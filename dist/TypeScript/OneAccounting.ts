
// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

class Account{
	name : string [];
	endingBalance : FixedPoint15d;
	startingBalance : FixedPoint15d;
	fromx : Date;
	to : Date;
	sumDebit : FixedPoint15d;
	sumCredit : FixedPoint15d;
}
class AccountDefinition{
	accountName : string [];
	numberx : string [];
	role : string [];
	debitBalance : boolean;
}
class AccountPlan{
	accountDefinitions : AccountDefinition [];
}
class Ledger{
	decimals : number;
	transactions : Transaction [];
	accountPlan : AccountPlan;
}
class Line{
	account : string [];
	debit : FixedPoint15d;
	credit : FixedPoint15d;
	description : string [];
	date : Date;
}
class Transaction{
	lines : Line [];
}
class BooleanArrayReference{
	booleanArray : boolean [];
}
class BooleanReference{
	booleanValue : boolean;
}
class CharacterReference{
	characterValue : string;
}
class NumberArrayReference{
	numberArray : number [];
}
class NumberReference{
	numberValue : number;
}
class StringArrayReference{
	stringArray : StringReference [];
}
class StringReference{
	stringx : string [];
}
class Date{
	year : number;
	month : number;
	day : number;
}
class DateReference{
	date : Date;
}
class Interval{
	first : Date;
	last : Date;
}
class DateTimeTimezone{
	dateTime : DateTime;
	timezoneOffsetSeconds : number;
}
class DateTimeTimezoneReference{
	dateTimeTimezone : DateTimeTimezone;
}
class DateTime{
	date : Date;
	hours : number;
	minutes : number;
	seconds : number;
}
class DateTimeReference{
	dateTime : DateTime;
}
class FixedPoint30d{
	part1 : number;
	part2 : number;
	digitsBeforeDecimalPoint : number;
	digitsAfterDecimalPoint : number;
}
class FixedPoint15d{
	numberx : number;
	digitsBeforeDecimalPoint : number;
	digitsAfterDecimalPoint : number;
}
class DynamicArrayCharacters{
	array : string [];
	length : number;
}
class LinkedListNodeStrings{
	end : boolean;
	value : string [];
	next : LinkedListNodeStrings;
}
class LinkedListStrings{
	first : LinkedListNodeStrings;
	last : LinkedListNodeStrings;
}
class LinkedListNodeNumbers{
	next : LinkedListNodeNumbers;
	end : boolean;
	value : number;
}
class LinkedListNumbers{
	first : LinkedListNodeNumbers;
	last : LinkedListNodeNumbers;
}
class LinkedListCharacters{
	first : LinkedListNodeCharacters;
	last : LinkedListNodeCharacters;
}
class LinkedListNodeCharacters{
	end : boolean;
	value : string;
	next : LinkedListNodeCharacters;
}
class DynamicArrayNumbers{
	array : number [];
	length : number;
}
class Arrayx{
	array : Data [];
	length : number;
}
class Data{
	isStruture : boolean;
	isArray : boolean;
	isNumber : boolean;
	isString : boolean;
	isBoolean : boolean;
	structure : Structure;
	array : Arrayx;
	numberx : number;
	booleanxx : boolean;
	stringx : string [];
}
class DataReference{
	data : Data;
}
class Structure{
	keys : Arrayx;
	values : Arrayx;
}
	function CreateLedger(decimals : number) : Structure{
		var ledger : Structure;
		var transactions : Arrayx;

		ledger = CreateStructure();
		transactions = CreateArray();
		AddNumberToStruct(ledger, "decimals".split(''), decimals);
		AddArrayToStruct(ledger, "transactions".split(''), transactions);

		return ledger;
	}


	function CreateFixedPointForDynamicLedger(ledger : Structure) : FixedPoint15d{
		var n : FixedPoint15d;
		var d : number;

		d = GetNumberFromStruct(ledger, "decimals".split(''));
		n = CreateFixedPoint15d(15 - d, d);

		return n;
	}


	function CreateFixedPointForStaticLedger(ledger : Ledger) : FixedPoint15d{
		var n : FixedPoint15d;
		var d : number;

		d = ledger.decimals;
		n = CreateFixedPoint15d(15 - d, d);

		return n;
	}


	function CreateLine(account : string [], debit : FixedPoint15d, credit : FixedPoint15d, description : string [], date : Date) : Line{
		var t : Line;

		t = new Line();

		t.account = arraysCopyString(account);
		t.debit = Copy15d(debit);
		t.credit = Copy15d(credit);
		t.description = arraysCopyString(description);
		t.date = CopyDate(date);

		return t;
	}


	function AddTransactionToLedger(ledger : Arrayx, src : Line) : void{
		var dst : Structure;

		dst = LineToStructure(src);

		AddStructToArray(ledger, dst);
	}


	function AddTransactionsToLedger(ledger : Arrayx, ts : Line []) : void{
		var dst : Structure;
		var i : number;

		for(i = 0; i < ts.length; i = i + 1){
			dst = LineToStructure(ts[i]);
			AddStructToArray(ledger, dst);
		}
	}


	function ValidateAndAddTransactionToLedger(ledger : Structure, ls : Line []) : boolean{
		var dst : Structure;
		var i : number;
		var valid : boolean;
		var transactions : Arrayx;
		var lines : Arrayx;

		transactions = GetArrayFromStruct(ledger, "transactions".split(''));

		valid = ValidateTransaction(ls, ledger);

		if(valid){
			lines = CreateArray();

			for(i = 0; i < ls.length; i = i + 1){
				dst = LineToStructure(ls[i]);
				AddStructToArray(lines, dst);
			}

			AddArrayToArray(transactions, lines);
		}

		return valid;
	}


	function GetTransactionFromLedger(ledger : Structure, index : number) : Line{
		var dst : Structure;
		var t : Line;
		var transactions : Arrayx;
		var decimals : number;

		transactions = GetArrayFromStruct(ledger, "transactions".split(''));
		decimals = GetNumberFromStruct(ledger, "decimals".split(''));

		dst = ArrayIndexStruct(transactions, index);

		t = LineFromStructure(dst, ledger);

		return t;
	}


	function LineToStructure(src : Line) : Structure{
		var dst : Structure;
		var debitStr : string [], creditStr : string [], dateStr : string [];

		dst = CreateStructure();

		debitStr = ToString15d(src.debit);
		creditStr = ToString15d(src.credit);
		dateStr = DateToStringISO8601(src.date);

		AddStringToStruct(dst, "account".split(''), src.account);
		AddStringToStruct(dst, "debit".split(''), debitStr);
		AddStringToStruct(dst, "credit".split(''), creditStr);
		AddStringToStruct(dst, "date".split(''), dateStr);
		AddStringToStruct(dst, "description".split(''), src.description);

		return dst;
	}


	function LineFromStructure(src : Structure, ledger : Structure) : Line{
		var dst : Line;
		var account : string [], debitStr : string [], creditStr : string [], dateStr : string [], description : string [];
		var debit : FixedPoint15d, credit : FixedPoint15d;
		var date : Date;
		var debitNumber : number, creditNumber : number;

		account = GetStringFromStruct(src, "account".split(''));
		debitStr = GetStringFromStruct(src, "debit".split(''));
		creditStr = GetStringFromStruct(src, "credit".split(''));
		dateStr = GetStringFromStruct(src, "date".split(''));
		description = GetStringFromStruct(src, "description".split(''));

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


	function LedgerDynamicToStatic(src : Structure) : Ledger{
		var dst : Ledger;
		var ts : number, ls : number, i : number, j : number, decimals : number;
		var line : Structure;
		var transactions : Arrayx, lines : Arrayx;
		var sline : Line;
		var t : Transaction;

		dst = new Ledger();

		transactions = GetArrayFromStruct(src, "transactions".split(''));
		decimals = GetNumberFromStruct(src, "decimals".split(''));
		ts = ArrayLength(transactions);

		dst.decimals = decimals;
		dst.transactions = new Array<Transaction>(ts);

		for(i = 0; i < ts; i = i + 1){
			lines = ArrayIndexArray(transactions, i);
			ls = ArrayLength(lines);

			t = new Transaction();
			t.lines = new Array<Line>(ls);

			for(j = 0; j < ls; j = j + 1){
				line = ArrayIndexStruct(lines, j);
				sline = LineFromStructure(line, src);
				t.lines[j] = sline;
			}

			dst.transactions[i] = t;
		}

		return dst;
	}


	function ValidateTransaction(ts : Line [], ledger : Structure) : boolean{
		var valid : boolean;
		var creditSum : FixedPoint15d, debitSum : FixedPoint15d;
		var i : number, d : number, c : number;
		var t : Line;
		var creditStr : string [], debitStr : string [];
		var date : Date;

		valid = true;

		if(ts.length > 0){
			date = ts[0].date;

			creditSum = CreateFixedPointForDynamicLedger(ledger);
			debitSum = CreateFixedPointForDynamicLedger(ledger);

			for(i = 0; i < ts.length && valid; i = i + 1){
				t = ts[i];

				d = ToNumber15d(t.debit);
				c = ToNumber15d(t.credit);

				Add15d(creditSum, creditSum, t.credit);
				Add15d(debitSum, debitSum, t.debit);

				if(DateEquals(date, t.date) && (d == 0 || c == 0)){
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


	function ValidateTransactions(ts : Line [], invalidIds : NumberArrayReference) : boolean{
		var valid : boolean;

		/* TODO*/
		valid = true;

		return valid;
	}


	function ComputeAccountBalance(ledger : Ledger, accountName : string [], fromDate : Date, toDate : Date) : Account{
		var a : Account;
		var i : number, j : number;
		var t : Transaction;
		var ts : Transaction [];
		var l : Line;

		ts = ledger.transactions;

		a = new Account();

		a.name = arraysCopyString(accountName);
		a.endingBalance = CreateFixedPointForStaticLedger(ledger);
		a.startingBalance = CreateFixedPointForStaticLedger(ledger);
		a.fromx = CopyDate(fromDate);
		a.to = CopyDate(toDate);
		a.sumDebit = CreateFixedPointForStaticLedger(ledger);
		a.sumCredit = CreateFixedPointForStaticLedger(ledger);

		for(i = 0; i < ts.length; i = i + 1){
			t = ts[i];

			for(j = 0; j < t.lines.length; j = j + 1){
				l = t.lines[j];

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


	function AccountToString(account : Account) : string []{
		var ll : LinkedListCharacters;
		var diff : FixedPoint15d;

		ll = CreateLinkedListCharacter();

		diff = Copy15d(account.endingBalance);
		Subtract15d(diff, diff, account.startingBalance);

		LinkedListCharactersAddString(ll, account.name);
		LinkedListCharactersAddString(ll, ": ".split(''));
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.startingBalance, 2, "".split(''), ".".split('')));
		LinkedListCharactersAddString(ll, " -> ".split(''));
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.endingBalance, 2, "".split(''), ".".split('')));
		LinkedListCharactersAddString(ll, ": ".split(''));
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2, ",".split(''), ".".split('')));
		LinkedListCharactersAddString(ll, " (+".split(''));
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumDebit, 2, "".split(''), ".".split('')));
		LinkedListCharactersAddString(ll, ", -".split(''));
		LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumCredit, 2, "".split(''), ".".split('')));
		LinkedListCharactersAddString(ll, ")".split(''));

		return LinkedListCharactersToArray(ll);
	}


	function AddMonthlyAccruals(ledger : Structure, fromx : Date, to : Date, amount : number, fromAccount : string [], toAccount : string []) : void{
		var i : number;
		var accountName : string [], desc : string [];
		var amounts : number [];
		var transaction : Line [];
		var valid : boolean;
		var date : Date;
		var c : FixedPoint15d, d : FixedPoint15d;

		amounts = GetAccrualsWithDates(amount, fromx, to);

		date = CopyDate(fromx);
		date.day = 1;

		c = CreateFixedPointForDynamicLedger(ledger);
		d = CreateFixedPointForDynamicLedger(ledger);

		for(i = 0; i < amounts.length; i = i + 1){
			transaction = new Array<Line>(2);

			accountName = fromAccount;
			Assign15d(d, amounts[i]);
			Assign15d(c, 0);
			desc = "x".split('');
			transaction[0] = CreateLine(accountName, d, c, desc, date);

			accountName = toAccount;
			Assign15d(d, 0);
			Assign15d(c, amounts[i]);
			desc = "x".split('');
			transaction[1] = CreateLine(accountName, d, c, desc, date);

			valid = ValidateAndAddTransactionToLedger(ledger, transaction);

			AddMonthsToDate(date, 1);
		}
	}


	function ComputeAccountBalancePrefixAccount(ledger : Ledger, accountNr : string [], toDate : Date, debitBalance : boolean) : FixedPoint15d{
		var i : number, j : number;
		var t : Transaction;
		var ts : Transaction [];
		var l : Line;
		var balance : FixedPoint15d;
		var prefixL : LinkedListCharacters;
		var prefixed : string [];

		prefixL = CreateLinkedListCharacter();
		LinkedListCharactersAddString(prefixL, accountNr);
		LinkedListCharactersAddString(prefixL, ".".split(''));

		prefixed = LinkedListCharactersToArray(prefixL);

		ts = ledger.transactions;

		balance = CreateFixedPointForStaticLedger(ledger);

		for(i = 0; i < ts.length; i = i + 1){
			t = ts[i];

			for(j = 0; j < t.lines.length; j = j + 1){
				l = t.lines[j];

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


	function GetIFRSAccountPlan() : AccountPlan{
		var accountPlanString : string [];
		var validRef : BooleanReference;
		var ll : LinkedListCharacters;

		ll = CreateLinkedListCharacter();

		/* https://www.ifrs-gaap.com/ifrs-chart-accounts*/
		validRef = CreateBooleanReference(false);

		LinkedListCharactersAddString(ll, "1\tAssets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1\tProperty, plant and equipment\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.1\tLand and land improvements\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.2\tBuildings, structures and improvements\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.3\tMachinery and equipment\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.4\tFixtures and fittings\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.5\tRight of use assets (classified as PP&E)\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.6\tAdditional property, plant and equipment\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1.7\tConstruction in progress\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.2\tInvestment property\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.2.1\tCompleted\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.2.2\tUnder construction or development\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.3\tGoodwill\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4\tIntangible assets excluding goodwill\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.1\tIntellectual property\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.2\tComputer software\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.3\tTrade and distribution assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.4\tContracts and rights\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.5\tRight of use assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.6\tCrypto assets (classified as intangible)\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.7\tAdditional intangible assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.4.8\tAcquisition in progress\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.5\tFinancial assets and investments\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.5.1\tNon-derivative financial assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.5.2\tDerivative financial assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.5.3\tAdditional financial assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.5.4\tCrypto assets (classified as financial assets)\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.6\tInventories\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.6.1\tMerchandise\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.6.2\tRaw materials and production supplies\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.6.3\tWork in progress\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.6.4\tFinished goods\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.6.5\tOther inventories\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.7\tPrepayments and accrued income\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.7.1\tPrepayments\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.7.2\tAccrued income\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.7.3\tService provider work in process (not classified as inventory)\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.7.4\tAdditional assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.8\tReceivables and contracts\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.8.1\tLoans and receivables\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.8.2\tContracts with customers\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.8.3\tNontrade and other receivables\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.9\tTax assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.9.1\tTax assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.9.2\tDeferred tax assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.9.3\tOther tax assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.1\tAgricultural biological assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.10.1\tBearer plants\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.10.2\tAnimals\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.10.3\tOther agricultural assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.11\tCash and cash equivalents\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.11.1\tCash\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.11.2\tCash equivalents\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "1.11.3\tRestricted cash and financial assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "2\tEquity\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.1\tTotal equity attributable to owners of parent\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.1.1\tIssued capital\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.1.2\tAdditional item paid-in capital\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.1.3\tPartner\'s capital\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.1.4\tMember\'s equity\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.1.5\tOther equity interest\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.2\tRetained earnings\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.2.3\tIn suspense\tZero\n".split(''));
		LinkedListCharactersAddString(ll, "2.3\tAccumulated other comprehensive income\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.3.2\tMiscellaneous equity\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.4\tOwners equity (non-shareholder)\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "2.5\tNon-controlling interests\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3\tLiabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.1\tTrade and other payables\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.1.1\tTrade payables\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.1.2\tDividend payables\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.1.3\tInterest payable\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.1.4\tOther payables\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.2\tProvisions\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.2.1\tCustomer related provisions\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.2.2\tLitigation and regulatory\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.2.3\tAdditional provisions\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3\tOther financial liabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3.1\tNotes payable\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3.2\tLoans received\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3.3\tBonds (debentures)\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3.4\tOther debts and borrowings\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3.5\tLease obligations\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.3.6\tDerivative financial liabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.4.1\tAccruals\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.4.2\tDeferred income and refund liabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.4.3\tAccrued taxes other than payroll\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "3.4.4\tAdditional liabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4\tRevenue\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.1\tRecognized point of time\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.1.1\tGoods\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.1.2\tServices\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.2\tRecognized over time\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.2.1\tProducts and projects\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.2.2\tServices\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "4.3\tAdjustments\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "4.3.1\tVariable consideration\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "4.3.2\tConsideration paid payable to customers\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "4.3.3\tOther adjustments\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5\tExpenses\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.1\tExpenses (classified by nature)\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.1.1\tMaterial and merchandise\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.1.2\tEmployee benefits expense\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.1.3\tServices expense\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.1.4\tRent, depreciation, amortization and depletion\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "5.1.6\tOther work performed by entity and capitalized\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.2\tExpenses (classified by function)\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.2.1\tCost of sales\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "5.2.2\tSelling, general and administrative expense\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "6\tOther non-operating income and expenses\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "6.1\tOther revenue and expenses\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "6.1.1\tOther revenue\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "6.1.2\tOther expenses\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "6.2\tGains and losses\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "6.3\tTaxes other than income and payroll and fees\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "6.4\tTax income (expense)\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7\tIntercompany and related party accounts\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7.1\tIntercompany and related party assets\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "7.1.1\tIntercompany balances eliminated in consolidation\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "7.1.2\tRelated party balances reported or disclosed\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "7.1.3\tIntercompany investments\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "7.2\tIntercompany and related party liabilities\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7.2.2\tRelated party balances reported or disclosed\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7.3\tIntercompany and related party income and expense\tDr or (Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7.3.1\tIntercompany and related party income\t(Cr)\n".split(''));
		LinkedListCharactersAddString(ll, "7.3.2\tIntercompany and related party expenses\tDr\n".split(''));
		LinkedListCharactersAddString(ll, "7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n".split(''));

		accountPlanString = LinkedListCharactersToArray(ll);

		FreeLinkedListCharacter(ll);

		return ParseAccountPlanString(accountPlanString, validRef);
	}


	function ParseAccountPlanString(accountPlanString : string [], valid : BooleanReference) : AccountPlan{
		var ap : AccountPlan;
		var i : number;
		var line : string [];
		var lines : StringReference [], parts : StringReference [];
		var ad : AccountDefinition;

		ap = new AccountPlan();

		accountPlanString = strTrim(accountPlanString);
		lines = strSplitByCharacter(accountPlanString, '\n');

		ap.accountDefinitions = new Array<AccountDefinition>(lines.length);

		for(i = 0; i < lines.length; i = i + 1){
			line = lines[i].stringx;
			/*System.out.println(line);*/
			parts = strSplitByCharacter(line, '\t');

			ad = new AccountDefinition();

			ad.accountName = parts[1].stringx;
			ad.numberx = parts[0].stringx;
			if(arraysStringsEqual(parts[2].stringx, "(Cr)".split(''))){
				ad.debitBalance = false;
			}else{
				ad.debitBalance = true;
			}
			ad.role = "".split('');
			if(arraysStringsEqual(ad.numberx, "1".split(''))){
				ad.role = "Assets".split('');
			}else if(arraysStringsEqual(ad.numberx, "2".split(''))){
				ad.role = "Equities".split('');
			}else if(arraysStringsEqual(ad.numberx, "3".split(''))){
				ad.role = "Liabilities".split('');
			}else if(arraysStringsEqual(ad.numberx, "4".split(''))){
				ad.role = "Revenue".split('');
			}else if(arraysStringsEqual(ad.numberx, "5".split(''))){
				ad.role = "Expenses".split('');
			}

			ap.accountDefinitions[i] = ad;
		}

		return ap;
	}


	function ComputeAccountBalances(sledger : Ledger, depth : number, date : Date, balanceSheet : DataReference) : boolean{
		var accountPlan : AccountPlan;
		var assetsBalance : FixedPoint15d, liabilitiesBalance : FixedPoint15d, equitiesBalance : FixedPoint15d, revenueBalanace : FixedPoint15d, expensesBalance : FixedPoint15d, resultBalance : FixedPoint15d, sum : FixedPoint15d, balance : FixedPoint15d;
		var balanceStr : string [];
		var assetsDef : AccountDefinition, liabilitiesDef : AccountDefinition, equitiesDef : AccountDefinition, revenueDef : AccountDefinition, expensesDef : AccountDefinition, accountDef : AccountDefinition;
		var success : boolean, isBalanced : boolean;
		var i : number;
		var parts : StringReference [];
		var foundRef : BooleanReference;
		var accounts : Arrayx;
		var account : Structure;
		var dateStr : string [];

		balanceSheet.data = CreateNewStructData();
		success = true;

		foundRef = CreateBooleanReference(false);

		accountPlan = sledger.accountPlan;

		assetsDef = FindAccountWithRole(accountPlan, "Assets".split(''), foundRef);
		success = success && foundRef.booleanValue;
		liabilitiesDef = FindAccountWithRole(accountPlan, "Liabilities".split(''), foundRef);
		success = success && foundRef.booleanValue;
		equitiesDef = FindAccountWithRole(accountPlan, "Equities".split(''), foundRef);
		success = success && foundRef.booleanValue;
		revenueDef = FindAccountWithRole(accountPlan, "Revenue".split(''), foundRef);
		success = success && foundRef.booleanValue;
		expensesDef = FindAccountWithRole(accountPlan, "Expenses".split(''), foundRef);
		success = success && foundRef.booleanValue;

		if(success){
			assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.numberx, date, assetsDef.debitBalance);
			liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.numberx, date, liabilitiesDef.debitBalance);

			/* TODO: This must be for a period*/
			revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.numberx, date, revenueDef.debitBalance);
			expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.numberx, date, expensesDef.debitBalance);
			resultBalance = CreateFixedPointForStaticLedger(sledger);
			Subtract15d(resultBalance, revenueBalanace, expensesBalance);
			balanceStr = FormatToStringWithSymbols15d(resultBalance, 2, "".split(''), ".".split(''));
			AddStringToStruct(balanceSheet.data.structure, "result".split(''), balanceStr);

			equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.numberx, date, equitiesDef.debitBalance);
			Add15d(equitiesBalance, equitiesBalance, resultBalance);

			/* Compute accounts*/
			accounts = CreateArray();

			for(i = 0; i < accountPlan.accountDefinitions.length; i = i + 1){
				accountDef = accountPlan.accountDefinitions[i];

				parts = strSplitByCharacter(accountDef.numberx, '.');

				if(parts.length <= depth + 1){
					account = CreateStructure();

					balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.numberx, date, accountDef.debitBalance);

					balanceStr = FormatToStringWithSymbols15d(balance, 2, "".split(''), ".".split(''));

					AddStringToStruct(account, "number".split(''), accountDef.numberx);
					AddStringToStruct(account, "name".split(''), accountDef.accountName);
					AddStringToStruct(account, "balance".split(''), balanceStr);
					AddNumberToStruct(account, "depth".split(''), parts.length - 1);

					AddStructToArray(accounts, account);
				}
			}

			AddArrayToStruct(balanceSheet.data.structure, "accounts".split(''), accounts);

			/* End conclusion*/
			balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2, "".split(''), ".".split(''));
			AddStringToStruct(balanceSheet.data.structure, "assets".split(''), balanceStr);

			sum = CreateFixedPointForStaticLedger(sledger);
			Add15d(sum, liabilitiesBalance, equitiesBalance);
			balanceStr = FormatToStringWithSymbols15d(sum, 2, "".split(''), ".".split(''));
			AddStringToStruct(balanceSheet.data.structure, "liabilitiesAndEquity".split(''), balanceStr);

			isBalanced = Equals15d(sum, assetsBalance);
			AddBooleanToStruct(balanceSheet.data.structure, "balanced".split(''), isBalanced);

			dateStr = DateToStringISO8601(date);
			AddStringToStruct(balanceSheet.data.structure, "date".split(''), dateStr);
		}

		return success;
	}


	function AccountBalancesToString(balanceSheet : Structure) : string []{
		var ll : LinkedListCharacters;
		var balanceStr : string [];
		var isBalanced : boolean;
		var i : number, j : number, depth : number;
		var accounts : Arrayx;
		var account : Structure;
		var accountNumber : string [], accountName : string [];

		ll = CreateLinkedListCharacter();

		/* Print accounts*/
		accounts = GetArrayFromStruct(balanceSheet, "accounts".split(''));

		for(i = 0; i < ArrayLength(accounts); i = i + 1){
			account = ArrayIndexStruct(accounts, i);

			accountNumber = GetStringFromStruct(account, "number".split(''));
			accountName = GetStringFromStruct(account, "name".split(''));
			balanceStr = GetStringFromStruct(account, "balance".split(''));
			depth = GetNumberFromStruct(account, "depth".split(''));

			for(j = 0; j < depth; j = j + 1){
				LinkedListCharactersAddString(ll, "  ".split(''));
			}

			LinkedListCharactersAddString(ll, accountNumber);
			LinkedListCharactersAddString(ll, ". ".split(''));
			LinkedListCharactersAddString(ll, accountName);
			LinkedListCharactersAddString(ll, ": ".split(''));
			LinkedListCharactersAddString(ll, balanceStr);
			LinkedListCharactersAddString(ll, "\n".split(''));
		}

		/* End conclusion*/
		LinkedListCharactersAddString(ll, "\n".split(''));

		LinkedListCharactersAddString(ll, "Result: ".split(''));
		balanceStr = GetStringFromStruct(balanceSheet, "result".split(''));
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".split(''));

		LinkedListCharactersAddString(ll, "Assets: ".split(''));
		balanceStr = GetStringFromStruct(balanceSheet, "assets".split(''));
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".split(''));

		LinkedListCharactersAddString(ll, "Liabilities + Equities: ".split(''));
		balanceStr = GetStringFromStruct(balanceSheet, "liabilitiesAndEquity".split(''));
		LinkedListCharactersAddString(ll, balanceStr);
		LinkedListCharactersAddString(ll, "\n".split(''));

		isBalanced = GetBooleanFromStruct(balanceSheet, "balanced".split(''));
		LinkedListCharactersAddString(ll, "Balance: ".split(''));
		if(isBalanced){
			LinkedListCharactersAddString(ll, "true".split(''));
		}else{
			LinkedListCharactersAddString(ll, "false".split(''));
		}
		LinkedListCharactersAddString(ll, "\n".split(''));

		return LinkedListCharactersToArray(ll);
	}


	function FindAccountWithRole(accountPlan : AccountPlan, role : string [], foundRef : BooleanReference) : AccountDefinition{
		var i : number;
		var ad : AccountDefinition;
		var done : boolean;

		ad = new AccountDefinition();

		done = false;
		for(i = 0; i < accountPlan.accountDefinitions.length && !done; i = i + 1){
			ad = accountPlan.accountDefinitions[i];
			if(arraysStringsEqual(ad.role, role)){
				done = true;
			}
		}

		foundRef.booleanValue = done;

		return ad;
	}


	function CreateAccountDefinition(name : string [], numberx : string [], role : string [], debitBalance : boolean) : AccountDefinition{
		var def : AccountDefinition;

		def = new AccountDefinition();
		def.accountName = name;
		def.numberx = numberx;
		def.role = role;
		def.debitBalance = debitBalance;

		return def;
	}


	function ComputeBalanceDiffs(sledger : Ledger, balances : Arrayx) : void{
		var i : number, j : number;
		var balance : Structure, first : Structure, balance1 : Structure, balance2 : Structure;
		var account1 : Structure, account2 : Structure;
		var b1 : string [], b2 : string [], diffStr : string [];
		var f1 : FixedPoint15d, f2 : FixedPoint15d, diff : FixedPoint15d;
		var accountsO : Arrayx, accounts1 : Arrayx, accounts2 : Arrayx;

		first = ArrayIndexStruct(balances, 0);
		accountsO = GetArrayFromStruct(first, "accounts".split(''));

		for(j = 0; j < ArrayLength(accountsO); j = j + 1){
			for(i = 1; i < ArrayLength(balances); i = i + 1){
				balance1 = ArrayIndexStruct(balances, i - 1);
				balance2 = ArrayIndexStruct(balances, i);
				accounts1 = GetArrayFromStruct(balance1, "accounts".split(''));
				accounts2 = GetArrayFromStruct(balance2, "accounts".split(''));

				account1 = ArrayIndexStruct(accounts1, j);
				account2 = ArrayIndexStruct(accounts2, j);

				b1 = GetStringFromStruct(account1, "balance".split(''));
				b2 = GetStringFromStruct(account2, "balance".split(''));

				f1 = CreateFixedPointForStaticLedger(sledger);
				f2 = CreateFixedPointForStaticLedger(sledger);
				diff = CreateFixedPointForStaticLedger(sledger);

				Assign15d(f1, CreateNumberFromDecimalString(b1));
				Assign15d(f2, CreateNumberFromDecimalString(b2));

				Subtract15d(diff, f2, f1);

				diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".split(''), ".".split(''));

				/*System.out.println(diffStr);*/
				if(i == 1){
					AddStringToStruct(account1, "change".split(''), "0.00".split(''));
				}
				AddStringToStruct(account2, "change".split(''), diffStr);
			}
		}

		for(i = 1; i < ArrayLength(balances); i = i + 1){
			balance1 = ArrayIndexStruct(balances, i - 1);
			balance2 = ArrayIndexStruct(balances, i);
			b1 = GetStringFromStruct(balance1, "result".split(''));
			b2 = GetStringFromStruct(balance2, "result".split(''));

			f1 = CreateFixedPointForStaticLedger(sledger);
			f2 = CreateFixedPointForStaticLedger(sledger);
			diff = CreateFixedPointForStaticLedger(sledger);

			Assign15d(f1, CreateNumberFromDecimalString(b1));
			Assign15d(f2, CreateNumberFromDecimalString(b2));

			Subtract15d(diff, f2, f1);

			diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".split(''), ".".split(''));

			/*System.out.println(diffStr);*/
			if(i == 1){
				AddStringToStruct(balance1, "rchange".split(''), "0.00".split(''));
			}
			AddStringToStruct(balance2, "rchange".split(''), diffStr);
		}
	}


	function BalancesArrayToHTML(balances : Arrayx, includeBalance : boolean, includeDiff : boolean) : string []{
		var ll : LinkedListCharacters;
		var i : number, j : number;
		var balance : Structure, first : Structure;
		var dateStr : string [], name : string [], numberx : string [], balanceStr : string [], changeStr : string [];
		var account : Structure;
		var accounts : Arrayx;

		ll = CreateLinkedListCharacter();

		LinkedListCharactersAddString(ll, "<html>".split(''));
		LinkedListCharactersAddString(ll, "<body>".split(''));
		LinkedListCharactersAddString(ll, "<table>".split(''));

		/* Headers*/
		LinkedListCharactersAddString(ll, "<tr>".split(''));

		LinkedListCharactersAddString(ll, "<td>".split(''));
		LinkedListCharactersAddString(ll, "</td>".split(''));
		LinkedListCharactersAddString(ll, "<td>".split(''));
		LinkedListCharactersAddString(ll, "</td>".split(''));

		for(i = 0; i < ArrayLength(balances); i = i + 1){
			balance = ArrayIndexStruct(balances, i);
			dateStr = GetStringFromStruct(balance, "date".split(''));
			dateStr = strSubstring(dateStr, 0, 7);

			LinkedListCharactersAddString(ll, "<td>".split(''));
			LinkedListCharactersAddString(ll, dateStr);
			LinkedListCharactersAddString(ll, "</td>".split(''));
		}

		LinkedListCharactersAddString(ll, "</tr>".split(''));

		/* Each account*/
		first = ArrayIndexStruct(balances, 0);
		accounts = GetArrayFromStruct(first, "accounts".split(''));
		for(j = 0; j < ArrayLength(accounts); j = j + 1){
			LinkedListCharactersAddString(ll, "<tr>".split(''));

			account = ArrayIndexStruct(accounts, j);
			name = GetStringFromStruct(account, "name".split(''));
			numberx = GetStringFromStruct(account, "number".split(''));

			LinkedListCharactersAddString(ll, "<td>".split(''));
			LinkedListCharactersAddString(ll, numberx);
			LinkedListCharactersAddString(ll, "</td>".split(''));

			LinkedListCharactersAddString(ll, "<td>".split(''));
			LinkedListCharactersAddString(ll, name);
			LinkedListCharactersAddString(ll, "</td>".split(''));

			for(i = 0; i < ArrayLength(balances); i = i + 1){
				balance = ArrayIndexStruct(balances, i);
				accounts = GetArrayFromStruct(balance, "accounts".split(''));
				account = ArrayIndexStruct(accounts, j);
				balanceStr = GetStringFromStruct(account, "balance".split(''));
				changeStr = GetStringFromStruct(account, "change".split(''));

				LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".split(''));

				if(includeBalance && includeDiff){
					LinkedListCharactersAddString(ll, balanceStr);
					LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".split(''));
					LinkedListCharactersAddString(ll, changeStr);
					LinkedListCharactersAddString(ll, "</small>".split(''));
				}else if(includeBalance){
					LinkedListCharactersAddString(ll, balanceStr);
				}else if(includeDiff){
					LinkedListCharactersAddString(ll, changeStr);
				}

				LinkedListCharactersAddString(ll, "</td>".split(''));
			}

			LinkedListCharactersAddString(ll, "</tr>".split(''));
		}

		/* Result*/
		LinkedListCharactersAddString(ll, "<tr>".split(''));

		LinkedListCharactersAddString(ll, "<td>".split(''));
		LinkedListCharactersAddString(ll, "".split(''));
		LinkedListCharactersAddString(ll, "</td>".split(''));

		LinkedListCharactersAddString(ll, "<td>".split(''));
		LinkedListCharactersAddString(ll, "Result".split(''));
		LinkedListCharactersAddString(ll, "</td>".split(''));

		for(i = 0; i < ArrayLength(balances); i = i + 1){
			balance = ArrayIndexStruct(balances, i);
			balanceStr = GetStringFromStruct(balance, "result".split(''));
			changeStr = GetStringFromStruct(balance, "rchange".split(''));

			LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".split(''));

			if(includeBalance && includeDiff){
				LinkedListCharactersAddString(ll, balanceStr);
				LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".split(''));
				LinkedListCharactersAddString(ll, changeStr);
				LinkedListCharactersAddString(ll, "</small>".split(''));
			}else if(includeBalance){
				LinkedListCharactersAddString(ll, balanceStr);
			}else if(includeDiff){
				LinkedListCharactersAddString(ll, changeStr);
			}

			LinkedListCharactersAddString(ll, "</td>".split(''));
		}

		LinkedListCharactersAddString(ll, "</tr>".split(''));

		/* Footer*/
		LinkedListCharactersAddString(ll, "</table>".split(''));
		LinkedListCharactersAddString(ll, "</body>".split(''));
		LinkedListCharactersAddString(ll, "</html>".split(''));

		return LinkedListCharactersToArray(ll);
	}


	function CreateLineFromScript(ledger : Structure, script : string [], date : Date) : Line{
		var parts : StringReference [];
		var c : FixedPoint15d, d : FixedPoint15d;
		var line : Line;
		var i : number, n : number;

		c = CreateFixedPointForDynamicLedger(ledger);
		d = CreateFixedPointForDynamicLedger(ledger);

		parts = strSplitByCharacter(script, ',');

		for(i = 0; i < parts.length; i = i + 1){
			parts[i].stringx = strTrim(parts[i].stringx);
		}

		line = new Line();

		n = CreateNumberFromDecimalString(parts[2].stringx);

		line.date = date;
		if(arraysStringsEqual(parts[0].stringx, "Debit".split(''))){
			Assign15d(d, n);
			Assign15d(c, 0);
		}else if(arraysStringsEqual(parts[0].stringx, "Credit".split(''))){
			Assign15d(d, 0);
			Assign15d(c, n);
		}

		line = CreateLine(parts[1].stringx, d, c, parts[3].stringx, date);

		return line;
	}


	function test() : number{
		var failures : NumberReference;

		failures = CreateNumberReference(0);

		TestBasicAccounting(failures);
		TestAccruals(failures);
		TestIFRSAccountPlan(failures);

		return failures.numberValue;
	}


	function TestIFRSAccountPlan(failures : NumberReference) : void{
		GetIFRSAccountPlan();
	}


	function TestBasicAccounting(failures : NumberReference) : void{
		var ledger : Structure;
		var c : FixedPoint15d, d : FixedPoint15d;
		var transaction : Line [];
		var valid : boolean;
		var date : Date, fromx : Date, to : Date;
		var account : Account;
		var accountName : string [], accountStr : string [], desc : string [];
		var sledger : Ledger;

		ledger = CreateLedger(2);

		/*c = CreateFixedPointForDynamicLedger(ledger);*/
		/*d = CreateFixedPointForDynamicLedger(ledger);*/
		/* Transaction 1:*/
		transaction = new Array<Line>(2);
		/*date = CreateDate(2026d, 2d, 18d);*/
		date = DateFromStringISO8601("2026-02-18".split(''));

		/* Debit, 100, 1000, l1, 2026-02-18*/
		/*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
        */
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1000, 100, l1".split(''), date);

		/* Credit, 100, 2000, l2, 2026-02-18*/
		/*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
        */
		transaction[1] = CreateLineFromScript(ledger, "Credit, 2000, 100, l2".split(''), date);

		valid = ValidateAndAddTransactionToLedger(ledger, transaction);

		AssertTrue(valid, failures);

		/* Compute*/
		sledger = LedgerDynamicToStatic(ledger);

		accountName = "1000".split('');
		fromx = DateFromStringISO8601("2026-02-17".split(''));
		to = DateFromStringISO8601("2026-02-19".split(''));
		account = ComputeAccountBalance(sledger, accountName, fromx, to);

		accountStr = AccountToString(account);

		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)".split(''), failures);
	}


	function TestAccruals(failures : NumberReference) : void{
		var ledger : Structure;
		var c : FixedPoint15d, d : FixedPoint15d;
		var transaction : Line [];
		var valid : boolean, success : boolean;
		var date : Date, fromx : Date, to : Date;
		var account : Account;
		var accountName : string [], desc : string [], accountStr : string [], accountSummaryStr : string [];
		var sledger : Ledger;
		var amounts : number [];
		var i : number;
		var assetsDef : AccountDefinition, liabilitiesDef : AccountDefinition, equitiesDef : AccountDefinition, incomeDef : AccountDefinition, expensesDef : AccountDefinition, accountDef : AccountDefinition;
		var a148 : AccountDefinition, a150 : AccountDefinition, a192 : AccountDefinition, a290 : AccountDefinition, a300 : AccountDefinition, a600 : AccountDefinition;
		var accountPlan : AccountPlan;
		var balanceSheetRef : DataReference;
		var html : string [];
		var message : StringReference;
		var balances : Arrayx;

		ledger = CreateLedger(2);

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
		transaction = new Array<Line>(2);
		date = DateFromStringISO8601("2025-09-17".split(''));
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x".split(''), date);
		transaction[1] = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x".split(''), date);
		valid = ValidateAndAddTransactionToLedger(ledger, transaction);
		AssertTrue(valid, failures);

		/* Transaction: Invoice paid*/
		transaction = new Array<Line>(2);
		date = DateFromStringISO8601("2025-10-01".split(''));
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x".split(''), date);
		transaction[1] = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x".split(''), date);
		valid = ValidateAndAddTransactionToLedger(ledger, transaction);
		AssertTrue(valid, failures);

		/* Transaction: Renewal paid*/
		transaction = new Array<Line>(2);
		date = DateFromStringISO8601("2025-11-08".split(''));
		transaction[0] = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x".split(''), date);
		transaction[1] = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x".split(''), date);
		valid = ValidateAndAddTransactionToLedger(ledger, transaction);
		AssertTrue(valid, failures);

		/* Accruals income*/
		fromx = DateFromStringISO8601("2025-12-06".split(''));
		to = DateFromStringISO8601("2026-12-05".split(''));
		AddMonthlyAccruals(ledger, fromx, to, 125, "3.4.2".split(''), "4.1.2".split(''));

		/* Accruals cost*/
		fromx = DateFromStringISO8601("2025-12-06".split(''));
		to = DateFromStringISO8601("2026-12-05".split(''));
		AddMonthlyAccruals(ledger, fromx, to, 112.50, "5.1.3".split(''), "1.7.1".split(''));

		/* Compute*/
		sledger = LedgerDynamicToStatic(ledger);

		fromx = DateFromStringISO8601("2027-01-01".split(''));
		to = DateFromStringISO8601("2027-01-01".split(''));

		account = ComputeAccountBalance(sledger, "5.1.3".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "4.1.2".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "1.8.1".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "3.4.2".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "1.11.1".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "1.7.1".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

		/*System.out.println("");*/
		/* In between*/
		fromx = DateFromStringISO8601("2026-06-15".split(''));
		to = DateFromStringISO8601("2026-06-16".split(''));

		account = ComputeAccountBalance(sledger, "5.1.3".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "4.1.2".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "1.8.1".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "3.4.2".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "1.11.1".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".split(''), failures);

		account = ComputeAccountBalance(sledger, "1.7.1".split(''), fromx, to);
		accountStr = AccountToString(account);
		/*System.out.println(accountStr);*/
		AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)".split(''), failures);

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

		to = DateFromStringISO8601("2026-02-16".split(''));
		balanceSheetRef = new DataReference();
		success = ComputeAccountBalances(sledger, 2, to, balanceSheetRef);
		accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure);
		AssertTrue(success, failures);
		/*System.out.println(accountSummaryStr);*/
		/* Compute monthly table*/
		to = DateFromStringISO8601("2025-08-01".split(''));
		message = new StringReference();
		AddDaysToDate(to, -1, message);
		balances = CreateArray();
		for(i = 0; i < 12 + 6; i = i + 1){
			AddDaysToDate(to, 1, message);
			AddMonthsToDate(to, 1);
			AddDaysToDate(to, -1, message);

			balanceSheetRef = new DataReference();
			success = ComputeAccountBalances(sledger, 1, to, balanceSheetRef);

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


	function CreateBooleanReference(value : boolean) : BooleanReference{
		var ref : BooleanReference;

		ref = new BooleanReference();
		ref.booleanValue = value;

		return ref;
	}


	function CreateBooleanArrayReference(value : boolean []) : BooleanArrayReference{
		var ref : BooleanArrayReference;

		ref = new BooleanArrayReference();
		ref.booleanArray = value;

		return ref;
	}


	function CreateBooleanArrayReferenceLengthValue(length : number, value : boolean) : BooleanArrayReference{
		var ref : BooleanArrayReference;
		var i : number;

		ref = new BooleanArrayReference();
		ref.booleanArray = new Array<boolean>(length);

		for(i = 0; i < length; i = i + 1){
			ref.booleanArray[i] = value;
		}

		return ref;
	}


	function FreeBooleanArrayReference(booleanArrayReference : BooleanArrayReference) : void{
		delete booleanArrayReference.booleanArray;
		booleanArrayReference = undefined;
	}


	function CreateCharacterReference(value : string) : CharacterReference{
		var ref : CharacterReference;

		ref = new CharacterReference();
		ref.characterValue = value;

		return ref;
	}


	function CreateNumberReference(value : number) : NumberReference{
		var ref : NumberReference;

		ref = new NumberReference();
		ref.numberValue = value;

		return ref;
	}


	function CreateNumberArrayReference(value : number []) : NumberArrayReference{
		var ref : NumberArrayReference;

		ref = new NumberArrayReference();
		ref.numberArray = value;

		return ref;
	}


	function CreateNumberArrayReferenceLengthValue(length : number, value : number) : NumberArrayReference{
		var ref : NumberArrayReference;
		var i : number;

		ref = new NumberArrayReference();
		ref.numberArray = new Array<number>(length);

		for(i = 0; i < length; i = i + 1){
			ref.numberArray[i] = value;
		}

		return ref;
	}


	function FreeNumberArrayReference(numberArrayReference : NumberArrayReference) : void{
		delete numberArrayReference.numberArray;
		numberArrayReference = undefined;
	}


	function CreateStringReference(value : string []) : StringReference{
		var ref : StringReference;

		ref = new StringReference();
		ref.stringx = value;

		return ref;
	}


	function CreateStringReferenceLengthValue(length : number, value : string) : StringReference{
		var ref : StringReference;
		var i : number;

		ref = new StringReference();
		ref.stringx = new Array<string>(length);

		for(i = 0; i < length; i = i + 1){
			ref.stringx[i] = value;
		}

		return ref;
	}


	function FreeStringReference(stringReference : StringReference) : void{
		delete stringReference.stringx;
		stringReference = undefined;
	}


	function CreateStringArrayReference(strings : StringReference []) : StringArrayReference{
		var ref : StringArrayReference;

		ref = new StringArrayReference();
		ref.stringArray = strings;

		return ref;
	}


	function CreateStringArrayReferenceLengthValue(length : number, value : string []) : StringArrayReference{
		var ref : StringArrayReference;
		var i : number;

		ref = new StringArrayReference();
		ref.stringArray = new Array<StringReference>(length);

		for(i = 0; i < length; i = i + 1){
			ref.stringArray[i] = CreateStringReference(value);
		}

		return ref;
	}


	function FreeStringArrayReference(stringArrayReference : StringArrayReference) : void{
		var i : number;

		for(i = 0; i < stringArrayReference.stringArray.length; i = i + 1){
			delete stringArrayReference.stringArray[i];
		}
		delete stringArrayReference.stringArray;
		stringArrayReference = undefined;
	}


	function CreateDate(year : number, month : number, day : number) : Date{
		var date : Date;

		date = new Date();

		date.year = year;
		date.month = month;
		date.day = day;

		return date;
	}


	function IsLeapYearWithCheck(year : number, isLeapYearReference : BooleanReference, message : StringReference) : boolean{
		var itIsLeapYear : boolean;
		var success : boolean;

		if(year >= 1752){
			success = true;
			itIsLeapYear = IsLeapYear(year);
		}else{
			success = false;
			itIsLeapYear = false;
			message.stringx = "Gregorian calendar was not in general use.".split('');
		}

		isLeapYearReference.booleanValue = itIsLeapYear;
		return success;
	}


	function IsLeapYear(year : number) : boolean{
		var itIsLeapYear : boolean;

		if(DivisibleBy(year, 4)){
			if(DivisibleBy(year, 100)){
				if(DivisibleBy(year, 400)){
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


	function DayToDateWithCheck(dayNr : number, dateReference : DateReference, message : StringReference) : boolean{
		var date : Date;
		var remainder : NumberReference;
		var success : boolean;

		if(dayNr >= -79623){
			date = new Date();
			remainder = new NumberReference();
			remainder.numberValue = dayNr + 79623;
			/* Days since 1752-01-01. Day 0: Thursday, 1970-01-01*/
			/* Find year.*/
			date.year = GetYearFromDayNr(remainder.numberValue, remainder);

			/* Find month.*/
			date.month = GetMonthFromDayNr(remainder.numberValue, date.year, remainder);

			/* Find day.*/
			date.day = 1 + remainder.numberValue;

			dateReference.date = date;
			success = true;
		}else{
			success = false;
			message.stringx = "Gregorian calendar was not in general use before 1752.".split('');
		}

		return success;
	}


	function DayToDate(dayNr : number) : Date{
		var date : Date;
		var success : boolean;
		var dateRef : DateReference;
		var message : StringReference;

		dateRef = new DateReference();
		message = new StringReference();

		success = DayToDateWithCheck(dayNr, dateRef, message);
		if(success){
			date = dateRef.date;
			dateRef = undefined;
			FreeStringReference(message);
		}else{
			date = CreateDate(1970, 1, 1);
		}

		return date;
	}


	function GetMonthFromDayNrWithCheck(dayNr : number, year : number, monthReference : NumberReference, remainderReference : NumberReference, message : StringReference) : boolean{
		var month : number;
		var success : boolean;

		if(dayNr >= -79623){
			month = GetMonthFromDayNr(dayNr, year, remainderReference);
			monthReference.numberValue = month;
			success = true;
		}else{
			success = false;
			message.stringx = "Gregorian calendar not in general use before 1752.".split('');
		}

		return success;
	}


	function GetMonthFromDayNr(dayNr : number, year : number, remainderReference : NumberReference) : number{
		var daysInMonth : number [];
		var done : boolean;
		var month : number;

		daysInMonth = GetDaysInMonth(year);
		done = false;
		month = 1;

		for(; !done; ){
			if(dayNr >= daysInMonth[month]){
				dayNr = dayNr - daysInMonth[month];
				month = month + 1;
			}else{
				done = true;
			}
		}
		remainderReference.numberValue = dayNr;

		return month;
	}


	function GetYearFromDayNrWithCheck(dayNr : number, yearReference : NumberReference, remainder : NumberReference, message : StringReference) : boolean{
		var success : boolean;
		var year : number;

		if(dayNr >= 0){
			success = true;
			year = GetYearFromDayNr(dayNr, remainder);
			yearReference.numberValue = year;
		}else{
			success = false;
			message.stringx = "Day number must be 0 or higher. 0 is 1752-01-01.".split('');
		}

		return success;
	}


	function GetYearFromDayNr(dayNr : number, remainder : NumberReference) : number{
		var nrOfDays : number;
		var done : boolean;
		var year : number;

		done = false;
		year = 1752;

		for(; !done; ){
			if(IsLeapYear(year)){
				nrOfDays = 366;
			}else{
				nrOfDays = 365;
			}

			if(dayNr >= nrOfDays){
				/* First day is 0.*/
				dayNr = dayNr - nrOfDays;
				year = year + 1;
			}else{
				done = true;
			}
		}
		remainder.numberValue = dayNr;

		return year;
	}


	function DaysBetweenDates(A : Date, B : Date) : number{
		var daysA : number, daysB : number, daysBetween : number;

		daysA = DateToDays(A);
		daysB = DateToDays(B);

		daysBetween = daysB - daysA;

		return daysBetween;
	}


	function GetDaysInMonthWithCheck(year : number, daysInMonthReference : NumberArrayReference, message : StringReference) : boolean{
		var daysInMonth : number [];
		var success : boolean;
		var date : Date;

		date = CreateDate(year, 1, 1);

		success = IsValidDate(date, message);
		if(success){
			daysInMonth = GetDaysInMonth(year);

			daysInMonthReference.numberArray = daysInMonth;
		}

		return success;
	}


	function GetDaysInMonth(year : number) : number []{
		var daysInMonth : number [];

		daysInMonth = new Array<number>(1 + 12);

		daysInMonth[0] = 0;
		daysInMonth[1] = 31;

		if(IsLeapYear(year)){
			daysInMonth[2] = 29;
		}else{
			daysInMonth[2] = 28;
		}
		daysInMonth[3] = 31;
		daysInMonth[4] = 30;
		daysInMonth[5] = 31;
		daysInMonth[6] = 30;
		daysInMonth[7] = 31;
		daysInMonth[8] = 31;
		daysInMonth[9] = 30;
		daysInMonth[10] = 31;
		daysInMonth[11] = 30;
		daysInMonth[12] = 31;

		return daysInMonth;
	}


	function DateToDaysWithCheck(date : Date, dayNumberReferenceReference : NumberReference, message : StringReference) : boolean{
		var days : number;
		var success : boolean;

		success = IsValidDate(date, message);
		if(success){
			days = DateToDays(date);
			dayNumberReferenceReference.numberValue = days;
		}

		return success;
	}


	function DateToDays(date : Date) : number{
		var days : number;

		/* Day 1752-01-01*/
		days = -79623;

		days = days + DaysInYears(date.year);
		days = days + DaysInMonths(date.month, date.year);
		days = days + date.day - 1;

		return days;
	}


	function DateToWeekdayNumberWithCheck(date : Date, weekDayNumberReference : NumberReference, message : StringReference) : boolean{
		var weekDay : number;
		var success : boolean;

		success = IsValidDate(date, message);
		if(success){
			weekDay = DateToWeekdayNumber(date);
			weekDayNumberReference.numberValue = weekDay;
		}

		return success;
	}


	function DateToWeekdayNumber(date : Date) : number{
		var days : number, weekDay : number;

		days = DateToDays(date);

		days = days + 79623;
		days = days + 5;

		weekDay = days%7 + 1;

		return weekDay;
	}


	function DateToWeeknumber(date : Date, yearRef : NumberReference) : number{
		var weekNumber : number, weekday : number, days : number, daysWeek1Start : number, weekdayNewYears : number;
		var week1Start : Date, newyears : Date;

		week1Start = CopyDate(date);

		week1Start.day = 1;
		week1Start.month = 1;
		weekday = DateToWeekdayNumber(week1Start);

		/* Set week1Start to the start of the Week 1.*/
		/* If monday, week 1 begins on Jan. 1st*/
		if(weekday == 1){
			week1Start.day = 1;
		}
		/* If tuesday, week 1 begins on Dec. 31st*/
		if(weekday == 2){
			week1Start.year = week1Start.year - 1;
			week1Start.month = 12;
			week1Start.day = 31;
		}
		/* If wednesday, week 1 begins on Dec. 30th*/
		if(weekday == 3){
			week1Start.year = week1Start.year - 1;
			week1Start.month = 12;
			week1Start.day = 30;
		}
		/* If thursday, week 1 begins on Dec. 29th*/
		if(weekday == 4){
			week1Start.year = week1Start.year - 1;
			week1Start.month = 12;
			week1Start.day = 29;
		}
		/* If friday, week 1 begins on Jan. 4th*/
		if(weekday == 5){
			week1Start.day = 4;
		}
		/* If saturday, week 1 begins on Jan. 3rd*/
		if(weekday == 6){
			week1Start.day = 3;
		}
		/* If sunday, week 1 begins on Jan. 2nd*/
		if(weekday == 7){
			week1Start.day = 2;
		}

		days = DateToDays(date);
		daysWeek1Start = DateToDays(week1Start);

		if(days >= daysWeek1Start){
			weekNumber = 1 + Math.floor((days - daysWeek1Start)/7);

			if(weekNumber >= 1 && weekNumber <= 52){
				/* Week is between 1 and 52 in the current year.*/
				yearRef.numberValue = date.year;
			}else{
				/* Is week nr 53 or 1 next year?*/
				newyears = CopyDate(date);
				newyears.month = 12;
				newyears.day = 31;
				weekdayNewYears = DateToWeekdayNumber(newyears);
				if(weekdayNewYears == 1 || weekdayNewYears == 2 || weekdayNewYears == 3){
					/* Week 1 next year.*/
					weekNumber = 1;
					yearRef.numberValue = date.year + 1;
				}else{
					/* Week 53*/
					yearRef.numberValue = date.year;
				}
				newyears = undefined;
			}
		}else{
			/* Week is in previous year. Either 52nd or 53rd.*/
			newyears = CopyDate(date);
			newyears.month = 12;
			newyears.day = 31;
			newyears.year = date.year - 1;
			weekNumber = DateToWeeknumber(newyears, yearRef);
			newyears = undefined;
		}

		week1Start = undefined;

		return weekNumber;
	}


	function DaysInMonthsWithCheck(month : number, year : number, daysInMonthsReference : NumberReference, message : StringReference) : boolean{
		var days : number;
		var success : boolean;
		var date : Date;

		date = CreateDate(year, month, 1);

		success = IsValidDate(date, message);
		if(success){
			days = DaysInMonths(month, year);

			daysInMonthsReference.numberValue = days;
		}

		return success;
	}


	function DaysInMonths(month : number, year : number) : number{
		var daysInMonth : number [];
		var days : number;
		var i : number;

		daysInMonth = GetDaysInMonth(year);

		days = 0;
		for(i = 1; i < month; i = i + 1){
			days = days + daysInMonth[i];
		}

		return days;
	}


	function DaysInYearsWithCheck(years : number, daysReference : NumberReference, message : StringReference) : boolean{
		var days : number;
		var success : boolean;
		var date : Date;

		date = CreateDate(years, 1, 1);

		success = IsValidDate(date, message);
		if(success){
			days = DaysInYears(years);
			daysReference.numberValue = days;
		}

		return success;
	}


	function DaysInYears(years : number) : number{
		var days : number;
		var i : number;
		var nrOfDays : number;

		days = 0;
		for(i = 1752; i < years; i = i + 1){
			if(IsLeapYear(i)){
				nrOfDays = 366;
			}else{
				nrOfDays = 365;
			}
			days = days + nrOfDays;
		}

		return days;
	}


	function IsValidDate(date : Date, message : StringReference) : boolean{
		var valid : boolean;
		var daysInMonth : number [];
		var daysInThisMonth : number;

		if(date.year >= 1752){
			if(date.month >= 1 && date.month <= 12){
				daysInMonth = GetDaysInMonth(date.year);
				daysInThisMonth = daysInMonth[date.month];
				if(date.day >= 1 && date.day <= daysInThisMonth){
					valid = true;
				}else{
					valid = false;
					message.stringx = "The month does not have the given day number.".split('');
				}
			}else{
				valid = false;
				message.stringx = "Month must be between 1 and 12, inclusive.".split('');
			}
		}else{
			valid = false;
			message.stringx = "Gregorian calendar was not in general use before 1752.".split('');
		}

		return valid;
	}


	function AddDaysToDate(date : Date, days : number, message : StringReference) : boolean{
		var n : number;
		var success : boolean;
		var dateReference : DateReference;
		var daysRef : NumberReference;

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


	function AssignDate(a : Date, b : Date) : void{
		a.year = b.year;
		a.month = b.month;
		a.day = b.day;
	}


	function AddMonthsToDate(date : Date, months : number) : void{
		var i : number;

		if(months > 0){
			for(i = 0; i < months; i = i + 1){
				date.month = date.month + 1;

				if(date.month == 13){
					date.month = 1;
					date.year = date.year + 1;
				}
			}
		}
		if(months < 0){
			for(i = 0; i < -months; i = i + 1){
				date.month = date.month - 1;

				if(date.month == 0){
					date.month = 12;
					date.year = date.year - 1;
				}
			}
		}
	}


	function DateToStringISO8601WithCheck(date : Date, datestr : StringReference, message : StringReference) : boolean{
		var success : boolean;

		success = IsValidDate(date, message);

		if(success){
			if(date.year <= 9999){
				datestr.stringx = DateToStringISO8601(date);
			}else{
				message.stringx = "This library works from 1752 to 9999.".split('');
			}
		}

		return success;
	}


	function DateToStringISO8601(date : Date) : string []{
		var str : string [];

		str = new Array<string>(10);

		str[0] = cDecimalDigitToCharacter(Math.floor(date.year/1000));
		str[1] = cDecimalDigitToCharacter(Math.floor((date.year%1000)/100));
		str[2] = cDecimalDigitToCharacter(Math.floor((date.year%100)/10));
		str[3] = cDecimalDigitToCharacter(Math.floor(date.year%10));

		str[4] = '-';

		str[5] = cDecimalDigitToCharacter(Math.floor((date.month%100)/10));
		str[6] = cDecimalDigitToCharacter(Math.floor(date.month%10));

		str[7] = '-';

		str[8] = cDecimalDigitToCharacter(Math.floor((date.day%100)/10));
		str[9] = cDecimalDigitToCharacter(Math.floor(date.day%10));

		return str;
	}


	function DateFromStringISO8601(str : string []) : Date{
		var date : Date;
		var n : number;

		date = new Date();

		n = cCharacterToDecimalDigit(str[0])*1000;
		n = n + cCharacterToDecimalDigit(str[1])*100;
		n = n + cCharacterToDecimalDigit(str[2])*10;
		n = n + cCharacterToDecimalDigit(str[3])*1;

		date.year = n;

		n = cCharacterToDecimalDigit(str[5])*10;
		n = n + cCharacterToDecimalDigit(str[6])*1;

		date.month = n;

		n = cCharacterToDecimalDigit(str[8])*10;
		n = n + cCharacterToDecimalDigit(str[9])*1;

		date.day = n;

		return date;
	}


	function DateFromStringISO8601WithCheck(str : string [], dateRef : DateReference, message : StringReference) : boolean{
		var valid : boolean;

		valid = IsValidDateISO8601(str, message);

		if(valid){
			dateRef.date = DateFromStringISO8601(str);
		}

		return valid;
	}


	function IsValidDateISO8601(str : string [], message : StringReference) : boolean{
		var valid : boolean;

		if(str.length == 4 + 1 + 2 + 1 + 2){

			if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9])){
				if(str[4] == '-' && str[7] == '-'){
					valid = true;
				}else{
					valid = false;
					message.stringx = "ISO8601 date must use \'-\' in positions 5 and 8.".split('');
				}
			}else{
				valid = false;
				message.stringx = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.".split('');
			}
		}else{
			valid = false;
			message.stringx = "ISO8601 date must be exactly 10 characters long.".split('');
		}

		return valid;
	}


	function DateEquals(a : Date, b : Date) : boolean{
		return a.year == b.year && a.month == b.month && a.day == b.day;
	}


	function CopyDate(a : Date) : Date{
		var b : Date;

		b = CreateDate(a.year, a.month, a.day);

		return b;
	}


	function GetSecondsFromDate(date : Date) : number{
		var seconds : number, days : number, secondsInMinute : number, secondsInHour : number, secondsInDay : number;
		var dayNumberReferenceReference : NumberReference;
		var message : StringReference;
		var success : boolean;

		seconds = 0;
		dayNumberReferenceReference = new NumberReference();
		message = new StringReference();

		success = DateToDaysWithCheck(date, dayNumberReferenceReference, message);
		if(success){
			days = dayNumberReferenceReference.numberValue;

			secondsInMinute = 60;
			secondsInHour = 60*secondsInMinute;
			secondsInDay = 24*secondsInHour;

			seconds = seconds + secondsInDay*days;
		}

		dayNumberReferenceReference = undefined;
		message = undefined;

		return seconds;
	}


	function DateIsInInterval(interval : Interval, date : Date) : boolean{
		var fromx : number, to : number, day : number;

		fromx = DateToDays(interval.first);
		to = DateToDays(interval.last);
		day = DateToDays(date);

		return day >= fromx && day <= to;
	}


	function DateLessThan(a : Date, b : Date) : boolean{
		var aDays : number, bDays : number;

		aDays = DateToDays(a);
		bDays = DateToDays(b);

		return aDays < bDays;
	}


	function CreateDateTimeTimezone(year : number, month : number, day : number, hours : number, minutes : number, seconds : number, timezoneOffsetSeconds : number) : DateTimeTimezone{
		var dateTimeTimezone : DateTimeTimezone;

		dateTimeTimezone = new DateTimeTimezone();

		dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

		return dateTimeTimezone;
	}


	function CreateDateTimeTimezoneInHoursAndMinutes(year : number, month : number, day : number, hours : number, minutes : number, seconds : number, timezoneOffsetHours : number, timezoneOffsetMinutes : number) : DateTimeTimezone{
		var dateTimeTimezone : DateTimeTimezone;

		dateTimeTimezone = new DateTimeTimezone();

		dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
		dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes);

		return dateTimeTimezone;
	}


	function GetDateFromDateTimeTimeZone(dateTimeTimezone : DateTimeTimezone, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		var dateTime : DateTime;

		dateTime = dateTimeTimezone.dateTime;

		return AddSecondsToDateTimeWithCheck(dateTime, -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message);
	}


	function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime : DateTime, timezoneOffsetSeconds : number, dateTimeTimezoneReference : DateTimeTimezoneReference, message : StringReference) : boolean{
		var success : boolean;
		var adjustedDateTimeReference : DateTimeReference;
		var dateTimeTimezone : DateTimeTimezone;

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


	function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(dateTime : DateTime, timezoneOffsetHours : number, timezoneOffsetMinutes : number, dateTimeTimezoneReference : DateTimeTimezoneReference, message : StringReference) : boolean{
		return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message);
	}


	function GetDateTimeTimezoneFromSeconds(dateTimeTzRef : DateTimeTimezoneReference, seconds : number, offset : number, message : StringReference) : boolean{
		var success : boolean;
		var dateTimeRef : DateTimeReference;

		dateTimeRef = new DateTimeReference();
		success = GetDateTimeFromSeconds(seconds, dateTimeRef, message);

		if(success){
			success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTime, offset, dateTimeTzRef, message);
		}

		return success;
	}


	function CreateDateTime(year : number, month : number, day : number, hours : number, minutes : number, seconds : number) : DateTime{
		var dateTime : DateTime;

		dateTime = new DateTime();

		dateTime.date = CreateDate(year, month, day);
		dateTime.hours = hours;
		dateTime.minutes = minutes;
		dateTime.seconds = seconds;

		return dateTime;
	}


	function GetDateTimeFromSeconds(seconds : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		var dateTime : DateTime;
		var secondsInMinute : number, secondsInHour : number, secondsInDay : number, days : number, remainder : number;
		var date : Date;
		var dateReference : DateReference;
		var success : boolean;

		secondsInMinute = 60;
		secondsInHour = 60*secondsInMinute;
		secondsInDay = 24*secondsInHour;
		days = Math.floor(seconds/secondsInDay);
		remainder = seconds - days*secondsInDay;
		dateReference = new DateReference();

		success = DayToDateWithCheck(days, dateReference, message);
		if(success){
			date = dateReference.date;

			dateTime = new DateTime();
			dateTime.date = date;
			dateTime.hours = Math.floor(remainder/secondsInHour);
			remainder = remainder - dateTime.hours*secondsInHour;
			dateTime.minutes = Math.floor(remainder/secondsInMinute);
			remainder = remainder - dateTime.minutes*secondsInMinute;
			dateTime.seconds = remainder;

			dateTimeReference.dateTime = dateTime;
		}

		return success;
	}


	function GetSecondsFromDateTime(dateTime : DateTime) : number{
		var seconds : number, secondsInMinute : number, secondsInHour : number;

		secondsInMinute = 60;
		secondsInHour = 60*secondsInMinute;

		seconds = GetSecondsFromDate(dateTime.date);
		seconds = seconds + secondsInHour*dateTime.hours;
		seconds = seconds + secondsInMinute*dateTime.minutes;
		seconds = seconds + dateTime.seconds;

		return seconds;
	}


	function GetSecondsFromMinutes(minutes : number) : number{
		return minutes*60;
	}


	function GetSecondsFromHours(hours : number) : number{
		return GetSecondsFromMinutes(hours*60);
	}


	function GetSecondsFromDays(days : number) : number{
		return GetSecondsFromHours(days*24);
	}


	function GetSecondsFromWeeks(weeks : number) : number{
		return GetSecondsFromDays(weeks*7);
	}


	function GetMinutesFromSeconds(seconds : number) : number{
		return seconds/60;
	}


	function GetHoursFromSeconds(seconds : number) : number{
		return GetMinutesFromSeconds(seconds)/60;
	}


	function GetDaysFromSeconds(seconds : number) : number{
		return GetHoursFromSeconds(seconds)/24;
	}


	function GetWeeksFromSeconds(seconds : number) : number{
		return GetDaysFromSeconds(seconds)/7;
	}


	function GetDateFromDateTime(dateTime : DateTime) : Date{
		return dateTime.date;
	}


	function AddSecondsToDateTimeWithCheck(dateTime : DateTime, seconds : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		var secondsInDateTime : number;
		var success : boolean;

		if(IsValidDateTime(dateTime, message)){
			secondsInDateTime = GetSecondsFromDateTime(dateTime);
			secondsInDateTime = secondsInDateTime + seconds;

			success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
		}else{
			success = false;
		}

		return success;
	}


	function AddSecondsToDateTime(dateTime : DateTime, seconds : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		var secondsInDateTime : number;

		secondsInDateTime = GetSecondsFromDateTime(dateTime);
		secondsInDateTime = secondsInDateTime + seconds;

		return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
	}


	function AddMinutesToDateTime(dateTime : DateTime, minutes : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message);
	}


	function AddHoursToDateTime(dateTime : DateTime, hours : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message);
	}


	function AddDaysToDateTime(dateTime : DateTime, days : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message);
	}


	function AddWeeksToDateTime(dateTime : DateTime, weeks : number, dateTimeReference : DateTimeReference, message : StringReference) : boolean{
		return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message);
	}


	function DateTimeToStringISO8601WithCheck(datetime : DateTime, dateStr : StringReference, message : StringReference) : boolean{
		var success : boolean;

		success = DateToStringISO8601WithCheck(datetime.date, dateStr, message);

		if(success){
			delete dateStr.stringx;

			success = IsValidDateTime(datetime, message);
			if(success){
				dateStr.stringx = DateTimeToStringISO8601(datetime);
			}
		}

		return success;
	}


	function IsValidDateTime(datetime : DateTime, message : StringReference) : boolean{
		var success : boolean;

		success = IsValidDate(datetime.date, message);

		if(success){
			if(datetime.hours <= 23 && datetime.hours >= 0){
				if(datetime.minutes <= 59 && datetime.minutes >= 0){
					if(datetime.seconds <= 59 && datetime.seconds >= 0){
						success = true;
					}else{
						success = false;
						message.stringx = "Seconds must be between 0 and 59.".split('');
					}
				}else{
					success = false;
					message.stringx = "Minutes must be between 0 and 59.".split('');
				}
			}else{
				success = false;
				message.stringx = "Hours must be between 0 and 23.".split('');
			}
		}

		return success;
	}


	function DateTimeToStringISO8601(datetime : DateTime) : string []{
		var datestr : string [], str : string [];
		var i : number;

		str = new Array<string>(19);

		datestr = DateToStringISO8601(datetime.date);
		for(i = 0; i < datestr.length; i = i + 1){
			str[i] = datestr[i];
		}

		str[10] = 'T';
		str[11] = cDecimalDigitToCharacter(Math.floor((datetime.hours%100)/10));
		str[12] = cDecimalDigitToCharacter(Math.floor(datetime.hours%10));

		str[13] = ':';

		str[14] = cDecimalDigitToCharacter(Math.floor((datetime.minutes%100)/10));
		str[15] = cDecimalDigitToCharacter(Math.floor(datetime.minutes%10));

		str[16] = ':';

		str[17] = cDecimalDigitToCharacter(Math.floor((datetime.seconds%100)/10));
		str[18] = cDecimalDigitToCharacter(Math.floor(datetime.seconds%10));

		return str;
	}


	function DateTimeFromStringISO8601(str : string []) : DateTime{
		var dateTime : DateTime;
		var n : number;

		dateTime = new DateTime();

		dateTime.date = DateFromStringISO8601(str);

		n = cCharacterToDecimalDigit(str[11])*10;
		n = n + cCharacterToDecimalDigit(str[12])*1;

		dateTime.hours = n;

		n = cCharacterToDecimalDigit(str[14])*10;
		n = n + cCharacterToDecimalDigit(str[15])*1;

		dateTime.minutes = n;

		n = cCharacterToDecimalDigit(str[17])*10;
		n = n + cCharacterToDecimalDigit(str[18])*1;

		dateTime.seconds = n;

		return dateTime;
	}


	function DateTimeFromStringISO8601WithCheck(str : string [], dateTimeRef : DateTimeReference, message : StringReference) : boolean{
		var valid : boolean;

		valid = IsValidDateTimeISO8601(str, message);

		if(valid){
			dateTimeRef.dateTime = DateTimeFromStringISO8601(str);
		}

		return valid;
	}


	function IsValidDateTimeISO8601(str : string [], message : StringReference) : boolean{
		var valid : boolean;

		if(str.length == 4 + 1 + 2 + 1 + 2 + 1 + 2 + 1 + 2 + 1 + 2){

			if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9]) && cIsNumber(str[11]) && cIsNumber(str[12]) && cIsNumber(str[14]) && cIsNumber(str[15]) && cIsNumber(str[17]) && cIsNumber(str[18])){
				if(str[4] == '-' && str[7] == '-' && str[10] == 'T' && str[13] == ':' && str[16] == ':'){
					valid = true;
				}else{
					valid = false;
					message.stringx = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.".split('');
				}
			}else{
				valid = false;
				message.stringx = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.".split('');
			}
		}else{
			valid = false;
			message.stringx = "ISO8601 date must be exactly 19 characters long.".split('');
		}

		return valid;
	}


	function DateTimeEquals(a : DateTime, b : DateTime) : boolean{
		return DateEquals(a.date, b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds;
	}


	function FreeDateTime(datetime : DateTime) : void{
		delete datetime.date;
		datetime = undefined;
	}


	function CreateFixedPoint30d(digitsBeforeDecimalPoint : number, digitsAfterDecimalPoint : number) : FixedPoint30d{
		var fp : FixedPoint30d;

		fp = new FixedPoint30d();
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
		fp.part1 = 0;
		fp.part2 = 0;

		return fp;
	}


	function CreateFixedPoint15d(digitsBeforeDecimalPoint : number, digitsAfterDecimalPoint : number) : FixedPoint15d{
		var fp : FixedPoint15d;

		fp = new FixedPoint15d();
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
		fp.numberx = 0;

		return fp;
	}


	function ToNumber15d(n : FixedPoint15d) : number{
		return n.numberx;
	}


	function Number15d(numberx : number) : FixedPoint15d{
		var fp : FixedPoint15d;

		fp = new FixedPoint15d();
		fp.digitsBeforeDecimalPoint = 7;
		fp.digitsAfterDecimalPoint = 7;
		fp.numberx = numberx;

		return fp;
	}


	function Assign15d(fp : FixedPoint15d, numberx : number) : boolean{
		var success : boolean;

		success = !WillOverflow15d(fp, numberx);
		success = success && FixedPointIsValid15d(fp);

		if(success){
			fp.numberx = numberx;
			fp.numberx = RoundToDigits(fp.numberx, fp.digitsAfterDecimalPoint);
		}

		return success;
	}


	function Assign15dFloor(fp : FixedPoint15d, numberx : number) : boolean{
		var success : boolean;

		success = !WillOverflow15d(fp, numberx);
		success = success && FixedPointIsValid15d(fp);

		if(success){
			fp.numberx = numberx;
			fp.numberx = FloorToDigits(fp.numberx, fp.digitsAfterDecimalPoint);
		}

		return success;
	}


	function FixedPointIsValid15d(fp : FixedPoint15d) : boolean{
		var valid : boolean;

		if(IsInteger(fp.digitsAfterDecimalPoint) && IsInteger(fp.digitsBeforeDecimalPoint)){
			if(fp.digitsBeforeDecimalPoint >= 0 && fp.digitsBeforeDecimalPoint <= 15){
				if(fp.digitsAfterDecimalPoint >= 0 && fp.digitsAfterDecimalPoint <= 15){
					if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15){
						if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0){
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


	function WillOverflow15d(fp : FixedPoint15d, numberx : number) : boolean{
		var overflow : boolean;

		if(Math.abs(numberx) < 10**fp.digitsBeforeDecimalPoint){
			overflow = false;
		}else{
			overflow = true;
		}

		return overflow;
	}


	function FloorToDigits(value : number, digits : number) : number{
		return Math.floor(value*10**digits)/10**digits;
	}


	function ToString15d(fp : FixedPoint15d) : string []{
		var stringx : string [];
		var digits : number;
		var digitPosition : number;
		var i : number, d : number, decimal : number;
		var characterReference : CharacterReference;

		stringx = new Array<string>(1 + fp.digitsBeforeDecimalPoint + 1 + fp.digitsAfterDecimalPoint);

		decimal = fp.numberx*10**fp.digitsAfterDecimalPoint;

		if(decimal < 0){
			decimal = -decimal;
			stringx[0] = '-';
		}else{
			stringx[0] = '+';
		}

		decimal = Round(decimal);

		characterReference = new CharacterReference();

		digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint;
		digitPosition = 1;

		for(i = 0; i < digits; i = i + 1){
			if(i == fp.digitsBeforeDecimalPoint){
				stringx[digitPosition] = '.';

				digitPosition = digitPosition + 1;
			}

			d = Math.floor(decimal/10**(digits - i - 1));
			d = d%10;

			GetSingleDigitCharacterFromNumberWithCheck(d, 10, characterReference);
			stringx[digitPosition] = characterReference.characterValue;

			digitPosition = digitPosition + 1;
		}

		characterReference = undefined;

		return stringx;
	}


	function Add15d(a : FixedPoint15d, b : FixedPoint15d, c : FixedPoint15d) : boolean{
		return Assign15d(a, b.numberx + c.numberx);
	}


	function Subtract15d(a : FixedPoint15d, b : FixedPoint15d, c : FixedPoint15d) : boolean{
		return Assign15d(a, b.numberx - c.numberx);
	}


	function Multiply15d(a : FixedPoint15d, b : FixedPoint15d, c : FixedPoint15d) : boolean{
		return Assign15d(a, b.numberx*c.numberx);
	}


	function DivideFloored15d(q : FixedPoint15d, r : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var success : boolean;
		var x : number, xDivisor : number, xDividend : number;
		var t : FixedPoint15d;

		t = Copy15d(r);

		if(b.numberx != 0){
			xDivisor = Round(a.numberx*10**q.digitsAfterDecimalPoint*10**q.digitsAfterDecimalPoint);
			xDividend = Round(b.numberx*10**q.digitsAfterDecimalPoint);
			x = Math.floor(xDivisor/xDividend);
			x = x/10**q.digitsAfterDecimalPoint;
			success = Assign15d(q, x);
			Multiply15d(t, q, b);
			Subtract15d(r, a, t);
		}else{
			success = false;
		}

		t = undefined;

		return success;
	}


	function Copy15d(r : FixedPoint15d) : FixedPoint15d{
		var t : FixedPoint15d;

		t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint);
		t.numberx = r.numberx;

		return t;
	}


	function Negate15d(a : FixedPoint15d) : void{
		a.numberx = -a.numberx;
	}


	function Positive15d(a : FixedPoint15d) : void{
		a.numberx = +a.numberx;
	}


	function Factorial15d(x : FixedPoint15d) : boolean{
		var success : boolean;

		if(x.numberx >= 0){
			success = Assign15d(x, Factorial(x.numberx));
		}else{
			success = false;
		}

		return success;
	}


	function Round15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Round(x.numberx));
	}


	function BankersRound15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, BankersRound(x.numberx));
	}


	function Ceil15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Ceil(x.numberx));
	}


	function Floor15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Math.floor(x.numberx));
	}


	function Truncate15d(x : FixedPoint15d) : void{
		x.numberx = Truncate(x.numberx);
	}


	function Absolute15d(x : FixedPoint15d) : void{
		x.numberx = Math.abs(x.numberx);
	}


	function Logarithm15d(x : FixedPoint15d) : boolean{
		var success : boolean;

		if(x.numberx > 0){
			success = Assign15d(x, Logarithm(x.numberx));
		}else{
			success = false;
		}

		return success;
	}


	function NaturalLogarithm15d(x : FixedPoint15d) : boolean{
		var success : boolean;

		if(x.numberx > 0){
			success = Assign15d(x, NaturalLogarithm(x.numberx));
		}else{
			success = false;
		}

		return success;
	}


	function Sin15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Sin(x.numberx));
	}


	function Cos15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Cos(x.numberx));
	}


	function Tan15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Tan(x.numberx));
	}


	function Asin15d(x : FixedPoint15d) : boolean{
		var success : boolean;

		if(x.numberx >= -1 && x.numberx <= 1){
			success = Assign15d(x, Asin(x.numberx));
		}else{
			success = false;
		}

		return success;
	}


	function Acos15d(x : FixedPoint15d) : boolean{
		var success : boolean;

		if(x.numberx >= -1 && x.numberx <= 1){
			success = Assign15d(x, Acos(x.numberx));
		}else{
			success = false;
		}

		return success;
	}


	function Atan15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Atan(x.numberx));
	}


	function Atan2_15d(a : FixedPoint15d, y : FixedPoint15d, x : FixedPoint15d) : boolean{
		return Assign15d(a, Atan2(y.numberx, x.numberx));
	}


	function Squareroot15d(x : FixedPoint15d) : boolean{
		var success : boolean;

		if(x.numberx >= 0){
			success = Assign15d(x, Math.sqrt(x.numberx));
		}else{
			success = false;
		}

		return success;
	}


	function Exp15d(x : FixedPoint15d) : boolean{
		return Assign15d(x, Exp(x.numberx));
	}


	function DivisibleBy15d(a : FixedPoint15d, b : FixedPoint15d) : boolean{
		return ((a.numberx%b.numberx) == 0);
	}


	function Combinations15d(x : FixedPoint15d, n : FixedPoint15d, k : FixedPoint15d) : boolean{
		var success : boolean;

		if(IsInteger(n.numberx) && IsInteger(k.numberx)){
			if(n.numberx >= 1 && k.numberx >= 0 && n.numberx >= k.numberx){
				success = Assign15d(x, Combinations(n.numberx, k.numberx));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	function Permutations15d(x : FixedPoint15d, n : FixedPoint15d, k : FixedPoint15d) : boolean{
		var success : boolean;

		if(IsInteger(n.numberx) && IsInteger(k.numberx)){
			if(n.numberx >= 1 && k.numberx >= 0 && n.numberx >= k.numberx){
				success = Assign15d(x, Permutations(n.numberx, k.numberx));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	function Equals15d(a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var p : number, an : number, bn : number;
		var equals : boolean;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		p = Math.max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint);

		equals = EpsilonCompare(an, bn, 10**(-p));

		return equals;
	}


	function GreaterThan15d(a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var an : number, bn : number;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		return an > bn;
	}


	function LessThan15d(a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var an : number, bn : number;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		return an < bn;
	}


	function GreaterThanOrEqual15d(a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var an : number, bn : number;
		var equal : boolean;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		equal = Equals15d(a, b);

		return an > bn || equal;
	}


	function LessThanOrEqual15d(a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var an : number, bn : number;
		var equal : boolean;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		equal = Equals15d(a, b);

		return an < bn || equal;
	}


	function EpsilonCompare15d(a : FixedPoint15d, b : FixedPoint15d, epsilon : FixedPoint15d) : boolean{
		return EpsilonCompare(a.numberx, b.numberx, epsilon.numberx);
	}


	function GreatestCommonDivisor15d(x : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var success : boolean;

		if(IsInteger(a.numberx) && IsInteger(b.numberx)){
			if(a.numberx >= 0 && b.numberx >= 0){
				success = Assign15d(x, GreatestCommonDivisor(a.numberx, b.numberx));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	function GCDWithSubtraction15d(x : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var success : boolean;

		if(IsInteger(a.numberx) && IsInteger(b.numberx)){
			if(a.numberx >= 0 && b.numberx >= 0){
				success = Assign15d(x, GCDWithSubtraction(a.numberx, b.numberx));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	function IsInteger15d(a : FixedPoint15d) : boolean{
		return IsInteger(a.numberx);
	}


	function LeastCommonMultiple15d(x : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var success : boolean;

		if(IsInteger(a.numberx) && IsInteger(b.numberx)){
			if(a.numberx != 0 && b.numberx != 0){
				success = Assign15d(x, LeastCommonMultiple(a.numberx, b.numberx));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	function Sign15d(a : FixedPoint15d) : number{
		return Sign(a.numberx);
	}


	function Max15d(x : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		return Assign15d(x, Max(a.numberx, b.numberx));
	}


	function Min15d(x : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		return Assign15d(x, Min(a.numberx, b.numberx));
	}


	function Power15d(x : FixedPoint15d, a : FixedPoint15d, b : FixedPoint15d) : boolean{
		var success : boolean;

		if(a.numberx != 0 || b.numberx != 0){
			if(!(a.numberx < 0 && !IsInteger(b.numberx))){
				success = Assign15d(x, Power(a.numberx, b.numberx));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}


	function FormatToString15d(fp : FixedPoint15d, digitsAfter : number) : string []{
		var result : string [];

		result = FormatToStringWithSymbols15d(fp, digitsAfter, "".split(''), ".".split(''));

		return result;
	}


	function FormatToStringWithSymbols15d(fp : FixedPoint15d, digitsAfter : number, thousandsSeparator : string [], decimalPoint : string []) : string []{
		var stringx : string [];
		var i : number, j : number, p : number, d : number, t : number, sign : number, extra : number, decimal : number, digits : number, digitsBefore : number, thousandsChars : number, thousandsTimes : number, decimalPointChars : number;
		var characterReference : CharacterReference;

		characterReference = new CharacterReference();

		decimal = Round(fp.numberx*10**digitsAfter);

		sign = 0;
		if(decimal < 0){
			sign = 1;
			decimal = -decimal;
		}

		if(decimal != 0){
			digits = Math.floor(Math.log10(decimal) + 1);
		}else{
			digits = 1;
		}
		digitsBefore = digits - digitsAfter;

		if(digitsBefore <= 0){
			digitsBefore = 0;
			thousandsTimes = 0;
			digits = digitsAfter + 1;
		}else{
			thousandsTimes = Math.floor((digitsBefore - 1)/3);
		}
		thousandsChars = thousandsTimes*thousandsSeparator.length;

		if(digitsAfter == 0){
			decimalPointChars = 0;
		}else{
			decimalPointChars = decimalPoint.length;
		}

		stringx = new Array<string>(sign + digits + thousandsChars + decimalPointChars);
		p = 0;

		if(sign > 0){
			stringx[p] = '-';
			p = p + 1;
		}

		for(i = 0; i < digits; i = i + 1){
			if(i == digitsBefore){
				if(i == 0){
					stringx[p] = '0';
					p = p + 1;
					digits = digits - 1;
				}

				for(j = 0; j < decimalPoint.length; j = j + 1){
					stringx[p] = decimalPoint[j];
					p = p + 1;
				}
			}

			if(i < digitsBefore){
				if((digitsBefore - i)%3 == 0 && i != 0){
					for(j = 0; j < thousandsSeparator.length; j = j + 1){
						stringx[p] = thousandsSeparator[j];
						p = p + 1;
					}
				}
			}

			d = Math.floor(decimal/10**(digits - i - 1));
			d = d%10;

			GetSingleDigitCharacterFromNumberWithCheck(d, 10, characterReference);
			stringx[p] = characterReference.characterValue;

			p = p + 1;
		}

		/* System.out.println(new String(string));*/
		return stringx;
	}


	function NumberToHumanReadable(n : number, digitsAfter : number, thousandsSeparator : string [], decimalPoint : string []) : string []{
		var str : string [];
		var u : string;
		var d : number, p3 : number;

		if(Math.abs(n) < 1){
			str = CreateStringDecimalFromNumber(n);
		}else{
			d = Math.log10(n);

			p3 = Math.min(Math.floor(d/3), 8);

			if(p3 == 0){
				u = 'B';
			}else if(p3 == 1){
				u = 'K';
			}else if(p3 == 2){
				u = 'M';
			}else if(p3 == 3){
				u = 'G';
			}else if(p3 == 4){
				u = 'T';
			}else if(p3 == 5){
				u = 'P';
			}else if(p3 == 6){
				u = 'E';
			}else if(p3 == 7){
				u = 'Z';
			}else{
				u = 'Y';
			}

			if(p3 > 1){
				n = n/10**(p3*3);
			}

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

			if(p3 > 1){
				str = strAppendCharacter(str, u);
			}
		}

		return str;
	}


	function NumberToHumanReadableBinaryPrefix(n : number, digitsAfter : number, thousandsSeparator : string [], decimalPoint : string []) : string []{
		var str : string [];
		var u : string [];
		var d : number, p3 : number;

		if(Math.abs(n) < 1){
			str = CreateStringDecimalFromNumber(n);
		}else{
			d = Math.floor(Math.log(n)/Math.log(2)) + 1;

			p3 = Math.min(Math.floor(d/10), 8);

			if(p3 == 0){
				u = "B".split('');
			}else if(p3 == 1){
				u = "Ki".split('');
			}else if(p3 == 2){
				u = "Mi".split('');
			}else if(p3 == 3){
				u = "Gi".split('');
			}else if(p3 == 4){
				u = "Ti".split('');
			}else if(p3 == 5){
				u = "Pi".split('');
			}else if(p3 == 6){
				u = "Ei".split('');
			}else if(p3 == 7){
				u = "Zi".split('');
			}else{
				u = "Yi".split('');
			}

			if(p3 > 1){
				n = n/2**(p3*10);
			}

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

			if(p3 > 1){
				str = strAppendString(str, u);
			}
		}

		return str;
	}


	function AddNumber(list : number [], a : number) : number []{
		var newlist : number [];
		var i : number;

		newlist = new Array<number>(list.length + 1);
		for(i = 0; i < list.length; i = i + 1){
			newlist[i] = list[i];
		}
		newlist[list.length] = a;
		
		list = undefined;
		
		return newlist;
	}


	function AddNumberRef(list : NumberArrayReference, i : number) : void{
		list.numberArray = AddNumber(list.numberArray, i);
	}


	function RemoveNumber(list : number [], n : number) : number []{
		var newlist : number [];
		var i : number;

		newlist = new Array<number>(list.length - 1);

		if(n >= 0 && n < list.length){
			for(i = 0; i < list.length; i = i + 1){
				if(i < n){
					newlist[i] = list[i];
				}
				if(i > n){
					newlist[i - 1] = list[i];
				}
			}

			list = undefined;
		}else{
			newlist = undefined;
		}
		
		return newlist;
	}


	function GetNumberRef(list : NumberArrayReference, i : number) : number{
		return list.numberArray[i];
	}


	function RemoveNumberRef(list : NumberArrayReference, i : number) : void{
		list.numberArray = RemoveNumber(list.numberArray, i);
	}


	function AddString(list : StringReference [], a : StringReference) : StringReference []{
		var newlist : StringReference [];
		var i : number;

		newlist = new Array<StringReference>(list.length + 1);

		for(i = 0; i < list.length; i = i + 1){
			newlist[i] = list[i];
		}
		newlist[list.length] = a;
		
		list = undefined;
		
		return newlist;
	}


	function AddStringRef(list : StringArrayReference, i : StringReference) : void{
		list.stringArray = AddString(list.stringArray, i);
	}


	function RemoveString(list : StringReference [], n : number) : StringReference []{
		var newlist : StringReference [];
		var i : number;

		newlist = new Array<StringReference>(list.length - 1);

		if(n >= 0 && n < list.length){
			for(i = 0; i < list.length; i = i + 1){
				if(i < n){
					newlist[i] = list[i];
				}
				if(i > n){
					newlist[i - 1] = list[i];
				}
			}

			list = undefined;
		}else{
			newlist = undefined;
		}
		
		return newlist;
	}


	function GetStringRef(list : StringArrayReference, i : number) : StringReference{
		return list.stringArray[i];
	}


	function RemoveStringRef(list : StringArrayReference, i : number) : void{
		list.stringArray = RemoveString(list.stringArray, i);
	}


	function CreateDynamicArrayCharacters() : DynamicArrayCharacters{
		var da : DynamicArrayCharacters;

		da = new DynamicArrayCharacters();
		da.array = new Array<string>(10);
		da.length = 0;

		return da;
	}


	function CreateDynamicArrayCharactersWithInitialCapacity(capacity : number) : DynamicArrayCharacters{
		var da : DynamicArrayCharacters;

		da = new DynamicArrayCharacters();
		da.array = new Array<string>(capacity);
		da.length = 0;

		return da;
	}


	function DynamicArrayAddCharacter(da : DynamicArrayCharacters, value : string) : void{
		if(da.length == da.array.length){
			DynamicArrayCharactersIncreaseSize(da);
		}

		da.array[da.length] = value;
		da.length = da.length + 1;
	}


	function DynamicArrayAddString(da : DynamicArrayCharacters, str : string []) : void{
		var i : number;

		for(i = 0; i < str.length; i = i + 1){
			DynamicArrayAddCharacter(da, str[i]);
		}
	}


	function DynamicArrayCharactersIncreaseSize(da : DynamicArrayCharacters) : void{
		var newLength : number, i : number;
		var newArray : string [];

		newLength = Math.round(da.array.length*3/2);
		newArray = new Array<string>(newLength);

		for(i = 0; i < da.array.length; i = i + 1){
			newArray[i] = da.array[i];
		}

		delete da.array;

		da.array = newArray;
	}


	function DynamicArrayCharactersDecreaseSizeNecessary(da : DynamicArrayCharacters) : boolean{
		var needsDecrease : boolean;

		needsDecrease = false;

		if(da.length > 10){
			needsDecrease = da.length <= Math.round(da.array.length*2/3);
		}

		return needsDecrease;
	}


	function DynamicArrayCharactersDecreaseSize(da : DynamicArrayCharacters) : void{
		var newLength : number, i : number;
		var newArray : string [];

		newLength = Math.round(da.array.length*2/3);
		newArray = new Array<string>(newLength);

		for(i = 0; i < newLength; i = i + 1){
			newArray[i] = da.array[i];
		}

		delete da.array;

		da.array = newArray;
	}


	function DynamicArrayCharactersIndex(da : DynamicArrayCharacters, index : number) : string{
		return da.array[index];
	}


	function DynamicArrayCharactersLength(da : DynamicArrayCharacters) : number{
		return da.length;
	}


	function DynamicArrayInsertCharacter(da : DynamicArrayCharacters, index : number, value : string) : void{
		var i : number;

		if(da.length == da.array.length){
			DynamicArrayCharactersIncreaseSize(da);
		}

		for(i = da.length; i > index; i = i - 1){
			da.array[i] = da.array[i - 1];
		}

		da.array[index] = value;

		da.length = da.length + 1;
	}


	function DynamicArrayCharacterSet(da : DynamicArrayCharacters, index : number, value : string) : boolean{
		var success : boolean;

		if(index < da.length){
			da.array[index] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function DynamicArrayRemoveCharacter(da : DynamicArrayCharacters, index : number) : void{
		var i : number;

		for(i = index; i < da.length - 1; i = i + 1){
			da.array[i] = da.array[i + 1];
		}

		da.length = da.length - 1;

		if(DynamicArrayCharactersDecreaseSizeNecessary(da)){
			DynamicArrayCharactersDecreaseSize(da);
		}
	}


	function FreeDynamicArrayCharacters(da : DynamicArrayCharacters) : void{
		delete da.array;
		da = undefined;
	}


	function DynamicArrayCharactersToArray(da : DynamicArrayCharacters) : string []{
		var array : string [];
		var i : number;

		array = new Array<string>(da.length);

		for(i = 0; i < da.length; i = i + 1){
			array[i] = da.array[i];
		}

		return array;
	}


	function ArrayToDynamicArrayCharactersWithOptimalSize(array : string []) : DynamicArrayCharacters{
		var da : DynamicArrayCharacters;
		var i : number;
		var c : number, n : number, newCapacity : number;

		c = array.length;
		n = (Math.log(c) - 1)/Math.log(3/2);
		newCapacity = Math.ceil(10*(3/2)**n);

		da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity);

		for(i = 0; i < array.length; i = i + 1){
			da.array[i] = array[i];
		}

		return da;
	}


	function ArrayToDynamicArrayCharacters(array : string []) : DynamicArrayCharacters{
		var da : DynamicArrayCharacters;

		da = new DynamicArrayCharacters();
		da.array = arraysCopyString(array);
		da.length = array.length;

		return da;
	}


	function DynamicArrayCharactersEqual(a : DynamicArrayCharacters, b : DynamicArrayCharacters) : boolean{
		var equal : boolean;
		var i : number;

		equal = true;
		if(a.length == b.length){
			for(i = 0; i < a.length && equal; i = i + 1){
				if(a.array[i] != b.array[i]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function DynamicArrayCharactersToLinkedList(da : DynamicArrayCharacters) : LinkedListCharacters{
		var ll : LinkedListCharacters;
		var i : number;

		ll = CreateLinkedListCharacter();

		for(i = 0; i < da.length; i = i + 1){
			LinkedListAddCharacter(ll, da.array[i]);
		}

		return ll;
	}


	function LinkedListToDynamicArrayCharacters(ll : LinkedListCharacters) : DynamicArrayCharacters{
		var da : DynamicArrayCharacters;
		var i : number;
		var node : LinkedListNodeCharacters;

		node = ll.first;

		da = new DynamicArrayCharacters();
		da.length = LinkedListCharactersLength(ll);

		da.array = new Array<string>(da.length);

		for(i = 0; i < da.length; i = i + 1){
			da.array[i] = node.value;
			node = node.next;
		}

		return da;
	}


	function AddBoolean(list : boolean [], a : boolean) : boolean []{
		var newlist : boolean [];
		var i : number;

		newlist = new Array<boolean>(list.length + 1);
		for(i = 0; i < list.length; i = i + 1){
			newlist[i] = list[i];
		}
		newlist[list.length] = a;
		
		list = undefined;
		
		return newlist;
	}


	function AddBooleanRef(list : BooleanArrayReference, i : boolean) : void{
		list.booleanArray = AddBoolean(list.booleanArray, i);
	}


	function RemoveBoolean(list : boolean [], n : number) : boolean []{
		var newlist : boolean [];
		var i : number;

		newlist = new Array<boolean>(list.length - 1);

		if(n >= 0 && n < list.length){
			for(i = 0; i < list.length; i = i + 1){
				if(i < n){
					newlist[i] = list[i];
				}
				if(i > n){
					newlist[i - 1] = list[i];
				}
			}

			list = undefined;
		}else{
			newlist = undefined;
		}
		
		return newlist;
	}


	function GetBooleanRef(list : BooleanArrayReference, i : number) : boolean{
		return list.booleanArray[i];
	}


	function RemoveDecimalRef(list : BooleanArrayReference, i : number) : void{
		list.booleanArray = RemoveBoolean(list.booleanArray, i);
	}


	function CreateLinkedListString() : LinkedListStrings{
		var ll : LinkedListStrings;

		ll = new LinkedListStrings();
		ll.first = new LinkedListNodeStrings();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}


	function LinkedListAddString(ll : LinkedListStrings, value : string []) : void{
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeStrings();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}


	function LinkedListStringsToArray(ll : LinkedListStrings) : StringReference []{
		var array : StringReference [];
		var length : number, i : number;
		var node : LinkedListNodeStrings;

		node = ll.first;

		length = LinkedListStringsLength(ll);

		array = new Array<StringReference>(length);

		for(i = 0; i < length; i = i + 1){
			array[i] = new StringReference();
			array[i].stringx = node.value;
			node = node.next;
		}

		return array;
	}


	function LinkedListStringsLength(ll : LinkedListStrings) : number{
		var l : number;
		var node : LinkedListNodeStrings;

		l = 0;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1;
		}

		return l;
	}


	function FreeLinkedListString(ll : LinkedListStrings) : void{
		var node : LinkedListNodeStrings, prev : LinkedListNodeStrings;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			prev = undefined;
		}

		node = undefined;
	}


	function LinkedListInsertString(ll : LinkedListStrings, index : number, value : string []) : void{
		var i : number;
		var node : LinkedListNodeStrings, tmp : LinkedListNodeStrings;

		if(index == 0){
			tmp = ll.first;
			ll.first = new LinkedListNodeStrings();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0; i < index - 1; i = i + 1){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeStrings();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}


	function CreateLinkedListNumbers() : LinkedListNumbers{
		var ll : LinkedListNumbers;

		ll = new LinkedListNumbers();
		ll.first = new LinkedListNodeNumbers();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}


	function CreateLinkedListNumbersArray(length : number) : LinkedListNumbers []{
		var lls : LinkedListNumbers [];
		var i : number;

		lls = new Array<LinkedListNumbers>(length);
		for(i = 0; i < lls.length; i = i + 1){
			lls[i] = CreateLinkedListNumbers();
		}

		return lls;
	}


	function LinkedListAddNumber(ll : LinkedListNumbers, value : number) : void{
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeNumbers();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}


	function LinkedListNumbersLength(ll : LinkedListNumbers) : number{
		var l : number;
		var node : LinkedListNodeNumbers;

		l = 0;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1;
		}

		return l;
	}


	function LinkedListNumbersIndex(ll : LinkedListNumbers, index : number) : number{
		var i : number;
		var node : LinkedListNodeNumbers;

		node = ll.first;
		for(i = 0; i < index; i = i + 1){
			node = node.next;
		}

		return node.value;
	}


	function LinkedListInsertNumber(ll : LinkedListNumbers, index : number, value : number) : void{
		var i : number;
		var node : LinkedListNodeNumbers, tmp : LinkedListNodeNumbers;

		if(index == 0){
			tmp = ll.first;
			ll.first = new LinkedListNodeNumbers();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0; i < index - 1; i = i + 1){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeNumbers();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}


	function LinkedListSet(ll : LinkedListNumbers, index : number, value : number) : void{
		var i : number;
		var node : LinkedListNodeNumbers;

		node = ll.first;
		for(i = 0; i < index; i = i + 1){
			node = node.next;
		}

		node.next.value = value;
	}


	function LinkedListRemoveNumber(ll : LinkedListNumbers, index : number) : void{
		var i : number;
		var node : LinkedListNodeNumbers, prev : LinkedListNodeNumbers;

		node = ll.first;
		prev = ll.first;

		for(i = 0; i < index; i = i + 1){
			prev = node;
			node = node.next;
		}

		if(index == 0){
			ll.first = prev.next;
		}
		if(!prev.next.end){
			prev.next = prev.next.next;
		}
	}


	function FreeLinkedListNumbers(ll : LinkedListNumbers) : void{
		var node : LinkedListNodeNumbers, prev : LinkedListNodeNumbers;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			prev = undefined;
		}

		node = undefined;
	}


	function FreeLinkedListNumbersArray(lls : LinkedListNumbers []) : void{
		var i : number;

		for(i = 0; i < lls.length; i = i + 1){
			FreeLinkedListNumbers(lls[i]);
		}
		lls = undefined;
	}


	function LinkedListNumbersToArray(ll : LinkedListNumbers) : number []{
		var array : number [];
		var length : number, i : number;
		var node : LinkedListNodeNumbers;

		node = ll.first;

		length = LinkedListNumbersLength(ll);

		array = new Array<number>(length);

		for(i = 0; i < length; i = i + 1){
			array[i] = node.value;
			node = node.next;
		}

		return array;
	}


	function ArrayToLinkedListNumbers(array : number []) : LinkedListNumbers{
		var ll : LinkedListNumbers;
		var i : number;

		ll = CreateLinkedListNumbers();

		for(i = 0; i < array.length; i = i + 1){
			LinkedListAddNumber(ll, array[i]);
		}

		return ll;
	}


	function LinkedListNumbersEqual(a : LinkedListNumbers, b : LinkedListNumbers) : boolean{
		var equal : boolean, done : boolean;
		var an : LinkedListNodeNumbers, bn : LinkedListNodeNumbers;

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


	function CreateLinkedListCharacter() : LinkedListCharacters{
		var ll : LinkedListCharacters;

		ll = new LinkedListCharacters();
		ll.first = new LinkedListNodeCharacters();
		ll.last = ll.first;
		ll.last.end = true;

		return ll;
	}


	function LinkedListAddCharacter(ll : LinkedListCharacters, value : string) : void{
		ll.last.end = false;
		ll.last.value = value;
		ll.last.next = new LinkedListNodeCharacters();
		ll.last.next.end = true;
		ll.last = ll.last.next;
	}


	function LinkedListCharactersToArray(ll : LinkedListCharacters) : string []{
		var array : string [];
		var length : number, i : number;
		var node : LinkedListNodeCharacters;

		node = ll.first;

		length = LinkedListCharactersLength(ll);

		array = new Array<string>(length);

		for(i = 0; i < length; i = i + 1){
			array[i] = node.value;
			node = node.next;
		}

		return array;
	}


	function LinkedListCharactersLength(ll : LinkedListCharacters) : number{
		var l : number;
		var node : LinkedListNodeCharacters;

		l = 0;
		node = ll.first;
		for(; !node.end; ){
			node = node.next;
			l = l + 1;
		}

		return l;
	}


	function FreeLinkedListCharacter(ll : LinkedListCharacters) : void{
		var node : LinkedListNodeCharacters, prev : LinkedListNodeCharacters;

		node = ll.first;

		for(; !node.end; ){
			prev = node;
			node = node.next;
			prev = undefined;
		}

		node = undefined;
	}


	function LinkedListCharactersAddString(ll : LinkedListCharacters, str : string []) : void{
		var i : number;

		for(i = 0; i < str.length; i = i + 1){
			LinkedListAddCharacter(ll, str[i]);
		}
	}


	function LinkedListInsertCharacter(ll : LinkedListCharacters, index : number, value : string) : void{
		var i : number;
		var node : LinkedListNodeCharacters, tmp : LinkedListNodeCharacters;

		if(index == 0){
			tmp = ll.first;
			ll.first = new LinkedListNodeCharacters();
			ll.first.next = tmp;
			ll.first.value = value;
			ll.first.end = false;
		}else{
			node = ll.first;
			for(i = 0; i < index - 1; i = i + 1){
				node = node.next;
			}

			tmp = node.next;
			node.next = new LinkedListNodeCharacters();
			node.next.next = tmp;
			node.next.value = value;
			node.next.end = false;
		}
	}


	function CreateDynamicArrayNumbers() : DynamicArrayNumbers{
		var da : DynamicArrayNumbers;

		da = new DynamicArrayNumbers();
		da.array = new Array<number>(10);
		da.length = 0;

		return da;
	}


	function CreateDynamicArrayNumbersWithInitialCapacity(capacity : number) : DynamicArrayNumbers{
		var da : DynamicArrayNumbers;

		da = new DynamicArrayNumbers();
		da.array = new Array<number>(capacity);
		da.length = 0;

		return da;
	}


	function DynamicArrayAddNumber(da : DynamicArrayNumbers, value : number) : void{
		if(da.length == da.array.length){
			DynamicArrayNumbersIncreaseSize(da);
		}

		da.array[da.length] = value;
		da.length = da.length + 1;
	}


	function DynamicArrayNumbersIncreaseSize(da : DynamicArrayNumbers) : void{
		var newLength : number, i : number;
		var newArray : number [];

		newLength = Math.round(da.array.length*3/2);
		newArray = new Array<number>(newLength);

		for(i = 0; i < da.array.length; i = i + 1){
			newArray[i] = da.array[i];
		}

		delete da.array;

		da.array = newArray;
	}


	function DynamicArrayNumbersDecreaseSizeNecessary(da : DynamicArrayNumbers) : boolean{
		var needsDecrease : boolean;

		needsDecrease = false;

		if(da.length > 10){
			needsDecrease = da.length <= Math.round(da.array.length*2/3);
		}

		return needsDecrease;
	}


	function DynamicArrayNumbersDecreaseSize(da : DynamicArrayNumbers) : void{
		var newLength : number, i : number;
		var newArray : number [];

		newLength = Math.round(da.array.length*2/3);
		newArray = new Array<number>(newLength);

		for(i = 0; i < newLength; i = i + 1){
			newArray[i] = da.array[i];
		}

		delete da.array;

		da.array = newArray;
	}


	function DynamicArrayNumbersIndex(da : DynamicArrayNumbers, index : number) : number{
		return da.array[index];
	}


	function DynamicArrayNumbersLength(da : DynamicArrayNumbers) : number{
		return da.length;
	}


	function DynamicArrayInsertNumber(da : DynamicArrayNumbers, index : number, value : number) : void{
		var i : number;

		if(da.length == da.array.length){
			DynamicArrayNumbersIncreaseSize(da);
		}

		for(i = da.length; i > index; i = i - 1){
			da.array[i] = da.array[i - 1];
		}

		da.array[index] = value;

		da.length = da.length + 1;
	}


	function DynamicArrayNumberSet(da : DynamicArrayNumbers, index : number, value : number) : boolean{
		var success : boolean;

		if(index < da.length){
			da.array[index] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function DynamicArrayRemoveNumber(da : DynamicArrayNumbers, index : number) : void{
		var i : number;

		for(i = index; i < da.length - 1; i = i + 1){
			da.array[i] = da.array[i + 1];
		}

		da.length = da.length - 1;

		if(DynamicArrayNumbersDecreaseSizeNecessary(da)){
			DynamicArrayNumbersDecreaseSize(da);
		}
	}


	function FreeDynamicArrayNumbers(da : DynamicArrayNumbers) : void{
		delete da.array;
		da = undefined;
	}


	function DynamicArrayNumbersToArray(da : DynamicArrayNumbers) : number []{
		var array : number [];
		var i : number;

		array = new Array<number>(da.length);

		for(i = 0; i < da.length; i = i + 1){
			array[i] = da.array[i];
		}

		return array;
	}


	function ArrayToDynamicArrayNumbersWithOptimalSize(array : number []) : DynamicArrayNumbers{
		var da : DynamicArrayNumbers;
		var i : number;
		var c : number, n : number, newCapacity : number;

		/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */
		c = array.length;
		n = (Math.log(c) - 1)/Math.log(3/2);
		newCapacity = Math.ceil(10*(3/2)**n);

		da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity);

		for(i = 0; i < array.length; i = i + 1){
			da.array[i] = array[i];
		}

		return da;
	}


	function ArrayToDynamicArrayNumbers(array : number []) : DynamicArrayNumbers{
		var da : DynamicArrayNumbers;

		da = new DynamicArrayNumbers();
		da.array = arraysCopyNumberArray(array);
		da.length = array.length;

		return da;
	}


	function DynamicArrayNumbersEqual(a : DynamicArrayNumbers, b : DynamicArrayNumbers) : boolean{
		var equal : boolean;
		var i : number;

		equal = true;
		if(a.length == b.length){
			for(i = 0; i < a.length && equal; i = i + 1){
				if(a.array[i] != b.array[i]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function DynamicArrayNumbersToLinkedList(da : DynamicArrayNumbers) : LinkedListNumbers{
		var ll : LinkedListNumbers;
		var i : number;

		ll = CreateLinkedListNumbers();

		for(i = 0; i < da.length; i = i + 1){
			LinkedListAddNumber(ll, da.array[i]);
		}

		return ll;
	}


	function LinkedListToDynamicArrayNumbers(ll : LinkedListNumbers) : DynamicArrayNumbers{
		var da : DynamicArrayNumbers;
		var i : number;
		var node : LinkedListNodeNumbers;

		node = ll.first;

		da = new DynamicArrayNumbers();
		da.length = LinkedListNumbersLength(ll);

		da.array = new Array<number>(da.length);

		for(i = 0; i < da.length; i = i + 1){
			da.array[i] = node.value;
			node = node.next;
		}

		return da;
	}


	function DynamicArrayNumbersIndexOf(arr : DynamicArrayNumbers, n : number, foundReference : BooleanReference) : number{
		var found : boolean;
		var i : number;

		found = false;
		for(i = 0; i < arr.length && !found; i = i + 1){
			if(arr.array[i] == n){
				found = true;
			}
		}
		if(!found){
			i = -1;
		}else{
			i = i - 1;
		}

		foundReference.booleanValue = found;

		return i;
	}


	function DynamicArrayNumbersIsInArray(arr : DynamicArrayNumbers, n : number) : boolean{
		var found : boolean;
		var i : number;

		found = false;
		for(i = 0; i < arr.length && !found; i = i + 1){
			if(arr.array[i] == n){
				found = true;
			}
		}

		return found;
	}


	function AddCharacter(list : string [], a : string) : string []{
		var newlist : string [];
		var i : number;

		newlist = new Array<string>(list.length + 1);
		for(i = 0; i < list.length; i = i + 1){
			newlist[i] = list[i];
		}
		newlist[list.length] = a;
		
		list = undefined;
		
		return newlist;
	}


	function AddCharacterRef(list : StringReference, i : string) : void{
		list.stringx = AddCharacter(list.stringx, i);
	}


	function RemoveCharacter(list : string [], n : number) : string []{
		var newlist : string [];
		var i : number;

		newlist = new Array<string>(list.length - 1);

		if(n >= 0 && n < list.length){
			for(i = 0; i < list.length; i = i + 1){
				if(i < n){
					newlist[i] = list[i];
				}
				if(i > n){
					newlist[i - 1] = list[i];
				}
			}

			list = undefined;
		}else{
			newlist = undefined;
		}

		return newlist;
	}


	function GetCharacterRef(list : StringReference, i : number) : string{
		return list.stringx[i];
	}


	function RemoveCharacterRef(list : StringReference, i : number) : void{
		list.stringx = RemoveCharacter(list.stringx, i);
	}


	function GetAccrualAmount(total : number, fromYear : number, fromMonth : number, fromDay : number, toYear : number, toMonth : number, toDay : number, yearOfInterest : number, monthOfInterest : number) : number{
		var fromx : Date, to : Date;
		var amount : number;

		fromx = CreateDate(fromYear, fromMonth, fromDay);
		to = CreateDate(toYear, toMonth, toDay);

		amount = GetAccrualAmountWithDates(total, fromx, to, yearOfInterest, monthOfInterest);

		return amount;
	}


	function GetAccruals(total : number, fromYear : number, fromMonth : number, fromDay : number, toYear : number, toMonth : number, toDay : number) : number []{
		var fromx : Date, to : Date;
		var amounts : number [];

		fromx = CreateDate(fromYear, fromMonth, fromDay);
		to = CreateDate(toYear, toMonth, toDay);

		amounts = GetAccrualsWithDates(total, fromx, to);

		return amounts;
	}


	function GetAccrualsWithDates(total : number, fromx : Date, to : Date) : number []{
		var entry : number;
		var done : boolean;
		var dateOfInterest : Date;
		var list : LinkedListNumbers;
		var result : number [];

		list = CreateLinkedListNumbers();

		done = false;
		dateOfInterest = new Date();
		AssignDate(dateOfInterest, fromx);
		for(; !done; ){
			if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
				done = true;
			}

			entry = GetAccrualAmountWithDates(total, fromx, to, dateOfInterest.year, dateOfInterest.month);
			LinkedListAddNumber(list, entry);
			AddMonthsToDate(dateOfInterest, 1);
		}

		result = LinkedListNumbersToArray(list);
		FreeLinkedListNumbers(list);

		return result;
	}


	function GetAccrualAmountWithDates(total : number, fromx : Date, to : Date, yearOfInterest : number, monthOfInterest : number) : number{
		var unadjustedAmount : number, adjustment : number, days : number, daysToAdjust : number, n : number;
		var adjustTo : Date;
		var valuePerDay : FixedPoint15d, divisibleRemaining : FixedPoint15d, divisibleTotal : FixedPoint15d, amount : FixedPoint15d;
		var message : StringReference;

		message = new StringReference();

		valuePerDay = CreateFixedPoint15d(13, 2);
		divisibleRemaining = CreateFixedPoint15d(13, 2);
		divisibleTotal = CreateFixedPoint15d(13, 2);
		amount = CreateFixedPoint15d(13, 2);

		days = DaysBetweenDates(fromx, to) + 1;

		/* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining*/
		DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days));

		Multiply15d(divisibleTotal, valuePerDay, Number15d(days));
		unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, fromx, to, yearOfInterest, monthOfInterest);

		if(!Equals15d(divisibleRemaining, Number15d(0))){
			daysToAdjust = Round(ToNumber15d(divisibleRemaining)*100);
			adjustTo = new Date();
			AssignDate(adjustTo, fromx);
			AddDaysToDate(adjustTo, daysToAdjust - 1, message);

			adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, fromx, adjustTo, yearOfInterest, monthOfInterest);

			adjustTo = undefined;
		}else{
			adjustment = 0;
		}

		Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment));

		n = ToNumber15d(amount);

		valuePerDay = undefined;
		divisibleRemaining = undefined;
		divisibleTotal = undefined;
		amount = undefined;

		return n;
	}


	function GetUnadjustedAccrualAmountWithDates(total : FixedPoint15d, fromx : Date, to : Date, yearOfInterest : number, monthOfInterest : number) : number{
		var days : number, daysInMonthOfInterest : number, n : number;
		var lastDayInMonth : Date, firstDateInMonth : Date;
		var daysInMonth : number [];
		var valuePerDay : FixedPoint15d, value : FixedPoint15d, remainder : FixedPoint15d;
		var success : boolean;

		value = CreateFixedPoint15d(13, 2);
		valuePerDay = CreateFixedPoint15d(13, 2);
		remainder = CreateFixedPoint15d(13, 2);

		days = DaysBetweenDates(fromx, to) + 1;
		/* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...*/
		success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days));

		if(success){
			daysInMonth = GetDaysInMonth(yearOfInterest);

			if(yearOfInterest < fromx.year){
				Assign15d(value, 0);
			}else if(yearOfInterest == fromx.year && monthOfInterest < fromx.month){
				Assign15d(value, 0);
			}else if(yearOfInterest > to.year){
				Assign15d(value, 0);
			}else if(yearOfInterest == to.year && monthOfInterest > to.month){
				Assign15d(value, 0);
			}else{
if(fromx.year == yearOfInterest && fromx.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest){
					daysInMonthOfInterest = days;
				}else if(fromx.year == yearOfInterest && fromx.month == monthOfInterest){
					lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[monthOfInterest]);
					daysInMonthOfInterest = DaysBetweenDates(fromx, lastDayInMonth) + 1;
				}else if(to.year == yearOfInterest && to.month == monthOfInterest){
					firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1);
					daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1;
				}else{
					daysInMonthOfInterest = daysInMonth[monthOfInterest];
				}

				/* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value*/
				Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest));
			}

			daysInMonth = undefined;
		}

		n = ToNumber15d(value);

		value = undefined;
		valuePerDay = undefined;
		remainder = undefined;

		return n;
	}


	function CreateNewArrayData() : Data{
		var data : Data;

		data = new Data();
		data.isArray = true;
		data.isStruture = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.isString = false;
		data.array = CreateArray();

		return data;
	}


	function CreateNewStructData() : Data{
		var data : Data;

		data = new Data();
		data.isStruture = true;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.isString = false;
		data.structure = CreateStructure();

		return data;
	}


	function CreateStructure() : Structure{
		var st : Structure;

		st = new Structure();
		st.keys = CreateArray();
		st.values = CreateArray();

		return st;
	}


	function CreateNumberData(n : number) : Data{
		var data : Data;

		data = new Data();
		data.isNumber = true;
		data.isStruture = false;
		data.isArray = false;
		data.isBoolean = false;
		data.isString = false;
		data.numberx = n;

		return data;
	}


	function CreateBooleanData(b : boolean) : Data{
		var data : Data;

		data = new Data();
		data.isBoolean = true;
		data.isStruture = false;
		data.isArray = false;
		data.isNumber = false;
		data.isString = false;
		data.booleanxx = b;

		return data;
	}


	function CreateStringData(stringx : string []) : Data{
		var data : Data;

		data = new Data();
		data.isString = true;
		data.isStruture = false;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.stringx = stringx;

		return data;
	}


	function CreateStructData(structure : Structure) : Data{
		var data : Data;

		data = new Data();
		data.isString = false;
		data.isStruture = true;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.structure = structure;

		return data;
	}


	function CreateArrayData(array : Arrayx) : Data{
		var data : Data;

		data = new Data();
		data.isString = false;
		data.isStruture = false;
		data.isArray = true;
		data.isNumber = false;
		data.isBoolean = false;
		data.array = array;

		return data;
	}


	function CreateNoTypeData() : Data{
		var data : Data;

		data = new Data();
		data.isStruture = false;
		data.isArray = false;
		data.isNumber = false;
		data.isBoolean = false;
		data.isString = false;

		return data;
	}


	function AddStructToArray(ar : Arrayx, st : Structure) : void{
		var data : Data;

		data = CreateNewStructData();
		delete data.structure;
		data.structure = st;

		ArrayAdd(ar, data);
	}


	function AddArrayToArray(ar : Arrayx, ar2 : Arrayx) : void{
		var data : Data;

		data = CreateNewArrayData();
		delete data.array;
		data.array = ar2;

		ArrayAdd(ar, data);
	}


	function AddNumberToArray(ar : Arrayx, n : number) : void{
		ArrayAdd(ar, CreateNumberData(n));
	}


	function AddBooleanToArray(ar : Arrayx, b : boolean) : void{
		ArrayAdd(ar, CreateBooleanData(b));
	}


	function AddStringToArray(ar : Arrayx, str : string []) : void{
		ArrayAdd(ar, CreateStringData(str));
	}


	function AddDataToArray(ar : Arrayx, data : Data) : void{
		ArrayAdd(ar, data);
	}


	function StructKeys(st : Structure) : number{
		return ArrayLength(st.keys);
	}


	function StructHasKey(st : Structure, key : string []) : boolean{
		var i : number;
		var hasKey : boolean;

		hasKey = false;
		for(i = 0; i < StructKeys(st); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				hasKey = true;
			}
		}

		return hasKey;
	}


	function StructKeyIndex(st : Structure, key : string []) : number{
		var i : number;
		var index : number;

		index = -1;
		for(i = 0; i < StructKeys(st); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				index = i;
			}
		}

		return index;
	}


	function GetStructKeys(st : Structure) : StringReference []{
		var keys : StringReference [];
		var nr : number, i : number;

		nr = StructKeys(st);

		keys = new Array<StringReference>(nr);

		for(i = 0; i < nr; i = i + 1){
			keys[i] = new StringReference();
			keys[i].stringx = arraysCopyString(st.keys.array[i].stringx);
		}

		return keys;
	}


	function GetStructFromStruct(st : Structure, key : string []) : Structure{
		var i : number;
		var r : Structure;

		r = new Structure();
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = st.values.array[i].structure;
			}
		}

		return r;
	}


	function GetArrayFromStruct(st : Structure, key : string []) : Arrayx{
		var i : number;
		var r : Arrayx;

		r = new Arrayx();
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = st.values.array[i].array;
			}
		}

		return r;
	}


	function GetNumberFromStruct(st : Structure, key : string []) : number{
		var i : number, r : number;

		r = 0;
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = st.values.array[i].numberx;
			}
		}

		return r;
	}


	function GetBooleanFromStruct(st : Structure, key : string []) : boolean{
		var i : number;
		var r : boolean;

		r = false;
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = st.values.array[i].booleanxx;
			}
		}

		return r;
	}


	function GetStringFromStruct(st : Structure, key : string []) : string []{
		var i : number;
		var r : string [];

		r = "".split('');
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = st.values.array[i].stringx;
			}
		}

		return r;
	}


	function GetDataFromStruct(st : Structure, key : string []) : Data{
		var i : number;
		var r : Data;

		r = new Data();
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = undefined;
				r = st.values.array[i];
			}
		}

		return r;
	}


	function GetDataFromStructWithCheck(st : Structure, key : string [], foundRef : BooleanReference) : Data{
		var i : number;
		var r : Data;

		r = new Data();
		foundRef.booleanValue = false;
		for(i = 0; i < ArrayLength(st.keys); i = i + 1){
			if(arraysStringsEqual(st.keys.array[i].stringx, key)){
				r = undefined;
				foundRef.booleanValue = true;
				r = st.values.array[i];
			}
		}

		return r;
	}


	function AddStructToStruct(st : Structure, key : string [], struct : Structure) : void{
		var i : number;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			delete st.values.array[i].structure;
			st.values.array[i].structure = struct;
		}else{
			AddStringToArray(st.keys, key);
			AddStructToArray(st.values, struct);
		}
	}


	function AddArrayToStruct(st : Structure, key : string [], ar : Arrayx) : void{
		var i : number;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			delete st.values.array[i].array;
			st.values.array[i].array = ar;
		}else{
			AddStringToArray(st.keys, key);
			AddArrayToArray(st.values, ar);
		}
	}


	function AddNumberToStruct(st : Structure, key : string [], n : number) : void{
		var i : number;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			st.values.array[i].numberx = n;
		}else{
			AddStringToArray(st.keys, key);
			AddNumberToArray(st.values, n);
		}
	}


	function AddBooleanToStruct(st : Structure, key : string [], b : boolean) : void{
		var i : number;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			st.values.array[i].booleanxx = b;
		}else{
			AddStringToArray(st.keys, key);
			AddBooleanToArray(st.values, b);
		}
	}


	function AddStringToStruct(st : Structure, key : string [], value : string []) : void{
		var i : number;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			delete st.values.array[i].stringx;
			st.values.array[i].stringx = value;
		}else{
			AddStringToArray(st.keys, key);
			AddStringToArray(st.values, value);
		}
	}


	function AddDataToStruct(st : Structure, key : string [], data : Data) : void{
		var i : number;

		if(StructHasKey(st, key)){
			i = StructKeyIndex(st, key);
			FreeData(st.values.array[i]);
			st.values.array[i] = data;
		}else{
			AddStringToArray(st.keys, key);
			AddDataToArray(st.values, data);
		}
	}


	function FreeData(data : Data) : void{
		var i : number;
		var st : Structure;

		if(data.isStruture){
			st = data.structure;
			for(i = 0; i < StructKeys(st); i = i + 1){
				FreeData(ArrayIndex(st.keys, i));
				FreeData(ArrayIndex(st.values, i));
			}
			st = undefined;
		}else if(data.isArray){
			FreeArray(data.array);
		}

		data = undefined;
	}


	function FreeArray(array : Arrayx) : void{
		var i : number;

		for(i = 0; i < ArrayLength(array); i = i + 1){
			FreeData(array.array[i]);
		}

		delete array.array;
		array = undefined;
	}


	function DataTypeEquals(a : Data, b : Data) : boolean{
		var equal : boolean;

		equal = true;
		equal = equal && a.isStruture == b.isStruture;
		equal = equal && a.isArray == b.isArray;
		equal = equal && a.isNumber == b.isNumber;
		equal = equal && a.isBoolean == b.isBoolean;
		equal = equal && a.isString == b.isString;

		return equal;
	}


	function IsStructure(a : Data) : boolean{
		var itis : boolean;

		itis = a.isStruture;
		if(a.isArray || a.isNumber || a.isBoolean || a.isString){
			itis = false;
		}

		return itis;
	}


	function IsArray(a : Data) : boolean{
		var itis : boolean;

		itis = a.isArray;
		if(a.isStruture || a.isNumber || a.isBoolean || a.isString){
			itis = false;
		}

		return itis;
	}


	function IsNumber(a : Data) : boolean{
		var itis : boolean;

		itis = a.isNumber;
		if(a.isStruture || a.isArray || a.isBoolean || a.isString){
			itis = false;
		}

		return itis;
	}


	function IsBoolean(a : Data) : boolean{
		var itis : boolean;

		itis = a.isBoolean;
		if(a.isStruture || a.isArray || a.isNumber || a.isString){
			itis = false;
		}

		return itis;
	}


	function IsString(a : Data) : boolean{
		var itis : boolean;

		itis = a.isString;
		if(a.isStruture || a.isArray || a.isNumber || a.isBoolean){
			itis = false;
		}

		return itis;
	}


	function IsNoType(a : Data) : boolean{
		var itis : boolean;

		if(!a.isString && !a.isStruture && !a.isArray && !a.isNumber && !a.isBoolean){
			itis = true;
		}else{
			itis = false;
		}

		return itis;
	}


	function CreateArray() : Arrayx{
		var array : Arrayx;

		array = new Arrayx();
		array.array = new Array<Data>(10);
		array.length = 0;

		return array;
	}


	function CreateArrayWithInitialCapacity(capacity : number) : Arrayx{
		var array : Arrayx;

		array = new Arrayx();
		array.array = new Array<Data>(capacity);
		array.length = 0;

		return array;
	}


	function ArrayAdd(array : Arrayx, value : Data) : void{
		if(array.length == array.array.length){
			ArrayIncreaseSize(array);
		}

		array.array[array.length] = value;
		array.length = array.length + 1;
	}


	function ArrayAddString(array : Arrayx, value : string []) : void{
		var data : Data;

		data = CreateStringData(value);

		ArrayAdd(array, data);
	}


	function ArrayAddBoolean(array : Arrayx, value : boolean) : void{
		var data : Data;

		data = CreateBooleanData(value);

		ArrayAdd(array, data);
	}


	function ArrayAddNumber(array : Arrayx, value : number) : void{
		var data : Data;

		data = CreateNumberData(value);

		ArrayAdd(array, data);
	}


	function ArrayAddStruct(array : Arrayx, value : Structure) : void{
		var data : Data;

		data = CreateStructData(value);

		ArrayAdd(array, data);
	}


	function ArrayAddArray(array : Arrayx, value : Arrayx) : void{
		var data : Data;

		data = CreateArrayData(value);

		ArrayAdd(array, data);
	}


	function ArrayIncreaseSize(array : Arrayx) : void{
		var newLength : number, i : number;
		var newArray : Data [];

		newLength = Math.round(array.array.length*3/2);
		newArray = new Array<Data>(newLength);

		for(i = 0; i < array.array.length; i = i + 1){
			newArray[i] = array.array[i];
		}

		delete array.array;

		array.array = newArray;
	}


	function ArrayDecreaseSizeNecessary(array : Arrayx) : boolean{
		var needsDecrease : boolean;

		needsDecrease = false;

		if(array.length > 10){
			needsDecrease = array.length <= Math.round(array.array.length*2/3);
		}

		return needsDecrease;
	}


	function ArrayDecreaseSize(array : Arrayx) : void{
		var newLength : number, i : number;
		var newArray : Data [];

		newLength = Math.round(array.array.length*2/3);
		newArray = new Array<Data>(newLength);

		for(i = 0; i < newLength; i = i + 1){
			newArray[i] = array.array[i];
		}

		delete array.array;

		array.array = newArray;
	}


	function ArrayIndex(array : Arrayx, index : number) : Data{
		return array.array[index];
	}


	function ArrayIndexArray(array : Arrayx, index : number) : Arrayx{
		return array.array[index].array;
	}


	function ArrayIndexStruct(array : Arrayx, index : number) : Structure{
		return array.array[index].structure;
	}


	function ArrayIndexBoolean(array : Arrayx, index : number) : boolean{
		return array.array[index].booleanxx;
	}


	function ArrayIndexString(array : Arrayx, index : number) : string []{
		return array.array[index].stringx;
	}


	function ArrayIndexNumber(array : Arrayx, index : number) : number{
		return array.array[index].numberx;
	}


	function ArrayLength(array : Arrayx) : number{
		return array.length;
	}


	function ArrayInsert(array : Arrayx, index : number, value : Data) : void{
		var i : number;

		if(array.length == array.array.length){
			ArrayIncreaseSize(array);
		}

		for(i = array.length; i > index; i = i - 1){
			array.array[i] = array.array[i - 1];
		}

		array.array[index] = value;

		array.length = array.length + 1;
	}


	function ArrayInsertString(array : Arrayx, index : number, value : string []) : void{
		var data : Data;

		data = CreateStringData(value);

		ArrayInsert(array, index, data);
	}


	function ArrayInsertBoolean(array : Arrayx, index : number, value : boolean) : void{
		var data : Data;

		data = CreateBooleanData(value);

		ArrayInsert(array, index, data);
	}


	function ArrayInsertNumber(array : Arrayx, index : number, value : number) : void{
		var data : Data;

		data = CreateNumberData(value);

		ArrayInsert(array, index, data);
	}


	function ArrayInsertStruct(array : Arrayx, index : number, value : Structure) : void{
		var data : Data;

		data = CreateStructData(value);

		ArrayInsert(array, index, data);
	}


	function ArrayInsertArray(array : Arrayx, index : number, value : Arrayx) : void{
		var data : Data;

		data = CreateArrayData(value);

		ArrayInsert(array, index, data);
	}


	function ArraySet(array : Arrayx, index : number, value : Data) : boolean{
		var success : boolean;

		if(index < array.length){
			array.array[index] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function ArraySetString(array : Arrayx, index : number, value : string []) : void{
		var data : Data;

		data = CreateStringData(value);

		ArraySet(array, index, data);
	}


	function ArraySetBoolean(array : Arrayx, index : number, value : boolean) : void{
		var data : Data;

		data = CreateBooleanData(value);

		ArraySet(array, index, data);
	}


	function ArraySetNumber(array : Arrayx, index : number, value : number) : void{
		var data : Data;

		data = CreateNumberData(value);

		ArraySet(array, index, data);
	}


	function ArraySetStruct(array : Arrayx, index : number, value : Structure) : void{
		var data : Data;

		data = CreateStructData(value);

		ArraySet(array, index, data);
	}


	function ArraySetArray(array : Arrayx, index : number, value : Arrayx) : void{
		var data : Data;

		data = CreateArrayData(value);

		ArraySet(array, index, data);
	}


	function ArrayRemove(array : Arrayx, index : number) : void{
		var i : number;

		for(i = index; i < array.length - 1; i = i + 1){
			array.array[i] = array.array[i + 1];
		}

		array.length = array.length - 1;

		if(ArrayDecreaseSizeNecessary(array)){
			ArrayDecreaseSize(array);
		}
	}


	function ToStaticArray(arc : Arrayx) : Data []{
		var array : Data [];
		var i : number;

		array = new Array<Data>(arc.length);

		for(i = 0; i < arc.length; i = i + 1){
			array[i] = arc.array[i];
		}

		return array;
	}


	function ToStaticNumberArray(array : Arrayx) : number []{
		var result : number [];
		var i : number, n : number;

		n = ArrayLength(array);

		result = new Array<number>(n);

		for(i = 0; i < n; i = i + 1){
			result[i] = ArrayIndex(array, i).numberx;
		}

		return result;
	}


	function ToStaticBooleanArray(array : Arrayx) : boolean []{
		var result : boolean [];
		var i : number, n : number;

		n = ArrayLength(array);

		result = new Array<boolean>(n);

		for(i = 0; i < n; i = i + 1){
			result[i] = ArrayIndex(array, i).booleanxx;
		}

		return result;
	}


	function ToStaticStringArray(array : Arrayx) : StringReference []{
		var result : StringReference [];
		var i : number, n : number;

		n = ArrayLength(array);

		result = new Array<StringReference>(n);

		for(i = 0; i < n; i = i + 1){
			result[i] = new StringReference();
			result[i].stringx = ArrayIndex(array, i).stringx;
		}

		return result;
	}


	function ToStaticArrayArray(array : Arrayx) : Arrayx []{
		var result : Arrayx [];
		var i : number, n : number;

		n = ArrayLength(array);

		result = new Array<Arrayx>(n);

		for(i = 0; i < n; i = i + 1){
			result[i] = ArrayIndex(array, i).array;
		}

		return result;
	}


	function ToStaticStructArray(array : Arrayx) : Structure []{
		var result : Structure [];
		var i : number, n : number;

		n = ArrayLength(array);

		result = new Array<Structure>(n);

		for(i = 0; i < n; i = i + 1){
			result[i] = ArrayIndex(array, i).structure;
		}

		return result;
	}


	function StaticArrayToArrayWithOptimalSize(src : Data []) : Arrayx{
		var dst : Arrayx;
		var i : number;
		var c : number, n : number, newCapacity : number;

		/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */

		c = src.length;
		n = (Math.log(c) - 1)/Math.log(3/2);

		newCapacity = Math.ceil(10*(3/2)**Math.ceil(n));

		dst = CreateArrayWithInitialCapacity(newCapacity);

		for(i = 0; i < src.length; i = i + 1){
			dst.array[i] = src[i];
		}

		return dst;
	}


	function StaticArrayToArray(src : Data []) : Arrayx{
		var i : number;
		var dst : Arrayx;

		dst = CreateArrayWithInitialCapacity(src.length);
		for(i = 0; i < src.length; i = i + 1){
			dst.array[i] = src[i];
		}
		dst.length = src.length;

		return dst;
	}


	function arraysStringToNumberArray(stringx : string []) : number []{
		var i : number;
		var array : number [];

		array = new Array<number>(stringx.length);

		for(i = 0; i < stringx.length; i = i + 1){
			array[i] = stringx[i].charCodeAt(0);
		}
		return array;
	}


	function arraysNumberArrayToString(array : number []) : string []{
		var i : number;
		var stringx : string [];

		stringx = new Array<string>(array.length);

		for(i = 0; i < array.length; i = i + 1){
			stringx[i] = String.fromCharCode(array[i]);
		}
		return stringx;
	}


	function arraysNumberArraysEqual(a : number [], b : number []) : boolean{
		var equal : boolean;
		var i : number;

		equal = true;
		if(a.length == b.length){
			for(i = 0; i < a.length && equal; i = i + 1){
				if(a[i] != b[i]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function arraysBooleanArraysEqual(a : boolean [], b : boolean []) : boolean{
		var equal : boolean;
		var i : number;

		equal = true;
		if(a.length == b.length){
			for(i = 0; i < a.length && equal; i = i + 1){
				if(a[i] != b[i]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function arraysStringsEqual(a : string [], b : string []) : boolean{
		var equal : boolean;
		var i : number;

		equal = true;
		if(a.length == b.length){
			for(i = 0; i < a.length && equal; i = i + 1){
				if(a[i] != b[i]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function arraysFillNumberArray(a : number [], value : number) : void{
		var i : number;

		for(i = 0; i < a.length; i = i + 1){
			a[i] = value;
		}
	}


	function arraysFillString(a : string [], value : string) : void{
		var i : number;

		for(i = 0; i < a.length; i = i + 1){
			a[i] = value;
		}
	}


	function arraysFillBooleanArray(a : boolean [], value : boolean) : void{
		var i : number;

		for(i = 0; i < a.length; i = i + 1){
			a[i] = value;
		}
	}


	function arraysFillNumberArrayRange(a : number [], value : number, fromx : number, to : number) : boolean{
		var i : number, length : number;
		var success : boolean;

		if(fromx >= 0 && fromx <= a.length && to >= 0 && to <= a.length && fromx <= to){
			length = to - fromx;
			for(i = 0; i < length; i = i + 1){
				a[fromx + i] = value;
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function arraysFillBooleanArrayRange(a : boolean [], value : boolean, fromx : number, to : number) : boolean{
		var i : number, length : number;
		var success : boolean;

		if(fromx >= 0 && fromx <= a.length && to >= 0 && to <= a.length && fromx <= to){
			length = to - fromx;
			for(i = 0; i < length; i = i + 1){
				a[fromx + i] = value;
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function arraysFillStringRange(a : string [], value : string, fromx : number, to : number) : boolean{
		var i : number, length : number;
		var success : boolean;

		if(fromx >= 0 && fromx <= a.length && to >= 0 && to <= a.length && fromx <= to){
			length = to - fromx;
			for(i = 0; i < length; i = i + 1){
				a[fromx + i] = value;
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function arraysCopyNumberArray(a : number []) : number []{
		var i : number;
		var n : number [];

		n = new Array<number>(a.length);

		for(i = 0; i < a.length; i = i + 1){
			n[i] = a[i];
		}

		return n;
	}


	function arraysCopyBooleanArray(a : boolean []) : boolean []{
		var i : number;
		var n : boolean [];

		n = new Array<boolean>(a.length);

		for(i = 0; i < a.length; i = i + 1){
			n[i] = a[i];
		}

		return n;
	}


	function arraysCopyString(a : string []) : string []{
		var i : number;
		var n : string [];

		n = new Array<string>(a.length);

		for(i = 0; i < a.length; i = i + 1){
			n[i] = a[i];
		}

		return n;
	}


	function arraysCopyNumberArrayRange(a : number [], fromx : number, to : number, copyReference : NumberArrayReference) : boolean{
		var i : number, length : number;
		var n : number [];
		var success : boolean;

		if(fromx >= 0 && fromx <= a.length && to >= 0 && to <= a.length && fromx <= to){
			length = to - fromx;
			n = new Array<number>(length);

			for(i = 0; i < length; i = i + 1){
				n[i] = a[fromx + i];
			}

			copyReference.numberArray = n;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function arraysCopyBooleanArrayRange(a : boolean [], fromx : number, to : number, copyReference : BooleanArrayReference) : boolean{
		var i : number, length : number;
		var n : boolean [];
		var success : boolean;

		if(fromx >= 0 && fromx <= a.length && to >= 0 && to <= a.length && fromx <= to){
			length = to - fromx;
			n = new Array<boolean>(length);

			for(i = 0; i < length; i = i + 1){
				n[i] = a[fromx + i];
			}

			copyReference.booleanArray = n;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function arraysCopyStringRange(a : string [], fromx : number, to : number, copyReference : StringReference) : boolean{
		var i : number, length : number;
		var n : string [];
		var success : boolean;

		if(fromx >= 0 && fromx <= a.length && to >= 0 && to <= a.length && fromx <= to){
			length = to - fromx;
			n = new Array<string>(length);

			for(i = 0; i < length; i = i + 1){
				n[i] = a[fromx + i];
			}

			copyReference.stringx = n;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function arraysIsLastElement(length : number, index : number) : boolean{
		return index + 1 == length;
	}


	function arraysCreateNumberArray(length : number, value : number) : number []{
		var array : number [];

		array = new Array<number>(length);
		arraysFillNumberArray(array, value);

		return array;
	}


	function arraysCreateBooleanArray(length : number, value : boolean) : boolean []{
		var array : boolean [];

		array = new Array<boolean>(length);
		arraysFillBooleanArray(array, value);

		return array;
	}


	function arraysCreateString(length : number, value : string) : string []{
		var array : string [];

		array = new Array<string>(length);
		arraysFillString(array, value);

		return array;
	}


	function arraysSwapElementsOfNumberArray(A : number [], ai : number, bi : number) : void{
		var tmp : number;

		tmp = A[ai];
		A[ai] = A[bi];
		A[bi] = tmp;
	}


	function arraysSwapElementsOfStringArray(A : StringArrayReference, ai : number, bi : number) : void{
		var tmp : StringReference;

		tmp = A.stringArray[ai];
		A.stringArray[ai] = A.stringArray[bi];
		A.stringArray[bi] = tmp;
	}


	function arraysReverseNumberArray(array : number []) : void{
		var i : number;

		for(i = 0; i < array.length/2; i = i + 1){
			arraysSwapElementsOfNumberArray(array, i, array.length - i - 1);
		}
	}


	function CreateStringScientificNotationDecimalFromNumber(n : number) : string []{
		var mantissaReference : StringReference, exponentReference : StringReference;
		var e : number;
		var isPositive : boolean;
		var result : string [];

		mantissaReference = new StringReference();
		exponentReference = new StringReference();
		result = new Array<string>(0);

		if(n < 0){
			isPositive = false;
			n = -n;
		}else{
			isPositive = true;
		}

		if(n == 0){
			e = 0;
		}else{
			e = GetFirstDecimalDigitPosition(n);

			if(e < 0){
				n = n*10**Math.abs(e);
			}else{
				n = n/10**e;
			}
		}

		mantissaReference.stringx = CreateStringDecimalFromNumber(n);
		exponentReference.stringx = CreateStringDecimalFromNumber(e);

		if(!isPositive){
			result = strAppendString(result, "-".split(''));
		}

		result = strAppendString(result, mantissaReference.stringx);
		result = strAppendString(result, "e".split(''));
		result = strAppendString(result, exponentReference.stringx);

		return result;
	}


	function CreateStringDecimalFromNumber(numberx : number) : string []{
		var stringx : DynamicArrayCharacters;
		var maximumDigits : number, i : number, d : number, digitPosition : number, trailingZeros : number;
		var hasPrintedPoint : boolean, isPositive : boolean, done : boolean;
		var characterReference : CharacterReference;
		var c : string;
		var str : string [];

		stringx = CreateDynamicArrayCharacters();
		isPositive = true;

		if(numberx < 0){
			isPositive = false;
			numberx = -numberx;
		}

		if(numberx == 0){
			DynamicArrayAddCharacter(stringx, '0');
		}else{
			characterReference = new CharacterReference();

			maximumDigits = GetMaximumDigitsForDecimal();

			digitPosition = GetFirstDecimalDigitPosition(numberx);

			hasPrintedPoint = false;

			if(!isPositive){
				DynamicArrayAddCharacter(stringx, '-');
			}

			/* Print leading zeros.*/
			if(digitPosition < 0){
				DynamicArrayAddCharacter(stringx, '0');
				DynamicArrayAddCharacter(stringx, '.');
				hasPrintedPoint = true;
				for(i = 0; i < -digitPosition - 1; i = i + 1){
					DynamicArrayAddCharacter(stringx, '0');
				}
			}

			/* Count trailing zeros*/
			trailingZeros = 0;
			done = false;
			for(i = 0; i < maximumDigits && !done; i = i + 1){
				d = GetDecimalDigitWithFirstDigitPosition(numberx, digitPosition, maximumDigits - i - 1);
				if(d == 0){
					trailingZeros = trailingZeros + 1;
				}else{
					done = true;
				}
			}

			/* Print number.*/
			for(i = 0; i < maximumDigits; i = i + 1){
				d = GetDecimalDigitWithFirstDigitPosition(numberx, digitPosition, i);

				if(!hasPrintedPoint && digitPosition - i + 1 == 0){
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
			for(i = 0; i < digitPosition - maximumDigits + 1; i = i + 1){
				DynamicArrayAddCharacter(stringx, '0');
			}
		}

		/* Done*/
		str = DynamicArrayCharactersToArray(stringx);
		FreeDynamicArrayCharacters(stringx);
		return str;
	}


	function CreateStringFromNumberWithCheck(numberx : number, base : number, stringRef : StringReference) : boolean{
		var stringx : DynamicArrayCharacters;
		var maximumDigits : number, i : number, d : number, digitPosition : number, trailingZeros : number;
		var success : boolean, hasPrintedPoint : boolean, isPositive : boolean, done : boolean;
		var characterReference : CharacterReference;
		var c : string;

		stringx = CreateDynamicArrayCharacters();
		isPositive = true;

		if(numberx < 0){
			isPositive = false;
			numberx = -numberx;
		}

		if(numberx == 0){
			DynamicArrayAddCharacter(stringx, '0');
			success = true;
		}else{
			characterReference = new CharacterReference();

			if(IsInteger(base)){
				success = true;

				maximumDigits = GetMaximumDigitsForBase(base);

				digitPosition = GetFirstDigitPosition(numberx, base);

				hasPrintedPoint = false;

				if(!isPositive){
					DynamicArrayAddCharacter(stringx, '-');
				}

				/* Print leading zeros.*/
				if(digitPosition < 0){
					DynamicArrayAddCharacter(stringx, '0');
					DynamicArrayAddCharacter(stringx, '.');
					hasPrintedPoint = true;
					for(i = 0; i < -digitPosition - 1; i = i + 1){
						DynamicArrayAddCharacter(stringx, '0');
					}
				}

				/* Count trailing zeros*/
				trailingZeros = 0;
				done = false;
				for(i = 0; i < maximumDigits && !done; i = i + 1){
					d = GetDigit(numberx, base, maximumDigits - i - 1);
					if(d == 0){
						trailingZeros = trailingZeros + 1;
					}else{
						done = true;
					}
				}

				/* Print number.*/
				for(i = 0; i < maximumDigits && success; i = i + 1){
					d = GetDigit(numberx, base, i);

					if(d >= base){
						d = base - 1;
					}

					if(!hasPrintedPoint && digitPosition - i + 1 == 0){
						if(maximumDigits - i > trailingZeros){
							DynamicArrayAddCharacter(stringx, '.');
						}
						hasPrintedPoint = true;
					}

					if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
					}else{
						success = GetSingleDigitCharacterFromNumberWithCheck(d, base, characterReference);
						if(success){
							c = characterReference.characterValue;
							DynamicArrayAddCharacter(stringx, c);
						}
					}
				}

				if(success){
					/* Print trailing zeros.*/
					for(i = 0; i < digitPosition - maximumDigits + 1; i = i + 1){
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


	function GetMaximumDigitsForBase(base : number) : number{
		var t : number;

		t = 10**15;
		return Math.floor(Math.log10(t)/Math.log10(base));
	}


	function GetMaximumDigitsForDecimal() : number{
		return 15;
	}


	function GetFirstDecimalDigitPosition(n : number) : number{
		var power : number, m : number, i : number;
		var multiply : boolean, done : boolean;

		n = Math.abs(n);

		if(n != 0){
			if(Math.floor(n) < 10**15){
				multiply = true;
			}else{
				multiply = false;
			}

			done = false;
			m = 0;
			for(i = 0; !done; i = i + 1){
				if(multiply){
					m = n*10**i;
					if(Math.floor(m) >= 10**14){
						done = true;
					}
				}else{
					m = n/10**i;
					if(Math.floor(m) < 10**15){
						done = true;
					}
				}
			}

			if(multiply){
				power = 15 - i;
			}else{
				power = 15 + i - 2;
			}

			if(Round(m) >= 10**15){
				power = power + 1;
			}
		}else{
			power = 1;
		}

		return power;
	}


	function GetFirstDigitPosition(n : number, base : number) : number{
		var power : number, m : number, i : number, maximumDigits : number;
		var multiply : boolean, done : boolean;

		maximumDigits = GetMaximumDigitsForBase(base);
		n = Math.abs(n);

		if(n != 0){
			if(Math.floor(n) < base**maximumDigits){
				multiply = true;
			}else{
				multiply = false;
			}

			done = false;
			m = 0;
			for(i = 0; !done; i = i + 1){
				if(multiply){
					m = n*base**i;
					if(Math.floor(m) >= base**(maximumDigits - 1)){
						done = true;
					}
				}else{
					m = n/base**i;
					if(Math.floor(m) < base**maximumDigits){
						done = true;
					}
				}
			}

			if(multiply){
				power = maximumDigits - i;
			}else{
				power = maximumDigits + i - 2;
			}

			if(Round(m) >= base**maximumDigits){
				power = power + 1;
			}
		}else{
			power = 1;
		}

		return power;
	}


	function GetSingleDigitCharacterFromNumberWithCheck(c : number, base : number, characterReference : CharacterReference) : boolean{
		var numberTable : string [];
		var success : boolean;

		numberTable = GetDigitCharacterTable();

		if(c < base || c < numberTable.length){
			success = true;
			characterReference.characterValue = numberTable[c];
		}else{
			success = false;
		}

		return success;
	}


	function GetDecimalDigitCharacterFromNumberWithCheck(c : number, characterRef : CharacterReference) : boolean{
		var numberTable : string [];
		var success : boolean;

		numberTable = "0123456789".split('');

		if(c >= 0 && c < 10){
			success = true;
			characterRef.characterValue = numberTable[c];
		}else{
			success = false;
		}

		return success;
	}


	function GetDigitCharacterTable() : string []{
		var numberTable : string [];

		numberTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".split('');

		return numberTable;
	}


	function GetDecimalDigit(n : number, index : number) : number{
		var digitPosition : number;

		digitPosition = GetFirstDecimalDigitPosition(n);

		return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index);
	}


	function GetDecimalDigitWithFirstDigitPosition(n : number, digitPosition : number, index : number) : number{
		var d : number, e : number, m : number, i : number;

		n = Math.abs(n);

		e = 15 - digitPosition - 1;
		if(e < 0){
			n = Math.round(n/10**Math.abs(e));
		}else{
			n = Math.round(n*10**e);
		}

		m = n;
		d = 0;
		for(i = 0; i < 15 - index; i = i + 1){
			d = Math.round(m%10);
			m = m - d;
			m = Math.round(m/10);
		}

		return d;
	}


	function GetDigit(n : number, base : number, index : number) : number{
		var d : number, digitPosition : number, e : number, m : number, maximumDigits : number, i : number;

		n = Math.abs(n);
		maximumDigits = GetMaximumDigitsForBase(base);
		digitPosition = GetFirstDigitPosition(n, base);

		e = maximumDigits - digitPosition - 1;
		if(e < 0){
			n = Math.round(n/base**Math.abs(e));
		}else{
			n = Math.round(n*base**e);
		}

		m = n;
		d = 0;
		for(i = 0; i < maximumDigits - index; i = i + 1){
			d = Math.round(m%base);
			m = m - d;
			m = Math.round(m/base);
		}

		return d;
	}


	function NumberToHumanReadableShortScale(n : number) : string []{
		var res : string [], suffix : string [];
		var hasSuffix : boolean;
		var k : number, M : number, B : number, T : number, Q : number;

		k = 1000;
		M = k*1000;
		B = M*1000;
		T = B*1000;
		Q = T*1000;
		suffix = " ".split('');

		if(n < k){
			hasSuffix = false;
		}else{
			hasSuffix = true;
		}

		if(n >= k && n < M){
			if(n < 10*k){
				n = Round(n/100);
				n = n/10;
			}else{
				n = Round(n/k);
			}
			suffix = "k".split('');
		}else if(n >= M && n < B){
			if(n < 10*M){
				n = Round(n/(k*100));
				n = n/10;
			}else{
				n = Round(n/M);
			}
			suffix = "M".split('');
		}else if(n >= B && n < T){
			if(n < 10*B){
				n = Round(n/(M*100));
				n = n/10;
			}else{
				n = Round(n/B);
			}
			suffix = "B".split('');
		}else if(n >= T && n < Q){
			if(n < 10*T){
				n = Round(n/(B*100));
				n = n/10;
			}else{
				n = Round(n/T);
			}
			suffix = "T".split('');
		}else if(n >= Q){
			if(n < 10*Q){
				n = Round(n/(T*100));
				n = n/10;
			}else{
				n = Round(n/Q);
			}
			suffix = "Q".split('');
		}

		res = CreateStringDecimalFromNumber(n);
		if(hasSuffix){
			res = strAppendString(res, suffix);
		}
        
		return res;
	}


	function NumberToHumanReadableBinary(n : number) : string []{
		var res : string [], suffix : string [];
		var hasSuffix : boolean;
		var Ki : number, Mi : number, Gi : number, Ti : number, Pi : number, Ei : number, Zi : number, Yi : number;

		Ki = 1024;
		Mi = Ki*1024;
		Gi = Mi*1024;
		Ti = Gi*1024;
		Pi = Ti*1024;
		Ei = Pi*1024;
		Zi = Ei*1024;
		Yi = Zi*1024;
		suffix = " ".split('');

		if(n < Ki){
			hasSuffix = false;
		}else{
			hasSuffix = true;
		}

		if(n >= Ki && n < Mi){
			if(n < 10*Ki){
				n = Round(n/(Ki/10));
				n = n/10;
			}else{
				n = Round(n/Ki);
			}
			suffix = "Ki".split('');
		}else if(n >= Mi && n < Gi){
			if(n < 10*Mi){
				n = Round(n/(Mi/10));
				n = n/10;
			}else{
				n = Round(n/Mi);
			}
			suffix = "Mi".split('');
		}else if(n >= Gi && n < Ti){
			if(n < 10*Gi){
				n = Round(n/(Gi/10));
				n = n/10;
			}else{
				n = Round(n/Gi);
			}
			suffix = "Gi".split('');
		}else if(n >= Ti && n < Pi){
			if(n < 10*Ti){
				n = Round(n/(Ti/10));
				n = n/10;
			}else{
				n = Round(n/Ti);
			}
			suffix = "Ti".split('');
		}else if(n >= Pi && n < Ei){
			if(n < 10*Pi){
				n = Round(n/(Pi/10));
				n = n/10;
			}else{
				n = Round(n/Pi);
			}
			suffix = "Pi".split('');
		}else if(n >= Ei && n < Zi){
			if(n < 10*Ei){
				n = Round(n/(Ei/10));
				n = n/10;
			}else{
				n = Round(n/Ei);
			}
			suffix = "Ei".split('');
		}else if(n >= Zi && n < Yi){
			if(n < 10*Zi){
				n = Round(n/(Zi/10));
				n = n/10;
			}else{
				n = Round(n/Zi);
			}
			suffix = "Zi".split('');
		}else if(n >= Yi){
			if(n < 10*Yi){
				n = Round(n/(Yi/10));
				n = n/10;
			}else{
				n = Round(n/Yi);
			}
			suffix = "Yi".split('');
		}

		res = CreateStringDecimalFromNumber(n);
		if(hasSuffix){
			res = strAppendString(res, suffix);
		}

		return res;
	}


	function NumberToHumanReadableMetric(n : number) : string []{
		var res : string [], suffix : string [];
		var hasSuffix : boolean;
		var k : number, M : number, G : number, T : number, P : number, Ex : number, Z : number, Y : number, R : number, Q : number;

		k = 1000;
		M = k*1000;
		G = M*1000;
		T = G*1000;
		P = T*1000;
		Ex = P*1000;
		Z = Ex*1000;
		Y = Z*1000;
		R = Y*1000;
		Q = R*1000;
		suffix = " ".split('');

		if(n < k){
			hasSuffix = false;
		}else{
			hasSuffix = true;
		}

		if(n >= k && n < M){
			if(n < 10*k){
				n = Round(n/100);
				n = n/10;
			}else{
				n = Round(n/k);
			}
			suffix = "k".split('');
		}else if(n >= M && n < G){
			if(n < 10*M){
				n = Round(n/(k*100));
				n = n/10;
			}else{
				n = Round(n/M);
			}
			suffix = "M".split('');
		}else if(n >= G && n < T){
			if(n < 10*G){
				n = Round(n/(M*100));
				n = n/10;
			}else{
				n = Round(n/G);
			}
			suffix = "G".split('');
		}else if(n >= T && n < P){
			if(n < 10*T){
				n = Round(n/(G*100));
				n = n/10;
			}else{
				n = Round(n/T);
			}
			suffix = "T".split('');
		}else if(n >= P && n < Ex){
			if(n < 10*P){
				n = Round(n/(T*100));
				n = n/10;
			}else{
				n = Round(n/P);
			}
			suffix = "P".split('');
		}else if(n >= Ex && n < Z){
			if(n < 10*Ex){
				n = Round(n/(P*100));
				n = n/10;
			}else{
				n = Round(n/Ex);
			}
			suffix = "E".split('');
		}else if(n >= Z && n < Y){
			if(n < 10*Z){
				n = Round(n/(Ex*100));
				n = n/10;
			}else{
				n = Round(n/Z);
			}
			suffix = "Z".split('');
		}else if(n >= Y && n < R){
			if(n < 10*Y){
				n = Round(n/(Z*100));
				n = n/10;
			}else{
				n = Round(n/Y);
			}
			suffix = "Y".split('');
		}else if(n >= R && n < Q){
			if(n < 10*R){
				n = Round(n/(Y*100));
				n = n/10;
			}else{
				n = Round(n/R);
			}
			suffix = "R".split('');
		}else if(n >= Q){
			if(n < 10*Q){
				n = Round(n/(R*100));
				n = n/10;
			}else{
				n = Round(n/Q);
			}
			suffix = "Q".split('');
		}

		res = CreateStringDecimalFromNumber(n);
		if(hasSuffix){
			res = strAppendString(res, suffix);
		}

		return res;
	}


	function IsValidNumber(str : string []) : boolean{
		var valid : boolean;
		var numberRef : NumberReference;
		var message : StringReference;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		numberRef = undefined;
		message = undefined;

		return valid;
	}


	function IsValidInteger(str : string []) : boolean{
		var valid : boolean;
		var numberRef : NumberReference;
		var message : StringReference;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		if(valid){
			valid = IsInteger(numberRef.numberValue);
		}

		numberRef = undefined;
		message = undefined;

		return valid;
	}


	function IsValidPositiveInteger(str : string []) : boolean{
		var valid : boolean;
		var numberRef : NumberReference;
		var message : StringReference;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		if(valid){
			valid = IsInteger(numberRef.numberValue);
			if(valid){
				valid = numberRef.numberValue >= 0;
			}
		}

		numberRef = undefined;
		message = undefined;

		return valid;
	}


	function CreateNumberFromDecimalStringWithCheck(stringx : string [], decimalReference : NumberReference, message : StringReference) : boolean{
		return CreateNumberFromStringWithCheck(stringx, 10, decimalReference, message);
	}


	function CreateNumberFromDecimalString(stringx : string []) : number{
		var doubleReference : NumberReference;
		var stringReference : StringReference;
		var numberx : number;

		doubleReference = CreateNumberReference(0);
		stringReference = CreateStringReference("".split(''));
		CreateNumberFromStringWithCheck(stringx, 10, doubleReference, stringReference);
		numberx = doubleReference.numberValue;

		doubleReference = undefined;
		stringReference = undefined;

		return numberx;
	}


	function CreateNumberFromStringWithCheck(stringx : string [], base : number, numberReference : NumberReference, message : StringReference) : boolean{
		var success : boolean;
		var numberIsPositive : BooleanReference, exponentIsPositive : BooleanReference;
		var beforePoint : NumberArrayReference, afterPoint : NumberArrayReference, exponent : NumberArrayReference;

		numberIsPositive = CreateBooleanReference(true);
		exponentIsPositive = CreateBooleanReference(true);
		beforePoint = new NumberArrayReference();
		afterPoint = new NumberArrayReference();
		exponent = new NumberArrayReference();

		if(base >= 2 && base <= 36){
			success = ExtractPartsFromNumberString(stringx, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

			if(success){
				numberReference.numberValue = CreateNumberFromParts(base, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray);
			}
		}else{
			success = false;
			message.stringx = "Base must be from 2 to 36.".split('');
		}

		return success;
	}


	function CreateNumberFromParts(base : number, numberIsPositive : boolean, beforePoint : number [], afterPoint : number [], exponentIsPositive : boolean, exponent : number []) : number{
		var n : number, i : number, p : number, e : number;

		n = 0;

		for(i = 0; i < beforePoint.length; i = i + 1){
			p = beforePoint[beforePoint.length - i - 1];

			n = n + p*base**i;
		}

		for(i = 0; i < afterPoint.length; i = i + 1){
			p = afterPoint[i];

			n = n + p/base**(i + 1);
		}

		if(exponent.length > 0){
			e = 0;
			for(i = 0; i < exponent.length; i = i + 1){
				p = exponent[exponent.length - i - 1];

				e = e + p*base**i;
			}

			if(!exponentIsPositive){
				e = -e;
			}

			n = n*base**e;
		}

		if(!numberIsPositive){
			n = -n;
		}

		return n;
	}


	function ExtractPartsFromNumberString(n : string [], base : number, numberIsPositive : BooleanReference, beforePoint : NumberArrayReference, afterPoint : NumberArrayReference, exponentIsPositive : BooleanReference, exponent : NumberArrayReference, errorMessages : StringReference) : boolean{
		var i : number, j : number, count : number;
		var success : boolean, done : boolean, complete : boolean;

		i = 0;
		complete = false;

		if(i < n.length){
			if(n[i] == '-'){
				numberIsPositive.booleanValue = false;
				i = i + 1;
			}else if(n[i] == '+'){
				numberIsPositive.booleanValue = true;
				i = i + 1;
			}

			success = true;
		}else{
			success = false;
			errorMessages.stringx = "Number cannot have length zero.".split('');
		}

		if(success){
			done = false;
			count = 0;
			for(; i + count < n.length && !done; ){
				if(CharacterIsNumberCharacterInBase(n[i + count], base)){
					count = count + 1;
				}else{
					done = true;
				}
			}

			if(count >= 1){
				beforePoint.numberArray = new Array<number>(count);

				for(j = 0; j < count; j = j + 1){
					beforePoint.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base);
				}

				i = i + count;

				if(i < n.length){
					success = true;
				}else{
					afterPoint.numberArray = new Array<number>(0);
					exponent.numberArray = new Array<number>(0);
					success = true;
					complete = true;
				}
			}else{
				success = false;
				errorMessages.stringx = "Number must have at least one number after the optional sign.".split('');
			}
		}

		if(success && !complete){
			if(n[i] == '.'){
				i = i + 1;

				if(i < n.length){
					done = false;
					count = 0;
					for(; i + count < n.length && !done; ){
						if(CharacterIsNumberCharacterInBase(n[i + count], base)){
							count = count + 1;
						}else{
							done = true;
						}
					}

					if(count >= 1){
						afterPoint.numberArray = new Array<number>(count);

						for(j = 0; j < count; j = j + 1){
							afterPoint.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base);
						}

						i = i + count;

						if(i < n.length){
							success = true;
						}else{
							exponent.numberArray = new Array<number>(0);
							success = true;
							complete = true;
						}
					}else{
						success = false;
						errorMessages.stringx = "There must be at least one digit after the decimal point.".split('');
					}
				}else{
					success = false;
					errorMessages.stringx = "There must be at least one digit after the decimal point.".split('');
				}
			}else if(base <= 14 && (n[i] == 'e' || n[i] == 'E')){
				if(i < n.length){
					success = true;
					afterPoint.numberArray = new Array<number>(0);
				}else{
					success = false;
					errorMessages.stringx = "There must be at least one digit after the exponent.".split('');
				}
			}else{
				success = false;
				errorMessages.stringx = "Expected decimal point or exponent symbol.".split('');
			}
		}

		if(success && !complete){
			if(base <= 14 && (n[i] == 'e' || n[i] == 'E')){
				i = i + 1;

				if(i < n.length){
					if(n[i] == '-'){
						exponentIsPositive.booleanValue = false;
						i = i + 1;
					}else if(n[i] == '+'){
						exponentIsPositive.booleanValue = true;
						i = i + 1;
					}

					if(i < n.length){
						done = false;
						count = 0;
						for(; i + count < n.length && !done; ){
							if(CharacterIsNumberCharacterInBase(n[i + count], base)){
								count = count + 1;
							}else{
								done = true;
							}
						}

						if(count >= 1){
							exponent.numberArray = new Array<number>(count);

							for(j = 0; j < count; j = j + 1){
								exponent.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base);
							}

							i = i + count;

							if(i == n.length){
								success = true;
							}else{
								success = false;
								errorMessages.stringx = "There cannot be any characters past the exponent of the number.".split('');
							}
						}else{
							success = false;
							errorMessages.stringx = "There must be at least one digit after the decimal point.".split('');
						}
					}else{
						success = false;
						errorMessages.stringx = "There must be at least one digit after the exponent symbol.".split('');
					}
				}else{
					success = false;
					errorMessages.stringx = "There must be at least one digit after the exponent symbol.".split('');
				}
			}else{
				success = false;
				errorMessages.stringx = "Expected exponent symbol.".split('');
			}
		}

		return success;
	}


	function GetNumberFromNumberCharacterForBase(c : string, base : number) : number{
		var numberTable : string [];
		var i : number;
		var position : number;

		numberTable = GetDigitCharacterTable();
		position = 0;

		for(i = 0; i < base; i = i + 1){
			if(numberTable[i] == c){
				position = i;
			}
		}

		return position;
	}


	function CharacterIsNumberCharacterInBase(c : string, base : number) : boolean{
		var numberTable : string [];
		var i : number;
		var found : boolean;

		numberTable = GetDigitCharacterTable();
		found = false;

		for(i = 0; i < base; i = i + 1){
			if(numberTable[i] == c){
				found = true;
			}
		}

		return found;
	}


	function StringToNumberArray(str : string []) : number []{
		var numberArrayReference : NumberArrayReference;
		var stringReference : StringReference;
		var numbers : number [];

		numberArrayReference = new NumberArrayReference();
		stringReference = new StringReference();

		StringToNumberArrayWithCheck(str, numberArrayReference, stringReference);

		numbers = numberArrayReference.numberArray;

		numberArrayReference = undefined;
		stringReference = undefined;

		return numbers;
	}


	function StringToNumberArrayWithCheck(str : string [], numberArrayReference : NumberArrayReference, errorMessage : StringReference) : boolean{
		var numberStrings : StringReference [];
		var numbers : number [];
		var i : number;
		var numberString : string [], trimmedNumberString : string [];
		var success : boolean;
		var numberReference : NumberReference;

		numberStrings = strSplitByString(str, ",".split(''));

		numbers = new Array<number>(numberStrings.length);
		success = true;
		numberReference = new NumberReference();

		for(i = 0; i < numberStrings.length; i = i + 1){
			numberString = numberStrings[i].stringx;
			trimmedNumberString = strTrim(numberString);
			success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage);
			numbers[i] = numberReference.numberValue;

			FreeStringReference(numberStrings[i]);
			trimmedNumberString = undefined;
		}

		numberStrings = undefined;
		numberReference = undefined;

		numberArrayReference.numberArray = numbers;

		return success;
	}


	function strWriteStringToStingStream(stream : string [], index : NumberReference, src : string []) : void{
		var i : number;

		for(i = 0; i < src.length; i = i + 1){
			stream[index.numberValue + i] = src[i];
		}
		index.numberValue = index.numberValue + src.length;
	}


	function strWriteCharacterToStingStream(stream : string [], index : NumberReference, src : string) : void{
		stream[index.numberValue] = src;
		index.numberValue = index.numberValue + 1;
	}


	function strWriteBooleanToStingStream(stream : string [], index : NumberReference, src : boolean) : void{
		if(src){
			strWriteStringToStingStream(stream, index, "true".split(''));
		}else{
			strWriteStringToStingStream(stream, index, "false".split(''));
		}
	}


	function strSubstringWithCheck(stringx : string [], fromx : number, to : number, stringReference : StringReference) : boolean{
		var success : boolean;

		if(fromx >= 0 && fromx <= stringx.length && to >= 0 && to <= stringx.length && fromx <= to){
			stringReference.stringx = strSubstring(stringx, fromx, to);
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function strSubstring(stringx : string [], fromx : number, to : number) : string []{
		var n : string [];
		var i : number, length : number;

		length = to - fromx;

		n = new Array<string>(length);

		for(i = fromx; i < to; i = i + 1){
			n[i - fromx] = stringx[i];
		}

		return n;
	}


	function strAppendString(s1 : string [], s2 : string []) : string []{
		var newString : string [];

		newString = strConcatenateString(s1, s2);

		s1 = undefined;

		return newString;
	}


	function strConcatenateString(s1 : string [], s2 : string []) : string []{
		var newString : string [];
		var i : number;

		newString = new Array<string>(s1.length + s2.length);

		for(i = 0; i < s1.length; i = i + 1){
			newString[i] = s1[i];
		}

		for(i = 0; i < s2.length; i = i + 1){
			newString[s1.length + i] = s2[i];
		}

		return newString;
	}


	function strAppendCharacter(stringx : string [], c : string) : string []{
		var newString : string [];

		newString = strConcatenateCharacter(stringx, c);

		stringx = undefined;

		return newString;
	}


	function strConcatenateCharacter(stringx : string [], c : string) : string []{
		var newString : string [];
		var i : number;
		newString = new Array<string>(stringx.length + 1);

		for(i = 0; i < stringx.length; i = i + 1){
			newString[i] = stringx[i];
		}

		newString[stringx.length] = c;

		return newString;
	}


	function strSplitByCharacter(toSplit : string [], splitBy : string) : StringReference []{
		var parts : StringReference [];
		var i : number;
		var c : string;
		var ll : LinkedListStrings;
		var next : LinkedListCharacters;
		var part : string [];

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0; i < toSplit.length; i = i + 1){
			c = toSplit[i];

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


	function strIndexOfCharacter(stringx : string [], character : string, indexReference : NumberReference) : boolean{
		var i : number;
		var found : boolean;

		found = false;
		for(i = 0; i < stringx.length && !found; i = i + 1){
			if(stringx[i] == character){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}


	function strLastIndexOfCharacter(stringx : string [], character : string, indexReference : NumberReference) : boolean{
		var i : number;
		var found : boolean;

		found = false;
		for(i = 0; i < stringx.length; i = i + 1){
			if(stringx[i] == character){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}


	function strSubstringEqualsWithCheck(stringx : string [], fromx : number, substring : string [], equalsReference : BooleanReference) : boolean{
		var success : boolean;

		if(fromx < stringx.length){
			success = true;
			equalsReference.booleanValue = strSubstringEquals(stringx, fromx, substring);
		}else{
			success = false;
		}

		return success;
	}


	function strSubstringEquals(stringx : string [], fromx : number, substring : string []) : boolean{
		var i : number;
		var equal : boolean;

		equal = true;
		if(stringx.length - fromx >= substring.length){
			for(i = 0; i < substring.length && equal; i = i + 1){
				if(stringx[fromx + i] != substring[i]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function strIndexOfString(stringx : string [], substring : string [], indexReference : NumberReference) : boolean{
		var i : number;
		var found : boolean;

		found = false;
		for(i = 0; i < stringx.length - substring.length + 1 && !found; i = i + 1){
			if(strSubstringEquals(stringx, i, substring)){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}


	function strContainsCharacter(stringx : string [], character : string) : boolean{
		var i : number;
		var found : boolean;

		found = false;
		for(i = 0; i < stringx.length && !found; i = i + 1){
			if(stringx[i] == character){
				found = true;
			}
		}

		return found;
	}


	function strContainsString(stringx : string [], substring : string []) : boolean{
		return strIndexOfString(stringx, substring, new NumberReference());
	}


	function strToUpperCase(stringx : string []) : void{
		var i : number;

		for(i = 0; i < stringx.length; i = i + 1){
			stringx[i] = cToUpperCase(stringx[i]);
		}
	}


	function strToLowerCase(stringx : string []) : void{
		var i : number;

		for(i = 0; i < stringx.length; i = i + 1){
			stringx[i] = cToLowerCase(stringx[i]);
		}
	}


	function strEqualsIgnoreCase(a : string [], b : string []) : boolean{
		var equal : boolean;
		var i : number;

		if(a.length == b.length){
			equal = true;
			for(i = 0; i < a.length && equal; i = i + 1){
				if(cToLowerCase(a[i]) != cToLowerCase(b[i])){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}


	function strReplaceString(stringx : string [], toReplace : string [], replaceWith : string []) : string []{
		var result : string [];
		var i : number, j : number;
		var equalsReference : BooleanReference;
		var success : boolean;
		var da : DynamicArrayCharacters;

		da = CreateDynamicArrayCharacters();

		equalsReference = new BooleanReference();

		for(i = 0; i < stringx.length; ){
			success = strSubstringEqualsWithCheck(stringx, i, toReplace, equalsReference);
			if(success){
				success = equalsReference.booleanValue;
			}

			if(success && toReplace.length > 0){
				for(j = 0; j < replaceWith.length; j = j + 1){
					DynamicArrayAddCharacter(da, replaceWith[j]);
				}
				i = i + toReplace.length;
			}else{
				DynamicArrayAddCharacter(da, stringx[i]);
				i = i + 1;
			}
		}

		result = DynamicArrayCharactersToArray(da);

		FreeDynamicArrayCharacters(da);

		return result;
	}


	function strReplaceCharacterToNew(stringx : string [], toReplace : string, replaceWith : string) : string []{
		var result : string [];
		var i : number;

		result = new Array<string>(stringx.length);

		for(i = 0; i < stringx.length; i = i + 1){
			if(stringx[i] == toReplace){
				result[i] = replaceWith;
			}else{
				result[i] = stringx[i];
			}
		}

		return result;
	}


	function strReplaceCharacter(stringx : string [], toReplace : string, replaceWith : string) : void{
		var i : number;

		for(i = 0; i < stringx.length; i = i + 1){
			if(stringx[i] == toReplace){
				stringx[i] = replaceWith;
			}
		}
	}


	function strTrim(stringx : string []) : string []{
		var result : string [];
		var i : number, lastWhitespaceLocationStart : number, lastWhitespaceLocationEnd : number;
		var firstNonWhitespaceFound : boolean;

		/* Find whitepaces at the start.*/
		lastWhitespaceLocationStart = -1;
		firstNonWhitespaceFound = false;
		for(i = 0; i < stringx.length && !firstNonWhitespaceFound; i = i + 1){
			if(cIsWhiteSpace(stringx[i])){
				lastWhitespaceLocationStart = i;
			}else{
				firstNonWhitespaceFound = true;
			}
		}

		/* Find whitepaces at the end.*/
		lastWhitespaceLocationEnd = stringx.length;
		firstNonWhitespaceFound = false;
		for(i = stringx.length - 1; i >= 0 && !firstNonWhitespaceFound; i = i - 1){
			if(cIsWhiteSpace(stringx[i])){
				lastWhitespaceLocationEnd = i;
			}else{
				firstNonWhitespaceFound = true;
			}
		}

		if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
			result = strSubstring(stringx, lastWhitespaceLocationStart + 1, lastWhitespaceLocationEnd);
		}else{
			result = new Array<string>(0);
		}

		return result;
	}


	function strStartsWith(stringx : string [], start : string []) : boolean{
		var startsWithString : boolean;

		startsWithString = false;
		if(stringx.length >= start.length){
			startsWithString = strSubstringEquals(stringx, 0, start);
		}

		return startsWithString;
	}


	function strEndsWith(stringx : string [], end : string []) : boolean{
		var endsWithString : boolean;

		endsWithString = false;
		if(stringx.length >= end.length){
			endsWithString = strSubstringEquals(stringx, stringx.length - end.length, end);
		}

		return endsWithString;
	}


	function strSplitByString(toSplit : string [], splitBy : string []) : StringReference []{
		var parts : StringReference [];
		var i : number;
		var c : string;
		var ll : LinkedListStrings;
		var next : LinkedListCharacters;
		var part : string [];

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0; i < toSplit.length; ){
			c = toSplit[i];

			if(strSubstringEquals(toSplit, i, splitBy)){
				part = LinkedListCharactersToArray(next);
				LinkedListAddString(ll, part);
				FreeLinkedListCharacter(next);
				next = CreateLinkedListCharacter();
				i = i + splitBy.length;
			}else{
				LinkedListAddCharacter(next, c);
				i = i + 1;
			}
		}

		part = LinkedListCharactersToArray(next);
		LinkedListAddString(ll, part);
		FreeLinkedListCharacter(next);

		parts = LinkedListStringsToArray(ll);
		FreeLinkedListString(ll);

		return parts;
	}


	function strStringIsBefore(a : string [], b : string []) : boolean{
		var before : boolean, equal : boolean, done : boolean;
		var i : number;

		before = false;
		equal = true;
		done = false;

		if(a.length == 0 && b.length > 0){
			before = true;
		}else{
			for(i = 0; i < a.length && i < b.length && !done; i = i + 1){
				if(a[i] != b[i]){
					equal = false;
				}
				if(cCharacterIsBefore(a[i], b[i])){
					before = true;
				}
				if(cCharacterIsBefore(b[i], a[i])){
					done = true;
				}
			}

			if(equal){
				if(a.length < b.length){
					before = true;
				}
			}
		}

		return before;
	}


	function strJoinStringsWithSeparator(strings : StringReference [], separator : string []) : string []{
		var result : string [], stringx : string [];
		var length : number, i : number;
		var index : NumberReference;

		index = CreateNumberReference(0);

		length = 0;
		for(i = 0; i < strings.length; i = i + 1){
			length = length + strings[i].stringx.length;
		}
		length = length + (strings.length - 1)*separator.length;

		result = new Array<string>(length);

		for(i = 0; i < strings.length; i = i + 1){
			stringx = strings[i].stringx;
			strWriteStringToStingStream(result, index, stringx);
			if(i + 1 < strings.length){
				strWriteStringToStingStream(result, index, separator);
			}
		}

		index = undefined;

		return result;
	}


	function strJoinStrings(strings : StringReference []) : string []{
		var result : string [], stringx : string [];
		var length : number, i : number;
		var index : NumberReference;

		index = CreateNumberReference(0);

		length = 0;
		for(i = 0; i < strings.length; i = i + 1){
			length = length + strings[i].stringx.length;
		}

		result = new Array<string>(length);

		for(i = 0; i < strings.length; i = i + 1){
			stringx = strings[i].stringx;
			strWriteStringToStingStream(result, index, stringx);
		}

		index = undefined;

		return result;
	}


	function strStringOrder(a : string [], b : string []) : number{
		var order : number, minimum : number, i : number, ac : number, bc : number;
		var done : boolean;

		minimum = Math.min(a.length, b.length);

		done = false;
		order = 0;
		for(i = 0; i < minimum && !done; i = i + 1){
			ac = a[i].charCodeAt(0);
			bc = b[i].charCodeAt(0);

			if(ac < bc){
				done = true;
				order = 1;
			}else if(ac > bc){
				done = true;
				order = -1;
			}
		}

		if(!done){
			if(a.length < b.length){
				order = 1;
			}else if(a.length > b.length){
				order = -1;
			}
		}

		return order;
	}


	function strLeftPad(str : string [], width : number) : string []{
		var i : number;
		var padded : string [];

		padded = new Array<string>(width);
		arraysFillString(padded, ' ');

		for(i = 0; i < str.length; i = i + 1){
			padded[width - str.length + i] = str[i];
		}

		return padded;
	}


	function strRightPad(str : string [], width : number) : string []{
		var i : number;
		var padded : string [];

		padded = new Array<string>(width);
		arraysFillString(padded, ' ');

		for(i = 0; i < str.length; i = i + 1){
			padded[i] = str[i];
		}

		return padded;
	}


	function AssertFalse(b : boolean, failures : NumberReference) : void{
		if(b){
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertTrue(b : boolean, failures : NumberReference) : void{
		if(!b){
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertEquals(a : number, b : number, failures : NumberReference) : void{
		if(a != b){
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertBooleansEqual(a : boolean, b : boolean, failures : NumberReference) : void{
		if(a != b){
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertCharactersEqual(a : string, b : string, failures : NumberReference) : void{
		if(a != b){
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertStringEquals(a : string [], b : string [], failures : NumberReference) : void{
		if(!arraysStringsEqual(a, b)){
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertNumberArraysEqual(a : number [], b : number [], failures : NumberReference) : void{
		var i : number;

		if(a.length == b.length){
			for(i = 0; i < a.length; i = i + 1){
				AssertEquals(a[i], b[i], failures);
			}
		}else{
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertBooleanArraysEqual(a : boolean [], b : boolean [], failures : NumberReference) : void{
		var i : number;

		if(a.length == b.length){
			for(i = 0; i < a.length; i = i + 1){
				AssertBooleansEqual(a[i], b[i], failures);
			}
		}else{
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function AssertStringArraysEqual(a : StringReference [], b : StringReference [], failures : NumberReference) : void{
		var i : number;

		if(a.length == b.length){
			for(i = 0; i < a.length; i = i + 1){
				AssertStringEquals(a[i].stringx, b[i].stringx, failures);
			}
		}else{
			failures.numberValue = failures.numberValue + 1;
		}
	}


	function Negate(x : number) : number{
		return -x;
	}


	function Positive(x : number) : number{
		return +x;
	}


	function Factorial(x : number) : number{
		var i : number, f : number;

		f = 1;

		for(i = 2; i <= x; i = i + 1){
			f = f*i;
		}

		return f;
	}


	function Round(x : number) : number{
		return Math.floor(x + 0.5);
	}


	function RoundToDigits(element : number, digitsAfterPoint : number) : number{
		return Round(element*10**digitsAfterPoint)/10**digitsAfterPoint;
	}


	function BankersRound(x : number) : number{
		var r : number;

		if(Absolute(x - Truncate(x)) == 0.5){
			if(!DivisibleBy(Round(x), 2)){
				r = Round(x) - 1;
			}else{
				r = Round(x);
			}
		}else{
			r = Round(x);
		}

		return r;
	}


	function Ceil(x : number) : number{
		return Math.ceil(x);
	}


	function Floor(x : number) : number{
		return Math.floor(x);
	}


	function Truncate(x : number) : number{
		var t : number;

		if(x >= 0){
			t = Math.floor(x);
		}else{
			t = Math.ceil(x);
		}

		return t;
	}


	function Absolute(x : number) : number{
		return Math.abs(x);
	}


	function Logarithm(x : number) : number{
		return Math.log10(x);
	}


	function NaturalLogarithm(x : number) : number{
		return Math.log(x);
	}


	function Sin(x : number) : number{
		return Math.sin(x);
	}


	function Cos(x : number) : number{
		return Math.cos(x);
	}


	function Tan(x : number) : number{
		return Math.tan(x);
	}


	function Asin(x : number) : number{
		return Math.asin(x);
	}


	function Acos(x : number) : number{
		return Math.acos(x);
	}


	function Atan(x : number) : number{
		return Math.atan(x);
	}


	function Atan2(y : number, x : number) : number{
		var a : number;

		/* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.*/
		a = 0;

		if(x > 0){
			a = Atan(y/x);
		}else if(x < 0 && y >= 0){
			a = Atan(y/x) + Math.PI;
		}else if(x < 0 && y < 0){
			a = Atan(y/x) - Math.PI;
		}else if(x == 0 && y > 0){
			a = Math.PI/2;
		}else if(x == 0 && y < 0){
			a = -Math.PI/2;
		}

		return a;
	}


	function Squareroot(x : number) : number{
		return Math.sqrt(x);
	}


	function Exp(x : number) : number{
		return Math.exp(x);
	}


	function DivisibleBy(a : number, b : number) : boolean{
		return ((a%b) == 0);
	}


	function Combinations(n : number, k : number) : number{
		var i : number, j : number, c : number;

		c = 1;
		j = 1;
		i = n - k + 1;

		for(; i <= n; ){
			c = c*i;
			c = c/j;

			i = i + 1;
			j = j + 1;
		}

		return c;
	}


	function Permutations(n : number, k : number) : number{
		var i : number, c : number;

		c = 1;

		for(i = n - k + 1; i <= n; i = i + 1){
			c = c*i;
		}

		return c;
	}


	function EpsilonCompare(a : number, b : number, epsilon : number) : boolean{
		return Math.abs(a - b) < epsilon;
	}


	function GreatestCommonDivisor(a : number, b : number) : number{
		var t : number;

		for(; b != 0; ){
			t = b;
			b = a%b;
			a = t;
		}

		return a;
	}


	function GCDWithSubtraction(a : number, b : number) : number{
		var g : number;

		if(a == 0){
			g = b;
		}else{
			for(; b != 0; ){
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


	function IsInteger(a : number) : boolean{
		return (a - Math.floor(a)) == 0;
	}


	function GreatestCommonDivisorWithCheck(a : number, b : number, gcdReference : NumberReference) : boolean{
		var success : boolean;
		var gcd : number;

		if(IsInteger(a) && IsInteger(b)){
			gcd = GreatestCommonDivisor(a, b);
			gcdReference.numberValue = gcd;
			success = true;
		}else{
			success = false;
		}

		return success;
	}


	function LeastCommonMultiple(a : number, b : number) : number{
		var lcm : number;

		if(a > 0 && b > 0){
			lcm = Math.abs(a*b)/GreatestCommonDivisor(a, b);
		}else{
			lcm = 0;
		}

		return lcm;
	}


	function Sign(a : number) : number{
		var s : number;

		if(a > 0){
			s = 1;
		}else if(a < 0){
			s = -1;
		}else{
			s = 0;
		}

		return s;
	}


	function Max(a : number, b : number) : number{
		return Math.max(a, b);
	}


	function Min(a : number, b : number) : number{
		return Math.min(a, b);
	}


	function Power(a : number, b : number) : number{
		return a**b;
	}


	function Gamma(x : number) : number{
		return LanczosApproximation(x);
	}


	function LogGamma(x : number) : number{
		return Math.log(Gamma(x));
	}


	function LanczosApproximation(z : number) : number{
		var p : number [];
		var i : number, y : number, t : number, x : number;

		p = new Array<number>(8);
		p[0] = 676.5203681218851;
		p[1] = -1259.1392167224028;
		p[2] = 771.32342877765313;
		p[3] = -176.61502916214059;
		p[4] = 12.507343278686905;
		p[5] = -0.13857109526572012;
		p[6] = 9.9843695780195716e-6;
		p[7] = 1.5056327351493116e-7;

		if(z < 0.5){
			y = Math.PI/(Math.sin(Math.PI*z)*LanczosApproximation(1 - z));
		}else{
			z = z - 1;
			x = 0.99999999999980993;
			for(i = 0; i < p.length; i = i + 1){
				x = x + p[i]/(z + i + 1);
			}
			t = z + p.length - 0.5;
			y = Math.sqrt(2*Math.PI)*t**(z + 0.5)*Math.exp(-t)*x;
		}

		return y;
	}


	function Beta(x : number, y : number) : number{
		return Gamma(x)*Gamma(y)/Gamma(x + y);
	}


	function Sinh(x : number) : number{
		return (Math.exp(x) - Math.exp(-x))/2;
	}


	function Cosh(x : number) : number{
		return (Math.exp(x) + Math.exp(-x))/2;
	}


	function Tanh(x : number) : number{
		return Sinh(x)/Cosh(x);
	}


	function Cot(x : number) : number{
		return 1/Math.tan(x);
	}


	function Sec(x : number) : number{
		return 1/Math.cos(x);
	}


	function Csc(x : number) : number{
		return 1/Math.sin(x);
	}


	function Coth(x : number) : number{
		return Cosh(x)/Sinh(x);
	}


	function Sech(x : number) : number{
		return 1/Cosh(x);
	}


	function Csch(x : number) : number{
		return 1/Sinh(x);
	}


	function Errorx(x : number) : number{
		var y : number, t : number, tau : number, c1 : number, c2 : number, c3 : number, c4 : number, c5 : number, c6 : number, c7 : number, c8 : number, c9 : number, c10 : number;

		if(x == 0){
			y = 0;
		}else if(x < 0){
			y = -Errorx(-x);
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

			t = 1/(1 + 0.5*Math.abs(x));

			tau = t*Math.exp(-(x**2) + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))));

			y = 1 - tau;
		}

		return y;
	}


	function ErrorInverse(x : number) : number{
		var y : number, a : number, t : number;

		a = (8*(Math.PI - 3))/(3*Math.PI*(4 - Math.PI));

		t = 2/(Math.PI*a) + Math.log(1 - x**2)/2;
		y = Sign(x)*Math.sqrt(Math.sqrt(t**2 - Math.log(1 - x**2)/a) - t);

		return y;
	}


	function FallingFactorial(x : number, n : number) : number{
		var k : number, y : number;

		y = 1;

		for(k = 0; k <= n - 1; k = k + 1){
			y = y*(x - k);
		}

		return y;
	}


	function RisingFactorial(x : number, n : number) : number{
		var k : number, y : number;

		y = 1;

		for(k = 0; k <= n - 1; k = k + 1){
			y = y*(x + k);
		}

		return y;
	}


	function Hypergeometric(a : number, b : number, c : number, z : number, maxIterations : number, precision : number) : number{
		var y : number;

		if(Math.abs(z) >= 0.5){
			y = (1 - z)**(-a)*HypergeometricDirect(a, c - b, c, z/(z - 1), maxIterations, precision);
		}else{
			y = HypergeometricDirect(a, b, c, z, maxIterations, precision);
		}

		return y;
	}


	function HypergeometricDirect(a : number, b : number, c : number, z : number, maxIterations : number, precision : number) : number{
		var y : number, yp : number, n : number;
		var done : boolean;

		y = 0;
		done = false;

		for(n = 0; n < maxIterations && !done; n = n + 1){
			yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*z**n/Factorial(n);
			if(Math.abs(yp) < precision){
				done = true;
			}
			y = y + yp;
		}

		return y;
	}


	function BernouilliNumber(n : number) : number{
		return AkiyamaTanigawaAlgorithm(n);
	}


	function AkiyamaTanigawaAlgorithm(n : number) : number{
		var m : number, j : number, B : number;
		var A : number [];

		A = new Array<number>(n + 1);

		for(m = 0; m <= n; m = m + 1){
			A[m] = 1/(m + 1);
			for(j = m; j >= 1; j = j - 1){
				A[j - 1] = j*(A[j - 1] - A[j]);
			}
		}

		B = A[0];

		A = undefined;

		return B;
	}


	function D15Add(a : number, b : number, overflow : BooleanReference) : number{
		var x : number;

		x = a + b;

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function RoundTo15Digits(x : number) : number{
		var p : number;

		p = Math.floor(Math.log10(x));
		x = x*10**(15 - p);
		x = Round(x);
		x = x/10**(15 - p);

		return x;
	}


	function D15MaxValue() : number{
		return +9.99999999999999e99;
	}


	function D15MinValue() : number{
		return -9.99999999999999e99;
	}


	function D15Multiply(a : number, b : number, overflow : BooleanReference) : number{
		var x : number;

		x = a*b;

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15Divide(a : number, b : number, reminder : NumberReference, overflow : BooleanReference, invalidOperation : BooleanReference) : number{
		var x : number, r : number;

		if(b != 0){
			invalidOperation.booleanValue = false;

			x = a/b;
			r = a%b;

			if(x > D15MaxValue() || x < D15MinValue()){
				overflow.booleanValue = true;
				x = 0;
				r = 0;
			}else{
				overflow.booleanValue = false;
				x = RoundTo15Digits(x);
				r = RoundTo15Digits(r);
			}
		}else{
			invalidOperation.booleanValue = true;
			overflow.booleanValue = false;
			x = 0;
			r = 0;
		}

		reminder.numberValue = r;

		return x;
	}


	function D15Exponentiation(a : number, b : number, overflow : BooleanReference, invalidOperation : BooleanReference) : number{
		var x : number;

		if(a == 0 && b == 0){
			invalidOperation.booleanValue = true;
			overflow.booleanValue = false;
			x = 0;
		}else if(a < 0 && !IsInteger(b)){
			invalidOperation.booleanValue = true;
			overflow.booleanValue = false;
			x = 0;
		}else{
			invalidOperation.booleanValue = false;

			x = a**b;

			if(x > D15MaxValue() || x < D15MinValue()){
				overflow.booleanValue = true;
				x = 0;
			}else{
				overflow.booleanValue = false;
				x = RoundTo15Digits(x);
			}
		}

		return x;
	}


	function D15Modulus(a : number, b : number, invalidOperation : BooleanReference) : number{
		var x : number;

		if(a < 0 || b == 0 || b < 0){
			invalidOperation.booleanValue = true;
			x = 0;
		}else{
			invalidOperation.booleanValue = false;
			x = a%b;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15Logarithm(a : number, invalidOperation : BooleanReference) : number{
		var x : number;

		if(a <= 0){
			invalidOperation.booleanValue = true;
			x = 0;
		}else{
			invalidOperation.booleanValue = false;
			x = Math.log10(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15NaturalLogarithm(a : number, invalidOperation : BooleanReference) : number{
		var x : number;

		if(a <= 0){
			invalidOperation.booleanValue = true;
			x = 0;
		}else{
			invalidOperation.booleanValue = false;
			x = Math.log(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15Sin(a : number) : number{
		var x : number;

		x = Math.sin(a);
		x = RoundTo15Digits(x);

		return x;
	}


	function D15Cos(x : number) : number{
		var a : number, y : number, piBy2Part1 : number, piBy2Part2 : number, limit : number, f : number;

		x = Math.abs(x);

		limit = Math.PI + 3.1/2;

		if(x > limit){
			f = Math.floor(x/Math.PI);
			x = x - Math.PI*f;
		}

		piBy2Part1 = +1.57079632679490;
		piBy2Part2 = -3.38076867830836e-15;

		if(x > 3.1/2 && x < 3.3/2){
			a = x - piBy2Part1;
			a = Math.round(a*10**15)/10**15;
			a = a - piBy2Part2;
			y = -Math.sin(a);
		}else{
			y = Math.cos(x);
			y = RoundTo15Digits(y);
		}

		return y;
	}


	function D15Tan(a : number, overflow : BooleanReference) : number{
		var x : number;

		x = Math.tan(a);

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15Asin(a : number, invalidOperation : BooleanReference) : number{
		var x : number;

		if(a < -1 || a > 1){
			invalidOperation.booleanValue = true;
			x = 0;
		}else{
			invalidOperation.booleanValue = false;
			x = Math.asin(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15Acos(a : number, invalidOperation : BooleanReference) : number{
		var x : number;

		if(a < -1 || a > 1){
			invalidOperation.booleanValue = true;
			x = 0;
		}else{
			invalidOperation.booleanValue = false;
			x = Math.acos(a);
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function D15Atan(a : number) : number{
		var x : number;

		x = Math.atan(a);
		x = RoundTo15Digits(x);

		return x;
	}


	function D15Sqrt(a : number) : number{
		var x : number;

		x = Math.sqrt(a);
		x = RoundTo15Digits(x);

		return x;
	}


	function D15Exponential(a : number, overflow : BooleanReference) : number{
		var x : number;

		x = Math.exp(a);

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true;
			x = 0;
		}else{
			overflow.booleanValue = false;
			x = RoundTo15Digits(x);
		}

		return x;
	}


	function Decimal15E2ToString(decimal : number) : string []{
		var multiplier : number, inc : number, i : number, d : number;
		var exponent : number;
		var done : boolean, isPositive : boolean, isPositiveExponent : boolean;
		var result : string [];
		var len : number;

		len = 21;
		/* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"*/
		result = new Array<string>(len);

		done = false;
		exponent = 0;

		if(decimal < 0){
			isPositive = false;
			decimal = -decimal;
		}else{
			isPositive = true;
		}

		if(decimal == 0){
			done = true;
		}

		if(!done){
			multiplier = 0;
			inc = 0;

			if(decimal < 1){
				multiplier = 10;
				inc = -1;
			}else if(decimal >= 10){
				multiplier = 0.1;
				inc = 1;
			}else{
				done = true;
			}

			if(!done){
				exponent = Math.round(Math.log10(decimal));
				exponent = Math.min(99, exponent);
				exponent = Math.max(-99, exponent);

				decimal = decimal/10**exponent;

				/* Adjust*/
				for(; (decimal >= 10 || decimal < 1) && Math.abs(exponent) < 99; ){
					decimal = decimal*multiplier;
					exponent = exponent + inc;
				}
			}
		}

		isPositiveExponent = exponent >= 0;
		if(!isPositiveExponent){
			exponent = -exponent;
		}

		if(isPositive){
			result[0] = '+';
		}else{
			result[0] = '-';
		}

		decimal = Math.round(decimal*10**14);

		d = Math.floor(decimal/10**14);
		result[1] = SingleDigitNumberToCharacter(d);
		decimal = decimal - d*10**14;

		result[2] = '.';

		for(i = 0; i < 14; i = i + 1){
			d = Math.floor(decimal/10**(13 - i));
			result[3 + i] = SingleDigitNumberToCharacter(d);
			decimal = decimal - d*10**(13 - i);
		}

		result[17] = 'e';

		if(isPositiveExponent){
			result[18] = '+';
		}else{
			result[18] = '-';
		}

		result[19] = SingleDigitNumberToCharacter(Math.floor(exponent/10));
		result[20] = SingleDigitNumberToCharacter(Math.floor(exponent%10));

		return result;
	}


	function SingleDigitNumberToCharacter(n : number) : string{
		var c : string;

		c = '0';
		if(n == 0){
			c = '0';
		}else if(n == 1){
			c = '1';
		}else if(n == 2){
			c = '2';
		}else if(n == 3){
			c = '3';
		}else if(n == 4){
			c = '4';
		}else if(n == 5){
			c = '5';
		}else if(n == 6){
			c = '6';
		}else if(n == 7){
			c = '7';
		}else if(n == 8){
			c = '8';
		}else if(n == 9){
			c = '9';
		}

		return c;
	}


	function cToLowerCase(character : string) : string{
		var toReturn : string;

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


	function cToUpperCase(character : string) : string{
		var toReturn : string;

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


	function cIsUpperCase(character : string) : boolean{
		var isUpper : boolean;

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


	function cIsLowerCase(character : string) : boolean{
		var isLower : boolean;

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


	function cIsLetter(character : string) : boolean{
		return cIsUpperCase(character) || cIsLowerCase(character);
	}


	function cIsNumber(character : string) : boolean{
		var isNumberx : boolean;

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


	function cIsWhiteSpace(character : string) : boolean{
		var isWhiteSpacex : boolean;

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


	function cIsSymbol(character : string) : boolean{
		var isSymbolx : boolean;

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


	function cCharacterIsBefore(a : string, b : string) : boolean{
		var ad : number, bd : number;

		ad = a.charCodeAt(0);
		bd = b.charCodeAt(0);

		return ad < bd;
	}


	function cDecimalDigitToCharacter(digit : number) : string{
		var c : string;
		if(digit == 1){
			c = '1';
		}else if(digit == 2){
			c = '2';
		}else if(digit == 3){
			c = '3';
		}else if(digit == 4){
			c = '4';
		}else if(digit == 5){
			c = '5';
		}else if(digit == 6){
			c = '6';
		}else if(digit == 7){
			c = '7';
		}else if(digit == 8){
			c = '8';
		}else if(digit == 9){
			c = '9';
		}else{
			c = '0';
		}
		return c;
	}


	function cCharacterToDecimalDigit(c : string) : number{
		var digit : number;

		if(c == '1'){
			digit = 1;
		}else if(c == '2'){
			digit = 2;
		}else if(c == '3'){
			digit = 3;
		}else if(c == '4'){
			digit = 4;
		}else if(c == '5'){
			digit = 5;
		}else if(c == '6'){
			digit = 6;
		}else if(c == '7'){
			digit = 7;
		}else if(c == '8'){
			digit = 8;
		}else if(c == '9'){
			digit = 9;
		}else{
			digit = 0;
		}

		return digit;
	}



