
# Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

class Account
	attr_accessor :name
	attr_accessor :endingBalance
	attr_accessor :startingBalance
	attr_accessor :from
	attr_accessor :to
	attr_accessor :sumDebit
	attr_accessor :sumCredit
end
class AccountDefinition
	attr_accessor :accountName
	attr_accessor :number
	attr_accessor :role
	attr_accessor :debitBalance
end
class AccountPlan
	attr_accessor :accountDefinitions
end
class Ledger
	attr_accessor :decimals
	attr_accessor :transactions
	attr_accessor :accountPlan
end
class Line
	attr_accessor :account
	attr_accessor :debit
	attr_accessor :credit
	attr_accessor :description
	attr_accessor :date
end
class Transaction
	attr_accessor :lines
end
class Sections
	attr_accessor :codes
	attr_accessor :counts
end
class RGBABitmapImageReference
	attr_accessor :image
end
class Success
	attr_accessor :feilmelding
	attr_accessor :success
end
class RGBABitmapImageReference
	attr_accessor :image
end
class Rectangle
	attr_accessor :x1
	attr_accessor :x2
	attr_accessor :y1
	attr_accessor :y2
end
class ScatterPlotSeries
	attr_accessor :linearInterpolation
	attr_accessor :pointType
	attr_accessor :lineType
	attr_accessor :lineThickness
	attr_accessor :xs
	attr_accessor :ys
	attr_accessor :color
end
class ScatterPlotSettings
	attr_accessor :scatterPlotSeries
	attr_accessor :autoBoundaries
	attr_accessor :xMax
	attr_accessor :xMin
	attr_accessor :yMax
	attr_accessor :yMin
	attr_accessor :autoPadding
	attr_accessor :xPadding
	attr_accessor :yPadding
	attr_accessor :xLabel
	attr_accessor :yLabel
	attr_accessor :title
	attr_accessor :showGrid
	attr_accessor :gridColor
	attr_accessor :xAxisAuto
	attr_accessor :xAxisTop
	attr_accessor :xAxisBottom
	attr_accessor :yAxisAuto
	attr_accessor :yAxisLeft
	attr_accessor :yAxisRight
	attr_accessor :width
	attr_accessor :height
end
class BarPlotSeries
	attr_accessor :ys
	attr_accessor :color
end
class BarPlotSettings
	attr_accessor :width
	attr_accessor :height
	attr_accessor :autoBoundaries
	attr_accessor :yMax
	attr_accessor :yMin
	attr_accessor :autoPadding
	attr_accessor :xPadding
	attr_accessor :yPadding
	attr_accessor :title
	attr_accessor :showGrid
	attr_accessor :gridColor
	attr_accessor :barPlotSeries
	attr_accessor :yLabel
	attr_accessor :autoColor
	attr_accessor :grayscaleAutoColor
	attr_accessor :autoSpacing
	attr_accessor :groupSeparation
	attr_accessor :barSeparation
	attr_accessor :autoLabels
	attr_accessor :xLabels
	attr_accessor :barBorder
end
class ArbitraryPrecisionInteger
	attr_accessor :sign
	attr_accessor :number
end
class ArbitraryPrecisionFixedPointNumber
	attr_accessor :baseNumber
	attr_accessor :pointPosition
end
class UnsignedInteger
	attr_accessor :digits
end
class BooleanArrayReference
	attr_accessor :booleanArray
end
class BooleanReference
	attr_accessor :booleanValue
end
class CharacterReference
	attr_accessor :characterValue
end
class NumberArrayReference
	attr_accessor :numberArray
end
class NumberReference
	attr_accessor :numberValue
end
class StringArrayReference
	attr_accessor :stringArray
end
class StringReference
	attr_accessor :string
end
class Date
	attr_accessor :year
	attr_accessor :month
	attr_accessor :day
end
class DateReference
	attr_accessor :date
end
class Interval
	attr_accessor :first
	attr_accessor :last
end
class DateTimeTimezone
	attr_accessor :dateTime
	attr_accessor :timezoneOffsetSeconds
end
class DateTimeTimezoneReference
	attr_accessor :dateTimeTimezone
end
class DateTime
	attr_accessor :date
	attr_accessor :hours
	attr_accessor :minutes
	attr_accessor :seconds
end
class DateTimeReference
	attr_accessor :dateTime
end
class FixedPoint30d
	attr_accessor :part1
	attr_accessor :part2
	attr_accessor :digitsBeforeDecimalPoint
	attr_accessor :digitsAfterDecimalPoint
end
class FixedPoint15d
	attr_accessor :number
	attr_accessor :digitsBeforeDecimalPoint
	attr_accessor :digitsAfterDecimalPoint
end
class DynamicArrayCharacters
	attr_accessor :array
	attr_accessor :lengthx
end
class LinkedListNodeStrings
	attr_accessor :endx
	attr_accessor :value
	attr_accessor :nextx
end
class LinkedListStrings
	attr_accessor :first
	attr_accessor :last
end
class LinkedListNodeNumbers
	attr_accessor :nextx
	attr_accessor :endx
	attr_accessor :value
end
class LinkedListNumbers
	attr_accessor :first
	attr_accessor :last
end
class LinkedListCharacters
	attr_accessor :first
	attr_accessor :last
end
class LinkedListNodeCharacters
	attr_accessor :endx
	attr_accessor :value
	attr_accessor :nextx
end
class DynamicArrayNumbers
	attr_accessor :array
	attr_accessor :lengthx
end
class Array
	attr_accessor :array
	attr_accessor :lengthx
end
class Datax
	attr_accessor :isStruture
	attr_accessor :isArray
	attr_accessor :isNumber
	attr_accessor :isString
	attr_accessor :isBoolean
	attr_accessor :structure
	attr_accessor :array
	attr_accessor :number
	attr_accessor :booleanx
	attr_accessor :string
end
class DataReference
	attr_accessor :data
end
class Structure
	attr_accessor :keys
	attr_accessor :values
end
class RGBA
	attr_accessor :r
	attr_accessor :g
	attr_accessor :b
	attr_accessor :a
end
class RGBABitmap
	attr_accessor :y
end
class RGBABitmapImage
	attr_accessor :x
end
class Matrix
	attr_accessor :r
end
class MatrixArrayReference
	attr_accessor :matrices
end
class MatrixReference
	attr_accessor :matrix
end
class MatrixRow
	attr_accessor :c
end
class ComplexMatrix
	attr_accessor :r
end
class ComplexMatrixArrayReference
	attr_accessor :matrices
end
class ComplexMatrixReference
	attr_accessor :matrix
end
class ComplexMatrixRow
	attr_accessor :c
end
class LinearCongruentialGenerator
	attr_accessor :x
	attr_accessor :a
	attr_accessor :c
	attr_accessor :m
end
class PseudorandomGenerator
	attr_accessor :lcg
end
class CComplexNumber
	attr_accessor :re
	attr_accessor :im
end
class CComplexNumberArrayReference
	attr_accessor :complexNumbers
end
class CComplexNumberReference
	attr_accessor :complexNumbers
end
class CPolarComplexNumber
	attr_accessor :r
	attr_accessor :phi
end
class PComplexPolynomial
	attr_accessor :cs
end
def CreateLedger(decimals)

	ledger = CreateStructure()
	transactions = CreateArray()
	AddNumberToStruct(ledger, "decimals".split(""), decimals)
	AddArrayToStruct(ledger, "transactions".split(""), transactions)

	return ledger
end


def CreateFixedPointForDynamicLedger(ledger)

	d = GetNumberFromStruct(ledger, "decimals".split(""))
	n = CreateFixedPoint15d(15.0 - d, d)

	return n
end


def CreateFixedPointForStaticLedger(ledger)

	d = ledger.decimals
	n = CreateFixedPoint15d(15.0 - d, d)

	return n
end


def CreateLine(account, debit, credit, description, date)

	t = Line.new

	t.account = arraysCopyString(account)
	t.debit = Copy15d(debit)
	t.credit = Copy15d(credit)
	t.description = arraysCopyString(description)
	t.date = CopyDate(date)

	return t
end


def AddTransactionToLedger(ledger, src)

	dst = LineToStructure(src)

	AddStructToArray(ledger, dst)
end


def AddTransactionsToLedger(ledger, ts)

	i = 0.0
	while(i < ts.length)
		dst = LineToStructure(ts[i])
		AddStructToArray(ledger, dst)
		i = i + 1.0
	end
end


def ValidateAndAddTransactionToLedger(ledger, ls)

	transactions = GetArrayFromStruct(ledger, "transactions".split(""))

	valid = ValidateTransaction(ls, ledger)

	if valid
		lines = CreateArray()

		i = 0.0
		while(i < ls.length)
			dst = LineToStructure(ls[i])
			AddStructToArray(lines, dst)
			i = i + 1.0
		end

		AddArrayToArray(transactions, lines)
	end

	return valid
end


def GetTransactionFromLedger(ledger, index)

	transactions = GetArrayFromStruct(ledger, "transactions".split(""))
	decimals = GetNumberFromStruct(ledger, "decimals".split(""))

	dst = ArrayIndexStruct(transactions, index)

	t = LineFromStructure(dst, ledger)

	return t
end


def LineToStructure(src)

	dst = CreateStructure()

	debitStr = ToString15d(src.debit)
	creditStr = ToString15d(src.credit)
	dateStr = DateToStringISO8601(src.date)

	AddStringToStruct(dst, "account".split(""), src.account)
	AddStringToStruct(dst, "debit".split(""), debitStr)
	AddStringToStruct(dst, "credit".split(""), creditStr)
	AddStringToStruct(dst, "date".split(""), dateStr)
	AddStringToStruct(dst, "description".split(""), src.description)

	return dst
end


def LineFromStructure(src, ledger)

	account = GetStringFromStruct(src, "account".split(""))
	debitStr = GetStringFromStruct(src, "debit".split(""))
	creditStr = GetStringFromStruct(src, "credit".split(""))
	dateStr = GetStringFromStruct(src, "date".split(""))
	description = GetStringFromStruct(src, "description".split(""))

	debitNumber = CreateNumberFromDecimalString(debitStr)
	creditNumber = CreateNumberFromDecimalString(creditStr)

	debit = CreateFixedPointForDynamicLedger(ledger)
	credit = CreateFixedPointForDynamicLedger(ledger)
	Assign15d(debit, debitNumber)
	Assign15d(credit, creditNumber)

	date = DateFromStringISO8601(dateStr)

	dst = CreateLine(account, debit, credit, description, date)

	return dst
end


def LedgerDynamicToStatic(src)

	dst = Ledger.new

	transactions = GetArrayFromStruct(src, "transactions".split(""))
	decimals = GetNumberFromStruct(src, "decimals".split(""))
	ts = ArrayLength(transactions)

	dst.decimals = decimals
	dst.transactions = Array.new(ts)

	i = 0.0
	while(i < ts)
		lines = ArrayIndexArray(transactions, i)
		ls = ArrayLength(lines)

		t = Transaction.new
		t.lines = Array.new(ls)

		j = 0.0
		while(j < ls)
			line = ArrayIndexStruct(lines, j)
			sline = LineFromStructure(line, src)
			t.lines[j] = sline
			j = j + 1.0
		end

		dst.transactions[i] = t
		i = i + 1.0
	end

	return dst
end


def ValidateTransaction(ts, ledger)

	valid = true

	if ts.length > 0.0
		date = ts[0].date

		creditSum = CreateFixedPointForDynamicLedger(ledger)
		debitSum = CreateFixedPointForDynamicLedger(ledger)

		i = 0.0
		while(i < ts.length && valid)
			t = ts[i]

			d = ToNumber15d(t.debit)
			c = ToNumber15d(t.credit)

			Add15d(creditSum, creditSum, t.credit)
			Add15d(debitSum, debitSum, t.debit)

			if DateEquals(date, t.date) && (d == 0.0 || c == 0.0)
			else
				valid = false
			end
			i = i + 1.0
		end

		if valid
			creditStr = ToString15d(creditSum)
			debitStr = ToString15d(creditSum)

			valid = arraysStringsEqual(creditStr, debitStr)
		end
	end

	return valid
end


def ValidateTransactions(ts, invalidIds)

	# TODO
	valid = true

	return valid
end


def ComputeAccountBalance(ledger, accountName, fromDate, toDate)

	ts = ledger.transactions

	a = Account.new

	a.name = arraysCopyString(accountName)
	a.endingBalance = CreateFixedPointForStaticLedger(ledger)
	a.startingBalance = CreateFixedPointForStaticLedger(ledger)
	a.from = CopyDate(fromDate)
	a.to = CopyDate(toDate)
	a.sumDebit = CreateFixedPointForStaticLedger(ledger)
	a.sumCredit = CreateFixedPointForStaticLedger(ledger)

	i = 0.0
	while(i < ts.length)
		t = ts[i]

		j = 0.0
		while(j < t.lines.length)
			l = t.lines[j]

			if arraysStringsEqual(l.account, accountName)

				if DateLessThan(l.date, fromDate)
					Add15d(a.startingBalance, a.startingBalance, l.debit)
					Subtract15d(a.startingBalance, a.startingBalance, l.credit)
				elsif DateLessThan(l.date, toDate)
					Add15d(a.endingBalance, a.endingBalance, l.debit)
					Subtract15d(a.endingBalance, a.endingBalance, l.credit)

					Add15d(a.sumDebit, a.sumDebit, l.debit)
					Add15d(a.sumCredit, a.sumCredit, l.credit)
				end
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	Add15d(a.endingBalance, a.endingBalance, a.startingBalance)

	return a
end


def AccountToString(account)

	ll = CreateLinkedListCharacter()

	diff = Copy15d(account.endingBalance)
	Subtract15d(diff, diff, account.startingBalance)

	LinkedListCharactersAddString(ll, account.name)
	LinkedListCharactersAddString(ll, ": ".split(""))
	LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.startingBalance, 2.0, "".split(""), ".".split("")))
	LinkedListCharactersAddString(ll, " -> ".split(""))
	LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.endingBalance, 2.0, "".split(""), ".".split("")))
	LinkedListCharactersAddString(ll, ": ".split(""))
	LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2.0, ",".split(""), ".".split("")))
	LinkedListCharactersAddString(ll, " (+".split(""))
	LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumDebit, 2.0, "".split(""), ".".split("")))
	LinkedListCharactersAddString(ll, ", -".split(""))
	LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumCredit, 2.0, "".split(""), ".".split("")))
	LinkedListCharactersAddString(ll, ")".split(""))

	return LinkedListCharactersToArray(ll)
end


def AddMonthlyAccruals(ledger, from, to, amount, fromAccount, toAccount)

	message = StringReference.new

	amounts = GetAccrualsWithDates(amount, from, to)

	date = CopyDate(from)
	date.day = 1.0

	c = CreateFixedPointForDynamicLedger(ledger)
	d = CreateFixedPointForDynamicLedger(ledger)

	i = 0.0
	while(i < amounts.length)
		transaction = Array.new(2)

		accountName = fromAccount
		Assign15d(d, amounts[i])
		Assign15d(c, 0.0)
		desc = "x".split("")
		transaction[0] = CreateLine(accountName, d, c, desc, date)

		accountName = toAccount
		Assign15d(d, 0.0)
		Assign15d(c, amounts[i])
		desc = "x".split("")
		transaction[1] = CreateLine(accountName, d, c, desc, date)

		valid = ValidateAndAddTransactionToLedger(ledger, transaction)

		success = AddMonthsToDate(date, 1.0, message)
		i = i + 1.0
	end
end


def ComputeAccountBalancePrefixAccount(ledger, accountNr, toDate, debitBalance)

	prefixL = CreateLinkedListCharacter()
	LinkedListCharactersAddString(prefixL, accountNr)
	LinkedListCharactersAddString(prefixL, ".".split(""))

	prefixed = LinkedListCharactersToArray(prefixL)

	ts = ledger.transactions

	balance = CreateFixedPointForStaticLedger(ledger)

	i = 0.0
	while(i < ts.length)
		t = ts[i]

		j = 0.0
		while(j < t.lines.length)
			l = t.lines[j]

			if strStartsWith(l.account, prefixed) || arraysStringsEqual(l.account, accountNr)
				if DateLessThan(l.date, toDate) || DateEquals(l.date, toDate)
					if debitBalance
						Add15d(balance, balance, l.debit)
						Subtract15d(balance, balance, l.credit)
					else
						Add15d(balance, balance, l.credit)
						Subtract15d(balance, balance, l.debit)
					end
				end
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	return balance
end


def GetIFRSAccountPlan()

	ll = CreateLinkedListCharacter()

	# https://www.ifrs-gaap.com/ifrs-chart-accounts
	validRef = CreateBooleanReference(false)

	LinkedListCharactersAddString(ll, "1\tAssets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1\tProperty, plant and equipment\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.1\tLand and land improvements\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.2\tBuildings, structures and improvements\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.3\tMachinery and equipment\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.4\tFixtures and fittings\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.5\tRight of use assets (classified as PP&E)\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.6\tAdditional property, plant and equipment\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1.7\tConstruction in progress\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.2\tInvestment property\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.2.1\tCompleted\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.2.2\tUnder construction or development\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.3\tGoodwill\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4\tIntangible assets excluding goodwill\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.1\tIntellectual property\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.2\tComputer software\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.3\tTrade and distribution assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.4\tContracts and rights\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.5\tRight of use assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.6\tCrypto assets (classified as intangible)\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.7\tAdditional intangible assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.4.8\tAcquisition in progress\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.5\tFinancial assets and investments\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.5.1\tNon-derivative financial assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.5.2\tDerivative financial assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.5.3\tAdditional financial assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.5.4\tCrypto assets (classified as financial assets)\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.6\tInventories\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.6.1\tMerchandise\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.6.2\tRaw materials and production supplies\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.6.3\tWork in progress\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.6.4\tFinished goods\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.6.5\tOther inventories\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.7\tPrepayments and accrued income\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.7.1\tPrepayments\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.7.2\tAccrued income\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.7.3\tService provider work in process (not classified as inventory)\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.7.4\tAdditional assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.8\tReceivables and contracts\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.8.1\tLoans and receivables\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.8.2\tContracts with customers\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.8.3\tNontrade and other receivables\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.9\tTax assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.9.1\tTax assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.9.2\tDeferred tax assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.9.3\tOther tax assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.1\tAgricultural biological assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.10.1\tBearer plants\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.10.2\tAnimals\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.10.3\tOther agricultural assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.11\tCash and cash equivalents\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.11.1\tCash\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.11.2\tCash equivalents\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "1.11.3\tRestricted cash and financial assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "2\tEquity\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.1\tTotal equity attributable to owners of parent\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.1.1\tIssued capital\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.1.2\tAdditional item paid-in capital\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.1.3\tPartner\'s capital\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.1.4\tMember\'s equity\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.1.5\tOther equity interest\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.2\tRetained earnings\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.2.3\tIn suspense\tZero\n".split(""))
	LinkedListCharactersAddString(ll, "2.3\tAccumulated other comprehensive income\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.3.2\tMiscellaneous equity\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.4\tOwners equity (non-shareholder)\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "2.5\tNon-controlling interests\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3\tLiabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.1\tTrade and other payables\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.1.1\tTrade payables\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.1.2\tDividend payables\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.1.3\tInterest payable\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.1.4\tOther payables\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.2\tProvisions\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.2.1\tCustomer related provisions\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.2.2\tLitigation and regulatory\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.2.3\tAdditional provisions\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3\tOther financial liabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3.1\tNotes payable\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3.2\tLoans received\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3.3\tBonds (debentures)\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3.4\tOther debts and borrowings\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3.5\tLease obligations\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.3.6\tDerivative financial liabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.4.1\tAccruals\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.4.2\tDeferred income and refund liabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.4.3\tAccrued taxes other than payroll\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "3.4.4\tAdditional liabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4\tRevenue\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.1\tRecognized point of time\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.1.1\tGoods\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.1.2\tServices\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.2\tRecognized over time\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.2.1\tProducts and projects\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.2.2\tServices\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "4.3\tAdjustments\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "4.3.1\tVariable consideration\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "4.3.2\tConsideration paid payable to customers\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "4.3.3\tOther adjustments\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5\tExpenses\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.1\tExpenses (classified by nature)\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.1.1\tMaterial and merchandise\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.1.2\tEmployee benefits expense\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.1.3\tServices expense\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.1.4\tRent, depreciation, amortization and depletion\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "5.1.6\tOther work performed by entity and capitalized\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.2\tExpenses (classified by function)\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.2.1\tCost of sales\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "5.2.2\tSelling, general and administrative expense\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "6\tOther non-operating income and expenses\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "6.1\tOther revenue and expenses\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "6.1.1\tOther revenue\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "6.1.2\tOther expenses\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "6.2\tGains and losses\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "6.3\tTaxes other than income and payroll and fees\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "6.4\tTax income (expense)\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7\tIntercompany and related party accounts\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7.1\tIntercompany and related party assets\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "7.1.1\tIntercompany balances eliminated in consolidation\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "7.1.2\tRelated party balances reported or disclosed\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "7.1.3\tIntercompany investments\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "7.2\tIntercompany and related party liabilities\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7.2.2\tRelated party balances reported or disclosed\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7.3\tIntercompany and related party income and expense\tDr or (Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7.3.1\tIntercompany and related party income\t(Cr)\n".split(""))
	LinkedListCharactersAddString(ll, "7.3.2\tIntercompany and related party expenses\tDr\n".split(""))
	LinkedListCharactersAddString(ll, "7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n".split(""))

	accountPlanString = LinkedListCharactersToArray(ll)

	FreeLinkedListCharacter(ll)

	return ParseAccountPlanString(accountPlanString, validRef)
end


def ParseAccountPlanString(accountPlanString, valid)

	ap = AccountPlan.new

	accountPlanString = strTrim(accountPlanString)
	lines = strSplitByCharacter(accountPlanString, "\n")

	ap.accountDefinitions = Array.new(lines.length)

	i = 0.0
	while(i < lines.length)
		line = lines[i].string
		#System.out.println(line);
		parts = strSplitByCharacter(line, "\t")

		ad = AccountDefinition.new

		ad.accountName = parts[1].string
		ad.number = parts[0].string
		if arraysStringsEqual(parts[2].string, "(Cr)".split(""))
			ad.debitBalance = false
		else
			ad.debitBalance = true
		end
		ad.role = "".split("")
		if arraysStringsEqual(ad.number, "1".split(""))
			ad.role = "Assets".split("")
		elsif arraysStringsEqual(ad.number, "2".split(""))
			ad.role = "Equities".split("")
		elsif arraysStringsEqual(ad.number, "3".split(""))
			ad.role = "Liabilities".split("")
		elsif arraysStringsEqual(ad.number, "4".split(""))
			ad.role = "Revenue".split("")
		elsif arraysStringsEqual(ad.number, "5".split(""))
			ad.role = "Expenses".split("")
		end

		ap.accountDefinitions[i] = ad
		i = i + 1.0
	end

	return ap
end


def ComputeAccountBalances(sledger, depth, date, balanceSheet)

	balanceSheet.data = CreateNewStructData()
	success = true

	foundRef = CreateBooleanReference(false)

	accountPlan = sledger.accountPlan

	assetsDef = FindAccountWithRole(accountPlan, "Assets".split(""), foundRef)
	success = success && foundRef.booleanValue
	liabilitiesDef = FindAccountWithRole(accountPlan, "Liabilities".split(""), foundRef)
	success = success && foundRef.booleanValue
	equitiesDef = FindAccountWithRole(accountPlan, "Equities".split(""), foundRef)
	success = success && foundRef.booleanValue
	revenueDef = FindAccountWithRole(accountPlan, "Revenue".split(""), foundRef)
	success = success && foundRef.booleanValue
	expensesDef = FindAccountWithRole(accountPlan, "Expenses".split(""), foundRef)
	success = success && foundRef.booleanValue

	if success
		assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.number, date, assetsDef.debitBalance)
		liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.number, date, liabilitiesDef.debitBalance)

		# TODO: This must be for a period
		revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.number, date, revenueDef.debitBalance)
		expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.number, date, expensesDef.debitBalance)
		resultBalance = CreateFixedPointForStaticLedger(sledger)
		Subtract15d(resultBalance, revenueBalanace, expensesBalance)
		balanceStr = FormatToStringWithSymbols15d(resultBalance, 2.0, "".split(""), ".".split(""))
		AddStringToStruct(balanceSheet.data.structure, "result".split(""), balanceStr)

		equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.number, date, equitiesDef.debitBalance)
		Add15d(equitiesBalance, equitiesBalance, resultBalance)

		# Compute accounts
		accounts = CreateArray()

		i = 0.0
		while(i < accountPlan.accountDefinitions.length)
			accountDef = accountPlan.accountDefinitions[i]

			parts = strSplitByCharacter(accountDef.number, ".")

			if parts.length <= depth + 1.0
				account = CreateStructure()

				balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.number, date, accountDef.debitBalance)

				balanceStr = FormatToStringWithSymbols15d(balance, 2.0, "".split(""), ".".split(""))

				AddStringToStruct(account, "number".split(""), accountDef.number)
				AddStringToStruct(account, "name".split(""), accountDef.accountName)
				AddStringToStruct(account, "balance".split(""), balanceStr)
				AddNumberToStruct(account, "depth".split(""), parts.length - 1.0)

				AddStructToArray(accounts, account)
			end
			i = i + 1.0
		end

		AddArrayToStruct(balanceSheet.data.structure, "accounts".split(""), accounts)

		# End conclusion
		balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2.0, "".split(""), ".".split(""))
		AddStringToStruct(balanceSheet.data.structure, "assets".split(""), balanceStr)

		sum = CreateFixedPointForStaticLedger(sledger)
		Add15d(sum, liabilitiesBalance, equitiesBalance)
		balanceStr = FormatToStringWithSymbols15d(sum, 2.0, "".split(""), ".".split(""))
		AddStringToStruct(balanceSheet.data.structure, "liabilitiesAndEquity".split(""), balanceStr)

		isBalanced = Equals15d(sum, assetsBalance)
		AddBooleanToStruct(balanceSheet.data.structure, "balanced".split(""), isBalanced)

		dateStr = DateToStringISO8601(date)
		AddStringToStruct(balanceSheet.data.structure, "date".split(""), dateStr)
	end

	return success
end


def AccountBalancesToString(balanceSheet)

	ll = CreateLinkedListCharacter()

	# Print accounts
	accounts = GetArrayFromStruct(balanceSheet, "accounts".split(""))

	i = 0.0
	while(i < ArrayLength(accounts))
		account = ArrayIndexStruct(accounts, i)

		accountNumber = GetStringFromStruct(account, "number".split(""))
		accountName = GetStringFromStruct(account, "name".split(""))
		balanceStr = GetStringFromStruct(account, "balance".split(""))
		depth = GetNumberFromStruct(account, "depth".split(""))

		j = 0.0
		while(j < depth)
			LinkedListCharactersAddString(ll, "  ".split(""))
			j = j + 1.0
		end

		LinkedListCharactersAddString(ll, accountNumber)
		LinkedListCharactersAddString(ll, ". ".split(""))
		LinkedListCharactersAddString(ll, accountName)
		LinkedListCharactersAddString(ll, ": ".split(""))
		LinkedListCharactersAddString(ll, balanceStr)
		LinkedListCharactersAddString(ll, "\n".split(""))
		i = i + 1.0
	end

	# End conclusion
	LinkedListCharactersAddString(ll, "\n".split(""))

	LinkedListCharactersAddString(ll, "Result: ".split(""))
	balanceStr = GetStringFromStruct(balanceSheet, "result".split(""))
	LinkedListCharactersAddString(ll, balanceStr)
	LinkedListCharactersAddString(ll, "\n".split(""))

	LinkedListCharactersAddString(ll, "Assets: ".split(""))
	balanceStr = GetStringFromStruct(balanceSheet, "assets".split(""))
	LinkedListCharactersAddString(ll, balanceStr)
	LinkedListCharactersAddString(ll, "\n".split(""))

	LinkedListCharactersAddString(ll, "Liabilities + Equities: ".split(""))
	balanceStr = GetStringFromStruct(balanceSheet, "liabilitiesAndEquity".split(""))
	LinkedListCharactersAddString(ll, balanceStr)
	LinkedListCharactersAddString(ll, "\n".split(""))

	isBalanced = GetBooleanFromStruct(balanceSheet, "balanced".split(""))
	LinkedListCharactersAddString(ll, "Balance: ".split(""))
	if isBalanced
		LinkedListCharactersAddString(ll, "true".split(""))
	else
		LinkedListCharactersAddString(ll, "false".split(""))
	end
	LinkedListCharactersAddString(ll, "\n".split(""))

	return LinkedListCharactersToArray(ll)
end


def FindAccountWithRole(accountPlan, role, foundRef)

	ad = AccountDefinition.new

	done = false
	i = 0.0
	while(i < accountPlan.accountDefinitions.length && !done)
		ad = accountPlan.accountDefinitions[i]
		if arraysStringsEqual(ad.role, role)
			done = true
		end
		i = i + 1.0
	end

	foundRef.booleanValue = done

	return ad
end


def CreateAccountDefinition(name, number, role, debitBalance)

	defx = AccountDefinition.new
	defx.accountName = name
	defx.number = number
	defx.role = role
	defx.debitBalance = debitBalance

	return defx
end


def ComputeBalanceDiffs(sledger, balances)

	first = ArrayIndexStruct(balances, 0.0)
	accountsO = GetArrayFromStruct(first, "accounts".split(""))

	j = 0.0
	while(j < ArrayLength(accountsO))
		i = 1.0
		while(i < ArrayLength(balances))
			balance1 = ArrayIndexStruct(balances, i - 1.0)
			balance2 = ArrayIndexStruct(balances, i)
			accounts1 = GetArrayFromStruct(balance1, "accounts".split(""))
			accounts2 = GetArrayFromStruct(balance2, "accounts".split(""))

			account1 = ArrayIndexStruct(accounts1, j)
			account2 = ArrayIndexStruct(accounts2, j)

			b1 = GetStringFromStruct(account1, "balance".split(""))
			b2 = GetStringFromStruct(account2, "balance".split(""))

			f1 = CreateFixedPointForStaticLedger(sledger)
			f2 = CreateFixedPointForStaticLedger(sledger)
			diff = CreateFixedPointForStaticLedger(sledger)

			Assign15d(f1, CreateNumberFromDecimalString(b1))
			Assign15d(f2, CreateNumberFromDecimalString(b2))

			Subtract15d(diff, f2, f1)

			diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".split(""), ".".split(""))

			#System.out.println(diffStr);
			if i == 1.0
				AddStringToStruct(account1, "change".split(""), "0.00".split(""))
			end
			AddStringToStruct(account2, "change".split(""), diffStr)
			i = i + 1.0
		end
		j = j + 1.0
	end

	i = 1.0
	while(i < ArrayLength(balances))
		balance1 = ArrayIndexStruct(balances, i - 1.0)
		balance2 = ArrayIndexStruct(balances, i)
		b1 = GetStringFromStruct(balance1, "result".split(""))
		b2 = GetStringFromStruct(balance2, "result".split(""))

		f1 = CreateFixedPointForStaticLedger(sledger)
		f2 = CreateFixedPointForStaticLedger(sledger)
		diff = CreateFixedPointForStaticLedger(sledger)

		Assign15d(f1, CreateNumberFromDecimalString(b1))
		Assign15d(f2, CreateNumberFromDecimalString(b2))

		Subtract15d(diff, f2, f1)

		diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".split(""), ".".split(""))

		#System.out.println(diffStr);
		if i == 1.0
			AddStringToStruct(balance1, "rchange".split(""), "0.00".split(""))
		end
		AddStringToStruct(balance2, "rchange".split(""), diffStr)
		i = i + 1.0
	end
end


def BalancesArrayToHTML(balances, includeBalance, includeDiff)

	ll = CreateLinkedListCharacter()

	LinkedListCharactersAddString(ll, "<html>".split(""))
	LinkedListCharactersAddString(ll, "<body>".split(""))
	LinkedListCharactersAddString(ll, "<table>".split(""))

	# Headers
	LinkedListCharactersAddString(ll, "<tr>".split(""))

	LinkedListCharactersAddString(ll, "<td>".split(""))
	LinkedListCharactersAddString(ll, "</td>".split(""))
	LinkedListCharactersAddString(ll, "<td>".split(""))
	LinkedListCharactersAddString(ll, "</td>".split(""))

	i = 0.0
	while(i < ArrayLength(balances))
		balance = ArrayIndexStruct(balances, i)
		dateStr = GetStringFromStruct(balance, "date".split(""))
		dateStr = strSubstring(dateStr, 0.0, 7.0)

		LinkedListCharactersAddString(ll, "<td>".split(""))
		LinkedListCharactersAddString(ll, dateStr)
		LinkedListCharactersAddString(ll, "</td>".split(""))
		i = i + 1.0
	end

	LinkedListCharactersAddString(ll, "</tr>".split(""))

	# Each account
	first = ArrayIndexStruct(balances, 0.0)
	accounts = GetArrayFromStruct(first, "accounts".split(""))
	j = 0.0
	while(j < ArrayLength(accounts))
		LinkedListCharactersAddString(ll, "<tr>".split(""))

		account = ArrayIndexStruct(accounts, j)
		name = GetStringFromStruct(account, "name".split(""))
		number = GetStringFromStruct(account, "number".split(""))

		LinkedListCharactersAddString(ll, "<td>".split(""))
		LinkedListCharactersAddString(ll, number)
		LinkedListCharactersAddString(ll, "</td>".split(""))

		LinkedListCharactersAddString(ll, "<td>".split(""))
		LinkedListCharactersAddString(ll, name)
		LinkedListCharactersAddString(ll, "</td>".split(""))

		i = 0.0
		while(i < ArrayLength(balances))
			balance = ArrayIndexStruct(balances, i)
			accounts = GetArrayFromStruct(balance, "accounts".split(""))
			account = ArrayIndexStruct(accounts, j)
			balanceStr = GetStringFromStruct(account, "balance".split(""))
			changeStr = GetStringFromStruct(account, "change".split(""))

			LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".split(""))

			if includeBalance && includeDiff
				LinkedListCharactersAddString(ll, balanceStr)
				LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".split(""))
				LinkedListCharactersAddString(ll, changeStr)
				LinkedListCharactersAddString(ll, "</small>".split(""))
			elsif includeBalance
				LinkedListCharactersAddString(ll, balanceStr)
			elsif includeDiff
				LinkedListCharactersAddString(ll, changeStr)
			end

			LinkedListCharactersAddString(ll, "</td>".split(""))
			i = i + 1.0
		end

		LinkedListCharactersAddString(ll, "</tr>".split(""))
		j = j + 1.0
	end

	# Result
	LinkedListCharactersAddString(ll, "<tr>".split(""))

	LinkedListCharactersAddString(ll, "<td>".split(""))
	LinkedListCharactersAddString(ll, "".split(""))
	LinkedListCharactersAddString(ll, "</td>".split(""))

	LinkedListCharactersAddString(ll, "<td>".split(""))
	LinkedListCharactersAddString(ll, "Result".split(""))
	LinkedListCharactersAddString(ll, "</td>".split(""))

	i = 0.0
	while(i < ArrayLength(balances))
		balance = ArrayIndexStruct(balances, i)
		balanceStr = GetStringFromStruct(balance, "result".split(""))
		changeStr = GetStringFromStruct(balance, "rchange".split(""))

		LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">".split(""))

		if includeBalance && includeDiff
			LinkedListCharactersAddString(ll, balanceStr)
			LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">".split(""))
			LinkedListCharactersAddString(ll, changeStr)
			LinkedListCharactersAddString(ll, "</small>".split(""))
		elsif includeBalance
			LinkedListCharactersAddString(ll, balanceStr)
		elsif includeDiff
			LinkedListCharactersAddString(ll, changeStr)
		end

		LinkedListCharactersAddString(ll, "</td>".split(""))
		i = i + 1.0
	end

	LinkedListCharactersAddString(ll, "</tr>".split(""))

	# Footer
	LinkedListCharactersAddString(ll, "</table>".split(""))
	LinkedListCharactersAddString(ll, "</body>".split(""))
	LinkedListCharactersAddString(ll, "</html>".split(""))

	return LinkedListCharactersToArray(ll)
end


def CreateLineFromScript(ledger, script, date)

	c = CreateFixedPointForDynamicLedger(ledger)
	d = CreateFixedPointForDynamicLedger(ledger)

	parts = strSplitByCharacter(script, ",")

	i = 0.0
	while(i < parts.length)
		parts[i].string = strTrim(parts[i].string)
		i = i + 1.0
	end

	line = Line.new

	n = CreateNumberFromDecimalString(parts[2].string)

	line.date = date
	if arraysStringsEqual(parts[0].string, "Debit".split(""))
		Assign15d(d, n)
		Assign15d(c, 0.0)
	elsif arraysStringsEqual(parts[0].string, "Credit".split(""))
		Assign15d(d, 0.0)
		Assign15d(c, n)
	end

	line = CreateLine(parts[1].string, d, c, parts[3].string, date)

	return line
end


def LuhnCheck(number, errorMessage)

	numberReference = StringReference.new
	checkDigitReference = CharacterReference.new
	numberString = Array.new(1)
	digitReference = NumberReference.new

	isValid = arraysCopyStringRange(number, 0.0, number.length - 1.0, numberReference)
	if isValid
		isValid = LuhnComputeCheckDigit(numberReference.string, checkDigitReference, errorMessage)
		if isValid
			if checkDigitReference.characterValue == number[number.length - 1.0]
			else
				numberString[0] = number[number.length - 1.0]
				isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage)
				if isValid
					errorMessage.string = "Check digit wrong.".split("")
				else
					errorMessage.string = "Check symbol not a digit.".split("")
				end
				isValid = false
			end
		end
	else
		errorMessage.string = "Number is too short: must be at least one digit.".split("")
	end

	return isValid
end


def LuhnComputeCheckDigit(number, checkDigitReference, errorMessage)

	sum = 0.0
	alternate = true
	numberString = Array.new(1)
	numberReference = NumberReference.new
	isValid = true

	i = number.length - 1.0
	while(i >= 0.0 && isValid)
		numberString[0] = number[i]
		isValid = CreateNumberFromDecimalStringWithCheck(numberString, numberReference, errorMessage)
		if isValid
			n = numberReference.numberValue
			if alternate
				n = n*2.0
				if n > 9.0
					n = (n%10.0) + 1.0
				end
			end
			sum = sum + n
			alternate = !alternate
		else
			errorMessage.string = "Invalid digit in number string.".split("")
		end
		i = i - 1.0
	end

	if isValid
		check = sum%10.0

		if check != 0.0
			check = 10.0 - check
		end

		GetSingleDigitCharacterFromNumberWithCheck(check, 10.0, checkDigitReference)
	end

	return isValid
end


def LuhnExtendWithCheckDigit(number, extended, errorMessage)

	checkDigitReference = CharacterReference.new
	isValid = LuhnComputeCheckDigit(number, checkDigitReference, errorMessage)

	if isValid
		extended.string = Array.new(number.length + 1.0)
		i = 0.0
		while(i < number.length)
			extended.string[i] = number[i]
			i = i + 1.0
		end
		extended.string[i] = checkDigitReference.characterValue
	end

	return isValid
end


def ISINCheck(isin, errorMessage)

	numberReference = StringReference.new
	checkDigitReference = CharacterReference.new
	numberString = Array.new(1)
	digitReference = NumberReference.new

	if isin.length == 12.0
		arraysCopyStringRange(isin, 0.0, isin.length - 1.0, numberReference)

		isValid = ISINComputeCheckDigit(numberReference.string, checkDigitReference, errorMessage)
		if isValid
			if checkDigitReference.characterValue == isin[isin.length - 1.0]
			else
				numberString[0] = isin[isin.length - 1.0]
				isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage)
				if isValid
					errorMessage.string = "Check digit wrong.".split("")
				else
					errorMessage.string = "Check symbol not a digit.".split("")
				end
				isValid = false
			end
		end
	else
		isValid = false
		errorMessage.string = "ISIN must be 12 alpha-numeric characters.".split("")
	end

	return isValid
end


def ISINComputeCheckDigit(isin, checkDigitReference, errorMessage)

	isinNumericReference = StringReference.new

	if isin.length == 11.0
		isValid = ISINToNumericCode(isin, isinNumericReference, errorMessage)

		if isValid
			LuhnComputeCheckDigit(isinNumericReference.string, checkDigitReference, errorMessage)
		end
	else
		isValid = false
		errorMessage.string = "ISIN must be 11 digits before the checksum digit to be calculated.".split("")
	end

	return isValid
end


def ISINExtendWithCheckDigit(isin, extended, errorMessage)

	checkDigitReference = CharacterReference.new
	isValid = ISINComputeCheckDigit(isin, checkDigitReference, errorMessage)

	if isValid
		extended.string = Array.new(isin.length + 1.0)
		i = 0.0
		while(i < isin.length)
			extended.string[i] = isin[i]
			i = i + 1.0
		end
		extended.string[i] = checkDigitReference.characterValue
	end

	return isValid
end


def ISINToNumericCode(isin, isinNumericReference, errorMessage)

	isValid = true
	code = StringReference.new

	lengthx = 0.0

	i = 0.0
	while(i < isin.length && isValid)
		if cIsLetter(isin[i])
			lengthx = lengthx + 2.0
		elsif cIsNumber(isin[i])
			lengthx = lengthx + 1.0
		else
			isValid = false
			errorMessage.string = "ISIN can only contain alpha-numeric characters.".split("")
		end
		i = i + 1.0
	end

	if isValid
		isinNumericReference.string = Array.new(lengthx)

		pos = 0.0

		i = 0.0
		while(i < isin.length)
			ISINSymbolToCode(isin[i], code, errorMessage)

			isinNumericReference.string[pos] = code.string[0]
			pos = pos + 1.0
			if code.string.length == 2.0
				isinNumericReference.string[pos] = code.string[1]
				pos = pos + 1.0
			end
			i = i + 1.0
		end
	end

	return isValid
end


def ISINSymbolToCode(c, stringReference, errorMessage)

	if cIsLetter(c) && cIsUpperCase(c)
		if c == "A"
			stringReference.string = "10".split("")
		elsif c == "B"
			stringReference.string = "11".split("")
		elsif c == "C"
			stringReference.string = "12".split("")
		elsif c == "D"
			stringReference.string = "13".split("")
		elsif c == "E"
			stringReference.string = "14".split("")
		elsif c == "F"
			stringReference.string = "15".split("")
		elsif c == "G"
			stringReference.string = "16".split("")
		elsif c == "H"
			stringReference.string = "17".split("")
		elsif c == "I"
			stringReference.string = "18".split("")
		elsif c == "J"
			stringReference.string = "19".split("")
		elsif c == "K"
			stringReference.string = "20".split("")
		elsif c == "L"
			stringReference.string = "21".split("")
		elsif c == "M"
			stringReference.string = "22".split("")
		elsif c == "N"
			stringReference.string = "23".split("")
		elsif c == "O"
			stringReference.string = "24".split("")
		elsif c == "P"
			stringReference.string = "25".split("")
		elsif c == "Q"
			stringReference.string = "26".split("")
		elsif c == "R"
			stringReference.string = "27".split("")
		elsif c == "S"
			stringReference.string = "28".split("")
		elsif c == "T"
			stringReference.string = "29".split("")
		elsif c == "U"
			stringReference.string = "30".split("")
		elsif c == "V"
			stringReference.string = "31".split("")
		elsif c == "W"
			stringReference.string = "32".split("")
		elsif c == "X"
			stringReference.string = "33".split("")
		elsif c == "Y"
			stringReference.string = "34".split("")
		elsif c == "Z"
			stringReference.string = "35".split("")
		end

		isValid = true
	elsif cIsNumber(c)
		if c == "0"
			stringReference.string = "0".split("")
		elsif c == "1"
			stringReference.string = "1".split("")
		elsif c == "2"
			stringReference.string = "2".split("")
		elsif c == "3"
			stringReference.string = "3".split("")
		elsif c == "4"
			stringReference.string = "4".split("")
		elsif c == "5"
			stringReference.string = "5".split("")
		elsif c == "6"
			stringReference.string = "6".split("")
		elsif c == "7"
			stringReference.string = "7".split("")
		elsif c == "8"
			stringReference.string = "8".split("")
		elsif c == "9"
			stringReference.string = "9".split("")
		end

		isValid = true
	else
		isValid = false
		errorMessage.string = "Character is not an ISIN alpha-character.".split("")
	end

	return isValid
end


def GenerateBarcodeEAN13(code, widthInMm, heightInMm, pixelsPerMm)

	h = Round(heightInMm*pixelsPerMm)
	w = Round(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, GetWhite())

	zoom100 = (11.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0*6.0 + 7.0)*0.33

	zoom = widthInMm.to_f / zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0.to_f / 37.0
	textQuietZone = textheight*5.0.to_f / 100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm.to_f / 2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = (moduleWidthPixels).floor
	leftQuietZoneWholePixels = 11.0*moduleWidthWholePixels
	leftQuietZonePixels = 11.0*moduleWidthPixels
	group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*6.0 + 4.0)*moduleWidthPixels
	betweenCharatcers = charwidth*92.0.to_f / 100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage((w*moduleWidthWholePixels.to_f / moduleWidthPixels).ceil, h, GetWhite())

	counterReference = CreateNumberReference(leftQuietZoneWholePixels)

	group1Pattern = GetEAN13Group1Pattern(code[0])

	# Start symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	i = 1.0
	while(i < code.length)
		c = code[i]
		if i <= 6.0
			type = group1Pattern[i - 1.0]
			if type == "L"
				widths = GetUPCLCodeWidths(c)
			else
				widths = GetUPCGCodeWidths(c)
			end
		else
			widths = GetUPCRCodeWidths(c)
		end
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

		if i == 6.0
			symbolWidths = GetUPCWidths(11.0)
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
		end
		i = i + 1.0
	end

	# Checksum
	checksum = GetCalculateUPCChecksum(code)
	characterReference = CharacterReference.new
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
	character = characterReference.characterValue
	delete(characterReference)
	symbolWidths = GetUPCRCodeWidths(character)
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels)

	# Stop symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
	DrawImageOnImage(image, barcode, 0.0, 0.0)

	# Draw digits
	i = 0.0
	while(i < code.length)
		digit = GetNumberFromNumberCharacterForBase(code[i], 10.0)
		if i == 0.0
			DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
		elsif i <= 6.0
			DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		else
			DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		end
		i = i + 1.0
	end
	DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	return image
end


def GetEAN13Group1Pattern(code)

	spaces = "".split("")

	if code == "0"
		spaces = "LLLLLL".split("")
	end
	if code == "1"
		spaces = "LLGLGG".split("")
	end
	if code == "2"
		spaces = "LLGGLG".split("")
	end
	if code == "3"
		spaces = "LLGGGL".split("")
	end
	if code == "4"
		spaces = "LGLLGG".split("")
	end
	if code == "5"
		spaces = "LGGLLG".split("")
	end
	if code == "6"
		spaces = "LGGGLL".split("")
	end
	if code == "7"
		spaces = "LGLGLG".split("")
	end
	if code == "8"
		spaces = "LGLGGL".split("")
	end
	if code == "9"
		spaces = "LGGLGL".split("")
	end

	return spaces
end


def GenerateBarcodeEAN8(code, widthInMm, heightInMm, pixelsPerMm)

	h = Round(heightInMm*pixelsPerMm)
	w = Round(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, GetWhite())

	zoom100 = (3.0 + 3.0 + 7.0*4.0 + 5.0 + 7.0*4.0 + 3.0 + 3.0)*0.33

	zoom = widthInMm.to_f / zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0.to_f / 37.0
	textQuietZone = textheight*5.0.to_f / 100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm.to_f / 2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = (moduleWidthPixels).floor
	leftQuietZoneWholePixels = 3.0*moduleWidthWholePixels
	leftQuietZonePixels = 3.0*moduleWidthPixels
	group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*3.0 + 4.0)*moduleWidthPixels
	betweenCharatcers = charwidth*92.0.to_f / 100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage((w*moduleWidthWholePixels.to_f / moduleWidthPixels).ceil, h, GetWhite())

	counterReference = CreateNumberReference(leftQuietZoneWholePixels)

	# Start symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	i = 0.0
	while(i < code.length)
		c = code[i]
		if i <= 3.0
			widths = GetUPCLCodeWidths(c)
		else
			widths = GetUPCRCodeWidths(c)
		end
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

		if i == 3.0
			symbolWidths = GetUPCWidths(11.0)
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
		end
		i = i + 1.0
	end

	# Checksum
	checksum = GetCalculateUPCChecksum(code)
	characterReference = CharacterReference.new
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
	character = characterReference.characterValue
	delete(characterReference)
	symbolWidths = GetUPCRCodeWidths(character)
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels)

	# Stop symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
	DrawImageOnImage(image, barcode, 0.0, 0.0)

	# Draw digits
	i = 0.0
	while(i < code.length)
		digit = GetNumberFromNumberCharacterForBase(code[i], 10.0)
		if i <= 3.0
			DrawDigitOnBarcode(image, group1x + i*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		else
			DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		end
		i = i + 1.0
	end
	DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	return image
end


def GenerateBarcodeUPCA(code, widthInMm, heightInMm, pixelsPerMm)

	h = Round(heightInMm*pixelsPerMm)
	w = Round(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, GetWhite())

	zoom100 = (9.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0*6.0 + 3.0 + 9.0)*0.33

	zoom = widthInMm.to_f / zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0.to_f / 37.0
	textQuietZone = textheight*5.0.to_f / 100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm.to_f / 2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = (moduleWidthPixels).floor
	leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
	leftQuietZonePixels = 9.0*moduleWidthPixels
	group1x = leftQuietZonePixels + (3.0 + 7.0)*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*5.0 + 5.0)*moduleWidthPixels
	distanceToThirdGroup = distanceToSecondGroup + (7.0*5.0 + 5.0)*moduleWidthPixels
	betweenCharatcers = charwidth*89.0.to_f / 100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage((w*moduleWidthWholePixels.to_f / moduleWidthPixels).ceil, h, GetWhite())

	counterReference = CreateNumberReference(leftQuietZoneWholePixels)

	# Start symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	i = 0.0
	while(i < code.length)
		c = code[i]
		if i <= 5.0
			widths = GetUPCLCodeWidths(c)
		else
			widths = GetUPCRCodeWidths(c)
		end

		if i == 0.0
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, longHeight, counterReference, moduleWidthWholePixels)
		else
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)
		end

		if i == 5.0
			symbolWidths = GetUPCWidths(11.0)
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
		end
		i = i + 1.0
	end

	# Checksum
	checksum = GetCalculateUPCChecksum(code)
	characterReference = CharacterReference.new
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
	character = characterReference.characterValue
	delete(characterReference)
	symbolWidths = GetUPCRCodeWidths(character)
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	# Stop symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
	DrawImageOnImage(image, barcode, 0.0, 0.0)

	# Draw digits
	i = 0.0
	while(i < code.length)
		digit = GetNumberFromNumberCharacterForBase(code[i], 10.0)
		if i == 0.0
			DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
		elsif i <= 5.0
			DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		else
			DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 6.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		end
		i = i + 1.0
	end
	DrawDigitOnBarcode(image, distanceToThirdGroup + (i - 10.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	return image
end


def GetCalculateUPCChecksum(chars)

	numberString = Array.new(1)

	checksum = 0.0
	nextx = true
	nextWeight = 3.0

	i = chars.length - 1.0
	while(i >= 0.0)
		numberString[0] = chars[i]
		value = CreateNumberFromDecimalString(numberString)
		checksum = checksum + value*nextWeight

		if nextx
			nextWeight = 1.0
		else
			nextWeight = 3.0
		end
		nextx = !nextx
		i = i - 1.0
	end

	nearest10 = (checksum.to_f / 10.0).ceil*10.0

	return nearest10 - checksum
end


def GetUPCStartAndStopCode()
	return 10.0
end


def GetEAN13Width()
	return 95.0 + 11.0
end


def GetUPCWidths(code)

	spaces = "".split("")

	if code == 10.0
		spaces = "101".split("")
	end
	if code == 11.0
		spaces = "01010".split("")
	end

	return spaces
end


def DrawBarcodeUPCSymbol(image, widths, h, counterReference, moduleWidthPixels)

	i = 0.0
	while(i < widths.length)
		widthCharacter = widths[i]
		if widthCharacter == "1"
			color = GetBlack()
		else
			color = GetWhite()
		end

		j = 0.0
		while(j < moduleWidthPixels)
			DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, color)
			counterReference.numberValue = counterReference.numberValue + 1.0
			j = j + 1.0
		end
		i = i + 1.0
	end
end


def GetUPCLCodeWidths(code)

	spaces = "".split("")

	if code == "0"
		spaces = "0001101".split("")
	end
	if code == "1"
		spaces = "0011001".split("")
	end
	if code == "2"
		spaces = "0010011".split("")
	end
	if code == "3"
		spaces = "0111101".split("")
	end
	if code == "4"
		spaces = "0100011".split("")
	end
	if code == "5"
		spaces = "0110001".split("")
	end
	if code == "6"
		spaces = "0101111".split("")
	end
	if code == "7"
		spaces = "0111011".split("")
	end
	if code == "8"
		spaces = "0110111".split("")
	end
	if code == "9"
		spaces = "0001011".split("")
	end

	return spaces
end


def GetUPCGCodeWidths(code)

	spaces = "".split("")

	if code == "0"
		spaces = "0100111".split("")
	end
	if code == "1"
		spaces = "0110011".split("")
	end
	if code == "2"
		spaces = "0011011".split("")
	end
	if code == "3"
		spaces = "0100001".split("")
	end
	if code == "4"
		spaces = "0011101".split("")
	end
	if code == "5"
		spaces = "0111001".split("")
	end
	if code == "6"
		spaces = "0000101".split("")
	end
	if code == "7"
		spaces = "0010001".split("")
	end
	if code == "8"
		spaces = "0001001".split("")
	end
	if code == "9"
		spaces = "0010111".split("")
	end
	return spaces
end


def GetUPCRCodeWidths(code)

	spaces = "".split("")

	if code == "0"
		spaces = "1110010".split("")
	end
	if code == "1"
		spaces = "1100110".split("")
	end
	if code == "2"
		spaces = "1101100".split("")
	end
	if code == "3"
		spaces = "1000010".split("")
	end
	if code == "4"
		spaces = "1011100".split("")
	end
	if code == "5"
		spaces = "1001110".split("")
	end
	if code == "6"
		spaces = "1010000".split("")
	end
	if code == "7"
		spaces = "1000100".split("")
	end
	if code == "8"
		spaces = "1001000".split("")
	end
	if code == "9"
		spaces = "1110100".split("")
	end

	return spaces
end


def DrawDigitOnBarcode(image, topx, topy, digit, pixelsPerMm, zoom)

	digitImage = CreateImage(30.0, 37.0, GetWhite())
	DrawDigitCharacter(digitImage, 0.0, 0.0, digit)
	scaled = BilinaerScaleUpFactor(digitImage, pixelsPerMm*zoom.to_f / DPIToDotsPerMm(300.0))
	DrawImageOnImage(image, scaled, (topx).floor, (topy).floor)
	delete(digitImage)
	delete(scaled)
end


def UPCAToUPCE(a)

	e = Array.new(7)
	e[0] = a[0]

	mfg = strSubstring(a, 1.0, 6.0)
	productCode = strSubstring(a, 6.0, 11.0)

	e[1] = mfg[0]
	e[2] = mfg[1]
	if (strSubstringEquals(mfg, 2.0, "000".split("")) || strSubstringEquals(mfg, 2.0, "100".split("")) || strSubstringEquals(mfg, 2.0, "200".split(""))) && productCode[0] == "0" && productCode[1] == "0"
		e[3] = productCode[2]
		e[4] = productCode[3]
		e[5] = productCode[4]
		e[6] = mfg[2]
	elsif strSubstringEquals(mfg, 3.0, "00".split("")) && productCode[0] == "0" && productCode[1] == "0" && productCode[2] == "0"
		e[3] = mfg[2]
		e[4] = productCode[3]
		e[5] = productCode[4]
		e[6] = "3"
	elsif strSubstringEquals(mfg, 4.0, "0".split("")) && productCode[0] == "0" && productCode[1] == "0" && productCode[2] == "0" && productCode[3] == "0"
		e[3] = mfg[2]
		e[4] = mfg[3]
		e[5] = productCode[4]
		e[6] = "4"
	elsif arraysStringsEqual(productCode, "00005".split("")) || arraysStringsEqual(productCode, "00006".split("")) || arraysStringsEqual(productCode, "00006".split("")) || arraysStringsEqual(productCode, "00007".split("")) || arraysStringsEqual(productCode, "00008".split("")) || arraysStringsEqual(productCode, "00009".split(""))
		e[3] = mfg[2]
		e[4] = mfg[3]
		e[5] = mfg[4]
		e[6] = productCode[4]
	end

	return e
end


def UPCEToUPCA(e)

	a = Array.new(11)

	a[0] = e[0]

	if e[6] == "0" || e[6] == "1" || e[6] == "2"
		a[1] = e[1]
		a[2] = e[2]
		a[3] = e[6]
		a[4] = "0"
		a[5] = "0"
		a[6] = "0"
		a[7] = "0"
		a[8] = e[3]
		a[9] = e[4]
		a[10] = e[5]
	elsif e[6] == "3"
		a[1] = e[1]
		a[2] = e[2]
		a[3] = e[3]
		a[4] = "0"
		a[5] = "0"
		a[6] = "0"
		a[7] = "0"
		a[8] = "0"
		a[9] = e[4]
		a[10] = e[5]
	elsif e[6] == "4"
		a[1] = e[1]
		a[2] = e[2]
		a[3] = e[3]
		a[4] = e[4]
		a[5] = "0"
		a[6] = "0"
		a[7] = "0"
		a[8] = "0"
		a[9] = "0"
		a[10] = e[5]
	else
		a[1] = e[1]
		a[2] = e[2]
		a[3] = e[3]
		a[4] = e[4]
		a[5] = e[5]
		a[6] = "0"
		a[7] = "0"
		a[8] = "0"
		a[9] = "0"
		a[10] = e[6]
	end

	return a
end


def GenerateBarcodeUPCE(e, widthInMm, heightInMm, pixelsPerMm)

	h = Round(heightInMm*pixelsPerMm)
	w = Round(widthInMm*pixelsPerMm)

	image = CreateImage(w, h, GetWhite())

	zoom100 = (9.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0)*0.33

	zoom = widthInMm.to_f / zoom100
	textheight = zoom*3.08
	charwidth = textheight*30.0.to_f / 37.0
	textQuietZone = textheight*5.0.to_f / 100.0
	textY = h - textheight*pixelsPerMm
	shortHeight = textY - textQuietZone*pixelsPerMm
	longHeight = textY + (textQuietZone + textheight)*pixelsPerMm.to_f / 2.0
	moduleWidthPixels = 0.33*zoom*pixelsPerMm
	moduleWidthWholePixels = (moduleWidthPixels).floor
	leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
	leftQuietZonePixels = 9.0*moduleWidthPixels
	group1x = leftQuietZonePixels + (3.0 + 1.0)*moduleWidthPixels
	distanceToSecondGroup = group1x + (7.0*6.0 + 5.0)*moduleWidthPixels
	betweenCharatcers = charwidth*89.0.to_f / 100.0*pixelsPerMm

	uninterpolatedBarcode = CreateImage((w*moduleWidthWholePixels.to_f / moduleWidthPixels).ceil, h, GetWhite())

	counterReference = CreateNumberReference(leftQuietZoneWholePixels)

	# Checksum
	a = UPCEToUPCA(e)
	checksum = GetCalculateUPCChecksum(a)
	characterReference = CharacterReference.new
	GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
	character = characterReference.characterValue

	# Start symbol
	symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

	pattern = GetUPCEPattern(character, e[0])

	i = 1.0
	while(i < e.length)
		c = e[i]
		type = pattern[i - 1.0]
		if type == "O"
			widths = GetUPCLCodeWidths(c)
		else
			widths = GetUPCGCodeWidths(c)
		end

		DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)
		i = i + 1.0
	end

	# Stop symbol
	DrawBarcodeUPCSymbol(uninterpolatedBarcode, "010101".split(""), longHeight, counterReference, moduleWidthWholePixels)

	barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
	DrawImageOnImage(image, barcode, 0.0, 0.0)

	# Draw digits
	i = 0.0
	while(i < e.length)
		digit = GetNumberFromNumberCharacterForBase(e[i], 10.0)
		if i == 0.0
			DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
		elsif i <= 6.0
			DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
		end
		i = i + 1.0
	end
	DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

	return image
end


def GetUPCEPattern(check, system)

	spaces = "".split("")

	if system == "0"
		if check == "0"
			spaces = "EEEOOO".split("")
		end
		if check == "1"
			spaces = "EEOEOO".split("")
		end
		if check == "2"
			spaces = "EEOOEO".split("")
		end
		if check == "3"
			spaces = "EEOOOE".split("")
		end
		if check == "4"
			spaces = "EOEEOO".split("")
		end
		if check == "5"
			spaces = "EOOEEO".split("")
		end
		if check == "6"
			spaces = "EOOOEE".split("")
		end
		if check == "7"
			spaces = "EOEOEO".split("")
		end
		if check == "8"
			spaces = "EOEOOE".split("")
		end
		if check == "9"
			spaces = "EOOEOE".split("")
		end
	elsif system == "1"
		if check == "0"
			spaces = "OOOEEE".split("")
		end
		if check == "1"
			spaces = "OOEOEE".split("")
		end
		if check == "2"
			spaces = "OOEEOE".split("")
		end
		if check == "3"
			spaces = "OOEEEO".split("")
		end
		if check == "4"
			spaces = "OEOOEE".split("")
		end
		if check == "5"
			spaces = "OEEOOE".split("")
		end
		if check == "6"
			spaces = "OEEEOO".split("")
		end
		if check == "7"
			spaces = "OEOEOE".split("")
		end
		if check == "8"
			spaces = "OEOEEO".split("")
		end
		if check == "9"
			spaces = "OEEOEO".split("")
		end
	end

	return spaces
end


def Code128EncodingParts(cs)

	parts = Array.new(cs.length)

	i = 0.0
	while(i < cs.length)
		c = cs[i]

		if IsCodeA(c) && IsCodeB(c) && IsCodeC(c)
			parts[i] = "X"
		elsif IsCodeA(c) && IsCodeB(c)
			parts[i] = "D"
		elsif IsCodeA(c)
			parts[i] = "A"
		elsif IsCodeB(c)
			parts[i] = "B"
		end
		i = i + 1.0
	end

	return parts
end


def IsCodeA(c)
	return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || charIsCode128ASymbol(c)
end


def IsCodeB(c)
	return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || cIsLowerCase(c) || charIsCode128BSymbol(c)
end


def IsCodeC(c)
	return cIsNumber(c)
end


def Code128EncodingSections(cs)

	parts = Code128EncodingParts(cs)

	sections = arraysCreateString(cs.length, " ")
	counts = arraysCreateNumberArray(cs.length, 0.0)
	nextx = 0.0

	# Pick C-sections.
	i = 0.0
	while(i < cs.length)
		p = parts[i]

		if p == "X"
			done = false
			c = 0.0
			while(i + c < cs.length && !done)
				if parts[i + c] != "X"
					done = true
					c = c - 1.0
				end
				c = c + 1.0
			end
			# Compress 2 or more if first, or 4 or more if not.
			if c >= 4.0 || (i == 0.0 && c >= 2.0)
				sections[nextx] = "C"
				c = (c.to_f / 2.0).floor*2.0
				counts[nextx] = c
				nextx = nextx + 1.0
				i = i + c - 1.0
			else
				sections[nextx] = "D"
				counts[nextx] = 1.0
				nextx = nextx + 1.0
			end
		else
			sections[nextx] = p
			counts[nextx] = 1.0
			nextx = nextx + 1.0
		end
		i = i + 1.0
	end

	# Trim
	currentSections = Array.new(nextx)
	i = 0.0
	while(i < nextx)
		currentSections[i] = sections[i]
		i = i + 1.0
	end

	currentCounts = Array.new(nextx)
	i = 0.0
	while(i < nextx)
		currentCounts[i] = counts[i]
		i = i + 1.0
	end

	sections = arraysCreateString(cs.length, " ")
	counts = arraysCreateNumberArray(cs.length, 0.0)

	# Compress A+A&D and B+B&D
	nextx = 0.0
	i = 0.0
	while(i < currentSections.length)
		p = currentSections[i]

		if p == "C" || p == "D"
			sections[nextx] = p
			counts[nextx] = currentCounts[i]
			nextx = nextx + 1.0
		elsif p == "A"
			sum = 0.0
			done = false
			c = 0.0
			while(i + c < currentSections.length && !done)
				if currentSections[i + c] == "A" || currentSections[i + c] == "D"
					sum = sum + currentCounts[i + c]
				else
					done = true
					c = c - 1.0
				end
				c = c + 1.0
			end
			sections[nextx] = p
			counts[nextx] = sum
			nextx = nextx + 1.0
			i = i + c - 1.0
		elsif p == "B"
			sum = 0.0
			done = false
			c = 0.0
			while(i + c < currentSections.length && !done)
				if currentSections[i + c] == "B" || currentSections[i + c] == "D"
					sum = sum + currentCounts[i + c]
				else
					done = true
					c = c - 1.0
				end
				c = c + 1.0
			end
			sections[nextx] = p
			counts[nextx] = sum
			nextx = nextx + 1.0
			i = i + c - 1.0
		end
		i = i + 1.0
	end

	# Trim
	currentSections = Array.new(nextx)
	i = 0.0
	while(i < nextx)
		currentSections[i] = sections[i]
		i = i + 1.0
	end

	currentCounts = Array.new(nextx)
	i = 0.0
	while(i < nextx)
		currentCounts[i] = counts[i]
		i = i + 1.0
	end

	sections = arraysCreateString(cs.length, " ")
	counts = arraysCreateNumberArray(cs.length, 0.0)

	# Compress D+A&D and D+B&D
	nextx = 0.0
	i = 0.0
	while(i < currentSections.length)
		p = currentSections[i]

		sum = 0.0

		if p == "C" || p == "A" || p == "B"
			sections[nextx] = p
			counts[nextx] = currentCounts[i]
			nextx = nextx + 1.0
		elsif p == "D"
			selected = " "
			done = false

			sum = 0.0
			c = 0.0
			while(i + c < currentSections.length && !done)
				p = currentSections[i + c]

				if p == "D"
					sum = sum + currentCounts[i + c]
				elsif p == "A" || p == "B"
					if selected == " "
						selected = p
						sum = sum + currentCounts[i + c]
					elsif p != selected
						done = true
						c = c - 1.0
					else
						sum = sum + currentCounts[i + c]
					end
				else
					done = true
					c = c - 1.0
				end
				c = c + 1.0
			end
			if selected == " "
				selected = "A"
			end
			sections[nextx] = selected
			counts[nextx] = sum
			nextx = nextx + 1.0
			i = i + c - 1.0
		end
		i = i + 1.0
	end

	# Trim
	currentSections = Array.new(nextx)
	i = 0.0
	while(i < nextx)
		currentSections[i] = sections[i]
		i = i + 1.0
	end
	sections = currentSections

	currentCounts = Array.new(nextx)
	i = 0.0
	while(i < nextx)
		currentCounts[i] = counts[i]
		i = i + 1.0
	end
	counts = currentCounts

	# Done
	sectionsStruct = Sections.new
	sectionsStruct.codes = sections
	sectionsStruct.counts = counts

	return sectionsStruct
end


def Code128Encode(cs)

	coded = Array.new(cs.length + 2.0 + 1.0 + 1.0 + 10.0)
	cnr = 0.0
	isFirst = true
	nextx = 0.0

	lastSection = "0"

	sections = Code128EncodingSections(cs)

	n = 0.0
	while(n < sections.codes.length)
		section = sections.codes[n]
		count = sections.counts[n]

		# start code
		if isFirst
			if section == "A"
				coded[nextx] = 103.0
			elsif section == "B"
				coded[nextx] = 104.0
			elsif section == "C"
				coded[nextx] = 105.0
			end
			nextx = nextx + 1.0

			isFirst = false
		end

		# Encode
		if section == "A"
			if lastSection == "B" || lastSection == "C"
				coded[nextx] = 101.0
				nextx = nextx + 1.0
			end

			k = 0.0
			while(k < count)
				coded[nextx] = GetCode128ACode(cs[cnr + k])
				nextx = nextx + 1.0
				k = k + 1.0
			end
			cnr = cnr + count
		elsif section == "B"
			if lastSection == "A" || lastSection == "C"
				coded[nextx] = 100.0
				nextx = nextx + 1.0
			end

			k = 0.0
			while(k < count)
				coded[nextx] = GetCode128BCode(cs[cnr + k])
				nextx = nextx + 1.0
				k = k + 1.0
			end
			cnr = cnr + count
		elsif section == "C"
			if lastSection == "A" || lastSection == "B"
				coded[nextx] = 99.0
				nextx = nextx + 1.0
			end

			k = 0.0
			while(k < count)
				coded[nextx] = GetCode128CCode(cs[cnr + k], cs[cnr + k + 1.0])
				nextx = nextx + 1.0
				k = k + 2.0
			end
			cnr = cnr + count
		end

		lastSection = section
		n = n + 1.0
	end

	coded[nextx] = CalculateCode128ChecksumWithLength(coded, nextx)
	nextx = nextx + 1.0

	coded[nextx] = 108.0
	nextx = nextx + 1.0

	# trim array
	nextCoded = Array.new(nextx)
	k = 0.0
	while(k < nextx)
		nextCoded[k] = coded[k]
		k = k + 1.0
	end
	delete(coded)
	coded = nextCoded

	return coded
end


def GetCode128ACode(c)

	n = (c).ord

	if n >= 32.0 && n <= 95.0
		code = n - 32.0
	elsif n >= 0.0 && n <= 31.0
		code = 64.0 + n
	else
		code = -1.0
	end

	return code
end


def GetCode128BCode(c)

	n = (c).ord

	if n >= 32.0 && n <= 126.0
		code = n - 32.0
	elsif n == 127.0
		code = 95.0
	else
		code = -1.0
	end

	return code
end


def GetCode128CCode(c1, c2)

	n1 = GetNumberFromNumberCharacterForBase(c1, 10.0)
	n2 = GetNumberFromNumberCharacterForBase(c2, 10.0)

	return n1*10.0 + n2
end


def charIsCode128AandBSymbol(character)

	common = false
	if character == " "
		common = true
	elsif character == "!"
		common = true
	elsif character == "\""
		common = true
	elsif character == "#"
		common = true
	elsif character == "$"
		common = true
	elsif character == "%"
		common = true
	elsif character == "&"
		common = true
	elsif character == "\'"
		common = true
	elsif character == "("
		common = true
	elsif character == ")"
		common = true
	elsif character == "*"
		common = true
	elsif character == "+"
		common = true
	elsif character == ","
		common = true
	elsif character == "-"
		common = true
	elsif character == "."
		common = true
	elsif character == "/"
		common = true
	elsif character == ":"
		common = true
	elsif character == ";"
		common = true
	elsif character == "<"
		common = true
	elsif character == "="
		common = true
	elsif character == ">"
		common = true
	elsif character == "?"
		common = true
	elsif character == "@"
		common = true
	elsif character == "["
		common = true
	elsif character == "\\"
		common = true
	elsif character == "]"
		common = true
	elsif character == "^"
		common = true
	elsif character == "_"
		common = true
	end

	return common
end


def charIsCode128BSymbol(character)

	codeB = false
	if character == "`"
		codeB = true
	elsif character == "{"
		codeB = true
	elsif character == "|"
		codeB = true
	elsif character == "}"
		codeB = true
	elsif character == "~"
		codeB = true
	elsif (character).ord == 127.0
		# del
		codeB = true
	end

	return codeB
end


def charIsCode128ASymbol(character)

	n = (character).ord

	codeA = false
	if n >= 0.0 && n <= 31.0
		codeA = true
	end

	return codeA
end


def GenerateBarcodeCode128(chars, height)

	image = RGBABitmapImage.new
	errorMessages = CreateStringReference("".split(""))

	success = GenerateBarcodeCode128AllParams(chars, height, 2.0, image, errorMessages)

	delete(errorMessages)

	return image
end


def GenerateBarcodeCode128AllParams(chars, height, moduleWidth, image, errorMessages)

	success = IsValidCode128Data(chars, height, moduleWidth, errorMessages)

	if success
		codes = Code128Encode(chars)

		h = height
		w = CalculateCode128Width(codes, moduleWidth)

		newImage = CreateImage(w, h, GetWhite())
		image.x = newImage.x
		delete(newImage)

		counterReference = NumberReference.new

		# Start Quiet Zone
		counterReference.numberValue = 10.0*moduleWidth

		i = 0.0
		while(i < codes.length)
			code = codes[i]
			DrawBarcodeSymbol(image, code, h, moduleWidth, counterReference)
			i = i + 1.0
		end

		# End Quiet Zone
		counterReference.numberValue = counterReference.numberValue + 10.0*moduleWidth
	end

	return success
end


def IsValidCode128Data(chars, height, moduleWidth, errorMessages)

	validCharacters = 0.0

	i = 0.0
	while(i < chars.length)
		if (chars[i]).ord >= 0.0 && (chars[i]).ord <= 127.0
			validCharacters = validCharacters + 1.0
		end
		i = i + 1.0
	end

	if validCharacters == chars.length

		if height > 0.0
			if Truncate(height) == height
				if moduleWidth > 0.0
					if Truncate(moduleWidth) == moduleWidth
						valid = true
					else
						valid = false
						errorMessages.string = strAppendString(errorMessages.string, "Module width must be a whole number of pixels.".split(""))
					end
				else
					valid = false
					errorMessages.string = strAppendString(errorMessages.string, "Module width must be at least one pixel.".split(""))
				end
			else
				valid = false
				errorMessages.string = strAppendString(errorMessages.string, "Height must be a whole number of pixels.".split(""))
			end
		else
			valid = false
			errorMessages.string = strAppendString(errorMessages.string, "Height must be at least one pixel.".split(""))
		end
	else
		valid = false
		errorMessages.string = strAppendString(errorMessages.string, "Input data contains character invalid for this implementation of Code 128. Only 0-127 (inclusive) supported in this implementation.".split(""))
	end

	return valid
end


def CalculateCode128Width(codes, moduleWidth)

	# Quiet Zone + 11 * codes + stop symbol extra + Quiet Zone.
	width = (10.0 + codes.length*11.0 + 2.0 + 10.0)*moduleWidth

	return width
end


def CalculateCode128Checksum(codes)
	return CalculateCode128ChecksumWithLength(codes, codes.length)
end


def CalculateCode128ChecksumWithLength(codes, lengthx)

	checksum = 0.0

	position = 1.0
	i = 0.0
	while(i < lengthx)
		if i > 1.0
			position = position + 1.0
		end
		value = codes[i]
		checksum = checksum + position*value
		i = i + 1.0
	end

	return checksum%103.0
end


def DrawBarcodeSymbol(image, barcodeNr, h, moduleWidth, counterReference)

	widths = GetCode128Widths(barcodeNr)

	nextColor = GetBlack()
	nextx = true

	i = 0.0
	while(i < widths.length)
		widthCharacter = widths[i]
		width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

		j = 0.0
		while(j < width)
			k = 0.0
			while(k < moduleWidth)
				DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
				counterReference.numberValue = counterReference.numberValue + 1.0
				k = k + 1.0
			end
			j = j + 1.0
		end

		if nextx
			nextColor = GetWhite()
		else
			nextColor = GetBlack()
		end
		nextx = !nextx
		i = i + 1.0
	end
end


def GetCode128Widths(code)

	spaces = "".split("")

	if code == 0.0
		spaces = "212222".split("")
	end
	if code == 1.0
		spaces = "222122".split("")
	end
	if code == 2.0
		spaces = "222221".split("")
	end
	if code == 3.0
		spaces = "121223".split("")
	end
	if code == 4.0
		spaces = "121322".split("")
	end
	if code == 5.0
		spaces = "131222".split("")
	end
	if code == 6.0
		spaces = "122213".split("")
	end
	if code == 7.0
		spaces = "122312".split("")
	end
	if code == 8.0
		spaces = "132212".split("")
	end
	if code == 9.0
		spaces = "221213".split("")
	end
	if code == 10.0
		spaces = "221312".split("")
	end
	if code == 11.0
		spaces = "231212".split("")
	end
	if code == 12.0
		spaces = "112232".split("")
	end
	if code == 13.0
		spaces = "122132".split("")
	end
	if code == 14.0
		spaces = "122231".split("")
	end
	if code == 15.0
		spaces = "113222".split("")
	end
	if code == 16.0
		spaces = "123122".split("")
	end
	if code == 17.0
		spaces = "123221".split("")
	end
	if code == 18.0
		spaces = "223211".split("")
	end
	if code == 19.0
		spaces = "221132".split("")
	end
	if code == 20.0
		spaces = "221231".split("")
	end
	if code == 21.0
		spaces = "213212".split("")
	end
	if code == 22.0
		spaces = "223112".split("")
	end
	if code == 23.0
		spaces = "312131".split("")
	end
	if code == 24.0
		spaces = "311222".split("")
	end
	if code == 25.0
		spaces = "321122".split("")
	end
	if code == 26.0
		spaces = "321221".split("")
	end
	if code == 27.0
		spaces = "312212".split("")
	end
	if code == 28.0
		spaces = "322112".split("")
	end
	if code == 29.0
		spaces = "322211".split("")
	end
	if code == 30.0
		spaces = "212123".split("")
	end
	if code == 31.0
		spaces = "212321".split("")
	end
	if code == 32.0
		spaces = "232121".split("")
	end
	if code == 33.0
		spaces = "111323".split("")
	end
	if code == 34.0
		spaces = "131123".split("")
	end
	if code == 35.0
		spaces = "131321".split("")
	end
	if code == 36.0
		spaces = "112313".split("")
	end
	if code == 37.0
		spaces = "132113".split("")
	end
	if code == 38.0
		spaces = "132311".split("")
	end
	if code == 39.0
		spaces = "211313".split("")
	end
	if code == 40.0
		spaces = "231113".split("")
	end
	if code == 41.0
		spaces = "231311".split("")
	end
	if code == 42.0
		spaces = "112133".split("")
	end
	if code == 43.0
		spaces = "112331".split("")
	end
	if code == 44.0
		spaces = "132131".split("")
	end
	if code == 45.0
		spaces = "113123".split("")
	end
	if code == 46.0
		spaces = "113321".split("")
	end
	if code == 47.0
		spaces = "133121".split("")
	end
	if code == 48.0
		spaces = "313121".split("")
	end
	if code == 49.0
		spaces = "211331".split("")
	end
	if code == 50.0
		spaces = "231131".split("")
	end
	if code == 51.0
		spaces = "213113".split("")
	end
	if code == 52.0
		spaces = "213311".split("")
	end
	if code == 53.0
		spaces = "213131".split("")
	end
	if code == 54.0
		spaces = "311123".split("")
	end
	if code == 55.0
		spaces = "311321".split("")
	end
	if code == 56.0
		spaces = "331121".split("")
	end
	if code == 57.0
		spaces = "312113".split("")
	end
	if code == 58.0
		spaces = "312311".split("")
	end
	if code == 59.0
		spaces = "332111".split("")
	end
	if code == 60.0
		spaces = "314111".split("")
	end
	if code == 61.0
		spaces = "221411".split("")
	end
	if code == 62.0
		spaces = "431111".split("")
	end
	if code == 63.0
		spaces = "111224".split("")
	end
	if code == 64.0
		spaces = "111422".split("")
	end
	if code == 65.0
		spaces = "121124".split("")
	end
	if code == 66.0
		spaces = "121421".split("")
	end
	if code == 67.0
		spaces = "141122".split("")
	end
	if code == 68.0
		spaces = "141221".split("")
	end
	if code == 69.0
		spaces = "112214".split("")
	end
	if code == 70.0
		spaces = "112412".split("")
	end
	if code == 71.0
		spaces = "122114".split("")
	end
	if code == 72.0
		spaces = "122411".split("")
	end
	if code == 73.0
		spaces = "142112".split("")
	end
	if code == 74.0
		spaces = "142211".split("")
	end
	if code == 75.0
		spaces = "241211".split("")
	end
	if code == 76.0
		spaces = "221114".split("")
	end
	if code == 77.0
		spaces = "413111".split("")
	end
	if code == 78.0
		spaces = "241112".split("")
	end
	if code == 79.0
		spaces = "134111".split("")
	end
	if code == 80.0
		spaces = "111242".split("")
	end
	if code == 81.0
		spaces = "121142".split("")
	end
	if code == 82.0
		spaces = "121241".split("")
	end
	if code == 83.0
		spaces = "114212".split("")
	end
	if code == 84.0
		spaces = "124112".split("")
	end
	if code == 85.0
		spaces = "124211".split("")
	end
	if code == 86.0
		spaces = "411212".split("")
	end
	if code == 87.0
		spaces = "421112".split("")
	end
	if code == 88.0
		spaces = "421211".split("")
	end
	if code == 89.0
		spaces = "212141".split("")
	end
	if code == 90.0
		spaces = "214121".split("")
	end
	if code == 91.0
		spaces = "412121".split("")
	end
	if code == 92.0
		spaces = "111143".split("")
	end
	if code == 93.0
		spaces = "111341".split("")
	end
	if code == 94.0
		spaces = "131141".split("")
	end
	if code == 95.0
		spaces = "114113".split("")
	end
	if code == 96.0
		spaces = "114311".split("")
	end
	if code == 97.0
		spaces = "411113".split("")
	end
	if code == 98.0
		spaces = "411311".split("")
	end
	if code == 99.0
		spaces = "113141".split("")
	end
	if code == 100.0
		spaces = "114131".split("")
	end
	if code == 101.0
		spaces = "311141".split("")
	end
	if code == 102.0
		spaces = "411131".split("")
	end
	if code == 103.0
		spaces = "211412".split("")
	end
	if code == 104.0
		spaces = "211214".split("")
	end
	if code == 105.0
		spaces = "211232".split("")
	end
	if code == 106.0
		spaces = "233111".split("")
	end
	if code == 107.0
		spaces = "211133".split("")
	end
	if code == 108.0
		spaces = "2331112".split("")
	end

	return spaces
end


def GenerateBarcodeCode39(chars, height)
	return GenerateBarcodeCode39WithChecksumOption(chars, height, false)
end


def GenerateBarcodeCode39WithChecksumOption(chars, height, includeChecksum)

	h = height
	w = CalculateCode39Width(chars, includeChecksum)*2.0

	image = CreateImage(w, h, GetWhite())

	counterReference = CreateNumberReference(10.0*2.0)

	# Start symbol
	DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, true)

	i = 0.0
	while(i < chars.length)
		c = chars[i]
		barcodeNr = AsciiToCode39(c)
		DrawBarcode39Symbol(image, barcodeNr, h, counterReference, true)
		i = i + 1.0
	end

	if includeChecksum
		checksum = CalculateCode39Checksum(chars)
		DrawBarcode39Symbol(image, checksum, h, counterReference, true)
	end

	# Stop symbol
	DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, false)

	return image
end


def CalculateCode39Checksum(chars)

	checksum = 0.0

	i = 0.0
	while(i < chars.length)
		c = chars[i]
		value = AsciiToCode39(c)
		checksum = checksum + value
		i = i + 1.0
	end

	return checksum%43.0
end


def Get39StartAndStopCode()
	return 43.0
end


def CalculateCode39Width(chars, includeChecksum)

	# quiet zone + start + 1 + 12*characters + 1*characters + stop + quiet zone
	width = 10.0 + 12.0 + 1.0 + chars.length*12.0 + chars.length*1.0 + 12.0 + 10.0

	if includeChecksum
		width = width + 1.0 + 12.0
	end

	return width
end


def DrawBarcode39Symbol(image, barcodeNr, h, counterReference, addSeparator)

	widths = GetCode39Widths(barcodeNr)

	nextColor = GetBlack()
	nextx = true

	j = 0.0
	while(j < widths.length)
		widthCharacter = widths[j]
		width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

		k = 0.0
		while(k < width)
			DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
			counterReference.numberValue = counterReference.numberValue + 1.0
			DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
			counterReference.numberValue = counterReference.numberValue + 1.0
			k = k + 1.0
		end

		if nextx
			nextColor = GetWhite()
		else
			nextColor = GetBlack()
		end
		nextx = !nextx
		j = j + 1.0
	end

	# Space
	if addSeparator
		DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, GetWhite())
		counterReference.numberValue = counterReference.numberValue + 1.0
		DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, GetWhite())
		counterReference.numberValue = counterReference.numberValue + 1.0
	end
end


def GetCode39Widths(code)

	spaces = "".split("")

	if code == 0.0
		spaces = "111221211".split("")
	end
	if code == 1.0
		spaces = "211211112".split("")
	end
	if code == 2.0
		spaces = "112211112".split("")
	end
	if code == 3.0
		spaces = "212211111".split("")
	end
	if code == 4.0
		spaces = "111221112".split("")
	end
	if code == 5.0
		spaces = "211221111".split("")
	end
	if code == 6.0
		spaces = "112221111".split("")
	end
	if code == 7.0
		spaces = "111211212".split("")
	end
	if code == 8.0
		spaces = "211211211".split("")
	end
	if code == 9.0
		spaces = "112211211".split("")
	end
	if code == 10.0
		spaces = "211112112".split("")
	end
	if code == 11.0
		spaces = "112112112".split("")
	end
	if code == 12.0
		spaces = "212112111".split("")
	end
	if code == 13.0
		spaces = "111122112".split("")
	end
	if code == 14.0
		spaces = "211122111".split("")
	end
	if code == 15.0
		spaces = "112122111".split("")
	end
	if code == 16.0
		spaces = "111112212".split("")
	end
	if code == 17.0
		spaces = "211112211".split("")
	end
	if code == 18.0
		spaces = "112112211".split("")
	end
	if code == 19.0
		spaces = "111122211".split("")
	end
	if code == 20.0
		spaces = "211111122".split("")
	end
	if code == 21.0
		spaces = "112111122".split("")
	end
	if code == 22.0
		spaces = "212111121".split("")
	end
	if code == 23.0
		spaces = "111121122".split("")
	end
	if code == 24.0
		spaces = "211121121".split("")
	end
	if code == 25.0
		spaces = "112121121".split("")
	end
	if code == 26.0
		spaces = "111111222".split("")
	end
	if code == 27.0
		spaces = "211111221".split("")
	end
	if code == 28.0
		spaces = "112111221".split("")
	end
	if code == 29.0
		spaces = "111121221".split("")
	end
	if code == 30.0
		spaces = "221111112".split("")
	end
	if code == 31.0
		spaces = "122111112".split("")
	end
	if code == 32.0
		spaces = "222111111".split("")
	end
	if code == 33.0
		spaces = "121121112".split("")
	end
	if code == 34.0
		spaces = "221121111".split("")
	end
	if code == 35.0
		spaces = "122121111".split("")
	end
	if code == 36.0
		spaces = "121111212".split("")
	end
	if code == 37.0
		spaces = "221111211".split("")
	end
	if code == 38.0
		spaces = "122111211".split("")
	end
	if code == 39.0
		spaces = "121212111".split("")
	end
	if code == 40.0
		spaces = "121211121".split("")
	end
	if code == 41.0
		spaces = "121112121".split("")
	end
	if code == 42.0
		spaces = "111212121".split("")
	end
	if code == 43.0
		spaces = "121121211".split("")
	end

	return spaces
end


def AsciiToCode39(c)

	asciiToNrTable = GetAsciiToCode39Table()
	nr = (c).ord

	return asciiToNrTable[nr]
end


def GetAsciiToCode39Table()

	c = Array.new(256)

	c["0".ord] = 0.0
	c["1".ord] = 1.0
	c["2".ord] = 2.0
	c["3".ord] = 3.0
	c["4".ord] = 4.0
	c["5".ord] = 5.0
	c["6".ord] = 6.0
	c["7".ord] = 7.0
	c["8".ord] = 8.0
	c["9".ord] = 9.0
	c["A".ord] = 10.0
	c["B".ord] = 11.0
	c["C".ord] = 12.0
	c["D".ord] = 13.0
	c["E".ord] = 14.0
	c["F".ord] = 15.0
	c["G".ord] = 16.0
	c["H".ord] = 17.0
	c["I".ord] = 18.0
	c["J".ord] = 19.0
	c["K".ord] = 20.0
	c["L".ord] = 21.0
	c["M".ord] = 22.0
	c["N".ord] = 23.0
	c["O".ord] = 24.0
	c["P".ord] = 25.0
	c["Q".ord] = 26.0
	c["R".ord] = 27.0
	c["S".ord] = 28.0
	c["T".ord] = 29.0
	c["U".ord] = 30.0
	c["V".ord] = 31.0
	c["W".ord] = 32.0
	c["X".ord] = 33.0
	c["Y".ord] = 34.0
	c["Z".ord] = 35.0
	c["-".ord] = 36.0
	c[".".ord] = 37.0
	c[" ".ord] = 38.0
	c["$".ord] = 39.0
	c["/".ord] = 40.0
	c["+".ord] = 41.0
	c["%".ord] = 42.0
	c["*".ord] = 43.0

	return c
end


def IsQRNumericString(chars)

	valid = true

	i = 0.0
	while(i < chars.length)
		if IsQRNumericCharacter(chars[i])
		else
			valid = false
		end
		i = i + 1.0
	end

	return valid
end


def IsQRNumericCharacter(aChar)
	return cIsNumber(aChar)
end


def IsQRAlphanumericString(chars)

	valid = true

	i = 0.0
	while(i < chars.length)
		c = chars[i]

		valid = IsQRAlphanumericCharacter(c)
		i = i + 1.0
	end

	return valid
end


def IsQRAlphanumericCharacter(c)

	valid = true

	if cIsNumber(c)
	elsif IsQRAlphaUppercase(c)
	elsif c == " "
	elsif c == "$"
	elsif c == "%"
	elsif c == "*"
	elsif c == "+"
	elsif c == "-"
	elsif c == "."
	elsif c == "/"
	elsif c == ":"
	else
		valid = false
	end
	return valid
end


def IsQRJIS8Character(c)

	code = (c).ord

	if code >= 0.0 && code < 128.0
		valid = true
	else
		valid = false
	end

	return valid
end


def IsQRAlphaUppercase(character)

	isUpper = true
	if character == "A"
	elsif character == "B"
	elsif character == "C"
	elsif character == "D"
	elsif character == "E"
	elsif character == "F"
	elsif character == "G"
	elsif character == "H"
	elsif character == "I"
	elsif character == "J"
	elsif character == "K"
	elsif character == "L"
	elsif character == "M"
	elsif character == "N"
	elsif character == "O"
	elsif character == "P"
	elsif character == "Q"
	elsif character == "R"
	elsif character == "S"
	elsif character == "T"
	elsif character == "U"
	elsif character == "V"
	elsif character == "W"
	elsif character == "X"
	elsif character == "Y"
	elsif character == "Z"
	else
		isUpper = false
	end

	return isUpper
end


def QRAlphanumericToCode(c)

	if c == "0"
		code = 0.0
	elsif c == "1"
		code = 1.0
	elsif c == "2"
		code = 2.0
	elsif c == "3"
		code = 3.0
	elsif c == "4"
		code = 4.0
	elsif c == "5"
		code = 5.0
	elsif c == "6"
		code = 6.0
	elsif c == "7"
		code = 7.0
	elsif c == "8"
		code = 8.0
	elsif c == "9"
		code = 9.0
	elsif c == "A"
		code = 10.0
	elsif c == "B"
		code = 11.0
	elsif c == "C"
		code = 12.0
	elsif c == "D"
		code = 13.0
	elsif c == "E"
		code = 14.0
	elsif c == "F"
		code = 15.0
	elsif c == "G"
		code = 16.0
	elsif c == "H"
		code = 17.0
	elsif c == "I"
		code = 18.0
	elsif c == "J"
		code = 19.0
	elsif c == "K"
		code = 20.0
	elsif c == "L"
		code = 21.0
	elsif c == "M"
		code = 22.0
	elsif c == "N"
		code = 23.0
	elsif c == "O"
		code = 24.0
	elsif c == "P"
		code = 25.0
	elsif c == "Q"
		code = 26.0
	elsif c == "R"
		code = 27.0
	elsif c == "S"
		code = 28.0
	elsif c == "T"
		code = 29.0
	elsif c == "U"
		code = 30.0
	elsif c == "V"
		code = 31.0
	elsif c == "W"
		code = 32.0
	elsif c == "X"
		code = 33.0
	elsif c == "Y"
		code = 34.0
	elsif c == "Z"
		code = 35.0
	elsif c == " "
		code = 36.0
	elsif c == "$"
		code = 37.0
	elsif c == "%"
		code = 38.0
	elsif c == "*"
		code = 39.0
	elsif c == "+"
		code = 40.0
	elsif c == "-"
		code = 41.0
	elsif c == "."
		code = 42.0
	elsif c == "/"
		code = 43.0
	elsif c == ":"
		code = 44.0
	else
		code = 0.0
	end

	return code
end


def QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel)

	eccPerBlockSpec = StringToNumberArray("7, 10, 13, 17, 10, 16, 22, 28, 15, 26, 18, 22, 20, 18, 26, 16, 26, 24, 18, 22, 18, 16, 24, 28, 20, 18, 18, 26, 24, 22, 22, 26, 30, 22, 20, 24, 18, 26, 24, 28, 20, 30, 28, 24, 24, 22, 26, 28, 26, 22, 24, 22, 30, 24, 20, 24, 22, 24, 30, 24, 24, 28, 24, 30, 28, 28, 28, 28, 30, 26, 28, 28, 28, 26, 26, 26, 28, 26, 30, 28, 28, 26, 28, 30, 28, 28, 30, 24, 30, 28, 30, 30, 30, 28, 30, 30, 26, 28, 30, 30, 28, 28, 28, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30".split(""))

	blockSpecs = StringToNumberArray("1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2, 4, 1, 2, 4, 4, 2, 4, 4, 4, 2, 4, 6, 5, 2, 4, 6, 6, 2, 5, 8, 8, 4, 5, 8, 8, 4, 5, 8, 11, 4, 8, 10, 11, 4, 9, 12, 16, 4, 9, 16, 16, 6, 10, 12, 18, 6, 10, 17, 16, 6, 11, 16, 19, 6, 13, 18, 21, 7, 14, 21, 25, 8, 16, 20, 25, 8, 17, 23, 25, 9, 17, 23, 34, 9, 18, 25, 30, 10, 20, 27, 32, 12, 21, 29, 35, 12, 23, 34, 37, 12, 25, 34, 40, 13, 26, 35, 42, 14, 28, 38, 45, 15, 29, 40, 48, 16, 31, 43, 51, 17, 33, 45, 54, 18, 35, 48, 57, 19, 37, 51, 60, 19, 38, 53, 63, 20, 40, 56, 66, 21, 43, 59, 70, 22, 45, 62, 74, 24, 47, 65, 77, 25, 49, 68, 81".split(""))

	errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevel)

	eccsPerBlock = eccPerBlockSpec[(version - 1.0)*4.0 + errorCorrectionLevelNumber]
	nrOfBlocks = blockSpecs[(version - 1.0)*4.0 + errorCorrectionLevelNumber]

	blockLengths = QRComputeBlockLengths(cws.length, nrOfBlocks)

	blocks = Array.new(nrOfBlocks)
	blockEccs = Array.new(nrOfBlocks)

	cw = 0.0
	i = 0.0
	while(i < nrOfBlocks)
		# Create block.
		cwsInBlock = blockLengths[i]
		block = Array.new(cwsInBlock)
		j = 0.0
		while(j < cwsInBlock)
			block[j] = cws[cw]
			cw = cw + 1.0
			j = j + 1.0
		end

		# Compute eccs.
		ecc = ComputeReedSolomonCodes(block, eccsPerBlock)

		blocks[i] = NumberArrayReference.new
		blocks[i].numberArray = block
		blockEccs[i] = NumberArrayReference.new
		blockEccs[i].numberArray = ecc
		i = i + 1.0
	end

	# Compose full data block:
	complete = Array.new(cws.length + eccsPerBlock*nrOfBlocks)

	e = 0.0
	# Interleave codewords:
	i = 0.0
	while(i < (cws.length.to_f / nrOfBlocks).floor)
		j = 0.0
		while(j < nrOfBlocks)
			complete[e] = blocks[j].numberArray[i]
			e = e + 1.0
			j = j + 1.0
		end
		i = i + 1.0
	end

	# Interleave remaining code words:
	i = 0.0
	while(i < nrOfBlocks)
		if blockLengths[i] > blockLengths[0]
			complete[e] = blocks[i].numberArray[blockLengths[i] - 1.0]
			e = e + 1.0
		end
		i = i + 1.0
	end

	i = 0.0
	while(i < eccsPerBlock)
		j = 0.0
		while(j < nrOfBlocks)
			complete[e] = blockEccs[j].numberArray[i]
			e = e + 1.0
			j = j + 1.0
		end
		i = i + 1.0
	end

	return complete
end


def QRComputeBlockLengths(lengthx, blocks)

	blockLengths = Array.new(blocks)

	q = (lengthx.to_f / blocks).floor
	r = lengthx%blocks

	i = 0.0
	while(i < blocks)
		blockLengths[i] = q
		i = i + 1.0
	end

	if r > 0.0
		i = 0.0
		while(i < r)
			blockLengths[blockLengths.length - 1.0 - i] = q + 1.0
			i = i + 1.0
		end
	end

	return blockLengths
end


def GenerateQRCode(imageReference, chars, errorCorrectionLevel, errorMessage)

	versionReference = NumberReference.new
	success = QRGetRequiredVersionFromData(chars, errorCorrectionLevel, versionReference, errorMessage)

	if success
		version = versionReference.numberValue

		GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, QRQuietZoneSize(), errorMessage)
	end

	return success
end


def QRGetRequiredVersionFromData(chars, errorCorrectionLevelCode, versionReference, errorMessage)

	modeReference = StringReference.new
	success = QRDetectMode(chars, modeReference, errorMessage)

	if success
		modeName = modeReference.string

		symbolBitsSpec = GetQRSymbolLengthsForVersions()

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

		done = false
		lengthReference = NumberReference.new
		i = 1.0
		while(i <= 40.0 && !done)
			success = QRComputeNumberOfCodewords(chars.length, i, modeName, lengthReference, errorMessage)

			if success
				l = lengthReference.numberValue

				if l <= symbolBitsSpec[(i - 1.0)*4.0 + errorCorrectionLevelNumber]
					versionReference.numberValue = i
					done = true
				end
			else
				done = true
			end
			i = i + 1.0
		end

		if !done
			success = false
			errorMessage.string = "Too much data for any QR code.".split("")
		end
	end

	return success
end


def GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, quietZoneSize, errorMessage)

	modeReference = StringReference.new
	success = QRDetectMode(chars, modeReference, errorMessage)

	if success
		mode = modeReference.string

		size = QRVersionToModules(version)

		image = CreateImage(size, size, GetTransparent())

		QRAddTimingPattern(image, version)

		QRAddFinderPattern(image, version)

		QRAddAlignmentPatterns(image, version)

		QRAddDummyFormatBits(image, version)

		if version >= 7.0
			QRAddVersionBits(image, version)
		end

		bsReference = StringReference.new

		success = GetQRCodewordBitSequence(chars, version, mode, bsReference, errorMessage)

		if success
			bs = bsReference.string

			cws = QRSegmentsToCodeWords(bs, version, errorCorrectionLevel)
			allcws = QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel)

			basis = CopyImage(image)

			QRAddCodewords(image, version, allcws)

			formatbits = Array.new(15)

			masks = Array.new(8)
			withMasks = Array.new(8)
			pentalies = Array.new(8)
			i = 0.0
			while(i < 8.0)
				masks[i] = CreateMask(i, version)
				withMasks[i] = QRApplyMask(basis, image, masks[i])
				QRComputeFormatBits(formatbits, errorCorrectionLevel, i)
				QRAddFormatBits(withMasks[i], formatbits)
				#System.out.println("Mask " + (int)i);
				pentalies[i] = QRComputePenalty(withMasks[i])
				i = i + 1.0
			end

			choice = 0.0
			min = pentalies[choice]
			i = 0.0
			while(i < 8.0)
				if pentalies[i] < min
					choice = i
					min = pentalies[choice]
				end
				i = i + 1.0
			end

			image = withMasks[choice]

			sizeWithQuietZone = size + 2.0*quietZoneSize
			quietZoneImage = CreateImage(sizeWithQuietZone, sizeWithQuietZone, GetWhite())
			DrawImageOnImage(quietZoneImage, image, quietZoneSize, quietZoneSize)

			imageReference.image = quietZoneImage
		end
	end

	return success
end


def GetQRCodewordBitSequence(chars, version, modeName, bsReference, errorMessage)

	if arraysStringsEqual(modeName, "Numeric".split(""))
		success = QRNumericDataToSegment(chars, version, bsReference, errorMessage)
	elsif arraysStringsEqual(modeName, "Alphanumeric".split(""))
		success = QRAlphanumericDataToSegment(chars, version, bsReference, errorMessage)
	elsif arraysStringsEqual(modeName, "8-bit Byte".split(""))
		success = QR8BitByteDataToSegment(chars, version, bsReference, errorMessage)
	else
		success = false
		errorMessage.string = "Invalid data mode.".split("")
	end

	return success
end


def QRComputeNumberOfCodewords(dataLength, version, modeName, lengthReference, errorMessage)

	lengthx = 0.0
	countReference = NumberReference.new

	success = QRGetCountLength(version, modeName, countReference, errorMessage)

	if success
		c = countReference.numberValue

		if arraysStringsEqual(modeName, "Numeric".split(""))
			r = 0.0
			last = dataLength%3.0
			if last == 0.0
				r = 0.0
			elsif last == 1.0
				r = 4.0
			elsif last == 2.0
				r = 7.0
			end

			lengthx = 4.0 + c + 10.0*(dataLength.to_f / 3.0).floor + r
		elsif arraysStringsEqual(modeName, "Alphanumeric".split(""))
			lengthx = 4.0 + c + 11.0*(dataLength.to_f / 2.0).floor + 6.0*(dataLength%2.0)
		elsif arraysStringsEqual(modeName, "8-bit Byte".split(""))
			lengthx = 4.0 + c + 8.0*dataLength
		else
			success = false
		end
	else
		success = false
	end

	if success
		lengthReference.numberValue = lengthx
	end

	return success
end


def QRAddVersionBits(image, version)

	ecc = ComputeBHC18_6Code(version)

	code = Array.new(18)

	str = StringReference.new
	CreateStringFromNumberWithCheck(version, 2.0, str)

	offset = 6.0 - str.string.length
	i = 0.0
	while(i < 6.0)
		if i < offset
			code[i] = "0"
		else
			code[i] = str.string[i - offset]
		end
		i = i + 1.0
	end

	CreateStringFromNumberWithCheck(ecc, 2.0, str)

	offset = 12.0 - str.string.length
	i = 0.0
	while(i < 12.0)
		if i < offset
			code[6.0 + i] = "0"
		else
			code[6.0 + i] = str.string[i - offset]
		end
		i = i + 1.0
	end

	i = 0.0
	while(i < 18.0)
		x = ImageWidth(image) - 11.0 + i%3.0
		y = 0.0 + (i.to_f / 3.0).floor

		if code[18.0 - 1.0 - i] == "1"
			SetPixel(image, x, y, GetBlack())
			SetPixel(image, y, x, GetBlack())
		else
			SetPixel(image, x, y, GetWhite())
			SetPixel(image, y, x, GetWhite())
		end
		i = i + 1.0
	end
end


def QRAddAlignmentPatterns(image, version)

	positions = Array.new(7)

	col2 = StringToNumberArray("18, 22, 26, 30, 34, 22, 24, 26, 28, 30, 32, 34, 26, 26, 26, 30, 30, 30, 34, 28, 26, 30, 28, 32, 30, 34, 26, 30, 26, 30, 34, 30, 34, 30, 24, 28, 32, 26, 30".split(""))
	col3 = StringToNumberArray("38, 42, 46, 50, 54, 58, 62, 46, 48, 50, 54, 56, 58, 62, 50, 50, 54, 54, 58, 58, 62, 50, 54, 52, 56, 60, 58, 62, 54, 50, 54, 58, 54, 58".split(""))
	col4 = StringToNumberArray("66, 70, 74, 78, 82, 86, 90, 72, 74, 78, 80, 84, 86, 90, 74, 78, 78, 82, 86, 86, 90, 78, 76, 80, 84, 82, 86".split(""))
	col5 = StringToNumberArray("94, 98, 102, 106, 110, 114, 118, 98, 102, 104, 108, 112, 114, 118, 102, 102, 106, 110, 110, 114".split(""))
	col6 = StringToNumberArray("122, 126, 130, 134, 138, 142, 146, 126, 128, 132, 136, 138, 142".split(""))
	col7 = StringToNumberArray("150, 154, 158, 162, 166, 170".split(""))

	positions[0] = 6.0
	nrOfPositions = 0.0

	if version == 1.0
		nrOfPositions = 0.0
	end
	if version >= 2.0
		nrOfPositions = 2.0
		positions[1] = col2[version - 2.0]
	end
	if version >= 7.0
		nrOfPositions = 3.0
		positions[2] = col3[version - 7.0]
	end
	if version >= 14.0
		nrOfPositions = 4.0
		positions[3] = col4[version - 14.0]
	end
	if version >= 21.0
		nrOfPositions = 5.0
		positions[4] = col5[version - 21.0]
	end
	if version >= 28.0
		nrOfPositions = 6.0
		positions[5] = col6[version - 28.0]
	end
	if version >= 35.0
		nrOfPositions = 7.0
		positions[6] = col7[version - 35.0]
	end

	i = 0.0
	while(i < nrOfPositions)
		j = 0.0
		while(j < nrOfPositions)
			x = positions[i]
			y = positions[j]

			if x <= 8.0 && y <= 8.0
				includePattern = false
			elsif x >= ImageWidth(image) - 8.0 && y <= 8.0
				includePattern = false
			elsif x <= 8.0 && y >= ImageWidth(image) - 7.0
				includePattern = false
			else
				includePattern = true
			end

			if includePattern
				QRAddAlignmentPattern(image, x, y)
			end
			j = j + 1.0
		end
		i = i + 1.0
	end
end


def QRAddAlignmentPattern(image, x, y)
	DrawRectangle1px(image, x, y, 0.0, 0.0, GetBlack())
	DrawRectangle1px(image, x - 1.0, y - 1.0, 2.0, 2.0, GetWhite())
	DrawRectangle1px(image, x - 2.0, y - 2.0, 4.0, 4.0, GetBlack())
end


def QR8BitByteDataToSegment(data, version, bsReference, errorMessage)

	countReference = NumberReference.new
	success = QRGetCountLength(version, "8-bit Byte".split(""), countReference, errorMessage)

	if success
		c = countReference.numberValue
		d = data.length

		lengthReference = NumberReference.new
		success = QRComputeNumberOfCodewords(data.length, version, "8-bit Byte".split(""), lengthReference, errorMessage)

		if success
			lengthx = lengthReference.numberValue

			bs = arraysCreateString(lengthx, "0")

			# Characters
			nstr = StringReference.new

			i = 0.0
			while(i < d)
				n = (data[i]).ord

				CreateStringFromNumberWithCheck(n, 2.0, nstr)

				offset = 8.0 - nstr.string.length
				j = 0.0
				while(j < nstr.string.length)
					bs[4.0 + c + 8.0*i + j + offset] = nstr.string[j]
					j = j + 1.0
				end
				i = i + 1.0
			end

			# Character count
			CreateStringFromNumberWithCheck(d, 2.0, nstr)
			offset = 4.0 + c - nstr.string.length
			j = 0.0
			while(j < nstr.string.length)
				bs[offset + j] = nstr.string[j]
				j = j + 1.0
			end

			# Mode
			mode = QR8BitByteModeIndicator()
			j = 0.0
			while(j < 4.0)
				bs[j] = mode[j]
				j = j + 1.0
			end

			bsReference.string = bs
		end
	end

	return success
end


def QRDetectMode(chars, modeReference, errorMessage)

	mode = 0.0
	success = false

	i = 0.0
	while(i < chars.length)
		c = chars[i]

		if cIsNumber(c)
			if mode == 0.0
				mode = 1.0
				success = true
			end
		elsif IsQRAlphanumericCharacter(c)
			if mode <= 1.0
				mode = 2.0
				success = true
			end
		elsif IsQRJIS8Character(c)
			if mode <= 2.0
				mode = 3.0
				success = true
			end
		else
			mode = 5.0
			success = false
			errorMessage.string = "Data contains invalid characters".split("")
		end
		i = i + 1.0
	end

	if mode == 0.0
		errorMessage.string = "There is no data to put in the QR code.".split("")
	end
	if mode == 1.0
		modeReference.string = "Numeric".split("")
	end
	if mode == 2.0
		modeReference.string = "Alphanumeric".split("")
	end
	if mode == 3.0
		modeReference.string = "8-bit Byte".split("")
	end

	return success
end


def QRComputePenalty(image)

	runP = QRComputePenaltyForRuns(image)
	#System.out.println("runP: " + ", " + (int)runP);
	boxP = QRComputePenaltyForBoxes(image)
	#System.out.println("boxP: " + ", " + (int)boxP);
	findP = QRComputePenaltyForFinders(image)
	#System.out.println("findP: " + ", " + (int)findP);
	balP = QRComputePenaltyForBalance(image)
	#System.out.println("balP: " + ", " + (int)balP);
	# Total penalty
	totalP = runP + boxP + balP + findP + balP
	#System.out.println(totalP);
	return totalP
end


def QRComputePenaltyForBalance(image)

	h = ImageHeight(image)
	w = ImageWidth(image)

	total = h*w
	black = 0.0

	y = 0.0
	while(y < h)
		x = 0.0
		while(x < w)
			isBlack = PixelIsBlack(image, x, y)

			if isBlack
				black = black + 1.0
			end
			x = x + 1.0
		end
		y = y + 1.0
	end

	deviation = (100.0*black.to_f / total - 50.0).abs
	balP = (deviation.to_f / 5.0).floor*10.0

	return balP
end


def QRComputePenaltyForFinders(image)

	h = ImageHeight(image)
	w = ImageWidth(image)

	findP = 0.0
	y = 0.0
	while(y < h)
		x = 0.0
		while(x < w - 10.0)
			d1 = PixelIsBlack(image, x + 0.0, y)
			w1 = PixelIsBlack(image, x + 1.0, y)
			d2 = PixelIsBlack(image, x + 2.0, y)
			d3 = PixelIsBlack(image, x + 3.0, y)
			d4 = PixelIsBlack(image, x + 4.0, y)
			w2 = PixelIsBlack(image, x + 5.0, y)
			d5 = PixelIsBlack(image, x + 6.0, y)
			w3 = PixelIsBlack(image, x + 7.0, y)
			w4 = PixelIsBlack(image, x + 8.0, y)
			w5 = PixelIsBlack(image, x + 9.0, y)
			w6 = PixelIsBlack(image, x + 10.0, y)

			if d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6
				findP = findP + 40.0
			end

			w3 = PixelIsBlack(image, x + 0.0, y)
			w4 = PixelIsBlack(image, x + 1.0, y)
			w5 = PixelIsBlack(image, x + 2.0, y)
			w6 = PixelIsBlack(image, x + 3.0, y)
			d1 = PixelIsBlack(image, x + 4.0, y)
			w1 = PixelIsBlack(image, x + 5.0, y)
			d2 = PixelIsBlack(image, x + 6.0, y)
			d3 = PixelIsBlack(image, x + 7.0, y)
			d4 = PixelIsBlack(image, x + 8.0, y)
			w2 = PixelIsBlack(image, x + 9.0, y)
			d5 = PixelIsBlack(image, x + 10.0, y)

			if d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6
				findP = findP + 40.0
			end
			x = x + 1.0
		end
		y = y + 1.0
	end

	x = 0.0
	while(x < w)
		y = 0.0
		while(y < h - 10.0)
			d1 = PixelIsBlack(image, x, y + 0.0)
			w1 = PixelIsBlack(image, x, y + 1.0)
			d2 = PixelIsBlack(image, x, y + 2.0)
			d3 = PixelIsBlack(image, x, y + 3.0)
			d4 = PixelIsBlack(image, x, y + 4.0)
			w2 = PixelIsBlack(image, x, y + 5.0)
			d5 = PixelIsBlack(image, x, y + 6.0)
			w3 = PixelIsBlack(image, x, y + 7.0)
			w4 = PixelIsBlack(image, x, y + 8.0)
			w5 = PixelIsBlack(image, x, y + 9.0)
			w6 = PixelIsBlack(image, x, y + 10.0)

			if d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6
				findP = findP + 40.0
			end

			w3 = PixelIsBlack(image, x, y + 0.0)
			w4 = PixelIsBlack(image, x, y + 1.0)
			w5 = PixelIsBlack(image, x, y + 2.0)
			w6 = PixelIsBlack(image, x, y + 3.0)
			d1 = PixelIsBlack(image, x, y + 4.0)
			w1 = PixelIsBlack(image, x, y + 5.0)
			d2 = PixelIsBlack(image, x, y + 6.0)
			d3 = PixelIsBlack(image, x, y + 7.0)
			d4 = PixelIsBlack(image, x, y + 8.0)
			w2 = PixelIsBlack(image, x, y + 9.0)
			d5 = PixelIsBlack(image, x, y + 10.0)

			if d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6
				findP = findP + 40.0
			end
			y = y + 1.0
		end
		x = x + 1.0
	end

	return findP
end


def QRComputePenaltyForBoxes(image)

	h = ImageHeight(image)
	w = ImageWidth(image)

	boxP = 0.0
	y = 0.0
	while(y < h - 1.0)
		x = 0.0
		while(x < w - 1.0)
			ul = PixelIsBlack(image, x + 0.0, y + 0.0)
			ur = PixelIsBlack(image, x + 1.0, y + 0.0)
			ll = PixelIsBlack(image, x + 0.0, y + 1.0)
			lr = PixelIsBlack(image, x + 1.0, y + 1.0)

			if ul && ur && ll && lr || !ul && !ur && !ll && !lr
				boxP = boxP + 3.0
			end
			x = x + 1.0
		end
		y = y + 1.0
	end

	return boxP
end


def PixelIsBlack(image, x, y)
	return GetImagePixel(image, x, y).r == 0.0
end


def QRComputePenaltyForRuns(image)

	h = ImageHeight(image)
	w = ImageWidth(image)

	runP = 0.0

	# Horizontal penalty
	y = 0.0
	while(y < h)
		first = true
		prev = true
		cur = true
		run = 1.0

		x = 0.0
		while(x <= w)
			last = x == w
			if !last
				cur = PixelIsBlack(image, x, y)
			end

			if !first
				if prev == cur && !last
					run = run + 1.0
				end

				if prev != cur || last
					if run >= 5.0
						runP = runP + 3.0 + run - 5.0
					end
					run = 1.0
				end
			end

			first = false
			prev = cur
			x = x + 1.0
		end
		y = y + 1.0
	end

	# Vertical penalty
	x = 0.0
	while(x < w)
		first = true
		prev = true
		cur = true
		run = 1.0

		y = 0.0
		while(y <= h)
			last = y == h
			if !last
				cur = PixelIsBlack(image, x, y)
			end

			if !first
				if prev == cur && !last
					run = run + 1.0
				end

				if prev != cur || last
					if run >= 5.0
						runP = runP + 3.0 + run - 5.0
					end
					run = 1.0
				end
			end

			first = false
			prev = cur
			y = y + 1.0
		end
		x = x + 1.0
	end
	return runP
end


def QRAddFormatBits(image, formatbits)

	black = GetBlack()
	white = GetWhite()

	x = 8.0
	y = 0.0

	# Upper-left
	i = 0.0
	while(i < formatbits.length)
		b = formatbits[14.0 - i]
		if b == "1"
			color = black
		else
			color = white
		end

		SetPixel(image, x, y, color)

		if i < 7.0
			y = y + 1.0
		end
		if i == 5.0
			y = y + 1.0
		end

		if i >= 7.0
			x = x - 1.0
		end
		if i == 8.0
			x = x - 1.0
		end
		i = i + 1.0
	end

	# Lower left and top right
	x = ImageWidth(image) - 1.0
	y = 8.0

	i = 0.0
	while(i < formatbits.length)
		b = formatbits[14.0 - i]
		if b == "1"
			color = black
		else
			color = white
		end

		SetPixel(image, x, y, color)

		if i < 7.0
			x = x - 1.0
		end
		if i == 7.0
			y = ImageHeight(image) - 7.0
			x = 8.0
		end

		if i > 7.0
			y = y + 1.0
		end
		i = i + 1.0
	end
end


def QRComputeFormatBits(bits, errorCorrectionLevel, mask)

	errorCorrectionCode = 0.0
	if errorCorrectionLevel == "L"
		errorCorrectionCode = 1.0
	elsif errorCorrectionLevel == "M"
		errorCorrectionCode = 0.0
	elsif errorCorrectionLevel == "Q"
		errorCorrectionCode = 3.0
	elsif errorCorrectionLevel == "H"
		errorCorrectionCode = 2.0
	end

	n = OrByte(ShiftLeftByte(errorCorrectionCode, 3.0), mask)

	bhc = ComputeBHC15_5Code(n)

	n = Or4Byte(ShiftLeft4Byte(n, 10.0), bhc)

	str = StringReference.new
	CreateStringFromNumberWithCheck(n, 2.0, str)

	offset = 15.0 - str.string.length
	i = 0.0
	while(i < 15.0)
		if i < offset
			bits[i] = "0"
		else
			bits[i] = str.string[i - offset]
		end
		i = i + 1.0
	end

	xorpattern = "101010000010010".split("")

	i = 0.0
	while(i < 15.0)
		a = bits[i] == "1"
		b = xorpattern[i] == "1"

		r = Xor(a, b)

		if r
			bits[i] = "1"
		else
			bits[i] = "0"
		end
		i = i + 1.0
	end
end


def QRApplyMask(basis, image, mask)

	withMask = CopyImage(image)

	i = 0.0
	while(i < ImageWidth(basis))
		j = 0.0
		while(j < ImageHeight(basis))
			if GetImagePixel(basis, i, j).a == 0.0
				a = PixelIsBlack(image, i, j)
				b = PixelIsBlack(mask, i, j)

				# xor
				r = Xor(a, b)

				if r
					SetPixel(withMask, i, j, GetBlack())
				else
					SetPixel(withMask, i, j, GetWhite())
				end
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	return withMask
end


def Xor(a, b)
	return a && !b || !a && b
end


def CreateMask(mask, version)

	size = QRVersionToModules(version)

	image = CreateImage(size, size, GetTransparent())

	black = true
	i = 0.0
	while(i < size)
		j = 0.0
		while(j < size)
			if mask == 0.0
				black = (i + j)%2.0 == 0.0
			elsif mask == 1.0
				black = i%2.0 == 0.0
			elsif mask == 2.0
				black = j%3.0 == 0.0
			elsif mask == 3.0
				black = (i + j)%3.0 == 0.0
			elsif mask == 4.0
				black = ((i.to_f / 2.0).floor + (j.to_f / 3.0).floor)%2.0 == 0.0
			elsif mask == 5.0
				black = (i*j)%2.0 + (i*j)%3.0 == 0.0
			elsif mask == 6.0
				black = ((i*j)%2.0 + (i*j)%3.0)%2.0 == 0.0
			elsif mask == 7.0
				black = ((i*j)%3.0 + (i + j)%2.0)%2.0 == 0.0
			end

			if black
				SetPixel(image, j, i, GetBlack())
			else
				SetPixel(image, j, i, GetWhite())
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	return image
end


def QRAddDummyFormatBits(image, version)

	size = QRVersionToModules(version)

	i = 0.0
	while(i < 9.0)
		if i != 6.0
			SetPixel(image, i, 8.0, GetWhite())
			SetPixel(image, 8.0, i, GetWhite())
		end
		if i != 8.0
			SetPixel(image, size - 1.0 - i, 8.0, GetWhite())
			SetPixel(image, 8.0, size - 1.0 - i, GetWhite())
		end
		i = i + 1.0
	end

	SetPixel(image, 8.0, size - 8.0, GetBlack())
end


def QRAddCodewords(image, version, cws)
        
	ll = CreateLinkedListCharacter()
	s = StringReference.new
        
	i = 0.0
	while(i < cws.length)
		CreateStringFromNumberWithCheck(cws[i], 2.0, s)

		offset = 8.0 - s.string.length
		j = 0.0
		while(j < 8.0)
			if j < offset
				LinkedListAddCharacter(ll, "0")
			else
				LinkedListAddCharacter(ll, s.string[j - offset])
			end
			j = j + 1.0
		end

		delete(s.string)
		i = i + 1.0
	end

	bits = LinkedListCharactersToArray(ll)

	size = QRVersionToModules(version)
	x = size - 1.0
	y = size - 1.0
	d = true
	w = true
	bit = 0.0
	offset = 0.0
	i = 0.0
	while(i < size**2.0 - size)
		if GetImagePixel(image, x - offset, y).a == 0.0
			if bit < bits.length
				b = bits[bit]

				if b == "1"
					SetPixel(image, (x - offset), y, GetBlack())
				else
					SetPixel(image, (x - offset), y, GetWhite())
				end

				bit = bit + 1.0
			else
				# Some symbols have nothing at the end.
				SetPixel(image, (x - offset), y, GetWhite())
			end
		end

		if d
			if w
				x = x - 1.0
			else
				x = x + 1.0
				y = y - 1.0
			end
		elsif w
			x = x - 1.0
		else
			x = x + 1.0
			y = y + 1.0
		end

		w = !w

		if i%(2.0*size) == 2.0*size - 1.0
			if d
				x = x - 2.0
				y = y + 1.0
				w = true
			else
				x = x - 2.0
				y = y - 1.0
				w = true
			end

			d = !d
		end

		if x == 6.0
			offset = 1.0
		end
		i = i + 1.0
	end
end


def QRAddTimingPattern(image, version)

	size = QRVersionToModules(version)

	black = true
	i = 0.0
	while(i < size)
		if black
			SetPixel(image, i, 6.0, GetBlack())
			SetPixel(image, 6.0, i, GetBlack())
		else
			SetPixel(image, i, 6.0, GetWhite())
			SetPixel(image, 6.0, i, GetWhite())
		end

		black = !black
		i = i + 1.0
	end
end


def QRAddFinderPattern(image, version)

	size = QRVersionToModules(version)
	finderPattern = GetQRFinderPattern()
	DrawImageOnImage(image, finderPattern, -1.0, -1.0)
	DrawImageOnImage(image, finderPattern, size - 7.0 - 1.0, -1.0)
	DrawImageOnImage(image, finderPattern, -1.0, size - 7.0 - 1.0)
end


def GetQRFinderPattern()

	fp = CreateImage(9.0, 9.0, GetBlack())

	DrawRectangle1px(fp, 2.0, 2.0, 4.0, 4.0, GetWhite())
	DrawRectangle1px(fp, 0.0, 0.0, 8.0, 8.0, GetWhite())

	return fp
end


def QRQuietZoneSize()
	return 4.0
end


def QRVersionToModules(version)
	return 17.0 + 4.0*version
end


def QRNumericDataToSegment(data, version, bsReference, errorMessage)

	countReference = NumberReference.new
	success = QRGetCountLength(version, "Numeric".split(""), countReference, errorMessage)

	if success
		c = countReference.numberValue
		d = data.length

		r = 0.0
		last = d%3.0
		if last == 0.0
			r = 0.0
		elsif last == 1.0
			r = 4.0
		elsif last == 2.0
			r = 7.0
		end

		lengthReference = NumberReference.new
		success = QRComputeNumberOfCodewords(data.length, version, "Numeric".split(""), lengthReference, errorMessage)
		if success
			lengthx = lengthReference.numberValue

			bs = arraysCreateString(lengthx, "0")

			# Characters
			group = Array.new(3)
			nstr = StringReference.new

			i = 0.0
			while(i < (d.to_f / 3.0).floor)
				group[0] = data[i*3.0 + 0.0]
				group[1] = data[i*3.0 + 1.0]
				group[2] = data[i*3.0 + 2.0]

				n = CreateNumberFromDecimalString(group)
				CreateStringFromNumberWithCheck(n, 2.0, nstr)

				offset = 10.0 - nstr.string.length
				j = 0.0
				while(j < nstr.string.length)
					bs[4.0 + c + i*10.0 + offset + j] = nstr.string[j]
					j = j + 1.0
				end
				i = i + 1.0
			end

			if last == 1.0
				group[0] = "0"
				group[1] = "0"
				group[2] = data[data.length - 1.0]
			end

			if last == 2.0
				group[0] = "0"
				group[1] = data[data.length - 2.0]
				group[2] = data[data.length - 1.0]
			end

			if last == 1.0 || last == 2.0
				n = CreateNumberFromDecimalString(group)
				CreateStringFromNumberWithCheck(n, 2.0, nstr)

				offset = r - nstr.string.length
				j = 0.0
				while(j < nstr.string.length)
					bs[bs.length - r + offset + j] = nstr.string[j]
					j = j + 1.0
				end
			end

			# Character count
			CreateStringFromNumberWithCheck(d, 2.0, nstr)
			offset = 4.0 + c - nstr.string.length
			j = 0.0
			while(j < nstr.string.length)
				bs[offset + j] = nstr.string[j]
				j = j + 1.0
			end

			# Mode
			mode = QRNumericModeIndicator()
			j = 0.0
			while(j < 4.0)
				bs[j] = mode[j]
				j = j + 1.0
			end

			bsReference.string = bs
		end
	end

	return success
end


def QRGetCountLength(version, modeName, cReference, errorMessage)

	success = true
	c = 0.0

	if arraysStringsEqual(modeName, "Numeric".split(""))
		if version >= 1.0 && version <= 9.0
			c = 10.0
		elsif version >= 10.0 && version <= 26.0
			c = 12.0
		elsif version >= 27.0 && version <= 40.0
			c = 14.0
		else
			success = false
			errorMessage.string = "Invalid version number.".split("")
		end
	elsif arraysStringsEqual(modeName, "Alphanumeric".split(""))
		if version >= 1.0 && version <= 9.0
			c = 9.0
		elsif version >= 10.0 && version <= 26.0
			c = 11.0
		elsif version >= 27.0 && version <= 40.0
			c = 13.0
		else
			success = false
			errorMessage.string = "Invalid version number.".split("")
		end
	elsif arraysStringsEqual(modeName, "8-bit Byte".split(""))
		if version >= 1.0 && version <= 9.0
			c = 8.0
		elsif version >= 10.0 && version <= 26.0
			c = 16.0
		elsif version >= 27.0 && version <= 40.0
			c = 16.0
		else
			success = false
			errorMessage.string = "Invalid version number.".split("")
		end
	else
		success = false
		errorMessage.string = "Invalid mode name.".split("")
	end

	if success
		cReference.numberValue = c
	end

	return success
end


def QRNumericModeIndicator()
	return "0001".split("")
end


def QRAlphanumericModeIndicator()
	return "0010".split("")
end


def QRTerminatorModeIndicator()
	return "0000".split("")
end


def QR8BitByteModeIndicator()
	return "0100".split("")
end


def QRKanjiModeIndicator()
	return "1000".split("")
end


def QRAlphanumericDataToSegment(data, version, bsReference, errorMessage)

	countReference = NumberReference.new
	success = QRGetCountLength(version, "Alphanumeric".split(""), countReference, errorMessage)

	if success
		c = countReference.numberValue
		d = data.length

		lengthReference = NumberReference.new
		success = QRComputeNumberOfCodewords(data.length, version, "Alphanumeric".split(""), lengthReference, errorMessage)

		if success
			lengthx = lengthReference.numberValue

			bs = arraysCreateString(lengthx, "0")

			# Characters
			nstr = StringReference.new

			i = 0.0
			while(i < (d.to_f / 2.0).floor)
				c0 = QRAlphanumericToCode(data[i*2.0 + 0.0])
				c1 = QRAlphanumericToCode(data[i*2.0 + 1.0])

				n = c0*45.0 + c1

				CreateStringFromNumberWithCheck(n, 2.0, nstr)

				offset = 11.0 - nstr.string.length
				j = 0.0
				while(j < nstr.string.length)
					bs[4.0 + c + i*11.0 + offset + j] = nstr.string[j]
					j = j + 1.0
				end
				i = i + 1.0
			end

			if d%2.0 == 1.0
				n = QRAlphanumericToCode(data[data.length - 1.0])

				CreateStringFromNumberWithCheck(n, 2.0, nstr)

				offset = 6.0 - nstr.string.length
				j = 0.0
				while(j < nstr.string.length)
					bs[bs.length - 6.0 + offset + j] = nstr.string[j]
					j = j + 1.0
				end
			end

			# Character count
			CreateStringFromNumberWithCheck(d, 2.0, nstr)
			offset = 4.0 + c - nstr.string.length
			j = 0.0
			while(j < nstr.string.length)
				bs[offset + j] = nstr.string[j]
				j = j + 1.0
			end

			# Mode
			mode = QRAlphanumericModeIndicator()
			j = 0.0
			while(j < 4.0)
				bs[j] = mode[j]
				j = j + 1.0
			end

			bsReference.string = bs
		end
	end

	return success
end


def QRSegmentsToCodeWords(data, version, errorCorrectionLevelCode)

	symbolBitsSpec = GetQRSymbolLengthsForVersions()

	errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

	symbolBits = symbolBitsSpec[(version - 1.0)*4.0 + errorCorrectionLevelNumber]

	terminatorLength = [symbolBits - data.length, 4.0].min

	d = data.length + terminatorLength
	n = (d.to_f / 8.0).ceil
	padding = n*8.0 - d

	codewords = Array.new((symbolBits.to_f / 8.0).floor)

	str = Array.new(8)
	nref = NumberReference.new
	errorMessage = StringReference.new

	cw = 0.0
	while(cw < (data.length.to_f / 8.0).floor)
		str[0] = data[cw*8.0 + 0.0]
		str[1] = data[cw*8.0 + 1.0]
		str[2] = data[cw*8.0 + 2.0]
		str[3] = data[cw*8.0 + 3.0]
		str[4] = data[cw*8.0 + 4.0]
		str[5] = data[cw*8.0 + 5.0]
		str[6] = data[cw*8.0 + 6.0]
		str[7] = data[cw*8.0 + 7.0]

		CreateNumberFromStringWithCheck(str, 2.0, nref, errorMessage)

		codewords[cw] = nref.numberValue
		cw = cw + 1.0
	end

	# Remaining data, terminator and bit-padding.
	r = data.length%8.0
	if r != 0.0
		j = 0.0
		while(j < 8.0)
			if j < r
				str[j] = data[data.length - r + j]
			else
				str[j] = "0"
			end
			j = j + 1.0
		end

		CreateNumberFromStringWithCheck(str, 2.0, nref, errorMessage)

		codewords[cw] = nref.numberValue
		cw = cw + 1.0
	end

	if r == 0.0 && terminatorLength + padding == 8.0
		codewords[cw] = 0.0
		cw = cw + 1.0
	elsif 8.0 - r >= terminatorLength + padding
	else
		codewords[cw] = 0.0
		cw = cw + 1.0
	end

	# Byte Padding
	padSymbol = true
	while(cw < codewords.length)
		if padSymbol
			codewords[cw] = 236.0
		else
			codewords[cw] = 17.0
		end
		padSymbol = !padSymbol
		cw = cw + 1.0
	end

	return codewords
end


def GetQRSymbolLengthsForVersions()
	return StringToNumberArray("152, 128, 104, 72, 272, 224, 176, 128, 440, 352, 272, 208, 640, 512, 384, 288, 864, 688, 496, 368, 1088, 864, 608, 480, 1248, 992, 704, 528, 1552, 1232, 880, 688, 1856, 1456, 1056, 800, 2192, 1728, 1232, 976, 2592, 2032, 1440, 1120, 2960, 2320, 1648, 1264, 3424, 2672, 1952, 1440, 3688, 2920, 2088, 1576, 4184, 3320, 2360, 1784, 4712, 3624, 2600, 2024, 5176, 4056, 2936, 2264, 5768, 4504, 3176, 2504, 6360, 5016, 3560, 2728, 6888, 5352, 3880, 3080, 7456, 5712, 4096, 3248, 8048, 6256, 4544, 3536, 8752, 6880, 4912, 3712, 9392, 7312, 5312, 4112, 10208, 8000, 5744, 4304, 10960, 8496, 6032, 4768, 11744, 9024, 6464, 5024, 12248, 9544, 6968, 5288, 13048, 10136, 7288, 5608, 13880, 10984, 7880, 5960, 14744, 11640, 8264, 6344, 15640, 12328, 8920, 6760, 16568, 13048, 9368, 7208, 17528, 13800, 9848, 7688, 18448, 14496, 10288, 7888, 19472, 15312, 10832, 8432, 20528, 15936, 11408, 8768, 21616, 16816, 12016, 9136, 22496, 17728, 12656, 9776, 23648, 18672, 13328, 10208".split(""))
end


def QREccLetterToNumber(errorCorrectionLevelCode)

	errorCorrectionLevelNumber = 0.0

	if errorCorrectionLevelCode == "L"
		errorCorrectionLevelNumber = 0.0
	elsif errorCorrectionLevelCode == "M"
		errorCorrectionLevelNumber = 1.0
	elsif errorCorrectionLevelCode == "Q"
		errorCorrectionLevelNumber = 2.0
	elsif errorCorrectionLevelCode == "H"
		errorCorrectionLevelNumber = 3.0
	end
	return errorCorrectionLevelNumber
end


def ErGyldigOrgNummerString(orgnummer)

	o = Array.new(9)

	gyldig = true

	if orgnummer.length == 9.0

		i = 0.0
		while(i < 9.0)
			if cIsNumber(orgnummer[i])
				o[i] = cCharacterToDecimalDigit(orgnummer[i])
			else
				gyldig = false
			end
			i = i + 1.0
		end

		if gyldig
			gyldig = ErGyldigOrgNummer(o)
		end
	else
		gyldig = false
	end

	return gyldig
end


def ErGyldigOrgNummer(o)

	if o.length == 9.0
		sum = o[0]*3.0 + o[1]*2.0 + o[2]*7.0 + o[3]*6.0 + o[4]*5.0 + o[5]*4.0 + o[6]*3.0 + o[7]*2.0
		rest = sum%11.0
		if rest == 0.0
			kontrollsiffer = 0.0
		else
			kontrollsiffer = 11.0 - rest
		end

		gyldig = rest != 1.0 && kontrollsiffer == o[8]
	else
		gyldig = false
	end

	return gyldig
end


def IsValidNorwegianPersonalIdentificationNumber(fnummer, message)

	valid = fnummer.length == 11.0
	if valid
		i = 0.0
		while(i < fnummer.length)
			if cIsNumber(fnummer[i])
			else
				valid = false
			end
			i = i + 1.0
		end

		if valid
			d1 = cCharacterToDecimalDigit(fnummer[0])
			d2 = cCharacterToDecimalDigit(fnummer[1])
			d3 = cCharacterToDecimalDigit(fnummer[2])
			d4 = cCharacterToDecimalDigit(fnummer[3])
			d5 = cCharacterToDecimalDigit(fnummer[4])
			d6 = cCharacterToDecimalDigit(fnummer[5])
			d7 = cCharacterToDecimalDigit(fnummer[6])
			d8 = cCharacterToDecimalDigit(fnummer[7])
			d9 = cCharacterToDecimalDigit(fnummer[8])
			d10 = cCharacterToDecimalDigit(fnummer[9])
			d11 = cCharacterToDecimalDigit(fnummer[10])

			dateRef = DateReference.new
			valid = GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message)

			if valid
				valid = IsValidDate(dateRef.date, message)
				if valid
					k1 = d1*3.0 + d2*7.0 + d3*6.0 + d4*1.0 + d5*8.0 + d6*9.0 + d7*4.0 + d8*5.0 + d9*2.0
					k1 = k1%11.0
					if k1 != 0.0
						k1 = 11.0 - k1
					end
					if k1 == 10.0
						valid = false
						message.string = "Control digit 1 is 10, which is invalid.".split("")
					end

					if valid
						k2 = d1*5.0 + d2*4.0 + d3*3.0 + d4*2.0 + d5*7.0 + d6*6.0 + d7*5.0 + d8*4.0 + d9*3.0 + k1*2.0
						k2 = k2%11.0
						if k2 != 0.0
							k2 = 11.0 - k2
						end
						if k2 == 10.0
							valid = false
							message.string = "Control digit 2 is 10, which is invalid.".split("")
						end

						if valid
							if k1 == d10
								if k2 == d11
									valid = true
								else
									valid = false
									message.string = "Check of control digit 2 failed.".split("")
								end
							else
								valid = false
								message.string = "Check of control digit 1 failed.".split("")
							end
						end
					end
				else
					message.string = "The date is not a valid date.".split("")
				end
			end
		else
			message.string = "Each character must be a decimal digit.".split("")
		end
	else
		message.string = "Must be exactly 11 digits long.".split("")
	end

	return valid
end


def GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message)

	dateRef.date = Date.new

	success = fnummer.length == 11.0
	if success
		i = 0.0
		while(i < fnummer.length)
			if cIsNumber(fnummer[i])
			else
				success = false
			end
			i = i + 1.0
		end

		if success
			d1 = cCharacterToDecimalDigit(fnummer[0])
			d2 = cCharacterToDecimalDigit(fnummer[1])
			d3 = cCharacterToDecimalDigit(fnummer[2])
			d4 = cCharacterToDecimalDigit(fnummer[3])
			d5 = cCharacterToDecimalDigit(fnummer[4])
			d6 = cCharacterToDecimalDigit(fnummer[5])
			d7 = cCharacterToDecimalDigit(fnummer[6])
			d8 = cCharacterToDecimalDigit(fnummer[7])
			d9 = cCharacterToDecimalDigit(fnummer[8])

			# Individnummer
			individnummer = d7*100.0 + d8*10.0 + d9

			# Make date
			day = d1*10.0 + d2
			month = d3*10.0 + d4
			year = d5*10.0 + d6

			if individnummer >= 0.0 && individnummer <= 499.0
				year = year + 1900.0
			elsif individnummer >= 500.0 && individnummer <= 749.0 && year >= 54.0 && year <= 99.0
				year = year + 1800.0
			elsif individnummer >= 900.0 && individnummer <= 999.0 && year >= 40.0 && year <= 99.0
				year = year + 1900.0
			elsif individnummer >= 500.0 && individnummer <= 999.0 && year >= 0.0 && year <= 39.0
				year = year + 2000.0
			else
				success = false
				message.string = "Invalid combination of individnummer and year.".split("")
			end

			if success
				dateRef.date.year = year
				dateRef.date.month = month
				dateRef.date.day = day
			end
		else
			message.string = "Each character must be a decimal digit.".split("")
		end
	else
		message.string = "Must be exactly 11 digits long.".split("")
	end

	return success
end


def HentKommunenavnFraNummer(kommunenummer, kommunenavnReference, errorMessages)

	kommunenavn = HentKommunenavn()

	nummer = HentGyldigeKommunenummer()
	success = false

	nr = 0.0
	while(nr < nummer.length && !success)
		if arraysStringsEqual(nummer[nr].string, kommunenummer)
			success = true
			kommunenavnReference.string = kommunenavn[nr].string
		end
		nr = nr + 1.0
	end

	if !success
		errorMessages.string = "Kommunenummer er ikke gyldig.".split("")
	end

	return success
end


def ErGyldigKommunenummer(kommunenummer)

	gyldig = false

	if kommunenummer.length == 4.0
		nummer = HentGyldigeKommunenummer()

		i = 0.0
		while(i < nummer.length && !gyldig)
			if arraysStringsEqual(nummer[i].string, kommunenummer)
				gyldig = true
			end
			i = i + 1.0
		end
	end

	return gyldig
end


def HentKommunenavn()

	kommunenavnliste = "\u00c5fjord, Agdenes, \u00c5l, \u00c5lesund, Alstahaug, Alta, Alvdal, \u00c5mli, \u00c5mot, And\u00f8y, \u00c5rdal, Aremark, Arendal, \u00c5s, \u00c5seral, Asker, Askim, Ask\u00f8y, Askvoll, \u00c5snes, Audnedal, Aukra, Aure, Aurland, Aurskog-H\u00f8land, Austevoll, Austrheim, Aver\u00f8y, B\u00e6rum, Balestrand, Ballangen, Balsfjord, Bamble, Bardu, B\u00e5tsfjord, Beiarn, Berg, Bergen, Berlev\u00e5g, Bindal, Birkenes, Bjerkreim, Bjugn, B\u00f8 i Nordland , B\u00f8 i Telemark, Bod\u00f8, Bokn, B\u00f8mlo, Bremanger, Br\u00f8nn\u00f8y, Bygland, Bykle, Deatnu - Tana, Divtasvuodna - Tysfjord, D\u00f8nna, Dovre, Drammen, Drangedal, Dyr\u00f8y, Eid, Eide, Eidfjord, Eidsberg, Eidskog, Eidsvoll, Eigersund, Elverum, Enebakk, Engerdal, Etne, Etnedal, Evenes, Evje og Hornnes, F\u00e6rder, Farsund, Fauske - Fuossko, Fedje, Fet, Finn\u00f8y, Fitjar, Fjaler, Fjell, Fl\u00e5, Flakstad, Flatanger, Flekkefjord, Flesberg, Flora, Folldal, F\u00f8rde, Forsand, Fosnes, Fr\u00e6na, Fredrikstad, Frogn, Froland, Frosta, Fr\u00f8ya, Fusa, Fyresdal, G\u00e1ivuotna - K\u00e5fjord - Kaivuono, Gamvik, Gaular, Gausdal, Gildesk\u00e5l, Giske, Gjemnes, Gjerdrum, Gjerstad, Gjesdal, Gj\u00f8vik, Gloppen, Gol, Gran, Grane, Granvin, Gratangen, Grimstad, Grong, Grue, Gulen, Guovdageaidnu - Kautokeino, H\u00e5, Hadsel, H\u00e6gebostad, Halden, Halsa, Hamar, Hamar\u00f8y - H\u00e1bmer, Hammerfest, Haram, Hareid, Harstad - H\u00e1rstt\u00e1k, Hasvik, Hattfjelldal, Haugesund, Hemne, Hemnes, Hemsedal, Her\u00f8y i  M\u00f8re og Romsdal, Her\u00f8y i Nordland, Hitra, Hjartdal, Hjelmeland, Hob\u00f8l, Hol, Hole, Holmestrand, Holt\u00e5len, Hornindal, Horten, H\u00f8yanger, H\u00f8ylandet, Hurdal, Hurum, Hvaler, Hyllestad, Ibestad, Inder\u00f8y, Indre Fosen, Iveland, Jevnaker, J\u00f8lster, Jondal, K\u00e1r\u00e1\u0161johka - Karasjok, Karls\u00f8y, Karm\u00f8y, Kl\u00e6bu, Klepp, Kongsberg, Kongsvinger, Krager\u00f8, Kristiansand, Kristiansund, Kr\u00f8dsherad, Kv\u00e6fjord, Kv\u00e6nangen, Kvalsund, Kvam, Kvinesdal, Kvinnherad, Kviteseid, Kvits\u00f8y, L\u00e6rdal, Larvik, Lebesby, Leikanger, Leirfjord, Leka, Lenvik, Lesja, Levanger, Lier, Lierne, Lillehammer, Lillesand, Lind\u00e5s, Lindesnes, Loab\u00e1k - Lavangen, L\u00f8dingen, Lom, Loppa, L\u00f8renskog, L\u00f8ten, Lund, Lunner, Lur\u00f8y, Luster, Lyngdal, Lyngen, M\u00e5lselv, Malvik, Mandal, Marker, Marnardal, Masfjorden, M\u00e5s\u00f8y, Meland, Meldal, Melhus, Mel\u00f8y, Mer\u00e5ker, Midsund, Midtre Gauldal, Modalen, Modum, Molde, Moskenes, Moss, N\u00e6r\u00f8y, Namdalseid, Namsos, Namsskogan, Nannestad, Narvik, Naustdal, Nedre Eiker, Nes i Akershus, Nes i Buskerud, Nesna, Nesodden, Nesset, Nissedal, Nittedal, Nome, Nord-Aurdal, Norddal, Nord-Fron, Nordkapp, Nord-Odal, Nordre Land, Nordreisa - R\u00e1isa - Raisi, Nore og Uvdal, Notodden, Odda, \u00d8ksnes, Oppdal, Oppeg\u00e5rd, Orkdal, \u00d8rland, \u00d8rskog, \u00d8rsta, Os i Hedmark, Os i Hordaland, Osen, Oslo, Oster\u00f8y, \u00d8stre Toten, Overhalla, \u00d8vre Eiker, \u00d8yer, \u00d8ygarden, \u00d8ystre Slidre, Porsanger - Pors\u00e1\u014bgu - Porsanki, Porsgrunn, Raarvikhe - R\u00f8yrvik, R\u00e5de, Rad\u00f8y, R\u00e6lingen, Rakkestad, Rana, Randaberg, Rauma, Re, Rendalen, Rennebu, Rennes\u00f8y, Rindal, Ringebu, Ringerike, Ringsaker, Ris\u00f8r, Roan, R\u00f8d\u00f8y, Rollag, R\u00f8mskog, R\u00f8ros, R\u00f8st, R\u00f8yken, Rygge, Salangen, Saltdal, Samnanger, Sande i M\u00f8re og Romsdal, Sande i Vestfold, Sandefjord, Sandnes, Sand\u00f8y, Sarpsborg, Sauda, Sauherad, Sel, Selbu, Selje, Seljord, Sigdal, Siljan, Sirdal, Sk\u00e5nland, Skaun, Skedsmo, Ski, Skien, Skiptvet, Skj\u00e5k, Skjerv\u00f8y, Skodje, Sm\u00f8la, Sn\u00e5ase - Sn\u00e5sa, Snillfjord, Sogndal, S\u00f8gne, Sokndal, Sola, Solund, S\u00f8mna, S\u00f8ndre Land, Songdalen, S\u00f8r-Aurdal, S\u00f8rfold, S\u00f8r-Fron, S\u00f8r-Odal, S\u00f8rreisa, Sortland - Suort\u00e1, S\u00f8rum, S\u00f8r-Varanger, Spydeberg, Stange, Stavanger, Steigen, Steinkjer, Stj\u00f8rdal, Stord, Stordal, Stor-Elvdal, Storfjord - Omasvuotna - Omasvuono, Strand, Stranda, Stryn, Sula, Suldal, Sund, Sunndal, Surnadal, Sveio, Svelvik, Sykkylven, Time, Tingvoll, Tinn, Tjeldsund, Tokke, Tolga, T\u00f8nsberg, Torsken, Tr\u00e6na, Tran\u00f8y, Tr\u00f8gstad, Troms\u00f8, Trondheim , Trysil, Tvedestrand, Tydal, Tynset, Tysnes, Tysv\u00e6r, Ullensaker, Ullensvang, Ulstein, Ulvik, Unj\u00e1rga - Nesseby, Utsira, Vads\u00f8, V\u00e6r\u00f8y, V\u00e5g\u00e5, V\u00e5gan, V\u00e5gs\u00f8y, Vaksdal, V\u00e5ler i Hedmark, V\u00e5ler i \u00d8stfold, Valle, Vang, Vanylven, Vard\u00f8, Vefsn, Vega, Veg\u00e5rshei, Vennesla, Verdal, Verran, Vestby, Vestnes, Vestre Slidre, Vestre Toten, Vestv\u00e5g\u00f8y, Vevelstad, Vik, Vikna, Vindafjord, Vinje, Volda, Voss, ".split("")

	kommunenavn = strSplitByString(kommunenavnliste, ", ".split(""))

	return kommunenavn
end


def HentGyldigeKommunenummer()

	kommunenummerliste = "5018, 5016, 0619, 1504, 1820, 2012, 0438, 0929, 0429, 1871, 1424, 0118, 0906, 0214, 1026, 0220, 0124, 1247, 1428, 0425, 1027, 1547, 1576, 1421, 0221, 1244, 1264, 1554, 0219, 1418, 1854, 1933, 0814, 1922, 2028, 1839, 1929, 1201, 2024, 1811, 0928, 1114, 5017, 1867, 0821, 1804, 1145, 1219, 1438, 1813, 0938, 0941, 2025, 1850, 1827, 0511, 0602, 0817, 1926, 1443, 1551, 1232, 0125, 0420, 0237, 1101, 0427, 0229, 0434, 1211, 0541, 1853, 0937, 0729, 1003, 1841, 1265, 0227, 1141, 1222, 1429, 1246, 0615, 1859, 5049, 1004, 0631, 1401, 0439, 1432, 1129, 5048, 1548, 0106, 0215, 0919, 5036, 5014, 1241, 0831, 1940, 2023, 1430, 0522, 1838, 1532, 1557, 0234, 0911, 1122, 0502, 1445, 0617, 0534, 1825, 1234, 1919, 0904, 5045, 0423, 1411, 2011, 1119, 1866, 1034, 0101, 1571, 0403, 1849, 2004, 1534, 1517, 1903, 2015, 1826, 1106, 5011, 1832, 0618, 1515, 1818, 5013, 0827, 1133, 0138, 0620, 0612, 0715, 5026, 1444, 0701, 1416, 5046, 0239, 0628, 0111, 1413, 1917, 5053, 5054, 0935, 0532, 1431, 1227, 2021, 1936, 1149, 5030, 1120, 0604, 0402, 0815, 1001, 1505, 0622, 1911, 1943, 2017, 1238, 1037, 1224, 0829, 1144, 1422, 0712, 2022, 1419, 1822, 5052, 1931, 0512, 5037, 0626, 5042, 0501, 0926, 1263, 1029, 1920, 1851, 0514, 2014, 0230, 0415, 1112, 0533, 1834, 1426, 1032, 1938, 1924, 5031, 1002, 0119, 1021, 1266, 2018, 1256, 5023, 5028, 1837, 5034, 1545, 5027, 1252, 0623, 1502, 1874, 0104, 5051, 5040, 5005, 5044, 0238, 1805, 1433, 0625, 0236, 0616, 1828, 0216, 1543, 0830, 0233, 0819, 0542, 1524, 0516, 2019, 0418, 0538, 1942, 0633, 0807, 1228, 1868, 5021, 0217, 5024, 5015, 1523, 1520, 0441, 1243, 5020, 0301, 1253, 0528, 5047, 0624, 0521, 1259, 0544, 2020, 0805, 5043, 0135, 1260, 0228, 0128, 1833, 1127, 1539, 0716, 0432, 5022, 1142, 5061, 0520, 0605, 0412, 0901, 5019, 1836, 0632, 0121, 5025, 1856, 0627, 0136, 1923, 1840, 1242, 1514, 0713, 0710, 1102, 1546, 0105, 1135, 0822, 0517, 5032, 1441, 0828, 0621, 0811, 1046, 1913, 5029, 0231, 0213, 0806, 0127, 0513, 1941, 1529, 1573, 5041, 5012, 1420, 1018, 1111, 1124, 1412, 1812, 0536, 1017, 0540, 1845, 0519, 0419, 1925, 1870, 0226, 2030, 0123, 0417, 1103, 1848, 5004, 5035, 1221, 1526, 0430, 1939, 1130, 1525, 1449, 1531, 1134, 1245, 1563, 1566, 1216, 0711, 1528, 1121, 1560, 0826, 1852, 0833, 0436, 0704, 1928, 1835, 1927, 0122, 1902, 5001, 0428, 0914, 5033, 0437, 1223, 1146, 0235, 1231, 1516, 1233, 2027, 1151, 2003, 1857, 0515, 1865, 1439, 1251, 0426, 0137, 0940, 0545, 1511, 2002, 1824, 1815, 0912, 1014, 5038, 5039, 0211, 1535, 0543, 0529, 1860, 1816, 1417, 5050, 1160, 0834, 1519, 1235".split("")

	kommunenummer = strSplitByString(kommunenummerliste, ", ".split(""))

	return kommunenummer
end


def HentPoststedListe()

	poststeder = "OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, HASLUM, SANDVIKA, FORNEBU, JAR, RUD, H\u00d8VIKODDEN, SLEPENDEN, V\u00d8YENENGA, V\u00d8YENENGA, EIKSMARKA, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, STABEKK, H\u00d8VIK, H\u00d8VIK, LYSAKER, LYSAKER, LYSAKER, LYSAKER, H\u00d8VIK, LOMMEDALEN, FORNEBU, FORNEBU, \u00d8STER\u00c5S, KOLS\u00c5S, RYKKINN, SNAR\u00d8YA, SANDVIKA, SANDVIKA, SANDVIKA, V\u00d8YENENGA, SKUI, SLEPENDEN, GJETTUM, HASLUM, GJETTUM, RYKKINN, RYKKINN, LOMMEDALEN, RUD, KOLS\u00c5S, B\u00c6RUMS VERK, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, JAR, EIKSMARKA, FORNEBU, \u00d8STER\u00c5S, HOSLE, H\u00d8VIK, FORNEBU, BLOMMENHOLM, LYSAKER, SNAR\u00d8YA, STABEKK, STABEKK, ASKER, ASKER, ASKER, BILLINGSTAD, BILLINGSTAD, BILLINGSTAD, NESBRU, NESBRU, HEGGEDAL, VETTRE, ASKER, ASKER, ASKER, ASKER, ASKER, BORGEN, HEGGEDAL, VOLLEN, VOLLEN, VETTRE, VOLLEN, NESBRU, HVALSTAD, BILLINGSTAD, NES\u00d8YA, ASKER, SKI, SKI, SKI, LANGHUS, SIGGERUD, LANGHUS, SKI, VINTERBRO, KR\u00c5KSTAD, SKOTBU, KOLBOTN, KOLBOTN, SOFIEMYR, T\u00c5RN\u00c5SEN, TROLL\u00c5SEN, OPPEG\u00c5RD, OPPEG\u00c5RD, SOFIEMYR, KOLBOTN, OPPEG\u00c5RD, SVARTSKOG, TROLL\u00c5SEN, SIGGERUD, VINTERBRO, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, NESODDTANGEN, NESODDTANGEN, NESODDTANGEN, BJ\u00d8RNEMYR, FAGERSTRAND, NORDRE FROGN, NESODDTANGEN, FAGERSTRAND, FJELLSTRAND, NESODDEN, STR\u00d8MMEN, STR\u00d8MMEN, STR\u00d8MMEN, FINSTADJORDET, RASTA, L\u00d8RENSKOG, L\u00d8RENSKOG, FJELLHAMAR, L\u00d8RENSKOG, L\u00d8RENSKOG, FINSTADJORDET, RASTA, FJELLHAMAR, L\u00d8RENSKOG, KURLAND, SLATTUM, HAGAN, NITTEDAL, HAGAN, HAKADAL, HAKADAL, NITTEDAL, HAKADAL, HAKADAL, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, VESTBY, VESTBY, HVITSTEN, H\u00d8LEN, SON, SON, LARKOLLEN, LARKOLLEN, DILLING, RYGGE, RYGGE, RYGGE, SPERREBOTN, V\u00c5LER I \u00d8STFOLD, SVINNDAL, V\u00c5LER I \u00d8STFOLD, MOSS, MOSS, MOSS, MOSS, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, MANSTAD, MANSTAD, ENGELSVIKEN, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, R\u00c5DE, R\u00c5DE, SALTNES, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, TORP, TORP, TORP, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, SKJ\u00c6RHALDEN, SKJ\u00c6RHALDEN, VESTER\u00d8Y, VESTER\u00d8Y, HERF\u00d8L, NEDG\u00c5RDEN, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, GR\u00c5LUM, GR\u00c5LUM, GR\u00c5LUM, YVEN, GRE\u00c5KER, GRE\u00c5KER, GRE\u00c5KER, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, ISE, HAFSLUNDS\u00d8Y, HAFSLUNDS\u00d8Y, VARTEIG, BORGENHAUGEN, BORGENHAUGEN, BORGENHAUGEN, KLAVESTADHAUGEN, KLAVESTADHAUGEN, SKJEBERG, SKJEBERG, SKJEBERG, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, BERG I \u00d8STFOLD, TISTEDAL, TISTEDAL, TISTEDAL, TISTEDAL, SPONVIKA, KORNSJ\u00d8, AREMARK, AREMARK, ASKIM, ASKIM, ASKIM, SPYDEBERG, TOMTER, SKIPTVET, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, SKIPTVET, SPYDEBERG, SPYDEBERG, KNAPSTAD, TOMTER, HOB\u00d8L, ASKIM, ASKIM, ASKIM, ASKIM, MYSEN, MYSEN, MYSEN, SLITU, TR\u00d8GSTAD, TR\u00d8GSTAD, B\u00c5STAD, B\u00c5STAD, \u00d8RJE, \u00d8RJE, OTTEID, H\u00c6RLAND, EIDSBERG, RAKKESTAD, RAKKESTAD, DEGERNES, DEGERNES, RAKKESTAD, FETSUND, FETSUND, GAN, ENEBAKKNESET, FLATEBY, ENEBAKK, YTRE ENEBAKK, FLATEBY, YTRE ENEBAKK, S\u00d8RUMSAND, S\u00d8RUMSAND, S\u00d8RUM, S\u00d8RUM, BLAKER, BLAKER, R\u00c5N\u00c5SFOSS, AULI, AULI, AURSKOG, AURSKOG, BJ\u00d8RKELANGEN, BJ\u00d8RKELANGEN, R\u00d8MSKOG, SETSKOG, L\u00d8KEN, L\u00d8KEN, FOSSER, HEMNES, HEMNES, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, R\u00c6LINGEN, L\u00d8VENSTAD, KJELLER, FJERDINGBY, NORDBY, STR\u00d8MMEN, STR\u00d8MMEN, LILLESTR\u00d8M, SKJETTEN, BLYSTADLIA, LEIRSUND, FROGNER, FROGNER, L\u00d8VENSTAD, SKEDSMOKORSET, SKEDSMOKORSET, SKEDSMOKORSET, GJERDRUM, SKEDSMOKORSET, GJERDRUM, FJERDINGBY, SKJETTEN, KJELLER, LILLESTR\u00d8M, R\u00c6LINGEN, NANNESTAD, NANNESTAD, MAURA, \u00c5SGREINA, HOLTER, HOLTER, MAURA, KL\u00d8FTA, KL\u00d8FTA, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, MOGREINA, NORDKISA, ALGARHEIM, JESSHEIM, SESSVOLLMOEN, GARDERMOEN, GARDERMOEN, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, R\u00c5HOLT, R\u00c5HOLT, DAL, B\u00d8N, EIDSVOLL VERK, DAL, EIDSVOLL, EIDSVOLL, HURDAL, HURDAL, MINNESUND, FEIRING, MINNESUND, SKARNES, SKARNES, SL\u00c5STAD, DISEN\u00c5, SANDER, SAGSTUA, SAGSTUA, BRUVOLL, KNAPPER, GARDVIK, GARDVIK, AUSTVATN, \u00c5RNES, \u00c5RNES, VORMSUND, VORMSUND, BR\u00c5RUD, SKOGBYGDA, SKOGBYGDA, HVAM, OPPAKER, HVAM, FENSTAD, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, GRANLI, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, ROVERUD, ROVERUD, HOKK\u00c5SEN, LUNDERS\u00c6TER, BRANDVAL, \u00c5BOGEN, GALTERUD, AUSTMARKA, KONGSVINGER, KONGSVINGER, AUSTMARKA, SKOTTERUD, SKOTTERUD, TOB\u00d8L, VESTMARKA, MATRAND, MAGNOR, MAGNOR, GRUE FINNSKOG, GRUE FINNSKOG, KIRKEN\u00c6R, KIRKEN\u00c6R, GRINDER, NAMN\u00c5, ARNEBERG, FLISA, FLISA, GJES\u00c5SEN, \u00c5SNES FINNSKOG, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, OTTESTAD, OTTESTAD, OTTESTAD, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, FURNES, HAMAR, RIDABU, INGEBERG, VANG P\u00c5 HEDMARKEN, HAMAR, HAMAR, FURNES, RIDABU, VANG P\u00c5 HEDMARKEN, VALLSET, VALLSET, \u00c5SVANG, ROMEDAL, ROMEDAL, STANGE, STANGE, TANGEN, ESPA, TANGEN, L\u00d8TEN, L\u00d8TEN, ILSENG, \u00c5DALSBRUK, ILSENG, NES P\u00c5 HEDMARKEN, NES P\u00c5 HEDMARKEN, STAVSJ\u00d8, GAUPEN, RUDSH\u00d8GDA, RUDSH\u00d8GDA, N\u00c6ROSET, \u00c5SMARKA, BR\u00d8TTUM, BR\u00d8TTUM, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, MOELV, MOELV, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, HERNES, ELVERUM, S\u00d8RSKOGBYGDA, ELVERUM, ELVERUM, HERADSBYGD, J\u00d8MNA, ELVERUM, ELVERUM, ELVERUM, TRYSIL, TRYSIL, NYBERGSUND, \u00d8STBY, \u00d8STBY, LJ\u00d8RDALEN, LJ\u00d8RDALEN, PLASSEN, S\u00d8RE OSEN, T\u00d8RBERGET, JORDET, SLETT\u00c5S, BRASKEREIDFOSS, BRASKEREIDFOSS, V\u00c5LER I SOL\u00d8R, HASLEMOEN, GRAVBERGET, V\u00c5LER I SOL\u00d8R, ENGERDAL, ENGERDAL, HERADSBYGD, DREVSJ\u00d8, DREVSJ\u00d8, ELG\u00c5, S\u00d8RE OSEN, S\u00d8M\u00c5DALEN, RENA, RENA, OSEN, OSEN, ATNA, SOLLIA, HANESTAD, KOPPANG, KOPPANG, RENDALEN, RENDALEN, RENDALEN, RENDALEN, RENDALEN, TYNSET, TYNSET, TYLLDALEN, KVIKNE, KVIKNE, TOLGA, TOLGA, VINGELEN, \u00d8VERSJ\u00d8DALEN, OS I \u00d8STERDALEN, OS I \u00d8STERDALEN, DALSBYGDA, TUFSINGDALEN, ALVDAL, ALVDAL, FOLLDAL, FOLLDAL, GRIMSBU, DALHOLEN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, VINGROM, LILLEHAMMER, LILLEHAMMER, MESNALI, LILLEHAMMER, SJUSJ\u00d8EN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LISMARKA, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, MESNALI, VINGROM, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, F\u00c5BERG, LILLEHAMMER, F\u00c5BERG, SJUSJ\u00d8EN, LILLEHAMMER, RINGEBU, RINGEBU, VENABYGD, F\u00c5VANG, F\u00c5VANG, TRETTEN, \u00d8YER, \u00d8YER, TRETTEN, VINSTRA, VINSTRA, KVAM, KVAM, SK\u00c5BU, SK\u00c5BU, S\u00d8R-FRON, G\u00c5L\u00c5, S\u00d8R-FRON, S\u00d8R-FRON, \u00d8STRE GAUSDAL, \u00d8STRE GAUSDAL, SVINGVOLL, VESTRE GAUSDAL, VESTRE GAUSDAL, FOLLEBU, SVATSUM, ESPEDALEN, DOMB\u00c5S, DOMB\u00c5S, HJERKINN, DOVRE, DOVRESKOGEN, DOVRE, LESJA, LORA, LESJAVERK, LESJASKOG, BJORLI, OTTA, LESJA, SEL, H\u00d8VRINGEN, MYSUS\u00c6TER, OTTA, HEIDAL, NEDRE HEIDAL, SEL, HEIDAL, V\u00c5G\u00c5, LALM, LALM, TESSANDEN, V\u00c5G\u00c5, GARMO, LOM, B\u00d8VERDALEN, LOM, SKJ\u00c5K, NORDBERG, SKJ\u00c5K, GROTLI, GRAN, BRANDBU, ROA, JAREN, LUNNER, HARESTUA, GRUA, BRANDBU, GRINDVOLL, LUNNER, ROA, GRUA, HARESTUA, GRAN, BRANDBU, JAREN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, NORDRE TOTEN, GJ\u00d8VIK, BYBRUA, GJ\u00d8VIK, HUNNDALEN, RAUFOSS, RAUFOSS, BIRI, RAUFOSS, RAUFOSS, RAUFOSS, BIRI, BIRISTRAND, SNERTINGDAL, \u00d8VRE SNERTINGDAL, REINSVOLL, SNERTINGDAL, EINA, KOLBU, B\u00d8VERBRU, B\u00d8VERBRU, KOLBU, SKREIA, KAPP, LENA, LENA, REINSVOLL, EINA, SKREIA, KAPP, HOV, LAND\u00c5SBYGDA, FLUBERG, FALL, ENGER, HOV, DOKKA, ODNES, NORD-TORPA, AUST-TORPA, DOKKA, ETNEDAL, ETNEDAL, FAGERNES, FAGERNES, LEIRA I VALDRES, AURDAL, AURDAL, SKRAUTV\u00c5L, ULNES, LEIRA I VALDRES, TISLEIDALEN, BAGN, BAGN, REINLI, BEGNADALEN, BEGNA, HEGGENES, HEGGENES, ROGNE, SKAMMESTEIN, BEITO, BEITOST\u00d8LEN, BEITOST\u00d8LEN, R\u00d8N, R\u00d8N, SLIDRE, SLIDRE, LOMEN, RYFOSS, RYFOSS, VANG I VALDRES, VANG I VALDRES, \u00d8YE, TYINKRYSSET, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, MJ\u00d8NDALEN, MJ\u00d8NDALEN, STEINBERG, KROKSTADELVA, KROKSTADELVA, SOLBERGELVA, SOLBERGELVA, SOLBERGMOEN, SVELVIK, SVELVIK, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, BERGER, SANDE I VESTFOLD, SANDE I VESTFOLD, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOF, HOF, SUNDBYFOSS, EIDSFOSS, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, SEM, VEAR, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, HUS\u00d8YSUND, HUS\u00d8YSUND, DUKEN, T\u00d8NSBERG, TOR\u00d8D, TOR\u00d8D, SKALLESTAD, SKALLESTAD, N\u00d8TTER\u00d8Y, KJ\u00d8PMANNSKJ\u00c6R, VESTSKOGEN, KJ\u00d8PMANNSKJ\u00c6R, VEIERLAND, TJ\u00d8ME, HVASSER, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, MELSOMVIK, BARK\u00c5KER, ANDEBU, MELSOMVIK, STOKKE, STOKKE, ANDEBU, N\u00d8TTER\u00d8Y, REVETAL, TJ\u00d8ME, TOLVSR\u00d8D, \u00c5SG\u00c5RDSTRAND, MELSOMVIK, STOKKE, SEM, SEM, VEAR, VEAR, REVETAL, RAMNES, UNDRUMSDAL, V\u00c5LE, V\u00c5LE, \u00c5SG\u00c5RDSTRAND, NYKIRKE, HORTEN, HORTEN, HORTEN, BORRE, SKOPPUM, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, SKOPPUM, HORTEN, NYKIRKE, BORRE, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, KODAL, SANDEFJORD, KODAL, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, SVARSTAD, SVARSTAD, STEINSHOLT, TJODALYNG, TJODALYNG, KVELDE, KVELDE, LARVIK, STAVERN, STAVERN, STAVERN, STAVERN, HELGEROA, NEVLUNGHAVN, HELGEROA, HOKKSUND, HOKKSUND, HOKKSUND, HOKKSUND, VESTFOSSEN, VESTFOSSEN, FISKUM, SKOTSELV, SKOTSELV, \u00c5MOT, \u00c5MOT, \u00c5MOT, PRESTFOSS, PRESTFOSS, SOLUMSMOEN, EGGEDAL, NEDRE EGGEDAL, EGGEDAL, GEITHUS, GEITHUS, VIKERSUND, VIKERSUND, LIER, LIER, LIER, LIER, LIER, TRANBY, TRANBY, TRANBY, TRANBY, SYLLING, SYLLING, LIERSTRANDA, LIER, LIERSTRANDA, LIERSKOGEN, LIERSKOGEN, REISTAD, GULLAUG, GULLAUG, GULLAUG, SPIKKESTAD, SPIKKESTAD, R\u00d8YKEN, R\u00d8YKEN, HYGGEN, SLEMMESTAD, SLEMMESTAD, B\u00d8DALEN, \u00c5ROS, S\u00c6TRE, S\u00c6TRE, B\u00c5TST\u00d8, N\u00c6RSNES, N\u00c6RSNES, FILTVET, TOFTE, TOFTE, KANA, HOLMSBU, FILTVET, KLOKKARSTUA, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, JEVNAKER, JEVNAKER, BJONEROA, NES I \u00c5DAL, NES I \u00c5DAL, HALLINGBY, HALLINGBY, BJONEROA, HEDALEN, R\u00d8YSE, R\u00d8YSE, KROKKLEIVA, TYRISTRAND, TYRISTRAND, SOKNA, KR\u00d8DEREN, NORESUND, KR\u00d8DEREN, SOLLIH\u00d8GDA, FL\u00c5, NESBYEN, NESBYEN, NORESUND, TUNHOVD, FL\u00c5, GOL, GOL, HEMSEDAL, HEMSEDAL, \u00c5L, \u00c5L, HOL, HOL, HOVET, TORPO, GEILO, GEILO, DAGALI, USTAOSET, HAUGAST\u00d8L, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, HEISTADMOEN, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, SKOLLENBORG, SKOLLENBORG, FLESBERG, LAMPELAND, SVENE, LAMPELAND, LYNGDAL I NUMEDAL, SKOLLENBORG, ROLLAG, VEGGLI, VEGGLI, NORE, R\u00d8DBERG, R\u00d8DBERG, UVDAL, NORE, HVITTINGFOSS, HVITTINGFOSS, PASSEBEKK, TINN AUSTBYGD, HOVIN I TELEMARK, ATR\u00c5, MILAND, RJUKAN, RJUKAN, SAULAND, ATR\u00c5, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, HJARTDAL, GRANSHERAD, SAULAND, TUDDAL, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SILJAN, SILJAN, DRANGEDAL, T\u00d8RDAL, NESLANDSVATN, SANNIDAL, KRAGER\u00d8, KRAGER\u00d8, SK\u00c5T\u00d8Y, JOMFRULAND, KRAGER\u00d8 SKJ\u00c6RG\u00c5RD, SKIEN, SKIEN, STABBESTAD, KRAGER\u00d8, HELLE, KRAGER\u00d8, SKIEN, SANNIDAL, HELLE, DRANGEDAL, SKIEN, SKIEN, SKIEN, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, GVARV, H\u00d8RTE, AKKERHAUGEN, NORDAGUTU, LUNDE, ULEFOSS, ULEFOSS, LUNDE, B\u00d8 I TELEMARK, GVARV, SELJORD, KVITESEID, SELJORD, FLATDAL, \u00c5MOTSDAL, MORGEDAL, VR\u00c5LIOSEN, KVITESEID, VR\u00c5DAL, VR\u00c5DAL, NISSEDAL, TREUNGEN, RAULAND, FYRESDAL, DALEN, \u00c5MDALS VERK, TREUNGEN, RAULAND, FYRESDAL, DALEN, VINJE, EDLAND, VINJE, H\u00d8YDALSMO, VINJESVINGEN, EDLAND, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, LANGANGEN, PORSGRUNN, PORSGRUNN, BREVIK, STATHELLE, STATHELLE, STATHELLE, HERRE, STATHELLE, STATHELLE, LANGESUND, BREVIK, LANGESUND, LANGESUND, STATHELLE, PORSGRUNN, PORSGRUNN, PORSGRUNN, HERRE, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, SOLA, SOLA, R\u00d8YNEBERG, R\u00c6GE, TJELTA, SOLA, TANANGER, TANANGER, TANANGER, R\u00d8YNEBERG, TJELTA, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, RANDABERG, RANDABERG, RANDABERG, VASS\u00d8Y, HUNDV\u00c5G, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HUNDV\u00c5G, STAVANGER, HUNDV\u00c5G, HUNDV\u00c5G, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, SOLA, TANANGER, STAVANGER, J\u00d8RPELAND, IDSE, FORSAND, FORSAND, TAU, S\u00d8R-HIDLE, TAU, J\u00d8RPELAND, LYSEBOTN, FL\u00d8YRLI, SONGESAND, HJELMELAND, J\u00d8SENFJORDEN, \u00c5RDAL I RYFYLKE, FISTER, SKIFTUN, HJELMELAND, RENNES\u00d8Y, VESTRE \u00c5M\u00d8Y, BRIMSE, AUSTRE \u00c5M\u00d8Y, MOSTER\u00d8Y, BRU, RENNES\u00d8Y, FINN\u00d8Y, FINN\u00d8Y, TALGJE, FOGN, HELG\u00d8Y I RYFYLKE, BYRE, S\u00d8RBOKN, SJERNAR\u00d8Y, NORD-HIDLE, SJERNAR\u00d8Y, KVITS\u00d8Y, KVITS\u00d8Y, SKARTVEIT, OMBO, FOLD\u00d8Y, SAUDA, SAUDA, SAUDASJ\u00d8EN, VANVIK, SAND, ERFJORD, JELSA, HEBNES, SULDALSOSEN, SAND, SULDALSOSEN, NESFLATEN, KOPERVIK, TORVASTAD, AVALDSNES, KVALAV\u00c5G, H\u00c5VIK, \u00c5KREHAMN, SANDVE, STOL, S\u00c6VELANDSVIK, VEAV\u00c5GEN, SKUDENESHAVN, KOPERVIK, KOPERVIK, VEAV\u00c5GEN, \u00c5KREHAMN, SKUDENESHAVN, TORVASTAD, AVALDSNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, FIGGJO, OLTEDAL, DIRDAL, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, BRYNE, BRYNE, UNDHEIM, ORRE, BRYNE, BRYNE, BRYNE, LYE, LYE, BRYNE, KLEPPE, KLEPP STASJON, VOLL, KVERNALAND, KVERNALAND, KLEPP STASJON, KLEPPE, VARHAUG, SIREV\u00c5G, VIGRESTAD, BRUSAND, SIREV\u00c5G, N\u00c6RB\u00d8, N\u00c6RB\u00d8, VARHAUG, VIGRESTAD, EGERSUND, EGERSUND, EGERSUND, EGERSUND, EGERSUND, HELLVIK, HELLELAND, EGERSUND, EGERSUND, HAUGE I DALANE, HAUGE I DALANE, VIKES\u00c5, HELLELAND, BJERKREIM, VIKES\u00c5, OLTEDAL, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, \u00c5NA-SIRA, HIDRASUND, ANDABEL\u00d8Y, GYLAND, SIRA, SIRA, TONSTAD, TONSTAD, TJ\u00d8RHOM, MOI, HOVSHERAD, UALAND, MOI, KVINLOG, KVINESDAL, \u00d8YESTRANDA, FEDA, KVINESDAL, KVINESDAL, KVINESDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, HOLUM, LINDESNES, LINDESNES, LINDESNES, LINDESNES, LINDESNES, KONSMO, KONSMO, KOLLUNGTVEIT, BYREMO, \u00d8YSLEB\u00d8, MARNARDAL, MARNARDAL, BJELLAND, \u00c5SERAL, \u00c5SERAL, FOSSDAL, FARSUND, FARSUND, FARSUND, FARSUND, FARSUND, VANSE, VANSE, VANSE, BORHAUG, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, KORSHAMN, KV\u00c5S, SNARTEMO, TINGVATN, EIKEN, EIKEN, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KARDEMOMME BY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, MOSBY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, NODELAND, FINSLAND, BRENN\u00c5SEN, FINSLAND, HAMRESANDEN, KJEVIK, TVEIT, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, BRENN\u00c5SEN, NODELAND, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, TVEIT, VENNESLA, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, H\u00c6GELAND, H\u00c6GELAND, IVELAND, IVELAND, VATNESTR\u00d8M, EVJE, EVJE, EVJE, HORNNES, BYGLANDSFJORD, GRENDI, BYGLAND, BYGLAND, VALLE, VALLE, RYSSTAD, RYSSTAD, BYKLE, HOVDEN I SETESDAL, HOVDEN I SETESDAL, BIRKELAND, HEREFOSS, ENGESLAND, H\u00d8V\u00c5G, BREKKEST\u00d8, LILLESAND, LILLESAND, LILLESAND, H\u00d8V\u00c5G, LILLESAND, BIRKELAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, KONGSHAVN, SALTR\u00d8D, KOLBJ\u00d8RNSVIK, HIS, F\u00c6RVIK, FROLAND, RYKENE, RYKENE, NEDENES, BJORBEKK, ARENDAL, FROLANDS VERK, MJ\u00c5VATN, HYNNEKLEIV, MYKLAND, RISDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, SALTR\u00d8D, F\u00c6RVIK, HIS, NEDENES, FROLAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, NELAUG, \u00c5MLI, \u00c5MLI, SEL\u00c5SVATN, D\u00d8LEMO, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, HOMBORSUND, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, TVEDESTRAND, TVEDESTRAND, TVEDESTRAND, SONGE, LYNG\u00d8R, GJEVING, VESTRE SAND\u00d8YA, BOR\u00d8Y, STAUB\u00d8, STAUB\u00d8, NES VERK, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, SUNDEBRU, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, SUNDEBRU, AKLAND, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, EIDSV\u00c5GNESET, EIDSV\u00c5G I \u00c5SANE, EIDSV\u00c5G I \u00c5SANE, \u00d8VRE ERVIK, SALHUS, HORDVIK, HYLKJE, BREISTEIN, TERTNES, TERTNES, ULSET, ULSET, ULSET, ULSET, ULSET, ULSET, MORVIK, MORVIK, NYBORG, NYBORG, NYBORG, FLAKTVEIT, FLAKTVEIT, MJ\u00d8LKER\u00c5EN, MJ\u00d8LKER\u00c5EN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, STRAUMSGREND, B\u00d8NES, B\u00d8NES, B\u00d8NES, B\u00d8NES, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, BJ\u00d8RNDALSTR\u00c6, LODDEFJORD, LODDEFJORD, LODDEFJORD, MATHOPEN, LODDEFJORD, BJ\u00d8R\u00d8YHAMN, LODDEFJORD, GODVIK, OLSVIK, OLSVIK, OS, OS, OS, OS, OS, S\u00d8FTELAND, OS, OS, OS, OS, S\u00d8FTELAND, LEPS\u00d8Y, LYSEKLOSTER, LYSEKLOSTER, LEPS\u00d8Y, HAGAVIK, NORDSTR\u00d8NO, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, KALANDSEIDET, PARADIS, PARADIS, PARADIS, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, FANA, FANA, S\u00d8REIDGREND, S\u00d8REIDGREND, SANDSLI, SANDSLI, KOKSTAD, BLOMSTERDALEN, HJELLESTAD, INDRE ARNA, INDRE ARNA, ARNATVEIT, TRENGEREID, GARNES, YTRE ARNA, ESPELAND, HAUKELAND, VALESTRANDSFOSSEN, LONEV\u00c5G, FOTLANDSV\u00c5G, TYSSEBOTNEN, BRUVIK, HAUS, VALESTRANDSFOSSEN, LONEV\u00c5G, HAUS, KLEPPEST\u00d8, KLEPPEST\u00d8, STRUSSHAMN, FOLLESE, HETLEVIK, FLORV\u00c5G, ERDAL, ASK, KLEPPEST\u00d8, KLEPPEST\u00d8, HAUGLANDSHELLA, KJERRGARDEN, KJERRGARDEN, HERDLA, STRUSSHAMN, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, FOLLESE, ASK, HAUGLANDSHELLA, FLORV\u00c5G, RONG, TJELDST\u00d8, HELLES\u00d8Y, HERNAR, TJELDST\u00d8, RONG, STRAUME, STRAUME, STRAUME, KNARREVIK, \u00c5GOTNES, \u00c5GOTNES, BRATTHOLMEN, STRAUME, STRAUME, KNARREVIK, FJELL, FJELL, KOLLTVEIT, \u00c5GOTNES, TUR\u00d8Y, MISJE, SKOGSV\u00c5G, STEINSLAND, KLOKKARVIK, STEINSLAND, T\u00c6LAV\u00c5G, GLESV\u00c6R, SKOGSV\u00c5G, TORANGSV\u00c5G, BAKKASUND, M\u00d8KSTER, LITLAKALS\u00d8Y, STOREB\u00d8, STOREB\u00d8, KOLBEINSVIK, VESTRE VINNESV\u00c5G, BEKKJARVIK, STOLMEN, BEKKJARVIK, STORD, STORD, STORD, STORD, STORD, STORD, SAGV\u00c5G, STORD, SAGV\u00c5G, STORD, STORD, HUGLO, STORD, STORD, STORD, STORD, FITJAR, FITJAR, RUBBESTADNESET, BRANDASUND, URANGSV\u00c5G, FOLDR\u00d8YHAMN, BREMNES, FINN\u00c5S, MOSTERHAMN, B\u00d8MLO, ESPEV\u00c6R, BREMNES, MOSTERHAMN, B\u00d8MLO, SUNDE I SUNNHORDLAND, VALEN, SANDVOLL, UT\u00c5KER, S\u00c6B\u00d8VIK, HALSN\u00d8Y KLOSTER, H\u00d8YLANDSBYGD, ARNAVIK, FJELBERG, HUSNES, HER\u00d8YSUNDET, USKEDALEN, DIMMELSVIK, USKEDALEN, ROSENDAL, SEIMSFOSS, SNILSTVEIT\u00d8Y, L\u00d8FALLSTRAND, \u00c6NES, MAURANGER, HUSNES, S\u00c6B\u00d8VIK, ROSENDAL, MATRE, \u00c5KRA, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KARMSUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KOLNES, KARMSUND, VORMEDAL, VORMEDAL, R\u00d8YKSUND, UTSIRA, FE\u00d8Y, R\u00d8V\u00c6R, SVEIO, AUKLANDSHAMN, VALEV\u00c5G, F\u00d8RDE I HORDALAND, F\u00d8RDE I HORDALAND, SVEIO, NEDSTRAND, BOKN, NEDSTRAND, F\u00d8RRESFJORDEN, TYSV\u00c6RV\u00c5G, HERVIK, SKJOLDASTRAUMEN, VIKEBYGD, BOKN, AKSDAL, SKJOLD, AKSDAL, \u00d8VRE VATS, NEDRE VATS, \u00d8LEN, \u00d8LENSV\u00c5G, VIKEDAL, BJOA, SANDEID, VIKEDAL, \u00d8LEN, SANDEID, ETNE, ETNE, SK\u00c5NEVIK, SK\u00c5NEVIK, F\u00d8RRESFJORDEN, MARKHUS, FJ\u00c6RA, NORHEIMSUND, NORHEIMSUND, NORHEIMSUND, \u00d8YSTESE, \u00c5LVIK, \u00d8YSTESE, STEINST\u00d8, \u00c5LVIK, T\u00d8RVIKBYGD, KYSNESSTRAND, JONDAL, HERAND, JONDAL, STRANDEBARM, STRANDEBARM, OMASTRAND, OMASTRAND, HATLESTRAND, VARALDS\u00d8Y, \u00d8LVE, EIKELANDSOSEN, FUSA, HOLMEFJORD, STRANDVIK, S\u00c6VAREID, S\u00c6VAREID, NORDTVEITGREND, BALDERSHEIM, FUSA, EIKELANDSOSEN, TYSSE, TYSSE, \u00c5RLAND, \u00c5RLAND, TYSNES, REKSTEREN, UGGDAL, FLATR\u00c5KER, LUNDEGREND, \u00c5RBAKKA, ONARHEIM, UGGDAL, TYSNES, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, EVANGER, VOSS, VOSS, SKULESTADMO, SKULESTADMO, VOSSESTRAND, VOSSESTRAND, VOSS, STALHEIM, MYRDAL, FINSE, STANGHELLE, DALEKVAM, DALEKVAM, BOLSTAD\u00d8YRI, STANGHELLE, VAKSDAL, VAKSDAL, STAMNES, EIDSLANDET, MODALEN, ULVIK, ULVIK, MODALEN, GRANVIN, VALLAVIK, GRANVIN, AURLAND, FL\u00c5M, FL\u00c5M, AURLAND, UNDREDAL, GUDVANGEN, STYVI, ODDA, ODDA, ODDA, R\u00d8LDAL, SKARE, TYSSEDAL, HOVLAND, N\u00c5, N\u00c5, GRIMO, UTNE, UTNE, KINSARVIK, LOFTHUS, KINSARVIK, EIDFJORD, \u00d8VRE EIDFJORD, V\u00d8RINGSFOSS, EIDFJORD, LOFTHUS, KINSARVIK, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, ISDALST\u00d8, ISDALST\u00d8, ISDALST\u00d8, FREKHAUG, ALVERSUND, ISDALST\u00d8, ALVERSUND, SEIM, EIKANGERV\u00c5G, ISDALST\u00d8, HJELM\u00c5S, ISDALST\u00d8, ROSSLAND, FREKHAUG, FREKHAUG, MANGER, B\u00d8V\u00c5GEN, MANGER, B\u00d8V\u00c5GEN, S\u00c6B\u00d8V\u00c5GEN, SLETTA, AUSTRHEIM, AUSTRHEIM, FEDJE, FEDJE, LIND\u00c5S, FONNES, FONNES, MONGSTAD, LIND\u00c5S, HUNDVIN, MYKING, DALS\u00d8YRA, BREKKE, BJORDAL, DALS\u00d8YRA, BREKKE, BJORDAL, EIVINDVIK, EIVINDVIK, BYRKNES\u00d8Y, \u00c5NNELAND, MJ\u00d8MNA, BYRKNES\u00d8Y, MASFJORDNES, MASFJORDNES, HAUGSV\u00c6R, MATREDAL, HAUGSV\u00c6R, HOSTELAND, HOSTELAND, OSTEREIDET, OSTEREIDET, VIKANES, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, LANGEV\u00c5G, EIDSNES, FISKARSTRAND, MAUSEIDV\u00c5G, EIDSNES, FISKARSTRAND, LANGEV\u00c5G, VIGRA, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, VALDER\u00d8YA, VALDER\u00d8YA, GISKE, GOD\u00d8YA, GOD\u00d8YA, ELLINGS\u00d8Y, VALDER\u00d8YA, VIGRA, HAREID, BRANDAL, HJ\u00d8RUNGAV\u00c5G, HADDAL, ULSTEINVIK, ULSTEINVIK, EIKSUND, HAREID, TJ\u00d8RV\u00c5G, MOLTUSTRANDA, MOLTUSTRANDA, GJERDSVIKA, GURSK\u00d8Y, GURSK\u00d8Y, GURSKEN, GJERDSVIKA, LARSNES, LARSNES, KVAMS\u00d8Y, KVAMS\u00d8Y, SANDSHAMN, SANDSHAMN, FOSNAV\u00c5G, FOSNAV\u00c5G, FOSNAV\u00c5G, LEIN\u00d8Y, B\u00d8LANDET, RUNDE, NERLANDS\u00d8Y, FOSNAV\u00c5G, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, AUSTEFJORDEN, FOLKESTAD, LAUVSTAD, LAUVSTAD, SYVDE, FISK\u00c5, SYVDE, ROVDE, EIDS\u00c5, FISK\u00c5, SYLTE, \u00c5HEIM, \u00c5HEIM, \u00c5RAM, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, HOVDEBYGDA, HOVDEBYGDA, S\u00c6B\u00d8, S\u00c6B\u00d8, VARTDAL, VARTDAL, BARSTADVIK, TRANDAL, STORESTANDAL, BJ\u00d8RKE, NORANGSFJORDEN, STRANDA, STRANDA, VALLDAL, VALLDAL, LIABYGDA, TAFJORD, NORDDAL, EIDSDAL, GEIRANGER, GEIRANGER, HELLESYLT, HELLESYLT, STRAUMGJERDE, IKORNNES, IKORNNES, HUNDEIDVIK, SYKKYLVEN, STRAUMGJERDE, SYKKYLVEN, \u00d8RSKOG, \u00d8RSKOG, STORDAL, EIDSDAL, STORDAL, SKODJE, SKODJE, TENNFJORD, VATNE, BRATTV\u00c5G, HILDRE, S\u00d8VIK, S\u00d8VIK, BRATTV\u00c5G, VATNE, STOREKALV\u00d8Y, HARAMS\u00d8Y, HARAMS\u00d8Y, KJERSTAD, LONGVA, FJ\u00d8RTOFT, \u00c5NDALSNES, \u00c5NDALSNES, VEBLUNGSNES, INNFJORDEN, ISFJORDEN, VERMA, VERMA, ISFJORDEN, EIDSBYGDA, \u00c5FARNES, \u00c5FARNES, MITTET, VISTDAL, VISTDAL, M\u00c5NDALEN, M\u00c5NDALEN, V\u00c5GSTRANDA, V\u00c5GSTRANDA, FIKSDAL, VESTNES, TRESFJORD, VIKEBUKT, TOMREFJORD, FIKSDAL, REKDAL, VIKEBUKT, TRESFJORD, TOMREFJORD, VESTNES, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, AUREOSEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, SEKKEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, BUD, BUD, HUSTAD, MOLDE, MOLDE, MOLDE, ELNESV\u00c5GEN, TORNES I ROMSDAL, FARSTAD, MALMEFJORDEN, FARSTAD, ELNESV\u00c5GEN, HJELSET, KLEIVE, KLEIVE, HJELSET, KORTGARDEN, SK\u00c5LA, BOLS\u00d8YA, SK\u00c5LA, EIDSV\u00c5G I ROMSDAL, EIDSV\u00c5G I ROMSDAL, RAUDSAND, ERESFJORD, ERESFJORD, EIKESDAL, MIDSUND, MIDSUND, AUKRA, AUKRA, ONA, SAND\u00d8Y, HAR\u00d8Y, ORTEN, HAR\u00d8Y, MYKLEBOST, EIDE, LYNGSTAD, VEVANG, EIDE, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, SM\u00d8LA, SM\u00d8LA, TUSTNA, TUSTNA, SUNNDALS\u00d8RA, SUNNDALS\u00d8RA, \u00d8KSENDAL, FURUGRENDA, GR\u00d8A, GJ\u00d8RA, GJ\u00d8RA, \u00c5LVUNDEID, \u00c5LVUNDFJORD, \u00c5LVUNDFJORD, TINGVOLL, MEISINGSET, TORJULV\u00c5GEN, TINGVOLL, BATNFJORDS\u00d8RA, BATNFJORDS\u00d8RA, GJEMNES, ANGVIK, FLEMMA, OSMARKA, TORVIKBUKT, KVANNE, TORVIKBUKT, STANGVIK, B\u00d8FJORDEN, B\u00c6VERFJORD, TODALEN, SURNADAL, SURNADAL, \u00d8VRE SURNADAL, VIND\u00d8LA, SURNADAL, RINDAL, RINDALSSKOGEN, RINDAL, \u00d8YDEGARD, \u00d8YDEGARD, KVISVIK, HALSANAUSTAN, V\u00c5GLAND, VALS\u00d8YBOTN, VALS\u00d8YFJORD, V\u00c5GLAND, AURE, AURE, MJOSUNDET, FOLDFJORDEN, VIHALS, LESUND, KJ\u00d8RSVIKBUGEN, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, DEKNEPOLLEN, RAUDEBERG, BRYGGJA, RAUDEBERG, BRYGGJA, ALMENNINGEN, SILDA, BARMEN, HUSEV\u00c5G, FLATRAKET, DEKNEPOLLEN, SKATESTRAUMEN, SVELGEN, SVELGEN, BREMANGER, BREMANGER, KALV\u00c5G, KALV\u00c5G, DAVIK, RUGSUND, \u00c5LFOTEN, SELJE, SELJE, STADLANDET, STADLANDET, HORNINDAL, HORNINDAL, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, KJ\u00d8LSDALEN, ST\u00c5RHEIM, LOTE, HOLM\u00d8YANE, STRYN, STRYN, STRYN, OLDEN, OLDEN, LOEN, LOEN, OLDEDALEN, BRIKSDALSBRE, INNVIK, INNVIK, BLAKS\u00c6TER, HOPLAND, UTVIK, HJELLEDALEN, OPPSTRYN, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, HAUKEDALEN, F\u00d8RDE, F\u00d8RDE, SANDANE, SANDANE, SANDANE, BYRKJELO, BREIM, HESTENES\u00d8YRA, HYEN, BYRKJELO, HYEN, SKEI I J\u00d8LSTER, SKEI I J\u00d8LSTER, VASSENDEN, FJ\u00c6RLAND, VASSENDEN, FJ\u00c6RLAND, KAUPANGER, SOGNDAL, SOGNDAL, SOGNDAL, KAUPANGER, FR\u00d8NNINGEN, SOGNDAL, FARDAL, SLINDE, LEIKANGER, LEIKANGER, GAUPNE, HAFSLO, GAUPNE, HAFSLO, ORNES, JOSTEDAL, LUSTER, MARIFJ\u00d8RA, LUSTER, H\u00d8YHEIMSVIK, SKJOLDEN, FORTUN, VEITASTROND, SOLVORN, \u00c5RDALSTANGEN, \u00d8VRE \u00c5RDAL, \u00d8VRE \u00c5RDAL, \u00c5RDALSTANGEN, L\u00c6RDAL, L\u00c6RDAL, BORGUND, VIK I SOGN, VIK I SOGN, VANGSNES, FEIOS, FRESVIK, BALESTRAND, BALESTRAND, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, KINN, FLOR\u00d8, SVAN\u00d8YBUKT, ROGNALDSV\u00c5G, BAREKSTAD, BATALDEN, S\u00d8R-SKORPA, TANS\u00d8Y, HARDBAKKE, HARDBAKKE, KRAKHELLA, YTR\u00d8YGREND, KOLGROV, HERSVIKBYGDA, EIKEFJORD, EIKEFJORD, SVORTEVIK, STAVANG, LAVIK, LAVIK, LEIRVIK I SOGN, LEIRVIK I SOGN, HYLLESTAD, S\u00d8RB\u00d8V\u00c5G, S\u00d8RB\u00d8V\u00c5G, DALE I SUNNFJORD, DALE I SUNNFJORD, KORSSUND, GUDDAL, HELLEVIK I FJALER, FLEKKE, STRAUMSNES, SANDE I SUNNFJORD, SANDE I SUNNFJORD, SKILBREI, BYGSTAD, BYGSTAD, VIKSDALEN, ASKVOLL, HOLMEDAL, KVAMMEN, STONGFJORDEN, ATL\u00d8Y, V\u00c6RLANDET, BULANDET, ASKVOLL, H\u00d8YANGER, H\u00d8YANGER, KYRKJEB\u00d8, VADHEIM, VADHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, RANHEIM, RANHEIM, RANHEIM, RANHEIM, JONSVATNET, JAKOBSLI, JAKOBSLI, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, BOSBERG, TRONDHEIM, HEIMDAL, SPONGDAL, TILLER, SAUPSTAD, FLAT\u00c5SEN, HEIMDAL, SJETNEMARKA, KATTEM, LEINSTRAND, HEIMDAL, HEIMDAL, TILLER, TILLER, TILLER, SAUPSTAD, SAUPSTAD, FLAT\u00c5SEN, RISSA, RISSA, STADSBYGD, FEV\u00c5G, HASSELVIKA, HASSELVIKA, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, STADSBYGD, LEKSVIK, LEKSVIK, VANVIKAN, VANVIKAN, OPPHAUG, BREKSTAD, BREKSTAD, OPPHAUG, UTHAUG, STORFOSNA, STORFOSNA, KR\u00c5KV\u00c5G, GARTEN, LEKSA, BJUGN, BJUGN, LYS\u00d8YSUNDET, OKSVOLL, TARVA, VALLERSUND, LYS\u00d8YSUNDET, \u00c5FJORD, \u00c5FJORD, REVSNES, STOKK\u00d8Y, LINES\u00d8YA, REVSNES, STOKK\u00d8Y, ROAN, ROAN, BESSAKER, BRANDSFJORD, KYRKS\u00c6TER\u00d8RA, KYRKS\u00c6TER\u00d8RA, VINJE\u00d8RA, HELLANDSJ\u00d8EN, KORSVEGEN, KORSVEGEN, G\u00c5SBAKKEN, MELHUS, MELHUS, MELHUS, GIMSE, KV\u00c5L, LUNDAMO, LUNDAMO, LER, LER, HOVIN I GAULDAL, HOVIN I GAULDAL, HITRA, HITRA, ANSNES, KNARRLAGSUND, KVENV\u00c6R, KNARRLAGSUND, KVENV\u00c6R, SANDSTAD, HESTVIKA, MELANDSJ\u00d8, DOLM\u00d8Y, SUNDLANDET, HEMNSKJELA, SNILLFJORD, SNILLFJORD, SISTRANDA, SISTRANDA, HAMARVIK, HAMARVIK, KVERVA, KVERVA, TITRAN, DYRVIK, NORDDYR\u00d8Y, NORDDYR\u00d8Y, SULA, BOG\u00d8YV\u00c6R, MAUSUND, GJ\u00c6SINGEN, S\u00d8RBUR\u00d8Y, SAU\u00d8Y, SOKNEDAL, SOKNEDAL, ST\u00d8REN, ST\u00d8REN, ROGNES, BUDALEN, ORKANGER, ORKANGER, ORKANGER, GJ\u00d8LME, LENSVIK, LENSVIK, AGDENES, AGDENES, FANNREM, FANNREM, SVORKMO, SVORKMO, L\u00d8KKEN VERK, L\u00d8KKEN VERK, STOR\u00c5S, STOR\u00c5S, JERPSTAD, MELDAL, MELDAL, OPPDAL, OPPDAL, L\u00d8NSET, VOGNILL, DRIVA, BUVIKA, BUVIKA, B\u00d8RSA, VIGGJA, EGGKLEIVA, SKAUN, SKAUN, B\u00d8RSA, R\u00d8ROS, BREKKEBYGD, GL\u00c5MOS, R\u00d8ROS, \u00c5LEN, HALTDALEN, \u00c5LEN, SINGS\u00c5S, SINGS\u00c5S, SINGS\u00c5S, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, SKATVAL, SKATVAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, HELL, ELVARLI, HEGRA, FLORNES, HEGRA, MER\u00c5KER, MER\u00c5KER, KOPPER\u00c5, KL\u00c6BU, KL\u00c6BU, TANEM, HOMMELVIK, HOMMELVIK, VIKHAMMER, SAKSVIK, MALVIK, VIKHAMMER, HELL, SELBU, SELBU, SELBU, SELBUSTRAND, TYDAL, TYDAL, FLAKNAN, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, SKOGN, SKOGN, MARKABYGDA, RONGLAN, EKNE, YTTER\u00d8Y, \u00c5SEN, \u00c5SEN, \u00c5SENFJORD, FROSTA, FROSTA, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VUKU, VUKU, INDER\u00d8Y, INDER\u00d8Y, INDER\u00d8Y, MOSVIK, MOSVIK, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINSDALEN, STEINSDALEN, YTTERV\u00c5G, HEPS\u00d8Y, OPPLAND, HASV\u00c5G, S\u00c6TERVIK, NAMDALSEID, NAMDALSEID, SN\u00c5SA, SN\u00c5SA, FLATANGER, FLATANGER, NORD-STATLAND, MALM, MALM, FOLLAFOSS, FOLLAFOSS, VERRABOTN, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, SALSNES, LUND, FOSSLANDSOSEN, SPILLUM, SPILLUM, BANGSUND, BANGSUND, J\u00d8A, SKAGE I NAMDALEN, OVERHALLA, OVERHALLA, SKAGE I NAMDALEN, GRONG, GRONG, HARRAN, HARRAN, KONGSMOEN, H\u00d8YLANDET, H\u00d8YLANDET, NORDLI, NORDLI, S\u00d8RLI, S\u00d8RLI, NAMSSKOGAN, NAMSSKOGAN, TRONES, SKOROVATN, BREKKVASSELV, LIMINGEN, LIMINGEN, R\u00d8RVIK, R\u00d8RVIK, R\u00d8RVIK, OTTERS\u00d8Y, OTTERS\u00d8Y, INDRE N\u00c6R\u00d8Y, ABELV\u00c6R, SALSBRUKET, KOLVEREID, KOLVEREID, GJERDINGA, TERR\u00c5K, TERR\u00c5K, HARANGSFJORD, BINDALSEIDET, BINDALSEIDET, FOLDEREID, FOLDEREID, NAUSTBUKTA, GUTVIK, LEKA, LEKA, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, TVERLANDET, SALTSTRAUMEN, SALTSTRAUMEN, TVERLANDET, V\u00c6R\u00d8Y, V\u00c6R\u00d8Y, R\u00d8ST, R\u00d8ST, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, KJERRING\u00d8Y, FLEINV\u00c6R, HELLIGV\u00c6R, BLIKSV\u00c6R, GIV\u00c6R, LANDEGODE, JAN MAYEN, MISV\u00c6R, SKJERSTAD, BREIVIK I SALTEN, MISV\u00c6R, MOLDJORD, TOLL\u00c5, MOLDJORD, NYG\u00c5RDSJ\u00d8EN, YTRE BEIARN, SANDHORN\u00d8Y, S\u00d8RARN\u00d8Y, S\u00d8RARN\u00d8Y, NORDARN\u00d8Y, INNDYR, INNDYR, STORVIK, REIP\u00c5, NEVERDAL, \u00d8RNES, \u00d8RNES, MEL\u00d8Y, BOLGA, ST\u00d8TT, GLOMFJORD, GLOMFJORD, ENGAV\u00c5GEN, ENGAV\u00c5GEN, HALSA, HALSA, MYKEN, MELFJORDBOTN, V\u00c5GAHOLMEN, \u00c5GSKARDET, V\u00c5GAHOLMEN, TJONGSFJORDEN, JEKTVIK, NORDVERNES, GJERSVIKGRENDA, S\u00d8RFJORDEN, R\u00d8D\u00d8Y, GJER\u00d8Y, SELS\u00d8YVIK, STORSELS\u00d8Y, NORDNES\u00d8Y, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, VALNESFJORD, FAUSKE, FAUSKE, R\u00d8SVIK, STRAUMEN, SULITJELMA, SULITJELMA, STRAUMEN, VALNESFJORD, ROGNAN, ROGNAN, R\u00d8KLAND, R\u00d8KLAND, INNHAVET, INNHAVET, ENGAN, M\u00d8RSVIKBOTN, DRAG, DRAG, NEVERVIK, MUSKEN, STORJORD I TYSFJORD, ULVSV\u00c5G, STOR\u00c5, LEINESFJORD, LEINESFJORD, LEINES, NORDFOLD, ENGEL\u00d8YA, BOG\u00d8Y, ENGEL\u00d8YA, SKUTVIK, HAMAR\u00d8Y, TRAN\u00d8Y, HAMAR\u00d8Y, SVOLV\u00c6R, SVOLV\u00c6R, SVOLV\u00c6R, KABELV\u00c5G, KABELV\u00c5G, HENNINGSV\u00c6R, HENNINGSV\u00c6R, KLEPPSTAD, GIMS\u00d8YSAND, LAUKVIK, LAUPSTAD, STR\u00d8NSTAD, SKROVA, BRETTESNES, STORFJELL, DIGERMULEN, TENGELFJORD, MYRLAND, STORMOLLA, STAMSUND, SENNESVIK, VALBERG, B\u00d8STAD, B\u00d8STAD, LEKNES, GRAVDAL, BALLSTAD, BALLSTAD, LEKNES, GRAVDAL, STAMSUND, RAMBERG, NAPP, SUND I LOFOTEN, FREDVANG, RAMBERG, REINE, S\u00d8RV\u00c5GEN, S\u00d8RV\u00c5GEN, REINE, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, GULLESFJORD, L\u00d8DINGEN, L\u00d8DINGEN, VESTBYGD, KVITNES, HENNES, SORTLAND, SORTLAND, SORTLAND, BARKESTAD, TUNSTAD, MYRE, ALSV\u00c5G, ST\u00d8, MYRE, MELBU, LONKAN, STOKMARKNES, STOKMARKNES, MELBU, STRAUMSJ\u00d8EN, B\u00d8 I VESTER\u00c5LEN, B\u00d8 I VESTER\u00c5LEN, STRAUMSJ\u00d8EN, ANDENES, BLEIK, ANDENES, RIS\u00d8YHAMN, DVERBERG, N\u00d8SS, NORDMELA, RIS\u00d8YHAMN, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, BEISFJORD, ELVEG\u00c5RD, BJERKVIK, BJERKVIK, BOGEN I OFOTEN, LILAND, T\u00c5RSTAD, EVENES, BOGEN I OFOTEN, BALLANGEN, KJELDEBOTN, BALLANGEN, KJ\u00d8PSVIK, KJ\u00d8PSVIK, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, SKONSENG, MO I RANA, DALSGRENDA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, STORFORSHEI, MO I RANA, STORFORSHEI, HEMNESBERGET, HEMNESBERGET, FINNEIDFJORD, BJERKA, BJERKA, KORGEN, BLEIKVASSLIA, KORGEN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, ELSFJORD, TROFORS, TROFORS, HATTFJELLDAL, HATTFJELLDAL, NESNA, NESNA, VIKHOLMEN, HUSBY, SAURA, UTSKARPEN, BRATLAND, ALDRA, STUVLAND, STOKKV\u00c5GEN, NORD-SOLV\u00c6R, SELV\u00c6R, INDRE KVAR\u00d8Y, TONNES, KONSVIKOSEN, KONSVIKOSEN, \u00d8RESVIK, SLENESET, LOVUND, LUR\u00d8Y, LUR\u00d8Y, TR\u00c6NA, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, L\u00d8KTA, D\u00d8NNA, D\u00d8NNA, VANDVE, BRAS\u00d8Y, SANDV\u00c6R, HER\u00d8Y, HER\u00d8Y, HER\u00d8Y, AUSTB\u00d8, TJ\u00d8TTA, TJ\u00d8TTA, TRO, VISTHUS, B\u00c6R\u00d8YV\u00c5GEN, LEIRFJORD, LEIRFJORD, SUND\u00d8Y, BARDAL, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, S\u00d8MNA, S\u00d8MNA, S\u00d8MNA, VELFJORD, VELFJORD, VEVELSTAD, VEVELSTAD, VEGA, VEGA, YLVINGEN, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMSDALEN, TROMSDALEN, KROKELVDALEN, KROKELVDALEN, TOMASJORD, RAMFJORDBOTN, TROMSDALEN, SJURSNES, OLDERVIK, TROMS\u00d8, TROMS\u00d8, NORDKJOSBOTN, LAKSVATN, J\u00d8VIK, OTEREN, NORDKJOSBOTN, STORSTEINNES, MEISTERVIK, MORTENHALS, VIKRAN, STORSTEINNES, LYNGSEIDET, FURUFLATEN, SVENSBY, NORD-LENANGEN, LYNGSEIDET, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YA, KVAL\u00d8YA, KVAL\u00d8YA, STRAUMSBUKTA, KVAL\u00d8YA, KVAL\u00d8YA, SOMMAR\u00d8Y, BRENSHOLMEN, SOMMAR\u00d8Y, VENGS\u00d8Y, TUSS\u00d8Y, HANSNES, K\u00c5RVIK, STAKKVIK, HANSNES, VANNV\u00c5G, VANNAREID, VANNV\u00c5G, KARLS\u00d8Y, REBBENES, MJ\u00d8LVIK, SKIBOTN, SKIBOTN, SAMUELSBERG, SAMUELSBERG, OLDERDALEN, BIRTAVARRE, OLDERDALEN, BIRTAVARRE, STORSLETT, S\u00d8RKJOSEN, ROTSUND, S\u00d8RKJOSEN, STORSLETT, HAVNNES, BURFJORD, S\u00d8RSTRAUMEN, J\u00d8KELFJORD, BURFJORD, LONGYEARBYEN, LONGYEARBYEN, NY-\u00c5LESUND, HOPEN, SVEAGRUVA, BJ\u00d8RN\u00d8YA, BARENTSBURG, SKJERV\u00d8Y, HAMNEIDET, SEGLVIK, REINFJORD, SPILDRA, ANDSNES, VALANHAMN, SKJERV\u00d8Y, AKKARVIK, ARN\u00d8YHAMN, NIKKEBY, LAUKSLETTA, \u00c5RVIKSAND, UL\u00d8YBUKT, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, FINNSNES, ROSSFJORDSTRAUMEN, SILSAND, VANGSVIK, FINNSNES, FINNSNES, FINNSNES, FINNSNES, FINNSNES, S\u00d8RREISA, BR\u00d8STADBOTN, S\u00d8RREISA, BR\u00d8STADBOTN, MOEN, KARLSTAD, BARDUFOSS, BARDUFOSS, MOEN, \u00d8VERBYGD, \u00d8VERBYGD, RUNDHAUG, SJ\u00d8VEGAN, SJ\u00d8VEGAN, TENNEVOLL, TENNEVOLL, BARDU, BARDU, SILSAND, GIBOSTAD, BOTNHAMN, SKATVIK, GRYLLEFJORD, GRYLLEFJORD, TORSKEN, GIBOSTAD, SKALAND, SKALAND, SENJAHOPEN, SENJAHOPEN, FJORDGARD, HUS\u00d8Y I SENJA, STONGLANDSEIDET, STONGLANDSEIDET, FLAKSTADV\u00c5G, KALDFARNES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, S\u00d8RVIK, LUNDENES, GR\u00d8TAV\u00c6R, KJ\u00d8TTA, SANDS\u00d8Y, BJARK\u00d8Y, MEL\u00d8YV\u00c6R, SANDTORG, KONGSVIK, EVENSKJER, EVENSKJER, FJELLDAL, RAMSUND, MYKLEBOSTAD, HOL I TJELDSUND, TOVIK, GROVFJORD, GROVFJORD, RAMSUND, HAMNVIK, HAMNVIK, KR\u00c5KR\u00d8HAMN, \u00c5NSTAD, ENGENES, ENGENES, GRATANGEN, GRATANGEN, BORKENES, BORKENES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, KVIBY, KAUTOKEINO, KAUTOKEINO, MAZE, KVALFJORD, HAKKSTABBEN, KONGSHUS, KORSFJORDEN, TALVIK, LANGFJORDBOTN, \u00d8KSFJORD, BERGSFJORD, NUVSV\u00c5G, LANGFJORDHAMN, S\u00d8R-TVERRFJORD, SANDLAND, LOPPA, SKAVNAKK, HASVIK, HASVIK, BREIVIKBOTN, S\u00d8RV\u00c6R, HAMMERFEST, HAMMERFEST, HAMMERFEST, HAMMERFEST, NORDRE SEILAND, RYPEFJORD, RYPEFJORD, FORS\u00d8L, HAMMERFEST, HAMMERFEST, KVALSUND, KVALSUND, REVSNESHAMN, AKKARFJORD, LANGSTRAND, K\u00c5RHAMN, SAND\u00d8YBOTN, TUFJORD, ING\u00d8Y, HAV\u00d8YSUND, HAV\u00d8YSUND, M\u00c5S\u00d8Y, LAKSELV, PORSANGMOEN, INDRE BILLEFJORD, LAKSELV, LAKSELV, RUSSENES, SNEFJORD, KOKELV, B\u00d8RSELV, VEIDNESKLUBBEN, SKOGANVARRE, KARASJOK, KARASJOK, LEBESBY, KUNES, HONNINGSV\u00c5G, HONNINGSV\u00c5G, NORDV\u00c5GEN, SKARSV\u00c5G, NORDKAPP, GJESV\u00c6R, REPV\u00c5G, MEHAMN, SKJ\u00c5NES, LANGFJORDNES, NERVEI, GAMVIK, DYFJORD, KJ\u00d8LLEFJORD, VADS\u00d8, VESTRE JAKOBSELV, VESTRE JAKOBSELV, VADS\u00d8, VADS\u00d8, VARANGERBOTN, SIRMA, VARANGERBOTN, TANA, TANA, KIRKENES, BJ\u00d8RNEVATN, HESSENG, BJ\u00d8RNEVATN, KIRKENES, HESSENG, KIRKENES, SVANVIK, NEIDEN, BUG\u00d8YNES, VARD\u00d8, VARD\u00d8, KIBERG, BERLEV\u00c5G, BERLEV\u00c5G, KONGSFJORD, B\u00c5TSFJORD, B\u00c5TSFJORD".split("")

	l = Array.new(10000)

	p = strSplitByString(poststeder, ", ".split(""))

	nr = HentPostnummerListe()

	i = 0.0
	while(i < nr.length)
		l[nr[i]] = p[i]
		i = i + 1.0
	end

	return l
end


def HentPostnummerListe()

	n = StringToNumberArray("0001, 0010, 0015, 0018, 0021, 0024, 0026, 0028, 0030, 0031, 0032, 0033, 0034, 0037, 0040, 0045, 0046, 0047, 0048, 0050, 0055, 0060, 0081, 0101, 0102, 0103, 0104, 0105, 0106, 0107, 0109, 0110, 0111, 0112, 0113, 0114, 0115, 0116, 0117, 0118, 0119, 0120, 0121, 0122, 0123, 0124, 0125, 0128, 0129, 0130, 0131, 0132, 0133, 0134, 0135, 0136, 0138, 0139, 0140, 0150, 0151, 0152, 0153, 0154, 0155, 0157, 0158, 0159, 0160, 0161, 0162, 0164, 0165, 0166, 0167, 0168, 0169, 0170, 0171, 0172, 0173, 0174, 0175, 0176, 0177, 0178, 0179, 0180, 0181, 0182, 0183, 0184, 0185, 0186, 0187, 0188, 0190, 0191, 0192, 0193, 0194, 0195, 0196, 0198, 0201, 0202, 0203, 0204, 0207, 0208, 0211, 0212, 0213, 0214, 0215, 0216, 0217, 0218, 0230, 0240, 0244, 0247, 0250, 0251, 0252, 0253, 0254, 0255, 0256, 0257, 0258, 0259, 0260, 0262, 0263, 0264, 0265, 0266, 0267, 0268, 0270, 0271, 0272, 0273, 0274, 0275, 0276, 0277, 0278, 0279, 0280, 0281, 0282, 0283, 0284, 0286, 0287, 0301, 0302, 0303, 0304, 0305, 0306, 0307, 0308, 0309, 0311, 0313, 0314, 0315, 0316, 0317, 0318, 0319, 0323, 0330, 0340, 0349, 0350, 0351, 0352, 0353, 0354, 0355, 0356, 0357, 0358, 0359, 0360, 0361, 0362, 0363, 0364, 0365, 0366, 0367, 0368, 0369, 0370, 0371, 0372, 0373, 0374, 0375, 0376, 0377, 0378, 0379, 0380, 0381, 0382, 0383, 0401, 0402, 0403, 0404, 0405, 0406, 0409, 0410, 0411, 0412, 0413, 0415, 0421, 0422, 0423, 0424, 0440, 0441, 0442, 0445, 0450, 0451, 0452, 0454, 0455, 0456, 0457, 0458, 0459, 0460, 0461, 0462, 0463, 0464, 0465, 0467, 0468, 0469, 0470, 0472, 0473, 0474, 0475, 0476, 0477, 0478, 0479, 0480, 0481, 0482, 0483, 0484, 0485, 0486, 0487, 0488, 0489, 0490, 0491, 0492, 0493, 0494, 0495, 0496, 0501, 0502, 0503, 0504, 0505, 0506, 0507, 0508, 0509, 0510, 0511, 0512, 0513, 0515, 0516, 0517, 0518, 0520, 0540, 0550, 0551, 0552, 0553, 0554, 0555, 0556, 0557, 0558, 0559, 0560, 0561, 0562, 0563, 0564, 0565, 0566, 0567, 0568, 0569, 0570, 0571, 0572, 0573, 0574, 0575, 0576, 0577, 0578, 0579, 0580, 0581, 0582, 0583, 0584, 0585, 0586, 0587, 0588, 0589, 0590, 0591, 0592, 0593, 0594, 0595, 0596, 0597, 0598, 0601, 0602, 0603, 0604, 0605, 0606, 0607, 0608, 0609, 0611, 0612, 0613, 0614, 0615, 0616, 0617, 0618, 0619, 0620, 0621, 0622, 0623, 0624, 0626, 0650, 0651, 0652, 0653, 0654, 0655, 0656, 0657, 0658, 0659, 0660, 0661, 0662, 0663, 0664, 0665, 0666, 0667, 0668, 0669, 0670, 0671, 0672, 0673, 0674, 0675, 0676, 0677, 0678, 0679, 0680, 0681, 0682, 0683, 0684, 0685, 0686, 0687, 0688, 0689, 0690, 0691, 0692, 0693, 0694, 0701, 0702, 0705, 0710, 0712, 0750, 0751, 0752, 0753, 0754, 0755, 0756, 0757, 0758, 0760, 0763, 0764, 0765, 0766, 0767, 0768, 0770, 0771, 0772, 0773, 0774, 0775, 0776, 0777, 0778, 0779, 0781, 0782, 0783, 0784, 0785, 0786, 0787, 0788, 0789, 0790, 0791, 0801, 0805, 0806, 0807, 0840, 0850, 0851, 0852, 0853, 0854, 0855, 0856, 0857, 0858, 0860, 0861, 0862, 0863, 0864, 0870, 0871, 0872, 0873, 0874, 0875, 0876, 0877, 0880, 0881, 0882, 0883, 0884, 0890, 0891, 0901, 0902, 0903, 0904, 0905, 0907, 0908, 0913, 0914, 0915, 0950, 0951, 0952, 0953, 0954, 0955, 0956, 0957, 0958, 0959, 0960, 0962, 0963, 0964, 0968, 0969, 0970, 0971, 0972, 0973, 0975, 0976, 0977, 0978, 0979, 0980, 0981, 0982, 0983, 0984, 0985, 0986, 0987, 0988, 1001, 1003, 1005, 1006, 1007, 1008, 1009, 1011, 1051, 1052, 1053, 1054, 1055, 1056, 1061, 1062, 1063, 1064, 1065, 1067, 1068, 1069, 1071, 1081, 1083, 1084, 1086, 1087, 1088, 1089, 1101, 1102, 1108, 1109, 1112, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1172, 1176, 1177, 1178, 1179, 1181, 1182, 1184, 1185, 1187, 1188, 1189, 1201, 1203, 1204, 1205, 1207, 1214, 1215, 1250, 1251, 1252, 1253, 1254, 1255, 1256, 1257, 1258, 1259, 1262, 1263, 1266, 1270, 1271, 1272, 1273, 1274, 1275, 1278, 1279, 1281, 1283, 1284, 1285, 1286, 1290, 1291, 1294, 1295, 1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1311, 1312, 1313, 1314, 1316, 1317, 1318, 1319, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1344, 1346, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1371, 1372, 1373, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1501, 1502, 1503, 1504, 1506, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540, 1541, 1545, 1550, 1555, 1556, 1560, 1561, 1570, 1580, 1581, 1590, 1591, 1592, 1593, 1594, 1596, 1597, 1598, 1599, 1601, 1602, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621, 1622, 1623, 1624, 1625, 1626, 1628, 1629, 1630, 1632, 1633, 1634, 1636, 1637, 1638, 1639, 1640, 1641, 1642, 1650, 1651, 1653, 1654, 1655, 1657, 1658, 1659, 1661, 1662, 1663, 1664, 1665, 1666, 1667, 1670, 1671, 1672, 1673, 1675, 1676, 1678, 1679, 1680, 1682, 1683, 1684, 1690, 1692, 1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1730, 1733, 1734, 1735, 1738, 1739, 1740, 1742, 1743, 1745, 1746, 1747, 1751, 1752, 1753, 1754, 1757, 1759, 1760, 1761, 1762, 1763, 1764, 1765, 1766, 1767, 1768, 1769, 1771, 1772, 1776, 1777, 1778, 1779, 1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1796, 1798, 1799, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1811, 1812, 1813, 1814, 1815, 1816, 1820, 1821, 1823, 1825, 1827, 1830, 1831, 1832, 1833, 1850, 1851, 1852, 1859, 1860, 1861, 1866, 1867, 1870, 1871, 1875, 1878, 1880, 1890, 1891, 1892, 1893, 1894, 1900, 1901, 1903, 1910, 1911, 1912, 1914, 1916, 1917, 1920, 1921, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1940, 1941, 1950, 1954, 1960, 1961, 1963, 1970, 1971, 2000, 2001, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2040, 2041, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2060, 2061, 2062, 2063, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2076, 2080, 2081, 2090, 2091, 2092, 2093, 2094, 2100, 2101, 2110, 2114, 2116, 2120, 2121, 2123, 2130, 2132, 2133, 2134, 2150, 2151, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2170, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2223, 2224, 2225, 2226, 2227, 2230, 2231, 2232, 2233, 2235, 2240, 2241, 2251, 2256, 2260, 2261, 2264, 2265, 2266, 2270, 2271, 2280, 2283, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2344, 2345, 2346, 2350, 2351, 2353, 2355, 2360, 2361, 2364, 2365, 2372, 2373, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2432, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2446, 2447, 2448, 2450, 2451, 2460, 2461, 2476, 2477, 2478, 2480, 2481, 2484, 2485, 2486, 2487, 2488, 2500, 2501, 2510, 2512, 2513, 2540, 2541, 2542, 2544, 2550, 2551, 2552, 2555, 2560, 2561, 2580, 2581, 2582, 2584, 2601, 2602, 2603, 2604, 2605, 2606, 2607, 2608, 2609, 2610, 2611, 2612, 2613, 2614, 2615, 2616, 2617, 2618, 2619, 2620, 2621, 2622, 2623, 2624, 2625, 2626, 2627, 2628, 2629, 2630, 2631, 2632, 2633, 2634, 2635, 2636, 2637, 2638, 2639, 2640, 2641, 2642, 2643, 2644, 2645, 2646, 2647, 2648, 2649, 2651, 2652, 2653, 2654, 2656, 2657, 2658, 2659, 2660, 2661, 2662, 2663, 2664, 2665, 2666, 2667, 2668, 2669, 2670, 2671, 2672, 2673, 2674, 2675, 2676, 2677, 2678, 2679, 2680, 2681, 2682, 2683, 2684, 2685, 2686, 2687, 2688, 2690, 2693, 2694, 2695, 2711, 2712, 2713, 2714, 2715, 2716, 2717, 2718, 2720, 2730, 2740, 2742, 2743, 2750, 2760, 2770, 2801, 2802, 2803, 2804, 2805, 2806, 2807, 2808, 2809, 2810, 2811, 2812, 2815, 2816, 2817, 2818, 2819, 2820, 2821, 2822, 2825, 2827, 2830, 2831, 2832, 2833, 2834, 2835, 2836, 2837, 2838, 2839, 2840, 2841, 2843, 2844, 2845, 2846, 2847, 2848, 2849, 2850, 2851, 2853, 2854, 2857, 2858, 2860, 2861, 2862, 2864, 2866, 2867, 2870, 2879, 2880, 2881, 2882, 2890, 2893, 2900, 2901, 2907, 2909, 2910, 2917, 2918, 2920, 2923, 2929, 2930, 2933, 2936, 2937, 2939, 2940, 2943, 2950, 2952, 2953, 2954, 2959, 2960, 2965, 2966, 2967, 2972, 2973, 2974, 2975, 2977, 2985, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3050, 3051, 3053, 3054, 3055, 3056, 3057, 3058, 3060, 3061, 3063, 3064, 3065, 3066, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3095, 3101, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3131, 3132, 3133, 3134, 3135, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3148, 3150, 3151, 3152, 3153, 3154, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3199, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3251, 3252, 3253, 3254, 3255, 3256, 3257, 3258, 3259, 3260, 3261, 3262, 3263, 3264, 3265, 3267, 3268, 3269, 3270, 3271, 3274, 3275, 3276, 3277, 3280, 3281, 3282, 3284, 3285, 3290, 3291, 3292, 3294, 3295, 3296, 3297, 3300, 3301, 3302, 3303, 3320, 3321, 3322, 3330, 3331, 3340, 3341, 3342, 3350, 3351, 3355, 3357, 3358, 3359, 3360, 3361, 3370, 3371, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3420, 3421, 3425, 3426, 3427, 3428, 3430, 3431, 3440, 3441, 3442, 3470, 3471, 3472, 3474, 3475, 3476, 3477, 3478, 3479, 3480, 3481, 3482, 3483, 3484, 3485, 3490, 3501, 3502, 3503, 3504, 3507, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528, 3529, 3530, 3531, 3532, 3533, 3534, 3535, 3536, 3537, 3538, 3539, 3540, 3541, 3543, 3544, 3545, 3550, 3551, 3560, 3561, 3570, 3571, 3575, 3576, 3577, 3579, 3580, 3581, 3588, 3593, 3595, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3621, 3622, 3623, 3624, 3625, 3626, 3627, 3628, 3629, 3630, 3631, 3632, 3634, 3646, 3647, 3648, 3650, 3652, 3656, 3658, 3660, 3661, 3665, 3666, 3671, 3672, 3673, 3674, 3675, 3676, 3677, 3678, 3679, 3680, 3681, 3683, 3684, 3690, 3691, 3692, 3697, 3701, 3702, 3703, 3704, 3705, 3707, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3746, 3747, 3748, 3749, 3750, 3753, 3760, 3766, 3770, 3772, 3780, 3781, 3783, 3785, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3810, 3811, 3812, 3820, 3825, 3830, 3831, 3832, 3833, 3834, 3835, 3836, 3840, 3841, 3844, 3848, 3849, 3850, 3852, 3853, 3854, 3855, 3864, 3870, 3880, 3882, 3883, 3884, 3885, 3886, 3887, 3888, 3890, 3891, 3893, 3895, 3901, 3902, 3903, 3904, 3905, 3906, 3910, 3911, 3912, 3913, 3914, 3915, 3916, 3917, 3918, 3919, 3920, 3921, 3922, 3924, 3925, 3928, 3929, 3930, 3931, 3933, 3936, 3937, 3939, 3940, 3941, 3942, 3943, 3944, 3946, 3947, 3948, 3949, 3950, 3960, 3961, 3962, 3965, 3966, 3967, 3970, 3991, 3993, 3994, 3995, 3996, 3997, 3998, 3999, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4031, 4032, 4033, 4034, 4035, 4036, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071, 4072, 4073, 4076, 4077, 4078, 4079, 4081, 4082, 4083, 4084, 4085, 4086, 4087, 4088, 4089, 4090, 4091, 4092, 4093, 4094, 4095, 4096, 4097, 4098, 4099, 4100, 4102, 4110, 4119, 4120, 4123, 4124, 4126, 4127, 4128, 4129, 4130, 4134, 4137, 4139, 4146, 4148, 4150, 4152, 4153, 4154, 4156, 4158, 4159, 4160, 4161, 4163, 4164, 4167, 4168, 4169, 4170, 4173, 4174, 4180, 4181, 4182, 4187, 4198, 4200, 4201, 4208, 4209, 4230, 4233, 4234, 4235, 4237, 4239, 4240, 4244, 4250, 4260, 4262, 4264, 4265, 4270, 4272, 4274, 4275, 4276, 4280, 4291, 4294, 4295, 4296, 4297, 4298, 4299, 4301, 4302, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4317, 4318, 4319, 4320, 4321, 4322, 4323, 4324, 4325, 4326, 4327, 4328, 4329, 4330, 4332, 4333, 4335, 4336, 4337, 4338, 4339, 4340, 4341, 4342, 4343, 4344, 4345, 4346, 4347, 4348, 4349, 4352, 4353, 4354, 4355, 4356, 4357, 4358, 4360, 4361, 4362, 4363, 4364, 4365, 4367, 4368, 4369, 4370, 4371, 4372, 4373, 4374, 4375, 4376, 4378, 4379, 4380, 4381, 4384, 4385, 4387, 4389, 4390, 4391, 4392, 4393, 4394, 4395, 4396, 4397, 4398, 4399, 4400, 4401, 4402, 4403, 4420, 4432, 4434, 4436, 4438, 4439, 4440, 4441, 4443, 4460, 4462, 4463, 4465, 4473, 4480, 4484, 4485, 4490, 4491, 4492, 4501, 4502, 4503, 4504, 4507, 4508, 4509, 4513, 4514, 4515, 4516, 4517, 4519, 4520, 4521, 4522, 4523, 4524, 4525, 4526, 4528, 4529, 4532, 4534, 4535, 4536, 4540, 4541, 4544, 4550, 4551, 4552, 4553, 4554, 4557, 4558, 4560, 4563, 4575, 4576, 4577, 4579, 4580, 4586, 4588, 4590, 4595, 4596, 4597, 4604, 4605, 4606, 4608, 4609, 4610, 4611, 4612, 4613, 4614, 4615, 4616, 4617, 4618, 4619, 4620, 4621, 4622, 4623, 4624, 4625, 4626, 4628, 4629, 4630, 4631, 4632, 4633, 4634, 4635, 4636, 4637, 4638, 4639, 4640, 4641, 4642, 4643, 4644, 4645, 4646, 4647, 4649, 4656, 4657, 4658, 4661, 4662, 4663, 4664, 4665, 4666, 4670, 4671, 4672, 4673, 4674, 4675, 4676, 4677, 4678, 4679, 4681, 4682, 4683, 4684, 4685, 4686, 4687, 4688, 4689, 4691, 4693, 4694, 4695, 4696, 4697, 4698, 4699, 4700, 4701, 4702, 4703, 4705, 4706, 4707, 4708, 4715, 4720, 4721, 4724, 4725, 4730, 4733, 4734, 4735, 4737, 4741, 4742, 4744, 4745, 4746, 4747, 4748, 4749, 4754, 4755, 4756, 4760, 4766, 4768, 4770, 4780, 4790, 4791, 4792, 4793, 4794, 4795, 4801, 4802, 4803, 4804, 4808, 4809, 4810, 4812, 4815, 4816, 4817, 4818, 4820, 4821, 4822, 4823, 4824, 4825, 4827, 4828, 4830, 4832, 4834, 4836, 4838, 4839, 4841, 4842, 4843, 4844, 4846, 4847, 4848, 4849, 4851, 4852, 4853, 4854, 4855, 4856, 4857, 4858, 4859, 4862, 4863, 4864, 4865, 4868, 4869, 4870, 4876, 4877, 4878, 4879, 4884, 4885, 4886, 4887, 4888, 4889, 4891, 4892, 4893, 4894, 4896, 4898, 4900, 4901, 4902, 4909, 4910, 4912, 4915, 4916, 4920, 4921, 4934, 4950, 4951, 4952, 4953, 4955, 4956, 4957, 4971, 4972, 4973, 4974, 4980, 4985, 4990, 4993, 4994, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5041, 5042, 5043, 5045, 5052, 5053, 5054, 5055, 5056, 5057, 5058, 5059, 5063, 5067, 5068, 5072, 5073, 5075, 5081, 5082, 5089, 5093, 5094, 5096, 5097, 5098, 5099, 5101, 5104, 5105, 5106, 5107, 5108, 5109, 5111, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5121, 5122, 5124, 5130, 5131, 5132, 5134, 5135, 5136, 5137, 5141, 5142, 5143, 5144, 5145, 5146, 5147, 5148, 5151, 5152, 5153, 5154, 5155, 5160, 5161, 5162, 5163, 5164, 5165, 5170, 5171, 5172, 5173, 5174, 5176, 5177, 5178, 5179, 5183, 5184, 5200, 5201, 5202, 5203, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217, 5218, 5221, 5222, 5223, 5224, 5225, 5226, 5227, 5228, 5229, 5230, 5231, 5232, 5235, 5236, 5237, 5238, 5239, 5243, 5244, 5251, 5252, 5253, 5254, 5257, 5258, 5259, 5260, 5261, 5262, 5263, 5264, 5265, 5267, 5268, 5281, 5282, 5283, 5284, 5285, 5286, 5291, 5293, 5299, 5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5314, 5315, 5318, 5319, 5321, 5322, 5323, 5325, 5326, 5327, 5329, 5331, 5333, 5334, 5335, 5336, 5337, 5341, 5342, 5343, 5345, 5346, 5347, 5350, 5353, 5354, 5355, 5357, 5358, 5360, 5363, 5365, 5366, 5371, 5374, 5378, 5379, 5380, 5381, 5382, 5384, 5385, 5387, 5388, 5392, 5393, 5394, 5396, 5397, 5398, 5399, 5401, 5402, 5403, 5404, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5423, 5427, 5428, 5430, 5437, 5440, 5443, 5444, 5445, 5447, 5449, 5450, 5451, 5452, 5453, 5454, 5455, 5457, 5458, 5459, 5460, 5462, 5463, 5464, 5465, 5470, 5472, 5473, 5474, 5475, 5476, 5480, 5484, 5486, 5498, 5499, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5511, 5512, 5514, 5515, 5516, 5517, 5518, 5519, 5521, 5522, 5523, 5525, 5527, 5528, 5529, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5541, 5542, 5544, 5545, 5546, 5547, 5548, 5549, 5550, 5551, 5554, 5555, 5556, 5559, 5560, 5561, 5562, 5563, 5565, 5566, 5567, 5568, 5569, 5570, 5574, 5575, 5576, 5578, 5580, 5582, 5583, 5584, 5585, 5586, 5588, 5589, 5590, 5591, 5593, 5594, 5595, 5596, 5598, 5600, 5601, 5602, 5604, 5605, 5610, 5612, 5614, 5620, 5626, 5627, 5628, 5629, 5630, 5631, 5632, 5633, 5635, 5636, 5637, 5640, 5641, 5642, 5643, 5644, 5645, 5646, 5647, 5648, 5649, 5650, 5651, 5652, 5653, 5680, 5683, 5685, 5687, 5690, 5693, 5694, 5695, 5696, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5718, 5719, 5720, 5721, 5722, 5723, 5724, 5725, 5726, 5727, 5728, 5729, 5730, 5731, 5732, 5733, 5734, 5736, 5741, 5742, 5743, 5745, 5746, 5747, 5748, 5750, 5751, 5752, 5760, 5763, 5770, 5773, 5775, 5776, 5777, 5778, 5779, 5780, 5781, 5782, 5783, 5784, 5785, 5786, 5787, 5788, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5823, 5824, 5825, 5826, 5827, 5828, 5829, 5830, 5831, 5832, 5833, 5834, 5835, 5836, 5837, 5838, 5841, 5843, 5844, 5845, 5847, 5848, 5849, 5851, 5852, 5853, 5854, 5855, 5857, 5858, 5859, 5861, 5862, 5863, 5864, 5865, 5866, 5867, 5868, 5869, 5872, 5873, 5876, 5877, 5878, 5879, 5881, 5884, 5886, 5887, 5888, 5889, 5892, 5893, 5895, 5896, 5899, 5902, 5903, 5904, 5906, 5907, 5908, 5911, 5912, 5913, 5914, 5915, 5916, 5917, 5918, 5919, 5931, 5935, 5936, 5937, 5938, 5939, 5941, 5943, 5947, 5948, 5951, 5952, 5953, 5954, 5955, 5956, 5957, 5960, 5961, 5962, 5963, 5964, 5965, 5966, 5967, 5970, 5977, 5978, 5979, 5981, 5982, 5983, 5984, 5985, 5986, 5987, 5991, 5993, 5994, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6028, 6030, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6044, 6045, 6046, 6047, 6048, 6050, 6051, 6052, 6054, 6055, 6057, 6058, 6059, 6060, 6062, 6063, 6064, 6065, 6067, 6068, 6069, 6070, 6075, 6076, 6078, 6079, 6080, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6094, 6095, 6096, 6098, 6099, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6110, 6120, 6133, 6134, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6146, 6147, 6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6160, 6161, 6165, 6166, 6170, 6171, 6174, 6183, 6184, 6190, 6196, 6200, 6201, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6222, 6223, 6224, 6230, 6238, 6239, 6240, 6249, 6250, 6255, 6259, 6260, 6263, 6264, 6265, 6270, 6272, 6280, 6281, 6282, 6283, 6285, 6290, 6291, 6292, 6293, 6294, 6300, 6301, 6310, 6315, 6320, 6330, 6331, 6339, 6350, 6360, 6361, 6363, 6364, 6365, 6385, 6386, 6387, 6388, 6389, 6390, 6391, 6392, 6393, 6394, 6395, 6396, 6397, 6398, 6399, 6401, 6402, 6403, 6404, 6405, 6407, 6408, 6409, 6410, 6411, 6412, 6413, 6414, 6415, 6416, 6418, 6419, 6421, 6422, 6423, 6425, 6429, 6430, 6431, 6433, 6434, 6435, 6436, 6440, 6443, 6444, 6445, 6446, 6447, 6450, 6452, 6453, 6454, 6455, 6456, 6457, 6458, 6460, 6461, 6462, 6470, 6471, 6472, 6475, 6476, 6480, 6481, 6483, 6484, 6485, 6486, 6487, 6488, 6490, 6493, 6494, 6499, 6501, 6502, 6503, 6504, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6514, 6515, 6516, 6517, 6518, 6520, 6521, 6522, 6523, 6524, 6525, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6538, 6539, 6546, 6547, 6548, 6549, 6570, 6571, 6590, 6591, 6600, 6601, 6610, 6611, 6612, 6613, 6614, 6620, 6622, 6623, 6627, 6628, 6629, 6630, 6631, 6632, 6633, 6636, 6637, 6638, 6639, 6640, 6641, 6642, 6643, 6644, 6645, 6650, 6652, 6653, 6655, 6656, 6657, 6658, 6659, 6670, 6671, 6674, 6680, 6683, 6686, 6687, 6688, 6689, 6690, 6693, 6694, 6697, 6698, 6699, 6700, 6701, 6702, 6703, 6704, 6707, 6708, 6710, 6711, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6721, 6723, 6726, 6727, 6728, 6729, 6730, 6734, 6737, 6740, 6741, 6750, 6751, 6761, 6763, 6770, 6771, 6772, 6773, 6774, 6776, 6777, 6778, 6779, 6781, 6782, 6783, 6784, 6788, 6789, 6790, 6791, 6792, 6793, 6794, 6795, 6796, 6797, 6798, 6799, 6800, 6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810, 6811, 6812, 6813, 6814, 6815, 6817, 6818, 6819, 6820, 6821, 6822, 6823, 6826, 6827, 6828, 6829, 6830, 6831, 6841, 6843, 6844, 6845, 6847, 6848, 6849, 6851, 6852, 6853, 6854, 6855, 6856, 6858, 6859, 6861, 6863, 6866, 6867, 6868, 6869, 6870, 6871, 6872, 6873, 6874, 6875, 6876, 6877, 6878, 6879, 6881, 6882, 6884, 6885, 6886, 6887, 6888, 6891, 6893, 6894, 6895, 6896, 6898, 6899, 6900, 6901, 6902, 6903, 6905, 6906, 6907, 6908, 6909, 6910, 6912, 6913, 6914, 6915, 6916, 6917, 6918, 6919, 6921, 6924, 6926, 6927, 6928, 6929, 6940, 6941, 6942, 6944, 6946, 6947, 6951, 6953, 6957, 6958, 6959, 6961, 6963, 6964, 6966, 6967, 6968, 6969, 6971, 6973, 6975, 6976, 6977, 6978, 6980, 6982, 6983, 6984, 6985, 6986, 6987, 6988, 6991, 6993, 6995, 6996, 6997, 7003, 7004, 7005, 7006, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050, 7051, 7052, 7053, 7054, 7055, 7056, 7057, 7058, 7059, 7066, 7067, 7068, 7069, 7070, 7071, 7072, 7074, 7075, 7078, 7079, 7080, 7081, 7082, 7083, 7088, 7089, 7091, 7092, 7093, 7097, 7098, 7099, 7100, 7101, 7105, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7119, 7120, 7121, 7125, 7126, 7127, 7129, 7130, 7140, 7142, 7150, 7151, 7152, 7153, 7156, 7159, 7160, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7174, 7175, 7176, 7177, 7178, 7180, 7181, 7190, 7194, 7200, 7201, 7203, 7206, 7211, 7212, 7213, 7221, 7223, 7224, 7227, 7228, 7231, 7232, 7234, 7235, 7236, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7250, 7252, 7255, 7256, 7257, 7259, 7260, 7261, 7263, 7264, 7266, 7267, 7268, 7270, 7273, 7274, 7280, 7282, 7284, 7285, 7286, 7287, 7288, 7289, 7290, 7291, 7295, 7298, 7300, 7301, 7302, 7310, 7315, 7316, 7318, 7319, 7320, 7321, 7327, 7329, 7331, 7332, 7333, 7334, 7335, 7336, 7338, 7340, 7341, 7342, 7343, 7345, 7350, 7351, 7353, 7354, 7355, 7356, 7357, 7358, 7361, 7370, 7372, 7374, 7380, 7383, 7384, 7386, 7387, 7388, 7391, 7392, 7393, 7397, 7398, 7399, 7400, 7401, 7402, 7403, 7404, 7405, 7406, 7407, 7408, 7409, 7410, 7411, 7412, 7413, 7414, 7415, 7416, 7417, 7418, 7419, 7420, 7421, 7422, 7424, 7425, 7426, 7427, 7428, 7429, 7430, 7431, 7432, 7433, 7434, 7435, 7436, 7437, 7438, 7439, 7440, 7441, 7442, 7443, 7444, 7445, 7446, 7447, 7448, 7449, 7450, 7451, 7452, 7453, 7454, 7455, 7456, 7457, 7458, 7459, 7462, 7463, 7464, 7465, 7466, 7467, 7468, 7469, 7470, 7471, 7472, 7473, 7474, 7475, 7476, 7477, 7478, 7479, 7480, 7481, 7482, 7483, 7484, 7485, 7486, 7487, 7488, 7489, 7490, 7491, 7492, 7493, 7494, 7495, 7496, 7497, 7498, 7500, 7501, 7502, 7503, 7504, 7505, 7506, 7507, 7508, 7509, 7510, 7511, 7512, 7513, 7514, 7517, 7519, 7520, 7525, 7529, 7530, 7531, 7533, 7540, 7541, 7549, 7550, 7551, 7560, 7562, 7563, 7566, 7570, 7580, 7581, 7583, 7584, 7590, 7591, 7596, 7600, 7601, 7602, 7603, 7604, 7605, 7606, 7607, 7608, 7609, 7610, 7619, 7620, 7622, 7623, 7624, 7629, 7630, 7631, 7632, 7633, 7634, 7650, 7651, 7652, 7653, 7654, 7655, 7656, 7657, 7658, 7660, 7661, 7670, 7671, 7672, 7690, 7691, 7701, 7702, 7703, 7704, 7705, 7707, 7708, 7709, 7710, 7711, 7712, 7713, 7714, 7715, 7716, 7717, 7718, 7724, 7725, 7726, 7729, 7730, 7732, 7733, 7734, 7735, 7736, 7737, 7738, 7739, 7740, 7741, 7742, 7744, 7745, 7746, 7748, 7750, 7751, 7760, 7761, 7770, 7771, 7777, 7790, 7791, 7795, 7796, 7797, 7800, 7801, 7802, 7803, 7804, 7805, 7808, 7810, 7817, 7818, 7819, 7820, 7821, 7822, 7823, 7856, 7860, 7863, 7864, 7869, 7870, 7871, 7873, 7874, 7876, 7877, 7878, 7881, 7882, 7884, 7885, 7890, 7891, 7892, 7893, 7896, 7897, 7898, 7900, 7901, 7902, 7940, 7941, 7944, 7950, 7960, 7970, 7971, 7973, 7979, 7980, 7981, 7982, 7983, 7985, 7986, 7990, 7993, 7994, 7995, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8019, 8020, 8021, 8022, 8023, 8026, 8027, 8028, 8029, 8030, 8031, 8037, 8038, 8041, 8047, 8048, 8049, 8050, 8056, 8057, 8058, 8062, 8063, 8064, 8065, 8070, 8071, 8072, 8073, 8074, 8075, 8076, 8079, 8084, 8086, 8087, 8088, 8089, 8091, 8092, 8093, 8094, 8095, 8096, 8097, 8098, 8099, 8100, 8102, 8103, 8108, 8110, 8114, 8118, 8120, 8128, 8130, 8134, 8135, 8136, 8138, 8140, 8145, 8146, 8149, 8150, 8151, 8157, 8158, 8159, 8160, 8161, 8168, 8170, 8178, 8179, 8181, 8182, 8183, 8184, 8185, 8186, 8187, 8188, 8189, 8190, 8193, 8195, 8196, 8197, 8198, 8200, 8201, 8202, 8203, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8214, 8215, 8218, 8219, 8220, 8226, 8230, 8231, 8232, 8233, 8250, 8251, 8255, 8256, 8260, 8261, 8264, 8266, 8270, 8271, 8273, 8274, 8275, 8276, 8278, 8281, 8283, 8285, 8286, 8287, 8288, 8289, 8290, 8294, 8297, 8298, 8300, 8301, 8305, 8309, 8310, 8311, 8312, 8313, 8314, 8315, 8316, 8317, 8320, 8322, 8323, 8324, 8325, 8326, 8328, 8340, 8352, 8357, 8360, 8361, 8370, 8372, 8373, 8374, 8376, 8377, 8378, 8380, 8382, 8384, 8387, 8388, 8390, 8392, 8393, 8398, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8419, 8426, 8428, 8430, 8432, 8438, 8439, 8445, 8447, 8450, 8455, 8459, 8465, 8469, 8470, 8475, 8480, 8481, 8483, 8484, 8485, 8488, 8489, 8493, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8512, 8513, 8514, 8515, 8516, 8517, 8518, 8520, 8522, 8523, 8530, 8531, 8533, 8534, 8535, 8536, 8539, 8540, 8543, 8546, 8590, 8591, 8601, 8602, 8603, 8604, 8607, 8608, 8609, 8610, 8613, 8614, 8615, 8616, 8617, 8618, 8619, 8622, 8624, 8626, 8630, 8634, 8638, 8640, 8641, 8642, 8643, 8644, 8646, 8647, 8648, 8651, 8652, 8654, 8655, 8656, 8657, 8658, 8659, 8660, 8661, 8663, 8664, 8665, 8666, 8672, 8680, 8681, 8690, 8691, 8700, 8701, 8720, 8723, 8724, 8725, 8730, 8732, 8733, 8735, 8740, 8742, 8743, 8750, 8752, 8753, 8754, 8762, 8764, 8766, 8767, 8770, 8800, 8801, 8802, 8803, 8804, 8805, 8809, 8813, 8820, 8827, 8830, 8842, 8844, 8850, 8851, 8852, 8854, 8860, 8861, 8865, 8870, 8880, 8890, 8891, 8892, 8897, 8900, 8901, 8902, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8920, 8921, 8922, 8960, 8961, 8976, 8977, 8980, 8981, 8985, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9027, 9029, 9030, 9034, 9037, 9038, 9040, 9042, 9043, 9046, 9049, 9050, 9055, 9056, 9057, 9059, 9060, 9062, 9064, 9068, 9069, 9100, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9110, 9118, 9119, 9120, 9128, 9130, 9131, 9132, 9134, 9135, 9136, 9137, 9138, 9140, 9141, 9142, 9143, 9144, 9145, 9146, 9147, 9148, 9149, 9151, 9152, 9153, 9155, 9156, 9159, 9161, 9162, 9163, 9169, 9170, 9171, 9173, 9174, 9175, 9176, 9178, 9180, 9181, 9182, 9184, 9185, 9186, 9187, 9189, 9190, 9192, 9193, 9194, 9195, 9197, 9240, 9251, 9252, 9253, 9254, 9255, 9256, 9257, 9258, 9259, 9260, 9261, 9262, 9263, 9265, 9266, 9267, 9268, 9269, 9270, 9271, 9272, 9273, 9274, 9275, 9276, 9277, 9278, 9279, 9280, 9281, 9282, 9283, 9284, 9285, 9286, 9287, 9288, 9290, 9291, 9292, 9293, 9294, 9296, 9298, 9299, 9300, 9302, 9303, 9304, 9305, 9306, 9307, 9308, 9309, 9310, 9311, 9315, 9316, 9321, 9322, 9325, 9326, 9329, 9334, 9335, 9336, 9350, 9355, 9357, 9358, 9360, 9365, 9370, 9372, 9373, 9376, 9379, 9380, 9381, 9382, 9384, 9385, 9386, 9387, 9388, 9389, 9391, 9392, 9393, 9395, 9402, 9403, 9404, 9405, 9406, 9407, 9408, 9409, 9411, 9414, 9415, 9416, 9419, 9420, 9423, 9424, 9425, 9426, 9427, 9430, 9436, 9439, 9440, 9441, 9442, 9443, 9444, 9445, 9446, 9447, 9448, 9450, 9451, 9453, 9454, 9455, 9456, 9470, 9471, 9475, 9476, 9479, 9480, 9481, 9482, 9483, 9484, 9485, 9486, 9487, 9488, 9489, 9496, 9497, 9498, 9501, 9502, 9503, 9504, 9505, 9506, 9507, 9508, 9509, 9510, 9511, 9512, 9513, 9514, 9515, 9516, 9517, 9518, 9519, 9520, 9521, 9525, 9531, 9532, 9533, 9536, 9540, 9545, 9550, 9580, 9582, 9583, 9584, 9585, 9586, 9587, 9590, 9591, 9593, 9595, 9600, 9601, 9602, 9603, 9609, 9610, 9611, 9612, 9615, 9616, 9620, 9621, 9624, 9650, 9651, 9657, 9664, 9670, 9672, 9690, 9691, 9692, 9700, 9709, 9710, 9711, 9712, 9713, 9714, 9715, 9716, 9717, 9722, 9730, 9735, 9740, 9742, 9750, 9751, 9760, 9763, 9764, 9765, 9768, 9770, 9771, 9772, 9773, 9775, 9782, 9790, 9800, 9802, 9810, 9811, 9815, 9820, 9826, 9840, 9845, 9846, 9900, 9910, 9912, 9914, 9915, 9916, 9917, 9925, 9930, 9935, 9950, 9951, 9960, 9980, 9981, 9982, 9990, 9991".split(""))

	return n
end


def HentPoststed(nrString, feilmelding)

	nr = CreateNumberFromDecimalString(nrString)
	respons = "".split("")

	if ErGyldigPostnummer(nrString)
		feilmelding.success = true
		poststedListe = HentPoststedListe()
		respons = poststedListe[nr].string
	else
		feilmelding.success = false
		feilmelding.feilmelding = "Postnummer er ikke gyldig.".split("")
	end

	return respons
end


def ErGyldigPostnummer(nrString)

	nr = CreateNumberFromDecimalString(nrString)
	gyldigePostnummer = GyldigPostnummertabell()

	if nr > 0.0 && nr < 10000.0 && IsInteger(nr) && nrString.length == 4.0
		erGyldig = gyldigePostnummer[nr]
	else
		erGyldig = false
	end

	return erGyldig
end


def GyldigPostnummertabell()

	postnummerliste = HentPostnummerListe()
	maxnummer = 0.0

	i = 0.0
	while(i < postnummerliste.length)
		maxnummer = [maxnummer, postnummerliste[i]].max
		i = i + 1.0
	end

	rev = Array.new(maxnummer + 1.0)

	i = 0.0
	while(i < maxnummer)
		rev[i] = false
		i = i + 1.0
	end

	i = 0.0
	while(i < postnummerliste.length)
		rev[postnummerliste[i]] = true
		i = i + 1.0
	end

	return rev
end


def Loess(xs, ys, bandwidth, robustnessIters, accuracy, resultXs, errorMessage)

	weights = Array.new(xs.length)
	arraysFillNumberArray(weights, 1.0)

	return Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage)
end


def Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage)

	# Sort arrays
	indexes = QuickSortNumbersWithIndexes(xs)
	RearrangeArray(ys, indexes)

	if xs.length == ys.length && xs.length != 0.0
		n = xs.length

		if n == 1.0 || n == 2.0
			if n == 1.0
				res = Array.new(1)
				res[0] = ys[0]
			else
				res = Array.new(2)
				res[0] = ys[0]
				res[1] = ys[1]
			end

			resultXs.numberArray = res
			success = true
		else
			bandwidthInPoints = Truncate(bandwidth*n)

			if bandwidthInPoints >= 2.0
				res = Array.new(n)
				residuals = Array.new(n)

				robustnessWeights = Array.new(n)
				arraysFillNumberArray(robustnessWeights, 1.0)

				done = false
				iter = 0.0
				while(iter <= robustnessIters && !done)
					bandwidthInterval = Array.new(2)
					bandwidthInterval[0] = 0.0
					bandwidthInterval[1] = bandwidthInPoints - 1.0

					i = 0.0
					while(i < n)
						x = xs[i]

						if i > 0.0
							left = bandwidthInterval[0]
							right = bandwidthInterval[1]

							nextRight = FindNextNonZeroElement(weights, right)
							nextLeft = left
							while(nextRight < xs.length && xs[nextRight] - xs[i] < xs[i] - xs[nextLeft])
								nextLeft = FindNextNonZeroElement(weights, bandwidthInterval[0])
								bandwidthInterval[0] = nextLeft
								bandwidthInterval[1] = nextRight
								nextRight = FindNextNonZeroElement(weights, nextRight)
							end
						end

						ileft = bandwidthInterval[0]
						iright = bandwidthInterval[1]

						if xs[i] - xs[ileft] > xs[iright] - xs[i]
							edge = ileft
						else
							edge = iright
						end

						sumWeights = 0.0
						sumX = 0.0
						sumXSquared = 0.0
						sumY = 0.0
						sumXY = 0.0
						denom = (1.0.to_f / (xs[edge] - x)).abs
						k = ileft
						while(k <= iright)
							xk = xs[k]
							yk = ys[k]

							if k < i
								dist = x - xk
							else
								dist = xk - x
							end

							w = Tricube(dist*denom)*robustnessWeights[k]*weights[k]
							xkw = xk*w
							sumWeights = sumWeights + w
							sumX = sumX + xkw
							sumXSquared = sumXSquared + xk*xkw
							sumY = sumY + yk*w
							sumXY = sumXY + yk*xkw
							k = k + 1.0
						end

						meanX = sumX.to_f / sumWeights
						meanY = sumY.to_f / sumWeights
						meanXY = sumXY.to_f / sumWeights
						meanXSquared = sumXSquared.to_f / sumWeights

						if Math.sqrt((meanXSquared - meanX*meanX).abs) < accuracy
							beta = 0.0
						else
							beta = (meanXY - meanX*meanY).to_f / (meanXSquared - meanX*meanX)
						end

						alpha = meanY - beta*meanX

						res[i] = beta*x + alpha

						residuals[i] = (ys[i] - res[i]).abs
						i = i + 1.0
					end

					if iter == robustnessIters
						done = true
					end

					if !done
						sortedResiduals = arraysCopyNumberArray(residuals)
						QuickSortNumbers(sortedResiduals)

						medianResidual = sortedResiduals[n.to_f / 2.0]

						if (medianResidual).abs < accuracy
							done = true
						end

						if !done
							i = 0.0
							while(i < n)
								arg = residuals[i].to_f / (6.0*medianResidual)
								if arg >= 1.0
									robustnessWeights[i] = 0.0
								else
									w = 1.0 - arg*arg
									robustnessWeights[i] = w*w
								end
								i = i + 1.0
							end
						end
					end
					iter = iter + 1.0
				end

				resultXs.numberArray = res
				success = true
			else
				success = false
				errorMessage.string = "There must be at least two points.".split("")
			end
		end
	else
		success = false
		errorMessage.string = "There must be equal number of points, and over zero.".split("")
	end

	return success
end


def RearrangeArray(as, indexes)

	bs = Array.new(as.length)

	AssignNumberArray(bs, as)

	i = 0.0
	while(i < indexes.length)
		as[i] = bs[indexes[i]]
		i = i + 1.0
	end

	delete(bs)
end


def AssignNumberArray(as, bs)

	i = 0.0
	while(i < [as.length, bs.length].min)
		as[i] = bs[i]
		i = i + 1.0
	end
end


def FindNextNonZeroElement(array, offset)

	done = false
	position = offset + 1.0
	while(position < array.length && !done)
		if array[position] != 0.0
			done = true
		end
		position = position + 1.0
	end

	return position
end


def Tricube(x)

	ax = (x).abs

	if ax >= 1.0
		result = 0.0
	else
		result = 1.0 - ax*ax*ax
		result = result*result*result
	end

	return result
end


def CropLineWithinBoundary(x1Ref, y1Ref, x2Ref, y2Ref, xMin, xMax, yMin, yMax)

	x1 = x1Ref.numberValue
	y1 = y1Ref.numberValue
	x2 = x2Ref.numberValue
	y2 = y2Ref.numberValue

	p1In = x1 >= xMin && x1 <= xMax && y1 >= yMin && y1 <= yMax
	p2In = x2 >= xMin && x2 <= xMax && y2 >= yMin && y2 <= yMax

	if p1In && p2In
		success = true
	elsif !p1In && p2In
		dx = x1 - x2
		dy = y1 - y2

		if dx != 0.0
			f1 = (xMin - x2).to_f / dx
			f2 = (xMax - x2).to_f / dx
		else
			f1 = 1.0
			f2 = 1.0
		end
		if dy != 0.0
			f3 = (yMin - y2).to_f / dy
			f4 = (yMax - y2).to_f / dy
		else
			f3 = 1.0
			f4 = 1.0
		end

		if f1 < 0.0
			f1 = 1.0
		end
		if f2 < 0.0
			f2 = 1.0
		end
		if f3 < 0.0
			f3 = 1.0
		end
		if f4 < 0.0
			f4 = 1.0
		end

		f = [f1, [f2, [f3, f4].min].min].min

		x1 = x2 + f*dx
		y1 = y2 + f*dy

		success = true
	elsif p1In && !p2In
		dx = x2 - x1
		dy = y2 - y1

		if dx != 0.0
			f1 = (xMin - x1).to_f / dx
			f2 = (xMax - x1).to_f / dx
		else
			f1 = 1.0
			f2 = 1.0
		end
		if dy != 0.0
			f3 = (yMin - y1).to_f / dy
			f4 = (yMax - y1).to_f / dy
		else
			f3 = 1.0
			f4 = 1.0
		end

		if f1 < 0.0
			f1 = 1.0
		end
		if f2 < 0.0
			f2 = 1.0
		end
		if f3 < 0.0
			f3 = 1.0
		end
		if f4 < 0.0
			f4 = 1.0
		end

		f = [f1, [f2, [f3, f4].min].min].min

		x2 = x1 + f*dx
		y2 = y1 + f*dy

		success = true
	else
		success = false
	end

	x1Ref.numberValue = x1
	y1Ref.numberValue = y1
	x2Ref.numberValue = x2
	y2Ref.numberValue = y2

	return success
end


def IncrementFromCoordinates(x1, y1, x2, y2)
	return (x2 - x1).to_f / (y2 - y1)
end


def InterceptFromCoordinates(x1, y1, x2, y2)

	a = IncrementFromCoordinates(x1, y1, x2, y2)
	b = y1 - a*x1

	return b
end


def Get8HighContrastColors()
	colors = Array.new(8)
	colors[0] = CreateRGBColor(3.0.to_f / 256.0, 146.0.to_f / 256.0, 206.0.to_f / 256.0)
	colors[1] = CreateRGBColor(253.0.to_f / 256.0, 83.0.to_f / 256.0, 8.0.to_f / 256.0)
	colors[2] = CreateRGBColor(102.0.to_f / 256.0, 176.0.to_f / 256.0, 50.0.to_f / 256.0)
	colors[3] = CreateRGBColor(208.0.to_f / 256.0, 234.0.to_f / 256.0, 43.0.to_f / 256.0)
	colors[4] = CreateRGBColor(167.0.to_f / 256.0, 25.0.to_f / 256.0, 75.0.to_f / 256.0)
	colors[5] = CreateRGBColor(254.0.to_f / 256.0, 254.0.to_f / 256.0, 51.0.to_f / 256.0)
	colors[6] = CreateRGBColor(134.0.to_f / 256.0, 1.0.to_f / 256.0, 175.0.to_f / 256.0)
	colors[7] = CreateRGBColor(251.0.to_f / 256.0, 153.0.to_f / 256.0, 2.0.to_f / 256.0)
	return colors
end


def DrawFilledRectangleWithBorder(image, x, y, w, h, borderColor, fillColor)
	if h > 0.0 && w > 0.0
		DrawFilledRectangle(image, x, y, w, h, fillColor)
		DrawRectangle1px(image, x, y, w, h, borderColor)
	end
end


def CreateRGBABitmapImageReference()

	reference = RGBABitmapImageReference.new
	reference.image = RGBABitmapImage.new
	reference.image.x = Array.new(0)

	return reference
end


def RectanglesOverlap(r1, r2)

	overlap = false

	overlap = overlap || (r2.x1 >= r1.x1 && r2.x1 <= r1.x2 && r2.y1 >= r1.y1 && r2.y1 <= r1.y2)
	overlap = overlap || (r2.x2 >= r1.x1 && r2.x2 <= r1.x2 && r2.y1 >= r1.y1 && r2.y1 <= r1.y2)
	overlap = overlap || (r2.x1 >= r1.x1 && r2.x1 <= r1.x2 && r2.y2 >= r1.y1 && r2.y2 <= r1.y2)
	overlap = overlap || (r2.x2 >= r1.x1 && r2.x2 <= r1.x2 && r2.y2 >= r1.y1 && r2.y2 <= r1.y2)

	return overlap
end


def CreateRectangle(x1, y1, x2, y2)
	r = Rectangle.new
	r.x1 = x1
	r.y1 = y1
	r.x2 = x2
	r.y2 = y2
	return r
end


def CopyRectangleValues(rd, rs)
	rd.x1 = rs.x1
	rd.y1 = rs.y1
	rd.x2 = rs.x2
	rd.y2 = rs.y2
end


def DrawXLabelsForPriority(p, xMin, oy, xMax, xPixelMin, xPixelMax, nextRectangle, gridLabelColor, canvas, xGridPositions, xLabels, xLabelPriorities, occupied, textOnBottom)

	r = Rectangle.new
	padding = 10.0

	overlap = false
	i = 0.0
	while(i < xLabels.stringArray.length)
		if xLabelPriorities.numberArray[i] == p

			x = xGridPositions[i]
			px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
			text = xLabels.stringArray[i].string

			r.x1 = (px - GetTextWidth(text).to_f / 2.0).floor
			if textOnBottom
				r.y1 = (oy + 5.0).floor
			else
				r.y1 = (oy - 20.0).floor
			end
			r.x2 = r.x1 + GetTextWidth(text)
			r.y2 = r.y1 + GetTextHeight(text)

			# Add padding
			r.x1 = r.x1 - padding
			r.y1 = r.y1 - padding
			r.x2 = r.x2 + padding
			r.y2 = r.y2 + padding

			currentOverlaps = false

			j = 0.0
			while(j < nextRectangle.numberValue)
				currentOverlaps = currentOverlaps || RectanglesOverlap(r, occupied[j])
				j = j + 1.0
			end

			if !currentOverlaps && p == 1.0
				DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor)

				CopyRectangleValues(occupied[nextRectangle.numberValue], r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			end

			overlap = overlap || currentOverlaps
		end
		i = i + 1.0
	end
	if !overlap && p != 1.0
		i = 0.0
		while(i < xGridPositions.length)
			x = xGridPositions[i]
			px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)

			if xLabelPriorities.numberArray[i] == p
				text = xLabels.stringArray[i].string

				r.x1 = (px - GetTextWidth(text).to_f / 2.0).floor
				if textOnBottom
					r.y1 = (oy + 5.0).floor
				else
					r.y1 = (oy - 20.0).floor
				end
				r.x2 = r.x1 + GetTextWidth(text)
				r.y2 = r.y1 + GetTextHeight(text)

				DrawText(canvas, r.x1, r.y1, text, gridLabelColor)

				CopyRectangleValues(occupied[nextRectangle.numberValue], r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			end
			i = i + 1.0
		end
	end
end


def DrawYLabelsForPriority(p, yMin, ox, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, textOnLeft)

	r = Rectangle.new
	padding = 10.0

	overlap = false
	i = 0.0
	while(i < yLabels.stringArray.length)
		if yLabelPriorities.numberArray[i] == p

			y = yGridPositions[i]
			py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
			text = yLabels.stringArray[i].string

			if textOnLeft
				r.x1 = (ox - GetTextWidth(text) - 10.0).floor
			else
				r.x1 = (ox + 10.0).floor
			end
			r.y1 = (py - 6.0).floor
			r.x2 = r.x1 + GetTextWidth(text)
			r.y2 = r.y1 + GetTextHeight(text)

			# Add padding
			r.x1 = r.x1 - padding
			r.y1 = r.y1 - padding
			r.x2 = r.x2 + padding
			r.y2 = r.y2 + padding

			currentOverlaps = false

			j = 0.0
			while(j < nextRectangle.numberValue)
				currentOverlaps = currentOverlaps || RectanglesOverlap(r, occupied[j])
				j = j + 1.0
			end

			# Draw labels with priority 1 if they do not overlap anything else.
			if !currentOverlaps && p == 1.0
				DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor)

				CopyRectangleValues(occupied[nextRectangle.numberValue], r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			end

			overlap = overlap || currentOverlaps
		end
		i = i + 1.0
	end
	if !overlap && p != 1.0
		i = 0.0
		while(i < yGridPositions.length)
			y = yGridPositions[i]
			py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)

			if yLabelPriorities.numberArray[i] == p
				text = yLabels.stringArray[i].string

				if textOnLeft
					r.x1 = (ox - GetTextWidth(text) - 10.0).floor
				else
					r.x1 = (ox + 10.0).floor
				end
				r.y1 = (py - 6.0).floor
				r.x2 = r.x1 + GetTextWidth(text)
				r.y2 = r.y1 + GetTextHeight(text)

				DrawText(canvas, r.x1, r.y1, text, gridLabelColor)

				CopyRectangleValues(occupied[nextRectangle.numberValue], r)
				nextRectangle.numberValue = nextRectangle.numberValue + 1.0
			end
			i = i + 1.0
		end
	end
end


def ComputeGridLinePositions(cMin, cMax, labels, priorities)

	cLength = cMax - cMin

	p = (Math.log10(cLength)).floor
	pInterval = 10.0**p
	# gives 10-1 lines for 100-10 diff
	pMin = (cMin.to_f / pInterval).ceil*pInterval
	pMax = (cMax.to_f / pInterval).floor*pInterval
	pNum = Round((pMax - pMin).to_f / pInterval + 1.0)

	mode = 1.0

	if pNum <= 3.0
		p = (Math.log10(cLength) - 1.0).floor
		# gives 100-10 lines for 100-10 diff
		pInterval = 10.0**p
		pMin = (cMin.to_f / pInterval).ceil*pInterval
		pMax = (cMax.to_f / pInterval).floor*pInterval
		pNum = Round((pMax - pMin).to_f / pInterval + 1.0)

		mode = 4.0
	elsif pNum <= 6.0
		p = (Math.log10(cLength)).floor
		pInterval = 10.0**p.to_f / 4.0
		# gives 40-5 lines for 100-10 diff
		pMin = (cMin.to_f / pInterval).ceil*pInterval
		pMax = (cMax.to_f / pInterval).floor*pInterval
		pNum = Round((pMax - pMin).to_f / pInterval + 1.0)

		mode = 3.0
	elsif pNum <= 10.0
		p = (Math.log10(cLength)).floor
		pInterval = 10.0**p.to_f / 2.0
		# gives 20-3 lines for 100-10 diff
		pMin = (cMin.to_f / pInterval).ceil*pInterval
		pMax = (cMax.to_f / pInterval).floor*pInterval
		pNum = Round((pMax - pMin).to_f / pInterval + 1.0)

		mode = 2.0
	end

	positions = Array.new(pNum)
	labels.stringArray = Array.new(pNum)
	priorities.numberArray = Array.new(pNum)

	i = 0.0
	while(i < pNum)
		num = pMin + pInterval*i
		positions[i] = num

		# Always print priority 1 labels. Only draw priority 2 if they can all be drawn. Then, only draw priority 3 if they can all be drawn.
		priority = 1.0

		# Prioritize x.25, x.5 and x.75 lower.
		if mode == 2.0 || mode == 3.0
			rem = ((num.to_f / 10.0**(p - 2.0)).round).abs%100.0

			priority = 1.0
			if rem == 50.0
				priority = 2.0
			elsif rem == 25.0 || rem == 75.0
				priority = 3.0
			end
		end

		# Prioritize x.1-x.4 and x.6-x.9 lower
		if mode == 4.0
			rem = (Round(num.to_f / 10.0**p)).abs%10.0

			priority = 1.0
			if rem == 1.0 || rem == 2.0 || rem == 3.0 || rem == 4.0 || rem == 6.0 || rem == 7.0 || rem == 8.0 || rem == 9.0
				priority = 2.0
			end
		end

		# 0 has lowest priority.
		if EpsilonCompare(num, 0.0, 10.0**(p - 5.0))
			priority = 3.0
		end

		priorities.numberArray[i] = priority

		# The label itself.
		labels.stringArray[i] = StringReference.new
		if p < 0.0
			if mode == 2.0 || mode == 3.0
				num = RoundToDigits(num, -(p - 1.0))
			else
				num = RoundToDigits(num, -p)
			end
		end
		labels.stringArray[i].string = CreateStringDecimalFromNumber(num)
		i = i + 1.0
	end

	return positions
end


def MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)

	yLength = yMax - yMin
	yPixelLength = yPixelMax - yPixelMin

	y = y - yMin
	y = y*yPixelLength.to_f / yLength
	y = yPixelLength - y
	y = y + yPixelMin
	return y
end


def MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)

	xLength = xMax - xMin
	xPixelLength = xPixelMax - xPixelMin

	x = x - xMin
	x = x*xPixelLength.to_f / xLength
	x = x + xPixelMin
	return x
end


def MapXCoordinateAutoSettings(x, image, xs)
	return MapXCoordinate(x, GetMinimum(xs), GetMaximum(xs), GetDefaultPaddingPercentage()*ImageWidth(image), (1.0 - GetDefaultPaddingPercentage())*ImageWidth(image))
end


def MapYCoordinateAutoSettings(y, image, ys)
	return MapYCoordinate(y, GetMinimum(ys), GetMaximum(ys), GetDefaultPaddingPercentage()*ImageHeight(image), (1.0 - GetDefaultPaddingPercentage())*ImageHeight(image))
end


def MapXCoordinateBasedOnSettings(x, settings)

	boundaries = Rectangle.new
	ComputeBoundariesBasedOnSettings(settings, boundaries)
	xMin = boundaries.x1
	xMax = boundaries.x2

	if settings.autoPadding
		xPadding = (GetDefaultPaddingPercentage()*settings.width).floor
	else
		xPadding = settings.xPadding
	end

	xPixelMin = xPadding
	xPixelMax = settings.width - xPadding

	return MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
end


def MapYCoordinateBasedOnSettings(y, settings)

	boundaries = Rectangle.new
	ComputeBoundariesBasedOnSettings(settings, boundaries)
	yMin = boundaries.y1
	yMax = boundaries.y2

	if settings.autoPadding
		yPadding = (GetDefaultPaddingPercentage()*settings.height).floor
	else
		yPadding = settings.yPadding
	end

	yPixelMin = yPadding
	yPixelMax = settings.height - yPadding

	return MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
end


def GetDefaultPaddingPercentage()
	return 0.10
end


def DrawText(canvas, x, y, text, color)

	charWidth = 8.0
	spacing = 2.0

	i = 0.0
	while(i < text.length)
		DrawAsciiCharacter(canvas, x + i*(charWidth + spacing), y, text[i], color)
		i = i + 1.0
	end
end


def DrawTextUpwards(canvas, x, y, text, color)

	buffer = CreateImage(GetTextWidth(text), GetTextHeight(text), GetTransparent())
	DrawText(buffer, 0.0, 0.0, text, color)
	rotated = RotateAntiClockwise90Degrees(buffer)
	DrawImageOnImage(canvas, rotated, x, y)
	DeleteImage(buffer)
	DeleteImage(rotated)
end


def GetDefaultScatterPlotSettings()

	settings = ScatterPlotSettings.new

	settings.autoBoundaries = true
	settings.xMax = 0.0
	settings.xMin = 0.0
	settings.yMax = 0.0
	settings.yMin = 0.0
	settings.autoPadding = true
	settings.xPadding = 0.0
	settings.yPadding = 0.0
	settings.title = "".split("")
	settings.xLabel = "".split("")
	settings.yLabel = "".split("")
	settings.scatterPlotSeries = Array.new(0)
	settings.showGrid = true
	settings.gridColor = GetGray(0.1)
	settings.xAxisAuto = true
	settings.xAxisTop = false
	settings.xAxisBottom = false
	settings.yAxisAuto = true
	settings.yAxisLeft = false
	settings.yAxisRight = false

	return settings
end


def GetDefaultScatterPlotSeriesSettings()

	series = ScatterPlotSeries.new

	series.linearInterpolation = true
	series.pointType = "pixels".split("")
	series.lineType = "solid".split("")
	series.lineThickness = 1.0
	series.xs = Array.new(0)
	series.ys = Array.new(0)
	series.color = GetBlack()

	return series
end


def DrawScatterPlot(canvasReference, width, height, xs, ys, errorMessage)

	settings = GetDefaultScatterPlotSettings()

	settings.width = width
	settings.height = height
	settings.scatterPlotSeries = Array.new(1)
	settings.scatterPlotSeries[0] = GetDefaultScatterPlotSeriesSettings()
	delete(settings.scatterPlotSeries[0].xs)
	settings.scatterPlotSeries[0].xs = xs
	delete(settings.scatterPlotSeries[0].ys)
	settings.scatterPlotSeries[0].ys = ys

	success = DrawScatterPlotFromSettings(canvasReference, settings, errorMessage)

	return success
end


def DrawScatterPlotFromSettings(canvasReference, settings, errorMessage)

	canvas = CreateImage(settings.width, settings.height, GetWhite())
	patternOffset = CreateNumberReference(0.0)

	success = ScatterPlotFromSettingsValid(settings, errorMessage)

	if success

		boundaries = Rectangle.new
		ComputeBoundariesBasedOnSettings(settings, boundaries)
		xMin = boundaries.x1
		yMin = boundaries.y1
		xMax = boundaries.x2
		yMax = boundaries.y2

		# If zero, set to defaults.
		if xMin - xMax == 0.0
			xMin = 0.0
			xMax = 10.0
		end

		if yMin - yMax == 0.0
			yMin = 0.0
			yMax = 10.0
		end

		xLength = xMax - xMin
		yLength = yMax - yMin

		if settings.autoPadding
			xPadding = (GetDefaultPaddingPercentage()*settings.width).floor
			yPadding = (GetDefaultPaddingPercentage()*settings.height).floor
		else
			xPadding = settings.xPadding
			yPadding = settings.yPadding
		end

		# Draw title
		DrawText(canvas, (settings.width.to_f / 2.0 - GetTextWidth(settings.title).to_f / 2.0).floor, (yPadding.to_f / 3.0).floor, settings.title, GetBlack())

		# Draw grid
		xPixelMin = xPadding
		yPixelMin = yPadding
		xPixelMax = settings.width - xPadding
		yPixelMax = settings.height - yPadding
		xLengthPixels = xPixelMax - xPixelMin
		yLengthPixels = yPixelMax - yPixelMin
		DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor)

		gridLabelColor = GetGray(0.5)

		xLabels = StringArrayReference.new
		xLabelPriorities = NumberArrayReference.new
		yLabels = StringArrayReference.new
		yLabelPriorities = NumberArrayReference.new
		xGridPositions = ComputeGridLinePositions(xMin, xMax, xLabels, xLabelPriorities)
		yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities)

		if settings.showGrid
			# X-grid
			i = 0.0
			while(i < xGridPositions.length)
				x = xGridPositions[i]
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
				DrawLine1px(canvas, px, yPixelMin, px, yPixelMax, settings.gridColor)
				i = i + 1.0
			end

			# Y-grid
			i = 0.0
			while(i < yGridPositions.length)
				y = yGridPositions[i]
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
				DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
				i = i + 1.0
			end
		end

		# Compute origin information.
		originYInside = yMin < 0.0 && yMax > 0.0
		originY = 0.0
		if settings.xAxisAuto
			if originYInside
				originY = 0.0
			else
				originY = yMin
			end
		else
if settings.xAxisTop
				originY = yMax
			end
			if settings.xAxisBottom
				originY = yMin
			end
		end
		originYPixels = MapYCoordinate(originY, yMin, yMax, yPixelMin, yPixelMax)

		originXInside = xMin < 0.0 && xMax > 0.0
		originX = 0.0
		if settings.yAxisAuto
			if originXInside
				originX = 0.0
			else
				originX = xMin
			end
		else
if settings.yAxisLeft
				originX = xMin
			end
			if settings.yAxisRight
				originX = xMax
			end
		end
		originXPixels = MapXCoordinate(originX, xMin, xMax, xPixelMin, xPixelMax)

		if originYInside
			originTextY = 0.0
		else
			originTextY = yMin + yLength.to_f / 2.0
		end
		originTextYPixels = MapYCoordinate(originTextY, yMin, yMax, yPixelMin, yPixelMax)

		if originXInside
			originTextX = 0.0
		else
			originTextX = xMin + xLength.to_f / 2.0
		end
		originTextXPixels = MapXCoordinate(originTextX, xMin, xMax, xPixelMin, xPixelMax)

		# Labels
		occupied = Array.new(xLabels.stringArray.length + yLabels.stringArray.length)
		i = 0.0
		while(i < occupied.length)
			occupied[i] = CreateRectangle(0.0, 0.0, 0.0, 0.0)
			i = i + 1.0
		end
		nextRectangle = CreateNumberReference(0.0)

		# x labels
		i = 1.0
		while(i <= 5.0)
			textOnBottom = true
			if !settings.xAxisAuto && settings.xAxisTop
				textOnBottom = false
			end
			DrawXLabelsForPriority(i, xMin, originYPixels, xMax, xPixelMin, xPixelMax, nextRectangle, gridLabelColor, canvas, xGridPositions, xLabels, xLabelPriorities, occupied, textOnBottom)
			i = i + 1.0
		end

		# y labels
		i = 1.0
		while(i <= 5.0)
			textOnLeft = true
			if !settings.yAxisAuto && settings.yAxisRight
				textOnLeft = false
			end
			DrawYLabelsForPriority(i, yMin, originXPixels, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, textOnLeft)
			i = i + 1.0
		end

		# Draw origin line axis titles.
		axisLabelPadding = 20.0

		# x origin line
		if originYInside
			DrawLine1px(canvas, Round(xPixelMin), Round(originYPixels), Round(xPixelMax), Round(originYPixels), GetBlack())
		end

		# y origin line
		if originXInside
			DrawLine1px(canvas, Round(originXPixels), Round(yPixelMin), Round(originXPixels), Round(yPixelMax), GetBlack())
		end

		# Draw origin axis titles.
		DrawTextUpwards(canvas, 10.0, (originTextYPixels - GetTextWidth(settings.yLabel).to_f / 2.0).floor, settings.yLabel, GetBlack())
		DrawText(canvas, (originTextXPixels - GetTextWidth(settings.xLabel).to_f / 2.0).floor, yPixelMax + axisLabelPadding, settings.xLabel, GetBlack())

		# X-grid-markers
		i = 0.0
		while(i < xGridPositions.length)
			x = xGridPositions[i]
			px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
			p = xLabelPriorities.numberArray[i]
			l = 1.0
			if p == 1.0
				l = 8.0
			elsif p == 2.0
				l = 3.0
			end
			side = -1.0
			if !settings.xAxisAuto && settings.xAxisTop
				side = 1.0
			end
			DrawLine1px(canvas, px, originYPixels, px, originYPixels + side*l, GetBlack())
			i = i + 1.0
		end

		# Y-grid-markers
		i = 0.0
		while(i < yGridPositions.length)
			y = yGridPositions[i]
			py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
			p = yLabelPriorities.numberArray[i]
			l = 1.0
			if p == 1.0
				l = 8.0
			elsif p == 2.0
				l = 3.0
			end
			side = 1.0
			if !settings.yAxisAuto && settings.yAxisRight
				side = -1.0
			end
			DrawLine1px(canvas, originXPixels, py, originXPixels + side*l, py, GetBlack())
			i = i + 1.0
		end

		# Draw points
		plot = 0.0
		while(plot < settings.scatterPlotSeries.length)
			sp = settings.scatterPlotSeries[plot]

			xs = sp.xs
			ys = sp.ys
			linearInterpolation = sp.linearInterpolation

			x1Ref = NumberReference.new
			y1Ref = NumberReference.new
			x2Ref = NumberReference.new
			y2Ref = NumberReference.new
			if linearInterpolation
				prevSet = false
				xPrev = 0.0
				yPrev = 0.0
				i = 0.0
				while(i < xs.length)
					x = xs[i]
					y = ys[i]

					if prevSet
						x1Ref.numberValue = xPrev
						y1Ref.numberValue = yPrev
						x2Ref.numberValue = x
						y2Ref.numberValue = y

						success = CropLineWithinBoundary(x1Ref, y1Ref, x2Ref, y2Ref, xMin, xMax, yMin, yMax)

						if success
							pxPrev = (MapXCoordinate(x1Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax)).floor
							pyPrev = (MapYCoordinate(y1Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax)).floor
							px = (MapXCoordinate(x2Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax)).floor
							py = (MapYCoordinate(y2Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax)).floor

							if arraysStringsEqual(sp.lineType, "solid".split("")) && sp.lineThickness == 1.0
								DrawLine1px(canvas, pxPrev, pyPrev, px, py, sp.color)
							elsif arraysStringsEqual(sp.lineType, "solid".split(""))
								DrawLine(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, sp.color)
							elsif arraysStringsEqual(sp.lineType, "dashed".split(""))
								linePattern = GetLinePattern1()
								DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
							elsif arraysStringsEqual(sp.lineType, "dotted".split(""))
								linePattern = GetLinePattern2()
								DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
							elsif arraysStringsEqual(sp.lineType, "dotdash".split(""))
								linePattern = GetLinePattern3()
								DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
							elsif arraysStringsEqual(sp.lineType, "longdash".split(""))
								linePattern = GetLinePattern4()
								DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
							elsif arraysStringsEqual(sp.lineType, "twodash".split(""))
								linePattern = GetLinePattern5()
								DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
							end
						end
					end

					prevSet = true
					xPrev = x
					yPrev = y
					i = i + 1.0
				end
			else
				i = 0.0
				while(i < xs.length)
					x = xs[i]
					y = ys[i]

					if x > xMin && x < xMax && y > yMin && y < yMax

						x = (MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)).floor
						y = (MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)).floor

						if arraysStringsEqual(sp.pointType, "crosses".split(""))
							DrawPixel(canvas, x, y, sp.color)
							DrawPixel(canvas, x + 1.0, y, sp.color)
							DrawPixel(canvas, x + 2.0, y, sp.color)
							DrawPixel(canvas, x - 1.0, y, sp.color)
							DrawPixel(canvas, x - 2.0, y, sp.color)
							DrawPixel(canvas, x, y + 1.0, sp.color)
							DrawPixel(canvas, x, y + 2.0, sp.color)
							DrawPixel(canvas, x, y - 1.0, sp.color)
							DrawPixel(canvas, x, y - 2.0, sp.color)
						elsif arraysStringsEqual(sp.pointType, "circles".split(""))
							DrawCircle(canvas, x, y, 3.0, sp.color)
						elsif arraysStringsEqual(sp.pointType, "dots".split(""))
							DrawFilledCircle(canvas, x, y, 3.0, sp.color)
						elsif arraysStringsEqual(sp.pointType, "triangles".split(""))
							DrawTriangle(canvas, x, y, 3.0, sp.color)
						elsif arraysStringsEqual(sp.pointType, "filled triangles".split(""))
							DrawFilledTriangle(canvas, x, y, 3.0, sp.color)
						elsif arraysStringsEqual(sp.pointType, "pixels".split(""))
							DrawPixel(canvas, x, y, sp.color)
						elsif arraysStringsEqual(sp.pointType, "dotlinetoxaxis".split(""))
							DrawFilledCircle(canvas, x, y, 3.0, sp.color)
							yaxis = (MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)).floor
							yaxis = [[yaxis, yPixelMin].max, yPixelMax].min
							DrawLine(canvas, x, y, x, yaxis, sp.lineThickness, sp.color)
						end
					end
					i = i + 1.0
				end
			end
			plot = plot + 1.0
		end

		canvasReference.image = canvas
	end

	return success
end


def ComputeBoundariesBasedOnSettings(settings, boundaries)

	if settings.scatterPlotSeries.length >= 1.0
		xMin = GetMinimum(settings.scatterPlotSeries[0].xs)*1.05
		xMax = GetMaximum(settings.scatterPlotSeries[0].xs)*1.05
		yMin = GetMinimum(settings.scatterPlotSeries[0].ys)*1.05
		yMax = GetMaximum(settings.scatterPlotSeries[0].ys)*1.05
	else
		xMin = -10.0
		xMax = 10.0
		yMin = -10.0
		yMax = 10.0
	end

	if !settings.autoBoundaries
		xMin = settings.xMin
		xMax = settings.xMax
		yMin = settings.yMin
		yMax = settings.yMax
	else
		plot = 1.0
		while(plot < settings.scatterPlotSeries.length)
			sp = settings.scatterPlotSeries[plot]

			xMin = [xMin, GetMinimum(sp.xs)].min
			xMax = [xMax, GetMaximum(sp.xs)].max
			yMin = [yMin, GetMinimum(sp.ys)].min
			yMax = [yMax, GetMaximum(sp.ys)].max
			plot = plot + 1.0
		end
	end

	boundaries.x1 = xMin
	boundaries.y1 = yMin
	boundaries.x2 = xMax
	boundaries.y2 = yMax
end


def ScatterPlotFromSettingsValid(settings, errorMessage)

	success = true

	# Check axis placement.
	if !settings.xAxisAuto
		if settings.xAxisTop && settings.xAxisBottom
			success = false
			errorMessage.string = "x-axis not automatic and configured to be both on top and on bottom.".split("")
		end
		if !settings.xAxisTop && !settings.xAxisBottom
			success = false
			errorMessage.string = "x-axis not automatic and configured to be neither on top nor on bottom.".split("")
		end
	end

	if !settings.yAxisAuto
		if settings.yAxisLeft && settings.yAxisRight
			success = false
			errorMessage.string = "y-axis not automatic and configured to be both on top and on bottom.".split("")
		end
		if !settings.yAxisLeft && !settings.yAxisRight
			success = false
			errorMessage.string = "y-axis not automatic and configured to be neither on top nor on bottom.".split("")
		end
	end

	# Check series lengths.
	i = 0.0
	while(i < settings.scatterPlotSeries.length)
		series = settings.scatterPlotSeries[i]
		if series.xs.length != series.ys.length
			success = false
			errorMessage.string = "x and y series must be of the same length.".split("")
		end
		if series.xs.length == 0.0
			success = false
			errorMessage.string = "There must be data in the series to be plotted.".split("")
		end
		if series.linearInterpolation && series.xs.length == 1.0
			success = false
			errorMessage.string = "Linear interpolation requires at least two data points to be plotted.".split("")
		end
		i = i + 1.0
	end

	# Check bounds.
	if !settings.autoBoundaries
		if settings.xMin >= settings.xMax
			success = false
			errorMessage.string = "x min is higher than or equal to x max.".split("")
		end
		if settings.yMin >= settings.yMax
			success = false
			errorMessage.string = "y min is higher than or equal to y max.".split("")
		end
	end

	# Check padding.
	if !settings.autoPadding
		if 2.0*settings.xPadding >= settings.width
			success = false
			errorMessage.string = "The x padding is more then the width.".split("")
		end
		if 2.0*settings.yPadding >= settings.height
			success = false
			errorMessage.string = "The y padding is more then the height.".split("")
		end
	end

	# Check width and height.
	if settings.width < 0.0
		success = false
		errorMessage.string = "The width is less than 0.".split("")
	end
	if settings.height < 0.0
		success = false
		errorMessage.string = "The height is less than 0.".split("")
	end

	# Check point types.
	i = 0.0
	while(i < settings.scatterPlotSeries.length)
		series = settings.scatterPlotSeries[i]

		if series.lineThickness < 0.0
			success = false
			errorMessage.string = "The line thickness is less than 0.".split("")
		end

		if !series.linearInterpolation
			# Point type.
			found = false
			if arraysStringsEqual(series.pointType, "crosses".split(""))
				found = true
			elsif arraysStringsEqual(series.pointType, "circles".split(""))
				found = true
			elsif arraysStringsEqual(series.pointType, "dots".split(""))
				found = true
			elsif arraysStringsEqual(series.pointType, "triangles".split(""))
				found = true
			elsif arraysStringsEqual(series.pointType, "filled triangles".split(""))
				found = true
			elsif arraysStringsEqual(series.pointType, "pixels".split(""))
				found = true
			elsif arraysStringsEqual(series.pointType, "dotlinetoxaxis".split(""))
				found = true
			end
			if !found
				success = false
				errorMessage.string = "The point type is unknown.".split("")
			end
		else
			# Line type.
			found = false
			if arraysStringsEqual(series.lineType, "solid".split(""))
				found = true
			elsif arraysStringsEqual(series.lineType, "dashed".split(""))
				found = true
			elsif arraysStringsEqual(series.lineType, "dotted".split(""))
				found = true
			elsif arraysStringsEqual(series.lineType, "dotdash".split(""))
				found = true
			elsif arraysStringsEqual(series.lineType, "longdash".split(""))
				found = true
			elsif arraysStringsEqual(series.lineType, "twodash".split(""))
				found = true
			end

			if !found
				success = false
				errorMessage.string = "The line type is unknown.".split("")
			end
		end
		i = i + 1.0
	end

	return success
end


def GetDefaultBarPlotSettings()

	settings = BarPlotSettings.new

	settings.width = 800.0
	settings.height = 600.0
	settings.autoBoundaries = true
	settings.yMax = 0.0
	settings.yMin = 0.0
	settings.autoPadding = true
	settings.xPadding = 0.0
	settings.yPadding = 0.0
	settings.title = "".split("")
	settings.yLabel = "".split("")
	settings.barPlotSeries = Array.new(0)
	settings.showGrid = true
	settings.gridColor = GetGray(0.1)
	settings.autoColor = true
	settings.grayscaleAutoColor = false
	settings.autoSpacing = true
	settings.groupSeparation = 0.0
	settings.barSeparation = 0.0
	settings.autoLabels = true
	settings.xLabels = Array.new(0)
=begin
settings.autoLabels = false;
        settings.xLabels = new StringReference [5];
        settings.xLabels[0] = CreateStringReference("may 20".toCharArray());
        settings.xLabels[1] = CreateStringReference("jun 20".toCharArray());
        settings.xLabels[2] = CreateStringReference("jul 20".toCharArray());
        settings.xLabels[3] = CreateStringReference("aug 20".toCharArray());
        settings.xLabels[4] = CreateStringReference("sep 20".toCharArray());
=end

	settings.barBorder = false

	return settings
end


def GetDefaultBarPlotSeriesSettings()

	series = BarPlotSeries.new

	series.ys = Array.new(0)
	series.color = GetBlack()

	return series
end


def DrawBarPlotNoErrorCheck(width, height, ys)

	errorMessage = StringReference.new
	canvasReference = CreateRGBABitmapImageReference()

	success = DrawBarPlot(canvasReference, width, height, ys, errorMessage)

	FreeStringReference(errorMessage)

	return canvasReference.image
end


def DrawBarPlot(canvasReference, width, height, ys, errorMessage)

	errorMessage = StringReference.new
	settings = GetDefaultBarPlotSettings()

	settings.barPlotSeries = Array.new(1)
	settings.barPlotSeries[0] = GetDefaultBarPlotSeriesSettings()
	delete(settings.barPlotSeries[0].ys)
	settings.barPlotSeries[0].ys = ys
	settings.width = width
	settings.height = height

	success = DrawBarPlotFromSettings(canvasReference, settings, errorMessage)

	return success
end


def DrawBarPlotFromSettings(canvasReference, settings, errorMessage)

	success = BarPlotSettingsIsValid(settings, errorMessage)

	if success
		canvas = CreateImage(settings.width, settings.height, GetWhite())

		ss = settings.barPlotSeries.length
		gridLabelColor = GetGray(0.5)

		# padding
		if settings.autoPadding
			xPadding = (GetDefaultPaddingPercentage()*ImageWidth(canvas)).floor
			yPadding = (GetDefaultPaddingPercentage()*ImageHeight(canvas)).floor
		else
			xPadding = settings.xPadding
			yPadding = settings.yPadding
		end

		# Draw title
		DrawText(canvas, (ImageWidth(canvas).to_f / 2.0 - GetTextWidth(settings.title).to_f / 2.0).floor, (yPadding.to_f / 3.0).floor, settings.title, GetBlack())
		DrawTextUpwards(canvas, 10.0, (ImageHeight(canvas).to_f / 2.0 - GetTextWidth(settings.yLabel).to_f / 2.0).floor, settings.yLabel, GetBlack())

		# min and max
		if settings.autoBoundaries
			if ss >= 1.0
				yMax = GetMaximum(settings.barPlotSeries[0].ys)*1.05
				yMin = [0.0, GetMinimum(settings.barPlotSeries[0].ys)].min*1.05

				s = 0.0
				while(s < ss)
					yMax = [yMax, GetMaximum(settings.barPlotSeries[s].ys)].max
					yMin = [yMin, GetMinimum(settings.barPlotSeries[s].ys)].min
					s = s + 1.0
				end
			else
				yMax = 10.0
				yMin = 0.0
			end
		else
			yMin = settings.yMin
			yMax = settings.yMax
		end

		# boundaries
		xPixelMin = xPadding
		yPixelMin = yPadding
		xPixelMax = ImageWidth(canvas) - xPadding
		yPixelMax = ImageHeight(canvas) - yPadding
		xLengthPixels = xPixelMax - xPixelMin
		yLengthPixels = yPixelMax - yPixelMin

		# Draw boundary.
		DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor)

		# Draw grid lines.
		yLabels = StringArrayReference.new
		yLabelPriorities = NumberArrayReference.new
		yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities)

		if settings.showGrid
			# Y-grid
			i = 0.0
			while(i < yGridPositions.length)
				y = yGridPositions[i]
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
				DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
				i = i + 1.0
			end
		end

		# Draw origin.
		if yMin < 0.0 && yMax > 0.0
			py = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)
			DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
		end

		# Labels
		occupied = Array.new(yLabels.stringArray.length)
		i = 0.0
		while(i < occupied.length)
			occupied[i] = CreateRectangle(0.0, 0.0, 0.0, 0.0)
			i = i + 1.0
		end
		nextRectangle = CreateNumberReference(0.0)

		i = 1.0
		while(i <= 5.0)
			DrawYLabelsForPriority(i, yMin, xPixelMin, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, true)
			i = i + 1.0
		end

		# Draw bars.
		if settings.autoColor
			if !settings.grayscaleAutoColor
				colors = Get8HighContrastColors()
			else
				colors = Array.new(ss)
				if ss > 1.0
					i = 0.0
					while(i < ss)
						colors[i] = GetGray(0.7 - (i.to_f / ss)*0.7)
						i = i + 1.0
					end
				else
					colors[0] = GetGray(0.5)
				end
			end
		else
			colors = Array.new(0)
		end

		# distances
		bs = settings.barPlotSeries[0].ys.length

		if settings.autoSpacing
			groupSeparation = ImageWidth(canvas)*0.05
			barSeparation = ImageWidth(canvas)*0.005
		else
			groupSeparation = settings.groupSeparation
			barSeparation = settings.barSeparation
		end

		barWidth = (xLengthPixels - groupSeparation*(bs - 1.0) - barSeparation*(bs*(ss - 1.0))).to_f / (bs*ss)

		# Draw bars.
		b = 0.0
		n = 0.0
		while(n < bs)
			s = 0.0
			while(s < ss)
				ys = settings.barPlotSeries[s].ys

				yValue = ys[n]

				yBottom = MapYCoordinate(yValue, yMin, yMax, yPixelMin, yPixelMax)
				yTop = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)

				x = xPixelMin + n*(groupSeparation + ss*barWidth) + s*(barWidth) + b*barSeparation
				w = barWidth

				if yValue >= 0.0
					y = yBottom
					h = yTop - y
				else
					y = yTop
					h = yBottom - yTop
				end

				# Cut at boundaries.
				if y < yPixelMin && y + h > yPixelMax
					y = yPixelMin
					h = yPixelMax - yPixelMin
				elsif y < yPixelMin
					y = yPixelMin
					if yValue >= 0.0
						h = yTop - y
					else
						h = yBottom - y
					end
				elsif y + h > yPixelMax
					h = yPixelMax - y
				end

				# Get color
				if settings.autoColor
					barColor = colors[s]
				else
					barColor = settings.barPlotSeries[s].color
				end

				# Draw
				if settings.barBorder
					DrawFilledRectangleWithBorder(canvas, Round(x), Round(y), Round(w), Round(h), GetBlack(), barColor)
				else
					DrawFilledRectangle(canvas, Round(x), Round(y), Round(w), Round(h), barColor)
				end

				b = b + 1.0
				s = s + 1.0
			end
			b = b - 1.0
			n = n + 1.0
		end

		# x-labels
		n = 0.0
		while(n < bs)
			if settings.autoLabels
				label = CreateStringDecimalFromNumber(n + 1.0)
			else
				label = settings.xLabels[n].string
			end

			textwidth = GetTextWidth(label)

			x = xPixelMin + (n + 0.5)*(ss*barWidth + (ss - 1.0)*barSeparation) + n*groupSeparation - textwidth.to_f / 2.0

			DrawText(canvas, (x).floor, ImageHeight(canvas) - yPadding + 20.0, label, gridLabelColor)

			b = b + 1.0
			n = n + 1.0
		end

		canvasReference.image = canvas
	end

	return success
end


def BarPlotSettingsIsValid(settings, errorMessage)

	success = true

	# Check series lengths.
	lengthSet = false
	lengthx = 0.0
	i = 0.0
	while(i < settings.barPlotSeries.length)
		series = settings.barPlotSeries[i]

		if !lengthSet
			lengthx = series.ys.length
			lengthSet = true
		elsif lengthx != series.ys.length
			success = false
			errorMessage.string = "The number of data points must be equal for all series.".split("")
		end
		i = i + 1.0
	end

	# Check bounds.
	if !settings.autoBoundaries
		if settings.yMin >= settings.yMax
			success = false
			errorMessage.string = "Minimum y lower than maximum y.".split("")
		end
	end

	# Check padding.
	if !settings.autoPadding
		if 2.0*settings.xPadding >= settings.width
			success = false
			errorMessage.string = "Double the horizontal padding is larger than or equal to the width.".split("")
		end
		if 2.0*settings.yPadding >= settings.height
			success = false
			errorMessage.string = "Double the vertical padding is larger than or equal to the height.".split("")
		end
	end

	# Check width and height.
	if settings.width < 0.0
		success = false
		errorMessage.string = "Width lower than zero.".split("")
	end
	if settings.height < 0.0
		success = false
		errorMessage.string = "Height lower than zero.".split("")
	end

	# Check spacing
	if !settings.autoSpacing
		if settings.groupSeparation < 0.0
			success = false
			errorMessage.string = "Group separation lower than zero.".split("")
		end
		if settings.barSeparation < 0.0
			success = false
			errorMessage.string = "Bar separation lower than zero.".split("")
		end
	end

	return success
end


def GetMinimum(data)

	minimum = data[0]
	i = 0.0
	while(i < data.length)
		minimum = [minimum, data[i]].min
		i = i + 1.0
	end

	return minimum
end


def GetMaximum(data)

	maximum = data[0]
	i = 0.0
	while(i < data.length)
		maximum = [maximum, data[i]].max
		i = i + 1.0
	end

	return maximum
end


def BinomialDensity(x, size, p)
	return Combinations(size, x)*p**x*(1.0 - p)**(size - x)
end


def BinomialRandom(prg, n, size, p)

	ns = Array.new(n)

	i = 0.0
	while(i < n)
		c = 0.0

		j = 0.0
		while(j < size)
			nr = PseudorandomNextNumber(prg)
			if nr < p
				c = c + 1.0
			end
			j = j + 1.0
		end

		ns[i] = c
		i = i + 1.0
	end

	return ns
end


def BinomialProbability(x, size, prob)

	sum = 0.0
	i = 0.0
	while(i <= x)
		sum = sum + BinomialDensity(i, size, prob)
		i = i + 1.0
	end

	return sum
end


def BinomialQuantile(u, size, prob)

	sum = 0.0
	done = false
	i = 0.0
	while(i <= size && !done)
		sum = sum + BinomialDensity(i, size, prob)
		if sum > u
			done = true
		end
		i = i + 1.0
	end

	return i - 1.0
end


def NormalDensity(x, mu, sd)
	return 1.0.to_f / (Math.sqrt(2.0*Math::PI)*sd)*Math.exp(-((x - mu)**2.0.to_f / (2.0*sd**2.0)))
end


def NormalRandom(prg, n, mean, sd)

	ns = Array.new(n)

	i = 0.0
	while(i < n)
		nr = PseudorandomNextNumber(prg)
		ns[i] = NormalQuantile(nr, mean, sd)
		i = i + 1.0
	end

	return ns
end


def NormalProbability(q, mean, sd)
	return NormalProbabilityMethod2(q, mean, sd)
end


def NormalProbabilityMethod1(q, mean, sd)

	q = (q - mean).to_f / sd

	if q < 0.0
		p = 1.0 - NormalProbabilityMethod1(-q, 0.0, 1.0)
	else
		c0 = 0.2316419
		c1 = 0.319381530
		c2 = -0.356563782
		c3 = 1.781477937
		c4 = -1.821255978
		c5 = 1.330274429

		z = 1.0.to_f / (1.0 + c0*q)
		qz = z*(c1 + z*(c2 + z*(c3 + z*(c4 + c5*z))))

		p = 1.0 - qz*NormalDensity(q, 0.0, 1.0)
	end

	return p
end


def NormalProbabilityMethod2(x, mean, sd)
	return 1.0.to_f / 2.0*(1.0 + Error((x - mean).to_f / (sd*Math.sqrt(2.0))))
end


def NormalQuantile(u, mean, sd)
	return NormalQuantileMethod1(u, mean, sd)
end


def NormalQuantileMethod1(u, mean, sd)

	if u < 1.0.to_f / 2.0
		q = -NormalQuantile(1.0 - u, 0.0, 1.0)
	else
		z = Math.sqrt(-2.0*Math.log(1.0 - u))
		c0 = -0.322232431088
		c1 = -0.342242088547
		c2 = -0.020423121024
		c3 = -0.0000453642210148
		c4 = 0.099348462606
		c5 = 0.58858157049
		c6 = 0.531103462366
		c7 = 0.10353775285
		c8 = 0.0038560700634
		q1z = c0 + z*(-1.0 + z*(c1 + z*(c2 + c3*z)))
		q2z = c4 + z*(c5 + z*(c6 + z*(c7 + c8*z)))
		q = z + q1z.to_f / q2z
	end

	q = mean + q*sd

	return q
end


def NormalQuantileMethod2(u, mean, sd)
	return mean + sd*Math.sqrt(2.0)*ErrorInverse(2.0*u - 1.0)
end


def PossionMass(k, lambda)
	return lambda**k*Math.exp(-lambda).to_f / Factorial(k)
end


def PoissonRandom(prg, n, lambda)

	ns = Array.new(n)

	i = 0.0
	while(i < n)
		nr = PseudorandomNextNumber(prg)
		ns[i] = PoissonQuantile(nr, lambda)
		i = i + 1.0
	end

	return ns
end


def PoissonQuantile(p, lambda)

	sum = 0.0
	done = false
	i = 0.0
	while(i <= lambda && !done)
		sum = sum + PossionMass(i, lambda)
		if sum > p
			done = true
		end
		i = i + 1.0
	end

	return i - 1.0
end


def PoissonProbability(k, lambda)

	t = 0.0
	i = 0.0
	while(i <= k)
		t = t + lambda**i.to_f / Factorial(i)
		i = i + 1.0
	end

	return t.to_f / Math.exp(lambda)
end


def SampleWithReplacement(prg, k, n)

	ss = Array.new(k)

	i = 0.0
	while(i < k)
		ss[i] = PseudorandomNextInteger(prg, n)
		i = i + 1.0
	end

	return ss
end


def Sample(prg, k, n)

	ss = Array.new(k)
	if n.to_f / 10.0 < k
		# If k is relatively high:
		list = RandomPermutation(prg, n)

		ssReference = NumberArrayReference.new
		arraysCopyNumberArrayRange(list, 0.0, k, ssReference)
		ss = ssReference.numberArray
		delete(ssReference)
		delete(list)
	else
		# If k is relatively low:
		hasPicked = arraysCreateBooleanArray(n, false)

		i = 0.0
		while(i < n)
			nextx = PseudorandomNextInteger(prg, n)
			if !hasPicked[nextx]
				hasPicked[nextx] = true
				ss[i] = nextx
				i = i + 1.0
			end
		end

		delete(hasPicked)
	end

	return ss
end


def Shuffle(prg, list)
	FisherYatesShuffle(prg, list)
end


def FisherYatesShuffle(prg, a)

	n = a.length

	i = 0.0
	while(i < n - 2.0)
		j = PseudorandomNextIntegerBetween(prg, i, n)
		arraysSwapElementsOfNumberArray(a, i, j)
		i = i + 1.0
	end
end


def SampleWithReplacementFromArray(prg, a, k)

	source = SampleWithReplacement(prg, k, a.length)

	list = Array.new(k)

	i = 0.0
	while(i < k)
		list[i] = a[source[i]]
		i = i + 1.0
	end

	delete(source)

	return list
end


def SampleFromArray(prg, a, k)

	source = Sample(prg, k, a.length)

	list = Array.new(k)

	i = 0.0
	while(i < k)
		list[i] = a[source[i]]
		i = i + 1.0
	end

	delete(source)

	return list
end


def RandomPermutation(prg, n)

	list = Array.new(n)

	i = 0.0
	while(i < n)
		list[i] = i
		i = i + 1.0
	end

	Shuffle(prg, list)

	return list
end


def StudentTDensity(x, v)
	return Gamma((v + 1.0).to_f / 2.0).to_f / (Math.sqrt(v*Math::PI)*Gamma(v.to_f / 2.0))*(1.0 + x**2.0.to_f / v)**(-((v + 1.0).to_f / 2.0))
end


def StudentTProbability(x, v)
	return 1.0.to_f / 2.0 + x*Gamma((v + 1.0).to_f / 2.0)*Hypergeometric(1.0.to_f / 2.0, (v + 1.0).to_f / 2.0, 3.0.to_f / 2.0, -x**2.0.to_f / v, 50.0, 0.00001).to_f / (Math.sqrt(Math::PI*v)*Gamma(v.to_f / 2.0))
end


def StudentTRandom(prg, n, v)

	ns = Array.new(n)

	i = 0.0
	while(i < n)
		nr = PseudorandomNextNumber(prg)
		ns[i] = StudentTQuantile(nr, v)
		i = i + 1.0
	end

	return ns
end


def StudentTQuantile(p, v)

	if v == 1.0
		q = Math.tan(Math::PI*(p - 1.0.to_f / 2.0))
	elsif v == 2.0
		a = 4.0*p*(1.0 - p)
		q = (2.0*p - 1.0)*Math.sqrt(2.0.to_f / a)
	elsif v == 4.0
		a = 4.0*p*(1.0 - p)
		q = Math.cos(1.0.to_f / 3.0*Math.acos(Math.sqrt(a))).to_f / Math.sqrt(a)
		q = Sign(p - 1.0.to_f / 2.0)*2.0*Math.sqrt(q - 1.0)
	elsif DivisibleBy(v, 2.0)
		q = ChengFuStudentTQuantileAlgorithm(p, v)
	else
		q = HillsAlgorithm396(p, v)
	end

	return q
end


def ChengFuStudentTQuantileAlgorithm(p, v)

	k = (v.to_f / 2.0).ceil
	a = 1.0 - p

	if a != 0.5
		qi = Math.sqrt(2.0*(1.0 - 2.0*a)**2.0.to_f / (1.0 - (1.0 - 2.0*a)**2.0))

		i = 0.0
		while(i < 20.0)
			gy = 0.0
			j = 0.0
			while(j <= k - 1.0)
				gy = gy + Factorial(2.0*j).to_f / 2.0**(2.0*j).to_f / Factorial(j)**2.0*(1.0 + qi**2.0.to_f / (2.0*k))**(-j)
				j = j + 1.0
			end

			qip1 = 1.0.to_f / Math.sqrt(1.0.to_f / (2.0*k)*((gy.to_f / (1.0 - 2.0*a))**2.0 - 1.0))

			qi = qip1
			i = i + 1.0
		end

		if a > 0.5
			q = -qi
		else
			q = qi
		end
	else
		q = 0.0
	end
	return q
end


def HillsAlgorithm396(p, v)

	if p > 0.5
		negate = false
		z = 2.0*(1.0 - p)
	else
		negate = true
		z = 2.0*p
	end

	a = 1.0.to_f / (v - 0.5)
	b = 48.0.to_f / (a*a)
	c = ((20700.0*a.to_f / b - 98.0)*a - 16.0)*a + 96.36
	d = ((94.5.to_f / (b + c) - 3.0).to_f / b + 1.0)*Math.sqrt(a*Math::PI.to_f / 2.0)*v
	x = z*d
	y = x**(2.0.to_f / v)

	if y > 0.05 + a
		x = NormalQuantile(z*0.5, 0.0, 1.0)
		y = x*x
		if v < 5.0
			c = c + 0.3*(v - 4.5)*(x + 0.6)
		end
		c = c + (((0.05*d*x - 5.0)*x - 7.0)*x - 2.0)*x + b
		y = (((((0.4*y + 6.3)*y + 36.0)*y + 94.5).to_f / c - y - 3.0).to_f / b + 1.0)*x
		y = a*y*y
		if y > 0.002
			y = Math.exp(y) - 1.0
		else
			y = y + 0.5*y*y
		end
	else
		y = ((1.0.to_f / (((v + 6.0).to_f / (v*y) - 0.089*d - 0.822)*(v + 2.0)*3.0) + 0.5.to_f / (v + 4.0))*y - 1.0)*(v + 1.0).to_f / (v + 2.0) + 1.0.to_f / y
	end

	q = Math.sqrt(v*y)

	if negate
		q = -q
	end

	return q
end


def Mean(list)

	sum = 0.0
	i = 0.0
	while(i < list.length)
		sum = sum + list[i]
		i = i + 1.0
	end

	return sum.to_f / list.length
end


def MeanOfRows(list)

	means = Array.new(list.r.length)

	i = 0.0
	while(i < list.r.length)
		means[i] = Mean(list.r[i].c)
		i = i + 1.0
	end

	return means
end


def MeanOfColumns(list)

	listT = TransposeToNew(list)

	means = MeanOfRows(listT)

	delete(listT)

	return means
end


def Variance(list)

	mu = Mean(list)

	sum = 0.0
	i = 0.0
	while(i < list.length)
		sum = sum + (list[i] - mu)**2.0
		i = i + 1.0
	end

	return sum.to_f / list.length
end


def Covariance(list1, list2)

	sum = 0.0
	if list1.length == list2.length

		mu1 = Mean(list1)
		mu2 = Mean(list2)

		sum = 0.0
		i = 0.0
		while(i < list1.length)
			sum = sum + (list1[i] - mu1)*(list2[i] - mu2)
			i = i + 1.0
		end
	end

	return sum.to_f / list1.length
end


def CovarianceMatrix(x)

	mu = MeanOfColumns(x)
	muMatrix = CreateMatrixFromRowCopies(mu, NumberOfRows(x))

	xCentered = CreateCopyOfMatrix(x)
	Subtract(xCentered, muMatrix)

	a = MultiplyToNew(TransposeToNew(xCentered), xCentered)
	ScalarDivide(a, NumberOfRows(x))

	return a
end


def CorrelationMatrix(x)

	sigma = SampleCovarianceMatrix(x)

	n = NumberOfRows(sigma)
	variances = Array.new(n)
	ExtractDiagonal(sigma, variances)
	vectorPower(variances, -1.0.to_f / 2.0)
	variancesMatrix = CreateDiagonalMatrixFromArray(variances)
	t1 = CreateCopyOfMatrix(variancesMatrix)
	Multiply(t1, variancesMatrix, sigma)
	correlationMatrixResult = CreateCopyOfMatrix(variancesMatrix)
	Multiply(correlationMatrixResult, t1, variancesMatrix)

	return correlationMatrixResult
end


def SampleCovarianceMatrix(x)

	a = CovarianceMatrix(x)
	ScalarMultiply(a, NumberOfRows(x).to_f / (NumberOfRows(x) - 1.0))

	return a
end


def Correlation(list1, list2)

	cv = Covariance(list1, list2)
	sd1 = StandardDeviation(list1)
	sd2 = StandardDeviation(list2)

	return cv.to_f / (sd1*sd2)
end


def Percentile(list, p)
	return list[(list.length*p).ceil - 1.0]
end


def VarianceSample(list)
	return Variance(list)*list.length.to_f / (list.length - 1.0)
end


def StandardDeviation(list)
	return Math.sqrt(Variance(list))
end


def StandardDeviationSample(list)
	return Math.sqrt(VarianceSample(list))
end


def Median(list)

	QuickSortNumbers(list)

	if list.length%2.0 == 1.0
		m = list[(list.length.to_f / 2.0).floor]
	else
		m = (list[list.length.to_f / 2.0] + list[list.length.to_f / 2.0 - 1.0]).to_f / 2.0
	end

	return m
end


def Mode(list)

	modes = Array.new(0)
	if list.length > 0.0
		QuickSortNumbers(list)
		unique = CountUniqueNumbers(list)
		counts = CountOccurrenceOfEachNumber(list, unique)
		mostFrequent = FindMostFrequentNumber(counts)
		valuesMostFrequent = CountNumberOfHighestOccurrences(mostFrequent, counts)
		delete(modes)
		modes = GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts)
		delete(counts)
	end

	return modes
end


def CountUniqueNumbers(list)

	last = list[0]
	unique = 1.0
	i = 1.0
	while(i < list.length)
		if list[i] != last
			unique = unique + 1.0
			last = list[i]
		end
		i = i + 1.0
	end

	return unique
end


def CountOccurrenceOfEachNumber(list, unique)

	counts = Array.new(unique)

	current = 0.0
	counts[0] = 1.0
	last = list[0]
	i = 1.0
	while(i < list.length)
		if list[i] != last
			current = current + 1.0
			counts[current] = 1.0
		else
			counts[current] = counts[current] + 1.0
		end
		last = list[i]
		i = i + 1.0
	end

	return counts
end


def FindMostFrequentNumber(counts)

	mostFrequent = 0.0
	i = 0.0
	while(i < counts.length)
		mostFrequent = [counts[i], mostFrequent].max
		i = i + 1.0
	end
	return mostFrequent
end


def CountNumberOfHighestOccurrences(mostFrequent, counts)

	valuesMostFrequent = 0.0
	i = 0.0
	while(i < counts.length)
		if counts[i] == mostFrequent
			valuesMostFrequent = valuesMostFrequent + 1.0
		end
		i = i + 1.0
	end
	return valuesMostFrequent
end


def GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts)

	modes = Array.new(valuesMostFrequent)

	current = 0.0
	currentInsert = 0.0
	i = 0.0
	while(i < counts.length)
		if counts[i] == mostFrequent
			modes[currentInsert] = list[current]
			currentInsert = currentInsert + 1.0
		end

		current = current + counts[i]
		i = i + 1.0
	end

	return modes
end


def LogNormalDensity(x, mean, sd)
	return 1.0.to_f / (x*sd*Math.sqrt(2.0*Math::PI))*Math.exp(-((Math.log(x) - mean)**2.0.to_f / (2.0*sd**2.0)))
end


def LogNormalRandom(prg, n, mean, sd)

	rs = NormalRandom(prg, n, mean, sd)

	i = 0.0
	while(i < n)
		rs[i] = Math.exp(rs[i])
		i = i + 1.0
	end

	return rs
end


def LogNormalProbability(q, mean, sd)
	return NormalProbability(Math.log(q), mean, sd)
end


def LogNormalQuantile(p, mean, sd)
	return Math.exp(NormalQuantile(p, mean, sd))
end


def CreateUnsignedInteger(digits)

	x = UnsignedInteger.new
	x.digits = Array.new(digits)

	ClearUnsignedInteger(x)

	return x
end


def FreeUnsignedInteger(x)
	delete(x.digits)
	delete(x)
end


def ClearUnsignedInteger(x)

	i = 0.0
	while(i < DigitCapacityUnsignedInteger(x))
		x.digits[i] = 0.0
		i = i + 1.0
	end
end


def TrimUnsignedInteger(x)

	capacity = DigitCapacityUnsignedInteger(x)
	digits = DigitsUnsignedInteger(x)

	if capacity > digits
		newCapacity = digits
		newDigits = Array.new(newCapacity)

		i = 0.0
		while(i < newCapacity)
			newDigits[i] = x.digits[i]
			i = i + 1.0
		end

		delete(x.digits)
		x.digits = newDigits
	end
end


def ToStringUnsignedInteger(x)

	digits = DigitsUnsignedInteger(x)
	str = Array.new(digits)

	i = 0.0
	while(i < digits)
		digit = DigitUnsignedInteger(x, i)

		c = DecimalDigitToCharacter(digit)

		str[digits - i - 1.0] = c
		i = i + 1.0
	end

	return str
end


def AddUnsignedInteger(x, a, b)

	overflow = !AddFixedUnsignedInteger(x, a, b)

	if overflow
		delete(x.digits)

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)
		capacity = [ads, bds].max + 1.0
		x.digits = Array.new(capacity)

		AddFixedUnsignedInteger(x, a, b)
	end
end


def SubtractUnsignedInteger(x, a, b)

	ads = DigitsUnsignedInteger(a)
	xds = DigitCapacityUnsignedInteger(x)

	if xds < ads
		delete(x.digits)
		x.digits = Array.new(ads)
	end

	return SubtractFixedUnsignedInteger(x, a, b)
end


def MultiplyUnsignedInteger(x, a, b)

	overflow = !MultiplyFixedUnsignedInteger(x, a, b)

	if overflow
		delete(x.digits)

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)
		capacity = ads + bds
		x.digits = Array.new(capacity)

		MultiplyFixedUnsignedInteger(x, a, b)
	end
end


def DivideUnsignedInteger(q, r, a, b)

	ads = DigitsUnsignedInteger(a)
	bds = DigitsUnsignedInteger(b)
	qds = DigitCapacityUnsignedInteger(q)
	rds = DigitCapacityUnsignedInteger(r)

	if qds < ads - bds + 1.0
		capacity = ads - bds + 1.0
		q.digits = Array.new(capacity)
	end

	if rds < bds
		capacity = bds
		r.digits = Array.new(capacity)
	end

	return DivideFixedUnsignedInteger(q, r, a, b)
end


def ShiftLeftUnsignedInteger(x, shifts)

	xds = DigitsUnsignedInteger(x)
	capacity = DigitCapacityUnsignedInteger(x)

	if xds + shifts > capacity
		capacity = xds + shifts
		oldDigits = x.digits
		x.digits = Array.new(capacity)
	else
		oldDigits = x.digits
	end

	i = 0.0
	while(i < oldDigits.length - shifts)
		x.digits[oldDigits.length - i - 1.0] = oldDigits[oldDigits.length - shifts - i - 1.0]
		i = i + 1.0
	end

	while(i < oldDigits.length)
		x.digits[oldDigits.length - i - 1.0] = 0.0
		i = i + 1.0
	end
end


def CreateArbitraryPrecisionInteger(digits)

	x = ArbitraryPrecisionInteger.new
	x.sign = true
	x.number = CreateUnsignedInteger(digits)

	return x
end


def FreeArbitraryPrecisionInteger(x)
	FreeUnsignedInteger(x.number)
	delete(x)
end


def ClearArbitraryPrecisionInteger(x)
	x.sign = true
	ClearUnsignedInteger(x.number)
end


def TrimArbitraryPrecisionInteger(x)
	TrimUnsignedInteger(x.number)
end


def ToStringArbitraryPrecisionInteger(x)

	if x.number.digits.length > 0.0

		digits = DigitsUnsignedInteger(x.number)
		str = Array.new(1.0 + digits)

		if x.sign
			str[0] = "+"
		else
			str[0] = "-"
		end

		i = 0.0
		while(i < digits)
			digit = DigitUnsignedInteger(x.number, i)

			c = DecimalDigitToCharacter(digit)

			str[1.0 + digits - i - 1.0] = c
			i = i + 1.0
		end
	else
		str = Array.new(2)
		str[0] = "+"
		str[1] = "0"
	end

	return str
end


def CreateArbitraryPrecisionIntegerFromString(str)

	hasSign = 0.0
	if str.length > 0.0
		if str[0] == "-" || str[0] == "+"
			hasSign = 1.0
		end
	end

	x = CreateArbitraryPrecisionInteger(str.length - hasSign)
	stringDigits = str.length

	if str.length > 0.0
		x.sign = true
		if str[0] == "-"
			x.sign = false
		elsif str[0] == "+"
			x.sign = true
		end
	end

	i = 0.0
	while(i < stringDigits - hasSign)
		c = str[stringDigits - i - 1.0]
		digit = CharacterToDecimalDigit(c)
		x.number.digits[i] = digit
		i = i + 1.0
	end

	return x
end


def AddArbitraryPrecisionInteger(x, a, b)

	as = a.sign
	bs = b.sign

	if as == bs
		AddUnsignedInteger(x.number, a.number, b.number)
		x.sign = as
	elsif as == true
		comparisonResult = CompareFixedUnsignedInteger(a.number, b.number)

		if comparisonResult == 1.0 || comparisonResult == 0.0
			SubtractUnsignedInteger(x.number, a.number, b.number)
		else
			SubtractUnsignedInteger(x.number, b.number, a.number)
			x.sign = false
		end
	else
		comparisonResult = CompareFixedUnsignedInteger(b.number, a.number)

		if comparisonResult == 1.0 || comparisonResult == 0.0
			SubtractUnsignedInteger(x.number, b.number, a.number)
		else
			SubtractUnsignedInteger(x.number, a.number, b.number)
			x.sign = false
		end
	end
end


def SubtractArbitraryPrecisionInteger(x, a, b)

	as = a.sign
	bs = b.sign

	if as == bs
		if as == true
			comparisonResult = CompareFixedUnsignedInteger(a.number, b.number)

			if comparisonResult == 1.0 || comparisonResult == 0.0
				SubtractUnsignedInteger(x.number, a.number, b.number)
			else
				SubtractUnsignedInteger(x.number, b.number, a.number)
				x.sign = false
			end
		else
			comparisonResult = CompareFixedUnsignedInteger(b.number, a.number)

			if comparisonResult == 1.0 || comparisonResult == 0.0
				SubtractUnsignedInteger(x.number, b.number, a.number)
			else
				SubtractUnsignedInteger(x.number, a.number, b.number)
				x.sign = false
			end
		end
	elsif as == false
		AddUnsignedInteger(x.number, a.number, b.number)
		x.sign = false
	else
		AddUnsignedInteger(x.number, a.number, b.number)
		x.sign = true
	end
end


def MultiplyArbitraryPrecisionInteger(x, a, b)
	MultiplyUnsignedInteger(x.number, a.number, b.number)
	if a.sign != b.sign
		x.sign = false
	end
end


def DivideArbitraryPrecisionInteger(q, r, a, b)

	if a.sign == b.sign
		success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

		if success
			q.sign = true
			r.sign = true
		end
	elsif a.sign == false
		success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

		if success
			q.sign = false
			r.sign = true
		end

		rIsZero = true
		i = 0.0
		while(i < r.number.digits.length)
			if r.number.digits[i] != 0.0
				rIsZero = false
			end
			i = i + 1.0
		end

		if !rIsZero
			AddUnsignedInteger(a.number, a.number, b.number)
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)
			SubtractUnsignedInteger(r.number, b.number, r.number)
			SubtractUnsignedInteger(a.number, a.number, b.number)
		end
	else
		AddUnsignedInteger(a.number, a.number, b.number)

		success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

		if success
			q.sign = false
			r.sign = false
		end
	end

	return success
end


def AddArbitraryPrecisionIntegerStrings(aStr, bStr)

	a = CreateArbitraryPrecisionIntegerFromString(aStr)
	b = CreateArbitraryPrecisionIntegerFromString(bStr)
	c = CreateArbitraryPrecisionInteger(0.0)

	AddArbitraryPrecisionInteger(c, a, b)

	cStr = ToStringArbitraryPrecisionInteger(c)

	return cStr
end


def SubtractArbitraryPrecisionIntegerStrings(aStr, bStr)

	a = CreateArbitraryPrecisionIntegerFromString(aStr)
	b = CreateArbitraryPrecisionIntegerFromString(bStr)
	c = CreateArbitraryPrecisionInteger(0.0)

	SubtractArbitraryPrecisionInteger(c, a, b)

	cStr = ToStringArbitraryPrecisionInteger(c)

	return cStr
end


def MultiplyArbitraryPrecisionIntegerStrings(aStr, bStr)

	a = CreateArbitraryPrecisionIntegerFromString(aStr)
	b = CreateArbitraryPrecisionIntegerFromString(bStr)
	c = CreateArbitraryPrecisionInteger(0.0)

	MultiplyArbitraryPrecisionInteger(c, a, b)

	cStr = ToStringArbitraryPrecisionInteger(c)

	return cStr
end


def DivideArbitraryPrecisionIntegerStrings(aStr, bStr, rStr)

	a = CreateArbitraryPrecisionIntegerFromString(aStr)
	b = CreateArbitraryPrecisionIntegerFromString(bStr)
	q = CreateArbitraryPrecisionInteger(0.0)
	r = CreateArbitraryPrecisionInteger(0.0)

	DivideArbitraryPrecisionInteger(q, r, a, b)

	qStr = ToStringArbitraryPrecisionInteger(q)
	rStr.string = ToStringArbitraryPrecisionInteger(r)

	return qStr
end


def CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	x = ArbitraryPrecisionFixedPointNumber.new
	x.baseNumber = CreateArbitraryPrecisionInteger(digitsBeforePoint + digitsAfterPoint)
	x.pointPosition = digitsAfterPoint

	return x
end


def FreeArbitraryPrecisionFixedPointNumber(x)
	FreeArbitraryPrecisionInteger(x.baseNumber)
	delete(x)
end


def AddArbitraryPrecisionFixedPoint(x, a, b)

	aDigitsBeforePoint = GetDigitsBeforePoint(a)
	aDigitsAfterPoint = GetDigitsAfterPoint(a)

	bDigitsBeforePoint = GetDigitsBeforePoint(b)
	bDigitsAfterPoint = GetDigitsAfterPoint(b)

	digitsBeforePoint = [aDigitsBeforePoint, bDigitsBeforePoint].max
	digitsAfterPoint = [aDigitsAfterPoint, bDigitsAfterPoint].max

	x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
	x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
	AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

	ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
	ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

	AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber)

	success = AssignArbitraryPrecisionFixedPoint(x, x1)

	return success
end


def AssignArbitraryPrecisionFixedPoint(x, a)

	xDigitsBeforePoint = GetDigitsBeforePoint(x)
	aDigitsBeforePoint = GetDigitsBeforePoint(a)
	xDigitsAfterPoint = GetDigitsAfterPoint(x)
	aDigitsAfterPoint = GetDigitsAfterPoint(a)

	zeroOverflow = true
	if xDigitsBeforePoint < aDigitsBeforePoint
		i = 0.0
		while(i < aDigitsBeforePoint - xDigitsBeforePoint)
			if DigitUnsignedInteger(a.baseNumber.number, aDigitsBeforePoint + aDigitsAfterPoint - i - 1.0) != 0.0
				zeroOverflow = false
			end
			i = i + 1.0
		end
	end

	if zeroOverflow
		# Assign before point.
		i = 0.0
		while(i < xDigitsBeforePoint)
			if i >= aDigitsBeforePoint
				x.baseNumber.number.digits[xDigitsAfterPoint + i] = 0.0
			else
				x.baseNumber.number.digits[xDigitsAfterPoint + i] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint + i)
			end
			i = i + 1.0
		end

		# Assign after point:
		i = 0.0
		while(i < xDigitsAfterPoint)
			if aDigitsAfterPoint - i - 1.0 < 0.0
				x.baseNumber.number.digits[xDigitsAfterPoint - i - 1.0] = 0.0
			else
				x.baseNumber.number.digits[xDigitsAfterPoint - i - 1.0] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - i - 1.0)
			end
			i = i + 1.0
		end

		# Assign sign.
		x.baseNumber.sign = a.baseNumber.sign

		# Round if necessary.
		if aDigitsAfterPoint > xDigitsAfterPoint
			if x.baseNumber.sign == true
				digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

				if digit >= 5.0
					# Make epsilon.
					epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint)
					epsilon.digits[0] = 1.0
					success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon)
					FreeUnsignedInteger(epsilon)
				else
					success = true
				end
			else
				digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

				isPointFive = true
				if digit == 5.0
					i = aDigitsAfterPoint - xDigitsAfterPoint - 2.0
					while(i >= 0.0)
						if DigitUnsignedInteger(a.baseNumber.number, i) != 0.0
							isPointFive = false
						end
						i = i - 1.0
					end
				else
					isPointFive = false
				end

				if digit <= 4.0 || isPointFive
					success = true
				else
					epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint)
					epsilon.digits[0] = 1.0
					success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon)
					FreeUnsignedInteger(epsilon)
				end
			end
		else
			success = true
		end
	else
		success = false
	end

	return success
end


def GetDigitsBeforePoint(a)

	digitsAfterPoint = GetDigitsAfterPoint(a)
	sum = DigitCapacityUnsignedInteger(a.baseNumber.number)
	digitsBeforePoint = sum - digitsAfterPoint

	return digitsBeforePoint
end


def GetDigitsAfterPoint(a)
	return a.pointPosition
end


def ToStringArbitraryPrecisionFixedPoint(x)

	if x.baseNumber.number.digits.length > 0.0

		digits = GetDigitsBeforePoint(x) + GetDigitsAfterPoint(x)
		str = Array.new(1.0 + GetDigitsBeforePoint(x) + 1.0 + GetDigitsAfterPoint(x))

		if x.baseNumber.sign
			str[0] = "+"
		else
			str[0] = "-"
		end

		point = 1.0

		i = 0.0
		while(i < digits)
			digit = DigitUnsignedInteger(x.baseNumber.number, i)

			if i == x.pointPosition
				str[1.0 + digits - i - 1.0 + point] = "."
				point = 0.0
			end

			c = DecimalDigitToCharacter(digit)

			str[1.0 + digits - i - 1.0 + point] = c
			i = i + 1.0
		end
	else
		str = Array.new(3)
		str[0] = "+"
		str[1] = "0"
		str[2] = "."
	end

	return str
end


def CreateArbitraryPrecisionFixedPointFromString(digitsBeforePoint, digitsAfterPoint, str)

	x = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	hasSign = 0.0
	if str.length > 0.0
		if str[0] == "-" || str[0] == "+"
			hasSign = 1.0
		end
	end

	pointPosition = str.length
	hasPoint = 0.0
	i = 0.0
	while(i < str.length && hasPoint == 0.0)
		if str[str.length - i - 1.0] == "."
			pointPosition = i
			hasPoint = 1.0
		end
		i = i + 1.0
	end
	stringDigits = str.length

	if str.length > 0.0
		x.baseNumber.sign = true
		if str[0] == "-"
			x.baseNumber.sign = false
		elsif str[0] == "+"
			x.baseNumber.sign = true
		end
	end

	point = 0.0
	i = 0.0
	while(i < stringDigits - hasSign - hasPoint)
		if i == pointPosition
			point = 1.0
		end
		c = str[stringDigits - point - i - 1.0]
		digit = CharacterToDecimalDigit(c)
		x.baseNumber.number.digits[i] = digit
		i = i + 1.0
	end

	return x
end


def SubtractArbitraryPrecisionFixedPoint(x, a, b)

	aDigitsBeforePoint = GetDigitsBeforePoint(a)
	aDigitsAfterPoint = GetDigitsAfterPoint(a)

	bDigitsBeforePoint = GetDigitsBeforePoint(b)
	bDigitsAfterPoint = GetDigitsAfterPoint(b)

	digitsBeforePoint = [aDigitsBeforePoint, bDigitsBeforePoint].max
	digitsAfterPoint = [aDigitsAfterPoint, bDigitsAfterPoint].max

	x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
	x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
	AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

	ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
	ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

	SubtractArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber)

	success = AssignArbitraryPrecisionFixedPoint(x, x1)

	return success
end


def MultiplyArbitraryPrecisionFixedPoint(x, a, b)

	aDigitsBeforePoint = GetDigitsBeforePoint(a)
	aDigitsAfterPoint = GetDigitsAfterPoint(a)

	bDigitsBeforePoint = GetDigitsBeforePoint(b)
	bDigitsAfterPoint = GetDigitsAfterPoint(b)

	digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint
	digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint

	x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
	x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
	AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

	ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
	ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

	t = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint, 2.0*digitsAfterPoint)
	MultiplyArbitraryPrecisionInteger(t.baseNumber, x1.baseNumber, x2.baseNumber)

	success = AssignArbitraryPrecisionFixedPoint(x, t)

	return success
end


def DivideArbitraryPrecisionFixedPoint(q, a, b)

	aDigitsBeforePoint = GetDigitsBeforePoint(a)
	aDigitsAfterPoint = GetDigitsAfterPoint(a)

	bDigitsBeforePoint = GetDigitsBeforePoint(b)
	bDigitsAfterPoint = GetDigitsAfterPoint(b)

	qDigitsAfterPoint = GetDigitsAfterPoint(q)

	digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint
	digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint

	x1 = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint)
	x2 = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint, 2.0*digitsAfterPoint)

	AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
	AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

	ShiftLeftUnsignedInteger(x1.baseNumber.number, qDigitsAfterPoint + 1.0 + bDigitsAfterPoint)

	qx = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint)
	rx = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint)
	DivideArbitraryPrecisionInteger(qx.baseNumber, rx.baseNumber, x1.baseNumber, x2.baseNumber)
	qx.pointPosition = qx.pointPosition + qDigitsAfterPoint - aDigitsAfterPoint + 1.0 - 2.0*bDigitsAfterPoint

	success = AssignArbitraryPrecisionFixedPoint(q, qx)

	return success
end


def AddArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint)

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
	c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	AddArbitraryPrecisionFixedPoint(c, a, b)

	cStr = ToStringArbitraryPrecisionFixedPoint(c)

	return cStr
end


def SubtractArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint)

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
	c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	SubtractArbitraryPrecisionFixedPoint(c, a, b)

	cStr = ToStringArbitraryPrecisionFixedPoint(c)

	return cStr
end


def MultiplyArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint)

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
	c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	MultiplyArbitraryPrecisionFixedPoint(c, a, b)

	cStr = ToStringArbitraryPrecisionFixedPoint(c)

	return cStr
end


def DivideArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint)

	a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
	b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
	q = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

	DivideArbitraryPrecisionFixedPoint(q, a, b)

	qStr = ToStringArbitraryPrecisionFixedPoint(q)

	return qStr
end


def GetDigitsAfterAPFPString(str)

	pointPosition = str.length
	hasPoint = 0.0
	i = 0.0
	while(i < str.length && hasPoint == 0.0)
		if str[str.length - i - 1.0] == "."
			pointPosition = i
			hasPoint = 1.0
		end
		i = i + 1.0
	end

	if hasPoint == 0.0
		digitsAfter = 0.0
	else
		digitsAfter = pointPosition
	end

	return digitsAfter
end


def GetDigitsBeforeAPFPString(str)

	hasSign = 0.0
	if str.length > 0.0
		if str[0] == "-" || str[0] == "+"
			hasSign = 1.0
		end
	end

	pointPosition = 0.0
	hasPoint = 0.0
	i = 0.0
	while(i < str.length && hasPoint == 0.0)
		if str[str.length - i - 1.0] == "."
			pointPosition = i
			hasPoint = 1.0
		end
		i = i + 1.0
	end

	if hasPoint == 0.0
		digitsBefore = str.length - hasPoint
	else
		digitsBefore = str.length - pointPosition - hasSign - 1.0
	end

	return digitsBefore
end


def DecimalDigitToCharacter(digit)
	if digit == 1.0
		c = "1"
	elsif digit == 2.0
		c = "2"
	elsif digit == 3.0
		c = "3"
	elsif digit == 4.0
		c = "4"
	elsif digit == 5.0
		c = "5"
	elsif digit == 6.0
		c = "6"
	elsif digit == 7.0
		c = "7"
	elsif digit == 8.0
		c = "8"
	elsif digit == 9.0
		c = "9"
	else
		c = "0"
	end
	return c
end


def DigitUnsignedInteger(x, i)
	return x.digits[i]
end


def DigitsUnsignedInteger(x)

	capacity = DigitCapacityUnsignedInteger(x)
	done = false
	digits = capacity

	i = capacity - 1.0
	while(i >= 0.0 && !done)
		if DigitUnsignedInteger(x, i) == 0.0
			digits = digits - 1.0
		else
			done = true
		end
		i = i - 1.0
	end

	if digits == 0.0
		digits = 1.0
	end

	return digits
end


def ToStringFixedUnsignedInteger(x)

	digits = DigitCapacityUnsignedInteger(x)
	str = Array.new(digits)

	i = 0.0
	while(i < digits)
		digit = DigitUnsignedInteger(x, i)

		c = DecimalDigitToCharacter(digit)

		str[digits - i - 1.0] = c
		i = i + 1.0
	end

	return str
end


def DigitCapacityUnsignedInteger(x)
	return x.digits.length
end


def CreateFixedUnsignedIntegerFromString(digits, str)

	x = CreateUnsignedInteger(digits)
	stringDigits = str.length

	i = 0.0
	while(i < stringDigits)
		c = str[stringDigits - i - 1.0]

		digit = CharacterToDecimalDigit(c)

		x.digits[i] = digit
		i = i + 1.0
	end

	return x
end


def CharacterToDecimalDigit(c)

	if c == "1"
		digit = 1.0
	elsif c == "2"
		digit = 2.0
	elsif c == "3"
		digit = 3.0
	elsif c == "4"
		digit = 4.0
	elsif c == "5"
		digit = 5.0
	elsif c == "6"
		digit = 6.0
	elsif c == "7"
		digit = 7.0
	elsif c == "8"
		digit = 8.0
	elsif c == "9"
		digit = 9.0
	else
		digit = 0.0
	end

	return digit
end


def AddFixedUnsignedInteger(x, a, b)
	return AddFixedUnsignedIntegerWithShift(x, a, b, 0.0, 0.0)
end


def AddFixedUnsignedIntegerWithShift(x, a, b, aShift, bShift)

	ads = DigitsUnsignedInteger(a)
	bds = DigitsUnsignedInteger(b)
	xds = DigitCapacityUnsignedInteger(x)

	if xds >= ads && xds >= bds
		carry = 0.0

		i = 0.0
		while(i < xds)
			apos = i - aShift
			if apos >= 0.0 && apos < ads
				ad = DigitUnsignedInteger(a, apos)
			else
				ad = 0.0
			end

			bpos = i - bShift
			if bpos >= 0.0 && bpos < bds
				bd = DigitUnsignedInteger(b, bpos)
			else
				bd = 0.0
			end

			remainder = ad + bd + carry

			if remainder >= 10.0
				carry = 1.0
				remainder = remainder - 10.0
			else
				carry = 0.0
			end

			x.digits[i] = remainder
			i = i + 1.0
		end

		if carry == 1.0
			overflow = true
		else
			overflow = false
		end
	else
		overflow = true
	end

	return !overflow
end


def SubtractFixedUnsignedInteger(x, a, b)
	return SubtractFixedUnsignedIntegerWithShift(x, a, b, 0.0, 0.0)
end


def SubtractFixedUnsignedIntegerWithShift(x, a, b, aShift, bShift)

	ads = DigitsUnsignedInteger(a)
	bds = DigitsUnsignedInteger(b)
	xds = DigitCapacityUnsignedInteger(x)

	borrow = 0.0
	overflow = false

	i = 0.0
	while(i < [[ads, bds].max, xds].max && !overflow)
		apos = i - aShift
		if apos >= 0.0 && apos < ads
			ad = DigitUnsignedInteger(a, apos)
		else
			ad = 0.0
		end

		bpos = i - bShift
		if bpos >= 0.0 && bpos < bds
			bd = DigitUnsignedInteger(b, bpos)
		else
			bd = 0.0
		end

		remainder = ad - bd - borrow

		if remainder < 0.0
			borrow = 1.0
			remainder = remainder + 10.0
		else
			borrow = 0.0
		end

		if remainder != 0.0
			if i < xds
			else
				overflow = true
			end
		end

		if i < xds
			x.digits[i] = remainder
		end
		i = i + 1.0
	end

	if borrow == 1.0
		underflow = true
	else
		underflow = false
	end

	return !underflow && !overflow
end


def MultiplyFixedUnsignedInteger(c, a, b)

	success = true

	ClearUnsignedInteger(c)

	ads = DigitsUnsignedInteger(a)
	i = 0.0
	while(i < ads)
		ad = DigitUnsignedInteger(a, i)

		j = 0.0
		while(j < ad)
			success = success && AddFixedUnsignedIntegerWithShift(c, c, b, 0.0, i)
			j = j + 1.0
		end
		i = i + 1.0
	end

	if c.digits.length == 0.0
		success = false
	end

	return success
end


def CompareFixedUnsignedInteger(a, b)

	ads = DigitsUnsignedInteger(a)
	bds = DigitsUnsignedInteger(b)

	comparizonResult = 0.0

	if ads > bds
		comparizonResult = 1.0
	elsif ads < bds
		comparizonResult = -1.0
	else
		done = false
		i = ads - 1.0
		while(i >= 0.0 && !done)
			ad = DigitUnsignedInteger(a, i)
			bd = DigitUnsignedInteger(b, i)

			if ad > bd
				comparizonResult = 1.0
				done = true
			elsif ad < bd
				comparizonResult = -1.0
				done = true
			end
			i = i - 1.0
		end
	end

	return comparizonResult
end


def CompareFixedUnsignedIntegerWithShift(a, b, aShift, bShift)

	ads = DigitsUnsignedInteger(a)
	if ads > 0.0
		ads = ads + aShift
	end
	bds = DigitsUnsignedInteger(b)
	if bds > 0.0
		bds = bds + bShift
	end

	comparizonResult = 0.0

	if ads > bds
		comparizonResult = 1.0
	elsif ads < bds
		comparizonResult = -1.0
	else
		done = false
		i = ads - 1.0
		while(i >= 0.0 && !done)
			apos = i - aShift
			if apos >= 0.0 && apos < ads
				ad = DigitUnsignedInteger(a, apos)
			else
				ad = 0.0
			end

			bpos = i - bShift
			if bpos >= 0.0 && bpos < bds
				bd = DigitUnsignedInteger(b, bpos)
			else
				bd = 0.0
			end

			if ad > bd
				comparizonResult = 1.0
				done = true
			elsif ad < bd
				comparizonResult = -1.0
				done = true
			end
			i = i - 1.0
		end
	end

	return comparizonResult
end


def DivideFixedUnsignedInteger(q, r, a, b)

	success = true

	ClearUnsignedInteger(q)
	ClearUnsignedInteger(r)

	ads = DigitsUnsignedInteger(a)
	bds = DigitsUnsignedInteger(b)
	qdsCapacity = DigitCapacityUnsignedInteger(q)

	# bds == 0 -> b.digits[0] != 0
	if bds != 1.0 || b.digits[0] != 0.0
		if ads >= bds
			i = ads - bds
			while(i >= 0.0 && success)
				qd = 0.0
				done = false
				j = 0.0
				while(j <= 9.0 && !done)
					comparisonResult = CompareFixedUnsignedIntegerWithShift(a, b, 0.0, i)
					if comparisonResult == 1.0 || comparisonResult == 0.0
						SubtractFixedUnsignedIntegerWithShift(a, a, b, 0.0, i)
						qd = qd + 1.0
					else
						done = true
					end
					j = j + 1.0
				end
				if i < qdsCapacity
					q.digits[i] = qd
				else
					success = false
				end
				i = i - 1.0
			end
			if success
				# Put the rest in the remainder.
				success = AddFixedUnsignedInteger(r, r, a)

				if success
					# Reconstruct a.
					MultiplyFixedUnsignedInteger(a, q, b)
					AddFixedUnsignedInteger(a, a, r)
				end
			end
		else
			# Put everything in the remainder.
			AddFixedUnsignedInteger(r, r, a)
		end
	else
		# division by zero
		success = false
	end

	return success
end


def AssertFalse(b, failures)
	if b
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertTrue(b, failures)
	if !b
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertEquals(a, b, failures)
	if a != b
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertBooleansEqual(a, b, failures)
	if a != b
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertCharactersEqual(a, b, failures)
	if a != b
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertStringEquals(a, b, failures)
	if !arraysStringsEqual(a, b)
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertNumberArraysEqual(a, b, failures)

	if a.length == b.length
		i = 0.0
		while(i < a.length)
			AssertEquals(a[i], b[i], failures)
			i = i + 1.0
		end
	else
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertBooleanArraysEqual(a, b, failures)

	if a.length == b.length
		i = 0.0
		while(i < a.length)
			AssertBooleansEqual(a[i], b[i], failures)
			i = i + 1.0
		end
	else
		failures.numberValue = failures.numberValue + 1.0
	end
end


def AssertStringArraysEqual(a, b, failures)

	if a.length == b.length
		i = 0.0
		while(i < a.length)
			AssertStringEquals(a[i].string, b[i].string, failures)
			i = i + 1.0
		end
	else
		failures.numberValue = failures.numberValue + 1.0
	end
end


def CreateBooleanReference(value)

	ref = BooleanReference.new
	ref.booleanValue = value

	return ref
end


def CreateBooleanArrayReference(value)

	ref = BooleanArrayReference.new
	ref.booleanArray = value

	return ref
end


def CreateBooleanArrayReferenceLengthValue(lengthx, value)

	ref = BooleanArrayReference.new
	ref.booleanArray = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		ref.booleanArray[i] = value
		i = i + 1.0
	end

	return ref
end


def FreeBooleanArrayReference(booleanArrayReference)
	delete(booleanArrayReference.booleanArray)
	delete(booleanArrayReference)
end


def CreateCharacterReference(value)

	ref = CharacterReference.new
	ref.characterValue = value

	return ref
end


def CreateNumberReference(value)

	ref = NumberReference.new
	ref.numberValue = value

	return ref
end


def CreateNumberArrayReference(value)

	ref = NumberArrayReference.new
	ref.numberArray = value

	return ref
end


def CreateNumberArrayReferenceLengthValue(lengthx, value)

	ref = NumberArrayReference.new
	ref.numberArray = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		ref.numberArray[i] = value
		i = i + 1.0
	end

	return ref
end


def FreeNumberArrayReference(numberArrayReference)
	delete(numberArrayReference.numberArray)
	delete(numberArrayReference)
end


def CreateStringReference(value)

	ref = StringReference.new
	ref.string = Array.new(value.length)
	i = 0.0
	while(i < value.length)
		ref.string[i] = value[i]
		i = i + 1.0
	end

	return ref
end


def CreateStringReferenceLengthValue(lengthx, value)

	ref = StringReference.new
	ref.string = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		ref.string[i] = value
		i = i + 1.0
	end

	return ref
end


def FreeStringReference(stringReference)
	delete(stringReference.string)
	delete(stringReference)
end


def CreateStringArrayReference(strings)

	ref = StringArrayReference.new
	ref.stringArray = strings

	return ref
end


def CreateStringArrayReferenceLengthValue(lengthx, value)

	ref = StringArrayReference.new
	ref.stringArray = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		ref.stringArray[i] = CreateStringReference(value)
		i = i + 1.0
	end

	return ref
end


def FreeStringArrayReference(stringArrayReference)
	FreeStringReferenceArray(stringArrayReference.stringArray)
	delete(stringArrayReference)
end


def FreeStringReferenceArray(stringReferencesArray)
	i = 0.0
	while(i < stringReferencesArray.length)
		delete(stringReferencesArray[i])
		i = i + 1.0
	end
	delete(stringReferencesArray)
end


def Increase(nRef)
	nRef.numberValue = nRef.numberValue + 1.0

	return nRef.numberValue
end


def Decrease(nRef)
	nRef.numberValue = nRef.numberValue - 1.0

	return nRef.numberValue
end


def AddToReference(nRef, n)
	nRef.numberValue = nRef.numberValue + n

	return nRef.numberValue
end


def CreateDate(year, month, day)

	date = Date.new

	date.year = year
	date.month = month
	date.day = day

	return date
end


def IsLeapYearWithCheck(year, isLeapYearReference, message)

	if year >= 1752.0
		success = true
		itIsLeapYear = IsLeapYear(year)
	else
		success = false
		itIsLeapYear = false
		message.string = "Gregorian calendar was not in general use.".split("")
	end

	isLeapYearReference.booleanValue = itIsLeapYear
	return success
end


def IsLeapYear(year)

	if DivisibleBy(year, 4.0)
		if DivisibleBy(year, 100.0)
			if DivisibleBy(year, 400.0)
				itIsLeapYear = true
			else
				itIsLeapYear = false
			end
		else
			itIsLeapYear = true
		end
	else
		itIsLeapYear = false
	end

	return itIsLeapYear
end


def DayToDateWithCheck(dayNr, dateReference, message)

	if dayNr >= -79623.0
		date = Date.new
		remainder = NumberReference.new
		remainder.numberValue = dayNr + 79623.0
		# Days since 1752-01-01. Day 0: Thursday, 1970-01-01
		# Find year.
		date.year = GetYearFromDayNr(remainder.numberValue, remainder)

		# Find month.
		date.month = GetMonthFromDayNr(remainder.numberValue, date.year, remainder)

		# Find day.
		date.day = 1.0 + remainder.numberValue

		dateReference.date = date
		success = true
	else
		success = false
		message.string = "Gregorian calendar was not in general use before 1752.".split("")
	end

	return success
end


def DayToDate(dayNr)

	dateRef = DateReference.new
	message = StringReference.new

	success = DayToDateWithCheck(dayNr, dateRef, message)
	if success
		date = dateRef.date
		delete(dateRef)
		FreeStringReference(message)
	else
		date = CreateDate(1970.0, 1.0, 1.0)
	end

	return date
end


def GetMonthFromDayNrWithCheck(dayNr, year, monthReference, remainderReference, message)

	if dayNr >= -79623.0
		month = GetMonthFromDayNr(dayNr, year, remainderReference)
		monthReference.numberValue = month
		success = true
	else
		success = false
		message.string = "Gregorian calendar not in general use before 1752.".split("")
	end

	return success
end


def GetMonthFromDayNr(dayNr, year, remainderReference)

	daysInMonth = GetDaysInMonth(year)
	done = false
	month = 1.0

	while(!done)
		if dayNr >= daysInMonth[month]
			dayNr = dayNr - daysInMonth[month]
			month = month + 1.0
		else
			done = true
		end
	end
	remainderReference.numberValue = dayNr

	return month
end


def GetYearFromDayNrWithCheck(dayNr, yearReference, remainder, message)

	if dayNr >= 0.0
		success = true
		year = GetYearFromDayNr(dayNr, remainder)
		yearReference.numberValue = year
	else
		success = false
		message.string = "Day number must be 0 or higher. 0 is 1752-01-01.".split("")
	end

	return success
end


def GetYearFromDayNr(dayNr, remainder)

	done = false
	year = 1752.0

	while(!done)
		if IsLeapYear(year)
			nrOfDays = 366.0
		else
			nrOfDays = 365.0
		end

		if dayNr >= nrOfDays
			# First day is 0.
			dayNr = dayNr - nrOfDays
			year = year + 1.0
		else
			done = true
		end
	end
	remainder.numberValue = dayNr

	return year
end


def DaysBetweenDates(a, b)

	daysA = DateToDays(a)
	daysB = DateToDays(b)

	daysBetween = daysB - daysA

	return daysBetween
end


def GetDaysInMonthWithCheck(year, daysInMonthReference, message)

	date = CreateDate(year, 1.0, 1.0)

	success = IsValidDate(date, message)
	if success
		daysInMonth = GetDaysInMonth(year)

		daysInMonthReference.numberArray = daysInMonth
	end

	return success
end


def GetDaysInMonth(year)

	daysInMonth = Array.new(1.0 + 12.0)

	daysInMonth[0] = 0.0
	daysInMonth[1] = 31.0

	if IsLeapYear(year)
		daysInMonth[2] = 29.0
	else
		daysInMonth[2] = 28.0
	end
	daysInMonth[3] = 31.0
	daysInMonth[4] = 30.0
	daysInMonth[5] = 31.0
	daysInMonth[6] = 30.0
	daysInMonth[7] = 31.0
	daysInMonth[8] = 31.0
	daysInMonth[9] = 30.0
	daysInMonth[10] = 31.0
	daysInMonth[11] = 30.0
	daysInMonth[12] = 31.0

	return daysInMonth
end


def DateToDaysWithCheck(date, dayNumberReferenceReference, message)

	success = IsValidDate(date, message)
	if success
		days = DateToDays(date)
		dayNumberReferenceReference.numberValue = days
	end

	return success
end


def DateToDays(date)

	# Day 1752-01-01
	days = -79623.0

	days = days + DaysInYears(date.year)
	days = days + DaysInMonths(date.month, date.year)
	days = days + date.day - 1.0

	return days
end


def DateToWeekdayNumberWithCheck(date, weekDayNumberReference, message)

	success = IsValidDate(date, message)
	if success
		weekDay = DateToWeekdayNumber(date)
		weekDayNumberReference.numberValue = weekDay
	end

	return success
end


def DateToWeekdayNumber(date)

	days = DateToDays(date)

	days = days + 79623.0
	days = days + 5.0

	weekDay = days%7.0 + 1.0

	return weekDay
end


def DateToWeeknumber(date, yearRef)

	week1Start = CopyDate(date)

	week1Start.day = 1.0
	week1Start.month = 1.0
	weekday = DateToWeekdayNumber(week1Start)

	# Set week1Start to the start of the Week 1.
	# If monday, week 1 begins on Jan. 1st
	if weekday == 1.0
		week1Start.day = 1.0
	end
	# If tuesday, week 1 begins on Dec. 31st
	if weekday == 2.0
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 31.0
	end
	# If wednesday, week 1 begins on Dec. 30th
	if weekday == 3.0
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 30.0
	end
	# If thursday, week 1 begins on Dec. 29th
	if weekday == 4.0
		week1Start.year = week1Start.year - 1.0
		week1Start.month = 12.0
		week1Start.day = 29.0
	end
	# If friday, week 1 begins on Jan. 4th
	if weekday == 5.0
		week1Start.day = 4.0
	end
	# If saturday, week 1 begins on Jan. 3rd
	if weekday == 6.0
		week1Start.day = 3.0
	end
	# If sunday, week 1 begins on Jan. 2nd
	if weekday == 7.0
		week1Start.day = 2.0
	end

	days = DateToDays(date)
	daysWeek1Start = DateToDays(week1Start)

	if days >= daysWeek1Start
		weekNumber = 1.0 + ((days - daysWeek1Start).to_f / 7.0).floor

		if weekNumber >= 1.0 && weekNumber <= 52.0
			# Week is between 1 and 52 in the current year.
			yearRef.numberValue = date.year
		else
			# Is week nr 53 or 1 next year?
			newyears = CopyDate(date)
			newyears.month = 12.0
			newyears.day = 31.0
			weekdayNewYears = DateToWeekdayNumber(newyears)
			if weekdayNewYears == 1.0 || weekdayNewYears == 2.0 || weekdayNewYears == 3.0
				# Week 1 next year.
				weekNumber = 1.0
				yearRef.numberValue = date.year + 1.0
			else
				# Week 53
				yearRef.numberValue = date.year
			end
			delete(newyears)
		end
	else
		# Week is in previous year. Either 52nd or 53rd.
		newyears = CopyDate(date)
		newyears.month = 12.0
		newyears.day = 31.0
		newyears.year = date.year - 1.0
		weekNumber = DateToWeeknumber(newyears, yearRef)
		delete(newyears)
	end

	delete(week1Start)

	return weekNumber
end


def DaysInMonthsWithCheck(month, year, daysInMonthsReference, message)

	date = CreateDate(year, month, 1.0)

	success = IsValidDate(date, message)
	if success
		days = DaysInMonths(month, year)

		daysInMonthsReference.numberValue = days
	end

	return success
end


def DaysInMonths(month, year)

	daysInMonth = GetDaysInMonth(year)

	days = 0.0
	i = 1.0
	while(i < month)
		days = days + daysInMonth[i]
		i = i + 1.0
	end

	return days
end


def DaysInYearsWithCheck(years, daysReference, message)

	date = CreateDate(years, 1.0, 1.0)

	success = IsValidDate(date, message)
	if success
		days = DaysInYears(years)
		daysReference.numberValue = days
	end

	return success
end


def DaysInYears(years)

	days = 0.0
	i = 1752.0
	while(i < years)
		if IsLeapYear(i)
			nrOfDays = 366.0
		else
			nrOfDays = 365.0
		end
		days = days + nrOfDays
		i = i + 1.0
	end

	return days
end


def IsValidDate(date, message)

	if date.year >= 1752.0
		if IsInteger(date.year)
			if date.month >= 1.0 && date.month <= 12.0
				if IsInteger(date.month)
					daysInMonth = GetDaysInMonth(date.year)
					daysInThisMonth = daysInMonth[date.month]
					if date.day >= 1.0 && date.day <= daysInThisMonth
						if IsInteger(date.day)
							valid = true
						else
							valid = false
							message.string = "Day must be an integer.".split("")
						end
					else
						valid = false
						message.string = "The month does not have the given day number.".split("")
					end
				else
					valid = false
					message.string = "Month must be an integer.".split("")
				end
			else
				valid = false
				message.string = "Month must be between 1 and 12, inclusive.".split("")
			end
		else
			valid = false
			message.string = "Year must be an integer.".split("")
		end
	else
		valid = false
		message.string = "Gregorian calendar was not in general use before 1752.".split("")
	end

	return valid
end


def AddDaysToDate(date, days, message)

	daysRef = NumberReference.new
	success = DateToDaysWithCheck(date, daysRef, message)

	if success
		n = daysRef.numberValue
		n = n + days

		dateReference = DateReference.new
		success = DayToDateWithCheck(n, dateReference, message)
		if success
			AssignDate(date, dateReference.date)
		end
	end

	return success
end


def AssignDate(a, b)
	a.year = b.year
	a.month = b.month
	a.day = b.day
end


def AddMonthsToDate(date, months, message)

	backup = CopyDate(date)

	if months > 0.0
		i = 0.0
		while(i < months)
			date.month = date.month + 1.0

			if date.month == 13.0
				date.month = 1.0
				date.year = date.year + 1.0
			end
			i = i + 1.0
		end
	end
	if months < 0.0
		i = 0.0
		while(i < -months)
			date.month = date.month - 1.0

			if date.month == 0.0
				date.month = 12.0
				date.year = date.year - 1.0
			end
			i = i + 1.0
		end
	end

	success = IsValidDate(date, message)

	if success
	else
		# Restore old date
		AssignDate(date, backup)
	end

	return success
end


def DateToStringISO8601WithCheck(date, datestr, message)

	success = IsValidDate(date, message)

	if success
		if date.year <= 9999.0
			datestr.string = DateToStringISO8601(date)
		else
			message.string = "This library works from 1752 to 9999.".split("")
		end
	end

	return success
end


def DateToStringISO8601(date)

	str = Array.new(10)

	str[0] = cDecimalDigitToCharacter((date.year.to_f / 1000.0).floor)
	str[1] = cDecimalDigitToCharacter(((date.year%1000.0).to_f / 100.0).floor)
	str[2] = cDecimalDigitToCharacter(((date.year%100.0).to_f / 10.0).floor)
	str[3] = cDecimalDigitToCharacter((date.year%10.0).floor)

	str[4] = "-"

	str[5] = cDecimalDigitToCharacter(((date.month%100.0).to_f / 10.0).floor)
	str[6] = cDecimalDigitToCharacter((date.month%10.0).floor)

	str[7] = "-"

	str[8] = cDecimalDigitToCharacter(((date.day%100.0).to_f / 10.0).floor)
	str[9] = cDecimalDigitToCharacter((date.day%10.0).floor)

	return str
end


def DateFromStringISO8601(str)

	date = Date.new

	n = cCharacterToDecimalDigit(str[0])*1000.0
	n = n + cCharacterToDecimalDigit(str[1])*100.0
	n = n + cCharacterToDecimalDigit(str[2])*10.0
	n = n + cCharacterToDecimalDigit(str[3])*1.0

	date.year = n

	n = cCharacterToDecimalDigit(str[5])*10.0
	n = n + cCharacterToDecimalDigit(str[6])*1.0

	date.month = n

	n = cCharacterToDecimalDigit(str[8])*10.0
	n = n + cCharacterToDecimalDigit(str[9])*1.0

	date.day = n

	return date
end


def DateFromStringISO8601WithCheck(str, dateRef, message)

	valid = IsValidDateISO8601(str, message)

	if valid
		dateRef.date = DateFromStringISO8601(str)
	end

	return valid
end


def IsValidDateISO8601(str, message)

	if str.length == 4.0 + 1.0 + 2.0 + 1.0 + 2.0

		if cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9])
			if str[4] == "-" && str[7] == "-"
				valid = true
			else
				valid = false
				message.string = "ISO8601 date must use \'-\' in positions 5 and 8.".split("")
			end
		else
			valid = false
			message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.".split("")
		end
	else
		valid = false
		message.string = "ISO8601 date must be exactly 10 characters long.".split("")
	end

	return valid
end


def DateEquals(a, b)
	return a.year == b.year && a.month == b.month && a.day == b.day
end


def CopyDate(a)

	b = CreateDate(a.year, a.month, a.day)

	return b
end


def GetSecondsFromDate(date)

	seconds = 0.0
	dayNumberReferenceReference = NumberReference.new
	message = StringReference.new

	success = DateToDaysWithCheck(date, dayNumberReferenceReference, message)
	if success
		days = dayNumberReferenceReference.numberValue

		secondsInMinute = 60.0
		secondsInHour = 60.0*secondsInMinute
		secondsInDay = 24.0*secondsInHour

		seconds = seconds + secondsInDay*days
	end

	delete(dayNumberReferenceReference)
	delete(message)

	return seconds
end


def DateIsInInterval(interval, date)

	from = DateToDays(interval.first)
	to = DateToDays(interval.last)
	day = DateToDays(date)

	return day >= from && day <= to
end


def DateLessThan(a, b)

	less = false

	if a.year < b.year
		less = true
	elsif a.year == b.year
		if a.month < b.month
			less = true
		elsif a.month == b.month
			if a.day < b.day
				less = true
			else
			end
		end
	end

	return less
end


def CreateDateTimeTimezone(year, month, day, hours, minutes, seconds, timezoneOffsetSeconds)

	dateTimeTimezone = DateTimeTimezone.new

	dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds)
	dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

	return dateTimeTimezone
end


def CreateDateTimeTimezoneInHoursAndMinutes(year, month, day, hours, minutes, seconds, timezoneOffsetHours, timezoneOffsetMinutes)

	dateTimeTimezone = DateTimeTimezone.new

	dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds)
	dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes)

	return dateTimeTimezone
end


def GetDateFromDateTimeTimeZone(dateTimeTimezone, dateTimeReference, message)

	dateTime = dateTimeTimezone.dateTime

	return AddSecondsToDateTimeWithCheck(dateTime, -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message)
end


def CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, timezoneOffsetSeconds, dateTimeTimezoneReference, message)

	adjustedDateTimeReference = DateTimeReference.new
	dateTimeTimezone = DateTimeTimezone.new

	success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message)

	if success
		dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

		dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone
	end

	return success
end


def CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(dateTime, timezoneOffsetHours, timezoneOffsetMinutes, dateTimeTimezoneReference, message)
	return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message)
end


def GetDateTimeTimezoneFromSeconds(dateTimeTzRef, seconds, offset, message)

	dateTimeRef = DateTimeReference.new
	success = GetDateTimeFromSeconds(seconds, dateTimeRef, message)

	if success
		success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTime, offset, dateTimeTzRef, message)
	end

	return success
end


def CreateDateTime(year, month, day, hours, minutes, seconds)

	dateTime = DateTime.new

	dateTime.date = CreateDate(year, month, day)
	dateTime.hours = hours
	dateTime.minutes = minutes
	dateTime.seconds = seconds

	return dateTime
end


def GetDateTimeFromSeconds(seconds, dateTimeReference, message)

	secondsInMinute = 60.0
	secondsInHour = 60.0*secondsInMinute
	secondsInDay = 24.0*secondsInHour
	days = (seconds.to_f / secondsInDay).floor
	remainder = seconds - days*secondsInDay
	dateReference = DateReference.new

	success = DayToDateWithCheck(days, dateReference, message)
	if success
		date = dateReference.date

		dateTime = DateTime.new
		dateTime.date = date
		dateTime.hours = (remainder.to_f / secondsInHour).floor
		remainder = remainder - dateTime.hours*secondsInHour
		dateTime.minutes = (remainder.to_f / secondsInMinute).floor
		remainder = remainder - dateTime.minutes*secondsInMinute
		dateTime.seconds = remainder

		dateTimeReference.dateTime = dateTime
	end

	return success
end


def GetSecondsFromDateTime(dateTime)

	secondsInMinute = 60.0
	secondsInHour = 60.0*secondsInMinute

	seconds = GetSecondsFromDate(dateTime.date)
	seconds = seconds + secondsInHour*dateTime.hours
	seconds = seconds + secondsInMinute*dateTime.minutes
	seconds = seconds + dateTime.seconds

	return seconds
end


def GetSecondsFromMinutes(minutes)
	return minutes*60.0
end


def GetSecondsFromHours(hours)
	return GetSecondsFromMinutes(hours*60.0)
end


def GetSecondsFromDays(days)
	return GetSecondsFromHours(days*24.0)
end


def GetSecondsFromWeeks(weeks)
	return GetSecondsFromDays(weeks*7.0)
end


def GetMinutesFromSeconds(seconds)
	return seconds.to_f / 60.0
end


def GetHoursFromSeconds(seconds)
	return GetMinutesFromSeconds(seconds).to_f / 60.0
end


def GetDaysFromSeconds(seconds)
	return GetHoursFromSeconds(seconds).to_f / 24.0
end


def GetWeeksFromSeconds(seconds)
	return GetDaysFromSeconds(seconds).to_f / 7.0
end


def GetDateFromDateTime(dateTime)
	return dateTime.date
end


def AddSecondsToDateTimeWithCheck(dateTime, seconds, dateTimeReference, message)

	if IsValidDateTime(dateTime, message)
		secondsInDateTime = GetSecondsFromDateTime(dateTime)
		secondsInDateTime = secondsInDateTime + seconds

		success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message)
	else
		success = false
	end

	return success
end


def AddSecondsToDateTime(dateTime, seconds, dateTimeReference, message)

	secondsInDateTime = GetSecondsFromDateTime(dateTime)
	secondsInDateTime = secondsInDateTime + seconds

	return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message)
end


def AddMinutesToDateTime(dateTime, minutes, dateTimeReference, message)
	return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message)
end


def AddHoursToDateTime(dateTime, hours, dateTimeReference, message)
	return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message)
end


def AddDaysToDateTime(dateTime, days, dateTimeReference, message)
	return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message)
end


def AddWeeksToDateTime(dateTime, weeks, dateTimeReference, message)
	return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message)
end


def DateTimeToStringISO8601WithCheck(datetime, dateStr, message)

	success = DateToStringISO8601WithCheck(datetime.date, dateStr, message)

	if success
		delete(dateStr.string)

		success = IsValidDateTime(datetime, message)
		if success
			dateStr.string = DateTimeToStringISO8601(datetime)
		end
	end

	return success
end


def IsValidDateTime(datetime, message)

	success = IsValidDate(datetime.date, message)

	if success
		if datetime.hours <= 23.0 && datetime.hours >= 0.0
			if datetime.minutes <= 59.0 && datetime.minutes >= 0.0
				if datetime.seconds <= 59.0 && datetime.seconds >= 0.0
					success = true
				else
					success = false
					message.string = "Seconds must be between 0 and 59.".split("")
				end
			else
				success = false
				message.string = "Minutes must be between 0 and 59.".split("")
			end
		else
			success = false
			message.string = "Hours must be between 0 and 23.".split("")
		end
	end

	return success
end


def DateTimeToStringISO8601(datetime)

	str = Array.new(19)

	datestr = DateToStringISO8601(datetime.date)
	i = 0.0
	while(i < datestr.length)
		str[i] = datestr[i]
		i = i + 1.0
	end

	str[10] = "T"
	str[11] = cDecimalDigitToCharacter(((datetime.hours%100.0).to_f / 10.0).floor)
	str[12] = cDecimalDigitToCharacter((datetime.hours%10.0).floor)

	str[13] = ":"

	str[14] = cDecimalDigitToCharacter(((datetime.minutes%100.0).to_f / 10.0).floor)
	str[15] = cDecimalDigitToCharacter((datetime.minutes%10.0).floor)

	str[16] = ":"

	str[17] = cDecimalDigitToCharacter(((datetime.seconds%100.0).to_f / 10.0).floor)
	str[18] = cDecimalDigitToCharacter((datetime.seconds%10.0).floor)

	return str
end


def DateTimeFromStringISO8601(str)

	dateTime = DateTime.new

	dateTime.date = DateFromStringISO8601(str)

	n = cCharacterToDecimalDigit(str[11])*10.0
	n = n + cCharacterToDecimalDigit(str[12])*1.0

	dateTime.hours = n

	n = cCharacterToDecimalDigit(str[14])*10.0
	n = n + cCharacterToDecimalDigit(str[15])*1.0

	dateTime.minutes = n

	n = cCharacterToDecimalDigit(str[17])*10.0
	n = n + cCharacterToDecimalDigit(str[18])*1.0

	dateTime.seconds = n

	return dateTime
end


def DateTimeFromStringISO8601WithCheck(str, dateTimeRef, message)

	valid = IsValidDateTimeISO8601(str, message)

	if valid
		dateTimeRef.dateTime = DateTimeFromStringISO8601(str)
	end

	return valid
end


def IsValidDateTimeISO8601(str, message)

	if str.length == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0

		if cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9]) && cIsNumber(str[11]) && cIsNumber(str[12]) && cIsNumber(str[14]) && cIsNumber(str[15]) && cIsNumber(str[17]) && cIsNumber(str[18])
			if str[4] == "-" && str[7] == "-" && str[10] == "T" && str[13] == ":" && str[16] == ":"
				valid = true
			else
				valid = false
				message.string = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.".split("")
			end
		else
			valid = false
			message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.".split("")
		end
	else
		valid = false
		message.string = "ISO8601 date must be exactly 19 characters long.".split("")
	end

	return valid
end


def DateTimeEquals(a, b)
	return DateEquals(a.date, b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds
end


def FreeDateTime(datetime)
	delete(datetime.date)
	delete(datetime)
end


def CreateFixedPoint30d(digitsBeforeDecimalPoint, digitsAfterDecimalPoint)

	fp = FixedPoint30d.new
	fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
	fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
	fp.part1 = 0.0
	fp.part2 = 0.0

	return fp
end


def CreateFixedPoint15d(digitsBeforeDecimalPoint, digitsAfterDecimalPoint)

	fp = FixedPoint15d.new
	fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
	fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
	fp.number = 0.0

	return fp
end


def ToNumber15d(n)
	return n.number
end


def Number15d(number)

	fp = FixedPoint15d.new
	fp.digitsBeforeDecimalPoint = 7.0
	fp.digitsAfterDecimalPoint = 7.0
	fp.number = number

	return fp
end


def Assign15d(fp, number)

	success = !WillOverflow15d(fp, number)
	success = success && FixedPointIsValid15d(fp)

	if success
		fp.number = number
		fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint)
	end

	return success
end


def Assign15dFloor(fp, number)

	success = !WillOverflow15d(fp, number)
	success = success && FixedPointIsValid15d(fp)

	if success
		fp.number = number
		fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint)
	end

	return success
end


def FixedPointIsValid15d(fp)

	if IsInteger(fp.digitsAfterDecimalPoint) && IsInteger(fp.digitsBeforeDecimalPoint)
		if fp.digitsBeforeDecimalPoint >= 0.0 && fp.digitsBeforeDecimalPoint <= 15.0
			if fp.digitsAfterDecimalPoint >= 0.0 && fp.digitsAfterDecimalPoint <= 15.0
				if fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15.0
					if fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0.0
						valid = true
					else
						valid = false
					end
				else
					valid = false
				end
			else
				valid = false
			end
		else
			valid = false
		end
	else
		valid = false
	end

	return valid
end


def WillOverflow15d(fp, number)

	if (number).abs < 10.0**fp.digitsBeforeDecimalPoint
		overflow = false
	else
		overflow = true
	end

	return overflow
end


def FloorToDigits(value, digits)
	return (value*10.0**digits).floor.to_f / 10.0**digits
end


def ToString15d(fp)

	string = Array.new(1.0 + fp.digitsBeforeDecimalPoint + 1.0 + fp.digitsAfterDecimalPoint)

	decimal = fp.number*10.0**fp.digitsAfterDecimalPoint

	if decimal < 0.0
		decimal = -decimal
		string[0] = "-"
	else
		string[0] = "+"
	end

	decimal = Round(decimal)

	characterReference = CharacterReference.new

	digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint
	digitPosition = 1.0

	i = 0.0
	while(i < digits)
		if i == fp.digitsBeforeDecimalPoint
			string[digitPosition] = "."

			digitPosition = digitPosition + 1.0
		end

		d = (decimal.to_f / 10.0**(digits - i - 1.0)).floor
		d = d%10.0

		GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference)
		string[digitPosition] = characterReference.characterValue

		digitPosition = digitPosition + 1.0
		i = i + 1.0
	end

	delete(characterReference)

	return string
end


def Add15d(a, b, c)
	return Assign15d(a, b.number + c.number)
end


def Subtract15d(a, b, c)
	return Assign15d(a, b.number - c.number)
end


def Multiply15d(a, b, c)
	return Assign15d(a, b.number*c.number)
end


def DivideFloored15d(q, r, a, b)

	t = Copy15d(r)

	if b.number != 0.0
		xDivisor = Round(a.number*10.0**q.digitsAfterDecimalPoint*10.0**q.digitsAfterDecimalPoint)
		xDividend = Round(b.number*10.0**q.digitsAfterDecimalPoint)
		x = (xDivisor.to_f / xDividend).floor
		x = x.to_f / 10.0**q.digitsAfterDecimalPoint
		success = Assign15d(q, x)
		Multiply15d(t, q, b)
		Subtract15d(r, a, t)
	else
		success = false
	end

	delete(t)

	return success
end


def Copy15d(r)

	t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint)
	t.number = r.number

	return t
end


def Negate15d(a)
	a.number = -a.number
end


def Positive15d(a)
	a.number = +a.number
end


def Factorial15d(x)

	if x.number >= 0.0
		success = Assign15d(x, Factorial(x.number))
	else
		success = false
	end

	return success
end


def Round15d(x)
	return Assign15d(x, Round(x.number))
end


def BankersRound15d(x)
	return Assign15d(x, BankersRound(x.number))
end


def Ceil15d(x)
	return Assign15d(x, Ceil(x.number))
end


def Floor15d(x)
	return Assign15d(x, (x.number).floor)
end


def Truncate15d(x)
	x.number = Truncate(x.number)
end


def Absolute15d(x)
	x.number = (x.number).abs
end


def Logarithm15d(x)

	if x.number > 0.0
		success = Assign15d(x, Logarithm(x.number))
	else
		success = false
	end

	return success
end


def NaturalLogarithm15d(x)

	if x.number > 0.0
		success = Assign15d(x, NaturalLogarithm(x.number))
	else
		success = false
	end

	return success
end


def Sin15d(x)
	return Assign15d(x, Sin(x.number))
end


def Cos15d(x)
	return Assign15d(x, Cos(x.number))
end


def Tan15d(x)
	return Assign15d(x, Tan(x.number))
end


def Asin15d(x)

	if x.number >= -1.0 && x.number <= 1.0
		success = Assign15d(x, Asin(x.number))
	else
		success = false
	end

	return success
end


def Acos15d(x)

	if x.number >= -1.0 && x.number <= 1.0
		success = Assign15d(x, Acos(x.number))
	else
		success = false
	end

	return success
end


def Atan15d(x)
	return Assign15d(x, Atan(x.number))
end


def Atan2_15d(a, y, x)
	return Assign15d(a, Atan2(y.number, x.number))
end


def Squareroot15d(x)

	if x.number >= 0.0
		success = Assign15d(x, Math.sqrt(x.number))
	else
		success = false
	end

	return success
end


def Exp15d(x)
	return Assign15d(x, Exp(x.number))
end


def DivisibleBy15d(a, b)
	return ((a.number%b.number) == 0.0)
end


def Combinations15d(x, n, k)

	if IsInteger(n.number) && IsInteger(k.number)
		if n.number >= 1.0 && k.number >= 0.0 && n.number >= k.number
			success = Assign15d(x, Combinations(n.number, k.number))
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def Permutations15d(x, n, k)

	if IsInteger(n.number) && IsInteger(k.number)
		if n.number >= 1.0 && k.number >= 0.0 && n.number >= k.number
			success = Assign15d(x, Permutations(n.number, k.number))
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def Equals15d(a, b)

	an = ToNumber15d(a)
	bn = ToNumber15d(b)

	p = [a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint].max

	equals = EpsilonCompare(an, bn, 10.0**(-p))

	return equals
end


def GreaterThan15d(a, b)

	an = ToNumber15d(a)
	bn = ToNumber15d(b)

	return an > bn
end


def LessThan15d(a, b)

	an = ToNumber15d(a)
	bn = ToNumber15d(b)

	return an < bn
end


def GreaterThanOrEqual15d(a, b)

	an = ToNumber15d(a)
	bn = ToNumber15d(b)

	equal = Equals15d(a, b)

	return an > bn || equal
end


def LessThanOrEqual15d(a, b)

	an = ToNumber15d(a)
	bn = ToNumber15d(b)

	equal = Equals15d(a, b)

	return an < bn || equal
end


def EpsilonCompare15d(a, b, epsilon)
	return EpsilonCompare(a.number, b.number, epsilon.number)
end


def GreatestCommonDivisor15d(x, a, b)

	if IsInteger(a.number) && IsInteger(b.number)
		if a.number >= 0.0 && b.number >= 0.0
			success = Assign15d(x, GreatestCommonDivisor(a.number, b.number))
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def GCDWithSubtraction15d(x, a, b)

	if IsInteger(a.number) && IsInteger(b.number)
		if a.number >= 0.0 && b.number >= 0.0
			success = Assign15d(x, GCDWithSubtraction(a.number, b.number))
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def IsInteger15d(a)
	return IsInteger(a.number)
end


def LeastCommonMultiple15d(x, a, b)

	if IsInteger(a.number) && IsInteger(b.number)
		if a.number != 0.0 && b.number != 0.0
			success = Assign15d(x, LeastCommonMultiple(a.number, b.number))
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def Sign15d(a)
	return Sign(a.number)
end


def Max15d(x, a, b)
	return Assign15d(x, Max(a.number, b.number))
end


def Min15d(x, a, b)
	return Assign15d(x, Min(a.number, b.number))
end


def Power15d(x, a, b)

	if a.number != 0.0 || b.number != 0.0
		if !(a.number < 0.0 && !IsInteger(b.number))
			success = Assign15d(x, Power(a.number, b.number))
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def FormatToString15d(fp, digitsAfter)

	result = FormatToStringWithSymbols15d(fp, digitsAfter, "".split(""), ".".split(""))

	return result
end


def FormatToStringWithSymbols15d(fp, digitsAfter, thousandsSeparator, decimalPoint)

	characterReference = CharacterReference.new

	decimal = Round(fp.number*10.0**digitsAfter)

	sign = 0.0
	if decimal < 0.0
		sign = 1.0
		decimal = -decimal
	end

	if decimal != 0.0
		digits = (Math.log10(decimal) + 1.0).floor
	else
		digits = 1.0
	end
	digitsBefore = digits - digitsAfter

	if digitsBefore <= 0.0
		digitsBefore = 0.0
		thousandsTimes = 0.0
		digits = digitsAfter + 1.0
	else
		thousandsTimes = ((digitsBefore - 1.0).to_f / 3.0).floor
	end
	thousandsChars = thousandsTimes*thousandsSeparator.length

	if digitsAfter == 0.0
		decimalPointChars = 0.0
	else
		decimalPointChars = decimalPoint.length
	end

	string = Array.new(sign + digits + thousandsChars + decimalPointChars)
	p = 0.0

	if sign > 0.0
		string[p] = "-"
		p = p + 1.0
	end

	i = 0.0
	while(i < digits)
		if i == digitsBefore
			if i == 0.0
				string[p] = "0"
				p = p + 1.0
				digits = digits - 1.0
			end

			j = 0.0
			while(j < decimalPoint.length)
				string[p] = decimalPoint[j]
				p = p + 1.0
				j = j + 1.0
			end
		end

		if i < digitsBefore
			if (digitsBefore - i)%3.0 == 0.0 && i != 0.0
				j = 0.0
				while(j < thousandsSeparator.length)
					string[p] = thousandsSeparator[j]
					p = p + 1.0
					j = j + 1.0
				end
			end
		end

		d = (decimal.to_f / 10.0**(digits - i - 1.0)).floor
		d = d%10.0

		GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference)
		string[p] = characterReference.characterValue

		p = p + 1.0
		i = i + 1.0
	end

	# System.out.println(new String(string));
	return string
end


def NumberToHumanReadable(n, digitsAfter, thousandsSeparator, decimalPoint)

	if (n).abs < 1.0
		str = CreateStringDecimalFromNumber(n)
	else
		d = Math.log10(n)

		p3 = [(d.to_f / 3.0).floor, 8.0].min

		if p3 == 0.0
			u = "B"
		elsif p3 == 1.0
			u = "K"
		elsif p3 == 2.0
			u = "M"
		elsif p3 == 3.0
			u = "G"
		elsif p3 == 4.0
			u = "T"
		elsif p3 == 5.0
			u = "P"
		elsif p3 == 6.0
			u = "E"
		elsif p3 == 7.0
			u = "Z"
		else
			u = "Y"
		end

		if p3 > 1.0
			n = n.to_f / 10.0**(p3*3.0)
		end

		str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint)

		if p3 > 1.0
			str = strAppendCharacter(str, u)
		end
	end

	return str
end


def NumberToHumanReadableBinaryPrefix(n, digitsAfter, thousandsSeparator, decimalPoint)

	if (n).abs < 1.0
		str = CreateStringDecimalFromNumber(n)
	else
		d = (Math.log(n).to_f / Math.log(2.0)).floor + 1.0

		p3 = [(d.to_f / 10.0).floor, 8.0].min

		if p3 == 0.0
			u = "B".split("")
		elsif p3 == 1.0
			u = "Ki".split("")
		elsif p3 == 2.0
			u = "Mi".split("")
		elsif p3 == 3.0
			u = "Gi".split("")
		elsif p3 == 4.0
			u = "Ti".split("")
		elsif p3 == 5.0
			u = "Pi".split("")
		elsif p3 == 6.0
			u = "Ei".split("")
		elsif p3 == 7.0
			u = "Zi".split("")
		else
			u = "Yi".split("")
		end

		if p3 > 1.0
			n = n.to_f / 2.0**(p3*10.0)
		end

		str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint)

		if p3 > 1.0
			str = strAppendString(str, u)
		end
	end

	return str
end


def AddNumber(list, a)

	newlist = Array.new(list.length + 1.0)
	i = 0.0
	while(i < list.length)
		newlist[i] = list[i]
		i = i + 1.0
	end
	newlist[list.length] = a
		
	delete(list)
		
	return newlist
end


def AddNumberRef(list, i)
	list.numberArray = AddNumber(list.numberArray, i)
end


def RemoveNumber(list, n)

	newlist = Array.new(list.length - 1.0)

	if n >= 0.0 && n < list.length
		i = 0.0
		while(i < list.length)
			if i < n
				newlist[i] = list[i]
			end
			if i > n
				newlist[i - 1.0] = list[i]
			end
			i = i + 1.0
		end

		delete(list)
	else
		delete(newlist)
	end
		
	return newlist
end


def GetNumberRef(list, i)
	return list.numberArray[i]
end


def RemoveNumberRef(list, i)
	list.numberArray = RemoveNumber(list.numberArray, i)
end


def AddString(list, a)

	newlist = Array.new(list.length + 1.0)

	i = 0.0
	while(i < list.length)
		newlist[i] = list[i]
		i = i + 1.0
	end
	newlist[list.length] = a
		
	delete(list)
		
	return newlist
end


def AddStringRef(list, i)
	list.stringArray = AddString(list.stringArray, i)
end


def RemoveString(list, n)

	newlist = Array.new(list.length - 1.0)

	if n >= 0.0 && n < list.length
		i = 0.0
		while(i < list.length)
			if i < n
				newlist[i] = list[i]
			end
			if i > n
				newlist[i - 1.0] = list[i]
			end
			i = i + 1.0
		end

		delete(list)
	else
		delete(newlist)
	end
		
	return newlist
end


def GetStringRef(list, i)
	return list.stringArray[i]
end


def RemoveStringRef(list, i)
	list.stringArray = RemoveString(list.stringArray, i)
end


def CreateDynamicArrayCharacters()

	da = DynamicArrayCharacters.new
	da.array = Array.new(10)
	da.lengthx = 0.0

	return da
end


def CreateDynamicArrayCharactersWithInitialCapacity(capacity)

	da = DynamicArrayCharacters.new
	da.array = Array.new(capacity)
	da.lengthx = 0.0

	return da
end


def DynamicArrayAddCharacter(da, value)
	if da.lengthx == da.array.length
		DynamicArrayCharactersIncreaseSize(da)
	end

	da.array[da.lengthx] = value
	da.lengthx = da.lengthx + 1.0
end


def DynamicArrayAddString(da, str)

	i = 0.0
	while(i < str.length)
		DynamicArrayAddCharacter(da, str[i])
		i = i + 1.0
	end
end


def DynamicArrayCharactersIncreaseSize(da)

	newLength = (da.array.length*3.0.to_f / 2.0).round
	newArray = Array.new(newLength)

	i = 0.0
	while(i < da.array.length)
		newArray[i] = da.array[i]
		i = i + 1.0
	end

	delete(da.array)

	da.array = newArray
end


def DynamicArrayCharactersDecreaseSizeNecessary(da)

	needsDecrease = false

	if da.lengthx > 10.0
		needsDecrease = da.lengthx <= (da.array.length*2.0.to_f / 3.0).round
	end

	return needsDecrease
end


def DynamicArrayCharactersDecreaseSize(da)

	newLength = (da.array.length*2.0.to_f / 3.0).round
	newArray = Array.new(newLength)

	i = 0.0
	while(i < newLength)
		newArray[i] = da.array[i]
		i = i + 1.0
	end

	delete(da.array)

	da.array = newArray
end


def DynamicArrayCharactersIndex(da, index)
	return da.array[index]
end


def DynamicArrayCharactersLength(da)
	return da.lengthx
end


def DynamicArrayInsertCharacter(da, index, value)

	if da.lengthx == da.array.length
		DynamicArrayCharactersIncreaseSize(da)
	end

	i = da.lengthx
	while(i > index)
		da.array[i] = da.array[i - 1.0]
		i = i - 1.0
	end

	da.array[index] = value

	da.lengthx = da.lengthx + 1.0
end


def DynamicArrayCharacterSet(da, index, value)

	if index < da.lengthx
		da.array[index] = value
		success = true
	else
		success = false
	end

	return success
end


def DynamicArrayRemoveCharacter(da, index)

	i = index
	while(i < da.lengthx - 1.0)
		da.array[i] = da.array[i + 1.0]
		i = i + 1.0
	end

	da.lengthx = da.lengthx - 1.0

	if DynamicArrayCharactersDecreaseSizeNecessary(da)
		DynamicArrayCharactersDecreaseSize(da)
	end
end


def FreeDynamicArrayCharacters(da)
	delete(da.array)
	delete(da)
end


def DynamicArrayCharactersToArray(da)

	array = Array.new(da.lengthx)

	i = 0.0
	while(i < da.lengthx)
		array[i] = da.array[i]
		i = i + 1.0
	end

	return array
end


def ArrayToDynamicArrayCharactersWithOptimalSize(array)

	c = array.length
	n = (Math.log(c) - 1.0).to_f / Math.log(3.0.to_f / 2.0)
	newCapacity = (10.0*(3.0.to_f / 2.0)**n).ceil

	da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity)

	i = 0.0
	while(i < array.length)
		da.array[i] = array[i]
		i = i + 1.0
	end

	return da
end


def ArrayToDynamicArrayCharacters(array)

	da = DynamicArrayCharacters.new
	da.array = arraysCopyString(array)
	da.lengthx = array.length

	return da
end


def DynamicArrayCharactersEqual(a, b)

	equal = true
	if a.lengthx == b.lengthx
		i = 0.0
		while(i < a.lengthx && equal)
			if a.array[i] != b.array[i]
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def DynamicArrayCharactersToLinkedList(da)

	ll = CreateLinkedListCharacter()

	i = 0.0
	while(i < da.lengthx)
		LinkedListAddCharacter(ll, da.array[i])
		i = i + 1.0
	end

	return ll
end


def LinkedListToDynamicArrayCharacters(ll)

	node = ll.first

	da = DynamicArrayCharacters.new
	da.lengthx = LinkedListCharactersLength(ll)

	da.array = Array.new(da.lengthx)

	i = 0.0
	while(i < da.lengthx)
		da.array[i] = node.value
		node = node.nextx
		i = i + 1.0
	end

	return da
end


def AddBoolean(list, a)

	newlist = Array.new(list.length + 1.0)
	i = 0.0
	while(i < list.length)
		newlist[i] = list[i]
		i = i + 1.0
	end
	newlist[list.length] = a
		
	delete(list)
		
	return newlist
end


def AddBooleanRef(list, i)
	list.booleanArray = AddBoolean(list.booleanArray, i)
end


def RemoveBoolean(list, n)

	newlist = Array.new(list.length - 1.0)

	if n >= 0.0 && n < list.length
		i = 0.0
		while(i < list.length)
			if i < n
				newlist[i] = list[i]
			end
			if i > n
				newlist[i - 1.0] = list[i]
			end
			i = i + 1.0
		end

		delete(list)
	else
		delete(newlist)
	end
		
	return newlist
end


def GetBooleanRef(list, i)
	return list.booleanArray[i]
end


def RemoveDecimalRef(list, i)
	list.booleanArray = RemoveBoolean(list.booleanArray, i)
end


def CreateLinkedListString()

	ll = LinkedListStrings.new
	ll.first = LinkedListNodeStrings.new
	ll.last = ll.first
	ll.last.endx = true

	return ll
end


def LinkedListAddString(ll, value)
	ll.last.endx = false
	ll.last.value = value
	ll.last.nextx = LinkedListNodeStrings.new
	ll.last.nextx.endx = true
	ll.last = ll.last.nextx
end


def LinkedListStringsToArray(ll)

	node = ll.first

	lengthx = LinkedListStringsLength(ll)

	array = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		array[i] = StringReference.new
		array[i].string = node.value
		node = node.nextx
		i = i + 1.0
	end

	return array
end


def LinkedListStringsLength(ll)

	l = 0.0
	node = ll.first
	while(!node.endx)
		node = node.nextx
		l = l + 1.0
	end

	return l
end


def FreeLinkedListString(ll)

	node = ll.first

	while(!node.endx)
		prev = node
		node = node.nextx
		delete(prev)
	end

	delete(node)
end


def LinkedListInsertString(ll, index, value)

	if index == 0.0
		tmp = ll.first
		ll.first = LinkedListNodeStrings.new
		ll.first.nextx = tmp
		ll.first.value = value
		ll.first.endx = false
	else
		node = ll.first
		i = 0.0
		while(i < index - 1.0)
			node = node.nextx
			i = i + 1.0
		end

		tmp = node.nextx
		node.nextx = LinkedListNodeStrings.new
		node.nextx.nextx = tmp
		node.nextx.value = value
		node.nextx.endx = false
	end
end


def CreateLinkedListNumbers()

	ll = LinkedListNumbers.new
	ll.first = LinkedListNodeNumbers.new
	ll.last = ll.first
	ll.last.endx = true

	return ll
end


def CreateLinkedListNumbersArray(lengthx)

	lls = Array.new(lengthx)
	i = 0.0
	while(i < lls.length)
		lls[i] = CreateLinkedListNumbers()
		i = i + 1.0
	end

	return lls
end


def LinkedListAddNumber(ll, value)
	ll.last.endx = false
	ll.last.value = value
	ll.last.nextx = LinkedListNodeNumbers.new
	ll.last.nextx.endx = true
	ll.last = ll.last.nextx
end


def LinkedListNumbersLength(ll)

	l = 0.0
	node = ll.first
	while(!node.endx)
		node = node.nextx
		l = l + 1.0
	end

	return l
end


def LinkedListNumbersIndex(ll, index)

	node = ll.first
	i = 0.0
	while(i < index)
		node = node.nextx
		i = i + 1.0
	end

	return node.value
end


def LinkedListInsertNumber(ll, index, value)

	if index == 0.0
		tmp = ll.first
		ll.first = LinkedListNodeNumbers.new
		ll.first.nextx = tmp
		ll.first.value = value
		ll.first.endx = false
	else
		node = ll.first
		i = 0.0
		while(i < index - 1.0)
			node = node.nextx
			i = i + 1.0
		end

		tmp = node.nextx
		node.nextx = LinkedListNodeNumbers.new
		node.nextx.nextx = tmp
		node.nextx.value = value
		node.nextx.endx = false
	end
end


def LinkedListSet(ll, index, value)

	node = ll.first
	i = 0.0
	while(i < index)
		node = node.nextx
		i = i + 1.0
	end

	node.nextx.value = value
end


def LinkedListRemoveNumber(ll, index)

	node = ll.first
	prev = ll.first

	i = 0.0
	while(i < index)
		prev = node
		node = node.nextx
		i = i + 1.0
	end

	if index == 0.0
		ll.first = prev.nextx
	end
	if !prev.nextx.endx
		prev.nextx = prev.nextx.nextx
	end
end


def FreeLinkedListNumbers(ll)

	node = ll.first

	while(!node.endx)
		prev = node
		node = node.nextx
		delete(prev)
	end

	delete(node)
end


def FreeLinkedListNumbersArray(lls)

	i = 0.0
	while(i < lls.length)
		FreeLinkedListNumbers(lls[i])
		i = i + 1.0
	end
	delete(lls)
end


def LinkedListNumbersToArray(ll)

	node = ll.first

	lengthx = LinkedListNumbersLength(ll)

	array = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		array[i] = node.value
		node = node.nextx
		i = i + 1.0
	end

	return array
end


def ArrayToLinkedListNumbers(array)

	ll = CreateLinkedListNumbers()

	i = 0.0
	while(i < array.length)
		LinkedListAddNumber(ll, array[i])
		i = i + 1.0
	end

	return ll
end


def LinkedListNumbersEqual(a, b)

	an = a.first
	bn = b.first

	equal = true
	done = false
	while(equal && !done)
		if an.endx == bn.endx
			if an.endx
				done = true
			elsif an.value == bn.value
				an = an.nextx
				bn = bn.nextx
			else
				equal = false
			end
		else
			equal = false
		end
	end

	return equal
end


def CreateLinkedListCharacter()

	ll = LinkedListCharacters.new
	ll.first = LinkedListNodeCharacters.new
	ll.last = ll.first
	ll.last.endx = true

	return ll
end


def LinkedListAddCharacter(ll, value)
	ll.last.endx = false
	ll.last.value = value
	ll.last.nextx = LinkedListNodeCharacters.new
	ll.last.nextx.endx = true
	ll.last = ll.last.nextx
end


def LinkedListCharactersToArray(ll)

	node = ll.first

	lengthx = LinkedListCharactersLength(ll)

	array = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		array[i] = node.value
		node = node.nextx
		i = i + 1.0
	end

	return array
end


def LinkedListCharactersLength(ll)

	l = 0.0
	node = ll.first
	while(!node.endx)
		node = node.nextx
		l = l + 1.0
	end

	return l
end


def FreeLinkedListCharacter(ll)

	node = ll.first

	while(!node.endx)
		prev = node
		node = node.nextx
		delete(prev)
	end

	delete(node)
end


def LinkedListCharactersAddString(ll, str)

	i = 0.0
	while(i < str.length)
		LinkedListAddCharacter(ll, str[i])
		i = i + 1.0
	end
end


def LinkedListInsertCharacter(ll, index, value)

	if index == 0.0
		tmp = ll.first
		ll.first = LinkedListNodeCharacters.new
		ll.first.nextx = tmp
		ll.first.value = value
		ll.first.endx = false
	else
		node = ll.first
		i = 0.0
		while(i < index - 1.0)
			node = node.nextx
			i = i + 1.0
		end

		tmp = node.nextx
		node.nextx = LinkedListNodeCharacters.new
		node.nextx.nextx = tmp
		node.nextx.value = value
		node.nextx.endx = false
	end
end


def CreateDynamicArrayNumbers()

	da = DynamicArrayNumbers.new
	da.array = Array.new(10)
	da.lengthx = 0.0

	return da
end


def CreateDynamicArrayNumbersWithInitialCapacity(capacity)

	da = DynamicArrayNumbers.new
	da.array = Array.new(capacity)
	da.lengthx = 0.0

	return da
end


def DynamicArrayAddNumber(da, value)
	if da.lengthx == da.array.length
		DynamicArrayNumbersIncreaseSize(da)
	end

	da.array[da.lengthx] = value
	da.lengthx = da.lengthx + 1.0
end


def DynamicArrayNumbersIncreaseSize(da)

	newLength = (da.array.length*3.0.to_f / 2.0).round
	newArray = Array.new(newLength)

	i = 0.0
	while(i < da.array.length)
		newArray[i] = da.array[i]
		i = i + 1.0
	end

	delete(da.array)

	da.array = newArray
end


def DynamicArrayNumbersDecreaseSizeNecessary(da)

	needsDecrease = false

	if da.lengthx > 10.0
		needsDecrease = da.lengthx <= (da.array.length*2.0.to_f / 3.0).round
	end

	return needsDecrease
end


def DynamicArrayNumbersDecreaseSize(da)

	newLength = (da.array.length*2.0.to_f / 3.0).round
	newArray = Array.new(newLength)

	i = 0.0
	while(i < newLength)
		newArray[i] = da.array[i]
		i = i + 1.0
	end

	delete(da.array)

	da.array = newArray
end


def DynamicArrayNumbersIndex(da, index)
	return da.array[index]
end


def DynamicArrayNumbersLength(da)
	return da.lengthx
end


def DynamicArrayInsertNumber(da, index, value)

	if da.lengthx == da.array.length
		DynamicArrayNumbersIncreaseSize(da)
	end

	i = da.lengthx
	while(i > index)
		da.array[i] = da.array[i - 1.0]
		i = i - 1.0
	end

	da.array[index] = value

	da.lengthx = da.lengthx + 1.0
end


def DynamicArrayNumberSet(da, index, value)

	if index < da.lengthx
		da.array[index] = value
		success = true
	else
		success = false
	end

	return success
end


def DynamicArrayRemoveNumber(da, index)

	i = index
	while(i < da.lengthx - 1.0)
		da.array[i] = da.array[i + 1.0]
		i = i + 1.0
	end

	da.lengthx = da.lengthx - 1.0

	if DynamicArrayNumbersDecreaseSizeNecessary(da)
		DynamicArrayNumbersDecreaseSize(da)
	end
end


def FreeDynamicArrayNumbers(da)
	delete(da.array)
	delete(da)
end


def DynamicArrayNumbersToArray(da)

	array = Array.new(da.lengthx)

	i = 0.0
	while(i < da.lengthx)
		array[i] = da.array[i]
		i = i + 1.0
	end

	return array
end


def ArrayToDynamicArrayNumbersWithOptimalSize(array)

=begin

         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        
=end

	c = array.length
	n = (Math.log(c) - 1.0).to_f / Math.log(3.0.to_f / 2.0)
	newCapacity = (10.0*(3.0.to_f / 2.0)**n).ceil

	da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity)

	i = 0.0
	while(i < array.length)
		da.array[i] = array[i]
		i = i + 1.0
	end

	return da
end


def ArrayToDynamicArrayNumbers(array)

	da = DynamicArrayNumbers.new
	da.array = arraysCopyNumberArray(array)
	da.lengthx = array.length

	return da
end


def DynamicArrayNumbersEqual(a, b)

	equal = true
	if a.lengthx == b.lengthx
		i = 0.0
		while(i < a.lengthx && equal)
			if a.array[i] != b.array[i]
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def DynamicArrayNumbersToLinkedList(da)

	ll = CreateLinkedListNumbers()

	i = 0.0
	while(i < da.lengthx)
		LinkedListAddNumber(ll, da.array[i])
		i = i + 1.0
	end

	return ll
end


def LinkedListToDynamicArrayNumbers(ll)

	node = ll.first

	da = DynamicArrayNumbers.new
	da.lengthx = LinkedListNumbersLength(ll)

	da.array = Array.new(da.lengthx)

	i = 0.0
	while(i < da.lengthx)
		da.array[i] = node.value
		node = node.nextx
		i = i + 1.0
	end

	return da
end


def DynamicArrayNumbersIndexOf(arr, n, foundReference)

	found = false
	i = 0.0
	while(i < arr.lengthx && !found)
		if arr.array[i] == n
			found = true
		end
		i = i + 1.0
	end
	if !found
		i = -1.0
	else
		i = i - 1.0
	end

	foundReference.booleanValue = found

	return i
end


def DynamicArrayNumbersIsInArray(arr, n)

	found = false
	i = 0.0
	while(i < arr.lengthx && !found)
		if arr.array[i] == n
			found = true
		end
		i = i + 1.0
	end

	return found
end


def AddCharacter(list, a)

	newlist = Array.new(list.length + 1.0)
	i = 0.0
	while(i < list.length)
		newlist[i] = list[i]
		i = i + 1.0
	end
	newlist[list.length] = a
		
	delete(list)
		
	return newlist
end


def AddCharacterRef(list, i)
	list.string = AddCharacter(list.string, i)
end


def RemoveCharacter(list, n)

	newlist = Array.new(list.length - 1.0)

	if n >= 0.0 && n < list.length
		i = 0.0
		while(i < list.length)
			if i < n
				newlist[i] = list[i]
			end
			if i > n
				newlist[i - 1.0] = list[i]
			end
			i = i + 1.0
		end

		delete(list)
	else
		delete(newlist)
	end

	return newlist
end


def GetCharacterRef(list, i)
	return list.string[i]
end


def RemoveCharacterRef(list, i)
	list.string = RemoveCharacter(list.string, i)
end


def GetAccrualAmount(total, fromYear, fromMonth, fromDay, toYear, toMonth, toDay, yearOfInterest, monthOfInterest)

	from = CreateDate(fromYear, fromMonth, fromDay)
	to = CreateDate(toYear, toMonth, toDay)

	amount = GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest)

	return amount
end


def GetAccruals(total, fromYear, fromMonth, fromDay, toYear, toMonth, toDay)

	from = CreateDate(fromYear, fromMonth, fromDay)
	to = CreateDate(toYear, toMonth, toDay)

	amounts = GetAccrualsWithDates(total, from, to)

	return amounts
end


def GetAccrualsWithDates(total, from, to)

	list = CreateLinkedListNumbers()
	message = StringReference.new

	done = false
	dateOfInterest = Date.new
	AssignDate(dateOfInterest, from)
	while(!done)
		if dateOfInterest.year == to.year && dateOfInterest.month == to.month
			done = true
		end

		entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest.year, dateOfInterest.month)
		LinkedListAddNumber(list, entry)
		success = AddMonthsToDate(dateOfInterest, 1.0, message)
	end

	result = LinkedListNumbersToArray(list)
	FreeLinkedListNumbers(list)

	return result
end


def GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest)

	message = StringReference.new

	valuePerDay = CreateFixedPoint15d(13.0, 2.0)
	divisibleRemaining = CreateFixedPoint15d(13.0, 2.0)
	divisibleTotal = CreateFixedPoint15d(13.0, 2.0)
	amount = CreateFixedPoint15d(13.0, 2.0)

	days = DaysBetweenDates(from, to) + 1.0

	# DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining
	DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days))

	Multiply15d(divisibleTotal, valuePerDay, Number15d(days))
	unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, from, to, yearOfInterest, monthOfInterest)

	if !Equals15d(divisibleRemaining, Number15d(0.0))
		daysToAdjust = Round(ToNumber15d(divisibleRemaining)*100.0)
		adjustTo = Date.new
		AssignDate(adjustTo, from)
		AddDaysToDate(adjustTo, daysToAdjust - 1.0, message)

		adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest)

		delete(adjustTo)
	else
		adjustment = 0.0
	end

	Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment))

	n = ToNumber15d(amount)

	delete(valuePerDay)
	delete(divisibleRemaining)
	delete(divisibleTotal)
	delete(amount)

	return n
end


def GetUnadjustedAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest)

	value = CreateFixedPoint15d(13.0, 2.0)
	valuePerDay = CreateFixedPoint15d(13.0, 2.0)
	remainder = CreateFixedPoint15d(13.0, 2.0)

	days = DaysBetweenDates(from, to) + 1.0
	# DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...
	success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days))

	if success
		daysInMonth = GetDaysInMonth(yearOfInterest)

		if yearOfInterest < from.year
			Assign15d(value, 0.0)
		elsif yearOfInterest == from.year && monthOfInterest < from.month
			Assign15d(value, 0.0)
		elsif yearOfInterest > to.year
			Assign15d(value, 0.0)
		elsif yearOfInterest == to.year && monthOfInterest > to.month
			Assign15d(value, 0.0)
		else
if from.year == yearOfInterest && from.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest
				daysInMonthOfInterest = days
			elsif from.year == yearOfInterest && from.month == monthOfInterest
				lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[monthOfInterest])
				daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1.0
			elsif to.year == yearOfInterest && to.month == monthOfInterest
				firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0)
				daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1.0
			else
				daysInMonthOfInterest = daysInMonth[monthOfInterest]
			end

			# MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value
			Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest))
		end

		delete(daysInMonth)
	end

	n = ToNumber15d(value)

	delete(value)
	delete(valuePerDay)
	delete(remainder)

	return n
end


def CreateNewArrayData()

	data = Datax.new
	data.isArray = true
	data.isStruture = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false
	data.array = CreateArray()

	return data
end


def CreateNewStructData()

	data = Datax.new
	data.isStruture = true
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false
	data.structure = CreateStructure()

	return data
end


def CreateStructure()

	st = Structure.new
	st.keys = CreateArray()
	st.values = CreateArray()

	return st
end


def CreateNumberData(n)

	data = Datax.new
	data.isNumber = true
	data.isStruture = false
	data.isArray = false
	data.isBoolean = false
	data.isString = false
	data.number = n

	return data
end


def CreateBooleanData(b)

	data = Datax.new
	data.isBoolean = true
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isString = false
	data.booleanx = b

	return data
end


def CreateStringData(string)

	data = Datax.new
	data.isString = true
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.string = string

	return data
end


def CreateStructData(structure)

	data = Datax.new
	data.isString = false
	data.isStruture = true
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.structure = structure

	return data
end


def CreateArrayData(array)

	data = Datax.new
	data.isString = false
	data.isStruture = false
	data.isArray = true
	data.isNumber = false
	data.isBoolean = false
	data.array = array

	return data
end


def CreateNoTypeData()

	data = Datax.new
	data.isStruture = false
	data.isArray = false
	data.isNumber = false
	data.isBoolean = false
	data.isString = false

	return data
end


def AddStructToArray(ar, st)

	data = CreateNewStructData()
	delete(data.structure)
	data.structure = st

	ArrayAdd(ar, data)
end


def AddArrayToArray(ar, ar2)

	data = CreateNewArrayData()
	delete(data.array)
	data.array = ar2

	ArrayAdd(ar, data)
end


def AddNumberToArray(ar, n)
	ArrayAdd(ar, CreateNumberData(n))
end


def AddBooleanToArray(ar, b)
	ArrayAdd(ar, CreateBooleanData(b))
end


def AddStringToArray(ar, str)
	ArrayAdd(ar, CreateStringData(str))
end


def AddDataToArray(ar, data)
	ArrayAdd(ar, data)
end


def StructKeys(st)
	return ArrayLength(st.keys)
end


def StructHasKey(st, key)

	hasKey = false
	i = 0.0
	while(i < StructKeys(st))
		if arraysStringsEqual(st.keys.array[i].string, key)
			hasKey = true
		end
		i = i + 1.0
	end

	return hasKey
end


def StructKeyIndex(st, key)

	index = -1.0
	i = 0.0
	while(i < StructKeys(st))
		if arraysStringsEqual(st.keys.array[i].string, key)
			index = i
		end
		i = i + 1.0
	end

	return index
end


def GetStructKeys(st)

	nr = StructKeys(st)

	keys = Array.new(nr)

	i = 0.0
	while(i < nr)
		keys[i] = StringReference.new
		keys[i].string = arraysCopyString(st.keys.array[i].string)
		i = i + 1.0
	end

	return keys
end


def GetStructFromStruct(st, key)

	r = Structure.new
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			r = st.values.array[i].structure
		end
		i = i + 1.0
	end

	return r
end


def GetArrayFromStruct(st, key)

	r = Array.new
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			r = st.values.array[i].array
		end
		i = i + 1.0
	end

	return r
end


def GetNumberFromStruct(st, key)

	r = 0.0
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			r = st.values.array[i].number
		end
		i = i + 1.0
	end

	return r
end


def GetBooleanFromStruct(st, key)

	r = false
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			r = st.values.array[i].booleanx
		end
		i = i + 1.0
	end

	return r
end


def GetStringFromStruct(st, key)

	r = "".split("")
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			r = st.values.array[i].string
		end
		i = i + 1.0
	end

	return r
end


def GetDataFromStruct(st, key)

	r = Datax.new
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			delete(r)
			r = st.values.array[i]
		end
		i = i + 1.0
	end

	return r
end


def GetDataFromStructWithCheck(st, key, foundRef)

	r = Datax.new
	foundRef.booleanValue = false
	i = 0.0
	while(i < ArrayLength(st.keys))
		if arraysStringsEqual(st.keys.array[i].string, key)
			delete(r)
			foundRef.booleanValue = true
			r = st.values.array[i]
		end
		i = i + 1.0
	end

	return r
end


def AddStructToStruct(st, key, struct)

	if StructHasKey(st, key)
		i = StructKeyIndex(st, key)
		delete(st.values.array[i].structure)
		st.values.array[i].structure = struct
	else
		AddStringToArray(st.keys, key)
		AddStructToArray(st.values, struct)
	end
end


def AddArrayToStruct(st, key, ar)

	if StructHasKey(st, key)
		i = StructKeyIndex(st, key)
		delete(st.values.array[i].array)
		st.values.array[i].array = ar
	else
		AddStringToArray(st.keys, key)
		AddArrayToArray(st.values, ar)
	end
end


def AddNumberToStruct(st, key, n)

	if StructHasKey(st, key)
		i = StructKeyIndex(st, key)
		st.values.array[i].number = n
	else
		AddStringToArray(st.keys, key)
		AddNumberToArray(st.values, n)
	end
end


def AddBooleanToStruct(st, key, b)

	if StructHasKey(st, key)
		i = StructKeyIndex(st, key)
		st.values.array[i].booleanx = b
	else
		AddStringToArray(st.keys, key)
		AddBooleanToArray(st.values, b)
	end
end


def AddStringToStruct(st, key, value)

	if StructHasKey(st, key)
		i = StructKeyIndex(st, key)
		delete(st.values.array[i].string)
		st.values.array[i].string = value
	else
		AddStringToArray(st.keys, key)
		AddStringToArray(st.values, value)
	end
end


def AddDataToStruct(st, key, data)

	if StructHasKey(st, key)
		i = StructKeyIndex(st, key)
		FreeData(st.values.array[i])
		st.values.array[i] = data
	else
		AddStringToArray(st.keys, key)
		AddDataToArray(st.values, data)
	end
end


def FreeData(data)

	if data.isStruture
		st = data.structure
		i = 0.0
		while(i < StructKeys(st))
			FreeData(ArrayIndex(st.keys, i))
			FreeData(ArrayIndex(st.values, i))
			i = i + 1.0
		end
		delete(st)
	elsif data.isArray
		FreeArray(data.array)
	end

	delete(data)
end


def FreeArray(array)

	i = 0.0
	while(i < ArrayLength(array))
		FreeData(array.array[i])
		i = i + 1.0
	end

	delete(array.array)
	delete(array)
end


def DataTypeEquals(a, b)

	equal = true
	equal = equal && a.isStruture == b.isStruture
	equal = equal && a.isArray == b.isArray
	equal = equal && a.isNumber == b.isNumber
	equal = equal && a.isBoolean == b.isBoolean
	equal = equal && a.isString == b.isString

	return equal
end


def IsStructure(a)

	itis = a.isStruture
	if a.isArray || a.isNumber || a.isBoolean || a.isString
		itis = false
	end

	return itis
end


def IsArray(a)

	itis = a.isArray
	if a.isStruture || a.isNumber || a.isBoolean || a.isString
		itis = false
	end

	return itis
end


def IsNumber(a)

	itis = a.isNumber
	if a.isStruture || a.isArray || a.isBoolean || a.isString
		itis = false
	end

	return itis
end


def IsBoolean(a)

	itis = a.isBoolean
	if a.isStruture || a.isArray || a.isNumber || a.isString
		itis = false
	end

	return itis
end


def IsString(a)

	itis = a.isString
	if a.isStruture || a.isArray || a.isNumber || a.isBoolean
		itis = false
	end

	return itis
end


def IsNoType(a)

	if !a.isString && !a.isStruture && !a.isArray && !a.isNumber && !a.isBoolean
		itis = true
	else
		itis = false
	end

	return itis
end


def CreateArray()

	array = Array.new
	array.array = Array.new(10)
	array.lengthx = 0.0

	return array
end


def CreateArrayWithInitialCapacity(capacity)

	array = Array.new
	array.array = Array.new(capacity)
	array.lengthx = 0.0

	return array
end


def ArrayAdd(array, value)
	if array.lengthx == array.array.length
		ArrayIncreaseSize(array)
	end

	array.array[array.lengthx] = value
	array.lengthx = array.lengthx + 1.0
end


def ArrayAddString(array, value)

	data = CreateStringData(value)

	ArrayAdd(array, data)
end


def ArrayAddBoolean(array, value)

	data = CreateBooleanData(value)

	ArrayAdd(array, data)
end


def ArrayAddNumber(array, value)

	data = CreateNumberData(value)

	ArrayAdd(array, data)
end


def ArrayAddStruct(array, value)

	data = CreateStructData(value)

	ArrayAdd(array, data)
end


def ArrayAddArray(array, value)

	data = CreateArrayData(value)

	ArrayAdd(array, data)
end


def ArrayIncreaseSize(array)

	newLength = (array.array.length*3.0.to_f / 2.0).round
	newArray = Array.new(newLength)

	i = 0.0
	while(i < array.array.length)
		newArray[i] = array.array[i]
		i = i + 1.0
	end

	delete(array.array)

	array.array = newArray
end


def ArrayDecreaseSizeNecessary(array)

	needsDecrease = false

	if array.lengthx > 10.0
		needsDecrease = array.lengthx <= (array.array.length*2.0.to_f / 3.0).round
	end

	return needsDecrease
end


def ArrayDecreaseSize(array)

	newLength = (array.array.length*2.0.to_f / 3.0).round
	newArray = Array.new(newLength)

	i = 0.0
	while(i < newLength)
		newArray[i] = array.array[i]
		i = i + 1.0
	end

	delete(array.array)

	array.array = newArray
end


def ArrayIndex(array, index)
	return array.array[index]
end


def ArrayIndexArray(array, index)
	return array.array[index].array
end


def ArrayIndexStruct(array, index)
	return array.array[index].structure
end


def ArrayIndexBoolean(array, index)
	return array.array[index].booleanx
end


def ArrayIndexString(array, index)
	return array.array[index].string
end


def ArrayIndexNumber(array, index)
	return array.array[index].number
end


def ArrayLength(array)
	return array.lengthx
end


def ArrayInsert(array, index, value)

	if array.lengthx == array.array.length
		ArrayIncreaseSize(array)
	end

	i = array.lengthx
	while(i > index)
		array.array[i] = array.array[i - 1.0]
		i = i - 1.0
	end

	array.array[index] = value

	array.lengthx = array.lengthx + 1.0
end


def ArrayInsertString(array, index, value)

	data = CreateStringData(value)

	ArrayInsert(array, index, data)
end


def ArrayInsertBoolean(array, index, value)

	data = CreateBooleanData(value)

	ArrayInsert(array, index, data)
end


def ArrayInsertNumber(array, index, value)

	data = CreateNumberData(value)

	ArrayInsert(array, index, data)
end


def ArrayInsertStruct(array, index, value)

	data = CreateStructData(value)

	ArrayInsert(array, index, data)
end


def ArrayInsertArray(array, index, value)

	data = CreateArrayData(value)

	ArrayInsert(array, index, data)
end


def ArraySet(array, index, value)

	if index < array.lengthx
		array.array[index] = value
		success = true
	else
		success = false
	end

	return success
end


def ArraySetString(array, index, value)

	data = CreateStringData(value)

	ArraySet(array, index, data)
end


def ArraySetBoolean(array, index, value)

	data = CreateBooleanData(value)

	ArraySet(array, index, data)
end


def ArraySetNumber(array, index, value)

	data = CreateNumberData(value)

	ArraySet(array, index, data)
end


def ArraySetStruct(array, index, value)

	data = CreateStructData(value)

	ArraySet(array, index, data)
end


def ArraySetArray(array, index, value)

	data = CreateArrayData(value)

	ArraySet(array, index, data)
end


def ArrayRemove(array, index)

	i = index
	while(i < array.lengthx - 1.0)
		array.array[i] = array.array[i + 1.0]
		i = i + 1.0
	end

	array.lengthx = array.lengthx - 1.0

	if ArrayDecreaseSizeNecessary(array)
		ArrayDecreaseSize(array)
	end
end


def ToStaticArray(arc)

	array = Array.new(arc.lengthx)

	i = 0.0
	while(i < arc.lengthx)
		array[i] = arc.array[i]
		i = i + 1.0
	end

	return array
end


def ToStaticNumberArray(array)

	n = ArrayLength(array)

	result = Array.new(n)

	i = 0.0
	while(i < n)
		result[i] = ArrayIndex(array, i).number
		i = i + 1.0
	end

	return result
end


def ToStaticBooleanArray(array)

	n = ArrayLength(array)

	result = Array.new(n)

	i = 0.0
	while(i < n)
		result[i] = ArrayIndex(array, i).booleanx
		i = i + 1.0
	end

	return result
end


def ToStaticStringArray(array)

	n = ArrayLength(array)

	result = Array.new(n)

	i = 0.0
	while(i < n)
		result[i] = StringReference.new
		result[i].string = ArrayIndex(array, i).string
		i = i + 1.0
	end

	return result
end


def ToStaticArrayArray(array)

	n = ArrayLength(array)

	result = Array.new(n)

	i = 0.0
	while(i < n)
		result[i] = ArrayIndex(array, i).array
		i = i + 1.0
	end

	return result
end


def ToStaticStructArray(array)

	n = ArrayLength(array)

	result = Array.new(n)

	i = 0.0
	while(i < n)
		result[i] = ArrayIndex(array, i).structure
		i = i + 1.0
	end

	return result
end


def StaticArrayToArrayWithOptimalSize(src)

=begin

         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        
=end


	c = src.length
	n = (Math.log(c) - 1.0).to_f / Math.log(3.0.to_f / 2.0)

	newCapacity = (10.0*(3.0.to_f / 2.0)**(n).ceil).ceil

	dst = CreateArrayWithInitialCapacity(newCapacity)

	i = 0.0
	while(i < src.length)
		dst.array[i] = src[i]
		i = i + 1.0
	end

	return dst
end


def StaticArrayToArray(src)

	dst = CreateArrayWithInitialCapacity(src.length)
	i = 0.0
	while(i < src.length)
		dst.array[i] = src[i]
		i = i + 1.0
	end
	dst.lengthx = src.length

	return dst
end


def ArrayAddAll(backups, from)

	i = 0.0
	while(i < ArrayLength(from))
		data = ArrayIndex(from, i)
		AddDataToArray(backups, data)
		i = i + 1.0
	end
end


def SortStringArray(a)
	return SortStringArrayWithOptions(a, true)
end


def SortStringArrayDescending(a)
	return SortStringArrayWithOptions(a, false)
end


def SortStringArrayWithOptions(a, asc)

	len = ArrayLength(a)
	success = true
	i = 0.0
	while(i < len && success)
		if IsString(ArrayIndex(a, i))
		else
			success = false
		end
		i = i + 1.0
	end

	if success
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped)
			swapped = false
			j = 0.0
			while(j < len - i - 1.0)
				da = a.array[j]
				db = a.array[j + 1.0]

				cmp = StringOrder(da.string, db.string)
				if asc
					swap = cmp < 0.0
				else
					swap = cmp > 0.0
				end

				if swap
					tmp = da.string
					da.string = db.string
					db.string = tmp
					swapped = true
				end
				j = j + 1.0
			end
			i = i + 1.0
		end
	end

	return success
end


def StringOrder(a, b)

	minimum = [a.length, b.length].min

	done = false
	order = 0.0
	i = 0.0
	while(i < minimum && !done)
		ac = (a[i]).ord
		bc = (b[i]).ord

		if ac < bc
			done = true
			order = 1.0
		elsif ac > bc
			done = true
			order = -1.0
		end
		i = i + 1.0
	end

	if !done
		if a.length < b.length
			order = 1.0
		elsif a.length > b.length
			order = -1.0
		end
	end

	return order
end


def SortNumberArray(a)
	return SortNumberArrayWithOptions(a, true)
end


def SortNumberArrayDescending(a)
	return SortNumberArrayWithOptions(a, false)
end


def SortNumberArrayWithOptions(a, asc)

	len = ArrayLength(a)
	success = true
	i = 0.0
	while(i < len && success)
		if IsNumber(ArrayIndex(a, i))
		else
			success = false
		end
		i = i + 1.0
	end

	if success
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped)
			swapped = false
			j = 0.0
			while(j < len - i - 1.0)
				da = a.array[j]
				db = a.array[j + 1.0]

				if asc
					swap = da.number > db.number
				else
					swap = da.number < db.number
				end

				if swap
					tmp = da.number
					da.number = db.number
					db.number = tmp
					swapped = true
				end
				j = j + 1.0
			end
			i = i + 1.0
		end
	end

	return success
end


def SortStructArrayByNumberKey(a, key)
	return SortStructArrayByNumberKeyWithOptions(a, key, true)
end


def SortStructArrayByNumberKeyDescending(a, key)
	return SortStructArrayByNumberKeyWithOptions(a, key, false)
end


def SortStructArrayByNumberKeyWithOptions(a, key, asc)

	len = ArrayLength(a)
	success = true
	i = 0.0
	while(i < len && success)
		da = ArrayIndex(a, i)
		if IsStructure(da)
			if StructHasKey(da.structure, key)
				da = GetDataFromStruct(da.structure, key)
				if IsNumber(da)
				else
					success = false
				end
			else
				success = false
			end
		else
			success = false
		end
		i = i + 1.0
	end

	if success
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped)
			swapped = false
			j = 0.0
			while(j < len - i - 1.0)
				da = ArrayIndex(a, j)
				db = ArrayIndex(a, j + 1.0)

				na = GetNumberFromStruct(da.structure, key)
				nb = GetNumberFromStruct(db.structure, key)

				if asc
					swap = na > nb
				else
					swap = na < nb
				end

				if swap
					tmp = da.structure
					da.structure = db.structure
					db.structure = tmp
					swapped = true
				end
				j = j + 1.0
			end
			i = i + 1.0
		end
	end

	return success
end


def SortStructArrayByStringKey(a, key)
	return SortStructArrayByStringKeyWithOptions(a, key, true)
end


def SortStructArrayByStringKeyDescending(a, key)
	return SortStructArrayByStringKeyWithOptions(a, key, false)
end


def SortStructArrayByStringKeyWithOptions(a, key, asc)

	len = ArrayLength(a)
	success = true
	i = 0.0
	while(i < len && success)
		da = ArrayIndex(a, i)
		if IsStructure(da)
			if StructHasKey(da.structure, key)
				da = GetDataFromStruct(da.structure, key)
				if IsString(da)
				else
					success = false
				end
			else
				success = false
			end
		else
			success = false
		end
		i = i + 1.0
	end

	if success
		swapped = true
		i = 0.0
		while(i < len - 1.0 && swapped)
			swapped = false
			j = 0.0
			while(j < len - i - 1.0)
				da = ArrayIndex(a, j)
				db = ArrayIndex(a, j + 1.0)

				sa = GetStringFromStruct(da.structure, key)
				sb = GetStringFromStruct(db.structure, key)

				cmp = StringOrder(sa, sb)
				if asc
					swap = cmp < 0.0
				else
					swap = cmp > 0.0
				end
				if swap
					tmp = da.structure
					da.structure = db.structure
					db.structure = tmp
					swapped = true
				end
				j = j + 1.0
			end
			i = i + 1.0
		end
	end

	return success
end


def arraysStringToNumberArray(string)

	array = Array.new(string.length)

	i = 0.0
	while(i < string.length)
		array[i] = (string[i]).ord
		i = i + 1.0
	end
	return array
end


def arraysNumberArrayToString(array)

	string = Array.new(array.length)

	i = 0.0
	while(i < array.length)
		string[i] = (array[i]).truncate.chr('UTF-8')
		i = i + 1.0
	end
	return string
end


def arraysNumberArraysEqual(a, b)

	equal = true
	if a.length == b.length
		i = 0.0
		while(i < a.length && equal)
			if a[i] != b[i]
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def arraysBooleanArraysEqual(a, b)

	equal = true
	if a.length == b.length
		i = 0.0
		while(i < a.length && equal)
			if a[i] != b[i]
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def arraysStringsEqual(a, b)

	equal = true
	if a.length == b.length
		i = 0.0
		while(i < a.length && equal)
			if a[i] != b[i]
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def arraysFillNumberArray(a, value)

	i = 0.0
	while(i < a.length)
		a[i] = value
		i = i + 1.0
	end
end


def arraysFillString(a, value)

	i = 0.0
	while(i < a.length)
		a[i] = value
		i = i + 1.0
	end
end


def arraysFillBooleanArray(a, value)

	i = 0.0
	while(i < a.length)
		a[i] = value
		i = i + 1.0
	end
end


def arraysFillNumberArrayRange(a, value, from, to)

	if from >= 0.0 && from <= a.length && to >= 0.0 && to <= a.length && from <= to
		lengthx = to - from
		i = 0.0
		while(i < lengthx)
			a[from + i] = value
			i = i + 1.0
		end

		success = true
	else
		success = false
	end

	return success
end


def arraysFillBooleanArrayRange(a, value, from, to)

	if from >= 0.0 && from <= a.length && to >= 0.0 && to <= a.length && from <= to
		lengthx = to - from
		i = 0.0
		while(i < lengthx)
			a[from + i] = value
			i = i + 1.0
		end

		success = true
	else
		success = false
	end

	return success
end


def arraysFillStringRange(a, value, from, to)

	if from >= 0.0 && from <= a.length && to >= 0.0 && to <= a.length && from <= to
		lengthx = to - from
		i = 0.0
		while(i < lengthx)
			a[from + i] = value
			i = i + 1.0
		end

		success = true
	else
		success = false
	end

	return success
end


def arraysCopyNumberArray(a)

	n = Array.new(a.length)

	i = 0.0
	while(i < a.length)
		n[i] = a[i]
		i = i + 1.0
	end

	return n
end


def arraysCopyBooleanArray(a)

	n = Array.new(a.length)

	i = 0.0
	while(i < a.length)
		n[i] = a[i]
		i = i + 1.0
	end

	return n
end


def arraysCopyString(a)

	n = Array.new(a.length)

	i = 0.0
	while(i < a.length)
		n[i] = a[i]
		i = i + 1.0
	end

	return n
end


def arraysCopyNumberArrayRange(a, from, to, copyReference)

	if from >= 0.0 && from <= a.length && to >= 0.0 && to <= a.length && from <= to
		lengthx = to - from
		n = Array.new(lengthx)

		i = 0.0
		while(i < lengthx)
			n[i] = a[from + i]
			i = i + 1.0
		end

		copyReference.numberArray = n
		success = true
	else
		success = false
	end

	return success
end


def arraysCopyBooleanArrayRange(a, from, to, copyReference)

	if from >= 0.0 && from <= a.length && to >= 0.0 && to <= a.length && from <= to
		lengthx = to - from
		n = Array.new(lengthx)

		i = 0.0
		while(i < lengthx)
			n[i] = a[from + i]
			i = i + 1.0
		end

		copyReference.booleanArray = n
		success = true
	else
		success = false
	end

	return success
end


def arraysCopyStringRange(a, from, to, copyReference)

	if from >= 0.0 && from <= a.length && to >= 0.0 && to <= a.length && from <= to
		lengthx = to - from
		n = Array.new(lengthx)

		i = 0.0
		while(i < lengthx)
			n[i] = a[from + i]
			i = i + 1.0
		end

		copyReference.string = n
		success = true
	else
		success = false
	end

	return success
end


def arraysIsLastElement(lengthx, index)
	return index + 1.0 == lengthx
end


def arraysCreateNumberArray(lengthx, value)

	array = Array.new(lengthx)
	arraysFillNumberArray(array, value)

	return array
end


def arraysCreateBooleanArray(lengthx, value)

	array = Array.new(lengthx)
	arraysFillBooleanArray(array, value)

	return array
end


def arraysCreateString(lengthx, value)

	array = Array.new(lengthx)
	arraysFillString(array, value)

	return array
end


def arraysSwapElementsOfNumberArray(a, ai, bi)

	tmp = a[ai]
	a[ai] = a[bi]
	a[bi] = tmp
end


def arraysSwapElementsOfStringArray(a, ai, bi)

	tmp = a.stringArray[ai]
	a.stringArray[ai] = a.stringArray[bi]
	a.stringArray[bi] = tmp
end


def arraysReverseNumberArray(array)

	i = 0.0
	while(i < array.length.to_f / 2.0)
		arraysSwapElementsOfNumberArray(array, i, array.length - i - 1.0)
		i = i + 1.0
	end
end


def arraysNumberArrayContains(a, e)

	found = false

	i = 0.0
	while(i < a.length && !found)
		if arraysIndexNumber(a, i) == e
			found = true
		end
		i = i + 1.0
	end

	return found
end


def arraysIndexNumber(array, index)
	return array[index]
end


def arraysIndexChar(array, index)
	return array[index]
end


def arraysIndexBoolean(array, index)
	return array[index]
end


def arraysIndexString(array, index)
	return array[index].string
end


def arraysGetMinimum(data, minimumReference)

	if data.length >= 1.0
		minimum = data[0]
		i = 0.0
		while(i < data.length)
			minimum = [minimum, data[i]].min
			i = i + 1.0
		end
		minimumReference.numberValue = minimum
		success = true
	else
		success = false
	end

	return success
end


def arraysGetMaximum(data, maximumReference)

	if data.length >= 1.0
		maximum = data[0]
		i = 0.0
		while(i < data.length)
			maximum = [maximum, data[i]].max
			i = i + 1.0
		end
		maximumReference.numberValue = maximum
		success = true
	else
		success = false
	end

	return success
end


def arraysAssignNumberArray(as, bs)

	i = 0.0
	while(i < [as.length, bs.length].min)
		as[i] = bs[i]
		i = i + 1.0
	end
end


def arraysAssignBooleanArray(as, bs)

	i = 0.0
	while(i < [as.length, bs.length].min)
		as[i] = bs[i]
		i = i + 1.0
	end
end


def arraysAssignString(as, bs)

	i = 0.0
	while(i < [as.length, bs.length].min)
		as[i] = bs[i]
		i = i + 1.0
	end
end


def arraysRearrangeArray(as, indexes)

	bs = Array.new(as.length)

	arraysAssignNumberArray(bs, as)

	i = 0.0
	while(i < indexes.length)
		as[i] = bs[indexes[i]]
		i = i + 1.0
	end

	delete(bs)
end


def arraysSetNumberArrayRange(data, offset, str)

	i = 0.0
	while(i < str.length && offset + i < data.length)
		data[offset + i] = str[i]
		i = i + 1.0
	end
end


def arraysCopyNumberArrayValues(a, b)

	success = a.length == b.length

	if success
		i = 0.0
		while(i < a.length)
			a[i] = b[i]
			i = i + 1.0
		end
	end

	return success
end


def arraysCopyBooleanArrayValues(a, b)

	success = a.length == b.length

	if success
		i = 0.0
		while(i < a.length)
			a[i] = b[i]
			i = i + 1.0
		end
	end

	return success
end


def arraysCopyStringValues(a, b)

	success = a.length == b.length

	if success
		i = 0.0
		while(i < a.length)
			a[i] = b[i]
			i = i + 1.0
		end
	end

	return success
end


def CreateStringScientificNotationDecimalFromNumber(n)

	mantissaReference = StringReference.new
	exponentReference = StringReference.new
	result = Array.new(0)

	if n < 0.0
		isPositive = false
		n = -n
	else
		isPositive = true
	end

	if n == 0.0
		e = 0.0
	else
		e = GetFirstDecimalDigitPosition(n)

		if e < 0.0
			n = n*10.0**(e).abs
		else
			n = n.to_f / 10.0**e
		end
	end

	mantissaReference.string = CreateStringDecimalFromNumber(n)
	exponentReference.string = CreateStringDecimalFromNumber(e)

	if !isPositive
		result = strAppendString(result, "-".split(""))
	end

	result = strAppendString(result, mantissaReference.string)
	result = strAppendString(result, "e".split(""))
	result = strAppendString(result, exponentReference.string)

	return result
end


def CreateStringDecimalFromNumber(number)

	factorRef = NumberReference.new

	isPositive = true

	if number < 0.0
		isPositive = false
		number = (number).abs
	end

	if number == 0.0
		str = "0".split("")
	elsif number > 999999999999999e99
		# Guard the number against relaxations.
		if isPositive
			str = "Infinity".split("")
		else
			str = "-Infinity".split("")
		end
	else
		lessThan1 = number < 1.0

		# Guard the number against relaxations.
		if number < 1e-99
			number = 0.0
		end

		# 1. Turn number into an integer with 15 digits.
		number = NumberTo15DigitInteger(number, factorRef)
		factor = factorRef.numberValue
		delete(factorRef)

		# 2. Extract the 15 digits
		ds = Array.new(15)

		a = number
		zero = ("0").ord
		d = 0.0
		while(d < 15.0)
			x = a - (a.to_f / 10.0).floor*10.0
			ds[15.0 - d - 1.0] = ((x + zero)).truncate.chr('UTF-8')
			a = (a.to_f / 10.0).floor
			d = d + 1.0
		end

		# 3. Remove trailing zeros
		tz = 0.0
		done = false
		d = 0.0
		while(d < 15.0 && !done)
			if ds[15.0 - d - 1.0] == "0"
				tz = tz + 1.0
			else
				done = true
			end
			d = d + 1.0
		end
		ds = strSubstring(ds, 0.0, 15.0 - tz)

		# 4. Determine if integer
		isInt = factor + tz >= 0.0

		# 5. Fill into formats
		if isInt
			# |-----|
			# AAAAAAA00000000
			str = Array.new(15.0 + factor)
			d = 0.0
			while(d < str.length)
				str[d] = "0"
				d = d + 1.0
			end
			d = 0.0
			while(d < ds.length)
				str[d] = ds[d]
				d = d + 1.0
			end
		elsif lessThan1
			#       |-----|
			# 0.0000AAAAAAA
			extra = -factor - 15.0
			str = Array.new(2.0 + extra + 15.0 - tz)
			d = 0.0
			while(d < str.length)
				str[d] = "0"
				d = d + 1.0
			end
			str[1] = "."
			d = 0.0
			while(d < ds.length)
				str[2.0 + extra + d] = ds[d]
				d = d + 1.0
			end
		else
			# |-------|
			# AAAA.AAAA
			str = Array.new(1.0 + 15.0 - tz)
			dotpos = 15.0 + factor
			p = 0.0
			d = 0.0
			while(d < str.length)
				if d == dotpos
					str[d] = "."
				else
					str[d] = ds[p]
					p = p + 1.0
				end
				d = d + 1.0
			end
		end
	end

	# Done
	if !isPositive
		str = strConcatenateString("-".split(""), str)
	end

	return str
end


def CreateStringFromNumberWithCheck(number, base, stringRef)

	string = CreateDynamicArrayCharacters()
	isPositive = true

	if number < 0.0
		isPositive = false
		number = -number
	end

	if number == 0.0
		DynamicArrayAddCharacter(string, "0")
		success = true
	else
		characterReference = CharacterReference.new

		if IsInteger(base)
			success = true

			maximumDigits = GetMaximumDigitsForBase(base)

			digitPosition = GetFirstDigitPosition(number, base)

			hasPrintedPoint = false

			if !isPositive
				DynamicArrayAddCharacter(string, "-")
			end

			# Print leading zeros.
			if digitPosition < 0.0
				DynamicArrayAddCharacter(string, "0")
				DynamicArrayAddCharacter(string, ".")
				hasPrintedPoint = true
				i = 0.0
				while(i < -digitPosition - 1.0)
					DynamicArrayAddCharacter(string, "0")
					i = i + 1.0
				end
			end

			# Count trailing zeros
			trailingZeros = 0.0
			done = false
			i = 0.0
			while(i < maximumDigits && !done)
				d = GetDigit(number, base, maximumDigits - i - 1.0)
				if d == 0.0
					trailingZeros = trailingZeros + 1.0
				else
					done = true
				end
				i = i + 1.0
			end

			# Print number.
			i = 0.0
			while(i < maximumDigits && success)
				d = GetDigit(number, base, i)

				if d >= base
					d = base - 1.0
				end

				if !hasPrintedPoint && digitPosition - i + 1.0 == 0.0
					if maximumDigits - i > trailingZeros
						DynamicArrayAddCharacter(string, ".")
					end
					hasPrintedPoint = true
				end

				if maximumDigits - i <= trailingZeros && hasPrintedPoint
				else
					success = GetSingleDigitCharacterFromNumberWithCheck(d, base, characterReference)
					if success
						c = characterReference.characterValue
						DynamicArrayAddCharacter(string, c)
					end
				end
				i = i + 1.0
			end

			if success
				# Print trailing zeros.
				i = 0.0
				while(i < digitPosition - maximumDigits + 1.0)
					DynamicArrayAddCharacter(string, "0")
					i = i + 1.0
				end
			end
		else
			success = false
		end
	end

	if success
		stringRef.string = DynamicArrayCharactersToArray(string)
		FreeDynamicArrayCharacters(string)
	end

	# Done
	return success
end


def GetMaximumDigitsForBase(base)

	t = 10.0**15.0
	return (Math.log10(t).to_f / Math.log10(base)).floor
end


def GetMaximumDigitsForDecimal()
	return 15.0
end


def NumberTo15DigitInteger(n, factorRef)

	factors = GetPowersOfTenFor15d2e()
	dp = GetFirstDecimalDigitPosition(n)
	factorRef.numberValue = dp - 14.0

	i = 14.0 + -dp

	n = MultiplyWithIntegerPowerOf10(n, factors, i)

	delete(factors)

	n = Round(n)

	if n >= 1e15
		n = n.to_f / 10.0
		factorRef.numberValue = factorRef.numberValue + 1.0
	end

	return n
end


def MultiplyWithIntegerPowerOf10(n, factors, power)
	n = n*factors[power + 99.0]

	return n
end


def GetFirstDecimalDigitPosition(n)

	n = (n).abs

	factors = GetPowersOfTenFor15d2e()

	power = 1.0

	if n == 0.0
		power = 0.0
	elsif n > 999999999999999e99
		# This guards against relaxed variables' max value
		power = 114.0
	elsif n < 1e-99
		# This guards against relaxed variables' min value
		power = -100.0
	else
		found = false
		# Search the most likely space first.
		i = 99.0 - 20.0
		while(i < 99.0 + 20.0 && !found)
			if n >= factors[i] && n < factors[i + 1.0]
				power = i - 99.0
				found = true
			end
			i = i + 1.0
		end
		# Search the whole space
		i = 0.0
		while(i < factors.length - 1.0 && !found)
			if n >= factors[i] && n < factors[i + 1.0]
				power = i - 99.0
				found = true
			end
			i = i + 1.0
		end
		if !found
			if n >= 100000000000000e99 && n <= 999999999999999e99
				power = i - 99.0
			end
		end
	end

	delete(factors)

	# Normal returns are -99 to 113. If -100 or 114 is returned, it means a relaxation is used.
	return power
end


def GetPowersOfTenFor15d2e()

	factors = Array.new(213)

	factors[0] = 1e-99
	factors[1] = 1e-98
	factors[2] = 1e-97
	factors[3] = 1e-96
	factors[4] = 1e-95
	factors[5] = 1e-94
	factors[6] = 1e-93
	factors[7] = 1e-92
	factors[8] = 1e-91
	factors[9] = 1e-90
	factors[10] = 1e-89
	factors[11] = 1e-88
	factors[12] = 1e-87
	factors[13] = 1e-86
	factors[14] = 1e-85
	factors[15] = 1e-84
	factors[16] = 1e-83
	factors[17] = 1e-82
	factors[18] = 1e-81
	factors[19] = 1e-80
	factors[20] = 1e-79
	factors[21] = 1e-78
	factors[22] = 1e-77
	factors[23] = 1e-76
	factors[24] = 1e-75
	factors[25] = 1e-74
	factors[26] = 1e-73
	factors[27] = 1e-72
	factors[28] = 1e-71
	factors[29] = 1e-70
	factors[30] = 1e-69
	factors[31] = 1e-68
	factors[32] = 1e-67
	factors[33] = 1e-66
	factors[34] = 1e-65
	factors[35] = 1e-64
	factors[36] = 1e-63
	factors[37] = 1e-62
	factors[38] = 1e-61
	factors[39] = 1e-60
	factors[40] = 1e-59
	factors[41] = 1e-58
	factors[42] = 1e-57
	factors[43] = 1e-56
	factors[44] = 1e-55
	factors[45] = 1e-54
	factors[46] = 1e-53
	factors[47] = 1e-52
	factors[48] = 1e-51
	factors[49] = 1e-50
	factors[50] = 1e-49
	factors[51] = 1e-48
	factors[52] = 1e-47
	factors[53] = 1e-46
	factors[54] = 1e-45
	factors[55] = 1e-44
	factors[56] = 1e-43
	factors[57] = 1e-42
	factors[58] = 1e-41
	factors[59] = 1e-40
	factors[60] = 1e-39
	factors[61] = 1e-38
	factors[62] = 1e-37
	factors[63] = 1e-36
	factors[64] = 1e-35
	factors[65] = 1e-34
	factors[66] = 1e-33
	factors[67] = 1e-32
	factors[68] = 1e-31
	factors[69] = 1e-30
	factors[70] = 1e-29
	factors[71] = 1e-28
	factors[72] = 1e-27
	factors[73] = 1e-26
	factors[74] = 1e-25
	factors[75] = 1e-24
	factors[76] = 1e-23
	factors[77] = 1e-22
	factors[78] = 1e-21
	factors[79] = 1e-20
	factors[80] = 1e-19
	factors[81] = 1e-18
	factors[82] = 1e-17
	factors[83] = 1e-16
	factors[84] = 1e-15
	factors[85] = 1e-14
	factors[86] = 1e-13
	factors[87] = 1e-12
	factors[88] = 1e-11
	factors[89] = 1e-10
	factors[90] = 1e-9
	factors[91] = 1e-8
	factors[92] = 1e-7
	factors[93] = 1e-6
	factors[94] = 1e-5
	factors[95] = 1e-4
	factors[96] = 1e-3
	factors[97] = 1e-2
	factors[98] = 1e-1
	factors[99] = 1e0
	factors[100] = 1e1
	factors[101] = 1e2
	factors[102] = 1e3
	factors[103] = 1e4
	factors[104] = 1e5
	factors[105] = 1e6
	factors[106] = 1e7
	factors[107] = 1e8
	factors[108] = 1e9
	factors[109] = 1e10
	factors[110] = 1e11
	factors[111] = 1e12
	factors[112] = 1e13
	factors[113] = 1e14
	factors[114] = 1e15
	factors[115] = 1e16
	factors[116] = 1e17
	factors[117] = 1e18
	factors[118] = 1e19
	factors[119] = 1e20
	factors[120] = 1e21
	factors[121] = 1e22
	factors[122] = 1e23
	factors[123] = 1e24
	factors[124] = 1e25
	factors[125] = 1e26
	factors[126] = 1e27
	factors[127] = 1e28
	factors[128] = 1e29
	factors[129] = 1e30
	factors[130] = 1e31
	factors[131] = 1e32
	factors[132] = 1e33
	factors[133] = 1e34
	factors[134] = 1e35
	factors[135] = 1e36
	factors[136] = 1e37
	factors[137] = 1e38
	factors[138] = 1e39
	factors[139] = 1e40
	factors[140] = 1e41
	factors[141] = 1e42
	factors[142] = 1e43
	factors[143] = 1e44
	factors[144] = 1e45
	factors[145] = 1e46
	factors[146] = 1e47
	factors[147] = 1e48
	factors[148] = 1e49
	factors[149] = 1e50
	factors[150] = 1e51
	factors[151] = 1e52
	factors[152] = 1e53
	factors[153] = 1e54
	factors[154] = 1e55
	factors[155] = 1e56
	factors[156] = 1e57
	factors[157] = 1e58
	factors[158] = 1e59
	factors[159] = 1e60
	factors[160] = 1e61
	factors[161] = 1e62
	factors[162] = 1e63
	factors[163] = 1e64
	factors[164] = 1e65
	factors[165] = 1e66
	factors[166] = 1e67
	factors[167] = 1e68
	factors[168] = 1e69
	factors[169] = 1e70
	factors[170] = 1e71
	factors[171] = 1e72
	factors[172] = 1e73
	factors[173] = 1e74
	factors[174] = 1e75
	factors[175] = 1e76
	factors[176] = 1e77
	factors[177] = 1e78
	factors[178] = 1e79
	factors[179] = 1e80
	factors[180] = 1e81
	factors[181] = 1e82
	factors[182] = 1e83
	factors[183] = 1e84
	factors[184] = 1e85
	factors[185] = 1e86
	factors[186] = 1e87
	factors[187] = 1e88
	factors[188] = 1e89
	factors[189] = 1e90
	factors[190] = 1e91
	factors[191] = 1e92
	factors[192] = 1e93
	factors[193] = 1e94
	factors[194] = 1e95
	factors[195] = 1e96
	factors[196] = 1e97
	factors[197] = 1e98
	factors[198] = 1e99
	factors[199] = 10e99
	factors[200] = 100e99
	factors[201] = 1000e99
	factors[202] = 10000e99
	factors[203] = 100000e99
	factors[204] = 1000000e99
	factors[205] = 10000000e99
	factors[206] = 100000000e99
	factors[207] = 1000000000e99
	factors[208] = 10000000000e99
	factors[209] = 100000000000e99
	factors[210] = 1000000000000e99
	factors[211] = 10000000000000e99
	factors[212] = 100000000000000e99

	return factors
end


def GetFirstDigitPosition(n, base)

	maximumDigits = GetMaximumDigitsForBase(base)
	n = (n).abs

	if n != 0.0
		if (n).floor < base**maximumDigits
			multiply = true
		else
			multiply = false
		end

		done = false
		m = 0.0
		i = 0.0
		while(!done)
			if multiply
				m = n*base**i
				if (m).floor >= base**(maximumDigits - 1.0)
					done = true
				end
			else
				m = n.to_f / base**i
				if (m).floor < base**maximumDigits
					done = true
				end
			end
			i = i + 1.0
		end

		if multiply
			power = maximumDigits - i
		else
			power = maximumDigits + i - 2.0
		end

		if Round(m) >= base**maximumDigits
			power = power + 1.0
		end
	else
		power = 1.0
	end

	return power
end


def GetSingleDigitCharacterFromNumberWithCheck(c, base, characterReference)

	numberTable = GetDigitCharacterTable()

	if c < base || c < numberTable.length
		success = true
		characterReference.characterValue = numberTable[c]
	else
		success = false
	end

	return success
end


def GetDecimalDigitCharacterFromNumberWithCheck(c, characterRef)

	numberTable = "0123456789".split("")

	if c >= 0.0 && c < 10.0
		success = true
		characterRef.characterValue = numberTable[c]
	else
		success = false
	end

	return success
end


def GetDigitCharacterTable()

	numberTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".split("")

	return numberTable
end


def GetDecimalDigit(n, index)

	digitPosition = GetFirstDecimalDigitPosition(n)

	return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index)
end


def GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index)

	n = (n).abs

	factorRef = NumberReference.new
	n = NumberTo15DigitInteger(n, factorRef)
	delete(factorRef)

	m = n
	d = 0.0
	i = 0.0
	while(i < 15.0 - index)
		d = (m%10.0).round
		m = m - d
		m = (m.to_f / 10.0).round
		i = i + 1.0
	end

	return d
end


def GetDigit(n, base, index)

	n = (n).abs
	maximumDigits = GetMaximumDigitsForBase(base)
	digitPosition = GetFirstDigitPosition(n, base)

	e = maximumDigits - digitPosition - 1.0
	if e < 0.0
		n = (n.to_f / base**(e).abs).round
	else
		n = (n*base**e).round
	end

	m = n
	d = 0.0
	i = 0.0
	while(i < maximumDigits - index)
		d = (m%base).round
		m = m - d
		m = (m.to_f / base).round
		i = i + 1.0
	end

	return d
end


def NumberToHumanReadableShortScale(n)

	k = 1000.0
	m = k*1000.0
	b = m*1000.0
	t = b*1000.0
	q = t*1000.0
	suffix = " ".split("")

	if n < k
		hasSuffix = false
	else
		hasSuffix = true
	end

	if n >= k && n < m
		if n < 10.0*k
			n = Round(n.to_f / 100.0)
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / k)
		end
		suffix = "k".split("")
	elsif n >= m && n < b
		if n < 10.0*m
			n = Round(n.to_f / (k*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / m)
		end
		suffix = "M".split("")
	elsif n >= b && n < t
		if n < 10.0*b
			n = Round(n.to_f / (m*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / b)
		end
		suffix = "B".split("")
	elsif n >= t && n < q
		if n < 10.0*t
			n = Round(n.to_f / (b*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / t)
		end
		suffix = "T".split("")
	elsif n >= q
		if n < 10.0*q
			n = Round(n.to_f / (t*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / q)
		end
		suffix = "Q".split("")
	end

	res = CreateStringDecimalFromNumber(n)
	if hasSuffix
		res = strAppendString(res, suffix)
	end
        
	return res
end


def NumberToHumanReadableBinary(n)

	ki = 1024.0
	mi = ki*1024.0
	gi = mi*1024.0
	ti = gi*1024.0
	pi = ti*1024.0
	ei = pi*1024.0
	zi = ei*1024.0
	yi = zi*1024.0
	suffix = " ".split("")

	if n < ki
		hasSuffix = false
	else
		hasSuffix = true
	end

	if n >= ki && n < mi
		if n < 10.0*ki
			n = Round(n.to_f / (ki.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / ki)
		end
		suffix = "Ki".split("")
	elsif n >= mi && n < gi
		if n < 10.0*mi
			n = Round(n.to_f / (mi.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / mi)
		end
		suffix = "Mi".split("")
	elsif n >= gi && n < ti
		if n < 10.0*gi
			n = Round(n.to_f / (gi.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / gi)
		end
		suffix = "Gi".split("")
	elsif n >= ti && n < pi
		if n < 10.0*ti
			n = Round(n.to_f / (ti.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / ti)
		end
		suffix = "Ti".split("")
	elsif n >= pi && n < ei
		if n < 10.0*pi
			n = Round(n.to_f / (pi.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / pi)
		end
		suffix = "Pi".split("")
	elsif n >= ei && n < zi
		if n < 10.0*ei
			n = Round(n.to_f / (ei.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / ei)
		end
		suffix = "Ei".split("")
	elsif n >= zi && n < yi
		if n < 10.0*zi
			n = Round(n.to_f / (zi.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / zi)
		end
		suffix = "Zi".split("")
	elsif n >= yi
		if n < 10.0*yi
			n = Round(n.to_f / (yi.to_f / 10.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / yi)
		end
		suffix = "Yi".split("")
	end

	res = CreateStringDecimalFromNumber(n)
	if hasSuffix
		res = strAppendString(res, suffix)
	end

	return res
end


def NumberToHumanReadableMetric(n)

	k = 1000.0
	m = k*1000.0
	g = m*1000.0
	t = g*1000.0
	p = t*1000.0
	ex = p*1000.0
	z = ex*1000.0
	y = z*1000.0
	r = y*1000.0
	q = r*1000.0
	suffix = " ".split("")

	if n < k
		hasSuffix = false
	else
		hasSuffix = true
	end

	if n >= k && n < m
		if n < 10.0*k
			n = Round(n.to_f / 100.0)
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / k)
		end
		suffix = "k".split("")
	elsif n >= m && n < g
		if n < 10.0*m
			n = Round(n.to_f / (k*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / m)
		end
		suffix = "M".split("")
	elsif n >= g && n < t
		if n < 10.0*g
			n = Round(n.to_f / (m*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / g)
		end
		suffix = "G".split("")
	elsif n >= t && n < p
		if n < 10.0*t
			n = Round(n.to_f / (g*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / t)
		end
		suffix = "T".split("")
	elsif n >= p && n < ex
		if n < 10.0*p
			n = Round(n.to_f / (t*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / p)
		end
		suffix = "P".split("")
	elsif n >= ex && n < z
		if n < 10.0*ex
			n = Round(n.to_f / (p*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / ex)
		end
		suffix = "E".split("")
	elsif n >= z && n < y
		if n < 10.0*z
			n = Round(n.to_f / (ex*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / z)
		end
		suffix = "Z".split("")
	elsif n >= y && n < r
		if n < 10.0*y
			n = Round(n.to_f / (z*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / y)
		end
		suffix = "Y".split("")
	elsif n >= r && n < q
		if n < 10.0*r
			n = Round(n.to_f / (y*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / r)
		end
		suffix = "R".split("")
	elsif n >= q
		if n < 10.0*q
			n = Round(n.to_f / (r*100.0))
			n = n.to_f / 10.0
		else
			n = Round(n.to_f / q)
		end
		suffix = "Q".split("")
	end

	res = CreateStringDecimalFromNumber(n)
	if hasSuffix
		res = strAppendString(res, suffix)
	end

	return res
end


def IsValidNumber(str)

	numberRef = NumberReference.new
	message = StringReference.new

	valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

	delete(numberRef)
	delete(message)

	return valid
end


def IsValidInteger(str)

	numberRef = NumberReference.new
	message = StringReference.new

	valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

	if valid
		valid = IsInteger(numberRef.numberValue)
	end

	delete(numberRef)
	delete(message)

	return valid
end


def IsValidPositiveInteger(str)

	numberRef = NumberReference.new
	message = StringReference.new

	valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

	if valid
		valid = IsInteger(numberRef.numberValue)
		if valid
			valid = numberRef.numberValue >= 0.0
		end
	end

	delete(numberRef)
	delete(message)

	return valid
end


def CreateNumberFromDecimalStringWithCheck(string, decimalReference, message)
	return CreateDecimalNumberFromStringWithCheck(string, decimalReference, message)
end


def CreateNumberFromDecimalString(string)

	numberRef = CreateNumberReference(0.0)
	message = CreateStringReference("".split(""))
	CreateDecimalNumberFromStringWithCheck(string, numberRef, message)
	number = numberRef.numberValue

	delete(numberRef)
	delete(message)

	return number
end


def CreateNumberFromStringWithCheck(string, base, numberReference, message)

	numberIsPositive = CreateBooleanReference(true)
	exponentIsPositive = CreateBooleanReference(true)
	beforePoint = NumberArrayReference.new
	afterPoint = NumberArrayReference.new
	exponent = NumberArrayReference.new

	if base >= 2.0 && base <= 36.0
		success = ExtractPartsFromNumberString(string, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

		if success
			numberReference.numberValue = CreateNumberFromParts(base, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray)
		end
	else
		success = false
		message.string = "Base must be from 2 to 36.".split("")
	end

	return success
end


def CreateDecimalNumberFromStringWithCheck(string, numberReference, message)

	numberIsPositive = CreateBooleanReference(true)
	exponentIsPositive = CreateBooleanReference(true)
	beforePoint = NumberArrayReference.new
	afterPoint = NumberArrayReference.new
	exponent = NumberArrayReference.new

	success = ExtractPartsFromNumberString(string, 10.0, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

	if success
		numberReference.numberValue = CreateDecimalNumberFromParts(numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray)
	end

	delete(numberIsPositive)
	delete(exponentIsPositive)
	delete(beforePoint)
	delete(afterPoint)
	delete(exponent)

	return success
end


def CreateNumberFromParts(base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent)

	n = 0.0
	e = 0.0
	digits = 0.0
	digitsStarted = false
	integerOffset = 0.0
	maxDigits = (15.0*Math.log(10.0).to_f / Math.log(base)).floor
	roundingDigitSet = false
	roundingDigit = 0.0

	# We construct an integer n, inserting one and one digit and shifting left.
	# We read up to a certain amount of digits.
	i = 0.0
	while(i < beforePoint.length + afterPoint.length && digits < maxDigits + 1.0)
		if i < beforePoint.length
			d = beforePoint[i]
		else
			d = afterPoint[i - beforePoint.length]
		end

		if digits < maxDigits
			if d != 0.0
				digitsStarted = true
				integerOffset = beforePoint.length - i
			end

			n = n*base
			n = n + d

			integerOffset = integerOffset - 1.0
		else
			roundingDigitSet = true
			roundingDigit = d
		end

		if digitsStarted
			digits = digits + 1.0
		end
		i = i + 1.0
	end

	if roundingDigitSet
		if roundingDigit >= base.to_f / 2.0
			n = n + 1.0
		end
	end

	i = 0.0
	while(i < exponent.length)
		d = exponent[i]
		e = e*base
		e = e + d
		i = i + 1.0
	end

	if !exponentIsPositive
		e = -e
	end

	if !numberIsPositive
		n = -n
	end

	n = n*base**(e + integerOffset)

	return n
end


def CreateDecimalNumberFromParts(numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent)

	n = 0.0
	e = 0.0
	digits = 0.0
	digitsStarted = false
	integerOffset = 0.0
	maxDigits = 15.0
	roundingDigitSet = false
	roundingDigit = 0.0

	# We construct an integer n, inserting one and one digit and shifting left.
	# We read up to 15 digits, but we note a 16th digit to correctly round the result.
	i = 0.0
	while(i < beforePoint.length + afterPoint.length && digits < maxDigits + 1.0)
		if i < beforePoint.length
			d = beforePoint[i]
		else
			d = afterPoint[i - beforePoint.length]
		end

		if digits < maxDigits
			if d != 0.0
				digitsStarted = true
				integerOffset = beforePoint.length - i
			end

			n = n*10.0
			n = n + d

			integerOffset = integerOffset - 1.0
		else
			roundingDigitSet = true
			roundingDigit = d
		end

		if digitsStarted
			digits = digits + 1.0
		end
		i = i + 1.0
	end

	if roundingDigitSet
		if roundingDigit >= 5.0
			n = n + 1.0
		end
	end

	i = 0.0
	while(i < exponent.length)
		d = exponent[i]
		e = e*10.0
		e = e + d
		i = i + 1.0
	end

	if !exponentIsPositive
		e = -e
	end

	if !numberIsPositive
		n = -n
	end

	n = n*10.0**(e + integerOffset)

	return n
end


def ExtractPartsFromNumberString(n, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

	i = 0.0
	complete = false

	if i < n.length
		if n[i] == "-"
			numberIsPositive.booleanValue = false
			i = i + 1.0
		elsif n[i] == "+"
			numberIsPositive.booleanValue = true
			i = i + 1.0
		end

		success = true
	else
		success = false
		message.string = "Number cannot have length zero.".split("")
	end

	if success
		done = false
		count = 0.0
		while(i + count < n.length && !done)
			if CharacterIsNumberCharacterInBase(n[i + count], base)
				count = count + 1.0
			else
				done = true
			end
		end

		if count >= 1.0
			beforePoint.numberArray = Array.new(count)

			j = 0.0
			while(j < count)
				beforePoint.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base)
				j = j + 1.0
			end

			i = i + count

			if i < n.length
				success = true
			else
				afterPoint.numberArray = Array.new(0)
				exponent.numberArray = Array.new(0)
				success = true
				complete = true
			end
		else
			success = false
			message.string = "Number must have at least one number after the optional sign.".split("")
		end
	end

	if success && !complete
		if n[i] == "."
			i = i + 1.0

			if i < n.length
				done = false
				count = 0.0
				while(i + count < n.length && !done)
					if CharacterIsNumberCharacterInBase(n[i + count], base)
						count = count + 1.0
					else
						done = true
					end
				end

				if count >= 1.0
					afterPoint.numberArray = Array.new(count)

					j = 0.0
					while(j < count)
						afterPoint.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base)
						j = j + 1.0
					end

					i = i + count

					if i < n.length
						success = true
					else
						exponent.numberArray = Array.new(0)
						success = true
						complete = true
					end
				else
					success = false
					message.string = "There must be at least one digit after the decimal point.".split("")
				end
			else
				success = false
				message.string = "There must be at least one digit after the decimal point.".split("")
			end
		elsif base <= 14.0 && (n[i] == "e" || n[i] == "E")
			if i < n.length
				success = true
				afterPoint.numberArray = Array.new(0)
			else
				success = false
				message.string = "There must be at least one digit after the exponent.".split("")
			end
		else
			success = false
			message.string = "Expected decimal point or exponent symbol.".split("")
		end
	end

	if success && !complete
		if base <= 14.0 && (n[i] == "e" || n[i] == "E")
			i = i + 1.0

			if i < n.length
				if n[i] == "-"
					exponentIsPositive.booleanValue = false
					i = i + 1.0
				elsif n[i] == "+"
					exponentIsPositive.booleanValue = true
					i = i + 1.0
				end

				if i < n.length
					done = false
					count = 0.0
					while(i + count < n.length && !done)
						if CharacterIsNumberCharacterInBase(n[i + count], base)
							count = count + 1.0
						else
							done = true
						end
					end

					if count >= 1.0
						exponent.numberArray = Array.new(count)

						j = 0.0
						while(j < count)
							exponent.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base)
							j = j + 1.0
						end

						i = i + count

						if i == n.length
							success = true
						else
							success = false
							message.string = "There cannot be any characters past the exponent of the number.".split("")
						end
					else
						success = false
						message.string = "There must be at least one digit after the decimal point.".split("")
					end
				else
					success = false
					message.string = "There must be at least one digit after the exponent symbol.".split("")
				end
			else
				success = false
				message.string = "There must be at least one digit after the exponent symbol.".split("")
			end
		else
			success = false
			message.string = "Expected exponent symbol.".split("")
		end
	end

	return success
end


def GetNumberFromNumberCharacterForBase(c, base)

	numberTable = GetDigitCharacterTable()
	position = 0.0

	i = 0.0
	while(i < base)
		if numberTable[i] == c
			position = i
		end
		i = i + 1.0
	end

	return position
end


def CharacterIsNumberCharacterInBase(c, base)

	numberTable = GetDigitCharacterTable()
	found = false

	i = 0.0
	while(i < base)
		if numberTable[i] == c
			found = true
		end
		i = i + 1.0
	end

	return found
end


def StringToNumberArray(str)

	numberArrayReference = NumberArrayReference.new
	stringReference = StringReference.new

	StringToNumberArrayWithCheck(str, numberArrayReference, stringReference)

	numbers = numberArrayReference.numberArray

	delete(numberArrayReference)
	delete(stringReference)

	return numbers
end


def StringToNumberArrayWithCheck(str, numberArrayReference, errorMessage)

	numberStrings = strSplitByString(str, ",".split(""))

	numbers = Array.new(numberStrings.length)
	success = true
	numberReference = NumberReference.new

	i = 0.0
	while(i < numberStrings.length)
		numberString = numberStrings[i].string
		trimmedNumberString = strTrim(numberString)
		success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage)
		numbers[i] = numberReference.numberValue

		FreeStringReference(numberStrings[i])
		delete(trimmedNumberString)
		i = i + 1.0
	end

	delete(numberStrings)
	delete(numberReference)

	numberArrayReference.numberArray = numbers

	return success
end


def strWriteStringToStingStream(stream, index, src)

	i = 0.0
	while(i < src.length)
		stream[index.numberValue + i] = src[i]
		i = i + 1.0
	end
	index.numberValue = index.numberValue + src.length
end


def strWriteCharacterToStingStream(stream, index, src)
	stream[index.numberValue] = src
	index.numberValue = index.numberValue + 1.0
end


def strWriteBooleanToStingStream(stream, index, src)
	if src
		strWriteStringToStingStream(stream, index, "true".split(""))
	else
		strWriteStringToStingStream(stream, index, "false".split(""))
	end
end


def strSubstringWithCheck(string, from, to, stringReference)

	if from >= 0.0 && from <= string.length && to >= 0.0 && to <= string.length && from <= to
		stringReference.string = strSubstring(string, from, to)
		success = true
	else
		success = false
	end

	return success
end


def strSubstring(string, from, to)

	lengthx = to - from

	n = Array.new(lengthx)

	i = from
	while(i < to)
		n[i - from] = string[i]
		i = i + 1.0
	end

	return n
end


def strAppendString(s1, s2)

	newString = strConcatenateString(s1, s2)

	delete(s1)

	return newString
end


def strConcatenateString(s1, s2)

	newString = Array.new(s1.length + s2.length)

	i = 0.0
	while(i < s1.length)
		newString[i] = s1[i]
		i = i + 1.0
	end

	i = 0.0
	while(i < s2.length)
		newString[s1.length + i] = s2[i]
		i = i + 1.0
	end

	return newString
end


def strAppendCharacter(string, c)

	newString = strConcatenateCharacter(string, c)

	delete(string)

	return newString
end


def strConcatenateCharacter(string, c)
	newString = Array.new(string.length + 1.0)

	i = 0.0
	while(i < string.length)
		newString[i] = string[i]
		i = i + 1.0
	end

	newString[string.length] = c

	return newString
end


def strSplitByCharacter(toSplit, splitBy)

	ll = CreateLinkedListString()

	nextx = CreateLinkedListCharacter()
	i = 0.0
	while(i < toSplit.length)
		c = toSplit[i]

		if c == splitBy
			part = LinkedListCharactersToArray(nextx)
			LinkedListAddString(ll, part)
			FreeLinkedListCharacter(nextx)
			nextx = CreateLinkedListCharacter()
		else
			LinkedListAddCharacter(nextx, c)
		end
		i = i + 1.0
	end

	part = LinkedListCharactersToArray(nextx)
	LinkedListAddString(ll, part)
	FreeLinkedListCharacter(nextx)

	parts = LinkedListStringsToArray(ll)
	FreeLinkedListString(ll)

	return parts
end


def strIndexOfCharacter(string, character, indexReference)

	found = false
	i = 0.0
	while(i < string.length && !found)
		if string[i] == character
			found = true
			indexReference.numberValue = i
		end
		i = i + 1.0
	end

	return found
end


def strLastIndexOfCharacter(string, character, indexReference)

	found = false
	i = 0.0
	while(i < string.length)
		if string[i] == character
			found = true
			indexReference.numberValue = i
		end
		i = i + 1.0
	end

	return found
end


def strSubstringEqualsWithCheck(string, from, substring, equalsReference)

	if from < string.length
		success = true
		equalsReference.booleanValue = strSubstringEquals(string, from, substring)
	else
		success = false
	end

	return success
end


def strSubstringEquals(string, from, substring)

	equal = true
	if string.length - from >= substring.length
		i = 0.0
		while(i < substring.length && equal)
			if string[from + i] != substring[i]
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def strIndexOfString(string, substring, indexReference)

	found = false
	i = 0.0
	while(i < string.length - substring.length + 1.0 && !found)
		if strSubstringEquals(string, i, substring)
			found = true
			indexReference.numberValue = i
		end
		i = i + 1.0
	end

	return found
end


def strContainsCharacter(string, character)

	found = false
	i = 0.0
	while(i < string.length && !found)
		if string[i] == character
			found = true
		end
		i = i + 1.0
	end

	return found
end


def strContainsString(string, substring)
	return strIndexOfString(string, substring, NumberReference.new)
end


def strToUpperCase(string)

	i = 0.0
	while(i < string.length)
		string[i] = cToUpperCase(string[i])
		i = i + 1.0
	end
end


def strToLowerCase(string)

	i = 0.0
	while(i < string.length)
		string[i] = cToLowerCase(string[i])
		i = i + 1.0
	end
end


def strEqualsIgnoreCase(a, b)

	if a.length == b.length
		equal = true
		i = 0.0
		while(i < a.length && equal)
			if cToLowerCase(a[i]) != cToLowerCase(b[i])
				equal = false
			end
			i = i + 1.0
		end
	else
		equal = false
	end

	return equal
end


def strReplaceString(string, toReplace, replaceWith)

	da = CreateDynamicArrayCharacters()

	equalsReference = BooleanReference.new

	i = 0.0
	while(i < string.length)
		success = strSubstringEqualsWithCheck(string, i, toReplace, equalsReference)
		if success
			success = equalsReference.booleanValue
		end

		if success && toReplace.length > 0.0
			j = 0.0
			while(j < replaceWith.length)
				DynamicArrayAddCharacter(da, replaceWith[j])
				j = j + 1.0
			end
			i = i + toReplace.length
		else
			DynamicArrayAddCharacter(da, string[i])
			i = i + 1.0
		end
	end

	result = DynamicArrayCharactersToArray(da)

	FreeDynamicArrayCharacters(da)

	return result
end


def strReplaceCharacterToNew(string, toReplace, replaceWith)

	result = Array.new(string.length)

	i = 0.0
	while(i < string.length)
		if string[i] == toReplace
			result[i] = replaceWith
		else
			result[i] = string[i]
		end
		i = i + 1.0
	end

	return result
end


def strReplaceCharacter(string, toReplace, replaceWith)

	i = 0.0
	while(i < string.length)
		if string[i] == toReplace
			string[i] = replaceWith
		end
		i = i + 1.0
	end
end


def strTrim(string)

	# Find whitepaces at the start.
	lastWhitespaceLocationStart = -1.0
	firstNonWhitespaceFound = false
	i = 0.0
	while(i < string.length && !firstNonWhitespaceFound)
		if cIsWhiteSpace(string[i])
			lastWhitespaceLocationStart = i
		else
			firstNonWhitespaceFound = true
		end
		i = i + 1.0
	end

	# Find whitepaces at the end.
	lastWhitespaceLocationEnd = string.length
	firstNonWhitespaceFound = false
	i = string.length - 1.0
	while(i >= 0.0 && !firstNonWhitespaceFound)
		if cIsWhiteSpace(string[i])
			lastWhitespaceLocationEnd = i
		else
			firstNonWhitespaceFound = true
		end
		i = i - 1.0
	end

	if lastWhitespaceLocationStart < lastWhitespaceLocationEnd
		result = strSubstring(string, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd)
	else
		result = Array.new(0)
	end

	return result
end


def strStartsWith(string, start)

	startsWithString = false
	if string.length >= start.length
		startsWithString = strSubstringEquals(string, 0.0, start)
	end

	return startsWithString
end


def strEndsWith(string, endx)

	endsWithString = false
	if string.length >= endx.length
		endsWithString = strSubstringEquals(string, string.length - endx.length, endx)
	end

	return endsWithString
end


def strSplitByWhitespace(toSplit)

	ll = CreateLinkedListString()

	nextx = CreateLinkedListCharacter()
	i = 0.0
	while(i < toSplit.length)
		c = toSplit[i]

		split = false
		skip = 0.0
		while((c == " " || c == "\n" || c == "\t") && i + skip <= toSplit.length)
			if i + skip != toSplit.length
				c = toSplit[i + skip]
			end
			skip = skip + 1.0
			split = true
		end

		if split
			part = LinkedListCharactersToArray(nextx)
			LinkedListAddString(ll, part)
			FreeLinkedListCharacter(nextx)
			nextx = CreateLinkedListCharacter()
			i = i + skip - 1.0
		else
			LinkedListAddCharacter(nextx, c)
			i = i + 1.0
		end
	end

	part = LinkedListCharactersToArray(nextx)
	LinkedListAddString(ll, part)
	FreeLinkedListCharacter(nextx)

	parts = LinkedListStringsToArray(ll)
	FreeLinkedListString(ll)

	return parts
end


def strSplitByString(toSplit, splitBy)

	ll = CreateLinkedListString()

	nextx = CreateLinkedListCharacter()
	i = 0.0
	while(i < toSplit.length)
		c = toSplit[i]

		if strSubstringEquals(toSplit, i, splitBy)
			part = LinkedListCharactersToArray(nextx)
			LinkedListAddString(ll, part)
			FreeLinkedListCharacter(nextx)
			nextx = CreateLinkedListCharacter()
			i = i + splitBy.length
		else
			LinkedListAddCharacter(nextx, c)
			i = i + 1.0
		end
	end

	part = LinkedListCharactersToArray(nextx)
	LinkedListAddString(ll, part)
	FreeLinkedListCharacter(nextx)

	parts = LinkedListStringsToArray(ll)
	FreeLinkedListString(ll)

	return parts
end


def strStringIsBefore(a, b)

	before = false
	equal = true
	done = false

	if a.length == 0.0 && b.length > 0.0
		before = true
	else
		i = 0.0
		while(i < a.length && i < b.length && !done)
			if a[i] != b[i]
				equal = false
			end
			if cCharacterIsBefore(a[i], b[i])
				before = true
			end
			if cCharacterIsBefore(b[i], a[i])
				done = true
			end
			i = i + 1.0
		end

		if equal
			if a.length < b.length
				before = true
			end
		end
	end

	return before
end


def strJoinStringsWithSeparator(strings, separator)

	index = CreateNumberReference(0.0)

	lengthx = 0.0
	i = 0.0
	while(i < strings.length)
		lengthx = lengthx + strings[i].string.length
		i = i + 1.0
	end
	lengthx = lengthx + (strings.length - 1.0)*separator.length

	result = Array.new(lengthx)

	i = 0.0
	while(i < strings.length)
		string = strings[i].string
		strWriteStringToStingStream(result, index, string)
		if i + 1.0 < strings.length
			strWriteStringToStingStream(result, index, separator)
		end
		i = i + 1.0
	end

	delete(index)

	return result
end


def strJoinStrings(strings)

	index = CreateNumberReference(0.0)

	lengthx = 0.0
	i = 0.0
	while(i < strings.length)
		lengthx = lengthx + strings[i].string.length
		i = i + 1.0
	end

	result = Array.new(lengthx)

	i = 0.0
	while(i < strings.length)
		string = strings[i].string
		strWriteStringToStingStream(result, index, string)
		i = i + 1.0
	end

	delete(index)

	return result
end


def strStringOrder(a, b)

	minimum = [a.length, b.length].min

	done = false
	order = 0.0
	i = 0.0
	while(i < minimum && !done)
		ac = (a[i]).ord
		bc = (b[i]).ord

		if ac < bc
			done = true
			order = 1.0
		elsif ac > bc
			done = true
			order = -1.0
		end
		i = i + 1.0
	end

	if !done
		if a.length < b.length
			order = 1.0
		elsif a.length > b.length
			order = -1.0
		end
	end

	return order
end


def strLeftPad(str, width)

	padded = Array.new(width)
	arraysFillString(padded, " ")

	i = 0.0
	while(i < str.length)
		padded[width - str.length + i] = str[i]
		i = i + 1.0
	end

	return padded
end


def strRightPad(str, width)

	padded = Array.new(width)
	arraysFillString(padded, " ")

	i = 0.0
	while(i < str.length)
		padded[i] = str[i]
		i = i + 1.0
	end

	return padded
end


def cToLowerCase(character)

	toReturn = character
	if character == "A"
		toReturn = "a"
	elsif character == "B"
		toReturn = "b"
	elsif character == "C"
		toReturn = "c"
	elsif character == "D"
		toReturn = "d"
	elsif character == "E"
		toReturn = "e"
	elsif character == "F"
		toReturn = "f"
	elsif character == "G"
		toReturn = "g"
	elsif character == "H"
		toReturn = "h"
	elsif character == "I"
		toReturn = "i"
	elsif character == "J"
		toReturn = "j"
	elsif character == "K"
		toReturn = "k"
	elsif character == "L"
		toReturn = "l"
	elsif character == "M"
		toReturn = "m"
	elsif character == "N"
		toReturn = "n"
	elsif character == "O"
		toReturn = "o"
	elsif character == "P"
		toReturn = "p"
	elsif character == "Q"
		toReturn = "q"
	elsif character == "R"
		toReturn = "r"
	elsif character == "S"
		toReturn = "s"
	elsif character == "T"
		toReturn = "t"
	elsif character == "U"
		toReturn = "u"
	elsif character == "V"
		toReturn = "v"
	elsif character == "W"
		toReturn = "w"
	elsif character == "X"
		toReturn = "x"
	elsif character == "Y"
		toReturn = "y"
	elsif character == "Z"
		toReturn = "z"
	end

	return toReturn
end


def cToUpperCase(character)

	toReturn = character
	if character == "a"
		toReturn = "A"
	elsif character == "b"
		toReturn = "B"
	elsif character == "c"
		toReturn = "C"
	elsif character == "d"
		toReturn = "D"
	elsif character == "e"
		toReturn = "E"
	elsif character == "f"
		toReturn = "F"
	elsif character == "g"
		toReturn = "G"
	elsif character == "h"
		toReturn = "H"
	elsif character == "i"
		toReturn = "I"
	elsif character == "j"
		toReturn = "J"
	elsif character == "k"
		toReturn = "K"
	elsif character == "l"
		toReturn = "L"
	elsif character == "m"
		toReturn = "M"
	elsif character == "n"
		toReturn = "N"
	elsif character == "o"
		toReturn = "O"
	elsif character == "p"
		toReturn = "P"
	elsif character == "q"
		toReturn = "Q"
	elsif character == "r"
		toReturn = "R"
	elsif character == "s"
		toReturn = "S"
	elsif character == "t"
		toReturn = "T"
	elsif character == "u"
		toReturn = "U"
	elsif character == "v"
		toReturn = "V"
	elsif character == "w"
		toReturn = "W"
	elsif character == "x"
		toReturn = "X"
	elsif character == "y"
		toReturn = "Y"
	elsif character == "z"
		toReturn = "Z"
	end

	return toReturn
end


def cIsUpperCase(character)

	isUpper = true
	if character == "A"
	elsif character == "B"
	elsif character == "C"
	elsif character == "D"
	elsif character == "E"
	elsif character == "F"
	elsif character == "G"
	elsif character == "H"
	elsif character == "I"
	elsif character == "J"
	elsif character == "K"
	elsif character == "L"
	elsif character == "M"
	elsif character == "N"
	elsif character == "O"
	elsif character == "P"
	elsif character == "Q"
	elsif character == "R"
	elsif character == "S"
	elsif character == "T"
	elsif character == "U"
	elsif character == "V"
	elsif character == "W"
	elsif character == "X"
	elsif character == "Y"
	elsif character == "Z"
	else
		isUpper = false
	end

	return isUpper
end


def cIsLowerCase(character)

	isLower = true
	if character == "a"
	elsif character == "b"
	elsif character == "c"
	elsif character == "d"
	elsif character == "e"
	elsif character == "f"
	elsif character == "g"
	elsif character == "h"
	elsif character == "i"
	elsif character == "j"
	elsif character == "k"
	elsif character == "l"
	elsif character == "m"
	elsif character == "n"
	elsif character == "o"
	elsif character == "p"
	elsif character == "q"
	elsif character == "r"
	elsif character == "s"
	elsif character == "t"
	elsif character == "u"
	elsif character == "v"
	elsif character == "w"
	elsif character == "x"
	elsif character == "y"
	elsif character == "z"
	else
		isLower = false
	end

	return isLower
end


def cIsLetter(character)
	return cIsUpperCase(character) || cIsLowerCase(character)
end


def cIsNumber(character)

	isNumberx = true
	if character == "0"
	elsif character == "1"
	elsif character == "2"
	elsif character == "3"
	elsif character == "4"
	elsif character == "5"
	elsif character == "6"
	elsif character == "7"
	elsif character == "8"
	elsif character == "9"
	else
		isNumberx = false
	end

	return isNumberx
end


def cIsWhiteSpace(character)

	isWhiteSpacex = true
	if character == " "
	elsif character == "\t"
	elsif character == "\n"
	elsif character == "\r"
	else
		isWhiteSpacex = false
	end

	return isWhiteSpacex
end


def cIsSymbol(character)

	isSymbolx = true
	if character == "!"
	elsif character == "\""
	elsif character == "#"
	elsif character == "$"
	elsif character == "%"
	elsif character == "&"
	elsif character == "\'"
	elsif character == "("
	elsif character == ")"
	elsif character == "*"
	elsif character == "+"
	elsif character == ","
	elsif character == "-"
	elsif character == "."
	elsif character == "/"
	elsif character == ":"
	elsif character == ";"
	elsif character == "<"
	elsif character == "="
	elsif character == ">"
	elsif character == "?"
	elsif character == "@"
	elsif character == "["
	elsif character == "\\"
	elsif character == "]"
	elsif character == "^"
	elsif character == "_"
	elsif character == "`"
	elsif character == "{"
	elsif character == "|"
	elsif character == "}"
	elsif character == "~"
	else
		isSymbolx = false
	end

	return isSymbolx
end


def cCharacterIsBefore(a, b)

	ad = (a).ord
	bd = (b).ord

	return ad < bd
end


def cDecimalDigitToCharacter(digit)

	if digit == 1.0
		c = "1"
	elsif digit == 2.0
		c = "2"
	elsif digit == 3.0
		c = "3"
	elsif digit == 4.0
		c = "4"
	elsif digit == 5.0
		c = "5"
	elsif digit == 6.0
		c = "6"
	elsif digit == 7.0
		c = "7"
	elsif digit == 8.0
		c = "8"
	elsif digit == 9.0
		c = "9"
	else
		c = "0"
	end

	return c
end


def cCharacterToDecimalDigit(c)

	if c == "1"
		digit = 1.0
	elsif c == "2"
		digit = 2.0
	elsif c == "3"
		digit = 3.0
	elsif c == "4"
		digit = 4.0
	elsif c == "5"
		digit = 5.0
	elsif c == "6"
		digit = 6.0
	elsif c == "7"
		digit = 7.0
	elsif c == "8"
		digit = 8.0
	elsif c == "9"
		digit = 9.0
	else
		digit = 0.0
	end

	return digit
end


def cHexadecimalDigitToCharacter(digit)

	if digit == 1.0
		c = "1"
	elsif digit == 2.0
		c = "2"
	elsif digit == 3.0
		c = "3"
	elsif digit == 4.0
		c = "4"
	elsif digit == 5.0
		c = "5"
	elsif digit == 6.0
		c = "6"
	elsif digit == 7.0
		c = "7"
	elsif digit == 8.0
		c = "8"
	elsif digit == 9.0
		c = "9"
	elsif digit == 10.0
		c = "A"
	elsif digit == 11.0
		c = "B"
	elsif digit == 12.0
		c = "C"
	elsif digit == 13.0
		c = "D"
	elsif digit == 14.0
		c = "E"
	elsif digit == 15.0
		c = "F"
	else
		c = "0"
	end

	return c
end


def cCharacterToHexadecimalDigit(c)

	if c == "1"
		digit = 1.0
	elsif c == "2"
		digit = 2.0
	elsif c == "3"
		digit = 3.0
	elsif c == "4"
		digit = 4.0
	elsif c == "5"
		digit = 5.0
	elsif c == "6"
		digit = 6.0
	elsif c == "7"
		digit = 7.0
	elsif c == "8"
		digit = 8.0
	elsif c == "9"
		digit = 9.0
	elsif c == "A"
		digit = 10.0
	elsif c == "B"
		digit = 11.0
	elsif c == "C"
		digit = 12.0
	elsif c == "D"
		digit = 13.0
	elsif c == "E"
		digit = 14.0
	elsif c == "F"
		digit = 15.0
	else
		digit = 0.0
	end

	return digit
end


def GetBlack()
	black = RGBA.new
	black.a = 1.0
	black.r = 0.0
	black.g = 0.0
	black.b = 0.0
	return black
end


def GetWhite()
	white = RGBA.new
	white.a = 1.0
	white.r = 1.0
	white.g = 1.0
	white.b = 1.0
	return white
end


def GetTransparent()
	transparent = RGBA.new
	transparent.a = 0.0
	transparent.r = 0.0
	transparent.g = 0.0
	transparent.b = 0.0
	return transparent
end


def GetGray(percentage)
	black = RGBA.new
	black.a = 1.0
	black.r = 1.0 - percentage
	black.g = 1.0 - percentage
	black.b = 1.0 - percentage
	return black
end


def CreateRGBColor(r, g, b)
	color = RGBA.new
	color.a = 1.0
	color.r = r
	color.g = g
	color.b = b
	return color
end


def CreateRGBAColor(r, g, b, a)
	color = RGBA.new
	color.a = a
	color.r = r
	color.g = g
	color.b = b
	return color
end


def CreateImage(w, h, color)

	image = RGBABitmapImage.new
	image.x = Array.new(w)
	i = 0.0
	while(i < w)
		image.x[i] = RGBABitmap.new
		image.x[i].y = Array.new(h)
		j = 0.0
		while(j < h)
			image.x[i].y[j] = RGBA.new
			SetPixel(image, i, j, color)
			j = j + 1.0
		end
		i = i + 1.0
	end

	return image
end


def DeleteImage(image)

	w = ImageWidth(image)
	h = ImageHeight(image)

	i = 0.0
	while(i < w)
		j = 0.0
		while(j < h)
			delete(image.x[i].y[j])
			j = j + 1.0
		end
		delete(image.x[i])
		i = i + 1.0
	end
	delete(image)
end


def ImageWidth(image)
	return image.x.length
end


def ImageHeight(image)

	if ImageWidth(image) == 0.0
		height = 0.0
	else
		height = image.x[0].y.length
	end

	return height
end


def SetPixel(image, x, y, color)
	if x >= 0.0 && x < ImageWidth(image) && y >= 0.0 && y < ImageHeight(image)
		image.x[x].y[y].a = color.a
		image.x[x].y[y].r = color.r
		image.x[x].y[y].g = color.g
		image.x[x].y[y].b = color.b
	end
end


def DrawPixel(image, x, y, color)

	if x >= 0.0 && x < ImageWidth(image) && y >= 0.0 && y < ImageHeight(image)
		ra = color.r
		ga = color.g
		ba = color.b
		aa = color.a

		c = GetImagePixel(image, x, y)
		rb = c.r
		gb = c.g
		bb = c.b
		ab = c.a

		ao = CombineAlpha(aa, ab)

		ro = AlphaBlend(ra, aa, rb, ab, ao)
		go = AlphaBlend(ga, aa, gb, ab, ao)
		bo = AlphaBlend(ba, aa, bb, ab, ao)

		image.x[x].y[y].r = ro
		image.x[x].y[y].g = go
		image.x[x].y[y].b = bo
		image.x[x].y[y].a = ao
	end
end


def CombineAlpha(as, ad)
	return as + ad*(1.0 - as)
end


def AlphaBlend(cs, as, cd, ad, ao)
	return (cs*as + cd*ad*(1.0 - as)).to_f / ao
end


def DrawHorizontalLine1px(image, x, y, lengthx, color)

	i = 0.0
	while(i < lengthx)
		DrawPixel(image, x + i, y, color)
		i = i + 1.0
	end
end


def DrawVerticalLine1px(image, x, y, height, color)

	i = 0.0
	while(i < height)
		DrawPixel(image, x, y + i, color)
		i = i + 1.0
	end
end


def DrawRectangle1px(image, x, y, width, height, color)
	DrawHorizontalLine1px(image, x, y, width + 1.0, color)
	DrawVerticalLine1px(image, x, y + 1.0, height + 1.0 - 1.0, color)
	DrawVerticalLine1px(image, x + width, y + 1.0, height + 1.0 - 1.0, color)
	DrawHorizontalLine1px(image, x + 1.0, y + height, width + 1.0 - 2.0, color)
end


def DrawImageOnImage(dst, src, topx, topy)

	y = 0.0
	while(y < ImageHeight(src))
		x = 0.0
		while(x < ImageWidth(src))
			if topx + x >= 0.0 && topx + x < ImageWidth(dst) && topy + y >= 0.0 && topy + y < ImageHeight(dst)
				DrawPixel(dst, topx + x, topy + y, GetImagePixel(src, x, y))
			end
			x = x + 1.0
		end
		y = y + 1.0
	end
end


def DrawLine1px(image, x0, y0, x1, y1, color)
	XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color)
end


def XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color)

	olda = color.a

	steep = (y1 - y0).abs > (x1 - x0).abs

	if steep
		t = x0
		x0 = y0
		y0 = t

		t = x1
		x1 = y1
		y1 = t
	end
	if x0 > x1
		t = x0
		x0 = x1
		x1 = t

		t = y0
		y0 = y1
		y1 = t
	end

	dx = x1 - x0
	dy = y1 - y0
	g = dy.to_f / dx

	if dx == 0.0
		g = 1.0
	end

	xEnd = Round(x0)
	yEnd = y0 + g*(xEnd - x0)
	xGap = OneMinusFractionalPart(x0 + 0.5)
	xpxl1 = xEnd
	ypxl1 = (yEnd).floor
	if steep
		DrawPixel(image, ypxl1, xpxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
		DrawPixel(image, ypxl1 + 1.0, xpxl1, SetBrightness(color, FractionalPart(yEnd)*xGap))
	else
		DrawPixel(image, xpxl1, ypxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
		DrawPixel(image, xpxl1, ypxl1 + 1.0, SetBrightness(color, FractionalPart(yEnd)*xGap))
	end
	intery = yEnd + g

	xEnd = Round(x1)
	yEnd = y1 + g*(xEnd - x1)
	xGap = FractionalPart(x1 + 0.5)
	xpxl2 = xEnd
	ypxl2 = (yEnd).floor
	if steep
		DrawPixel(image, ypxl2, xpxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
		DrawPixel(image, ypxl2 + 1.0, xpxl2, SetBrightness(color, FractionalPart(yEnd)*xGap))
	else
		DrawPixel(image, xpxl2, ypxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
		DrawPixel(image, xpxl2, ypxl2 + 1.0, SetBrightness(color, FractionalPart(yEnd)*xGap))
	end

	if steep
		x = xpxl1 + 1.0
		while(x <= xpxl2 - 1.0)
			DrawPixel(image, (intery).floor, x, SetBrightness(color, OneMinusFractionalPart(intery)))
			DrawPixel(image, (intery).floor + 1.0, x, SetBrightness(color, FractionalPart(intery)))
			intery = intery + g
			x = x + 1.0
		end
	else
		x = xpxl1 + 1.0
		while(x <= xpxl2 - 1.0)
			DrawPixel(image, x, (intery).floor, SetBrightness(color, OneMinusFractionalPart(intery)))
			DrawPixel(image, x, (intery).floor + 1.0, SetBrightness(color, FractionalPart(intery)))
			intery = intery + g
			x = x + 1.0
		end
	end

	color.a = olda
end


def OneMinusFractionalPart(x)
	return 1.0 - FractionalPart(x)
end


def FractionalPart(x)
	return x - (x).floor
end


def SetBrightness(color, newBrightness)
	color.a = newBrightness
	return color
end


def DrawQuadraticBezierCurve(image, x0, y0, cx, cy, x1, y1, color)

	dx = (x0 - x1).abs
	dy = (y0 - y1).abs

	dt = 1.0.to_f / Math.sqrt(dx**2.0 + dy**2.0)

	xs = NumberReference.new
	ys = NumberReference.new
	xe = NumberReference.new
	ye = NumberReference.new

	QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, 0.0, xs, ys)
	t = dt
	while(t <= 1.0)
		QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, xe, ye)
		DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color)
		xs.numberValue = xe.numberValue
		ys.numberValue = ye.numberValue
		t = t + dt
	end

	delete(xs)
	delete(ys)
	delete(xe)
	delete(ye)
end


def QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, x, y)
	x.numberValue = (1.0 - t)**2.0*x0 + (1.0 - t)*2.0*t*cx + t**2.0*x1
	y.numberValue = (1.0 - t)**2.0*y0 + (1.0 - t)*2.0*t*cy + t**2.0*y1
end


def DrawCubicBezierCurve(image, x0, y0, c0x, c0y, c1x, c1y, x1, y1, color)

	dx = (x0 - x1).abs
	dy = (y0 - y1).abs

	dt = 1.0.to_f / Math.sqrt(dx**2.0 + dy**2.0)

	xs = NumberReference.new
	ys = NumberReference.new
	xe = NumberReference.new
	ye = NumberReference.new

	CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, 0.0, xs, ys)
	t = dt
	while(t <= 1.0)
		CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, xe, ye)
		DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color)
		xs.numberValue = xe.numberValue
		ys.numberValue = ye.numberValue
		t = t + dt
	end

	delete(xs)
	delete(ys)
	delete(xe)
	delete(ye)
end


def CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, x, y)
	x.numberValue = (1.0 - t)**3.0*x0 + (1.0 - t)**2.0*3.0*t*c0x + (1.0 - t)*3.0*t**2.0*c1x + t**3.0*x1

	y.numberValue = (1.0 - t)**3.0*y0 + (1.0 - t)**2.0*3.0*t*c0y + (1.0 - t)*3.0*t**2.0*c1y + t**3.0*y1
end


def CopyImage(image)

	copy = CreateImage(ImageWidth(image), ImageHeight(image), GetTransparent())

	i = 0.0
	while(i < ImageWidth(image))
		j = 0.0
		while(j < ImageHeight(image))
			SetPixel(copy, i, j, GetImagePixel(image, i, j))
			j = j + 1.0
		end
		i = i + 1.0
	end

	return copy
end


def GetImagePixel(image, x, y)
	return image.x[x].y[y]
end


def HorizontalFlip(img)

	y = 0.0
	while(y < ImageHeight(img))
		x = 0.0
		while(x < ImageWidth(img).to_f / 2.0)
			c1 = GetImagePixel(img, x, y)
			c2 = GetImagePixel(img, ImageWidth(img) - 1.0 - x, y)

			tmp = c1.a
			c1.a = c2.a
			c2.a = tmp

			tmp = c1.r
			c1.r = c2.r
			c2.r = tmp

			tmp = c1.g
			c1.g = c2.g
			c2.g = tmp

			tmp = c1.b
			c1.b = c2.b
			c2.b = tmp
			x = x + 1.0
		end
		y = y + 1.0
	end
end


def DrawFilledRectangle(image, x, y, w, h, color)

	i = 0.0
	while(i < w)
		j = 0.0
		while(j < h)
			SetPixel(image, x + i, y + j, color)
			j = j + 1.0
		end
		i = i + 1.0
	end
end


def RotateAntiClockwise90Degrees(image)

	rotated = CreateImage(ImageHeight(image), ImageWidth(image), GetBlack())

	y = 0.0
	while(y < ImageHeight(image))
		x = 0.0
		while(x < ImageWidth(image))
			SetPixel(rotated, y, ImageWidth(image) - 1.0 - x, GetImagePixel(image, x, y))
			x = x + 1.0
		end
		y = y + 1.0
	end

	return rotated
end


def DrawCircle(canvas, xCenter, yCenter, radius, color)
	DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color)
end


def BresenhamsCircleDrawingAlgorithm(canvas, xCenter, yCenter, radius, color)

	y = radius
	x = 0.0

	delta = 3.0 - 2.0*radius
	while(y >= x)
		DrawLine1px(canvas, xCenter + x, yCenter + y, xCenter + x, yCenter + y, color)
		DrawLine1px(canvas, xCenter + x, yCenter - y, xCenter + x, yCenter - y, color)
		DrawLine1px(canvas, xCenter - x, yCenter + y, xCenter - x, yCenter + y, color)
		DrawLine1px(canvas, xCenter - x, yCenter - y, xCenter - x, yCenter - y, color)

		DrawLine1px(canvas, xCenter - y, yCenter + x, xCenter - y, yCenter + x, color)
		DrawLine1px(canvas, xCenter - y, yCenter - x, xCenter - y, yCenter - x, color)
		DrawLine1px(canvas, xCenter + y, yCenter + x, xCenter + y, yCenter + x, color)
		DrawLine1px(canvas, xCenter + y, yCenter - x, xCenter + y, yCenter - x, color)

		if delta < 0.0
			delta = delta + 4.0*x + 6.0
		else
			delta = delta + 4.0*(x - y) + 10.0
			y = y - 1.0
		end
		x = x + 1.0
	end
end


def DrawCircleMidpointAlgorithm(canvas, xCenter, yCenter, radius, color)

	d = ((5.0 - radius*4.0).to_f / 4.0).floor
	x = 0.0
	y = radius

	while(x <= y)
		DrawPixel(canvas, xCenter + x, yCenter + y, color)
		DrawPixel(canvas, xCenter + x, yCenter - y, color)
		DrawPixel(canvas, xCenter - x, yCenter + y, color)
		DrawPixel(canvas, xCenter - x, yCenter - y, color)
		DrawPixel(canvas, xCenter + y, yCenter + x, color)
		DrawPixel(canvas, xCenter + y, yCenter - x, color)
		DrawPixel(canvas, xCenter - y, yCenter + x, color)
		DrawPixel(canvas, xCenter - y, yCenter - x, color)

		if d < 0.0
			d = d + 2.0*x + 1.0
		else
			d = d + 2.0*(x - y) + 1.0
			y = y - 1.0
		end
		x = x + 1.0
	end
end


def DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color)

	# Place the circle in the center of the pixel.
	xCenter = (xCenter).floor + 0.5
	yCenter = (yCenter).floor + 0.5

	pixels = 2.0*Math::PI*radius

	# Below a radius of 10 pixels, over-compensate to get a smoother circle.
	if radius < 10.0
		pixels = pixels*10.0
	end

	da = 2.0*Math::PI.to_f / pixels

	a = 0.0
	while(a < 2.0*Math::PI)
		dx = Math.cos(a)*radius
		dy = Math.sin(a)*radius

		# Floor to get the pixel coordinate.
		DrawPixel(canvas, (xCenter + dx).floor, (yCenter + dy).floor, color)
		a = a + da
	end
end


def DrawFilledCircle(canvas, x, y, r, color)
	DrawFilledCircleBasicAlgorithm(canvas, x, y, r, color)
end


def DrawFilledCircleMidpointAlgorithm(canvas, xCenter, yCenter, radius, color)

	d = ((5.0 - radius*4.0).to_f / 4.0).floor
	x = 0.0
	y = radius

	while(x <= y)
		DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter + y, xCenter - x, yCenter + y, color)
		DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter - y, xCenter - x, yCenter - y, color)
		DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter + x, xCenter - y, yCenter + x, color)
		DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter - x, xCenter - y, yCenter - x, color)

		if d < 0.0
			d = d + 2.0*x + 1.0
		else
			d = d + 2.0*(x - y) + 1.0
			y = y - 1.0
		end
		x = x + 1.0
	end
end


def DrawFilledCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color)

	# Place the circle in the center of the pixel.
	xCenter = (xCenter).floor + 0.5
	yCenter = (yCenter).floor + 0.5

	pixels = 2.0*Math::PI*radius

	# Below a radius of 10 pixels, over-compensate to get a smoother circle.
	if radius < 10.0
		pixels = pixels*10.0
	end

	da = 2.0*Math::PI.to_f / pixels

	# Draw lines for a half-circle to fill an entire circle.
	a = 0.0
	while(a < Math::PI)
		dx = Math.cos(a)*radius
		dy = Math.sin(a)*radius

		# Floor to get the pixel coordinate.
		DrawVerticalLine1px(canvas, (xCenter - dx).floor, (yCenter - dy).floor, (2.0*dy).floor + 1.0, color)
		a = a + da
	end
end


def DrawTriangle(canvas, xCenter, yCenter, height, color)

	x1 = (xCenter + 0.5).floor
	y1 = ((yCenter + 0.5).floor - height).floor
	x2 = x1 - 2.0*height*Math.tan(Math::PI.to_f / 6.0)
	y2 = (y1 + 2.0*height).floor
	x3 = x1 + 2.0*height*Math.tan(Math::PI.to_f / 6.0)
	y3 = (y1 + 2.0*height).floor

	DrawLine1px(canvas, x1, y1, x2, y2, color)
	DrawLine1px(canvas, x1, y1, x3, y3, color)
	DrawLine1px(canvas, x2, y2, x3, y3, color)
end


def DrawFilledTriangle(canvas, xCenter, yCenter, height, color)

	x1 = (xCenter + 0.5).floor
	y1 = ((yCenter + 0.5).floor - height).floor

	i = 0.0
	while(i <= 2.0*height)
		offset = (i*Math.tan(Math::PI.to_f / 6.0)).floor
		DrawHorizontalLine1px(canvas, x1 - offset, y1 + i, 2.0*offset, color)
		i = i + 1.0
	end
end


def DrawLine(canvas, x1, y1, x2, y2, thickness, color)
	DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color)
end


def DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color)

	dx = x2 - x1
	dy = y2 - y1

	incX = Sign(dx)
	incY = Sign(dy)

	dx = (dx).abs
	dy = (dy).abs

	if dx > dy
		pdx = incX
		pdy = 0.0
		es = dy
		el = dx
	else
		pdx = 0.0
		pdy = incY
		es = dx
		el = dy
	end

	x = x1
	y = y1
	err = el.to_f / 2.0

	if thickness >= 3.0
		r = thickness.to_f / 2.0
		DrawCircle(canvas, x, y, r, color)
	elsif (thickness).floor == 2.0
		DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
	elsif (thickness).floor == 1.0
		DrawPixel(canvas, x, y, color)
	end

	t = 0.0
	while(t < el)
		err = err - es
		if err < 0.0
			err = err + el
			x = x + incX
			y = y + incY
		else
			x = x + pdx
			y = y + pdy
		end

		if thickness >= 3.0
			r = thickness.to_f / 2.0
			DrawCircle(canvas, x, y, r, color)
		elsif (thickness).floor == 2.0
			DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
		elsif (thickness).floor == 1.0
			DrawPixel(canvas, x, y, color)
		end
		t = t + 1.0
	end
end


def DrawLineBresenhamsAlgorithm(canvas, x1, y1, x2, y2, color)

	dx = x2 - x1
	dy = y2 - y1

	incX = Sign(dx)
	incY = Sign(dy)

	dx = (dx).abs
	dy = (dy).abs

	if dx > dy
		pdx = incX
		pdy = 0.0
		es = dy
		el = dx
	else
		pdx = 0.0
		pdy = incY
		es = dx
		el = dy
	end

	x = x1
	y = y1
	err = el.to_f / 2.0
	DrawPixel(canvas, x, y, color)

	t = 0.0
	while(t < el)
		err = err - es
		if err < 0.0
			err = err + el
			x = x + incX
			y = y + incY
		else
			x = x + pdx
			y = y + pdy
		end

		DrawPixel(canvas, x, y, color)
		t = t + 1.0
	end
end


def DrawLineBresenhamsAlgorithmThickPatterned(canvas, x1, y1, x2, y2, thickness, pattern, offset, color)

	dx = x2 - x1
	dy = y2 - y1

	incX = Sign(dx)
	incY = Sign(dy)

	dx = (dx).abs
	dy = (dy).abs

	if dx > dy
		pdx = incX
		pdy = 0.0
		es = dy
		el = dx
	else
		pdx = 0.0
		pdy = incY
		es = dx
		el = dy
	end

	x = x1
	y = y1
	err = el.to_f / 2.0

	offset.numberValue = (offset.numberValue + 1.0)%(pattern.length*thickness)

	if pattern[(offset.numberValue.to_f / thickness).floor]
		if thickness >= 3.0
			r = thickness.to_f / 2.0
			DrawCircle(canvas, x, y, r, color)
		elsif (thickness).floor == 2.0
			DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
		elsif (thickness).floor == 1.0
			DrawPixel(canvas, x, y, color)
		end
	end

	t = 0.0
	while(t < el)
		err = err - es
		if err < 0.0
			err = err + el
			x = x + incX
			y = y + incY
		else
			x = x + pdx
			y = y + pdy
		end

		offset.numberValue = (offset.numberValue + 1.0)%(pattern.length*thickness)

		if pattern[(offset.numberValue.to_f / thickness).floor]
			if thickness >= 3.0
				r = thickness.to_f / 2.0
				DrawCircle(canvas, x, y, r, color)
			elsif (thickness).floor == 2.0
				DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
			elsif (thickness).floor == 1.0
				DrawPixel(canvas, x, y, color)
			end
		end
		t = t + 1.0
	end
end


def GetLinePattern5()

	pattern = Array.new(19)

	pattern[0] = true
	pattern[1] = true
	pattern[2] = true
	pattern[3] = true
	pattern[4] = true
	pattern[5] = true
	pattern[6] = true
	pattern[7] = true
	pattern[8] = true
	pattern[9] = true
	pattern[10] = false
	pattern[11] = false
	pattern[12] = false
	pattern[13] = true
	pattern[14] = true
	pattern[15] = true
	pattern[16] = false
	pattern[17] = false
	pattern[18] = false

	return pattern
end


def GetLinePattern4()

	pattern = Array.new(13)

	pattern[0] = true
	pattern[1] = true
	pattern[2] = true
	pattern[3] = true
	pattern[4] = true
	pattern[5] = true
	pattern[6] = true
	pattern[7] = true
	pattern[8] = true
	pattern[9] = true
	pattern[10] = false
	pattern[11] = false
	pattern[12] = false

	return pattern
end


def GetLinePattern3()

	pattern = Array.new(13)

	pattern[0] = true
	pattern[1] = true
	pattern[2] = true
	pattern[3] = true
	pattern[4] = true
	pattern[5] = true
	pattern[6] = false
	pattern[7] = false
	pattern[8] = false
	pattern[9] = true
	pattern[10] = true
	pattern[11] = false
	pattern[12] = false

	return pattern
end


def GetLinePattern2()

	pattern = Array.new(4)

	pattern[0] = true
	pattern[1] = true
	pattern[2] = false
	pattern[3] = false

	return pattern
end


def GetLinePattern1()

	pattern = Array.new(8)

	pattern[0] = true
	pattern[1] = true
	pattern[2] = true
	pattern[3] = true
	pattern[4] = true
	pattern[5] = false
	pattern[6] = false
	pattern[7] = false

	return pattern
end


def Blur(src, pixels)

	w = ImageWidth(src)
	h = ImageHeight(src)
	dst = CreateImage(w, h, GetTransparent())

	x = 0.0
	while(x < w)
		y = 0.0
		while(y < h)
			SetPixel(dst, x, y, CreateBlurForPoint(src, x, y, pixels))
			y = y + 1.0
		end
		x = x + 1.0
	end

	return dst
end


def CreateBlurForPoint(src, x, y, pixels)

	w = ImageWidth(src)
	h = ImageHeight(src)

	rgba = RGBA.new
	rgba.r = 0.0
	rgba.g = 0.0
	rgba.b = 0.0
	rgba.a = 0.0

	fromx = x - pixels
	fromx = [fromx, 0.0].max

	tox = x + pixels
	tox = [tox, w - 1.0].min

	fromy = y - pixels
	fromy = [fromy, 0.0].max

	toy = y + pixels
	toy = [toy, h - 1.0].min

	countColor = 0.0
	countTransparent = 0.0
	i = fromx
	while(i < tox)
		j = fromy
		while(j < toy)
			alpha = src.x[i].y[j].a
			if alpha > 0.0
				rgba.r = rgba.r + src.x[i].y[j].r
				rgba.g = rgba.g + src.x[i].y[j].g
				rgba.b = rgba.b + src.x[i].y[j].b
				countColor = countColor + 1.0
			end
			rgba.a = rgba.a + alpha
			countTransparent = countTransparent + 1.0
			j = j + 1.0
		end
		i = i + 1.0
	end

	if countColor > 0.0
		rgba.r = rgba.r.to_f / countColor
		rgba.g = rgba.g.to_f / countColor
		rgba.b = rgba.b.to_f / countColor
	else
		rgba.r = 0.0
		rgba.g = 0.0
		rgba.b = 0.0
	end

	if countTransparent > 0.0
		rgba.a = rgba.a.to_f / countTransparent
	else
		rgba.a = 0.0
	end

	return rgba
end


def ScaleNearestNeighborFloorFactor(src, factor)

	w = ImageWidth(src)
	h = ImageHeight(src)

	newWidth = Round(w*factor)
	newHeight = Round(h*factor)

	dst = ScaleNearestNeighborFloor(src, newWidth, newHeight)

	return dst
end


def ScaleNearestNeighborFloor(src, newWidth, newHeight)

	dst = CreateImage(newWidth, newHeight, GetTransparent())

	x = 0.0
	while(x < newWidth)
		y = 0.0
		while(y < newHeight)
			SetPixel(dst, x, y, GetNearestNeighborFloor(src, dst, x, y))
			y = y + 1.0
		end
		x = x + 1.0
	end

	return dst
end


def GetNearestNeighborFloor(src, dst, x, y)

	srcw = ImageWidth(src)
	srch = ImageHeight(src)
	dstw = ImageWidth(dst)
	dsth = ImageHeight(dst)

	nnx = (x*srcw.to_f / dstw).floor
	nny = (y*srch.to_f / dsth).floor

	return src.x[nnx].y[nny]
end


def ScaleNearestNeighborFactor(src, factor)

	w = ImageWidth(src)
	h = ImageHeight(src)

	newWidth = Round(w*factor)
	newHeight = Round(h*factor)

	dst = ScaleNearestNeighbor(src, newWidth, newHeight)

	return dst
end


def ScaleNearestNeighbor(src, newWidth, newHeight)

	dst = CreateImage(newWidth, newHeight, GetTransparent())

	x = 0.0
	while(x < newWidth)
		y = 0.0
		while(y < newHeight)
			SetPixel(dst, x, y, GetNearestNeighbor(src, dst, x, y))
			y = y + 1.0
		end
		x = x + 1.0
	end

	return dst
end


def GetNearestNeighbor(src, dst, x, y)

	srcw = ImageWidth(src)
	srch = ImageHeight(src)
	dstw = ImageWidth(dst)
	dsth = ImageHeight(dst)

	nnx = [Round(x*srcw.to_f / dstw), srcw - 1.0].min
	nny = [Round(y*srch.to_f / dsth), srch - 1.0].min

	return src.x[nnx].y[nny]
end


def BilinaerScaleUpFactor(src, factor)

	w = ImageWidth(src)
	h = ImageHeight(src)

	newWidth = Round(w*factor)
	newHeight = Round(h*factor)

	dst = BilinaerScaleUp(src, newWidth, newHeight)

	return dst
end


def BilinaerScaleUp(src, newWidth, newHeight)

	dst = CreateImage(newWidth, newHeight, GetTransparent())

	y = 0.0
	while(y < newHeight)
		x = 0.0
		while(x < newWidth)
			SetPixel(dst, x, y, GetBilinearlyScaledPixel(src, dst, x, y))
			x = x + 1.0
		end
		y = y + 1.0
	end

	return dst
end


def GetBilinearlyScaledPixel(src, dst, dstx, dsty)

	srcw = ImageWidth(src)
	srch = ImageHeight(src)
	dstw = ImageWidth(dst)
	dsth = ImageHeight(dst)

	x = dstx*srcw.to_f / dstw
	y = dsty*srch.to_f / dsth

	x = x + 0.25
	y = y + 0.25

	x1 = [(x).floor, srcw - 1.0].min
	x2 = [(x).ceil, srcw - 1.0].min
	y1 = [(y).floor, srch - 1.0].min
	y2 = [(y).ceil, srch - 1.0].min

	x1y1 = src.x[x1].y[y1]
	x1y2 = src.x[x1].y[y2]
	x2y1 = src.x[x2].y[y1]
	x2y2 = src.x[x2].y[y2]

	if x1 == x2
		x2 = x2 + 1.0
	end
	if y1 == y2
		y2 = y2 + 1.0
	end

	result = RGBA.new

	result.r = GetBilinearInterpolation(x1y1.r, x2y1.r, x1y2.r, x2y2.r, x, y, x1, x2, y1, y2)
	result.g = GetBilinearInterpolation(x1y1.g, x2y1.g, x1y2.g, x2y2.g, x, y, x1, x2, y1, y2)
	result.b = GetBilinearInterpolation(x1y1.b, x2y1.b, x1y2.b, x2y2.b, x, y, x1, x2, y1, y2)
	result.a = GetBilinearInterpolation(x1y1.a, x2y1.a, x1y2.a, x2y2.a, x, y, x1, x2, y1, y2)

	return result
end


def GetBilinearInterpolation(q11, q12, q21, q22, x, y, x1, x2, y1, y2)

	h1 = (x2 - x).to_f / (x2 - x1)*q11 + (x - x1).to_f / (x2 - x1)*q12
	h2 = (x2 - x).to_f / (x2 - x1)*q21 + (x - x1).to_f / (x2 - x1)*q22

	v = (y2 - y).to_f / (y2 - y1)*h1 + (y - y1).to_f / (y2 - y1)*h2

	return v
end


def Negate(x)
	return -x
end


def Positive(x)
	return +x
end


def Factorial(x)

	f = 1.0

	i = 2.0
	while(i <= x)
		f = f*i
		i = i + 1.0
	end

	return f
end


def Round(x)
	return (x + 0.5).floor
end


def RoundToDigits(element, digitsAfterPoint)
	return Round(element*10.0**digitsAfterPoint).to_f / 10.0**digitsAfterPoint
end


def BankersRound(x)

	if Absolute(x - Truncate(x)) == 0.5
		if !DivisibleBy(Round(x), 2.0)
			r = Round(x) - 1.0
		else
			r = Round(x)
		end
	else
		r = Round(x)
	end

	return r
end


def Ceil(x)
	return (x).ceil
end


def Floor(x)
	return (x).floor
end


def Truncate(x)

	if x >= 0.0
		t = (x).floor
	else
		t = (x).ceil
	end

	return t
end


def Absolute(x)
	return (x).abs
end


def Logarithm(x)
	return Math.log10(x)
end


def NaturalLogarithm(x)
	return Math.log(x)
end


def Sin(x)
	return Math.sin(x)
end


def Cos(x)
	return Math.cos(x)
end


def Tan(x)
	return Math.tan(x)
end


def Asin(x)
	return Math.asin(x)
end


def Acos(x)
	return Math.acos(x)
end


def Atan(x)
	return Math.atan(x)
end


def Atan2(y, x)

	# Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.
	a = 0.0

	if x > 0.0
		a = Atan(y.to_f / x)
	elsif x < 0.0 && y >= 0.0
		a = Atan(y.to_f / x) + Math::PI
	elsif x < 0.0 && y < 0.0
		a = Atan(y.to_f / x) - Math::PI
	elsif x == 0.0 && y > 0.0
		a = Math::PI.to_f / 2.0
	elsif x == 0.0 && y < 0.0
		a = -Math::PI.to_f / 2.0
	end

	return a
end


def Squareroot(x)
	return Math.sqrt(x)
end


def Exp(x)
	return Math.exp(x)
end


def DivisibleBy(a, b)
	return ((a%b) == 0.0)
end


def Combinations(n, k)

	c = 1.0
	j = 1.0
	i = n - k + 1.0

	while(i <= n)
		c = c*i
		c = c.to_f / j

		i = i + 1.0
		j = j + 1.0
	end

	return c
end


def Permutations(n, k)

	c = 1.0

	i = n - k + 1.0
	while(i <= n)
		c = c*i
		i = i + 1.0
	end

	return c
end


def EpsilonCompare(a, b, epsilon)
	return (a - b).abs < epsilon
end


def GreatestCommonDivisor(a, b)

	while(b != 0.0)
		t = b
		b = a%b
		a = t
	end

	return a
end


def GCDWithSubtraction(a, b)

	if a == 0.0
		g = b
	else
		while(b != 0.0)
			if a > b
				a = a - b
			else
				b = b - a
			end
		end

		g = a
	end

	return g
end


def IsInteger(a)
	return (a - (a).floor) == 0.0
end


def GreatestCommonDivisorWithCheck(a, b, gcdReference)

	if IsInteger(a) && IsInteger(b)
		gcd = GreatestCommonDivisor(a, b)
		gcdReference.numberValue = gcd
		success = true
	else
		success = false
	end

	return success
end


def LeastCommonMultiple(a, b)

	if a > 0.0 && b > 0.0
		lcm = (a*b).abs.to_f / GreatestCommonDivisor(a, b)
	else
		lcm = 0.0
	end

	return lcm
end


def Sign(a)

	if a > 0.0
		s = 1.0
	elsif a < 0.0
		s = -1.0
	else
		s = 0.0
	end

	return s
end


def Max(a, b)
	return [a, b].max
end


def Min(a, b)
	return [a, b].min
end


def Power(a, b)
	return a**b
end


def Gamma(x)
	return LanczosApproximation(x)
end


def LogGamma(x)
	return Math.log(Gamma(x))
end


def LanczosApproximation(z)

	p = Array.new(8)
	p[0] = 676.5203681218851
	p[1] = -1259.1392167224028
	p[2] = 771.32342877765313
	p[3] = -176.61502916214059
	p[4] = 12.507343278686905
	p[5] = -0.13857109526572012
	p[6] = 9.9843695780195716e-6
	p[7] = 1.5056327351493116e-7

	if z < 0.5
		y = Math::PI.to_f / (Math.sin(Math::PI*z)*LanczosApproximation(1.0 - z))
	else
		z = z - 1.0
		x = 0.99999999999980993
		i = 0.0
		while(i < p.length)
			x = x + p[i].to_f / (z + i + 1.0)
			i = i + 1.0
		end
		t = z + p.length - 0.5
		y = Math.sqrt(2.0*Math::PI)*t**(z + 0.5)*Math.exp(-t)*x
	end

	return y
end


def Beta(x, y)
	return Gamma(x)*Gamma(y).to_f / Gamma(x + y)
end


def Sinh(x)
	return (Math.exp(x) - Math.exp(-x)).to_f / 2.0
end


def Cosh(x)
	return (Math.exp(x) + Math.exp(-x)).to_f / 2.0
end


def Tanh(x)
	return Sinh(x).to_f / Cosh(x)
end


def Cot(x)
	return 1.0.to_f / Math.tan(x)
end


def Sec(x)
	return 1.0.to_f / Math.cos(x)
end


def Csc(x)
	return 1.0.to_f / Math.sin(x)
end


def Coth(x)
	return Cosh(x).to_f / Sinh(x)
end


def Sech(x)
	return 1.0.to_f / Cosh(x)
end


def Csch(x)
	return 1.0.to_f / Sinh(x)
end


def Error(x)

	if x == 0.0
		y = 0.0
	elsif x < 0.0
		y = -Error(-x)
	else
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

		t = 1.0.to_f / (1.0 + 0.5*(x).abs)

		tau = t*Math.exp(-x**2.0 + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))))

		y = 1.0 - tau
	end

	return y
end


def ErrorInverse(x)

	a = (8.0*(Math::PI - 3.0)).to_f / (3.0*Math::PI*(4.0 - Math::PI))

	t = 2.0.to_f / (Math::PI*a) + Math.log(1.0 - x**2.0).to_f / 2.0
	y = Sign(x)*Math.sqrt(Math.sqrt(t**2.0 - Math.log(1.0 - x**2.0).to_f / a) - t)

	return y
end


def FallingFactorial(x, n)

	y = 1.0

	k = 0.0
	while(k <= n - 1.0)
		y = y*(x - k)
		k = k + 1.0
	end

	return y
end


def RisingFactorial(x, n)

	y = 1.0

	k = 0.0
	while(k <= n - 1.0)
		y = y*(x + k)
		k = k + 1.0
	end

	return y
end


def Hypergeometric(a, b, c, z, maxIterations, precision)

	if (z).abs >= 0.5
		y = (1.0 - z)**(-a)*HypergeometricDirect(a, c - b, c, z.to_f / (z - 1.0), maxIterations, precision)
	else
		y = HypergeometricDirect(a, b, c, z, maxIterations, precision)
	end

	return y
end


def HypergeometricDirect(a, b, c, z, maxIterations, precision)

	y = 0.0
	done = false

	n = 0.0
	while(n < maxIterations && !done)
		yp = RisingFactorial(a, n)*RisingFactorial(b, n).to_f / RisingFactorial(c, n)*z**n.to_f / Factorial(n)
		if (yp).abs < precision
			done = true
		end
		y = y + yp
		n = n + 1.0
	end

	return y
end


def BernouilliNumber(n)
	return AkiyamaTanigawaAlgorithm(n)
end


def AkiyamaTanigawaAlgorithm(n)

	a = Array.new(n + 1.0)

	m = 0.0
	while(m <= n)
		a[m] = 1.0.to_f / (m + 1.0)
		j = m
		while(j >= 1.0)
			a[j - 1.0] = j*(a[j - 1.0] - a[j])
			j = j - 1.0
		end
		m = m + 1.0
	end

	b = a[0]

	delete(a)

	return b
end


def D15Add(a, b, overflow)

	x = a + b

	if x > D15MaxValue() || x < D15MinValue()
		overflow.booleanValue = true
		x = 0.0
	else
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	end

	return x
end


def RoundTo15Digits(x)

	p = (Math.log10(x)).floor
	x = x*10.0**(15.0 - p)
	x = Round(x)
	x = x.to_f / 10.0**(15.0 - p)

	return x
end


def D15MaxValue()
	return +9.99999999999999e99
end


def D15MinValue()
	return -9.99999999999999e99
end


def D15Multiply(a, b, overflow)

	x = a*b

	if x > D15MaxValue() || x < D15MinValue()
		overflow.booleanValue = true
		x = 0.0
	else
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	end

	return x
end


def D15Divide(a, b, reminder, overflow, invalidOperation)

	if b != 0.0
		invalidOperation.booleanValue = false

		x = a.to_f / b
		r = a%b

		if x > D15MaxValue() || x < D15MinValue()
			overflow.booleanValue = true
			x = 0.0
			r = 0.0
		else
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
			r = RoundTo15Digits(r)
		end
	else
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
		r = 0.0
	end

	reminder.numberValue = r

	return x
end


def D15Exponentiation(a, b, overflow, invalidOperation)

	if a == 0.0 && b == 0.0
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
	elsif a < 0.0 && !IsInteger(b)
		invalidOperation.booleanValue = true
		overflow.booleanValue = false
		x = 0.0
	else
		invalidOperation.booleanValue = false

		x = a**b

		if x > D15MaxValue() || x < D15MinValue()
			overflow.booleanValue = true
			x = 0.0
		else
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		end
	end

	return x
end


def D15Modulus(a, b, invalidOperation)

	if a < 0.0 || b == 0.0 || b < 0.0
		invalidOperation.booleanValue = true
		x = 0.0
	else
		invalidOperation.booleanValue = false
		x = a%b
		x = RoundTo15Digits(x)
	end

	return x
end


def D15Logarithm(a, invalidOperation)

	if a <= 0.0
		invalidOperation.booleanValue = true
		x = 0.0
	else
		invalidOperation.booleanValue = false
		x = Math.log10(a)
		x = RoundTo15Digits(x)
	end

	return x
end


def D15NaturalLogarithm(a, invalidOperation)

	if a <= 0.0
		invalidOperation.booleanValue = true
		x = 0.0
	else
		invalidOperation.booleanValue = false
		x = Math.log(a)
		x = RoundTo15Digits(x)
	end

	return x
end


def D15Sin(a)

	x = Math.sin(a)
	x = RoundTo15Digits(x)

	return x
end


def D15Cos(x)

	x = (x).abs

	limit = Math::PI + 3.1.to_f / 2.0

	if x > limit
		f = (x.to_f / Math::PI).floor
		x = x - Math::PI*f
	end

	piBy2Part1 = +1.57079632679490
	piBy2Part2 = -3.38076867830836e-15

	if x > 3.1.to_f / 2.0 && x < 3.3.to_f / 2.0
		a = x - piBy2Part1
		a = (a*10.0**15.0).round.to_f / 10.0**15.0
		a = a - piBy2Part2
		y = -Math.sin(a)
	else
		y = Math.cos(x)
		y = RoundTo15Digits(y)
	end

	return y
end


def D15Tan(a, overflow)

	x = Math.tan(a)

	if x > D15MaxValue() || x < D15MinValue()
		overflow.booleanValue = true
		x = 0.0
	else
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	end

	return x
end


def D15Asin(a, invalidOperation)

	if a < -1.0 || a > 1.0
		invalidOperation.booleanValue = true
		x = 0.0
	else
		invalidOperation.booleanValue = false
		x = Math.asin(a)
		x = RoundTo15Digits(x)
	end

	return x
end


def D15Acos(a, invalidOperation)

	if a < -1.0 || a > 1.0
		invalidOperation.booleanValue = true
		x = 0.0
	else
		invalidOperation.booleanValue = false
		x = Math.acos(a)
		x = RoundTo15Digits(x)
	end

	return x
end


def D15Atan(a)

	x = Math.atan(a)
	x = RoundTo15Digits(x)

	return x
end


def D15Sqrt(a)

	x = Math.sqrt(a)
	x = RoundTo15Digits(x)

	return x
end


def D15Exponential(a, overflow)

	x = Math.exp(a)

	if x > D15MaxValue() || x < D15MinValue()
		overflow.booleanValue = true
		x = 0.0
	else
		overflow.booleanValue = false
		x = RoundTo15Digits(x)
	end

	return x
end


def Decimal15E2ToString(decimal)

	len = 21.0
	# 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"
	result = Array.new(len)

	done = false
	exponent = 0.0

	if decimal < 0.0
		isPositive = false
		decimal = -decimal
	else
		isPositive = true
	end

	if decimal == 0.0
		done = true
	end

	if !done
		multiplier = 0.0
		inc = 0.0

		if decimal < 1.0
			multiplier = 10.0
			inc = -1.0
		elsif decimal >= 10.0
			multiplier = 0.1
			inc = 1.0
		else
			done = true
		end

		if !done
			exponent = (Math.log10(decimal)).round
			exponent = [99.0, exponent].min
			exponent = [-99.0, exponent].max

			decimal = decimal.to_f / 10.0**exponent

			# Adjust
			while((decimal >= 10.0 || decimal < 1.0) && (exponent).abs < 99.0)
				decimal = decimal*multiplier
				exponent = exponent + inc
			end
		end
	end

	isPositiveExponent = exponent >= 0.0
	if !isPositiveExponent
		exponent = -exponent
	end

	if isPositive
		result[0] = "+"
	else
		result[0] = "-"
	end

	decimal = (decimal*10.0**14.0).round

	d = (decimal.to_f / 10.0**14.0).floor
	result[1] = SingleDigitNumberToCharacter(d)
	decimal = decimal - d*10.0**14.0

	result[2] = "."

	i = 0.0
	while(i < 14.0)
		d = (decimal.to_f / 10.0**(13.0 - i)).floor
		result[3.0 + i] = SingleDigitNumberToCharacter(d)
		decimal = decimal - d*10.0**(13.0 - i)
		i = i + 1.0
	end

	result[17] = "e"

	if isPositiveExponent
		result[18] = "+"
	else
		result[18] = "-"
	end

	result[19] = SingleDigitNumberToCharacter((exponent.to_f / 10.0).floor)
	result[20] = SingleDigitNumberToCharacter((exponent%10.0).floor)

	return result
end


def SingleDigitNumberToCharacter(n)

	c = "0"
	if n == 0.0
		c = "0"
	elsif n == 1.0
		c = "1"
	elsif n == 2.0
		c = "2"
	elsif n == 3.0
		c = "3"
	elsif n == 4.0
		c = "4"
	elsif n == 5.0
		c = "5"
	elsif n == 6.0
		c = "6"
	elsif n == 7.0
		c = "7"
	elsif n == 8.0
		c = "8"
	elsif n == 9.0
		c = "9"
	end

	return c
end


def DigitDataBase16()
	return "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe891412108153069c4ffffffffffffffffffffffffffffffffffffffff9409000000000000000049e7ffffffffffffffffffffffffffffffffff61000000000000000000000017ddffffffffffffffffffffffffffffff840000000573d3f5e5a62b00000028f0ffffffffffffffffffffffffffda04000008bcfffffffffff44200000073ffffffffffffffffffffffffff5700000088ffffffffffffffe812000008e3ffffffffffffffffffffffea02000015f9ffffffffffffffff8100000080ffffffffffffffffffffff9c00000072ffffffffffffffffffe40100002fffffffffffffffffffffff51000000b8ffffffffffffffffffff2a000000e2ffffffffffffffffffff21000001f0ffffffffffffffffffff65000000b3fffffffffffffffffff602000018ffffffffffffffffffffff8b0000008affffffffffffffffffd200000036ffffffffffffffffffffffa900000063ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffb500000057ffffffffffffffffffffffc900000046ffffffffffffffffffa90000005fffffffffffffffffffffffd20000003affffffffffffffffffa900000060ffffffffffffffffffffffd30000003affffffffffffffffffb400000057ffffffffffffffffffffffca00000046ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffd100000037ffffffffffffffffffffffa900000063fffffffffffffffffff602000019ffffffffffffffffffffff8b00000089ffffffffffffffffffff21000001f1ffffffffffffffffffff66000000b3ffffffffffffffffffff50000000b8ffffffffffffffffffff2a000000e1ffffffffffffffffffff9c00000073ffffffffffffffffffe40100002fffffffffffffffffffffffea02000015f9ffffffffffffffff8200000080ffffffffffffffffffffffff5700000088ffffffffffffffe812000008e2ffffffffffffffffffffffffda04000008bcfffffffffff44300000073ffffffffffffffffffffffffffff830000000674d3f6e6a72b00000028f0ffffffffffffffffffffffffffffff60000000000000000000000016ddfffffffffffffffffffffffffffffffffe9309000000000000000048e6ffffffffffffffffffffffffffffffffffffffe88f3f1f07132e68c3fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9d7b28e69441f02000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6a274c7095b9de64000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000affffffffffffffffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffd48b56271005142a5ea0f6ffffffffffffffffffffffffffffffffdb7c20000000000000000000001392feffffffffffffffffffffffffffff1f00000000000000000000000000004cf9ffffffffffffffffffffffffff1f0000003784c7e7f9e8b1480000000056ffffffffffffffffffffffffff1f015accffffffffffffffff9701000000b0ffffffffffffffffffffffff58caffffffffffffffffffffff770000003cfffffffffffffffffffffffffffffffffffffffffffffffffff107000002edffffffffffffffffffffffffffffffffffffffffffffffffff3a000000ccffffffffffffffffffffffffffffffffffffffffffffffffff4c000000baffffffffffffffffffffffffffffffffffffffffffffffffff32000000cbffffffffffffffffffffffffffffffffffffffffffffffffec05000002edffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffeb140000009affffffffffffffffffffffffffffffffffffffffffffffff520000002afbffffffffffffffffffffffffffffffffffffffffffffff8c00000003c7ffffffffffffffffffffffffffffffffffffffffffffffb30300000085ffffffffffffffffffffffffffffffffffffffffffffffc50a0000005dfeffffffffffffffffffffffffffffffffffffffffffffd2110000004efbffffffffffffffffffffffffffffffffffffffffffffdb1800000042f8ffffffffffffffffffffffffffffffffffffffffffffe21f00000039f3ffffffffffffffffffffffffffffffffffffffffffffe92600000030efffffffffffffffffffffffffffffffffffffffffffffee2e00000029eafffffffffffffffffffffffffffffffffffffffffffff33700000022e5fffffffffffffffffffffffffffffffffffffffffffff7410000001cdffffffffffffffffffffffffffffffffffffffffffffffb4c00000017d9fffffffffffffffffffffffffffffffffffffffffffffd5900000012d2ffffffffffffffffffffffffffffffffffffffffffffff680000000ecbffffffffffffffffffffffffffffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe2af8058392817060a1a3f74c8ffffffffffffffffffffffffffffffffeb0000000000000000000000000036cfffffffffffffffffffffffffffffeb000000000000000000000000000004a7ffffffffffffffffffffffffffeb00000f5a9dd0edfbf0ca841900000003c2ffffffffffffffffffffffffec3da8f9fffffffffffffffff0410000002bffffffffffffffffffffffffffffffffffffffffffffffffffee12000000cbffffffffffffffffffffffffffffffffffffffffffffffffff6900000090ffffffffffffffffffffffffffffffffffffffffffffffffff9600000078ffffffffffffffffffffffffffffffffffffffffffffffffff9a0000007effffffffffffffffffffffffffffffffffffffffffffffffff73000000a5fffffffffffffffffffffffffffffffffffffffffffffffff51b000009edfffffffffffffffffffffffffffffffffffffffffffffff7540000007efffffffffffffffffffffffffffffffffffffffffff3d3912400000055fcffffffffffffffffffffffffffffffffff1700000000000000001692feffffffffffffffffffffffffffffffffffff17000000000000002db8feffffffffffffffffffffffffffffffffffffff170000000000000000002bc3fffffffffffffffffffffffffffffffffffffffffffdf0cf922e00000003a5fffffffffffffffffffffffffffffffffffffffffffffffffd8700000007d1ffffffffffffffffffffffffffffffffffffffffffffffffff780000004ffffffffffffffffffffffffffffffffffffffffffffffffffff308000006f6ffffffffffffffffffffffffffffffffffffffffffffffffff3c000000d0ffffffffffffffffffffffffffffffffffffffffffffffffff4d000000c6ffffffffffffffffffffffffffffffffffffffffffffffffff35000000ddffffffffffffffffffffffffffffffffffffffffffffffffea0300000bf9ffffffffffffffffffffffffffffffffffffffffffffffff6200000054ffffffffffffffffffffff47bafefffffffffffffffffff56b00000002cbffffffffffffffffffffff0b001e71a9d7edfbf6e4ba771a000000007cffffffffffffffffffffffff0b0000000000000000000000000000017dffffffffffffffffffffffffff0b000000000000000000000000003cc8ffffffffffffffffffffffffffffe9b989593827160608162a5689dbffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffbd0100000000f3fffffffffffffffffffffffffffffffffffffffffffff3200000000000f3ffffffffffffffffffffffffffffffffffffffffffff69000000000000f3ffffffffffffffffffffffffffffffffffffffffffbf01000b0e000000f3fffffffffffffffffffffffffffffffffffffffff42100008e1f000000f3ffffffffffffffffffffffffffffffffffffffff6a000035fc1f000000f3ffffffffffffffffffffffffffffffffffffffc0010004d1ff1f000000f3fffffffffffffffffffffffffffffffffffff42200007affff1f000000f3ffffffffffffffffffffffffffffffffffff6c000026f7ffff1f000000f3ffffffffffffffffffffffffffffffffffc1010001c1ffffff1f000000f3fffffffffffffffffffffffffffffffff523000066ffffffff1f000000f3ffffffffffffffffffffffffffffffff6d000019f0ffffffff1f000000f3ffffffffffffffffffffffffffffffc2010000aeffffffffff1f000000f3fffffffffffffffffffffffffffff524000052ffffffffffff1f000000f3ffffffffffffffffffffffffffff6e00000fe6ffffffffffff1f000000f3ffffffffffffffffffffffffffc30200009affffffffffffff1f000000f3fffffffffffffffffffffffff62400003ffeffffffffffffff1f000000f3ffffffffffffffffffffffff70000008daffffffffffffffff1f000000f3fffffffffffffffffffffff602000086ffffffffffffffffff1f000000f3fffffffffffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f000008672f120514275997efffffffffffffffffffffffffffffffffff4f00000000000000000000000b73f6ffffffffffffffffffffffffffffff4f000000000000000000000000002bdeffffffffffffffffffffffffffff60538cbad2e7faf0d599370000000025ebffffffffffffffffffffffffffffffffffffffffffffffffa0090000005bffffffffffffffffffffffffffffffffffffffffffffffffffb100000001d2ffffffffffffffffffffffffffffffffffffffffffffffffff560000007effffffffffffffffffffffffffffffffffffffffffffffffffb80000003dffffffffffffffffffffffffffffffffffffffffffffffffffec00000022fffffffffffffffffffffffffffffffffffffffffffffffffffd00000011ffffffffffffffffffffffffffffffffffffffffffffffffffec00000022ffffffffffffffffffffffffffffffffffffffffffffffffffb80000003cffffffffffffffffffffffffffffffffffffffffffffffffff580000007dffffffffffffffffffffffffffffffffffffffffffffffffb301000000cfffffffffffffffffffffff4cb1fdffffffffffffffffffa40a00000058ffffffffffffffffffffffff17001a6ea9d7eefbf2d69b380000000024e8ffffffffffffffffffffffff1700000000000000000000000000002de0ffffffffffffffffffffffffff17000000000000000000000000127ef9ffffffffffffffffffffffffffffebba8a59372615050a1a3569a6f7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffca753915050d233866a3e0ffffffffffffffffffffffffffffffffffd13f0000000000000000000000f7ffffffffffffffffffffffffffffff9d07000000000000000000000000f7ffffffffffffffffffffffffffff9700000000469fdbf3f5da9e490100f7ffffffffffffffffffffffffffca0300000eb3ffffffffffffffffd84df8fffffffffffffffffffffffffa2d000007c8ffffffffffffffffffffffffffffffffffffffffffffffff9100000081ffffffffffffffffffffffffffffffffffffffffffffffffff28000010f6ffffffffffffffffffffffffffffffffffffffffffffffffc20000006affffffffffffffffffffffffffffffffffffffffffffffffff79000000b2ffffffffffffffffffffffffffffffffffffffffffffffffff43000000ebffeb903d1a0616306fc0ffffffffffffffffffffffffffffff0f000015ffa211000000000000000041dcfffffffffffffffffffffffff30000003087000000000000000000000013c6ffffffffffffffffffffffe30000000f00000055beeef7d8881000000017e6ffffffffffffffffffffd30000000000019dffffffffffffe12200000056ffffffffffffffffffffd100000000006effffffffffffffffce04000002dbffffffffffffffffffdd0000000006eaffffffffffffffffff550000008bffffffffffffffffffe90000000043ffffffffffffffffffffa90000004dfffffffffffffffffff80200000074ffffffffffffffffffffdb0000002cffffffffffffffffffff2200000088ffffffffffffffffffffef00000019ffffffffffffffffffff4d00000088ffffffffffffffffffffee0000001affffffffffffffffffff7e00000074ffffffffffffffffffffdb0000002dffffffffffffffffffffcd00000042ffffffffffffffffffffa900000052ffffffffffffffffffffff21000005e9ffffffffffffffffff5400000093ffffffffffffffffffffff8f0000006dffffffffffffffffcd04000007e6fffffffffffffffffffffff9220000019effffffffffffe1230000006cffffffffffffffffffffffffffc00600000056beeff8d888110000002af3ffffffffffffffffffffffffffffa603000000000000000000000026ddffffffffffffffffffffffffffffffffc8280000000000000000025deffffffffffffffffffffffffffffffffffffffab25a2a1106193b7ed7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff47000000000000000000000000000000000000f7ffffffffffffffffffff47000000000000000000000000000000000003faffffffffffffffffffff4700000000000000000000000000000000004afffffffffffffffffffffffffffffffffffffffffffffffffc1a000000adffffffffffffffffffffffffffffffffffffffffffffffffb300000015faffffffffffffffffffffffffffffffffffffffffffffffff5100000073ffffffffffffffffffffffffffffffffffffffffffffffffea05000000d6ffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffff2c0000009dffffffffffffffffffffffffffffffffffffffffffffffffc90000000cf3ffffffffffffffffffffffffffffffffffffffffffffffff6700000063fffffffffffffffffffffffffffffffffffffffffffffffff60f000000c6ffffffffffffffffffffffffffffffffffffffffffffffffa300000029ffffffffffffffffffffffffffffffffffffffffffffffffff410000008cffffffffffffffffffffffffffffffffffffffffffffffffdf01000005e9ffffffffffffffffffffffffffffffffffffffffffffffff7d00000052fffffffffffffffffffffffffffffffffffffffffffffffffd1e000000b5ffffffffffffffffffffffffffffffffffffffffffffffffb90000001bfcffffffffffffffffffffffffffffffffffffffffffffffff570000007bffffffffffffffffffffffffffffffffffffffffffffffffee07000001ddffffffffffffffffffffffffffffffffffffffffffffffff9300000042ffffffffffffffffffffffffffffffffffffffffffffffffff31000000a5ffffffffffffffffffffffffffffffffffffffffffffffffd000000010f7ffffffffffffffffffffffffffffffffffffffffffffffff6d0000006bfffffffffffffffffffffffffffffffffffffffffffffffff913000000ceffffffffffffffffffffffffffffffffffffffffffffffffa900000031ffffffffffffffffffffffffffffffffffffffffffffffffff4700000094ffffffffffffffffffffffffffffffffffffffffffffffffe302000008eeffffffffffffffffffffffffffffffffffffffffffffffff840000005afffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9a8602c13050c1d4882dfffffffffffffffffffffffffffffffffffffa918000000000000000000025eeeffffffffffffffffffffffffffffff780000000000000000000000000023e5ffffffffffffffffffffffffff9f0000000037a8e4faf1c66d0500000033fdfffffffffffffffffffffff81600000065fdffffffffffffc40a0000009fffffffffffffffffffffffb600000021faffffffffffffffff8d00000047ffffffffffffffffffffff820000007bffffffffffffffffffeb01000014ffffffffffffffffffffff6d000000a2ffffffffffffffffffff15000001fdffffffffffffffffffff76000000a2ffffffffffffffffffff14000007ffffffffffffffffffffffa10000007bffffffffffffffffffec01000033ffffffffffffffffffffffec08000022fbffffffffffffffff8e00000087ffffffffffffffffffffffff7d00000068fdffffffffffffc70b00001ef2fffffffffffffffffffffffffb5500000039aae5fbf2c87006000013d0fffffffffffffffffffffffffffffe93160000000000000000000153e3ffffffffffffffffffffffffffffffffffbd2e000000000000000780f0ffffffffffffffffffffffffffffffffce3500000000000000000000000e87fcffffffffffffffffffffffffffb3060000004fb2e6faf0cd82150000004ffaffffffffffffffffffffffda0b000004a9ffffffffffffffe93600000076ffffffffffffffffffffff5600000084ffffffffffffffffffe80e000005e2fffffffffffffffffff606000008f4ffffffffffffffffffff6f0000008dffffffffffffffffffcb00000039ffffffffffffffffffffffac0000005cffffffffffffffffffbc0000004affffffffffffffffffffffbe0000004dffffffffffffffffffcc00000039ffffffffffffffffffffffac0000005effffffffffffffffffea00000008f4ffffffffffffffffffff6e0000007cffffffffffffffffffff2f00000085ffffffffffffffffffe70d000000c1ffffffffffffffffffff9300000004a9ffffffffffffffe83400000028fcfffffffffffffffffffffa2d0000000050b2e7fbf2cd821400000002b8ffffffffffffffffffffffffe523000000000000000000000000000299fffffffffffffffffffffffffffff16605000000000000000000002cc5ffffffffffffffffffffffffffffffffffe88e542512040b1b3d72c1fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff8a259251008203f8be2ffffffffffffffffffffffffffffffffffffffa91d0000000000000000047ffaffffffffffffffffffffffffffffffff7b00000000000000000000000040f8ffffffffffffffffffffffffffff94000000004db9ecf7da8b1300000057ffffffffffffffffffffffffffdc050000008fffffffffffffe527000000acffffffffffffffffffffffff630000005fffffffffffffffffd406000025fbfffffffffffffffffffffb0c000002e0ffffffffffffffffff5f000000b2ffffffffffffffffffffc600000036ffffffffffffffffffffb50000005fffffffffffffffffffffa000000068ffffffffffffffffffffe700000011feffffffffffffffffff8d0000007cfffffffffffffffffffffb00000000dfffffffffffffffffff8c0000007cfffffffffffffffffffffb00000000b4ffffffffffffffffff9e00000069ffffffffffffffffffffe7000000008dffffffffffffffffffbe00000038ffffffffffffffffffffb6000000007bfffffffffffffffffff606000003e2ffffffffffffffffff62000000006fffffffffffffffffffff4f00000064ffffffffffffffffd8080000000062ffffffffffffffffffffc50000000096ffffffffffffe82b000000000064ffffffffffffffffffffff6c0000000051bbeff8dc8e1500001000000074fffffffffffffffffffffff94f0000000000000000000000288c00000084fffffffffffffffffffffffffd810b000000000000000052ea830000009fffffffffffffffffffffffffffffea8d471d090d2864c1ffff5b000000d4ffffffffffffffffffffffffffffffffffffffffffffffffff2100000dfdffffffffffffffffffffffffffffffffffffffffffffffffd900000052ffffffffffffffffffffffffffffffffffffffffffffffffff75000000b8ffffffffffffffffffffffffffffffffffffffffffffffffe30d000023fefffffffffffffffffffffffffffffffffffffffffffffff945000000b7ffffffffffffffffffffffffff7fa2fdffffffffffffffe8480000005effffffffffffffffffffffffffff63002080c4ecfae7c0740e00000034f4ffffffffffffffffffffffffffff6300000000000000000000000043f0ffffffffffffffffffffffffffffff6300000000000000000000118efdfffffffffffffffffffffffffffffffff4bb7f462b15040b25569ff4ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff".split("")
end


def DrawDigitCharacter(image, topx, topy, digit)

	colorReference = NumberReference.new
	errorMessage = StringReference.new
	color = RGBA.new

	colorChars = Array.new(2)

	allCharData = DigitDataBase16()

	y = 0.0
	while(y < 37.0)
		x = 0.0
		while(x < 30.0)
			colorChars[0] = allCharData[digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 0.0]
			colorChars[1] = allCharData[digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 1.0]

			strToUpperCase(colorChars)
			CreateNumberFromStringWithCheck(colorChars, 16.0, colorReference, errorMessage)
			color.r = colorReference.numberValue.to_f / 255.0
			color.g = colorReference.numberValue.to_f / 255.0
			color.b = colorReference.numberValue.to_f / 255.0
			color.a = 1.0
			SetPixel(image, topx + x, topy + y, color)
			x = x + 1.0
		end
		y = y + 1.0
	end
end


def GetPixelFontData()
	return "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001100000011000000000000000000000011000000110000001100000011000000110000001100000011000000000000000000000000000000000000000000000000000000000000000000000000000011011000110110001101100011011000000000000000000000000000110011001100110111111110110011001100110111111110110011001100110000000000000000000000000000000000001100001111110111111111101100011111000011111100001111100011011111111110111111000011000000000000000000001110000110110001101101101110110000011000001100000110000011011101101101100011011000011100000000000000000111111100110001111110011000110110000111000001110000110110011001100110011001101100001110000000000000000000000000000000000000000000000000000000000000000000000000000011000001110000011000001110000000000000000000000110000000110000000110000001100000011000000110000001100000011000000110000011000001100000000000000000000000011000001100000110000001100000011000000110000001100000011000000110000000110000000110000000000000000000000000000000000100110010101101000111100111111110011110001011010100110010000000000000000000000000000000000000000000110000001100000011000111111111111111100011000000110000001100000000000000000000000000000000000000011000001100000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011111111111111110000000000000000000000000000000000000000000000000000000000000000000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000110000001100000110000001100000110000001100000110000001100000110000001100000110000001100000000000000000000000011110001100110110000111100011111001111110110111111001111100011110000110110011000111100000000000000000001111110000110000001100000011000000110000001100000011000000110000001111000011100000110000000000000000000111111110000001100000011000001100000110000011000001100000110000011000000111001110111111000000000000000000111111011100111110000001100000011100000011111101110000011000000110000001110011101111110000000000000000000110000001100000011000000110000001100001111111100110011001101100011110000111000001100000000000000000000011111101110011111000000110000001110000001111111000000110000001100000011000000111111111100000000000000000111111011100111110000111100001111100011011111110000001100000011000000111110011101111110000000000000000000001100000011000000110000001100000110000011000001100000110000001100000011000000111111110000000000000000011111101110011111000011110000111110011101111110111001111100001111000011111001110111111000000000000000000111111011100111110000001100000011000000111111101110011111000011110000111110011101111110000000000000000000000000000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000000000000011000001100000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000110000000110000000110000000110000000110000000110000011000001100000110000011000001100000000000000000000000000000000000001111111111111111000000001111111111111111000000000000000000000000000000000000000000000000000001100000110000011000001100000110000011000000011000000011000000011000000011000000011000000000000000000001100000000000000000000001100000011000001100000110000011000000110000111100001101111110000000000000000011111100000001101111001111011011110010111011101111000011011111100000000000000000000000000000000000000000110000111100001111000011110000111111111111000011110000111100001101100110001111000001100000000000000000000111111111100011110000111100001111100011011111111110001111000011110000111110001101111111000000000000000001111110111001110000001100000011000000110000001100000011000000110000001111100111011111100000000000000000001111110111001111100011110000111100001111000011110000111100001111100011011100110011111100000000000000001111111100000011000000110000001100000011001111110000001100000011000000110000001111111111000000000000000000000011000000110000001100000011000000110000001100111111000000110000001100000011111111110000000000000000011111101110011111000011110000111111001100000011000000110000001100000011111001110111111000000000000000001100001111000011110000111100001111000011111111111100001111000011110000111100001111000011000000000000000001111110000110000001100000011000000110000001100000011000000110000001100000011000011111100000000000000000001111100111011101100011011000000110000001100000011000000110000001100000011000000110000000000000000000001100001101100011001100110001101100001111000001110000111100011011001100110110001111000011000000000000000011111111000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000110000111100001111000011110000111100001111000011110110111111111111111111111001111100001100000000000000001110001111100011111100111111001111111011110110111101111111001111110011111100011111000111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111100111011111100000000000000000000000110000001100000011000000110000001101111111111000111100001111000011111000110111111100000000000000001111110001110110111110111101101111000011110000111100001111000011110000110110011000111100000000000000000011000011011000110011001100011011000011110111111111100011110000111100001111100011011111110000000000000000011111101110011111000000110000001110000001111110000001110000001100000011111001110111111000000000000000000001100000011000000110000001100000011000000110000001100000011000000110000001100011111111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111000011110000110000000000000000000110000011110000111100011001100110011011000011110000111100001111000011110000111100001100000000000000001100001111100111111111111111111111011011110110111100001111000011110000111100001111000011000000000000000011000011011001100110011000111100001111000001100000111100001111000110011001100110110000110000000000000000000110000001100000011000000110000001100000011000001111000011110001100110011001101100001100000000000000001111111100000011000000110000011000001100011111100011000001100000110000001100000011111111000000000000000000111100000011000000110000001100000011000000110000001100000011000000110000001100001111000000000011000000110000000110000001100000001100000011000000011000000110000000110000001100000001100000011000000000000000000011110000110000001100000011000000110000001100000011000000110000001100000011000000111100000000000000000000000000000000000000000000000000000000000000000000000000110000110110011000111100000110001111111111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000111000000110000001110000000000000000011111110110000111100001111111110110000001100001101111110000000000000000000000000000000000000000000000000011111111100001111000011110000111100001101111111000000110000001100000011000000110000001100000000000000000111111011000011000000110000001100000011110000110111111000000000000000000000000000000000000000000000000011111110110000111100001111000011110000111111111011000000110000001100000011000000110000000000000000000000111111100000001100000011011111111100001111000011011111100000000000000000000000000000000000000000000000000000110000001100000011000000110000001100001111110000110000001100000011001100110001111000011111101100001111000000110000001111111011000011110000111100001101111110000000000000000000000000000000000000000000000000110000111100001111000011110000111100001111000011011111110000001100000011000000110000001100000000000000000001100000011000000110000001100000011000000110000001100000000000000000000001100000000000000111000011011000110000001100000011000000110000001100000011000000110000000000000000000000110000000000000000000000000000011000110011001100011111000011110001101100110011011000110000001100000011000000110000001100000000000000000111111000011000000110000001100000011000000110000001100000011000000110000001100000011110000000000000000011011011110110111101101111011011110110111101101101111111000000000000000000000000000000000000000000000000011000110110001101100011011000110110001101100011001111110000000000000000000000000000000000000000000000000011111001100011011000110110001101100011011000110011111000000000000000000000000000000000000000110000001100000011011111111100001111000011110000111100001101111111000000000000000000000000000000001100000011000000110000001111111011000011110000111100001111000011111111100000000000000000000000000000000000000000000000000000001100000011000000110000001100000011000001110111111100000000000000000000000000000000000000000000000001111111110000001100000001111110000000110000001111111110000000000000000000000000000000000000000000000000001110000110110000001100000011000000110000001100001111110000110000001100000011000000000000000000000000000111111001100011011000110110001101100011011000110110001100000000000000000000000000000000000000000000000000011000001111000011110001100110011001101100001111000011000000000000000000000000000000000000000000000000110000111110011111111111110110111100001111000011110000110000000000000000000000000000000000000000000000001100001101100110001111000001100000111100011001101100001100000000000000000000000000000000000000110000011000000110000011000001100000111100011001100110011011000011000000000000000000000000000000000000000000000000111111110000011000001100000110000011000001100000111111110000000000000000000000000000000000000000000000001111000000011000000110000001100000011100000011110001110000011000000110000001100011110000000110000001100000011000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000000000011110001100000011000000110000011100011110000001110000001100000011000000110000000111100000000000000000000000000000000000000000000000000000000000000000000000000000000001110110110111000000000".split("")
end


def DrawAsciiCharacter(image, topx, topy, a, color)

	index = (a).ord
	index = index - 32.0
	allCharData = GetPixelFontData()

	basis = index*8.0*13.0

	y = 0.0
	while(y < 13.0)
		ybasis = basis + y*8.0
		x = 0.0
		while(x < 8.0)
			pixel = (allCharData[ybasis + x]).ord
			if pixel == ("1").ord
				DrawPixel(image, topx + 8.0 - 1.0 - x, topy + 13.0 - 1.0 - y, color)
			end
			x = x + 1.0
		end
		y = y + 1.0
	end
end


def GetTextWidth(text)

	charWidth = 8.0
	spacing = 2.0

	if text.length == 0.0
		width = 0.0
	else
		width = text.length*charWidth + (text.length - 1.0)*spacing
	end

	return width
end


def GetTextHeight(text)
	return 13.0
end


def DPIToDotsPerMm(dpi)
	return dpi.to_f / 25.4
end


def DotsPerMmDPI(dotsPerMm)
	return dotsPerMm*25.4
end


def MmToInch(mm)
	return mm.to_f / 25.4
end


def InchToMm(inch)
	return inch*25.4
end


def MmToDots(mm, dpi)
	return MmToInch(mm)*dpi
end


def DotsToMm(dots, dpi)
	return InchToMm(dots.to_f / dpi)
end


def PtsToInch(pts)
	return pts*1.0.to_f / 72.0
end


def InchToPts(inch)
	return inch*72.0
end


def PtsToMm(pts)
	return InchToMm(PtsToInch(pts))
end


def MmToPts(mm)
	return InchToPts(MmToInch(mm))
end


def ComputeReedSolomonCodes(data, eccs)

	rsDiv = ReedSolomonComputeDivisor(eccs)
	ecc = ReedSolomonComputeRemainder(data, rsDiv)

	return ecc
end


def ReedSolomonComputeDivisor(eccs)

	result = arraysCreateNumberArray(eccs, 0.0)
	result[result.length - 1.0] = 1.0

	root = 1.0
	i = 0.0
	while(i < eccs)
		j = 0.0
		while(j < result.length)
			result[j] = GaloisField2e8Mul(result[j], root, 285.0)
			if j + 1.0 < result.length
				result[j] = XorByte(result[j], result[j + 1.0])
			end
			j = j + 1.0
		end
		root = GaloisField2e8Mul(root, 2.0, 285.0)
		i = i + 1.0
	end

	return result
end


def ReedSolomonComputeRemainder(data, divisor)

	result = arraysCreateNumberArray(divisor.length, 0.0)

	i = 0.0
	while(i < data.length)
		b = data[i]

		factor = XorByte(b, result[0])

		j = 0.0
		while(j < result.length - 1.0)
			result[j] = result[j + 1.0]
			j = j + 1.0
		end
		result[j] = 0.0

		j = 0.0
		while(j < divisor.length)
			coef = divisor[j]
			result[j] = XorByte(result[j], GaloisField2e8Mul(coef, factor, 285.0))
			j = j + 1.0
		end
		i = i + 1.0
	end

	return result
end


def ComputeBHC15_5Code(data)

	# x^10 + x^8 + x^5 + x^4 + x^2 + x + 1 is encoded as 10100110111b = 1335
	gp = 1335.0

	i = 0.0
	while(i < 10.0)
		data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 9.0)*gp)
		i = i + 1.0
	end

	return data
end


def ComputeBHC18_6Code(data)

	# x^12 + x^11 + x^10 + x^9 + x^8 + x^5 + x^2 + 1 is encoded as 1111100100101b = 7973
	gp = 7973.0

	i = 0.0
	while(i < 12.0)
		data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 11.0)*gp)
		i = i + 1.0
	end

	return data
end


def And4Byte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned4Bytes(a)
	b = ToUnsigned4Bytes(b)

	i = 0.0
	while(i < 32.0)
		ab = a%2.0
		bb = b%2.0

		if ab == 1.0 && bb == 1.0
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def ToUnsigned4Bytes(a)
	if a < 0.0
		a = 4294967296.0 - Truncate((-a)%4294967296.0)
	else
		a = Truncate(a%4294967296.0)
	end
	return a
end


def ToUnsigned2Bytes(a)
	if a < 0.0
		a = 65536.0 - Truncate((-a)%65536.0)
	else
		a = Truncate(a%65536.0)
	end
	return a
end


def ToUnsignedByte(a)
	if a < 0.0
		a = 256.0 - Truncate((-a)%256.0)
	else
		a = Truncate(a%256.0)
	end
	return a
end


def And2Byte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned2Bytes(a)
	b = ToUnsigned2Bytes(b)

	i = 0.0
	while(i < 16.0)
		ab = a%2.0
		bb = b%2.0

		if ab == 1.0 && bb == 1.0
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def AndByte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsignedByte(a)
	b = ToUnsignedByte(b)

	i = 0.0
	while(i < 8.0)
		ab = a%2.0
		bb = b%2.0

		if ab == 1.0 && bb == 1.0
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def Or4Byte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned4Bytes(a)
	b = ToUnsigned4Bytes(b)

	i = 0.0
	while(i < 32.0)
		ab = a%2.0
		bb = b%2.0

		if ab == 1.0 || bb == 1.0
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def Or2Byte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned2Bytes(a)
	b = ToUnsigned2Bytes(b)

	i = 0.0
	while(i < 16.0)
		ab = a%2.0
		bb = b%2.0

		if ab == 1.0 || bb == 1.0
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def OrByte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsignedByte(a)
	b = ToUnsignedByte(b)

	i = 0.0
	while(i < 8.0)
		ab = a%2.0
		bb = b%2.0

		if ab == 1.0 || bb == 1.0
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def Xor4Byte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned4Bytes(a)
	b = ToUnsigned4Bytes(b)

	i = 0.0
	while(i < 32.0)
		ab = a%2.0
		bb = b%2.0

		if ab != bb
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def Xor2Byte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsigned2Bytes(a)
	b = ToUnsigned2Bytes(b)

	i = 0.0
	while(i < 16.0)
		ab = a%2.0
		bb = b%2.0

		if ab != bb
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def XorByte(a, b)

	byteVal = 1.0
	result = 0.0

	a = ToUnsignedByte(a)
	b = ToUnsignedByte(b)

	i = 0.0
	while(i < 8.0)
		ab = a%2.0
		bb = b%2.0

		if ab != bb
			result = result + byteVal
		end

		a = (a.to_f / 2.0).floor
		b = (b.to_f / 2.0).floor
		byteVal = byteVal*2.0
		i = i + 1.0
	end

	return result
end


def Not4Byte(a)

	a = ToUnsigned4Bytes(a)

	result = 4294967296.0 - a - 1.0

	return result
end


def Not2Byte(a)

	a = ToUnsigned2Bytes(a)

	result = 65536.0 - a - 1.0

	return result
end


def NotByte(a)

	a = ToUnsignedByte(a)

	result = 256.0 - a - 1.0

	return result
end


def ShiftLeft4Byte(a, n)

	a = Truncate(a%4294967296.0)
	n = Truncate([n, 0.0].max)

	result = a*2.0**n

	return result
end


def ShiftLeft2Byte(a, n)

	a = Truncate(a%65536.0)
	n = Truncate([n, 0.0].max)

	result = a*2.0**n

	return result
end


def ShiftLeftByte(a, n)

	a = Truncate(a%256.0)
	n = Truncate([n, 0.0].max)

	result = a*2.0**n

	return result
end


def ShiftRight4Byte(a, n)

	a = Truncate(a%4294967296.0)
	n = Truncate([n, 0.0].max)

	result = Truncate(a.to_f / 2.0**n)

	return result
end


def ShiftRight2Byte(a, n)

	a = Truncate(a%65536.0)
	n = Truncate([n, 0.0].max)

	result = Truncate(a.to_f / 2.0**n)

	return result
end


def ShiftRightByte(a, n)

	a = Truncate(a%256.0)
	n = Truncate([n, 0.0].max)

	result = Truncate(a.to_f / 2.0**n)

	return result
end


def RotateLeft4Byte(a, n)

	a = ToUnsigned4Bytes(a)
	n = Truncate(n)

	#return (a << n) | (a >> (32 - n));
	# Mask the upper bits first, then rotate.
	x = And4Byte(a, Not4Byte(ShiftLeft4Byte(1.0, n) - 1.0))
	x = Or4Byte(ShiftLeft4Byte(x, n), ShiftRight4Byte(a, (32.0 - n)))

	return x
end


def RotateRight4Byte(a, n)

	a = ToUnsigned4Bytes(a)
	n = Truncate(n)

	# return (a >> d) | (a << (32 - n));
	# Mask away the upper bits first, then perform the shift.
	x = And4Byte(a, ShiftLeft4Byte(1.0, n) - 1.0)
	x = Or4Byte(ShiftRight4Byte(a, n), ShiftLeft4Byte(x, 32.0 - n))

	return x
end


def CreateBooleanArrayFromNumber(w, size)

	out = arraysCreateBooleanArray(size, false)

	j = 0.0
	p = 1.0
	while(p < w)
		p = p*2.0
		j = j + 1.0
	end

	while(j >= 0.0)
		if w >= p
			w = w - p
			if j < size
				out[size - 1.0 - j] = true
			end
		end
		p = p.to_f / 2.0
		j = j - 1.0
	end

	return out
end


def BooleanArrayToNumber(bits)

	w = 0.0
	p = 1.0
	i = 31.0
	while(i >= 0.0)
		if bits[i]
			w = w + p
		end
		p = p*2.0
		i = i - 1.0
	end

	return w
end


def BooleanAnd(a, b)

	lengthx = a.length

	out = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		out[i] = a[i] && b[i]
		i = i + 1.0
	end
	return out
end


def BooleanXor(a, b)

	lengthx = a.length

	out = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		if a[i] || b[i]
			if !(a[i] && b[i])
				out[i] = true
			end
		end
		i = i + 1.0
	end
	return out
end


def BooleanNot(a)

	lengthx = a.length

	out = Array.new(lengthx)

	i = 0.0
	while(i < lengthx)
		out[i] = !a[i]
		i = i + 1.0
	end
	return out
end


def ShiftBitsRight4Byte(w, n)
	f = false

	if n == 0.0
		ob = w
	else
		wb = w
		ob = Array.new(32)

		i = 0.0
		while(i < 32.0)
			it = i - n

			if it < 0.0
				f = false
			else
				f = wb[it]
			end

			ob[i] = f
			i = i + 1.0
		end
	end

	return ob
end


def ReadNextBit(data, nextbit)

	bytenr = (nextbit.numberValue.to_f / 8.0).floor
	bitnumber = nextbit.numberValue%8.0

	b = data[bytenr]

	bit = (b.to_f / 2.0**bitnumber).floor%2.0

	nextbit.numberValue = nextbit.numberValue + 1.0

	return bit
end


def BitExtract(b, fromInc, toInc)
	return (b.to_f / 2.0**fromInc).floor%2.0**(toInc + 1.0 - fromInc)
end


def ReadBitRange(data, nextbit, lengthx)

	number = 0.0

	startbyte = (nextbit.numberValue.to_f / 8.0).floor
	endbyte = ((nextbit.numberValue + lengthx).to_f / 8.0).floor

	startbit = nextbit.numberValue%8.0
	endbit = (nextbit.numberValue + lengthx - 1.0)%8.0

	if startbyte == endbyte
		number = BitExtract(data[startbyte], startbit, endbit)
	end

	nextbit.numberValue = nextbit.numberValue + lengthx

	return number
end


def SkipToBoundary(nextbit)

	skip = 8.0 - nextbit.numberValue%8.0
	nextbit.numberValue = nextbit.numberValue + skip
end


def ReadNextByteBoundary(data, nextbit)

	bytenr = (nextbit.numberValue.to_f / 8.0).floor
	b = data[bytenr]
	nextbit.numberValue = nextbit.numberValue + 8.0

	return b
end


def Read2bytesByteBoundary(data, nextbit)

	r = 0.0
	r = r + 2.0**8.0*ReadNextByteBoundary(data, nextbit)
	r = r + ReadNextByteBoundary(data, nextbit)

	return r
end


def QuickSortStrings(list)
	QuickSortStringsBounds(list, 0.0, list.stringArray.length - 1.0)
end


def QuickSortStringsBounds(a, lo, hi)

	if lo < hi
		p = QuickSortStringsPartition(a, lo, hi)
		QuickSortStringsBounds(a, lo, p - 1.0)
		QuickSortStringsBounds(a, p + 1.0, hi)
	end
end


def QuickSortStringsPartition(a, lo, hi)

	pivot = a.stringArray[hi].string
	i = lo - 1.0
	j = lo
	while(j <= hi - 1.0)
		if strStringIsBefore(a.stringArray[j].string, pivot)
			i = i + 1.0
			arraysSwapElementsOfStringArray(a, i, j)
		end
		j = j + 1.0
	end
	arraysSwapElementsOfStringArray(a, i + 1.0, hi)

	return i + 1.0
end


def QuickSortStringsWithIndexes(a)

	indexes = Array.new(a.stringArray.length)

	i = 0.0
	while(i < a.stringArray.length)
		indexes[i] = i
		i = i + 1.0
	end

	QuickSortStringsBoundsWithIndexes(a, indexes, 0.0, a.stringArray.length - 1.0)

	return indexes
end


def QuickSortStringsBoundsWithIndexes(a, indexes, lo, hi)

	if lo < hi
		p = QuickSortStringsPartitionWithIndexes(a, indexes, lo, hi)
		QuickSortStringsBoundsWithIndexes(a, indexes, lo, p - 1.0)
		QuickSortStringsBoundsWithIndexes(a, indexes, p + 1.0, hi)
	end
end


def QuickSortStringsPartitionWithIndexes(a, indexes, lo, hi)

	pivot = a.stringArray[hi].string
	i = lo - 1.0
	j = lo
	while(j <= hi - 1.0)
		if strStringIsBefore(a.stringArray[j].string, pivot)
			i = i + 1.0
			arraysSwapElementsOfStringArray(a, i, j)
			arraysSwapElementsOfNumberArray(indexes, i, j)
		end
		j = j + 1.0
	end
	arraysSwapElementsOfStringArray(a, i + 1.0, hi)
	arraysSwapElementsOfNumberArray(indexes, i + 1.0, hi)

	return i + 1.0
end


def QuickSortNumbers(list)
	QuickSortNumbersBounds(list, 0.0, list.length - 1.0)
end


def QuickSortNumbersBounds(a, lo, hi)

	if lo < hi
		p = QuickSortNumbersPartition(a, lo, hi)
		QuickSortNumbersBounds(a, lo, p - 1.0)
		QuickSortNumbersBounds(a, p + 1.0, hi)
	end
end


def QuickSortNumbersPartition(a, lo, hi)

	pivot = a[hi]
	lowPos = lo
	j = lo
	while(j <= hi - 1.0)
		if a[j] < pivot
			arraysSwapElementsOfNumberArray(a, lowPos, j)
			lowPos = lowPos + 1.0
		end
		j = j + 1.0
	end
	arraysSwapElementsOfNumberArray(a, lowPos, hi)

	return lowPos
end


def QuickSortNumbersWithIndexes(a)

	indexes = Array.new(a.length)

	i = 0.0
	while(i < a.length)
		indexes[i] = i
		i = i + 1.0
	end

	QuickSortNumbersBoundsWithIndexes(a, indexes, 0.0, a.length - 1.0)

	return indexes
end


def QuickSortNumbersBoundsWithIndexes(a, indexes, lo, hi)

	if lo < hi
		p = QuickSortNumbersPartitionWithIndexes(a, indexes, lo, hi)
		QuickSortNumbersBoundsWithIndexes(a, indexes, lo, p - 1.0)
		QuickSortNumbersBoundsWithIndexes(a, indexes, p + 1.0, hi)
	end
end


def QuickSortNumbersPartitionWithIndexes(a, indexes, lo, hi)

	pivot = a[hi]
	i = lo - 1.0
	j = lo
	while(j <= hi - 1.0)
		if a[j] < pivot
			i = i + 1.0
			arraysSwapElementsOfNumberArray(a, i, j)
			arraysSwapElementsOfNumberArray(indexes, i, j)
		end
		j = j + 1.0
	end
	arraysSwapElementsOfNumberArray(a, i + 1.0, hi)
	arraysSwapElementsOfNumberArray(indexes, i + 1.0, hi)

	return i + 1.0
end


def Add(a, b)

	r = NumberOfRows(a)
	c = NumberOfColumns(a)
	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			a.r[m].c[n] = Element(a, m, n) + Element(b, m, n)
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def Assign(a, b)

	r = NumberOfRows(a)
	c = NumberOfColumns(a)
	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			a.r[m].c[n] = Element(b, m, n)
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def Resize(a, r, c)

	c = CreateMatrix(r, c)

	ar = NumberOfRows(a)
	ac = NumberOfColumns(a)

	m = 0.0
	while(m < [r, ar].min)
		n = 0.0
		while(n < [c, ac].min)
			c.r[m].c[n] = Element(a, m, n)
			n = n + 1.0
		end
		m = m + 1.0
	end

	FreeMatrixRows(a.r)
	a.r = c.r
end


def Subtract(a, b)

	r = NumberOfRows(a)
	c = NumberOfColumns(a)
	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			a.r[m].c[n] = Element(a, m, n) - Element(b, m, n)
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def SubtractToNew(a, b)

	x = CreateCopyOfMatrix(a)
	Subtract(x, b)

	return x
end


def ScalarMultiply(a, b)

	r = NumberOfRows(a)
	c = NumberOfColumns(a)
	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			a.r[m].c[n] = b*a.r[m].c[n]
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def ScalarDivide(a, b)

	r = NumberOfRows(a)
	c = NumberOfColumns(a)
	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			a.r[m].c[n] = Element(a, m, n).to_f / b
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def ElementWisePower(a, p)

	r = NumberOfRows(a)
	c = NumberOfColumns(a)

	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			a.r[m].c[n] = a.r[m].c[n]**p
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def ScalarMultiplyToNew(a, b)

	matrix = CreateCopyOfMatrix(a)
	ScalarMultiply(matrix, b)

	return matrix
end


def MultiplyToNew(a, b)

	rows = NumberOfRows(a)
	cols = NumberOfColumns(b)
	x = CreateMatrix(rows, cols)
	Multiply(x, a, b)

	return x
end


def Multiply(x, a, b)

	rows = NumberOfRows(a)
	cols = NumberOfColumns(b)
	d = NumberOfColumns(a)

	m = 0.0
	while(m < rows)
		n = 0.0
		while(n < cols)
			s = 0.0

			i = 0.0
			while(i < d)
				s = s + a.r[m].c[i]*b.r[i].c[n]
				i = i + 1.0
			end

			x.r[m].c[n] = s
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def CreateSquareMatrix(d)

	matrix = Matrix.new
	matrix.r = Array.new(d)
	m = 0.0
	while(m < d)
		matrix.r[m] = MatrixRow.new
		matrix.r[m].c = Array.new(d)
		n = 0.0
		while(n < d)
			matrix.r[m].c[n] = 0.0
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def CreateMatrix(rows, cols)

	matrix = Matrix.new
	matrix.r = Array.new(rows)
	m = 0.0
	while(m < rows)
		matrix.r[m] = MatrixRow.new
		matrix.r[m].c = Array.new(cols)
		n = 0.0
		while(n < cols)
			matrix.r[m].c[n] = 0.0
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def CreateIdentityMatrix(d)

	matrix = CreateSquareMatrix(d)
	Fill(matrix, 0.0)

	m = 0.0
	while(m < d)
		matrix.r[m].c[m] = 1.0
		m = m + 1.0
	end

	return matrix
end


def Transpose(a)

	ap = TransposeToNew(a)

	FreeMatrixRows(a.r)
	a.r = ap.r
end


def TransposeAssign(t, a)

	cols = NumberOfRows(a)
	rows = NumberOfColumns(a)

	m = 0.0
	while(m < cols)
		n = 0.0
		while(n < rows)
			t.r[n].c[m] = a.r[m].c[n]
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def TransposeToNew(a)

	cols = NumberOfRows(a)
	rows = NumberOfColumns(a)

	c = CreateMatrix(rows, cols)

	m = 0.0
	while(m < cols)
		n = 0.0
		while(n < rows)
			c.r[n].c[m] = a.r[m].c[n]
			n = n + 1.0
		end
		m = m + 1.0
	end

	return c
end


def CofactorOfMatrix(mat, temp, p, q, n)

	i = 0.0
	j = 0.0

	row = 0.0
	while(row < n)
		col = 0.0
		while(col < n)
			if row != p && col != q
				temp.r[i].c[j] = mat.r[row].c[col]
				j = j + 1.0

				if j == n - 1.0
					j = 0.0
					i = i + 1.0
				end
			end
			col = col + 1.0
		end
		row = row + 1.0
	end
end


def DeterminantOfSubmatrix(mat, n)

	d = 0.0

	if n == 1.0
		d = mat.r[0].c[0]
	else
		temp = CreateSquareMatrix(n)

		sign = 1.0

		f = 0.0
		while(f < n)
			CofactorOfMatrix(mat, temp, 0.0, f, n)
			d = d + sign*mat.r[0].c[f]*DeterminantOfSubmatrix(temp, n - 1.0)
			sign = -sign
			f = f + 1.0
		end

		FreeMatrix(temp)
	end

	return d
end


def Determinant(m)

	n = NumberOfRows(m)
	d = DeterminantOfSubmatrix(m, n)

	return d
end


def Adjoint(a, adj)

	n = a.r.length

	if n == 1.0
		adj.r[0].c[0] = 1.0
	else
		cofactors = CreateSquareMatrix(n)

		i = 0.0
		while(i < n)
			j = 0.0
			while(j < n)
				CofactorOfMatrix(a, cofactors, i, j, n)

				if (i + j)%2.0 == 0.0
					sign = 1.0
				else
					sign = -1.0
				end

				adj.r[j].c[i] = sign*DeterminantOfSubmatrix(cofactors, n - 1.0)
				j = j + 1.0
			end
			i = i + 1.0
		end

		FreeMatrix(cofactors)
	end
end


def Inverse(a, inverseResult)
	return InverseUsingLUDecomposition(a, inverseResult)
end


def InverseUsingAdjoint(a, inverseResult)

	if NumberOfColumns(a) == NumberOfRows(a)
		n = NumberOfColumns(a)

		det = Determinant(a)
		if det != 0.0
			adj = CreateSquareMatrix(n)
			Adjoint(a, adj)

			i = 0.0
			while(i < n)
				j = 0.0
				while(j < n)
					inverseResult.r[i].c[j] = adj.r[i].c[j].to_f / det
					j = j + 1.0
				end
				i = i + 1.0
			end

			success = true
			FreeMatrix(adj)
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def InverseUsingLUDecomposition(a, inverseResult)

	l = CreateCopyOfMatrix(a)
	u = CreateCopyOfMatrix(a)
	li = CreateCopyOfMatrix(a)
	ui = CreateCopyOfMatrix(a)
	inverseResult.r = CreateCopyOfMatrix(a).r

	success = LUDecomposition(a, l, u)
	if success
		success = InvertLowerTriangularMatrix(l, li)
		if success
			success = InvertUpperTriangularMatrix(u, ui)
			if success
				Multiply(inverseResult, ui, li)
			end
		end
	end

	FreeMatrix(l)
	FreeMatrix(u)
	FreeMatrix(li)
	FreeMatrix(ui)

	return success
end


def LUDecomposition(a, l, u)

	n = NumberOfRows(a)

	l.r = CreateSquareMatrix(n).r
	u.r = CreateSquareMatrix(n).r

	if IsSquare(a)
		success = true

		i = 0.0
		while(i < n && success)
			k = i
			while(k < n)
				sum = 0.0
				j = 0.0
				while(j < i)
					sum = sum + (Element(l, i, j)*Element(u, j, k))
					j = j + 1.0
				end

				u.r[i].c[k] = Element(a, i, k) - sum
				k = k + 1.0
			end

			k = i
			while(k < n && success)
				if i == k
					l.r[i].c[i] = 1.0
				else
					sum = 0.0
					j = 0.0
					while(j < i)
						sum = sum + (Element(l, k, j)*Element(u, j, i))
						j = j + 1.0
					end

					if Element(u, i, i) == 0.0
						success = false
					else
						l.r[k].c[i] = (Element(a, k, i) - sum).to_f / Element(u, i, i)
					end
				end
				k = k + 1.0
			end
			i = i + 1.0
		end
	else
		success = false
	end

	return success
end


def IsSymmetric(a)

	n = NumberOfRows(a)

	done = false
	is = true
	i = 0.0
	while(i < n && !done)
		j = 0.0
		while(j < i && !done)
			if a.r[i].c[j] != a.r[j].c[i]
				is = false
				done = true
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	return is
end


def IsSquare(a)

	if NumberOfRows(a) == NumberOfColumns(a)
		is = true
	else
		is = false
	end

	return is
end


def Cholesky(a, l)

	Clear(l)

	if IsSquare(a) && IsSymmetric(a)
		success = true

		n = NumberOfRows(a)

		i = 0.0
		while(i < n && success)
			j = 0.0
			while(j <= i && success)
				s = 0.0
				k = 0.0
				while(k < j)
					s = s + l.r[i].c[k]*l.r[j].c[k]
					k = k + 1.0
				end
				if i == j
					l.r[i].c[i] = Math.sqrt(a.r[i].c[i] - s)
				else
					l.r[i].c[j] = 1.0.to_f / l.r[j].c[j]*(a.r[i].c[j] - s)
				end
				j = j + 1.0
			end
			if l.r[i].c[i] <= 0.0
				success = false
			end
			i = i + 1.0
		end

		success = true
	else
		success = false
	end

	return success
end


def Clear(a)
	Fill(a, 0.0)
end


def Fill(a, value)

	m = 0.0
	while(m < NumberOfRows(a))
		n = 0.0
		while(n < NumberOfColumns(a))
			a.r[m].c[n] = value
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def Element(matrix, m, n)
	return matrix.r[m].c[n]
end


def Trace(a)

	tr = 0.0

	d = a.r.length
	m = 0.0
	while(m < d)
		tr = tr + a.r[m].c[m]
		m = m + 1.0
	end

	return tr
end


def ColumnCombineMatricesToNew(a, b)

	x = CreateMatrix(NumberOfRows(a), NumberOfColumns(a) + NumberOfColumns(b))

	m = 0.0
	while(m < NumberOfRows(a))
		n = 0.0
		while(n < NumberOfColumns(a))
			x.r[m].c[n] = a.r[m].c[n]
			n = n + 1.0
		end
		m = m + 1.0
	end

	m = 0.0
	while(m < NumberOfRows(b))
		n = 0.0
		while(n < NumberOfColumns(b))
			x.r[m].c[NumberOfColumns(a) + n] = b.r[m].c[n]
			n = n + 1.0
		end
		m = m + 1.0
	end

	return x
end


def NumberOfRows(a)
	return a.r.length
end


def NumberOfColumns(a)
	return a.r[0].c.length
end


def CharacteristicPolynomial(a)

	dummy = CreateSquareMatrix(NumberOfRows(a))

	coeffs = NumberArrayReference.new
	determinant = NumberReference.new
	CharacteristicPolynomialWithInverse(a, dummy, coeffs, determinant)

	FreeMatrix(dummy)

	return coeffs.numberArray
end


def CharacteristicPolynomialWithInverse(a, aInverse, cp, determinant)
	FaddeevLeVerrierAlgorithm(a, aInverse, cp, determinant)
end


def FaddeevLeVerrierAlgorithm(a, aInverse, cp, determinant)

	n = NumberOfRows(a)
	p = Array.new(n + 1.0)
	p[n] = 1.0
	mkm1 = CreateSquareMatrix(n)
	Fill(mkm1, 0.0)
	i = CreateIdentityMatrix(n)
	mk = CreateSquareMatrix(n)
	t1 = CreateSquareMatrix(n)

	k = 1.0
	while(k <= n)
		# M_k = A * M_(k-1) + c_(n-k+1) * I
		Multiply(mk, a, mkm1)
		Assign(t1, i)
		ScalarMultiply(t1, p[n - k + 1.0])
		Add(mk, t1)

		# c_(n-k) = -1/k * trace(A * M_k)
		Multiply(t1, a, mk)
		p[n - k] = -1.0.to_f / k*Trace(t1)

		# done
		Assign(mkm1, mk)

		if k == n
			Assign(aInverse, mk)
			determinant.numberValue = -p[0]
			if p[0] == 0.0
			else
				ScalarDivide(aInverse, determinant.numberValue)
			end
		end
		k = k + 1.0
	end

	FreeMatrix(mkm1)
	FreeMatrix(i)
	FreeMatrix(mk)
	FreeMatrix(t1)

	cp.numberArray = p
end


def InverseUsingCharacteristicPolynomial(a)

	inverse = CreateSquareMatrix(NumberOfRows(a))
	coeffs = NumberArrayReference.new
	determinant = NumberReference.new
	CharacteristicPolynomialWithInverse(a, inverse, coeffs, determinant)
	delete(coeffs.numberArray)
	delete(coeffs)

	return inverse
end


def Eigenvalues(a, eigenValuesReference)

	eigenVectorsReference = MatrixArrayReference.new
	success = Eigenpairs(a, eigenValuesReference, eigenVectorsReference)
	if success
		i = 0.0
		while(i < eigenVectorsReference.matrices.length)
			FreeMatrix(eigenVectorsReference.matrices[i])
			i = i + 1.0
		end
		delete(eigenVectorsReference.matrices)
		delete(eigenVectorsReference)
	end

	return success
end


def EigenvaluesUsingQRAlgorithm(a, eigenValuesReference, precision, maxIterations)

	n = NumberOfRows(a)
	x = CreateSquareMatrix(n)
	q = CreateSquareMatrix(n)
	r = CreateSquareMatrix(n)
	eigenValuesReference.numberArray = Array.new(n)
	success = QRAlgorithm(a, r, x, q, precision, maxIterations)
	found = 0.0
	if success
		ExtractDiagonal(x, eigenValuesReference.numberArray)

		# find the correct sign of the eigenvalue.
		cp = CharacteristicPolynomial(a)
		i = 0.0
		while(i < n)
			ev = eigenValuesReference.numberArray[i]

			v1 = pEvaluate(cp, ev)
			v2 = pEvaluate(cp, -ev)

			if (v2).abs < (v1).abs
				eigenValuesReference.numberArray[i] = -ev
				v = v2
			else
				v = v1
			end

			if (v).abs < precision*10.0**4.0
				found = found + 1.0
			end
			i = i + 1.0
		end

		FreeMatrix(x)
		FreeMatrix(q)
		FreeMatrix(r)
	end

	if found != n
		success = false
	end

	return success
end


def EigenvaluesUsingLaguerreIterations(a, eigenValuesReference)

	p = CharacteristicPolynomial(a)
	success = FindRoots(p, eigenValuesReference)

	return success
end


def GaussianElimination(a)

	m = NumberOfRows(a)
	n = NumberOfColumns(a)

	h = 0.0
	k = 0.0
	while(h < m && k < n)
		maxElement = h
		max = 0.0
		i = h
		while(i < m)
			maxCandidate = (Element(a, i, k)).abs
			if max < maxCandidate
				maxElement = i
				max = maxCandidate
			end
			i = i + 1.0
		end
		if a.r[maxElement].c[k] == 0.0
			k = k + 1.0
		else
			SwapRows(a, h, maxElement)
			i = h + 1.0
			while(i < m)
				f = Element(a, i, k).to_f / Element(a, h, k)
				a.r[i].c[k] = 0.0
				j = k + 1.0
				while(j < n)
					a.r[i].c[j] = Element(a, i, j) - Element(a, h, j)*f
					j = j + 1.0
				end
				i = i + 1.0
			end
			h = h + 1.0
			k = k + 1.0
		end
	end
end


def GaussianEliminationToNew(a)

	x = CreateCopyOfMatrix(a)
	GaussianElimination(x)

	return x
end


def CreateCopyOfMatrix(a)

	x = CreateMatrix(NumberOfRows(a), NumberOfColumns(a))
	Assign(x, a)

	return x
end


def SwapRows(a, to, from)

	c = NumberOfRows(a)
	n = 0.0
	while(n < c)
		t = a.r[to].c[n]
		a.r[to].c[n] = a.r[from].c[n]
		a.r[from].c[n] = t
		n = n + 1.0
	end
end


def UnnormalizeVector(numberArray)

	mSet = false
	m = 0.0

	i = 0.0
	while(i < numberArray.length)
		if numberArray[i] - Truncate(numberArray[i]) < 0.001
			if !mSet
				m = (numberArray[i]).abs
				mSet = true
			else
				m = [m, (numberArray[i]).abs].min
			end
		end
		i = i + 1.0
	end

	if mSet
		i = 0.0
		while(i < numberArray.length)
			numberArray[i] = numberArray[i].to_f / m
			i = i + 1.0
		end
	end
end


def InversePowerMethod(a, eigenvalue, maxIterations, eigenvector)

	n = NumberOfRows(a)

	x = CreateIdentityMatrix(n)
	ScalarMultiply(x, eigenvalue)
	y = SubtractToNew(a, x)
	z = CreateSquareMatrix(n)
	singular = !Inverse(y, z)
	if singular
		# Try again with more erroneous eigenvalue estimate.
		x = CreateIdentityMatrix(n)
		ScalarMultiply(x, eigenvalue*1.01)
		y = SubtractToNew(a, x)
		z = CreateSquareMatrix(n)
		singular = !Inverse(y, z)
	end

	if !singular
		b = CreateMatrix(n, 1.0)

		i = 0.0
		while(i < n)
			b.r[i].c[0] = 1.0
			i = i + 1.0
		end

		i = 0.0
		while(i < maxIterations)
			t = MultiplyToNew(z, b)
			c = Norm(t)
			ScalarDivide(t, c)
			Assign(b, t)
			i = i + 1.0
		end

		eigenvector.numberArray = Array.new(n)
		i = 0.0
		while(i < n)
			eigenvector.numberArray[i] = b.r[i].c[0]
			i = i + 1.0
		end
	end

	return !singular
end


def Eigenvectors(a, eigenVectorsReference)

	evsReference = NumberArrayReference.new
	success = Eigenpairs(a, evsReference, eigenVectorsReference)
	if success
		delete(evsReference.numberArray)
		delete(evsReference)
	end

	return success
end


def Eigenpairs(a, eigenValuesReference, eigenVectorsReference)
	return EigenpairsUsingQRAlgorithmAndInversePowerMethod(a, eigenValuesReference, eigenVectorsReference, 0.00000000001, 100.0)
end


def EigenpairsUsingQRAlgorithmAndInversePowerMethod(m, eigenValuesReference, eigenVectorsReference, precision, maxIterations)

	n = NumberOfRows(m)

	a = CreateCopyOfMatrix(m)
	q = CreateCopyOfMatrix(m)
	r = CreateCopyOfMatrix(m)

	done = false
	eigenVectorsReference.matrices = Array.new(n)
	evecReference = NumberArrayReference.new
	eigenValuesReference.numberArray = Array.new(n)
	cp = CharacteristicPolynomial(m)

	j = 0.0
	while(j < n)
		eigenVectorsReference.matrices[j] = CreateMatrix(n, 1.0)
		j = j + 1.0
	end

	i = 0.0
	while(i < maxIterations && !done)
		QRDecomposition(a, q, r)
		Multiply(a, r, q)

		# Check
		withinPrecision = 0.0
		ExtractDiagonal(r, eigenValuesReference.numberArray)

		j = 0.0
		while(j < n)
			# Find the correct sign of the eigenvalue.
			eigenValue = eigenValuesReference.numberArray[j]
			v1 = pEvaluate(cp, eigenValue)
			v2 = pEvaluate(cp, -eigenValue)
			if (v2).abs < (v1).abs
				eigenValuesReference.numberArray[j] = -eigenValue
				eigenValue = -eigenValue
			end

			# Calculate the eigenvector corresponding to the eigenvalue.
			inverseSuccess = InversePowerMethod(m, eigenValue, i + 1.0, evecReference)
			if inverseSuccess
				k = 0.0
				while(k < n)
					eigenVectorsReference.matrices[j].r[k].c[0] = evecReference.numberArray[k]
					k = k + 1.0
				end

				# Check eigenpair agains precision.
				eigenVector = eigenVectorsReference.matrices[j]

				if CheckEigenpairPrecision(m, eigenValue, eigenVector, precision)
					withinPrecision = withinPrecision + 1.0
				end
			end
			j = j + 1.0
		end

		if withinPrecision == n
			done = true
		end
		i = i + 1.0
	end

	FreeMatrix(a)
	FreeMatrix(q)
	FreeMatrix(r)
	delete(evecReference)
	delete(cp)

	return done
end


def CheckEigenpairPrecision(a, lambda, e, precision)

	vec1 = MultiplyToNew(a, e)
	vec2 = ScalarMultiplyToNew(e, lambda)

	equal = MatrixEqualsEpsilon(vec1, vec2, precision)

	return equal
end


def EigenvectorsLaguerreIterationsAndGaussianEliminations(a, eigenVectorsReference)

	n = NumberOfRows(a)

	eigenValuesReference = NumberArrayReference.new
	success = Eigenvalues(a, eigenValuesReference)

	eigenVectorsResult = Array.new(n)

	if success
		ev = eigenValuesReference.numberArray

		id = CreateIdentityMatrix(n)
		t1 = CreateSquareMatrix(n)
		b = CreateSquareMatrix(n)

		j = 0.0
		while(j < ev.length && success)
			lambda = ev[j]

			# B = A - lambda * Id
			Assign(t1, id)
			ScalarMultiply(t1, lambda)

			Assign(b, a)
			Subtract(b, t1)

			GaussianElimination(b)

			v = CreateMatrix(n, 1.0)
			v.r[n - 1.0].c[0] = 1.0
			i = n - 2.0
			while(i >= 0.0 && success)
				if !RowIsZero(b, i)
					x = 0.0

					k = n - 1.0
					while(k > i)
						x = x - Element(b, i, k)*Element(v, k, 0.0)
						k = k - 1.0
					end

					v.r[i].c[0] = x.to_f / Element(b, i, i)
				else
					success = false
				end
				i = i - 1.0
			end

			eigenVectorsResult[j] = v
			j = j + 1.0
		end

		FreeMatrix(t1)
		FreeMatrix(b)
		FreeMatrix(id)

		eigenVectorsReference.matrices = eigenVectorsResult
	end

	return success
end


def RowIsZero(x, r)

	isZero = true

	columns = NumberOfColumns(x)
	i = 0.0
	while(i < columns && isZero)
		if Element(x, r, i) != 0.0
			isZero = false
		end
		i = i + 1.0
	end

	return isZero
end


def FreeMatrix(x)
	FreeMatrixRows(x.r)
	delete(x)
end


def FreeMatrixRows(r)

	rows = r.length
	m = 0.0
	while(m < rows)
		delete(r[m].c)
		delete(r[m])
		m = m + 1.0
	end

	delete(r)
end


def CreateDiagonalMatrixFromArray(array)

	matrix = CreateSquareMatrix(array.length)
	Fill(matrix, 0.0)

	m = 0.0
	while(m < array.length)
		matrix.r[m].c[m] = array[m]
		m = m + 1.0
	end

	return matrix
end


def CreateMatrixFromRowCopies(row, times)

	matrix = CreateMatrix(times, row.length)

	m = 0.0
	while(m < times)
		n = 0.0
		while(n < row.length)
			matrix.r[m].c[n] = row[n]
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def ExtractDiagonal(x, diag)

	n = NumberOfRows(x)

	i = 0.0
	while(i < n)
		diag[i] = x.r[i].c[i]
		i = i + 1.0
	end
end


def ExtractDiagonalToNew(x)

	n = NumberOfRows(x)
	diag = Array.new(n)

	i = 0.0
	while(i < n)
		diag[i] = x.r[i].c[i]
		i = i + 1.0
	end

	return diag
end


def MatrixEqualsEpsilon(a, b, epsilon)

	equals = true

	if NumberOfRows(a) == NumberOfRows(b) && NumberOfColumns(a) == NumberOfColumns(b)
		columns = NumberOfColumns(a)
		rows = NumberOfRows(a)

		x = 0.0
		while(x < rows)
			y = 0.0
			while(y < columns)
				equals = equals && EpsilonCompare(Element(a, x, y), Element(b, x, y), epsilon)
				y = y + 1.0
			end
			x = x + 1.0
		end
	else
		equals = false
	end

	return equals
end


def Minor(x, row, column)

	rows = NumberOfRows(x) - 1.0
	cols = NumberOfColumns(x) - 1.0

	theMinor = CreateMatrix(rows, cols)

	i = 0.0
	while(i < rows)
		if i < row
			m = i
		else
			m = i + 1.0
		end

		j = 0.0
		while(i != row && j < cols)
			if j != column

				if j < column
					n = j
				else
					n = j + 1.0
				end

				theMinor.r[m].c[n] = x.r[i].c[j]
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	return theMinor
end


def QRDecomposition(m, q, r)
	HouseholderMethod(m, q, r)
end


def HouseholderTriangularizationAlgorithm(m, qout, rout)

	rows = NumberOfRows(m)
	cols = NumberOfColumns(m)

	p = CreateIdentityMatrix(rows)
	a = CreateCopyOfMatrix(m)
	aA = CreateMatrix(rows, cols)

	t = CreateMatrix(rows, cols)
	pP = CreateIdentityMatrix(rows)
	vt = CreateMatrix(1.0, rows)

	j = 0.0
	while(j < cols)
		v = ExtractSubMatrix(a, 0.0, rows - 1.0, j, j)
		if j > 0.0
			i = 0.0
			while(i < j)
				v.r[i].c[0] = 0.0
				i = i + 1.0
			end
		end

		s = Sign(v.r[j].c[0])
		if s == 0.0
			s = 1.0
		end
		v.r[j].c[0] = v.r[j].c[0] + Norm(v)*s
		r = -2.0.to_f / (Norm(v)*Norm(v))
		Assign(aA, a)

		TransposeAssign(vt, v)
		Multiply(t, vt, a)
		Assign(a, t)
		Multiply(t, v, a)
		Assign(a, t)
		ScalarMultiply(a, r)
		Assign(t, aA)
		Add(a, aA)

		Assign(pP, p)

		Multiply(t, vt, p)
		Assign(p, t)
		Multiply(t, v, p)
		Assign(p, t)
		ScalarMultiply(p, r)
		Assign(t, aA)
		Add(p, pP)
		j = j + 1.0
	end

	Assign(rout, a)
	Assign(qout, p)
	Transpose(qout)
end


def HouseholderMethod(a, q, r)

	# Initialize.
	qR = CreateCopyOfMatrix(a)
	m = NumberOfRows(a)
	n = NumberOfColumns(a)
	rdiag = Array.new(n)

	# Main loop.
	k = 0.0
	while(k < n)
		# Compute 2-norm of k-th column without under/overflow.
		nrm = 0.0
		i = k
		while(i < m)
			nrm = Hypothenuse(nrm, Element(qR, i, k))
			i = i + 1.0
		end

		if nrm != 0.0
			# Form k-th Householder vector.
			if Element(qR, k, k) < 0.0
				nrm = -nrm
			end
			i = k
			while(i < m)
				qR.r[i].c[k] = Element(qR, i, k).to_f / nrm
				i = i + 1.0
			end
			qR.r[k].c[k] = Element(qR, k, k) + 1.0

			# Apply transformation to remaining columns.
			j = k + 1.0
			while(j < n)
				s = 0.0
				i = k
				while(i < m)
					s = s + Element(qR, i, k)*Element(qR, i, j)
					i = i + 1.0
				end
				s = -s.to_f / Element(qR, k, k)
				i = k
				while(i < m)
					qR.r[i].c[j] = Element(qR, i, j) + s*Element(qR, i, k)
					i = i + 1.0
				end
				j = j + 1.0
			end
		end
		rdiag[k] = -nrm
		k = k + 1.0
	end

	# Compute R
	r = CreateSquareMatrix(n)
	i = 0.0
	while(i < n)
		j = 0.0
		while(j < n)
			if i < j
				r.r[i].c[j] = Element(qR, i, j)
			elsif i == j
				r.r[i].c[j] = rdiag[i]
			else
				r.r[i].c[j] = 0.0
			end
			j = j + 1.0
		end
		i = i + 1.0
	end
	Assign(r, r)

	# Compute Q
	q = CreateMatrix(m, n)
	k = n - 1.0
	while(k >= 0.0)
		i = 0.0
		while(i < m)
			q.r[i].c[k] = 0.0
			i = i + 1.0
		end
		q.r[k].c[k] = 1.0
		j = k
		while(j < n)
			if Element(qR, k, k) != 0.0
				s = 0.0
				i = k
				while(i < m)
					s = s + Element(qR, i, k)*Element(q, i, j)
					i = i + 1.0
				end
				s = -s.to_f / Element(qR, k, k)
				i = k
				while(i < m)
					q.r[i].c[j] = Element(q, i, j) + s*Element(qR, i, k)
					i = i + 1.0
				end
			end
			j = j + 1.0
		end
		k = k - 1.0
	end
	Assign(q, q)

	# Adjust for positive R.
	n = NumberOfRows(r)

	n = CreateIdentityMatrix(n)

	i = 0.0
	while(i < n)
		e = Element(r, i, i)

		if e < 0.0
			n.r[i].c[i] = -1.0
		end
		i = i + 1.0
	end

	ra = MultiplyToNew(n, r)
	Assign(r, ra)
	rq = MultiplyToNew(q, n)
	Assign(q, rq)

	FreeMatrix(ra)
	FreeMatrix(rq)
	FreeMatrix(q)
	FreeMatrix(r)
	FreeMatrix(qR)
end


def Hypothenuse(a, b)
	return Math.sqrt(a**2.0 + b**2.0)
end


def Norm(a)

	l = 0.0

	rows = NumberOfRows(a)
	cols = NumberOfColumns(a)

	i = 0.0
	while(i < rows)
		j = 0.0
		while(j < cols)
			l = l + a.r[i].c[j]*a.r[i].c[j]
			j = j + 1.0
		end
		i = i + 1.0
	end
	l = Math.sqrt(l)

	return l
end


def ExtractSubMatrix(m, r1, r2, c1, c2)

	a = CreateMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0)

	i = r1
	while(i <= r2)
		j = c1
		while(j <= c2)
			a.r[i - r1].c[j - c1] = m.r[i].c[j]
			j = j + 1.0
		end
		i = i + 1.0
	end

	return a
end


def QRAlgorithm(m, r, a, q, precision, maxIterations)

	Assign(a, m)
	n = NumberOfRows(m)
	previous = Array.new(n)
	previousSet = false

	done = false
	i = 0.0
	while(i < maxIterations && !done)
		QRDecomposition(a, q, r)
		Multiply(a, r, q)

		# Check precision.
		if previousSet
			withinPrecision = 0.0
			j = 0.0
			while(j < n)
				v = previous[j] - Element(a, j, j)
				if (v).abs < precision || v == 0.0
					withinPrecision = withinPrecision + 1.0
				end
				j = j + 1.0
			end
			if withinPrecision == n
				done = true
			end
		end

		j = 0.0
		while(j < n)
			previous[j] = Element(a, j, j)
			j = j + 1.0
		end
		previousSet = true
		i = i + 1.0
	end

	return done
end


def InvertUpperTriangularMatrix(a, inverse)

	inverse.r = CreateCopyOfMatrix(a).r
	n = NumberOfRows(inverse)
	success = true

	i = n - 1.0
	while(i >= 0.0 && success)
		if Element(inverse, i, i) == 0.0
			success = false
		else
			inverse.r[i].c[i] = 1.0.to_f / Element(inverse, i, i)
			j = i - 1.0
			while(j >= 0.0 && success)
				sum = 0.0
				k = i
				while(k > j)
					sum = sum - Element(inverse, j, k)*Element(inverse, k, i)
					k = k - 1.0
				end
				if Element(inverse, j, j) == 0.0
					success = false
				else
					inverse.r[j].c[i] = sum.to_f / Element(inverse, j, j)
				end
				j = j - 1.0
			end
		end
		i = i - 1.0
	end

	return success
end


def InvertLowerTriangularMatrix(a, inverse)

	inverse.r = CreateCopyOfMatrix(a).r
	n = NumberOfRows(inverse)
	success = true

	i = 0.0
	while(i < n && success)
		if Element(inverse, i, i) == 0.0
			success = false
		else
			inverse.r[i].c[i] = 1.0.to_f / Element(inverse, i, i)
			j = i + 1.0
			while(j < n)
				sum = 0.0
				k = i
				while(k < j && success)
					sum = sum - Element(inverse, j, k)*Element(inverse, k, i)
					k = k + 1.0
				end
				if Element(inverse, j, j) == 0.0
					success = false
				else
					inverse.r[j].c[i] = sum.to_f / Element(inverse, j, j)
				end
				j = j + 1.0
			end
		end
		i = i + 1.0
	end

	return success
end


def ParseMatrixFromString(aref, matrixString, errorMessage)

	replaced = strReplaceString(matrixString, "\r".split(""), "".split(""))
	trimmed = strTrim(replaced)
	lines = strSplitByCharacter(trimmed, "\n")

	delete(replaced)
	delete(trimmed)

	success = true

	rows = lines.length
	if rows == 0.0
		aref.matrix = CreateMatrix(0.0, 0.0)
	else
		row = StringToNumberArray(lines[0].string)
		cols = row.length
		delete(row)

		aref.matrix = CreateMatrix(rows, cols)

		i = 0.0
		while(i < rows && success)
			delete(aref.matrix.r[i].c)
			aref.matrix.r[i].c = StringToNumberArray(lines[i].string)

			if aref.matrix.r[i].c.length != cols
				success = false
				errorMessage.string = "All rows must have the same number of columns.".split("")
			end
			i = i + 1.0
		end
	end

	FreeStringReferenceArray(lines)

	return success
end


def MatrixToString(matrix, digitsAfterPoint)

	s1 = Array.new(0)

	n = 0.0
	while(n < NumberOfRows(matrix))
		m = 0.0
		while(m < NumberOfColumns(matrix))
			element = Element(matrix, n, m)
			element = RoundToDigits(element, digitsAfterPoint)
			s2 = strAppendString(s1, CreateStringDecimalFromNumber(element))
			delete(s1)
			s1 = s2
			if m + 1.0 != NumberOfColumns(matrix)
				s2 = strAppendString(s1, ", ".split(""))
				delete(s1)
				s1 = s2
			end
			m = m + 1.0
		end
		s2 = strAppendString(s1, "\n".split(""))
		delete(s1)
		s1 = s2
		n = n + 1.0
	end

	return s1
end


def MatrixArrayToString(matrices, digitsAfterPoint)

	s1 = Array.new(0)

	i = 0.0
	while(i < matrices.length)
		s2 = strAppendString(s1, MatrixToString(matrices[i], digitsAfterPoint))
		delete(s1)
		s1 = s2

		s2 = strAppendString(s1, "\n".split(""))
		delete(s1)
		s1 = s2
		i = i + 1.0
	end

	return s1
end


def RoundMatrixElementsToDigits(a, digits)

	m = 0.0
	while(m < NumberOfRows(a))
		n = 0.0
		while(n < NumberOfColumns(a))
			a.r[m].c[n] = RoundToDigits(Element(a, m, n), digits)
			if a.r[m].c[n] == -0.0
				a.r[m].c[n] = 0.0
			end
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def SingularValueDecomposition(ap, uRef, sigmaRef, vRef)

	# Square matrix, adjust results correspondingly.
	orgm = NumberOfRows(ap)
	orgn = NumberOfColumns(ap)
	size = [orgm, orgn].max
	a = CreateCopyOfMatrix(ap)
	Resize(a, size, size)

	# Initialize.
	m = size
	n = size

	# Compute
	nu = [m, n].min
	s = Array.new([m + 1.0, n].min)
	u = CreateMatrix(m, nu)
	v = CreateSquareMatrix(n)
	e = Array.new(n)
	work = Array.new(m)

	# Reduce A to bidiagonal form, storing the diagonal elements in s and the super-diagonal elements in e.
	nct = [m - 1.0, n].min
	nrt = [0.0, [n - 2.0, m].min].max
	k = 0.0
	while(k < [nct, nrt].max)
		if k < nct

			# Compute the transformation for the k-th column and place the k-th diagonal in s[k].
			# Compute 2-norm of k-th column without under/overflow.
			s[k] = 0.0
			i = k
			while(i < m)
				s[k] = Hypothenuse(s[k], Element(a, i, k))
				i = i + 1.0
			end
			if s[k] != 0.0
				if Element(a, k, k) < 0.0
					s[k] = -s[k]
				end
				i = k
				while(i < m)
					a.r[i].c[k] = Element(a, i, k).to_f / s[k]
					i = i + 1.0
				end
				a.r[k].c[k] = Element(a, k, k) + 1.0
			end
			s[k] = -s[k]
		end
		j = k + 1.0
		while(j < n)
			if (k < nct) && (s[k] != 0.0)

				# Apply the transformation.
				t = 0.0
				i = k
				while(i < m)
					t = t + Element(a, i, k)*Element(a, i, j)
					i = i + 1.0
				end
				t = -t.to_f / Element(a, k, k)
				i = k
				while(i < m)
					a.r[i].c[j] = Element(a, i, j) + t*Element(a, i, k)
					i = i + 1.0
				end
			end

			# Place the k-th row of A into e for the subsequent calculation of the row transformation.
			e[j] = Element(a, k, j)
			j = j + 1.0
		end
		if k < nct

			# Place the transformation in U for subsequent back
			# multiplication.
			i = k
			while(i < m)
				u.r[i].c[k] = Element(a, i, k)
				i = i + 1.0
			end
		end
		if k < nrt
			# Compute the k-th row transformation and place the k-th super-diagonal in e[k].
			# Compute 2-norm without under/overflow.
			e[k] = 0.0
			i = k + 1.0
			while(i < n)
				e[k] = Hypothenuse(e[k], e[i])
				i = i + 1.0
			end
			if e[k] != 0.0
				if e[k + 1.0] < 0.0
					e[k] = -e[k]
				end
				i = k + 1.0
				while(i < n)
					e[i] = e[i].to_f / e[k]
					i = i + 1.0
				end
				e[k + 1.0] = e[k + 1.0] + 1.0
			end
			e[k] = -e[k]
			if (k + 1.0 < m) && (e[k] != 0.0)

				# Apply the transformation.
				i = k + 1.0
				while(i < m)
					work[i] = 0.0
					i = i + 1.0
				end
				j = k + 1.0
				while(j < n)
					i = k + 1.0
					while(i < m)
						work[i] = work[i] + e[j]*Element(a, i, j)
						i = i + 1.0
					end
					j = j + 1.0
				end
				j = k + 1.0
				while(j < n)
					t = -e[j].to_f / e[k + 1.0]
					i = k + 1.0
					while(i < m)
						a.r[i].c[j] = Element(a, i, j) + t*work[i]
						i = i + 1.0
					end
					j = j + 1.0
				end
			end

			# Place the transformation in V for subsequent back multiplication.
			i = k + 1.0
			while(i < n)
				v.r[i].c[k] = e[i]
				i = i + 1.0
			end
		end
		k = k + 1.0
	end

	# Set up the final bidiagonal matrix or order p.
	p = [n, m + 1.0].min
	if nct < n
		s[nct] = Element(a, nct, nct)
	end
	if m < p
		s[p - 1.0] = 0.0
	end
	if nrt + 1.0 < p
		e[nrt] = Element(a, nrt, p - 1.0)
	end
	e[p - 1.0] = 0.0

	# Generate U.
	j = nct
	while(j < nu)
		i = 0.0
		while(i < m)
			u.r[i].c[j] = 0.0
			i = i + 1.0
		end
		u.r[j].c[j] = 1.0
		j = j + 1.0
	end
	k = nct - 1.0
	while(k >= 0.0)
		if s[k] != 0.0
			j = k + 1.0
			while(j < nu)
				t = 0.0
				i = k
				while(i < m)
					t = t + Element(u, i, k)*Element(u, i, j)
					i = i + 1.0
				end
				t = -t.to_f / Element(u, k, k)
				i = k
				while(i < m)
					u.r[i].c[j] = Element(u, i, j) + t*Element(u, i, k)
					i = i + 1.0
				end
				j = j + 1.0
			end
			i = k
			while(i < m)
				u.r[i].c[k] = -Element(u, i, k)
				i = i + 1.0
			end
			u.r[k].c[k] = 1.0 + Element(u, k, k)
			i = 0.0
			while(i < k - 1.0)
				u.r[i].c[k] = 0.0
				i = i + 1.0
			end
		else
			i = 0.0
			while(i < m)
				u.r[i].c[k] = 0.0
				i = i + 1.0
			end
			u.r[k].c[k] = 1.0
		end
		k = k - 1.0
	end

	# Generate V.
	k = n - 1.0
	while(k >= 0.0)
		if (k < nrt) && (e[k] != 0.0)
			j = k + 1.0
			while(j < nu)
				t = 0.0
				i = k + 1.0
				while(i < n)
					t = t + Element(v, i, k)*Element(v, i, j)
					i = i + 1.0
				end
				t = -t.to_f / Element(v, k + 1.0, k)
				i = k + 1.0
				while(i < n)
					v.r[i].c[j] = Element(v, i, j) + t*Element(v, i, k)
					i = i + 1.0
				end
				j = j + 1.0
			end
		end
		i = 0.0
		while(i < n)
			v.r[i].c[k] = 0.0
			i = i + 1.0
		end
		v.r[k].c[k] = 1.0
		k = k - 1.0
	end

	# Main iteration loop for the singular values.
	pp = p - 1.0
	iter = 0.0
	eps = 2.0**(-52.0)
	tiny = 2.0**(-966.0)
	while(p > 0.0)
		# Here is where a test for too many iterations would go.
		# This section of the program inspects for negligible elements in the s and e arrays.
		# On completion the variables kase and k are set as follows.
		# kase = 1, if s(p) and e[k-1] are negligible and k<p
		# kase = 2, if s(k) is negligible and k<p
		# kase = 3, if e[k-1] is negligible, k<p, and s(k), ..., s(p) are not negligible (qr step).
		# kase = 4, if e(p-1) is negligible (convergence).
		done = false
		k = p - 2.0
		while(k > -1.0 && !done)
			if (e[k]).abs <= tiny + eps*((s[k]).abs + (s[k + 1.0]).abs)
				e[k] = 0.0
				done = true
			else
				k = k - 1.0
			end
		end
		if k == p - 2.0
			kase = 4.0
		else
			done = false
			ks = p - 1.0
			while(ks > k && !done)
				if ks != p
					t = (e[ks]).abs
				else
					t = 0.0
				end

				if ks != k + 1.0
					t = t + (e[ks - 1.0]).abs
				end

				if (s[ks]).abs <= tiny + eps*t
					s[ks] = 0.0
					done = true
				else
					ks = ks - 1.0
				end
			end
			if ks == k
				kase = 3.0
			elsif ks == p - 1.0
				kase = 1.0
			else
				kase = 2.0
				k = ks
			end
		end
		k = k + 1.0

		# Perform the task indicated by kase.
		if kase == 1.0
			# Deflate negligible s(p).
			f = e[p - 2.0]
			e[p - 2.0] = 0.0
			j = p - 2.0
			while(j >= k)
				t = Hypothenuse(s[j], f)
				cs = s[j].to_f / t
				sn = f.to_f / t
				s[j] = t
				if j != k
					f = -sn*e[j - 1.0]
					e[j - 1.0] = cs*e[j - 1.0]
				end

				i = 0.0
				while(i < n)
					t = cs*Element(v, i, j) + sn*Element(v, i, p - 1.0)
					v.r[i].c[p - 1.0] = -sn*Element(v, i, j) + cs*Element(v, i, p - 1.0)
					v.r[i].c[j] = t
					i = i + 1.0
				end
				j = j - 1.0
			end
		elsif kase == 2.0
			# Split at negligible s(k).
			f = e[k - 1.0]
			e[k - 1.0] = 0.0
			j = k
			while(j < p)
				t = Hypothenuse(s[j], f)
				cs = s[j].to_f / t
				sn = f.to_f / t
				s[j] = t
				f = -sn*e[j]
				e[j] = cs*e[j]

				i = 0.0
				while(i < m)
					t = cs*Element(u, i, j) + sn*Element(u, i, k + 1.0)
					u.r[i].c[k - 1.0] = -sn*Element(u, i, j) + cs*Element(u, i, k + 1.0)
					u.r[i].c[j] = t
					i = i + 1.0
				end
				j = j + 1.0
			end
		elsif kase == 3.0
			# Perform one qr step.
			# Calculate the shift.
			scale = [[[[(s[p - 1.0]).abs, (s[p - 2.0]).abs].max, (e[p - 2.0]).abs].max, (s[k]).abs].max, (e[k]).abs].max
			sp = s[p - 1.0].to_f / scale
			spm1 = s[p - 2.0].to_f / scale
			epm1 = e[p - 2.0].to_f / scale
			sk = s[k].to_f / scale
			ek = e[k].to_f / scale
			b = ((spm1 + sp)*(spm1 - sp) + epm1*epm1).to_f / 2.0
			c = (sp*epm1)*(sp*epm1)
			shift = 0.0
			if (b != 0.0) || (c != 0.0)
				shift = Math.sqrt(b*b + c)
				if b < 0.0
					shift = -shift
				end
				shift = c.to_f / (b + shift)
			end
			f = (sk + sp)*(sk - sp) + shift
			g = sk*ek

			# Chase zeros.
			j = k
			while(j < p - 1.0)
				t = Hypothenuse(f, g)
				cs = f.to_f / t
				sn = g.to_f / t
				if j != k
					e[j - 1.0] = t
				end
				f = cs*s[j] + sn*e[j]
				e[j] = cs*e[j] - sn*s[j]
				g = sn*s[j + 1.0]
				s[j + 1.0] = cs*s[j + 1.0]
				i = 0.0
				while(i < n)
					t = cs*Element(v, i, j) + sn*Element(v, i, j + 1.0)
					v.r[i].c[j + 1.0] = -sn*Element(v, i, j) + cs*Element(v, i, j + 1.0)
					v.r[i].c[j] = t
					i = i + 1.0
				end
				t = Hypothenuse(f, g)
				cs = f.to_f / t
				sn = g.to_f / t
				s[j] = t
				f = cs*e[j] + sn*s[j + 1.0]
				s[j + 1.0] = -sn*e[j] + cs*s[j + 1.0]
				g = sn*e[j + 1.0]
				e[j + 1.0] = cs*e[j + 1.0]
				if j < m - 1.0
					i = 0.0
					while(i < m)
						t = cs*Element(u, i, j) + sn*Element(u, i, j + 1.0)
						u.r[i].c[j + 1.0] = -sn*Element(u, i, j) + cs*Element(u, i, j + 1.0)
						u.r[i].c[j] = t
						i = i + 1.0
					end
				end
				j = j + 1.0
			end
			e[p - 2.0] = f
			iter = iter + 1.0
		elsif kase == 4.0
			# Make the singular values positive.
			if s[k] <= 0.0
				if s[k] < 0.0
					s[k] = -s[k]
				else
					s[k] = 0.0
				end

				i = 0.0
				while(i <= pp)
					v.r[i].c[k] = -Element(v, i, k)
					i = i + 1.0
				end
			end

			# Order the singular values.
			while(k < pp && s[k] < s[k + 1.0])
				t = s[k]
				s[k] = s[k + 1.0]
				s[k + 1.0] = t
				if k < n - 1.0
					i = 0.0
					while(i < n)
						t = Element(v, i, k + 1.0)
						v.r[i].c[k + 1.0] = Element(v, i, k)
						v.r[i].c[k] = t
						i = i + 1.0
					end
				end
				if k < m - 1.0
					i = 0.0
					while(i < m)
						t = Element(u, i, k + 1.0)
						u.r[i].c[k + 1.0] = Element(u, i, k)
						u.r[i].c[k] = t
						i = i + 1.0
					end
				end
				k = k + 1.0
			end
			iter = 0.0
			p = p - 1.0
		end
	end

	Resize(u, orgm, orgm)
	Resize(v, orgn, orgn)

	uRef.matrix = u
	vRef.matrix = v
	sigmaRef.matrix = CreateMatrix(orgm, orgn)
	i = 0.0
	while(i < [orgm, orgn].min)
		sigmaRef.matrix.r[i].c[i] = s[i]
		i = i + 1.0
	end

	return true
end


def CreateComplexMatrix(rows, cols)

	matrix = ComplexMatrix.new
	matrix.r = Array.new(rows)
	m = 0.0
	while(m < rows)
		matrix.r[m] = ComplexMatrixRow.new
		matrix.r[m].c = Array.new(cols)
		n = 0.0
		while(n < cols)
			matrix.r[m].c[n] = cCreateComplexNumber(0.0, 0.0)
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def CreateComplexMatrixFromMatrix(a)

	rows = NumberOfRows(a)
	cols = NumberOfColumns(a)

	matrix = ComplexMatrix.new
	matrix.r = Array.new(rows)
	m = 0.0
	while(m < rows)
		matrix.r[m] = ComplexMatrixRow.new
		matrix.r[m].c = Array.new(cols)
		n = 0.0
		while(n < cols)
			matrix.r[m].c[n] = cCreateComplexNumber(a.r[m].c[n], 0.0)
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def CreateReMatrixFromComplexMatrix(a)

	rows = NumberOfRowsComplex(a)
	cols = NumberOfColumnsComplex(a)

	matrix = Matrix.new
	matrix.r = Array.new(rows)
	m = 0.0
	while(m < rows)
		matrix.r[m] = MatrixRow.new
		matrix.r[m].c = Array.new(cols)
		n = 0.0
		while(n < cols)
			matrix.r[m].c[n] = IndexComplex(a, m, n).re
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def CreateImMatrixFromComplexMatrix(a)

	rows = NumberOfRowsComplex(a)
	cols = NumberOfColumnsComplex(a)

	matrix = Matrix.new
	matrix.r = Array.new(rows)
	m = 0.0
	while(m < rows)
		matrix.r[m] = MatrixRow.new
		matrix.r[m].c = Array.new(cols)
		n = 0.0
		while(n < cols)
			matrix.r[m].c[n] = IndexComplex(a, m, n).im
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def NumberOfRowsComplex(a)
	return a.r.length
end


def NumberOfColumnsComplex(a)
	return a.r[0].c.length
end


def IndexComplex(a, m, n)
	return a.r[m].c[n]
end


def AddComplex(a, b)

	d = NumberOfRowsComplex(a)

	m = 0.0
	while(m < d)
		n = 0.0
		while(n < d)
			cAdd(IndexComplex(a, m, n), IndexComplex(b, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def SubtractComplex(a, b)

	r = NumberOfRowsComplex(a)
	c = NumberOfColumnsComplex(a)

	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			cSub(IndexComplex(a, m, n), IndexComplex(b, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def SubtractComplexToNew(a, b)

	x = CreateCopyOfComplexMatrix(a)
	SubtractComplex(x, b)

	return x
end


def MultiplyComplex(x, a, b)

	rows = NumberOfRowsComplex(a)
	cols = NumberOfColumnsComplex(b)
	d = NumberOfColumnsComplex(a)
	t = cCreateComplexNumber(0.0, 0.0)

	m = 0.0
	while(m < rows)
		n = 0.0
		while(n < cols)
			s = cCreateComplexNumber(0.0, 0.0)

			i = 0.0
			while(i < d)
				cAssignComplex(t, s)
				cAssignComplex(s, IndexComplex(a, m, i))
				cMul(s, IndexComplex(b, i, n))
				cAdd(s, t)
				i = i + 1.0
			end

			x.r[m].c[n] = s
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def MultiplyComplexToNew(a, b)

	rows = NumberOfRowsComplex(a)
	cols = NumberOfColumnsComplex(b)
	x = CreateComplexMatrix(rows, cols)
	MultiplyComplex(x, a, b)

	return x
end


def Conjugate(a)

	rows = NumberOfRowsComplex(a)
	cols = NumberOfRowsComplex(a)

	m = 0.0
	while(m < rows)
		n = 0.0
		while(n < cols)
			cConjugate(IndexComplex(a, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def AssignComplexMatrix(a, b)

	r = NumberOfRowsComplex(a)
	c = NumberOfColumnsComplex(a)

	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			cAssignComplex(IndexComplex(a, m, n), IndexComplex(b, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def ScalarMultiplyComplex(a, b)

	r = NumberOfRowsComplex(a)
	c = NumberOfColumnsComplex(a)

	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			cMul(IndexComplex(a, m, n), b)
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def ScalarMultiplyComplexToNew(a, b)

	matrix = CreateCopyOfComplexMatrix(a)
	ScalarMultiplyComplex(matrix, b)

	return matrix
end


def ScalarDivideComplex(a, b)

	r = NumberOfRowsComplex(a)
	c = NumberOfColumnsComplex(a)

	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			cDiv(IndexComplex(a, m, n), b)
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def ElementWisePowerComplex(a, p)

	r = NumberOfRowsComplex(a)
	c = NumberOfColumnsComplex(a)

	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			cPower(IndexComplex(a, m, n), p)
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def CreateComplexIdentityMatrix(d)

	matrix = CreateSquareComplexMatrix(d)
	FillComplex(matrix, 0.0, 0.0)

	m = 0.0
	while(m < d)
		IndexComplex(matrix, m, m).re = 1.0
		m = m + 1.0
	end

	return matrix
end


def CreateSquareComplexMatrix(d)

	matrix = ComplexMatrix.new
	matrix.r = Array.new(d)
	m = 0.0
	while(m < d)
		matrix.r[m] = ComplexMatrixRow.new
		matrix.r[m].c = Array.new(d)
		n = 0.0
		while(n < d)
			matrix.r[m].c[n] = cCreateComplexNumber(0.0, 0.0)
			n = n + 1.0
		end
		m = m + 1.0
	end

	return matrix
end


def ClearComplex(a)
	FillComplex(a, 0.0, 0.0)
end


def FillComplex(a, re, im)

	m = 0.0
	while(m < NumberOfRowsComplex(a))
		n = 0.0
		while(n < NumberOfColumnsComplex(a))
			IndexComplex(a, m, n).re = re
			IndexComplex(a, m, n).im = im
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def TraceComplex(a)

	tr = cCreateComplexNumber(0.0, 0.0)

	d = a.r.length
	m = 0.0
	while(m < d)
		cAdd(tr, IndexComplex(a, m, m))
		m = m + 1.0
	end

	return tr
end


def CofactorOfComplexMatrix(mat, temp, p, q, n)

	i = 0.0
	j = 0.0

	row = 0.0
	while(row < n)
		col = 0.0
		while(col < n)
			if row != p && col != q
				cAssignComplex(IndexComplex(temp, i, j), IndexComplex(mat, row, col))
				j = j + 1.0

				if j == n - 1.0
					j = 0.0
					i = i + 1.0
				end
			end
			col = col + 1.0
		end
		row = row + 1.0
	end
end


def DeterminantOfComplexSubmatrix(mat, n)

	d = cCreateComplexNumber(0.0, 0.0)
	t = cCreateComplexNumber(0.0, 0.0)

	if n == 1.0
		d = mat.r[0].c[0]
	else
		temp = CreateSquareComplexMatrix(n)

		sign = 1.0

		f = 0.0
		while(f < n)
			CofactorOfComplexMatrix(mat, temp, 0.0, f, n)
			cAssignComplexByValues(t, sign, 0.0)
			cMul(t, IndexComplex(mat, 0.0, f))
			cMul(t, DeterminantOfComplexSubmatrix(temp, n - 1.0))
			cAdd(d, t)
			sign = -sign
			f = f + 1.0
		end

		DeleteComplexMatrix(temp)
	end

	return d
end


def DeleteComplexMatrix(x)

	rows = NumberOfRowsComplex(x)
	cols = NumberOfColumnsComplex(x)
	m = 0.0
	while(m < rows)
		n = 0.0
		while(n < cols)
			delete(x.r[m].c[n])
			n = n + 1.0
		end
		delete(x.r[m].c)
		delete(x.r[m])
		m = m + 1.0
	end

	delete(x.r)
	delete(x)
end


def DeterminantComplex(m)

	n = NumberOfRowsComplex(m)
	d = DeterminantOfComplexSubmatrix(m, n)

	return d
end


def AdjointComplex(a, adj)

	n = a.r.length
	t = cCreateComplexNumber(0.0, 0.0)
	sign = cCreateComplexNumber(0.0, 0.0)

	if n == 1.0
		cAssignComplexByValues(IndexComplex(adj, 0.0, 0.0), 1.0, 0.0)
	else
		cofactors = CreateSquareComplexMatrix(n)

		i = 0.0
		while(i < n)
			j = 0.0
			while(j < n)
				CofactorOfComplexMatrix(a, cofactors, i, j, n)

				if (i + j)%2.0 == 0.0
					cAssignComplexByValues(sign, 1.0, 0.0)
				else
					cAssignComplexByValues(sign, -1.0, 0.0)
				end

				cAssignComplex(t, sign)
				cMul(t, DeterminantOfComplexSubmatrix(cofactors, n - 1.0))
				cAssignComplex(IndexComplex(adj, j, i), t)
				j = j + 1.0
			end
			i = i + 1.0
		end

		DeleteComplexMatrix(cofactors)
	end
end


def InverseComplex(a, inverseResult)

	t = cCreateComplexNumber(0.0, 0.0)

	if NumberOfColumnsComplex(a) == NumberOfRowsComplex(a)
		n = NumberOfColumnsComplex(a)

		det = DeterminantComplex(a)
		if det.re != 0.0 || det.im != 0.0
			adj = CreateSquareComplexMatrix(n)
			AdjointComplex(a, adj)

			i = 0.0
			while(i < n)
				j = 0.0
				while(j < n)
					cAssignComplex(t, IndexComplex(adj, i, j))
					cDiv(t, det)
					cAssignComplex(IndexComplex(inverseResult, i, j), t)
					j = j + 1.0
				end
				i = i + 1.0
			end

			success = true
			DeleteComplexMatrix(adj)
		else
			success = false
		end
	else
		success = false
	end

	return success
end


def ComplexMatrixEqualsEpsilon(b, f, epsilon)

	equals = true

	if NumberOfRowsComplex(b) == NumberOfRowsComplex(f) && NumberOfColumnsComplex(b) == NumberOfColumnsComplex(f)
		columns = NumberOfColumnsComplex(b)
		rows = NumberOfRowsComplex(b)

		x = 0.0
		while(x < rows)
			y = 0.0
			while(y < columns)
				equals = equals && cEpsilonCompareComplex(IndexComplex(b, x, y), IndexComplex(f, x, y), epsilon)
				y = y + 1.0
			end
			x = x + 1.0
		end
	else
		equals = false
	end

	return equals
end


def MinorComplex(x, row, column)

	rows = NumberOfRowsComplex(x) - 1.0
	cols = NumberOfColumnsComplex(x) - 1.0

	minor = CreateComplexMatrix(rows, cols)

	i = 0.0
	while(i < rows)
		if i < row
			m = i
		else
			m = i + 1.0
		end

		j = 0.0
		while(i != row && j < cols)
			if j != column

				if j < column
					n = j
				else
					n = j + 1.0
				end

				cAssignComplex(IndexComplex(minor, m, n), IndexComplex(x, i, j))
			end
			j = j + 1.0
		end
		i = i + 1.0
	end

	return minor
end


def AssignComplex(a, b)

	r = NumberOfRowsComplex(a)
	c = NumberOfColumnsComplex(a)
	m = 0.0
	while(m < r)
		n = 0.0
		while(n < c)
			cAssignComplex(IndexComplex(a, m, n), IndexComplex(b, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def CreateCopyOfComplexMatrix(a)

	x = CreateComplexMatrix(NumberOfRowsComplex(a), NumberOfColumnsComplex(a))
	AssignComplex(x, a)

	return x
end


def TransposeComplex(a)

	tmp = cCreateComplexNumber(0.0, 0.0)

	square = IsSquareComplexMatrix(a)
	if square
		rows = NumberOfColumnsComplex(a)

		m = 0.0
		while(m < rows)
			n = 0.0
			while(n < m)
				cAssignComplex(tmp, IndexComplex(a, n, m))
				cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n))
				cAssignComplex(IndexComplex(a, m, n), tmp)
				n = n + 1.0
			end
			m = m + 1.0
		end
	end

	return square
end


def ConjugateTransposeComplex(a)

	tmp = cCreateComplexNumber(0.0, 0.0)

	square = IsSquareComplexMatrix(a)
	if square
		rows = NumberOfColumnsComplex(a)

		m = 0.0
		while(m < rows)
			n = 0.0
			while(n < m)
				cAssignComplex(tmp, IndexComplex(a, n, m))
				cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n))
				cAssignComplex(IndexComplex(a, m, n), tmp)
				cConjugate(IndexComplex(a, m, n))
				n = n + 1.0
			end
			m = m + 1.0
		end
	end

	return square
end


def IsSquareComplexMatrix(a)

	if NumberOfRowsComplex(a) == NumberOfColumnsComplex(a)
		is = true
	else
		is = false
	end

	return is
end


def TransposeComplexAssign(t, a)

	cols = NumberOfRowsComplex(a)
	rows = NumberOfColumnsComplex(a)

	m = 0.0
	while(m < cols)
		n = 0.0
		while(n < rows)
			cAssignComplex(IndexComplex(t, n, m), IndexComplex(a, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end
end


def TransposeComplexToNew(a)

	cols = NumberOfRowsComplex(a)
	rows = NumberOfColumnsComplex(a)

	c = CreateComplexMatrix(rows, cols)

	m = 0.0
	while(m < cols)
		n = 0.0
		while(n < rows)
			cAssignComplex(IndexComplex(c, n, m), IndexComplex(a, m, n))
			n = n + 1.0
		end
		m = m + 1.0
	end

	return c
end


def ExtractComplexSubMatrix(m, r1, r2, c1, c2)

	a = CreateComplexMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0)

	i = r1
	while(i <= r2)
		j = c1
		while(j <= c2)
			cAssignComplex(IndexComplex(a, i - r1, j - c1), IndexComplex(m, i, j))
			j = j + 1.0
		end
		i = i + 1.0
	end

	return a
end


def NormComplex(a)

	l = 0.0

	rows = NumberOfRowsComplex(a)
	cols = NumberOfColumnsComplex(a)

	i = 0.0
	while(i < rows)
		j = 0.0
		while(j < cols)
			cComplexNumber = IndexComplex(a, i, j)
			l = l + cComplexNumber.re**2.0 + cComplexNumber.im**2.0
			j = j + 1.0
		end
		i = i + 1.0
	end
	l = Math.sqrt(l)

	return l
end


def ComplexCharacteristicPolynomial(a, p)

	cp = CreateSquareComplexMatrix(NumberOfRowsComplex(a))
	determinant = CComplexNumber.new

	ComplexCharacteristicPolynomialWithInverse(a, cp, p, determinant)

	DeleteComplexMatrix(cp)
end


def ComplexCharacteristicPolynomialWithInverse(a, aInverse, p, determinant)
	FaddeevLeVerrierAlgorithmComplex(a, aInverse, p, determinant)
end


def FaddeevLeVerrierAlgorithmComplex(a, aInverse, p, determinant)

	n1 = cCreateComplexNumber(-1.0, 0.0)
	n = NumberOfRowsComplex(a)
	p.cs = Array.new(n + 1.0)
	i = 0.0
	while(i < n + 1.0)
		p.cs[i] = CComplexNumber.new
		i = i + 1.0
	end
	cAssignComplexByValues(p.cs[n], 1.0, 0.0)
	mkm1 = CreateSquareComplexMatrix(n)
	FillComplex(mkm1, 0.0, 0.0)
	id = CreateComplexIdentityMatrix(n)
	mk = CreateSquareComplexMatrix(n)
	t1 = CreateSquareComplexMatrix(n)

	k = 1.0
	while(k <= n)
		MultiplyComplex(mk, a, mkm1)
		AssignComplex(t1, id)
		ScalarMultiplyComplex(t1, p.cs[n - k + 1.0])
		AddComplex(mk, t1)

		MultiplyComplex(t1, a, mk)
		t = TraceComplex(t1)
		t2 = cCreateComplexNumber(-1.0.to_f / k, 0.0)
		cMul(t, t2)
		cAssignComplex(p.cs[n - k], t)

		# done
		AssignComplex(mkm1, mk)

		if k == n
			AssignComplex(aInverse, mk)
			cAssignComplex(t, p.cs[0])
			cMul(t, n1)
			cAssignComplex(determinant, t)
			if t.re == 0.0 && t.im == 0.0
			else
				ScalarDivideComplex(aInverse, t)
			end
		end
		k = k + 1.0
	end

	DeleteComplexMatrix(mkm1)
	DeleteComplexMatrix(id)
	DeleteComplexMatrix(mk)
	DeleteComplexMatrix(t1)
end


def EigenvaluesComplex(a, eigenValuesReference)

	eigenVectorsReference = ComplexMatrixArrayReference.new
	success = EigenpairsComplex(a, eigenValuesReference, eigenVectorsReference)
	if success
		i = 0.0
		while(i < eigenVectorsReference.matrices.length)
			DeleteComplexMatrix(eigenVectorsReference.matrices[i])
			i = i + 1.0
		end
		delete(eigenVectorsReference.matrices)
		delete(eigenVectorsReference)
	end

	return success
end


def EigenvectorsComplex(a, eigenVectorsReference)

	evsReference = CComplexNumberArrayReference.new
	success = EigenpairsComplex(a, evsReference, eigenVectorsReference)
	if success
		i = 0.0
		while(i < evsReference.complexNumbers.length)
			delete(evsReference.complexNumbers[i])
			i = i + 1.0
		end
		delete(evsReference.complexNumbers)
		delete(evsReference)
	end

	return success
end


def InversePowerMethodComplex(a, eigenvalue, maxIterations, eigenvector)

	n = NumberOfRowsComplex(a)

	t2 = CreateComplexIdentityMatrix(n)
	ScalarMultiplyComplex(t2, eigenvalue)
	t3 = SubtractComplexToNew(a, t2)
	t4 = CreateSquareComplexMatrix(n)
	isSingular = !InverseComplex(t3, t4)
	cc = cCreateComplexNumber(0.0, 0.0)
	t1 = CreateComplexMatrix(n, 1.0)

	if isSingular
		DeleteComplexMatrix(t2)
		DeleteComplexMatrix(t3)
		DeleteComplexMatrix(t4)

		c101 = cCreateComplexNumber(1.01, 0.0)
		# Try again with more erroneous eigenvalue estimate.
		t2 = CreateComplexIdentityMatrix(n)
		k = cMulToNew(eigenvalue, c101)
		ScalarMultiplyComplex(t2, k)
		t3 = SubtractComplexToNew(a, t2)
		t4 = CreateSquareComplexMatrix(n)
		isSingular = !InverseComplex(t3, t4)
		delete(c101)
	end

	if !isSingular
		b = CreateComplexMatrix(n, 1.0)

		i = 0.0
		while(i < n)
			cAssignComplexByValues(b.r[i].c[0], 1.0, 1.0)
			i = i + 1.0
		end

		i = 0.0
		while(i < maxIterations)
			MultiplyComplex(t1, t4, b)
			c = NormComplex(t1)
			cAssignComplexByValues(cc, c, 0.0)
			ScalarDivideComplex(t1, cc)
			AssignComplex(b, t1)
			i = i + 1.0
		end

		eigenvector.complexNumbers = Array.new(n)
		i = 0.0
		while(i < n)
			eigenvector.complexNumbers[i] = b.r[i].c[0]
			i = i + 1.0
		end
	end

	DeleteComplexMatrix(t1)
	DeleteComplexMatrix(t2)
	DeleteComplexMatrix(t3)
	DeleteComplexMatrix(t4)
	delete(cc)

	return !isSingular
end


def EigenpairsComplex(m, eigenValuesReference, eigenVectorsReference)
	return ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(m, eigenValuesReference, eigenVectorsReference, 0.000001, 100.0)
end


def ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(m, eigenValuesReference, eigenVectorsReference, precision, maxIterations)

	evecReference = CComplexNumberArrayReference.new

	p = PComplexPolynomial.new
	ComplexCharacteristicPolynomial(m, p)

	n = p.cs.length - 1.0
	rs = Array.new(n)
	i = 0.0
	while(i < n)
		rs[i] = cCreateComplexNumber(0.0, 0.0)
		i = i + 1.0
	end
	rsPrev = Array.new(n)
	i = 0.0
	while(i < n)
		rsPrev[i] = cCreateComplexNumber(0.4, 0.9)
		cPower(rsPrev[i], i)
		i = i + 1.0
	end
	t2 = cCreateComplexNumber(0.0, 0.0)
	t3 = cCreateComplexNumber(0.0, 0.0)

	success = false

	eigenVectorsReference.matrices = Array.new(n)
	i = 0.0
	while(i < n)
		eigenVectorsReference.matrices[i] = CreateComplexMatrix(n, 1.0)
		i = i + 1.0
	end

	i = 0.0
	while(i < maxIterations && !success)
		j = 0.0
		while(j < n)
			xn1 = rsPrev[j]

			t1 = pEvaluateComplex(p, xn1)
			cAssignComplexByValues(t2, 1.0, 0.0)
			k = 0.0
			while(k < n)
				if k < j
					cAssignComplex(t3, xn1)
					cSub(t3, rs[k])
					cMul(t2, t3)
				end
				if k > j
					cAssignComplex(t3, xn1)
					cSub(t3, rsPrev[k])
					cMul(t2, t3)
				end
				k = k + 1.0
			end
			cDiv(t1, t2)
			cAssignComplex(rs[j], xn1)
			cSub(rs[j], t1)

			delete(t1)
			j = j + 1.0
		end
		withinPrecision = 0.0
		j = 0.0
		while(j < n)
			eigenValue = rs[j]

			# Calculate the eigenvector corresponding to the eigenvalue.
			inverseSuccess = InversePowerMethodComplex(m, eigenValue, i + 1.0, evecReference)
			if inverseSuccess
				k = 0.0
				while(k < n)
					eigenVectorsReference.matrices[j].r[k].c[0] = evecReference.complexNumbers[k]
					k = k + 1.0
				end

				# Check eigenpair agains precision.
				eigenVector = eigenVectorsReference.matrices[j]

				if CheckComplexEigenpairPrecision(m, eigenValue, eigenVector, precision)
					withinPrecision = withinPrecision + 1.0
				end
				cAssignComplex(rsPrev[j], rs[j])
			end
			j = j + 1.0
		end
		if withinPrecision == n
			success = true
		end
		i = i + 1.0
	end

	eigenValuesReference.complexNumbers = rs

	return success
end


def CheckComplexEigenpairPrecision(a, lambda, e, precision)

	vec1 = MultiplyComplexToNew(a, e)
	vec2 = ScalarMultiplyComplexToNew(e, lambda)

	equal = ComplexMatrixEqualsEpsilon(vec1, vec2, precision)

	return equal
end


def vectorCreate2DVector(a0, a1)

	vector = Array.new(2)
	vector[0] = a0
	vector[1] = a1

	return vector
end


def vectorCreate3DVector(a0, a1, a2)

	vector = Array.new(3)
	vector[0] = a0
	vector[1] = a1
	vector[2] = a2

	return vector
end


def vectorCreate4DVector(a0, a1, a2, a3)

	vector = Array.new(4)
	vector[0] = a0
	vector[1] = a1
	vector[2] = a2
	vector[3] = a3

	return vector
end


def vectorDotProductWithCheck(a, b, answer, errorMessage)

	sum = 0.0

	if a.length == b.length
		sum = vectorDotProduct(a, b)
		success = true
	else
		errorMessage.string = "The dimensions have to be equal.".split("")
		success = false
	end

	answer.numberValue = sum

	return success
end


def vectorDotProduct(a, b)

	sum = 0.0
	# Dot product is the sum of the products of the corresponding entries of two vectors.
	i = 0.0
	while(i < a.length)
		sum = sum + a[i]*b[i]
		i = i + 1.0
	end

	return sum
end


def vectorMagnitude(a)

	sum = 0.0

	i = 0.0
	while(i < a.length)
		sum = sum + a[i]**2.0
		i = i + 1.0
	end
	sum = Math.sqrt(sum)

	return sum
end


def vectorCrossProduct3dWithCheck(a, b, answer, errorMessage)

	crossProduct = Array.new(3)

	if a.length == 3.0 && b.length == 3.0
		crossProduct[0] = a[1]*b[2] - b[1]*a[2]
		crossProduct[1] = a[2]*b[0] - b[2]*a[0]
		crossProduct[2] = a[0]*b[1] - b[0]*a[1]

		success = true
	else
		errorMessage.string = "The dimensions must be 3.".split("")
		success = false
	end

	answer.numberArray = crossProduct

	return success
end


def vectorSum(a)

	s = 0.0

	i = 0.0
	while(i < a.length)
		s = s + a[i]
		i = i + 1.0
	end

	return s
end


def vectorProduct(a)

	p = 1.0

	i = 0.0
	while(i < a.length)
		p = p*a[i]
		i = i + 1.0
	end

	return p
end


def vectorCumulativeSum(a)

	s = 0.0

	i = 0.0
	while(i < a.length)
		s = s + a[i]
		a[i] = s
		i = i + 1.0
	end
end


def vectorCumulativeProduct(a)

	p = 1.0

	i = 0.0
	while(i < a.length)
		p = p*a[i]
		a[i] = p
		i = i + 1.0
	end
end


def vectorAdd(a, b)

	i = 0.0
	while(i < a.length && i < b.length)
		a[i] = a[i] + b[i]
		i = i + 1.0
	end
end


def vectorSubtract(a, b)

	i = 0.0
	while(i < a.length && i < b.length)
		a[i] = a[i] - b[i]
		i = i + 1.0
	end
end


def vectorMultiply(a, b)

	i = 0.0
	while(i < a.length && i < b.length)
		a[i] = a[i]*b[i]
		i = i + 1.0
	end
end


def vectorDivide(a, b)

	i = 0.0
	while(i < a.length && i < b.length)
		a[i] = a[i].to_f / b[i]
		i = i + 1.0
	end
end


def vectorAddToNew(a, b)

	c = Array.new([a.length, b.length].min)

	i = 0.0
	while(i < a.length && i < b.length)
		c[i] = a[i] + b[i]
		i = i + 1.0
	end

	return c
end


def vectorSubtractToNew(a, b)

	c = Array.new([a.length, b.length].min)

	i = 0.0
	while(i < a.length && i < b.length)
		c[i] = a[i] - b[i]
		i = i + 1.0
	end

	return c
end


def vectorMultiplyToNew(a, b)

	c = Array.new([a.length, b.length].min)

	i = 0.0
	while(i < a.length && i < b.length)
		c[i] = a[i]*b[i]
		i = i + 1.0
	end

	return c
end


def vectorDivideToNew(a, b)

	c = Array.new([a.length, b.length].min)

	i = 0.0
	while(i < a.length && i < b.length)
		c[i] = a[i].to_f / b[i]
		i = i + 1.0
	end

	return c
end


def vectorPower(a, p)

	i = 0.0
	while(i < a.length)
		a[i] = a[i]**p
		i = i + 1.0
	end
end


def CreateLinearCongruentialGeneratorNumericalRecipes(seed)
	return CreateLinearCongruentialGeneratorCustom(2.0**29.0, 1664525.0, 1013904223.0, seed)
end


def CreateLinearCongruentialGeneratorCustom(modulus, multiplier, increment, seed)

	lcg = LinearCongruentialGenerator.new
	lcg.m = modulus
	lcg.a = multiplier
	lcg.c = increment
	lcg.x = seed

	return lcg
end


def LinearCongruentialGeneratorNextNumber(lcg)
	lcg.x = ((lcg.a*lcg.x + lcg.c)%lcg.m).floor

	return lcg.x.to_f / lcg.m
end


def CreatePseudorandomNumberGenerator(seed)

	prg = PseudorandomGenerator.new
	prg.lcg = CreateLinearCongruentialGeneratorNumericalRecipes(seed)

	return prg
end


def PseudorandomNextNumber(prg)
	return LinearCongruentialGeneratorNextNumber(prg.lcg)
end


def PseudorandomNextInteger(prg, n)
	return (PseudorandomNextNumber(prg)*n).floor
end


def PseudorandomNextIntegerBetween(prg, a, b)
	return (a).ceil + (PseudorandomNextNumber(prg)*(b - a)).floor
end


def GaloisField2e8Add(a, b)
	return Xor2Byte(a, b)
end


def GaloisField2e8Sub(a, b)
	return Xor2Byte(a, b)
end


def GaloisField2e8Mul(a, b, modulusPolynomial)

	r = 0.0

	while(b != 0.0)
		if And2Byte(b, 1.0) == 1.0
			r = Xor2Byte(r, a)
		end
		b = ShiftRight2Byte(b, 1.0)
		a = ShiftLeft2Byte(a, 1.0)
		if (And2Byte(a, 256.0) == 256.0)
			a = Xor2Byte(a, modulusPolynomial)
		end
	end

	return r
end


def GaloisField2e8Reciprocal(a, modulusPolynomial)

	ga = a
	done = false
	inv = 0.0

	i = 0.0
	while(i < ShiftLeft2Byte(1.0, 8.0) && !done)
		if GaloisField2e8Mul(ga, i, modulusPolynomial) == 1.0
			done = true
			inv = i
		end
		i = i + 1.0
	end

	return inv
end


def FindRoots(p, rootsReference)
	return DurandKernerMethod(p, 0.000001, 100.0, rootsReference)
end


def LaguerresMethodWithRepeatedDivision(p, maxIterations, precision, guess, rootsReference)

	n = pDegree(p)

	x = Array.new(n)

	q = pCreatePolynomial(n)
	r = pCreatePolynomial(n)
	d = pCreatePolynomial(n)

	success = true
	xkReference = CreateNumberReference(0.0)

	nr = 0.0
	while(nr < n && success)
		success = LaguerresMethod(p, guess, maxIterations, precision, xkReference)

		if success
			xk = xkReference.numberValue
			x[nr] = xk

			pFill(d, 0.0)
			d[0] = -xk
			d[1] = 1.0
			pDivide(q, r, p, d)
			pAssign(p, q)
		end
		nr = nr + 1.0
	end

	delete(q)
	delete(r)
	delete(d)
        
	rootsReference.numberArray = x

	return success
end


def LaguerresMethod(p, guess, maxIterations, precision, rootReference)

	n = pDegree(p)
	success = true

	xk = guess

	k = 0.0
	while((k < maxIterations) && ((pEvaluate(p, xk)).abs >= precision) && success)
		g = pEvaluateDerivative(p, xk, 1.0).to_f / pEvaluate(p, xk)
		h = g**2.0 - pEvaluateDerivative(p, xk, 2.0).to_f / pEvaluate(p, xk)
		t1 = (n - 1.0)*(n*h - g**2.0)
		if t1 >= 0.0
			denom = Math.sqrt(t1)
			denom1 = g + denom
			denom2 = g - denom
			if (denom1).abs >= (denom2).abs
				denom = denom1
			else
				denom = denom2
			end
			a = n.to_f / denom

			xk = xk - a
		else
			success = false
		end
		k = k + 1.0
	end

	if k == maxIterations
		success = false
	end

	if (pEvaluate(p, xk)).abs >= precision
		success = false
	end

	rootReference.numberValue = xk

	return success
end


def DurandKernerMethod(p, precision, maxIterations, rootsReference)

	n = p.length - 1.0
	rs = Array.new(n)
	rsPrev = Array.new(n)

	i = 0.0
	while(i < n)
		rsPrev[i] = i
		i = i + 1.0
	end

	success = false

	i = 0.0
	while(i < maxIterations && !success)
		j = 0.0
		while(j < n)
			xn1 = rsPrev[j]

			t1 = pEvaluate(p, xn1)
			t2 = 1.0
			k = 0.0
			while(k < n)
				if k < j
					t2 = t2*(xn1 - rs[k])
				end
				if k > j
					t2 = t2*(xn1 - rsPrev[k])
				end
				k = k + 1.0
			end
			t1 = t1.to_f / t2
			rs[j] = xn1 - t1
			j = j + 1.0
		end
		withinPrecision = 0.0
		j = 0.0
		while(j < n)
			if EpsilonCompare(rsPrev[j], rs[j], precision)
				withinPrecision = withinPrecision + 1.0
			end
			rsPrev[j] = rs[j]
			j = j + 1.0
		end
		if withinPrecision == n
			success = true
		end
		i = i + 1.0
	end

	rootsReference.numberArray = rs

	return success
end


def FindRootsComplex(p, rootsReference)
	return DurandKernerMethodComplex(p, 0.000001, 100.0, rootsReference)
end


def DurandKernerMethodComplex(p, precision, maxIterations, rootsReference)

	n = p.cs.length - 1.0
	rs = Array.new(n)
	i = 0.0
	while(i < n)
		rs[i] = cCreateComplexNumber(0.0, 0.0)
		i = i + 1.0
	end
	rsPrev = Array.new(n)
	i = 0.0
	while(i < n)
		rsPrev[i] = cCreateComplexNumber(0.4, 0.9)
		cPower(rsPrev[i], i)
		i = i + 1.0
	end
	t2 = cCreateComplexNumber(0.0, 0.0)
	t3 = cCreateComplexNumber(0.0, 0.0)

	success = false

	i = 0.0
	while(i < maxIterations && !success)
		j = 0.0
		while(j < n)
			xn1 = rsPrev[j]

			t1 = pEvaluateComplex(p, xn1)
			cAssignComplexByValues(t2, 1.0, 0.0)
			k = 0.0
			while(k < n)
				if k < j
					cAssignComplex(t3, xn1)
					cSub(t3, rs[k])
					cMul(t2, t3)
				end
				if k > j
					cAssignComplex(t3, xn1)
					cSub(t3, rsPrev[k])
					cMul(t2, t3)
				end
				k = k + 1.0
			end
			cDiv(t1, t2)
			cAssignComplex(rs[j], xn1)
			cSub(rs[j], t1)
			j = j + 1.0
		end
		withinPrecision = 0.0
		j = 0.0
		while(j < n)
			if cEpsilonCompareComplex(rsPrev[j], rs[j], precision)
				withinPrecision = withinPrecision + 1.0
			end
			cAssignComplex(rsPrev[j], rs[j])
			j = j + 1.0
		end
		if withinPrecision == n
			success = true
		end
		i = i + 1.0
	end

	rootsReference.complexNumbers = rs

	return success
end


def cCreateComplexNumber(re, im)

	z = CComplexNumber.new
	z.re = re
	z.im = im

	return z
end


def cCreatePolarComplexNumber(r, phi)

	p = CPolarComplexNumber.new
	p.r = r
	p.phi = phi

	return p
end


def cAdd(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = a + c
	z1.im = b + d
end


def cAddToNew(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = CComplexNumber.new

	x.re = a + c
	x.im = b + d

	return x
end


def cSub(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = a - c
	z1.im = b - d
end


def cSubToNew(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = CComplexNumber.new

	x.re = a - c
	x.im = b - d

	return x
end


def cMul(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = a*c - b*d
	z1.im = b*c + a*d
end


def cMulToNew(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = CComplexNumber.new

	x.re = a*c - b*d
	x.im = b*c + a*d

	return x
end


def cDiv(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	z1.re = (a*c + b*d).to_f / (c**2.0 + d**2.0)
	z1.im = (b*c - a*d).to_f / (c**2.0 + d**2.0)
end


def cDivToNew(z1, z2)

	a = z1.re
	b = z1.im
	c = z2.re
	d = z2.im

	x = CComplexNumber.new

	x.re = (a*c + b*d).to_f / (c**2.0 + d**2.0)
	x.im = (b*c - a*d).to_f / (c**2.0 + d**2.0)

	return x
end


def cConjugate(z)
	z.im = -z.im
end


def cConjugateToNew(z)

	x = CComplexNumber.new

	x.re = z.re
	x.im = -z.im

	return x
end


def cAbs(z)

	x = Math.sqrt(z.re**2.0 + z.im**2.0)

	return x
end


def cArg(z)

	x = Atan2(z.im, z.re)

	return x
end


def cCreatePolarFromComplexNumber(z)

	x = CPolarComplexNumber.new

	x.r = cAbs(z)
	x.phi = cArg(z)

	return x
end


def cCreateComplexFromPolar(p)

	z = CComplexNumber.new

	z.re = p.r*Math.cos(p.phi)
	z.im = p.r*Math.sin(p.phi)

	return z
end


def cRe(z)
	return z.re
end


def cIm(z)
	return z.im
end


def cAddPolar(p1, p2)

	z1 = cCreateComplexFromPolar(p1)
	z2 = cCreateComplexFromPolar(p2)

	cAdd(z1, z2)

	x = cCreatePolarFromComplexNumber(z1)

	p1.r = x.r
	p1.phi = x.phi

	delete(z1)
	delete(z2)
	delete(x)
end


def cAddPolarToNew(p1, p2)

	z1 = cCreateComplexFromPolar(p1)
	z2 = cCreateComplexFromPolar(p2)

	cAdd(z1, z2)

	x = cCreatePolarFromComplexNumber(z1)

	delete(z1)
	delete(z2)

	return x
end


def cSubPolar(p1, p2)

	z1 = cCreateComplexFromPolar(p1)
	z2 = cCreateComplexFromPolar(p2)

	cSub(z1, z2)

	x = cCreatePolarFromComplexNumber(z1)

	p1.r = x.r
	p1.phi = x.phi

	delete(z1)
	delete(z2)
	delete(x)
end


def cSubPolarToNew(p1, p2)

	z1 = cCreateComplexFromPolar(p1)
	z2 = cCreateComplexFromPolar(p2)

	cSub(z1, z2)

	x = cCreatePolarFromComplexNumber(z1)

	delete(z1)
	delete(z2)

	return x
end


def cMulPolar(p1, p2)

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	p1.r = r1*r2
	p1.phi = phi1 + phi2
end


def cMulPolarToNew(p1, p2)

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	x = CPolarComplexNumber.new

	x.r = r1*r2
	x.phi = phi1 + phi2

	return x
end


def cDivPolar(p1, p2)

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	p1.r = r1.to_f / r2
	p1.phi = phi1 - phi2
end


def cDivPolarToNew(p1, p2)

	r1 = p1.r
	r2 = p2.r
	phi1 = p1.phi
	phi2 = p2.phi

	x = CPolarComplexNumber.new

	x.r = r1.to_f / r2
	x.phi = phi1 - phi2

	return x
end


def cSquareRoot(z)

	a = z.re
	b = z.im

	m = Math.sqrt(a**2.0 + b**2.0)

	z.re = Math.sqrt((m + a).to_f / 2.0)
	z.im = Sign(b)*Math.sqrt((m - a).to_f / 2.0)
end


def cPowerPolar(p, n)
	p.r = p.r**n
	p.phi = p.phi*n
end


def cPowerToNew(z, n)

	p = cCreatePolarFromComplexNumber(z)
	cPowerPolar(p, n)
	zp = cCreateComplexFromPolar(p)

	delete(p)

	return zp
end


def cPower(z, n)

	zp = cPowerToNew(z, n)
	z.re = zp.re
	z.im = zp.im

	delete(zp)
end


def cNegate(z)
	z.re = Negate(z.re)
	z.im = Negate(z.im)
end


def cAssignComplexByValues(s, re, im)
	s.re = re
	s.im = im
end


def cAssignComplex(a, b)
	a.re = b.re
	a.im = b.im
end


def cEpsilonCompareComplex(a, b, epsilon)
	return EpsilonCompare(a.re, b.re, epsilon) && EpsilonCompare(a.im, b.im, epsilon)
end


def cExpComplex(x)

	re = Math.exp(x.re)*Math.cos(x.im)
	im = Math.exp(x.re)*Math.sin(x.im)
	x.re = re
	x.im = im
end


def cSineComplex(x)

	re = Math.sin(x.re)*Cosh(x.im)
	im = Math.cos(x.re)*Sinh(x.im)
	x.re = re
	x.im = im
end


def cCosineComplex(x)

	re = Math.cos(x.re)*Cosh(x.im)
	im = Math.sin(x.re)*Sinh(x.im)
	x.re = re
	x.im = im
end


def cComplexToString(a)

	ll = CreateLinkedListCharacter()

	number = CreateStringDecimalFromNumber(a.re)

	i = 0.0
	while(i < number.length)
		LinkedListAddCharacter(ll, number[i])
		i = i + 1.0
	end

	delete(number)

	if a.im < 0.0
		LinkedListAddCharacter(ll, "-")
		number = CreateStringDecimalFromNumber(-a.im)
	else
		LinkedListAddCharacter(ll, "+")
		number = CreateStringDecimalFromNumber(a.im)
	end

	i = 0.0
	while(i < number.length)
		LinkedListAddCharacter(ll, number[i])
		i = i + 1.0
	end

	delete(number)

	LinkedListAddCharacter(ll, "i")

	str = LinkedListCharactersToArray(ll)
	FreeLinkedListCharacter(ll)

	return str
end


def pPolynomialToTextDirect(p, x)

	buffer = StringReference.new

	ll = CreateLinkedListCharacter()

	if p.length == 0.0
		LinkedListAddCharacter(ll, "0")
	else
		i = 0.0
		while(i < p.length)
			c = p[i]
			if c < 0.0
				LinkedListAddCharacter(ll, "-")
			else
				LinkedListAddCharacter(ll, "+")
			end

			CreateStringFromNumberWithCheck((c).abs, 10.0, buffer)
			LinkedListCharactersAddString(ll, buffer.string)
			delete(buffer.string)

			LinkedListCharactersAddString(ll, x)
			LinkedListAddCharacter(ll, "^")

			CreateStringFromNumberWithCheck(i, 10.0, buffer)
			LinkedListCharactersAddString(ll, buffer.string)
			delete(buffer.string)
			i = i + 1.0
		end
	end

	str = LinkedListCharactersToArray(ll)
	FreeLinkedListCharacter(ll)

	return str
end


def pGenerateCommonRenderSpecification(p, showCoefficient, sign, coefficient, showPower, showX)

	setZero = false

	if p.length == 0.0
		setZero = true
	else
		zeros = 0.0
		i = 0.0
		while(i < p.length)
			if p[i] == 0.0
				zeros = zeros + 1.0
			end
			i = i + 1.0
		end

		if zeros == p.length
			setZero = true
		else
			showCoefficient.booleanArray = Array.new(p.length)
			sign.string = Array.new(p.length)
			coefficient.numberArray = Array.new(p.length)
			showPower.booleanArray = Array.new(p.length)
			showX.booleanArray = Array.new(p.length)

			i = 0.0
			while(i < p.length)
				c = p[i]

				if c < 0.0
					sign.string[i] = "-"
				else
					sign.string[i] = "+"
				end
				coefficient.numberArray[i] = (p[i]).abs
				if c == 0.0
					showCoefficient.booleanArray[i] = false
				else
if (c).abs == 1.0 && i > 0.0
						showCoefficient.booleanArray[i] = false
					else
						showCoefficient.booleanArray[i] = true
					end

					if i == 0.0
						showX.booleanArray[i] = false
						showPower.booleanArray[i] = false
					else
						showX.booleanArray[i] = true
						if i == 1.0
							showPower.booleanArray[i] = false
						else
							showPower.booleanArray[i] = true
						end
					end
				end
				i = i + 1.0
			end
		end
	end

	if setZero
		showCoefficient.booleanArray = Array.new(1)
		sign.string = Array.new(1)
		coefficient.numberArray = Array.new(1)
		showPower.booleanArray = Array.new(1)
		showX.booleanArray = Array.new(1)

		showCoefficient.booleanArray[0] = true
		sign.string[0] = "+"
		coefficient.numberArray[0] = 0.0
		showPower.booleanArray[0] = true
		showX.booleanArray[0] = false
	end
end


def pPolynomialToText(p, x)

	showCoefficient = CreateBooleanArrayReferenceLengthValue(0.0, false)
	showPower = CreateBooleanArrayReferenceLengthValue(0.0, false)
	showX = CreateBooleanArrayReferenceLengthValue(0.0, false)
	sign = CreateStringReferenceLengthValue(0.0, " ")
	coefficient = CreateNumberArrayReferenceLengthValue(0.0, 0.0)

	pGenerateCommonRenderSpecification(p, showCoefficient, sign, coefficient, showPower, showX)

	buffer = CreateStringReferenceLengthValue(0.0, " ")

	ll = CreateLinkedListCharacter()

	hasPrinted = false
	i = 0.0
	while(i < showCoefficient.booleanArray.length)
		c = p[i]

		if showCoefficient.booleanArray[i] || showX.booleanArray[i]
			if !hasPrinted && c >= 0.0
			else
				LinkedListAddCharacter(ll, sign.string[i])
			end

			if showCoefficient.booleanArray[i]
				CreateStringFromNumberWithCheck(coefficient.numberArray[i], 10.0, buffer)
				LinkedListCharactersAddString(ll, buffer.string)
				delete(buffer.string)
				hasPrinted = true
			end

			if showX.booleanArray[i]
				LinkedListCharactersAddString(ll, x)
				hasPrinted = true
				if showPower.booleanArray[i]
					LinkedListAddCharacter(ll, "^")
					CreateStringFromNumberWithCheck(i, 10.0, buffer)
					LinkedListCharactersAddString(ll, buffer.string)
					delete(buffer.string)
				end
			end
		end
		i = i + 1.0
	end

	str = LinkedListCharactersToArray(ll)
	FreeLinkedListCharacter(ll)

	return str
end


def pComplexPolynomialToTextDirect(p, x)

	buffer = StringReference.new

	ll = CreateLinkedListCharacter()

	if p.cs.length == 0.0
		LinkedListAddCharacter(ll, "0")
	else
		i = 0.0
		while(i < p.cs.length)
			c = p.cs[i]
			if i > 0.0
				LinkedListAddCharacter(ll, "+")
			end

			number = cComplexToString(c)
			LinkedListAddCharacter(ll, "(")
			LinkedListCharactersAddString(ll, number)
			LinkedListAddCharacter(ll, ")")
			delete(number)

			LinkedListCharactersAddString(ll, x)
			LinkedListAddCharacter(ll, "^")

			CreateStringFromNumberWithCheck(i, 10.0, buffer)
			LinkedListCharactersAddString(ll, buffer.string)
			delete(buffer.string)
			i = i + 1.0
		end
	end

	str = LinkedListCharactersToArray(ll)
	FreeLinkedListCharacter(ll)

	return str
end


def pAdd(a, b)

	nr = b.length

	i = 0.0
	while(i < nr)
		a[i] = a[i] + b[i]
		i = i + 1.0
	end
end


def pSubtract(a, b)

	nr = b.length

	i = 0.0
	while(i < nr)
		a[i] = a[i] - b[i]
		i = i + 1.0
	end
end


def pMultiply(c, a, b)

	n = pDegree(a)
	m = pDegree(b)

	pFill(c, 0.0)

	i = 0.0
	while(i <= n + m)
		c[i] = 0.0
		k = 0.0
		while(k <= i && k < a.length && i - k < b.length)
			av = a[k]
			bv = b[i - k]
			c[i] = c[i] + av*bv
			k = k + 1.0
		end
		i = i + 1.0
	end
end


def pDivide(q, r, n, d)

	pFill(q, 0.0)
	pAssign(r, n)
	deg = pDegree(n)
	t = pCreatePolynomial(deg)
	t1 = pCreatePolynomial(deg)

	rd = pDegree(r)
	dd = pDegree(d)
	i = 0.0
	while(i < deg + 1.0 && !pIsZero(r) && rd - i >= dd)
		pFill(t, 0.0)
		tdegree = rd - i - dd
		tcoff = r[rd - i].to_f / d[dd]
		t[tdegree] = tcoff
		pAdd(q, t)
		pFill(t1, 0.0)
		pMultiply(t1, t, d)
		pSubtract(r, t1)
		i = i + 1.0
	end

	delete(t)
	delete(t1)
end


def pIsZero(a)

	itIsZero = true

	i = 0.0
	while(i < a.length)
		if a[i] != 0.0
			itIsZero = false
		end
		i = i + 1.0
	end

	return itIsZero
end


def pAssign(a, b)

	nr = b.length

	i = 0.0
	while(i < nr)
		a[i] = b[i]
		i = i + 1.0
	end
end


def pCreatePolynomial(deg)

	p = Array.new(deg + 1.0)

	pFill(p, 0.0)

	return p
end


def pFill(p, value)

	i = 0.0
	while(i < p.length)
		p[i] = value
		i = i + 1.0
	end
end


def pDegree(a)

	done = false
	deg = 0.0
	i = a.length - 1.0
	while(i >= 0.0 && !done)
		if a[i] != 0.0
			deg = i
			done = true
		end
		i = i - 1.0
	end

	return deg
end


def pLead(a)

	deg = pDegree(a)

	return a[deg]
end


def pEvaluate(a, x)
	return pEvaluateWithHornersMethod(a, x)
end


def pEvaluateWithHornersMethod(a, x)

	r = 0.0

	i = a.length - 1.0
	while(i >= 0.0)
		r = r*x
		r = a[i] + r
		i = i - 1.0
	end

	return r
end


def pEvaluateWithPowers(a, x)

	r = 0.0

	i = 0.0
	while(i < a.length)
		r = r + a[i]*x**i
		i = i + 1.0
	end

	return r
end


def pEvaluateDerivative(a, x, n)

	r = 0.0

	i = 0.0
	while(i < a.length)
		if i - n >= 0.0
			v = a[i]*Permutations(i, n)*x**(i - n)
			r = r + v
		end
		i = i + 1.0
	end

	return r
end


def pDerivative(a)

	degree = 0.0
	i = 1.0
	while(i < a.length)
		degree = degree + 1.0
		a[i - 1.0] = degree*a[i]
		i = i + 1.0
	end

	a[a.length - 1.0] = 0.0
end


def pAddComplex(a, b)

	nr = a.cs.length

	i = 0.0
	while(i < nr)
		cAdd(a.cs[i], b.cs[i])
		i = i + 1.0
	end
end


def pSubtractComplex(a, b)

	nr = a.cs.length

	i = 0.0
	while(i < nr)
		cSub(a.cs[i], b.cs[i])
		i = i + 1.0
	end
end


def pIsZeroComplex(a)

	itIsZero = true

	i = 0.0
	while(i < a.cs.length)
		if a.cs[i].re != 0.0 && a.cs[i].im != 0.0
			itIsZero = false
		end
		i = i + 1.0
	end

	return itIsZero
end


def pAssignComplex(a, b)

	nr = b.cs.length

	i = 0.0
	while(i < nr)
		cAssignComplex(a.cs[i], b.cs[i])
		i = i + 1.0
	end
end


def pCreateComplexPolynomial(deg)

	p = PComplexPolynomial.new
	p.cs = Array.new(deg + 1.0)

	i = 0.0
	while(i < deg + 1.0)
		p.cs[i] = CComplexNumber.new
		i = i + 1.0
	end

	pFillComplex(p, 0.0, 0.0)

	return p
end


def pFillComplex(p, re, im)

	c = cCreateComplexNumber(re, im)

	i = 0.0
	while(i < p.cs.length)
		cAssignComplex(p.cs[i], c)
		i = i + 1.0
	end

	delete(c)
end


def pDegreeComplex(a)

	done = false
	deg = 0.0
	i = a.cs.length - 1.0
	while(i >= 0.0 && !done)
		if a.cs[i].re != 0.0 && a.cs[i].im != 0.0
			deg = i
			done = true
		end
		i = i - 1.0
	end

	return deg
end


def pLeadComplex(a)

	deg = pDegreeComplex(a)

	return a.cs[deg]
end


def pEvaluateComplex(a, x)

	r = cCreateComplexNumber(0.0, 0.0)
	t = cCreateComplexNumber(0.0, 0.0)

	i = 0.0
	while(i < a.cs.length)
		cAssignComplex(t, x)
		cPower(t, i)
		cMul(t, a.cs[i])
		cAdd(r, t)
		i = i + 1.0
	end

	return r
end


def pTotalNumberOfRoots(p)
	return pDegree(p)
end


def delete(x)
	# Ruby has garbage collection.
end

