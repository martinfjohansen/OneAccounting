package com.martinfjohansen.oneaccounting.Accounting.Accounting;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Array;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.LinkedListCharacters;
import com.martinfjohansen.oneaccounting.references.references.BooleanReference;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;
import static com.martinfjohansen.oneaccounting.references.references.references.*;

import com.martinfjohansen.oneaccounting.datetime.DateCalculations.*;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.*;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.*;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.*;

import static com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.LinkedListCharactersFunctions.LinkedListCharactersFunctions.*;

import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.*;

import static com.martinfjohansen.oneaccounting.Accrual.Accrual.Accrual.*;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.*;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;

import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.*;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.*;

import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.*;

import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.*;


public class Accounting{
	public static Structure CreateLedger(double decimals){
		Structure ledger;
		Array transactions;

		ledger = CreateStructure();
		transactions = CreateArray();
		AddNumberToStruct(ledger, "decimals".toCharArray(), decimals);
		AddArrayToStruct(ledger, "transactions".toCharArray(), transactions);

		return ledger;
	}

	public static FixedPoint15d CreateFixedPointForDynamicLedger(Structure ledger){
		FixedPoint15d n;
		double d;

		d = GetNumberFromStruct(ledger, "decimals".toCharArray());
		n = CreateFixedPoint15d(15d - d, d);

		return n;
	}

	public static FixedPoint15d CreateFixedPointForStaticLedger(Ledger ledger){
		FixedPoint15d n;
		double d;

		d = ledger.decimals;
		n = CreateFixedPoint15d(15d - d, d);

		return n;
	}

	public static Line CreateLine(char [] account, FixedPoint15d debit, FixedPoint15d credit, char [] description, Date date){
		Line t;

		t = new Line();

		t.account = arraysCopyString(account);
		t.debit = Copy15d(debit);
		t.credit = Copy15d(credit);
		t.description = arraysCopyString(description);
		t.date = CopyDate(date);

		return t;
	}

	public static void AddTransactionToLedger(Array ledger, Line src){
		Structure dst;

		dst = LineToStructure(src);

		AddStructToArray(ledger, dst);
	}

	public static void AddTransactionsToLedger(Array ledger, Line [] ts){
		Structure dst;
		double i;

		for(i = 0d; i < ts.length; i = i + 1d){
			dst = LineToStructure(ts[(int)(i)]);
			AddStructToArray(ledger, dst);
		}
	}

	public static boolean ValidateAndAddTransactionToLedger(Structure ledger, Line [] ls){
		Structure dst;
		double i;
		boolean valid;
		Array transactions;
		Array lines;

		transactions = GetArrayFromStruct(ledger, "transactions".toCharArray());

		valid = ValidateTransaction(ls, ledger);

		if(valid){
			lines = CreateArray();

			for(i = 0d; i < ls.length; i = i + 1d){
				dst = LineToStructure(ls[(int)(i)]);
				AddStructToArray(lines, dst);
			}

			AddArrayToArray(transactions, lines);
		}

		return valid;
	}

	public static Line GetTransactionFromLedger(Structure ledger, double index){
		Structure dst;
		Line t;
		Array transactions;
		double decimals;

		transactions = GetArrayFromStruct(ledger, "transactions".toCharArray());
		decimals = GetNumberFromStruct(ledger, "decimals".toCharArray());

		dst = ArrayIndexStruct(transactions, index);

		t = LineFromStructure(dst, ledger);

		return t;
	}

	public static Structure LineToStructure(Line src){
		Structure dst;
		char [] debitStr, creditStr, dateStr;

		dst = CreateStructure();

		debitStr = ToString15d(src.debit);
		creditStr = ToString15d(src.credit);
		dateStr = DateToStringISO8601(src.date);

		AddStringToStruct(dst, "account".toCharArray(), src.account);
		AddStringToStruct(dst, "debit".toCharArray(), debitStr);
		AddStringToStruct(dst, "credit".toCharArray(), creditStr);
		AddStringToStruct(dst, "date".toCharArray(), dateStr);
		AddStringToStruct(dst, "description".toCharArray(), src.description);

		return dst;
	}

	public static Line LineFromStructure(Structure src, Structure ledger){
		Line dst;
		char [] account, debitStr, creditStr, dateStr, description;
		FixedPoint15d debit, credit;
		Date date;
		double debitNumber, creditNumber;

		account = GetStringFromStruct(src, "account".toCharArray());
		debitStr = GetStringFromStruct(src, "debit".toCharArray());
		creditStr = GetStringFromStruct(src, "credit".toCharArray());
		dateStr = GetStringFromStruct(src, "date".toCharArray());
		description = GetStringFromStruct(src, "description".toCharArray());

		debitNumber = CreateNumberFromDecimalString(debitStr);
		creditNumber = CreateNumberFromDecimalString(creditStr);

		debit = CreateFixedPointForDynamicLedger(ledger);
		credit = CreateFixedPointForDynamicLedger(ledger);
		Assign15d(debit, debitNumber);
		Assign15d(credit, creditNumber);

		date = DateFromStringISO8601(dateStr);

		dst = CreateLine(account, debit, credit, description, date);

		return dst;
	}

	public static Ledger LedgerDynamicToStatic(Structure src){
		Ledger dst;
		double ts, ls, i, j, decimals;
		Structure line;
		Array transactions, lines;
		Line sline;
		Transaction t;

		dst = new Ledger();

		transactions = GetArrayFromStruct(src, "transactions".toCharArray());
		decimals = GetNumberFromStruct(src, "decimals".toCharArray());
		ts = ArrayLength(transactions);

		dst.decimals = decimals;
		dst.transactions = new Transaction [(int)(ts)];

		for(i = 0d; i < ts; i = i + 1d){
			lines = ArrayIndexArray(transactions, i);
			ls = ArrayLength(lines);

			t = new Transaction();
			t.lines = new Line [(int)(ls)];

			for(j = 0d; j < ls; j = j + 1d){
				line = ArrayIndexStruct(lines, j);
				sline = LineFromStructure(line, src);
				t.lines[(int)(j)] = sline;
			}

			dst.transactions[(int)(i)] = t;
		}

		return dst;
	}

	public static boolean ValidateTransaction(Line [] ts, Structure ledger){
		boolean valid;
		FixedPoint15d creditSum, debitSum;
		double i, d, c;
		Line t;
		char [] creditStr, debitStr;
		Date date;

		valid = true;

		if(ts.length > 0d){
			date = ts[0].date;

			creditSum = CreateFixedPointForDynamicLedger(ledger);
			debitSum = CreateFixedPointForDynamicLedger(ledger);

			for(i = 0d; i < ts.length && valid; i = i + 1d){
				t = ts[(int)(i)];

				d = ToNumber15d(t.debit);
				c = ToNumber15d(t.credit);

				Add15d(creditSum, creditSum, t.credit);
				Add15d(debitSum, debitSum, t.debit);

				if(DateEquals(date, t.date) && (d == 0d || c == 0d)){
				}else{
					valid = false;
				}
			}

			if(valid){
				creditStr = ToString15d(creditSum);
				debitStr = ToString15d(creditSum);

				valid = arraysStringsEqual(creditStr, debitStr);
			}
		}

		return valid;
	}

	public static boolean ValidateTransactions(Line [] ts, NumberArrayReference invalidIds){
		boolean valid;

		/* TODO*/
		valid = true;

		return valid;
	}

	public static Account ComputeAccountBalance(Ledger ledger, char [] accountName, Date fromDate, Date toDate){
		Account a;
		double i, j;
		Transaction t;
		Transaction [] ts;
		Line l;

		ts = ledger.transactions;

		a = new Account();

		a.name = arraysCopyString(accountName);
		a.endingBalance = CreateFixedPointForStaticLedger(ledger);
		a.startingBalance = CreateFixedPointForStaticLedger(ledger);
		a.from = CopyDate(fromDate);
		a.to = CopyDate(toDate);
		a.sumDebit = CreateFixedPointForStaticLedger(ledger);
		a.sumCredit = CreateFixedPointForStaticLedger(ledger);

		for(i = 0d; i < ts.length; i = i + 1d){
			t = ts[(int)(i)];

			for(j = 0d; j < t.lines.length; j = j + 1d){
				l = t.lines[(int)(j)];

				if(arraysStringsEqual(l.account, accountName)){

					if(DateLessThan(l.date, fromDate)){
						Add15d(a.startingBalance, a.startingBalance, l.debit);
						Subtract15d(a.startingBalance, a.startingBalance, l.credit);
					}else if(DateLessThan(l.date, toDate)){
						Add15d(a.endingBalance, a.endingBalance, l.debit);
						Subtract15d(a.endingBalance, a.endingBalance, l.credit);

						Add15d(a.sumDebit, a.sumDebit, l.debit);
						Add15d(a.sumCredit, a.sumCredit, l.credit);
					}
				}
			}
		}

		Add15d(a.endingBalance, a.endingBalance, a.startingBalance);

		return a;
	}

	public static char [] AccountToString(Account account){
		LinkedListCharacters ll;
		FixedPoint15d diff;

		ll = CreateLinkedListCharacter();

		diff = Copy15d(account.endingBalance);
		Subtract15d(diff, diff, account.startingBalance);

		LinkedListCharactersAddString(ll, account.name);
		LinkedListCharactersAddString(ll, ": ".toCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.startingBalance, 2d, "".toCharArray(), ".".toCharArray()));
		LinkedListCharactersAddString(ll, " -> ".toCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.endingBalance, 2d, "".toCharArray(), ".".toCharArray()));
		LinkedListCharactersAddString(ll, ": ".toCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2d, ",".toCharArray(), ".".toCharArray()));
		LinkedListCharactersAddString(ll, " (+".toCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumDebit, 2d, "".toCharArray(), ".".toCharArray()));
		LinkedListCharactersAddString(ll, ", -".toCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumCredit, 2d, "".toCharArray(), ".".toCharArray()));
		LinkedListCharactersAddString(ll, ")".toCharArray());

		return LinkedListCharactersToArray(ll);
	}

	public static void AddMonthlyAccruals(Structure ledger, Date from, Date to, double amount, char [] fromAccount, char [] toAccount){
		double i;
		char [] accountName, desc;
		double [] amounts;
		Line [] transaction;
		boolean valid;
		Date date;
		FixedPoint15d c, d;

		amounts = GetAccrualsWithDates(amount, from, to);

		date = CopyDate(from);
		date.day = 1d;

		c = CreateFixedPointForDynamicLedger(ledger);
		d = CreateFixedPointForDynamicLedger(ledger);

		for(i = 0d; i < amounts.length; i = i + 1d){
			transaction = new Line [2];

			accountName = fromAccount;
			Assign15d(d, amounts[(int)(i)]);
			Assign15d(c, 0d);
			desc = "x".toCharArray();
			transaction[0] = CreateLine(accountName, d, c, desc, date);

			accountName = toAccount;
			Assign15d(d, 0d);
			Assign15d(c, amounts[(int)(i)]);
			desc = "x".toCharArray();
			transaction[1] = CreateLine(accountName, d, c, desc, date);

			valid = ValidateAndAddTransactionToLedger(ledger, transaction);

			AddMonthsToDate(date, 1d);
		}
	}

	public static FixedPoint15d ComputeAccountBalancePrefixAccount(Ledger ledger, char [] accountNr, Date toDate, boolean debitBalance){
		double i, j;
		Transaction t;
		Transaction [] ts;
		Line l;
		FixedPoint15d balance;
		LinkedListCharacters prefixL;
		char [] prefixed;

		prefixL = CreateLinkedListCharacter();
		LinkedListCharactersAddString(prefixL, accountNr);
		LinkedListCharactersAddString(prefixL, ".".toCharArray());

		prefixed = LinkedListCharactersToArray(prefixL);

		ts = ledger.transactions;

		balance = CreateFixedPointForStaticLedger(ledger);

		for(i = 0d; i < ts.length; i = i + 1d){
			t = ts[(int)(i)];

			for(j = 0d; j < t.lines.length; j = j + 1d){
				l = t.lines[(int)(j)];

				if(strStartsWith(l.account, prefixed) || arraysStringsEqual(l.account, accountNr)){
					if(DateLessThan(l.date, toDate) || DateEquals(l.date, toDate)){
						if(debitBalance){
							Add15d(balance, balance, l.debit);
							Subtract15d(balance, balance, l.credit);
						}else{
							Add15d(balance, balance, l.credit);
							Subtract15d(balance, balance, l.debit);
						}
					}
				}
			}
		}

		return balance;
	}

	public static AccountPlan GetIFRSAccountPlan(){
		char [] accountPlanString;
		BooleanReference validRef;
		LinkedListCharacters ll;

		ll = CreateLinkedListCharacter();

		/* https://www.ifrs-gaap.com/ifrs-chart-accounts*/
		validRef = CreateBooleanReference(false);

		LinkedListCharactersAddString(ll, "1\tAssets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1\tProperty, plant and equipment\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.1\tLand and land improvements\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.2\tBuildings, structures and improvements\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.3\tMachinery and equipment\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.4\tFixtures and fittings\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.5\tRight of use assets (classified as PP&E)\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.6\tAdditional property, plant and equipment\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1.7\tConstruction in progress\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.2\tInvestment property\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.2.1\tCompleted\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.2.2\tUnder construction or development\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.3\tGoodwill\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4\tIntangible assets excluding goodwill\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.1\tIntellectual property\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.2\tComputer software\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.3\tTrade and distribution assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.4\tContracts and rights\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.5\tRight of use assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.6\tCrypto assets (classified as intangible)\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.7\tAdditional intangible assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.4.8\tAcquisition in progress\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.5\tFinancial assets and investments\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.5.1\tNon-derivative financial assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.5.2\tDerivative financial assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.5.3\tAdditional financial assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.5.4\tCrypto assets (classified as financial assets)\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.6\tInventories\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.6.1\tMerchandise\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.6.2\tRaw materials and production supplies\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.6.3\tWork in progress\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.6.4\tFinished goods\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.6.5\tOther inventories\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.7\tPrepayments and accrued income\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.7.1\tPrepayments\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.7.2\tAccrued income\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.7.3\tService provider work in process (not classified as inventory)\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.7.4\tAdditional assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.8\tReceivables and contracts\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.8.1\tLoans and receivables\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.8.2\tContracts with customers\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.8.3\tNontrade and other receivables\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.9\tTax assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.9.1\tTax assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.9.2\tDeferred tax assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.9.3\tOther tax assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.1\tAgricultural biological assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.10.1\tBearer plants\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.10.2\tAnimals\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.10.3\tOther agricultural assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.11\tCash and cash equivalents\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.11.1\tCash\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.11.2\tCash equivalents\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "1.11.3\tRestricted cash and financial assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "2\tEquity\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.1\tTotal equity attributable to owners of parent\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.1.1\tIssued capital\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.1.2\tAdditional item paid-in capital\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.1.3\tPartner\'s capital\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.1.4\tMember\'s equity\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.1.5\tOther equity interest\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.2\tRetained earnings\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.2.3\tIn suspense\tZero\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.3\tAccumulated other comprehensive income\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.3.2\tMiscellaneous equity\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.4\tOwners equity (non-shareholder)\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "2.5\tNon-controlling interests\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3\tLiabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.1\tTrade and other payables\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.1.1\tTrade payables\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.1.2\tDividend payables\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.1.3\tInterest payable\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.1.4\tOther payables\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.2\tProvisions\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.2.1\tCustomer related provisions\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.2.2\tLitigation and regulatory\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.2.3\tAdditional provisions\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3\tOther financial liabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3.1\tNotes payable\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3.2\tLoans received\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3.3\tBonds (debentures)\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3.4\tOther debts and borrowings\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3.5\tLease obligations\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.3.6\tDerivative financial liabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.4.1\tAccruals\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.4.2\tDeferred income and refund liabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.4.3\tAccrued taxes other than payroll\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "3.4.4\tAdditional liabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4\tRevenue\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.1\tRecognized point of time\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.1.1\tGoods\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.1.2\tServices\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.2\tRecognized over time\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.2.1\tProducts and projects\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.2.2\tServices\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.3\tAdjustments\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.3.1\tVariable consideration\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.3.2\tConsideration paid payable to customers\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "4.3.3\tOther adjustments\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5\tExpenses\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1\tExpenses (classified by nature)\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1.1\tMaterial and merchandise\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1.2\tEmployee benefits expense\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1.3\tServices expense\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1.4\tRent, depreciation, amortization and depletion\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.1.6\tOther work performed by entity and capitalized\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.2\tExpenses (classified by function)\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.2.1\tCost of sales\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "5.2.2\tSelling, general and administrative expense\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "6\tOther non-operating income and expenses\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "6.1\tOther revenue and expenses\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "6.1.1\tOther revenue\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "6.1.2\tOther expenses\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "6.2\tGains and losses\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "6.3\tTaxes other than income and payroll and fees\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "6.4\tTax income (expense)\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7\tIntercompany and related party accounts\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.1\tIntercompany and related party assets\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.1.1\tIntercompany balances eliminated in consolidation\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.1.2\tRelated party balances reported or disclosed\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.1.3\tIntercompany investments\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.2\tIntercompany and related party liabilities\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.2.2\tRelated party balances reported or disclosed\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.3\tIntercompany and related party income and expense\tDr or (Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.3.1\tIntercompany and related party income\t(Cr)\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.3.2\tIntercompany and related party expenses\tDr\n".toCharArray());
		LinkedListCharactersAddString(ll, "7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n".toCharArray());

		accountPlanString = LinkedListCharactersToArray(ll);

		FreeLinkedListCharacter(ll);

		return ParseAccountPlanString(accountPlanString, validRef);
	}

	public static AccountPlan ParseAccountPlanString(char [] accountPlanString, BooleanReference valid){
		AccountPlan ap;
		double i;
		char [] line;
		StringReference[] lines, parts;
		AccountDefinition ad;

		ap = new AccountPlan();

		accountPlanString = strTrim(accountPlanString);
		lines = strSplitByCharacter(accountPlanString, '\n');

		ap.accountDefinitions = new AccountDefinition [(int)(lines.length)];

		for(i = 0d; i < lines.length; i = i + 1d){
			line = lines[(int)(i)].string;
			/*System.out.println(line);*/
			parts = strSplitByCharacter(line, '\t');

			ad = new AccountDefinition();

			ad.accountName = parts[1].string;
			ad.number = parts[0].string;
			if(arraysStringsEqual(parts[2].string, "(Cr)".toCharArray())){
				ad.debitBalance = false;
			}else{
				ad.debitBalance = true;
			}
			ad.role = "".toCharArray();
			if(arraysStringsEqual(ad.number, "1".toCharArray())){
				ad.role = "Assets".toCharArray();
			}else if(arraysStringsEqual(ad.number, "2".toCharArray())){
				ad.role = "Equities".toCharArray();
			}else if(arraysStringsEqual(ad.number, "3".toCharArray())){
				ad.role = "Liabilities".toCharArray();
			}else if(arraysStringsEqual(ad.number, "4".toCharArray())){
				ad.role = "Revenue".toCharArray();
			}else if(arraysStringsEqual(ad.number, "5".toCharArray())){
				ad.role = "Expenses".toCharArray();
			}

			ap.accountDefinitions[(int)(i)] = ad;
		}

		return ap;
	}

	public static boolean ComputeAccountBalances(Ledger sledger, double depth, Date date, DataReference balanceSheet){
		AccountPlan accountPlan;
		FixedPoint15d assetsBalance, liabilitiesBalance, equitiesBalance, revenueBalanace, expensesBalance, resultBalance, sum, balance;
		char [] balanceStr;
		AccountDefinition assetsDef, liabilitiesDef, equitiesDef, revenueDef, expensesDef, accountDef;
		boolean success, isBalanced;
		double i;
		StringReference [] parts;
		BooleanReference foundRef;
		Array accounts;
		Structure account;
		char [] dateStr;

		balanceSheet.data = CreateNewStructData();
		success = true;

		foundRef = CreateBooleanReference(false);

		accountPlan = sledger.accountPlan;

		assetsDef = FindAccountWithRole(accountPlan, "Assets".toCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		liabilitiesDef = FindAccountWithRole(accountPlan, "Liabilities".toCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		equitiesDef = FindAccountWithRole(accountPlan, "Equities".toCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		revenueDef = FindAccountWithRole(accountPlan, "Revenue".toCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		expensesDef = FindAccountWithRole(accountPlan, "Expenses".toCharArray(), foundRef);
		success = success && foundRef.booleanValue;

		if(success){
			assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.number, date, assetsDef.debitBalance);
			liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.number, date, liabilitiesDef.debitBalance);

			/* TODO: This must be for a period*/
			revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.number, date, revenueDef.debitBalance);
			expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.number, date, expensesDef.debitBalance);
			resultBalance = CreateFixedPointForStaticLedger(sledger);
			Subtract15d(resultBalance, revenueBalanace, expensesBalance);
			balanceStr = FormatToStringWithSymbols15d(resultBalance, 2d, "".toCharArray(), ".".toCharArray());
			AddStringToStruct(balanceSheet.data.structure, "result".toCharArray(), balanceStr);

			equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.number, date, equitiesDef.debitBalance);
			Add15d(equitiesBalance, equitiesBalance, resultBalance);

			/* Compute accounts*/
			accounts = CreateArray();

			for(i = 0d; i < accountPlan.accountDefinitions.length; i = i + 1d){
				accountDef = accountPlan.accountDefinitions[(int)(i)];

				parts = strSplitByCharacter(accountDef.number, '.');

				if(parts.length <= depth + 1d){
					account = CreateStructure();

					balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.number, date, accountDef.debitBalance);

					balanceStr = FormatToStringWithSymbols15d(balance, 2d, "".toCharArray(), ".".toCharArray());

					AddStringToStruct(account, "number".toCharArray(), accountDef.number);
					AddStringToStruct(account, "name".toCharArray(), accountDef.accountName);
					AddStringToStruct(account, "balance".toCharArray(), balanceStr);
					AddNumberToStruct(account, "depth".toCharArray(), parts.length - 1d);

					AddStructToArray(accounts, account);
				}
			}

			AddArrayToStruct(balanceSheet.data.structure, "accounts".toCharArray(), accounts);

			/* End conclusion*/
			balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2d, "".toCharArray(), ".".toCharArray());
			AddStringToStruct(balanceSheet.data.structure, "assets".toCharArray(), balanceStr);

			sum = CreateFixedPointForStaticLedger(sledger);
			Add15d(sum, liabilitiesBalance, equitiesBalance);
			balanceStr = FormatToStringWithSymbols15d(sum, 2d, "".toCharArray(), ".".toCharArray());
			AddStringToStruct(balanceSheet.data.structure, "liabilitiesAndEquity".toCharArray(), balanceStr);

			isBalanced = Equals15d(sum, assetsBalance);
			AddBooleanToStruct(balanceSheet.data.structure, "balanced".toCharArray(), isBalanced);

			dateStr = DateToStringISO8601(date);
			AddStringToStruct(balanceSheet.data.structure, "date".toCharArray(), dateStr);
		}

		return success;
	}

	public static char [] AccountBalancesToString(Structure balanceSheet){
		LinkedListCharacters ll;
		char [] balanceStr;
		boolean isBalanced;
		double i, j, depth;
		Array accounts;
		Structure account;
		char [] accountNumber, accountName;

		ll = CreateLinkedListCharacter();

		/* Print accounts*/
		accounts = GetArrayFromStruct(balanceSheet, "accounts".toCharArray());

		for(i = 0d; i < ArrayLength(accounts); i = i + 1d){
			account = ArrayIndexStruct(accounts, i);

			accountNumber = GetStringFromStruct(account, "number".toCharArray());
			accountName = GetStringFromStruct(account, "name".toCharArray());
			balanceStr = GetStringFromStruct(account, "balance".toCharArray());
			depth = GetNumberFromStruct(account, "depth".toCharArray());

			for(j = 0d; j < depth; j = j + 1d){
				LinkedListCharactersAddString(ll, "  ".toCharArray());
			}

			LinkedListCharactersAddString(ll, accountNumber);
			LinkedListCharactersAddString(ll, ". ".toCharArray());
			LinkedListCharactersAddString(ll, accountName);
			LinkedListCharactersAddString(ll, ": ".toCharArray());
			LinkedListCharactersAddString(ll, balanceStr);
			LinkedListCharactersAddString(ll, "\n".toCharArray());
		}

		/* End conclusion*/
		LinkedListCharactersAddString(ll, "\n".toCharArray());

		LinkedListCharactersAddString(ll, "Result: ".toCharArray());
		balanceStr = GetStringFromStruct(balanceSheet, "result".toCharArray());
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".toCharArray());

		LinkedListCharactersAddString(ll, "Assets: ".toCharArray());
		balanceStr = GetStringFromStruct(balanceSheet, "assets".toCharArray());
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".toCharArray());

		LinkedListCharactersAddString(ll, "Liabilities + Equities: ".toCharArray());
		balanceStr = GetStringFromStruct(balanceSheet, "liabilitiesAndEquity".toCharArray());
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".toCharArray());

		isBalanced = GetBooleanFromStruct(balanceSheet, "balanced".toCharArray());
		LinkedListCharactersAddString(ll, "Balance: ".toCharArray());
		if(isBalanced){
			LinkedListCharactersAddString(ll, "true".toCharArray());
		}else{
			LinkedListCharactersAddString(ll, "false".toCharArray());
		}
		LinkedListCharactersAddString(ll, "\n".toCharArray());

		return LinkedListCharactersToArray(ll);
	}

	public static AccountDefinition FindAccountWithRole(AccountPlan accountPlan, char [] role, BooleanReference foundRef){
		double i;
		AccountDefinition ad;
		boolean done;

		ad = new AccountDefinition();

		done = false;
		for(i = 0d; i < accountPlan.accountDefinitions.length && !done; i = i + 1d){
			ad = accountPlan.accountDefinitions[(int)(i)];
			if(arraysStringsEqual(ad.role, role)){
				done = true;
			}
		}

		foundRef.booleanValue = done;

		return ad;
	}

	public static AccountDefinition CreateAccountDefinition(char [] name, char [] number, char [] role, boolean debitBalance){
		AccountDefinition def;

		def = new AccountDefinition();
		def.accountName = name;
		def.number = number;
		def.role = role;
		def.debitBalance = debitBalance;

		return def;
	}

	public static void ComputeBalanceDiffs(Ledger sledger, Array balances){
		double i, j;
		Structure balance, first, balance1, balance2;
		Structure account1, account2;
		char [] b1, b2, diffStr;
		FixedPoint15d f1, f2, diff;
		Array accountsO, accounts1, accounts2;

		first = ArrayIndexStruct(balances, 0d);
		accountsO = GetArrayFromStruct(first, "accounts".toCharArray());

		for(j = 0d; j < ArrayLength(accountsO); j = j + 1d){
			for(i = 1d; i < ArrayLength(balances); i = i + 1d){
				balance1 = ArrayIndexStruct(balances, i - 1d);
				balance2 = ArrayIndexStruct(balances, i);
				accounts1 = GetArrayFromStruct(balance1, "accounts".toCharArray());
				accounts2 = GetArrayFromStruct(balance2, "accounts".toCharArray());

				account1 = ArrayIndexStruct(accounts1, j);
				account2 = ArrayIndexStruct(accounts2, j);

				b1 = GetStringFromStruct(account1, "balance".toCharArray());
				b2 = GetStringFromStruct(account2, "balance".toCharArray());

				f1 = CreateFixedPointForStaticLedger(sledger);
				f2 = CreateFixedPointForStaticLedger(sledger);
				diff = CreateFixedPointForStaticLedger(sledger);

				Assign15d(f1, CreateNumberFromDecimalString(b1));
				Assign15d(f2, CreateNumberFromDecimalString(b2));

				Subtract15d(diff, f2, f1);

				diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".toCharArray(), ".".toCharArray());

				/*System.out.println(diffStr);*/
				if(i == 1d){
					AddStringToStruct(account1, "change".toCharArray(), "0.00".toCharArray());
				}
				AddStringToStruct(account2, "change".toCharArray(), diffStr);
			}
		}

		for(i = 1d; i < ArrayLength(balances); i = i + 1d){
			balance1 = ArrayIndexStruct(balances, i - 1d);
			balance2 = ArrayIndexStruct(balances, i);
			b1 = GetStringFromStruct(balance1, "result".toCharArray());
			b2 = GetStringFromStruct(balance2, "result".toCharArray());

			f1 = CreateFixedPointForStaticLedger(sledger);
			f2 = CreateFixedPointForStaticLedger(sledger);
			diff = CreateFixedPointForStaticLedger(sledger);

			Assign15d(f1, CreateNumberFromDecimalString(b1));
			Assign15d(f2, CreateNumberFromDecimalString(b2));

			Subtract15d(diff, f2, f1);

			diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".toCharArray(), ".".toCharArray());

			/*System.out.println(diffStr);*/
			if(i == 1d){
				AddStringToStruct(balance1, "rchange".toCharArray(), "0.00".toCharArray());
			}
			AddStringToStruct(balance2, "rchange".toCharArray(), diffStr);
		}
	}

	public static char [] BalancesArrayToHTML(Array balances, boolean includeBalance, boolean includeDiff){
		LinkedListCharacters ll;
		double i, j;
		Structure balance, first;
		char [] dateStr, name, number, balanceStr, changeStr;
		Structure account;
		Array accounts;

		ll = CreateLinkedListCharacter();

		LinkedListCharactersAddString(ll, "<html>".toCharArray());
		LinkedListCharactersAddString(ll, "<body>".toCharArray());
		LinkedListCharactersAddString(ll, "<table>".toCharArray());

		/* Headers*/
		LinkedListCharactersAddString(ll, "<tr>".toCharArray());

		LinkedListCharactersAddString(ll, "<td>".toCharArray());
		LinkedListCharactersAddString(ll, "</td>".toCharArray());
		LinkedListCharactersAddString(ll, "<td>".toCharArray());
		LinkedListCharactersAddString(ll, "</td>".toCharArray());

		for(i = 0d; i < ArrayLength(balances); i = i + 1d){
			balance = ArrayIndexStruct(balances, i);
			dateStr = GetStringFromStruct(balance, "date".toCharArray());
			dateStr = strSubstring(dateStr, 0d, 7d);

			LinkedListCharactersAddString(ll, "<td>".toCharArray());
			LinkedListCharactersAddString(ll, dateStr);
			LinkedListCharactersAddString(ll, "</td>".toCharArray());
		}

		LinkedListCharactersAddString(ll, "</tr>".toCharArray());

		/* Each account*/
		first = ArrayIndexStruct(balances, 0d);
		accounts = GetArrayFromStruct(first, "accounts".toCharArray());
		for(j = 0d; j < ArrayLength(accounts); j = j + 1d){
			LinkedListCharactersAddString(ll, "<tr>".toCharArray());

			account = ArrayIndexStruct(accounts, j);
			name = GetStringFromStruct(account, "name".toCharArray());
			number = GetStringFromStruct(account, "number".toCharArray());

			LinkedListCharactersAddString(ll, "<td>".toCharArray());
			LinkedListCharactersAddString(ll, number);
			LinkedListCharactersAddString(ll, "</td>".toCharArray());

			LinkedListCharactersAddString(ll, "<td>".toCharArray());
			LinkedListCharactersAddString(ll, name);
			LinkedListCharactersAddString(ll, "</td>".toCharArray());

			for(i = 0d; i < ArrayLength(balances); i = i + 1d){
				balance = ArrayIndexStruct(balances, i);
				accounts = GetArrayFromStruct(balance, "accounts".toCharArray());
				account = ArrayIndexStruct(accounts, j);
				balanceStr = GetStringFromStruct(account, "balance".toCharArray());
				changeStr = GetStringFromStruct(account, "change".toCharArray());

				LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".toCharArray());

				if(includeBalance && includeDiff){
					LinkedListCharactersAddString(ll, balanceStr);
					LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".toCharArray());
					LinkedListCharactersAddString(ll, changeStr);
					LinkedListCharactersAddString(ll, "</small>".toCharArray());
				}else if(includeBalance){
					LinkedListCharactersAddString(ll, balanceStr);
				}else if(includeDiff){
					LinkedListCharactersAddString(ll, changeStr);
				}

				LinkedListCharactersAddString(ll, "</td>".toCharArray());
			}

			LinkedListCharactersAddString(ll, "</tr>".toCharArray());
		}

		/* Result*/
		LinkedListCharactersAddString(ll, "<tr>".toCharArray());

		LinkedListCharactersAddString(ll, "<td>".toCharArray());
		LinkedListCharactersAddString(ll, "".toCharArray());
		LinkedListCharactersAddString(ll, "</td>".toCharArray());

		LinkedListCharactersAddString(ll, "<td>".toCharArray());
		LinkedListCharactersAddString(ll, "Result".toCharArray());
		LinkedListCharactersAddString(ll, "</td>".toCharArray());

		for(i = 0d; i < ArrayLength(balances); i = i + 1d){
			balance = ArrayIndexStruct(balances, i);
			balanceStr = GetStringFromStruct(balance, "result".toCharArray());
			changeStr = GetStringFromStruct(balance, "rchange".toCharArray());

			LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".toCharArray());

			if(includeBalance && includeDiff){
				LinkedListCharactersAddString(ll, balanceStr);
				LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".toCharArray());
				LinkedListCharactersAddString(ll, changeStr);
				LinkedListCharactersAddString(ll, "</small>".toCharArray());
			}else if(includeBalance){
				LinkedListCharactersAddString(ll, balanceStr);
			}else if(includeDiff){
				LinkedListCharactersAddString(ll, changeStr);
			}

			LinkedListCharactersAddString(ll, "</td>".toCharArray());
		}

		LinkedListCharactersAddString(ll, "</tr>".toCharArray());

		/* Footer*/
		LinkedListCharactersAddString(ll, "</table>".toCharArray());
		LinkedListCharactersAddString(ll, "</body>".toCharArray());
		LinkedListCharactersAddString(ll, "</html>".toCharArray());

		return LinkedListCharactersToArray(ll);
	}

	public static Line CreateLineFromScript(Structure ledger, char [] script, Date date){
		StringReference [] parts;
		FixedPoint15d c, d;
		Line line;
		double i, n;

		c = CreateFixedPointForDynamicLedger(ledger);
		d = CreateFixedPointForDynamicLedger(ledger);

		parts = strSplitByCharacter(script, ',');

		for(i = 0d; i < parts.length; i = i + 1d){
			parts[(int)(i)].string = strTrim(parts[(int)(i)].string);
		}

		line = new Line();

		n = CreateNumberFromDecimalString(parts[2].string);

		line.date = date;
		if(arraysStringsEqual(parts[0].string, "Debit".toCharArray())){
			Assign15d(d, n);
			Assign15d(c, 0d);
		}else if(arraysStringsEqual(parts[0].string, "Credit".toCharArray())){
			Assign15d(d, 0d);
			Assign15d(c, n);
		}

		line = CreateLine(parts[1].string, d, c, parts[3].string, date);

		return line;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
