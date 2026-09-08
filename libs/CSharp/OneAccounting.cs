// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

using static System.Math;

public class Account{
	public char [] name;
	public FixedPoint15d endingBalance;
	public FixedPoint15d startingBalance;
	public Date from;
	public Date to;
	public FixedPoint15d sumDebit;
	public FixedPoint15d sumCredit;
}
public class AccountDefinition{
	public char [] accountName;
	public char [] number;
	public char [] role;
	public bool debitBalance;
}
public class AccountPlan{
	public AccountDefinition [] accountDefinitions;
}
public class Ledger{
	public double decimals;
	public Transaction [] transactions;
	public AccountPlan accountPlan;
}
public class Line{
	public char [] account;
	public FixedPoint15d debit;
	public FixedPoint15d credit;
	public char [] description;
	public Date date;
}
public class Transaction{
	public Line [] lines;
}
public class BooleanArrayReference{
	public bool [] booleanArray;
}
public class BooleanReference{
	public bool booleanValue;
}
public class CharacterReference{
	public char characterValue;
}
public class NumberArrayReference{
	public double [] numberArray;
}
public class NumberReference{
	public double numberValue;
}
public class StringArrayReference{
	public StringReference [] stringArray;
}
public class StringReference{
	public char [] stringx;
}
public class Date{
	public double year;
	public double month;
	public double day;
}
public class DateReference{
	public Date date;
}
public class Interval{
	public Date first;
	public Date last;
}
public class DateTimeTimezone{
	public DateTime dateTime;
	public double timezoneOffsetSeconds;
}
public class DateTimeTimezoneReference{
	public DateTimeTimezone dateTimeTimezone;
}
public class DateTime{
	public Date date;
	public double hours;
	public double minutes;
	public double seconds;
}
public class DateTimeReference{
	public DateTime dateTime;
}
public class FixedPoint30d{
	public double part1;
	public double part2;
	public double digitsBeforeDecimalPoint;
	public double digitsAfterDecimalPoint;
}
public class FixedPoint15d{
	public double number;
	public double digitsBeforeDecimalPoint;
	public double digitsAfterDecimalPoint;
}
public class DynamicArrayCharacters{
	public char [] array;
	public double length;
}
public class LinkedListNodeStrings{
	public bool end;
	public char [] value;
	public LinkedListNodeStrings next;
}
public class LinkedListStrings{
	public LinkedListNodeStrings first;
	public LinkedListNodeStrings last;
}
public class LinkedListNodeNumbers{
	public LinkedListNodeNumbers next;
	public bool end;
	public double value;
}
public class LinkedListNumbers{
	public LinkedListNodeNumbers first;
	public LinkedListNodeNumbers last;
}
public class LinkedListCharacters{
	public LinkedListNodeCharacters first;
	public LinkedListNodeCharacters last;
}
public class LinkedListNodeCharacters{
	public bool end;
	public char value;
	public LinkedListNodeCharacters next;
}
public class DynamicArrayNumbers{
	public double [] array;
	public double length;
}
public class Array{
	public Data [] array;
	public double length;
}
public class Data{
	public bool isStruture;
	public bool isArray;
	public bool isNumber;
	public bool isString;
	public bool isBoolean;
	public Structure structure;
	public Array array;
	public double number;
	public bool booleanx;
	public char [] stringx;
}
public class DataReference{
	public Data data;
}
public class Structure{
	public Array keys;
	public Array values;
}
public class Accounting{
	public static Structure CreateLedger(double decimals){
		Structure ledger;
		Array transactions;

		ledger = CreateStructure();
		transactions = CreateArray();
		AddNumberToStruct(ledger, "decimals".ToCharArray(), decimals);
		AddArrayToStruct(ledger, "transactions".ToCharArray(), transactions);

		return ledger;
	}


	public static FixedPoint15d CreateFixedPointForDynamicLedger(Structure ledger){
		FixedPoint15d n;
		double d;

		d = GetNumberFromStruct(ledger, "decimals".ToCharArray());
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

		for(i = 0d; i < ts.Length; i = i + 1d){
			dst = LineToStructure(ts[(int)(i)]);
			AddStructToArray(ledger, dst);
		}
	}


	public static bool ValidateAndAddTransactionToLedger(Structure ledger, Line [] ls){
		Structure dst;
		double i;
		bool valid;
		Array transactions;
		Array lines;

		transactions = GetArrayFromStruct(ledger, "transactions".ToCharArray());

		valid = ValidateTransaction(ls, ledger);

		if(valid){
			lines = CreateArray();

			for(i = 0d; i < ls.Length; i = i + 1d){
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

		transactions = GetArrayFromStruct(ledger, "transactions".ToCharArray());
		decimals = GetNumberFromStruct(ledger, "decimals".ToCharArray());

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

		AddStringToStruct(dst, "account".ToCharArray(), src.account);
		AddStringToStruct(dst, "debit".ToCharArray(), debitStr);
		AddStringToStruct(dst, "credit".ToCharArray(), creditStr);
		AddStringToStruct(dst, "date".ToCharArray(), dateStr);
		AddStringToStruct(dst, "description".ToCharArray(), src.description);

		return dst;
	}


	public static Line LineFromStructure(Structure src, Structure ledger){
		Line dst;
		char [] account, debitStr, creditStr, dateStr, description;
		FixedPoint15d debit, credit;
		Date date;
		double debitNumber, creditNumber;

		account = GetStringFromStruct(src, "account".ToCharArray());
		debitStr = GetStringFromStruct(src, "debit".ToCharArray());
		creditStr = GetStringFromStruct(src, "credit".ToCharArray());
		dateStr = GetStringFromStruct(src, "date".ToCharArray());
		description = GetStringFromStruct(src, "description".ToCharArray());

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

		transactions = GetArrayFromStruct(src, "transactions".ToCharArray());
		decimals = GetNumberFromStruct(src, "decimals".ToCharArray());
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


	public static bool ValidateTransaction(Line [] ts, Structure ledger){
		bool valid;
		FixedPoint15d creditSum, debitSum;
		double i, d, c;
		Line t;
		char [] creditStr, debitStr;
		Date date;

		valid = true;

		if(ts.Length > 0d){
			date = ts[0].date;

			creditSum = CreateFixedPointForDynamicLedger(ledger);
			debitSum = CreateFixedPointForDynamicLedger(ledger);

			for(i = 0d; i < ts.Length && valid; i = i + 1d){
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


	public static bool ValidateTransactions(Line [] ts, NumberArrayReference invalidIds){
		bool valid;

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

		for(i = 0d; i < ts.Length; i = i + 1d){
			t = ts[(int)(i)];

			for(j = 0d; j < t.lines.Length; j = j + 1d){
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
		LinkedListCharactersAddString(ll, ": ".ToCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.startingBalance, 2d, "".ToCharArray(), ".".ToCharArray()));
		LinkedListCharactersAddString(ll, " -> ".ToCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.endingBalance, 2d, "".ToCharArray(), ".".ToCharArray()));
		LinkedListCharactersAddString(ll, ": ".ToCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2d, ",".ToCharArray(), ".".ToCharArray()));
		LinkedListCharactersAddString(ll, " (+".ToCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumDebit, 2d, "".ToCharArray(), ".".ToCharArray()));
		LinkedListCharactersAddString(ll, ", -".ToCharArray());
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumCredit, 2d, "".ToCharArray(), ".".ToCharArray()));
		LinkedListCharactersAddString(ll, ")".ToCharArray());

		return LinkedListCharactersToArray(ll);
	}


	public static void AddMonthlyAccruals(Structure ledger, Date from, Date to, double amount, char [] fromAccount, char [] toAccount){
		double i;
		char [] accountName, desc;
		double [] amounts;
		Line [] transaction;
		bool valid;
		Date date;
		FixedPoint15d c, d;

		amounts = GetAccrualsWithDates(amount, from, to);

		date = CopyDate(from);
		date.day = 1d;

		c = CreateFixedPointForDynamicLedger(ledger);
		d = CreateFixedPointForDynamicLedger(ledger);

		for(i = 0d; i < amounts.Length; i = i + 1d){
			transaction = new Line [2];

			accountName = fromAccount;
			Assign15d(d, amounts[(int)(i)]);
			Assign15d(c, 0d);
			desc = "x".ToCharArray();
			transaction[0] = CreateLine(accountName, d, c, desc, date);

			accountName = toAccount;
			Assign15d(d, 0d);
			Assign15d(c, amounts[(int)(i)]);
			desc = "x".ToCharArray();
			transaction[1] = CreateLine(accountName, d, c, desc, date);

			valid = ValidateAndAddTransactionToLedger(ledger, transaction);

			AddMonthsToDate(date, 1d);
		}
	}


	public static FixedPoint15d ComputeAccountBalancePrefixAccount(Ledger ledger, char [] accountNr, Date toDate, bool debitBalance){
		double i, j;
		Transaction t;
		Transaction [] ts;
		Line l;
		FixedPoint15d balance;
		LinkedListCharacters prefixL;
		char [] prefixed;

		prefixL = CreateLinkedListCharacter();
		LinkedListCharactersAddString(prefixL, accountNr);
		LinkedListCharactersAddString(prefixL, ".".ToCharArray());

		prefixed = LinkedListCharactersToArray(prefixL);

		ts = ledger.transactions;

		balance = CreateFixedPointForStaticLedger(ledger);

		for(i = 0d; i < ts.Length; i = i + 1d){
			t = ts[(int)(i)];

			for(j = 0d; j < t.lines.Length; j = j + 1d){
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

		LinkedListCharactersAddString(ll, "1\tAssets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1\tProperty, plant and equipment\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.1\tLand and land improvements\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.2\tBuildings, structures and improvements\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.3\tMachinery and equipment\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.4\tFixtures and fittings\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.5\tRight of use assets (classified as PP&E)\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.6\tAdditional property, plant and equipment\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1.7\tConstruction in progress\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.2\tInvestment property\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.2.1\tCompleted\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.2.2\tUnder construction or development\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.3\tGoodwill\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4\tIntangible assets excluding goodwill\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.1\tIntellectual property\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.2\tComputer software\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.3\tTrade and distribution assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.4\tContracts and rights\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.5\tRight of use assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.6\tCrypto assets (classified as intangible)\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.7\tAdditional intangible assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.4.8\tAcquisition in progress\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.5\tFinancial assets and investments\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.5.1\tNon-derivative financial assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.5.2\tDerivative financial assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.5.3\tAdditional financial assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.5.4\tCrypto assets (classified as financial assets)\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.6\tInventories\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.6.1\tMerchandise\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.6.2\tRaw materials and production supplies\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.6.3\tWork in progress\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.6.4\tFinished goods\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.6.5\tOther inventories\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.7\tPrepayments and accrued income\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.7.1\tPrepayments\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.7.2\tAccrued income\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.7.3\tService provider work in process (not classified as inventory)\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.7.4\tAdditional assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.8\tReceivables and contracts\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.8.1\tLoans and receivables\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.8.2\tContracts with customers\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.8.3\tNontrade and other receivables\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.9\tTax assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.9.1\tTax assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.9.2\tDeferred tax assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.9.3\tOther tax assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.1\tAgricultural biological assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.10.1\tBearer plants\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.10.2\tAnimals\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.10.3\tOther agricultural assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.11\tCash and cash equivalents\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.11.1\tCash\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.11.2\tCash equivalents\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "1.11.3\tRestricted cash and financial assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2\tEquity\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.1\tTotal equity attributable to owners of parent\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.1.1\tIssued capital\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.1.2\tAdditional item paid-in capital\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.1.3\tPartner\'s capital\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.1.4\tMember\'s equity\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.1.5\tOther equity interest\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.2\tRetained earnings\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.2.3\tIn suspense\tZero\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.3\tAccumulated other comprehensive income\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.3.2\tMiscellaneous equity\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.4\tOwners equity (non-shareholder)\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "2.5\tNon-controlling interests\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3\tLiabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.1\tTrade and other payables\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.1.1\tTrade payables\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.1.2\tDividend payables\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.1.3\tInterest payable\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.1.4\tOther payables\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.2\tProvisions\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.2.1\tCustomer related provisions\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.2.2\tLitigation and regulatory\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.2.3\tAdditional provisions\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3\tOther financial liabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3.1\tNotes payable\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3.2\tLoans received\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3.3\tBonds (debentures)\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3.4\tOther debts and borrowings\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3.5\tLease obligations\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.3.6\tDerivative financial liabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.4.1\tAccruals\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.4.2\tDeferred income and refund liabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.4.3\tAccrued taxes other than payroll\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "3.4.4\tAdditional liabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4\tRevenue\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.1\tRecognized point of time\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.1.1\tGoods\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.1.2\tServices\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.2\tRecognized over time\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.2.1\tProducts and projects\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.2.2\tServices\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.3\tAdjustments\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.3.1\tVariable consideration\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.3.2\tConsideration paid payable to customers\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "4.3.3\tOther adjustments\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5\tExpenses\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1\tExpenses (classified by nature)\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1.1\tMaterial and merchandise\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1.2\tEmployee benefits expense\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1.3\tServices expense\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1.4\tRent, depreciation, amortization and depletion\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.1.6\tOther work performed by entity and capitalized\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.2\tExpenses (classified by function)\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.2.1\tCost of sales\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "5.2.2\tSelling, general and administrative expense\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6\tOther non-operating income and expenses\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6.1\tOther revenue and expenses\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6.1.1\tOther revenue\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6.1.2\tOther expenses\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6.2\tGains and losses\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6.3\tTaxes other than income and payroll and fees\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "6.4\tTax income (expense)\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7\tIntercompany and related party accounts\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.1\tIntercompany and related party assets\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.1.1\tIntercompany balances eliminated in consolidation\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.1.2\tRelated party balances reported or disclosed\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.1.3\tIntercompany investments\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.2\tIntercompany and related party liabilities\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.2.2\tRelated party balances reported or disclosed\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.3\tIntercompany and related party income and expense\tDr or (Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.3.1\tIntercompany and related party income\t(Cr)\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.3.2\tIntercompany and related party expenses\tDr\n".ToCharArray());
		LinkedListCharactersAddString(ll, "7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n".ToCharArray());

		accountPlanString = LinkedListCharactersToArray(ll);

		FreeLinkedListCharacter(ll);

		return ParseAccountPlanString(accountPlanString, validRef);
	}


	public static AccountPlan ParseAccountPlanString(char [] accountPlanString, BooleanReference valid){
		AccountPlan ap;
		double i;
		char [] line;
		StringReference [] lines, parts;
		AccountDefinition ad;

		ap = new AccountPlan();

		accountPlanString = strTrim(accountPlanString);
		lines = strSplitByCharacter(accountPlanString, '\n');

		ap.accountDefinitions = new AccountDefinition [(int)(lines.Length)];

		for(i = 0d; i < lines.Length; i = i + 1d){
			line = lines[(int)(i)].stringx;
			/*System.out.println(line);*/
			parts = strSplitByCharacter(line, '\t');

			ad = new AccountDefinition();

			ad.accountName = parts[1].stringx;
			ad.number = parts[0].stringx;
			if(arraysStringsEqual(parts[2].stringx, "(Cr)".ToCharArray())){
				ad.debitBalance = false;
			}else{
				ad.debitBalance = true;
			}
			ad.role = "".ToCharArray();
			if(arraysStringsEqual(ad.number, "1".ToCharArray())){
				ad.role = "Assets".ToCharArray();
			}else if(arraysStringsEqual(ad.number, "2".ToCharArray())){
				ad.role = "Equities".ToCharArray();
			}else if(arraysStringsEqual(ad.number, "3".ToCharArray())){
				ad.role = "Liabilities".ToCharArray();
			}else if(arraysStringsEqual(ad.number, "4".ToCharArray())){
				ad.role = "Revenue".ToCharArray();
			}else if(arraysStringsEqual(ad.number, "5".ToCharArray())){
				ad.role = "Expenses".ToCharArray();
			}

			ap.accountDefinitions[(int)(i)] = ad;
		}

		return ap;
	}


	public static bool ComputeAccountBalances(Ledger sledger, double depth, Date date, DataReference balanceSheet){
		AccountPlan accountPlan;
		FixedPoint15d assetsBalance, liabilitiesBalance, equitiesBalance, revenueBalanace, expensesBalance, resultBalance, sum, balance;
		char [] balanceStr;
		AccountDefinition assetsDef, liabilitiesDef, equitiesDef, revenueDef, expensesDef, accountDef;
		bool success, isBalanced;
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

		assetsDef = FindAccountWithRole(accountPlan, "Assets".ToCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		liabilitiesDef = FindAccountWithRole(accountPlan, "Liabilities".ToCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		equitiesDef = FindAccountWithRole(accountPlan, "Equities".ToCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		revenueDef = FindAccountWithRole(accountPlan, "Revenue".ToCharArray(), foundRef);
		success = success && foundRef.booleanValue;
		expensesDef = FindAccountWithRole(accountPlan, "Expenses".ToCharArray(), foundRef);
		success = success && foundRef.booleanValue;

		if(success){
			assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.number, date, assetsDef.debitBalance);
			liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.number, date, liabilitiesDef.debitBalance);

			/* TODO: This must be for a period*/
			revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.number, date, revenueDef.debitBalance);
			expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.number, date, expensesDef.debitBalance);
			resultBalance = CreateFixedPointForStaticLedger(sledger);
			Subtract15d(resultBalance, revenueBalanace, expensesBalance);
			balanceStr = FormatToStringWithSymbols15d(resultBalance, 2d, "".ToCharArray(), ".".ToCharArray());
			AddStringToStruct(balanceSheet.data.structure, "result".ToCharArray(), balanceStr);

			equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.number, date, equitiesDef.debitBalance);
			Add15d(equitiesBalance, equitiesBalance, resultBalance);

			/* Compute accounts*/
			accounts = CreateArray();

			for(i = 0d; i < accountPlan.accountDefinitions.Length; i = i + 1d){
				accountDef = accountPlan.accountDefinitions[(int)(i)];

				parts = strSplitByCharacter(accountDef.number, '.');

				if(parts.Length <= depth + 1d){
					account = CreateStructure();

					balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.number, date, accountDef.debitBalance);

					balanceStr = FormatToStringWithSymbols15d(balance, 2d, "".ToCharArray(), ".".ToCharArray());

					AddStringToStruct(account, "number".ToCharArray(), accountDef.number);
					AddStringToStruct(account, "name".ToCharArray(), accountDef.accountName);
					AddStringToStruct(account, "balance".ToCharArray(), balanceStr);
					AddNumberToStruct(account, "depth".ToCharArray(), parts.Length - 1d);

					AddStructToArray(accounts, account);
				}
			}

			AddArrayToStruct(balanceSheet.data.structure, "accounts".ToCharArray(), accounts);

			/* End conclusion*/
			balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2d, "".ToCharArray(), ".".ToCharArray());
			AddStringToStruct(balanceSheet.data.structure, "assets".ToCharArray(), balanceStr);

			sum = CreateFixedPointForStaticLedger(sledger);
			Add15d(sum, liabilitiesBalance, equitiesBalance);
			balanceStr = FormatToStringWithSymbols15d(sum, 2d, "".ToCharArray(), ".".ToCharArray());
			AddStringToStruct(balanceSheet.data.structure, "liabilitiesAndEquity".ToCharArray(), balanceStr);

			isBalanced = Equals15d(sum, assetsBalance);
			AddBooleanToStruct(balanceSheet.data.structure, "balanced".ToCharArray(), isBalanced);

			dateStr = DateToStringISO8601(date);
			AddStringToStruct(balanceSheet.data.structure, "date".ToCharArray(), dateStr);
		}

		return success;
	}


	public static char [] AccountBalancesToString(Structure balanceSheet){
		LinkedListCharacters ll;
		char [] balanceStr;
		bool isBalanced;
		double i, j, depth;
		Array accounts;
		Structure account;
		char [] accountNumber, accountName;

		ll = CreateLinkedListCharacter();

		/* Print accounts*/
		accounts = GetArrayFromStruct(balanceSheet, "accounts".ToCharArray());

		for(i = 0d; i < ArrayLength(accounts); i = i + 1d){
			account = ArrayIndexStruct(accounts, i);

			accountNumber = GetStringFromStruct(account, "number".ToCharArray());
			accountName = GetStringFromStruct(account, "name".ToCharArray());
			balanceStr = GetStringFromStruct(account, "balance".ToCharArray());
			depth = GetNumberFromStruct(account, "depth".ToCharArray());

			for(j = 0d; j < depth; j = j + 1d){
				LinkedListCharactersAddString(ll, "  ".ToCharArray());
			}

			LinkedListCharactersAddString(ll, accountNumber);
			LinkedListCharactersAddString(ll, ". ".ToCharArray());
			LinkedListCharactersAddString(ll, accountName);
			LinkedListCharactersAddString(ll, ": ".ToCharArray());
			LinkedListCharactersAddString(ll, balanceStr);
			LinkedListCharactersAddString(ll, "\n".ToCharArray());
		}

		/* End conclusion*/
		LinkedListCharactersAddString(ll, "\n".ToCharArray());

		LinkedListCharactersAddString(ll, "Result: ".ToCharArray());
		balanceStr = GetStringFromStruct(balanceSheet, "result".ToCharArray());
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".ToCharArray());

		LinkedListCharactersAddString(ll, "Assets: ".ToCharArray());
		balanceStr = GetStringFromStruct(balanceSheet, "assets".ToCharArray());
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".ToCharArray());

		LinkedListCharactersAddString(ll, "Liabilities + Equities: ".ToCharArray());
		balanceStr = GetStringFromStruct(balanceSheet, "liabilitiesAndEquity".ToCharArray());
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".ToCharArray());

		isBalanced = GetBooleanFromStruct(balanceSheet, "balanced".ToCharArray());
		LinkedListCharactersAddString(ll, "Balance: ".ToCharArray());
		if(isBalanced){
			LinkedListCharactersAddString(ll, "true".ToCharArray());
		}else{
			LinkedListCharactersAddString(ll, "false".ToCharArray());
		}
		LinkedListCharactersAddString(ll, "\n".ToCharArray());

		return LinkedListCharactersToArray(ll);
	}


	public static AccountDefinition FindAccountWithRole(AccountPlan accountPlan, char [] role, BooleanReference foundRef){
		double i;
		AccountDefinition ad;
		bool done;

		ad = new AccountDefinition();

		done = false;
		for(i = 0d; i < accountPlan.accountDefinitions.Length && !done; i = i + 1d){
			ad = accountPlan.accountDefinitions[(int)(i)];
			if(arraysStringsEqual(ad.role, role)){
				done = true;
			}
		}

		foundRef.booleanValue = done;

		return ad;
	}


	public static AccountDefinition CreateAccountDefinition(char [] name, char [] number, char [] role, bool debitBalance){
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
		accountsO = GetArrayFromStruct(first, "accounts".ToCharArray());

		for(j = 0d; j < ArrayLength(accountsO); j = j + 1d){
			for(i = 1d; i < ArrayLength(balances); i = i + 1d){
				balance1 = ArrayIndexStruct(balances, i - 1d);
				balance2 = ArrayIndexStruct(balances, i);
				accounts1 = GetArrayFromStruct(balance1, "accounts".ToCharArray());
				accounts2 = GetArrayFromStruct(balance2, "accounts".ToCharArray());

				account1 = ArrayIndexStruct(accounts1, j);
				account2 = ArrayIndexStruct(accounts2, j);

				b1 = GetStringFromStruct(account1, "balance".ToCharArray());
				b2 = GetStringFromStruct(account2, "balance".ToCharArray());

				f1 = CreateFixedPointForStaticLedger(sledger);
				f2 = CreateFixedPointForStaticLedger(sledger);
				diff = CreateFixedPointForStaticLedger(sledger);

				Assign15d(f1, CreateNumberFromDecimalString(b1));
				Assign15d(f2, CreateNumberFromDecimalString(b2));

				Subtract15d(diff, f2, f1);

				diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".ToCharArray(), ".".ToCharArray());

				/*System.out.println(diffStr);*/
				if(i == 1d){
					AddStringToStruct(account1, "change".ToCharArray(), "0.00".ToCharArray());
				}
				AddStringToStruct(account2, "change".ToCharArray(), diffStr);
			}
		}

		for(i = 1d; i < ArrayLength(balances); i = i + 1d){
			balance1 = ArrayIndexStruct(balances, i - 1d);
			balance2 = ArrayIndexStruct(balances, i);
			b1 = GetStringFromStruct(balance1, "result".ToCharArray());
			b2 = GetStringFromStruct(balance2, "result".ToCharArray());

			f1 = CreateFixedPointForStaticLedger(sledger);
			f2 = CreateFixedPointForStaticLedger(sledger);
			diff = CreateFixedPointForStaticLedger(sledger);

			Assign15d(f1, CreateNumberFromDecimalString(b1));
			Assign15d(f2, CreateNumberFromDecimalString(b2));

			Subtract15d(diff, f2, f1);

			diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".ToCharArray(), ".".ToCharArray());

			/*System.out.println(diffStr);*/
			if(i == 1d){
				AddStringToStruct(balance1, "rchange".ToCharArray(), "0.00".ToCharArray());
			}
			AddStringToStruct(balance2, "rchange".ToCharArray(), diffStr);
		}
	}


	public static char [] BalancesArrayToHTML(Array balances, bool includeBalance, bool includeDiff){
		LinkedListCharacters ll;
		double i, j;
		Structure balance, first;
		char [] dateStr, name, number, balanceStr, changeStr;
		Structure account;
		Array accounts;

		ll = CreateLinkedListCharacter();

		LinkedListCharactersAddString(ll, "<html>".ToCharArray());
		LinkedListCharactersAddString(ll, "<body>".ToCharArray());
		LinkedListCharactersAddString(ll, "<table>".ToCharArray());

		/* Headers*/
		LinkedListCharactersAddString(ll, "<tr>".ToCharArray());

		LinkedListCharactersAddString(ll, "<td>".ToCharArray());
		LinkedListCharactersAddString(ll, "</td>".ToCharArray());
		LinkedListCharactersAddString(ll, "<td>".ToCharArray());
		LinkedListCharactersAddString(ll, "</td>".ToCharArray());

		for(i = 0d; i < ArrayLength(balances); i = i + 1d){
			balance = ArrayIndexStruct(balances, i);
			dateStr = GetStringFromStruct(balance, "date".ToCharArray());
			dateStr = strSubstring(dateStr, 0d, 7d);

			LinkedListCharactersAddString(ll, "<td>".ToCharArray());
			LinkedListCharactersAddString(ll, dateStr);
			LinkedListCharactersAddString(ll, "</td>".ToCharArray());
		}

		LinkedListCharactersAddString(ll, "</tr>".ToCharArray());

		/* Each account*/
		first = ArrayIndexStruct(balances, 0d);
		accounts = GetArrayFromStruct(first, "accounts".ToCharArray());
		for(j = 0d; j < ArrayLength(accounts); j = j + 1d){
			LinkedListCharactersAddString(ll, "<tr>".ToCharArray());

			account = ArrayIndexStruct(accounts, j);
			name = GetStringFromStruct(account, "name".ToCharArray());
			number = GetStringFromStruct(account, "number".ToCharArray());

			LinkedListCharactersAddString(ll, "<td>".ToCharArray());
			LinkedListCharactersAddString(ll, number);
			LinkedListCharactersAddString(ll, "</td>".ToCharArray());

			LinkedListCharactersAddString(ll, "<td>".ToCharArray());
			LinkedListCharactersAddString(ll, name);
			LinkedListCharactersAddString(ll, "</td>".ToCharArray());

			for(i = 0d; i < ArrayLength(balances); i = i + 1d){
				balance = ArrayIndexStruct(balances, i);
				accounts = GetArrayFromStruct(balance, "accounts".ToCharArray());
				account = ArrayIndexStruct(accounts, j);
				balanceStr = GetStringFromStruct(account, "balance".ToCharArray());
				changeStr = GetStringFromStruct(account, "change".ToCharArray());

				LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".ToCharArray());

				if(includeBalance && includeDiff){
					LinkedListCharactersAddString(ll, balanceStr);
					LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".ToCharArray());
					LinkedListCharactersAddString(ll, changeStr);
					LinkedListCharactersAddString(ll, "</small>".ToCharArray());
				}else if(includeBalance){
					LinkedListCharactersAddString(ll, balanceStr);
				}else if(includeDiff){
					LinkedListCharactersAddString(ll, changeStr);
				}

				LinkedListCharactersAddString(ll, "</td>".ToCharArray());
			}

			LinkedListCharactersAddString(ll, "</tr>".ToCharArray());
		}

		/* Result*/
		LinkedListCharactersAddString(ll, "<tr>".ToCharArray());

		LinkedListCharactersAddString(ll, "<td>".ToCharArray());
		LinkedListCharactersAddString(ll, "".ToCharArray());
		LinkedListCharactersAddString(ll, "</td>".ToCharArray());

		LinkedListCharactersAddString(ll, "<td>".ToCharArray());
		LinkedListCharactersAddString(ll, "Result".ToCharArray());
		LinkedListCharactersAddString(ll, "</td>".ToCharArray());

		for(i = 0d; i < ArrayLength(balances); i = i + 1d){
			balance = ArrayIndexStruct(balances, i);
			balanceStr = GetStringFromStruct(balance, "result".ToCharArray());
			changeStr = GetStringFromStruct(balance, "rchange".ToCharArray());

			LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".ToCharArray());

			if(includeBalance && includeDiff){
				LinkedListCharactersAddString(ll, balanceStr);
				LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".ToCharArray());
				LinkedListCharactersAddString(ll, changeStr);
				LinkedListCharactersAddString(ll, "</small>".ToCharArray());
			}else if(includeBalance){
				LinkedListCharactersAddString(ll, balanceStr);
			}else if(includeDiff){
				LinkedListCharactersAddString(ll, changeStr);
			}

			LinkedListCharactersAddString(ll, "</td>".ToCharArray());
		}

		LinkedListCharactersAddString(ll, "</tr>".ToCharArray());

		/* Footer*/
		LinkedListCharactersAddString(ll, "</table>".ToCharArray());
		LinkedListCharactersAddString(ll, "</body>".ToCharArray());
		LinkedListCharactersAddString(ll, "</html>".ToCharArray());

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

		for(i = 0d; i < parts.Length; i = i + 1d){
			parts[(int)(i)].stringx = strTrim(parts[(int)(i)].stringx);
		}

		line = new Line();

		n = CreateNumberFromDecimalString(parts[2].stringx);

		line.date = date;
		if(arraysStringsEqual(parts[0].stringx, "Debit".ToCharArray())){
			Assign15d(d, n);
			Assign15d(c, 0d);
		}else if(arraysStringsEqual(parts[0].stringx, "Credit".ToCharArray())){
			Assign15d(d, 0d);
			Assign15d(c, n);
		}

		line = CreateLine(parts[1].stringx, d, c, parts[3].stringx, date);

		return line;
	}


	public static double test(){
		NumberReference failures;

		failures = CreateNumberReference(0d);

		TestBasicAccounting(failures);
		TestAccruals(failures);
		TestIFRSAccountPlan(failures);

		return failures.numberValue;
	}


	public static void TestIFRSAccountPlan(NumberReference failures){
		GetIFRSAccountPlan();
	}


	public static void TestBasicAccounting(NumberReference failures){
		Structure ledger;
		FixedPoint15d c, d;
		Line [] transaction;
		bool valid;
		Date date, from, to;
		Account account;
		char [] accountName, accountStr, desc;
		Ledger sledger;

		ledger = CreateLedger(2d);

		/*c = CreateFixedPointForDynamicLedger(ledger);*/
		/*d = CreateFixedPointForDynamicLedger(ledger);*/
		/* Transaction 1:*/
		transaction = new Line [2];
		/*date = CreateDate(2026d, 2d, 18d);*/
		date = DateFromStringISO8601("2026-02-18".ToCharArray());

		/* Debit, 100, 1000, l1, 2026-02-18*/
		/*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
        */
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1000, 100, l1".ToCharArray(), date);

		/* Credit, 100, 2000, l2, 2026-02-18*/
		/*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
        */
		transaction[1] = CreateLineFromScript(ledger, "Credit, 2000, 100, l2".ToCharArray(), date);

		valid = ValidateAndAddTransactionToLedger(ledger, transaction);

		AssertTrue(valid, failures);

		/* Compute*/
		sledger = LedgerDynamicToStatic(ledger);

		accountName = "1000".ToCharArray();
		from = DateFromStringISO8601("2026-02-17".ToCharArray());
		to = DateFromStringISO8601("2026-02-19".ToCharArray());
		account = ComputeAccountBalance(sledger, accountName, from, to);

		accountStr = AccountToString(account);

		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)".ToCharArray(), failures);
	}


	public static void TestAccruals(NumberReference failures){
		Structure ledger;
		FixedPoint15d c, d;
		Line [] transaction;
		bool valid, success;
		Date date, from, to;
		Account account;
		char [] accountName, desc, accountStr, accountSummaryStr;
		Ledger sledger;
		double [] amounts;
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

		/* 1.8.1. Loans and receivables*/
		/* 3.4.2. Deferred income and refund liabilities*/
		/* 1.11.1. Cash*/
		/* 1.8.1. Loans and receivables*/
		/* 3.4.2. Deferred income and refund liabilities*/
		/* 4.1.2 Services*/
		/* 1.11.1. Cash*/
		/* 1.7.1. Prepayments*/
		/* 5.1.3. Services expense*/
		/* 1.7.1. Prepayments*/
		/* Transaction: Invoice sent*/
		transaction = new Line [2];
		date = DateFromStringISO8601("2025-09-17".ToCharArray());
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x".ToCharArray(), date);
		transaction[1] = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x".ToCharArray(), date);
		valid = ValidateAndAddTransactionToLedger(ledger, transaction);
		AssertTrue(valid, failures);

		/* Transaction: Invoice paid*/
		transaction = new Line [2];
		date = DateFromStringISO8601("2025-10-01".ToCharArray());
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x".ToCharArray(), date);
		transaction[1] = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x".ToCharArray(), date);
		valid = ValidateAndAddTransactionToLedger(ledger, transaction);
		AssertTrue(valid, failures);

		/* Transaction: Renewal paid*/
		transaction = new Line [2];
		date = DateFromStringISO8601("2025-11-08".ToCharArray());
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x".ToCharArray(), date);
		transaction[1] = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x".ToCharArray(), date);
		valid = ValidateAndAddTransactionToLedger(ledger, transaction);
		AssertTrue(valid, failures);

		/* Accruals income*/
		from = DateFromStringISO8601("2025-12-06".ToCharArray());
		to = DateFromStringISO8601("2026-12-05".ToCharArray());
		AddMonthlyAccruals(ledger, from, to, 125d, "3.4.2".ToCharArray(), "4.1.2".ToCharArray());

		/* Accruals cost*/
		from = DateFromStringISO8601("2025-12-06".ToCharArray());
		to = DateFromStringISO8601("2026-12-05".ToCharArray());
		AddMonthlyAccruals(ledger, from, to, 112.50, "5.1.3".ToCharArray(), "1.7.1".ToCharArray());

		/* Compute*/
		sledger = LedgerDynamicToStatic(ledger);

		from = DateFromStringISO8601("2027-01-01".ToCharArray());
		to = DateFromStringISO8601("2027-01-01".ToCharArray());

		account = ComputeAccountBalance(sledger, "5.1.3".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "4.1.2".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "1.8.1".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "3.4.2".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "1.11.1".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "1.7.1".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		/*System.out.println("");*/
		/* In between*/
		from = DateFromStringISO8601("2026-06-15".ToCharArray());
		to = DateFromStringISO8601("2026-06-16".ToCharArray());

		account = ComputeAccountBalance(sledger, "5.1.3".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "4.1.2".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "1.8.1".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "3.4.2".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "1.11.1".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		account = ComputeAccountBalance(sledger, "1.7.1".ToCharArray(), from, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)".ToCharArray(), failures);

		/* Balance Sheet: Snapshots a companys assets, liabilities, and equity at a specific point in time.*/
		/* Income Statement (P&L): Shows revenue, expenses, and profit/loss over a period.*/
		/* Cash Flow Statement: Tracks cash inflow and outflow from operating, investing, and financing activities.*/
		/* Statement of Shareholders' Equity: Details changes in owner interest over time.*/
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

		to = DateFromStringISO8601("2026-02-16".ToCharArray());
		balanceSheetRef = new DataReference();
		success = ComputeAccountBalances(sledger, 2d, to, balanceSheetRef);
		accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure);
		AssertTrue(success, failures);
		/*System.out.println(accountSummaryStr);*/
		/* Compute monthly table*/
		to = DateFromStringISO8601("2025-08-01".ToCharArray());
		message = new StringReference();
		AddDaysToDate(to, -1d, message);
		balances = CreateArray();
		for(i = 0d; i < 12d + 6d; i = i + 1d){
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

		/*StringToFile("x.html", html);*/
		html = BalancesArrayToHTML(balances, false, true);

		/*StringToFile("x-diff.html", html);*/
		html = BalancesArrayToHTML(balances, true, true);
	}


	public static BooleanReference CreateBooleanReference(bool value){
		BooleanReference refx;

		refx = new BooleanReference();
		refx.booleanValue = value;

		return refx;
	}


	public static BooleanArrayReference CreateBooleanArrayReference(bool [] value){
		BooleanArrayReference refx;

		refx = new BooleanArrayReference();
		refx.booleanArray = value;

		return refx;
	}


	public static BooleanArrayReference CreateBooleanArrayReferenceLengthValue(double length, bool value){
		BooleanArrayReference refx;
		double i;

		refx = new BooleanArrayReference();
		refx.booleanArray = new bool [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			refx.booleanArray[(int)(i)] = value;
		}

		return refx;
	}


	public static void FreeBooleanArrayReference(BooleanArrayReference booleanArrayReference){
		delete(booleanArrayReference.booleanArray);
		delete(booleanArrayReference);
	}


	public static CharacterReference CreateCharacterReference(char value){
		CharacterReference refx;

		refx = new CharacterReference();
		refx.characterValue = value;

		return refx;
	}


	public static NumberReference CreateNumberReference(double value){
		NumberReference refx;

		refx = new NumberReference();
		refx.numberValue = value;

		return refx;
	}


	public static NumberArrayReference CreateNumberArrayReference(double [] value){
		NumberArrayReference refx;

		refx = new NumberArrayReference();
		refx.numberArray = value;

		return refx;
	}


	public static NumberArrayReference CreateNumberArrayReferenceLengthValue(double length, double value){
		NumberArrayReference refx;
		double i;

		refx = new NumberArrayReference();
		refx.numberArray = new double [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			refx.numberArray[(int)(i)] = value;
		}

		return refx;
	}


	public static void FreeNumberArrayReference(NumberArrayReference numberArrayReference){
		delete(numberArrayReference.numberArray);
		delete(numberArrayReference);
	}


	public static StringReference CreateStringReference(char [] value){
		StringReference refx;

		refx = new StringReference();
		refx.stringx = value;

		return refx;
	}


	public static StringReference CreateStringReferenceLengthValue(double length, char value){
		StringReference refx;
		double i;

		refx = new StringReference();
		refx.stringx = new char [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			refx.stringx[(int)(i)] = value;
		}

		return refx;
	}


	public static void FreeStringReference(StringReference stringReference){
		delete(stringReference.stringx);
		delete(stringReference);
	}


	public static StringArrayReference CreateStringArrayReference(StringReference [] strings){
		StringArrayReference refx;

		refx = new StringArrayReference();
		refx.stringArray = strings;

		return refx;
	}


	public static StringArrayReference CreateStringArrayReferenceLengthValue(double length, char [] value){
		StringArrayReference refx;
		double i;

		refx = new StringArrayReference();
		refx.stringArray = new StringReference [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			refx.stringArray[(int)(i)] = CreateStringReference(value);
		}

		return refx;
	}


	public static void FreeStringArrayReference(StringArrayReference stringArrayReference){
		double i;

		for(i = 0d; i < stringArrayReference.stringArray.Length; i = i + 1d){
			delete(stringArrayReference.stringArray[(int)(i)]);
		}
		delete(stringArrayReference.stringArray);
		delete(stringArrayReference);
	}


	public static Date CreateDate(double year, double month, double day){
		Date date;

		date = new Date();

		date.year = year;
		date.month = month;
		date.day = day;

		return date;
	}


	public static bool IsLeapYearWithCheck(double year, BooleanReference isLeapYearReference, StringReference message){
		bool itIsLeapYear;
		bool success;

		if(year >= 1752d){
			success = true;
			itIsLeapYear = IsLeapYear(year);
		}else{
			success = false;
			itIsLeapYear = false;
			message.stringx = "Gregorian calendar was not in general use.".ToCharArray();
		}

		isLeapYearReference.booleanValue = itIsLeapYear;
		return success;
	}


	public static bool IsLeapYear(double year){
		bool itIsLeapYear;

		if(DivisibleBy(year, 4d)){
			if(DivisibleBy(year, 100d)){
				if(DivisibleBy(year, 400d)){
					itIsLeapYear = true;
				}else{
					itIsLeapYear = false;
				}
			}else{
				itIsLeapYear = true;
			}
		}else{
			itIsLeapYear = false;
		}

		return itIsLeapYear;
	}


	public static bool DayToDateWithCheck(double dayNr, DateReference dateReference, StringReference message){
		Date date;
		NumberReference remainder;
		bool success;

		if(dayNr >= -79623d){
			date = new Date();
			remainder = new NumberReference();
			remainder.numberValue = dayNr + 79623d;
			/* Days since 1752-01-01. Day 0: Thursday, 1970-01-01*/
			/* Find year.*/
			date.year = GetYearFromDayNr(remainder.numberValue, remainder);

			/* Find month.*/
			date.month = GetMonthFromDayNr(remainder.numberValue, date.year, remainder);

			/* Find day.*/
			date.day = 1d + remainder.numberValue;

			dateReference.date = date;
			success = true;
		}else{
			success = false;
			message.stringx = "Gregorian calendar was not in general use before 1752.".ToCharArray();
		}

		return success;
	}


	public static Date DayToDate(double dayNr){
		Date date;
		bool success;
		DateReference dateRef;
		StringReference message;

		dateRef = new DateReference();
		message = new StringReference();

		success = DayToDateWithCheck(dayNr, dateRef, message);
		if(success){
			date = dateRef.date;
			delete(dateRef);
			FreeStringReference(message);
		}else{
			date = CreateDate(1970d, 1d, 1d);
		}

		return date;
	}


	public static bool GetMonthFromDayNrWithCheck(double dayNr, double year, NumberReference monthReference, NumberReference remainderReference, StringReference message){
		double month;
		bool success;

		if(dayNr >= -79623d){
			month = GetMonthFromDayNr(dayNr, year, remainderReference);
			monthReference.numberValue = month;
			success = true;
		}else{
			success = false;
			message.stringx = "Gregorian calendar not in general use before 1752.".ToCharArray();
		}

		return success;
	}


	public static double GetMonthFromDayNr(double dayNr, double year, NumberReference remainderReference){
		double [] daysInMonth;
		bool done;
		double month;

		daysInMonth = GetDaysInMonth(year);
		done = false;
		month = 1d;

		for(; !done; ){
			if(dayNr >= daysInMonth[(int)(month)]){
				dayNr = dayNr - daysInMonth[(int)(month)];
				month = month + 1d;
			}else{
				done = true;
			}
		}
		remainderReference.numberValue = dayNr;

		return month;
	}


	public static bool GetYearFromDayNrWithCheck(double dayNr, NumberReference yearReference, NumberReference remainder, StringReference message){
		bool success;
		double year;

		if(dayNr >= 0d){
			success = true;
			year = GetYearFromDayNr(dayNr, remainder);
			yearReference.numberValue = year;
		}else{
			success = false;
			message.stringx = "Day number must be 0 or higher. 0 is 1752-01-01.".ToCharArray();
		}

		return success;
	}


	public static double GetYearFromDayNr(double dayNr, NumberReference remainder){
		double nrOfDays;
		bool done;
		double year;

		done = false;
		year = 1752d;

		for(; !done; ){
			if(IsLeapYear(year)){
				nrOfDays = 366d;
			}else{
				nrOfDays = 365d;
			}

			if(dayNr >= nrOfDays){
				/* First day is 0.*/
				dayNr = dayNr - nrOfDays;
				year = year + 1d;
			}else{
				done = true;
			}
		}
		remainder.numberValue = dayNr;

		return year;
	}


	public static double DaysBetweenDates(Date A, Date B){
		double daysA, daysB, daysBetween;

		daysA = DateToDays(A);
		daysB = DateToDays(B);

		daysBetween = daysB - daysA;

		return daysBetween;
	}


	public static bool GetDaysInMonthWithCheck(double year, NumberArrayReference daysInMonthReference, StringReference message){
		double [] daysInMonth;
		bool success;
		Date date;

		date = CreateDate(year, 1d, 1d);

		success = IsValidDate(date, message);
		if(success){
			daysInMonth = GetDaysInMonth(year);

			daysInMonthReference.numberArray = daysInMonth;
		}

		return success;
	}


	public static double [] GetDaysInMonth(double year){
		double [] daysInMonth;

		daysInMonth = new double [(int)(1d + 12d)];

		daysInMonth[0] = 0d;
		daysInMonth[1] = 31d;

		if(IsLeapYear(year)){
			daysInMonth[2] = 29d;
		}else{
			daysInMonth[2] = 28d;
		}
		daysInMonth[3] = 31d;
		daysInMonth[4] = 30d;
		daysInMonth[5] = 31d;
		daysInMonth[6] = 30d;
		daysInMonth[7] = 31d;
		daysInMonth[8] = 31d;
		daysInMonth[9] = 30d;
		daysInMonth[10] = 31d;
		daysInMonth[11] = 30d;
		daysInMonth[12] = 31d;

		return daysInMonth;
	}


	public static bool DateToDaysWithCheck(Date date, NumberReference dayNumberReferenceReference, StringReference message){
		double days;
		bool success;

		success = IsValidDate(date, message);
		if(success){
			days = DateToDays(date);
			dayNumberReferenceReference.numberValue = days;
		}

		return success;
	}


	public static double DateToDays(Date date){
		double days;

		/* Day 1752-01-01*/
		days = -79623d;

		days = days + DaysInYears(date.year);
		days = days + DaysInMonths(date.month, date.year);
		days = days + date.day - 1d;

		return days;
	}


	public static bool DateToWeekdayNumberWithCheck(Date date, NumberReference weekDayNumberReference, StringReference message){
		double weekDay;
		bool success;

		success = IsValidDate(date, message);
		if(success){
			weekDay = DateToWeekdayNumber(date);
			weekDayNumberReference.numberValue = weekDay;
		}

		return success;
	}


	public static double DateToWeekdayNumber(Date date){
		double days, weekDay;

		days = DateToDays(date);

		days = days + 79623d;
		days = days + 5d;

		weekDay = days%7d + 1d;

		return weekDay;
	}


	public static double DateToWeeknumber(Date date, NumberReference yearRef){
		double weekNumber, weekday, days, daysWeek1Start, weekdayNewYears;
		Date week1Start, newyears;

		week1Start = CopyDate(date);

		week1Start.day = 1d;
		week1Start.month = 1d;
		weekday = DateToWeekdayNumber(week1Start);

		/* Set week1Start to the start of the Week 1.*/
		/* If monday, week 1 begins on Jan. 1st*/
		if(weekday == 1d){
			week1Start.day = 1d;
		}
		/* If tuesday, week 1 begins on Dec. 31st*/
		if(weekday == 2d){
			week1Start.year = week1Start.year - 1d;
			week1Start.month = 12d;
			week1Start.day = 31d;
		}
		/* If wednesday, week 1 begins on Dec. 30th*/
		if(weekday == 3d){
			week1Start.year = week1Start.year - 1d;
			week1Start.month = 12d;
			week1Start.day = 30d;
		}
		/* If thursday, week 1 begins on Dec. 29th*/
		if(weekday == 4d){
			week1Start.year = week1Start.year - 1d;
			week1Start.month = 12d;
			week1Start.day = 29d;
		}
		/* If friday, week 1 begins on Jan. 4th*/
		if(weekday == 5d){
			week1Start.day = 4d;
		}
		/* If saturday, week 1 begins on Jan. 3rd*/
		if(weekday == 6d){
			week1Start.day = 3d;
		}
		/* If sunday, week 1 begins on Jan. 2nd*/
		if(weekday == 7d){
			week1Start.day = 2d;
		}

		days = DateToDays(date);
		daysWeek1Start = DateToDays(week1Start);

		if(days >= daysWeek1Start){
			weekNumber = 1d + Floor((days - daysWeek1Start)/7d);

			if(weekNumber >= 1d && weekNumber <= 52d){
				/* Week is between 1 and 52 in the current year.*/
				yearRef.numberValue = date.year;
			}else{
				/* Is week nr 53 or 1 next year?*/
				newyears = CopyDate(date);
				newyears.month = 12d;
				newyears.day = 31d;
				weekdayNewYears = DateToWeekdayNumber(newyears);
				if(weekdayNewYears == 1d || weekdayNewYears == 2d || weekdayNewYears == 3d){
					/* Week 1 next year.*/
					weekNumber = 1d;
					yearRef.numberValue = date.year + 1d;
				}else{
					/* Week 53*/
					yearRef.numberValue = date.year;
				}
				delete(newyears);
			}
		}else{
			/* Week is in previous year. Either 52nd or 53rd.*/
			newyears = CopyDate(date);
			newyears.month = 12d;
			newyears.day = 31d;
			newyears.year = date.year - 1d;
			weekNumber = DateToWeeknumber(newyears, yearRef);
			delete(newyears);
		}

		delete(week1Start);

		return weekNumber;
	}


	public static bool DaysInMonthsWithCheck(double month, double year, NumberReference daysInMonthsReference, StringReference message){
		double days;
		bool success;
		Date date;

		date = CreateDate(year, month, 1d);

		success = IsValidDate(date, message);
		if(success){
			days = DaysInMonths(month, year);

			daysInMonthsReference.numberValue = days;
		}

		return success;
	}


	public static double DaysInMonths(double month, double year){
		double [] daysInMonth;
		double days;
		double i;

		daysInMonth = GetDaysInMonth(year);

		days = 0d;
		for(i = 1d; i < month; i = i + 1d){
			days = days + daysInMonth[(int)(i)];
		}

		return days;
	}


	public static bool DaysInYearsWithCheck(double years, NumberReference daysReference, StringReference message){
		double days;
		bool success;
		Date date;

		date = CreateDate(years, 1d, 1d);

		success = IsValidDate(date, message);
		if(success){
			days = DaysInYears(years);
			daysReference.numberValue = days;
		}

		return success;
	}


	public static double DaysInYears(double years){
		double days;
		double i;
		double nrOfDays;

		days = 0d;
		for(i = 1752d; i < years; i = i + 1d){
			if(IsLeapYear(i)){
				nrOfDays = 366d;
			}else{
				nrOfDays = 365d;
			}
			days = days + nrOfDays;
		}

		return days;
	}


	public static bool IsValidDate(Date date, StringReference message){
		bool valid;
		double [] daysInMonth;
		double daysInThisMonth;

		if(date.year >= 1752d){
			if(date.month >= 1d && date.month <= 12d){
				daysInMonth = GetDaysInMonth(date.year);
				daysInThisMonth = daysInMonth[(int)(date.month)];
				if(date.day >= 1d && date.day <= daysInThisMonth){
					valid = true;
				}else{
					valid = false;
					message.stringx = "The month does not have the given day number.".ToCharArray();
				}
			}else{
				valid = false;
				message.stringx = "Month must be between 1 and 12, inclusive.".ToCharArray();
			}
		}else{
			valid = false;
			message.stringx = "Gregorian calendar was not in general use before 1752.".ToCharArray();
		}

		return valid;
	}


	public static bool AddDaysToDate(Date date, double days, StringReference message){
		double n;
		bool success;
		DateReference dateReference;
		NumberReference daysRef;

		daysRef = new NumberReference();
		success = DateToDaysWithCheck(date, daysRef, message);

		if(success){
			n = daysRef.numberValue;
			n = n + days;

			dateReference = new DateReference();
			success = DayToDateWithCheck(n, dateReference, message);
			if(success){
				AssignDate(date, dateReference.date);
			}
		}

		return success;
	}


	public static void AssignDate(Date a, Date b){
		a.year = b.year;
		a.month = b.month;
		a.day = b.day;
	}


	public static void AddMonthsToDate(Date date, double months){
		double i;

		if(months > 0d){
			for(i = 0d; i < months; i = i + 1d){
				date.month = date.month + 1d;

				if(date.month == 13d){
					date.month = 1d;
					date.year = date.year + 1d;
				}
			}
		}
		if(months < 0d){
			for(i = 0d; i < -months; i = i + 1d){
				date.month = date.month - 1d;

				if(date.month == 0d){
					date.month = 12d;
					date.year = date.year - 1d;
				}
			}
		}
	}


	public static bool DateToStringISO8601WithCheck(Date date, StringReference datestr, StringReference message){
		bool success;

		success = IsValidDate(date, message);

		if(success){
			if(date.year <= 9999d){
				datestr.stringx = DateToStringISO8601(date);
			}else{
				message.stringx = "This library works from 1752 to 9999.".ToCharArray();
			}
		}

		return success;
	}


	public static char [] DateToStringISO8601(Date date){
		char [] str;

		str = new char [10];

		str[0] = cDecimalDigitToCharacter(Floor(date.year/1000d));
		str[1] = cDecimalDigitToCharacter(Floor((date.year%1000d)/100d));
		str[2] = cDecimalDigitToCharacter(Floor((date.year%100d)/10d));
		str[3] = cDecimalDigitToCharacter(Floor(date.year%10d));

		str[4] = '-';

		str[5] = cDecimalDigitToCharacter(Floor((date.month%100d)/10d));
		str[6] = cDecimalDigitToCharacter(Floor(date.month%10d));

		str[7] = '-';

		str[8] = cDecimalDigitToCharacter(Floor((date.day%100d)/10d));
		str[9] = cDecimalDigitToCharacter(Floor(date.day%10d));

		return str;
	}


	public static Date DateFromStringISO8601(char [] str){
		Date date;
		double n;

		date = new Date();

		n = cCharacterToDecimalDigit(str[0])*1000d;
		n = n + cCharacterToDecimalDigit(str[1])*100d;
		n = n + cCharacterToDecimalDigit(str[2])*10d;
		n = n + cCharacterToDecimalDigit(str[3])*1d;

		date.year = n;

		n = cCharacterToDecimalDigit(str[5])*10d;
		n = n + cCharacterToDecimalDigit(str[6])*1d;

		date.month = n;

		n = cCharacterToDecimalDigit(str[8])*10d;
		n = n + cCharacterToDecimalDigit(str[9])*1d;

		date.day = n;

		return date;
	}


	public static bool DateFromStringISO8601WithCheck(char [] str, DateReference dateRef, StringReference message){
		bool valid;

		valid = IsValidDateISO8601(str, message);

		if(valid){
			dateRef.date = DateFromStringISO8601(str);
		}

		return valid;
	}


	public static bool IsValidDateISO8601(char [] str, StringReference message){
		bool valid;

		if(str.Length == 4d + 1d + 2d + 1d + 2d){

			if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9])){
				if(str[4] == '-' && str[7] == '-'){
					valid = true;
				}else{
					valid = false;
					message.stringx = "ISO8601 date must use \'-\' in positions 5 and 8.".ToCharArray();
				}
			}else{
				valid = false;
				message.stringx = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.".ToCharArray();
			}
		}else{
			valid = false;
			message.stringx = "ISO8601 date must be exactly 10 characters long.".ToCharArray();
		}

		return valid;
	}


	public static bool DateEquals(Date a, Date b){
		return a.year == b.year && a.month == b.month && a.day == b.day;
	}


	public static Date CopyDate(Date a){
		Date b;

		b = CreateDate(a.year, a.month, a.day);

		return b;
	}


	public static double GetSecondsFromDate(Date date){
		double seconds, days, secondsInMinute, secondsInHour, secondsInDay;
		NumberReference dayNumberReferenceReference;
		StringReference message;
		bool success;

		seconds = 0d;
		dayNumberReferenceReference = new NumberReference();
		message = new StringReference();

		success = DateToDaysWithCheck(date, dayNumberReferenceReference, message);
		if(success){
			days = dayNumberReferenceReference.numberValue;

			secondsInMinute = 60d;
			secondsInHour = 60d*secondsInMinute;
			secondsInDay = 24d*secondsInHour;

			seconds = seconds + secondsInDay*days;
		}

		delete(dayNumberReferenceReference);
		delete(message);

		return seconds;
	}


	public static bool DateIsInInterval(Interval interval, Date date){
		double from, to, day;

		from = DateToDays(interval.first);
		to = DateToDays(interval.last);
		day = DateToDays(date);

		return day >= from && day <= to;
	}


	public static bool DateLessThan(Date a, Date b){
		double aDays, bDays;

		aDays = DateToDays(a);
		bDays = DateToDays(b);

		return aDays < bDays;
	}


	public static DateTimeTimezone CreateDateTimeTimezone(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetSeconds){
		DateTimeTimezone dateTimeTimezone;

		dateTimeTimezone = new DateTimeTimezone();

		dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

		return dateTimeTimezone;
	}


	public static DateTimeTimezone CreateDateTimeTimezoneInHoursAndMinutes(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetHours, double timezoneOffsetMinutes){
		DateTimeTimezone dateTimeTimezone;

		dateTimeTimezone = new DateTimeTimezone();

		dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
		dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes);

		return dateTimeTimezone;
	}


	public static bool GetDateFromDateTimeTimeZone(DateTimeTimezone dateTimeTimezone, DateTimeReference dateTimeReference, StringReference message){
		DateTime dateTime;

		dateTime = dateTimeTimezone.dateTime;

		return AddSecondsToDateTimeWithCheck(dateTime, -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message);
	}


	public static bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(DateTime dateTime, double timezoneOffsetSeconds, DateTimeTimezoneReference dateTimeTimezoneReference, StringReference message){
		bool success;
		DateTimeReference adjustedDateTimeReference;
		DateTimeTimezone dateTimeTimezone;

		adjustedDateTimeReference = new DateTimeReference();
		dateTimeTimezone = new DateTimeTimezone();

		success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message);

		if(success){
			dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime;
			dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

			dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone;
		}

		return success;
	}


	public static bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(DateTime dateTime, double timezoneOffsetHours, double timezoneOffsetMinutes, DateTimeTimezoneReference dateTimeTimezoneReference, StringReference message){
		return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message);
	}


	public static bool GetDateTimeTimezoneFromSeconds(DateTimeTimezoneReference dateTimeTzRef, double seconds, double offset, StringReference message){
		bool success;
		DateTimeReference dateTimeRef;

		dateTimeRef = new DateTimeReference();
		success = GetDateTimeFromSeconds(seconds, dateTimeRef, message);

		if(success){
			success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTime, offset, dateTimeTzRef, message);
		}

		return success;
	}


	public static DateTime CreateDateTime(double year, double month, double day, double hours, double minutes, double seconds){
		DateTime dateTime;

		dateTime = new DateTime();

		dateTime.date = CreateDate(year, month, day);
		dateTime.hours = hours;
		dateTime.minutes = minutes;
		dateTime.seconds = seconds;

		return dateTime;
	}


	public static bool GetDateTimeFromSeconds(double seconds, DateTimeReference dateTimeReference, StringReference message){
		DateTime dateTime;
		double secondsInMinute, secondsInHour, secondsInDay, days, remainder;
		Date date;
		DateReference dateReference;
		bool success;

		secondsInMinute = 60d;
		secondsInHour = 60d*secondsInMinute;
		secondsInDay = 24d*secondsInHour;
		days = Floor(seconds/secondsInDay);
		remainder = seconds - days*secondsInDay;
		dateReference = new DateReference();

		success = DayToDateWithCheck(days, dateReference, message);
		if(success){
			date = dateReference.date;

			dateTime = new DateTime();
			dateTime.date = date;
			dateTime.hours = Floor(remainder/secondsInHour);
			remainder = remainder - dateTime.hours*secondsInHour;
			dateTime.minutes = Floor(remainder/secondsInMinute);
			remainder = remainder - dateTime.minutes*secondsInMinute;
			dateTime.seconds = remainder;

			dateTimeReference.dateTime = dateTime;
		}

		return success;
	}


	public static double GetSecondsFromDateTime(DateTime dateTime){
		double seconds, secondsInMinute, secondsInHour;

		secondsInMinute = 60d;
		secondsInHour = 60d*secondsInMinute;

		seconds = GetSecondsFromDate(dateTime.date);
		seconds = seconds + secondsInHour*dateTime.hours;
		seconds = seconds + secondsInMinute*dateTime.minutes;
		seconds = seconds + dateTime.seconds;

		return seconds;
	}


	public static double GetSecondsFromMinutes(double minutes){
		return minutes*60d;
	}


	public static double GetSecondsFromHours(double hours){
		return GetSecondsFromMinutes(hours*60d);
	}


	public static double GetSecondsFromDays(double days){
		return GetSecondsFromHours(days*24d);
	}


	public static double GetSecondsFromWeeks(double weeks){
		return GetSecondsFromDays(weeks*7d);
	}


	public static double GetMinutesFromSeconds(double seconds){
		return seconds/60d;
	}


	public static double GetHoursFromSeconds(double seconds){
		return GetMinutesFromSeconds(seconds)/60d;
	}


	public static double GetDaysFromSeconds(double seconds){
		return GetHoursFromSeconds(seconds)/24d;
	}


	public static double GetWeeksFromSeconds(double seconds){
		return GetDaysFromSeconds(seconds)/7d;
	}


	public static Date GetDateFromDateTime(DateTime dateTime){
		return dateTime.date;
	}


	public static bool AddSecondsToDateTimeWithCheck(DateTime dateTime, double seconds, DateTimeReference dateTimeReference, StringReference message){
		double secondsInDateTime;
		bool success;

		if(IsValidDateTime(dateTime, message)){
			secondsInDateTime = GetSecondsFromDateTime(dateTime);
			secondsInDateTime = secondsInDateTime + seconds;

			success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
		}else{
			success = false;
		}

		return success;
	}


	public static bool AddSecondsToDateTime(DateTime dateTime, double seconds, DateTimeReference dateTimeReference, StringReference message){
		double secondsInDateTime;

		secondsInDateTime = GetSecondsFromDateTime(dateTime);
		secondsInDateTime = secondsInDateTime + seconds;

		return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
	}


	public static bool AddMinutesToDateTime(DateTime dateTime, double minutes, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message);
	}


	public static bool AddHoursToDateTime(DateTime dateTime, double hours, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message);
	}


	public static bool AddDaysToDateTime(DateTime dateTime, double days, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message);
	}


	public static bool AddWeeksToDateTime(DateTime dateTime, double weeks, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message);
	}


	public static bool DateTimeToStringISO8601WithCheck(DateTime datetime, StringReference dateStr, StringReference message){
		bool success;

		success = DateToStringISO8601WithCheck(datetime.date, dateStr, message);

		if(success){
			delete(dateStr.stringx);

			success = IsValidDateTime(datetime, message);
			if(success){
				dateStr.stringx = DateTimeToStringISO8601(datetime);
			}
		}

		return success;
	}


	public static bool IsValidDateTime(DateTime datetime, StringReference message){
		bool success;

		success = IsValidDate(datetime.date, message);

		if(success){
			if(datetime.hours <= 23d && datetime.hours >= 0d){
				if(datetime.minutes <= 59d && datetime.minutes >= 0d){
					if(datetime.seconds <= 59d && datetime.seconds >= 0d){
						success = true;
					}else{
						success = false;
						message.stringx = "Seconds must be between 0 and 59.".ToCharArray();
					}
				}else{
					success = false;
					message.stringx = "Minutes must be between 0 and 59.".ToCharArray();
				}
			}else{
				success = false;
				message.stringx = "Hours must be between 0 and 23.".ToCharArray();
			}
		}

		return success;
	}


	public static char [] DateTimeToStringISO8601(DateTime datetime){
		char [] datestr, str;
		double i;

		str = new char [19];

		datestr = DateToStringISO8601(datetime.date);
		for(i = 0d; i < datestr.Length; i = i + 1d){
			str[(int)(i)] = datestr[(int)(i)];
		}

		str[10] = 'T';
		str[11] = cDecimalDigitToCharacter(Floor((datetime.hours%100d)/10d));
		str[12] = cDecimalDigitToCharacter(Floor(datetime.hours%10d));

		str[13] = ':';

		str[14] = cDecimalDigitToCharacter(Floor((datetime.minutes%100d)/10d));
		str[15] = cDecimalDigitToCharacter(Floor(datetime.minutes%10d));

		str[16] = ':';

		str[17] = cDecimalDigitToCharacter(Floor((datetime.seconds%100d)/10d));
		str[18] = cDecimalDigitToCharacter(Floor(datetime.seconds%10d));

		return str;
	}


	public static DateTime DateTimeFromStringISO8601(char [] str){
		DateTime dateTime;
		double n;

		dateTime = new DateTime();

		dateTime.date = DateFromStringISO8601(str);

		n = cCharacterToDecimalDigit(str[11])*10d;
		n = n + cCharacterToDecimalDigit(str[12])*1d;

		dateTime.hours = n;

		n = cCharacterToDecimalDigit(str[14])*10d;
		n = n + cCharacterToDecimalDigit(str[15])*1d;

		dateTime.minutes = n;

		n = cCharacterToDecimalDigit(str[17])*10d;
		n = n + cCharacterToDecimalDigit(str[18])*1d;

		dateTime.seconds = n;

		return dateTime;
	}


	public static bool DateTimeFromStringISO8601WithCheck(char [] str, DateTimeReference dateTimeRef, StringReference message){
		bool valid;

		valid = IsValidDateTimeISO8601(str, message);

		if(valid){
			dateTimeRef.dateTime = DateTimeFromStringISO8601(str);
		}

		return valid;
	}


	public static bool IsValidDateTimeISO8601(char [] str, StringReference message){
		bool valid;

		if(str.Length == 4d + 1d + 2d + 1d + 2d + 1d + 2d + 1d + 2d + 1d + 2d){

			if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9]) && cIsNumber(str[11]) && cIsNumber(str[12]) && cIsNumber(str[14]) && cIsNumber(str[15]) && cIsNumber(str[17]) && cIsNumber(str[18])){
				if(str[4] == '-' && str[7] == '-' && str[10] == 'T' && str[13] == ':' && str[16] == ':'){
					valid = true;
				}else{
					valid = false;
					message.stringx = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.".ToCharArray();
				}
			}else{
				valid = false;
				message.stringx = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.".ToCharArray();
			}
		}else{
			valid = false;
			message.stringx = "ISO8601 date must be exactly 19 characters long.".ToCharArray();
		}

		return valid;
	}


	public static bool DateTimeEquals(DateTime a, DateTime b){
		return DateEquals(a.date, b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds;
	}


	public static void FreeDateTime(DateTime datetime){
		delete(datetime.date);
		delete(datetime);
	}


	public static FixedPoint30d CreateFixedPoint30d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
		FixedPoint30d fp;

		fp = new FixedPoint30d();
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
		fp.part1 = 0d;
		fp.part2 = 0d;

		return fp;
	}


	public static FixedPoint15d CreateFixedPoint15d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
		FixedPoint15d fp;

		fp = new FixedPoint15d();
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
		fp.number = 0d;

		return fp;
	}


	public static double ToNumber15d(FixedPoint15d n){
		return n.number;
	}


	public static FixedPoint15d Number15d(double number){
		FixedPoint15d fp;

		fp = new FixedPoint15d();
		fp.digitsBeforeDecimalPoint = 7d;
		fp.digitsAfterDecimalPoint = 7d;
		fp.number = number;

		return fp;
	}


	public static bool Assign15d(FixedPoint15d fp, double number){
		bool success;

		success = !WillOverflow15d(fp, number);
		success = success && FixedPointIsValid15d(fp);

		if(success){
			fp.number = number;
			fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint);
		}

		return success;
	}


	public static bool Assign15dFloor(FixedPoint15d fp, double number){
		bool success;

		success = !WillOverflow15d(fp, number);
		success = success && FixedPointIsValid15d(fp);

		if(success){
			fp.number = number;
			fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint);
		}

		return success;
	}


	public static bool FixedPointIsValid15d(FixedPoint15d fp){
		bool valid;

		if(IsInteger(fp.digitsAfterDecimalPoint) && IsInteger(fp.digitsBeforeDecimalPoint)){
			if(fp.digitsBeforeDecimalPoint >= 0d && fp.digitsBeforeDecimalPoint <= 15d){
				if(fp.digitsAfterDecimalPoint >= 0d && fp.digitsAfterDecimalPoint <= 15d){
					if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15d){
						if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0d){
							valid = true;
						}else{
							valid = false;
						}
					}else{
						valid = false;
					}
				}else{
					valid = false;
				}
			}else{
				valid = false;
			}
		}else{
			valid = false;
		}

		return valid;
	}


	public static bool WillOverflow15d(FixedPoint15d fp, double number){
		bool overflow;

		if(Abs(number) < Pow(10d, fp.digitsBeforeDecimalPoint)){
			overflow = false;
		}else{
			overflow = true;
		}

		return overflow;
	}


	public static double FloorToDigits(double value, double digits){
		return Floor(value*Pow(10d, digits))/Pow(10d, digits);
	}


	public static char [] ToString15d(FixedPoint15d fp){
		char [] stringx;
		double digits;
		double digitPosition;
		double i, d, decimalx;
		CharacterReference characterReference;

		stringx = new char [(int)(1d + fp.digitsBeforeDecimalPoint + 1d + fp.digitsAfterDecimalPoint)];

		decimalx = fp.number*Pow(10d, fp.digitsAfterDecimalPoint);

		if(decimalx < 0d){
			decimalx = -decimalx;
			stringx[0] = '-';
		}else{
			stringx[0] = '+';
		}

		decimalx = Roundx(decimalx);

		characterReference = new CharacterReference();

		digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint;
		digitPosition = 1d;

		for(i = 0d; i < digits; i = i + 1d){
			if(i == fp.digitsBeforeDecimalPoint){
				stringx[(int)(digitPosition)] = '.';

				digitPosition = digitPosition + 1d;
			}

			d = Floor(decimalx/Pow(10d, digits - i - 1d));
			d = d%10d;

			GetSingleDigitCharacterFromNumberWithCheck(d, 10d, characterReference);
			stringx[(int)(digitPosition)] = characterReference.characterValue;

			digitPosition = digitPosition + 1d;
		}

		delete(characterReference);

		return stringx;
	}


	public static bool Add15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d c){
		return Assign15d(a, b.number + c.number);
	}


	public static bool Subtract15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d c){
		return Assign15d(a, b.number - c.number);
	}


	public static bool Multiply15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d c){
		return Assign15d(a, b.number*c.number);
	}


	public static bool DivideFloored15d(FixedPoint15d q, FixedPoint15d r, FixedPoint15d a, FixedPoint15d b){
		bool success;
		double x, xDivisor, xDividend;
		FixedPoint15d t;

		t = Copy15d(r);

		if(b.number != 0d){
			xDivisor = Roundx(a.number*Pow(10d, q.digitsAfterDecimalPoint)*Pow(10d, q.digitsAfterDecimalPoint));
			xDividend = Roundx(b.number*Pow(10d, q.digitsAfterDecimalPoint));
			x = Floor(xDivisor/xDividend);
			x = x/Pow(10d, q.digitsAfterDecimalPoint);
			success = Assign15d(q, x);
			Multiply15d(t, q, b);
			Subtract15d(r, a, t);
		}else{
			success = false;
		}

		delete(t);

		return success;
	}


	public static FixedPoint15d Copy15d(FixedPoint15d r){
		FixedPoint15d t;

		t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint);
		t.number = r.number;

		return t;
	}


	public static void Negate15d(FixedPoint15d a){
		a.number = -a.number;
	}


	public static void Positive15d(FixedPoint15d a){
		a.number = +a.number;
	}


	public static bool Factorial15d(FixedPoint15d x){
		bool success;

		if(x.number >= 0d){
			success = Assign15d(x, Factorial(x.number));
		}else{
			success = false;
		}

		return success;
	}


	public static bool Round15d(FixedPoint15d x){
		return Assign15d(x, Roundx(x.number));
	}


	public static bool BankersRound15d(FixedPoint15d x){
		return Assign15d(x, BankersRound(x.number));
	}


	public static bool Ceil15d(FixedPoint15d x){
		return Assign15d(x, Ceil(x.number));
	}


	public static bool Floor15d(FixedPoint15d x){
		return Assign15d(x, Floor(x.number));
	}


	public static void Truncate15d(FixedPoint15d x){
		x.number = Truncate(x.number);
	}


	public static void Absolute15d(FixedPoint15d x){
		x.number = Abs(x.number);
	}


	public static bool Logarithm15d(FixedPoint15d x){
		bool success;

		if(x.number > 0d){
			success = Assign15d(x, Logarithm(x.number));
		}else{
			success = false;
		}

		return success;
	}


	public static bool NaturalLogarithm15d(FixedPoint15d x){
		bool success;

		if(x.number > 0d){
			success = Assign15d(x, NaturalLogarithm(x.number));
		}else{
			success = false;
		}

		return success;
	}


	public static bool Sin15d(FixedPoint15d x){
		return Assign15d(x, Sinx(x.number));
	}


	public static bool Cos15d(FixedPoint15d x){
		return Assign15d(x, Cosx(x.number));
	}


	public static bool Tan15d(FixedPoint15d x){
		return Assign15d(x, Tanx(x.number));
	}


	public static bool Asin15d(FixedPoint15d x){
		bool success;

		if(x.number >= -1d && x.number <= 1d){
			success = Assign15d(x, Asinx(x.number));
		}else{
			success = false;
		}

		return success;
	}


	public static bool Acos15d(FixedPoint15d x){
		bool success;

		if(x.number >= -1d && x.number <= 1d){
			success = Assign15d(x, Acosx(x.number));
		}else{
			success = false;
		}

		return success;
	}


	public static bool Atan15d(FixedPoint15d x){
		return Assign15d(x, Atanx(x.number));
	}


	public static bool Atan2_15d(FixedPoint15d a, FixedPoint15d y, FixedPoint15d x){
		return Assign15d(a, Atan2(y.number, x.number));
	}


	public static bool Squareroot15d(FixedPoint15d x){
		bool success;

		if(x.number >= 0d){
			success = Assign15d(x, Sqrt(x.number));
		}else{
			success = false;
		}

		return success;
	}


	public static bool Exp15d(FixedPoint15d x){
		return Assign15d(x, Expx(x.number));
	}


	public static bool DivisibleBy15d(FixedPoint15d a, FixedPoint15d b){
		return ((a.number%b.number) == 0d);
	}


	public static bool Combinations15d(FixedPoint15d x, FixedPoint15d n, FixedPoint15d k){
		bool success;

		if(IsInteger(n.number) && IsInteger(k.number)){
			if(n.number >= 1d && k.number >= 0d && n.number >= k.number){
				success = Assign15d(x, Combinations(n.number, k.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool Permutations15d(FixedPoint15d x, FixedPoint15d n, FixedPoint15d k){
		bool success;

		if(IsInteger(n.number) && IsInteger(k.number)){
			if(n.number >= 1d && k.number >= 0d && n.number >= k.number){
				success = Assign15d(x, Permutations(n.number, k.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool Equals15d(FixedPoint15d a, FixedPoint15d b){
		double p, an, bn;
		bool equals;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		p = Max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint);

		equals = EpsilonCompare(an, bn, Pow(10d, -p));

		return equals;
	}


	public static bool GreaterThan15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		return an > bn;
	}


	public static bool LessThan15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		return an < bn;
	}


	public static bool GreaterThanOrEqual15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;
		bool equal;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		equal = Equals15d(a, b);

		return an > bn || equal;
	}


	public static bool LessThanOrEqual15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;
		bool equal;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		equal = Equals15d(a, b);

		return an < bn || equal;
	}


	public static bool EpsilonCompare15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d epsilon){
		return EpsilonCompare(a.number, b.number, epsilon.number);
	}


	public static bool GreatestCommonDivisor15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		bool success;

		if(IsInteger(a.number) && IsInteger(b.number)){
			if(a.number >= 0d && b.number >= 0d){
				success = Assign15d(x, GreatestCommonDivisor(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool GCDWithSubtraction15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		bool success;

		if(IsInteger(a.number) && IsInteger(b.number)){
			if(a.number >= 0d && b.number >= 0d){
				success = Assign15d(x, GCDWithSubtraction(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool IsInteger15d(FixedPoint15d a){
		return IsInteger(a.number);
	}


	public static bool LeastCommonMultiple15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		bool success;

		if(IsInteger(a.number) && IsInteger(b.number)){
			if(a.number != 0d && b.number != 0d){
				success = Assign15d(x, LeastCommonMultiple(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static double Sign15d(FixedPoint15d a){
		return Sign(a.number);
	}


	public static bool Max15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		return Assign15d(x, Maxx(a.number, b.number));
	}


	public static bool Min15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		return Assign15d(x, Minx(a.number, b.number));
	}


	public static bool Power15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		bool success;

		if(a.number != 0d || b.number != 0d){
			if(!(a.number < 0d && !IsInteger(b.number))){
				success = Assign15d(x, Power(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static char [] FormatToString15d(FixedPoint15d fp, double digitsAfter){
		char [] result;

		result = FormatToStringWithSymbols15d(fp, digitsAfter, "".ToCharArray(), ".".ToCharArray());

		return result;
	}


	public static char [] FormatToStringWithSymbols15d(FixedPoint15d fp, double digitsAfter, char [] thousandsSeparator, char [] decimalPoint){
		char [] stringx;
		double i, j, p, d, t, sign, extra, decimalx, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars;
		CharacterReference characterReference;

		characterReference = new CharacterReference();

		decimalx = Roundx(fp.number*Pow(10d, digitsAfter));

		sign = 0d;
		if(decimalx < 0d){
			sign = 1d;
			decimalx = -decimalx;
		}

		if(decimalx != 0d){
			digits = Floor(Log10(decimalx) + 1d);
		}else{
			digits = 1d;
		}
		digitsBefore = digits - digitsAfter;

		if(digitsBefore <= 0d){
			digitsBefore = 0d;
			thousandsTimes = 0d;
			digits = digitsAfter + 1d;
		}else{
			thousandsTimes = Floor((digitsBefore - 1d)/3d);
		}
		thousandsChars = thousandsTimes*thousandsSeparator.Length;

		if(digitsAfter == 0d){
			decimalPointChars = 0d;
		}else{
			decimalPointChars = decimalPoint.Length;
		}

		stringx = new char [(int)(sign + digits + thousandsChars + decimalPointChars)];
		p = 0d;

		if(sign > 0d){
			stringx[(int)(p)] = '-';
			p = p + 1d;
		}

		for(i = 0d; i < digits; i = i + 1d){
			if(i == digitsBefore){
				if(i == 0d){
					stringx[(int)(p)] = '0';
					p = p + 1d;
					digits = digits - 1d;
				}

				for(j = 0d; j < decimalPoint.Length; j = j + 1d){
					stringx[(int)(p)] = decimalPoint[(int)(j)];
					p = p + 1d;
				}
			}

			if(i < digitsBefore){
				if((digitsBefore - i)%3d == 0d && i != 0d){
					for(j = 0d; j < thousandsSeparator.Length; j = j + 1d){
						stringx[(int)(p)] = thousandsSeparator[(int)(j)];
						p = p + 1d;
					}
				}
			}

			d = Floor(decimalx/Pow(10d, digits - i - 1d));
			d = d%10d;

			GetSingleDigitCharacterFromNumberWithCheck(d, 10d, characterReference);
			stringx[(int)(p)] = characterReference.characterValue;

			p = p + 1d;
		}

		/* System.out.println(new String(string));*/
		return stringx;
	}


	public static char [] NumberToHumanReadable(double n, double digitsAfter, char [] thousandsSeparator, char [] decimalPoint){
		char [] str;
		char u;
		double d, p3;

		if(Abs(n) < 1d){
			str = CreateStringDecimalFromNumber(n);
		}else{
			d = Log10(n);

			p3 = Min(Floor(d/3d), 8d);

			if(p3 == 0d){
				u = 'B';
			}else if(p3 == 1d){
				u = 'K';
			}else if(p3 == 2d){
				u = 'M';
			}else if(p3 == 3d){
				u = 'G';
			}else if(p3 == 4d){
				u = 'T';
			}else if(p3 == 5d){
				u = 'P';
			}else if(p3 == 6d){
				u = 'E';
			}else if(p3 == 7d){
				u = 'Z';
			}else{
				u = 'Y';
			}

			if(p3 > 1d){
				n = n/Pow(10d, p3*3d);
			}

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

			if(p3 > 1d){
				str = strAppendCharacter(str, u);
			}
		}

		return str;
	}


	public static char [] NumberToHumanReadableBinaryPrefix(double n, double digitsAfter, char [] thousandsSeparator, char [] decimalPoint){
		char [] str;
		char [] u;
		double d, p3;

		if(Abs(n) < 1d){
			str = CreateStringDecimalFromNumber(n);
		}else{
			d = Floor(Log(n)/Log(2d)) + 1d;

			p3 = Min(Floor(d/10d), 8d);

			if(p3 == 0d){
				u = "B".ToCharArray();
			}else if(p3 == 1d){
				u = "Ki".ToCharArray();
			}else if(p3 == 2d){
				u = "Mi".ToCharArray();
			}else if(p3 == 3d){
				u = "Gi".ToCharArray();
			}else if(p3 == 4d){
				u = "Ti".ToCharArray();
			}else if(p3 == 5d){
				u = "Pi".ToCharArray();
			}else if(p3 == 6d){
				u = "Ei".ToCharArray();
			}else if(p3 == 7d){
				u = "Zi".ToCharArray();
			}else{
				u = "Yi".ToCharArray();
			}

			if(p3 > 1d){
				n = n/Pow(2d, p3*10d);
			}

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

			if(p3 > 1d){
				str = strAppendString(str, u);
			}
		}

		return str;
	}


	public static double [] AddNumber(double [] list, double a){
		double [] newlist;
		double i;

		newlist = new double [(int)(list.Length + 1d)];
		for(i = 0d; i < list.Length; i = i + 1d){
			newlist[(int)(i)] = list[(int)(i)];
		}
		newlist[(int)(list.Length)] = a;
		
		delete(list);
		
		return newlist;
	}


	public static void AddNumberRef(NumberArrayReference list, double i){
		list.numberArray = AddNumber(list.numberArray, i);
	}


	public static double [] RemoveNumber(double [] list, double n){
		double [] newlist;
		double i;

		newlist = new double [(int)(list.Length - 1d)];

		if(n >= 0d && n < list.Length){
			for(i = 0d; i < list.Length; i = i + 1d){
				if(i < n){
					newlist[(int)(i)] = list[(int)(i)];
				}
				if(i > n){
					newlist[(int)(i - 1d)] = list[(int)(i)];
				}
			}

			delete(list);
		}else{
			delete(newlist);
		}
		
		return newlist;
	}


	public static double GetNumberRef(NumberArrayReference list, double i){
		return list.numberArray[(int)(i)];
	}


	public static void RemoveNumberRef(NumberArrayReference list, double i){
		list.numberArray = RemoveNumber(list.numberArray, i);
	}


	public static StringReference [] AddString(StringReference [] list, StringReference a){
		StringReference [] newlist;
		double i;

		newlist = new StringReference [(int)(list.Length + 1d)];

		for(i = 0d; i < list.Length; i = i + 1d){
			newlist[(int)(i)] = list[(int)(i)];
		}
		newlist[(int)(list.Length)] = a;
		
		delete(list);
		
		return newlist;
	}


	public static void AddStringRef(StringArrayReference list, StringReference i){
		list.stringArray = AddString(list.stringArray, i);
	}


	public static StringReference [] RemoveString(StringReference [] list, double n){
		StringReference [] newlist;
		double i;

		newlist = new StringReference [(int)(list.Length - 1d)];

		if(n >= 0d && n < list.Length){
			for(i = 0d; i < list.Length; i = i + 1d){
				if(i < n){
					newlist[(int)(i)] = list[(int)(i)];
				}
				if(i > n){
					newlist[(int)(i - 1d)] = list[(int)(i)];
				}
			}

			delete(list);
		}else{
			delete(newlist);
		}
		
		return newlist;
	}


	public static StringReference GetStringRef(StringArrayReference list, double i){
		return list.stringArray[(int)(i)];
	}


	public static void RemoveStringRef(StringArrayReference list, double i){
		list.stringArray = RemoveString(list.stringArray, i);
	}


	public static DynamicArrayCharacters CreateDynamicArrayCharacters(){
		DynamicArrayCharacters da;

		da = new DynamicArrayCharacters();
		da.array = new char [10];
		da.length = 0d;

		return da;
	}


	public static DynamicArrayCharacters CreateDynamicArrayCharactersWithInitialCapacity(double capacity){
		DynamicArrayCharacters da;

		da = new DynamicArrayCharacters();
		da.array = new char [(int)(capacity)];
		da.length = 0d;

		return da;
	}


	public static void DynamicArrayAddCharacter(DynamicArrayCharacters da, char value){
		if(da.length == da.array.Length){
			DynamicArrayCharactersIncreaseSize(da);
		}

		da.array[(int)(da.length)] = value;
		da.length = da.length + 1d;
	}


	public static void DynamicArrayAddString(DynamicArrayCharacters da, char [] str){
		double i;

		for(i = 0d; i < str.Length; i = i + 1d){
			DynamicArrayAddCharacter(da, str[(int)(i)]);
		}
	}


	public static void DynamicArrayCharactersIncreaseSize(DynamicArrayCharacters da){
		double newLength, i;
		char [] newArray;

		newLength = (double)Round(da.array.Length*3d/2d);
		newArray = new char [(int)(newLength)];

		for(i = 0d; i < da.array.Length; i = i + 1d){
			newArray[(int)(i)] = da.array[(int)(i)];
		}

		delete(da.array);

		da.array = newArray;
	}


	public static bool DynamicArrayCharactersDecreaseSizeNecessary(DynamicArrayCharacters da){
		bool needsDecrease;

		needsDecrease = false;

		if(da.length > 10d){
			needsDecrease = da.length <= (double)Round(da.array.Length*2d/3d);
		}

		return needsDecrease;
	}


	public static void DynamicArrayCharactersDecreaseSize(DynamicArrayCharacters da){
		double newLength, i;
		char [] newArray;

		newLength = (double)Round(da.array.Length*2d/3d);
		newArray = new char [(int)(newLength)];

		for(i = 0d; i < newLength; i = i + 1d){
			newArray[(int)(i)] = da.array[(int)(i)];
		}

		delete(da.array);

		da.array = newArray;
	}


	public static char DynamicArrayCharactersIndex(DynamicArrayCharacters da, double index){
		return da.array[(int)(index)];
	}


	public static double DynamicArrayCharactersLength(DynamicArrayCharacters da){
		return da.length;
	}


	public static void DynamicArrayInsertCharacter(DynamicArrayCharacters da, double index, char value){
		double i;

		if(da.length == da.array.Length){
			DynamicArrayCharactersIncreaseSize(da);
		}

		for(i = da.length; i > index; i = i - 1d){
			da.array[(int)(i)] = da.array[(int)(i - 1d)];
		}

		da.array[(int)(index)] = value;

		da.length = da.length + 1d;
	}


	public static bool DynamicArrayCharacterSet(DynamicArrayCharacters da, double index, char value){
		bool success;

		if(index < da.length){
			da.array[(int)(index)] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static void DynamicArrayRemoveCharacter(DynamicArrayCharacters da, double index){
		double i;

		for(i = index; i < da.length - 1d; i = i + 1d){
			da.array[(int)(i)] = da.array[(int)(i + 1d)];
		}

		da.length = da.length - 1d;

		if(DynamicArrayCharactersDecreaseSizeNecessary(da)){
			DynamicArrayCharactersDecreaseSize(da);
		}
	}


	public static void FreeDynamicArrayCharacters(DynamicArrayCharacters da){
		delete(da.array);
		delete(da);
	}


	public static char [] DynamicArrayCharactersToArray(DynamicArrayCharacters da){
		char [] array;
		double i;

		array = new char [(int)(da.length)];

		for(i = 0d; i < da.length; i = i + 1d){
			array[(int)(i)] = da.array[(int)(i)];
		}

		return array;
	}


	public static DynamicArrayCharacters ArrayToDynamicArrayCharactersWithOptimalSize(char [] array){
		DynamicArrayCharacters da;
		double i;
		double c, n, newCapacity;

		c = array.Length;
		n = (Log(c) - 1d)/Log(3d/2d);
		newCapacity = Ceiling(10d*Pow(3d/2d, n));

		da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity);

		for(i = 0d; i < array.Length; i = i + 1d){
			da.array[(int)(i)] = array[(int)(i)];
		}

		return da;
	}


	public static DynamicArrayCharacters ArrayToDynamicArrayCharacters(char [] array){
		DynamicArrayCharacters da;

		da = new DynamicArrayCharacters();
		da.array = arraysCopyString(array);
		da.length = array.Length;

		return da;
	}


	public static bool DynamicArrayCharactersEqual(DynamicArrayCharacters a, DynamicArrayCharacters b){
		bool equal;
		double i;

		equal = true;
		if(a.length == b.length){
			for(i = 0d; i < a.length && equal; i = i + 1d){
				if(a.array[(int)(i)] != b.array[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static LinkedListCharacters DynamicArrayCharactersToLinkedList(DynamicArrayCharacters da){
		LinkedListCharacters ll;
		double i;

		ll = CreateLinkedListCharacter();

		for(i = 0d; i < da.length; i = i + 1d){
			LinkedListAddCharacter(ll, da.array[(int)(i)]);
		}

		return ll;
	}


	public static DynamicArrayCharacters LinkedListToDynamicArrayCharacters(LinkedListCharacters ll){
		DynamicArrayCharacters da;
		double i;
		LinkedListNodeCharacters node;

		node = ll.first;

		da = new DynamicArrayCharacters();
		da.length = LinkedListCharactersLength(ll);

		da.array = new char [(int)(da.length)];

		for(i = 0d; i < da.length; i = i + 1d){
			da.array[(int)(i)] = node.value;
			node = node.next;
		}

		return da;
	}


	public static bool [] AddBoolean(bool [] list, bool a){
		bool [] newlist;
		double i;

		newlist = new bool [(int)(list.Length + 1d)];
		for(i = 0d; i < list.Length; i = i + 1d){
			newlist[(int)(i)] = list[(int)(i)];
		}
		newlist[(int)(list.Length)] = a;
		
		delete(list);
		
		return newlist;
	}


	public static void AddBooleanRef(BooleanArrayReference list, bool i){
		list.booleanArray = AddBoolean(list.booleanArray, i);
	}


	public static bool [] RemoveBoolean(bool [] list, double n){
		bool [] newlist;
		double i;

		newlist = new bool [(int)(list.Length - 1d)];

		if(n >= 0d && n < list.Length){
			for(i = 0d; i < list.Length; i = i + 1d){
				if(i < n){
					newlist[(int)(i)] = list[(int)(i)];
				}
				if(i > n){
					newlist[(int)(i - 1d)] = list[(int)(i)];
				}
			}

			delete(list);
		}else{
			delete(newlist);
		}
		
		return newlist;
	}


	public static bool GetBooleanRef(BooleanArrayReference list, double i){
		return list.booleanArray[(int)(i)];
	}


	public static void RemoveDecimalRef(BooleanArrayReference list, double i){
		list.booleanArray = RemoveBoolean(list.booleanArray, i);
	}


	public static LinkedListStrings CreateLinkedListString(){
		LinkedListStrings ll;

		ll = new LinkedListStrings();
		ll.first = new LinkedListNodeStrings();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}


	public static void LinkedListAddString(LinkedListStrings ll, char [] value){
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeStrings();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}


	public static StringReference [] LinkedListStringsToArray(LinkedListStrings ll){
		StringReference [] array;
		double length, i;
		LinkedListNodeStrings node;

		node = ll.first;

		length = LinkedListStringsLength(ll);

		array = new StringReference [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			array[(int)(i)] = new StringReference();
			array[(int)(i)].stringx = node.value;
			node = node.next;
		}

		return array;
	}


	public static double LinkedListStringsLength(LinkedListStrings ll){
		double l;
		LinkedListNodeStrings node;

		l = 0d;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1d;
		}

		return l;
	}


	public static void FreeLinkedListString(LinkedListStrings ll){
		LinkedListNodeStrings node, prev;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			delete(prev);
		}

		delete(node);
	}


	public static void LinkedListInsertString(LinkedListStrings ll, double index, char [] value){
		double i;
		LinkedListNodeStrings node, tmp;

		if(index == 0d){
			tmp = ll.first;
			ll.first = new LinkedListNodeStrings();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0d; i < index - 1d; i = i + 1d){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeStrings();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}


	public static LinkedListNumbers CreateLinkedListNumbers(){
		LinkedListNumbers ll;

		ll = new LinkedListNumbers();
		ll.first = new LinkedListNodeNumbers();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}


	public static LinkedListNumbers [] CreateLinkedListNumbersArray(double length){
		LinkedListNumbers [] lls;
		double i;

		lls = new LinkedListNumbers [(int)(length)];
		for(i = 0d; i < lls.Length; i = i + 1d){
			lls[(int)(i)] = CreateLinkedListNumbers();
		}

		return lls;
	}


	public static void LinkedListAddNumber(LinkedListNumbers ll, double value){
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeNumbers();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}


	public static double LinkedListNumbersLength(LinkedListNumbers ll){
		double l;
		LinkedListNodeNumbers node;

		l = 0d;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1d;
		}

		return l;
	}


	public static double LinkedListNumbersIndex(LinkedListNumbers ll, double index){
		double i;
		LinkedListNodeNumbers node;

		node = ll.first;
		for(i = 0d; i < index; i = i + 1d){
			node = node.next;
		}

		return node.value;
	}


	public static void LinkedListInsertNumber(LinkedListNumbers ll, double index, double value){
		double i;
		LinkedListNodeNumbers node, tmp;

		if(index == 0d){
			tmp = ll.first;
			ll.first = new LinkedListNodeNumbers();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0d; i < index - 1d; i = i + 1d){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeNumbers();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}


	public static void LinkedListSet(LinkedListNumbers ll, double index, double value){
		double i;
		LinkedListNodeNumbers node;

		node = ll.first;
		for(i = 0d; i < index; i = i + 1d){
			node = node.next;
		}

		node.next.value = value;
	}


	public static void LinkedListRemoveNumber(LinkedListNumbers ll, double index){
		double i;
		LinkedListNodeNumbers node, prev;

		node = ll.first;
		prev = ll.first;

		for(i = 0d; i < index; i = i + 1d){
			prev = node;
			node = node.next;
		}

		if(index == 0d){
			ll.first = prev.next;
		}
		if(!prev.next.end){
			prev.next = prev.next.next;
		}
	}


	public static void FreeLinkedListNumbers(LinkedListNumbers ll){
		LinkedListNodeNumbers node, prev;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			delete(prev);
		}

		delete(node);
	}


	public static void FreeLinkedListNumbersArray(LinkedListNumbers [] lls){
		double i;

		for(i = 0d; i < lls.Length; i = i + 1d){
			FreeLinkedListNumbers(lls[(int)(i)]);
		}
		delete(lls);
	}


	public static double [] LinkedListNumbersToArray(LinkedListNumbers ll){
		double [] array;
		double length, i;
		LinkedListNodeNumbers node;

		node = ll.first;

		length = LinkedListNumbersLength(ll);

		array = new double [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			array[(int)(i)] = node.value;
			node = node.next;
		}

		return array;
	}


	public static LinkedListNumbers ArrayToLinkedListNumbers(double [] array){
		LinkedListNumbers ll;
		double i;

		ll = CreateLinkedListNumbers();

		for(i = 0d; i < array.Length; i = i + 1d){
			LinkedListAddNumber(ll, array[(int)(i)]);
		}

		return ll;
	}


	public static bool LinkedListNumbersEqual(LinkedListNumbers a, LinkedListNumbers b){
		bool equal, done;
		LinkedListNodeNumbers an, bn;

		an = a.first;
		bn = b.first;

		equal = true;
		done = false;
		for(; equal && !done; ){
			if(an.end == bn.end){
				if(an.end){
					done = true;
				}else if(an.value == bn.value){
					an = an.next;
					bn = bn.next;
				}else{
					equal = false;
				}
			}else{
				equal = false;
			}
		}

		return equal;
	}


	public static LinkedListCharacters CreateLinkedListCharacter(){
		LinkedListCharacters ll;

		ll = new LinkedListCharacters();
		ll.first = new LinkedListNodeCharacters();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}


	public static void LinkedListAddCharacter(LinkedListCharacters ll, char value){
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeCharacters();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}


	public static char [] LinkedListCharactersToArray(LinkedListCharacters ll){
		char [] array;
		double length, i;
		LinkedListNodeCharacters node;

		node = ll.first;

		length = LinkedListCharactersLength(ll);

		array = new char [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			array[(int)(i)] = node.value;
			node = node.next;
		}

		return array;
	}


	public static double LinkedListCharactersLength(LinkedListCharacters ll){
		double l;
		LinkedListNodeCharacters node;

		l = 0d;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1d;
		}

		return l;
	}


	public static void FreeLinkedListCharacter(LinkedListCharacters ll){
		LinkedListNodeCharacters node, prev;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			delete(prev);
		}

		delete(node);
	}


	public static void LinkedListCharactersAddString(LinkedListCharacters ll, char [] str){
		double i;

		for(i = 0d; i < str.Length; i = i + 1d){
			LinkedListAddCharacter(ll, str[(int)(i)]);
		}
	}


	public static void LinkedListInsertCharacter(LinkedListCharacters ll, double index, char value){
		double i;
		LinkedListNodeCharacters node, tmp;

		if(index == 0d){
			tmp = ll.first;
			ll.first = new LinkedListNodeCharacters();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0d; i < index - 1d; i = i + 1d){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeCharacters();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}


	public static DynamicArrayNumbers CreateDynamicArrayNumbers(){
		DynamicArrayNumbers da;

		da = new DynamicArrayNumbers();
		da.array = new double [10];
		da.length = 0d;

		return da;
	}


	public static DynamicArrayNumbers CreateDynamicArrayNumbersWithInitialCapacity(double capacity){
		DynamicArrayNumbers da;

		da = new DynamicArrayNumbers();
		da.array = new double [(int)(capacity)];
		da.length = 0d;

		return da;
	}


	public static void DynamicArrayAddNumber(DynamicArrayNumbers da, double value){
		if(da.length == da.array.Length){
			DynamicArrayNumbersIncreaseSize(da);
		}

		da.array[(int)(da.length)] = value;
		da.length = da.length + 1d;
	}


	public static void DynamicArrayNumbersIncreaseSize(DynamicArrayNumbers da){
		double newLength, i;
		double [] newArray;

		newLength = (double)Round(da.array.Length*3d/2d);
		newArray = new double [(int)(newLength)];

		for(i = 0d; i < da.array.Length; i = i + 1d){
			newArray[(int)(i)] = da.array[(int)(i)];
		}

		delete(da.array);

		da.array = newArray;
	}


	public static bool DynamicArrayNumbersDecreaseSizeNecessary(DynamicArrayNumbers da){
		bool needsDecrease;

		needsDecrease = false;

		if(da.length > 10d){
			needsDecrease = da.length <= (double)Round(da.array.Length*2d/3d);
		}

		return needsDecrease;
	}


	public static void DynamicArrayNumbersDecreaseSize(DynamicArrayNumbers da){
		double newLength, i;
		double [] newArray;

		newLength = (double)Round(da.array.Length*2d/3d);
		newArray = new double [(int)(newLength)];

		for(i = 0d; i < newLength; i = i + 1d){
			newArray[(int)(i)] = da.array[(int)(i)];
		}

		delete(da.array);

		da.array = newArray;
	}


	public static double DynamicArrayNumbersIndex(DynamicArrayNumbers da, double index){
		return da.array[(int)(index)];
	}


	public static double DynamicArrayNumbersLength(DynamicArrayNumbers da){
		return da.length;
	}


	public static void DynamicArrayInsertNumber(DynamicArrayNumbers da, double index, double value){
		double i;

		if(da.length == da.array.Length){
			DynamicArrayNumbersIncreaseSize(da);
		}

		for(i = da.length; i > index; i = i - 1d){
			da.array[(int)(i)] = da.array[(int)(i - 1d)];
		}

		da.array[(int)(index)] = value;

		da.length = da.length + 1d;
	}


	public static bool DynamicArrayNumberSet(DynamicArrayNumbers da, double index, double value){
		bool success;

		if(index < da.length){
			da.array[(int)(index)] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static void DynamicArrayRemoveNumber(DynamicArrayNumbers da, double index){
		double i;

		for(i = index; i < da.length - 1d; i = i + 1d){
			da.array[(int)(i)] = da.array[(int)(i + 1d)];
		}

		da.length = da.length - 1d;

		if(DynamicArrayNumbersDecreaseSizeNecessary(da)){
			DynamicArrayNumbersDecreaseSize(da);
		}
	}


	public static void FreeDynamicArrayNumbers(DynamicArrayNumbers da){
		delete(da.array);
		delete(da);
	}


	public static double [] DynamicArrayNumbersToArray(DynamicArrayNumbers da){
		double [] array;
		double i;

		array = new double [(int)(da.length)];

		for(i = 0d; i < da.length; i = i + 1d){
			array[(int)(i)] = da.array[(int)(i)];
		}

		return array;
	}


	public static DynamicArrayNumbers ArrayToDynamicArrayNumbersWithOptimalSize(double [] array){
		DynamicArrayNumbers da;
		double i;
		double c, n, newCapacity;

		/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */
		c = array.Length;
		n = (Log(c) - 1d)/Log(3d/2d);
		newCapacity = Ceiling(10d*Pow(3d/2d, n));

		da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity);

		for(i = 0d; i < array.Length; i = i + 1d){
			da.array[(int)(i)] = array[(int)(i)];
		}

		return da;
	}


	public static DynamicArrayNumbers ArrayToDynamicArrayNumbers(double [] array){
		DynamicArrayNumbers da;

		da = new DynamicArrayNumbers();
		da.array = arraysCopyNumberArray(array);
		da.length = array.Length;

		return da;
	}


	public static bool DynamicArrayNumbersEqual(DynamicArrayNumbers a, DynamicArrayNumbers b){
		bool equal;
		double i;

		equal = true;
		if(a.length == b.length){
			for(i = 0d; i < a.length && equal; i = i + 1d){
				if(a.array[(int)(i)] != b.array[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static LinkedListNumbers DynamicArrayNumbersToLinkedList(DynamicArrayNumbers da){
		LinkedListNumbers ll;
		double i;

		ll = CreateLinkedListNumbers();

		for(i = 0d; i < da.length; i = i + 1d){
			LinkedListAddNumber(ll, da.array[(int)(i)]);
		}

		return ll;
	}


	public static DynamicArrayNumbers LinkedListToDynamicArrayNumbers(LinkedListNumbers ll){
		DynamicArrayNumbers da;
		double i;
		LinkedListNodeNumbers node;

		node = ll.first;

		da = new DynamicArrayNumbers();
		da.length = LinkedListNumbersLength(ll);

		da.array = new double [(int)(da.length)];

		for(i = 0d; i < da.length; i = i + 1d){
			da.array[(int)(i)] = node.value;
			node = node.next;
		}

		return da;
	}


	public static double DynamicArrayNumbersIndexOf(DynamicArrayNumbers arr, double n, BooleanReference foundReference){
		bool found;
		double i;

		found = false;
		for(i = 0d; i < arr.length && !found; i = i + 1d){
			if(arr.array[(int)(i)] == n){
				found = true;
			}
		}
		if(!found){
			i = -1d;
		}else{
			i = i - 1d;
		}

		foundReference.booleanValue = found;

		return i;
	}


	public static bool DynamicArrayNumbersIsInArray(DynamicArrayNumbers arr, double n){
		bool found;
		double i;

		found = false;
		for(i = 0d; i < arr.length && !found; i = i + 1d){
			if(arr.array[(int)(i)] == n){
				found = true;
			}
		}

		return found;
	}


	public static char [] AddCharacter(char [] list, char a){
		char [] newlist;
		double i;

		newlist = new char [(int)(list.Length + 1d)];
		for(i = 0d; i < list.Length; i = i + 1d){
			newlist[(int)(i)] = list[(int)(i)];
		}
		newlist[(int)(list.Length)] = a;
		
		delete(list);
		
		return newlist;
	}


	public static void AddCharacterRef(StringReference list, char i){
		list.stringx = AddCharacter(list.stringx, i);
	}


	public static char [] RemoveCharacter(char [] list, double n){
		char [] newlist;
		double i;

		newlist = new char [(int)(list.Length - 1d)];

		if(n >= 0d && n < list.Length){
			for(i = 0d; i < list.Length; i = i + 1d){
				if(i < n){
					newlist[(int)(i)] = list[(int)(i)];
				}
				if(i > n){
					newlist[(int)(i - 1d)] = list[(int)(i)];
				}
			}

			delete(list);
		}else{
			delete(newlist);
		}

		return newlist;
	}


	public static char GetCharacterRef(StringReference list, double i){
		return list.stringx[(int)(i)];
	}


	public static void RemoveCharacterRef(StringReference list, double i){
		list.stringx = RemoveCharacter(list.stringx, i);
	}


	public static double GetAccrualAmount(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay, double yearOfInterest, double monthOfInterest){
		Date from, to;
		double amount;

		from = CreateDate(fromYear, fromMonth, fromDay);
		to = CreateDate(toYear, toMonth, toDay);

		amount = GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest);

		return amount;
	}


	public static double [] GetAccruals(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay){
		Date from, to;
		double [] amounts;

		from = CreateDate(fromYear, fromMonth, fromDay);
		to = CreateDate(toYear, toMonth, toDay);

		amounts = GetAccrualsWithDates(total, from, to);

		return amounts;
	}


	public static double [] GetAccrualsWithDates(double total, Date from, Date to){
		double entry;
		bool done;
		Date dateOfInterest;
		LinkedListNumbers list;
		double [] result;

		list = CreateLinkedListNumbers();

		done = false;
		dateOfInterest = new Date();
		AssignDate(dateOfInterest, from);
		for(; !done; ){
			if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
				done = true;
			}

			entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest.year, dateOfInterest.month);
			LinkedListAddNumber(list, entry);
			AddMonthsToDate(dateOfInterest, 1d);
		}

		result = LinkedListNumbersToArray(list);
		FreeLinkedListNumbers(list);

		return result;
	}


	public static double GetAccrualAmountWithDates(double total, Date from, Date to, double yearOfInterest, double monthOfInterest){
		double unadjustedAmount, adjustment, days, daysToAdjust, n;
		Date adjustTo;
		FixedPoint15d valuePerDay, divisibleRemaining, divisibleTotal, amount;
		StringReference message;

		message = new StringReference();

		valuePerDay = CreateFixedPoint15d(13d, 2d);
		divisibleRemaining = CreateFixedPoint15d(13d, 2d);
		divisibleTotal = CreateFixedPoint15d(13d, 2d);
		amount = CreateFixedPoint15d(13d, 2d);

		days = DaysBetweenDates(from, to) + 1d;

		/* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining*/
		DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days));

		Multiply15d(divisibleTotal, valuePerDay, Number15d(days));
		unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, from, to, yearOfInterest, monthOfInterest);

		if(!Equals15d(divisibleRemaining, Number15d(0d))){
			daysToAdjust = Roundx(ToNumber15d(divisibleRemaining)*100d);
			adjustTo = new Date();
			AssignDate(adjustTo, from);
			AddDaysToDate(adjustTo, daysToAdjust - 1d, message);

			adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest);

			delete(adjustTo);
		}else{
			adjustment = 0d;
		}

		Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment));

		n = ToNumber15d(amount);

		delete(valuePerDay);
		delete(divisibleRemaining);
		delete(divisibleTotal);
		delete(amount);

		return n;
	}


	public static double GetUnadjustedAccrualAmountWithDates(FixedPoint15d total, Date from, Date to, double yearOfInterest, double monthOfInterest){
		double days, daysInMonthOfInterest, n;
		Date lastDayInMonth, firstDateInMonth;
		double [] daysInMonth;
		FixedPoint15d valuePerDay, value, remainder;
		bool success;

		value = CreateFixedPoint15d(13d, 2d);
		valuePerDay = CreateFixedPoint15d(13d, 2d);
		remainder = CreateFixedPoint15d(13d, 2d);

		days = DaysBetweenDates(from, to) + 1d;
		/* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...*/
		success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days));

		if(success){
			daysInMonth = GetDaysInMonth(yearOfInterest);

			if(yearOfInterest < from.year){
				Assign15d(value, 0d);
			}else if(yearOfInterest == from.year && monthOfInterest < from.month){
				Assign15d(value, 0d);
			}else if(yearOfInterest > to.year){
				Assign15d(value, 0d);
			}else if(yearOfInterest == to.year && monthOfInterest > to.month){
				Assign15d(value, 0d);
			}else{
if(from.year == yearOfInterest && from.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest){
					daysInMonthOfInterest = days;
				}else if(from.year == yearOfInterest && from.month == monthOfInterest){
					lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[(int)(monthOfInterest)]);
					daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1d;
				}else if(to.year == yearOfInterest && to.month == monthOfInterest){
					firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1d);
					daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1d;
				}else{
					daysInMonthOfInterest = daysInMonth[(int)(monthOfInterest)];
				}

				/* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value*/
				Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest));
			}

			delete(daysInMonth);
		}

		n = ToNumber15d(value);

		delete(value);
		delete(valuePerDay);
		delete(remainder);

		return n;
	}


	public static Data CreateNewArrayData(){
		Data data;

		data = new Data();
		data.isArray = true;
		data.isStruture = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.isString = false;
		data.array = CreateArray();

		return data;
	}


	public static Data CreateNewStructData(){
		Data data;

		data = new Data();
		data.isStruture = true;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.isString = false;
		data.structure = CreateStructure();

		return data;
	}


	public static Structure CreateStructure(){
		Structure st;

		st = new Structure();
		st.keys = CreateArray();
		st.values = CreateArray();

		return st;
	}


	public static Data CreateNumberData(double n){
		Data data;

		data = new Data();
		data.isNumber = true;
		data.isStruture = false;
		data.isArray = false;
		data.isBoolean = false;
		data.isString = false;
		data.number = n;

		return data;
	}


	public static Data CreateBooleanData(bool b){
		Data data;

		data = new Data();
		data.isBoolean = true;
		data.isStruture = false;
		data.isArray = false;
		data.isNumber = false;
		data.isString = false;
		data.booleanx = b;

		return data;
	}


	public static Data CreateStringData(char [] stringx){
		Data data;

		data = new Data();
		data.isString = true;
		data.isStruture = false;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.stringx = stringx;

		return data;
	}


	public static Data CreateStructData(Structure structure){
		Data data;

		data = new Data();
		data.isString = false;
		data.isStruture = true;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.structure = structure;

		return data;
	}


	public static Data CreateArrayData(Array array){
		Data data;

		data = new Data();
		data.isString = false;
		data.isStruture = false;
		data.isArray = true;
		data.isNumber = false;
		data.isBoolean = false;
		data.array = array;

		return data;
	}


	public static Data CreateNoTypeData(){
		Data data;

		data = new Data();
		data.isStruture = false;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.isString = false;

		return data;
	}


	public static void AddStructToArray(Array ar, Structure st){
		Data data;

		data = CreateNewStructData();
		delete(data.structure);
		data.structure = st;

		ArrayAdd(ar, data);
	}


	public static void AddArrayToArray(Array ar, Array ar2){
		Data data;

		data = CreateNewArrayData();
		delete(data.array);
		data.array = ar2;

		ArrayAdd(ar, data);
	}


	public static void AddNumberToArray(Array ar, double n){
		ArrayAdd(ar, CreateNumberData(n));
	}


	public static void AddBooleanToArray(Array ar, bool b){
		ArrayAdd(ar, CreateBooleanData(b));
	}


	public static void AddStringToArray(Array ar, char [] str){
		ArrayAdd(ar, CreateStringData(str));
	}


	public static void AddDataToArray(Array ar, Data data){
		ArrayAdd(ar, data);
	}


	public static double StructKeys(Structure st){
		return ArrayLength(st.keys);
	}


	public static bool StructHasKey(Structure st, char [] key){
		double i;
		bool hasKey;

		hasKey = false;
		for(i = 0d; i < StructKeys(st); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				hasKey = true;
			}
		}

		return hasKey;
	}


	public static double StructKeyIndex(Structure st, char [] key){
		double i;
		double index;

		index = -1d;
		for(i = 0d; i < StructKeys(st); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				index = i;
			}
		}

		return index;
	}


	public static StringReference [] GetStructKeys(Structure st){
		StringReference [] keys;
		double nr, i;

		nr = StructKeys(st);

		keys = new StringReference [(int)(nr)];

		for(i = 0d; i < nr; i = i + 1d){
			keys[(int)(i)] = new StringReference();
			keys[(int)(i)].stringx = arraysCopyString(st.keys.array[(int)(i)].stringx);
		}

		return keys;
	}


	public static Structure GetStructFromStruct(Structure st, char [] key){
		double i;
		Structure r;

		r = new Structure();
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				r = st.values.array[(int)(i)].structure;
			}
		}

		return r;
	}


	public static Array GetArrayFromStruct(Structure st, char [] key){
		double i;
		Array r;

		r = new Array();
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				r = st.values.array[(int)(i)].array;
			}
		}

		return r;
	}


	public static double GetNumberFromStruct(Structure st, char [] key){
		double i, r;

		r = 0d;
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				r = st.values.array[(int)(i)].number;
			}
		}

		return r;
	}


	public static bool GetBooleanFromStruct(Structure st, char [] key){
		double i;
		bool r;

		r = false;
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				r = st.values.array[(int)(i)].booleanx;
			}
		}

		return r;
	}


	public static char [] GetStringFromStruct(Structure st, char [] key){
		double i;
		char [] r;

		r = "".ToCharArray();
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				r = st.values.array[(int)(i)].stringx;
			}
		}

		return r;
	}


	public static Data GetDataFromStruct(Structure st, char [] key){
		double i;
		Data r;

		r = new Data();
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				delete(r);
				r = st.values.array[(int)(i)];
			}
		}

		return r;
	}


	public static Data GetDataFromStructWithCheck(Structure st, char [] key, BooleanReference foundRef){
		double i;
		Data r;

		r = new Data();
		foundRef.booleanValue = false;
		for(i = 0d; i < ArrayLength(st.keys); i = i + 1d){
			if(arraysStringsEqual(st.keys.array[(int)(i)].stringx, key)){
				delete(r);
				foundRef.booleanValue = true;
				r = st.values.array[(int)(i)];
			}
		}

		return r;
	}


	public static void AddStructToStruct(Structure st, char [] key, Structure structx){
		double i;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			delete(st.values.array[(int)(i)].structure);
			st.values.array[(int)(i)].structure = structx;
		}else{
			AddStringToArray(st.keys, key);
			AddStructToArray(st.values, structx);
		}
	}


	public static void AddArrayToStruct(Structure st, char [] key, Array ar){
		double i;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			delete(st.values.array[(int)(i)].array);
			st.values.array[(int)(i)].array = ar;
		}else{
			AddStringToArray(st.keys, key);
			AddArrayToArray(st.values, ar);
		}
	}


	public static void AddNumberToStruct(Structure st, char [] key, double n){
		double i;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			st.values.array[(int)(i)].number = n;
		}else{
			AddStringToArray(st.keys, key);
			AddNumberToArray(st.values, n);
		}
	}


	public static void AddBooleanToStruct(Structure st, char [] key, bool b){
		double i;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			st.values.array[(int)(i)].booleanx = b;
		}else{
			AddStringToArray(st.keys, key);
			AddBooleanToArray(st.values, b);
		}
	}


	public static void AddStringToStruct(Structure st, char [] key, char [] value){
		double i;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			delete(st.values.array[(int)(i)].stringx);
			st.values.array[(int)(i)].stringx = value;
		}else{
			AddStringToArray(st.keys, key);
			AddStringToArray(st.values, value);
		}
	}


	public static void AddDataToStruct(Structure st, char [] key, Data data){
		double i;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			FreeData(st.values.array[(int)(i)]);
			st.values.array[(int)(i)] = data;
		}else{
			AddStringToArray(st.keys, key);
			AddDataToArray(st.values, data);
		}
	}


	public static void FreeData(Data data){
		double i;
		Structure st;

		if(data.isStruture){
			st = data.structure;
			for(i = 0d; i < StructKeys(st); i = i + 1d){
				FreeData(ArrayIndex(st.keys, i));
				FreeData(ArrayIndex(st.values, i));
			}
			delete(st);
		}else if(data.isArray){
			FreeArray(data.array);
		}

		delete(data);
	}


	public static void FreeArray(Array array){
		double i;

		for(i = 0d; i < ArrayLength(array); i = i + 1d){
			FreeData(array.array[(int)(i)]);
		}

		delete(array.array);
		delete(array);
	}


	public static bool DataTypeEquals(Data a, Data b){
		bool equal;

		equal = true;
		equal = equal && a.isStruture == b.isStruture;
		equal = equal && a.isArray == b.isArray;
		equal = equal && a.isNumber == b.isNumber;
		equal = equal && a.isBoolean == b.isBoolean;
		equal = equal && a.isString == b.isString;

		return equal;
	}


	public static bool IsStructure(Data a){
		bool itis;

		itis = a.isStruture;
		if(a.isArray || a.isNumber || a.isBoolean || a.isString){
			itis = false;
		}

		return itis;
	}


	public static bool IsArray(Data a){
		bool itis;

		itis = a.isArray;
		if(a.isStruture || a.isNumber || a.isBoolean || a.isString){
			itis = false;
		}

		return itis;
	}


	public static bool IsNumber(Data a){
		bool itis;

		itis = a.isNumber;
		if(a.isStruture || a.isArray || a.isBoolean || a.isString){
			itis = false;
		}

		return itis;
	}


	public static bool IsBoolean(Data a){
		bool itis;

		itis = a.isBoolean;
		if(a.isStruture || a.isArray || a.isNumber || a.isString){
			itis = false;
		}

		return itis;
	}


	public static bool IsString(Data a){
		bool itis;

		itis = a.isString;
		if(a.isStruture || a.isArray || a.isNumber || a.isBoolean){
			itis = false;
		}

		return itis;
	}


	public static bool IsNoType(Data a){
		bool itis;

		if(!a.isString && !a.isStruture && !a.isArray && !a.isNumber && !a.isBoolean){
			itis = true;
		}else{
			itis = false;
		}

		return itis;
	}


	public static Array CreateArray(){
		Array array;

		array = new Array();
		array.array = new Data [10];
		array.length = 0d;

		return array;
	}


	public static Array CreateArrayWithInitialCapacity(double capacity){
		Array array;

		array = new Array();
		array.array = new Data [(int)(capacity)];
		array.length = 0d;

		return array;
	}


	public static void ArrayAdd(Array array, Data value){
		if(array.length == array.array.Length){
			ArrayIncreaseSize(array);
		}

		array.array[(int)(array.length)] = value;
		array.length = array.length + 1d;
	}


	public static void ArrayAddString(Array array, char [] value){
		Data data;

		data = CreateStringData(value);

		ArrayAdd(array, data);
	}


	public static void ArrayAddBoolean(Array array, bool value){
		Data data;

		data = CreateBooleanData(value);

		ArrayAdd(array, data);
	}


	public static void ArrayAddNumber(Array array, double value){
		Data data;

		data = CreateNumberData(value);

		ArrayAdd(array, data);
	}


	public static void ArrayAddStruct(Array array, Structure value){
		Data data;

		data = CreateStructData(value);

		ArrayAdd(array, data);
	}


	public static void ArrayAddArray(Array array, Array value){
		Data data;

		data = CreateArrayData(value);

		ArrayAdd(array, data);
	}


	public static void ArrayIncreaseSize(Array array){
		double newLength, i;
		Data [] newArray;

		newLength = (double)Round(array.array.Length*3d/2d);
		newArray = new Data [(int)(newLength)];

		for(i = 0d; i < array.array.Length; i = i + 1d){
			newArray[(int)(i)] = array.array[(int)(i)];
		}

		delete(array.array);

		array.array = newArray;
	}


	public static bool ArrayDecreaseSizeNecessary(Array array){
		bool needsDecrease;

		needsDecrease = false;

		if(array.length > 10d){
			needsDecrease = array.length <= (double)Round(array.array.Length*2d/3d);
		}

		return needsDecrease;
	}


	public static void ArrayDecreaseSize(Array array){
		double newLength, i;
		Data [] newArray;

		newLength = (double)Round(array.array.Length*2d/3d);
		newArray = new Data [(int)(newLength)];

		for(i = 0d; i < newLength; i = i + 1d){
			newArray[(int)(i)] = array.array[(int)(i)];
		}

		delete(array.array);

		array.array = newArray;
	}


	public static Data ArrayIndex(Array array, double index){
		return array.array[(int)(index)];
	}


	public static Array ArrayIndexArray(Array array, double index){
		return array.array[(int)(index)].array;
	}


	public static Structure ArrayIndexStruct(Array array, double index){
		return array.array[(int)(index)].structure;
	}


	public static bool ArrayIndexBoolean(Array array, double index){
		return array.array[(int)(index)].booleanx;
	}


	public static char [] ArrayIndexString(Array array, double index){
		return array.array[(int)(index)].stringx;
	}


	public static double ArrayIndexNumber(Array array, double index){
		return array.array[(int)(index)].number;
	}


	public static double ArrayLength(Array array){
		return array.length;
	}


	public static void ArrayInsert(Array array, double index, Data value){
		double i;

		if(array.length == array.array.Length){
			ArrayIncreaseSize(array);
		}

		for(i = array.length; i > index; i = i - 1d){
			array.array[(int)(i)] = array.array[(int)(i - 1d)];
		}

		array.array[(int)(index)] = value;

		array.length = array.length + 1d;
	}


	public static void ArrayInsertString(Array array, double index, char [] value){
		Data data;

		data = CreateStringData(value);

		ArrayInsert(array, index, data);
	}


	public static void ArrayInsertBoolean(Array array, double index, bool value){
		Data data;

		data = CreateBooleanData(value);

		ArrayInsert(array, index, data);
	}


	public static void ArrayInsertNumber(Array array, double index, double value){
		Data data;

		data = CreateNumberData(value);

		ArrayInsert(array, index, data);
	}


	public static void ArrayInsertStruct(Array array, double index, Structure value){
		Data data;

		data = CreateStructData(value);

		ArrayInsert(array, index, data);
	}


	public static void ArrayInsertArray(Array array, double index, Array value){
		Data data;

		data = CreateArrayData(value);

		ArrayInsert(array, index, data);
	}


	public static bool ArraySet(Array array, double index, Data value){
		bool success;

		if(index < array.length){
			array.array[(int)(index)] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static void ArraySetString(Array array, double index, char [] value){
		Data data;

		data = CreateStringData(value);

		ArraySet(array, index, data);
	}


	public static void ArraySetBoolean(Array array, double index, bool value){
		Data data;

		data = CreateBooleanData(value);

		ArraySet(array, index, data);
	}


	public static void ArraySetNumber(Array array, double index, double value){
		Data data;

		data = CreateNumberData(value);

		ArraySet(array, index, data);
	}


	public static void ArraySetStruct(Array array, double index, Structure value){
		Data data;

		data = CreateStructData(value);

		ArraySet(array, index, data);
	}


	public static void ArraySetArray(Array array, double index, Array value){
		Data data;

		data = CreateArrayData(value);

		ArraySet(array, index, data);
	}


	public static void ArrayRemove(Array array, double index){
		double i;

		for(i = index; i < array.length - 1d; i = i + 1d){
			array.array[(int)(i)] = array.array[(int)(i + 1d)];
		}

		array.length = array.length - 1d;

		if(ArrayDecreaseSizeNecessary(array)){
			ArrayDecreaseSize(array);
		}
	}


	public static Data [] ToStaticArray(Array arc){
		Data [] array;
		double i;

		array = new Data [(int)(arc.length)];

		for(i = 0d; i < arc.length; i = i + 1d){
			array[(int)(i)] = arc.array[(int)(i)];
		}

		return array;
	}


	public static double [] ToStaticNumberArray(Array array){
		double [] result;
		double i, n;

		n = ArrayLength(array);

		result = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).number;
		}

		return result;
	}


	public static bool [] ToStaticBooleanArray(Array array){
		bool [] result;
		double i, n;

		n = ArrayLength(array);

		result = new bool [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).booleanx;
		}

		return result;
	}


	public static StringReference [] ToStaticStringArray(Array array){
		StringReference [] result;
		double i, n;

		n = ArrayLength(array);

		result = new StringReference [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = new StringReference();
			result[(int)(i)].stringx = ArrayIndex(array, i).stringx;
		}

		return result;
	}


	public static Array [] ToStaticArrayArray(Array array){
		Array [] result;
		double i, n;

		n = ArrayLength(array);

		result = new Array [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).array;
		}

		return result;
	}


	public static Structure [] ToStaticStructArray(Array array){
		Structure [] result;
		double i, n;

		n = ArrayLength(array);

		result = new Structure [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).structure;
		}

		return result;
	}


	public static Array StaticArrayToArrayWithOptimalSize(Data [] src){
		Array dst;
		double i;
		double c, n, newCapacity;

		/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */

		c = src.Length;
		n = (Log(c) - 1d)/Log(3d/2d);

		newCapacity = Ceiling(10d*Pow(3d/2d, Ceiling(n)));

		dst = CreateArrayWithInitialCapacity(newCapacity);

		for(i = 0d; i < src.Length; i = i + 1d){
			dst.array[(int)(i)] = src[(int)(i)];
		}

		return dst;
	}


	public static Array StaticArrayToArray(Data [] src){
		double i;
		Array dst;

		dst = CreateArrayWithInitialCapacity(src.Length);
		for(i = 0d; i < src.Length; i = i + 1d){
			dst.array[(int)(i)] = src[(int)(i)];
		}
		dst.length = src.Length;

		return dst;
	}


	public static double [] arraysStringToNumberArray(char [] stringx){
		double i;
		double [] array;

		array = new double [(int)(stringx.Length)];

		for(i = 0d; i < stringx.Length; i = i + 1d){
			array[(int)(i)] = stringx[(int)(i)];
		}
		return array;
	}


	public static char [] arraysNumberArrayToString(double [] array){
		double i;
		char [] stringx;

		stringx = new char [(int)(array.Length)];

		for(i = 0d; i < array.Length; i = i + 1d){
			stringx[(int)(i)] = (char)(array[(int)(i)]);
		}
		return stringx;
	}


	public static bool arraysNumberArraysEqual(double [] a, double [] b){
		bool equal;
		double i;

		equal = true;
		if(a.Length == b.Length){
			for(i = 0d; i < a.Length && equal; i = i + 1d){
				if(a[(int)(i)] != b[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static bool arraysBooleanArraysEqual(bool [] a, bool [] b){
		bool equal;
		double i;

		equal = true;
		if(a.Length == b.Length){
			for(i = 0d; i < a.Length && equal; i = i + 1d){
				if(a[(int)(i)] != b[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static bool arraysStringsEqual(char [] a, char [] b){
		bool equal;
		double i;

		equal = true;
		if(a.Length == b.Length){
			for(i = 0d; i < a.Length && equal; i = i + 1d){
				if(a[(int)(i)] != b[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static void arraysFillNumberArray(double [] a, double value){
		double i;

		for(i = 0d; i < a.Length; i = i + 1d){
			a[(int)(i)] = value;
		}
	}


	public static void arraysFillString(char [] a, char value){
		double i;

		for(i = 0d; i < a.Length; i = i + 1d){
			a[(int)(i)] = value;
		}
	}


	public static void arraysFillBooleanArray(bool [] a, bool value){
		double i;

		for(i = 0d; i < a.Length; i = i + 1d){
			a[(int)(i)] = value;
		}
	}


	public static bool arraysFillNumberArrayRange(double [] a, double value, double from, double to){
		double i, length;
		bool success;

		if(from >= 0d && from <= a.Length && to >= 0d && to <= a.Length && from <= to){
			length = to - from;
			for(i = 0d; i < length; i = i + 1d){
				a[(int)(from + i)] = value;
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static bool arraysFillBooleanArrayRange(bool [] a, bool value, double from, double to){
		double i, length;
		bool success;

		if(from >= 0d && from <= a.Length && to >= 0d && to <= a.Length && from <= to){
			length = to - from;
			for(i = 0d; i < length; i = i + 1d){
				a[(int)(from + i)] = value;
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static bool arraysFillStringRange(char [] a, char value, double from, double to){
		double i, length;
		bool success;

		if(from >= 0d && from <= a.Length && to >= 0d && to <= a.Length && from <= to){
			length = to - from;
			for(i = 0d; i < length; i = i + 1d){
				a[(int)(from + i)] = value;
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static double [] arraysCopyNumberArray(double [] a){
		double i;
		double [] n;

		n = new double [(int)(a.Length)];

		for(i = 0d; i < a.Length; i = i + 1d){
			n[(int)(i)] = a[(int)(i)];
		}

		return n;
	}


	public static bool [] arraysCopyBooleanArray(bool [] a){
		double i;
		bool [] n;

		n = new bool [(int)(a.Length)];

		for(i = 0d; i < a.Length; i = i + 1d){
			n[(int)(i)] = a[(int)(i)];
		}

		return n;
	}


	public static char [] arraysCopyString(char [] a){
		double i;
		char [] n;

		n = new char [(int)(a.Length)];

		for(i = 0d; i < a.Length; i = i + 1d){
			n[(int)(i)] = a[(int)(i)];
		}

		return n;
	}


	public static bool arraysCopyNumberArrayRange(double [] a, double from, double to, NumberArrayReference copyReference){
		double i, length;
		double [] n;
		bool success;

		if(from >= 0d && from <= a.Length && to >= 0d && to <= a.Length && from <= to){
			length = to - from;
			n = new double [(int)(length)];

			for(i = 0d; i < length; i = i + 1d){
				n[(int)(i)] = a[(int)(from + i)];
			}

			copyReference.numberArray = n;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static bool arraysCopyBooleanArrayRange(bool [] a, double from, double to, BooleanArrayReference copyReference){
		double i, length;
		bool [] n;
		bool success;

		if(from >= 0d && from <= a.Length && to >= 0d && to <= a.Length && from <= to){
			length = to - from;
			n = new bool [(int)(length)];

			for(i = 0d; i < length; i = i + 1d){
				n[(int)(i)] = a[(int)(from + i)];
			}

			copyReference.booleanArray = n;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static bool arraysCopyStringRange(char [] a, double from, double to, StringReference copyReference){
		double i, length;
		char [] n;
		bool success;

		if(from >= 0d && from <= a.Length && to >= 0d && to <= a.Length && from <= to){
			length = to - from;
			n = new char [(int)(length)];

			for(i = 0d; i < length; i = i + 1d){
				n[(int)(i)] = a[(int)(from + i)];
			}

			copyReference.stringx = n;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static bool arraysIsLastElement(double length, double index){
		return index + 1d == length;
	}


	public static double [] arraysCreateNumberArray(double length, double value){
		double [] array;

		array = new double [(int)(length)];
		arraysFillNumberArray(array, value);

		return array;
	}


	public static bool [] arraysCreateBooleanArray(double length, bool value){
		bool [] array;

		array = new bool [(int)(length)];
		arraysFillBooleanArray(array, value);

		return array;
	}


	public static char [] arraysCreateString(double length, char value){
		char [] array;

		array = new char [(int)(length)];
		arraysFillString(array, value);

		return array;
	}


	public static void arraysSwapElementsOfNumberArray(double [] A, double ai, double bi){
		double tmp;

		tmp = A[(int)(ai)];
		A[(int)(ai)] = A[(int)(bi)];
		A[(int)(bi)] = tmp;
	}


	public static void arraysSwapElementsOfStringArray(StringArrayReference A, double ai, double bi){
		StringReference tmp;

		tmp = A.stringArray[(int)(ai)];
		A.stringArray[(int)(ai)] = A.stringArray[(int)(bi)];
		A.stringArray[(int)(bi)] = tmp;
	}


	public static void arraysReverseNumberArray(double [] array){
		double i;

		for(i = 0d; i < array.Length/2d; i = i + 1d){
			arraysSwapElementsOfNumberArray(array, i, array.Length - i - 1d);
		}
	}


	public static char [] CreateStringScientificNotationDecimalFromNumber(double n){
		StringReference mantissaReference, exponentReference;
		double e;
		bool isPositive;
		char [] result;

		mantissaReference = new StringReference();
		exponentReference = new StringReference();
		result = new char [0];

		if(n < 0d){
			isPositive = false;
			n = -n;
		}else{
			isPositive = true;
		}

		if(n == 0d){
			e = 0d;
		}else{
			e = GetFirstDecimalDigitPosition(n);

			if(e < 0d){
				n = n*Pow(10d, Abs(e));
			}else{
				n = n/Pow(10d, e);
			}
		}

		mantissaReference.stringx = CreateStringDecimalFromNumber(n);
		exponentReference.stringx = CreateStringDecimalFromNumber(e);

		if(!isPositive){
			result = strAppendString(result, "-".ToCharArray());
		}

		result = strAppendString(result, mantissaReference.stringx);
		result = strAppendString(result, "e".ToCharArray());
		result = strAppendString(result, exponentReference.stringx);

		return result;
	}


	public static char [] CreateStringDecimalFromNumber(double number){
		DynamicArrayCharacters stringx;
		double maximumDigits, i, d, digitPosition, trailingZeros;
		bool hasPrintedPoint, isPositive, done;
		CharacterReference characterReference;
		char c;
		char [] str;

		stringx = CreateDynamicArrayCharacters();
		isPositive = true;

		if(number < 0d){
			isPositive = false;
			number = -number;
		}

		if(number == 0d){
			DynamicArrayAddCharacter(stringx, '0');
		}else{
			characterReference = new CharacterReference();

			maximumDigits = GetMaximumDigitsForDecimal();

			digitPosition = GetFirstDecimalDigitPosition(number);

			hasPrintedPoint = false;

			if(!isPositive){
				DynamicArrayAddCharacter(stringx, '-');
			}

			/* Print leading zeros.*/
			if(digitPosition < 0d){
				DynamicArrayAddCharacter(stringx, '0');
				DynamicArrayAddCharacter(stringx, '.');
				hasPrintedPoint = true;
				for(i = 0d; i < -digitPosition - 1d; i = i + 1d){
					DynamicArrayAddCharacter(stringx, '0');
				}
			}

			/* Count trailing zeros*/
			trailingZeros = 0d;
			done = false;
			for(i = 0d; i < maximumDigits && !done; i = i + 1d){
				d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1d);
				if(d == 0d){
					trailingZeros = trailingZeros + 1d;
				}else{
					done = true;
				}
			}

			/* Print number.*/
			for(i = 0d; i < maximumDigits; i = i + 1d){
				d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i);

				if(!hasPrintedPoint && digitPosition - i + 1d == 0d){
					if(maximumDigits - i > trailingZeros){
						DynamicArrayAddCharacter(stringx, '.');
					}
					hasPrintedPoint = true;
				}

				if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
				}else{
					GetDecimalDigitCharacterFromNumberWithCheck(d, characterReference);
					c = characterReference.characterValue;
					DynamicArrayAddCharacter(stringx, c);
				}
			}

			/* Print trailing zeros.*/
			for(i = 0d; i < digitPosition - maximumDigits + 1d; i = i + 1d){
				DynamicArrayAddCharacter(stringx, '0');
			}
		}

		/* Done*/
		str = DynamicArrayCharactersToArray(stringx);
		FreeDynamicArrayCharacters(stringx);
		return str;
	}


	public static bool CreateStringFromNumberWithCheck(double number, double basex, StringReference stringRef){
		DynamicArrayCharacters stringx;
		double maximumDigits, i, d, digitPosition, trailingZeros;
		bool success, hasPrintedPoint, isPositive, done;
		CharacterReference characterReference;
		char c;

		stringx = CreateDynamicArrayCharacters();
		isPositive = true;

		if(number < 0d){
			isPositive = false;
			number = -number;
		}

		if(number == 0d){
			DynamicArrayAddCharacter(stringx, '0');
			success = true;
		}else{
			characterReference = new CharacterReference();

			if(IsInteger(basex)){
				success = true;

				maximumDigits = GetMaximumDigitsForBase(basex);

				digitPosition = GetFirstDigitPosition(number, basex);

				hasPrintedPoint = false;

				if(!isPositive){
					DynamicArrayAddCharacter(stringx, '-');
				}

				/* Print leading zeros.*/
				if(digitPosition < 0d){
					DynamicArrayAddCharacter(stringx, '0');
					DynamicArrayAddCharacter(stringx, '.');
					hasPrintedPoint = true;
					for(i = 0d; i < -digitPosition - 1d; i = i + 1d){
						DynamicArrayAddCharacter(stringx, '0');
					}
				}

				/* Count trailing zeros*/
				trailingZeros = 0d;
				done = false;
				for(i = 0d; i < maximumDigits && !done; i = i + 1d){
					d = GetDigit(number, basex, maximumDigits - i - 1d);
					if(d == 0d){
						trailingZeros = trailingZeros + 1d;
					}else{
						done = true;
					}
				}

				/* Print number.*/
				for(i = 0d; i < maximumDigits && success; i = i + 1d){
					d = GetDigit(number, basex, i);

					if(d >= basex){
						d = basex - 1d;
					}

					if(!hasPrintedPoint && digitPosition - i + 1d == 0d){
						if(maximumDigits - i > trailingZeros){
							DynamicArrayAddCharacter(stringx, '.');
						}
						hasPrintedPoint = true;
					}

					if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
					}else{
						success = GetSingleDigitCharacterFromNumberWithCheck(d, basex, characterReference);
						if(success){
							c = characterReference.characterValue;
							DynamicArrayAddCharacter(stringx, c);
						}
					}
				}

				if(success){
					/* Print trailing zeros.*/
					for(i = 0d; i < digitPosition - maximumDigits + 1d; i = i + 1d){
						DynamicArrayAddCharacter(stringx, '0');
					}
				}
			}else{
				success = false;
			}
		}

		if(success){
			stringRef.stringx = DynamicArrayCharactersToArray(stringx);
			FreeDynamicArrayCharacters(stringx);
		}

		/* Done*/
		return success;
	}


	public static double GetMaximumDigitsForBase(double basex){
		double t;

		t = Pow(10d, 15d);
		return Floor(Log10(t)/Log10(basex));
	}


	public static double GetMaximumDigitsForDecimal(){
		return 15d;
	}


	public static double GetFirstDecimalDigitPosition(double n){
		double power, m, i;
		bool multiply, done;

		n = Abs(n);

		if(n != 0d){
			if(Floor(n) < Pow(10d, 15d)){
				multiply = true;
			}else{
				multiply = false;
			}

			done = false;
			m = 0d;
			for(i = 0d; !done; i = i + 1d){
				if(multiply){
					m = n*Pow(10d, i);
					if(Floor(m) >= Pow(10d, 14d)){
						done = true;
					}
				}else{
					m = n/Pow(10d, i);
					if(Floor(m) < Pow(10d, 15d)){
						done = true;
					}
				}
			}

			if(multiply){
				power = 15d - i;
			}else{
				power = 15d + i - 2d;
			}

			if(Roundx(m) >= Pow(10d, 15d)){
				power = power + 1d;
			}
		}else{
			power = 1d;
		}

		return power;
	}


	public static double GetFirstDigitPosition(double n, double basex){
		double power, m, i, maximumDigits;
		bool multiply, done;

		maximumDigits = GetMaximumDigitsForBase(basex);
		n = Abs(n);

		if(n != 0d){
			if(Floor(n) < Pow(basex, maximumDigits)){
				multiply = true;
			}else{
				multiply = false;
			}

			done = false;
			m = 0d;
			for(i = 0d; !done; i = i + 1d){
				if(multiply){
					m = n*Pow(basex, i);
					if(Floor(m) >= Pow(basex, maximumDigits - 1d)){
						done = true;
					}
				}else{
					m = n/Pow(basex, i);
					if(Floor(m) < Pow(basex, maximumDigits)){
						done = true;
					}
				}
			}

			if(multiply){
				power = maximumDigits - i;
			}else{
				power = maximumDigits + i - 2d;
			}

			if(Roundx(m) >= Pow(basex, maximumDigits)){
				power = power + 1d;
			}
		}else{
			power = 1d;
		}

		return power;
	}


	public static bool GetSingleDigitCharacterFromNumberWithCheck(double c, double basex, CharacterReference characterReference){
		char [] numberTable;
		bool success;

		numberTable = GetDigitCharacterTable();

		if(c < basex || c < numberTable.Length){
			success = true;
			characterReference.characterValue = numberTable[(int)(c)];
		}else{
			success = false;
		}

		return success;
	}


	public static bool GetDecimalDigitCharacterFromNumberWithCheck(double c, CharacterReference characterRef){
		char [] numberTable;
		bool success;

		numberTable = "0123456789".ToCharArray();

		if(c >= 0d && c < 10d){
			success = true;
			characterRef.characterValue = numberTable[(int)(c)];
		}else{
			success = false;
		}

		return success;
	}


	public static char [] GetDigitCharacterTable(){
		char [] numberTable;

		numberTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

		return numberTable;
	}


	public static double GetDecimalDigit(double n, double index){
		double digitPosition;

		digitPosition = GetFirstDecimalDigitPosition(n);

		return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index);
	}


	public static double GetDecimalDigitWithFirstDigitPosition(double n, double digitPosition, double index){
		double d, e, m, i;

		n = Abs(n);

		e = 15d - digitPosition - 1d;
		if(e < 0d){
			n = (double)Round(n/Pow(10d, Abs(e)));
		}else{
			n = (double)Round(n*Pow(10d, e));
		}

		m = n;
		d = 0d;
		for(i = 0d; i < 15d - index; i = i + 1d){
			d = (double)Round(m%10d);
			m = m - d;
			m = (double)Round(m/10d);
		}

		return d;
	}


	public static double GetDigit(double n, double basex, double index){
		double d, digitPosition, e, m, maximumDigits, i;

		n = Abs(n);
		maximumDigits = GetMaximumDigitsForBase(basex);
		digitPosition = GetFirstDigitPosition(n, basex);

		e = maximumDigits - digitPosition - 1d;
		if(e < 0d){
			n = (double)Round(n/Pow(basex, Abs(e)));
		}else{
			n = (double)Round(n*Pow(basex, e));
		}

		m = n;
		d = 0d;
		for(i = 0d; i < maximumDigits - index; i = i + 1d){
			d = (double)Round(m%basex);
			m = m - d;
			m = (double)Round(m/basex);
		}

		return d;
	}


	public static char [] NumberToHumanReadableShortScale(double n){
		char [] res, suffix;
		bool hasSuffix;
		double k, M, B, T, Q;

		k = 1000d;
		M = k*1000d;
		B = M*1000d;
		T = B*1000d;
		Q = T*1000d;
		suffix = " ".ToCharArray();

		if(n < k){
			hasSuffix = false;
		}else{
			hasSuffix = true;
		}

		if(n >= k && n < M){
			if(n < 10d*k){
				n = Roundx(n/100d);
				n = n/10d;
			}else{
				n = Roundx(n/k);
			}
			suffix = "k".ToCharArray();
		}else if(n >= M && n < B){
			if(n < 10d*M){
				n = Roundx(n/(k*100d));
				n = n/10d;
			}else{
				n = Roundx(n/M);
			}
			suffix = "M".ToCharArray();
		}else if(n >= B && n < T){
			if(n < 10d*B){
				n = Roundx(n/(M*100d));
				n = n/10d;
			}else{
				n = Roundx(n/B);
			}
			suffix = "B".ToCharArray();
		}else if(n >= T && n < Q){
			if(n < 10d*T){
				n = Roundx(n/(B*100d));
				n = n/10d;
			}else{
				n = Roundx(n/T);
			}
			suffix = "T".ToCharArray();
		}else if(n >= Q){
			if(n < 10d*Q){
				n = Roundx(n/(T*100d));
				n = n/10d;
			}else{
				n = Roundx(n/Q);
			}
			suffix = "Q".ToCharArray();
		}

		res = CreateStringDecimalFromNumber(n);
		if(hasSuffix){
			res = strAppendString(res, suffix);
		}
        
		return res;
	}


	public static char [] NumberToHumanReadableBinary(double n){
		char [] res, suffix;
		bool hasSuffix;
		double Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi;

		Ki = 1024d;
		Mi = Ki*1024d;
		Gi = Mi*1024d;
		Ti = Gi*1024d;
		Pi = Ti*1024d;
		Ei = Pi*1024d;
		Zi = Ei*1024d;
		Yi = Zi*1024d;
		suffix = " ".ToCharArray();

		if(n < Ki){
			hasSuffix = false;
		}else{
			hasSuffix = true;
		}

		if(n >= Ki && n < Mi){
			if(n < 10d*Ki){
				n = Roundx(n/(Ki/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Ki);
			}
			suffix = "Ki".ToCharArray();
		}else if(n >= Mi && n < Gi){
			if(n < 10d*Mi){
				n = Roundx(n/(Mi/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Mi);
			}
			suffix = "Mi".ToCharArray();
		}else if(n >= Gi && n < Ti){
			if(n < 10d*Gi){
				n = Roundx(n/(Gi/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Gi);
			}
			suffix = "Gi".ToCharArray();
		}else if(n >= Ti && n < Pi){
			if(n < 10d*Ti){
				n = Roundx(n/(Ti/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Ti);
			}
			suffix = "Ti".ToCharArray();
		}else if(n >= Pi && n < Ei){
			if(n < 10d*Pi){
				n = Roundx(n/(Pi/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Pi);
			}
			suffix = "Pi".ToCharArray();
		}else if(n >= Ei && n < Zi){
			if(n < 10d*Ei){
				n = Roundx(n/(Ei/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Ei);
			}
			suffix = "Ei".ToCharArray();
		}else if(n >= Zi && n < Yi){
			if(n < 10d*Zi){
				n = Roundx(n/(Zi/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Zi);
			}
			suffix = "Zi".ToCharArray();
		}else if(n >= Yi){
			if(n < 10d*Yi){
				n = Roundx(n/(Yi/10d));
				n = n/10d;
			}else{
				n = Roundx(n/Yi);
			}
			suffix = "Yi".ToCharArray();
		}

		res = CreateStringDecimalFromNumber(n);
		if(hasSuffix){
			res = strAppendString(res, suffix);
		}

		return res;
	}


	public static char [] NumberToHumanReadableMetric(double n){
		char [] res, suffix;
		bool hasSuffix;
		double k, M, G, T, P, Ex, Z, Y, R, Q;

		k = 1000d;
		M = k*1000d;
		G = M*1000d;
		T = G*1000d;
		P = T*1000d;
		Ex = P*1000d;
		Z = Ex*1000d;
		Y = Z*1000d;
		R = Y*1000d;
		Q = R*1000d;
		suffix = " ".ToCharArray();

		if(n < k){
			hasSuffix = false;
		}else{
			hasSuffix = true;
		}

		if(n >= k && n < M){
			if(n < 10d*k){
				n = Roundx(n/100d);
				n = n/10d;
			}else{
				n = Roundx(n/k);
			}
			suffix = "k".ToCharArray();
		}else if(n >= M && n < G){
			if(n < 10d*M){
				n = Roundx(n/(k*100d));
				n = n/10d;
			}else{
				n = Roundx(n/M);
			}
			suffix = "M".ToCharArray();
		}else if(n >= G && n < T){
			if(n < 10d*G){
				n = Roundx(n/(M*100d));
				n = n/10d;
			}else{
				n = Roundx(n/G);
			}
			suffix = "G".ToCharArray();
		}else if(n >= T && n < P){
			if(n < 10d*T){
				n = Roundx(n/(G*100d));
				n = n/10d;
			}else{
				n = Roundx(n/T);
			}
			suffix = "T".ToCharArray();
		}else if(n >= P && n < Ex){
			if(n < 10d*P){
				n = Roundx(n/(T*100d));
				n = n/10d;
			}else{
				n = Roundx(n/P);
			}
			suffix = "P".ToCharArray();
		}else if(n >= Ex && n < Z){
			if(n < 10d*Ex){
				n = Roundx(n/(P*100d));
				n = n/10d;
			}else{
				n = Roundx(n/Ex);
			}
			suffix = "E".ToCharArray();
		}else if(n >= Z && n < Y){
			if(n < 10d*Z){
				n = Roundx(n/(Ex*100d));
				n = n/10d;
			}else{
				n = Roundx(n/Z);
			}
			suffix = "Z".ToCharArray();
		}else if(n >= Y && n < R){
			if(n < 10d*Y){
				n = Roundx(n/(Z*100d));
				n = n/10d;
			}else{
				n = Roundx(n/Y);
			}
			suffix = "Y".ToCharArray();
		}else if(n >= R && n < Q){
			if(n < 10d*R){
				n = Roundx(n/(Y*100d));
				n = n/10d;
			}else{
				n = Roundx(n/R);
			}
			suffix = "R".ToCharArray();
		}else if(n >= Q){
			if(n < 10d*Q){
				n = Roundx(n/(R*100d));
				n = n/10d;
			}else{
				n = Roundx(n/Q);
			}
			suffix = "Q".ToCharArray();
		}

		res = CreateStringDecimalFromNumber(n);
		if(hasSuffix){
			res = strAppendString(res, suffix);
		}

		return res;
	}


	public static bool IsValidNumber(char [] str){
		bool valid;
		NumberReference numberRef;
		StringReference message;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		delete(numberRef);
		delete(message);

		return valid;
	}


	public static bool IsValidInteger(char [] str){
		bool valid;
		NumberReference numberRef;
		StringReference message;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		if(valid){
			valid = IsInteger(numberRef.numberValue);
		}

		delete(numberRef);
		delete(message);

		return valid;
	}


	public static bool IsValidPositiveInteger(char [] str){
		bool valid;
		NumberReference numberRef;
		StringReference message;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		if(valid){
			valid = IsInteger(numberRef.numberValue);
			if(valid){
				valid = numberRef.numberValue >= 0d;
			}
		}

		delete(numberRef);
		delete(message);

		return valid;
	}


	public static bool CreateNumberFromDecimalStringWithCheck(char [] stringx, NumberReference decimalReference, StringReference message){
		return CreateNumberFromStringWithCheck(stringx, 10d, decimalReference, message);
	}


	public static double CreateNumberFromDecimalString(char [] stringx){
		NumberReference doubleReference;
		StringReference stringReference;
		double number;

		doubleReference = CreateNumberReference(0d);
		stringReference = CreateStringReference("".ToCharArray());
		CreateNumberFromStringWithCheck(stringx, 10d, doubleReference, stringReference);
		number = doubleReference.numberValue;

		delete(doubleReference);
		delete(stringReference);

		return number;
	}


	public static bool CreateNumberFromStringWithCheck(char [] stringx, double basex, NumberReference numberReference, StringReference message){
		bool success;
		BooleanReference numberIsPositive, exponentIsPositive;
		NumberArrayReference beforePoint, afterPoint, exponent;

		numberIsPositive = CreateBooleanReference(true);
		exponentIsPositive = CreateBooleanReference(true);
		beforePoint = new NumberArrayReference();
		afterPoint = new NumberArrayReference();
		exponent = new NumberArrayReference();

		if(basex >= 2d && basex <= 36d){
			success = ExtractPartsFromNumberString(stringx, basex, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

			if(success){
				numberReference.numberValue = CreateNumberFromParts(basex, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray);
			}
		}else{
			success = false;
			message.stringx = "Base must be from 2 to 36.".ToCharArray();
		}

		return success;
	}


	public static double CreateNumberFromParts(double basex, bool numberIsPositive, double [] beforePoint, double [] afterPoint, bool exponentIsPositive, double [] exponent){
		double n, i, p, e;

		n = 0d;

		for(i = 0d; i < beforePoint.Length; i = i + 1d){
			p = beforePoint[(int)(beforePoint.Length - i - 1d)];

			n = n + p*Pow(basex, i);
		}

		for(i = 0d; i < afterPoint.Length; i = i + 1d){
			p = afterPoint[(int)(i)];

			n = n + p/Pow(basex, i + 1d);
		}

		if(exponent.Length > 0d){
			e = 0d;
			for(i = 0d; i < exponent.Length; i = i + 1d){
				p = exponent[(int)(exponent.Length - i - 1d)];

				e = e + p*Pow(basex, i);
			}

			if(!exponentIsPositive){
				e = -e;
			}

			n = n*Pow(basex, e);
		}

		if(!numberIsPositive){
			n = -n;
		}

		return n;
	}


	public static bool ExtractPartsFromNumberString(char [] n, double basex, BooleanReference numberIsPositive, NumberArrayReference beforePoint, NumberArrayReference afterPoint, BooleanReference exponentIsPositive, NumberArrayReference exponent, StringReference errorMessages){
		double i, j, count;
		bool success, done, complete;

		i = 0d;
		complete = false;

		if(i < n.Length){
			if(n[(int)(i)] == '-'){
				numberIsPositive.booleanValue = false;
				i = i + 1d;
			}else if(n[(int)(i)] == '+'){
				numberIsPositive.booleanValue = true;
				i = i + 1d;
			}

			success = true;
		}else{
			success = false;
			errorMessages.stringx = "Number cannot have length zero.".ToCharArray();
		}

		if(success){
			done = false;
			count = 0d;
			for(; i + count < n.Length && !done; ){
				if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], basex)){
					count = count + 1d;
				}else{
					done = true;
				}
			}

			if(count >= 1d){
				beforePoint.numberArray = new double [(int)(count)];

				for(j = 0d; j < count; j = j + 1d){
					beforePoint.numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], basex);
				}

				i = i + count;

				if(i < n.Length){
					success = true;
				}else{
					afterPoint.numberArray = new double [0];
					exponent.numberArray = new double [0];
					success = true;
					complete = true;
				}
			}else{
				success = false;
				errorMessages.stringx = "Number must have at least one number after the optional sign.".ToCharArray();
			}
		}

		if(success && !complete){
			if(n[(int)(i)] == '.'){
				i = i + 1d;

				if(i < n.Length){
					done = false;
					count = 0d;
					for(; i + count < n.Length && !done; ){
						if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], basex)){
							count = count + 1d;
						}else{
							done = true;
						}
					}

					if(count >= 1d){
						afterPoint.numberArray = new double [(int)(count)];

						for(j = 0d; j < count; j = j + 1d){
							afterPoint.numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], basex);
						}

						i = i + count;

						if(i < n.Length){
							success = true;
						}else{
							exponent.numberArray = new double [0];
							success = true;
							complete = true;
						}
					}else{
						success = false;
						errorMessages.stringx = "There must be at least one digit after the decimal point.".ToCharArray();
					}
				}else{
					success = false;
					errorMessages.stringx = "There must be at least one digit after the decimal point.".ToCharArray();
				}
			}else if(basex <= 14d && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
				if(i < n.Length){
					success = true;
					afterPoint.numberArray = new double [0];
				}else{
					success = false;
					errorMessages.stringx = "There must be at least one digit after the exponent.".ToCharArray();
				}
			}else{
				success = false;
				errorMessages.stringx = "Expected decimal point or exponent symbol.".ToCharArray();
			}
		}

		if(success && !complete){
			if(basex <= 14d && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
				i = i + 1d;

				if(i < n.Length){
					if(n[(int)(i)] == '-'){
						exponentIsPositive.booleanValue = false;
						i = i + 1d;
					}else if(n[(int)(i)] == '+'){
						exponentIsPositive.booleanValue = true;
						i = i + 1d;
					}

					if(i < n.Length){
						done = false;
						count = 0d;
						for(; i + count < n.Length && !done; ){
							if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], basex)){
								count = count + 1d;
							}else{
								done = true;
							}
						}

						if(count >= 1d){
							exponent.numberArray = new double [(int)(count)];

							for(j = 0d; j < count; j = j + 1d){
								exponent.numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], basex);
							}

							i = i + count;

							if(i == n.Length){
								success = true;
							}else{
								success = false;
								errorMessages.stringx = "There cannot be any characters past the exponent of the number.".ToCharArray();
							}
						}else{
							success = false;
							errorMessages.stringx = "There must be at least one digit after the decimal point.".ToCharArray();
						}
					}else{
						success = false;
						errorMessages.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray();
					}
				}else{
					success = false;
					errorMessages.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray();
				}
			}else{
				success = false;
				errorMessages.stringx = "Expected exponent symbol.".ToCharArray();
			}
		}

		return success;
	}


	public static double GetNumberFromNumberCharacterForBase(char c, double basex){
		char [] numberTable;
		double i;
		double position;

		numberTable = GetDigitCharacterTable();
		position = 0d;

		for(i = 0d; i < basex; i = i + 1d){
			if(numberTable[(int)(i)] == c){
				position = i;
			}
		}

		return position;
	}


	public static bool CharacterIsNumberCharacterInBase(char c, double basex){
		char [] numberTable;
		double i;
		bool found;

		numberTable = GetDigitCharacterTable();
		found = false;

		for(i = 0d; i < basex; i = i + 1d){
			if(numberTable[(int)(i)] == c){
				found = true;
			}
		}

		return found;
	}


	public static double [] StringToNumberArray(char [] str){
		NumberArrayReference numberArrayReference;
		StringReference stringReference;
		double [] numbers;

		numberArrayReference = new NumberArrayReference();
		stringReference = new StringReference();

		StringToNumberArrayWithCheck(str, numberArrayReference, stringReference);

		numbers = numberArrayReference.numberArray;

		delete(numberArrayReference);
		delete(stringReference);

		return numbers;
	}


	public static bool StringToNumberArrayWithCheck(char [] str, NumberArrayReference numberArrayReference, StringReference errorMessage){
		StringReference [] numberStrings;
		double [] numbers;
		double i;
		char [] numberString, trimmedNumberString;
		bool success;
		NumberReference numberReference;

		numberStrings = strSplitByString(str, ",".ToCharArray());

		numbers = new double [(int)(numberStrings.Length)];
		success = true;
		numberReference = new NumberReference();

		for(i = 0d; i < numberStrings.Length; i = i + 1d){
			numberString = numberStrings[(int)(i)].stringx;
			trimmedNumberString = strTrim(numberString);
			success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage);
			numbers[(int)(i)] = numberReference.numberValue;

			FreeStringReference(numberStrings[(int)(i)]);
			delete(trimmedNumberString);
		}

		delete(numberStrings);
		delete(numberReference);

		numberArrayReference.numberArray = numbers;

		return success;
	}


	public static void strWriteStringToStingStream(char [] stream, NumberReference index, char [] src){
		double i;

		for(i = 0d; i < src.Length; i = i + 1d){
			stream[(int)(index.numberValue + i)] = src[(int)(i)];
		}
		index.numberValue = index.numberValue + src.Length;
	}


	public static void strWriteCharacterToStingStream(char [] stream, NumberReference index, char src){
		stream[(int)(index.numberValue)] = src;
		index.numberValue = index.numberValue + 1d;
	}


	public static void strWriteBooleanToStingStream(char [] stream, NumberReference index, bool src){
		if(src){
			strWriteStringToStingStream(stream, index, "true".ToCharArray());
		}else{
			strWriteStringToStingStream(stream, index, "false".ToCharArray());
		}
	}


	public static bool strSubstringWithCheck(char [] stringx, double from, double to, StringReference stringReference){
		bool success;

		if(from >= 0d && from <= stringx.Length && to >= 0d && to <= stringx.Length && from <= to){
			stringReference.stringx = strSubstring(stringx, from, to);
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static char [] strSubstring(char [] stringx, double from, double to){
		char [] n;
		double i, length;

		length = to - from;

		n = new char [(int)(length)];

		for(i = from; i < to; i = i + 1d){
			n[(int)(i - from)] = stringx[(int)(i)];
		}

		return n;
	}


	public static char [] strAppendString(char [] s1, char [] s2){
		char [] newString;

		newString = strConcatenateString(s1, s2);

		delete(s1);

		return newString;
	}


	public static char [] strConcatenateString(char [] s1, char [] s2){
		char [] newString;
		double i;

		newString = new char [(int)(s1.Length + s2.Length)];

		for(i = 0d; i < s1.Length; i = i + 1d){
			newString[(int)(i)] = s1[(int)(i)];
		}

		for(i = 0d; i < s2.Length; i = i + 1d){
			newString[(int)(s1.Length + i)] = s2[(int)(i)];
		}

		return newString;
	}


	public static char [] strAppendCharacter(char [] stringx, char c){
		char [] newString;

		newString = strConcatenateCharacter(stringx, c);

		delete(stringx);

		return newString;
	}


	public static char [] strConcatenateCharacter(char [] stringx, char c){
		char [] newString;
		double i;
		newString = new char [(int)(stringx.Length + 1d)];

		for(i = 0d; i < stringx.Length; i = i + 1d){
			newString[(int)(i)] = stringx[(int)(i)];
		}

		newString[(int)(stringx.Length)] = c;

		return newString;
	}


	public static StringReference [] strSplitByCharacter(char [] toSplit, char splitBy){
		StringReference [] parts;
		double i;
		char c;
		LinkedListStrings ll;
		LinkedListCharacters next;
		char [] part;

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0d; i < toSplit.Length; i = i + 1d){
			c = toSplit[(int)(i)];

			if(c == splitBy){
				part = LinkedListCharactersToArray(next);
				LinkedListAddString(ll, part);
				FreeLinkedListCharacter(next);
				next = CreateLinkedListCharacter();
			}else{
				LinkedListAddCharacter(next, c);
			}
		}

		part = LinkedListCharactersToArray(next);
		LinkedListAddString(ll, part);
		FreeLinkedListCharacter(next);

		parts = LinkedListStringsToArray(ll);
		FreeLinkedListString(ll);

		return parts;
	}


	public static bool strIndexOfCharacter(char [] stringx, char character, NumberReference indexReference){
		double i;
		bool found;

		found = false;
		for(i = 0d; i < stringx.Length && !found; i = i + 1d){
			if(stringx[(int)(i)] == character){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}


	public static bool strLastIndexOfCharacter(char [] stringx, char character, NumberReference indexReference){
		double i;
		bool found;

		found = false;
		for(i = 0d; i < stringx.Length; i = i + 1d){
			if(stringx[(int)(i)] == character){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}


	public static bool strSubstringEqualsWithCheck(char [] stringx, double from, char [] substring, BooleanReference equalsReference){
		bool success;

		if(from < stringx.Length){
			success = true;
			equalsReference.booleanValue = strSubstringEquals(stringx, from, substring);
		}else{
			success = false;
		}

		return success;
	}


	public static bool strSubstringEquals(char [] stringx, double from, char [] substring){
		double i;
		bool equal;

		equal = true;
		if(stringx.Length - from >= substring.Length){
			for(i = 0d; i < substring.Length && equal; i = i + 1d){
				if(stringx[(int)(from + i)] != substring[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static bool strIndexOfString(char [] stringx, char [] substring, NumberReference indexReference){
		double i;
		bool found;

		found = false;
		for(i = 0d; i < stringx.Length - substring.Length + 1d && !found; i = i + 1d){
			if(strSubstringEquals(stringx, i, substring)){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}


	public static bool strContainsCharacter(char [] stringx, char character){
		double i;
		bool found;

		found = false;
		for(i = 0d; i < stringx.Length && !found; i = i + 1d){
			if(stringx[(int)(i)] == character){
				found = true;
			}
		}

		return found;
	}


	public static bool strContainsString(char [] stringx, char [] substring){
		return strIndexOfString(stringx, substring, new NumberReference());
	}


	public static void strToUpperCase(char [] stringx){
		double i;

		for(i = 0d; i < stringx.Length; i = i + 1d){
			stringx[(int)(i)] = cToUpperCase(stringx[(int)(i)]);
		}
	}


	public static void strToLowerCase(char [] stringx){
		double i;

		for(i = 0d; i < stringx.Length; i = i + 1d){
			stringx[(int)(i)] = cToLowerCase(stringx[(int)(i)]);
		}
	}


	public static bool strEqualsIgnoreCase(char [] a, char [] b){
		bool equal;
		double i;

		if(a.Length == b.Length){
			equal = true;
			for(i = 0d; i < a.Length && equal; i = i + 1d){
				if(cToLowerCase(a[(int)(i)]) != cToLowerCase(b[(int)(i)])){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	public static char [] strReplaceString(char [] stringx, char [] toReplace, char [] replaceWith){
		char [] result;
		double i, j;
		BooleanReference equalsReference;
		bool success;
		DynamicArrayCharacters da;

		da = CreateDynamicArrayCharacters();

		equalsReference = new BooleanReference();

		for(i = 0d; i < stringx.Length; ){
			success = strSubstringEqualsWithCheck(stringx, i, toReplace, equalsReference);
			if(success){
				success = equalsReference.booleanValue;
			}

			if(success && toReplace.Length > 0d){
				for(j = 0d; j < replaceWith.Length; j = j + 1d){
					DynamicArrayAddCharacter(da, replaceWith[(int)(j)]);
				}
				i = i + toReplace.Length;
			}else{
				DynamicArrayAddCharacter(da, stringx[(int)(i)]);
				i = i + 1d;
			}
		}

		result = DynamicArrayCharactersToArray(da);

		FreeDynamicArrayCharacters(da);

		return result;
	}


	public static char [] strReplaceCharacterToNew(char [] stringx, char toReplace, char replaceWith){
		char [] result;
		double i;

		result = new char [(int)(stringx.Length)];

		for(i = 0d; i < stringx.Length; i = i + 1d){
			if(stringx[(int)(i)] == toReplace){
				result[(int)(i)] = replaceWith;
			}else{
				result[(int)(i)] = stringx[(int)(i)];
			}
		}

		return result;
	}


	public static void strReplaceCharacter(char [] stringx, char toReplace, char replaceWith){
		double i;

		for(i = 0d; i < stringx.Length; i = i + 1d){
			if(stringx[(int)(i)] == toReplace){
				stringx[(int)(i)] = replaceWith;
			}
		}
	}


	public static char [] strTrim(char [] stringx){
		char [] result;
		double i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd;
		bool firstNonWhitespaceFound;

		/* Find whitepaces at the start.*/
		lastWhitespaceLocationStart = -1d;
		firstNonWhitespaceFound = false;
		for(i = 0d; i < stringx.Length && !firstNonWhitespaceFound; i = i + 1d){
			if(cIsWhiteSpace(stringx[(int)(i)])){
				lastWhitespaceLocationStart = i;
			}else{
				firstNonWhitespaceFound = true;
			}
		}

		/* Find whitepaces at the end.*/
		lastWhitespaceLocationEnd = stringx.Length;
		firstNonWhitespaceFound = false;
		for(i = stringx.Length - 1d; i >= 0d && !firstNonWhitespaceFound; i = i - 1d){
			if(cIsWhiteSpace(stringx[(int)(i)])){
				lastWhitespaceLocationEnd = i;
			}else{
				firstNonWhitespaceFound = true;
			}
		}

		if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
			result = strSubstring(stringx, lastWhitespaceLocationStart + 1d, lastWhitespaceLocationEnd);
		}else{
			result = new char [0];
		}

		return result;
	}


	public static bool strStartsWith(char [] stringx, char [] start){
		bool startsWithString;

		startsWithString = false;
		if(stringx.Length >= start.Length){
			startsWithString = strSubstringEquals(stringx, 0d, start);
		}

		return startsWithString;
	}


	public static bool strEndsWith(char [] stringx, char [] end){
		bool endsWithString;

		endsWithString = false;
		if(stringx.Length >= end.Length){
			endsWithString = strSubstringEquals(stringx, stringx.Length - end.Length, end);
		}

		return endsWithString;
	}


	public static StringReference [] strSplitByString(char [] toSplit, char [] splitBy){
		StringReference [] parts;
		double i;
		char c;
		LinkedListStrings ll;
		LinkedListCharacters next;
		char [] part;

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0d; i < toSplit.Length; ){
			c = toSplit[(int)(i)];

			if(strSubstringEquals(toSplit, i, splitBy)){
				part = LinkedListCharactersToArray(next);
				LinkedListAddString(ll, part);
				FreeLinkedListCharacter(next);
				next = CreateLinkedListCharacter();
				i = i + splitBy.Length;
			}else{
				LinkedListAddCharacter(next, c);
				i = i + 1d;
			}
		}

		part = LinkedListCharactersToArray(next);
		LinkedListAddString(ll, part);
		FreeLinkedListCharacter(next);

		parts = LinkedListStringsToArray(ll);
		FreeLinkedListString(ll);

		return parts;
	}


	public static bool strStringIsBefore(char [] a, char [] b){
		bool before, equal, done;
		double i;

		before = false;
		equal = true;
		done = false;

		if(a.Length == 0d && b.Length > 0d){
			before = true;
		}else{
			for(i = 0d; i < a.Length && i < b.Length && !done; i = i + 1d){
				if(a[(int)(i)] != b[(int)(i)]){
					equal = false;
				}
				if(cCharacterIsBefore(a[(int)(i)], b[(int)(i)])){
					before = true;
				}
				if(cCharacterIsBefore(b[(int)(i)], a[(int)(i)])){
					done = true;
				}
			}

			if(equal){
				if(a.Length < b.Length){
					before = true;
				}
			}
		}

		return before;
	}


	public static char [] strJoinStringsWithSeparator(StringReference [] strings, char [] separator){
		char [] result, stringx;
		double length, i;
		NumberReference index;

		index = CreateNumberReference(0d);

		length = 0d;
		for(i = 0d; i < strings.Length; i = i + 1d){
			length = length + strings[(int)(i)].stringx.Length;
		}
		length = length + (strings.Length - 1d)*separator.Length;

		result = new char [(int)(length)];

		for(i = 0d; i < strings.Length; i = i + 1d){
			stringx = strings[(int)(i)].stringx;
			strWriteStringToStingStream(result, index, stringx);
			if(i + 1d < strings.Length){
				strWriteStringToStingStream(result, index, separator);
			}
		}

		delete(index);

		return result;
	}


	public static char [] strJoinStrings(StringReference [] strings){
		char [] result, stringx;
		double length, i;
		NumberReference index;

		index = CreateNumberReference(0d);

		length = 0d;
		for(i = 0d; i < strings.Length; i = i + 1d){
			length = length + strings[(int)(i)].stringx.Length;
		}

		result = new char [(int)(length)];

		for(i = 0d; i < strings.Length; i = i + 1d){
			stringx = strings[(int)(i)].stringx;
			strWriteStringToStingStream(result, index, stringx);
		}

		delete(index);

		return result;
	}


	public static double strStringOrder(char [] a, char [] b){
		double order, minimum, i, ac, bc;
		bool done;

		minimum = Min(a.Length, b.Length);

		done = false;
		order = 0d;
		for(i = 0d; i < minimum && !done; i = i + 1d){
			ac = a[(int)(i)];
			bc = b[(int)(i)];

			if(ac < bc){
				done = true;
				order = 1d;
			}else if(ac > bc){
				done = true;
				order = -1d;
			}
		}

		if(!done){
			if(a.Length < b.Length){
				order = 1d;
			}else if(a.Length > b.Length){
				order = -1d;
			}
		}

		return order;
	}


	public static char [] strLeftPad(char [] str, double width){
		double i;
		char [] padded;

		padded = new char [(int)(width)];
		arraysFillString(padded, ' ');

		for(i = 0d; i < str.Length; i = i + 1d){
			padded[(int)(width - str.Length + i)] = str[(int)(i)];
		}

		return padded;
	}


	public static char [] strRightPad(char [] str, double width){
		double i;
		char [] padded;

		padded = new char [(int)(width)];
		arraysFillString(padded, ' ');

		for(i = 0d; i < str.Length; i = i + 1d){
			padded[(int)(i)] = str[(int)(i)];
		}

		return padded;
	}


	public static void AssertFalse(bool b, NumberReference failures){
		if(b){
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertTrue(bool b, NumberReference failures){
		if(!b){
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertEquals(double a, double b, NumberReference failures){
		if(a != b){
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertBooleansEqual(bool a, bool b, NumberReference failures){
		if(a != b){
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertCharactersEqual(char a, char b, NumberReference failures){
		if(a != b){
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertStringEquals(char [] a, char [] b, NumberReference failures){
		if(!arraysStringsEqual(a, b)){
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertNumberArraysEqual(double [] a, double [] b, NumberReference failures){
		double i;

		if(a.Length == b.Length){
			for(i = 0d; i < a.Length; i = i + 1d){
				AssertEquals(a[(int)(i)], b[(int)(i)], failures);
			}
		}else{
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertBooleanArraysEqual(bool [] a, bool [] b, NumberReference failures){
		double i;

		if(a.Length == b.Length){
			for(i = 0d; i < a.Length; i = i + 1d){
				AssertBooleansEqual(a[(int)(i)], b[(int)(i)], failures);
			}
		}else{
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static void AssertStringArraysEqual(StringReference [] a, StringReference [] b, NumberReference failures){
		double i;

		if(a.Length == b.Length){
			for(i = 0d; i < a.Length; i = i + 1d){
				AssertStringEquals(a[(int)(i)].stringx, b[(int)(i)].stringx, failures);
			}
		}else{
			failures.numberValue = failures.numberValue + 1d;
		}
	}


	public static double Negate(double x){
		return -x;
	}


	public static double Positive(double x){
		return +x;
	}


	public static double Factorial(double x){
		double i, f;

		f = 1d;

		for(i = 2d; i <= x; i = i + 1d){
			f = f*i;
		}

		return f;
	}


	public static double Roundx(double x){
		return Floor(x + 0.5);
	}


	public static double RoundToDigits(double element, double digitsAfterPoint){
		return Roundx(element*Pow(10d, digitsAfterPoint))/Pow(10d, digitsAfterPoint);
	}


	public static double BankersRound(double x){
		double r;

		if(Absolute(x - Truncate(x)) == 0.5){
			if(!DivisibleBy(Roundx(x), 2d)){
				r = Roundx(x) - 1d;
			}else{
				r = Roundx(x);
			}
		}else{
			r = Roundx(x);
		}

		return r;
	}


	public static double Ceil(double x){
		return Ceiling(x);
	}


	public static double Floorx(double x){
		return Floor(x);
	}


	public static double Truncate(double x){
		double t;

		if(x >= 0d){
			t = Floor(x);
		}else{
			t = Ceiling(x);
		}

		return t;
	}


	public static double Absolute(double x){
		return Abs(x);
	}


	public static double Logarithm(double x){
		return Log10(x);
	}


	public static double NaturalLogarithm(double x){
		return Log(x);
	}


	public static double Sinx(double x){
		return Sin(x);
	}


	public static double Cosx(double x){
		return Cos(x);
	}


	public static double Tanx(double x){
		return Tan(x);
	}


	public static double Asinx(double x){
		return Asin(x);
	}


	public static double Acosx(double x){
		return Acos(x);
	}


	public static double Atanx(double x){
		return Atan(x);
	}


	public static double Atan2(double y, double x){
		double a;

		/* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.*/
		a = 0d;

		if(x > 0d){
			a = Atanx(y/x);
		}else if(x < 0d && y >= 0d){
			a = Atanx(y/x) + PI;
		}else if(x < 0d && y < 0d){
			a = Atanx(y/x) - PI;
		}else if(x == 0d && y > 0d){
			a = PI/2d;
		}else if(x == 0d && y < 0d){
			a = -PI/2d;
		}

		return a;
	}


	public static double Squareroot(double x){
		return Sqrt(x);
	}


	public static double Expx(double x){
		return Exp(x);
	}


	public static bool DivisibleBy(double a, double b){
		return ((a%b) == 0d);
	}


	public static double Combinations(double n, double k){
		double i, j, c;

		c = 1d;
		j = 1d;
		i = n - k + 1d;

		for(; i <= n; ){
			c = c*i;
			c = c/j;

			i = i + 1d;
			j = j + 1d;
		}

		return c;
	}


	public static double Permutations(double n, double k){
		double i, c;

		c = 1d;

		for(i = n - k + 1d; i <= n; i = i + 1d){
			c = c*i;
		}

		return c;
	}


	public static bool EpsilonCompare(double a, double b, double epsilon){
		return Abs(a - b) < epsilon;
	}


	public static double GreatestCommonDivisor(double a, double b){
		double t;

		for(; b != 0d; ){
			t = b;
			b = a%b;
			a = t;
		}

		return a;
	}


	public static double GCDWithSubtraction(double a, double b){
		double g;

		if(a == 0d){
			g = b;
		}else{
			for(; b != 0d; ){
				if(a > b){
					a = a - b;
				}else{
					b = b - a;
				}
			}

			g = a;
		}

		return g;
	}


	public static bool IsInteger(double a){
		return (a - Floor(a)) == 0d;
	}


	public static bool GreatestCommonDivisorWithCheck(double a, double b, NumberReference gcdReference){
		bool success;
		double gcd;

		if(IsInteger(a) && IsInteger(b)){
			gcd = GreatestCommonDivisor(a, b);
			gcdReference.numberValue = gcd;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static double LeastCommonMultiple(double a, double b){
		double lcm;

		if(a > 0d && b > 0d){
			lcm = Abs(a*b)/GreatestCommonDivisor(a, b);
		}else{
			lcm = 0d;
		}

		return lcm;
	}


	public static double Sign(double a){
		double s;

		if(a > 0d){
			s = 1d;
		}else if(a < 0d){
			s = -1d;
		}else{
			s = 0d;
		}

		return s;
	}


	public static double Maxx(double a, double b){
		return Max(a, b);
	}


	public static double Minx(double a, double b){
		return Min(a, b);
	}


	public static double Power(double a, double b){
		return Pow(a, b);
	}


	public static double Gamma(double x){
		return LanczosApproximation(x);
	}


	public static double LogGamma(double x){
		return Log(Gamma(x));
	}


	public static double LanczosApproximation(double z){
		double [] p;
		double i, y, t, x;

		p = new double [8];
		p[0] = 676.5203681218851;
		p[1] = -1259.1392167224028;
		p[2] = 771.32342877765313;
		p[3] = -176.61502916214059;
		p[4] = 12.507343278686905;
		p[5] = -0.13857109526572012;
		p[6] = 9.9843695780195716e-6;
		p[7] = 1.5056327351493116e-7;

		if(z < 0.5){
			y = PI/(Sin(PI*z)*LanczosApproximation(1d - z));
		}else{
			z = z - 1d;
			x = 0.99999999999980993;
			for(i = 0d; i < p.Length; i = i + 1d){
				x = x + p[(int)(i)]/(z + i + 1d);
			}
			t = z + p.Length - 0.5;
			y = Sqrt(2d*PI)*Pow(t, z + 0.5)*Exp(-t)*x;
		}

		return y;
	}


	public static double Beta(double x, double y){
		return Gamma(x)*Gamma(y)/Gamma(x + y);
	}


	public static double Sinh(double x){
		return (Exp(x) - Exp(-x))/2d;
	}


	public static double Cosh(double x){
		return (Exp(x) + Exp(-x))/2d;
	}


	public static double Tanh(double x){
		return Sinh(x)/Cosh(x);
	}


	public static double Cot(double x){
		return 1d/Tan(x);
	}


	public static double Sec(double x){
		return 1d/Cos(x);
	}


	public static double Csc(double x){
		return 1d/Sin(x);
	}


	public static double Coth(double x){
		return Cosh(x)/Sinh(x);
	}


	public static double Sech(double x){
		return 1d/Cosh(x);
	}


	public static double Csch(double x){
		return 1d/Sinh(x);
	}


	public static double Error(double x){
		double y, t, tau, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

		if(x == 0d){
			y = 0d;
		}else if(x < 0d){
			y = -Error(-x);
		}else{
			c1 = -1.26551223;
			c2 = +1.00002368;
			c3 = +0.37409196;
			c4 = +0.09678418;
			c5 = -0.18628806;
			c6 = +0.27886807;
			c7 = -1.13520398;
			c8 = +1.48851587;
			c9 = -0.82215223;
			c10 = +0.17087277;

			t = 1d/(1d + 0.5*Abs(x));

			tau = t*Exp(-Pow(x, 2d) + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))));

			y = 1d - tau;
		}

		return y;
	}


	public static double ErrorInverse(double x){
		double y, a, t;

		a = (8d*(PI - 3d))/(3d*PI*(4d - PI));

		t = 2d/(PI*a) + Log(1d - Pow(x, 2d))/2d;
		y = Sign(x)*Sqrt(Sqrt(Pow(t, 2d) - Log(1d - Pow(x, 2d))/a) - t);

		return y;
	}


	public static double FallingFactorial(double x, double n){
		double k, y;

		y = 1d;

		for(k = 0d; k <= n - 1d; k = k + 1d){
			y = y*(x - k);
		}

		return y;
	}


	public static double RisingFactorial(double x, double n){
		double k, y;

		y = 1d;

		for(k = 0d; k <= n - 1d; k = k + 1d){
			y = y*(x + k);
		}

		return y;
	}


	public static double Hypergeometric(double a, double b, double c, double z, double maxIterations, double precision){
		double y;

		if(Abs(z) >= 0.5){
			y = Pow(1d - z, -a)*HypergeometricDirect(a, c - b, c, z/(z - 1d), maxIterations, precision);
		}else{
			y = HypergeometricDirect(a, b, c, z, maxIterations, precision);
		}

		return y;
	}


	public static double HypergeometricDirect(double a, double b, double c, double z, double maxIterations, double precision){
		double y, yp, n;
		bool done;

		y = 0d;
		done = false;

		for(n = 0d; n < maxIterations && !done; n = n + 1d){
			yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*Pow(z, n)/Factorial(n);
			if(Abs(yp) < precision){
				done = true;
			}
			y = y + yp;
		}

		return y;
	}


	public static double BernouilliNumber(double n){
		return AkiyamaTanigawaAlgorithm(n);
	}


	public static double AkiyamaTanigawaAlgorithm(double n){
		double m, j, B;
		double [] A;

		A = new double [(int)(n + 1d)];

		for(m = 0d; m <= n; m = m + 1d){
			A[(int)(m)] = 1d/(m + 1d);
			for(j = m; j >= 1d; j = j - 1d){
				A[(int)(j - 1d)] = j*(A[(int)(j - 1d)] - A[(int)(j)]);
			}
		}

		B = A[0];

		delete(A);

		return B;
	}


	public static double D15Add(double a, double b, BooleanReference overflow){
		double x;

		x = a + b;

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0d;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double RoundTo15Digits(double x){
		double p;

		p = Floor(Log10(x));
		x = x*Pow(10d, 15d - p);
		x = Roundx(x);
		x = x/Pow(10d, 15d - p);

		return x;
	}


	public static double D15MaxValue(){
		return +9.99999999999999e99;
	}


	public static double D15MinValue(){
		return -9.99999999999999e99;
	}


	public static double D15Multiply(double a, double b, BooleanReference overflow){
		double x;

		x = a*b;

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0d;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15Divide(double a, double b, NumberReference reminder, BooleanReference overflow, BooleanReference invalidOperation){
		double x, r;

		if(b != 0d){
			invalidOperation.booleanValue = false;

			x = a/b;
			r = a%b;

			if(x > D15MaxValue() || x < D15MinValue()){
				overflow.booleanValue = true;
				x = 0d;
				r = 0d;
			}else{
				overflow.booleanValue = false;
				x = RoundTo15Digits(x);
				r = RoundTo15Digits(r);
			}
		}else{
			invalidOperation.booleanValue = true;
			overflow.booleanValue = false;
			x = 0d;
			r = 0d;
		}

		reminder.numberValue = r;

		return x;
	}


	public static double D15Exponentiation(double a, double b, BooleanReference overflow, BooleanReference invalidOperation){
		double x;

		if(a == 0d && b == 0d){
			invalidOperation.booleanValue = true;
			overflow.booleanValue = false;
			x = 0d;
		}else if(a < 0d && !IsInteger(b)){
			invalidOperation.booleanValue = true;
			overflow.booleanValue = false;
			x = 0d;
		}else{
			invalidOperation.booleanValue = false;

			x = Pow(a, b);

			if(x > D15MaxValue() || x < D15MinValue()){
				overflow.booleanValue = true;
				x = 0d;
			}else{
				overflow.booleanValue = false;
				x = RoundTo15Digits(x);
			}
		}

		return x;
	}


	public static double D15Modulus(double a, double b, BooleanReference invalidOperation){
		double x;

		if(a < 0d || b == 0d || b < 0d){
			invalidOperation.booleanValue = true;
			x = 0d;
		}else{
			invalidOperation.booleanValue = false;
			x = a%b;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15Logarithm(double a, BooleanReference invalidOperation){
		double x;

		if(a <= 0d){
			invalidOperation.booleanValue = true;
			x = 0d;
		}else{
			invalidOperation.booleanValue = false;
			x = Log10(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15NaturalLogarithm(double a, BooleanReference invalidOperation){
		double x;

		if(a <= 0d){
			invalidOperation.booleanValue = true;
			x = 0d;
		}else{
			invalidOperation.booleanValue = false;
			x = Log(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15Sin(double a){
		double x;

		x = Sin(a);
		x = RoundTo15Digits(x);

		return x;
	}


	public static double D15Cos(double x){
		double a, y, piBy2Part1, piBy2Part2, limit, f;

		x = Abs(x);

		limit = PI + 3.1/2d;

		if(x > limit){
			f = Floor(x/PI);
			x = x - PI*f;
		}

		piBy2Part1 = +1.57079632679490;
		piBy2Part2 = -3.38076867830836e-15;

		if(x > 3.1/2d && x < 3.3/2d){
			a = x - piBy2Part1;
			a = (double)Round(a*Pow(10d, 15d))/Pow(10d, 15d);
			a = a - piBy2Part2;
			y = -Sin(a);
		}else{
			y = Cos(x);
			y = RoundTo15Digits(y);
		}

		return y;
	}


	public static double D15Tan(double a, BooleanReference overflow){
		double x;

		x = Tan(a);

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0d;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15Asin(double a, BooleanReference invalidOperation){
		double x;

		if(a < -1d || a > 1d){
			invalidOperation.booleanValue = true;
			x = 0d;
		}else{
			invalidOperation.booleanValue = false;
			x = Asin(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15Acos(double a, BooleanReference invalidOperation){
		double x;

		if(a < -1d || a > 1d){
			invalidOperation.booleanValue = true;
			x = 0d;
		}else{
			invalidOperation.booleanValue = false;
			x = Acos(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static double D15Atan(double a){
		double x;

		x = Atan(a);
		x = RoundTo15Digits(x);

		return x;
	}


	public static double D15Sqrt(double a){
		double x;

		x = Sqrt(a);
		x = RoundTo15Digits(x);

		return x;
	}


	public static double D15Exponential(double a, BooleanReference overflow){
		double x;

		x = Exp(a);

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0d;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	public static char [] Decimal15E2ToString(double decimalx){
		double multiplier, inc, i, d;
		double exponent;
		bool done, isPositive, isPositiveExponent;
		char [] result;
		double len;

		len = 21d;
		/* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"*/
		result = new char [(int)(len)];

		done = false;
		exponent = 0d;

		if(decimalx < 0d){
			isPositive = false;
			decimalx = -decimalx;
		}else{
			isPositive = true;
		}

		if(decimalx == 0d){
			done = true;
		}

		if(!done){
			multiplier = 0d;
			inc = 0d;

			if(decimalx < 1d){
				multiplier = 10d;
				inc = -1d;
			}else if(decimalx >= 10d){
				multiplier = 0.1;
				inc = 1d;
			}else{
				done = true;
			}

			if(!done){
				exponent = (double)Round(Log10(decimalx));
				exponent = Min(99d, exponent);
				exponent = Max(-99d, exponent);

				decimalx = decimalx/Pow(10d, exponent);

				/* Adjust*/
				for(; (decimalx >= 10d || decimalx < 1d) && Abs(exponent) < 99d; ){
					decimalx = decimalx*multiplier;
					exponent = exponent + inc;
				}
			}
		}

		isPositiveExponent = exponent >= 0d;
		if(!isPositiveExponent){
			exponent = -exponent;
		}

		if(isPositive){
			result[0] = '+';
		}else{
			result[0] = '-';
		}

		decimalx = (double)Round(decimalx*Pow(10d, 14d));

		d = Floor(decimalx/Pow(10d, 14d));
		result[1] = SingleDigitNumberToCharacter(d);
		decimalx = decimalx - d*Pow(10d, 14d);

		result[2] = '.';

		for(i = 0d; i < 14d; i = i + 1d){
			d = Floor(decimalx/Pow(10d, 13d - i));
			result[(int)(3d + i)] = SingleDigitNumberToCharacter(d);
			decimalx = decimalx - d*Pow(10d, 13d - i);
		}

		result[17] = 'e';

		if(isPositiveExponent){
			result[18] = '+';
		}else{
			result[18] = '-';
		}

		result[19] = SingleDigitNumberToCharacter(Floor(exponent/10d));
		result[20] = SingleDigitNumberToCharacter(Floor(exponent%10d));

		return result;
	}


	public static char SingleDigitNumberToCharacter(double n){
		char c;

		c = '0';
		if(n == 0d){
			c = '0';
		}else if(n == 1d){
			c = '1';
		}else if(n == 2d){
			c = '2';
		}else if(n == 3d){
			c = '3';
		}else if(n == 4d){
			c = '4';
		}else if(n == 5d){
			c = '5';
		}else if(n == 6d){
			c = '6';
		}else if(n == 7d){
			c = '7';
		}else if(n == 8d){
			c = '8';
		}else if(n == 9d){
			c = '9';
		}

		return c;
	}


	public static char cToLowerCase(char character){
		char toReturn;

		toReturn = character;
		if(character == 'A'){
			toReturn = 'a';
		}else if(character == 'B'){
			toReturn = 'b';
		}else if(character == 'C'){
			toReturn = 'c';
		}else if(character == 'D'){
			toReturn = 'd';
		}else if(character == 'E'){
			toReturn = 'e';
		}else if(character == 'F'){
			toReturn = 'f';
		}else if(character == 'G'){
			toReturn = 'g';
		}else if(character == 'H'){
			toReturn = 'h';
		}else if(character == 'I'){
			toReturn = 'i';
		}else if(character == 'J'){
			toReturn = 'j';
		}else if(character == 'K'){
			toReturn = 'k';
		}else if(character == 'L'){
			toReturn = 'l';
		}else if(character == 'M'){
			toReturn = 'm';
		}else if(character == 'N'){
			toReturn = 'n';
		}else if(character == 'O'){
			toReturn = 'o';
		}else if(character == 'P'){
			toReturn = 'p';
		}else if(character == 'Q'){
			toReturn = 'q';
		}else if(character == 'R'){
			toReturn = 'r';
		}else if(character == 'S'){
			toReturn = 's';
		}else if(character == 'T'){
			toReturn = 't';
		}else if(character == 'U'){
			toReturn = 'u';
		}else if(character == 'V'){
			toReturn = 'v';
		}else if(character == 'W'){
			toReturn = 'w';
		}else if(character == 'X'){
			toReturn = 'x';
		}else if(character == 'Y'){
			toReturn = 'y';
		}else if(character == 'Z'){
			toReturn = 'z';
		}

		return toReturn;
	}


	public static char cToUpperCase(char character){
		char toReturn;

		toReturn = character;
		if(character == 'a'){
			toReturn = 'A';
		}else if(character == 'b'){
			toReturn = 'B';
		}else if(character == 'c'){
			toReturn = 'C';
		}else if(character == 'd'){
			toReturn = 'D';
		}else if(character == 'e'){
			toReturn = 'E';
		}else if(character == 'f'){
			toReturn = 'F';
		}else if(character == 'g'){
			toReturn = 'G';
		}else if(character == 'h'){
			toReturn = 'H';
		}else if(character == 'i'){
			toReturn = 'I';
		}else if(character == 'j'){
			toReturn = 'J';
		}else if(character == 'k'){
			toReturn = 'K';
		}else if(character == 'l'){
			toReturn = 'L';
		}else if(character == 'm'){
			toReturn = 'M';
		}else if(character == 'n'){
			toReturn = 'N';
		}else if(character == 'o'){
			toReturn = 'O';
		}else if(character == 'p'){
			toReturn = 'P';
		}else if(character == 'q'){
			toReturn = 'Q';
		}else if(character == 'r'){
			toReturn = 'R';
		}else if(character == 's'){
			toReturn = 'S';
		}else if(character == 't'){
			toReturn = 'T';
		}else if(character == 'u'){
			toReturn = 'U';
		}else if(character == 'v'){
			toReturn = 'V';
		}else if(character == 'w'){
			toReturn = 'W';
		}else if(character == 'x'){
			toReturn = 'X';
		}else if(character == 'y'){
			toReturn = 'Y';
		}else if(character == 'z'){
			toReturn = 'Z';
		}

		return toReturn;
	}


	public static bool cIsUpperCase(char character){
		bool isUpper;

		isUpper = true;
		if(character == 'A'){
		}else if(character == 'B'){
		}else if(character == 'C'){
		}else if(character == 'D'){
		}else if(character == 'E'){
		}else if(character == 'F'){
		}else if(character == 'G'){
		}else if(character == 'H'){
		}else if(character == 'I'){
		}else if(character == 'J'){
		}else if(character == 'K'){
		}else if(character == 'L'){
		}else if(character == 'M'){
		}else if(character == 'N'){
		}else if(character == 'O'){
		}else if(character == 'P'){
		}else if(character == 'Q'){
		}else if(character == 'R'){
		}else if(character == 'S'){
		}else if(character == 'T'){
		}else if(character == 'U'){
		}else if(character == 'V'){
		}else if(character == 'W'){
		}else if(character == 'X'){
		}else if(character == 'Y'){
		}else if(character == 'Z'){
		}else{
			isUpper = false;
		}

		return isUpper;
	}


	public static bool cIsLowerCase(char character){
		bool isLower;

		isLower = true;
		if(character == 'a'){
		}else if(character == 'b'){
		}else if(character == 'c'){
		}else if(character == 'd'){
		}else if(character == 'e'){
		}else if(character == 'f'){
		}else if(character == 'g'){
		}else if(character == 'h'){
		}else if(character == 'i'){
		}else if(character == 'j'){
		}else if(character == 'k'){
		}else if(character == 'l'){
		}else if(character == 'm'){
		}else if(character == 'n'){
		}else if(character == 'o'){
		}else if(character == 'p'){
		}else if(character == 'q'){
		}else if(character == 'r'){
		}else if(character == 's'){
		}else if(character == 't'){
		}else if(character == 'u'){
		}else if(character == 'v'){
		}else if(character == 'w'){
		}else if(character == 'x'){
		}else if(character == 'y'){
		}else if(character == 'z'){
		}else{
			isLower = false;
		}

		return isLower;
	}


	public static bool cIsLetter(char character){
		return cIsUpperCase(character) || cIsLowerCase(character);
	}


	public static bool cIsNumber(char character){
		bool isNumberx;

		isNumberx = true;
		if(character == '0'){
		}else if(character == '1'){
		}else if(character == '2'){
		}else if(character == '3'){
		}else if(character == '4'){
		}else if(character == '5'){
		}else if(character == '6'){
		}else if(character == '7'){
		}else if(character == '8'){
		}else if(character == '9'){
		}else{
			isNumberx = false;
		}

		return isNumberx;
	}


	public static bool cIsWhiteSpace(char character){
		bool isWhiteSpacex;

		isWhiteSpacex = true;
		if(character == ' '){
		}else if(character == '\t'){
		}else if(character == '\n'){
		}else if(character == '\r'){
		}else{
			isWhiteSpacex = false;
		}

		return isWhiteSpacex;
	}


	public static bool cIsSymbol(char character){
		bool isSymbolx;

		isSymbolx = true;
		if(character == '!'){
		}else if(character == '\"'){
		}else if(character == '#'){
		}else if(character == '$'){
		}else if(character == '%'){
		}else if(character == '&'){
		}else if(character == '\''){
		}else if(character == '('){
		}else if(character == ')'){
		}else if(character == '*'){
		}else if(character == '+'){
		}else if(character == ','){
		}else if(character == '-'){
		}else if(character == '.'){
		}else if(character == '/'){
		}else if(character == ':'){
		}else if(character == ';'){
		}else if(character == '<'){
		}else if(character == '='){
		}else if(character == '>'){
		}else if(character == '?'){
		}else if(character == '@'){
		}else if(character == '['){
		}else if(character == '\\'){
		}else if(character == ']'){
		}else if(character == '^'){
		}else if(character == '_'){
		}else if(character == '`'){
		}else if(character == '{'){
		}else if(character == '|'){
		}else if(character == '}'){
		}else if(character == '~'){
		}else{
			isSymbolx = false;
		}

		return isSymbolx;
	}


	public static bool cCharacterIsBefore(char a, char b){
		double ad, bd;

		ad = a;
		bd = b;

		return ad < bd;
	}


	public static char cDecimalDigitToCharacter(double digit){
		char c;
		if(digit == 1d){
			c = '1';
		}else if(digit == 2d){
			c = '2';
		}else if(digit == 3d){
			c = '3';
		}else if(digit == 4d){
			c = '4';
		}else if(digit == 5d){
			c = '5';
		}else if(digit == 6d){
			c = '6';
		}else if(digit == 7d){
			c = '7';
		}else if(digit == 8d){
			c = '8';
		}else if(digit == 9d){
			c = '9';
		}else{
			c = '0';
		}
		return c;
	}


	public static double cCharacterToDecimalDigit(char c){
		double digit;

		if(c == '1'){
			digit = 1d;
		}else if(c == '2'){
			digit = 2d;
		}else if(c == '3'){
			digit = 3d;
		}else if(c == '4'){
			digit = 4d;
		}else if(c == '5'){
			digit = 5d;
		}else if(c == '6'){
			digit = 6d;
		}else if(c == '7'){
			digit = 7d;
		}else if(c == '8'){
			digit = 8d;
		}else if(c == '9'){
			digit = 9d;
		}else{
			digit = 0d;
		}

		return digit;
	}


	public static void delete(System.Object objectx){
		// C# has garbage collection.
	}
}

