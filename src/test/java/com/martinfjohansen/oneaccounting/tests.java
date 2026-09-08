package com.martinfjohansen.oneaccounting;

import com.martinfjohansen.oneaccounting.Accounting.Accounting.*;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Array;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.LinkedListCharacters;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.Accounting.Accounting.Accounting.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.*;
import static com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.LinkedListCharactersFunctions.LinkedListCharactersFunctions.*;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.CreateNumberFromDecimalString;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateNumberReference;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.*;
import static com.martinfjohansen.oneaccounting.testing.testing.*;

public class tests {
    public static double test(){
        NumberReference failures;

        failures = CreateNumberReference(0d);

        TestBasicAccounting(failures);
        TestAccruals(failures);
        TestIFRSAccountPlan(failures);

        return failures.numberValue;
    }

    public static void TestIFRSAccountPlan(NumberReference failures) {
        GetIFRSAccountPlan();
    }

    public static void TestBasicAccounting(NumberReference failures) {
        Structure ledger;
        FixedPoint15d c, d;
        Line[] transaction;
        boolean valid;
        Date date, from, to;
        Account account;
        char [] accountName, accountStr, desc;
        Ledger sledger;

        ledger = CreateLedger(2d);

        //c = CreateFixedPointForDynamicLedger(ledger);
        //d = CreateFixedPointForDynamicLedger(ledger);

        // Transaction 1:
        transaction = new Line[2];
        //date = CreateDate(2026d, 2d, 18d);
        date = DateFromStringISO8601("2026-02-18".toCharArray());

        // Debit, 100, 1000, l1, 2026-02-18
        /*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
        */
        transaction[0] = CreateLineFromScript(ledger, "Debit, 1000, 100, l1".toCharArray(), date);

        // Credit, 100, 2000, l2, 2026-02-18
        /*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
        */
        transaction[1] = CreateLineFromScript(ledger, "Credit, 2000, 100, l2".toCharArray(), date);

        valid = ValidateAndAddTransactionToLedger(ledger, transaction);

        AssertTrue(valid, failures);

        // Compute
        sledger = LedgerDynamicToStatic(ledger);

        accountName = "1000".toCharArray();
        from = DateFromStringISO8601("2026-02-17".toCharArray());
        to = DateFromStringISO8601("2026-02-19".toCharArray());
        account = ComputeAccountBalance(sledger, accountName, from, to);

        accountStr = AccountToString(account);

        //System.out.println(accountStr);

        AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)".toCharArray(), failures);
    }

    public static void TestAccruals(NumberReference failures) {
        Structure ledger;
        FixedPoint15d c, d;
        Line[] transaction;
        boolean valid, success;
        Date date, from, to;
        Account account;
        char [] accountName, desc, accountStr, accountSummaryStr;
        Ledger sledger;
        double[] amounts;
        double i;
        AccountDefinition assetsDef, liabilitiesDef, equitiesDef, incomeDef, expensesDef, accountDef;
        AccountDefinition a148, a150, a192, a290, a300, a600;
        AccountPlan accountPlan;
        DataReference balanceSheetRef;
        char [] html;
        StringReference message;
        Array balances;

        ledger = CreateLedger(2d);

        c = CreateFixedPointForDynamicLedger(ledger);
        d = CreateFixedPointForDynamicLedger(ledger);

        /* Case:
           * A domain is renewed for the period 2025-12-06 - 2026-12-05.
           * it is invoiced 2025-09-17 with a due date 2025-10-01, amount 125.00
           * It is paid 2025-10-01.
           * It is renewed 2025-11-08 by paying the renewal fee 112.50
           * The domain must be correctly accounted for using accruals for each month
         */

        // 1.8.1. Loans and receivables
        // 3.4.2. Deferred income and refund liabilities

        // 1.11.1. Cash
        // 1.8.1. Loans and receivables

        // 3.4.2. Deferred income and refund liabilities
        // 4.1.2 Services

        // 1.11.1. Cash
        // 1.7.1. Prepayments

        // 5.1.3. Services expense
        // 1.7.1. Prepayments

        // Transaction: Invoice sent
        transaction = new Line[2];
        date = DateFromStringISO8601("2025-09-17".toCharArray());
        transaction[0] = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x".toCharArray(), date);
        transaction[1] = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x".toCharArray(), date);
        valid = ValidateAndAddTransactionToLedger(ledger, transaction);
        AssertTrue(valid, failures);

        // Transaction: Invoice paid
        transaction = new Line[2];
        date = DateFromStringISO8601("2025-10-01".toCharArray());
        transaction[0] = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x".toCharArray(), date);
        transaction[1] = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x".toCharArray(), date);
        valid = ValidateAndAddTransactionToLedger(ledger, transaction);
        AssertTrue(valid, failures);

        // Transaction: Renewal paid
        transaction = new Line[2];
        date = DateFromStringISO8601("2025-11-08".toCharArray());
        transaction[0] = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x".toCharArray(), date);
        transaction[1] = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x".toCharArray(), date);
        valid = ValidateAndAddTransactionToLedger(ledger, transaction);
        AssertTrue(valid, failures);

        // Accruals income
        from = DateFromStringISO8601("2025-12-06".toCharArray());
        to = DateFromStringISO8601("2026-12-05".toCharArray());
        AddMonthlyAccruals(ledger, from, to, 125d, "3.4.2".toCharArray(), "4.1.2".toCharArray());

        // Accruals cost
        from = DateFromStringISO8601("2025-12-06".toCharArray());
        to = DateFromStringISO8601("2026-12-05".toCharArray());
        AddMonthlyAccruals(ledger, from, to, 112.50, "5.1.3".toCharArray(), "1.7.1".toCharArray());

        // Compute
        sledger = LedgerDynamicToStatic(ledger);

        from = DateFromStringISO8601("2027-01-01".toCharArray());
        to = DateFromStringISO8601("2027-01-01".toCharArray());

        account = ComputeAccountBalance(sledger, "5.1.3".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "4.1.2".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "1.8.1".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "3.4.2".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "1.11.1".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "1.7.1".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        //System.out.println("");

        // In between
        from = DateFromStringISO8601("2026-06-15".toCharArray());
        to = DateFromStringISO8601("2026-06-16".toCharArray());

        account = ComputeAccountBalance(sledger, "5.1.3".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "4.1.2".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "1.8.1".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "3.4.2".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "1.11.1".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        account = ComputeAccountBalance(sledger, "1.7.1".toCharArray(), from, to);
        accountStr = AccountToString(account);
        //System.out.println(accountStr);
        AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)".toCharArray(), failures);

        // Balance Sheet: Snapshots a companys assets, liabilities, and equity at a specific point in time.
        // Income Statement (P&L): Shows revenue, expenses, and profit/loss over a period.
        // Cash Flow Statement: Tracks cash inflow and outflow from operating, investing, and financing activities.
        // Statement of Shareholders' Equity: Details changes in owner interest over time.

        /*accountPlan = new AccountPlan();
        accountPlan.accountDefinitions = new AccountDefinition[11];
        assetsDef = CreateAccountDefinition("Assets".toCharArray(), "1".toCharArray(), "Assets".toCharArray(), true);
        a148 = CreateAccountDefinition("Forskuddsbetalt leverandor".toCharArray(), "1.4".toCharArray(), "".toCharArray(), true);
        a150 = CreateAccountDefinition("Kundefordringer".toCharArray(), "1.5".toCharArray(), "".toCharArray(), true);
        a192 = CreateAccountDefinition("Bankinnskudd".toCharArray(), "1.9".toCharArray(), "".toCharArray(), true);
        liabilitiesDef = CreateAccountDefinition("Liabilities".toCharArray(), "2".toCharArray(), "Liabilities".toCharArray(), false);
        a290 = CreateAccountDefinition("Forskuddsbetalt inntekt/kortsiktig gjeld".toCharArray(), "2.9".toCharArray(), "".toCharArray(), true);
        equitiesDef = CreateAccountDefinition("Equities".toCharArray(), "4".toCharArray(), "Equities".toCharArray(), false);
        incomeDef = CreateAccountDefinition("Income".toCharArray(), "3".toCharArray(), "Revenue".toCharArray(), false);
        a300 = CreateAccountDefinition("Salgsinntekt".toCharArray(), "2.9".toCharArray(), "".toCharArray(), true);
        expensesDef = CreateAccountDefinition("Expenses".toCharArray(), "6".toCharArray(), "Expenses".toCharArray(), true);
        a600 = CreateAccountDefinition("Domenekostnader".toCharArray(), "6.0".toCharArray(), "".toCharArray(), true);

        accountPlan.accountDefinitions[0] = assetsDef;
        accountPlan.accountDefinitions[1] = a148;
        accountPlan.accountDefinitions[2] = a150;
        accountPlan.accountDefinitions[3] = a192;
        accountPlan.accountDefinitions[4] = liabilitiesDef;
        accountPlan.accountDefinitions[5] = a290;
        accountPlan.accountDefinitions[6] = equitiesDef;
        accountPlan.accountDefinitions[7] = incomeDef;
        accountPlan.accountDefinitions[8] = a300;
        accountPlan.accountDefinitions[9] = expensesDef;
        accountPlan.accountDefinitions[10] = a600;
        sledger.accountPlan = accountPlan*/

        sledger.accountPlan = GetIFRSAccountPlan();

        to = DateFromStringISO8601("2026-02-16".toCharArray());
        balanceSheetRef = new DataReference();
        success = ComputeAccountBalances(sledger, 2d, to, balanceSheetRef);
        accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure);
        AssertTrue(success, failures);
        //System.out.println(accountSummaryStr);

        // Compute monthly table
        to = DateFromStringISO8601("2025-08-01".toCharArray());
        message = new StringReference();
        AddDaysToDate(to, -1d, message);
        balances = CreateArray();
        for(i = 0; i < 12d+6d; i = i + 1d){
            AddDaysToDate(to, 1d, message);
            AddMonthsToDate(to, 1d);
            AddDaysToDate(to, -1d, message);

            balanceSheetRef = new DataReference();
            success = ComputeAccountBalances(sledger, 1d, to, balanceSheetRef);

            if(success){
                AddStructToArray(balances, balanceSheetRef.data.structure);
            }
        }
        ComputeBalanceDiffs(sledger, balances);

        html = BalancesArrayToHTML(balances, true, false);

        //StringToFile("x.html", html);

        html = BalancesArrayToHTML(balances, false, true);

        //StringToFile("x-diff.html", html);

        html = BalancesArrayToHTML(balances, true, true);

        //StringToFile("x-both.html", html);
    }

    /*public static void StringToFile(String filename, char[] html) {
        try {
            Files.writeString(Path.of(filename), new String(html), StandardCharsets.UTF_8);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }*/
}


































