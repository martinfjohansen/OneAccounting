// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

import Foundation

class CharacterArray{
    var ca : [Character]!
}

func characterArray(_ x : String) -> CharacterArray{
    let ca = CharacterArray()
    ca.ca = Array(x)
    return ca
}
func charToDouble(_ c : Character) -> Double{
    return Double(c.unicodeScalars.map{$0.value}.reduce(0, +))
}
/* Downloaded from https://repo.progsbase.com - Code Developed Using progsbase. */

public class Account{
	public var name : [Character]!
	public var endingBalance : FixedPoint15d!
	public var startingBalance : FixedPoint15d!
	public var from : Date!
	public var to : Date!
	public var sumDebit : FixedPoint15d!
	public var sumCredit : FixedPoint15d!
}
public class AccountReferenceClass{
	public var ref : Account!
}
func AccountCreateFunction() -> AccountReferenceClass{
	var returnReference = AccountReferenceClass()
	returnReference.ref = Account()
	return returnReference
}
public class AccountDefinition{
	public var accountName : [Character]!
	public var number : [Character]!
	public var role : [Character]!
	public var debitBalance : Bool!
}
public class AccountDefinitionReferenceClass{
	public var ref : AccountDefinition!
}
func AccountDefinitionCreateFunction() -> AccountDefinitionReferenceClass{
	var returnReference = AccountDefinitionReferenceClass()
	returnReference.ref = AccountDefinition()
	return returnReference
}
public class AccountPlan{
	public var accountDefinitions : [AccountDefinition]!
}
public class AccountPlanReferenceClass{
	public var ref : AccountPlan!
}
func AccountPlanCreateFunction() -> AccountPlanReferenceClass{
	var returnReference = AccountPlanReferenceClass()
	returnReference.ref = AccountPlan()
	return returnReference
}
public class Ledger{
	public var decimals : Double!
	public var transactions : [Transaction]!
	public var accountPlan : AccountPlan!
}
public class LedgerReferenceClass{
	public var ref : Ledger!
}
func LedgerCreateFunction() -> LedgerReferenceClass{
	var returnReference = LedgerReferenceClass()
	returnReference.ref = Ledger()
	return returnReference
}
public class Line{
	public var account : [Character]!
	public var debit : FixedPoint15d!
	public var credit : FixedPoint15d!
	public var description : [Character]!
	public var date : Date!
}
public class LineReferenceClass{
	public var ref : Line!
}
func LineCreateFunction() -> LineReferenceClass{
	var returnReference = LineReferenceClass()
	returnReference.ref = Line()
	return returnReference
}
public class Transaction{
	public var lines : [Line]!
}
public class TransactionReferenceClass{
	public var ref : Transaction!
}
func TransactionCreateFunction() -> TransactionReferenceClass{
	var returnReference = TransactionReferenceClass()
	returnReference.ref = Transaction()
	return returnReference
}
public class BooleanArrayReference{
	public var booleanArray : [Bool]!
}
public class BooleanArrayReferenceReferenceClass{
	public var ref : BooleanArrayReference!
}
func BooleanArrayReferenceCreateFunction() -> BooleanArrayReferenceReferenceClass{
	var returnReference = BooleanArrayReferenceReferenceClass()
	returnReference.ref = BooleanArrayReference()
	return returnReference
}
public class BooleanReference{
	public var booleanValue : Bool!
}
public class BooleanReferenceReferenceClass{
	public var ref : BooleanReference!
}
func BooleanReferenceCreateFunction() -> BooleanReferenceReferenceClass{
	var returnReference = BooleanReferenceReferenceClass()
	returnReference.ref = BooleanReference()
	return returnReference
}
public class CharacterReference{
	public var characterValue : Character!
}
public class CharacterReferenceReferenceClass{
	public var ref : CharacterReference!
}
func CharacterReferenceCreateFunction() -> CharacterReferenceReferenceClass{
	var returnReference = CharacterReferenceReferenceClass()
	returnReference.ref = CharacterReference()
	return returnReference
}
public class NumberArrayReference{
	public var numberArray : [Double]!
}
public class NumberArrayReferenceReferenceClass{
	public var ref : NumberArrayReference!
}
func NumberArrayReferenceCreateFunction() -> NumberArrayReferenceReferenceClass{
	var returnReference = NumberArrayReferenceReferenceClass()
	returnReference.ref = NumberArrayReference()
	return returnReference
}
public class NumberReference{
	public var numberValue : Double!
}
public class NumberReferenceReferenceClass{
	public var ref : NumberReference!
}
func NumberReferenceCreateFunction() -> NumberReferenceReferenceClass{
	var returnReference = NumberReferenceReferenceClass()
	returnReference.ref = NumberReference()
	return returnReference
}
public class StringArrayReference{
	public var stringArray : [StringReference]!
}
public class StringArrayReferenceReferenceClass{
	public var ref : StringArrayReference!
}
func StringArrayReferenceCreateFunction() -> StringArrayReferenceReferenceClass{
	var returnReference = StringArrayReferenceReferenceClass()
	returnReference.ref = StringArrayReference()
	return returnReference
}
public class StringReference{
	public var stringx : [Character]!
}
public class StringReferenceReferenceClass{
	public var ref : StringReference!
}
func StringReferenceCreateFunction() -> StringReferenceReferenceClass{
	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = StringReference()
	return returnReference
}
public class Date{
	public var year : Double!
	public var month : Double!
	public var day : Double!
}
public class DateReferenceClass{
	public var ref : Date!
}
func DateCreateFunction() -> DateReferenceClass{
	var returnReference = DateReferenceClass()
	returnReference.ref = Date()
	return returnReference
}
public class DateReference{
	public var date : Date!
}
public class DateReferenceReferenceClass{
	public var ref : DateReference!
}
func DateReferenceCreateFunction() -> DateReferenceReferenceClass{
	var returnReference = DateReferenceReferenceClass()
	returnReference.ref = DateReference()
	return returnReference
}
public class Interval{
	public var first : Date!
	public var last : Date!
}
public class IntervalReferenceClass{
	public var ref : Interval!
}
func IntervalCreateFunction() -> IntervalReferenceClass{
	var returnReference = IntervalReferenceClass()
	returnReference.ref = Interval()
	return returnReference
}
public class DateTimeTimezone{
	public var dateTime : DateTime!
	public var timezoneOffsetSeconds : Double!
}
public class DateTimeTimezoneReferenceClass{
	public var ref : DateTimeTimezone!
}
func DateTimeTimezoneCreateFunction() -> DateTimeTimezoneReferenceClass{
	var returnReference = DateTimeTimezoneReferenceClass()
	returnReference.ref = DateTimeTimezone()
	return returnReference
}
public class DateTimeTimezoneReference{
	public var dateTimeTimezone : DateTimeTimezone!
}
public class DateTimeTimezoneReferenceReferenceClass{
	public var ref : DateTimeTimezoneReference!
}
func DateTimeTimezoneReferenceCreateFunction() -> DateTimeTimezoneReferenceReferenceClass{
	var returnReference = DateTimeTimezoneReferenceReferenceClass()
	returnReference.ref = DateTimeTimezoneReference()
	return returnReference
}
public class DateTime{
	public var date : Date!
	public var hours : Double!
	public var minutes : Double!
	public var seconds : Double!
}
public class DateTimeReferenceClass{
	public var ref : DateTime!
}
func DateTimeCreateFunction() -> DateTimeReferenceClass{
	var returnReference = DateTimeReferenceClass()
	returnReference.ref = DateTime()
	return returnReference
}
public class DateTimeReference{
	public var dateTime : DateTime!
}
public class DateTimeReferenceReferenceClass{
	public var ref : DateTimeReference!
}
func DateTimeReferenceCreateFunction() -> DateTimeReferenceReferenceClass{
	var returnReference = DateTimeReferenceReferenceClass()
	returnReference.ref = DateTimeReference()
	return returnReference
}
public class FixedPoint30d{
	public var part1 : Double!
	public var part2 : Double!
	public var digitsBeforeDecimalPoint : Double!
	public var digitsAfterDecimalPoint : Double!
}
public class FixedPoint30dReferenceClass{
	public var ref : FixedPoint30d!
}
func FixedPoint30dCreateFunction() -> FixedPoint30dReferenceClass{
	var returnReference = FixedPoint30dReferenceClass()
	returnReference.ref = FixedPoint30d()
	return returnReference
}
public class FixedPoint15d{
	public var number : Double!
	public var digitsBeforeDecimalPoint : Double!
	public var digitsAfterDecimalPoint : Double!
}
public class FixedPoint15dReferenceClass{
	public var ref : FixedPoint15d!
}
func FixedPoint15dCreateFunction() -> FixedPoint15dReferenceClass{
	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = FixedPoint15d()
	return returnReference
}
public class DynamicArrayCharacters{
	public var array : [Character]!
	public var length : Double!
}
public class DynamicArrayCharactersReferenceClass{
	public var ref : DynamicArrayCharacters!
}
func DynamicArrayCharactersCreateFunction() -> DynamicArrayCharactersReferenceClass{
	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = DynamicArrayCharacters()
	return returnReference
}
public class LinkedListNodeStrings{
	public var end : Bool!
	public var value : [Character]!
	public var next : LinkedListNodeStrings!
}
public class LinkedListNodeStringsReferenceClass{
	public var ref : LinkedListNodeStrings!
}
func LinkedListNodeStringsCreateFunction() -> LinkedListNodeStringsReferenceClass{
	var returnReference = LinkedListNodeStringsReferenceClass()
	returnReference.ref = LinkedListNodeStrings()
	return returnReference
}
public class LinkedListStrings{
	public var first : LinkedListNodeStrings!
	public var last : LinkedListNodeStrings!
}
public class LinkedListStringsReferenceClass{
	public var ref : LinkedListStrings!
}
func LinkedListStringsCreateFunction() -> LinkedListStringsReferenceClass{
	var returnReference = LinkedListStringsReferenceClass()
	returnReference.ref = LinkedListStrings()
	return returnReference
}
public class LinkedListNodeNumbers{
	public var next : LinkedListNodeNumbers!
	public var end : Bool!
	public var value : Double!
}
public class LinkedListNodeNumbersReferenceClass{
	public var ref : LinkedListNodeNumbers!
}
func LinkedListNodeNumbersCreateFunction() -> LinkedListNodeNumbersReferenceClass{
	var returnReference = LinkedListNodeNumbersReferenceClass()
	returnReference.ref = LinkedListNodeNumbers()
	return returnReference
}
public class LinkedListNumbers{
	public var first : LinkedListNodeNumbers!
	public var last : LinkedListNodeNumbers!
}
public class LinkedListNumbersReferenceClass{
	public var ref : LinkedListNumbers!
}
func LinkedListNumbersCreateFunction() -> LinkedListNumbersReferenceClass{
	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = LinkedListNumbers()
	return returnReference
}
public class LinkedListCharacters{
	public var first : LinkedListNodeCharacters!
	public var last : LinkedListNodeCharacters!
}
public class LinkedListCharactersReferenceClass{
	public var ref : LinkedListCharacters!
}
func LinkedListCharactersCreateFunction() -> LinkedListCharactersReferenceClass{
	var returnReference = LinkedListCharactersReferenceClass()
	returnReference.ref = LinkedListCharacters()
	return returnReference
}
public class LinkedListNodeCharacters{
	public var end : Bool!
	public var value : Character!
	public var next : LinkedListNodeCharacters!
}
public class LinkedListNodeCharactersReferenceClass{
	public var ref : LinkedListNodeCharacters!
}
func LinkedListNodeCharactersCreateFunction() -> LinkedListNodeCharactersReferenceClass{
	var returnReference = LinkedListNodeCharactersReferenceClass()
	returnReference.ref = LinkedListNodeCharacters()
	return returnReference
}
public class DynamicArrayNumbers{
	public var array : [Double]!
	public var length : Double!
}
public class DynamicArrayNumbersReferenceClass{
	public var ref : DynamicArrayNumbers!
}
func DynamicArrayNumbersCreateFunction() -> DynamicArrayNumbersReferenceClass{
	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = DynamicArrayNumbers()
	return returnReference
}
public class Arrayx{
	public var array : [Data]!
	public var length : Double!
}
public class ArrayxReferenceClass{
	public var ref : Arrayx!
}
func ArrayxCreateFunction() -> ArrayxReferenceClass{
	var returnReference = ArrayxReferenceClass()
	returnReference.ref = Arrayx()
	return returnReference
}
public class Data{
	public var isStruture : Bool!
	public var isArray : Bool!
	public var isNumber : Bool!
	public var isString : Bool!
	public var isBoolean : Bool!
	public var structure : Structure!
	public var array : Arrayx!
	public var number : Double!
	public var booleanx : Bool!
	public var stringx : [Character]!
}
public class DataReferenceClass{
	public var ref : Data!
}
func DataCreateFunction() -> DataReferenceClass{
	var returnReference = DataReferenceClass()
	returnReference.ref = Data()
	return returnReference
}
public class DataReference{
	public var data : Data!
}
public class DataReferenceReferenceClass{
	public var ref : DataReference!
}
func DataReferenceCreateFunction() -> DataReferenceReferenceClass{
	var returnReference = DataReferenceReferenceClass()
	returnReference.ref = DataReference()
	return returnReference
}
public class Structure{
	public var keys : Arrayx!
	public var values : Arrayx!
}
public class StructureReferenceClass{
	public var ref : Structure!
}
func StructureCreateFunction() -> StructureReferenceClass{
	var returnReference = StructureReferenceClass()
	returnReference.ref = Structure()
	return returnReference
}
func CreateLedger(_ decimals : Double) -> StructureReferenceClass{
	var decimals = decimals;
	var ledger : Structure
	var transactions : Arrayx

	ledger = CreateStructure().ref
	transactions = CreateArray().ref
	AddNumberToStruct(&ledger, &characterArray("decimals").ca, decimals)
	AddArrayToStruct(&ledger, &characterArray("transactions").ca, &transactions)

	var returnReference = StructureReferenceClass()
	returnReference.ref = ledger
	return returnReference
}


func CreateFixedPointForDynamicLedger(_ ledger : inout Structure) -> FixedPoint15dReferenceClass{
	var n : FixedPoint15d
	var d : Double

	d = GetNumberFromStruct(&ledger, &characterArray("decimals").ca)
	n = CreateFixedPoint15d(15.0 - d, d).ref

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = n
	return returnReference
}


func CreateFixedPointForStaticLedger(_ ledger : inout Ledger) -> FixedPoint15dReferenceClass{
	var n : FixedPoint15d
	var d : Double

	d = ledger.decimals
	n = CreateFixedPoint15d(15.0 - d, d).ref

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = n
	return returnReference
}


func CreateLine(_ account : inout [Character], _ debit : inout FixedPoint15d, _ credit : inout FixedPoint15d, _ description : inout [Character], _ date : inout Date) -> LineReferenceClass{
	var t : Line

	t = Line()

	t.account = arraysCopyString(&account)
	t.debit = Copy15d(&debit).ref
	t.credit = Copy15d(&credit).ref
	t.description = arraysCopyString(&description)
	t.date = CopyDate(&date).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = t
	return returnReference
}


func AddTransactionToLedger(_ ledger : inout Arrayx, _ src : inout Line) -> Void{
	var dst : Structure

	dst = LineToStructure(&src).ref

	AddStructToArray(&ledger, &dst)
}


func AddTransactionsToLedger(_ ledger : inout Arrayx, _ ts : inout [Line]) -> Void{
	var dst : Structure
	var i : Double

	i = 0.0
	while(i < Double(ts.count)){
		dst = LineToStructure(&ts[Int(i)]).ref
		AddStructToArray(&ledger, &dst)
		i = i + 1.0
	}
}


func ValidateAndAddTransactionToLedger(_ ledger : inout Structure, _ ls : inout [Line]) -> Bool{
	var dst : Structure
	var i : Double
	var valid : Bool
	var transactions : Arrayx
	var lines : Arrayx

	transactions = GetArrayFromStruct(&ledger, &characterArray("transactions").ca).ref

	valid = ValidateTransaction(&ls, &ledger)

	if(valid){
		lines = CreateArray().ref

		i = 0.0
		while(i < Double(ls.count)){
			dst = LineToStructure(&ls[Int(i)]).ref
			AddStructToArray(&lines, &dst)
			i = i + 1.0
		}

		AddArrayToArray(&transactions, &lines)
	}

	return valid
}


func GetTransactionFromLedger(_ ledger : inout Structure, _ index : Double) -> LineReferenceClass{
	var index = index;
	var dst : Structure
	var t : Line
	var transactions : Arrayx
	var decimals : Double

	transactions = GetArrayFromStruct(&ledger, &characterArray("transactions").ca).ref
	decimals = GetNumberFromStruct(&ledger, &characterArray("decimals").ca)

	dst = ArrayIndexStruct(&transactions, index).ref

	t = LineFromStructure(&dst, &ledger).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = t
	return returnReference
}


func LineToStructure(_ src : inout Line) -> StructureReferenceClass{
	var dst : Structure
	var debitStr, creditStr, dateStr : [Character]

	dst = CreateStructure().ref

	debitStr = ToString15d(&src.debit)
	creditStr = ToString15d(&src.credit)
	dateStr = DateToStringISO8601(&src.date)

	AddStringToStruct(&dst, &characterArray("account").ca, &src.account)
	AddStringToStruct(&dst, &characterArray("debit").ca, &debitStr)
	AddStringToStruct(&dst, &characterArray("credit").ca, &creditStr)
	AddStringToStruct(&dst, &characterArray("date").ca, &dateStr)
	AddStringToStruct(&dst, &characterArray("description").ca, &src.description)

	var returnReference = StructureReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func LineFromStructure(_ src : inout Structure, _ ledger : inout Structure) -> LineReferenceClass{
	var dst : Line
	var account, debitStr, creditStr, dateStr, description : [Character]
	var debit, credit : FixedPoint15d
	var date : Date
	var debitNumber, creditNumber : Double

	account = GetStringFromStruct(&src, &characterArray("account").ca)
	debitStr = GetStringFromStruct(&src, &characterArray("debit").ca)
	creditStr = GetStringFromStruct(&src, &characterArray("credit").ca)
	dateStr = GetStringFromStruct(&src, &characterArray("date").ca)
	description = GetStringFromStruct(&src, &characterArray("description").ca)

	debitNumber = CreateNumberFromDecimalString(&debitStr)
	creditNumber = CreateNumberFromDecimalString(&creditStr)

	debit = CreateFixedPointForDynamicLedger(&ledger).ref
	credit = CreateFixedPointForDynamicLedger(&ledger).ref
	Assign15d(&debit, debitNumber)
	Assign15d(&credit, creditNumber)

	date = DateFromStringISO8601(&dateStr).ref

	dst = CreateLine(&account, &debit, &credit, &description, &date).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func LedgerDynamicToStatic(_ src : inout Structure) -> LedgerReferenceClass{
	var dst : Ledger
	var ts, ls, i, j, decimals : Double
	var line : Structure
	var transactions, lines : Arrayx
	var sline : Line
	var t : Transaction

	dst = Ledger()

	transactions = GetArrayFromStruct(&src, &characterArray("transactions").ca).ref
	decimals = GetNumberFromStruct(&src, &characterArray("decimals").ca)
	ts = ArrayLength(&transactions)

	dst.decimals = decimals
	dst.transactions = Array(repeating:Transaction(), count: Int(ts))

	i = 0.0
	while(i < ts){
		lines = ArrayIndexArray(&transactions, i).ref
		ls = ArrayLength(&lines)

		t = Transaction()
		t.lines = Array(repeating:Line(), count: Int(ls))

		j = 0.0
		while(j < ls){
			line = ArrayIndexStruct(&lines, j).ref
			sline = LineFromStructure(&line, &src).ref
			t.lines[Int(j)] = sline
			j = j + 1.0
		}

		dst.transactions[Int(i)] = t
		i = i + 1.0
	}

	var returnReference = LedgerReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func ValidateTransaction(_ ts : inout [Line], _ ledger : inout Structure) -> Bool{
	var valid : Bool
	var creditSum, debitSum : FixedPoint15d
	var i, d, c : Double
	var t : Line
	var creditStr, debitStr : [Character]
	var date : Date

	valid = true

	if(Double(ts.count) > 0.0){
		date = ts[Int(0)].date

		creditSum = CreateFixedPointForDynamicLedger(&ledger).ref
		debitSum = CreateFixedPointForDynamicLedger(&ledger).ref

		i = 0.0
		while(i < Double(ts.count) && valid){
			t = ts[Int(i)]

			d = ToNumber15d(&t.debit)
			c = ToNumber15d(&t.credit)

			Add15d(&creditSum, &creditSum, &t.credit)
			Add15d(&debitSum, &debitSum, &t.debit)

			if(DateEquals(&date, &t.date) && (d == 0.0 || c == 0.0)){
			}else{
				valid = false
			}
			i = i + 1.0
		}

		if(valid){
			creditStr = ToString15d(&creditSum)
			debitStr = ToString15d(&creditSum)

			valid = arraysStringsEqual(&creditStr, &debitStr)
		}
	}

	return valid
}


func ValidateTransactions(_ ts : inout [Line], _ invalidIds : inout NumberArrayReference) -> Bool{
	var valid : Bool

	/* TODO*/
	valid = true

	return valid
}


func ComputeAccountBalance(_ ledger : inout Ledger, _ accountName : inout [Character], _ fromDate : inout Date, _ toDate : inout Date) -> AccountReferenceClass{
	var a : Account
	var i, j : Double
	var t : Transaction
	var ts : [Transaction]
	var l : Line

	ts = ledger.transactions

	a = Account()

	a.name = arraysCopyString(&accountName)
	a.endingBalance = CreateFixedPointForStaticLedger(&ledger).ref
	a.startingBalance = CreateFixedPointForStaticLedger(&ledger).ref
	a.from = CopyDate(&fromDate).ref
	a.to = CopyDate(&toDate).ref
	a.sumDebit = CreateFixedPointForStaticLedger(&ledger).ref
	a.sumCredit = CreateFixedPointForStaticLedger(&ledger).ref

	i = 0.0
	while(i < Double(ts.count)){
		t = ts[Int(i)]

		j = 0.0
		while(j < Double(t.lines.count)){
			l = t.lines[Int(j)]

			if(arraysStringsEqual(&l.account, &accountName)){

				if(DateLessThan(&l.date, &fromDate)){
					Add15d(&a.startingBalance, &a.startingBalance, &l.debit)
					Subtract15d(&a.startingBalance, &a.startingBalance, &l.credit)
				}else if(DateLessThan(&l.date, &toDate)){
					Add15d(&a.endingBalance, &a.endingBalance, &l.debit)
					Subtract15d(&a.endingBalance, &a.endingBalance, &l.credit)

					Add15d(&a.sumDebit, &a.sumDebit, &l.debit)
					Add15d(&a.sumCredit, &a.sumCredit, &l.credit)
				}
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	Add15d(&a.endingBalance, &a.endingBalance, &a.startingBalance)

	var returnReference = AccountReferenceClass()
	returnReference.ref = a
	return returnReference
}


func AccountToString(_ account : inout Account) -> [Character]{
	var ll : LinkedListCharacters
	var diff : FixedPoint15d

	ll = CreateLinkedListCharacter().ref

	diff = Copy15d(&account.endingBalance).ref
	Subtract15d(&diff, &diff, &account.startingBalance)

	LinkedListCharactersAddString(&ll, &account.name)
	LinkedListCharactersAddString(&ll, &characterArray(": ").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.startingBalance, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(" -> ").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.endingBalance, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(": ").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&diff, 2.0, &characterArray(",").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(" (+").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.sumDebit, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(", -").ca)
	LinkedListCharactersAddString(&ll, &FormatToStringWithSymbols15d(&account.sumCredit, 2.0, &characterArray("").ca, &characterArray(".").ca))
	LinkedListCharactersAddString(&ll, &characterArray(")").ca)

	return LinkedListCharactersToArray(&ll)
}


func AddMonthlyAccruals(_ ledger : inout Structure, _ from : inout Date, _ to : inout Date, _ amount : Double, _ fromAccount : inout [Character], _ toAccount : inout [Character]) -> Void{
	var amount = amount;
	var i : Double
	var accountName, desc : [Character]
	var amounts : [Double]
	var transaction : [Line]
	var valid : Bool
	var date : Date
	var c, d : FixedPoint15d

	amounts = GetAccrualsWithDates(amount, &from, &to)

	date = CopyDate(&from).ref
	date.day = 1.0

	c = CreateFixedPointForDynamicLedger(&ledger).ref
	d = CreateFixedPointForDynamicLedger(&ledger).ref

	i = 0.0
	while(i < Double(amounts.count)){
		transaction = Array(repeating:Line(), count: Int(2))

		accountName = fromAccount
		Assign15d(&d, amounts[Int(i)])
		Assign15d(&c, 0.0)
		desc = characterArray("x").ca
		transaction[Int(0)] = CreateLine(&accountName, &d, &c, &desc, &date).ref

		accountName = toAccount
		Assign15d(&d, 0.0)
		Assign15d(&c, amounts[Int(i)])
		desc = characterArray("x").ca
		transaction[Int(1)] = CreateLine(&accountName, &d, &c, &desc, &date).ref

		valid = ValidateAndAddTransactionToLedger(&ledger, &transaction)

		AddMonthsToDate(&date, 1.0)
		i = i + 1.0
	}
}


func ComputeAccountBalancePrefixAccount(_ ledger : inout Ledger, _ accountNr : inout [Character], _ toDate : inout Date, _ debitBalance : Bool) -> FixedPoint15dReferenceClass{
	var debitBalance = debitBalance;
	var i, j : Double
	var t : Transaction
	var ts : [Transaction]
	var l : Line
	var balance : FixedPoint15d
	var prefixL : LinkedListCharacters
	var prefixed : [Character]

	prefixL = CreateLinkedListCharacter().ref
	LinkedListCharactersAddString(&prefixL, &accountNr)
	LinkedListCharactersAddString(&prefixL, &characterArray(".").ca)

	prefixed = LinkedListCharactersToArray(&prefixL)

	ts = ledger.transactions

	balance = CreateFixedPointForStaticLedger(&ledger).ref

	i = 0.0
	while(i < Double(ts.count)){
		t = ts[Int(i)]

		j = 0.0
		while(j < Double(t.lines.count)){
			l = t.lines[Int(j)]

			if(strStartsWith(&l.account, &prefixed) || arraysStringsEqual(&l.account, &accountNr)){
				if(DateLessThan(&l.date, &toDate) || DateEquals(&l.date, &toDate)){
					if(debitBalance){
						Add15d(&balance, &balance, &l.debit)
						Subtract15d(&balance, &balance, &l.credit)
					}else{
						Add15d(&balance, &balance, &l.credit)
						Subtract15d(&balance, &balance, &l.debit)
					}
				}
			}
			j = j + 1.0
		}
		i = i + 1.0
	}

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = balance
	return returnReference
}


func GetIFRSAccountPlan() -> AccountPlanReferenceClass{
	var accountPlanString : [Character]
	var validRef : BooleanReference
	var ll : LinkedListCharacters

	ll = CreateLinkedListCharacter().ref

	/* https://www.ifrs-gaap.com/ifrs-chart-accounts*/
	validRef = CreateBooleanReference(false).ref

	LinkedListCharactersAddString(&ll, &characterArray("1\tAssets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1\tProperty, plant and equipment\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.1\tLand and land improvements\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.2\tBuildings, structures and improvements\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.3\tMachinery and equipment\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.4\tFixtures and fittings\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.5\tRight of use assets (classified as PP&E)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.6\tAdditional property, plant and equipment\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1.7\tConstruction in progress\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.2\tInvestment property\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.2.1\tCompleted\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.2.2\tUnder construction or development\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.3\tGoodwill\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4\tIntangible assets excluding goodwill\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.1\tIntellectual property\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.2\tComputer software\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.3\tTrade and distribution assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.4\tContracts and rights\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.5\tRight of use assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.6\tCrypto assets (classified as intangible)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.7\tAdditional intangible assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.4.8\tAcquisition in progress\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5\tFinancial assets and investments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.1\tNon-derivative financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.2\tDerivative financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.3\tAdditional financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.5.4\tCrypto assets (classified as financial assets)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6\tInventories\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.1\tMerchandise\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.2\tRaw materials and production supplies\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.3\tWork in progress\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.4\tFinished goods\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.6.5\tOther inventories\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7\tPrepayments and accrued income\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.1\tPrepayments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.2\tAccrued income\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.3\tService provider work in process (not classified as inventory)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.7.4\tAdditional assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8\tReceivables and contracts\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8.1\tLoans and receivables\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8.2\tContracts with customers\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.8.3\tNontrade and other receivables\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9\tTax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9.1\tTax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9.2\tDeferred tax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.9.3\tOther tax assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.1\tAgricultural biological assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.10.1\tBearer plants\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.10.2\tAnimals\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.10.3\tOther agricultural assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11\tCash and cash equivalents\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11.1\tCash\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11.2\tCash equivalents\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("1.11.3\tRestricted cash and financial assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2\tEquity\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1\tTotal equity attributable to owners of parent\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.1\tIssued capital\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.2\tAdditional item paid-in capital\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.3\tPartner\'s capital\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.4\tMember\'s equity\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.1.5\tOther equity interest\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2\tRetained earnings\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.2.3\tIn suspense\tZero\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.3\tAccumulated other comprehensive income\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.3.2\tMiscellaneous equity\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.4\tOwners equity (non-shareholder)\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("2.5\tNon-controlling interests\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3\tLiabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1\tTrade and other payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.1\tTrade payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.2\tDividend payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.3\tInterest payable\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.1.4\tOther payables\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2\tProvisions\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2.1\tCustomer related provisions\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2.2\tLitigation and regulatory\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.2.3\tAdditional provisions\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3\tOther financial liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.1\tNotes payable\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.2\tLoans received\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.3\tBonds (debentures)\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.4\tOther debts and borrowings\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.5\tLease obligations\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.3.6\tDerivative financial liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.1\tAccruals\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.2\tDeferred income and refund liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.3\tAccrued taxes other than payroll\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("3.4.4\tAdditional liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4\tRevenue\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.1\tRecognized point of time\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.1.1\tGoods\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.1.2\tServices\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.2\tRecognized over time\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.2.1\tProducts and projects\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.2.2\tServices\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3\tAdjustments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3.1\tVariable consideration\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3.2\tConsideration paid payable to customers\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("4.3.3\tOther adjustments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5\tExpenses\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1\tExpenses (classified by nature)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.1\tMaterial and merchandise\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.2\tEmployee benefits expense\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.3\tServices expense\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.4\tRent, depreciation, amortization and depletion\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.1.6\tOther work performed by entity and capitalized\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.2\tExpenses (classified by function)\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.2.1\tCost of sales\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("5.2.2\tSelling, general and administrative expense\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6\tOther non-operating income and expenses\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.1\tOther revenue and expenses\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.1.1\tOther revenue\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.1.2\tOther expenses\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.2\tGains and losses\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.3\tTaxes other than income and payroll and fees\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("6.4\tTax income (expense)\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7\tIntercompany and related party accounts\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1\tIntercompany and related party assets\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1.1\tIntercompany balances eliminated in consolidation\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1.2\tRelated party balances reported or disclosed\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.1.3\tIntercompany investments\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.2\tIntercompany and related party liabilities\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.2.2\tRelated party balances reported or disclosed\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3\tIntercompany and related party income and expense\tDr or (Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3.1\tIntercompany and related party income\t(Cr)\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3.2\tIntercompany and related party expenses\tDr\n").ca)
	LinkedListCharactersAddString(&ll, &characterArray("7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n").ca)

	accountPlanString = LinkedListCharactersToArray(&ll)

	FreeLinkedListCharacter(&ll)

	var returnReference = AccountPlanReferenceClass()
	returnReference.ref = ParseAccountPlanString(&accountPlanString, &validRef).ref
	return returnReference
}


func ParseAccountPlanString(_ accountPlanString : inout [Character], _ valid : inout BooleanReference) -> AccountPlanReferenceClass{
	var ap : AccountPlan
	var i : Double
	var line : [Character]
	var lines, parts : [StringReference]
	var ad : AccountDefinition

	ap = AccountPlan()

	accountPlanString = strTrim(&accountPlanString)
	lines = strSplitByCharacter(&accountPlanString, "\n")

	ap.accountDefinitions = Array(repeating:AccountDefinition(), count: Int(Double(lines.count)))

	i = 0.0
	while(i < Double(lines.count)){
		line = lines[Int(i)].stringx
		/*System.out.println(line);*/
		parts = strSplitByCharacter(&line, "\t")

		ad = AccountDefinition()

		ad.accountName = parts[Int(1)].stringx
		ad.number = parts[Int(0)].stringx
		if(arraysStringsEqual(&parts[Int(2)].stringx, &characterArray("(Cr)").ca)){
			ad.debitBalance = false
		}else{
			ad.debitBalance = true
		}
		ad.role = characterArray("").ca
		if(arraysStringsEqual(&ad.number, &characterArray("1").ca)){
			ad.role = characterArray("Assets").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("2").ca)){
			ad.role = characterArray("Equities").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("3").ca)){
			ad.role = characterArray("Liabilities").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("4").ca)){
			ad.role = characterArray("Revenue").ca
		}else if(arraysStringsEqual(&ad.number, &characterArray("5").ca)){
			ad.role = characterArray("Expenses").ca
		}

		ap.accountDefinitions[Int(i)] = ad
		i = i + 1.0
	}

	var returnReference = AccountPlanReferenceClass()
	returnReference.ref = ap
	return returnReference
}


func ComputeAccountBalances(_ sledger : inout Ledger, _ depth : Double, _ date : inout Date, _ balanceSheet : inout DataReference) -> Bool{
	var depth = depth;
	var accountPlan : AccountPlan
	var assetsBalance, liabilitiesBalance, equitiesBalance, revenueBalanace, expensesBalance, resultBalance, sum, balance : FixedPoint15d
	var balanceStr : [Character]
	var assetsDef, liabilitiesDef, equitiesDef, revenueDef, expensesDef, accountDef : AccountDefinition
	var success, isBalanced : Bool
	var i : Double
	var parts : [StringReference]
	var foundRef : BooleanReference
	var accounts : Arrayx
	var account : Structure
	var dateStr : [Character]

	balanceSheet.data = CreateNewStructData().ref
	success = true

	foundRef = CreateBooleanReference(false).ref

	accountPlan = sledger.accountPlan

	assetsDef = FindAccountWithRole(&accountPlan, &characterArray("Assets").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	liabilitiesDef = FindAccountWithRole(&accountPlan, &characterArray("Liabilities").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	equitiesDef = FindAccountWithRole(&accountPlan, &characterArray("Equities").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	revenueDef = FindAccountWithRole(&accountPlan, &characterArray("Revenue").ca, &foundRef).ref
	success = success && foundRef.booleanValue
	expensesDef = FindAccountWithRole(&accountPlan, &characterArray("Expenses").ca, &foundRef).ref
	success = success && foundRef.booleanValue

	if(success){
		assetsBalance = ComputeAccountBalancePrefixAccount(&sledger, &assetsDef.number, &date, assetsDef.debitBalance).ref
		liabilitiesBalance = ComputeAccountBalancePrefixAccount(&sledger, &liabilitiesDef.number, &date, liabilitiesDef.debitBalance).ref

		/* TODO: This must be for a period*/
		revenueBalanace = ComputeAccountBalancePrefixAccount(&sledger, &revenueDef.number, &date, revenueDef.debitBalance).ref
		expensesBalance = ComputeAccountBalancePrefixAccount(&sledger, &expensesDef.number, &date, expensesDef.debitBalance).ref
		resultBalance = CreateFixedPointForStaticLedger(&sledger).ref
		Subtract15d(&resultBalance, &revenueBalanace, &expensesBalance)
		balanceStr = FormatToStringWithSymbols15d(&resultBalance, 2.0, &characterArray("").ca, &characterArray(".").ca)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("result").ca, &balanceStr)

		equitiesBalance = ComputeAccountBalancePrefixAccount(&sledger, &equitiesDef.number, &date, equitiesDef.debitBalance).ref
		Add15d(&equitiesBalance, &equitiesBalance, &resultBalance)

		/* Compute accounts*/
		accounts = CreateArray().ref

		i = 0.0
		while(i < Double(accountPlan.accountDefinitions.count)){
			accountDef = accountPlan.accountDefinitions[Int(i)]

			parts = strSplitByCharacter(&accountDef.number, ".")

			if(Double(parts.count) <= depth + 1.0){
				account = CreateStructure().ref

				balance = ComputeAccountBalancePrefixAccount(&sledger, &accountDef.number, &date, accountDef.debitBalance).ref

				balanceStr = FormatToStringWithSymbols15d(&balance, 2.0, &characterArray("").ca, &characterArray(".").ca)

				AddStringToStruct(&account, &characterArray("number").ca, &accountDef.number)
				AddStringToStruct(&account, &characterArray("name").ca, &accountDef.accountName)
				AddStringToStruct(&account, &characterArray("balance").ca, &balanceStr)
				AddNumberToStruct(&account, &characterArray("depth").ca, Double(parts.count) - 1.0)

				AddStructToArray(&accounts, &account)
			}
			i = i + 1.0
		}

		AddArrayToStruct(&balanceSheet.data.structure, &characterArray("accounts").ca, &accounts)

		/* End conclusion*/
		balanceStr = FormatToStringWithSymbols15d(&assetsBalance, 2.0, &characterArray("").ca, &characterArray(".").ca)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("assets").ca, &balanceStr)

		sum = CreateFixedPointForStaticLedger(&sledger).ref
		Add15d(&sum, &liabilitiesBalance, &equitiesBalance)
		balanceStr = FormatToStringWithSymbols15d(&sum, 2.0, &characterArray("").ca, &characterArray(".").ca)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("liabilitiesAndEquity").ca, &balanceStr)

		isBalanced = Equals15d(&sum, &assetsBalance)
		AddBooleanToStruct(&balanceSheet.data.structure, &characterArray("balanced").ca, isBalanced)

		dateStr = DateToStringISO8601(&date)
		AddStringToStruct(&balanceSheet.data.structure, &characterArray("date").ca, &dateStr)
	}

	return success
}


func AccountBalancesToString(_ balanceSheet : inout Structure) -> [Character]{
	var ll : LinkedListCharacters
	var balanceStr : [Character]
	var isBalanced : Bool
	var i, j, depth : Double
	var accounts : Arrayx
	var account : Structure
	var accountNumber, accountName : [Character]

	ll = CreateLinkedListCharacter().ref

	/* Print accounts*/
	accounts = GetArrayFromStruct(&balanceSheet, &characterArray("accounts").ca).ref

	i = 0.0
	while(i < ArrayLength(&accounts)){
		account = ArrayIndexStruct(&accounts, i).ref

		accountNumber = GetStringFromStruct(&account, &characterArray("number").ca)
		accountName = GetStringFromStruct(&account, &characterArray("name").ca)
		balanceStr = GetStringFromStruct(&account, &characterArray("balance").ca)
		depth = GetNumberFromStruct(&account, &characterArray("depth").ca)

		j = 0.0
		while(j < depth){
			LinkedListCharactersAddString(&ll, &characterArray("  ").ca)
			j = j + 1.0
		}

		LinkedListCharactersAddString(&ll, &accountNumber)
		LinkedListCharactersAddString(&ll, &characterArray(". ").ca)
		LinkedListCharactersAddString(&ll, &accountName)
		LinkedListCharactersAddString(&ll, &characterArray(": ").ca)
		LinkedListCharactersAddString(&ll, &balanceStr)
		LinkedListCharactersAddString(&ll, &characterArray("\n").ca)
		i = i + 1.0
	}

	/* End conclusion*/
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	LinkedListCharactersAddString(&ll, &characterArray("Result: ").ca)
	balanceStr = GetStringFromStruct(&balanceSheet, &characterArray("result").ca)
	LinkedListCharactersAddString(&ll, &balanceStr)
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	LinkedListCharactersAddString(&ll, &characterArray("Assets: ").ca)
	balanceStr = GetStringFromStruct(&balanceSheet, &characterArray("assets").ca)
	LinkedListCharactersAddString(&ll, &balanceStr)
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	LinkedListCharactersAddString(&ll, &characterArray("Liabilities + Equities: ").ca)
	balanceStr = GetStringFromStruct(&balanceSheet, &characterArray("liabilitiesAndEquity").ca)
	LinkedListCharactersAddString(&ll, &balanceStr)
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	isBalanced = GetBooleanFromStruct(&balanceSheet, &characterArray("balanced").ca)
	LinkedListCharactersAddString(&ll, &characterArray("Balance: ").ca)
	if(isBalanced){
		LinkedListCharactersAddString(&ll, &characterArray("true").ca)
	}else{
		LinkedListCharactersAddString(&ll, &characterArray("false").ca)
	}
	LinkedListCharactersAddString(&ll, &characterArray("\n").ca)

	return LinkedListCharactersToArray(&ll)
}


func FindAccountWithRole(_ accountPlan : inout AccountPlan, _ role : inout [Character], _ foundRef : inout BooleanReference) -> AccountDefinitionReferenceClass{
	var i : Double
	var ad : AccountDefinition
	var done : Bool

	ad = AccountDefinition()

	done = false
	i = 0.0
	while(i < Double(accountPlan.accountDefinitions.count) && !done){
		ad = accountPlan.accountDefinitions[Int(i)]
		if(arraysStringsEqual(&ad.role, &role)){
			done = true
		}
		i = i + 1.0
	}

	foundRef.booleanValue = done

	var returnReference = AccountDefinitionReferenceClass()
	returnReference.ref = ad
	return returnReference
}


func CreateAccountDefinition(_ name : inout [Character], _ number : inout [Character], _ role : inout [Character], _ debitBalance : Bool) -> AccountDefinitionReferenceClass{
	var debitBalance = debitBalance;
	var def : AccountDefinition

	def = AccountDefinition()
	def.accountName = name
	def.number = number
	def.role = role
	def.debitBalance = debitBalance

	var returnReference = AccountDefinitionReferenceClass()
	returnReference.ref = def
	return returnReference
}


func ComputeBalanceDiffs(_ sledger : inout Ledger, _ balances : inout Arrayx) -> Void{
	var i, j : Double
	var balance, first, balance1, balance2 : Structure
	var account1, account2 : Structure
	var b1, b2, diffStr : [Character]
	var f1, f2, diff : FixedPoint15d
	var accountsO, accounts1, accounts2 : Arrayx

	first = ArrayIndexStruct(&balances, 0.0).ref
	accountsO = GetArrayFromStruct(&first, &characterArray("accounts").ca).ref

	j = 0.0
	while(j < ArrayLength(&accountsO)){
		i = 1.0
		while(i < ArrayLength(&balances)){
			balance1 = ArrayIndexStruct(&balances, i - 1.0).ref
			balance2 = ArrayIndexStruct(&balances, i).ref
			accounts1 = GetArrayFromStruct(&balance1, &characterArray("accounts").ca).ref
			accounts2 = GetArrayFromStruct(&balance2, &characterArray("accounts").ca).ref

			account1 = ArrayIndexStruct(&accounts1, j).ref
			account2 = ArrayIndexStruct(&accounts2, j).ref

			b1 = GetStringFromStruct(&account1, &characterArray("balance").ca)
			b2 = GetStringFromStruct(&account2, &characterArray("balance").ca)

			f1 = CreateFixedPointForStaticLedger(&sledger).ref
			f2 = CreateFixedPointForStaticLedger(&sledger).ref
			diff = CreateFixedPointForStaticLedger(&sledger).ref

			Assign15d(&f1, CreateNumberFromDecimalString(&b1))
			Assign15d(&f2, CreateNumberFromDecimalString(&b2))

			Subtract15d(&diff, &f2, &f1)

			diffStr = FormatToStringWithSymbols15d(&diff, sledger.decimals, &characterArray("").ca, &characterArray(".").ca)

			/*System.out.println(diffStr);*/
			if(i == 1.0){
				AddStringToStruct(&account1, &characterArray("change").ca, &characterArray("0.00").ca)
			}
			AddStringToStruct(&account2, &characterArray("change").ca, &diffStr)
			i = i + 1.0
		}
		j = j + 1.0
	}

	i = 1.0
	while(i < ArrayLength(&balances)){
		balance1 = ArrayIndexStruct(&balances, i - 1.0).ref
		balance2 = ArrayIndexStruct(&balances, i).ref
		b1 = GetStringFromStruct(&balance1, &characterArray("result").ca)
		b2 = GetStringFromStruct(&balance2, &characterArray("result").ca)

		f1 = CreateFixedPointForStaticLedger(&sledger).ref
		f2 = CreateFixedPointForStaticLedger(&sledger).ref
		diff = CreateFixedPointForStaticLedger(&sledger).ref

		Assign15d(&f1, CreateNumberFromDecimalString(&b1))
		Assign15d(&f2, CreateNumberFromDecimalString(&b2))

		Subtract15d(&diff, &f2, &f1)

		diffStr = FormatToStringWithSymbols15d(&diff, sledger.decimals, &characterArray("").ca, &characterArray(".").ca)

		/*System.out.println(diffStr);*/
		if(i == 1.0){
			AddStringToStruct(&balance1, &characterArray("rchange").ca, &characterArray("0.00").ca)
		}
		AddStringToStruct(&balance2, &characterArray("rchange").ca, &diffStr)
		i = i + 1.0
	}
}


func BalancesArrayToHTML(_ balances : inout Arrayx, _ includeBalance : Bool, _ includeDiff : Bool) -> [Character]{
	var includeBalance = includeBalance;
	var includeDiff = includeDiff;
	var ll : LinkedListCharacters
	var i, j : Double
	var balance, first : Structure
	var dateStr, name, number, balanceStr, changeStr : [Character]
	var account : Structure
	var accounts : Arrayx

	ll = CreateLinkedListCharacter().ref

	LinkedListCharactersAddString(&ll, &characterArray("<html>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("<body>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("<table>").ca)

	/* Headers*/
	LinkedListCharactersAddString(&ll, &characterArray("<tr>").ca)

	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

	i = 0.0
	while(i < ArrayLength(&balances)){
		balance = ArrayIndexStruct(&balances, i).ref
		dateStr = GetStringFromStruct(&balance, &characterArray("date").ca)
		dateStr = strSubstring(&dateStr, 0.0, 7.0)

		LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
		LinkedListCharactersAddString(&ll, &dateStr)
		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
		i = i + 1.0
	}

	LinkedListCharactersAddString(&ll, &characterArray("</tr>").ca)

	/* Each account*/
	first = ArrayIndexStruct(&balances, 0.0).ref
	accounts = GetArrayFromStruct(&first, &characterArray("accounts").ca).ref
	j = 0.0
	while(j < ArrayLength(&accounts)){
		LinkedListCharactersAddString(&ll, &characterArray("<tr>").ca)

		account = ArrayIndexStruct(&accounts, j).ref
		name = GetStringFromStruct(&account, &characterArray("name").ca)
		number = GetStringFromStruct(&account, &characterArray("number").ca)

		LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
		LinkedListCharactersAddString(&ll, &number)
		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

		LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
		LinkedListCharactersAddString(&ll, &name)
		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

		i = 0.0
		while(i < ArrayLength(&balances)){
			balance = ArrayIndexStruct(&balances, i).ref
			accounts = GetArrayFromStruct(&balance, &characterArray("accounts").ca).ref
			account = ArrayIndexStruct(&accounts, j).ref
			balanceStr = GetStringFromStruct(&account, &characterArray("balance").ca)
			changeStr = GetStringFromStruct(&account, &characterArray("change").ca)

			LinkedListCharactersAddString(&ll, &characterArray("<td style=\"text-align: right;\">").ca)

			if(includeBalance && includeDiff){
				LinkedListCharactersAddString(&ll, &balanceStr)
				LinkedListCharactersAddString(&ll, &characterArray("<br><small style=\"color: grey\">").ca)
				LinkedListCharactersAddString(&ll, &changeStr)
				LinkedListCharactersAddString(&ll, &characterArray("</small>").ca)
			}else if(includeBalance){
				LinkedListCharactersAddString(&ll, &balanceStr)
			}else if(includeDiff){
				LinkedListCharactersAddString(&ll, &changeStr)
			}

			LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
			i = i + 1.0
		}

		LinkedListCharactersAddString(&ll, &characterArray("</tr>").ca)
		j = j + 1.0
	}

	/* Result*/
	LinkedListCharactersAddString(&ll, &characterArray("<tr>").ca)

	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

	LinkedListCharactersAddString(&ll, &characterArray("<td>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("Result").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)

	i = 0.0
	while(i < ArrayLength(&balances)){
		balance = ArrayIndexStruct(&balances, i).ref
		balanceStr = GetStringFromStruct(&balance, &characterArray("result").ca)
		changeStr = GetStringFromStruct(&balance, &characterArray("rchange").ca)

		LinkedListCharactersAddString(&ll, &characterArray("<td style=\"text-align: right;\">").ca)

		if(includeBalance && includeDiff){
			LinkedListCharactersAddString(&ll, &balanceStr)
			LinkedListCharactersAddString(&ll, &characterArray("<br><small style=\"color: grey\">").ca)
			LinkedListCharactersAddString(&ll, &changeStr)
			LinkedListCharactersAddString(&ll, &characterArray("</small>").ca)
		}else if(includeBalance){
			LinkedListCharactersAddString(&ll, &balanceStr)
		}else if(includeDiff){
			LinkedListCharactersAddString(&ll, &changeStr)
		}

		LinkedListCharactersAddString(&ll, &characterArray("</td>").ca)
		i = i + 1.0
	}

	LinkedListCharactersAddString(&ll, &characterArray("</tr>").ca)

	/* Footer*/
	LinkedListCharactersAddString(&ll, &characterArray("</table>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</body>").ca)
	LinkedListCharactersAddString(&ll, &characterArray("</html>").ca)

	return LinkedListCharactersToArray(&ll)
}


func CreateLineFromScript(_ ledger : inout Structure, _ script : inout [Character], _ date : inout Date) -> LineReferenceClass{
	var parts : [StringReference]
	var c, d : FixedPoint15d
	var line : Line
	var i, n : Double

	c = CreateFixedPointForDynamicLedger(&ledger).ref
	d = CreateFixedPointForDynamicLedger(&ledger).ref

	parts = strSplitByCharacter(&script, ",")

	i = 0.0
	while(i < Double(parts.count)){
		parts[Int(i)].stringx = strTrim(&parts[Int(i)].stringx)
		i = i + 1.0
	}

	line = Line()

	n = CreateNumberFromDecimalString(&parts[Int(2)].stringx)

	line.date = date
	if(arraysStringsEqual(&parts[Int(0)].stringx, &characterArray("Debit").ca)){
		Assign15d(&d, n)
		Assign15d(&c, 0.0)
	}else if(arraysStringsEqual(&parts[Int(0)].stringx, &characterArray("Credit").ca)){
		Assign15d(&d, 0.0)
		Assign15d(&c, n)
	}

	line = CreateLine(&parts[Int(1)].stringx, &d, &c, &parts[Int(3)].stringx, &date).ref

	var returnReference = LineReferenceClass()
	returnReference.ref = line
	return returnReference
}


func test() -> Double{
	var failures : NumberReference

	failures = CreateNumberReference(0.0).ref

	TestBasicAccounting(&failures)
	TestAccruals(&failures)
	TestIFRSAccountPlan(&failures)

	return failures.numberValue
}


func TestIFRSAccountPlan(_ failures : inout NumberReference) -> Void{
	GetIFRSAccountPlan().ref
}


func TestBasicAccounting(_ failures : inout NumberReference) -> Void{
	var ledger : Structure
	var c, d : FixedPoint15d
	var transaction : [Line]
	var valid : Bool
	var date, from, to : Date
	var account : Account
	var accountName, accountStr, desc : [Character]
	var sledger : Ledger

	ledger = CreateLedger(2.0).ref

	/*c = CreateFixedPointForDynamicLedger(ledger);*/
	/*d = CreateFixedPointForDynamicLedger(ledger);*/
	/* Transaction 1:*/
	transaction = Array(repeating:Line(), count: Int(2))
	/*date = CreateDate(2026d, 2d, 18d);*/
	date = DateFromStringISO8601(&characterArray("2026-02-18").ca).ref

	/* Debit, 100, 1000, l1, 2026-02-18*/
	/*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
        */
	transaction[Int(0)] = CreateLineFromScript(&ledger, &characterArray("Debit, 1000, 100, l1").ca, &date).ref

	/* Credit, 100, 2000, l2, 2026-02-18*/
	/*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
        */
	transaction[Int(1)] = CreateLineFromScript(&ledger, &characterArray("Credit, 2000, 100, l2").ca, &date).ref

	valid = ValidateAndAddTransactionToLedger(&ledger, &transaction)

	AssertTrue(valid, &failures)

	/* Compute*/
	sledger = LedgerDynamicToStatic(&ledger).ref

	accountName = characterArray("1000").ca
	from = DateFromStringISO8601(&characterArray("2026-02-17").ca).ref
	to = DateFromStringISO8601(&characterArray("2026-02-19").ca).ref
	account = ComputeAccountBalance(&sledger, &accountName, &from, &to).ref

	accountStr = AccountToString(&account)

	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)").ca, &failures)
}


func TestAccruals(_ failures : inout NumberReference) -> Void{
	var ledger : Structure
	var c, d : FixedPoint15d
	var transaction : [Line]
	var valid, success : Bool
	var date, from, to : Date
	var account : Account
	var accountName, desc, accountStr, accountSummaryStr : [Character]
	var sledger : Ledger
	var amounts : [Double]
	var i : Double
	var assetsDef, liabilitiesDef, equitiesDef, incomeDef, expensesDef, accountDef : AccountDefinition
	var a148, a150, a192, a290, a300, a600 : AccountDefinition
	var accountPlan : AccountPlan
	var balanceSheetRef : DataReference
	var html : [Character]
	var message : StringReference
	var balances : Arrayx

	ledger = CreateLedger(2.0).ref

	c = CreateFixedPointForDynamicLedger(&ledger).ref
	d = CreateFixedPointForDynamicLedger(&ledger).ref

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
	transaction = Array(repeating:Line(), count: Int(2))
	date = DateFromStringISO8601(&characterArray("2025-09-17").ca).ref
	transaction[Int(0)] = CreateLineFromScript(&ledger, &characterArray("Debit, 1.8.1, 125, x").ca, &date).ref
	transaction[Int(1)] = CreateLineFromScript(&ledger, &characterArray("Credit, 3.4.2, 125, x").ca, &date).ref
	valid = ValidateAndAddTransactionToLedger(&ledger, &transaction)
	AssertTrue(valid, &failures)

	/* Transaction: Invoice paid*/
	transaction = Array(repeating:Line(), count: Int(2))
	date = DateFromStringISO8601(&characterArray("2025-10-01").ca).ref
	transaction[Int(0)] = CreateLineFromScript(&ledger, &characterArray("Debit, 1.11.1, 125, x").ca, &date).ref
	transaction[Int(1)] = CreateLineFromScript(&ledger, &characterArray("Credit, 1.8.1, 125, x").ca, &date).ref
	valid = ValidateAndAddTransactionToLedger(&ledger, &transaction)
	AssertTrue(valid, &failures)

	/* Transaction: Renewal paid*/
	transaction = Array(repeating:Line(), count: Int(2))
	date = DateFromStringISO8601(&characterArray("2025-11-08").ca).ref
	transaction[Int(0)] = CreateLineFromScript(&ledger, &characterArray("Debit, 1.7.1, 112.50, x").ca, &date).ref
	transaction[Int(1)] = CreateLineFromScript(&ledger, &characterArray("Credit, 1.11.1, 112.50, x").ca, &date).ref
	valid = ValidateAndAddTransactionToLedger(&ledger, &transaction)
	AssertTrue(valid, &failures)

	/* Accruals income*/
	from = DateFromStringISO8601(&characterArray("2025-12-06").ca).ref
	to = DateFromStringISO8601(&characterArray("2026-12-05").ca).ref
	AddMonthlyAccruals(&ledger, &from, &to, 125.0, &characterArray("3.4.2").ca, &characterArray("4.1.2").ca)

	/* Accruals cost*/
	from = DateFromStringISO8601(&characterArray("2025-12-06").ca).ref
	to = DateFromStringISO8601(&characterArray("2026-12-05").ca).ref
	AddMonthlyAccruals(&ledger, &from, &to, 112.50, &characterArray("5.1.3").ca, &characterArray("1.7.1").ca)

	/* Compute*/
	sledger = LedgerDynamicToStatic(&ledger).ref

	from = DateFromStringISO8601(&characterArray("2027-01-01").ca).ref
	to = DateFromStringISO8601(&characterArray("2027-01-01").ca).ref

	account = ComputeAccountBalance(&sledger, &characterArray("5.1.3").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("4.1.2").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("1.8.1").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("3.4.2").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("1.11.1").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("1.7.1").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)").ca, &failures)

	/*System.out.println("");*/
	/* In between*/
	from = DateFromStringISO8601(&characterArray("2026-06-15").ca).ref
	to = DateFromStringISO8601(&characterArray("2026-06-16").ca).ref

	account = ComputeAccountBalance(&sledger, &characterArray("5.1.3").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("4.1.2").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("1.8.1").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("3.4.2").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("1.11.1").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)").ca, &failures)

	account = ComputeAccountBalance(&sledger, &characterArray("1.7.1").ca, &from, &to).ref
	accountStr = AccountToString(&account)
	/*System.out.println(accountStr);*/
	AssertStringEquals(&accountStr, &characterArray("1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)").ca, &failures)

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

	sledger.accountPlan = GetIFRSAccountPlan().ref

	to = DateFromStringISO8601(&characterArray("2026-02-16").ca).ref
	balanceSheetRef = DataReference()
	success = ComputeAccountBalances(&sledger, 2.0, &to, &balanceSheetRef)
	accountSummaryStr = AccountBalancesToString(&balanceSheetRef.data.structure)
	AssertTrue(success, &failures)
	/*System.out.println(accountSummaryStr);*/
	/* Compute monthly table*/
	to = DateFromStringISO8601(&characterArray("2025-08-01").ca).ref
	message = StringReference()
	AddDaysToDate(&to, -1.0, &message)
	balances = CreateArray().ref
	i = 0.0
	while(i < 12.0 + 6.0){
		AddDaysToDate(&to, 1.0, &message)
		AddMonthsToDate(&to, 1.0)
		AddDaysToDate(&to, -1.0, &message)

		balanceSheetRef = DataReference()
		success = ComputeAccountBalances(&sledger, 1.0, &to, &balanceSheetRef)

		if(success){
			AddStructToArray(&balances, &balanceSheetRef.data.structure)
		}
		i = i + 1.0
	}
	ComputeBalanceDiffs(&sledger, &balances)

	html = BalancesArrayToHTML(&balances, true, false)

	/*StringToFile("x.html", html);*/
	html = BalancesArrayToHTML(&balances, false, true)

	/*StringToFile("x-diff.html", html);*/
	html = BalancesArrayToHTML(&balances, true, true)
}


func CreateBooleanReference(_ value : Bool) -> BooleanReferenceReferenceClass{
	var value = value;
	var ref : BooleanReference

	ref = BooleanReference()
	ref.booleanValue = value

	var returnReference = BooleanReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateBooleanArrayReference(_ value : inout [Bool]) -> BooleanArrayReferenceReferenceClass{
	var ref : BooleanArrayReference

	ref = BooleanArrayReference()
	ref.booleanArray = value

	var returnReference = BooleanArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateBooleanArrayReferenceLengthValue(_ length : Double, _ value : Bool) -> BooleanArrayReferenceReferenceClass{
	var length = length;
	var value = value;
	var ref : BooleanArrayReference
	var i : Double

	ref = BooleanArrayReference()
	ref.booleanArray = Array(repeating:Bool(), count: Int(length))

	i = 0.0
	while(i < length){
		ref.booleanArray[Int(i)] = value
		i = i + 1.0
	}

	var returnReference = BooleanArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeBooleanArrayReference(_ booleanArrayReference : inout BooleanArrayReference) -> Void{
	delete(booleanArrayReference.booleanArray)
	delete(booleanArrayReference)
}


func CreateCharacterReference(_ value : Character) -> CharacterReferenceReferenceClass{
	var value = value;
	var ref : CharacterReference

	ref = CharacterReference()
	ref.characterValue = value

	var returnReference = CharacterReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateNumberReference(_ value : Double) -> NumberReferenceReferenceClass{
	var value = value;
	var ref : NumberReference

	ref = NumberReference()
	ref.numberValue = value

	var returnReference = NumberReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateNumberArrayReference(_ value : inout [Double]) -> NumberArrayReferenceReferenceClass{
	var ref : NumberArrayReference

	ref = NumberArrayReference()
	ref.numberArray = value

	var returnReference = NumberArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateNumberArrayReferenceLengthValue(_ length : Double, _ value : Double) -> NumberArrayReferenceReferenceClass{
	var length = length;
	var value = value;
	var ref : NumberArrayReference
	var i : Double

	ref = NumberArrayReference()
	ref.numberArray = Array(repeating:Double(), count: Int(length))

	i = 0.0
	while(i < length){
		ref.numberArray[Int(i)] = value
		i = i + 1.0
	}

	var returnReference = NumberArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeNumberArrayReference(_ numberArrayReference : inout NumberArrayReference) -> Void{
	delete(numberArrayReference.numberArray)
	delete(numberArrayReference)
}


func CreateStringReference(_ value : inout [Character]) -> StringReferenceReferenceClass{
	var ref : StringReference

	ref = StringReference()
	ref.stringx = value

	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateStringReferenceLengthValue(_ length : Double, _ value : Character) -> StringReferenceReferenceClass{
	var length = length;
	var value = value;
	var ref : StringReference
	var i : Double

	ref = StringReference()
	ref.stringx = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < length){
		ref.stringx[Int(i)] = value
		i = i + 1.0
	}

	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeStringReference(_ stringReference : inout StringReference) -> Void{
	delete(stringReference.stringx)
	delete(stringReference)
}


func CreateStringArrayReference(_ strings : inout [StringReference]) -> StringArrayReferenceReferenceClass{
	var ref : StringArrayReference

	ref = StringArrayReference()
	ref.stringArray = strings

	var returnReference = StringArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func CreateStringArrayReferenceLengthValue(_ length : Double, _ value : inout [Character]) -> StringArrayReferenceReferenceClass{
	var length = length;
	var ref : StringArrayReference
	var i : Double

	ref = StringArrayReference()
	ref.stringArray = Array(repeating:StringReference(), count: Int(length))

	i = 0.0
	while(i < length){
		ref.stringArray[Int(i)] = CreateStringReference(&value).ref
		i = i + 1.0
	}

	var returnReference = StringArrayReferenceReferenceClass()
	returnReference.ref = ref
	return returnReference
}


func FreeStringArrayReference(_ stringArrayReference : inout StringArrayReference) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(stringArrayReference.stringArray.count)){
		delete(stringArrayReference.stringArray[Int(i)])
		i = i + 1.0
	}
	delete(stringArrayReference.stringArray)
	delete(stringArrayReference)
}


func CreateDate(_ year : Double, _ month : Double, _ day : Double) -> DateReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var date : Date

	date = Date()

	date.year = year
	date.month = month
	date.day = day

	var returnReference = DateReferenceClass()
	returnReference.ref = date
	return returnReference
}


func IsLeapYearWithCheck(_ year : Double, _ isLeapYearReference : inout BooleanReference, _ message : inout StringReference) -> Bool{
	var year = year;
	var itIsLeapYear : Bool
	var success : Bool

	if(year >= 1752.0){
		success = true
		itIsLeapYear = IsLeapYear(year)
	}else{
		success = false
		itIsLeapYear = false
		message.stringx = characterArray("Gregorian calendar was not in general use.").ca
	}

	isLeapYearReference.booleanValue = itIsLeapYear
	return success
}


func IsLeapYear(_ year : Double) -> Bool{
	var year = year;
	var itIsLeapYear : Bool

	if(DivisibleBy(year, 4.0)){
		if(DivisibleBy(year, 100.0)){
			if(DivisibleBy(year, 400.0)){
				itIsLeapYear = true
			}else{
				itIsLeapYear = false
			}
		}else{
			itIsLeapYear = true
		}
	}else{
		itIsLeapYear = false
	}

	return itIsLeapYear
}


func DayToDateWithCheck(_ dayNr : Double, _ dateReference : inout DateReference, _ message : inout StringReference) -> Bool{
	var dayNr = dayNr;
	var date : Date
	var remainder : NumberReference
	var success : Bool

	if(dayNr >= -79623.0){
		date = Date()
		remainder = NumberReference()
		remainder.numberValue = dayNr + 79623.0
		/* Days since 1752-01-01. Day 0: Thursday, 1970-01-01*/
		/* Find year.*/
		date.year = GetYearFromDayNr(remainder.numberValue, &remainder)

		/* Find month.*/
		date.month = GetMonthFromDayNr(remainder.numberValue, date.year, &remainder)

		/* Find day.*/
		date.day = 1.0 + remainder.numberValue

		dateReference.date = date
		success = true
	}else{
		success = false
		message.stringx = characterArray("Gregorian calendar was not in general use before 1752.").ca
	}

	return success
}


func DayToDate(_ dayNr : Double) -> DateReferenceClass{
	var dayNr = dayNr;
	var date : Date
	var success : Bool
	var dateRef : DateReference
	var message : StringReference

	dateRef = DateReference()
	message = StringReference()

	success = DayToDateWithCheck(dayNr, &dateRef, &message)
	if(success){
		date = dateRef.date
		delete(dateRef)
		FreeStringReference(&message)
	}else{
		date = CreateDate(1970.0, 1.0, 1.0).ref
	}

	var returnReference = DateReferenceClass()
	returnReference.ref = date
	return returnReference
}


func GetMonthFromDayNrWithCheck(_ dayNr : Double, _ year : Double, _ monthReference : inout NumberReference, _ remainderReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var dayNr = dayNr;
	var year = year;
	var month : Double
	var success : Bool

	if(dayNr >= -79623.0){
		month = GetMonthFromDayNr(dayNr, year, &remainderReference)
		monthReference.numberValue = month
		success = true
	}else{
		success = false
		message.stringx = characterArray("Gregorian calendar not in general use before 1752.").ca
	}

	return success
}


func GetMonthFromDayNr(_ dayNr : Double, _ year : Double, _ remainderReference : inout NumberReference) -> Double{
	var dayNr = dayNr;
	var year = year;
	var daysInMonth : [Double]
	var done : Bool
	var month : Double

	daysInMonth = GetDaysInMonth(year)
	done = false
	month = 1.0

	while(!done){
		if(dayNr >= daysInMonth[Int(month)]){
			dayNr = dayNr - daysInMonth[Int(month)]
			month = month + 1.0
		}else{
			done = true
		}
	}
	remainderReference.numberValue = dayNr

	return month
}


func GetYearFromDayNrWithCheck(_ dayNr : Double, _ yearReference : inout NumberReference, _ remainder : inout NumberReference, _ message : inout StringReference) -> Bool{
	var dayNr = dayNr;
	var success : Bool
	var year : Double

	if(dayNr >= 0.0){
		success = true
		year = GetYearFromDayNr(dayNr, &remainder)
		yearReference.numberValue = year
	}else{
		success = false
		message.stringx = characterArray("Day number must be 0 or higher. 0 is 1752-01-01.").ca
	}

	return success
}


func GetYearFromDayNr(_ dayNr : Double, _ remainder : inout NumberReference) -> Double{
	var dayNr = dayNr;
	var nrOfDays : Double
	var done : Bool
	var year : Double

	done = false
	year = 1752.0

	while(!done){
		if(IsLeapYear(year)){
			nrOfDays = 366.0
		}else{
			nrOfDays = 365.0
		}

		if(dayNr >= nrOfDays){
			/* First day is 0.*/
			dayNr = dayNr - nrOfDays
			year = year + 1.0
		}else{
			done = true
		}
	}
	remainder.numberValue = dayNr

	return year
}


func DaysBetweenDates(_ A : inout Date, _ B : inout Date) -> Double{
	var daysA, daysB, daysBetween : Double

	daysA = DateToDays(&A)
	daysB = DateToDays(&B)

	daysBetween = daysB - daysA

	return daysBetween
}


func GetDaysInMonthWithCheck(_ year : Double, _ daysInMonthReference : inout NumberArrayReference, _ message : inout StringReference) -> Bool{
	var year = year;
	var daysInMonth : [Double]
	var success : Bool
	var date : Date

	date = CreateDate(year, 1.0, 1.0).ref

	success = IsValidDate(&date, &message)
	if(success){
		daysInMonth = GetDaysInMonth(year)

		daysInMonthReference.numberArray = daysInMonth
	}

	return success
}


func GetDaysInMonth(_ year : Double) -> [Double]{
	var year = year;
	var daysInMonth : [Double]

	daysInMonth = Array(repeating:Double(), count: Int(1.0 + 12.0))

	daysInMonth[Int(0)] = 0.0
	daysInMonth[Int(1)] = 31.0

	if(IsLeapYear(year)){
		daysInMonth[Int(2)] = 29.0
	}else{
		daysInMonth[Int(2)] = 28.0
	}
	daysInMonth[Int(3)] = 31.0
	daysInMonth[Int(4)] = 30.0
	daysInMonth[Int(5)] = 31.0
	daysInMonth[Int(6)] = 30.0
	daysInMonth[Int(7)] = 31.0
	daysInMonth[Int(8)] = 31.0
	daysInMonth[Int(9)] = 30.0
	daysInMonth[Int(10)] = 31.0
	daysInMonth[Int(11)] = 30.0
	daysInMonth[Int(12)] = 31.0

	return daysInMonth
}


func DateToDaysWithCheck(_ date : inout Date, _ dayNumberReferenceReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var days : Double
	var success : Bool

	success = IsValidDate(&date, &message)
	if(success){
		days = DateToDays(&date)
		dayNumberReferenceReference.numberValue = days
	}

	return success
}


func DateToDays(_ date : inout Date) -> Double{
	var days : Double

	/* Day 1752-01-01*/
	days = -79623.0

	days = days + DaysInYears(date.year)
	days = days + DaysInMonths(date.month, date.year)
	days = days + date.day - 1.0

	return days
}


func DateToWeekdayNumberWithCheck(_ date : inout Date, _ weekDayNumberReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var weekDay : Double
	var success : Bool

	success = IsValidDate(&date, &message)
	if(success){
		weekDay = DateToWeekdayNumber(&date)
		weekDayNumberReference.numberValue = weekDay
	}

	return success
}


func DateToWeekdayNumber(_ date : inout Date) -> Double{
	var days, weekDay : Double

	days = DateToDays(&date)

	days = days + 79623.0
	days = days + 5.0

	weekDay = days.truncatingRemainder(dividingBy:7.0) + 1.0

	return weekDay
}


func DateToWeeknumber(_ date : inout Date, _ yearRef : inout NumberReference) -> Double{
	var weekNumber, weekday, days, daysWeek1Start, weekdayNewYears : Double
	var week1Start, newyears : Date

	week1Start = CopyDate(&date).ref

	week1Start.day = 1.0
	week1Start.month = 1.0
	weekday = DateToWeekdayNumber(&week1Start)

	/* Set week1Start to the start of the Week 1.*/
	/* If monday, week 1 begins on Jan. 1st*/
	if(weekday == 1.0){
		week1Start.day = 1.0
	}
	/* If tuesday, week 1 begins on Dec. 31st*/
	if(weekday == 2.0){
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 31.0
	}
	/* If wednesday, week 1 begins on Dec. 30th*/
	if(weekday == 3.0){
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 30.0
	}
	/* If thursday, week 1 begins on Dec. 29th*/
	if(weekday == 4.0){
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 29.0
	}
	/* If friday, week 1 begins on Jan. 4th*/
	if(weekday == 5.0){
		week1Start.day = 4.0
	}
	/* If saturday, week 1 begins on Jan. 3rd*/
	if(weekday == 6.0){
		week1Start.day = 3.0
	}
	/* If sunday, week 1 begins on Jan. 2nd*/
	if(weekday == 7.0){
		week1Start.day = 2.0
	}

	days = DateToDays(&date)
	daysWeek1Start = DateToDays(&week1Start)

	if(days >= daysWeek1Start){
		weekNumber = 1.0 + floor((days - daysWeek1Start)/7.0)

		if(weekNumber >= 1.0 && weekNumber <= 52.0){
			/* Week is between 1 and 52 in the current year.*/
			yearRef.numberValue = date.year
		}else{
			/* Is week nr 53 or 1 next year?*/
			newyears = CopyDate(&date).ref
			newyears.month = 12.0
			newyears.day = 31.0
			weekdayNewYears = DateToWeekdayNumber(&newyears)
			if(weekdayNewYears == 1.0 || weekdayNewYears == 2.0 || weekdayNewYears == 3.0){
				/* Week 1 next year.*/
				weekNumber = 1.0
				yearRef.numberValue = date.year + 1.0
			}else{
				/* Week 53*/
				yearRef.numberValue = date.year
			}
			delete(newyears)
		}
	}else{
		/* Week is in previous year. Either 52nd or 53rd.*/
		newyears = CopyDate(&date).ref
		newyears.month = 12.0
		newyears.day = 31.0
		newyears.year = date.year - 1.0
		weekNumber = DateToWeeknumber(&newyears, &yearRef)
		delete(newyears)
	}

	delete(week1Start)

	return weekNumber
}


func DaysInMonthsWithCheck(_ month : Double, _ year : Double, _ daysInMonthsReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var month = month;
	var year = year;
	var days : Double
	var success : Bool
	var date : Date

	date = CreateDate(year, month, 1.0).ref

	success = IsValidDate(&date, &message)
	if(success){
		days = DaysInMonths(month, year)

		daysInMonthsReference.numberValue = days
	}

	return success
}


func DaysInMonths(_ month : Double, _ year : Double) -> Double{
	var month = month;
	var year = year;
	var daysInMonth : [Double]
	var days : Double
	var i : Double

	daysInMonth = GetDaysInMonth(year)

	days = 0.0
	i = 1.0
	while(i < month){
		days = days + daysInMonth[Int(i)]
		i = i + 1.0
	}

	return days
}


func DaysInYearsWithCheck(_ years : Double, _ daysReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var years = years;
	var days : Double
	var success : Bool
	var date : Date

	date = CreateDate(years, 1.0, 1.0).ref

	success = IsValidDate(&date, &message)
	if(success){
		days = DaysInYears(years)
		daysReference.numberValue = days
	}

	return success
}


func DaysInYears(_ years : Double) -> Double{
	var years = years;
	var days : Double
	var i : Double
	var nrOfDays : Double

	days = 0.0
	i = 1752.0
	while(i < years){
		if(IsLeapYear(i)){
			nrOfDays = 366.0
		}else{
			nrOfDays = 365.0
		}
		days = days + nrOfDays
		i = i + 1.0
	}

	return days
}


func IsValidDate(_ date : inout Date, _ message : inout StringReference) -> Bool{
	var valid : Bool
	var daysInMonth : [Double]
	var daysInThisMonth : Double

	if(date.year >= 1752.0){
		if(date.month >= 1.0 && date.month <= 12.0){
			daysInMonth = GetDaysInMonth(date.year)
			daysInThisMonth = daysInMonth[Int(date.month)]
			if(date.day >= 1.0 && date.day <= daysInThisMonth){
				valid = true
			}else{
				valid = false
				message.stringx = characterArray("The month does not have the given day number.").ca
			}
		}else{
			valid = false
			message.stringx = characterArray("Month must be between 1 and 12, inclusive.").ca
		}
	}else{
		valid = false
		message.stringx = characterArray("Gregorian calendar was not in general use before 1752.").ca
	}

	return valid
}


func AddDaysToDate(_ date : inout Date, _ days : Double, _ message : inout StringReference) -> Bool{
	var days = days;
	var n : Double
	var success : Bool
	var dateReference : DateReference
	var daysRef : NumberReference

	daysRef = NumberReference()
	success = DateToDaysWithCheck(&date, &daysRef, &message)

	if(success){
		n = daysRef.numberValue
		n = n + days

		dateReference = DateReference()
		success = DayToDateWithCheck(n, &dateReference, &message)
		if(success){
			AssignDate(&date, &dateReference.date)
		}
	}

	return success
}


func AssignDate(_ a : inout Date, _ b : inout Date) -> Void{
	a.year = b.year
	a.month = b.month
	a.day = b.day
}


func AddMonthsToDate(_ date : inout Date, _ months : Double) -> Void{
	var months = months;
	var i : Double

	if(months > 0.0){
		i = 0.0
		while(i < months){
			date.month = date.month + 1.0

			if(date.month == 13.0){
				date.month = 1.0
				date.year = date.year + 1.0
			}
			i = i + 1.0
		}
	}
	if(months < 0.0){
		i = 0.0
		while(i < -months){
			date.month = date.month - 1.0

			if(date.month == 0.0){
				date.month = 12.0
				date.year = date.year - 1.0
			}
			i = i + 1.0
		}
	}
}


func DateToStringISO8601WithCheck(_ date : inout Date, _ datestr : inout StringReference, _ message : inout StringReference) -> Bool{
	var success : Bool

	success = IsValidDate(&date, &message)

	if(success){
		if(date.year <= 9999.0){
			datestr.stringx = DateToStringISO8601(&date)
		}else{
			message.stringx = characterArray("This library works from 1752 to 9999.").ca
		}
	}

	return success
}


func DateToStringISO8601(_ date : inout Date) -> [Character]{
	var str : [Character]

	str = Array(repeating:Character(" "), count: Int(10))

	str[Int(0)] = cDecimalDigitToCharacter(floor(date.year/1000.0))
	str[Int(1)] = cDecimalDigitToCharacter(floor((date.year.truncatingRemainder(dividingBy:1000.0))/100.0))
	str[Int(2)] = cDecimalDigitToCharacter(floor((date.year.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(3)] = cDecimalDigitToCharacter(floor(date.year.truncatingRemainder(dividingBy:10.0)))

	str[Int(4)] = "-"

	str[Int(5)] = cDecimalDigitToCharacter(floor((date.month.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(6)] = cDecimalDigitToCharacter(floor(date.month.truncatingRemainder(dividingBy:10.0)))

	str[Int(7)] = "-"

	str[Int(8)] = cDecimalDigitToCharacter(floor((date.day.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(9)] = cDecimalDigitToCharacter(floor(date.day.truncatingRemainder(dividingBy:10.0)))

	return str
}


func DateFromStringISO8601(_ str : inout [Character]) -> DateReferenceClass{
	var date : Date
	var n : Double

	date = Date()

	n = cCharacterToDecimalDigit(str[Int(0)])*1000.0
	n = n + cCharacterToDecimalDigit(str[Int(1)])*100.0
	n = n + cCharacterToDecimalDigit(str[Int(2)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(3)])*1.0

	date.year = n

	n = cCharacterToDecimalDigit(str[Int(5)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(6)])*1.0

	date.month = n

	n = cCharacterToDecimalDigit(str[Int(8)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(9)])*1.0

	date.day = n

	var returnReference = DateReferenceClass()
	returnReference.ref = date
	return returnReference
}


func DateFromStringISO8601WithCheck(_ str : inout [Character], _ dateRef : inout DateReference, _ message : inout StringReference) -> Bool{
	var valid : Bool

	valid = IsValidDateISO8601(&str, &message)

	if(valid){
		dateRef.date = DateFromStringISO8601(&str).ref
	}

	return valid
}


func IsValidDateISO8601(_ str : inout [Character], _ message : inout StringReference) -> Bool{
	var valid : Bool

	if(Double(str.count) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0){

		if(cIsNumber(str[Int(0)]) && cIsNumber(str[Int(1)]) && cIsNumber(str[Int(2)]) && cIsNumber(str[Int(3)]) && cIsNumber(str[Int(5)]) && cIsNumber(str[Int(6)]) && cIsNumber(str[Int(8)]) && cIsNumber(str[Int(9)])){
			if(str[Int(4)] == "-" && str[Int(7)] == "-"){
				valid = true
			}else{
				valid = false
				message.stringx = characterArray("ISO8601 date must use \'-\' in positions 5 and 8.").ca
			}
		}else{
			valid = false
			message.stringx = characterArray("ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.").ca
		}
	}else{
		valid = false
		message.stringx = characterArray("ISO8601 date must be exactly 10 characters long.").ca
	}

	return valid
}


func DateEquals(_ a : inout Date, _ b : inout Date) -> Bool{
	return a.year == b.year && a.month == b.month && a.day == b.day
}


func CopyDate(_ a : inout Date) -> DateReferenceClass{
	var b : Date

	b = CreateDate(a.year, a.month, a.day).ref

	var returnReference = DateReferenceClass()
	returnReference.ref = b
	return returnReference
}


func GetSecondsFromDate(_ date : inout Date) -> Double{
	var seconds, days, secondsInMinute, secondsInHour, secondsInDay : Double
	var dayNumberReferenceReference : NumberReference
	var message : StringReference
	var success : Bool

	seconds = 0.0
	dayNumberReferenceReference = NumberReference()
	message = StringReference()

	success = DateToDaysWithCheck(&date, &dayNumberReferenceReference, &message)
	if(success){
		days = dayNumberReferenceReference.numberValue

		secondsInMinute = 60.0
		secondsInHour = 60.0*secondsInMinute
		secondsInDay = 24.0*secondsInHour

		seconds = seconds + secondsInDay*days
	}

	delete(dayNumberReferenceReference)
	delete(message)

	return seconds
}


func DateIsInInterval(_ interval : inout Interval, _ date : inout Date) -> Bool{
	var from, to, day : Double

	from = DateToDays(&interval.first)
	to = DateToDays(&interval.last)
	day = DateToDays(&date)

	return day >= from && day <= to
}


func DateLessThan(_ a : inout Date, _ b : inout Date) -> Bool{
	var aDays, bDays : Double

	aDays = DateToDays(&a)
	bDays = DateToDays(&b)

	return aDays < bDays
}


func CreateDateTimeTimezone(_ year : Double, _ month : Double, _ day : Double, _ hours : Double, _ minutes : Double, _ seconds : Double, _ timezoneOffsetSeconds : Double) -> DateTimeTimezoneReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var hours = hours;
	var minutes = minutes;
	var seconds = seconds;
	var timezoneOffsetSeconds = timezoneOffsetSeconds;
	var dateTimeTimezone : DateTimeTimezone

	dateTimeTimezone = DateTimeTimezone()

	dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds).ref
	dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

	var returnReference = DateTimeTimezoneReferenceClass()
	returnReference.ref = dateTimeTimezone
	return returnReference
}


func CreateDateTimeTimezoneInHoursAndMinutes(_ year : Double, _ month : Double, _ day : Double, _ hours : Double, _ minutes : Double, _ seconds : Double, _ timezoneOffsetHours : Double, _ timezoneOffsetMinutes : Double) -> DateTimeTimezoneReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var hours = hours;
	var minutes = minutes;
	var seconds = seconds;
	var timezoneOffsetHours = timezoneOffsetHours;
	var timezoneOffsetMinutes = timezoneOffsetMinutes;
	var dateTimeTimezone : DateTimeTimezone

	dateTimeTimezone = DateTimeTimezone()

	dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds).ref
	dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes)

	var returnReference = DateTimeTimezoneReferenceClass()
	returnReference.ref = dateTimeTimezone
	return returnReference
}


func GetDateFromDateTimeTimeZone(_ dateTimeTimezone : inout DateTimeTimezone, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var dateTime : DateTime

	dateTime = dateTimeTimezone.dateTime

	return AddSecondsToDateTimeWithCheck(&dateTime, -dateTimeTimezone.timezoneOffsetSeconds, &dateTimeReference, &message)
}


func CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(_ dateTime : inout DateTime, _ timezoneOffsetSeconds : Double, _ dateTimeTimezoneReference : inout DateTimeTimezoneReference, _ message : inout StringReference) -> Bool{
	var timezoneOffsetSeconds = timezoneOffsetSeconds;
	var success : Bool
	var adjustedDateTimeReference : DateTimeReference
	var dateTimeTimezone : DateTimeTimezone

	adjustedDateTimeReference = DateTimeReference()
	dateTimeTimezone = DateTimeTimezone()

	success = AddSecondsToDateTime(&dateTime, timezoneOffsetSeconds, &adjustedDateTimeReference, &message)

	if(success){
		dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

		dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone
	}

	return success
}


func CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(_ dateTime : inout DateTime, _ timezoneOffsetHours : Double, _ timezoneOffsetMinutes : Double, _ dateTimeTimezoneReference : inout DateTimeTimezoneReference, _ message : inout StringReference) -> Bool{
	var timezoneOffsetHours = timezoneOffsetHours;
	var timezoneOffsetMinutes = timezoneOffsetMinutes;
	return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(&dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), &dateTimeTimezoneReference, &message)
}


func GetDateTimeTimezoneFromSeconds(_ dateTimeTzRef : inout DateTimeTimezoneReference, _ seconds : Double, _ offset : Double, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var offset = offset;
	var success : Bool
	var dateTimeRef : DateTimeReference

	dateTimeRef = DateTimeReference()
	success = GetDateTimeFromSeconds(seconds, &dateTimeRef, &message)

	if(success){
		success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(&dateTimeRef.dateTime, offset, &dateTimeTzRef, &message)
	}

	return success
}


func CreateDateTime(_ year : Double, _ month : Double, _ day : Double, _ hours : Double, _ minutes : Double, _ seconds : Double) -> DateTimeReferenceClass{
	var year = year;
	var month = month;
	var day = day;
	var hours = hours;
	var minutes = minutes;
	var seconds = seconds;
	var dateTime : DateTime

	dateTime = DateTime()

	dateTime.date = CreateDate(year, month, day).ref
	dateTime.hours = hours
	dateTime.minutes = minutes
	dateTime.seconds = seconds

	var returnReference = DateTimeReferenceClass()
	returnReference.ref = dateTime
	return returnReference
}


func GetDateTimeFromSeconds(_ seconds : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var dateTime : DateTime
	var secondsInMinute, secondsInHour, secondsInDay, days, remainder : Double
	var date : Date
	var dateReference : DateReference
	var success : Bool

	secondsInMinute = 60.0
	secondsInHour = 60.0*secondsInMinute
	secondsInDay = 24.0*secondsInHour
	days = floor(seconds/secondsInDay)
	remainder = seconds - days*secondsInDay
	dateReference = DateReference()

	success = DayToDateWithCheck(days, &dateReference, &message)
	if(success){
		date = dateReference.date

		dateTime = DateTime()
		dateTime.date = date
		dateTime.hours = floor(remainder/secondsInHour)
		remainder = remainder - dateTime.hours*secondsInHour
		dateTime.minutes = floor(remainder/secondsInMinute)
		remainder = remainder - dateTime.minutes*secondsInMinute
		dateTime.seconds = remainder

		dateTimeReference.dateTime = dateTime
	}

	return success
}


func GetSecondsFromDateTime(_ dateTime : inout DateTime) -> Double{
	var seconds, secondsInMinute, secondsInHour : Double

	secondsInMinute = 60.0
	secondsInHour = 60.0*secondsInMinute

	seconds = GetSecondsFromDate(&dateTime.date)
	seconds = seconds + secondsInHour*dateTime.hours
	seconds = seconds + secondsInMinute*dateTime.minutes
	seconds = seconds + dateTime.seconds

	return seconds
}


func GetSecondsFromMinutes(_ minutes : Double) -> Double{
	var minutes = minutes;
	return minutes*60.0
}


func GetSecondsFromHours(_ hours : Double) -> Double{
	var hours = hours;
	return GetSecondsFromMinutes(hours*60.0)
}


func GetSecondsFromDays(_ days : Double) -> Double{
	var days = days;
	return GetSecondsFromHours(days*24.0)
}


func GetSecondsFromWeeks(_ weeks : Double) -> Double{
	var weeks = weeks;
	return GetSecondsFromDays(weeks*7.0)
}


func GetMinutesFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return seconds/60.0
}


func GetHoursFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return GetMinutesFromSeconds(seconds)/60.0
}


func GetDaysFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return GetHoursFromSeconds(seconds)/24.0
}


func GetWeeksFromSeconds(_ seconds : Double) -> Double{
	var seconds = seconds;
	return GetDaysFromSeconds(seconds)/7.0
}


func GetDateFromDateTime(_ dateTime : inout DateTime) -> DateReferenceClass{
	var returnReference = DateReferenceClass()
	returnReference.ref = dateTime.date
	return returnReference
}


func AddSecondsToDateTimeWithCheck(_ dateTime : inout DateTime, _ seconds : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var secondsInDateTime : Double
	var success : Bool

	if(IsValidDateTime(&dateTime, &message)){
		secondsInDateTime = GetSecondsFromDateTime(&dateTime)
		secondsInDateTime = secondsInDateTime + seconds

		success = GetDateTimeFromSeconds(secondsInDateTime, &dateTimeReference, &message)
	}else{
		success = false
	}

	return success
}


func AddSecondsToDateTime(_ dateTime : inout DateTime, _ seconds : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var seconds = seconds;
	var secondsInDateTime : Double

	secondsInDateTime = GetSecondsFromDateTime(&dateTime)
	secondsInDateTime = secondsInDateTime + seconds

	return GetDateTimeFromSeconds(secondsInDateTime, &dateTimeReference, &message)
}


func AddMinutesToDateTime(_ dateTime : inout DateTime, _ minutes : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var minutes = minutes;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromMinutes(minutes), &dateTimeReference, &message)
}


func AddHoursToDateTime(_ dateTime : inout DateTime, _ hours : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var hours = hours;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromHours(hours), &dateTimeReference, &message)
}


func AddDaysToDateTime(_ dateTime : inout DateTime, _ days : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var days = days;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromDays(days), &dateTimeReference, &message)
}


func AddWeeksToDateTime(_ dateTime : inout DateTime, _ weeks : Double, _ dateTimeReference : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var weeks = weeks;
	return AddSecondsToDateTime(&dateTime, GetSecondsFromWeeks(weeks), &dateTimeReference, &message)
}


func DateTimeToStringISO8601WithCheck(_ datetime : inout DateTime, _ dateStr : inout StringReference, _ message : inout StringReference) -> Bool{
	var success : Bool

	success = DateToStringISO8601WithCheck(&datetime.date, &dateStr, &message)

	if(success){
		delete(dateStr.stringx)

		success = IsValidDateTime(&datetime, &message)
		if(success){
			dateStr.stringx = DateTimeToStringISO8601(&datetime)
		}
	}

	return success
}


func IsValidDateTime(_ datetime : inout DateTime, _ message : inout StringReference) -> Bool{
	var success : Bool

	success = IsValidDate(&datetime.date, &message)

	if(success){
		if(datetime.hours <= 23.0 && datetime.hours >= 0.0){
			if(datetime.minutes <= 59.0 && datetime.minutes >= 0.0){
				if(datetime.seconds <= 59.0 && datetime.seconds >= 0.0){
					success = true
				}else{
					success = false
					message.stringx = characterArray("Seconds must be between 0 and 59.").ca
				}
			}else{
				success = false
				message.stringx = characterArray("Minutes must be between 0 and 59.").ca
			}
		}else{
			success = false
			message.stringx = characterArray("Hours must be between 0 and 23.").ca
		}
	}

	return success
}


func DateTimeToStringISO8601(_ datetime : inout DateTime) -> [Character]{
	var datestr, str : [Character]
	var i : Double

	str = Array(repeating:Character(" "), count: Int(19))

	datestr = DateToStringISO8601(&datetime.date)
	i = 0.0
	while(i < Double(datestr.count)){
		str[Int(i)] = datestr[Int(i)]
		i = i + 1.0
	}

	str[Int(10)] = "T"
	str[Int(11)] = cDecimalDigitToCharacter(floor((datetime.hours.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(12)] = cDecimalDigitToCharacter(floor(datetime.hours.truncatingRemainder(dividingBy:10.0)))

	str[Int(13)] = ":"

	str[Int(14)] = cDecimalDigitToCharacter(floor((datetime.minutes.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(15)] = cDecimalDigitToCharacter(floor(datetime.minutes.truncatingRemainder(dividingBy:10.0)))

	str[Int(16)] = ":"

	str[Int(17)] = cDecimalDigitToCharacter(floor((datetime.seconds.truncatingRemainder(dividingBy:100.0))/10.0))
	str[Int(18)] = cDecimalDigitToCharacter(floor(datetime.seconds.truncatingRemainder(dividingBy:10.0)))

	return str
}


func DateTimeFromStringISO8601(_ str : inout [Character]) -> DateTimeReferenceClass{
	var dateTime : DateTime
	var n : Double

	dateTime = DateTime()

	dateTime.date = DateFromStringISO8601(&str).ref

	n = cCharacterToDecimalDigit(str[Int(11)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(12)])*1.0

	dateTime.hours = n

	n = cCharacterToDecimalDigit(str[Int(14)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(15)])*1.0

	dateTime.minutes = n

	n = cCharacterToDecimalDigit(str[Int(17)])*10.0
	n = n + cCharacterToDecimalDigit(str[Int(18)])*1.0

	dateTime.seconds = n

	var returnReference = DateTimeReferenceClass()
	returnReference.ref = dateTime
	return returnReference
}


func DateTimeFromStringISO8601WithCheck(_ str : inout [Character], _ dateTimeRef : inout DateTimeReference, _ message : inout StringReference) -> Bool{
	var valid : Bool

	valid = IsValidDateTimeISO8601(&str, &message)

	if(valid){
		dateTimeRef.dateTime = DateTimeFromStringISO8601(&str).ref
	}

	return valid
}


func IsValidDateTimeISO8601(_ str : inout [Character], _ message : inout StringReference) -> Bool{
	var valid : Bool

	if(Double(str.count) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0){

		if(cIsNumber(str[Int(0)]) && cIsNumber(str[Int(1)]) && cIsNumber(str[Int(2)]) && cIsNumber(str[Int(3)]) && cIsNumber(str[Int(5)]) && cIsNumber(str[Int(6)]) && cIsNumber(str[Int(8)]) && cIsNumber(str[Int(9)]) && cIsNumber(str[Int(11)]) && cIsNumber(str[Int(12)]) && cIsNumber(str[Int(14)]) && cIsNumber(str[Int(15)]) && cIsNumber(str[Int(17)]) && cIsNumber(str[Int(18)])){
			if(str[Int(4)] == "-" && str[Int(7)] == "-" && str[Int(10)] == "T" && str[Int(13)] == ":" && str[Int(16)] == ":"){
				valid = true
			}else{
				valid = false
				message.stringx = characterArray("ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.").ca
			}
		}else{
			valid = false
			message.stringx = characterArray("ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.").ca
		}
	}else{
		valid = false
		message.stringx = characterArray("ISO8601 date must be exactly 19 characters long.").ca
	}

	return valid
}


func DateTimeEquals(_ a : inout DateTime, _ b : inout DateTime) -> Bool{
	return DateEquals(&a.date, &b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds
}


func FreeDateTime(_ datetime : inout DateTime) -> Void{
	delete(datetime.date)
	delete(datetime)
}


func CreateFixedPoint30d(_ digitsBeforeDecimalPoint : Double, _ digitsAfterDecimalPoint : Double) -> FixedPoint30dReferenceClass{
	var digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
	var digitsAfterDecimalPoint = digitsAfterDecimalPoint;
	var fp : FixedPoint30d

	fp = FixedPoint30d()
	fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
	fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
	fp.part1 = 0.0
	fp.part2 = 0.0

	var returnReference = FixedPoint30dReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func CreateFixedPoint15d(_ digitsBeforeDecimalPoint : Double, _ digitsAfterDecimalPoint : Double) -> FixedPoint15dReferenceClass{
	var digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
	var digitsAfterDecimalPoint = digitsAfterDecimalPoint;
	var fp : FixedPoint15d

	fp = FixedPoint15d()
	fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
	fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
	fp.number = 0.0

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func ToNumber15d(_ n : inout FixedPoint15d) -> Double{
	return n.number
}


func Number15d(_ number : Double) -> FixedPoint15dReferenceClass{
	var number = number;
	var fp : FixedPoint15d

	fp = FixedPoint15d()
	fp.digitsBeforeDecimalPoint = 7.0
	fp.digitsAfterDecimalPoint = 7.0
	fp.number = number

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = fp
	return returnReference
}


func Assign15d(_ fp : inout FixedPoint15d, _ number : Double) -> Bool{
	var number = number;
	var success : Bool

	success = !WillOverflow15d(&fp, number)
	success = success && FixedPointIsValid15d(&fp)

	if(success){
		fp.number = number
		fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint)
	}

	return success
}


func Assign15dFloor(_ fp : inout FixedPoint15d, _ number : Double) -> Bool{
	var number = number;
	var success : Bool

	success = !WillOverflow15d(&fp, number)
	success = success && FixedPointIsValid15d(&fp)

	if(success){
		fp.number = number
		fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint)
	}

	return success
}


func FixedPointIsValid15d(_ fp : inout FixedPoint15d) -> Bool{
	var valid : Bool

	if(IsInteger(fp.digitsAfterDecimalPoint) && IsInteger(fp.digitsBeforeDecimalPoint)){
		if(fp.digitsBeforeDecimalPoint >= 0.0 && fp.digitsBeforeDecimalPoint <= 15.0){
			if(fp.digitsAfterDecimalPoint >= 0.0 && fp.digitsAfterDecimalPoint <= 15.0){
				if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15.0){
					if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0.0){
						valid = true
					}else{
						valid = false
					}
				}else{
					valid = false
				}
			}else{
				valid = false
			}
		}else{
			valid = false
		}
	}else{
		valid = false
	}

	return valid
}


func WillOverflow15d(_ fp : inout FixedPoint15d, _ number : Double) -> Bool{
	var number = number;
	var overflow : Bool

	if(abs(number) < pow(10.0, fp.digitsBeforeDecimalPoint)){
		overflow = false
	}else{
		overflow = true
	}

	return overflow
}


func FloorToDigits(_ value : Double, _ digits : Double) -> Double{
	var value = value;
	var digits = digits;
	return floor(value*pow(10.0, digits))/pow(10.0, digits)
}


func ToString15d(_ fp : inout FixedPoint15d) -> [Character]{
	var stringx : [Character]
	var digits : Double
	var digitPosition : Double
	var i, d, decimalx : Double
	var characterReference : CharacterReference

	stringx = Array(repeating:Character(" "), count: Int(1.0 + fp.digitsBeforeDecimalPoint + 1.0 + fp.digitsAfterDecimalPoint))

	decimalx = fp.number*pow(10.0, fp.digitsAfterDecimalPoint)

	if(decimalx < 0.0){
		decimalx = -decimalx
		stringx[Int(0)] = "-"
	}else{
		stringx[Int(0)] = "+"
	}

	decimalx = Roundx(decimalx)

	characterReference = CharacterReference()

	digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint
	digitPosition = 1.0

	i = 0.0
	while(i < digits){
		if(i == fp.digitsBeforeDecimalPoint){
			stringx[Int(digitPosition)] = "."

			digitPosition = digitPosition + 1.0
		}

		d = floor(decimalx/pow(10.0, digits - i - 1.0))
		d = d.truncatingRemainder(dividingBy:10.0)

		GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, &characterReference)
		stringx[Int(digitPosition)] = characterReference.characterValue

		digitPosition = digitPosition + 1.0
		i = i + 1.0
	}

	delete(characterReference)

	return stringx
}


func Add15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ c : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, b.number + c.number)
}


func Subtract15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ c : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, b.number - c.number)
}


func Multiply15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ c : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, b.number*c.number)
}


func DivideFloored15d(_ q : inout FixedPoint15d, _ r : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool
	var x, xDivisor, xDividend : Double
	var t : FixedPoint15d

	t = Copy15d(&r).ref

	if(b.number != 0.0){
		xDivisor = Roundx(a.number*pow(10.0, q.digitsAfterDecimalPoint)*pow(10.0, q.digitsAfterDecimalPoint))
		xDividend = Roundx(b.number*pow(10.0, q.digitsAfterDecimalPoint))
		x = floor(xDivisor/xDividend)
		x = x/pow(10.0, q.digitsAfterDecimalPoint)
		success = Assign15d(&q, x)
		Multiply15d(&t, &q, &b)
		Subtract15d(&r, &a, &t)
	}else{
		success = false
	}

	delete(t)

	return success
}


func Copy15d(_ r : inout FixedPoint15d) -> FixedPoint15dReferenceClass{
	var t : FixedPoint15d

	t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint).ref
	t.number = r.number

	var returnReference = FixedPoint15dReferenceClass()
	returnReference.ref = t
	return returnReference
}


func Negate15d(_ a : inout FixedPoint15d) -> Void{
	a.number = -a.number
}


func Positive15d(_ a : inout FixedPoint15d) -> Void{
	a.number = +a.number
}


func Factorial15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= 0.0){
		success = Assign15d(&x, Factorial(x.number))
	}else{
		success = false
	}

	return success
}


func Round15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Roundx(x.number))
}


func BankersRound15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, BankersRound(x.number))
}


func Ceil15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Ceil(x.number))
}


func Floor15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, floor(x.number))
}


func Truncate15d(_ x : inout FixedPoint15d) -> Void{
	x.number = Truncate(x.number)
}


func Absolute15d(_ x : inout FixedPoint15d) -> Void{
	x.number = abs(x.number)
}


func Logarithm15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number > 0.0){
		success = Assign15d(&x, Logarithm(x.number))
	}else{
		success = false
	}

	return success
}


func NaturalLogarithm15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number > 0.0){
		success = Assign15d(&x, NaturalLogarithm(x.number))
	}else{
		success = false
	}

	return success
}


func Sin15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Sinx(x.number))
}


func Cos15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Cosx(x.number))
}


func Tan15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Tanx(x.number))
}


func Asin15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= -1.0 && x.number <= 1.0){
		success = Assign15d(&x, Asinx(x.number))
	}else{
		success = false
	}

	return success
}


func Acos15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= -1.0 && x.number <= 1.0){
		success = Assign15d(&x, Acosx(x.number))
	}else{
		success = false
	}

	return success
}


func Atan15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Atanx(x.number))
}


func Atan2_15d(_ a : inout FixedPoint15d, _ y : inout FixedPoint15d, _ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&a, Atan2(y.number, x.number))
}


func Squareroot15d(_ x : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(x.number >= 0.0){
		success = Assign15d(&x, sqrt(x.number))
	}else{
		success = false
	}

	return success
}


func Exp15d(_ x : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Expx(x.number))
}


func DivisibleBy15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	return ((a.number.truncatingRemainder(dividingBy:b.number)) == 0.0)
}


func Combinations15d(_ x : inout FixedPoint15d, _ n : inout FixedPoint15d, _ k : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(n.number) && IsInteger(k.number)){
		if(n.number >= 1.0 && k.number >= 0.0 && n.number >= k.number){
			success = Assign15d(&x, Combinations(n.number, k.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func Permutations15d(_ x : inout FixedPoint15d, _ n : inout FixedPoint15d, _ k : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(n.number) && IsInteger(k.number)){
		if(n.number >= 1.0 && k.number >= 0.0 && n.number >= k.number){
			success = Assign15d(&x, Permutations(n.number, k.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func Equals15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var p, an, bn : Double
	var equals : Bool

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	p = max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint)

	equals = EpsilonCompare(an, bn, pow(10.0, -p))

	return equals
}


func GreaterThan15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	return an > bn
}


func LessThan15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	return an < bn
}


func GreaterThanOrEqual15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double
	var equal : Bool

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	equal = Equals15d(&a, &b)

	return an > bn || equal
}


func LessThanOrEqual15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var an, bn : Double
	var equal : Bool

	an = ToNumber15d(&a)
	bn = ToNumber15d(&b)

	equal = Equals15d(&a, &b)

	return an < bn || equal
}


func EpsilonCompare15d(_ a : inout FixedPoint15d, _ b : inout FixedPoint15d, _ epsilon : inout FixedPoint15d) -> Bool{
	return EpsilonCompare(a.number, b.number, epsilon.number)
}


func GreatestCommonDivisor15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(a.number) && IsInteger(b.number)){
		if(a.number >= 0.0 && b.number >= 0.0){
			success = Assign15d(&x, GreatestCommonDivisor(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func GCDWithSubtraction15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(a.number) && IsInteger(b.number)){
		if(a.number >= 0.0 && b.number >= 0.0){
			success = Assign15d(&x, GCDWithSubtraction(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func IsInteger15d(_ a : inout FixedPoint15d) -> Bool{
	return IsInteger(a.number)
}


func LeastCommonMultiple15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(IsInteger(a.number) && IsInteger(b.number)){
		if(a.number != 0.0 && b.number != 0.0){
			success = Assign15d(&x, LeastCommonMultiple(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func Sign15d(_ a : inout FixedPoint15d) -> Double{
	return Sign(a.number)
}


func Max15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Max(a.number, b.number))
}


func Min15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	return Assign15d(&x, Min(a.number, b.number))
}


func Power15d(_ x : inout FixedPoint15d, _ a : inout FixedPoint15d, _ b : inout FixedPoint15d) -> Bool{
	var success : Bool

	if(a.number != 0.0 || b.number != 0.0){
		if(!(a.number < 0.0 && !IsInteger(b.number))){
			success = Assign15d(&x, Power(a.number, b.number))
		}else{
			success = false
		}
	}else{
		success = false
	}

	return success
}


func FormatToString15d(_ fp : inout FixedPoint15d, _ digitsAfter : Double) -> [Character]{
	var digitsAfter = digitsAfter;
	var result : [Character]

	result = FormatToStringWithSymbols15d(&fp, digitsAfter, &characterArray("").ca, &characterArray(".").ca)

	return result
}


func FormatToStringWithSymbols15d(_ fp : inout FixedPoint15d, _ digitsAfter : Double, _ thousandsSeparator : inout [Character], _ decimalPoint : inout [Character]) -> [Character]{
	var digitsAfter = digitsAfter;
	var stringx : [Character]
	var i, j, p, d, t, sign, extra, decimalx, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars : Double
	var characterReference : CharacterReference

	characterReference = CharacterReference()

	decimalx = Roundx(fp.number*pow(10.0, digitsAfter))

	sign = 0.0
	if(decimalx < 0.0){
		sign = 1.0
		decimalx = -decimalx
	}

	if(decimalx != 0.0){
		digits = floor(log10(decimalx) + 1.0)
	}else{
		digits = 1.0
	}
	digitsBefore = digits - digitsAfter

	if(digitsBefore <= 0.0){
		digitsBefore = 0.0
		thousandsTimes = 0.0
		digits = digitsAfter + 1.0
	}else{
		thousandsTimes = floor((digitsBefore - 1.0)/3.0)
	}
	thousandsChars = thousandsTimes*Double(thousandsSeparator.count)

	if(digitsAfter == 0.0){
		decimalPointChars = 0.0
	}else{
		decimalPointChars = Double(decimalPoint.count)
	}

	stringx = Array(repeating:Character(" "), count: Int(sign + digits + thousandsChars + decimalPointChars))
	p = 0.0

	if(sign > 0.0){
		stringx[Int(p)] = "-"
		p = p + 1.0
	}

	i = 0.0
	while(i < digits){
		if(i == digitsBefore){
			if(i == 0.0){
				stringx[Int(p)] = "0"
				p = p + 1.0
				digits = digits - 1.0
			}

			j = 0.0
			while(j < Double(decimalPoint.count)){
				stringx[Int(p)] = decimalPoint[Int(j)]
				p = p + 1.0
				j = j + 1.0
			}
		}

		if(i < digitsBefore){
			if((digitsBefore - i).truncatingRemainder(dividingBy:3.0) == 0.0 && i != 0.0){
				j = 0.0
				while(j < Double(thousandsSeparator.count)){
					stringx[Int(p)] = thousandsSeparator[Int(j)]
					p = p + 1.0
					j = j + 1.0
				}
			}
		}

		d = floor(decimalx/pow(10.0, digits - i - 1.0))
		d = d.truncatingRemainder(dividingBy:10.0)

		GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, &characterReference)
		stringx[Int(p)] = characterReference.characterValue

		p = p + 1.0
		i = i + 1.0
	}

	/* System.out.println(new String(string));*/
	return stringx
}


func NumberToHumanReadable(_ n : Double, _ digitsAfter : Double, _ thousandsSeparator : inout [Character], _ decimalPoint : inout [Character]) -> [Character]{
	var n = n;
	var digitsAfter = digitsAfter;
	var str : [Character]
	var u : Character
	var d, p3 : Double

	if(abs(n) < 1.0){
		str = CreateStringDecimalFromNumber(n)
	}else{
		d = log10(n)

		p3 = min(floor(d/3.0), 8.0)

		if(p3 == 0.0){
			u = "B"
		}else if(p3 == 1.0){
			u = "K"
		}else if(p3 == 2.0){
			u = "M"
		}else if(p3 == 3.0){
			u = "G"
		}else if(p3 == 4.0){
			u = "T"
		}else if(p3 == 5.0){
			u = "P"
		}else if(p3 == 6.0){
			u = "E"
		}else if(p3 == 7.0){
			u = "Z"
		}else{
			u = "Y"
		}

		if(p3 > 1.0){
			n = n/pow(10.0, p3*3.0)
		}

		str = FormatToStringWithSymbols15d(&Number15d(n).ref, digitsAfter, &thousandsSeparator, &decimalPoint)

		if(p3 > 1.0){
			str = strAppendCharacter(&str, u)
		}
	}

	return str
}


func NumberToHumanReadableBinaryPrefix(_ n : Double, _ digitsAfter : Double, _ thousandsSeparator : inout [Character], _ decimalPoint : inout [Character]) -> [Character]{
	var n = n;
	var digitsAfter = digitsAfter;
	var str : [Character]
	var u : [Character]
	var d, p3 : Double

	if(abs(n) < 1.0){
		str = CreateStringDecimalFromNumber(n)
	}else{
		d = floor(log(n)/log(2.0)) + 1.0

		p3 = min(floor(d/10.0), 8.0)

		if(p3 == 0.0){
			u = characterArray("B").ca
		}else if(p3 == 1.0){
			u = characterArray("Ki").ca
		}else if(p3 == 2.0){
			u = characterArray("Mi").ca
		}else if(p3 == 3.0){
			u = characterArray("Gi").ca
		}else if(p3 == 4.0){
			u = characterArray("Ti").ca
		}else if(p3 == 5.0){
			u = characterArray("Pi").ca
		}else if(p3 == 6.0){
			u = characterArray("Ei").ca
		}else if(p3 == 7.0){
			u = characterArray("Zi").ca
		}else{
			u = characterArray("Yi").ca
		}

		if(p3 > 1.0){
			n = n/pow(2.0, p3*10.0)
		}

		str = FormatToStringWithSymbols15d(&Number15d(n).ref, digitsAfter, &thousandsSeparator, &decimalPoint)

		if(p3 > 1.0){
			str = strAppendString(&str, &u)
		}
	}

	return str
}


func AddNumber(_ list : inout [Double], _ a : Double) -> [Double]{
	var a = a;
	var newlist : [Double]
	var i : Double

	newlist = Array(repeating:Double(), count: Int(Double(list.count) + 1.0))
	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddNumberRef(_ list : inout NumberArrayReference, _ i : Double) -> Void{
	var i = i;
	list.numberArray = AddNumber(&list.numberArray, i)
}


func RemoveNumber(_ list : inout [Double], _ n : Double) -> [Double]{
	var n = n;
	var newlist : [Double]
	var i : Double

	newlist = Array(repeating:Double(), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}
		
	return newlist
}


func GetNumberRef(_ list : inout NumberArrayReference, _ i : Double) -> Double{
	var i = i;
	return list.numberArray[Int(i)]
}


func RemoveNumberRef(_ list : inout NumberArrayReference, _ i : Double) -> Void{
	var i = i;
	list.numberArray = RemoveNumber(&list.numberArray, i)
}


func AddString(_ list : inout [StringReference], _ a : inout StringReference) -> [StringReference]{
	var newlist : [StringReference]
	var i : Double

	newlist = Array(repeating:StringReference(), count: Int(Double(list.count) + 1.0))

	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddStringRef(_ list : inout StringArrayReference, _ i : inout StringReference) -> Void{
	list.stringArray = AddString(&list.stringArray, &i)
}


func RemoveString(_ list : inout [StringReference], _ n : Double) -> [StringReference]{
	var n = n;
	var newlist : [StringReference]
	var i : Double

	newlist = Array(repeating:StringReference(), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}
		
	return newlist
}


func GetStringRef(_ list : inout StringArrayReference, _ i : Double) -> StringReferenceReferenceClass{
	var i = i;
	var returnReference = StringReferenceReferenceClass()
	returnReference.ref = list.stringArray[Int(i)]
	return returnReference
}


func RemoveStringRef(_ list : inout StringArrayReference, _ i : Double) -> Void{
	var i = i;
	list.stringArray = RemoveString(&list.stringArray, i)
}


func CreateDynamicArrayCharacters() -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters

	da = DynamicArrayCharacters()
	da.array = Array(repeating:Character(" "), count: Int(10))
	da.length = 0.0

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func CreateDynamicArrayCharactersWithInitialCapacity(_ capacity : Double) -> DynamicArrayCharactersReferenceClass{
	var capacity = capacity;
	var da : DynamicArrayCharacters

	da = DynamicArrayCharacters()
	da.array = Array(repeating:Character(" "), count: Int(capacity))
	da.length = 0.0

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayAddCharacter(_ da : inout DynamicArrayCharacters, _ value : Character) -> Void{
	var value = value;
	if(da.length == Double(da.array.count)){
		DynamicArrayCharactersIncreaseSize(&da)
	}

	da.array[Int(da.length)] = value
	da.length = da.length + 1.0
}


func DynamicArrayAddString(_ da : inout DynamicArrayCharacters, _ str : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(str.count)){
		DynamicArrayAddCharacter(&da, str[Int(i)])
		i = i + 1.0
	}
}


func DynamicArrayCharactersIncreaseSize(_ da : inout DynamicArrayCharacters) -> Void{
	var newLength, i : Double
	var newArray : [Character]

	newLength = round(Double(da.array.count)*3.0/2.0)
	newArray = Array(repeating:Character(" "), count: Int(newLength))

	i = 0.0
	while(i < Double(da.array.count)){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayCharactersDecreaseSizeNecessary(_ da : inout DynamicArrayCharacters) -> Bool{
	var needsDecrease : Bool

	needsDecrease = false

	if(da.length > 10.0){
		needsDecrease = da.length <= round(Double(da.array.count)*2.0/3.0)
	}

	return needsDecrease
}


func DynamicArrayCharactersDecreaseSize(_ da : inout DynamicArrayCharacters) -> Void{
	var newLength, i : Double
	var newArray : [Character]

	newLength = round(Double(da.array.count)*2.0/3.0)
	newArray = Array(repeating:Character(" "), count: Int(newLength))

	i = 0.0
	while(i < newLength){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayCharactersIndex(_ da : inout DynamicArrayCharacters, _ index : Double) -> Character{
	var index = index;
	return da.array[Int(index)]
}


func DynamicArrayCharactersLength(_ da : inout DynamicArrayCharacters) -> Double{
	return da.length
}


func DynamicArrayInsertCharacter(_ da : inout DynamicArrayCharacters, _ index : Double, _ value : Character) -> Void{
	var index = index;
	var value = value;
	var i : Double

	if(da.length == Double(da.array.count)){
		DynamicArrayCharactersIncreaseSize(&da)
	}

	i = da.length
	while(i > index){
		da.array[Int(i)] = da.array[Int(i - 1.0)]
		i = i - 1.0
	}

	da.array[Int(index)] = value

	da.length = da.length + 1.0
}


func DynamicArrayCharacterSet(_ da : inout DynamicArrayCharacters, _ index : Double, _ value : Character) -> Bool{
	var index = index;
	var value = value;
	var success : Bool

	if(index < da.length){
		da.array[Int(index)] = value
		success = true
	}else{
		success = false
	}

	return success
}


func DynamicArrayRemoveCharacter(_ da : inout DynamicArrayCharacters, _ index : Double) -> Void{
	var index = index;
	var i : Double

	i = index
	while(i < da.length - 1.0){
		da.array[Int(i)] = da.array[Int(i + 1.0)]
		i = i + 1.0
	}

	da.length = da.length - 1.0

	if(DynamicArrayCharactersDecreaseSizeNecessary(&da)){
		DynamicArrayCharactersDecreaseSize(&da)
	}
}


func FreeDynamicArrayCharacters(_ da : inout DynamicArrayCharacters) -> Void{
	delete(da.array)
	delete(da)
}


func DynamicArrayCharactersToArray(_ da : inout DynamicArrayCharacters) -> [Character]{
	var array : [Character]
	var i : Double

	array = Array(repeating:Character(" "), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		array[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	return array
}


func ArrayToDynamicArrayCharactersWithOptimalSize(_ array : inout [Character]) -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters
	var i : Double
	var c, n, newCapacity : Double

	c = Double(array.count)
	n = (log(c) - 1.0)/log(3.0/2.0)
	newCapacity = ceil(10.0*pow(3.0/2.0, n))

	da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity).ref

	i = 0.0
	while(i < Double(array.count)){
		da.array[Int(i)] = array[Int(i)]
		i = i + 1.0
	}

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func ArrayToDynamicArrayCharacters(_ array : inout [Character]) -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters

	da = DynamicArrayCharacters()
	da.array = arraysCopyString(&array)
	da.length = Double(array.count)

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayCharactersEqual(_ a : inout DynamicArrayCharacters, _ b : inout DynamicArrayCharacters) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(a.length == b.length){
		i = 0.0
		while(i < a.length && equal){
			if(a.array[Int(i)] != b.array[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func DynamicArrayCharactersToLinkedList(_ da : inout DynamicArrayCharacters) -> LinkedListCharactersReferenceClass{
	var ll : LinkedListCharacters
	var i : Double

	ll = CreateLinkedListCharacter().ref

	i = 0.0
	while(i < da.length){
		LinkedListAddCharacter(&ll, da.array[Int(i)])
		i = i + 1.0
	}

	var returnReference = LinkedListCharactersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListToDynamicArrayCharacters(_ ll : inout LinkedListCharacters) -> DynamicArrayCharactersReferenceClass{
	var da : DynamicArrayCharacters
	var i : Double
	var node : LinkedListNodeCharacters

	node = ll.first

	da = DynamicArrayCharacters()
	da.length = LinkedListCharactersLength(&ll)

	da.array = Array(repeating:Character(" "), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		da.array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	var returnReference = DynamicArrayCharactersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func AddBoolean(_ list : inout [Bool], _ a : Bool) -> [Bool]{
	var a = a;
	var newlist : [Bool]
	var i : Double

	newlist = Array(repeating:Bool(), count: Int(Double(list.count) + 1.0))
	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddBooleanRef(_ list : inout BooleanArrayReference, _ i : Bool) -> Void{
	var i = i;
	list.booleanArray = AddBoolean(&list.booleanArray, i)
}


func RemoveBoolean(_ list : inout [Bool], _ n : Double) -> [Bool]{
	var n = n;
	var newlist : [Bool]
	var i : Double

	newlist = Array(repeating:Bool(), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}
		
	return newlist
}


func GetBooleanRef(_ list : inout BooleanArrayReference, _ i : Double) -> Bool{
	var i = i;
	return list.booleanArray[Int(i)]
}


func RemoveDecimalRef(_ list : inout BooleanArrayReference, _ i : Double) -> Void{
	var i = i;
	list.booleanArray = RemoveBoolean(&list.booleanArray, i)
}


func CreateLinkedListString() -> LinkedListStringsReferenceClass{
	var ll : LinkedListStrings

	ll = LinkedListStrings()
	ll.first = LinkedListNodeStrings()
	ll.last = ll.first
	ll.last.end = true

	var returnReference = LinkedListStringsReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListAddString(_ ll : inout LinkedListStrings, _ value : inout [Character]) -> Void{
	ll.last.end = false
	ll.last.value = value
	ll.last.next = LinkedListNodeStrings()
	ll.last.next.end = true
	ll.last = ll.last.next
}


func LinkedListStringsToArray(_ ll : inout LinkedListStrings) -> [StringReference]{
	var array : [StringReference]
	var length, i : Double
	var node : LinkedListNodeStrings

	node = ll.first

	length = LinkedListStringsLength(&ll)

	array = Array(repeating:StringReference(), count: Int(length))

	i = 0.0
	while(i < length){
		array[Int(i)] = StringReference()
		array[Int(i)].stringx = node.value
		node = node.next
		i = i + 1.0
	}

	return array
}


func LinkedListStringsLength(_ ll : inout LinkedListStrings) -> Double{
	var l : Double
	var node : LinkedListNodeStrings

	l = 0.0
	node = ll.first
	while(!node.end){
		node = node.next
		l = l + 1.0
	}

	return l
}


func FreeLinkedListString(_ ll : inout LinkedListStrings) -> Void{
	var node, prev : LinkedListNodeStrings

	node = ll.first

	while(!node.end){
		prev = node
		node = node.next
		delete(prev)
	}

	delete(node)
}


func LinkedListInsertString(_ ll : inout LinkedListStrings, _ index : Double, _ value : inout [Character]) -> Void{
	var index = index;
	var i : Double
	var node, tmp : LinkedListNodeStrings

	if(index == 0.0){
		tmp = ll.first
		ll.first = LinkedListNodeStrings()
		ll.first.next = tmp
		ll.first.value = value
		ll.first.end = false
	}else{
		node = ll.first
		i = 0.0
		while(i < index - 1.0){
			node = node.next
			i = i + 1.0
		}

		tmp = node.next
		node.next = LinkedListNodeStrings()
		node.next.next = tmp
		node.next.value = value
		node.next.end = false
	}
}


func CreateLinkedListNumbers() -> LinkedListNumbersReferenceClass{
	var ll : LinkedListNumbers

	ll = LinkedListNumbers()
	ll.first = LinkedListNodeNumbers()
	ll.last = ll.first
	ll.last.end = true

	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func CreateLinkedListNumbersArray(_ length : Double) -> [LinkedListNumbers]{
	var length = length;
	var lls : [LinkedListNumbers]
	var i : Double

	lls = Array(repeating:LinkedListNumbers(), count: Int(length))
	i = 0.0
	while(i < Double(lls.count)){
		lls[Int(i)] = CreateLinkedListNumbers().ref
		i = i + 1.0
	}

	return lls
}


func LinkedListAddNumber(_ ll : inout LinkedListNumbers, _ value : Double) -> Void{
	var value = value;
	ll.last.end = false
	ll.last.value = value
	ll.last.next = LinkedListNodeNumbers()
	ll.last.next.end = true
	ll.last = ll.last.next
}


func LinkedListNumbersLength(_ ll : inout LinkedListNumbers) -> Double{
	var l : Double
	var node : LinkedListNodeNumbers

	l = 0.0
	node = ll.first
	while(!node.end){
		node = node.next
		l = l + 1.0
	}

	return l
}


func LinkedListNumbersIndex(_ ll : inout LinkedListNumbers, _ index : Double) -> Double{
	var index = index;
	var i : Double
	var node : LinkedListNodeNumbers

	node = ll.first
	i = 0.0
	while(i < index){
		node = node.next
		i = i + 1.0
	}

	return node.value
}


func LinkedListInsertNumber(_ ll : inout LinkedListNumbers, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var i : Double
	var node, tmp : LinkedListNodeNumbers

	if(index == 0.0){
		tmp = ll.first
		ll.first = LinkedListNodeNumbers()
		ll.first.next = tmp
		ll.first.value = value
		ll.first.end = false
	}else{
		node = ll.first
		i = 0.0
		while(i < index - 1.0){
			node = node.next
			i = i + 1.0
		}

		tmp = node.next
		node.next = LinkedListNodeNumbers()
		node.next.next = tmp
		node.next.value = value
		node.next.end = false
	}
}


func LinkedListSet(_ ll : inout LinkedListNumbers, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var i : Double
	var node : LinkedListNodeNumbers

	node = ll.first
	i = 0.0
	while(i < index){
		node = node.next
		i = i + 1.0
	}

	node.next.value = value
}


func LinkedListRemoveNumber(_ ll : inout LinkedListNumbers, _ index : Double) -> Void{
	var index = index;
	var i : Double
	var node, prev : LinkedListNodeNumbers

	node = ll.first
	prev = ll.first

	i = 0.0
	while(i < index){
		prev = node
		node = node.next
		i = i + 1.0
	}

	if(index == 0.0){
		ll.first = prev.next
	}
	if(!prev.next.end){
		prev.next = prev.next.next
	}
}


func FreeLinkedListNumbers(_ ll : inout LinkedListNumbers) -> Void{
	var node, prev : LinkedListNodeNumbers

	node = ll.first

	while(!node.end){
		prev = node
		node = node.next
		delete(prev)
	}

	delete(node)
}


func FreeLinkedListNumbersArray(_ lls : inout [LinkedListNumbers]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(lls.count)){
		FreeLinkedListNumbers(&lls[Int(i)])
		i = i + 1.0
	}
	delete(lls)
}


func LinkedListNumbersToArray(_ ll : inout LinkedListNumbers) -> [Double]{
	var array : [Double]
	var length, i : Double
	var node : LinkedListNodeNumbers

	node = ll.first

	length = LinkedListNumbersLength(&ll)

	array = Array(repeating:Double(), count: Int(length))

	i = 0.0
	while(i < length){
		array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	return array
}


func ArrayToLinkedListNumbers(_ array : inout [Double]) -> LinkedListNumbersReferenceClass{
	var ll : LinkedListNumbers
	var i : Double

	ll = CreateLinkedListNumbers().ref

	i = 0.0
	while(i < Double(array.count)){
		LinkedListAddNumber(&ll, array[Int(i)])
		i = i + 1.0
	}

	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListNumbersEqual(_ a : inout LinkedListNumbers, _ b : inout LinkedListNumbers) -> Bool{
	var equal, done : Bool
	var an, bn : LinkedListNodeNumbers

	an = a.first
	bn = b.first

	equal = true
	done = false
	while(equal && !done){
		if(an.end == bn.end){
			if(an.end){
				done = true
			}else if(an.value == bn.value){
				an = an.next
				bn = bn.next
			}else{
				equal = false
			}
		}else{
			equal = false
		}
	}

	return equal
}


func CreateLinkedListCharacter() -> LinkedListCharactersReferenceClass{
	var ll : LinkedListCharacters

	ll = LinkedListCharacters()
	ll.first = LinkedListNodeCharacters()
	ll.last = ll.first
	ll.last.end = true

	var returnReference = LinkedListCharactersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListAddCharacter(_ ll : inout LinkedListCharacters, _ value : Character) -> Void{
	var value = value;
	ll.last.end = false
	ll.last.value = value
	ll.last.next = LinkedListNodeCharacters()
	ll.last.next.end = true
	ll.last = ll.last.next
}


func LinkedListCharactersToArray(_ ll : inout LinkedListCharacters) -> [Character]{
	var array : [Character]
	var length, i : Double
	var node : LinkedListNodeCharacters

	node = ll.first

	length = LinkedListCharactersLength(&ll)

	array = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < length){
		array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	return array
}


func LinkedListCharactersLength(_ ll : inout LinkedListCharacters) -> Double{
	var l : Double
	var node : LinkedListNodeCharacters

	l = 0.0
	node = ll.first
	while(!node.end){
		node = node.next
		l = l + 1.0
	}

	return l
}


func FreeLinkedListCharacter(_ ll : inout LinkedListCharacters) -> Void{
	var node, prev : LinkedListNodeCharacters

	node = ll.first

	while(!node.end){
		prev = node
		node = node.next
		delete(prev)
	}

	delete(node)
}


func LinkedListCharactersAddString(_ ll : inout LinkedListCharacters, _ str : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(str.count)){
		LinkedListAddCharacter(&ll, str[Int(i)])
		i = i + 1.0
	}
}


func LinkedListInsertCharacter(_ ll : inout LinkedListCharacters, _ index : Double, _ value : Character) -> Void{
	var index = index;
	var value = value;
	var i : Double
	var node, tmp : LinkedListNodeCharacters

	if(index == 0.0){
		tmp = ll.first
		ll.first = LinkedListNodeCharacters()
		ll.first.next = tmp
		ll.first.value = value
		ll.first.end = false
	}else{
		node = ll.first
		i = 0.0
		while(i < index - 1.0){
			node = node.next
			i = i + 1.0
		}

		tmp = node.next
		node.next = LinkedListNodeCharacters()
		node.next.next = tmp
		node.next.value = value
		node.next.end = false
	}
}


func CreateDynamicArrayNumbers() -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers

	da = DynamicArrayNumbers()
	da.array = Array(repeating:Double(), count: Int(10))
	da.length = 0.0

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func CreateDynamicArrayNumbersWithInitialCapacity(_ capacity : Double) -> DynamicArrayNumbersReferenceClass{
	var capacity = capacity;
	var da : DynamicArrayNumbers

	da = DynamicArrayNumbers()
	da.array = Array(repeating:Double(), count: Int(capacity))
	da.length = 0.0

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayAddNumber(_ da : inout DynamicArrayNumbers, _ value : Double) -> Void{
	var value = value;
	if(da.length == Double(da.array.count)){
		DynamicArrayNumbersIncreaseSize(&da)
	}

	da.array[Int(da.length)] = value
	da.length = da.length + 1.0
}


func DynamicArrayNumbersIncreaseSize(_ da : inout DynamicArrayNumbers) -> Void{
	var newLength, i : Double
	var newArray : [Double]

	newLength = round(Double(da.array.count)*3.0/2.0)
	newArray = Array(repeating:Double(), count: Int(newLength))

	i = 0.0
	while(i < Double(da.array.count)){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayNumbersDecreaseSizeNecessary(_ da : inout DynamicArrayNumbers) -> Bool{
	var needsDecrease : Bool

	needsDecrease = false

	if(da.length > 10.0){
		needsDecrease = da.length <= round(Double(da.array.count)*2.0/3.0)
	}

	return needsDecrease
}


func DynamicArrayNumbersDecreaseSize(_ da : inout DynamicArrayNumbers) -> Void{
	var newLength, i : Double
	var newArray : [Double]

	newLength = round(Double(da.array.count)*2.0/3.0)
	newArray = Array(repeating:Double(), count: Int(newLength))

	i = 0.0
	while(i < newLength){
		newArray[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	delete(da.array)

	da.array = newArray
}


func DynamicArrayNumbersIndex(_ da : inout DynamicArrayNumbers, _ index : Double) -> Double{
	var index = index;
	return da.array[Int(index)]
}


func DynamicArrayNumbersLength(_ da : inout DynamicArrayNumbers) -> Double{
	return da.length
}


func DynamicArrayInsertNumber(_ da : inout DynamicArrayNumbers, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var i : Double

	if(da.length == Double(da.array.count)){
		DynamicArrayNumbersIncreaseSize(&da)
	}

	i = da.length
	while(i > index){
		da.array[Int(i)] = da.array[Int(i - 1.0)]
		i = i - 1.0
	}

	da.array[Int(index)] = value

	da.length = da.length + 1.0
}


func DynamicArrayNumberSet(_ da : inout DynamicArrayNumbers, _ index : Double, _ value : Double) -> Bool{
	var index = index;
	var value = value;
	var success : Bool

	if(index < da.length){
		da.array[Int(index)] = value
		success = true
	}else{
		success = false
	}

	return success
}


func DynamicArrayRemoveNumber(_ da : inout DynamicArrayNumbers, _ index : Double) -> Void{
	var index = index;
	var i : Double

	i = index
	while(i < da.length - 1.0){
		da.array[Int(i)] = da.array[Int(i + 1.0)]
		i = i + 1.0
	}

	da.length = da.length - 1.0

	if(DynamicArrayNumbersDecreaseSizeNecessary(&da)){
		DynamicArrayNumbersDecreaseSize(&da)
	}
}


func FreeDynamicArrayNumbers(_ da : inout DynamicArrayNumbers) -> Void{
	delete(da.array)
	delete(da)
}


func DynamicArrayNumbersToArray(_ da : inout DynamicArrayNumbers) -> [Double]{
	var array : [Double]
	var i : Double

	array = Array(repeating:Double(), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		array[Int(i)] = da.array[Int(i)]
		i = i + 1.0
	}

	return array
}


func ArrayToDynamicArrayNumbersWithOptimalSize(_ array : inout [Double]) -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers
	var i : Double
	var c, n, newCapacity : Double

	/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */
	c = Double(array.count)
	n = (log(c) - 1.0)/log(3.0/2.0)
	newCapacity = ceil(10.0*pow(3.0/2.0, n))

	da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity).ref

	i = 0.0
	while(i < Double(array.count)){
		da.array[Int(i)] = array[Int(i)]
		i = i + 1.0
	}

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func ArrayToDynamicArrayNumbers(_ array : inout [Double]) -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers

	da = DynamicArrayNumbers()
	da.array = arraysCopyNumberArray(&array)
	da.length = Double(array.count)

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayNumbersEqual(_ a : inout DynamicArrayNumbers, _ b : inout DynamicArrayNumbers) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(a.length == b.length){
		i = 0.0
		while(i < a.length && equal){
			if(a.array[Int(i)] != b.array[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func DynamicArrayNumbersToLinkedList(_ da : inout DynamicArrayNumbers) -> LinkedListNumbersReferenceClass{
	var ll : LinkedListNumbers
	var i : Double

	ll = CreateLinkedListNumbers().ref

	i = 0.0
	while(i < da.length){
		LinkedListAddNumber(&ll, da.array[Int(i)])
		i = i + 1.0
	}

	var returnReference = LinkedListNumbersReferenceClass()
	returnReference.ref = ll
	return returnReference
}


func LinkedListToDynamicArrayNumbers(_ ll : inout LinkedListNumbers) -> DynamicArrayNumbersReferenceClass{
	var da : DynamicArrayNumbers
	var i : Double
	var node : LinkedListNodeNumbers

	node = ll.first

	da = DynamicArrayNumbers()
	da.length = LinkedListNumbersLength(&ll)

	da.array = Array(repeating:Double(), count: Int(da.length))

	i = 0.0
	while(i < da.length){
		da.array[Int(i)] = node.value
		node = node.next
		i = i + 1.0
	}

	var returnReference = DynamicArrayNumbersReferenceClass()
	returnReference.ref = da
	return returnReference
}


func DynamicArrayNumbersIndexOf(_ arr : inout DynamicArrayNumbers, _ n : Double, _ foundReference : inout BooleanReference) -> Double{
	var n = n;
	var found : Bool
	var i : Double

	found = false
	i = 0.0
	while(i < arr.length && !found){
		if(arr.array[Int(i)] == n){
			found = true
		}
		i = i + 1.0
	}
	if(!found){
		i = -1.0
	}else{
		i = i - 1.0
	}

	foundReference.booleanValue = found

	return i
}


func DynamicArrayNumbersIsInArray(_ arr : inout DynamicArrayNumbers, _ n : Double) -> Bool{
	var n = n;
	var found : Bool
	var i : Double

	found = false
	i = 0.0
	while(i < arr.length && !found){
		if(arr.array[Int(i)] == n){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func AddCharacter(_ list : inout [Character], _ a : Character) -> [Character]{
	var a = a;
	var newlist : [Character]
	var i : Double

	newlist = Array(repeating:Character(" "), count: Int(Double(list.count) + 1.0))
	i = 0.0
	while(i < Double(list.count)){
		newlist[Int(i)] = list[Int(i)]
		i = i + 1.0
	}
	newlist[Int(Double(list.count))] = a
		
	delete(list)
		
	return newlist
}


func AddCharacterRef(_ list : inout StringReference, _ i : Character) -> Void{
	var i = i;
	list.stringx = AddCharacter(&list.stringx, i)
}


func RemoveCharacter(_ list : inout [Character], _ n : Double) -> [Character]{
	var n = n;
	var newlist : [Character]
	var i : Double

	newlist = Array(repeating:Character(" "), count: Int(Double(list.count) - 1.0))

	if(n >= 0.0 && n < Double(list.count)){
		i = 0.0
		while(i < Double(list.count)){
			if(i < n){
				newlist[Int(i)] = list[Int(i)]
			}
			if(i > n){
				newlist[Int(i - 1.0)] = list[Int(i)]
			}
			i = i + 1.0
		}

		delete(list)
	}else{
		delete(newlist)
	}

	return newlist
}


func GetCharacterRef(_ list : inout StringReference, _ i : Double) -> Character{
	var i = i;
	return list.stringx[Int(i)]
}


func RemoveCharacterRef(_ list : inout StringReference, _ i : Double) -> Void{
	var i = i;
	list.stringx = RemoveCharacter(&list.stringx, i)
}


func GetAccrualAmount(_ total : Double, _ fromYear : Double, _ fromMonth : Double, _ fromDay : Double, _ toYear : Double, _ toMonth : Double, _ toDay : Double, _ yearOfInterest : Double, _ monthOfInterest : Double) -> Double{
	var total = total;
	var fromYear = fromYear;
	var fromMonth = fromMonth;
	var fromDay = fromDay;
	var toYear = toYear;
	var toMonth = toMonth;
	var toDay = toDay;
	var yearOfInterest = yearOfInterest;
	var monthOfInterest = monthOfInterest;
	var from, to : Date
	var amount : Double

	from = CreateDate(fromYear, fromMonth, fromDay).ref
	to = CreateDate(toYear, toMonth, toDay).ref

	amount = GetAccrualAmountWithDates(total, &from, &to, yearOfInterest, monthOfInterest)

	return amount
}


func GetAccruals(_ total : Double, _ fromYear : Double, _ fromMonth : Double, _ fromDay : Double, _ toYear : Double, _ toMonth : Double, _ toDay : Double) -> [Double]{
	var total = total;
	var fromYear = fromYear;
	var fromMonth = fromMonth;
	var fromDay = fromDay;
	var toYear = toYear;
	var toMonth = toMonth;
	var toDay = toDay;
	var from, to : Date
	var amounts : [Double]

	from = CreateDate(fromYear, fromMonth, fromDay).ref
	to = CreateDate(toYear, toMonth, toDay).ref

	amounts = GetAccrualsWithDates(total, &from, &to)

	return amounts
}


func GetAccrualsWithDates(_ total : Double, _ from : inout Date, _ to : inout Date) -> [Double]{
	var total = total;
	var entry : Double
	var done : Bool
	var dateOfInterest : Date
	var list : LinkedListNumbers
	var result : [Double]

	list = CreateLinkedListNumbers().ref

	done = false
	dateOfInterest = Date()
	AssignDate(&dateOfInterest, &from)
	while(!done){
		if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
			done = true
		}

		entry = GetAccrualAmountWithDates(total, &from, &to, dateOfInterest.year, dateOfInterest.month)
		LinkedListAddNumber(&list, entry)
		AddMonthsToDate(&dateOfInterest, 1.0)
	}

	result = LinkedListNumbersToArray(&list)
	FreeLinkedListNumbers(&list)

	return result
}


func GetAccrualAmountWithDates(_ total : Double, _ from : inout Date, _ to : inout Date, _ yearOfInterest : Double, _ monthOfInterest : Double) -> Double{
	var total = total;
	var yearOfInterest = yearOfInterest;
	var monthOfInterest = monthOfInterest;
	var unadjustedAmount, adjustment, days, daysToAdjust, n : Double
	var adjustTo : Date
	var valuePerDay, divisibleRemaining, divisibleTotal, amount : FixedPoint15d
	var message : StringReference

	message = StringReference()

	valuePerDay = CreateFixedPoint15d(13.0, 2.0).ref
	divisibleRemaining = CreateFixedPoint15d(13.0, 2.0).ref
	divisibleTotal = CreateFixedPoint15d(13.0, 2.0).ref
	amount = CreateFixedPoint15d(13.0, 2.0).ref

	days = DaysBetweenDates(&from, &to) + 1.0

	/* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining*/
	DivideFloored15d(&valuePerDay, &divisibleRemaining, &Number15d(total).ref, &Number15d(days).ref)

	Multiply15d(&divisibleTotal, &valuePerDay, &Number15d(days).ref)
	unadjustedAmount = GetUnadjustedAccrualAmountWithDates(&divisibleTotal, &from, &to, yearOfInterest, monthOfInterest)

	if(!Equals15d(&divisibleRemaining, &Number15d(0.0).ref)){
		daysToAdjust = Roundx(ToNumber15d(&divisibleRemaining)*100.0)
		adjustTo = Date()
		AssignDate(&adjustTo, &from)
		AddDaysToDate(&adjustTo, daysToAdjust - 1.0, &message)

		adjustment = GetUnadjustedAccrualAmountWithDates(&divisibleRemaining, &from, &adjustTo, yearOfInterest, monthOfInterest)

		delete(adjustTo)
	}else{
		adjustment = 0.0
	}

	Add15d(&amount, &Number15d(unadjustedAmount).ref, &Number15d(adjustment).ref)

	n = ToNumber15d(&amount)

	delete(valuePerDay)
	delete(divisibleRemaining)
	delete(divisibleTotal)
	delete(amount)

	return n
}


func GetUnadjustedAccrualAmountWithDates(_ total : inout FixedPoint15d, _ from : inout Date, _ to : inout Date, _ yearOfInterest : Double, _ monthOfInterest : Double) -> Double{
	var yearOfInterest = yearOfInterest;
	var monthOfInterest = monthOfInterest;
	var days, daysInMonthOfInterest, n : Double
	var lastDayInMonth, firstDateInMonth : Date
	var daysInMonth : [Double]
	var valuePerDay, value, remainder : FixedPoint15d
	var success : Bool

	value = CreateFixedPoint15d(13.0, 2.0).ref
	valuePerDay = CreateFixedPoint15d(13.0, 2.0).ref
	remainder = CreateFixedPoint15d(13.0, 2.0).ref

	days = DaysBetweenDates(&from, &to) + 1.0
	/* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...*/
	success = DivideFloored15d(&valuePerDay, &remainder, &total, &Number15d(days).ref)

	if(success){
		daysInMonth = GetDaysInMonth(yearOfInterest)

		if(yearOfInterest < from.year){
			Assign15d(&value, 0.0)
		}else if(yearOfInterest == from.year && monthOfInterest < from.month){
			Assign15d(&value, 0.0)
		}else if(yearOfInterest > to.year){
			Assign15d(&value, 0.0)
		}else if(yearOfInterest == to.year && monthOfInterest > to.month){
			Assign15d(&value, 0.0)
		}else{
if(from.year == yearOfInterest && from.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest){
				daysInMonthOfInterest = days
			}else if(from.year == yearOfInterest && from.month == monthOfInterest){
				lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[Int(monthOfInterest)]).ref
				daysInMonthOfInterest = DaysBetweenDates(&from, &lastDayInMonth) + 1.0
			}else if(to.year == yearOfInterest && to.month == monthOfInterest){
				firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0).ref
				daysInMonthOfInterest = DaysBetweenDates(&firstDateInMonth, &to) + 1.0
			}else{
				daysInMonthOfInterest = daysInMonth[Int(monthOfInterest)]
			}

			/* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value*/
			Multiply15d(&value, &valuePerDay, &Number15d(daysInMonthOfInterest).ref)
		}

		delete(daysInMonth)
	}

	n = ToNumber15d(&value)

	delete(value)
	delete(valuePerDay)
	delete(remainder)

	return n
}


func CreateNewArrayData() -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isArray = true
	data.isStruture = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false
	data.array = CreateArray().ref

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateNewStructData() -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isStruture = true
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false
	data.structure = CreateStructure().ref

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateStructure() -> StructureReferenceClass{
	var st : Structure

	st = Structure()
	st.keys = CreateArray().ref
	st.values = CreateArray().ref

	var returnReference = StructureReferenceClass()
	returnReference.ref = st
	return returnReference
}


func CreateNumberData(_ n : Double) -> DataReferenceClass{
	var n = n;
	var data : Data

	data = Data()
	data.isNumber = true
	data.isStruture = false
	data.isArray = false
	data.isBoolean = false
	data.isString = false
	data.number = n

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateBooleanData(_ b : Bool) -> DataReferenceClass{
	var b = b;
	var data : Data

	data = Data()
	data.isBoolean = true
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isString = false
	data.booleanx = b

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateStringData(_ stringx : inout [Character]) -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isString = true
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.stringx = stringx

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateStructData(_ structure : inout Structure) -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isString = false
	data.isStruture = true
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.structure = structure

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateArrayData(_ array : inout Arrayx) -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isString = false
	data.isStruture = false
	data.isArray = true
	data.isNumber = false
	data.isBoolean = false
	data.array = array

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func CreateNoTypeData() -> DataReferenceClass{
	var data : Data

	data = Data()
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false

	var returnReference = DataReferenceClass()
	returnReference.ref = data
	return returnReference
}


func AddStructToArray(_ ar : inout Arrayx, _ st : inout Structure) -> Void{
	var data : Data

	data = CreateNewStructData().ref
	delete(data.structure)
	data.structure = st

	ArrayAdd(&ar, &data)
}


func AddArrayToArray(_ ar : inout Arrayx, _ ar2 : inout Arrayx) -> Void{
	var data : Data

	data = CreateNewArrayData().ref
	delete(data.array)
	data.array = ar2

	ArrayAdd(&ar, &data)
}


func AddNumberToArray(_ ar : inout Arrayx, _ n : Double) -> Void{
	var n = n;
	ArrayAdd(&ar, &CreateNumberData(n).ref)
}


func AddBooleanToArray(_ ar : inout Arrayx, _ b : Bool) -> Void{
	var b = b;
	ArrayAdd(&ar, &CreateBooleanData(b).ref)
}


func AddStringToArray(_ ar : inout Arrayx, _ str : inout [Character]) -> Void{
	ArrayAdd(&ar, &CreateStringData(&str).ref)
}


func AddDataToArray(_ ar : inout Arrayx, _ data : inout Data) -> Void{
	ArrayAdd(&ar, &data)
}


func StructKeys(_ st : inout Structure) -> Double{
	return ArrayLength(&st.keys)
}


func StructHasKey(_ st : inout Structure, _ key : inout [Character]) -> Bool{
	var i : Double
	var hasKey : Bool

	hasKey = false
	i = 0.0
	while(i < StructKeys(&st)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			hasKey = true
		}
		i = i + 1.0
	}

	return hasKey
}


func StructKeyIndex(_ st : inout Structure, _ key : inout [Character]) -> Double{
	var i : Double
	var index : Double

	index = -1.0
	i = 0.0
	while(i < StructKeys(&st)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			index = i
		}
		i = i + 1.0
	}

	return index
}


func GetStructKeys(_ st : inout Structure) -> [StringReference]{
	var keys : [StringReference]
	var nr, i : Double

	nr = StructKeys(&st)

	keys = Array(repeating:StringReference(), count: Int(nr))

	i = 0.0
	while(i < nr){
		keys[Int(i)] = StringReference()
		keys[Int(i)].stringx = arraysCopyString(&st.keys.array[Int(i)].stringx)
		i = i + 1.0
	}

	return keys
}


func GetStructFromStruct(_ st : inout Structure, _ key : inout [Character]) -> StructureReferenceClass{
	var i : Double
	var r : Structure

	r = Structure()
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].structure
		}
		i = i + 1.0
	}

	var returnReference = StructureReferenceClass()
	returnReference.ref = r
	return returnReference
}


func GetArrayFromStruct(_ st : inout Structure, _ key : inout [Character]) -> ArrayxReferenceClass{
	var i : Double
	var r : Arrayx

	r = Arrayx()
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].array
		}
		i = i + 1.0
	}

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = r
	return returnReference
}


func GetNumberFromStruct(_ st : inout Structure, _ key : inout [Character]) -> Double{
	var i, r : Double

	r = 0.0
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].number
		}
		i = i + 1.0
	}

	return r
}


func GetBooleanFromStruct(_ st : inout Structure, _ key : inout [Character]) -> Bool{
	var i : Double
	var r : Bool

	r = false
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].booleanx
		}
		i = i + 1.0
	}

	return r
}


func GetStringFromStruct(_ st : inout Structure, _ key : inout [Character]) -> [Character]{
	var i : Double
	var r : [Character]

	r = characterArray("").ca
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			r = st.values.array[Int(i)].stringx
		}
		i = i + 1.0
	}

	return r
}


func GetDataFromStruct(_ st : inout Structure, _ key : inout [Character]) -> DataReferenceClass{
	var i : Double
	var r : Data

	r = Data()
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			delete(r)
			r = st.values.array[Int(i)]
		}
		i = i + 1.0
	}

	var returnReference = DataReferenceClass()
	returnReference.ref = r
	return returnReference
}


func GetDataFromStructWithCheck(_ st : inout Structure, _ key : inout [Character], _ foundRef : inout BooleanReference) -> DataReferenceClass{
	var i : Double
	var r : Data

	r = Data()
	foundRef.booleanValue = false
	i = 0.0
	while(i < ArrayLength(&st.keys)){
		if(arraysStringsEqual(&st.keys.array[Int(i)].stringx, &key)){
			delete(r)
			foundRef.booleanValue = true
			r = st.values.array[Int(i)]
		}
		i = i + 1.0
	}

	var returnReference = DataReferenceClass()
	returnReference.ref = r
	return returnReference
}


func AddStructToStruct(_ st : inout Structure, _ key : inout [Character], _ structx : inout Structure) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		delete(st.values.array[Int(i)].structure)
		st.values.array[Int(i)].structure = structx
	}else{
		AddStringToArray(&st.keys, &key)
		AddStructToArray(&st.values, &structx)
	}
}


func AddArrayToStruct(_ st : inout Structure, _ key : inout [Character], _ ar : inout Arrayx) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		delete(st.values.array[Int(i)].array)
		st.values.array[Int(i)].array = ar
	}else{
		AddStringToArray(&st.keys, &key)
		AddArrayToArray(&st.values, &ar)
	}
}


func AddNumberToStruct(_ st : inout Structure, _ key : inout [Character], _ n : Double) -> Void{
	var n = n;
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		st.values.array[Int(i)].number = n
	}else{
		AddStringToArray(&st.keys, &key)
		AddNumberToArray(&st.values, n)
	}
}


func AddBooleanToStruct(_ st : inout Structure, _ key : inout [Character], _ b : Bool) -> Void{
	var b = b;
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		st.values.array[Int(i)].booleanx = b
	}else{
		AddStringToArray(&st.keys, &key)
		AddBooleanToArray(&st.values, b)
	}
}


func AddStringToStruct(_ st : inout Structure, _ key : inout [Character], _ value : inout [Character]) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		delete(st.values.array[Int(i)].stringx)
		st.values.array[Int(i)].stringx = value
	}else{
		AddStringToArray(&st.keys, &key)
		AddStringToArray(&st.values, &value)
	}
}


func AddDataToStruct(_ st : inout Structure, _ key : inout [Character], _ data : inout Data) -> Void{
	var i : Double

	if(StructHasKey(&st, &key)){
		i = StructKeyIndex(&st, &key)
		FreeData(&st.values.array[Int(i)])
		st.values.array[Int(i)] = data
	}else{
		AddStringToArray(&st.keys, &key)
		AddDataToArray(&st.values, &data)
	}
}


func FreeData(_ data : inout Data) -> Void{
	var i : Double
	var st : Structure

	if(data.isStruture){
		st = data.structure
		i = 0.0
		while(i < StructKeys(&st)){
			FreeData(&ArrayIndex(&st.keys, i).ref)
			FreeData(&ArrayIndex(&st.values, i).ref)
			i = i + 1.0
		}
		delete(st)
	}else if(data.isArray){
		FreeArray(&data.array)
	}

	delete(data)
}


func FreeArray(_ array : inout Arrayx) -> Void{
	var i : Double

	i = 0.0
	while(i < ArrayLength(&array)){
		FreeData(&array.array[Int(i)])
		i = i + 1.0
	}

	delete(array.array)
	delete(array)
}


func DataTypeEquals(_ a : inout Data, _ b : inout Data) -> Bool{
	var equal : Bool

	equal = true
	equal = equal && a.isStruture == b.isStruture
	equal = equal && a.isArray == b.isArray
	equal = equal && a.isNumber == b.isNumber
	equal = equal && a.isBoolean == b.isBoolean
	equal = equal && a.isString == b.isString

	return equal
}


func IsStructure(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isStruture
	if(a.isArray || a.isNumber || a.isBoolean || a.isString){
		itis = false
	}

	return itis
}


func IsArray(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isArray
	if(a.isStruture || a.isNumber || a.isBoolean || a.isString){
		itis = false
	}

	return itis
}


func IsNumber(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isNumber
	if(a.isStruture || a.isArray || a.isBoolean || a.isString){
		itis = false
	}

	return itis
}


func IsBoolean(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isBoolean
	if(a.isStruture || a.isArray || a.isNumber || a.isString){
		itis = false
	}

	return itis
}


func IsString(_ a : inout Data) -> Bool{
	var itis : Bool

	itis = a.isString
	if(a.isStruture || a.isArray || a.isNumber || a.isBoolean){
		itis = false
	}

	return itis
}


func IsNoType(_ a : inout Data) -> Bool{
	var itis : Bool

	if(!a.isString && !a.isStruture && !a.isArray && !a.isNumber && !a.isBoolean){
		itis = true
	}else{
		itis = false
	}

	return itis
}


func CreateArray() -> ArrayxReferenceClass{
	var array : Arrayx

	array = Arrayx()
	array.array = Array(repeating:Data(), count: Int(10))
	array.length = 0.0

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = array
	return returnReference
}


func CreateArrayWithInitialCapacity(_ capacity : Double) -> ArrayxReferenceClass{
	var capacity = capacity;
	var array : Arrayx

	array = Arrayx()
	array.array = Array(repeating:Data(), count: Int(capacity))
	array.length = 0.0

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = array
	return returnReference
}


func ArrayAdd(_ array : inout Arrayx, _ value : inout Data) -> Void{
	if(array.length == Double(array.array.count)){
		ArrayIncreaseSize(&array)
	}

	array.array[Int(array.length)] = value
	array.length = array.length + 1.0
}


func ArrayAddString(_ array : inout Arrayx, _ value : inout [Character]) -> Void{
	var data : Data

	data = CreateStringData(&value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddBoolean(_ array : inout Arrayx, _ value : Bool) -> Void{
	var value = value;
	var data : Data

	data = CreateBooleanData(value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddNumber(_ array : inout Arrayx, _ value : Double) -> Void{
	var value = value;
	var data : Data

	data = CreateNumberData(value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddStruct(_ array : inout Arrayx, _ value : inout Structure) -> Void{
	var data : Data

	data = CreateStructData(&value).ref

	ArrayAdd(&array, &data)
}


func ArrayAddArray(_ array : inout Arrayx, _ value : inout Arrayx) -> Void{
	var data : Data

	data = CreateArrayData(&value).ref

	ArrayAdd(&array, &data)
}


func ArrayIncreaseSize(_ array : inout Arrayx) -> Void{
	var newLength, i : Double
	var newArray : [Data]

	newLength = round(Double(array.array.count)*3.0/2.0)
	newArray = Array(repeating:Data(), count: Int(newLength))

	i = 0.0
	while(i < Double(array.array.count)){
		newArray[Int(i)] = array.array[Int(i)]
		i = i + 1.0
	}

	delete(array.array)

	array.array = newArray
}


func ArrayDecreaseSizeNecessary(_ array : inout Arrayx) -> Bool{
	var needsDecrease : Bool

	needsDecrease = false

	if(array.length > 10.0){
		needsDecrease = array.length <= round(Double(array.array.count)*2.0/3.0)
	}

	return needsDecrease
}


func ArrayDecreaseSize(_ array : inout Arrayx) -> Void{
	var newLength, i : Double
	var newArray : [Data]

	newLength = round(Double(array.array.count)*2.0/3.0)
	newArray = Array(repeating:Data(), count: Int(newLength))

	i = 0.0
	while(i < newLength){
		newArray[Int(i)] = array.array[Int(i)]
		i = i + 1.0
	}

	delete(array.array)

	array.array = newArray
}


func ArrayIndex(_ array : inout Arrayx, _ index : Double) -> DataReferenceClass{
	var index = index;
	var returnReference = DataReferenceClass()
	returnReference.ref = array.array[Int(index)]
	return returnReference
}


func ArrayIndexArray(_ array : inout Arrayx, _ index : Double) -> ArrayxReferenceClass{
	var index = index;
	var returnReference = ArrayxReferenceClass()
	returnReference.ref = array.array[Int(index)].array
	return returnReference
}


func ArrayIndexStruct(_ array : inout Arrayx, _ index : Double) -> StructureReferenceClass{
	var index = index;
	var returnReference = StructureReferenceClass()
	returnReference.ref = array.array[Int(index)].structure
	return returnReference
}


func ArrayIndexBoolean(_ array : inout Arrayx, _ index : Double) -> Bool{
	var index = index;
	return array.array[Int(index)].booleanx
}


func ArrayIndexString(_ array : inout Arrayx, _ index : Double) -> [Character]{
	var index = index;
	return array.array[Int(index)].stringx
}


func ArrayIndexNumber(_ array : inout Arrayx, _ index : Double) -> Double{
	var index = index;
	return array.array[Int(index)].number
}


func ArrayLength(_ array : inout Arrayx) -> Double{
	return array.length
}


func ArrayInsert(_ array : inout Arrayx, _ index : Double, _ value : inout Data) -> Void{
	var index = index;
	var i : Double

	if(array.length == Double(array.array.count)){
		ArrayIncreaseSize(&array)
	}

	i = array.length
	while(i > index){
		array.array[Int(i)] = array.array[Int(i - 1.0)]
		i = i - 1.0
	}

	array.array[Int(index)] = value

	array.length = array.length + 1.0
}


func ArrayInsertString(_ array : inout Arrayx, _ index : Double, _ value : inout [Character]) -> Void{
	var index = index;
	var data : Data

	data = CreateStringData(&value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertBoolean(_ array : inout Arrayx, _ index : Double, _ value : Bool) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateBooleanData(value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertNumber(_ array : inout Arrayx, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateNumberData(value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertStruct(_ array : inout Arrayx, _ index : Double, _ value : inout Structure) -> Void{
	var index = index;
	var data : Data

	data = CreateStructData(&value).ref

	ArrayInsert(&array, index, &data)
}


func ArrayInsertArray(_ array : inout Arrayx, _ index : Double, _ value : inout Arrayx) -> Void{
	var index = index;
	var data : Data

	data = CreateArrayData(&value).ref

	ArrayInsert(&array, index, &data)
}


func ArraySet(_ array : inout Arrayx, _ index : Double, _ value : inout Data) -> Bool{
	var index = index;
	var success : Bool

	if(index < array.length){
		array.array[Int(index)] = value
		success = true
	}else{
		success = false
	}

	return success
}


func ArraySetString(_ array : inout Arrayx, _ index : Double, _ value : inout [Character]) -> Void{
	var index = index;
	var data : Data

	data = CreateStringData(&value).ref

	ArraySet(&array, index, &data)
}


func ArraySetBoolean(_ array : inout Arrayx, _ index : Double, _ value : Bool) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateBooleanData(value).ref

	ArraySet(&array, index, &data)
}


func ArraySetNumber(_ array : inout Arrayx, _ index : Double, _ value : Double) -> Void{
	var index = index;
	var value = value;
	var data : Data

	data = CreateNumberData(value).ref

	ArraySet(&array, index, &data)
}


func ArraySetStruct(_ array : inout Arrayx, _ index : Double, _ value : inout Structure) -> Void{
	var index = index;
	var data : Data

	data = CreateStructData(&value).ref

	ArraySet(&array, index, &data)
}


func ArraySetArray(_ array : inout Arrayx, _ index : Double, _ value : inout Arrayx) -> Void{
	var index = index;
	var data : Data

	data = CreateArrayData(&value).ref

	ArraySet(&array, index, &data)
}


func ArrayRemove(_ array : inout Arrayx, _ index : Double) -> Void{
	var index = index;
	var i : Double

	i = index
	while(i < array.length - 1.0){
		array.array[Int(i)] = array.array[Int(i + 1.0)]
		i = i + 1.0
	}

	array.length = array.length - 1.0

	if(ArrayDecreaseSizeNecessary(&array)){
		ArrayDecreaseSize(&array)
	}
}


func ToStaticArray(_ arc : inout Arrayx) -> [Data]{
	var array : [Data]
	var i : Double

	array = Array(repeating:Data(), count: Int(arc.length))

	i = 0.0
	while(i < arc.length){
		array[Int(i)] = arc.array[Int(i)]
		i = i + 1.0
	}

	return array
}


func ToStaticNumberArray(_ array : inout Arrayx) -> [Double]{
	var result : [Double]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Double(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.number
		i = i + 1.0
	}

	return result
}


func ToStaticBooleanArray(_ array : inout Arrayx) -> [Bool]{
	var result : [Bool]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Bool(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.booleanx
		i = i + 1.0
	}

	return result
}


func ToStaticStringArray(_ array : inout Arrayx) -> [StringReference]{
	var result : [StringReference]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:StringReference(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = StringReference()
		result[Int(i)].stringx = ArrayIndex(&array, i).ref.stringx
		i = i + 1.0
	}

	return result
}


func ToStaticArrayArray(_ array : inout Arrayx) -> [Arrayx]{
	var result : [Arrayx]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Arrayx(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.array
		i = i + 1.0
	}

	return result
}


func ToStaticStructArray(_ array : inout Arrayx) -> [Structure]{
	var result : [Structure]
	var i, n : Double

	n = ArrayLength(&array)

	result = Array(repeating:Structure(), count: Int(n))

	i = 0.0
	while(i < n){
		result[Int(i)] = ArrayIndex(&array, i).ref.structure
		i = i + 1.0
	}

	return result
}


func StaticArrayToArrayWithOptimalSize(_ src : inout [Data]) -> ArrayxReferenceClass{
	var dst : Arrayx
	var i : Double
	var c, n, newCapacity : Double

	/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */

	c = Double(src.count)
	n = (log(c) - 1.0)/log(3.0/2.0)

	newCapacity = ceil(10.0*pow(3.0/2.0, ceil(n)))

	dst = CreateArrayWithInitialCapacity(newCapacity).ref

	i = 0.0
	while(i < Double(src.count)){
		dst.array[Int(i)] = src[Int(i)]
		i = i + 1.0
	}

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func StaticArrayToArray(_ src : inout [Data]) -> ArrayxReferenceClass{
	var i : Double
	var dst : Arrayx

	dst = CreateArrayWithInitialCapacity(Double(src.count)).ref
	i = 0.0
	while(i < Double(src.count)){
		dst.array[Int(i)] = src[Int(i)]
		i = i + 1.0
	}
	dst.length = Double(src.count)

	var returnReference = ArrayxReferenceClass()
	returnReference.ref = dst
	return returnReference
}


func arraysStringToNumberArray(_ stringx : inout [Character]) -> [Double]{
	var i : Double
	var array : [Double]

	array = Array(repeating:Double(), count: Int(Double(stringx.count)))

	i = 0.0
	while(i < Double(stringx.count)){
		array[Int(i)] = charToDouble(stringx[Int(i)])
		i = i + 1.0
	}
	return array
}


func arraysNumberArrayToString(_ array : inout [Double]) -> [Character]{
	var i : Double
	var stringx : [Character]

	stringx = Array(repeating:Character(" "), count: Int(Double(array.count)))

	i = 0.0
	while(i < Double(array.count)){
		stringx[Int(i)] = Character(Unicode.Scalar(Int(array[Int(i)]))!)
		i = i + 1.0
	}
	return stringx
}


func arraysNumberArraysEqual(_ a : inout [Double], _ b : inout [Double]) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count) && equal){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func arraysBooleanArraysEqual(_ a : inout [Bool], _ b : inout [Bool]) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count) && equal){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func arraysStringsEqual(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var equal : Bool
	var i : Double

	equal = true
	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count) && equal){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func arraysFillNumberArray(_ a : inout [Double], _ value : Double) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = value
		i = i + 1.0
	}
}


func arraysFillString(_ a : inout [Character], _ value : Character) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = value
		i = i + 1.0
	}
}


func arraysFillBooleanArray(_ a : inout [Bool], _ value : Bool) -> Void{
	var value = value;
	var i : Double

	i = 0.0
	while(i < Double(a.count)){
		a[Int(i)] = value
		i = i + 1.0
	}
}


func arraysFillNumberArrayRange(_ a : inout [Double], _ value : Double, _ from : Double, _ to : Double) -> Bool{
	var value = value;
	var from = from;
	var to = to;
	var i, length : Double
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		i = 0.0
		while(i < length){
			a[Int(from + i)] = value
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func arraysFillBooleanArrayRange(_ a : inout [Bool], _ value : Bool, _ from : Double, _ to : Double) -> Bool{
	var value = value;
	var from = from;
	var to = to;
	var i, length : Double
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		i = 0.0
		while(i < length){
			a[Int(from + i)] = value
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func arraysFillStringRange(_ a : inout [Character], _ value : Character, _ from : Double, _ to : Double) -> Bool{
	var value = value;
	var from = from;
	var to = to;
	var i, length : Double
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		i = 0.0
		while(i < length){
			a[Int(from + i)] = value
			i = i + 1.0
		}

		success = true
	}else{
		success = false
	}

	return success
}


func arraysCopyNumberArray(_ a : inout [Double]) -> [Double]{
	var i : Double
	var n : [Double]

	n = Array(repeating:Double(), count: Int(Double(a.count)))

	i = 0.0
	while(i < Double(a.count)){
		n[Int(i)] = a[Int(i)]
		i = i + 1.0
	}

	return n
}


func arraysCopyBooleanArray(_ a : inout [Bool]) -> [Bool]{
	var i : Double
	var n : [Bool]

	n = Array(repeating:Bool(), count: Int(Double(a.count)))

	i = 0.0
	while(i < Double(a.count)){
		n[Int(i)] = a[Int(i)]
		i = i + 1.0
	}

	return n
}


func arraysCopyString(_ a : inout [Character]) -> [Character]{
	var i : Double
	var n : [Character]

	n = Array(repeating:Character(" "), count: Int(Double(a.count)))

	i = 0.0
	while(i < Double(a.count)){
		n[Int(i)] = a[Int(i)]
		i = i + 1.0
	}

	return n
}


func arraysCopyNumberArrayRange(_ a : inout [Double], _ from : Double, _ to : Double, _ copyReference : inout NumberArrayReference) -> Bool{
	var from = from;
	var to = to;
	var i, length : Double
	var n : [Double]
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		n = Array(repeating:Double(), count: Int(length))

		i = 0.0
		while(i < length){
			n[Int(i)] = a[Int(from + i)]
			i = i + 1.0
		}

		copyReference.numberArray = n
		success = true
	}else{
		success = false
	}

	return success
}


func arraysCopyBooleanArrayRange(_ a : inout [Bool], _ from : Double, _ to : Double, _ copyReference : inout BooleanArrayReference) -> Bool{
	var from = from;
	var to = to;
	var i, length : Double
	var n : [Bool]
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		n = Array(repeating:Bool(), count: Int(length))

		i = 0.0
		while(i < length){
			n[Int(i)] = a[Int(from + i)]
			i = i + 1.0
		}

		copyReference.booleanArray = n
		success = true
	}else{
		success = false
	}

	return success
}


func arraysCopyStringRange(_ a : inout [Character], _ from : Double, _ to : Double, _ copyReference : inout StringReference) -> Bool{
	var from = from;
	var to = to;
	var i, length : Double
	var n : [Character]
	var success : Bool

	if(from >= 0.0 && from <= Double(a.count) && to >= 0.0 && to <= Double(a.count) && from <= to){
		length = to - from
		n = Array(repeating:Character(" "), count: Int(length))

		i = 0.0
		while(i < length){
			n[Int(i)] = a[Int(from + i)]
			i = i + 1.0
		}

		copyReference.stringx = n
		success = true
	}else{
		success = false
	}

	return success
}


func arraysIsLastElement(_ length : Double, _ index : Double) -> Bool{
	var length = length;
	var index = index;
	return index + 1.0 == length
}


func arraysCreateNumberArray(_ length : Double, _ value : Double) -> [Double]{
	var length = length;
	var value = value;
	var array : [Double]

	array = Array(repeating:Double(), count: Int(length))
	arraysFillNumberArray(&array, value)

	return array
}


func arraysCreateBooleanArray(_ length : Double, _ value : Bool) -> [Bool]{
	var length = length;
	var value = value;
	var array : [Bool]

	array = Array(repeating:Bool(), count: Int(length))
	arraysFillBooleanArray(&array, value)

	return array
}


func arraysCreateString(_ length : Double, _ value : Character) -> [Character]{
	var length = length;
	var value = value;
	var array : [Character]

	array = Array(repeating:Character(" "), count: Int(length))
	arraysFillString(&array, value)

	return array
}


func arraysSwapElementsOfNumberArray(_ A : inout [Double], _ ai : Double, _ bi : Double) -> Void{
	var ai = ai;
	var bi = bi;
	var tmp : Double

	tmp = A[Int(ai)]
	A[Int(ai)] = A[Int(bi)]
	A[Int(bi)] = tmp
}


func arraysSwapElementsOfStringArray(_ A : inout StringArrayReference, _ ai : Double, _ bi : Double) -> Void{
	var ai = ai;
	var bi = bi;
	var tmp : StringReference

	tmp = A.stringArray[Int(ai)]
	A.stringArray[Int(ai)] = A.stringArray[Int(bi)]
	A.stringArray[Int(bi)] = tmp
}


func arraysReverseNumberArray(_ array : inout [Double]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(array.count)/2.0){
		arraysSwapElementsOfNumberArray(&array, i, Double(array.count) - i - 1.0)
		i = i + 1.0
	}
}


func CreateStringScientificNotationDecimalFromNumber(_ n : Double) -> [Character]{
	var n = n;
	var mantissaReference, exponentReference : StringReference
	var e : Double
	var isPositive : Bool
	var result : [Character]

	mantissaReference = StringReference()
	exponentReference = StringReference()
	result = Array(repeating:Character(" "), count: Int(0))

	if(n < 0.0){
		isPositive = false
		n = -n
	}else{
		isPositive = true
	}

	if(n == 0.0){
		e = 0.0
	}else{
		e = GetFirstDecimalDigitPosition(n)

		if(e < 0.0){
			n = n*pow(10.0, abs(e))
		}else{
			n = n/pow(10.0, e)
		}
	}

	mantissaReference.stringx = CreateStringDecimalFromNumber(n)
	exponentReference.stringx = CreateStringDecimalFromNumber(e)

	if(!isPositive){
		result = strAppendString(&result, &characterArray("-").ca)
	}

	result = strAppendString(&result, &mantissaReference.stringx)
	result = strAppendString(&result, &characterArray("e").ca)
	result = strAppendString(&result, &exponentReference.stringx)

	return result
}


func CreateStringDecimalFromNumber(_ number : Double) -> [Character]{
	var number = number;
	var stringx : DynamicArrayCharacters
	var maximumDigits, i, d, digitPosition, trailingZeros : Double
	var hasPrintedPoint, isPositive, done : Bool
	var characterReference : CharacterReference
	var c : Character
	var str : [Character]

	stringx = CreateDynamicArrayCharacters().ref
	isPositive = true

	if(number < 0.0){
		isPositive = false
		number = -number
	}

	if(number == 0.0){
		DynamicArrayAddCharacter(&stringx, "0")
	}else{
		characterReference = CharacterReference()

		maximumDigits = GetMaximumDigitsForDecimal()

		digitPosition = GetFirstDecimalDigitPosition(number)

		hasPrintedPoint = false

		if(!isPositive){
			DynamicArrayAddCharacter(&stringx, "-")
		}

		/* Print leading zeros.*/
		if(digitPosition < 0.0){
			DynamicArrayAddCharacter(&stringx, "0")
			DynamicArrayAddCharacter(&stringx, ".")
			hasPrintedPoint = true
			i = 0.0
			while(i < -digitPosition - 1.0){
				DynamicArrayAddCharacter(&stringx, "0")
				i = i + 1.0
			}
		}

		/* Count trailing zeros*/
		trailingZeros = 0.0
		done = false
		i = 0.0
		while(i < maximumDigits && !done){
			d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1.0)
			if(d == 0.0){
				trailingZeros = trailingZeros + 1.0
			}else{
				done = true
			}
			i = i + 1.0
		}

		/* Print number.*/
		i = 0.0
		while(i < maximumDigits){
			d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i)

			if(!hasPrintedPoint && digitPosition - i + 1.0 == 0.0){
				if(maximumDigits - i > trailingZeros){
					DynamicArrayAddCharacter(&stringx, ".")
				}
				hasPrintedPoint = true
			}

			if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
			}else{
				GetDecimalDigitCharacterFromNumberWithCheck(d, &characterReference)
				c = characterReference.characterValue
				DynamicArrayAddCharacter(&stringx, c)
			}
			i = i + 1.0
		}

		/* Print trailing zeros.*/
		i = 0.0
		while(i < digitPosition - maximumDigits + 1.0){
			DynamicArrayAddCharacter(&stringx, "0")
			i = i + 1.0
		}
	}

	/* Done*/
	str = DynamicArrayCharactersToArray(&stringx)
	FreeDynamicArrayCharacters(&stringx)
	return str
}


func CreateStringFromNumberWithCheck(_ number : Double, _ basex : Double, _ stringRef : inout StringReference) -> Bool{
	var number = number;
	var basex = basex;
	var stringx : DynamicArrayCharacters
	var maximumDigits, i, d, digitPosition, trailingZeros : Double
	var success, hasPrintedPoint, isPositive, done : Bool
	var characterReference : CharacterReference
	var c : Character

	stringx = CreateDynamicArrayCharacters().ref
	isPositive = true

	if(number < 0.0){
		isPositive = false
		number = -number
	}

	if(number == 0.0){
		DynamicArrayAddCharacter(&stringx, "0")
		success = true
	}else{
		characterReference = CharacterReference()

		if(IsInteger(basex)){
			success = true

			maximumDigits = GetMaximumDigitsForBase(basex)

			digitPosition = GetFirstDigitPosition(number, basex)

			hasPrintedPoint = false

			if(!isPositive){
				DynamicArrayAddCharacter(&stringx, "-")
			}

			/* Print leading zeros.*/
			if(digitPosition < 0.0){
				DynamicArrayAddCharacter(&stringx, "0")
				DynamicArrayAddCharacter(&stringx, ".")
				hasPrintedPoint = true
				i = 0.0
				while(i < -digitPosition - 1.0){
					DynamicArrayAddCharacter(&stringx, "0")
					i = i + 1.0
				}
			}

			/* Count trailing zeros*/
			trailingZeros = 0.0
			done = false
			i = 0.0
			while(i < maximumDigits && !done){
				d = GetDigit(number, basex, maximumDigits - i - 1.0)
				if(d == 0.0){
					trailingZeros = trailingZeros + 1.0
				}else{
					done = true
				}
				i = i + 1.0
			}

			/* Print number.*/
			i = 0.0
			while(i < maximumDigits && success){
				d = GetDigit(number, basex, i)

				if(d >= basex){
					d = basex - 1.0
				}

				if(!hasPrintedPoint && digitPosition - i + 1.0 == 0.0){
					if(maximumDigits - i > trailingZeros){
						DynamicArrayAddCharacter(&stringx, ".")
					}
					hasPrintedPoint = true
				}

				if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
				}else{
					success = GetSingleDigitCharacterFromNumberWithCheck(d, basex, &characterReference)
					if(success){
						c = characterReference.characterValue
						DynamicArrayAddCharacter(&stringx, c)
					}
				}
				i = i + 1.0
			}

			if(success){
				/* Print trailing zeros.*/
				i = 0.0
				while(i < digitPosition - maximumDigits + 1.0){
					DynamicArrayAddCharacter(&stringx, "0")
					i = i + 1.0
				}
			}
		}else{
			success = false
		}
	}

	if(success){
		stringRef.stringx = DynamicArrayCharactersToArray(&stringx)
		FreeDynamicArrayCharacters(&stringx)
	}

	/* Done*/
	return success
}


func GetMaximumDigitsForBase(_ basex : Double) -> Double{
	var basex = basex;
	var t : Double

	t = pow(10.0, 15.0)
	return floor(log10(t)/log10(basex))
}


func GetMaximumDigitsForDecimal() -> Double{
	return 15.0
}


func GetFirstDecimalDigitPosition(_ n : Double) -> Double{
	var n = n;
	var power, m, i : Double
	var multiply, done : Bool

	n = abs(n)

	if(n != 0.0){
		if(floor(n) < pow(10.0, 15.0)){
			multiply = true
		}else{
			multiply = false
		}

		done = false
		m = 0.0
		i = 0.0
		while(!done){
			if(multiply){
				m = n*pow(10.0, i)
				if(floor(m) >= pow(10.0, 14.0)){
					done = true
				}
			}else{
				m = n/pow(10.0, i)
				if(floor(m) < pow(10.0, 15.0)){
					done = true
				}
			}
			i = i + 1.0
		}

		if(multiply){
			power = 15.0 - i
		}else{
			power = 15.0 + i - 2.0
		}

		if(Roundx(m) >= pow(10.0, 15.0)){
			power = power + 1.0
		}
	}else{
		power = 1.0
	}

	return power
}


func GetFirstDigitPosition(_ n : Double, _ basex : Double) -> Double{
	var n = n;
	var basex = basex;
	var power, m, i, maximumDigits : Double
	var multiply, done : Bool

	maximumDigits = GetMaximumDigitsForBase(basex)
	n = abs(n)

	if(n != 0.0){
		if(floor(n) < pow(basex, maximumDigits)){
			multiply = true
		}else{
			multiply = false
		}

		done = false
		m = 0.0
		i = 0.0
		while(!done){
			if(multiply){
				m = n*pow(basex, i)
				if(floor(m) >= pow(basex, maximumDigits - 1.0)){
					done = true
				}
			}else{
				m = n/pow(basex, i)
				if(floor(m) < pow(basex, maximumDigits)){
					done = true
				}
			}
			i = i + 1.0
		}

		if(multiply){
			power = maximumDigits - i
		}else{
			power = maximumDigits + i - 2.0
		}

		if(Roundx(m) >= pow(basex, maximumDigits)){
			power = power + 1.0
		}
	}else{
		power = 1.0
	}

	return power
}


func GetSingleDigitCharacterFromNumberWithCheck(_ c : Double, _ basex : Double, _ characterReference : inout CharacterReference) -> Bool{
	var c = c;
	var basex = basex;
	var numberTable : [Character]
	var success : Bool

	numberTable = GetDigitCharacterTable()

	if(c < basex || c < Double(numberTable.count)){
		success = true
		characterReference.characterValue = numberTable[Int(c)]
	}else{
		success = false
	}

	return success
}


func GetDecimalDigitCharacterFromNumberWithCheck(_ c : Double, _ characterRef : inout CharacterReference) -> Bool{
	var c = c;
	var numberTable : [Character]
	var success : Bool

	numberTable = characterArray("0123456789").ca

	if(c >= 0.0 && c < 10.0){
		success = true
		characterRef.characterValue = numberTable[Int(c)]
	}else{
		success = false
	}

	return success
}


func GetDigitCharacterTable() -> [Character]{
	var numberTable : [Character]

	numberTable = characterArray("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ").ca

	return numberTable
}


func GetDecimalDigit(_ n : Double, _ index : Double) -> Double{
	var n = n;
	var index = index;
	var digitPosition : Double

	digitPosition = GetFirstDecimalDigitPosition(n)

	return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index)
}


func GetDecimalDigitWithFirstDigitPosition(_ n : Double, _ digitPosition : Double, _ index : Double) -> Double{
	var n = n;
	var digitPosition = digitPosition;
	var index = index;
	var d, e, m, i : Double

	n = abs(n)

	e = 15.0 - digitPosition - 1.0
	if(e < 0.0){
		n = round(n/pow(10.0, abs(e)))
	}else{
		n = round(n*pow(10.0, e))
	}

	m = n
	d = 0.0
	i = 0.0
	while(i < 15.0 - index){
		d = round(m.truncatingRemainder(dividingBy:10.0))
		m = m - d
		m = round(m/10.0)
		i = i + 1.0
	}

	return d
}


func GetDigit(_ n : Double, _ basex : Double, _ index : Double) -> Double{
	var n = n;
	var basex = basex;
	var index = index;
	var d, digitPosition, e, m, maximumDigits, i : Double

	n = abs(n)
	maximumDigits = GetMaximumDigitsForBase(basex)
	digitPosition = GetFirstDigitPosition(n, basex)

	e = maximumDigits - digitPosition - 1.0
	if(e < 0.0){
		n = round(n/pow(basex, abs(e)))
	}else{
		n = round(n*pow(basex, e))
	}

	m = n
	d = 0.0
	i = 0.0
	while(i < maximumDigits - index){
		d = round(m.truncatingRemainder(dividingBy:basex))
		m = m - d
		m = round(m/basex)
		i = i + 1.0
	}

	return d
}


func NumberToHumanReadableShortScale(_ n : Double) -> [Character]{
	var n = n;
	var res, suffix : [Character]
	var hasSuffix : Bool
	var k, M, B, T, Q : Double

	k = 1000.0
	M = k*1000.0
	B = M*1000.0
	T = B*1000.0
	Q = T*1000.0
	suffix = characterArray(" ").ca

	if(n < k){
		hasSuffix = false
	}else{
		hasSuffix = true
	}

	if(n >= k && n < M){
		if(n < 10.0*k){
			n = Roundx(n/100.0)
			n = n/10.0
		}else{
			n = Roundx(n/k)
		}
		suffix = characterArray("k").ca
	}else if(n >= M && n < B){
		if(n < 10.0*M){
			n = Roundx(n/(k*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/M)
		}
		suffix = characterArray("M").ca
	}else if(n >= B && n < T){
		if(n < 10.0*B){
			n = Roundx(n/(M*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/B)
		}
		suffix = characterArray("B").ca
	}else if(n >= T && n < Q){
		if(n < 10.0*T){
			n = Roundx(n/(B*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/T)
		}
		suffix = characterArray("T").ca
	}else if(n >= Q){
		if(n < 10.0*Q){
			n = Roundx(n/(T*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Q)
		}
		suffix = characterArray("Q").ca
	}

	res = CreateStringDecimalFromNumber(n)
	if(hasSuffix){
		res = strAppendString(&res, &suffix)
	}
        
	return res
}


func NumberToHumanReadableBinary(_ n : Double) -> [Character]{
	var n = n;
	var res, suffix : [Character]
	var hasSuffix : Bool
	var Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi : Double

	Ki = 1024.0
	Mi = Ki*1024.0
	Gi = Mi*1024.0
	Ti = Gi*1024.0
	Pi = Ti*1024.0
	Ei = Pi*1024.0
	Zi = Ei*1024.0
	Yi = Zi*1024.0
	suffix = characterArray(" ").ca

	if(n < Ki){
		hasSuffix = false
	}else{
		hasSuffix = true
	}

	if(n >= Ki && n < Mi){
		if(n < 10.0*Ki){
			n = Roundx(n/(Ki/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ki)
		}
		suffix = characterArray("Ki").ca
	}else if(n >= Mi && n < Gi){
		if(n < 10.0*Mi){
			n = Roundx(n/(Mi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Mi)
		}
		suffix = characterArray("Mi").ca
	}else if(n >= Gi && n < Ti){
		if(n < 10.0*Gi){
			n = Roundx(n/(Gi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Gi)
		}
		suffix = characterArray("Gi").ca
	}else if(n >= Ti && n < Pi){
		if(n < 10.0*Ti){
			n = Roundx(n/(Ti/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ti)
		}
		suffix = characterArray("Ti").ca
	}else if(n >= Pi && n < Ei){
		if(n < 10.0*Pi){
			n = Roundx(n/(Pi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Pi)
		}
		suffix = characterArray("Pi").ca
	}else if(n >= Ei && n < Zi){
		if(n < 10.0*Ei){
			n = Roundx(n/(Ei/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ei)
		}
		suffix = characterArray("Ei").ca
	}else if(n >= Zi && n < Yi){
		if(n < 10.0*Zi){
			n = Roundx(n/(Zi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Zi)
		}
		suffix = characterArray("Zi").ca
	}else if(n >= Yi){
		if(n < 10.0*Yi){
			n = Roundx(n/(Yi/10.0))
			n = n/10.0
		}else{
			n = Roundx(n/Yi)
		}
		suffix = characterArray("Yi").ca
	}

	res = CreateStringDecimalFromNumber(n)
	if(hasSuffix){
		res = strAppendString(&res, &suffix)
	}

	return res
}


func NumberToHumanReadableMetric(_ n : Double) -> [Character]{
	var n = n;
	var res, suffix : [Character]
	var hasSuffix : Bool
	var k, M, G, T, P, Ex, Z, Y, R, Q : Double

	k = 1000.0
	M = k*1000.0
	G = M*1000.0
	T = G*1000.0
	P = T*1000.0
	Ex = P*1000.0
	Z = Ex*1000.0
	Y = Z*1000.0
	R = Y*1000.0
	Q = R*1000.0
	suffix = characterArray(" ").ca

	if(n < k){
		hasSuffix = false
	}else{
		hasSuffix = true
	}

	if(n >= k && n < M){
		if(n < 10.0*k){
			n = Roundx(n/100.0)
			n = n/10.0
		}else{
			n = Roundx(n/k)
		}
		suffix = characterArray("k").ca
	}else if(n >= M && n < G){
		if(n < 10.0*M){
			n = Roundx(n/(k*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/M)
		}
		suffix = characterArray("M").ca
	}else if(n >= G && n < T){
		if(n < 10.0*G){
			n = Roundx(n/(M*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/G)
		}
		suffix = characterArray("G").ca
	}else if(n >= T && n < P){
		if(n < 10.0*T){
			n = Roundx(n/(G*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/T)
		}
		suffix = characterArray("T").ca
	}else if(n >= P && n < Ex){
		if(n < 10.0*P){
			n = Roundx(n/(T*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/P)
		}
		suffix = characterArray("P").ca
	}else if(n >= Ex && n < Z){
		if(n < 10.0*Ex){
			n = Roundx(n/(P*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Ex)
		}
		suffix = characterArray("E").ca
	}else if(n >= Z && n < Y){
		if(n < 10.0*Z){
			n = Roundx(n/(Ex*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Z)
		}
		suffix = characterArray("Z").ca
	}else if(n >= Y && n < R){
		if(n < 10.0*Y){
			n = Roundx(n/(Z*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Y)
		}
		suffix = characterArray("Y").ca
	}else if(n >= R && n < Q){
		if(n < 10.0*R){
			n = Roundx(n/(Y*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/R)
		}
		suffix = characterArray("R").ca
	}else if(n >= Q){
		if(n < 10.0*Q){
			n = Roundx(n/(R*100.0))
			n = n/10.0
		}else{
			n = Roundx(n/Q)
		}
		suffix = characterArray("Q").ca
	}

	res = CreateStringDecimalFromNumber(n)
	if(hasSuffix){
		res = strAppendString(&res, &suffix)
	}

	return res
}


func IsValidNumber(_ str : inout [Character]) -> Bool{
	var valid : Bool
	var numberRef : NumberReference
	var message : StringReference

	numberRef = NumberReference()
	message = StringReference()

	valid = CreateNumberFromDecimalStringWithCheck(&str, &numberRef, &message)

	delete(numberRef)
	delete(message)

	return valid
}


func IsValidInteger(_ str : inout [Character]) -> Bool{
	var valid : Bool
	var numberRef : NumberReference
	var message : StringReference

	numberRef = NumberReference()
	message = StringReference()

	valid = CreateNumberFromDecimalStringWithCheck(&str, &numberRef, &message)

	if(valid){
		valid = IsInteger(numberRef.numberValue)
	}

	delete(numberRef)
	delete(message)

	return valid
}


func IsValidPositiveInteger(_ str : inout [Character]) -> Bool{
	var valid : Bool
	var numberRef : NumberReference
	var message : StringReference

	numberRef = NumberReference()
	message = StringReference()

	valid = CreateNumberFromDecimalStringWithCheck(&str, &numberRef, &message)

	if(valid){
		valid = IsInteger(numberRef.numberValue)
		if(valid){
			valid = numberRef.numberValue >= 0.0
		}
	}

	delete(numberRef)
	delete(message)

	return valid
}


func CreateNumberFromDecimalStringWithCheck(_ stringx : inout [Character], _ decimalReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	return CreateNumberFromStringWithCheck(&stringx, 10.0, &decimalReference, &message)
}


func CreateNumberFromDecimalString(_ stringx : inout [Character]) -> Double{
	var doubleReference : NumberReference
	var stringReference : StringReference
	var number : Double

	doubleReference = CreateNumberReference(0.0).ref
	stringReference = CreateStringReference(&characterArray("").ca).ref
	CreateNumberFromStringWithCheck(&stringx, 10.0, &doubleReference, &stringReference)
	number = doubleReference.numberValue

	delete(doubleReference)
	delete(stringReference)

	return number
}


func CreateNumberFromStringWithCheck(_ stringx : inout [Character], _ basex : Double, _ numberReference : inout NumberReference, _ message : inout StringReference) -> Bool{
	var basex = basex;
	var success : Bool
	var numberIsPositive, exponentIsPositive : BooleanReference
	var beforePoint, afterPoint, exponent : NumberArrayReference

	numberIsPositive = CreateBooleanReference(true).ref
	exponentIsPositive = CreateBooleanReference(true).ref
	beforePoint = NumberArrayReference()
	afterPoint = NumberArrayReference()
	exponent = NumberArrayReference()

	if(basex >= 2.0 && basex <= 36.0){
		success = ExtractPartsFromNumberString(&stringx, basex, &numberIsPositive, &beforePoint, &afterPoint, &exponentIsPositive, &exponent, &message)

		if(success){
			numberReference.numberValue = CreateNumberFromParts(basex, numberIsPositive.booleanValue, &beforePoint.numberArray, &afterPoint.numberArray, exponentIsPositive.booleanValue, &exponent.numberArray)
		}
	}else{
		success = false
		message.stringx = characterArray("Base must be from 2 to 36.").ca
	}

	return success
}


func CreateNumberFromParts(_ basex : Double, _ numberIsPositive : Bool, _ beforePoint : inout [Double], _ afterPoint : inout [Double], _ exponentIsPositive : Bool, _ exponent : inout [Double]) -> Double{
	var basex = basex;
	var numberIsPositive = numberIsPositive;
	var exponentIsPositive = exponentIsPositive;
	var n, i, p, e : Double

	n = 0.0

	i = 0.0
	while(i < Double(beforePoint.count)){
		p = beforePoint[Int(Double(beforePoint.count) - i - 1.0)]

		n = n + p*pow(basex, i)
		i = i + 1.0
	}

	i = 0.0
	while(i < Double(afterPoint.count)){
		p = afterPoint[Int(i)]

		n = n + p/pow(basex, i + 1.0)
		i = i + 1.0
	}

	if(Double(exponent.count) > 0.0){
		e = 0.0
		i = 0.0
		while(i < Double(exponent.count)){
			p = exponent[Int(Double(exponent.count) - i - 1.0)]

			e = e + p*pow(basex, i)
			i = i + 1.0
		}

		if(!exponentIsPositive){
			e = -e
		}

		n = n*pow(basex, e)
	}

	if(!numberIsPositive){
		n = -n
	}

	return n
}


func ExtractPartsFromNumberString(_ n : inout [Character], _ basex : Double, _ numberIsPositive : inout BooleanReference, _ beforePoint : inout NumberArrayReference, _ afterPoint : inout NumberArrayReference, _ exponentIsPositive : inout BooleanReference, _ exponent : inout NumberArrayReference, _ errorMessages : inout StringReference) -> Bool{
	var basex = basex;
	var i, j, count : Double
	var success, done, complete : Bool

	i = 0.0
	complete = false

	if(i < Double(n.count)){
		if(n[Int(i)] == "-"){
			numberIsPositive.booleanValue = false
			i = i + 1.0
		}else if(n[Int(i)] == "+"){
			numberIsPositive.booleanValue = true
			i = i + 1.0
		}

		success = true
	}else{
		success = false
		errorMessages.stringx = characterArray("Number cannot have length zero.").ca
	}

	if(success){
		done = false
		count = 0.0
		while(i + count < Double(n.count) && !done){
			if(CharacterIsNumberCharacterInBase(n[Int(i + count)], basex)){
				count = count + 1.0
			}else{
				done = true
			}
		}

		if(count >= 1.0){
			beforePoint.numberArray = Array(repeating:Double(), count: Int(count))

			j = 0.0
			while(j < count){
				beforePoint.numberArray[Int(j)] = GetNumberFromNumberCharacterForBase(n[Int(i + j)], basex)
				j = j + 1.0
			}

			i = i + count

			if(i < Double(n.count)){
				success = true
			}else{
				afterPoint.numberArray = Array(repeating:Double(), count: Int(0))
				exponent.numberArray = Array(repeating:Double(), count: Int(0))
				success = true
				complete = true
			}
		}else{
			success = false
			errorMessages.stringx = characterArray("Number must have at least one number after the optional sign.").ca
		}
	}

	if(success && !complete){
		if(n[Int(i)] == "."){
			i = i + 1.0

			if(i < Double(n.count)){
				done = false
				count = 0.0
				while(i + count < Double(n.count) && !done){
					if(CharacterIsNumberCharacterInBase(n[Int(i + count)], basex)){
						count = count + 1.0
					}else{
						done = true
					}
				}

				if(count >= 1.0){
					afterPoint.numberArray = Array(repeating:Double(), count: Int(count))

					j = 0.0
					while(j < count){
						afterPoint.numberArray[Int(j)] = GetNumberFromNumberCharacterForBase(n[Int(i + j)], basex)
						j = j + 1.0
					}

					i = i + count

					if(i < Double(n.count)){
						success = true
					}else{
						exponent.numberArray = Array(repeating:Double(), count: Int(0))
						success = true
						complete = true
					}
				}else{
					success = false
					errorMessages.stringx = characterArray("There must be at least one digit after the decimal point.").ca
				}
			}else{
				success = false
				errorMessages.stringx = characterArray("There must be at least one digit after the decimal point.").ca
			}
		}else if(basex <= 14.0 && (n[Int(i)] == "e" || n[Int(i)] == "E")){
			if(i < Double(n.count)){
				success = true
				afterPoint.numberArray = Array(repeating:Double(), count: Int(0))
			}else{
				success = false
				errorMessages.stringx = characterArray("There must be at least one digit after the exponent.").ca
			}
		}else{
			success = false
			errorMessages.stringx = characterArray("Expected decimal point or exponent symbol.").ca
		}
	}

	if(success && !complete){
		if(basex <= 14.0 && (n[Int(i)] == "e" || n[Int(i)] == "E")){
			i = i + 1.0

			if(i < Double(n.count)){
				if(n[Int(i)] == "-"){
					exponentIsPositive.booleanValue = false
					i = i + 1.0
				}else if(n[Int(i)] == "+"){
					exponentIsPositive.booleanValue = true
					i = i + 1.0
				}

				if(i < Double(n.count)){
					done = false
					count = 0.0
					while(i + count < Double(n.count) && !done){
						if(CharacterIsNumberCharacterInBase(n[Int(i + count)], basex)){
							count = count + 1.0
						}else{
							done = true
						}
					}

					if(count >= 1.0){
						exponent.numberArray = Array(repeating:Double(), count: Int(count))

						j = 0.0
						while(j < count){
							exponent.numberArray[Int(j)] = GetNumberFromNumberCharacterForBase(n[Int(i + j)], basex)
							j = j + 1.0
						}

						i = i + count

						if(i == Double(n.count)){
							success = true
						}else{
							success = false
							errorMessages.stringx = characterArray("There cannot be any characters past the exponent of the number.").ca
						}
					}else{
						success = false
						errorMessages.stringx = characterArray("There must be at least one digit after the decimal point.").ca
					}
				}else{
					success = false
					errorMessages.stringx = characterArray("There must be at least one digit after the exponent symbol.").ca
				}
			}else{
				success = false
				errorMessages.stringx = characterArray("There must be at least one digit after the exponent symbol.").ca
			}
		}else{
			success = false
			errorMessages.stringx = characterArray("Expected exponent symbol.").ca
		}
	}

	return success
}


func GetNumberFromNumberCharacterForBase(_ c : Character, _ basex : Double) -> Double{
	var c = c;
	var basex = basex;
	var numberTable : [Character]
	var i : Double
	var position : Double

	numberTable = GetDigitCharacterTable()
	position = 0.0

	i = 0.0
	while(i < basex){
		if(numberTable[Int(i)] == c){
			position = i
		}
		i = i + 1.0
	}

	return position
}


func CharacterIsNumberCharacterInBase(_ c : Character, _ basex : Double) -> Bool{
	var c = c;
	var basex = basex;
	var numberTable : [Character]
	var i : Double
	var found : Bool

	numberTable = GetDigitCharacterTable()
	found = false

	i = 0.0
	while(i < basex){
		if(numberTable[Int(i)] == c){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func StringToNumberArray(_ str : inout [Character]) -> [Double]{
	var numberArrayReference : NumberArrayReference
	var stringReference : StringReference
	var numbers : [Double]

	numberArrayReference = NumberArrayReference()
	stringReference = StringReference()

	StringToNumberArrayWithCheck(&str, &numberArrayReference, &stringReference)

	numbers = numberArrayReference.numberArray

	delete(numberArrayReference)
	delete(stringReference)

	return numbers
}


func StringToNumberArrayWithCheck(_ str : inout [Character], _ numberArrayReference : inout NumberArrayReference, _ errorMessage : inout StringReference) -> Bool{
	var numberStrings : [StringReference]
	var numbers : [Double]
	var i : Double
	var numberString, trimmedNumberString : [Character]
	var success : Bool
	var numberReference : NumberReference

	numberStrings = strSplitByString(&str, &characterArray(",").ca)

	numbers = Array(repeating:Double(), count: Int(Double(numberStrings.count)))
	success = true
	numberReference = NumberReference()

	i = 0.0
	while(i < Double(numberStrings.count)){
		numberString = numberStrings[Int(i)].stringx
		trimmedNumberString = strTrim(&numberString)
		success = CreateNumberFromDecimalStringWithCheck(&trimmedNumberString, &numberReference, &errorMessage)
		numbers[Int(i)] = numberReference.numberValue

		FreeStringReference(&numberStrings[Int(i)])
		delete(trimmedNumberString)
		i = i + 1.0
	}

	delete(numberStrings)
	delete(numberReference)

	numberArrayReference.numberArray = numbers

	return success
}


func strWriteStringToStingStream(_ stream : inout [Character], _ index : inout NumberReference, _ src : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(src.count)){
		stream[Int(index.numberValue + i)] = src[Int(i)]
		i = i + 1.0
	}
	index.numberValue = index.numberValue + Double(src.count)
}


func strWriteCharacterToStingStream(_ stream : inout [Character], _ index : inout NumberReference, _ src : Character) -> Void{
	var src = src;
	stream[Int(index.numberValue)] = src
	index.numberValue = index.numberValue + 1.0
}


func strWriteBooleanToStingStream(_ stream : inout [Character], _ index : inout NumberReference, _ src : Bool) -> Void{
	var src = src;
	if(src){
		strWriteStringToStingStream(&stream, &index, &characterArray("true").ca)
	}else{
		strWriteStringToStingStream(&stream, &index, &characterArray("false").ca)
	}
}


func strSubstringWithCheck(_ stringx : inout [Character], _ from : Double, _ to : Double, _ stringReference : inout StringReference) -> Bool{
	var from = from;
	var to = to;
	var success : Bool

	if(from >= 0.0 && from <= Double(stringx.count) && to >= 0.0 && to <= Double(stringx.count) && from <= to){
		stringReference.stringx = strSubstring(&stringx, from, to)
		success = true
	}else{
		success = false
	}

	return success
}


func strSubstring(_ stringx : inout [Character], _ from : Double, _ to : Double) -> [Character]{
	var from = from;
	var to = to;
	var n : [Character]
	var i, length : Double

	length = to - from

	n = Array(repeating:Character(" "), count: Int(length))

	i = from
	while(i < to){
		n[Int(i - from)] = stringx[Int(i)]
		i = i + 1.0
	}

	return n
}


func strAppendString(_ s1 : inout [Character], _ s2 : inout [Character]) -> [Character]{
	var newString : [Character]

	newString = strConcatenateString(&s1, &s2)

	delete(s1)

	return newString
}


func strConcatenateString(_ s1 : inout [Character], _ s2 : inout [Character]) -> [Character]{
	var newString : [Character]
	var i : Double

	newString = Array(repeating:Character(" "), count: Int(Double(s1.count) + Double(s2.count)))

	i = 0.0
	while(i < Double(s1.count)){
		newString[Int(i)] = s1[Int(i)]
		i = i + 1.0
	}

	i = 0.0
	while(i < Double(s2.count)){
		newString[Int(Double(s1.count) + i)] = s2[Int(i)]
		i = i + 1.0
	}

	return newString
}


func strAppendCharacter(_ stringx : inout [Character], _ c : Character) -> [Character]{
	var c = c;
	var newString : [Character]

	newString = strConcatenateCharacter(&stringx, c)

	delete(stringx)

	return newString
}


func strConcatenateCharacter(_ stringx : inout [Character], _ c : Character) -> [Character]{
	var c = c;
	var newString : [Character]
	var i : Double
	newString = Array(repeating:Character(" "), count: Int(Double(stringx.count) + 1.0))

	i = 0.0
	while(i < Double(stringx.count)){
		newString[Int(i)] = stringx[Int(i)]
		i = i + 1.0
	}

	newString[Int(Double(stringx.count))] = c

	return newString
}


func strSplitByCharacter(_ toSplit : inout [Character], _ splitBy : Character) -> [StringReference]{
	var splitBy = splitBy;
	var parts : [StringReference]
	var i : Double
	var c : Character
	var ll : LinkedListStrings
	var next : LinkedListCharacters
	var part : [Character]

	ll = CreateLinkedListString().ref

	next = CreateLinkedListCharacter().ref
	i = 0.0
	while(i < Double(toSplit.count)){
		c = toSplit[Int(i)]

		if(c == splitBy){
			part = LinkedListCharactersToArray(&next)
			LinkedListAddString(&ll, &part)
			FreeLinkedListCharacter(&next)
			next = CreateLinkedListCharacter().ref
		}else{
			LinkedListAddCharacter(&next, c)
		}
		i = i + 1.0
	}

	part = LinkedListCharactersToArray(&next)
	LinkedListAddString(&ll, &part)
	FreeLinkedListCharacter(&next)

	parts = LinkedListStringsToArray(&ll)
	FreeLinkedListString(&ll)

	return parts
}


func strIndexOfCharacter(_ stringx : inout [Character], _ character : Character, _ indexReference : inout NumberReference) -> Bool{
	var character = character;
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count) && !found){
		if(stringx[Int(i)] == character){
			found = true
			indexReference.numberValue = i
		}
		i = i + 1.0
	}

	return found
}


func strLastIndexOfCharacter(_ stringx : inout [Character], _ character : Character, _ indexReference : inout NumberReference) -> Bool{
	var character = character;
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count)){
		if(stringx[Int(i)] == character){
			found = true
			indexReference.numberValue = i
		}
		i = i + 1.0
	}

	return found
}


func strSubstringEqualsWithCheck(_ stringx : inout [Character], _ from : Double, _ substring : inout [Character], _ equalsReference : inout BooleanReference) -> Bool{
	var from = from;
	var success : Bool

	if(from < Double(stringx.count)){
		success = true
		equalsReference.booleanValue = strSubstringEquals(&stringx, from, &substring)
	}else{
		success = false
	}

	return success
}


func strSubstringEquals(_ stringx : inout [Character], _ from : Double, _ substring : inout [Character]) -> Bool{
	var from = from;
	var i : Double
	var equal : Bool

	equal = true
	if(Double(stringx.count) - from >= Double(substring.count)){
		i = 0.0
		while(i < Double(substring.count) && equal){
			if(stringx[Int(from + i)] != substring[Int(i)]){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func strIndexOfString(_ stringx : inout [Character], _ substring : inout [Character], _ indexReference : inout NumberReference) -> Bool{
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count) - Double(substring.count) + 1.0 && !found){
		if(strSubstringEquals(&stringx, i, &substring)){
			found = true
			indexReference.numberValue = i
		}
		i = i + 1.0
	}

	return found
}


func strContainsCharacter(_ stringx : inout [Character], _ character : Character) -> Bool{
	var character = character;
	var i : Double
	var found : Bool

	found = false
	i = 0.0
	while(i < Double(stringx.count) && !found){
		if(stringx[Int(i)] == character){
			found = true
		}
		i = i + 1.0
	}

	return found
}


func strContainsString(_ stringx : inout [Character], _ substring : inout [Character]) -> Bool{
	return strIndexOfString(&stringx, &substring, &NumberReferenceCreateFunction().ref)
}


func strToUpperCase(_ stringx : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(stringx.count)){
		stringx[Int(i)] = cToUpperCase(stringx[Int(i)])
		i = i + 1.0
	}
}


func strToLowerCase(_ stringx : inout [Character]) -> Void{
	var i : Double

	i = 0.0
	while(i < Double(stringx.count)){
		stringx[Int(i)] = cToLowerCase(stringx[Int(i)])
		i = i + 1.0
	}
}


func strEqualsIgnoreCase(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var equal : Bool
	var i : Double

	if(Double(a.count) == Double(b.count)){
		equal = true
		i = 0.0
		while(i < Double(a.count) && equal){
			if(cToLowerCase(a[Int(i)]) != cToLowerCase(b[Int(i)])){
				equal = false
			}
			i = i + 1.0
		}
	}else{
		equal = false
	}

	return equal
}


func strReplaceString(_ stringx : inout [Character], _ toReplace : inout [Character], _ replaceWith : inout [Character]) -> [Character]{
	var result : [Character]
	var i, j : Double
	var equalsReference : BooleanReference
	var success : Bool
	var da : DynamicArrayCharacters

	da = CreateDynamicArrayCharacters().ref

	equalsReference = BooleanReference()

	i = 0.0
	while(i < Double(stringx.count)){
		success = strSubstringEqualsWithCheck(&stringx, i, &toReplace, &equalsReference)
		if(success){
			success = equalsReference.booleanValue
		}

		if(success && Double(toReplace.count) > 0.0){
			j = 0.0
			while(j < Double(replaceWith.count)){
				DynamicArrayAddCharacter(&da, replaceWith[Int(j)])
				j = j + 1.0
			}
			i = i + Double(toReplace.count)
		}else{
			DynamicArrayAddCharacter(&da, stringx[Int(i)])
			i = i + 1.0
		}
	}

	result = DynamicArrayCharactersToArray(&da)

	FreeDynamicArrayCharacters(&da)

	return result
}


func strReplaceCharacterToNew(_ stringx : inout [Character], _ toReplace : Character, _ replaceWith : Character) -> [Character]{
	var toReplace = toReplace;
	var replaceWith = replaceWith;
	var result : [Character]
	var i : Double

	result = Array(repeating:Character(" "), count: Int(Double(stringx.count)))

	i = 0.0
	while(i < Double(stringx.count)){
		if(stringx[Int(i)] == toReplace){
			result[Int(i)] = replaceWith
		}else{
			result[Int(i)] = stringx[Int(i)]
		}
		i = i + 1.0
	}

	return result
}


func strReplaceCharacter(_ stringx : inout [Character], _ toReplace : Character, _ replaceWith : Character) -> Void{
	var toReplace = toReplace;
	var replaceWith = replaceWith;
	var i : Double

	i = 0.0
	while(i < Double(stringx.count)){
		if(stringx[Int(i)] == toReplace){
			stringx[Int(i)] = replaceWith
		}
		i = i + 1.0
	}
}


func strTrim(_ stringx : inout [Character]) -> [Character]{
	var result : [Character]
	var i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd : Double
	var firstNonWhitespaceFound : Bool

	/* Find whitepaces at the start.*/
	lastWhitespaceLocationStart = -1.0
	firstNonWhitespaceFound = false
	i = 0.0
	while(i < Double(stringx.count) && !firstNonWhitespaceFound){
		if(cIsWhiteSpace(stringx[Int(i)])){
			lastWhitespaceLocationStart = i
		}else{
			firstNonWhitespaceFound = true
		}
		i = i + 1.0
	}

	/* Find whitepaces at the end.*/
	lastWhitespaceLocationEnd = Double(stringx.count)
	firstNonWhitespaceFound = false
	i = Double(stringx.count) - 1.0
	while(i >= 0.0 && !firstNonWhitespaceFound){
		if(cIsWhiteSpace(stringx[Int(i)])){
			lastWhitespaceLocationEnd = i
		}else{
			firstNonWhitespaceFound = true
		}
		i = i - 1.0
	}

	if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
		result = strSubstring(&stringx, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd)
	}else{
		result = Array(repeating:Character(" "), count: Int(0))
	}

	return result
}


func strStartsWith(_ stringx : inout [Character], _ start : inout [Character]) -> Bool{
	var startsWithString : Bool

	startsWithString = false
	if(Double(stringx.count) >= Double(start.count)){
		startsWithString = strSubstringEquals(&stringx, 0.0, &start)
	}

	return startsWithString
}


func strEndsWith(_ stringx : inout [Character], _ end : inout [Character]) -> Bool{
	var endsWithString : Bool

	endsWithString = false
	if(Double(stringx.count) >= Double(end.count)){
		endsWithString = strSubstringEquals(&stringx, Double(stringx.count) - Double(end.count), &end)
	}

	return endsWithString
}


func strSplitByString(_ toSplit : inout [Character], _ splitBy : inout [Character]) -> [StringReference]{
	var parts : [StringReference]
	var i : Double
	var c : Character
	var ll : LinkedListStrings
	var next : LinkedListCharacters
	var part : [Character]

	ll = CreateLinkedListString().ref

	next = CreateLinkedListCharacter().ref
	i = 0.0
	while(i < Double(toSplit.count)){
		c = toSplit[Int(i)]

		if(strSubstringEquals(&toSplit, i, &splitBy)){
			part = LinkedListCharactersToArray(&next)
			LinkedListAddString(&ll, &part)
			FreeLinkedListCharacter(&next)
			next = CreateLinkedListCharacter().ref
			i = i + Double(splitBy.count)
		}else{
			LinkedListAddCharacter(&next, c)
			i = i + 1.0
		}
	}

	part = LinkedListCharactersToArray(&next)
	LinkedListAddString(&ll, &part)
	FreeLinkedListCharacter(&next)

	parts = LinkedListStringsToArray(&ll)
	FreeLinkedListString(&ll)

	return parts
}


func strStringIsBefore(_ a : inout [Character], _ b : inout [Character]) -> Bool{
	var before, equal, done : Bool
	var i : Double

	before = false
	equal = true
	done = false

	if(Double(a.count) == 0.0 && Double(b.count) > 0.0){
		before = true
	}else{
		i = 0.0
		while(i < Double(a.count) && i < Double(b.count) && !done){
			if(a[Int(i)] != b[Int(i)]){
				equal = false
			}
			if(cCharacterIsBefore(a[Int(i)], b[Int(i)])){
				before = true
			}
			if(cCharacterIsBefore(b[Int(i)], a[Int(i)])){
				done = true
			}
			i = i + 1.0
		}

		if(equal){
			if(Double(a.count) < Double(b.count)){
				before = true
			}
		}
	}

	return before
}


func strJoinStringsWithSeparator(_ strings : inout [StringReference], _ separator : inout [Character]) -> [Character]{
	var result, stringx : [Character]
	var length, i : Double
	var index : NumberReference

	index = CreateNumberReference(0.0).ref

	length = 0.0
	i = 0.0
	while(i < Double(strings.count)){
		length = length + Double(strings[Int(i)].stringx.count)
		i = i + 1.0
	}
	length = length + (Double(strings.count) - 1.0)*Double(separator.count)

	result = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < Double(strings.count)){
		stringx = strings[Int(i)].stringx
		strWriteStringToStingStream(&result, &index, &stringx)
		if(i + 1.0 < Double(strings.count)){
			strWriteStringToStingStream(&result, &index, &separator)
		}
		i = i + 1.0
	}

	delete(index)

	return result
}


func strJoinStrings(_ strings : inout [StringReference]) -> [Character]{
	var result, stringx : [Character]
	var length, i : Double
	var index : NumberReference

	index = CreateNumberReference(0.0).ref

	length = 0.0
	i = 0.0
	while(i < Double(strings.count)){
		length = length + Double(strings[Int(i)].stringx.count)
		i = i + 1.0
	}

	result = Array(repeating:Character(" "), count: Int(length))

	i = 0.0
	while(i < Double(strings.count)){
		stringx = strings[Int(i)].stringx
		strWriteStringToStingStream(&result, &index, &stringx)
		i = i + 1.0
	}

	delete(index)

	return result
}


func strStringOrder(_ a : inout [Character], _ b : inout [Character]) -> Double{
	var order, minimum, i, ac, bc : Double
	var done : Bool

	minimum = min(Double(a.count), Double(b.count))

	done = false
	order = 0.0
	i = 0.0
	while(i < minimum && !done){
		ac = charToDouble(a[Int(i)])
		bc = charToDouble(b[Int(i)])

		if(ac < bc){
			done = true
			order = 1.0
		}else if(ac > bc){
			done = true
			order = -1.0
		}
		i = i + 1.0
	}

	if(!done){
		if(Double(a.count) < Double(b.count)){
			order = 1.0
		}else if(Double(a.count) > Double(b.count)){
			order = -1.0
		}
	}

	return order
}


func strLeftPad(_ str : inout [Character], _ width : Double) -> [Character]{
	var width = width;
	var i : Double
	var padded : [Character]

	padded = Array(repeating:Character(" "), count: Int(width))
	arraysFillString(&padded, " ")

	i = 0.0
	while(i < Double(str.count)){
		padded[Int(width - Double(str.count) + i)] = str[Int(i)]
		i = i + 1.0
	}

	return padded
}


func strRightPad(_ str : inout [Character], _ width : Double) -> [Character]{
	var width = width;
	var i : Double
	var padded : [Character]

	padded = Array(repeating:Character(" "), count: Int(width))
	arraysFillString(&padded, " ")

	i = 0.0
	while(i < Double(str.count)){
		padded[Int(i)] = str[Int(i)]
		i = i + 1.0
	}

	return padded
}


func AssertFalse(_ b : Bool, _ failures : inout NumberReference) -> Void{
	var b = b;
	if(b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertTrue(_ b : Bool, _ failures : inout NumberReference) -> Void{
	var b = b;
	if(!b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertEquals(_ a : Double, _ b : Double, _ failures : inout NumberReference) -> Void{
	var a = a;
	var b = b;
	if(a != b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertBooleansEqual(_ a : Bool, _ b : Bool, _ failures : inout NumberReference) -> Void{
	var a = a;
	var b = b;
	if(a != b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertCharactersEqual(_ a : Character, _ b : Character, _ failures : inout NumberReference) -> Void{
	var a = a;
	var b = b;
	if(a != b){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertStringEquals(_ a : inout [Character], _ b : inout [Character], _ failures : inout NumberReference) -> Void{
	if(!arraysStringsEqual(&a, &b)){
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertNumberArraysEqual(_ a : inout [Double], _ b : inout [Double], _ failures : inout NumberReference) -> Void{
	var i : Double

	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count)){
			AssertEquals(a[Int(i)], b[Int(i)], &failures)
			i = i + 1.0
		}
	}else{
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertBooleanArraysEqual(_ a : inout [Bool], _ b : inout [Bool], _ failures : inout NumberReference) -> Void{
	var i : Double

	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count)){
			AssertBooleansEqual(a[Int(i)], b[Int(i)], &failures)
			i = i + 1.0
		}
	}else{
		failures.numberValue = failures.numberValue + 1.0
	}
}


func AssertStringArraysEqual(_ a : inout [StringReference], _ b : inout [StringReference], _ failures : inout NumberReference) -> Void{
	var i : Double

	if(Double(a.count) == Double(b.count)){
		i = 0.0
		while(i < Double(a.count)){
			AssertStringEquals(&a[Int(i)].stringx, &b[Int(i)].stringx, &failures)
			i = i + 1.0
		}
	}else{
		failures.numberValue = failures.numberValue + 1.0
	}
}


func Negate(_ x : Double) -> Double{
	var x = x;
	return -x
}


func Positive(_ x : Double) -> Double{
	var x = x;
	return +x
}


func Factorial(_ x : Double) -> Double{
	var x = x;
	var i, f : Double

	f = 1.0

	i = 2.0
	while(i <= x){
		f = f*i
		i = i + 1.0
	}

	return f
}


func Roundx(_ x : Double) -> Double{
	var x = x;
	return floor(x + 0.5)
}


func RoundToDigits(_ element : Double, _ digitsAfterPoint : Double) -> Double{
	var element = element;
	var digitsAfterPoint = digitsAfterPoint;
	return Roundx(element*pow(10.0, digitsAfterPoint))/pow(10.0, digitsAfterPoint)
}


func BankersRound(_ x : Double) -> Double{
	var x = x;
	var r : Double

	if(Absolute(x - Truncate(x)) == 0.5){
		if(!DivisibleBy(Roundx(x), 2.0)){
			r = Roundx(x) - 1.0
		}else{
			r = Roundx(x)
		}
	}else{
		r = Roundx(x)
	}

	return r
}


func Ceil(_ x : Double) -> Double{
	var x = x;
	return ceil(x)
}


func Floorx(_ x : Double) -> Double{
	var x = x;
	return floor(x)
}


func Truncate(_ x : Double) -> Double{
	var x = x;
	var t : Double

	if(x >= 0.0){
		t = floor(x)
	}else{
		t = ceil(x)
	}

	return t
}


func Absolute(_ x : Double) -> Double{
	var x = x;
	return abs(x)
}


func Logarithm(_ x : Double) -> Double{
	var x = x;
	return log10(x)
}


func NaturalLogarithm(_ x : Double) -> Double{
	var x = x;
	return log(x)
}


func Sinx(_ x : Double) -> Double{
	var x = x;
	return sin(x)
}


func Cosx(_ x : Double) -> Double{
	var x = x;
	return cos(x)
}


func Tanx(_ x : Double) -> Double{
	var x = x;
	return tan(x)
}


func Asinx(_ x : Double) -> Double{
	var x = x;
	return asin(x)
}


func Acosx(_ x : Double) -> Double{
	var x = x;
	return acos(x)
}


func Atanx(_ x : Double) -> Double{
	var x = x;
	return atan(x)
}


func Atan2(_ y : Double, _ x : Double) -> Double{
	var y = y;
	var x = x;
	var a : Double

	/* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.*/
	a = 0.0

	if(x > 0.0){
		a = Atanx(y/x)
	}else if(x < 0.0 && y >= 0.0){
		a = Atanx(y/x) + Double.pi
	}else if(x < 0.0 && y < 0.0){
		a = Atanx(y/x) - Double.pi
	}else if(x == 0.0 && y > 0.0){
		a = Double.pi/2.0
	}else if(x == 0.0 && y < 0.0){
		a = -Double.pi/2.0
	}

	return a
}


func Squareroot(_ x : Double) -> Double{
	var x = x;
	return sqrt(x)
}


func Expx(_ x : Double) -> Double{
	var x = x;
	return exp(x)
}


func DivisibleBy(_ a : Double, _ b : Double) -> Bool{
	var a = a;
	var b = b;
	return ((a.truncatingRemainder(dividingBy:b)) == 0.0)
}


func Combinations(_ n : Double, _ k : Double) -> Double{
	var n = n;
	var k = k;
	var i, j, c : Double

	c = 1.0
	j = 1.0
	i = n - k + 1.0

	while(i <= n){
		c = c*i
		c = c/j

		i = i + 1.0
		j = j + 1.0
	}

	return c
}


func Permutations(_ n : Double, _ k : Double) -> Double{
	var n = n;
	var k = k;
	var i, c : Double

	c = 1.0

	i = n - k + 1.0
	while(i <= n){
		c = c*i
		i = i + 1.0
	}

	return c
}


func EpsilonCompare(_ a : Double, _ b : Double, _ epsilon : Double) -> Bool{
	var a = a;
	var b = b;
	var epsilon = epsilon;
	return abs(a - b) < epsilon
}


func GreatestCommonDivisor(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var t : Double

	while(b != 0.0){
		t = b
		b = a.truncatingRemainder(dividingBy:b)
		a = t
	}

	return a
}


func GCDWithSubtraction(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var g : Double

	if(a == 0.0){
		g = b
	}else{
		while(b != 0.0){
			if(a > b){
				a = a - b
			}else{
				b = b - a
			}
		}

		g = a
	}

	return g
}


func IsInteger(_ a : Double) -> Bool{
	var a = a;
	return (a - floor(a)) == 0.0
}


func GreatestCommonDivisorWithCheck(_ a : Double, _ b : Double, _ gcdReference : inout NumberReference) -> Bool{
	var a = a;
	var b = b;
	var success : Bool
	var gcd : Double

	if(IsInteger(a) && IsInteger(b)){
		gcd = GreatestCommonDivisor(a, b)
		gcdReference.numberValue = gcd
		success = true
	}else{
		success = false
	}

	return success
}


func LeastCommonMultiple(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	var lcm : Double

	if(a > 0.0 && b > 0.0){
		lcm = abs(a*b)/GreatestCommonDivisor(a, b)
	}else{
		lcm = 0.0
	}

	return lcm
}


func Sign(_ a : Double) -> Double{
	var a = a;
	var s : Double

	if(a > 0.0){
		s = 1.0
	}else if(a < 0.0){
		s = -1.0
	}else{
		s = 0.0
	}

	return s
}


func Max(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return max(a, b)
}


func Min(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return min(a, b)
}


func Power(_ a : Double, _ b : Double) -> Double{
	var a = a;
	var b = b;
	return pow(a, b)
}


func Gamma(_ x : Double) -> Double{
	var x = x;
	return LanczosApproximation(x)
}


func LogGamma(_ x : Double) -> Double{
	var x = x;
	return log(Gamma(x))
}


func LanczosApproximation(_ z : Double) -> Double{
	var z = z;
	var p : [Double]
	var i, y, t, x : Double

	p = Array(repeating:Double(), count: Int(8))
	p[Int(0)] = 676.5203681218851
	p[Int(1)] = -1259.1392167224028
	p[Int(2)] = 771.32342877765313
	p[Int(3)] = -176.61502916214059
	p[Int(4)] = 12.507343278686905
	p[Int(5)] = -0.13857109526572012
	p[Int(6)] = 9.9843695780195716e-6
	p[Int(7)] = 1.5056327351493116e-7

	if(z < 0.5){
		y = Double.pi/(sin(Double.pi*z)*LanczosApproximation(1.0 - z))
	}else{
		z = z - 1.0
		x = 0.99999999999980993
		i = 0.0
		while(i < Double(p.count)){
			x = x + p[Int(i)]/(z + i + 1.0)
			i = i + 1.0
		}
		t = z + Double(p.count) - 0.5
		y = sqrt(2.0*Double.pi)*pow(t, z + 0.5)*exp(-t)*x
	}

	return y
}


func Beta(_ x : Double, _ y : Double) -> Double{
	var x = x;
	var y = y;
	return Gamma(x)*Gamma(y)/Gamma(x + y)
}


func Sinh(_ x : Double) -> Double{
	var x = x;
	return (exp(x) - exp(-x))/2.0
}


func Cosh(_ x : Double) -> Double{
	var x = x;
	return (exp(x) + exp(-x))/2.0
}


func Tanh(_ x : Double) -> Double{
	var x = x;
	return Sinh(x)/Cosh(x)
}


func Cot(_ x : Double) -> Double{
	var x = x;
	return 1.0/tan(x)
}


func Sec(_ x : Double) -> Double{
	var x = x;
	return 1.0/cos(x)
}


func Csc(_ x : Double) -> Double{
	var x = x;
	return 1.0/sin(x)
}


func Coth(_ x : Double) -> Double{
	var x = x;
	return Cosh(x)/Sinh(x)
}


func Sech(_ x : Double) -> Double{
	var x = x;
	return 1.0/Cosh(x)
}


func Csch(_ x : Double) -> Double{
	var x = x;
	return 1.0/Sinh(x)
}


func Error(_ x : Double) -> Double{
	var x = x;
	var y, t, tau, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 : Double

	if(x == 0.0){
		y = 0.0
	}else if(x < 0.0){
		y = -Error(-x)
	}else{
		c1 = -1.26551223
		c2 = +1.00002368
		c3 = +0.37409196
		c4 = +0.09678418
		c5 = -0.18628806
		c6 = +0.27886807
		c7 = -1.13520398
		c8 = +1.48851587
		c9 = -0.82215223
		c10 = +0.17087277

		t = 1.0/(1.0 + 0.5*abs(x))

		tau = t*exp(-pow(x, 2.0) + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))))

		y = 1.0 - tau
	}

	return y
}


func ErrorInverse(_ x : Double) -> Double{
	var x = x;
	var y, a, t : Double

	a = (8.0*(Double.pi - 3.0))/(3.0*Double.pi*(4.0 - Double.pi))

	t = 2.0/(Double.pi*a) + log(1.0 - pow(x, 2.0))/2.0
	y = Sign(x)*sqrt(sqrt(pow(t, 2.0) - log(1.0 - pow(x, 2.0))/a) - t)

	return y
}


func FallingFactorial(_ x : Double, _ n : Double) -> Double{
	var x = x;
	var n = n;
	var k, y : Double

	y = 1.0

	k = 0.0
	while(k <= n - 1.0){
		y = y*(x - k)
		k = k + 1.0
	}

	return y
}


func RisingFactorial(_ x : Double, _ n : Double) -> Double{
	var x = x;
	var n = n;
	var k, y : Double

	y = 1.0

	k = 0.0
	while(k <= n - 1.0){
		y = y*(x + k)
		k = k + 1.0
	}

	return y
}


func Hypergeometric(_ a : Double, _ b : Double, _ c : Double, _ z : Double, _ maxIterations : Double, _ precision : Double) -> Double{
	var a = a;
	var b = b;
	var c = c;
	var z = z;
	var maxIterations = maxIterations;
	var precision = precision;
	var y : Double

	if(abs(z) >= 0.5){
		y = pow(1.0 - z, -a)*HypergeometricDirect(a, c - b, c, z/(z - 1.0), maxIterations, precision)
	}else{
		y = HypergeometricDirect(a, b, c, z, maxIterations, precision)
	}

	return y
}


func HypergeometricDirect(_ a : Double, _ b : Double, _ c : Double, _ z : Double, _ maxIterations : Double, _ precision : Double) -> Double{
	var a = a;
	var b = b;
	var c = c;
	var z = z;
	var maxIterations = maxIterations;
	var precision = precision;
	var y, yp, n : Double
	var done : Bool

	y = 0.0
	done = false

	n = 0.0
	while(n < maxIterations && !done){
		yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*pow(z, n)/Factorial(n)
		if(abs(yp) < precision){
			done = true
		}
		y = y + yp
		n = n + 1.0
	}

	return y
}


func BernouilliNumber(_ n : Double) -> Double{
	var n = n;
	return AkiyamaTanigawaAlgorithm(n)
}


func AkiyamaTanigawaAlgorithm(_ n : Double) -> Double{
	var n = n;
	var m, j, B : Double
	var A : [Double]

	A = Array(repeating:Double(), count: Int(n + 1.0))

	m = 0.0
	while(m <= n){
		A[Int(m)] = 1.0/(m + 1.0)
		j = m
		while(j >= 1.0){
			A[Int(j - 1.0)] = j*(A[Int(j - 1.0)] - A[Int(j)])
			j = j - 1.0
		}
		m = m + 1.0
	}

	B = A[Int(0)]

	delete(A)

	return B
}


func D15Add(_ a : Double, _ b : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	x = a + b

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func RoundTo15Digits(_ x : Double) -> Double{
	var x = x;
	var p : Double

	p = floor(log10(x))
	x = x*pow(10.0, 15.0 - p)
	x = Roundx(x)
	x = x/pow(10.0, 15.0 - p)

	return x
}


func D15MaxValue() -> Double{
	return +9.99999999999999e99
}


func D15MinValue() -> Double{
	return -9.99999999999999e99
}


func D15Multiply(_ a : Double, _ b : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	x = a*b

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Divide(_ a : Double, _ b : Double, _ reminder : inout NumberReference, _ overflow : inout BooleanReference, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x, r : Double

	if(b != 0.0){
		invalidOperation.booleanValue = false

		x = a/b
		r = a.truncatingRemainder(dividingBy:b)

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true
			x = 0.0
			r = 0.0
		}else{
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
			r = RoundTo15Digits(r)
		}
	}else{
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
		r = 0.0
	}

	reminder.numberValue = r

	return x
}


func D15Exponentiation(_ a : Double, _ b : Double, _ overflow : inout BooleanReference, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	if(a == 0.0 && b == 0.0){
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
	}else if(a < 0.0 && !IsInteger(b)){
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
	}else{
		invalidOperation.booleanValue = false

		x = pow(a, b)

		if(x > D15MaxValue() || x < D15MinValue()){
			overflow.booleanValue = true
			x = 0.0
		}else{
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		}
	}

	return x
}


func D15Modulus(_ a : Double, _ b : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var b = b;
	var x : Double

	if(a < 0.0 || b == 0.0 || b < 0.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = a.truncatingRemainder(dividingBy:b)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Logarithm(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a <= 0.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = log10(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15NaturalLogarithm(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a <= 0.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = log(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Sin(_ a : Double) -> Double{
	var a = a;
	var x : Double

	x = sin(a)
	x = RoundTo15Digits(x)

	return x
}


func D15Cos(_ x : Double) -> Double{
	var x = x;
	var a, y, piBy2Part1, piBy2Part2, limit, f : Double

	x = abs(x)

	limit = Double.pi + 3.1/2.0

	if(x > limit){
		f = floor(x/Double.pi)
		x = x - Double.pi*f
	}

	piBy2Part1 = +1.57079632679490
	piBy2Part2 = -3.38076867830836e-15

	if(x > 3.1/2.0 && x < 3.3/2.0){
		a = x - piBy2Part1
		a = round(a*pow(10.0, 15.0))/pow(10.0, 15.0)
		a = a - piBy2Part2
		y = -sin(a)
	}else{
		y = cos(x)
		y = RoundTo15Digits(y)
	}

	return y
}


func D15Tan(_ a : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	x = tan(a)

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Asin(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a < -1.0 || a > 1.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = asin(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Acos(_ a : Double, _ invalidOperation : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	if(a < -1.0 || a > 1.0){
		invalidOperation.booleanValue = true
		x = 0.0
	}else{
		invalidOperation.booleanValue = false
		x = acos(a)
		x = RoundTo15Digits(x)
	}

	return x
}


func D15Atan(_ a : Double) -> Double{
	var a = a;
	var x : Double

	x = atan(a)
	x = RoundTo15Digits(x)

	return x
}


func D15Sqrt(_ a : Double) -> Double{
	var a = a;
	var x : Double

	x = sqrt(a)
	x = RoundTo15Digits(x)

	return x
}


func D15Exponential(_ a : Double, _ overflow : inout BooleanReference) -> Double{
	var a = a;
	var x : Double

	x = exp(a)

	if(x > D15MaxValue() || x < D15MinValue()){
		overflow.booleanValue = true
		x = 0.0
	}else{
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	}

	return x
}


func Decimal15E2ToString(_ decimalx : Double) -> [Character]{
	var decimalx = decimalx;
	var multiplier, inc, i, d : Double
	var exponent : Double
	var done, isPositive, isPositiveExponent : Bool
	var result : [Character]
	var len : Double

	len = 21.0
	/* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"*/
	result = Array(repeating:Character(" "), count: Int(len))

	done = false
	exponent = 0.0

	if(decimalx < 0.0){
		isPositive = false
		decimalx = -decimalx
	}else{
		isPositive = true
	}

	if(decimalx == 0.0){
		done = true
	}

	if(!done){
		multiplier = 0.0
		inc = 0.0

		if(decimalx < 1.0){
			multiplier = 10.0
			inc = -1.0
		}else if(decimalx >= 10.0){
			multiplier = 0.1
			inc = 1.0
		}else{
			done = true
		}

		if(!done){
			exponent = round(log10(decimalx))
			exponent = min(99.0, exponent)
			exponent = max(-99.0, exponent)

			decimalx = decimalx/pow(10.0, exponent)

			/* Adjust*/
			while((decimalx >= 10.0 || decimalx < 1.0) && abs(exponent) < 99.0){
				decimalx = decimalx*multiplier
				exponent = exponent + inc
			}
		}
	}

	isPositiveExponent = exponent >= 0.0
	if(!isPositiveExponent){
		exponent = -exponent
	}

	if(isPositive){
		result[Int(0)] = "+"
	}else{
		result[Int(0)] = "-"
	}

	decimalx = round(decimalx*pow(10.0, 14.0))

	d = floor(decimalx/pow(10.0, 14.0))
	result[Int(1)] = SingleDigitNumberToCharacter(d)
	decimalx = decimalx - d*pow(10.0, 14.0)

	result[Int(2)] = "."

	i = 0.0
	while(i < 14.0){
		d = floor(decimalx/pow(10.0, 13.0 - i))
		result[Int(3.0 + i)] = SingleDigitNumberToCharacter(d)
		decimalx = decimalx - d*pow(10.0, 13.0 - i)
		i = i + 1.0
	}

	result[Int(17)] = "e"

	if(isPositiveExponent){
		result[Int(18)] = "+"
	}else{
		result[Int(18)] = "-"
	}

	result[Int(19)] = SingleDigitNumberToCharacter(floor(exponent/10.0))
	result[Int(20)] = SingleDigitNumberToCharacter(floor(exponent.truncatingRemainder(dividingBy:10.0)))

	return result
}


func SingleDigitNumberToCharacter(_ n : Double) -> Character{
	var n = n;
	var c : Character

	c = "0"
	if(n == 0.0){
		c = "0"
	}else if(n == 1.0){
		c = "1"
	}else if(n == 2.0){
		c = "2"
	}else if(n == 3.0){
		c = "3"
	}else if(n == 4.0){
		c = "4"
	}else if(n == 5.0){
		c = "5"
	}else if(n == 6.0){
		c = "6"
	}else if(n == 7.0){
		c = "7"
	}else if(n == 8.0){
		c = "8"
	}else if(n == 9.0){
		c = "9"
	}

	return c
}


func cToLowerCase(_ character : Character) -> Character{
	var character = character;
	var toReturn : Character

	toReturn = character
	if(character == "A"){
		toReturn = "a"
	}else if(character == "B"){
		toReturn = "b"
	}else if(character == "C"){
		toReturn = "c"
	}else if(character == "D"){
		toReturn = "d"
	}else if(character == "E"){
		toReturn = "e"
	}else if(character == "F"){
		toReturn = "f"
	}else if(character == "G"){
		toReturn = "g"
	}else if(character == "H"){
		toReturn = "h"
	}else if(character == "I"){
		toReturn = "i"
	}else if(character == "J"){
		toReturn = "j"
	}else if(character == "K"){
		toReturn = "k"
	}else if(character == "L"){
		toReturn = "l"
	}else if(character == "M"){
		toReturn = "m"
	}else if(character == "N"){
		toReturn = "n"
	}else if(character == "O"){
		toReturn = "o"
	}else if(character == "P"){
		toReturn = "p"
	}else if(character == "Q"){
		toReturn = "q"
	}else if(character == "R"){
		toReturn = "r"
	}else if(character == "S"){
		toReturn = "s"
	}else if(character == "T"){
		toReturn = "t"
	}else if(character == "U"){
		toReturn = "u"
	}else if(character == "V"){
		toReturn = "v"
	}else if(character == "W"){
		toReturn = "w"
	}else if(character == "X"){
		toReturn = "x"
	}else if(character == "Y"){
		toReturn = "y"
	}else if(character == "Z"){
		toReturn = "z"
	}

	return toReturn
}


func cToUpperCase(_ character : Character) -> Character{
	var character = character;
	var toReturn : Character

	toReturn = character
	if(character == "a"){
		toReturn = "A"
	}else if(character == "b"){
		toReturn = "B"
	}else if(character == "c"){
		toReturn = "C"
	}else if(character == "d"){
		toReturn = "D"
	}else if(character == "e"){
		toReturn = "E"
	}else if(character == "f"){
		toReturn = "F"
	}else if(character == "g"){
		toReturn = "G"
	}else if(character == "h"){
		toReturn = "H"
	}else if(character == "i"){
		toReturn = "I"
	}else if(character == "j"){
		toReturn = "J"
	}else if(character == "k"){
		toReturn = "K"
	}else if(character == "l"){
		toReturn = "L"
	}else if(character == "m"){
		toReturn = "M"
	}else if(character == "n"){
		toReturn = "N"
	}else if(character == "o"){
		toReturn = "O"
	}else if(character == "p"){
		toReturn = "P"
	}else if(character == "q"){
		toReturn = "Q"
	}else if(character == "r"){
		toReturn = "R"
	}else if(character == "s"){
		toReturn = "S"
	}else if(character == "t"){
		toReturn = "T"
	}else if(character == "u"){
		toReturn = "U"
	}else if(character == "v"){
		toReturn = "V"
	}else if(character == "w"){
		toReturn = "W"
	}else if(character == "x"){
		toReturn = "X"
	}else if(character == "y"){
		toReturn = "Y"
	}else if(character == "z"){
		toReturn = "Z"
	}

	return toReturn
}


func cIsUpperCase(_ character : Character) -> Bool{
	var character = character;
	var isUpper : Bool

	isUpper = true
	if(character == "A"){
	}else if(character == "B"){
	}else if(character == "C"){
	}else if(character == "D"){
	}else if(character == "E"){
	}else if(character == "F"){
	}else if(character == "G"){
	}else if(character == "H"){
	}else if(character == "I"){
	}else if(character == "J"){
	}else if(character == "K"){
	}else if(character == "L"){
	}else if(character == "M"){
	}else if(character == "N"){
	}else if(character == "O"){
	}else if(character == "P"){
	}else if(character == "Q"){
	}else if(character == "R"){
	}else if(character == "S"){
	}else if(character == "T"){
	}else if(character == "U"){
	}else if(character == "V"){
	}else if(character == "W"){
	}else if(character == "X"){
	}else if(character == "Y"){
	}else if(character == "Z"){
	}else{
		isUpper = false
	}

	return isUpper
}


func cIsLowerCase(_ character : Character) -> Bool{
	var character = character;
	var isLower : Bool

	isLower = true
	if(character == "a"){
	}else if(character == "b"){
	}else if(character == "c"){
	}else if(character == "d"){
	}else if(character == "e"){
	}else if(character == "f"){
	}else if(character == "g"){
	}else if(character == "h"){
	}else if(character == "i"){
	}else if(character == "j"){
	}else if(character == "k"){
	}else if(character == "l"){
	}else if(character == "m"){
	}else if(character == "n"){
	}else if(character == "o"){
	}else if(character == "p"){
	}else if(character == "q"){
	}else if(character == "r"){
	}else if(character == "s"){
	}else if(character == "t"){
	}else if(character == "u"){
	}else if(character == "v"){
	}else if(character == "w"){
	}else if(character == "x"){
	}else if(character == "y"){
	}else if(character == "z"){
	}else{
		isLower = false
	}

	return isLower
}


func cIsLetter(_ character : Character) -> Bool{
	var character = character;
	return cIsUpperCase(character) || cIsLowerCase(character)
}


func cIsNumber(_ character : Character) -> Bool{
	var character = character;
	var isNumberx : Bool

	isNumberx = true
	if(character == "0"){
	}else if(character == "1"){
	}else if(character == "2"){
	}else if(character == "3"){
	}else if(character == "4"){
	}else if(character == "5"){
	}else if(character == "6"){
	}else if(character == "7"){
	}else if(character == "8"){
	}else if(character == "9"){
	}else{
		isNumberx = false
	}

	return isNumberx
}


func cIsWhiteSpace(_ character : Character) -> Bool{
	var character = character;
	var isWhiteSpacex : Bool

	isWhiteSpacex = true
	if(character == " "){
	}else if(character == "\t"){
	}else if(character == "\n"){
	}else if(character == "\r"){
	}else{
		isWhiteSpacex = false
	}

	return isWhiteSpacex
}


func cIsSymbol(_ character : Character) -> Bool{
	var character = character;
	var isSymbolx : Bool

	isSymbolx = true
	if(character == "!"){
	}else if(character == "\""){
	}else if(character == "#"){
	}else if(character == "$"){
	}else if(character == "%"){
	}else if(character == "&"){
	}else if(character == "\'"){
	}else if(character == "("){
	}else if(character == ")"){
	}else if(character == "*"){
	}else if(character == "+"){
	}else if(character == ","){
	}else if(character == "-"){
	}else if(character == "."){
	}else if(character == "/"){
	}else if(character == ":"){
	}else if(character == ";"){
	}else if(character == "<"){
	}else if(character == "="){
	}else if(character == ">"){
	}else if(character == "?"){
	}else if(character == "@"){
	}else if(character == "["){
	}else if(character == "\\"){
	}else if(character == "]"){
	}else if(character == "^"){
	}else if(character == "_"){
	}else if(character == "`"){
	}else if(character == "{"){
	}else if(character == "|"){
	}else if(character == "}"){
	}else if(character == "~"){
	}else{
		isSymbolx = false
	}

	return isSymbolx
}


func cCharacterIsBefore(_ a : Character, _ b : Character) -> Bool{
	var a = a;
	var b = b;
	var ad, bd : Double

	ad = charToDouble(a)
	bd = charToDouble(b)

	return ad < bd
}


func cDecimalDigitToCharacter(_ digit : Double) -> Character{
	var digit = digit;
	var c : Character
	if(digit == 1.0){
		c = "1"
	}else if(digit == 2.0){
		c = "2"
	}else if(digit == 3.0){
		c = "3"
	}else if(digit == 4.0){
		c = "4"
	}else if(digit == 5.0){
		c = "5"
	}else if(digit == 6.0){
		c = "6"
	}else if(digit == 7.0){
		c = "7"
	}else if(digit == 8.0){
		c = "8"
	}else if(digit == 9.0){
		c = "9"
	}else{
		c = "0"
	}
	return c
}


func cCharacterToDecimalDigit(_ c : Character) -> Double{
	var c = c;
	var digit : Double

	if(c == "1"){
		digit = 1.0
	}else if(c == "2"){
		digit = 2.0
	}else if(c == "3"){
		digit = 3.0
	}else if(c == "4"){
		digit = 4.0
	}else if(c == "5"){
		digit = 5.0
	}else if(c == "6"){
		digit = 6.0
	}else if(c == "7"){
		digit = 7.0
	}else if(c == "8"){
		digit = 8.0
	}else if(c == "9"){
		digit = 9.0
	}else{
		digit = 0.0
	}

	return digit
}


func delete(_ x : Any){
	// Swift has reference counting.
}

