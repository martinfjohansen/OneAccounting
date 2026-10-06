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
public class Sections{
	public char [] codes;
	public double [] counts;
}
public class RGBABitmapImageReference{
	public RGBABitmapImage image;
}
public class Success{
	public char [] feilmelding;
	public bool success;
}
public class RGBABitmapImageReference{
	public RGBABitmapImage image;
}
public class Rectangle{
	public double x1;
	public double x2;
	public double y1;
	public double y2;
}
public class ScatterPlotSeries{
	public bool linearInterpolation;
	public char [] pointType;
	public char [] lineType;
	public double lineThickness;
	public double [] xs;
	public double [] ys;
	public RGBA color;
}
public class ScatterPlotSettings{
	public ScatterPlotSeries [] scatterPlotSeries;
	public bool autoBoundaries;
	public double xMax;
	public double xMin;
	public double yMax;
	public double yMin;
	public bool autoPadding;
	public double xPadding;
	public double yPadding;
	public char [] xLabel;
	public char [] yLabel;
	public char [] title;
	public bool showGrid;
	public RGBA gridColor;
	public bool xAxisAuto;
	public bool xAxisTop;
	public bool xAxisBottom;
	public bool yAxisAuto;
	public bool yAxisLeft;
	public bool yAxisRight;
	public double width;
	public double height;
}
public class BarPlotSeries{
	public double [] ys;
	public RGBA color;
}
public class BarPlotSettings{
	public double width;
	public double height;
	public bool autoBoundaries;
	public double yMax;
	public double yMin;
	public bool autoPadding;
	public double xPadding;
	public double yPadding;
	public char [] title;
	public bool showGrid;
	public RGBA gridColor;
	public BarPlotSeries [] barPlotSeries;
	public char [] yLabel;
	public bool autoColor;
	public bool grayscaleAutoColor;
	public bool autoSpacing;
	public double groupSeparation;
	public double barSeparation;
	public bool autoLabels;
	public StringReference [] xLabels;
	public bool barBorder;
}
public class ArbitraryPrecisionInteger{
	public bool sign;
	public UnsignedInteger number;
}
public class ArbitraryPrecisionFixedPointNumber{
	public ArbitraryPrecisionInteger baseNumber;
	public double pointPosition;
}
public class UnsignedInteger{
	public double [] digits;
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
public class RGBA{
	public double r;
	public double g;
	public double b;
	public double a;
}
public class RGBABitmap{
	public RGBA [] y;
}
public class RGBABitmapImage{
	public RGBABitmap [] x;
}
public class Matrix{
	public MatrixRow [] r;
}
public class MatrixArrayReference{
	public Matrix [] matrices;
}
public class MatrixReference{
	public Matrix matrix;
}
public class MatrixRow{
	public double [] c;
}
public class ComplexMatrix{
	public ComplexMatrixRow [] r;
}
public class ComplexMatrixArrayReference{
	public ComplexMatrix [] matrices;
}
public class ComplexMatrixReference{
	public ComplexMatrix matrix;
}
public class ComplexMatrixRow{
	public cComplexNumber [] c;
}
public class LinearCongruentialGenerator{
	public double x;
	public double a;
	public double c;
	public double m;
}
public class PseudorandomGenerator{
	public LinearCongruentialGenerator lcg;
}
public class cComplexNumber{
	public double re;
	public double im;
}
public class cComplexNumberArrayReference{
	public cComplexNumber [] complexNumbers;
}
public class cComplexNumberReference{
	public cComplexNumber complexNumbers;
}
public class cPolarComplexNumber{
	public double r;
	public double phi;
}
public class pComplexPolynomial{
	public cComplexNumber [] cs;
}
public class OneAccounting{
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
		bool valid, success;
		Date date;
		FixedPoint15d c, d;
		StringReference message;

		message = new StringReference();

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

			success = AddMonthsToDate(date, 1d, message);
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


	public static bool LuhnCheck(char [] number, StringReference errorMessage){
		bool isValid;
		StringReference numberReference;
		CharacterReference checkDigitReference;
		char [] numberString;
		NumberReference digitReference;

		numberReference = new StringReference();
		checkDigitReference = new CharacterReference();
		numberString = new char [1];
		digitReference = new NumberReference();

		isValid = arraysCopyStringRange(number, 0d, number.Length - 1d, numberReference);
		if(isValid){
			isValid = LuhnComputeCheckDigit(numberReference.stringx, checkDigitReference, errorMessage);
			if(isValid){
				if(checkDigitReference.characterValue == number[(int)(number.Length - 1d)]){
				}else{
					numberString[0] = number[(int)(number.Length - 1d)];
					isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage);
					if(isValid){
						errorMessage.stringx = "Check digit wrong.".ToCharArray();
					}else{
						errorMessage.stringx = "Check symbol not a digit.".ToCharArray();
					}
					isValid = false;
				}
			}
		}else{
			errorMessage.stringx = "Number is too short: must be at least one digit.".ToCharArray();
		}

		return isValid;
	}


	public static bool LuhnComputeCheckDigit(char [] number, CharacterReference checkDigitReference, StringReference errorMessage){
		double sum, n, i, check;
		bool alternate, isValid;
		NumberReference numberReference;
		char [] numberString;

		sum = 0d;
		alternate = true;
		numberString = new char [1];
		numberReference = new NumberReference();
		isValid = true;

		for(i = number.Length - 1d; i >= 0d && isValid; i = i - 1d){
			numberString[0] = number[(int)(i)];
			isValid = CreateNumberFromDecimalStringWithCheck(numberString, numberReference, errorMessage);
			if(isValid){
				n = numberReference.numberValue;
				if(alternate){
					n = n*2d;
					if(n > 9d){
						n = (n%10d) + 1d;
					}
				}
				sum = sum + n;
				alternate = !alternate;
			}else{
				errorMessage.stringx = "Invalid digit in number string.".ToCharArray();
			}
		}

		if(isValid){
			check = sum%10d;

			if(check != 0d){
				check = 10d - check;
			}

			GetSingleDigitCharacterFromNumberWithCheck(check, 10d, checkDigitReference);
		}

		return isValid;
	}


	public static bool LuhnExtendWithCheckDigit(char [] number, StringReference extended, StringReference errorMessage){
		bool isValid;
		double i;
		CharacterReference checkDigitReference;

		checkDigitReference = new CharacterReference();
		isValid = LuhnComputeCheckDigit(number, checkDigitReference, errorMessage);

		if(isValid){
			extended.stringx = new char [(int)(number.Length + 1d)];
			for(i = 0d; i < number.Length; i = i + 1d){
				extended.stringx[(int)(i)] = number[(int)(i)];
			}
			extended.stringx[(int)(i)] = checkDigitReference.characterValue;
		}

		return isValid;
	}


	public static bool ISINCheck(char [] isin, StringReference errorMessage){
		bool isValid;
		StringReference numberReference;
		CharacterReference checkDigitReference;
		char [] numberString;
		NumberReference digitReference;

		numberReference = new StringReference();
		checkDigitReference = new CharacterReference();
		numberString = new char [1];
		digitReference = new NumberReference();

		if(isin.Length == 12d){
			arraysCopyStringRange(isin, 0d, isin.Length - 1d, numberReference);

			isValid = ISINComputeCheckDigit(numberReference.stringx, checkDigitReference, errorMessage);
			if(isValid){
				if(checkDigitReference.characterValue == isin[(int)(isin.Length - 1d)]){
				}else{
					numberString[0] = isin[(int)(isin.Length - 1d)];
					isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage);
					if(isValid){
						errorMessage.stringx = "Check digit wrong.".ToCharArray();
					}else{
						errorMessage.stringx = "Check symbol not a digit.".ToCharArray();
					}
					isValid = false;
				}
			}
		}else{
			isValid = false;
			errorMessage.stringx = "ISIN must be 12 alpha-numeric characters.".ToCharArray();
		}

		return isValid;
	}


	public static bool ISINComputeCheckDigit(char [] isin, CharacterReference checkDigitReference, StringReference errorMessage){
		bool isValid;
		StringReference isinNumericReference;

		isinNumericReference = new StringReference();

		if(isin.Length == 11d){
			isValid = ISINToNumericCode(isin, isinNumericReference, errorMessage);

			if(isValid){
				LuhnComputeCheckDigit(isinNumericReference.stringx, checkDigitReference, errorMessage);
			}
		}else{
			isValid = false;
			errorMessage.stringx = "ISIN must be 11 digits before the checksum digit to be calculated.".ToCharArray();
		}

		return isValid;
	}


	public static bool ISINExtendWithCheckDigit(char [] isin, StringReference extended, StringReference errorMessage){
		bool isValid;
		double i;
		CharacterReference checkDigitReference;

		checkDigitReference = new CharacterReference();
		isValid = ISINComputeCheckDigit(isin, checkDigitReference, errorMessage);

		if(isValid){
			extended.stringx = new char [(int)(isin.Length + 1d)];
			for(i = 0d; i < isin.Length; i = i + 1d){
				extended.stringx[(int)(i)] = isin[(int)(i)];
			}
			extended.stringx[(int)(i)] = checkDigitReference.characterValue;
		}

		return isValid;
	}


	public static bool ISINToNumericCode(char [] isin, StringReference isinNumericReference, StringReference errorMessage){
		bool isValid;
		double length, i, pos;
		StringReference code;

		isValid = true;
		code = new StringReference();

		length = 0d;

		for(i = 0d; i < isin.Length && isValid; i = i + 1d){
			if(cIsLetter(isin[(int)(i)])){
				length = length + 2d;
			}else if(cIsNumber(isin[(int)(i)])){
				length = length + 1d;
			}else{
				isValid = false;
				errorMessage.stringx = "ISIN can only contain alpha-numeric characters.".ToCharArray();
			}
		}

		if(isValid){
			isinNumericReference.stringx = new char [(int)(length)];

			pos = 0d;

			for(i = 0d; i < isin.Length; i = i + 1d){
				ISINSymbolToCode(isin[(int)(i)], code, errorMessage);

				isinNumericReference.stringx[(int)(pos)] = code.stringx[0];
				pos = pos + 1d;
				if(code.stringx.Length == 2d){
					isinNumericReference.stringx[(int)(pos)] = code.stringx[1];
					pos = pos + 1d;
				}
			}
		}

		return isValid;
	}


	public static bool ISINSymbolToCode(char c, StringReference stringReference, StringReference errorMessage){
		bool isValid;

		if(cIsLetter(c) && cIsUpperCase(c)){
			if(c == 'A'){
				stringReference.stringx = "10".ToCharArray();
			}else if(c == 'B'){
				stringReference.stringx = "11".ToCharArray();
			}else if(c == 'C'){
				stringReference.stringx = "12".ToCharArray();
			}else if(c == 'D'){
				stringReference.stringx = "13".ToCharArray();
			}else if(c == 'E'){
				stringReference.stringx = "14".ToCharArray();
			}else if(c == 'F'){
				stringReference.stringx = "15".ToCharArray();
			}else if(c == 'G'){
				stringReference.stringx = "16".ToCharArray();
			}else if(c == 'H'){
				stringReference.stringx = "17".ToCharArray();
			}else if(c == 'I'){
				stringReference.stringx = "18".ToCharArray();
			}else if(c == 'J'){
				stringReference.stringx = "19".ToCharArray();
			}else if(c == 'K'){
				stringReference.stringx = "20".ToCharArray();
			}else if(c == 'L'){
				stringReference.stringx = "21".ToCharArray();
			}else if(c == 'M'){
				stringReference.stringx = "22".ToCharArray();
			}else if(c == 'N'){
				stringReference.stringx = "23".ToCharArray();
			}else if(c == 'O'){
				stringReference.stringx = "24".ToCharArray();
			}else if(c == 'P'){
				stringReference.stringx = "25".ToCharArray();
			}else if(c == 'Q'){
				stringReference.stringx = "26".ToCharArray();
			}else if(c == 'R'){
				stringReference.stringx = "27".ToCharArray();
			}else if(c == 'S'){
				stringReference.stringx = "28".ToCharArray();
			}else if(c == 'T'){
				stringReference.stringx = "29".ToCharArray();
			}else if(c == 'U'){
				stringReference.stringx = "30".ToCharArray();
			}else if(c == 'V'){
				stringReference.stringx = "31".ToCharArray();
			}else if(c == 'W'){
				stringReference.stringx = "32".ToCharArray();
			}else if(c == 'X'){
				stringReference.stringx = "33".ToCharArray();
			}else if(c == 'Y'){
				stringReference.stringx = "34".ToCharArray();
			}else if(c == 'Z'){
				stringReference.stringx = "35".ToCharArray();
			}

			isValid = true;
		}else if(cIsNumber(c)){
			if(c == '0'){
				stringReference.stringx = "0".ToCharArray();
			}else if(c == '1'){
				stringReference.stringx = "1".ToCharArray();
			}else if(c == '2'){
				stringReference.stringx = "2".ToCharArray();
			}else if(c == '3'){
				stringReference.stringx = "3".ToCharArray();
			}else if(c == '4'){
				stringReference.stringx = "4".ToCharArray();
			}else if(c == '5'){
				stringReference.stringx = "5".ToCharArray();
			}else if(c == '6'){
				stringReference.stringx = "6".ToCharArray();
			}else if(c == '7'){
				stringReference.stringx = "7".ToCharArray();
			}else if(c == '8'){
				stringReference.stringx = "8".ToCharArray();
			}else if(c == '9'){
				stringReference.stringx = "9".ToCharArray();
			}

			isValid = true;
		}else{
			isValid = false;
			errorMessage.stringx = "Character is not an ISIN alpha-character.".ToCharArray();
		}

		return isValid;
	}


	public static RGBABitmapImage GenerateBarcodeEAN13(char [] code, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100;
		char c, type, character;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, group1Pattern, symbolWidths;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Roundx(heightInMm*pixelsPerMm);
		w = Roundx(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (11d + 3d + 7d*6d + 5d + 7d*6d + 7d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = Floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 11d*moduleWidthWholePixels;
		leftQuietZonePixels = 11d*moduleWidthPixels;
		group1x = leftQuietZonePixels + 3d*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*6d + 4d)*moduleWidthPixels;
		betweenCharatcers = charwidth*92d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		group1Pattern = GetEAN13Group1Pattern(code[0]);

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		for(i = 1d; i < code.Length; i = i + 1d){
			c = code[(int)(i)];
			if(i <= 6d){
				type = group1Pattern[(int)(i - 1d)];
				if(type == 'L'){
					widths = GetUPCLCodeWidths(c);
				}else{
					widths = GetUPCGCodeWidths(c);
				}
			}else{
				widths = GetUPCRCodeWidths(c);
			}
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);

			if(i == 6d){
				symbolWidths = GetUPCWidths(11d);
				DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);
			}
		}

		/* Checksum*/
		checksum = GetCalculateUPCChecksum(code);
		characterReference = new CharacterReference();
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10d, characterReference);
		character = characterReference.characterValue;
		delete(characterReference);
		symbolWidths = GetUPCRCodeWidths(character);
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels);

		/* Stop symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h);
		DrawImageOnImage(image, barcode, 0d, 0d);

		/* Draw digits*/
		for(i = 0d; i < code.Length; i = i + 1d){
			digit = GetNumberFromNumberCharacterForBase(code[(int)(i)], 10d);
			if(i == 0d){
				DrawDigitOnBarcode(image, 0d, textY, digit, pixelsPerMm, zoom);
			}else if(i <= 6d){
				DrawDigitOnBarcode(image, group1x + (i - 1d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}else{
				DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}


	public static char [] GetEAN13Group1Pattern(char code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == '0'){
			spaces = "LLLLLL".ToCharArray();
		}
		if(code == '1'){
			spaces = "LLGLGG".ToCharArray();
		}
		if(code == '2'){
			spaces = "LLGGLG".ToCharArray();
		}
		if(code == '3'){
			spaces = "LLGGGL".ToCharArray();
		}
		if(code == '4'){
			spaces = "LGLLGG".ToCharArray();
		}
		if(code == '5'){
			spaces = "LGGLLG".ToCharArray();
		}
		if(code == '6'){
			spaces = "LGGGLL".ToCharArray();
		}
		if(code == '7'){
			spaces = "LGLGLG".ToCharArray();
		}
		if(code == '8'){
			spaces = "LGLGGL".ToCharArray();
		}
		if(code == '9'){
			spaces = "LGGLGL".ToCharArray();
		}

		return spaces;
	}


	public static RGBABitmapImage GenerateBarcodeEAN8(char [] code, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100;
		char c, character;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, symbolWidths;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Roundx(heightInMm*pixelsPerMm);
		w = Roundx(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (3d + 3d + 7d*4d + 5d + 7d*4d + 3d + 3d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = Floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 3d*moduleWidthWholePixels;
		leftQuietZonePixels = 3d*moduleWidthPixels;
		group1x = leftQuietZonePixels + 3d*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*3d + 4d)*moduleWidthPixels;
		betweenCharatcers = charwidth*92d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		for(i = 0d; i < code.Length; i = i + 1d){
			c = code[(int)(i)];
			if(i <= 3d){
				widths = GetUPCLCodeWidths(c);
			}else{
				widths = GetUPCRCodeWidths(c);
			}
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);

			if(i == 3d){
				symbolWidths = GetUPCWidths(11d);
				DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);
			}
		}

		/* Checksum*/
		checksum = GetCalculateUPCChecksum(code);
		characterReference = new CharacterReference();
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10d, characterReference);
		character = characterReference.characterValue;
		delete(characterReference);
		symbolWidths = GetUPCRCodeWidths(character);
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels);

		/* Stop symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h);
		DrawImageOnImage(image, barcode, 0d, 0d);

		/* Draw digits*/
		for(i = 0d; i < code.Length; i = i + 1d){
			digit = GetNumberFromNumberCharacterForBase(code[(int)(i)], 10d);
			if(i <= 3d){
				DrawDigitOnBarcode(image, group1x + i*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}else{
				DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}


	public static RGBABitmapImage GenerateBarcodeUPCA(char [] code, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup;
		char c, character;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, symbolWidths;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Roundx(heightInMm*pixelsPerMm);
		w = Roundx(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (9d + 3d + 7d*6d + 5d + 7d*6d + 3d + 9d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = Floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 9d*moduleWidthWholePixels;
		leftQuietZonePixels = 9d*moduleWidthPixels;
		group1x = leftQuietZonePixels + (3d + 7d)*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*5d + 5d)*moduleWidthPixels;
		distanceToThirdGroup = distanceToSecondGroup + (7d*5d + 5d)*moduleWidthPixels;
		betweenCharatcers = charwidth*89d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		for(i = 0d; i < code.Length; i = i + 1d){
			c = code[(int)(i)];
			if(i <= 5d){
				widths = GetUPCLCodeWidths(c);
			}else{
				widths = GetUPCRCodeWidths(c);
			}

			if(i == 0d){
				DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, longHeight, counterReference, moduleWidthWholePixels);
			}else{
				DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);
			}

			if(i == 5d){
				symbolWidths = GetUPCWidths(11d);
				DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);
			}
		}

		/* Checksum*/
		checksum = GetCalculateUPCChecksum(code);
		characterReference = new CharacterReference();
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10d, characterReference);
		character = characterReference.characterValue;
		delete(characterReference);
		symbolWidths = GetUPCRCodeWidths(character);
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		/* Stop symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h);
		DrawImageOnImage(image, barcode, 0d, 0d);

		/* Draw digits*/
		for(i = 0d; i < code.Length; i = i + 1d){
			digit = GetNumberFromNumberCharacterForBase(code[(int)(i)], 10d);
			if(i == 0d){
				DrawDigitOnBarcode(image, 0d, textY, digit, pixelsPerMm, zoom);
			}else if(i <= 5d){
				DrawDigitOnBarcode(image, group1x + (i - 1d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}else{
				DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 6d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToThirdGroup + (i - 10d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}


	public static double GetCalculateUPCChecksum(char [] chars){
		double checksum, i, nextWeight, value, nearest10;
		bool next;
		char [] numberString;

		numberString = new char [1];

		checksum = 0d;
		next = true;
		nextWeight = 3d;

		for(i = chars.Length - 1d; i >= 0d; i = i - 1d){
			numberString[0] = chars[(int)(i)];
			value = CreateNumberFromDecimalString(numberString);
			checksum = checksum + value*nextWeight;

			if(next){
				nextWeight = 1d;
			}else{
				nextWeight = 3d;
			}
			next = !next;
		}

		nearest10 = Ceiling(checksum/10d)*10d;

		return nearest10 - checksum;
	}


	public static double GetUPCStartAndStopCode(){
		return 10d;
	}


	public static double GetEAN13Width(){
		return 95d + 11d;
	}


	public static char [] GetUPCWidths(double code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == 10d){
			spaces = "101".ToCharArray();
		}
		if(code == 11d){
			spaces = "01010".ToCharArray();
		}

		return spaces;
	}


	public static void DrawBarcodeUPCSymbol(RGBABitmapImage image, char [] widths, double h, NumberReference counterReference, double moduleWidthPixels){
		double i, j;
		char widthCharacter;
		RGBA color;

		for(i = 0d; i < widths.Length; i = i + 1d){
			widthCharacter = widths[(int)(i)];
			if(widthCharacter == '1'){
				color = GetBlack();
			}else{
				color = GetWhite();
			}

			for(j = 0d; j < moduleWidthPixels; j = j + 1d){
				DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, color);
				counterReference.numberValue = counterReference.numberValue + 1d;
			}
		}
	}


	public static char [] GetUPCLCodeWidths(char code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == '0'){
			spaces = "0001101".ToCharArray();
		}
		if(code == '1'){
			spaces = "0011001".ToCharArray();
		}
		if(code == '2'){
			spaces = "0010011".ToCharArray();
		}
		if(code == '3'){
			spaces = "0111101".ToCharArray();
		}
		if(code == '4'){
			spaces = "0100011".ToCharArray();
		}
		if(code == '5'){
			spaces = "0110001".ToCharArray();
		}
		if(code == '6'){
			spaces = "0101111".ToCharArray();
		}
		if(code == '7'){
			spaces = "0111011".ToCharArray();
		}
		if(code == '8'){
			spaces = "0110111".ToCharArray();
		}
		if(code == '9'){
			spaces = "0001011".ToCharArray();
		}

		return spaces;
	}


	public static char [] GetUPCGCodeWidths(char code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == '0'){
			spaces = "0100111".ToCharArray();
		}
		if(code == '1'){
			spaces = "0110011".ToCharArray();
		}
		if(code == '2'){
			spaces = "0011011".ToCharArray();
		}
		if(code == '3'){
			spaces = "0100001".ToCharArray();
		}
		if(code == '4'){
			spaces = "0011101".ToCharArray();
		}
		if(code == '5'){
			spaces = "0111001".ToCharArray();
		}
		if(code == '6'){
			spaces = "0000101".ToCharArray();
		}
		if(code == '7'){
			spaces = "0010001".ToCharArray();
		}
		if(code == '8'){
			spaces = "0001001".ToCharArray();
		}
		if(code == '9'){
			spaces = "0010111".ToCharArray();
		}
		return spaces;
	}


	public static char [] GetUPCRCodeWidths(char code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == '0'){
			spaces = "1110010".ToCharArray();
		}
		if(code == '1'){
			spaces = "1100110".ToCharArray();
		}
		if(code == '2'){
			spaces = "1101100".ToCharArray();
		}
		if(code == '3'){
			spaces = "1000010".ToCharArray();
		}
		if(code == '4'){
			spaces = "1011100".ToCharArray();
		}
		if(code == '5'){
			spaces = "1001110".ToCharArray();
		}
		if(code == '6'){
			spaces = "1010000".ToCharArray();
		}
		if(code == '7'){
			spaces = "1000100".ToCharArray();
		}
		if(code == '8'){
			spaces = "1001000".ToCharArray();
		}
		if(code == '9'){
			spaces = "1110100".ToCharArray();
		}

		return spaces;
	}


	public static void DrawDigitOnBarcode(RGBABitmapImage image, double topx, double topy, double digit, double pixelsPerMm, double zoom){
		RGBABitmapImage digitImage, scaled;

		digitImage = CreateImage(30d, 37d, GetWhite());
		DrawDigitCharacter(digitImage, 0d, 0d, digit);
		scaled = BilinaerScaleUpFactor(digitImage, pixelsPerMm*zoom/DPIToDotsPerMm(300d));
		DrawImageOnImage(image, scaled, Floor(topx), Floor(topy));
		delete(digitImage);
		delete(scaled);
	}


	public static char [] UPCAToUPCE(char [] a){
		char [] mfg, productCode, e;

		e = new char [7];
		e[0] = a[0];

		mfg = strSubstring(a, 1d, 6d);
		productCode = strSubstring(a, 6d, 11d);

		e[1] = mfg[0];
		e[2] = mfg[1];
		if((strSubstringEquals(mfg, 2d, "000".ToCharArray()) || strSubstringEquals(mfg, 2d, "100".ToCharArray()) || strSubstringEquals(mfg, 2d, "200".ToCharArray())) && productCode[0] == '0' && productCode[1] == '0'){
			e[3] = productCode[2];
			e[4] = productCode[3];
			e[5] = productCode[4];
			e[6] = mfg[2];
		}else if(strSubstringEquals(mfg, 3d, "00".ToCharArray()) && productCode[0] == '0' && productCode[1] == '0' && productCode[2] == '0'){
			e[3] = mfg[2];
			e[4] = productCode[3];
			e[5] = productCode[4];
			e[6] = '3';
		}else if(strSubstringEquals(mfg, 4d, "0".ToCharArray()) && productCode[0] == '0' && productCode[1] == '0' && productCode[2] == '0' && productCode[3] == '0'){
			e[3] = mfg[2];
			e[4] = mfg[3];
			e[5] = productCode[4];
			e[6] = '4';
		}else if(arraysStringsEqual(productCode, "00005".ToCharArray()) || arraysStringsEqual(productCode, "00006".ToCharArray()) || arraysStringsEqual(productCode, "00006".ToCharArray()) || arraysStringsEqual(productCode, "00007".ToCharArray()) || arraysStringsEqual(productCode, "00008".ToCharArray()) || arraysStringsEqual(productCode, "00009".ToCharArray())){
			e[3] = mfg[2];
			e[4] = mfg[3];
			e[5] = mfg[4];
			e[6] = productCode[4];
		}

		return e;
	}


	public static char [] UPCEToUPCA(char [] e){
		char [] a;

		a = new char [11];

		a[0] = e[0];

		if(e[6] == '0' || e[6] == '1' || e[6] == '2'){
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[6];
			a[4] = '0';
			a[5] = '0';
			a[6] = '0';
			a[7] = '0';
			a[8] = e[3];
			a[9] = e[4];
			a[10] = e[5];
		}else if(e[6] == '3'){
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[3];
			a[4] = '0';
			a[5] = '0';
			a[6] = '0';
			a[7] = '0';
			a[8] = '0';
			a[9] = e[4];
			a[10] = e[5];
		}else if(e[6] == '4'){
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[3];
			a[4] = e[4];
			a[5] = '0';
			a[6] = '0';
			a[7] = '0';
			a[8] = '0';
			a[9] = '0';
			a[10] = e[5];
		}else{
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[3];
			a[4] = e[4];
			a[5] = e[5];
			a[6] = '0';
			a[7] = '0';
			a[8] = '0';
			a[9] = '0';
			a[10] = e[6];
		}

		return a;
	}


	public static RGBABitmapImage GenerateBarcodeUPCE(char [] e, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup;
		char c, character, type;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, symbolWidths, a, pattern;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Roundx(heightInMm*pixelsPerMm);
		w = Roundx(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (9d + 3d + 7d*6d + 5d + 7d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = Floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 9d*moduleWidthWholePixels;
		leftQuietZonePixels = 9d*moduleWidthPixels;
		group1x = leftQuietZonePixels + (3d + 1d)*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*6d + 5d)*moduleWidthPixels;
		betweenCharatcers = charwidth*89d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		/* Checksum*/
		a = UPCEToUPCA(e);
		checksum = GetCalculateUPCChecksum(a);
		characterReference = new CharacterReference();
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10d, characterReference);
		character = characterReference.characterValue;

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		pattern = GetUPCEPattern(character, e[0]);

		for(i = 1d; i < e.Length; i = i + 1d){
			c = e[(int)(i)];
			type = pattern[(int)(i - 1d)];
			if(type == 'O'){
				widths = GetUPCLCodeWidths(c);
			}else{
				widths = GetUPCGCodeWidths(c);
			}

			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);
		}

		/* Stop symbol*/
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, "010101".ToCharArray(), longHeight, counterReference, moduleWidthWholePixels);

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h);
		DrawImageOnImage(image, barcode, 0d, 0d);

		/* Draw digits*/
		for(i = 0d; i < e.Length; i = i + 1d){
			digit = GetNumberFromNumberCharacterForBase(e[(int)(i)], 10d);
			if(i == 0d){
				DrawDigitOnBarcode(image, 0d, textY, digit, pixelsPerMm, zoom);
			}else if(i <= 6d){
				DrawDigitOnBarcode(image, group1x + (i - 1d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}


	public static char [] GetUPCEPattern(char check, char system){
		char [] spaces;

		spaces = "".ToCharArray();

		if(system == '0'){
			if(check == '0'){
				spaces = "EEEOOO".ToCharArray();
			}
			if(check == '1'){
				spaces = "EEOEOO".ToCharArray();
			}
			if(check == '2'){
				spaces = "EEOOEO".ToCharArray();
			}
			if(check == '3'){
				spaces = "EEOOOE".ToCharArray();
			}
			if(check == '4'){
				spaces = "EOEEOO".ToCharArray();
			}
			if(check == '5'){
				spaces = "EOOEEO".ToCharArray();
			}
			if(check == '6'){
				spaces = "EOOOEE".ToCharArray();
			}
			if(check == '7'){
				spaces = "EOEOEO".ToCharArray();
			}
			if(check == '8'){
				spaces = "EOEOOE".ToCharArray();
			}
			if(check == '9'){
				spaces = "EOOEOE".ToCharArray();
			}
		}else if(system == '1'){
			if(check == '0'){
				spaces = "OOOEEE".ToCharArray();
			}
			if(check == '1'){
				spaces = "OOEOEE".ToCharArray();
			}
			if(check == '2'){
				spaces = "OOEEOE".ToCharArray();
			}
			if(check == '3'){
				spaces = "OOEEEO".ToCharArray();
			}
			if(check == '4'){
				spaces = "OEOOEE".ToCharArray();
			}
			if(check == '5'){
				spaces = "OEEOOE".ToCharArray();
			}
			if(check == '6'){
				spaces = "OEEEOO".ToCharArray();
			}
			if(check == '7'){
				spaces = "OEOEOE".ToCharArray();
			}
			if(check == '8'){
				spaces = "OEOEEO".ToCharArray();
			}
			if(check == '9'){
				spaces = "OEEOEO".ToCharArray();
			}
		}

		return spaces;
	}


	public static char [] Code128EncodingParts(char [] cs){
		char [] parts;
		double i;
		char c;

		parts = new char [(int)(cs.Length)];

		for(i = 0d; i < cs.Length; i = i + 1d){
			c = cs[(int)(i)];

			if(IsCodeA(c) && IsCodeB(c) && IsCodeC(c)){
				parts[(int)(i)] = 'X';
			}else if(IsCodeA(c) && IsCodeB(c)){
				parts[(int)(i)] = 'D';
			}else if(IsCodeA(c)){
				parts[(int)(i)] = 'A';
			}else if(IsCodeB(c)){
				parts[(int)(i)] = 'B';
			}
		}

		return parts;
	}


	public static bool IsCodeA(char c){
		return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || charIsCode128ASymbol(c);
	}


	public static bool IsCodeB(char c){
		return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || cIsLowerCase(c) || charIsCode128BSymbol(c);
	}


	public static bool IsCodeC(char c){
		return cIsNumber(c);
	}


	public static Sections Code128EncodingSections(char [] cs){
		char [] sections, parts, currentSections;
		double i, c, next, sum;
		char p, selected;
		bool done;
		Sections sectionsStruct;
		double [] counts, currentCounts;

		parts = Code128EncodingParts(cs);

		sections = arraysCreateString(cs.Length, ' ');
		counts = arraysCreateNumberArray(cs.Length, 0d);
		next = 0d;

		/* Pick C-sections.*/
		for(i = 0d; i < cs.Length; i = i + 1d){
			p = parts[(int)(i)];

			if(p == 'X'){
				done = false;
				for(c = 0d; i + c < cs.Length && !done; c = c + 1d){
					if(parts[(int)(i + c)] != 'X'){
						done = true;
						c = c - 1d;
					}
				}
				/* Compress 2 or more if first, or 4 or more if not.*/
				if(c >= 4d || (i == 0d && c >= 2d)){
					sections[(int)(next)] = 'C';
					c = Floor(c/2d)*2d;
					counts[(int)(next)] = c;
					next = next + 1d;
					i = i + c - 1d;
				}else{
					sections[(int)(next)] = 'D';
					counts[(int)(next)] = 1d;
					next = next + 1d;
				}
			}else{
				sections[(int)(next)] = p;
				counts[(int)(next)] = 1d;
				next = next + 1d;
			}
		}

		/* Trim*/
		currentSections = new char [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentSections[(int)(i)] = sections[(int)(i)];
		}

		currentCounts = new double [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentCounts[(int)(i)] = counts[(int)(i)];
		}

		sections = arraysCreateString(cs.Length, ' ');
		counts = arraysCreateNumberArray(cs.Length, 0d);

		/* Compress A+A&D and B+B&D*/
		next = 0d;
		for(i = 0d; i < currentSections.Length; i = i + 1d){
			p = currentSections[(int)(i)];

			if(p == 'C' || p == 'D'){
				sections[(int)(next)] = p;
				counts[(int)(next)] = currentCounts[(int)(i)];
				next = next + 1d;
			}else if(p == 'A'){
				sum = 0d;
				done = false;
				for(c = 0d; i + c < currentSections.Length && !done; c = c + 1d){
					if(currentSections[(int)(i + c)] == 'A' || currentSections[(int)(i + c)] == 'D'){
						sum = sum + currentCounts[(int)(i + c)];
					}else{
						done = true;
						c = c - 1d;
					}
				}
				sections[(int)(next)] = p;
				counts[(int)(next)] = sum;
				next = next + 1d;
				i = i + c - 1d;
			}else if(p == 'B'){
				sum = 0d;
				done = false;
				for(c = 0d; i + c < currentSections.Length && !done; c = c + 1d){
					if(currentSections[(int)(i + c)] == 'B' || currentSections[(int)(i + c)] == 'D'){
						sum = sum + currentCounts[(int)(i + c)];
					}else{
						done = true;
						c = c - 1d;
					}
				}
				sections[(int)(next)] = p;
				counts[(int)(next)] = sum;
				next = next + 1d;
				i = i + c - 1d;
			}
		}

		/* Trim*/
		currentSections = new char [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentSections[(int)(i)] = sections[(int)(i)];
		}

		currentCounts = new double [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentCounts[(int)(i)] = counts[(int)(i)];
		}

		sections = arraysCreateString(cs.Length, ' ');
		counts = arraysCreateNumberArray(cs.Length, 0d);

		/* Compress D+A&D and D+B&D*/
		next = 0d;
		for(i = 0d; i < currentSections.Length; i = i + 1d){
			p = currentSections[(int)(i)];

			sum = 0d;

			if(p == 'C' || p == 'A' || p == 'B'){
				sections[(int)(next)] = p;
				counts[(int)(next)] = currentCounts[(int)(i)];
				next = next + 1d;
			}else if(p == 'D'){
				selected = ' ';
				done = false;

				sum = 0d;
				for(c = 0d; i + c < currentSections.Length && !done; c = c + 1d){
					p = currentSections[(int)(i + c)];

					if(p == 'D'){
						sum = sum + currentCounts[(int)(i + c)];
					}else if(p == 'A' || p == 'B'){
						if(selected == ' '){
							selected = p;
							sum = sum + currentCounts[(int)(i + c)];
						}else if(p != selected){
							done = true;
							c = c - 1d;
						}else{
							sum = sum + currentCounts[(int)(i + c)];
						}
					}else{
						done = true;
						c = c - 1d;
					}
				}
				if(selected == ' '){
					selected = 'A';
				}
				sections[(int)(next)] = selected;
				counts[(int)(next)] = sum;
				next = next + 1d;
				i = i + c - 1d;
			}
		}

		/* Trim*/
		currentSections = new char [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentSections[(int)(i)] = sections[(int)(i)];
		}
		sections = currentSections;

		currentCounts = new double [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentCounts[(int)(i)] = counts[(int)(i)];
		}
		counts = currentCounts;

		/* Done*/
		sectionsStruct = new Sections();
		sectionsStruct.codes = sections;
		sectionsStruct.counts = counts;

		return sectionsStruct;
	}


	public static double [] Code128Encode(char [] cs){
		double [] coded, nextCoded;
		bool isFirst;
		double n, k, next, cnr, count;
		char section, lastSection;
		Sections sections;

		coded = new double [(int)(cs.Length + 2d + 1d + 1d + 10d)];
		cnr = 0d;
		isFirst = true;
		next = 0d;

		lastSection = '0';

		sections = Code128EncodingSections(cs);

		for(n = 0d; n < sections.codes.Length; n = n + 1d){
			section = sections.codes[(int)(n)];
			count = sections.counts[(int)(n)];

			/* start code*/
			if(isFirst){
				if(section == 'A'){
					coded[(int)(next)] = 103d;
				}else if(section == 'B'){
					coded[(int)(next)] = 104d;
				}else if(section == 'C'){
					coded[(int)(next)] = 105d;
				}
				next = next + 1d;

				isFirst = false;
			}

			/* Encode*/
			if(section == 'A'){
				if(lastSection == 'B' || lastSection == 'C'){
					coded[(int)(next)] = 101d;
					next = next + 1d;
				}

				for(k = 0d; k < count; k = k + 1d){
					coded[(int)(next)] = GetCode128ACode(cs[(int)(cnr + k)]);
					next = next + 1d;
				}
				cnr = cnr + count;
			}else if(section == 'B'){
				if(lastSection == 'A' || lastSection == 'C'){
					coded[(int)(next)] = 100d;
					next = next + 1d;
				}

				for(k = 0d; k < count; k = k + 1d){
					coded[(int)(next)] = GetCode128BCode(cs[(int)(cnr + k)]);
					next = next + 1d;
				}
				cnr = cnr + count;
			}else if(section == 'C'){
				if(lastSection == 'A' || lastSection == 'B'){
					coded[(int)(next)] = 99d;
					next = next + 1d;
				}

				for(k = 0d; k < count; k = k + 2d){
					coded[(int)(next)] = GetCode128CCode(cs[(int)(cnr + k)], cs[(int)(cnr + k + 1d)]);
					next = next + 1d;
				}
				cnr = cnr + count;
			}

			lastSection = section;
		}

		coded[(int)(next)] = CalculateCode128ChecksumWithLength(coded, next);
		next = next + 1d;

		coded[(int)(next)] = 108d;
		next = next + 1d;

		/* trim array*/
		nextCoded = new double [(int)(next)];
		for(k = 0d; k < next; k = k + 1d){
			nextCoded[(int)(k)] = coded[(int)(k)];
		}
		delete(coded);
		coded = nextCoded;

		return coded;
	}


	public static double GetCode128ACode(char c){
		double code, n;

		n = c;

		if(n >= 32d && n <= 95d){
			code = n - 32d;
		}else if(n >= 0d && n <= 31d){
			code = 64d + n;
		}else{
			code = -1d;
		}

		return code;
	}


	public static double GetCode128BCode(char c){
		double code, n;

		n = c;

		if(n >= 32d && n <= 126d){
			code = n - 32d;
		}else if(n == 127d){
			code = 95d;
		}else{
			code = -1d;
		}

		return code;
	}


	public static double GetCode128CCode(char c1, char c2){
		double n1, n2;

		n1 = GetNumberFromNumberCharacterForBase(c1, 10d);
		n2 = GetNumberFromNumberCharacterForBase(c2, 10d);

		return n1*10d + n2;
	}


	public static bool charIsCode128AandBSymbol(char character){
		bool common;

		common = false;
		if(character == ' '){
			common = true;
		}else if(character == '!'){
			common = true;
		}else if(character == '\"'){
			common = true;
		}else if(character == '#'){
			common = true;
		}else if(character == '$'){
			common = true;
		}else if(character == '%'){
			common = true;
		}else if(character == '&'){
			common = true;
		}else if(character == '\''){
			common = true;
		}else if(character == '('){
			common = true;
		}else if(character == ')'){
			common = true;
		}else if(character == '*'){
			common = true;
		}else if(character == '+'){
			common = true;
		}else if(character == ','){
			common = true;
		}else if(character == '-'){
			common = true;
		}else if(character == '.'){
			common = true;
		}else if(character == '/'){
			common = true;
		}else if(character == ':'){
			common = true;
		}else if(character == ';'){
			common = true;
		}else if(character == '<'){
			common = true;
		}else if(character == '='){
			common = true;
		}else if(character == '>'){
			common = true;
		}else if(character == '?'){
			common = true;
		}else if(character == '@'){
			common = true;
		}else if(character == '['){
			common = true;
		}else if(character == '\\'){
			common = true;
		}else if(character == ']'){
			common = true;
		}else if(character == '^'){
			common = true;
		}else if(character == '_'){
			common = true;
		}

		return common;
	}


	public static bool charIsCode128BSymbol(char character){
		bool codeB;

		codeB = false;
		if(character == '`'){
			codeB = true;
		}else if(character == '{'){
			codeB = true;
		}else if(character == '|'){
			codeB = true;
		}else if(character == '}'){
			codeB = true;
		}else if(character == '~'){
			codeB = true;
		}else if(character == 127d){
			/* del*/
			codeB = true;
		}

		return codeB;
	}


	public static bool charIsCode128ASymbol(char character){
		bool codeA;
		double n;

		n = character;

		codeA = false;
		if(n >= 0d && n <= 31d){
			codeA = true;
		}

		return codeA;
	}


	public static RGBABitmapImage GenerateBarcodeCode128(char [] chars, double height){
		RGBABitmapImage image;
		bool success;
		StringReference errorMessages;

		image = new RGBABitmapImage();
		errorMessages = CreateStringReference("".ToCharArray());

		success = GenerateBarcodeCode128AllParams(chars, height, 2d, image, errorMessages);

		delete(errorMessages);

		return image;
	}


	public static bool GenerateBarcodeCode128AllParams(char [] chars, double height, double moduleWidth, RGBABitmapImage image, StringReference errorMessages){
		double w, h, i, code;
		NumberReference counterReference;
		double [] codes;
		bool success;
		RGBABitmapImage newImage;

		success = IsValidCode128Data(chars, height, moduleWidth, errorMessages);

		if(success){
			codes = Code128Encode(chars);

			h = height;
			w = CalculateCode128Width(codes, moduleWidth);

			newImage = CreateImage(w, h, GetWhite());
			image.x = newImage.x;
			delete(newImage);

			counterReference = new NumberReference();

			/* Start Quiet Zone*/
			counterReference.numberValue = 10d*moduleWidth;

			for(i = 0d; i < codes.Length; i = i + 1d){
				code = codes[(int)(i)];
				DrawBarcodeSymbol(image, code, h, moduleWidth, counterReference);
			}

			/* End Quiet Zone*/
			counterReference.numberValue = counterReference.numberValue + 10d*moduleWidth;
		}

		return success;
	}


	public static bool IsValidCode128Data(char [] chars, double height, double moduleWidth, StringReference errorMessages){
		double validCharacters, i;
		bool valid;

		validCharacters = 0d;

		for(i = 0d; i < chars.Length; i = i + 1d){
			if(chars[(int)(i)] >= 0d && chars[(int)(i)] <= 127d){
				validCharacters = validCharacters + 1d;
			}
		}

		if(validCharacters == chars.Length){

			if(height > 0d){
				if(Truncate(height) == height){
					if(moduleWidth > 0d){
						if(Truncate(moduleWidth) == moduleWidth){
							valid = true;
						}else{
							valid = false;
							errorMessages.stringx = strAppendString(errorMessages.stringx, "Module width must be a whole number of pixels.".ToCharArray());
						}
					}else{
						valid = false;
						errorMessages.stringx = strAppendString(errorMessages.stringx, "Module width must be at least one pixel.".ToCharArray());
					}
				}else{
					valid = false;
					errorMessages.stringx = strAppendString(errorMessages.stringx, "Height must be a whole number of pixels.".ToCharArray());
				}
			}else{
				valid = false;
				errorMessages.stringx = strAppendString(errorMessages.stringx, "Height must be at least one pixel.".ToCharArray());
			}
		}else{
			valid = false;
			errorMessages.stringx = strAppendString(errorMessages.stringx, "Input data contains character invalid for this implementation of Code 128. Only 0-127 (inclusive) supported in this implementation.".ToCharArray());
		}

		return valid;
	}


	public static double CalculateCode128Width(double [] codes, double moduleWidth){
		double width;

		/* Quiet Zone + 11 * codes + stop symbol extra + Quiet Zone.*/
		width = (10d + codes.Length*11d + 2d + 10d)*moduleWidth;

		return width;
	}


	public static double CalculateCode128Checksum(double [] codes){
		return CalculateCode128ChecksumWithLength(codes, codes.Length);
	}


	public static double CalculateCode128ChecksumWithLength(double [] codes, double length){
		double checksum, i, position, value;

		checksum = 0d;

		position = 1d;
		for(i = 0d; i < length; i = i + 1d){
			if(i > 1d){
				position = position + 1d;
			}
			value = codes[(int)(i)];
			checksum = checksum + position*value;
		}

		return checksum%103d;
	}


	public static void DrawBarcodeSymbol(RGBABitmapImage image, double barcodeNr, double h, double moduleWidth, NumberReference counterReference){
		double i, j, k, width;
		char widthCharacter;
		char [] widths;
		bool next;
		RGBA nextColor;

		widths = GetCode128Widths(barcodeNr);

		nextColor = GetBlack();
		next = true;

		for(i = 0d; i < widths.Length; i = i + 1d){
			widthCharacter = widths[(int)(i)];
			width = GetNumberFromNumberCharacterForBase(widthCharacter, 10d);

			for(j = 0d; j < width; j = j + 1d){
				for(k = 0d; k < moduleWidth; k = k + 1d){
					DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, nextColor);
					counterReference.numberValue = counterReference.numberValue + 1d;
				}
			}

			if(next){
				nextColor = GetWhite();
			}else{
				nextColor = GetBlack();
			}
			next = !next;
		}
	}


	public static char [] GetCode128Widths(double code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == 0d){
			spaces = "212222".ToCharArray();
		}
		if(code == 1d){
			spaces = "222122".ToCharArray();
		}
		if(code == 2d){
			spaces = "222221".ToCharArray();
		}
		if(code == 3d){
			spaces = "121223".ToCharArray();
		}
		if(code == 4d){
			spaces = "121322".ToCharArray();
		}
		if(code == 5d){
			spaces = "131222".ToCharArray();
		}
		if(code == 6d){
			spaces = "122213".ToCharArray();
		}
		if(code == 7d){
			spaces = "122312".ToCharArray();
		}
		if(code == 8d){
			spaces = "132212".ToCharArray();
		}
		if(code == 9d){
			spaces = "221213".ToCharArray();
		}
		if(code == 10d){
			spaces = "221312".ToCharArray();
		}
		if(code == 11d){
			spaces = "231212".ToCharArray();
		}
		if(code == 12d){
			spaces = "112232".ToCharArray();
		}
		if(code == 13d){
			spaces = "122132".ToCharArray();
		}
		if(code == 14d){
			spaces = "122231".ToCharArray();
		}
		if(code == 15d){
			spaces = "113222".ToCharArray();
		}
		if(code == 16d){
			spaces = "123122".ToCharArray();
		}
		if(code == 17d){
			spaces = "123221".ToCharArray();
		}
		if(code == 18d){
			spaces = "223211".ToCharArray();
		}
		if(code == 19d){
			spaces = "221132".ToCharArray();
		}
		if(code == 20d){
			spaces = "221231".ToCharArray();
		}
		if(code == 21d){
			spaces = "213212".ToCharArray();
		}
		if(code == 22d){
			spaces = "223112".ToCharArray();
		}
		if(code == 23d){
			spaces = "312131".ToCharArray();
		}
		if(code == 24d){
			spaces = "311222".ToCharArray();
		}
		if(code == 25d){
			spaces = "321122".ToCharArray();
		}
		if(code == 26d){
			spaces = "321221".ToCharArray();
		}
		if(code == 27d){
			spaces = "312212".ToCharArray();
		}
		if(code == 28d){
			spaces = "322112".ToCharArray();
		}
		if(code == 29d){
			spaces = "322211".ToCharArray();
		}
		if(code == 30d){
			spaces = "212123".ToCharArray();
		}
		if(code == 31d){
			spaces = "212321".ToCharArray();
		}
		if(code == 32d){
			spaces = "232121".ToCharArray();
		}
		if(code == 33d){
			spaces = "111323".ToCharArray();
		}
		if(code == 34d){
			spaces = "131123".ToCharArray();
		}
		if(code == 35d){
			spaces = "131321".ToCharArray();
		}
		if(code == 36d){
			spaces = "112313".ToCharArray();
		}
		if(code == 37d){
			spaces = "132113".ToCharArray();
		}
		if(code == 38d){
			spaces = "132311".ToCharArray();
		}
		if(code == 39d){
			spaces = "211313".ToCharArray();
		}
		if(code == 40d){
			spaces = "231113".ToCharArray();
		}
		if(code == 41d){
			spaces = "231311".ToCharArray();
		}
		if(code == 42d){
			spaces = "112133".ToCharArray();
		}
		if(code == 43d){
			spaces = "112331".ToCharArray();
		}
		if(code == 44d){
			spaces = "132131".ToCharArray();
		}
		if(code == 45d){
			spaces = "113123".ToCharArray();
		}
		if(code == 46d){
			spaces = "113321".ToCharArray();
		}
		if(code == 47d){
			spaces = "133121".ToCharArray();
		}
		if(code == 48d){
			spaces = "313121".ToCharArray();
		}
		if(code == 49d){
			spaces = "211331".ToCharArray();
		}
		if(code == 50d){
			spaces = "231131".ToCharArray();
		}
		if(code == 51d){
			spaces = "213113".ToCharArray();
		}
		if(code == 52d){
			spaces = "213311".ToCharArray();
		}
		if(code == 53d){
			spaces = "213131".ToCharArray();
		}
		if(code == 54d){
			spaces = "311123".ToCharArray();
		}
		if(code == 55d){
			spaces = "311321".ToCharArray();
		}
		if(code == 56d){
			spaces = "331121".ToCharArray();
		}
		if(code == 57d){
			spaces = "312113".ToCharArray();
		}
		if(code == 58d){
			spaces = "312311".ToCharArray();
		}
		if(code == 59d){
			spaces = "332111".ToCharArray();
		}
		if(code == 60d){
			spaces = "314111".ToCharArray();
		}
		if(code == 61d){
			spaces = "221411".ToCharArray();
		}
		if(code == 62d){
			spaces = "431111".ToCharArray();
		}
		if(code == 63d){
			spaces = "111224".ToCharArray();
		}
		if(code == 64d){
			spaces = "111422".ToCharArray();
		}
		if(code == 65d){
			spaces = "121124".ToCharArray();
		}
		if(code == 66d){
			spaces = "121421".ToCharArray();
		}
		if(code == 67d){
			spaces = "141122".ToCharArray();
		}
		if(code == 68d){
			spaces = "141221".ToCharArray();
		}
		if(code == 69d){
			spaces = "112214".ToCharArray();
		}
		if(code == 70d){
			spaces = "112412".ToCharArray();
		}
		if(code == 71d){
			spaces = "122114".ToCharArray();
		}
		if(code == 72d){
			spaces = "122411".ToCharArray();
		}
		if(code == 73d){
			spaces = "142112".ToCharArray();
		}
		if(code == 74d){
			spaces = "142211".ToCharArray();
		}
		if(code == 75d){
			spaces = "241211".ToCharArray();
		}
		if(code == 76d){
			spaces = "221114".ToCharArray();
		}
		if(code == 77d){
			spaces = "413111".ToCharArray();
		}
		if(code == 78d){
			spaces = "241112".ToCharArray();
		}
		if(code == 79d){
			spaces = "134111".ToCharArray();
		}
		if(code == 80d){
			spaces = "111242".ToCharArray();
		}
		if(code == 81d){
			spaces = "121142".ToCharArray();
		}
		if(code == 82d){
			spaces = "121241".ToCharArray();
		}
		if(code == 83d){
			spaces = "114212".ToCharArray();
		}
		if(code == 84d){
			spaces = "124112".ToCharArray();
		}
		if(code == 85d){
			spaces = "124211".ToCharArray();
		}
		if(code == 86d){
			spaces = "411212".ToCharArray();
		}
		if(code == 87d){
			spaces = "421112".ToCharArray();
		}
		if(code == 88d){
			spaces = "421211".ToCharArray();
		}
		if(code == 89d){
			spaces = "212141".ToCharArray();
		}
		if(code == 90d){
			spaces = "214121".ToCharArray();
		}
		if(code == 91d){
			spaces = "412121".ToCharArray();
		}
		if(code == 92d){
			spaces = "111143".ToCharArray();
		}
		if(code == 93d){
			spaces = "111341".ToCharArray();
		}
		if(code == 94d){
			spaces = "131141".ToCharArray();
		}
		if(code == 95d){
			spaces = "114113".ToCharArray();
		}
		if(code == 96d){
			spaces = "114311".ToCharArray();
		}
		if(code == 97d){
			spaces = "411113".ToCharArray();
		}
		if(code == 98d){
			spaces = "411311".ToCharArray();
		}
		if(code == 99d){
			spaces = "113141".ToCharArray();
		}
		if(code == 100d){
			spaces = "114131".ToCharArray();
		}
		if(code == 101d){
			spaces = "311141".ToCharArray();
		}
		if(code == 102d){
			spaces = "411131".ToCharArray();
		}
		if(code == 103d){
			spaces = "211412".ToCharArray();
		}
		if(code == 104d){
			spaces = "211214".ToCharArray();
		}
		if(code == 105d){
			spaces = "211232".ToCharArray();
		}
		if(code == 106d){
			spaces = "233111".ToCharArray();
		}
		if(code == 107d){
			spaces = "211133".ToCharArray();
		}
		if(code == 108d){
			spaces = "2331112".ToCharArray();
		}

		return spaces;
	}


	public static RGBABitmapImage GenerateBarcodeCode39(char [] chars, double height){
		return GenerateBarcodeCode39WithChecksumOption(chars, height, false);
	}


	public static RGBABitmapImage GenerateBarcodeCode39WithChecksumOption(char [] chars, double height, bool includeChecksum){
		double w, h, i, barcodeNr, checksum;
		char c;
		NumberReference counterReference;
		RGBABitmapImage image;

		h = height;
		w = CalculateCode39Width(chars, includeChecksum)*2d;

		image = CreateImage(w, h, GetWhite());

		counterReference = CreateNumberReference(10d*2d);

		/* Start symbol*/
		DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, true);

		for(i = 0d; i < chars.Length; i = i + 1d){
			c = chars[(int)(i)];
			barcodeNr = AsciiToCode39(c);
			DrawBarcode39Symbol(image, barcodeNr, h, counterReference, true);
		}

		if(includeChecksum){
			checksum = CalculateCode39Checksum(chars);
			DrawBarcode39Symbol(image, checksum, h, counterReference, true);
		}

		/* Stop symbol*/
		DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, false);

		return image;
	}


	public static double CalculateCode39Checksum(char [] chars){
		double checksum, i, value;
		char c;

		checksum = 0d;

		for(i = 0d; i < chars.Length; i = i + 1d){
			c = chars[(int)(i)];
			value = AsciiToCode39(c);
			checksum = checksum + value;
		}

		return checksum%43d;
	}


	public static double Get39StartAndStopCode(){
		return 43d;
	}


	public static double CalculateCode39Width(char [] chars, bool includeChecksum){
		double width;

		/* quiet zone + start + 1 + 12*characters + 1*characters + stop + quiet zone*/
		width = 10d + 12d + 1d + chars.Length*12d + chars.Length*1d + 12d + 10d;

		if(includeChecksum){
			width = width + 1d + 12d;
		}

		return width;
	}


	public static void DrawBarcode39Symbol(RGBABitmapImage image, double barcodeNr, double h, NumberReference counterReference, bool addSeparator){
		double j, k, width;
		char widthCharacter;
		char [] widths;
		bool next;
		RGBA nextColor;

		widths = GetCode39Widths(barcodeNr);

		nextColor = GetBlack();
		next = true;

		for(j = 0d; j < widths.Length; j = j + 1d){
			widthCharacter = widths[(int)(j)];
			width = GetNumberFromNumberCharacterForBase(widthCharacter, 10d);

			for(k = 0d; k < width; k = k + 1d){
				DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, nextColor);
				counterReference.numberValue = counterReference.numberValue + 1d;
				DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, nextColor);
				counterReference.numberValue = counterReference.numberValue + 1d;
			}

			if(next){
				nextColor = GetWhite();
			}else{
				nextColor = GetBlack();
			}
			next = !next;
		}

		/* Space*/
		if(addSeparator){
			DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, GetWhite());
			counterReference.numberValue = counterReference.numberValue + 1d;
			DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, GetWhite());
			counterReference.numberValue = counterReference.numberValue + 1d;
		}
	}


	public static char [] GetCode39Widths(double code){
		char [] spaces;

		spaces = "".ToCharArray();

		if(code == 0d){
			spaces = "111221211".ToCharArray();
		}
		if(code == 1d){
			spaces = "211211112".ToCharArray();
		}
		if(code == 2d){
			spaces = "112211112".ToCharArray();
		}
		if(code == 3d){
			spaces = "212211111".ToCharArray();
		}
		if(code == 4d){
			spaces = "111221112".ToCharArray();
		}
		if(code == 5d){
			spaces = "211221111".ToCharArray();
		}
		if(code == 6d){
			spaces = "112221111".ToCharArray();
		}
		if(code == 7d){
			spaces = "111211212".ToCharArray();
		}
		if(code == 8d){
			spaces = "211211211".ToCharArray();
		}
		if(code == 9d){
			spaces = "112211211".ToCharArray();
		}
		if(code == 10d){
			spaces = "211112112".ToCharArray();
		}
		if(code == 11d){
			spaces = "112112112".ToCharArray();
		}
		if(code == 12d){
			spaces = "212112111".ToCharArray();
		}
		if(code == 13d){
			spaces = "111122112".ToCharArray();
		}
		if(code == 14d){
			spaces = "211122111".ToCharArray();
		}
		if(code == 15d){
			spaces = "112122111".ToCharArray();
		}
		if(code == 16d){
			spaces = "111112212".ToCharArray();
		}
		if(code == 17d){
			spaces = "211112211".ToCharArray();
		}
		if(code == 18d){
			spaces = "112112211".ToCharArray();
		}
		if(code == 19d){
			spaces = "111122211".ToCharArray();
		}
		if(code == 20d){
			spaces = "211111122".ToCharArray();
		}
		if(code == 21d){
			spaces = "112111122".ToCharArray();
		}
		if(code == 22d){
			spaces = "212111121".ToCharArray();
		}
		if(code == 23d){
			spaces = "111121122".ToCharArray();
		}
		if(code == 24d){
			spaces = "211121121".ToCharArray();
		}
		if(code == 25d){
			spaces = "112121121".ToCharArray();
		}
		if(code == 26d){
			spaces = "111111222".ToCharArray();
		}
		if(code == 27d){
			spaces = "211111221".ToCharArray();
		}
		if(code == 28d){
			spaces = "112111221".ToCharArray();
		}
		if(code == 29d){
			spaces = "111121221".ToCharArray();
		}
		if(code == 30d){
			spaces = "221111112".ToCharArray();
		}
		if(code == 31d){
			spaces = "122111112".ToCharArray();
		}
		if(code == 32d){
			spaces = "222111111".ToCharArray();
		}
		if(code == 33d){
			spaces = "121121112".ToCharArray();
		}
		if(code == 34d){
			spaces = "221121111".ToCharArray();
		}
		if(code == 35d){
			spaces = "122121111".ToCharArray();
		}
		if(code == 36d){
			spaces = "121111212".ToCharArray();
		}
		if(code == 37d){
			spaces = "221111211".ToCharArray();
		}
		if(code == 38d){
			spaces = "122111211".ToCharArray();
		}
		if(code == 39d){
			spaces = "121212111".ToCharArray();
		}
		if(code == 40d){
			spaces = "121211121".ToCharArray();
		}
		if(code == 41d){
			spaces = "121112121".ToCharArray();
		}
		if(code == 42d){
			spaces = "111212121".ToCharArray();
		}
		if(code == 43d){
			spaces = "121121211".ToCharArray();
		}

		return spaces;
	}


	public static double AsciiToCode39(char c){
		double nr;
		double [] asciiToNrTable;

		asciiToNrTable = GetAsciiToCode39Table();
		nr = c;

		return asciiToNrTable[(int)(nr)];
	}


	public static double [] GetAsciiToCode39Table(){
		double [] c;

		c = new double [256];

		c[(int)('0')] = 0d;
		c[(int)('1')] = 1d;
		c[(int)('2')] = 2d;
		c[(int)('3')] = 3d;
		c[(int)('4')] = 4d;
		c[(int)('5')] = 5d;
		c[(int)('6')] = 6d;
		c[(int)('7')] = 7d;
		c[(int)('8')] = 8d;
		c[(int)('9')] = 9d;
		c[(int)('A')] = 10d;
		c[(int)('B')] = 11d;
		c[(int)('C')] = 12d;
		c[(int)('D')] = 13d;
		c[(int)('E')] = 14d;
		c[(int)('F')] = 15d;
		c[(int)('G')] = 16d;
		c[(int)('H')] = 17d;
		c[(int)('I')] = 18d;
		c[(int)('J')] = 19d;
		c[(int)('K')] = 20d;
		c[(int)('L')] = 21d;
		c[(int)('M')] = 22d;
		c[(int)('N')] = 23d;
		c[(int)('O')] = 24d;
		c[(int)('P')] = 25d;
		c[(int)('Q')] = 26d;
		c[(int)('R')] = 27d;
		c[(int)('S')] = 28d;
		c[(int)('T')] = 29d;
		c[(int)('U')] = 30d;
		c[(int)('V')] = 31d;
		c[(int)('W')] = 32d;
		c[(int)('X')] = 33d;
		c[(int)('Y')] = 34d;
		c[(int)('Z')] = 35d;
		c[(int)('-')] = 36d;
		c[(int)('.')] = 37d;
		c[(int)(' ')] = 38d;
		c[(int)('$')] = 39d;
		c[(int)('/')] = 40d;
		c[(int)('+')] = 41d;
		c[(int)('%')] = 42d;
		c[(int)('*')] = 43d;

		return c;
	}


	public static bool IsQRNumericString(char [] chars){
		double i;
		bool valid;

		valid = true;

		for(i = 0d; i < chars.Length; i = i + 1d){
			if(IsQRNumericCharacter(chars[(int)(i)])){
			}else{
				valid = false;
			}
		}

		return valid;
	}


	public static bool IsQRNumericCharacter(char aChar){
		return cIsNumber(aChar);
	}


	public static bool IsQRAlphanumericString(char [] chars){
		double i;
		bool valid;
		char c;

		valid = true;

		for(i = 0d; i < chars.Length; i = i + 1d){
			c = chars[(int)(i)];

			valid = IsQRAlphanumericCharacter(c);
		}

		return valid;
	}


	public static bool IsQRAlphanumericCharacter(char c){
		bool valid;

		valid = true;

		if(cIsNumber(c)){
		}else if(IsQRAlphaUppercase(c)){
		}else if(c == ' '){
		}else if(c == '$'){
		}else if(c == '%'){
		}else if(c == '*'){
		}else if(c == '+'){
		}else if(c == '-'){
		}else if(c == '.'){
		}else if(c == '/'){
		}else if(c == ':'){
		}else{
			valid = false;
		}
		return valid;
	}


	public static bool IsQRJIS8Character(char c){
		double code;
		bool valid;

		code = c;

		if(code >= 0d && code < 128d){
			valid = true;
		}else{
			valid = false;
		}

		return valid;
	}


	public static bool IsQRAlphaUppercase(char character){
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


	public static double QRAlphanumericToCode(char c){
		double code;

		if(c == '0'){
			code = 0d;
		}else if(c == '1'){
			code = 1d;
		}else if(c == '2'){
			code = 2d;
		}else if(c == '3'){
			code = 3d;
		}else if(c == '4'){
			code = 4d;
		}else if(c == '5'){
			code = 5d;
		}else if(c == '6'){
			code = 6d;
		}else if(c == '7'){
			code = 7d;
		}else if(c == '8'){
			code = 8d;
		}else if(c == '9'){
			code = 9d;
		}else if(c == 'A'){
			code = 10d;
		}else if(c == 'B'){
			code = 11d;
		}else if(c == 'C'){
			code = 12d;
		}else if(c == 'D'){
			code = 13d;
		}else if(c == 'E'){
			code = 14d;
		}else if(c == 'F'){
			code = 15d;
		}else if(c == 'G'){
			code = 16d;
		}else if(c == 'H'){
			code = 17d;
		}else if(c == 'I'){
			code = 18d;
		}else if(c == 'J'){
			code = 19d;
		}else if(c == 'K'){
			code = 20d;
		}else if(c == 'L'){
			code = 21d;
		}else if(c == 'M'){
			code = 22d;
		}else if(c == 'N'){
			code = 23d;
		}else if(c == 'O'){
			code = 24d;
		}else if(c == 'P'){
			code = 25d;
		}else if(c == 'Q'){
			code = 26d;
		}else if(c == 'R'){
			code = 27d;
		}else if(c == 'S'){
			code = 28d;
		}else if(c == 'T'){
			code = 29d;
		}else if(c == 'U'){
			code = 30d;
		}else if(c == 'V'){
			code = 31d;
		}else if(c == 'W'){
			code = 32d;
		}else if(c == 'X'){
			code = 33d;
		}else if(c == 'Y'){
			code = 34d;
		}else if(c == 'Z'){
			code = 35d;
		}else if(c == ' '){
			code = 36d;
		}else if(c == '$'){
			code = 37d;
		}else if(c == '%'){
			code = 38d;
		}else if(c == '*'){
			code = 39d;
		}else if(c == '+'){
			code = 40d;
		}else if(c == '-'){
			code = 41d;
		}else if(c == '.'){
			code = 42d;
		}else if(c == '/'){
			code = 43d;
		}else if(c == ':'){
			code = 44d;
		}else{
			code = 0d;
		}

		return code;
	}


	public static double [] QRAddErrorCodesAndInterleave(double [] cws, double version, char errorCorrectionLevel){
		double eccsPerBlock, errorCorrectionLevelNumber, nrOfBlocks, i, j, cw, cwsInBlock, e;
		double [] ecc, eccPerBlockSpec, blockSpecs, blockLengths, block, complete;
		NumberArrayReference [] blocks, blockEccs;

		eccPerBlockSpec = StringToNumberArray("7, 10, 13, 17, 10, 16, 22, 28, 15, 26, 18, 22, 20, 18, 26, 16, 26, 24, 18, 22, 18, 16, 24, 28, 20, 18, 18, 26, 24, 22, 22, 26, 30, 22, 20, 24, 18, 26, 24, 28, 20, 30, 28, 24, 24, 22, 26, 28, 26, 22, 24, 22, 30, 24, 20, 24, 22, 24, 30, 24, 24, 28, 24, 30, 28, 28, 28, 28, 30, 26, 28, 28, 28, 26, 26, 26, 28, 26, 30, 28, 28, 26, 28, 30, 28, 28, 30, 24, 30, 28, 30, 30, 30, 28, 30, 30, 26, 28, 30, 30, 28, 28, 28, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30".ToCharArray());

		blockSpecs = StringToNumberArray("1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2, 4, 1, 2, 4, 4, 2, 4, 4, 4, 2, 4, 6, 5, 2, 4, 6, 6, 2, 5, 8, 8, 4, 5, 8, 8, 4, 5, 8, 11, 4, 8, 10, 11, 4, 9, 12, 16, 4, 9, 16, 16, 6, 10, 12, 18, 6, 10, 17, 16, 6, 11, 16, 19, 6, 13, 18, 21, 7, 14, 21, 25, 8, 16, 20, 25, 8, 17, 23, 25, 9, 17, 23, 34, 9, 18, 25, 30, 10, 20, 27, 32, 12, 21, 29, 35, 12, 23, 34, 37, 12, 25, 34, 40, 13, 26, 35, 42, 14, 28, 38, 45, 15, 29, 40, 48, 16, 31, 43, 51, 17, 33, 45, 54, 18, 35, 48, 57, 19, 37, 51, 60, 19, 38, 53, 63, 20, 40, 56, 66, 21, 43, 59, 70, 22, 45, 62, 74, 24, 47, 65, 77, 25, 49, 68, 81".ToCharArray());

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevel);

		eccsPerBlock = eccPerBlockSpec[(int)((version - 1d)*4d + errorCorrectionLevelNumber)];
		nrOfBlocks = blockSpecs[(int)((version - 1d)*4d + errorCorrectionLevelNumber)];

		blockLengths = QRComputeBlockLengths(cws.Length, nrOfBlocks);

		blocks = new NumberArrayReference [(int)(nrOfBlocks)];
		blockEccs = new NumberArrayReference [(int)(nrOfBlocks)];

		cw = 0d;
		for(i = 0d; i < nrOfBlocks; i = i + 1d){
			/* Create block.*/
			cwsInBlock = blockLengths[(int)(i)];
			block = new double [(int)(cwsInBlock)];
			for(j = 0d; j < cwsInBlock; j = j + 1d){
				block[(int)(j)] = cws[(int)(cw)];
				cw = cw + 1d;
			}

			/* Compute eccs.*/
			ecc = ComputeReedSolomonCodes(block, eccsPerBlock);

			blocks[(int)(i)] = new NumberArrayReference();
			blocks[(int)(i)].numberArray = block;
			blockEccs[(int)(i)] = new NumberArrayReference();
			blockEccs[(int)(i)].numberArray = ecc;
		}

		/* Compose full data block:*/
		complete = new double [(int)(cws.Length + eccsPerBlock*nrOfBlocks)];

		e = 0d;
		/* Interleave codewords:*/
		for(i = 0d; i < Floor(cws.Length/nrOfBlocks); i = i + 1d){
			for(j = 0d; j < nrOfBlocks; j = j + 1d){
				complete[(int)(e)] = blocks[(int)(j)].numberArray[(int)(i)];
				e = e + 1d;
			}
		}

		/* Interleave remaining code words:*/
		for(i = 0d; i < nrOfBlocks; i = i + 1d){
			if(blockLengths[(int)(i)] > blockLengths[0]){
				complete[(int)(e)] = blocks[(int)(i)].numberArray[(int)(blockLengths[(int)(i)] - 1d)];
				e = e + 1d;
			}
		}

		for(i = 0d; i < eccsPerBlock; i = i + 1d){
			for(j = 0d; j < nrOfBlocks; j = j + 1d){
				complete[(int)(e)] = blockEccs[(int)(j)].numberArray[(int)(i)];
				e = e + 1d;
			}
		}

		return complete;
	}


	public static double [] QRComputeBlockLengths(double length, double blocks){
		double q, r, i;
		double [] blockLengths;

		blockLengths = new double [(int)(blocks)];

		q = Floor(length/blocks);
		r = length%blocks;

		for(i = 0d; i < blocks; i = i + 1d){
			blockLengths[(int)(i)] = q;
		}

		if(r > 0d){
			for(i = 0d; i < r; i = i + 1d){
				blockLengths[(int)(blockLengths.Length - 1d - i)] = q + 1d;
			}
		}

		return blockLengths;
	}


	public static bool GenerateQRCode(RGBABitmapImageReference imageReference, char [] chars, char errorCorrectionLevel, StringReference errorMessage){
		double version;
		NumberReference versionReference;
		bool success;

		versionReference = new NumberReference();
		success = QRGetRequiredVersionFromData(chars, errorCorrectionLevel, versionReference, errorMessage);

		if(success){
			version = versionReference.numberValue;

			GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, QRQuietZoneSize(), errorMessage);
		}

		return success;
	}


	public static bool QRGetRequiredVersionFromData(char [] chars, char errorCorrectionLevelCode, NumberReference versionReference, StringReference errorMessage){
		StringReference modeReference;
		bool success, done;
		double i, l, errorCorrectionLevelNumber;
		char [] modeName;
		double [] symbolBitsSpec;
		NumberReference lengthReference;

		modeReference = new StringReference();
		success = QRDetectMode(chars, modeReference, errorMessage);

		if(success){
			modeName = modeReference.stringx;

			symbolBitsSpec = GetQRSymbolLengthsForVersions();

			errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode);

			done = false;
			lengthReference = new NumberReference();
			for(i = 1d; i <= 40d && !done; i = i + 1d){
				success = QRComputeNumberOfCodewords(chars.Length, i, modeName, lengthReference, errorMessage);

				if(success){
					l = lengthReference.numberValue;

					if(l <= symbolBitsSpec[(int)((i - 1d)*4d + errorCorrectionLevelNumber)]){
						versionReference.numberValue = i;
						done = true;
					}
				}else{
					done = true;
				}
			}

			if(!done){
				success = false;
				errorMessage.stringx = "Too much data for any QR code.".ToCharArray();
			}
		}

		return success;
	}


	public static bool GenerateQRCodeWithAllOptions(RGBABitmapImageReference imageReference, char [] chars, double version, char errorCorrectionLevel, double quietZoneSize, StringReference errorMessage){
		RGBABitmapImage image, quietZoneImage, basis;
		RGBABitmapImage [] masks, withMasks;
		double size, sizeWithQuietZone, i, min, choice;
		char [] bs, formatbits, mode;
		double [] cws, allcws, pentalies;
		bool success;
		StringReference modeReference, bsReference;

		modeReference = new StringReference();
		success = QRDetectMode(chars, modeReference, errorMessage);

		if(success){
			mode = modeReference.stringx;

			size = QRVersionToModules(version);

			image = CreateImage(size, size, GetTransparent());

			QRAddTimingPattern(image, version);

			QRAddFinderPattern(image, version);

			QRAddAlignmentPatterns(image, version);

			QRAddDummyFormatBits(image, version);

			if(version >= 7d){
				QRAddVersionBits(image, version);
			}

			bsReference = new StringReference();

			success = GetQRCodewordBitSequence(chars, version, mode, bsReference, errorMessage);

			if(success){
				bs = bsReference.stringx;

				cws = QRSegmentsToCodeWords(bs, version, errorCorrectionLevel);
				allcws = QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel);

				basis = CopyImage(image);

				QRAddCodewords(image, version, allcws);

				formatbits = new char [15];

				masks = new RGBABitmapImage [8];
				withMasks = new RGBABitmapImage [8];
				pentalies = new double [8];
				for(i = 0d; i < 8d; i = i + 1d){
					masks[(int)(i)] = CreateMask(i, version);
					withMasks[(int)(i)] = QRApplyMask(basis, image, masks[(int)(i)]);
					QRComputeFormatBits(formatbits, errorCorrectionLevel, i);
					QRAddFormatBits(withMasks[(int)(i)], formatbits);
					/*System.out.println("Mask " + (int)i);*/
					pentalies[(int)(i)] = QRComputePenalty(withMasks[(int)(i)]);
				}

				choice = 0d;
				min = pentalies[(int)(choice)];
				for(i = 0d; i < 8d; i = i + 1d){
					if(pentalies[(int)(i)] < min){
						choice = i;
						min = pentalies[(int)(choice)];
					}
				}

				image = withMasks[(int)(choice)];

				sizeWithQuietZone = size + 2d*quietZoneSize;
				quietZoneImage = CreateImage(sizeWithQuietZone, sizeWithQuietZone, GetWhite());
				DrawImageOnImage(quietZoneImage, image, quietZoneSize, quietZoneSize);

				imageReference.image = quietZoneImage;
			}
		}

		return success;
	}


	public static bool GetQRCodewordBitSequence(char [] chars, double version, char [] modeName, StringReference bsReference, StringReference errorMessage){
		bool success;

		if(arraysStringsEqual(modeName, "Numeric".ToCharArray())){
			success = QRNumericDataToSegment(chars, version, bsReference, errorMessage);
		}else if(arraysStringsEqual(modeName, "Alphanumeric".ToCharArray())){
			success = QRAlphanumericDataToSegment(chars, version, bsReference, errorMessage);
		}else if(arraysStringsEqual(modeName, "8-bit Byte".ToCharArray())){
			success = QR8BitByteDataToSegment(chars, version, bsReference, errorMessage);
		}else{
			success = false;
			errorMessage.stringx = "Invalid data mode.".ToCharArray();
		}

		return success;
	}


	public static bool QRComputeNumberOfCodewords(double dataLength, double version, char [] modeName, NumberReference lengthReference, StringReference errorMessage){
		double length, r, last, c;
		bool success;
		NumberReference countReference;

		length = 0d;
		countReference = new NumberReference();

		success = QRGetCountLength(version, modeName, countReference, errorMessage);

		if(success){
			c = countReference.numberValue;

			if(arraysStringsEqual(modeName, "Numeric".ToCharArray())){
				r = 0d;
				last = dataLength%3d;
				if(last == 0d){
					r = 0d;
				}else if(last == 1d){
					r = 4d;
				}else if(last == 2d){
					r = 7d;
				}

				length = 4d + c + 10d*Floor(dataLength/3d) + r;
			}else if(arraysStringsEqual(modeName, "Alphanumeric".ToCharArray())){
				length = 4d + c + 11d*Floor(dataLength/2d) + 6d*(dataLength%2d);
			}else if(arraysStringsEqual(modeName, "8-bit Byte".ToCharArray())){
				length = 4d + c + 8d*dataLength;
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		if(success){
			lengthReference.numberValue = length;
		}

		return success;
	}


	public static void QRAddVersionBits(RGBABitmapImage image, double version){
		double ecc, i, x, y, offset;
		StringReference str;
		char [] code;

		ecc = ComputeBHC18_6Code(version);

		code = new char [18];

		str = new StringReference();
		CreateStringFromNumberWithCheck(version, 2d, str);

		offset = 6d - str.stringx.Length;
		for(i = 0d; i < 6d; i = i + 1d){
			if(i < offset){
				code[(int)(i)] = '0';
			}else{
				code[(int)(i)] = str.stringx[(int)(i - offset)];
			}
		}

		CreateStringFromNumberWithCheck(ecc, 2d, str);

		offset = 12d - str.stringx.Length;
		for(i = 0d; i < 12d; i = i + 1d){
			if(i < offset){
				code[(int)(6d + i)] = '0';
			}else{
				code[(int)(6d + i)] = str.stringx[(int)(i - offset)];
			}
		}

		for(i = 0d; i < 18d; i = i + 1d){
			x = ImageWidth(image) - 11d + i%3d;
			y = 0d + Floor(i/3d);

			if(code[(int)(18d - 1d - i)] == '1'){
				SetPixel(image, x, y, GetBlack());
				SetPixel(image, y, x, GetBlack());
			}else{
				SetPixel(image, x, y, GetWhite());
				SetPixel(image, y, x, GetWhite());
			}
		}
	}


	public static void QRAddAlignmentPatterns(RGBABitmapImage image, double version){
		double i, j, x, y, nrOfPositions;
		double [] positions, col2, col3, col4, col5, col6, col7;
		bool includePattern;

		positions = new double [7];

		col2 = StringToNumberArray("18, 22, 26, 30, 34, 22, 24, 26, 28, 30, 32, 34, 26, 26, 26, 30, 30, 30, 34, 28, 26, 30, 28, 32, 30, 34, 26, 30, 26, 30, 34, 30, 34, 30, 24, 28, 32, 26, 30".ToCharArray());
		col3 = StringToNumberArray("38, 42, 46, 50, 54, 58, 62, 46, 48, 50, 54, 56, 58, 62, 50, 50, 54, 54, 58, 58, 62, 50, 54, 52, 56, 60, 58, 62, 54, 50, 54, 58, 54, 58".ToCharArray());
		col4 = StringToNumberArray("66, 70, 74, 78, 82, 86, 90, 72, 74, 78, 80, 84, 86, 90, 74, 78, 78, 82, 86, 86, 90, 78, 76, 80, 84, 82, 86".ToCharArray());
		col5 = StringToNumberArray("94, 98, 102, 106, 110, 114, 118, 98, 102, 104, 108, 112, 114, 118, 102, 102, 106, 110, 110, 114".ToCharArray());
		col6 = StringToNumberArray("122, 126, 130, 134, 138, 142, 146, 126, 128, 132, 136, 138, 142".ToCharArray());
		col7 = StringToNumberArray("150, 154, 158, 162, 166, 170".ToCharArray());

		positions[0] = 6d;
		nrOfPositions = 0d;

		if(version == 1d){
			nrOfPositions = 0d;
		}
		if(version >= 2d){
			nrOfPositions = 2d;
			positions[1] = col2[(int)(version - 2d)];
		}
		if(version >= 7d){
			nrOfPositions = 3d;
			positions[2] = col3[(int)(version - 7d)];
		}
		if(version >= 14d){
			nrOfPositions = 4d;
			positions[3] = col4[(int)(version - 14d)];
		}
		if(version >= 21d){
			nrOfPositions = 5d;
			positions[4] = col5[(int)(version - 21d)];
		}
		if(version >= 28d){
			nrOfPositions = 6d;
			positions[5] = col6[(int)(version - 28d)];
		}
		if(version >= 35d){
			nrOfPositions = 7d;
			positions[6] = col7[(int)(version - 35d)];
		}

		for(i = 0d; i < nrOfPositions; i = i + 1d){
			for(j = 0d; j < nrOfPositions; j = j + 1d){
				x = positions[(int)(i)];
				y = positions[(int)(j)];

				if(x <= 8d && y <= 8d){
					includePattern = false;
				}else if(x >= ImageWidth(image) - 8d && y <= 8d){
					includePattern = false;
				}else if(x <= 8d && y >= ImageWidth(image) - 7d){
					includePattern = false;
				}else{
					includePattern = true;
				}

				if(includePattern){
					QRAddAlignmentPattern(image, x, y);
				}
			}
		}
	}


	public static void QRAddAlignmentPattern(RGBABitmapImage image, double x, double y){
		DrawRectangle1px(image, x, y, 0d, 0d, GetBlack());
		DrawRectangle1px(image, x - 1d, y - 1d, 2d, 2d, GetWhite());
		DrawRectangle1px(image, x - 2d, y - 2d, 4d, 4d, GetBlack());
	}


	public static bool QR8BitByteDataToSegment(char [] data, double version, StringReference bsReference, StringReference errorMessage){
		char [] bs, mode;
		double length, c, d, i, n, j, offset;
		StringReference nstr;
		NumberReference lengthReference, countReference;
		bool success;

		countReference = new NumberReference();
		success = QRGetCountLength(version, "8-bit Byte".ToCharArray(), countReference, errorMessage);

		if(success){
			c = countReference.numberValue;
			d = data.Length;

			lengthReference = new NumberReference();
			success = QRComputeNumberOfCodewords(data.Length, version, "8-bit Byte".ToCharArray(), lengthReference, errorMessage);

			if(success){
				length = lengthReference.numberValue;

				bs = arraysCreateString(length, '0');

				/* Characters*/
				nstr = new StringReference();

				for(i = 0d; i < d; i = i + 1d){
					n = data[(int)(i)];

					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 8d - nstr.stringx.Length;
					for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
						bs[(int)(4d + c + 8d*i + j + offset)] = nstr.stringx[(int)(j)];
					}
				}

				/* Character count*/
				CreateStringFromNumberWithCheck(d, 2d, nstr);
				offset = 4d + c - nstr.stringx.Length;
				for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
					bs[(int)(offset + j)] = nstr.stringx[(int)(j)];
				}

				/* Mode*/
				mode = QR8BitByteModeIndicator();
				for(j = 0d; j < 4d; j = j + 1d){
					bs[(int)(j)] = mode[(int)(j)];
				}

				bsReference.stringx = bs;
			}
		}

		return success;
	}


	public static bool QRDetectMode(char [] chars, StringReference modeReference, StringReference errorMessage){
		bool success;
		double i, mode;
		char c;

		mode = 0d;
		success = false;

		for(i = 0d; i < chars.Length; i = i + 1d){
			c = chars[(int)(i)];

			if(cIsNumber(c)){
				if(mode == 0d){
					mode = 1d;
					success = true;
				}
			}else if(IsQRAlphanumericCharacter(c)){
				if(mode <= 1d){
					mode = 2d;
					success = true;
				}
			}else if(IsQRJIS8Character(c)){
				if(mode <= 2d){
					mode = 3d;
					success = true;
				}
			}else{
				mode = 5d;
				success = false;
				errorMessage.stringx = "Data contains invalid characters".ToCharArray();
			}
		}

		if(mode == 0d){
			errorMessage.stringx = "There is no data to put in the QR code.".ToCharArray();
		}
		if(mode == 1d){
			modeReference.stringx = "Numeric".ToCharArray();
		}
		if(mode == 2d){
			modeReference.stringx = "Alphanumeric".ToCharArray();
		}
		if(mode == 3d){
			modeReference.stringx = "8-bit Byte".ToCharArray();
		}

		return success;
	}


	public static double QRComputePenalty(RGBABitmapImage image){
		double totalP, runP, boxP, findP, balP;

		runP = QRComputePenaltyForRuns(image);
		/*System.out.println("runP: " + ", " + (int)runP);*/
		boxP = QRComputePenaltyForBoxes(image);
		/*System.out.println("boxP: " + ", " + (int)boxP);*/
		findP = QRComputePenaltyForFinders(image);
		/*System.out.println("findP: " + ", " + (int)findP);*/
		balP = QRComputePenaltyForBalance(image);
		/*System.out.println("balP: " + ", " + (int)balP);*/
		/* Total penalty*/
		totalP = runP + boxP + balP + findP + balP;
		/*System.out.println(totalP);*/
		return totalP;
	}


	public static double QRComputePenaltyForBalance(RGBABitmapImage image){
		double x, y, h, w, balP, total, black, deviation;
		bool isBlack;

		h = ImageHeight(image);
		w = ImageWidth(image);

		total = h*w;
		black = 0d;

		for(y = 0d; y < h; y = y + 1d){
			for(x = 0d; x < w; x = x + 1d){
				isBlack = PixelIsBlack(image, x, y);

				if(isBlack){
					black = black + 1d;
				}
			}
		}

		deviation = Abs(100d*black/total - 50d);
		balP = Floor(deviation/5d)*10d;

		return balP;
	}


	public static double QRComputePenaltyForFinders(RGBABitmapImage image){
		double x, y, h, w, findP;
		bool d1, w1, d2, d3, d4, w2, d5, w3, w4, w5, w6;

		h = ImageHeight(image);
		w = ImageWidth(image);

		findP = 0d;
		for(y = 0d; y < h; y = y + 1d){
			for(x = 0d; x < w - 10d; x = x + 1d){
				d1 = PixelIsBlack(image, x + 0d, y);
				w1 = PixelIsBlack(image, x + 1d, y);
				d2 = PixelIsBlack(image, x + 2d, y);
				d3 = PixelIsBlack(image, x + 3d, y);
				d4 = PixelIsBlack(image, x + 4d, y);
				w2 = PixelIsBlack(image, x + 5d, y);
				d5 = PixelIsBlack(image, x + 6d, y);
				w3 = PixelIsBlack(image, x + 7d, y);
				w4 = PixelIsBlack(image, x + 8d, y);
				w5 = PixelIsBlack(image, x + 9d, y);
				w6 = PixelIsBlack(image, x + 10d, y);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}

				w3 = PixelIsBlack(image, x + 0d, y);
				w4 = PixelIsBlack(image, x + 1d, y);
				w5 = PixelIsBlack(image, x + 2d, y);
				w6 = PixelIsBlack(image, x + 3d, y);
				d1 = PixelIsBlack(image, x + 4d, y);
				w1 = PixelIsBlack(image, x + 5d, y);
				d2 = PixelIsBlack(image, x + 6d, y);
				d3 = PixelIsBlack(image, x + 7d, y);
				d4 = PixelIsBlack(image, x + 8d, y);
				w2 = PixelIsBlack(image, x + 9d, y);
				d5 = PixelIsBlack(image, x + 10d, y);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}
			}
		}

		for(x = 0d; x < w; x = x + 1d){
			for(y = 0d; y < h - 10d; y = y + 1d){
				d1 = PixelIsBlack(image, x, y + 0d);
				w1 = PixelIsBlack(image, x, y + 1d);
				d2 = PixelIsBlack(image, x, y + 2d);
				d3 = PixelIsBlack(image, x, y + 3d);
				d4 = PixelIsBlack(image, x, y + 4d);
				w2 = PixelIsBlack(image, x, y + 5d);
				d5 = PixelIsBlack(image, x, y + 6d);
				w3 = PixelIsBlack(image, x, y + 7d);
				w4 = PixelIsBlack(image, x, y + 8d);
				w5 = PixelIsBlack(image, x, y + 9d);
				w6 = PixelIsBlack(image, x, y + 10d);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}

				w3 = PixelIsBlack(image, x, y + 0d);
				w4 = PixelIsBlack(image, x, y + 1d);
				w5 = PixelIsBlack(image, x, y + 2d);
				w6 = PixelIsBlack(image, x, y + 3d);
				d1 = PixelIsBlack(image, x, y + 4d);
				w1 = PixelIsBlack(image, x, y + 5d);
				d2 = PixelIsBlack(image, x, y + 6d);
				d3 = PixelIsBlack(image, x, y + 7d);
				d4 = PixelIsBlack(image, x, y + 8d);
				w2 = PixelIsBlack(image, x, y + 9d);
				d5 = PixelIsBlack(image, x, y + 10d);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}
			}
		}

		return findP;
	}


	public static double QRComputePenaltyForBoxes(RGBABitmapImage image){
		double x, y, h, w, boxP;
		bool ul, ur, ll, lr;

		h = ImageHeight(image);
		w = ImageWidth(image);

		boxP = 0d;
		for(y = 0d; y < h - 1d; y = y + 1d){
			for(x = 0d; x < w - 1d; x = x + 1d){
				ul = PixelIsBlack(image, x + 0d, y + 0d);
				ur = PixelIsBlack(image, x + 1d, y + 0d);
				ll = PixelIsBlack(image, x + 0d, y + 1d);
				lr = PixelIsBlack(image, x + 1d, y + 1d);

				if(ul && ur && ll && lr || !ul && !ur && !ll && !lr){
					boxP = boxP + 3d;
				}
			}
		}

		return boxP;
	}


	public static bool PixelIsBlack(RGBABitmapImage image, double x, double y){
		return GetImagePixel(image, x, y).r == 0d;
	}


	public static double QRComputePenaltyForRuns(RGBABitmapImage image){
		bool first, prev, cur;
		double run, x, y, h, w, runP;
		bool last;

		h = ImageHeight(image);
		w = ImageWidth(image);

		runP = 0d;

		/* Horizontal penalty*/
		for(y = 0d; y < h; y = y + 1d){
			first = true;
			prev = true;
			cur = true;
			run = 1d;

			for(x = 0d; x <= w; x = x + 1d){
				last = x == w;
				if(!last){
					cur = PixelIsBlack(image, x, y);
				}

				if(!first){
					if(prev == cur && !last){
						run = run + 1d;
					}

					if(prev != cur || last){
						if(run >= 5d){
							runP = runP + 3d + run - 5d;
						}
						run = 1d;
					}
				}

				first = false;
				prev = cur;
			}
		}

		/* Vertical penalty*/
		for(x = 0d; x < w; x = x + 1d){
			first = true;
			prev = true;
			cur = true;
			run = 1d;

			for(y = 0d; y <= h; y = y + 1d){
				last = y == h;
				if(!last){
					cur = PixelIsBlack(image, x, y);
				}

				if(!first){
					if(prev == cur && !last){
						run = run + 1d;
					}

					if(prev != cur || last){
						if(run >= 5d){
							runP = runP + 3d + run - 5d;
						}
						run = 1d;
					}
				}

				first = false;
				prev = cur;
			}
		}
		return runP;
	}


	public static void QRAddFormatBits(RGBABitmapImage image, char [] formatbits){
		char b;
		double i, x, y;
		RGBA black, white, color;

		black = GetBlack();
		white = GetWhite();

		x = 8d;
		y = 0d;

		/* Upper-left*/
		for(i = 0d; i < formatbits.Length; i = i + 1d){
			b = formatbits[(int)(14d - i)];
			if(b == '1'){
				color = black;
			}else{
				color = white;
			}

			SetPixel(image, x, y, color);

			if(i < 7d){
				y = y + 1d;
			}
			if(i == 5d){
				y = y + 1d;
			}

			if(i >= 7d){
				x = x - 1d;
			}
			if(i == 8d){
				x = x - 1d;
			}
		}

		/* Lower left and top right*/
		x = ImageWidth(image) - 1d;
		y = 8d;

		for(i = 0d; i < formatbits.Length; i = i + 1d){
			b = formatbits[(int)(14d - i)];
			if(b == '1'){
				color = black;
			}else{
				color = white;
			}

			SetPixel(image, x, y, color);

			if(i < 7d){
				x = x - 1d;
			}
			if(i == 7d){
				y = ImageHeight(image) - 7d;
				x = 8d;
			}

			if(i > 7d){
				y = y + 1d;
			}
		}
	}


	public static void QRComputeFormatBits(char [] bits, char errorCorrectionLevel, double mask){
		double i, bhc, offset, errorCorrectionCode, n;
		char [] xorpattern;
		StringReference str;
		bool a, b, r;

		errorCorrectionCode = 0d;
		if(errorCorrectionLevel == 'L'){
			errorCorrectionCode = 1d;
		}else if(errorCorrectionLevel == 'M'){
			errorCorrectionCode = 0d;
		}else if(errorCorrectionLevel == 'Q'){
			errorCorrectionCode = 3d;
		}else if(errorCorrectionLevel == 'H'){
			errorCorrectionCode = 2d;
		}

		n = OrByte(ShiftLeftByte(errorCorrectionCode, 3d), mask);

		bhc = ComputeBHC15_5Code(n);

		n = Or4Byte(ShiftLeft4Byte(n, 10d), bhc);

		str = new StringReference();
		CreateStringFromNumberWithCheck(n, 2d, str);

		offset = 15d - str.stringx.Length;
		for(i = 0d; i < 15d; i = i + 1d){
			if(i < offset){
				bits[(int)(i)] = '0';
			}else{
				bits[(int)(i)] = str.stringx[(int)(i - offset)];
			}
		}

		xorpattern = "101010000010010".ToCharArray();

		for(i = 0d; i < 15d; i = i + 1d){
			a = bits[(int)(i)] == '1';
			b = xorpattern[(int)(i)] == '1';

			r = Xor(a, b);

			if(r){
				bits[(int)(i)] = '1';
			}else{
				bits[(int)(i)] = '0';
			}
		}
	}


	public static RGBABitmapImage QRApplyMask(RGBABitmapImage basis, RGBABitmapImage image, RGBABitmapImage mask){
		RGBABitmapImage withMask;
		double i, j;
		bool a, b, r;

		withMask = CopyImage(image);

		for(i = 0d; i < ImageWidth(basis); i = i + 1d){
			for(j = 0d; j < ImageHeight(basis); j = j + 1d){
				if(GetImagePixel(basis, i, j).a == 0d){
					a = PixelIsBlack(image, i, j);
					b = PixelIsBlack(mask, i, j);

					/* xor*/
					r = Xor(a, b);

					if(r){
						SetPixel(withMask, i, j, GetBlack());
					}else{
						SetPixel(withMask, i, j, GetWhite());
					}
				}
			}
		}

		return withMask;
	}


	public static bool Xor(bool a, bool b){
		return a && !b || !a && b;
	}


	public static RGBABitmapImage CreateMask(double mask, double version){
		double size, i, j;
		bool black;
		RGBABitmapImage image;

		size = QRVersionToModules(version);

		image = CreateImage(size, size, GetTransparent());

		black = true;
		for(i = 0d; i < size; i = i + 1d){
			for(j = 0d; j < size; j = j + 1d){
				if(mask == 0d){
					black = (i + j)%2d == 0d;
				}else if(mask == 1d){
					black = i%2d == 0d;
				}else if(mask == 2d){
					black = j%3d == 0d;
				}else if(mask == 3d){
					black = (i + j)%3d == 0d;
				}else if(mask == 4d){
					black = (Floor(i/2d) + Floor(j/3d))%2d == 0d;
				}else if(mask == 5d){
					black = (i*j)%2d + (i*j)%3d == 0d;
				}else if(mask == 6d){
					black = ((i*j)%2d + (i*j)%3d)%2d == 0d;
				}else if(mask == 7d){
					black = ((i*j)%3d + (i + j)%2d)%2d == 0d;
				}

				if(black){
					SetPixel(image, j, i, GetBlack());
				}else{
					SetPixel(image, j, i, GetWhite());
				}
			}
		}

		return image;
	}


	public static void QRAddDummyFormatBits(RGBABitmapImage image, double version){
		double i, size;

		size = QRVersionToModules(version);

		for(i = 0d; i < 9d; i = i + 1d){
			if(i != 6d){
				SetPixel(image, i, 8d, GetWhite());
				SetPixel(image, 8d, i, GetWhite());
			}
			if(i != 8d){
				SetPixel(image, size - 1d - i, 8d, GetWhite());
				SetPixel(image, 8d, size - 1d - i, GetWhite());
			}
		}

		SetPixel(image, 8d, size - 8d, GetBlack());
	}


	public static void QRAddCodewords(RGBABitmapImage image, double version, double [] cws){
		LinkedListCharacters ll;
		double i, j, x, y, size, offset, bit;
		StringReference s;
		char [] bits;
		char b;
		bool w, d;
        
		ll = CreateLinkedListCharacter();
		s = new StringReference();
        
		for(i = 0d; i < cws.Length; i = i + 1d){
			CreateStringFromNumberWithCheck(cws[(int)(i)], 2d, s);

			offset = 8d - s.stringx.Length;
			for(j = 0d; j < 8d; j = j + 1d){
				if(j < offset){
					LinkedListAddCharacter(ll, '0');
				}else{
					LinkedListAddCharacter(ll, s.stringx[(int)(j - offset)]);
				}
			}

			delete(s.stringx);
		}

		bits = LinkedListCharactersToArray(ll);

		size = QRVersionToModules(version);
		x = size - 1d;
		y = size - 1d;
		d = true;
		w = true;
		bit = 0d;
		offset = 0d;
		for(i = 0d; i < Pow(size, 2d) - size; i = i + 1d){
			if(GetImagePixel(image, x - offset, y).a == 0d){
				if(bit < bits.Length){
					b = bits[(int)(bit)];

					if(b == '1'){
						SetPixel(image, (x - offset), y, GetBlack());
					}else{
						SetPixel(image, (x - offset), y, GetWhite());
					}

					bit = bit + 1d;
				}else{
					/* Some symbols have nothing at the end.*/
					SetPixel(image, (x - offset), y, GetWhite());
				}
			}

			if(d){
				if(w){
					x = x - 1d;
				}else{
					x = x + 1d;
					y = y - 1d;
				}
			}else if(w){
				x = x - 1d;
			}else{
				x = x + 1d;
				y = y + 1d;
			}

			w = !w;

			if(i%(2d*size) == 2d*size - 1d){
				if(d){
					x = x - 2d;
					y = y + 1d;
					w = true;
				}else{
					x = x - 2d;
					y = y - 1d;
					w = true;
				}

				d = !d;
			}

			if(x == 6d){
				offset = 1d;
			}
		}
	}


	public static void QRAddTimingPattern(RGBABitmapImage image, double version){
		double size, i;
		bool black;

		size = QRVersionToModules(version);

		black = true;
		for(i = 0d; i < size; i = i + 1d){
			if(black){
				SetPixel(image, i, 6d, GetBlack());
				SetPixel(image, 6d, i, GetBlack());
			}else{
				SetPixel(image, i, 6d, GetWhite());
				SetPixel(image, 6d, i, GetWhite());
			}

			black = !black;
		}
	}


	public static void QRAddFinderPattern(RGBABitmapImage image, double version){
		RGBABitmapImage finderPattern;
		double size;

		size = QRVersionToModules(version);
		finderPattern = GetQRFinderPattern();
		DrawImageOnImage(image, finderPattern, -1d, -1d);
		DrawImageOnImage(image, finderPattern, size - 7d - 1d, -1d);
		DrawImageOnImage(image, finderPattern, -1d, size - 7d - 1d);
	}


	public static RGBABitmapImage GetQRFinderPattern(){
		RGBABitmapImage fp;

		fp = CreateImage(9d, 9d, GetBlack());

		DrawRectangle1px(fp, 2d, 2d, 4d, 4d, GetWhite());
		DrawRectangle1px(fp, 0d, 0d, 8d, 8d, GetWhite());

		return fp;
	}


	public static double QRQuietZoneSize(){
		return 4d;
	}


	public static double QRVersionToModules(double version){
		return 17d + 4d*version;
	}


	public static bool QRNumericDataToSegment(char [] data, double version, StringReference bsReference, StringReference errorMessage){
		char [] bs, group, mode;
		double length, c, d, r, i, n, j, offset, last;
		StringReference nstr;
		NumberReference countReference, lengthReference;
		bool success;

		countReference = new NumberReference();
		success = QRGetCountLength(version, "Numeric".ToCharArray(), countReference, errorMessage);

		if(success){
			c = countReference.numberValue;
			d = data.Length;

			r = 0d;
			last = d%3d;
			if(last == 0d){
				r = 0d;
			}else if(last == 1d){
				r = 4d;
			}else if(last == 2d){
				r = 7d;
			}

			lengthReference = new NumberReference();
			success = QRComputeNumberOfCodewords(data.Length, version, "Numeric".ToCharArray(), lengthReference, errorMessage);
			if(success){
				length = lengthReference.numberValue;

				bs = arraysCreateString(length, '0');

				/* Characters*/
				group = new char [3];
				nstr = new StringReference();

				for(i = 0d; i < Floor(d/3d); i = i + 1d){
					group[0] = data[(int)(i*3d + 0d)];
					group[1] = data[(int)(i*3d + 1d)];
					group[2] = data[(int)(i*3d + 2d)];

					n = CreateNumberFromDecimalString(group);
					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 10d - nstr.stringx.Length;
					for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
						bs[(int)(4d + c + i*10d + offset + j)] = nstr.stringx[(int)(j)];
					}
				}

				if(last == 1d){
					group[0] = '0';
					group[1] = '0';
					group[2] = data[(int)(data.Length - 1d)];
				}

				if(last == 2d){
					group[0] = '0';
					group[1] = data[(int)(data.Length - 2d)];
					group[2] = data[(int)(data.Length - 1d)];
				}

				if(last == 1d || last == 2d){
					n = CreateNumberFromDecimalString(group);
					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = r - nstr.stringx.Length;
					for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
						bs[(int)(bs.Length - r + offset + j)] = nstr.stringx[(int)(j)];
					}
				}

				/* Character count*/
				CreateStringFromNumberWithCheck(d, 2d, nstr);
				offset = 4d + c - nstr.stringx.Length;
				for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
					bs[(int)(offset + j)] = nstr.stringx[(int)(j)];
				}

				/* Mode*/
				mode = QRNumericModeIndicator();
				for(j = 0d; j < 4d; j = j + 1d){
					bs[(int)(j)] = mode[(int)(j)];
				}

				bsReference.stringx = bs;
			}
		}

		return success;
	}


	public static bool QRGetCountLength(double version, char [] modeName, NumberReference cReference, StringReference errorMessage){
		double c;
		bool success;

		success = true;
		c = 0d;

		if(arraysStringsEqual(modeName, "Numeric".ToCharArray())){
			if(version >= 1d && version <= 9d){
				c = 10d;
			}else if(version >= 10d && version <= 26d){
				c = 12d;
			}else if(version >= 27d && version <= 40d){
				c = 14d;
			}else{
				success = false;
				errorMessage.stringx = "Invalid version number.".ToCharArray();
			}
		}else if(arraysStringsEqual(modeName, "Alphanumeric".ToCharArray())){
			if(version >= 1d && version <= 9d){
				c = 9d;
			}else if(version >= 10d && version <= 26d){
				c = 11d;
			}else if(version >= 27d && version <= 40d){
				c = 13d;
			}else{
				success = false;
				errorMessage.stringx = "Invalid version number.".ToCharArray();
			}
		}else if(arraysStringsEqual(modeName, "8-bit Byte".ToCharArray())){
			if(version >= 1d && version <= 9d){
				c = 8d;
			}else if(version >= 10d && version <= 26d){
				c = 16d;
			}else if(version >= 27d && version <= 40d){
				c = 16d;
			}else{
				success = false;
				errorMessage.stringx = "Invalid version number.".ToCharArray();
			}
		}else{
			success = false;
			errorMessage.stringx = "Invalid mode name.".ToCharArray();
		}

		if(success){
			cReference.numberValue = c;
		}

		return success;
	}


	public static char [] QRNumericModeIndicator(){
		return "0001".ToCharArray();
	}


	public static char [] QRAlphanumericModeIndicator(){
		return "0010".ToCharArray();
	}


	public static char [] QRTerminatorModeIndicator(){
		return "0000".ToCharArray();
	}


	public static char [] QR8BitByteModeIndicator(){
		return "0100".ToCharArray();
	}


	public static char [] QRKanjiModeIndicator(){
		return "1000".ToCharArray();
	}


	public static bool QRAlphanumericDataToSegment(char [] data, double version, StringReference bsReference, StringReference errorMessage){
		char [] bs, mode;
		double length, c, d, i, n, j, offset, c0, c1;
		StringReference nstr;
		bool success;
		NumberReference lengthReference, countReference;

		countReference = new NumberReference();
		success = QRGetCountLength(version, "Alphanumeric".ToCharArray(), countReference, errorMessage);

		if(success){
			c = countReference.numberValue;
			d = data.Length;

			lengthReference = new NumberReference();
			success = QRComputeNumberOfCodewords(data.Length, version, "Alphanumeric".ToCharArray(), lengthReference, errorMessage);

			if(success){
				length = lengthReference.numberValue;

				bs = arraysCreateString(length, '0');

				/* Characters*/
				nstr = new StringReference();

				for(i = 0d; i < Floor(d/2d); i = i + 1d){
					c0 = QRAlphanumericToCode(data[(int)(i*2d + 0d)]);
					c1 = QRAlphanumericToCode(data[(int)(i*2d + 1d)]);

					n = c0*45d + c1;

					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 11d - nstr.stringx.Length;
					for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
						bs[(int)(4d + c + i*11d + offset + j)] = nstr.stringx[(int)(j)];
					}
				}

				if(d%2d == 1d){
					n = QRAlphanumericToCode(data[(int)(data.Length - 1d)]);

					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 6d - nstr.stringx.Length;
					for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
						bs[(int)(bs.Length - 6d + offset + j)] = nstr.stringx[(int)(j)];
					}
				}

				/* Character count*/
				CreateStringFromNumberWithCheck(d, 2d, nstr);
				offset = 4d + c - nstr.stringx.Length;
				for(j = 0d; j < nstr.stringx.Length; j = j + 1d){
					bs[(int)(offset + j)] = nstr.stringx[(int)(j)];
				}

				/* Mode*/
				mode = QRAlphanumericModeIndicator();
				for(j = 0d; j < 4d; j = j + 1d){
					bs[(int)(j)] = mode[(int)(j)];
				}

				bsReference.stringx = bs;
			}
		}

		return success;
	}


	public static double [] QRSegmentsToCodeWords(char [] data, double version, char errorCorrectionLevelCode){
		double symbolBits, terminatorLength, d, n, padding, cw, j, r, errorCorrectionLevelNumber;
		double [] codewords, symbolBitsSpec;
		char [] str;
		NumberReference nref;
		StringReference errorMessage;
		bool padSymbol;

		symbolBitsSpec = GetQRSymbolLengthsForVersions();

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode);

		symbolBits = symbolBitsSpec[(int)((version - 1d)*4d + errorCorrectionLevelNumber)];

		terminatorLength = Min(symbolBits - data.Length, 4d);

		d = data.Length + terminatorLength;
		n = Ceiling(d/8d);
		padding = n*8d - d;

		codewords = new double [(int)(Floor(symbolBits/8d))];

		str = new char [8];
		nref = new NumberReference();
		errorMessage = new StringReference();

		for(cw = 0d; cw < Floor(data.Length/8d); cw = cw + 1d){
			str[0] = data[(int)(cw*8d + 0d)];
			str[1] = data[(int)(cw*8d + 1d)];
			str[2] = data[(int)(cw*8d + 2d)];
			str[3] = data[(int)(cw*8d + 3d)];
			str[4] = data[(int)(cw*8d + 4d)];
			str[5] = data[(int)(cw*8d + 5d)];
			str[6] = data[(int)(cw*8d + 6d)];
			str[7] = data[(int)(cw*8d + 7d)];

			CreateNumberFromStringWithCheck(str, 2d, nref, errorMessage);

			codewords[(int)(cw)] = nref.numberValue;
		}

		/* Remaining data, terminator and bit-padding.*/
		r = data.Length%8d;
		if(r != 0d){
			for(j = 0d; j < 8d; j = j + 1d){
				if(j < r){
					str[(int)(j)] = data[(int)(data.Length - r + j)];
				}else{
					str[(int)(j)] = '0';
				}
			}

			CreateNumberFromStringWithCheck(str, 2d, nref, errorMessage);

			codewords[(int)(cw)] = nref.numberValue;
			cw = cw + 1d;
		}

		if(r == 0d && terminatorLength + padding == 8d){
			codewords[(int)(cw)] = 0d;
			cw = cw + 1d;
		}else if(8d - r >= terminatorLength + padding){
		}else{
			codewords[(int)(cw)] = 0d;
			cw = cw + 1d;
		}

		/* Byte Padding*/
		padSymbol = true;
		for(; cw < codewords.Length; cw = cw + 1d){
			if(padSymbol){
				codewords[(int)(cw)] = 236d;
			}else{
				codewords[(int)(cw)] = 17d;
			}
			padSymbol = !padSymbol;
		}

		return codewords;
	}


	public static double [] GetQRSymbolLengthsForVersions(){
		return StringToNumberArray("152, 128, 104, 72, 272, 224, 176, 128, 440, 352, 272, 208, 640, 512, 384, 288, 864, 688, 496, 368, 1088, 864, 608, 480, 1248, 992, 704, 528, 1552, 1232, 880, 688, 1856, 1456, 1056, 800, 2192, 1728, 1232, 976, 2592, 2032, 1440, 1120, 2960, 2320, 1648, 1264, 3424, 2672, 1952, 1440, 3688, 2920, 2088, 1576, 4184, 3320, 2360, 1784, 4712, 3624, 2600, 2024, 5176, 4056, 2936, 2264, 5768, 4504, 3176, 2504, 6360, 5016, 3560, 2728, 6888, 5352, 3880, 3080, 7456, 5712, 4096, 3248, 8048, 6256, 4544, 3536, 8752, 6880, 4912, 3712, 9392, 7312, 5312, 4112, 10208, 8000, 5744, 4304, 10960, 8496, 6032, 4768, 11744, 9024, 6464, 5024, 12248, 9544, 6968, 5288, 13048, 10136, 7288, 5608, 13880, 10984, 7880, 5960, 14744, 11640, 8264, 6344, 15640, 12328, 8920, 6760, 16568, 13048, 9368, 7208, 17528, 13800, 9848, 7688, 18448, 14496, 10288, 7888, 19472, 15312, 10832, 8432, 20528, 15936, 11408, 8768, 21616, 16816, 12016, 9136, 22496, 17728, 12656, 9776, 23648, 18672, 13328, 10208".ToCharArray());
	}


	public static double QREccLetterToNumber(char errorCorrectionLevelCode){
		double errorCorrectionLevelNumber;

		errorCorrectionLevelNumber = 0d;

		if(errorCorrectionLevelCode == 'L'){
			errorCorrectionLevelNumber = 0d;
		}else if(errorCorrectionLevelCode == 'M'){
			errorCorrectionLevelNumber = 1d;
		}else if(errorCorrectionLevelCode == 'Q'){
			errorCorrectionLevelNumber = 2d;
		}else if(errorCorrectionLevelCode == 'H'){
			errorCorrectionLevelNumber = 3d;
		}
		return errorCorrectionLevelNumber;
	}


	public static bool ErGyldigOrgNummerString(char [] orgnummer){
		bool gyldig;
		double [] o;
		double i;

		o = new double [9];

		gyldig = true;

		if(orgnummer.Length == 9d){

			for(i = 0d; i < 9d; i = i + 1d){
				if(cIsNumber(orgnummer[(int)(i)])){
					o[(int)(i)] = cCharacterToDecimalDigit(orgnummer[(int)(i)]);
				}else{
					gyldig = false;
				}
			}

			if(gyldig){
				gyldig = ErGyldigOrgNummer(o);
			}
		}else{
			gyldig = false;
		}

		return gyldig;
	}


	public static bool ErGyldigOrgNummer(double [] o){
		bool gyldig;
		double sum, rest, kontrollsiffer;

		if(o.Length == 9d){
			sum = o[0]*3d + o[1]*2d + o[2]*7d + o[3]*6d + o[4]*5d + o[5]*4d + o[6]*3d + o[7]*2d;
			rest = sum%11d;
			if(rest == 0d){
				kontrollsiffer = 0d;
			}else{
				kontrollsiffer = 11d - rest;
			}

			gyldig = rest != 1d && kontrollsiffer == o[8];
		}else{
			gyldig = false;
		}

		return gyldig;
	}


	public static bool IsValidNorwegianPersonalIdentificationNumber(char [] fnummer, StringReference message){
		bool valid;
		double i, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11;
		double k1, k2;
		DateReference dateRef;

		valid = fnummer.Length == 11d;
		if(valid){
			for(i = 0d; i < fnummer.Length; i = i + 1d){
				if(cIsNumber(fnummer[(int)(i)])){
				}else{
					valid = false;
				}
			}

			if(valid){
				d1 = cCharacterToDecimalDigit(fnummer[0]);
				d2 = cCharacterToDecimalDigit(fnummer[1]);
				d3 = cCharacterToDecimalDigit(fnummer[2]);
				d4 = cCharacterToDecimalDigit(fnummer[3]);
				d5 = cCharacterToDecimalDigit(fnummer[4]);
				d6 = cCharacterToDecimalDigit(fnummer[5]);
				d7 = cCharacterToDecimalDigit(fnummer[6]);
				d8 = cCharacterToDecimalDigit(fnummer[7]);
				d9 = cCharacterToDecimalDigit(fnummer[8]);
				d10 = cCharacterToDecimalDigit(fnummer[9]);
				d11 = cCharacterToDecimalDigit(fnummer[10]);

				dateRef = new DateReference();
				valid = GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message);

				if(valid){
					valid = IsValidDate(dateRef.date, message);
					if(valid){
						k1 = d1*3d + d2*7d + d3*6d + d4*1d + d5*8d + d6*9d + d7*4d + d8*5d + d9*2d;
						k1 = k1%11d;
						if(k1 != 0d){
							k1 = 11d - k1;
						}
						if(k1 == 10d){
							valid = false;
							message.stringx = "Control digit 1 is 10, which is invalid.".ToCharArray();
						}

						if(valid){
							k2 = d1*5d + d2*4d + d3*3d + d4*2d + d5*7d + d6*6d + d7*5d + d8*4d + d9*3d + k1*2d;
							k2 = k2%11d;
							if(k2 != 0d){
								k2 = 11d - k2;
							}
							if(k2 == 10d){
								valid = false;
								message.stringx = "Control digit 2 is 10, which is invalid.".ToCharArray();
							}

							if(valid){
								if(k1 == d10){
									if(k2 == d11){
										valid = true;
									}else{
										valid = false;
										message.stringx = "Check of control digit 2 failed.".ToCharArray();
									}
								}else{
									valid = false;
									message.stringx = "Check of control digit 1 failed.".ToCharArray();
								}
							}
						}
					}else{
						message.stringx = "The date is not a valid date.".ToCharArray();
					}
				}
			}else{
				message.stringx = "Each character must be a decimal digit.".ToCharArray();
			}
		}else{
			message.stringx = "Must be exactly 11 digits long.".ToCharArray();
		}

		return valid;
	}


	public static bool GetDateFromNorwegianPersonalIdentificationNumber(char [] fnummer, DateReference dateRef, StringReference message){
		double individnummer;
		double day, month, year;
		double i, d1, d2, d3, d4, d5, d6, d7, d8, d9;
		bool success;

		dateRef.date = new Date();

		success = fnummer.Length == 11d;
		if(success){
			for(i = 0d; i < fnummer.Length; i = i + 1d){
				if(cIsNumber(fnummer[(int)(i)])){
				}else{
					success = false;
				}
			}

			if(success){
				d1 = cCharacterToDecimalDigit(fnummer[0]);
				d2 = cCharacterToDecimalDigit(fnummer[1]);
				d3 = cCharacterToDecimalDigit(fnummer[2]);
				d4 = cCharacterToDecimalDigit(fnummer[3]);
				d5 = cCharacterToDecimalDigit(fnummer[4]);
				d6 = cCharacterToDecimalDigit(fnummer[5]);
				d7 = cCharacterToDecimalDigit(fnummer[6]);
				d8 = cCharacterToDecimalDigit(fnummer[7]);
				d9 = cCharacterToDecimalDigit(fnummer[8]);

				/* Individnummer*/
				individnummer = d7*100d + d8*10d + d9;

				/* Make date*/
				day = d1*10d + d2;
				month = d3*10d + d4;
				year = d5*10d + d6;

				if(individnummer >= 0d && individnummer <= 499d){
					year = year + 1900d;
				}else if(individnummer >= 500d && individnummer <= 749d && year >= 54d && year <= 99d){
					year = year + 1800d;
				}else if(individnummer >= 900d && individnummer <= 999d && year >= 40d && year <= 99d){
					year = year + 1900d;
				}else if(individnummer >= 500d && individnummer <= 999d && year >= 0d && year <= 39d){
					year = year + 2000d;
				}else{
					success = false;
					message.stringx = "Invalid combination of individnummer and year.".ToCharArray();
				}

				if(success){
					dateRef.date.year = year;
					dateRef.date.month = month;
					dateRef.date.day = day;
				}
			}else{
				message.stringx = "Each character must be a decimal digit.".ToCharArray();
			}
		}else{
			message.stringx = "Must be exactly 11 digits long.".ToCharArray();
		}

		return success;
	}


	public static bool HentKommunenavnFraNummer(char [] kommunenummer, StringReference kommunenavnReference, StringReference errorMessages){
		double nr;
		bool success;
		StringReference [] nummer, kommunenavn;

		kommunenavn = HentKommunenavn();

		nummer = HentGyldigeKommunenummer();
		success = false;

		for(nr = 0d; nr < nummer.Length && !success; nr = nr + 1d){
			if(arraysStringsEqual(nummer[(int)(nr)].stringx, kommunenummer)){
				success = true;
				kommunenavnReference.stringx = kommunenavn[(int)(nr)].stringx;
			}
		}

		if(!success){
			errorMessages.stringx = "Kommunenummer er ikke gyldig.".ToCharArray();
		}

		return success;
	}


	public static bool ErGyldigKommunenummer(char [] kommunenummer){
		bool gyldig;
		double i;
		StringReference [] nummer;

		gyldig = false;

		if(kommunenummer.Length == 4d){
			nummer = HentGyldigeKommunenummer();

			for(i = 0d; i < nummer.Length && !gyldig; i = i + 1d){
				if(arraysStringsEqual(nummer[(int)(i)].stringx, kommunenummer)){
					gyldig = true;
				}
			}
		}

		return gyldig;
	}


	public static StringReference [] HentKommunenavn(){
		StringReference [] kommunenavn;
		char [] kommunenavnliste;

		kommunenavnliste = "\u00c5fjord, Agdenes, \u00c5l, \u00c5lesund, Alstahaug, Alta, Alvdal, \u00c5mli, \u00c5mot, And\u00f8y, \u00c5rdal, Aremark, Arendal, \u00c5s, \u00c5seral, Asker, Askim, Ask\u00f8y, Askvoll, \u00c5snes, Audnedal, Aukra, Aure, Aurland, Aurskog-H\u00f8land, Austevoll, Austrheim, Aver\u00f8y, B\u00e6rum, Balestrand, Ballangen, Balsfjord, Bamble, Bardu, B\u00e5tsfjord, Beiarn, Berg, Bergen, Berlev\u00e5g, Bindal, Birkenes, Bjerkreim, Bjugn, B\u00f8 i Nordland , B\u00f8 i Telemark, Bod\u00f8, Bokn, B\u00f8mlo, Bremanger, Br\u00f8nn\u00f8y, Bygland, Bykle, Deatnu - Tana, Divtasvuodna - Tysfjord, D\u00f8nna, Dovre, Drammen, Drangedal, Dyr\u00f8y, Eid, Eide, Eidfjord, Eidsberg, Eidskog, Eidsvoll, Eigersund, Elverum, Enebakk, Engerdal, Etne, Etnedal, Evenes, Evje og Hornnes, F\u00e6rder, Farsund, Fauske - Fuossko, Fedje, Fet, Finn\u00f8y, Fitjar, Fjaler, Fjell, Fl\u00e5, Flakstad, Flatanger, Flekkefjord, Flesberg, Flora, Folldal, F\u00f8rde, Forsand, Fosnes, Fr\u00e6na, Fredrikstad, Frogn, Froland, Frosta, Fr\u00f8ya, Fusa, Fyresdal, G\u00e1ivuotna - K\u00e5fjord - Kaivuono, Gamvik, Gaular, Gausdal, Gildesk\u00e5l, Giske, Gjemnes, Gjerdrum, Gjerstad, Gjesdal, Gj\u00f8vik, Gloppen, Gol, Gran, Grane, Granvin, Gratangen, Grimstad, Grong, Grue, Gulen, Guovdageaidnu - Kautokeino, H\u00e5, Hadsel, H\u00e6gebostad, Halden, Halsa, Hamar, Hamar\u00f8y - H\u00e1bmer, Hammerfest, Haram, Hareid, Harstad - H\u00e1rstt\u00e1k, Hasvik, Hattfjelldal, Haugesund, Hemne, Hemnes, Hemsedal, Her\u00f8y i  M\u00f8re og Romsdal, Her\u00f8y i Nordland, Hitra, Hjartdal, Hjelmeland, Hob\u00f8l, Hol, Hole, Holmestrand, Holt\u00e5len, Hornindal, Horten, H\u00f8yanger, H\u00f8ylandet, Hurdal, Hurum, Hvaler, Hyllestad, Ibestad, Inder\u00f8y, Indre Fosen, Iveland, Jevnaker, J\u00f8lster, Jondal, K\u00e1r\u00e1\u0161johka - Karasjok, Karls\u00f8y, Karm\u00f8y, Kl\u00e6bu, Klepp, Kongsberg, Kongsvinger, Krager\u00f8, Kristiansand, Kristiansund, Kr\u00f8dsherad, Kv\u00e6fjord, Kv\u00e6nangen, Kvalsund, Kvam, Kvinesdal, Kvinnherad, Kviteseid, Kvits\u00f8y, L\u00e6rdal, Larvik, Lebesby, Leikanger, Leirfjord, Leka, Lenvik, Lesja, Levanger, Lier, Lierne, Lillehammer, Lillesand, Lind\u00e5s, Lindesnes, Loab\u00e1k - Lavangen, L\u00f8dingen, Lom, Loppa, L\u00f8renskog, L\u00f8ten, Lund, Lunner, Lur\u00f8y, Luster, Lyngdal, Lyngen, M\u00e5lselv, Malvik, Mandal, Marker, Marnardal, Masfjorden, M\u00e5s\u00f8y, Meland, Meldal, Melhus, Mel\u00f8y, Mer\u00e5ker, Midsund, Midtre Gauldal, Modalen, Modum, Molde, Moskenes, Moss, N\u00e6r\u00f8y, Namdalseid, Namsos, Namsskogan, Nannestad, Narvik, Naustdal, Nedre Eiker, Nes i Akershus, Nes i Buskerud, Nesna, Nesodden, Nesset, Nissedal, Nittedal, Nome, Nord-Aurdal, Norddal, Nord-Fron, Nordkapp, Nord-Odal, Nordre Land, Nordreisa - R\u00e1isa - Raisi, Nore og Uvdal, Notodden, Odda, \u00d8ksnes, Oppdal, Oppeg\u00e5rd, Orkdal, \u00d8rland, \u00d8rskog, \u00d8rsta, Os i Hedmark, Os i Hordaland, Osen, Oslo, Oster\u00f8y, \u00d8stre Toten, Overhalla, \u00d8vre Eiker, \u00d8yer, \u00d8ygarden, \u00d8ystre Slidre, Porsanger - Pors\u00e1\u014bgu - Porsanki, Porsgrunn, Raarvikhe - R\u00f8yrvik, R\u00e5de, Rad\u00f8y, R\u00e6lingen, Rakkestad, Rana, Randaberg, Rauma, Re, Rendalen, Rennebu, Rennes\u00f8y, Rindal, Ringebu, Ringerike, Ringsaker, Ris\u00f8r, Roan, R\u00f8d\u00f8y, Rollag, R\u00f8mskog, R\u00f8ros, R\u00f8st, R\u00f8yken, Rygge, Salangen, Saltdal, Samnanger, Sande i M\u00f8re og Romsdal, Sande i Vestfold, Sandefjord, Sandnes, Sand\u00f8y, Sarpsborg, Sauda, Sauherad, Sel, Selbu, Selje, Seljord, Sigdal, Siljan, Sirdal, Sk\u00e5nland, Skaun, Skedsmo, Ski, Skien, Skiptvet, Skj\u00e5k, Skjerv\u00f8y, Skodje, Sm\u00f8la, Sn\u00e5ase - Sn\u00e5sa, Snillfjord, Sogndal, S\u00f8gne, Sokndal, Sola, Solund, S\u00f8mna, S\u00f8ndre Land, Songdalen, S\u00f8r-Aurdal, S\u00f8rfold, S\u00f8r-Fron, S\u00f8r-Odal, S\u00f8rreisa, Sortland - Suort\u00e1, S\u00f8rum, S\u00f8r-Varanger, Spydeberg, Stange, Stavanger, Steigen, Steinkjer, Stj\u00f8rdal, Stord, Stordal, Stor-Elvdal, Storfjord - Omasvuotna - Omasvuono, Strand, Stranda, Stryn, Sula, Suldal, Sund, Sunndal, Surnadal, Sveio, Svelvik, Sykkylven, Time, Tingvoll, Tinn, Tjeldsund, Tokke, Tolga, T\u00f8nsberg, Torsken, Tr\u00e6na, Tran\u00f8y, Tr\u00f8gstad, Troms\u00f8, Trondheim , Trysil, Tvedestrand, Tydal, Tynset, Tysnes, Tysv\u00e6r, Ullensaker, Ullensvang, Ulstein, Ulvik, Unj\u00e1rga - Nesseby, Utsira, Vads\u00f8, V\u00e6r\u00f8y, V\u00e5g\u00e5, V\u00e5gan, V\u00e5gs\u00f8y, Vaksdal, V\u00e5ler i Hedmark, V\u00e5ler i \u00d8stfold, Valle, Vang, Vanylven, Vard\u00f8, Vefsn, Vega, Veg\u00e5rshei, Vennesla, Verdal, Verran, Vestby, Vestnes, Vestre Slidre, Vestre Toten, Vestv\u00e5g\u00f8y, Vevelstad, Vik, Vikna, Vindafjord, Vinje, Volda, Voss, ".ToCharArray();

		kommunenavn = strSplitByString(kommunenavnliste, ", ".ToCharArray());

		return kommunenavn;
	}


	public static StringReference [] HentGyldigeKommunenummer(){
		char [] kommunenummerliste;
		StringReference [] kommunenummer;

		kommunenummerliste = "5018, 5016, 0619, 1504, 1820, 2012, 0438, 0929, 0429, 1871, 1424, 0118, 0906, 0214, 1026, 0220, 0124, 1247, 1428, 0425, 1027, 1547, 1576, 1421, 0221, 1244, 1264, 1554, 0219, 1418, 1854, 1933, 0814, 1922, 2028, 1839, 1929, 1201, 2024, 1811, 0928, 1114, 5017, 1867, 0821, 1804, 1145, 1219, 1438, 1813, 0938, 0941, 2025, 1850, 1827, 0511, 0602, 0817, 1926, 1443, 1551, 1232, 0125, 0420, 0237, 1101, 0427, 0229, 0434, 1211, 0541, 1853, 0937, 0729, 1003, 1841, 1265, 0227, 1141, 1222, 1429, 1246, 0615, 1859, 5049, 1004, 0631, 1401, 0439, 1432, 1129, 5048, 1548, 0106, 0215, 0919, 5036, 5014, 1241, 0831, 1940, 2023, 1430, 0522, 1838, 1532, 1557, 0234, 0911, 1122, 0502, 1445, 0617, 0534, 1825, 1234, 1919, 0904, 5045, 0423, 1411, 2011, 1119, 1866, 1034, 0101, 1571, 0403, 1849, 2004, 1534, 1517, 1903, 2015, 1826, 1106, 5011, 1832, 0618, 1515, 1818, 5013, 0827, 1133, 0138, 0620, 0612, 0715, 5026, 1444, 0701, 1416, 5046, 0239, 0628, 0111, 1413, 1917, 5053, 5054, 0935, 0532, 1431, 1227, 2021, 1936, 1149, 5030, 1120, 0604, 0402, 0815, 1001, 1505, 0622, 1911, 1943, 2017, 1238, 1037, 1224, 0829, 1144, 1422, 0712, 2022, 1419, 1822, 5052, 1931, 0512, 5037, 0626, 5042, 0501, 0926, 1263, 1029, 1920, 1851, 0514, 2014, 0230, 0415, 1112, 0533, 1834, 1426, 1032, 1938, 1924, 5031, 1002, 0119, 1021, 1266, 2018, 1256, 5023, 5028, 1837, 5034, 1545, 5027, 1252, 0623, 1502, 1874, 0104, 5051, 5040, 5005, 5044, 0238, 1805, 1433, 0625, 0236, 0616, 1828, 0216, 1543, 0830, 0233, 0819, 0542, 1524, 0516, 2019, 0418, 0538, 1942, 0633, 0807, 1228, 1868, 5021, 0217, 5024, 5015, 1523, 1520, 0441, 1243, 5020, 0301, 1253, 0528, 5047, 0624, 0521, 1259, 0544, 2020, 0805, 5043, 0135, 1260, 0228, 0128, 1833, 1127, 1539, 0716, 0432, 5022, 1142, 5061, 0520, 0605, 0412, 0901, 5019, 1836, 0632, 0121, 5025, 1856, 0627, 0136, 1923, 1840, 1242, 1514, 0713, 0710, 1102, 1546, 0105, 1135, 0822, 0517, 5032, 1441, 0828, 0621, 0811, 1046, 1913, 5029, 0231, 0213, 0806, 0127, 0513, 1941, 1529, 1573, 5041, 5012, 1420, 1018, 1111, 1124, 1412, 1812, 0536, 1017, 0540, 1845, 0519, 0419, 1925, 1870, 0226, 2030, 0123, 0417, 1103, 1848, 5004, 5035, 1221, 1526, 0430, 1939, 1130, 1525, 1449, 1531, 1134, 1245, 1563, 1566, 1216, 0711, 1528, 1121, 1560, 0826, 1852, 0833, 0436, 0704, 1928, 1835, 1927, 0122, 1902, 5001, 0428, 0914, 5033, 0437, 1223, 1146, 0235, 1231, 1516, 1233, 2027, 1151, 2003, 1857, 0515, 1865, 1439, 1251, 0426, 0137, 0940, 0545, 1511, 2002, 1824, 1815, 0912, 1014, 5038, 5039, 0211, 1535, 0543, 0529, 1860, 1816, 1417, 5050, 1160, 0834, 1519, 1235".ToCharArray();

		kommunenummer = strSplitByString(kommunenummerliste, ", ".ToCharArray());

		return kommunenummer;
	}


	public static StringReference [] HentPoststedListe(){
		StringReference [] p, l;
		char [] poststeder;
		double [] nr;
		double i;

		poststeder = "OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, HASLUM, SANDVIKA, FORNEBU, JAR, RUD, H\u00d8VIKODDEN, SLEPENDEN, V\u00d8YENENGA, V\u00d8YENENGA, EIKSMARKA, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, STABEKK, H\u00d8VIK, H\u00d8VIK, LYSAKER, LYSAKER, LYSAKER, LYSAKER, H\u00d8VIK, LOMMEDALEN, FORNEBU, FORNEBU, \u00d8STER\u00c5S, KOLS\u00c5S, RYKKINN, SNAR\u00d8YA, SANDVIKA, SANDVIKA, SANDVIKA, V\u00d8YENENGA, SKUI, SLEPENDEN, GJETTUM, HASLUM, GJETTUM, RYKKINN, RYKKINN, LOMMEDALEN, RUD, KOLS\u00c5S, B\u00c6RUMS VERK, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, JAR, EIKSMARKA, FORNEBU, \u00d8STER\u00c5S, HOSLE, H\u00d8VIK, FORNEBU, BLOMMENHOLM, LYSAKER, SNAR\u00d8YA, STABEKK, STABEKK, ASKER, ASKER, ASKER, BILLINGSTAD, BILLINGSTAD, BILLINGSTAD, NESBRU, NESBRU, HEGGEDAL, VETTRE, ASKER, ASKER, ASKER, ASKER, ASKER, BORGEN, HEGGEDAL, VOLLEN, VOLLEN, VETTRE, VOLLEN, NESBRU, HVALSTAD, BILLINGSTAD, NES\u00d8YA, ASKER, SKI, SKI, SKI, LANGHUS, SIGGERUD, LANGHUS, SKI, VINTERBRO, KR\u00c5KSTAD, SKOTBU, KOLBOTN, KOLBOTN, SOFIEMYR, T\u00c5RN\u00c5SEN, TROLL\u00c5SEN, OPPEG\u00c5RD, OPPEG\u00c5RD, SOFIEMYR, KOLBOTN, OPPEG\u00c5RD, SVARTSKOG, TROLL\u00c5SEN, SIGGERUD, VINTERBRO, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, NESODDTANGEN, NESODDTANGEN, NESODDTANGEN, BJ\u00d8RNEMYR, FAGERSTRAND, NORDRE FROGN, NESODDTANGEN, FAGERSTRAND, FJELLSTRAND, NESODDEN, STR\u00d8MMEN, STR\u00d8MMEN, STR\u00d8MMEN, FINSTADJORDET, RASTA, L\u00d8RENSKOG, L\u00d8RENSKOG, FJELLHAMAR, L\u00d8RENSKOG, L\u00d8RENSKOG, FINSTADJORDET, RASTA, FJELLHAMAR, L\u00d8RENSKOG, KURLAND, SLATTUM, HAGAN, NITTEDAL, HAGAN, HAKADAL, HAKADAL, NITTEDAL, HAKADAL, HAKADAL, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, VESTBY, VESTBY, HVITSTEN, H\u00d8LEN, SON, SON, LARKOLLEN, LARKOLLEN, DILLING, RYGGE, RYGGE, RYGGE, SPERREBOTN, V\u00c5LER I \u00d8STFOLD, SVINNDAL, V\u00c5LER I \u00d8STFOLD, MOSS, MOSS, MOSS, MOSS, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, MANSTAD, MANSTAD, ENGELSVIKEN, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, R\u00c5DE, R\u00c5DE, SALTNES, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, TORP, TORP, TORP, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, SKJ\u00c6RHALDEN, SKJ\u00c6RHALDEN, VESTER\u00d8Y, VESTER\u00d8Y, HERF\u00d8L, NEDG\u00c5RDEN, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, GR\u00c5LUM, GR\u00c5LUM, GR\u00c5LUM, YVEN, GRE\u00c5KER, GRE\u00c5KER, GRE\u00c5KER, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, ISE, HAFSLUNDS\u00d8Y, HAFSLUNDS\u00d8Y, VARTEIG, BORGENHAUGEN, BORGENHAUGEN, BORGENHAUGEN, KLAVESTADHAUGEN, KLAVESTADHAUGEN, SKJEBERG, SKJEBERG, SKJEBERG, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, BERG I \u00d8STFOLD, TISTEDAL, TISTEDAL, TISTEDAL, TISTEDAL, SPONVIKA, KORNSJ\u00d8, AREMARK, AREMARK, ASKIM, ASKIM, ASKIM, SPYDEBERG, TOMTER, SKIPTVET, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, SKIPTVET, SPYDEBERG, SPYDEBERG, KNAPSTAD, TOMTER, HOB\u00d8L, ASKIM, ASKIM, ASKIM, ASKIM, MYSEN, MYSEN, MYSEN, SLITU, TR\u00d8GSTAD, TR\u00d8GSTAD, B\u00c5STAD, B\u00c5STAD, \u00d8RJE, \u00d8RJE, OTTEID, H\u00c6RLAND, EIDSBERG, RAKKESTAD, RAKKESTAD, DEGERNES, DEGERNES, RAKKESTAD, FETSUND, FETSUND, GAN, ENEBAKKNESET, FLATEBY, ENEBAKK, YTRE ENEBAKK, FLATEBY, YTRE ENEBAKK, S\u00d8RUMSAND, S\u00d8RUMSAND, S\u00d8RUM, S\u00d8RUM, BLAKER, BLAKER, R\u00c5N\u00c5SFOSS, AULI, AULI, AURSKOG, AURSKOG, BJ\u00d8RKELANGEN, BJ\u00d8RKELANGEN, R\u00d8MSKOG, SETSKOG, L\u00d8KEN, L\u00d8KEN, FOSSER, HEMNES, HEMNES, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, R\u00c6LINGEN, L\u00d8VENSTAD, KJELLER, FJERDINGBY, NORDBY, STR\u00d8MMEN, STR\u00d8MMEN, LILLESTR\u00d8M, SKJETTEN, BLYSTADLIA, LEIRSUND, FROGNER, FROGNER, L\u00d8VENSTAD, SKEDSMOKORSET, SKEDSMOKORSET, SKEDSMOKORSET, GJERDRUM, SKEDSMOKORSET, GJERDRUM, FJERDINGBY, SKJETTEN, KJELLER, LILLESTR\u00d8M, R\u00c6LINGEN, NANNESTAD, NANNESTAD, MAURA, \u00c5SGREINA, HOLTER, HOLTER, MAURA, KL\u00d8FTA, KL\u00d8FTA, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, MOGREINA, NORDKISA, ALGARHEIM, JESSHEIM, SESSVOLLMOEN, GARDERMOEN, GARDERMOEN, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, R\u00c5HOLT, R\u00c5HOLT, DAL, B\u00d8N, EIDSVOLL VERK, DAL, EIDSVOLL, EIDSVOLL, HURDAL, HURDAL, MINNESUND, FEIRING, MINNESUND, SKARNES, SKARNES, SL\u00c5STAD, DISEN\u00c5, SANDER, SAGSTUA, SAGSTUA, BRUVOLL, KNAPPER, GARDVIK, GARDVIK, AUSTVATN, \u00c5RNES, \u00c5RNES, VORMSUND, VORMSUND, BR\u00c5RUD, SKOGBYGDA, SKOGBYGDA, HVAM, OPPAKER, HVAM, FENSTAD, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, GRANLI, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, ROVERUD, ROVERUD, HOKK\u00c5SEN, LUNDERS\u00c6TER, BRANDVAL, \u00c5BOGEN, GALTERUD, AUSTMARKA, KONGSVINGER, KONGSVINGER, AUSTMARKA, SKOTTERUD, SKOTTERUD, TOB\u00d8L, VESTMARKA, MATRAND, MAGNOR, MAGNOR, GRUE FINNSKOG, GRUE FINNSKOG, KIRKEN\u00c6R, KIRKEN\u00c6R, GRINDER, NAMN\u00c5, ARNEBERG, FLISA, FLISA, GJES\u00c5SEN, \u00c5SNES FINNSKOG, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, OTTESTAD, OTTESTAD, OTTESTAD, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, FURNES, HAMAR, RIDABU, INGEBERG, VANG P\u00c5 HEDMARKEN, HAMAR, HAMAR, FURNES, RIDABU, VANG P\u00c5 HEDMARKEN, VALLSET, VALLSET, \u00c5SVANG, ROMEDAL, ROMEDAL, STANGE, STANGE, TANGEN, ESPA, TANGEN, L\u00d8TEN, L\u00d8TEN, ILSENG, \u00c5DALSBRUK, ILSENG, NES P\u00c5 HEDMARKEN, NES P\u00c5 HEDMARKEN, STAVSJ\u00d8, GAUPEN, RUDSH\u00d8GDA, RUDSH\u00d8GDA, N\u00c6ROSET, \u00c5SMARKA, BR\u00d8TTUM, BR\u00d8TTUM, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, MOELV, MOELV, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, HERNES, ELVERUM, S\u00d8RSKOGBYGDA, ELVERUM, ELVERUM, HERADSBYGD, J\u00d8MNA, ELVERUM, ELVERUM, ELVERUM, TRYSIL, TRYSIL, NYBERGSUND, \u00d8STBY, \u00d8STBY, LJ\u00d8RDALEN, LJ\u00d8RDALEN, PLASSEN, S\u00d8RE OSEN, T\u00d8RBERGET, JORDET, SLETT\u00c5S, BRASKEREIDFOSS, BRASKEREIDFOSS, V\u00c5LER I SOL\u00d8R, HASLEMOEN, GRAVBERGET, V\u00c5LER I SOL\u00d8R, ENGERDAL, ENGERDAL, HERADSBYGD, DREVSJ\u00d8, DREVSJ\u00d8, ELG\u00c5, S\u00d8RE OSEN, S\u00d8M\u00c5DALEN, RENA, RENA, OSEN, OSEN, ATNA, SOLLIA, HANESTAD, KOPPANG, KOPPANG, RENDALEN, RENDALEN, RENDALEN, RENDALEN, RENDALEN, TYNSET, TYNSET, TYLLDALEN, KVIKNE, KVIKNE, TOLGA, TOLGA, VINGELEN, \u00d8VERSJ\u00d8DALEN, OS I \u00d8STERDALEN, OS I \u00d8STERDALEN, DALSBYGDA, TUFSINGDALEN, ALVDAL, ALVDAL, FOLLDAL, FOLLDAL, GRIMSBU, DALHOLEN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, VINGROM, LILLEHAMMER, LILLEHAMMER, MESNALI, LILLEHAMMER, SJUSJ\u00d8EN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LISMARKA, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, MESNALI, VINGROM, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, F\u00c5BERG, LILLEHAMMER, F\u00c5BERG, SJUSJ\u00d8EN, LILLEHAMMER, RINGEBU, RINGEBU, VENABYGD, F\u00c5VANG, F\u00c5VANG, TRETTEN, \u00d8YER, \u00d8YER, TRETTEN, VINSTRA, VINSTRA, KVAM, KVAM, SK\u00c5BU, SK\u00c5BU, S\u00d8R-FRON, G\u00c5L\u00c5, S\u00d8R-FRON, S\u00d8R-FRON, \u00d8STRE GAUSDAL, \u00d8STRE GAUSDAL, SVINGVOLL, VESTRE GAUSDAL, VESTRE GAUSDAL, FOLLEBU, SVATSUM, ESPEDALEN, DOMB\u00c5S, DOMB\u00c5S, HJERKINN, DOVRE, DOVRESKOGEN, DOVRE, LESJA, LORA, LESJAVERK, LESJASKOG, BJORLI, OTTA, LESJA, SEL, H\u00d8VRINGEN, MYSUS\u00c6TER, OTTA, HEIDAL, NEDRE HEIDAL, SEL, HEIDAL, V\u00c5G\u00c5, LALM, LALM, TESSANDEN, V\u00c5G\u00c5, GARMO, LOM, B\u00d8VERDALEN, LOM, SKJ\u00c5K, NORDBERG, SKJ\u00c5K, GROTLI, GRAN, BRANDBU, ROA, JAREN, LUNNER, HARESTUA, GRUA, BRANDBU, GRINDVOLL, LUNNER, ROA, GRUA, HARESTUA, GRAN, BRANDBU, JAREN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, NORDRE TOTEN, GJ\u00d8VIK, BYBRUA, GJ\u00d8VIK, HUNNDALEN, RAUFOSS, RAUFOSS, BIRI, RAUFOSS, RAUFOSS, RAUFOSS, BIRI, BIRISTRAND, SNERTINGDAL, \u00d8VRE SNERTINGDAL, REINSVOLL, SNERTINGDAL, EINA, KOLBU, B\u00d8VERBRU, B\u00d8VERBRU, KOLBU, SKREIA, KAPP, LENA, LENA, REINSVOLL, EINA, SKREIA, KAPP, HOV, LAND\u00c5SBYGDA, FLUBERG, FALL, ENGER, HOV, DOKKA, ODNES, NORD-TORPA, AUST-TORPA, DOKKA, ETNEDAL, ETNEDAL, FAGERNES, FAGERNES, LEIRA I VALDRES, AURDAL, AURDAL, SKRAUTV\u00c5L, ULNES, LEIRA I VALDRES, TISLEIDALEN, BAGN, BAGN, REINLI, BEGNADALEN, BEGNA, HEGGENES, HEGGENES, ROGNE, SKAMMESTEIN, BEITO, BEITOST\u00d8LEN, BEITOST\u00d8LEN, R\u00d8N, R\u00d8N, SLIDRE, SLIDRE, LOMEN, RYFOSS, RYFOSS, VANG I VALDRES, VANG I VALDRES, \u00d8YE, TYINKRYSSET, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, MJ\u00d8NDALEN, MJ\u00d8NDALEN, STEINBERG, KROKSTADELVA, KROKSTADELVA, SOLBERGELVA, SOLBERGELVA, SOLBERGMOEN, SVELVIK, SVELVIK, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, BERGER, SANDE I VESTFOLD, SANDE I VESTFOLD, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOF, HOF, SUNDBYFOSS, EIDSFOSS, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, SEM, VEAR, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, HUS\u00d8YSUND, HUS\u00d8YSUND, DUKEN, T\u00d8NSBERG, TOR\u00d8D, TOR\u00d8D, SKALLESTAD, SKALLESTAD, N\u00d8TTER\u00d8Y, KJ\u00d8PMANNSKJ\u00c6R, VESTSKOGEN, KJ\u00d8PMANNSKJ\u00c6R, VEIERLAND, TJ\u00d8ME, HVASSER, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, MELSOMVIK, BARK\u00c5KER, ANDEBU, MELSOMVIK, STOKKE, STOKKE, ANDEBU, N\u00d8TTER\u00d8Y, REVETAL, TJ\u00d8ME, TOLVSR\u00d8D, \u00c5SG\u00c5RDSTRAND, MELSOMVIK, STOKKE, SEM, SEM, VEAR, VEAR, REVETAL, RAMNES, UNDRUMSDAL, V\u00c5LE, V\u00c5LE, \u00c5SG\u00c5RDSTRAND, NYKIRKE, HORTEN, HORTEN, HORTEN, BORRE, SKOPPUM, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, SKOPPUM, HORTEN, NYKIRKE, BORRE, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, KODAL, SANDEFJORD, KODAL, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, SVARSTAD, SVARSTAD, STEINSHOLT, TJODALYNG, TJODALYNG, KVELDE, KVELDE, LARVIK, STAVERN, STAVERN, STAVERN, STAVERN, HELGEROA, NEVLUNGHAVN, HELGEROA, HOKKSUND, HOKKSUND, HOKKSUND, HOKKSUND, VESTFOSSEN, VESTFOSSEN, FISKUM, SKOTSELV, SKOTSELV, \u00c5MOT, \u00c5MOT, \u00c5MOT, PRESTFOSS, PRESTFOSS, SOLUMSMOEN, EGGEDAL, NEDRE EGGEDAL, EGGEDAL, GEITHUS, GEITHUS, VIKERSUND, VIKERSUND, LIER, LIER, LIER, LIER, LIER, TRANBY, TRANBY, TRANBY, TRANBY, SYLLING, SYLLING, LIERSTRANDA, LIER, LIERSTRANDA, LIERSKOGEN, LIERSKOGEN, REISTAD, GULLAUG, GULLAUG, GULLAUG, SPIKKESTAD, SPIKKESTAD, R\u00d8YKEN, R\u00d8YKEN, HYGGEN, SLEMMESTAD, SLEMMESTAD, B\u00d8DALEN, \u00c5ROS, S\u00c6TRE, S\u00c6TRE, B\u00c5TST\u00d8, N\u00c6RSNES, N\u00c6RSNES, FILTVET, TOFTE, TOFTE, KANA, HOLMSBU, FILTVET, KLOKKARSTUA, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, JEVNAKER, JEVNAKER, BJONEROA, NES I \u00c5DAL, NES I \u00c5DAL, HALLINGBY, HALLINGBY, BJONEROA, HEDALEN, R\u00d8YSE, R\u00d8YSE, KROKKLEIVA, TYRISTRAND, TYRISTRAND, SOKNA, KR\u00d8DEREN, NORESUND, KR\u00d8DEREN, SOLLIH\u00d8GDA, FL\u00c5, NESBYEN, NESBYEN, NORESUND, TUNHOVD, FL\u00c5, GOL, GOL, HEMSEDAL, HEMSEDAL, \u00c5L, \u00c5L, HOL, HOL, HOVET, TORPO, GEILO, GEILO, DAGALI, USTAOSET, HAUGAST\u00d8L, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, HEISTADMOEN, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, SKOLLENBORG, SKOLLENBORG, FLESBERG, LAMPELAND, SVENE, LAMPELAND, LYNGDAL I NUMEDAL, SKOLLENBORG, ROLLAG, VEGGLI, VEGGLI, NORE, R\u00d8DBERG, R\u00d8DBERG, UVDAL, NORE, HVITTINGFOSS, HVITTINGFOSS, PASSEBEKK, TINN AUSTBYGD, HOVIN I TELEMARK, ATR\u00c5, MILAND, RJUKAN, RJUKAN, SAULAND, ATR\u00c5, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, HJARTDAL, GRANSHERAD, SAULAND, TUDDAL, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SILJAN, SILJAN, DRANGEDAL, T\u00d8RDAL, NESLANDSVATN, SANNIDAL, KRAGER\u00d8, KRAGER\u00d8, SK\u00c5T\u00d8Y, JOMFRULAND, KRAGER\u00d8 SKJ\u00c6RG\u00c5RD, SKIEN, SKIEN, STABBESTAD, KRAGER\u00d8, HELLE, KRAGER\u00d8, SKIEN, SANNIDAL, HELLE, DRANGEDAL, SKIEN, SKIEN, SKIEN, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, GVARV, H\u00d8RTE, AKKERHAUGEN, NORDAGUTU, LUNDE, ULEFOSS, ULEFOSS, LUNDE, B\u00d8 I TELEMARK, GVARV, SELJORD, KVITESEID, SELJORD, FLATDAL, \u00c5MOTSDAL, MORGEDAL, VR\u00c5LIOSEN, KVITESEID, VR\u00c5DAL, VR\u00c5DAL, NISSEDAL, TREUNGEN, RAULAND, FYRESDAL, DALEN, \u00c5MDALS VERK, TREUNGEN, RAULAND, FYRESDAL, DALEN, VINJE, EDLAND, VINJE, H\u00d8YDALSMO, VINJESVINGEN, EDLAND, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, LANGANGEN, PORSGRUNN, PORSGRUNN, BREVIK, STATHELLE, STATHELLE, STATHELLE, HERRE, STATHELLE, STATHELLE, LANGESUND, BREVIK, LANGESUND, LANGESUND, STATHELLE, PORSGRUNN, PORSGRUNN, PORSGRUNN, HERRE, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, SOLA, SOLA, R\u00d8YNEBERG, R\u00c6GE, TJELTA, SOLA, TANANGER, TANANGER, TANANGER, R\u00d8YNEBERG, TJELTA, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, RANDABERG, RANDABERG, RANDABERG, VASS\u00d8Y, HUNDV\u00c5G, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HUNDV\u00c5G, STAVANGER, HUNDV\u00c5G, HUNDV\u00c5G, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, SOLA, TANANGER, STAVANGER, J\u00d8RPELAND, IDSE, FORSAND, FORSAND, TAU, S\u00d8R-HIDLE, TAU, J\u00d8RPELAND, LYSEBOTN, FL\u00d8YRLI, SONGESAND, HJELMELAND, J\u00d8SENFJORDEN, \u00c5RDAL I RYFYLKE, FISTER, SKIFTUN, HJELMELAND, RENNES\u00d8Y, VESTRE \u00c5M\u00d8Y, BRIMSE, AUSTRE \u00c5M\u00d8Y, MOSTER\u00d8Y, BRU, RENNES\u00d8Y, FINN\u00d8Y, FINN\u00d8Y, TALGJE, FOGN, HELG\u00d8Y I RYFYLKE, BYRE, S\u00d8RBOKN, SJERNAR\u00d8Y, NORD-HIDLE, SJERNAR\u00d8Y, KVITS\u00d8Y, KVITS\u00d8Y, SKARTVEIT, OMBO, FOLD\u00d8Y, SAUDA, SAUDA, SAUDASJ\u00d8EN, VANVIK, SAND, ERFJORD, JELSA, HEBNES, SULDALSOSEN, SAND, SULDALSOSEN, NESFLATEN, KOPERVIK, TORVASTAD, AVALDSNES, KVALAV\u00c5G, H\u00c5VIK, \u00c5KREHAMN, SANDVE, STOL, S\u00c6VELANDSVIK, VEAV\u00c5GEN, SKUDENESHAVN, KOPERVIK, KOPERVIK, VEAV\u00c5GEN, \u00c5KREHAMN, SKUDENESHAVN, TORVASTAD, AVALDSNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, FIGGJO, OLTEDAL, DIRDAL, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, BRYNE, BRYNE, UNDHEIM, ORRE, BRYNE, BRYNE, BRYNE, LYE, LYE, BRYNE, KLEPPE, KLEPP STASJON, VOLL, KVERNALAND, KVERNALAND, KLEPP STASJON, KLEPPE, VARHAUG, SIREV\u00c5G, VIGRESTAD, BRUSAND, SIREV\u00c5G, N\u00c6RB\u00d8, N\u00c6RB\u00d8, VARHAUG, VIGRESTAD, EGERSUND, EGERSUND, EGERSUND, EGERSUND, EGERSUND, HELLVIK, HELLELAND, EGERSUND, EGERSUND, HAUGE I DALANE, HAUGE I DALANE, VIKES\u00c5, HELLELAND, BJERKREIM, VIKES\u00c5, OLTEDAL, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, \u00c5NA-SIRA, HIDRASUND, ANDABEL\u00d8Y, GYLAND, SIRA, SIRA, TONSTAD, TONSTAD, TJ\u00d8RHOM, MOI, HOVSHERAD, UALAND, MOI, KVINLOG, KVINESDAL, \u00d8YESTRANDA, FEDA, KVINESDAL, KVINESDAL, KVINESDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, HOLUM, LINDESNES, LINDESNES, LINDESNES, LINDESNES, LINDESNES, KONSMO, KONSMO, KOLLUNGTVEIT, BYREMO, \u00d8YSLEB\u00d8, MARNARDAL, MARNARDAL, BJELLAND, \u00c5SERAL, \u00c5SERAL, FOSSDAL, FARSUND, FARSUND, FARSUND, FARSUND, FARSUND, VANSE, VANSE, VANSE, BORHAUG, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, KORSHAMN, KV\u00c5S, SNARTEMO, TINGVATN, EIKEN, EIKEN, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KARDEMOMME BY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, MOSBY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, NODELAND, FINSLAND, BRENN\u00c5SEN, FINSLAND, HAMRESANDEN, KJEVIK, TVEIT, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, BRENN\u00c5SEN, NODELAND, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, TVEIT, VENNESLA, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, H\u00c6GELAND, H\u00c6GELAND, IVELAND, IVELAND, VATNESTR\u00d8M, EVJE, EVJE, EVJE, HORNNES, BYGLANDSFJORD, GRENDI, BYGLAND, BYGLAND, VALLE, VALLE, RYSSTAD, RYSSTAD, BYKLE, HOVDEN I SETESDAL, HOVDEN I SETESDAL, BIRKELAND, HEREFOSS, ENGESLAND, H\u00d8V\u00c5G, BREKKEST\u00d8, LILLESAND, LILLESAND, LILLESAND, H\u00d8V\u00c5G, LILLESAND, BIRKELAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, KONGSHAVN, SALTR\u00d8D, KOLBJ\u00d8RNSVIK, HIS, F\u00c6RVIK, FROLAND, RYKENE, RYKENE, NEDENES, BJORBEKK, ARENDAL, FROLANDS VERK, MJ\u00c5VATN, HYNNEKLEIV, MYKLAND, RISDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, SALTR\u00d8D, F\u00c6RVIK, HIS, NEDENES, FROLAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, NELAUG, \u00c5MLI, \u00c5MLI, SEL\u00c5SVATN, D\u00d8LEMO, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, HOMBORSUND, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, TVEDESTRAND, TVEDESTRAND, TVEDESTRAND, SONGE, LYNG\u00d8R, GJEVING, VESTRE SAND\u00d8YA, BOR\u00d8Y, STAUB\u00d8, STAUB\u00d8, NES VERK, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, SUNDEBRU, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, SUNDEBRU, AKLAND, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, EIDSV\u00c5GNESET, EIDSV\u00c5G I \u00c5SANE, EIDSV\u00c5G I \u00c5SANE, \u00d8VRE ERVIK, SALHUS, HORDVIK, HYLKJE, BREISTEIN, TERTNES, TERTNES, ULSET, ULSET, ULSET, ULSET, ULSET, ULSET, MORVIK, MORVIK, NYBORG, NYBORG, NYBORG, FLAKTVEIT, FLAKTVEIT, MJ\u00d8LKER\u00c5EN, MJ\u00d8LKER\u00c5EN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, STRAUMSGREND, B\u00d8NES, B\u00d8NES, B\u00d8NES, B\u00d8NES, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, BJ\u00d8RNDALSTR\u00c6, LODDEFJORD, LODDEFJORD, LODDEFJORD, MATHOPEN, LODDEFJORD, BJ\u00d8R\u00d8YHAMN, LODDEFJORD, GODVIK, OLSVIK, OLSVIK, OS, OS, OS, OS, OS, S\u00d8FTELAND, OS, OS, OS, OS, S\u00d8FTELAND, LEPS\u00d8Y, LYSEKLOSTER, LYSEKLOSTER, LEPS\u00d8Y, HAGAVIK, NORDSTR\u00d8NO, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, KALANDSEIDET, PARADIS, PARADIS, PARADIS, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, FANA, FANA, S\u00d8REIDGREND, S\u00d8REIDGREND, SANDSLI, SANDSLI, KOKSTAD, BLOMSTERDALEN, HJELLESTAD, INDRE ARNA, INDRE ARNA, ARNATVEIT, TRENGEREID, GARNES, YTRE ARNA, ESPELAND, HAUKELAND, VALESTRANDSFOSSEN, LONEV\u00c5G, FOTLANDSV\u00c5G, TYSSEBOTNEN, BRUVIK, HAUS, VALESTRANDSFOSSEN, LONEV\u00c5G, HAUS, KLEPPEST\u00d8, KLEPPEST\u00d8, STRUSSHAMN, FOLLESE, HETLEVIK, FLORV\u00c5G, ERDAL, ASK, KLEPPEST\u00d8, KLEPPEST\u00d8, HAUGLANDSHELLA, KJERRGARDEN, KJERRGARDEN, HERDLA, STRUSSHAMN, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, FOLLESE, ASK, HAUGLANDSHELLA, FLORV\u00c5G, RONG, TJELDST\u00d8, HELLES\u00d8Y, HERNAR, TJELDST\u00d8, RONG, STRAUME, STRAUME, STRAUME, KNARREVIK, \u00c5GOTNES, \u00c5GOTNES, BRATTHOLMEN, STRAUME, STRAUME, KNARREVIK, FJELL, FJELL, KOLLTVEIT, \u00c5GOTNES, TUR\u00d8Y, MISJE, SKOGSV\u00c5G, STEINSLAND, KLOKKARVIK, STEINSLAND, T\u00c6LAV\u00c5G, GLESV\u00c6R, SKOGSV\u00c5G, TORANGSV\u00c5G, BAKKASUND, M\u00d8KSTER, LITLAKALS\u00d8Y, STOREB\u00d8, STOREB\u00d8, KOLBEINSVIK, VESTRE VINNESV\u00c5G, BEKKJARVIK, STOLMEN, BEKKJARVIK, STORD, STORD, STORD, STORD, STORD, STORD, SAGV\u00c5G, STORD, SAGV\u00c5G, STORD, STORD, HUGLO, STORD, STORD, STORD, STORD, FITJAR, FITJAR, RUBBESTADNESET, BRANDASUND, URANGSV\u00c5G, FOLDR\u00d8YHAMN, BREMNES, FINN\u00c5S, MOSTERHAMN, B\u00d8MLO, ESPEV\u00c6R, BREMNES, MOSTERHAMN, B\u00d8MLO, SUNDE I SUNNHORDLAND, VALEN, SANDVOLL, UT\u00c5KER, S\u00c6B\u00d8VIK, HALSN\u00d8Y KLOSTER, H\u00d8YLANDSBYGD, ARNAVIK, FJELBERG, HUSNES, HER\u00d8YSUNDET, USKEDALEN, DIMMELSVIK, USKEDALEN, ROSENDAL, SEIMSFOSS, SNILSTVEIT\u00d8Y, L\u00d8FALLSTRAND, \u00c6NES, MAURANGER, HUSNES, S\u00c6B\u00d8VIK, ROSENDAL, MATRE, \u00c5KRA, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KARMSUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KOLNES, KARMSUND, VORMEDAL, VORMEDAL, R\u00d8YKSUND, UTSIRA, FE\u00d8Y, R\u00d8V\u00c6R, SVEIO, AUKLANDSHAMN, VALEV\u00c5G, F\u00d8RDE I HORDALAND, F\u00d8RDE I HORDALAND, SVEIO, NEDSTRAND, BOKN, NEDSTRAND, F\u00d8RRESFJORDEN, TYSV\u00c6RV\u00c5G, HERVIK, SKJOLDASTRAUMEN, VIKEBYGD, BOKN, AKSDAL, SKJOLD, AKSDAL, \u00d8VRE VATS, NEDRE VATS, \u00d8LEN, \u00d8LENSV\u00c5G, VIKEDAL, BJOA, SANDEID, VIKEDAL, \u00d8LEN, SANDEID, ETNE, ETNE, SK\u00c5NEVIK, SK\u00c5NEVIK, F\u00d8RRESFJORDEN, MARKHUS, FJ\u00c6RA, NORHEIMSUND, NORHEIMSUND, NORHEIMSUND, \u00d8YSTESE, \u00c5LVIK, \u00d8YSTESE, STEINST\u00d8, \u00c5LVIK, T\u00d8RVIKBYGD, KYSNESSTRAND, JONDAL, HERAND, JONDAL, STRANDEBARM, STRANDEBARM, OMASTRAND, OMASTRAND, HATLESTRAND, VARALDS\u00d8Y, \u00d8LVE, EIKELANDSOSEN, FUSA, HOLMEFJORD, STRANDVIK, S\u00c6VAREID, S\u00c6VAREID, NORDTVEITGREND, BALDERSHEIM, FUSA, EIKELANDSOSEN, TYSSE, TYSSE, \u00c5RLAND, \u00c5RLAND, TYSNES, REKSTEREN, UGGDAL, FLATR\u00c5KER, LUNDEGREND, \u00c5RBAKKA, ONARHEIM, UGGDAL, TYSNES, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, EVANGER, VOSS, VOSS, SKULESTADMO, SKULESTADMO, VOSSESTRAND, VOSSESTRAND, VOSS, STALHEIM, MYRDAL, FINSE, STANGHELLE, DALEKVAM, DALEKVAM, BOLSTAD\u00d8YRI, STANGHELLE, VAKSDAL, VAKSDAL, STAMNES, EIDSLANDET, MODALEN, ULVIK, ULVIK, MODALEN, GRANVIN, VALLAVIK, GRANVIN, AURLAND, FL\u00c5M, FL\u00c5M, AURLAND, UNDREDAL, GUDVANGEN, STYVI, ODDA, ODDA, ODDA, R\u00d8LDAL, SKARE, TYSSEDAL, HOVLAND, N\u00c5, N\u00c5, GRIMO, UTNE, UTNE, KINSARVIK, LOFTHUS, KINSARVIK, EIDFJORD, \u00d8VRE EIDFJORD, V\u00d8RINGSFOSS, EIDFJORD, LOFTHUS, KINSARVIK, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, ISDALST\u00d8, ISDALST\u00d8, ISDALST\u00d8, FREKHAUG, ALVERSUND, ISDALST\u00d8, ALVERSUND, SEIM, EIKANGERV\u00c5G, ISDALST\u00d8, HJELM\u00c5S, ISDALST\u00d8, ROSSLAND, FREKHAUG, FREKHAUG, MANGER, B\u00d8V\u00c5GEN, MANGER, B\u00d8V\u00c5GEN, S\u00c6B\u00d8V\u00c5GEN, SLETTA, AUSTRHEIM, AUSTRHEIM, FEDJE, FEDJE, LIND\u00c5S, FONNES, FONNES, MONGSTAD, LIND\u00c5S, HUNDVIN, MYKING, DALS\u00d8YRA, BREKKE, BJORDAL, DALS\u00d8YRA, BREKKE, BJORDAL, EIVINDVIK, EIVINDVIK, BYRKNES\u00d8Y, \u00c5NNELAND, MJ\u00d8MNA, BYRKNES\u00d8Y, MASFJORDNES, MASFJORDNES, HAUGSV\u00c6R, MATREDAL, HAUGSV\u00c6R, HOSTELAND, HOSTELAND, OSTEREIDET, OSTEREIDET, VIKANES, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, LANGEV\u00c5G, EIDSNES, FISKARSTRAND, MAUSEIDV\u00c5G, EIDSNES, FISKARSTRAND, LANGEV\u00c5G, VIGRA, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, VALDER\u00d8YA, VALDER\u00d8YA, GISKE, GOD\u00d8YA, GOD\u00d8YA, ELLINGS\u00d8Y, VALDER\u00d8YA, VIGRA, HAREID, BRANDAL, HJ\u00d8RUNGAV\u00c5G, HADDAL, ULSTEINVIK, ULSTEINVIK, EIKSUND, HAREID, TJ\u00d8RV\u00c5G, MOLTUSTRANDA, MOLTUSTRANDA, GJERDSVIKA, GURSK\u00d8Y, GURSK\u00d8Y, GURSKEN, GJERDSVIKA, LARSNES, LARSNES, KVAMS\u00d8Y, KVAMS\u00d8Y, SANDSHAMN, SANDSHAMN, FOSNAV\u00c5G, FOSNAV\u00c5G, FOSNAV\u00c5G, LEIN\u00d8Y, B\u00d8LANDET, RUNDE, NERLANDS\u00d8Y, FOSNAV\u00c5G, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, AUSTEFJORDEN, FOLKESTAD, LAUVSTAD, LAUVSTAD, SYVDE, FISK\u00c5, SYVDE, ROVDE, EIDS\u00c5, FISK\u00c5, SYLTE, \u00c5HEIM, \u00c5HEIM, \u00c5RAM, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, HOVDEBYGDA, HOVDEBYGDA, S\u00c6B\u00d8, S\u00c6B\u00d8, VARTDAL, VARTDAL, BARSTADVIK, TRANDAL, STORESTANDAL, BJ\u00d8RKE, NORANGSFJORDEN, STRANDA, STRANDA, VALLDAL, VALLDAL, LIABYGDA, TAFJORD, NORDDAL, EIDSDAL, GEIRANGER, GEIRANGER, HELLESYLT, HELLESYLT, STRAUMGJERDE, IKORNNES, IKORNNES, HUNDEIDVIK, SYKKYLVEN, STRAUMGJERDE, SYKKYLVEN, \u00d8RSKOG, \u00d8RSKOG, STORDAL, EIDSDAL, STORDAL, SKODJE, SKODJE, TENNFJORD, VATNE, BRATTV\u00c5G, HILDRE, S\u00d8VIK, S\u00d8VIK, BRATTV\u00c5G, VATNE, STOREKALV\u00d8Y, HARAMS\u00d8Y, HARAMS\u00d8Y, KJERSTAD, LONGVA, FJ\u00d8RTOFT, \u00c5NDALSNES, \u00c5NDALSNES, VEBLUNGSNES, INNFJORDEN, ISFJORDEN, VERMA, VERMA, ISFJORDEN, EIDSBYGDA, \u00c5FARNES, \u00c5FARNES, MITTET, VISTDAL, VISTDAL, M\u00c5NDALEN, M\u00c5NDALEN, V\u00c5GSTRANDA, V\u00c5GSTRANDA, FIKSDAL, VESTNES, TRESFJORD, VIKEBUKT, TOMREFJORD, FIKSDAL, REKDAL, VIKEBUKT, TRESFJORD, TOMREFJORD, VESTNES, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, AUREOSEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, SEKKEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, BUD, BUD, HUSTAD, MOLDE, MOLDE, MOLDE, ELNESV\u00c5GEN, TORNES I ROMSDAL, FARSTAD, MALMEFJORDEN, FARSTAD, ELNESV\u00c5GEN, HJELSET, KLEIVE, KLEIVE, HJELSET, KORTGARDEN, SK\u00c5LA, BOLS\u00d8YA, SK\u00c5LA, EIDSV\u00c5G I ROMSDAL, EIDSV\u00c5G I ROMSDAL, RAUDSAND, ERESFJORD, ERESFJORD, EIKESDAL, MIDSUND, MIDSUND, AUKRA, AUKRA, ONA, SAND\u00d8Y, HAR\u00d8Y, ORTEN, HAR\u00d8Y, MYKLEBOST, EIDE, LYNGSTAD, VEVANG, EIDE, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, SM\u00d8LA, SM\u00d8LA, TUSTNA, TUSTNA, SUNNDALS\u00d8RA, SUNNDALS\u00d8RA, \u00d8KSENDAL, FURUGRENDA, GR\u00d8A, GJ\u00d8RA, GJ\u00d8RA, \u00c5LVUNDEID, \u00c5LVUNDFJORD, \u00c5LVUNDFJORD, TINGVOLL, MEISINGSET, TORJULV\u00c5GEN, TINGVOLL, BATNFJORDS\u00d8RA, BATNFJORDS\u00d8RA, GJEMNES, ANGVIK, FLEMMA, OSMARKA, TORVIKBUKT, KVANNE, TORVIKBUKT, STANGVIK, B\u00d8FJORDEN, B\u00c6VERFJORD, TODALEN, SURNADAL, SURNADAL, \u00d8VRE SURNADAL, VIND\u00d8LA, SURNADAL, RINDAL, RINDALSSKOGEN, RINDAL, \u00d8YDEGARD, \u00d8YDEGARD, KVISVIK, HALSANAUSTAN, V\u00c5GLAND, VALS\u00d8YBOTN, VALS\u00d8YFJORD, V\u00c5GLAND, AURE, AURE, MJOSUNDET, FOLDFJORDEN, VIHALS, LESUND, KJ\u00d8RSVIKBUGEN, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, DEKNEPOLLEN, RAUDEBERG, BRYGGJA, RAUDEBERG, BRYGGJA, ALMENNINGEN, SILDA, BARMEN, HUSEV\u00c5G, FLATRAKET, DEKNEPOLLEN, SKATESTRAUMEN, SVELGEN, SVELGEN, BREMANGER, BREMANGER, KALV\u00c5G, KALV\u00c5G, DAVIK, RUGSUND, \u00c5LFOTEN, SELJE, SELJE, STADLANDET, STADLANDET, HORNINDAL, HORNINDAL, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, KJ\u00d8LSDALEN, ST\u00c5RHEIM, LOTE, HOLM\u00d8YANE, STRYN, STRYN, STRYN, OLDEN, OLDEN, LOEN, LOEN, OLDEDALEN, BRIKSDALSBRE, INNVIK, INNVIK, BLAKS\u00c6TER, HOPLAND, UTVIK, HJELLEDALEN, OPPSTRYN, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, HAUKEDALEN, F\u00d8RDE, F\u00d8RDE, SANDANE, SANDANE, SANDANE, BYRKJELO, BREIM, HESTENES\u00d8YRA, HYEN, BYRKJELO, HYEN, SKEI I J\u00d8LSTER, SKEI I J\u00d8LSTER, VASSENDEN, FJ\u00c6RLAND, VASSENDEN, FJ\u00c6RLAND, KAUPANGER, SOGNDAL, SOGNDAL, SOGNDAL, KAUPANGER, FR\u00d8NNINGEN, SOGNDAL, FARDAL, SLINDE, LEIKANGER, LEIKANGER, GAUPNE, HAFSLO, GAUPNE, HAFSLO, ORNES, JOSTEDAL, LUSTER, MARIFJ\u00d8RA, LUSTER, H\u00d8YHEIMSVIK, SKJOLDEN, FORTUN, VEITASTROND, SOLVORN, \u00c5RDALSTANGEN, \u00d8VRE \u00c5RDAL, \u00d8VRE \u00c5RDAL, \u00c5RDALSTANGEN, L\u00c6RDAL, L\u00c6RDAL, BORGUND, VIK I SOGN, VIK I SOGN, VANGSNES, FEIOS, FRESVIK, BALESTRAND, BALESTRAND, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, KINN, FLOR\u00d8, SVAN\u00d8YBUKT, ROGNALDSV\u00c5G, BAREKSTAD, BATALDEN, S\u00d8R-SKORPA, TANS\u00d8Y, HARDBAKKE, HARDBAKKE, KRAKHELLA, YTR\u00d8YGREND, KOLGROV, HERSVIKBYGDA, EIKEFJORD, EIKEFJORD, SVORTEVIK, STAVANG, LAVIK, LAVIK, LEIRVIK I SOGN, LEIRVIK I SOGN, HYLLESTAD, S\u00d8RB\u00d8V\u00c5G, S\u00d8RB\u00d8V\u00c5G, DALE I SUNNFJORD, DALE I SUNNFJORD, KORSSUND, GUDDAL, HELLEVIK I FJALER, FLEKKE, STRAUMSNES, SANDE I SUNNFJORD, SANDE I SUNNFJORD, SKILBREI, BYGSTAD, BYGSTAD, VIKSDALEN, ASKVOLL, HOLMEDAL, KVAMMEN, STONGFJORDEN, ATL\u00d8Y, V\u00c6RLANDET, BULANDET, ASKVOLL, H\u00d8YANGER, H\u00d8YANGER, KYRKJEB\u00d8, VADHEIM, VADHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, RANHEIM, RANHEIM, RANHEIM, RANHEIM, JONSVATNET, JAKOBSLI, JAKOBSLI, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, BOSBERG, TRONDHEIM, HEIMDAL, SPONGDAL, TILLER, SAUPSTAD, FLAT\u00c5SEN, HEIMDAL, SJETNEMARKA, KATTEM, LEINSTRAND, HEIMDAL, HEIMDAL, TILLER, TILLER, TILLER, SAUPSTAD, SAUPSTAD, FLAT\u00c5SEN, RISSA, RISSA, STADSBYGD, FEV\u00c5G, HASSELVIKA, HASSELVIKA, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, STADSBYGD, LEKSVIK, LEKSVIK, VANVIKAN, VANVIKAN, OPPHAUG, BREKSTAD, BREKSTAD, OPPHAUG, UTHAUG, STORFOSNA, STORFOSNA, KR\u00c5KV\u00c5G, GARTEN, LEKSA, BJUGN, BJUGN, LYS\u00d8YSUNDET, OKSVOLL, TARVA, VALLERSUND, LYS\u00d8YSUNDET, \u00c5FJORD, \u00c5FJORD, REVSNES, STOKK\u00d8Y, LINES\u00d8YA, REVSNES, STOKK\u00d8Y, ROAN, ROAN, BESSAKER, BRANDSFJORD, KYRKS\u00c6TER\u00d8RA, KYRKS\u00c6TER\u00d8RA, VINJE\u00d8RA, HELLANDSJ\u00d8EN, KORSVEGEN, KORSVEGEN, G\u00c5SBAKKEN, MELHUS, MELHUS, MELHUS, GIMSE, KV\u00c5L, LUNDAMO, LUNDAMO, LER, LER, HOVIN I GAULDAL, HOVIN I GAULDAL, HITRA, HITRA, ANSNES, KNARRLAGSUND, KVENV\u00c6R, KNARRLAGSUND, KVENV\u00c6R, SANDSTAD, HESTVIKA, MELANDSJ\u00d8, DOLM\u00d8Y, SUNDLANDET, HEMNSKJELA, SNILLFJORD, SNILLFJORD, SISTRANDA, SISTRANDA, HAMARVIK, HAMARVIK, KVERVA, KVERVA, TITRAN, DYRVIK, NORDDYR\u00d8Y, NORDDYR\u00d8Y, SULA, BOG\u00d8YV\u00c6R, MAUSUND, GJ\u00c6SINGEN, S\u00d8RBUR\u00d8Y, SAU\u00d8Y, SOKNEDAL, SOKNEDAL, ST\u00d8REN, ST\u00d8REN, ROGNES, BUDALEN, ORKANGER, ORKANGER, ORKANGER, GJ\u00d8LME, LENSVIK, LENSVIK, AGDENES, AGDENES, FANNREM, FANNREM, SVORKMO, SVORKMO, L\u00d8KKEN VERK, L\u00d8KKEN VERK, STOR\u00c5S, STOR\u00c5S, JERPSTAD, MELDAL, MELDAL, OPPDAL, OPPDAL, L\u00d8NSET, VOGNILL, DRIVA, BUVIKA, BUVIKA, B\u00d8RSA, VIGGJA, EGGKLEIVA, SKAUN, SKAUN, B\u00d8RSA, R\u00d8ROS, BREKKEBYGD, GL\u00c5MOS, R\u00d8ROS, \u00c5LEN, HALTDALEN, \u00c5LEN, SINGS\u00c5S, SINGS\u00c5S, SINGS\u00c5S, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, SKATVAL, SKATVAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, HELL, ELVARLI, HEGRA, FLORNES, HEGRA, MER\u00c5KER, MER\u00c5KER, KOPPER\u00c5, KL\u00c6BU, KL\u00c6BU, TANEM, HOMMELVIK, HOMMELVIK, VIKHAMMER, SAKSVIK, MALVIK, VIKHAMMER, HELL, SELBU, SELBU, SELBU, SELBUSTRAND, TYDAL, TYDAL, FLAKNAN, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, SKOGN, SKOGN, MARKABYGDA, RONGLAN, EKNE, YTTER\u00d8Y, \u00c5SEN, \u00c5SEN, \u00c5SENFJORD, FROSTA, FROSTA, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VUKU, VUKU, INDER\u00d8Y, INDER\u00d8Y, INDER\u00d8Y, MOSVIK, MOSVIK, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINSDALEN, STEINSDALEN, YTTERV\u00c5G, HEPS\u00d8Y, OPPLAND, HASV\u00c5G, S\u00c6TERVIK, NAMDALSEID, NAMDALSEID, SN\u00c5SA, SN\u00c5SA, FLATANGER, FLATANGER, NORD-STATLAND, MALM, MALM, FOLLAFOSS, FOLLAFOSS, VERRABOTN, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, SALSNES, LUND, FOSSLANDSOSEN, SPILLUM, SPILLUM, BANGSUND, BANGSUND, J\u00d8A, SKAGE I NAMDALEN, OVERHALLA, OVERHALLA, SKAGE I NAMDALEN, GRONG, GRONG, HARRAN, HARRAN, KONGSMOEN, H\u00d8YLANDET, H\u00d8YLANDET, NORDLI, NORDLI, S\u00d8RLI, S\u00d8RLI, NAMSSKOGAN, NAMSSKOGAN, TRONES, SKOROVATN, BREKKVASSELV, LIMINGEN, LIMINGEN, R\u00d8RVIK, R\u00d8RVIK, R\u00d8RVIK, OTTERS\u00d8Y, OTTERS\u00d8Y, INDRE N\u00c6R\u00d8Y, ABELV\u00c6R, SALSBRUKET, KOLVEREID, KOLVEREID, GJERDINGA, TERR\u00c5K, TERR\u00c5K, HARANGSFJORD, BINDALSEIDET, BINDALSEIDET, FOLDEREID, FOLDEREID, NAUSTBUKTA, GUTVIK, LEKA, LEKA, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, TVERLANDET, SALTSTRAUMEN, SALTSTRAUMEN, TVERLANDET, V\u00c6R\u00d8Y, V\u00c6R\u00d8Y, R\u00d8ST, R\u00d8ST, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, KJERRING\u00d8Y, FLEINV\u00c6R, HELLIGV\u00c6R, BLIKSV\u00c6R, GIV\u00c6R, LANDEGODE, JAN MAYEN, MISV\u00c6R, SKJERSTAD, BREIVIK I SALTEN, MISV\u00c6R, MOLDJORD, TOLL\u00c5, MOLDJORD, NYG\u00c5RDSJ\u00d8EN, YTRE BEIARN, SANDHORN\u00d8Y, S\u00d8RARN\u00d8Y, S\u00d8RARN\u00d8Y, NORDARN\u00d8Y, INNDYR, INNDYR, STORVIK, REIP\u00c5, NEVERDAL, \u00d8RNES, \u00d8RNES, MEL\u00d8Y, BOLGA, ST\u00d8TT, GLOMFJORD, GLOMFJORD, ENGAV\u00c5GEN, ENGAV\u00c5GEN, HALSA, HALSA, MYKEN, MELFJORDBOTN, V\u00c5GAHOLMEN, \u00c5GSKARDET, V\u00c5GAHOLMEN, TJONGSFJORDEN, JEKTVIK, NORDVERNES, GJERSVIKGRENDA, S\u00d8RFJORDEN, R\u00d8D\u00d8Y, GJER\u00d8Y, SELS\u00d8YVIK, STORSELS\u00d8Y, NORDNES\u00d8Y, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, VALNESFJORD, FAUSKE, FAUSKE, R\u00d8SVIK, STRAUMEN, SULITJELMA, SULITJELMA, STRAUMEN, VALNESFJORD, ROGNAN, ROGNAN, R\u00d8KLAND, R\u00d8KLAND, INNHAVET, INNHAVET, ENGAN, M\u00d8RSVIKBOTN, DRAG, DRAG, NEVERVIK, MUSKEN, STORJORD I TYSFJORD, ULVSV\u00c5G, STOR\u00c5, LEINESFJORD, LEINESFJORD, LEINES, NORDFOLD, ENGEL\u00d8YA, BOG\u00d8Y, ENGEL\u00d8YA, SKUTVIK, HAMAR\u00d8Y, TRAN\u00d8Y, HAMAR\u00d8Y, SVOLV\u00c6R, SVOLV\u00c6R, SVOLV\u00c6R, KABELV\u00c5G, KABELV\u00c5G, HENNINGSV\u00c6R, HENNINGSV\u00c6R, KLEPPSTAD, GIMS\u00d8YSAND, LAUKVIK, LAUPSTAD, STR\u00d8NSTAD, SKROVA, BRETTESNES, STORFJELL, DIGERMULEN, TENGELFJORD, MYRLAND, STORMOLLA, STAMSUND, SENNESVIK, VALBERG, B\u00d8STAD, B\u00d8STAD, LEKNES, GRAVDAL, BALLSTAD, BALLSTAD, LEKNES, GRAVDAL, STAMSUND, RAMBERG, NAPP, SUND I LOFOTEN, FREDVANG, RAMBERG, REINE, S\u00d8RV\u00c5GEN, S\u00d8RV\u00c5GEN, REINE, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, GULLESFJORD, L\u00d8DINGEN, L\u00d8DINGEN, VESTBYGD, KVITNES, HENNES, SORTLAND, SORTLAND, SORTLAND, BARKESTAD, TUNSTAD, MYRE, ALSV\u00c5G, ST\u00d8, MYRE, MELBU, LONKAN, STOKMARKNES, STOKMARKNES, MELBU, STRAUMSJ\u00d8EN, B\u00d8 I VESTER\u00c5LEN, B\u00d8 I VESTER\u00c5LEN, STRAUMSJ\u00d8EN, ANDENES, BLEIK, ANDENES, RIS\u00d8YHAMN, DVERBERG, N\u00d8SS, NORDMELA, RIS\u00d8YHAMN, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, BEISFJORD, ELVEG\u00c5RD, BJERKVIK, BJERKVIK, BOGEN I OFOTEN, LILAND, T\u00c5RSTAD, EVENES, BOGEN I OFOTEN, BALLANGEN, KJELDEBOTN, BALLANGEN, KJ\u00d8PSVIK, KJ\u00d8PSVIK, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, SKONSENG, MO I RANA, DALSGRENDA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, STORFORSHEI, MO I RANA, STORFORSHEI, HEMNESBERGET, HEMNESBERGET, FINNEIDFJORD, BJERKA, BJERKA, KORGEN, BLEIKVASSLIA, KORGEN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, ELSFJORD, TROFORS, TROFORS, HATTFJELLDAL, HATTFJELLDAL, NESNA, NESNA, VIKHOLMEN, HUSBY, SAURA, UTSKARPEN, BRATLAND, ALDRA, STUVLAND, STOKKV\u00c5GEN, NORD-SOLV\u00c6R, SELV\u00c6R, INDRE KVAR\u00d8Y, TONNES, KONSVIKOSEN, KONSVIKOSEN, \u00d8RESVIK, SLENESET, LOVUND, LUR\u00d8Y, LUR\u00d8Y, TR\u00c6NA, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, L\u00d8KTA, D\u00d8NNA, D\u00d8NNA, VANDVE, BRAS\u00d8Y, SANDV\u00c6R, HER\u00d8Y, HER\u00d8Y, HER\u00d8Y, AUSTB\u00d8, TJ\u00d8TTA, TJ\u00d8TTA, TRO, VISTHUS, B\u00c6R\u00d8YV\u00c5GEN, LEIRFJORD, LEIRFJORD, SUND\u00d8Y, BARDAL, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, S\u00d8MNA, S\u00d8MNA, S\u00d8MNA, VELFJORD, VELFJORD, VEVELSTAD, VEVELSTAD, VEGA, VEGA, YLVINGEN, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMSDALEN, TROMSDALEN, KROKELVDALEN, KROKELVDALEN, TOMASJORD, RAMFJORDBOTN, TROMSDALEN, SJURSNES, OLDERVIK, TROMS\u00d8, TROMS\u00d8, NORDKJOSBOTN, LAKSVATN, J\u00d8VIK, OTEREN, NORDKJOSBOTN, STORSTEINNES, MEISTERVIK, MORTENHALS, VIKRAN, STORSTEINNES, LYNGSEIDET, FURUFLATEN, SVENSBY, NORD-LENANGEN, LYNGSEIDET, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YA, KVAL\u00d8YA, KVAL\u00d8YA, STRAUMSBUKTA, KVAL\u00d8YA, KVAL\u00d8YA, SOMMAR\u00d8Y, BRENSHOLMEN, SOMMAR\u00d8Y, VENGS\u00d8Y, TUSS\u00d8Y, HANSNES, K\u00c5RVIK, STAKKVIK, HANSNES, VANNV\u00c5G, VANNAREID, VANNV\u00c5G, KARLS\u00d8Y, REBBENES, MJ\u00d8LVIK, SKIBOTN, SKIBOTN, SAMUELSBERG, SAMUELSBERG, OLDERDALEN, BIRTAVARRE, OLDERDALEN, BIRTAVARRE, STORSLETT, S\u00d8RKJOSEN, ROTSUND, S\u00d8RKJOSEN, STORSLETT, HAVNNES, BURFJORD, S\u00d8RSTRAUMEN, J\u00d8KELFJORD, BURFJORD, LONGYEARBYEN, LONGYEARBYEN, NY-\u00c5LESUND, HOPEN, SVEAGRUVA, BJ\u00d8RN\u00d8YA, BARENTSBURG, SKJERV\u00d8Y, HAMNEIDET, SEGLVIK, REINFJORD, SPILDRA, ANDSNES, VALANHAMN, SKJERV\u00d8Y, AKKARVIK, ARN\u00d8YHAMN, NIKKEBY, LAUKSLETTA, \u00c5RVIKSAND, UL\u00d8YBUKT, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, FINNSNES, ROSSFJORDSTRAUMEN, SILSAND, VANGSVIK, FINNSNES, FINNSNES, FINNSNES, FINNSNES, FINNSNES, S\u00d8RREISA, BR\u00d8STADBOTN, S\u00d8RREISA, BR\u00d8STADBOTN, MOEN, KARLSTAD, BARDUFOSS, BARDUFOSS, MOEN, \u00d8VERBYGD, \u00d8VERBYGD, RUNDHAUG, SJ\u00d8VEGAN, SJ\u00d8VEGAN, TENNEVOLL, TENNEVOLL, BARDU, BARDU, SILSAND, GIBOSTAD, BOTNHAMN, SKATVIK, GRYLLEFJORD, GRYLLEFJORD, TORSKEN, GIBOSTAD, SKALAND, SKALAND, SENJAHOPEN, SENJAHOPEN, FJORDGARD, HUS\u00d8Y I SENJA, STONGLANDSEIDET, STONGLANDSEIDET, FLAKSTADV\u00c5G, KALDFARNES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, S\u00d8RVIK, LUNDENES, GR\u00d8TAV\u00c6R, KJ\u00d8TTA, SANDS\u00d8Y, BJARK\u00d8Y, MEL\u00d8YV\u00c6R, SANDTORG, KONGSVIK, EVENSKJER, EVENSKJER, FJELLDAL, RAMSUND, MYKLEBOSTAD, HOL I TJELDSUND, TOVIK, GROVFJORD, GROVFJORD, RAMSUND, HAMNVIK, HAMNVIK, KR\u00c5KR\u00d8HAMN, \u00c5NSTAD, ENGENES, ENGENES, GRATANGEN, GRATANGEN, BORKENES, BORKENES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, KVIBY, KAUTOKEINO, KAUTOKEINO, MAZE, KVALFJORD, HAKKSTABBEN, KONGSHUS, KORSFJORDEN, TALVIK, LANGFJORDBOTN, \u00d8KSFJORD, BERGSFJORD, NUVSV\u00c5G, LANGFJORDHAMN, S\u00d8R-TVERRFJORD, SANDLAND, LOPPA, SKAVNAKK, HASVIK, HASVIK, BREIVIKBOTN, S\u00d8RV\u00c6R, HAMMERFEST, HAMMERFEST, HAMMERFEST, HAMMERFEST, NORDRE SEILAND, RYPEFJORD, RYPEFJORD, FORS\u00d8L, HAMMERFEST, HAMMERFEST, KVALSUND, KVALSUND, REVSNESHAMN, AKKARFJORD, LANGSTRAND, K\u00c5RHAMN, SAND\u00d8YBOTN, TUFJORD, ING\u00d8Y, HAV\u00d8YSUND, HAV\u00d8YSUND, M\u00c5S\u00d8Y, LAKSELV, PORSANGMOEN, INDRE BILLEFJORD, LAKSELV, LAKSELV, RUSSENES, SNEFJORD, KOKELV, B\u00d8RSELV, VEIDNESKLUBBEN, SKOGANVARRE, KARASJOK, KARASJOK, LEBESBY, KUNES, HONNINGSV\u00c5G, HONNINGSV\u00c5G, NORDV\u00c5GEN, SKARSV\u00c5G, NORDKAPP, GJESV\u00c6R, REPV\u00c5G, MEHAMN, SKJ\u00c5NES, LANGFJORDNES, NERVEI, GAMVIK, DYFJORD, KJ\u00d8LLEFJORD, VADS\u00d8, VESTRE JAKOBSELV, VESTRE JAKOBSELV, VADS\u00d8, VADS\u00d8, VARANGERBOTN, SIRMA, VARANGERBOTN, TANA, TANA, KIRKENES, BJ\u00d8RNEVATN, HESSENG, BJ\u00d8RNEVATN, KIRKENES, HESSENG, KIRKENES, SVANVIK, NEIDEN, BUG\u00d8YNES, VARD\u00d8, VARD\u00d8, KIBERG, BERLEV\u00c5G, BERLEV\u00c5G, KONGSFJORD, B\u00c5TSFJORD, B\u00c5TSFJORD".ToCharArray();

		l = new StringReference [10000];

		p = strSplitByString(poststeder, ", ".ToCharArray());

		nr = HentPostnummerListe();

		for(i = 0d; i < nr.Length; i = i + 1d){
			l[(int)(nr[(int)(i)])] = p[(int)(i)];
		}

		return l;
	}


	public static double [] HentPostnummerListe(){
		double [] n;

		n = StringToNumberArray("0001, 0010, 0015, 0018, 0021, 0024, 0026, 0028, 0030, 0031, 0032, 0033, 0034, 0037, 0040, 0045, 0046, 0047, 0048, 0050, 0055, 0060, 0081, 0101, 0102, 0103, 0104, 0105, 0106, 0107, 0109, 0110, 0111, 0112, 0113, 0114, 0115, 0116, 0117, 0118, 0119, 0120, 0121, 0122, 0123, 0124, 0125, 0128, 0129, 0130, 0131, 0132, 0133, 0134, 0135, 0136, 0138, 0139, 0140, 0150, 0151, 0152, 0153, 0154, 0155, 0157, 0158, 0159, 0160, 0161, 0162, 0164, 0165, 0166, 0167, 0168, 0169, 0170, 0171, 0172, 0173, 0174, 0175, 0176, 0177, 0178, 0179, 0180, 0181, 0182, 0183, 0184, 0185, 0186, 0187, 0188, 0190, 0191, 0192, 0193, 0194, 0195, 0196, 0198, 0201, 0202, 0203, 0204, 0207, 0208, 0211, 0212, 0213, 0214, 0215, 0216, 0217, 0218, 0230, 0240, 0244, 0247, 0250, 0251, 0252, 0253, 0254, 0255, 0256, 0257, 0258, 0259, 0260, 0262, 0263, 0264, 0265, 0266, 0267, 0268, 0270, 0271, 0272, 0273, 0274, 0275, 0276, 0277, 0278, 0279, 0280, 0281, 0282, 0283, 0284, 0286, 0287, 0301, 0302, 0303, 0304, 0305, 0306, 0307, 0308, 0309, 0311, 0313, 0314, 0315, 0316, 0317, 0318, 0319, 0323, 0330, 0340, 0349, 0350, 0351, 0352, 0353, 0354, 0355, 0356, 0357, 0358, 0359, 0360, 0361, 0362, 0363, 0364, 0365, 0366, 0367, 0368, 0369, 0370, 0371, 0372, 0373, 0374, 0375, 0376, 0377, 0378, 0379, 0380, 0381, 0382, 0383, 0401, 0402, 0403, 0404, 0405, 0406, 0409, 0410, 0411, 0412, 0413, 0415, 0421, 0422, 0423, 0424, 0440, 0441, 0442, 0445, 0450, 0451, 0452, 0454, 0455, 0456, 0457, 0458, 0459, 0460, 0461, 0462, 0463, 0464, 0465, 0467, 0468, 0469, 0470, 0472, 0473, 0474, 0475, 0476, 0477, 0478, 0479, 0480, 0481, 0482, 0483, 0484, 0485, 0486, 0487, 0488, 0489, 0490, 0491, 0492, 0493, 0494, 0495, 0496, 0501, 0502, 0503, 0504, 0505, 0506, 0507, 0508, 0509, 0510, 0511, 0512, 0513, 0515, 0516, 0517, 0518, 0520, 0540, 0550, 0551, 0552, 0553, 0554, 0555, 0556, 0557, 0558, 0559, 0560, 0561, 0562, 0563, 0564, 0565, 0566, 0567, 0568, 0569, 0570, 0571, 0572, 0573, 0574, 0575, 0576, 0577, 0578, 0579, 0580, 0581, 0582, 0583, 0584, 0585, 0586, 0587, 0588, 0589, 0590, 0591, 0592, 0593, 0594, 0595, 0596, 0597, 0598, 0601, 0602, 0603, 0604, 0605, 0606, 0607, 0608, 0609, 0611, 0612, 0613, 0614, 0615, 0616, 0617, 0618, 0619, 0620, 0621, 0622, 0623, 0624, 0626, 0650, 0651, 0652, 0653, 0654, 0655, 0656, 0657, 0658, 0659, 0660, 0661, 0662, 0663, 0664, 0665, 0666, 0667, 0668, 0669, 0670, 0671, 0672, 0673, 0674, 0675, 0676, 0677, 0678, 0679, 0680, 0681, 0682, 0683, 0684, 0685, 0686, 0687, 0688, 0689, 0690, 0691, 0692, 0693, 0694, 0701, 0702, 0705, 0710, 0712, 0750, 0751, 0752, 0753, 0754, 0755, 0756, 0757, 0758, 0760, 0763, 0764, 0765, 0766, 0767, 0768, 0770, 0771, 0772, 0773, 0774, 0775, 0776, 0777, 0778, 0779, 0781, 0782, 0783, 0784, 0785, 0786, 0787, 0788, 0789, 0790, 0791, 0801, 0805, 0806, 0807, 0840, 0850, 0851, 0852, 0853, 0854, 0855, 0856, 0857, 0858, 0860, 0861, 0862, 0863, 0864, 0870, 0871, 0872, 0873, 0874, 0875, 0876, 0877, 0880, 0881, 0882, 0883, 0884, 0890, 0891, 0901, 0902, 0903, 0904, 0905, 0907, 0908, 0913, 0914, 0915, 0950, 0951, 0952, 0953, 0954, 0955, 0956, 0957, 0958, 0959, 0960, 0962, 0963, 0964, 0968, 0969, 0970, 0971, 0972, 0973, 0975, 0976, 0977, 0978, 0979, 0980, 0981, 0982, 0983, 0984, 0985, 0986, 0987, 0988, 1001, 1003, 1005, 1006, 1007, 1008, 1009, 1011, 1051, 1052, 1053, 1054, 1055, 1056, 1061, 1062, 1063, 1064, 1065, 1067, 1068, 1069, 1071, 1081, 1083, 1084, 1086, 1087, 1088, 1089, 1101, 1102, 1108, 1109, 1112, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1172, 1176, 1177, 1178, 1179, 1181, 1182, 1184, 1185, 1187, 1188, 1189, 1201, 1203, 1204, 1205, 1207, 1214, 1215, 1250, 1251, 1252, 1253, 1254, 1255, 1256, 1257, 1258, 1259, 1262, 1263, 1266, 1270, 1271, 1272, 1273, 1274, 1275, 1278, 1279, 1281, 1283, 1284, 1285, 1286, 1290, 1291, 1294, 1295, 1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1311, 1312, 1313, 1314, 1316, 1317, 1318, 1319, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1344, 1346, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1371, 1372, 1373, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1501, 1502, 1503, 1504, 1506, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540, 1541, 1545, 1550, 1555, 1556, 1560, 1561, 1570, 1580, 1581, 1590, 1591, 1592, 1593, 1594, 1596, 1597, 1598, 1599, 1601, 1602, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621, 1622, 1623, 1624, 1625, 1626, 1628, 1629, 1630, 1632, 1633, 1634, 1636, 1637, 1638, 1639, 1640, 1641, 1642, 1650, 1651, 1653, 1654, 1655, 1657, 1658, 1659, 1661, 1662, 1663, 1664, 1665, 1666, 1667, 1670, 1671, 1672, 1673, 1675, 1676, 1678, 1679, 1680, 1682, 1683, 1684, 1690, 1692, 1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1730, 1733, 1734, 1735, 1738, 1739, 1740, 1742, 1743, 1745, 1746, 1747, 1751, 1752, 1753, 1754, 1757, 1759, 1760, 1761, 1762, 1763, 1764, 1765, 1766, 1767, 1768, 1769, 1771, 1772, 1776, 1777, 1778, 1779, 1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1796, 1798, 1799, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1811, 1812, 1813, 1814, 1815, 1816, 1820, 1821, 1823, 1825, 1827, 1830, 1831, 1832, 1833, 1850, 1851, 1852, 1859, 1860, 1861, 1866, 1867, 1870, 1871, 1875, 1878, 1880, 1890, 1891, 1892, 1893, 1894, 1900, 1901, 1903, 1910, 1911, 1912, 1914, 1916, 1917, 1920, 1921, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1940, 1941, 1950, 1954, 1960, 1961, 1963, 1970, 1971, 2000, 2001, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2040, 2041, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2060, 2061, 2062, 2063, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2076, 2080, 2081, 2090, 2091, 2092, 2093, 2094, 2100, 2101, 2110, 2114, 2116, 2120, 2121, 2123, 2130, 2132, 2133, 2134, 2150, 2151, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2170, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2223, 2224, 2225, 2226, 2227, 2230, 2231, 2232, 2233, 2235, 2240, 2241, 2251, 2256, 2260, 2261, 2264, 2265, 2266, 2270, 2271, 2280, 2283, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2344, 2345, 2346, 2350, 2351, 2353, 2355, 2360, 2361, 2364, 2365, 2372, 2373, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2432, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2446, 2447, 2448, 2450, 2451, 2460, 2461, 2476, 2477, 2478, 2480, 2481, 2484, 2485, 2486, 2487, 2488, 2500, 2501, 2510, 2512, 2513, 2540, 2541, 2542, 2544, 2550, 2551, 2552, 2555, 2560, 2561, 2580, 2581, 2582, 2584, 2601, 2602, 2603, 2604, 2605, 2606, 2607, 2608, 2609, 2610, 2611, 2612, 2613, 2614, 2615, 2616, 2617, 2618, 2619, 2620, 2621, 2622, 2623, 2624, 2625, 2626, 2627, 2628, 2629, 2630, 2631, 2632, 2633, 2634, 2635, 2636, 2637, 2638, 2639, 2640, 2641, 2642, 2643, 2644, 2645, 2646, 2647, 2648, 2649, 2651, 2652, 2653, 2654, 2656, 2657, 2658, 2659, 2660, 2661, 2662, 2663, 2664, 2665, 2666, 2667, 2668, 2669, 2670, 2671, 2672, 2673, 2674, 2675, 2676, 2677, 2678, 2679, 2680, 2681, 2682, 2683, 2684, 2685, 2686, 2687, 2688, 2690, 2693, 2694, 2695, 2711, 2712, 2713, 2714, 2715, 2716, 2717, 2718, 2720, 2730, 2740, 2742, 2743, 2750, 2760, 2770, 2801, 2802, 2803, 2804, 2805, 2806, 2807, 2808, 2809, 2810, 2811, 2812, 2815, 2816, 2817, 2818, 2819, 2820, 2821, 2822, 2825, 2827, 2830, 2831, 2832, 2833, 2834, 2835, 2836, 2837, 2838, 2839, 2840, 2841, 2843, 2844, 2845, 2846, 2847, 2848, 2849, 2850, 2851, 2853, 2854, 2857, 2858, 2860, 2861, 2862, 2864, 2866, 2867, 2870, 2879, 2880, 2881, 2882, 2890, 2893, 2900, 2901, 2907, 2909, 2910, 2917, 2918, 2920, 2923, 2929, 2930, 2933, 2936, 2937, 2939, 2940, 2943, 2950, 2952, 2953, 2954, 2959, 2960, 2965, 2966, 2967, 2972, 2973, 2974, 2975, 2977, 2985, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3050, 3051, 3053, 3054, 3055, 3056, 3057, 3058, 3060, 3061, 3063, 3064, 3065, 3066, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3095, 3101, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3131, 3132, 3133, 3134, 3135, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3148, 3150, 3151, 3152, 3153, 3154, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3199, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3251, 3252, 3253, 3254, 3255, 3256, 3257, 3258, 3259, 3260, 3261, 3262, 3263, 3264, 3265, 3267, 3268, 3269, 3270, 3271, 3274, 3275, 3276, 3277, 3280, 3281, 3282, 3284, 3285, 3290, 3291, 3292, 3294, 3295, 3296, 3297, 3300, 3301, 3302, 3303, 3320, 3321, 3322, 3330, 3331, 3340, 3341, 3342, 3350, 3351, 3355, 3357, 3358, 3359, 3360, 3361, 3370, 3371, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3420, 3421, 3425, 3426, 3427, 3428, 3430, 3431, 3440, 3441, 3442, 3470, 3471, 3472, 3474, 3475, 3476, 3477, 3478, 3479, 3480, 3481, 3482, 3483, 3484, 3485, 3490, 3501, 3502, 3503, 3504, 3507, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528, 3529, 3530, 3531, 3532, 3533, 3534, 3535, 3536, 3537, 3538, 3539, 3540, 3541, 3543, 3544, 3545, 3550, 3551, 3560, 3561, 3570, 3571, 3575, 3576, 3577, 3579, 3580, 3581, 3588, 3593, 3595, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3621, 3622, 3623, 3624, 3625, 3626, 3627, 3628, 3629, 3630, 3631, 3632, 3634, 3646, 3647, 3648, 3650, 3652, 3656, 3658, 3660, 3661, 3665, 3666, 3671, 3672, 3673, 3674, 3675, 3676, 3677, 3678, 3679, 3680, 3681, 3683, 3684, 3690, 3691, 3692, 3697, 3701, 3702, 3703, 3704, 3705, 3707, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3746, 3747, 3748, 3749, 3750, 3753, 3760, 3766, 3770, 3772, 3780, 3781, 3783, 3785, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3810, 3811, 3812, 3820, 3825, 3830, 3831, 3832, 3833, 3834, 3835, 3836, 3840, 3841, 3844, 3848, 3849, 3850, 3852, 3853, 3854, 3855, 3864, 3870, 3880, 3882, 3883, 3884, 3885, 3886, 3887, 3888, 3890, 3891, 3893, 3895, 3901, 3902, 3903, 3904, 3905, 3906, 3910, 3911, 3912, 3913, 3914, 3915, 3916, 3917, 3918, 3919, 3920, 3921, 3922, 3924, 3925, 3928, 3929, 3930, 3931, 3933, 3936, 3937, 3939, 3940, 3941, 3942, 3943, 3944, 3946, 3947, 3948, 3949, 3950, 3960, 3961, 3962, 3965, 3966, 3967, 3970, 3991, 3993, 3994, 3995, 3996, 3997, 3998, 3999, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4031, 4032, 4033, 4034, 4035, 4036, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071, 4072, 4073, 4076, 4077, 4078, 4079, 4081, 4082, 4083, 4084, 4085, 4086, 4087, 4088, 4089, 4090, 4091, 4092, 4093, 4094, 4095, 4096, 4097, 4098, 4099, 4100, 4102, 4110, 4119, 4120, 4123, 4124, 4126, 4127, 4128, 4129, 4130, 4134, 4137, 4139, 4146, 4148, 4150, 4152, 4153, 4154, 4156, 4158, 4159, 4160, 4161, 4163, 4164, 4167, 4168, 4169, 4170, 4173, 4174, 4180, 4181, 4182, 4187, 4198, 4200, 4201, 4208, 4209, 4230, 4233, 4234, 4235, 4237, 4239, 4240, 4244, 4250, 4260, 4262, 4264, 4265, 4270, 4272, 4274, 4275, 4276, 4280, 4291, 4294, 4295, 4296, 4297, 4298, 4299, 4301, 4302, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4317, 4318, 4319, 4320, 4321, 4322, 4323, 4324, 4325, 4326, 4327, 4328, 4329, 4330, 4332, 4333, 4335, 4336, 4337, 4338, 4339, 4340, 4341, 4342, 4343, 4344, 4345, 4346, 4347, 4348, 4349, 4352, 4353, 4354, 4355, 4356, 4357, 4358, 4360, 4361, 4362, 4363, 4364, 4365, 4367, 4368, 4369, 4370, 4371, 4372, 4373, 4374, 4375, 4376, 4378, 4379, 4380, 4381, 4384, 4385, 4387, 4389, 4390, 4391, 4392, 4393, 4394, 4395, 4396, 4397, 4398, 4399, 4400, 4401, 4402, 4403, 4420, 4432, 4434, 4436, 4438, 4439, 4440, 4441, 4443, 4460, 4462, 4463, 4465, 4473, 4480, 4484, 4485, 4490, 4491, 4492, 4501, 4502, 4503, 4504, 4507, 4508, 4509, 4513, 4514, 4515, 4516, 4517, 4519, 4520, 4521, 4522, 4523, 4524, 4525, 4526, 4528, 4529, 4532, 4534, 4535, 4536, 4540, 4541, 4544, 4550, 4551, 4552, 4553, 4554, 4557, 4558, 4560, 4563, 4575, 4576, 4577, 4579, 4580, 4586, 4588, 4590, 4595, 4596, 4597, 4604, 4605, 4606, 4608, 4609, 4610, 4611, 4612, 4613, 4614, 4615, 4616, 4617, 4618, 4619, 4620, 4621, 4622, 4623, 4624, 4625, 4626, 4628, 4629, 4630, 4631, 4632, 4633, 4634, 4635, 4636, 4637, 4638, 4639, 4640, 4641, 4642, 4643, 4644, 4645, 4646, 4647, 4649, 4656, 4657, 4658, 4661, 4662, 4663, 4664, 4665, 4666, 4670, 4671, 4672, 4673, 4674, 4675, 4676, 4677, 4678, 4679, 4681, 4682, 4683, 4684, 4685, 4686, 4687, 4688, 4689, 4691, 4693, 4694, 4695, 4696, 4697, 4698, 4699, 4700, 4701, 4702, 4703, 4705, 4706, 4707, 4708, 4715, 4720, 4721, 4724, 4725, 4730, 4733, 4734, 4735, 4737, 4741, 4742, 4744, 4745, 4746, 4747, 4748, 4749, 4754, 4755, 4756, 4760, 4766, 4768, 4770, 4780, 4790, 4791, 4792, 4793, 4794, 4795, 4801, 4802, 4803, 4804, 4808, 4809, 4810, 4812, 4815, 4816, 4817, 4818, 4820, 4821, 4822, 4823, 4824, 4825, 4827, 4828, 4830, 4832, 4834, 4836, 4838, 4839, 4841, 4842, 4843, 4844, 4846, 4847, 4848, 4849, 4851, 4852, 4853, 4854, 4855, 4856, 4857, 4858, 4859, 4862, 4863, 4864, 4865, 4868, 4869, 4870, 4876, 4877, 4878, 4879, 4884, 4885, 4886, 4887, 4888, 4889, 4891, 4892, 4893, 4894, 4896, 4898, 4900, 4901, 4902, 4909, 4910, 4912, 4915, 4916, 4920, 4921, 4934, 4950, 4951, 4952, 4953, 4955, 4956, 4957, 4971, 4972, 4973, 4974, 4980, 4985, 4990, 4993, 4994, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5041, 5042, 5043, 5045, 5052, 5053, 5054, 5055, 5056, 5057, 5058, 5059, 5063, 5067, 5068, 5072, 5073, 5075, 5081, 5082, 5089, 5093, 5094, 5096, 5097, 5098, 5099, 5101, 5104, 5105, 5106, 5107, 5108, 5109, 5111, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5121, 5122, 5124, 5130, 5131, 5132, 5134, 5135, 5136, 5137, 5141, 5142, 5143, 5144, 5145, 5146, 5147, 5148, 5151, 5152, 5153, 5154, 5155, 5160, 5161, 5162, 5163, 5164, 5165, 5170, 5171, 5172, 5173, 5174, 5176, 5177, 5178, 5179, 5183, 5184, 5200, 5201, 5202, 5203, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217, 5218, 5221, 5222, 5223, 5224, 5225, 5226, 5227, 5228, 5229, 5230, 5231, 5232, 5235, 5236, 5237, 5238, 5239, 5243, 5244, 5251, 5252, 5253, 5254, 5257, 5258, 5259, 5260, 5261, 5262, 5263, 5264, 5265, 5267, 5268, 5281, 5282, 5283, 5284, 5285, 5286, 5291, 5293, 5299, 5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5314, 5315, 5318, 5319, 5321, 5322, 5323, 5325, 5326, 5327, 5329, 5331, 5333, 5334, 5335, 5336, 5337, 5341, 5342, 5343, 5345, 5346, 5347, 5350, 5353, 5354, 5355, 5357, 5358, 5360, 5363, 5365, 5366, 5371, 5374, 5378, 5379, 5380, 5381, 5382, 5384, 5385, 5387, 5388, 5392, 5393, 5394, 5396, 5397, 5398, 5399, 5401, 5402, 5403, 5404, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5423, 5427, 5428, 5430, 5437, 5440, 5443, 5444, 5445, 5447, 5449, 5450, 5451, 5452, 5453, 5454, 5455, 5457, 5458, 5459, 5460, 5462, 5463, 5464, 5465, 5470, 5472, 5473, 5474, 5475, 5476, 5480, 5484, 5486, 5498, 5499, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5511, 5512, 5514, 5515, 5516, 5517, 5518, 5519, 5521, 5522, 5523, 5525, 5527, 5528, 5529, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5541, 5542, 5544, 5545, 5546, 5547, 5548, 5549, 5550, 5551, 5554, 5555, 5556, 5559, 5560, 5561, 5562, 5563, 5565, 5566, 5567, 5568, 5569, 5570, 5574, 5575, 5576, 5578, 5580, 5582, 5583, 5584, 5585, 5586, 5588, 5589, 5590, 5591, 5593, 5594, 5595, 5596, 5598, 5600, 5601, 5602, 5604, 5605, 5610, 5612, 5614, 5620, 5626, 5627, 5628, 5629, 5630, 5631, 5632, 5633, 5635, 5636, 5637, 5640, 5641, 5642, 5643, 5644, 5645, 5646, 5647, 5648, 5649, 5650, 5651, 5652, 5653, 5680, 5683, 5685, 5687, 5690, 5693, 5694, 5695, 5696, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5718, 5719, 5720, 5721, 5722, 5723, 5724, 5725, 5726, 5727, 5728, 5729, 5730, 5731, 5732, 5733, 5734, 5736, 5741, 5742, 5743, 5745, 5746, 5747, 5748, 5750, 5751, 5752, 5760, 5763, 5770, 5773, 5775, 5776, 5777, 5778, 5779, 5780, 5781, 5782, 5783, 5784, 5785, 5786, 5787, 5788, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5823, 5824, 5825, 5826, 5827, 5828, 5829, 5830, 5831, 5832, 5833, 5834, 5835, 5836, 5837, 5838, 5841, 5843, 5844, 5845, 5847, 5848, 5849, 5851, 5852, 5853, 5854, 5855, 5857, 5858, 5859, 5861, 5862, 5863, 5864, 5865, 5866, 5867, 5868, 5869, 5872, 5873, 5876, 5877, 5878, 5879, 5881, 5884, 5886, 5887, 5888, 5889, 5892, 5893, 5895, 5896, 5899, 5902, 5903, 5904, 5906, 5907, 5908, 5911, 5912, 5913, 5914, 5915, 5916, 5917, 5918, 5919, 5931, 5935, 5936, 5937, 5938, 5939, 5941, 5943, 5947, 5948, 5951, 5952, 5953, 5954, 5955, 5956, 5957, 5960, 5961, 5962, 5963, 5964, 5965, 5966, 5967, 5970, 5977, 5978, 5979, 5981, 5982, 5983, 5984, 5985, 5986, 5987, 5991, 5993, 5994, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6028, 6030, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6044, 6045, 6046, 6047, 6048, 6050, 6051, 6052, 6054, 6055, 6057, 6058, 6059, 6060, 6062, 6063, 6064, 6065, 6067, 6068, 6069, 6070, 6075, 6076, 6078, 6079, 6080, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6094, 6095, 6096, 6098, 6099, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6110, 6120, 6133, 6134, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6146, 6147, 6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6160, 6161, 6165, 6166, 6170, 6171, 6174, 6183, 6184, 6190, 6196, 6200, 6201, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6222, 6223, 6224, 6230, 6238, 6239, 6240, 6249, 6250, 6255, 6259, 6260, 6263, 6264, 6265, 6270, 6272, 6280, 6281, 6282, 6283, 6285, 6290, 6291, 6292, 6293, 6294, 6300, 6301, 6310, 6315, 6320, 6330, 6331, 6339, 6350, 6360, 6361, 6363, 6364, 6365, 6385, 6386, 6387, 6388, 6389, 6390, 6391, 6392, 6393, 6394, 6395, 6396, 6397, 6398, 6399, 6401, 6402, 6403, 6404, 6405, 6407, 6408, 6409, 6410, 6411, 6412, 6413, 6414, 6415, 6416, 6418, 6419, 6421, 6422, 6423, 6425, 6429, 6430, 6431, 6433, 6434, 6435, 6436, 6440, 6443, 6444, 6445, 6446, 6447, 6450, 6452, 6453, 6454, 6455, 6456, 6457, 6458, 6460, 6461, 6462, 6470, 6471, 6472, 6475, 6476, 6480, 6481, 6483, 6484, 6485, 6486, 6487, 6488, 6490, 6493, 6494, 6499, 6501, 6502, 6503, 6504, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6514, 6515, 6516, 6517, 6518, 6520, 6521, 6522, 6523, 6524, 6525, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6538, 6539, 6546, 6547, 6548, 6549, 6570, 6571, 6590, 6591, 6600, 6601, 6610, 6611, 6612, 6613, 6614, 6620, 6622, 6623, 6627, 6628, 6629, 6630, 6631, 6632, 6633, 6636, 6637, 6638, 6639, 6640, 6641, 6642, 6643, 6644, 6645, 6650, 6652, 6653, 6655, 6656, 6657, 6658, 6659, 6670, 6671, 6674, 6680, 6683, 6686, 6687, 6688, 6689, 6690, 6693, 6694, 6697, 6698, 6699, 6700, 6701, 6702, 6703, 6704, 6707, 6708, 6710, 6711, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6721, 6723, 6726, 6727, 6728, 6729, 6730, 6734, 6737, 6740, 6741, 6750, 6751, 6761, 6763, 6770, 6771, 6772, 6773, 6774, 6776, 6777, 6778, 6779, 6781, 6782, 6783, 6784, 6788, 6789, 6790, 6791, 6792, 6793, 6794, 6795, 6796, 6797, 6798, 6799, 6800, 6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810, 6811, 6812, 6813, 6814, 6815, 6817, 6818, 6819, 6820, 6821, 6822, 6823, 6826, 6827, 6828, 6829, 6830, 6831, 6841, 6843, 6844, 6845, 6847, 6848, 6849, 6851, 6852, 6853, 6854, 6855, 6856, 6858, 6859, 6861, 6863, 6866, 6867, 6868, 6869, 6870, 6871, 6872, 6873, 6874, 6875, 6876, 6877, 6878, 6879, 6881, 6882, 6884, 6885, 6886, 6887, 6888, 6891, 6893, 6894, 6895, 6896, 6898, 6899, 6900, 6901, 6902, 6903, 6905, 6906, 6907, 6908, 6909, 6910, 6912, 6913, 6914, 6915, 6916, 6917, 6918, 6919, 6921, 6924, 6926, 6927, 6928, 6929, 6940, 6941, 6942, 6944, 6946, 6947, 6951, 6953, 6957, 6958, 6959, 6961, 6963, 6964, 6966, 6967, 6968, 6969, 6971, 6973, 6975, 6976, 6977, 6978, 6980, 6982, 6983, 6984, 6985, 6986, 6987, 6988, 6991, 6993, 6995, 6996, 6997, 7003, 7004, 7005, 7006, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050, 7051, 7052, 7053, 7054, 7055, 7056, 7057, 7058, 7059, 7066, 7067, 7068, 7069, 7070, 7071, 7072, 7074, 7075, 7078, 7079, 7080, 7081, 7082, 7083, 7088, 7089, 7091, 7092, 7093, 7097, 7098, 7099, 7100, 7101, 7105, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7119, 7120, 7121, 7125, 7126, 7127, 7129, 7130, 7140, 7142, 7150, 7151, 7152, 7153, 7156, 7159, 7160, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7174, 7175, 7176, 7177, 7178, 7180, 7181, 7190, 7194, 7200, 7201, 7203, 7206, 7211, 7212, 7213, 7221, 7223, 7224, 7227, 7228, 7231, 7232, 7234, 7235, 7236, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7250, 7252, 7255, 7256, 7257, 7259, 7260, 7261, 7263, 7264, 7266, 7267, 7268, 7270, 7273, 7274, 7280, 7282, 7284, 7285, 7286, 7287, 7288, 7289, 7290, 7291, 7295, 7298, 7300, 7301, 7302, 7310, 7315, 7316, 7318, 7319, 7320, 7321, 7327, 7329, 7331, 7332, 7333, 7334, 7335, 7336, 7338, 7340, 7341, 7342, 7343, 7345, 7350, 7351, 7353, 7354, 7355, 7356, 7357, 7358, 7361, 7370, 7372, 7374, 7380, 7383, 7384, 7386, 7387, 7388, 7391, 7392, 7393, 7397, 7398, 7399, 7400, 7401, 7402, 7403, 7404, 7405, 7406, 7407, 7408, 7409, 7410, 7411, 7412, 7413, 7414, 7415, 7416, 7417, 7418, 7419, 7420, 7421, 7422, 7424, 7425, 7426, 7427, 7428, 7429, 7430, 7431, 7432, 7433, 7434, 7435, 7436, 7437, 7438, 7439, 7440, 7441, 7442, 7443, 7444, 7445, 7446, 7447, 7448, 7449, 7450, 7451, 7452, 7453, 7454, 7455, 7456, 7457, 7458, 7459, 7462, 7463, 7464, 7465, 7466, 7467, 7468, 7469, 7470, 7471, 7472, 7473, 7474, 7475, 7476, 7477, 7478, 7479, 7480, 7481, 7482, 7483, 7484, 7485, 7486, 7487, 7488, 7489, 7490, 7491, 7492, 7493, 7494, 7495, 7496, 7497, 7498, 7500, 7501, 7502, 7503, 7504, 7505, 7506, 7507, 7508, 7509, 7510, 7511, 7512, 7513, 7514, 7517, 7519, 7520, 7525, 7529, 7530, 7531, 7533, 7540, 7541, 7549, 7550, 7551, 7560, 7562, 7563, 7566, 7570, 7580, 7581, 7583, 7584, 7590, 7591, 7596, 7600, 7601, 7602, 7603, 7604, 7605, 7606, 7607, 7608, 7609, 7610, 7619, 7620, 7622, 7623, 7624, 7629, 7630, 7631, 7632, 7633, 7634, 7650, 7651, 7652, 7653, 7654, 7655, 7656, 7657, 7658, 7660, 7661, 7670, 7671, 7672, 7690, 7691, 7701, 7702, 7703, 7704, 7705, 7707, 7708, 7709, 7710, 7711, 7712, 7713, 7714, 7715, 7716, 7717, 7718, 7724, 7725, 7726, 7729, 7730, 7732, 7733, 7734, 7735, 7736, 7737, 7738, 7739, 7740, 7741, 7742, 7744, 7745, 7746, 7748, 7750, 7751, 7760, 7761, 7770, 7771, 7777, 7790, 7791, 7795, 7796, 7797, 7800, 7801, 7802, 7803, 7804, 7805, 7808, 7810, 7817, 7818, 7819, 7820, 7821, 7822, 7823, 7856, 7860, 7863, 7864, 7869, 7870, 7871, 7873, 7874, 7876, 7877, 7878, 7881, 7882, 7884, 7885, 7890, 7891, 7892, 7893, 7896, 7897, 7898, 7900, 7901, 7902, 7940, 7941, 7944, 7950, 7960, 7970, 7971, 7973, 7979, 7980, 7981, 7982, 7983, 7985, 7986, 7990, 7993, 7994, 7995, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8019, 8020, 8021, 8022, 8023, 8026, 8027, 8028, 8029, 8030, 8031, 8037, 8038, 8041, 8047, 8048, 8049, 8050, 8056, 8057, 8058, 8062, 8063, 8064, 8065, 8070, 8071, 8072, 8073, 8074, 8075, 8076, 8079, 8084, 8086, 8087, 8088, 8089, 8091, 8092, 8093, 8094, 8095, 8096, 8097, 8098, 8099, 8100, 8102, 8103, 8108, 8110, 8114, 8118, 8120, 8128, 8130, 8134, 8135, 8136, 8138, 8140, 8145, 8146, 8149, 8150, 8151, 8157, 8158, 8159, 8160, 8161, 8168, 8170, 8178, 8179, 8181, 8182, 8183, 8184, 8185, 8186, 8187, 8188, 8189, 8190, 8193, 8195, 8196, 8197, 8198, 8200, 8201, 8202, 8203, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8214, 8215, 8218, 8219, 8220, 8226, 8230, 8231, 8232, 8233, 8250, 8251, 8255, 8256, 8260, 8261, 8264, 8266, 8270, 8271, 8273, 8274, 8275, 8276, 8278, 8281, 8283, 8285, 8286, 8287, 8288, 8289, 8290, 8294, 8297, 8298, 8300, 8301, 8305, 8309, 8310, 8311, 8312, 8313, 8314, 8315, 8316, 8317, 8320, 8322, 8323, 8324, 8325, 8326, 8328, 8340, 8352, 8357, 8360, 8361, 8370, 8372, 8373, 8374, 8376, 8377, 8378, 8380, 8382, 8384, 8387, 8388, 8390, 8392, 8393, 8398, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8419, 8426, 8428, 8430, 8432, 8438, 8439, 8445, 8447, 8450, 8455, 8459, 8465, 8469, 8470, 8475, 8480, 8481, 8483, 8484, 8485, 8488, 8489, 8493, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8512, 8513, 8514, 8515, 8516, 8517, 8518, 8520, 8522, 8523, 8530, 8531, 8533, 8534, 8535, 8536, 8539, 8540, 8543, 8546, 8590, 8591, 8601, 8602, 8603, 8604, 8607, 8608, 8609, 8610, 8613, 8614, 8615, 8616, 8617, 8618, 8619, 8622, 8624, 8626, 8630, 8634, 8638, 8640, 8641, 8642, 8643, 8644, 8646, 8647, 8648, 8651, 8652, 8654, 8655, 8656, 8657, 8658, 8659, 8660, 8661, 8663, 8664, 8665, 8666, 8672, 8680, 8681, 8690, 8691, 8700, 8701, 8720, 8723, 8724, 8725, 8730, 8732, 8733, 8735, 8740, 8742, 8743, 8750, 8752, 8753, 8754, 8762, 8764, 8766, 8767, 8770, 8800, 8801, 8802, 8803, 8804, 8805, 8809, 8813, 8820, 8827, 8830, 8842, 8844, 8850, 8851, 8852, 8854, 8860, 8861, 8865, 8870, 8880, 8890, 8891, 8892, 8897, 8900, 8901, 8902, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8920, 8921, 8922, 8960, 8961, 8976, 8977, 8980, 8981, 8985, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9027, 9029, 9030, 9034, 9037, 9038, 9040, 9042, 9043, 9046, 9049, 9050, 9055, 9056, 9057, 9059, 9060, 9062, 9064, 9068, 9069, 9100, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9110, 9118, 9119, 9120, 9128, 9130, 9131, 9132, 9134, 9135, 9136, 9137, 9138, 9140, 9141, 9142, 9143, 9144, 9145, 9146, 9147, 9148, 9149, 9151, 9152, 9153, 9155, 9156, 9159, 9161, 9162, 9163, 9169, 9170, 9171, 9173, 9174, 9175, 9176, 9178, 9180, 9181, 9182, 9184, 9185, 9186, 9187, 9189, 9190, 9192, 9193, 9194, 9195, 9197, 9240, 9251, 9252, 9253, 9254, 9255, 9256, 9257, 9258, 9259, 9260, 9261, 9262, 9263, 9265, 9266, 9267, 9268, 9269, 9270, 9271, 9272, 9273, 9274, 9275, 9276, 9277, 9278, 9279, 9280, 9281, 9282, 9283, 9284, 9285, 9286, 9287, 9288, 9290, 9291, 9292, 9293, 9294, 9296, 9298, 9299, 9300, 9302, 9303, 9304, 9305, 9306, 9307, 9308, 9309, 9310, 9311, 9315, 9316, 9321, 9322, 9325, 9326, 9329, 9334, 9335, 9336, 9350, 9355, 9357, 9358, 9360, 9365, 9370, 9372, 9373, 9376, 9379, 9380, 9381, 9382, 9384, 9385, 9386, 9387, 9388, 9389, 9391, 9392, 9393, 9395, 9402, 9403, 9404, 9405, 9406, 9407, 9408, 9409, 9411, 9414, 9415, 9416, 9419, 9420, 9423, 9424, 9425, 9426, 9427, 9430, 9436, 9439, 9440, 9441, 9442, 9443, 9444, 9445, 9446, 9447, 9448, 9450, 9451, 9453, 9454, 9455, 9456, 9470, 9471, 9475, 9476, 9479, 9480, 9481, 9482, 9483, 9484, 9485, 9486, 9487, 9488, 9489, 9496, 9497, 9498, 9501, 9502, 9503, 9504, 9505, 9506, 9507, 9508, 9509, 9510, 9511, 9512, 9513, 9514, 9515, 9516, 9517, 9518, 9519, 9520, 9521, 9525, 9531, 9532, 9533, 9536, 9540, 9545, 9550, 9580, 9582, 9583, 9584, 9585, 9586, 9587, 9590, 9591, 9593, 9595, 9600, 9601, 9602, 9603, 9609, 9610, 9611, 9612, 9615, 9616, 9620, 9621, 9624, 9650, 9651, 9657, 9664, 9670, 9672, 9690, 9691, 9692, 9700, 9709, 9710, 9711, 9712, 9713, 9714, 9715, 9716, 9717, 9722, 9730, 9735, 9740, 9742, 9750, 9751, 9760, 9763, 9764, 9765, 9768, 9770, 9771, 9772, 9773, 9775, 9782, 9790, 9800, 9802, 9810, 9811, 9815, 9820, 9826, 9840, 9845, 9846, 9900, 9910, 9912, 9914, 9915, 9916, 9917, 9925, 9930, 9935, 9950, 9951, 9960, 9980, 9981, 9982, 9990, 9991".ToCharArray());

		return n;
	}


	public static char [] HentPoststed(char [] nrString, Success feilmelding){
		double nr;
		char [] respons;
		StringReference [] poststedListe;

		nr = CreateNumberFromDecimalString(nrString);
		respons = "".ToCharArray();

		if(ErGyldigPostnummer(nrString)){
			feilmelding.success = true;
			poststedListe = HentPoststedListe();
			respons = poststedListe[(int)(nr)].stringx;
		}else{
			feilmelding.success = false;
			feilmelding.feilmelding = "Postnummer er ikke gyldig.".ToCharArray();
		}

		return respons;
	}


	public static bool ErGyldigPostnummer(char [] nrString){
		double nr;
		bool [] gyldigePostnummer;
		bool erGyldig;

		nr = CreateNumberFromDecimalString(nrString);
		gyldigePostnummer = GyldigPostnummertabell();

		if(nr > 0d && nr < 10000d && IsInteger(nr) && nrString.Length == 4d){
			erGyldig = gyldigePostnummer[(int)(nr)];
		}else{
			erGyldig = false;
		}

		return erGyldig;
	}


	public static bool [] GyldigPostnummertabell(){
		double i, maxnummer;
		double [] postnummerliste;
		bool [] rev;

		postnummerliste = HentPostnummerListe();
		maxnummer = 0d;

		for(i = 0d; i < postnummerliste.Length; i = i + 1d){
			maxnummer = Max(maxnummer, postnummerliste[(int)(i)]);
		}

		rev = new bool [(int)(maxnummer + 1d)];

		for(i = 0d; i < maxnummer; i = i + 1d){
			rev[(int)(i)] = false;
		}

		for(i = 0d; i < postnummerliste.Length; i = i + 1d){
			rev[(int)(postnummerliste[(int)(i)])] = true;
		}

		return rev;
	}


	public static bool Loess(double [] xs, double [] ys, double bandwidth, double robustnessIters, double accuracy, NumberArrayReference resultXs, StringReference errorMessage){
		double [] weights;

		weights = new double [(int)(xs.Length)];
		arraysFillNumberArray(weights, 1d);

		return Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage);
	}


	public static bool Lowess(double [] xs, double [] ys, double [] weights, double bandwidth, double robustnessIters, double accuracy, NumberArrayReference resultXs, StringReference errorMessage){
		double [] res, residuals, sortedResiduals, robustnessWeights, indexes;
		double n, i, k;
		double x, sumWeights, sumX, sumXSquared, sumY, sumXY, denom;
		double xk, yk, dist, w, xkw;
		double meanX, meanY, meanXY, meanXSquared;
		double alpha, beta;
		double arg, iter, medianResidual;
		double [] bandwidthInterval;
		double ileft, iright, edge;
		double left, right, nextRight, nextLeft, bandwidthInPoints;
		bool success, done;

		/* Sort arrays*/
		indexes = QuickSortNumbersWithIndexes(xs);
		RearrangeArray(ys, indexes);

		if(xs.Length == ys.Length && xs.Length != 0d){
			n = xs.Length;

			if(n == 1d || n == 2d){
				if(n == 1d){
					res = new double [1];
					res[0] = ys[0];
				}else{
					res = new double [2];
					res[0] = ys[0];
					res[1] = ys[1];
				}

				resultXs.numberArray = res;
				success = true;
			}else{
				bandwidthInPoints = Truncate(bandwidth*n);

				if(bandwidthInPoints >= 2d){
					res = new double [(int)(n)];
					residuals = new double [(int)(n)];

					robustnessWeights = new double [(int)(n)];
					arraysFillNumberArray(robustnessWeights, 1d);

					done = false;
					for(iter = 0d; iter <= robustnessIters && !done; iter = iter + 1d){
						bandwidthInterval = new double [2];
						bandwidthInterval[0] = 0d;
						bandwidthInterval[1] = bandwidthInPoints - 1d;

						for(i = 0d; i < n; i = i + 1d){
							x = xs[(int)(i)];

							if(i > 0d){
								left = bandwidthInterval[0];
								right = bandwidthInterval[1];

								nextRight = FindNextNonZeroElement(weights, right);
								nextLeft = left;
								for(; nextRight < xs.Length && xs[(int)(nextRight)] - xs[(int)(i)] < xs[(int)(i)] - xs[(int)(nextLeft)]; ){
									nextLeft = FindNextNonZeroElement(weights, bandwidthInterval[0]);
									bandwidthInterval[0] = nextLeft;
									bandwidthInterval[1] = nextRight;
									nextRight = FindNextNonZeroElement(weights, nextRight);
								}
							}

							ileft = bandwidthInterval[0];
							iright = bandwidthInterval[1];

							if(xs[(int)(i)] - xs[(int)(ileft)] > xs[(int)(iright)] - xs[(int)(i)]){
								edge = ileft;
							}else{
								edge = iright;
							}

							sumWeights = 0d;
							sumX = 0d;
							sumXSquared = 0d;
							sumY = 0d;
							sumXY = 0d;
							denom = Abs(1d/(xs[(int)(edge)] - x));
							for(k = ileft; k <= iright; k = k + 1d){
								xk = xs[(int)(k)];
								yk = ys[(int)(k)];

								if(k < i){
									dist = x - xk;
								}else{
									dist = xk - x;
								}

								w = Tricube(dist*denom)*robustnessWeights[(int)(k)]*weights[(int)(k)];
								xkw = xk*w;
								sumWeights = sumWeights + w;
								sumX = sumX + xkw;
								sumXSquared = sumXSquared + xk*xkw;
								sumY = sumY + yk*w;
								sumXY = sumXY + yk*xkw;
							}

							meanX = sumX/sumWeights;
							meanY = sumY/sumWeights;
							meanXY = sumXY/sumWeights;
							meanXSquared = sumXSquared/sumWeights;

							if(Sqrt(Abs(meanXSquared - meanX*meanX)) < accuracy){
								beta = 0d;
							}else{
								beta = (meanXY - meanX*meanY)/(meanXSquared - meanX*meanX);
							}

							alpha = meanY - beta*meanX;

							res[(int)(i)] = beta*x + alpha;

							residuals[(int)(i)] = Abs(ys[(int)(i)] - res[(int)(i)]);
						}

						if(iter == robustnessIters){
							done = true;
						}

						if(!done){
							sortedResiduals = arraysCopyNumberArray(residuals);
							QuickSortNumbers(sortedResiduals);

							medianResidual = sortedResiduals[(int)(n/2d)];

							if(Abs(medianResidual) < accuracy){
								done = true;
							}

							if(!done){
								for(i = 0d; i < n; i = i + 1d){
									arg = residuals[(int)(i)]/(6d*medianResidual);
									if(arg >= 1d){
										robustnessWeights[(int)(i)] = 0d;
									}else{
										w = 1d - arg*arg;
										robustnessWeights[(int)(i)] = w*w;
									}
								}
							}
						}
					}

					resultXs.numberArray = res;
					success = true;
				}else{
					success = false;
					errorMessage.stringx = "There must be at least two points.".ToCharArray();
				}
			}
		}else{
			success = false;
			errorMessage.stringx = "There must be equal number of points, and over zero.".ToCharArray();
		}

		return success;
	}


	public static void RearrangeArray(double [] asx, double [] indexes){
		double [] bs;
		double i;

		bs = new double [(int)(asx.Length)];

		AssignNumberArray(bs, asx);

		for(i = 0d; i < indexes.Length; i = i + 1d){
			asx[(int)(i)] = bs[(int)(indexes[(int)(i)])];
		}

		delete(bs);
	}


	public static void AssignNumberArray(double [] asx, double [] bs){
		double i;

		for(i = 0d; i < Min(asx.Length, bs.Length); i = i + 1d){
			asx[(int)(i)] = bs[(int)(i)];
		}
	}


	public static double FindNextNonZeroElement(double [] array, double offset){
		double position;
		bool done;

		done = false;
		for(position = offset + 1d; position < array.Length && !done; position = position + 1d){
			if(array[(int)(position)] != 0d){
				done = true;
			}
		}

		return position;
	}


	public static double Tricube(double x){
		double ax, result;

		ax = Abs(x);

		if(ax >= 1d){
			result = 0d;
		}else{
			result = 1d - ax*ax*ax;
			result = result*result*result;
		}

		return result;
	}


	public static bool CropLineWithinBoundary(NumberReference x1Ref, NumberReference y1Ref, NumberReference x2Ref, NumberReference y2Ref, double xMin, double xMax, double yMin, double yMax){
		double x1, y1, x2, y2;
		bool success, p1In, p2In;
		double dx, dy, f1, f2, f3, f4, f;

		x1 = x1Ref.numberValue;
		y1 = y1Ref.numberValue;
		x2 = x2Ref.numberValue;
		y2 = y2Ref.numberValue;

		p1In = x1 >= xMin && x1 <= xMax && y1 >= yMin && y1 <= yMax;
		p2In = x2 >= xMin && x2 <= xMax && y2 >= yMin && y2 <= yMax;

		if(p1In && p2In){
			success = true;
		}else if(!p1In && p2In){
			dx = x1 - x2;
			dy = y1 - y2;

			if(dx != 0d){
				f1 = (xMin - x2)/dx;
				f2 = (xMax - x2)/dx;
			}else{
				f1 = 1d;
				f2 = 1d;
			}
			if(dy != 0d){
				f3 = (yMin - y2)/dy;
				f4 = (yMax - y2)/dy;
			}else{
				f3 = 1d;
				f4 = 1d;
			}

			if(f1 < 0d){
				f1 = 1d;
			}
			if(f2 < 0d){
				f2 = 1d;
			}
			if(f3 < 0d){
				f3 = 1d;
			}
			if(f4 < 0d){
				f4 = 1d;
			}

			f = Min(f1, Min(f2, Min(f3, f4)));

			x1 = x2 + f*dx;
			y1 = y2 + f*dy;

			success = true;
		}else if(p1In && !p2In){
			dx = x2 - x1;
			dy = y2 - y1;

			if(dx != 0d){
				f1 = (xMin - x1)/dx;
				f2 = (xMax - x1)/dx;
			}else{
				f1 = 1d;
				f2 = 1d;
			}
			if(dy != 0d){
				f3 = (yMin - y1)/dy;
				f4 = (yMax - y1)/dy;
			}else{
				f3 = 1d;
				f4 = 1d;
			}

			if(f1 < 0d){
				f1 = 1d;
			}
			if(f2 < 0d){
				f2 = 1d;
			}
			if(f3 < 0d){
				f3 = 1d;
			}
			if(f4 < 0d){
				f4 = 1d;
			}

			f = Min(f1, Min(f2, Min(f3, f4)));

			x2 = x1 + f*dx;
			y2 = y1 + f*dy;

			success = true;
		}else{
			success = false;
		}

		x1Ref.numberValue = x1;
		y1Ref.numberValue = y1;
		x2Ref.numberValue = x2;
		y2Ref.numberValue = y2;

		return success;
	}


	public static double IncrementFromCoordinates(double x1, double y1, double x2, double y2){
		return (x2 - x1)/(y2 - y1);
	}


	public static double InterceptFromCoordinates(double x1, double y1, double x2, double y2){
		double a, b;

		a = IncrementFromCoordinates(x1, y1, x2, y2);
		b = y1 - a*x1;

		return b;
	}


	public static RGBA [] Get8HighContrastColors(){
		RGBA [] colors;
		colors = new RGBA [8];
		colors[0] = CreateRGBColor(3d/256d, 146d/256d, 206d/256d);
		colors[1] = CreateRGBColor(253d/256d, 83d/256d, 8d/256d);
		colors[2] = CreateRGBColor(102d/256d, 176d/256d, 50d/256d);
		colors[3] = CreateRGBColor(208d/256d, 234d/256d, 43d/256d);
		colors[4] = CreateRGBColor(167d/256d, 25d/256d, 75d/256d);
		colors[5] = CreateRGBColor(254d/256d, 254d/256d, 51d/256d);
		colors[6] = CreateRGBColor(134d/256d, 1d/256d, 175d/256d);
		colors[7] = CreateRGBColor(251d/256d, 153d/256d, 2d/256d);
		return colors;
	}


	public static void DrawFilledRectangleWithBorder(RGBABitmapImage image, double x, double y, double w, double h, RGBA borderColor, RGBA fillColor){
		if(h > 0d && w > 0d){
			DrawFilledRectangle(image, x, y, w, h, fillColor);
			DrawRectangle1px(image, x, y, w, h, borderColor);
		}
	}


	public static RGBABitmapImageReference CreateRGBABitmapImageReference(){
		RGBABitmapImageReference reference;

		reference = new RGBABitmapImageReference();
		reference.image = new RGBABitmapImage();
		reference.image.x = new RGBABitmap [0];

		return reference;
	}


	public static bool RectanglesOverlap(Rectangle r1, Rectangle r2){
		bool overlap;

		overlap = false;

		overlap = overlap || (r2.x1 >= r1.x1 && r2.x1 <= r1.x2 && r2.y1 >= r1.y1 && r2.y1 <= r1.y2);
		overlap = overlap || (r2.x2 >= r1.x1 && r2.x2 <= r1.x2 && r2.y1 >= r1.y1 && r2.y1 <= r1.y2);
		overlap = overlap || (r2.x1 >= r1.x1 && r2.x1 <= r1.x2 && r2.y2 >= r1.y1 && r2.y2 <= r1.y2);
		overlap = overlap || (r2.x2 >= r1.x1 && r2.x2 <= r1.x2 && r2.y2 >= r1.y1 && r2.y2 <= r1.y2);

		return overlap;
	}


	public static Rectangle CreateRectangle(double x1, double y1, double x2, double y2){
		Rectangle r;
		r = new Rectangle();
		r.x1 = x1;
		r.y1 = y1;
		r.x2 = x2;
		r.y2 = y2;
		return r;
	}


	public static void CopyRectangleValues(Rectangle rd, Rectangle rs){
		rd.x1 = rs.x1;
		rd.y1 = rs.y1;
		rd.x2 = rs.x2;
		rd.y2 = rs.y2;
	}


	public static void DrawXLabelsForPriority(double p, double xMin, double oy, double xMax, double xPixelMin, double xPixelMax, NumberReference nextRectangle, RGBA gridLabelColor, RGBABitmapImage canvas, double [] xGridPositions, StringArrayReference xLabels, NumberArrayReference xLabelPriorities, Rectangle [] occupied, bool textOnBottom){
		bool overlap, currentOverlaps;
		double i, j, x, px, padding;
		char [] text;
		Rectangle r;

		r = new Rectangle();
		padding = 10d;

		overlap = false;
		for(i = 0d; i < xLabels.stringArray.Length; i = i + 1d){
			if(xLabelPriorities.numberArray[(int)(i)] == p){

				x = xGridPositions[(int)(i)];
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax);
				text = xLabels.stringArray[(int)(i)].stringx;

				r.x1 = Floor(px - GetTextWidth(text)/2d);
				if(textOnBottom){
					r.y1 = Floor(oy + 5d);
				}else{
					r.y1 = Floor(oy - 20d);
				}
				r.x2 = r.x1 + GetTextWidth(text);
				r.y2 = r.y1 + GetTextHeight(text);

				/* Add padding*/
				r.x1 = r.x1 - padding;
				r.y1 = r.y1 - padding;
				r.x2 = r.x2 + padding;
				r.y2 = r.y2 + padding;

				currentOverlaps = false;

				for(j = 0d; j < nextRectangle.numberValue; j = j + 1d){
					currentOverlaps = currentOverlaps || RectanglesOverlap(r, occupied[(int)(j)]);
				}

				if(!currentOverlaps && p == 1d){
					DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor);

					CopyRectangleValues(occupied[(int)(nextRectangle.numberValue)], r);
					nextRectangle.numberValue = nextRectangle.numberValue + 1d;
				}

				overlap = overlap || currentOverlaps;
			}
		}
		if(!overlap && p != 1d){
			for(i = 0d; i < xGridPositions.Length; i = i + 1d){
				x = xGridPositions[(int)(i)];
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax);

				if(xLabelPriorities.numberArray[(int)(i)] == p){
					text = xLabels.stringArray[(int)(i)].stringx;

					r.x1 = Floor(px - GetTextWidth(text)/2d);
					if(textOnBottom){
						r.y1 = Floor(oy + 5d);
					}else{
						r.y1 = Floor(oy - 20d);
					}
					r.x2 = r.x1 + GetTextWidth(text);
					r.y2 = r.y1 + GetTextHeight(text);

					DrawText(canvas, r.x1, r.y1, text, gridLabelColor);

					CopyRectangleValues(occupied[(int)(nextRectangle.numberValue)], r);
					nextRectangle.numberValue = nextRectangle.numberValue + 1d;
				}
			}
		}
	}


	public static void DrawYLabelsForPriority(double p, double yMin, double ox, double yMax, double yPixelMin, double yPixelMax, NumberReference nextRectangle, RGBA gridLabelColor, RGBABitmapImage canvas, double [] yGridPositions, StringArrayReference yLabels, NumberArrayReference yLabelPriorities, Rectangle [] occupied, bool textOnLeft){
		bool overlap, currentOverlaps;
		double i, j, y, py, padding;
		char [] text;
		Rectangle r;

		r = new Rectangle();
		padding = 10d;

		overlap = false;
		for(i = 0d; i < yLabels.stringArray.Length; i = i + 1d){
			if(yLabelPriorities.numberArray[(int)(i)] == p){

				y = yGridPositions[(int)(i)];
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax);
				text = yLabels.stringArray[(int)(i)].stringx;

				if(textOnLeft){
					r.x1 = Floor(ox - GetTextWidth(text) - 10d);
				}else{
					r.x1 = Floor(ox + 10d);
				}
				r.y1 = Floor(py - 6d);
				r.x2 = r.x1 + GetTextWidth(text);
				r.y2 = r.y1 + GetTextHeight(text);

				/* Add padding*/
				r.x1 = r.x1 - padding;
				r.y1 = r.y1 - padding;
				r.x2 = r.x2 + padding;
				r.y2 = r.y2 + padding;

				currentOverlaps = false;

				for(j = 0d; j < nextRectangle.numberValue; j = j + 1d){
					currentOverlaps = currentOverlaps || RectanglesOverlap(r, occupied[(int)(j)]);
				}

				/* Draw labels with priority 1 if they do not overlap anything else.*/
				if(!currentOverlaps && p == 1d){
					DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor);

					CopyRectangleValues(occupied[(int)(nextRectangle.numberValue)], r);
					nextRectangle.numberValue = nextRectangle.numberValue + 1d;
				}

				overlap = overlap || currentOverlaps;
			}
		}
		if(!overlap && p != 1d){
			for(i = 0d; i < yGridPositions.Length; i = i + 1d){
				y = yGridPositions[(int)(i)];
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax);

				if(yLabelPriorities.numberArray[(int)(i)] == p){
					text = yLabels.stringArray[(int)(i)].stringx;

					if(textOnLeft){
						r.x1 = Floor(ox - GetTextWidth(text) - 10d);
					}else{
						r.x1 = Floor(ox + 10d);
					}
					r.y1 = Floor(py - 6d);
					r.x2 = r.x1 + GetTextWidth(text);
					r.y2 = r.y1 + GetTextHeight(text);

					DrawText(canvas, r.x1, r.y1, text, gridLabelColor);

					CopyRectangleValues(occupied[(int)(nextRectangle.numberValue)], r);
					nextRectangle.numberValue = nextRectangle.numberValue + 1d;
				}
			}
		}
	}


	public static double [] ComputeGridLinePositions(double cMin, double cMax, StringArrayReference labels, NumberArrayReference priorities){
		double [] positions;
		double cLength, p, pMin, pMax, pInterval, pNum, i, num, rem, priority, mode;

		cLength = cMax - cMin;

		p = Floor(Log10(cLength));
		pInterval = Pow(10d, p);
		/* gives 10-1 lines for 100-10 diff*/
		pMin = Ceiling(cMin/pInterval)*pInterval;
		pMax = Floor(cMax/pInterval)*pInterval;
		pNum = Roundx((pMax - pMin)/pInterval + 1d);

		mode = 1d;

		if(pNum <= 3d){
			p = Floor(Log10(cLength) - 1d);
			/* gives 100-10 lines for 100-10 diff*/
			pInterval = Pow(10d, p);
			pMin = Ceiling(cMin/pInterval)*pInterval;
			pMax = Floor(cMax/pInterval)*pInterval;
			pNum = Roundx((pMax - pMin)/pInterval + 1d);

			mode = 4d;
		}else if(pNum <= 6d){
			p = Floor(Log10(cLength));
			pInterval = Pow(10d, p)/4d;
			/* gives 40-5 lines for 100-10 diff*/
			pMin = Ceiling(cMin/pInterval)*pInterval;
			pMax = Floor(cMax/pInterval)*pInterval;
			pNum = Roundx((pMax - pMin)/pInterval + 1d);

			mode = 3d;
		}else if(pNum <= 10d){
			p = Floor(Log10(cLength));
			pInterval = Pow(10d, p)/2d;
			/* gives 20-3 lines for 100-10 diff*/
			pMin = Ceiling(cMin/pInterval)*pInterval;
			pMax = Floor(cMax/pInterval)*pInterval;
			pNum = Roundx((pMax - pMin)/pInterval + 1d);

			mode = 2d;
		}

		positions = new double [(int)(pNum)];
		labels.stringArray = new StringReference [(int)(pNum)];
		priorities.numberArray = new double [(int)(pNum)];

		for(i = 0d; i < pNum; i = i + 1d){
			num = pMin + pInterval*i;
			positions[(int)(i)] = num;

			/* Always print priority 1 labels. Only draw priority 2 if they can all be drawn. Then, only draw priority 3 if they can all be drawn.*/
			priority = 1d;

			/* Prioritize x.25, x.5 and x.75 lower.*/
			if(mode == 2d || mode == 3d){
				rem = Abs((double)Round(num/Pow(10d, p - 2d)))%100d;

				priority = 1d;
				if(rem == 50d){
					priority = 2d;
				}else if(rem == 25d || rem == 75d){
					priority = 3d;
				}
			}

			/* Prioritize x.1-x.4 and x.6-x.9 lower*/
			if(mode == 4d){
				rem = Abs(Roundx(num/Pow(10d, p)))%10d;

				priority = 1d;
				if(rem == 1d || rem == 2d || rem == 3d || rem == 4d || rem == 6d || rem == 7d || rem == 8d || rem == 9d){
					priority = 2d;
				}
			}

			/* 0 has lowest priority.*/
			if(EpsilonCompare(num, 0d, Pow(10d, p - 5d))){
				priority = 3d;
			}

			priorities.numberArray[(int)(i)] = priority;

			/* The label itself.*/
			labels.stringArray[(int)(i)] = new StringReference();
			if(p < 0d){
				if(mode == 2d || mode == 3d){
					num = RoundToDigits(num, -(p - 1d));
				}else{
					num = RoundToDigits(num, -p);
				}
			}
			labels.stringArray[(int)(i)].stringx = CreateStringDecimalFromNumber(num);
		}

		return positions;
	}


	public static double MapYCoordinate(double y, double yMin, double yMax, double yPixelMin, double yPixelMax){
		double yLength, yPixelLength;

		yLength = yMax - yMin;
		yPixelLength = yPixelMax - yPixelMin;

		y = y - yMin;
		y = y*yPixelLength/yLength;
		y = yPixelLength - y;
		y = y + yPixelMin;
		return y;
	}


	public static double MapXCoordinate(double x, double xMin, double xMax, double xPixelMin, double xPixelMax){
		double xLength, xPixelLength;

		xLength = xMax - xMin;
		xPixelLength = xPixelMax - xPixelMin;

		x = x - xMin;
		x = x*xPixelLength/xLength;
		x = x + xPixelMin;
		return x;
	}


	public static double MapXCoordinateAutoSettings(double x, RGBABitmapImage image, double [] xs){
		return MapXCoordinate(x, GetMinimum(xs), GetMaximum(xs), GetDefaultPaddingPercentage()*ImageWidth(image), (1d - GetDefaultPaddingPercentage())*ImageWidth(image));
	}


	public static double MapYCoordinateAutoSettings(double y, RGBABitmapImage image, double [] ys){
		return MapYCoordinate(y, GetMinimum(ys), GetMaximum(ys), GetDefaultPaddingPercentage()*ImageHeight(image), (1d - GetDefaultPaddingPercentage())*ImageHeight(image));
	}


	public static double MapXCoordinateBasedOnSettings(double x, ScatterPlotSettings settings){
		double xMin, xMax, xPadding, xPixelMin, xPixelMax;
		Rectangle boundaries;

		boundaries = new Rectangle();
		ComputeBoundariesBasedOnSettings(settings, boundaries);
		xMin = boundaries.x1;
		xMax = boundaries.x2;

		if(settings.autoPadding){
			xPadding = Floor(GetDefaultPaddingPercentage()*settings.width);
		}else{
			xPadding = settings.xPadding;
		}

		xPixelMin = xPadding;
		xPixelMax = settings.width - xPadding;

		return MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax);
	}


	public static double MapYCoordinateBasedOnSettings(double y, ScatterPlotSettings settings){
		double yMin, yMax, yPadding, yPixelMin, yPixelMax;
		Rectangle boundaries;

		boundaries = new Rectangle();
		ComputeBoundariesBasedOnSettings(settings, boundaries);
		yMin = boundaries.y1;
		yMax = boundaries.y2;

		if(settings.autoPadding){
			yPadding = Floor(GetDefaultPaddingPercentage()*settings.height);
		}else{
			yPadding = settings.yPadding;
		}

		yPixelMin = yPadding;
		yPixelMax = settings.height - yPadding;

		return MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax);
	}


	public static double GetDefaultPaddingPercentage(){
		return 0.10;
	}


	public static void DrawText(RGBABitmapImage canvas, double x, double y, char [] text, RGBA color){
		double i, charWidth, spacing;

		charWidth = 8d;
		spacing = 2d;

		for(i = 0d; i < text.Length; i = i + 1d){
			DrawAsciiCharacter(canvas, x + i*(charWidth + spacing), y, text[(int)(i)], color);
		}
	}


	public static void DrawTextUpwards(RGBABitmapImage canvas, double x, double y, char [] text, RGBA color){
		RGBABitmapImage buffer, rotated;

		buffer = CreateImage(GetTextWidth(text), GetTextHeight(text), GetTransparent());
		DrawText(buffer, 0d, 0d, text, color);
		rotated = RotateAntiClockwise90Degrees(buffer);
		DrawImageOnImage(canvas, rotated, x, y);
		DeleteImage(buffer);
		DeleteImage(rotated);
	}


	public static ScatterPlotSettings GetDefaultScatterPlotSettings(){
		ScatterPlotSettings settings;

		settings = new ScatterPlotSettings();

		settings.autoBoundaries = true;
		settings.xMax = 0d;
		settings.xMin = 0d;
		settings.yMax = 0d;
		settings.yMin = 0d;
		settings.autoPadding = true;
		settings.xPadding = 0d;
		settings.yPadding = 0d;
		settings.title = "".ToCharArray();
		settings.xLabel = "".ToCharArray();
		settings.yLabel = "".ToCharArray();
		settings.scatterPlotSeries = new ScatterPlotSeries [0];
		settings.showGrid = true;
		settings.gridColor = GetGray(0.1);
		settings.xAxisAuto = true;
		settings.xAxisTop = false;
		settings.xAxisBottom = false;
		settings.yAxisAuto = true;
		settings.yAxisLeft = false;
		settings.yAxisRight = false;

		return settings;
	}


	public static ScatterPlotSeries GetDefaultScatterPlotSeriesSettings(){
		ScatterPlotSeries series;

		series = new ScatterPlotSeries();

		series.linearInterpolation = true;
		series.pointType = "pixels".ToCharArray();
		series.lineType = "solid".ToCharArray();
		series.lineThickness = 1d;
		series.xs = new double [0];
		series.ys = new double [0];
		series.color = GetBlack();

		return series;
	}


	public static bool DrawScatterPlot(RGBABitmapImageReference canvasReference, double width, double height, double [] xs, double [] ys, StringReference errorMessage){
		ScatterPlotSettings settings;
		bool success;

		settings = GetDefaultScatterPlotSettings();

		settings.width = width;
		settings.height = height;
		settings.scatterPlotSeries = new ScatterPlotSeries [1];
		settings.scatterPlotSeries[0] = GetDefaultScatterPlotSeriesSettings();
		delete(settings.scatterPlotSeries[0].xs);
		settings.scatterPlotSeries[0].xs = xs;
		delete(settings.scatterPlotSeries[0].ys);
		settings.scatterPlotSeries[0].ys = ys;

		success = DrawScatterPlotFromSettings(canvasReference, settings, errorMessage);

		return success;
	}


	public static bool DrawScatterPlotFromSettings(RGBABitmapImageReference canvasReference, ScatterPlotSettings settings, StringReference errorMessage){
		double xMin, xMax, yMin, yMax, xLength, yLength, i, x, y, xPrev, yPrev, px, py, pxPrev, pyPrev, originX, originY, p, l, plot;
		Rectangle boundaries;
		double xPadding, yPadding, originXPixels, originYPixels;
		double xPixelMin, yPixelMin, xPixelMax, yPixelMax, xLengthPixels, yLengthPixels, axisLabelPadding;
		NumberReference nextRectangle, x1Ref, y1Ref, x2Ref, y2Ref, patternOffset;
		bool prevSet, success;
		RGBA gridLabelColor;
		RGBABitmapImage canvas;
		double [] xs, ys;
		bool linearInterpolation;
		ScatterPlotSeries sp;
		double [] xGridPositions, yGridPositions;
		StringArrayReference xLabels, yLabels;
		NumberArrayReference xLabelPriorities, yLabelPriorities;
		Rectangle [] occupied;
		bool [] linePattern;
		bool originXInside, originYInside, textOnLeft, textOnBottom;
		double originTextX, originTextY, originTextXPixels, originTextYPixels, side, yaxis;

		canvas = CreateImage(settings.width, settings.height, GetWhite());
		patternOffset = CreateNumberReference(0d);

		success = ScatterPlotFromSettingsValid(settings, errorMessage);

		if(success){

			boundaries = new Rectangle();
			ComputeBoundariesBasedOnSettings(settings, boundaries);
			xMin = boundaries.x1;
			yMin = boundaries.y1;
			xMax = boundaries.x2;
			yMax = boundaries.y2;

			/* If zero, set to defaults.*/
			if(xMin - xMax == 0d){
				xMin = 0d;
				xMax = 10d;
			}

			if(yMin - yMax == 0d){
				yMin = 0d;
				yMax = 10d;
			}

			xLength = xMax - xMin;
			yLength = yMax - yMin;

			if(settings.autoPadding){
				xPadding = Floor(GetDefaultPaddingPercentage()*settings.width);
				yPadding = Floor(GetDefaultPaddingPercentage()*settings.height);
			}else{
				xPadding = settings.xPadding;
				yPadding = settings.yPadding;
			}

			/* Draw title*/
			DrawText(canvas, Floor(settings.width/2d - GetTextWidth(settings.title)/2d), Floor(yPadding/3d), settings.title, GetBlack());

			/* Draw grid*/
			xPixelMin = xPadding;
			yPixelMin = yPadding;
			xPixelMax = settings.width - xPadding;
			yPixelMax = settings.height - yPadding;
			xLengthPixels = xPixelMax - xPixelMin;
			yLengthPixels = yPixelMax - yPixelMin;
			DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor);

			gridLabelColor = GetGray(0.5);

			xLabels = new StringArrayReference();
			xLabelPriorities = new NumberArrayReference();
			yLabels = new StringArrayReference();
			yLabelPriorities = new NumberArrayReference();
			xGridPositions = ComputeGridLinePositions(xMin, xMax, xLabels, xLabelPriorities);
			yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities);

			if(settings.showGrid){
				/* X-grid*/
				for(i = 0d; i < xGridPositions.Length; i = i + 1d){
					x = xGridPositions[(int)(i)];
					px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax);
					DrawLine1px(canvas, px, yPixelMin, px, yPixelMax, settings.gridColor);
				}

				/* Y-grid*/
				for(i = 0d; i < yGridPositions.Length; i = i + 1d){
					y = yGridPositions[(int)(i)];
					py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax);
					DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor);
				}
			}

			/* Compute origin information.*/
			originYInside = yMin < 0d && yMax > 0d;
			originY = 0d;
			if(settings.xAxisAuto){
				if(originYInside){
					originY = 0d;
				}else{
					originY = yMin;
				}
			}else{
if(settings.xAxisTop){
					originY = yMax;
				}
				if(settings.xAxisBottom){
					originY = yMin;
				}
			}
			originYPixels = MapYCoordinate(originY, yMin, yMax, yPixelMin, yPixelMax);

			originXInside = xMin < 0d && xMax > 0d;
			originX = 0d;
			if(settings.yAxisAuto){
				if(originXInside){
					originX = 0d;
				}else{
					originX = xMin;
				}
			}else{
if(settings.yAxisLeft){
					originX = xMin;
				}
				if(settings.yAxisRight){
					originX = xMax;
				}
			}
			originXPixels = MapXCoordinate(originX, xMin, xMax, xPixelMin, xPixelMax);

			if(originYInside){
				originTextY = 0d;
			}else{
				originTextY = yMin + yLength/2d;
			}
			originTextYPixels = MapYCoordinate(originTextY, yMin, yMax, yPixelMin, yPixelMax);

			if(originXInside){
				originTextX = 0d;
			}else{
				originTextX = xMin + xLength/2d;
			}
			originTextXPixels = MapXCoordinate(originTextX, xMin, xMax, xPixelMin, xPixelMax);

			/* Labels*/
			occupied = new Rectangle [(int)(xLabels.stringArray.Length + yLabels.stringArray.Length)];
			for(i = 0d; i < occupied.Length; i = i + 1d){
				occupied[(int)(i)] = CreateRectangle(0d, 0d, 0d, 0d);
			}
			nextRectangle = CreateNumberReference(0d);

			/* x labels*/
			for(i = 1d; i <= 5d; i = i + 1d){
				textOnBottom = true;
				if(!settings.xAxisAuto && settings.xAxisTop){
					textOnBottom = false;
				}
				DrawXLabelsForPriority(i, xMin, originYPixels, xMax, xPixelMin, xPixelMax, nextRectangle, gridLabelColor, canvas, xGridPositions, xLabels, xLabelPriorities, occupied, textOnBottom);
			}

			/* y labels*/
			for(i = 1d; i <= 5d; i = i + 1d){
				textOnLeft = true;
				if(!settings.yAxisAuto && settings.yAxisRight){
					textOnLeft = false;
				}
				DrawYLabelsForPriority(i, yMin, originXPixels, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, textOnLeft);
			}

			/* Draw origin line axis titles.*/
			axisLabelPadding = 20d;

			/* x origin line*/
			if(originYInside){
				DrawLine1px(canvas, Roundx(xPixelMin), Roundx(originYPixels), Roundx(xPixelMax), Roundx(originYPixels), GetBlack());
			}

			/* y origin line*/
			if(originXInside){
				DrawLine1px(canvas, Roundx(originXPixels), Roundx(yPixelMin), Roundx(originXPixels), Roundx(yPixelMax), GetBlack());
			}

			/* Draw origin axis titles.*/
			DrawTextUpwards(canvas, 10d, Floor(originTextYPixels - GetTextWidth(settings.yLabel)/2d), settings.yLabel, GetBlack());
			DrawText(canvas, Floor(originTextXPixels - GetTextWidth(settings.xLabel)/2d), yPixelMax + axisLabelPadding, settings.xLabel, GetBlack());

			/* X-grid-markers*/
			for(i = 0d; i < xGridPositions.Length; i = i + 1d){
				x = xGridPositions[(int)(i)];
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax);
				p = xLabelPriorities.numberArray[(int)(i)];
				l = 1d;
				if(p == 1d){
					l = 8d;
				}else if(p == 2d){
					l = 3d;
				}
				side = -1d;
				if(!settings.xAxisAuto && settings.xAxisTop){
					side = 1d;
				}
				DrawLine1px(canvas, px, originYPixels, px, originYPixels + side*l, GetBlack());
			}

			/* Y-grid-markers*/
			for(i = 0d; i < yGridPositions.Length; i = i + 1d){
				y = yGridPositions[(int)(i)];
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax);
				p = yLabelPriorities.numberArray[(int)(i)];
				l = 1d;
				if(p == 1d){
					l = 8d;
				}else if(p == 2d){
					l = 3d;
				}
				side = 1d;
				if(!settings.yAxisAuto && settings.yAxisRight){
					side = -1d;
				}
				DrawLine1px(canvas, originXPixels, py, originXPixels + side*l, py, GetBlack());
			}

			/* Draw points*/
			for(plot = 0d; plot < settings.scatterPlotSeries.Length; plot = plot + 1d){
				sp = settings.scatterPlotSeries[(int)(plot)];

				xs = sp.xs;
				ys = sp.ys;
				linearInterpolation = sp.linearInterpolation;

				x1Ref = new NumberReference();
				y1Ref = new NumberReference();
				x2Ref = new NumberReference();
				y2Ref = new NumberReference();
				if(linearInterpolation){
					prevSet = false;
					xPrev = 0d;
					yPrev = 0d;
					for(i = 0d; i < xs.Length; i = i + 1d){
						x = xs[(int)(i)];
						y = ys[(int)(i)];

						if(prevSet){
							x1Ref.numberValue = xPrev;
							y1Ref.numberValue = yPrev;
							x2Ref.numberValue = x;
							y2Ref.numberValue = y;

							success = CropLineWithinBoundary(x1Ref, y1Ref, x2Ref, y2Ref, xMin, xMax, yMin, yMax);

							if(success){
								pxPrev = Floor(MapXCoordinate(x1Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax));
								pyPrev = Floor(MapYCoordinate(y1Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax));
								px = Floor(MapXCoordinate(x2Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax));
								py = Floor(MapYCoordinate(y2Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax));

								if(arraysStringsEqual(sp.lineType, "solid".ToCharArray()) && sp.lineThickness == 1d){
									DrawLine1px(canvas, pxPrev, pyPrev, px, py, sp.color);
								}else if(arraysStringsEqual(sp.lineType, "solid".ToCharArray())){
									DrawLine(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, sp.color);
								}else if(arraysStringsEqual(sp.lineType, "dashed".ToCharArray())){
									linePattern = GetLinePattern1();
									DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color);
								}else if(arraysStringsEqual(sp.lineType, "dotted".ToCharArray())){
									linePattern = GetLinePattern2();
									DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color);
								}else if(arraysStringsEqual(sp.lineType, "dotdash".ToCharArray())){
									linePattern = GetLinePattern3();
									DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color);
								}else if(arraysStringsEqual(sp.lineType, "longdash".ToCharArray())){
									linePattern = GetLinePattern4();
									DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color);
								}else if(arraysStringsEqual(sp.lineType, "twodash".ToCharArray())){
									linePattern = GetLinePattern5();
									DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color);
								}
							}
						}

						prevSet = true;
						xPrev = x;
						yPrev = y;
					}
				}else{
					for(i = 0d; i < xs.Length; i = i + 1d){
						x = xs[(int)(i)];
						y = ys[(int)(i)];

						if(x > xMin && x < xMax && y > yMin && y < yMax){

							x = Floor(MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax));
							y = Floor(MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax));

							if(arraysStringsEqual(sp.pointType, "crosses".ToCharArray())){
								DrawPixel(canvas, x, y, sp.color);
								DrawPixel(canvas, x + 1d, y, sp.color);
								DrawPixel(canvas, x + 2d, y, sp.color);
								DrawPixel(canvas, x - 1d, y, sp.color);
								DrawPixel(canvas, x - 2d, y, sp.color);
								DrawPixel(canvas, x, y + 1d, sp.color);
								DrawPixel(canvas, x, y + 2d, sp.color);
								DrawPixel(canvas, x, y - 1d, sp.color);
								DrawPixel(canvas, x, y - 2d, sp.color);
							}else if(arraysStringsEqual(sp.pointType, "circles".ToCharArray())){
								DrawCircle(canvas, x, y, 3d, sp.color);
							}else if(arraysStringsEqual(sp.pointType, "dots".ToCharArray())){
								DrawFilledCircle(canvas, x, y, 3d, sp.color);
							}else if(arraysStringsEqual(sp.pointType, "triangles".ToCharArray())){
								DrawTriangle(canvas, x, y, 3d, sp.color);
							}else if(arraysStringsEqual(sp.pointType, "filled triangles".ToCharArray())){
								DrawFilledTriangle(canvas, x, y, 3d, sp.color);
							}else if(arraysStringsEqual(sp.pointType, "pixels".ToCharArray())){
								DrawPixel(canvas, x, y, sp.color);
							}else if(arraysStringsEqual(sp.pointType, "dotlinetoxaxis".ToCharArray())){
								DrawFilledCircle(canvas, x, y, 3d, sp.color);
								yaxis = Floor(MapYCoordinate(0d, yMin, yMax, yPixelMin, yPixelMax));
								yaxis = Min(Max(yaxis, yPixelMin), yPixelMax);
								DrawLine(canvas, x, y, x, yaxis, sp.lineThickness, sp.color);
							}
						}
					}
				}
			}

			canvasReference.image = canvas;
		}

		return success;
	}


	public static void ComputeBoundariesBasedOnSettings(ScatterPlotSettings settings, Rectangle boundaries){
		ScatterPlotSeries sp;
		double plot, xMin, xMax, yMin, yMax;

		if(settings.scatterPlotSeries.Length >= 1d){
			xMin = GetMinimum(settings.scatterPlotSeries[0].xs)*1.05;
			xMax = GetMaximum(settings.scatterPlotSeries[0].xs)*1.05;
			yMin = GetMinimum(settings.scatterPlotSeries[0].ys)*1.05;
			yMax = GetMaximum(settings.scatterPlotSeries[0].ys)*1.05;
		}else{
			xMin = -10d;
			xMax = 10d;
			yMin = -10d;
			yMax = 10d;
		}

		if(!settings.autoBoundaries){
			xMin = settings.xMin;
			xMax = settings.xMax;
			yMin = settings.yMin;
			yMax = settings.yMax;
		}else{
			for(plot = 1d; plot < settings.scatterPlotSeries.Length; plot = plot + 1d){
				sp = settings.scatterPlotSeries[(int)(plot)];

				xMin = Min(xMin, GetMinimum(sp.xs));
				xMax = Max(xMax, GetMaximum(sp.xs));
				yMin = Min(yMin, GetMinimum(sp.ys));
				yMax = Max(yMax, GetMaximum(sp.ys));
			}
		}

		boundaries.x1 = xMin;
		boundaries.y1 = yMin;
		boundaries.x2 = xMax;
		boundaries.y2 = yMax;
	}


	public static bool ScatterPlotFromSettingsValid(ScatterPlotSettings settings, StringReference errorMessage){
		bool success, found;
		ScatterPlotSeries series;
		double i;

		success = true;

		/* Check axis placement.*/
		if(!settings.xAxisAuto){
			if(settings.xAxisTop && settings.xAxisBottom){
				success = false;
				errorMessage.stringx = "x-axis not automatic and configured to be both on top and on bottom.".ToCharArray();
			}
			if(!settings.xAxisTop && !settings.xAxisBottom){
				success = false;
				errorMessage.stringx = "x-axis not automatic and configured to be neither on top nor on bottom.".ToCharArray();
			}
		}

		if(!settings.yAxisAuto){
			if(settings.yAxisLeft && settings.yAxisRight){
				success = false;
				errorMessage.stringx = "y-axis not automatic and configured to be both on top and on bottom.".ToCharArray();
			}
			if(!settings.yAxisLeft && !settings.yAxisRight){
				success = false;
				errorMessage.stringx = "y-axis not automatic and configured to be neither on top nor on bottom.".ToCharArray();
			}
		}

		/* Check series lengths.*/
		for(i = 0d; i < settings.scatterPlotSeries.Length; i = i + 1d){
			series = settings.scatterPlotSeries[(int)(i)];
			if(series.xs.Length != series.ys.Length){
				success = false;
				errorMessage.stringx = "x and y series must be of the same length.".ToCharArray();
			}
			if(series.xs.Length == 0d){
				success = false;
				errorMessage.stringx = "There must be data in the series to be plotted.".ToCharArray();
			}
			if(series.linearInterpolation && series.xs.Length == 1d){
				success = false;
				errorMessage.stringx = "Linear interpolation requires at least two data points to be plotted.".ToCharArray();
			}
		}

		/* Check bounds.*/
		if(!settings.autoBoundaries){
			if(settings.xMin >= settings.xMax){
				success = false;
				errorMessage.stringx = "x min is higher than or equal to x max.".ToCharArray();
			}
			if(settings.yMin >= settings.yMax){
				success = false;
				errorMessage.stringx = "y min is higher than or equal to y max.".ToCharArray();
			}
		}

		/* Check padding.*/
		if(!settings.autoPadding){
			if(2d*settings.xPadding >= settings.width){
				success = false;
				errorMessage.stringx = "The x padding is more then the width.".ToCharArray();
			}
			if(2d*settings.yPadding >= settings.height){
				success = false;
				errorMessage.stringx = "The y padding is more then the height.".ToCharArray();
			}
		}

		/* Check width and height.*/
		if(settings.width < 0d){
			success = false;
			errorMessage.stringx = "The width is less than 0.".ToCharArray();
		}
		if(settings.height < 0d){
			success = false;
			errorMessage.stringx = "The height is less than 0.".ToCharArray();
		}

		/* Check point types.*/
		for(i = 0d; i < settings.scatterPlotSeries.Length; i = i + 1d){
			series = settings.scatterPlotSeries[(int)(i)];

			if(series.lineThickness < 0d){
				success = false;
				errorMessage.stringx = "The line thickness is less than 0.".ToCharArray();
			}

			if(!series.linearInterpolation){
				/* Point type.*/
				found = false;
				if(arraysStringsEqual(series.pointType, "crosses".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.pointType, "circles".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.pointType, "dots".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.pointType, "triangles".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.pointType, "filled triangles".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.pointType, "pixels".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.pointType, "dotlinetoxaxis".ToCharArray())){
					found = true;
				}
				if(!found){
					success = false;
					errorMessage.stringx = "The point type is unknown.".ToCharArray();
				}
			}else{
				/* Line type.*/
				found = false;
				if(arraysStringsEqual(series.lineType, "solid".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.lineType, "dashed".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.lineType, "dotted".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.lineType, "dotdash".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.lineType, "longdash".ToCharArray())){
					found = true;
				}else if(arraysStringsEqual(series.lineType, "twodash".ToCharArray())){
					found = true;
				}

				if(!found){
					success = false;
					errorMessage.stringx = "The line type is unknown.".ToCharArray();
				}
			}
		}

		return success;
	}


	public static BarPlotSettings GetDefaultBarPlotSettings(){
		BarPlotSettings settings;

		settings = new BarPlotSettings();

		settings.width = 800d;
		settings.height = 600d;
		settings.autoBoundaries = true;
		settings.yMax = 0d;
		settings.yMin = 0d;
		settings.autoPadding = true;
		settings.xPadding = 0d;
		settings.yPadding = 0d;
		settings.title = "".ToCharArray();
		settings.yLabel = "".ToCharArray();
		settings.barPlotSeries = new BarPlotSeries [0];
		settings.showGrid = true;
		settings.gridColor = GetGray(0.1);
		settings.autoColor = true;
		settings.grayscaleAutoColor = false;
		settings.autoSpacing = true;
		settings.groupSeparation = 0d;
		settings.barSeparation = 0d;
		settings.autoLabels = true;
		settings.xLabels = new StringReference [0];
		/*settings.autoLabels = false;
        settings.xLabels = new StringReference [5];
        settings.xLabels[0] = CreateStringReference("may 20".toCharArray());
        settings.xLabels[1] = CreateStringReference("jun 20".toCharArray());
        settings.xLabels[2] = CreateStringReference("jul 20".toCharArray());
        settings.xLabels[3] = CreateStringReference("aug 20".toCharArray());
        settings.xLabels[4] = CreateStringReference("sep 20".toCharArray());*/
		settings.barBorder = false;

		return settings;
	}


	public static BarPlotSeries GetDefaultBarPlotSeriesSettings(){
		BarPlotSeries series;

		series = new BarPlotSeries();

		series.ys = new double [0];
		series.color = GetBlack();

		return series;
	}


	public static RGBABitmapImage DrawBarPlotNoErrorCheck(double width, double height, double [] ys){
		StringReference errorMessage;
		bool success;
		RGBABitmapImageReference canvasReference;

		errorMessage = new StringReference();
		canvasReference = CreateRGBABitmapImageReference();

		success = DrawBarPlot(canvasReference, width, height, ys, errorMessage);

		FreeStringReference(errorMessage);

		return canvasReference.image;
	}


	public static bool DrawBarPlot(RGBABitmapImageReference canvasReference, double width, double height, double [] ys, StringReference errorMessage){
		BarPlotSettings settings;
		bool success;

		errorMessage = new StringReference();
		settings = GetDefaultBarPlotSettings();

		settings.barPlotSeries = new BarPlotSeries [1];
		settings.barPlotSeries[0] = GetDefaultBarPlotSeriesSettings();
		delete(settings.barPlotSeries[0].ys);
		settings.barPlotSeries[0].ys = ys;
		settings.width = width;
		settings.height = height;

		success = DrawBarPlotFromSettings(canvasReference, settings, errorMessage);

		return success;
	}


	public static bool DrawBarPlotFromSettings(RGBABitmapImageReference canvasReference, BarPlotSettings settings, StringReference errorMessage){
		double xPadding, yPadding;
		double xPixelMin, yPixelMin, yPixelMax, xPixelMax;
		double xLengthPixels, yLengthPixels;
		double s, n, y, x, w, h, yMin, yMax, b, i, py, yValue;
		RGBA [] colors;
		double [] ys, yGridPositions;
		double yTop, yBottom, ss, bs;
		double groupSeparation, barSeparation, barWidth, textwidth;
		StringArrayReference yLabels;
		NumberArrayReference yLabelPriorities;
		Rectangle [] occupied;
		NumberReference nextRectangle;
		RGBA gridLabelColor, barColor;
		char [] label;
		bool success;
		RGBABitmapImage canvas;

		success = BarPlotSettingsIsValid(settings, errorMessage);

		if(success){
			canvas = CreateImage(settings.width, settings.height, GetWhite());

			ss = settings.barPlotSeries.Length;
			gridLabelColor = GetGray(0.5);

			/* padding*/
			if(settings.autoPadding){
				xPadding = Floor(GetDefaultPaddingPercentage()*ImageWidth(canvas));
				yPadding = Floor(GetDefaultPaddingPercentage()*ImageHeight(canvas));
			}else{
				xPadding = settings.xPadding;
				yPadding = settings.yPadding;
			}

			/* Draw title*/
			DrawText(canvas, Floor(ImageWidth(canvas)/2d - GetTextWidth(settings.title)/2d), Floor(yPadding/3d), settings.title, GetBlack());
			DrawTextUpwards(canvas, 10d, Floor(ImageHeight(canvas)/2d - GetTextWidth(settings.yLabel)/2d), settings.yLabel, GetBlack());

			/* min and max*/
			if(settings.autoBoundaries){
				if(ss >= 1d){
					yMax = GetMaximum(settings.barPlotSeries[0].ys)*1.05;
					yMin = Min(0d, GetMinimum(settings.barPlotSeries[0].ys))*1.05;

					for(s = 0d; s < ss; s = s + 1d){
						yMax = Max(yMax, GetMaximum(settings.barPlotSeries[(int)(s)].ys));
						yMin = Min(yMin, GetMinimum(settings.barPlotSeries[(int)(s)].ys));
					}
				}else{
					yMax = 10d;
					yMin = 0d;
				}
			}else{
				yMin = settings.yMin;
				yMax = settings.yMax;
			}

			/* boundaries*/
			xPixelMin = xPadding;
			yPixelMin = yPadding;
			xPixelMax = ImageWidth(canvas) - xPadding;
			yPixelMax = ImageHeight(canvas) - yPadding;
			xLengthPixels = xPixelMax - xPixelMin;
			yLengthPixels = yPixelMax - yPixelMin;

			/* Draw boundary.*/
			DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor);

			/* Draw grid lines.*/
			yLabels = new StringArrayReference();
			yLabelPriorities = new NumberArrayReference();
			yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities);

			if(settings.showGrid){
				/* Y-grid*/
				for(i = 0d; i < yGridPositions.Length; i = i + 1d){
					y = yGridPositions[(int)(i)];
					py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax);
					DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor);
				}
			}

			/* Draw origin.*/
			if(yMin < 0d && yMax > 0d){
				py = MapYCoordinate(0d, yMin, yMax, yPixelMin, yPixelMax);
				DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor);
			}

			/* Labels*/
			occupied = new Rectangle [(int)(yLabels.stringArray.Length)];
			for(i = 0d; i < occupied.Length; i = i + 1d){
				occupied[(int)(i)] = CreateRectangle(0d, 0d, 0d, 0d);
			}
			nextRectangle = CreateNumberReference(0d);

			for(i = 1d; i <= 5d; i = i + 1d){
				DrawYLabelsForPriority(i, yMin, xPixelMin, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, true);
			}

			/* Draw bars.*/
			if(settings.autoColor){
				if(!settings.grayscaleAutoColor){
					colors = Get8HighContrastColors();
				}else{
					colors = new RGBA [(int)(ss)];
					if(ss > 1d){
						for(i = 0d; i < ss; i = i + 1d){
							colors[(int)(i)] = GetGray(0.7 - (i/ss)*0.7);
						}
					}else{
						colors[0] = GetGray(0.5);
					}
				}
			}else{
				colors = new RGBA [0];
			}

			/* distances*/
			bs = settings.barPlotSeries[0].ys.Length;

			if(settings.autoSpacing){
				groupSeparation = ImageWidth(canvas)*0.05;
				barSeparation = ImageWidth(canvas)*0.005;
			}else{
				groupSeparation = settings.groupSeparation;
				barSeparation = settings.barSeparation;
			}

			barWidth = (xLengthPixels - groupSeparation*(bs - 1d) - barSeparation*(bs*(ss - 1d)))/(bs*ss);

			/* Draw bars.*/
			b = 0d;
			for(n = 0d; n < bs; n = n + 1d){
				for(s = 0d; s < ss; s = s + 1d){
					ys = settings.barPlotSeries[(int)(s)].ys;

					yValue = ys[(int)(n)];

					yBottom = MapYCoordinate(yValue, yMin, yMax, yPixelMin, yPixelMax);
					yTop = MapYCoordinate(0d, yMin, yMax, yPixelMin, yPixelMax);

					x = xPixelMin + n*(groupSeparation + ss*barWidth) + s*(barWidth) + b*barSeparation;
					w = barWidth;

					if(yValue >= 0d){
						y = yBottom;
						h = yTop - y;
					}else{
						y = yTop;
						h = yBottom - yTop;
					}

					/* Cut at boundaries.*/
					if(y < yPixelMin && y + h > yPixelMax){
						y = yPixelMin;
						h = yPixelMax - yPixelMin;
					}else if(y < yPixelMin){
						y = yPixelMin;
						if(yValue >= 0d){
							h = yTop - y;
						}else{
							h = yBottom - y;
						}
					}else if(y + h > yPixelMax){
						h = yPixelMax - y;
					}

					/* Get color*/
					if(settings.autoColor){
						barColor = colors[(int)(s)];
					}else{
						barColor = settings.barPlotSeries[(int)(s)].color;
					}

					/* Draw*/
					if(settings.barBorder){
						DrawFilledRectangleWithBorder(canvas, Roundx(x), Roundx(y), Roundx(w), Roundx(h), GetBlack(), barColor);
					}else{
						DrawFilledRectangle(canvas, Roundx(x), Roundx(y), Roundx(w), Roundx(h), barColor);
					}

					b = b + 1d;
				}
				b = b - 1d;
			}

			/* x-labels*/
			for(n = 0d; n < bs; n = n + 1d){
				if(settings.autoLabels){
					label = CreateStringDecimalFromNumber(n + 1d);
				}else{
					label = settings.xLabels[(int)(n)].stringx;
				}

				textwidth = GetTextWidth(label);

				x = xPixelMin + (n + 0.5)*(ss*barWidth + (ss - 1d)*barSeparation) + n*groupSeparation - textwidth/2d;

				DrawText(canvas, Floor(x), ImageHeight(canvas) - yPadding + 20d, label, gridLabelColor);

				b = b + 1d;
			}

			canvasReference.image = canvas;
		}

		return success;
	}


	public static bool BarPlotSettingsIsValid(BarPlotSettings settings, StringReference errorMessage){
		bool success, lengthSet;
		BarPlotSeries series;
		double i, length;

		success = true;

		/* Check series lengths.*/
		lengthSet = false;
		length = 0d;
		for(i = 0d; i < settings.barPlotSeries.Length; i = i + 1d){
			series = settings.barPlotSeries[(int)(i)];

			if(!lengthSet){
				length = series.ys.Length;
				lengthSet = true;
			}else if(length != series.ys.Length){
				success = false;
				errorMessage.stringx = "The number of data points must be equal for all series.".ToCharArray();
			}
		}

		/* Check bounds.*/
		if(!settings.autoBoundaries){
			if(settings.yMin >= settings.yMax){
				success = false;
				errorMessage.stringx = "Minimum y lower than maximum y.".ToCharArray();
			}
		}

		/* Check padding.*/
		if(!settings.autoPadding){
			if(2d*settings.xPadding >= settings.width){
				success = false;
				errorMessage.stringx = "Double the horizontal padding is larger than or equal to the width.".ToCharArray();
			}
			if(2d*settings.yPadding >= settings.height){
				success = false;
				errorMessage.stringx = "Double the vertical padding is larger than or equal to the height.".ToCharArray();
			}
		}

		/* Check width and height.*/
		if(settings.width < 0d){
			success = false;
			errorMessage.stringx = "Width lower than zero.".ToCharArray();
		}
		if(settings.height < 0d){
			success = false;
			errorMessage.stringx = "Height lower than zero.".ToCharArray();
		}

		/* Check spacing*/
		if(!settings.autoSpacing){
			if(settings.groupSeparation < 0d){
				success = false;
				errorMessage.stringx = "Group separation lower than zero.".ToCharArray();
			}
			if(settings.barSeparation < 0d){
				success = false;
				errorMessage.stringx = "Bar separation lower than zero.".ToCharArray();
			}
		}

		return success;
	}


	public static double GetMinimum(double [] data){
		double i, minimum;

		minimum = data[0];
		for(i = 0d; i < data.Length; i = i + 1d){
			minimum = Min(minimum, data[(int)(i)]);
		}

		return minimum;
	}


	public static double GetMaximum(double [] data){
		double i, maximum;

		maximum = data[0];
		for(i = 0d; i < data.Length; i = i + 1d){
			maximum = Max(maximum, data[(int)(i)]);
		}

		return maximum;
	}


	public static double BinomialDensity(double x, double size, double p){
		return Combinations(size, x)*Pow(p, x)*Pow(1d - p, size - x);
	}


	public static double [] BinomialRandom(PseudorandomGenerator prg, double n, double size, double p){
		double [] ns;
		double i, j, nr, c;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			c = 0d;

			for(j = 0d; j < size; j = j + 1d){
				nr = PseudorandomNextNumber(prg);
				if(nr < p){
					c = c + 1d;
				}
			}

			ns[(int)(i)] = c;
		}

		return ns;
	}


	public static double BinomialProbability(double x, double size, double prob){
		double sum, i;

		sum = 0d;
		for(i = 0d; i <= x; i = i + 1d){
			sum = sum + BinomialDensity(i, size, prob);
		}

		return sum;
	}


	public static double BinomialQuantile(double u, double size, double prob){
		double sum, i;
		bool done;

		sum = 0d;
		done = false;
		for(i = 0d; i <= size && !done; i = i + 1d){
			sum = sum + BinomialDensity(i, size, prob);
			if(sum > u){
				done = true;
			}
		}

		return i - 1d;
	}


	public static double NormalDensity(double x, double mu, double sd){
		return 1d/(Sqrt(2d*PI)*sd)*Exp(-(Pow(x - mu, 2d)/(2d*Pow(sd, 2d))));
	}


	public static double [] NormalRandom(PseudorandomGenerator prg, double n, double mean, double sd){
		double [] ns;
		double i, nr;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			nr = PseudorandomNextNumber(prg);
			ns[(int)(i)] = NormalQuantile(nr, mean, sd);
		}

		return ns;
	}


	public static double NormalProbability(double q, double mean, double sd){
		return NormalProbabilityMethod2(q, mean, sd);
	}


	public static double NormalProbabilityMethod1(double q, double mean, double sd){
		double p, z, qz, c0, c1, c2, c3, c4, c5;

		q = (q - mean)/sd;

		if(q < 0d){
			p = 1d - NormalProbabilityMethod1(-q, 0d, 1d);
		}else{
			c0 = 0.2316419;
			c1 = 0.319381530;
			c2 = -0.356563782;
			c3 = 1.781477937;
			c4 = -1.821255978;
			c5 = 1.330274429;

			z = 1d/(1d + c0*q);
			qz = z*(c1 + z*(c2 + z*(c3 + z*(c4 + c5*z))));

			p = 1d - qz*NormalDensity(q, 0d, 1d);
		}

		return p;
	}


	public static double NormalProbabilityMethod2(double x, double mean, double sd){
		return 1d/2d*(1d + Error((x - mean)/(sd*Sqrt(2d))));
	}


	public static double NormalQuantile(double u, double mean, double sd){
		return NormalQuantileMethod1(u, mean, sd);
	}


	public static double NormalQuantileMethod1(double u, double mean, double sd){
		double q, z, q1z, q2z, c0, c1, c2, c3, c4, c5, c6, c7, c8;

		if(u < 1d/2d){
			q = -NormalQuantile(1d - u, 0d, 1d);
		}else{
			z = Sqrt(-2d*Log(1d - u));
			c0 = -0.322232431088;
			c1 = -0.342242088547;
			c2 = -0.020423121024;
			c3 = -0.0000453642210148;
			c4 = 0.099348462606;
			c5 = 0.58858157049;
			c6 = 0.531103462366;
			c7 = 0.10353775285;
			c8 = 0.0038560700634;
			q1z = c0 + z*(-1d + z*(c1 + z*(c2 + c3*z)));
			q2z = c4 + z*(c5 + z*(c6 + z*(c7 + c8*z)));
			q = z + q1z/q2z;
		}

		q = mean + q*sd;

		return q;
	}


	public static double NormalQuantileMethod2(double u, double mean, double sd){
		return mean + sd*Sqrt(2d)*ErrorInverse(2d*u - 1d);
	}


	public static double PossionMass(double k, double lambda){
		return Pow(lambda, k)*Exp(-lambda)/Factorial(k);
	}


	public static double [] PoissonRandom(PseudorandomGenerator prg, double n, double lambda){
		double [] ns;
		double i, nr;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			nr = PseudorandomNextNumber(prg);
			ns[(int)(i)] = PoissonQuantile(nr, lambda);
		}

		return ns;
	}


	public static double PoissonQuantile(double p, double lambda){
		double sum, i;
		bool done;

		sum = 0d;
		done = false;
		for(i = 0d; i <= lambda && !done; i = i + 1d){
			sum = sum + PossionMass(i, lambda);
			if(sum > p){
				done = true;
			}
		}

		return i - 1d;
	}


	public static double PoissonProbability(double k, double lambda){
		double i, t;

		t = 0d;
		for(i = 0d; i <= k; i = i + 1d){
			t = t + Pow(lambda, i)/Factorial(i);
		}

		return t/Exp(lambda);
	}


	public static double [] SampleWithReplacement(PseudorandomGenerator prg, double k, double n){
		double [] ss;
		double i;

		ss = new double [(int)(k)];

		for(i = 0d; i < k; i = i + 1d){
			ss[(int)(i)] = PseudorandomNextInteger(prg, n);
		}

		return ss;
	}


	public static double [] Sample(PseudorandomGenerator prg, double k, double n){
		double [] ss, list;
		double i, next;
		bool [] hasPicked;
		NumberArrayReference ssReference;

		ss = new double [(int)(k)];
		if(n/10d < k){
			/* If k is relatively high:*/
			list = RandomPermutation(prg, n);

			ssReference = new NumberArrayReference();
			arraysCopyNumberArrayRange(list, 0d, k, ssReference);
			ss = ssReference.numberArray;
			delete(ssReference);
			delete(list);
		}else{
			/* If k is relatively low:*/
			hasPicked = arraysCreateBooleanArray(n, false);

			for(i = 0d; i < n; ){
				next = PseudorandomNextInteger(prg, n);
				if(!hasPicked[(int)(next)]){
					hasPicked[(int)(next)] = true;
					ss[(int)(i)] = next;
					i = i + 1d;
				}
			}

			delete(hasPicked);
		}

		return ss;
	}


	public static void Shuffle(PseudorandomGenerator prg, double [] list){
		FisherYatesShuffle(prg, list);
	}


	public static void FisherYatesShuffle(PseudorandomGenerator prg, double [] a){
		double i, j, n;

		n = a.Length;

		for(i = 0d; i < n - 2d; i = i + 1d){
			j = PseudorandomNextIntegerBetween(prg, i, n);
			arraysSwapElementsOfNumberArray(a, i, j);
		}
	}


	public static double [] SampleWithReplacementFromArray(PseudorandomGenerator prg, double [] a, double k){
		double [] source, list;
		double i;

		source = SampleWithReplacement(prg, k, a.Length);

		list = new double [(int)(k)];

		for(i = 0d; i < k; i = i + 1d){
			list[(int)(i)] = a[(int)(source[(int)(i)])];
		}

		delete(source);

		return list;
	}


	public static double [] SampleFromArray(PseudorandomGenerator prg, double [] a, double k){
		double [] source, list;
		double i;

		source = Sample(prg, k, a.Length);

		list = new double [(int)(k)];

		for(i = 0d; i < k; i = i + 1d){
			list[(int)(i)] = a[(int)(source[(int)(i)])];
		}

		delete(source);

		return list;
	}


	public static double [] RandomPermutation(PseudorandomGenerator prg, double n){
		double [] list;
		double i;

		list = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			list[(int)(i)] = i;
		}

		Shuffle(prg, list);

		return list;
	}


	public static double StudentTDensity(double x, double v){
		return Gamma((v + 1d)/2d)/(Sqrt(v*PI)*Gamma(v/2d))*Pow(1d + Pow(x, 2d)/v, -((v + 1d)/2d));
	}


	public static double StudentTProbability(double x, double v){
		return 1d/2d + x*Gamma((v + 1d)/2d)*Hypergeometric(1d/2d, (v + 1d)/2d, 3d/2d, -Pow(x, 2d)/v, 50d, 0.00001)/(Sqrt(PI*v)*Gamma(v/2d));
	}


	public static double [] StudentTRandom(PseudorandomGenerator prg, double n, double v){
		double [] ns;
		double i, nr;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			nr = PseudorandomNextNumber(prg);
			ns[(int)(i)] = StudentTQuantile(nr, v);
		}

		return ns;
	}


	public static double StudentTQuantile(double p, double v){
		double t, i, j, q, hy, qi, qip1, gy, a;

		if(v == 1d){
			q = Tan(PI*(p - 1d/2d));
		}else if(v == 2d){
			a = 4d*p*(1d - p);
			q = (2d*p - 1d)*Sqrt(2d/a);
		}else if(v == 4d){
			a = 4d*p*(1d - p);
			q = Cos(1d/3d*Acos(Sqrt(a)))/Sqrt(a);
			q = Sign(p - 1d/2d)*2d*Sqrt(q - 1d);
		}else if(DivisibleBy(v, 2d)){
			q = ChengFuStudentTQuantileAlgorithm(p, v);
		}else{
			q = HillsAlgorithm396(p, v);
		}

		return q;
	}


	public static double ChengFuStudentTQuantileAlgorithm(double p, double v){
		double a, qi, i, gy, j, qip1, q, k;

		k = Ceiling(v/2d);
		a = 1d - p;

		if(a != 0.5){
			qi = Sqrt(2d*Pow(1d - 2d*a, 2d)/(1d - Pow(1d - 2d*a, 2d)));

			for(i = 0d; i < 20d; i = i + 1d){
				gy = 0d;
				for(j = 0d; j <= k - 1d; j = j + 1d){
					gy = gy + Factorial(2d*j)/Pow(2d, 2d*j)/Pow(Factorial(j), 2d)*Pow(1d + Pow(qi, 2d)/(2d*k), -j);
				}

				qip1 = 1d/Sqrt(1d/(2d*k)*(Pow(gy/(1d - 2d*a), 2d) - 1d));

				qi = qip1;
			}

			if(a > 0.5){
				q = -qi;
			}else{
				q = qi;
			}
		}else{
			q = 0d;
		}
		return q;
	}


	public static double HillsAlgorithm396(double p, double v){
		double q, t, z;
		double a, b, c, d, x, y;
		bool negate;

		if(p > 0.5){
			negate = false;
			z = 2d*(1d - p);
		}else{
			negate = true;
			z = 2d*p;
		}

		a = 1d/(v - 0.5);
		b = 48d/(a*a);
		c = ((20700d*a/b - 98d)*a - 16d)*a + 96.36;
		d = ((94.5/(b + c) - 3d)/b + 1d)*Sqrt(a*PI/2d)*v;
		x = z*d;
		y = Pow(x, 2d/v);

		if(y > 0.05 + a){
			x = NormalQuantile(z*0.5, 0d, 1d);
			y = x*x;
			if(v < 5d){
				c = c + 0.3*(v - 4.5)*(x + 0.6);
			}
			c = c + (((0.05*d*x - 5d)*x - 7d)*x - 2d)*x + b;
			y = (((((0.4*y + 6.3)*y + 36d)*y + 94.5)/c - y - 3d)/b + 1d)*x;
			y = a*y*y;
			if(y > 0.002){
				y = Exp(y) - 1d;
			}else{
				y = y + 0.5*y*y;
			}
		}else{
			y = ((1d/(((v + 6d)/(v*y) - 0.089*d - 0.822)*(v + 2d)*3d) + 0.5/(v + 4d))*y - 1d)*(v + 1d)/(v + 2d) + 1d/y;
		}

		q = Sqrt(v*y);

		if(negate){
			q = -q;
		}

		return q;
	}


	public static double Mean(double [] list){
		double sum, i;

		sum = 0d;
		for(i = 0d; i < list.Length; i = i + 1d){
			sum = sum + list[(int)(i)];
		}

		return sum/list.Length;
	}


	public static double [] MeanOfRows(Matrix list){
		double [] means;
		double i;

		means = new double [(int)(list.r.Length)];

		for(i = 0d; i < list.r.Length; i = i + 1d){
			means[(int)(i)] = Mean(list.r[(int)(i)].c);
		}

		return means;
	}


	public static double [] MeanOfColumns(Matrix list){
		double [] means;
		Matrix listT;

		listT = TransposeToNew(list);

		means = MeanOfRows(listT);

		delete(listT);

		return means;
	}


	public static double Variance(double [] list){
		double mu, sum, i;

		mu = Mean(list);

		sum = 0d;
		for(i = 0d; i < list.Length; i = i + 1d){
			sum = sum + Pow(list[(int)(i)] - mu, 2d);
		}

		return sum/list.Length;
	}


	public static double Covariance(double [] list1, double [] list2){
		double mu1, mu2, sum, i;

		sum = 0d;
		if(list1.Length == list2.Length){

			mu1 = Mean(list1);
			mu2 = Mean(list2);

			sum = 0d;
			for(i = 0d; i < list1.Length; i = i + 1d){
				sum = sum + (list1[(int)(i)] - mu1)*(list2[(int)(i)] - mu2);
			}
		}

		return sum/list1.Length;
	}


	public static Matrix CovarianceMatrix(Matrix X){
		Matrix A, XCentered, muMatrix;
		double [] mu;

		mu = MeanOfColumns(X);
		muMatrix = CreateMatrixFromRowCopies(mu, NumberOfRows(X));

		XCentered = CreateCopyOfMatrix(X);
		Subtract(XCentered, muMatrix);

		A = MultiplyToNew(TransposeToNew(XCentered), XCentered);
		ScalarDivide(A, NumberOfRows(X));

		return A;
	}


	public static Matrix CorrelationMatrix(Matrix X){
		Matrix sigma, variancesMatrix, t1, correlationMatrixResult;
		double [] variances;
		double n;

		sigma = SampleCovarianceMatrix(X);

		n = NumberOfRows(sigma);
		variances = new double [(int)(n)];
		ExtractDiagonal(sigma, variances);
		vectorPower(variances, -1d/2d);
		variancesMatrix = CreateDiagonalMatrixFromArray(variances);
		t1 = CreateCopyOfMatrix(variancesMatrix);
		Multiply(t1, variancesMatrix, sigma);
		correlationMatrixResult = CreateCopyOfMatrix(variancesMatrix);
		Multiply(correlationMatrixResult, t1, variancesMatrix);

		return correlationMatrixResult;
	}


	public static Matrix SampleCovarianceMatrix(Matrix X){
		Matrix A;

		A = CovarianceMatrix(X);
		ScalarMultiply(A, NumberOfRows(X)/(NumberOfRows(X) - 1d));

		return A;
	}


	public static double Correlation(double [] list1, double [] list2){
		double cv, sd1, sd2;

		cv = Covariance(list1, list2);
		sd1 = StandardDeviation(list1);
		sd2 = StandardDeviation(list2);

		return cv/(sd1*sd2);
	}


	public static double Percentile(double [] list, double p){
		return list[(int)(Ceiling(list.Length*p) - 1d)];
	}


	public static double VarianceSample(double [] list){
		return Variance(list)*list.Length/(list.Length - 1d);
	}


	public static double StandardDeviation(double [] list){
		return Sqrt(Variance(list));
	}


	public static double StandardDeviationSample(double [] list){
		return Sqrt(VarianceSample(list));
	}


	public static double Median(double [] list){
		double m;

		QuickSortNumbers(list);

		if(list.Length%2d == 1d){
			m = list[(int)(Floor(list.Length/2d))];
		}else{
			m = (list[(int)(list.Length/2d)] + list[(int)(list.Length/2d - 1d)])/2d;
		}

		return m;
	}


	public static double [] Mode(double [] list){
		double unique, mostFrequent, valuesMostFrequent;
		double [] modes, counts;

		modes = new double [0];
		if(list.Length > 0d){
			QuickSortNumbers(list);
			unique = CountUniqueNumbers(list);
			counts = CountOccurrenceOfEachNumber(list, unique);
			mostFrequent = FindMostFrequentNumber(counts);
			valuesMostFrequent = CountNumberOfHighestOccurrences(mostFrequent, counts);
			delete(modes);
			modes = GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts);
			delete(counts);
		}

		return modes;
	}


	public static double CountUniqueNumbers(double [] list){
		double last, unique, i;

		last = list[0];
		unique = 1d;
		for(i = 1d; i < list.Length; i = i + 1d){
			if(list[(int)(i)] != last){
				unique = unique + 1d;
				last = list[(int)(i)];
			}
		}

		return unique;
	}


	public static double [] CountOccurrenceOfEachNumber(double [] list, double unique){
		double [] counts;
		double current, last, i;

		counts = new double [(int)(unique)];

		current = 0d;
		counts[0] = 1d;
		last = list[0];
		for(i = 1d; i < list.Length; i = i + 1d){
			if(list[(int)(i)] != last){
				current = current + 1d;
				counts[(int)(current)] = 1d;
			}else{
				counts[(int)(current)] = counts[(int)(current)] + 1d;
			}
			last = list[(int)(i)];
		}

		return counts;
	}


	public static double FindMostFrequentNumber(double [] counts){
		double mostFrequent, i;

		mostFrequent = 0d;
		for(i = 0d; i < counts.Length; i = i + 1d){
			mostFrequent = Max(counts[(int)(i)], mostFrequent);
		}
		return mostFrequent;
	}


	public static double CountNumberOfHighestOccurrences(double mostFrequent, double [] counts){
		double valuesMostFrequent, i;

		valuesMostFrequent = 0d;
		for(i = 0d; i < counts.Length; i = i + 1d){
			if(counts[(int)(i)] == mostFrequent){
				valuesMostFrequent = valuesMostFrequent + 1d;
			}
		}
		return valuesMostFrequent;
	}


	public static double [] GetListOfNumbersWithHighestOccurrence(double [] list, double mostFrequent, double valuesMostFrequent, double [] counts){
		double [] modes;
		double current, currentInsert, i;

		modes = new double [(int)(valuesMostFrequent)];

		current = 0d;
		currentInsert = 0d;
		for(i = 0d; i < counts.Length; i = i + 1d){
			if(counts[(int)(i)] == mostFrequent){
				modes[(int)(currentInsert)] = list[(int)(current)];
				currentInsert = currentInsert + 1d;
			}

			current = current + counts[(int)(i)];
		}

		return modes;
	}


	public static double LogNormalDensity(double x, double mean, double sd){
		return 1d/(x*sd*Sqrt(2d*PI))*Exp(-(Pow(Log(x) - mean, 2d)/(2d*Pow(sd, 2d))));
	}


	public static double [] LogNormalRandom(PseudorandomGenerator prg, double n, double mean, double sd){
		double i;
		double [] rs;

		rs = NormalRandom(prg, n, mean, sd);

		for(i = 0d; i < n; i = i + 1d){
			rs[(int)(i)] = Exp(rs[(int)(i)]);
		}

		return rs;
	}


	public static double LogNormalProbability(double q, double mean, double sd){
		return NormalProbability(Log(q), mean, sd);
	}


	public static double LogNormalQuantile(double p, double mean, double sd){
		return Exp(NormalQuantile(p, mean, sd));
	}


	public static UnsignedInteger CreateUnsignedInteger(double digits){
		UnsignedInteger x;

		x = new UnsignedInteger();
		x.digits = new double [(int)(digits)];

		ClearUnsignedInteger(x);

		return x;
	}


	public static void FreeUnsignedInteger(UnsignedInteger x){
		delete(x.digits);
		delete(x);
	}


	public static void ClearUnsignedInteger(UnsignedInteger x){
		double i;

		for(i = 0d; i < DigitCapacityUnsignedInteger(x); i = i + 1d){
			x.digits[(int)(i)] = 0d;
		}
	}


	public static void TrimUnsignedInteger(UnsignedInteger x){
		double capacity, digits, newCapacity, i;
		double [] newDigits;

		capacity = DigitCapacityUnsignedInteger(x);
		digits = DigitsUnsignedInteger(x);

		if(capacity > digits){
			newCapacity = digits;
			newDigits = new double [(int)(newCapacity)];

			for(i = 0d; i < newCapacity; i = i + 1d){
				newDigits[(int)(i)] = x.digits[(int)(i)];
			}

			delete(x.digits);
			x.digits = newDigits;
		}
	}


	public static char [] ToStringUnsignedInteger(UnsignedInteger x){
		char [] str;
		char c;
		double i, digits, digit;

		digits = DigitsUnsignedInteger(x);
		str = new char [(int)(digits)];

		for(i = 0d; i < digits; i = i + 1d){
			digit = DigitUnsignedInteger(x, i);

			c = DecimalDigitToCharacter(digit);

			str[(int)(digits - i - 1d)] = c;
		}

		return str;
	}


	public static void AddUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		bool overflow;
		double capacity, ads, bds;

		overflow = !AddFixedUnsignedInteger(x, a, b);

		if(overflow){
			delete(x.digits);

			ads = DigitsUnsignedInteger(a);
			bds = DigitsUnsignedInteger(b);
			capacity = Max(ads, bds) + 1d;
			x.digits = new double [(int)(capacity)];

			AddFixedUnsignedInteger(x, a, b);
		}
	}


	public static bool SubtractUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		double ads, xds;

		ads = DigitsUnsignedInteger(a);
		xds = DigitCapacityUnsignedInteger(x);

		if(xds < ads){
			delete(x.digits);
			x.digits = new double [(int)(ads)];
		}

		return SubtractFixedUnsignedInteger(x, a, b);
	}


	public static void MultiplyUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		bool overflow;
		double capacity, ads, bds;

		overflow = !MultiplyFixedUnsignedInteger(x, a, b);

		if(overflow){
			delete(x.digits);

			ads = DigitsUnsignedInteger(a);
			bds = DigitsUnsignedInteger(b);
			capacity = ads + bds;
			x.digits = new double [(int)(capacity)];

			MultiplyFixedUnsignedInteger(x, a, b);
		}
	}


	public static bool DivideUnsignedInteger(UnsignedInteger q, UnsignedInteger r, UnsignedInteger a, UnsignedInteger b){
		double capacity, ads, bds, qds, rds;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		qds = DigitCapacityUnsignedInteger(q);
		rds = DigitCapacityUnsignedInteger(r);

		if(qds < ads - bds + 1d){
			capacity = ads - bds + 1d;
			q.digits = new double [(int)(capacity)];
		}

		if(rds < bds){
			capacity = bds;
			r.digits = new double [(int)(capacity)];
		}

		return DivideFixedUnsignedInteger(q, r, a, b);
	}


	public static void ShiftLeftUnsignedInteger(UnsignedInteger x, double shifts){
		double xds, capacity, i;
		double [] oldDigits;

		xds = DigitsUnsignedInteger(x);
		capacity = DigitCapacityUnsignedInteger(x);

		if(xds + shifts > capacity){
			capacity = xds + shifts;
			oldDigits = x.digits;
			x.digits = new double [(int)(capacity)];
		}else{
			oldDigits = x.digits;
		}

		for(i = 0d; i < oldDigits.Length - shifts; i = i + 1d){
			x.digits[(int)(oldDigits.Length - i - 1d)] = oldDigits[(int)(oldDigits.Length - shifts - i - 1d)];
		}

		for(; i < oldDigits.Length; i = i + 1d){
			x.digits[(int)(oldDigits.Length - i - 1d)] = 0d;
		}
	}


	public static ArbitraryPrecisionInteger CreateArbitraryPrecisionInteger(double digits){
		ArbitraryPrecisionInteger x;

		x = new ArbitraryPrecisionInteger();
		x.sign = true;
		x.number = CreateUnsignedInteger(digits);

		return x;
	}


	public static void FreeArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		FreeUnsignedInteger(x.number);
		delete(x);
	}


	public static void ClearArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		x.sign = true;
		ClearUnsignedInteger(x.number);
	}


	public static void TrimArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		TrimUnsignedInteger(x.number);
	}


	public static char [] ToStringArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		char [] str;
		char c;
		double i, digits, digit;

		if(x.number.digits.Length > 0d){

			digits = DigitsUnsignedInteger(x.number);
			str = new char [(int)(1d + digits)];

			if(x.sign){
				str[0] = '+';
			}else{
				str[0] = '-';
			}

			for(i = 0d; i < digits; i = i + 1d){
				digit = DigitUnsignedInteger(x.number, i);

				c = DecimalDigitToCharacter(digit);

				str[(int)(1d + digits - i - 1d)] = c;
			}
		}else{
			str = new char [2];
			str[0] = '+';
			str[1] = '0';
		}

		return str;
	}


	public static ArbitraryPrecisionInteger CreateArbitraryPrecisionIntegerFromString(char [] str){
		ArbitraryPrecisionInteger x;
		char c;
		double i, digit, stringDigits, hasSign;

		hasSign = 0d;
		if(str.Length > 0d){
			if(str[0] == '-' || str[0] == '+'){
				hasSign = 1d;
			}
		}

		x = CreateArbitraryPrecisionInteger(str.Length - hasSign);
		stringDigits = str.Length;

		if(str.Length > 0d){
			x.sign = true;
			if(str[0] == '-'){
				x.sign = false;
			}else if(str[0] == '+'){
				x.sign = true;
			}
		}

		for(i = 0d; i < stringDigits - hasSign; i = i + 1d){
			c = str[(int)(stringDigits - i - 1d)];
			digit = CharacterToDecimalDigit(c);
			x.number.digits[(int)(i)] = digit;
		}

		return x;
	}


	public static void AddArbitraryPrecisionInteger(ArbitraryPrecisionInteger x, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		bool asx, bs;
		double comparisonResult;

		asx = a.sign;
		bs = b.sign;

		if(asx == bs){
			AddUnsignedInteger(x.number, a.number, b.number);
			x.sign = asx;
		}else if(asx == true){
			comparisonResult = CompareFixedUnsignedInteger(a.number, b.number);

			if(comparisonResult == 1d || comparisonResult == 0d){
				SubtractUnsignedInteger(x.number, a.number, b.number);
			}else{
				SubtractUnsignedInteger(x.number, b.number, a.number);
				x.sign = false;
			}
		}else{
			comparisonResult = CompareFixedUnsignedInteger(b.number, a.number);

			if(comparisonResult == 1d || comparisonResult == 0d){
				SubtractUnsignedInteger(x.number, b.number, a.number);
			}else{
				SubtractUnsignedInteger(x.number, a.number, b.number);
				x.sign = false;
			}
		}
	}


	public static void SubtractArbitraryPrecisionInteger(ArbitraryPrecisionInteger x, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		bool asx, bs;
		double comparisonResult;

		asx = a.sign;
		bs = b.sign;

		if(asx == bs){
			if(asx == true){
				comparisonResult = CompareFixedUnsignedInteger(a.number, b.number);

				if(comparisonResult == 1d || comparisonResult == 0d){
					SubtractUnsignedInteger(x.number, a.number, b.number);
				}else{
					SubtractUnsignedInteger(x.number, b.number, a.number);
					x.sign = false;
				}
			}else{
				comparisonResult = CompareFixedUnsignedInteger(b.number, a.number);

				if(comparisonResult == 1d || comparisonResult == 0d){
					SubtractUnsignedInteger(x.number, b.number, a.number);
				}else{
					SubtractUnsignedInteger(x.number, a.number, b.number);
					x.sign = false;
				}
			}
		}else if(asx == false){
			AddUnsignedInteger(x.number, a.number, b.number);
			x.sign = false;
		}else{
			AddUnsignedInteger(x.number, a.number, b.number);
			x.sign = true;
		}
	}


	public static void MultiplyArbitraryPrecisionInteger(ArbitraryPrecisionInteger x, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		MultiplyUnsignedInteger(x.number, a.number, b.number);
		if(a.sign != b.sign){
			x.sign = false;
		}
	}


	public static bool DivideArbitraryPrecisionInteger(ArbitraryPrecisionInteger q, ArbitraryPrecisionInteger r, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		bool success, rIsZero;
		double i;

		if(a.sign == b.sign){
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);

			if(success){
				q.sign = true;
				r.sign = true;
			}
		}else if(a.sign == false){
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);

			if(success){
				q.sign = false;
				r.sign = true;
			}

			rIsZero = true;
			for(i = 0d; i < r.number.digits.Length; i = i + 1d){
				if(r.number.digits[(int)(i)] != 0d){
					rIsZero = false;
				}
			}

			if(!rIsZero){
				AddUnsignedInteger(a.number, a.number, b.number);
				success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);
				SubtractUnsignedInteger(r.number, b.number, r.number);
				SubtractUnsignedInteger(a.number, a.number, b.number);
			}
		}else{
			AddUnsignedInteger(a.number, a.number, b.number);

			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);

			if(success){
				q.sign = false;
				r.sign = false;
			}
		}

		return success;
	}


	public static char [] AddArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr){
		ArbitraryPrecisionInteger a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		c = CreateArbitraryPrecisionInteger(0d);

		AddArbitraryPrecisionInteger(c, a, b);

		cStr = ToStringArbitraryPrecisionInteger(c);

		return cStr;
	}


	public static char [] SubtractArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr){
		ArbitraryPrecisionInteger a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		c = CreateArbitraryPrecisionInteger(0d);

		SubtractArbitraryPrecisionInteger(c, a, b);

		cStr = ToStringArbitraryPrecisionInteger(c);

		return cStr;
	}


	public static char [] MultiplyArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr){
		ArbitraryPrecisionInteger a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		c = CreateArbitraryPrecisionInteger(0d);

		MultiplyArbitraryPrecisionInteger(c, a, b);

		cStr = ToStringArbitraryPrecisionInteger(c);

		return cStr;
	}


	public static char [] DivideArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr, StringReference rStr){
		ArbitraryPrecisionInteger a, b, q, r;
		char [] qStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		q = CreateArbitraryPrecisionInteger(0d);
		r = CreateArbitraryPrecisionInteger(0d);

		DivideArbitraryPrecisionInteger(q, r, a, b);

		qStr = ToStringArbitraryPrecisionInteger(q);
		rStr.stringx = ToStringArbitraryPrecisionInteger(r);

		return qStr;
	}


	public static ArbitraryPrecisionFixedPointNumber CreateArbitraryPrecisionFixedPointNumber(double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber x;

		x = new ArbitraryPrecisionFixedPointNumber();
		x.baseNumber = CreateArbitraryPrecisionInteger(digitsBeforePoint + digitsAfterPoint);
		x.pointPosition = digitsAfterPoint;

		return x;
	}


	public static void FreeArbitraryPrecisionFixedPointNumber(ArbitraryPrecisionFixedPointNumber x){
		FreeArbitraryPrecisionInteger(x.baseNumber);
		delete(x);
	}


	public static bool AddArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint;
		bool success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		digitsBeforePoint = Max(aDigitsBeforePoint, bDigitsBeforePoint);
		digitsAfterPoint = Max(aDigitsAfterPoint, bDigitsAfterPoint);

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint);
		ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber);

		success = AssignArbitraryPrecisionFixedPoint(x, x1);

		return success;
	}


	public static bool AssignArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a){
		bool success, isPointFive, zeroOverflow;
		double aDigitsBeforePoint, aDigitsAfterPoint, xDigitsBeforePoint, xDigitsAfterPoint, i, digit;
		UnsignedInteger epsilon;

		xDigitsBeforePoint = GetDigitsBeforePoint(x);
		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		xDigitsAfterPoint = GetDigitsAfterPoint(x);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		zeroOverflow = true;
		if(xDigitsBeforePoint < aDigitsBeforePoint){
			for(i = 0d; i < aDigitsBeforePoint - xDigitsBeforePoint; i = i + 1d){
				if(DigitUnsignedInteger(a.baseNumber.number, aDigitsBeforePoint + aDigitsAfterPoint - i - 1d) != 0d){
					zeroOverflow = false;
				}
			}
		}

		if(zeroOverflow){
			/* Assign before point.*/
			for(i = 0d; i < xDigitsBeforePoint; i = i + 1d){
				if(i >= aDigitsBeforePoint){
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint + i)] = 0d;
				}else{
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint + i)] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint + i);
				}
			}

			/* Assign after point:*/
			for(i = 0d; i < xDigitsAfterPoint; i = i + 1d){
				if(aDigitsAfterPoint - i - 1d < 0d){
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint - i - 1d)] = 0d;
				}else{
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint - i - 1d)] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - i - 1d);
				}
			}

			/* Assign sign.*/
			x.baseNumber.sign = a.baseNumber.sign;

			/* Round if necessary.*/
			if(aDigitsAfterPoint > xDigitsAfterPoint){
				if(x.baseNumber.sign == true){
					digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1d);

					if(digit >= 5d){
						/* Make epsilon.*/
						epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint);
						epsilon.digits[0] = 1d;
						success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon);
						FreeUnsignedInteger(epsilon);
					}else{
						success = true;
					}
				}else{
					digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1d);

					isPointFive = true;
					if(digit == 5d){
						for(i = aDigitsAfterPoint - xDigitsAfterPoint - 2d; i >= 0d; i = i - 1d){
							if(DigitUnsignedInteger(a.baseNumber.number, i) != 0d){
								isPointFive = false;
							}
						}
					}else{
						isPointFive = false;
					}

					if(digit <= 4d || isPointFive){
						success = true;
					}else{
						epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint);
						epsilon.digits[0] = 1d;
						success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon);
						FreeUnsignedInteger(epsilon);
					}
				}
			}else{
				success = true;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static double GetDigitsBeforePoint(ArbitraryPrecisionFixedPointNumber a){
		double sum;
		double digitsBeforePoint, digitsAfterPoint;

		digitsAfterPoint = GetDigitsAfterPoint(a);
		sum = DigitCapacityUnsignedInteger(a.baseNumber.number);
		digitsBeforePoint = sum - digitsAfterPoint;

		return digitsBeforePoint;
	}


	public static double GetDigitsAfterPoint(ArbitraryPrecisionFixedPointNumber a){
		return a.pointPosition;
	}


	public static char [] ToStringArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x){
		char [] str;
		char c;
		double i, digits, digit, point;

		if(x.baseNumber.number.digits.Length > 0d){

			digits = GetDigitsBeforePoint(x) + GetDigitsAfterPoint(x);
			str = new char [(int)(1d + GetDigitsBeforePoint(x) + 1d + GetDigitsAfterPoint(x))];

			if(x.baseNumber.sign){
				str[0] = '+';
			}else{
				str[0] = '-';
			}

			point = 1d;

			for(i = 0d; i < digits; i = i + 1d){
				digit = DigitUnsignedInteger(x.baseNumber.number, i);

				if(i == x.pointPosition){
					str[(int)(1d + digits - i - 1d + point)] = '.';
					point = 0d;
				}

				c = DecimalDigitToCharacter(digit);

				str[(int)(1d + digits - i - 1d + point)] = c;
			}
		}else{
			str = new char [3];
			str[0] = '+';
			str[1] = '0';
			str[2] = '.';
		}

		return str;
	}


	public static ArbitraryPrecisionFixedPointNumber CreateArbitraryPrecisionFixedPointFromString(double digitsBeforePoint, double digitsAfterPoint, char [] str){
		ArbitraryPrecisionFixedPointNumber x;
		char c;
		double i, digit, stringDigits, hasSign, pointPosition, hasPoint, point;

		x = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		hasSign = 0d;
		if(str.Length > 0d){
			if(str[0] == '-' || str[0] == '+'){
				hasSign = 1d;
			}
		}

		pointPosition = str.Length;
		hasPoint = 0d;
		for(i = 0d; i < str.Length && hasPoint == 0d; i = i + 1d){
			if(str[(int)(str.Length - i - 1d)] == '.'){
				pointPosition = i;
				hasPoint = 1d;
			}
		}
		stringDigits = str.Length;

		if(str.Length > 0d){
			x.baseNumber.sign = true;
			if(str[0] == '-'){
				x.baseNumber.sign = false;
			}else if(str[0] == '+'){
				x.baseNumber.sign = true;
			}
		}

		point = 0d;
		for(i = 0d; i < stringDigits - hasSign - hasPoint; i = i + 1d){
			if(i == pointPosition){
				point = 1d;
			}
			c = str[(int)(stringDigits - point - i - 1d)];
			digit = CharacterToDecimalDigit(c);
			x.baseNumber.number.digits[(int)(i)] = digit;
		}

		return x;
	}


	public static bool SubtractArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint;
		bool success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		digitsBeforePoint = Max(aDigitsBeforePoint, bDigitsBeforePoint);
		digitsAfterPoint = Max(aDigitsAfterPoint, bDigitsAfterPoint);

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint);
		ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint);

		SubtractArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber);

		success = AssignArbitraryPrecisionFixedPoint(x, x1);

		return success;
	}


	public static bool MultiplyArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2, t;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint;
		bool success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint;
		digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint;

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint);
		ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint);

		t = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint, 2d*digitsAfterPoint);
		MultiplyArbitraryPrecisionInteger(t.baseNumber, x1.baseNumber, x2.baseNumber);

		success = AssignArbitraryPrecisionFixedPoint(x, t);

		return success;
	}


	public static bool DivideArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber q, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2, qx, rx;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint, qDigitsBeforePoint, qDigitsAfterPoint;
		bool success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		qDigitsAfterPoint = GetDigitsAfterPoint(q);

		digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint;
		digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint;

		x1 = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint + qDigitsAfterPoint + 1d + bDigitsAfterPoint, 2d*digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint, 2d*digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, qDigitsAfterPoint + 1d + bDigitsAfterPoint);

		qx = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint + qDigitsAfterPoint + 1d + bDigitsAfterPoint, 2d*digitsAfterPoint);
		rx = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint + qDigitsAfterPoint + 1d + bDigitsAfterPoint, 2d*digitsAfterPoint);
		DivideArbitraryPrecisionInteger(qx.baseNumber, rx.baseNumber, x1.baseNumber, x2.baseNumber);
		qx.pointPosition = qx.pointPosition + qDigitsAfterPoint - aDigitsAfterPoint + 1d - 2d*bDigitsAfterPoint;

		success = AssignArbitraryPrecisionFixedPoint(q, qx);

		return success;
	}


	public static char [] AddArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionFixedPoint(c, a, b);

		cStr = ToStringArbitraryPrecisionFixedPoint(c);

		return cStr;
	}


	public static char [] SubtractArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		SubtractArbitraryPrecisionFixedPoint(c, a, b);

		cStr = ToStringArbitraryPrecisionFixedPoint(c);

		return cStr;
	}


	public static char [] MultiplyArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		MultiplyArbitraryPrecisionFixedPoint(c, a, b);

		cStr = ToStringArbitraryPrecisionFixedPoint(c);

		return cStr;
	}


	public static char [] DivideArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, q, r;
		char [] qStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		q = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		DivideArbitraryPrecisionFixedPoint(q, a, b);

		qStr = ToStringArbitraryPrecisionFixedPoint(q);

		return qStr;
	}


	public static double GetDigitsAfterAPFPString(char [] str){
		double pointPosition, hasPoint, i, digitsAfter;

		pointPosition = str.Length;
		hasPoint = 0d;
		for(i = 0d; i < str.Length && hasPoint == 0d; i = i + 1d){
			if(str[(int)(str.Length - i - 1d)] == '.'){
				pointPosition = i;
				hasPoint = 1d;
			}
		}

		if(hasPoint == 0d){
			digitsAfter = 0d;
		}else{
			digitsAfter = pointPosition;
		}

		return digitsAfter;
	}


	public static double GetDigitsBeforeAPFPString(char [] str){
		double hasSign, pointPosition, hasPoint, i, digitsBefore;

		hasSign = 0d;
		if(str.Length > 0d){
			if(str[0] == '-' || str[0] == '+'){
				hasSign = 1d;
			}
		}

		pointPosition = 0d;
		hasPoint = 0d;
		for(i = 0d; i < str.Length && hasPoint == 0d; i = i + 1d){
			if(str[(int)(str.Length - i - 1d)] == '.'){
				pointPosition = i;
				hasPoint = 1d;
			}
		}

		if(hasPoint == 0d){
			digitsBefore = str.Length - hasPoint;
		}else{
			digitsBefore = str.Length - pointPosition - hasSign - 1d;
		}

		return digitsBefore;
	}


	public static char DecimalDigitToCharacter(double digit){
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


	public static double DigitUnsignedInteger(UnsignedInteger x, double i){
		return x.digits[(int)(i)];
	}


	public static double DigitsUnsignedInteger(UnsignedInteger x){
		double i, capacity, digits;
		bool done;

		capacity = DigitCapacityUnsignedInteger(x);
		done = false;
		digits = capacity;

		for(i = capacity - 1d; i >= 0d && !done; i = i - 1d){
			if(DigitUnsignedInteger(x, i) == 0d){
				digits = digits - 1d;
			}else{
				done = true;
			}
		}

		if(digits == 0d){
			digits = 1d;
		}

		return digits;
	}


	public static char [] ToStringFixedUnsignedInteger(UnsignedInteger x){
		char [] str;
		char c;
		double i, digits, digit;

		digits = DigitCapacityUnsignedInteger(x);
		str = new char [(int)(digits)];

		for(i = 0d; i < digits; i = i + 1d){
			digit = DigitUnsignedInteger(x, i);

			c = DecimalDigitToCharacter(digit);

			str[(int)(digits - i - 1d)] = c;
		}

		return str;
	}


	public static double DigitCapacityUnsignedInteger(UnsignedInteger x){
		return x.digits.Length;
	}


	public static UnsignedInteger CreateFixedUnsignedIntegerFromString(double digits, char [] str){
		UnsignedInteger x;
		char c;
		double i, digit, stringDigits;

		x = CreateUnsignedInteger(digits);
		stringDigits = str.Length;

		for(i = 0d; i < stringDigits; i = i + 1d){
			c = str[(int)(stringDigits - i - 1d)];

			digit = CharacterToDecimalDigit(c);

			x.digits[(int)(i)] = digit;
		}

		return x;
	}


	public static double CharacterToDecimalDigit(char c){
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


	public static bool AddFixedUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		return AddFixedUnsignedIntegerWithShift(x, a, b, 0d, 0d);
	}


	public static bool AddFixedUnsignedIntegerWithShift(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b, double aShift, double bShift){
		double ads, bds, xds, i, carry, remainder, ad, bd, apos, bpos;
		bool overflow;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		xds = DigitCapacityUnsignedInteger(x);

		if(xds >= ads && xds >= bds){
			carry = 0d;

			for(i = 0d; i < xds; i = i + 1d){
				apos = i - aShift;
				if(apos >= 0d && apos < ads){
					ad = DigitUnsignedInteger(a, apos);
				}else{
					ad = 0d;
				}

				bpos = i - bShift;
				if(bpos >= 0d && bpos < bds){
					bd = DigitUnsignedInteger(b, bpos);
				}else{
					bd = 0d;
				}

				remainder = ad + bd + carry;

				if(remainder >= 10d){
					carry = 1d;
					remainder = remainder - 10d;
				}else{
					carry = 0d;
				}

				x.digits[(int)(i)] = remainder;
			}

			if(carry == 1d){
				overflow = true;
			}else{
				overflow = false;
			}
		}else{
			overflow = true;
		}

		return !overflow;
	}


	public static bool SubtractFixedUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		return SubtractFixedUnsignedIntegerWithShift(x, a, b, 0d, 0d);
	}


	public static bool SubtractFixedUnsignedIntegerWithShift(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b, double aShift, double bShift){
		double ads, bds, xds, i, borrow, remainder, ad, bd, apos, bpos;
		bool underflow, overflow;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		xds = DigitCapacityUnsignedInteger(x);

		borrow = 0d;
		overflow = false;

		for(i = 0d; i < Max(Max(ads, bds), xds) && !overflow; i = i + 1d){
			apos = i - aShift;
			if(apos >= 0d && apos < ads){
				ad = DigitUnsignedInteger(a, apos);
			}else{
				ad = 0d;
			}

			bpos = i - bShift;
			if(bpos >= 0d && bpos < bds){
				bd = DigitUnsignedInteger(b, bpos);
			}else{
				bd = 0d;
			}

			remainder = ad - bd - borrow;

			if(remainder < 0d){
				borrow = 1d;
				remainder = remainder + 10d;
			}else{
				borrow = 0d;
			}

			if(remainder != 0d){
				if(i < xds){
				}else{
					overflow = true;
				}
			}

			if(i < xds){
				x.digits[(int)(i)] = remainder;
			}
		}

		if(borrow == 1d){
			underflow = true;
		}else{
			underflow = false;
		}

		return !underflow && !overflow;
	}


	public static bool MultiplyFixedUnsignedInteger(UnsignedInteger c, UnsignedInteger a, UnsignedInteger b){
		double i, j, ads, ad;
		bool success;

		success = true;

		ClearUnsignedInteger(c);

		ads = DigitsUnsignedInteger(a);
		for(i = 0d; i < ads; i = i + 1d){
			ad = DigitUnsignedInteger(a, i);

			for(j = 0d; j < ad; j = j + 1d){
				success = success && AddFixedUnsignedIntegerWithShift(c, c, b, 0d, i);
			}
		}

		if(c.digits.Length == 0d){
			success = false;
		}

		return success;
	}


	public static double CompareFixedUnsignedInteger(UnsignedInteger a, UnsignedInteger b){
		double comparizonResult, ads, bds, i, ad, bd;
		bool done;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);

		comparizonResult = 0d;

		if(ads > bds){
			comparizonResult = 1d;
		}else if(ads < bds){
			comparizonResult = -1d;
		}else{
			done = false;
			for(i = ads - 1d; i >= 0d && !done; i = i - 1d){
				ad = DigitUnsignedInteger(a, i);
				bd = DigitUnsignedInteger(b, i);

				if(ad > bd){
					comparizonResult = 1d;
					done = true;
				}else if(ad < bd){
					comparizonResult = -1d;
					done = true;
				}
			}
		}

		return comparizonResult;
	}


	public static double CompareFixedUnsignedIntegerWithShift(UnsignedInteger a, UnsignedInteger b, double aShift, double bShift){
		double comparizonResult, ads, bds, i, ad, bd, apos, bpos;
		bool done;

		ads = DigitsUnsignedInteger(a);
		if(ads > 0d){
			ads = ads + aShift;
		}
		bds = DigitsUnsignedInteger(b);
		if(bds > 0d){
			bds = bds + bShift;
		}

		comparizonResult = 0d;

		if(ads > bds){
			comparizonResult = 1d;
		}else if(ads < bds){
			comparizonResult = -1d;
		}else{
			done = false;
			for(i = ads - 1d; i >= 0d && !done; i = i - 1d){
				apos = i - aShift;
				if(apos >= 0d && apos < ads){
					ad = DigitUnsignedInteger(a, apos);
				}else{
					ad = 0d;
				}

				bpos = i - bShift;
				if(bpos >= 0d && bpos < bds){
					bd = DigitUnsignedInteger(b, bpos);
				}else{
					bd = 0d;
				}

				if(ad > bd){
					comparizonResult = 1d;
					done = true;
				}else if(ad < bd){
					comparizonResult = -1d;
					done = true;
				}
			}
		}

		return comparizonResult;
	}


	public static bool DivideFixedUnsignedInteger(UnsignedInteger q, UnsignedInteger r, UnsignedInteger a, UnsignedInteger b){
		double i, j, ads, bds, qd, comparisonResult, qdsCapacity;
		bool success, done;

		success = true;

		ClearUnsignedInteger(q);
		ClearUnsignedInteger(r);

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		qdsCapacity = DigitCapacityUnsignedInteger(q);

		/* bds == 0 -> b.digits[0] != 0*/
		if(bds != 1d || b.digits[0] != 0d){
			if(ads >= bds){
				for(i = ads - bds; i >= 0d && success; i = i - 1d){
					qd = 0d;
					done = false;
					for(j = 0d; j <= 9d && !done; j = j + 1d){
						comparisonResult = CompareFixedUnsignedIntegerWithShift(a, b, 0d, i);
						if(comparisonResult == 1d || comparisonResult == 0d){
							SubtractFixedUnsignedIntegerWithShift(a, a, b, 0d, i);
							qd = qd + 1d;
						}else{
							done = true;
						}
					}
					if(i < qdsCapacity){
						q.digits[(int)(i)] = qd;
					}else{
						success = false;
					}
				}
				if(success){
					/* Put the rest in the remainder.*/
					success = AddFixedUnsignedInteger(r, r, a);

					if(success){
						/* Reconstruct a.*/
						MultiplyFixedUnsignedInteger(a, q, b);
						AddFixedUnsignedInteger(a, a, r);
					}
				}
			}else{
				/* Put everything in the remainder.*/
				AddFixedUnsignedInteger(r, r, a);
			}
		}else{
			/* division by zero*/
			success = false;
		}

		return success;
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
		double i;

		refx = new StringReference();
		refx.stringx = new char [(int)(value.Length)];
		for(i = 0d; i < value.Length; i = i + 1d){
			refx.stringx[(int)(i)] = value[(int)(i)];
		}

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
		FreeStringReferenceArray(stringArrayReference.stringArray);
		delete(stringArrayReference);
	}


	public static void FreeStringReferenceArray(StringReference [] stringReferencesArray){
		double i;
		for(i = 0d; i < stringReferencesArray.Length; i = i + 1d){
			delete(stringReferencesArray[(int)(i)]);
		}
		delete(stringReferencesArray);
	}


	public static double Increase(NumberReference nRef){
		nRef.numberValue = nRef.numberValue + 1d;

		return nRef.numberValue;
	}


	public static double Decrease(NumberReference nRef){
		nRef.numberValue = nRef.numberValue - 1d;

		return nRef.numberValue;
	}


	public static double AddToReference(NumberReference nRef, double n){
		nRef.numberValue = nRef.numberValue + n;

		return nRef.numberValue;
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
			if(IsInteger(date.year)){
				if(date.month >= 1d && date.month <= 12d){
					if(IsInteger(date.month)){
						daysInMonth = GetDaysInMonth(date.year);
						daysInThisMonth = daysInMonth[(int)(date.month)];
						if(date.day >= 1d && date.day <= daysInThisMonth){
							if(IsInteger(date.day)){
								valid = true;
							}else{
								valid = false;
								message.stringx = "Day must be an integer.".ToCharArray();
							}
						}else{
							valid = false;
							message.stringx = "The month does not have the given day number.".ToCharArray();
						}
					}else{
						valid = false;
						message.stringx = "Month must be an integer.".ToCharArray();
					}
				}else{
					valid = false;
					message.stringx = "Month must be between 1 and 12, inclusive.".ToCharArray();
				}
			}else{
				valid = false;
				message.stringx = "Year must be an integer.".ToCharArray();
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


	public static bool AddMonthsToDate(Date date, double months, StringReference message){
		double i;
		bool success;
		Date backup;

		backup = CopyDate(date);

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

		success = IsValidDate(date, message);

		if(success){
		}else{
			/* Restore old date*/
			AssignDate(date, backup);
		}

		return success;
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
		bool less;

		less = false;

		if(a.year < b.year){
			less = true;
		}else if(a.year == b.year){
			if(a.month < b.month){
				less = true;
			}else if(a.month == b.month){
				if(a.day < b.day){
					less = true;
				}else{
				}
			}
		}

		return less;
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
		bool done, success;
		Date dateOfInterest;
		LinkedListNumbers list;
		double [] result;
		StringReference message;

		list = CreateLinkedListNumbers();
		message = new StringReference();

		done = false;
		dateOfInterest = new Date();
		AssignDate(dateOfInterest, from);
		for(; !done; ){
			if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
				done = true;
			}

			entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest.year, dateOfInterest.month);
			LinkedListAddNumber(list, entry);
			success = AddMonthsToDate(dateOfInterest, 1d, message);
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


	public static void ArrayAddAll(Array backups, Array from){
		double i;
		Data data;

		for(i = 0d; i < ArrayLength(from); i = i + 1d){
			data = ArrayIndex(from, i);
			AddDataToArray(backups, data);
		}
	}


	public static bool SortStringArray(Array a){
		return SortStringArrayWithOptions(a, true);
	}


	public static bool SortStringArrayDescending(Array a){
		return SortStringArrayWithOptions(a, false);
	}


	public static bool SortStringArrayWithOptions(Array a, bool asc){
		bool success;
		double i, j, len, cmp;
		bool swapped, swap;
		char [] tmp;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			if(IsString(ArrayIndex(a, i))){
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = a.array[(int)(j)];
					db = a.array[(int)(j + 1d)];

					cmp = StringOrder(da.stringx, db.stringx);
					if(asc){
						swap = cmp < 0d;
					}else{
						swap = cmp > 0d;
					}

					if(swap){
						tmp = da.stringx;
						da.stringx = db.stringx;
						db.stringx = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}


	public static double StringOrder(char [] a, char [] b){
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


	public static bool SortNumberArray(Array a){
		return SortNumberArrayWithOptions(a, true);
	}


	public static bool SortNumberArrayDescending(Array a){
		return SortNumberArrayWithOptions(a, false);
	}


	public static bool SortNumberArrayWithOptions(Array a, bool asc){
		bool success;
		double i, j, len;
		bool swapped, swap;
		double tmp;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			if(IsNumber(ArrayIndex(a, i))){
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = a.array[(int)(j)];
					db = a.array[(int)(j + 1d)];

					if(asc){
						swap = da.number > db.number;
					}else{
						swap = da.number < db.number;
					}

					if(swap){
						tmp = da.number;
						da.number = db.number;
						db.number = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}


	public static bool SortStructArrayByNumberKey(Array a, char [] key){
		return SortStructArrayByNumberKeyWithOptions(a, key, true);
	}


	public static bool SortStructArrayByNumberKeyDescending(Array a, char [] key){
		return SortStructArrayByNumberKeyWithOptions(a, key, false);
	}


	public static bool SortStructArrayByNumberKeyWithOptions(Array a, char [] key, bool asc){
		bool success;
		double i, j, len;
		bool swapped, swap;
		Structure tmp;
		double na, nb;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			da = ArrayIndex(a, i);
			if(IsStructure(da)){
				if(StructHasKey(da.structure, key)){
					da = GetDataFromStruct(da.structure, key);
					if(IsNumber(da)){
					}else{
						success = false;
					}
				}else{
					success = false;
				}
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = ArrayIndex(a, j);
					db = ArrayIndex(a, j + 1d);

					na = GetNumberFromStruct(da.structure, key);
					nb = GetNumberFromStruct(db.structure, key);

					if(asc){
						swap = na > nb;
					}else{
						swap = na < nb;
					}

					if(swap){
						tmp = da.structure;
						da.structure = db.structure;
						db.structure = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}


	public static bool SortStructArrayByStringKey(Array a, char [] key){
		return SortStructArrayByStringKeyWithOptions(a, key, true);
	}


	public static bool SortStructArrayByStringKeyDescending(Array a, char [] key){
		return SortStructArrayByStringKeyWithOptions(a, key, false);
	}


	public static bool SortStructArrayByStringKeyWithOptions(Array a, char [] key, bool asc){
		bool success;
		double i, j, len, cmp;
		bool swapped, swap;
		Structure tmp;
		char [] sa, sb;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			da = ArrayIndex(a, i);
			if(IsStructure(da)){
				if(StructHasKey(da.structure, key)){
					da = GetDataFromStruct(da.structure, key);
					if(IsString(da)){
					}else{
						success = false;
					}
				}else{
					success = false;
				}
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = ArrayIndex(a, j);
					db = ArrayIndex(a, j + 1d);

					sa = GetStringFromStruct(da.structure, key);
					sb = GetStringFromStruct(db.structure, key);

					cmp = StringOrder(sa, sb);
					if(asc){
						swap = cmp < 0d;
					}else{
						swap = cmp > 0d;
					}
					if(swap){
						tmp = da.structure;
						da.structure = db.structure;
						db.structure = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
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


	public static bool arraysNumberArrayContains(double [] a, double e){
		bool found;
		double i;

		found = false;

		for(i = 0d; i < a.Length && !found; i = i + 1d){
			if(arraysIndexNumber(a, i) == e){
				found = true;
			}
		}

		return found;
	}


	public static double arraysIndexNumber(double [] array, double index){
		return array[(int)(index)];
	}


	public static char arraysIndexChar(char [] array, double index){
		return array[(int)(index)];
	}


	public static bool arraysIndexBoolean(bool [] array, double index){
		return array[(int)(index)];
	}


	public static char [] arraysIndexString(StringReference [] array, double index){
		return array[(int)(index)].stringx;
	}


	public static bool arraysGetMinimum(double [] data, NumberReference minimumReference){
		double i, minimum;
		bool success;

		if(data.Length >= 1d){
			minimum = data[0];
			for(i = 0d; i < data.Length; i = i + 1d){
				minimum = Min(minimum, data[(int)(i)]);
			}
			minimumReference.numberValue = minimum;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static bool arraysGetMaximum(double [] data, NumberReference maximumReference){
		double i, maximum;
		bool success;

		if(data.Length >= 1d){
			maximum = data[0];
			for(i = 0d; i < data.Length; i = i + 1d){
				maximum = Max(maximum, data[(int)(i)]);
			}
			maximumReference.numberValue = maximum;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static void arraysAssignNumberArray(double [] asx, double [] bs){
		double i;

		for(i = 0d; i < Min(asx.Length, bs.Length); i = i + 1d){
			asx[(int)(i)] = bs[(int)(i)];
		}
	}


	public static void arraysAssignBooleanArray(bool [] asx, bool [] bs){
		double i;

		for(i = 0d; i < Min(asx.Length, bs.Length); i = i + 1d){
			asx[(int)(i)] = bs[(int)(i)];
		}
	}


	public static void arraysAssignString(char [] asx, char [] bs){
		double i;

		for(i = 0d; i < Min(asx.Length, bs.Length); i = i + 1d){
			asx[(int)(i)] = bs[(int)(i)];
		}
	}


	public static void arraysRearrangeArray(double [] asx, double [] indexes){
		double [] bs;
		double i;

		bs = new double [(int)(asx.Length)];

		arraysAssignNumberArray(bs, asx);

		for(i = 0d; i < indexes.Length; i = i + 1d){
			asx[(int)(i)] = bs[(int)(indexes[(int)(i)])];
		}

		delete(bs);
	}


	public static void arraysSetNumberArrayRange(double [] data, double offset, double [] str){
		double i;

		for(i = 0d; i < str.Length && offset + i < data.Length; i = i + 1d){
			data[(int)(offset + i)] = str[(int)(i)];
		}
	}


	public static bool arraysCopyNumberArrayValues(double [] a, double [] b){
		bool success;
		double i;

		success = a.Length == b.Length;

		if(success){
			for(i = 0d; i < a.Length; i = i + 1d){
				a[(int)(i)] = b[(int)(i)];
			}
		}

		return success;
	}


	public static bool arraysCopyBooleanArrayValues(bool [] a, bool [] b){
		bool success;
		double i;

		success = a.Length == b.Length;

		if(success){
			for(i = 0d; i < a.Length; i = i + 1d){
				a[(int)(i)] = b[(int)(i)];
			}
		}

		return success;
	}


	public static bool arraysCopyStringValues(char [] a, char [] b){
		bool success;
		double i;

		success = a.Length == b.Length;

		if(success){
			for(i = 0d; i < a.Length; i = i + 1d){
				a[(int)(i)] = b[(int)(i)];
			}
		}

		return success;
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
		double d, factor, a, x, tz, extra, dotpos, p, zero;
		bool isPositive, done, lessThan1, isInt;
		char [] str, ds;
		NumberReference factorRef;

		factorRef = new NumberReference();

		isPositive = true;

		if(number < 0d){
			isPositive = false;
			number = Abs(number);
		}

		if(number == 0d){
			str = "0".ToCharArray();
		}else if(number > 999999999999999e99){
			/* Guard the number against relaxations.*/
			if(isPositive){
				str = "Infinity".ToCharArray();
			}else{
				str = "-Infinity".ToCharArray();
			}
		}else{
			lessThan1 = number < 1d;

			/* Guard the number against relaxations.*/
			if(number < 1e-99){
				number = 0d;
			}

			/* 1. Turn number into an integer with 15 digits.*/
			number = NumberTo15DigitInteger(number, factorRef);
			factor = factorRef.numberValue;
			delete(factorRef);

			/* 2. Extract the 15 digits*/
			ds = new char [15];

			a = number;
			zero = '0';
			for(d = 0d; d < 15d; d = d + 1d){
				x = a - Floor(a/10d)*10d;
				ds[(int)(15d - d - 1d)] = (char)((x + zero));
				a = Floor(a/10d);
			}

			/* 3. Remove trailing zeros*/
			tz = 0d;
			done = false;
			for(d = 0d; d < 15d && !done; d = d + 1d){
				if(ds[(int)(15d - d - 1d)] == '0'){
					tz = tz + 1d;
				}else{
					done = true;
				}
			}
			ds = strSubstring(ds, 0d, 15d - tz);

			/* 4. Determine if integer*/
			isInt = factor + tz >= 0d;

			/* 5. Fill into formats*/
			if(isInt){
				/* |-----|*/
				/* AAAAAAA00000000*/
				str = new char [(int)(15d + factor)];
				for(d = 0d; d < str.Length; d = d + 1d){
					str[(int)(d)] = '0';
				}
				for(d = 0d; d < ds.Length; d = d + 1d){
					str[(int)(d)] = ds[(int)(d)];
				}
			}else if(lessThan1){
				/*       |-----|*/
				/* 0.0000AAAAAAA*/
				extra = -factor - 15d;
				str = new char [(int)(2d + extra + 15d - tz)];
				for(d = 0d; d < str.Length; d = d + 1d){
					str[(int)(d)] = '0';
				}
				str[1] = '.';
				for(d = 0d; d < ds.Length; d = d + 1d){
					str[(int)(2d + extra + d)] = ds[(int)(d)];
				}
			}else{
				/* |-------|*/
				/* AAAA.AAAA*/
				str = new char [(int)(1d + 15d - tz)];
				dotpos = 15d + factor;
				p = 0d;
				for(d = 0d; d < str.Length; d = d + 1d){
					if(d == dotpos){
						str[(int)(d)] = '.';
					}else{
						str[(int)(d)] = ds[(int)(p)];
						p = p + 1d;
					}
				}
			}
		}

		/* Done*/
		if(!isPositive){
			str = strConcatenateString("-".ToCharArray(), str);
		}

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


	public static double NumberTo15DigitInteger(double n, NumberReference factorRef){
		double i, dp;
		double [] factors;

		factors = GetPowersOfTenFor15d2e();
		dp = GetFirstDecimalDigitPosition(n);
		factorRef.numberValue = dp - 14d;

		i = 14d + -dp;

		n = MultiplyWithIntegerPowerOf10(n, factors, i);

		delete(factors);

		n = Roundx(n);

		if(n >= 1e15){
			n = n/10d;
			factorRef.numberValue = factorRef.numberValue + 1d;
		}

		return n;
	}


	public static double MultiplyWithIntegerPowerOf10(double n, double [] factors, double power){
		n = n*factors[(int)(power + 99d)];

		return n;
	}


	public static double GetFirstDecimalDigitPosition(double n){
		double power, i;
		double [] factors;
		bool found;

		n = Abs(n);

		factors = GetPowersOfTenFor15d2e();

		power = 1d;

		if(n == 0d){
			power = 0d;
		}else if(n > 999999999999999e99){
			/* This guards against relaxed variables' max value*/
			power = 114d;
		}else if(n < 1e-99){
			/* This guards against relaxed variables' min value*/
			power = -100d;
		}else{
			found = false;
			/* Search the most likely space first.*/
			for(i = 99d - 20d; i < 99d + 20d && !found; i = i + 1d){
				if(n >= factors[(int)(i)] && n < factors[(int)(i + 1d)]){
					power = i - 99d;
					found = true;
				}
			}
			/* Search the whole space*/
			for(i = 0d; i < factors.Length - 1d && !found; i = i + 1d){
				if(n >= factors[(int)(i)] && n < factors[(int)(i + 1d)]){
					power = i - 99d;
					found = true;
				}
			}
			if(!found){
				if(n >= 100000000000000e99 && n <= 999999999999999e99){
					power = i - 99d;
				}
			}
		}

		delete(factors);

		/* Normal returns are -99 to 113. If -100 or 114 is returned, it means a relaxation is used.*/
		return power;
	}


	public static double [] GetPowersOfTenFor15d2e(){
		double [] factors;

		factors = new double [213];

		factors[0] = 1e-99;
		factors[1] = 1e-98;
		factors[2] = 1e-97;
		factors[3] = 1e-96;
		factors[4] = 1e-95;
		factors[5] = 1e-94;
		factors[6] = 1e-93;
		factors[7] = 1e-92;
		factors[8] = 1e-91;
		factors[9] = 1e-90;
		factors[10] = 1e-89;
		factors[11] = 1e-88;
		factors[12] = 1e-87;
		factors[13] = 1e-86;
		factors[14] = 1e-85;
		factors[15] = 1e-84;
		factors[16] = 1e-83;
		factors[17] = 1e-82;
		factors[18] = 1e-81;
		factors[19] = 1e-80;
		factors[20] = 1e-79;
		factors[21] = 1e-78;
		factors[22] = 1e-77;
		factors[23] = 1e-76;
		factors[24] = 1e-75;
		factors[25] = 1e-74;
		factors[26] = 1e-73;
		factors[27] = 1e-72;
		factors[28] = 1e-71;
		factors[29] = 1e-70;
		factors[30] = 1e-69;
		factors[31] = 1e-68;
		factors[32] = 1e-67;
		factors[33] = 1e-66;
		factors[34] = 1e-65;
		factors[35] = 1e-64;
		factors[36] = 1e-63;
		factors[37] = 1e-62;
		factors[38] = 1e-61;
		factors[39] = 1e-60;
		factors[40] = 1e-59;
		factors[41] = 1e-58;
		factors[42] = 1e-57;
		factors[43] = 1e-56;
		factors[44] = 1e-55;
		factors[45] = 1e-54;
		factors[46] = 1e-53;
		factors[47] = 1e-52;
		factors[48] = 1e-51;
		factors[49] = 1e-50;
		factors[50] = 1e-49;
		factors[51] = 1e-48;
		factors[52] = 1e-47;
		factors[53] = 1e-46;
		factors[54] = 1e-45;
		factors[55] = 1e-44;
		factors[56] = 1e-43;
		factors[57] = 1e-42;
		factors[58] = 1e-41;
		factors[59] = 1e-40;
		factors[60] = 1e-39;
		factors[61] = 1e-38;
		factors[62] = 1e-37;
		factors[63] = 1e-36;
		factors[64] = 1e-35;
		factors[65] = 1e-34;
		factors[66] = 1e-33;
		factors[67] = 1e-32;
		factors[68] = 1e-31;
		factors[69] = 1e-30;
		factors[70] = 1e-29;
		factors[71] = 1e-28;
		factors[72] = 1e-27;
		factors[73] = 1e-26;
		factors[74] = 1e-25;
		factors[75] = 1e-24;
		factors[76] = 1e-23;
		factors[77] = 1e-22;
		factors[78] = 1e-21;
		factors[79] = 1e-20;
		factors[80] = 1e-19;
		factors[81] = 1e-18;
		factors[82] = 1e-17;
		factors[83] = 1e-16;
		factors[84] = 1e-15;
		factors[85] = 1e-14;
		factors[86] = 1e-13;
		factors[87] = 1e-12;
		factors[88] = 1e-11;
		factors[89] = 1e-10;
		factors[90] = 1e-9;
		factors[91] = 1e-8;
		factors[92] = 1e-7;
		factors[93] = 1e-6;
		factors[94] = 1e-5;
		factors[95] = 1e-4;
		factors[96] = 1e-3;
		factors[97] = 1e-2;
		factors[98] = 1e-1;
		factors[99] = 1e0;
		factors[100] = 1e1;
		factors[101] = 1e2;
		factors[102] = 1e3;
		factors[103] = 1e4;
		factors[104] = 1e5;
		factors[105] = 1e6;
		factors[106] = 1e7;
		factors[107] = 1e8;
		factors[108] = 1e9;
		factors[109] = 1e10;
		factors[110] = 1e11;
		factors[111] = 1e12;
		factors[112] = 1e13;
		factors[113] = 1e14;
		factors[114] = 1e15;
		factors[115] = 1e16;
		factors[116] = 1e17;
		factors[117] = 1e18;
		factors[118] = 1e19;
		factors[119] = 1e20;
		factors[120] = 1e21;
		factors[121] = 1e22;
		factors[122] = 1e23;
		factors[123] = 1e24;
		factors[124] = 1e25;
		factors[125] = 1e26;
		factors[126] = 1e27;
		factors[127] = 1e28;
		factors[128] = 1e29;
		factors[129] = 1e30;
		factors[130] = 1e31;
		factors[131] = 1e32;
		factors[132] = 1e33;
		factors[133] = 1e34;
		factors[134] = 1e35;
		factors[135] = 1e36;
		factors[136] = 1e37;
		factors[137] = 1e38;
		factors[138] = 1e39;
		factors[139] = 1e40;
		factors[140] = 1e41;
		factors[141] = 1e42;
		factors[142] = 1e43;
		factors[143] = 1e44;
		factors[144] = 1e45;
		factors[145] = 1e46;
		factors[146] = 1e47;
		factors[147] = 1e48;
		factors[148] = 1e49;
		factors[149] = 1e50;
		factors[150] = 1e51;
		factors[151] = 1e52;
		factors[152] = 1e53;
		factors[153] = 1e54;
		factors[154] = 1e55;
		factors[155] = 1e56;
		factors[156] = 1e57;
		factors[157] = 1e58;
		factors[158] = 1e59;
		factors[159] = 1e60;
		factors[160] = 1e61;
		factors[161] = 1e62;
		factors[162] = 1e63;
		factors[163] = 1e64;
		factors[164] = 1e65;
		factors[165] = 1e66;
		factors[166] = 1e67;
		factors[167] = 1e68;
		factors[168] = 1e69;
		factors[169] = 1e70;
		factors[170] = 1e71;
		factors[171] = 1e72;
		factors[172] = 1e73;
		factors[173] = 1e74;
		factors[174] = 1e75;
		factors[175] = 1e76;
		factors[176] = 1e77;
		factors[177] = 1e78;
		factors[178] = 1e79;
		factors[179] = 1e80;
		factors[180] = 1e81;
		factors[181] = 1e82;
		factors[182] = 1e83;
		factors[183] = 1e84;
		factors[184] = 1e85;
		factors[185] = 1e86;
		factors[186] = 1e87;
		factors[187] = 1e88;
		factors[188] = 1e89;
		factors[189] = 1e90;
		factors[190] = 1e91;
		factors[191] = 1e92;
		factors[192] = 1e93;
		factors[193] = 1e94;
		factors[194] = 1e95;
		factors[195] = 1e96;
		factors[196] = 1e97;
		factors[197] = 1e98;
		factors[198] = 1e99;
		factors[199] = 10e99;
		factors[200] = 100e99;
		factors[201] = 1000e99;
		factors[202] = 10000e99;
		factors[203] = 100000e99;
		factors[204] = 1000000e99;
		factors[205] = 10000000e99;
		factors[206] = 100000000e99;
		factors[207] = 1000000000e99;
		factors[208] = 10000000000e99;
		factors[209] = 100000000000e99;
		factors[210] = 1000000000000e99;
		factors[211] = 10000000000000e99;
		factors[212] = 100000000000000e99;

		return factors;
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
		double d, m, i;
		NumberReference factorRef;

		n = Abs(n);

		factorRef = new NumberReference();
		n = NumberTo15DigitInteger(n, factorRef);
		delete(factorRef);

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
		return CreateDecimalNumberFromStringWithCheck(stringx, decimalReference, message);
	}


	public static double CreateNumberFromDecimalString(char [] stringx){
		NumberReference numberRef;
		StringReference message;
		double number;

		numberRef = CreateNumberReference(0d);
		message = CreateStringReference("".ToCharArray());
		CreateDecimalNumberFromStringWithCheck(stringx, numberRef, message);
		number = numberRef.numberValue;

		delete(numberRef);
		delete(message);

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


	public static bool CreateDecimalNumberFromStringWithCheck(char [] stringx, NumberReference numberReference, StringReference message){
		bool success;
		BooleanReference numberIsPositive, exponentIsPositive;
		NumberArrayReference beforePoint, afterPoint, exponent;

		numberIsPositive = CreateBooleanReference(true);
		exponentIsPositive = CreateBooleanReference(true);
		beforePoint = new NumberArrayReference();
		afterPoint = new NumberArrayReference();
		exponent = new NumberArrayReference();

		success = ExtractPartsFromNumberString(stringx, 10d, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

		if(success){
			numberReference.numberValue = CreateDecimalNumberFromParts(numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray);
		}

		delete(numberIsPositive);
		delete(exponentIsPositive);
		delete(beforePoint);
		delete(afterPoint);
		delete(exponent);

		return success;
	}


	public static double CreateNumberFromParts(double basex, bool numberIsPositive, double [] beforePoint, double [] afterPoint, bool exponentIsPositive, double [] exponent){
		double n, i, d, e, digits, integerOffset, maxDigits, roundingDigit;
		bool digitsStarted, roundingDigitSet;

		n = 0d;
		e = 0d;
		digits = 0d;
		digitsStarted = false;
		integerOffset = 0d;
		maxDigits = Floor(15d*Log(10d)/Log(basex));
		roundingDigitSet = false;
		roundingDigit = 0d;

		/* We construct an integer n, inserting one and one digit and shifting left.*/
		/* We read up to a certain amount of digits.*/
		for(i = 0d; i < beforePoint.Length + afterPoint.Length && digits < maxDigits + 1d; i = i + 1d){
			if(i < beforePoint.Length){
				d = beforePoint[(int)(i)];
			}else{
				d = afterPoint[(int)(i - beforePoint.Length)];
			}

			if(digits < maxDigits){
				if(d != 0d){
					digitsStarted = true;
					integerOffset = beforePoint.Length - i;
				}

				n = n*basex;
				n = n + d;

				integerOffset = integerOffset - 1d;
			}else{
				roundingDigitSet = true;
				roundingDigit = d;
			}

			if(digitsStarted){
				digits = digits + 1d;
			}
		}

		if(roundingDigitSet){
			if(roundingDigit >= basex/2d){
				n = n + 1d;
			}
		}

		for(i = 0d; i < exponent.Length; i = i + 1d){
			d = exponent[(int)(i)];
			e = e*basex;
			e = e + d;
		}

		if(!exponentIsPositive){
			e = -e;
		}

		if(!numberIsPositive){
			n = -n;
		}

		n = n*Pow(basex, e + integerOffset);

		return n;
	}


	public static double CreateDecimalNumberFromParts(bool numberIsPositive, double [] beforePoint, double [] afterPoint, bool exponentIsPositive, double [] exponent){
		double n, i, d, e, digits, integerOffset, maxDigits, roundingDigit;
		bool digitsStarted, roundingDigitSet;

		n = 0d;
		e = 0d;
		digits = 0d;
		digitsStarted = false;
		integerOffset = 0d;
		maxDigits = 15d;
		roundingDigitSet = false;
		roundingDigit = 0d;

		/* We construct an integer n, inserting one and one digit and shifting left.*/
		/* We read up to 15 digits, but we note a 16th digit to correctly round the result.*/
		for(i = 0d; i < beforePoint.Length + afterPoint.Length && digits < maxDigits + 1d; i = i + 1d){
			if(i < beforePoint.Length){
				d = beforePoint[(int)(i)];
			}else{
				d = afterPoint[(int)(i - beforePoint.Length)];
			}

			if(digits < maxDigits){
				if(d != 0d){
					digitsStarted = true;
					integerOffset = beforePoint.Length - i;
				}

				n = n*10d;
				n = n + d;

				integerOffset = integerOffset - 1d;
			}else{
				roundingDigitSet = true;
				roundingDigit = d;
			}

			if(digitsStarted){
				digits = digits + 1d;
			}
		}

		if(roundingDigitSet){
			if(roundingDigit >= 5d){
				n = n + 1d;
			}
		}

		for(i = 0d; i < exponent.Length; i = i + 1d){
			d = exponent[(int)(i)];
			e = e*10d;
			e = e + d;
		}

		if(!exponentIsPositive){
			e = -e;
		}

		if(!numberIsPositive){
			n = -n;
		}

		n = n*Pow(10d, e + integerOffset);

		return n;
	}


	public static bool ExtractPartsFromNumberString(char [] n, double basex, BooleanReference numberIsPositive, NumberArrayReference beforePoint, NumberArrayReference afterPoint, BooleanReference exponentIsPositive, NumberArrayReference exponent, StringReference message){
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
			message.stringx = "Number cannot have length zero.".ToCharArray();
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
				message.stringx = "Number must have at least one number after the optional sign.".ToCharArray();
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
						message.stringx = "There must be at least one digit after the decimal point.".ToCharArray();
					}
				}else{
					success = false;
					message.stringx = "There must be at least one digit after the decimal point.".ToCharArray();
				}
			}else if(basex <= 14d && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
				if(i < n.Length){
					success = true;
					afterPoint.numberArray = new double [0];
				}else{
					success = false;
					message.stringx = "There must be at least one digit after the exponent.".ToCharArray();
				}
			}else{
				success = false;
				message.stringx = "Expected decimal point or exponent symbol.".ToCharArray();
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
								message.stringx = "There cannot be any characters past the exponent of the number.".ToCharArray();
							}
						}else{
							success = false;
							message.stringx = "There must be at least one digit after the decimal point.".ToCharArray();
						}
					}else{
						success = false;
						message.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray();
					}
				}else{
					success = false;
					message.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray();
				}
			}else{
				success = false;
				message.stringx = "Expected exponent symbol.".ToCharArray();
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


	public static StringReference [] strSplitByWhitespace(char [] toSplit){
		StringReference [] parts;
		double i, skip;
		char c;
		LinkedListStrings ll;
		LinkedListCharacters next;
		char [] part;
		bool split;

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0d; i < toSplit.Length; ){
			c = toSplit[(int)(i)];

			split = false;
			skip = 0d;
			for(; (c == ' ' || c == '\n' || c == '\t') && i + skip <= toSplit.Length; ){
				if(i + skip != toSplit.Length){
					c = toSplit[(int)(i + skip)];
				}
				skip = skip + 1d;
				split = true;
			}

			if(split){
				part = LinkedListCharactersToArray(next);
				LinkedListAddString(ll, part);
				FreeLinkedListCharacter(next);
				next = CreateLinkedListCharacter();
				i = i + skip - 1d;
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


	public static char cHexadecimalDigitToCharacter(double digit){
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
		}else if(digit == 10d){
			c = 'A';
		}else if(digit == 11d){
			c = 'B';
		}else if(digit == 12d){
			c = 'C';
		}else if(digit == 13d){
			c = 'D';
		}else if(digit == 14d){
			c = 'E';
		}else if(digit == 15d){
			c = 'F';
		}else{
			c = '0';
		}

		return c;
	}


	public static double cCharacterToHexadecimalDigit(char c){
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
		}else if(c == 'A'){
			digit = 10d;
		}else if(c == 'B'){
			digit = 11d;
		}else if(c == 'C'){
			digit = 12d;
		}else if(c == 'D'){
			digit = 13d;
		}else if(c == 'E'){
			digit = 14d;
		}else if(c == 'F'){
			digit = 15d;
		}else{
			digit = 0d;
		}

		return digit;
	}


	public static RGBA GetBlack(){
		RGBA black;
		black = new RGBA();
		black.a = 1d;
		black.r = 0d;
		black.g = 0d;
		black.b = 0d;
		return black;
	}


	public static RGBA GetWhite(){
		RGBA white;
		white = new RGBA();
		white.a = 1d;
		white.r = 1d;
		white.g = 1d;
		white.b = 1d;
		return white;
	}


	public static RGBA GetTransparent(){
		RGBA transparent;
		transparent = new RGBA();
		transparent.a = 0d;
		transparent.r = 0d;
		transparent.g = 0d;
		transparent.b = 0d;
		return transparent;
	}


	public static RGBA GetGray(double percentage){
		RGBA black;
		black = new RGBA();
		black.a = 1d;
		black.r = 1d - percentage;
		black.g = 1d - percentage;
		black.b = 1d - percentage;
		return black;
	}


	public static RGBA CreateRGBColor(double r, double g, double b){
		RGBA color;
		color = new RGBA();
		color.a = 1d;
		color.r = r;
		color.g = g;
		color.b = b;
		return color;
	}


	public static RGBA CreateRGBAColor(double r, double g, double b, double a){
		RGBA color;
		color = new RGBA();
		color.a = a;
		color.r = r;
		color.g = g;
		color.b = b;
		return color;
	}


	public static RGBABitmapImage CreateImage(double w, double h, RGBA color){
		RGBABitmapImage image;
		double i, j;

		image = new RGBABitmapImage();
		image.x = new RGBABitmap [(int)(w)];
		for(i = 0d; i < w; i = i + 1d){
			image.x[(int)(i)] = new RGBABitmap();
			image.x[(int)(i)].y = new RGBA [(int)(h)];
			for(j = 0d; j < h; j = j + 1d){
				image.x[(int)(i)].y[(int)(j)] = new RGBA();
				SetPixel(image, i, j, color);
			}
		}

		return image;
	}


	public static void DeleteImage(RGBABitmapImage image){
		double i, j, w, h;

		w = ImageWidth(image);
		h = ImageHeight(image);

		for(i = 0d; i < w; i = i + 1d){
			for(j = 0d; j < h; j = j + 1d){
				delete(image.x[(int)(i)].y[(int)(j)]);
			}
			delete(image.x[(int)(i)]);
		}
		delete(image);
	}


	public static double ImageWidth(RGBABitmapImage image){
		return image.x.Length;
	}


	public static double ImageHeight(RGBABitmapImage image){
		double height;

		if(ImageWidth(image) == 0d){
			height = 0d;
		}else{
			height = image.x[0].y.Length;
		}

		return height;
	}


	public static void SetPixel(RGBABitmapImage image, double x, double y, RGBA color){
		if(x >= 0d && x < ImageWidth(image) && y >= 0d && y < ImageHeight(image)){
			image.x[(int)(x)].y[(int)(y)].a = color.a;
			image.x[(int)(x)].y[(int)(y)].r = color.r;
			image.x[(int)(x)].y[(int)(y)].g = color.g;
			image.x[(int)(x)].y[(int)(y)].b = color.b;
		}
	}


	public static void DrawPixel(RGBABitmapImage image, double x, double y, RGBA color){
		double ra, ga, ba, aa;
		double rb, gb, bb, ab;
		double ro, go, bo, ao;
		RGBA c;

		if(x >= 0d && x < ImageWidth(image) && y >= 0d && y < ImageHeight(image)){
			ra = color.r;
			ga = color.g;
			ba = color.b;
			aa = color.a;

			c = GetImagePixel(image, x, y);
			rb = c.r;
			gb = c.g;
			bb = c.b;
			ab = c.a;

			ao = CombineAlpha(aa, ab);

			ro = AlphaBlend(ra, aa, rb, ab, ao);
			go = AlphaBlend(ga, aa, gb, ab, ao);
			bo = AlphaBlend(ba, aa, bb, ab, ao);

			image.x[(int)(x)].y[(int)(y)].r = ro;
			image.x[(int)(x)].y[(int)(y)].g = go;
			image.x[(int)(x)].y[(int)(y)].b = bo;
			image.x[(int)(x)].y[(int)(y)].a = ao;
		}
	}


	public static double CombineAlpha(double asx, double ad){
		return asx + ad*(1d - asx);
	}


	public static double AlphaBlend(double cs, double asx, double cd, double ad, double ao){
		return (cs*asx + cd*ad*(1d - asx))/ao;
	}


	public static void DrawHorizontalLine1px(RGBABitmapImage image, double x, double y, double length, RGBA color){
		double i;

		for(i = 0d; i < length; i = i + 1d){
			DrawPixel(image, x + i, y, color);
		}
	}


	public static void DrawVerticalLine1px(RGBABitmapImage image, double x, double y, double height, RGBA color){
		double i;

		for(i = 0d; i < height; i = i + 1d){
			DrawPixel(image, x, y + i, color);
		}
	}


	public static void DrawRectangle1px(RGBABitmapImage image, double x, double y, double width, double height, RGBA color){
		DrawHorizontalLine1px(image, x, y, width + 1d, color);
		DrawVerticalLine1px(image, x, y + 1d, height + 1d - 1d, color);
		DrawVerticalLine1px(image, x + width, y + 1d, height + 1d - 1d, color);
		DrawHorizontalLine1px(image, x + 1d, y + height, width + 1d - 2d, color);
	}


	public static void DrawImageOnImage(RGBABitmapImage dst, RGBABitmapImage src, double topx, double topy){
		double y, x;

		for(y = 0d; y < ImageHeight(src); y = y + 1d){
			for(x = 0d; x < ImageWidth(src); x = x + 1d){
				if(topx + x >= 0d && topx + x < ImageWidth(dst) && topy + y >= 0d && topy + y < ImageHeight(dst)){
					DrawPixel(dst, topx + x, topy + y, GetImagePixel(src, x, y));
				}
			}
		}
	}


	public static void DrawLine1px(RGBABitmapImage image, double x0, double y0, double x1, double y1, RGBA color){
		XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color);
	}


	public static void XiaolinWusLineAlgorithm(RGBABitmapImage image, double x0, double y0, double x1, double y1, RGBA color){
		bool steep;
		double x, t, dx, dy, g, xEnd, yEnd, xGap, xpxl1, ypxl1, intery, xpxl2, ypxl2, olda;

		olda = color.a;

		steep = Abs(y1 - y0) > Abs(x1 - x0);

		if(steep){
			t = x0;
			x0 = y0;
			y0 = t;

			t = x1;
			x1 = y1;
			y1 = t;
		}
		if(x0 > x1){
			t = x0;
			x0 = x1;
			x1 = t;

			t = y0;
			y0 = y1;
			y1 = t;
		}

		dx = x1 - x0;
		dy = y1 - y0;
		g = dy/dx;

		if(dx == 0d){
			g = 1d;
		}

		xEnd = Roundx(x0);
		yEnd = y0 + g*(xEnd - x0);
		xGap = OneMinusFractionalPart(x0 + 0.5);
		xpxl1 = xEnd;
		ypxl1 = Floor(yEnd);
		if(steep){
			DrawPixel(image, ypxl1, xpxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, ypxl1 + 1d, xpxl1, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}else{
			DrawPixel(image, xpxl1, ypxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, xpxl1, ypxl1 + 1d, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}
		intery = yEnd + g;

		xEnd = Roundx(x1);
		yEnd = y1 + g*(xEnd - x1);
		xGap = FractionalPart(x1 + 0.5);
		xpxl2 = xEnd;
		ypxl2 = Floor(yEnd);
		if(steep){
			DrawPixel(image, ypxl2, xpxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, ypxl2 + 1d, xpxl2, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}else{
			DrawPixel(image, xpxl2, ypxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, xpxl2, ypxl2 + 1d, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}

		if(steep){
			for(x = xpxl1 + 1d; x <= xpxl2 - 1d; x = x + 1d){
				DrawPixel(image, Floor(intery), x, SetBrightness(color, OneMinusFractionalPart(intery)));
				DrawPixel(image, Floor(intery) + 1d, x, SetBrightness(color, FractionalPart(intery)));
				intery = intery + g;
			}
		}else{
			for(x = xpxl1 + 1d; x <= xpxl2 - 1d; x = x + 1d){
				DrawPixel(image, x, Floor(intery), SetBrightness(color, OneMinusFractionalPart(intery)));
				DrawPixel(image, x, Floor(intery) + 1d, SetBrightness(color, FractionalPart(intery)));
				intery = intery + g;
			}
		}

		color.a = olda;
	}


	public static double OneMinusFractionalPart(double x){
		return 1d - FractionalPart(x);
	}


	public static double FractionalPart(double x){
		return x - Floor(x);
	}


	public static RGBA SetBrightness(RGBA color, double newBrightness){
		color.a = newBrightness;
		return color;
	}


	public static void DrawQuadraticBezierCurve(RGBABitmapImage image, double x0, double y0, double cx, double cy, double x1, double y1, RGBA color){
		double t, dt, dx, dy;
		NumberReference xs, ys, xe, ye;

		dx = Abs(x0 - x1);
		dy = Abs(y0 - y1);

		dt = 1d/Sqrt(Pow(dx, 2d) + Pow(dy, 2d));

		xs = new NumberReference();
		ys = new NumberReference();
		xe = new NumberReference();
		ye = new NumberReference();

		QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, 0d, xs, ys);
		for(t = dt; t <= 1d; t = t + dt){
			QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, xe, ye);
			DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color);
			xs.numberValue = xe.numberValue;
			ys.numberValue = ye.numberValue;
		}

		delete(xs);
		delete(ys);
		delete(xe);
		delete(ye);
	}


	public static void QuadraticBezierPoint(double x0, double y0, double cx, double cy, double x1, double y1, double t, NumberReference x, NumberReference y){
		x.numberValue = Pow(1d - t, 2d)*x0 + (1d - t)*2d*t*cx + Pow(t, 2d)*x1;
		y.numberValue = Pow(1d - t, 2d)*y0 + (1d - t)*2d*t*cy + Pow(t, 2d)*y1;
	}


	public static void DrawCubicBezierCurve(RGBABitmapImage image, double x0, double y0, double c0x, double c0y, double c1x, double c1y, double x1, double y1, RGBA color){
		double t, dt, dx, dy;
		NumberReference xs, ys, xe, ye;

		dx = Abs(x0 - x1);
		dy = Abs(y0 - y1);

		dt = 1d/Sqrt(Pow(dx, 2d) + Pow(dy, 2d));

		xs = new NumberReference();
		ys = new NumberReference();
		xe = new NumberReference();
		ye = new NumberReference();

		CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, 0d, xs, ys);
		for(t = dt; t <= 1d; t = t + dt){
			CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, xe, ye);
			DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color);
			xs.numberValue = xe.numberValue;
			ys.numberValue = ye.numberValue;
		}

		delete(xs);
		delete(ys);
		delete(xe);
		delete(ye);
	}


	public static void CubicBezierPoint(double x0, double y0, double c0x, double c0y, double c1x, double c1y, double x1, double y1, double t, NumberReference x, NumberReference y){
		x.numberValue = Pow(1d - t, 3d)*x0 + Pow(1d - t, 2d)*3d*t*c0x + (1d - t)*3d*Pow(t, 2d)*c1x + Pow(t, 3d)*x1;

		y.numberValue = Pow(1d - t, 3d)*y0 + Pow(1d - t, 2d)*3d*t*c0y + (1d - t)*3d*Pow(t, 2d)*c1y + Pow(t, 3d)*y1;
	}


	public static RGBABitmapImage CopyImage(RGBABitmapImage image){
		RGBABitmapImage copy;
		double i, j;

		copy = CreateImage(ImageWidth(image), ImageHeight(image), GetTransparent());

		for(i = 0d; i < ImageWidth(image); i = i + 1d){
			for(j = 0d; j < ImageHeight(image); j = j + 1d){
				SetPixel(copy, i, j, GetImagePixel(image, i, j));
			}
		}

		return copy;
	}


	public static RGBA GetImagePixel(RGBABitmapImage image, double x, double y){
		return image.x[(int)(x)].y[(int)(y)];
	}


	public static void HorizontalFlip(RGBABitmapImage img){
		double y, x;
		double tmp;
		RGBA c1, c2;

		for(y = 0d; y < ImageHeight(img); y = y + 1d){
			for(x = 0d; x < ImageWidth(img)/2d; x = x + 1d){
				c1 = GetImagePixel(img, x, y);
				c2 = GetImagePixel(img, ImageWidth(img) - 1d - x, y);

				tmp = c1.a;
				c1.a = c2.a;
				c2.a = tmp;

				tmp = c1.r;
				c1.r = c2.r;
				c2.r = tmp;

				tmp = c1.g;
				c1.g = c2.g;
				c2.g = tmp;

				tmp = c1.b;
				c1.b = c2.b;
				c2.b = tmp;
			}
		}
	}


	public static void DrawFilledRectangle(RGBABitmapImage image, double x, double y, double w, double h, RGBA color){
		double i, j;

		for(i = 0d; i < w; i = i + 1d){
			for(j = 0d; j < h; j = j + 1d){
				SetPixel(image, x + i, y + j, color);
			}
		}
	}


	public static RGBABitmapImage RotateAntiClockwise90Degrees(RGBABitmapImage image){
		RGBABitmapImage rotated;
		double x, y;

		rotated = CreateImage(ImageHeight(image), ImageWidth(image), GetBlack());

		for(y = 0d; y < ImageHeight(image); y = y + 1d){
			for(x = 0d; x < ImageWidth(image); x = x + 1d){
				SetPixel(rotated, y, ImageWidth(image) - 1d - x, GetImagePixel(image, x, y));
			}
		}

		return rotated;
	}


	public static void DrawCircle(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color);
	}


	public static void BresenhamsCircleDrawingAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double x, y, delta;

		y = radius;
		x = 0d;

		delta = 3d - 2d*radius;
		for(; y >= x; x = x + 1d){
			DrawLine1px(canvas, xCenter + x, yCenter + y, xCenter + x, yCenter + y, color);
			DrawLine1px(canvas, xCenter + x, yCenter - y, xCenter + x, yCenter - y, color);
			DrawLine1px(canvas, xCenter - x, yCenter + y, xCenter - x, yCenter + y, color);
			DrawLine1px(canvas, xCenter - x, yCenter - y, xCenter - x, yCenter - y, color);

			DrawLine1px(canvas, xCenter - y, yCenter + x, xCenter - y, yCenter + x, color);
			DrawLine1px(canvas, xCenter - y, yCenter - x, xCenter - y, yCenter - x, color);
			DrawLine1px(canvas, xCenter + y, yCenter + x, xCenter + y, yCenter + x, color);
			DrawLine1px(canvas, xCenter + y, yCenter - x, xCenter + y, yCenter - x, color);

			if(delta < 0d){
				delta = delta + 4d*x + 6d;
			}else{
				delta = delta + 4d*(x - y) + 10d;
				y = y - 1d;
			}
		}
	}


	public static void DrawCircleMidpointAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double d, x, y;

		d = Floor((5d - radius*4d)/4d);
		x = 0d;
		y = radius;

		for(; x <= y; x = x + 1d){
			DrawPixel(canvas, xCenter + x, yCenter + y, color);
			DrawPixel(canvas, xCenter + x, yCenter - y, color);
			DrawPixel(canvas, xCenter - x, yCenter + y, color);
			DrawPixel(canvas, xCenter - x, yCenter - y, color);
			DrawPixel(canvas, xCenter + y, yCenter + x, color);
			DrawPixel(canvas, xCenter + y, yCenter - x, color);
			DrawPixel(canvas, xCenter - y, yCenter + x, color);
			DrawPixel(canvas, xCenter - y, yCenter - x, color);

			if(d < 0d){
				d = d + 2d*x + 1d;
			}else{
				d = d + 2d*(x - y) + 1d;
				y = y - 1d;
			}
		}
	}


	public static void DrawCircleBasicAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double pixels, a, da, dx, dy;

		/* Place the circle in the center of the pixel.*/
		xCenter = Floor(xCenter) + 0.5;
		yCenter = Floor(yCenter) + 0.5;

		pixels = 2d*PI*radius;

		/* Below a radius of 10 pixels, over-compensate to get a smoother circle.*/
		if(radius < 10d){
			pixels = pixels*10d;
		}

		da = 2d*PI/pixels;

		for(a = 0d; a < 2d*PI; a = a + da){
			dx = Cos(a)*radius;
			dy = Sin(a)*radius;

			/* Floor to get the pixel coordinate.*/
			DrawPixel(canvas, Floor(xCenter + dx), Floor(yCenter + dy), color);
		}
	}


	public static void DrawFilledCircle(RGBABitmapImage canvas, double x, double y, double r, RGBA color){
		DrawFilledCircleBasicAlgorithm(canvas, x, y, r, color);
	}


	public static void DrawFilledCircleMidpointAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double d, x, y;

		d = Floor((5d - radius*4d)/4d);
		x = 0d;
		y = radius;

		for(; x <= y; x = x + 1d){
			DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter + y, xCenter - x, yCenter + y, color);
			DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter - y, xCenter - x, yCenter - y, color);
			DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter + x, xCenter - y, yCenter + x, color);
			DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter - x, xCenter - y, yCenter - x, color);

			if(d < 0d){
				d = d + 2d*x + 1d;
			}else{
				d = d + 2d*(x - y) + 1d;
				y = y - 1d;
			}
		}
	}


	public static void DrawFilledCircleBasicAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double pixels, a, da, dx, dy;

		/* Place the circle in the center of the pixel.*/
		xCenter = Floor(xCenter) + 0.5;
		yCenter = Floor(yCenter) + 0.5;

		pixels = 2d*PI*radius;

		/* Below a radius of 10 pixels, over-compensate to get a smoother circle.*/
		if(radius < 10d){
			pixels = pixels*10d;
		}

		da = 2d*PI/pixels;

		/* Draw lines for a half-circle to fill an entire circle.*/
		for(a = 0d; a < PI; a = a + da){
			dx = Cos(a)*radius;
			dy = Sin(a)*radius;

			/* Floor to get the pixel coordinate.*/
			DrawVerticalLine1px(canvas, Floor(xCenter - dx), Floor(yCenter - dy), Floor(2d*dy) + 1d, color);
		}
	}


	public static void DrawTriangle(RGBABitmapImage canvas, double xCenter, double yCenter, double height, RGBA color){
		double x1, y1, x2, y2, x3, y3;

		x1 = Floor(xCenter + 0.5);
		y1 = Floor(Floor(yCenter + 0.5) - height);
		x2 = x1 - 2d*height*Tan(PI/6d);
		y2 = Floor(y1 + 2d*height);
		x3 = x1 + 2d*height*Tan(PI/6d);
		y3 = Floor(y1 + 2d*height);

		DrawLine1px(canvas, x1, y1, x2, y2, color);
		DrawLine1px(canvas, x1, y1, x3, y3, color);
		DrawLine1px(canvas, x2, y2, x3, y3, color);
	}


	public static void DrawFilledTriangle(RGBABitmapImage canvas, double xCenter, double yCenter, double height, RGBA color){
		double i, offset, x1, y1;

		x1 = Floor(xCenter + 0.5);
		y1 = Floor(Floor(yCenter + 0.5) - height);

		for(i = 0d; i <= 2d*height; i = i + 1d){
			offset = Floor(i*Tan(PI/6d));
			DrawHorizontalLine1px(canvas, x1 - offset, y1 + i, 2d*offset, color);
		}
	}


	public static void DrawLine(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, double thickness, RGBA color){
		DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color);
	}


	public static void DrawLineBresenhamsAlgorithmThick(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, double thickness, RGBA color){
		double x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r;

		dx = x2 - x1;
		dy = y2 - y1;

		incX = Sign(dx);
		incY = Sign(dy);

		dx = Abs(dx);
		dy = Abs(dy);

		if(dx > dy){
			pdx = incX;
			pdy = 0d;
			es = dy;
			el = dx;
		}else{
			pdx = 0d;
			pdy = incY;
			es = dx;
			el = dy;
		}

		x = x1;
		y = y1;
		err = el/2d;

		if(thickness >= 3d){
			r = thickness/2d;
			DrawCircle(canvas, x, y, r, color);
		}else if(Floor(thickness) == 2d){
			DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
		}else if(Floor(thickness) == 1d){
			DrawPixel(canvas, x, y, color);
		}

		for(t = 0d; t < el; t = t + 1d){
			err = err - es;
			if(err < 0d){
				err = err + el;
				x = x + incX;
				y = y + incY;
			}else{
				x = x + pdx;
				y = y + pdy;
			}

			if(thickness >= 3d){
				r = thickness/2d;
				DrawCircle(canvas, x, y, r, color);
			}else if(Floor(thickness) == 2d){
				DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
			}else if(Floor(thickness) == 1d){
				DrawPixel(canvas, x, y, color);
			}
		}
	}


	public static void DrawLineBresenhamsAlgorithm(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, RGBA color){
		double x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t;

		dx = x2 - x1;
		dy = y2 - y1;

		incX = Sign(dx);
		incY = Sign(dy);

		dx = Abs(dx);
		dy = Abs(dy);

		if(dx > dy){
			pdx = incX;
			pdy = 0d;
			es = dy;
			el = dx;
		}else{
			pdx = 0d;
			pdy = incY;
			es = dx;
			el = dy;
		}

		x = x1;
		y = y1;
		err = el/2d;
		DrawPixel(canvas, x, y, color);

		for(t = 0d; t < el; t = t + 1d){
			err = err - es;
			if(err < 0d){
				err = err + el;
				x = x + incX;
				y = y + incY;
			}else{
				x = x + pdx;
				y = y + pdy;
			}

			DrawPixel(canvas, x, y, color);
		}
	}


	public static void DrawLineBresenhamsAlgorithmThickPatterned(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, double thickness, bool [] pattern, NumberReference offset, RGBA color){
		double x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r;

		dx = x2 - x1;
		dy = y2 - y1;

		incX = Sign(dx);
		incY = Sign(dy);

		dx = Abs(dx);
		dy = Abs(dy);

		if(dx > dy){
			pdx = incX;
			pdy = 0d;
			es = dy;
			el = dx;
		}else{
			pdx = 0d;
			pdy = incY;
			es = dx;
			el = dy;
		}

		x = x1;
		y = y1;
		err = el/2d;

		offset.numberValue = (offset.numberValue + 1d)%(pattern.Length*thickness);

		if(pattern[(int)(Floor(offset.numberValue/thickness))]){
			if(thickness >= 3d){
				r = thickness/2d;
				DrawCircle(canvas, x, y, r, color);
			}else if(Floor(thickness) == 2d){
				DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
			}else if(Floor(thickness) == 1d){
				DrawPixel(canvas, x, y, color);
			}
		}

		for(t = 0d; t < el; t = t + 1d){
			err = err - es;
			if(err < 0d){
				err = err + el;
				x = x + incX;
				y = y + incY;
			}else{
				x = x + pdx;
				y = y + pdy;
			}

			offset.numberValue = (offset.numberValue + 1d)%(pattern.Length*thickness);

			if(pattern[(int)(Floor(offset.numberValue/thickness))]){
				if(thickness >= 3d){
					r = thickness/2d;
					DrawCircle(canvas, x, y, r, color);
				}else if(Floor(thickness) == 2d){
					DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
				}else if(Floor(thickness) == 1d){
					DrawPixel(canvas, x, y, color);
				}
			}
		}
	}


	public static bool [] GetLinePattern5(){
		bool [] pattern;

		pattern = new bool [19];

		pattern[0] = true;
		pattern[1] = true;
		pattern[2] = true;
		pattern[3] = true;
		pattern[4] = true;
		pattern[5] = true;
		pattern[6] = true;
		pattern[7] = true;
		pattern[8] = true;
		pattern[9] = true;
		pattern[10] = false;
		pattern[11] = false;
		pattern[12] = false;
		pattern[13] = true;
		pattern[14] = true;
		pattern[15] = true;
		pattern[16] = false;
		pattern[17] = false;
		pattern[18] = false;

		return pattern;
	}


	public static bool [] GetLinePattern4(){
		bool [] pattern;

		pattern = new bool [13];

		pattern[0] = true;
		pattern[1] = true;
		pattern[2] = true;
		pattern[3] = true;
		pattern[4] = true;
		pattern[5] = true;
		pattern[6] = true;
		pattern[7] = true;
		pattern[8] = true;
		pattern[9] = true;
		pattern[10] = false;
		pattern[11] = false;
		pattern[12] = false;

		return pattern;
	}


	public static bool [] GetLinePattern3(){
		bool [] pattern;

		pattern = new bool [13];

		pattern[0] = true;
		pattern[1] = true;
		pattern[2] = true;
		pattern[3] = true;
		pattern[4] = true;
		pattern[5] = true;
		pattern[6] = false;
		pattern[7] = false;
		pattern[8] = false;
		pattern[9] = true;
		pattern[10] = true;
		pattern[11] = false;
		pattern[12] = false;

		return pattern;
	}


	public static bool [] GetLinePattern2(){
		bool [] pattern;

		pattern = new bool [4];

		pattern[0] = true;
		pattern[1] = true;
		pattern[2] = false;
		pattern[3] = false;

		return pattern;
	}


	public static bool [] GetLinePattern1(){
		bool [] pattern;

		pattern = new bool [8];

		pattern[0] = true;
		pattern[1] = true;
		pattern[2] = true;
		pattern[3] = true;
		pattern[4] = true;
		pattern[5] = false;
		pattern[6] = false;
		pattern[7] = false;

		return pattern;
	}


	public static RGBABitmapImage Blur(RGBABitmapImage src, double pixels){
		RGBABitmapImage dst;
		double x, y, w, h;

		w = ImageWidth(src);
		h = ImageHeight(src);
		dst = CreateImage(w, h, GetTransparent());

		for(x = 0d; x < w; x = x + 1d){
			for(y = 0d; y < h; y = y + 1d){
				SetPixel(dst, x, y, CreateBlurForPoint(src, x, y, pixels));
			}
		}

		return dst;
	}


	public static RGBA CreateBlurForPoint(RGBABitmapImage src, double x, double y, double pixels){
		RGBA rgba;
		double i, j, countColor, countTransparent;
		double fromx, tox, fromy, toy;
		double w, h;
		double alpha;

		w = ImageWidth(src);
		h = ImageHeight(src);

		rgba = new RGBA();
		rgba.r = 0d;
		rgba.g = 0d;
		rgba.b = 0d;
		rgba.a = 0d;

		fromx = x - pixels;
		fromx = Max(fromx, 0d);

		tox = x + pixels;
		tox = Min(tox, w - 1d);

		fromy = y - pixels;
		fromy = Max(fromy, 0d);

		toy = y + pixels;
		toy = Min(toy, h - 1d);

		countColor = 0d;
		countTransparent = 0d;
		for(i = fromx; i < tox; i = i + 1d){
			for(j = fromy; j < toy; j = j + 1d){
				alpha = src.x[(int)(i)].y[(int)(j)].a;
				if(alpha > 0d){
					rgba.r = rgba.r + src.x[(int)(i)].y[(int)(j)].r;
					rgba.g = rgba.g + src.x[(int)(i)].y[(int)(j)].g;
					rgba.b = rgba.b + src.x[(int)(i)].y[(int)(j)].b;
					countColor = countColor + 1d;
				}
				rgba.a = rgba.a + alpha;
				countTransparent = countTransparent + 1d;
			}
		}

		if(countColor > 0d){
			rgba.r = rgba.r/countColor;
			rgba.g = rgba.g/countColor;
			rgba.b = rgba.b/countColor;
		}else{
			rgba.r = 0d;
			rgba.g = 0d;
			rgba.b = 0d;
		}

		if(countTransparent > 0d){
			rgba.a = rgba.a/countTransparent;
		}else{
			rgba.a = 0d;
		}

		return rgba;
	}


	public static RGBABitmapImage ScaleNearestNeighborFloorFactor(RGBABitmapImage src, double factor){
		RGBABitmapImage dst;
		double w, h, newWidth, newHeight;

		w = ImageWidth(src);
		h = ImageHeight(src);

		newWidth = Roundx(w*factor);
		newHeight = Roundx(h*factor);

		dst = ScaleNearestNeighborFloor(src, newWidth, newHeight);

		return dst;
	}


	public static RGBABitmapImage ScaleNearestNeighborFloor(RGBABitmapImage src, double newWidth, double newHeight){
		RGBABitmapImage dst;
		double x, y;

		dst = CreateImage(newWidth, newHeight, GetTransparent());

		for(x = 0d; x < newWidth; x = x + 1d){
			for(y = 0d; y < newHeight; y = y + 1d){
				SetPixel(dst, x, y, GetNearestNeighborFloor(src, dst, x, y));
			}
		}

		return dst;
	}


	public static RGBA GetNearestNeighborFloor(RGBABitmapImage src, RGBABitmapImage dst, double x, double y){
		double nnx, nny, srcw, srch, dstw, dsth;

		srcw = ImageWidth(src);
		srch = ImageHeight(src);
		dstw = ImageWidth(dst);
		dsth = ImageHeight(dst);

		nnx = Floor(x*srcw/dstw);
		nny = Floor(y*srch/dsth);

		return src.x[(int)(nnx)].y[(int)(nny)];
	}


	public static RGBABitmapImage ScaleNearestNeighborFactor(RGBABitmapImage src, double factor){
		RGBABitmapImage dst;
		double w, h, newWidth, newHeight;

		w = ImageWidth(src);
		h = ImageHeight(src);

		newWidth = Roundx(w*factor);
		newHeight = Roundx(h*factor);

		dst = ScaleNearestNeighbor(src, newWidth, newHeight);

		return dst;
	}


	public static RGBABitmapImage ScaleNearestNeighbor(RGBABitmapImage src, double newWidth, double newHeight){
		RGBABitmapImage dst;
		double x, y;

		dst = CreateImage(newWidth, newHeight, GetTransparent());

		for(x = 0d; x < newWidth; x = x + 1d){
			for(y = 0d; y < newHeight; y = y + 1d){
				SetPixel(dst, x, y, GetNearestNeighbor(src, dst, x, y));
			}
		}

		return dst;
	}


	public static RGBA GetNearestNeighbor(RGBABitmapImage src, RGBABitmapImage dst, double x, double y){
		double nnx, nny, srcw, srch, dstw, dsth;

		srcw = ImageWidth(src);
		srch = ImageHeight(src);
		dstw = ImageWidth(dst);
		dsth = ImageHeight(dst);

		nnx = Min(Roundx(x*srcw/dstw), srcw - 1d);
		nny = Min(Roundx(y*srch/dsth), srch - 1d);

		return src.x[(int)(nnx)].y[(int)(nny)];
	}


	public static RGBABitmapImage BilinaerScaleUpFactor(RGBABitmapImage src, double factor){
		RGBABitmapImage dst;
		double w, h, newWidth, newHeight;

		w = ImageWidth(src);
		h = ImageHeight(src);

		newWidth = Roundx(w*factor);
		newHeight = Roundx(h*factor);

		dst = BilinaerScaleUp(src, newWidth, newHeight);

		return dst;
	}


	public static RGBABitmapImage BilinaerScaleUp(RGBABitmapImage src, double newWidth, double newHeight){
		RGBABitmapImage dst;
		double x, y;

		dst = CreateImage(newWidth, newHeight, GetTransparent());

		for(y = 0d; y < newHeight; y = y + 1d){
			for(x = 0d; x < newWidth; x = x + 1d){
				SetPixel(dst, x, y, GetBilinearlyScaledPixel(src, dst, x, y));
			}
		}

		return dst;
	}


	public static RGBA GetBilinearlyScaledPixel(RGBABitmapImage src, RGBABitmapImage dst, double dstx, double dsty){
		double x1, y1, x2, y2, srcw, srch, dstw, dsth;
		RGBA x1y1, x2y1, x1y2, x2y2;
		RGBA result;
		double x, y;

		srcw = ImageWidth(src);
		srch = ImageHeight(src);
		dstw = ImageWidth(dst);
		dsth = ImageHeight(dst);

		x = dstx*srcw/dstw;
		y = dsty*srch/dsth;

		x = x + 0.25;
		y = y + 0.25;

		x1 = Min(Floor(x), srcw - 1d);
		x2 = Min(Ceiling(x), srcw - 1d);
		y1 = Min(Floor(y), srch - 1d);
		y2 = Min(Ceiling(y), srch - 1d);

		x1y1 = src.x[(int)(x1)].y[(int)(y1)];
		x1y2 = src.x[(int)(x1)].y[(int)(y2)];
		x2y1 = src.x[(int)(x2)].y[(int)(y1)];
		x2y2 = src.x[(int)(x2)].y[(int)(y2)];

		if(x1 == x2){
			x2 = x2 + 1d;
		}
		if(y1 == y2){
			y2 = y2 + 1d;
		}

		result = new RGBA();

		result.r = GetBilinearInterpolation(x1y1.r, x2y1.r, x1y2.r, x2y2.r, x, y, x1, x2, y1, y2);
		result.g = GetBilinearInterpolation(x1y1.g, x2y1.g, x1y2.g, x2y2.g, x, y, x1, x2, y1, y2);
		result.b = GetBilinearInterpolation(x1y1.b, x2y1.b, x1y2.b, x2y2.b, x, y, x1, x2, y1, y2);
		result.a = GetBilinearInterpolation(x1y1.a, x2y1.a, x1y2.a, x2y2.a, x, y, x1, x2, y1, y2);

		return result;
	}


	public static double GetBilinearInterpolation(double q11, double q12, double q21, double q22, double x, double y, double x1, double x2, double y1, double y2){
		double h1, h2, v;

		h1 = (x2 - x)/(x2 - x1)*q11 + (x - x1)/(x2 - x1)*q12;
		h2 = (x2 - x)/(x2 - x1)*q21 + (x - x1)/(x2 - x1)*q22;

		v = (y2 - y)/(y2 - y1)*h1 + (y - y1)/(y2 - y1)*h2;

		return v;
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


	public static char [] DigitDataBase16(){
		return "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe891412108153069c4ffffffffffffffffffffffffffffffffffffffff9409000000000000000049e7ffffffffffffffffffffffffffffffffff61000000000000000000000017ddffffffffffffffffffffffffffffff840000000573d3f5e5a62b00000028f0ffffffffffffffffffffffffffda04000008bcfffffffffff44200000073ffffffffffffffffffffffffff5700000088ffffffffffffffe812000008e3ffffffffffffffffffffffea02000015f9ffffffffffffffff8100000080ffffffffffffffffffffff9c00000072ffffffffffffffffffe40100002fffffffffffffffffffffff51000000b8ffffffffffffffffffff2a000000e2ffffffffffffffffffff21000001f0ffffffffffffffffffff65000000b3fffffffffffffffffff602000018ffffffffffffffffffffff8b0000008affffffffffffffffffd200000036ffffffffffffffffffffffa900000063ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffb500000057ffffffffffffffffffffffc900000046ffffffffffffffffffa90000005fffffffffffffffffffffffd20000003affffffffffffffffffa900000060ffffffffffffffffffffffd30000003affffffffffffffffffb400000057ffffffffffffffffffffffca00000046ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffd100000037ffffffffffffffffffffffa900000063fffffffffffffffffff602000019ffffffffffffffffffffff8b00000089ffffffffffffffffffff21000001f1ffffffffffffffffffff66000000b3ffffffffffffffffffff50000000b8ffffffffffffffffffff2a000000e1ffffffffffffffffffff9c00000073ffffffffffffffffffe40100002fffffffffffffffffffffffea02000015f9ffffffffffffffff8200000080ffffffffffffffffffffffff5700000088ffffffffffffffe812000008e2ffffffffffffffffffffffffda04000008bcfffffffffff44300000073ffffffffffffffffffffffffffff830000000674d3f6e6a72b00000028f0ffffffffffffffffffffffffffffff60000000000000000000000016ddfffffffffffffffffffffffffffffffffe9309000000000000000048e6ffffffffffffffffffffffffffffffffffffffe88f3f1f07132e68c3fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9d7b28e69441f02000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6a274c7095b9de64000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000affffffffffffffffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffd48b56271005142a5ea0f6ffffffffffffffffffffffffffffffffdb7c20000000000000000000001392feffffffffffffffffffffffffffff1f00000000000000000000000000004cf9ffffffffffffffffffffffffff1f0000003784c7e7f9e8b1480000000056ffffffffffffffffffffffffff1f015accffffffffffffffff9701000000b0ffffffffffffffffffffffff58caffffffffffffffffffffff770000003cfffffffffffffffffffffffffffffffffffffffffffffffffff107000002edffffffffffffffffffffffffffffffffffffffffffffffffff3a000000ccffffffffffffffffffffffffffffffffffffffffffffffffff4c000000baffffffffffffffffffffffffffffffffffffffffffffffffff32000000cbffffffffffffffffffffffffffffffffffffffffffffffffec05000002edffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffeb140000009affffffffffffffffffffffffffffffffffffffffffffffff520000002afbffffffffffffffffffffffffffffffffffffffffffffff8c00000003c7ffffffffffffffffffffffffffffffffffffffffffffffb30300000085ffffffffffffffffffffffffffffffffffffffffffffffc50a0000005dfeffffffffffffffffffffffffffffffffffffffffffffd2110000004efbffffffffffffffffffffffffffffffffffffffffffffdb1800000042f8ffffffffffffffffffffffffffffffffffffffffffffe21f00000039f3ffffffffffffffffffffffffffffffffffffffffffffe92600000030efffffffffffffffffffffffffffffffffffffffffffffee2e00000029eafffffffffffffffffffffffffffffffffffffffffffff33700000022e5fffffffffffffffffffffffffffffffffffffffffffff7410000001cdffffffffffffffffffffffffffffffffffffffffffffffb4c00000017d9fffffffffffffffffffffffffffffffffffffffffffffd5900000012d2ffffffffffffffffffffffffffffffffffffffffffffff680000000ecbffffffffffffffffffffffffffffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe2af8058392817060a1a3f74c8ffffffffffffffffffffffffffffffffeb0000000000000000000000000036cfffffffffffffffffffffffffffffeb000000000000000000000000000004a7ffffffffffffffffffffffffffeb00000f5a9dd0edfbf0ca841900000003c2ffffffffffffffffffffffffec3da8f9fffffffffffffffff0410000002bffffffffffffffffffffffffffffffffffffffffffffffffffee12000000cbffffffffffffffffffffffffffffffffffffffffffffffffff6900000090ffffffffffffffffffffffffffffffffffffffffffffffffff9600000078ffffffffffffffffffffffffffffffffffffffffffffffffff9a0000007effffffffffffffffffffffffffffffffffffffffffffffffff73000000a5fffffffffffffffffffffffffffffffffffffffffffffffff51b000009edfffffffffffffffffffffffffffffffffffffffffffffff7540000007efffffffffffffffffffffffffffffffffffffffffff3d3912400000055fcffffffffffffffffffffffffffffffffff1700000000000000001692feffffffffffffffffffffffffffffffffffff17000000000000002db8feffffffffffffffffffffffffffffffffffffff170000000000000000002bc3fffffffffffffffffffffffffffffffffffffffffffdf0cf922e00000003a5fffffffffffffffffffffffffffffffffffffffffffffffffd8700000007d1ffffffffffffffffffffffffffffffffffffffffffffffffff780000004ffffffffffffffffffffffffffffffffffffffffffffffffffff308000006f6ffffffffffffffffffffffffffffffffffffffffffffffffff3c000000d0ffffffffffffffffffffffffffffffffffffffffffffffffff4d000000c6ffffffffffffffffffffffffffffffffffffffffffffffffff35000000ddffffffffffffffffffffffffffffffffffffffffffffffffea0300000bf9ffffffffffffffffffffffffffffffffffffffffffffffff6200000054ffffffffffffffffffffff47bafefffffffffffffffffff56b00000002cbffffffffffffffffffffff0b001e71a9d7edfbf6e4ba771a000000007cffffffffffffffffffffffff0b0000000000000000000000000000017dffffffffffffffffffffffffff0b000000000000000000000000003cc8ffffffffffffffffffffffffffffe9b989593827160608162a5689dbffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffbd0100000000f3fffffffffffffffffffffffffffffffffffffffffffff3200000000000f3ffffffffffffffffffffffffffffffffffffffffffff69000000000000f3ffffffffffffffffffffffffffffffffffffffffffbf01000b0e000000f3fffffffffffffffffffffffffffffffffffffffff42100008e1f000000f3ffffffffffffffffffffffffffffffffffffffff6a000035fc1f000000f3ffffffffffffffffffffffffffffffffffffffc0010004d1ff1f000000f3fffffffffffffffffffffffffffffffffffff42200007affff1f000000f3ffffffffffffffffffffffffffffffffffff6c000026f7ffff1f000000f3ffffffffffffffffffffffffffffffffffc1010001c1ffffff1f000000f3fffffffffffffffffffffffffffffffff523000066ffffffff1f000000f3ffffffffffffffffffffffffffffffff6d000019f0ffffffff1f000000f3ffffffffffffffffffffffffffffffc2010000aeffffffffff1f000000f3fffffffffffffffffffffffffffff524000052ffffffffffff1f000000f3ffffffffffffffffffffffffffff6e00000fe6ffffffffffff1f000000f3ffffffffffffffffffffffffffc30200009affffffffffffff1f000000f3fffffffffffffffffffffffff62400003ffeffffffffffffff1f000000f3ffffffffffffffffffffffff70000008daffffffffffffffff1f000000f3fffffffffffffffffffffff602000086ffffffffffffffffff1f000000f3fffffffffffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f000008672f120514275997efffffffffffffffffffffffffffffffffff4f00000000000000000000000b73f6ffffffffffffffffffffffffffffff4f000000000000000000000000002bdeffffffffffffffffffffffffffff60538cbad2e7faf0d599370000000025ebffffffffffffffffffffffffffffffffffffffffffffffffa0090000005bffffffffffffffffffffffffffffffffffffffffffffffffffb100000001d2ffffffffffffffffffffffffffffffffffffffffffffffffff560000007effffffffffffffffffffffffffffffffffffffffffffffffffb80000003dffffffffffffffffffffffffffffffffffffffffffffffffffec00000022fffffffffffffffffffffffffffffffffffffffffffffffffffd00000011ffffffffffffffffffffffffffffffffffffffffffffffffffec00000022ffffffffffffffffffffffffffffffffffffffffffffffffffb80000003cffffffffffffffffffffffffffffffffffffffffffffffffff580000007dffffffffffffffffffffffffffffffffffffffffffffffffb301000000cfffffffffffffffffffffff4cb1fdffffffffffffffffffa40a00000058ffffffffffffffffffffffff17001a6ea9d7eefbf2d69b380000000024e8ffffffffffffffffffffffff1700000000000000000000000000002de0ffffffffffffffffffffffffff17000000000000000000000000127ef9ffffffffffffffffffffffffffffebba8a59372615050a1a3569a6f7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffca753915050d233866a3e0ffffffffffffffffffffffffffffffffffd13f0000000000000000000000f7ffffffffffffffffffffffffffffff9d07000000000000000000000000f7ffffffffffffffffffffffffffff9700000000469fdbf3f5da9e490100f7ffffffffffffffffffffffffffca0300000eb3ffffffffffffffffd84df8fffffffffffffffffffffffffa2d000007c8ffffffffffffffffffffffffffffffffffffffffffffffff9100000081ffffffffffffffffffffffffffffffffffffffffffffffffff28000010f6ffffffffffffffffffffffffffffffffffffffffffffffffc20000006affffffffffffffffffffffffffffffffffffffffffffffffff79000000b2ffffffffffffffffffffffffffffffffffffffffffffffffff43000000ebffeb903d1a0616306fc0ffffffffffffffffffffffffffffff0f000015ffa211000000000000000041dcfffffffffffffffffffffffff30000003087000000000000000000000013c6ffffffffffffffffffffffe30000000f00000055beeef7d8881000000017e6ffffffffffffffffffffd30000000000019dffffffffffffe12200000056ffffffffffffffffffffd100000000006effffffffffffffffce04000002dbffffffffffffffffffdd0000000006eaffffffffffffffffff550000008bffffffffffffffffffe90000000043ffffffffffffffffffffa90000004dfffffffffffffffffff80200000074ffffffffffffffffffffdb0000002cffffffffffffffffffff2200000088ffffffffffffffffffffef00000019ffffffffffffffffffff4d00000088ffffffffffffffffffffee0000001affffffffffffffffffff7e00000074ffffffffffffffffffffdb0000002dffffffffffffffffffffcd00000042ffffffffffffffffffffa900000052ffffffffffffffffffffff21000005e9ffffffffffffffffff5400000093ffffffffffffffffffffff8f0000006dffffffffffffffffcd04000007e6fffffffffffffffffffffff9220000019effffffffffffe1230000006cffffffffffffffffffffffffffc00600000056beeff8d888110000002af3ffffffffffffffffffffffffffffa603000000000000000000000026ddffffffffffffffffffffffffffffffffc8280000000000000000025deffffffffffffffffffffffffffffffffffffffab25a2a1106193b7ed7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff47000000000000000000000000000000000000f7ffffffffffffffffffff47000000000000000000000000000000000003faffffffffffffffffffff4700000000000000000000000000000000004afffffffffffffffffffffffffffffffffffffffffffffffffc1a000000adffffffffffffffffffffffffffffffffffffffffffffffffb300000015faffffffffffffffffffffffffffffffffffffffffffffffff5100000073ffffffffffffffffffffffffffffffffffffffffffffffffea05000000d6ffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffff2c0000009dffffffffffffffffffffffffffffffffffffffffffffffffc90000000cf3ffffffffffffffffffffffffffffffffffffffffffffffff6700000063fffffffffffffffffffffffffffffffffffffffffffffffff60f000000c6ffffffffffffffffffffffffffffffffffffffffffffffffa300000029ffffffffffffffffffffffffffffffffffffffffffffffffff410000008cffffffffffffffffffffffffffffffffffffffffffffffffdf01000005e9ffffffffffffffffffffffffffffffffffffffffffffffff7d00000052fffffffffffffffffffffffffffffffffffffffffffffffffd1e000000b5ffffffffffffffffffffffffffffffffffffffffffffffffb90000001bfcffffffffffffffffffffffffffffffffffffffffffffffff570000007bffffffffffffffffffffffffffffffffffffffffffffffffee07000001ddffffffffffffffffffffffffffffffffffffffffffffffff9300000042ffffffffffffffffffffffffffffffffffffffffffffffffff31000000a5ffffffffffffffffffffffffffffffffffffffffffffffffd000000010f7ffffffffffffffffffffffffffffffffffffffffffffffff6d0000006bfffffffffffffffffffffffffffffffffffffffffffffffff913000000ceffffffffffffffffffffffffffffffffffffffffffffffffa900000031ffffffffffffffffffffffffffffffffffffffffffffffffff4700000094ffffffffffffffffffffffffffffffffffffffffffffffffe302000008eeffffffffffffffffffffffffffffffffffffffffffffffff840000005afffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9a8602c13050c1d4882dfffffffffffffffffffffffffffffffffffffa918000000000000000000025eeeffffffffffffffffffffffffffffff780000000000000000000000000023e5ffffffffffffffffffffffffff9f0000000037a8e4faf1c66d0500000033fdfffffffffffffffffffffff81600000065fdffffffffffffc40a0000009fffffffffffffffffffffffb600000021faffffffffffffffff8d00000047ffffffffffffffffffffff820000007bffffffffffffffffffeb01000014ffffffffffffffffffffff6d000000a2ffffffffffffffffffff15000001fdffffffffffffffffffff76000000a2ffffffffffffffffffff14000007ffffffffffffffffffffffa10000007bffffffffffffffffffec01000033ffffffffffffffffffffffec08000022fbffffffffffffffff8e00000087ffffffffffffffffffffffff7d00000068fdffffffffffffc70b00001ef2fffffffffffffffffffffffffb5500000039aae5fbf2c87006000013d0fffffffffffffffffffffffffffffe93160000000000000000000153e3ffffffffffffffffffffffffffffffffffbd2e000000000000000780f0ffffffffffffffffffffffffffffffffce3500000000000000000000000e87fcffffffffffffffffffffffffffb3060000004fb2e6faf0cd82150000004ffaffffffffffffffffffffffda0b000004a9ffffffffffffffe93600000076ffffffffffffffffffffff5600000084ffffffffffffffffffe80e000005e2fffffffffffffffffff606000008f4ffffffffffffffffffff6f0000008dffffffffffffffffffcb00000039ffffffffffffffffffffffac0000005cffffffffffffffffffbc0000004affffffffffffffffffffffbe0000004dffffffffffffffffffcc00000039ffffffffffffffffffffffac0000005effffffffffffffffffea00000008f4ffffffffffffffffffff6e0000007cffffffffffffffffffff2f00000085ffffffffffffffffffe70d000000c1ffffffffffffffffffff9300000004a9ffffffffffffffe83400000028fcfffffffffffffffffffffa2d0000000050b2e7fbf2cd821400000002b8ffffffffffffffffffffffffe523000000000000000000000000000299fffffffffffffffffffffffffffff16605000000000000000000002cc5ffffffffffffffffffffffffffffffffffe88e542512040b1b3d72c1fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff8a259251008203f8be2ffffffffffffffffffffffffffffffffffffffa91d0000000000000000047ffaffffffffffffffffffffffffffffffff7b00000000000000000000000040f8ffffffffffffffffffffffffffff94000000004db9ecf7da8b1300000057ffffffffffffffffffffffffffdc050000008fffffffffffffe527000000acffffffffffffffffffffffff630000005fffffffffffffffffd406000025fbfffffffffffffffffffffb0c000002e0ffffffffffffffffff5f000000b2ffffffffffffffffffffc600000036ffffffffffffffffffffb50000005fffffffffffffffffffffa000000068ffffffffffffffffffffe700000011feffffffffffffffffff8d0000007cfffffffffffffffffffffb00000000dfffffffffffffffffff8c0000007cfffffffffffffffffffffb00000000b4ffffffffffffffffff9e00000069ffffffffffffffffffffe7000000008dffffffffffffffffffbe00000038ffffffffffffffffffffb6000000007bfffffffffffffffffff606000003e2ffffffffffffffffff62000000006fffffffffffffffffffff4f00000064ffffffffffffffffd8080000000062ffffffffffffffffffffc50000000096ffffffffffffe82b000000000064ffffffffffffffffffffff6c0000000051bbeff8dc8e1500001000000074fffffffffffffffffffffff94f0000000000000000000000288c00000084fffffffffffffffffffffffffd810b000000000000000052ea830000009fffffffffffffffffffffffffffffea8d471d090d2864c1ffff5b000000d4ffffffffffffffffffffffffffffffffffffffffffffffffff2100000dfdffffffffffffffffffffffffffffffffffffffffffffffffd900000052ffffffffffffffffffffffffffffffffffffffffffffffffff75000000b8ffffffffffffffffffffffffffffffffffffffffffffffffe30d000023fefffffffffffffffffffffffffffffffffffffffffffffff945000000b7ffffffffffffffffffffffffff7fa2fdffffffffffffffe8480000005effffffffffffffffffffffffffff63002080c4ecfae7c0740e00000034f4ffffffffffffffffffffffffffff6300000000000000000000000043f0ffffffffffffffffffffffffffffff6300000000000000000000118efdfffffffffffffffffffffffffffffffff4bb7f462b15040b25569ff4ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff".ToCharArray();
	}


	public static void DrawDigitCharacter(RGBABitmapImage image, double topx, double topy, double digit){
		double x, y;
		char [] allCharData, colorChars;
		NumberReference colorReference;
		StringReference errorMessage;
		RGBA color;

		colorReference = new NumberReference();
		errorMessage = new StringReference();
		color = new RGBA();

		colorChars = new char [2];

		allCharData = DigitDataBase16();

		for(y = 0d; y < 37d; y = y + 1d){
			for(x = 0d; x < 30d; x = x + 1d){
				colorChars[0] = allCharData[(int)(digit*30d*37d*2d + y*2d*30d + x*2d + 0d)];
				colorChars[1] = allCharData[(int)(digit*30d*37d*2d + y*2d*30d + x*2d + 1d)];

				strToUpperCase(colorChars);
				CreateNumberFromStringWithCheck(colorChars, 16d, colorReference, errorMessage);
				color.r = colorReference.numberValue/255d;
				color.g = colorReference.numberValue/255d;
				color.b = colorReference.numberValue/255d;
				color.a = 1d;
				SetPixel(image, topx + x, topy + y, color);
			}
		}
	}


	public static char [] GetPixelFontData(){
		return "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001100000011000000000000000000000011000000110000001100000011000000110000001100000011000000000000000000000000000000000000000000000000000000000000000000000000000011011000110110001101100011011000000000000000000000000000110011001100110111111110110011001100110111111110110011001100110000000000000000000000000000000000001100001111110111111111101100011111000011111100001111100011011111111110111111000011000000000000000000001110000110110001101101101110110000011000001100000110000011011101101101100011011000011100000000000000000111111100110001111110011000110110000111000001110000110110011001100110011001101100001110000000000000000000000000000000000000000000000000000000000000000000000000000011000001110000011000001110000000000000000000000110000000110000000110000001100000011000000110000001100000011000000110000011000001100000000000000000000000011000001100000110000001100000011000000110000001100000011000000110000000110000000110000000000000000000000000000000000100110010101101000111100111111110011110001011010100110010000000000000000000000000000000000000000000110000001100000011000111111111111111100011000000110000001100000000000000000000000000000000000000011000001100000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011111111111111110000000000000000000000000000000000000000000000000000000000000000000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000110000001100000110000001100000110000001100000110000001100000110000001100000110000001100000000000000000000000011110001100110110000111100011111001111110110111111001111100011110000110110011000111100000000000000000001111110000110000001100000011000000110000001100000011000000110000001111000011100000110000000000000000000111111110000001100000011000001100000110000011000001100000110000011000000111001110111111000000000000000000111111011100111110000001100000011100000011111101110000011000000110000001110011101111110000000000000000000110000001100000011000000110000001100001111111100110011001101100011110000111000001100000000000000000000011111101110011111000000110000001110000001111111000000110000001100000011000000111111111100000000000000000111111011100111110000111100001111100011011111110000001100000011000000111110011101111110000000000000000000001100000011000000110000001100000110000011000001100000110000001100000011000000111111110000000000000000011111101110011111000011110000111110011101111110111001111100001111000011111001110111111000000000000000000111111011100111110000001100000011000000111111101110011111000011110000111110011101111110000000000000000000000000000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000000000000011000001100000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000110000000110000000110000000110000000110000000110000011000001100000110000011000001100000000000000000000000000000000000001111111111111111000000001111111111111111000000000000000000000000000000000000000000000000000001100000110000011000001100000110000011000000011000000011000000011000000011000000011000000000000000000001100000000000000000000001100000011000001100000110000011000000110000111100001101111110000000000000000011111100000001101111001111011011110010111011101111000011011111100000000000000000000000000000000000000000110000111100001111000011110000111111111111000011110000111100001101100110001111000001100000000000000000000111111111100011110000111100001111100011011111111110001111000011110000111110001101111111000000000000000001111110111001110000001100000011000000110000001100000011000000110000001111100111011111100000000000000000001111110111001111100011110000111100001111000011110000111100001111100011011100110011111100000000000000001111111100000011000000110000001100000011001111110000001100000011000000110000001111111111000000000000000000000011000000110000001100000011000000110000001100111111000000110000001100000011111111110000000000000000011111101110011111000011110000111111001100000011000000110000001100000011111001110111111000000000000000001100001111000011110000111100001111000011111111111100001111000011110000111100001111000011000000000000000001111110000110000001100000011000000110000001100000011000000110000001100000011000011111100000000000000000001111100111011101100011011000000110000001100000011000000110000001100000011000000110000000000000000000001100001101100011001100110001101100001111000001110000111100011011001100110110001111000011000000000000000011111111000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000110000111100001111000011110000111100001111000011110110111111111111111111111001111100001100000000000000001110001111100011111100111111001111111011110110111101111111001111110011111100011111000111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111100111011111100000000000000000000000110000001100000011000000110000001101111111111000111100001111000011111000110111111100000000000000001111110001110110111110111101101111000011110000111100001111000011110000110110011000111100000000000000000011000011011000110011001100011011000011110111111111100011110000111100001111100011011111110000000000000000011111101110011111000000110000001110000001111110000001110000001100000011111001110111111000000000000000000001100000011000000110000001100000011000000110000001100000011000000110000001100011111111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111000011110000110000000000000000000110000011110000111100011001100110011011000011110000111100001111000011110000111100001100000000000000001100001111100111111111111111111111011011110110111100001111000011110000111100001111000011000000000000000011000011011001100110011000111100001111000001100000111100001111000110011001100110110000110000000000000000000110000001100000011000000110000001100000011000001111000011110001100110011001101100001100000000000000001111111100000011000000110000011000001100011111100011000001100000110000001100000011111111000000000000000000111100000011000000110000001100000011000000110000001100000011000000110000001100001111000000000011000000110000000110000001100000001100000011000000011000000110000000110000001100000001100000011000000000000000000011110000110000001100000011000000110000001100000011000000110000001100000011000000111100000000000000000000000000000000000000000000000000000000000000000000000000110000110110011000111100000110001111111111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000111000000110000001110000000000000000011111110110000111100001111111110110000001100001101111110000000000000000000000000000000000000000000000000011111111100001111000011110000111100001101111111000000110000001100000011000000110000001100000000000000000111111011000011000000110000001100000011110000110111111000000000000000000000000000000000000000000000000011111110110000111100001111000011110000111111111011000000110000001100000011000000110000000000000000000000111111100000001100000011011111111100001111000011011111100000000000000000000000000000000000000000000000000000110000001100000011000000110000001100001111110000110000001100000011001100110001111000011111101100001111000000110000001111111011000011110000111100001101111110000000000000000000000000000000000000000000000000110000111100001111000011110000111100001111000011011111110000001100000011000000110000001100000000000000000001100000011000000110000001100000011000000110000001100000000000000000000001100000000000000111000011011000110000001100000011000000110000001100000011000000110000000000000000000000110000000000000000000000000000011000110011001100011111000011110001101100110011011000110000001100000011000000110000001100000000000000000111111000011000000110000001100000011000000110000001100000011000000110000001100000011110000000000000000011011011110110111101101111011011110110111101101101111111000000000000000000000000000000000000000000000000011000110110001101100011011000110110001101100011001111110000000000000000000000000000000000000000000000000011111001100011011000110110001101100011011000110011111000000000000000000000000000000000000000110000001100000011011111111100001111000011110000111100001101111111000000000000000000000000000000001100000011000000110000001111111011000011110000111100001111000011111111100000000000000000000000000000000000000000000000000000001100000011000000110000001100000011000001110111111100000000000000000000000000000000000000000000000001111111110000001100000001111110000000110000001111111110000000000000000000000000000000000000000000000000001110000110110000001100000011000000110000001100001111110000110000001100000011000000000000000000000000000111111001100011011000110110001101100011011000110110001100000000000000000000000000000000000000000000000000011000001111000011110001100110011001101100001111000011000000000000000000000000000000000000000000000000110000111110011111111111110110111100001111000011110000110000000000000000000000000000000000000000000000001100001101100110001111000001100000111100011001101100001100000000000000000000000000000000000000110000011000000110000011000001100000111100011001100110011011000011000000000000000000000000000000000000000000000000111111110000011000001100000110000011000001100000111111110000000000000000000000000000000000000000000000001111000000011000000110000001100000011100000011110001110000011000000110000001100011110000000110000001100000011000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000000000011110001100000011000000110000011100011110000001110000001100000011000000110000000111100000000000000000000000000000000000000000000000000000000000000000000000000000000001110110110111000000000".ToCharArray();
	}


	public static void DrawAsciiCharacter(RGBABitmapImage image, double topx, double topy, char a, RGBA color){
		double index, x, y, pixel, basis, ybasis;
		char [] allCharData;

		index = a;
		index = index - 32d;
		allCharData = GetPixelFontData();

		basis = index*8d*13d;

		for(y = 0d; y < 13d; y = y + 1d){
			ybasis = basis + y*8d;
			for(x = 0d; x < 8d; x = x + 1d){
				pixel = allCharData[(int)(ybasis + x)];
				if(pixel == '1'){
					DrawPixel(image, topx + 8d - 1d - x, topy + 13d - 1d - y, color);
				}
			}
		}
	}


	public static double GetTextWidth(char [] text){
		double charWidth, spacing, width;

		charWidth = 8d;
		spacing = 2d;

		if(text.Length == 0d){
			width = 0d;
		}else{
			width = text.Length*charWidth + (text.Length - 1d)*spacing;
		}

		return width;
	}


	public static double GetTextHeight(char [] text){
		return 13d;
	}


	public static double DPIToDotsPerMm(double dpi){
		return dpi/25.4;
	}


	public static double DotsPerMmDPI(double dotsPerMm){
		return dotsPerMm*25.4;
	}


	public static double MmToInch(double mm){
		return mm/25.4;
	}


	public static double InchToMm(double inch){
		return inch*25.4;
	}


	public static double MmToDots(double mm, double dpi){
		return MmToInch(mm)*dpi;
	}


	public static double DotsToMm(double dots, double dpi){
		return InchToMm(dots/dpi);
	}


	public static double PtsToInch(double pts){
		return pts*1.0/72d;
	}


	public static double InchToPts(double inch){
		return inch*72d;
	}


	public static double PtsToMm(double pts){
		return InchToMm(PtsToInch(pts));
	}


	public static double MmToPts(double mm){
		return InchToPts(MmToInch(mm));
	}


	public static double [] ComputeReedSolomonCodes(double [] data, double eccs){
		double [] rsDiv, ecc;

		rsDiv = ReedSolomonComputeDivisor(eccs);
		ecc = ReedSolomonComputeRemainder(data, rsDiv);

		return ecc;
	}


	public static double [] ReedSolomonComputeDivisor(double eccs){
		double [] result;
		double root, i, j;

		result = arraysCreateNumberArray(eccs, 0d);
		result[(int)(result.Length - 1d)] = 1d;

		root = 1d;
		for(i = 0d; i < eccs; i = i + 1d){
			for(j = 0d; j < result.Length; j = j + 1d){
				result[(int)(j)] = GaloisField2e8Mul(result[(int)(j)], root, 285d);
				if(j + 1d < result.Length){
					result[(int)(j)] = XorByte(result[(int)(j)], result[(int)(j + 1d)]);
				}
			}
			root = GaloisField2e8Mul(root, 2d, 285d);
		}

		return result;
	}


	public static double [] ReedSolomonComputeRemainder(double [] data, double [] divisor){
		double [] result;
		double i, j, b, factor, coef;

		result = arraysCreateNumberArray(divisor.Length, 0d);

		for(i = 0d; i < data.Length; i = i + 1d){
			b = data[(int)(i)];

			factor = XorByte(b, result[0]);

			for(j = 0d; j < result.Length - 1d; j = j + 1d){
				result[(int)(j)] = result[(int)(j + 1d)];
			}
			result[(int)(j)] = 0d;

			for(j = 0d; j < divisor.Length; j = j + 1d){
				coef = divisor[(int)(j)];
				result[(int)(j)] = XorByte(result[(int)(j)], GaloisField2e8Mul(coef, factor, 285d));
			}
		}

		return result;
	}


	public static double ComputeBHC15_5Code(double data){
		double i, gp;

		/* x^10 + x^8 + x^5 + x^4 + x^2 + x + 1 is encoded as 10100110111b = 1335*/
		gp = 1335d;

		for(i = 0d; i < 10d; i = i + 1d){
			data = Xor4Byte(ShiftLeft4Byte(data, 1d), ShiftRight4Byte(data, 9d)*gp);
		}

		return data;
	}


	public static double ComputeBHC18_6Code(double data){
		double i, gp;

		/* x^12 + x^11 + x^10 + x^9 + x^8 + x^5 + x^2 + 1 is encoded as 1111100100101b = 7973*/
		gp = 7973d;

		for(i = 0d; i < 12d; i = i + 1d){
			data = Xor4Byte(ShiftLeft4Byte(data, 1d), ShiftRight4Byte(data, 11d)*gp);
		}

		return data;
	}


	public static double And4Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned4Bytes(a);
		b = ToUnsigned4Bytes(b);

		for(i = 0d; i < 32d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d && bb == 1d){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double ToUnsigned4Bytes(double a){
		if(a < 0d){
			a = 4294967296d - Truncate((-a)%4294967296d);
		}else{
			a = Truncate(a%4294967296d);
		}
		return a;
	}


	public static double ToUnsigned2Bytes(double a){
		if(a < 0d){
			a = 65536d - Truncate((-a)%65536d);
		}else{
			a = Truncate(a%65536d);
		}
		return a;
	}


	public static double ToUnsignedByte(double a){
		if(a < 0d){
			a = 256d - Truncate((-a)%256d);
		}else{
			a = Truncate(a%256d);
		}
		return a;
	}


	public static double And2Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned2Bytes(a);
		b = ToUnsigned2Bytes(b);

		for(i = 0d; i < 16d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d && bb == 1d){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double AndByte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsignedByte(a);
		b = ToUnsignedByte(b);

		for(i = 0d; i < 8d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d && bb == 1d){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double Or4Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned4Bytes(a);
		b = ToUnsigned4Bytes(b);

		for(i = 0d; i < 32d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d || bb == 1d){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double Or2Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned2Bytes(a);
		b = ToUnsigned2Bytes(b);

		for(i = 0d; i < 16d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d || bb == 1d){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double OrByte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsignedByte(a);
		b = ToUnsignedByte(b);

		for(i = 0d; i < 8d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d || bb == 1d){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double Xor4Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned4Bytes(a);
		b = ToUnsigned4Bytes(b);

		for(i = 0d; i < 32d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab != bb){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double Xor2Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned2Bytes(a);
		b = ToUnsigned2Bytes(b);

		for(i = 0d; i < 16d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab != bb){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double XorByte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsignedByte(a);
		b = ToUnsignedByte(b);

		for(i = 0d; i < 8d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab != bb){
				result = result + byteVal;
			}

			a = Floor(a/2d);
			b = Floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}


	public static double Not4Byte(double a){
		double result;

		a = ToUnsigned4Bytes(a);

		result = 4294967296d - a - 1d;

		return result;
	}


	public static double Not2Byte(double a){
		double result;

		a = ToUnsigned2Bytes(a);

		result = 65536d - a - 1d;

		return result;
	}


	public static double NotByte(double a){
		double result;

		a = ToUnsignedByte(a);

		result = 256d - a - 1d;

		return result;
	}


	public static double ShiftLeft4Byte(double a, double n){
		double result;

		a = Truncate(a%4294967296d);
		n = Truncate(Max(n, 0d));

		result = a*Pow(2d, n);

		return result;
	}


	public static double ShiftLeft2Byte(double a, double n){
		double result;

		a = Truncate(a%65536d);
		n = Truncate(Max(n, 0d));

		result = a*Pow(2d, n);

		return result;
	}


	public static double ShiftLeftByte(double a, double n){
		double result;

		a = Truncate(a%256d);
		n = Truncate(Max(n, 0d));

		result = a*Pow(2d, n);

		return result;
	}


	public static double ShiftRight4Byte(double a, double n){
		double result;

		a = Truncate(a%4294967296d);
		n = Truncate(Max(n, 0d));

		result = Truncate(a/Pow(2d, n));

		return result;
	}


	public static double ShiftRight2Byte(double a, double n){
		double result;

		a = Truncate(a%65536d);
		n = Truncate(Max(n, 0d));

		result = Truncate(a/Pow(2d, n));

		return result;
	}


	public static double ShiftRightByte(double a, double n){
		double result;

		a = Truncate(a%256d);
		n = Truncate(Max(n, 0d));

		result = Truncate(a/Pow(2d, n));

		return result;
	}


	public static double RotateLeft4Byte(double a, double n){
		double x;

		a = ToUnsigned4Bytes(a);
		n = Truncate(n);

		/*return (a << n) | (a >> (32 - n));*/
		/* Mask the upper bits first, then rotate.*/
		x = And4Byte(a, Not4Byte(ShiftLeft4Byte(1d, n) - 1d));
		x = Or4Byte(ShiftLeft4Byte(x, n), ShiftRight4Byte(a, (32d - n)));

		return x;
	}


	public static double RotateRight4Byte(double a, double n){
		double x;

		a = ToUnsigned4Bytes(a);
		n = Truncate(n);

		/* return (a >> d) | (a << (32 - n));*/
		/* Mask away the upper bits first, then perform the shift.*/
		x = And4Byte(a, ShiftLeft4Byte(1d, n) - 1d);
		x = Or4Byte(ShiftRight4Byte(a, n), ShiftLeft4Byte(x, 32d - n));

		return x;
	}


	public static bool [] CreateBooleanArrayFromNumber(double w, double size){
		bool [] outx;
		double p, j;

		outx = arraysCreateBooleanArray(size, false);

		j = 0d;
		p = 1d;
		for(; p < w; ){
			p = p*2d;
			j = j + 1d;
		}

		for(; j >= 0d; j = j - 1d){
			if(w >= p){
				w = w - p;
				if(j < size){
					outx[(int)(size - 1d - j)] = true;
				}
			}
			p = p/2d;
		}

		return outx;
	}


	public static double BooleanArrayToNumber(bool [] bits){
		double w, i, p;

		w = 0d;
		p = 1d;
		for(i = 31d; i >= 0d; i = i - 1d){
			if(bits[(int)(i)]){
				w = w + p;
			}
			p = p*2d;
		}

		return w;
	}


	public static bool [] BooleanAnd(bool [] a, bool [] b){
		bool [] outx;
		double i, length;

		length = a.Length;

		outx = new bool [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			outx[(int)(i)] = a[(int)(i)] && b[(int)(i)];
		}
		return outx;
	}


	public static bool [] BooleanXor(bool [] a, bool [] b){
		bool [] outx;
		double i, length;

		length = a.Length;

		outx = new bool [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			if(a[(int)(i)] || b[(int)(i)]){
				if(!(a[(int)(i)] && b[(int)(i)])){
					outx[(int)(i)] = true;
				}
			}
		}
		return outx;
	}


	public static bool [] BooleanNot(bool [] a){
		bool [] outx;
		double i, length;

		length = a.Length;

		outx = new bool [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			outx[(int)(i)] = !a[(int)(i)];
		}
		return outx;
	}


	public static bool [] ShiftBitsRight4Byte(bool [] w, double n){
		bool [] wb;
		bool [] ob;
		double i, it;
		bool f;
		f = false;

		if(n == 0d){
			ob = w;
		}else{
			wb = w;
			ob = new bool [32];

			for(i = 0d; i < 32d; i = i + 1d){
				it = i - n;

				if(it < 0d){
					f = false;
				}else{
					f = wb[(int)(it)];
				}

				ob[(int)(i)] = f;
			}
		}

		return ob;
	}


	public static double ReadNextBit(double [] data, NumberReference nextbit){
		double bytenr, bitnumber, bit, b;

		bytenr = Floor(nextbit.numberValue/8d);
		bitnumber = nextbit.numberValue%8d;

		b = data[(int)(bytenr)];

		bit = Floor(b/Pow(2d, bitnumber))%2d;

		nextbit.numberValue = nextbit.numberValue + 1d;

		return bit;
	}


	public static double BitExtract(double b, double fromInc, double toInc){
		return Floor(b/Pow(2d, fromInc))%Pow(2d, toInc + 1d - fromInc);
	}


	public static double ReadBitRange(double [] data, NumberReference nextbit, double length){
		double startbyte, endbyte;
		double startbit, endbit;
		double number, i;

		number = 0d;

		startbyte = Floor(nextbit.numberValue/8d);
		endbyte = Floor((nextbit.numberValue + length)/8d);

		startbit = nextbit.numberValue%8d;
		endbit = (nextbit.numberValue + length - 1d)%8d;

		if(startbyte == endbyte){
			number = BitExtract(data[(int)(startbyte)], startbit, endbit);
		}

		nextbit.numberValue = nextbit.numberValue + length;

		return number;
	}


	public static void SkipToBoundary(NumberReference nextbit){
		double skip;

		skip = 8d - nextbit.numberValue%8d;
		nextbit.numberValue = nextbit.numberValue + skip;
	}


	public static double ReadNextByteBoundary(double [] data, NumberReference nextbit){
		double bytenr, b;

		bytenr = Floor(nextbit.numberValue/8d);
		b = data[(int)(bytenr)];
		nextbit.numberValue = nextbit.numberValue + 8d;

		return b;
	}


	public static double Read2bytesByteBoundary(double [] data, NumberReference nextbit){
		double r;

		r = 0d;
		r = r + Pow(2d, 8d)*ReadNextByteBoundary(data, nextbit);
		r = r + ReadNextByteBoundary(data, nextbit);

		return r;
	}


	public static void QuickSortStrings(StringArrayReference list){
		QuickSortStringsBounds(list, 0d, list.stringArray.Length - 1d);
	}


	public static void QuickSortStringsBounds(StringArrayReference A, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortStringsPartition(A, lo, hi);
			QuickSortStringsBounds(A, lo, p - 1d);
			QuickSortStringsBounds(A, p + 1d, hi);
		}
	}


	public static double QuickSortStringsPartition(StringArrayReference A, double lo, double hi){
		char [] pivot;
		double i, j;

		pivot = A.stringArray[(int)(hi)].stringx;
		i = lo - 1d;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(strStringIsBefore(A.stringArray[(int)(j)].stringx, pivot)){
				i = i + 1d;
				arraysSwapElementsOfStringArray(A, i, j);
			}
		}
		arraysSwapElementsOfStringArray(A, i + 1d, hi);

		return i + 1d;
	}


	public static double [] QuickSortStringsWithIndexes(StringArrayReference A){
		double [] indexes;
		double i;

		indexes = new double [(int)(A.stringArray.Length)];

		for(i = 0d; i < A.stringArray.Length; i = i + 1d){
			indexes[(int)(i)] = i;
		}

		QuickSortStringsBoundsWithIndexes(A, indexes, 0d, A.stringArray.Length - 1d);

		return indexes;
	}


	public static void QuickSortStringsBoundsWithIndexes(StringArrayReference A, double [] indexes, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortStringsPartitionWithIndexes(A, indexes, lo, hi);
			QuickSortStringsBoundsWithIndexes(A, indexes, lo, p - 1d);
			QuickSortStringsBoundsWithIndexes(A, indexes, p + 1d, hi);
		}
	}


	public static double QuickSortStringsPartitionWithIndexes(StringArrayReference A, double [] indexes, double lo, double hi){
		double i, j;
		char [] pivot;

		pivot = A.stringArray[(int)(hi)].stringx;
		i = lo - 1d;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(strStringIsBefore(A.stringArray[(int)(j)].stringx, pivot)){
				i = i + 1d;
				arraysSwapElementsOfStringArray(A, i, j);
				arraysSwapElementsOfNumberArray(indexes, i, j);
			}
		}
		arraysSwapElementsOfStringArray(A, i + 1d, hi);
		arraysSwapElementsOfNumberArray(indexes, i + 1d, hi);

		return i + 1d;
	}


	public static void QuickSortNumbers(double [] list){
		QuickSortNumbersBounds(list, 0d, list.Length - 1d);
	}


	public static void QuickSortNumbersBounds(double [] A, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortNumbersPartition(A, lo, hi);
			QuickSortNumbersBounds(A, lo, p - 1d);
			QuickSortNumbersBounds(A, p + 1d, hi);
		}
	}


	public static double QuickSortNumbersPartition(double [] A, double lo, double hi){
		double pivot, lowPos, j;

		pivot = A[(int)(hi)];
		lowPos = lo;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(A[(int)(j)] < pivot){
				arraysSwapElementsOfNumberArray(A, lowPos, j);
				lowPos = lowPos + 1d;
			}
		}
		arraysSwapElementsOfNumberArray(A, lowPos, hi);

		return lowPos;
	}


	public static double [] QuickSortNumbersWithIndexes(double [] A){
		double [] indexes;
		double i;

		indexes = new double [(int)(A.Length)];

		for(i = 0d; i < A.Length; i = i + 1d){
			indexes[(int)(i)] = i;
		}

		QuickSortNumbersBoundsWithIndexes(A, indexes, 0d, A.Length - 1d);

		return indexes;
	}


	public static void QuickSortNumbersBoundsWithIndexes(double [] A, double [] indexes, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortNumbersPartitionWithIndexes(A, indexes, lo, hi);
			QuickSortNumbersBoundsWithIndexes(A, indexes, lo, p - 1d);
			QuickSortNumbersBoundsWithIndexes(A, indexes, p + 1d, hi);
		}
	}


	public static double QuickSortNumbersPartitionWithIndexes(double [] A, double [] indexes, double lo, double hi){
		double pivot, i, j;

		pivot = A[(int)(hi)];
		i = lo - 1d;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(A[(int)(j)] < pivot){
				i = i + 1d;
				arraysSwapElementsOfNumberArray(A, i, j);
				arraysSwapElementsOfNumberArray(indexes, i, j);
			}
		}
		arraysSwapElementsOfNumberArray(A, i + 1d, hi);
		arraysSwapElementsOfNumberArray(indexes, i + 1d, hi);

		return i + 1d;
	}


	public static void Add(Matrix a, Matrix b){
		double m, n;
		double r, c;

		r = NumberOfRows(a);
		c = NumberOfColumns(a);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = Element(a, m, n) + Element(b, m, n);
			}
		}
	}


	public static void Assign(Matrix A, Matrix B){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = Element(B, m, n);
			}
		}
	}


	public static void Resize(Matrix A, double r, double c){
		double m, n, ar, ac;
		Matrix C;

		C = CreateMatrix(r, c);

		ar = NumberOfRows(A);
		ac = NumberOfColumns(A);

		for(m = 0d; m < Min(r, ar); m = m + 1d){
			for(n = 0d; n < Min(c, ac); n = n + 1d){
				C.r[(int)(m)].c[(int)(n)] = Element(A, m, n);
			}
		}

		FreeMatrixRows(A.r);
		A.r = C.r;
	}


	public static void Subtract(Matrix a, Matrix b){
		double m, n;
		double r, c;

		r = NumberOfRows(a);
		c = NumberOfColumns(a);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = Element(a, m, n) - Element(b, m, n);
			}
		}
	}


	public static Matrix SubtractToNew(Matrix a, Matrix b){
		Matrix X;

		X = CreateCopyOfMatrix(a);
		Subtract(X, b);

		return X;
	}


	public static void ScalarMultiply(Matrix A, double b){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = b*A.r[(int)(m)].c[(int)(n)];
			}
		}
	}


	public static void ScalarDivide(Matrix A, double b){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = Element(A, m, n)/b;
			}
		}
	}


	public static void ElementWisePower(Matrix A, double p){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = Pow(A.r[(int)(m)].c[(int)(n)], p);
			}
		}
	}


	public static Matrix ScalarMultiplyToNew(Matrix A, double b){
		Matrix matrix;

		matrix = CreateCopyOfMatrix(A);
		ScalarMultiply(matrix, b);

		return matrix;
	}


	public static Matrix MultiplyToNew(Matrix a, Matrix b){
		double rows, cols;
		Matrix x;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(b);
		x = CreateMatrix(rows, cols);
		Multiply(x, a, b);

		return x;
	}


	public static void Multiply(Matrix x, Matrix a, Matrix b){
		double m, n;
		double rows, cols, d;
		double i, s;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(b);
		d = NumberOfColumns(a);

		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				s = 0d;

				for(i = 0d; i < d; i = i + 1d){
					s = s + a.r[(int)(m)].c[(int)(i)]*b.r[(int)(i)].c[(int)(n)];
				}

				x.r[(int)(m)].c[(int)(n)] = s;
			}
		}
	}


	public static Matrix CreateSquareMatrix(double d){
		double m, n;
		Matrix matrix;

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(d)];
		for(m = 0d; m < d; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(d)];
			for(n = 0d; n < d; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = 0d;
			}
		}

		return matrix;
	}


	public static Matrix CreateMatrix(double rows, double cols){
		double m, n;
		Matrix matrix;

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = 0d;
			}
		}

		return matrix;
	}


	public static Matrix CreateIdentityMatrix(double d){
		double m;
		Matrix matrix;

		matrix = CreateSquareMatrix(d);
		Fill(matrix, 0d);

		for(m = 0d; m < d; m = m + 1d){
			matrix.r[(int)(m)].c[(int)(m)] = 1d;
		}

		return matrix;
	}


	public static void Transpose(Matrix a){
		Matrix ap;

		ap = TransposeToNew(a);

		FreeMatrixRows(a.r);
		a.r = ap.r;
	}


	public static void TransposeAssign(Matrix t, Matrix a){
		double m, n;
		double rows, cols;

		cols = NumberOfRows(a);
		rows = NumberOfColumns(a);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				t.r[(int)(n)].c[(int)(m)] = a.r[(int)(m)].c[(int)(n)];
			}
		}
	}


	public static Matrix TransposeToNew(Matrix a){
		double m, n;
		double rows, cols;
		Matrix c;

		cols = NumberOfRows(a);
		rows = NumberOfColumns(a);

		c = CreateMatrix(rows, cols);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				c.r[(int)(n)].c[(int)(m)] = a.r[(int)(m)].c[(int)(n)];
			}
		}

		return c;
	}


	public static void CofactorOfMatrix(Matrix mat, Matrix temp, double p, double q, double n){
		double i, j;
		double row, col;

		i = 0d;
		j = 0d;

		for(row = 0d; row < n; row = row + 1d){
			for(col = 0d; col < n; col = col + 1d){
				if(row != p && col != q){
					temp.r[(int)(i)].c[(int)(j)] = mat.r[(int)(row)].c[(int)(col)];
					j = j + 1d;

					if(j == n - 1d){
						j = 0d;
						i = i + 1d;
					}
				}
			}
		}
	}


	public static double DeterminantOfSubmatrix(Matrix mat, double n){
		double D, f, sign;
		Matrix temp;

		D = 0d;

		if(n == 1d){
			D = mat.r[0].c[0];
		}else{
			temp = CreateSquareMatrix(n);

			sign = 1d;

			for(f = 0d; f < n; f = f + 1d){
				CofactorOfMatrix(mat, temp, 0d, f, n);
				D = D + sign*mat.r[0].c[(int)(f)]*DeterminantOfSubmatrix(temp, n - 1d);
				sign = -sign;
			}

			FreeMatrix(temp);
		}

		return D;
	}


	public static double Determinant(Matrix m){
		double D, n;

		n = NumberOfRows(m);
		D = DeterminantOfSubmatrix(m, n);

		return D;
	}


	public static void Adjoint(Matrix A, Matrix adj){
		double n, sign;
		Matrix cofactors;
		double i, j;

		n = A.r.Length;

		if(n == 1d){
			adj.r[0].c[0] = 1d;
		}else{
			cofactors = CreateSquareMatrix(n);

			for(i = 0d; i < n; i = i + 1d){
				for(j = 0d; j < n; j = j + 1d){
					CofactorOfMatrix(A, cofactors, i, j, n);

					if((i + j)%2d == 0d){
						sign = 1d;
					}else{
						sign = -1d;
					}

					adj.r[(int)(j)].c[(int)(i)] = sign*DeterminantOfSubmatrix(cofactors, n - 1d);
				}
			}

			FreeMatrix(cofactors);
		}
	}


	public static bool Inverse(Matrix A, Matrix inverseResult){
		return InverseUsingLUDecomposition(A, inverseResult);
	}


	public static bool InverseUsingAdjoint(Matrix A, Matrix inverseResult){
		bool success;
		Matrix adj;
		double n, i, j;
		double det;

		if(NumberOfColumns(A) == NumberOfRows(A)){
			n = NumberOfColumns(A);

			det = Determinant(A);
			if(det != 0d){
				adj = CreateSquareMatrix(n);
				Adjoint(A, adj);

				for(i = 0d; i < n; i = i + 1d){
					for(j = 0d; j < n; j = j + 1d){
						inverseResult.r[(int)(i)].c[(int)(j)] = adj.r[(int)(i)].c[(int)(j)]/det;
					}
				}

				success = true;
				FreeMatrix(adj);
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool InverseUsingLUDecomposition(Matrix A, Matrix inverseResult){
		bool success;
		Matrix l, u, li, ui;

		l = CreateCopyOfMatrix(A);
		u = CreateCopyOfMatrix(A);
		li = CreateCopyOfMatrix(A);
		ui = CreateCopyOfMatrix(A);
		inverseResult.r = CreateCopyOfMatrix(A).r;

		success = LUDecomposition(A, l, u);
		if(success){
			success = InvertLowerTriangularMatrix(l, li);
			if(success){
				success = InvertUpperTriangularMatrix(u, ui);
				if(success){
					Multiply(inverseResult, ui, li);
				}
			}
		}

		FreeMatrix(l);
		FreeMatrix(u);
		FreeMatrix(li);
		FreeMatrix(ui);

		return success;
	}


	public static bool LUDecomposition(Matrix A, Matrix L, Matrix U){
		double n, i, j, k, sum;
		bool success;

		n = NumberOfRows(A);

		L.r = CreateSquareMatrix(n).r;
		U.r = CreateSquareMatrix(n).r;

		if(IsSquare(A)){
			success = true;

			for(i = 0d; i < n && success; i = i + 1d){
				for(k = i; k < n; k = k + 1d){
					sum = 0d;
					for(j = 0d; j < i; j = j + 1d){
						sum = sum + (Element(L, i, j)*Element(U, j, k));
					}

					U.r[(int)(i)].c[(int)(k)] = Element(A, i, k) - sum;
				}

				for(k = i; k < n && success; k = k + 1d){
					if(i == k){
						L.r[(int)(i)].c[(int)(i)] = 1d;
					}else{
						sum = 0d;
						for(j = 0d; j < i; j = j + 1d){
							sum = sum + (Element(L, k, j)*Element(U, j, i));
						}

						if(Element(U, i, i) == 0d){
							success = false;
						}else{
							L.r[(int)(k)].c[(int)(i)] = (Element(A, k, i) - sum)/Element(U, i, i);
						}
					}
				}
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool IsSymmetric(Matrix A){
		double N;
		double i, j;
		bool isx, done;

		N = NumberOfRows(A);

		done = false;
		isx = true;
		for(i = 0d; i < N && !done; i = i + 1d){
			for(j = 0d; j < i && !done; j = j + 1d){
				if(A.r[(int)(i)].c[(int)(j)] != A.r[(int)(j)].c[(int)(i)]){
					isx = false;
					done = true;
				}
			}
		}

		return isx;
	}


	public static bool IsSquare(Matrix A){
		bool isx;

		if(NumberOfRows(A) == NumberOfColumns(A)){
			isx = true;
		}else{
			isx = false;
		}

		return isx;
	}


	public static bool Cholesky(Matrix A, Matrix L){
		bool success;
		double N;
		double i, j, k, s;

		Clear(L);

		if(IsSquare(A) && IsSymmetric(A)){
			success = true;

			N = NumberOfRows(A);

			for(i = 0d; i < N && success; i = i + 1d){
				for(j = 0d; j <= i && success; j = j + 1d){
					s = 0d;
					for(k = 0d; k < j; k = k + 1d){
						s = s + L.r[(int)(i)].c[(int)(k)]*L.r[(int)(j)].c[(int)(k)];
					}
					if(i == j){
						L.r[(int)(i)].c[(int)(i)] = Sqrt(A.r[(int)(i)].c[(int)(i)] - s);
					}else{
						L.r[(int)(i)].c[(int)(j)] = 1d/L.r[(int)(j)].c[(int)(j)]*(A.r[(int)(i)].c[(int)(j)] - s);
					}
				}
				if(L.r[(int)(i)].c[(int)(i)] <= 0d){
					success = false;
				}
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	public static void Clear(Matrix a){
		Fill(a, 0d);
	}


	public static void Fill(Matrix a, double value){
		double m, n;

		for(m = 0d; m < NumberOfRows(a); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(a); n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = value;
			}
		}
	}


	public static double Element(Matrix matrix, double m, double n){
		return matrix.r[(int)(m)].c[(int)(n)];
	}


	public static double Trace(Matrix a){
		double m;
		double d, tr;

		tr = 0d;

		d = a.r.Length;
		for(m = 0d; m < d; m = m + 1d){
			tr = tr + a.r[(int)(m)].c[(int)(m)];
		}

		return tr;
	}


	public static Matrix ColumnCombineMatricesToNew(Matrix A, Matrix B){
		Matrix X;
		double m, n;

		X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A) + NumberOfColumns(B));

		for(m = 0d; m < NumberOfRows(A); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(A); n = n + 1d){
				X.r[(int)(m)].c[(int)(n)] = A.r[(int)(m)].c[(int)(n)];
			}
		}

		for(m = 0d; m < NumberOfRows(B); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(B); n = n + 1d){
				X.r[(int)(m)].c[(int)(NumberOfColumns(A) + n)] = B.r[(int)(m)].c[(int)(n)];
			}
		}

		return X;
	}


	public static double NumberOfRows(Matrix A){
		return A.r.Length;
	}


	public static double NumberOfColumns(Matrix A){
		return A.r[0].c.Length;
	}


	public static double [] CharacteristicPolynomial(Matrix A){
		Matrix dummy;
		NumberArrayReference coeffs;
		NumberReference determinant;

		dummy = CreateSquareMatrix(NumberOfRows(A));

		coeffs = new NumberArrayReference();
		determinant = new NumberReference();
		CharacteristicPolynomialWithInverse(A, dummy, coeffs, determinant);

		FreeMatrix(dummy);

		return coeffs.numberArray;
	}


	public static void CharacteristicPolynomialWithInverse(Matrix A, Matrix AInverse, NumberArrayReference cp, NumberReference determinant){
		FaddeevLeVerrierAlgorithm(A, AInverse, cp, determinant);
	}


	public static void FaddeevLeVerrierAlgorithm(Matrix A, Matrix AInverse, NumberArrayReference cp, NumberReference determinant){
		double [] p;
		Matrix Mk, Mkm1, t1, I;
		double n, k;

		n = NumberOfRows(A);
		p = new double [(int)(n + 1d)];
		p[(int)(n)] = 1d;
		Mkm1 = CreateSquareMatrix(n);
		Fill(Mkm1, 0d);
		I = CreateIdentityMatrix(n);
		Mk = CreateSquareMatrix(n);
		t1 = CreateSquareMatrix(n);

		for(k = 1d; k <= n; k = k + 1d){
			/* M_k = A * M_(k-1) + c_(n-k+1) * I*/
			Multiply(Mk, A, Mkm1);
			Assign(t1, I);
			ScalarMultiply(t1, p[(int)(n - k + 1d)]);
			Add(Mk, t1);

			/* c_(n-k) = -1/k * trace(A * M_k)*/
			Multiply(t1, A, Mk);
			p[(int)(n - k)] = -1d/k*Trace(t1);

			/* done*/
			Assign(Mkm1, Mk);

			if(k == n){
				Assign(AInverse, Mk);
				determinant.numberValue = -p[0];
				if(p[0] == 0d){
				}else{
					ScalarDivide(AInverse, determinant.numberValue);
				}
			}
		}

		FreeMatrix(Mkm1);
		FreeMatrix(I);
		FreeMatrix(Mk);
		FreeMatrix(t1);

		cp.numberArray = p;
	}


	public static Matrix InverseUsingCharacteristicPolynomial(Matrix A){
		Matrix inverse;
		NumberArrayReference coeffs;
		NumberReference determinant;

		inverse = CreateSquareMatrix(NumberOfRows(A));
		coeffs = new NumberArrayReference();
		determinant = new NumberReference();
		CharacteristicPolynomialWithInverse(A, inverse, coeffs, determinant);
		delete(coeffs.numberArray);
		delete(coeffs);

		return inverse;
	}


	public static bool Eigenvalues(Matrix A, NumberArrayReference eigenValuesReference){
		MatrixArrayReference eigenVectorsReference;
		bool success;
		double i;

		eigenVectorsReference = new MatrixArrayReference();
		success = Eigenpairs(A, eigenValuesReference, eigenVectorsReference);
		if(success){
			for(i = 0d; i < eigenVectorsReference.matrices.Length; i = i + 1d){
				FreeMatrix(eigenVectorsReference.matrices[(int)(i)]);
			}
			delete(eigenVectorsReference.matrices);
			delete(eigenVectorsReference);
		}

		return success;
	}


	public static bool EigenvaluesUsingQRAlgorithm(Matrix A, NumberArrayReference eigenValuesReference, double precision, double maxIterations){
		Matrix x, q, r;
		bool success;
		double i, n, v, v1, v2, ev, found;
		double [] cp;

		n = NumberOfRows(A);
		x = CreateSquareMatrix(n);
		q = CreateSquareMatrix(n);
		r = CreateSquareMatrix(n);
		eigenValuesReference.numberArray = new double [(int)(n)];
		success = QRAlgorithm(A, r, x, q, precision, maxIterations);
		found = 0d;
		if(success){
			ExtractDiagonal(x, eigenValuesReference.numberArray);

			/* find the correct sign of the eigenvalue.*/
			cp = CharacteristicPolynomial(A);
			for(i = 0d; i < n; i = i + 1d){
				ev = eigenValuesReference.numberArray[(int)(i)];

				v1 = pEvaluate(cp, ev);
				v2 = pEvaluate(cp, -ev);

				if(Abs(v2) < Abs(v1)){
					eigenValuesReference.numberArray[(int)(i)] = -ev;
					v = v2;
				}else{
					v = v1;
				}

				if(Abs(v) < precision*Pow(10d, 4d)){
					found = found + 1d;
				}
			}

			FreeMatrix(x);
			FreeMatrix(q);
			FreeMatrix(r);
		}

		if(found != n){
			success = false;
		}

		return success;
	}


	public static bool EigenvaluesUsingLaguerreIterations(Matrix A, NumberArrayReference eigenValuesReference){
		double [] p;
		bool success;

		p = CharacteristicPolynomial(A);
		success = FindRoots(p, eigenValuesReference);

		return success;
	}


	public static void GaussianElimination(Matrix A){
		double h, k, m, n, maxElement, i, j, max, maxCandidate, f;

		m = NumberOfRows(A);
		n = NumberOfColumns(A);

		h = 0d;
		k = 0d;
		for(; h < m && k < n; ){
			maxElement = h;
			max = 0d;
			for(i = h; i < m; i = i + 1d){
				maxCandidate = Abs(Element(A, i, k));
				if(max < maxCandidate){
					maxElement = i;
					max = maxCandidate;
				}
			}
			if(A.r[(int)(maxElement)].c[(int)(k)] == 0d){
				k = k + 1d;
			}else{
				SwapRows(A, h, maxElement);
				for(i = h + 1d; i < m; i = i + 1d){
					f = Element(A, i, k)/Element(A, h, k);
					A.r[(int)(i)].c[(int)(k)] = 0d;
					for(j = k + 1d; j < n; j = j + 1d){
						A.r[(int)(i)].c[(int)(j)] = Element(A, i, j) - Element(A, h, j)*f;
					}
				}
				h = h + 1d;
				k = k + 1d;
			}
		}
	}


	public static Matrix GaussianEliminationToNew(Matrix A){
		Matrix X;

		X = CreateCopyOfMatrix(A);
		GaussianElimination(X);

		return X;
	}


	public static Matrix CreateCopyOfMatrix(Matrix A){
		Matrix X;

		X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A));
		Assign(X, A);

		return X;
	}


	public static void SwapRows(Matrix A, double to, double from){
		double n;
		double c, t;

		c = NumberOfRows(A);
		for(n = 0d; n < c; n = n + 1d){
			t = A.r[(int)(to)].c[(int)(n)];
			A.r[(int)(to)].c[(int)(n)] = A.r[(int)(from)].c[(int)(n)];
			A.r[(int)(from)].c[(int)(n)] = t;
		}
	}


	public static void UnnormalizeVector(double [] numberArray){
		double i, m;
		bool mSet;

		mSet = false;
		m = 0d;

		for(i = 0d; i < numberArray.Length; i = i + 1d){
			if(numberArray[(int)(i)] - Truncate(numberArray[(int)(i)]) < 0.001){
				if(!mSet){
					m = Abs(numberArray[(int)(i)]);
					mSet = true;
				}else{
					m = Min(m, Abs(numberArray[(int)(i)]));
				}
			}
		}

		if(mSet){
			for(i = 0d; i < numberArray.Length; i = i + 1d){
				numberArray[(int)(i)] = numberArray[(int)(i)]/m;
			}
		}
	}


	public static bool InversePowerMethod(Matrix A, double eigenvalue, double maxIterations, NumberArrayReference eigenvector){
		Matrix x, y, z, b, t;
		double n, i, c;
		bool singular;

		n = NumberOfRows(A);

		x = CreateIdentityMatrix(n);
		ScalarMultiply(x, eigenvalue);
		y = SubtractToNew(A, x);
		z = CreateSquareMatrix(n);
		singular = !Inverse(y, z);
		if(singular){
			/* Try again with more erroneous eigenvalue estimate.*/
			x = CreateIdentityMatrix(n);
			ScalarMultiply(x, eigenvalue*1.01);
			y = SubtractToNew(A, x);
			z = CreateSquareMatrix(n);
			singular = !Inverse(y, z);
		}

		if(!singular){
			b = CreateMatrix(n, 1d);

			for(i = 0d; i < n; i = i + 1d){
				b.r[(int)(i)].c[0] = 1d;
			}

			for(i = 0d; i < maxIterations; i = i + 1d){
				t = MultiplyToNew(z, b);
				c = Norm(t);
				ScalarDivide(t, c);
				Assign(b, t);
			}

			eigenvector.numberArray = new double [(int)(n)];
			for(i = 0d; i < n; i = i + 1d){
				eigenvector.numberArray[(int)(i)] = b.r[(int)(i)].c[0];
			}
		}

		return !singular;
	}


	public static bool Eigenvectors(Matrix A, MatrixArrayReference eigenVectorsReference){
		NumberArrayReference evsReference;
		bool success;

		evsReference = new NumberArrayReference();
		success = Eigenpairs(A, evsReference, eigenVectorsReference);
		if(success){
			delete(evsReference.numberArray);
			delete(evsReference);
		}

		return success;
	}


	public static bool Eigenpairs(Matrix A, NumberArrayReference eigenValuesReference, MatrixArrayReference eigenVectorsReference){
		return EigenpairsUsingQRAlgorithmAndInversePowerMethod(A, eigenValuesReference, eigenVectorsReference, 0.00000000001, 100d);
	}


	public static bool EigenpairsUsingQRAlgorithmAndInversePowerMethod(Matrix M, NumberArrayReference eigenValuesReference, MatrixArrayReference eigenVectorsReference, double precision, double maxIterations){
		NumberArrayReference evecReference;
		bool done, inverseSuccess;
		double i, j, k, N, v1, v2, eigenValue, withinPrecision;
		Matrix A, Q, R, eigenVector;
		double [] cp;

		N = NumberOfRows(M);

		A = CreateCopyOfMatrix(M);
		Q = CreateCopyOfMatrix(M);
		R = CreateCopyOfMatrix(M);

		done = false;
		eigenVectorsReference.matrices = new Matrix [(int)(N)];
		evecReference = new NumberArrayReference();
		eigenValuesReference.numberArray = new double [(int)(N)];
		cp = CharacteristicPolynomial(M);

		for(j = 0d; j < N; j = j + 1d){
			eigenVectorsReference.matrices[(int)(j)] = CreateMatrix(N, 1d);
		}

		for(i = 0d; i < maxIterations && !done; i = i + 1d){
			QRDecomposition(A, Q, R);
			Multiply(A, R, Q);

			/* Check*/
			withinPrecision = 0d;
			ExtractDiagonal(R, eigenValuesReference.numberArray);

			for(j = 0d; j < N; j = j + 1d){
				/* Find the correct sign of the eigenvalue.*/
				eigenValue = eigenValuesReference.numberArray[(int)(j)];
				v1 = pEvaluate(cp, eigenValue);
				v2 = pEvaluate(cp, -eigenValue);
				if(Abs(v2) < Abs(v1)){
					eigenValuesReference.numberArray[(int)(j)] = -eigenValue;
					eigenValue = -eigenValue;
				}

				/* Calculate the eigenvector corresponding to the eigenvalue.*/
				inverseSuccess = InversePowerMethod(M, eigenValue, i + 1d, evecReference);
				if(inverseSuccess){
					for(k = 0d; k < N; k = k + 1d){
						eigenVectorsReference.matrices[(int)(j)].r[(int)(k)].c[0] = evecReference.numberArray[(int)(k)];
					}

					/* Check eigenpair agains precision.*/
					eigenVector = eigenVectorsReference.matrices[(int)(j)];

					if(CheckEigenpairPrecision(M, eigenValue, eigenVector, precision)){
						withinPrecision = withinPrecision + 1d;
					}
				}
			}

			if(withinPrecision == N){
				done = true;
			}
		}

		FreeMatrix(A);
		FreeMatrix(Q);
		FreeMatrix(R);
		delete(evecReference);
		delete(cp);

		return done;
	}


	public static bool CheckEigenpairPrecision(Matrix a, double lambda, Matrix e, double precision){
		Matrix vec1, vec2;
		bool equal;

		vec1 = MultiplyToNew(a, e);
		vec2 = ScalarMultiplyToNew(e, lambda);

		equal = MatrixEqualsEpsilon(vec1, vec2, precision);

		return equal;
	}


	public static bool EigenvectorsLaguerreIterationsAndGaussianEliminations(Matrix A, MatrixArrayReference eigenVectorsReference){
		Matrix Id, t1, B, v;
		Matrix [] eigenVectorsResult;
		bool success;
		NumberArrayReference eigenValuesReference;
		double i, lambda, j, N, x, k;
		double [] ev;

		N = NumberOfRows(A);

		eigenValuesReference = new NumberArrayReference();
		success = Eigenvalues(A, eigenValuesReference);

		eigenVectorsResult = new Matrix [(int)(N)];

		if(success){
			ev = eigenValuesReference.numberArray;

			Id = CreateIdentityMatrix(N);
			t1 = CreateSquareMatrix(N);
			B = CreateSquareMatrix(N);

			for(j = 0d; j < ev.Length && success; j = j + 1d){
				lambda = ev[(int)(j)];

				/* B = A - lambda * Id*/
				Assign(t1, Id);
				ScalarMultiply(t1, lambda);

				Assign(B, A);
				Subtract(B, t1);

				GaussianElimination(B);

				v = CreateMatrix(N, 1d);
				v.r[(int)(N - 1d)].c[0] = 1d;
				for(i = N - 2d; i >= 0d && success; i = i - 1d){
					if(!RowIsZero(B, i)){
						x = 0d;

						for(k = N - 1d; k > i; k = k - 1d){
							x = x - Element(B, i, k)*Element(v, k, 0d);
						}

						v.r[(int)(i)].c[0] = x/Element(B, i, i);
					}else{
						success = false;
					}
				}

				eigenVectorsResult[(int)(j)] = v;
			}

			FreeMatrix(t1);
			FreeMatrix(B);
			FreeMatrix(Id);

			eigenVectorsReference.matrices = eigenVectorsResult;
		}

		return success;
	}


	public static bool RowIsZero(Matrix X, double r){
		bool isZero;
		double columns, i;

		isZero = true;

		columns = NumberOfColumns(X);
		for(i = 0d; i < columns && isZero; i = i + 1d){
			if(Element(X, r, i) != 0d){
				isZero = false;
			}
		}

		return isZero;
	}


	public static void FreeMatrix(Matrix X){
		FreeMatrixRows(X.r);
		delete(X);
	}


	public static void FreeMatrixRows(MatrixRow [] r){
		double m, rows;

		rows = r.Length;
		for(m = 0d; m < rows; m = m + 1d){
			delete(r[(int)(m)].c);
			delete(r[(int)(m)]);
		}

		delete(r);
	}


	public static Matrix CreateDiagonalMatrixFromArray(double [] array){
		double m;
		Matrix matrix;

		matrix = CreateSquareMatrix(array.Length);
		Fill(matrix, 0d);

		for(m = 0d; m < array.Length; m = m + 1d){
			matrix.r[(int)(m)].c[(int)(m)] = array[(int)(m)];
		}

		return matrix;
	}


	public static Matrix CreateMatrixFromRowCopies(double [] row, double times){
		double m, n;
		Matrix matrix;

		matrix = CreateMatrix(times, row.Length);

		for(m = 0d; m < times; m = m + 1d){
			for(n = 0d; n < row.Length; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = row[(int)(n)];
			}
		}

		return matrix;
	}


	public static void ExtractDiagonal(Matrix X, double [] diag){
		double n, i;

		n = NumberOfRows(X);

		for(i = 0d; i < n; i = i + 1d){
			diag[(int)(i)] = X.r[(int)(i)].c[(int)(i)];
		}
	}


	public static double [] ExtractDiagonalToNew(Matrix X){
		double [] diag;
		double n, i;

		n = NumberOfRows(X);
		diag = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			diag[(int)(i)] = X.r[(int)(i)].c[(int)(i)];
		}

		return diag;
	}


	public static bool MatrixEqualsEpsilon(Matrix a, Matrix b, double epsilon){
		double x, y, columns, rows;
		bool equals;

		equals = true;

		if(NumberOfRows(a) == NumberOfRows(b) && NumberOfColumns(a) == NumberOfColumns(b)){
			columns = NumberOfColumns(a);
			rows = NumberOfRows(a);

			for(x = 0d; x < rows; x = x + 1d){
				for(y = 0d; y < columns; y = y + 1d){
					equals = equals && EpsilonCompare(Element(a, x, y), Element(b, x, y), epsilon);
				}
			}
		}else{
			equals = false;
		}

		return equals;
	}


	public static Matrix Minor(Matrix x, double row, double column){
		Matrix theMinor;
		double cols, rows, i, j, m, n;

		rows = NumberOfRows(x) - 1d;
		cols = NumberOfColumns(x) - 1d;

		theMinor = CreateMatrix(rows, cols);

		for(i = 0d; i < rows; i = i + 1d){
			if(i < row){
				m = i;
			}else{
				m = i + 1d;
			}

			for(j = 0d; i != row && j < cols; j = j + 1d){
				if(j != column){

					if(j < column){
						n = j;
					}else{
						n = j + 1d;
					}

					theMinor.r[(int)(m)].c[(int)(n)] = x.r[(int)(i)].c[(int)(j)];
				}
			}
		}

		return theMinor;
	}


	public static void QRDecomposition(Matrix m, Matrix Q, Matrix R){
		HouseholderMethod(m, Q, R);
	}


	public static void HouseholderTriangularizationAlgorithm(Matrix m, Matrix Qout, Matrix Rout){
		Matrix P, AA, A, PP, v, vt, t;
		double i, j, rows, cols, r, s;

		rows = NumberOfRows(m);
		cols = NumberOfColumns(m);

		P = CreateIdentityMatrix(rows);
		A = CreateCopyOfMatrix(m);
		AA = CreateMatrix(rows, cols);

		t = CreateMatrix(rows, cols);
		PP = CreateIdentityMatrix(rows);
		vt = CreateMatrix(1d, rows);

		for(j = 0d; j < cols; j = j + 1d){
			v = ExtractSubMatrix(A, 0d, rows - 1d, j, j);
			if(j > 0d){
				for(i = 0d; i < j; i = i + 1d){
					v.r[(int)(i)].c[0] = 0d;
				}
			}

			s = Sign(v.r[(int)(j)].c[0]);
			if(s == 0d){
				s = 1d;
			}
			v.r[(int)(j)].c[0] = v.r[(int)(j)].c[0] + Norm(v)*s;
			r = -2d/(Norm(v)*Norm(v));
			Assign(AA, A);

			TransposeAssign(vt, v);
			Multiply(t, vt, A);
			Assign(A, t);
			Multiply(t, v, A);
			Assign(A, t);
			ScalarMultiply(A, r);
			Assign(t, AA);
			Add(A, AA);

			Assign(PP, P);

			Multiply(t, vt, P);
			Assign(P, t);
			Multiply(t, v, P);
			Assign(P, t);
			ScalarMultiply(P, r);
			Assign(t, AA);
			Add(P, PP);
		}

		Assign(Rout, A);
		Assign(Qout, P);
		Transpose(Qout);
	}


	public static void HouseholderMethod(Matrix A, Matrix q, Matrix r){
		Matrix QR, R, Q;
		double [] Rdiag;
		double m, n;
		double i, j, k;
		double s, nrm;
		double e;
		Matrix N, ra, rq;

		/* Initialize.*/
		QR = CreateCopyOfMatrix(A);
		m = NumberOfRows(A);
		n = NumberOfColumns(A);
		Rdiag = new double [(int)(n)];

		/* Main loop.*/
		for(k = 0d; k < n; k = k + 1d){
			/* Compute 2-norm of k-th column without under/overflow.*/
			nrm = 0d;
			for(i = k; i < m; i = i + 1d){
				nrm = Hypothenuse(nrm, Element(QR, i, k));
			}

			if(nrm != 0d){
				/* Form k-th Householder vector.*/
				if(Element(QR, k, k) < 0d){
					nrm = -nrm;
				}
				for(i = k; i < m; i = i + 1d){
					QR.r[(int)(i)].c[(int)(k)] = Element(QR, i, k)/nrm;
				}
				QR.r[(int)(k)].c[(int)(k)] = Element(QR, k, k) + 1d;

				/* Apply transformation to remaining columns.*/
				for(j = k + 1d; j < n; j = j + 1d){
					s = 0d;
					for(i = k; i < m; i = i + 1d){
						s = s + Element(QR, i, k)*Element(QR, i, j);
					}
					s = -s/Element(QR, k, k);
					for(i = k; i < m; i = i + 1d){
						QR.r[(int)(i)].c[(int)(j)] = Element(QR, i, j) + s*Element(QR, i, k);
					}
				}
			}
			Rdiag[(int)(k)] = -nrm;
		}

		/* Compute R*/
		R = CreateSquareMatrix(n);
		for(i = 0d; i < n; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				if(i < j){
					R.r[(int)(i)].c[(int)(j)] = Element(QR, i, j);
				}else if(i == j){
					R.r[(int)(i)].c[(int)(j)] = Rdiag[(int)(i)];
				}else{
					R.r[(int)(i)].c[(int)(j)] = 0d;
				}
			}
		}
		Assign(r, R);

		/* Compute Q*/
		Q = CreateMatrix(m, n);
		for(k = n - 1d; k >= 0d; k = k - 1d){
			for(i = 0d; i < m; i = i + 1d){
				Q.r[(int)(i)].c[(int)(k)] = 0d;
			}
			Q.r[(int)(k)].c[(int)(k)] = 1d;
			for(j = k; j < n; j = j + 1d){
				if(Element(QR, k, k) != 0d){
					s = 0d;
					for(i = k; i < m; i = i + 1d){
						s = s + Element(QR, i, k)*Element(Q, i, j);
					}
					s = -s/Element(QR, k, k);
					for(i = k; i < m; i = i + 1d){
						Q.r[(int)(i)].c[(int)(j)] = Element(Q, i, j) + s*Element(QR, i, k);
					}
				}
			}
		}
		Assign(q, Q);

		/* Adjust for positive R.*/
		n = NumberOfRows(r);

		N = CreateIdentityMatrix(n);

		for(i = 0d; i < n; i = i + 1d){
			e = Element(r, i, i);

			if(e < 0d){
				N.r[(int)(i)].c[(int)(i)] = -1d;
			}
		}

		ra = MultiplyToNew(N, r);
		Assign(r, ra);
		rq = MultiplyToNew(q, N);
		Assign(q, rq);

		FreeMatrix(ra);
		FreeMatrix(rq);
		FreeMatrix(Q);
		FreeMatrix(R);
		FreeMatrix(QR);
	}


	public static double Hypothenuse(double a, double b){
		return Sqrt(Pow(a, 2d) + Pow(b, 2d));
	}


	public static double Norm(Matrix a){
		double l, i, j, rows, cols;

		l = 0d;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(a);

		for(i = 0d; i < rows; i = i + 1d){
			for(j = 0d; j < cols; j = j + 1d){
				l = l + a.r[(int)(i)].c[(int)(j)]*a.r[(int)(i)].c[(int)(j)];
			}
		}
		l = Sqrt(l);

		return l;
	}


	public static Matrix ExtractSubMatrix(Matrix M, double r1, double r2, double c1, double c2){
		Matrix A;
		double i, j;

		A = CreateMatrix(r2 - r1 + 1d, c2 - c1 + 1d);

		for(i = r1; i <= r2; i = i + 1d){
			for(j = c1; j <= c2; j = j + 1d){
				A.r[(int)(i - r1)].c[(int)(j - c1)] = M.r[(int)(i)].c[(int)(j)];
			}
		}

		return A;
	}


	public static bool QRAlgorithm(Matrix M, Matrix R, Matrix A, Matrix Q, double precision, double maxIterations){
		double n, i, j, v;
		double [] previous;
		double withinPrecision;
		bool done, previousSet;

		Assign(A, M);
		n = NumberOfRows(M);
		previous = new double [(int)(n)];
		previousSet = false;

		done = false;
		for(i = 0d; i < maxIterations && !done; i = i + 1d){
			QRDecomposition(A, Q, R);
			Multiply(A, R, Q);

			/* Check precision.*/
			if(previousSet){
				withinPrecision = 0d;
				for(j = 0d; j < n; j = j + 1d){
					v = previous[(int)(j)] - Element(A, j, j);
					if(Abs(v) < precision || v == 0d){
						withinPrecision = withinPrecision + 1d;
					}
				}
				if(withinPrecision == n){
					done = true;
				}
			}

			for(j = 0d; j < n; j = j + 1d){
				previous[(int)(j)] = Element(A, j, j);
			}
			previousSet = true;
		}

		return done;
	}


	public static bool InvertUpperTriangularMatrix(Matrix A, Matrix inverse){
		double sum, i, j, k, n;
		bool success;

		inverse.r = CreateCopyOfMatrix(A).r;
		n = NumberOfRows(inverse);
		success = true;

		for(i = n - 1d; i >= 0d && success; i = i - 1d){
			if(Element(inverse, i, i) == 0d){
				success = false;
			}else{
				inverse.r[(int)(i)].c[(int)(i)] = 1d/Element(inverse, i, i);
				for(j = i - 1d; j >= 0d && success; j = j - 1d){
					sum = 0d;
					for(k = i; k > j; k = k - 1d){
						sum = sum - Element(inverse, j, k)*Element(inverse, k, i);
					}
					if(Element(inverse, j, j) == 0d){
						success = false;
					}else{
						inverse.r[(int)(j)].c[(int)(i)] = sum/Element(inverse, j, j);
					}
				}
			}
		}

		return success;
	}


	public static bool InvertLowerTriangularMatrix(Matrix A, Matrix inverse){
		double sum, i, j, k, n;
		bool success;

		inverse.r = CreateCopyOfMatrix(A).r;
		n = NumberOfRows(inverse);
		success = true;

		for(i = 0d; i < n && success; i = i + 1d){
			if(Element(inverse, i, i) == 0d){
				success = false;
			}else{
				inverse.r[(int)(i)].c[(int)(i)] = 1d/Element(inverse, i, i);
				for(j = i + 1d; j < n; j = j + 1d){
					sum = 0d;
					for(k = i; k < j && success; k = k + 1d){
						sum = sum - Element(inverse, j, k)*Element(inverse, k, i);
					}
					if(Element(inverse, j, j) == 0d){
						success = false;
					}else{
						inverse.r[(int)(j)].c[(int)(i)] = sum/Element(inverse, j, j);
					}
				}
			}
		}

		return success;
	}


	public static bool ParseMatrixFromString(MatrixReference aref, char [] matrixString, StringReference errorMessage){
		bool success;
		StringReference [] lines;
		double rows, cols, i;
		double [] row;
		char [] replaced, trimmed;

		replaced = strReplaceString(matrixString, "\r".ToCharArray(), "".ToCharArray());
		trimmed = strTrim(replaced);
		lines = strSplitByCharacter(trimmed, '\n');

		delete(replaced);
		delete(trimmed);

		success = true;

		rows = lines.Length;
		if(rows == 0d){
			aref.matrix = CreateMatrix(0d, 0d);
		}else{
			row = StringToNumberArray(lines[0].stringx);
			cols = row.Length;
			delete(row);

			aref.matrix = CreateMatrix(rows, cols);

			for(i = 0d; i < rows && success; i = i + 1d){
				delete(aref.matrix.r[(int)(i)].c);
				aref.matrix.r[(int)(i)].c = StringToNumberArray(lines[(int)(i)].stringx);

				if(aref.matrix.r[(int)(i)].c.Length != cols){
					success = false;
					errorMessage.stringx = "All rows must have the same number of columns.".ToCharArray();
				}
			}
		}

		FreeStringReferenceArray(lines);

		return success;
	}


	public static char [] MatrixToString(Matrix matrix, double digitsAfterPoint){
		char [] s1, s2;
		double n, m, element;

		s1 = new char [0];

		for(n = 0d; n < NumberOfRows(matrix); n = n + 1d){
			for(m = 0d; m < NumberOfColumns(matrix); m = m + 1d){
				element = Element(matrix, n, m);
				element = RoundToDigits(element, digitsAfterPoint);
				s2 = strAppendString(s1, CreateStringDecimalFromNumber(element));
				delete(s1);
				s1 = s2;
				if(m + 1d != NumberOfColumns(matrix)){
					s2 = strAppendString(s1, ", ".ToCharArray());
					delete(s1);
					s1 = s2;
				}
			}
			s2 = strAppendString(s1, "\n".ToCharArray());
			delete(s1);
			s1 = s2;
		}

		return s1;
	}


	public static char [] MatrixArrayToString(Matrix [] matrices, double digitsAfterPoint){
		char [] s1, s2;
		double i;

		s1 = new char [0];

		for(i = 0d; i < matrices.Length; i = i + 1d){
			s2 = strAppendString(s1, MatrixToString(matrices[(int)(i)], digitsAfterPoint));
			delete(s1);
			s1 = s2;

			s2 = strAppendString(s1, "\n".ToCharArray());
			delete(s1);
			s1 = s2;
		}

		return s1;
	}


	public static void RoundMatrixElementsToDigits(Matrix a, double digits){
		double m, n;

		for(m = 0d; m < NumberOfRows(a); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(a); n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = RoundToDigits(Element(a, m, n), digits);
				if(a.r[(int)(m)].c[(int)(n)] == -0d){
					a.r[(int)(m)].c[(int)(n)] = 0d;
				}
			}
		}
	}


	public static bool SingularValueDecomposition(Matrix Ap, MatrixReference URef, MatrixReference SigmaRef, MatrixReference VRef){
		Matrix A, U, V;
		double m, n, nu, nct, nrt, i, j, k, t, pp, iter, eps, tiny, kase, f, cs, sn, ks, size, orgm, orgn;
		double scale, sp, spm1, epm1, sk, ek, b, c, shift, g, p;
		bool done;
		double [] s, e, work;

		/* Square matrix, adjust results correspondingly.*/
		orgm = NumberOfRows(Ap);
		orgn = NumberOfColumns(Ap);
		size = Max(orgm, orgn);
		A = CreateCopyOfMatrix(Ap);
		Resize(A, size, size);

		/* Initialize.*/
		m = size;
		n = size;

		/* Compute*/
		nu = Min(m, n);
		s = new double [(int)(Min(m + 1d, n))];
		U = CreateMatrix(m, nu);
		V = CreateSquareMatrix(n);
		e = new double [(int)(n)];
		work = new double [(int)(m)];

		/* Reduce A to bidiagonal form, storing the diagonal elements in s and the super-diagonal elements in e.*/
		nct = Min(m - 1d, n);
		nrt = Max(0d, Min(n - 2d, m));
		for(k = 0d; k < Max(nct, nrt); k = k + 1d){
			if(k < nct){

				/* Compute the transformation for the k-th column and place the k-th diagonal in s[k].*/
				/* Compute 2-norm of k-th column without under/overflow.*/
				s[(int)(k)] = 0d;
				for(i = k; i < m; i = i + 1d){
					s[(int)(k)] = Hypothenuse(s[(int)(k)], Element(A, i, k));
				}
				if(s[(int)(k)] != 0d){
					if(Element(A, k, k) < 0d){
						s[(int)(k)] = -s[(int)(k)];
					}
					for(i = k; i < m; i = i + 1d){
						A.r[(int)(i)].c[(int)(k)] = Element(A, i, k)/s[(int)(k)];
					}
					A.r[(int)(k)].c[(int)(k)] = Element(A, k, k) + 1d;
				}
				s[(int)(k)] = -s[(int)(k)];
			}
			for(j = k + 1d; j < n; j = j + 1d){
				if((k < nct) && (s[(int)(k)] != 0d)){

					/* Apply the transformation.*/
					t = 0d;
					for(i = k; i < m; i = i + 1d){
						t = t + Element(A, i, k)*Element(A, i, j);
					}
					t = -t/Element(A, k, k);
					for(i = k; i < m; i = i + 1d){
						A.r[(int)(i)].c[(int)(j)] = Element(A, i, j) + t*Element(A, i, k);
					}
				}

				/* Place the k-th row of A into e for the subsequent calculation of the row transformation.*/
				e[(int)(j)] = Element(A, k, j);
			}
			if(k < nct){

				/* Place the transformation in U for subsequent back*/
				/* multiplication.*/
				for(i = k; i < m; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = Element(A, i, k);
				}
			}
			if(k < nrt){
				/* Compute the k-th row transformation and place the k-th super-diagonal in e[k].*/
				/* Compute 2-norm without under/overflow.*/
				e[(int)(k)] = 0d;
				for(i = k + 1d; i < n; i = i + 1d){
					e[(int)(k)] = Hypothenuse(e[(int)(k)], e[(int)(i)]);
				}
				if(e[(int)(k)] != 0d){
					if(e[(int)(k + 1d)] < 0d){
						e[(int)(k)] = -e[(int)(k)];
					}
					for(i = k + 1d; i < n; i = i + 1d){
						e[(int)(i)] = e[(int)(i)]/e[(int)(k)];
					}
					e[(int)(k + 1d)] = e[(int)(k + 1d)] + 1d;
				}
				e[(int)(k)] = -e[(int)(k)];
				if((k + 1d < m) && (e[(int)(k)] != 0d)){

					/* Apply the transformation.*/
					for(i = k + 1d; i < m; i = i + 1d){
						work[(int)(i)] = 0d;
					}
					for(j = k + 1d; j < n; j = j + 1d){
						for(i = k + 1d; i < m; i = i + 1d){
							work[(int)(i)] = work[(int)(i)] + e[(int)(j)]*Element(A, i, j);
						}
					}
					for(j = k + 1d; j < n; j = j + 1d){
						t = -e[(int)(j)]/e[(int)(k + 1d)];
						for(i = k + 1d; i < m; i = i + 1d){
							A.r[(int)(i)].c[(int)(j)] = Element(A, i, j) + t*work[(int)(i)];
						}
					}
				}

				/* Place the transformation in V for subsequent back multiplication.*/
				for(i = k + 1d; i < n; i = i + 1d){
					V.r[(int)(i)].c[(int)(k)] = e[(int)(i)];
				}
			}
		}

		/* Set up the final bidiagonal matrix or order p.*/
		p = Min(n, m + 1d);
		if(nct < n){
			s[(int)(nct)] = Element(A, nct, nct);
		}
		if(m < p){
			s[(int)(p - 1d)] = 0d;
		}
		if(nrt + 1d < p){
			e[(int)(nrt)] = Element(A, nrt, p - 1d);
		}
		e[(int)(p - 1d)] = 0d;

		/* Generate U.*/
		for(j = nct; j < nu; j = j + 1d){
			for(i = 0d; i < m; i = i + 1d){
				U.r[(int)(i)].c[(int)(j)] = 0d;
			}
			U.r[(int)(j)].c[(int)(j)] = 1d;
		}
		for(k = nct - 1d; k >= 0d; k = k - 1d){
			if(s[(int)(k)] != 0d){
				for(j = k + 1d; j < nu; j = j + 1d){
					t = 0d;
					for(i = k; i < m; i = i + 1d){
						t = t + Element(U, i, k)*Element(U, i, j);
					}
					t = -t/Element(U, k, k);
					for(i = k; i < m; i = i + 1d){
						U.r[(int)(i)].c[(int)(j)] = Element(U, i, j) + t*Element(U, i, k);
					}
				}
				for(i = k; i < m; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = -Element(U, i, k);
				}
				U.r[(int)(k)].c[(int)(k)] = 1d + Element(U, k, k);
				for(i = 0d; i < k - 1d; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = 0d;
				}
			}else{
				for(i = 0d; i < m; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = 0d;
				}
				U.r[(int)(k)].c[(int)(k)] = 1d;
			}
		}

		/* Generate V.*/
		for(k = n - 1d; k >= 0d; k = k - 1d){
			if((k < nrt) && (e[(int)(k)] != 0d)){
				for(j = k + 1d; j < nu; j = j + 1d){
					t = 0d;
					for(i = k + 1d; i < n; i = i + 1d){
						t = t + Element(V, i, k)*Element(V, i, j);
					}
					t = -t/Element(V, k + 1d, k);
					for(i = k + 1d; i < n; i = i + 1d){
						V.r[(int)(i)].c[(int)(j)] = Element(V, i, j) + t*Element(V, i, k);
					}
				}
			}
			for(i = 0d; i < n; i = i + 1d){
				V.r[(int)(i)].c[(int)(k)] = 0d;
			}
			V.r[(int)(k)].c[(int)(k)] = 1d;
		}

		/* Main iteration loop for the singular values.*/
		pp = p - 1d;
		iter = 0d;
		eps = Pow(2d, -52d);
		tiny = Pow(2d, -966d);
		for(; p > 0d; ){
			/* Here is where a test for too many iterations would go.*/
			/* This section of the program inspects for negligible elements in the s and e arrays.*/
			/* On completion the variables kase and k are set as follows.*/
			/* kase = 1, if s(p) and e[k-1] are negligible and k<p*/
			/* kase = 2, if s(k) is negligible and k<p*/
			/* kase = 3, if e[k-1] is negligible, k<p, and s(k), ..., s(p) are not negligible (qr step).*/
			/* kase = 4, if e(p-1) is negligible (convergence).*/
			done = false;
			for(k = p - 2d; k > -1d && !done; ){
				if(Abs(e[(int)(k)]) <= tiny + eps*(Abs(s[(int)(k)]) + Abs(s[(int)(k + 1d)]))){
					e[(int)(k)] = 0d;
					done = true;
				}else{
					k = k - 1d;
				}
			}
			if(k == p - 2d){
				kase = 4d;
			}else{
				done = false;
				for(ks = p - 1d; ks > k && !done; ){
					if(ks != p){
						t = Abs(e[(int)(ks)]);
					}else{
						t = 0d;
					}

					if(ks != k + 1d){
						t = t + Abs(e[(int)(ks - 1d)]);
					}

					if(Abs(s[(int)(ks)]) <= tiny + eps*t){
						s[(int)(ks)] = 0d;
						done = true;
					}else{
						ks = ks - 1d;
					}
				}
				if(ks == k){
					kase = 3d;
				}else if(ks == p - 1d){
					kase = 1d;
				}else{
					kase = 2d;
					k = ks;
				}
			}
			k = k + 1d;

			/* Perform the task indicated by kase.*/
			if(kase == 1d){
				/* Deflate negligible s(p).*/
				f = e[(int)(p - 2d)];
				e[(int)(p - 2d)] = 0d;
				for(j = p - 2d; j >= k; j = j - 1d){
					t = Hypothenuse(s[(int)(j)], f);
					cs = s[(int)(j)]/t;
					sn = f/t;
					s[(int)(j)] = t;
					if(j != k){
						f = -sn*e[(int)(j - 1d)];
						e[(int)(j - 1d)] = cs*e[(int)(j - 1d)];
					}

					for(i = 0d; i < n; i = i + 1d){
						t = cs*Element(V, i, j) + sn*Element(V, i, p - 1d);
						V.r[(int)(i)].c[(int)(p - 1d)] = -sn*Element(V, i, j) + cs*Element(V, i, p - 1d);
						V.r[(int)(i)].c[(int)(j)] = t;
					}
				}
			}else if(kase == 2d){
				/* Split at negligible s(k).*/
				f = e[(int)(k - 1d)];
				e[(int)(k - 1d)] = 0d;
				for(j = k; j < p; j = j + 1d){
					t = Hypothenuse(s[(int)(j)], f);
					cs = s[(int)(j)]/t;
					sn = f/t;
					s[(int)(j)] = t;
					f = -sn*e[(int)(j)];
					e[(int)(j)] = cs*e[(int)(j)];

					for(i = 0d; i < m; i = i + 1d){
						t = cs*Element(U, i, j) + sn*Element(U, i, k + 1d);
						U.r[(int)(i)].c[(int)(k - 1d)] = -sn*Element(U, i, j) + cs*Element(U, i, k + 1d);
						U.r[(int)(i)].c[(int)(j)] = t;
					}
				}
			}else if(kase == 3d){
				/* Perform one qr step.*/
				/* Calculate the shift.*/
				scale = Max(Max(Max(Max(Abs(s[(int)(p - 1d)]), Abs(s[(int)(p - 2d)])), Abs(e[(int)(p - 2d)])), Abs(s[(int)(k)])), Abs(e[(int)(k)]));
				sp = s[(int)(p - 1d)]/scale;
				spm1 = s[(int)(p - 2d)]/scale;
				epm1 = e[(int)(p - 2d)]/scale;
				sk = s[(int)(k)]/scale;
				ek = e[(int)(k)]/scale;
				b = ((spm1 + sp)*(spm1 - sp) + epm1*epm1)/2d;
				c = (sp*epm1)*(sp*epm1);
				shift = 0d;
				if((b != 0d) || (c != 0d)){
					shift = Sqrt(b*b + c);
					if(b < 0d){
						shift = -shift;
					}
					shift = c/(b + shift);
				}
				f = (sk + sp)*(sk - sp) + shift;
				g = sk*ek;

				/* Chase zeros.*/
				for(j = k; j < p - 1d; j = j + 1d){
					t = Hypothenuse(f, g);
					cs = f/t;
					sn = g/t;
					if(j != k){
						e[(int)(j - 1d)] = t;
					}
					f = cs*s[(int)(j)] + sn*e[(int)(j)];
					e[(int)(j)] = cs*e[(int)(j)] - sn*s[(int)(j)];
					g = sn*s[(int)(j + 1d)];
					s[(int)(j + 1d)] = cs*s[(int)(j + 1d)];
					for(i = 0d; i < n; i = i + 1d){
						t = cs*Element(V, i, j) + sn*Element(V, i, j + 1d);
						V.r[(int)(i)].c[(int)(j + 1d)] = -sn*Element(V, i, j) + cs*Element(V, i, j + 1d);
						V.r[(int)(i)].c[(int)(j)] = t;
					}
					t = Hypothenuse(f, g);
					cs = f/t;
					sn = g/t;
					s[(int)(j)] = t;
					f = cs*e[(int)(j)] + sn*s[(int)(j + 1d)];
					s[(int)(j + 1d)] = -sn*e[(int)(j)] + cs*s[(int)(j + 1d)];
					g = sn*e[(int)(j + 1d)];
					e[(int)(j + 1d)] = cs*e[(int)(j + 1d)];
					if(j < m - 1d){
						for(i = 0d; i < m; i = i + 1d){
							t = cs*Element(U, i, j) + sn*Element(U, i, j + 1d);
							U.r[(int)(i)].c[(int)(j + 1d)] = -sn*Element(U, i, j) + cs*Element(U, i, j + 1d);
							U.r[(int)(i)].c[(int)(j)] = t;
						}
					}
				}
				e[(int)(p - 2d)] = f;
				iter = iter + 1d;
			}else if(kase == 4d){
				/* Make the singular values positive.*/
				if(s[(int)(k)] <= 0d){
					if(s[(int)(k)] < 0d){
						s[(int)(k)] = -s[(int)(k)];
					}else{
						s[(int)(k)] = 0d;
					}

					for(i = 0d; i <= pp; i = i + 1d){
						V.r[(int)(i)].c[(int)(k)] = -Element(V, i, k);
					}
				}

				/* Order the singular values.*/
				for(; k < pp && s[(int)(k)] < s[(int)(k + 1d)]; ){
					t = s[(int)(k)];
					s[(int)(k)] = s[(int)(k + 1d)];
					s[(int)(k + 1d)] = t;
					if(k < n - 1d){
						for(i = 0d; i < n; i = i + 1d){
							t = Element(V, i, k + 1d);
							V.r[(int)(i)].c[(int)(k + 1d)] = Element(V, i, k);
							V.r[(int)(i)].c[(int)(k)] = t;
						}
					}
					if(k < m - 1d){
						for(i = 0d; i < m; i = i + 1d){
							t = Element(U, i, k + 1d);
							U.r[(int)(i)].c[(int)(k + 1d)] = Element(U, i, k);
							U.r[(int)(i)].c[(int)(k)] = t;
						}
					}
					k = k + 1d;
				}
				iter = 0d;
				p = p - 1d;
			}
		}

		Resize(U, orgm, orgm);
		Resize(V, orgn, orgn);

		URef.matrix = U;
		VRef.matrix = V;
		SigmaRef.matrix = CreateMatrix(orgm, orgn);
		for(i = 0d; i < Min(orgm, orgn); i = i + 1d){
			SigmaRef.matrix.r[(int)(i)].c[(int)(i)] = s[(int)(i)];
		}

		return true;
	}


	public static ComplexMatrix CreateComplexMatrix(double rows, double cols){
		double m, n;
		ComplexMatrix matrix;

		matrix = new ComplexMatrix();
		matrix.r = new ComplexMatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new ComplexMatrixRow();
			matrix.r[(int)(m)].c = new cComplexNumber [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = cCreateComplexNumber(0d, 0d);
			}
		}

		return matrix;
	}


	public static ComplexMatrix CreateComplexMatrixFromMatrix(Matrix a){
		double m, n, rows, cols;
		ComplexMatrix matrix;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(a);

		matrix = new ComplexMatrix();
		matrix.r = new ComplexMatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new ComplexMatrixRow();
			matrix.r[(int)(m)].c = new cComplexNumber [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = cCreateComplexNumber(a.r[(int)(m)].c[(int)(n)], 0d);
			}
		}

		return matrix;
	}


	public static Matrix CreateReMatrixFromComplexMatrix(ComplexMatrix a){
		double m, n, rows, cols;
		Matrix matrix;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(a);

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = IndexComplex(a, m, n).re;
			}
		}

		return matrix;
	}


	public static Matrix CreateImMatrixFromComplexMatrix(ComplexMatrix a){
		double m, n, rows, cols;
		Matrix matrix;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(a);

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = IndexComplex(a, m, n).im;
			}
		}

		return matrix;
	}


	public static double NumberOfRowsComplex(ComplexMatrix A){
		return A.r.Length;
	}


	public static double NumberOfColumnsComplex(ComplexMatrix A){
		return A.r[0].c.Length;
	}


	public static cComplexNumber IndexComplex(ComplexMatrix a, double m, double n){
		return a.r[(int)(m)].c[(int)(n)];
	}


	public static void AddComplex(ComplexMatrix a, ComplexMatrix b){
		double m, n;
		double d;

		d = NumberOfRowsComplex(a);

		for(m = 0d; m < d; m = m + 1d){
			for(n = 0d; n < d; n = n + 1d){
				cAdd(IndexComplex(a, m, n), IndexComplex(b, m, n));
			}
		}
	}


	public static void SubtractComplex(ComplexMatrix a, ComplexMatrix b){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(a);
		c = NumberOfColumnsComplex(a);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cSub(IndexComplex(a, m, n), IndexComplex(b, m, n));
			}
		}
	}


	public static ComplexMatrix SubtractComplexToNew(ComplexMatrix a, ComplexMatrix b){
		ComplexMatrix X;

		X = CreateCopyOfComplexMatrix(a);
		SubtractComplex(X, b);

		return X;
	}


	public static void MultiplyComplex(ComplexMatrix x, ComplexMatrix a, ComplexMatrix b){
		double m, n;
		double rows, cols, d;
		double i;
		cComplexNumber s, t;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(b);
		d = NumberOfColumnsComplex(a);
		t = cCreateComplexNumber(0d, 0d);

		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				s = cCreateComplexNumber(0d, 0d);

				for(i = 0d; i < d; i = i + 1d){
					cAssignComplex(t, s);
					cAssignComplex(s, IndexComplex(a, m, i));
					cMul(s, IndexComplex(b, i, n));
					cAdd(s, t);
				}

				x.r[(int)(m)].c[(int)(n)] = s;
			}
		}
	}


	public static ComplexMatrix MultiplyComplexToNew(ComplexMatrix a, ComplexMatrix b){
		double rows, cols;
		ComplexMatrix x;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(b);
		x = CreateComplexMatrix(rows, cols);
		MultiplyComplex(x, a, b);

		return x;
	}


	public static void Conjugate(ComplexMatrix a){
		double m, n;
		double rows, cols;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfRowsComplex(a);

		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				cConjugate(IndexComplex(a, m, n));
			}
		}
	}


	public static void AssignComplexMatrix(ComplexMatrix A, ComplexMatrix B){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n));
			}
		}
	}


	public static void ScalarMultiplyComplex(ComplexMatrix A, cComplexNumber b){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cMul(IndexComplex(A, m, n), b);
			}
		}
	}


	public static ComplexMatrix ScalarMultiplyComplexToNew(ComplexMatrix A, cComplexNumber b){
		ComplexMatrix matrix;

		matrix = CreateCopyOfComplexMatrix(A);
		ScalarMultiplyComplex(matrix, b);

		return matrix;
	}


	public static void ScalarDivideComplex(ComplexMatrix A, cComplexNumber b){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cDiv(IndexComplex(A, m, n), b);
			}
		}
	}


	public static void ElementWisePowerComplex(ComplexMatrix A, double p){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cPower(IndexComplex(A, m, n), p);
			}
		}
	}


	public static ComplexMatrix CreateComplexIdentityMatrix(double d){
		double m;
		ComplexMatrix matrix;

		matrix = CreateSquareComplexMatrix(d);
		FillComplex(matrix, 0d, 0d);

		for(m = 0d; m < d; m = m + 1d){
			IndexComplex(matrix, m, m).re = 1d;
		}

		return matrix;
	}


	public static ComplexMatrix CreateSquareComplexMatrix(double d){
		double m, n;
		ComplexMatrix matrix;

		matrix = new ComplexMatrix();
		matrix.r = new ComplexMatrixRow [(int)(d)];
		for(m = 0d; m < d; m = m + 1d){
			matrix.r[(int)(m)] = new ComplexMatrixRow();
			matrix.r[(int)(m)].c = new cComplexNumber [(int)(d)];
			for(n = 0d; n < d; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = cCreateComplexNumber(0d, 0d);
			}
		}

		return matrix;
	}


	public static void ClearComplex(ComplexMatrix a){
		FillComplex(a, 0d, 0d);
	}


	public static void FillComplex(ComplexMatrix a, double re, double im){
		double m, n;

		for(m = 0d; m < NumberOfRowsComplex(a); m = m + 1d){
			for(n = 0d; n < NumberOfColumnsComplex(a); n = n + 1d){
				IndexComplex(a, m, n).re = re;
				IndexComplex(a, m, n).im = im;
			}
		}
	}


	public static cComplexNumber TraceComplex(ComplexMatrix a){
		double m;
		double d;
		cComplexNumber tr;

		tr = cCreateComplexNumber(0d, 0d);

		d = a.r.Length;
		for(m = 0d; m < d; m = m + 1d){
			cAdd(tr, IndexComplex(a, m, m));
		}

		return tr;
	}


	public static void CofactorOfComplexMatrix(ComplexMatrix mat, ComplexMatrix temp, double p, double q, double n){
		double i, j;
		double row, col;

		i = 0d;
		j = 0d;

		for(row = 0d; row < n; row = row + 1d){
			for(col = 0d; col < n; col = col + 1d){
				if(row != p && col != q){
					cAssignComplex(IndexComplex(temp, i, j), IndexComplex(mat, row, col));
					j = j + 1d;

					if(j == n - 1d){
						j = 0d;
						i = i + 1d;
					}
				}
			}
		}
	}


	public static cComplexNumber DeterminantOfComplexSubmatrix(ComplexMatrix mat, double n){
		double f, sign;
		cComplexNumber D, t;
		ComplexMatrix temp;

		D = cCreateComplexNumber(0d, 0d);
		t = cCreateComplexNumber(0d, 0d);

		if(n == 1d){
			D = mat.r[0].c[0];
		}else{
			temp = CreateSquareComplexMatrix(n);

			sign = 1d;

			for(f = 0d; f < n; f = f + 1d){
				CofactorOfComplexMatrix(mat, temp, 0d, f, n);
				cAssignComplexByValues(t, sign, 0d);
				cMul(t, IndexComplex(mat, 0d, f));
				cMul(t, DeterminantOfComplexSubmatrix(temp, n - 1d));
				cAdd(D, t);
				sign = -sign;
			}

			DeleteComplexMatrix(temp);
		}

		return D;
	}


	public static void DeleteComplexMatrix(ComplexMatrix X){
		double m, n, rows, cols;

		rows = NumberOfRowsComplex(X);
		cols = NumberOfColumnsComplex(X);
		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				delete(X.r[(int)(m)].c[(int)(n)]);
			}
			delete(X.r[(int)(m)].c);
			delete(X.r[(int)(m)]);
		}

		delete(X.r);
		delete(X);
	}


	public static cComplexNumber DeterminantComplex(ComplexMatrix m){
		double n;
		cComplexNumber D;

		n = NumberOfRowsComplex(m);
		D = DeterminantOfComplexSubmatrix(m, n);

		return D;
	}


	public static void AdjointComplex(ComplexMatrix A, ComplexMatrix adj){
		double n;
		ComplexMatrix cofactors;
		double i, j;
		cComplexNumber t, sign;

		n = A.r.Length;
		t = cCreateComplexNumber(0d, 0d);
		sign = cCreateComplexNumber(0d, 0d);

		if(n == 1d){
			cAssignComplexByValues(IndexComplex(adj, 0d, 0d), 1d, 0d);
		}else{
			cofactors = CreateSquareComplexMatrix(n);

			for(i = 0d; i < n; i = i + 1d){
				for(j = 0d; j < n; j = j + 1d){
					CofactorOfComplexMatrix(A, cofactors, i, j, n);

					if((i + j)%2d == 0d){
						cAssignComplexByValues(sign, 1d, 0d);
					}else{
						cAssignComplexByValues(sign, -1d, 0d);
					}

					cAssignComplex(t, sign);
					cMul(t, DeterminantOfComplexSubmatrix(cofactors, n - 1d));
					cAssignComplex(IndexComplex(adj, j, i), t);
				}
			}

			DeleteComplexMatrix(cofactors);
		}
	}


	public static bool InverseComplex(ComplexMatrix A, ComplexMatrix inverseResult){
		bool success;
		ComplexMatrix adj;
		double n, i, j;
		cComplexNumber det, t;

		t = cCreateComplexNumber(0d, 0d);

		if(NumberOfColumnsComplex(A) == NumberOfRowsComplex(A)){
			n = NumberOfColumnsComplex(A);

			det = DeterminantComplex(A);
			if(det.re != 0d || det.im != 0d){
				adj = CreateSquareComplexMatrix(n);
				AdjointComplex(A, adj);

				for(i = 0d; i < n; i = i + 1d){
					for(j = 0d; j < n; j = j + 1d){
						cAssignComplex(t, IndexComplex(adj, i, j));
						cDiv(t, det);
						cAssignComplex(IndexComplex(inverseResult, i, j), t);
					}
				}

				success = true;
				DeleteComplexMatrix(adj);
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	public static bool ComplexMatrixEqualsEpsilon(ComplexMatrix b, ComplexMatrix f, double epsilon){
		double x, y, columns, rows;
		bool equals;

		equals = true;

		if(NumberOfRowsComplex(b) == NumberOfRowsComplex(f) && NumberOfColumnsComplex(b) == NumberOfColumnsComplex(f)){
			columns = NumberOfColumnsComplex(b);
			rows = NumberOfRowsComplex(b);

			for(x = 0d; x < rows; x = x + 1d){
				for(y = 0d; y < columns; y = y + 1d){
					equals = equals && cEpsilonCompareComplex(IndexComplex(b, x, y), IndexComplex(f, x, y), epsilon);
				}
			}
		}else{
			equals = false;
		}

		return equals;
	}


	public static ComplexMatrix MinorComplex(ComplexMatrix x, double row, double column){
		ComplexMatrix minor;
		double cols, rows, i, j, m, n;

		rows = NumberOfRowsComplex(x) - 1d;
		cols = NumberOfColumnsComplex(x) - 1d;

		minor = CreateComplexMatrix(rows, cols);

		for(i = 0d; i < rows; i = i + 1d){
			if(i < row){
				m = i;
			}else{
				m = i + 1d;
			}

			for(j = 0d; i != row && j < cols; j = j + 1d){
				if(j != column){

					if(j < column){
						n = j;
					}else{
						n = j + 1d;
					}

					cAssignComplex(IndexComplex(minor, m, n), IndexComplex(x, i, j));
				}
			}
		}

		return minor;
	}


	public static void AssignComplex(ComplexMatrix A, ComplexMatrix B){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n));
			}
		}
	}


	public static ComplexMatrix CreateCopyOfComplexMatrix(ComplexMatrix A){
		ComplexMatrix X;

		X = CreateComplexMatrix(NumberOfRowsComplex(A), NumberOfColumnsComplex(A));
		AssignComplex(X, A);

		return X;
	}


	public static bool TransposeComplex(ComplexMatrix a){
		double m, n;
		double rows;
		bool square;
		cComplexNumber tmp;

		tmp = cCreateComplexNumber(0d, 0d);

		square = IsSquareComplexMatrix(a);
		if(square){
			rows = NumberOfColumnsComplex(a);

			for(m = 0d; m < rows; m = m + 1d){
				for(n = 0d; n < m; n = n + 1d){
					cAssignComplex(tmp, IndexComplex(a, n, m));
					cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n));
					cAssignComplex(IndexComplex(a, m, n), tmp);
				}
			}
		}

		return square;
	}


	public static bool ConjugateTransposeComplex(ComplexMatrix a){
		double m, n;
		double rows;
		bool square;
		cComplexNumber tmp;

		tmp = cCreateComplexNumber(0d, 0d);

		square = IsSquareComplexMatrix(a);
		if(square){
			rows = NumberOfColumnsComplex(a);

			for(m = 0d; m < rows; m = m + 1d){
				for(n = 0d; n < m; n = n + 1d){
					cAssignComplex(tmp, IndexComplex(a, n, m));
					cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n));
					cAssignComplex(IndexComplex(a, m, n), tmp);
					cConjugate(IndexComplex(a, m, n));
				}
			}
		}

		return square;
	}


	public static bool IsSquareComplexMatrix(ComplexMatrix A){
		bool isx;

		if(NumberOfRowsComplex(A) == NumberOfColumnsComplex(A)){
			isx = true;
		}else{
			isx = false;
		}

		return isx;
	}


	public static void TransposeComplexAssign(ComplexMatrix t, ComplexMatrix a){
		double m, n;
		double rows, cols;

		cols = NumberOfRowsComplex(a);
		rows = NumberOfColumnsComplex(a);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				cAssignComplex(IndexComplex(t, n, m), IndexComplex(a, m, n));
			}
		}
	}


	public static ComplexMatrix TransposeComplexToNew(ComplexMatrix a){
		double m, n;
		double rows, cols;
		ComplexMatrix c;

		cols = NumberOfRowsComplex(a);
		rows = NumberOfColumnsComplex(a);

		c = CreateComplexMatrix(rows, cols);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				cAssignComplex(IndexComplex(c, n, m), IndexComplex(a, m, n));
			}
		}

		return c;
	}


	public static ComplexMatrix ExtractComplexSubMatrix(ComplexMatrix M, double r1, double r2, double c1, double c2){
		ComplexMatrix A;
		double i, j;

		A = CreateComplexMatrix(r2 - r1 + 1d, c2 - c1 + 1d);

		for(i = r1; i <= r2; i = i + 1d){
			for(j = c1; j <= c2; j = j + 1d){
				cAssignComplex(IndexComplex(A, i - r1, j - c1), IndexComplex(M, i, j));
			}
		}

		return A;
	}


	public static double NormComplex(ComplexMatrix a){
		double l, i, j, rows, cols;
		cComplexNumber cComplexNumber;

		l = 0d;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(a);

		for(i = 0d; i < rows; i = i + 1d){
			for(j = 0d; j < cols; j = j + 1d){
				cComplexNumber = IndexComplex(a, i, j);
				l = l + Pow(cComplexNumber.re, 2d) + Pow(cComplexNumber.im, 2d);
			}
		}
		l = Sqrt(l);

		return l;
	}


	public static void ComplexCharacteristicPolynomial(ComplexMatrix A, pComplexPolynomial p){
		ComplexMatrix cp;
		cComplexNumber determinant;

		cp = CreateSquareComplexMatrix(NumberOfRowsComplex(A));
		determinant = new cComplexNumber();

		ComplexCharacteristicPolynomialWithInverse(A, cp, p, determinant);

		DeleteComplexMatrix(cp);
	}


	public static void ComplexCharacteristicPolynomialWithInverse(ComplexMatrix A, ComplexMatrix AInverse, pComplexPolynomial p, cComplexNumber determinant){
		FaddeevLeVerrierAlgorithmComplex(A, AInverse, p, determinant);
	}


	public static void FaddeevLeVerrierAlgorithmComplex(ComplexMatrix A, ComplexMatrix AInverse, pComplexPolynomial p, cComplexNumber determinant){
		ComplexMatrix Mk, Mkm1, t1, Id;
		cComplexNumber t, t2, n1;
		double i, n, k;

		n1 = cCreateComplexNumber(-1d, 0d);
		n = NumberOfRowsComplex(A);
		p.cs = new cComplexNumber [(int)(n + 1d)];
		for(i = 0d; i < n + 1d; i = i + 1d){
			p.cs[(int)(i)] = new cComplexNumber();
		}
		cAssignComplexByValues(p.cs[(int)(n)], 1d, 0d);
		Mkm1 = CreateSquareComplexMatrix(n);
		FillComplex(Mkm1, 0d, 0d);
		Id = CreateComplexIdentityMatrix(n);
		Mk = CreateSquareComplexMatrix(n);
		t1 = CreateSquareComplexMatrix(n);

		for(k = 1d; k <= n; k = k + 1d){
			MultiplyComplex(Mk, A, Mkm1);
			AssignComplex(t1, Id);
			ScalarMultiplyComplex(t1, p.cs[(int)(n - k + 1d)]);
			AddComplex(Mk, t1);

			MultiplyComplex(t1, A, Mk);
			t = TraceComplex(t1);
			t2 = cCreateComplexNumber(-1d/k, 0d);
			cMul(t, t2);
			cAssignComplex(p.cs[(int)(n - k)], t);

			/* done*/
			AssignComplex(Mkm1, Mk);

			if(k == n){
				AssignComplex(AInverse, Mk);
				cAssignComplex(t, p.cs[0]);
				cMul(t, n1);
				cAssignComplex(determinant, t);
				if(t.re == 0d && t.im == 0d){
				}else{
					ScalarDivideComplex(AInverse, t);
				}
			}
		}

		DeleteComplexMatrix(Mkm1);
		DeleteComplexMatrix(Id);
		DeleteComplexMatrix(Mk);
		DeleteComplexMatrix(t1);
	}


	public static bool EigenvaluesComplex(ComplexMatrix A, cComplexNumberArrayReference eigenValuesReference){
		ComplexMatrixArrayReference eigenVectorsReference;
		bool success;
		double i;

		eigenVectorsReference = new ComplexMatrixArrayReference();
		success = EigenpairsComplex(A, eigenValuesReference, eigenVectorsReference);
		if(success){
			for(i = 0d; i < eigenVectorsReference.matrices.Length; i = i + 1d){
				DeleteComplexMatrix(eigenVectorsReference.matrices[(int)(i)]);
			}
			delete(eigenVectorsReference.matrices);
			delete(eigenVectorsReference);
		}

		return success;
	}


	public static bool EigenvectorsComplex(ComplexMatrix A, ComplexMatrixArrayReference eigenVectorsReference){
		cComplexNumberArrayReference evsReference;
		bool success;
		double i;

		evsReference = new cComplexNumberArrayReference();
		success = EigenpairsComplex(A, evsReference, eigenVectorsReference);
		if(success){
			for(i = 0d; i < evsReference.complexNumbers.Length; i = i + 1d){
				delete(evsReference.complexNumbers[(int)(i)]);
			}
			delete(evsReference.complexNumbers);
			delete(evsReference);
		}

		return success;
	}


	public static bool InversePowerMethodComplex(ComplexMatrix A, cComplexNumber eigenvalue, double maxIterations, cComplexNumberArrayReference eigenvector){
		ComplexMatrix t1, t2, t3, t4, b;
		double n, i, c;
		bool isSingular;
		cComplexNumber c101, k, cc;

		n = NumberOfRowsComplex(A);

		t2 = CreateComplexIdentityMatrix(n);
		ScalarMultiplyComplex(t2, eigenvalue);
		t3 = SubtractComplexToNew(A, t2);
		t4 = CreateSquareComplexMatrix(n);
		isSingular = !InverseComplex(t3, t4);
		cc = cCreateComplexNumber(0d, 0d);
		t1 = CreateComplexMatrix(n, 1d);

		if(isSingular){
			DeleteComplexMatrix(t2);
			DeleteComplexMatrix(t3);
			DeleteComplexMatrix(t4);

			c101 = cCreateComplexNumber(1.01, 0d);
			/* Try again with more erroneous eigenvalue estimate.*/
			t2 = CreateComplexIdentityMatrix(n);
			k = cMulToNew(eigenvalue, c101);
			ScalarMultiplyComplex(t2, k);
			t3 = SubtractComplexToNew(A, t2);
			t4 = CreateSquareComplexMatrix(n);
			isSingular = !InverseComplex(t3, t4);
			delete(c101);
		}

		if(!isSingular){
			b = CreateComplexMatrix(n, 1d);

			for(i = 0d; i < n; i = i + 1d){
				cAssignComplexByValues(b.r[(int)(i)].c[0], 1d, 1d);
			}

			for(i = 0d; i < maxIterations; i = i + 1d){
				MultiplyComplex(t1, t4, b);
				c = NormComplex(t1);
				cAssignComplexByValues(cc, c, 0d);
				ScalarDivideComplex(t1, cc);
				AssignComplex(b, t1);
			}

			eigenvector.complexNumbers = new cComplexNumber [(int)(n)];
			for(i = 0d; i < n; i = i + 1d){
				eigenvector.complexNumbers[(int)(i)] = b.r[(int)(i)].c[0];
			}
		}

		DeleteComplexMatrix(t1);
		DeleteComplexMatrix(t2);
		DeleteComplexMatrix(t3);
		DeleteComplexMatrix(t4);
		delete(cc);

		return !isSingular;
	}


	public static bool EigenpairsComplex(ComplexMatrix M, cComplexNumberArrayReference eigenValuesReference, ComplexMatrixArrayReference eigenVectorsReference){
		return ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(M, eigenValuesReference, eigenVectorsReference, 0.000001, 100d);
	}


	public static bool ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(ComplexMatrix M, cComplexNumberArrayReference eigenValuesReference, ComplexMatrixArrayReference eigenVectorsReference, double precision, double maxIterations){
		bool success, inverseSuccess;
		double n, i, j, k, withinPrecision;
		cComplexNumber t1, t2, t3, xn1, eigenValue;
		cComplexNumber [] rs, rsPrev;
		pComplexPolynomial p;
		cComplexNumberArrayReference evecReference;
		ComplexMatrix eigenVector;

		evecReference = new cComplexNumberArrayReference();

		p = new pComplexPolynomial();
		ComplexCharacteristicPolynomial(M, p);

		n = p.cs.Length - 1d;
		rs = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rs[(int)(i)] = cCreateComplexNumber(0d, 0d);
		}
		rsPrev = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rsPrev[(int)(i)] = cCreateComplexNumber(0.4, 0.9);
			cPower(rsPrev[(int)(i)], i);
		}
		t2 = cCreateComplexNumber(0d, 0d);
		t3 = cCreateComplexNumber(0d, 0d);

		success = false;

		eigenVectorsReference.matrices = new ComplexMatrix [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			eigenVectorsReference.matrices[(int)(i)] = CreateComplexMatrix(n, 1d);
		}

		for(i = 0d; i < maxIterations && !success; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				xn1 = rsPrev[(int)(j)];

				t1 = pEvaluateComplex(p, xn1);
				cAssignComplexByValues(t2, 1d, 0d);
				for(k = 0d; k < n; k = k + 1d){
					if(k < j){
						cAssignComplex(t3, xn1);
						cSub(t3, rs[(int)(k)]);
						cMul(t2, t3);
					}
					if(k > j){
						cAssignComplex(t3, xn1);
						cSub(t3, rsPrev[(int)(k)]);
						cMul(t2, t3);
					}
				}
				cDiv(t1, t2);
				cAssignComplex(rs[(int)(j)], xn1);
				cSub(rs[(int)(j)], t1);

				delete(t1);
			}
			withinPrecision = 0d;
			for(j = 0d; j < n; j = j + 1d){
				eigenValue = rs[(int)(j)];

				/* Calculate the eigenvector corresponding to the eigenvalue.*/
				inverseSuccess = InversePowerMethodComplex(M, eigenValue, i + 1d, evecReference);
				if(inverseSuccess){
					for(k = 0d; k < n; k = k + 1d){
						eigenVectorsReference.matrices[(int)(j)].r[(int)(k)].c[0] = evecReference.complexNumbers[(int)(k)];
					}

					/* Check eigenpair agains precision.*/
					eigenVector = eigenVectorsReference.matrices[(int)(j)];

					if(CheckComplexEigenpairPrecision(M, eigenValue, eigenVector, precision)){
						withinPrecision = withinPrecision + 1d;
					}
					cAssignComplex(rsPrev[(int)(j)], rs[(int)(j)]);
				}
			}
			if(withinPrecision == n){
				success = true;
			}
		}

		eigenValuesReference.complexNumbers = rs;

		return success;
	}


	public static bool CheckComplexEigenpairPrecision(ComplexMatrix a, cComplexNumber lambda, ComplexMatrix e, double precision){
		ComplexMatrix vec1, vec2;
		bool equal;

		vec1 = MultiplyComplexToNew(a, e);
		vec2 = ScalarMultiplyComplexToNew(e, lambda);

		equal = ComplexMatrixEqualsEpsilon(vec1, vec2, precision);

		return equal;
	}


	public static double [] vectorCreate2DVector(double a0, double a1){
		double [] vector;

		vector = new double [2];
		vector[0] = a0;
		vector[1] = a1;

		return vector;
	}


	public static double [] vectorCreate3DVector(double a0, double a1, double a2){
		double [] vector;

		vector = new double [3];
		vector[0] = a0;
		vector[1] = a1;
		vector[2] = a2;

		return vector;
	}


	public static double [] vectorCreate4DVector(double a0, double a1, double a2, double a3){
		double [] vector;

		vector = new double [4];
		vector[0] = a0;
		vector[1] = a1;
		vector[2] = a2;
		vector[3] = a3;

		return vector;
	}


	public static bool vectorDotProductWithCheck(double [] a, double [] b, NumberReference answer, StringReference errorMessage){
		double sum;
		bool success;

		sum = 0d;

		if(a.Length == b.Length){
			sum = vectorDotProduct(a, b);
			success = true;
		}else{
			errorMessage.stringx = "The dimensions have to be equal.".ToCharArray();
			success = false;
		}

		answer.numberValue = sum;

		return success;
	}


	public static double vectorDotProduct(double [] a, double [] b){
		double sum, i;

		sum = 0d;
		/* Dot product is the sum of the products of the corresponding entries of two vectors.*/
		for(i = 0d; i < a.Length; i = i + 1d){
			sum = sum + a[(int)(i)]*b[(int)(i)];
		}

		return sum;
	}


	public static double vectorMagnitude(double [] a){
		double sum, i;

		sum = 0d;

		for(i = 0d; i < a.Length; i = i + 1d){
			sum = sum + Pow(a[(int)(i)], 2d);
		}
		sum = Sqrt(sum);

		return sum;
	}


	public static bool vectorCrossProduct3dWithCheck(double [] a, double [] b, NumberArrayReference answer, StringReference errorMessage){
		double [] crossProduct;
		bool success;

		crossProduct = new double [3];

		if(a.Length == 3d && b.Length == 3d){
			crossProduct[0] = a[1]*b[2] - b[1]*a[2];
			crossProduct[1] = a[2]*b[0] - b[2]*a[0];
			crossProduct[2] = a[0]*b[1] - b[0]*a[1];

			success = true;
		}else{
			errorMessage.stringx = "The dimensions must be 3.".ToCharArray();
			success = false;
		}

		answer.numberArray = crossProduct;

		return success;
	}


	public static double vectorSum(double [] a){
		double s, i;

		s = 0d;

		for(i = 0d; i < a.Length; i = i + 1d){
			s = s + a[(int)(i)];
		}

		return s;
	}


	public static double vectorProduct(double [] a){
		double p, i;

		p = 1d;

		for(i = 0d; i < a.Length; i = i + 1d){
			p = p*a[(int)(i)];
		}

		return p;
	}


	public static void vectorCumulativeSum(double [] a){
		double s, i;

		s = 0d;

		for(i = 0d; i < a.Length; i = i + 1d){
			s = s + a[(int)(i)];
			a[(int)(i)] = s;
		}
	}


	public static void vectorCumulativeProduct(double [] a){
		double p, i;

		p = 1d;

		for(i = 0d; i < a.Length; i = i + 1d){
			p = p*a[(int)(i)];
			a[(int)(i)] = p;
		}
	}


	public static void vectorAdd(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] + b[(int)(i)];
		}
	}


	public static void vectorSubtract(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] - b[(int)(i)];
		}
	}


	public static void vectorMultiply(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)]*b[(int)(i)];
		}
	}


	public static void vectorDivide(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)]/b[(int)(i)];
		}
	}


	public static double [] vectorAddToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(Min(a.Length, b.Length))];

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)] + b[(int)(i)];
		}

		return c;
	}


	public static double [] vectorSubtractToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(Min(a.Length, b.Length))];

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)] - b[(int)(i)];
		}

		return c;
	}


	public static double [] vectorMultiplyToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(Min(a.Length, b.Length))];

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)]*b[(int)(i)];
		}

		return c;
	}


	public static double [] vectorDivideToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(Min(a.Length, b.Length))];

		for(i = 0d; i < a.Length && i < b.Length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)]/b[(int)(i)];
		}

		return c;
	}


	public static void vectorPower(double [] a, double p){
		double i;

		for(i = 0d; i < a.Length; i = i + 1d){
			a[(int)(i)] = Pow(a[(int)(i)], p);
		}
	}


	public static LinearCongruentialGenerator CreateLinearCongruentialGeneratorNumericalRecipes(double seed){
		return CreateLinearCongruentialGeneratorCustom(Pow(2d, 29d), 1664525d, 1013904223d, seed);
	}


	public static LinearCongruentialGenerator CreateLinearCongruentialGeneratorCustom(double modulus, double multiplier, double increment, double seed){
		LinearCongruentialGenerator lcg;

		lcg = new LinearCongruentialGenerator();
		lcg.m = modulus;
		lcg.a = multiplier;
		lcg.c = increment;
		lcg.x = seed;

		return lcg;
	}


	public static double LinearCongruentialGeneratorNextNumber(LinearCongruentialGenerator lcg){
		lcg.x = Floor((lcg.a*lcg.x + lcg.c)%lcg.m);

		return lcg.x/lcg.m;
	}


	public static PseudorandomGenerator CreatePseudorandomNumberGenerator(double seed){
		PseudorandomGenerator prg;

		prg = new PseudorandomGenerator();
		prg.lcg = CreateLinearCongruentialGeneratorNumericalRecipes(seed);

		return prg;
	}


	public static double PseudorandomNextNumber(PseudorandomGenerator prg){
		return LinearCongruentialGeneratorNextNumber(prg.lcg);
	}


	public static double PseudorandomNextInteger(PseudorandomGenerator prg, double n){
		return Floor(PseudorandomNextNumber(prg)*n);
	}


	public static double PseudorandomNextIntegerBetween(PseudorandomGenerator prg, double a, double b){
		return Ceiling(a) + Floor(PseudorandomNextNumber(prg)*(b - a));
	}


	public static double GaloisField2e8Add(double a, double b){
		return Xor2Byte(a, b);
	}


	public static double GaloisField2e8Sub(double a, double b){
		return Xor2Byte(a, b);
	}


	public static double GaloisField2e8Mul(double a, double b, double modulusPolynomial){
		double r;

		r = 0d;

		for(; b != 0d; ){
			if(And2Byte(b, 1d) == 1d){
				r = Xor2Byte(r, a);
			}
			b = ShiftRight2Byte(b, 1d);
			a = ShiftLeft2Byte(a, 1d);
			if((And2Byte(a, 256d) == 256d)){
				a = Xor2Byte(a, modulusPolynomial);
			}
		}

		return r;
	}


	public static double GaloisField2e8Reciprocal(double a, double modulusPolynomial){
		double ga, i, inv;
		bool done;

		ga = a;
		done = false;
		inv = 0d;

		for(i = 0d; i < ShiftLeft2Byte(1d, 8d) && !done; i = i + 1d){
			if(GaloisField2e8Mul(ga, i, modulusPolynomial) == 1d){
				done = true;
				inv = i;
			}
		}

		return inv;
	}


	public static bool FindRoots(double [] p, NumberArrayReference rootsReference){
		return DurandKernerMethod(p, 0.000001, 100d, rootsReference);
	}


	public static bool LaguerresMethodWithRepeatedDivision(double [] p, double maxIterations, double precision, double guess, NumberArrayReference rootsReference){
		double n, nr, xk;
		double [] x;
		double [] q, r, d;
		bool success;
		NumberReference xkReference;

		n = pDegree(p);

		x = new double [(int)(n)];

		q = pCreatePolynomial(n);
		r = pCreatePolynomial(n);
		d = pCreatePolynomial(n);

		success = true;
		xkReference = CreateNumberReference(0d);

		for(nr = 0d; nr < n && success; nr = nr + 1d){
			success = LaguerresMethod(p, guess, maxIterations, precision, xkReference);

			if(success){
				xk = xkReference.numberValue;
				x[(int)(nr)] = xk;

				pFill(d, 0d);
				d[0] = -xk;
				d[1] = 1d;
				pDivide(q, r, p, d);
				pAssign(p, q);
			}
		}

		delete(q);
		delete(r);
		delete(d);
        
		rootsReference.numberArray = x;

		return success;
	}


	public static bool LaguerresMethod(double [] p, double guess, double maxIterations, double precision, NumberReference rootReference){
		double k, a, G, H, xk, denom1, denom2, denom, t1, n;
		bool success;

		n = pDegree(p);
		success = true;

		xk = guess;

		for(k = 0d; (k < maxIterations) && (Abs(pEvaluate(p, xk)) >= precision) && success; k = k + 1d){
			G = pEvaluateDerivative(p, xk, 1d)/pEvaluate(p, xk);
			H = Pow(G, 2d) - pEvaluateDerivative(p, xk, 2d)/pEvaluate(p, xk);
			t1 = (n - 1d)*(n*H - Pow(G, 2d));
			if(t1 >= 0d){
				denom = Sqrt(t1);
				denom1 = G + denom;
				denom2 = G - denom;
				if(Abs(denom1) >= Abs(denom2)){
					denom = denom1;
				}else{
					denom = denom2;
				}
				a = n/denom;

				xk = xk - a;
			}else{
				success = false;
			}
		}

		if(k == maxIterations){
			success = false;
		}

		if(Abs(pEvaluate(p, xk)) >= precision){
			success = false;
		}

		rootReference.numberValue = xk;

		return success;
	}


	public static bool DurandKernerMethod(double [] p, double precision, double maxIterations, NumberArrayReference rootsReference){
		bool success;
		double n, i, j, k, t1, t2, xn1, withinPrecision;
		double [] rs, rsPrev;

		n = p.Length - 1d;
		rs = new double [(int)(n)];
		rsPrev = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			rsPrev[(int)(i)] = i;
		}

		success = false;

		for(i = 0d; i < maxIterations && !success; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				xn1 = rsPrev[(int)(j)];

				t1 = pEvaluate(p, xn1);
				t2 = 1d;
				for(k = 0d; k < n; k = k + 1d){
					if(k < j){
						t2 = t2*(xn1 - rs[(int)(k)]);
					}
					if(k > j){
						t2 = t2*(xn1 - rsPrev[(int)(k)]);
					}
				}
				t1 = t1/t2;
				rs[(int)(j)] = xn1 - t1;
			}
			withinPrecision = 0d;
			for(j = 0d; j < n; j = j + 1d){
				if(EpsilonCompare(rsPrev[(int)(j)], rs[(int)(j)], precision)){
					withinPrecision = withinPrecision + 1d;
				}
				rsPrev[(int)(j)] = rs[(int)(j)];
			}
			if(withinPrecision == n){
				success = true;
			}
		}

		rootsReference.numberArray = rs;

		return success;
	}


	public static bool FindRootsComplex(pComplexPolynomial p, cComplexNumberArrayReference rootsReference){
		return DurandKernerMethodComplex(p, 0.000001, 100d, rootsReference);
	}


	public static bool DurandKernerMethodComplex(pComplexPolynomial p, double precision, double maxIterations, cComplexNumberArrayReference rootsReference){
		bool success;
		double n, i, j, k, withinPrecision;
		cComplexNumber t1, t2, t3, xn1;
		cComplexNumber [] rs, rsPrev;

		n = p.cs.Length - 1d;
		rs = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rs[(int)(i)] = cCreateComplexNumber(0d, 0d);
		}
		rsPrev = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rsPrev[(int)(i)] = cCreateComplexNumber(0.4, 0.9);
			cPower(rsPrev[(int)(i)], i);
		}
		t2 = cCreateComplexNumber(0d, 0d);
		t3 = cCreateComplexNumber(0d, 0d);

		success = false;

		for(i = 0d; i < maxIterations && !success; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				xn1 = rsPrev[(int)(j)];

				t1 = pEvaluateComplex(p, xn1);
				cAssignComplexByValues(t2, 1d, 0d);
				for(k = 0d; k < n; k = k + 1d){
					if(k < j){
						cAssignComplex(t3, xn1);
						cSub(t3, rs[(int)(k)]);
						cMul(t2, t3);
					}
					if(k > j){
						cAssignComplex(t3, xn1);
						cSub(t3, rsPrev[(int)(k)]);
						cMul(t2, t3);
					}
				}
				cDiv(t1, t2);
				cAssignComplex(rs[(int)(j)], xn1);
				cSub(rs[(int)(j)], t1);
			}
			withinPrecision = 0d;
			for(j = 0d; j < n; j = j + 1d){
				if(cEpsilonCompareComplex(rsPrev[(int)(j)], rs[(int)(j)], precision)){
					withinPrecision = withinPrecision + 1d;
				}
				cAssignComplex(rsPrev[(int)(j)], rs[(int)(j)]);
			}
			if(withinPrecision == n){
				success = true;
			}
		}

		rootsReference.complexNumbers = rs;

		return success;
	}


	public static cComplexNumber cCreateComplexNumber(double re, double im){
		cComplexNumber z;

		z = new cComplexNumber();
		z.re = re;
		z.im = im;

		return z;
	}


	public static cPolarComplexNumber cCreatePolarComplexNumber(double r, double phi){
		cPolarComplexNumber p;

		p = new cPolarComplexNumber();
		p.r = r;
		p.phi = phi;

		return p;
	}


	public static void cAdd(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = a + c;
		z1.im = b + d;
	}


	public static cComplexNumber cAddToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = a + c;
		x.im = b + d;

		return x;
	}


	public static void cSub(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = a - c;
		z1.im = b - d;
	}


	public static cComplexNumber cSubToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = a - c;
		x.im = b - d;

		return x;
	}


	public static void cMul(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = a*c - b*d;
		z1.im = b*c + a*d;
	}


	public static cComplexNumber cMulToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = a*c - b*d;
		x.im = b*c + a*d;

		return x;
	}


	public static void cDiv(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = (a*c + b*d)/(Pow(c, 2d) + Pow(d, 2d));
		z1.im = (b*c - a*d)/(Pow(c, 2d) + Pow(d, 2d));
	}


	public static cComplexNumber cDivToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = (a*c + b*d)/(Pow(c, 2d) + Pow(d, 2d));
		x.im = (b*c - a*d)/(Pow(c, 2d) + Pow(d, 2d));

		return x;
	}


	public static void cConjugate(cComplexNumber z){
		z.im = -z.im;
	}


	public static cComplexNumber cConjugateToNew(cComplexNumber z){
		cComplexNumber x;

		x = new cComplexNumber();

		x.re = z.re;
		x.im = -z.im;

		return x;
	}


	public static double cAbs(cComplexNumber z){
		double x;

		x = Sqrt(Pow(z.re, 2d) + Pow(z.im, 2d));

		return x;
	}


	public static double cArg(cComplexNumber z){
		double x;

		x = Atan2(z.im, z.re);

		return x;
	}


	public static cPolarComplexNumber cCreatePolarFromComplexNumber(cComplexNumber z){
		cPolarComplexNumber x;

		x = new cPolarComplexNumber();

		x.r = cAbs(z);
		x.phi = cArg(z);

		return x;
	}


	public static cComplexNumber cCreateComplexFromPolar(cPolarComplexNumber p){
		cComplexNumber z;

		z = new cComplexNumber();

		z.re = p.r*Cos(p.phi);
		z.im = p.r*Sin(p.phi);

		return z;
	}


	public static double cRe(cComplexNumber z){
		return z.re;
	}


	public static double cIm(cComplexNumber z){
		return z.im;
	}


	public static void cAddPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cAdd(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		p1.r = x.r;
		p1.phi = x.phi;

		delete(z1);
		delete(z2);
		delete(x);
	}


	public static cPolarComplexNumber cAddPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cAdd(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		delete(z1);
		delete(z2);

		return x;
	}


	public static void cSubPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cSub(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		p1.r = x.r;
		p1.phi = x.phi;

		delete(z1);
		delete(z2);
		delete(x);
	}


	public static cPolarComplexNumber cSubPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cSub(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		delete(z1);
		delete(z2);

		return x;
	}


	public static void cMulPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		p1.r = r1*r2;
		p1.phi = phi1 + phi2;
	}


	public static cPolarComplexNumber cMulPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		x = new cPolarComplexNumber();

		x.r = r1*r2;
		x.phi = phi1 + phi2;

		return x;
	}


	public static void cDivPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		p1.r = r1/r2;
		p1.phi = phi1 - phi2;
	}


	public static cPolarComplexNumber cDivPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		x = new cPolarComplexNumber();

		x.r = r1/r2;
		x.phi = phi1 - phi2;

		return x;
	}


	public static void cSquareRoot(cComplexNumber z){
		double a, b, m;

		a = z.re;
		b = z.im;

		m = Sqrt(Pow(a, 2d) + Pow(b, 2d));

		z.re = Sqrt((m + a)/2d);
		z.im = Sign(b)*Sqrt((m - a)/2d);
	}


	public static void cPowerPolar(cPolarComplexNumber p, double n){
		p.r = Pow(p.r, n);
		p.phi = p.phi*n;
	}


	public static cComplexNumber cPowerToNew(cComplexNumber z, double n){
		cPolarComplexNumber p;
		cComplexNumber zp;

		p = cCreatePolarFromComplexNumber(z);
		cPowerPolar(p, n);
		zp = cCreateComplexFromPolar(p);

		delete(p);

		return zp;
	}


	public static void cPower(cComplexNumber z, double n){
		cComplexNumber zp;

		zp = cPowerToNew(z, n);
		z.re = zp.re;
		z.im = zp.im;

		delete(zp);
	}


	public static void cNegate(cComplexNumber z){
		z.re = Negate(z.re);
		z.im = Negate(z.im);
	}


	public static void cAssignComplexByValues(cComplexNumber s, double re, double im){
		s.re = re;
		s.im = im;
	}


	public static void cAssignComplex(cComplexNumber a, cComplexNumber b){
		a.re = b.re;
		a.im = b.im;
	}


	public static bool cEpsilonCompareComplex(cComplexNumber a, cComplexNumber b, double epsilon){
		return EpsilonCompare(a.re, b.re, epsilon) && EpsilonCompare(a.im, b.im, epsilon);
	}


	public static void cExpComplex(cComplexNumber x){
		double re, im;

		re = Exp(x.re)*Cos(x.im);
		im = Exp(x.re)*Sin(x.im);
		x.re = re;
		x.im = im;
	}


	public static void cSineComplex(cComplexNumber x){
		double re, im;

		re = Sin(x.re)*Cosh(x.im);
		im = Cos(x.re)*Sinh(x.im);
		x.re = re;
		x.im = im;
	}


	public static void cCosineComplex(cComplexNumber x){
		double re, im;

		re = Cos(x.re)*Cosh(x.im);
		im = Sin(x.re)*Sinh(x.im);
		x.re = re;
		x.im = im;
	}


	public static char [] cComplexToString(cComplexNumber a){
		char [] str, number;
		LinkedListCharacters ll;
		double i;

		ll = CreateLinkedListCharacter();

		number = CreateStringDecimalFromNumber(a.re);

		for(i = 0d; i < number.Length; i = i + 1d){
			LinkedListAddCharacter(ll, number[(int)(i)]);
		}

		delete(number);

		if(a.im < 0d){
			LinkedListAddCharacter(ll, '-');
			number = CreateStringDecimalFromNumber(-a.im);
		}else{
			LinkedListAddCharacter(ll, '+');
			number = CreateStringDecimalFromNumber(a.im);
		}

		for(i = 0d; i < number.Length; i = i + 1d){
			LinkedListAddCharacter(ll, number[(int)(i)]);
		}

		delete(number);

		LinkedListAddCharacter(ll, 'i');

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}


	public static char [] pPolynomialToTextDirect(double [] p, char [] x){
		LinkedListCharacters ll;
		char [] str;
		double i, c, j;
		StringReference buffer;

		buffer = new StringReference();

		ll = CreateLinkedListCharacter();

		if(p.Length == 0d){
			LinkedListAddCharacter(ll, '0');
		}else{
			for(i = 0d; i < p.Length; i = i + 1d){
				c = p[(int)(i)];
				if(c < 0d){
					LinkedListAddCharacter(ll, '-');
				}else{
					LinkedListAddCharacter(ll, '+');
				}

				CreateStringFromNumberWithCheck(Abs(c), 10d, buffer);
				LinkedListCharactersAddString(ll, buffer.stringx);
				delete(buffer.stringx);

				LinkedListCharactersAddString(ll, x);
				LinkedListAddCharacter(ll, '^');

				CreateStringFromNumberWithCheck(i, 10d, buffer);
				LinkedListCharactersAddString(ll, buffer.stringx);
				delete(buffer.stringx);
			}
		}

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}


	public static void pGenerateCommonRenderSpecification(double [] p, BooleanArrayReference showCoefficient, StringReference sign, NumberArrayReference coefficient, BooleanArrayReference showPower, BooleanArrayReference showX){
		double i, zeros, c;
		bool setZero;

		setZero = false;

		if(p.Length == 0d){
			setZero = true;
		}else{
			zeros = 0d;
			for(i = 0d; i < p.Length; i = i + 1d){
				if(p[(int)(i)] == 0d){
					zeros = zeros + 1d;
				}
			}

			if(zeros == p.Length){
				setZero = true;
			}else{
				showCoefficient.booleanArray = new bool [(int)(p.Length)];
				sign.stringx = new char [(int)(p.Length)];
				coefficient.numberArray = new double [(int)(p.Length)];
				showPower.booleanArray = new bool [(int)(p.Length)];
				showX.booleanArray = new bool [(int)(p.Length)];

				for(i = 0d; i < p.Length; i = i + 1d){
					c = p[(int)(i)];

					if(c < 0d){
						sign.stringx[(int)(i)] = '-';
					}else{
						sign.stringx[(int)(i)] = '+';
					}
					coefficient.numberArray[(int)(i)] = Abs(p[(int)(i)]);
					if(c == 0d){
						showCoefficient.booleanArray[(int)(i)] = false;
					}else{
if(Abs(c) == 1d && i > 0d){
							showCoefficient.booleanArray[(int)(i)] = false;
						}else{
							showCoefficient.booleanArray[(int)(i)] = true;
						}

						if(i == 0d){
							showX.booleanArray[(int)(i)] = false;
							showPower.booleanArray[(int)(i)] = false;
						}else{
							showX.booleanArray[(int)(i)] = true;
							if(i == 1d){
								showPower.booleanArray[(int)(i)] = false;
							}else{
								showPower.booleanArray[(int)(i)] = true;
							}
						}
					}
				}
			}
		}

		if(setZero){
			showCoefficient.booleanArray = new bool [1];
			sign.stringx = new char [1];
			coefficient.numberArray = new double [1];
			showPower.booleanArray = new bool [1];
			showX.booleanArray = new bool [1];

			showCoefficient.booleanArray[0] = true;
			sign.stringx[0] = '+';
			coefficient.numberArray[0] = 0d;
			showPower.booleanArray[0] = true;
			showX.booleanArray[0] = false;
		}
	}


	public static char [] pPolynomialToText(double [] p, char [] x){
		LinkedListCharacters ll;
		char [] str;
		double i, c;
		StringReference buffer;
		BooleanArrayReference showCoefficient, showPower, showX;
		StringReference sign;
		NumberArrayReference coefficient;
		bool hasPrinted;

		showCoefficient = CreateBooleanArrayReferenceLengthValue(0d, false);
		showPower = CreateBooleanArrayReferenceLengthValue(0d, false);
		showX = CreateBooleanArrayReferenceLengthValue(0d, false);
		sign = CreateStringReferenceLengthValue(0d, ' ');
		coefficient = CreateNumberArrayReferenceLengthValue(0d, 0d);

		pGenerateCommonRenderSpecification(p, showCoefficient, sign, coefficient, showPower, showX);

		buffer = CreateStringReferenceLengthValue(0d, ' ');

		ll = CreateLinkedListCharacter();

		hasPrinted = false;
		for(i = 0d; i < showCoefficient.booleanArray.Length; i = i + 1d){
			c = p[(int)(i)];

			if(showCoefficient.booleanArray[(int)(i)] || showX.booleanArray[(int)(i)]){
				if(!hasPrinted && c >= 0d){
				}else{
					LinkedListAddCharacter(ll, sign.stringx[(int)(i)]);
				}

				if(showCoefficient.booleanArray[(int)(i)]){
					CreateStringFromNumberWithCheck(coefficient.numberArray[(int)(i)], 10d, buffer);
					LinkedListCharactersAddString(ll, buffer.stringx);
					delete(buffer.stringx);
					hasPrinted = true;
				}

				if(showX.booleanArray[(int)(i)]){
					LinkedListCharactersAddString(ll, x);
					hasPrinted = true;
					if(showPower.booleanArray[(int)(i)]){
						LinkedListAddCharacter(ll, '^');
						CreateStringFromNumberWithCheck(i, 10d, buffer);
						LinkedListCharactersAddString(ll, buffer.stringx);
						delete(buffer.stringx);
					}
				}
			}
		}

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}


	public static char [] pComplexPolynomialToTextDirect(pComplexPolynomial p, char [] x){
		LinkedListCharacters ll;
		char [] str, number;
		double i;
		cComplexNumber c;
		StringReference buffer;

		buffer = new StringReference();

		ll = CreateLinkedListCharacter();

		if(p.cs.Length == 0d){
			LinkedListAddCharacter(ll, '0');
		}else{
			for(i = 0d; i < p.cs.Length; i = i + 1d){
				c = p.cs[(int)(i)];
				if(i > 0d){
					LinkedListAddCharacter(ll, '+');
				}

				number = cComplexToString(c);
				LinkedListAddCharacter(ll, '(');
				LinkedListCharactersAddString(ll, number);
				LinkedListAddCharacter(ll, ')');
				delete(number);

				LinkedListCharactersAddString(ll, x);
				LinkedListAddCharacter(ll, '^');

				CreateStringFromNumberWithCheck(i, 10d, buffer);
				LinkedListCharactersAddString(ll, buffer.stringx);
				delete(buffer.stringx);
			}
		}

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}


	public static void pAdd(double [] a, double [] b){
		double i, nr;

		nr = b.Length;

		for(i = 0d; i < nr; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] + b[(int)(i)];
		}
	}


	public static void pSubtract(double [] a, double [] b){
		double i, nr;

		nr = b.Length;

		for(i = 0d; i < nr; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] - b[(int)(i)];
		}
	}


	public static void pMultiply(double [] c, double [] a, double [] b){
		double k, n, m, i;
		double av, bv;

		n = pDegree(a);
		m = pDegree(b);

		pFill(c, 0d);

		for(i = 0d; i <= n + m; i = i + 1d){
			c[(int)(i)] = 0d;
			for(k = 0d; k <= i && k < a.Length && i - k < b.Length; k = k + 1d){
				av = a[(int)(k)];
				bv = b[(int)(i - k)];
				c[(int)(i)] = c[(int)(i)] + av*bv;
			}
		}
	}


	public static void pDivide(double [] q, double [] r, double [] n, double [] d){
		double [] t, t1;
		double tcoff, tdegree, i;
		double deg;
		double rd, dd;

		pFill(q, 0d);
		pAssign(r, n);
		deg = pDegree(n);
		t = pCreatePolynomial(deg);
		t1 = pCreatePolynomial(deg);

		rd = pDegree(r);
		dd = pDegree(d);
		for(i = 0d; i < deg + 1d && !pIsZero(r) && rd - i >= dd; i = i + 1d){
			pFill(t, 0d);
			tdegree = rd - i - dd;
			tcoff = r[(int)(rd - i)]/d[(int)(dd)];
			t[(int)(tdegree)] = tcoff;
			pAdd(q, t);
			pFill(t1, 0d);
			pMultiply(t1, t, d);
			pSubtract(r, t1);
		}

		delete(t);
		delete(t1);
	}


	public static bool pIsZero(double [] a){
		double i;
		bool itIsZero;

		itIsZero = true;

		for(i = 0d; i < a.Length; i = i + 1d){
			if(a[(int)(i)] != 0d){
				itIsZero = false;
			}
		}

		return itIsZero;
	}


	public static void pAssign(double [] a, double [] b){
		double i, nr;

		nr = b.Length;

		for(i = 0d; i < nr; i = i + 1d){
			a[(int)(i)] = b[(int)(i)];
		}
	}


	public static double [] pCreatePolynomial(double deg){
		double [] p;

		p = new double [(int)(deg + 1d)];

		pFill(p, 0d);

		return p;
	}


	public static void pFill(double [] p, double value){
		double i;

		for(i = 0d; i < p.Length; i = i + 1d){
			p[(int)(i)] = value;
		}
	}


	public static double pDegree(double [] A){
		double i;
		double deg;
		bool done;

		done = false;
		deg = 0d;
		for(i = A.Length - 1d; i >= 0d && !done; i = i - 1d){
			if(A[(int)(i)] != 0d){
				deg = i;
				done = true;
			}
		}

		return deg;
	}


	public static double pLead(double [] A){
		double deg;

		deg = pDegree(A);

		return A[(int)(deg)];
	}


	public static double pEvaluate(double [] A, double x){
		return pEvaluateWithHornersMethod(A, x);
	}


	public static double pEvaluateWithHornersMethod(double [] A, double x){
		double r, i;

		r = 0d;

		for(i = A.Length - 1d; i >= 0d; i = i - 1d){
			r = r*x;
			r = A[(int)(i)] + r;
		}

		return r;
	}


	public static double pEvaluateWithPowers(double [] A, double x){
		double r, i;

		r = 0d;

		for(i = 0d; i < A.Length; i = i + 1d){
			r = r + A[(int)(i)]*Pow(x, i);
		}

		return r;
	}


	public static double pEvaluateDerivative(double [] A, double x, double n){
		double r, i, v;

		r = 0d;

		for(i = 0d; i < A.Length; i = i + 1d){
			if(i - n >= 0d){
				v = A[(int)(i)]*Permutations(i, n)*Pow(x, i - n);
				r = r + v;
			}
		}

		return r;
	}


	public static void pDerivative(double [] A){
		double i, degree;

		degree = 0d;
		for(i = 1d; i < A.Length; i = i + 1d){
			degree = degree + 1d;
			A[(int)(i - 1d)] = degree*A[(int)(i)];
		}

		A[(int)(A.Length - 1d)] = 0d;
	}


	public static void pAddComplex(pComplexPolynomial a, pComplexPolynomial b){
		double i, nr;

		nr = a.cs.Length;

		for(i = 0d; i < nr; i = i + 1d){
			cAdd(a.cs[(int)(i)], b.cs[(int)(i)]);
		}
	}


	public static void pSubtractComplex(pComplexPolynomial a, pComplexPolynomial b){
		double i, nr;

		nr = a.cs.Length;

		for(i = 0d; i < nr; i = i + 1d){
			cSub(a.cs[(int)(i)], b.cs[(int)(i)]);
		}
	}


	public static bool pIsZeroComplex(pComplexPolynomial a){
		double i;
		bool itIsZero;

		itIsZero = true;

		for(i = 0d; i < a.cs.Length; i = i + 1d){
			if(a.cs[(int)(i)].re != 0d && a.cs[(int)(i)].im != 0d){
				itIsZero = false;
			}
		}

		return itIsZero;
	}


	public static void pAssignComplex(pComplexPolynomial a, pComplexPolynomial b){
		double i, nr;

		nr = b.cs.Length;

		for(i = 0d; i < nr; i = i + 1d){
			cAssignComplex(a.cs[(int)(i)], b.cs[(int)(i)]);
		}
	}


	public static pComplexPolynomial pCreateComplexPolynomial(double deg){
		pComplexPolynomial p;
		double i;

		p = new pComplexPolynomial();
		p.cs = new cComplexNumber [(int)(deg + 1d)];

		for(i = 0d; i < deg + 1d; i = i + 1d){
			p.cs[(int)(i)] = new cComplexNumber();
		}

		pFillComplex(p, 0d, 0d);

		return p;
	}


	public static void pFillComplex(pComplexPolynomial p, double re, double im){
		double i;
		cComplexNumber c;

		c = cCreateComplexNumber(re, im);

		for(i = 0d; i < p.cs.Length; i = i + 1d){
			cAssignComplex(p.cs[(int)(i)], c);
		}

		delete(c);
	}


	public static double pDegreeComplex(pComplexPolynomial A){
		double i;
		double deg;
		bool done;

		done = false;
		deg = 0d;
		for(i = A.cs.Length - 1d; i >= 0d && !done; i = i - 1d){
			if(A.cs[(int)(i)].re != 0d && A.cs[(int)(i)].im != 0d){
				deg = i;
				done = true;
			}
		}

		return deg;
	}


	public static cComplexNumber pLeadComplex(pComplexPolynomial A){
		double deg;

		deg = pDegreeComplex(A);

		return A.cs[(int)(deg)];
	}


	public static cComplexNumber pEvaluateComplex(pComplexPolynomial A, cComplexNumber x){
		double i;
		cComplexNumber r, t;

		r = cCreateComplexNumber(0d, 0d);
		t = cCreateComplexNumber(0d, 0d);

		for(i = 0d; i < A.cs.Length; i = i + 1d){
			cAssignComplex(t, x);
			cPower(t, i);
			cMul(t, A.cs[(int)(i)]);
			cAdd(r, t);
		}

		return r;
	}


	public static double pTotalNumberOfRoots(double [] p){
		return pDegree(p);
	}


	public static void delete(System.Object objectx){
		// C# has garbage collection.
	}
}

