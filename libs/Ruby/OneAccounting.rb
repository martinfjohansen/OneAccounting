
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

		AddMonthsToDate(date, 1.0)
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


def test()

	failures = CreateNumberReference(0.0)

	TestBasicAccounting(failures)
	TestAccruals(failures)
	TestIFRSAccountPlan(failures)

	return failures.numberValue
end


def TestIFRSAccountPlan(failures)
	GetIFRSAccountPlan()
end


def TestBasicAccounting(failures)

	ledger = CreateLedger(2.0)

	#c = CreateFixedPointForDynamicLedger(ledger);
	#d = CreateFixedPointForDynamicLedger(ledger);
	# Transaction 1:
	transaction = Array.new(2)
	#date = CreateDate(2026d, 2d, 18d);
	date = DateFromStringISO8601("2026-02-18".split(""))

	# Debit, 100, 1000, l1, 2026-02-18
=begin

        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
        
=end

	transaction[0] = CreateLineFromScript(ledger, "Debit, 1000, 100, l1".split(""), date)

	# Credit, 100, 2000, l2, 2026-02-18
=begin

        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
        
=end

	transaction[1] = CreateLineFromScript(ledger, "Credit, 2000, 100, l2".split(""), date)

	valid = ValidateAndAddTransactionToLedger(ledger, transaction)

	AssertTrue(valid, failures)

	# Compute
	sledger = LedgerDynamicToStatic(ledger)

	accountName = "1000".split("")
	from = DateFromStringISO8601("2026-02-17".split(""))
	to = DateFromStringISO8601("2026-02-19".split(""))
	account = ComputeAccountBalance(sledger, accountName, from, to)

	accountStr = AccountToString(account)

	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)".split(""), failures)
end


def TestAccruals(failures)

	ledger = CreateLedger(2.0)

	c = CreateFixedPointForDynamicLedger(ledger)
	d = CreateFixedPointForDynamicLedger(ledger)

=begin
 Case:
           * A domain is renewed for the period 2025-12-06 - 2026-12-05.
           * it is invoiced 2025-09-17 with a due date 2025-10-01, amount 125.00
           * It is paid 2025-10-01.
           * It is renewed 2025-11-08 by paying the renewal fee 112.50
           * The domain must be correctly accounted for using accruals for each month
         
=end


	# 1.8.1. Loans and receivables
	# 3.4.2. Deferred income and refund liabilities
	# 1.11.1. Cash
	# 1.8.1. Loans and receivables
	# 3.4.2. Deferred income and refund liabilities
	# 4.1.2 Services
	# 1.11.1. Cash
	# 1.7.1. Prepayments
	# 5.1.3. Services expense
	# 1.7.1. Prepayments
	# Transaction: Invoice sent
	transaction = Array.new(2)
	date = DateFromStringISO8601("2025-09-17".split(""))
	transaction[0] = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x".split(""), date)
	transaction[1] = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x".split(""), date)
	valid = ValidateAndAddTransactionToLedger(ledger, transaction)
	AssertTrue(valid, failures)

	# Transaction: Invoice paid
	transaction = Array.new(2)
	date = DateFromStringISO8601("2025-10-01".split(""))
	transaction[0] = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x".split(""), date)
	transaction[1] = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x".split(""), date)
	valid = ValidateAndAddTransactionToLedger(ledger, transaction)
	AssertTrue(valid, failures)

	# Transaction: Renewal paid
	transaction = Array.new(2)
	date = DateFromStringISO8601("2025-11-08".split(""))
	transaction[0] = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x".split(""), date)
	transaction[1] = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x".split(""), date)
	valid = ValidateAndAddTransactionToLedger(ledger, transaction)
	AssertTrue(valid, failures)

	# Accruals income
	from = DateFromStringISO8601("2025-12-06".split(""))
	to = DateFromStringISO8601("2026-12-05".split(""))
	AddMonthlyAccruals(ledger, from, to, 125.0, "3.4.2".split(""), "4.1.2".split(""))

	# Accruals cost
	from = DateFromStringISO8601("2025-12-06".split(""))
	to = DateFromStringISO8601("2026-12-05".split(""))
	AddMonthlyAccruals(ledger, from, to, 112.50, "5.1.3".split(""), "1.7.1".split(""))

	# Compute
	sledger = LedgerDynamicToStatic(ledger)

	from = DateFromStringISO8601("2027-01-01".split(""))
	to = DateFromStringISO8601("2027-01-01".split(""))

	account = ComputeAccountBalance(sledger, "5.1.3".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "4.1.2".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "1.8.1".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "3.4.2".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "1.11.1".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "1.7.1".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(""), failures)

	#System.out.println("");
	# In between
	from = DateFromStringISO8601("2026-06-15".split(""))
	to = DateFromStringISO8601("2026-06-16".split(""))

	account = ComputeAccountBalance(sledger, "5.1.3".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "4.1.2".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "1.8.1".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "3.4.2".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "1.11.1".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".split(""), failures)

	account = ComputeAccountBalance(sledger, "1.7.1".split(""), from, to)
	accountStr = AccountToString(account)
	#System.out.println(accountStr);
	AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)".split(""), failures)

	# Balance Sheet: Snapshots a companys assets, liabilities, and equity at a specific point in time.
	# Income Statement (P&L): Shows revenue, expenses, and profit/loss over a period.
	# Cash Flow Statement: Tracks cash inflow and outflow from operating, investing, and financing activities.
	# Statement of Shareholders' Equity: Details changes in owner interest over time.
=begin
accountPlan = new AccountPlan();
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
        sledger.accountPlan = accountPlan
=end


	sledger.accountPlan = GetIFRSAccountPlan()

	to = DateFromStringISO8601("2026-02-16".split(""))
	balanceSheetRef = DataReference.new
	success = ComputeAccountBalances(sledger, 2.0, to, balanceSheetRef)
	accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure)
	AssertTrue(success, failures)
	#System.out.println(accountSummaryStr);
	# Compute monthly table
	to = DateFromStringISO8601("2025-08-01".split(""))
	message = StringReference.new
	AddDaysToDate(to, -1.0, message)
	balances = CreateArray()
	i = 0.0
	while(i < 12.0 + 6.0)
		AddDaysToDate(to, 1.0, message)
		AddMonthsToDate(to, 1.0)
		AddDaysToDate(to, -1.0, message)

		balanceSheetRef = DataReference.new
		success = ComputeAccountBalances(sledger, 1.0, to, balanceSheetRef)

		if success
			AddStructToArray(balances, balanceSheetRef.data.structure)
		end
		i = i + 1.0
	end
	ComputeBalanceDiffs(sledger, balances)

	html = BalancesArrayToHTML(balances, true, false)

	#StringToFile("x.html", html);
	html = BalancesArrayToHTML(balances, false, true)

	#StringToFile("x-diff.html", html);
	html = BalancesArrayToHTML(balances, true, true)
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
	ref.string = value

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

	i = 0.0
	while(i < stringArrayReference.stringArray.length)
		delete(stringArrayReference.stringArray[i])
		i = i + 1.0
	end
	delete(stringArrayReference.stringArray)
	delete(stringArrayReference)
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
		if date.month >= 1.0 && date.month <= 12.0
			daysInMonth = GetDaysInMonth(date.year)
			daysInThisMonth = daysInMonth[date.month]
			if date.day >= 1.0 && date.day <= daysInThisMonth
				valid = true
			else
				valid = false
				message.string = "The month does not have the given day number.".split("")
			end
		else
			valid = false
			message.string = "Month must be between 1 and 12, inclusive.".split("")
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


def AddMonthsToDate(date, months)

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

	aDays = DateToDays(a)
	bDays = DateToDays(b)

	return aDays < bDays
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

	done = false
	dateOfInterest = Date.new
	AssignDate(dateOfInterest, from)
	while(!done)
		if dateOfInterest.year == to.year && dateOfInterest.month == to.month
			done = true
		end

		entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest.year, dateOfInterest.month)
		LinkedListAddNumber(list, entry)
		AddMonthsToDate(dateOfInterest, 1.0)
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

	string = CreateDynamicArrayCharacters()
	isPositive = true

	if number < 0.0
		isPositive = false
		number = -number
	end

	if number == 0.0
		DynamicArrayAddCharacter(string, "0")
	else
		characterReference = CharacterReference.new

		maximumDigits = GetMaximumDigitsForDecimal()

		digitPosition = GetFirstDecimalDigitPosition(number)

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
			d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1.0)
			if d == 0.0
				trailingZeros = trailingZeros + 1.0
			else
				done = true
			end
			i = i + 1.0
		end

		# Print number.
		i = 0.0
		while(i < maximumDigits)
			d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i)

			if !hasPrintedPoint && digitPosition - i + 1.0 == 0.0
				if maximumDigits - i > trailingZeros
					DynamicArrayAddCharacter(string, ".")
				end
				hasPrintedPoint = true
			end

			if maximumDigits - i <= trailingZeros && hasPrintedPoint
			else
				GetDecimalDigitCharacterFromNumberWithCheck(d, characterReference)
				c = characterReference.characterValue
				DynamicArrayAddCharacter(string, c)
			end
			i = i + 1.0
		end

		# Print trailing zeros.
		i = 0.0
		while(i < digitPosition - maximumDigits + 1.0)
			DynamicArrayAddCharacter(string, "0")
			i = i + 1.0
		end
	end

	# Done
	str = DynamicArrayCharactersToArray(string)
	FreeDynamicArrayCharacters(string)
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


def GetFirstDecimalDigitPosition(n)

	n = (n).abs

	if n != 0.0
		if (n).floor < 10.0**15.0
			multiply = true
		else
			multiply = false
		end

		done = false
		m = 0.0
		i = 0.0
		while(!done)
			if multiply
				m = n*10.0**i
				if (m).floor >= 10.0**14.0
					done = true
				end
			else
				m = n.to_f / 10.0**i
				if (m).floor < 10.0**15.0
					done = true
				end
			end
			i = i + 1.0
		end

		if multiply
			power = 15.0 - i
		else
			power = 15.0 + i - 2.0
		end

		if Round(m) >= 10.0**15.0
			power = power + 1.0
		end
	else
		power = 1.0
	end

	return power
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

	e = 15.0 - digitPosition - 1.0
	if e < 0.0
		n = (n.to_f / 10.0**(e).abs).round
	else
		n = (n*10.0**e).round
	end

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
	return CreateNumberFromStringWithCheck(string, 10.0, decimalReference, message)
end


def CreateNumberFromDecimalString(string)

	doubleReference = CreateNumberReference(0.0)
	stringReference = CreateStringReference("".split(""))
	CreateNumberFromStringWithCheck(string, 10.0, doubleReference, stringReference)
	number = doubleReference.numberValue

	delete(doubleReference)
	delete(stringReference)

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


def CreateNumberFromParts(base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent)

	n = 0.0

	i = 0.0
	while(i < beforePoint.length)
		p = beforePoint[beforePoint.length - i - 1.0]

		n = n + p*base**i
		i = i + 1.0
	end

	i = 0.0
	while(i < afterPoint.length)
		p = afterPoint[i]

		n = n + p.to_f / base**(i + 1.0)
		i = i + 1.0
	end

	if exponent.length > 0.0
		e = 0.0
		i = 0.0
		while(i < exponent.length)
			p = exponent[exponent.length - i - 1.0]

			e = e + p*base**i
			i = i + 1.0
		end

		if !exponentIsPositive
			e = -e
		end

		n = n*base**e
	end

	if !numberIsPositive
		n = -n
	end

	return n
end


def ExtractPartsFromNumberString(n, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, errorMessages)

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
		errorMessages.string = "Number cannot have length zero.".split("")
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
			errorMessages.string = "Number must have at least one number after the optional sign.".split("")
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
					errorMessages.string = "There must be at least one digit after the decimal point.".split("")
				end
			else
				success = false
				errorMessages.string = "There must be at least one digit after the decimal point.".split("")
			end
		elsif base <= 14.0 && (n[i] == "e" || n[i] == "E")
			if i < n.length
				success = true
				afterPoint.numberArray = Array.new(0)
			else
				success = false
				errorMessages.string = "There must be at least one digit after the exponent.".split("")
			end
		else
			success = false
			errorMessages.string = "Expected decimal point or exponent symbol.".split("")
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
							errorMessages.string = "There cannot be any characters past the exponent of the number.".split("")
						end
					else
						success = false
						errorMessages.string = "There must be at least one digit after the decimal point.".split("")
					end
				else
					success = false
					errorMessages.string = "There must be at least one digit after the exponent symbol.".split("")
				end
			else
				success = false
				errorMessages.string = "There must be at least one digit after the exponent symbol.".split("")
			end
		else
			success = false
			errorMessages.string = "Expected exponent symbol.".split("")
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


def delete(x)
	# Ruby has garbage collection.
end

