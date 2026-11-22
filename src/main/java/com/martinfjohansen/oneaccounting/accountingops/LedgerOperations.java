package com.martinfjohansen.oneaccounting.accountingops;

import com.martinfjohansen.oneaccounting.Accounting.Accounting.Line;
import com.martinfjohansen.oneaccounting.Accounting.Accounting.Transaction;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Array;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.OneAccountingState;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.Accounting.Accounting.Accounting.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.Assign15d;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.DateFromStringISO8601;

public class LedgerOperations {
    public static boolean AddTransactionToLedger(Structure input, OneAccountingState state, StringReference message) {
        boolean success;
        Transaction t;
        FixedPoint15d d, c;
        char [] dateStr, type, account;
        Structure line;
        double i, amount, lineCount;

        dateStr = GetStringFromStruct(input, "date".toCharArray());
        Date date = DateFromStringISO8601(dateStr);

        t = new Transaction();

        char [] description = GetStringFromStruct(input, "description".toCharArray());

        c = CreateFixedPointForDynamicLedger(state.ledger);
        d = CreateFixedPointForDynamicLedger(state.ledger);

        Array lines = GetArrayFromStruct(input, "lines".toCharArray());

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

        return success;
    }
}
