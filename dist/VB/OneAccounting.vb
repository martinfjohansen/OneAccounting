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

Public Class Sections
	Public codes As Char ()
	Public counts As Double ()
End Class

Public Class RGBABitmapImageReference
	Public image As RGBABitmapImage
End Class

Public Class Success
	Public feilmelding As Char ()
	Public success As Boolean
End Class

Public Class RGBABitmapImageReference
	Public image As RGBABitmapImage
End Class

Public Class Rectangle
	Public x1 As Double
	Public x2 As Double
	Public y1 As Double
	Public y2 As Double
End Class

Public Class ScatterPlotSeries
	Public linearInterpolation As Boolean
	Public pointType As Char ()
	Public lineType As Char ()
	Public lineThickness As Double
	Public xs As Double ()
	Public ys As Double ()
	Public color As RGBA
End Class

Public Class ScatterPlotSettings
	Public scatterPlotSeries As ScatterPlotSeries ()
	Public autoBoundaries As Boolean
	Public xMax As Double
	Public xMin As Double
	Public yMax As Double
	Public yMin As Double
	Public autoPadding As Boolean
	Public xPadding As Double
	Public yPadding As Double
	Public xLabel As Char ()
	Public yLabel As Char ()
	Public title As Char ()
	Public showGrid As Boolean
	Public gridColor As RGBA
	Public xAxisAuto As Boolean
	Public xAxisTop As Boolean
	Public xAxisBottom As Boolean
	Public yAxisAuto As Boolean
	Public yAxisLeft As Boolean
	Public yAxisRight As Boolean
	Public width As Double
	Public height As Double
End Class

Public Class BarPlotSeries
	Public ys As Double ()
	Public color As RGBA
End Class

Public Class BarPlotSettings
	Public width As Double
	Public height As Double
	Public autoBoundaries As Boolean
	Public yMax As Double
	Public yMin As Double
	Public autoPadding As Boolean
	Public xPadding As Double
	Public yPadding As Double
	Public title As Char ()
	Public showGrid As Boolean
	Public gridColor As RGBA
	Public barPlotSeries As BarPlotSeries ()
	Public yLabel As Char ()
	Public autoColor As Boolean
	Public grayscaleAutoColor As Boolean
	Public autoSpacing As Boolean
	Public groupSeparation As Double
	Public barSeparation As Double
	Public autoLabels As Boolean
	Public xLabels As StringReference ()
	Public barBorder As Boolean
End Class

Public Class ArbitraryPrecisionInteger
	Public signx As Boolean
	Public number As UnsignedInteger
End Class

Public Class ArbitraryPrecisionFixedPointNumber
	Public baseNumber As ArbitraryPrecisionInteger
	Public pointPosition As Double
End Class

Public Class UnsignedInteger
	Public digits As Double ()
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

Public Class RGBA
	Public r As Double
	Public g As Double
	Public b As Double
	Public a As Double
End Class

Public Class RGBABitmap
	Public y As RGBA ()
End Class

Public Class RGBABitmapImage
	Public x As RGBABitmap ()
End Class

Public Class Matrix
	Public r As MatrixRow ()
End Class

Public Class MatrixArrayReference
	Public matrices As Matrix ()
End Class

Public Class MatrixReference
	Public matrix As Matrix
End Class

Public Class MatrixRow
	Public c As Double ()
End Class

Public Class ComplexMatrix
	Public r As ComplexMatrixRow ()
End Class

Public Class ComplexMatrixArrayReference
	Public matrices As ComplexMatrix ()
End Class

Public Class ComplexMatrixReference
	Public matrix As ComplexMatrix
End Class

Public Class ComplexMatrixRow
	Public c As cComplexNumber ()
End Class

Public Class LinearCongruentialGenerator
	Public x As Double
	Public a As Double
	Public c As Double
	Public m As Double
End Class

Public Class PseudorandomGenerator
	Public lcg As LinearCongruentialGenerator
End Class

Public Class cComplexNumber
	Public re As Double
	Public im As Double
End Class

Public Class cComplexNumberArrayReference
	Public complexNumbers As cComplexNumber ()
End Class

Public Class cComplexNumberReference
	Public complexNumbers As cComplexNumber
End Class

Public Class cPolarComplexNumber
	Public r As Double
	Public phi As Double
End Class

Public Class pComplexPolynomial
	Public cs As cComplexNumber ()
End Class

Module OneAccounting
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
		Dim valid, success As Boolean
		Dim datex As Datex
		Dim c, d As FixedPoint15d
		Dim message As StringReference

		message = New StringReference()

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

			success = AddMonthsToDate(datex, 1.0, message)
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


	Public Function LuhnCheck(ByRef number As Char (), ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean
		Dim numberReference As StringReference
		Dim checkDigitReference As CharacterReference
		Dim numberString As Char ()
		Dim digitReference As NumberReference

		numberReference = New StringReference()
		checkDigitReference = New CharacterReference()
		numberString = New Char (1 - 1){}
		digitReference = New NumberReference()

		isValid = arraysCopyStringRange(number, 0.0, number.Length - 1.0, numberReference)
		If isValid
			isValid = LuhnComputeCheckDigit(numberReference.stringx, checkDigitReference, errorMessage)
			If isValid
				If checkDigitReference.characterValue = number(number.Length - 1.0)
				Else
					numberString(0) = number(number.Length - 1.0)
					isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage)
					If isValid
						errorMessage.stringx = "Check digit wrong.".ToCharArray()
					Else
						errorMessage.stringx = "Check symbol not a digit.".ToCharArray()
					End If
					isValid = false
				End If
			End If
		Else
			errorMessage.stringx = "Number is too short: must be at least one digit.".ToCharArray()
		End If

		Return isValid
	End Function


	Public Function LuhnComputeCheckDigit(ByRef number As Char (), ByRef checkDigitReference As CharacterReference, ByRef errorMessage As StringReference) As Boolean
		Dim sum, n, i, check As Double
		Dim alternate, isValid As Boolean
		Dim numberReference As NumberReference
		Dim numberString As Char ()

		sum = 0.0
		alternate = true
		numberString = New Char (1 - 1){}
		numberReference = New NumberReference()
		isValid = true

		i = number.Length - 1.0
		While i >= 0.0 And isValid
			numberString(0) = number(i)
			isValid = CreateNumberFromDecimalStringWithCheck(numberString, numberReference, errorMessage)
			If isValid
				n = numberReference.numberValue
				If alternate
					n = n*2.0
					If n > 9.0
						n = (n Mod 10.0) + 1.0
					End If
				End If
				sum = sum + n
				alternate = Not alternate
			Else
				errorMessage.stringx = "Invalid digit in number string.".ToCharArray()
			End If
			i = i - 1.0
		End While

		If isValid
			check = sum Mod 10.0

			If check <> 0.0
				check = 10.0 - check
			End If

			GetSingleDigitCharacterFromNumberWithCheck(check, 10.0, checkDigitReference)
		End If

		Return isValid
	End Function


	Public Function LuhnExtendWithCheckDigit(ByRef number As Char (), ByRef extended As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean
		Dim i As Double
		Dim checkDigitReference As CharacterReference

		checkDigitReference = New CharacterReference()
		isValid = LuhnComputeCheckDigit(number, checkDigitReference, errorMessage)

		If isValid
			extended.stringx = New Char (number.Length + 1.0 - 1){}
			i = 0.0
			While i < number.Length
				extended.stringx(i) = number(i)
				i = i + 1.0
			End While
			extended.stringx(i) = checkDigitReference.characterValue
		End If

		Return isValid
	End Function


	Public Function ISINCheck(ByRef isin As Char (), ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean
		Dim numberReference As StringReference
		Dim checkDigitReference As CharacterReference
		Dim numberString As Char ()
		Dim digitReference As NumberReference

		numberReference = New StringReference()
		checkDigitReference = New CharacterReference()
		numberString = New Char (1 - 1){}
		digitReference = New NumberReference()

		If isin.Length = 12.0
			arraysCopyStringRange(isin, 0.0, isin.Length - 1.0, numberReference)

			isValid = ISINComputeCheckDigit(numberReference.stringx, checkDigitReference, errorMessage)
			If isValid
				If checkDigitReference.characterValue = isin(isin.Length - 1.0)
				Else
					numberString(0) = isin(isin.Length - 1.0)
					isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage)
					If isValid
						errorMessage.stringx = "Check digit wrong.".ToCharArray()
					Else
						errorMessage.stringx = "Check symbol not a digit.".ToCharArray()
					End If
					isValid = false
				End If
			End If
		Else
			isValid = false
			errorMessage.stringx = "ISIN must be 12 alpha-numeric characters.".ToCharArray()
		End If

		Return isValid
	End Function


	Public Function ISINComputeCheckDigit(ByRef isin As Char (), ByRef checkDigitReference As CharacterReference, ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean
		Dim isinNumericReference As StringReference

		isinNumericReference = New StringReference()

		If isin.Length = 11.0
			isValid = ISINToNumericCode(isin, isinNumericReference, errorMessage)

			If isValid
				LuhnComputeCheckDigit(isinNumericReference.stringx, checkDigitReference, errorMessage)
			End If
		Else
			isValid = false
			errorMessage.stringx = "ISIN must be 11 digits before the checksum digit to be calculated.".ToCharArray()
		End If

		Return isValid
	End Function


	Public Function ISINExtendWithCheckDigit(ByRef isin As Char (), ByRef extended As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean
		Dim i As Double
		Dim checkDigitReference As CharacterReference

		checkDigitReference = New CharacterReference()
		isValid = ISINComputeCheckDigit(isin, checkDigitReference, errorMessage)

		If isValid
			extended.stringx = New Char (isin.Length + 1.0 - 1){}
			i = 0.0
			While i < isin.Length
				extended.stringx(i) = isin(i)
				i = i + 1.0
			End While
			extended.stringx(i) = checkDigitReference.characterValue
		End If

		Return isValid
	End Function


	Public Function ISINToNumericCode(ByRef isin As Char (), ByRef isinNumericReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean
		Dim length, i, pos As Double
		Dim code As StringReference

		isValid = true
		code = New StringReference()

		length = 0.0

		i = 0.0
		While i < isin.Length And isValid
			If cIsLetter(isin(i))
				length = length + 2.0
			ElseIf cIsNumber(isin(i))
				length = length + 1.0
			Else
				isValid = false
				errorMessage.stringx = "ISIN can only contain alpha-numeric characters.".ToCharArray()
			End If
			i = i + 1.0
		End While

		If isValid
			isinNumericReference.stringx = New Char (length - 1){}

			pos = 0.0

			i = 0.0
			While i < isin.Length
				ISINSymbolToCode(isin(i), code, errorMessage)

				isinNumericReference.stringx(pos) = code.stringx(0)
				pos = pos + 1.0
				If code.stringx.Length = 2.0
					isinNumericReference.stringx(pos) = code.stringx(1)
					pos = pos + 1.0
				End If
				i = i + 1.0
			End While
		End If

		Return isValid
	End Function


	Public Function ISINSymbolToCode(c As Char, ByRef stringReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim isValid As Boolean

		If cIsLetter(c) And cIsUpperCase(c)
			If c = "A"C
				stringReference.stringx = "10".ToCharArray()
			ElseIf c = "B"C
				stringReference.stringx = "11".ToCharArray()
			ElseIf c = "C"C
				stringReference.stringx = "12".ToCharArray()
			ElseIf c = "D"C
				stringReference.stringx = "13".ToCharArray()
			ElseIf c = "E"C
				stringReference.stringx = "14".ToCharArray()
			ElseIf c = "F"C
				stringReference.stringx = "15".ToCharArray()
			ElseIf c = "G"C
				stringReference.stringx = "16".ToCharArray()
			ElseIf c = "H"C
				stringReference.stringx = "17".ToCharArray()
			ElseIf c = "I"C
				stringReference.stringx = "18".ToCharArray()
			ElseIf c = "J"C
				stringReference.stringx = "19".ToCharArray()
			ElseIf c = "K"C
				stringReference.stringx = "20".ToCharArray()
			ElseIf c = "L"C
				stringReference.stringx = "21".ToCharArray()
			ElseIf c = "M"C
				stringReference.stringx = "22".ToCharArray()
			ElseIf c = "N"C
				stringReference.stringx = "23".ToCharArray()
			ElseIf c = "O"C
				stringReference.stringx = "24".ToCharArray()
			ElseIf c = "P"C
				stringReference.stringx = "25".ToCharArray()
			ElseIf c = "Q"C
				stringReference.stringx = "26".ToCharArray()
			ElseIf c = "R"C
				stringReference.stringx = "27".ToCharArray()
			ElseIf c = "S"C
				stringReference.stringx = "28".ToCharArray()
			ElseIf c = "T"C
				stringReference.stringx = "29".ToCharArray()
			ElseIf c = "U"C
				stringReference.stringx = "30".ToCharArray()
			ElseIf c = "V"C
				stringReference.stringx = "31".ToCharArray()
			ElseIf c = "W"C
				stringReference.stringx = "32".ToCharArray()
			ElseIf c = "X"C
				stringReference.stringx = "33".ToCharArray()
			ElseIf c = "Y"C
				stringReference.stringx = "34".ToCharArray()
			ElseIf c = "Z"C
				stringReference.stringx = "35".ToCharArray()
			End If

			isValid = true
		ElseIf cIsNumber(c)
			If c = "0"C
				stringReference.stringx = "0".ToCharArray()
			ElseIf c = "1"C
				stringReference.stringx = "1".ToCharArray()
			ElseIf c = "2"C
				stringReference.stringx = "2".ToCharArray()
			ElseIf c = "3"C
				stringReference.stringx = "3".ToCharArray()
			ElseIf c = "4"C
				stringReference.stringx = "4".ToCharArray()
			ElseIf c = "5"C
				stringReference.stringx = "5".ToCharArray()
			ElseIf c = "6"C
				stringReference.stringx = "6".ToCharArray()
			ElseIf c = "7"C
				stringReference.stringx = "7".ToCharArray()
			ElseIf c = "8"C
				stringReference.stringx = "8".ToCharArray()
			ElseIf c = "9"C
				stringReference.stringx = "9".ToCharArray()
			End If

			isValid = true
		Else
			isValid = false
			errorMessage.stringx = "Character is not an ISIN alpha-character.".ToCharArray()
		End If

		Return isValid
	End Function


	Public Function GenerateBarcodeEAN13(ByRef code As Char (), widthInMm As Double, heightInMm As Double, pixelsPerMm As Double) As RGBABitmapImage
		Dim w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone As Double
		Dim charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100 As Double
		Dim c, type, character As Char
		Dim image, uninterpolatedBarcode, barcode As RGBABitmapImage
		Dim widths, group1Pattern, symbolWidths As Char ()
		Dim counterReference As NumberReference
		Dim characterReference As CharacterReference

		h = Roundx(heightInMm*pixelsPerMm)
		w = Roundx(widthInMm*pixelsPerMm)

		image = CreateImage(w, h, GetWhite())

		zoom100 = (11.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0*6.0 + 7.0)*0.33

		zoom = widthInMm/zoom100
		textheight = zoom*3.08
		charwidth = textheight*30.0/37.0
		textQuietZone = textheight*5.0/100.0
		textY = h - textheight*pixelsPerMm
		shortHeight = textY - textQuietZone*pixelsPerMm
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
		moduleWidthPixels = 0.33*zoom*pixelsPerMm
		moduleWidthWholePixels = Floor(moduleWidthPixels)
		leftQuietZoneWholePixels = 11.0*moduleWidthWholePixels
		leftQuietZonePixels = 11.0*moduleWidthPixels
		group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
		distanceToSecondGroup = group1x + (7.0*6.0 + 4.0)*moduleWidthPixels
		betweenCharatcers = charwidth*92.0/100.0*pixelsPerMm

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

		counterReference = CreateNumberReference(leftQuietZoneWholePixels)

		group1Pattern = GetEAN13Group1Pattern(code(0))

		' Start symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		i = 1.0
		While i < code.Length
			c = code(i)
			If i <= 6.0
				type = group1Pattern(i - 1.0)
				If type = "L"C
					widths = GetUPCLCodeWidths(c)
				Else
					widths = GetUPCGCodeWidths(c)
				End If
			Else
				widths = GetUPCRCodeWidths(c)
			End If
			Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

			If i = 6.0
				symbolWidths = GetUPCWidths(11.0)
				Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
			End If
			i = i + 1.0
		End While

		' Checksum
		checksum = GetCalculateUPCChecksum(code)
		characterReference = New CharacterReference()
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
		character = characterReference.characterValue
		characterReference = Nothing
		symbolWidths = GetUPCRCodeWidths(character)
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels)

		' Stop symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
		Call DrawImageOnImage(image, barcode, 0.0, 0.0)

		' Draw digits
		i = 0.0
		While i < code.Length
			digit = GetNumberFromNumberCharacterForBase(code(i), 10.0)
			If i = 0.0
				Call DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
			ElseIf i <= 6.0
				Call DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			Else
				Call DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			End If
			i = i + 1.0
		End While
		Call DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

		Return image
	End Function


	Public Function GetEAN13Group1Pattern(code As Char) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = "0"C
			spaces = "LLLLLL".ToCharArray()
		End If
		If code = "1"C
			spaces = "LLGLGG".ToCharArray()
		End If
		If code = "2"C
			spaces = "LLGGLG".ToCharArray()
		End If
		If code = "3"C
			spaces = "LLGGGL".ToCharArray()
		End If
		If code = "4"C
			spaces = "LGLLGG".ToCharArray()
		End If
		If code = "5"C
			spaces = "LGGLLG".ToCharArray()
		End If
		If code = "6"C
			spaces = "LGGGLL".ToCharArray()
		End If
		If code = "7"C
			spaces = "LGLGLG".ToCharArray()
		End If
		If code = "8"C
			spaces = "LGLGGL".ToCharArray()
		End If
		If code = "9"C
			spaces = "LGGLGL".ToCharArray()
		End If

		Return spaces
	End Function


	Public Function GenerateBarcodeEAN8(ByRef code As Char (), widthInMm As Double, heightInMm As Double, pixelsPerMm As Double) As RGBABitmapImage
		Dim w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone As Double
		Dim charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100 As Double
		Dim c, character As Char
		Dim image, uninterpolatedBarcode, barcode As RGBABitmapImage
		Dim widths, symbolWidths As Char ()
		Dim counterReference As NumberReference
		Dim characterReference As CharacterReference

		h = Roundx(heightInMm*pixelsPerMm)
		w = Roundx(widthInMm*pixelsPerMm)

		image = CreateImage(w, h, GetWhite())

		zoom100 = (3.0 + 3.0 + 7.0*4.0 + 5.0 + 7.0*4.0 + 3.0 + 3.0)*0.33

		zoom = widthInMm/zoom100
		textheight = zoom*3.08
		charwidth = textheight*30.0/37.0
		textQuietZone = textheight*5.0/100.0
		textY = h - textheight*pixelsPerMm
		shortHeight = textY - textQuietZone*pixelsPerMm
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
		moduleWidthPixels = 0.33*zoom*pixelsPerMm
		moduleWidthWholePixels = Floor(moduleWidthPixels)
		leftQuietZoneWholePixels = 3.0*moduleWidthWholePixels
		leftQuietZonePixels = 3.0*moduleWidthPixels
		group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
		distanceToSecondGroup = group1x + (7.0*3.0 + 4.0)*moduleWidthPixels
		betweenCharatcers = charwidth*92.0/100.0*pixelsPerMm

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

		counterReference = CreateNumberReference(leftQuietZoneWholePixels)

		' Start symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		i = 0.0
		While i < code.Length
			c = code(i)
			If i <= 3.0
				widths = GetUPCLCodeWidths(c)
			Else
				widths = GetUPCRCodeWidths(c)
			End If
			Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

			If i = 3.0
				symbolWidths = GetUPCWidths(11.0)
				Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
			End If
			i = i + 1.0
		End While

		' Checksum
		checksum = GetCalculateUPCChecksum(code)
		characterReference = New CharacterReference()
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
		character = characterReference.characterValue
		characterReference = Nothing
		symbolWidths = GetUPCRCodeWidths(character)
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels)

		' Stop symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
		Call DrawImageOnImage(image, barcode, 0.0, 0.0)

		' Draw digits
		i = 0.0
		While i < code.Length
			digit = GetNumberFromNumberCharacterForBase(code(i), 10.0)
			If i <= 3.0
				Call DrawDigitOnBarcode(image, group1x + i*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			Else
				Call DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			End If
			i = i + 1.0
		End While
		Call DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

		Return image
	End Function


	Public Function GenerateBarcodeUPCA(ByRef code As Char (), widthInMm As Double, heightInMm As Double, pixelsPerMm As Double) As RGBABitmapImage
		Dim w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone As Double
		Dim charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup As Double
		Dim c, character As Char
		Dim image, uninterpolatedBarcode, barcode As RGBABitmapImage
		Dim widths, symbolWidths As Char ()
		Dim counterReference As NumberReference
		Dim characterReference As CharacterReference

		h = Roundx(heightInMm*pixelsPerMm)
		w = Roundx(widthInMm*pixelsPerMm)

		image = CreateImage(w, h, GetWhite())

		zoom100 = (9.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0*6.0 + 3.0 + 9.0)*0.33

		zoom = widthInMm/zoom100
		textheight = zoom*3.08
		charwidth = textheight*30.0/37.0
		textQuietZone = textheight*5.0/100.0
		textY = h - textheight*pixelsPerMm
		shortHeight = textY - textQuietZone*pixelsPerMm
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
		moduleWidthPixels = 0.33*zoom*pixelsPerMm
		moduleWidthWholePixels = Floor(moduleWidthPixels)
		leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
		leftQuietZonePixels = 9.0*moduleWidthPixels
		group1x = leftQuietZonePixels + (3.0 + 7.0)*moduleWidthPixels
		distanceToSecondGroup = group1x + (7.0*5.0 + 5.0)*moduleWidthPixels
		distanceToThirdGroup = distanceToSecondGroup + (7.0*5.0 + 5.0)*moduleWidthPixels
		betweenCharatcers = charwidth*89.0/100.0*pixelsPerMm

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

		counterReference = CreateNumberReference(leftQuietZoneWholePixels)

		' Start symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		i = 0.0
		While i < code.Length
			c = code(i)
			If i <= 5.0
				widths = GetUPCLCodeWidths(c)
			Else
				widths = GetUPCRCodeWidths(c)
			End If

			If i = 0.0
				Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, longHeight, counterReference, moduleWidthWholePixels)
			Else
				Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)
			End If

			If i = 5.0
				symbolWidths = GetUPCWidths(11.0)
				Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
			End If
			i = i + 1.0
		End While

		' Checksum
		checksum = GetCalculateUPCChecksum(code)
		characterReference = New CharacterReference()
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
		character = characterReference.characterValue
		characterReference = Nothing
		symbolWidths = GetUPCRCodeWidths(character)
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		' Stop symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
		Call DrawImageOnImage(image, barcode, 0.0, 0.0)

		' Draw digits
		i = 0.0
		While i < code.Length
			digit = GetNumberFromNumberCharacterForBase(code(i), 10.0)
			If i = 0.0
				Call DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
			ElseIf i <= 5.0
				Call DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			Else
				Call DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 6.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			End If
			i = i + 1.0
		End While
		Call DrawDigitOnBarcode(image, distanceToThirdGroup + (i - 10.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

		Return image
	End Function


	Public Function GetCalculateUPCChecksum(ByRef chars As Char ()) As Double
		Dim checksum, i, nextWeight, value, nearest10 As Double
		Dim nextx As Boolean
		Dim numberString As Char ()

		numberString = New Char (1 - 1){}

		checksum = 0.0
		nextx = true
		nextWeight = 3.0

		i = chars.Length - 1.0
		While i >= 0.0
			numberString(0) = chars(i)
			value = CreateNumberFromDecimalString(numberString)
			checksum = checksum + value*nextWeight

			If nextx
				nextWeight = 1.0
			Else
				nextWeight = 3.0
			End If
			nextx = Not nextx
			i = i - 1.0
		End While

		nearest10 = Ceiling(checksum/10.0)*10.0

		Return nearest10 - checksum
	End Function


	Public Function GetUPCStartAndStopCode() As Double
		Return 10.0
	End Function


	Public Function GetEAN13Width() As Double
		Return 95.0 + 11.0
	End Function


	Public Function GetUPCWidths(code As Double) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = 10.0
			spaces = "101".ToCharArray()
		End If
		If code = 11.0
			spaces = "01010".ToCharArray()
		End If

		Return spaces
	End Function


	Public Sub DrawBarcodeUPCSymbol(ByRef image As RGBABitmapImage, ByRef widths As Char (), h As Double, ByRef counterReference As NumberReference, moduleWidthPixels As Double)
		Dim i, j As Double
		Dim widthCharacter As Char
		Dim color As RGBA

		i = 0.0
		While i < widths.Length
			widthCharacter = widths(i)
			If widthCharacter = "1"C
				color = GetBlack()
			Else
				color = GetWhite()
			End If

			j = 0.0
			While j < moduleWidthPixels
				Call DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, color)
				counterReference.numberValue = counterReference.numberValue + 1.0
				j = j + 1.0
			End While
			i = i + 1.0
		End While
	End Sub


	Public Function GetUPCLCodeWidths(code As Char) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = "0"C
			spaces = "0001101".ToCharArray()
		End If
		If code = "1"C
			spaces = "0011001".ToCharArray()
		End If
		If code = "2"C
			spaces = "0010011".ToCharArray()
		End If
		If code = "3"C
			spaces = "0111101".ToCharArray()
		End If
		If code = "4"C
			spaces = "0100011".ToCharArray()
		End If
		If code = "5"C
			spaces = "0110001".ToCharArray()
		End If
		If code = "6"C
			spaces = "0101111".ToCharArray()
		End If
		If code = "7"C
			spaces = "0111011".ToCharArray()
		End If
		If code = "8"C
			spaces = "0110111".ToCharArray()
		End If
		If code = "9"C
			spaces = "0001011".ToCharArray()
		End If

		Return spaces
	End Function


	Public Function GetUPCGCodeWidths(code As Char) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = "0"C
			spaces = "0100111".ToCharArray()
		End If
		If code = "1"C
			spaces = "0110011".ToCharArray()
		End If
		If code = "2"C
			spaces = "0011011".ToCharArray()
		End If
		If code = "3"C
			spaces = "0100001".ToCharArray()
		End If
		If code = "4"C
			spaces = "0011101".ToCharArray()
		End If
		If code = "5"C
			spaces = "0111001".ToCharArray()
		End If
		If code = "6"C
			spaces = "0000101".ToCharArray()
		End If
		If code = "7"C
			spaces = "0010001".ToCharArray()
		End If
		If code = "8"C
			spaces = "0001001".ToCharArray()
		End If
		If code = "9"C
			spaces = "0010111".ToCharArray()
		End If
		Return spaces
	End Function


	Public Function GetUPCRCodeWidths(code As Char) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = "0"C
			spaces = "1110010".ToCharArray()
		End If
		If code = "1"C
			spaces = "1100110".ToCharArray()
		End If
		If code = "2"C
			spaces = "1101100".ToCharArray()
		End If
		If code = "3"C
			spaces = "1000010".ToCharArray()
		End If
		If code = "4"C
			spaces = "1011100".ToCharArray()
		End If
		If code = "5"C
			spaces = "1001110".ToCharArray()
		End If
		If code = "6"C
			spaces = "1010000".ToCharArray()
		End If
		If code = "7"C
			spaces = "1000100".ToCharArray()
		End If
		If code = "8"C
			spaces = "1001000".ToCharArray()
		End If
		If code = "9"C
			spaces = "1110100".ToCharArray()
		End If

		Return spaces
	End Function


	Public Sub DrawDigitOnBarcode(ByRef image As RGBABitmapImage, topx As Double, topy As Double, digit As Double, pixelsPerMm As Double, zoom As Double)
		Dim digitImage, scaled As RGBABitmapImage

		digitImage = CreateImage(30.0, 37.0, GetWhite())
		Call DrawDigitCharacter(digitImage, 0.0, 0.0, digit)
		scaled = BilinaerScaleUpFactor(digitImage, pixelsPerMm*zoom/DPIToDotsPerMm(300.0))
		Call DrawImageOnImage(image, scaled, Floor(topx), Floor(topy))
		digitImage = Nothing
		scaled = Nothing
	End Sub


	Public Function UPCAToUPCE(ByRef a As Char ()) As Char ()
		Dim mfg, productCode, e As Char ()

		e = New Char (7 - 1){}
		e(0) = a(0)

		mfg = strSubstring(a, 1.0, 6.0)
		productCode = strSubstring(a, 6.0, 11.0)

		e(1) = mfg(0)
		e(2) = mfg(1)
		If (strSubstringEquals(mfg, 2.0, "000".ToCharArray()) Or strSubstringEquals(mfg, 2.0, "100".ToCharArray()) Or strSubstringEquals(mfg, 2.0, "200".ToCharArray())) And productCode(0) = "0"C And productCode(1) = "0"C
			e(3) = productCode(2)
			e(4) = productCode(3)
			e(5) = productCode(4)
			e(6) = mfg(2)
		ElseIf strSubstringEquals(mfg, 3.0, "00".ToCharArray()) And productCode(0) = "0"C And productCode(1) = "0"C And productCode(2) = "0"C
			e(3) = mfg(2)
			e(4) = productCode(3)
			e(5) = productCode(4)
			e(6) = "3"C
		ElseIf strSubstringEquals(mfg, 4.0, "0".ToCharArray()) And productCode(0) = "0"C And productCode(1) = "0"C And productCode(2) = "0"C And productCode(3) = "0"C
			e(3) = mfg(2)
			e(4) = mfg(3)
			e(5) = productCode(4)
			e(6) = "4"C
		ElseIf arraysStringsEqual(productCode, "00005".ToCharArray()) Or arraysStringsEqual(productCode, "00006".ToCharArray()) Or arraysStringsEqual(productCode, "00006".ToCharArray()) Or arraysStringsEqual(productCode, "00007".ToCharArray()) Or arraysStringsEqual(productCode, "00008".ToCharArray()) Or arraysStringsEqual(productCode, "00009".ToCharArray())
			e(3) = mfg(2)
			e(4) = mfg(3)
			e(5) = mfg(4)
			e(6) = productCode(4)
		End If

		Return e
	End Function


	Public Function UPCEToUPCA(ByRef e As Char ()) As Char ()
		Dim a As Char ()

		a = New Char (11 - 1){}

		a(0) = e(0)

		If e(6) = "0"C Or e(6) = "1"C Or e(6) = "2"C
			a(1) = e(1)
			a(2) = e(2)
			a(3) = e(6)
			a(4) = "0"C
			a(5) = "0"C
			a(6) = "0"C
			a(7) = "0"C
			a(8) = e(3)
			a(9) = e(4)
			a(10) = e(5)
		ElseIf e(6) = "3"C
			a(1) = e(1)
			a(2) = e(2)
			a(3) = e(3)
			a(4) = "0"C
			a(5) = "0"C
			a(6) = "0"C
			a(7) = "0"C
			a(8) = "0"C
			a(9) = e(4)
			a(10) = e(5)
		ElseIf e(6) = "4"C
			a(1) = e(1)
			a(2) = e(2)
			a(3) = e(3)
			a(4) = e(4)
			a(5) = "0"C
			a(6) = "0"C
			a(7) = "0"C
			a(8) = "0"C
			a(9) = "0"C
			a(10) = e(5)
		Else
			a(1) = e(1)
			a(2) = e(2)
			a(3) = e(3)
			a(4) = e(4)
			a(5) = e(5)
			a(6) = "0"C
			a(7) = "0"C
			a(8) = "0"C
			a(9) = "0"C
			a(10) = e(6)
		End If

		Return a
	End Function


	Public Function GenerateBarcodeUPCE(ByRef e As Char (), widthInMm As Double, heightInMm As Double, pixelsPerMm As Double) As RGBABitmapImage
		Dim w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone As Double
		Dim charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup As Double
		Dim c, character, type As Char
		Dim image, uninterpolatedBarcode, barcode As RGBABitmapImage
		Dim widths, symbolWidths, a, pattern As Char ()
		Dim counterReference As NumberReference
		Dim characterReference As CharacterReference

		h = Roundx(heightInMm*pixelsPerMm)
		w = Roundx(widthInMm*pixelsPerMm)

		image = CreateImage(w, h, GetWhite())

		zoom100 = (9.0 + 3.0 + 7.0*6.0 + 5.0 + 7.0)*0.33

		zoom = widthInMm/zoom100
		textheight = zoom*3.08
		charwidth = textheight*30.0/37.0
		textQuietZone = textheight*5.0/100.0
		textY = h - textheight*pixelsPerMm
		shortHeight = textY - textQuietZone*pixelsPerMm
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2.0
		moduleWidthPixels = 0.33*zoom*pixelsPerMm
		moduleWidthWholePixels = Floor(moduleWidthPixels)
		leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
		leftQuietZonePixels = 9.0*moduleWidthPixels
		group1x = leftQuietZonePixels + (3.0 + 1.0)*moduleWidthPixels
		distanceToSecondGroup = group1x + (7.0*6.0 + 5.0)*moduleWidthPixels
		betweenCharatcers = charwidth*89.0/100.0*pixelsPerMm

		uninterpolatedBarcode = CreateImage(Ceiling(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

		counterReference = CreateNumberReference(leftQuietZoneWholePixels)

		' Checksum
		a = UPCEToUPCA(e)
		checksum = GetCalculateUPCChecksum(a)
		characterReference = New CharacterReference()
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
		character = characterReference.characterValue

		' Start symbol
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

		pattern = GetUPCEPattern(character, e(0))

		i = 1.0
		While i < e.Length
			c = e(i)
			type = pattern(i - 1.0)
			If type = "O"C
				widths = GetUPCLCodeWidths(c)
			Else
				widths = GetUPCGCodeWidths(c)
			End If

			Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)
			i = i + 1.0
		End While

		' Stop symbol
		Call DrawBarcodeUPCSymbol(uninterpolatedBarcode, "010101".ToCharArray(), longHeight, counterReference, moduleWidthWholePixels)

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
		Call DrawImageOnImage(image, barcode, 0.0, 0.0)

		' Draw digits
		i = 0.0
		While i < e.Length
			digit = GetNumberFromNumberCharacterForBase(e(i), 10.0)
			If i = 0.0
				Call DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
			ElseIf i <= 6.0
				Call DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
			End If
			i = i + 1.0
		End While
		Call DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

		Return image
	End Function


	Public Function GetUPCEPattern(check As Char, system As Char) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If system = "0"C
			If check = "0"C
				spaces = "EEEOOO".ToCharArray()
			End If
			If check = "1"C
				spaces = "EEOEOO".ToCharArray()
			End If
			If check = "2"C
				spaces = "EEOOEO".ToCharArray()
			End If
			If check = "3"C
				spaces = "EEOOOE".ToCharArray()
			End If
			If check = "4"C
				spaces = "EOEEOO".ToCharArray()
			End If
			If check = "5"C
				spaces = "EOOEEO".ToCharArray()
			End If
			If check = "6"C
				spaces = "EOOOEE".ToCharArray()
			End If
			If check = "7"C
				spaces = "EOEOEO".ToCharArray()
			End If
			If check = "8"C
				spaces = "EOEOOE".ToCharArray()
			End If
			If check = "9"C
				spaces = "EOOEOE".ToCharArray()
			End If
		ElseIf system = "1"C
			If check = "0"C
				spaces = "OOOEEE".ToCharArray()
			End If
			If check = "1"C
				spaces = "OOEOEE".ToCharArray()
			End If
			If check = "2"C
				spaces = "OOEEOE".ToCharArray()
			End If
			If check = "3"C
				spaces = "OOEEEO".ToCharArray()
			End If
			If check = "4"C
				spaces = "OEOOEE".ToCharArray()
			End If
			If check = "5"C
				spaces = "OEEOOE".ToCharArray()
			End If
			If check = "6"C
				spaces = "OEEEOO".ToCharArray()
			End If
			If check = "7"C
				spaces = "OEOEOE".ToCharArray()
			End If
			If check = "8"C
				spaces = "OEOEEO".ToCharArray()
			End If
			If check = "9"C
				spaces = "OEEOEO".ToCharArray()
			End If
		End If

		Return spaces
	End Function


	Public Function Code128EncodingParts(ByRef cs As Char ()) As Char ()
		Dim parts As Char ()
		Dim i As Double
		Dim c As Char

		parts = New Char (cs.Length - 1){}

		i = 0.0
		While i < cs.Length
			c = cs(i)

			If IsCodeA(c) And IsCodeB(c) And IsCodeC(c)
				parts(i) = "X"C
			ElseIf IsCodeA(c) And IsCodeB(c)
				parts(i) = "D"C
			ElseIf IsCodeA(c)
				parts(i) = "A"C
			ElseIf IsCodeB(c)
				parts(i) = "B"C
			End If
			i = i + 1.0
		End While

		Return parts
	End Function


	Public Function IsCodeA(c As Char) As Boolean
		Return cIsNumber(c) Or cIsUpperCase(c) Or charIsCode128AandBSymbol(c) Or charIsCode128ASymbol(c)
	End Function


	Public Function IsCodeB(c As Char) As Boolean
		Return cIsNumber(c) Or cIsUpperCase(c) Or charIsCode128AandBSymbol(c) Or cIsLowerCase(c) Or charIsCode128BSymbol(c)
	End Function


	Public Function IsCodeC(c As Char) As Boolean
		Return cIsNumber(c)
	End Function


	Public Function Code128EncodingSections(ByRef cs As Char ()) As Sections
		Dim sections, parts, currentSections As Char ()
		Dim i, c, nextx, sum As Double
		Dim p, selected As Char
		Dim done As Boolean
		Dim sectionsStruct As Sections
		Dim counts, currentCounts As Double ()

		parts = Code128EncodingParts(cs)

		sections = arraysCreateString(cs.Length, " "C)
		counts = arraysCreateNumberArray(cs.Length, 0.0)
		nextx = 0.0

		' Pick C-sections.
		i = 0.0
		While i < cs.Length
			p = parts(i)

			If p = "X"C
				done = false
				c = 0.0
				While i + c < cs.Length And Not done
					If parts(i + c) <> "X"C
						done = true
						c = c - 1.0
					End If
					c = c + 1.0
				End While
				' Compress 2 or more if first, or 4 or more if not.
				If c >= 4.0 Or (i = 0.0 And c >= 2.0)
					sections(nextx) = "C"C
					c = Floor(c/2.0)*2.0
					counts(nextx) = c
					nextx = nextx + 1.0
					i = i + c - 1.0
				Else
					sections(nextx) = "D"C
					counts(nextx) = 1.0
					nextx = nextx + 1.0
				End If
			Else
				sections(nextx) = p
				counts(nextx) = 1.0
				nextx = nextx + 1.0
			End If
			i = i + 1.0
		End While

		' Trim
		currentSections = New Char (nextx - 1){}
		i = 0.0
		While i < nextx
			currentSections(i) = sections(i)
			i = i + 1.0
		End While

		currentCounts = New Double (nextx - 1){}
		i = 0.0
		While i < nextx
			currentCounts(i) = counts(i)
			i = i + 1.0
		End While

		sections = arraysCreateString(cs.Length, " "C)
		counts = arraysCreateNumberArray(cs.Length, 0.0)

		' Compress A+A&D and B+B&D
		nextx = 0.0
		i = 0.0
		While i < currentSections.Length
			p = currentSections(i)

			If p = "C"C Or p = "D"C
				sections(nextx) = p
				counts(nextx) = currentCounts(i)
				nextx = nextx + 1.0
			ElseIf p = "A"C
				sum = 0.0
				done = false
				c = 0.0
				While i + c < currentSections.Length And Not done
					If currentSections(i + c) = "A"C Or currentSections(i + c) = "D"C
						sum = sum + currentCounts(i + c)
					Else
						done = true
						c = c - 1.0
					End If
					c = c + 1.0
				End While
				sections(nextx) = p
				counts(nextx) = sum
				nextx = nextx + 1.0
				i = i + c - 1.0
			ElseIf p = "B"C
				sum = 0.0
				done = false
				c = 0.0
				While i + c < currentSections.Length And Not done
					If currentSections(i + c) = "B"C Or currentSections(i + c) = "D"C
						sum = sum + currentCounts(i + c)
					Else
						done = true
						c = c - 1.0
					End If
					c = c + 1.0
				End While
				sections(nextx) = p
				counts(nextx) = sum
				nextx = nextx + 1.0
				i = i + c - 1.0
			End If
			i = i + 1.0
		End While

		' Trim
		currentSections = New Char (nextx - 1){}
		i = 0.0
		While i < nextx
			currentSections(i) = sections(i)
			i = i + 1.0
		End While

		currentCounts = New Double (nextx - 1){}
		i = 0.0
		While i < nextx
			currentCounts(i) = counts(i)
			i = i + 1.0
		End While

		sections = arraysCreateString(cs.Length, " "C)
		counts = arraysCreateNumberArray(cs.Length, 0.0)

		' Compress D+A&D and D+B&D
		nextx = 0.0
		i = 0.0
		While i < currentSections.Length
			p = currentSections(i)

			sum = 0.0

			If p = "C"C Or p = "A"C Or p = "B"C
				sections(nextx) = p
				counts(nextx) = currentCounts(i)
				nextx = nextx + 1.0
			ElseIf p = "D"C
				selected = " "C
				done = false

				sum = 0.0
				c = 0.0
				While i + c < currentSections.Length And Not done
					p = currentSections(i + c)

					If p = "D"C
						sum = sum + currentCounts(i + c)
					ElseIf p = "A"C Or p = "B"C
						If selected = " "C
							selected = p
							sum = sum + currentCounts(i + c)
						ElseIf p <> selected
							done = true
							c = c - 1.0
						Else
							sum = sum + currentCounts(i + c)
						End If
					Else
						done = true
						c = c - 1.0
					End If
					c = c + 1.0
				End While
				If selected = " "C
					selected = "A"C
				End If
				sections(nextx) = selected
				counts(nextx) = sum
				nextx = nextx + 1.0
				i = i + c - 1.0
			End If
			i = i + 1.0
		End While

		' Trim
		currentSections = New Char (nextx - 1){}
		i = 0.0
		While i < nextx
			currentSections(i) = sections(i)
			i = i + 1.0
		End While
		sections = currentSections

		currentCounts = New Double (nextx - 1){}
		i = 0.0
		While i < nextx
			currentCounts(i) = counts(i)
			i = i + 1.0
		End While
		counts = currentCounts

		' Done
		sectionsStruct = New Sections()
		sectionsStruct.codes = sections
		sectionsStruct.counts = counts

		Return sectionsStruct
	End Function


	Public Function Code128Encode(ByRef cs As Char ()) As Double ()
		Dim coded, nextCoded As Double ()
		Dim isFirst As Boolean
		Dim n, k, nextx, cnr, count As Double
		Dim section, lastSection As Char
		Dim sections As Sections

		coded = New Double (cs.Length + 2.0 + 1.0 + 1.0 + 10.0 - 1){}
		cnr = 0.0
		isFirst = true
		nextx = 0.0

		lastSection = "0"C

		sections = Code128EncodingSections(cs)

		n = 0.0
		While n < sections.codes.Length
			section = sections.codes(n)
			count = sections.counts(n)

			' start code
			If isFirst
				If section = "A"C
					coded(nextx) = 103.0
				ElseIf section = "B"C
					coded(nextx) = 104.0
				ElseIf section = "C"C
					coded(nextx) = 105.0
				End If
				nextx = nextx + 1.0

				isFirst = false
			End If

			' Encode
			If section = "A"C
				If lastSection = "B"C Or lastSection = "C"C
					coded(nextx) = 101.0
					nextx = nextx + 1.0
				End If

				k = 0.0
				While k < count
					coded(nextx) = GetCode128ACode(cs(cnr + k))
					nextx = nextx + 1.0
					k = k + 1.0
				End While
				cnr = cnr + count
			ElseIf section = "B"C
				If lastSection = "A"C Or lastSection = "C"C
					coded(nextx) = 100.0
					nextx = nextx + 1.0
				End If

				k = 0.0
				While k < count
					coded(nextx) = GetCode128BCode(cs(cnr + k))
					nextx = nextx + 1.0
					k = k + 1.0
				End While
				cnr = cnr + count
			ElseIf section = "C"C
				If lastSection = "A"C Or lastSection = "B"C
					coded(nextx) = 99.0
					nextx = nextx + 1.0
				End If

				k = 0.0
				While k < count
					coded(nextx) = GetCode128CCode(cs(cnr + k), cs(cnr + k + 1.0))
					nextx = nextx + 1.0
					k = k + 2.0
				End While
				cnr = cnr + count
			End If

			lastSection = section
			n = n + 1.0
		End While

		coded(nextx) = CalculateCode128ChecksumWithLength(coded, nextx)
		nextx = nextx + 1.0

		coded(nextx) = 108.0
		nextx = nextx + 1.0

		' trim array
		nextCoded = New Double (nextx - 1){}
		k = 0.0
		While k < nextx
			nextCoded(k) = coded(k)
			k = k + 1.0
		End While
		Erase coded 
		coded = nextCoded

		Return coded
	End Function


	Public Function GetCode128ACode(c As Char) As Double
		Dim code, n As Double

		n = Convert.ToInt16(c)

		If n >= 32.0 And n <= 95.0
			code = n - 32.0
		ElseIf n >= 0.0 And n <= 31.0
			code = 64.0 + n
		Else
			code = -1.0
		End If

		Return code
	End Function


	Public Function GetCode128BCode(c As Char) As Double
		Dim code, n As Double

		n = Convert.ToInt16(c)

		If n >= 32.0 And n <= 126.0
			code = n - 32.0
		ElseIf n = 127.0
			code = 95.0
		Else
			code = -1.0
		End If

		Return code
	End Function


	Public Function GetCode128CCode(c1 As Char, c2 As Char) As Double
		Dim n1, n2 As Double

		n1 = GetNumberFromNumberCharacterForBase(c1, 10.0)
		n2 = GetNumberFromNumberCharacterForBase(c2, 10.0)

		Return n1*10.0 + n2
	End Function


	Public Function charIsCode128AandBSymbol(character As Char) As Boolean
		Dim common As Boolean

		common = false
		If character = " "C
			common = true
		ElseIf character = "!"C
			common = true
		ElseIf character = """"C
			common = true
		ElseIf character = "#"C
			common = true
		ElseIf character = "$"C
			common = true
		ElseIf character = "%"C
			common = true
		ElseIf character = "&"C
			common = true
		ElseIf character = "'"C
			common = true
		ElseIf character = "("C
			common = true
		ElseIf character = ")"C
			common = true
		ElseIf character = "*"C
			common = true
		ElseIf character = "+"C
			common = true
		ElseIf character = ","C
			common = true
		ElseIf character = "-"C
			common = true
		ElseIf character = "."C
			common = true
		ElseIf character = "/"C
			common = true
		ElseIf character = ":"C
			common = true
		ElseIf character = ";"C
			common = true
		ElseIf character = "<"C
			common = true
		ElseIf character = "="C
			common = true
		ElseIf character = ">"C
			common = true
		ElseIf character = "?"C
			common = true
		ElseIf character = "@"C
			common = true
		ElseIf character = "["C
			common = true
		ElseIf character = "\"C
			common = true
		ElseIf character = "]"C
			common = true
		ElseIf character = "^"C
			common = true
		ElseIf character = "_"C
			common = true
		End If

		Return common
	End Function


	Public Function charIsCode128BSymbol(character As Char) As Boolean
		Dim codeB As Boolean

		codeB = false
		If character = "`"C
			codeB = true
		ElseIf character = "{"C
			codeB = true
		ElseIf character = "|"C
			codeB = true
		ElseIf character = "}"C
			codeB = true
		ElseIf character = "~"C
			codeB = true
		ElseIf Convert.ToInt16(character) = 127.0
			' del
			codeB = true
		End If

		Return codeB
	End Function


	Public Function charIsCode128ASymbol(character As Char) As Boolean
		Dim codeA As Boolean
		Dim n As Double

		n = Convert.ToInt16(character)

		codeA = false
		If n >= 0.0 And n <= 31.0
			codeA = true
		End If

		Return codeA
	End Function


	Public Function GenerateBarcodeCode128(ByRef chars As Char (), height As Double) As RGBABitmapImage
		Dim image As RGBABitmapImage
		Dim success As Boolean
		Dim errorMessages As StringReference

		image = New RGBABitmapImage()
		errorMessages = CreateStringReference("".ToCharArray())

		success = GenerateBarcodeCode128AllParams(chars, height, 2.0, image, errorMessages)

		errorMessages = Nothing

		Return image
	End Function


	Public Function GenerateBarcodeCode128AllParams(ByRef chars As Char (), height As Double, moduleWidth As Double, ByRef image As RGBABitmapImage, ByRef errorMessages As StringReference) As Boolean
		Dim w, h, i, code As Double
		Dim counterReference As NumberReference
		Dim codes As Double ()
		Dim success As Boolean
		Dim newImage As RGBABitmapImage

		success = IsValidCode128Data(chars, height, moduleWidth, errorMessages)

		If success
			codes = Code128Encode(chars)

			h = height
			w = CalculateCode128Width(codes, moduleWidth)

			newImage = CreateImage(w, h, GetWhite())
			image.x = newImage.x
			newImage = Nothing

			counterReference = New NumberReference()

			' Start Quiet Zone
			counterReference.numberValue = 10.0*moduleWidth

			i = 0.0
			While i < codes.Length
				code = codes(i)
				Call DrawBarcodeSymbol(image, code, h, moduleWidth, counterReference)
				i = i + 1.0
			End While

			' End Quiet Zone
			counterReference.numberValue = counterReference.numberValue + 10.0*moduleWidth
		End If

		Return success
	End Function


	Public Function IsValidCode128Data(ByRef chars As Char (), height As Double, moduleWidth As Double, ByRef errorMessages As StringReference) As Boolean
		Dim validCharacters, i As Double
		Dim valid As Boolean

		validCharacters = 0.0

		i = 0.0
		While i < chars.Length
			If Convert.ToInt16(chars(i)) >= 0.0 And Convert.ToInt16(chars(i)) <= 127.0
				validCharacters = validCharacters + 1.0
			End If
			i = i + 1.0
		End While

		If validCharacters = chars.Length

			If height > 0.0
				If Truncatex(height) = height
					If moduleWidth > 0.0
						If Truncatex(moduleWidth) = moduleWidth
							valid = true
						Else
							valid = false
							errorMessages.stringx = strAppendString(errorMessages.stringx, "Module width must be a whole number of pixels.".ToCharArray())
						End If
					Else
						valid = false
						errorMessages.stringx = strAppendString(errorMessages.stringx, "Module width must be at least one pixel.".ToCharArray())
					End If
				Else
					valid = false
					errorMessages.stringx = strAppendString(errorMessages.stringx, "Height must be a whole number of pixels.".ToCharArray())
				End If
			Else
				valid = false
				errorMessages.stringx = strAppendString(errorMessages.stringx, "Height must be at least one pixel.".ToCharArray())
			End If
		Else
			valid = false
			errorMessages.stringx = strAppendString(errorMessages.stringx, "Input data contains character invalid for this implementation of Code 128. Only 0-127 (inclusive) supported in this implementation.".ToCharArray())
		End If

		Return valid
	End Function


	Public Function CalculateCode128Width(ByRef codes As Double (), moduleWidth As Double) As Double
		Dim width As Double

		' Quiet Zone + 11 * codes + stop symbol extra + Quiet Zone.
		width = (10.0 + codes.Length*11.0 + 2.0 + 10.0)*moduleWidth

		Return width
	End Function


	Public Function CalculateCode128Checksum(ByRef codes As Double ()) As Double
		Return CalculateCode128ChecksumWithLength(codes, codes.Length)
	End Function


	Public Function CalculateCode128ChecksumWithLength(ByRef codes As Double (), length As Double) As Double
		Dim checksum, i, position, value As Double

		checksum = 0.0

		position = 1.0
		i = 0.0
		While i < length
			If i > 1.0
				position = position + 1.0
			End If
			value = codes(i)
			checksum = checksum + position*value
			i = i + 1.0
		End While

		Return checksum Mod 103.0
	End Function


	Public Sub DrawBarcodeSymbol(ByRef image As RGBABitmapImage, barcodeNr As Double, h As Double, moduleWidth As Double, ByRef counterReference As NumberReference)
		Dim i, j, k, width As Double
		Dim widthCharacter As Char
		Dim widths As Char ()
		Dim nextx As Boolean
		Dim nextColor As RGBA

		widths = GetCode128Widths(barcodeNr)

		nextColor = GetBlack()
		nextx = true

		i = 0.0
		While i < widths.Length
			widthCharacter = widths(i)
			width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

			j = 0.0
			While j < width
				k = 0.0
				While k < moduleWidth
					Call DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
					counterReference.numberValue = counterReference.numberValue + 1.0
					k = k + 1.0
				End While
				j = j + 1.0
			End While

			If nextx
				nextColor = GetWhite()
			Else
				nextColor = GetBlack()
			End If
			nextx = Not nextx
			i = i + 1.0
		End While
	End Sub


	Public Function GetCode128Widths(code As Double) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = 0.0
			spaces = "212222".ToCharArray()
		End If
		If code = 1.0
			spaces = "222122".ToCharArray()
		End If
		If code = 2.0
			spaces = "222221".ToCharArray()
		End If
		If code = 3.0
			spaces = "121223".ToCharArray()
		End If
		If code = 4.0
			spaces = "121322".ToCharArray()
		End If
		If code = 5.0
			spaces = "131222".ToCharArray()
		End If
		If code = 6.0
			spaces = "122213".ToCharArray()
		End If
		If code = 7.0
			spaces = "122312".ToCharArray()
		End If
		If code = 8.0
			spaces = "132212".ToCharArray()
		End If
		If code = 9.0
			spaces = "221213".ToCharArray()
		End If
		If code = 10.0
			spaces = "221312".ToCharArray()
		End If
		If code = 11.0
			spaces = "231212".ToCharArray()
		End If
		If code = 12.0
			spaces = "112232".ToCharArray()
		End If
		If code = 13.0
			spaces = "122132".ToCharArray()
		End If
		If code = 14.0
			spaces = "122231".ToCharArray()
		End If
		If code = 15.0
			spaces = "113222".ToCharArray()
		End If
		If code = 16.0
			spaces = "123122".ToCharArray()
		End If
		If code = 17.0
			spaces = "123221".ToCharArray()
		End If
		If code = 18.0
			spaces = "223211".ToCharArray()
		End If
		If code = 19.0
			spaces = "221132".ToCharArray()
		End If
		If code = 20.0
			spaces = "221231".ToCharArray()
		End If
		If code = 21.0
			spaces = "213212".ToCharArray()
		End If
		If code = 22.0
			spaces = "223112".ToCharArray()
		End If
		If code = 23.0
			spaces = "312131".ToCharArray()
		End If
		If code = 24.0
			spaces = "311222".ToCharArray()
		End If
		If code = 25.0
			spaces = "321122".ToCharArray()
		End If
		If code = 26.0
			spaces = "321221".ToCharArray()
		End If
		If code = 27.0
			spaces = "312212".ToCharArray()
		End If
		If code = 28.0
			spaces = "322112".ToCharArray()
		End If
		If code = 29.0
			spaces = "322211".ToCharArray()
		End If
		If code = 30.0
			spaces = "212123".ToCharArray()
		End If
		If code = 31.0
			spaces = "212321".ToCharArray()
		End If
		If code = 32.0
			spaces = "232121".ToCharArray()
		End If
		If code = 33.0
			spaces = "111323".ToCharArray()
		End If
		If code = 34.0
			spaces = "131123".ToCharArray()
		End If
		If code = 35.0
			spaces = "131321".ToCharArray()
		End If
		If code = 36.0
			spaces = "112313".ToCharArray()
		End If
		If code = 37.0
			spaces = "132113".ToCharArray()
		End If
		If code = 38.0
			spaces = "132311".ToCharArray()
		End If
		If code = 39.0
			spaces = "211313".ToCharArray()
		End If
		If code = 40.0
			spaces = "231113".ToCharArray()
		End If
		If code = 41.0
			spaces = "231311".ToCharArray()
		End If
		If code = 42.0
			spaces = "112133".ToCharArray()
		End If
		If code = 43.0
			spaces = "112331".ToCharArray()
		End If
		If code = 44.0
			spaces = "132131".ToCharArray()
		End If
		If code = 45.0
			spaces = "113123".ToCharArray()
		End If
		If code = 46.0
			spaces = "113321".ToCharArray()
		End If
		If code = 47.0
			spaces = "133121".ToCharArray()
		End If
		If code = 48.0
			spaces = "313121".ToCharArray()
		End If
		If code = 49.0
			spaces = "211331".ToCharArray()
		End If
		If code = 50.0
			spaces = "231131".ToCharArray()
		End If
		If code = 51.0
			spaces = "213113".ToCharArray()
		End If
		If code = 52.0
			spaces = "213311".ToCharArray()
		End If
		If code = 53.0
			spaces = "213131".ToCharArray()
		End If
		If code = 54.0
			spaces = "311123".ToCharArray()
		End If
		If code = 55.0
			spaces = "311321".ToCharArray()
		End If
		If code = 56.0
			spaces = "331121".ToCharArray()
		End If
		If code = 57.0
			spaces = "312113".ToCharArray()
		End If
		If code = 58.0
			spaces = "312311".ToCharArray()
		End If
		If code = 59.0
			spaces = "332111".ToCharArray()
		End If
		If code = 60.0
			spaces = "314111".ToCharArray()
		End If
		If code = 61.0
			spaces = "221411".ToCharArray()
		End If
		If code = 62.0
			spaces = "431111".ToCharArray()
		End If
		If code = 63.0
			spaces = "111224".ToCharArray()
		End If
		If code = 64.0
			spaces = "111422".ToCharArray()
		End If
		If code = 65.0
			spaces = "121124".ToCharArray()
		End If
		If code = 66.0
			spaces = "121421".ToCharArray()
		End If
		If code = 67.0
			spaces = "141122".ToCharArray()
		End If
		If code = 68.0
			spaces = "141221".ToCharArray()
		End If
		If code = 69.0
			spaces = "112214".ToCharArray()
		End If
		If code = 70.0
			spaces = "112412".ToCharArray()
		End If
		If code = 71.0
			spaces = "122114".ToCharArray()
		End If
		If code = 72.0
			spaces = "122411".ToCharArray()
		End If
		If code = 73.0
			spaces = "142112".ToCharArray()
		End If
		If code = 74.0
			spaces = "142211".ToCharArray()
		End If
		If code = 75.0
			spaces = "241211".ToCharArray()
		End If
		If code = 76.0
			spaces = "221114".ToCharArray()
		End If
		If code = 77.0
			spaces = "413111".ToCharArray()
		End If
		If code = 78.0
			spaces = "241112".ToCharArray()
		End If
		If code = 79.0
			spaces = "134111".ToCharArray()
		End If
		If code = 80.0
			spaces = "111242".ToCharArray()
		End If
		If code = 81.0
			spaces = "121142".ToCharArray()
		End If
		If code = 82.0
			spaces = "121241".ToCharArray()
		End If
		If code = 83.0
			spaces = "114212".ToCharArray()
		End If
		If code = 84.0
			spaces = "124112".ToCharArray()
		End If
		If code = 85.0
			spaces = "124211".ToCharArray()
		End If
		If code = 86.0
			spaces = "411212".ToCharArray()
		End If
		If code = 87.0
			spaces = "421112".ToCharArray()
		End If
		If code = 88.0
			spaces = "421211".ToCharArray()
		End If
		If code = 89.0
			spaces = "212141".ToCharArray()
		End If
		If code = 90.0
			spaces = "214121".ToCharArray()
		End If
		If code = 91.0
			spaces = "412121".ToCharArray()
		End If
		If code = 92.0
			spaces = "111143".ToCharArray()
		End If
		If code = 93.0
			spaces = "111341".ToCharArray()
		End If
		If code = 94.0
			spaces = "131141".ToCharArray()
		End If
		If code = 95.0
			spaces = "114113".ToCharArray()
		End If
		If code = 96.0
			spaces = "114311".ToCharArray()
		End If
		If code = 97.0
			spaces = "411113".ToCharArray()
		End If
		If code = 98.0
			spaces = "411311".ToCharArray()
		End If
		If code = 99.0
			spaces = "113141".ToCharArray()
		End If
		If code = 100.0
			spaces = "114131".ToCharArray()
		End If
		If code = 101.0
			spaces = "311141".ToCharArray()
		End If
		If code = 102.0
			spaces = "411131".ToCharArray()
		End If
		If code = 103.0
			spaces = "211412".ToCharArray()
		End If
		If code = 104.0
			spaces = "211214".ToCharArray()
		End If
		If code = 105.0
			spaces = "211232".ToCharArray()
		End If
		If code = 106.0
			spaces = "233111".ToCharArray()
		End If
		If code = 107.0
			spaces = "211133".ToCharArray()
		End If
		If code = 108.0
			spaces = "2331112".ToCharArray()
		End If

		Return spaces
	End Function


	Public Function GenerateBarcodeCode39(ByRef chars As Char (), height As Double) As RGBABitmapImage
		Return GenerateBarcodeCode39WithChecksumOption(chars, height, false)
	End Function


	Public Function GenerateBarcodeCode39WithChecksumOption(ByRef chars As Char (), height As Double, includeChecksum As Boolean) As RGBABitmapImage
		Dim w, h, i, barcodeNr, checksum As Double
		Dim c As Char
		Dim counterReference As NumberReference
		Dim image As RGBABitmapImage

		h = height
		w = CalculateCode39Width(chars, includeChecksum)*2.0

		image = CreateImage(w, h, GetWhite())

		counterReference = CreateNumberReference(10.0*2.0)

		' Start symbol
		Call DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, true)

		i = 0.0
		While i < chars.Length
			c = chars(i)
			barcodeNr = AsciiToCode39(c)
			Call DrawBarcode39Symbol(image, barcodeNr, h, counterReference, true)
			i = i + 1.0
		End While

		If includeChecksum
			checksum = CalculateCode39Checksum(chars)
			Call DrawBarcode39Symbol(image, checksum, h, counterReference, true)
		End If

		' Stop symbol
		Call DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, false)

		Return image
	End Function


	Public Function CalculateCode39Checksum(ByRef chars As Char ()) As Double
		Dim checksum, i, value As Double
		Dim c As Char

		checksum = 0.0

		i = 0.0
		While i < chars.Length
			c = chars(i)
			value = AsciiToCode39(c)
			checksum = checksum + value
			i = i + 1.0
		End While

		Return checksum Mod 43.0
	End Function


	Public Function Get39StartAndStopCode() As Double
		Return 43.0
	End Function


	Public Function CalculateCode39Width(ByRef chars As Char (), includeChecksum As Boolean) As Double
		Dim width As Double

		' quiet zone + start + 1 + 12*characters + 1*characters + stop + quiet zone
		width = 10.0 + 12.0 + 1.0 + chars.Length*12.0 + chars.Length*1.0 + 12.0 + 10.0

		If includeChecksum
			width = width + 1.0 + 12.0
		End If

		Return width
	End Function


	Public Sub DrawBarcode39Symbol(ByRef image As RGBABitmapImage, barcodeNr As Double, h As Double, ByRef counterReference As NumberReference, addSeparator As Boolean)
		Dim j, k, width As Double
		Dim widthCharacter As Char
		Dim widths As Char ()
		Dim nextx As Boolean
		Dim nextColor As RGBA

		widths = GetCode39Widths(barcodeNr)

		nextColor = GetBlack()
		nextx = true

		j = 0.0
		While j < widths.Length
			widthCharacter = widths(j)
			width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

			k = 0.0
			While k < width
				Call DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
				counterReference.numberValue = counterReference.numberValue + 1.0
				Call DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
				counterReference.numberValue = counterReference.numberValue + 1.0
				k = k + 1.0
			End While

			If nextx
				nextColor = GetWhite()
			Else
				nextColor = GetBlack()
			End If
			nextx = Not nextx
			j = j + 1.0
		End While

		' Space
		If addSeparator
			Call DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, GetWhite())
			counterReference.numberValue = counterReference.numberValue + 1.0
			Call DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, GetWhite())
			counterReference.numberValue = counterReference.numberValue + 1.0
		End If
	End Sub


	Public Function GetCode39Widths(code As Double) As Char ()
		Dim spaces As Char ()

		spaces = "".ToCharArray()

		If code = 0.0
			spaces = "111221211".ToCharArray()
		End If
		If code = 1.0
			spaces = "211211112".ToCharArray()
		End If
		If code = 2.0
			spaces = "112211112".ToCharArray()
		End If
		If code = 3.0
			spaces = "212211111".ToCharArray()
		End If
		If code = 4.0
			spaces = "111221112".ToCharArray()
		End If
		If code = 5.0
			spaces = "211221111".ToCharArray()
		End If
		If code = 6.0
			spaces = "112221111".ToCharArray()
		End If
		If code = 7.0
			spaces = "111211212".ToCharArray()
		End If
		If code = 8.0
			spaces = "211211211".ToCharArray()
		End If
		If code = 9.0
			spaces = "112211211".ToCharArray()
		End If
		If code = 10.0
			spaces = "211112112".ToCharArray()
		End If
		If code = 11.0
			spaces = "112112112".ToCharArray()
		End If
		If code = 12.0
			spaces = "212112111".ToCharArray()
		End If
		If code = 13.0
			spaces = "111122112".ToCharArray()
		End If
		If code = 14.0
			spaces = "211122111".ToCharArray()
		End If
		If code = 15.0
			spaces = "112122111".ToCharArray()
		End If
		If code = 16.0
			spaces = "111112212".ToCharArray()
		End If
		If code = 17.0
			spaces = "211112211".ToCharArray()
		End If
		If code = 18.0
			spaces = "112112211".ToCharArray()
		End If
		If code = 19.0
			spaces = "111122211".ToCharArray()
		End If
		If code = 20.0
			spaces = "211111122".ToCharArray()
		End If
		If code = 21.0
			spaces = "112111122".ToCharArray()
		End If
		If code = 22.0
			spaces = "212111121".ToCharArray()
		End If
		If code = 23.0
			spaces = "111121122".ToCharArray()
		End If
		If code = 24.0
			spaces = "211121121".ToCharArray()
		End If
		If code = 25.0
			spaces = "112121121".ToCharArray()
		End If
		If code = 26.0
			spaces = "111111222".ToCharArray()
		End If
		If code = 27.0
			spaces = "211111221".ToCharArray()
		End If
		If code = 28.0
			spaces = "112111221".ToCharArray()
		End If
		If code = 29.0
			spaces = "111121221".ToCharArray()
		End If
		If code = 30.0
			spaces = "221111112".ToCharArray()
		End If
		If code = 31.0
			spaces = "122111112".ToCharArray()
		End If
		If code = 32.0
			spaces = "222111111".ToCharArray()
		End If
		If code = 33.0
			spaces = "121121112".ToCharArray()
		End If
		If code = 34.0
			spaces = "221121111".ToCharArray()
		End If
		If code = 35.0
			spaces = "122121111".ToCharArray()
		End If
		If code = 36.0
			spaces = "121111212".ToCharArray()
		End If
		If code = 37.0
			spaces = "221111211".ToCharArray()
		End If
		If code = 38.0
			spaces = "122111211".ToCharArray()
		End If
		If code = 39.0
			spaces = "121212111".ToCharArray()
		End If
		If code = 40.0
			spaces = "121211121".ToCharArray()
		End If
		If code = 41.0
			spaces = "121112121".ToCharArray()
		End If
		If code = 42.0
			spaces = "111212121".ToCharArray()
		End If
		If code = 43.0
			spaces = "121121211".ToCharArray()
		End If

		Return spaces
	End Function


	Public Function AsciiToCode39(c As Char) As Double
		Dim nr As Double
		Dim asciiToNrTable As Double ()

		asciiToNrTable = GetAsciiToCode39Table()
		nr = Convert.ToInt16(c)

		Return asciiToNrTable(nr)
	End Function


	Public Function GetAsciiToCode39Table() As Double ()
		Dim c As Double ()

		c = New Double (256 - 1){}

		c(Convert.ToByte("0"C)) = 0.0
		c(Convert.ToByte("1"C)) = 1.0
		c(Convert.ToByte("2"C)) = 2.0
		c(Convert.ToByte("3"C)) = 3.0
		c(Convert.ToByte("4"C)) = 4.0
		c(Convert.ToByte("5"C)) = 5.0
		c(Convert.ToByte("6"C)) = 6.0
		c(Convert.ToByte("7"C)) = 7.0
		c(Convert.ToByte("8"C)) = 8.0
		c(Convert.ToByte("9"C)) = 9.0
		c(Convert.ToByte("A"C)) = 10.0
		c(Convert.ToByte("B"C)) = 11.0
		c(Convert.ToByte("C"C)) = 12.0
		c(Convert.ToByte("D"C)) = 13.0
		c(Convert.ToByte("E"C)) = 14.0
		c(Convert.ToByte("F"C)) = 15.0
		c(Convert.ToByte("G"C)) = 16.0
		c(Convert.ToByte("H"C)) = 17.0
		c(Convert.ToByte("I"C)) = 18.0
		c(Convert.ToByte("J"C)) = 19.0
		c(Convert.ToByte("K"C)) = 20.0
		c(Convert.ToByte("L"C)) = 21.0
		c(Convert.ToByte("M"C)) = 22.0
		c(Convert.ToByte("N"C)) = 23.0
		c(Convert.ToByte("O"C)) = 24.0
		c(Convert.ToByte("P"C)) = 25.0
		c(Convert.ToByte("Q"C)) = 26.0
		c(Convert.ToByte("R"C)) = 27.0
		c(Convert.ToByte("S"C)) = 28.0
		c(Convert.ToByte("T"C)) = 29.0
		c(Convert.ToByte("U"C)) = 30.0
		c(Convert.ToByte("V"C)) = 31.0
		c(Convert.ToByte("W"C)) = 32.0
		c(Convert.ToByte("X"C)) = 33.0
		c(Convert.ToByte("Y"C)) = 34.0
		c(Convert.ToByte("Z"C)) = 35.0
		c(Convert.ToByte("-"C)) = 36.0
		c(Convert.ToByte("."C)) = 37.0
		c(Convert.ToByte(" "C)) = 38.0
		c(Convert.ToByte("$"C)) = 39.0
		c(Convert.ToByte("/"C)) = 40.0
		c(Convert.ToByte("+"C)) = 41.0
		c(Convert.ToByte("%"C)) = 42.0
		c(Convert.ToByte("*"C)) = 43.0

		Return c
	End Function


	Public Function IsQRNumericString(ByRef chars As Char ()) As Boolean
		Dim i As Double
		Dim valid As Boolean

		valid = true

		i = 0.0
		While i < chars.Length
			If IsQRNumericCharacter(chars(i))
			Else
				valid = false
			End If
			i = i + 1.0
		End While

		Return valid
	End Function


	Public Function IsQRNumericCharacter(aChar As Char) As Boolean
		Return cIsNumber(aChar)
	End Function


	Public Function IsQRAlphanumericString(ByRef chars As Char ()) As Boolean
		Dim i As Double
		Dim valid As Boolean
		Dim c As Char

		valid = true

		i = 0.0
		While i < chars.Length
			c = chars(i)

			valid = IsQRAlphanumericCharacter(c)
			i = i + 1.0
		End While

		Return valid
	End Function


	Public Function IsQRAlphanumericCharacter(c As Char) As Boolean
		Dim valid As Boolean

		valid = true

		If cIsNumber(c)
		ElseIf IsQRAlphaUppercase(c)
		ElseIf c = " "C
		ElseIf c = "$"C
		ElseIf c = "%"C
		ElseIf c = "*"C
		ElseIf c = "+"C
		ElseIf c = "-"C
		ElseIf c = "."C
		ElseIf c = "/"C
		ElseIf c = ":"C
		Else
			valid = false
		End If
		Return valid
	End Function


	Public Function IsQRJIS8Character(c As Char) As Boolean
		Dim code As Double
		Dim valid As Boolean

		code = Convert.ToInt16(c)

		If code >= 0.0 And code < 128.0
			valid = true
		Else
			valid = false
		End If

		Return valid
	End Function


	Public Function IsQRAlphaUppercase(character As Char) As Boolean
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


	Public Function QRAlphanumericToCode(c As Char) As Double
		Dim code As Double

		If c = "0"C
			code = 0.0
		ElseIf c = "1"C
			code = 1.0
		ElseIf c = "2"C
			code = 2.0
		ElseIf c = "3"C
			code = 3.0
		ElseIf c = "4"C
			code = 4.0
		ElseIf c = "5"C
			code = 5.0
		ElseIf c = "6"C
			code = 6.0
		ElseIf c = "7"C
			code = 7.0
		ElseIf c = "8"C
			code = 8.0
		ElseIf c = "9"C
			code = 9.0
		ElseIf c = "A"C
			code = 10.0
		ElseIf c = "B"C
			code = 11.0
		ElseIf c = "C"C
			code = 12.0
		ElseIf c = "D"C
			code = 13.0
		ElseIf c = "E"C
			code = 14.0
		ElseIf c = "F"C
			code = 15.0
		ElseIf c = "G"C
			code = 16.0
		ElseIf c = "H"C
			code = 17.0
		ElseIf c = "I"C
			code = 18.0
		ElseIf c = "J"C
			code = 19.0
		ElseIf c = "K"C
			code = 20.0
		ElseIf c = "L"C
			code = 21.0
		ElseIf c = "M"C
			code = 22.0
		ElseIf c = "N"C
			code = 23.0
		ElseIf c = "O"C
			code = 24.0
		ElseIf c = "P"C
			code = 25.0
		ElseIf c = "Q"C
			code = 26.0
		ElseIf c = "R"C
			code = 27.0
		ElseIf c = "S"C
			code = 28.0
		ElseIf c = "T"C
			code = 29.0
		ElseIf c = "U"C
			code = 30.0
		ElseIf c = "V"C
			code = 31.0
		ElseIf c = "W"C
			code = 32.0
		ElseIf c = "X"C
			code = 33.0
		ElseIf c = "Y"C
			code = 34.0
		ElseIf c = "Z"C
			code = 35.0
		ElseIf c = " "C
			code = 36.0
		ElseIf c = "$"C
			code = 37.0
		ElseIf c = "%"C
			code = 38.0
		ElseIf c = "*"C
			code = 39.0
		ElseIf c = "+"C
			code = 40.0
		ElseIf c = "-"C
			code = 41.0
		ElseIf c = "."C
			code = 42.0
		ElseIf c = "/"C
			code = 43.0
		ElseIf c = ":"C
			code = 44.0
		Else
			code = 0.0
		End If

		Return code
	End Function


	Public Function QRAddErrorCodesAndInterleave(ByRef cws As Double (), version As Double, errorCorrectionLevel As Char) As Double ()
		Dim eccsPerBlock, errorCorrectionLevelNumber, nrOfBlocks, i, j, cw, cwsInBlock, e As Double
		Dim ecc, eccPerBlockSpec, blockSpecs, blockLengths, block, complete As Double ()
		Dim blocks, blockEccs As NumberArrayReference ()

		eccPerBlockSpec = StringToNumberArray("7, 10, 13, 17, 10, 16, 22, 28, 15, 26, 18, 22, 20, 18, 26, 16, 26, 24, 18, 22, 18, 16, 24, 28, 20, 18, 18, 26, 24, 22, 22, 26, 30, 22, 20, 24, 18, 26, 24, 28, 20, 30, 28, 24, 24, 22, 26, 28, 26, 22, 24, 22, 30, 24, 20, 24, 22, 24, 30, 24, 24, 28, 24, 30, 28, 28, 28, 28, 30, 26, 28, 28, 28, 26, 26, 26, 28, 26, 30, 28, 28, 26, 28, 30, 28, 28, 30, 24, 30, 28, 30, 30, 30, 28, 30, 30, 26, 28, 30, 30, 28, 28, 28, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30".ToCharArray())

		blockSpecs = StringToNumberArray("1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2, 4, 1, 2, 4, 4, 2, 4, 4, 4, 2, 4, 6, 5, 2, 4, 6, 6, 2, 5, 8, 8, 4, 5, 8, 8, 4, 5, 8, 11, 4, 8, 10, 11, 4, 9, 12, 16, 4, 9, 16, 16, 6, 10, 12, 18, 6, 10, 17, 16, 6, 11, 16, 19, 6, 13, 18, 21, 7, 14, 21, 25, 8, 16, 20, 25, 8, 17, 23, 25, 9, 17, 23, 34, 9, 18, 25, 30, 10, 20, 27, 32, 12, 21, 29, 35, 12, 23, 34, 37, 12, 25, 34, 40, 13, 26, 35, 42, 14, 28, 38, 45, 15, 29, 40, 48, 16, 31, 43, 51, 17, 33, 45, 54, 18, 35, 48, 57, 19, 37, 51, 60, 19, 38, 53, 63, 20, 40, 56, 66, 21, 43, 59, 70, 22, 45, 62, 74, 24, 47, 65, 77, 25, 49, 68, 81".ToCharArray())

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevel)

		eccsPerBlock = eccPerBlockSpec((version - 1.0)*4.0 + errorCorrectionLevelNumber)
		nrOfBlocks = blockSpecs((version - 1.0)*4.0 + errorCorrectionLevelNumber)

		blockLengths = QRComputeBlockLengths(cws.Length, nrOfBlocks)

		blocks = New NumberArrayReference (nrOfBlocks - 1){}
		blockEccs = New NumberArrayReference (nrOfBlocks - 1){}

		cw = 0.0
		i = 0.0
		While i < nrOfBlocks
			' Create block.
			cwsInBlock = blockLengths(i)
			block = New Double (cwsInBlock - 1){}
			j = 0.0
			While j < cwsInBlock
				block(j) = cws(cw)
				cw = cw + 1.0
				j = j + 1.0
			End While

			' Compute eccs.
			ecc = ComputeReedSolomonCodes(block, eccsPerBlock)

			blocks(i) = New NumberArrayReference()
			blocks(i).numberArray = block
			blockEccs(i) = New NumberArrayReference()
			blockEccs(i).numberArray = ecc
			i = i + 1.0
		End While

		' Compose full data block:
		complete = New Double (cws.Length + eccsPerBlock*nrOfBlocks - 1){}

		e = 0.0
		' Interleave codewords:
		i = 0.0
		While i < Floor(cws.Length/nrOfBlocks)
			j = 0.0
			While j < nrOfBlocks
				complete(e) = blocks(j).numberArray(i)
				e = e + 1.0
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		' Interleave remaining code words:
		i = 0.0
		While i < nrOfBlocks
			If blockLengths(i) > blockLengths(0)
				complete(e) = blocks(i).numberArray(blockLengths(i) - 1.0)
				e = e + 1.0
			End If
			i = i + 1.0
		End While

		i = 0.0
		While i < eccsPerBlock
			j = 0.0
			While j < nrOfBlocks
				complete(e) = blockEccs(j).numberArray(i)
				e = e + 1.0
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return complete
	End Function


	Public Function QRComputeBlockLengths(length As Double, blocks As Double) As Double ()
		Dim q, r, i As Double
		Dim blockLengths As Double ()

		blockLengths = New Double (blocks - 1){}

		q = Floor(length/blocks)
		r = length Mod blocks

		i = 0.0
		While i < blocks
			blockLengths(i) = q
			i = i + 1.0
		End While

		If r > 0.0
			i = 0.0
			While i < r
				blockLengths(blockLengths.Length - 1.0 - i) = q + 1.0
				i = i + 1.0
			End While
		End If

		Return blockLengths
	End Function


	Public Function GenerateQRCode(ByRef imageReference As RGBABitmapImageReference, ByRef chars As Char (), errorCorrectionLevel As Char, ByRef errorMessage As StringReference) As Boolean
		Dim version As Double
		Dim versionReference As NumberReference
		Dim success As Boolean

		versionReference = New NumberReference()
		success = QRGetRequiredVersionFromData(chars, errorCorrectionLevel, versionReference, errorMessage)

		If success
			version = versionReference.numberValue

			GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, QRQuietZoneSize(), errorMessage)
		End If

		Return success
	End Function


	Public Function QRGetRequiredVersionFromData(ByRef chars As Char (), errorCorrectionLevelCode As Char, ByRef versionReference As NumberReference, ByRef errorMessage As StringReference) As Boolean
		Dim modeReference As StringReference
		Dim success, done As Boolean
		Dim i, l, errorCorrectionLevelNumber As Double
		Dim modeName As Char ()
		Dim symbolBitsSpec As Double ()
		Dim lengthReference As NumberReference

		modeReference = New StringReference()
		success = QRDetectMode(chars, modeReference, errorMessage)

		If success
			modeName = modeReference.stringx

			symbolBitsSpec = GetQRSymbolLengthsForVersions()

			errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

			done = false
			lengthReference = New NumberReference()
			i = 1.0
			While i <= 40.0 And Not done
				success = QRComputeNumberOfCodewords(chars.Length, i, modeName, lengthReference, errorMessage)

				If success
					l = lengthReference.numberValue

					If l <= symbolBitsSpec((i - 1.0)*4.0 + errorCorrectionLevelNumber)
						versionReference.numberValue = i
						done = true
					End If
				Else
					done = true
				End If
				i = i + 1.0
			End While

			If Not done
				success = false
				errorMessage.stringx = "Too much data for any QR code.".ToCharArray()
			End If
		End If

		Return success
	End Function


	Public Function GenerateQRCodeWithAllOptions(ByRef imageReference As RGBABitmapImageReference, ByRef chars As Char (), version As Double, errorCorrectionLevel As Char, quietZoneSize As Double, ByRef errorMessage As StringReference) As Boolean
		Dim image, quietZoneImage, basis As RGBABitmapImage
		Dim masks, withMasks As RGBABitmapImage ()
		Dim size, sizeWithQuietZone, i, minx, choice As Double
		Dim bs, formatbits, mode As Char ()
		Dim cws, allcws, pentalies As Double ()
		Dim success As Boolean
		Dim modeReference, bsReference As StringReference

		modeReference = New StringReference()
		success = QRDetectMode(chars, modeReference, errorMessage)

		If success
			mode = modeReference.stringx

			size = QRVersionToModules(version)

			image = CreateImage(size, size, GetTransparent())

			Call QRAddTimingPattern(image, version)

			Call QRAddFinderPattern(image, version)

			Call QRAddAlignmentPatterns(image, version)

			Call QRAddDummyFormatBits(image, version)

			If version >= 7.0
				Call QRAddVersionBits(image, version)
			End If

			bsReference = New StringReference()

			success = GetQRCodewordBitSequence(chars, version, mode, bsReference, errorMessage)

			If success
				bs = bsReference.stringx

				cws = QRSegmentsToCodeWords(bs, version, errorCorrectionLevel)
				allcws = QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel)

				basis = CopyImage(image)

				Call QRAddCodewords(image, version, allcws)

				formatbits = New Char (15 - 1){}

				masks = New RGBABitmapImage (8 - 1){}
				withMasks = New RGBABitmapImage (8 - 1){}
				pentalies = New Double (8 - 1){}
				i = 0.0
				While i < 8.0
					masks(i) = CreateMask(i, version)
					withMasks(i) = QRApplyMask(basis, image, masks(i))
					Call QRComputeFormatBits(formatbits, errorCorrectionLevel, i)
					Call QRAddFormatBits(withMasks(i), formatbits)
					'System.out.println("Mask " + (int)i);
					pentalies(i) = QRComputePenalty(withMasks(i))
					i = i + 1.0
				End While

				choice = 0.0
				minx = pentalies(choice)
				i = 0.0
				While i < 8.0
					If pentalies(i) < minx
						choice = i
						minx = pentalies(choice)
					End If
					i = i + 1.0
				End While

				image = withMasks(choice)

				sizeWithQuietZone = size + 2.0*quietZoneSize
				quietZoneImage = CreateImage(sizeWithQuietZone, sizeWithQuietZone, GetWhite())
				Call DrawImageOnImage(quietZoneImage, image, quietZoneSize, quietZoneSize)

				imageReference.image = quietZoneImage
			End If
		End If

		Return success
	End Function


	Public Function GetQRCodewordBitSequence(ByRef chars As Char (), version As Double, ByRef modeName As Char (), ByRef bsReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim success As Boolean

		If arraysStringsEqual(modeName, "Numeric".ToCharArray())
			success = QRNumericDataToSegment(chars, version, bsReference, errorMessage)
		ElseIf arraysStringsEqual(modeName, "Alphanumeric".ToCharArray())
			success = QRAlphanumericDataToSegment(chars, version, bsReference, errorMessage)
		ElseIf arraysStringsEqual(modeName, "8-bit Byte".ToCharArray())
			success = QR8BitByteDataToSegment(chars, version, bsReference, errorMessage)
		Else
			success = false
			errorMessage.stringx = "Invalid data mode.".ToCharArray()
		End If

		Return success
	End Function


	Public Function QRComputeNumberOfCodewords(dataLength As Double, version As Double, ByRef modeName As Char (), ByRef lengthReference As NumberReference, ByRef errorMessage As StringReference) As Boolean
		Dim length, r, last, c As Double
		Dim success As Boolean
		Dim countReference As NumberReference

		length = 0.0
		countReference = New NumberReference()

		success = QRGetCountLength(version, modeName, countReference, errorMessage)

		If success
			c = countReference.numberValue

			If arraysStringsEqual(modeName, "Numeric".ToCharArray())
				r = 0.0
				last = dataLength Mod 3.0
				If last = 0.0
					r = 0.0
				ElseIf last = 1.0
					r = 4.0
				ElseIf last = 2.0
					r = 7.0
				End If

				length = 4.0 + c + 10.0*Floor(dataLength/3.0) + r
			ElseIf arraysStringsEqual(modeName, "Alphanumeric".ToCharArray())
				length = 4.0 + c + 11.0*Floor(dataLength/2.0) + 6.0*(dataLength Mod 2.0)
			ElseIf arraysStringsEqual(modeName, "8-bit Byte".ToCharArray())
				length = 4.0 + c + 8.0*dataLength
			Else
				success = false
			End If
		Else
			success = false
		End If

		If success
			lengthReference.numberValue = length
		End If

		Return success
	End Function


	Public Sub QRAddVersionBits(ByRef image As RGBABitmapImage, version As Double)
		Dim ecc, i, x, y, offset As Double
		Dim str As StringReference
		Dim code As Char ()

		ecc = ComputeBHC18_6Code(version)

		code = New Char (18 - 1){}

		str = New StringReference()
		CreateStringFromNumberWithCheck(version, 2.0, str)

		offset = 6.0 - str.stringx.Length
		i = 0.0
		While i < 6.0
			If i < offset
				code(i) = "0"C
			Else
				code(i) = str.stringx(i - offset)
			End If
			i = i + 1.0
		End While

		CreateStringFromNumberWithCheck(ecc, 2.0, str)

		offset = 12.0 - str.stringx.Length
		i = 0.0
		While i < 12.0
			If i < offset
				code(6.0 + i) = "0"C
			Else
				code(6.0 + i) = str.stringx(i - offset)
			End If
			i = i + 1.0
		End While

		i = 0.0
		While i < 18.0
			x = ImageWidth(image) - 11.0 + i Mod 3.0
			y = 0.0 + Floor(i/3.0)

			If code(18.0 - 1.0 - i) = "1"C
				Call SetPixel(image, x, y, GetBlack())
				Call SetPixel(image, y, x, GetBlack())
			Else
				Call SetPixel(image, x, y, GetWhite())
				Call SetPixel(image, y, x, GetWhite())
			End If
			i = i + 1.0
		End While
	End Sub


	Public Sub QRAddAlignmentPatterns(ByRef image As RGBABitmapImage, version As Double)
		Dim i, j, x, y, nrOfPositions As Double
		Dim positions, col2, col3, col4, col5, col6, col7 As Double ()
		Dim includePattern As Boolean

		positions = New Double (7 - 1){}

		col2 = StringToNumberArray("18, 22, 26, 30, 34, 22, 24, 26, 28, 30, 32, 34, 26, 26, 26, 30, 30, 30, 34, 28, 26, 30, 28, 32, 30, 34, 26, 30, 26, 30, 34, 30, 34, 30, 24, 28, 32, 26, 30".ToCharArray())
		col3 = StringToNumberArray("38, 42, 46, 50, 54, 58, 62, 46, 48, 50, 54, 56, 58, 62, 50, 50, 54, 54, 58, 58, 62, 50, 54, 52, 56, 60, 58, 62, 54, 50, 54, 58, 54, 58".ToCharArray())
		col4 = StringToNumberArray("66, 70, 74, 78, 82, 86, 90, 72, 74, 78, 80, 84, 86, 90, 74, 78, 78, 82, 86, 86, 90, 78, 76, 80, 84, 82, 86".ToCharArray())
		col5 = StringToNumberArray("94, 98, 102, 106, 110, 114, 118, 98, 102, 104, 108, 112, 114, 118, 102, 102, 106, 110, 110, 114".ToCharArray())
		col6 = StringToNumberArray("122, 126, 130, 134, 138, 142, 146, 126, 128, 132, 136, 138, 142".ToCharArray())
		col7 = StringToNumberArray("150, 154, 158, 162, 166, 170".ToCharArray())

		positions(0) = 6.0
		nrOfPositions = 0.0

		If version = 1.0
			nrOfPositions = 0.0
		End If
		If version >= 2.0
			nrOfPositions = 2.0
			positions(1) = col2(version - 2.0)
		End If
		If version >= 7.0
			nrOfPositions = 3.0
			positions(2) = col3(version - 7.0)
		End If
		If version >= 14.0
			nrOfPositions = 4.0
			positions(3) = col4(version - 14.0)
		End If
		If version >= 21.0
			nrOfPositions = 5.0
			positions(4) = col5(version - 21.0)
		End If
		If version >= 28.0
			nrOfPositions = 6.0
			positions(5) = col6(version - 28.0)
		End If
		If version >= 35.0
			nrOfPositions = 7.0
			positions(6) = col7(version - 35.0)
		End If

		i = 0.0
		While i < nrOfPositions
			j = 0.0
			While j < nrOfPositions
				x = positions(i)
				y = positions(j)

				If x <= 8.0 And y <= 8.0
					includePattern = false
				ElseIf x >= ImageWidth(image) - 8.0 And y <= 8.0
					includePattern = false
				ElseIf x <= 8.0 And y >= ImageWidth(image) - 7.0
					includePattern = false
				Else
					includePattern = true
				End If

				If includePattern
					Call QRAddAlignmentPattern(image, x, y)
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While
	End Sub


	Public Sub QRAddAlignmentPattern(ByRef image As RGBABitmapImage, x As Double, y As Double)
		Call DrawRectangle1px(image, x, y, 0.0, 0.0, GetBlack())
		Call DrawRectangle1px(image, x - 1.0, y - 1.0, 2.0, 2.0, GetWhite())
		Call DrawRectangle1px(image, x - 2.0, y - 2.0, 4.0, 4.0, GetBlack())
	End Sub


	Public Function QR8BitByteDataToSegment(ByRef data As Char (), version As Double, ByRef bsReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim bs, mode As Char ()
		Dim length, c, d, i, n, j, offset As Double
		Dim nstr As StringReference
		Dim lengthReference, countReference As NumberReference
		Dim success As Boolean

		countReference = New NumberReference()
		success = QRGetCountLength(version, "8-bit Byte".ToCharArray(), countReference, errorMessage)

		If success
			c = countReference.numberValue
			d = data.Length

			lengthReference = New NumberReference()
			success = QRComputeNumberOfCodewords(data.Length, version, "8-bit Byte".ToCharArray(), lengthReference, errorMessage)

			If success
				length = lengthReference.numberValue

				bs = arraysCreateString(length, "0"C)

				' Characters
				nstr = New StringReference()

				i = 0.0
				While i < d
					n = Convert.ToInt16(data(i))

					CreateStringFromNumberWithCheck(n, 2.0, nstr)

					offset = 8.0 - nstr.stringx.Length
					j = 0.0
					While j < nstr.stringx.Length
						bs(4.0 + c + 8.0*i + j + offset) = nstr.stringx(j)
						j = j + 1.0
					End While
					i = i + 1.0
				End While

				' Character count
				CreateStringFromNumberWithCheck(d, 2.0, nstr)
				offset = 4.0 + c - nstr.stringx.Length
				j = 0.0
				While j < nstr.stringx.Length
					bs(offset + j) = nstr.stringx(j)
					j = j + 1.0
				End While

				' Mode
				mode = QR8BitByteModeIndicator()
				j = 0.0
				While j < 4.0
					bs(j) = mode(j)
					j = j + 1.0
				End While

				bsReference.stringx = bs
			End If
		End If

		Return success
	End Function


	Public Function QRDetectMode(ByRef chars As Char (), ByRef modeReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim success As Boolean
		Dim i, mode As Double
		Dim c As Char

		mode = 0.0
		success = false

		i = 0.0
		While i < chars.Length
			c = chars(i)

			If cIsNumber(c)
				If mode = 0.0
					mode = 1.0
					success = true
				End If
			ElseIf IsQRAlphanumericCharacter(c)
				If mode <= 1.0
					mode = 2.0
					success = true
				End If
			ElseIf IsQRJIS8Character(c)
				If mode <= 2.0
					mode = 3.0
					success = true
				End If
			Else
				mode = 5.0
				success = false
				errorMessage.stringx = "Data contains invalid characters".ToCharArray()
			End If
			i = i + 1.0
		End While

		If mode = 0.0
			errorMessage.stringx = "There is no data to put in the QR code.".ToCharArray()
		End If
		If mode = 1.0
			modeReference.stringx = "Numeric".ToCharArray()
		End If
		If mode = 2.0
			modeReference.stringx = "Alphanumeric".ToCharArray()
		End If
		If mode = 3.0
			modeReference.stringx = "8-bit Byte".ToCharArray()
		End If

		Return success
	End Function


	Public Function QRComputePenalty(ByRef image As RGBABitmapImage) As Double
		Dim totalP, runP, boxP, findP, balP As Double

		runP = QRComputePenaltyForRuns(image)
		'System.out.println("runP: " + ", " + (int)runP);
		boxP = QRComputePenaltyForBoxes(image)
		'System.out.println("boxP: " + ", " + (int)boxP);
		findP = QRComputePenaltyForFinders(image)
		'System.out.println("findP: " + ", " + (int)findP);
		balP = QRComputePenaltyForBalance(image)
		'System.out.println("balP: " + ", " + (int)balP);
		' Total penalty
		totalP = runP + boxP + balP + findP + balP
		'System.out.println(totalP);
		Return totalP
	End Function


	Public Function QRComputePenaltyForBalance(ByRef image As RGBABitmapImage) As Double
		Dim x, y, h, w, balP, total, black, deviation As Double
		Dim isBlack As Boolean

		h = ImageHeight(image)
		w = ImageWidth(image)

		total = h*w
		black = 0.0

		y = 0.0
		While y < h
			x = 0.0
			While x < w
				isBlack = PixelIsBlack(image, x, y)

				If isBlack
					black = black + 1.0
				End If
				x = x + 1.0
			End While
			y = y + 1.0
		End While

		deviation = Abs(100.0*black/total - 50.0)
		balP = Floor(deviation/5.0)*10.0

		Return balP
	End Function


	Public Function QRComputePenaltyForFinders(ByRef image As RGBABitmapImage) As Double
		Dim x, y, h, w, findP As Double
		Dim d1, w1, d2, d3, d4, w2, d5, w3, w4, w5, w6 As Boolean

		h = ImageHeight(image)
		w = ImageWidth(image)

		findP = 0.0
		y = 0.0
		While y < h
			x = 0.0
			While x < w - 10.0
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

				If d1 And Not w1 And d2 And d3 And d4 And Not w2 And d5 And Not w3 And Not w4 And Not w5 And Not w6
					findP = findP + 40.0
				End If

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

				If d1 And Not w1 And d2 And d3 And d4 And Not w2 And d5 And Not w3 And Not w4 And Not w5 And Not w6
					findP = findP + 40.0
				End If
				x = x + 1.0
			End While
			y = y + 1.0
		End While

		x = 0.0
		While x < w
			y = 0.0
			While y < h - 10.0
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

				If d1 And Not w1 And d2 And d3 And d4 And Not w2 And d5 And Not w3 And Not w4 And Not w5 And Not w6
					findP = findP + 40.0
				End If

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

				If d1 And Not w1 And d2 And d3 And d4 And Not w2 And d5 And Not w3 And Not w4 And Not w5 And Not w6
					findP = findP + 40.0
				End If
				y = y + 1.0
			End While
			x = x + 1.0
		End While

		Return findP
	End Function


	Public Function QRComputePenaltyForBoxes(ByRef image As RGBABitmapImage) As Double
		Dim x, y, h, w, boxP As Double
		Dim ul, ur, ll, lr As Boolean

		h = ImageHeight(image)
		w = ImageWidth(image)

		boxP = 0.0
		y = 0.0
		While y < h - 1.0
			x = 0.0
			While x < w - 1.0
				ul = PixelIsBlack(image, x + 0.0, y + 0.0)
				ur = PixelIsBlack(image, x + 1.0, y + 0.0)
				ll = PixelIsBlack(image, x + 0.0, y + 1.0)
				lr = PixelIsBlack(image, x + 1.0, y + 1.0)

				If ul And ur And ll And lr Or Not ul And Not ur And Not ll And Not lr
					boxP = boxP + 3.0
				End If
				x = x + 1.0
			End While
			y = y + 1.0
		End While

		Return boxP
	End Function


	Public Function PixelIsBlack(ByRef image As RGBABitmapImage, x As Double, y As Double) As Boolean
		Return GetImagePixel(image, x, y).r = 0.0
	End Function


	Public Function QRComputePenaltyForRuns(ByRef image As RGBABitmapImage) As Double
		Dim first, prev, cur As Boolean
		Dim run, x, y, h, w, runP As Double
		Dim last As Boolean

		h = ImageHeight(image)
		w = ImageWidth(image)

		runP = 0.0

		' Horizontal penalty
		y = 0.0
		While y < h
			first = true
			prev = true
			cur = true
			run = 1.0

			x = 0.0
			While x <= w
				last = x = w
				If Not last
					cur = PixelIsBlack(image, x, y)
				End If

				If Not first
					If prev = cur And Not last
						run = run + 1.0
					End If

					If prev <> cur Or last
						If run >= 5.0
							runP = runP + 3.0 + run - 5.0
						End If
						run = 1.0
					End If
				End If

				first = false
				prev = cur
				x = x + 1.0
			End While
			y = y + 1.0
		End While

		' Vertical penalty
		x = 0.0
		While x < w
			first = true
			prev = true
			cur = true
			run = 1.0

			y = 0.0
			While y <= h
				last = y = h
				If Not last
					cur = PixelIsBlack(image, x, y)
				End If

				If Not first
					If prev = cur And Not last
						run = run + 1.0
					End If

					If prev <> cur Or last
						If run >= 5.0
							runP = runP + 3.0 + run - 5.0
						End If
						run = 1.0
					End If
				End If

				first = false
				prev = cur
				y = y + 1.0
			End While
			x = x + 1.0
		End While
		Return runP
	End Function


	Public Sub QRAddFormatBits(ByRef image As RGBABitmapImage, ByRef formatbits As Char ())
		Dim b As Char
		Dim i, x, y As Double
		Dim black, white, color As RGBA

		black = GetBlack()
		white = GetWhite()

		x = 8.0
		y = 0.0

		' Upper-left
		i = 0.0
		While i < formatbits.Length
			b = formatbits(14.0 - i)
			If b = "1"C
				color = black
			Else
				color = white
			End If

			Call SetPixel(image, x, y, color)

			If i < 7.0
				y = y + 1.0
			End If
			If i = 5.0
				y = y + 1.0
			End If

			If i >= 7.0
				x = x - 1.0
			End If
			If i = 8.0
				x = x - 1.0
			End If
			i = i + 1.0
		End While

		' Lower left and top right
		x = ImageWidth(image) - 1.0
		y = 8.0

		i = 0.0
		While i < formatbits.Length
			b = formatbits(14.0 - i)
			If b = "1"C
				color = black
			Else
				color = white
			End If

			Call SetPixel(image, x, y, color)

			If i < 7.0
				x = x - 1.0
			End If
			If i = 7.0
				y = ImageHeight(image) - 7.0
				x = 8.0
			End If

			If i > 7.0
				y = y + 1.0
			End If
			i = i + 1.0
		End While
	End Sub


	Public Sub QRComputeFormatBits(ByRef bits As Char (), errorCorrectionLevel As Char, mask As Double)
		Dim i, bhc, offset, errorCorrectionCode, n As Double
		Dim xorpattern As Char ()
		Dim str As StringReference
		Dim a, b, r As Boolean

		errorCorrectionCode = 0.0
		If errorCorrectionLevel = "L"C
			errorCorrectionCode = 1.0
		ElseIf errorCorrectionLevel = "M"C
			errorCorrectionCode = 0.0
		ElseIf errorCorrectionLevel = "Q"C
			errorCorrectionCode = 3.0
		ElseIf errorCorrectionLevel = "H"C
			errorCorrectionCode = 2.0
		End If

		n = OrByte(ShiftLeftByte(errorCorrectionCode, 3.0), mask)

		bhc = ComputeBHC15_5Code(n)

		n = Or4Byte(ShiftLeft4Byte(n, 10.0), bhc)

		str = New StringReference()
		CreateStringFromNumberWithCheck(n, 2.0, str)

		offset = 15.0 - str.stringx.Length
		i = 0.0
		While i < 15.0
			If i < offset
				bits(i) = "0"C
			Else
				bits(i) = str.stringx(i - offset)
			End If
			i = i + 1.0
		End While

		xorpattern = "101010000010010".ToCharArray()

		i = 0.0
		While i < 15.0
			a = bits(i) = "1"C
			b = xorpattern(i) = "1"C

			r = Xorx(a, b)

			If r
				bits(i) = "1"C
			Else
				bits(i) = "0"C
			End If
			i = i + 1.0
		End While
	End Sub


	Public Function QRApplyMask(ByRef basis As RGBABitmapImage, ByRef image As RGBABitmapImage, ByRef mask As RGBABitmapImage) As RGBABitmapImage
		Dim withMask As RGBABitmapImage
		Dim i, j As Double
		Dim a, b, r As Boolean

		withMask = CopyImage(image)

		i = 0.0
		While i < ImageWidth(basis)
			j = 0.0
			While j < ImageHeight(basis)
				If GetImagePixel(basis, i, j).a = 0.0
					a = PixelIsBlack(image, i, j)
					b = PixelIsBlack(mask, i, j)

					' xor
					r = Xorx(a, b)

					If r
						Call SetPixel(withMask, i, j, GetBlack())
					Else
						Call SetPixel(withMask, i, j, GetWhite())
					End If
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return withMask
	End Function


	Public Function Xorx(a As Boolean, b As Boolean) As Boolean
		Return a And Not b Or Not a And b
	End Function


	Public Function CreateMask(mask As Double, version As Double) As RGBABitmapImage
		Dim size, i, j As Double
		Dim black As Boolean
		Dim image As RGBABitmapImage

		size = QRVersionToModules(version)

		image = CreateImage(size, size, GetTransparent())

		black = true
		i = 0.0
		While i < size
			j = 0.0
			While j < size
				If mask = 0.0
					black = (i + j) Mod 2.0 = 0.0
				ElseIf mask = 1.0
					black = i Mod 2.0 = 0.0
				ElseIf mask = 2.0
					black = j Mod 3.0 = 0.0
				ElseIf mask = 3.0
					black = (i + j) Mod 3.0 = 0.0
				ElseIf mask = 4.0
					black = (Floor(i/2.0) + Floor(j/3.0)) Mod 2.0 = 0.0
				ElseIf mask = 5.0
					black = (i*j) Mod 2.0 + (i*j) Mod 3.0 = 0.0
				ElseIf mask = 6.0
					black = ((i*j) Mod 2.0 + (i*j) Mod 3.0) Mod 2.0 = 0.0
				ElseIf mask = 7.0
					black = ((i*j) Mod 3.0 + (i + j) Mod 2.0) Mod 2.0 = 0.0
				End If

				If black
					Call SetPixel(image, j, i, GetBlack())
				Else
					Call SetPixel(image, j, i, GetWhite())
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return image
	End Function


	Public Sub QRAddDummyFormatBits(ByRef image As RGBABitmapImage, version As Double)
		Dim i, size As Double

		size = QRVersionToModules(version)

		i = 0.0
		While i < 9.0
			If i <> 6.0
				Call SetPixel(image, i, 8.0, GetWhite())
				Call SetPixel(image, 8.0, i, GetWhite())
			End If
			If i <> 8.0
				Call SetPixel(image, size - 1.0 - i, 8.0, GetWhite())
				Call SetPixel(image, 8.0, size - 1.0 - i, GetWhite())
			End If
			i = i + 1.0
		End While

		Call SetPixel(image, 8.0, size - 8.0, GetBlack())
	End Sub


	Public Sub QRAddCodewords(ByRef image As RGBABitmapImage, version As Double, ByRef cws As Double ())
		Dim ll As LinkedListCharacters
		Dim i, j, x, y, size, offset, bit As Double
		Dim s As StringReference
		Dim bits As Char ()
		Dim b As Char
		Dim w, d As Boolean
        
		ll = CreateLinkedListCharacter()
		s = New StringReference()
        
		i = 0.0
		While i < cws.Length
			CreateStringFromNumberWithCheck(cws(i), 2.0, s)

			offset = 8.0 - s.stringx.Length
			j = 0.0
			While j < 8.0
				If j < offset
					Call LinkedListAddCharacter(ll, "0"C)
				Else
					Call LinkedListAddCharacter(ll, s.stringx(j - offset))
				End If
				j = j + 1.0
			End While

			Erase s.stringx 
			i = i + 1.0
		End While

		bits = LinkedListCharactersToArray(ll)

		size = QRVersionToModules(version)
		x = size - 1.0
		y = size - 1.0
		d = true
		w = true
		bit = 0.0
		offset = 0.0
		i = 0.0
		While i < size ^ 2.0 - size
			If GetImagePixel(image, x - offset, y).a = 0.0
				If bit < bits.Length
					b = bits(bit)

					If b = "1"C
						Call SetPixel(image, (x - offset), y, GetBlack())
					Else
						Call SetPixel(image, (x - offset), y, GetWhite())
					End If

					bit = bit + 1.0
				Else
					' Some symbols have nothing at the end.
					Call SetPixel(image, (x - offset), y, GetWhite())
				End If
			End If

			If d
				If w
					x = x - 1.0
				Else
					x = x + 1.0
					y = y - 1.0
				End If
			ElseIf w
				x = x - 1.0
			Else
				x = x + 1.0
				y = y + 1.0
			End If

			w = Not w

			If i Mod (2.0*size) = 2.0*size - 1.0
				If d
					x = x - 2.0
					y = y + 1.0
					w = true
				Else
					x = x - 2.0
					y = y - 1.0
					w = true
				End If

				d = Not d
			End If

			If x = 6.0
				offset = 1.0
			End If
			i = i + 1.0
		End While
	End Sub


	Public Sub QRAddTimingPattern(ByRef image As RGBABitmapImage, version As Double)
		Dim size, i As Double
		Dim black As Boolean

		size = QRVersionToModules(version)

		black = true
		i = 0.0
		While i < size
			If black
				Call SetPixel(image, i, 6.0, GetBlack())
				Call SetPixel(image, 6.0, i, GetBlack())
			Else
				Call SetPixel(image, i, 6.0, GetWhite())
				Call SetPixel(image, 6.0, i, GetWhite())
			End If

			black = Not black
			i = i + 1.0
		End While
	End Sub


	Public Sub QRAddFinderPattern(ByRef image As RGBABitmapImage, version As Double)
		Dim finderPattern As RGBABitmapImage
		Dim size As Double

		size = QRVersionToModules(version)
		finderPattern = GetQRFinderPattern()
		Call DrawImageOnImage(image, finderPattern, -1.0, -1.0)
		Call DrawImageOnImage(image, finderPattern, size - 7.0 - 1.0, -1.0)
		Call DrawImageOnImage(image, finderPattern, -1.0, size - 7.0 - 1.0)
	End Sub


	Public Function GetQRFinderPattern() As RGBABitmapImage
		Dim fp As RGBABitmapImage

		fp = CreateImage(9.0, 9.0, GetBlack())

		Call DrawRectangle1px(fp, 2.0, 2.0, 4.0, 4.0, GetWhite())
		Call DrawRectangle1px(fp, 0.0, 0.0, 8.0, 8.0, GetWhite())

		Return fp
	End Function


	Public Function QRQuietZoneSize() As Double
		Return 4.0
	End Function


	Public Function QRVersionToModules(version As Double) As Double
		Return 17.0 + 4.0*version
	End Function


	Public Function QRNumericDataToSegment(ByRef data As Char (), version As Double, ByRef bsReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim bs, group, mode As Char ()
		Dim length, c, d, r, i, n, j, offset, last As Double
		Dim nstr As StringReference
		Dim countReference, lengthReference As NumberReference
		Dim success As Boolean

		countReference = New NumberReference()
		success = QRGetCountLength(version, "Numeric".ToCharArray(), countReference, errorMessage)

		If success
			c = countReference.numberValue
			d = data.Length

			r = 0.0
			last = d Mod 3.0
			If last = 0.0
				r = 0.0
			ElseIf last = 1.0
				r = 4.0
			ElseIf last = 2.0
				r = 7.0
			End If

			lengthReference = New NumberReference()
			success = QRComputeNumberOfCodewords(data.Length, version, "Numeric".ToCharArray(), lengthReference, errorMessage)
			If success
				length = lengthReference.numberValue

				bs = arraysCreateString(length, "0"C)

				' Characters
				group = New Char (3 - 1){}
				nstr = New StringReference()

				i = 0.0
				While i < Floor(d/3.0)
					group(0) = data(i*3.0 + 0.0)
					group(1) = data(i*3.0 + 1.0)
					group(2) = data(i*3.0 + 2.0)

					n = CreateNumberFromDecimalString(group)
					CreateStringFromNumberWithCheck(n, 2.0, nstr)

					offset = 10.0 - nstr.stringx.Length
					j = 0.0
					While j < nstr.stringx.Length
						bs(4.0 + c + i*10.0 + offset + j) = nstr.stringx(j)
						j = j + 1.0
					End While
					i = i + 1.0
				End While

				If last = 1.0
					group(0) = "0"C
					group(1) = "0"C
					group(2) = data(data.Length - 1.0)
				End If

				If last = 2.0
					group(0) = "0"C
					group(1) = data(data.Length - 2.0)
					group(2) = data(data.Length - 1.0)
				End If

				If last = 1.0 Or last = 2.0
					n = CreateNumberFromDecimalString(group)
					CreateStringFromNumberWithCheck(n, 2.0, nstr)

					offset = r - nstr.stringx.Length
					j = 0.0
					While j < nstr.stringx.Length
						bs(bs.Length - r + offset + j) = nstr.stringx(j)
						j = j + 1.0
					End While
				End If

				' Character count
				CreateStringFromNumberWithCheck(d, 2.0, nstr)
				offset = 4.0 + c - nstr.stringx.Length
				j = 0.0
				While j < nstr.stringx.Length
					bs(offset + j) = nstr.stringx(j)
					j = j + 1.0
				End While

				' Mode
				mode = QRNumericModeIndicator()
				j = 0.0
				While j < 4.0
					bs(j) = mode(j)
					j = j + 1.0
				End While

				bsReference.stringx = bs
			End If
		End If

		Return success
	End Function


	Public Function QRGetCountLength(version As Double, ByRef modeName As Char (), ByRef cReference As NumberReference, ByRef errorMessage As StringReference) As Boolean
		Dim c As Double
		Dim success As Boolean

		success = true
		c = 0.0

		If arraysStringsEqual(modeName, "Numeric".ToCharArray())
			If version >= 1.0 And version <= 9.0
				c = 10.0
			ElseIf version >= 10.0 And version <= 26.0
				c = 12.0
			ElseIf version >= 27.0 And version <= 40.0
				c = 14.0
			Else
				success = false
				errorMessage.stringx = "Invalid version number.".ToCharArray()
			End If
		ElseIf arraysStringsEqual(modeName, "Alphanumeric".ToCharArray())
			If version >= 1.0 And version <= 9.0
				c = 9.0
			ElseIf version >= 10.0 And version <= 26.0
				c = 11.0
			ElseIf version >= 27.0 And version <= 40.0
				c = 13.0
			Else
				success = false
				errorMessage.stringx = "Invalid version number.".ToCharArray()
			End If
		ElseIf arraysStringsEqual(modeName, "8-bit Byte".ToCharArray())
			If version >= 1.0 And version <= 9.0
				c = 8.0
			ElseIf version >= 10.0 And version <= 26.0
				c = 16.0
			ElseIf version >= 27.0 And version <= 40.0
				c = 16.0
			Else
				success = false
				errorMessage.stringx = "Invalid version number.".ToCharArray()
			End If
		Else
			success = false
			errorMessage.stringx = "Invalid mode name.".ToCharArray()
		End If

		If success
			cReference.numberValue = c
		End If

		Return success
	End Function


	Public Function QRNumericModeIndicator() As Char ()
		Return "0001".ToCharArray()
	End Function


	Public Function QRAlphanumericModeIndicator() As Char ()
		Return "0010".ToCharArray()
	End Function


	Public Function QRTerminatorModeIndicator() As Char ()
		Return "0000".ToCharArray()
	End Function


	Public Function QR8BitByteModeIndicator() As Char ()
		Return "0100".ToCharArray()
	End Function


	Public Function QRKanjiModeIndicator() As Char ()
		Return "1000".ToCharArray()
	End Function


	Public Function QRAlphanumericDataToSegment(ByRef data As Char (), version As Double, ByRef bsReference As StringReference, ByRef errorMessage As StringReference) As Boolean
		Dim bs, mode As Char ()
		Dim length, c, d, i, n, j, offset, c0, c1 As Double
		Dim nstr As StringReference
		Dim success As Boolean
		Dim lengthReference, countReference As NumberReference

		countReference = New NumberReference()
		success = QRGetCountLength(version, "Alphanumeric".ToCharArray(), countReference, errorMessage)

		If success
			c = countReference.numberValue
			d = data.Length

			lengthReference = New NumberReference()
			success = QRComputeNumberOfCodewords(data.Length, version, "Alphanumeric".ToCharArray(), lengthReference, errorMessage)

			If success
				length = lengthReference.numberValue

				bs = arraysCreateString(length, "0"C)

				' Characters
				nstr = New StringReference()

				i = 0.0
				While i < Floor(d/2.0)
					c0 = QRAlphanumericToCode(data(i*2.0 + 0.0))
					c1 = QRAlphanumericToCode(data(i*2.0 + 1.0))

					n = c0*45.0 + c1

					CreateStringFromNumberWithCheck(n, 2.0, nstr)

					offset = 11.0 - nstr.stringx.Length
					j = 0.0
					While j < nstr.stringx.Length
						bs(4.0 + c + i*11.0 + offset + j) = nstr.stringx(j)
						j = j + 1.0
					End While
					i = i + 1.0
				End While

				If d Mod 2.0 = 1.0
					n = QRAlphanumericToCode(data(data.Length - 1.0))

					CreateStringFromNumberWithCheck(n, 2.0, nstr)

					offset = 6.0 - nstr.stringx.Length
					j = 0.0
					While j < nstr.stringx.Length
						bs(bs.Length - 6.0 + offset + j) = nstr.stringx(j)
						j = j + 1.0
					End While
				End If

				' Character count
				CreateStringFromNumberWithCheck(d, 2.0, nstr)
				offset = 4.0 + c - nstr.stringx.Length
				j = 0.0
				While j < nstr.stringx.Length
					bs(offset + j) = nstr.stringx(j)
					j = j + 1.0
				End While

				' Mode
				mode = QRAlphanumericModeIndicator()
				j = 0.0
				While j < 4.0
					bs(j) = mode(j)
					j = j + 1.0
				End While

				bsReference.stringx = bs
			End If
		End If

		Return success
	End Function


	Public Function QRSegmentsToCodeWords(ByRef data As Char (), version As Double, errorCorrectionLevelCode As Char) As Double ()
		Dim symbolBits, terminatorLength, d, n, padding, cw, j, r, errorCorrectionLevelNumber As Double
		Dim codewords, symbolBitsSpec As Double ()
		Dim str As Char ()
		Dim nref As NumberReference
		Dim errorMessage As StringReference
		Dim padSymbol As Boolean

		symbolBitsSpec = GetQRSymbolLengthsForVersions()

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

		symbolBits = symbolBitsSpec((version - 1.0)*4.0 + errorCorrectionLevelNumber)

		terminatorLength = Min(symbolBits - data.Length, 4.0)

		d = data.Length + terminatorLength
		n = Ceiling(d/8.0)
		padding = n*8.0 - d

		codewords = New Double (Floor(symbolBits/8.0) - 1){}

		str = New Char (8 - 1){}
		nref = New NumberReference()
		errorMessage = New StringReference()

		cw = 0.0
		While cw < Floor(data.Length/8.0)
			str(0) = data(cw*8.0 + 0.0)
			str(1) = data(cw*8.0 + 1.0)
			str(2) = data(cw*8.0 + 2.0)
			str(3) = data(cw*8.0 + 3.0)
			str(4) = data(cw*8.0 + 4.0)
			str(5) = data(cw*8.0 + 5.0)
			str(6) = data(cw*8.0 + 6.0)
			str(7) = data(cw*8.0 + 7.0)

			CreateNumberFromStringWithCheck(str, 2.0, nref, errorMessage)

			codewords(cw) = nref.numberValue
			cw = cw + 1.0
		End While

		' Remaining data, terminator and bit-padding.
		r = data.Length Mod 8.0
		If r <> 0.0
			j = 0.0
			While j < 8.0
				If j < r
					str(j) = data(data.Length - r + j)
				Else
					str(j) = "0"C
				End If
				j = j + 1.0
			End While

			CreateNumberFromStringWithCheck(str, 2.0, nref, errorMessage)

			codewords(cw) = nref.numberValue
			cw = cw + 1.0
		End If

		If r = 0.0 And terminatorLength + padding = 8.0
			codewords(cw) = 0.0
			cw = cw + 1.0
		ElseIf 8.0 - r >= terminatorLength + padding
		Else
			codewords(cw) = 0.0
			cw = cw + 1.0
		End If

		' Byte Padding
		padSymbol = true
		
		While cw < codewords.Length
			If padSymbol
				codewords(cw) = 236.0
			Else
				codewords(cw) = 17.0
			End If
			padSymbol = Not padSymbol
			cw = cw + 1.0
		End While

		Return codewords
	End Function


	Public Function GetQRSymbolLengthsForVersions() As Double ()
		Return StringToNumberArray("152, 128, 104, 72, 272, 224, 176, 128, 440, 352, 272, 208, 640, 512, 384, 288, 864, 688, 496, 368, 1088, 864, 608, 480, 1248, 992, 704, 528, 1552, 1232, 880, 688, 1856, 1456, 1056, 800, 2192, 1728, 1232, 976, 2592, 2032, 1440, 1120, 2960, 2320, 1648, 1264, 3424, 2672, 1952, 1440, 3688, 2920, 2088, 1576, 4184, 3320, 2360, 1784, 4712, 3624, 2600, 2024, 5176, 4056, 2936, 2264, 5768, 4504, 3176, 2504, 6360, 5016, 3560, 2728, 6888, 5352, 3880, 3080, 7456, 5712, 4096, 3248, 8048, 6256, 4544, 3536, 8752, 6880, 4912, 3712, 9392, 7312, 5312, 4112, 10208, 8000, 5744, 4304, 10960, 8496, 6032, 4768, 11744, 9024, 6464, 5024, 12248, 9544, 6968, 5288, 13048, 10136, 7288, 5608, 13880, 10984, 7880, 5960, 14744, 11640, 8264, 6344, 15640, 12328, 8920, 6760, 16568, 13048, 9368, 7208, 17528, 13800, 9848, 7688, 18448, 14496, 10288, 7888, 19472, 15312, 10832, 8432, 20528, 15936, 11408, 8768, 21616, 16816, 12016, 9136, 22496, 17728, 12656, 9776, 23648, 18672, 13328, 10208".ToCharArray())
	End Function


	Public Function QREccLetterToNumber(errorCorrectionLevelCode As Char) As Double
		Dim errorCorrectionLevelNumber As Double

		errorCorrectionLevelNumber = 0.0

		If errorCorrectionLevelCode = "L"C
			errorCorrectionLevelNumber = 0.0
		ElseIf errorCorrectionLevelCode = "M"C
			errorCorrectionLevelNumber = 1.0
		ElseIf errorCorrectionLevelCode = "Q"C
			errorCorrectionLevelNumber = 2.0
		ElseIf errorCorrectionLevelCode = "H"C
			errorCorrectionLevelNumber = 3.0
		End If
		Return errorCorrectionLevelNumber
	End Function


	Public Function ErGyldigOrgNummerString(ByRef orgnummer As Char ()) As Boolean
		Dim gyldig As Boolean
		Dim o As Double ()
		Dim i As Double

		o = New Double (9 - 1){}

		gyldig = true

		If orgnummer.Length = 9.0

			i = 0.0
			While i < 9.0
				If cIsNumber(orgnummer(i))
					o(i) = cCharacterToDecimalDigit(orgnummer(i))
				Else
					gyldig = false
				End If
				i = i + 1.0
			End While

			If gyldig
				gyldig = ErGyldigOrgNummer(o)
			End If
		Else
			gyldig = false
		End If

		Return gyldig
	End Function


	Public Function ErGyldigOrgNummer(ByRef o As Double ()) As Boolean
		Dim gyldig As Boolean
		Dim sum, rest, kontrollsiffer As Double

		If o.Length = 9.0
			sum = o(0)*3.0 + o(1)*2.0 + o(2)*7.0 + o(3)*6.0 + o(4)*5.0 + o(5)*4.0 + o(6)*3.0 + o(7)*2.0
			rest = sum Mod 11.0
			If rest = 0.0
				kontrollsiffer = 0.0
			Else
				kontrollsiffer = 11.0 - rest
			End If

			gyldig = rest <> 1.0 And kontrollsiffer = o(8)
		Else
			gyldig = false
		End If

		Return gyldig
	End Function


	Public Function IsValidNorwegianPersonalIdentificationNumber(ByRef fnummer As Char (), ByRef message As StringReference) As Boolean
		Dim valid As Boolean
		Dim i, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11 As Double
		Dim k1, k2 As Double
		Dim dateRef As DateReference

		valid = fnummer.Length = 11.0
		If valid
			i = 0.0
			While i < fnummer.Length
				If cIsNumber(fnummer(i))
				Else
					valid = false
				End If
				i = i + 1.0
			End While

			If valid
				d1 = cCharacterToDecimalDigit(fnummer(0))
				d2 = cCharacterToDecimalDigit(fnummer(1))
				d3 = cCharacterToDecimalDigit(fnummer(2))
				d4 = cCharacterToDecimalDigit(fnummer(3))
				d5 = cCharacterToDecimalDigit(fnummer(4))
				d6 = cCharacterToDecimalDigit(fnummer(5))
				d7 = cCharacterToDecimalDigit(fnummer(6))
				d8 = cCharacterToDecimalDigit(fnummer(7))
				d9 = cCharacterToDecimalDigit(fnummer(8))
				d10 = cCharacterToDecimalDigit(fnummer(9))
				d11 = cCharacterToDecimalDigit(fnummer(10))

				dateRef = New DateReference()
				valid = GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message)

				If valid
					valid = IsValidDate(dateRef.datex, message)
					If valid
						k1 = d1*3.0 + d2*7.0 + d3*6.0 + d4*1.0 + d5*8.0 + d6*9.0 + d7*4.0 + d8*5.0 + d9*2.0
						k1 = k1 Mod 11.0
						If k1 <> 0.0
							k1 = 11.0 - k1
						End If
						If k1 = 10.0
							valid = false
							message.stringx = "Control digit 1 is 10, which is invalid.".ToCharArray()
						End If

						If valid
							k2 = d1*5.0 + d2*4.0 + d3*3.0 + d4*2.0 + d5*7.0 + d6*6.0 + d7*5.0 + d8*4.0 + d9*3.0 + k1*2.0
							k2 = k2 Mod 11.0
							If k2 <> 0.0
								k2 = 11.0 - k2
							End If
							If k2 = 10.0
								valid = false
								message.stringx = "Control digit 2 is 10, which is invalid.".ToCharArray()
							End If

							If valid
								If k1 = d10
									If k2 = d11
										valid = true
									Else
										valid = false
										message.stringx = "Check of control digit 2 failed.".ToCharArray()
									End If
								Else
									valid = false
									message.stringx = "Check of control digit 1 failed.".ToCharArray()
								End If
							End If
						End If
					Else
						message.stringx = "The date is not a valid date.".ToCharArray()
					End If
				End If
			Else
				message.stringx = "Each character must be a decimal digit.".ToCharArray()
			End If
		Else
			message.stringx = "Must be exactly 11 digits long.".ToCharArray()
		End If

		Return valid
	End Function


	Public Function GetDateFromNorwegianPersonalIdentificationNumber(ByRef fnummer As Char (), ByRef dateRef As DateReference, ByRef message As StringReference) As Boolean
		Dim individnummer As Double
		Dim day, month, year As Double
		Dim i, d1, d2, d3, d4, d5, d6, d7, d8, d9 As Double
		Dim success As Boolean

		dateRef.datex = New Datex()

		success = fnummer.Length = 11.0
		If success
			i = 0.0
			While i < fnummer.Length
				If cIsNumber(fnummer(i))
				Else
					success = false
				End If
				i = i + 1.0
			End While

			If success
				d1 = cCharacterToDecimalDigit(fnummer(0))
				d2 = cCharacterToDecimalDigit(fnummer(1))
				d3 = cCharacterToDecimalDigit(fnummer(2))
				d4 = cCharacterToDecimalDigit(fnummer(3))
				d5 = cCharacterToDecimalDigit(fnummer(4))
				d6 = cCharacterToDecimalDigit(fnummer(5))
				d7 = cCharacterToDecimalDigit(fnummer(6))
				d8 = cCharacterToDecimalDigit(fnummer(7))
				d9 = cCharacterToDecimalDigit(fnummer(8))

				' Individnummer
				individnummer = d7*100.0 + d8*10.0 + d9

				' Make date
				day = d1*10.0 + d2
				month = d3*10.0 + d4
				year = d5*10.0 + d6

				If individnummer >= 0.0 And individnummer <= 499.0
					year = year + 1900.0
				ElseIf individnummer >= 500.0 And individnummer <= 749.0 And year >= 54.0 And year <= 99.0
					year = year + 1800.0
				ElseIf individnummer >= 900.0 And individnummer <= 999.0 And year >= 40.0 And year <= 99.0
					year = year + 1900.0
				ElseIf individnummer >= 500.0 And individnummer <= 999.0 And year >= 0.0 And year <= 39.0
					year = year + 2000.0
				Else
					success = false
					message.stringx = "Invalid combination of individnummer and year.".ToCharArray()
				End If

				If success
					dateRef.datex.year = year
					dateRef.datex.month = month
					dateRef.datex.day = day
				End If
			Else
				message.stringx = "Each character must be a decimal digit.".ToCharArray()
			End If
		Else
			message.stringx = "Must be exactly 11 digits long.".ToCharArray()
		End If

		Return success
	End Function


	Public Function HentKommunenavnFraNummer(ByRef kommunenummer As Char (), ByRef kommunenavnReference As StringReference, ByRef errorMessages As StringReference) As Boolean
		Dim nr As Double
		Dim success As Boolean
		Dim nummer, kommunenavn As StringReference ()

		kommunenavn = HentKommunenavn()

		nummer = HentGyldigeKommunenummer()
		success = false

		nr = 0.0
		While nr < nummer.Length And Not success
			If arraysStringsEqual(nummer(nr).stringx, kommunenummer)
				success = true
				kommunenavnReference.stringx = kommunenavn(nr).stringx
			End If
			nr = nr + 1.0
		End While

		If Not success
			errorMessages.stringx = "Kommunenummer er ikke gyldig.".ToCharArray()
		End If

		Return success
	End Function


	Public Function ErGyldigKommunenummer(ByRef kommunenummer As Char ()) As Boolean
		Dim gyldig As Boolean
		Dim i As Double
		Dim nummer As StringReference ()

		gyldig = false

		If kommunenummer.Length = 4.0
			nummer = HentGyldigeKommunenummer()

			i = 0.0
			While i < nummer.Length And Not gyldig
				If arraysStringsEqual(nummer(i).stringx, kommunenummer)
					gyldig = true
				End If
				i = i + 1.0
			End While
		End If

		Return gyldig
	End Function


	Public Function HentKommunenavn() As StringReference ()
		Dim kommunenavn As StringReference ()
		Dim kommunenavnliste As Char ()

		kommunenavnliste = "\u00c5fjord, Agdenes, \u00c5l, \u00c5lesund, Alstahaug, Alta, Alvdal, \u00c5mli, \u00c5mot, And\u00f8y, \u00c5rdal, Aremark, Arendal, \u00c5s, \u00c5seral, Asker, Askim, Ask\u00f8y, Askvoll, \u00c5snes, Audnedal, Aukra, Aure, Aurland, Aurskog-H\u00f8land, Austevoll, Austrheim, Aver\u00f8y, B\u00e6rum, Balestrand, Ballangen, Balsfjord, Bamble, Bardu, B\u00e5tsfjord, Beiarn, Berg, Bergen, Berlev\u00e5g, Bindal, Birkenes, Bjerkreim, Bjugn, B\u00f8 i Nordland , B\u00f8 i Telemark, Bod\u00f8, Bokn, B\u00f8mlo, Bremanger, Br\u00f8nn\u00f8y, Bygland, Bykle, Deatnu - Tana, Divtasvuodna - Tysfjord, D\u00f8nna, Dovre, Drammen, Drangedal, Dyr\u00f8y, Eid, Eide, Eidfjord, Eidsberg, Eidskog, Eidsvoll, Eigersund, Elverum, Enebakk, Engerdal, Etne, Etnedal, Evenes, Evje og Hornnes, F\u00e6rder, Farsund, Fauske - Fuossko, Fedje, Fet, Finn\u00f8y, Fitjar, Fjaler, Fjell, Fl\u00e5, Flakstad, Flatanger, Flekkefjord, Flesberg, Flora, Folldal, F\u00f8rde, Forsand, Fosnes, Fr\u00e6na, Fredrikstad, Frogn, Froland, Frosta, Fr\u00f8ya, Fusa, Fyresdal, G\u00e1ivuotna - K\u00e5fjord - Kaivuono, Gamvik, Gaular, Gausdal, Gildesk\u00e5l, Giske, Gjemnes, Gjerdrum, Gjerstad, Gjesdal, Gj\u00f8vik, Gloppen, Gol, Gran, Grane, Granvin, Gratangen, Grimstad, Grong, Grue, Gulen, Guovdageaidnu - Kautokeino, H\u00e5, Hadsel, H\u00e6gebostad, Halden, Halsa, Hamar, Hamar\u00f8y - H\u00e1bmer, Hammerfest, Haram, Hareid, Harstad - H\u00e1rstt\u00e1k, Hasvik, Hattfjelldal, Haugesund, Hemne, Hemnes, Hemsedal, Her\u00f8y i  M\u00f8re og Romsdal, Her\u00f8y i Nordland, Hitra, Hjartdal, Hjelmeland, Hob\u00f8l, Hol, Hole, Holmestrand, Holt\u00e5len, Hornindal, Horten, H\u00f8yanger, H\u00f8ylandet, Hurdal, Hurum, Hvaler, Hyllestad, Ibestad, Inder\u00f8y, Indre Fosen, Iveland, Jevnaker, J\u00f8lster, Jondal, K\u00e1r\u00e1\u0161johka - Karasjok, Karls\u00f8y, Karm\u00f8y, Kl\u00e6bu, Klepp, Kongsberg, Kongsvinger, Krager\u00f8, Kristiansand, Kristiansund, Kr\u00f8dsherad, Kv\u00e6fjord, Kv\u00e6nangen, Kvalsund, Kvam, Kvinesdal, Kvinnherad, Kviteseid, Kvits\u00f8y, L\u00e6rdal, Larvik, Lebesby, Leikanger, Leirfjord, Leka, Lenvik, Lesja, Levanger, Lier, Lierne, Lillehammer, Lillesand, Lind\u00e5s, Lindesnes, Loab\u00e1k - Lavangen, L\u00f8dingen, Lom, Loppa, L\u00f8renskog, L\u00f8ten, Lund, Lunner, Lur\u00f8y, Luster, Lyngdal, Lyngen, M\u00e5lselv, Malvik, Mandal, Marker, Marnardal, Masfjorden, M\u00e5s\u00f8y, Meland, Meldal, Melhus, Mel\u00f8y, Mer\u00e5ker, Midsund, Midtre Gauldal, Modalen, Modum, Molde, Moskenes, Moss, N\u00e6r\u00f8y, Namdalseid, Namsos, Namsskogan, Nannestad, Narvik, Naustdal, Nedre Eiker, Nes i Akershus, Nes i Buskerud, Nesna, Nesodden, Nesset, Nissedal, Nittedal, Nome, Nord-Aurdal, Norddal, Nord-Fron, Nordkapp, Nord-Odal, Nordre Land, Nordreisa - R\u00e1isa - Raisi, Nore og Uvdal, Notodden, Odda, \u00d8ksnes, Oppdal, Oppeg\u00e5rd, Orkdal, \u00d8rland, \u00d8rskog, \u00d8rsta, Os i Hedmark, Os i Hordaland, Osen, Oslo, Oster\u00f8y, \u00d8stre Toten, Overhalla, \u00d8vre Eiker, \u00d8yer, \u00d8ygarden, \u00d8ystre Slidre, Porsanger - Pors\u00e1\u014bgu - Porsanki, Porsgrunn, Raarvikhe - R\u00f8yrvik, R\u00e5de, Rad\u00f8y, R\u00e6lingen, Rakkestad, Rana, Randaberg, Rauma, Re, Rendalen, Rennebu, Rennes\u00f8y, Rindal, Ringebu, Ringerike, Ringsaker, Ris\u00f8r, Roan, R\u00f8d\u00f8y, Rollag, R\u00f8mskog, R\u00f8ros, R\u00f8st, R\u00f8yken, Rygge, Salangen, Saltdal, Samnanger, Sande i M\u00f8re og Romsdal, Sande i Vestfold, Sandefjord, Sandnes, Sand\u00f8y, Sarpsborg, Sauda, Sauherad, Sel, Selbu, Selje, Seljord, Sigdal, Siljan, Sirdal, Sk\u00e5nland, Skaun, Skedsmo, Ski, Skien, Skiptvet, Skj\u00e5k, Skjerv\u00f8y, Skodje, Sm\u00f8la, Sn\u00e5ase - Sn\u00e5sa, Snillfjord, Sogndal, S\u00f8gne, Sokndal, Sola, Solund, S\u00f8mna, S\u00f8ndre Land, Songdalen, S\u00f8r-Aurdal, S\u00f8rfold, S\u00f8r-Fron, S\u00f8r-Odal, S\u00f8rreisa, Sortland - Suort\u00e1, S\u00f8rum, S\u00f8r-Varanger, Spydeberg, Stange, Stavanger, Steigen, Steinkjer, Stj\u00f8rdal, Stord, Stordal, Stor-Elvdal, Storfjord - Omasvuotna - Omasvuono, Strand, Stranda, Stryn, Sula, Suldal, Sund, Sunndal, Surnadal, Sveio, Svelvik, Sykkylven, Time, Tingvoll, Tinn, Tjeldsund, Tokke, Tolga, T\u00f8nsberg, Torsken, Tr\u00e6na, Tran\u00f8y, Tr\u00f8gstad, Troms\u00f8, Trondheim , Trysil, Tvedestrand, Tydal, Tynset, Tysnes, Tysv\u00e6r, Ullensaker, Ullensvang, Ulstein, Ulvik, Unj\u00e1rga - Nesseby, Utsira, Vads\u00f8, V\u00e6r\u00f8y, V\u00e5g\u00e5, V\u00e5gan, V\u00e5gs\u00f8y, Vaksdal, V\u00e5ler i Hedmark, V\u00e5ler i \u00d8stfold, Valle, Vang, Vanylven, Vard\u00f8, Vefsn, Vega, Veg\u00e5rshei, Vennesla, Verdal, Verran, Vestby, Vestnes, Vestre Slidre, Vestre Toten, Vestv\u00e5g\u00f8y, Vevelstad, Vik, Vikna, Vindafjord, Vinje, Volda, Voss, ".ToCharArray()

		kommunenavn = strSplitByString(kommunenavnliste, ", ".ToCharArray())

		Return kommunenavn
	End Function


	Public Function HentGyldigeKommunenummer() As StringReference ()
		Dim kommunenummerliste As Char ()
		Dim kommunenummer As StringReference ()

		kommunenummerliste = "5018, 5016, 0619, 1504, 1820, 2012, 0438, 0929, 0429, 1871, 1424, 0118, 0906, 0214, 1026, 0220, 0124, 1247, 1428, 0425, 1027, 1547, 1576, 1421, 0221, 1244, 1264, 1554, 0219, 1418, 1854, 1933, 0814, 1922, 2028, 1839, 1929, 1201, 2024, 1811, 0928, 1114, 5017, 1867, 0821, 1804, 1145, 1219, 1438, 1813, 0938, 0941, 2025, 1850, 1827, 0511, 0602, 0817, 1926, 1443, 1551, 1232, 0125, 0420, 0237, 1101, 0427, 0229, 0434, 1211, 0541, 1853, 0937, 0729, 1003, 1841, 1265, 0227, 1141, 1222, 1429, 1246, 0615, 1859, 5049, 1004, 0631, 1401, 0439, 1432, 1129, 5048, 1548, 0106, 0215, 0919, 5036, 5014, 1241, 0831, 1940, 2023, 1430, 0522, 1838, 1532, 1557, 0234, 0911, 1122, 0502, 1445, 0617, 0534, 1825, 1234, 1919, 0904, 5045, 0423, 1411, 2011, 1119, 1866, 1034, 0101, 1571, 0403, 1849, 2004, 1534, 1517, 1903, 2015, 1826, 1106, 5011, 1832, 0618, 1515, 1818, 5013, 0827, 1133, 0138, 0620, 0612, 0715, 5026, 1444, 0701, 1416, 5046, 0239, 0628, 0111, 1413, 1917, 5053, 5054, 0935, 0532, 1431, 1227, 2021, 1936, 1149, 5030, 1120, 0604, 0402, 0815, 1001, 1505, 0622, 1911, 1943, 2017, 1238, 1037, 1224, 0829, 1144, 1422, 0712, 2022, 1419, 1822, 5052, 1931, 0512, 5037, 0626, 5042, 0501, 0926, 1263, 1029, 1920, 1851, 0514, 2014, 0230, 0415, 1112, 0533, 1834, 1426, 1032, 1938, 1924, 5031, 1002, 0119, 1021, 1266, 2018, 1256, 5023, 5028, 1837, 5034, 1545, 5027, 1252, 0623, 1502, 1874, 0104, 5051, 5040, 5005, 5044, 0238, 1805, 1433, 0625, 0236, 0616, 1828, 0216, 1543, 0830, 0233, 0819, 0542, 1524, 0516, 2019, 0418, 0538, 1942, 0633, 0807, 1228, 1868, 5021, 0217, 5024, 5015, 1523, 1520, 0441, 1243, 5020, 0301, 1253, 0528, 5047, 0624, 0521, 1259, 0544, 2020, 0805, 5043, 0135, 1260, 0228, 0128, 1833, 1127, 1539, 0716, 0432, 5022, 1142, 5061, 0520, 0605, 0412, 0901, 5019, 1836, 0632, 0121, 5025, 1856, 0627, 0136, 1923, 1840, 1242, 1514, 0713, 0710, 1102, 1546, 0105, 1135, 0822, 0517, 5032, 1441, 0828, 0621, 0811, 1046, 1913, 5029, 0231, 0213, 0806, 0127, 0513, 1941, 1529, 1573, 5041, 5012, 1420, 1018, 1111, 1124, 1412, 1812, 0536, 1017, 0540, 1845, 0519, 0419, 1925, 1870, 0226, 2030, 0123, 0417, 1103, 1848, 5004, 5035, 1221, 1526, 0430, 1939, 1130, 1525, 1449, 1531, 1134, 1245, 1563, 1566, 1216, 0711, 1528, 1121, 1560, 0826, 1852, 0833, 0436, 0704, 1928, 1835, 1927, 0122, 1902, 5001, 0428, 0914, 5033, 0437, 1223, 1146, 0235, 1231, 1516, 1233, 2027, 1151, 2003, 1857, 0515, 1865, 1439, 1251, 0426, 0137, 0940, 0545, 1511, 2002, 1824, 1815, 0912, 1014, 5038, 5039, 0211, 1535, 0543, 0529, 1860, 1816, 1417, 5050, 1160, 0834, 1519, 1235".ToCharArray()

		kommunenummer = strSplitByString(kommunenummerliste, ", ".ToCharArray())

		Return kommunenummer
	End Function


	Public Function HentPoststedListe() As StringReference ()
		Dim p, l As StringReference ()
		Dim poststeder As Char ()
		Dim nr As Double ()
		Dim i As Double

		poststeder = "OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, HASLUM, SANDVIKA, FORNEBU, JAR, RUD, H\u00d8VIKODDEN, SLEPENDEN, V\u00d8YENENGA, V\u00d8YENENGA, EIKSMARKA, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, STABEKK, H\u00d8VIK, H\u00d8VIK, LYSAKER, LYSAKER, LYSAKER, LYSAKER, H\u00d8VIK, LOMMEDALEN, FORNEBU, FORNEBU, \u00d8STER\u00c5S, KOLS\u00c5S, RYKKINN, SNAR\u00d8YA, SANDVIKA, SANDVIKA, SANDVIKA, V\u00d8YENENGA, SKUI, SLEPENDEN, GJETTUM, HASLUM, GJETTUM, RYKKINN, RYKKINN, LOMMEDALEN, RUD, KOLS\u00c5S, B\u00c6RUMS VERK, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, JAR, EIKSMARKA, FORNEBU, \u00d8STER\u00c5S, HOSLE, H\u00d8VIK, FORNEBU, BLOMMENHOLM, LYSAKER, SNAR\u00d8YA, STABEKK, STABEKK, ASKER, ASKER, ASKER, BILLINGSTAD, BILLINGSTAD, BILLINGSTAD, NESBRU, NESBRU, HEGGEDAL, VETTRE, ASKER, ASKER, ASKER, ASKER, ASKER, BORGEN, HEGGEDAL, VOLLEN, VOLLEN, VETTRE, VOLLEN, NESBRU, HVALSTAD, BILLINGSTAD, NES\u00d8YA, ASKER, SKI, SKI, SKI, LANGHUS, SIGGERUD, LANGHUS, SKI, VINTERBRO, KR\u00c5KSTAD, SKOTBU, KOLBOTN, KOLBOTN, SOFIEMYR, T\u00c5RN\u00c5SEN, TROLL\u00c5SEN, OPPEG\u00c5RD, OPPEG\u00c5RD, SOFIEMYR, KOLBOTN, OPPEG\u00c5RD, SVARTSKOG, TROLL\u00c5SEN, SIGGERUD, VINTERBRO, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, NESODDTANGEN, NESODDTANGEN, NESODDTANGEN, BJ\u00d8RNEMYR, FAGERSTRAND, NORDRE FROGN, NESODDTANGEN, FAGERSTRAND, FJELLSTRAND, NESODDEN, STR\u00d8MMEN, STR\u00d8MMEN, STR\u00d8MMEN, FINSTADJORDET, RASTA, L\u00d8RENSKOG, L\u00d8RENSKOG, FJELLHAMAR, L\u00d8RENSKOG, L\u00d8RENSKOG, FINSTADJORDET, RASTA, FJELLHAMAR, L\u00d8RENSKOG, KURLAND, SLATTUM, HAGAN, NITTEDAL, HAGAN, HAKADAL, HAKADAL, NITTEDAL, HAKADAL, HAKADAL, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, VESTBY, VESTBY, HVITSTEN, H\u00d8LEN, SON, SON, LARKOLLEN, LARKOLLEN, DILLING, RYGGE, RYGGE, RYGGE, SPERREBOTN, V\u00c5LER I \u00d8STFOLD, SVINNDAL, V\u00c5LER I \u00d8STFOLD, MOSS, MOSS, MOSS, MOSS, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, MANSTAD, MANSTAD, ENGELSVIKEN, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, R\u00c5DE, R\u00c5DE, SALTNES, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, TORP, TORP, TORP, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, SKJ\u00c6RHALDEN, SKJ\u00c6RHALDEN, VESTER\u00d8Y, VESTER\u00d8Y, HERF\u00d8L, NEDG\u00c5RDEN, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, GR\u00c5LUM, GR\u00c5LUM, GR\u00c5LUM, YVEN, GRE\u00c5KER, GRE\u00c5KER, GRE\u00c5KER, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, ISE, HAFSLUNDS\u00d8Y, HAFSLUNDS\u00d8Y, VARTEIG, BORGENHAUGEN, BORGENHAUGEN, BORGENHAUGEN, KLAVESTADHAUGEN, KLAVESTADHAUGEN, SKJEBERG, SKJEBERG, SKJEBERG, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, BERG I \u00d8STFOLD, TISTEDAL, TISTEDAL, TISTEDAL, TISTEDAL, SPONVIKA, KORNSJ\u00d8, AREMARK, AREMARK, ASKIM, ASKIM, ASKIM, SPYDEBERG, TOMTER, SKIPTVET, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, SKIPTVET, SPYDEBERG, SPYDEBERG, KNAPSTAD, TOMTER, HOB\u00d8L, ASKIM, ASKIM, ASKIM, ASKIM, MYSEN, MYSEN, MYSEN, SLITU, TR\u00d8GSTAD, TR\u00d8GSTAD, B\u00c5STAD, B\u00c5STAD, \u00d8RJE, \u00d8RJE, OTTEID, H\u00c6RLAND, EIDSBERG, RAKKESTAD, RAKKESTAD, DEGERNES, DEGERNES, RAKKESTAD, FETSUND, FETSUND, GAN, ENEBAKKNESET, FLATEBY, ENEBAKK, YTRE ENEBAKK, FLATEBY, YTRE ENEBAKK, S\u00d8RUMSAND, S\u00d8RUMSAND, S\u00d8RUM, S\u00d8RUM, BLAKER, BLAKER, R\u00c5N\u00c5SFOSS, AULI, AULI, AURSKOG, AURSKOG, BJ\u00d8RKELANGEN, BJ\u00d8RKELANGEN, R\u00d8MSKOG, SETSKOG, L\u00d8KEN, L\u00d8KEN, FOSSER, HEMNES, HEMNES, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, R\u00c6LINGEN, L\u00d8VENSTAD, KJELLER, FJERDINGBY, NORDBY, STR\u00d8MMEN, STR\u00d8MMEN, LILLESTR\u00d8M, SKJETTEN, BLYSTADLIA, LEIRSUND, FROGNER, FROGNER, L\u00d8VENSTAD, SKEDSMOKORSET, SKEDSMOKORSET, SKEDSMOKORSET, GJERDRUM, SKEDSMOKORSET, GJERDRUM, FJERDINGBY, SKJETTEN, KJELLER, LILLESTR\u00d8M, R\u00c6LINGEN, NANNESTAD, NANNESTAD, MAURA, \u00c5SGREINA, HOLTER, HOLTER, MAURA, KL\u00d8FTA, KL\u00d8FTA, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, MOGREINA, NORDKISA, ALGARHEIM, JESSHEIM, SESSVOLLMOEN, GARDERMOEN, GARDERMOEN, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, R\u00c5HOLT, R\u00c5HOLT, DAL, B\u00d8N, EIDSVOLL VERK, DAL, EIDSVOLL, EIDSVOLL, HURDAL, HURDAL, MINNESUND, FEIRING, MINNESUND, SKARNES, SKARNES, SL\u00c5STAD, DISEN\u00c5, SANDER, SAGSTUA, SAGSTUA, BRUVOLL, KNAPPER, GARDVIK, GARDVIK, AUSTVATN, \u00c5RNES, \u00c5RNES, VORMSUND, VORMSUND, BR\u00c5RUD, SKOGBYGDA, SKOGBYGDA, HVAM, OPPAKER, HVAM, FENSTAD, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, GRANLI, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, ROVERUD, ROVERUD, HOKK\u00c5SEN, LUNDERS\u00c6TER, BRANDVAL, \u00c5BOGEN, GALTERUD, AUSTMARKA, KONGSVINGER, KONGSVINGER, AUSTMARKA, SKOTTERUD, SKOTTERUD, TOB\u00d8L, VESTMARKA, MATRAND, MAGNOR, MAGNOR, GRUE FINNSKOG, GRUE FINNSKOG, KIRKEN\u00c6R, KIRKEN\u00c6R, GRINDER, NAMN\u00c5, ARNEBERG, FLISA, FLISA, GJES\u00c5SEN, \u00c5SNES FINNSKOG, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, OTTESTAD, OTTESTAD, OTTESTAD, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, FURNES, HAMAR, RIDABU, INGEBERG, VANG P\u00c5 HEDMARKEN, HAMAR, HAMAR, FURNES, RIDABU, VANG P\u00c5 HEDMARKEN, VALLSET, VALLSET, \u00c5SVANG, ROMEDAL, ROMEDAL, STANGE, STANGE, TANGEN, ESPA, TANGEN, L\u00d8TEN, L\u00d8TEN, ILSENG, \u00c5DALSBRUK, ILSENG, NES P\u00c5 HEDMARKEN, NES P\u00c5 HEDMARKEN, STAVSJ\u00d8, GAUPEN, RUDSH\u00d8GDA, RUDSH\u00d8GDA, N\u00c6ROSET, \u00c5SMARKA, BR\u00d8TTUM, BR\u00d8TTUM, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, MOELV, MOELV, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, HERNES, ELVERUM, S\u00d8RSKOGBYGDA, ELVERUM, ELVERUM, HERADSBYGD, J\u00d8MNA, ELVERUM, ELVERUM, ELVERUM, TRYSIL, TRYSIL, NYBERGSUND, \u00d8STBY, \u00d8STBY, LJ\u00d8RDALEN, LJ\u00d8RDALEN, PLASSEN, S\u00d8RE OSEN, T\u00d8RBERGET, JORDET, SLETT\u00c5S, BRASKEREIDFOSS, BRASKEREIDFOSS, V\u00c5LER I SOL\u00d8R, HASLEMOEN, GRAVBERGET, V\u00c5LER I SOL\u00d8R, ENGERDAL, ENGERDAL, HERADSBYGD, DREVSJ\u00d8, DREVSJ\u00d8, ELG\u00c5, S\u00d8RE OSEN, S\u00d8M\u00c5DALEN, RENA, RENA, OSEN, OSEN, ATNA, SOLLIA, HANESTAD, KOPPANG, KOPPANG, RENDALEN, RENDALEN, RENDALEN, RENDALEN, RENDALEN, TYNSET, TYNSET, TYLLDALEN, KVIKNE, KVIKNE, TOLGA, TOLGA, VINGELEN, \u00d8VERSJ\u00d8DALEN, OS I \u00d8STERDALEN, OS I \u00d8STERDALEN, DALSBYGDA, TUFSINGDALEN, ALVDAL, ALVDAL, FOLLDAL, FOLLDAL, GRIMSBU, DALHOLEN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, VINGROM, LILLEHAMMER, LILLEHAMMER, MESNALI, LILLEHAMMER, SJUSJ\u00d8EN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LISMARKA, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, MESNALI, VINGROM, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, F\u00c5BERG, LILLEHAMMER, F\u00c5BERG, SJUSJ\u00d8EN, LILLEHAMMER, RINGEBU, RINGEBU, VENABYGD, F\u00c5VANG, F\u00c5VANG, TRETTEN, \u00d8YER, \u00d8YER, TRETTEN, VINSTRA, VINSTRA, KVAM, KVAM, SK\u00c5BU, SK\u00c5BU, S\u00d8R-FRON, G\u00c5L\u00c5, S\u00d8R-FRON, S\u00d8R-FRON, \u00d8STRE GAUSDAL, \u00d8STRE GAUSDAL, SVINGVOLL, VESTRE GAUSDAL, VESTRE GAUSDAL, FOLLEBU, SVATSUM, ESPEDALEN, DOMB\u00c5S, DOMB\u00c5S, HJERKINN, DOVRE, DOVRESKOGEN, DOVRE, LESJA, LORA, LESJAVERK, LESJASKOG, BJORLI, OTTA, LESJA, SEL, H\u00d8VRINGEN, MYSUS\u00c6TER, OTTA, HEIDAL, NEDRE HEIDAL, SEL, HEIDAL, V\u00c5G\u00c5, LALM, LALM, TESSANDEN, V\u00c5G\u00c5, GARMO, LOM, B\u00d8VERDALEN, LOM, SKJ\u00c5K, NORDBERG, SKJ\u00c5K, GROTLI, GRAN, BRANDBU, ROA, JAREN, LUNNER, HARESTUA, GRUA, BRANDBU, GRINDVOLL, LUNNER, ROA, GRUA, HARESTUA, GRAN, BRANDBU, JAREN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, NORDRE TOTEN, GJ\u00d8VIK, BYBRUA, GJ\u00d8VIK, HUNNDALEN, RAUFOSS, RAUFOSS, BIRI, RAUFOSS, RAUFOSS, RAUFOSS, BIRI, BIRISTRAND, SNERTINGDAL, \u00d8VRE SNERTINGDAL, REINSVOLL, SNERTINGDAL, EINA, KOLBU, B\u00d8VERBRU, B\u00d8VERBRU, KOLBU, SKREIA, KAPP, LENA, LENA, REINSVOLL, EINA, SKREIA, KAPP, HOV, LAND\u00c5SBYGDA, FLUBERG, FALL, ENGER, HOV, DOKKA, ODNES, NORD-TORPA, AUST-TORPA, DOKKA, ETNEDAL, ETNEDAL, FAGERNES, FAGERNES, LEIRA I VALDRES, AURDAL, AURDAL, SKRAUTV\u00c5L, ULNES, LEIRA I VALDRES, TISLEIDALEN, BAGN, BAGN, REINLI, BEGNADALEN, BEGNA, HEGGENES, HEGGENES, ROGNE, SKAMMESTEIN, BEITO, BEITOST\u00d8LEN, BEITOST\u00d8LEN, R\u00d8N, R\u00d8N, SLIDRE, SLIDRE, LOMEN, RYFOSS, RYFOSS, VANG I VALDRES, VANG I VALDRES, \u00d8YE, TYINKRYSSET, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, MJ\u00d8NDALEN, MJ\u00d8NDALEN, STEINBERG, KROKSTADELVA, KROKSTADELVA, SOLBERGELVA, SOLBERGELVA, SOLBERGMOEN, SVELVIK, SVELVIK, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, BERGER, SANDE I VESTFOLD, SANDE I VESTFOLD, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOF, HOF, SUNDBYFOSS, EIDSFOSS, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, SEM, VEAR, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, HUS\u00d8YSUND, HUS\u00d8YSUND, DUKEN, T\u00d8NSBERG, TOR\u00d8D, TOR\u00d8D, SKALLESTAD, SKALLESTAD, N\u00d8TTER\u00d8Y, KJ\u00d8PMANNSKJ\u00c6R, VESTSKOGEN, KJ\u00d8PMANNSKJ\u00c6R, VEIERLAND, TJ\u00d8ME, HVASSER, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, MELSOMVIK, BARK\u00c5KER, ANDEBU, MELSOMVIK, STOKKE, STOKKE, ANDEBU, N\u00d8TTER\u00d8Y, REVETAL, TJ\u00d8ME, TOLVSR\u00d8D, \u00c5SG\u00c5RDSTRAND, MELSOMVIK, STOKKE, SEM, SEM, VEAR, VEAR, REVETAL, RAMNES, UNDRUMSDAL, V\u00c5LE, V\u00c5LE, \u00c5SG\u00c5RDSTRAND, NYKIRKE, HORTEN, HORTEN, HORTEN, BORRE, SKOPPUM, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, SKOPPUM, HORTEN, NYKIRKE, BORRE, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, KODAL, SANDEFJORD, KODAL, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, SVARSTAD, SVARSTAD, STEINSHOLT, TJODALYNG, TJODALYNG, KVELDE, KVELDE, LARVIK, STAVERN, STAVERN, STAVERN, STAVERN, HELGEROA, NEVLUNGHAVN, HELGEROA, HOKKSUND, HOKKSUND, HOKKSUND, HOKKSUND, VESTFOSSEN, VESTFOSSEN, FISKUM, SKOTSELV, SKOTSELV, \u00c5MOT, \u00c5MOT, \u00c5MOT, PRESTFOSS, PRESTFOSS, SOLUMSMOEN, EGGEDAL, NEDRE EGGEDAL, EGGEDAL, GEITHUS, GEITHUS, VIKERSUND, VIKERSUND, LIER, LIER, LIER, LIER, LIER, TRANBY, TRANBY, TRANBY, TRANBY, SYLLING, SYLLING, LIERSTRANDA, LIER, LIERSTRANDA, LIERSKOGEN, LIERSKOGEN, REISTAD, GULLAUG, GULLAUG, GULLAUG, SPIKKESTAD, SPIKKESTAD, R\u00d8YKEN, R\u00d8YKEN, HYGGEN, SLEMMESTAD, SLEMMESTAD, B\u00d8DALEN, \u00c5ROS, S\u00c6TRE, S\u00c6TRE, B\u00c5TST\u00d8, N\u00c6RSNES, N\u00c6RSNES, FILTVET, TOFTE, TOFTE, KANA, HOLMSBU, FILTVET, KLOKKARSTUA, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, JEVNAKER, JEVNAKER, BJONEROA, NES I \u00c5DAL, NES I \u00c5DAL, HALLINGBY, HALLINGBY, BJONEROA, HEDALEN, R\u00d8YSE, R\u00d8YSE, KROKKLEIVA, TYRISTRAND, TYRISTRAND, SOKNA, KR\u00d8DEREN, NORESUND, KR\u00d8DEREN, SOLLIH\u00d8GDA, FL\u00c5, NESBYEN, NESBYEN, NORESUND, TUNHOVD, FL\u00c5, GOL, GOL, HEMSEDAL, HEMSEDAL, \u00c5L, \u00c5L, HOL, HOL, HOVET, TORPO, GEILO, GEILO, DAGALI, USTAOSET, HAUGAST\u00d8L, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, HEISTADMOEN, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, SKOLLENBORG, SKOLLENBORG, FLESBERG, LAMPELAND, SVENE, LAMPELAND, LYNGDAL I NUMEDAL, SKOLLENBORG, ROLLAG, VEGGLI, VEGGLI, NORE, R\u00d8DBERG, R\u00d8DBERG, UVDAL, NORE, HVITTINGFOSS, HVITTINGFOSS, PASSEBEKK, TINN AUSTBYGD, HOVIN I TELEMARK, ATR\u00c5, MILAND, RJUKAN, RJUKAN, SAULAND, ATR\u00c5, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, HJARTDAL, GRANSHERAD, SAULAND, TUDDAL, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SILJAN, SILJAN, DRANGEDAL, T\u00d8RDAL, NESLANDSVATN, SANNIDAL, KRAGER\u00d8, KRAGER\u00d8, SK\u00c5T\u00d8Y, JOMFRULAND, KRAGER\u00d8 SKJ\u00c6RG\u00c5RD, SKIEN, SKIEN, STABBESTAD, KRAGER\u00d8, HELLE, KRAGER\u00d8, SKIEN, SANNIDAL, HELLE, DRANGEDAL, SKIEN, SKIEN, SKIEN, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, GVARV, H\u00d8RTE, AKKERHAUGEN, NORDAGUTU, LUNDE, ULEFOSS, ULEFOSS, LUNDE, B\u00d8 I TELEMARK, GVARV, SELJORD, KVITESEID, SELJORD, FLATDAL, \u00c5MOTSDAL, MORGEDAL, VR\u00c5LIOSEN, KVITESEID, VR\u00c5DAL, VR\u00c5DAL, NISSEDAL, TREUNGEN, RAULAND, FYRESDAL, DALEN, \u00c5MDALS VERK, TREUNGEN, RAULAND, FYRESDAL, DALEN, VINJE, EDLAND, VINJE, H\u00d8YDALSMO, VINJESVINGEN, EDLAND, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, LANGANGEN, PORSGRUNN, PORSGRUNN, BREVIK, STATHELLE, STATHELLE, STATHELLE, HERRE, STATHELLE, STATHELLE, LANGESUND, BREVIK, LANGESUND, LANGESUND, STATHELLE, PORSGRUNN, PORSGRUNN, PORSGRUNN, HERRE, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, SOLA, SOLA, R\u00d8YNEBERG, R\u00c6GE, TJELTA, SOLA, TANANGER, TANANGER, TANANGER, R\u00d8YNEBERG, TJELTA, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, RANDABERG, RANDABERG, RANDABERG, VASS\u00d8Y, HUNDV\u00c5G, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HUNDV\u00c5G, STAVANGER, HUNDV\u00c5G, HUNDV\u00c5G, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, SOLA, TANANGER, STAVANGER, J\u00d8RPELAND, IDSE, FORSAND, FORSAND, TAU, S\u00d8R-HIDLE, TAU, J\u00d8RPELAND, LYSEBOTN, FL\u00d8YRLI, SONGESAND, HJELMELAND, J\u00d8SENFJORDEN, \u00c5RDAL I RYFYLKE, FISTER, SKIFTUN, HJELMELAND, RENNES\u00d8Y, VESTRE \u00c5M\u00d8Y, BRIMSE, AUSTRE \u00c5M\u00d8Y, MOSTER\u00d8Y, BRU, RENNES\u00d8Y, FINN\u00d8Y, FINN\u00d8Y, TALGJE, FOGN, HELG\u00d8Y I RYFYLKE, BYRE, S\u00d8RBOKN, SJERNAR\u00d8Y, NORD-HIDLE, SJERNAR\u00d8Y, KVITS\u00d8Y, KVITS\u00d8Y, SKARTVEIT, OMBO, FOLD\u00d8Y, SAUDA, SAUDA, SAUDASJ\u00d8EN, VANVIK, SAND, ERFJORD, JELSA, HEBNES, SULDALSOSEN, SAND, SULDALSOSEN, NESFLATEN, KOPERVIK, TORVASTAD, AVALDSNES, KVALAV\u00c5G, H\u00c5VIK, \u00c5KREHAMN, SANDVE, STOL, S\u00c6VELANDSVIK, VEAV\u00c5GEN, SKUDENESHAVN, KOPERVIK, KOPERVIK, VEAV\u00c5GEN, \u00c5KREHAMN, SKUDENESHAVN, TORVASTAD, AVALDSNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, FIGGJO, OLTEDAL, DIRDAL, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, BRYNE, BRYNE, UNDHEIM, ORRE, BRYNE, BRYNE, BRYNE, LYE, LYE, BRYNE, KLEPPE, KLEPP STASJON, VOLL, KVERNALAND, KVERNALAND, KLEPP STASJON, KLEPPE, VARHAUG, SIREV\u00c5G, VIGRESTAD, BRUSAND, SIREV\u00c5G, N\u00c6RB\u00d8, N\u00c6RB\u00d8, VARHAUG, VIGRESTAD, EGERSUND, EGERSUND, EGERSUND, EGERSUND, EGERSUND, HELLVIK, HELLELAND, EGERSUND, EGERSUND, HAUGE I DALANE, HAUGE I DALANE, VIKES\u00c5, HELLELAND, BJERKREIM, VIKES\u00c5, OLTEDAL, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, \u00c5NA-SIRA, HIDRASUND, ANDABEL\u00d8Y, GYLAND, SIRA, SIRA, TONSTAD, TONSTAD, TJ\u00d8RHOM, MOI, HOVSHERAD, UALAND, MOI, KVINLOG, KVINESDAL, \u00d8YESTRANDA, FEDA, KVINESDAL, KVINESDAL, KVINESDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, HOLUM, LINDESNES, LINDESNES, LINDESNES, LINDESNES, LINDESNES, KONSMO, KONSMO, KOLLUNGTVEIT, BYREMO, \u00d8YSLEB\u00d8, MARNARDAL, MARNARDAL, BJELLAND, \u00c5SERAL, \u00c5SERAL, FOSSDAL, FARSUND, FARSUND, FARSUND, FARSUND, FARSUND, VANSE, VANSE, VANSE, BORHAUG, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, KORSHAMN, KV\u00c5S, SNARTEMO, TINGVATN, EIKEN, EIKEN, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KARDEMOMME BY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, MOSBY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, NODELAND, FINSLAND, BRENN\u00c5SEN, FINSLAND, HAMRESANDEN, KJEVIK, TVEIT, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, BRENN\u00c5SEN, NODELAND, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, TVEIT, VENNESLA, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, H\u00c6GELAND, H\u00c6GELAND, IVELAND, IVELAND, VATNESTR\u00d8M, EVJE, EVJE, EVJE, HORNNES, BYGLANDSFJORD, GRENDI, BYGLAND, BYGLAND, VALLE, VALLE, RYSSTAD, RYSSTAD, BYKLE, HOVDEN I SETESDAL, HOVDEN I SETESDAL, BIRKELAND, HEREFOSS, ENGESLAND, H\u00d8V\u00c5G, BREKKEST\u00d8, LILLESAND, LILLESAND, LILLESAND, H\u00d8V\u00c5G, LILLESAND, BIRKELAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, KONGSHAVN, SALTR\u00d8D, KOLBJ\u00d8RNSVIK, HIS, F\u00c6RVIK, FROLAND, RYKENE, RYKENE, NEDENES, BJORBEKK, ARENDAL, FROLANDS VERK, MJ\u00c5VATN, HYNNEKLEIV, MYKLAND, RISDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, SALTR\u00d8D, F\u00c6RVIK, HIS, NEDENES, FROLAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, NELAUG, \u00c5MLI, \u00c5MLI, SEL\u00c5SVATN, D\u00d8LEMO, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, HOMBORSUND, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, TVEDESTRAND, TVEDESTRAND, TVEDESTRAND, SONGE, LYNG\u00d8R, GJEVING, VESTRE SAND\u00d8YA, BOR\u00d8Y, STAUB\u00d8, STAUB\u00d8, NES VERK, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, SUNDEBRU, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, SUNDEBRU, AKLAND, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, EIDSV\u00c5GNESET, EIDSV\u00c5G I \u00c5SANE, EIDSV\u00c5G I \u00c5SANE, \u00d8VRE ERVIK, SALHUS, HORDVIK, HYLKJE, BREISTEIN, TERTNES, TERTNES, ULSET, ULSET, ULSET, ULSET, ULSET, ULSET, MORVIK, MORVIK, NYBORG, NYBORG, NYBORG, FLAKTVEIT, FLAKTVEIT, MJ\u00d8LKER\u00c5EN, MJ\u00d8LKER\u00c5EN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, STRAUMSGREND, B\u00d8NES, B\u00d8NES, B\u00d8NES, B\u00d8NES, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, BJ\u00d8RNDALSTR\u00c6, LODDEFJORD, LODDEFJORD, LODDEFJORD, MATHOPEN, LODDEFJORD, BJ\u00d8R\u00d8YHAMN, LODDEFJORD, GODVIK, OLSVIK, OLSVIK, OS, OS, OS, OS, OS, S\u00d8FTELAND, OS, OS, OS, OS, S\u00d8FTELAND, LEPS\u00d8Y, LYSEKLOSTER, LYSEKLOSTER, LEPS\u00d8Y, HAGAVIK, NORDSTR\u00d8NO, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, KALANDSEIDET, PARADIS, PARADIS, PARADIS, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, FANA, FANA, S\u00d8REIDGREND, S\u00d8REIDGREND, SANDSLI, SANDSLI, KOKSTAD, BLOMSTERDALEN, HJELLESTAD, INDRE ARNA, INDRE ARNA, ARNATVEIT, TRENGEREID, GARNES, YTRE ARNA, ESPELAND, HAUKELAND, VALESTRANDSFOSSEN, LONEV\u00c5G, FOTLANDSV\u00c5G, TYSSEBOTNEN, BRUVIK, HAUS, VALESTRANDSFOSSEN, LONEV\u00c5G, HAUS, KLEPPEST\u00d8, KLEPPEST\u00d8, STRUSSHAMN, FOLLESE, HETLEVIK, FLORV\u00c5G, ERDAL, ASK, KLEPPEST\u00d8, KLEPPEST\u00d8, HAUGLANDSHELLA, KJERRGARDEN, KJERRGARDEN, HERDLA, STRUSSHAMN, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, FOLLESE, ASK, HAUGLANDSHELLA, FLORV\u00c5G, RONG, TJELDST\u00d8, HELLES\u00d8Y, HERNAR, TJELDST\u00d8, RONG, STRAUME, STRAUME, STRAUME, KNARREVIK, \u00c5GOTNES, \u00c5GOTNES, BRATTHOLMEN, STRAUME, STRAUME, KNARREVIK, FJELL, FJELL, KOLLTVEIT, \u00c5GOTNES, TUR\u00d8Y, MISJE, SKOGSV\u00c5G, STEINSLAND, KLOKKARVIK, STEINSLAND, T\u00c6LAV\u00c5G, GLESV\u00c6R, SKOGSV\u00c5G, TORANGSV\u00c5G, BAKKASUND, M\u00d8KSTER, LITLAKALS\u00d8Y, STOREB\u00d8, STOREB\u00d8, KOLBEINSVIK, VESTRE VINNESV\u00c5G, BEKKJARVIK, STOLMEN, BEKKJARVIK, STORD, STORD, STORD, STORD, STORD, STORD, SAGV\u00c5G, STORD, SAGV\u00c5G, STORD, STORD, HUGLO, STORD, STORD, STORD, STORD, FITJAR, FITJAR, RUBBESTADNESET, BRANDASUND, URANGSV\u00c5G, FOLDR\u00d8YHAMN, BREMNES, FINN\u00c5S, MOSTERHAMN, B\u00d8MLO, ESPEV\u00c6R, BREMNES, MOSTERHAMN, B\u00d8MLO, SUNDE I SUNNHORDLAND, VALEN, SANDVOLL, UT\u00c5KER, S\u00c6B\u00d8VIK, HALSN\u00d8Y KLOSTER, H\u00d8YLANDSBYGD, ARNAVIK, FJELBERG, HUSNES, HER\u00d8YSUNDET, USKEDALEN, DIMMELSVIK, USKEDALEN, ROSENDAL, SEIMSFOSS, SNILSTVEIT\u00d8Y, L\u00d8FALLSTRAND, \u00c6NES, MAURANGER, HUSNES, S\u00c6B\u00d8VIK, ROSENDAL, MATRE, \u00c5KRA, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KARMSUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KOLNES, KARMSUND, VORMEDAL, VORMEDAL, R\u00d8YKSUND, UTSIRA, FE\u00d8Y, R\u00d8V\u00c6R, SVEIO, AUKLANDSHAMN, VALEV\u00c5G, F\u00d8RDE I HORDALAND, F\u00d8RDE I HORDALAND, SVEIO, NEDSTRAND, BOKN, NEDSTRAND, F\u00d8RRESFJORDEN, TYSV\u00c6RV\u00c5G, HERVIK, SKJOLDASTRAUMEN, VIKEBYGD, BOKN, AKSDAL, SKJOLD, AKSDAL, \u00d8VRE VATS, NEDRE VATS, \u00d8LEN, \u00d8LENSV\u00c5G, VIKEDAL, BJOA, SANDEID, VIKEDAL, \u00d8LEN, SANDEID, ETNE, ETNE, SK\u00c5NEVIK, SK\u00c5NEVIK, F\u00d8RRESFJORDEN, MARKHUS, FJ\u00c6RA, NORHEIMSUND, NORHEIMSUND, NORHEIMSUND, \u00d8YSTESE, \u00c5LVIK, \u00d8YSTESE, STEINST\u00d8, \u00c5LVIK, T\u00d8RVIKBYGD, KYSNESSTRAND, JONDAL, HERAND, JONDAL, STRANDEBARM, STRANDEBARM, OMASTRAND, OMASTRAND, HATLESTRAND, VARALDS\u00d8Y, \u00d8LVE, EIKELANDSOSEN, FUSA, HOLMEFJORD, STRANDVIK, S\u00c6VAREID, S\u00c6VAREID, NORDTVEITGREND, BALDERSHEIM, FUSA, EIKELANDSOSEN, TYSSE, TYSSE, \u00c5RLAND, \u00c5RLAND, TYSNES, REKSTEREN, UGGDAL, FLATR\u00c5KER, LUNDEGREND, \u00c5RBAKKA, ONARHEIM, UGGDAL, TYSNES, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, EVANGER, VOSS, VOSS, SKULESTADMO, SKULESTADMO, VOSSESTRAND, VOSSESTRAND, VOSS, STALHEIM, MYRDAL, FINSE, STANGHELLE, DALEKVAM, DALEKVAM, BOLSTAD\u00d8YRI, STANGHELLE, VAKSDAL, VAKSDAL, STAMNES, EIDSLANDET, MODALEN, ULVIK, ULVIK, MODALEN, GRANVIN, VALLAVIK, GRANVIN, AURLAND, FL\u00c5M, FL\u00c5M, AURLAND, UNDREDAL, GUDVANGEN, STYVI, ODDA, ODDA, ODDA, R\u00d8LDAL, SKARE, TYSSEDAL, HOVLAND, N\u00c5, N\u00c5, GRIMO, UTNE, UTNE, KINSARVIK, LOFTHUS, KINSARVIK, EIDFJORD, \u00d8VRE EIDFJORD, V\u00d8RINGSFOSS, EIDFJORD, LOFTHUS, KINSARVIK, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, ISDALST\u00d8, ISDALST\u00d8, ISDALST\u00d8, FREKHAUG, ALVERSUND, ISDALST\u00d8, ALVERSUND, SEIM, EIKANGERV\u00c5G, ISDALST\u00d8, HJELM\u00c5S, ISDALST\u00d8, ROSSLAND, FREKHAUG, FREKHAUG, MANGER, B\u00d8V\u00c5GEN, MANGER, B\u00d8V\u00c5GEN, S\u00c6B\u00d8V\u00c5GEN, SLETTA, AUSTRHEIM, AUSTRHEIM, FEDJE, FEDJE, LIND\u00c5S, FONNES, FONNES, MONGSTAD, LIND\u00c5S, HUNDVIN, MYKING, DALS\u00d8YRA, BREKKE, BJORDAL, DALS\u00d8YRA, BREKKE, BJORDAL, EIVINDVIK, EIVINDVIK, BYRKNES\u00d8Y, \u00c5NNELAND, MJ\u00d8MNA, BYRKNES\u00d8Y, MASFJORDNES, MASFJORDNES, HAUGSV\u00c6R, MATREDAL, HAUGSV\u00c6R, HOSTELAND, HOSTELAND, OSTEREIDET, OSTEREIDET, VIKANES, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, LANGEV\u00c5G, EIDSNES, FISKARSTRAND, MAUSEIDV\u00c5G, EIDSNES, FISKARSTRAND, LANGEV\u00c5G, VIGRA, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, VALDER\u00d8YA, VALDER\u00d8YA, GISKE, GOD\u00d8YA, GOD\u00d8YA, ELLINGS\u00d8Y, VALDER\u00d8YA, VIGRA, HAREID, BRANDAL, HJ\u00d8RUNGAV\u00c5G, HADDAL, ULSTEINVIK, ULSTEINVIK, EIKSUND, HAREID, TJ\u00d8RV\u00c5G, MOLTUSTRANDA, MOLTUSTRANDA, GJERDSVIKA, GURSK\u00d8Y, GURSK\u00d8Y, GURSKEN, GJERDSVIKA, LARSNES, LARSNES, KVAMS\u00d8Y, KVAMS\u00d8Y, SANDSHAMN, SANDSHAMN, FOSNAV\u00c5G, FOSNAV\u00c5G, FOSNAV\u00c5G, LEIN\u00d8Y, B\u00d8LANDET, RUNDE, NERLANDS\u00d8Y, FOSNAV\u00c5G, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, AUSTEFJORDEN, FOLKESTAD, LAUVSTAD, LAUVSTAD, SYVDE, FISK\u00c5, SYVDE, ROVDE, EIDS\u00c5, FISK\u00c5, SYLTE, \u00c5HEIM, \u00c5HEIM, \u00c5RAM, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, HOVDEBYGDA, HOVDEBYGDA, S\u00c6B\u00d8, S\u00c6B\u00d8, VARTDAL, VARTDAL, BARSTADVIK, TRANDAL, STORESTANDAL, BJ\u00d8RKE, NORANGSFJORDEN, STRANDA, STRANDA, VALLDAL, VALLDAL, LIABYGDA, TAFJORD, NORDDAL, EIDSDAL, GEIRANGER, GEIRANGER, HELLESYLT, HELLESYLT, STRAUMGJERDE, IKORNNES, IKORNNES, HUNDEIDVIK, SYKKYLVEN, STRAUMGJERDE, SYKKYLVEN, \u00d8RSKOG, \u00d8RSKOG, STORDAL, EIDSDAL, STORDAL, SKODJE, SKODJE, TENNFJORD, VATNE, BRATTV\u00c5G, HILDRE, S\u00d8VIK, S\u00d8VIK, BRATTV\u00c5G, VATNE, STOREKALV\u00d8Y, HARAMS\u00d8Y, HARAMS\u00d8Y, KJERSTAD, LONGVA, FJ\u00d8RTOFT, \u00c5NDALSNES, \u00c5NDALSNES, VEBLUNGSNES, INNFJORDEN, ISFJORDEN, VERMA, VERMA, ISFJORDEN, EIDSBYGDA, \u00c5FARNES, \u00c5FARNES, MITTET, VISTDAL, VISTDAL, M\u00c5NDALEN, M\u00c5NDALEN, V\u00c5GSTRANDA, V\u00c5GSTRANDA, FIKSDAL, VESTNES, TRESFJORD, VIKEBUKT, TOMREFJORD, FIKSDAL, REKDAL, VIKEBUKT, TRESFJORD, TOMREFJORD, VESTNES, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, AUREOSEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, SEKKEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, BUD, BUD, HUSTAD, MOLDE, MOLDE, MOLDE, ELNESV\u00c5GEN, TORNES I ROMSDAL, FARSTAD, MALMEFJORDEN, FARSTAD, ELNESV\u00c5GEN, HJELSET, KLEIVE, KLEIVE, HJELSET, KORTGARDEN, SK\u00c5LA, BOLS\u00d8YA, SK\u00c5LA, EIDSV\u00c5G I ROMSDAL, EIDSV\u00c5G I ROMSDAL, RAUDSAND, ERESFJORD, ERESFJORD, EIKESDAL, MIDSUND, MIDSUND, AUKRA, AUKRA, ONA, SAND\u00d8Y, HAR\u00d8Y, ORTEN, HAR\u00d8Y, MYKLEBOST, EIDE, LYNGSTAD, VEVANG, EIDE, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, SM\u00d8LA, SM\u00d8LA, TUSTNA, TUSTNA, SUNNDALS\u00d8RA, SUNNDALS\u00d8RA, \u00d8KSENDAL, FURUGRENDA, GR\u00d8A, GJ\u00d8RA, GJ\u00d8RA, \u00c5LVUNDEID, \u00c5LVUNDFJORD, \u00c5LVUNDFJORD, TINGVOLL, MEISINGSET, TORJULV\u00c5GEN, TINGVOLL, BATNFJORDS\u00d8RA, BATNFJORDS\u00d8RA, GJEMNES, ANGVIK, FLEMMA, OSMARKA, TORVIKBUKT, KVANNE, TORVIKBUKT, STANGVIK, B\u00d8FJORDEN, B\u00c6VERFJORD, TODALEN, SURNADAL, SURNADAL, \u00d8VRE SURNADAL, VIND\u00d8LA, SURNADAL, RINDAL, RINDALSSKOGEN, RINDAL, \u00d8YDEGARD, \u00d8YDEGARD, KVISVIK, HALSANAUSTAN, V\u00c5GLAND, VALS\u00d8YBOTN, VALS\u00d8YFJORD, V\u00c5GLAND, AURE, AURE, MJOSUNDET, FOLDFJORDEN, VIHALS, LESUND, KJ\u00d8RSVIKBUGEN, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, DEKNEPOLLEN, RAUDEBERG, BRYGGJA, RAUDEBERG, BRYGGJA, ALMENNINGEN, SILDA, BARMEN, HUSEV\u00c5G, FLATRAKET, DEKNEPOLLEN, SKATESTRAUMEN, SVELGEN, SVELGEN, BREMANGER, BREMANGER, KALV\u00c5G, KALV\u00c5G, DAVIK, RUGSUND, \u00c5LFOTEN, SELJE, SELJE, STADLANDET, STADLANDET, HORNINDAL, HORNINDAL, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, KJ\u00d8LSDALEN, ST\u00c5RHEIM, LOTE, HOLM\u00d8YANE, STRYN, STRYN, STRYN, OLDEN, OLDEN, LOEN, LOEN, OLDEDALEN, BRIKSDALSBRE, INNVIK, INNVIK, BLAKS\u00c6TER, HOPLAND, UTVIK, HJELLEDALEN, OPPSTRYN, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, HAUKEDALEN, F\u00d8RDE, F\u00d8RDE, SANDANE, SANDANE, SANDANE, BYRKJELO, BREIM, HESTENES\u00d8YRA, HYEN, BYRKJELO, HYEN, SKEI I J\u00d8LSTER, SKEI I J\u00d8LSTER, VASSENDEN, FJ\u00c6RLAND, VASSENDEN, FJ\u00c6RLAND, KAUPANGER, SOGNDAL, SOGNDAL, SOGNDAL, KAUPANGER, FR\u00d8NNINGEN, SOGNDAL, FARDAL, SLINDE, LEIKANGER, LEIKANGER, GAUPNE, HAFSLO, GAUPNE, HAFSLO, ORNES, JOSTEDAL, LUSTER, MARIFJ\u00d8RA, LUSTER, H\u00d8YHEIMSVIK, SKJOLDEN, FORTUN, VEITASTROND, SOLVORN, \u00c5RDALSTANGEN, \u00d8VRE \u00c5RDAL, \u00d8VRE \u00c5RDAL, \u00c5RDALSTANGEN, L\u00c6RDAL, L\u00c6RDAL, BORGUND, VIK I SOGN, VIK I SOGN, VANGSNES, FEIOS, FRESVIK, BALESTRAND, BALESTRAND, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, KINN, FLOR\u00d8, SVAN\u00d8YBUKT, ROGNALDSV\u00c5G, BAREKSTAD, BATALDEN, S\u00d8R-SKORPA, TANS\u00d8Y, HARDBAKKE, HARDBAKKE, KRAKHELLA, YTR\u00d8YGREND, KOLGROV, HERSVIKBYGDA, EIKEFJORD, EIKEFJORD, SVORTEVIK, STAVANG, LAVIK, LAVIK, LEIRVIK I SOGN, LEIRVIK I SOGN, HYLLESTAD, S\u00d8RB\u00d8V\u00c5G, S\u00d8RB\u00d8V\u00c5G, DALE I SUNNFJORD, DALE I SUNNFJORD, KORSSUND, GUDDAL, HELLEVIK I FJALER, FLEKKE, STRAUMSNES, SANDE I SUNNFJORD, SANDE I SUNNFJORD, SKILBREI, BYGSTAD, BYGSTAD, VIKSDALEN, ASKVOLL, HOLMEDAL, KVAMMEN, STONGFJORDEN, ATL\u00d8Y, V\u00c6RLANDET, BULANDET, ASKVOLL, H\u00d8YANGER, H\u00d8YANGER, KYRKJEB\u00d8, VADHEIM, VADHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, RANHEIM, RANHEIM, RANHEIM, RANHEIM, JONSVATNET, JAKOBSLI, JAKOBSLI, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, BOSBERG, TRONDHEIM, HEIMDAL, SPONGDAL, TILLER, SAUPSTAD, FLAT\u00c5SEN, HEIMDAL, SJETNEMARKA, KATTEM, LEINSTRAND, HEIMDAL, HEIMDAL, TILLER, TILLER, TILLER, SAUPSTAD, SAUPSTAD, FLAT\u00c5SEN, RISSA, RISSA, STADSBYGD, FEV\u00c5G, HASSELVIKA, HASSELVIKA, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, STADSBYGD, LEKSVIK, LEKSVIK, VANVIKAN, VANVIKAN, OPPHAUG, BREKSTAD, BREKSTAD, OPPHAUG, UTHAUG, STORFOSNA, STORFOSNA, KR\u00c5KV\u00c5G, GARTEN, LEKSA, BJUGN, BJUGN, LYS\u00d8YSUNDET, OKSVOLL, TARVA, VALLERSUND, LYS\u00d8YSUNDET, \u00c5FJORD, \u00c5FJORD, REVSNES, STOKK\u00d8Y, LINES\u00d8YA, REVSNES, STOKK\u00d8Y, ROAN, ROAN, BESSAKER, BRANDSFJORD, KYRKS\u00c6TER\u00d8RA, KYRKS\u00c6TER\u00d8RA, VINJE\u00d8RA, HELLANDSJ\u00d8EN, KORSVEGEN, KORSVEGEN, G\u00c5SBAKKEN, MELHUS, MELHUS, MELHUS, GIMSE, KV\u00c5L, LUNDAMO, LUNDAMO, LER, LER, HOVIN I GAULDAL, HOVIN I GAULDAL, HITRA, HITRA, ANSNES, KNARRLAGSUND, KVENV\u00c6R, KNARRLAGSUND, KVENV\u00c6R, SANDSTAD, HESTVIKA, MELANDSJ\u00d8, DOLM\u00d8Y, SUNDLANDET, HEMNSKJELA, SNILLFJORD, SNILLFJORD, SISTRANDA, SISTRANDA, HAMARVIK, HAMARVIK, KVERVA, KVERVA, TITRAN, DYRVIK, NORDDYR\u00d8Y, NORDDYR\u00d8Y, SULA, BOG\u00d8YV\u00c6R, MAUSUND, GJ\u00c6SINGEN, S\u00d8RBUR\u00d8Y, SAU\u00d8Y, SOKNEDAL, SOKNEDAL, ST\u00d8REN, ST\u00d8REN, ROGNES, BUDALEN, ORKANGER, ORKANGER, ORKANGER, GJ\u00d8LME, LENSVIK, LENSVIK, AGDENES, AGDENES, FANNREM, FANNREM, SVORKMO, SVORKMO, L\u00d8KKEN VERK, L\u00d8KKEN VERK, STOR\u00c5S, STOR\u00c5S, JERPSTAD, MELDAL, MELDAL, OPPDAL, OPPDAL, L\u00d8NSET, VOGNILL, DRIVA, BUVIKA, BUVIKA, B\u00d8RSA, VIGGJA, EGGKLEIVA, SKAUN, SKAUN, B\u00d8RSA, R\u00d8ROS, BREKKEBYGD, GL\u00c5MOS, R\u00d8ROS, \u00c5LEN, HALTDALEN, \u00c5LEN, SINGS\u00c5S, SINGS\u00c5S, SINGS\u00c5S, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, SKATVAL, SKATVAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, HELL, ELVARLI, HEGRA, FLORNES, HEGRA, MER\u00c5KER, MER\u00c5KER, KOPPER\u00c5, KL\u00c6BU, KL\u00c6BU, TANEM, HOMMELVIK, HOMMELVIK, VIKHAMMER, SAKSVIK, MALVIK, VIKHAMMER, HELL, SELBU, SELBU, SELBU, SELBUSTRAND, TYDAL, TYDAL, FLAKNAN, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, SKOGN, SKOGN, MARKABYGDA, RONGLAN, EKNE, YTTER\u00d8Y, \u00c5SEN, \u00c5SEN, \u00c5SENFJORD, FROSTA, FROSTA, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VUKU, VUKU, INDER\u00d8Y, INDER\u00d8Y, INDER\u00d8Y, MOSVIK, MOSVIK, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINSDALEN, STEINSDALEN, YTTERV\u00c5G, HEPS\u00d8Y, OPPLAND, HASV\u00c5G, S\u00c6TERVIK, NAMDALSEID, NAMDALSEID, SN\u00c5SA, SN\u00c5SA, FLATANGER, FLATANGER, NORD-STATLAND, MALM, MALM, FOLLAFOSS, FOLLAFOSS, VERRABOTN, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, SALSNES, LUND, FOSSLANDSOSEN, SPILLUM, SPILLUM, BANGSUND, BANGSUND, J\u00d8A, SKAGE I NAMDALEN, OVERHALLA, OVERHALLA, SKAGE I NAMDALEN, GRONG, GRONG, HARRAN, HARRAN, KONGSMOEN, H\u00d8YLANDET, H\u00d8YLANDET, NORDLI, NORDLI, S\u00d8RLI, S\u00d8RLI, NAMSSKOGAN, NAMSSKOGAN, TRONES, SKOROVATN, BREKKVASSELV, LIMINGEN, LIMINGEN, R\u00d8RVIK, R\u00d8RVIK, R\u00d8RVIK, OTTERS\u00d8Y, OTTERS\u00d8Y, INDRE N\u00c6R\u00d8Y, ABELV\u00c6R, SALSBRUKET, KOLVEREID, KOLVEREID, GJERDINGA, TERR\u00c5K, TERR\u00c5K, HARANGSFJORD, BINDALSEIDET, BINDALSEIDET, FOLDEREID, FOLDEREID, NAUSTBUKTA, GUTVIK, LEKA, LEKA, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, TVERLANDET, SALTSTRAUMEN, SALTSTRAUMEN, TVERLANDET, V\u00c6R\u00d8Y, V\u00c6R\u00d8Y, R\u00d8ST, R\u00d8ST, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, KJERRING\u00d8Y, FLEINV\u00c6R, HELLIGV\u00c6R, BLIKSV\u00c6R, GIV\u00c6R, LANDEGODE, JAN MAYEN, MISV\u00c6R, SKJERSTAD, BREIVIK I SALTEN, MISV\u00c6R, MOLDJORD, TOLL\u00c5, MOLDJORD, NYG\u00c5RDSJ\u00d8EN, YTRE BEIARN, SANDHORN\u00d8Y, S\u00d8RARN\u00d8Y, S\u00d8RARN\u00d8Y, NORDARN\u00d8Y, INNDYR, INNDYR, STORVIK, REIP\u00c5, NEVERDAL, \u00d8RNES, \u00d8RNES, MEL\u00d8Y, BOLGA, ST\u00d8TT, GLOMFJORD, GLOMFJORD, ENGAV\u00c5GEN, ENGAV\u00c5GEN, HALSA, HALSA, MYKEN, MELFJORDBOTN, V\u00c5GAHOLMEN, \u00c5GSKARDET, V\u00c5GAHOLMEN, TJONGSFJORDEN, JEKTVIK, NORDVERNES, GJERSVIKGRENDA, S\u00d8RFJORDEN, R\u00d8D\u00d8Y, GJER\u00d8Y, SELS\u00d8YVIK, STORSELS\u00d8Y, NORDNES\u00d8Y, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, VALNESFJORD, FAUSKE, FAUSKE, R\u00d8SVIK, STRAUMEN, SULITJELMA, SULITJELMA, STRAUMEN, VALNESFJORD, ROGNAN, ROGNAN, R\u00d8KLAND, R\u00d8KLAND, INNHAVET, INNHAVET, ENGAN, M\u00d8RSVIKBOTN, DRAG, DRAG, NEVERVIK, MUSKEN, STORJORD I TYSFJORD, ULVSV\u00c5G, STOR\u00c5, LEINESFJORD, LEINESFJORD, LEINES, NORDFOLD, ENGEL\u00d8YA, BOG\u00d8Y, ENGEL\u00d8YA, SKUTVIK, HAMAR\u00d8Y, TRAN\u00d8Y, HAMAR\u00d8Y, SVOLV\u00c6R, SVOLV\u00c6R, SVOLV\u00c6R, KABELV\u00c5G, KABELV\u00c5G, HENNINGSV\u00c6R, HENNINGSV\u00c6R, KLEPPSTAD, GIMS\u00d8YSAND, LAUKVIK, LAUPSTAD, STR\u00d8NSTAD, SKROVA, BRETTESNES, STORFJELL, DIGERMULEN, TENGELFJORD, MYRLAND, STORMOLLA, STAMSUND, SENNESVIK, VALBERG, B\u00d8STAD, B\u00d8STAD, LEKNES, GRAVDAL, BALLSTAD, BALLSTAD, LEKNES, GRAVDAL, STAMSUND, RAMBERG, NAPP, SUND I LOFOTEN, FREDVANG, RAMBERG, REINE, S\u00d8RV\u00c5GEN, S\u00d8RV\u00c5GEN, REINE, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, GULLESFJORD, L\u00d8DINGEN, L\u00d8DINGEN, VESTBYGD, KVITNES, HENNES, SORTLAND, SORTLAND, SORTLAND, BARKESTAD, TUNSTAD, MYRE, ALSV\u00c5G, ST\u00d8, MYRE, MELBU, LONKAN, STOKMARKNES, STOKMARKNES, MELBU, STRAUMSJ\u00d8EN, B\u00d8 I VESTER\u00c5LEN, B\u00d8 I VESTER\u00c5LEN, STRAUMSJ\u00d8EN, ANDENES, BLEIK, ANDENES, RIS\u00d8YHAMN, DVERBERG, N\u00d8SS, NORDMELA, RIS\u00d8YHAMN, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, BEISFJORD, ELVEG\u00c5RD, BJERKVIK, BJERKVIK, BOGEN I OFOTEN, LILAND, T\u00c5RSTAD, EVENES, BOGEN I OFOTEN, BALLANGEN, KJELDEBOTN, BALLANGEN, KJ\u00d8PSVIK, KJ\u00d8PSVIK, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, SKONSENG, MO I RANA, DALSGRENDA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, STORFORSHEI, MO I RANA, STORFORSHEI, HEMNESBERGET, HEMNESBERGET, FINNEIDFJORD, BJERKA, BJERKA, KORGEN, BLEIKVASSLIA, KORGEN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, ELSFJORD, TROFORS, TROFORS, HATTFJELLDAL, HATTFJELLDAL, NESNA, NESNA, VIKHOLMEN, HUSBY, SAURA, UTSKARPEN, BRATLAND, ALDRA, STUVLAND, STOKKV\u00c5GEN, NORD-SOLV\u00c6R, SELV\u00c6R, INDRE KVAR\u00d8Y, TONNES, KONSVIKOSEN, KONSVIKOSEN, \u00d8RESVIK, SLENESET, LOVUND, LUR\u00d8Y, LUR\u00d8Y, TR\u00c6NA, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, L\u00d8KTA, D\u00d8NNA, D\u00d8NNA, VANDVE, BRAS\u00d8Y, SANDV\u00c6R, HER\u00d8Y, HER\u00d8Y, HER\u00d8Y, AUSTB\u00d8, TJ\u00d8TTA, TJ\u00d8TTA, TRO, VISTHUS, B\u00c6R\u00d8YV\u00c5GEN, LEIRFJORD, LEIRFJORD, SUND\u00d8Y, BARDAL, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, S\u00d8MNA, S\u00d8MNA, S\u00d8MNA, VELFJORD, VELFJORD, VEVELSTAD, VEVELSTAD, VEGA, VEGA, YLVINGEN, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMSDALEN, TROMSDALEN, KROKELVDALEN, KROKELVDALEN, TOMASJORD, RAMFJORDBOTN, TROMSDALEN, SJURSNES, OLDERVIK, TROMS\u00d8, TROMS\u00d8, NORDKJOSBOTN, LAKSVATN, J\u00d8VIK, OTEREN, NORDKJOSBOTN, STORSTEINNES, MEISTERVIK, MORTENHALS, VIKRAN, STORSTEINNES, LYNGSEIDET, FURUFLATEN, SVENSBY, NORD-LENANGEN, LYNGSEIDET, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YA, KVAL\u00d8YA, KVAL\u00d8YA, STRAUMSBUKTA, KVAL\u00d8YA, KVAL\u00d8YA, SOMMAR\u00d8Y, BRENSHOLMEN, SOMMAR\u00d8Y, VENGS\u00d8Y, TUSS\u00d8Y, HANSNES, K\u00c5RVIK, STAKKVIK, HANSNES, VANNV\u00c5G, VANNAREID, VANNV\u00c5G, KARLS\u00d8Y, REBBENES, MJ\u00d8LVIK, SKIBOTN, SKIBOTN, SAMUELSBERG, SAMUELSBERG, OLDERDALEN, BIRTAVARRE, OLDERDALEN, BIRTAVARRE, STORSLETT, S\u00d8RKJOSEN, ROTSUND, S\u00d8RKJOSEN, STORSLETT, HAVNNES, BURFJORD, S\u00d8RSTRAUMEN, J\u00d8KELFJORD, BURFJORD, LONGYEARBYEN, LONGYEARBYEN, NY-\u00c5LESUND, HOPEN, SVEAGRUVA, BJ\u00d8RN\u00d8YA, BARENTSBURG, SKJERV\u00d8Y, HAMNEIDET, SEGLVIK, REINFJORD, SPILDRA, ANDSNES, VALANHAMN, SKJERV\u00d8Y, AKKARVIK, ARN\u00d8YHAMN, NIKKEBY, LAUKSLETTA, \u00c5RVIKSAND, UL\u00d8YBUKT, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, FINNSNES, ROSSFJORDSTRAUMEN, SILSAND, VANGSVIK, FINNSNES, FINNSNES, FINNSNES, FINNSNES, FINNSNES, S\u00d8RREISA, BR\u00d8STADBOTN, S\u00d8RREISA, BR\u00d8STADBOTN, MOEN, KARLSTAD, BARDUFOSS, BARDUFOSS, MOEN, \u00d8VERBYGD, \u00d8VERBYGD, RUNDHAUG, SJ\u00d8VEGAN, SJ\u00d8VEGAN, TENNEVOLL, TENNEVOLL, BARDU, BARDU, SILSAND, GIBOSTAD, BOTNHAMN, SKATVIK, GRYLLEFJORD, GRYLLEFJORD, TORSKEN, GIBOSTAD, SKALAND, SKALAND, SENJAHOPEN, SENJAHOPEN, FJORDGARD, HUS\u00d8Y I SENJA, STONGLANDSEIDET, STONGLANDSEIDET, FLAKSTADV\u00c5G, KALDFARNES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, S\u00d8RVIK, LUNDENES, GR\u00d8TAV\u00c6R, KJ\u00d8TTA, SANDS\u00d8Y, BJARK\u00d8Y, MEL\u00d8YV\u00c6R, SANDTORG, KONGSVIK, EVENSKJER, EVENSKJER, FJELLDAL, RAMSUND, MYKLEBOSTAD, HOL I TJELDSUND, TOVIK, GROVFJORD, GROVFJORD, RAMSUND, HAMNVIK, HAMNVIK, KR\u00c5KR\u00d8HAMN, \u00c5NSTAD, ENGENES, ENGENES, GRATANGEN, GRATANGEN, BORKENES, BORKENES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, KVIBY, KAUTOKEINO, KAUTOKEINO, MAZE, KVALFJORD, HAKKSTABBEN, KONGSHUS, KORSFJORDEN, TALVIK, LANGFJORDBOTN, \u00d8KSFJORD, BERGSFJORD, NUVSV\u00c5G, LANGFJORDHAMN, S\u00d8R-TVERRFJORD, SANDLAND, LOPPA, SKAVNAKK, HASVIK, HASVIK, BREIVIKBOTN, S\u00d8RV\u00c6R, HAMMERFEST, HAMMERFEST, HAMMERFEST, HAMMERFEST, NORDRE SEILAND, RYPEFJORD, RYPEFJORD, FORS\u00d8L, HAMMERFEST, HAMMERFEST, KVALSUND, KVALSUND, REVSNESHAMN, AKKARFJORD, LANGSTRAND, K\u00c5RHAMN, SAND\u00d8YBOTN, TUFJORD, ING\u00d8Y, HAV\u00d8YSUND, HAV\u00d8YSUND, M\u00c5S\u00d8Y, LAKSELV, PORSANGMOEN, INDRE BILLEFJORD, LAKSELV, LAKSELV, RUSSENES, SNEFJORD, KOKELV, B\u00d8RSELV, VEIDNESKLUBBEN, SKOGANVARRE, KARASJOK, KARASJOK, LEBESBY, KUNES, HONNINGSV\u00c5G, HONNINGSV\u00c5G, NORDV\u00c5GEN, SKARSV\u00c5G, NORDKAPP, GJESV\u00c6R, REPV\u00c5G, MEHAMN, SKJ\u00c5NES, LANGFJORDNES, NERVEI, GAMVIK, DYFJORD, KJ\u00d8LLEFJORD, VADS\u00d8, VESTRE JAKOBSELV, VESTRE JAKOBSELV, VADS\u00d8, VADS\u00d8, VARANGERBOTN, SIRMA, VARANGERBOTN, TANA, TANA, KIRKENES, BJ\u00d8RNEVATN, HESSENG, BJ\u00d8RNEVATN, KIRKENES, HESSENG, KIRKENES, SVANVIK, NEIDEN, BUG\u00d8YNES, VARD\u00d8, VARD\u00d8, KIBERG, BERLEV\u00c5G, BERLEV\u00c5G, KONGSFJORD, B\u00c5TSFJORD, B\u00c5TSFJORD".ToCharArray()

		l = New StringReference (10000 - 1){}

		p = strSplitByString(poststeder, ", ".ToCharArray())

		nr = HentPostnummerListe()

		i = 0.0
		While i < nr.Length
			l(nr(i)) = p(i)
			i = i + 1.0
		End While

		Return l
	End Function


	Public Function HentPostnummerListe() As Double ()
		Dim n As Double ()

		n = StringToNumberArray("0001, 0010, 0015, 0018, 0021, 0024, 0026, 0028, 0030, 0031, 0032, 0033, 0034, 0037, 0040, 0045, 0046, 0047, 0048, 0050, 0055, 0060, 0081, 0101, 0102, 0103, 0104, 0105, 0106, 0107, 0109, 0110, 0111, 0112, 0113, 0114, 0115, 0116, 0117, 0118, 0119, 0120, 0121, 0122, 0123, 0124, 0125, 0128, 0129, 0130, 0131, 0132, 0133, 0134, 0135, 0136, 0138, 0139, 0140, 0150, 0151, 0152, 0153, 0154, 0155, 0157, 0158, 0159, 0160, 0161, 0162, 0164, 0165, 0166, 0167, 0168, 0169, 0170, 0171, 0172, 0173, 0174, 0175, 0176, 0177, 0178, 0179, 0180, 0181, 0182, 0183, 0184, 0185, 0186, 0187, 0188, 0190, 0191, 0192, 0193, 0194, 0195, 0196, 0198, 0201, 0202, 0203, 0204, 0207, 0208, 0211, 0212, 0213, 0214, 0215, 0216, 0217, 0218, 0230, 0240, 0244, 0247, 0250, 0251, 0252, 0253, 0254, 0255, 0256, 0257, 0258, 0259, 0260, 0262, 0263, 0264, 0265, 0266, 0267, 0268, 0270, 0271, 0272, 0273, 0274, 0275, 0276, 0277, 0278, 0279, 0280, 0281, 0282, 0283, 0284, 0286, 0287, 0301, 0302, 0303, 0304, 0305, 0306, 0307, 0308, 0309, 0311, 0313, 0314, 0315, 0316, 0317, 0318, 0319, 0323, 0330, 0340, 0349, 0350, 0351, 0352, 0353, 0354, 0355, 0356, 0357, 0358, 0359, 0360, 0361, 0362, 0363, 0364, 0365, 0366, 0367, 0368, 0369, 0370, 0371, 0372, 0373, 0374, 0375, 0376, 0377, 0378, 0379, 0380, 0381, 0382, 0383, 0401, 0402, 0403, 0404, 0405, 0406, 0409, 0410, 0411, 0412, 0413, 0415, 0421, 0422, 0423, 0424, 0440, 0441, 0442, 0445, 0450, 0451, 0452, 0454, 0455, 0456, 0457, 0458, 0459, 0460, 0461, 0462, 0463, 0464, 0465, 0467, 0468, 0469, 0470, 0472, 0473, 0474, 0475, 0476, 0477, 0478, 0479, 0480, 0481, 0482, 0483, 0484, 0485, 0486, 0487, 0488, 0489, 0490, 0491, 0492, 0493, 0494, 0495, 0496, 0501, 0502, 0503, 0504, 0505, 0506, 0507, 0508, 0509, 0510, 0511, 0512, 0513, 0515, 0516, 0517, 0518, 0520, 0540, 0550, 0551, 0552, 0553, 0554, 0555, 0556, 0557, 0558, 0559, 0560, 0561, 0562, 0563, 0564, 0565, 0566, 0567, 0568, 0569, 0570, 0571, 0572, 0573, 0574, 0575, 0576, 0577, 0578, 0579, 0580, 0581, 0582, 0583, 0584, 0585, 0586, 0587, 0588, 0589, 0590, 0591, 0592, 0593, 0594, 0595, 0596, 0597, 0598, 0601, 0602, 0603, 0604, 0605, 0606, 0607, 0608, 0609, 0611, 0612, 0613, 0614, 0615, 0616, 0617, 0618, 0619, 0620, 0621, 0622, 0623, 0624, 0626, 0650, 0651, 0652, 0653, 0654, 0655, 0656, 0657, 0658, 0659, 0660, 0661, 0662, 0663, 0664, 0665, 0666, 0667, 0668, 0669, 0670, 0671, 0672, 0673, 0674, 0675, 0676, 0677, 0678, 0679, 0680, 0681, 0682, 0683, 0684, 0685, 0686, 0687, 0688, 0689, 0690, 0691, 0692, 0693, 0694, 0701, 0702, 0705, 0710, 0712, 0750, 0751, 0752, 0753, 0754, 0755, 0756, 0757, 0758, 0760, 0763, 0764, 0765, 0766, 0767, 0768, 0770, 0771, 0772, 0773, 0774, 0775, 0776, 0777, 0778, 0779, 0781, 0782, 0783, 0784, 0785, 0786, 0787, 0788, 0789, 0790, 0791, 0801, 0805, 0806, 0807, 0840, 0850, 0851, 0852, 0853, 0854, 0855, 0856, 0857, 0858, 0860, 0861, 0862, 0863, 0864, 0870, 0871, 0872, 0873, 0874, 0875, 0876, 0877, 0880, 0881, 0882, 0883, 0884, 0890, 0891, 0901, 0902, 0903, 0904, 0905, 0907, 0908, 0913, 0914, 0915, 0950, 0951, 0952, 0953, 0954, 0955, 0956, 0957, 0958, 0959, 0960, 0962, 0963, 0964, 0968, 0969, 0970, 0971, 0972, 0973, 0975, 0976, 0977, 0978, 0979, 0980, 0981, 0982, 0983, 0984, 0985, 0986, 0987, 0988, 1001, 1003, 1005, 1006, 1007, 1008, 1009, 1011, 1051, 1052, 1053, 1054, 1055, 1056, 1061, 1062, 1063, 1064, 1065, 1067, 1068, 1069, 1071, 1081, 1083, 1084, 1086, 1087, 1088, 1089, 1101, 1102, 1108, 1109, 1112, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1172, 1176, 1177, 1178, 1179, 1181, 1182, 1184, 1185, 1187, 1188, 1189, 1201, 1203, 1204, 1205, 1207, 1214, 1215, 1250, 1251, 1252, 1253, 1254, 1255, 1256, 1257, 1258, 1259, 1262, 1263, 1266, 1270, 1271, 1272, 1273, 1274, 1275, 1278, 1279, 1281, 1283, 1284, 1285, 1286, 1290, 1291, 1294, 1295, 1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1311, 1312, 1313, 1314, 1316, 1317, 1318, 1319, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1344, 1346, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1371, 1372, 1373, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1501, 1502, 1503, 1504, 1506, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540, 1541, 1545, 1550, 1555, 1556, 1560, 1561, 1570, 1580, 1581, 1590, 1591, 1592, 1593, 1594, 1596, 1597, 1598, 1599, 1601, 1602, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621, 1622, 1623, 1624, 1625, 1626, 1628, 1629, 1630, 1632, 1633, 1634, 1636, 1637, 1638, 1639, 1640, 1641, 1642, 1650, 1651, 1653, 1654, 1655, 1657, 1658, 1659, 1661, 1662, 1663, 1664, 1665, 1666, 1667, 1670, 1671, 1672, 1673, 1675, 1676, 1678, 1679, 1680, 1682, 1683, 1684, 1690, 1692, 1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1730, 1733, 1734, 1735, 1738, 1739, 1740, 1742, 1743, 1745, 1746, 1747, 1751, 1752, 1753, 1754, 1757, 1759, 1760, 1761, 1762, 1763, 1764, 1765, 1766, 1767, 1768, 1769, 1771, 1772, 1776, 1777, 1778, 1779, 1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1796, 1798, 1799, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1811, 1812, 1813, 1814, 1815, 1816, 1820, 1821, 1823, 1825, 1827, 1830, 1831, 1832, 1833, 1850, 1851, 1852, 1859, 1860, 1861, 1866, 1867, 1870, 1871, 1875, 1878, 1880, 1890, 1891, 1892, 1893, 1894, 1900, 1901, 1903, 1910, 1911, 1912, 1914, 1916, 1917, 1920, 1921, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1940, 1941, 1950, 1954, 1960, 1961, 1963, 1970, 1971, 2000, 2001, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2040, 2041, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2060, 2061, 2062, 2063, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2076, 2080, 2081, 2090, 2091, 2092, 2093, 2094, 2100, 2101, 2110, 2114, 2116, 2120, 2121, 2123, 2130, 2132, 2133, 2134, 2150, 2151, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2170, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2223, 2224, 2225, 2226, 2227, 2230, 2231, 2232, 2233, 2235, 2240, 2241, 2251, 2256, 2260, 2261, 2264, 2265, 2266, 2270, 2271, 2280, 2283, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2344, 2345, 2346, 2350, 2351, 2353, 2355, 2360, 2361, 2364, 2365, 2372, 2373, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2432, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2446, 2447, 2448, 2450, 2451, 2460, 2461, 2476, 2477, 2478, 2480, 2481, 2484, 2485, 2486, 2487, 2488, 2500, 2501, 2510, 2512, 2513, 2540, 2541, 2542, 2544, 2550, 2551, 2552, 2555, 2560, 2561, 2580, 2581, 2582, 2584, 2601, 2602, 2603, 2604, 2605, 2606, 2607, 2608, 2609, 2610, 2611, 2612, 2613, 2614, 2615, 2616, 2617, 2618, 2619, 2620, 2621, 2622, 2623, 2624, 2625, 2626, 2627, 2628, 2629, 2630, 2631, 2632, 2633, 2634, 2635, 2636, 2637, 2638, 2639, 2640, 2641, 2642, 2643, 2644, 2645, 2646, 2647, 2648, 2649, 2651, 2652, 2653, 2654, 2656, 2657, 2658, 2659, 2660, 2661, 2662, 2663, 2664, 2665, 2666, 2667, 2668, 2669, 2670, 2671, 2672, 2673, 2674, 2675, 2676, 2677, 2678, 2679, 2680, 2681, 2682, 2683, 2684, 2685, 2686, 2687, 2688, 2690, 2693, 2694, 2695, 2711, 2712, 2713, 2714, 2715, 2716, 2717, 2718, 2720, 2730, 2740, 2742, 2743, 2750, 2760, 2770, 2801, 2802, 2803, 2804, 2805, 2806, 2807, 2808, 2809, 2810, 2811, 2812, 2815, 2816, 2817, 2818, 2819, 2820, 2821, 2822, 2825, 2827, 2830, 2831, 2832, 2833, 2834, 2835, 2836, 2837, 2838, 2839, 2840, 2841, 2843, 2844, 2845, 2846, 2847, 2848, 2849, 2850, 2851, 2853, 2854, 2857, 2858, 2860, 2861, 2862, 2864, 2866, 2867, 2870, 2879, 2880, 2881, 2882, 2890, 2893, 2900, 2901, 2907, 2909, 2910, 2917, 2918, 2920, 2923, 2929, 2930, 2933, 2936, 2937, 2939, 2940, 2943, 2950, 2952, 2953, 2954, 2959, 2960, 2965, 2966, 2967, 2972, 2973, 2974, 2975, 2977, 2985, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3050, 3051, 3053, 3054, 3055, 3056, 3057, 3058, 3060, 3061, 3063, 3064, 3065, 3066, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3095, 3101, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3131, 3132, 3133, 3134, 3135, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3148, 3150, 3151, 3152, 3153, 3154, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3199, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3251, 3252, 3253, 3254, 3255, 3256, 3257, 3258, 3259, 3260, 3261, 3262, 3263, 3264, 3265, 3267, 3268, 3269, 3270, 3271, 3274, 3275, 3276, 3277, 3280, 3281, 3282, 3284, 3285, 3290, 3291, 3292, 3294, 3295, 3296, 3297, 3300, 3301, 3302, 3303, 3320, 3321, 3322, 3330, 3331, 3340, 3341, 3342, 3350, 3351, 3355, 3357, 3358, 3359, 3360, 3361, 3370, 3371, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3420, 3421, 3425, 3426, 3427, 3428, 3430, 3431, 3440, 3441, 3442, 3470, 3471, 3472, 3474, 3475, 3476, 3477, 3478, 3479, 3480, 3481, 3482, 3483, 3484, 3485, 3490, 3501, 3502, 3503, 3504, 3507, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528, 3529, 3530, 3531, 3532, 3533, 3534, 3535, 3536, 3537, 3538, 3539, 3540, 3541, 3543, 3544, 3545, 3550, 3551, 3560, 3561, 3570, 3571, 3575, 3576, 3577, 3579, 3580, 3581, 3588, 3593, 3595, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3621, 3622, 3623, 3624, 3625, 3626, 3627, 3628, 3629, 3630, 3631, 3632, 3634, 3646, 3647, 3648, 3650, 3652, 3656, 3658, 3660, 3661, 3665, 3666, 3671, 3672, 3673, 3674, 3675, 3676, 3677, 3678, 3679, 3680, 3681, 3683, 3684, 3690, 3691, 3692, 3697, 3701, 3702, 3703, 3704, 3705, 3707, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3746, 3747, 3748, 3749, 3750, 3753, 3760, 3766, 3770, 3772, 3780, 3781, 3783, 3785, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3810, 3811, 3812, 3820, 3825, 3830, 3831, 3832, 3833, 3834, 3835, 3836, 3840, 3841, 3844, 3848, 3849, 3850, 3852, 3853, 3854, 3855, 3864, 3870, 3880, 3882, 3883, 3884, 3885, 3886, 3887, 3888, 3890, 3891, 3893, 3895, 3901, 3902, 3903, 3904, 3905, 3906, 3910, 3911, 3912, 3913, 3914, 3915, 3916, 3917, 3918, 3919, 3920, 3921, 3922, 3924, 3925, 3928, 3929, 3930, 3931, 3933, 3936, 3937, 3939, 3940, 3941, 3942, 3943, 3944, 3946, 3947, 3948, 3949, 3950, 3960, 3961, 3962, 3965, 3966, 3967, 3970, 3991, 3993, 3994, 3995, 3996, 3997, 3998, 3999, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4031, 4032, 4033, 4034, 4035, 4036, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071, 4072, 4073, 4076, 4077, 4078, 4079, 4081, 4082, 4083, 4084, 4085, 4086, 4087, 4088, 4089, 4090, 4091, 4092, 4093, 4094, 4095, 4096, 4097, 4098, 4099, 4100, 4102, 4110, 4119, 4120, 4123, 4124, 4126, 4127, 4128, 4129, 4130, 4134, 4137, 4139, 4146, 4148, 4150, 4152, 4153, 4154, 4156, 4158, 4159, 4160, 4161, 4163, 4164, 4167, 4168, 4169, 4170, 4173, 4174, 4180, 4181, 4182, 4187, 4198, 4200, 4201, 4208, 4209, 4230, 4233, 4234, 4235, 4237, 4239, 4240, 4244, 4250, 4260, 4262, 4264, 4265, 4270, 4272, 4274, 4275, 4276, 4280, 4291, 4294, 4295, 4296, 4297, 4298, 4299, 4301, 4302, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4317, 4318, 4319, 4320, 4321, 4322, 4323, 4324, 4325, 4326, 4327, 4328, 4329, 4330, 4332, 4333, 4335, 4336, 4337, 4338, 4339, 4340, 4341, 4342, 4343, 4344, 4345, 4346, 4347, 4348, 4349, 4352, 4353, 4354, 4355, 4356, 4357, 4358, 4360, 4361, 4362, 4363, 4364, 4365, 4367, 4368, 4369, 4370, 4371, 4372, 4373, 4374, 4375, 4376, 4378, 4379, 4380, 4381, 4384, 4385, 4387, 4389, 4390, 4391, 4392, 4393, 4394, 4395, 4396, 4397, 4398, 4399, 4400, 4401, 4402, 4403, 4420, 4432, 4434, 4436, 4438, 4439, 4440, 4441, 4443, 4460, 4462, 4463, 4465, 4473, 4480, 4484, 4485, 4490, 4491, 4492, 4501, 4502, 4503, 4504, 4507, 4508, 4509, 4513, 4514, 4515, 4516, 4517, 4519, 4520, 4521, 4522, 4523, 4524, 4525, 4526, 4528, 4529, 4532, 4534, 4535, 4536, 4540, 4541, 4544, 4550, 4551, 4552, 4553, 4554, 4557, 4558, 4560, 4563, 4575, 4576, 4577, 4579, 4580, 4586, 4588, 4590, 4595, 4596, 4597, 4604, 4605, 4606, 4608, 4609, 4610, 4611, 4612, 4613, 4614, 4615, 4616, 4617, 4618, 4619, 4620, 4621, 4622, 4623, 4624, 4625, 4626, 4628, 4629, 4630, 4631, 4632, 4633, 4634, 4635, 4636, 4637, 4638, 4639, 4640, 4641, 4642, 4643, 4644, 4645, 4646, 4647, 4649, 4656, 4657, 4658, 4661, 4662, 4663, 4664, 4665, 4666, 4670, 4671, 4672, 4673, 4674, 4675, 4676, 4677, 4678, 4679, 4681, 4682, 4683, 4684, 4685, 4686, 4687, 4688, 4689, 4691, 4693, 4694, 4695, 4696, 4697, 4698, 4699, 4700, 4701, 4702, 4703, 4705, 4706, 4707, 4708, 4715, 4720, 4721, 4724, 4725, 4730, 4733, 4734, 4735, 4737, 4741, 4742, 4744, 4745, 4746, 4747, 4748, 4749, 4754, 4755, 4756, 4760, 4766, 4768, 4770, 4780, 4790, 4791, 4792, 4793, 4794, 4795, 4801, 4802, 4803, 4804, 4808, 4809, 4810, 4812, 4815, 4816, 4817, 4818, 4820, 4821, 4822, 4823, 4824, 4825, 4827, 4828, 4830, 4832, 4834, 4836, 4838, 4839, 4841, 4842, 4843, 4844, 4846, 4847, 4848, 4849, 4851, 4852, 4853, 4854, 4855, 4856, 4857, 4858, 4859, 4862, 4863, 4864, 4865, 4868, 4869, 4870, 4876, 4877, 4878, 4879, 4884, 4885, 4886, 4887, 4888, 4889, 4891, 4892, 4893, 4894, 4896, 4898, 4900, 4901, 4902, 4909, 4910, 4912, 4915, 4916, 4920, 4921, 4934, 4950, 4951, 4952, 4953, 4955, 4956, 4957, 4971, 4972, 4973, 4974, 4980, 4985, 4990, 4993, 4994, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5041, 5042, 5043, 5045, 5052, 5053, 5054, 5055, 5056, 5057, 5058, 5059, 5063, 5067, 5068, 5072, 5073, 5075, 5081, 5082, 5089, 5093, 5094, 5096, 5097, 5098, 5099, 5101, 5104, 5105, 5106, 5107, 5108, 5109, 5111, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5121, 5122, 5124, 5130, 5131, 5132, 5134, 5135, 5136, 5137, 5141, 5142, 5143, 5144, 5145, 5146, 5147, 5148, 5151, 5152, 5153, 5154, 5155, 5160, 5161, 5162, 5163, 5164, 5165, 5170, 5171, 5172, 5173, 5174, 5176, 5177, 5178, 5179, 5183, 5184, 5200, 5201, 5202, 5203, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217, 5218, 5221, 5222, 5223, 5224, 5225, 5226, 5227, 5228, 5229, 5230, 5231, 5232, 5235, 5236, 5237, 5238, 5239, 5243, 5244, 5251, 5252, 5253, 5254, 5257, 5258, 5259, 5260, 5261, 5262, 5263, 5264, 5265, 5267, 5268, 5281, 5282, 5283, 5284, 5285, 5286, 5291, 5293, 5299, 5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5314, 5315, 5318, 5319, 5321, 5322, 5323, 5325, 5326, 5327, 5329, 5331, 5333, 5334, 5335, 5336, 5337, 5341, 5342, 5343, 5345, 5346, 5347, 5350, 5353, 5354, 5355, 5357, 5358, 5360, 5363, 5365, 5366, 5371, 5374, 5378, 5379, 5380, 5381, 5382, 5384, 5385, 5387, 5388, 5392, 5393, 5394, 5396, 5397, 5398, 5399, 5401, 5402, 5403, 5404, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5423, 5427, 5428, 5430, 5437, 5440, 5443, 5444, 5445, 5447, 5449, 5450, 5451, 5452, 5453, 5454, 5455, 5457, 5458, 5459, 5460, 5462, 5463, 5464, 5465, 5470, 5472, 5473, 5474, 5475, 5476, 5480, 5484, 5486, 5498, 5499, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5511, 5512, 5514, 5515, 5516, 5517, 5518, 5519, 5521, 5522, 5523, 5525, 5527, 5528, 5529, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5541, 5542, 5544, 5545, 5546, 5547, 5548, 5549, 5550, 5551, 5554, 5555, 5556, 5559, 5560, 5561, 5562, 5563, 5565, 5566, 5567, 5568, 5569, 5570, 5574, 5575, 5576, 5578, 5580, 5582, 5583, 5584, 5585, 5586, 5588, 5589, 5590, 5591, 5593, 5594, 5595, 5596, 5598, 5600, 5601, 5602, 5604, 5605, 5610, 5612, 5614, 5620, 5626, 5627, 5628, 5629, 5630, 5631, 5632, 5633, 5635, 5636, 5637, 5640, 5641, 5642, 5643, 5644, 5645, 5646, 5647, 5648, 5649, 5650, 5651, 5652, 5653, 5680, 5683, 5685, 5687, 5690, 5693, 5694, 5695, 5696, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5718, 5719, 5720, 5721, 5722, 5723, 5724, 5725, 5726, 5727, 5728, 5729, 5730, 5731, 5732, 5733, 5734, 5736, 5741, 5742, 5743, 5745, 5746, 5747, 5748, 5750, 5751, 5752, 5760, 5763, 5770, 5773, 5775, 5776, 5777, 5778, 5779, 5780, 5781, 5782, 5783, 5784, 5785, 5786, 5787, 5788, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5823, 5824, 5825, 5826, 5827, 5828, 5829, 5830, 5831, 5832, 5833, 5834, 5835, 5836, 5837, 5838, 5841, 5843, 5844, 5845, 5847, 5848, 5849, 5851, 5852, 5853, 5854, 5855, 5857, 5858, 5859, 5861, 5862, 5863, 5864, 5865, 5866, 5867, 5868, 5869, 5872, 5873, 5876, 5877, 5878, 5879, 5881, 5884, 5886, 5887, 5888, 5889, 5892, 5893, 5895, 5896, 5899, 5902, 5903, 5904, 5906, 5907, 5908, 5911, 5912, 5913, 5914, 5915, 5916, 5917, 5918, 5919, 5931, 5935, 5936, 5937, 5938, 5939, 5941, 5943, 5947, 5948, 5951, 5952, 5953, 5954, 5955, 5956, 5957, 5960, 5961, 5962, 5963, 5964, 5965, 5966, 5967, 5970, 5977, 5978, 5979, 5981, 5982, 5983, 5984, 5985, 5986, 5987, 5991, 5993, 5994, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6028, 6030, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6044, 6045, 6046, 6047, 6048, 6050, 6051, 6052, 6054, 6055, 6057, 6058, 6059, 6060, 6062, 6063, 6064, 6065, 6067, 6068, 6069, 6070, 6075, 6076, 6078, 6079, 6080, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6094, 6095, 6096, 6098, 6099, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6110, 6120, 6133, 6134, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6146, 6147, 6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6160, 6161, 6165, 6166, 6170, 6171, 6174, 6183, 6184, 6190, 6196, 6200, 6201, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6222, 6223, 6224, 6230, 6238, 6239, 6240, 6249, 6250, 6255, 6259, 6260, 6263, 6264, 6265, 6270, 6272, 6280, 6281, 6282, 6283, 6285, 6290, 6291, 6292, 6293, 6294, 6300, 6301, 6310, 6315, 6320, 6330, 6331, 6339, 6350, 6360, 6361, 6363, 6364, 6365, 6385, 6386, 6387, 6388, 6389, 6390, 6391, 6392, 6393, 6394, 6395, 6396, 6397, 6398, 6399, 6401, 6402, 6403, 6404, 6405, 6407, 6408, 6409, 6410, 6411, 6412, 6413, 6414, 6415, 6416, 6418, 6419, 6421, 6422, 6423, 6425, 6429, 6430, 6431, 6433, 6434, 6435, 6436, 6440, 6443, 6444, 6445, 6446, 6447, 6450, 6452, 6453, 6454, 6455, 6456, 6457, 6458, 6460, 6461, 6462, 6470, 6471, 6472, 6475, 6476, 6480, 6481, 6483, 6484, 6485, 6486, 6487, 6488, 6490, 6493, 6494, 6499, 6501, 6502, 6503, 6504, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6514, 6515, 6516, 6517, 6518, 6520, 6521, 6522, 6523, 6524, 6525, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6538, 6539, 6546, 6547, 6548, 6549, 6570, 6571, 6590, 6591, 6600, 6601, 6610, 6611, 6612, 6613, 6614, 6620, 6622, 6623, 6627, 6628, 6629, 6630, 6631, 6632, 6633, 6636, 6637, 6638, 6639, 6640, 6641, 6642, 6643, 6644, 6645, 6650, 6652, 6653, 6655, 6656, 6657, 6658, 6659, 6670, 6671, 6674, 6680, 6683, 6686, 6687, 6688, 6689, 6690, 6693, 6694, 6697, 6698, 6699, 6700, 6701, 6702, 6703, 6704, 6707, 6708, 6710, 6711, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6721, 6723, 6726, 6727, 6728, 6729, 6730, 6734, 6737, 6740, 6741, 6750, 6751, 6761, 6763, 6770, 6771, 6772, 6773, 6774, 6776, 6777, 6778, 6779, 6781, 6782, 6783, 6784, 6788, 6789, 6790, 6791, 6792, 6793, 6794, 6795, 6796, 6797, 6798, 6799, 6800, 6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810, 6811, 6812, 6813, 6814, 6815, 6817, 6818, 6819, 6820, 6821, 6822, 6823, 6826, 6827, 6828, 6829, 6830, 6831, 6841, 6843, 6844, 6845, 6847, 6848, 6849, 6851, 6852, 6853, 6854, 6855, 6856, 6858, 6859, 6861, 6863, 6866, 6867, 6868, 6869, 6870, 6871, 6872, 6873, 6874, 6875, 6876, 6877, 6878, 6879, 6881, 6882, 6884, 6885, 6886, 6887, 6888, 6891, 6893, 6894, 6895, 6896, 6898, 6899, 6900, 6901, 6902, 6903, 6905, 6906, 6907, 6908, 6909, 6910, 6912, 6913, 6914, 6915, 6916, 6917, 6918, 6919, 6921, 6924, 6926, 6927, 6928, 6929, 6940, 6941, 6942, 6944, 6946, 6947, 6951, 6953, 6957, 6958, 6959, 6961, 6963, 6964, 6966, 6967, 6968, 6969, 6971, 6973, 6975, 6976, 6977, 6978, 6980, 6982, 6983, 6984, 6985, 6986, 6987, 6988, 6991, 6993, 6995, 6996, 6997, 7003, 7004, 7005, 7006, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050, 7051, 7052, 7053, 7054, 7055, 7056, 7057, 7058, 7059, 7066, 7067, 7068, 7069, 7070, 7071, 7072, 7074, 7075, 7078, 7079, 7080, 7081, 7082, 7083, 7088, 7089, 7091, 7092, 7093, 7097, 7098, 7099, 7100, 7101, 7105, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7119, 7120, 7121, 7125, 7126, 7127, 7129, 7130, 7140, 7142, 7150, 7151, 7152, 7153, 7156, 7159, 7160, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7174, 7175, 7176, 7177, 7178, 7180, 7181, 7190, 7194, 7200, 7201, 7203, 7206, 7211, 7212, 7213, 7221, 7223, 7224, 7227, 7228, 7231, 7232, 7234, 7235, 7236, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7250, 7252, 7255, 7256, 7257, 7259, 7260, 7261, 7263, 7264, 7266, 7267, 7268, 7270, 7273, 7274, 7280, 7282, 7284, 7285, 7286, 7287, 7288, 7289, 7290, 7291, 7295, 7298, 7300, 7301, 7302, 7310, 7315, 7316, 7318, 7319, 7320, 7321, 7327, 7329, 7331, 7332, 7333, 7334, 7335, 7336, 7338, 7340, 7341, 7342, 7343, 7345, 7350, 7351, 7353, 7354, 7355, 7356, 7357, 7358, 7361, 7370, 7372, 7374, 7380, 7383, 7384, 7386, 7387, 7388, 7391, 7392, 7393, 7397, 7398, 7399, 7400, 7401, 7402, 7403, 7404, 7405, 7406, 7407, 7408, 7409, 7410, 7411, 7412, 7413, 7414, 7415, 7416, 7417, 7418, 7419, 7420, 7421, 7422, 7424, 7425, 7426, 7427, 7428, 7429, 7430, 7431, 7432, 7433, 7434, 7435, 7436, 7437, 7438, 7439, 7440, 7441, 7442, 7443, 7444, 7445, 7446, 7447, 7448, 7449, 7450, 7451, 7452, 7453, 7454, 7455, 7456, 7457, 7458, 7459, 7462, 7463, 7464, 7465, 7466, 7467, 7468, 7469, 7470, 7471, 7472, 7473, 7474, 7475, 7476, 7477, 7478, 7479, 7480, 7481, 7482, 7483, 7484, 7485, 7486, 7487, 7488, 7489, 7490, 7491, 7492, 7493, 7494, 7495, 7496, 7497, 7498, 7500, 7501, 7502, 7503, 7504, 7505, 7506, 7507, 7508, 7509, 7510, 7511, 7512, 7513, 7514, 7517, 7519, 7520, 7525, 7529, 7530, 7531, 7533, 7540, 7541, 7549, 7550, 7551, 7560, 7562, 7563, 7566, 7570, 7580, 7581, 7583, 7584, 7590, 7591, 7596, 7600, 7601, 7602, 7603, 7604, 7605, 7606, 7607, 7608, 7609, 7610, 7619, 7620, 7622, 7623, 7624, 7629, 7630, 7631, 7632, 7633, 7634, 7650, 7651, 7652, 7653, 7654, 7655, 7656, 7657, 7658, 7660, 7661, 7670, 7671, 7672, 7690, 7691, 7701, 7702, 7703, 7704, 7705, 7707, 7708, 7709, 7710, 7711, 7712, 7713, 7714, 7715, 7716, 7717, 7718, 7724, 7725, 7726, 7729, 7730, 7732, 7733, 7734, 7735, 7736, 7737, 7738, 7739, 7740, 7741, 7742, 7744, 7745, 7746, 7748, 7750, 7751, 7760, 7761, 7770, 7771, 7777, 7790, 7791, 7795, 7796, 7797, 7800, 7801, 7802, 7803, 7804, 7805, 7808, 7810, 7817, 7818, 7819, 7820, 7821, 7822, 7823, 7856, 7860, 7863, 7864, 7869, 7870, 7871, 7873, 7874, 7876, 7877, 7878, 7881, 7882, 7884, 7885, 7890, 7891, 7892, 7893, 7896, 7897, 7898, 7900, 7901, 7902, 7940, 7941, 7944, 7950, 7960, 7970, 7971, 7973, 7979, 7980, 7981, 7982, 7983, 7985, 7986, 7990, 7993, 7994, 7995, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8019, 8020, 8021, 8022, 8023, 8026, 8027, 8028, 8029, 8030, 8031, 8037, 8038, 8041, 8047, 8048, 8049, 8050, 8056, 8057, 8058, 8062, 8063, 8064, 8065, 8070, 8071, 8072, 8073, 8074, 8075, 8076, 8079, 8084, 8086, 8087, 8088, 8089, 8091, 8092, 8093, 8094, 8095, 8096, 8097, 8098, 8099, 8100, 8102, 8103, 8108, 8110, 8114, 8118, 8120, 8128, 8130, 8134, 8135, 8136, 8138, 8140, 8145, 8146, 8149, 8150, 8151, 8157, 8158, 8159, 8160, 8161, 8168, 8170, 8178, 8179, 8181, 8182, 8183, 8184, 8185, 8186, 8187, 8188, 8189, 8190, 8193, 8195, 8196, 8197, 8198, 8200, 8201, 8202, 8203, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8214, 8215, 8218, 8219, 8220, 8226, 8230, 8231, 8232, 8233, 8250, 8251, 8255, 8256, 8260, 8261, 8264, 8266, 8270, 8271, 8273, 8274, 8275, 8276, 8278, 8281, 8283, 8285, 8286, 8287, 8288, 8289, 8290, 8294, 8297, 8298, 8300, 8301, 8305, 8309, 8310, 8311, 8312, 8313, 8314, 8315, 8316, 8317, 8320, 8322, 8323, 8324, 8325, 8326, 8328, 8340, 8352, 8357, 8360, 8361, 8370, 8372, 8373, 8374, 8376, 8377, 8378, 8380, 8382, 8384, 8387, 8388, 8390, 8392, 8393, 8398, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8419, 8426, 8428, 8430, 8432, 8438, 8439, 8445, 8447, 8450, 8455, 8459, 8465, 8469, 8470, 8475, 8480, 8481, 8483, 8484, 8485, 8488, 8489, 8493, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8512, 8513, 8514, 8515, 8516, 8517, 8518, 8520, 8522, 8523, 8530, 8531, 8533, 8534, 8535, 8536, 8539, 8540, 8543, 8546, 8590, 8591, 8601, 8602, 8603, 8604, 8607, 8608, 8609, 8610, 8613, 8614, 8615, 8616, 8617, 8618, 8619, 8622, 8624, 8626, 8630, 8634, 8638, 8640, 8641, 8642, 8643, 8644, 8646, 8647, 8648, 8651, 8652, 8654, 8655, 8656, 8657, 8658, 8659, 8660, 8661, 8663, 8664, 8665, 8666, 8672, 8680, 8681, 8690, 8691, 8700, 8701, 8720, 8723, 8724, 8725, 8730, 8732, 8733, 8735, 8740, 8742, 8743, 8750, 8752, 8753, 8754, 8762, 8764, 8766, 8767, 8770, 8800, 8801, 8802, 8803, 8804, 8805, 8809, 8813, 8820, 8827, 8830, 8842, 8844, 8850, 8851, 8852, 8854, 8860, 8861, 8865, 8870, 8880, 8890, 8891, 8892, 8897, 8900, 8901, 8902, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8920, 8921, 8922, 8960, 8961, 8976, 8977, 8980, 8981, 8985, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9027, 9029, 9030, 9034, 9037, 9038, 9040, 9042, 9043, 9046, 9049, 9050, 9055, 9056, 9057, 9059, 9060, 9062, 9064, 9068, 9069, 9100, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9110, 9118, 9119, 9120, 9128, 9130, 9131, 9132, 9134, 9135, 9136, 9137, 9138, 9140, 9141, 9142, 9143, 9144, 9145, 9146, 9147, 9148, 9149, 9151, 9152, 9153, 9155, 9156, 9159, 9161, 9162, 9163, 9169, 9170, 9171, 9173, 9174, 9175, 9176, 9178, 9180, 9181, 9182, 9184, 9185, 9186, 9187, 9189, 9190, 9192, 9193, 9194, 9195, 9197, 9240, 9251, 9252, 9253, 9254, 9255, 9256, 9257, 9258, 9259, 9260, 9261, 9262, 9263, 9265, 9266, 9267, 9268, 9269, 9270, 9271, 9272, 9273, 9274, 9275, 9276, 9277, 9278, 9279, 9280, 9281, 9282, 9283, 9284, 9285, 9286, 9287, 9288, 9290, 9291, 9292, 9293, 9294, 9296, 9298, 9299, 9300, 9302, 9303, 9304, 9305, 9306, 9307, 9308, 9309, 9310, 9311, 9315, 9316, 9321, 9322, 9325, 9326, 9329, 9334, 9335, 9336, 9350, 9355, 9357, 9358, 9360, 9365, 9370, 9372, 9373, 9376, 9379, 9380, 9381, 9382, 9384, 9385, 9386, 9387, 9388, 9389, 9391, 9392, 9393, 9395, 9402, 9403, 9404, 9405, 9406, 9407, 9408, 9409, 9411, 9414, 9415, 9416, 9419, 9420, 9423, 9424, 9425, 9426, 9427, 9430, 9436, 9439, 9440, 9441, 9442, 9443, 9444, 9445, 9446, 9447, 9448, 9450, 9451, 9453, 9454, 9455, 9456, 9470, 9471, 9475, 9476, 9479, 9480, 9481, 9482, 9483, 9484, 9485, 9486, 9487, 9488, 9489, 9496, 9497, 9498, 9501, 9502, 9503, 9504, 9505, 9506, 9507, 9508, 9509, 9510, 9511, 9512, 9513, 9514, 9515, 9516, 9517, 9518, 9519, 9520, 9521, 9525, 9531, 9532, 9533, 9536, 9540, 9545, 9550, 9580, 9582, 9583, 9584, 9585, 9586, 9587, 9590, 9591, 9593, 9595, 9600, 9601, 9602, 9603, 9609, 9610, 9611, 9612, 9615, 9616, 9620, 9621, 9624, 9650, 9651, 9657, 9664, 9670, 9672, 9690, 9691, 9692, 9700, 9709, 9710, 9711, 9712, 9713, 9714, 9715, 9716, 9717, 9722, 9730, 9735, 9740, 9742, 9750, 9751, 9760, 9763, 9764, 9765, 9768, 9770, 9771, 9772, 9773, 9775, 9782, 9790, 9800, 9802, 9810, 9811, 9815, 9820, 9826, 9840, 9845, 9846, 9900, 9910, 9912, 9914, 9915, 9916, 9917, 9925, 9930, 9935, 9950, 9951, 9960, 9980, 9981, 9982, 9990, 9991".ToCharArray())

		Return n
	End Function


	Public Function HentPoststed(ByRef nrString As Char (), ByRef feilmelding As Success) As Char ()
		Dim nr As Double
		Dim respons As Char ()
		Dim poststedListe As StringReference ()

		nr = CreateNumberFromDecimalString(nrString)
		respons = "".ToCharArray()

		If ErGyldigPostnummer(nrString)
			feilmelding.success = true
			poststedListe = HentPoststedListe()
			respons = poststedListe(nr).stringx
		Else
			feilmelding.success = false
			feilmelding.feilmelding = "Postnummer er ikke gyldig.".ToCharArray()
		End If

		Return respons
	End Function


	Public Function ErGyldigPostnummer(ByRef nrString As Char ()) As Boolean
		Dim nr As Double
		Dim gyldigePostnummer As Boolean ()
		Dim erGyldig As Boolean

		nr = CreateNumberFromDecimalString(nrString)
		gyldigePostnummer = GyldigPostnummertabell()

		If nr > 0.0 And nr < 10000.0 And IsInteger(nr) And nrString.Length = 4.0
			erGyldig = gyldigePostnummer(nr)
		Else
			erGyldig = false
		End If

		Return erGyldig
	End Function


	Public Function GyldigPostnummertabell() As Boolean ()
		Dim i, maxnummer As Double
		Dim postnummerliste As Double ()
		Dim rev As Boolean ()

		postnummerliste = HentPostnummerListe()
		maxnummer = 0.0

		i = 0.0
		While i < postnummerliste.Length
			maxnummer = Max(maxnummer, postnummerliste(i))
			i = i + 1.0
		End While

		rev = New Boolean (maxnummer + 1.0 - 1){}

		i = 0.0
		While i < maxnummer
			rev(i) = false
			i = i + 1.0
		End While

		i = 0.0
		While i < postnummerliste.Length
			rev(postnummerliste(i)) = true
			i = i + 1.0
		End While

		Return rev
	End Function


	Public Function Loess(ByRef xs As Double (), ByRef ys As Double (), bandwidth As Double, robustnessIters As Double, accuracy As Double, ByRef resultXs As NumberArrayReference, ByRef errorMessage As StringReference) As Boolean
		Dim weights As Double ()

		weights = New Double (xs.Length - 1){}
		Call arraysFillNumberArray(weights, 1.0)

		Return Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage)
	End Function


	Public Function Lowess(ByRef xs As Double (), ByRef ys As Double (), ByRef weights As Double (), bandwidth As Double, robustnessIters As Double, accuracy As Double, ByRef resultXs As NumberArrayReference, ByRef errorMessage As StringReference) As Boolean
		Dim res, residuals, sortedResiduals, robustnessWeights, indexes As Double ()
		Dim n, i, k As Double
		Dim x, sumWeights, sumX, sumXSquared, sumY, sumXY, denom As Double
		Dim xk, yk, dist, w, xkw As Double
		Dim meanX, meanY, meanXY, meanXSquared As Double
		Dim alpha, beta As Double
		Dim arg, iter, medianResidual As Double
		Dim bandwidthInterval As Double ()
		Dim ileft, iright, edge As Double
		Dim left, right, nextRight, nextLeft, bandwidthInPoints As Double
		Dim success, done As Boolean

		' Sort arrays
		indexes = QuickSortNumbersWithIndexes(xs)
		Call RearrangeArray(ys, indexes)

		If xs.Length = ys.Length And xs.Length <> 0.0
			n = xs.Length

			If n = 1.0 Or n = 2.0
				If n = 1.0
					res = New Double (1 - 1){}
					res(0) = ys(0)
				Else
					res = New Double (2 - 1){}
					res(0) = ys(0)
					res(1) = ys(1)
				End If

				resultXs.numberArray = res
				success = true
			Else
				bandwidthInPoints = Truncatex(bandwidth*n)

				If bandwidthInPoints >= 2.0
					res = New Double (n - 1){}
					residuals = New Double (n - 1){}

					robustnessWeights = New Double (n - 1){}
					Call arraysFillNumberArray(robustnessWeights, 1.0)

					done = false
					iter = 0.0
					While iter <= robustnessIters And Not done
						bandwidthInterval = New Double (2 - 1){}
						bandwidthInterval(0) = 0.0
						bandwidthInterval(1) = bandwidthInPoints - 1.0

						i = 0.0
						While i < n
							x = xs(i)

							If i > 0.0
								left = bandwidthInterval(0)
								right = bandwidthInterval(1)

								nextRight = FindNextNonZeroElement(weights, right)
								nextLeft = left
								
								While nextRight < xs.Length And xs(nextRight) - xs(i) < xs(i) - xs(nextLeft)
									nextLeft = FindNextNonZeroElement(weights, bandwidthInterval(0))
									bandwidthInterval(0) = nextLeft
									bandwidthInterval(1) = nextRight
									nextRight = FindNextNonZeroElement(weights, nextRight)
								End While
							End If

							ileft = bandwidthInterval(0)
							iright = bandwidthInterval(1)

							If xs(i) - xs(ileft) > xs(iright) - xs(i)
								edge = ileft
							Else
								edge = iright
							End If

							sumWeights = 0.0
							sumX = 0.0
							sumXSquared = 0.0
							sumY = 0.0
							sumXY = 0.0
							denom = Abs(1.0/(xs(edge) - x))
							k = ileft
							While k <= iright
								xk = xs(k)
								yk = ys(k)

								If k < i
									dist = x - xk
								Else
									dist = xk - x
								End If

								w = Tricube(dist*denom)*robustnessWeights(k)*weights(k)
								xkw = xk*w
								sumWeights = sumWeights + w
								sumX = sumX + xkw
								sumXSquared = sumXSquared + xk*xkw
								sumY = sumY + yk*w
								sumXY = sumXY + yk*xkw
								k = k + 1.0
							End While

							meanX = sumX/sumWeights
							meanY = sumY/sumWeights
							meanXY = sumXY/sumWeights
							meanXSquared = sumXSquared/sumWeights

							If Sqrt(Abs(meanXSquared - meanX*meanX)) < accuracy
								beta = 0.0
							Else
								beta = (meanXY - meanX*meanY)/(meanXSquared - meanX*meanX)
							End If

							alpha = meanY - beta*meanX

							res(i) = beta*x + alpha

							residuals(i) = Abs(ys(i) - res(i))
							i = i + 1.0
						End While

						If iter = robustnessIters
							done = true
						End If

						If Not done
							sortedResiduals = arraysCopyNumberArray(residuals)
							Call QuickSortNumbers(sortedResiduals)

							medianResidual = sortedResiduals(n/2.0)

							If Abs(medianResidual) < accuracy
								done = true
							End If

							If Not done
								i = 0.0
								While i < n
									arg = residuals(i)/(6.0*medianResidual)
									If arg >= 1.0
										robustnessWeights(i) = 0.0
									Else
										w = 1.0 - arg*arg
										robustnessWeights(i) = w*w
									End If
									i = i + 1.0
								End While
							End If
						End If
						iter = iter + 1.0
					End While

					resultXs.numberArray = res
					success = true
				Else
					success = false
					errorMessage.stringx = "There must be at least two points.".ToCharArray()
				End If
			End If
		Else
			success = false
			errorMessage.stringx = "There must be equal number of points, and over zero.".ToCharArray()
		End If

		Return success
	End Function


	Public Sub RearrangeArray(ByRef asx As Double (), ByRef indexes As Double ())
		Dim bs As Double ()
		Dim i As Double

		bs = New Double (asx.Length - 1){}

		Call AssignNumberArray(bs, asx)

		i = 0.0
		While i < indexes.Length
			asx(i) = bs(indexes(i))
			i = i + 1.0
		End While

		Erase bs 
	End Sub


	Public Sub AssignNumberArray(ByRef asx As Double (), ByRef bs As Double ())
		Dim i As Double

		i = 0.0
		While i < Min(asx.Length, bs.Length)
			asx(i) = bs(i)
			i = i + 1.0
		End While
	End Sub


	Public Function FindNextNonZeroElement(ByRef arrayx As Double (), offset As Double) As Double
		Dim position As Double
		Dim done As Boolean

		done = false
		position = offset + 1.0
		While position < arrayx.Length And Not done
			If arrayx(position) <> 0.0
				done = true
			End If
			position = position + 1.0
		End While

		Return position
	End Function


	Public Function Tricube(x As Double) As Double
		Dim ax, result As Double

		ax = Abs(x)

		If ax >= 1.0
			result = 0.0
		Else
			result = 1.0 - ax*ax*ax
			result = result*result*result
		End If

		Return result
	End Function


	Public Function CropLineWithinBoundary(ByRef x1Ref As NumberReference, ByRef y1Ref As NumberReference, ByRef x2Ref As NumberReference, ByRef y2Ref As NumberReference, xMin As Double, xMax As Double, yMin As Double, yMax As Double) As Boolean
		Dim x1, y1, x2, y2 As Double
		Dim success, p1In, p2In As Boolean
		Dim dx, dy, f1, f2, f3, f4, f As Double

		x1 = x1Ref.numberValue
		y1 = y1Ref.numberValue
		x2 = x2Ref.numberValue
		y2 = y2Ref.numberValue

		p1In = x1 >= xMin And x1 <= xMax And y1 >= yMin And y1 <= yMax
		p2In = x2 >= xMin And x2 <= xMax And y2 >= yMin And y2 <= yMax

		If p1In And p2In
			success = true
		ElseIf Not p1In And p2In
			dx = x1 - x2
			dy = y1 - y2

			If dx <> 0.0
				f1 = (xMin - x2)/dx
				f2 = (xMax - x2)/dx
			Else
				f1 = 1.0
				f2 = 1.0
			End If
			If dy <> 0.0
				f3 = (yMin - y2)/dy
				f4 = (yMax - y2)/dy
			Else
				f3 = 1.0
				f4 = 1.0
			End If

			If f1 < 0.0
				f1 = 1.0
			End If
			If f2 < 0.0
				f2 = 1.0
			End If
			If f3 < 0.0
				f3 = 1.0
			End If
			If f4 < 0.0
				f4 = 1.0
			End If

			f = Min(f1, Min(f2, Min(f3, f4)))

			x1 = x2 + f*dx
			y1 = y2 + f*dy

			success = true
		ElseIf p1In And Not p2In
			dx = x2 - x1
			dy = y2 - y1

			If dx <> 0.0
				f1 = (xMin - x1)/dx
				f2 = (xMax - x1)/dx
			Else
				f1 = 1.0
				f2 = 1.0
			End If
			If dy <> 0.0
				f3 = (yMin - y1)/dy
				f4 = (yMax - y1)/dy
			Else
				f3 = 1.0
				f4 = 1.0
			End If

			If f1 < 0.0
				f1 = 1.0
			End If
			If f2 < 0.0
				f2 = 1.0
			End If
			If f3 < 0.0
				f3 = 1.0
			End If
			If f4 < 0.0
				f4 = 1.0
			End If

			f = Min(f1, Min(f2, Min(f3, f4)))

			x2 = x1 + f*dx
			y2 = y1 + f*dy

			success = true
		Else
			success = false
		End If

		x1Ref.numberValue = x1
		y1Ref.numberValue = y1
		x2Ref.numberValue = x2
		y2Ref.numberValue = y2

		Return success
	End Function


	Public Function IncrementFromCoordinates(x1 As Double, y1 As Double, x2 As Double, y2 As Double) As Double
		Return (x2 - x1)/(y2 - y1)
	End Function


	Public Function InterceptFromCoordinates(x1 As Double, y1 As Double, x2 As Double, y2 As Double) As Double
		Dim a, b As Double

		a = IncrementFromCoordinates(x1, y1, x2, y2)
		b = y1 - a*x1

		Return b
	End Function


	Public Function Get8HighContrastColors() As RGBA ()
		Dim colors As RGBA ()
		colors = New RGBA (8 - 1){}
		colors(0) = CreateRGBColor(3.0/256.0, 146.0/256.0, 206.0/256.0)
		colors(1) = CreateRGBColor(253.0/256.0, 83.0/256.0, 8.0/256.0)
		colors(2) = CreateRGBColor(102.0/256.0, 176.0/256.0, 50.0/256.0)
		colors(3) = CreateRGBColor(208.0/256.0, 234.0/256.0, 43.0/256.0)
		colors(4) = CreateRGBColor(167.0/256.0, 25.0/256.0, 75.0/256.0)
		colors(5) = CreateRGBColor(254.0/256.0, 254.0/256.0, 51.0/256.0)
		colors(6) = CreateRGBColor(134.0/256.0, 1.0/256.0, 175.0/256.0)
		colors(7) = CreateRGBColor(251.0/256.0, 153.0/256.0, 2.0/256.0)
		Return colors
	End Function


	Public Sub DrawFilledRectangleWithBorder(ByRef image As RGBABitmapImage, x As Double, y As Double, w As Double, h As Double, ByRef borderColor As RGBA, ByRef fillColor As RGBA)
		If h > 0.0 And w > 0.0
			Call DrawFilledRectangle(image, x, y, w, h, fillColor)
			Call DrawRectangle1px(image, x, y, w, h, borderColor)
		End If
	End Sub


	Public Function CreateRGBABitmapImageReference() As RGBABitmapImageReference
		Dim reference As RGBABitmapImageReference

		reference = New RGBABitmapImageReference()
		reference.image = New RGBABitmapImage()
		reference.image.x = New RGBABitmap (0 - 1){}

		Return reference
	End Function


	Public Function RectanglesOverlap(ByRef r1 As Rectangle, ByRef r2 As Rectangle) As Boolean
		Dim overlap As Boolean

		overlap = false

		overlap = overlap Or (r2.x1 >= r1.x1 And r2.x1 <= r1.x2 And r2.y1 >= r1.y1 And r2.y1 <= r1.y2)
		overlap = overlap Or (r2.x2 >= r1.x1 And r2.x2 <= r1.x2 And r2.y1 >= r1.y1 And r2.y1 <= r1.y2)
		overlap = overlap Or (r2.x1 >= r1.x1 And r2.x1 <= r1.x2 And r2.y2 >= r1.y1 And r2.y2 <= r1.y2)
		overlap = overlap Or (r2.x2 >= r1.x1 And r2.x2 <= r1.x2 And r2.y2 >= r1.y1 And r2.y2 <= r1.y2)

		Return overlap
	End Function


	Public Function CreateRectangle(x1 As Double, y1 As Double, x2 As Double, y2 As Double) As Rectangle
		Dim r As Rectangle
		r = New Rectangle()
		r.x1 = x1
		r.y1 = y1
		r.x2 = x2
		r.y2 = y2
		Return r
	End Function


	Public Sub CopyRectangleValues(ByRef rd As Rectangle, ByRef rs As Rectangle)
		rd.x1 = rs.x1
		rd.y1 = rs.y1
		rd.x2 = rs.x2
		rd.y2 = rs.y2
	End Sub


	Public Sub DrawXLabelsForPriority(p As Double, xMin As Double, oy As Double, xMax As Double, xPixelMin As Double, xPixelMax As Double, ByRef nextRectangle As NumberReference, ByRef gridLabelColor As RGBA, ByRef canvas As RGBABitmapImage, ByRef xGridPositions As Double (), ByRef xLabels As StringArrayReference, ByRef xLabelPriorities As NumberArrayReference, ByRef occupied As Rectangle (), textOnBottom As Boolean)
		Dim overlap, currentOverlaps As Boolean
		Dim i, j, x, px, padding As Double
		Dim text As Char ()
		Dim r As Rectangle

		r = New Rectangle()
		padding = 10.0

		overlap = false
		i = 0.0
		While i < xLabels.stringArray.Length
			If xLabelPriorities.numberArray(i) = p

				x = xGridPositions(i)
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
				text = xLabels.stringArray(i).stringx

				r.x1 = Floor(px - GetTextWidth(text)/2.0)
				If textOnBottom
					r.y1 = Floor(oy + 5.0)
				Else
					r.y1 = Floor(oy - 20.0)
				End If
				r.x2 = r.x1 + GetTextWidth(text)
				r.y2 = r.y1 + GetTextHeight(text)

				' Add padding
				r.x1 = r.x1 - padding
				r.y1 = r.y1 - padding
				r.x2 = r.x2 + padding
				r.y2 = r.y2 + padding

				currentOverlaps = false

				j = 0.0
				While j < nextRectangle.numberValue
					currentOverlaps = currentOverlaps Or RectanglesOverlap(r, occupied(j))
					j = j + 1.0
				End While

				If Not currentOverlaps And p = 1.0
					Call DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor)

					Call CopyRectangleValues(occupied(nextRectangle.numberValue), r)
					nextRectangle.numberValue = nextRectangle.numberValue + 1.0
				End If

				overlap = overlap Or currentOverlaps
			End If
			i = i + 1.0
		End While
		If Not overlap And p <> 1.0
			i = 0.0
			While i < xGridPositions.Length
				x = xGridPositions(i)
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)

				If xLabelPriorities.numberArray(i) = p
					text = xLabels.stringArray(i).stringx

					r.x1 = Floor(px - GetTextWidth(text)/2.0)
					If textOnBottom
						r.y1 = Floor(oy + 5.0)
					Else
						r.y1 = Floor(oy - 20.0)
					End If
					r.x2 = r.x1 + GetTextWidth(text)
					r.y2 = r.y1 + GetTextHeight(text)

					Call DrawText(canvas, r.x1, r.y1, text, gridLabelColor)

					Call CopyRectangleValues(occupied(nextRectangle.numberValue), r)
					nextRectangle.numberValue = nextRectangle.numberValue + 1.0
				End If
				i = i + 1.0
			End While
		End If
	End Sub


	Public Sub DrawYLabelsForPriority(p As Double, yMin As Double, ox As Double, yMax As Double, yPixelMin As Double, yPixelMax As Double, ByRef nextRectangle As NumberReference, ByRef gridLabelColor As RGBA, ByRef canvas As RGBABitmapImage, ByRef yGridPositions As Double (), ByRef yLabels As StringArrayReference, ByRef yLabelPriorities As NumberArrayReference, ByRef occupied As Rectangle (), textOnLeft As Boolean)
		Dim overlap, currentOverlaps As Boolean
		Dim i, j, y, py, padding As Double
		Dim text As Char ()
		Dim r As Rectangle

		r = New Rectangle()
		padding = 10.0

		overlap = false
		i = 0.0
		While i < yLabels.stringArray.Length
			If yLabelPriorities.numberArray(i) = p

				y = yGridPositions(i)
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
				text = yLabels.stringArray(i).stringx

				If textOnLeft
					r.x1 = Floor(ox - GetTextWidth(text) - 10.0)
				Else
					r.x1 = Floor(ox + 10.0)
				End If
				r.y1 = Floor(py - 6.0)
				r.x2 = r.x1 + GetTextWidth(text)
				r.y2 = r.y1 + GetTextHeight(text)

				' Add padding
				r.x1 = r.x1 - padding
				r.y1 = r.y1 - padding
				r.x2 = r.x2 + padding
				r.y2 = r.y2 + padding

				currentOverlaps = false

				j = 0.0
				While j < nextRectangle.numberValue
					currentOverlaps = currentOverlaps Or RectanglesOverlap(r, occupied(j))
					j = j + 1.0
				End While

				' Draw labels with priority 1 if they do not overlap anything else.
				If Not currentOverlaps And p = 1.0
					Call DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor)

					Call CopyRectangleValues(occupied(nextRectangle.numberValue), r)
					nextRectangle.numberValue = nextRectangle.numberValue + 1.0
				End If

				overlap = overlap Or currentOverlaps
			End If
			i = i + 1.0
		End While
		If Not overlap And p <> 1.0
			i = 0.0
			While i < yGridPositions.Length
				y = yGridPositions(i)
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)

				If yLabelPriorities.numberArray(i) = p
					text = yLabels.stringArray(i).stringx

					If textOnLeft
						r.x1 = Floor(ox - GetTextWidth(text) - 10.0)
					Else
						r.x1 = Floor(ox + 10.0)
					End If
					r.y1 = Floor(py - 6.0)
					r.x2 = r.x1 + GetTextWidth(text)
					r.y2 = r.y1 + GetTextHeight(text)

					Call DrawText(canvas, r.x1, r.y1, text, gridLabelColor)

					Call CopyRectangleValues(occupied(nextRectangle.numberValue), r)
					nextRectangle.numberValue = nextRectangle.numberValue + 1.0
				End If
				i = i + 1.0
			End While
		End If
	End Sub


	Public Function ComputeGridLinePositions(cMin As Double, cMax As Double, ByRef labels As StringArrayReference, ByRef priorities As NumberArrayReference) As Double ()
		Dim positions As Double ()
		Dim cLength, p, pMin, pMax, pInterval, pNum, i, num, remx, priority, mode As Double

		cLength = cMax - cMin

		p = Floor(Log10(cLength))
		pInterval = 10.0 ^ p
		' gives 10-1 lines for 100-10 diff
		pMin = Ceiling(cMin/pInterval)*pInterval
		pMax = Floor(cMax/pInterval)*pInterval
		pNum = Roundx((pMax - pMin)/pInterval + 1.0)

		mode = 1.0

		If pNum <= 3.0
			p = Floor(Log10(cLength) - 1.0)
			' gives 100-10 lines for 100-10 diff
			pInterval = 10.0 ^ p
			pMin = Ceiling(cMin/pInterval)*pInterval
			pMax = Floor(cMax/pInterval)*pInterval
			pNum = Roundx((pMax - pMin)/pInterval + 1.0)

			mode = 4.0
		ElseIf pNum <= 6.0
			p = Floor(Log10(cLength))
			pInterval = 10.0 ^ p/4.0
			' gives 40-5 lines for 100-10 diff
			pMin = Ceiling(cMin/pInterval)*pInterval
			pMax = Floor(cMax/pInterval)*pInterval
			pNum = Roundx((pMax - pMin)/pInterval + 1.0)

			mode = 3.0
		ElseIf pNum <= 10.0
			p = Floor(Log10(cLength))
			pInterval = 10.0 ^ p/2.0
			' gives 20-3 lines for 100-10 diff
			pMin = Ceiling(cMin/pInterval)*pInterval
			pMax = Floor(cMax/pInterval)*pInterval
			pNum = Roundx((pMax - pMin)/pInterval + 1.0)

			mode = 2.0
		End If

		positions = New Double (pNum - 1){}
		labels.stringArray = New StringReference (pNum - 1){}
		priorities.numberArray = New Double (pNum - 1){}

		i = 0.0
		While i < pNum
			num = pMin + pInterval*i
			positions(i) = num

			' Always print priority 1 labels. Only draw priority 2 if they can all be drawn. Then, only draw priority 3 if they can all be drawn.
			priority = 1.0

			' Prioritize x.25, x.5 and x.75 lower.
			If mode = 2.0 Or mode = 3.0
				remx = Abs(Round(num/10.0 ^ (p - 2.0))) Mod 100.0

				priority = 1.0
				If remx = 50.0
					priority = 2.0
				ElseIf remx = 25.0 Or remx = 75.0
					priority = 3.0
				End If
			End If

			' Prioritize x.1-x.4 and x.6-x.9 lower
			If mode = 4.0
				remx = Abs(Roundx(num/10.0 ^ p)) Mod 10.0

				priority = 1.0
				If remx = 1.0 Or remx = 2.0 Or remx = 3.0 Or remx = 4.0 Or remx = 6.0 Or remx = 7.0 Or remx = 8.0 Or remx = 9.0
					priority = 2.0
				End If
			End If

			' 0 has lowest priority.
			If EpsilonCompare(num, 0.0, 10.0 ^ (p - 5.0))
				priority = 3.0
			End If

			priorities.numberArray(i) = priority

			' The label itself.
			labels.stringArray(i) = New StringReference()
			If p < 0.0
				If mode = 2.0 Or mode = 3.0
					num = RoundToDigits(num, -(p - 1.0))
				Else
					num = RoundToDigits(num, -p)
				End If
			End If
			labels.stringArray(i).stringx = CreateStringDecimalFromNumber(num)
			i = i + 1.0
		End While

		Return positions
	End Function


	Public Function MapYCoordinate(y As Double, yMin As Double, yMax As Double, yPixelMin As Double, yPixelMax As Double) As Double
		Dim yLength, yPixelLength As Double

		yLength = yMax - yMin
		yPixelLength = yPixelMax - yPixelMin

		y = y - yMin
		y = y*yPixelLength/yLength
		y = yPixelLength - y
		y = y + yPixelMin
		Return y
	End Function


	Public Function MapXCoordinate(x As Double, xMin As Double, xMax As Double, xPixelMin As Double, xPixelMax As Double) As Double
		Dim xLength, xPixelLength As Double

		xLength = xMax - xMin
		xPixelLength = xPixelMax - xPixelMin

		x = x - xMin
		x = x*xPixelLength/xLength
		x = x + xPixelMin
		Return x
	End Function


	Public Function MapXCoordinateAutoSettings(x As Double, ByRef image As RGBABitmapImage, ByRef xs As Double ()) As Double
		Return MapXCoordinate(x, GetMinimum(xs), GetMaximum(xs), GetDefaultPaddingPercentage()*ImageWidth(image), (1.0 - GetDefaultPaddingPercentage())*ImageWidth(image))
	End Function


	Public Function MapYCoordinateAutoSettings(y As Double, ByRef image As RGBABitmapImage, ByRef ys As Double ()) As Double
		Return MapYCoordinate(y, GetMinimum(ys), GetMaximum(ys), GetDefaultPaddingPercentage()*ImageHeight(image), (1.0 - GetDefaultPaddingPercentage())*ImageHeight(image))
	End Function


	Public Function MapXCoordinateBasedOnSettings(x As Double, ByRef settings As ScatterPlotSettings) As Double
		Dim xMin, xMax, xPadding, xPixelMin, xPixelMax As Double
		Dim boundaries As Rectangle

		boundaries = New Rectangle()
		Call ComputeBoundariesBasedOnSettings(settings, boundaries)
		xMin = boundaries.x1
		xMax = boundaries.x2

		If settings.autoPadding
			xPadding = Floor(GetDefaultPaddingPercentage()*settings.width)
		Else
			xPadding = settings.xPadding
		End If

		xPixelMin = xPadding
		xPixelMax = settings.width - xPadding

		Return MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
	End Function


	Public Function MapYCoordinateBasedOnSettings(y As Double, ByRef settings As ScatterPlotSettings) As Double
		Dim yMin, yMax, yPadding, yPixelMin, yPixelMax As Double
		Dim boundaries As Rectangle

		boundaries = New Rectangle()
		Call ComputeBoundariesBasedOnSettings(settings, boundaries)
		yMin = boundaries.y1
		yMax = boundaries.y2

		If settings.autoPadding
			yPadding = Floor(GetDefaultPaddingPercentage()*settings.height)
		Else
			yPadding = settings.yPadding
		End If

		yPixelMin = yPadding
		yPixelMax = settings.height - yPadding

		Return MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
	End Function


	Public Function GetDefaultPaddingPercentage() As Double
		Return 0.10
	End Function


	Public Sub DrawText(ByRef canvas As RGBABitmapImage, x As Double, y As Double, ByRef text As Char (), ByRef color As RGBA)
		Dim i, charWidth, spacing As Double

		charWidth = 8.0
		spacing = 2.0

		i = 0.0
		While i < text.Length
			Call DrawAsciiCharacter(canvas, x + i*(charWidth + spacing), y, text(i), color)
			i = i + 1.0
		End While
	End Sub


	Public Sub DrawTextUpwards(ByRef canvas As RGBABitmapImage, x As Double, y As Double, ByRef text As Char (), ByRef color As RGBA)
		Dim buffer, rotated As RGBABitmapImage

		buffer = CreateImage(GetTextWidth(text), GetTextHeight(text), GetTransparent())
		Call DrawText(buffer, 0.0, 0.0, text, color)
		rotated = RotateAntiClockwise90Degrees(buffer)
		Call DrawImageOnImage(canvas, rotated, x, y)
		Call DeleteImage(buffer)
		Call DeleteImage(rotated)
	End Sub


	Public Function GetDefaultScatterPlotSettings() As ScatterPlotSettings
		Dim settings As ScatterPlotSettings

		settings = New ScatterPlotSettings()

		settings.autoBoundaries = true
		settings.xMax = 0.0
		settings.xMin = 0.0
		settings.yMax = 0.0
		settings.yMin = 0.0
		settings.autoPadding = true
		settings.xPadding = 0.0
		settings.yPadding = 0.0
		settings.title = "".ToCharArray()
		settings.xLabel = "".ToCharArray()
		settings.yLabel = "".ToCharArray()
		settings.scatterPlotSeries = New ScatterPlotSeries (0 - 1){}
		settings.showGrid = true
		settings.gridColor = GetGray(0.1)
		settings.xAxisAuto = true
		settings.xAxisTop = false
		settings.xAxisBottom = false
		settings.yAxisAuto = true
		settings.yAxisLeft = false
		settings.yAxisRight = false

		Return settings
	End Function


	Public Function GetDefaultScatterPlotSeriesSettings() As ScatterPlotSeries
		Dim series As ScatterPlotSeries

		series = New ScatterPlotSeries()

		series.linearInterpolation = true
		series.pointType = "pixels".ToCharArray()
		series.lineType = "solid".ToCharArray()
		series.lineThickness = 1.0
		series.xs = New Double (0 - 1){}
		series.ys = New Double (0 - 1){}
		series.color = GetBlack()

		Return series
	End Function


	Public Function DrawScatterPlot(ByRef canvasReference As RGBABitmapImageReference, width As Double, height As Double, ByRef xs As Double (), ByRef ys As Double (), ByRef errorMessage As StringReference) As Boolean
		Dim settings As ScatterPlotSettings
		Dim success As Boolean

		settings = GetDefaultScatterPlotSettings()

		settings.width = width
		settings.height = height
		settings.scatterPlotSeries = New ScatterPlotSeries (1 - 1){}
		settings.scatterPlotSeries(0) = GetDefaultScatterPlotSeriesSettings()
		Erase settings.scatterPlotSeries(0).xs 
		settings.scatterPlotSeries(0).xs = xs
		Erase settings.scatterPlotSeries(0).ys 
		settings.scatterPlotSeries(0).ys = ys

		success = DrawScatterPlotFromSettings(canvasReference, settings, errorMessage)

		Return success
	End Function


	Public Function DrawScatterPlotFromSettings(ByRef canvasReference As RGBABitmapImageReference, ByRef settings As ScatterPlotSettings, ByRef errorMessage As StringReference) As Boolean
		Dim xMin, xMax, yMin, yMax, xLength, yLength, i, x, y, xPrev, yPrev, px, py, pxPrev, pyPrev, originX, originY, p, l, plot As Double
		Dim boundaries As Rectangle
		Dim xPadding, yPadding, originXPixels, originYPixels As Double
		Dim xPixelMin, yPixelMin, xPixelMax, yPixelMax, xLengthPixels, yLengthPixels, axisLabelPadding As Double
		Dim nextRectangle, x1Ref, y1Ref, x2Ref, y2Ref, patternOffset As NumberReference
		Dim prevSet, success As Boolean
		Dim gridLabelColor As RGBA
		Dim canvas As RGBABitmapImage
		Dim xs, ys As Double ()
		Dim linearInterpolation As Boolean
		Dim sp As ScatterPlotSeries
		Dim xGridPositions, yGridPositions As Double ()
		Dim xLabels, yLabels As StringArrayReference
		Dim xLabelPriorities, yLabelPriorities As NumberArrayReference
		Dim occupied As Rectangle ()
		Dim linePattern As Boolean ()
		Dim originXInside, originYInside, textOnLeft, textOnBottom As Boolean
		Dim originTextX, originTextY, originTextXPixels, originTextYPixels, side, yaxis As Double

		canvas = CreateImage(settings.width, settings.height, GetWhite())
		patternOffset = CreateNumberReference(0.0)

		success = ScatterPlotFromSettingsValid(settings, errorMessage)

		If success

			boundaries = New Rectangle()
			Call ComputeBoundariesBasedOnSettings(settings, boundaries)
			xMin = boundaries.x1
			yMin = boundaries.y1
			xMax = boundaries.x2
			yMax = boundaries.y2

			' If zero, set to defaults.
			If xMin - xMax = 0.0
				xMin = 0.0
				xMax = 10.0
			End If

			If yMin - yMax = 0.0
				yMin = 0.0
				yMax = 10.0
			End If

			xLength = xMax - xMin
			yLength = yMax - yMin

			If settings.autoPadding
				xPadding = Floor(GetDefaultPaddingPercentage()*settings.width)
				yPadding = Floor(GetDefaultPaddingPercentage()*settings.height)
			Else
				xPadding = settings.xPadding
				yPadding = settings.yPadding
			End If

			' Draw title
			Call DrawText(canvas, Floor(settings.width/2.0 - GetTextWidth(settings.title)/2.0), Floor(yPadding/3.0), settings.title, GetBlack())

			' Draw grid
			xPixelMin = xPadding
			yPixelMin = yPadding
			xPixelMax = settings.width - xPadding
			yPixelMax = settings.height - yPadding
			xLengthPixels = xPixelMax - xPixelMin
			yLengthPixels = yPixelMax - yPixelMin
			Call DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor)

			gridLabelColor = GetGray(0.5)

			xLabels = New StringArrayReference()
			xLabelPriorities = New NumberArrayReference()
			yLabels = New StringArrayReference()
			yLabelPriorities = New NumberArrayReference()
			xGridPositions = ComputeGridLinePositions(xMin, xMax, xLabels, xLabelPriorities)
			yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities)

			If settings.showGrid
				' X-grid
				i = 0.0
				While i < xGridPositions.Length
					x = xGridPositions(i)
					px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
					Call DrawLine1px(canvas, px, yPixelMin, px, yPixelMax, settings.gridColor)
					i = i + 1.0
				End While

				' Y-grid
				i = 0.0
				While i < yGridPositions.Length
					y = yGridPositions(i)
					py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
					Call DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
					i = i + 1.0
				End While
			End If

			' Compute origin information.
			originYInside = yMin < 0.0 And yMax > 0.0
			originY = 0.0
			If settings.xAxisAuto
				If originYInside
					originY = 0.0
				Else
					originY = yMin
				End If
			Else
				If settings.xAxisTop
					originY = yMax
				End If
				If settings.xAxisBottom
					originY = yMin
				End If
			End If
			originYPixels = MapYCoordinate(originY, yMin, yMax, yPixelMin, yPixelMax)

			originXInside = xMin < 0.0 And xMax > 0.0
			originX = 0.0
			If settings.yAxisAuto
				If originXInside
					originX = 0.0
				Else
					originX = xMin
				End If
			Else
				If settings.yAxisLeft
					originX = xMin
				End If
				If settings.yAxisRight
					originX = xMax
				End If
			End If
			originXPixels = MapXCoordinate(originX, xMin, xMax, xPixelMin, xPixelMax)

			If originYInside
				originTextY = 0.0
			Else
				originTextY = yMin + yLength/2.0
			End If
			originTextYPixels = MapYCoordinate(originTextY, yMin, yMax, yPixelMin, yPixelMax)

			If originXInside
				originTextX = 0.0
			Else
				originTextX = xMin + xLength/2.0
			End If
			originTextXPixels = MapXCoordinate(originTextX, xMin, xMax, xPixelMin, xPixelMax)

			' Labels
			occupied = New Rectangle (xLabels.stringArray.Length + yLabels.stringArray.Length - 1){}
			i = 0.0
			While i < occupied.Length
				occupied(i) = CreateRectangle(0.0, 0.0, 0.0, 0.0)
				i = i + 1.0
			End While
			nextRectangle = CreateNumberReference(0.0)

			' x labels
			i = 1.0
			While i <= 5.0
				textOnBottom = true
				If Not settings.xAxisAuto And settings.xAxisTop
					textOnBottom = false
				End If
				Call DrawXLabelsForPriority(i, xMin, originYPixels, xMax, xPixelMin, xPixelMax, nextRectangle, gridLabelColor, canvas, xGridPositions, xLabels, xLabelPriorities, occupied, textOnBottom)
				i = i + 1.0
			End While

			' y labels
			i = 1.0
			While i <= 5.0
				textOnLeft = true
				If Not settings.yAxisAuto And settings.yAxisRight
					textOnLeft = false
				End If
				Call DrawYLabelsForPriority(i, yMin, originXPixels, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, textOnLeft)
				i = i + 1.0
			End While

			' Draw origin line axis titles.
			axisLabelPadding = 20.0

			' x origin line
			If originYInside
				Call DrawLine1px(canvas, Roundx(xPixelMin), Roundx(originYPixels), Roundx(xPixelMax), Roundx(originYPixels), GetBlack())
			End If

			' y origin line
			If originXInside
				Call DrawLine1px(canvas, Roundx(originXPixels), Roundx(yPixelMin), Roundx(originXPixels), Roundx(yPixelMax), GetBlack())
			End If

			' Draw origin axis titles.
			Call DrawTextUpwards(canvas, 10.0, Floor(originTextYPixels - GetTextWidth(settings.yLabel)/2.0), settings.yLabel, GetBlack())
			Call DrawText(canvas, Floor(originTextXPixels - GetTextWidth(settings.xLabel)/2.0), yPixelMax + axisLabelPadding, settings.xLabel, GetBlack())

			' X-grid-markers
			i = 0.0
			While i < xGridPositions.Length
				x = xGridPositions(i)
				px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
				p = xLabelPriorities.numberArray(i)
				l = 1.0
				If p = 1.0
					l = 8.0
				ElseIf p = 2.0
					l = 3.0
				End If
				side = -1.0
				If Not settings.xAxisAuto And settings.xAxisTop
					side = 1.0
				End If
				Call DrawLine1px(canvas, px, originYPixels, px, originYPixels + side*l, GetBlack())
				i = i + 1.0
			End While

			' Y-grid-markers
			i = 0.0
			While i < yGridPositions.Length
				y = yGridPositions(i)
				py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
				p = yLabelPriorities.numberArray(i)
				l = 1.0
				If p = 1.0
					l = 8.0
				ElseIf p = 2.0
					l = 3.0
				End If
				side = 1.0
				If Not settings.yAxisAuto And settings.yAxisRight
					side = -1.0
				End If
				Call DrawLine1px(canvas, originXPixels, py, originXPixels + side*l, py, GetBlack())
				i = i + 1.0
			End While

			' Draw points
			plot = 0.0
			While plot < settings.scatterPlotSeries.Length
				sp = settings.scatterPlotSeries(plot)

				xs = sp.xs
				ys = sp.ys
				linearInterpolation = sp.linearInterpolation

				x1Ref = New NumberReference()
				y1Ref = New NumberReference()
				x2Ref = New NumberReference()
				y2Ref = New NumberReference()
				If linearInterpolation
					prevSet = false
					xPrev = 0.0
					yPrev = 0.0
					i = 0.0
					While i < xs.Length
						x = xs(i)
						y = ys(i)

						If prevSet
							x1Ref.numberValue = xPrev
							y1Ref.numberValue = yPrev
							x2Ref.numberValue = x
							y2Ref.numberValue = y

							success = CropLineWithinBoundary(x1Ref, y1Ref, x2Ref, y2Ref, xMin, xMax, yMin, yMax)

							If success
								pxPrev = Floor(MapXCoordinate(x1Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax))
								pyPrev = Floor(MapYCoordinate(y1Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax))
								px = Floor(MapXCoordinate(x2Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax))
								py = Floor(MapYCoordinate(y2Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax))

								If arraysStringsEqual(sp.lineType, "solid".ToCharArray()) And sp.lineThickness = 1.0
									Call DrawLine1px(canvas, pxPrev, pyPrev, px, py, sp.color)
								ElseIf arraysStringsEqual(sp.lineType, "solid".ToCharArray())
									Call DrawLine(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, sp.color)
								ElseIf arraysStringsEqual(sp.lineType, "dashed".ToCharArray())
									linePattern = GetLinePattern1()
									Call DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
								ElseIf arraysStringsEqual(sp.lineType, "dotted".ToCharArray())
									linePattern = GetLinePattern2()
									Call DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
								ElseIf arraysStringsEqual(sp.lineType, "dotdash".ToCharArray())
									linePattern = GetLinePattern3()
									Call DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
								ElseIf arraysStringsEqual(sp.lineType, "longdash".ToCharArray())
									linePattern = GetLinePattern4()
									Call DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
								ElseIf arraysStringsEqual(sp.lineType, "twodash".ToCharArray())
									linePattern = GetLinePattern5()
									Call DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
								End If
							End If
						End If

						prevSet = true
						xPrev = x
						yPrev = y
						i = i + 1.0
					End While
				Else
					i = 0.0
					While i < xs.Length
						x = xs(i)
						y = ys(i)

						If x > xMin And x < xMax And y > yMin And y < yMax

							x = Floor(MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax))
							y = Floor(MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax))

							If arraysStringsEqual(sp.pointType, "crosses".ToCharArray())
								Call DrawPixel(canvas, x, y, sp.color)
								Call DrawPixel(canvas, x + 1.0, y, sp.color)
								Call DrawPixel(canvas, x + 2.0, y, sp.color)
								Call DrawPixel(canvas, x - 1.0, y, sp.color)
								Call DrawPixel(canvas, x - 2.0, y, sp.color)
								Call DrawPixel(canvas, x, y + 1.0, sp.color)
								Call DrawPixel(canvas, x, y + 2.0, sp.color)
								Call DrawPixel(canvas, x, y - 1.0, sp.color)
								Call DrawPixel(canvas, x, y - 2.0, sp.color)
							ElseIf arraysStringsEqual(sp.pointType, "circles".ToCharArray())
								Call DrawCircle(canvas, x, y, 3.0, sp.color)
							ElseIf arraysStringsEqual(sp.pointType, "dots".ToCharArray())
								Call DrawFilledCircle(canvas, x, y, 3.0, sp.color)
							ElseIf arraysStringsEqual(sp.pointType, "triangles".ToCharArray())
								Call DrawTriangle(canvas, x, y, 3.0, sp.color)
							ElseIf arraysStringsEqual(sp.pointType, "filled triangles".ToCharArray())
								Call DrawFilledTriangle(canvas, x, y, 3.0, sp.color)
							ElseIf arraysStringsEqual(sp.pointType, "pixels".ToCharArray())
								Call DrawPixel(canvas, x, y, sp.color)
							ElseIf arraysStringsEqual(sp.pointType, "dotlinetoxaxis".ToCharArray())
								Call DrawFilledCircle(canvas, x, y, 3.0, sp.color)
								yaxis = Floor(MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax))
								yaxis = Min(Max(yaxis, yPixelMin), yPixelMax)
								Call DrawLine(canvas, x, y, x, yaxis, sp.lineThickness, sp.color)
							End If
						End If
						i = i + 1.0
					End While
				End If
				plot = plot + 1.0
			End While

			canvasReference.image = canvas
		End If

		Return success
	End Function


	Public Sub ComputeBoundariesBasedOnSettings(ByRef settings As ScatterPlotSettings, ByRef boundaries As Rectangle)
		Dim sp As ScatterPlotSeries
		Dim plot, xMin, xMax, yMin, yMax As Double

		If settings.scatterPlotSeries.Length >= 1.0
			xMin = GetMinimum(settings.scatterPlotSeries(0).xs)*1.05
			xMax = GetMaximum(settings.scatterPlotSeries(0).xs)*1.05
			yMin = GetMinimum(settings.scatterPlotSeries(0).ys)*1.05
			yMax = GetMaximum(settings.scatterPlotSeries(0).ys)*1.05
		Else
			xMin = -10.0
			xMax = 10.0
			yMin = -10.0
			yMax = 10.0
		End If

		If Not settings.autoBoundaries
			xMin = settings.xMin
			xMax = settings.xMax
			yMin = settings.yMin
			yMax = settings.yMax
		Else
			plot = 1.0
			While plot < settings.scatterPlotSeries.Length
				sp = settings.scatterPlotSeries(plot)

				xMin = Min(xMin, GetMinimum(sp.xs))
				xMax = Max(xMax, GetMaximum(sp.xs))
				yMin = Min(yMin, GetMinimum(sp.ys))
				yMax = Max(yMax, GetMaximum(sp.ys))
				plot = plot + 1.0
			End While
		End If

		boundaries.x1 = xMin
		boundaries.y1 = yMin
		boundaries.x2 = xMax
		boundaries.y2 = yMax
	End Sub


	Public Function ScatterPlotFromSettingsValid(ByRef settings As ScatterPlotSettings, ByRef errorMessage As StringReference) As Boolean
		Dim success, found As Boolean
		Dim series As ScatterPlotSeries
		Dim i As Double

		success = true

		' Check axis placement.
		If Not settings.xAxisAuto
			If settings.xAxisTop And settings.xAxisBottom
				success = false
				errorMessage.stringx = "x-axis not automatic and configured to be both on top and on bottom.".ToCharArray()
			End If
			If Not settings.xAxisTop And Not settings.xAxisBottom
				success = false
				errorMessage.stringx = "x-axis not automatic and configured to be neither on top nor on bottom.".ToCharArray()
			End If
		End If

		If Not settings.yAxisAuto
			If settings.yAxisLeft And settings.yAxisRight
				success = false
				errorMessage.stringx = "y-axis not automatic and configured to be both on top and on bottom.".ToCharArray()
			End If
			If Not settings.yAxisLeft And Not settings.yAxisRight
				success = false
				errorMessage.stringx = "y-axis not automatic and configured to be neither on top nor on bottom.".ToCharArray()
			End If
		End If

		' Check series lengths.
		i = 0.0
		While i < settings.scatterPlotSeries.Length
			series = settings.scatterPlotSeries(i)
			If series.xs.Length <> series.ys.Length
				success = false
				errorMessage.stringx = "x and y series must be of the same length.".ToCharArray()
			End If
			If series.xs.Length = 0.0
				success = false
				errorMessage.stringx = "There must be data in the series to be plotted.".ToCharArray()
			End If
			If series.linearInterpolation And series.xs.Length = 1.0
				success = false
				errorMessage.stringx = "Linear interpolation requires at least two data points to be plotted.".ToCharArray()
			End If
			i = i + 1.0
		End While

		' Check bounds.
		If Not settings.autoBoundaries
			If settings.xMin >= settings.xMax
				success = false
				errorMessage.stringx = "x min is higher than or equal to x max.".ToCharArray()
			End If
			If settings.yMin >= settings.yMax
				success = false
				errorMessage.stringx = "y min is higher than or equal to y max.".ToCharArray()
			End If
		End If

		' Check padding.
		If Not settings.autoPadding
			If 2.0*settings.xPadding >= settings.width
				success = false
				errorMessage.stringx = "The x padding is more then the width.".ToCharArray()
			End If
			If 2.0*settings.yPadding >= settings.height
				success = false
				errorMessage.stringx = "The y padding is more then the height.".ToCharArray()
			End If
		End If

		' Check width and height.
		If settings.width < 0.0
			success = false
			errorMessage.stringx = "The width is less than 0.".ToCharArray()
		End If
		If settings.height < 0.0
			success = false
			errorMessage.stringx = "The height is less than 0.".ToCharArray()
		End If

		' Check point types.
		i = 0.0
		While i < settings.scatterPlotSeries.Length
			series = settings.scatterPlotSeries(i)

			If series.lineThickness < 0.0
				success = false
				errorMessage.stringx = "The line thickness is less than 0.".ToCharArray()
			End If

			If Not series.linearInterpolation
				' Point type.
				found = false
				If arraysStringsEqual(series.pointType, "crosses".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.pointType, "circles".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.pointType, "dots".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.pointType, "triangles".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.pointType, "filled triangles".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.pointType, "pixels".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.pointType, "dotlinetoxaxis".ToCharArray())
					found = true
				End If
				If Not found
					success = false
					errorMessage.stringx = "The point type is unknown.".ToCharArray()
				End If
			Else
				' Line type.
				found = false
				If arraysStringsEqual(series.lineType, "solid".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.lineType, "dashed".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.lineType, "dotted".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.lineType, "dotdash".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.lineType, "longdash".ToCharArray())
					found = true
				ElseIf arraysStringsEqual(series.lineType, "twodash".ToCharArray())
					found = true
				End If

				If Not found
					success = false
					errorMessage.stringx = "The line type is unknown.".ToCharArray()
				End If
			End If
			i = i + 1.0
		End While

		Return success
	End Function


	Public Function GetDefaultBarPlotSettings() As BarPlotSettings
		Dim settings As BarPlotSettings

		settings = New BarPlotSettings()

		settings.width = 800.0
		settings.height = 600.0
		settings.autoBoundaries = true
		settings.yMax = 0.0
		settings.yMin = 0.0
		settings.autoPadding = true
		settings.xPadding = 0.0
		settings.yPadding = 0.0
		settings.title = "".ToCharArray()
		settings.yLabel = "".ToCharArray()
		settings.barPlotSeries = New BarPlotSeries (0 - 1){}
		settings.showGrid = true
		settings.gridColor = GetGray(0.1)
		settings.autoColor = true
		settings.grayscaleAutoColor = false
		settings.autoSpacing = true
		settings.groupSeparation = 0.0
		settings.barSeparation = 0.0
		settings.autoLabels = true
		settings.xLabels = New StringReference (0 - 1){}
		'settings.autoLabels = false;
		'        settings.xLabels = new StringReference [5];
		'        settings.xLabels[0] = CreateStringReference("may 20".toCharArray());
		'        settings.xLabels[1] = CreateStringReference("jun 20".toCharArray());
		'        settings.xLabels[2] = CreateStringReference("jul 20".toCharArray());
		'        settings.xLabels[3] = CreateStringReference("aug 20".toCharArray());
		'        settings.xLabels[4] = CreateStringReference("sep 20".toCharArray());
		settings.barBorder = false

		Return settings
	End Function


	Public Function GetDefaultBarPlotSeriesSettings() As BarPlotSeries
		Dim series As BarPlotSeries

		series = New BarPlotSeries()

		series.ys = New Double (0 - 1){}
		series.color = GetBlack()

		Return series
	End Function


	Public Function DrawBarPlotNoErrorCheck(width As Double, height As Double, ByRef ys As Double ()) As RGBABitmapImage
		Dim errorMessage As StringReference
		Dim success As Boolean
		Dim canvasReference As RGBABitmapImageReference

		errorMessage = New StringReference()
		canvasReference = CreateRGBABitmapImageReference()

		success = DrawBarPlot(canvasReference, width, height, ys, errorMessage)

		Call FreeStringReference(errorMessage)

		Return canvasReference.image
	End Function


	Public Function DrawBarPlot(ByRef canvasReference As RGBABitmapImageReference, width As Double, height As Double, ByRef ys As Double (), ByRef errorMessage As StringReference) As Boolean
		Dim settings As BarPlotSettings
		Dim success As Boolean

		errorMessage = New StringReference()
		settings = GetDefaultBarPlotSettings()

		settings.barPlotSeries = New BarPlotSeries (1 - 1){}
		settings.barPlotSeries(0) = GetDefaultBarPlotSeriesSettings()
		Erase settings.barPlotSeries(0).ys 
		settings.barPlotSeries(0).ys = ys
		settings.width = width
		settings.height = height

		success = DrawBarPlotFromSettings(canvasReference, settings, errorMessage)

		Return success
	End Function


	Public Function DrawBarPlotFromSettings(ByRef canvasReference As RGBABitmapImageReference, ByRef settings As BarPlotSettings, ByRef errorMessage As StringReference) As Boolean
		Dim xPadding, yPadding As Double
		Dim xPixelMin, yPixelMin, yPixelMax, xPixelMax As Double
		Dim xLengthPixels, yLengthPixels As Double
		Dim s, n, y, x, w, h, yMin, yMax, b, i, py, yValue As Double
		Dim colors As RGBA ()
		Dim ys, yGridPositions As Double ()
		Dim yTop, yBottom, ss, bs As Double
		Dim groupSeparation, barSeparation, barWidth, textwidth As Double
		Dim yLabels As StringArrayReference
		Dim yLabelPriorities As NumberArrayReference
		Dim occupied As Rectangle ()
		Dim nextRectangle As NumberReference
		Dim gridLabelColor, barColor As RGBA
		Dim label As Char ()
		Dim success As Boolean
		Dim canvas As RGBABitmapImage

		success = BarPlotSettingsIsValid(settings, errorMessage)

		If success
			canvas = CreateImage(settings.width, settings.height, GetWhite())

			ss = settings.barPlotSeries.Length
			gridLabelColor = GetGray(0.5)

			' padding
			If settings.autoPadding
				xPadding = Floor(GetDefaultPaddingPercentage()*ImageWidth(canvas))
				yPadding = Floor(GetDefaultPaddingPercentage()*ImageHeight(canvas))
			Else
				xPadding = settings.xPadding
				yPadding = settings.yPadding
			End If

			' Draw title
			Call DrawText(canvas, Floor(ImageWidth(canvas)/2.0 - GetTextWidth(settings.title)/2.0), Floor(yPadding/3.0), settings.title, GetBlack())
			Call DrawTextUpwards(canvas, 10.0, Floor(ImageHeight(canvas)/2.0 - GetTextWidth(settings.yLabel)/2.0), settings.yLabel, GetBlack())

			' min and max
			If settings.autoBoundaries
				If ss >= 1.0
					yMax = GetMaximum(settings.barPlotSeries(0).ys)*1.05
					yMin = Min(0.0, GetMinimum(settings.barPlotSeries(0).ys))*1.05

					s = 0.0
					While s < ss
						yMax = Max(yMax, GetMaximum(settings.barPlotSeries(s).ys))
						yMin = Min(yMin, GetMinimum(settings.barPlotSeries(s).ys))
						s = s + 1.0
					End While
				Else
					yMax = 10.0
					yMin = 0.0
				End If
			Else
				yMin = settings.yMin
				yMax = settings.yMax
			End If

			' boundaries
			xPixelMin = xPadding
			yPixelMin = yPadding
			xPixelMax = ImageWidth(canvas) - xPadding
			yPixelMax = ImageHeight(canvas) - yPadding
			xLengthPixels = xPixelMax - xPixelMin
			yLengthPixels = yPixelMax - yPixelMin

			' Draw boundary.
			Call DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor)

			' Draw grid lines.
			yLabels = New StringArrayReference()
			yLabelPriorities = New NumberArrayReference()
			yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities)

			If settings.showGrid
				' Y-grid
				i = 0.0
				While i < yGridPositions.Length
					y = yGridPositions(i)
					py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
					Call DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
					i = i + 1.0
				End While
			End If

			' Draw origin.
			If yMin < 0.0 And yMax > 0.0
				py = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)
				Call DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
			End If

			' Labels
			occupied = New Rectangle (yLabels.stringArray.Length - 1){}
			i = 0.0
			While i < occupied.Length
				occupied(i) = CreateRectangle(0.0, 0.0, 0.0, 0.0)
				i = i + 1.0
			End While
			nextRectangle = CreateNumberReference(0.0)

			i = 1.0
			While i <= 5.0
				Call DrawYLabelsForPriority(i, yMin, xPixelMin, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, true)
				i = i + 1.0
			End While

			' Draw bars.
			If settings.autoColor
				If Not settings.grayscaleAutoColor
					colors = Get8HighContrastColors()
				Else
					colors = New RGBA (ss - 1){}
					If ss > 1.0
						i = 0.0
						While i < ss
							colors(i) = GetGray(0.7 - (i/ss)*0.7)
							i = i + 1.0
						End While
					Else
						colors(0) = GetGray(0.5)
					End If
				End If
			Else
				colors = New RGBA (0 - 1){}
			End If

			' distances
			bs = settings.barPlotSeries(0).ys.Length

			If settings.autoSpacing
				groupSeparation = ImageWidth(canvas)*0.05
				barSeparation = ImageWidth(canvas)*0.005
			Else
				groupSeparation = settings.groupSeparation
				barSeparation = settings.barSeparation
			End If

			barWidth = (xLengthPixels - groupSeparation*(bs - 1.0) - barSeparation*(bs*(ss - 1.0)))/(bs*ss)

			' Draw bars.
			b = 0.0
			n = 0.0
			While n < bs
				s = 0.0
				While s < ss
					ys = settings.barPlotSeries(s).ys

					yValue = ys(n)

					yBottom = MapYCoordinate(yValue, yMin, yMax, yPixelMin, yPixelMax)
					yTop = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)

					x = xPixelMin + n*(groupSeparation + ss*barWidth) + s*(barWidth) + b*barSeparation
					w = barWidth

					If yValue >= 0.0
						y = yBottom
						h = yTop - y
					Else
						y = yTop
						h = yBottom - yTop
					End If

					' Cut at boundaries.
					If y < yPixelMin And y + h > yPixelMax
						y = yPixelMin
						h = yPixelMax - yPixelMin
					ElseIf y < yPixelMin
						y = yPixelMin
						If yValue >= 0.0
							h = yTop - y
						Else
							h = yBottom - y
						End If
					ElseIf y + h > yPixelMax
						h = yPixelMax - y
					End If

					' Get color
					If settings.autoColor
						barColor = colors(s)
					Else
						barColor = settings.barPlotSeries(s).color
					End If

					' Draw
					If settings.barBorder
						Call DrawFilledRectangleWithBorder(canvas, Roundx(x), Roundx(y), Roundx(w), Roundx(h), GetBlack(), barColor)
					Else
						Call DrawFilledRectangle(canvas, Roundx(x), Roundx(y), Roundx(w), Roundx(h), barColor)
					End If

					b = b + 1.0
					s = s + 1.0
				End While
				b = b - 1.0
				n = n + 1.0
			End While

			' x-labels
			n = 0.0
			While n < bs
				If settings.autoLabels
					label = CreateStringDecimalFromNumber(n + 1.0)
				Else
					label = settings.xLabels(n).stringx
				End If

				textwidth = GetTextWidth(label)

				x = xPixelMin + (n + 0.5)*(ss*barWidth + (ss - 1.0)*barSeparation) + n*groupSeparation - textwidth/2.0

				Call DrawText(canvas, Floor(x), ImageHeight(canvas) - yPadding + 20.0, label, gridLabelColor)

				b = b + 1.0
				n = n + 1.0
			End While

			canvasReference.image = canvas
		End If

		Return success
	End Function


	Public Function BarPlotSettingsIsValid(ByRef settings As BarPlotSettings, ByRef errorMessage As StringReference) As Boolean
		Dim success, lengthSet As Boolean
		Dim series As BarPlotSeries
		Dim i, length As Double

		success = true

		' Check series lengths.
		lengthSet = false
		length = 0.0
		i = 0.0
		While i < settings.barPlotSeries.Length
			series = settings.barPlotSeries(i)

			If Not lengthSet
				length = series.ys.Length
				lengthSet = true
			ElseIf length <> series.ys.Length
				success = false
				errorMessage.stringx = "The number of data points must be equal for all series.".ToCharArray()
			End If
			i = i + 1.0
		End While

		' Check bounds.
		If Not settings.autoBoundaries
			If settings.yMin >= settings.yMax
				success = false
				errorMessage.stringx = "Minimum y lower than maximum y.".ToCharArray()
			End If
		End If

		' Check padding.
		If Not settings.autoPadding
			If 2.0*settings.xPadding >= settings.width
				success = false
				errorMessage.stringx = "Double the horizontal padding is larger than or equal to the width.".ToCharArray()
			End If
			If 2.0*settings.yPadding >= settings.height
				success = false
				errorMessage.stringx = "Double the vertical padding is larger than or equal to the height.".ToCharArray()
			End If
		End If

		' Check width and height.
		If settings.width < 0.0
			success = false
			errorMessage.stringx = "Width lower than zero.".ToCharArray()
		End If
		If settings.height < 0.0
			success = false
			errorMessage.stringx = "Height lower than zero.".ToCharArray()
		End If

		' Check spacing
		If Not settings.autoSpacing
			If settings.groupSeparation < 0.0
				success = false
				errorMessage.stringx = "Group separation lower than zero.".ToCharArray()
			End If
			If settings.barSeparation < 0.0
				success = false
				errorMessage.stringx = "Bar separation lower than zero.".ToCharArray()
			End If
		End If

		Return success
	End Function


	Public Function GetMinimum(ByRef data As Double ()) As Double
		Dim i, minimum As Double

		minimum = data(0)
		i = 0.0
		While i < data.Length
			minimum = Min(minimum, data(i))
			i = i + 1.0
		End While

		Return minimum
	End Function


	Public Function GetMaximum(ByRef data As Double ()) As Double
		Dim i, maximum As Double

		maximum = data(0)
		i = 0.0
		While i < data.Length
			maximum = Max(maximum, data(i))
			i = i + 1.0
		End While

		Return maximum
	End Function


	Public Function BinomialDensity(x As Double, size As Double, p As Double) As Double
		Return Combinations(size, x)*p ^ x*(1.0 - p) ^ (size - x)
	End Function


	Public Function BinomialRandom(ByRef prg As PseudorandomGenerator, n As Double, size As Double, p As Double) As Double ()
		Dim ns As Double ()
		Dim i, j, nr, c As Double

		ns = New Double (n - 1){}

		i = 0.0
		While i < n
			c = 0.0

			j = 0.0
			While j < size
				nr = PseudorandomNextNumber(prg)
				If nr < p
					c = c + 1.0
				End If
				j = j + 1.0
			End While

			ns(i) = c
			i = i + 1.0
		End While

		Return ns
	End Function


	Public Function BinomialProbability(x As Double, size As Double, prob As Double) As Double
		Dim sum, i As Double

		sum = 0.0
		i = 0.0
		While i <= x
			sum = sum + BinomialDensity(i, size, prob)
			i = i + 1.0
		End While

		Return sum
	End Function


	Public Function BinomialQuantile(u As Double, size As Double, prob As Double) As Double
		Dim sum, i As Double
		Dim done As Boolean

		sum = 0.0
		done = false
		i = 0.0
		While i <= size And Not done
			sum = sum + BinomialDensity(i, size, prob)
			If sum > u
				done = true
			End If
			i = i + 1.0
		End While

		Return i - 1.0
	End Function


	Public Function NormalDensity(x As Double, mu As Double, sd As Double) As Double
		Return 1.0/(Sqrt(2.0*Pi)*sd)*Exp(-((x - mu) ^ 2.0/(2.0*sd ^ 2.0)))
	End Function


	Public Function NormalRandom(ByRef prg As PseudorandomGenerator, n As Double, mean As Double, sd As Double) As Double ()
		Dim ns As Double ()
		Dim i, nr As Double

		ns = New Double (n - 1){}

		i = 0.0
		While i < n
			nr = PseudorandomNextNumber(prg)
			ns(i) = NormalQuantile(nr, mean, sd)
			i = i + 1.0
		End While

		Return ns
	End Function


	Public Function NormalProbability(q As Double, mean As Double, sd As Double) As Double
		Return NormalProbabilityMethod2(q, mean, sd)
	End Function


	Public Function NormalProbabilityMethod1(q As Double, mean As Double, sd As Double) As Double
		Dim p, z, qz, c0, c1, c2, c3, c4, c5 As Double

		q = (q - mean)/sd

		If q < 0.0
			p = 1.0 - NormalProbabilityMethod1(-q, 0.0, 1.0)
		Else
			c0 = 0.2316419
			c1 = 0.319381530
			c2 = -0.356563782
			c3 = 1.781477937
			c4 = -1.821255978
			c5 = 1.330274429

			z = 1.0/(1.0 + c0*q)
			qz = z*(c1 + z*(c2 + z*(c3 + z*(c4 + c5*z))))

			p = 1.0 - qz*NormalDensity(q, 0.0, 1.0)
		End If

		Return p
	End Function


	Public Function NormalProbabilityMethod2(x As Double, mean As Double, sd As Double) As Double
		Return 1.0/2.0*(1.0 + Errorx((x - mean)/(sd*Sqrt(2.0))))
	End Function


	Public Function NormalQuantile(u As Double, mean As Double, sd As Double) As Double
		Return NormalQuantileMethod1(u, mean, sd)
	End Function


	Public Function NormalQuantileMethod1(u As Double, mean As Double, sd As Double) As Double
		Dim q, z, q1z, q2z, c0, c1, c2, c3, c4, c5, c6, c7, c8 As Double

		If u < 1.0/2.0
			q = -NormalQuantile(1.0 - u, 0.0, 1.0)
		Else
			z = Sqrt(-2.0*Log(1.0 - u))
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
			q = z + q1z/q2z
		End If

		q = mean + q*sd

		Return q
	End Function


	Public Function NormalQuantileMethod2(u As Double, mean As Double, sd As Double) As Double
		Return mean + sd*Sqrt(2.0)*ErrorInverse(2.0*u - 1.0)
	End Function


	Public Function PossionMass(k As Double, lambda As Double) As Double
		Return lambda ^ k*Exp(-lambda)/Factorial(k)
	End Function


	Public Function PoissonRandom(ByRef prg As PseudorandomGenerator, n As Double, lambda As Double) As Double ()
		Dim ns As Double ()
		Dim i, nr As Double

		ns = New Double (n - 1){}

		i = 0.0
		While i < n
			nr = PseudorandomNextNumber(prg)
			ns(i) = PoissonQuantile(nr, lambda)
			i = i + 1.0
		End While

		Return ns
	End Function


	Public Function PoissonQuantile(p As Double, lambda As Double) As Double
		Dim sum, i As Double
		Dim done As Boolean

		sum = 0.0
		done = false
		i = 0.0
		While i <= lambda And Not done
			sum = sum + PossionMass(i, lambda)
			If sum > p
				done = true
			End If
			i = i + 1.0
		End While

		Return i - 1.0
	End Function


	Public Function PoissonProbability(k As Double, lambda As Double) As Double
		Dim i, t As Double

		t = 0.0
		i = 0.0
		While i <= k
			t = t + lambda ^ i/Factorial(i)
			i = i + 1.0
		End While

		Return t/Exp(lambda)
	End Function


	Public Function SampleWithReplacement(ByRef prg As PseudorandomGenerator, k As Double, n As Double) As Double ()
		Dim ss As Double ()
		Dim i As Double

		ss = New Double (k - 1){}

		i = 0.0
		While i < k
			ss(i) = PseudorandomNextInteger(prg, n)
			i = i + 1.0
		End While

		Return ss
	End Function


	Public Function Sample(ByRef prg As PseudorandomGenerator, k As Double, n As Double) As Double ()
		Dim ss, list As Double ()
		Dim i, nextx As Double
		Dim hasPicked As Boolean ()
		Dim ssReference As NumberArrayReference

		ss = New Double (k - 1){}
		If n/10.0 < k
			' If k is relatively high:
			list = RandomPermutation(prg, n)

			ssReference = New NumberArrayReference()
			arraysCopyNumberArrayRange(list, 0.0, k, ssReference)
			ss = ssReference.numberArray
			ssReference = Nothing
			Erase list 
		Else
			' If k is relatively low:
			hasPicked = arraysCreateBooleanArray(n, false)

			i = 0.0
			While i < n
				nextx = PseudorandomNextInteger(prg, n)
				If Not hasPicked(nextx)
					hasPicked(nextx) = true
					ss(i) = nextx
					i = i + 1.0
				End If
			End While

			Erase hasPicked 
		End If

		Return ss
	End Function


	Public Sub Shuffle(ByRef prg As PseudorandomGenerator, ByRef list As Double ())
		Call FisherYatesShuffle(prg, list)
	End Sub


	Public Sub FisherYatesShuffle(ByRef prg As PseudorandomGenerator, ByRef a As Double ())
		Dim i, j, n As Double

		n = a.Length

		i = 0.0
		While i < n - 2.0
			j = PseudorandomNextIntegerBetween(prg, i, n)
			Call arraysSwapElementsOfNumberArray(a, i, j)
			i = i + 1.0
		End While
	End Sub


	Public Function SampleWithReplacementFromArray(ByRef prg As PseudorandomGenerator, ByRef a As Double (), k As Double) As Double ()
		Dim source, list As Double ()
		Dim i As Double

		source = SampleWithReplacement(prg, k, a.Length)

		list = New Double (k - 1){}

		i = 0.0
		While i < k
			list(i) = a(source(i))
			i = i + 1.0
		End While

		Erase source 

		Return list
	End Function


	Public Function SampleFromArray(ByRef prg As PseudorandomGenerator, ByRef a As Double (), k As Double) As Double ()
		Dim source, list As Double ()
		Dim i As Double

		source = Sample(prg, k, a.Length)

		list = New Double (k - 1){}

		i = 0.0
		While i < k
			list(i) = a(source(i))
			i = i + 1.0
		End While

		Erase source 

		Return list
	End Function


	Public Function RandomPermutation(ByRef prg As PseudorandomGenerator, n As Double) As Double ()
		Dim list As Double ()
		Dim i As Double

		list = New Double (n - 1){}

		i = 0.0
		While i < n
			list(i) = i
			i = i + 1.0
		End While

		Call Shuffle(prg, list)

		Return list
	End Function


	Public Function StudentTDensity(x As Double, v As Double) As Double
		Return Gamma((v + 1.0)/2.0)/(Sqrt(v*Pi)*Gamma(v/2.0))*(1.0 + x ^ 2.0/v) ^ (-((v + 1.0)/2.0))
	End Function


	Public Function StudentTProbability(x As Double, v As Double) As Double
		Return 1.0/2.0 + x*Gamma((v + 1.0)/2.0)*Hypergeometric(1.0/2.0, (v + 1.0)/2.0, 3.0/2.0, -x ^ 2.0/v, 50.0, 0.00001)/(Sqrt(Pi*v)*Gamma(v/2.0))
	End Function


	Public Function StudentTRandom(ByRef prg As PseudorandomGenerator, n As Double, v As Double) As Double ()
		Dim ns As Double ()
		Dim i, nr As Double

		ns = New Double (n - 1){}

		i = 0.0
		While i < n
			nr = PseudorandomNextNumber(prg)
			ns(i) = StudentTQuantile(nr, v)
			i = i + 1.0
		End While

		Return ns
	End Function


	Public Function StudentTQuantile(p As Double, v As Double) As Double
		Dim t, i, j, q, hy, qi, qip1, gy, a As Double

		If v = 1.0
			q = Tan(Pi*(p - 1.0/2.0))
		ElseIf v = 2.0
			a = 4.0*p*(1.0 - p)
			q = (2.0*p - 1.0)*Sqrt(2.0/a)
		ElseIf v = 4.0
			a = 4.0*p*(1.0 - p)
			q = Cos(1.0/3.0*Acos(Sqrt(a)))/Sqrt(a)
			q = Signx(p - 1.0/2.0)*2.0*Sqrt(q - 1.0)
		ElseIf DivisibleBy(v, 2.0)
			q = ChengFuStudentTQuantileAlgorithm(p, v)
		Else
			q = HillsAlgorithm396(p, v)
		End If

		Return q
	End Function


	Public Function ChengFuStudentTQuantileAlgorithm(p As Double, v As Double) As Double
		Dim a, qi, i, gy, j, qip1, q, k As Double

		k = Ceiling(v/2.0)
		a = 1.0 - p

		If a <> 0.5
			qi = Sqrt(2.0*(1.0 - 2.0*a) ^ 2.0/(1.0 - (1.0 - 2.0*a) ^ 2.0))

			i = 0.0
			While i < 20.0
				gy = 0.0
				j = 0.0
				While j <= k - 1.0
					gy = gy + Factorial(2.0*j)/2.0 ^ (2.0*j)/Factorial(j) ^ 2.0*(1.0 + qi ^ 2.0/(2.0*k)) ^ (-j)
					j = j + 1.0
				End While

				qip1 = 1.0/Sqrt(1.0/(2.0*k)*((gy/(1.0 - 2.0*a)) ^ 2.0 - 1.0))

				qi = qip1
				i = i + 1.0
			End While

			If a > 0.5
				q = -qi
			Else
				q = qi
			End If
		Else
			q = 0.0
		End If
		Return q
	End Function


	Public Function HillsAlgorithm396(p As Double, v As Double) As Double
		Dim q, t, z As Double
		Dim a, b, c, d, x, y As Double
		Dim negate As Boolean

		If p > 0.5
			negate = false
			z = 2.0*(1.0 - p)
		Else
			negate = true
			z = 2.0*p
		End If

		a = 1.0/(v - 0.5)
		b = 48.0/(a*a)
		c = ((20700.0*a/b - 98.0)*a - 16.0)*a + 96.36
		d = ((94.5/(b + c) - 3.0)/b + 1.0)*Sqrt(a*Pi/2.0)*v
		x = z*d
		y = x ^ (2.0/v)

		If y > 0.05 + a
			x = NormalQuantile(z*0.5, 0.0, 1.0)
			y = x*x
			If v < 5.0
				c = c + 0.3*(v - 4.5)*(x + 0.6)
			End If
			c = c + (((0.05*d*x - 5.0)*x - 7.0)*x - 2.0)*x + b
			y = (((((0.4*y + 6.3)*y + 36.0)*y + 94.5)/c - y - 3.0)/b + 1.0)*x
			y = a*y*y
			If y > 0.002
				y = Exp(y) - 1.0
			Else
				y = y + 0.5*y*y
			End If
		Else
			y = ((1.0/(((v + 6.0)/(v*y) - 0.089*d - 0.822)*(v + 2.0)*3.0) + 0.5/(v + 4.0))*y - 1.0)*(v + 1.0)/(v + 2.0) + 1.0/y
		End If

		q = Sqrt(v*y)

		If negate
			q = -q
		End If

		Return q
	End Function


	Public Function Mean(ByRef list As Double ()) As Double
		Dim sum, i As Double

		sum = 0.0
		i = 0.0
		While i < list.Length
			sum = sum + list(i)
			i = i + 1.0
		End While

		Return sum/list.Length
	End Function


	Public Function MeanOfRows(ByRef list As Matrix) As Double ()
		Dim means As Double ()
		Dim i As Double

		means = New Double (list.r.Length - 1){}

		i = 0.0
		While i < list.r.Length
			means(i) = Mean(list.r(i).c)
			i = i + 1.0
		End While

		Return means
	End Function


	Public Function MeanOfColumns(ByRef list As Matrix) As Double ()
		Dim means As Double ()
		Dim listT As Matrix

		listT = TransposeToNew(list)

		means = MeanOfRows(listT)

		listT = Nothing

		Return means
	End Function


	Public Function Variance(ByRef list As Double ()) As Double
		Dim mu, sum, i As Double

		mu = Mean(list)

		sum = 0.0
		i = 0.0
		While i < list.Length
			sum = sum + (list(i) - mu) ^ 2.0
			i = i + 1.0
		End While

		Return sum/list.Length
	End Function


	Public Function Covariance(ByRef list1 As Double (), ByRef list2 As Double ()) As Double
		Dim mu1, mu2, sum, i As Double

		sum = 0.0
		If list1.Length = list2.Length

			mu1 = Mean(list1)
			mu2 = Mean(list2)

			sum = 0.0
			i = 0.0
			While i < list1.Length
				sum = sum + (list1(i) - mu1)*(list2(i) - mu2)
				i = i + 1.0
			End While
		End If

		Return sum/list1.Length
	End Function


	Public Function CovarianceMatrix(ByRef X As Matrix) As Matrix
		Dim A, XCentered, muMatrix As Matrix
		Dim mu As Double ()

		mu = MeanOfColumns(X)
		muMatrix = CreateMatrixFromRowCopies(mu, NumberOfRows(X))

		XCentered = CreateCopyOfMatrix(X)
		Call Subtract(XCentered, muMatrix)

		A = MultiplyToNew(TransposeToNew(XCentered), XCentered)
		Call ScalarDivide(A, NumberOfRows(X))

		Return A
	End Function


	Public Function CorrelationMatrix(ByRef X As Matrix) As Matrix
		Dim sigma, variancesMatrix, t1, correlationMatrixResult As Matrix
		Dim variances As Double ()
		Dim n As Double

		sigma = SampleCovarianceMatrix(X)

		n = NumberOfRows(sigma)
		variances = New Double (n - 1){}
		Call ExtractDiagonal(sigma, variances)
		Call vectorPower(variances, -1.0/2.0)
		variancesMatrix = CreateDiagonalMatrixFromArray(variances)
		t1 = CreateCopyOfMatrix(variancesMatrix)
		Call Multiply(t1, variancesMatrix, sigma)
		correlationMatrixResult = CreateCopyOfMatrix(variancesMatrix)
		Call Multiply(correlationMatrixResult, t1, variancesMatrix)

		Return correlationMatrixResult
	End Function


	Public Function SampleCovarianceMatrix(ByRef X As Matrix) As Matrix
		Dim A As Matrix

		A = CovarianceMatrix(X)
		Call ScalarMultiply(A, NumberOfRows(X)/(NumberOfRows(X) - 1.0))

		Return A
	End Function


	Public Function Correlation(ByRef list1 As Double (), ByRef list2 As Double ()) As Double
		Dim cv, sd1, sd2 As Double

		cv = Covariance(list1, list2)
		sd1 = StandardDeviation(list1)
		sd2 = StandardDeviation(list2)

		Return cv/(sd1*sd2)
	End Function


	Public Function Percentile(ByRef list As Double (), p As Double) As Double
		Return list(Ceiling(list.Length*p) - 1.0)
	End Function


	Public Function VarianceSample(ByRef list As Double ()) As Double
		Return Variance(list)*list.Length/(list.Length - 1.0)
	End Function


	Public Function StandardDeviation(ByRef list As Double ()) As Double
		Return Sqrt(Variance(list))
	End Function


	Public Function StandardDeviationSample(ByRef list As Double ()) As Double
		Return Sqrt(VarianceSample(list))
	End Function


	Public Function Median(ByRef list As Double ()) As Double
		Dim m As Double

		Call QuickSortNumbers(list)

		If list.Length Mod 2.0 = 1.0
			m = list(Floor(list.Length/2.0))
		Else
			m = (list(list.Length/2.0) + list(list.Length/2.0 - 1.0))/2.0
		End If

		Return m
	End Function


	Public Function Mode(ByRef list As Double ()) As Double ()
		Dim unique, mostFrequent, valuesMostFrequent As Double
		Dim modes, counts As Double ()

		modes = New Double (0 - 1){}
		If list.Length > 0.0
			Call QuickSortNumbers(list)
			unique = CountUniqueNumbers(list)
			counts = CountOccurrenceOfEachNumber(list, unique)
			mostFrequent = FindMostFrequentNumber(counts)
			valuesMostFrequent = CountNumberOfHighestOccurrences(mostFrequent, counts)
			Erase modes 
			modes = GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts)
			Erase counts 
		End If

		Return modes
	End Function


	Public Function CountUniqueNumbers(ByRef list As Double ()) As Double
		Dim last, unique, i As Double

		last = list(0)
		unique = 1.0
		i = 1.0
		While i < list.Length
			If list(i) <> last
				unique = unique + 1.0
				last = list(i)
			End If
			i = i + 1.0
		End While

		Return unique
	End Function


	Public Function CountOccurrenceOfEachNumber(ByRef list As Double (), unique As Double) As Double ()
		Dim counts As Double ()
		Dim current, last, i As Double

		counts = New Double (unique - 1){}

		current = 0.0
		counts(0) = 1.0
		last = list(0)
		i = 1.0
		While i < list.Length
			If list(i) <> last
				current = current + 1.0
				counts(current) = 1.0
			Else
				counts(current) = counts(current) + 1.0
			End If
			last = list(i)
			i = i + 1.0
		End While

		Return counts
	End Function


	Public Function FindMostFrequentNumber(ByRef counts As Double ()) As Double
		Dim mostFrequent, i As Double

		mostFrequent = 0.0
		i = 0.0
		While i < counts.Length
			mostFrequent = Max(counts(i), mostFrequent)
			i = i + 1.0
		End While
		Return mostFrequent
	End Function


	Public Function CountNumberOfHighestOccurrences(mostFrequent As Double, ByRef counts As Double ()) As Double
		Dim valuesMostFrequent, i As Double

		valuesMostFrequent = 0.0
		i = 0.0
		While i < counts.Length
			If counts(i) = mostFrequent
				valuesMostFrequent = valuesMostFrequent + 1.0
			End If
			i = i + 1.0
		End While
		Return valuesMostFrequent
	End Function


	Public Function GetListOfNumbersWithHighestOccurrence(ByRef list As Double (), mostFrequent As Double, valuesMostFrequent As Double, ByRef counts As Double ()) As Double ()
		Dim modes As Double ()
		Dim current, currentInsert, i As Double

		modes = New Double (valuesMostFrequent - 1){}

		current = 0.0
		currentInsert = 0.0
		i = 0.0
		While i < counts.Length
			If counts(i) = mostFrequent
				modes(currentInsert) = list(current)
				currentInsert = currentInsert + 1.0
			End If

			current = current + counts(i)
			i = i + 1.0
		End While

		Return modes
	End Function


	Public Function LogNormalDensity(x As Double, mean As Double, sd As Double) As Double
		Return 1.0/(x*sd*Sqrt(2.0*Pi))*Exp(-((Log(x) - mean) ^ 2.0/(2.0*sd ^ 2.0)))
	End Function


	Public Function LogNormalRandom(ByRef prg As PseudorandomGenerator, n As Double, mean As Double, sd As Double) As Double ()
		Dim i As Double
		Dim rs As Double ()

		rs = NormalRandom(prg, n, mean, sd)

		i = 0.0
		While i < n
			rs(i) = Exp(rs(i))
			i = i + 1.0
		End While

		Return rs
	End Function


	Public Function LogNormalProbability(q As Double, mean As Double, sd As Double) As Double
		Return NormalProbability(Log(q), mean, sd)
	End Function


	Public Function LogNormalQuantile(p As Double, mean As Double, sd As Double) As Double
		Return Exp(NormalQuantile(p, mean, sd))
	End Function


	Public Function CreateUnsignedInteger(digits As Double) As UnsignedInteger
		Dim x As UnsignedInteger

		x = New UnsignedInteger()
		x.digits = New Double (digits - 1){}

		Call ClearUnsignedInteger(x)

		Return x
	End Function


	Public Sub FreeUnsignedInteger(ByRef x As UnsignedInteger)
		Erase x.digits 
		x = Nothing
	End Sub


	Public Sub ClearUnsignedInteger(ByRef x As UnsignedInteger)
		Dim i As Double

		i = 0.0
		While i < DigitCapacityUnsignedInteger(x)
			x.digits(i) = 0.0
			i = i + 1.0
		End While
	End Sub


	Public Sub TrimUnsignedInteger(ByRef x As UnsignedInteger)
		Dim capacity, digits, newCapacity, i As Double
		Dim newDigits As Double ()

		capacity = DigitCapacityUnsignedInteger(x)
		digits = DigitsUnsignedInteger(x)

		If capacity > digits
			newCapacity = digits
			newDigits = New Double (newCapacity - 1){}

			i = 0.0
			While i < newCapacity
				newDigits(i) = x.digits(i)
				i = i + 1.0
			End While

			Erase x.digits 
			x.digits = newDigits
		End If
	End Sub


	Public Function ToStringUnsignedInteger(ByRef x As UnsignedInteger) As Char ()
		Dim str As Char ()
		Dim c As Char
		Dim i, digits, digit As Double

		digits = DigitsUnsignedInteger(x)
		str = New Char (digits - 1){}

		i = 0.0
		While i < digits
			digit = DigitUnsignedInteger(x, i)

			c = DecimalDigitToCharacter(digit)

			str(digits - i - 1.0) = c
			i = i + 1.0
		End While

		Return str
	End Function


	Public Sub AddUnsignedInteger(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger)
		Dim overflow As Boolean
		Dim capacity, ads, bds As Double

		overflow = Not AddFixedUnsignedInteger(x, a, b)

		If overflow
			Erase x.digits 

			ads = DigitsUnsignedInteger(a)
			bds = DigitsUnsignedInteger(b)
			capacity = Max(ads, bds) + 1.0
			x.digits = New Double (capacity - 1){}

			AddFixedUnsignedInteger(x, a, b)
		End If
	End Sub


	Public Function SubtractUnsignedInteger(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Boolean
		Dim ads, xds As Double

		ads = DigitsUnsignedInteger(a)
		xds = DigitCapacityUnsignedInteger(x)

		If xds < ads
			Erase x.digits 
			x.digits = New Double (ads - 1){}
		End If

		Return SubtractFixedUnsignedInteger(x, a, b)
	End Function


	Public Sub MultiplyUnsignedInteger(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger)
		Dim overflow As Boolean
		Dim capacity, ads, bds As Double

		overflow = Not MultiplyFixedUnsignedInteger(x, a, b)

		If overflow
			Erase x.digits 

			ads = DigitsUnsignedInteger(a)
			bds = DigitsUnsignedInteger(b)
			capacity = ads + bds
			x.digits = New Double (capacity - 1){}

			MultiplyFixedUnsignedInteger(x, a, b)
		End If
	End Sub


	Public Function DivideUnsignedInteger(ByRef q As UnsignedInteger, ByRef r As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Boolean
		Dim capacity, ads, bds, qds, rds As Double

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)
		qds = DigitCapacityUnsignedInteger(q)
		rds = DigitCapacityUnsignedInteger(r)

		If qds < ads - bds + 1.0
			capacity = ads - bds + 1.0
			q.digits = New Double (capacity - 1){}
		End If

		If rds < bds
			capacity = bds
			r.digits = New Double (capacity - 1){}
		End If

		Return DivideFixedUnsignedInteger(q, r, a, b)
	End Function


	Public Sub ShiftLeftUnsignedInteger(ByRef x As UnsignedInteger, shifts As Double)
		Dim xds, capacity, i As Double
		Dim oldDigits As Double ()

		xds = DigitsUnsignedInteger(x)
		capacity = DigitCapacityUnsignedInteger(x)

		If xds + shifts > capacity
			capacity = xds + shifts
			oldDigits = x.digits
			x.digits = New Double (capacity - 1){}
		Else
			oldDigits = x.digits
		End If

		i = 0.0
		While i < oldDigits.Length - shifts
			x.digits(oldDigits.Length - i - 1.0) = oldDigits(oldDigits.Length - shifts - i - 1.0)
			i = i + 1.0
		End While

		
		While i < oldDigits.Length
			x.digits(oldDigits.Length - i - 1.0) = 0.0
			i = i + 1.0
		End While
	End Sub


	Public Function CreateArbitraryPrecisionInteger(digits As Double) As ArbitraryPrecisionInteger
		Dim x As ArbitraryPrecisionInteger

		x = New ArbitraryPrecisionInteger()
		x.signx = true
		x.number = CreateUnsignedInteger(digits)

		Return x
	End Function


	Public Sub FreeArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger)
		Call FreeUnsignedInteger(x.number)
		x = Nothing
	End Sub


	Public Sub ClearArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger)
		x.signx = true
		Call ClearUnsignedInteger(x.number)
	End Sub


	Public Sub TrimArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger)
		Call TrimUnsignedInteger(x.number)
	End Sub


	Public Function ToStringArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger) As Char ()
		Dim str As Char ()
		Dim c As Char
		Dim i, digits, digit As Double

		If x.number.digits.Length > 0.0

			digits = DigitsUnsignedInteger(x.number)
			str = New Char (1.0 + digits - 1){}

			If x.signx
				str(0) = "+"C
			Else
				str(0) = "-"C
			End If

			i = 0.0
			While i < digits
				digit = DigitUnsignedInteger(x.number, i)

				c = DecimalDigitToCharacter(digit)

				str(1.0 + digits - i - 1.0) = c
				i = i + 1.0
			End While
		Else
			str = New Char (2 - 1){}
			str(0) = "+"C
			str(1) = "0"C
		End If

		Return str
	End Function


	Public Function CreateArbitraryPrecisionIntegerFromString(ByRef str As Char ()) As ArbitraryPrecisionInteger
		Dim x As ArbitraryPrecisionInteger
		Dim c As Char
		Dim i, digit, stringDigits, hasSign As Double

		hasSign = 0.0
		If str.Length > 0.0
			If str(0) = "-"C Or str(0) = "+"C
				hasSign = 1.0
			End If
		End If

		x = CreateArbitraryPrecisionInteger(str.Length - hasSign)
		stringDigits = str.Length

		If str.Length > 0.0
			x.signx = true
			If str(0) = "-"C
				x.signx = false
			ElseIf str(0) = "+"C
				x.signx = true
			End If
		End If

		i = 0.0
		While i < stringDigits - hasSign
			c = str(stringDigits - i - 1.0)
			digit = CharacterToDecimalDigit(c)
			x.number.digits(i) = digit
			i = i + 1.0
		End While

		Return x
	End Function


	Public Sub AddArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger, ByRef a As ArbitraryPrecisionInteger, ByRef b As ArbitraryPrecisionInteger)
		Dim asx, bs As Boolean
		Dim comparisonResult As Double

		asx = a.signx
		bs = b.signx

		If asx = bs
			Call AddUnsignedInteger(x.number, a.number, b.number)
			x.signx = asx
		ElseIf asx = true
			comparisonResult = CompareFixedUnsignedInteger(a.number, b.number)

			If comparisonResult = 1.0 Or comparisonResult = 0.0
				SubtractUnsignedInteger(x.number, a.number, b.number)
			Else
				SubtractUnsignedInteger(x.number, b.number, a.number)
				x.signx = false
			End If
		Else
			comparisonResult = CompareFixedUnsignedInteger(b.number, a.number)

			If comparisonResult = 1.0 Or comparisonResult = 0.0
				SubtractUnsignedInteger(x.number, b.number, a.number)
			Else
				SubtractUnsignedInteger(x.number, a.number, b.number)
				x.signx = false
			End If
		End If
	End Sub


	Public Sub SubtractArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger, ByRef a As ArbitraryPrecisionInteger, ByRef b As ArbitraryPrecisionInteger)
		Dim asx, bs As Boolean
		Dim comparisonResult As Double

		asx = a.signx
		bs = b.signx

		If asx = bs
			If asx = true
				comparisonResult = CompareFixedUnsignedInteger(a.number, b.number)

				If comparisonResult = 1.0 Or comparisonResult = 0.0
					SubtractUnsignedInteger(x.number, a.number, b.number)
				Else
					SubtractUnsignedInteger(x.number, b.number, a.number)
					x.signx = false
				End If
			Else
				comparisonResult = CompareFixedUnsignedInteger(b.number, a.number)

				If comparisonResult = 1.0 Or comparisonResult = 0.0
					SubtractUnsignedInteger(x.number, b.number, a.number)
				Else
					SubtractUnsignedInteger(x.number, a.number, b.number)
					x.signx = false
				End If
			End If
		ElseIf asx = false
			Call AddUnsignedInteger(x.number, a.number, b.number)
			x.signx = false
		Else
			Call AddUnsignedInteger(x.number, a.number, b.number)
			x.signx = true
		End If
	End Sub


	Public Sub MultiplyArbitraryPrecisionInteger(ByRef x As ArbitraryPrecisionInteger, ByRef a As ArbitraryPrecisionInteger, ByRef b As ArbitraryPrecisionInteger)
		Call MultiplyUnsignedInteger(x.number, a.number, b.number)
		If a.signx <> b.signx
			x.signx = false
		End If
	End Sub


	Public Function DivideArbitraryPrecisionInteger(ByRef q As ArbitraryPrecisionInteger, ByRef r As ArbitraryPrecisionInteger, ByRef a As ArbitraryPrecisionInteger, ByRef b As ArbitraryPrecisionInteger) As Boolean
		Dim success, rIsZero As Boolean
		Dim i As Double

		If a.signx = b.signx
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

			If success
				q.signx = true
				r.signx = true
			End If
		ElseIf a.signx = false
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

			If success
				q.signx = false
				r.signx = true
			End If

			rIsZero = true
			i = 0.0
			While i < r.number.digits.Length
				If r.number.digits(i) <> 0.0
					rIsZero = false
				End If
				i = i + 1.0
			End While

			If Not rIsZero
				Call AddUnsignedInteger(a.number, a.number, b.number)
				success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)
				SubtractUnsignedInteger(r.number, b.number, r.number)
				SubtractUnsignedInteger(a.number, a.number, b.number)
			End If
		Else
			Call AddUnsignedInteger(a.number, a.number, b.number)

			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

			If success
				q.signx = false
				r.signx = false
			End If
		End If

		Return success
	End Function


	Public Function AddArbitraryPrecisionIntegerStrings(ByRef aStr As Char (), ByRef bStr As Char ()) As Char ()
		Dim a, b, c As ArbitraryPrecisionInteger
		Dim cStrx As Char ()

		a = CreateArbitraryPrecisionIntegerFromString(aStr)
		b = CreateArbitraryPrecisionIntegerFromString(bStr)
		c = CreateArbitraryPrecisionInteger(0.0)

		Call AddArbitraryPrecisionInteger(c, a, b)

		cStrx = ToStringArbitraryPrecisionInteger(c)

		Return cStrx
	End Function


	Public Function SubtractArbitraryPrecisionIntegerStrings(ByRef aStr As Char (), ByRef bStr As Char ()) As Char ()
		Dim a, b, c As ArbitraryPrecisionInteger
		Dim cStrx As Char ()

		a = CreateArbitraryPrecisionIntegerFromString(aStr)
		b = CreateArbitraryPrecisionIntegerFromString(bStr)
		c = CreateArbitraryPrecisionInteger(0.0)

		Call SubtractArbitraryPrecisionInteger(c, a, b)

		cStrx = ToStringArbitraryPrecisionInteger(c)

		Return cStrx
	End Function


	Public Function MultiplyArbitraryPrecisionIntegerStrings(ByRef aStr As Char (), ByRef bStr As Char ()) As Char ()
		Dim a, b, c As ArbitraryPrecisionInteger
		Dim cStrx As Char ()

		a = CreateArbitraryPrecisionIntegerFromString(aStr)
		b = CreateArbitraryPrecisionIntegerFromString(bStr)
		c = CreateArbitraryPrecisionInteger(0.0)

		Call MultiplyArbitraryPrecisionInteger(c, a, b)

		cStrx = ToStringArbitraryPrecisionInteger(c)

		Return cStrx
	End Function


	Public Function DivideArbitraryPrecisionIntegerStrings(ByRef aStr As Char (), ByRef bStr As Char (), ByRef rStr As StringReference) As Char ()
		Dim a, b, q, r As ArbitraryPrecisionInteger
		Dim qStr As Char ()

		a = CreateArbitraryPrecisionIntegerFromString(aStr)
		b = CreateArbitraryPrecisionIntegerFromString(bStr)
		q = CreateArbitraryPrecisionInteger(0.0)
		r = CreateArbitraryPrecisionInteger(0.0)

		DivideArbitraryPrecisionInteger(q, r, a, b)

		qStr = ToStringArbitraryPrecisionInteger(q)
		rStr.stringx = ToStringArbitraryPrecisionInteger(r)

		Return qStr
	End Function


	Public Function CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint As Double, digitsAfterPoint As Double) As ArbitraryPrecisionFixedPointNumber
		Dim x As ArbitraryPrecisionFixedPointNumber

		x = New ArbitraryPrecisionFixedPointNumber()
		x.baseNumber = CreateArbitraryPrecisionInteger(digitsBeforePoint + digitsAfterPoint)
		x.pointPosition = digitsAfterPoint

		Return x
	End Function


	Public Sub FreeArbitraryPrecisionFixedPointNumber(ByRef x As ArbitraryPrecisionFixedPointNumber)
		Call FreeArbitraryPrecisionInteger(x.baseNumber)
		x = Nothing
	End Sub


	Public Function AddArbitraryPrecisionFixedPoint(ByRef x As ArbitraryPrecisionFixedPointNumber, ByRef a As ArbitraryPrecisionFixedPointNumber, ByRef b As ArbitraryPrecisionFixedPointNumber) As Boolean
		Dim x1, x2 As ArbitraryPrecisionFixedPointNumber
		Dim aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint As Double
		Dim success As Boolean

		aDigitsBeforePoint = GetDigitsBeforePoint(a)
		aDigitsAfterPoint = GetDigitsAfterPoint(a)

		bDigitsBeforePoint = GetDigitsBeforePoint(b)
		bDigitsAfterPoint = GetDigitsAfterPoint(b)

		digitsBeforePoint = Max(aDigitsBeforePoint, bDigitsBeforePoint)
		digitsAfterPoint = Max(aDigitsAfterPoint, bDigitsAfterPoint)

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		Call AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
		Call AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

		Call ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
		Call ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

		Call AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber)

		success = AssignArbitraryPrecisionFixedPoint(x, x1)

		Return success
	End Function


	Public Function AssignArbitraryPrecisionFixedPoint(ByRef x As ArbitraryPrecisionFixedPointNumber, ByRef a As ArbitraryPrecisionFixedPointNumber) As Boolean
		Dim success, isPointFive, zeroOverflow As Boolean
		Dim aDigitsBeforePoint, aDigitsAfterPoint, xDigitsBeforePoint, xDigitsAfterPoint, i, digit As Double
		Dim epsilon As UnsignedInteger

		xDigitsBeforePoint = GetDigitsBeforePoint(x)
		aDigitsBeforePoint = GetDigitsBeforePoint(a)
		xDigitsAfterPoint = GetDigitsAfterPoint(x)
		aDigitsAfterPoint = GetDigitsAfterPoint(a)

		zeroOverflow = true
		If xDigitsBeforePoint < aDigitsBeforePoint
			i = 0.0
			While i < aDigitsBeforePoint - xDigitsBeforePoint
				If DigitUnsignedInteger(a.baseNumber.number, aDigitsBeforePoint + aDigitsAfterPoint - i - 1.0) <> 0.0
					zeroOverflow = false
				End If
				i = i + 1.0
			End While
		End If

		If zeroOverflow
			' Assign before point.
			i = 0.0
			While i < xDigitsBeforePoint
				If i >= aDigitsBeforePoint
					x.baseNumber.number.digits(xDigitsAfterPoint + i) = 0.0
				Else
					x.baseNumber.number.digits(xDigitsAfterPoint + i) = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint + i)
				End If
				i = i + 1.0
			End While

			' Assign after point:
			i = 0.0
			While i < xDigitsAfterPoint
				If aDigitsAfterPoint - i - 1.0 < 0.0
					x.baseNumber.number.digits(xDigitsAfterPoint - i - 1.0) = 0.0
				Else
					x.baseNumber.number.digits(xDigitsAfterPoint - i - 1.0) = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - i - 1.0)
				End If
				i = i + 1.0
			End While

			' Assign sign.
			x.baseNumber.signx = a.baseNumber.signx

			' Round if necessary.
			If aDigitsAfterPoint > xDigitsAfterPoint
				If x.baseNumber.signx = true
					digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

					If digit >= 5.0
						' Make epsilon.
						epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint)
						epsilon.digits(0) = 1.0
						success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon)
						Call FreeUnsignedInteger(epsilon)
					Else
						success = true
					End If
				Else
					digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

					isPointFive = true
					If digit = 5.0
						i = aDigitsAfterPoint - xDigitsAfterPoint - 2.0
						While i >= 0.0
							If DigitUnsignedInteger(a.baseNumber.number, i) <> 0.0
								isPointFive = false
							End If
							i = i - 1.0
						End While
					Else
						isPointFive = false
					End If

					If digit <= 4.0 Or isPointFive
						success = true
					Else
						epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint)
						epsilon.digits(0) = 1.0
						success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon)
						Call FreeUnsignedInteger(epsilon)
					End If
				End If
			Else
				success = true
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function GetDigitsBeforePoint(ByRef a As ArbitraryPrecisionFixedPointNumber) As Double
		Dim sum As Double
		Dim digitsBeforePoint, digitsAfterPoint As Double

		digitsAfterPoint = GetDigitsAfterPoint(a)
		sum = DigitCapacityUnsignedInteger(a.baseNumber.number)
		digitsBeforePoint = sum - digitsAfterPoint

		Return digitsBeforePoint
	End Function


	Public Function GetDigitsAfterPoint(ByRef a As ArbitraryPrecisionFixedPointNumber) As Double
		Return a.pointPosition
	End Function


	Public Function ToStringArbitraryPrecisionFixedPoint(ByRef x As ArbitraryPrecisionFixedPointNumber) As Char ()
		Dim str As Char ()
		Dim c As Char
		Dim i, digits, digit, point As Double

		If x.baseNumber.number.digits.Length > 0.0

			digits = GetDigitsBeforePoint(x) + GetDigitsAfterPoint(x)
			str = New Char (1.0 + GetDigitsBeforePoint(x) + 1.0 + GetDigitsAfterPoint(x) - 1){}

			If x.baseNumber.signx
				str(0) = "+"C
			Else
				str(0) = "-"C
			End If

			point = 1.0

			i = 0.0
			While i < digits
				digit = DigitUnsignedInteger(x.baseNumber.number, i)

				If i = x.pointPosition
					str(1.0 + digits - i - 1.0 + point) = "."C
					point = 0.0
				End If

				c = DecimalDigitToCharacter(digit)

				str(1.0 + digits - i - 1.0 + point) = c
				i = i + 1.0
			End While
		Else
			str = New Char (3 - 1){}
			str(0) = "+"C
			str(1) = "0"C
			str(2) = "."C
		End If

		Return str
	End Function


	Public Function CreateArbitraryPrecisionFixedPointFromString(digitsBeforePoint As Double, digitsAfterPoint As Double, ByRef str As Char ()) As ArbitraryPrecisionFixedPointNumber
		Dim x As ArbitraryPrecisionFixedPointNumber
		Dim c As Char
		Dim i, digit, stringDigits, hasSign, pointPosition, hasPoint, point As Double

		x = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		hasSign = 0.0
		If str.Length > 0.0
			If str(0) = "-"C Or str(0) = "+"C
				hasSign = 1.0
			End If
		End If

		pointPosition = str.Length
		hasPoint = 0.0
		i = 0.0
		While i < str.Length And hasPoint = 0.0
			If str(str.Length - i - 1.0) = "."C
				pointPosition = i
				hasPoint = 1.0
			End If
			i = i + 1.0
		End While
		stringDigits = str.Length

		If str.Length > 0.0
			x.baseNumber.signx = true
			If str(0) = "-"C
				x.baseNumber.signx = false
			ElseIf str(0) = "+"C
				x.baseNumber.signx = true
			End If
		End If

		point = 0.0
		i = 0.0
		While i < stringDigits - hasSign - hasPoint
			If i = pointPosition
				point = 1.0
			End If
			c = str(stringDigits - point - i - 1.0)
			digit = CharacterToDecimalDigit(c)
			x.baseNumber.number.digits(i) = digit
			i = i + 1.0
		End While

		Return x
	End Function


	Public Function SubtractArbitraryPrecisionFixedPoint(ByRef x As ArbitraryPrecisionFixedPointNumber, ByRef a As ArbitraryPrecisionFixedPointNumber, ByRef b As ArbitraryPrecisionFixedPointNumber) As Boolean
		Dim x1, x2 As ArbitraryPrecisionFixedPointNumber
		Dim aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint As Double
		Dim success As Boolean

		aDigitsBeforePoint = GetDigitsBeforePoint(a)
		aDigitsAfterPoint = GetDigitsAfterPoint(a)

		bDigitsBeforePoint = GetDigitsBeforePoint(b)
		bDigitsAfterPoint = GetDigitsAfterPoint(b)

		digitsBeforePoint = Max(aDigitsBeforePoint, bDigitsBeforePoint)
		digitsAfterPoint = Max(aDigitsAfterPoint, bDigitsAfterPoint)

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		Call AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
		Call AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

		Call ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
		Call ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

		Call SubtractArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber)

		success = AssignArbitraryPrecisionFixedPoint(x, x1)

		Return success
	End Function


	Public Function MultiplyArbitraryPrecisionFixedPoint(ByRef x As ArbitraryPrecisionFixedPointNumber, ByRef a As ArbitraryPrecisionFixedPointNumber, ByRef b As ArbitraryPrecisionFixedPointNumber) As Boolean
		Dim x1, x2, t As ArbitraryPrecisionFixedPointNumber
		Dim aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint As Double
		Dim success As Boolean

		aDigitsBeforePoint = GetDigitsBeforePoint(a)
		aDigitsAfterPoint = GetDigitsAfterPoint(a)

		bDigitsBeforePoint = GetDigitsBeforePoint(b)
		bDigitsAfterPoint = GetDigitsAfterPoint(b)

		digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint
		digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		Call AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
		Call AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

		Call ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
		Call ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

		t = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint, 2.0*digitsAfterPoint)
		Call MultiplyArbitraryPrecisionInteger(t.baseNumber, x1.baseNumber, x2.baseNumber)

		success = AssignArbitraryPrecisionFixedPoint(x, t)

		Return success
	End Function


	Public Function DivideArbitraryPrecisionFixedPoint(ByRef q As ArbitraryPrecisionFixedPointNumber, ByRef a As ArbitraryPrecisionFixedPointNumber, ByRef b As ArbitraryPrecisionFixedPointNumber) As Boolean
		Dim x1, x2, qx, rx As ArbitraryPrecisionFixedPointNumber
		Dim aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint, qDigitsBeforePoint, qDigitsAfterPoint As Double
		Dim success As Boolean

		aDigitsBeforePoint = GetDigitsBeforePoint(a)
		aDigitsAfterPoint = GetDigitsAfterPoint(a)

		bDigitsBeforePoint = GetDigitsBeforePoint(b)
		bDigitsAfterPoint = GetDigitsAfterPoint(b)

		qDigitsAfterPoint = GetDigitsAfterPoint(q)

		digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint
		digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint

		x1 = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint)
		x2 = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint, 2.0*digitsAfterPoint)

		Call AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
		Call AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

		Call ShiftLeftUnsignedInteger(x1.baseNumber.number, qDigitsAfterPoint + 1.0 + bDigitsAfterPoint)

		qx = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint)
		rx = CreateArbitraryPrecisionFixedPointNumber(2.0*digitsBeforePoint + qDigitsAfterPoint + 1.0 + bDigitsAfterPoint, 2.0*digitsAfterPoint)
		DivideArbitraryPrecisionInteger(qx.baseNumber, rx.baseNumber, x1.baseNumber, x2.baseNumber)
		qx.pointPosition = qx.pointPosition + qDigitsAfterPoint - aDigitsAfterPoint + 1.0 - 2.0*bDigitsAfterPoint

		success = AssignArbitraryPrecisionFixedPoint(q, qx)

		Return success
	End Function


	Public Function AddArbitraryPrecisionFixedPointStrings(ByRef aStr As Char (), ByRef bStr As Char (), digitsBeforePoint As Double, digitsAfterPoint As Double) As Char ()
		Dim a, b, c As ArbitraryPrecisionFixedPointNumber
		Dim cStrx As Char ()

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		AddArbitraryPrecisionFixedPoint(c, a, b)

		cStrx = ToStringArbitraryPrecisionFixedPoint(c)

		Return cStrx
	End Function


	Public Function SubtractArbitraryPrecisionFixedPointStrings(ByRef aStr As Char (), ByRef bStr As Char (), digitsBeforePoint As Double, digitsAfterPoint As Double) As Char ()
		Dim a, b, c As ArbitraryPrecisionFixedPointNumber
		Dim cStrx As Char ()

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		SubtractArbitraryPrecisionFixedPoint(c, a, b)

		cStrx = ToStringArbitraryPrecisionFixedPoint(c)

		Return cStrx
	End Function


	Public Function MultiplyArbitraryPrecisionFixedPointStrings(ByRef aStr As Char (), ByRef bStr As Char (), digitsBeforePoint As Double, digitsAfterPoint As Double) As Char ()
		Dim a, b, c As ArbitraryPrecisionFixedPointNumber
		Dim cStrx As Char ()

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		MultiplyArbitraryPrecisionFixedPoint(c, a, b)

		cStrx = ToStringArbitraryPrecisionFixedPoint(c)

		Return cStrx
	End Function


	Public Function DivideArbitraryPrecisionFixedPointStrings(ByRef aStr As Char (), ByRef bStr As Char (), digitsBeforePoint As Double, digitsAfterPoint As Double) As Char ()
		Dim a, b, q, r As ArbitraryPrecisionFixedPointNumber
		Dim qStr As Char ()

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
		q = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

		DivideArbitraryPrecisionFixedPoint(q, a, b)

		qStr = ToStringArbitraryPrecisionFixedPoint(q)

		Return qStr
	End Function


	Public Function GetDigitsAfterAPFPString(ByRef str As Char ()) As Double
		Dim pointPosition, hasPoint, i, digitsAfter As Double

		pointPosition = str.Length
		hasPoint = 0.0
		i = 0.0
		While i < str.Length And hasPoint = 0.0
			If str(str.Length - i - 1.0) = "."C
				pointPosition = i
				hasPoint = 1.0
			End If
			i = i + 1.0
		End While

		If hasPoint = 0.0
			digitsAfter = 0.0
		Else
			digitsAfter = pointPosition
		End If

		Return digitsAfter
	End Function


	Public Function GetDigitsBeforeAPFPString(ByRef str As Char ()) As Double
		Dim hasSign, pointPosition, hasPoint, i, digitsBefore As Double

		hasSign = 0.0
		If str.Length > 0.0
			If str(0) = "-"C Or str(0) = "+"C
				hasSign = 1.0
			End If
		End If

		pointPosition = 0.0
		hasPoint = 0.0
		i = 0.0
		While i < str.Length And hasPoint = 0.0
			If str(str.Length - i - 1.0) = "."C
				pointPosition = i
				hasPoint = 1.0
			End If
			i = i + 1.0
		End While

		If hasPoint = 0.0
			digitsBefore = str.Length - hasPoint
		Else
			digitsBefore = str.Length - pointPosition - hasSign - 1.0
		End If

		Return digitsBefore
	End Function


	Public Function DecimalDigitToCharacter(digit As Double) As Char
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


	Public Function DigitUnsignedInteger(ByRef x As UnsignedInteger, i As Double) As Double
		Return x.digits(i)
	End Function


	Public Function DigitsUnsignedInteger(ByRef x As UnsignedInteger) As Double
		Dim i, capacity, digits As Double
		Dim done As Boolean

		capacity = DigitCapacityUnsignedInteger(x)
		done = false
		digits = capacity

		i = capacity - 1.0
		While i >= 0.0 And Not done
			If DigitUnsignedInteger(x, i) = 0.0
				digits = digits - 1.0
			Else
				done = true
			End If
			i = i - 1.0
		End While

		If digits = 0.0
			digits = 1.0
		End If

		Return digits
	End Function


	Public Function ToStringFixedUnsignedInteger(ByRef x As UnsignedInteger) As Char ()
		Dim str As Char ()
		Dim c As Char
		Dim i, digits, digit As Double

		digits = DigitCapacityUnsignedInteger(x)
		str = New Char (digits - 1){}

		i = 0.0
		While i < digits
			digit = DigitUnsignedInteger(x, i)

			c = DecimalDigitToCharacter(digit)

			str(digits - i - 1.0) = c
			i = i + 1.0
		End While

		Return str
	End Function


	Public Function DigitCapacityUnsignedInteger(ByRef x As UnsignedInteger) As Double
		Return x.digits.Length
	End Function


	Public Function CreateFixedUnsignedIntegerFromString(digits As Double, ByRef str As Char ()) As UnsignedInteger
		Dim x As UnsignedInteger
		Dim c As Char
		Dim i, digit, stringDigits As Double

		x = CreateUnsignedInteger(digits)
		stringDigits = str.Length

		i = 0.0
		While i < stringDigits
			c = str(stringDigits - i - 1.0)

			digit = CharacterToDecimalDigit(c)

			x.digits(i) = digit
			i = i + 1.0
		End While

		Return x
	End Function


	Public Function CharacterToDecimalDigit(c As Char) As Double
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


	Public Function AddFixedUnsignedInteger(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Boolean
		Return AddFixedUnsignedIntegerWithShift(x, a, b, 0.0, 0.0)
	End Function


	Public Function AddFixedUnsignedIntegerWithShift(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger, aShift As Double, bShift As Double) As Boolean
		Dim ads, bds, xds, i, carry, remainder, ad, bd, apos, bpos As Double
		Dim overflow As Boolean

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)
		xds = DigitCapacityUnsignedInteger(x)

		If xds >= ads And xds >= bds
			carry = 0.0

			i = 0.0
			While i < xds
				apos = i - aShift
				If apos >= 0.0 And apos < ads
					ad = DigitUnsignedInteger(a, apos)
				Else
					ad = 0.0
				End If

				bpos = i - bShift
				If bpos >= 0.0 And bpos < bds
					bd = DigitUnsignedInteger(b, bpos)
				Else
					bd = 0.0
				End If

				remainder = ad + bd + carry

				If remainder >= 10.0
					carry = 1.0
					remainder = remainder - 10.0
				Else
					carry = 0.0
				End If

				x.digits(i) = remainder
				i = i + 1.0
			End While

			If carry = 1.0
				overflow = true
			Else
				overflow = false
			End If
		Else
			overflow = true
		End If

		Return Not overflow
	End Function


	Public Function SubtractFixedUnsignedInteger(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Boolean
		Return SubtractFixedUnsignedIntegerWithShift(x, a, b, 0.0, 0.0)
	End Function


	Public Function SubtractFixedUnsignedIntegerWithShift(ByRef x As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger, aShift As Double, bShift As Double) As Boolean
		Dim ads, bds, xds, i, borrow, remainder, ad, bd, apos, bpos As Double
		Dim underflow, overflow As Boolean

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)
		xds = DigitCapacityUnsignedInteger(x)

		borrow = 0.0
		overflow = false

		i = 0.0
		While i < Max(Max(ads, bds), xds) And Not overflow
			apos = i - aShift
			If apos >= 0.0 And apos < ads
				ad = DigitUnsignedInteger(a, apos)
			Else
				ad = 0.0
			End If

			bpos = i - bShift
			If bpos >= 0.0 And bpos < bds
				bd = DigitUnsignedInteger(b, bpos)
			Else
				bd = 0.0
			End If

			remainder = ad - bd - borrow

			If remainder < 0.0
				borrow = 1.0
				remainder = remainder + 10.0
			Else
				borrow = 0.0
			End If

			If remainder <> 0.0
				If i < xds
				Else
					overflow = true
				End If
			End If

			If i < xds
				x.digits(i) = remainder
			End If
			i = i + 1.0
		End While

		If borrow = 1.0
			underflow = true
		Else
			underflow = false
		End If

		Return Not underflow And Not overflow
	End Function


	Public Function MultiplyFixedUnsignedInteger(ByRef c As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Boolean
		Dim i, j, ads, ad As Double
		Dim success As Boolean

		success = true

		Call ClearUnsignedInteger(c)

		ads = DigitsUnsignedInteger(a)
		i = 0.0
		While i < ads
			ad = DigitUnsignedInteger(a, i)

			j = 0.0
			While j < ad
				success = success And AddFixedUnsignedIntegerWithShift(c, c, b, 0.0, i)
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		If c.digits.Length = 0.0
			success = false
		End If

		Return success
	End Function


	Public Function CompareFixedUnsignedInteger(ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Double
		Dim comparizonResult, ads, bds, i, ad, bd As Double
		Dim done As Boolean

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)

		comparizonResult = 0.0

		If ads > bds
			comparizonResult = 1.0
		ElseIf ads < bds
			comparizonResult = -1.0
		Else
			done = false
			i = ads - 1.0
			While i >= 0.0 And Not done
				ad = DigitUnsignedInteger(a, i)
				bd = DigitUnsignedInteger(b, i)

				If ad > bd
					comparizonResult = 1.0
					done = true
				ElseIf ad < bd
					comparizonResult = -1.0
					done = true
				End If
				i = i - 1.0
			End While
		End If

		Return comparizonResult
	End Function


	Public Function CompareFixedUnsignedIntegerWithShift(ByRef a As UnsignedInteger, ByRef b As UnsignedInteger, aShift As Double, bShift As Double) As Double
		Dim comparizonResult, ads, bds, i, ad, bd, apos, bpos As Double
		Dim done As Boolean

		ads = DigitsUnsignedInteger(a)
		If ads > 0.0
			ads = ads + aShift
		End If
		bds = DigitsUnsignedInteger(b)
		If bds > 0.0
			bds = bds + bShift
		End If

		comparizonResult = 0.0

		If ads > bds
			comparizonResult = 1.0
		ElseIf ads < bds
			comparizonResult = -1.0
		Else
			done = false
			i = ads - 1.0
			While i >= 0.0 And Not done
				apos = i - aShift
				If apos >= 0.0 And apos < ads
					ad = DigitUnsignedInteger(a, apos)
				Else
					ad = 0.0
				End If

				bpos = i - bShift
				If bpos >= 0.0 And bpos < bds
					bd = DigitUnsignedInteger(b, bpos)
				Else
					bd = 0.0
				End If

				If ad > bd
					comparizonResult = 1.0
					done = true
				ElseIf ad < bd
					comparizonResult = -1.0
					done = true
				End If
				i = i - 1.0
			End While
		End If

		Return comparizonResult
	End Function


	Public Function DivideFixedUnsignedInteger(ByRef q As UnsignedInteger, ByRef r As UnsignedInteger, ByRef a As UnsignedInteger, ByRef b As UnsignedInteger) As Boolean
		Dim i, j, ads, bds, qd, comparisonResult, qdsCapacity As Double
		Dim success, done As Boolean

		success = true

		Call ClearUnsignedInteger(q)
		Call ClearUnsignedInteger(r)

		ads = DigitsUnsignedInteger(a)
		bds = DigitsUnsignedInteger(b)
		qdsCapacity = DigitCapacityUnsignedInteger(q)

		' bds == 0 -> b.digits[0] != 0
		If bds <> 1.0 Or b.digits(0) <> 0.0
			If ads >= bds
				i = ads - bds
				While i >= 0.0 And success
					qd = 0.0
					done = false
					j = 0.0
					While j <= 9.0 And Not done
						comparisonResult = CompareFixedUnsignedIntegerWithShift(a, b, 0.0, i)
						If comparisonResult = 1.0 Or comparisonResult = 0.0
							SubtractFixedUnsignedIntegerWithShift(a, a, b, 0.0, i)
							qd = qd + 1.0
						Else
							done = true
						End If
						j = j + 1.0
					End While
					If i < qdsCapacity
						q.digits(i) = qd
					Else
						success = false
					End If
					i = i - 1.0
				End While
				If success
					' Put the rest in the remainder.
					success = AddFixedUnsignedInteger(r, r, a)

					If success
						' Reconstruct a.
						MultiplyFixedUnsignedInteger(a, q, b)
						AddFixedUnsignedInteger(a, a, r)
					End If
				End If
			Else
				' Put everything in the remainder.
				AddFixedUnsignedInteger(r, r, a)
			End If
		Else
			' division by zero
			success = false
		End If

		Return success
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
		Dim i As Double

		ref = New StringReference()
		ref.stringx = New Char (value.Length - 1){}
		i = 0.0
		While i < value.Length
			ref.stringx(i) = value(i)
			i = i + 1.0
		End While

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
		Call FreeStringReferenceArray(stringArrayReference.stringArray)
		stringArrayReference = Nothing
	End Sub


	Public Sub FreeStringReferenceArray(ByRef stringReferencesArray As StringReference ())
		Dim i As Double
		i = 0.0
		While i < stringReferencesArray.Length
			stringReferencesArray(i) = Nothing
			i = i + 1.0
		End While
		Erase stringReferencesArray 
	End Sub


	Public Function Increase(ByRef nRef As NumberReference) As Double
		nRef.numberValue = nRef.numberValue + 1.0

		Return nRef.numberValue
	End Function


	Public Function Decrease(ByRef nRef As NumberReference) As Double
		nRef.numberValue = nRef.numberValue - 1.0

		Return nRef.numberValue
	End Function


	Public Function AddToReference(ByRef nRef As NumberReference, n As Double) As Double
		nRef.numberValue = nRef.numberValue + n

		Return nRef.numberValue
	End Function


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
			If IsInteger(datex.year)
				If datex.month >= 1.0 And datex.month <= 12.0
					If IsInteger(datex.month)
						daysInMonth = GetDaysInMonth(datex.year)
						daysInThisMonth = daysInMonth(datex.month)
						If datex.day >= 1.0 And datex.day <= daysInThisMonth
							If IsInteger(datex.day)
								valid = true
							Else
								valid = false
								message.stringx = "Day must be an integer.".ToCharArray()
							End If
						Else
							valid = false
							message.stringx = "The month does not have the given day number.".ToCharArray()
						End If
					Else
						valid = false
						message.stringx = "Month must be an integer.".ToCharArray()
					End If
				Else
					valid = false
					message.stringx = "Month must be between 1 and 12, inclusive.".ToCharArray()
				End If
			Else
				valid = false
				message.stringx = "Year must be an integer.".ToCharArray()
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


	Public Function AddMonthsToDate(ByRef datex As Datex, months As Double, ByRef message As StringReference) As Boolean
		Dim i As Double
		Dim success As Boolean
		Dim backup As Datex

		backup = CopyDate(datex)

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

		success = IsValidDate(datex, message)

		If success
		Else
			' Restore old date
			Call AssignDate(datex, backup)
		End If

		Return success
	End Function


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
		Dim less As Boolean

		less = false

		If a.year < b.year
			less = true
		ElseIf a.year = b.year
			If a.month < b.month
				less = true
			ElseIf a.month = b.month
				If a.day < b.day
					less = true
				Else
				End If
			End If
		End If

		Return less
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
		Dim done, success As Boolean
		Dim dateOfInterest As Datex
		Dim list As LinkedListNumbers
		Dim result As Double ()
		Dim message As StringReference

		list = CreateLinkedListNumbers()
		message = New StringReference()

		done = false
		dateOfInterest = New Datex()
		Call AssignDate(dateOfInterest, from)
		
		While Not done
			If dateOfInterest.year = tox.year And dateOfInterest.month = tox.month
				done = true
			End If

			entry = GetAccrualAmountWithDates(total, from, tox, dateOfInterest.year, dateOfInterest.month)
			Call LinkedListAddNumber(list, entry)
			success = AddMonthsToDate(dateOfInterest, 1.0, message)
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


	Public Sub ArrayAddAll(ByRef backups As Arrayx, ByRef from As Arrayx)
		Dim i As Double
		Dim data As Data

		i = 0.0
		While i < ArrayLength(from)
			data = ArrayIndex(from, i)
			Call AddDataToArray(backups, data)
			i = i + 1.0
		End While
	End Sub


	Public Function SortStringArray(ByRef a As Arrayx) As Boolean
		Return SortStringArrayWithOptions(a, true)
	End Function


	Public Function SortStringArrayDescending(ByRef a As Arrayx) As Boolean
		Return SortStringArrayWithOptions(a, false)
	End Function


	Public Function SortStringArrayWithOptions(ByRef a As Arrayx, asc As Boolean) As Boolean
		Dim success As Boolean
		Dim i, j, len, cmp As Double
		Dim swapped, swap As Boolean
		Dim tmp As Char ()
		Dim da, db As Data

		len = ArrayLength(a)
		success = true
		i = 0.0
		While i < len And success
			If IsString(ArrayIndex(a, i))
			Else
				success = false
			End If
			i = i + 1.0
		End While

		If success
			swapped = true
			i = 0.0
			While i < len - 1.0 And swapped
				swapped = false
				j = 0.0
				While j < len - i - 1.0
					da = a.arrayx(j)
					db = a.arrayx(j + 1.0)

					cmp = StringOrder(da.stringx, db.stringx)
					If asc
						swap = cmp < 0.0
					Else
						swap = cmp > 0.0
					End If

					If swap
						tmp = da.stringx
						da.stringx = db.stringx
						db.stringx = tmp
						swapped = true
					End If
					j = j + 1.0
				End While
				i = i + 1.0
			End While
		End If

		Return success
	End Function


	Public Function StringOrder(ByRef a As Char (), ByRef b As Char ()) As Double
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


	Public Function SortNumberArray(ByRef a As Arrayx) As Boolean
		Return SortNumberArrayWithOptions(a, true)
	End Function


	Public Function SortNumberArrayDescending(ByRef a As Arrayx) As Boolean
		Return SortNumberArrayWithOptions(a, false)
	End Function


	Public Function SortNumberArrayWithOptions(ByRef a As Arrayx, asc As Boolean) As Boolean
		Dim success As Boolean
		Dim i, j, len As Double
		Dim swapped, swap As Boolean
		Dim tmp As Double
		Dim da, db As Data

		len = ArrayLength(a)
		success = true
		i = 0.0
		While i < len And success
			If IsNumber(ArrayIndex(a, i))
			Else
				success = false
			End If
			i = i + 1.0
		End While

		If success
			swapped = true
			i = 0.0
			While i < len - 1.0 And swapped
				swapped = false
				j = 0.0
				While j < len - i - 1.0
					da = a.arrayx(j)
					db = a.arrayx(j + 1.0)

					If asc
						swap = da.number > db.number
					Else
						swap = da.number < db.number
					End If

					If swap
						tmp = da.number
						da.number = db.number
						db.number = tmp
						swapped = true
					End If
					j = j + 1.0
				End While
				i = i + 1.0
			End While
		End If

		Return success
	End Function


	Public Function SortStructArrayByNumberKey(ByRef a As Arrayx, ByRef key As Char ()) As Boolean
		Return SortStructArrayByNumberKeyWithOptions(a, key, true)
	End Function


	Public Function SortStructArrayByNumberKeyDescending(ByRef a As Arrayx, ByRef key As Char ()) As Boolean
		Return SortStructArrayByNumberKeyWithOptions(a, key, false)
	End Function


	Public Function SortStructArrayByNumberKeyWithOptions(ByRef a As Arrayx, ByRef key As Char (), asc As Boolean) As Boolean
		Dim success As Boolean
		Dim i, j, len As Double
		Dim swapped, swap As Boolean
		Dim tmp As Structurex
		Dim na, nb As Double
		Dim da, db As Data

		len = ArrayLength(a)
		success = true
		i = 0.0
		While i < len And success
			da = ArrayIndex(a, i)
			If IsStructure(da)
				If StructHasKey(da.structurex, key)
					da = GetDataFromStruct(da.structurex, key)
					If IsNumber(da)
					Else
						success = false
					End If
				Else
					success = false
				End If
			Else
				success = false
			End If
			i = i + 1.0
		End While

		If success
			swapped = true
			i = 0.0
			While i < len - 1.0 And swapped
				swapped = false
				j = 0.0
				While j < len - i - 1.0
					da = ArrayIndex(a, j)
					db = ArrayIndex(a, j + 1.0)

					na = GetNumberFromStruct(da.structurex, key)
					nb = GetNumberFromStruct(db.structurex, key)

					If asc
						swap = na > nb
					Else
						swap = na < nb
					End If

					If swap
						tmp = da.structurex
						da.structurex = db.structurex
						db.structurex = tmp
						swapped = true
					End If
					j = j + 1.0
				End While
				i = i + 1.0
			End While
		End If

		Return success
	End Function


	Public Function SortStructArrayByStringKey(ByRef a As Arrayx, ByRef key As Char ()) As Boolean
		Return SortStructArrayByStringKeyWithOptions(a, key, true)
	End Function


	Public Function SortStructArrayByStringKeyDescending(ByRef a As Arrayx, ByRef key As Char ()) As Boolean
		Return SortStructArrayByStringKeyWithOptions(a, key, false)
	End Function


	Public Function SortStructArrayByStringKeyWithOptions(ByRef a As Arrayx, ByRef key As Char (), asc As Boolean) As Boolean
		Dim success As Boolean
		Dim i, j, len, cmp As Double
		Dim swapped, swap As Boolean
		Dim tmp As Structurex
		Dim sa, sb As Char ()
		Dim da, db As Data

		len = ArrayLength(a)
		success = true
		i = 0.0
		While i < len And success
			da = ArrayIndex(a, i)
			If IsStructure(da)
				If StructHasKey(da.structurex, key)
					da = GetDataFromStruct(da.structurex, key)
					If IsString(da)
					Else
						success = false
					End If
				Else
					success = false
				End If
			Else
				success = false
			End If
			i = i + 1.0
		End While

		If success
			swapped = true
			i = 0.0
			While i < len - 1.0 And swapped
				swapped = false
				j = 0.0
				While j < len - i - 1.0
					da = ArrayIndex(a, j)
					db = ArrayIndex(a, j + 1.0)

					sa = GetStringFromStruct(da.structurex, key)
					sb = GetStringFromStruct(db.structurex, key)

					cmp = StringOrder(sa, sb)
					If asc
						swap = cmp < 0.0
					Else
						swap = cmp > 0.0
					End If
					If swap
						tmp = da.structurex
						da.structurex = db.structurex
						db.structurex = tmp
						swapped = true
					End If
					j = j + 1.0
				End While
				i = i + 1.0
			End While
		End If

		Return success
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


	Public Function arraysNumberArrayContains(ByRef a As Double (), e As Double) As Boolean
		Dim found As Boolean
		Dim i As Double

		found = false

		i = 0.0
		While i < a.Length And Not found
			If arraysIndexNumber(a, i) = e
				found = true
			End If
			i = i + 1.0
		End While

		Return found
	End Function


	Public Function arraysIndexNumber(ByRef arrayx As Double (), index As Double) As Double
		Return arrayx(index)
	End Function


	Public Function arraysIndexChar(ByRef arrayx As Char (), index As Double) As Char
		Return arrayx(index)
	End Function


	Public Function arraysIndexBoolean(ByRef arrayx As Boolean (), index As Double) As Boolean
		Return arrayx(index)
	End Function


	Public Function arraysIndexString(ByRef arrayx As StringReference (), index As Double) As Char ()
		Return arrayx(index).stringx
	End Function


	Public Function arraysGetMinimum(ByRef data As Double (), ByRef minimumReference As NumberReference) As Boolean
		Dim i, minimum As Double
		Dim success As Boolean

		If data.Length >= 1.0
			minimum = data(0)
			i = 0.0
			While i < data.Length
				minimum = Min(minimum, data(i))
				i = i + 1.0
			End While
			minimumReference.numberValue = minimum
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Function arraysGetMaximum(ByRef data As Double (), ByRef maximumReference As NumberReference) As Boolean
		Dim i, maximum As Double
		Dim success As Boolean

		If data.Length >= 1.0
			maximum = data(0)
			i = 0.0
			While i < data.Length
				maximum = Max(maximum, data(i))
				i = i + 1.0
			End While
			maximumReference.numberValue = maximum
			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Sub arraysAssignNumberArray(ByRef asx As Double (), ByRef bs As Double ())
		Dim i As Double

		i = 0.0
		While i < Min(asx.Length, bs.Length)
			asx(i) = bs(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub arraysAssignBooleanArray(ByRef asx As Boolean (), ByRef bs As Boolean ())
		Dim i As Double

		i = 0.0
		While i < Min(asx.Length, bs.Length)
			asx(i) = bs(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub arraysAssignString(ByRef asx As Char (), ByRef bs As Char ())
		Dim i As Double

		i = 0.0
		While i < Min(asx.Length, bs.Length)
			asx(i) = bs(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub arraysRearrangeArray(ByRef asx As Double (), ByRef indexes As Double ())
		Dim bs As Double ()
		Dim i As Double

		bs = New Double (asx.Length - 1){}

		Call arraysAssignNumberArray(bs, asx)

		i = 0.0
		While i < indexes.Length
			asx(i) = bs(indexes(i))
			i = i + 1.0
		End While

		Erase bs 
	End Sub


	Public Sub arraysSetNumberArrayRange(ByRef data As Double (), offset As Double, ByRef str As Double ())
		Dim i As Double

		i = 0.0
		While i < str.Length And offset + i < data.Length
			data(offset + i) = str(i)
			i = i + 1.0
		End While
	End Sub


	Public Function arraysCopyNumberArrayValues(ByRef a As Double (), ByRef b As Double ()) As Boolean
		Dim success As Boolean
		Dim i As Double

		success = a.Length = b.Length

		If success
			i = 0.0
			While i < a.Length
				a(i) = b(i)
				i = i + 1.0
			End While
		End If

		Return success
	End Function


	Public Function arraysCopyBooleanArrayValues(ByRef a As Boolean (), ByRef b As Boolean ()) As Boolean
		Dim success As Boolean
		Dim i As Double

		success = a.Length = b.Length

		If success
			i = 0.0
			While i < a.Length
				a(i) = b(i)
				i = i + 1.0
			End While
		End If

		Return success
	End Function


	Public Function arraysCopyStringValues(ByRef a As Char (), ByRef b As Char ()) As Boolean
		Dim success As Boolean
		Dim i As Double

		success = a.Length = b.Length

		If success
			i = 0.0
			While i < a.Length
				a(i) = b(i)
				i = i + 1.0
			End While
		End If

		Return success
	End Function


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
		Dim d, factor, a, x, tz, extra, dotpos, p, zero As Double
		Dim isPositive, done, lessThan1, isInt As Boolean
		Dim str, ds As Char ()
		Dim factorRef As NumberReference

		factorRef = New NumberReference()

		isPositive = true

		If number < 0.0
			isPositive = false
			number = Abs(number)
		End If

		If number = 0.0
			str = "0".ToCharArray()
		ElseIf number > 999999999999999e99
			' Guard the number against relaxations.
			If isPositive
				str = "Infinity".ToCharArray()
			Else
				str = "-Infinity".ToCharArray()
			End If
		Else
			lessThan1 = number < 1.0

			' Guard the number against relaxations.
			If number < 1e-99
				number = 0.0
			End If

			' 1. Turn number into an integer with 15 digits.
			number = NumberTo15DigitInteger(number, factorRef)
			factor = factorRef.numberValue
			factorRef = Nothing

			' 2. Extract the 15 digits
			ds = New Char (15 - 1){}

			a = number
			zero = Convert.ToInt16("0"C)
			d = 0.0
			While d < 15.0
				x = a - Floor(a/10.0)*10.0
				ds(15.0 - d - 1.0) = Convert.ToChar(Convert.ToInt64((x + zero)))
				a = Floor(a/10.0)
				d = d + 1.0
			End While

			' 3. Remove trailing zeros
			tz = 0.0
			done = false
			d = 0.0
			While d < 15.0 And Not done
				If ds(15.0 - d - 1.0) = "0"C
					tz = tz + 1.0
				Else
					done = true
				End If
				d = d + 1.0
			End While
			ds = strSubstring(ds, 0.0, 15.0 - tz)

			' 4. Determine if integer
			isInt = factor + tz >= 0.0

			' 5. Fill into formats
			If isInt
				' |-----|
				' AAAAAAA00000000
				str = New Char (15.0 + factor - 1){}
				d = 0.0
				While d < str.Length
					str(d) = "0"C
					d = d + 1.0
				End While
				d = 0.0
				While d < ds.Length
					str(d) = ds(d)
					d = d + 1.0
				End While
			ElseIf lessThan1
				'       |-----|
				' 0.0000AAAAAAA
				extra = -factor - 15.0
				str = New Char (2.0 + extra + 15.0 - tz - 1){}
				d = 0.0
				While d < str.Length
					str(d) = "0"C
					d = d + 1.0
				End While
				str(1) = "."C
				d = 0.0
				While d < ds.Length
					str(2.0 + extra + d) = ds(d)
					d = d + 1.0
				End While
			Else
				' |-------|
				' AAAA.AAAA
				str = New Char (1.0 + 15.0 - tz - 1){}
				dotpos = 15.0 + factor
				p = 0.0
				d = 0.0
				While d < str.Length
					If d = dotpos
						str(d) = "."C
					Else
						str(d) = ds(p)
						p = p + 1.0
					End If
					d = d + 1.0
				End While
			End If
		End If

		' Done
		If Not isPositive
			str = strConcatenateString("-".ToCharArray(), str)
		End If

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


	Public Function NumberTo15DigitInteger(n As Double, ByRef factorRef As NumberReference) As Double
		Dim i, dp As Double
		Dim factors As Double ()

		factors = GetPowersOfTenFor15d2e()
		dp = GetFirstDecimalDigitPosition(n)
		factorRef.numberValue = dp - 14.0

		i = 14.0 + -dp

		n = MultiplyWithIntegerPowerOf10(n, factors, i)

		Erase factors 

		n = Roundx(n)

		If n >= 1e15
			n = n/10.0
			factorRef.numberValue = factorRef.numberValue + 1.0
		End If

		Return n
	End Function


	Public Function MultiplyWithIntegerPowerOf10(n As Double, ByRef factors As Double (), power As Double) As Double
		n = n*factors(power + 99.0)

		Return n
	End Function


	Public Function GetFirstDecimalDigitPosition(n As Double) As Double
		Dim power, i As Double
		Dim factors As Double ()
		Dim found As Boolean

		n = Abs(n)

		factors = GetPowersOfTenFor15d2e()

		power = 1.0

		If n = 0.0
			power = 0.0
		ElseIf n > 999999999999999e99
			' This guards against relaxed variables' max value
			power = 114.0
		ElseIf n < 1e-99
			' This guards against relaxed variables' min value
			power = -100.0
		Else
			found = false
			' Search the most likely space first.
			i = 99.0 - 20.0
			While i < 99.0 + 20.0 And Not found
				If n >= factors(i) And n < factors(i + 1.0)
					power = i - 99.0
					found = true
				End If
				i = i + 1.0
			End While
			' Search the whole space
			i = 0.0
			While i < factors.Length - 1.0 And Not found
				If n >= factors(i) And n < factors(i + 1.0)
					power = i - 99.0
					found = true
				End If
				i = i + 1.0
			End While
			If Not found
				If n >= 100000000000000e99 And n <= 999999999999999e99
					power = i - 99.0
				End If
			End If
		End If

		Erase factors 

		' Normal returns are -99 to 113. If -100 or 114 is returned, it means a relaxation is used.
		Return power
	End Function


	Public Function GetPowersOfTenFor15d2e() As Double ()
		Dim factors As Double ()

		factors = New Double (213 - 1){}

		factors(0) = 1e-99
		factors(1) = 1e-98
		factors(2) = 1e-97
		factors(3) = 1e-96
		factors(4) = 1e-95
		factors(5) = 1e-94
		factors(6) = 1e-93
		factors(7) = 1e-92
		factors(8) = 1e-91
		factors(9) = 1e-90
		factors(10) = 1e-89
		factors(11) = 1e-88
		factors(12) = 1e-87
		factors(13) = 1e-86
		factors(14) = 1e-85
		factors(15) = 1e-84
		factors(16) = 1e-83
		factors(17) = 1e-82
		factors(18) = 1e-81
		factors(19) = 1e-80
		factors(20) = 1e-79
		factors(21) = 1e-78
		factors(22) = 1e-77
		factors(23) = 1e-76
		factors(24) = 1e-75
		factors(25) = 1e-74
		factors(26) = 1e-73
		factors(27) = 1e-72
		factors(28) = 1e-71
		factors(29) = 1e-70
		factors(30) = 1e-69
		factors(31) = 1e-68
		factors(32) = 1e-67
		factors(33) = 1e-66
		factors(34) = 1e-65
		factors(35) = 1e-64
		factors(36) = 1e-63
		factors(37) = 1e-62
		factors(38) = 1e-61
		factors(39) = 1e-60
		factors(40) = 1e-59
		factors(41) = 1e-58
		factors(42) = 1e-57
		factors(43) = 1e-56
		factors(44) = 1e-55
		factors(45) = 1e-54
		factors(46) = 1e-53
		factors(47) = 1e-52
		factors(48) = 1e-51
		factors(49) = 1e-50
		factors(50) = 1e-49
		factors(51) = 1e-48
		factors(52) = 1e-47
		factors(53) = 1e-46
		factors(54) = 1e-45
		factors(55) = 1e-44
		factors(56) = 1e-43
		factors(57) = 1e-42
		factors(58) = 1e-41
		factors(59) = 1e-40
		factors(60) = 1e-39
		factors(61) = 1e-38
		factors(62) = 1e-37
		factors(63) = 1e-36
		factors(64) = 1e-35
		factors(65) = 1e-34
		factors(66) = 1e-33
		factors(67) = 1e-32
		factors(68) = 1e-31
		factors(69) = 1e-30
		factors(70) = 1e-29
		factors(71) = 1e-28
		factors(72) = 1e-27
		factors(73) = 1e-26
		factors(74) = 1e-25
		factors(75) = 1e-24
		factors(76) = 1e-23
		factors(77) = 1e-22
		factors(78) = 1e-21
		factors(79) = 1e-20
		factors(80) = 1e-19
		factors(81) = 1e-18
		factors(82) = 1e-17
		factors(83) = 1e-16
		factors(84) = 1e-15
		factors(85) = 1e-14
		factors(86) = 1e-13
		factors(87) = 1e-12
		factors(88) = 1e-11
		factors(89) = 1e-10
		factors(90) = 1e-9
		factors(91) = 1e-8
		factors(92) = 1e-7
		factors(93) = 1e-6
		factors(94) = 1e-5
		factors(95) = 1e-4
		factors(96) = 1e-3
		factors(97) = 1e-2
		factors(98) = 1e-1
		factors(99) = 1e0
		factors(100) = 1e1
		factors(101) = 1e2
		factors(102) = 1e3
		factors(103) = 1e4
		factors(104) = 1e5
		factors(105) = 1e6
		factors(106) = 1e7
		factors(107) = 1e8
		factors(108) = 1e9
		factors(109) = 1e10
		factors(110) = 1e11
		factors(111) = 1e12
		factors(112) = 1e13
		factors(113) = 1e14
		factors(114) = 1e15
		factors(115) = 1e16
		factors(116) = 1e17
		factors(117) = 1e18
		factors(118) = 1e19
		factors(119) = 1e20
		factors(120) = 1e21
		factors(121) = 1e22
		factors(122) = 1e23
		factors(123) = 1e24
		factors(124) = 1e25
		factors(125) = 1e26
		factors(126) = 1e27
		factors(127) = 1e28
		factors(128) = 1e29
		factors(129) = 1e30
		factors(130) = 1e31
		factors(131) = 1e32
		factors(132) = 1e33
		factors(133) = 1e34
		factors(134) = 1e35
		factors(135) = 1e36
		factors(136) = 1e37
		factors(137) = 1e38
		factors(138) = 1e39
		factors(139) = 1e40
		factors(140) = 1e41
		factors(141) = 1e42
		factors(142) = 1e43
		factors(143) = 1e44
		factors(144) = 1e45
		factors(145) = 1e46
		factors(146) = 1e47
		factors(147) = 1e48
		factors(148) = 1e49
		factors(149) = 1e50
		factors(150) = 1e51
		factors(151) = 1e52
		factors(152) = 1e53
		factors(153) = 1e54
		factors(154) = 1e55
		factors(155) = 1e56
		factors(156) = 1e57
		factors(157) = 1e58
		factors(158) = 1e59
		factors(159) = 1e60
		factors(160) = 1e61
		factors(161) = 1e62
		factors(162) = 1e63
		factors(163) = 1e64
		factors(164) = 1e65
		factors(165) = 1e66
		factors(166) = 1e67
		factors(167) = 1e68
		factors(168) = 1e69
		factors(169) = 1e70
		factors(170) = 1e71
		factors(171) = 1e72
		factors(172) = 1e73
		factors(173) = 1e74
		factors(174) = 1e75
		factors(175) = 1e76
		factors(176) = 1e77
		factors(177) = 1e78
		factors(178) = 1e79
		factors(179) = 1e80
		factors(180) = 1e81
		factors(181) = 1e82
		factors(182) = 1e83
		factors(183) = 1e84
		factors(184) = 1e85
		factors(185) = 1e86
		factors(186) = 1e87
		factors(187) = 1e88
		factors(188) = 1e89
		factors(189) = 1e90
		factors(190) = 1e91
		factors(191) = 1e92
		factors(192) = 1e93
		factors(193) = 1e94
		factors(194) = 1e95
		factors(195) = 1e96
		factors(196) = 1e97
		factors(197) = 1e98
		factors(198) = 1e99
		factors(199) = 10e99
		factors(200) = 100e99
		factors(201) = 1000e99
		factors(202) = 10000e99
		factors(203) = 100000e99
		factors(204) = 1000000e99
		factors(205) = 10000000e99
		factors(206) = 100000000e99
		factors(207) = 1000000000e99
		factors(208) = 10000000000e99
		factors(209) = 100000000000e99
		factors(210) = 1000000000000e99
		factors(211) = 10000000000000e99
		factors(212) = 100000000000000e99

		Return factors
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
		Dim d, m, i As Double
		Dim factorRef As NumberReference

		n = Abs(n)

		factorRef = New NumberReference()
		n = NumberTo15DigitInteger(n, factorRef)
		factorRef = Nothing

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
		Return CreateDecimalNumberFromStringWithCheck(stringx, decimalReference, message)
	End Function


	Public Function CreateNumberFromDecimalString(ByRef stringx As Char ()) As Double
		Dim numberRef As NumberReference
		Dim message As StringReference
		Dim number As Double

		numberRef = CreateNumberReference(0.0)
		message = CreateStringReference("".ToCharArray())
		CreateDecimalNumberFromStringWithCheck(stringx, numberRef, message)
		number = numberRef.numberValue

		numberRef = Nothing
		message = Nothing

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


	Public Function CreateDecimalNumberFromStringWithCheck(ByRef stringx As Char (), ByRef numberReference As NumberReference, ByRef message As StringReference) As Boolean
		Dim success As Boolean
		Dim numberIsPositive, exponentIsPositive As BooleanReference
		Dim beforePoint, afterPoint, exponent As NumberArrayReference

		numberIsPositive = CreateBooleanReference(true)
		exponentIsPositive = CreateBooleanReference(true)
		beforePoint = New NumberArrayReference()
		afterPoint = New NumberArrayReference()
		exponent = New NumberArrayReference()

		success = ExtractPartsFromNumberString(stringx, 10.0, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

		If success
			numberReference.numberValue = CreateDecimalNumberFromParts(numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray)
		End If

		numberIsPositive = Nothing
		exponentIsPositive = Nothing
		beforePoint = Nothing
		afterPoint = Nothing
		exponent = Nothing

		Return success
	End Function


	Public Function CreateNumberFromParts(base As Double, numberIsPositive As Boolean, ByRef beforePoint As Double (), ByRef afterPoint As Double (), exponentIsPositive As Boolean, ByRef exponent As Double ()) As Double
		Dim n, i, d, e, digits, integerOffset, maxDigits, roundingDigit As Double
		Dim digitsStarted, roundingDigitSet As Boolean

		n = 0.0
		e = 0.0
		digits = 0.0
		digitsStarted = false
		integerOffset = 0.0
		maxDigits = Floor(15.0*Log(10.0)/Log(base))
		roundingDigitSet = false
		roundingDigit = 0.0

		' We construct an integer n, inserting one and one digit and shifting left.
		' We read up to a certain amount of digits.
		i = 0.0
		While i < beforePoint.Length + afterPoint.Length And digits < maxDigits + 1.0
			If i < beforePoint.Length
				d = beforePoint(i)
			Else
				d = afterPoint(i - beforePoint.Length)
			End If

			If digits < maxDigits
				If d <> 0.0
					digitsStarted = true
					integerOffset = beforePoint.Length - i
				End If

				n = n*base
				n = n + d

				integerOffset = integerOffset - 1.0
			Else
				roundingDigitSet = true
				roundingDigit = d
			End If

			If digitsStarted
				digits = digits + 1.0
			End If
			i = i + 1.0
		End While

		If roundingDigitSet
			If roundingDigit >= base/2.0
				n = n + 1.0
			End If
		End If

		i = 0.0
		While i < exponent.Length
			d = exponent(i)
			e = e*base
			e = e + d
			i = i + 1.0
		End While

		If Not exponentIsPositive
			e = -e
		End If

		If Not numberIsPositive
			n = -n
		End If

		n = n*base ^ (e + integerOffset)

		Return n
	End Function


	Public Function CreateDecimalNumberFromParts(numberIsPositive As Boolean, ByRef beforePoint As Double (), ByRef afterPoint As Double (), exponentIsPositive As Boolean, ByRef exponent As Double ()) As Double
		Dim n, i, d, e, digits, integerOffset, maxDigits, roundingDigit As Double
		Dim digitsStarted, roundingDigitSet As Boolean

		n = 0.0
		e = 0.0
		digits = 0.0
		digitsStarted = false
		integerOffset = 0.0
		maxDigits = 15.0
		roundingDigitSet = false
		roundingDigit = 0.0

		' We construct an integer n, inserting one and one digit and shifting left.
		' We read up to 15 digits, but we note a 16th digit to correctly round the result.
		i = 0.0
		While i < beforePoint.Length + afterPoint.Length And digits < maxDigits + 1.0
			If i < beforePoint.Length
				d = beforePoint(i)
			Else
				d = afterPoint(i - beforePoint.Length)
			End If

			If digits < maxDigits
				If d <> 0.0
					digitsStarted = true
					integerOffset = beforePoint.Length - i
				End If

				n = n*10.0
				n = n + d

				integerOffset = integerOffset - 1.0
			Else
				roundingDigitSet = true
				roundingDigit = d
			End If

			If digitsStarted
				digits = digits + 1.0
			End If
			i = i + 1.0
		End While

		If roundingDigitSet
			If roundingDigit >= 5.0
				n = n + 1.0
			End If
		End If

		i = 0.0
		While i < exponent.Length
			d = exponent(i)
			e = e*10.0
			e = e + d
			i = i + 1.0
		End While

		If Not exponentIsPositive
			e = -e
		End If

		If Not numberIsPositive
			n = -n
		End If

		n = n*10.0 ^ (e + integerOffset)

		Return n
	End Function


	Public Function ExtractPartsFromNumberString(ByRef n As Char (), base As Double, ByRef numberIsPositive As BooleanReference, ByRef beforePoint As NumberArrayReference, ByRef afterPoint As NumberArrayReference, ByRef exponentIsPositive As BooleanReference, ByRef exponent As NumberArrayReference, ByRef message As StringReference) As Boolean
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
			message.stringx = "Number cannot have length zero.".ToCharArray()
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
				message.stringx = "Number must have at least one number after the optional sign.".ToCharArray()
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
						message.stringx = "There must be at least one digit after the decimal point.".ToCharArray()
					End If
				Else
					success = false
					message.stringx = "There must be at least one digit after the decimal point.".ToCharArray()
				End If
			ElseIf base <= 14.0 And (n(i) = "e"C Or n(i) = "E"C)
				If i < n.Length
					success = true
					afterPoint.numberArray = New Double (0 - 1){}
				Else
					success = false
					message.stringx = "There must be at least one digit after the exponent.".ToCharArray()
				End If
			Else
				success = false
				message.stringx = "Expected decimal point or exponent symbol.".ToCharArray()
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
								message.stringx = "There cannot be any characters past the exponent of the number.".ToCharArray()
							End If
						Else
							success = false
							message.stringx = "There must be at least one digit after the decimal point.".ToCharArray()
						End If
					Else
						success = false
						message.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray()
					End If
				Else
					success = false
					message.stringx = "There must be at least one digit after the exponent symbol.".ToCharArray()
				End If
			Else
				success = false
				message.stringx = "Expected exponent symbol.".ToCharArray()
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


	Public Function strSplitByWhitespace(ByRef toSplit As Char ()) As StringReference ()
		Dim parts As StringReference ()
		Dim i, skip As Double
		Dim c As Char
		Dim ll As LinkedListStrings
		Dim nextx As LinkedListCharacters
		Dim part As Char ()
		Dim split As Boolean

		ll = CreateLinkedListString()

		nextx = CreateLinkedListCharacter()
		i = 0.0
		While i < toSplit.Length
			c = toSplit(i)

			split = false
			skip = 0.0
			
			While (c = " "C Or c = vblf Or c = vbTab) And i + skip <= toSplit.Length
				If i + skip <> toSplit.Length
					c = toSplit(i + skip)
				End If
				skip = skip + 1.0
				split = true
			End While

			If split
				part = LinkedListCharactersToArray(nextx)
				Call LinkedListAddString(ll, part)
				Call FreeLinkedListCharacter(nextx)
				nextx = CreateLinkedListCharacter()
				i = i + skip - 1.0
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


	Public Function cHexadecimalDigitToCharacter(digit As Double) As Char
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
		ElseIf digit = 10.0
			c = "A"C
		ElseIf digit = 11.0
			c = "B"C
		ElseIf digit = 12.0
			c = "C"C
		ElseIf digit = 13.0
			c = "D"C
		ElseIf digit = 14.0
			c = "E"C
		ElseIf digit = 15.0
			c = "F"C
		Else
			c = "0"C
		End If

		Return c
	End Function


	Public Function cCharacterToHexadecimalDigit(c As Char) As Double
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
		ElseIf c = "A"C
			digit = 10.0
		ElseIf c = "B"C
			digit = 11.0
		ElseIf c = "C"C
			digit = 12.0
		ElseIf c = "D"C
			digit = 13.0
		ElseIf c = "E"C
			digit = 14.0
		ElseIf c = "F"C
			digit = 15.0
		Else
			digit = 0.0
		End If

		Return digit
	End Function


	Public Function GetBlack() As RGBA
		Dim black As RGBA
		black = New RGBA()
		black.a = 1.0
		black.r = 0.0
		black.g = 0.0
		black.b = 0.0
		Return black
	End Function


	Public Function GetWhite() As RGBA
		Dim white As RGBA
		white = New RGBA()
		white.a = 1.0
		white.r = 1.0
		white.g = 1.0
		white.b = 1.0
		Return white
	End Function


	Public Function GetTransparent() As RGBA
		Dim transparent As RGBA
		transparent = New RGBA()
		transparent.a = 0.0
		transparent.r = 0.0
		transparent.g = 0.0
		transparent.b = 0.0
		Return transparent
	End Function


	Public Function GetGray(percentage As Double) As RGBA
		Dim black As RGBA
		black = New RGBA()
		black.a = 1.0
		black.r = 1.0 - percentage
		black.g = 1.0 - percentage
		black.b = 1.0 - percentage
		Return black
	End Function


	Public Function CreateRGBColor(r As Double, g As Double, b As Double) As RGBA
		Dim color As RGBA
		color = New RGBA()
		color.a = 1.0
		color.r = r
		color.g = g
		color.b = b
		Return color
	End Function


	Public Function CreateRGBAColor(r As Double, g As Double, b As Double, a As Double) As RGBA
		Dim color As RGBA
		color = New RGBA()
		color.a = a
		color.r = r
		color.g = g
		color.b = b
		Return color
	End Function


	Public Function CreateImage(w As Double, h As Double, ByRef color As RGBA) As RGBABitmapImage
		Dim image As RGBABitmapImage
		Dim i, j As Double

		image = New RGBABitmapImage()
		image.x = New RGBABitmap (w - 1){}
		i = 0.0
		While i < w
			image.x(i) = New RGBABitmap()
			image.x(i).y = New RGBA (h - 1){}
			j = 0.0
			While j < h
				image.x(i).y(j) = New RGBA()
				Call SetPixel(image, i, j, color)
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return image
	End Function


	Public Sub DeleteImage(ByRef image As RGBABitmapImage)
		Dim i, j, w, h As Double

		w = ImageWidth(image)
		h = ImageHeight(image)

		i = 0.0
		While i < w
			j = 0.0
			While j < h
				image.x(i).y(j) = Nothing
				j = j + 1.0
			End While
			image.x(i) = Nothing
			i = i + 1.0
		End While
		image = Nothing
	End Sub


	Public Function ImageWidth(ByRef image As RGBABitmapImage) As Double
		Return image.x.Length
	End Function


	Public Function ImageHeight(ByRef image As RGBABitmapImage) As Double
		Dim height As Double

		If ImageWidth(image) = 0.0
			height = 0.0
		Else
			height = image.x(0).y.Length
		End If

		Return height
	End Function


	Public Sub SetPixel(ByRef image As RGBABitmapImage, x As Double, y As Double, ByRef color As RGBA)
		If x >= 0.0 And x < ImageWidth(image) And y >= 0.0 And y < ImageHeight(image)
			image.x(x).y(y).a = color.a
			image.x(x).y(y).r = color.r
			image.x(x).y(y).g = color.g
			image.x(x).y(y).b = color.b
		End If
	End Sub


	Public Sub DrawPixel(ByRef image As RGBABitmapImage, x As Double, y As Double, ByRef color As RGBA)
		Dim ra, ga, ba, aa As Double
		Dim rb, gb, bb, ab As Double
		Dim ro, go, bo, ao As Double
		Dim c As RGBA

		If x >= 0.0 And x < ImageWidth(image) And y >= 0.0 And y < ImageHeight(image)
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

			image.x(x).y(y).r = ro
			image.x(x).y(y).g = go
			image.x(x).y(y).b = bo
			image.x(x).y(y).a = ao
		End If
	End Sub


	Public Function CombineAlpha(asx As Double, ad As Double) As Double
		Return asx + ad*(1.0 - asx)
	End Function


	Public Function AlphaBlend(cs As Double, asx As Double, cd As Double, ad As Double, ao As Double) As Double
		Return (cs*asx + cd*ad*(1.0 - asx))/ao
	End Function


	Public Sub DrawHorizontalLine1px(ByRef image As RGBABitmapImage, x As Double, y As Double, length As Double, ByRef color As RGBA)
		Dim i As Double

		i = 0.0
		While i < length
			Call DrawPixel(image, x + i, y, color)
			i = i + 1.0
		End While
	End Sub


	Public Sub DrawVerticalLine1px(ByRef image As RGBABitmapImage, x As Double, y As Double, height As Double, ByRef color As RGBA)
		Dim i As Double

		i = 0.0
		While i < height
			Call DrawPixel(image, x, y + i, color)
			i = i + 1.0
		End While
	End Sub


	Public Sub DrawRectangle1px(ByRef image As RGBABitmapImage, x As Double, y As Double, width As Double, height As Double, ByRef color As RGBA)
		Call DrawHorizontalLine1px(image, x, y, width + 1.0, color)
		Call DrawVerticalLine1px(image, x, y + 1.0, height + 1.0 - 1.0, color)
		Call DrawVerticalLine1px(image, x + width, y + 1.0, height + 1.0 - 1.0, color)
		Call DrawHorizontalLine1px(image, x + 1.0, y + height, width + 1.0 - 2.0, color)
	End Sub


	Public Sub DrawImageOnImage(ByRef dst As RGBABitmapImage, ByRef src As RGBABitmapImage, topx As Double, topy As Double)
		Dim y, x As Double

		y = 0.0
		While y < ImageHeight(src)
			x = 0.0
			While x < ImageWidth(src)
				If topx + x >= 0.0 And topx + x < ImageWidth(dst) And topy + y >= 0.0 And topy + y < ImageHeight(dst)
					Call DrawPixel(dst, topx + x, topy + y, GetImagePixel(src, x, y))
				End If
				x = x + 1.0
			End While
			y = y + 1.0
		End While
	End Sub


	Public Sub DrawLine1px(ByRef image As RGBABitmapImage, x0 As Double, y0 As Double, x1 As Double, y1 As Double, ByRef color As RGBA)
		Call XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color)
	End Sub


	Public Sub XiaolinWusLineAlgorithm(ByRef image As RGBABitmapImage, x0 As Double, y0 As Double, x1 As Double, y1 As Double, ByRef color As RGBA)
		Dim steep As Boolean
		Dim x, t, dx, dy, g, xEnd, yEnd, xGap, xpxl1, ypxl1, intery, xpxl2, ypxl2, olda As Double

		olda = color.a

		steep = Abs(y1 - y0) > Abs(x1 - x0)

		If steep
			t = x0
			x0 = y0
			y0 = t

			t = x1
			x1 = y1
			y1 = t
		End If
		If x0 > x1
			t = x0
			x0 = x1
			x1 = t

			t = y0
			y0 = y1
			y1 = t
		End If

		dx = x1 - x0
		dy = y1 - y0
		g = dy/dx

		If dx = 0.0
			g = 1.0
		End If

		xEnd = Roundx(x0)
		yEnd = y0 + g*(xEnd - x0)
		xGap = OneMinusFractionalPart(x0 + 0.5)
		xpxl1 = xEnd
		ypxl1 = Floor(yEnd)
		If steep
			Call DrawPixel(image, ypxl1, xpxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
			Call DrawPixel(image, ypxl1 + 1.0, xpxl1, SetBrightness(color, FractionalPart(yEnd)*xGap))
		Else
			Call DrawPixel(image, xpxl1, ypxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
			Call DrawPixel(image, xpxl1, ypxl1 + 1.0, SetBrightness(color, FractionalPart(yEnd)*xGap))
		End If
		intery = yEnd + g

		xEnd = Roundx(x1)
		yEnd = y1 + g*(xEnd - x1)
		xGap = FractionalPart(x1 + 0.5)
		xpxl2 = xEnd
		ypxl2 = Floor(yEnd)
		If steep
			Call DrawPixel(image, ypxl2, xpxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
			Call DrawPixel(image, ypxl2 + 1.0, xpxl2, SetBrightness(color, FractionalPart(yEnd)*xGap))
		Else
			Call DrawPixel(image, xpxl2, ypxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
			Call DrawPixel(image, xpxl2, ypxl2 + 1.0, SetBrightness(color, FractionalPart(yEnd)*xGap))
		End If

		If steep
			x = xpxl1 + 1.0
			While x <= xpxl2 - 1.0
				Call DrawPixel(image, Floor(intery), x, SetBrightness(color, OneMinusFractionalPart(intery)))
				Call DrawPixel(image, Floor(intery) + 1.0, x, SetBrightness(color, FractionalPart(intery)))
				intery = intery + g
				x = x + 1.0
			End While
		Else
			x = xpxl1 + 1.0
			While x <= xpxl2 - 1.0
				Call DrawPixel(image, x, Floor(intery), SetBrightness(color, OneMinusFractionalPart(intery)))
				Call DrawPixel(image, x, Floor(intery) + 1.0, SetBrightness(color, FractionalPart(intery)))
				intery = intery + g
				x = x + 1.0
			End While
		End If

		color.a = olda
	End Sub


	Public Function OneMinusFractionalPart(x As Double) As Double
		Return 1.0 - FractionalPart(x)
	End Function


	Public Function FractionalPart(x As Double) As Double
		Return x - Floor(x)
	End Function


	Public Function SetBrightness(ByRef color As RGBA, newBrightness As Double) As RGBA
		color.a = newBrightness
		Return color
	End Function


	Public Sub DrawQuadraticBezierCurve(ByRef image As RGBABitmapImage, x0 As Double, y0 As Double, cx As Double, cy As Double, x1 As Double, y1 As Double, ByRef color As RGBA)
		Dim t, dt, dx, dy As Double
		Dim xs, ys, xe, ye As NumberReference

		dx = Abs(x0 - x1)
		dy = Abs(y0 - y1)

		dt = 1.0/Sqrt(dx ^ 2.0 + dy ^ 2.0)

		xs = New NumberReference()
		ys = New NumberReference()
		xe = New NumberReference()
		ye = New NumberReference()

		Call QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, 0.0, xs, ys)
		t = dt
		While t <= 1.0
			Call QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, xe, ye)
			Call DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color)
			xs.numberValue = xe.numberValue
			ys.numberValue = ye.numberValue
			t = t + dt
		End While

		xs = Nothing
		ys = Nothing
		xe = Nothing
		ye = Nothing
	End Sub


	Public Sub QuadraticBezierPoint(x0 As Double, y0 As Double, cx As Double, cy As Double, x1 As Double, y1 As Double, t As Double, ByRef x As NumberReference, ByRef y As NumberReference)
		x.numberValue = (1.0 - t) ^ 2.0*x0 + (1.0 - t)*2.0*t*cx + t ^ 2.0*x1
		y.numberValue = (1.0 - t) ^ 2.0*y0 + (1.0 - t)*2.0*t*cy + t ^ 2.0*y1
	End Sub


	Public Sub DrawCubicBezierCurve(ByRef image As RGBABitmapImage, x0 As Double, y0 As Double, c0x As Double, c0y As Double, c1x As Double, c1y As Double, x1 As Double, y1 As Double, ByRef color As RGBA)
		Dim t, dt, dx, dy As Double
		Dim xs, ys, xe, ye As NumberReference

		dx = Abs(x0 - x1)
		dy = Abs(y0 - y1)

		dt = 1.0/Sqrt(dx ^ 2.0 + dy ^ 2.0)

		xs = New NumberReference()
		ys = New NumberReference()
		xe = New NumberReference()
		ye = New NumberReference()

		Call CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, 0.0, xs, ys)
		t = dt
		While t <= 1.0
			Call CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, xe, ye)
			Call DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color)
			xs.numberValue = xe.numberValue
			ys.numberValue = ye.numberValue
			t = t + dt
		End While

		xs = Nothing
		ys = Nothing
		xe = Nothing
		ye = Nothing
	End Sub


	Public Sub CubicBezierPoint(x0 As Double, y0 As Double, c0x As Double, c0y As Double, c1x As Double, c1y As Double, x1 As Double, y1 As Double, t As Double, ByRef x As NumberReference, ByRef y As NumberReference)
		x.numberValue = (1.0 - t) ^ 3.0*x0 + (1.0 - t) ^ 2.0*3.0*t*c0x + (1.0 - t)*3.0*t ^ 2.0*c1x + t ^ 3.0*x1

		y.numberValue = (1.0 - t) ^ 3.0*y0 + (1.0 - t) ^ 2.0*3.0*t*c0y + (1.0 - t)*3.0*t ^ 2.0*c1y + t ^ 3.0*y1
	End Sub


	Public Function CopyImage(ByRef image As RGBABitmapImage) As RGBABitmapImage
		Dim copy As RGBABitmapImage
		Dim i, j As Double

		copy = CreateImage(ImageWidth(image), ImageHeight(image), GetTransparent())

		i = 0.0
		While i < ImageWidth(image)
			j = 0.0
			While j < ImageHeight(image)
				Call SetPixel(copy, i, j, GetImagePixel(image, i, j))
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return copy
	End Function


	Public Function GetImagePixel(ByRef image As RGBABitmapImage, x As Double, y As Double) As RGBA
		Return image.x(x).y(y)
	End Function


	Public Sub HorizontalFlip(ByRef img As RGBABitmapImage)
		Dim y, x As Double
		Dim tmp As Double
		Dim c1, c2 As RGBA

		y = 0.0
		While y < ImageHeight(img)
			x = 0.0
			While x < ImageWidth(img)/2.0
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
			End While
			y = y + 1.0
		End While
	End Sub


	Public Sub DrawFilledRectangle(ByRef image As RGBABitmapImage, x As Double, y As Double, w As Double, h As Double, ByRef color As RGBA)
		Dim i, j As Double

		i = 0.0
		While i < w
			j = 0.0
			While j < h
				Call SetPixel(image, x + i, y + j, color)
				j = j + 1.0
			End While
			i = i + 1.0
		End While
	End Sub


	Public Function RotateAntiClockwise90Degrees(ByRef image As RGBABitmapImage) As RGBABitmapImage
		Dim rotated As RGBABitmapImage
		Dim x, y As Double

		rotated = CreateImage(ImageHeight(image), ImageWidth(image), GetBlack())

		y = 0.0
		While y < ImageHeight(image)
			x = 0.0
			While x < ImageWidth(image)
				Call SetPixel(rotated, y, ImageWidth(image) - 1.0 - x, GetImagePixel(image, x, y))
				x = x + 1.0
			End While
			y = y + 1.0
		End While

		Return rotated
	End Function


	Public Sub DrawCircle(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, radius As Double, ByRef color As RGBA)
		Call DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color)
	End Sub


	Public Sub BresenhamsCircleDrawingAlgorithm(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, radius As Double, ByRef color As RGBA)
		Dim x, y, delta As Double

		y = radius
		x = 0.0

		delta = 3.0 - 2.0*radius
		
		While y >= x
			Call DrawLine1px(canvas, xCenter + x, yCenter + y, xCenter + x, yCenter + y, color)
			Call DrawLine1px(canvas, xCenter + x, yCenter - y, xCenter + x, yCenter - y, color)
			Call DrawLine1px(canvas, xCenter - x, yCenter + y, xCenter - x, yCenter + y, color)
			Call DrawLine1px(canvas, xCenter - x, yCenter - y, xCenter - x, yCenter - y, color)

			Call DrawLine1px(canvas, xCenter - y, yCenter + x, xCenter - y, yCenter + x, color)
			Call DrawLine1px(canvas, xCenter - y, yCenter - x, xCenter - y, yCenter - x, color)
			Call DrawLine1px(canvas, xCenter + y, yCenter + x, xCenter + y, yCenter + x, color)
			Call DrawLine1px(canvas, xCenter + y, yCenter - x, xCenter + y, yCenter - x, color)

			If delta < 0.0
				delta = delta + 4.0*x + 6.0
			Else
				delta = delta + 4.0*(x - y) + 10.0
				y = y - 1.0
			End If
			x = x + 1.0
		End While
	End Sub


	Public Sub DrawCircleMidpointAlgorithm(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, radius As Double, ByRef color As RGBA)
		Dim d, x, y As Double

		d = Floor((5.0 - radius*4.0)/4.0)
		x = 0.0
		y = radius

		
		While x <= y
			Call DrawPixel(canvas, xCenter + x, yCenter + y, color)
			Call DrawPixel(canvas, xCenter + x, yCenter - y, color)
			Call DrawPixel(canvas, xCenter - x, yCenter + y, color)
			Call DrawPixel(canvas, xCenter - x, yCenter - y, color)
			Call DrawPixel(canvas, xCenter + y, yCenter + x, color)
			Call DrawPixel(canvas, xCenter + y, yCenter - x, color)
			Call DrawPixel(canvas, xCenter - y, yCenter + x, color)
			Call DrawPixel(canvas, xCenter - y, yCenter - x, color)

			If d < 0.0
				d = d + 2.0*x + 1.0
			Else
				d = d + 2.0*(x - y) + 1.0
				y = y - 1.0
			End If
			x = x + 1.0
		End While
	End Sub


	Public Sub DrawCircleBasicAlgorithm(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, radius As Double, ByRef color As RGBA)
		Dim pixels, a, da, dx, dy As Double

		' Place the circle in the center of the pixel.
		xCenter = Floor(xCenter) + 0.5
		yCenter = Floor(yCenter) + 0.5

		pixels = 2.0*Pi*radius

		' Below a radius of 10 pixels, over-compensate to get a smoother circle.
		If radius < 10.0
			pixels = pixels*10.0
		End If

		da = 2.0*Pi/pixels

		a = 0.0
		While a < 2.0*Pi
			dx = Cos(a)*radius
			dy = Sin(a)*radius

			' Floor to get the pixel coordinate.
			Call DrawPixel(canvas, Floor(xCenter + dx), Floor(yCenter + dy), color)
			a = a + da
		End While
	End Sub


	Public Sub DrawFilledCircle(ByRef canvas As RGBABitmapImage, x As Double, y As Double, r As Double, ByRef color As RGBA)
		Call DrawFilledCircleBasicAlgorithm(canvas, x, y, r, color)
	End Sub


	Public Sub DrawFilledCircleMidpointAlgorithm(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, radius As Double, ByRef color As RGBA)
		Dim d, x, y As Double

		d = Floor((5.0 - radius*4.0)/4.0)
		x = 0.0
		y = radius

		
		While x <= y
			Call DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter + y, xCenter - x, yCenter + y, color)
			Call DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter - y, xCenter - x, yCenter - y, color)
			Call DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter + x, xCenter - y, yCenter + x, color)
			Call DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter - x, xCenter - y, yCenter - x, color)

			If d < 0.0
				d = d + 2.0*x + 1.0
			Else
				d = d + 2.0*(x - y) + 1.0
				y = y - 1.0
			End If
			x = x + 1.0
		End While
	End Sub


	Public Sub DrawFilledCircleBasicAlgorithm(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, radius As Double, ByRef color As RGBA)
		Dim pixels, a, da, dx, dy As Double

		' Place the circle in the center of the pixel.
		xCenter = Floor(xCenter) + 0.5
		yCenter = Floor(yCenter) + 0.5

		pixels = 2.0*Pi*radius

		' Below a radius of 10 pixels, over-compensate to get a smoother circle.
		If radius < 10.0
			pixels = pixels*10.0
		End If

		da = 2.0*Pi/pixels

		' Draw lines for a half-circle to fill an entire circle.
		a = 0.0
		While a < Pi
			dx = Cos(a)*radius
			dy = Sin(a)*radius

			' Floor to get the pixel coordinate.
			Call DrawVerticalLine1px(canvas, Floor(xCenter - dx), Floor(yCenter - dy), Floor(2.0*dy) + 1.0, color)
			a = a + da
		End While
	End Sub


	Public Sub DrawTriangle(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, height As Double, ByRef color As RGBA)
		Dim x1, y1, x2, y2, x3, y3 As Double

		x1 = Floor(xCenter + 0.5)
		y1 = Floor(Floor(yCenter + 0.5) - height)
		x2 = x1 - 2.0*height*Tan(Pi/6.0)
		y2 = Floor(y1 + 2.0*height)
		x3 = x1 + 2.0*height*Tan(Pi/6.0)
		y3 = Floor(y1 + 2.0*height)

		Call DrawLine1px(canvas, x1, y1, x2, y2, color)
		Call DrawLine1px(canvas, x1, y1, x3, y3, color)
		Call DrawLine1px(canvas, x2, y2, x3, y3, color)
	End Sub


	Public Sub DrawFilledTriangle(ByRef canvas As RGBABitmapImage, xCenter As Double, yCenter As Double, height As Double, ByRef color As RGBA)
		Dim i, offset, x1, y1 As Double

		x1 = Floor(xCenter + 0.5)
		y1 = Floor(Floor(yCenter + 0.5) - height)

		i = 0.0
		While i <= 2.0*height
			offset = Floor(i*Tan(Pi/6.0))
			Call DrawHorizontalLine1px(canvas, x1 - offset, y1 + i, 2.0*offset, color)
			i = i + 1.0
		End While
	End Sub


	Public Sub DrawLine(ByRef canvas As RGBABitmapImage, x1 As Double, y1 As Double, x2 As Double, y2 As Double, thickness As Double, ByRef color As RGBA)
		Call DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color)
	End Sub


	Public Sub DrawLineBresenhamsAlgorithmThick(ByRef canvas As RGBABitmapImage, x1 As Double, y1 As Double, x2 As Double, y2 As Double, thickness As Double, ByRef color As RGBA)
		Dim x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r As Double

		dx = x2 - x1
		dy = y2 - y1

		incX = Signx(dx)
		incY = Signx(dy)

		dx = Abs(dx)
		dy = Abs(dy)

		If dx > dy
			pdx = incX
			pdy = 0.0
			es = dy
			el = dx
		Else
			pdx = 0.0
			pdy = incY
			es = dx
			el = dy
		End If

		x = x1
		y = y1
		err = el/2.0

		If thickness >= 3.0
			r = thickness/2.0
			Call DrawCircle(canvas, x, y, r, color)
		ElseIf Floor(thickness) = 2.0
			Call DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
		ElseIf Floor(thickness) = 1.0
			Call DrawPixel(canvas, x, y, color)
		End If

		t = 0.0
		While t < el
			err = err - es
			If err < 0.0
				err = err + el
				x = x + incX
				y = y + incY
			Else
				x = x + pdx
				y = y + pdy
			End If

			If thickness >= 3.0
				r = thickness/2.0
				Call DrawCircle(canvas, x, y, r, color)
			ElseIf Floor(thickness) = 2.0
				Call DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
			ElseIf Floor(thickness) = 1.0
				Call DrawPixel(canvas, x, y, color)
			End If
			t = t + 1.0
		End While
	End Sub


	Public Sub DrawLineBresenhamsAlgorithm(ByRef canvas As RGBABitmapImage, x1 As Double, y1 As Double, x2 As Double, y2 As Double, ByRef color As RGBA)
		Dim x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t As Double

		dx = x2 - x1
		dy = y2 - y1

		incX = Signx(dx)
		incY = Signx(dy)

		dx = Abs(dx)
		dy = Abs(dy)

		If dx > dy
			pdx = incX
			pdy = 0.0
			es = dy
			el = dx
		Else
			pdx = 0.0
			pdy = incY
			es = dx
			el = dy
		End If

		x = x1
		y = y1
		err = el/2.0
		Call DrawPixel(canvas, x, y, color)

		t = 0.0
		While t < el
			err = err - es
			If err < 0.0
				err = err + el
				x = x + incX
				y = y + incY
			Else
				x = x + pdx
				y = y + pdy
			End If

			Call DrawPixel(canvas, x, y, color)
			t = t + 1.0
		End While
	End Sub


	Public Sub DrawLineBresenhamsAlgorithmThickPatterned(ByRef canvas As RGBABitmapImage, x1 As Double, y1 As Double, x2 As Double, y2 As Double, thickness As Double, ByRef pattern As Boolean (), ByRef offset As NumberReference, ByRef color As RGBA)
		Dim x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r As Double

		dx = x2 - x1
		dy = y2 - y1

		incX = Signx(dx)
		incY = Signx(dy)

		dx = Abs(dx)
		dy = Abs(dy)

		If dx > dy
			pdx = incX
			pdy = 0.0
			es = dy
			el = dx
		Else
			pdx = 0.0
			pdy = incY
			es = dx
			el = dy
		End If

		x = x1
		y = y1
		err = el/2.0

		offset.numberValue = (offset.numberValue + 1.0) Mod (pattern.Length*thickness)

		If pattern(Floor(offset.numberValue/thickness))
			If thickness >= 3.0
				r = thickness/2.0
				Call DrawCircle(canvas, x, y, r, color)
			ElseIf Floor(thickness) = 2.0
				Call DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
			ElseIf Floor(thickness) = 1.0
				Call DrawPixel(canvas, x, y, color)
			End If
		End If

		t = 0.0
		While t < el
			err = err - es
			If err < 0.0
				err = err + el
				x = x + incX
				y = y + incY
			Else
				x = x + pdx
				y = y + pdy
			End If

			offset.numberValue = (offset.numberValue + 1.0) Mod (pattern.Length*thickness)

			If pattern(Floor(offset.numberValue/thickness))
				If thickness >= 3.0
					r = thickness/2.0
					Call DrawCircle(canvas, x, y, r, color)
				ElseIf Floor(thickness) = 2.0
					Call DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
				ElseIf Floor(thickness) = 1.0
					Call DrawPixel(canvas, x, y, color)
				End If
			End If
			t = t + 1.0
		End While
	End Sub


	Public Function GetLinePattern5() As Boolean ()
		Dim pattern As Boolean ()

		pattern = New Boolean (19 - 1){}

		pattern(0) = true
		pattern(1) = true
		pattern(2) = true
		pattern(3) = true
		pattern(4) = true
		pattern(5) = true
		pattern(6) = true
		pattern(7) = true
		pattern(8) = true
		pattern(9) = true
		pattern(10) = false
		pattern(11) = false
		pattern(12) = false
		pattern(13) = true
		pattern(14) = true
		pattern(15) = true
		pattern(16) = false
		pattern(17) = false
		pattern(18) = false

		Return pattern
	End Function


	Public Function GetLinePattern4() As Boolean ()
		Dim pattern As Boolean ()

		pattern = New Boolean (13 - 1){}

		pattern(0) = true
		pattern(1) = true
		pattern(2) = true
		pattern(3) = true
		pattern(4) = true
		pattern(5) = true
		pattern(6) = true
		pattern(7) = true
		pattern(8) = true
		pattern(9) = true
		pattern(10) = false
		pattern(11) = false
		pattern(12) = false

		Return pattern
	End Function


	Public Function GetLinePattern3() As Boolean ()
		Dim pattern As Boolean ()

		pattern = New Boolean (13 - 1){}

		pattern(0) = true
		pattern(1) = true
		pattern(2) = true
		pattern(3) = true
		pattern(4) = true
		pattern(5) = true
		pattern(6) = false
		pattern(7) = false
		pattern(8) = false
		pattern(9) = true
		pattern(10) = true
		pattern(11) = false
		pattern(12) = false

		Return pattern
	End Function


	Public Function GetLinePattern2() As Boolean ()
		Dim pattern As Boolean ()

		pattern = New Boolean (4 - 1){}

		pattern(0) = true
		pattern(1) = true
		pattern(2) = false
		pattern(3) = false

		Return pattern
	End Function


	Public Function GetLinePattern1() As Boolean ()
		Dim pattern As Boolean ()

		pattern = New Boolean (8 - 1){}

		pattern(0) = true
		pattern(1) = true
		pattern(2) = true
		pattern(3) = true
		pattern(4) = true
		pattern(5) = false
		pattern(6) = false
		pattern(7) = false

		Return pattern
	End Function


	Public Function Blur(ByRef src As RGBABitmapImage, pixels As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim x, y, w, h As Double

		w = ImageWidth(src)
		h = ImageHeight(src)
		dst = CreateImage(w, h, GetTransparent())

		x = 0.0
		While x < w
			y = 0.0
			While y < h
				Call SetPixel(dst, x, y, CreateBlurForPoint(src, x, y, pixels))
				y = y + 1.0
			End While
			x = x + 1.0
		End While

		Return dst
	End Function


	Public Function CreateBlurForPoint(ByRef src As RGBABitmapImage, x As Double, y As Double, pixels As Double) As RGBA
		Dim rgba As RGBA
		Dim i, j, countColor, countTransparent As Double
		Dim fromx, toxx, fromy, toy As Double
		Dim w, h As Double
		Dim alpha As Double

		w = ImageWidth(src)
		h = ImageHeight(src)

		rgba = New RGBA()
		rgba.r = 0.0
		rgba.g = 0.0
		rgba.b = 0.0
		rgba.a = 0.0

		fromx = x - pixels
		fromx = Max(fromx, 0.0)

		toxx = x + pixels
		toxx = Min(toxx, w - 1.0)

		fromy = y - pixels
		fromy = Max(fromy, 0.0)

		toy = y + pixels
		toy = Min(toy, h - 1.0)

		countColor = 0.0
		countTransparent = 0.0
		i = fromx
		While i < toxx
			j = fromy
			While j < toy
				alpha = src.x(i).y(j).a
				If alpha > 0.0
					rgba.r = rgba.r + src.x(i).y(j).r
					rgba.g = rgba.g + src.x(i).y(j).g
					rgba.b = rgba.b + src.x(i).y(j).b
					countColor = countColor + 1.0
				End If
				rgba.a = rgba.a + alpha
				countTransparent = countTransparent + 1.0
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		If countColor > 0.0
			rgba.r = rgba.r/countColor
			rgba.g = rgba.g/countColor
			rgba.b = rgba.b/countColor
		Else
			rgba.r = 0.0
			rgba.g = 0.0
			rgba.b = 0.0
		End If

		If countTransparent > 0.0
			rgba.a = rgba.a/countTransparent
		Else
			rgba.a = 0.0
		End If

		Return rgba
	End Function


	Public Function ScaleNearestNeighborFloorFactor(ByRef src As RGBABitmapImage, factor As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim w, h, newWidth, newHeight As Double

		w = ImageWidth(src)
		h = ImageHeight(src)

		newWidth = Roundx(w*factor)
		newHeight = Roundx(h*factor)

		dst = ScaleNearestNeighborFloor(src, newWidth, newHeight)

		Return dst
	End Function


	Public Function ScaleNearestNeighborFloor(ByRef src As RGBABitmapImage, newWidth As Double, newHeight As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim x, y As Double

		dst = CreateImage(newWidth, newHeight, GetTransparent())

		x = 0.0
		While x < newWidth
			y = 0.0
			While y < newHeight
				Call SetPixel(dst, x, y, GetNearestNeighborFloor(src, dst, x, y))
				y = y + 1.0
			End While
			x = x + 1.0
		End While

		Return dst
	End Function


	Public Function GetNearestNeighborFloor(ByRef src As RGBABitmapImage, ByRef dst As RGBABitmapImage, x As Double, y As Double) As RGBA
		Dim nnx, nny, srcw, srch, dstw, dsth As Double

		srcw = ImageWidth(src)
		srch = ImageHeight(src)
		dstw = ImageWidth(dst)
		dsth = ImageHeight(dst)

		nnx = Floor(x*srcw/dstw)
		nny = Floor(y*srch/dsth)

		Return src.x(nnx).y(nny)
	End Function


	Public Function ScaleNearestNeighborFactor(ByRef src As RGBABitmapImage, factor As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim w, h, newWidth, newHeight As Double

		w = ImageWidth(src)
		h = ImageHeight(src)

		newWidth = Roundx(w*factor)
		newHeight = Roundx(h*factor)

		dst = ScaleNearestNeighbor(src, newWidth, newHeight)

		Return dst
	End Function


	Public Function ScaleNearestNeighbor(ByRef src As RGBABitmapImage, newWidth As Double, newHeight As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim x, y As Double

		dst = CreateImage(newWidth, newHeight, GetTransparent())

		x = 0.0
		While x < newWidth
			y = 0.0
			While y < newHeight
				Call SetPixel(dst, x, y, GetNearestNeighbor(src, dst, x, y))
				y = y + 1.0
			End While
			x = x + 1.0
		End While

		Return dst
	End Function


	Public Function GetNearestNeighbor(ByRef src As RGBABitmapImage, ByRef dst As RGBABitmapImage, x As Double, y As Double) As RGBA
		Dim nnx, nny, srcw, srch, dstw, dsth As Double

		srcw = ImageWidth(src)
		srch = ImageHeight(src)
		dstw = ImageWidth(dst)
		dsth = ImageHeight(dst)

		nnx = Min(Roundx(x*srcw/dstw), srcw - 1.0)
		nny = Min(Roundx(y*srch/dsth), srch - 1.0)

		Return src.x(nnx).y(nny)
	End Function


	Public Function BilinaerScaleUpFactor(ByRef src As RGBABitmapImage, factor As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim w, h, newWidth, newHeight As Double

		w = ImageWidth(src)
		h = ImageHeight(src)

		newWidth = Roundx(w*factor)
		newHeight = Roundx(h*factor)

		dst = BilinaerScaleUp(src, newWidth, newHeight)

		Return dst
	End Function


	Public Function BilinaerScaleUp(ByRef src As RGBABitmapImage, newWidth As Double, newHeight As Double) As RGBABitmapImage
		Dim dst As RGBABitmapImage
		Dim x, y As Double

		dst = CreateImage(newWidth, newHeight, GetTransparent())

		y = 0.0
		While y < newHeight
			x = 0.0
			While x < newWidth
				Call SetPixel(dst, x, y, GetBilinearlyScaledPixel(src, dst, x, y))
				x = x + 1.0
			End While
			y = y + 1.0
		End While

		Return dst
	End Function


	Public Function GetBilinearlyScaledPixel(ByRef src As RGBABitmapImage, ByRef dst As RGBABitmapImage, dstx As Double, dsty As Double) As RGBA
		Dim x1, y1, x2, y2, srcw, srch, dstw, dsth As Double
		Dim x1y1, x2y1, x1y2, x2y2 As RGBA
		Dim result As RGBA
		Dim x, y As Double

		srcw = ImageWidth(src)
		srch = ImageHeight(src)
		dstw = ImageWidth(dst)
		dsth = ImageHeight(dst)

		x = dstx*srcw/dstw
		y = dsty*srch/dsth

		x = x + 0.25
		y = y + 0.25

		x1 = Min(Floor(x), srcw - 1.0)
		x2 = Min(Ceiling(x), srcw - 1.0)
		y1 = Min(Floor(y), srch - 1.0)
		y2 = Min(Ceiling(y), srch - 1.0)

		x1y1 = src.x(x1).y(y1)
		x1y2 = src.x(x1).y(y2)
		x2y1 = src.x(x2).y(y1)
		x2y2 = src.x(x2).y(y2)

		If x1 = x2
			x2 = x2 + 1.0
		End If
		If y1 = y2
			y2 = y2 + 1.0
		End If

		result = New RGBA()

		result.r = GetBilinearInterpolation(x1y1.r, x2y1.r, x1y2.r, x2y2.r, x, y, x1, x2, y1, y2)
		result.g = GetBilinearInterpolation(x1y1.g, x2y1.g, x1y2.g, x2y2.g, x, y, x1, x2, y1, y2)
		result.b = GetBilinearInterpolation(x1y1.b, x2y1.b, x1y2.b, x2y2.b, x, y, x1, x2, y1, y2)
		result.a = GetBilinearInterpolation(x1y1.a, x2y1.a, x1y2.a, x2y2.a, x, y, x1, x2, y1, y2)

		Return result
	End Function


	Public Function GetBilinearInterpolation(q11 As Double, q12 As Double, q21 As Double, q22 As Double, x As Double, y As Double, x1 As Double, x2 As Double, y1 As Double, y2 As Double) As Double
		Dim h1, h2, v As Double

		h1 = (x2 - x)/(x2 - x1)*q11 + (x - x1)/(x2 - x1)*q12
		h2 = (x2 - x)/(x2 - x1)*q21 + (x - x1)/(x2 - x1)*q22

		v = (y2 - y)/(y2 - y1)*h1 + (y - y1)/(y2 - y1)*h2

		Return v
	End Function


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


	Public Function DigitDataBase16() As Char ()
		Return "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe891412108153069c4ffffffffffffffffffffffffffffffffffffffff9409000000000000000049e7ffffffffffffffffffffffffffffffffff61000000000000000000000017ddffffffffffffffffffffffffffffff840000000573d3f5e5a62b00000028f0ffffffffffffffffffffffffffda04000008bcfffffffffff44200000073ffffffffffffffffffffffffff5700000088ffffffffffffffe812000008e3ffffffffffffffffffffffea02000015f9ffffffffffffffff8100000080ffffffffffffffffffffff9c00000072ffffffffffffffffffe40100002fffffffffffffffffffffff51000000b8ffffffffffffffffffff2a000000e2ffffffffffffffffffff21000001f0ffffffffffffffffffff65000000b3fffffffffffffffffff602000018ffffffffffffffffffffff8b0000008affffffffffffffffffd200000036ffffffffffffffffffffffa900000063ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffb500000057ffffffffffffffffffffffc900000046ffffffffffffffffffa90000005fffffffffffffffffffffffd20000003affffffffffffffffffa900000060ffffffffffffffffffffffd30000003affffffffffffffffffb400000057ffffffffffffffffffffffca00000046ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffd100000037ffffffffffffffffffffffa900000063fffffffffffffffffff602000019ffffffffffffffffffffff8b00000089ffffffffffffffffffff21000001f1ffffffffffffffffffff66000000b3ffffffffffffffffffff50000000b8ffffffffffffffffffff2a000000e1ffffffffffffffffffff9c00000073ffffffffffffffffffe40100002fffffffffffffffffffffffea02000015f9ffffffffffffffff8200000080ffffffffffffffffffffffff5700000088ffffffffffffffe812000008e2ffffffffffffffffffffffffda04000008bcfffffffffff44300000073ffffffffffffffffffffffffffff830000000674d3f6e6a72b00000028f0ffffffffffffffffffffffffffffff60000000000000000000000016ddfffffffffffffffffffffffffffffffffe9309000000000000000048e6ffffffffffffffffffffffffffffffffffffffe88f3f1f07132e68c3fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9d7b28e69441f02000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6a274c7095b9de64000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000affffffffffffffffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffd48b56271005142a5ea0f6ffffffffffffffffffffffffffffffffdb7c20000000000000000000001392feffffffffffffffffffffffffffff1f00000000000000000000000000004cf9ffffffffffffffffffffffffff1f0000003784c7e7f9e8b1480000000056ffffffffffffffffffffffffff1f015accffffffffffffffff9701000000b0ffffffffffffffffffffffff58caffffffffffffffffffffff770000003cfffffffffffffffffffffffffffffffffffffffffffffffffff107000002edffffffffffffffffffffffffffffffffffffffffffffffffff3a000000ccffffffffffffffffffffffffffffffffffffffffffffffffff4c000000baffffffffffffffffffffffffffffffffffffffffffffffffff32000000cbffffffffffffffffffffffffffffffffffffffffffffffffec05000002edffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffeb140000009affffffffffffffffffffffffffffffffffffffffffffffff520000002afbffffffffffffffffffffffffffffffffffffffffffffff8c00000003c7ffffffffffffffffffffffffffffffffffffffffffffffb30300000085ffffffffffffffffffffffffffffffffffffffffffffffc50a0000005dfeffffffffffffffffffffffffffffffffffffffffffffd2110000004efbffffffffffffffffffffffffffffffffffffffffffffdb1800000042f8ffffffffffffffffffffffffffffffffffffffffffffe21f00000039f3ffffffffffffffffffffffffffffffffffffffffffffe92600000030efffffffffffffffffffffffffffffffffffffffffffffee2e00000029eafffffffffffffffffffffffffffffffffffffffffffff33700000022e5fffffffffffffffffffffffffffffffffffffffffffff7410000001cdffffffffffffffffffffffffffffffffffffffffffffffb4c00000017d9fffffffffffffffffffffffffffffffffffffffffffffd5900000012d2ffffffffffffffffffffffffffffffffffffffffffffff680000000ecbffffffffffffffffffffffffffffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe2af8058392817060a1a3f74c8ffffffffffffffffffffffffffffffffeb0000000000000000000000000036cfffffffffffffffffffffffffffffeb000000000000000000000000000004a7ffffffffffffffffffffffffffeb00000f5a9dd0edfbf0ca841900000003c2ffffffffffffffffffffffffec3da8f9fffffffffffffffff0410000002bffffffffffffffffffffffffffffffffffffffffffffffffffee12000000cbffffffffffffffffffffffffffffffffffffffffffffffffff6900000090ffffffffffffffffffffffffffffffffffffffffffffffffff9600000078ffffffffffffffffffffffffffffffffffffffffffffffffff9a0000007effffffffffffffffffffffffffffffffffffffffffffffffff73000000a5fffffffffffffffffffffffffffffffffffffffffffffffff51b000009edfffffffffffffffffffffffffffffffffffffffffffffff7540000007efffffffffffffffffffffffffffffffffffffffffff3d3912400000055fcffffffffffffffffffffffffffffffffff1700000000000000001692feffffffffffffffffffffffffffffffffffff17000000000000002db8feffffffffffffffffffffffffffffffffffffff170000000000000000002bc3fffffffffffffffffffffffffffffffffffffffffffdf0cf922e00000003a5fffffffffffffffffffffffffffffffffffffffffffffffffd8700000007d1ffffffffffffffffffffffffffffffffffffffffffffffffff780000004ffffffffffffffffffffffffffffffffffffffffffffffffffff308000006f6ffffffffffffffffffffffffffffffffffffffffffffffffff3c000000d0ffffffffffffffffffffffffffffffffffffffffffffffffff4d000000c6ffffffffffffffffffffffffffffffffffffffffffffffffff35000000ddffffffffffffffffffffffffffffffffffffffffffffffffea0300000bf9ffffffffffffffffffffffffffffffffffffffffffffffff6200000054ffffffffffffffffffffff47bafefffffffffffffffffff56b00000002cbffffffffffffffffffffff0b001e71a9d7edfbf6e4ba771a000000007cffffffffffffffffffffffff0b0000000000000000000000000000017dffffffffffffffffffffffffff0b000000000000000000000000003cc8ffffffffffffffffffffffffffffe9b989593827160608162a5689dbffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffbd0100000000f3fffffffffffffffffffffffffffffffffffffffffffff3200000000000f3ffffffffffffffffffffffffffffffffffffffffffff69000000000000f3ffffffffffffffffffffffffffffffffffffffffffbf01000b0e000000f3fffffffffffffffffffffffffffffffffffffffff42100008e1f000000f3ffffffffffffffffffffffffffffffffffffffff6a000035fc1f000000f3ffffffffffffffffffffffffffffffffffffffc0010004d1ff1f000000f3fffffffffffffffffffffffffffffffffffff42200007affff1f000000f3ffffffffffffffffffffffffffffffffffff6c000026f7ffff1f000000f3ffffffffffffffffffffffffffffffffffc1010001c1ffffff1f000000f3fffffffffffffffffffffffffffffffff523000066ffffffff1f000000f3ffffffffffffffffffffffffffffffff6d000019f0ffffffff1f000000f3ffffffffffffffffffffffffffffffc2010000aeffffffffff1f000000f3fffffffffffffffffffffffffffff524000052ffffffffffff1f000000f3ffffffffffffffffffffffffffff6e00000fe6ffffffffffff1f000000f3ffffffffffffffffffffffffffc30200009affffffffffffff1f000000f3fffffffffffffffffffffffff62400003ffeffffffffffffff1f000000f3ffffffffffffffffffffffff70000008daffffffffffffffff1f000000f3fffffffffffffffffffffff602000086ffffffffffffffffff1f000000f3fffffffffffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f000008672f120514275997efffffffffffffffffffffffffffffffffff4f00000000000000000000000b73f6ffffffffffffffffffffffffffffff4f000000000000000000000000002bdeffffffffffffffffffffffffffff60538cbad2e7faf0d599370000000025ebffffffffffffffffffffffffffffffffffffffffffffffffa0090000005bffffffffffffffffffffffffffffffffffffffffffffffffffb100000001d2ffffffffffffffffffffffffffffffffffffffffffffffffff560000007effffffffffffffffffffffffffffffffffffffffffffffffffb80000003dffffffffffffffffffffffffffffffffffffffffffffffffffec00000022fffffffffffffffffffffffffffffffffffffffffffffffffffd00000011ffffffffffffffffffffffffffffffffffffffffffffffffffec00000022ffffffffffffffffffffffffffffffffffffffffffffffffffb80000003cffffffffffffffffffffffffffffffffffffffffffffffffff580000007dffffffffffffffffffffffffffffffffffffffffffffffffb301000000cfffffffffffffffffffffff4cb1fdffffffffffffffffffa40a00000058ffffffffffffffffffffffff17001a6ea9d7eefbf2d69b380000000024e8ffffffffffffffffffffffff1700000000000000000000000000002de0ffffffffffffffffffffffffff17000000000000000000000000127ef9ffffffffffffffffffffffffffffebba8a59372615050a1a3569a6f7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffca753915050d233866a3e0ffffffffffffffffffffffffffffffffffd13f0000000000000000000000f7ffffffffffffffffffffffffffffff9d07000000000000000000000000f7ffffffffffffffffffffffffffff9700000000469fdbf3f5da9e490100f7ffffffffffffffffffffffffffca0300000eb3ffffffffffffffffd84df8fffffffffffffffffffffffffa2d000007c8ffffffffffffffffffffffffffffffffffffffffffffffff9100000081ffffffffffffffffffffffffffffffffffffffffffffffffff28000010f6ffffffffffffffffffffffffffffffffffffffffffffffffc20000006affffffffffffffffffffffffffffffffffffffffffffffffff79000000b2ffffffffffffffffffffffffffffffffffffffffffffffffff43000000ebffeb903d1a0616306fc0ffffffffffffffffffffffffffffff0f000015ffa211000000000000000041dcfffffffffffffffffffffffff30000003087000000000000000000000013c6ffffffffffffffffffffffe30000000f00000055beeef7d8881000000017e6ffffffffffffffffffffd30000000000019dffffffffffffe12200000056ffffffffffffffffffffd100000000006effffffffffffffffce04000002dbffffffffffffffffffdd0000000006eaffffffffffffffffff550000008bffffffffffffffffffe90000000043ffffffffffffffffffffa90000004dfffffffffffffffffff80200000074ffffffffffffffffffffdb0000002cffffffffffffffffffff2200000088ffffffffffffffffffffef00000019ffffffffffffffffffff4d00000088ffffffffffffffffffffee0000001affffffffffffffffffff7e00000074ffffffffffffffffffffdb0000002dffffffffffffffffffffcd00000042ffffffffffffffffffffa900000052ffffffffffffffffffffff21000005e9ffffffffffffffffff5400000093ffffffffffffffffffffff8f0000006dffffffffffffffffcd04000007e6fffffffffffffffffffffff9220000019effffffffffffe1230000006cffffffffffffffffffffffffffc00600000056beeff8d888110000002af3ffffffffffffffffffffffffffffa603000000000000000000000026ddffffffffffffffffffffffffffffffffc8280000000000000000025deffffffffffffffffffffffffffffffffffffffab25a2a1106193b7ed7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff47000000000000000000000000000000000000f7ffffffffffffffffffff47000000000000000000000000000000000003faffffffffffffffffffff4700000000000000000000000000000000004afffffffffffffffffffffffffffffffffffffffffffffffffc1a000000adffffffffffffffffffffffffffffffffffffffffffffffffb300000015faffffffffffffffffffffffffffffffffffffffffffffffff5100000073ffffffffffffffffffffffffffffffffffffffffffffffffea05000000d6ffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffff2c0000009dffffffffffffffffffffffffffffffffffffffffffffffffc90000000cf3ffffffffffffffffffffffffffffffffffffffffffffffff6700000063fffffffffffffffffffffffffffffffffffffffffffffffff60f000000c6ffffffffffffffffffffffffffffffffffffffffffffffffa300000029ffffffffffffffffffffffffffffffffffffffffffffffffff410000008cffffffffffffffffffffffffffffffffffffffffffffffffdf01000005e9ffffffffffffffffffffffffffffffffffffffffffffffff7d00000052fffffffffffffffffffffffffffffffffffffffffffffffffd1e000000b5ffffffffffffffffffffffffffffffffffffffffffffffffb90000001bfcffffffffffffffffffffffffffffffffffffffffffffffff570000007bffffffffffffffffffffffffffffffffffffffffffffffffee07000001ddffffffffffffffffffffffffffffffffffffffffffffffff9300000042ffffffffffffffffffffffffffffffffffffffffffffffffff31000000a5ffffffffffffffffffffffffffffffffffffffffffffffffd000000010f7ffffffffffffffffffffffffffffffffffffffffffffffff6d0000006bfffffffffffffffffffffffffffffffffffffffffffffffff913000000ceffffffffffffffffffffffffffffffffffffffffffffffffa900000031ffffffffffffffffffffffffffffffffffffffffffffffffff4700000094ffffffffffffffffffffffffffffffffffffffffffffffffe302000008eeffffffffffffffffffffffffffffffffffffffffffffffff840000005afffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9a8602c13050c1d4882dfffffffffffffffffffffffffffffffffffffa918000000000000000000025eeeffffffffffffffffffffffffffffff780000000000000000000000000023e5ffffffffffffffffffffffffff9f0000000037a8e4faf1c66d0500000033fdfffffffffffffffffffffff81600000065fdffffffffffffc40a0000009fffffffffffffffffffffffb600000021faffffffffffffffff8d00000047ffffffffffffffffffffff820000007bffffffffffffffffffeb01000014ffffffffffffffffffffff6d000000a2ffffffffffffffffffff15000001fdffffffffffffffffffff76000000a2ffffffffffffffffffff14000007ffffffffffffffffffffffa10000007bffffffffffffffffffec01000033ffffffffffffffffffffffec08000022fbffffffffffffffff8e00000087ffffffffffffffffffffffff7d00000068fdffffffffffffc70b00001ef2fffffffffffffffffffffffffb5500000039aae5fbf2c87006000013d0fffffffffffffffffffffffffffffe93160000000000000000000153e3ffffffffffffffffffffffffffffffffffbd2e000000000000000780f0ffffffffffffffffffffffffffffffffce3500000000000000000000000e87fcffffffffffffffffffffffffffb3060000004fb2e6faf0cd82150000004ffaffffffffffffffffffffffda0b000004a9ffffffffffffffe93600000076ffffffffffffffffffffff5600000084ffffffffffffffffffe80e000005e2fffffffffffffffffff606000008f4ffffffffffffffffffff6f0000008dffffffffffffffffffcb00000039ffffffffffffffffffffffac0000005cffffffffffffffffffbc0000004affffffffffffffffffffffbe0000004dffffffffffffffffffcc00000039ffffffffffffffffffffffac0000005effffffffffffffffffea00000008f4ffffffffffffffffffff6e0000007cffffffffffffffffffff2f00000085ffffffffffffffffffe70d000000c1ffffffffffffffffffff9300000004a9ffffffffffffffe83400000028fcfffffffffffffffffffffa2d0000000050b2e7fbf2cd821400000002b8ffffffffffffffffffffffffe523000000000000000000000000000299fffffffffffffffffffffffffffff16605000000000000000000002cc5ffffffffffffffffffffffffffffffffffe88e542512040b1b3d72c1fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff8a259251008203f8be2ffffffffffffffffffffffffffffffffffffffa91d0000000000000000047ffaffffffffffffffffffffffffffffffff7b00000000000000000000000040f8ffffffffffffffffffffffffffff94000000004db9ecf7da8b1300000057ffffffffffffffffffffffffffdc050000008fffffffffffffe527000000acffffffffffffffffffffffff630000005fffffffffffffffffd406000025fbfffffffffffffffffffffb0c000002e0ffffffffffffffffff5f000000b2ffffffffffffffffffffc600000036ffffffffffffffffffffb50000005fffffffffffffffffffffa000000068ffffffffffffffffffffe700000011feffffffffffffffffff8d0000007cfffffffffffffffffffffb00000000dfffffffffffffffffff8c0000007cfffffffffffffffffffffb00000000b4ffffffffffffffffff9e00000069ffffffffffffffffffffe7000000008dffffffffffffffffffbe00000038ffffffffffffffffffffb6000000007bfffffffffffffffffff606000003e2ffffffffffffffffff62000000006fffffffffffffffffffff4f00000064ffffffffffffffffd8080000000062ffffffffffffffffffffc50000000096ffffffffffffe82b000000000064ffffffffffffffffffffff6c0000000051bbeff8dc8e1500001000000074fffffffffffffffffffffff94f0000000000000000000000288c00000084fffffffffffffffffffffffffd810b000000000000000052ea830000009fffffffffffffffffffffffffffffea8d471d090d2864c1ffff5b000000d4ffffffffffffffffffffffffffffffffffffffffffffffffff2100000dfdffffffffffffffffffffffffffffffffffffffffffffffffd900000052ffffffffffffffffffffffffffffffffffffffffffffffffff75000000b8ffffffffffffffffffffffffffffffffffffffffffffffffe30d000023fefffffffffffffffffffffffffffffffffffffffffffffff945000000b7ffffffffffffffffffffffffff7fa2fdffffffffffffffe8480000005effffffffffffffffffffffffffff63002080c4ecfae7c0740e00000034f4ffffffffffffffffffffffffffff6300000000000000000000000043f0ffffffffffffffffffffffffffffff6300000000000000000000118efdfffffffffffffffffffffffffffffffff4bb7f462b15040b25569ff4ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff".ToCharArray()
	End Function


	Public Sub DrawDigitCharacter(ByRef image As RGBABitmapImage, topx As Double, topy As Double, digit As Double)
		Dim x, y As Double
		Dim allCharData, colorChars As Char ()
		Dim colorReference As NumberReference
		Dim errorMessage As StringReference
		Dim color As RGBA

		colorReference = New NumberReference()
		errorMessage = New StringReference()
		color = New RGBA()

		colorChars = New Char (2 - 1){}

		allCharData = DigitDataBase16()

		y = 0.0
		While y < 37.0
			x = 0.0
			While x < 30.0
				colorChars(0) = allCharData(digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 0.0)
				colorChars(1) = allCharData(digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 1.0)

				Call strToUpperCase(colorChars)
				CreateNumberFromStringWithCheck(colorChars, 16.0, colorReference, errorMessage)
				color.r = colorReference.numberValue/255.0
				color.g = colorReference.numberValue/255.0
				color.b = colorReference.numberValue/255.0
				color.a = 1.0
				Call SetPixel(image, topx + x, topy + y, color)
				x = x + 1.0
			End While
			y = y + 1.0
		End While
	End Sub


	Public Function GetPixelFontData() As Char ()
		Return "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001100000011000000000000000000000011000000110000001100000011000000110000001100000011000000000000000000000000000000000000000000000000000000000000000000000000000011011000110110001101100011011000000000000000000000000000110011001100110111111110110011001100110111111110110011001100110000000000000000000000000000000000001100001111110111111111101100011111000011111100001111100011011111111110111111000011000000000000000000001110000110110001101101101110110000011000001100000110000011011101101101100011011000011100000000000000000111111100110001111110011000110110000111000001110000110110011001100110011001101100001110000000000000000000000000000000000000000000000000000000000000000000000000000011000001110000011000001110000000000000000000000110000000110000000110000001100000011000000110000001100000011000000110000011000001100000000000000000000000011000001100000110000001100000011000000110000001100000011000000110000000110000000110000000000000000000000000000000000100110010101101000111100111111110011110001011010100110010000000000000000000000000000000000000000000110000001100000011000111111111111111100011000000110000001100000000000000000000000000000000000000011000001100000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011111111111111110000000000000000000000000000000000000000000000000000000000000000000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000110000001100000110000001100000110000001100000110000001100000110000001100000110000001100000000000000000000000011110001100110110000111100011111001111110110111111001111100011110000110110011000111100000000000000000001111110000110000001100000011000000110000001100000011000000110000001111000011100000110000000000000000000111111110000001100000011000001100000110000011000001100000110000011000000111001110111111000000000000000000111111011100111110000001100000011100000011111101110000011000000110000001110011101111110000000000000000000110000001100000011000000110000001100001111111100110011001101100011110000111000001100000000000000000000011111101110011111000000110000001110000001111111000000110000001100000011000000111111111100000000000000000111111011100111110000111100001111100011011111110000001100000011000000111110011101111110000000000000000000001100000011000000110000001100000110000011000001100000110000001100000011000000111111110000000000000000011111101110011111000011110000111110011101111110111001111100001111000011111001110111111000000000000000000111111011100111110000001100000011000000111111101110011111000011110000111110011101111110000000000000000000000000000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000000000000011000001100000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000110000000110000000110000000110000000110000000110000011000001100000110000011000001100000000000000000000000000000000000001111111111111111000000001111111111111111000000000000000000000000000000000000000000000000000001100000110000011000001100000110000011000000011000000011000000011000000011000000011000000000000000000001100000000000000000000001100000011000001100000110000011000000110000111100001101111110000000000000000011111100000001101111001111011011110010111011101111000011011111100000000000000000000000000000000000000000110000111100001111000011110000111111111111000011110000111100001101100110001111000001100000000000000000000111111111100011110000111100001111100011011111111110001111000011110000111110001101111111000000000000000001111110111001110000001100000011000000110000001100000011000000110000001111100111011111100000000000000000001111110111001111100011110000111100001111000011110000111100001111100011011100110011111100000000000000001111111100000011000000110000001100000011001111110000001100000011000000110000001111111111000000000000000000000011000000110000001100000011000000110000001100111111000000110000001100000011111111110000000000000000011111101110011111000011110000111111001100000011000000110000001100000011111001110111111000000000000000001100001111000011110000111100001111000011111111111100001111000011110000111100001111000011000000000000000001111110000110000001100000011000000110000001100000011000000110000001100000011000011111100000000000000000001111100111011101100011011000000110000001100000011000000110000001100000011000000110000000000000000000001100001101100011001100110001101100001111000001110000111100011011001100110110001111000011000000000000000011111111000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000110000111100001111000011110000111100001111000011110110111111111111111111111001111100001100000000000000001110001111100011111100111111001111111011110110111101111111001111110011111100011111000111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111100111011111100000000000000000000000110000001100000011000000110000001101111111111000111100001111000011111000110111111100000000000000001111110001110110111110111101101111000011110000111100001111000011110000110110011000111100000000000000000011000011011000110011001100011011000011110111111111100011110000111100001111100011011111110000000000000000011111101110011111000000110000001110000001111110000001110000001100000011111001110111111000000000000000000001100000011000000110000001100000011000000110000001100000011000000110000001100011111111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111000011110000110000000000000000000110000011110000111100011001100110011011000011110000111100001111000011110000111100001100000000000000001100001111100111111111111111111111011011110110111100001111000011110000111100001111000011000000000000000011000011011001100110011000111100001111000001100000111100001111000110011001100110110000110000000000000000000110000001100000011000000110000001100000011000001111000011110001100110011001101100001100000000000000001111111100000011000000110000011000001100011111100011000001100000110000001100000011111111000000000000000000111100000011000000110000001100000011000000110000001100000011000000110000001100001111000000000011000000110000000110000001100000001100000011000000011000000110000000110000001100000001100000011000000000000000000011110000110000001100000011000000110000001100000011000000110000001100000011000000111100000000000000000000000000000000000000000000000000000000000000000000000000110000110110011000111100000110001111111111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000111000000110000001110000000000000000011111110110000111100001111111110110000001100001101111110000000000000000000000000000000000000000000000000011111111100001111000011110000111100001101111111000000110000001100000011000000110000001100000000000000000111111011000011000000110000001100000011110000110111111000000000000000000000000000000000000000000000000011111110110000111100001111000011110000111111111011000000110000001100000011000000110000000000000000000000111111100000001100000011011111111100001111000011011111100000000000000000000000000000000000000000000000000000110000001100000011000000110000001100001111110000110000001100000011001100110001111000011111101100001111000000110000001111111011000011110000111100001101111110000000000000000000000000000000000000000000000000110000111100001111000011110000111100001111000011011111110000001100000011000000110000001100000000000000000001100000011000000110000001100000011000000110000001100000000000000000000001100000000000000111000011011000110000001100000011000000110000001100000011000000110000000000000000000000110000000000000000000000000000011000110011001100011111000011110001101100110011011000110000001100000011000000110000001100000000000000000111111000011000000110000001100000011000000110000001100000011000000110000001100000011110000000000000000011011011110110111101101111011011110110111101101101111111000000000000000000000000000000000000000000000000011000110110001101100011011000110110001101100011001111110000000000000000000000000000000000000000000000000011111001100011011000110110001101100011011000110011111000000000000000000000000000000000000000110000001100000011011111111100001111000011110000111100001101111111000000000000000000000000000000001100000011000000110000001111111011000011110000111100001111000011111111100000000000000000000000000000000000000000000000000000001100000011000000110000001100000011000001110111111100000000000000000000000000000000000000000000000001111111110000001100000001111110000000110000001111111110000000000000000000000000000000000000000000000000001110000110110000001100000011000000110000001100001111110000110000001100000011000000000000000000000000000111111001100011011000110110001101100011011000110110001100000000000000000000000000000000000000000000000000011000001111000011110001100110011001101100001111000011000000000000000000000000000000000000000000000000110000111110011111111111110110111100001111000011110000110000000000000000000000000000000000000000000000001100001101100110001111000001100000111100011001101100001100000000000000000000000000000000000000110000011000000110000011000001100000111100011001100110011011000011000000000000000000000000000000000000000000000000111111110000011000001100000110000011000001100000111111110000000000000000000000000000000000000000000000001111000000011000000110000001100000011100000011110001110000011000000110000001100011110000000110000001100000011000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000000000011110001100000011000000110000011100011110000001110000001100000011000000110000000111100000000000000000000000000000000000000000000000000000000000000000000000000000000001110110110111000000000".ToCharArray()
	End Function


	Public Sub DrawAsciiCharacter(ByRef image As RGBABitmapImage, topx As Double, topy As Double, a As Char, ByRef color As RGBA)
		Dim index, x, y, pixel, basis, ybasis As Double
		Dim allCharData As Char ()

		index = Convert.ToInt16(a)
		index = index - 32.0
		allCharData = GetPixelFontData()

		basis = index*8.0*13.0

		y = 0.0
		While y < 13.0
			ybasis = basis + y*8.0
			x = 0.0
			While x < 8.0
				pixel = Convert.ToInt16(allCharData(ybasis + x))
				If pixel = Convert.ToInt16("1"C)
					Call DrawPixel(image, topx + 8.0 - 1.0 - x, topy + 13.0 - 1.0 - y, color)
				End If
				x = x + 1.0
			End While
			y = y + 1.0
		End While
	End Sub


	Public Function GetTextWidth(ByRef text As Char ()) As Double
		Dim charWidth, spacing, width As Double

		charWidth = 8.0
		spacing = 2.0

		If text.Length = 0.0
			width = 0.0
		Else
			width = text.Length*charWidth + (text.Length - 1.0)*spacing
		End If

		Return width
	End Function


	Public Function GetTextHeight(ByRef text As Char ()) As Double
		Return 13.0
	End Function


	Public Function DPIToDotsPerMm(dpi As Double) As Double
		Return dpi/25.4
	End Function


	Public Function DotsPerMmDPI(dotsPerMm As Double) As Double
		Return dotsPerMm*25.4
	End Function


	Public Function MmToInch(mm As Double) As Double
		Return mm/25.4
	End Function


	Public Function InchToMm(inch As Double) As Double
		Return inch*25.4
	End Function


	Public Function MmToDots(mm As Double, dpi As Double) As Double
		Return MmToInch(mm)*dpi
	End Function


	Public Function DotsToMm(dots As Double, dpi As Double) As Double
		Return InchToMm(dots/dpi)
	End Function


	Public Function PtsToInch(pts As Double) As Double
		Return pts*1.0/72.0
	End Function


	Public Function InchToPts(inch As Double) As Double
		Return inch*72.0
	End Function


	Public Function PtsToMm(pts As Double) As Double
		Return InchToMm(PtsToInch(pts))
	End Function


	Public Function MmToPts(mm As Double) As Double
		Return InchToPts(MmToInch(mm))
	End Function


	Public Function ComputeReedSolomonCodes(ByRef data As Double (), eccs As Double) As Double ()
		Dim rsDiv, ecc As Double ()

		rsDiv = ReedSolomonComputeDivisor(eccs)
		ecc = ReedSolomonComputeRemainder(data, rsDiv)

		Return ecc
	End Function


	Public Function ReedSolomonComputeDivisor(eccs As Double) As Double ()
		Dim result As Double ()
		Dim root, i, j As Double

		result = arraysCreateNumberArray(eccs, 0.0)
		result(result.Length - 1.0) = 1.0

		root = 1.0
		i = 0.0
		While i < eccs
			j = 0.0
			While j < result.Length
				result(j) = GaloisField2e8Mul(result(j), root, 285.0)
				If j + 1.0 < result.Length
					result(j) = XorByte(result(j), result(j + 1.0))
				End If
				j = j + 1.0
			End While
			root = GaloisField2e8Mul(root, 2.0, 285.0)
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ReedSolomonComputeRemainder(ByRef data As Double (), ByRef divisor As Double ()) As Double ()
		Dim result As Double ()
		Dim i, j, b, factor, coef As Double

		result = arraysCreateNumberArray(divisor.Length, 0.0)

		i = 0.0
		While i < data.Length
			b = data(i)

			factor = XorByte(b, result(0))

			j = 0.0
			While j < result.Length - 1.0
				result(j) = result(j + 1.0)
				j = j + 1.0
			End While
			result(j) = 0.0

			j = 0.0
			While j < divisor.Length
				coef = divisor(j)
				result(j) = XorByte(result(j), GaloisField2e8Mul(coef, factor, 285.0))
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ComputeBHC15_5Code(data As Double) As Double
		Dim i, gp As Double

		' x^10 + x^8 + x^5 + x^4 + x^2 + x + 1 is encoded as 10100110111b = 1335
		gp = 1335.0

		i = 0.0
		While i < 10.0
			data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 9.0)*gp)
			i = i + 1.0
		End While

		Return data
	End Function


	Public Function ComputeBHC18_6Code(data As Double) As Double
		Dim i, gp As Double

		' x^12 + x^11 + x^10 + x^9 + x^8 + x^5 + x^2 + 1 is encoded as 1111100100101b = 7973
		gp = 7973.0

		i = 0.0
		While i < 12.0
			data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 11.0)*gp)
			i = i + 1.0
		End While

		Return data
	End Function


	Public Function And4Byte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsigned4Bytes(a)
		b = ToUnsigned4Bytes(b)

		i = 0.0
		While i < 32.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab = 1.0 And bb = 1.0
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function ToUnsigned4Bytes(a As Double) As Double
		If a < 0.0
			a = 4294967296.0 - Truncatex((-a) Mod 4294967296.0)
		Else
			a = Truncatex(a Mod 4294967296.0)
		End If
		Return a
	End Function


	Public Function ToUnsigned2Bytes(a As Double) As Double
		If a < 0.0
			a = 65536.0 - Truncatex((-a) Mod 65536.0)
		Else
			a = Truncatex(a Mod 65536.0)
		End If
		Return a
	End Function


	Public Function ToUnsignedByte(a As Double) As Double
		If a < 0.0
			a = 256.0 - Truncatex((-a) Mod 256.0)
		Else
			a = Truncatex(a Mod 256.0)
		End If
		Return a
	End Function


	Public Function And2Byte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsigned2Bytes(a)
		b = ToUnsigned2Bytes(b)

		i = 0.0
		While i < 16.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab = 1.0 And bb = 1.0
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function AndByte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsignedByte(a)
		b = ToUnsignedByte(b)

		i = 0.0
		While i < 8.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab = 1.0 And bb = 1.0
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function Or4Byte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsigned4Bytes(a)
		b = ToUnsigned4Bytes(b)

		i = 0.0
		While i < 32.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab = 1.0 Or bb = 1.0
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function Or2Byte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsigned2Bytes(a)
		b = ToUnsigned2Bytes(b)

		i = 0.0
		While i < 16.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab = 1.0 Or bb = 1.0
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function OrByte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsignedByte(a)
		b = ToUnsignedByte(b)

		i = 0.0
		While i < 8.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab = 1.0 Or bb = 1.0
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function Xor4Byte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsigned4Bytes(a)
		b = ToUnsigned4Bytes(b)

		i = 0.0
		While i < 32.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab <> bb
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function Xor2Byte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsigned2Bytes(a)
		b = ToUnsigned2Bytes(b)

		i = 0.0
		While i < 16.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab <> bb
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function XorByte(a As Double, b As Double) As Double
		Dim byteVal, result, i, ab, bb As Double

		byteVal = 1.0
		result = 0.0

		a = ToUnsignedByte(a)
		b = ToUnsignedByte(b)

		i = 0.0
		While i < 8.0
			ab = a Mod 2.0
			bb = b Mod 2.0

			If ab <> bb
				result = result + byteVal
			End If

			a = Floor(a/2.0)
			b = Floor(b/2.0)
			byteVal = byteVal*2.0
			i = i + 1.0
		End While

		Return result
	End Function


	Public Function Not4Byte(a As Double) As Double
		Dim result As Double

		a = ToUnsigned4Bytes(a)

		result = 4294967296.0 - a - 1.0

		Return result
	End Function


	Public Function Not2Byte(a As Double) As Double
		Dim result As Double

		a = ToUnsigned2Bytes(a)

		result = 65536.0 - a - 1.0

		Return result
	End Function


	Public Function NotByte(a As Double) As Double
		Dim result As Double

		a = ToUnsignedByte(a)

		result = 256.0 - a - 1.0

		Return result
	End Function


	Public Function ShiftLeft4Byte(a As Double, n As Double) As Double
		Dim result As Double

		a = Truncatex(a Mod 4294967296.0)
		n = Truncatex(Max(n, 0.0))

		result = a*2.0 ^ n

		Return result
	End Function


	Public Function ShiftLeft2Byte(a As Double, n As Double) As Double
		Dim result As Double

		a = Truncatex(a Mod 65536.0)
		n = Truncatex(Max(n, 0.0))

		result = a*2.0 ^ n

		Return result
	End Function


	Public Function ShiftLeftByte(a As Double, n As Double) As Double
		Dim result As Double

		a = Truncatex(a Mod 256.0)
		n = Truncatex(Max(n, 0.0))

		result = a*2.0 ^ n

		Return result
	End Function


	Public Function ShiftRight4Byte(a As Double, n As Double) As Double
		Dim result As Double

		a = Truncatex(a Mod 4294967296.0)
		n = Truncatex(Max(n, 0.0))

		result = Truncatex(a/2.0 ^ n)

		Return result
	End Function


	Public Function ShiftRight2Byte(a As Double, n As Double) As Double
		Dim result As Double

		a = Truncatex(a Mod 65536.0)
		n = Truncatex(Max(n, 0.0))

		result = Truncatex(a/2.0 ^ n)

		Return result
	End Function


	Public Function ShiftRightByte(a As Double, n As Double) As Double
		Dim result As Double

		a = Truncatex(a Mod 256.0)
		n = Truncatex(Max(n, 0.0))

		result = Truncatex(a/2.0 ^ n)

		Return result
	End Function


	Public Function RotateLeft4Byte(a As Double, n As Double) As Double
		Dim x As Double

		a = ToUnsigned4Bytes(a)
		n = Truncatex(n)

		'return (a << n) | (a >> (32 - n));
		' Mask the upper bits first, then rotate.
		x = And4Byte(a, Not4Byte(ShiftLeft4Byte(1.0, n) - 1.0))
		x = Or4Byte(ShiftLeft4Byte(x, n), ShiftRight4Byte(a, (32.0 - n)))

		Return x
	End Function


	Public Function RotateRight4Byte(a As Double, n As Double) As Double
		Dim x As Double

		a = ToUnsigned4Bytes(a)
		n = Truncatex(n)

		' return (a >> d) | (a << (32 - n));
		' Mask away the upper bits first, then perform the shift.
		x = And4Byte(a, ShiftLeft4Byte(1.0, n) - 1.0)
		x = Or4Byte(ShiftRight4Byte(a, n), ShiftLeft4Byte(x, 32.0 - n))

		Return x
	End Function


	Public Function CreateBooleanArrayFromNumber(w As Double, size As Double) As Boolean ()
		Dim outx As Boolean ()
		Dim p, j As Double

		outx = arraysCreateBooleanArray(size, false)

		j = 0.0
		p = 1.0
		
		While p < w
			p = p*2.0
			j = j + 1.0
		End While

		
		While j >= 0.0
			If w >= p
				w = w - p
				If j < size
					outx(size - 1.0 - j) = true
				End If
			End If
			p = p/2.0
			j = j - 1.0
		End While

		Return outx
	End Function


	Public Function BooleanArrayToNumber(ByRef bits As Boolean ()) As Double
		Dim w, i, p As Double

		w = 0.0
		p = 1.0
		i = 31.0
		While i >= 0.0
			If bits(i)
				w = w + p
			End If
			p = p*2.0
			i = i - 1.0
		End While

		Return w
	End Function


	Public Function BooleanAnd(ByRef a As Boolean (), ByRef b As Boolean ()) As Boolean ()
		Dim outx As Boolean ()
		Dim i, length As Double

		length = a.Length

		outx = New Boolean (length - 1){}

		i = 0.0
		While i < length
			outx(i) = a(i) And b(i)
			i = i + 1.0
		End While
		Return outx
	End Function


	Public Function BooleanXor(ByRef a As Boolean (), ByRef b As Boolean ()) As Boolean ()
		Dim outx As Boolean ()
		Dim i, length As Double

		length = a.Length

		outx = New Boolean (length - 1){}

		i = 0.0
		While i < length
			If a(i) Or b(i)
				If Not (a(i) And b(i))
					outx(i) = true
				End If
			End If
			i = i + 1.0
		End While
		Return outx
	End Function


	Public Function BooleanNot(ByRef a As Boolean ()) As Boolean ()
		Dim outx As Boolean ()
		Dim i, length As Double

		length = a.Length

		outx = New Boolean (length - 1){}

		i = 0.0
		While i < length
			outx(i) = Not a(i)
			i = i + 1.0
		End While
		Return outx
	End Function


	Public Function ShiftBitsRight4Byte(ByRef w As Boolean (), n As Double) As Boolean ()
		Dim wb As Boolean ()
		Dim ob As Boolean ()
		Dim i, it As Double
		Dim f As Boolean
		f = false

		If n = 0.0
			ob = w
		Else
			wb = w
			ob = New Boolean (32 - 1){}

			i = 0.0
			While i < 32.0
				it = i - n

				If it < 0.0
					f = false
				Else
					f = wb(it)
				End If

				ob(i) = f
				i = i + 1.0
			End While
		End If

		Return ob
	End Function


	Public Function ReadNextBit(ByRef data As Double (), ByRef nextbit As NumberReference) As Double
		Dim bytenr, bitnumber, bit, b As Double

		bytenr = Floor(nextbit.numberValue/8.0)
		bitnumber = nextbit.numberValue Mod 8.0

		b = data(bytenr)

		bit = Floor(b/2.0 ^ bitnumber) Mod 2.0

		nextbit.numberValue = nextbit.numberValue + 1.0

		Return bit
	End Function


	Public Function BitExtract(b As Double, fromInc As Double, toInc As Double) As Double
		Return Floor(b/2.0 ^ fromInc) Mod 2.0 ^ (toInc + 1.0 - fromInc)
	End Function


	Public Function ReadBitRange(ByRef data As Double (), ByRef nextbit As NumberReference, length As Double) As Double
		Dim startbyte, endbyte As Double
		Dim startbit, endbit As Double
		Dim number, i As Double

		number = 0.0

		startbyte = Floor(nextbit.numberValue/8.0)
		endbyte = Floor((nextbit.numberValue + length)/8.0)

		startbit = nextbit.numberValue Mod 8.0
		endbit = (nextbit.numberValue + length - 1.0) Mod 8.0

		If startbyte = endbyte
			number = BitExtract(data(startbyte), startbit, endbit)
		End If

		nextbit.numberValue = nextbit.numberValue + length

		Return number
	End Function


	Public Sub SkipToBoundary(ByRef nextbit As NumberReference)
		Dim skip As Double

		skip = 8.0 - nextbit.numberValue Mod 8.0
		nextbit.numberValue = nextbit.numberValue + skip
	End Sub


	Public Function ReadNextByteBoundary(ByRef data As Double (), ByRef nextbit As NumberReference) As Double
		Dim bytenr, b As Double

		bytenr = Floor(nextbit.numberValue/8.0)
		b = data(bytenr)
		nextbit.numberValue = nextbit.numberValue + 8.0

		Return b
	End Function


	Public Function Read2bytesByteBoundary(ByRef data As Double (), ByRef nextbit As NumberReference) As Double
		Dim r As Double

		r = 0.0
		r = r + 2.0 ^ 8.0*ReadNextByteBoundary(data, nextbit)
		r = r + ReadNextByteBoundary(data, nextbit)

		Return r
	End Function


	Public Sub QuickSortStrings(ByRef list As StringArrayReference)
		Call QuickSortStringsBounds(list, 0.0, list.stringArray.Length - 1.0)
	End Sub


	Public Sub QuickSortStringsBounds(ByRef A As StringArrayReference, lo As Double, hi As Double)
		Dim p As Double

		If lo < hi
			p = QuickSortStringsPartition(A, lo, hi)
			Call QuickSortStringsBounds(A, lo, p - 1.0)
			Call QuickSortStringsBounds(A, p + 1.0, hi)
		End If
	End Sub


	Public Function QuickSortStringsPartition(ByRef A As StringArrayReference, lo As Double, hi As Double) As Double
		Dim pivot As Char ()
		Dim i, j As Double

		pivot = A.stringArray(hi).stringx
		i = lo - 1.0
		j = lo
		While j <= hi - 1.0
			If strStringIsBefore(A.stringArray(j).stringx, pivot)
				i = i + 1.0
				Call arraysSwapElementsOfStringArray(A, i, j)
			End If
			j = j + 1.0
		End While
		Call arraysSwapElementsOfStringArray(A, i + 1.0, hi)

		Return i + 1.0
	End Function


	Public Function QuickSortStringsWithIndexes(ByRef A As StringArrayReference) As Double ()
		Dim indexes As Double ()
		Dim i As Double

		indexes = New Double (A.stringArray.Length - 1){}

		i = 0.0
		While i < A.stringArray.Length
			indexes(i) = i
			i = i + 1.0
		End While

		Call QuickSortStringsBoundsWithIndexes(A, indexes, 0.0, A.stringArray.Length - 1.0)

		Return indexes
	End Function


	Public Sub QuickSortStringsBoundsWithIndexes(ByRef A As StringArrayReference, ByRef indexes As Double (), lo As Double, hi As Double)
		Dim p As Double

		If lo < hi
			p = QuickSortStringsPartitionWithIndexes(A, indexes, lo, hi)
			Call QuickSortStringsBoundsWithIndexes(A, indexes, lo, p - 1.0)
			Call QuickSortStringsBoundsWithIndexes(A, indexes, p + 1.0, hi)
		End If
	End Sub


	Public Function QuickSortStringsPartitionWithIndexes(ByRef A As StringArrayReference, ByRef indexes As Double (), lo As Double, hi As Double) As Double
		Dim i, j As Double
		Dim pivot As Char ()

		pivot = A.stringArray(hi).stringx
		i = lo - 1.0
		j = lo
		While j <= hi - 1.0
			If strStringIsBefore(A.stringArray(j).stringx, pivot)
				i = i + 1.0
				Call arraysSwapElementsOfStringArray(A, i, j)
				Call arraysSwapElementsOfNumberArray(indexes, i, j)
			End If
			j = j + 1.0
		End While
		Call arraysSwapElementsOfStringArray(A, i + 1.0, hi)
		Call arraysSwapElementsOfNumberArray(indexes, i + 1.0, hi)

		Return i + 1.0
	End Function


	Public Sub QuickSortNumbers(ByRef list As Double ())
		Call QuickSortNumbersBounds(list, 0.0, list.Length - 1.0)
	End Sub


	Public Sub QuickSortNumbersBounds(ByRef A As Double (), lo As Double, hi As Double)
		Dim p As Double

		If lo < hi
			p = QuickSortNumbersPartition(A, lo, hi)
			Call QuickSortNumbersBounds(A, lo, p - 1.0)
			Call QuickSortNumbersBounds(A, p + 1.0, hi)
		End If
	End Sub


	Public Function QuickSortNumbersPartition(ByRef A As Double (), lo As Double, hi As Double) As Double
		Dim pivot, lowPos, j As Double

		pivot = A(hi)
		lowPos = lo
		j = lo
		While j <= hi - 1.0
			If A(j) < pivot
				Call arraysSwapElementsOfNumberArray(A, lowPos, j)
				lowPos = lowPos + 1.0
			End If
			j = j + 1.0
		End While
		Call arraysSwapElementsOfNumberArray(A, lowPos, hi)

		Return lowPos
	End Function


	Public Function QuickSortNumbersWithIndexes(ByRef A As Double ()) As Double ()
		Dim indexes As Double ()
		Dim i As Double

		indexes = New Double (A.Length - 1){}

		i = 0.0
		While i < A.Length
			indexes(i) = i
			i = i + 1.0
		End While

		Call QuickSortNumbersBoundsWithIndexes(A, indexes, 0.0, A.Length - 1.0)

		Return indexes
	End Function


	Public Sub QuickSortNumbersBoundsWithIndexes(ByRef A As Double (), ByRef indexes As Double (), lo As Double, hi As Double)
		Dim p As Double

		If lo < hi
			p = QuickSortNumbersPartitionWithIndexes(A, indexes, lo, hi)
			Call QuickSortNumbersBoundsWithIndexes(A, indexes, lo, p - 1.0)
			Call QuickSortNumbersBoundsWithIndexes(A, indexes, p + 1.0, hi)
		End If
	End Sub


	Public Function QuickSortNumbersPartitionWithIndexes(ByRef A As Double (), ByRef indexes As Double (), lo As Double, hi As Double) As Double
		Dim pivot, i, j As Double

		pivot = A(hi)
		i = lo - 1.0
		j = lo
		While j <= hi - 1.0
			If A(j) < pivot
				i = i + 1.0
				Call arraysSwapElementsOfNumberArray(A, i, j)
				Call arraysSwapElementsOfNumberArray(indexes, i, j)
			End If
			j = j + 1.0
		End While
		Call arraysSwapElementsOfNumberArray(A, i + 1.0, hi)
		Call arraysSwapElementsOfNumberArray(indexes, i + 1.0, hi)

		Return i + 1.0
	End Function


	Public Sub Add(ByRef a As Matrix, ByRef b As Matrix)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRows(a)
		c = NumberOfColumns(a)
		m = 0.0
		While m < r
			n = 0.0
			While n < c
				a.r(m).c(n) = Element(a, m, n) + Element(b, m, n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub Assign(ByRef A As Matrix, ByRef B As Matrix)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRows(A)
		c = NumberOfColumns(A)
		m = 0.0
		While m < r
			n = 0.0
			While n < c
				A.r(m).c(n) = Element(B, m, n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub Resize(ByRef A As Matrix, r As Double, c As Double)
		Dim m, n, ar, ac As Double
		Dim C As Matrix

		C = CreateMatrix(r, c)

		ar = NumberOfRows(A)
		ac = NumberOfColumns(A)

		m = 0.0
		While m < Min(r, ar)
			n = 0.0
			While n < Min(c, ac)
				C.r(m).c(n) = Element(A, m, n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Call FreeMatrixRows(A.r)
		A.r = C.r
	End Sub


	Public Sub Subtract(ByRef a As Matrix, ByRef b As Matrix)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRows(a)
		c = NumberOfColumns(a)
		m = 0.0
		While m < r
			n = 0.0
			While n < c
				a.r(m).c(n) = Element(a, m, n) - Element(b, m, n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function SubtractToNew(ByRef a As Matrix, ByRef b As Matrix) As Matrix
		Dim X As Matrix

		X = CreateCopyOfMatrix(a)
		Call Subtract(X, b)

		Return X
	End Function


	Public Sub ScalarMultiply(ByRef A As Matrix, b As Double)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRows(A)
		c = NumberOfColumns(A)
		m = 0.0
		While m < r
			n = 0.0
			While n < c
				A.r(m).c(n) = b*A.r(m).c(n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub ScalarDivide(ByRef A As Matrix, b As Double)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRows(A)
		c = NumberOfColumns(A)
		m = 0.0
		While m < r
			n = 0.0
			While n < c
				A.r(m).c(n) = Element(A, m, n)/b
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub ElementWisePower(ByRef A As Matrix, p As Double)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRows(A)
		c = NumberOfColumns(A)

		m = 0.0
		While m < r
			n = 0.0
			While n < c
				A.r(m).c(n) = A.r(m).c(n) ^ p
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function ScalarMultiplyToNew(ByRef A As Matrix, b As Double) As Matrix
		Dim matrix As Matrix

		matrix = CreateCopyOfMatrix(A)
		Call ScalarMultiply(matrix, b)

		Return matrix
	End Function


	Public Function MultiplyToNew(ByRef a As Matrix, ByRef b As Matrix) As Matrix
		Dim rows, cols As Double
		Dim x As Matrix

		rows = NumberOfRows(a)
		cols = NumberOfColumns(b)
		x = CreateMatrix(rows, cols)
		Call Multiply(x, a, b)

		Return x
	End Function


	Public Sub Multiply(ByRef x As Matrix, ByRef a As Matrix, ByRef b As Matrix)
		Dim m, n As Double
		Dim rows, cols, d As Double
		Dim i, s As Double

		rows = NumberOfRows(a)
		cols = NumberOfColumns(b)
		d = NumberOfColumns(a)

		m = 0.0
		While m < rows
			n = 0.0
			While n < cols
				s = 0.0

				i = 0.0
				While i < d
					s = s + a.r(m).c(i)*b.r(i).c(n)
					i = i + 1.0
				End While

				x.r(m).c(n) = s
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function CreateSquareMatrix(d As Double) As Matrix
		Dim m, n As Double
		Dim matrix As Matrix

		matrix = New Matrix()
		matrix.r = New MatrixRow (d - 1){}
		m = 0.0
		While m < d
			matrix.r(m) = New MatrixRow()
			matrix.r(m).c = New Double (d - 1){}
			n = 0.0
			While n < d
				matrix.r(m).c(n) = 0.0
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateMatrix(rows As Double, cols As Double) As Matrix
		Dim m, n As Double
		Dim matrix As Matrix

		matrix = New Matrix()
		matrix.r = New MatrixRow (rows - 1){}
		m = 0.0
		While m < rows
			matrix.r(m) = New MatrixRow()
			matrix.r(m).c = New Double (cols - 1){}
			n = 0.0
			While n < cols
				matrix.r(m).c(n) = 0.0
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateIdentityMatrix(d As Double) As Matrix
		Dim m As Double
		Dim matrix As Matrix

		matrix = CreateSquareMatrix(d)
		Call Fill(matrix, 0.0)

		m = 0.0
		While m < d
			matrix.r(m).c(m) = 1.0
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Sub Transpose(ByRef a As Matrix)
		Dim ap As Matrix

		ap = TransposeToNew(a)

		Call FreeMatrixRows(a.r)
		a.r = ap.r
	End Sub


	Public Sub TransposeAssign(ByRef t As Matrix, ByRef a As Matrix)
		Dim m, n As Double
		Dim rows, cols As Double

		cols = NumberOfRows(a)
		rows = NumberOfColumns(a)

		m = 0.0
		While m < cols
			n = 0.0
			While n < rows
				t.r(n).c(m) = a.r(m).c(n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function TransposeToNew(ByRef a As Matrix) As Matrix
		Dim m, n As Double
		Dim rows, cols As Double
		Dim c As Matrix

		cols = NumberOfRows(a)
		rows = NumberOfColumns(a)

		c = CreateMatrix(rows, cols)

		m = 0.0
		While m < cols
			n = 0.0
			While n < rows
				c.r(n).c(m) = a.r(m).c(n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return c
	End Function


	Public Sub CofactorOfMatrix(ByRef mat As Matrix, ByRef temp As Matrix, p As Double, q As Double, n As Double)
		Dim i, j As Double
		Dim row, col As Double

		i = 0.0
		j = 0.0

		row = 0.0
		While row < n
			col = 0.0
			While col < n
				If row <> p And col <> q
					temp.r(i).c(j) = mat.r(row).c(col)
					j = j + 1.0

					If j = n - 1.0
						j = 0.0
						i = i + 1.0
					End If
				End If
				col = col + 1.0
			End While
			row = row + 1.0
		End While
	End Sub


	Public Function DeterminantOfSubmatrix(ByRef mat As Matrix, n As Double) As Double
		Dim D, f, signx As Double
		Dim temp As Matrix

		D = 0.0

		If n = 1.0
			D = mat.r(0).c(0)
		Else
			temp = CreateSquareMatrix(n)

			signx = 1.0

			f = 0.0
			While f < n
				Call CofactorOfMatrix(mat, temp, 0.0, f, n)
				D = D + signx*mat.r(0).c(f)*DeterminantOfSubmatrix(temp, n - 1.0)
				signx = -signx
				f = f + 1.0
			End While

			Call FreeMatrix(temp)
		End If

		Return D
	End Function


	Public Function Determinant(ByRef m As Matrix) As Double
		Dim D, n As Double

		n = NumberOfRows(m)
		D = DeterminantOfSubmatrix(m, n)

		Return D
	End Function


	Public Sub Adjoint(ByRef A As Matrix, ByRef adj As Matrix)
		Dim n, signx As Double
		Dim cofactors As Matrix
		Dim i, j As Double

		n = A.r.Length

		If n = 1.0
			adj.r(0).c(0) = 1.0
		Else
			cofactors = CreateSquareMatrix(n)

			i = 0.0
			While i < n
				j = 0.0
				While j < n
					Call CofactorOfMatrix(A, cofactors, i, j, n)

					If (i + j) Mod 2.0 = 0.0
						signx = 1.0
					Else
						signx = -1.0
					End If

					adj.r(j).c(i) = signx*DeterminantOfSubmatrix(cofactors, n - 1.0)
					j = j + 1.0
				End While
				i = i + 1.0
			End While

			Call FreeMatrix(cofactors)
		End If
	End Sub


	Public Function Inverse(ByRef A As Matrix, ByRef inverseResult As Matrix) As Boolean
		Return InverseUsingLUDecomposition(A, inverseResult)
	End Function


	Public Function InverseUsingAdjoint(ByRef A As Matrix, ByRef inverseResult As Matrix) As Boolean
		Dim success As Boolean
		Dim adj As Matrix
		Dim n, i, j As Double
		Dim det As Double

		If NumberOfColumns(A) = NumberOfRows(A)
			n = NumberOfColumns(A)

			det = Determinant(A)
			If det <> 0.0
				adj = CreateSquareMatrix(n)
				Call Adjoint(A, adj)

				i = 0.0
				While i < n
					j = 0.0
					While j < n
						inverseResult.r(i).c(j) = adj.r(i).c(j)/det
						j = j + 1.0
					End While
					i = i + 1.0
				End While

				success = true
				Call FreeMatrix(adj)
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function InverseUsingLUDecomposition(ByRef A As Matrix, ByRef inverseResult As Matrix) As Boolean
		Dim success As Boolean
		Dim l, u, li, ui As Matrix

		l = CreateCopyOfMatrix(A)
		u = CreateCopyOfMatrix(A)
		li = CreateCopyOfMatrix(A)
		ui = CreateCopyOfMatrix(A)
		inverseResult.r = CreateCopyOfMatrix(A).r

		success = LUDecomposition(A, l, u)
		If success
			success = InvertLowerTriangularMatrix(l, li)
			If success
				success = InvertUpperTriangularMatrix(u, ui)
				If success
					Call Multiply(inverseResult, ui, li)
				End If
			End If
		End If

		Call FreeMatrix(l)
		Call FreeMatrix(u)
		Call FreeMatrix(li)
		Call FreeMatrix(ui)

		Return success
	End Function


	Public Function LUDecomposition(ByRef A As Matrix, ByRef L As Matrix, ByRef U As Matrix) As Boolean
		Dim n, i, j, k, sum As Double
		Dim success As Boolean

		n = NumberOfRows(A)

		L.r = CreateSquareMatrix(n).r
		U.r = CreateSquareMatrix(n).r

		If IsSquare(A)
			success = true

			i = 0.0
			While i < n And success
				k = i
				While k < n
					sum = 0.0
					j = 0.0
					While j < i
						sum = sum + (Element(L, i, j)*Element(U, j, k))
						j = j + 1.0
					End While

					U.r(i).c(k) = Element(A, i, k) - sum
					k = k + 1.0
				End While

				k = i
				While k < n And success
					If i = k
						L.r(i).c(i) = 1.0
					Else
						sum = 0.0
						j = 0.0
						While j < i
							sum = sum + (Element(L, k, j)*Element(U, j, i))
							j = j + 1.0
						End While

						If Element(U, i, i) = 0.0
							success = false
						Else
							L.r(k).c(i) = (Element(A, k, i) - sum)/Element(U, i, i)
						End If
					End If
					k = k + 1.0
				End While
				i = i + 1.0
			End While
		Else
			success = false
		End If

		Return success
	End Function


	Public Function IsSymmetric(ByRef A As Matrix) As Boolean
		Dim N As Double
		Dim i, j As Double
		Dim isx, done As Boolean

		N = NumberOfRows(A)

		done = false
		isx = true
		i = 0.0
		While i < N And Not done
			j = 0.0
			While j < i And Not done
				If A.r(i).c(j) <> A.r(j).c(i)
					isx = false
					done = true
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return isx
	End Function


	Public Function IsSquare(ByRef A As Matrix) As Boolean
		Dim isx As Boolean

		If NumberOfRows(A) = NumberOfColumns(A)
			isx = true
		Else
			isx = false
		End If

		Return isx
	End Function


	Public Function Cholesky(ByRef A As Matrix, ByRef L As Matrix) As Boolean
		Dim success As Boolean
		Dim N As Double
		Dim i, j, k, s As Double

		Call Clear(L)

		If IsSquare(A) And IsSymmetric(A)
			success = true

			N = NumberOfRows(A)

			i = 0.0
			While i < N And success
				j = 0.0
				While j <= i And success
					s = 0.0
					k = 0.0
					While k < j
						s = s + L.r(i).c(k)*L.r(j).c(k)
						k = k + 1.0
					End While
					If i = j
						L.r(i).c(i) = Sqrt(A.r(i).c(i) - s)
					Else
						L.r(i).c(j) = 1.0/L.r(j).c(j)*(A.r(i).c(j) - s)
					End If
					j = j + 1.0
				End While
				If L.r(i).c(i) <= 0.0
					success = false
				End If
				i = i + 1.0
			End While

			success = true
		Else
			success = false
		End If

		Return success
	End Function


	Public Sub Clear(ByRef a As Matrix)
		Call Fill(a, 0.0)
	End Sub


	Public Sub Fill(ByRef a As Matrix, value As Double)
		Dim m, n As Double

		m = 0.0
		While m < NumberOfRows(a)
			n = 0.0
			While n < NumberOfColumns(a)
				a.r(m).c(n) = value
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function Element(ByRef matrix As Matrix, m As Double, n As Double) As Double
		Return matrix.r(m).c(n)
	End Function


	Public Function Trace(ByRef a As Matrix) As Double
		Dim m As Double
		Dim d, tr As Double

		tr = 0.0

		d = a.r.Length
		m = 0.0
		While m < d
			tr = tr + a.r(m).c(m)
			m = m + 1.0
		End While

		Return tr
	End Function


	Public Function ColumnCombineMatricesToNew(ByRef A As Matrix, ByRef B As Matrix) As Matrix
		Dim X As Matrix
		Dim m, n As Double

		X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A) + NumberOfColumns(B))

		m = 0.0
		While m < NumberOfRows(A)
			n = 0.0
			While n < NumberOfColumns(A)
				X.r(m).c(n) = A.r(m).c(n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		m = 0.0
		While m < NumberOfRows(B)
			n = 0.0
			While n < NumberOfColumns(B)
				X.r(m).c(NumberOfColumns(A) + n) = B.r(m).c(n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return X
	End Function


	Public Function NumberOfRows(ByRef A As Matrix) As Double
		Return A.r.Length
	End Function


	Public Function NumberOfColumns(ByRef A As Matrix) As Double
		Return A.r(0).c.Length
	End Function


	Public Function CharacteristicPolynomial(ByRef A As Matrix) As Double ()
		Dim dummy As Matrix
		Dim coeffs As NumberArrayReference
		Dim determinant As NumberReference

		dummy = CreateSquareMatrix(NumberOfRows(A))

		coeffs = New NumberArrayReference()
		determinant = New NumberReference()
		Call CharacteristicPolynomialWithInverse(A, dummy, coeffs, determinant)

		Call FreeMatrix(dummy)

		Return coeffs.numberArray
	End Function


	Public Sub CharacteristicPolynomialWithInverse(ByRef A As Matrix, ByRef AInverse As Matrix, ByRef cp As NumberArrayReference, ByRef determinant As NumberReference)
		Call FaddeevLeVerrierAlgorithm(A, AInverse, cp, determinant)
	End Sub


	Public Sub FaddeevLeVerrierAlgorithm(ByRef A As Matrix, ByRef AInverse As Matrix, ByRef cp As NumberArrayReference, ByRef determinant As NumberReference)
		Dim p As Double ()
		Dim Mk, Mkm1, t1, I As Matrix
		Dim n, k As Double

		n = NumberOfRows(A)
		p = New Double (n + 1.0 - 1){}
		p(n) = 1.0
		Mkm1 = CreateSquareMatrix(n)
		Call Fill(Mkm1, 0.0)
		I = CreateIdentityMatrix(n)
		Mk = CreateSquareMatrix(n)
		t1 = CreateSquareMatrix(n)

		k = 1.0
		While k <= n
			' M_k = A * M_(k-1) + c_(n-k+1) * I
			Call Multiply(Mk, A, Mkm1)
			Call Assign(t1, I)
			Call ScalarMultiply(t1, p(n - k + 1.0))
			Call Add(Mk, t1)

			' c_(n-k) = -1/k * trace(A * M_k)
			Call Multiply(t1, A, Mk)
			p(n - k) = -1.0/k*Trace(t1)

			' done
			Call Assign(Mkm1, Mk)

			If k = n
				Call Assign(AInverse, Mk)
				determinant.numberValue = -p(0)
				If p(0) = 0.0
				Else
					Call ScalarDivide(AInverse, determinant.numberValue)
				End If
			End If
			k = k + 1.0
		End While

		Call FreeMatrix(Mkm1)
		Call FreeMatrix(I)
		Call FreeMatrix(Mk)
		Call FreeMatrix(t1)

		cp.numberArray = p
	End Sub


	Public Function InverseUsingCharacteristicPolynomial(ByRef A As Matrix) As Matrix
		Dim inverse As Matrix
		Dim coeffs As NumberArrayReference
		Dim determinant As NumberReference

		inverse = CreateSquareMatrix(NumberOfRows(A))
		coeffs = New NumberArrayReference()
		determinant = New NumberReference()
		Call CharacteristicPolynomialWithInverse(A, inverse, coeffs, determinant)
		Erase coeffs.numberArray 
		coeffs = Nothing

		Return inverse
	End Function


	Public Function Eigenvalues(ByRef A As Matrix, ByRef eigenValuesReference As NumberArrayReference) As Boolean
		Dim eigenVectorsReference As MatrixArrayReference
		Dim success As Boolean
		Dim i As Double

		eigenVectorsReference = New MatrixArrayReference()
		success = Eigenpairs(A, eigenValuesReference, eigenVectorsReference)
		If success
			i = 0.0
			While i < eigenVectorsReference.matrices.Length
				Call FreeMatrix(eigenVectorsReference.matrices(i))
				i = i + 1.0
			End While
			Erase eigenVectorsReference.matrices 
			eigenVectorsReference = Nothing
		End If

		Return success
	End Function


	Public Function EigenvaluesUsingQRAlgorithm(ByRef A As Matrix, ByRef eigenValuesReference As NumberArrayReference, precision As Double, maxIterations As Double) As Boolean
		Dim x, q, r As Matrix
		Dim success As Boolean
		Dim i, n, v, v1, v2, ev, found As Double
		Dim cp As Double ()

		n = NumberOfRows(A)
		x = CreateSquareMatrix(n)
		q = CreateSquareMatrix(n)
		r = CreateSquareMatrix(n)
		eigenValuesReference.numberArray = New Double (n - 1){}
		success = QRAlgorithm(A, r, x, q, precision, maxIterations)
		found = 0.0
		If success
			Call ExtractDiagonal(x, eigenValuesReference.numberArray)

			' find the correct sign of the eigenvalue.
			cp = CharacteristicPolynomial(A)
			i = 0.0
			While i < n
				ev = eigenValuesReference.numberArray(i)

				v1 = pEvaluate(cp, ev)
				v2 = pEvaluate(cp, -ev)

				If Abs(v2) < Abs(v1)
					eigenValuesReference.numberArray(i) = -ev
					v = v2
				Else
					v = v1
				End If

				If Abs(v) < precision*10.0 ^ 4.0
					found = found + 1.0
				End If
				i = i + 1.0
			End While

			Call FreeMatrix(x)
			Call FreeMatrix(q)
			Call FreeMatrix(r)
		End If

		If found <> n
			success = false
		End If

		Return success
	End Function


	Public Function EigenvaluesUsingLaguerreIterations(ByRef A As Matrix, ByRef eigenValuesReference As NumberArrayReference) As Boolean
		Dim p As Double ()
		Dim success As Boolean

		p = CharacteristicPolynomial(A)
		success = FindRoots(p, eigenValuesReference)

		Return success
	End Function


	Public Sub GaussianElimination(ByRef A As Matrix)
		Dim h, k, m, n, maxElement, i, j, maxx, maxCandidate, f As Double

		m = NumberOfRows(A)
		n = NumberOfColumns(A)

		h = 0.0
		k = 0.0
		
		While h < m And k < n
			maxElement = h
			maxx = 0.0
			i = h
			While i < m
				maxCandidate = Abs(Element(A, i, k))
				If maxx < maxCandidate
					maxElement = i
					maxx = maxCandidate
				End If
				i = i + 1.0
			End While
			If A.r(maxElement).c(k) = 0.0
				k = k + 1.0
			Else
				Call SwapRows(A, h, maxElement)
				i = h + 1.0
				While i < m
					f = Element(A, i, k)/Element(A, h, k)
					A.r(i).c(k) = 0.0
					j = k + 1.0
					While j < n
						A.r(i).c(j) = Element(A, i, j) - Element(A, h, j)*f
						j = j + 1.0
					End While
					i = i + 1.0
				End While
				h = h + 1.0
				k = k + 1.0
			End If
		End While
	End Sub


	Public Function GaussianEliminationToNew(ByRef A As Matrix) As Matrix
		Dim X As Matrix

		X = CreateCopyOfMatrix(A)
		Call GaussianElimination(X)

		Return X
	End Function


	Public Function CreateCopyOfMatrix(ByRef A As Matrix) As Matrix
		Dim X As Matrix

		X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A))
		Call Assign(X, A)

		Return X
	End Function


	Public Sub SwapRows(ByRef A As Matrix, tox As Double, from As Double)
		Dim n As Double
		Dim c, t As Double

		c = NumberOfRows(A)
		n = 0.0
		While n < c
			t = A.r(tox).c(n)
			A.r(tox).c(n) = A.r(from).c(n)
			A.r(from).c(n) = t
			n = n + 1.0
		End While
	End Sub


	Public Sub UnnormalizeVector(ByRef numberArray As Double ())
		Dim i, m As Double
		Dim mSet As Boolean

		mSet = false
		m = 0.0

		i = 0.0
		While i < numberArray.Length
			If numberArray(i) - Truncatex(numberArray(i)) < 0.001
				If Not mSet
					m = Abs(numberArray(i))
					mSet = true
				Else
					m = Min(m, Abs(numberArray(i)))
				End If
			End If
			i = i + 1.0
		End While

		If mSet
			i = 0.0
			While i < numberArray.Length
				numberArray(i) = numberArray(i)/m
				i = i + 1.0
			End While
		End If
	End Sub


	Public Function InversePowerMethod(ByRef A As Matrix, eigenvalue As Double, maxIterations As Double, ByRef eigenvector As NumberArrayReference) As Boolean
		Dim x, y, z, b, t As Matrix
		Dim n, i, c As Double
		Dim singular As Boolean

		n = NumberOfRows(A)

		x = CreateIdentityMatrix(n)
		Call ScalarMultiply(x, eigenvalue)
		y = SubtractToNew(A, x)
		z = CreateSquareMatrix(n)
		singular = Not Inverse(y, z)
		If singular
			' Try again with more erroneous eigenvalue estimate.
			x = CreateIdentityMatrix(n)
			Call ScalarMultiply(x, eigenvalue*1.01)
			y = SubtractToNew(A, x)
			z = CreateSquareMatrix(n)
			singular = Not Inverse(y, z)
		End If

		If Not singular
			b = CreateMatrix(n, 1.0)

			i = 0.0
			While i < n
				b.r(i).c(0) = 1.0
				i = i + 1.0
			End While

			i = 0.0
			While i < maxIterations
				t = MultiplyToNew(z, b)
				c = Norm(t)
				Call ScalarDivide(t, c)
				Call Assign(b, t)
				i = i + 1.0
			End While

			eigenvector.numberArray = New Double (n - 1){}
			i = 0.0
			While i < n
				eigenvector.numberArray(i) = b.r(i).c(0)
				i = i + 1.0
			End While
		End If

		Return Not singular
	End Function


	Public Function Eigenvectors(ByRef A As Matrix, ByRef eigenVectorsReference As MatrixArrayReference) As Boolean
		Dim evsReference As NumberArrayReference
		Dim success As Boolean

		evsReference = New NumberArrayReference()
		success = Eigenpairs(A, evsReference, eigenVectorsReference)
		If success
			Erase evsReference.numberArray 
			evsReference = Nothing
		End If

		Return success
	End Function


	Public Function Eigenpairs(ByRef A As Matrix, ByRef eigenValuesReference As NumberArrayReference, ByRef eigenVectorsReference As MatrixArrayReference) As Boolean
		Return EigenpairsUsingQRAlgorithmAndInversePowerMethod(A, eigenValuesReference, eigenVectorsReference, 0.00000000001, 100.0)
	End Function


	Public Function EigenpairsUsingQRAlgorithmAndInversePowerMethod(ByRef M As Matrix, ByRef eigenValuesReference As NumberArrayReference, ByRef eigenVectorsReference As MatrixArrayReference, precision As Double, maxIterations As Double) As Boolean
		Dim evecReference As NumberArrayReference
		Dim done, inverseSuccess As Boolean
		Dim i, j, k, N, v1, v2, eigenValue, withinPrecision As Double
		Dim A, Q, R, eigenVector As Matrix
		Dim cp As Double ()

		N = NumberOfRows(M)

		A = CreateCopyOfMatrix(M)
		Q = CreateCopyOfMatrix(M)
		R = CreateCopyOfMatrix(M)

		done = false
		eigenVectorsReference.matrices = New Matrix (N - 1){}
		evecReference = New NumberArrayReference()
		eigenValuesReference.numberArray = New Double (N - 1){}
		cp = CharacteristicPolynomial(M)

		j = 0.0
		While j < N
			eigenVectorsReference.matrices(j) = CreateMatrix(N, 1.0)
			j = j + 1.0
		End While

		i = 0.0
		While i < maxIterations And Not done
			Call QRDecomposition(A, Q, R)
			Call Multiply(A, R, Q)

			' Check
			withinPrecision = 0.0
			Call ExtractDiagonal(R, eigenValuesReference.numberArray)

			j = 0.0
			While j < N
				' Find the correct sign of the eigenvalue.
				eigenValue = eigenValuesReference.numberArray(j)
				v1 = pEvaluate(cp, eigenValue)
				v2 = pEvaluate(cp, -eigenValue)
				If Abs(v2) < Abs(v1)
					eigenValuesReference.numberArray(j) = -eigenValue
					eigenValue = -eigenValue
				End If

				' Calculate the eigenvector corresponding to the eigenvalue.
				inverseSuccess = InversePowerMethod(M, eigenValue, i + 1.0, evecReference)
				If inverseSuccess
					k = 0.0
					While k < N
						eigenVectorsReference.matrices(j).r(k).c(0) = evecReference.numberArray(k)
						k = k + 1.0
					End While

					' Check eigenpair agains precision.
					eigenVector = eigenVectorsReference.matrices(j)

					If CheckEigenpairPrecision(M, eigenValue, eigenVector, precision)
						withinPrecision = withinPrecision + 1.0
					End If
				End If
				j = j + 1.0
			End While

			If withinPrecision = N
				done = true
			End If
			i = i + 1.0
		End While

		Call FreeMatrix(A)
		Call FreeMatrix(Q)
		Call FreeMatrix(R)
		evecReference = Nothing
		Erase cp 

		Return done
	End Function


	Public Function CheckEigenpairPrecision(ByRef a As Matrix, lambda As Double, ByRef e As Matrix, precision As Double) As Boolean
		Dim vec1, vec2 As Matrix
		Dim equal As Boolean

		vec1 = MultiplyToNew(a, e)
		vec2 = ScalarMultiplyToNew(e, lambda)

		equal = MatrixEqualsEpsilon(vec1, vec2, precision)

		Return equal
	End Function


	Public Function EigenvectorsLaguerreIterationsAndGaussianEliminations(ByRef A As Matrix, ByRef eigenVectorsReference As MatrixArrayReference) As Boolean
		Dim Id, t1, B, v As Matrix
		Dim eigenVectorsResult As Matrix ()
		Dim success As Boolean
		Dim eigenValuesReference As NumberArrayReference
		Dim i, lambda, j, N, x, k As Double
		Dim ev As Double ()

		N = NumberOfRows(A)

		eigenValuesReference = New NumberArrayReference()
		success = Eigenvalues(A, eigenValuesReference)

		eigenVectorsResult = New Matrix (N - 1){}

		If success
			ev = eigenValuesReference.numberArray

			Id = CreateIdentityMatrix(N)
			t1 = CreateSquareMatrix(N)
			B = CreateSquareMatrix(N)

			j = 0.0
			While j < ev.Length And success
				lambda = ev(j)

				' B = A - lambda * Id
				Call Assign(t1, Id)
				Call ScalarMultiply(t1, lambda)

				Call Assign(B, A)
				Call Subtract(B, t1)

				Call GaussianElimination(B)

				v = CreateMatrix(N, 1.0)
				v.r(N - 1.0).c(0) = 1.0
				i = N - 2.0
				While i >= 0.0 And success
					If Not RowIsZero(B, i)
						x = 0.0

						k = N - 1.0
						While k > i
							x = x - Element(B, i, k)*Element(v, k, 0.0)
							k = k - 1.0
						End While

						v.r(i).c(0) = x/Element(B, i, i)
					Else
						success = false
					End If
					i = i - 1.0
				End While

				eigenVectorsResult(j) = v
				j = j + 1.0
			End While

			Call FreeMatrix(t1)
			Call FreeMatrix(B)
			Call FreeMatrix(Id)

			eigenVectorsReference.matrices = eigenVectorsResult
		End If

		Return success
	End Function


	Public Function RowIsZero(ByRef X As Matrix, r As Double) As Boolean
		Dim isZero As Boolean
		Dim columns, i As Double

		isZero = true

		columns = NumberOfColumns(X)
		i = 0.0
		While i < columns And isZero
			If Element(X, r, i) <> 0.0
				isZero = false
			End If
			i = i + 1.0
		End While

		Return isZero
	End Function


	Public Sub FreeMatrix(ByRef X As Matrix)
		Call FreeMatrixRows(X.r)
		X = Nothing
	End Sub


	Public Sub FreeMatrixRows(ByRef r As MatrixRow ())
		Dim m, rows As Double

		rows = r.Length
		m = 0.0
		While m < rows
			Erase r(m).c 
			r(m) = Nothing
			m = m + 1.0
		End While

		Erase r 
	End Sub


	Public Function CreateDiagonalMatrixFromArray(ByRef arrayx As Double ()) As Matrix
		Dim m As Double
		Dim matrix As Matrix

		matrix = CreateSquareMatrix(arrayx.Length)
		Call Fill(matrix, 0.0)

		m = 0.0
		While m < arrayx.Length
			matrix.r(m).c(m) = arrayx(m)
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateMatrixFromRowCopies(ByRef row As Double (), times As Double) As Matrix
		Dim m, n As Double
		Dim matrix As Matrix

		matrix = CreateMatrix(times, row.Length)

		m = 0.0
		While m < times
			n = 0.0
			While n < row.Length
				matrix.r(m).c(n) = row(n)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Sub ExtractDiagonal(ByRef X As Matrix, ByRef diag As Double ())
		Dim n, i As Double

		n = NumberOfRows(X)

		i = 0.0
		While i < n
			diag(i) = X.r(i).c(i)
			i = i + 1.0
		End While
	End Sub


	Public Function ExtractDiagonalToNew(ByRef X As Matrix) As Double ()
		Dim diag As Double ()
		Dim n, i As Double

		n = NumberOfRows(X)
		diag = New Double (n - 1){}

		i = 0.0
		While i < n
			diag(i) = X.r(i).c(i)
			i = i + 1.0
		End While

		Return diag
	End Function


	Public Function MatrixEqualsEpsilon(ByRef a As Matrix, ByRef b As Matrix, epsilon As Double) As Boolean
		Dim x, y, columns, rows As Double
		Dim equals As Boolean

		equals = true

		If NumberOfRows(a) = NumberOfRows(b) And NumberOfColumns(a) = NumberOfColumns(b)
			columns = NumberOfColumns(a)
			rows = NumberOfRows(a)

			x = 0.0
			While x < rows
				y = 0.0
				While y < columns
					equals = equals And EpsilonCompare(Element(a, x, y), Element(b, x, y), epsilon)
					y = y + 1.0
				End While
				x = x + 1.0
			End While
		Else
			equals = false
		End If

		Return equals
	End Function


	Public Function Minor(ByRef x As Matrix, row As Double, column As Double) As Matrix
		Dim theMinor As Matrix
		Dim cols, rows, i, j, m, n As Double

		rows = NumberOfRows(x) - 1.0
		cols = NumberOfColumns(x) - 1.0

		theMinor = CreateMatrix(rows, cols)

		i = 0.0
		While i < rows
			If i < row
				m = i
			Else
				m = i + 1.0
			End If

			j = 0.0
			While i <> row And j < cols
				If j <> column

					If j < column
						n = j
					Else
						n = j + 1.0
					End If

					theMinor.r(m).c(n) = x.r(i).c(j)
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return theMinor
	End Function


	Public Sub QRDecomposition(ByRef m As Matrix, ByRef Q As Matrix, ByRef R As Matrix)
		Call HouseholderMethod(m, Q, R)
	End Sub


	Public Sub HouseholderTriangularizationAlgorithm(ByRef m As Matrix, ByRef Qout As Matrix, ByRef Rout As Matrix)
		Dim P, AA, A, PP, v, vt, t As Matrix
		Dim i, j, rows, cols, r, s As Double

		rows = NumberOfRows(m)
		cols = NumberOfColumns(m)

		P = CreateIdentityMatrix(rows)
		A = CreateCopyOfMatrix(m)
		AA = CreateMatrix(rows, cols)

		t = CreateMatrix(rows, cols)
		PP = CreateIdentityMatrix(rows)
		vt = CreateMatrix(1.0, rows)

		j = 0.0
		While j < cols
			v = ExtractSubMatrix(A, 0.0, rows - 1.0, j, j)
			If j > 0.0
				i = 0.0
				While i < j
					v.r(i).c(0) = 0.0
					i = i + 1.0
				End While
			End If

			s = Signx(v.r(j).c(0))
			If s = 0.0
				s = 1.0
			End If
			v.r(j).c(0) = v.r(j).c(0) + Norm(v)*s
			r = -2.0/(Norm(v)*Norm(v))
			Call Assign(AA, A)

			Call TransposeAssign(vt, v)
			Call Multiply(t, vt, A)
			Call Assign(A, t)
			Call Multiply(t, v, A)
			Call Assign(A, t)
			Call ScalarMultiply(A, r)
			Call Assign(t, AA)
			Call Add(A, AA)

			Call Assign(PP, P)

			Call Multiply(t, vt, P)
			Call Assign(P, t)
			Call Multiply(t, v, P)
			Call Assign(P, t)
			Call ScalarMultiply(P, r)
			Call Assign(t, AA)
			Call Add(P, PP)
			j = j + 1.0
		End While

		Call Assign(Rout, A)
		Call Assign(Qout, P)
		Call Transpose(Qout)
	End Sub


	Public Sub HouseholderMethod(ByRef A As Matrix, ByRef q As Matrix, ByRef r As Matrix)
		Dim QR, R, Q As Matrix
		Dim Rdiag As Double ()
		Dim m, n As Double
		Dim i, j, k As Double
		Dim s, nrm As Double
		Dim e As Double
		Dim N, ra, rq As Matrix

		' Initialize.
		QR = CreateCopyOfMatrix(A)
		m = NumberOfRows(A)
		n = NumberOfColumns(A)
		Rdiag = New Double (n - 1){}

		' Main loop.
		k = 0.0
		While k < n
			' Compute 2-norm of k-th column without under/overflow.
			nrm = 0.0
			i = k
			While i < m
				nrm = Hypothenuse(nrm, Element(QR, i, k))
				i = i + 1.0
			End While

			If nrm <> 0.0
				' Form k-th Householder vector.
				If Element(QR, k, k) < 0.0
					nrm = -nrm
				End If
				i = k
				While i < m
					QR.r(i).c(k) = Element(QR, i, k)/nrm
					i = i + 1.0
				End While
				QR.r(k).c(k) = Element(QR, k, k) + 1.0

				' Apply transformation to remaining columns.
				j = k + 1.0
				While j < n
					s = 0.0
					i = k
					While i < m
						s = s + Element(QR, i, k)*Element(QR, i, j)
						i = i + 1.0
					End While
					s = -s/Element(QR, k, k)
					i = k
					While i < m
						QR.r(i).c(j) = Element(QR, i, j) + s*Element(QR, i, k)
						i = i + 1.0
					End While
					j = j + 1.0
				End While
			End If
			Rdiag(k) = -nrm
			k = k + 1.0
		End While

		' Compute R
		R = CreateSquareMatrix(n)
		i = 0.0
		While i < n
			j = 0.0
			While j < n
				If i < j
					R.r(i).c(j) = Element(QR, i, j)
				ElseIf i = j
					R.r(i).c(j) = Rdiag(i)
				Else
					R.r(i).c(j) = 0.0
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While
		Call Assign(r, R)

		' Compute Q
		Q = CreateMatrix(m, n)
		k = n - 1.0
		While k >= 0.0
			i = 0.0
			While i < m
				Q.r(i).c(k) = 0.0
				i = i + 1.0
			End While
			Q.r(k).c(k) = 1.0
			j = k
			While j < n
				If Element(QR, k, k) <> 0.0
					s = 0.0
					i = k
					While i < m
						s = s + Element(QR, i, k)*Element(Q, i, j)
						i = i + 1.0
					End While
					s = -s/Element(QR, k, k)
					i = k
					While i < m
						Q.r(i).c(j) = Element(Q, i, j) + s*Element(QR, i, k)
						i = i + 1.0
					End While
				End If
				j = j + 1.0
			End While
			k = k - 1.0
		End While
		Call Assign(q, Q)

		' Adjust for positive R.
		n = NumberOfRows(r)

		N = CreateIdentityMatrix(n)

		i = 0.0
		While i < n
			e = Element(r, i, i)

			If e < 0.0
				N.r(i).c(i) = -1.0
			End If
			i = i + 1.0
		End While

		ra = MultiplyToNew(N, r)
		Call Assign(r, ra)
		rq = MultiplyToNew(q, N)
		Call Assign(q, rq)

		Call FreeMatrix(ra)
		Call FreeMatrix(rq)
		Call FreeMatrix(Q)
		Call FreeMatrix(R)
		Call FreeMatrix(QR)
	End Sub


	Public Function Hypothenuse(a As Double, b As Double) As Double
		Return Sqrt(a ^ 2.0 + b ^ 2.0)
	End Function


	Public Function Norm(ByRef a As Matrix) As Double
		Dim l, i, j, rows, cols As Double

		l = 0.0

		rows = NumberOfRows(a)
		cols = NumberOfColumns(a)

		i = 0.0
		While i < rows
			j = 0.0
			While j < cols
				l = l + a.r(i).c(j)*a.r(i).c(j)
				j = j + 1.0
			End While
			i = i + 1.0
		End While
		l = Sqrt(l)

		Return l
	End Function


	Public Function ExtractSubMatrix(ByRef M As Matrix, r1 As Double, r2 As Double, c1 As Double, c2 As Double) As Matrix
		Dim A As Matrix
		Dim i, j As Double

		A = CreateMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0)

		i = r1
		While i <= r2
			j = c1
			While j <= c2
				A.r(i - r1).c(j - c1) = M.r(i).c(j)
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return A
	End Function


	Public Function QRAlgorithm(ByRef M As Matrix, ByRef R As Matrix, ByRef A As Matrix, ByRef Q As Matrix, precision As Double, maxIterations As Double) As Boolean
		Dim n, i, j, v As Double
		Dim previous As Double ()
		Dim withinPrecision As Double
		Dim done, previousSet As Boolean

		Call Assign(A, M)
		n = NumberOfRows(M)
		previous = New Double (n - 1){}
		previousSet = false

		done = false
		i = 0.0
		While i < maxIterations And Not done
			Call QRDecomposition(A, Q, R)
			Call Multiply(A, R, Q)

			' Check precision.
			If previousSet
				withinPrecision = 0.0
				j = 0.0
				While j < n
					v = previous(j) - Element(A, j, j)
					If Abs(v) < precision Or v = 0.0
						withinPrecision = withinPrecision + 1.0
					End If
					j = j + 1.0
				End While
				If withinPrecision = n
					done = true
				End If
			End If

			j = 0.0
			While j < n
				previous(j) = Element(A, j, j)
				j = j + 1.0
			End While
			previousSet = true
			i = i + 1.0
		End While

		Return done
	End Function


	Public Function InvertUpperTriangularMatrix(ByRef A As Matrix, ByRef inverse As Matrix) As Boolean
		Dim sum, i, j, k, n As Double
		Dim success As Boolean

		inverse.r = CreateCopyOfMatrix(A).r
		n = NumberOfRows(inverse)
		success = true

		i = n - 1.0
		While i >= 0.0 And success
			If Element(inverse, i, i) = 0.0
				success = false
			Else
				inverse.r(i).c(i) = 1.0/Element(inverse, i, i)
				j = i - 1.0
				While j >= 0.0 And success
					sum = 0.0
					k = i
					While k > j
						sum = sum - Element(inverse, j, k)*Element(inverse, k, i)
						k = k - 1.0
					End While
					If Element(inverse, j, j) = 0.0
						success = false
					Else
						inverse.r(j).c(i) = sum/Element(inverse, j, j)
					End If
					j = j - 1.0
				End While
			End If
			i = i - 1.0
		End While

		Return success
	End Function


	Public Function InvertLowerTriangularMatrix(ByRef A As Matrix, ByRef inverse As Matrix) As Boolean
		Dim sum, i, j, k, n As Double
		Dim success As Boolean

		inverse.r = CreateCopyOfMatrix(A).r
		n = NumberOfRows(inverse)
		success = true

		i = 0.0
		While i < n And success
			If Element(inverse, i, i) = 0.0
				success = false
			Else
				inverse.r(i).c(i) = 1.0/Element(inverse, i, i)
				j = i + 1.0
				While j < n
					sum = 0.0
					k = i
					While k < j And success
						sum = sum - Element(inverse, j, k)*Element(inverse, k, i)
						k = k + 1.0
					End While
					If Element(inverse, j, j) = 0.0
						success = false
					Else
						inverse.r(j).c(i) = sum/Element(inverse, j, j)
					End If
					j = j + 1.0
				End While
			End If
			i = i + 1.0
		End While

		Return success
	End Function


	Public Function ParseMatrixFromString(ByRef aref As MatrixReference, ByRef matrixString As Char (), ByRef errorMessage As StringReference) As Boolean
		Dim success As Boolean
		Dim lines As StringReference ()
		Dim rows, cols, i As Double
		Dim row As Double ()
		Dim replaced, trimmed As Char ()

		replaced = strReplaceString(matrixString, "" + vbcr + "".ToCharArray(), "".ToCharArray())
		trimmed = strTrim(replaced)
		lines = strSplitByCharacter(trimmed, vblf)

		Erase replaced 
		Erase trimmed 

		success = true

		rows = lines.Length
		If rows = 0.0
			aref.matrix = CreateMatrix(0.0, 0.0)
		Else
			row = StringToNumberArray(lines(0).stringx)
			cols = row.Length
			Erase row 

			aref.matrix = CreateMatrix(rows, cols)

			i = 0.0
			While i < rows And success
				Erase aref.matrix.r(i).c 
				aref.matrix.r(i).c = StringToNumberArray(lines(i).stringx)

				If aref.matrix.r(i).c.Length <> cols
					success = false
					errorMessage.stringx = "All rows must have the same number of columns.".ToCharArray()
				End If
				i = i + 1.0
			End While
		End If

		Call FreeStringReferenceArray(lines)

		Return success
	End Function


	Public Function MatrixToString(ByRef matrix As Matrix, digitsAfterPoint As Double) As Char ()
		Dim s1, s2 As Char ()
		Dim n, m, element As Double

		s1 = New Char (0 - 1){}

		n = 0.0
		While n < NumberOfRows(matrix)
			m = 0.0
			While m < NumberOfColumns(matrix)
				element = Element(matrix, n, m)
				element = RoundToDigits(element, digitsAfterPoint)
				s2 = strAppendString(s1, CreateStringDecimalFromNumber(element))
				Erase s1 
				s1 = s2
				If m + 1.0 <> NumberOfColumns(matrix)
					s2 = strAppendString(s1, ", ".ToCharArray())
					Erase s1 
					s1 = s2
				End If
				m = m + 1.0
			End While
			s2 = strAppendString(s1, "" + vblf + "".ToCharArray())
			Erase s1 
			s1 = s2
			n = n + 1.0
		End While

		Return s1
	End Function


	Public Function MatrixArrayToString(ByRef matrices As Matrix (), digitsAfterPoint As Double) As Char ()
		Dim s1, s2 As Char ()
		Dim i As Double

		s1 = New Char (0 - 1){}

		i = 0.0
		While i < matrices.Length
			s2 = strAppendString(s1, MatrixToString(matrices(i), digitsAfterPoint))
			Erase s1 
			s1 = s2

			s2 = strAppendString(s1, "" + vblf + "".ToCharArray())
			Erase s1 
			s1 = s2
			i = i + 1.0
		End While

		Return s1
	End Function


	Public Sub RoundMatrixElementsToDigits(ByRef a As Matrix, digits As Double)
		Dim m, n As Double

		m = 0.0
		While m < NumberOfRows(a)
			n = 0.0
			While n < NumberOfColumns(a)
				a.r(m).c(n) = RoundToDigits(Element(a, m, n), digits)
				If a.r(m).c(n) = -0.0
					a.r(m).c(n) = 0.0
				End If
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function SingularValueDecomposition(ByRef Ap As Matrix, ByRef URef As MatrixReference, ByRef SigmaRef As MatrixReference, ByRef VRef As MatrixReference) As Boolean
		Dim A, U, V As Matrix
		Dim m, n, nu, nct, nrt, i, j, k, t, pp, iter, eps, tiny, kase, f, cs, sn, ks, size, orgm, orgn As Double
		Dim scale, sp, spm1, epm1, sk, ek, b, c, shift, g, p As Double
		Dim done As Boolean
		Dim s, e, work As Double ()

		' Square matrix, adjust results correspondingly.
		orgm = NumberOfRows(Ap)
		orgn = NumberOfColumns(Ap)
		size = Max(orgm, orgn)
		A = CreateCopyOfMatrix(Ap)
		Call Resize(A, size, size)

		' Initialize.
		m = size
		n = size

		' Compute
		nu = Min(m, n)
		s = New Double (Min(m + 1.0, n) - 1){}
		U = CreateMatrix(m, nu)
		V = CreateSquareMatrix(n)
		e = New Double (n - 1){}
		work = New Double (m - 1){}

		' Reduce A to bidiagonal form, storing the diagonal elements in s and the super-diagonal elements in e.
		nct = Min(m - 1.0, n)
		nrt = Max(0.0, Min(n - 2.0, m))
		k = 0.0
		While k < Max(nct, nrt)
			If k < nct

				' Compute the transformation for the k-th column and place the k-th diagonal in s[k].
				' Compute 2-norm of k-th column without under/overflow.
				s(k) = 0.0
				i = k
				While i < m
					s(k) = Hypothenuse(s(k), Element(A, i, k))
					i = i + 1.0
				End While
				If s(k) <> 0.0
					If Element(A, k, k) < 0.0
						s(k) = -s(k)
					End If
					i = k
					While i < m
						A.r(i).c(k) = Element(A, i, k)/s(k)
						i = i + 1.0
					End While
					A.r(k).c(k) = Element(A, k, k) + 1.0
				End If
				s(k) = -s(k)
			End If
			j = k + 1.0
			While j < n
				If (k < nct) And (s(k) <> 0.0)

					' Apply the transformation.
					t = 0.0
					i = k
					While i < m
						t = t + Element(A, i, k)*Element(A, i, j)
						i = i + 1.0
					End While
					t = -t/Element(A, k, k)
					i = k
					While i < m
						A.r(i).c(j) = Element(A, i, j) + t*Element(A, i, k)
						i = i + 1.0
					End While
				End If

				' Place the k-th row of A into e for the subsequent calculation of the row transformation.
				e(j) = Element(A, k, j)
				j = j + 1.0
			End While
			If k < nct

				' Place the transformation in U for subsequent back
				' multiplication.
				i = k
				While i < m
					U.r(i).c(k) = Element(A, i, k)
					i = i + 1.0
				End While
			End If
			If k < nrt
				' Compute the k-th row transformation and place the k-th super-diagonal in e[k].
				' Compute 2-norm without under/overflow.
				e(k) = 0.0
				i = k + 1.0
				While i < n
					e(k) = Hypothenuse(e(k), e(i))
					i = i + 1.0
				End While
				If e(k) <> 0.0
					If e(k + 1.0) < 0.0
						e(k) = -e(k)
					End If
					i = k + 1.0
					While i < n
						e(i) = e(i)/e(k)
						i = i + 1.0
					End While
					e(k + 1.0) = e(k + 1.0) + 1.0
				End If
				e(k) = -e(k)
				If (k + 1.0 < m) And (e(k) <> 0.0)

					' Apply the transformation.
					i = k + 1.0
					While i < m
						work(i) = 0.0
						i = i + 1.0
					End While
					j = k + 1.0
					While j < n
						i = k + 1.0
						While i < m
							work(i) = work(i) + e(j)*Element(A, i, j)
							i = i + 1.0
						End While
						j = j + 1.0
					End While
					j = k + 1.0
					While j < n
						t = -e(j)/e(k + 1.0)
						i = k + 1.0
						While i < m
							A.r(i).c(j) = Element(A, i, j) + t*work(i)
							i = i + 1.0
						End While
						j = j + 1.0
					End While
				End If

				' Place the transformation in V for subsequent back multiplication.
				i = k + 1.0
				While i < n
					V.r(i).c(k) = e(i)
					i = i + 1.0
				End While
			End If
			k = k + 1.0
		End While

		' Set up the final bidiagonal matrix or order p.
		p = Min(n, m + 1.0)
		If nct < n
			s(nct) = Element(A, nct, nct)
		End If
		If m < p
			s(p - 1.0) = 0.0
		End If
		If nrt + 1.0 < p
			e(nrt) = Element(A, nrt, p - 1.0)
		End If
		e(p - 1.0) = 0.0

		' Generate U.
		j = nct
		While j < nu
			i = 0.0
			While i < m
				U.r(i).c(j) = 0.0
				i = i + 1.0
			End While
			U.r(j).c(j) = 1.0
			j = j + 1.0
		End While
		k = nct - 1.0
		While k >= 0.0
			If s(k) <> 0.0
				j = k + 1.0
				While j < nu
					t = 0.0
					i = k
					While i < m
						t = t + Element(U, i, k)*Element(U, i, j)
						i = i + 1.0
					End While
					t = -t/Element(U, k, k)
					i = k
					While i < m
						U.r(i).c(j) = Element(U, i, j) + t*Element(U, i, k)
						i = i + 1.0
					End While
					j = j + 1.0
				End While
				i = k
				While i < m
					U.r(i).c(k) = -Element(U, i, k)
					i = i + 1.0
				End While
				U.r(k).c(k) = 1.0 + Element(U, k, k)
				i = 0.0
				While i < k - 1.0
					U.r(i).c(k) = 0.0
					i = i + 1.0
				End While
			Else
				i = 0.0
				While i < m
					U.r(i).c(k) = 0.0
					i = i + 1.0
				End While
				U.r(k).c(k) = 1.0
			End If
			k = k - 1.0
		End While

		' Generate V.
		k = n - 1.0
		While k >= 0.0
			If (k < nrt) And (e(k) <> 0.0)
				j = k + 1.0
				While j < nu
					t = 0.0
					i = k + 1.0
					While i < n
						t = t + Element(V, i, k)*Element(V, i, j)
						i = i + 1.0
					End While
					t = -t/Element(V, k + 1.0, k)
					i = k + 1.0
					While i < n
						V.r(i).c(j) = Element(V, i, j) + t*Element(V, i, k)
						i = i + 1.0
					End While
					j = j + 1.0
				End While
			End If
			i = 0.0
			While i < n
				V.r(i).c(k) = 0.0
				i = i + 1.0
			End While
			V.r(k).c(k) = 1.0
			k = k - 1.0
		End While

		' Main iteration loop for the singular values.
		pp = p - 1.0
		iter = 0.0
		eps = 2.0 ^ (-52.0)
		tiny = 2.0 ^ (-966.0)
		
		While p > 0.0
			' Here is where a test for too many iterations would go.
			' This section of the program inspects for negligible elements in the s and e arrays.
			' On completion the variables kase and k are set as follows.
			' kase = 1, if s(p) and e[k-1] are negligible and k<p
			' kase = 2, if s(k) is negligible and k<p
			' kase = 3, if e[k-1] is negligible, k<p, and s(k), ..., s(p) are not negligible (qr step).
			' kase = 4, if e(p-1) is negligible (convergence).
			done = false
			k = p - 2.0
			While k > -1.0 And Not done
				If Abs(e(k)) <= tiny + eps*(Abs(s(k)) + Abs(s(k + 1.0)))
					e(k) = 0.0
					done = true
				Else
					k = k - 1.0
				End If
			End While
			If k = p - 2.0
				kase = 4.0
			Else
				done = false
				ks = p - 1.0
				While ks > k And Not done
					If ks <> p
						t = Abs(e(ks))
					Else
						t = 0.0
					End If

					If ks <> k + 1.0
						t = t + Abs(e(ks - 1.0))
					End If

					If Abs(s(ks)) <= tiny + eps*t
						s(ks) = 0.0
						done = true
					Else
						ks = ks - 1.0
					End If
				End While
				If ks = k
					kase = 3.0
				ElseIf ks = p - 1.0
					kase = 1.0
				Else
					kase = 2.0
					k = ks
				End If
			End If
			k = k + 1.0

			' Perform the task indicated by kase.
			If kase = 1.0
				' Deflate negligible s(p).
				f = e(p - 2.0)
				e(p - 2.0) = 0.0
				j = p - 2.0
				While j >= k
					t = Hypothenuse(s(j), f)
					cs = s(j)/t
					sn = f/t
					s(j) = t
					If j <> k
						f = -sn*e(j - 1.0)
						e(j - 1.0) = cs*e(j - 1.0)
					End If

					i = 0.0
					While i < n
						t = cs*Element(V, i, j) + sn*Element(V, i, p - 1.0)
						V.r(i).c(p - 1.0) = -sn*Element(V, i, j) + cs*Element(V, i, p - 1.0)
						V.r(i).c(j) = t
						i = i + 1.0
					End While
					j = j - 1.0
				End While
			ElseIf kase = 2.0
				' Split at negligible s(k).
				f = e(k - 1.0)
				e(k - 1.0) = 0.0
				j = k
				While j < p
					t = Hypothenuse(s(j), f)
					cs = s(j)/t
					sn = f/t
					s(j) = t
					f = -sn*e(j)
					e(j) = cs*e(j)

					i = 0.0
					While i < m
						t = cs*Element(U, i, j) + sn*Element(U, i, k + 1.0)
						U.r(i).c(k - 1.0) = -sn*Element(U, i, j) + cs*Element(U, i, k + 1.0)
						U.r(i).c(j) = t
						i = i + 1.0
					End While
					j = j + 1.0
				End While
			ElseIf kase = 3.0
				' Perform one qr step.
				' Calculate the shift.
				scale = Max(Max(Max(Max(Abs(s(p - 1.0)), Abs(s(p - 2.0))), Abs(e(p - 2.0))), Abs(s(k))), Abs(e(k)))
				sp = s(p - 1.0)/scale
				spm1 = s(p - 2.0)/scale
				epm1 = e(p - 2.0)/scale
				sk = s(k)/scale
				ek = e(k)/scale
				b = ((spm1 + sp)*(spm1 - sp) + epm1*epm1)/2.0
				c = (sp*epm1)*(sp*epm1)
				shift = 0.0
				If (b <> 0.0) Or (c <> 0.0)
					shift = Sqrt(b*b + c)
					If b < 0.0
						shift = -shift
					End If
					shift = c/(b + shift)
				End If
				f = (sk + sp)*(sk - sp) + shift
				g = sk*ek

				' Chase zeros.
				j = k
				While j < p - 1.0
					t = Hypothenuse(f, g)
					cs = f/t
					sn = g/t
					If j <> k
						e(j - 1.0) = t
					End If
					f = cs*s(j) + sn*e(j)
					e(j) = cs*e(j) - sn*s(j)
					g = sn*s(j + 1.0)
					s(j + 1.0) = cs*s(j + 1.0)
					i = 0.0
					While i < n
						t = cs*Element(V, i, j) + sn*Element(V, i, j + 1.0)
						V.r(i).c(j + 1.0) = -sn*Element(V, i, j) + cs*Element(V, i, j + 1.0)
						V.r(i).c(j) = t
						i = i + 1.0
					End While
					t = Hypothenuse(f, g)
					cs = f/t
					sn = g/t
					s(j) = t
					f = cs*e(j) + sn*s(j + 1.0)
					s(j + 1.0) = -sn*e(j) + cs*s(j + 1.0)
					g = sn*e(j + 1.0)
					e(j + 1.0) = cs*e(j + 1.0)
					If j < m - 1.0
						i = 0.0
						While i < m
							t = cs*Element(U, i, j) + sn*Element(U, i, j + 1.0)
							U.r(i).c(j + 1.0) = -sn*Element(U, i, j) + cs*Element(U, i, j + 1.0)
							U.r(i).c(j) = t
							i = i + 1.0
						End While
					End If
					j = j + 1.0
				End While
				e(p - 2.0) = f
				iter = iter + 1.0
			ElseIf kase = 4.0
				' Make the singular values positive.
				If s(k) <= 0.0
					If s(k) < 0.0
						s(k) = -s(k)
					Else
						s(k) = 0.0
					End If

					i = 0.0
					While i <= pp
						V.r(i).c(k) = -Element(V, i, k)
						i = i + 1.0
					End While
				End If

				' Order the singular values.
				
				While k < pp And s(k) < s(k + 1.0)
					t = s(k)
					s(k) = s(k + 1.0)
					s(k + 1.0) = t
					If k < n - 1.0
						i = 0.0
						While i < n
							t = Element(V, i, k + 1.0)
							V.r(i).c(k + 1.0) = Element(V, i, k)
							V.r(i).c(k) = t
							i = i + 1.0
						End While
					End If
					If k < m - 1.0
						i = 0.0
						While i < m
							t = Element(U, i, k + 1.0)
							U.r(i).c(k + 1.0) = Element(U, i, k)
							U.r(i).c(k) = t
							i = i + 1.0
						End While
					End If
					k = k + 1.0
				End While
				iter = 0.0
				p = p - 1.0
			End If
		End While

		Call Resize(U, orgm, orgm)
		Call Resize(V, orgn, orgn)

		URef.matrix = U
		VRef.matrix = V
		SigmaRef.matrix = CreateMatrix(orgm, orgn)
		i = 0.0
		While i < Min(orgm, orgn)
			SigmaRef.matrix.r(i).c(i) = s(i)
			i = i + 1.0
		End While

		Return true
	End Function


	Public Function CreateComplexMatrix(rows As Double, cols As Double) As ComplexMatrix
		Dim m, n As Double
		Dim matrix As ComplexMatrix

		matrix = New ComplexMatrix()
		matrix.r = New ComplexMatrixRow (rows - 1){}
		m = 0.0
		While m < rows
			matrix.r(m) = New ComplexMatrixRow()
			matrix.r(m).c = New cComplexNumber (cols - 1){}
			n = 0.0
			While n < cols
				matrix.r(m).c(n) = cCreateComplexNumber(0.0, 0.0)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateComplexMatrixFromMatrix(ByRef a As Matrix) As ComplexMatrix
		Dim m, n, rows, cols As Double
		Dim matrix As ComplexMatrix

		rows = NumberOfRows(a)
		cols = NumberOfColumns(a)

		matrix = New ComplexMatrix()
		matrix.r = New ComplexMatrixRow (rows - 1){}
		m = 0.0
		While m < rows
			matrix.r(m) = New ComplexMatrixRow()
			matrix.r(m).c = New cComplexNumber (cols - 1){}
			n = 0.0
			While n < cols
				matrix.r(m).c(n) = cCreateComplexNumber(a.r(m).c(n), 0.0)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateReMatrixFromComplexMatrix(ByRef a As ComplexMatrix) As Matrix
		Dim m, n, rows, cols As Double
		Dim matrix As Matrix

		rows = NumberOfRowsComplex(a)
		cols = NumberOfColumnsComplex(a)

		matrix = New Matrix()
		matrix.r = New MatrixRow (rows - 1){}
		m = 0.0
		While m < rows
			matrix.r(m) = New MatrixRow()
			matrix.r(m).c = New Double (cols - 1){}
			n = 0.0
			While n < cols
				matrix.r(m).c(n) = IndexComplex(a, m, n).re
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateImMatrixFromComplexMatrix(ByRef a As ComplexMatrix) As Matrix
		Dim m, n, rows, cols As Double
		Dim matrix As Matrix

		rows = NumberOfRowsComplex(a)
		cols = NumberOfColumnsComplex(a)

		matrix = New Matrix()
		matrix.r = New MatrixRow (rows - 1){}
		m = 0.0
		While m < rows
			matrix.r(m) = New MatrixRow()
			matrix.r(m).c = New Double (cols - 1){}
			n = 0.0
			While n < cols
				matrix.r(m).c(n) = IndexComplex(a, m, n).im
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function NumberOfRowsComplex(ByRef A As ComplexMatrix) As Double
		Return A.r.Length
	End Function


	Public Function NumberOfColumnsComplex(ByRef A As ComplexMatrix) As Double
		Return A.r(0).c.Length
	End Function


	Public Function IndexComplex(ByRef a As ComplexMatrix, m As Double, n As Double) As cComplexNumber
		Return a.r(m).c(n)
	End Function


	Public Sub AddComplex(ByRef a As ComplexMatrix, ByRef b As ComplexMatrix)
		Dim m, n As Double
		Dim d As Double

		d = NumberOfRowsComplex(a)

		m = 0.0
		While m < d
			n = 0.0
			While n < d
				Call cAdd(IndexComplex(a, m, n), IndexComplex(b, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub SubtractComplex(ByRef a As ComplexMatrix, ByRef b As ComplexMatrix)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRowsComplex(a)
		c = NumberOfColumnsComplex(a)

		m = 0.0
		While m < r
			n = 0.0
			While n < c
				Call cSub(IndexComplex(a, m, n), IndexComplex(b, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function SubtractComplexToNew(ByRef a As ComplexMatrix, ByRef b As ComplexMatrix) As ComplexMatrix
		Dim X As ComplexMatrix

		X = CreateCopyOfComplexMatrix(a)
		Call SubtractComplex(X, b)

		Return X
	End Function


	Public Sub MultiplyComplex(ByRef x As ComplexMatrix, ByRef a As ComplexMatrix, ByRef b As ComplexMatrix)
		Dim m, n As Double
		Dim rows, cols, d As Double
		Dim i As Double
		Dim s, t As cComplexNumber

		rows = NumberOfRowsComplex(a)
		cols = NumberOfColumnsComplex(b)
		d = NumberOfColumnsComplex(a)
		t = cCreateComplexNumber(0.0, 0.0)

		m = 0.0
		While m < rows
			n = 0.0
			While n < cols
				s = cCreateComplexNumber(0.0, 0.0)

				i = 0.0
				While i < d
					Call cAssignComplex(t, s)
					Call cAssignComplex(s, IndexComplex(a, m, i))
					Call cMul(s, IndexComplex(b, i, n))
					Call cAdd(s, t)
					i = i + 1.0
				End While

				x.r(m).c(n) = s
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function MultiplyComplexToNew(ByRef a As ComplexMatrix, ByRef b As ComplexMatrix) As ComplexMatrix
		Dim rows, cols As Double
		Dim x As ComplexMatrix

		rows = NumberOfRowsComplex(a)
		cols = NumberOfColumnsComplex(b)
		x = CreateComplexMatrix(rows, cols)
		Call MultiplyComplex(x, a, b)

		Return x
	End Function


	Public Sub Conjugate(ByRef a As ComplexMatrix)
		Dim m, n As Double
		Dim rows, cols As Double

		rows = NumberOfRowsComplex(a)
		cols = NumberOfRowsComplex(a)

		m = 0.0
		While m < rows
			n = 0.0
			While n < cols
				Call cConjugate(IndexComplex(a, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub AssignComplexMatrix(ByRef A As ComplexMatrix, ByRef B As ComplexMatrix)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRowsComplex(A)
		c = NumberOfColumnsComplex(A)

		m = 0.0
		While m < r
			n = 0.0
			While n < c
				Call cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub ScalarMultiplyComplex(ByRef A As ComplexMatrix, ByRef b As cComplexNumber)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRowsComplex(A)
		c = NumberOfColumnsComplex(A)

		m = 0.0
		While m < r
			n = 0.0
			While n < c
				Call cMul(IndexComplex(A, m, n), b)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function ScalarMultiplyComplexToNew(ByRef A As ComplexMatrix, ByRef b As cComplexNumber) As ComplexMatrix
		Dim matrix As ComplexMatrix

		matrix = CreateCopyOfComplexMatrix(A)
		Call ScalarMultiplyComplex(matrix, b)

		Return matrix
	End Function


	Public Sub ScalarDivideComplex(ByRef A As ComplexMatrix, ByRef b As cComplexNumber)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRowsComplex(A)
		c = NumberOfColumnsComplex(A)

		m = 0.0
		While m < r
			n = 0.0
			While n < c
				Call cDiv(IndexComplex(A, m, n), b)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Sub ElementWisePowerComplex(ByRef A As ComplexMatrix, p As Double)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRowsComplex(A)
		c = NumberOfColumnsComplex(A)

		m = 0.0
		While m < r
			n = 0.0
			While n < c
				Call cPower(IndexComplex(A, m, n), p)
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function CreateComplexIdentityMatrix(d As Double) As ComplexMatrix
		Dim m As Double
		Dim matrix As ComplexMatrix

		matrix = CreateSquareComplexMatrix(d)
		Call FillComplex(matrix, 0.0, 0.0)

		m = 0.0
		While m < d
			IndexComplex(matrix, m, m).re = 1.0
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Function CreateSquareComplexMatrix(d As Double) As ComplexMatrix
		Dim m, n As Double
		Dim matrix As ComplexMatrix

		matrix = New ComplexMatrix()
		matrix.r = New ComplexMatrixRow (d - 1){}
		m = 0.0
		While m < d
			matrix.r(m) = New ComplexMatrixRow()
			matrix.r(m).c = New cComplexNumber (d - 1){}
			n = 0.0
			While n < d
				matrix.r(m).c(n) = cCreateComplexNumber(0.0, 0.0)
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return matrix
	End Function


	Public Sub ClearComplex(ByRef a As ComplexMatrix)
		Call FillComplex(a, 0.0, 0.0)
	End Sub


	Public Sub FillComplex(ByRef a As ComplexMatrix, re As Double, im As Double)
		Dim m, n As Double

		m = 0.0
		While m < NumberOfRowsComplex(a)
			n = 0.0
			While n < NumberOfColumnsComplex(a)
				IndexComplex(a, m, n).re = re
				IndexComplex(a, m, n).im = im
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function TraceComplex(ByRef a As ComplexMatrix) As cComplexNumber
		Dim m As Double
		Dim d As Double
		Dim tr As cComplexNumber

		tr = cCreateComplexNumber(0.0, 0.0)

		d = a.r.Length
		m = 0.0
		While m < d
			Call cAdd(tr, IndexComplex(a, m, m))
			m = m + 1.0
		End While

		Return tr
	End Function


	Public Sub CofactorOfComplexMatrix(ByRef mat As ComplexMatrix, ByRef temp As ComplexMatrix, p As Double, q As Double, n As Double)
		Dim i, j As Double
		Dim row, col As Double

		i = 0.0
		j = 0.0

		row = 0.0
		While row < n
			col = 0.0
			While col < n
				If row <> p And col <> q
					Call cAssignComplex(IndexComplex(temp, i, j), IndexComplex(mat, row, col))
					j = j + 1.0

					If j = n - 1.0
						j = 0.0
						i = i + 1.0
					End If
				End If
				col = col + 1.0
			End While
			row = row + 1.0
		End While
	End Sub


	Public Function DeterminantOfComplexSubmatrix(ByRef mat As ComplexMatrix, n As Double) As cComplexNumber
		Dim f, signx As Double
		Dim D, t As cComplexNumber
		Dim temp As ComplexMatrix

		D = cCreateComplexNumber(0.0, 0.0)
		t = cCreateComplexNumber(0.0, 0.0)

		If n = 1.0
			D = mat.r(0).c(0)
		Else
			temp = CreateSquareComplexMatrix(n)

			signx = 1.0

			f = 0.0
			While f < n
				Call CofactorOfComplexMatrix(mat, temp, 0.0, f, n)
				Call cAssignComplexByValues(t, signx, 0.0)
				Call cMul(t, IndexComplex(mat, 0.0, f))
				Call cMul(t, DeterminantOfComplexSubmatrix(temp, n - 1.0))
				Call cAdd(D, t)
				signx = -signx
				f = f + 1.0
			End While

			Call DeleteComplexMatrix(temp)
		End If

		Return D
	End Function


	Public Sub DeleteComplexMatrix(ByRef X As ComplexMatrix)
		Dim m, n, rows, cols As Double

		rows = NumberOfRowsComplex(X)
		cols = NumberOfColumnsComplex(X)
		m = 0.0
		While m < rows
			n = 0.0
			While n < cols
				X.r(m).c(n) = Nothing
				n = n + 1.0
			End While
			Erase X.r(m).c 
			X.r(m) = Nothing
			m = m + 1.0
		End While

		Erase X.r 
		X = Nothing
	End Sub


	Public Function DeterminantComplex(ByRef m As ComplexMatrix) As cComplexNumber
		Dim n As Double
		Dim D As cComplexNumber

		n = NumberOfRowsComplex(m)
		D = DeterminantOfComplexSubmatrix(m, n)

		Return D
	End Function


	Public Sub AdjointComplex(ByRef A As ComplexMatrix, ByRef adj As ComplexMatrix)
		Dim n As Double
		Dim cofactors As ComplexMatrix
		Dim i, j As Double
		Dim t, signx As cComplexNumber

		n = A.r.Length
		t = cCreateComplexNumber(0.0, 0.0)
		signx = cCreateComplexNumber(0.0, 0.0)

		If n = 1.0
			Call cAssignComplexByValues(IndexComplex(adj, 0.0, 0.0), 1.0, 0.0)
		Else
			cofactors = CreateSquareComplexMatrix(n)

			i = 0.0
			While i < n
				j = 0.0
				While j < n
					Call CofactorOfComplexMatrix(A, cofactors, i, j, n)

					If (i + j) Mod 2.0 = 0.0
						Call cAssignComplexByValues(signx, 1.0, 0.0)
					Else
						Call cAssignComplexByValues(signx, -1.0, 0.0)
					End If

					Call cAssignComplex(t, signx)
					Call cMul(t, DeterminantOfComplexSubmatrix(cofactors, n - 1.0))
					Call cAssignComplex(IndexComplex(adj, j, i), t)
					j = j + 1.0
				End While
				i = i + 1.0
			End While

			Call DeleteComplexMatrix(cofactors)
		End If
	End Sub


	Public Function InverseComplex(ByRef A As ComplexMatrix, ByRef inverseResult As ComplexMatrix) As Boolean
		Dim success As Boolean
		Dim adj As ComplexMatrix
		Dim n, i, j As Double
		Dim det, t As cComplexNumber

		t = cCreateComplexNumber(0.0, 0.0)

		If NumberOfColumnsComplex(A) = NumberOfRowsComplex(A)
			n = NumberOfColumnsComplex(A)

			det = DeterminantComplex(A)
			If det.re <> 0.0 Or det.im <> 0.0
				adj = CreateSquareComplexMatrix(n)
				Call AdjointComplex(A, adj)

				i = 0.0
				While i < n
					j = 0.0
					While j < n
						Call cAssignComplex(t, IndexComplex(adj, i, j))
						Call cDiv(t, det)
						Call cAssignComplex(IndexComplex(inverseResult, i, j), t)
						j = j + 1.0
					End While
					i = i + 1.0
				End While

				success = true
				Call DeleteComplexMatrix(adj)
			Else
				success = false
			End If
		Else
			success = false
		End If

		Return success
	End Function


	Public Function ComplexMatrixEqualsEpsilon(ByRef b As ComplexMatrix, ByRef f As ComplexMatrix, epsilon As Double) As Boolean
		Dim x, y, columns, rows As Double
		Dim equals As Boolean

		equals = true

		If NumberOfRowsComplex(b) = NumberOfRowsComplex(f) And NumberOfColumnsComplex(b) = NumberOfColumnsComplex(f)
			columns = NumberOfColumnsComplex(b)
			rows = NumberOfRowsComplex(b)

			x = 0.0
			While x < rows
				y = 0.0
				While y < columns
					equals = equals And cEpsilonCompareComplex(IndexComplex(b, x, y), IndexComplex(f, x, y), epsilon)
					y = y + 1.0
				End While
				x = x + 1.0
			End While
		Else
			equals = false
		End If

		Return equals
	End Function


	Public Function MinorComplex(ByRef x As ComplexMatrix, row As Double, column As Double) As ComplexMatrix
		Dim minor As ComplexMatrix
		Dim cols, rows, i, j, m, n As Double

		rows = NumberOfRowsComplex(x) - 1.0
		cols = NumberOfColumnsComplex(x) - 1.0

		minor = CreateComplexMatrix(rows, cols)

		i = 0.0
		While i < rows
			If i < row
				m = i
			Else
				m = i + 1.0
			End If

			j = 0.0
			While i <> row And j < cols
				If j <> column

					If j < column
						n = j
					Else
						n = j + 1.0
					End If

					Call cAssignComplex(IndexComplex(minor, m, n), IndexComplex(x, i, j))
				End If
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return minor
	End Function


	Public Sub AssignComplex(ByRef A As ComplexMatrix, ByRef B As ComplexMatrix)
		Dim m, n As Double
		Dim r, c As Double

		r = NumberOfRowsComplex(A)
		c = NumberOfColumnsComplex(A)
		m = 0.0
		While m < r
			n = 0.0
			While n < c
				Call cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function CreateCopyOfComplexMatrix(ByRef A As ComplexMatrix) As ComplexMatrix
		Dim X As ComplexMatrix

		X = CreateComplexMatrix(NumberOfRowsComplex(A), NumberOfColumnsComplex(A))
		Call AssignComplex(X, A)

		Return X
	End Function


	Public Function TransposeComplex(ByRef a As ComplexMatrix) As Boolean
		Dim m, n As Double
		Dim rows As Double
		Dim square As Boolean
		Dim tmp As cComplexNumber

		tmp = cCreateComplexNumber(0.0, 0.0)

		square = IsSquareComplexMatrix(a)
		If square
			rows = NumberOfColumnsComplex(a)

			m = 0.0
			While m < rows
				n = 0.0
				While n < m
					Call cAssignComplex(tmp, IndexComplex(a, n, m))
					Call cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n))
					Call cAssignComplex(IndexComplex(a, m, n), tmp)
					n = n + 1.0
				End While
				m = m + 1.0
			End While
		End If

		Return square
	End Function


	Public Function ConjugateTransposeComplex(ByRef a As ComplexMatrix) As Boolean
		Dim m, n As Double
		Dim rows As Double
		Dim square As Boolean
		Dim tmp As cComplexNumber

		tmp = cCreateComplexNumber(0.0, 0.0)

		square = IsSquareComplexMatrix(a)
		If square
			rows = NumberOfColumnsComplex(a)

			m = 0.0
			While m < rows
				n = 0.0
				While n < m
					Call cAssignComplex(tmp, IndexComplex(a, n, m))
					Call cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n))
					Call cAssignComplex(IndexComplex(a, m, n), tmp)
					Call cConjugate(IndexComplex(a, m, n))
					n = n + 1.0
				End While
				m = m + 1.0
			End While
		End If

		Return square
	End Function


	Public Function IsSquareComplexMatrix(ByRef A As ComplexMatrix) As Boolean
		Dim isx As Boolean

		If NumberOfRowsComplex(A) = NumberOfColumnsComplex(A)
			isx = true
		Else
			isx = false
		End If

		Return isx
	End Function


	Public Sub TransposeComplexAssign(ByRef t As ComplexMatrix, ByRef a As ComplexMatrix)
		Dim m, n As Double
		Dim rows, cols As Double

		cols = NumberOfRowsComplex(a)
		rows = NumberOfColumnsComplex(a)

		m = 0.0
		While m < cols
			n = 0.0
			While n < rows
				Call cAssignComplex(IndexComplex(t, n, m), IndexComplex(a, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While
	End Sub


	Public Function TransposeComplexToNew(ByRef a As ComplexMatrix) As ComplexMatrix
		Dim m, n As Double
		Dim rows, cols As Double
		Dim c As ComplexMatrix

		cols = NumberOfRowsComplex(a)
		rows = NumberOfColumnsComplex(a)

		c = CreateComplexMatrix(rows, cols)

		m = 0.0
		While m < cols
			n = 0.0
			While n < rows
				Call cAssignComplex(IndexComplex(c, n, m), IndexComplex(a, m, n))
				n = n + 1.0
			End While
			m = m + 1.0
		End While

		Return c
	End Function


	Public Function ExtractComplexSubMatrix(ByRef M As ComplexMatrix, r1 As Double, r2 As Double, c1 As Double, c2 As Double) As ComplexMatrix
		Dim A As ComplexMatrix
		Dim i, j As Double

		A = CreateComplexMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0)

		i = r1
		While i <= r2
			j = c1
			While j <= c2
				Call cAssignComplex(IndexComplex(A, i - r1, j - c1), IndexComplex(M, i, j))
				j = j + 1.0
			End While
			i = i + 1.0
		End While

		Return A
	End Function


	Public Function NormComplex(ByRef a As ComplexMatrix) As Double
		Dim l, i, j, rows, cols As Double
		Dim cComplexNumber As cComplexNumber

		l = 0.0

		rows = NumberOfRowsComplex(a)
		cols = NumberOfColumnsComplex(a)

		i = 0.0
		While i < rows
			j = 0.0
			While j < cols
				cComplexNumber = IndexComplex(a, i, j)
				l = l + cComplexNumber.re ^ 2.0 + cComplexNumber.im ^ 2.0
				j = j + 1.0
			End While
			i = i + 1.0
		End While
		l = Sqrt(l)

		Return l
	End Function


	Public Sub ComplexCharacteristicPolynomial(ByRef A As ComplexMatrix, ByRef p As pComplexPolynomial)
		Dim cp As ComplexMatrix
		Dim determinant As cComplexNumber

		cp = CreateSquareComplexMatrix(NumberOfRowsComplex(A))
		determinant = New cComplexNumber()

		Call ComplexCharacteristicPolynomialWithInverse(A, cp, p, determinant)

		Call DeleteComplexMatrix(cp)
	End Sub


	Public Sub ComplexCharacteristicPolynomialWithInverse(ByRef A As ComplexMatrix, ByRef AInverse As ComplexMatrix, ByRef p As pComplexPolynomial, ByRef determinant As cComplexNumber)
		Call FaddeevLeVerrierAlgorithmComplex(A, AInverse, p, determinant)
	End Sub


	Public Sub FaddeevLeVerrierAlgorithmComplex(ByRef A As ComplexMatrix, ByRef AInverse As ComplexMatrix, ByRef p As pComplexPolynomial, ByRef determinant As cComplexNumber)
		Dim Mk, Mkm1, t1, Id As ComplexMatrix
		Dim t, t2, n1 As cComplexNumber
		Dim i, n, k As Double

		n1 = cCreateComplexNumber(-1.0, 0.0)
		n = NumberOfRowsComplex(A)
		p.cs = New cComplexNumber (n + 1.0 - 1){}
		i = 0.0
		While i < n + 1.0
			p.cs(i) = New cComplexNumber()
			i = i + 1.0
		End While
		Call cAssignComplexByValues(p.cs(n), 1.0, 0.0)
		Mkm1 = CreateSquareComplexMatrix(n)
		Call FillComplex(Mkm1, 0.0, 0.0)
		Id = CreateComplexIdentityMatrix(n)
		Mk = CreateSquareComplexMatrix(n)
		t1 = CreateSquareComplexMatrix(n)

		k = 1.0
		While k <= n
			Call MultiplyComplex(Mk, A, Mkm1)
			Call AssignComplex(t1, Id)
			Call ScalarMultiplyComplex(t1, p.cs(n - k + 1.0))
			Call AddComplex(Mk, t1)

			Call MultiplyComplex(t1, A, Mk)
			t = TraceComplex(t1)
			t2 = cCreateComplexNumber(-1.0/k, 0.0)
			Call cMul(t, t2)
			Call cAssignComplex(p.cs(n - k), t)

			' done
			Call AssignComplex(Mkm1, Mk)

			If k = n
				Call AssignComplex(AInverse, Mk)
				Call cAssignComplex(t, p.cs(0))
				Call cMul(t, n1)
				Call cAssignComplex(determinant, t)
				If t.re = 0.0 And t.im = 0.0
				Else
					Call ScalarDivideComplex(AInverse, t)
				End If
			End If
			k = k + 1.0
		End While

		Call DeleteComplexMatrix(Mkm1)
		Call DeleteComplexMatrix(Id)
		Call DeleteComplexMatrix(Mk)
		Call DeleteComplexMatrix(t1)
	End Sub


	Public Function EigenvaluesComplex(ByRef A As ComplexMatrix, ByRef eigenValuesReference As cComplexNumberArrayReference) As Boolean
		Dim eigenVectorsReference As ComplexMatrixArrayReference
		Dim success As Boolean
		Dim i As Double

		eigenVectorsReference = New ComplexMatrixArrayReference()
		success = EigenpairsComplex(A, eigenValuesReference, eigenVectorsReference)
		If success
			i = 0.0
			While i < eigenVectorsReference.matrices.Length
				Call DeleteComplexMatrix(eigenVectorsReference.matrices(i))
				i = i + 1.0
			End While
			Erase eigenVectorsReference.matrices 
			eigenVectorsReference = Nothing
		End If

		Return success
	End Function


	Public Function EigenvectorsComplex(ByRef A As ComplexMatrix, ByRef eigenVectorsReference As ComplexMatrixArrayReference) As Boolean
		Dim evsReference As cComplexNumberArrayReference
		Dim success As Boolean
		Dim i As Double

		evsReference = New cComplexNumberArrayReference()
		success = EigenpairsComplex(A, evsReference, eigenVectorsReference)
		If success
			i = 0.0
			While i < evsReference.complexNumbers.Length
				evsReference.complexNumbers(i) = Nothing
				i = i + 1.0
			End While
			Erase evsReference.complexNumbers 
			evsReference = Nothing
		End If

		Return success
	End Function


	Public Function InversePowerMethodComplex(ByRef A As ComplexMatrix, ByRef eigenvalue As cComplexNumber, maxIterations As Double, ByRef eigenvector As cComplexNumberArrayReference) As Boolean
		Dim t1, t2, t3, t4, b As ComplexMatrix
		Dim n, i, c As Double
		Dim isSingular As Boolean
		Dim c101, k, cc As cComplexNumber

		n = NumberOfRowsComplex(A)

		t2 = CreateComplexIdentityMatrix(n)
		Call ScalarMultiplyComplex(t2, eigenvalue)
		t3 = SubtractComplexToNew(A, t2)
		t4 = CreateSquareComplexMatrix(n)
		isSingular = Not InverseComplex(t3, t4)
		cc = cCreateComplexNumber(0.0, 0.0)
		t1 = CreateComplexMatrix(n, 1.0)

		If isSingular
			Call DeleteComplexMatrix(t2)
			Call DeleteComplexMatrix(t3)
			Call DeleteComplexMatrix(t4)

			c101 = cCreateComplexNumber(1.01, 0.0)
			' Try again with more erroneous eigenvalue estimate.
			t2 = CreateComplexIdentityMatrix(n)
			k = cMulToNew(eigenvalue, c101)
			Call ScalarMultiplyComplex(t2, k)
			t3 = SubtractComplexToNew(A, t2)
			t4 = CreateSquareComplexMatrix(n)
			isSingular = Not InverseComplex(t3, t4)
			c101 = Nothing
		End If

		If Not isSingular
			b = CreateComplexMatrix(n, 1.0)

			i = 0.0
			While i < n
				Call cAssignComplexByValues(b.r(i).c(0), 1.0, 1.0)
				i = i + 1.0
			End While

			i = 0.0
			While i < maxIterations
				Call MultiplyComplex(t1, t4, b)
				c = NormComplex(t1)
				Call cAssignComplexByValues(cc, c, 0.0)
				Call ScalarDivideComplex(t1, cc)
				Call AssignComplex(b, t1)
				i = i + 1.0
			End While

			eigenvector.complexNumbers = New cComplexNumber (n - 1){}
			i = 0.0
			While i < n
				eigenvector.complexNumbers(i) = b.r(i).c(0)
				i = i + 1.0
			End While
		End If

		Call DeleteComplexMatrix(t1)
		Call DeleteComplexMatrix(t2)
		Call DeleteComplexMatrix(t3)
		Call DeleteComplexMatrix(t4)
		cc = Nothing

		Return Not isSingular
	End Function


	Public Function EigenpairsComplex(ByRef M As ComplexMatrix, ByRef eigenValuesReference As cComplexNumberArrayReference, ByRef eigenVectorsReference As ComplexMatrixArrayReference) As Boolean
		Return ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(M, eigenValuesReference, eigenVectorsReference, 0.000001, 100.0)
	End Function


	Public Function ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(ByRef M As ComplexMatrix, ByRef eigenValuesReference As cComplexNumberArrayReference, ByRef eigenVectorsReference As ComplexMatrixArrayReference, precision As Double, maxIterations As Double) As Boolean
		Dim success, inverseSuccess As Boolean
		Dim n, i, j, k, withinPrecision As Double
		Dim t1, t2, t3, xn1, eigenValue As cComplexNumber
		Dim rs, rsPrev As cComplexNumber ()
		Dim p As pComplexPolynomial
		Dim evecReference As cComplexNumberArrayReference
		Dim eigenVector As ComplexMatrix

		evecReference = New cComplexNumberArrayReference()

		p = New pComplexPolynomial()
		Call ComplexCharacteristicPolynomial(M, p)

		n = p.cs.Length - 1.0
		rs = New cComplexNumber (n - 1){}
		i = 0.0
		While i < n
			rs(i) = cCreateComplexNumber(0.0, 0.0)
			i = i + 1.0
		End While
		rsPrev = New cComplexNumber (n - 1){}
		i = 0.0
		While i < n
			rsPrev(i) = cCreateComplexNumber(0.4, 0.9)
			Call cPower(rsPrev(i), i)
			i = i + 1.0
		End While
		t2 = cCreateComplexNumber(0.0, 0.0)
		t3 = cCreateComplexNumber(0.0, 0.0)

		success = false

		eigenVectorsReference.matrices = New ComplexMatrix (n - 1){}
		i = 0.0
		While i < n
			eigenVectorsReference.matrices(i) = CreateComplexMatrix(n, 1.0)
			i = i + 1.0
		End While

		i = 0.0
		While i < maxIterations And Not success
			j = 0.0
			While j < n
				xn1 = rsPrev(j)

				t1 = pEvaluateComplex(p, xn1)
				Call cAssignComplexByValues(t2, 1.0, 0.0)
				k = 0.0
				While k < n
					If k < j
						Call cAssignComplex(t3, xn1)
						Call cSub(t3, rs(k))
						Call cMul(t2, t3)
					End If
					If k > j
						Call cAssignComplex(t3, xn1)
						Call cSub(t3, rsPrev(k))
						Call cMul(t2, t3)
					End If
					k = k + 1.0
				End While
				Call cDiv(t1, t2)
				Call cAssignComplex(rs(j), xn1)
				Call cSub(rs(j), t1)

				t1 = Nothing
				j = j + 1.0
			End While
			withinPrecision = 0.0
			j = 0.0
			While j < n
				eigenValue = rs(j)

				' Calculate the eigenvector corresponding to the eigenvalue.
				inverseSuccess = InversePowerMethodComplex(M, eigenValue, i + 1.0, evecReference)
				If inverseSuccess
					k = 0.0
					While k < n
						eigenVectorsReference.matrices(j).r(k).c(0) = evecReference.complexNumbers(k)
						k = k + 1.0
					End While

					' Check eigenpair agains precision.
					eigenVector = eigenVectorsReference.matrices(j)

					If CheckComplexEigenpairPrecision(M, eigenValue, eigenVector, precision)
						withinPrecision = withinPrecision + 1.0
					End If
					Call cAssignComplex(rsPrev(j), rs(j))
				End If
				j = j + 1.0
			End While
			If withinPrecision = n
				success = true
			End If
			i = i + 1.0
		End While

		eigenValuesReference.complexNumbers = rs

		Return success
	End Function


	Public Function CheckComplexEigenpairPrecision(ByRef a As ComplexMatrix, ByRef lambda As cComplexNumber, ByRef e As ComplexMatrix, precision As Double) As Boolean
		Dim vec1, vec2 As ComplexMatrix
		Dim equal As Boolean

		vec1 = MultiplyComplexToNew(a, e)
		vec2 = ScalarMultiplyComplexToNew(e, lambda)

		equal = ComplexMatrixEqualsEpsilon(vec1, vec2, precision)

		Return equal
	End Function


	Public Function vectorCreate2DVector(a0 As Double, a1 As Double) As Double ()
		Dim vector As Double ()

		vector = New Double (2 - 1){}
		vector(0) = a0
		vector(1) = a1

		Return vector
	End Function


	Public Function vectorCreate3DVector(a0 As Double, a1 As Double, a2 As Double) As Double ()
		Dim vector As Double ()

		vector = New Double (3 - 1){}
		vector(0) = a0
		vector(1) = a1
		vector(2) = a2

		Return vector
	End Function


	Public Function vectorCreate4DVector(a0 As Double, a1 As Double, a2 As Double, a3 As Double) As Double ()
		Dim vector As Double ()

		vector = New Double (4 - 1){}
		vector(0) = a0
		vector(1) = a1
		vector(2) = a2
		vector(3) = a3

		Return vector
	End Function


	Public Function vectorDotProductWithCheck(ByRef a As Double (), ByRef b As Double (), ByRef answer As NumberReference, ByRef errorMessage As StringReference) As Boolean
		Dim sum As Double
		Dim success As Boolean

		sum = 0.0

		If a.Length = b.Length
			sum = vectorDotProduct(a, b)
			success = true
		Else
			errorMessage.stringx = "The dimensions have to be equal.".ToCharArray()
			success = false
		End If

		answer.numberValue = sum

		Return success
	End Function


	Public Function vectorDotProduct(ByRef a As Double (), ByRef b As Double ()) As Double
		Dim sum, i As Double

		sum = 0.0
		' Dot product is the sum of the products of the corresponding entries of two vectors.
		i = 0.0
		While i < a.Length
			sum = sum + a(i)*b(i)
			i = i + 1.0
		End While

		Return sum
	End Function


	Public Function vectorMagnitude(ByRef a As Double ()) As Double
		Dim sum, i As Double

		sum = 0.0

		i = 0.0
		While i < a.Length
			sum = sum + a(i) ^ 2.0
			i = i + 1.0
		End While
		sum = Sqrt(sum)

		Return sum
	End Function


	Public Function vectorCrossProduct3dWithCheck(ByRef a As Double (), ByRef b As Double (), ByRef answer As NumberArrayReference, ByRef errorMessage As StringReference) As Boolean
		Dim crossProduct As Double ()
		Dim success As Boolean

		crossProduct = New Double (3 - 1){}

		If a.Length = 3.0 And b.Length = 3.0
			crossProduct(0) = a(1)*b(2) - b(1)*a(2)
			crossProduct(1) = a(2)*b(0) - b(2)*a(0)
			crossProduct(2) = a(0)*b(1) - b(0)*a(1)

			success = true
		Else
			errorMessage.stringx = "The dimensions must be 3.".ToCharArray()
			success = false
		End If

		answer.numberArray = crossProduct

		Return success
	End Function


	Public Function vectorSum(ByRef a As Double ()) As Double
		Dim s, i As Double

		s = 0.0

		i = 0.0
		While i < a.Length
			s = s + a(i)
			i = i + 1.0
		End While

		Return s
	End Function


	Public Function vectorProduct(ByRef a As Double ()) As Double
		Dim p, i As Double

		p = 1.0

		i = 0.0
		While i < a.Length
			p = p*a(i)
			i = i + 1.0
		End While

		Return p
	End Function


	Public Sub vectorCumulativeSum(ByRef a As Double ())
		Dim s, i As Double

		s = 0.0

		i = 0.0
		While i < a.Length
			s = s + a(i)
			a(i) = s
			i = i + 1.0
		End While
	End Sub


	Public Sub vectorCumulativeProduct(ByRef a As Double ())
		Dim p, i As Double

		p = 1.0

		i = 0.0
		While i < a.Length
			p = p*a(i)
			a(i) = p
			i = i + 1.0
		End While
	End Sub


	Public Sub vectorAdd(ByRef a As Double (), ByRef b As Double ())
		Dim i As Double

		i = 0.0
		While i < a.Length And i < b.Length
			a(i) = a(i) + b(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub vectorSubtract(ByRef a As Double (), ByRef b As Double ())
		Dim i As Double

		i = 0.0
		While i < a.Length And i < b.Length
			a(i) = a(i) - b(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub vectorMultiply(ByRef a As Double (), ByRef b As Double ())
		Dim i As Double

		i = 0.0
		While i < a.Length And i < b.Length
			a(i) = a(i)*b(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub vectorDivide(ByRef a As Double (), ByRef b As Double ())
		Dim i As Double

		i = 0.0
		While i < a.Length And i < b.Length
			a(i) = a(i)/b(i)
			i = i + 1.0
		End While
	End Sub


	Public Function vectorAddToNew(ByRef a As Double (), ByRef b As Double ()) As Double ()
		Dim i As Double
		Dim c As Double ()

		c = New Double (Min(a.Length, b.Length) - 1){}

		i = 0.0
		While i < a.Length And i < b.Length
			c(i) = a(i) + b(i)
			i = i + 1.0
		End While

		Return c
	End Function


	Public Function vectorSubtractToNew(ByRef a As Double (), ByRef b As Double ()) As Double ()
		Dim i As Double
		Dim c As Double ()

		c = New Double (Min(a.Length, b.Length) - 1){}

		i = 0.0
		While i < a.Length And i < b.Length
			c(i) = a(i) - b(i)
			i = i + 1.0
		End While

		Return c
	End Function


	Public Function vectorMultiplyToNew(ByRef a As Double (), ByRef b As Double ()) As Double ()
		Dim i As Double
		Dim c As Double ()

		c = New Double (Min(a.Length, b.Length) - 1){}

		i = 0.0
		While i < a.Length And i < b.Length
			c(i) = a(i)*b(i)
			i = i + 1.0
		End While

		Return c
	End Function


	Public Function vectorDivideToNew(ByRef a As Double (), ByRef b As Double ()) As Double ()
		Dim i As Double
		Dim c As Double ()

		c = New Double (Min(a.Length, b.Length) - 1){}

		i = 0.0
		While i < a.Length And i < b.Length
			c(i) = a(i)/b(i)
			i = i + 1.0
		End While

		Return c
	End Function


	Public Sub vectorPower(ByRef a As Double (), p As Double)
		Dim i As Double

		i = 0.0
		While i < a.Length
			a(i) = a(i) ^ p
			i = i + 1.0
		End While
	End Sub


	Public Function CreateLinearCongruentialGeneratorNumericalRecipes(seed As Double) As LinearCongruentialGenerator
		Return CreateLinearCongruentialGeneratorCustom(2.0 ^ 29.0, 1664525.0, 1013904223.0, seed)
	End Function


	Public Function CreateLinearCongruentialGeneratorCustom(modulus As Double, multiplier As Double, increment As Double, seed As Double) As LinearCongruentialGenerator
		Dim lcg As LinearCongruentialGenerator

		lcg = New LinearCongruentialGenerator()
		lcg.m = modulus
		lcg.a = multiplier
		lcg.c = increment
		lcg.x = seed

		Return lcg
	End Function


	Public Function LinearCongruentialGeneratorNextNumber(ByRef lcg As LinearCongruentialGenerator) As Double
		lcg.x = Floor((lcg.a*lcg.x + lcg.c) Mod lcg.m)

		Return lcg.x/lcg.m
	End Function


	Public Function CreatePseudorandomNumberGenerator(seed As Double) As PseudorandomGenerator
		Dim prg As PseudorandomGenerator

		prg = New PseudorandomGenerator()
		prg.lcg = CreateLinearCongruentialGeneratorNumericalRecipes(seed)

		Return prg
	End Function


	Public Function PseudorandomNextNumber(ByRef prg As PseudorandomGenerator) As Double
		Return LinearCongruentialGeneratorNextNumber(prg.lcg)
	End Function


	Public Function PseudorandomNextInteger(ByRef prg As PseudorandomGenerator, n As Double) As Double
		Return Floor(PseudorandomNextNumber(prg)*n)
	End Function


	Public Function PseudorandomNextIntegerBetween(ByRef prg As PseudorandomGenerator, a As Double, b As Double) As Double
		Return Ceiling(a) + Floor(PseudorandomNextNumber(prg)*(b - a))
	End Function


	Public Function GaloisField2e8Add(a As Double, b As Double) As Double
		Return Xor2Byte(a, b)
	End Function


	Public Function GaloisField2e8Sub(a As Double, b As Double) As Double
		Return Xor2Byte(a, b)
	End Function


	Public Function GaloisField2e8Mul(a As Double, b As Double, modulusPolynomial As Double) As Double
		Dim r As Double

		r = 0.0

		
		While b <> 0.0
			If And2Byte(b, 1.0) = 1.0
				r = Xor2Byte(r, a)
			End If
			b = ShiftRight2Byte(b, 1.0)
			a = ShiftLeft2Byte(a, 1.0)
			If (And2Byte(a, 256.0) = 256.0)
				a = Xor2Byte(a, modulusPolynomial)
			End If
		End While

		Return r
	End Function


	Public Function GaloisField2e8Reciprocal(a As Double, modulusPolynomial As Double) As Double
		Dim ga, i, inv As Double
		Dim done As Boolean

		ga = a
		done = false
		inv = 0.0

		i = 0.0
		While i < ShiftLeft2Byte(1.0, 8.0) And Not done
			If GaloisField2e8Mul(ga, i, modulusPolynomial) = 1.0
				done = true
				inv = i
			End If
			i = i + 1.0
		End While

		Return inv
	End Function


	Public Function FindRoots(ByRef p As Double (), ByRef rootsReference As NumberArrayReference) As Boolean
		Return DurandKernerMethod(p, 0.000001, 100.0, rootsReference)
	End Function


	Public Function LaguerresMethodWithRepeatedDivision(ByRef p As Double (), maxIterations As Double, precision As Double, guess As Double, ByRef rootsReference As NumberArrayReference) As Boolean
		Dim n, nr, xk As Double
		Dim x As Double ()
		Dim q, r, d As Double ()
		Dim success As Boolean
		Dim xkReference As NumberReference

		n = pDegree(p)

		x = New Double (n - 1){}

		q = pCreatePolynomial(n)
		r = pCreatePolynomial(n)
		d = pCreatePolynomial(n)

		success = true
		xkReference = CreateNumberReference(0.0)

		nr = 0.0
		While nr < n And success
			success = LaguerresMethod(p, guess, maxIterations, precision, xkReference)

			If success
				xk = xkReference.numberValue
				x(nr) = xk

				Call pFill(d, 0.0)
				d(0) = -xk
				d(1) = 1.0
				Call pDivide(q, r, p, d)
				Call pAssign(p, q)
			End If
			nr = nr + 1.0
		End While

		Erase q 
		Erase r 
		Erase d 
        
		rootsReference.numberArray = x

		Return success
	End Function


	Public Function LaguerresMethod(ByRef p As Double (), guess As Double, maxIterations As Double, precision As Double, ByRef rootReference As NumberReference) As Boolean
		Dim k, a, G, H, xk, denom1, denom2, denom, t1, n As Double
		Dim success As Boolean

		n = pDegree(p)
		success = true

		xk = guess

		k = 0.0
		While (k < maxIterations) And (Abs(pEvaluate(p, xk)) >= precision) And success
			G = pEvaluateDerivative(p, xk, 1.0)/pEvaluate(p, xk)
			H = G ^ 2.0 - pEvaluateDerivative(p, xk, 2.0)/pEvaluate(p, xk)
			t1 = (n - 1.0)*(n*H - G ^ 2.0)
			If t1 >= 0.0
				denom = Sqrt(t1)
				denom1 = G + denom
				denom2 = G - denom
				If Abs(denom1) >= Abs(denom2)
					denom = denom1
				Else
					denom = denom2
				End If
				a = n/denom

				xk = xk - a
			Else
				success = false
			End If
			k = k + 1.0
		End While

		If k = maxIterations
			success = false
		End If

		If Abs(pEvaluate(p, xk)) >= precision
			success = false
		End If

		rootReference.numberValue = xk

		Return success
	End Function


	Public Function DurandKernerMethod(ByRef p As Double (), precision As Double, maxIterations As Double, ByRef rootsReference As NumberArrayReference) As Boolean
		Dim success As Boolean
		Dim n, i, j, k, t1, t2, xn1, withinPrecision As Double
		Dim rs, rsPrev As Double ()

		n = p.Length - 1.0
		rs = New Double (n - 1){}
		rsPrev = New Double (n - 1){}

		i = 0.0
		While i < n
			rsPrev(i) = i
			i = i + 1.0
		End While

		success = false

		i = 0.0
		While i < maxIterations And Not success
			j = 0.0
			While j < n
				xn1 = rsPrev(j)

				t1 = pEvaluate(p, xn1)
				t2 = 1.0
				k = 0.0
				While k < n
					If k < j
						t2 = t2*(xn1 - rs(k))
					End If
					If k > j
						t2 = t2*(xn1 - rsPrev(k))
					End If
					k = k + 1.0
				End While
				t1 = t1/t2
				rs(j) = xn1 - t1
				j = j + 1.0
			End While
			withinPrecision = 0.0
			j = 0.0
			While j < n
				If EpsilonCompare(rsPrev(j), rs(j), precision)
					withinPrecision = withinPrecision + 1.0
				End If
				rsPrev(j) = rs(j)
				j = j + 1.0
			End While
			If withinPrecision = n
				success = true
			End If
			i = i + 1.0
		End While

		rootsReference.numberArray = rs

		Return success
	End Function


	Public Function FindRootsComplex(ByRef p As pComplexPolynomial, ByRef rootsReference As cComplexNumberArrayReference) As Boolean
		Return DurandKernerMethodComplex(p, 0.000001, 100.0, rootsReference)
	End Function


	Public Function DurandKernerMethodComplex(ByRef p As pComplexPolynomial, precision As Double, maxIterations As Double, ByRef rootsReference As cComplexNumberArrayReference) As Boolean
		Dim success As Boolean
		Dim n, i, j, k, withinPrecision As Double
		Dim t1, t2, t3, xn1 As cComplexNumber
		Dim rs, rsPrev As cComplexNumber ()

		n = p.cs.Length - 1.0
		rs = New cComplexNumber (n - 1){}
		i = 0.0
		While i < n
			rs(i) = cCreateComplexNumber(0.0, 0.0)
			i = i + 1.0
		End While
		rsPrev = New cComplexNumber (n - 1){}
		i = 0.0
		While i < n
			rsPrev(i) = cCreateComplexNumber(0.4, 0.9)
			Call cPower(rsPrev(i), i)
			i = i + 1.0
		End While
		t2 = cCreateComplexNumber(0.0, 0.0)
		t3 = cCreateComplexNumber(0.0, 0.0)

		success = false

		i = 0.0
		While i < maxIterations And Not success
			j = 0.0
			While j < n
				xn1 = rsPrev(j)

				t1 = pEvaluateComplex(p, xn1)
				Call cAssignComplexByValues(t2, 1.0, 0.0)
				k = 0.0
				While k < n
					If k < j
						Call cAssignComplex(t3, xn1)
						Call cSub(t3, rs(k))
						Call cMul(t2, t3)
					End If
					If k > j
						Call cAssignComplex(t3, xn1)
						Call cSub(t3, rsPrev(k))
						Call cMul(t2, t3)
					End If
					k = k + 1.0
				End While
				Call cDiv(t1, t2)
				Call cAssignComplex(rs(j), xn1)
				Call cSub(rs(j), t1)
				j = j + 1.0
			End While
			withinPrecision = 0.0
			j = 0.0
			While j < n
				If cEpsilonCompareComplex(rsPrev(j), rs(j), precision)
					withinPrecision = withinPrecision + 1.0
				End If
				Call cAssignComplex(rsPrev(j), rs(j))
				j = j + 1.0
			End While
			If withinPrecision = n
				success = true
			End If
			i = i + 1.0
		End While

		rootsReference.complexNumbers = rs

		Return success
	End Function


	Public Function cCreateComplexNumber(re As Double, im As Double) As cComplexNumber
		Dim z As cComplexNumber

		z = New cComplexNumber()
		z.re = re
		z.im = im

		Return z
	End Function


	Public Function cCreatePolarComplexNumber(r As Double, phi As Double) As cPolarComplexNumber
		Dim p As cPolarComplexNumber

		p = New cPolarComplexNumber()
		p.r = r
		p.phi = phi

		Return p
	End Function


	Public Sub cAdd(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber)
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		z1.re = a + c
		z1.im = b + d
	End Sub


	Public Function cAddToNew(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber) As cComplexNumber
		Dim x As cComplexNumber
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		x = New cComplexNumber()

		x.re = a + c
		x.im = b + d

		Return x
	End Function


	Public Sub cSub(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber)
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		z1.re = a - c
		z1.im = b - d
	End Sub


	Public Function cSubToNew(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber) As cComplexNumber
		Dim x As cComplexNumber
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		x = New cComplexNumber()

		x.re = a - c
		x.im = b - d

		Return x
	End Function


	Public Sub cMul(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber)
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		z1.re = a*c - b*d
		z1.im = b*c + a*d
	End Sub


	Public Function cMulToNew(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber) As cComplexNumber
		Dim x As cComplexNumber
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		x = New cComplexNumber()

		x.re = a*c - b*d
		x.im = b*c + a*d

		Return x
	End Function


	Public Sub cDiv(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber)
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		z1.re = (a*c + b*d)/(c ^ 2.0 + d ^ 2.0)
		z1.im = (b*c - a*d)/(c ^ 2.0 + d ^ 2.0)
	End Sub


	Public Function cDivToNew(ByRef z1 As cComplexNumber, ByRef z2 As cComplexNumber) As cComplexNumber
		Dim x As cComplexNumber
		Dim a, b, c, d As Double

		a = z1.re
		b = z1.im
		c = z2.re
		d = z2.im

		x = New cComplexNumber()

		x.re = (a*c + b*d)/(c ^ 2.0 + d ^ 2.0)
		x.im = (b*c - a*d)/(c ^ 2.0 + d ^ 2.0)

		Return x
	End Function


	Public Sub cConjugate(ByRef z As cComplexNumber)
		z.im = -z.im
	End Sub


	Public Function cConjugateToNew(ByRef z As cComplexNumber) As cComplexNumber
		Dim x As cComplexNumber

		x = New cComplexNumber()

		x.re = z.re
		x.im = -z.im

		Return x
	End Function


	Public Function cAbs(ByRef z As cComplexNumber) As Double
		Dim x As Double

		x = Sqrt(z.re ^ 2.0 + z.im ^ 2.0)

		Return x
	End Function


	Public Function cArg(ByRef z As cComplexNumber) As Double
		Dim x As Double

		x = Atan2x(z.im, z.re)

		Return x
	End Function


	Public Function cCreatePolarFromComplexNumber(ByRef z As cComplexNumber) As cPolarComplexNumber
		Dim x As cPolarComplexNumber

		x = New cPolarComplexNumber()

		x.r = cAbs(z)
		x.phi = cArg(z)

		Return x
	End Function


	Public Function cCreateComplexFromPolar(ByRef p As cPolarComplexNumber) As cComplexNumber
		Dim z As cComplexNumber

		z = New cComplexNumber()

		z.re = p.r*Cos(p.phi)
		z.im = p.r*Sin(p.phi)

		Return z
	End Function


	Public Function cRe(ByRef z As cComplexNumber) As Double
		Return z.re
	End Function


	Public Function cIm(ByRef z As cComplexNumber) As Double
		Return z.im
	End Function


	Public Sub cAddPolar(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber)
		Dim x As cPolarComplexNumber
		Dim z1, z2 As cComplexNumber

		z1 = cCreateComplexFromPolar(p1)
		z2 = cCreateComplexFromPolar(p2)

		Call cAdd(z1, z2)

		x = cCreatePolarFromComplexNumber(z1)

		p1.r = x.r
		p1.phi = x.phi

		z1 = Nothing
		z2 = Nothing
		x = Nothing
	End Sub


	Public Function cAddPolarToNew(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber) As cPolarComplexNumber
		Dim x As cPolarComplexNumber
		Dim z1, z2 As cComplexNumber

		z1 = cCreateComplexFromPolar(p1)
		z2 = cCreateComplexFromPolar(p2)

		Call cAdd(z1, z2)

		x = cCreatePolarFromComplexNumber(z1)

		z1 = Nothing
		z2 = Nothing

		Return x
	End Function


	Public Sub cSubPolar(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber)
		Dim x As cPolarComplexNumber
		Dim z1, z2 As cComplexNumber

		z1 = cCreateComplexFromPolar(p1)
		z2 = cCreateComplexFromPolar(p2)

		Call cSub(z1, z2)

		x = cCreatePolarFromComplexNumber(z1)

		p1.r = x.r
		p1.phi = x.phi

		z1 = Nothing
		z2 = Nothing
		x = Nothing
	End Sub


	Public Function cSubPolarToNew(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber) As cPolarComplexNumber
		Dim x As cPolarComplexNumber
		Dim z1, z2 As cComplexNumber

		z1 = cCreateComplexFromPolar(p1)
		z2 = cCreateComplexFromPolar(p2)

		Call cSub(z1, z2)

		x = cCreatePolarFromComplexNumber(z1)

		z1 = Nothing
		z2 = Nothing

		Return x
	End Function


	Public Sub cMulPolar(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber)
		Dim r1, r2, phi1, phi2 As Double

		r1 = p1.r
		r2 = p2.r
		phi1 = p1.phi
		phi2 = p2.phi

		p1.r = r1*r2
		p1.phi = phi1 + phi2
	End Sub


	Public Function cMulPolarToNew(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber) As cPolarComplexNumber
		Dim x As cPolarComplexNumber
		Dim r1, r2, phi1, phi2 As Double

		r1 = p1.r
		r2 = p2.r
		phi1 = p1.phi
		phi2 = p2.phi

		x = New cPolarComplexNumber()

		x.r = r1*r2
		x.phi = phi1 + phi2

		Return x
	End Function


	Public Sub cDivPolar(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber)
		Dim r1, r2, phi1, phi2 As Double

		r1 = p1.r
		r2 = p2.r
		phi1 = p1.phi
		phi2 = p2.phi

		p1.r = r1/r2
		p1.phi = phi1 - phi2
	End Sub


	Public Function cDivPolarToNew(ByRef p1 As cPolarComplexNumber, ByRef p2 As cPolarComplexNumber) As cPolarComplexNumber
		Dim x As cPolarComplexNumber
		Dim r1, r2, phi1, phi2 As Double

		r1 = p1.r
		r2 = p2.r
		phi1 = p1.phi
		phi2 = p2.phi

		x = New cPolarComplexNumber()

		x.r = r1/r2
		x.phi = phi1 - phi2

		Return x
	End Function


	Public Sub cSquareRoot(ByRef z As cComplexNumber)
		Dim a, b, m As Double

		a = z.re
		b = z.im

		m = Sqrt(a ^ 2.0 + b ^ 2.0)

		z.re = Sqrt((m + a)/2.0)
		z.im = Signx(b)*Sqrt((m - a)/2.0)
	End Sub


	Public Sub cPowerPolar(ByRef p As cPolarComplexNumber, n As Double)
		p.r = p.r ^ n
		p.phi = p.phi*n
	End Sub


	Public Function cPowerToNew(ByRef z As cComplexNumber, n As Double) As cComplexNumber
		Dim p As cPolarComplexNumber
		Dim zp As cComplexNumber

		p = cCreatePolarFromComplexNumber(z)
		Call cPowerPolar(p, n)
		zp = cCreateComplexFromPolar(p)

		p = Nothing

		Return zp
	End Function


	Public Sub cPower(ByRef z As cComplexNumber, n As Double)
		Dim zp As cComplexNumber

		zp = cPowerToNew(z, n)
		z.re = zp.re
		z.im = zp.im

		zp = Nothing
	End Sub


	Public Sub cNegate(ByRef z As cComplexNumber)
		z.re = Negate(z.re)
		z.im = Negate(z.im)
	End Sub


	Public Sub cAssignComplexByValues(ByRef s As cComplexNumber, re As Double, im As Double)
		s.re = re
		s.im = im
	End Sub


	Public Sub cAssignComplex(ByRef a As cComplexNumber, ByRef b As cComplexNumber)
		a.re = b.re
		a.im = b.im
	End Sub


	Public Function cEpsilonCompareComplex(ByRef a As cComplexNumber, ByRef b As cComplexNumber, epsilon As Double) As Boolean
		Return EpsilonCompare(a.re, b.re, epsilon) And EpsilonCompare(a.im, b.im, epsilon)
	End Function


	Public Sub cExpComplex(ByRef x As cComplexNumber)
		Dim re, im As Double

		re = Exp(x.re)*Cos(x.im)
		im = Exp(x.re)*Sin(x.im)
		x.re = re
		x.im = im
	End Sub


	Public Sub cSineComplex(ByRef x As cComplexNumber)
		Dim re, im As Double

		re = Sin(x.re)*Coshx(x.im)
		im = Cos(x.re)*Sinhx(x.im)
		x.re = re
		x.im = im
	End Sub


	Public Sub cCosineComplex(ByRef x As cComplexNumber)
		Dim re, im As Double

		re = Cos(x.re)*Coshx(x.im)
		im = Sin(x.re)*Sinhx(x.im)
		x.re = re
		x.im = im
	End Sub


	Public Function cComplexToString(ByRef a As cComplexNumber) As Char ()
		Dim str, number As Char ()
		Dim ll As LinkedListCharacters
		Dim i As Double

		ll = CreateLinkedListCharacter()

		number = CreateStringDecimalFromNumber(a.re)

		i = 0.0
		While i < number.Length
			Call LinkedListAddCharacter(ll, number(i))
			i = i + 1.0
		End While

		Erase number 

		If a.im < 0.0
			Call LinkedListAddCharacter(ll, "-"C)
			number = CreateStringDecimalFromNumber(-a.im)
		Else
			Call LinkedListAddCharacter(ll, "+"C)
			number = CreateStringDecimalFromNumber(a.im)
		End If

		i = 0.0
		While i < number.Length
			Call LinkedListAddCharacter(ll, number(i))
			i = i + 1.0
		End While

		Erase number 

		Call LinkedListAddCharacter(ll, "i"C)

		str = LinkedListCharactersToArray(ll)
		Call FreeLinkedListCharacter(ll)

		Return str
	End Function


	Public Function pPolynomialToTextDirect(ByRef p As Double (), ByRef x As Char ()) As Char ()
		Dim ll As LinkedListCharacters
		Dim str As Char ()
		Dim i, c, j As Double
		Dim buffer As StringReference

		buffer = New StringReference()

		ll = CreateLinkedListCharacter()

		If p.Length = 0.0
			Call LinkedListAddCharacter(ll, "0"C)
		Else
			i = 0.0
			While i < p.Length
				c = p(i)
				If c < 0.0
					Call LinkedListAddCharacter(ll, "-"C)
				Else
					Call LinkedListAddCharacter(ll, "+"C)
				End If

				CreateStringFromNumberWithCheck(Abs(c), 10.0, buffer)
				Call LinkedListCharactersAddString(ll, buffer.stringx)
				Erase buffer.stringx 

				Call LinkedListCharactersAddString(ll, x)
				Call LinkedListAddCharacter(ll, "^"C)

				CreateStringFromNumberWithCheck(i, 10.0, buffer)
				Call LinkedListCharactersAddString(ll, buffer.stringx)
				Erase buffer.stringx 
				i = i + 1.0
			End While
		End If

		str = LinkedListCharactersToArray(ll)
		Call FreeLinkedListCharacter(ll)

		Return str
	End Function


	Public Sub pGenerateCommonRenderSpecification(ByRef p As Double (), ByRef showCoefficient As BooleanArrayReference, ByRef signx As StringReference, ByRef coefficient As NumberArrayReference, ByRef showPower As BooleanArrayReference, ByRef showX As BooleanArrayReference)
		Dim i, zeros, c As Double
		Dim setZero As Boolean

		setZero = false

		If p.Length = 0.0
			setZero = true
		Else
			zeros = 0.0
			i = 0.0
			While i < p.Length
				If p(i) = 0.0
					zeros = zeros + 1.0
				End If
				i = i + 1.0
			End While

			If zeros = p.Length
				setZero = true
			Else
				showCoefficient.booleanArray = New Boolean (p.Length - 1){}
				signx.stringx = New Char (p.Length - 1){}
				coefficient.numberArray = New Double (p.Length - 1){}
				showPower.booleanArray = New Boolean (p.Length - 1){}
				showX.booleanArray = New Boolean (p.Length - 1){}

				i = 0.0
				While i < p.Length
					c = p(i)

					If c < 0.0
						signx.stringx(i) = "-"C
					Else
						signx.stringx(i) = "+"C
					End If
					coefficient.numberArray(i) = Abs(p(i))
					If c = 0.0
						showCoefficient.booleanArray(i) = false
					Else
						If Abs(c) = 1.0 And i > 0.0
							showCoefficient.booleanArray(i) = false
						Else
							showCoefficient.booleanArray(i) = true
						End If

						If i = 0.0
							showX.booleanArray(i) = false
							showPower.booleanArray(i) = false
						Else
							showX.booleanArray(i) = true
							If i = 1.0
								showPower.booleanArray(i) = false
							Else
								showPower.booleanArray(i) = true
							End If
						End If
					End If
					i = i + 1.0
				End While
			End If
		End If

		If setZero
			showCoefficient.booleanArray = New Boolean (1 - 1){}
			signx.stringx = New Char (1 - 1){}
			coefficient.numberArray = New Double (1 - 1){}
			showPower.booleanArray = New Boolean (1 - 1){}
			showX.booleanArray = New Boolean (1 - 1){}

			showCoefficient.booleanArray(0) = true
			signx.stringx(0) = "+"C
			coefficient.numberArray(0) = 0.0
			showPower.booleanArray(0) = true
			showX.booleanArray(0) = false
		End If
	End Sub


	Public Function pPolynomialToText(ByRef p As Double (), ByRef x As Char ()) As Char ()
		Dim ll As LinkedListCharacters
		Dim str As Char ()
		Dim i, c As Double
		Dim buffer As StringReference
		Dim showCoefficient, showPower, showX As BooleanArrayReference
		Dim signx As StringReference
		Dim coefficient As NumberArrayReference
		Dim hasPrinted As Boolean

		showCoefficient = CreateBooleanArrayReferenceLengthValue(0.0, false)
		showPower = CreateBooleanArrayReferenceLengthValue(0.0, false)
		showX = CreateBooleanArrayReferenceLengthValue(0.0, false)
		signx = CreateStringReferenceLengthValue(0.0, " "C)
		coefficient = CreateNumberArrayReferenceLengthValue(0.0, 0.0)

		Call pGenerateCommonRenderSpecification(p, showCoefficient, signx, coefficient, showPower, showX)

		buffer = CreateStringReferenceLengthValue(0.0, " "C)

		ll = CreateLinkedListCharacter()

		hasPrinted = false
		i = 0.0
		While i < showCoefficient.booleanArray.Length
			c = p(i)

			If showCoefficient.booleanArray(i) Or showX.booleanArray(i)
				If Not hasPrinted And c >= 0.0
				Else
					Call LinkedListAddCharacter(ll, signx.stringx(i))
				End If

				If showCoefficient.booleanArray(i)
					CreateStringFromNumberWithCheck(coefficient.numberArray(i), 10.0, buffer)
					Call LinkedListCharactersAddString(ll, buffer.stringx)
					Erase buffer.stringx 
					hasPrinted = true
				End If

				If showX.booleanArray(i)
					Call LinkedListCharactersAddString(ll, x)
					hasPrinted = true
					If showPower.booleanArray(i)
						Call LinkedListAddCharacter(ll, "^"C)
						CreateStringFromNumberWithCheck(i, 10.0, buffer)
						Call LinkedListCharactersAddString(ll, buffer.stringx)
						Erase buffer.stringx 
					End If
				End If
			End If
			i = i + 1.0
		End While

		str = LinkedListCharactersToArray(ll)
		Call FreeLinkedListCharacter(ll)

		Return str
	End Function


	Public Function pComplexPolynomialToTextDirect(ByRef p As pComplexPolynomial, ByRef x As Char ()) As Char ()
		Dim ll As LinkedListCharacters
		Dim str, number As Char ()
		Dim i As Double
		Dim c As cComplexNumber
		Dim buffer As StringReference

		buffer = New StringReference()

		ll = CreateLinkedListCharacter()

		If p.cs.Length = 0.0
			Call LinkedListAddCharacter(ll, "0"C)
		Else
			i = 0.0
			While i < p.cs.Length
				c = p.cs(i)
				If i > 0.0
					Call LinkedListAddCharacter(ll, "+"C)
				End If

				number = cComplexToString(c)
				Call LinkedListAddCharacter(ll, "("C)
				Call LinkedListCharactersAddString(ll, number)
				Call LinkedListAddCharacter(ll, ")"C)
				Erase number 

				Call LinkedListCharactersAddString(ll, x)
				Call LinkedListAddCharacter(ll, "^"C)

				CreateStringFromNumberWithCheck(i, 10.0, buffer)
				Call LinkedListCharactersAddString(ll, buffer.stringx)
				Erase buffer.stringx 
				i = i + 1.0
			End While
		End If

		str = LinkedListCharactersToArray(ll)
		Call FreeLinkedListCharacter(ll)

		Return str
	End Function


	Public Sub pAdd(ByRef a As Double (), ByRef b As Double ())
		Dim i, nr As Double

		nr = b.Length

		i = 0.0
		While i < nr
			a(i) = a(i) + b(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub pSubtract(ByRef a As Double (), ByRef b As Double ())
		Dim i, nr As Double

		nr = b.Length

		i = 0.0
		While i < nr
			a(i) = a(i) - b(i)
			i = i + 1.0
		End While
	End Sub


	Public Sub pMultiply(ByRef c As Double (), ByRef a As Double (), ByRef b As Double ())
		Dim k, n, m, i As Double
		Dim av, bv As Double

		n = pDegree(a)
		m = pDegree(b)

		Call pFill(c, 0.0)

		i = 0.0
		While i <= n + m
			c(i) = 0.0
			k = 0.0
			While k <= i And k < a.Length And i - k < b.Length
				av = a(k)
				bv = b(i - k)
				c(i) = c(i) + av*bv
				k = k + 1.0
			End While
			i = i + 1.0
		End While
	End Sub


	Public Sub pDivide(ByRef q As Double (), ByRef r As Double (), ByRef n As Double (), ByRef d As Double ())
		Dim t, t1 As Double ()
		Dim tcoff, tdegree, i As Double
		Dim deg As Double
		Dim rd, dd As Double

		Call pFill(q, 0.0)
		Call pAssign(r, n)
		deg = pDegree(n)
		t = pCreatePolynomial(deg)
		t1 = pCreatePolynomial(deg)

		rd = pDegree(r)
		dd = pDegree(d)
		i = 0.0
		While i < deg + 1.0 And Not pIsZero(r) And rd - i >= dd
			Call pFill(t, 0.0)
			tdegree = rd - i - dd
			tcoff = r(rd - i)/d(dd)
			t(tdegree) = tcoff
			Call pAdd(q, t)
			Call pFill(t1, 0.0)
			Call pMultiply(t1, t, d)
			Call pSubtract(r, t1)
			i = i + 1.0
		End While

		Erase t 
		Erase t1 
	End Sub


	Public Function pIsZero(ByRef a As Double ()) As Boolean
		Dim i As Double
		Dim itIsZero As Boolean

		itIsZero = true

		i = 0.0
		While i < a.Length
			If a(i) <> 0.0
				itIsZero = false
			End If
			i = i + 1.0
		End While

		Return itIsZero
	End Function


	Public Sub pAssign(ByRef a As Double (), ByRef b As Double ())
		Dim i, nr As Double

		nr = b.Length

		i = 0.0
		While i < nr
			a(i) = b(i)
			i = i + 1.0
		End While
	End Sub


	Public Function pCreatePolynomial(deg As Double) As Double ()
		Dim p As Double ()

		p = New Double (deg + 1.0 - 1){}

		Call pFill(p, 0.0)

		Return p
	End Function


	Public Sub pFill(ByRef p As Double (), value As Double)
		Dim i As Double

		i = 0.0
		While i < p.Length
			p(i) = value
			i = i + 1.0
		End While
	End Sub


	Public Function pDegree(ByRef A As Double ()) As Double
		Dim i As Double
		Dim deg As Double
		Dim done As Boolean

		done = false
		deg = 0.0
		i = A.Length - 1.0
		While i >= 0.0 And Not done
			If A(i) <> 0.0
				deg = i
				done = true
			End If
			i = i - 1.0
		End While

		Return deg
	End Function


	Public Function pLead(ByRef A As Double ()) As Double
		Dim deg As Double

		deg = pDegree(A)

		Return A(deg)
	End Function


	Public Function pEvaluate(ByRef A As Double (), x As Double) As Double
		Return pEvaluateWithHornersMethod(A, x)
	End Function


	Public Function pEvaluateWithHornersMethod(ByRef A As Double (), x As Double) As Double
		Dim r, i As Double

		r = 0.0

		i = A.Length - 1.0
		While i >= 0.0
			r = r*x
			r = A(i) + r
			i = i - 1.0
		End While

		Return r
	End Function


	Public Function pEvaluateWithPowers(ByRef A As Double (), x As Double) As Double
		Dim r, i As Double

		r = 0.0

		i = 0.0
		While i < A.Length
			r = r + A(i)*x ^ i
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function pEvaluateDerivative(ByRef A As Double (), x As Double, n As Double) As Double
		Dim r, i, v As Double

		r = 0.0

		i = 0.0
		While i < A.Length
			If i - n >= 0.0
				v = A(i)*Permutations(i, n)*x ^ (i - n)
				r = r + v
			End If
			i = i + 1.0
		End While

		Return r
	End Function


	Public Sub pDerivative(ByRef A As Double ())
		Dim i, degree As Double

		degree = 0.0
		i = 1.0
		While i < A.Length
			degree = degree + 1.0
			A(i - 1.0) = degree*A(i)
			i = i + 1.0
		End While

		A(A.Length - 1.0) = 0.0
	End Sub


	Public Sub pAddComplex(ByRef a As pComplexPolynomial, ByRef b As pComplexPolynomial)
		Dim i, nr As Double

		nr = a.cs.Length

		i = 0.0
		While i < nr
			Call cAdd(a.cs(i), b.cs(i))
			i = i + 1.0
		End While
	End Sub


	Public Sub pSubtractComplex(ByRef a As pComplexPolynomial, ByRef b As pComplexPolynomial)
		Dim i, nr As Double

		nr = a.cs.Length

		i = 0.0
		While i < nr
			Call cSub(a.cs(i), b.cs(i))
			i = i + 1.0
		End While
	End Sub


	Public Function pIsZeroComplex(ByRef a As pComplexPolynomial) As Boolean
		Dim i As Double
		Dim itIsZero As Boolean

		itIsZero = true

		i = 0.0
		While i < a.cs.Length
			If a.cs(i).re <> 0.0 And a.cs(i).im <> 0.0
				itIsZero = false
			End If
			i = i + 1.0
		End While

		Return itIsZero
	End Function


	Public Sub pAssignComplex(ByRef a As pComplexPolynomial, ByRef b As pComplexPolynomial)
		Dim i, nr As Double

		nr = b.cs.Length

		i = 0.0
		While i < nr
			Call cAssignComplex(a.cs(i), b.cs(i))
			i = i + 1.0
		End While
	End Sub


	Public Function pCreateComplexPolynomial(deg As Double) As pComplexPolynomial
		Dim p As pComplexPolynomial
		Dim i As Double

		p = New pComplexPolynomial()
		p.cs = New cComplexNumber (deg + 1.0 - 1){}

		i = 0.0
		While i < deg + 1.0
			p.cs(i) = New cComplexNumber()
			i = i + 1.0
		End While

		Call pFillComplex(p, 0.0, 0.0)

		Return p
	End Function


	Public Sub pFillComplex(ByRef p As pComplexPolynomial, re As Double, im As Double)
		Dim i As Double
		Dim c As cComplexNumber

		c = cCreateComplexNumber(re, im)

		i = 0.0
		While i < p.cs.Length
			Call cAssignComplex(p.cs(i), c)
			i = i + 1.0
		End While

		c = Nothing
	End Sub


	Public Function pDegreeComplex(ByRef A As pComplexPolynomial) As Double
		Dim i As Double
		Dim deg As Double
		Dim done As Boolean

		done = false
		deg = 0.0
		i = A.cs.Length - 1.0
		While i >= 0.0 And Not done
			If A.cs(i).re <> 0.0 And A.cs(i).im <> 0.0
				deg = i
				done = true
			End If
			i = i - 1.0
		End While

		Return deg
	End Function


	Public Function pLeadComplex(ByRef A As pComplexPolynomial) As cComplexNumber
		Dim deg As Double

		deg = pDegreeComplex(A)

		Return A.cs(deg)
	End Function


	Public Function pEvaluateComplex(ByRef A As pComplexPolynomial, ByRef x As cComplexNumber) As cComplexNumber
		Dim i As Double
		Dim r, t As cComplexNumber

		r = cCreateComplexNumber(0.0, 0.0)
		t = cCreateComplexNumber(0.0, 0.0)

		i = 0.0
		While i < A.cs.Length
			Call cAssignComplex(t, x)
			Call cPower(t, i)
			Call cMul(t, A.cs(i))
			Call cAdd(r, t)
			i = i + 1.0
		End While

		Return r
	End Function


	Public Function pTotalNumberOfRoots(ByRef p As Double ()) As Double
		Return pDegree(p)
	End Function


End Module

