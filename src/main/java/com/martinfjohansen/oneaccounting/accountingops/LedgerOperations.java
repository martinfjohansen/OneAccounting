package com.martinfjohansen.oneaccounting.accountingops;

import com.martinfjohansen.oneaccounting.Accounting.Accounting.*;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Array;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.OneAccountingState;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.Accounting.Accounting.Accounting.*;
import static com.martinfjohansen.oneaccounting.Accounting.Accounting.Accounting.ComputeAccountBalances;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.DateFromStringISO8601;

public class LedgerOperations {
    public static boolean AddTransactionToLedger(Structure input, OneAccountingState state, StringReference message) {
        boolean success;
        Transaction t;
        FixedPoint15d d, c;
        char [] dateStr, type, account, description;
        Structure line;
        double i, amount, lineCount;
        Date date;
        Array lines;

        dateStr = GetStringFromStruct(input, "date".toCharArray());
        date = DateFromStringISO8601(dateStr);

        t = new Transaction();

        description = GetStringFromStruct(input, "description".toCharArray());

        c = CreateFixedPointForDynamicLedger(state.ledger);
        d = CreateFixedPointForDynamicLedger(state.ledger);

        lines = GetArrayFromStruct(input, "lines".toCharArray());

        lineCount = ArrayLength(lines);

        t.lines = new Line[(int)lineCount];

        for(i = 0d; i < lineCount; i = i + 1d){
            line = ArrayIndexStruct(lines, i);

            amount = GetNumberFromStruct(line, "amount".toCharArray());
            type = GetStringFromStruct(line, "type".toCharArray());
            account = GetStringFromStruct(line, "account".toCharArray());

            if(arraysStringsEqual(type, "Debit".toCharArray())){
                Assign15d(d, amount);
                Assign15d(c, 0d);
            }else if(arraysStringsEqual(type, "Credit".toCharArray())){
                Assign15d(d, 0d);
                Assign15d(c, amount);
            }

            t.lines[(int)i] = CreateLine(account, d, c, description, date);
        }

        success = ValidateAndAddTransactionToLedger(state.ledger, t.lines);

        if(success){
        }else{
            message.string = "Invalid transaction.".toCharArray();
        }

        return success;
    }

    public static boolean ComputeAccountBalance(Structure input, DataReference outputRef, OneAccountingState state, StringReference message) {
        boolean success;
        Ledger sledger;
        Account account;
        char [] fromStr, toStr, accountStr;
        Date from, to;
        Structure output;
        FixedPoint15d diff;
        double outputFormat;

        accountStr = GetStringFromStruct(input, "account".toCharArray());
        fromStr = GetStringFromStruct(input, "from".toCharArray());
        from = DateFromStringISO8601(fromStr);
        toStr = GetStringFromStruct(input, "to".toCharArray());
        to = DateFromStringISO8601(toStr);

        sledger = LedgerDynamicToStatic(state.ledger);
        account = Accounting.ComputeAccountBalance(sledger, accountStr, from, to);

        diff = Copy15d(account.endingBalance);
        Subtract15d(diff, diff, account.startingBalance);

        output = CreateStructure();

        outputFormat = 1d;

        if(outputFormat == 0d){
            AddNumberToStruct(output, "start".toCharArray(), account.startingBalance.number);
            AddNumberToStruct(output, "end".toCharArray(), account.endingBalance.number);
            AddNumberToStruct(output, "change".toCharArray(), diff.number);
            AddNumberToStruct(output, "credit".toCharArray(), account.sumCredit.number);
            AddNumberToStruct(output, "debit".toCharArray(), account.sumDebit.number);
        }else if(outputFormat == 1d) {
            AddStringToStruct(output, "start".toCharArray(), FormatToStringWithSymbols15d(account.startingBalance, 2d, "".toCharArray(), ".".toCharArray()));
            AddStringToStruct(output, "end".toCharArray(), FormatToStringWithSymbols15d(account.endingBalance, 2d, "".toCharArray(), ".".toCharArray()));
            AddStringToStruct(output, "change".toCharArray(), FormatToStringWithSymbols15d(diff, 2d, "".toCharArray(), ".".toCharArray()));
            AddStringToStruct(output, "credit".toCharArray(), FormatToStringWithSymbols15d(account.sumCredit, 2d, "".toCharArray(), ".".toCharArray()));
            AddStringToStruct(output, "debit".toCharArray(), FormatToStringWithSymbols15d(account.sumDebit, 2d, "".toCharArray(), ".".toCharArray()));

        }else if(outputFormat == 2d) {
            accountStr = AccountToString(account);
            outputRef.data = CreateStringData(accountStr);
        }

        outputRef.data = CreateStructData(output);

        success = true;

        return success;
    }

    public static boolean ComputeAccountBalancePrefixAccount(Structure input, DataReference outputRef, OneAccountingState state, StringReference message) {
        /*boolean success;
        Ledger sledger;
        FixedPoint15d amount;
        char [] fromStr, toStr, accountStr, amountStr;
        Date from, to;

        accountStr = GetStringFromStruct(input, "account".toCharArray());
        fromStr = GetStringFromStruct(input, "from".toCharArray());
        from = DateFromStringISO8601(fromStr);
        toStr = GetStringFromStruct(input, "to".toCharArray());
        to = DateFromStringISO8601(toStr);

        sledger = LedgerDynamicToStatic(state.ledger);
        amount = Accounting.ComputeAccountBalancePrefixAccount(sledger, accountStr, to, true);

        amountStr = ToString15d(amount);

        outputRef.data = CreateStringData(amountStr);

        success = true;

        return success;*/

        boolean success;

        success = false;
        message.string = "Not implemented.".toCharArray();

        return success;
    }

    public static boolean AddMonthlyAccruals(Structure input, DataReference outputRef, OneAccountingState state, StringReference message) {
        boolean success;

        success = false;
        message.string = "Not implemented.".toCharArray();

        return success;
    }

    public static boolean ComputeAccountBalances(Structure input, DataReference outputRef, OneAccountingState state, StringReference message) {
        boolean success;
        Ledger sledger;
        char [] toStr, accountSummaryStr;
        Date to;
        DataReference balanceSheetRef;
        double outputFormat, depth;

        balanceSheetRef = new DataReference();

        toStr = GetStringFromStruct(input, "to".toCharArray());
        to = DateFromStringISO8601(toStr);

        depth = GetNumberFromStruct(input, "depth".toCharArray());

        //success = false;
        //message.string = "Not implemented.".toCharArray();

        sledger = LedgerDynamicToStatic(state.ledger);
        sledger.accountPlan = state.accountPlan;

        success = Accounting.ComputeAccountBalances(sledger, depth, to, balanceSheetRef);

        if(success) {

            outputFormat = 1d;

            if (outputFormat == 0d) {

            } else if (outputFormat == 1d) {
                accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure);
                outputRef.data = CreateStringData(accountSummaryStr);
            }
        }else{
            message.string = "Error computing account balances.".toCharArray();
        }

        return success;
    }

    public static boolean LoadIFRSAccountPlan(Structure structure, OneAccountingState state, StringReference message) {
        state.accountPlanSet = true;
        state.accountPlan = GetIFRSAccountPlan();

        return true;
    }
}
