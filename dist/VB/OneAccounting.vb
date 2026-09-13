' Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

Imports System.Math

Public Class Account
	Public name As Char ()
	Public endingBalance As FixedPoint15d
	Public startingBalance As FixedPoint15d
	Public from As Datex
	Public tox As Datex
	Public sumDebit As FixedPoint15d
	Public sumCredit As FixedPoint15d
End Class

Public Class AccountDefinition
	Public accountName As Char ()
	Public number As Char ()
	Public role As Char ()
	Public debitBalance As Boolean
End Class

Public Class AccountPlan
	Public accountDefinitions As AccountDefinition ()
End Class

Public Class Ledger
	Public decimals As Double
	Public transactions As Transaction ()
	Public accountPlan As AccountPlan
End Class

Public Class Line
	Public account As Char ()
	Public debit As FixedPoint15d
	Public credit As FixedPoint15d
	Public description As Char ()
	Public datex As Datex
End Class

Public Class Transaction
	Public lines As Line ()
End Class

Public Class BooleanArrayReference
	Public booleanArray As Boolean ()
End Class

Public Class BooleanReference
	Public booleanValue As Boolean
End Class

Public Class CharacterReference
	Public characterValue As Char
End Class

Public Class NumberArrayReference
	Public numberArray As Double ()
End Class

Public Class NumberReference
	Public numberValue As Double
End Class

Public Class StringArrayReference
	Public stringArray As StringReference ()
End Class

Public Class StringReference
	Public stringx As Char ()
End Class

Public Class Datex
	Public year As Double
	Public month As Double
	Public day As Double
End Class

Public Class DateReference
	Public datex As Datex
End Class

Public Class Interval
	Public first As Datex
	Public last As Datex
End Class

Public Class DateTimeTimezone
	Public dateTimex As DateTimex
	Public timezoneOffsetSeconds As Double
End Class

Public Class DateTimeTimezoneReference
	Public dateTimeTimezone As DateTimeTimezone
End Class

Public Class DateTimex
	Public datex As Datex
	Public hours As Double
	Public minutes As Double
	Public seconds As Double
End Class

Public Class DateTimeReference
	Public dateTimex As DateTimex
End Class

Public Class FixedPoint30d
	Public part1 As Double
	Public part2 As Double
	Public digitsBeforeDecimalPoint As Double
	Public digitsAfterDecimalPoint As Double
End Class

Public Class FixedPoint15d
	Public number As Double
	Public digitsBeforeDecimalPoint As Double
	Public digitsAfterDecimalPoint As Double
End Class

Public Class DynamicArrayCharacters
	Public arrayx As Char ()
	Public length As Double
End Class

Public Class LinkedListNodeStrings
	Public endx As Boolean
	Public value As Char ()
	Public nextx As LinkedListNodeStrings
End Class

Public Class LinkedListStrings
	Public first As LinkedListNodeStrings
	Public last As LinkedListNodeStrings
End Class

Public Class LinkedListNodeNumbers
	Public nextx As LinkedListNodeNumbers
	Public endx As Boolean
	Public value As Double
End Class

Public Class LinkedListNumbers
	Public first As LinkedListNodeNumbers
	Public last As LinkedListNodeNumbers
End Class

Public Class LinkedListCharacters
	Public first As LinkedListNodeCharacters
	Public last As LinkedListNodeCharacters
End Class

Public Class LinkedListNodeCharacters
	Public endx As Boolean
	Public value As Char
	Public nextx As LinkedListNodeCharacters
End Class

Public Class DynamicArrayNumbers
	Public arrayx As Double ()
	Public length As Double
End Class

Public Class Arrayx
	Public arrayx As Data ()
	Public length As Double
End Class

Public Class Data
	Public isStruture As Boolean
	Public isArray As Boolean
	Public isNumber As Boolean
	Public isString As Boolean
	Public isBoolean As Boolean
	Public structurex As Structurex
	Public arrayx As Arrayx
	Public number As Double
	Public booleanxx As Boolean
	Public stringx As Char ()
End Class

Public Class DataReference
	Public data As Data
End Class

Public Class Structurex
	Public keys As Arrayx
	Public values As Arrayx
End Class

Module Accounting
	Public Function CreateLedger(decimals As Double) As Structurex
		Dim ledger As Structurex
		Dim transactions As Arrayx

		ledger = CreateStructure()
		transactions = CreateArray()
		Call AddNumberToStruct(ledger, "decimals".ToCharArray(), decimals)
		Call AddArrayToStruct(ledger, "transactions".ToCharArray(), transactions)

		Return ledger
	End Function


	Public Function CreateFixedPointForDynamicLedger(ByRef ledger As Structurex) As FixedPoint15d
		Dim n As FixedPoint15d
		Dim d As Double

		d = GetNumberFromStruct(ledger, "decimals".ToCharArray())
		n = CreateFixedPoint15d(15.0 - d, d)

		Return n
	End Function


	Public Function CreateFixedPointForStaticLedger(ByRef ledger As Ledger) As FixedPoint15d
		Dim n As FixedPoint15d
		Dim d As Double

		d = ledger.decimals
		n = CreateFixedPoint15d(15.0 - d, d)

		Return n
	End Function


	Public Function CreateLine(ByRef account As Char (), ByRef debit As FixedPoint15d, ByRef credit As FixedPoint15d, ByRef description As Char (), ByRef datex As Datex) As Line
		Dim t As Line

		t = New Line()

		t.account = arraysCopyString(account)
		t.debit = Copy15d(debit)
		t.credit = Copy15d(credit)
		t.description = arraysCopyString(description)
		t.datex = CopyDate(datex)

		Return t
	End Function


	Public Sub AddTransactionToLedger(ByRef ledger As Arrayx, ByRef src As Line)
		Dim dst As Structurex

		dst = LineToStructure(src)

		Call AddStructToArray(ledger, dst)
	End Sub


	Public Sub AddTransactionsToLedger(ByRef ledger As Arrayx, ByRef ts As Line ())
		Dim dst As Structurex
		Dim i As Double

		i = 0.0
		While i < ts.Length
			dst = LineToStructure(ts(i))
			Call AddStructToArray(ledger, dst)
			i = i + 1.0
		End While
	End Sub


	Public Function ValidateAndAddTransactionToLedger(ByRef ledger As Structurex, ByRef ls As Line ()) As Boolean
		Dim dst As Structurex
		Dim i As Double
		Dim valid As Boolean
		Dim transactions As Arrayx
		Dim lines As Arrayx

		transactions = GetArrayFromStruct(ledger, "transactions".ToCharArray())

		valid = ValidateTransaction(ls, ledger)

		If valid
			lines = CreateArray()

			i = 0.0
			While i < ls.Length
				dst = LineToStructure(ls(i))
				Call AddStructToArray(lines, dst)
				i = i + 1.0
			End While

			Call AddArrayToArray(transactions, lines)
		End If

		Return valid
	End Function


	Public Function GetTransactionFromLedger(ByRef ledger As Structurex, index As Double) As Line
		Dim dst As Structurex
		Dim t As Line
		Dim transactions As Arrayx
		Dim decimals As Double

		transactions = GetArrayFromStruct(ledger, "transactions".ToCharArray())
		decimals = GetNumberFromStruct(ledger, "decimals".ToCharArray())

		dst = ArrayIndexStruct(transactions, index)

		t = LineFromStructure(dst, ledger)

		Return t
	End Function


	Public Function LineToStructure(ByRef src As Line) As Structurex
		Dim dst As Structurex
		Dim debitStr, creditStr, dateStr As Char ()

		dst = CreateStructure()

		debitStr = ToString15d(src.debit)
		creditStr = ToString15d(src.credit)
		dateStr = DateToStringISO8601(src.datex)

		Call AddStringToStruct(dst, "account".ToCharArray(), src.account)
		Call AddStringToStruct(dst, "debit".ToCharArray(), debitStr)
		Call AddStringToStruct(dst, "credit".ToCharArray(), creditStr)
		Call AddStringToStruct(dst, "date".ToCharArray(), dateStr)
		Call AddStringToStruct(dst, "description".ToCharArray(), src.description)

		Return dst
	End Function


	Public Function LineFromStructure(ByRef src As Structurex, ByRef ledger As Structurex) As Line
		Dim dst As Line
		Dim account, debitStr, creditStr, dateStr, description As Char ()
		Dim debit, credit As FixedPoint15d
		Dim datex As Datex
		Dim debitNumber, creditNumber As Double

		account = GetStringFromStruct(src, "account".ToCharArray())
		debitStr = GetStringFromStruct(src, "debit".ToCharArray())
		creditStr = GetStringFromStruct(src, "credit".ToCharArray())
		dateStr = GetStringFromStruct(src, "date".ToCharArray())
		description = GetStringFromStruct(src, "description".ToCharArray())

		debitNumber = CreateNumberFromDecimalString(debitStr)
		creditNumber = CreateNumberFromDecimalString(creditStr)

		debit = CreateFixedPointForDynamicLedger(ledger)
		credit = CreateFixedPointForDynamicLedger(ledger)
		Assign15d(debit, debitNumber)
		Assign15d(credit, creditNumber)

		datex = DateFromStringISO8601(dateStr)

		dst = CreateLine(account, debit, credit, description, datex)

		Return dst
	End Function


	Public Function LedgerDynamicToStatic(ByRef src As Structurex) As Ledger
		Dim dst As Ledger
		Dim ts, ls, i, j, decimals As Double
		Dim line As Structurex
		Dim transactions, lines As Arrayx
		Dim sline As Line
		Dim t As Transaction

		dst = New Ledger()

		transactions = GetArrayFromStruct(src, "transactions".ToCharArray())
		decimals = GetNumberFromStruct(src, "decimals".ToCharArray())
		ts = ArrayLength(transactions)

		dst.decimals = decimals
		dst.transactions = New Transaction (ts - 1){}

		i = 0.0
		While i < ts
			lines = ArrayIndexArray(transactions, i)
			ls = ArrayLength(lines)

			t = New Transaction()
			t.lines = New Line (ls - 1){}

			j = 0.0
			While j < ls
				line = ArrayIndexStruct(lines, j)
				sline = LineFromStructure(line, src)
				t.lines(j) = sline
				j = j + 1.0
			End While

			dst.transactions(i) = t
			i = i + 1.0
		End While

		Return dst
	End Function


	Public Function ValidateTransaction(ByRef ts As Line (), ByRef ledger As Structurex) As Boolean
		Dim valid As Boolean
		Dim creditSum, debitSum As FixedPoint15d
		Dim i, d, c As Double
		Dim t As Line
		Dim creditStr, debitStr As Char ()
		Dim datex As Datex

		valid = true

		If ts.Length > 0.0
			datex = ts(0).datex

			creditSum = CreateFixedPointForDynamicLedger(ledger)
			debitSum = CreateFixedPointForDynamicLedger(ledger)

			i = 0.0
			While i < ts.Length And valid
				t = ts(i)

				d = ToNumber15d(t.debit)
				c = ToNumber15d(t.credit)

				Add15d(creditSum, creditSum, t.credit)
				Add15d(debitSum, debitSum, t.debit)

				If DateEquals(datex, t.datex) And (d = 0.0 Or c = 0.0)
				Else
					valid = false
				End If
				i = i + 1.0
			End While

			If valid
				creditStr = ToString15d(creditSum)
				debitStr = ToString15d(creditSum)

				valid = arraysStringsEqual(creditStr, debitStr)
			End If
		End If

		Return valid
	End Function


	Public Function ValidateTransactions(ByRef ts As Line (), ByRef invalidIds As NumberArrayReference) As Boolean
		Dim valid As Boolean

		' TODO
		valid = true

		Return valid
	End Function


	Public Function ComputeAccountBalance(ByRef ledger As Ledger, ByRef accountName As Char (), ByRef fromDate As Datex, ByRef toDate As Datex) As Account
		Dim a As Account
		Dim i, j As Double
		Dim t As Transaction
		Dim ts As Transaction ()
		Dim l As Line

		ts = ledger.transactions

		a = New Account()

		a.name = arraysCopyString(accountName)
		a.endingBalance = CreateFixedPointForStaticLedger(ledger)
		a.startingBalance = CreateFixedPointForStaticLedger(ledger)
		a.from = CopyDate(fromDate)
		a.tox = CopyDate(toDate)
		a.sumDebit = CreateFixedPointForStaticLedger(ledger)
		a.sumCredit = CreateFixedPointForStaticLedger(ledger)

		i = 0.0
		While i < ts.Length
			t = ts(i)

			j = 0.0
			While j < t.lines.Length
				l = t.lines(j)

				If arraysStringsEqual(l.account, accountName)

					If DateLessThan(l.datex, fromDate)
						Add15d(a.startingBalance, a.startingBalance, l.debit)
						Subtract15d(a.startingBalance, a.startingBalance, l.credit)
					ElseIf DateLessThan(l.datex, toDate)
						Add15d(a.endingBalance, a.endingBalance, l.debit)
						Subtract15d(a.endingBalance, a.endingBalance, l.credit)

						Add15d(a.sumDebit, a.sumDebit, l.debit)
						Add15d(a.sumCredit, a.sumCredit, l.credit)
					End If
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Add15d(a.endingBalance, a.endingBalance, a.startingBalance)

		Return a
	End Function


	Public Function AccountToString(ByRef account As Account) As Char ()
		Dim ll As LinkedListCharacters
		Dim diff As FixedPoint15d

		ll = CreateLinkedListCharacter()

		diff = Copy15d(account.endingBalance)
		Subtract15d(diff, diff, account.startingBalance)

		Call LinkedListCharactersAddString(ll, account.name)
		Call LinkedListCharactersAddString(ll, ": ".ToCharArray())
		Call LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.startingBalance, 2.0, "".ToCharArray(), ".".ToCharArray()))
		Call LinkedListCharactersAddString(ll, " -> ".ToCharArray())
		Call LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.endingBalance, 2.0, "".ToCharArray(), ".".ToCharArray()))
		Call LinkedListCharactersAddString(ll, ": ".ToCharArray())
		Call LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2.0, ",".ToCharArray(), ".".ToCharArray()))
		Call LinkedListCharactersAddString(ll, " (+".ToCharArray())
		Call LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumDebit, 2.0, "".ToCharArray(), ".".ToCharArray()))
		Call LinkedListCharactersAddString(ll, ", -".ToCharArray())
		Call LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumCredit, 2.0, "".ToCharArray(), ".".ToCharArray()))
		Call LinkedListCharactersAddString(ll, ")".ToCharArray())

		Return LinkedListCharactersToArray(ll)
	End Function


	Public Sub AddMonthlyAccruals(ByRef ledger As Structurex, ByRef from As Datex, ByRef tox As Datex, amount As Double, ByRef fromAccount As Char (), ByRef toAccount As Char ())
		Dim i As Double
		Dim accountName, desc As Char ()
		Dim amounts As Double ()
		Dim transaction As Line ()
		Dim valid As Boolean
		Dim datex As Datex
		Dim c, d As FixedPoint15d

		amounts = GetAccrualsWithDates(amount, from, tox)

		datex = CopyDate(from)
		datex.day = 1.0

		c = CreateFixedPointForDynamicLedger(ledger)
		d = CreateFixedPointForDynamicLedger(ledger)

		i = 0.0
		While i < amounts.Length
			transaction = New Line (2 - 1){}

			accountName = fromAccount
			Assign15d(d, amounts(i))
			Assign15d(c, 0.0)
			desc = "x".ToCharArray()
			transaction(0) = CreateLine(accountName, d, c, desc, datex)

			accountName = toAccount
			Assign15d(d, 0.0)
			Assign15d(c, amounts(i))
			desc = "x".ToCharArray()
			transaction(1) = CreateLine(accountName, d, c, desc, datex)

			valid = ValidateAndAddTransactionToLedger(ledger, transaction)

			Call AddMonthsToDate(datex, 1.0)
			i = i + 1.0
		End While
	End Sub


	Public Function ComputeAccountBalancePrefixAccount(ByRef ledger As Ledger, ByRef accountNr As Char (), ByRef toDate As Datex, debitBalance As Boolean) As FixedPoint15d
		Dim i, j As Double
		Dim t As Transaction
		Dim ts As Transaction ()
		Dim l As Line
		Dim balance As FixedPoint15d
		Dim prefixL As LinkedListCharacters
		Dim prefixed As Char ()

		prefixL = CreateLinkedListCharacter()
		Call LinkedListCharactersAddString(prefixL, accountNr)
		Call LinkedListCharactersAddString(prefixL, ".".ToCharArray())

		prefixed = LinkedListCharactersToArray(prefixL)

		ts = ledger.transactions

		balance = CreateFixedPointForStaticLedger(ledger)

		i = 0.0
		While i < ts.Length
			t = ts(i)

			j = 0.0
			While j < t.lines.Length
				l = t.lines(j)

				If strStartsWith(l.account, prefixed) Or arraysStringsEqual(l.account, accountNr)
					If DateLessThan(l.datex, toDate) Or DateEquals(l.datex, toDate)
						If debitBalance
							Add15d(balance, balance, l.debit)
							Subtract15d(balance, balance, l.credit)
						Else
							Add15d(balance, balance, l.credit)
							Subtract15d(balance, balance, l.debit)
						End If
					End If
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return balance
	End Function


	Public Function GetIFRSAccountPlan() As AccountPlan
		Dim accountPlanString As Char ()
		Dim validRef As BooleanReference
		Dim ll As LinkedListCharacters

		ll = CreateLinkedListCharacter()

		' https://www.ifrs-gaap.com/ifrs-chart-accounts
		validRef = CreateBooleanReference(false)

		Call LinkedListCharactersAddString(ll, "1" + Chrw(9) + "Assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1" + Chrw(9) + "Property, plant and equipment" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.1" + Chrw(9) + "Land and land improvements" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.2" + Chrw(9) + "Buildings, structures and improvements" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.3" + Chrw(9) + "Machinery and equipment" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.4" + Chrw(9) + "Fixtures and fittings" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.5" + Chrw(9) + "Right of use assets (classified as PP&E)" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.6" + Chrw(9) + "Additional property, plant and equipment" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1.7" + Chrw(9) + "Construction in progress" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.2" + Chrw(9) + "Investment property" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.2.1" + Chrw(9) + "Completed" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.2.2" + Chrw(9) + "Under construction or development" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.3" + Chrw(9) + "Goodwill" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4" + Chrw(9) + "Intangible assets excluding goodwill" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.1" + Chrw(9) + "Intellectual property" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.2" + Chrw(9) + "Computer software" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.3" + Chrw(9) + "Trade and distribution assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.4" + Chrw(9) + "Contracts and rights" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.5" + Chrw(9) + "Right of use assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.6" + Chrw(9) + "Crypto assets (classified as intangible)" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.7" + Chrw(9) + "Additional intangible assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.4.8" + Chrw(9) + "Acquisition in progress" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.5" + Chrw(9) + "Financial assets and investments" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.5.1" + Chrw(9) + "Non-derivative financial assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.5.2" + Chrw(9) + "Derivative financial assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.5.3" + Chrw(9) + "Additional financial assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.5.4" + Chrw(9) + "Crypto assets (classified as financial assets)" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.6" + Chrw(9) + "Inventories" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.6.1" + Chrw(9) + "Merchandise" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.6.2" + Chrw(9) + "Raw materials and production supplies" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.6.3" + Chrw(9) + "Work in progress" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.6.4" + Chrw(9) + "Finished goods" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.6.5" + Chrw(9) + "Other inventories" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.7" + Chrw(9) + "Prepayments and accrued income" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.7.1" + Chrw(9) + "Prepayments" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.7.2" + Chrw(9) + "Accrued income" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.7.3" + Chrw(9) + "Service provider work in process (not classified as inventory)" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.7.4" + Chrw(9) + "Additional assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.8" + Chrw(9) + "Receivables and contracts" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.8.1" + Chrw(9) + "Loans and receivables" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.8.2" + Chrw(9) + "Contracts with customers" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.8.3" + Chrw(9) + "Nontrade and other receivables" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.9" + Chrw(9) + "Tax assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.9.1" + Chrw(9) + "Tax assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.9.2" + Chrw(9) + "Deferred tax assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.9.3" + Chrw(9) + "Other tax assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.1" + Chrw(9) + "Agricultural biological assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.10.1" + Chrw(9) + "Bearer plants" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.10.2" + Chrw(9) + "Animals" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.10.3" + Chrw(9) + "Other agricultural assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.11" + Chrw(9) + "Cash and cash equivalents" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.11.1" + Chrw(9) + "Cash" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.11.2" + Chrw(9) + "Cash equivalents" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "1.11.3" + Chrw(9) + "Restricted cash and financial assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2" + Chrw(9) + "Equity" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.1" + Chrw(9) + "Total equity attributable to owners of parent" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.1.1" + Chrw(9) + "Issued capital" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.1.2" + Chrw(9) + "Additional item paid-in capital" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.1.3" + Chrw(9) + "Partner\'s capital" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.1.4" + Chrw(9) + "Member\'s equity" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.1.5" + Chrw(9) + "Other equity interest" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.2" + Chrw(9) + "Retained earnings" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.2.1" + Chrw(9) + "Retained earnings profit loss for reporting period" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.2.2" + Chrw(9) + "Retained earnings excluding profit loss for reporting period" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.2.3" + Chrw(9) + "In suspense" + Chrw(9) + "Zero" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.3" + Chrw(9) + "Accumulated other comprehensive income" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.3.1" + Chrw(9) + "Accumulated OCI, reserves" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.3.2" + Chrw(9) + "Miscellaneous equity" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.4" + Chrw(9) + "Owners equity (non-shareholder)" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "2.5" + Chrw(9) + "Non-controlling interests" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3" + Chrw(9) + "Liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.1" + Chrw(9) + "Trade and other payables" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.1.1" + Chrw(9) + "Trade payables" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.1.2" + Chrw(9) + "Dividend payables" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.1.3" + Chrw(9) + "Interest payable" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.1.4" + Chrw(9) + "Other payables" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.2" + Chrw(9) + "Provisions" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.2.1" + Chrw(9) + "Customer related provisions" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.2.2" + Chrw(9) + "Litigation and regulatory" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.2.3" + Chrw(9) + "Additional provisions" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3" + Chrw(9) + "Other financial liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3.1" + Chrw(9) + "Notes payable" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3.2" + Chrw(9) + "Loans received" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3.3" + Chrw(9) + "Bonds (debentures)" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3.4" + Chrw(9) + "Other debts and borrowings" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3.5" + Chrw(9) + "Lease obligations" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.3.6" + Chrw(9) + "Derivative financial liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.4" + Chrw(9) + "Accruals, deferrals and additional liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.4.1" + Chrw(9) + "Accruals" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.4.2" + Chrw(9) + "Deferred income and refund liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.4.3" + Chrw(9) + "Accrued taxes other than payroll" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "3.4.4" + Chrw(9) + "Additional liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4" + Chrw(9) + "Revenue" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.1" + Chrw(9) + "Recognized point of time" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.1.1" + Chrw(9) + "Goods" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.1.2" + Chrw(9) + "Services" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.2" + Chrw(9) + "Recognized over time" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.2.1" + Chrw(9) + "Products and projects" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.2.2" + Chrw(9) + "Services" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.3" + Chrw(9) + "Adjustments" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.3.1" + Chrw(9) + "Variable consideration" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.3.2" + Chrw(9) + "Consideration paid payable to customers" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "4.3.3" + Chrw(9) + "Other adjustments" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5" + Chrw(9) + "Expenses" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1" + Chrw(9) + "Expenses (classified by nature)" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1.1" + Chrw(9) + "Material and merchandise" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1.2" + Chrw(9) + "Employee benefits expense" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1.3" + Chrw(9) + "Services expense" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1.4" + Chrw(9) + "Rent, depreciation, amortization and depletion" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1.5" + Chrw(9) + "Increase in decrease in inventories of finished goods and work in progress" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.1.6" + Chrw(9) + "Other work performed by entity and capitalized" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.2" + Chrw(9) + "Expenses (classified by function)" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.2.1" + Chrw(9) + "Cost of sales" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "5.2.2" + Chrw(9) + "Selling, general and administrative expense" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6" + Chrw(9) + "Other non-operating income and expenses" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6.1" + Chrw(9) + "Other revenue and expenses" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6.1.1" + Chrw(9) + "Other revenue" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6.1.2" + Chrw(9) + "Other expenses" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6.2" + Chrw(9) + "Gains and losses" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6.3" + Chrw(9) + "Taxes other than income and payroll and fees" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "6.4" + Chrw(9) + "Tax income (expense)" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7" + Chrw(9) + "Intercompany and related party accounts" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.1" + Chrw(9) + "Intercompany and related party assets" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.1.1" + Chrw(9) + "Intercompany balances eliminated in consolidation" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.1.2" + Chrw(9) + "Related party balances reported or disclosed" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.1.3" + Chrw(9) + "Intercompany investments" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.2" + Chrw(9) + "Intercompany and related party liabilities" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.2.1" + Chrw(9) + "Intercompany balances eliminated in consolidation" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.2.2" + Chrw(9) + "Related party balances reported or disclosed" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.3" + Chrw(9) + "Intercompany and related party income and expense" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.3.1" + Chrw(9) + "Intercompany and related party income" + Chrw(9) + "(Cr)" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.3.2" + Chrw(9) + "Intercompany and related party expenses" + Chrw(9) + "Dr" + vblf + "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "7.3.3" + Chrw(9) + "Income loss from equity method investments" + Chrw(9) + "Dr or (Cr)" + vblf + "".ToCharArray())

		accountPlanString = LinkedListCharactersToArray(ll)

		Call FreeLinkedListCharacter(ll)

		Return ParseAccountPlanString(accountPlanString, validRef)
	End Function


	Public Function ParseAccountPlanString(ByRef accountPlanString As Char (), ByRef valid As BooleanReference) As AccountPlan
		Dim ap As AccountPlan
		Dim i As Double
		Dim line As Char ()
		Dim lines, parts As StringReference ()
		Dim ad As AccountDefinition

		ap = New AccountPlan()

		accountPlanString = strTrim(accountPlanString)
		lines = strSplitByCharacter(accountPlanString, vblf)

		ap.accountDefinitions = New AccountDefinition (lines.Length - 1){}

		i = 0.0
		While i < lines.Length
			line = lines(i).stringx
			'System.out.println(line);
			parts = strSplitByCharacter(line, vbTab)

			ad = New AccountDefinition()

			ad.accountName = parts(1).stringx
			ad.number = parts(0).stringx
			If arraysStringsEqual(parts(2).stringx, "(Cr)".ToCharArray())
				ad.debitBalance = false
			Else
				ad.debitBalance = true
			End If
			ad.role = "".ToCharArray()
			If arraysStringsEqual(ad.number, "1".ToCharArray())
				ad.role = "Assets".ToCharArray()
			ElseIf arraysStringsEqual(ad.number, "2".ToCharArray())
				ad.role = "Equities".ToCharArray()
			ElseIf arraysStringsEqual(ad.number, "3".ToCharArray())
				ad.role = "Liabilities".ToCharArray()
			ElseIf arraysStringsEqual(ad.number, "4".ToCharArray())
				ad.role = "Revenue".ToCharArray()
			ElseIf arraysStringsEqual(ad.number, "5".ToCharArray())
				ad.role = "Expenses".ToCharArray()
			End If

			ap.accountDefinitions(i) = ad
			i = i + 1.0
		End While

		Return ap
	End Function


	Public Function ComputeAccountBalances(ByRef sledger As Ledger, depth As Double, ByRef datex As Datex, ByRef balanceSheet As DataReference) As Boolean
		Dim accountPlan As AccountPlan
		Dim assetsBalance, liabilitiesBalance, equitiesBalance, revenueBalanace, expensesBalance, resultBalance, sum, balance As FixedPoint15d
		Dim balanceStr As Char ()
		Dim assetsDef, liabilitiesDef, equitiesDef, revenueDef, expensesDef, accountDef As AccountDefinition
		Dim success, isBalanced As Boolean
		Dim i As Double
		Dim parts As StringReference ()
		Dim foundRef As BooleanReference
		Dim accounts As Arrayx
		Dim account As Structurex
		Dim dateStr As Char ()

		balanceSheet.data = CreateNewStructData()
		success = true

		foundRef = CreateBooleanReference(false)

		accountPlan = sledger.accountPlan

		assetsDef = FindAccountWithRole(accountPlan, "Assets".ToCharArray(), foundRef)
		success = success And foundRef.booleanValue
		liabilitiesDef = FindAccountWithRole(accountPlan, "Liabilities".ToCharArray(), foundRef)
		success = success And foundRef.booleanValue
		equitiesDef = FindAccountWithRole(accountPlan, "Equities".ToCharArray(), foundRef)
		success = success And foundRef.booleanValue
		revenueDef = FindAccountWithRole(accountPlan, "Revenue".ToCharArray(), foundRef)
		success = success And foundRef.booleanValue
		expensesDef = FindAccountWithRole(accountPlan, "Expenses".ToCharArray(), foundRef)
		success = success And foundRef.booleanValue

		If success
			assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.number, datex, assetsDef.debitBalance)
			liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.number, datex, liabilitiesDef.debitBalance)

			' TODO: This must be for a period
			revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.number, datex, revenueDef.debitBalance)
			expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.number, datex, expensesDef.debitBalance)
			resultBalance = CreateFixedPointForStaticLedger(sledger)
			Subtract15d(resultBalance, revenueBalanace, expensesBalance)
			balanceStr = FormatToStringWithSymbols15d(resultBalance, 2.0, "".ToCharArray(), ".".ToCharArray())
			Call AddStringToStruct(balanceSheet.data.structurex, "result".ToCharArray(), balanceStr)

			equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.number, datex, equitiesDef.debitBalance)
			Add15d(equitiesBalance, equitiesBalance, resultBalance)

			' Compute accounts
			accounts = CreateArray()

			i = 0.0
			While i < accountPlan.accountDefinitions.Length
				accountDef = accountPlan.accountDefinitions(i)

				parts = strSplitByCharacter(accountDef.number, "."C)

				If parts.Length <= depth + 1.0
					account = CreateStructure()

					balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.number, datex, accountDef.debitBalance)

					balanceStr = FormatToStringWithSymbols15d(balance, 2.0, "".ToCharArray(), ".".ToCharArray())

					Call AddStringToStruct(account, "number".ToCharArray(), accountDef.number)
					Call AddStringToStruct(account, "name".ToCharArray(), accountDef.accountName)
					Call AddStringToStruct(account, "balance".ToCharArray(), balanceStr)
					Call AddNumberToStruct(account, "depth".ToCharArray(), parts.Length - 1.0)

					Call AddStructToArray(accounts, account)
				End If
				i = i + 1.0
			End While

			Call AddArrayToStruct(balanceSheet.data.structurex, "accounts".ToCharArray(), accounts)

			' End conclusion
			balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2.0, "".ToCharArray(), ".".ToCharArray())
			Call AddStringToStruct(balanceSheet.data.structurex, "assets".ToCharArray(), balanceStr)

			sum = CreateFixedPointForStaticLedger(sledger)
			Add15d(sum, liabilitiesBalance, equitiesBalance)
			balanceStr = FormatToStringWithSymbols15d(sum, 2.0, "".ToCharArray(), ".".ToCharArray())
			Call AddStringToStruct(balanceSheet.data.structurex, "liabilitiesAndEquity".ToCharArray(), balanceStr)

			isBalanced = Equals15d(sum, assetsBalance)
			Call AddBooleanToStruct(balanceSheet.data.structurex, "balanced".ToCharArray(), isBalanced)

			dateStr = DateToStringISO8601(datex)
			Call AddStringToStruct(balanceSheet.data.structurex, "date".ToCharArray(), dateStr)
		End If

		Return success
	End Function


	Public Function AccountBalancesToString(ByRef balanceSheet As Structurex) As Char ()
		Dim ll As LinkedListCharacters
		Dim balanceStr As Char ()
		Dim isBalanced As Boolean
		Dim i, j, depth As Double
		Dim accounts As Arrayx
		Dim account As Structurex
		Dim accountNumber, accountName As Char ()

		ll = CreateLinkedListCharacter()

		' Print accounts
		accounts = GetArrayFromStruct(balanceSheet, "accounts".ToCharArray())

		i = 0.0
		While i < ArrayLength(accounts)
			account = ArrayIndexStruct(accounts, i)

			accountNumber = GetStringFromStruct(account, "number".ToCharArray())
			accountName = GetStringFromStruct(account, "name".ToCharArray())
			balanceStr = GetStringFromStruct(account, "balance".ToCharArray())
			depth = GetNumberFromStruct(account, "depth".ToCharArray())

			j = 0.0
			While j < depth
				Call LinkedListCharactersAddString(ll, "  ".ToCharArray())
				j = j + 1.0
			End While

			Call LinkedListCharactersAddString(ll, accountNumber)
			Call LinkedListCharactersAddString(ll, ". ".ToCharArray())
			Call LinkedListCharactersAddString(ll, accountName)
			Call LinkedListCharactersAddString(ll, ": ".ToCharArray())
			Call LinkedListCharactersAddString(ll, balanceStr)
			Call LinkedListCharactersAddString(ll, "" + vblf + "".ToCharArray())
			i = i + 1.0
		End While

		' End conclusion
		Call LinkedListCharactersAddString(ll, "" + vblf + "".ToCharArray())

		Call LinkedListCharactersAddString(ll, "Result: ".ToCharArray())
		balanceStr = GetStringFromStruct(balanceSheet, "result".ToCharArray())
		Call LinkedListCharactersAddString(ll, balanceStr)
		Call LinkedListCharactersAddString(ll, "" + vblf + "".ToCharArray())

		Call LinkedListCharactersAddString(ll, "Assets: ".ToCharArray())
		balanceStr = GetStringFromStruct(balanceSheet, "assets".ToCharArray())
		Call LinkedListCharactersAddString(ll, balanceStr)
		Call LinkedListCharactersAddString(ll, "" + vblf + "".ToCharArray())

		Call LinkedListCharactersAddString(ll, "Liabilities + Equities: ".ToCharArray())
		balanceStr = GetStringFromStruct(balanceSheet, "liabilitiesAndEquity".ToCharArray())
		Call LinkedListCharactersAddString(ll, balanceStr)
		Call LinkedListCharactersAddString(ll, "" + vblf + "".ToCharArray())

		isBalanced = GetBooleanFromStruct(balanceSheet, "balanced".ToCharArray())
		Call LinkedListCharactersAddString(ll, "Balance: ".ToCharArray())
		If isBalanced
			Call LinkedListCharactersAddString(ll, "true".ToCharArray())
		Else
			Call LinkedListCharactersAddString(ll, "false".ToCharArray())
		End If
		Call LinkedListCharactersAddString(ll, "" + vblf + "".ToCharArray())

		Return LinkedListCharactersToArray(ll)
	End Function


	Public Function FindAccountWithRole(ByRef accountPlan As AccountPlan, ByRef role As Char (), ByRef foundRef As BooleanReference) As AccountDefinition
		Dim i As Double
		Dim ad As AccountDefinition
		Dim done As Boolean

		ad = New AccountDefinition()

		done = false
		i = 0.0
		While i < accountPlan.accountDefinitions.Length And Not done
			ad = accountPlan.accountDefinitions(i)
			If arraysStringsEqual(ad.role, role)
				done = true
			End If
			i = i + 1.0
		End While

		foundRef.booleanValue = done

		Return ad
	End Function


	Public Function CreateAccountDefinition(ByRef name As Char (), ByRef number As Char (), ByRef role As Char (), debitBalance As Boolean) As AccountDefinition
		Dim def As AccountDefinition

		def = New AccountDefinition()
		def.accountName = name
		def.number = number
		def.role = role
		def.debitBalance = debitBalance

		Return def
	End Function


	Public Sub ComputeBalanceDiffs(ByRef sledger As Ledger, ByRef balances As Arrayx)
		Dim i, j As Double
		Dim balance, first, balance1, balance2 As Structurex
		Dim account1, account2 As Structurex
		Dim b1, b2, diffStr As Char ()
		Dim f1, f2, diff As FixedPoint15d
		Dim accountsO, accounts1, accounts2 As Arrayx

		first = ArrayIndexStruct(balances, 0.0)
		accountsO = GetArrayFromStruct(first, "accounts".ToCharArray())

		j = 0.0
		While j < ArrayLength(accountsO)
			i = 1.0
			While i < ArrayLength(balances)
				balance1 = ArrayIndexStruct(balances, i - 1.0)
				balance2 = ArrayIndexStruct(balances, i)
				accounts1 = GetArrayFromStruct(balance1, "accounts".ToCharArray())
				accounts2 = GetArrayFromStruct(balance2, "accounts".ToCharArray())

				account1 = ArrayIndexStruct(accounts1, j)
				account2 = ArrayIndexStruct(accounts2, j)

				b1 = GetStringFromStruct(account1, "balance".ToCharArray())
				b2 = GetStringFromStruct(account2, "balance".ToCharArray())

				f1 = CreateFixedPointForStaticLedger(sledger)
				f2 = CreateFixedPointForStaticLedger(sledger)
				diff = CreateFixedPointForStaticLedger(sledger)

				Assign15d(f1, CreateNumberFromDecimalString(b1))
				Assign15d(f2, CreateNumberFromDecimalString(b2))

				Subtract15d(diff, f2, f1)

				diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".ToCharArray(), ".".ToCharArray())

				'System.out.println(diffStr);
				If i = 1.0
					Call AddStringToStruct(account1, "change".ToCharArray(), "0.00".ToCharArray())
				End If
				Call AddStringToStruct(account2, "change".ToCharArray(), diffStr)
				i = i + 1.0
			End While
			j = j + 1.0
		End While

		i = 1.0
		While i < ArrayLength(balances)
			balance1 = ArrayIndexStruct(balances, i - 1.0)
			balance2 = ArrayIndexStruct(balances, i)
			b1 = GetStringFromStruct(balance1, "result".ToCharArray())
			b2 = GetStringFromStruct(balance2, "result".ToCharArray())

			f1 = CreateFixedPointForStaticLedger(sledger)
			f2 = CreateFixedPointForStaticLedger(sledger)
			diff = CreateFixedPointForStaticLedger(sledger)

			Assign15d(f1, CreateNumberFromDecimalString(b1))
			Assign15d(f2, CreateNumberFromDecimalString(b2))

			Subtract15d(diff, f2, f1)

			diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "".ToCharArray(), ".".ToCharArray())

			'System.out.println(diffStr);
			If i = 1.0
				Call AddStringToStruct(balance1, "rchange".ToCharArray(), "0.00".ToCharArray())
			End If
			Call AddStringToStruct(balance2, "rchange".ToCharArray(), diffStr)
			i = i + 1.0
		End While
	End Sub


	Public Function BalancesArrayToHTML(ByRef balances As Arrayx, includeBalance As Boolean, includeDiff As Boolean) As Char ()
		Dim ll As LinkedListCharacters
		Dim i, j As Double
		Dim balance, first As Structurex
		Dim dateStr, name, number, balanceStr, changeStr As Char ()
		Dim account As Structurex
		Dim accounts As Arrayx

		ll = CreateLinkedListCharacter()

		Call LinkedListCharactersAddString(ll, "<html>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "<body>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "<table>".ToCharArray())

		' Headers
		Call LinkedListCharactersAddString(ll, "<tr>".ToCharArray())

		Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())

		i = 0.0
		While i < ArrayLength(balances)
			balance = ArrayIndexStruct(balances, i)
			dateStr = GetStringFromStruct(balance, "date".ToCharArray())
			dateStr = strSubstring(dateStr, 0.0, 7.0)

			Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
			Call LinkedListCharactersAddString(ll, dateStr)
			Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())
			i = i + 1.0
		End While

		Call LinkedListCharactersAddString(ll, "</tr>".ToCharArray())

		' Each account
		first = ArrayIndexStruct(balances, 0.0)
		accounts = GetArrayFromStruct(first, "accounts".ToCharArray())
		j = 0.0
		While j < ArrayLength(accounts)
			Call LinkedListCharactersAddString(ll, "<tr>".ToCharArray())

			account = ArrayIndexStruct(accounts, j)
			name = GetStringFromStruct(account, "name".ToCharArray())
			number = GetStringFromStruct(account, "number".ToCharArray())

			Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
			Call LinkedListCharactersAddString(ll, number)
			Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())

			Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
			Call LinkedListCharactersAddString(ll, name)
			Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())

			i = 0.0
			While i < ArrayLength(balances)
				balance = ArrayIndexStruct(balances, i)
				accounts = GetArrayFromStruct(balance, "accounts".ToCharArray())
				account = ArrayIndexStruct(accounts, j)
				balanceStr = GetStringFromStruct(account, "balance".ToCharArray())
				changeStr = GetStringFromStruct(account, "change".ToCharArray())

				Call LinkedListCharactersAddString(ll, "<td style=""text-align: right;"">".ToCharArray())

				If includeBalance And includeDiff
					Call LinkedListCharactersAddString(ll, balanceStr)
					Call LinkedListCharactersAddString(ll, "<br><small style=""color: grey"">".ToCharArray())
					Call LinkedListCharactersAddString(ll, changeStr)
					Call LinkedListCharactersAddString(ll, "</small>".ToCharArray())
				ElseIf includeBalance
					Call LinkedListCharactersAddString(ll, balanceStr)
				ElseIf includeDiff
					Call LinkedListCharactersAddString(ll, changeStr)
				End If

				Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())
				i = i + 1.0
			End While

			Call LinkedListCharactersAddString(ll, "</tr>".ToCharArray())
			j = j + 1.0
		End While

		' Result
		Call LinkedListCharactersAddString(ll, "<tr>".ToCharArray())

		Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "".ToCharArray())
		Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())

		Call LinkedListCharactersAddString(ll, "<td>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "Result".ToCharArray())
		Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())

		i = 0.0
		While i < ArrayLength(balances)
			balance = ArrayIndexStruct(balances, i)
			balanceStr = GetStringFromStruct(balance, "result".ToCharArray())
			changeStr = GetStringFromStruct(balance, "rchange".ToCharArray())

			Call LinkedListCharactersAddString(ll, "<td style=""text-align: right;"">".ToCharArray())

			If includeBalance And includeDiff
				Call LinkedListCharactersAddString(ll, balanceStr)
				Call LinkedListCharactersAddString(ll, "<br><small style=""color: grey"">".ToCharArray())
				Call LinkedListCharactersAddString(ll, changeStr)
				Call LinkedListCharactersAddString(ll, "</small>".ToCharArray())
			ElseIf includeBalance
				Call LinkedListCharactersAddString(ll, balanceStr)
			ElseIf includeDiff
				Call LinkedListCharactersAddString(ll, changeStr)
			End If

			Call LinkedListCharactersAddString(ll, "</td>".ToCharArray())
			i = i + 1.0
		End While

		Call LinkedListCharactersAddString(ll, "</tr>".ToCharArray())

		' Footer
		Call LinkedListCharactersAddString(ll, "</table>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "</body>".ToCharArray())
		Call LinkedListCharactersAddString(ll, "</html>".ToCharArray())

		Return LinkedListCharactersToArray(ll)
	End Function


	Public Function CreateLineFromScript(ByRef ledger As Structurex, ByRef script As Char (), ByRef datex As Datex) As Line
		Dim parts As StringReference ()
		Dim c, d As FixedPoint15d
		Dim line As Line
		Dim i, n As Double

		c = CreateFixedPointForDynamicLedger(ledger)
		d = CreateFixedPointForDynamicLedger(ledger)

		parts = strSplitByCharacter(script, ","C)

		i = 0.0
		While i < parts.Length
			parts(i).stringx = strTrim(parts(i).stringx)
			i = i + 1.0
		End While

		line = New Line()

		n = CreateNumberFromDecimalString(parts(2).stringx)

		line.datex = datex
		If arraysStringsEqual(parts(0).stringx, "Debit".ToCharArray())
			Assign15d(d, n)
			Assign15d(c, 0.0)
		ElseIf arraysStringsEqual(parts(0).stringx, "Credit".ToCharArray())
			Assign15d(d, 0.0)
			Assign15d(c, n)
		End If

		line = CreateLine(parts(1).stringx, d, c, parts(3).stringx, datex)

		Return line
	End Function


	Public Function test() As Double
		Dim failures As NumberReference

		failures = CreateNumberReference(0.0)

		Call TestBasicAccounting(failures)
		Call TestAccruals(failures)
		Call TestIFRSAccountPlan(failures)

		Return failures.numberValue
	End Function


	Public Sub TestIFRSAccountPlan(ByRef failures As NumberReference)
		GetIFRSAccountPlan()
	End Sub


	Public Sub TestBasicAccounting(ByRef failures As NumberReference)
		Dim ledger As Structurex
		Dim c, d As FixedPoint15d
		Dim transaction As Line ()
		Dim valid As Boolean
		Dim datex, from, tox As Datex
		Dim account As Account
		Dim accountName, accountStr, desc As Char ()
		Dim sledger As Ledger

		ledger = CreateLedger(2.0)

		'c = CreateFixedPointForDynamicLedger(ledger);
		'd = CreateFixedPointForDynamicLedger(ledger);
		' Transaction 1:
		transaction = New Line (2 - 1){}
		'date = CreateDate(2026d, 2d, 18d);
		datex = DateFromStringISO8601("2026-02-18".ToCharArray())

		' Debit, 100, 1000, l1, 2026-02-18
		'
		'        accountName = "1000".toCharArray();
		'        Assign15d(d, 100d);
		'        Assign15d(c, 0d);
		'        desc = "l1".toCharArray();
		'        transaction[0] = CreateLine(accountName, d, c, desc, date);
		'        
		transaction(0) = CreateLineFromScript(ledger, "Debit, 1000, 100, l1".ToCharArray(), datex)

		' Credit, 100, 2000, l2, 2026-02-18
		'
		'        accountName = "2000".toCharArray();
		'        Assign15d(d, 0d);
		'        Assign15d(c, 100d);
		'        desc = "l2".toCharArray();
		'        transaction[1] = CreateLine(accountName, d, c, desc, date);
		'        
		transaction(1) = CreateLineFromScript(ledger, "Credit, 2000, 100, l2".ToCharArray(), datex)

		valid = ValidateAndAddTransactionToLedger(ledger, transaction)

		Call AssertTrue(valid, failures)

		' Compute
		sledger = LedgerDynamicToStatic(ledger)

		accountName = "1000".ToCharArray()
		from = DateFromStringISO8601("2026-02-17".ToCharArray())
		tox = DateFromStringISO8601("2026-02-19".ToCharArray())
		account = ComputeAccountBalance(sledger, accountName, from, tox)

		accountStr = AccountToString(account)

		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)".ToCharArray(), failures)
	End Sub


	Public Sub TestAccruals(ByRef failures As NumberReference)
		Dim ledger As Structurex
		Dim c, d As FixedPoint15d
		Dim transaction As Line ()
		Dim valid, success As Boolean
		Dim datex, from, tox As Datex
		Dim account As Account
		Dim accountName, desc, accountStr, accountSummaryStr As Char ()
		Dim sledger As Ledger
		Dim amounts As Double ()
		Dim i As Double
		Dim assetsDef, liabilitiesDef, equitiesDef, incomeDef, expensesDef, accountDef As AccountDefinition
		Dim a148, a150, a192, a290, a300, a600 As AccountDefinition
		Dim accountPlan As AccountPlan
		Dim balanceSheetRef As DataReference
		Dim html As Char ()
		Dim message As StringReference
		Dim balances As Arrayx

		ledger = CreateLedger(2.0)

		c = CreateFixedPointForDynamicLedger(ledger)
		d = CreateFixedPointForDynamicLedger(ledger)

		' Case:
		'           * A domain is renewed for the period 2025-12-06 - 2026-12-05.
		'           * it is invoiced 2025-09-17 with a due date 2025-10-01, amount 125.00
		'           * It is paid 2025-10-01.
		'           * It is renewed 2025-11-08 by paying the renewal fee 112.50
		'           * The domain must be correctly accounted for using accruals for each month
		'         

		' 1.8.1. Loans and receivables
		' 3.4.2. Deferred income and refund liabilities
		' 1.11.1. Cash
		' 1.8.1. Loans and receivables
		' 3.4.2. Deferred income and refund liabilities
		' 4.1.2 Services
		' 1.11.1. Cash
		' 1.7.1. Prepayments
		' 5.1.3. Services expense
		' 1.7.1. Prepayments
		' Transaction: Invoice sent
		transaction = New Line (2 - 1){}
		datex = DateFromStringISO8601("2025-09-17".ToCharArray())
		transaction(0) = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x".ToCharArray(), datex)
		transaction(1) = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x".ToCharArray(), datex)
		valid = ValidateAndAddTransactionToLedger(ledger, transaction)
		Call AssertTrue(valid, failures)

		' Transaction: Invoice paid
		transaction = New Line (2 - 1){}
		datex = DateFromStringISO8601("2025-10-01".ToCharArray())
		transaction(0) = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x".ToCharArray(), datex)
		transaction(1) = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x".ToCharArray(), datex)
		valid = ValidateAndAddTransactionToLedger(ledger, transaction)
		Call AssertTrue(valid, failures)

		' Transaction: Renewal paid
		transaction = New Line (2 - 1){}
		datex = DateFromStringISO8601("2025-11-08".ToCharArray())
		transaction(0) = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x".ToCharArray(), datex)
		transaction(1) = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x".ToCharArray(), datex)
		valid = ValidateAndAddTransactionToLedger(ledger, transaction)
		Call AssertTrue(valid, failures)

		' Accruals income
		from = DateFromStringISO8601("2025-12-06".ToCharArray())
		tox = DateFromStringISO8601("2026-12-05".ToCharArray())
		Call AddMonthlyAccruals(ledger, from, tox, 125.0, "3.4.2".ToCharArray(), "4.1.2".ToCharArray())

		' Accruals cost
		from = DateFromStringISO8601("2025-12-06".ToCharArray())
		tox = DateFromStringISO8601("2026-12-05".ToCharArray())
		Call AddMonthlyAccruals(ledger, from, tox, 112.50, "5.1.3".ToCharArray(), "1.7.1".ToCharArray())

		' Compute
		sledger = LedgerDynamicToStatic(ledger)

		from = DateFromStringISO8601("2027-01-01".ToCharArray())
		tox = DateFromStringISO8601("2027-01-01".ToCharArray())

		account = ComputeAccountBalance(sledger, "5.1.3".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "4.1.2".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "1.8.1".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "3.4.2".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "1.11.1".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "1.7.1".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		'System.out.println("");
		' In between
		from = DateFromStringISO8601("2026-06-15".ToCharArray())
		tox = DateFromStringISO8601("2026-06-16".ToCharArray())

		account = ComputeAccountBalance(sledger, "5.1.3".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "4.1.2".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "1.8.1".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "3.4.2".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "1.11.1".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		account = ComputeAccountBalance(sledger, "1.7.1".ToCharArray(), from, tox)
		accountStr = AccountToString(account)
		'System.out.println(accountStr);
		Call AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)".ToCharArray(), failures)

		' Balance Sheet: Snapshots a companys assets, liabilities, and equity at a specific point in time.
		' Income Statement (P&L): Shows revenue, expenses, and profit/loss over a period.
		' Cash Flow Statement: Tracks cash inflow and outflow from operating, investing, and financing activities.
		' Statement of Shareholders' Equity: Details changes in owner interest over time.
		'accountPlan = new AccountPlan();
		'        accountPlan.accountDefinitions = new AccountDefinition[11];
		'        assetsDef = CreateAccountDefinition("Assets".toCharArray(), "1".toCharArray(), "Assets".toCharArray(), true);
		'        a148 = CreateAccountDefinition("Forskuddsbetalt leverandor".toCharArray(), "1.4".toCharArray(), "".toCharArray(), true);
		'        a150 = CreateAccountDefinition("Kundefordringer".toCharArray(), "1.5".toCharArray(), "".toCharArray(), true);
		'        a192 = CreateAccountDefinition("Bankinnskudd".toCharArray(), "1.9".toCharArray(), "".toCharArray(), true);
		'        liabilitiesDef = CreateAccountDefinition("Liabilities".toCharArray(), "2".toCharArray(), "Liabilities".toCharArray(), false);
		'        a290 = CreateAccountDefinition("Forskuddsbetalt inntekt/kortsiktig gjeld".toCharArray(), "2.9".toCharArray(), "".toCharArray(), true);
		'        equitiesDef = CreateAccountDefinition("Equities".toCharArray(), "4".toCharArray(), "Equities".toCharArray(), false);
		'        incomeDef = CreateAccountDefinition("Income".toCharArray(), "3".toCharArray(), "Revenue".toCharArray(), false);
		'        a300 = CreateAccountDefinition("Salgsinntekt".toCharArray(), "2.9".toCharArray(), "".toCharArray(), true);
		'        expensesDef = CreateAccountDefinition("Expenses".toCharArray(), "6".toCharArray(), "Expenses".toCharArray(), true);
		'        a600 = CreateAccountDefinition("Domenekostnader".toCharArray(), "6.0".toCharArray(), "".toCharArray(), true);
		'
		'        accountPlan.accountDefinitions[0] = assetsDef;
		'        accountPlan.accountDefinitions[1] = a148;
		'        accountPlan.accountDefinitions[2] = a150;
		'        accountPlan.accountDefinitions[3] = a192;
		'        accountPlan.accountDefinitions[4] = liabilitiesDef;
		'        accountPlan.accountDefinitions[5] = a290;
		'        accountPlan.accountDefinitions[6] = equitiesDef;
		'        accountPlan.accountDefinitions[7] = incomeDef;
		'        accountPlan.accountDefinitions[8] = a300;
		'        accountPlan.accountDefinitions[9] = expensesDef;
		'        accountPlan.accountDefinitions[10] = a600;
		'        sledger.accountPlan = accountPlan

		sledger.accountPlan = GetIFRSAccountPlan()

		tox = DateFromStringISO8601("2026-02-16".ToCharArray())
		balanceSheetRef = New DataReference()
		success = ComputeAccountBalances(sledger, 2.0, tox, balanceSheetRef)
		accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structurex)
		Call AssertTrue(success, failures)
		'System.out.println(accountSummaryStr);
		' Compute monthly table
		tox = DateFromStringISO8601("2025-08-01".ToCharArray())
		message = New StringReference()
		AddDaysToDate(tox, -1.0, message)
		balances = CreateArray()
		i = 0.0
		While i < 12.0 + 6.0
			AddDaysToDate(tox, 1.0, message)
			Call AddMonthsToDate(tox, 1.0)
			AddDaysToDate(tox, -1.0, message)

			balanceSheetRef = New DataReference()
			success = ComputeAccountBalances(sledger, 1.0, tox, balanceSheetRef)

			If success
				Call AddStructToArray(balances, balanceSheetRef.data.structurex)
			End If
			i = i + 1.0
		End While
		Call ComputeBalanceDiffs(sledger, balances)

		html = BalancesArrayToHTML(balances, true, false)

		'StringToFile("x.html", html);
		html = BalancesArrayToHTML(balances, false, true)

		'StringToFile("x-diff.html", html);
		html = BalancesArrayToHTML(balances, true, true)
	End Sub


	Public Function CreateBooleanReference(value As Boolean) As BooleanReference
		Dim ref As BooleanReference

		ref = New BooleanReference()
		ref.booleanValue = value

		Return ref
	End Function


	Public Function CreateBooleanArrayReference(ByRef value As Boolean ()) As BooleanArrayReference
		Dim ref As BooleanArrayReference

		ref = New BooleanArrayReference()
		ref.booleanArray = value

		Return ref
	End Function


	Public Function CreateBooleanArrayReferenceLengthValue(length As Double, value As Boolean) As BooleanArrayReference
		Dim ref As BooleanArrayReference
		Dim i As Double

		ref = New BooleanArrayReference()
		ref.booleanArray = New Boolean (length - 1){}

		i = 0.0
		While i < length
			ref.booleanArray(i) = value
			i = i + 1.0
		End While

		Return ref
	End Function


	Public Sub FreeBooleanArrayReference(ByRef booleanArrayReference As BooleanArrayReference)
		Erase booleanArrayReference.booleanArray 
		booleanArrayReference = Nothing
	End Sub


	Public Function CreateCharacterReference(value As Char) As CharacterReference
		Dim ref As CharacterReference

		ref = New CharacterReference()
		ref.characterValue = value

		Return ref
	End Function


	Public Function CreateNumberReference(value As Double) As NumberReference
		Dim ref As NumberReference

		ref = New NumberReference()
		ref.numberValue = value

		Return ref
	End Function


	Public Function CreateNumberArrayReference(ByRef value As Double ()) As NumberArrayReference
		Dim ref As NumberArrayReference

		ref = New NumberArrayReference()
		ref.numberArray = value

		Return ref
	End Function


	Public Function CreateNumberArrayReferenceLengthValue(length As Double, value As Double) As NumberArrayReference
		Dim ref As NumberArrayReference
		Dim i As Double

		ref = New NumberArrayReference()
		ref.numberArray = New Double (length - 1){}

		i = 0.0
		While i < length
			ref.numberArray(i) = value
			i = i + 1.0
		End While

		Return ref
	End Function


	Public Sub FreeNumberArrayReference(ByRef numberArrayReference As NumberArrayReference)
		Erase numberArrayReference.numberArray 
		numberArrayReference = Nothing
	End Sub


	Public Function CreateStringReference(ByRef value As Char ()) As StringReference
		Dim ref As StringReference

		ref = New StringReference()
		ref.stringx = value

		Return ref
	End Function


	Public Function CreateStringReferenceLengthValue(length As Double, value As Char) As StringReference
		Dim ref As StringReference
		Dim i As Double

		ref = New StringReference()
		ref.stringx = New Char (length - 1){}

		i = 0.0
		While i < length
			ref.stringx(i) = value
			i = i + 1.0
		End While

		Return ref
	End Function


	Public Sub FreeStringReference(ByRef stringReference As StringReference)
		Erase stringReference.stringx 
		stringReference = Nothing
	End Sub


	Public Function CreateStringArrayReference(ByRef strings As StringReference ()) As StringArrayReference
		Dim ref As StringArrayReference

		ref = New StringArrayReference()
		ref.stringArray = strings

		Return ref
	End Function


	Public Function CreateStringArrayReferenceLengthValue(length As Double, ByRef value As Char ()) As StringArrayReference
		Dim ref As StringArrayReference
		Dim i As Double

		ref = New StringArrayReference()
		ref.stringArray = New StringReference (length - 1){}

		i = 0.0
		While i < length
			ref.stringArray(i) = CreateStringReference(value)
			i = i + 1.0
		End While

		Return ref
	End Function


	Public Sub FreeStringArrayReference(ByRef stringArrayReference As StringArrayReference)
		Dim i As Double

		i = 0.0
		While i < stringArrayReference.stringArray.Length
			stringArrayReference.stringArray(i) = Nothing
			i = i + 1.0
		End While
		Erase stringArrayReference.stringArray 
		stringArrayReference = Nothing
	End Sub


	Public Function CreateDate(year As Double, month As Double, day As Double) As Datex
		Dim datex As Datex

		datex = New Datex()

		datex.year = year
		datex.month = month
		datex.day = day

		Return datex
	End Function


	Public Function IsLeapYearWithCheck(year As Double, ByRef isLeapYearReference As BooleanReference, ByRef message As StringReference) As Boolean
		Dim itIsLeapYear As Boolean
		Dim success As Boolean

		If year >= 1752.0
			success = true
			itIsLeapYear = IsLeapYear(year)
		Else
			success = false
			itIsLeapYear = false
			message.stringx = "Gregorian calendar was not in general use.".ToCharArray()
		End If

		isLeapYearReference.booleanValue = itIsLeapYear
		Return success
	End Function


	Public Function IsLeapYear(year As Double) As Boolean
		Dim itIsLeapYear As Boolean

		If DivisibleBy(year, 4.0)
			If DivisibleBy(year, 100.0)
				If DivisibleBy(year, 400.0)
					itIsLeapYear = true
				Else
					itIsLeapYear = false
				End If
			Else
				itIsLeapYear = true
			End If
		Else
			itIsLeapYear = false
		End If

		Return itIsLeapYear
	End Function


	Public Function DayToDateWithCheck(dayNr As Double, ByRef dateReference As DateReference, ByRef message As StringReference) As Boolean
		Dim datex As Datex
		Dim remainder As NumberReference
		Dim success As Boolean

		If dayNr >= -79623.0
			datex = New Datex()
			remainder = New NumberReference()
			remainder.numberValue = dayNr + 79623.0
			' Days since 1752-01-01. Day 0: Thursday, 1970-01-01
			' Find year.
			datex.year = GetYearFromDayNr(remainder.numberValue, remainder)

			' Find month.
			datex.month = GetMonthFromDayNr(remainder.numberValue, datex.year, remainder)

			' Find day.
			datex.day = 1.0 + remainder.numberValue

			dateReference.datex = datex
			success = true
		Else
			success = false
			message.stringx = "Gregorian calendar was not in general use before 1752.".ToCharArray()
		End If

		Return success
	End Function


	Public Function DayToDate(dayNr As Double) As Datex
		Dim datex As Datex
		Dim success As Boolean
		Dim dateRef As DateReference
		Dim message As StringReference

		dateRef = New DateReference()
		message = New StringReference()

		success = DayToDateWithCheck(dayNr, dateRef, message)
		If success
			datex = dateRef.datex
			dateRef = Nothing
			Call FreeStringReference(message)
		Else
			datex = CreateDate(1970.0, 1.0, 1.0)
		End If

		Return datex
	End Function


	Public Function GetMonthFromDayNrWithCheck(dayNr As Double, year As Double, ByRef monthReference As NumberReference, ByRef remainderReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim month As Double
		Dim success As Boolean

		If dayNr >= -79623.0
			month = GetMonthFromDayNr(dayNr, year, remainderReference)
			monthReference.numberValue = month
			success = true
		Else
			success = false
			message.stringx = "Gregorian calendar not in general use before 1752.".ToCharArray()
		End If

		Return success
	End Function


	Public Function GetMonthFromDayNr(dayNr As Double, year As Double, ByRef remainderReference As NumberReference) As Double
		Dim daysInMonth As Double ()
		Dim done As Boolean
		Dim month As Double

		daysInMonth = GetDaysInMonth(year)
		done = false
		month = 1.0

		
		While Not done
			If dayNr >= daysInMonth(month)
				dayNr = dayNr - daysInMonth(month)
				month = month + 1.0
			Else
				done = true
			End If
		End While
		remainderReference.numberValue = dayNr

		Return month
	End Function


	Public Function GetYearFromDayNrWithCheck(dayNr As Double, ByRef yearReference As NumberReference, ByRef remainder As NumberReference, ByRef message As StringReference) As Boolean
		Dim success As Boolean
		Dim year As Double

		If dayNr >= 0.0
			success = true
			year = GetYearFromDayNr(dayNr, remainder)
			yearReference.numberValue = year
		Else
			success = false
			message.stringx = "Day number must be 0 or higher. 0 is 1752-01-01.".ToCharArray()
		End If

		Return success
	End Function


	Public Function GetYearFromDayNr(dayNr As Double, ByRef remainder As NumberReference) As Double
		Dim nrOfDays As Double
		Dim done As Boolean
		Dim year As Double

		done = false
		year = 1752.0

		
		While Not done
			If IsLeapYear(year)
				nrOfDays = 366.0
			Else
				nrOfDays = 365.0
			End If

			If dayNr >= nrOfDays
				' First day is 0.
				dayNr = dayNr - nrOfDays
				year = year + 1.0
			Else
				done = true
			End If
		End While
		remainder.numberValue = dayNr

		Return year
	End Function


	Public Function DaysBetweenDates(ByRef A As Datex, ByRef B As Datex) As Double
		Dim daysA, daysB, daysBetween As Double

		daysA = DateToDays(A)
		daysB = DateToDays(B)

		daysBetween = daysB - daysA

		Return daysBetween
	End Function


	Public Function GetDaysInMonthWithCheck(year As Double, ByRef daysInMonthReference As NumberArrayReference, ByRef message As StringReference) As Boolean
		Dim daysInMonth As Double ()
		Dim success As Boolean
		Dim datex As Datex

		datex = CreateDate(year, 1.0, 1.0)

		success = IsValidDate(datex, message)
		If success
			daysInMonth = GetDaysInMonth(year)

			daysInMonthReference.numberArray = daysInMonth
		End If

		Return success
	End Function


	Public Function GetDaysInMonth(year As Double) As Double ()
		Dim daysInMonth As Double ()

		daysInMonth = New Double (1.0 + 12.0 - 1){}

		daysInMonth(0) = 0.0
		daysInMonth(1) = 31.0

		If IsLeapYear(year)
			daysInMonth(2) = 29.0
		Else
			daysInMonth(2) = 28.0
		End If
		daysInMonth(3) = 31.0
		daysInMonth(4) = 30.0
		daysInMonth(5) = 31.0
		daysInMonth(6) = 30.0
		daysInMonth(7) = 31.0
		daysInMonth(8) = 31.0
		daysInMonth(9) = 30.0
		daysInMonth(10) = 31.0
		daysInMonth(11) = 30.0
		daysInMonth(12) = 31.0

		Return daysInMonth
	End Function


	Public Function DateToDaysWithCheck(ByRef datex As Datex, ByRef dayNumberReferenceReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim days As Double
		Dim success As Boolean

		success = IsValidDate(datex, message)
		If success
			days = DateToDays(datex)
			dayNumberReferenceReference.numberValue = days
		End If

		Return success
	End Function


	Public Function DateToDays(ByRef datex As Datex) As Double
		Dim days As Double

		' Day 1752-01-01
		days = -79623.0

		days = days + DaysInYears(datex.year)
		days = days + DaysInMonths(datex.month, datex.year)
		days = days + datex.day - 1.0

		Return days
	End Function


	Public Function DateToWeekdayNumberWithCheck(ByRef datex As Datex, ByRef weekDayNumberReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim weekDay As Double
		Dim success As Boolean

		success = IsValidDate(datex, message)
		If success
			weekDay = DateToWeekdayNumber(datex)
			weekDayNumberReference.numberValue = weekDay
		End If

		Return success
	End Function


	Public Function DateToWeekdayNumber(ByRef datex As Datex) As Double
		Dim days, weekDay As Double

		days = DateToDays(datex)

		days = days + 79623.0
		days = days + 5.0

		weekDay = days Mod 7.0 + 1.0

		Return weekDay
	End Function


	Public Function DateToWeeknumber(ByRef datex As Datex, ByRef yearRef As NumberReference) As Double
		Dim weekNumber, weekday, days, daysWeek1Start, weekdayNewYears As Double
		Dim week1Start, newyears As Datex

		week1Start = CopyDate(datex)

		week1Start.day = 1.0
		week1Start.month = 1.0
		weekday = DateToWeekdayNumber(week1Start)

		' Set week1Start to the start of the Week 1.
		' If monday, week 1 begins on Jan. 1st
		If weekday = 1.0
			week1Start.day = 1.0
		End If
		' If tuesday, week 1 begins on Dec. 31st
		If weekday = 2.0
			week1Start.year = week1Start.year - 1.0
			week1Start.month = 12.0
			week1Start.day = 31.0
		End If
		' If wednesday, week 1 begins on Dec. 30th
		If weekday = 3.0
			week1Start.year = week1Start.year - 1.0
			week1Start.month = 12.0
			week1Start.day = 30.0
		End If
		' If thursday, week 1 begins on Dec. 29th
		If weekday = 4.0
			week1Start.year = week1Start.year - 1.0
			week1Start.month = 12.0
			week1Start.day = 29.0
		End If
		' If friday, week 1 begins on Jan. 4th
		If weekday = 5.0
			week1Start.day = 4.0
		End If
		' If saturday, week 1 begins on Jan. 3rd
		If weekday = 6.0
			week1Start.day = 3.0
		End If
		' If sunday, week 1 begins on Jan. 2nd
		If weekday = 7.0
			week1Start.day = 2.0
		End If

		days = DateToDays(datex)
		daysWeek1Start = DateToDays(week1Start)

		If days >= daysWeek1Start
			weekNumber = 1.0 + Floor((days - daysWeek1Start)/7.0)

			If weekNumber >= 1.0 And weekNumber <= 52.0
				' Week is between 1 and 52 in the current year.
				yearRef.numberValue = datex.year
			Else
				' Is week nr 53 or 1 next year?
				newyears = CopyDate(datex)
				newyears.month = 12.0
				newyears.day = 31.0
				weekdayNewYears = DateToWeekdayNumber(newyears)
				If weekdayNewYears = 1.0 Or weekdayNewYears = 2.0 Or weekdayNewYears = 3.0
					' Week 1 next year.
					weekNumber = 1.0
					yearRef.numberValue = datex.year + 1.0
				Else
					' Week 53
					yearRef.numberValue = datex.year
				End If
				newyears = Nothing
			End If
		Else
			' Week is in previous year. Either 52nd or 53rd.
			newyears = CopyDate(datex)
			newyears.month = 12.0
			newyears.day = 31.0
			newyears.year = datex.year - 1.0
			weekNumber = DateToWeeknumber(newyears, yearRef)
			newyears = Nothing
		End If

		week1Start = Nothing

		Return weekNumber
	End Function


	Public Function DaysInMonthsWithCheck(month As Double, year As Double, ByRef daysInMonthsReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim days As Double
		Dim success As Boolean
		Dim datex As Datex

		datex = CreateDate(year, month, 1.0)

		success = IsValidDate(datex, message)
		If success
			days = DaysInMonths(month, year)

			daysInMonthsReference.numberValue = days
		End If

		Return success
	End Function


	Public Function DaysInMonths(month As Double, year As Double) As Double
		Dim daysInMonth As Double ()
		Dim days As Double
		Dim i As Double

		daysInMonth = GetDaysInMonth(year)

		days = 0.0
		i = 1.0
		While i < month
			days = days + daysInMonth(i)
			i = i + 1.0
		End While

		Return days
	End Function


	Public Function DaysInYearsWithCheck(years As Double, ByRef daysReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim days As Double
		Dim success As Boolean
		Dim datex As Datex

		datex = CreateDate(years, 1.0, 1.0)

		success = IsValidDate(datex, message)
		If success
			days = DaysInYears(years)
			daysReference.numberValue = days
		End If

		Return success
	End Function


	Public Function DaysInYears(years As Double) As Double
		Dim days As Double
		Dim i As Double
		Dim nrOfDays As Double

		days = 0.0
		i = 1752.0
		While i < years
			If IsLeapYear(i)
				nrOfDays = 366.0
			Else
				nrOfDays = 365.0
			End If
			days = days + nrOfDays
			i = i + 1.0
		End While

		Return days
	End Function


	Public Function IsValidDate(ByRef datex As Datex, ByRef message As StringReference) As Boolean
		Dim valid As Boolean
		Dim daysInMonth As Double ()
		Dim daysInThisMonth As Double

		If datex.year >= 1752.0
			If datex.month >= 1.0 And datex.month <= 12.0
				daysInMonth = GetDaysInMonth(datex.year)
				daysInThisMonth = daysInMonth(datex.month)
				If datex.day >= 1.0 And datex.day <= daysInThisMonth
					valid = true
				Else
					valid = false
					message.stringx = "The month does not have the given day number.".ToCharArray()
				End If
			Else
				valid = false
				message.stringx = "Month must be between 1 and 12, inclusive.".ToCharArray()
			End If
		Else
			valid = false
			message.stringx = "Gregorian calendar was not in general use before 1752.".ToCharArray()
		End If

		Return valid
	End Function


	Public Function AddDaysToDate(ByRef datex As Datex, days As Double, ByRef message As StringReference) As Boolean
		Dim n As Double
		Dim success As Boolean
		Dim dateReference As DateReference
		Dim daysRef As NumberReference

		daysRef = New NumberReference()
		success = DateToDaysWithCheck(datex, daysRef, message)

		If success
			n = daysRef.numberValue
			n = n + days

			dateReference = New DateReference()
			success = DayToDateWithCheck(n, dateReference, message)
			If success
				Call AssignDate(datex, dateReference.datex)
			End If
		End If

		Return success
	End Function


	Public Sub AssignDate(ByRef a As Datex, ByRef b As Datex)
		a.year = b.year
		a.month = b.month
		a.day = b.day
	End Sub


	Public Sub AddMonthsToDate(ByRef datex As Datex, months As Double)
		Dim i As Double

		If months > 0.0
			i = 0.0
			While i < months
				datex.month = datex.month + 1.0

				If datex.month = 13.0
					datex.month = 1.0
					datex.year = datex.year + 1.0
				End If
				i = i + 1.0
			End While
		End If
		If months < 0.0
			i = 0.0
			While i < -months
				datex.month = datex.month - 1.0

				If datex.month = 0.0
					datex.month = 12.0
					datex.year = datex.year - 1.0
				End If
				i = i + 1.0
			End While
		End If
	End Sub


	Public Function DateToStringISO8601WithCheck(ByRef datex As Datex, ByRef datestr As StringReference, ByRef message As StringReference) As Boolean
		Dim success As Boolean

		success = IsValidDate(datex, message)

		If success
			If datex.year <= 9999.0
				datestr.stringx = DateToStringISO8601(datex)
			Else
				message.stringx = "This library works from 1752 to 9999.".ToCharArray()
			End If
		End If

		Return success
	End Function


	Public Function DateToStringISO8601(ByRef datex As Datex) As Char ()
		Dim str As Char ()

		str = New Char (10 - 1){}

		str(0) = cDecimalDigitToCharacter(Floor(datex.year/1000.0))
		str(1) = cDecimalDigitToCharacter(Floor((datex.year Mod 1000.0)/100.0))
		str(2) = cDecimalDigitToCharacter(Floor((datex.year Mod 100.0)/10.0))
		str(3) = cDecimalDigitToCharacter(Floor(datex.year Mod 10.0))

		str(4) = "-"C

		str(5) = cDecimalDigitToCharacter(Floor((datex.month Mod 100.0)/10.0))
		str(6) = cDecimalDigitToCharacter(Floor(datex.month Mod 10.0))

		str(7) = "-"C

		str(8) = cDecimalDigitToCharacter(Floor((datex.day Mod 100.0)/10.0))
		str(9) = cDecimalDigitToCharacter(Floor(datex.day Mod 10.0))

		Return str
	End Function


	Public Function DateFromStringISO8601(ByRef str As Char ()) As Datex
		Dim datex As Datex
		Dim n As Double

		datex = New Datex()

		n = cCharacterToDecimalDigit(str(0))*1000.0
		n = n + cCharacterToDecimalDigit(str(1))*100.0
		n = n + cCharacterToDecimalDigit(str(2))*10.0
		n = n + cCharacterToDecimalDigit(str(3))*1.0

		datex.year = n

		n = cCharacterToDecimalDigit(str(5))*10.0
		n = n + cCharacterToDecimalDigit(str(6))*1.0

		datex.month = n

		n = cCharacterToDecimalDigit(str(8))*10.0
		n = n + cCharacterToDecimalDigit(str(9))*1.0

		datex.day = n

		Return datex
	End Function


	Public Function DateFromStringISO8601WithCheck(ByRef str As Char (), ByRef dateRef As DateReference, ByRef message As StringReference) As Boolean
		Dim valid As Boolean

		valid = IsValidDateISO8601(str, message)

		If valid
			dateRef.datex = DateFromStringISO8601(str)
		End If

		Return valid
	End Function


	Public Function IsValidDateISO8601(ByRef str As Char (), ByRef message As StringReference) As Boolean
		Dim valid As Boolean

		If str.Length = 4.0 + 1.0 + 2.0 + 1.0 + 2.0

			If cIsNumber(str(0)) And cIsNumber(str(1)) And cIsNumber(str(2)) And cIsNumber(str(3)) And cIsNumber(str(5)) And cIsNumber(str(6)) And cIsNumber(str(8)) And cIsNumber(str(9))
				If str(4) = "-"C And str(7) = "-"C
					valid = true
				Else
					valid = false
					message.stringx = "ISO8601 date must use \'-\' in positions 5 and 8.".ToCharArray()
				End If
			Else
				valid = false
				message.stringx = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.".ToCharArray()
			End If
		Else
			valid = false
			message.stringx = "ISO8601 date must be exactly 10 characters long.".ToCharArray()
		End If

		Return valid
	End Function


	Public Function DateEquals(ByRef a As Datex, ByRef b As Datex) As Boolean
		Return a.year = b.year And a.month = b.month And a.day = b.day
	End Function


	Public Function CopyDate(ByRef a As Datex) As Datex
		Dim b As Datex

		b = CreateDate(a.year, a.month, a.day)

		Return b
	End Function


	Public Function GetSecondsFromDate(ByRef datex As Datex) As Double
		Dim seconds, days, secondsInMinute, secondsInHour, secondsInDay As Double
		Dim dayNumberReferenceReference As NumberReference
		Dim message As StringReference
		Dim success As Boolean

		seconds = 0.0
		dayNumberReferenceReference = New NumberReference()
		message = New StringReference()

		success = DateToDaysWithCheck(datex, dayNumberReferenceReference, message)
		If success
			days = dayNumberReferenceReference.numberValue

			secondsInMinute = 60.0
			secondsInHour = 60.0*secondsInMinute
			secondsInDay = 24.0*secondsInHour

			seconds = seconds + secondsInDay*days
		End If

		dayNumberReferenceReference = Nothing
		message = Nothing

		Return seconds
	End Function


	Public Function DateIsInInterval(ByRef interval As Interval, ByRef datex As Datex) As Boolean
		Dim from, tox, day As Double

		from = DateToDays(interval.first)
		tox = DateToDays(interval.last)
		day = DateToDays(datex)

		Return day >= from And day <= tox
	End Function


	Public Function DateLessThan(ByRef a As Datex, ByRef b As Datex) As Boolean
		Dim aDays, bDays As Double

		aDays = DateToDays(a)
		bDays = DateToDays(b)

		Return aDays < bDays
	End Function


	Public Function CreateDateTimeTimezone(year As Double, month As Double, day As Double, hours As Double, minutes As Double, seconds As Double, timezoneOffsetSeconds As Double) As DateTimeTimezone
		Dim dateTimeTimezone As DateTimeTimezone

		dateTimeTimezone = New DateTimeTimezone()

		dateTimeTimezone.dateTimex = CreateDateTime(year, month, day, hours, minutes, seconds)
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

		Return dateTimeTimezone
	End Function


	Public Function CreateDateTimeTimezoneInHoursAndMinutes(year As Double, month As Double, day As Double, hours As Double, minutes As Double, seconds As Double, timezoneOffsetHours As Double, timezoneOffsetMinutes As Double) As DateTimeTimezone
		Dim dateTimeTimezone As DateTimeTimezone

		dateTimeTimezone = New DateTimeTimezone()

		dateTimeTimezone.dateTimex = CreateDateTime(year, month, day, hours, minutes, seconds)
		dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes)

		Return dateTimeTimezone
	End Function


	Public Function GetDateFromDateTimeTimeZone(ByRef dateTimeTimezone As DateTimeTimezone, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Dim dateTimex As DateTimex

		dateTimex = dateTimeTimezone.dateTimex

		Return AddSecondsToDateTimeWithCheck(dateTimex, -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message)
	End Function


	Public Function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(ByRef dateTimex As DateTimex, timezoneOffsetSeconds As Double, ByRef dateTimeTimezoneReference As DateTimeTimezoneReference, ByRef message As StringReference) As Boolean
		Dim success As Boolean
		Dim adjustedDateTimeReference As DateTimeReference
		Dim dateTimeTimezone As DateTimeTimezone

		adjustedDateTimeReference = New DateTimeReference()
		dateTimeTimezone = New DateTimeTimezone()

		success = AddSecondsToDateTime(dateTimex, timezoneOffsetSeconds, adjustedDateTimeReference, message)

		If success
			dateTimeTimezone.dateTimex = adjustedDateTimeReference.dateTimex
			dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

			dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone
		End If

		Return success
	End Function


	Public Function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(ByRef dateTimex As DateTimex, timezoneOffsetHours As Double, timezoneOffsetMinutes As Double, ByRef dateTimeTimezoneReference As DateTimeTimezoneReference, ByRef message As StringReference) As Boolean
		Return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimex, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message)
	End Function


	Public Function GetDateTimeTimezoneFromSeconds(ByRef dateTimeTzRef As DateTimeTimezoneReference, seconds As Double, offset As Double, ByRef message As StringReference) As Boolean
		Dim success As Boolean
		Dim dateTimeRef As DateTimeReference

		dateTimeRef = New DateTimeReference()
		success = GetDateTimeFromSeconds(seconds, dateTimeRef, message)

		If success
			success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTimex, offset, dateTimeTzRef, message)
		End If

		Return success
	End Function


	Public Function CreateDateTime(year As Double, month As Double, day As Double, hours As Double, minutes As Double, seconds As Double) As DateTimex
		Dim dateTimex As DateTimex

		dateTimex = New DateTimex()

		dateTimex.datex = CreateDate(year, month, day)
		dateTimex.hours = hours
		dateTimex.minutes = minutes
		dateTimex.seconds = seconds

		Return dateTimex
	End Function


	Public Function GetDateTimeFromSeconds(seconds As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Dim dateTimex As DateTimex
		Dim secondsInMinute, secondsInHour, secondsInDay, days, remainder As Double
		Dim datex As Datex
		Dim dateReference As DateReference
		Dim success As Boolean

		secondsInMinute = 60.0
		secondsInHour = 60.0*secondsInMinute
		secondsInDay = 24.0*secondsInHour
		days = Floor(seconds/secondsInDay)
		remainder = seconds - days*secondsInDay
		dateReference = New DateReference()

		success = DayToDateWithCheck(days, dateReference, message)
		If success
			datex = dateReference.datex

			dateTimex = New DateTimex()
			dateTimex.datex = datex
			dateTimex.hours = Floor(remainder/secondsInHour)
			remainder = remainder - dateTimex.hours*secondsInHour
			dateTimex.minutes = Floor(remainder/secondsInMinute)
			remainder = remainder - dateTimex.minutes*secondsInMinute
			dateTimex.seconds = remainder

			dateTimeReference.dateTimex = dateTimex
		End If

		Return success
	End Function


	Public Function GetSecondsFromDateTime(ByRef dateTimex As DateTimex) As Double
		Dim seconds, secondsInMinute, secondsInHour As Double

		secondsInMinute = 60.0
		secondsInHour = 60.0*secondsInMinute

		seconds = GetSecondsFromDate(dateTimex.datex)
		seconds = seconds + secondsInHour*dateTimex.hours
		seconds = seconds + secondsInMinute*dateTimex.minutes
		seconds = seconds + dateTimex.seconds

		Return seconds
	End Function


	Public Function GetSecondsFromMinutes(minutes As Double) As Double
		Return minutes*60.0
	End Function


	Public Function GetSecondsFromHours(hours As Double) As Double
		Return GetSecondsFromMinutes(hours*60.0)
	End Function


	Public Function GetSecondsFromDays(days As Double) As Double
		Return GetSecondsFromHours(days*24.0)
	End Function


	Public Function GetSecondsFromWeeks(weeks As Double) As Double
		Return GetSecondsFromDays(weeks*7.0)
	End Function


	Public Function GetMinutesFromSeconds(seconds As Double) As Double
		Return seconds/60.0
	End Function


	Public Function GetHoursFromSeconds(seconds As Double) As Double
		Return GetMinutesFromSeconds(seconds)/60.0
	End Function


	Public Function GetDaysFromSeconds(seconds As Double) As Double
		Return GetHoursFromSeconds(seconds)/24.0
	End Function


	Public Function GetWeeksFromSeconds(seconds As Double) As Double
		Return GetDaysFromSeconds(seconds)/7.0
	End Function


	Public Function GetDateFromDateTime(ByRef dateTimex As DateTimex) As Datex
		Return dateTimex.datex
	End Function


	Public Function AddSecondsToDateTimeWithCheck(ByRef dateTimex As DateTimex, seconds As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Dim secondsInDateTime As Double
		Dim success As Boolean

		If IsValidDateTime(dateTimex, message)
			secondsInDateTime = GetSecondsFromDateTime(dateTimex)
			secondsInDateTime = secondsInDateTime + seconds

			success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message)
		Else
			success = false
		End If

		Return success
	End Function


	Public Function AddSecondsToDateTime(ByRef dateTimex As DateTimex, seconds As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Dim secondsInDateTime As Double

		secondsInDateTime = GetSecondsFromDateTime(dateTimex)
		secondsInDateTime = secondsInDateTime + seconds

		Return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message)
	End Function


	Public Function AddMinutesToDateTime(ByRef dateTimex As DateTimex, minutes As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Return AddSecondsToDateTime(dateTimex, GetSecondsFromMinutes(minutes), dateTimeReference, message)
	End Function


	Public Function AddHoursToDateTime(ByRef dateTimex As DateTimex, hours As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Return AddSecondsToDateTime(dateTimex, GetSecondsFromHours(hours), dateTimeReference, message)
	End Function


	Public Function AddDaysToDateTime(ByRef dateTimex As DateTimex, days As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Return AddSecondsToDateTime(dateTimex, GetSecondsFromDays(days), dateTimeReference, message)
	End Function


	Public Function AddWeeksToDateTime(ByRef dateTimex As DateTimex, weeks As Double, ByRef dateTimeReference As DateTimeReference, ByRef message As StringReference) As Boolean
		Return AddSecondsToDateTime(dateTimex, GetSecondsFromWeeks(weeks), dateTimeReference, message)
	End Function


	Public Function DateTimeToStringISO8601WithCheck(ByRef datetimex As DateTimex, ByRef dateStr As StringReference, ByRef message As StringReference) As Boolean
		Dim success As Boolean

		success = DateToStringISO8601WithCheck(datetimex.datex, dateStr, message)

		If success
			Erase dateStr.stringx 

			success = IsValidDateTime(datetimex, message)
			If success
				dateStr.stringx = DateTimeToStringISO8601(datetimex)
			End If
		End If

		Return success
	End Function


	Public Function IsValidDateTime(ByRef datetimex As DateTimex, ByRef message As StringReference) As Boolean
		Dim success As Boolean

		success = IsValidDate(datetimex.datex, message)

		If success
			If datetimex.hours <= 23.0 And datetimex.hours >= 0.0
				If datetimex.minutes <= 59.0 And datetimex.minutes >= 0.0
					If datetimex.seconds <= 59.0 And datetimex.seconds >= 0.0
						success = true
					Else
						success = false
						message.stringx = "Seconds must be between 0 and 59.".ToCharArray()
					End If
				Else
					success = false
					message.stringx = "Minutes must be between 0 and 59.".ToCharArray()
				End If
			Else
				success = false
				message.stringx = "Hours must be between 0 and 23.".ToCharArray()
			End If
		End If

		Return success
	End Function


	Public Function DateTimeToStringISO8601(ByRef datetimex As DateTimex) As Char ()
		Dim datestr, str As Char ()
		Dim i As Double

		str = New Char (19 - 1){}

		datestr = DateToStringISO8601(datetimex.datex)
		i = 0.0
		While i < datestr.Length
			str(i) = datestr(i)
			i = i + 1.0
		End While

		str(10) = "T"C
		str(11) = cDecimalDigitToCharacter(Floor((datetimex.hours Mod 100.0)/10.0))
		str(12) = cDecimalDigitToCharacter(Floor(datetimex.hours Mod 10.0))

		str(13) = ":"C

		str(14) = cDecimalDigitToCharacter(Floor((datetimex.minutes Mod 100.0)/10.0))
		str(15) = cDecimalDigitToCharacter(Floor(datetimex.minutes Mod 10.0))

		str(16) = ":"C

		str(17) = cDecimalDigitToCharacter(Floor((datetimex.seconds Mod 100.0)/10.0))
		str(18) = cDecimalDigitToCharacter(Floor(datetimex.seconds Mod 10.0))

		Return str
	End Function


	Public Function DateTimeFromStringISO8601(ByRef str As Char ()) As DateTimex
		Dim dateTimex As DateTimex
		Dim n As Double

		dateTimex = New DateTimex()

		dateTimex.datex = DateFromStringISO8601(str)

		n = cCharacterToDecimalDigit(str(11))*10.0
		n = n + cCharacterToDecimalDigit(str(12))*1.0

		dateTimex.hours = n

		n = cCharacterToDecimalDigit(str(14))*10.0
		n = n + cCharacterToDecimalDigit(str(15))*1.0

		dateTimex.minutes = n

		n = cCharacterToDecimalDigit(str(17))*10.0
		n = n + cCharacterToDecimalDigit(str(18))*1.0

		dateTimex.seconds = n

		Return dateTimex
	End Function


	Public Function DateTimeFromStringISO8601WithCheck(ByRef str As Char (), ByRef dateTimeRef As DateTimeReference, ByRef message As StringReference) As Boolean
		Dim valid As Boolean

		valid = IsValidDateTimeISO8601(str, message)

		If valid
			dateTimeRef.dateTimex = DateTimeFromStringISO8601(str)
		End If

		Return valid
	End Function


	Public Function IsValidDateTimeISO8601(ByRef str As Char (), ByRef message As StringReference) As Boolean
		Dim valid As Boolean

		If str.Length = 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0

			If cIsNumber(str(0)) And cIsNumber(str(1)) And cIsNumber(str(2)) And cIsNumber(str(3)) And cIsNumber(str(5)) And cIsNumber(str(6)) And cIsNumber(str(8)) And cIsNumber(str(9)) And cIsNumber(str(11)) And cIsNumber(str(12)) And cIsNumber(str(14)) And cIsNumber(str(15)) And cIsNumber(str(17)) And cIsNumber(str(18))
				If str(4) = "-"C And str(7) = "-"C And str(10) = "T"C And str(13) = ":"C And str(16) = ":"C
					valid = true
				Else
					valid = false
					message.stringx = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.".ToCharArray()
				End If
			Else
				valid = false
				message.stringx = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.".ToCharArray()
			End If
		Else
			valid = false
			message.stringx = "ISO8601 date must be exactly 19 characters long.".ToCharArray()
		End If

		Return valid
	End Function


	Public Function DateTimeEquals(ByRef a As DateTimex, ByRef b As DateTimex) As Boolean
		Return DateEquals(a.datex, b.datex) And a.hours = b.hours And a.minutes = b.minutes And a.seconds = b.seconds
	End Function


	Public Sub FreeDateTime(ByRef datetimex As DateTimex)
		datetimex.datex = Nothing
		datetimex = Nothing
	End Sub


	Public Function CreateFixedPoint30d(digitsBeforeDecimalPoint As Double, digitsAfterDecimalPoint As Double) As FixedPoint30d
		Dim fp As FixedPoint30d

		fp = New FixedPoint30d()
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
		fp.part1 = 0.0
		fp.part2 = 0.0

		Return fp
	End Function


	Public Function CreateFixedPoint15d(digitsBeforeDecimalPoint As Double, digitsAfterDecimalPoint As Double) As FixedPoint15d
		Dim fp As FixedPoint15d

		fp = New FixedPoint15d()
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
		fp.number = 0.0

		Return fp
	End Function


	Public Function ToNumber15d(ByRef n As FixedPoint15d) As Double
		Return n.number
	End Function


	Public Function Number15d(number As Double) As FixedPoint15d
		Dim fp As FixedPoint15d

		fp = New FixedPoint15d()
		fp.digitsBeforeDecimalPoint = 7.0
		fp.digitsAfterDecimalPoint = 7.0
		fp.number = number

		Return fp
	End Function


	Public Function Assign15d(ByRef fp As FixedPoint15d, number As Double) As Boolean
		Dim success As Boolean

		success = Not WillOverflow15d(fp, number)
		success = success And FixedPointIsValid15d(fp)

		If success
			fp.number = number
			fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint)
		End If

		Return success
	End Function


	Public Function Assign15dFloor(ByRef fp As FixedPoint15d, number As Double) As Boolean
		Dim success As Boolean

		success = Not WillOverflow15d(fp, number)
		success = success And FixedPointIsValid15d(fp)

		If success
			fp.number = number
			fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint)
		End If

		Return success
	End Function


	Public Function FixedPointIsValid15d(ByRef fp As FixedPoint15d) As Boolean
		Dim valid As Boolean

		If IsInteger(fp.digitsAfterDecimalPoint) And IsInteger(fp.digitsBeforeDecimalPoint)
			If fp.digitsBeforeDecimalPoint >= 0.0 And fp.digitsBeforeDecimalPoint <= 15.0
				If fp.digitsAfterDecimalPoint >= 0.0 And fp.digitsAfterDecimalPoint <= 15.0
					If fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15.0
						If fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0.0
							valid = true
						Else
							valid = false
						End If
					Else
						valid = false
					End If
				Else
					valid = false
				End If
			Else
				valid = false
			End If
		Else
			valid = false
		End If

		Return valid
	End Function


	Public Function WillOverflow15d(ByRef fp As FixedPoint15d, number As Double) As Boolean
		Dim overflow As Boolean

		If Abs(number) < 10.0 ^ fp.digitsBeforeDecimalPoint
			overflow = false
		Else
			overflow = true
		End If

		Return overflow
	End Function


	Public Function FloorToDigits(value As Double, digits As Double) As Double
		Return Floor(value*10.0 ^ digits)/10.0 ^ digits
	End Function


	Public Function ToString15d(ByRef fp As FixedPoint15d) As Char ()
		Dim stringx As Char ()
		Dim digits As Double
		Dim digitPosition As Double
		Dim i, d, decimalx As Double
		Dim characterReference As CharacterReference

		stringx = New Char (1.0 + fp.digitsBeforeDecimalPoint + 1.0 + fp.digitsAfterDecimalPoint - 1){}

		decimalx = fp.number*10.0 ^ fp.digitsAfterDecimalPoint

		If decimalx < 0.0
			decimalx = -decimalx
			stringx(0) = "-"C
		Else
			stringx(0) = "+"C
		End If

		decimalx = Roundx(decimalx)

		characterReference = New CharacterReference()

		digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint
		digitPosition = 1.0

		i = 0.0
		While i < digits
			If i = fp.digitsBeforeDecimalPoint
				stringx(digitPosition) = "."C

				digitPosition = digitPosition + 1.0
			End If

			d = Floor(decimalx/10.0 ^ (digits - i - 1.0))
			d = d Mod 10.0

			GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference)
			stringx(digitPosition) = characterReference.characterValue

			digitPosition = digitPosition + 1.0
			i = i + 1.0
		End While

		characterReference = Nothing

		Return stringx
	End Function


	Public Function Add15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d, ByRef c As FixedPoint15d) As Boolean
		Return Assign15d(a, b.number + c.number)
	End Function


	Public Function Subtract15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d, ByRef c As FixedPoint15d) As Boolean
		Return Assign15d(a, b.number - c.number)
	End Function


	Public Function Multiply15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d, ByRef c As FixedPoint15d) As Boolean
		Return Assign15d(a, b.number*c.number)
	End Function


	Public Function DivideFloored15d(ByRef q As FixedPoint15d, ByRef r As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim success As Boolean
		Dim x, xDivisor, xDividend As Double
		Dim t As FixedPoint15d

		t = Copy15d(r)

		If b.number <> 0.0
			xDivisor = Roundx(a.number*10.0 ^ q.digitsAfterDecimalPoint*10.0 ^ q.digitsAfterDecimalPoint)
			xDividend = Roundx(b.number*10.0 ^ q.digitsAfterDecimalPoint)
			x = Floor(xDivisor/xDividend)
			x = x/10.0 ^ q.digitsAfterDecimalPoint
			success = Assign15d(q, x)
			Multiply15d(t, q, b)
			Subtract15d(r, a, t)
		Else
			success = false
		End If

		t = Nothing

		Return success
	End Function


	Public Function Copy15d(ByRef r As FixedPoint15d) As FixedPoint15d
		Dim t As FixedPoint15d

		t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint)
		t.number = r.number

		Return t
	End Function


	Public Sub Negate15d(ByRef a As FixedPoint15d)
		a.number = -a.number
	End Sub


	Public Sub Positive15d(ByRef a As FixedPoint15d)
		a.number = +a.number
	End Sub


	Public Function Factorial15d(ByRef x As FixedPoint15d) As Boolean
		Dim success As Boolean

		If x.number >= 0.0
			success = Assign15d(x, Factorial(x.number))
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Round15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Roundx(x.number))
	End Function


	Public Function BankersRound15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, BankersRound(x.number))
	End Function


	Public Function Ceil15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Ceil(x.number))
	End Function


	Public Function Floor15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Floor(x.number))
	End Function


	Public Sub Truncate15d(ByRef x As FixedPoint15d)
		x.number = Truncatex(x.number)
	End Sub


	Public Sub Absolute15d(ByRef x As FixedPoint15d)
		x.number = Abs(x.number)
	End Sub


	Public Function Logarithm15d(ByRef x As FixedPoint15d) As Boolean
		Dim success As Boolean

		If x.number > 0.0
			success = Assign15d(x, Logarithm(x.number))
		Else
			success = false
		End If

		Return success
	End Function


	Public Function NaturalLogarithm15d(ByRef x As FixedPoint15d) As Boolean
		Dim success As Boolean

		If x.number > 0.0
			success = Assign15d(x, NaturalLogarithm(x.number))
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Sin15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Sinx(x.number))
	End Function


	Public Function Cos15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Cosx(x.number))
	End Function


	Public Function Tan15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Tanx(x.number))
	End Function


	Public Function Asin15d(ByRef x As FixedPoint15d) As Boolean
		Dim success As Boolean

		If x.number >= -1.0 And x.number <= 1.0
			success = Assign15d(x, Asinx(x.number))
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Acos15d(ByRef x As FixedPoint15d) As Boolean
		Dim success As Boolean

		If x.number >= -1.0 And x.number <= 1.0
			success = Assign15d(x, Acosx(x.number))
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Atan15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Atanx(x.number))
	End Function


	Public Function Atan2_15d(ByRef a As FixedPoint15d, ByRef y As FixedPoint15d, ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(a, Atan2x(y.number, x.number))
	End Function


	Public Function Squareroot15d(ByRef x As FixedPoint15d) As Boolean
		Dim success As Boolean

		If x.number >= 0.0
			success = Assign15d(x, Sqrt(x.number))
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Exp15d(ByRef x As FixedPoint15d) As Boolean
		Return Assign15d(x, Expx(x.number))
	End Function


	Public Function DivisibleBy15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Return ((a.number Mod b.number) = 0.0)
	End Function


	Public Function Combinations15d(ByRef x As FixedPoint15d, ByRef n As FixedPoint15d, ByRef k As FixedPoint15d) As Boolean
		Dim success As Boolean

		If IsInteger(n.number) And IsInteger(k.number)
			If n.number >= 1.0 And k.number >= 0.0 And n.number >= k.number
				success = Assign15d(x, Combinations(n.number, k.number))
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Permutations15d(ByRef x As FixedPoint15d, ByRef n As FixedPoint15d, ByRef k As FixedPoint15d) As Boolean
		Dim success As Boolean

		If IsInteger(n.number) And IsInteger(k.number)
			If n.number >= 1.0 And k.number >= 0.0 And n.number >= k.number
				success = Assign15d(x, Permutations(n.number, k.number))
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Equals15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim p, an, bn As Double
		Dim equals As Boolean

		an = ToNumber15d(a)
		bn = ToNumber15d(b)

		p = Max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint)

		equals = EpsilonCompare(an, bn, 10.0 ^ (-p))

		Return equals
	End Function


	Public Function GreaterThan15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim an, bn As Double

		an = ToNumber15d(a)
		bn = ToNumber15d(b)

		Return an > bn
	End Function


	Public Function LessThan15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim an, bn As Double

		an = ToNumber15d(a)
		bn = ToNumber15d(b)

		Return an < bn
	End Function


	Public Function GreaterThanOrEqual15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim an, bn As Double
		Dim equal As Boolean

		an = ToNumber15d(a)
		bn = ToNumber15d(b)

		equal = Equals15d(a, b)

		Return an > bn Or equal
	End Function


	Public Function LessThanOrEqual15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim an, bn As Double
		Dim equal As Boolean

		an = ToNumber15d(a)
		bn = ToNumber15d(b)

		equal = Equals15d(a, b)

		Return an < bn Or equal
	End Function


	Public Function EpsilonCompare15d(ByRef a As FixedPoint15d, ByRef b As FixedPoint15d, ByRef epsilon As FixedPoint15d) As Boolean
		Return EpsilonCompare(a.number, b.number, epsilon.number)
	End Function


	Public Function GreatestCommonDivisor15d(ByRef x As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim success As Boolean

		If IsInteger(a.number) And IsInteger(b.number)
			If a.number >= 0.0 And b.number >= 0.0
				success = Assign15d(x, GreatestCommonDivisor(a.number, b.number))
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function GCDWithSubtraction15d(ByRef x As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim success As Boolean

		If IsInteger(a.number) And IsInteger(b.number)
			If a.number >= 0.0 And b.number >= 0.0
				success = Assign15d(x, GCDWithSubtraction(a.number, b.number))
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function IsInteger15d(ByRef a As FixedPoint15d) As Boolean
		Return IsInteger(a.number)
	End Function


	Public Function LeastCommonMultiple15d(ByRef x As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim success As Boolean

		If IsInteger(a.number) And IsInteger(b.number)
			If a.number <> 0.0 And b.number <> 0.0
				success = Assign15d(x, LeastCommonMultiple(a.number, b.number))
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function Sign15d(ByRef a As FixedPoint15d) As Double
		Return Signx(a.number)
	End Function


	Public Function Max15d(ByRef x As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Return Assign15d(x, Maxx(a.number, b.number))
	End Function


	Public Function Min15d(ByRef x As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Return Assign15d(x, Minx(a.number, b.number))
	End Function


	Public Function Power15d(ByRef x As FixedPoint15d, ByRef a As FixedPoint15d, ByRef b As FixedPoint15d) As Boolean
		Dim success As Boolean

		If a.number <> 0.0 Or b.number <> 0.0
			If Not (a.number < 0.0 And Not IsInteger(b.number))
				success = Assign15d(x, Power(a.number, b.number))
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function FormatToString15d(ByRef fp As FixedPoint15d, digitsAfter As Double) As Char ()
		Dim result As Char ()

		result = FormatToStringWithSymbols15d(fp, digitsAfter, "".ToCharArray(), ".".ToCharArray())

		Return result
	End Function


	Public Function FormatToStringWithSymbols15d(ByRef fp As FixedPoint15d, digitsAfter As Double, ByRef thousandsSeparator As Char (), ByRef decimalPoint As Char ()) As Char ()
		Dim stringx As Char ()
		Dim i, j, p, d, t, signx, extra, decimalx, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars As Double
		Dim characterReference As CharacterReference

		characterReference = New CharacterReference()

		decimalx = Roundx(fp.number*10.0 ^ digitsAfter)

		signx = 0.0
		If decimalx < 0.0
			signx = 1.0
			decimalx = -decimalx
		End If

		If decimalx <> 0.0
			digits = Floor(Log10(decimalx) + 1.0)
		Else
			digits = 1.0
		End If
		digitsBefore = digits - digitsAfter

		If digitsBefore <= 0.0
			digitsBefore = 0.0
			thousandsTimes = 0.0
			digits = digitsAfter + 1.0
		Else
			thousandsTimes = Floor((digitsBefore - 1.0)/3.0)
		End If
		thousandsChars = thousandsTimes*thousandsSeparator.Length

		If digitsAfter = 0.0
			decimalPointChars = 0.0
		Else
			decimalPointChars = decimalPoint.Length
		End If

		stringx = New Char (signx + digits + thousandsChars + decimalPointChars - 1){}
		p = 0.0

		If signx > 0.0
			stringx(p) = "-"C
			p = p + 1.0
		End If

		i = 0.0
		While i < digits
			If i = digitsBefore
				If i = 0.0
					stringx(p) = "0"C
					p = p + 1.0
					digits = digits - 1.0
				End If

				j = 0.0
				While j < decimalPoint.Length
					stringx(p) = decimalPoint(j)
					p = p + 1.0
					j = j + 1.0
				End While
			End If

			If i < digitsBefore
				If (digitsBefore - i) Mod 3.0 = 0.0 And i <> 0.0
					j = 0.0
					While j < thousandsSeparator.Length
						stringx(p) = thousandsSeparator(j)
						p = p + 1.0
						j = j + 1.0
					End While
				End If
			End If

			d = Floor(decimalx/10.0 ^ (digits - i - 1.0))
			d = d Mod 10.0

			GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference)
			stringx(p) = characterReference.characterValue

			p = p + 1.0
			i = i + 1.0
		End While

		' System.out.println(new String(string));
		Return stringx
	End Function


	Public Function NumberToHumanReadable(n As Double, digitsAfter As Double, ByRef thousandsSeparator As Char (), ByRef decimalPoint As Char ()) As Char ()
		Dim str As Char ()
		Dim u As Char
		Dim d, p3 As Double

		If Abs(n) < 1.0
			str = CreateStringDecimalFromNumber(n)
		Else
			d = Log10(n)

			p3 = Min(Floor(d/3.0), 8.0)

			If p3 = 0.0
				u = "B"C
			ElseIf p3 = 1.0
				u = "K"C
			ElseIf p3 = 2.0
				u = "M"C
			ElseIf p3 = 3.0
				u = "G"C
			ElseIf p3 = 4.0
				u = "T"C
			ElseIf p3 = 5.0
				u = "P"C
			ElseIf p3 = 6.0
				u = "E"C
			ElseIf p3 = 7.0
				u = "Z"C
			Else
				u = "Y"C
			End If

			If p3 > 1.0
				n = n/10.0 ^ (p3*3.0)
			End If

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint)

			If p3 > 1.0
				str = strAppendCharacter(str, u)
			End If
		End If

		Return str
	End Function


	Public Function NumberToHumanReadableBinaryPrefix(n As Double, digitsAfter As Double, ByRef thousandsSeparator As Char (), ByRef decimalPoint As Char ()) As Char ()
		Dim str As Char ()
		Dim u As Char ()
		Dim d, p3 As Double

		If Abs(n) < 1.0
			str = CreateStringDecimalFromNumber(n)
		Else
			d = Floor(Log(n)/Log(2.0)) + 1.0

			p3 = Min(Floor(d/10.0), 8.0)

			If p3 = 0.0
				u = "B".ToCharArray()
			ElseIf p3 = 1.0
				u = "Ki".ToCharArray()
			ElseIf p3 = 2.0
				u = "Mi".ToCharArray()
			ElseIf p3 = 3.0
				u = "Gi".ToCharArray()
			ElseIf p3 = 4.0
				u = "Ti".ToCharArray()
			ElseIf p3 = 5.0
				u = "Pi".ToCharArray()
			ElseIf p3 = 6.0
				u = "Ei".ToCharArray()
			ElseIf p3 = 7.0
				u = "Zi".ToCharArray()
			Else
				u = "Yi".ToCharArray()
			End If

			If p3 > 1.0
				n = n/2.0 ^ (p3*10.0)
			End If

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint)

			If p3 > 1.0
				str = strAppendString(str, u)
			End If
		End If

		Return str
	End Function


	Public Function AddNumber(ByRef list As Double (), a As Double) As Double ()
		Dim newlist As Double ()
		Dim i As Double

		newlist = New Double (list.Length + 1.0 - 1){}
		i = 0.0
		While i < list.Length
			newlist(i) = list(i)
			i = i + 1.0
		End While
		newlist(list.Length) = a
		
		Erase list 
		
		Return newlist
	End Function


	Public Sub AddNumberRef(ByRef list As NumberArrayReference, i As Double)
		list.numberArray = AddNumber(list.numberArray, i)
	End Sub


	Public Function RemoveNumber(ByRef list As Double (), n As Double) As Double ()
		Dim newlist As Double ()
		Dim i As Double

		newlist = New Double (list.Length - 1.0 - 1){}

		If n >= 0.0 And n < list.Length
			i = 0.0
			While i < list.Length
				If i < n
					newlist(i) = list(i)
				End If
				If i > n
					newlist(i - 1.0) = list(i)
				End If
				i = i + 1.0
			End While

			Erase list 
		Else
			Erase newlist 
		End If
		
		Return newlist
	End Function


	Public Function GetNumberRef(ByRef list As NumberArrayReference, i As Double) As Double
		Return list.numberArray(i)
	End Function


	Public Sub RemoveNumberRef(ByRef list As NumberArrayReference, i As Double)
		list.numberArray = RemoveNumber(list.numberArray, i)
	End Sub


	Public Function AddString(ByRef list As StringReference (), ByRef a As StringReference) As StringReference ()
		Dim newlist As StringReference ()
		Dim i As Double

		newlist = New StringReference (list.Length + 1.0 - 1){}

		i = 0.0
		While i < list.Length
			newlist(i) = list(i)
			i = i + 1.0
		End While
		newlist(list.Length) = a
		
		Erase list 
		
		Return newlist
	End Function


	Public Sub AddStringRef(ByRef list As StringArrayReference, ByRef i As StringReference)
		list.stringArray = AddString(list.stringArray, i)
	End Sub


	Public Function RemoveString(ByRef list As StringReference (), n As Double) As StringReference ()
		Dim newlist As StringReference ()
		Dim i As Double

		newlist = New StringReference (list.Length - 1.0 - 1){}

		If n >= 0.0 And n < list.Length
			i = 0.0
			While i < list.Length
				If i < n
					newlist(i) = list(i)
				End If
				If i > n
					newlist(i - 1.0) = list(i)
				End If
				i = i + 1.0
			End While

			Erase list 
		Else
			Erase newlist 
		End If
		
		Return newlist
	End Function


	Public Function GetStringRef(ByRef list As StringArrayReference, i As Double) As StringReference
		Return list.stringArray(i)
	End Function


	Public Sub RemoveStringRef(ByRef list As StringArrayReference, i As Double)
		list.stringArray = RemoveString(list.stringArray, i)
	End Sub


	Public Function CreateDynamicArrayCharacters() As DynamicArrayCharacters
		Dim da As DynamicArrayCharacters

		da = New DynamicArrayCharacters()
		da.arrayx = New Char (10 - 1){}
		da.length = 0.0

		Return da
	End Function


	Public Function CreateDynamicArrayCharactersWithInitialCapacity(capacity As Double) As DynamicArrayCharacters
		Dim da As DynamicArrayCharacters

		da = New DynamicArrayCharacters()
		da.arrayx = New Char (capacity - 1){}
		da.length = 0.0

		Return da
	End Function


	Public Sub DynamicArrayAddCharacter(ByRef da As DynamicArrayCharacters, value As Char)
		If da.length = da.arrayx.Length
			Call DynamicArrayCharactersIncreaseSize(da)
		End If

		da.arrayx(da.length) = value
		da.length = da.length + 1.0
	End Sub


	Public Sub DynamicArrayAddString(ByRef da As DynamicArrayCharacters, ByRef str As Char ())
		Dim i As Double

		i = 0.0
		While i < str.Length
			Call DynamicArrayAddCharacter(da, str(i))
			i = i + 1.0
		End While
	End Sub


	Public Sub DynamicArrayCharactersIncreaseSize(ByRef da As DynamicArrayCharacters)
		Dim newLength, i As Double
		Dim newArray As Char ()

		newLength = Round(da.arrayx.Length*3.0/2.0)
		newArray = New Char (newLength - 1){}

		i = 0.0
		While i < da.arrayx.Length
			newArray(i) = da.arrayx(i)
			i = i + 1.0
		End While

		Erase da.arrayx 

		da.arrayx = newArray
	End Sub


	Public Function DynamicArrayCharactersDecreaseSizeNecessary(ByRef da As DynamicArrayCharacters) As Boolean
		Dim needsDecrease As Boolean

		needsDecrease = false

		If da.length > 10.0
			needsDecrease = da.length <= Round(da.arrayx.Length*2.0/3.0)
		End If

		Return needsDecrease
	End Function


	Public Sub DynamicArrayCharactersDecreaseSize(ByRef da As DynamicArrayCharacters)
		Dim newLength, i As Double
		Dim newArray As Char ()

		newLength = Round(da.arrayx.Length*2.0/3.0)
		newArray = New Char (newLength - 1){}

		i = 0.0
		While i < newLength
			newArray(i) = da.arrayx(i)
			i = i + 1.0
		End While

		Erase da.arrayx 

		da.arrayx = newArray
	End Sub


	Public Function DynamicArrayCharactersIndex(ByRef da As DynamicArrayCharacters, index As Double) As Char
		Return da.arrayx(index)
	End Function


	Public Function DynamicArrayCharactersLength(ByRef da As DynamicArrayCharacters) As Double
		Return da.length
	End Function


	Public Sub DynamicArrayInsertCharacter(ByRef da As DynamicArrayCharacters, index As Double, value As Char)
		Dim i As Double

		If da.length = da.arrayx.Length
			Call DynamicArrayCharactersIncreaseSize(da)
		End If

		i = da.length
		While i > index
			da.arrayx(i) = da.arrayx(i - 1.0)
			i = i - 1.0
		End While

		da.arrayx(index) = value

		da.length = da.length + 1.0
	End Sub


	Public Function DynamicArrayCharacterSet(ByRef da As DynamicArrayCharacters, index As Double, value As Char) As Boolean
		Dim success As Boolean

		If index < da.length
			da.arrayx(index) = value
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Sub DynamicArrayRemoveCharacter(ByRef da As DynamicArrayCharacters, index As Double)
		Dim i As Double

		i = index
		While i < da.length - 1.0
			da.arrayx(i) = da.arrayx(i + 1.0)
			i = i + 1.0
		End While

		da.length = da.length - 1.0

		If DynamicArrayCharactersDecreaseSizeNecessary(da)
			Call DynamicArrayCharactersDecreaseSize(da)
		End If
	End Sub


	Public Sub FreeDynamicArrayCharacters(ByRef da As DynamicArrayCharacters)
		Erase da.arrayx 
		da = Nothing
	End Sub


	Public Function DynamicArrayCharactersToArray(ByRef da As DynamicArrayCharacters) As Char ()
		Dim arrayx As Char ()
		Dim i As Double

		arrayx = New Char (da.length - 1){}

		i = 0.0
		While i < da.length
			arrayx(i) = da.arrayx(i)
			i = i + 1.0
		End While

		Return arrayx
	End Function


	Public Function ArrayToDynamicArrayCharactersWithOptimalSize(ByRef arrayx As Char ()) As DynamicArrayCharacters
		Dim da As DynamicArrayCharacters
		Dim i As Double
		Dim c, n, newCapacity As Double

		c = arrayx.Length
		n = (Log(c) - 1.0)/Log(3.0/2.0)
		newCapacity = Ceiling(10.0*(3.0/2.0) ^ n)

		da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity)

		i = 0.0
		While i < arrayx.Length
			da.arrayx(i) = arrayx(i)
			i = i + 1.0
		End While

		Return da
	End Function


	Public Function ArrayToDynamicArrayCharacters(ByRef arrayx As Char ()) As DynamicArrayCharacters
		Dim da As DynamicArrayCharacters

		da = New DynamicArrayCharacters()
		da.arrayx = arraysCopyString(arrayx)
		da.length = arrayx.Length

		Return da
	End Function


	Public Function DynamicArrayCharactersEqual(ByRef a As DynamicArrayCharacters, ByRef b As DynamicArrayCharacters) As Boolean
		Dim equal As Boolean
		Dim i As Double

		equal = true
		If a.length = b.length
			i = 0.0
			While i < a.length And equal
				If a.arrayx(i) <> b.arrayx(i)
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Function DynamicArrayCharactersToLinkedList(ByRef da As DynamicArrayCharacters) As LinkedListCharacters
		Dim ll As LinkedListCharacters
		Dim i As Double

		ll = CreateLinkedListCharacter()

		i = 0.0
		While i < da.length
			Call LinkedListAddCharacter(ll, da.arrayx(i))
			i = i + 1.0
		End While

		Return ll
	End Function


	Public Function LinkedListToDynamicArrayCharacters(ByRef ll As LinkedListCharacters) As DynamicArrayCharacters
		Dim da As DynamicArrayCharacters
		Dim i As Double
		Dim node As LinkedListNodeCharacters

		node = ll.first

		da = New DynamicArrayCharacters()
		da.length = LinkedListCharactersLength(ll)

		da.arrayx = New Char (da.length - 1){}

		i = 0.0
		While i < da.length
			da.arrayx(i) = node.value
			node = node.nextx
			i = i + 1.0
		End While

		Return da
	End Function


	Public Function AddBoolean(ByRef list As Boolean (), a As Boolean) As Boolean ()
		Dim newlist As Boolean ()
		Dim i As Double

		newlist = New Boolean (list.Length + 1.0 - 1){}
		i = 0.0
		While i < list.Length
			newlist(i) = list(i)
			i = i + 1.0
		End While
		newlist(list.Length) = a
		
		Erase list 
		
		Return newlist
	End Function


	Public Sub AddBooleanRef(ByRef list As BooleanArrayReference, i As Boolean)
		list.booleanArray = AddBoolean(list.booleanArray, i)
	End Sub


	Public Function RemoveBoolean(ByRef list As Boolean (), n As Double) As Boolean ()
		Dim newlist As Boolean ()
		Dim i As Double

		newlist = New Boolean (list.Length - 1.0 - 1){}

		If n >= 0.0 And n < list.Length
			i = 0.0
			While i < list.Length
				If i < n
					newlist(i) = list(i)
				End If
				If i > n
					newlist(i - 1.0) = list(i)
				End If
				i = i + 1.0
			End While

			Erase list 
		Else
			Erase newlist 
		End If
		
		Return newlist
	End Function


	Public Function GetBooleanRef(ByRef list As BooleanArrayReference, i As Double) As Boolean
		Return list.booleanArray(i)
	End Function


	Public Sub RemoveDecimalRef(ByRef list As BooleanArrayReference, i As Double)
		list.booleanArray = RemoveBoolean(list.booleanArray, i)
	End Sub


	Public Function CreateLinkedListString() As LinkedListStrings
		Dim ll As LinkedListStrings

		ll = New LinkedListStrings()
		ll.first = New LinkedListNodeStrings()
		ll.last = ll.first
		ll.last.endx = true

		Return ll
	End Function


	Public Sub LinkedListAddString(ByRef ll As LinkedListStrings, ByRef value As Char ())
		ll.last.endx = false
		ll.last.value = value
		ll.last.nextx = New LinkedListNodeStrings()
		ll.last.nextx.endx = true
		ll.last = ll.last.nextx
	End Sub


	Public Function LinkedListStringsToArray(ByRef ll As LinkedListStrings) As StringReference ()
		Dim arrayx As StringReference ()
		Dim length, i As Double
		Dim node As LinkedListNodeStrings

		node = ll.first

		length = LinkedListStringsLength(ll)

		arrayx = New StringReference (length - 1){}

		i = 0.0
		While i < length
			arrayx(i) = New StringReference()
			arrayx(i).stringx = node.value
			node = node.nextx
			i = i + 1.0
		End While

		Return arrayx
	End Function


	Public Function LinkedListStringsLength(ByRef ll As LinkedListStrings) As Double
		Dim l As Double
		Dim node As LinkedListNodeStrings

		l = 0.0
		node = ll.first
		
		While Not node.endx
			node = node.nextx
			l = l + 1.0
		End While

		Return l
	End Function


	Public Sub FreeLinkedListString(ByRef ll As LinkedListStrings)
		Dim node, prev As LinkedListNodeStrings

		node = ll.first

		
		While Not node.endx
			prev = node
			node = node.nextx
			prev = Nothing
		End While

		node = Nothing
	End Sub


	Public Sub LinkedListInsertString(ByRef ll As LinkedListStrings, index As Double, ByRef value As Char ())
		Dim i As Double
		Dim node, tmp As LinkedListNodeStrings

		If index = 0.0
			tmp = ll.first
			ll.first = New LinkedListNodeStrings()
			ll.first.nextx = tmp
			ll.first.value = value
			ll.first.endx = false
		Else
			node = ll.first
			i = 0.0
			While i < index - 1.0
				node = node.nextx
				i = i + 1.0
			End While

			tmp = node.nextx
			node.nextx = New LinkedListNodeStrings()
			node.nextx.nextx = tmp
			node.nextx.value = value
			node.nextx.endx = false
		End If
	End Sub


	Public Function CreateLinkedListNumbers() As LinkedListNumbers
		Dim ll As LinkedListNumbers

		ll = New LinkedListNumbers()
		ll.first = New LinkedListNodeNumbers()
		ll.last = ll.first
		ll.last.endx = true

		Return ll
	End Function


	Public Function CreateLinkedListNumbersArray(length As Double) As LinkedListNumbers ()
		Dim lls As LinkedListNumbers ()
		Dim i As Double

		lls = New LinkedListNumbers (length - 1){}
		i = 0.0
		While i < lls.Length
			lls(i) = CreateLinkedListNumbers()
			i = i + 1.0
		End While

		Return lls
	End Function


	Public Sub LinkedListAddNumber(ByRef ll As LinkedListNumbers, value As Double)
		ll.last.endx = false
		ll.last.value = value
		ll.last.nextx = New LinkedListNodeNumbers()
		ll.last.nextx.endx = true
		ll.last = ll.last.nextx
	End Sub


	Public Function LinkedListNumbersLength(ByRef ll As LinkedListNumbers) As Double
		Dim l As Double
		Dim node As LinkedListNodeNumbers

		l = 0.0
		node = ll.first
		
		While Not node.endx
			node = node.nextx
			l = l + 1.0
		End While

		Return l
	End Function


	Public Function LinkedListNumbersIndex(ByRef ll As LinkedListNumbers, index As Double) As Double
		Dim i As Double
		Dim node As LinkedListNodeNumbers

		node = ll.first
		i = 0.0
		While i < index
			node = node.nextx
			i = i + 1.0
		End While

		Return node.value
	End Function


	Public Sub LinkedListInsertNumber(ByRef ll As LinkedListNumbers, index As Double, value As Double)
		Dim i As Double
		Dim node, tmp As LinkedListNodeNumbers

		If index = 0.0
			tmp = ll.first
			ll.first = New LinkedListNodeNumbers()
			ll.first.nextx = tmp
			ll.first.value = value
			ll.first.endx = false
		Else
			node = ll.first
			i = 0.0
			While i < index - 1.0
				node = node.nextx
				i = i + 1.0
			End While

			tmp = node.nextx
			node.nextx = New LinkedListNodeNumbers()
			node.nextx.nextx = tmp
			node.nextx.value = value
			node.nextx.endx = false
		End If
	End Sub


	Public Sub LinkedListSet(ByRef ll As LinkedListNumbers, index As Double, value As Double)
		Dim i As Double
		Dim node As LinkedListNodeNumbers

		node = ll.first
		i = 0.0
		While i < index
			node = node.nextx
			i = i + 1.0
		End While

		node.nextx.value = value
	End Sub


	Public Sub LinkedListRemoveNumber(ByRef ll As LinkedListNumbers, index As Double)
		Dim i As Double
		Dim node, prev As LinkedListNodeNumbers

		node = ll.first
		prev = ll.first

		i = 0.0
		While i < index
			prev = node
			node = node.nextx
			i = i + 1.0
		End While

		If index = 0.0
			ll.first = prev.nextx
		End If
		If Not prev.nextx.endx
			prev.nextx = prev.nextx.nextx
		End If
	End Sub


	Public Sub FreeLinkedListNumbers(ByRef ll As LinkedListNumbers)
		Dim node, prev As LinkedListNodeNumbers

		node = ll.first

		
		While Not node.endx
			prev = node
			node = node.nextx
			prev = Nothing
		End While

		node = Nothing
	End Sub


	Public Sub FreeLinkedListNumbersArray(ByRef lls As LinkedListNumbers ())
		Dim i As Double

		i = 0.0
		While i < lls.Length
			Call FreeLinkedListNumbers(lls(i))
			i = i + 1.0
		End While
		Erase lls 
	End Sub


	Public Function LinkedListNumbersToArray(ByRef ll As LinkedListNumbers) As Double ()
		Dim arrayx As Double ()
		Dim length, i As Double
		Dim node As LinkedListNodeNumbers

		node = ll.first

		length = LinkedListNumbersLength(ll)

		arrayx = New Double (length - 1){}

		i = 0.0
		While i < length
			arrayx(i) = node.value
			node = node.nextx
			i = i + 1.0
		End While

		Return arrayx
	End Function


	Public Function ArrayToLinkedListNumbers(ByRef arrayx As Double ()) As LinkedListNumbers
		Dim ll As LinkedListNumbers
		Dim i As Double

		ll = CreateLinkedListNumbers()

		i = 0.0
		While i < arrayx.Length
			Call LinkedListAddNumber(ll, arrayx(i))
			i = i + 1.0
		End While

		Return ll
	End Function


	Public Function LinkedListNumbersEqual(ByRef a As LinkedListNumbers, ByRef b As LinkedListNumbers) As Boolean
		Dim equal, done As Boolean
		Dim an, bn As LinkedListNodeNumbers

		an = a.first
		bn = b.first

		equal = true
		done = false
		
		While equal And Not done
			If an.endx = bn.endx
				If an.endx
					done = true
				ElseIf an.value = bn.value
					an = an.nextx
					bn = bn.nextx
				Else
					equal = false
				End If
			Else
				equal = false
			End If
		End While

		Return equal
	End Function


	Public Function CreateLinkedListCharacter() As LinkedListCharacters
		Dim ll As LinkedListCharacters

		ll = New LinkedListCharacters()
		ll.first = New LinkedListNodeCharacters()
		ll.last = ll.first
		ll.last.endx = true

		Return ll
	End Function


	Public Sub LinkedListAddCharacter(ByRef ll As LinkedListCharacters, value As Char)
		ll.last.endx = false
		ll.last.value = value
		ll.last.nextx = New LinkedListNodeCharacters()
		ll.last.nextx.endx = true
		ll.last = ll.last.nextx
	End Sub


	Public Function LinkedListCharactersToArray(ByRef ll As LinkedListCharacters) As Char ()
		Dim arrayx As Char ()
		Dim length, i As Double
		Dim node As LinkedListNodeCharacters

		node = ll.first

		length = LinkedListCharactersLength(ll)

		arrayx = New Char (length - 1){}

		i = 0.0
		While i < length
			arrayx(i) = node.value
			node = node.nextx
			i = i + 1.0
		End While

		Return arrayx
	End Function


	Public Function LinkedListCharactersLength(ByRef ll As LinkedListCharacters) As Double
		Dim l As Double
		Dim node As LinkedListNodeCharacters

		l = 0.0
		node = ll.first
		
		While Not node.endx
			node = node.nextx
			l = l + 1.0
		End While

		Return l
	End Function


	Public Sub FreeLinkedListCharacter(ByRef ll As LinkedListCharacters)
		Dim node, prev As LinkedListNodeCharacters

		node = ll.first

		
		While Not node.endx
			prev = node
			node = node.nextx
			prev = Nothing
		End While

		node = Nothing
	End Sub


	Public Sub LinkedListCharactersAddString(ByRef ll As LinkedListCharacters, ByRef str As Char ())
		Dim i As Double

		i = 0.0
		While i < str.Length
			Call LinkedListAddCharacter(ll, str(i))
			i = i + 1.0
		End While
	End Sub


	Public Sub LinkedListInsertCharacter(ByRef ll As LinkedListCharacters, index As Double, value As Char)
		Dim i As Double
		Dim node, tmp As LinkedListNodeCharacters

		If index = 0.0
			tmp = ll.first
			ll.first = New LinkedListNodeCharacters()
			ll.first.nextx = tmp
			ll.first.value = value
			ll.first.endx = false
		Else
			node = ll.first
			i = 0.0
			While i < index - 1.0
				node = node.nextx
				i = i + 1.0
			End While

			tmp = node.nextx
			node.nextx = New LinkedListNodeCharacters()
			node.nextx.nextx = tmp
			node.nextx.value = value
			node.nextx.endx = false
		End If
	End Sub


	Public Function CreateDynamicArrayNumbers() As DynamicArrayNumbers
		Dim da As DynamicArrayNumbers

		da = New DynamicArrayNumbers()
		da.arrayx = New Double (10 - 1){}
		da.length = 0.0

		Return da
	End Function


	Public Function CreateDynamicArrayNumbersWithInitialCapacity(capacity As Double) As DynamicArrayNumbers
		Dim da As DynamicArrayNumbers

		da = New DynamicArrayNumbers()
		da.arrayx = New Double (capacity - 1){}
		da.length = 0.0

		Return da
	End Function


	Public Sub DynamicArrayAddNumber(ByRef da As DynamicArrayNumbers, value As Double)
		If da.length = da.arrayx.Length
			Call DynamicArrayNumbersIncreaseSize(da)
		End If

		da.arrayx(da.length) = value
		da.length = da.length + 1.0
	End Sub


	Public Sub DynamicArrayNumbersIncreaseSize(ByRef da As DynamicArrayNumbers)
		Dim newLength, i As Double
		Dim newArray As Double ()

		newLength = Round(da.arrayx.Length*3.0/2.0)
		newArray = New Double (newLength - 1){}

		i = 0.0
		While i < da.arrayx.Length
			newArray(i) = da.arrayx(i)
			i = i + 1.0
		End While

		Erase da.arrayx 

		da.arrayx = newArray
	End Sub


	Public Function DynamicArrayNumbersDecreaseSizeNecessary(ByRef da As DynamicArrayNumbers) As Boolean
		Dim needsDecrease As Boolean

		needsDecrease = false

		If da.length > 10.0
			needsDecrease = da.length <= Round(da.arrayx.Length*2.0/3.0)
		End If

		Return needsDecrease
	End Function


	Public Sub DynamicArrayNumbersDecreaseSize(ByRef da As DynamicArrayNumbers)
		Dim newLength, i As Double
		Dim newArray As Double ()

		newLength = Round(da.arrayx.Length*2.0/3.0)
		newArray = New Double (newLength - 1){}

		i = 0.0
		While i < newLength
			newArray(i) = da.arrayx(i)
			i = i + 1.0
		End While

		Erase da.arrayx 

		da.arrayx = newArray
	End Sub


	Public Function DynamicArrayNumbersIndex(ByRef da As DynamicArrayNumbers, index As Double) As Double
		Return da.arrayx(index)
	End Function


	Public Function DynamicArrayNumbersLength(ByRef da As DynamicArrayNumbers) As Double
		Return da.length
	End Function


	Public Sub DynamicArrayInsertNumber(ByRef da As DynamicArrayNumbers, index As Double, value As Double)
		Dim i As Double

		If da.length = da.arrayx.Length
			Call DynamicArrayNumbersIncreaseSize(da)
		End If

		i = da.length
		While i > index
			da.arrayx(i) = da.arrayx(i - 1.0)
			i = i - 1.0
		End While

		da.arrayx(index) = value

		da.length = da.length + 1.0
	End Sub


	Public Function DynamicArrayNumberSet(ByRef da As DynamicArrayNumbers, index As Double, value As Double) As Boolean
		Dim success As Boolean

		If index < da.length
			da.arrayx(index) = value
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Sub DynamicArrayRemoveNumber(ByRef da As DynamicArrayNumbers, index As Double)
		Dim i As Double

		i = index
		While i < da.length - 1.0
			da.arrayx(i) = da.arrayx(i + 1.0)
			i = i + 1.0
		End While

		da.length = da.length - 1.0

		If DynamicArrayNumbersDecreaseSizeNecessary(da)
			Call DynamicArrayNumbersDecreaseSize(da)
		End If
	End Sub


	Public Sub FreeDynamicArrayNumbers(ByRef da As DynamicArrayNumbers)
		Erase da.arrayx 
		da = Nothing
	End Sub


	Public Function DynamicArrayNumbersToArray(ByRef da As DynamicArrayNumbers) As Double ()
		Dim arrayx As Double ()
		Dim i As Double

		arrayx = New Double (da.length - 1){}

		i = 0.0
		While i < da.length
			arrayx(i) = da.arrayx(i)
			i = i + 1.0
		End While

		Return arrayx
	End Function


	Public Function ArrayToDynamicArrayNumbersWithOptimalSize(ByRef arrayx As Double ()) As DynamicArrayNumbers
		Dim da As DynamicArrayNumbers
		Dim i As Double
		Dim c, n, newCapacity As Double

		'
		'         c = 10*(3/2)^n
		'         log(c) = log(10*(3/2)^n)
		'         log(c) = log(10) + log((3/2)^n)
		'         log(c) = 1 + log((3/2)^n)
		'         log(c) - 1 = log((3/2)^n)
		'         log(c) - 1 = n*log(3/2)
		'         n = (log(c) - 1)/log(3/2)
		'        
		c = arrayx.Length
		n = (Log(c) - 1.0)/Log(3.0/2.0)
		newCapacity = Ceiling(10.0*(3.0/2.0) ^ n)

		da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity)

		i = 0.0
		While i < arrayx.Length
			da.arrayx(i) = arrayx(i)
			i = i + 1.0
		End While

		Return da
	End Function


	Public Function ArrayToDynamicArrayNumbers(ByRef arrayx As Double ()) As DynamicArrayNumbers
		Dim da As DynamicArrayNumbers

		da = New DynamicArrayNumbers()
		da.arrayx = arraysCopyNumberArray(arrayx)
		da.length = arrayx.Length

		Return da
	End Function


	Public Function DynamicArrayNumbersEqual(ByRef a As DynamicArrayNumbers, ByRef b As DynamicArrayNumbers) As Boolean
		Dim equal As Boolean
		Dim i As Double

		equal = true
		If a.length = b.length
			i = 0.0
			While i < a.length And equal
				If a.arrayx(i) <> b.arrayx(i)
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Function DynamicArrayNumbersToLinkedList(ByRef da As DynamicArrayNumbers) As LinkedListNumbers
		Dim ll As LinkedListNumbers
		Dim i As Double

		ll = CreateLinkedListNumbers()

		i = 0.0
		While i < da.length
			Call LinkedListAddNumber(ll, da.arrayx(i))
			i = i + 1.0
		End While

		Return ll
	End Function


	Public Function LinkedListToDynamicArrayNumbers(ByRef ll As LinkedListNumbers) As DynamicArrayNumbers
		Dim da As DynamicArrayNumbers
		Dim i As Double
		Dim node As LinkedListNodeNumbers

		node = ll.first

		da = New DynamicArrayNumbers()
		da.length = LinkedListNumbersLength(ll)

		da.arrayx = New Double (da.length - 1){}

		i = 0.0
		While i < da.length
			da.arrayx(i) = node.value
			node = node.nextx
			i = i + 1.0
		End While

		Return da
	End Function


	Public Function DynamicArrayNumbersIndexOf(ByRef arr As DynamicArrayNumbers, n As Double, ByRef foundReference As BooleanReference) As Double
		Dim found As Boolean
		Dim i As Double

		found = false
		i = 0.0
		While i < arr.length And Not found
			If arr.arrayx(i) = n
				found = true
			End If
			i = i + 1.0
		End While
		If Not found
			i = -1.0
		Else
			i = i - 1.0
		End If

		foundReference.booleanValue = found

		Return i
	End Function


	Public Function DynamicArrayNumbersIsInArray(ByRef arr As DynamicArrayNumbers, n As Double) As Boolean
		Dim found As Boolean
		Dim i As Double

		found = false
		i = 0.0
		While i < arr.length And Not found
			If arr.arrayx(i) = n
				found = true
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function AddCharacter(ByRef list As Char (), a As Char) As Char ()
		Dim newlist As Char ()
		Dim i As Double

		newlist = New Char (list.Length + 1.0 - 1){}
		i = 0.0
		While i < list.Length
			newlist(i) = list(i)
			i = i + 1.0
		End While
		newlist(list.Length) = a
		
		Erase list 
		
		Return newlist
	End Function


	Public Sub AddCharacterRef(ByRef list As StringReference, i As Char)
		list.stringx = AddCharacter(list.stringx, i)
	End Sub


	Public Function RemoveCharacter(ByRef list As Char (), n As Double) As Char ()
		Dim newlist As Char ()
		Dim i As Double

		newlist = New Char (list.Length - 1.0 - 1){}

		If n >= 0.0 And n < list.Length
			i = 0.0
			While i < list.Length
				If i < n
					newlist(i) = list(i)
				End If
				If i > n
					newlist(i - 1.0) = list(i)
				End If
				i = i + 1.0
			End While

			Erase list 
		Else
			Erase newlist 
		End If

		Return newlist
	End Function


	Public Function GetCharacterRef(ByRef list As StringReference, i As Double) As Char
		Return list.stringx(i)
	End Function


	Public Sub RemoveCharacterRef(ByRef list As StringReference, i As Double)
		list.stringx = RemoveCharacter(list.stringx, i)
	End Sub


	Public Function GetAccrualAmount(total As Double, fromYear As Double, fromMonth As Double, fromDay As Double, toYear As Double, toMonth As Double, toDay As Double, yearOfInterest As Double, monthOfInterest As Double) As Double
		Dim from, tox As Datex
		Dim amount As Double

		from = CreateDate(fromYear, fromMonth, fromDay)
		tox = CreateDate(toYear, toMonth, toDay)

		amount = GetAccrualAmountWithDates(total, from, tox, yearOfInterest, monthOfInterest)

		Return amount
	End Function


	Public Function GetAccruals(total As Double, fromYear As Double, fromMonth As Double, fromDay As Double, toYear As Double, toMonth As Double, toDay As Double) As Double ()
		Dim from, tox As Datex
		Dim amounts As Double ()

		from = CreateDate(fromYear, fromMonth, fromDay)
		tox = CreateDate(toYear, toMonth, toDay)

		amounts = GetAccrualsWithDates(total, from, tox)

		Return amounts
	End Function


	Public Function GetAccrualsWithDates(total As Double, ByRef from As Datex, ByRef tox As Datex) As Double ()
		Dim entry As Double
		Dim done As Boolean
		Dim dateOfInterest As Datex
		Dim list As LinkedListNumbers
		Dim result As Double ()

		list = CreateLinkedListNumbers()

		done = false
		dateOfInterest = New Datex()
		Call AssignDate(dateOfInterest, from)
		
		While Not done
			If dateOfInterest.year = tox.year And dateOfInterest.month = tox.month
				done = true
			End If

			entry = GetAccrualAmountWithDates(total, from, tox, dateOfInterest.year, dateOfInterest.month)
			Call LinkedListAddNumber(list, entry)
			Call AddMonthsToDate(dateOfInterest, 1.0)
		End While

		result = LinkedListNumbersToArray(list)
		Call FreeLinkedListNumbers(list)

		Return result
	End Function


	Public Function GetAccrualAmountWithDates(total As Double, ByRef from As Datex, ByRef tox As Datex, yearOfInterest As Double, monthOfInterest As Double) As Double
		Dim unadjustedAmount, adjustment, days, daysToAdjust, n As Double
		Dim adjustTo As Datex
		Dim valuePerDay, divisibleRemaining, divisibleTotal, amount As FixedPoint15d
		Dim message As StringReference

		message = New StringReference()

		valuePerDay = CreateFixedPoint15d(13.0, 2.0)
		divisibleRemaining = CreateFixedPoint15d(13.0, 2.0)
		divisibleTotal = CreateFixedPoint15d(13.0, 2.0)
		amount = CreateFixedPoint15d(13.0, 2.0)

		days = DaysBetweenDates(from, tox) + 1.0

		' DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining
		DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days))

		Multiply15d(divisibleTotal, valuePerDay, Number15d(days))
		unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, from, tox, yearOfInterest, monthOfInterest)

		If Not Equals15d(divisibleRemaining, Number15d(0.0))
			daysToAdjust = Roundx(ToNumber15d(divisibleRemaining)*100.0)
			adjustTo = New Datex()
			Call AssignDate(adjustTo, from)
			AddDaysToDate(adjustTo, daysToAdjust - 1.0, message)

			adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest)

			adjustTo = Nothing
		Else
			adjustment = 0.0
		End If

		Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment))

		n = ToNumber15d(amount)

		valuePerDay = Nothing
		divisibleRemaining = Nothing
		divisibleTotal = Nothing
		amount = Nothing

		Return n
	End Function


	Public Function GetUnadjustedAccrualAmountWithDates(ByRef total As FixedPoint15d, ByRef from As Datex, ByRef tox As Datex, yearOfInterest As Double, monthOfInterest As Double) As Double
		Dim days, daysInMonthOfInterest, n As Double
		Dim lastDayInMonth, firstDateInMonth As Datex
		Dim daysInMonth As Double ()
		Dim valuePerDay, value, remainder As FixedPoint15d
		Dim success As Boolean

		value = CreateFixedPoint15d(13.0, 2.0)
		valuePerDay = CreateFixedPoint15d(13.0, 2.0)
		remainder = CreateFixedPoint15d(13.0, 2.0)

		days = DaysBetweenDates(from, tox) + 1.0
		' DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...
		success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days))

		If success
			daysInMonth = GetDaysInMonth(yearOfInterest)

			If yearOfInterest < from.year
				Assign15d(value, 0.0)
			ElseIf yearOfInterest = from.year And monthOfInterest < from.month
				Assign15d(value, 0.0)
			ElseIf yearOfInterest > tox.year
				Assign15d(value, 0.0)
			ElseIf yearOfInterest = tox.year And monthOfInterest > tox.month
				Assign15d(value, 0.0)
			Else
				If from.year = yearOfInterest And from.month = monthOfInterest And tox.year = yearOfInterest And tox.month = monthOfInterest
					daysInMonthOfInterest = days
				ElseIf from.year = yearOfInterest And from.month = monthOfInterest
					lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth(monthOfInterest))
					daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1.0
				ElseIf tox.year = yearOfInterest And tox.month = monthOfInterest
					firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0)
					daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, tox) + 1.0
				Else
					daysInMonthOfInterest = daysInMonth(monthOfInterest)
				End If

				' MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value
				Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest))
			End If

			Erase daysInMonth 
		End If

		n = ToNumber15d(value)

		value = Nothing
		valuePerDay = Nothing
		remainder = Nothing

		Return n
	End Function


	Public Function CreateNewArrayData() As Data
		Dim data As Data

		data = New Data()
		data.isArray = true
		data.isStruture = false
		data.isNumber = false
		data.isBoolean = false
		data.isString = false
		data.arrayx = CreateArray()

		Return data
	End Function


	Public Function CreateNewStructData() As Data
		Dim data As Data

		data = New Data()
		data.isStruture = true
		data.isArray = false
		data.isNumber = false
		data.isBoolean = false
		data.isString = false
		data.structurex = CreateStructure()

		Return data
	End Function


	Public Function CreateStructure() As Structurex
		Dim st As Structurex

		st = New Structurex()
		st.keys = CreateArray()
		st.values = CreateArray()

		Return st
	End Function


	Public Function CreateNumberData(n As Double) As Data
		Dim data As Data

		data = New Data()
		data.isNumber = true
		data.isStruture = false
		data.isArray = false
		data.isBoolean = false
		data.isString = false
		data.number = n

		Return data
	End Function


	Public Function CreateBooleanData(b As Boolean) As Data
		Dim data As Data

		data = New Data()
		data.isBoolean = true
		data.isStruture = false
		data.isArray = false
		data.isNumber = false
		data.isString = false
		data.booleanxx = b

		Return data
	End Function


	Public Function CreateStringData(ByRef stringx As Char ()) As Data
		Dim data As Data

		data = New Data()
		data.isString = true
		data.isStruture = false
		data.isArray = false
		data.isNumber = false
		data.isBoolean = false
		data.stringx = stringx

		Return data
	End Function


	Public Function CreateStructData(ByRef structurex As Structurex) As Data
		Dim data As Data

		data = New Data()
		data.isString = false
		data.isStruture = true
		data.isArray = false
		data.isNumber = false
		data.isBoolean = false
		data.structurex = structurex

		Return data
	End Function


	Public Function CreateArrayData(ByRef arrayx As Arrayx) As Data
		Dim data As Data

		data = New Data()
		data.isString = false
		data.isStruture = false
		data.isArray = true
		data.isNumber = false
		data.isBoolean = false
		data.arrayx = arrayx

		Return data
	End Function


	Public Function CreateNoTypeData() As Data
		Dim data As Data

		data = New Data()
		data.isStruture = false
		data.isArray = false
		data.isNumber = false
		data.isBoolean = false
		data.isString = false

		Return data
	End Function


	Public Sub AddStructToArray(ByRef ar As Arrayx, ByRef st As Structurex)
		Dim data As Data

		data = CreateNewStructData()
		data.structurex = Nothing
		data.structurex = st

		Call ArrayAdd(ar, data)
	End Sub


	Public Sub AddArrayToArray(ByRef ar As Arrayx, ByRef ar2 As Arrayx)
		Dim data As Data

		data = CreateNewArrayData()
		data.arrayx = Nothing
		data.arrayx = ar2

		Call ArrayAdd(ar, data)
	End Sub


	Public Sub AddNumberToArray(ByRef ar As Arrayx, n As Double)
		Call ArrayAdd(ar, CreateNumberData(n))
	End Sub


	Public Sub AddBooleanToArray(ByRef ar As Arrayx, b As Boolean)
		Call ArrayAdd(ar, CreateBooleanData(b))
	End Sub


	Public Sub AddStringToArray(ByRef ar As Arrayx, ByRef str As Char ())
		Call ArrayAdd(ar, CreateStringData(str))
	End Sub


	Public Sub AddDataToArray(ByRef ar As Arrayx, ByRef data As Data)
		Call ArrayAdd(ar, data)
	End Sub


	Public Function StructKeys(ByRef st As Structurex) As Double
		Return ArrayLength(st.keys)
	End Function


	Public Function StructHasKey(ByRef st As Structurex, ByRef key As Char ()) As Boolean
		Dim i As Double
		Dim hasKey As Boolean

		hasKey = false
		i = 0.0
		While i < StructKeys(st)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				hasKey = true
			End If
			i = i + 1.0
		End While

		Return hasKey
	End Function


	Public Function StructKeyIndex(ByRef st As Structurex, ByRef key As Char ()) As Double
		Dim i As Double
		Dim index As Double

		index = -1.0
		i = 0.0
		While i < StructKeys(st)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				index = i
			End If
			i = i + 1.0
		End While

		Return index
	End Function


	Public Function GetStructKeys(ByRef st As Structurex) As StringReference ()
		Dim keys As StringReference ()
		Dim nr, i As Double

		nr = StructKeys(st)

		keys = New StringReference (nr - 1){}

		i = 0.0
		While i < nr
			keys(i) = New StringReference()
			keys(i).stringx = arraysCopyString(st.keys.arrayx(i).stringx)
			i = i + 1.0
		End While

		Return keys
	End Function


	Public Function GetStructFromStruct(ByRef st As Structurex, ByRef key As Char ()) As Structurex
		Dim i As Double
		Dim r As Structurex

		r = New Structurex()
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = st.values.arrayx(i).structurex
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function GetArrayFromStruct(ByRef st As Structurex, ByRef key As Char ()) As Arrayx
		Dim i As Double
		Dim r As Arrayx

		r = New Arrayx()
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = st.values.arrayx(i).arrayx
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function GetNumberFromStruct(ByRef st As Structurex, ByRef key As Char ()) As Double
		Dim i, r As Double

		r = 0.0
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = st.values.arrayx(i).number
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function GetBooleanFromStruct(ByRef st As Structurex, ByRef key As Char ()) As Boolean
		Dim i As Double
		Dim r As Boolean

		r = false
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = st.values.arrayx(i).booleanxx
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function GetStringFromStruct(ByRef st As Structurex, ByRef key As Char ()) As Char ()
		Dim i As Double
		Dim r As Char ()

		r = "".ToCharArray()
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = st.values.arrayx(i).stringx
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function GetDataFromStruct(ByRef st As Structurex, ByRef key As Char ()) As Data
		Dim i As Double
		Dim r As Data

		r = New Data()
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = Nothing
				r = st.values.arrayx(i)
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function GetDataFromStructWithCheck(ByRef st As Structurex, ByRef key As Char (), ByRef foundRef As BooleanReference) As Data
		Dim i As Double
		Dim r As Data

		r = New Data()
		foundRef.booleanValue = false
		i = 0.0
		While i < ArrayLength(st.keys)
			If arraysStringsEqual(st.keys.arrayx(i).stringx, key)
				r = Nothing
				foundRef.booleanValue = true
				r = st.values.arrayx(i)
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Sub AddStructToStruct(ByRef st As Structurex, ByRef key As Char (), ByRef struct As Structurex)
		Dim i As Double

		If StructHasKey(st, key)
			i = StructKeyIndex(st, key)
			st.values.arrayx(i).structurex = Nothing
			st.values.arrayx(i).structurex = struct
		Else
			Call AddStringToArray(st.keys, key)
			Call AddStructToArray(st.values, struct)
		End If
	End Sub


	Public Sub AddArrayToStruct(ByRef st As Structurex, ByRef key As Char (), ByRef ar As Arrayx)
		Dim i As Double

		If StructHasKey(st, key)
			i = StructKeyIndex(st, key)
			st.values.arrayx(i).arrayx = Nothing
			st.values.arrayx(i).arrayx = ar
		Else
			Call AddStringToArray(st.keys, key)
			Call AddArrayToArray(st.values, ar)
		End If
	End Sub


	Public Sub AddNumberToStruct(ByRef st As Structurex, ByRef key As Char (), n As Double)
		Dim i As Double

		If StructHasKey(st, key)
			i = StructKeyIndex(st, key)
			st.values.arrayx(i).number = n
		Else
			Call AddStringToArray(st.keys, key)
			Call AddNumberToArray(st.values, n)
		End If
	End Sub


	Public Sub AddBooleanToStruct(ByRef st As Structurex, ByRef key As Char (), b As Boolean)
		Dim i As Double

		If StructHasKey(st, key)
			i = StructKeyIndex(st, key)
			st.values.arrayx(i).booleanxx = b
		Else
			Call AddStringToArray(st.keys, key)
			Call AddBooleanToArray(st.values, b)
		End If
	End Sub


	Public Sub AddStringToStruct(ByRef st As Structurex, ByRef key As Char (), ByRef value As Char ())
		Dim i As Double

		If StructHasKey(st, key)
			i = StructKeyIndex(st, key)
			Erase st.values.arrayx(i).stringx 
			st.values.arrayx(i).stringx = value
		Else
			Call AddStringToArray(st.keys, key)
			Call AddStringToArray(st.values, value)
		End If
	End Sub


	Public Sub AddDataToStruct(ByRef st As Structurex, ByRef key As Char (), ByRef data As Data)
		Dim i As Double

		If StructHasKey(st, key)
			i = StructKeyIndex(st, key)
			Call FreeData(st.values.arrayx(i))
			st.values.arrayx(i) = data
		Else
			Call AddStringToArray(st.keys, key)
			Call AddDataToArray(st.values, data)
		End If
	End Sub


	Public Sub FreeData(ByRef data As Data)
		Dim i As Double
		Dim st As Structurex

		If data.isStruture
			st = data.structurex
			i = 0.0
			While i < StructKeys(st)
				Call FreeData(ArrayIndex(st.keys, i))
				Call FreeData(ArrayIndex(st.values, i))
				i = i + 1.0
			End While
			st = Nothing
		ElseIf data.isArray
			Call FreeArray(data.arrayx)
		End If

		data = Nothing
	End Sub


	Public Sub FreeArray(ByRef arrayx As Arrayx)
		Dim i As Double

		i = 0.0
		While i < ArrayLength(arrayx)
			Call FreeData(arrayx.arrayx(i))
			i = i + 1.0
		End While

		Erase arrayx.arrayx 
		arrayx = Nothing
	End Sub


	Public Function DataTypeEquals(ByRef a As Data, ByRef b As Data) As Boolean
		Dim equal As Boolean

		equal = true
		equal = equal And a.isStruture = b.isStruture
		equal = equal And a.isArray = b.isArray
		equal = equal And a.isNumber = b.isNumber
		equal = equal And a.isBoolean = b.isBoolean
		equal = equal And a.isString = b.isString

		Return equal
	End Function


	Public Function IsStructure(ByRef a As Data) As Boolean
		Dim itis As Boolean

		itis = a.isStruture
		If a.isArray Or a.isNumber Or a.isBoolean Or a.isString
			itis = false
		End If

		Return itis
	End Function


	Public Function IsArray(ByRef a As Data) As Boolean
		Dim itis As Boolean

		itis = a.isArray
		If a.isStruture Or a.isNumber Or a.isBoolean Or a.isString
			itis = false
		End If

		Return itis
	End Function


	Public Function IsNumber(ByRef a As Data) As Boolean
		Dim itis As Boolean

		itis = a.isNumber
		If a.isStruture Or a.isArray Or a.isBoolean Or a.isString
			itis = false
		End If

		Return itis
	End Function


	Public Function IsBoolean(ByRef a As Data) As Boolean
		Dim itis As Boolean

		itis = a.isBoolean
		If a.isStruture Or a.isArray Or a.isNumber Or a.isString
			itis = false
		End If

		Return itis
	End Function


	Public Function IsString(ByRef a As Data) As Boolean
		Dim itis As Boolean

		itis = a.isString
		If a.isStruture Or a.isArray Or a.isNumber Or a.isBoolean
			itis = false
		End If

		Return itis
	End Function


	Public Function IsNoType(ByRef a As Data) As Boolean
		Dim itis As Boolean

		If Not a.isString And Not a.isStruture And Not a.isArray And Not a.isNumber And Not a.isBoolean
			itis = true
		Else
			itis = false
		End If

		Return itis
	End Function


	Public Function CreateArray() As Arrayx
		Dim arrayx As Arrayx

		arrayx = New Arrayx()
		arrayx.arrayx = New Data (10 - 1){}
		arrayx.length = 0.0

		Return arrayx
	End Function


	Public Function CreateArrayWithInitialCapacity(capacity As Double) As Arrayx
		Dim arrayx As Arrayx

		arrayx = New Arrayx()
		arrayx.arrayx = New Data (capacity - 1){}
		arrayx.length = 0.0

		Return arrayx
	End Function


	Public Sub ArrayAdd(ByRef arrayx As Arrayx, ByRef value As Data)
		If arrayx.length = arrayx.arrayx.Length
			Call ArrayIncreaseSize(arrayx)
		End If

		arrayx.arrayx(arrayx.length) = value
		arrayx.length = arrayx.length + 1.0
	End Sub


	Public Sub ArrayAddString(ByRef arrayx As Arrayx, ByRef value As Char ())
		Dim data As Data

		data = CreateStringData(value)

		Call ArrayAdd(arrayx, data)
	End Sub


	Public Sub ArrayAddBoolean(ByRef arrayx As Arrayx, value As Boolean)
		Dim data As Data

		data = CreateBooleanData(value)

		Call ArrayAdd(arrayx, data)
	End Sub


	Public Sub ArrayAddNumber(ByRef arrayx As Arrayx, value As Double)
		Dim data As Data

		data = CreateNumberData(value)

		Call ArrayAdd(arrayx, data)
	End Sub


	Public Sub ArrayAddStruct(ByRef arrayx As Arrayx, ByRef value As Structurex)
		Dim data As Data

		data = CreateStructData(value)

		Call ArrayAdd(arrayx, data)
	End Sub


	Public Sub ArrayAddArray(ByRef arrayx As Arrayx, ByRef value As Arrayx)
		Dim data As Data

		data = CreateArrayData(value)

		Call ArrayAdd(arrayx, data)
	End Sub


	Public Sub ArrayIncreaseSize(ByRef arrayx As Arrayx)
		Dim newLength, i As Double
		Dim newArray As Data ()

		newLength = Round(arrayx.arrayx.Length*3.0/2.0)
		newArray = New Data (newLength - 1){}

		i = 0.0
		While i < arrayx.arrayx.Length
			newArray(i) = arrayx.arrayx(i)
			i = i + 1.0
		End While

		Erase arrayx.arrayx 

		arrayx.arrayx = newArray
	End Sub


	Public Function ArrayDecreaseSizeNecessary(ByRef arrayx As Arrayx) As Boolean
		Dim needsDecrease As Boolean

		needsDecrease = false

		If arrayx.length > 10.0
			needsDecrease = arrayx.length <= Round(arrayx.arrayx.Length*2.0/3.0)
		End If

		Return needsDecrease
	End Function


	Public Sub ArrayDecreaseSize(ByRef arrayx As Arrayx)
		Dim newLength, i As Double
		Dim newArray As Data ()

		newLength = Round(arrayx.arrayx.Length*2.0/3.0)
		newArray = New Data (newLength - 1){}

		i = 0.0
		While i < newLength
			newArray(i) = arrayx.arrayx(i)
			i = i + 1.0
		End While

		Erase arrayx.arrayx 

		arrayx.arrayx = newArray
	End Sub


	Public Function ArrayIndex(ByRef arrayx As Arrayx, index As Double) As Data
		Return arrayx.arrayx(index)
	End Function


	Public Function ArrayIndexArray(ByRef arrayx As Arrayx, index As Double) As Arrayx
		Return arrayx.arrayx(index).arrayx
	End Function


	Public Function ArrayIndexStruct(ByRef arrayx As Arrayx, index As Double) As Structurex
		Return arrayx.arrayx(index).structurex
	End Function


	Public Function ArrayIndexBoolean(ByRef arrayx As Arrayx, index As Double) As Boolean
		Return arrayx.arrayx(index).booleanxx
	End Function


	Public Function ArrayIndexString(ByRef arrayx As Arrayx, index As Double) As Char ()
		Return arrayx.arrayx(index).stringx
	End Function


	Public Function ArrayIndexNumber(ByRef arrayx As Arrayx, index As Double) As Double
		Return arrayx.arrayx(index).number
	End Function


	Public Function ArrayLength(ByRef arrayx As Arrayx) As Double
		Return arrayx.length
	End Function


	Public Sub ArrayInsert(ByRef arrayx As Arrayx, index As Double, ByRef value As Data)
		Dim i As Double

		If arrayx.length = arrayx.arrayx.Length
			Call ArrayIncreaseSize(arrayx)
		End If

		i = arrayx.length
		While i > index
			arrayx.arrayx(i) = arrayx.arrayx(i - 1.0)
			i = i - 1.0
		End While

		arrayx.arrayx(index) = value

		arrayx.length = arrayx.length + 1.0
	End Sub


	Public Sub ArrayInsertString(ByRef arrayx As Arrayx, index As Double, ByRef value As Char ())
		Dim data As Data

		data = CreateStringData(value)

		Call ArrayInsert(arrayx, index, data)
	End Sub


	Public Sub ArrayInsertBoolean(ByRef arrayx As Arrayx, index As Double, value As Boolean)
		Dim data As Data

		data = CreateBooleanData(value)

		Call ArrayInsert(arrayx, index, data)
	End Sub


	Public Sub ArrayInsertNumber(ByRef arrayx As Arrayx, index As Double, value As Double)
		Dim data As Data

		data = CreateNumberData(value)

		Call ArrayInsert(arrayx, index, data)
	End Sub


	Public Sub ArrayInsertStruct(ByRef arrayx As Arrayx, index As Double, ByRef value As Structurex)
		Dim data As Data

		data = CreateStructData(value)

		Call ArrayInsert(arrayx, index, data)
	End Sub


	Public Sub ArrayInsertArray(ByRef arrayx As Arrayx, index As Double, ByRef value As Arrayx)
		Dim data As Data

		data = CreateArrayData(value)

		Call ArrayInsert(arrayx, index, data)
	End Sub


	Public Function ArraySet(ByRef arrayx As Arrayx, index As Double, ByRef value As Data) As Boolean
		Dim success As Boolean

		If index < arrayx.length
			arrayx.arrayx(index) = value
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Sub ArraySetString(ByRef arrayx As Arrayx, index As Double, ByRef value As Char ())
		Dim data As Data

		data = CreateStringData(value)

		ArraySet(arrayx, index, data)
	End Sub


	Public Sub ArraySetBoolean(ByRef arrayx As Arrayx, index As Double, value As Boolean)
		Dim data As Data

		data = CreateBooleanData(value)

		ArraySet(arrayx, index, data)
	End Sub


	Public Sub ArraySetNumber(ByRef arrayx As Arrayx, index As Double, value As Double)
		Dim data As Data

		data = CreateNumberData(value)

		ArraySet(arrayx, index, data)
	End Sub


	Public Sub ArraySetStruct(ByRef arrayx As Arrayx, index As Double, ByRef value As Structurex)
		Dim data As Data

		data = CreateStructData(value)

		ArraySet(arrayx, index, data)
	End Sub


	Public Sub ArraySetArray(ByRef arrayx As Arrayx, index As Double, ByRef value As Arrayx)
		Dim data As Data

		data = CreateArrayData(value)

		ArraySet(arrayx, index, data)
	End Sub


	Public Sub ArrayRemove(ByRef arrayx As Arrayx, index As Double)
		Dim i As Double

		i = index
		While i < arrayx.length - 1.0
			arrayx.arrayx(i) = arrayx.arrayx(i + 1.0)
			i = i + 1.0
		End While

		arrayx.length = arrayx.length - 1.0

		If ArrayDecreaseSizeNecessary(arrayx)
			Call ArrayDecreaseSize(arrayx)
		End If
	End Sub


	Public Function ToStaticArray(ByRef arc As Arrayx) As Data ()
		Dim arrayx As Data ()
		Dim i As Double

		arrayx = New Data (arc.length - 1){}

		i = 0.0
		While i < arc.length
			arrayx(i) = arc.arrayx(i)
			i = i + 1.0
		End While

		Return arrayx
	End Function


	Public Function ToStaticNumberArray(ByRef arrayx As Arrayx) As Double ()
		Dim result As Double ()
		Dim i, n As Double

		n = ArrayLength(arrayx)

		result = New Double (n - 1){}

		i = 0.0
		While i < n
			result(i) = ArrayIndex(arrayx, i).number
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ToStaticBooleanArray(ByRef arrayx As Arrayx) As Boolean ()
		Dim result As Boolean ()
		Dim i, n As Double

		n = ArrayLength(arrayx)

		result = New Boolean (n - 1){}

		i = 0.0
		While i < n
			result(i) = ArrayIndex(arrayx, i).booleanxx
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ToStaticStringArray(ByRef arrayx As Arrayx) As StringReference ()
		Dim result As StringReference ()
		Dim i, n As Double

		n = ArrayLength(arrayx)

		result = New StringReference (n - 1){}

		i = 0.0
		While i < n
			result(i) = New StringReference()
			result(i).stringx = ArrayIndex(arrayx, i).stringx
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ToStaticArrayArray(ByRef arrayx As Arrayx) As Arrayx ()
		Dim result As Arrayx ()
		Dim i, n As Double

		n = ArrayLength(arrayx)

		result = New Arrayx (n - 1){}

		i = 0.0
		While i < n
			result(i) = ArrayIndex(arrayx, i).arrayx
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ToStaticStructArray(ByRef arrayx As Arrayx) As Structurex ()
		Dim result As Structurex ()
		Dim i, n As Double

		n = ArrayLength(arrayx)

		result = New Structurex (n - 1){}

		i = 0.0
		While i < n
			result(i) = ArrayIndex(arrayx, i).structurex
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function StaticArrayToArrayWithOptimalSize(ByRef src As Data ()) As Arrayx
		Dim dst As Arrayx
		Dim i As Double
		Dim c, n, newCapacity As Double

		'
		'         c = 10*(3/2)^n
		'         log(c) = log(10*(3/2)^n)
		'         log(c) = log(10) + log((3/2)^n)
		'         log(c) = 1 + log((3/2)^n)
		'         log(c) - 1 = log((3/2)^n)
		'         log(c) - 1 = n*log(3/2)
		'         n = (log(c) - 1)/log(3/2)
		'        

		c = src.Length
		n = (Log(c) - 1.0)/Log(3.0/2.0)

		newCapacity = Ceiling(10.0*(3.0/2.0) ^ Ceiling(n))

		dst = CreateArrayWithInitialCapacity(newCapacity)

		i = 0.0
		While i < src.Length
			dst.arrayx(i) = src(i)
			i = i + 1.0
		End While

		Return dst
	End Function


	Public Function StaticArrayToArray(ByRef src As Data ()) As Arrayx
		Dim i As Double
		Dim dst As Arrayx

		dst = CreateArrayWithInitialCapacity(src.Length)
		i = 0.0
		While i < src.Length
			dst.arrayx(i) = src(i)
			i = i + 1.0
		End While
		dst.length = src.Length

		Return dst
	End Function


	Public Function arraysStringToNumberArray(ByRef stringx As Char ()) As Double ()
		Dim i As Double
		Dim arrayx As Double ()

		arrayx = New Double (stringx.Length - 1){}

		i = 0.0
		While i < stringx.Length
			arrayx(i) = Convert.ToInt16(stringx(i))
			i = i + 1.0
		End While
		Return arrayx
	End Function


	Public Function arraysNumberArrayToString(ByRef arrayx As Double ()) As Char ()
		Dim i As Double
		Dim stringx As Char ()

		stringx = New Char (arrayx.Length - 1){}

		i = 0.0
		While i < arrayx.Length
			stringx(i) = Convert.ToChar(Convert.ToInt64(arrayx(i)))
			i = i + 1.0
		End While
		Return stringx
	End Function


	Public Function arraysNumberArraysEqual(ByRef a As Double (), ByRef b As Double ()) As Boolean
		Dim equal As Boolean
		Dim i As Double

		equal = true
		If a.Length = b.Length
			i = 0.0
			While i < a.Length And equal
				If a(i) <> b(i)
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Function arraysBooleanArraysEqual(ByRef a As Boolean (), ByRef b As Boolean ()) As Boolean
		Dim equal As Boolean
		Dim i As Double

		equal = true
		If a.Length = b.Length
			i = 0.0
			While i < a.Length And equal
				If a(i) <> b(i)
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Function arraysStringsEqual(ByRef a As Char (), ByRef b As Char ()) As Boolean
		Dim equal As Boolean
		Dim i As Double

		equal = true
		If a.Length = b.Length
			i = 0.0
			While i < a.Length And equal
				If a(i) <> b(i)
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Sub arraysFillNumberArray(ByRef a As Double (), value As Double)
		Dim i As Double

		i = 0.0
		While i < a.Length
			a(i) = value
			i = i + 1.0
		End While
	End Sub


	Public Sub arraysFillString(ByRef a As Char (), value As Char)
		Dim i As Double

		i = 0.0
		While i < a.Length
			a(i) = value
			i = i + 1.0
		End While
	End Sub


	Public Sub arraysFillBooleanArray(ByRef a As Boolean (), value As Boolean)
		Dim i As Double

		i = 0.0
		While i < a.Length
			a(i) = value
			i = i + 1.0
		End While
	End Sub


	Public Function arraysFillNumberArrayRange(ByRef a As Double (), value As Double, from As Double, tox As Double) As Boolean
		Dim i, length As Double
		Dim success As Boolean

		If from >= 0.0 And from <= a.Length And tox >= 0.0 And tox <= a.Length And from <= tox
			length = tox - from
			i = 0.0
			While i < length
				a(from + i) = value
				i = i + 1.0
			End While

			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysFillBooleanArrayRange(ByRef a As Boolean (), value As Boolean, from As Double, tox As Double) As Boolean
		Dim i, length As Double
		Dim success As Boolean

		If from >= 0.0 And from <= a.Length And tox >= 0.0 And tox <= a.Length And from <= tox
			length = tox - from
			i = 0.0
			While i < length
				a(from + i) = value
				i = i + 1.0
			End While

			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysFillStringRange(ByRef a As Char (), value As Char, from As Double, tox As Double) As Boolean
		Dim i, length As Double
		Dim success As Boolean

		If from >= 0.0 And from <= a.Length And tox >= 0.0 And tox <= a.Length And from <= tox
			length = tox - from
			i = 0.0
			While i < length
				a(from + i) = value
				i = i + 1.0
			End While

			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysCopyNumberArray(ByRef a As Double ()) As Double ()
		Dim i As Double
		Dim n As Double ()

		n = New Double (a.Length - 1){}

		i = 0.0
		While i < a.Length
			n(i) = a(i)
			i = i + 1.0
		End While

		Return n
	End Function


	Public Function arraysCopyBooleanArray(ByRef a As Boolean ()) As Boolean ()
		Dim i As Double
		Dim n As Boolean ()

		n = New Boolean (a.Length - 1){}

		i = 0.0
		While i < a.Length
			n(i) = a(i)
			i = i + 1.0
		End While

		Return n
	End Function


	Public Function arraysCopyString(ByRef a As Char ()) As Char ()
		Dim i As Double
		Dim n As Char ()

		n = New Char (a.Length - 1){}

		i = 0.0
		While i < a.Length
			n(i) = a(i)
			i = i + 1.0
		End While

		Return n
	End Function


	Public Function arraysCopyNumberArrayRange(ByRef a As Double (), from As Double, tox As Double, ByRef copyReference As NumberArrayReference) As Boolean
		Dim i, length As Double
		Dim n As Double ()
		Dim success As Boolean

		If from >= 0.0 And from <= a.Length And tox >= 0.0 And tox <= a.Length And from <= tox
			length = tox - from
			n = New Double (length - 1){}

			i = 0.0
			While i < length
				n(i) = a(from + i)
				i = i + 1.0
			End While

			copyReference.numberArray = n
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysCopyBooleanArrayRange(ByRef a As Boolean (), from As Double, tox As Double, ByRef copyReference As BooleanArrayReference) As Boolean
		Dim i, length As Double
		Dim n As Boolean ()
		Dim success As Boolean

		If from >= 0.0 And from <= a.Length And tox >= 0.0 And tox <= a.Length And from <= tox
			length = tox - from
			n = New Boolean (length - 1){}

			i = 0.0
			While i < length
				n(i) = a(from + i)
				i = i + 1.0
			End While

			copyReference.booleanArray = n
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysCopyStringRange(ByRef a As Char (), from As Double, tox As Double, ByRef copyReference As StringReference) As Boolean
		Dim i, length As Double
		Dim n As Char ()
		Dim success As Boolean

		If from >= 0.0 And from <= a.Length And tox >= 0.0 And tox <= a.Length And from <= tox
			length = tox - from
			n = New Char (length - 1){}

			i = 0.0
			While i < length
				n(i) = a(from + i)
				i = i + 1.0
			End While

			copyReference.stringx = n
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysIsLastElement(length As Double, index As Double) As Boolean
		Return index + 1.0 = length
	End Function


	Public Function arraysCreateNumberArray(length As Double, value As Double) As Double ()
		Dim arrayx As Double ()

		arrayx = New Double (length - 1){}
		Call arraysFillNumberArray(arrayx, value)

		Return arrayx
	End Function


	Public Function arraysCreateBooleanArray(length As Double, value As Boolean) As Boolean ()
		Dim arrayx As Boolean ()

		arrayx = New Boolean (length - 1){}
		Call arraysFillBooleanArray(arrayx, value)

		Return arrayx
	End Function


	Public Function arraysCreateString(length As Double, value As Char) As Char ()
		Dim arrayx As Char ()

		arrayx = New Char (length - 1){}
		Call arraysFillString(arrayx, value)

		Return arrayx
	End Function


	Public Sub arraysSwapElementsOfNumberArray(ByRef A As Double (), ai As Double, bi As Double)
		Dim tmp As Double

		tmp = A(ai)
		A(ai) = A(bi)
		A(bi) = tmp
	End Sub


	Public Sub arraysSwapElementsOfStringArray(ByRef A As StringArrayReference, ai As Double, bi As Double)
		Dim tmp As StringReference

		tmp = A.stringArray(ai)
		A.stringArray(ai) = A.stringArray(bi)
		A.stringArray(bi) = tmp
	End Sub


	Public Sub arraysReverseNumberArray(ByRef arrayx As Double ())
		Dim i As Double

		i = 0.0
		While i < arrayx.Length/2.0
			Call arraysSwapElementsOfNumberArray(arrayx, i, arrayx.Length - i - 1.0)
			i = i + 1.0
		End While
	End Sub


	Public Function CreateStringScientificNotationDecimalFromNumber(n As Double) As Char ()
		Dim mantissaReference, exponentReference As StringReference
		Dim e As Double
		Dim isPositive As Boolean
		Dim result As Char ()

		mantissaReference = New StringReference()
		exponentReference = New StringReference()
		result = New Char (0 - 1){}

		If n < 0.0
			isPositive = false
			n = -n
		Else
			isPositive = true
		End If

		If n = 0.0
			e = 0.0
		Else
			e = GetFirstDecimalDigitPosition(n)

			If e < 0.0
				n = n*10.0 ^ Abs(e)
			Else
				n = n/10.0 ^ e
			End If
		End If

		mantissaReference.stringx = CreateStringDecimalFromNumber(n)
		exponentReference.stringx = CreateStringDecimalFromNumber(e)

		If Not isPositive
			result = strAppendString(result, "-".ToCharArray())
		End If

		result = strAppendString(result, mantissaReference.stringx)
		result = strAppendString(result, "e".ToCharArray())
		result = strAppendString(result, exponentReference.stringx)

		Return result
	End Function


	Public Function CreateStringDecimalFromNumber(number As Double) As Char ()
		Dim stringx As DynamicArrayCharacters
		Dim maximumDigits, i, d, digitPosition, trailingZeros As Double
		Dim hasPrintedPoint, isPositive, done As Boolean
		Dim characterReference As CharacterReference
		Dim c As Char
		Dim str As Char ()

		stringx = CreateDynamicArrayCharacters()
		isPositive = true

		If number < 0.0
			isPositive = false
			number = -number
		End If

		If number = 0.0
			Call DynamicArrayAddCharacter(stringx, "0"C)
		Else
			characterReference = New CharacterReference()

			maximumDigits = GetMaximumDigitsForDecimal()

			digitPosition = GetFirstDecimalDigitPosition(number)

			hasPrintedPoint = false

			If Not isPositive
				Call DynamicArrayAddCharacter(stringx, "-"C)
			End If

			' Print leading zeros.
			If digitPosition < 0.0
				Call DynamicArrayAddCharacter(stringx, "0"C)
				Call DynamicArrayAddCharacter(stringx, "."C)
				hasPrintedPoint = true
				i = 0.0
				While i < -digitPosition - 1.0
					Call DynamicArrayAddCharacter(stringx, "0"C)
					i = i + 1.0
				End While
			End If

			' Count trailing zeros
			trailingZeros = 0.0
			done = false
			i = 0.0
			While i < maximumDigits And Not done
				d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1.0)
				If d = 0.0
					trailingZeros = trailingZeros + 1.0
				Else
					done = true
				End If
				i = i + 1.0
			End While

			' Print number.
			i = 0.0
			While i < maximumDigits
				d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i)

				If Not hasPrintedPoint And digitPosition - i + 1.0 = 0.0
					If maximumDigits - i > trailingZeros
						Call DynamicArrayAddCharacter(stringx, "."C)
					End If
					hasPrintedPoint = true
				End If

				If maximumDigits - i <= trailingZeros And hasPrintedPoint
				Else
					GetDecimalDigitCharacterFromNumberWithCheck(d, characterReference)
					c = characterReference.characterValue
					Call DynamicArrayAddCharacter(stringx, c)
				End If
				i = i + 1.0
			End While

			' Print trailing zeros.
			i = 0.0
			While i < digitPosition - maximumDigits + 1.0
				Call DynamicArrayAddCharacter(stringx, "0"C)
				i = i + 1.0
			End While
		End If

		' Done
		str = DynamicArrayCharactersToArray(stringx)
		Call FreeDynamicArrayCharacters(stringx)
		Return str
	End Function


	Public Function CreateStringFromNumberWithCheck(number As Double, base As Double, ByRef stringRef As StringReference) As Boolean
		Dim stringx As DynamicArrayCharacters
		Dim maximumDigits, i, d, digitPosition, trailingZeros As Double
		Dim success, hasPrintedPoint, isPositive, done As Boolean
		Dim characterReference As CharacterReference
		Dim c As Char

		stringx = CreateDynamicArrayCharacters()
		isPositive = true

		If number < 0.0
			isPositive = false
			number = -number
		End If

		If number = 0.0
			Call DynamicArrayAddCharacter(stringx, "0"C)
			success = true
		Else
			characterReference = New CharacterReference()

			If IsInteger(base)
				success = true

				maximumDigits = GetMaximumDigitsForBase(base)

				digitPosition = GetFirstDigitPosition(number, base)

				hasPrintedPoint = false

				If Not isPositive
					Call DynamicArrayAddCharacter(stringx, "-"C)
				End If

				' Print leading zeros.
				If digitPosition < 0.0
					Call DynamicArrayAddCharacter(stringx, "0"C)
					Call DynamicArrayAddCharacter(stringx, "."C)
					hasPrintedPoint = true
					i = 0.0
					While i < -digitPosition - 1.0
						Call DynamicArrayAddCharacter(stringx, "0"C)
						i = i + 1.0
					End While
				End If

				' Count trailing zeros
				trailingZeros = 0.0
				done = false
				i = 0.0
				While i < maximumDigits And Not done
					d = GetDigit(number, base, maximumDigits - i - 1.0)
					If d = 0.0
						trailingZeros = trailingZeros + 1.0
					Else
						done = true
					End If
					i = i + 1.0
				End While

				' Print number.
				i = 0.0
				While i < maximumDigits And success
					d = GetDigit(number, base, i)

					If d >= base
						d = base - 1.0
					End If

					If Not hasPrintedPoint And digitPosition - i + 1.0 = 0.0
						If maximumDigits - i > trailingZeros
							Call DynamicArrayAddCharacter(stringx, "."C)
						End If
						hasPrintedPoint = true
					End If

					If maximumDigits - i <= trailingZeros And hasPrintedPoint
					Else
						success = GetSingleDigitCharacterFromNumberWithCheck(d, base, characterReference)
						If success
							c = characterReference.characterValue
							Call DynamicArrayAddCharacter(stringx, c)
						End If
					End If
					i = i + 1.0
				End While

				If success
					' Print trailing zeros.
					i = 0.0
					While i < digitPosition - maximumDigits + 1.0
						Call DynamicArrayAddCharacter(stringx, "0"C)
						i = i + 1.0
					End While
				End If
			Else
				success = false
			End If
		End If

		If success
			stringRef.stringx = DynamicArrayCharactersToArray(stringx)
			Call FreeDynamicArrayCharacters(stringx)
		End If

		' Done
		Return success
	End Function


	Public Function GetMaximumDigitsForBase(base As Double) As Double
		Dim t As Double

		t = 10.0 ^ 15.0
		Return Floor(Log10(t)/Log10(base))
	End Function


	Public Function GetMaximumDigitsForDecimal() As Double
		Return 15.0
	End Function


	Public Function GetFirstDecimalDigitPosition(n As Double) As Double
		Dim power, m, i As Double
		Dim multiply, done As Boolean

		n = Abs(n)

		If n <> 0.0
			If Floor(n) < 10.0 ^ 15.0
				multiply = true
			Else
				multiply = false
			End If

			done = false
			m = 0.0
			i = 0.0
			While Not done
				If multiply
					m = n*10.0 ^ i
					If Floor(m) >= 10.0 ^ 14.0
						done = true
					End If
				Else
					m = n/10.0 ^ i
					If Floor(m) < 10.0 ^ 15.0
						done = true
					End If
				End If
				i = i + 1.0
			End While

			If multiply
				power = 15.0 - i
			Else
				power = 15.0 + i - 2.0
			End If

			If Roundx(m) >= 10.0 ^ 15.0
				power = power + 1.0
			End If
		Else
			power = 1.0
		End If

		Return power
	End Function


	Public Function GetFirstDigitPosition(n As Double, base As Double) As Double
		Dim power, m, i, maximumDigits As Double
		Dim multiply, done As Boolean

		maximumDigits = GetMaximumDigitsForBase(base)
		n = Abs(n)

		If n <> 0.0
			If Floor(n) < base ^ maximumDigits
				multiply = true
			Else
				multiply = false
			End If

			done = false
			m = 0.0
			i = 0.0
			While Not done
				If multiply
					m = n*base ^ i
					If Floor(m) >= base ^ (maximumDigits - 1.0)
						done = true
					End If
				Else
					m = n/base ^ i
					If Floor(m) < base ^ maximumDigits
						done = true
					End If
				End If
				i = i + 1.0
			End While

			If multiply
				power = maximumDigits - i
			Else
				power = maximumDigits + i - 2.0
			End If

			If Roundx(m) >= base ^ maximumDigits
				power = power + 1.0
			End If
		Else
			power = 1.0
		End If

		Return power
	End Function


	Public Function GetSingleDigitCharacterFromNumberWithCheck(c As Double, base As Double, ByRef characterReference As CharacterReference) As Boolean
		Dim numberTable As Char ()
		Dim success As Boolean

		numberTable = GetDigitCharacterTable()

		If c < base Or c < numberTable.Length
			success = true
			characterReference.characterValue = numberTable(c)
		Else
			success = false
		End If

		Return success
	End Function


	Public Function GetDecimalDigitCharacterFromNumberWithCheck(c As Double, ByRef characterRef As CharacterReference) As Boolean
		Dim numberTable As Char ()
		Dim success As Boolean

		numberTable = "0123456789".ToCharArray()

		If c >= 0.0 And c < 10.0
			success = true
			characterRef.characterValue = numberTable(c)
		Else
			success = false
		End If

		Return success
	End Function


	Public Function GetDigitCharacterTable() As Char ()
		Dim numberTable As Char ()

		numberTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()

		Return numberTable
	End Function


	Public Function GetDecimalDigit(n As Double, index As Double) As Double
		Dim digitPosition As Double

		digitPosition = GetFirstDecimalDigitPosition(n)

		Return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index)
	End Function


	Public Function GetDecimalDigitWithFirstDigitPosition(n As Double, digitPosition As Double, index As Double) As Double
		Dim d, e, m, i As Double

		n = Abs(n)

		e = 15.0 - digitPosition - 1.0
		If e < 0.0
			n = Round(n/10.0 ^ Abs(e))
		Else
			n = Round(n*10.0 ^ e)
		End If

		m = n
		d = 0.0
		i = 0.0
		While i < 15.0 - index
			d = Round(m Mod 10.0)
			m = m - d
			m = Round(m/10.0)
			i = i + 1.0
		End While

		Return d
	End Function


	Public Function GetDigit(n As Double, base As Double, index As Double) As Double
		Dim d, digitPosition, e, m, maximumDigits, i As Double

		n = Abs(n)
		maximumDigits = GetMaximumDigitsForBase(base)
		digitPosition = GetFirstDigitPosition(n, base)

		e = maximumDigits - digitPosition - 1.0
		If e < 0.0
			n = Round(n/base ^ Abs(e))
		Else
			n = Round(n*base ^ e)
		End If

		m = n
		d = 0.0
		i = 0.0
		While i < maximumDigits - index
			d = Round(m Mod base)
			m = m - d
			m = Round(m/base)
			i = i + 1.0
		End While

		Return d
	End Function


	Public Function NumberToHumanReadableShortScale(n As Double) As Char ()
		Dim res, suffix As Char ()
		Dim hasSuffix As Boolean
		Dim k, M, B, T, Q As Double

		k = 1000.0
		M = k*1000.0
		B = M*1000.0
		T = B*1000.0
		Q = T*1000.0
		suffix = " ".ToCharArray()

		If n < k
			hasSuffix = false
		Else
			hasSuffix = true
		End If

		If n >= k And n < M
			If n < 10.0*k
				n = Roundx(n/100.0)
				n = n/10.0
			Else
				n = Roundx(n/k)
			End If
			suffix = "k".ToCharArray()
		ElseIf n >= M And n < B
			If n < 10.0*M
				n = Roundx(n/(k*100.0))
				n = n/10.0
			Else
				n = Roundx(n/M)
			End If
			suffix = "M".ToCharArray()
		ElseIf n >= B And n < T
			If n < 10.0*B
				n = Roundx(n/(M*100.0))
				n = n/10.0
			Else
				n = Roundx(n/B)
			End If
			suffix = "B".ToCharArray()
		ElseIf n >= T And n < Q
			If n < 10.0*T
				n = Roundx(n/(B*100.0))
				n = n/10.0
			Else
				n = Roundx(n/T)
			End If
			suffix = "T".ToCharArray()
		ElseIf n >= Q
			If n < 10.0*Q
				n = Roundx(n/(T*100.0))
				n = n/10.0
			Else
				n = Roundx(n/Q)
			End If
			suffix = "Q".ToCharArray()
		End If

		res = CreateStringDecimalFromNumber(n)
		If hasSuffix
			res = strAppendString(res, suffix)
		End If
        
		Return res
	End Function


	Public Function NumberToHumanReadableBinary(n As Double) As Char ()
		Dim res, suffix As Char ()
		Dim hasSuffix As Boolean
		Dim Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi As Double

		Ki = 1024.0
		Mi = Ki*1024.0
		Gi = Mi*1024.0
		Ti = Gi*1024.0
		Pi = Ti*1024.0
		Ei = Pi*1024.0
		Zi = Ei*1024.0
		Yi = Zi*1024.0
		suffix = " ".ToCharArray()

		If n < Ki
			hasSuffix = false
		Else
			hasSuffix = true
		End If

		If n >= Ki And n < Mi
			If n < 10.0*Ki
				n = Roundx(n/(Ki/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Ki)
			End If
			suffix = "Ki".ToCharArray()
		ElseIf n >= Mi And n < Gi
			If n < 10.0*Mi
				n = Roundx(n/(Mi/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Mi)
			End If
			suffix = "Mi".ToCharArray()
		ElseIf n >= Gi And n < Ti
			If n < 10.0*Gi
				n = Roundx(n/(Gi/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Gi)
			End If
			suffix = "Gi".ToCharArray()
		ElseIf n >= Ti And n < Pi
			If n < 10.0*Ti
				n = Roundx(n/(Ti/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Ti)
			End If
			suffix = "Ti".ToCharArray()
		ElseIf n >= Pi And n < Ei
			If n < 10.0*Pi
				n = Roundx(n/(Pi/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Pi)
			End If
			suffix = "Pi".ToCharArray()
		ElseIf n >= Ei And n < Zi
			If n < 10.0*Ei
				n = Roundx(n/(Ei/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Ei)
			End If
			suffix = "Ei".ToCharArray()
		ElseIf n >= Zi And n < Yi
			If n < 10.0*Zi
				n = Roundx(n/(Zi/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Zi)
			End If
			suffix = "Zi".ToCharArray()
		ElseIf n >= Yi
			If n < 10.0*Yi
				n = Roundx(n/(Yi/10.0))
				n = n/10.0
			Else
				n = Roundx(n/Yi)
			End If
			suffix = "Yi".ToCharArray()
		End If

		res = CreateStringDecimalFromNumber(n)
		If hasSuffix
			res = strAppendString(res, suffix)
		End If

		Return res
	End Function


	Public Function NumberToHumanReadableMetric(n As Double) As Char ()
		Dim res, suffix As Char ()
		Dim hasSuffix As Boolean
		Dim k, M, G, T, P, Ex, Z, Y, R, Q As Double

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
		suffix = " ".ToCharArray()

		If n < k
			hasSuffix = false
		Else
			hasSuffix = true
		End If

		If n >= k And n < M
			If n < 10.0*k
				n = Roundx(n/100.0)
				n = n/10.0
			Else
				n = Roundx(n/k)
			End If
			suffix = "k".ToCharArray()
		ElseIf n >= M And n < G
			If n < 10.0*M
				n = Roundx(n/(k*100.0))
				n = n/10.0
			Else
				n = Roundx(n/M)
			End If
			suffix = "M".ToCharArray()
		ElseIf n >= G And n < T
			If n < 10.0*G
				n = Roundx(n/(M*100.0))
				n = n/10.0
			Else
				n = Roundx(n/G)
			End If
			suffix = "G".ToCharArray()
		ElseIf n >= T And n < P
			If n < 10.0*T
				n = Roundx(n/(G*100.0))
				n = n/10.0
			Else
				n = Roundx(n/T)
			End If
			suffix = "T".ToCharArray()
		ElseIf n >= P And n < Ex
			If n < 10.0*P
				n = Roundx(n/(T*100.0))
				n = n/10.0
			Else
				n = Roundx(n/P)
			End If
			suffix = "P".ToCharArray()
		ElseIf n >= Ex And n < Z
			If n < 10.0*Ex
				n = Roundx(n/(P*100.0))
				n = n/10.0
			Else
				n = Roundx(n/Ex)
			End If
			suffix = "E".ToCharArray()
		ElseIf n >= Z And n < Y
			If n < 10.0*Z
				n = Roundx(n/(Ex*100.0))
				n = n/10.0
			Else
				n = Roundx(n/Z)
			End If
			suffix = "Z".ToCharArray()
		ElseIf n >= Y And n < R
			If n < 10.0*Y
				n = Roundx(n/(Z*100.0))
				n = n/10.0
			Else
				n = Roundx(n/Y)
			End If
			suffix = "Y".ToCharArray()
		ElseIf n >= R And n < Q
			If n < 10.0*R
				n = Roundx(n/(Y*100.0))
				n = n/10.0
			Else
				n = Roundx(n/R)
			End If
			suffix = "R".ToCharArray()
		ElseIf n >= Q
			If n < 10.0*Q
				n = Roundx(n/(R*100.0))
				n = n/10.0
			Else
				n = Roundx(n/Q)
			End If
			suffix = "Q".ToCharArray()
		End If

		res = CreateStringDecimalFromNumber(n)
		If hasSuffix
			res = strAppendString(res, suffix)
		End If

		Return res
	End Function


	Public Function IsValidNumber(ByRef str As Char ()) As Boolean
		Dim valid As Boolean
		Dim numberRef As NumberReference
		Dim message As StringReference

		numberRef = New NumberReference()
		message = New StringReference()

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

		numberRef = Nothing
		message = Nothing

		Return valid
	End Function


	Public Function IsValidInteger(ByRef str As Char ()) As Boolean
		Dim valid As Boolean
		Dim numberRef As NumberReference
		Dim message As StringReference

		numberRef = New NumberReference()
		message = New StringReference()

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

		If valid
			valid = IsInteger(numberRef.numberValue)
		End If

		numberRef = Nothing
		message = Nothing

		Return valid
	End Function


	Public Function IsValidPositiveInteger(ByRef str As Char ()) As Boolean
		Dim valid As Boolean
		Dim numberRef As NumberReference
		Dim message As StringReference

		numberRef = New NumberReference()
		message = New StringReference()

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

		If valid
			valid = IsInteger(numberRef.numberValue)
			If valid
				valid = numberRef.numberValue >= 0.0
			End If
		End If

		numberRef = Nothing
		message = Nothing

		Return valid
	End Function


	Public Function CreateNumberFromDecimalStringWithCheck(ByRef stringx As Char (), ByRef decimalReference As NumberReference, ByRef message As StringReference) As Boolean
		Return CreateNumberFromStringWithCheck(stringx, 10.0, decimalReference, message)
	End Function


	Public Function CreateNumberFromDecimalString(ByRef stringx As Char ()) As Double
		Dim doubleReference As NumberReference
		Dim stringReference As StringReference
		Dim number As Double

		doubleReference = CreateNumberReference(0.0)
		stringReference = CreateStringReference("".ToCharArray())
		CreateNumberFromStringWithCheck(stringx, 10.0, doubleReference, stringReference)
		number = doubleReference.numberValue

		doubleReference = Nothing
		stringReference = Nothing

		Return number
	End Function


	Public Function CreateNumberFromStringWithCheck(ByRef stringx As Char (), base As Double, ByRef numberReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim success As Boolean
		Dim numberIsPositive, exponentIsPositive As BooleanReference
		Dim beforePoint, afterPoint, exponent As NumberArrayReference

		numberIsPositive = CreateBooleanReference(true)
		exponentIsPositive = CreateBooleanReference(true)
		beforePoint = New NumberArrayReference()
		afterPoint = New NumberArrayReference()
		exponent = New NumberArrayReference()

		If base >= 2.0 And base <= 36.0
			success = ExtractPartsFromNumberString(stringx, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

			If success
				numberReference.numberValue = CreateNumberFromParts(base, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray)
			End If
		Else
			success = false
			message.stringx = "Base must be from 2 to 36.".ToCharArray()
		End If

		Return success
	End Function


	Public Function CreateNumberFromParts(base As Double, numberIsPositive As Boolean, ByRef beforePoint As Double (), ByRef afterPoint As Double (), exponentIsPositive As Boolean, ByRef exponent As Double ()) As Double
		Dim n, i, p, e As Double

		n = 0.0

		i = 0.0
		While i < beforePoint.Length
			p = beforePoint(beforePoint.Length - i - 1.0)

			n = n + p*base ^ i
			i = i + 1.0
		End While

		i = 0.0
		While i < afterPoint.Length
			p = afterPoint(i)

			n = n + p/base ^ (i + 1.0)
			i = i + 1.0
		End While

		If exponent.Length > 0.0
			e = 0.0
			i = 0.0
			While i < exponent.Length
				p = exponent(exponent.Length - i - 1.0)

				e = e + p*base ^ i
				i = i + 1.0
			End While

			If Not exponentIsPositive
				e = -e
			End If

			n = n*base ^ e
		End If

		If Not numberIsPositive
			n = -n
		End If

		Return n
	End Function


	Public Function ExtractPartsFromNumberString(ByRef n As Char (), base As Double, ByRef numberIsPositive As BooleanReference, ByRef beforePoint As NumberArrayReference, ByRef afterPoint As NumberArrayReference, ByRef exponentIsPositive As BooleanReference, ByRef exponent As NumberArrayReference, ByRef errorMessages As StringReference) As Boolean
		Dim i, j, count As Double
		Dim success, done, complete As Boolean

		i = 0.0
		complete = false

		If i < n.Length
			If n(i) = "-"C
				numberIsPositive.booleanValue = false
				i = i + 1.0
			ElseIf n(i) = "+"C
				numberIsPositive.booleanValue = true
				i = i + 1.0
			End If

			success = true
		Else
			success = false
			errorMessages.stringx = "Number cannot have length zero.".ToCharArray()
		End If

		If success
			done = false
			count = 0.0
			
			While i + count < n.Length And Not done
				If CharacterIsNumberCharacterInBase(n(i + count), base)
					count = count + 1.0
				Else
					done = true
				End If
			End While

			If count >= 1.0
				beforePoint.numberArray = New Double (count - 1){}

				j = 0.0
				While j < count
					beforePoint.numberArray(j) = GetNumberFromNumberCharacterForBase(n(i + j), base)
					j = j + 1.0
				End While

				i = i + count

				If i < n.Length
					success = true
				Else
					afterPoint.numberArray = New Double (0 - 1){}
					exponent.numberArray = New Double (0 - 1){}
					success = true
					complete = true
				End If
			Else
				success = false
				errorMessages.stringx = "Number must have at least one number after the optional sign.".ToCharArray()
			End If
		End If

		If success And Not complete
			If n(i) = "."C
				i = i + 1.0

				If i < n.Length
					done = false
					count = 0.0
					
					While i + count < n.Length And Not done
						If CharacterIsNumberCharacterInBase(n(i + count), base)
							count = count + 1.0
						Else
							done = true
						End If
					End While

					If count >= 1.0
						afterPoint.numberArray = New Double (count - 1){}

						j = 0.0
						While j < count
							afterPoint.numberArray(j) = GetNumberFromNumberCharacterForBase(n(i + j), base)
							j = j + 1.0
						End While

						i = i + count

						If i < n.Length
							success = true
						Else
							exponent.numberArray = New Double (0 - 1){}
							success = true
							complete = true
						End If
					Else
						success = false
						errorMessages.stringx = "There must be at least one digit after the decimal point.".ToCharArray()
					End If
				Else
					success = false
					errorMessages.stringx = "There must be at least one digit after the decimal point.".ToCharArray()
				End If
			ElseIf base <= 14.0 And (n(i) = "e"C Or n(i) = "E"C)
				If i < n.Length
					success = true
					afterPoint.numberArray = New Double (0 - 1){}
				Else
					success = false
					errorMessages.stringx = "There must be at least one digit after the exponent.".ToCharArray()
				End If
			Else
				success = false
				errorMessages.stringx = "Expected decimal point or exponent symbol.".ToCharArray()
			End If
		End If

		If success And Not complete
			If base <= 14.0 And (n(i) = "e"C Or n(i) = "E"C)
				i = i + 1.0

				If i < n.Length
					If n(i) = "-"C
						exponentIsPositive.booleanValue = false
						i = i + 1.0
					ElseIf n(i) = "+"C
						exponentIsPositive.booleanValue = true
						i = i + 1.0
					End If

					If i < n.Length
						done = false
						count = 0.0
						
						While i + count < n.Length And Not done
							If CharacterIsNumberCharacterInBase(n(i + count), base)
								count = count + 1.0
							Else
								done = true
							End If
						End While

						If count >= 1.0
							exponent.numberArray = New Double (count - 1){}

							j = 0.0
							While j < count
								exponent.numberArray(j) = GetNumberFromNumberCharacterForBase(n(i + j), base)
								j = j + 1.0
							End While

							i = i + count

							If i = n.Length
								success = true
							Else
								success = false
								errorMessages.stringx = "There cannot be any characters past the exponent of the number.".ToCharArray()
							End If
						Else
							success = false
							errorMessages.stringx = "There must be at least one digit after the decimal point.".ToCharArray()
						End If
					Else
						success = false
						errorMessages.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray()
					End If
				Else
					success = false
					errorMessages.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray()
				End If
			Else
				success = false
				errorMessages.stringx = "Expected exponent symbol.".ToCharArray()
			End If
		End If

		Return success
	End Function


	Public Function GetNumberFromNumberCharacterForBase(c As Char, base As Double) As Double
		Dim numberTable As Char ()
		Dim i As Double
		Dim position As Double

		numberTable = GetDigitCharacterTable()
		position = 0.0

		i = 0.0
		While i < base
			If numberTable(i) = c
				position = i
			End If
			i = i + 1.0
		End While

		Return position
	End Function


	Public Function CharacterIsNumberCharacterInBase(c As Char, base As Double) As Boolean
		Dim numberTable As Char ()
		Dim i As Double
		Dim found As Boolean

		numberTable = GetDigitCharacterTable()
		found = false

		i = 0.0
		While i < base
			If numberTable(i) = c
				found = true
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function StringToNumberArray(ByRef str As Char ()) As Double ()
		Dim numberArrayReference As NumberArrayReference
		Dim stringReference As StringReference
		Dim numbers As Double ()

		numberArrayReference = New NumberArrayReference()
		stringReference = New StringReference()

		StringToNumberArrayWithCheck(str, numberArrayReference, stringReference)

		numbers = numberArrayReference.numberArray

		numberArrayReference = Nothing
		stringReference = Nothing

		Return numbers
	End Function


	Public Function StringToNumberArrayWithCheck(ByRef str As Char (), ByRef numberArrayReference As NumberArrayReference, ByRef errorMessage As StringReference) As Boolean
		Dim numberStrings As StringReference ()
		Dim numbers As Double ()
		Dim i As Double
		Dim numberString, trimmedNumberString As Char ()
		Dim success As Boolean
		Dim numberReference As NumberReference

		numberStrings = strSplitByString(str, ",".ToCharArray())

		numbers = New Double (numberStrings.Length - 1){}
		success = true
		numberReference = New NumberReference()

		i = 0.0
		While i < numberStrings.Length
			numberString = numberStrings(i).stringx
			trimmedNumberString = strTrim(numberString)
			success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage)
			numbers(i) = numberReference.numberValue

			Call FreeStringReference(numberStrings(i))
			Erase trimmedNumberString 
			i = i + 1.0
		End While

		Erase numberStrings 
		numberReference = Nothing

		numberArrayReference.numberArray = numbers

		Return success
	End Function


	Public Sub strWriteStringToStingStream(ByRef stream As Char (), ByRef index As NumberReference, ByRef src As Char ())
		Dim i As Double

		i = 0.0
		While i < src.Length
			stream(index.numberValue + i) = src(i)
			i = i + 1.0
		End While
		index.numberValue = index.numberValue + src.Length
	End Sub


	Public Sub strWriteCharacterToStingStream(ByRef stream As Char (), ByRef index As NumberReference, src As Char)
		stream(index.numberValue) = src
		index.numberValue = index.numberValue + 1.0
	End Sub


	Public Sub strWriteBooleanToStingStream(ByRef stream As Char (), ByRef index As NumberReference, src As Boolean)
		If src
			Call strWriteStringToStingStream(stream, index, "true".ToCharArray())
		Else
			Call strWriteStringToStingStream(stream, index, "false".ToCharArray())
		End If
	End Sub


	Public Function strSubstringWithCheck(ByRef stringx As Char (), from As Double, tox As Double, ByRef stringReference As StringReference) As Boolean
		Dim success As Boolean

		If from >= 0.0 And from <= stringx.Length And tox >= 0.0 And tox <= stringx.Length And from <= tox
			stringReference.stringx = strSubstring(stringx, from, tox)
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function strSubstring(ByRef stringx As Char (), from As Double, tox As Double) As Char ()
		Dim n As Char ()
		Dim i, length As Double

		length = tox - from

		n = New Char (length - 1){}

		i = from
		While i < tox
			n(i - from) = stringx(i)
			i = i + 1.0
		End While

		Return n
	End Function


	Public Function strAppendString(ByRef s1 As Char (), ByRef s2 As Char ()) As Char ()
		Dim newString As Char ()

		newString = strConcatenateString(s1, s2)

		Erase s1 

		Return newString
	End Function


	Public Function strConcatenateString(ByRef s1 As Char (), ByRef s2 As Char ()) As Char ()
		Dim newString As Char ()
		Dim i As Double

		newString = New Char (s1.Length + s2.Length - 1){}

		i = 0.0
		While i < s1.Length
			newString(i) = s1(i)
			i = i + 1.0
		End While

		i = 0.0
		While i < s2.Length
			newString(s1.Length + i) = s2(i)
			i = i + 1.0
		End While

		Return newString
	End Function


	Public Function strAppendCharacter(ByRef stringx As Char (), c As Char) As Char ()
		Dim newString As Char ()

		newString = strConcatenateCharacter(stringx, c)

		Erase stringx 

		Return newString
	End Function


	Public Function strConcatenateCharacter(ByRef stringx As Char (), c As Char) As Char ()
		Dim newString As Char ()
		Dim i As Double
		newString = New Char (stringx.Length + 1.0 - 1){}

		i = 0.0
		While i < stringx.Length
			newString(i) = stringx(i)
			i = i + 1.0
		End While

		newString(stringx.Length) = c

		Return newString
	End Function


	Public Function strSplitByCharacter(ByRef toSplit As Char (), splitBy As Char) As StringReference ()
		Dim parts As StringReference ()
		Dim i As Double
		Dim c As Char
		Dim ll As LinkedListStrings
		Dim nextx As LinkedListCharacters
		Dim part As Char ()

		ll = CreateLinkedListString()

		nextx = CreateLinkedListCharacter()
		i = 0.0
		While i < toSplit.Length
			c = toSplit(i)

			If c = splitBy
				part = LinkedListCharactersToArray(nextx)
				Call LinkedListAddString(ll, part)
				Call FreeLinkedListCharacter(nextx)
				nextx = CreateLinkedListCharacter()
			Else
				Call LinkedListAddCharacter(nextx, c)
			End If
			i = i + 1.0
		End While

		part = LinkedListCharactersToArray(nextx)
		Call LinkedListAddString(ll, part)
		Call FreeLinkedListCharacter(nextx)

		parts = LinkedListStringsToArray(ll)
		Call FreeLinkedListString(ll)

		Return parts
	End Function


	Public Function strIndexOfCharacter(ByRef stringx As Char (), character As Char, ByRef indexReference As NumberReference) As Boolean
		Dim i As Double
		Dim found As Boolean

		found = false
		i = 0.0
		While i < stringx.Length And Not found
			If stringx(i) = character
				found = true
				indexReference.numberValue = i
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function strLastIndexOfCharacter(ByRef stringx As Char (), character As Char, ByRef indexReference As NumberReference) As Boolean
		Dim i As Double
		Dim found As Boolean

		found = false
		i = 0.0
		While i < stringx.Length
			If stringx(i) = character
				found = true
				indexReference.numberValue = i
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function strSubstringEqualsWithCheck(ByRef stringx As Char (), from As Double, ByRef substring As Char (), ByRef equalsReference As BooleanReference) As Boolean
		Dim success As Boolean

		If from < stringx.Length
			success = true
			equalsReference.booleanValue = strSubstringEquals(stringx, from, substring)
		Else
			success = false
		End If

		Return success
	End Function


	Public Function strSubstringEquals(ByRef stringx As Char (), from As Double, ByRef substring As Char ()) As Boolean
		Dim i As Double
		Dim equal As Boolean

		equal = true
		If stringx.Length - from >= substring.Length
			i = 0.0
			While i < substring.Length And equal
				If stringx(from + i) <> substring(i)
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Function strIndexOfString(ByRef stringx As Char (), ByRef substring As Char (), ByRef indexReference As NumberReference) As Boolean
		Dim i As Double
		Dim found As Boolean

		found = false
		i = 0.0
		While i < stringx.Length - substring.Length + 1.0 And Not found
			If strSubstringEquals(stringx, i, substring)
				found = true
				indexReference.numberValue = i
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function strContainsCharacter(ByRef stringx As Char (), character As Char) As Boolean
		Dim i As Double
		Dim found As Boolean

		found = false
		i = 0.0
		While i < stringx.Length And Not found
			If stringx(i) = character
				found = true
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function strContainsString(ByRef stringx As Char (), ByRef substring As Char ()) As Boolean
		Return strIndexOfString(stringx, substring, New NumberReference())
	End Function


	Public Sub strToUpperCase(ByRef stringx As Char ())
		Dim i As Double

		i = 0.0
		While i < stringx.Length
			stringx(i) = cToUpperCase(stringx(i))
			i = i + 1.0
		End While
	End Sub


	Public Sub strToLowerCase(ByRef stringx As Char ())
		Dim i As Double

		i = 0.0
		While i < stringx.Length
			stringx(i) = cToLowerCase(stringx(i))
			i = i + 1.0
		End While
	End Sub


	Public Function strEqualsIgnoreCase(ByRef a As Char (), ByRef b As Char ()) As Boolean
		Dim equal As Boolean
		Dim i As Double

		If a.Length = b.Length
			equal = true
			i = 0.0
			While i < a.Length And equal
				If cToLowerCase(a(i)) <> cToLowerCase(b(i))
					equal = false
				End If
				i = i + 1.0
			End While
		Else
			equal = false
		End If

		Return equal
	End Function


	Public Function strReplaceString(ByRef stringx As Char (), ByRef toReplace As Char (), ByRef replaceWith As Char ()) As Char ()
		Dim result As Char ()
		Dim i, j As Double
		Dim equalsReference As BooleanReference
		Dim success As Boolean
		Dim da As DynamicArrayCharacters

		da = CreateDynamicArrayCharacters()

		equalsReference = New BooleanReference()

		i = 0.0
		While i < stringx.Length
			success = strSubstringEqualsWithCheck(stringx, i, toReplace, equalsReference)
			If success
				success = equalsReference.booleanValue
			End If

			If success And toReplace.Length > 0.0
				j = 0.0
				While j < replaceWith.Length
					Call DynamicArrayAddCharacter(da, replaceWith(j))
					j = j + 1.0
				End While
				i = i + toReplace.Length
			Else
				Call DynamicArrayAddCharacter(da, stringx(i))
				i = i + 1.0
			End If
		End While

		result = DynamicArrayCharactersToArray(da)

		Call FreeDynamicArrayCharacters(da)

		Return result
	End Function


	Public Function strReplaceCharacterToNew(ByRef stringx As Char (), toReplace As Char, replaceWith As Char) As Char ()
		Dim result As Char ()
		Dim i As Double

		result = New Char (stringx.Length - 1){}

		i = 0.0
		While i < stringx.Length
			If stringx(i) = toReplace
				result(i) = replaceWith
			Else
				result(i) = stringx(i)
			End If
			i = i + 1.0
		End While

		Return result
	End Function


	Public Sub strReplaceCharacter(ByRef stringx As Char (), toReplace As Char, replaceWith As Char)
		Dim i As Double

		i = 0.0
		While i < stringx.Length
			If stringx(i) = toReplace
				stringx(i) = replaceWith
			End If
			i = i + 1.0
		End While
	End Sub


	Public Function strTrim(ByRef stringx As Char ()) As Char ()
		Dim result As Char ()
		Dim i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd As Double
		Dim firstNonWhitespaceFound As Boolean

		' Find whitepaces at the start.
		lastWhitespaceLocationStart = -1.0
		firstNonWhitespaceFound = false
		i = 0.0
		While i < stringx.Length And Not firstNonWhitespaceFound
			If cIsWhiteSpace(stringx(i))
				lastWhitespaceLocationStart = i
			Else
				firstNonWhitespaceFound = true
			End If
			i = i + 1.0
		End While

		' Find whitepaces at the end.
		lastWhitespaceLocationEnd = stringx.Length
		firstNonWhitespaceFound = false
		i = stringx.Length - 1.0
		While i >= 0.0 And Not firstNonWhitespaceFound
			If cIsWhiteSpace(stringx(i))
				lastWhitespaceLocationEnd = i
			Else
				firstNonWhitespaceFound = true
			End If
			i = i - 1.0
		End While

		If lastWhitespaceLocationStart < lastWhitespaceLocationEnd
			result = strSubstring(stringx, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd)
		Else
			result = New Char (0 - 1){}
		End If

		Return result
	End Function


	Public Function strStartsWith(ByRef stringx As Char (), ByRef start As Char ()) As Boolean
		Dim startsWithString As Boolean

		startsWithString = false
		If stringx.Length >= start.Length
			startsWithString = strSubstringEquals(stringx, 0.0, start)
		End If

		Return startsWithString
	End Function


	Public Function strEndsWith(ByRef stringx As Char (), ByRef endx As Char ()) As Boolean
		Dim endsWithString As Boolean

		endsWithString = false
		If stringx.Length >= endx.Length
			endsWithString = strSubstringEquals(stringx, stringx.Length - endx.Length, endx)
		End If

		Return endsWithString
	End Function


	Public Function strSplitByString(ByRef toSplit As Char (), ByRef splitBy As Char ()) As StringReference ()
		Dim parts As StringReference ()
		Dim i As Double
		Dim c As Char
		Dim ll As LinkedListStrings
		Dim nextx As LinkedListCharacters
		Dim part As Char ()

		ll = CreateLinkedListString()

		nextx = CreateLinkedListCharacter()
		i = 0.0
		While i < toSplit.Length
			c = toSplit(i)

			If strSubstringEquals(toSplit, i, splitBy)
				part = LinkedListCharactersToArray(nextx)
				Call LinkedListAddString(ll, part)
				Call FreeLinkedListCharacter(nextx)
				nextx = CreateLinkedListCharacter()
				i = i + splitBy.Length
			Else
				Call LinkedListAddCharacter(nextx, c)
				i = i + 1.0
			End If
		End While

		part = LinkedListCharactersToArray(nextx)
		Call LinkedListAddString(ll, part)
		Call FreeLinkedListCharacter(nextx)

		parts = LinkedListStringsToArray(ll)
		Call FreeLinkedListString(ll)

		Return parts
	End Function


	Public Function strStringIsBefore(ByRef a As Char (), ByRef b As Char ()) As Boolean
		Dim before, equal, done As Boolean
		Dim i As Double

		before = false
		equal = true
		done = false

		If a.Length = 0.0 And b.Length > 0.0
			before = true
		Else
			i = 0.0
			While i < a.Length And i < b.Length And Not done
				If a(i) <> b(i)
					equal = false
				End If
				If cCharacterIsBefore(a(i), b(i))
					before = true
				End If
				If cCharacterIsBefore(b(i), a(i))
					done = true
				End If
				i = i + 1.0
			End While

			If equal
				If a.Length < b.Length
					before = true
				End If
			End If
		End If

		Return before
	End Function


	Public Function strJoinStringsWithSeparator(ByRef strings As StringReference (), ByRef separator As Char ()) As Char ()
		Dim result, stringx As Char ()
		Dim length, i As Double
		Dim index As NumberReference

		index = CreateNumberReference(0.0)

		length = 0.0
		i = 0.0
		While i < strings.Length
			length = length + strings(i).stringx.Length
			i = i + 1.0
		End While
		length = length + (strings.Length - 1.0)*separator.Length

		result = New Char (length - 1){}

		i = 0.0
		While i < strings.Length
			stringx = strings(i).stringx
			Call strWriteStringToStingStream(result, index, stringx)
			If i + 1.0 < strings.Length
				Call strWriteStringToStingStream(result, index, separator)
			End If
			i = i + 1.0
		End While

		index = Nothing

		Return result
	End Function


	Public Function strJoinStrings(ByRef strings As StringReference ()) As Char ()
		Dim result, stringx As Char ()
		Dim length, i As Double
		Dim index As NumberReference

		index = CreateNumberReference(0.0)

		length = 0.0
		i = 0.0
		While i < strings.Length
			length = length + strings(i).stringx.Length
			i = i + 1.0
		End While

		result = New Char (length - 1){}

		i = 0.0
		While i < strings.Length
			stringx = strings(i).stringx
			Call strWriteStringToStingStream(result, index, stringx)
			i = i + 1.0
		End While

		index = Nothing

		Return result
	End Function


	Public Function strStringOrder(ByRef a As Char (), ByRef b As Char ()) As Double
		Dim order, minimum, i, ac, bc As Double
		Dim done As Boolean

		minimum = Min(a.Length, b.Length)

		done = false
		order = 0.0
		i = 0.0
		While i < minimum And Not done
			ac = Convert.ToInt16(a(i))
			bc = Convert.ToInt16(b(i))

			If ac < bc
				done = true
				order = 1.0
			ElseIf ac > bc
				done = true
				order = -1.0
			End If
			i = i + 1.0
		End While

		If Not done
			If a.Length < b.Length
				order = 1.0
			ElseIf a.Length > b.Length
				order = -1.0
			End If
		End If

		Return order
	End Function


	Public Function strLeftPad(ByRef str As Char (), width As Double) As Char ()
		Dim i As Double
		Dim padded As Char ()

		padded = New Char (width - 1){}
		Call arraysFillString(padded, " "C)

		i = 0.0
		While i < str.Length
			padded(width - str.Length + i) = str(i)
			i = i + 1.0
		End While

		Return padded
	End Function


	Public Function strRightPad(ByRef str As Char (), width As Double) As Char ()
		Dim i As Double
		Dim padded As Char ()

		padded = New Char (width - 1){}
		Call arraysFillString(padded, " "C)

		i = 0.0
		While i < str.Length
			padded(i) = str(i)
			i = i + 1.0
		End While

		Return padded
	End Function


	Public Sub AssertFalse(b As Boolean, ByRef failures As NumberReference)
		If b
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertTrue(b As Boolean, ByRef failures As NumberReference)
		If Not b
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertEquals(a As Double, b As Double, ByRef failures As NumberReference)
		If a <> b
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertBooleansEqual(a As Boolean, b As Boolean, ByRef failures As NumberReference)
		If a <> b
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertCharactersEqual(a As Char, b As Char, ByRef failures As NumberReference)
		If a <> b
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertStringEquals(ByRef a As Char (), ByRef b As Char (), ByRef failures As NumberReference)
		If Not arraysStringsEqual(a, b)
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertNumberArraysEqual(ByRef a As Double (), ByRef b As Double (), ByRef failures As NumberReference)
		Dim i As Double

		If a.Length = b.Length
			i = 0.0
			While i < a.Length
				Call AssertEquals(a(i), b(i), failures)
				i = i + 1.0
			End While
		Else
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertBooleanArraysEqual(ByRef a As Boolean (), ByRef b As Boolean (), ByRef failures As NumberReference)
		Dim i As Double

		If a.Length = b.Length
			i = 0.0
			While i < a.Length
				Call AssertBooleansEqual(a(i), b(i), failures)
				i = i + 1.0
			End While
		Else
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Sub AssertStringArraysEqual(ByRef a As StringReference (), ByRef b As StringReference (), ByRef failures As NumberReference)
		Dim i As Double

		If a.Length = b.Length
			i = 0.0
			While i < a.Length
				Call AssertStringEquals(a(i).stringx, b(i).stringx, failures)
				i = i + 1.0
			End While
		Else
			failures.numberValue = failures.numberValue + 1.0
		End If
	End Sub


	Public Function Negate(x As Double) As Double
		Return -x
	End Function


	Public Function Positive(x As Double) As Double
		Return +x
	End Function


	Public Function Factorial(x As Double) As Double
		Dim i, f As Double

		f = 1.0

		i = 2.0
		While i <= x
			f = f*i
			i = i + 1.0
		End While

		Return f
	End Function


	Public Function Roundx(x As Double) As Double
		Return Floor(x + 0.5)
	End Function


	Public Function RoundToDigits(element As Double, digitsAfterPoint As Double) As Double
		Return Roundx(element*10.0 ^ digitsAfterPoint)/10.0 ^ digitsAfterPoint
	End Function


	Public Function BankersRound(x As Double) As Double
		Dim r As Double

		If Absolute(x - Truncatex(x)) = 0.5
			If Not DivisibleBy(Roundx(x), 2.0)
				r = Roundx(x) - 1.0
			Else
				r = Roundx(x)
			End If
		Else
			r = Roundx(x)
		End If

		Return r
	End Function


	Public Function Ceil(x As Double) As Double
		Return Ceiling(x)
	End Function


	Public Function Floorx(x As Double) As Double
		Return Floor(x)
	End Function


	Public Function Truncatex(x As Double) As Double
		Dim t As Double

		If x >= 0.0
			t = Floor(x)
		Else
			t = Ceiling(x)
		End If

		Return t
	End Function


	Public Function Absolute(x As Double) As Double
		Return Abs(x)
	End Function


	Public Function Logarithm(x As Double) As Double
		Return Log10(x)
	End Function


	Public Function NaturalLogarithm(x As Double) As Double
		Return Log(x)
	End Function


	Public Function Sinx(x As Double) As Double
		Return Sin(x)
	End Function


	Public Function Cosx(x As Double) As Double
		Return Cos(x)
	End Function


	Public Function Tanx(x As Double) As Double
		Return Tan(x)
	End Function


	Public Function Asinx(x As Double) As Double
		Return Asin(x)
	End Function


	Public Function Acosx(x As Double) As Double
		Return Acos(x)
	End Function


	Public Function Atanx(x As Double) As Double
		Return Atan(x)
	End Function


	Public Function Atan2x(y As Double, x As Double) As Double
		Dim a As Double

		' Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.
		a = 0.0

		If x > 0.0
			a = Atanx(y/x)
		ElseIf x < 0.0 And y >= 0.0
			a = Atanx(y/x) + Pi
		ElseIf x < 0.0 And y < 0.0
			a = Atanx(y/x) - Pi
		ElseIf x = 0.0 And y > 0.0
			a = Pi/2.0
		ElseIf x = 0.0 And y < 0.0
			a = -Pi/2.0
		End If

		Return a
	End Function


	Public Function Squareroot(x As Double) As Double
		Return Sqrt(x)
	End Function


	Public Function Expx(x As Double) As Double
		Return Exp(x)
	End Function


	Public Function DivisibleBy(a As Double, b As Double) As Boolean
		Return ((a Mod b) = 0.0)
	End Function


	Public Function Combinations(n As Double, k As Double) As Double
		Dim i, j, c As Double

		c = 1.0
		j = 1.0
		i = n - k + 1.0

		
		While i <= n
			c = c*i
			c = c/j

			i = i + 1.0
			j = j + 1.0
		End While

		Return c
	End Function


	Public Function Permutations(n As Double, k As Double) As Double
		Dim i, c As Double

		c = 1.0

		i = n - k + 1.0
		While i <= n
			c = c*i
			i = i + 1.0
		End While

		Return c
	End Function


	Public Function EpsilonCompare(a As Double, b As Double, epsilon As Double) As Boolean
		Return Abs(a - b) < epsilon
	End Function


	Public Function GreatestCommonDivisor(a As Double, b As Double) As Double
		Dim t As Double

		
		While b <> 0.0
			t = b
			b = a Mod b
			a = t
		End While

		Return a
	End Function


	Public Function GCDWithSubtraction(a As Double, b As Double) As Double
		Dim g As Double

		If a = 0.0
			g = b
		Else
			
			While b <> 0.0
				If a > b
					a = a - b
				Else
					b = b - a
				End If
			End While

			g = a
		End If

		Return g
	End Function


	Public Function IsInteger(a As Double) As Boolean
		Return (a - Floor(a)) = 0.0
	End Function


	Public Function GreatestCommonDivisorWithCheck(a As Double, b As Double, ByRef gcdReference As NumberReference) As Boolean
		Dim success As Boolean
		Dim gcd As Double

		If IsInteger(a) And IsInteger(b)
			gcd = GreatestCommonDivisor(a, b)
			gcdReference.numberValue = gcd
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function LeastCommonMultiple(a As Double, b As Double) As Double
		Dim lcm As Double

		If a > 0.0 And b > 0.0
			lcm = Abs(a*b)/GreatestCommonDivisor(a, b)
		Else
			lcm = 0.0
		End If

		Return lcm
	End Function


	Public Function Signx(a As Double) As Double
		Dim s As Double

		If a > 0.0
			s = 1.0
		ElseIf a < 0.0
			s = -1.0
		Else
			s = 0.0
		End If

		Return s
	End Function


	Public Function Maxx(a As Double, b As Double) As Double
		Return Max(a, b)
	End Function


	Public Function Minx(a As Double, b As Double) As Double
		Return Min(a, b)
	End Function


	Public Function Power(a As Double, b As Double) As Double
		Return a ^ b
	End Function


	Public Function Gamma(x As Double) As Double
		Return LanczosApproximation(x)
	End Function


	Public Function LogGamma(x As Double) As Double
		Return Log(Gamma(x))
	End Function


	Public Function LanczosApproximation(z As Double) As Double
		Dim p As Double ()
		Dim i, y, t, x As Double

		p = New Double (8 - 1){}
		p(0) = 676.5203681218851
		p(1) = -1259.1392167224028
		p(2) = 771.32342877765313
		p(3) = -176.61502916214059
		p(4) = 12.507343278686905
		p(5) = -0.13857109526572012
		p(6) = 9.9843695780195716e-6
		p(7) = 1.5056327351493116e-7

		If z < 0.5
			y = Pi/(Sin(Pi*z)*LanczosApproximation(1.0 - z))
		Else
			z = z - 1.0
			x = 0.99999999999980993
			i = 0.0
			While i < p.Length
				x = x + p(i)/(z + i + 1.0)
				i = i + 1.0
			End While
			t = z + p.Length - 0.5
			y = Sqrt(2.0*Pi)*t ^ (z + 0.5)*Exp(-t)*x
		End If

		Return y
	End Function


	Public Function Beta(x As Double, y As Double) As Double
		Return Gamma(x)*Gamma(y)/Gamma(x + y)
	End Function


	Public Function Sinhx(x As Double) As Double
		Return (Exp(x) - Exp(-x))/2.0
	End Function


	Public Function Coshx(x As Double) As Double
		Return (Exp(x) + Exp(-x))/2.0
	End Function


	Public Function Tanhx(x As Double) As Double
		Return Sinhx(x)/Coshx(x)
	End Function


	Public Function Cot(x As Double) As Double
		Return 1.0/Tan(x)
	End Function


	Public Function Sec(x As Double) As Double
		Return 1.0/Cos(x)
	End Function


	Public Function Csc(x As Double) As Double
		Return 1.0/Sin(x)
	End Function


	Public Function Coth(x As Double) As Double
		Return Coshx(x)/Sinhx(x)
	End Function


	Public Function Sech(x As Double) As Double
		Return 1.0/Coshx(x)
	End Function


	Public Function Csch(x As Double) As Double
		Return 1.0/Sinhx(x)
	End Function


	Public Function Errorx(x As Double) As Double
		Dim y, t, tau, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 As Double

		If x = 0.0
			y = 0.0
		ElseIf x < 0.0
			y = -Errorx(-x)
		Else
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

			t = 1.0/(1.0 + 0.5*Abs(x))

			tau = t*Exp(-x ^ 2.0 + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))))

			y = 1.0 - tau
		End If

		Return y
	End Function


	Public Function ErrorInverse(x As Double) As Double
		Dim y, a, t As Double

		a = (8.0*(Pi - 3.0))/(3.0*Pi*(4.0 - Pi))

		t = 2.0/(Pi*a) + Log(1.0 - x ^ 2.0)/2.0
		y = Signx(x)*Sqrt(Sqrt(t ^ 2.0 - Log(1.0 - x ^ 2.0)/a) - t)

		Return y
	End Function


	Public Function FallingFactorial(x As Double, n As Double) As Double
		Dim k, y As Double

		y = 1.0

		k = 0.0
		While k <= n - 1.0
			y = y*(x - k)
			k = k + 1.0
		End While

		Return y
	End Function


	Public Function RisingFactorial(x As Double, n As Double) As Double
		Dim k, y As Double

		y = 1.0

		k = 0.0
		While k <= n - 1.0
			y = y*(x + k)
			k = k + 1.0
		End While

		Return y
	End Function


	Public Function Hypergeometric(a As Double, b As Double, c As Double, z As Double, maxIterations As Double, precision As Double) As Double
		Dim y As Double

		If Abs(z) >= 0.5
			y = (1.0 - z) ^ (-a)*HypergeometricDirect(a, c - b, c, z/(z - 1.0), maxIterations, precision)
		Else
			y = HypergeometricDirect(a, b, c, z, maxIterations, precision)
		End If

		Return y
	End Function


	Public Function HypergeometricDirect(a As Double, b As Double, c As Double, z As Double, maxIterations As Double, precision As Double) As Double
		Dim y, yp, n As Double
		Dim done As Boolean

		y = 0.0
		done = false

		n = 0.0
		While n < maxIterations And Not done
			yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*z ^ n/Factorial(n)
			If Abs(yp) < precision
				done = true
			End If
			y = y + yp
			n = n + 1.0
		End While

		Return y
	End Function


	Public Function BernouilliNumber(n As Double) As Double
		Return AkiyamaTanigawaAlgorithm(n)
	End Function


	Public Function AkiyamaTanigawaAlgorithm(n As Double) As Double
		Dim m, j, B As Double
		Dim A As Double ()

		A = New Double (n + 1.0 - 1){}

		m = 0.0
		While m <= n
			A(m) = 1.0/(m + 1.0)
			j = m
			While j >= 1.0
				A(j - 1.0) = j*(A(j - 1.0) - A(j))
				j = j - 1.0
			End While
			m = m + 1.0
		End While

		B = A(0)

		Erase A 

		Return B
	End Function


	Public Function D15Add(a As Double, b As Double, ByRef overflow As BooleanReference) As Double
		Dim x As Double

		x = a + b

		If x > D15MaxValue() Or x < D15MinValue()
			overflow.booleanValue = true
			x = 0.0
		Else
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function RoundTo15Digits(x As Double) As Double
		Dim p As Double

		p = Floor(Log10(x))
		x = x*10.0 ^ (15.0 - p)
		x = Roundx(x)
		x = x/10.0 ^ (15.0 - p)

		Return x
	End Function


	Public Function D15MaxValue() As Double
		Return +9.99999999999999e99
	End Function


	Public Function D15MinValue() As Double
		Return -9.99999999999999e99
	End Function


	Public Function D15Multiply(a As Double, b As Double, ByRef overflow As BooleanReference) As Double
		Dim x As Double

		x = a*b

		If x > D15MaxValue() Or x < D15MinValue()
			overflow.booleanValue = true
			x = 0.0
		Else
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15Divide(a As Double, b As Double, ByRef reminder As NumberReference, ByRef overflow As BooleanReference, ByRef invalidOperation As BooleanReference) As Double
		Dim x, r As Double

		If b <> 0.0
			invalidOperation.booleanValue = false

			x = a/b
			r = a Mod b

			If x > D15MaxValue() Or x < D15MinValue()
				overflow.booleanValue = true
				x = 0.0
				r = 0.0
			Else
				overflow.booleanValue = false
				x = RoundTo15Digits(x)
				r = RoundTo15Digits(r)
			End If
		Else
			invalidOperation.booleanValue = true
			overflow.booleanValue = false
			x = 0.0
			r = 0.0
		End If

		reminder.numberValue = r

		Return x
	End Function


	Public Function D15Exponentiation(a As Double, b As Double, ByRef overflow As BooleanReference, ByRef invalidOperation As BooleanReference) As Double
		Dim x As Double

		If a = 0.0 And b = 0.0
			invalidOperation.booleanValue = true
			overflow.booleanValue = false
			x = 0.0
		ElseIf a < 0.0 And Not IsInteger(b)
			invalidOperation.booleanValue = true
			overflow.booleanValue = false
			x = 0.0
		Else
			invalidOperation.booleanValue = false

			x = a ^ b

			If x > D15MaxValue() Or x < D15MinValue()
				overflow.booleanValue = true
				x = 0.0
			Else
				overflow.booleanValue = false
				x = RoundTo15Digits(x)
			End If
		End If

		Return x
	End Function


	Public Function D15Modulus(a As Double, b As Double, ByRef invalidOperation As BooleanReference) As Double
		Dim x As Double

		If a < 0.0 Or b = 0.0 Or b < 0.0
			invalidOperation.booleanValue = true
			x = 0.0
		Else
			invalidOperation.booleanValue = false
			x = a Mod b
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15Logarithm(a As Double, ByRef invalidOperation As BooleanReference) As Double
		Dim x As Double

		If a <= 0.0
			invalidOperation.booleanValue = true
			x = 0.0
		Else
			invalidOperation.booleanValue = false
			x = Log10(a)
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15NaturalLogarithm(a As Double, ByRef invalidOperation As BooleanReference) As Double
		Dim x As Double

		If a <= 0.0
			invalidOperation.booleanValue = true
			x = 0.0
		Else
			invalidOperation.booleanValue = false
			x = Log(a)
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15Sin(a As Double) As Double
		Dim x As Double

		x = Sin(a)
		x = RoundTo15Digits(x)

		Return x
	End Function


	Public Function D15Cos(x As Double) As Double
		Dim a, y, piBy2Part1, piBy2Part2, limit, f As Double

		x = Abs(x)

		limit = Pi + 3.1/2.0

		If x > limit
			f = Floor(x/Pi)
			x = x - Pi*f
		End If

		piBy2Part1 = +1.57079632679490
		piBy2Part2 = -3.38076867830836e-15

		If x > 3.1/2.0 And x < 3.3/2.0
			a = x - piBy2Part1
			a = Round(a*10.0 ^ 15.0)/10.0 ^ 15.0
			a = a - piBy2Part2
			y = -Sin(a)
		Else
			y = Cos(x)
			y = RoundTo15Digits(y)
		End If

		Return y
	End Function


	Public Function D15Tan(a As Double, ByRef overflow As BooleanReference) As Double
		Dim x As Double

		x = Tan(a)

		If x > D15MaxValue() Or x < D15MinValue()
			overflow.booleanValue = true
			x = 0.0
		Else
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15Asin(a As Double, ByRef invalidOperation As BooleanReference) As Double
		Dim x As Double

		If a < -1.0 Or a > 1.0
			invalidOperation.booleanValue = true
			x = 0.0
		Else
			invalidOperation.booleanValue = false
			x = Asin(a)
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15Acos(a As Double, ByRef invalidOperation As BooleanReference) As Double
		Dim x As Double

		If a < -1.0 Or a > 1.0
			invalidOperation.booleanValue = true
			x = 0.0
		Else
			invalidOperation.booleanValue = false
			x = Acos(a)
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function D15Atan(a As Double) As Double
		Dim x As Double

		x = Atan(a)
		x = RoundTo15Digits(x)

		Return x
	End Function


	Public Function D15Sqrt(a As Double) As Double
		Dim x As Double

		x = Sqrt(a)
		x = RoundTo15Digits(x)

		Return x
	End Function


	Public Function D15Exponential(a As Double, ByRef overflow As BooleanReference) As Double
		Dim x As Double

		x = Exp(a)

		If x > D15MaxValue() Or x < D15MinValue()
			overflow.booleanValue = true
			x = 0.0
		Else
			overflow.booleanValue = false
			x = RoundTo15Digits(x)
		End If

		Return x
	End Function


	Public Function Decimal15E2ToString(decimalx As Double) As Char ()
		Dim multiplier, inc, i, d As Double
		Dim exponent As Double
		Dim done, isPositive, isPositiveExponent As Boolean
		Dim result As Char ()
		Dim len As Double

		len = 21.0
		' 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"
		result = New Char (len - 1){}

		done = false
		exponent = 0.0

		If decimalx < 0.0
			isPositive = false
			decimalx = -decimalx
		Else
			isPositive = true
		End If

		If decimalx = 0.0
			done = true
		End If

		If Not done
			multiplier = 0.0
			inc = 0.0

			If decimalx < 1.0
				multiplier = 10.0
				inc = -1.0
			ElseIf decimalx >= 10.0
				multiplier = 0.1
				inc = 1.0
			Else
				done = true
			End If

			If Not done
				exponent = Round(Log10(decimalx))
				exponent = Min(99.0, exponent)
				exponent = Max(-99.0, exponent)

				decimalx = decimalx/10.0 ^ exponent

				' Adjust
				
				While (decimalx >= 10.0 Or decimalx < 1.0) And Abs(exponent) < 99.0
					decimalx = decimalx*multiplier
					exponent = exponent + inc
				End While
			End If
		End If

		isPositiveExponent = exponent >= 0.0
		If Not isPositiveExponent
			exponent = -exponent
		End If

		If isPositive
			result(0) = "+"C
		Else
			result(0) = "-"C
		End If

		decimalx = Round(decimalx*10.0 ^ 14.0)

		d = Floor(decimalx/10.0 ^ 14.0)
		result(1) = SingleDigitNumberToCharacter(d)
		decimalx = decimalx - d*10.0 ^ 14.0

		result(2) = "."C

		i = 0.0
		While i < 14.0
			d = Floor(decimalx/10.0 ^ (13.0 - i))
			result(3.0 + i) = SingleDigitNumberToCharacter(d)
			decimalx = decimalx - d*10.0 ^ (13.0 - i)
			i = i + 1.0
		End While

		result(17) = "e"C

		If isPositiveExponent
			result(18) = "+"C
		Else
			result(18) = "-"C
		End If

		result(19) = SingleDigitNumberToCharacter(Floor(exponent/10.0))
		result(20) = SingleDigitNumberToCharacter(Floor(exponent Mod 10.0))

		Return result
	End Function


	Public Function SingleDigitNumberToCharacter(n As Double) As Char
		Dim c As Char

		c = "0"C
		If n = 0.0
			c = "0"C
		ElseIf n = 1.0
			c = "1"C
		ElseIf n = 2.0
			c = "2"C
		ElseIf n = 3.0
			c = "3"C
		ElseIf n = 4.0
			c = "4"C
		ElseIf n = 5.0
			c = "5"C
		ElseIf n = 6.0
			c = "6"C
		ElseIf n = 7.0
			c = "7"C
		ElseIf n = 8.0
			c = "8"C
		ElseIf n = 9.0
			c = "9"C
		End If

		Return c
	End Function


	Public Function cToLowerCase(character As Char) As Char
		Dim toReturn As Char

		toReturn = character
		If character = "A"C
			toReturn = "a"C
		ElseIf character = "B"C
			toReturn = "b"C
		ElseIf character = "C"C
			toReturn = "c"C
		ElseIf character = "D"C
			toReturn = "d"C
		ElseIf character = "E"C
			toReturn = "e"C
		ElseIf character = "F"C
			toReturn = "f"C
		ElseIf character = "G"C
			toReturn = "g"C
		ElseIf character = "H"C
			toReturn = "h"C
		ElseIf character = "I"C
			toReturn = "i"C
		ElseIf character = "J"C
			toReturn = "j"C
		ElseIf character = "K"C
			toReturn = "k"C
		ElseIf character = "L"C
			toReturn = "l"C
		ElseIf character = "M"C
			toReturn = "m"C
		ElseIf character = "N"C
			toReturn = "n"C
		ElseIf character = "O"C
			toReturn = "o"C
		ElseIf character = "P"C
			toReturn = "p"C
		ElseIf character = "Q"C
			toReturn = "q"C
		ElseIf character = "R"C
			toReturn = "r"C
		ElseIf character = "S"C
			toReturn = "s"C
		ElseIf character = "T"C
			toReturn = "t"C
		ElseIf character = "U"C
			toReturn = "u"C
		ElseIf character = "V"C
			toReturn = "v"C
		ElseIf character = "W"C
			toReturn = "w"C
		ElseIf character = "X"C
			toReturn = "x"C
		ElseIf character = "Y"C
			toReturn = "y"C
		ElseIf character = "Z"C
			toReturn = "z"C
		End If

		Return toReturn
	End Function


	Public Function cToUpperCase(character As Char) As Char
		Dim toReturn As Char

		toReturn = character
		If character = "a"C
			toReturn = "A"C
		ElseIf character = "b"C
			toReturn = "B"C
		ElseIf character = "c"C
			toReturn = "C"C
		ElseIf character = "d"C
			toReturn = "D"C
		ElseIf character = "e"C
			toReturn = "E"C
		ElseIf character = "f"C
			toReturn = "F"C
		ElseIf character = "g"C
			toReturn = "G"C
		ElseIf character = "h"C
			toReturn = "H"C
		ElseIf character = "i"C
			toReturn = "I"C
		ElseIf character = "j"C
			toReturn = "J"C
		ElseIf character = "k"C
			toReturn = "K"C
		ElseIf character = "l"C
			toReturn = "L"C
		ElseIf character = "m"C
			toReturn = "M"C
		ElseIf character = "n"C
			toReturn = "N"C
		ElseIf character = "o"C
			toReturn = "O"C
		ElseIf character = "p"C
			toReturn = "P"C
		ElseIf character = "q"C
			toReturn = "Q"C
		ElseIf character = "r"C
			toReturn = "R"C
		ElseIf character = "s"C
			toReturn = "S"C
		ElseIf character = "t"C
			toReturn = "T"C
		ElseIf character = "u"C
			toReturn = "U"C
		ElseIf character = "v"C
			toReturn = "V"C
		ElseIf character = "w"C
			toReturn = "W"C
		ElseIf character = "x"C
			toReturn = "X"C
		ElseIf character = "y"C
			toReturn = "Y"C
		ElseIf character = "z"C
			toReturn = "Z"C
		End If

		Return toReturn
	End Function


	Public Function cIsUpperCase(character As Char) As Boolean
		Dim isUpper As Boolean

		isUpper = true
		If character = "A"C
		ElseIf character = "B"C
		ElseIf character = "C"C
		ElseIf character = "D"C
		ElseIf character = "E"C
		ElseIf character = "F"C
		ElseIf character = "G"C
		ElseIf character = "H"C
		ElseIf character = "I"C
		ElseIf character = "J"C
		ElseIf character = "K"C
		ElseIf character = "L"C
		ElseIf character = "M"C
		ElseIf character = "N"C
		ElseIf character = "O"C
		ElseIf character = "P"C
		ElseIf character = "Q"C
		ElseIf character = "R"C
		ElseIf character = "S"C
		ElseIf character = "T"C
		ElseIf character = "U"C
		ElseIf character = "V"C
		ElseIf character = "W"C
		ElseIf character = "X"C
		ElseIf character = "Y"C
		ElseIf character = "Z"C
		Else
			isUpper = false
		End If

		Return isUpper
	End Function


	Public Function cIsLowerCase(character As Char) As Boolean
		Dim isLower As Boolean

		isLower = true
		If character = "a"C
		ElseIf character = "b"C
		ElseIf character = "c"C
		ElseIf character = "d"C
		ElseIf character = "e"C
		ElseIf character = "f"C
		ElseIf character = "g"C
		ElseIf character = "h"C
		ElseIf character = "i"C
		ElseIf character = "j"C
		ElseIf character = "k"C
		ElseIf character = "l"C
		ElseIf character = "m"C
		ElseIf character = "n"C
		ElseIf character = "o"C
		ElseIf character = "p"C
		ElseIf character = "q"C
		ElseIf character = "r"C
		ElseIf character = "s"C
		ElseIf character = "t"C
		ElseIf character = "u"C
		ElseIf character = "v"C
		ElseIf character = "w"C
		ElseIf character = "x"C
		ElseIf character = "y"C
		ElseIf character = "z"C
		Else
			isLower = false
		End If

		Return isLower
	End Function


	Public Function cIsLetter(character As Char) As Boolean
		Return cIsUpperCase(character) Or cIsLowerCase(character)
	End Function


	Public Function cIsNumber(character As Char) As Boolean
		Dim isNumberx As Boolean

		isNumberx = true
		If character = "0"C
		ElseIf character = "1"C
		ElseIf character = "2"C
		ElseIf character = "3"C
		ElseIf character = "4"C
		ElseIf character = "5"C
		ElseIf character = "6"C
		ElseIf character = "7"C
		ElseIf character = "8"C
		ElseIf character = "9"C
		Else
			isNumberx = false
		End If

		Return isNumberx
	End Function


	Public Function cIsWhiteSpace(character As Char) As Boolean
		Dim isWhiteSpacex As Boolean

		isWhiteSpacex = true
		If character = " "C
		ElseIf character = vbTab
		ElseIf character = vblf
		ElseIf character = vbcr
		Else
			isWhiteSpacex = false
		End If

		Return isWhiteSpacex
	End Function


	Public Function cIsSymbol(character As Char) As Boolean
		Dim isSymbolx As Boolean

		isSymbolx = true
		If character = "!"C
		ElseIf character = """"C
		ElseIf character = "#"C
		ElseIf character = "$"C
		ElseIf character = "%"C
		ElseIf character = "&"C
		ElseIf character = "'"C
		ElseIf character = "("C
		ElseIf character = ")"C
		ElseIf character = "*"C
		ElseIf character = "+"C
		ElseIf character = ","C
		ElseIf character = "-"C
		ElseIf character = "."C
		ElseIf character = "/"C
		ElseIf character = ":"C
		ElseIf character = ";"C
		ElseIf character = "<"C
		ElseIf character = "="C
		ElseIf character = ">"C
		ElseIf character = "?"C
		ElseIf character = "@"C
		ElseIf character = "["C
		ElseIf character = "\"C
		ElseIf character = "]"C
		ElseIf character = "^"C
		ElseIf character = "_"C
		ElseIf character = "`"C
		ElseIf character = "{"C
		ElseIf character = "|"C
		ElseIf character = "}"C
		ElseIf character = "~"C
		Else
			isSymbolx = false
		End If

		Return isSymbolx
	End Function


	Public Function cCharacterIsBefore(a As Char, b As Char) As Boolean
		Dim ad, bd As Double

		ad = Convert.ToInt16(a)
		bd = Convert.ToInt16(b)

		Return ad < bd
	End Function


	Public Function cDecimalDigitToCharacter(digit As Double) As Char
		Dim c As Char
		If digit = 1.0
			c = "1"C
		ElseIf digit = 2.0
			c = "2"C
		ElseIf digit = 3.0
			c = "3"C
		ElseIf digit = 4.0
			c = "4"C
		ElseIf digit = 5.0
			c = "5"C
		ElseIf digit = 6.0
			c = "6"C
		ElseIf digit = 7.0
			c = "7"C
		ElseIf digit = 8.0
			c = "8"C
		ElseIf digit = 9.0
			c = "9"C
		Else
			c = "0"C
		End If
		Return c
	End Function


	Public Function cCharacterToDecimalDigit(c As Char) As Double
		Dim digit As Double

		If c = "1"C
			digit = 1.0
		ElseIf c = "2"C
			digit = 2.0
		ElseIf c = "3"C
			digit = 3.0
		ElseIf c = "4"C
			digit = 4.0
		ElseIf c = "5"C
			digit = 5.0
		ElseIf c = "6"C
			digit = 6.0
		ElseIf c = "7"C
			digit = 7.0
		ElseIf c = "8"C
			digit = 8.0
		ElseIf c = "9"C
			digit = 9.0
		Else
			digit = 0.0
		End If

		Return digit
	End Function


End Module

