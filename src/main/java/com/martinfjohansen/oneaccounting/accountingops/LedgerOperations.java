package com.martinfjohansen.oneaccounting.accountingops;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import Disk.Disk.DiskStructure;
import com.martinfjohansen.oneaccounting.Accounting.Accounting.Line;
import com.martinfjohansen.oneaccounting.Accounting.Accounting.Transaction;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.OneAccountingState;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static Bytes.Bytes.Bytes.*;
import static Disk.Disk.Disk.Read;
import static Disk.Disk.Disk.Write;
import static DiskRanges.DiskRanges.DiskRanges.ReadRange;
import static DiskRanges.DiskRanges.DiskRanges.WriteRange;
import static JSON.Parser.Parser.ReadJSON;
import static JSON.Writer.Writer.WriteJSON;
import static JSON.Writer.Writer.WriteJSONFromStruct;
import static Unicode.Unicode.Unicode.UTF16ToUTF8;
import static Unicode.Unicode.Unicode.UTF8ToUTF16;
import static com.martinfjohansen.oneaccounting.Accounting.Accounting.Accounting.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.DateFromStringISO8601;

public class LedgerOperations {
    public static boolean AddTransactionToLedger(DiskStructure disk, OneAccountingState state, StringReference message) {
        boolean success;
        Transaction t;

        double amount = 125;
        Date from = DateFromStringISO8601("2026-11-22".toCharArray());

        t = new Transaction();
        t.lines = new Line[2];
        t.lines[0] = CreateLineFromScript(state.ledger, ("Debit, 1.8.1, "+(int)amount+", x").toCharArray(), from);
        t.lines[1] = CreateLineFromScript(state.ledger, ("Credit, 3.4.2, "+(int)amount+", x").toCharArray(), from);

        success = ValidateAndAddTransactionToLedger(state.ledger, t.lines);

        return success;
    }
}
