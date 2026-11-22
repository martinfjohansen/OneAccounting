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
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.Assign15d;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.ToString15d;
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
            account = GetStringFromStruct(line, "type".toCharArray());

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

        accountStr = GetStringFromStruct(input, "account".toCharArray());
        fromStr = GetStringFromStruct(input, "from".toCharArray());
        from = DateFromStringISO8601(fromStr);
        toStr = GetStringFromStruct(input, "to".toCharArray());
        to = DateFromStringISO8601(toStr);

        sledger = LedgerDynamicToStatic(state.ledger);
        account = Accounting.ComputeAccountBalance(sledger, accountStr, from, to);

        accountStr = AccountToString(account);

        outputRef.data = CreateStringData(accountStr);

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

        success = false;
        message.string = "Not implemented.".toCharArray();

        return success;
    }
}
