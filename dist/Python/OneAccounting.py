# Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

from math import *
class Account:
  name = None
  endingBalance = None
  startingBalance = None
  fromx = None
  to = None
  sumDebit = None
  sumCredit = None

class AccountDefinition:
  accountName = None
  number = None
  role = None
  debitBalance = None

class AccountPlan:
  accountDefinitions = None

class Ledger:
  decimals = None
  transactions = None
  accountPlan = None

class Line:
  account = None
  debit = None
  credit = None
  description = None
  date = None

class Transaction:
  lines = None

class Sections:
  codes = None
  counts = None

class RGBABitmapImageReference:
  image = None

class Success:
  feilmelding = None
  success = None

class RGBABitmapImageReference:
  image = None

class Rectangle:
  x1 = None
  x2 = None
  y1 = None
  y2 = None

class ScatterPlotSeries:
  linearInterpolation = None
  pointType = None
  lineType = None
  lineThickness = None
  xs = None
  ys = None
  color = None

class ScatterPlotSettings:
  scatterPlotSeries = None
  autoBoundaries = None
  xMax = None
  xMin = None
  yMax = None
  yMin = None
  autoPadding = None
  xPadding = None
  yPadding = None
  xLabel = None
  yLabel = None
  title = None
  showGrid = None
  gridColor = None
  xAxisAuto = None
  xAxisTop = None
  xAxisBottom = None
  yAxisAuto = None
  yAxisLeft = None
  yAxisRight = None
  width = None
  height = None

class BarPlotSeries:
  ys = None
  color = None

class BarPlotSettings:
  width = None
  height = None
  autoBoundaries = None
  yMax = None
  yMin = None
  autoPadding = None
  xPadding = None
  yPadding = None
  title = None
  showGrid = None
  gridColor = None
  barPlotSeries = None
  yLabel = None
  autoColor = None
  grayscaleAutoColor = None
  autoSpacing = None
  groupSeparation = None
  barSeparation = None
  autoLabels = None
  xLabels = None
  barBorder = None

class ArbitraryPrecisionInteger:
  sign = None
  number = None

class ArbitraryPrecisionFixedPointNumber:
  baseNumber = None
  pointPosition = None

class UnsignedInteger:
  digits = None

class BooleanArrayReference:
  booleanArray = None

class BooleanReference:
  booleanValue = None

class CharacterReference:
  characterValue = None

class NumberArrayReference:
  numberArray = None

class NumberReference:
  numberValue = None

class StringArrayReference:
  stringArray = None

class StringReference:
  string = None

class Date:
  year = None
  month = None
  day = None

class DateReference:
  date = None

class Interval:
  first = None
  last = None

class DateTimeTimezone:
  dateTime = None
  timezoneOffsetSeconds = None

class DateTimeTimezoneReference:
  dateTimeTimezone = None

class DateTime:
  date = None
  hours = None
  minutes = None
  seconds = None

class DateTimeReference:
  dateTime = None

class FixedPoint30d:
  part1 = None
  part2 = None
  digitsBeforeDecimalPoint = None
  digitsAfterDecimalPoint = None

class FixedPoint15d:
  number = None
  digitsBeforeDecimalPoint = None
  digitsAfterDecimalPoint = None

class DynamicArrayCharacters:
  array = None
  length = None

class LinkedListNodeStrings:
  end = None
  value = None
  next = None

class LinkedListStrings:
  first = None
  last = None

class LinkedListNodeNumbers:
  next = None
  end = None
  value = None

class LinkedListNumbers:
  first = None
  last = None

class LinkedListCharacters:
  first = None
  last = None

class LinkedListNodeCharacters:
  end = None
  value = None
  next = None

class DynamicArrayNumbers:
  array = None
  length = None

class Array:
  array = None
  length = None

class Data:
  isStruture = None
  isArray = None
  isNumber = None
  isString = None
  isBoolean = None
  structure = None
  array = None
  number = None
  booleanx = None
  string = None

class DataReference:
  data = None

class Structure:
  keys = None
  values = None

class RGBA:
  r = None
  g = None
  b = None
  a = None

class RGBABitmap:
  y = None

class RGBABitmapImage:
  x = None

class Matrix:
  r = None

class MatrixArrayReference:
  matrices = None

class MatrixReference:
  matrix = None

class MatrixRow:
  c = None

class ComplexMatrix:
  r = None

class ComplexMatrixArrayReference:
  matrices = None

class ComplexMatrixReference:
  matrix = None

class ComplexMatrixRow:
  c = None

class LinearCongruentialGenerator:
  x = None
  a = None
  c = None
  m = None

class PseudorandomGenerator:
  lcg = None

class cComplexNumber:
  re = None
  im = None

class cComplexNumberArrayReference:
  complexNumbers = None

class cComplexNumberReference:
  complexNumbers = None

class cPolarComplexNumber:
  r = None
  phi = None

class pComplexPolynomial:
  cs = None

def CreateLedger(decimals):

  ledger = CreateStructure()
  transactions = CreateArray()
  AddNumberToStruct(ledger, "decimals", decimals)
  AddArrayToStruct(ledger, "transactions", transactions)

  return ledger

def CreateFixedPointForDynamicLedger(ledger):

  d = GetNumberFromStruct(ledger, "decimals")
  n = CreateFixedPoint15d(15.0 - d, d)

  return n

def CreateFixedPointForStaticLedger(ledger):

  d = ledger.decimals
  n = CreateFixedPoint15d(15.0 - d, d)

  return n

def CreateLine(account, debit, credit, description, date):

  t = Line()

  t.account = arraysCopyString(account)
  t.debit = Copy15d(debit)
  t.credit = Copy15d(credit)
  t.description = arraysCopyString(description)
  t.date = CopyDate(date)

  return t

def AddTransactionToLedger(ledger, src):

  dst = LineToStructure(src)

  AddStructToArray(ledger, dst)

def AddTransactionsToLedger(ledger, ts):

  i = 0.0
  while i < len(ts):
    dst = LineToStructure(ts[int(i)])
    AddStructToArray(ledger, dst)
    i = i + 1.0
  

def ValidateAndAddTransactionToLedger(ledger, ls):

  transactions = GetArrayFromStruct(ledger, "transactions")

  valid = ValidateTransaction(ls, ledger)

  if valid:
    lines = CreateArray()

    i = 0.0
    while i < len(ls):
      dst = LineToStructure(ls[int(i)])
      AddStructToArray(lines, dst)
      i = i + 1.0
    

    AddArrayToArray(transactions, lines)

  return valid

def GetTransactionFromLedger(ledger, index):

  transactions = GetArrayFromStruct(ledger, "transactions")
  decimals = GetNumberFromStruct(ledger, "decimals")

  dst = ArrayIndexStruct(transactions, index)

  t = LineFromStructure(dst, ledger)

  return t

def LineToStructure(src):

  dst = CreateStructure()

  debitStr = ToString15d(src.debit)
  creditStr = ToString15d(src.credit)
  dateStr = DateToStringISO8601(src.date)

  AddStringToStruct(dst, "account", src.account)
  AddStringToStruct(dst, "debit", debitStr)
  AddStringToStruct(dst, "credit", creditStr)
  AddStringToStruct(dst, "date", dateStr)
  AddStringToStruct(dst, "description", src.description)

  return dst

def LineFromStructure(src, ledger):

  account = GetStringFromStruct(src, "account")
  debitStr = GetStringFromStruct(src, "debit")
  creditStr = GetStringFromStruct(src, "credit")
  dateStr = GetStringFromStruct(src, "date")
  description = GetStringFromStruct(src, "description")

  debitNumber = CreateNumberFromDecimalString(debitStr)
  creditNumber = CreateNumberFromDecimalString(creditStr)

  debit = CreateFixedPointForDynamicLedger(ledger)
  credit = CreateFixedPointForDynamicLedger(ledger)
  Assign15d(debit, debitNumber)
  Assign15d(credit, creditNumber)

  date = DateFromStringISO8601(dateStr)

  dst = CreateLine(account, debit, credit, description, date)

  return dst

def LedgerDynamicToStatic(src):

  dst = Ledger()

  transactions = GetArrayFromStruct(src, "transactions")
  decimals = GetNumberFromStruct(src, "decimals")
  ts = ArrayLength(transactions)

  dst.decimals = decimals
  dst.transactions =  [None]*int(ts)

  i = 0.0
  while i < ts:
    lines = ArrayIndexArray(transactions, i)
    ls = ArrayLength(lines)

    t = Transaction()
    t.lines =  [None]*int(ls)

    j = 0.0
    while j < ls:
      line = ArrayIndexStruct(lines, j)
      sline = LineFromStructure(line, src)
      t.lines[int(j)] = sline
      j = j + 1.0
    

    dst.transactions[int(i)] = t
    i = i + 1.0
  

  return dst

def ValidateTransaction(ts, ledger):

  valid = True

  if len(ts) > 0.0:
    date = ts[int(0.0)].date

    creditSum = CreateFixedPointForDynamicLedger(ledger)
    debitSum = CreateFixedPointForDynamicLedger(ledger)

    i = 0.0
    while i < len(ts) and valid:
      t = ts[int(i)]

      d = ToNumber15d(t.debit)
      c = ToNumber15d(t.credit)

      Add15d(creditSum, creditSum, t.credit)
      Add15d(debitSum, debitSum, t.debit)

      if DateEquals(date, t.date) and (d == 0.0 or c == 0.0):
        pass
      else:
        valid = False
      i = i + 1.0
    

    if valid:
      creditStr = ToString15d(creditSum)
      debitStr = ToString15d(creditSum)

      valid = arraysStringsEqual(creditStr, debitStr)

  return valid

def ValidateTransactions(ts, invalidIds):

  # TODO
  valid = True

  return valid

def ComputeAccountBalance(ledger, accountName, fromDate, toDate):

  ts = ledger.transactions

  a = Account()

  a.name = arraysCopyString(accountName)
  a.endingBalance = CreateFixedPointForStaticLedger(ledger)
  a.startingBalance = CreateFixedPointForStaticLedger(ledger)
  a.fromx = CopyDate(fromDate)
  a.to = CopyDate(toDate)
  a.sumDebit = CreateFixedPointForStaticLedger(ledger)
  a.sumCredit = CreateFixedPointForStaticLedger(ledger)

  i = 0.0
  while i < len(ts):
    t = ts[int(i)]

    j = 0.0
    while j < len(t.lines):
      l = t.lines[int(j)]

      if arraysStringsEqual(l.account, accountName):

        if DateLessThan(l.date, fromDate):
          Add15d(a.startingBalance, a.startingBalance, l.debit)
          Subtract15d(a.startingBalance, a.startingBalance, l.credit)
        elif DateLessThan(l.date, toDate):
          Add15d(a.endingBalance, a.endingBalance, l.debit)
          Subtract15d(a.endingBalance, a.endingBalance, l.credit)

          Add15d(a.sumDebit, a.sumDebit, l.debit)
          Add15d(a.sumCredit, a.sumCredit, l.credit)
      j = j + 1.0
    
    i = i + 1.0
  

  Add15d(a.endingBalance, a.endingBalance, a.startingBalance)

  return a

def AccountToString(account):

  ll = CreateLinkedListCharacter()

  diff = Copy15d(account.endingBalance)
  Subtract15d(diff, diff, account.startingBalance)

  LinkedListCharactersAddString(ll, account.name)
  LinkedListCharactersAddString(ll, ": ")
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.startingBalance, 2.0, "", "."))
  LinkedListCharactersAddString(ll, " -> ")
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.endingBalance, 2.0, "", "."))
  LinkedListCharactersAddString(ll, ": ")
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2.0, ",", "."))
  LinkedListCharactersAddString(ll, " (+")
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumDebit, 2.0, "", "."))
  LinkedListCharactersAddString(ll, ", -")
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account.sumCredit, 2.0, "", "."))
  LinkedListCharactersAddString(ll, ")")

  return LinkedListCharactersToArray(ll)

def AddMonthlyAccruals(ledger, fromx, to, amount, fromAccount, toAccount):

  message = StringReference()

  amounts = GetAccrualsWithDates(amount, fromx, to)

  date = CopyDate(fromx)
  date.day = 1.0

  c = CreateFixedPointForDynamicLedger(ledger)
  d = CreateFixedPointForDynamicLedger(ledger)

  i = 0.0
  while i < len(amounts):
    transaction =  [None]*int(2.0)

    accountName = fromAccount
    Assign15d(d, amounts[int(i)])
    Assign15d(c, 0.0)
    desc = "x"
    transaction[int(0.0)] = CreateLine(accountName, d, c, desc, date)

    accountName = toAccount
    Assign15d(d, 0.0)
    Assign15d(c, amounts[int(i)])
    desc = "x"
    transaction[int(1.0)] = CreateLine(accountName, d, c, desc, date)

    valid = ValidateAndAddTransactionToLedger(ledger, transaction)

    success = AddMonthsToDate(date, 1.0, message)
    i = i + 1.0
  

def ComputeAccountBalancePrefixAccount(ledger, accountNr, toDate, debitBalance):

  prefixL = CreateLinkedListCharacter()
  LinkedListCharactersAddString(prefixL, accountNr)
  LinkedListCharactersAddString(prefixL, ".")

  prefixed = LinkedListCharactersToArray(prefixL)

  ts = ledger.transactions

  balance = CreateFixedPointForStaticLedger(ledger)

  i = 0.0
  while i < len(ts):
    t = ts[int(i)]

    j = 0.0
    while j < len(t.lines):
      l = t.lines[int(j)]

      if strStartsWith(l.account, prefixed) or arraysStringsEqual(l.account, accountNr):
        if DateLessThan(l.date, toDate) or DateEquals(l.date, toDate):
          if debitBalance:
            Add15d(balance, balance, l.debit)
            Subtract15d(balance, balance, l.credit)
          else:
            Add15d(balance, balance, l.credit)
            Subtract15d(balance, balance, l.debit)
      j = j + 1.0
    
    i = i + 1.0
  

  return balance

def GetIFRSAccountPlan():

  ll = CreateLinkedListCharacter()

  # https://www.ifrs-gaap.com/ifrs-chart-accounts
  validRef = CreateBooleanReference(False)

  LinkedListCharactersAddString(ll, "1\tAssets\tDr\n")
  LinkedListCharactersAddString(ll, "1.1\tProperty, plant and equipment\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.1\tLand and land improvements\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.2\tBuildings, structures and improvements\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.3\tMachinery and equipment\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.4\tFixtures and fittings\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.5\tRight of use assets (classified as PP&E)\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.6\tAdditional property, plant and equipment\tDr\n")
  LinkedListCharactersAddString(ll, "1.1.7\tConstruction in progress\tDr\n")
  LinkedListCharactersAddString(ll, "1.2\tInvestment property\tDr\n")
  LinkedListCharactersAddString(ll, "1.2.1\tCompleted\tDr\n")
  LinkedListCharactersAddString(ll, "1.2.2\tUnder construction or development\tDr\n")
  LinkedListCharactersAddString(ll, "1.3\tGoodwill\tDr\n")
  LinkedListCharactersAddString(ll, "1.4\tIntangible assets excluding goodwill\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.1\tIntellectual property\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.2\tComputer software\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.3\tTrade and distribution assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.4\tContracts and rights\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.5\tRight of use assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.6\tCrypto assets (classified as intangible)\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.7\tAdditional intangible assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.4.8\tAcquisition in progress\tDr\n")
  LinkedListCharactersAddString(ll, "1.5\tFinancial assets and investments\tDr\n")
  LinkedListCharactersAddString(ll, "1.5.1\tNon-derivative financial assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.5.2\tDerivative financial assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.5.3\tAdditional financial assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.5.4\tCrypto assets (classified as financial assets)\tDr\n")
  LinkedListCharactersAddString(ll, "1.6\tInventories\tDr\n")
  LinkedListCharactersAddString(ll, "1.6.1\tMerchandise\tDr\n")
  LinkedListCharactersAddString(ll, "1.6.2\tRaw materials and production supplies\tDr\n")
  LinkedListCharactersAddString(ll, "1.6.3\tWork in progress\tDr\n")
  LinkedListCharactersAddString(ll, "1.6.4\tFinished goods\tDr\n")
  LinkedListCharactersAddString(ll, "1.6.5\tOther inventories\tDr\n")
  LinkedListCharactersAddString(ll, "1.7\tPrepayments and accrued income\tDr\n")
  LinkedListCharactersAddString(ll, "1.7.1\tPrepayments\tDr\n")
  LinkedListCharactersAddString(ll, "1.7.2\tAccrued income\tDr\n")
  LinkedListCharactersAddString(ll, "1.7.3\tService provider work in process (not classified as inventory)\tDr\n")
  LinkedListCharactersAddString(ll, "1.7.4\tAdditional assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.8\tReceivables and contracts\tDr\n")
  LinkedListCharactersAddString(ll, "1.8.1\tLoans and receivables\tDr\n")
  LinkedListCharactersAddString(ll, "1.8.2\tContracts with customers\tDr\n")
  LinkedListCharactersAddString(ll, "1.8.3\tNontrade and other receivables\tDr\n")
  LinkedListCharactersAddString(ll, "1.9\tTax assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.9.1\tTax assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.9.2\tDeferred tax assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.9.3\tOther tax assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.1\tAgricultural biological assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.10.1\tBearer plants\tDr\n")
  LinkedListCharactersAddString(ll, "1.10.2\tAnimals\tDr\n")
  LinkedListCharactersAddString(ll, "1.10.3\tOther agricultural assets\tDr\n")
  LinkedListCharactersAddString(ll, "1.11\tCash and cash equivalents\tDr\n")
  LinkedListCharactersAddString(ll, "1.11.1\tCash\tDr\n")
  LinkedListCharactersAddString(ll, "1.11.2\tCash equivalents\tDr\n")
  LinkedListCharactersAddString(ll, "1.11.3\tRestricted cash and financial assets\tDr\n")
  LinkedListCharactersAddString(ll, "2\tEquity\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.1\tTotal equity attributable to owners of parent\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.1.1\tIssued capital\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.1.2\tAdditional item paid-in capital\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.1.3\tPartner\'s capital\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.1.4\tMember\'s equity\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.1.5\tOther equity interest\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.2\tRetained earnings\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "2.2.3\tIn suspense\tZero\n")
  LinkedListCharactersAddString(ll, "2.3\tAccumulated other comprehensive income\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "2.3.2\tMiscellaneous equity\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "2.4\tOwners equity (non-shareholder)\t(Cr)\n")
  LinkedListCharactersAddString(ll, "2.5\tNon-controlling interests\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3\tLiabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.1\tTrade and other payables\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.1.1\tTrade payables\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.1.2\tDividend payables\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.1.3\tInterest payable\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.1.4\tOther payables\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.2\tProvisions\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.2.1\tCustomer related provisions\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.2.2\tLitigation and regulatory\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.2.3\tAdditional provisions\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3\tOther financial liabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3.1\tNotes payable\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3.2\tLoans received\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3.3\tBonds (debentures)\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3.4\tOther debts and borrowings\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3.5\tLease obligations\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.3.6\tDerivative financial liabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.4.1\tAccruals\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.4.2\tDeferred income and refund liabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.4.3\tAccrued taxes other than payroll\t(Cr)\n")
  LinkedListCharactersAddString(ll, "3.4.4\tAdditional liabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4\tRevenue\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.1\tRecognized point of time\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.1.1\tGoods\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.1.2\tServices\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.2\tRecognized over time\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.2.1\tProducts and projects\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.2.2\tServices\t(Cr)\n")
  LinkedListCharactersAddString(ll, "4.3\tAdjustments\tDr\n")
  LinkedListCharactersAddString(ll, "4.3.1\tVariable consideration\tDr\n")
  LinkedListCharactersAddString(ll, "4.3.2\tConsideration paid payable to customers\tDr\n")
  LinkedListCharactersAddString(ll, "4.3.3\tOther adjustments\tDr\n")
  LinkedListCharactersAddString(ll, "5\tExpenses\tDr\n")
  LinkedListCharactersAddString(ll, "5.1\tExpenses (classified by nature)\tDr\n")
  LinkedListCharactersAddString(ll, "5.1.1\tMaterial and merchandise\tDr\n")
  LinkedListCharactersAddString(ll, "5.1.2\tEmployee benefits expense\tDr\n")
  LinkedListCharactersAddString(ll, "5.1.3\tServices expense\tDr\n")
  LinkedListCharactersAddString(ll, "5.1.4\tRent, depreciation, amortization and depletion\tDr\n")
  LinkedListCharactersAddString(ll, "5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "5.1.6\tOther work performed by entity and capitalized\tDr\n")
  LinkedListCharactersAddString(ll, "5.2\tExpenses (classified by function)\tDr\n")
  LinkedListCharactersAddString(ll, "5.2.1\tCost of sales\tDr\n")
  LinkedListCharactersAddString(ll, "5.2.2\tSelling, general and administrative expense\tDr\n")
  LinkedListCharactersAddString(ll, "6\tOther non-operating income and expenses\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "6.1\tOther revenue and expenses\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "6.1.1\tOther revenue\t(Cr)\n")
  LinkedListCharactersAddString(ll, "6.1.2\tOther expenses\tDr\n")
  LinkedListCharactersAddString(ll, "6.2\tGains and losses\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "6.3\tTaxes other than income and payroll and fees\tDr\n")
  LinkedListCharactersAddString(ll, "6.4\tTax income (expense)\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "7\tIntercompany and related party accounts\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "7.1\tIntercompany and related party assets\tDr\n")
  LinkedListCharactersAddString(ll, "7.1.1\tIntercompany balances eliminated in consolidation\tDr\n")
  LinkedListCharactersAddString(ll, "7.1.2\tRelated party balances reported or disclosed\tDr\n")
  LinkedListCharactersAddString(ll, "7.1.3\tIntercompany investments\tDr\n")
  LinkedListCharactersAddString(ll, "7.2\tIntercompany and related party liabilities\t(Cr)\n")
  LinkedListCharactersAddString(ll, "7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n")
  LinkedListCharactersAddString(ll, "7.2.2\tRelated party balances reported or disclosed\t(Cr)\n")
  LinkedListCharactersAddString(ll, "7.3\tIntercompany and related party income and expense\tDr or (Cr)\n")
  LinkedListCharactersAddString(ll, "7.3.1\tIntercompany and related party income\t(Cr)\n")
  LinkedListCharactersAddString(ll, "7.3.2\tIntercompany and related party expenses\tDr\n")
  LinkedListCharactersAddString(ll, "7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n")

  accountPlanString = LinkedListCharactersToArray(ll)

  FreeLinkedListCharacter(ll)

  return ParseAccountPlanString(accountPlanString, validRef)

def ParseAccountPlanString(accountPlanString, valid):

  ap = AccountPlan()

  accountPlanString = strTrim(accountPlanString)
  lines = strSplitByCharacter(accountPlanString, '\n')

  ap.accountDefinitions =  [None]*int(len(lines))

  i = 0.0
  while i < len(lines):
    line = lines[int(i)].string
    #System.out.println(line);
    parts = strSplitByCharacter(line, '\t')

    ad = AccountDefinition()

    ad.accountName = parts[int(1.0)].string
    ad.number = parts[int(0.0)].string
    if arraysStringsEqual(parts[int(2.0)].string, "(Cr)"):
      ad.debitBalance = False
    else:
      ad.debitBalance = True
    ad.role = ""
    if arraysStringsEqual(ad.number, "1"):
      ad.role = "Assets"
    elif arraysStringsEqual(ad.number, "2"):
      ad.role = "Equities"
    elif arraysStringsEqual(ad.number, "3"):
      ad.role = "Liabilities"
    elif arraysStringsEqual(ad.number, "4"):
      ad.role = "Revenue"
    elif arraysStringsEqual(ad.number, "5"):
      ad.role = "Expenses"

    ap.accountDefinitions[int(i)] = ad
    i = i + 1.0
  

  return ap

def ComputeAccountBalances(sledger, depth, date, balanceSheet):

  balanceSheet.data = CreateNewStructData()
  success = True

  foundRef = CreateBooleanReference(False)

  accountPlan = sledger.accountPlan

  assetsDef = FindAccountWithRole(accountPlan, "Assets", foundRef)
  success = success and foundRef.booleanValue
  liabilitiesDef = FindAccountWithRole(accountPlan, "Liabilities", foundRef)
  success = success and foundRef.booleanValue
  equitiesDef = FindAccountWithRole(accountPlan, "Equities", foundRef)
  success = success and foundRef.booleanValue
  revenueDef = FindAccountWithRole(accountPlan, "Revenue", foundRef)
  success = success and foundRef.booleanValue
  expensesDef = FindAccountWithRole(accountPlan, "Expenses", foundRef)
  success = success and foundRef.booleanValue

  if success:
    assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.number, date, assetsDef.debitBalance)
    liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.number, date, liabilitiesDef.debitBalance)

    # TODO: This must be for a period
    revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.number, date, revenueDef.debitBalance)
    expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.number, date, expensesDef.debitBalance)
    resultBalance = CreateFixedPointForStaticLedger(sledger)
    Subtract15d(resultBalance, revenueBalanace, expensesBalance)
    balanceStr = FormatToStringWithSymbols15d(resultBalance, 2.0, "", ".")
    AddStringToStruct(balanceSheet.data.structure, "result", balanceStr)

    equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.number, date, equitiesDef.debitBalance)
    Add15d(equitiesBalance, equitiesBalance, resultBalance)

    # Compute accounts
    accounts = CreateArray()

    i = 0.0
    while i < len(accountPlan.accountDefinitions):
      accountDef = accountPlan.accountDefinitions[int(i)]

      parts = strSplitByCharacter(accountDef.number, '.')

      if len(parts) <= depth + 1.0:
        account = CreateStructure()

        balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.number, date, accountDef.debitBalance)

        balanceStr = FormatToStringWithSymbols15d(balance, 2.0, "", ".")

        AddStringToStruct(account, "number", accountDef.number)
        AddStringToStruct(account, "name", accountDef.accountName)
        AddStringToStruct(account, "balance", balanceStr)
        AddNumberToStruct(account, "depth", len(parts) - 1.0)

        AddStructToArray(accounts, account)
      i = i + 1.0
    

    AddArrayToStruct(balanceSheet.data.structure, "accounts", accounts)

    # End conclusion
    balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2.0, "", ".")
    AddStringToStruct(balanceSheet.data.structure, "assets", balanceStr)

    sum = CreateFixedPointForStaticLedger(sledger)
    Add15d(sum, liabilitiesBalance, equitiesBalance)
    balanceStr = FormatToStringWithSymbols15d(sum, 2.0, "", ".")
    AddStringToStruct(balanceSheet.data.structure, "liabilitiesAndEquity", balanceStr)

    isBalanced = Equals15d(sum, assetsBalance)
    AddBooleanToStruct(balanceSheet.data.structure, "balanced", isBalanced)

    dateStr = DateToStringISO8601(date)
    AddStringToStruct(balanceSheet.data.structure, "date", dateStr)

  return success

def AccountBalancesToString(balanceSheet):

  ll = CreateLinkedListCharacter()

  # Print accounts
  accounts = GetArrayFromStruct(balanceSheet, "accounts")

  i = 0.0
  while i < ArrayLength(accounts):
    account = ArrayIndexStruct(accounts, i)

    accountNumber = GetStringFromStruct(account, "number")
    accountName = GetStringFromStruct(account, "name")
    balanceStr = GetStringFromStruct(account, "balance")
    depth = GetNumberFromStruct(account, "depth")

    j = 0.0
    while j < depth:
      LinkedListCharactersAddString(ll, "  ")
      j = j + 1.0
    

    LinkedListCharactersAddString(ll, accountNumber)
    LinkedListCharactersAddString(ll, ". ")
    LinkedListCharactersAddString(ll, accountName)
    LinkedListCharactersAddString(ll, ": ")
    LinkedListCharactersAddString(ll, balanceStr)
    LinkedListCharactersAddString(ll, "\n")
    i = i + 1.0
  

  # End conclusion
  LinkedListCharactersAddString(ll, "\n")

  LinkedListCharactersAddString(ll, "Result: ")
  balanceStr = GetStringFromStruct(balanceSheet, "result")
  LinkedListCharactersAddString(ll, balanceStr)
  LinkedListCharactersAddString(ll, "\n")

  LinkedListCharactersAddString(ll, "Assets: ")
  balanceStr = GetStringFromStruct(balanceSheet, "assets")
  LinkedListCharactersAddString(ll, balanceStr)
  LinkedListCharactersAddString(ll, "\n")

  LinkedListCharactersAddString(ll, "Liabilities + Equities: ")
  balanceStr = GetStringFromStruct(balanceSheet, "liabilitiesAndEquity")
  LinkedListCharactersAddString(ll, balanceStr)
  LinkedListCharactersAddString(ll, "\n")

  isBalanced = GetBooleanFromStruct(balanceSheet, "balanced")
  LinkedListCharactersAddString(ll, "Balance: ")
  if isBalanced:
    LinkedListCharactersAddString(ll, "true")
  else:
    LinkedListCharactersAddString(ll, "false")
  LinkedListCharactersAddString(ll, "\n")

  return LinkedListCharactersToArray(ll)

def FindAccountWithRole(accountPlan, role, foundRef):

  ad = AccountDefinition()

  done = False
  i = 0.0
  while i < len(accountPlan.accountDefinitions) and  not done :
    ad = accountPlan.accountDefinitions[int(i)]
    if arraysStringsEqual(ad.role, role):
      done = True
    i = i + 1.0
  

  foundRef.booleanValue = done

  return ad

def CreateAccountDefinition(name, number, role, debitBalance):

  defx = AccountDefinition()
  defx.accountName = name
  defx.number = number
  defx.role = role
  defx.debitBalance = debitBalance

  return defx

def ComputeBalanceDiffs(sledger, balances):

  first = ArrayIndexStruct(balances, 0.0)
  accountsO = GetArrayFromStruct(first, "accounts")

  j = 0.0
  while j < ArrayLength(accountsO):
    i = 1.0
    while i < ArrayLength(balances):
      balance1 = ArrayIndexStruct(balances, i - 1.0)
      balance2 = ArrayIndexStruct(balances, i)
      accounts1 = GetArrayFromStruct(balance1, "accounts")
      accounts2 = GetArrayFromStruct(balance2, "accounts")

      account1 = ArrayIndexStruct(accounts1, j)
      account2 = ArrayIndexStruct(accounts2, j)

      b1 = GetStringFromStruct(account1, "balance")
      b2 = GetStringFromStruct(account2, "balance")

      f1 = CreateFixedPointForStaticLedger(sledger)
      f2 = CreateFixedPointForStaticLedger(sledger)
      diff = CreateFixedPointForStaticLedger(sledger)

      Assign15d(f1, CreateNumberFromDecimalString(b1))
      Assign15d(f2, CreateNumberFromDecimalString(b2))

      Subtract15d(diff, f2, f1)

      diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "", ".")

      #System.out.println(diffStr);
      if i == 1.0:
        AddStringToStruct(account1, "change", "0.00")
      AddStringToStruct(account2, "change", diffStr)
      i = i + 1.0
    
    j = j + 1.0
  

  i = 1.0
  while i < ArrayLength(balances):
    balance1 = ArrayIndexStruct(balances, i - 1.0)
    balance2 = ArrayIndexStruct(balances, i)
    b1 = GetStringFromStruct(balance1, "result")
    b2 = GetStringFromStruct(balance2, "result")

    f1 = CreateFixedPointForStaticLedger(sledger)
    f2 = CreateFixedPointForStaticLedger(sledger)
    diff = CreateFixedPointForStaticLedger(sledger)

    Assign15d(f1, CreateNumberFromDecimalString(b1))
    Assign15d(f2, CreateNumberFromDecimalString(b2))

    Subtract15d(diff, f2, f1)

    diffStr = FormatToStringWithSymbols15d(diff, sledger.decimals, "", ".")

    #System.out.println(diffStr);
    if i == 1.0:
      AddStringToStruct(balance1, "rchange", "0.00")
    AddStringToStruct(balance2, "rchange", diffStr)
    i = i + 1.0
  

def BalancesArrayToHTML(balances, includeBalance, includeDiff):

  ll = CreateLinkedListCharacter()

  LinkedListCharactersAddString(ll, "<html>")
  LinkedListCharactersAddString(ll, "<body>")
  LinkedListCharactersAddString(ll, "<table>")

  # Headers
  LinkedListCharactersAddString(ll, "<tr>")

  LinkedListCharactersAddString(ll, "<td>")
  LinkedListCharactersAddString(ll, "</td>")
  LinkedListCharactersAddString(ll, "<td>")
  LinkedListCharactersAddString(ll, "</td>")

  i = 0.0
  while i < ArrayLength(balances):
    balance = ArrayIndexStruct(balances, i)
    dateStr = GetStringFromStruct(balance, "date")
    dateStr = strSubstring(dateStr, 0.0, 7.0)

    LinkedListCharactersAddString(ll, "<td>")
    LinkedListCharactersAddString(ll, dateStr)
    LinkedListCharactersAddString(ll, "</td>")
    i = i + 1.0
  

  LinkedListCharactersAddString(ll, "</tr>")

  # Each account
  first = ArrayIndexStruct(balances, 0.0)
  accounts = GetArrayFromStruct(first, "accounts")
  j = 0.0
  while j < ArrayLength(accounts):
    LinkedListCharactersAddString(ll, "<tr>")

    account = ArrayIndexStruct(accounts, j)
    name = GetStringFromStruct(account, "name")
    number = GetStringFromStruct(account, "number")

    LinkedListCharactersAddString(ll, "<td>")
    LinkedListCharactersAddString(ll, number)
    LinkedListCharactersAddString(ll, "</td>")

    LinkedListCharactersAddString(ll, "<td>")
    LinkedListCharactersAddString(ll, name)
    LinkedListCharactersAddString(ll, "</td>")

    i = 0.0
    while i < ArrayLength(balances):
      balance = ArrayIndexStruct(balances, i)
      accounts = GetArrayFromStruct(balance, "accounts")
      account = ArrayIndexStruct(accounts, j)
      balanceStr = GetStringFromStruct(account, "balance")
      changeStr = GetStringFromStruct(account, "change")

      LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">")

      if includeBalance and includeDiff:
        LinkedListCharactersAddString(ll, balanceStr)
        LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">")
        LinkedListCharactersAddString(ll, changeStr)
        LinkedListCharactersAddString(ll, "</small>")
      elif includeBalance:
        LinkedListCharactersAddString(ll, balanceStr)
      elif includeDiff:
        LinkedListCharactersAddString(ll, changeStr)

      LinkedListCharactersAddString(ll, "</td>")
      i = i + 1.0
    

    LinkedListCharactersAddString(ll, "</tr>")
    j = j + 1.0
  

  # Result
  LinkedListCharactersAddString(ll, "<tr>")

  LinkedListCharactersAddString(ll, "<td>")
  LinkedListCharactersAddString(ll, "")
  LinkedListCharactersAddString(ll, "</td>")

  LinkedListCharactersAddString(ll, "<td>")
  LinkedListCharactersAddString(ll, "Result")
  LinkedListCharactersAddString(ll, "</td>")

  i = 0.0
  while i < ArrayLength(balances):
    balance = ArrayIndexStruct(balances, i)
    balanceStr = GetStringFromStruct(balance, "result")
    changeStr = GetStringFromStruct(balance, "rchange")

    LinkedListCharactersAddString(ll, "<td style=\"text-align: right;\">")

    if includeBalance and includeDiff:
      LinkedListCharactersAddString(ll, balanceStr)
      LinkedListCharactersAddString(ll, "<br><small style=\"color: grey\">")
      LinkedListCharactersAddString(ll, changeStr)
      LinkedListCharactersAddString(ll, "</small>")
    elif includeBalance:
      LinkedListCharactersAddString(ll, balanceStr)
    elif includeDiff:
      LinkedListCharactersAddString(ll, changeStr)

    LinkedListCharactersAddString(ll, "</td>")
    i = i + 1.0
  

  LinkedListCharactersAddString(ll, "</tr>")

  # Footer
  LinkedListCharactersAddString(ll, "</table>")
  LinkedListCharactersAddString(ll, "</body>")
  LinkedListCharactersAddString(ll, "</html>")

  return LinkedListCharactersToArray(ll)

def CreateLineFromScript(ledger, script, date):

  c = CreateFixedPointForDynamicLedger(ledger)
  d = CreateFixedPointForDynamicLedger(ledger)

  parts = strSplitByCharacter(script, ',')

  i = 0.0
  while i < len(parts):
    parts[int(i)].string = strTrim(parts[int(i)].string)
    i = i + 1.0
  

  line = Line()

  n = CreateNumberFromDecimalString(parts[int(2.0)].string)

  line.date = date
  if arraysStringsEqual(parts[int(0.0)].string, "Debit"):
    Assign15d(d, n)
    Assign15d(c, 0.0)
  elif arraysStringsEqual(parts[int(0.0)].string, "Credit"):
    Assign15d(d, 0.0)
    Assign15d(c, n)

  line = CreateLine(parts[int(1.0)].string, d, c, parts[int(3.0)].string, date)

  return line

def LuhnCheck(number, errorMessage):

  numberReference = StringReference()
  checkDigitReference = CharacterReference()
  numberString =  [None]*int(1.0)
  digitReference = NumberReference()

  isValid = arraysCopyStringRange(number, 0.0, len(number) - 1.0, numberReference)
  if isValid:
    isValid = LuhnComputeCheckDigit(numberReference.string, checkDigitReference, errorMessage)
    if isValid:
      if checkDigitReference.characterValue == number[int(len(number) - 1.0)]:
        pass
      else:
        numberString[int(0.0)] = number[int(len(number) - 1.0)]
        isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage)
        if isValid:
          errorMessage.string = "Check digit wrong."
        else:
          errorMessage.string = "Check symbol not a digit."
        isValid = False
  else:
    errorMessage.string = "Number is too short: must be at least one digit."

  return isValid

def LuhnComputeCheckDigit(number, checkDigitReference, errorMessage):

  sum = 0.0
  alternate = True
  numberString =  [None]*int(1.0)
  numberReference = NumberReference()
  isValid = True

  i = len(number) - 1.0
  while i >= 0.0 and isValid:
    numberString[int(0.0)] = number[int(i)]
    isValid = CreateNumberFromDecimalStringWithCheck(numberString, numberReference, errorMessage)
    if isValid:
      n = numberReference.numberValue
      if alternate:
        n = n*2.0
        if n > 9.0:
          n = (n % 10.0) + 1.0
      sum = sum + n
      alternate =  not alternate 
    else:
      errorMessage.string = "Invalid digit in number string."
    i = i - 1.0
  

  if isValid:
    check = sum % 10.0

    if check != 0.0:
      check = 10.0 - check

    GetSingleDigitCharacterFromNumberWithCheck(check, 10.0, checkDigitReference)

  return isValid

def LuhnExtendWithCheckDigit(number, extended, errorMessage):

  checkDigitReference = CharacterReference()
  isValid = LuhnComputeCheckDigit(number, checkDigitReference, errorMessage)

  if isValid:
    extended.string =  [None]*int(len(number) + 1.0)
    i = 0.0
    while i < len(number):
      extended.string[int(i)] = number[int(i)]
      i = i + 1.0
    
    extended.string[int(i)] = checkDigitReference.characterValue

  return isValid

def ISINCheck(isin, errorMessage):

  numberReference = StringReference()
  checkDigitReference = CharacterReference()
  numberString =  [None]*int(1.0)
  digitReference = NumberReference()

  if len(isin) == 12.0:
    arraysCopyStringRange(isin, 0.0, len(isin) - 1.0, numberReference)

    isValid = ISINComputeCheckDigit(numberReference.string, checkDigitReference, errorMessage)
    if isValid:
      if checkDigitReference.characterValue == isin[int(len(isin) - 1.0)]:
        pass
      else:
        numberString[int(0.0)] = isin[int(len(isin) - 1.0)]
        isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage)
        if isValid:
          errorMessage.string = "Check digit wrong."
        else:
          errorMessage.string = "Check symbol not a digit."
        isValid = False
  else:
    isValid = False
    errorMessage.string = "ISIN must be 12 alpha-numeric characters."

  return isValid

def ISINComputeCheckDigit(isin, checkDigitReference, errorMessage):

  isinNumericReference = StringReference()

  if len(isin) == 11.0:
    isValid = ISINToNumericCode(isin, isinNumericReference, errorMessage)

    if isValid:
      LuhnComputeCheckDigit(isinNumericReference.string, checkDigitReference, errorMessage)
  else:
    isValid = False
    errorMessage.string = "ISIN must be 11 digits before the checksum digit to be calculated."

  return isValid

def ISINExtendWithCheckDigit(isin, extended, errorMessage):

  checkDigitReference = CharacterReference()
  isValid = ISINComputeCheckDigit(isin, checkDigitReference, errorMessage)

  if isValid:
    extended.string =  [None]*int(len(isin) + 1.0)
    i = 0.0
    while i < len(isin):
      extended.string[int(i)] = isin[int(i)]
      i = i + 1.0
    
    extended.string[int(i)] = checkDigitReference.characterValue

  return isValid

def ISINToNumericCode(isin, isinNumericReference, errorMessage):

  isValid = True
  code = StringReference()

  length = 0.0

  i = 0.0
  while i < len(isin) and isValid:
    if cIsLetter(isin[int(i)]):
      length = length + 2.0
    elif cIsNumber(isin[int(i)]):
      length = length + 1.0
    else:
      isValid = False
      errorMessage.string = "ISIN can only contain alpha-numeric characters."
    i = i + 1.0
  

  if isValid:
    isinNumericReference.string =  [None]*int(length)

    pos = 0.0

    i = 0.0
    while i < len(isin):
      ISINSymbolToCode(isin[int(i)], code, errorMessage)

      isinNumericReference.string[int(pos)] = code.string[int(0.0)]
      pos = pos + 1.0
      if len(code.string) == 2.0:
        isinNumericReference.string[int(pos)] = code.string[int(1.0)]
        pos = pos + 1.0
      i = i + 1.0
    

  return isValid

def ISINSymbolToCode(c, stringReference, errorMessage):

  if cIsLetter(c) and cIsUpperCase(c):
    if c == 'A':
      stringReference.string = "10"
    elif c == 'B':
      stringReference.string = "11"
    elif c == 'C':
      stringReference.string = "12"
    elif c == 'D':
      stringReference.string = "13"
    elif c == 'E':
      stringReference.string = "14"
    elif c == 'F':
      stringReference.string = "15"
    elif c == 'G':
      stringReference.string = "16"
    elif c == 'H':
      stringReference.string = "17"
    elif c == 'I':
      stringReference.string = "18"
    elif c == 'J':
      stringReference.string = "19"
    elif c == 'K':
      stringReference.string = "20"
    elif c == 'L':
      stringReference.string = "21"
    elif c == 'M':
      stringReference.string = "22"
    elif c == 'N':
      stringReference.string = "23"
    elif c == 'O':
      stringReference.string = "24"
    elif c == 'P':
      stringReference.string = "25"
    elif c == 'Q':
      stringReference.string = "26"
    elif c == 'R':
      stringReference.string = "27"
    elif c == 'S':
      stringReference.string = "28"
    elif c == 'T':
      stringReference.string = "29"
    elif c == 'U':
      stringReference.string = "30"
    elif c == 'V':
      stringReference.string = "31"
    elif c == 'W':
      stringReference.string = "32"
    elif c == 'X':
      stringReference.string = "33"
    elif c == 'Y':
      stringReference.string = "34"
    elif c == 'Z':
      stringReference.string = "35"

    isValid = True
  elif cIsNumber(c):
    if c == '0':
      stringReference.string = "0"
    elif c == '1':
      stringReference.string = "1"
    elif c == '2':
      stringReference.string = "2"
    elif c == '3':
      stringReference.string = "3"
    elif c == '4':
      stringReference.string = "4"
    elif c == '5':
      stringReference.string = "5"
    elif c == '6':
      stringReference.string = "6"
    elif c == '7':
      stringReference.string = "7"
    elif c == '8':
      stringReference.string = "8"
    elif c == '9':
      stringReference.string = "9"

    isValid = True
  else:
    isValid = False
    errorMessage.string = "Character is not an ISIN alpha-character."

  return isValid

def GenerateBarcodeEAN13(code, widthInMm, heightInMm, pixelsPerMm):

  h = Round(heightInMm*pixelsPerMm)
  w = Round(widthInMm*pixelsPerMm)

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
  moduleWidthWholePixels = floor(moduleWidthPixels)
  leftQuietZoneWholePixels = 11.0*moduleWidthWholePixels
  leftQuietZonePixels = 11.0*moduleWidthPixels
  group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
  distanceToSecondGroup = group1x + (7.0*6.0 + 4.0)*moduleWidthPixels
  betweenCharatcers = charwidth*92.0/100.0*pixelsPerMm

  uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

  counterReference = CreateNumberReference(leftQuietZoneWholePixels)

  group1Pattern = GetEAN13Group1Pattern(code[int(0.0)])

  # Start symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  i = 1.0
  while i < len(code):
    c = code[int(i)]
    if i <= 6.0:
      type = group1Pattern[int(i - 1.0)]
      if type == 'L':
        widths = GetUPCLCodeWidths(c)
      else:
        widths = GetUPCGCodeWidths(c)
    else:
      widths = GetUPCRCodeWidths(c)
    DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

    if i == 6.0:
      symbolWidths = GetUPCWidths(11.0)
      DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
    i = i + 1.0
  

  # Checksum
  checksum = GetCalculateUPCChecksum(code)
  characterReference = CharacterReference()
  GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
  character = characterReference.characterValue
  characterReference = None
  symbolWidths = GetUPCRCodeWidths(character)
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels)

  # Stop symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
  DrawImageOnImage(image, barcode, 0.0, 0.0)

  # Draw digits
  i = 0.0
  while i < len(code):
    digit = GetNumberFromNumberCharacterForBase(code[int(i)], 10.0)
    if i == 0.0:
      DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
    elif i <= 6.0:
      DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    else:
      DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    i = i + 1.0
  
  DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

  return image

def GetEAN13Group1Pattern(code):

  spaces = ""

  if code == '0':
    spaces = "LLLLLL"
  if code == '1':
    spaces = "LLGLGG"
  if code == '2':
    spaces = "LLGGLG"
  if code == '3':
    spaces = "LLGGGL"
  if code == '4':
    spaces = "LGLLGG"
  if code == '5':
    spaces = "LGGLLG"
  if code == '6':
    spaces = "LGGGLL"
  if code == '7':
    spaces = "LGLGLG"
  if code == '8':
    spaces = "LGLGGL"
  if code == '9':
    spaces = "LGGLGL"

  return spaces

def GenerateBarcodeEAN8(code, widthInMm, heightInMm, pixelsPerMm):

  h = Round(heightInMm*pixelsPerMm)
  w = Round(widthInMm*pixelsPerMm)

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
  moduleWidthWholePixels = floor(moduleWidthPixels)
  leftQuietZoneWholePixels = 3.0*moduleWidthWholePixels
  leftQuietZonePixels = 3.0*moduleWidthPixels
  group1x = leftQuietZonePixels + 3.0*moduleWidthPixels
  distanceToSecondGroup = group1x + (7.0*3.0 + 4.0)*moduleWidthPixels
  betweenCharatcers = charwidth*92.0/100.0*pixelsPerMm

  uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

  counterReference = CreateNumberReference(leftQuietZoneWholePixels)

  # Start symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  i = 0.0
  while i < len(code):
    c = code[int(i)]
    if i <= 3.0:
      widths = GetUPCLCodeWidths(c)
    else:
      widths = GetUPCRCodeWidths(c)
    DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

    if i == 3.0:
      symbolWidths = GetUPCWidths(11.0)
      DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
    i = i + 1.0
  

  # Checksum
  checksum = GetCalculateUPCChecksum(code)
  characterReference = CharacterReference()
  GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
  character = characterReference.characterValue
  characterReference = None
  symbolWidths = GetUPCRCodeWidths(character)
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels)

  # Stop symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
  DrawImageOnImage(image, barcode, 0.0, 0.0)

  # Draw digits
  i = 0.0
  while i < len(code):
    digit = GetNumberFromNumberCharacterForBase(code[int(i)], 10.0)
    if i <= 3.0:
      DrawDigitOnBarcode(image, group1x + i*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    else:
      DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    i = i + 1.0
  
  DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

  return image

def GenerateBarcodeUPCA(code, widthInMm, heightInMm, pixelsPerMm):

  h = Round(heightInMm*pixelsPerMm)
  w = Round(widthInMm*pixelsPerMm)

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
  moduleWidthWholePixels = floor(moduleWidthPixels)
  leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
  leftQuietZonePixels = 9.0*moduleWidthPixels
  group1x = leftQuietZonePixels + (3.0 + 7.0)*moduleWidthPixels
  distanceToSecondGroup = group1x + (7.0*5.0 + 5.0)*moduleWidthPixels
  distanceToThirdGroup = distanceToSecondGroup + (7.0*5.0 + 5.0)*moduleWidthPixels
  betweenCharatcers = charwidth*89.0/100.0*pixelsPerMm

  uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

  counterReference = CreateNumberReference(leftQuietZoneWholePixels)

  # Start symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  i = 0.0
  while i < len(code):
    c = code[int(i)]
    if i <= 5.0:
      widths = GetUPCLCodeWidths(c)
    else:
      widths = GetUPCRCodeWidths(c)

    if i == 0.0:
      DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, longHeight, counterReference, moduleWidthWholePixels)
    else:
      DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)

    if i == 5.0:
      symbolWidths = GetUPCWidths(11.0)
      DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)
    i = i + 1.0
  

  # Checksum
  checksum = GetCalculateUPCChecksum(code)
  characterReference = CharacterReference()
  GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
  character = characterReference.characterValue
  characterReference = None
  symbolWidths = GetUPCRCodeWidths(character)
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  # Stop symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
  DrawImageOnImage(image, barcode, 0.0, 0.0)

  # Draw digits
  i = 0.0
  while i < len(code):
    digit = GetNumberFromNumberCharacterForBase(code[int(i)], 10.0)
    if i == 0.0:
      DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
    elif i <= 5.0:
      DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    else:
      DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 6.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    i = i + 1.0
  
  DrawDigitOnBarcode(image, distanceToThirdGroup + (i - 10.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

  return image

def GetCalculateUPCChecksum(chars):

  numberString =  [None]*int(1.0)

  checksum = 0.0
  next = True
  nextWeight = 3.0

  i = len(chars) - 1.0
  while i >= 0.0:
    numberString[int(0.0)] = chars[int(i)]
    value = CreateNumberFromDecimalString(numberString)
    checksum = checksum + value*nextWeight

    if next:
      nextWeight = 1.0
    else:
      nextWeight = 3.0
    next =  not next 
    i = i - 1.0
  

  nearest10 = ceil(checksum/10.0)*10.0

  return nearest10 - checksum

def GetUPCStartAndStopCode():
  return 10.0

def GetEAN13Width():
  return 95.0 + 11.0

def GetUPCWidths(code):

  spaces = ""

  if code == 10.0:
    spaces = "101"
  if code == 11.0:
    spaces = "01010"

  return spaces

def DrawBarcodeUPCSymbol(image, widths, h, counterReference, moduleWidthPixels):

  i = 0.0
  while i < len(widths):
    widthCharacter = widths[int(i)]
    if widthCharacter == '1':
      color = GetBlack()
    else:
      color = GetWhite()

    j = 0.0
    while j < moduleWidthPixels:
      DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, color)
      counterReference.numberValue = counterReference.numberValue + 1.0
      j = j + 1.0
    
    i = i + 1.0
  

def GetUPCLCodeWidths(code):

  spaces = ""

  if code == '0':
    spaces = "0001101"
  if code == '1':
    spaces = "0011001"
  if code == '2':
    spaces = "0010011"
  if code == '3':
    spaces = "0111101"
  if code == '4':
    spaces = "0100011"
  if code == '5':
    spaces = "0110001"
  if code == '6':
    spaces = "0101111"
  if code == '7':
    spaces = "0111011"
  if code == '8':
    spaces = "0110111"
  if code == '9':
    spaces = "0001011"

  return spaces

def GetUPCGCodeWidths(code):

  spaces = ""

  if code == '0':
    spaces = "0100111"
  if code == '1':
    spaces = "0110011"
  if code == '2':
    spaces = "0011011"
  if code == '3':
    spaces = "0100001"
  if code == '4':
    spaces = "0011101"
  if code == '5':
    spaces = "0111001"
  if code == '6':
    spaces = "0000101"
  if code == '7':
    spaces = "0010001"
  if code == '8':
    spaces = "0001001"
  if code == '9':
    spaces = "0010111"
  return spaces

def GetUPCRCodeWidths(code):

  spaces = ""

  if code == '0':
    spaces = "1110010"
  if code == '1':
    spaces = "1100110"
  if code == '2':
    spaces = "1101100"
  if code == '3':
    spaces = "1000010"
  if code == '4':
    spaces = "1011100"
  if code == '5':
    spaces = "1001110"
  if code == '6':
    spaces = "1010000"
  if code == '7':
    spaces = "1000100"
  if code == '8':
    spaces = "1001000"
  if code == '9':
    spaces = "1110100"

  return spaces

def DrawDigitOnBarcode(image, topx, topy, digit, pixelsPerMm, zoom):

  digitImage = CreateImage(30.0, 37.0, GetWhite())
  DrawDigitCharacter(digitImage, 0.0, 0.0, digit)
  scaled = BilinaerScaleUpFactor(digitImage, pixelsPerMm*zoom/DPIToDotsPerMm(300.0))
  DrawImageOnImage(image, scaled, floor(topx), floor(topy))
  digitImage = None
  scaled = None

def UPCAToUPCE(a):

  e =  [None]*int(7.0)
  e[int(0.0)] = a[int(0.0)]

  mfg = strSubstring(a, 1.0, 6.0)
  productCode = strSubstring(a, 6.0, 11.0)

  e[int(1.0)] = mfg[int(0.0)]
  e[int(2.0)] = mfg[int(1.0)]
  if (strSubstringEquals(mfg, 2.0, "000") or strSubstringEquals(mfg, 2.0, "100") or strSubstringEquals(mfg, 2.0, "200")) and productCode[int(0.0)] == '0' and productCode[int(1.0)] == '0':
    e[int(3.0)] = productCode[int(2.0)]
    e[int(4.0)] = productCode[int(3.0)]
    e[int(5.0)] = productCode[int(4.0)]
    e[int(6.0)] = mfg[int(2.0)]
  elif strSubstringEquals(mfg, 3.0, "00") and productCode[int(0.0)] == '0' and productCode[int(1.0)] == '0' and productCode[int(2.0)] == '0':
    e[int(3.0)] = mfg[int(2.0)]
    e[int(4.0)] = productCode[int(3.0)]
    e[int(5.0)] = productCode[int(4.0)]
    e[int(6.0)] = '3'
  elif strSubstringEquals(mfg, 4.0, "0") and productCode[int(0.0)] == '0' and productCode[int(1.0)] == '0' and productCode[int(2.0)] == '0' and productCode[int(3.0)] == '0':
    e[int(3.0)] = mfg[int(2.0)]
    e[int(4.0)] = mfg[int(3.0)]
    e[int(5.0)] = productCode[int(4.0)]
    e[int(6.0)] = '4'
  elif arraysStringsEqual(productCode, "00005") or arraysStringsEqual(productCode, "00006") or arraysStringsEqual(productCode, "00006") or arraysStringsEqual(productCode, "00007") or arraysStringsEqual(productCode, "00008") or arraysStringsEqual(productCode, "00009"):
    e[int(3.0)] = mfg[int(2.0)]
    e[int(4.0)] = mfg[int(3.0)]
    e[int(5.0)] = mfg[int(4.0)]
    e[int(6.0)] = productCode[int(4.0)]

  return e

def UPCEToUPCA(e):

  a =  [None]*int(11.0)

  a[int(0.0)] = e[int(0.0)]

  if e[int(6.0)] == '0' or e[int(6.0)] == '1' or e[int(6.0)] == '2':
    a[int(1.0)] = e[int(1.0)]
    a[int(2.0)] = e[int(2.0)]
    a[int(3.0)] = e[int(6.0)]
    a[int(4.0)] = '0'
    a[int(5.0)] = '0'
    a[int(6.0)] = '0'
    a[int(7.0)] = '0'
    a[int(8.0)] = e[int(3.0)]
    a[int(9.0)] = e[int(4.0)]
    a[int(10.0)] = e[int(5.0)]
  elif e[int(6.0)] == '3':
    a[int(1.0)] = e[int(1.0)]
    a[int(2.0)] = e[int(2.0)]
    a[int(3.0)] = e[int(3.0)]
    a[int(4.0)] = '0'
    a[int(5.0)] = '0'
    a[int(6.0)] = '0'
    a[int(7.0)] = '0'
    a[int(8.0)] = '0'
    a[int(9.0)] = e[int(4.0)]
    a[int(10.0)] = e[int(5.0)]
  elif e[int(6.0)] == '4':
    a[int(1.0)] = e[int(1.0)]
    a[int(2.0)] = e[int(2.0)]
    a[int(3.0)] = e[int(3.0)]
    a[int(4.0)] = e[int(4.0)]
    a[int(5.0)] = '0'
    a[int(6.0)] = '0'
    a[int(7.0)] = '0'
    a[int(8.0)] = '0'
    a[int(9.0)] = '0'
    a[int(10.0)] = e[int(5.0)]
  else:
    a[int(1.0)] = e[int(1.0)]
    a[int(2.0)] = e[int(2.0)]
    a[int(3.0)] = e[int(3.0)]
    a[int(4.0)] = e[int(4.0)]
    a[int(5.0)] = e[int(5.0)]
    a[int(6.0)] = '0'
    a[int(7.0)] = '0'
    a[int(8.0)] = '0'
    a[int(9.0)] = '0'
    a[int(10.0)] = e[int(6.0)]

  return a

def GenerateBarcodeUPCE(e, widthInMm, heightInMm, pixelsPerMm):

  h = Round(heightInMm*pixelsPerMm)
  w = Round(widthInMm*pixelsPerMm)

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
  moduleWidthWholePixels = floor(moduleWidthPixels)
  leftQuietZoneWholePixels = 9.0*moduleWidthWholePixels
  leftQuietZonePixels = 9.0*moduleWidthPixels
  group1x = leftQuietZonePixels + (3.0 + 1.0)*moduleWidthPixels
  distanceToSecondGroup = group1x + (7.0*6.0 + 5.0)*moduleWidthPixels
  betweenCharatcers = charwidth*89.0/100.0*pixelsPerMm

  uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite())

  counterReference = CreateNumberReference(leftQuietZoneWholePixels)

  # Checksum
  a = UPCEToUPCA(e)
  checksum = GetCalculateUPCChecksum(a)
  characterReference = CharacterReference()
  GetSingleDigitCharacterFromNumberWithCheck(checksum, 10.0, characterReference)
  character = characterReference.characterValue

  # Start symbol
  symbolWidths = GetUPCWidths(GetUPCStartAndStopCode())
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels)

  pattern = GetUPCEPattern(character, e[int(0.0)])

  i = 1.0
  while i < len(e):
    c = e[int(i)]
    type = pattern[int(i - 1.0)]
    if type == 'O':
      widths = GetUPCLCodeWidths(c)
    else:
      widths = GetUPCGCodeWidths(c)

    DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels)
    i = i + 1.0
  

  # Stop symbol
  DrawBarcodeUPCSymbol(uninterpolatedBarcode, "010101", longHeight, counterReference, moduleWidthWholePixels)

  barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h)
  DrawImageOnImage(image, barcode, 0.0, 0.0)

  # Draw digits
  i = 0.0
  while i < len(e):
    digit = GetNumberFromNumberCharacterForBase(e[int(i)], 10.0)
    if i == 0.0:
      DrawDigitOnBarcode(image, 0.0, textY, digit, pixelsPerMm, zoom)
    elif i <= 6.0:
      DrawDigitOnBarcode(image, group1x + (i - 1.0)*betweenCharatcers, textY, digit, pixelsPerMm, zoom)
    i = i + 1.0
  
  DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7.0)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom)

  return image

def GetUPCEPattern(check, system):

  spaces = ""

  if system == '0':
    if check == '0':
      spaces = "EEEOOO"
    if check == '1':
      spaces = "EEOEOO"
    if check == '2':
      spaces = "EEOOEO"
    if check == '3':
      spaces = "EEOOOE"
    if check == '4':
      spaces = "EOEEOO"
    if check == '5':
      spaces = "EOOEEO"
    if check == '6':
      spaces = "EOOOEE"
    if check == '7':
      spaces = "EOEOEO"
    if check == '8':
      spaces = "EOEOOE"
    if check == '9':
      spaces = "EOOEOE"
  elif system == '1':
    if check == '0':
      spaces = "OOOEEE"
    if check == '1':
      spaces = "OOEOEE"
    if check == '2':
      spaces = "OOEEOE"
    if check == '3':
      spaces = "OOEEEO"
    if check == '4':
      spaces = "OEOOEE"
    if check == '5':
      spaces = "OEEOOE"
    if check == '6':
      spaces = "OEEEOO"
    if check == '7':
      spaces = "OEOEOE"
    if check == '8':
      spaces = "OEOEEO"
    if check == '9':
      spaces = "OEEOEO"

  return spaces

def Code128EncodingParts(cs):

  parts =  [None]*int(len(cs))

  i = 0.0
  while i < len(cs):
    c = cs[int(i)]

    if IsCodeA(c) and IsCodeB(c) and IsCodeC(c):
      parts[int(i)] = 'X'
    elif IsCodeA(c) and IsCodeB(c):
      parts[int(i)] = 'D'
    elif IsCodeA(c):
      parts[int(i)] = 'A'
    elif IsCodeB(c):
      parts[int(i)] = 'B'
    i = i + 1.0
  

  return parts

def IsCodeA(c):
  return cIsNumber(c) or cIsUpperCase(c) or charIsCode128AandBSymbol(c) or charIsCode128ASymbol(c)

def IsCodeB(c):
  return cIsNumber(c) or cIsUpperCase(c) or charIsCode128AandBSymbol(c) or cIsLowerCase(c) or charIsCode128BSymbol(c)

def IsCodeC(c):
  return cIsNumber(c)

def Code128EncodingSections(cs):

  parts = Code128EncodingParts(cs)

  sections = arraysCreateString(len(cs), ' ')
  counts = arraysCreateNumberArray(len(cs), 0.0)
  next = 0.0

  # Pick C-sections.
  i = 0.0
  while i < len(cs):
    p = parts[int(i)]

    if p == 'X':
      done = False
      c = 0.0
      while i + c < len(cs) and  not done :
        if parts[int(i + c)] != 'X':
          done = True
          c = c - 1.0
        c = c + 1.0
      
      # Compress 2 or more if first, or 4 or more if not.
      if c >= 4.0 or (i == 0.0 and c >= 2.0):
        sections[int(next)] = 'C'
        c = floor(c/2.0)*2.0
        counts[int(next)] = c
        next = next + 1.0
        i = i + c - 1.0
      else:
        sections[int(next)] = 'D'
        counts[int(next)] = 1.0
        next = next + 1.0
    else:
      sections[int(next)] = p
      counts[int(next)] = 1.0
      next = next + 1.0
    i = i + 1.0
  

  # Trim
  currentSections =  [None]*int(next)
  i = 0.0
  while i < next:
    currentSections[int(i)] = sections[int(i)]
    i = i + 1.0
  

  currentCounts =  [None]*int(next)
  i = 0.0
  while i < next:
    currentCounts[int(i)] = counts[int(i)]
    i = i + 1.0
  

  sections = arraysCreateString(len(cs), ' ')
  counts = arraysCreateNumberArray(len(cs), 0.0)

  # Compress A+A&D and B+B&D
  next = 0.0
  i = 0.0
  while i < len(currentSections):
    p = currentSections[int(i)]

    if p == 'C' or p == 'D':
      sections[int(next)] = p
      counts[int(next)] = currentCounts[int(i)]
      next = next + 1.0
    elif p == 'A':
      sum = 0.0
      done = False
      c = 0.0
      while i + c < len(currentSections) and  not done :
        if currentSections[int(i + c)] == 'A' or currentSections[int(i + c)] == 'D':
          sum = sum + currentCounts[int(i + c)]
        else:
          done = True
          c = c - 1.0
        c = c + 1.0
      
      sections[int(next)] = p
      counts[int(next)] = sum
      next = next + 1.0
      i = i + c - 1.0
    elif p == 'B':
      sum = 0.0
      done = False
      c = 0.0
      while i + c < len(currentSections) and  not done :
        if currentSections[int(i + c)] == 'B' or currentSections[int(i + c)] == 'D':
          sum = sum + currentCounts[int(i + c)]
        else:
          done = True
          c = c - 1.0
        c = c + 1.0
      
      sections[int(next)] = p
      counts[int(next)] = sum
      next = next + 1.0
      i = i + c - 1.0
    i = i + 1.0
  

  # Trim
  currentSections =  [None]*int(next)
  i = 0.0
  while i < next:
    currentSections[int(i)] = sections[int(i)]
    i = i + 1.0
  

  currentCounts =  [None]*int(next)
  i = 0.0
  while i < next:
    currentCounts[int(i)] = counts[int(i)]
    i = i + 1.0
  

  sections = arraysCreateString(len(cs), ' ')
  counts = arraysCreateNumberArray(len(cs), 0.0)

  # Compress D+A&D and D+B&D
  next = 0.0
  i = 0.0
  while i < len(currentSections):
    p = currentSections[int(i)]

    sum = 0.0

    if p == 'C' or p == 'A' or p == 'B':
      sections[int(next)] = p
      counts[int(next)] = currentCounts[int(i)]
      next = next + 1.0
    elif p == 'D':
      selected = ' '
      done = False

      sum = 0.0
      c = 0.0
      while i + c < len(currentSections) and  not done :
        p = currentSections[int(i + c)]

        if p == 'D':
          sum = sum + currentCounts[int(i + c)]
        elif p == 'A' or p == 'B':
          if selected == ' ':
            selected = p
            sum = sum + currentCounts[int(i + c)]
          elif p != selected:
            done = True
            c = c - 1.0
          else:
            sum = sum + currentCounts[int(i + c)]
        else:
          done = True
          c = c - 1.0
        c = c + 1.0
      
      if selected == ' ':
        selected = 'A'
      sections[int(next)] = selected
      counts[int(next)] = sum
      next = next + 1.0
      i = i + c - 1.0
    i = i + 1.0
  

  # Trim
  currentSections =  [None]*int(next)
  i = 0.0
  while i < next:
    currentSections[int(i)] = sections[int(i)]
    i = i + 1.0
  
  sections = currentSections

  currentCounts =  [None]*int(next)
  i = 0.0
  while i < next:
    currentCounts[int(i)] = counts[int(i)]
    i = i + 1.0
  
  counts = currentCounts

  # Done
  sectionsStruct = Sections()
  sectionsStruct.codes = sections
  sectionsStruct.counts = counts

  return sectionsStruct

def Code128Encode(cs):

  coded =  [None]*int(len(cs) + 2.0 + 1.0 + 1.0 + 10.0)
  cnr = 0.0
  isFirst = True
  next = 0.0

  lastSection = '0'

  sections = Code128EncodingSections(cs)

  n = 0.0
  while n < len(sections.codes):
    section = sections.codes[int(n)]
    count = sections.counts[int(n)]

    # start code
    if isFirst:
      if section == 'A':
        coded[int(next)] = 103.0
      elif section == 'B':
        coded[int(next)] = 104.0
      elif section == 'C':
        coded[int(next)] = 105.0
      next = next + 1.0

      isFirst = False

    # Encode
    if section == 'A':
      if lastSection == 'B' or lastSection == 'C':
        coded[int(next)] = 101.0
        next = next + 1.0

      k = 0.0
      while k < count:
        coded[int(next)] = GetCode128ACode(cs[int(cnr + k)])
        next = next + 1.0
        k = k + 1.0
      
      cnr = cnr + count
    elif section == 'B':
      if lastSection == 'A' or lastSection == 'C':
        coded[int(next)] = 100.0
        next = next + 1.0

      k = 0.0
      while k < count:
        coded[int(next)] = GetCode128BCode(cs[int(cnr + k)])
        next = next + 1.0
        k = k + 1.0
      
      cnr = cnr + count
    elif section == 'C':
      if lastSection == 'A' or lastSection == 'B':
        coded[int(next)] = 99.0
        next = next + 1.0

      k = 0.0
      while k < count:
        coded[int(next)] = GetCode128CCode(cs[int(cnr + k)], cs[int(cnr + k + 1.0)])
        next = next + 1.0
        k = k + 2.0
      
      cnr = cnr + count

    lastSection = section
    n = n + 1.0
  

  coded[int(next)] = CalculateCode128ChecksumWithLength(coded, next)
  next = next + 1.0

  coded[int(next)] = 108.0
  next = next + 1.0

  # trim array
  nextCoded =  [None]*int(next)
  k = 0.0
  while k < next:
    nextCoded[int(k)] = coded[int(k)]
    k = k + 1.0
  
  coded = None
  coded = nextCoded

  return coded

def GetCode128ACode(c):

  n = ord(c)

  if n >= 32.0 and n <= 95.0:
    code = n - 32.0
  elif n >= 0.0 and n <= 31.0:
    code = 64.0 + n
  else:
    code = -1.0

  return code

def GetCode128BCode(c):

  n = ord(c)

  if n >= 32.0 and n <= 126.0:
    code = n - 32.0
  elif n == 127.0:
    code = 95.0
  else:
    code = -1.0

  return code

def GetCode128CCode(c1, c2):

  n1 = GetNumberFromNumberCharacterForBase(c1, 10.0)
  n2 = GetNumberFromNumberCharacterForBase(c2, 10.0)

  return n1*10.0 + n2

def charIsCode128AandBSymbol(character):

  common = False
  if character == ' ':
    common = True
  elif character == '!':
    common = True
  elif character == '\"':
    common = True
  elif character == '#':
    common = True
  elif character == '$':
    common = True
  elif character == '%':
    common = True
  elif character == '&':
    common = True
  elif character == '\'':
    common = True
  elif character == '(':
    common = True
  elif character == ')':
    common = True
  elif character == '*':
    common = True
  elif character == '+':
    common = True
  elif character == ',':
    common = True
  elif character == '-':
    common = True
  elif character == '.':
    common = True
  elif character == '/':
    common = True
  elif character == ':':
    common = True
  elif character == ';':
    common = True
  elif character == '<':
    common = True
  elif character == '=':
    common = True
  elif character == '>':
    common = True
  elif character == '?':
    common = True
  elif character == '@':
    common = True
  elif character == '[':
    common = True
  elif character == '\\':
    common = True
  elif character == ']':
    common = True
  elif character == '^':
    common = True
  elif character == '_':
    common = True

  return common

def charIsCode128BSymbol(character):

  codeB = False
  if character == '`':
    codeB = True
  elif character == '{':
    codeB = True
  elif character == '|':
    codeB = True
  elif character == '}':
    codeB = True
  elif character == '~':
    codeB = True
  elif ord(character) == 127.0:
    # del
    codeB = True

  return codeB

def charIsCode128ASymbol(character):

  n = ord(character)

  codeA = False
  if n >= 0.0 and n <= 31.0:
    codeA = True

  return codeA

def GenerateBarcodeCode128(chars, height):

  image = RGBABitmapImage()
  errorMessages = CreateStringReference("")

  success = GenerateBarcodeCode128AllParams(chars, height, 2.0, image, errorMessages)

  errorMessages = None

  return image

def GenerateBarcodeCode128AllParams(chars, height, moduleWidth, image, errorMessages):

  success = IsValidCode128Data(chars, height, moduleWidth, errorMessages)

  if success:
    codes = Code128Encode(chars)

    h = height
    w = CalculateCode128Width(codes, moduleWidth)

    newImage = CreateImage(w, h, GetWhite())
    image.x = newImage.x
    newImage = None

    counterReference = NumberReference()

    # Start Quiet Zone
    counterReference.numberValue = 10.0*moduleWidth

    i = 0.0
    while i < len(codes):
      code = codes[int(i)]
      DrawBarcodeSymbol(image, code, h, moduleWidth, counterReference)
      i = i + 1.0
    

    # End Quiet Zone
    counterReference.numberValue = counterReference.numberValue + 10.0*moduleWidth

  return success

def IsValidCode128Data(chars, height, moduleWidth, errorMessages):

  validCharacters = 0.0

  i = 0.0
  while i < len(chars):
    if ord(chars[int(i)]) >= 0.0 and ord(chars[int(i)]) <= 127.0:
      validCharacters = validCharacters + 1.0
    i = i + 1.0
  

  if validCharacters == len(chars):

    if height > 0.0:
      if Truncate(height) == height:
        if moduleWidth > 0.0:
          if Truncate(moduleWidth) == moduleWidth:
            valid = True
          else:
            valid = False
            errorMessages.string = strAppendString(errorMessages.string, "Module width must be a whole number of pixels.")
        else:
          valid = False
          errorMessages.string = strAppendString(errorMessages.string, "Module width must be at least one pixel.")
      else:
        valid = False
        errorMessages.string = strAppendString(errorMessages.string, "Height must be a whole number of pixels.")
    else:
      valid = False
      errorMessages.string = strAppendString(errorMessages.string, "Height must be at least one pixel.")
  else:
    valid = False
    errorMessages.string = strAppendString(errorMessages.string, "Input data contains character invalid for this implementation of Code 128. Only 0-127 (inclusive) supported in this implementation.")

  return valid

def CalculateCode128Width(codes, moduleWidth):

  # Quiet Zone + 11 * codes + stop symbol extra + Quiet Zone.
  width = (10.0 + len(codes)*11.0 + 2.0 + 10.0)*moduleWidth

  return width

def CalculateCode128Checksum(codes):
  return CalculateCode128ChecksumWithLength(codes, len(codes))

def CalculateCode128ChecksumWithLength(codes, length):

  checksum = 0.0

  position = 1.0
  i = 0.0
  while i < length:
    if i > 1.0:
      position = position + 1.0
    value = codes[int(i)]
    checksum = checksum + position*value
    i = i + 1.0
  

  return checksum % 103.0

def DrawBarcodeSymbol(image, barcodeNr, h, moduleWidth, counterReference):

  widths = GetCode128Widths(barcodeNr)

  nextColor = GetBlack()
  next = True

  i = 0.0
  while i < len(widths):
    widthCharacter = widths[int(i)]
    width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

    j = 0.0
    while j < width:
      k = 0.0
      while k < moduleWidth:
        DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
        counterReference.numberValue = counterReference.numberValue + 1.0
        k = k + 1.0
      
      j = j + 1.0
    

    if next:
      nextColor = GetWhite()
    else:
      nextColor = GetBlack()
    next =  not next 
    i = i + 1.0
  

def GetCode128Widths(code):

  spaces = ""

  if code == 0.0:
    spaces = "212222"
  if code == 1.0:
    spaces = "222122"
  if code == 2.0:
    spaces = "222221"
  if code == 3.0:
    spaces = "121223"
  if code == 4.0:
    spaces = "121322"
  if code == 5.0:
    spaces = "131222"
  if code == 6.0:
    spaces = "122213"
  if code == 7.0:
    spaces = "122312"
  if code == 8.0:
    spaces = "132212"
  if code == 9.0:
    spaces = "221213"
  if code == 10.0:
    spaces = "221312"
  if code == 11.0:
    spaces = "231212"
  if code == 12.0:
    spaces = "112232"
  if code == 13.0:
    spaces = "122132"
  if code == 14.0:
    spaces = "122231"
  if code == 15.0:
    spaces = "113222"
  if code == 16.0:
    spaces = "123122"
  if code == 17.0:
    spaces = "123221"
  if code == 18.0:
    spaces = "223211"
  if code == 19.0:
    spaces = "221132"
  if code == 20.0:
    spaces = "221231"
  if code == 21.0:
    spaces = "213212"
  if code == 22.0:
    spaces = "223112"
  if code == 23.0:
    spaces = "312131"
  if code == 24.0:
    spaces = "311222"
  if code == 25.0:
    spaces = "321122"
  if code == 26.0:
    spaces = "321221"
  if code == 27.0:
    spaces = "312212"
  if code == 28.0:
    spaces = "322112"
  if code == 29.0:
    spaces = "322211"
  if code == 30.0:
    spaces = "212123"
  if code == 31.0:
    spaces = "212321"
  if code == 32.0:
    spaces = "232121"
  if code == 33.0:
    spaces = "111323"
  if code == 34.0:
    spaces = "131123"
  if code == 35.0:
    spaces = "131321"
  if code == 36.0:
    spaces = "112313"
  if code == 37.0:
    spaces = "132113"
  if code == 38.0:
    spaces = "132311"
  if code == 39.0:
    spaces = "211313"
  if code == 40.0:
    spaces = "231113"
  if code == 41.0:
    spaces = "231311"
  if code == 42.0:
    spaces = "112133"
  if code == 43.0:
    spaces = "112331"
  if code == 44.0:
    spaces = "132131"
  if code == 45.0:
    spaces = "113123"
  if code == 46.0:
    spaces = "113321"
  if code == 47.0:
    spaces = "133121"
  if code == 48.0:
    spaces = "313121"
  if code == 49.0:
    spaces = "211331"
  if code == 50.0:
    spaces = "231131"
  if code == 51.0:
    spaces = "213113"
  if code == 52.0:
    spaces = "213311"
  if code == 53.0:
    spaces = "213131"
  if code == 54.0:
    spaces = "311123"
  if code == 55.0:
    spaces = "311321"
  if code == 56.0:
    spaces = "331121"
  if code == 57.0:
    spaces = "312113"
  if code == 58.0:
    spaces = "312311"
  if code == 59.0:
    spaces = "332111"
  if code == 60.0:
    spaces = "314111"
  if code == 61.0:
    spaces = "221411"
  if code == 62.0:
    spaces = "431111"
  if code == 63.0:
    spaces = "111224"
  if code == 64.0:
    spaces = "111422"
  if code == 65.0:
    spaces = "121124"
  if code == 66.0:
    spaces = "121421"
  if code == 67.0:
    spaces = "141122"
  if code == 68.0:
    spaces = "141221"
  if code == 69.0:
    spaces = "112214"
  if code == 70.0:
    spaces = "112412"
  if code == 71.0:
    spaces = "122114"
  if code == 72.0:
    spaces = "122411"
  if code == 73.0:
    spaces = "142112"
  if code == 74.0:
    spaces = "142211"
  if code == 75.0:
    spaces = "241211"
  if code == 76.0:
    spaces = "221114"
  if code == 77.0:
    spaces = "413111"
  if code == 78.0:
    spaces = "241112"
  if code == 79.0:
    spaces = "134111"
  if code == 80.0:
    spaces = "111242"
  if code == 81.0:
    spaces = "121142"
  if code == 82.0:
    spaces = "121241"
  if code == 83.0:
    spaces = "114212"
  if code == 84.0:
    spaces = "124112"
  if code == 85.0:
    spaces = "124211"
  if code == 86.0:
    spaces = "411212"
  if code == 87.0:
    spaces = "421112"
  if code == 88.0:
    spaces = "421211"
  if code == 89.0:
    spaces = "212141"
  if code == 90.0:
    spaces = "214121"
  if code == 91.0:
    spaces = "412121"
  if code == 92.0:
    spaces = "111143"
  if code == 93.0:
    spaces = "111341"
  if code == 94.0:
    spaces = "131141"
  if code == 95.0:
    spaces = "114113"
  if code == 96.0:
    spaces = "114311"
  if code == 97.0:
    spaces = "411113"
  if code == 98.0:
    spaces = "411311"
  if code == 99.0:
    spaces = "113141"
  if code == 100.0:
    spaces = "114131"
  if code == 101.0:
    spaces = "311141"
  if code == 102.0:
    spaces = "411131"
  if code == 103.0:
    spaces = "211412"
  if code == 104.0:
    spaces = "211214"
  if code == 105.0:
    spaces = "211232"
  if code == 106.0:
    spaces = "233111"
  if code == 107.0:
    spaces = "211133"
  if code == 108.0:
    spaces = "2331112"

  return spaces

def GenerateBarcodeCode39(chars, height):
  return GenerateBarcodeCode39WithChecksumOption(chars, height, False)

def GenerateBarcodeCode39WithChecksumOption(chars, height, includeChecksum):

  h = height
  w = CalculateCode39Width(chars, includeChecksum)*2.0

  image = CreateImage(w, h, GetWhite())

  counterReference = CreateNumberReference(10.0*2.0)

  # Start symbol
  DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, True)

  i = 0.0
  while i < len(chars):
    c = chars[int(i)]
    barcodeNr = AsciiToCode39(c)
    DrawBarcode39Symbol(image, barcodeNr, h, counterReference, True)
    i = i + 1.0
  

  if includeChecksum:
    checksum = CalculateCode39Checksum(chars)
    DrawBarcode39Symbol(image, checksum, h, counterReference, True)

  # Stop symbol
  DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, False)

  return image

def CalculateCode39Checksum(chars):

  checksum = 0.0

  i = 0.0
  while i < len(chars):
    c = chars[int(i)]
    value = AsciiToCode39(c)
    checksum = checksum + value
    i = i + 1.0
  

  return checksum % 43.0

def Get39StartAndStopCode():
  return 43.0

def CalculateCode39Width(chars, includeChecksum):

  # quiet zone + start + 1 + 12*characters + 1*characters + stop + quiet zone
  width = 10.0 + 12.0 + 1.0 + len(chars)*12.0 + len(chars)*1.0 + 12.0 + 10.0

  if includeChecksum:
    width = width + 1.0 + 12.0

  return width

def DrawBarcode39Symbol(image, barcodeNr, h, counterReference, addSeparator):

  widths = GetCode39Widths(barcodeNr)

  nextColor = GetBlack()
  next = True

  j = 0.0
  while j < len(widths):
    widthCharacter = widths[int(j)]
    width = GetNumberFromNumberCharacterForBase(widthCharacter, 10.0)

    k = 0.0
    while k < width:
      DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
      counterReference.numberValue = counterReference.numberValue + 1.0
      DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, nextColor)
      counterReference.numberValue = counterReference.numberValue + 1.0
      k = k + 1.0
    

    if next:
      nextColor = GetWhite()
    else:
      nextColor = GetBlack()
    next =  not next 
    j = j + 1.0
  

  # Space
  if addSeparator:
    DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, GetWhite())
    counterReference.numberValue = counterReference.numberValue + 1.0
    DrawVerticalLine1px(image, counterReference.numberValue, 0.0, h, GetWhite())
    counterReference.numberValue = counterReference.numberValue + 1.0

def GetCode39Widths(code):

  spaces = ""

  if code == 0.0:
    spaces = "111221211"
  if code == 1.0:
    spaces = "211211112"
  if code == 2.0:
    spaces = "112211112"
  if code == 3.0:
    spaces = "212211111"
  if code == 4.0:
    spaces = "111221112"
  if code == 5.0:
    spaces = "211221111"
  if code == 6.0:
    spaces = "112221111"
  if code == 7.0:
    spaces = "111211212"
  if code == 8.0:
    spaces = "211211211"
  if code == 9.0:
    spaces = "112211211"
  if code == 10.0:
    spaces = "211112112"
  if code == 11.0:
    spaces = "112112112"
  if code == 12.0:
    spaces = "212112111"
  if code == 13.0:
    spaces = "111122112"
  if code == 14.0:
    spaces = "211122111"
  if code == 15.0:
    spaces = "112122111"
  if code == 16.0:
    spaces = "111112212"
  if code == 17.0:
    spaces = "211112211"
  if code == 18.0:
    spaces = "112112211"
  if code == 19.0:
    spaces = "111122211"
  if code == 20.0:
    spaces = "211111122"
  if code == 21.0:
    spaces = "112111122"
  if code == 22.0:
    spaces = "212111121"
  if code == 23.0:
    spaces = "111121122"
  if code == 24.0:
    spaces = "211121121"
  if code == 25.0:
    spaces = "112121121"
  if code == 26.0:
    spaces = "111111222"
  if code == 27.0:
    spaces = "211111221"
  if code == 28.0:
    spaces = "112111221"
  if code == 29.0:
    spaces = "111121221"
  if code == 30.0:
    spaces = "221111112"
  if code == 31.0:
    spaces = "122111112"
  if code == 32.0:
    spaces = "222111111"
  if code == 33.0:
    spaces = "121121112"
  if code == 34.0:
    spaces = "221121111"
  if code == 35.0:
    spaces = "122121111"
  if code == 36.0:
    spaces = "121111212"
  if code == 37.0:
    spaces = "221111211"
  if code == 38.0:
    spaces = "122111211"
  if code == 39.0:
    spaces = "121212111"
  if code == 40.0:
    spaces = "121211121"
  if code == 41.0:
    spaces = "121112121"
  if code == 42.0:
    spaces = "111212121"
  if code == 43.0:
    spaces = "121121211"

  return spaces

def AsciiToCode39(c):

  asciiToNrTable = GetAsciiToCode39Table()
  nr = ord(c)

  return asciiToNrTable[int(nr)]

def GetAsciiToCode39Table():

  c =  [None]*int(256.0)

  c[ord('0')] = 0.0
  c[ord('1')] = 1.0
  c[ord('2')] = 2.0
  c[ord('3')] = 3.0
  c[ord('4')] = 4.0
  c[ord('5')] = 5.0
  c[ord('6')] = 6.0
  c[ord('7')] = 7.0
  c[ord('8')] = 8.0
  c[ord('9')] = 9.0
  c[ord('A')] = 10.0
  c[ord('B')] = 11.0
  c[ord('C')] = 12.0
  c[ord('D')] = 13.0
  c[ord('E')] = 14.0
  c[ord('F')] = 15.0
  c[ord('G')] = 16.0
  c[ord('H')] = 17.0
  c[ord('I')] = 18.0
  c[ord('J')] = 19.0
  c[ord('K')] = 20.0
  c[ord('L')] = 21.0
  c[ord('M')] = 22.0
  c[ord('N')] = 23.0
  c[ord('O')] = 24.0
  c[ord('P')] = 25.0
  c[ord('Q')] = 26.0
  c[ord('R')] = 27.0
  c[ord('S')] = 28.0
  c[ord('T')] = 29.0
  c[ord('U')] = 30.0
  c[ord('V')] = 31.0
  c[ord('W')] = 32.0
  c[ord('X')] = 33.0
  c[ord('Y')] = 34.0
  c[ord('Z')] = 35.0
  c[ord('-')] = 36.0
  c[ord('.')] = 37.0
  c[ord(' ')] = 38.0
  c[ord('$')] = 39.0
  c[ord('/')] = 40.0
  c[ord('+')] = 41.0
  c[ord('%')] = 42.0
  c[ord('*')] = 43.0

  return c

def IsQRNumericString(chars):

  valid = True

  i = 0.0
  while i < len(chars):
    if IsQRNumericCharacter(chars[int(i)]):
      pass
    else:
      valid = False
    i = i + 1.0
  

  return valid

def IsQRNumericCharacter(aChar):
  return cIsNumber(aChar)

def IsQRAlphanumericString(chars):

  valid = True

  i = 0.0
  while i < len(chars):
    c = chars[int(i)]

    valid = IsQRAlphanumericCharacter(c)
    i = i + 1.0
  

  return valid

def IsQRAlphanumericCharacter(c):

  valid = True

  if cIsNumber(c):
    pass
  elif IsQRAlphaUppercase(c):
    pass
  elif c == ' ':
    pass
  elif c == '$':
    pass
  elif c == '%':
    pass
  elif c == '*':
    pass
  elif c == '+':
    pass
  elif c == '-':
    pass
  elif c == '.':
    pass
  elif c == '/':
    pass
  elif c == ':':
    pass
  else:
    valid = False
  return valid

def IsQRJIS8Character(c):

  code = ord(c)

  if code >= 0.0 and code < 128.0:
    valid = True
  else:
    valid = False

  return valid

def IsQRAlphaUppercase(character):

  isUpper = True
  if character == 'A':
    pass
  elif character == 'B':
    pass
  elif character == 'C':
    pass
  elif character == 'D':
    pass
  elif character == 'E':
    pass
  elif character == 'F':
    pass
  elif character == 'G':
    pass
  elif character == 'H':
    pass
  elif character == 'I':
    pass
  elif character == 'J':
    pass
  elif character == 'K':
    pass
  elif character == 'L':
    pass
  elif character == 'M':
    pass
  elif character == 'N':
    pass
  elif character == 'O':
    pass
  elif character == 'P':
    pass
  elif character == 'Q':
    pass
  elif character == 'R':
    pass
  elif character == 'S':
    pass
  elif character == 'T':
    pass
  elif character == 'U':
    pass
  elif character == 'V':
    pass
  elif character == 'W':
    pass
  elif character == 'X':
    pass
  elif character == 'Y':
    pass
  elif character == 'Z':
    pass
  else:
    isUpper = False

  return isUpper

def QRAlphanumericToCode(c):

  if c == '0':
    code = 0.0
  elif c == '1':
    code = 1.0
  elif c == '2':
    code = 2.0
  elif c == '3':
    code = 3.0
  elif c == '4':
    code = 4.0
  elif c == '5':
    code = 5.0
  elif c == '6':
    code = 6.0
  elif c == '7':
    code = 7.0
  elif c == '8':
    code = 8.0
  elif c == '9':
    code = 9.0
  elif c == 'A':
    code = 10.0
  elif c == 'B':
    code = 11.0
  elif c == 'C':
    code = 12.0
  elif c == 'D':
    code = 13.0
  elif c == 'E':
    code = 14.0
  elif c == 'F':
    code = 15.0
  elif c == 'G':
    code = 16.0
  elif c == 'H':
    code = 17.0
  elif c == 'I':
    code = 18.0
  elif c == 'J':
    code = 19.0
  elif c == 'K':
    code = 20.0
  elif c == 'L':
    code = 21.0
  elif c == 'M':
    code = 22.0
  elif c == 'N':
    code = 23.0
  elif c == 'O':
    code = 24.0
  elif c == 'P':
    code = 25.0
  elif c == 'Q':
    code = 26.0
  elif c == 'R':
    code = 27.0
  elif c == 'S':
    code = 28.0
  elif c == 'T':
    code = 29.0
  elif c == 'U':
    code = 30.0
  elif c == 'V':
    code = 31.0
  elif c == 'W':
    code = 32.0
  elif c == 'X':
    code = 33.0
  elif c == 'Y':
    code = 34.0
  elif c == 'Z':
    code = 35.0
  elif c == ' ':
    code = 36.0
  elif c == '$':
    code = 37.0
  elif c == '%':
    code = 38.0
  elif c == '*':
    code = 39.0
  elif c == '+':
    code = 40.0
  elif c == '-':
    code = 41.0
  elif c == '.':
    code = 42.0
  elif c == '/':
    code = 43.0
  elif c == ':':
    code = 44.0
  else:
    code = 0.0

  return code

def QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel):

  eccPerBlockSpec = StringToNumberArray("7, 10, 13, 17, 10, 16, 22, 28, 15, 26, 18, 22, 20, 18, 26, 16, 26, 24, 18, 22, 18, 16, 24, 28, 20, 18, 18, 26, 24, 22, 22, 26, 30, 22, 20, 24, 18, 26, 24, 28, 20, 30, 28, 24, 24, 22, 26, 28, 26, 22, 24, 22, 30, 24, 20, 24, 22, 24, 30, 24, 24, 28, 24, 30, 28, 28, 28, 28, 30, 26, 28, 28, 28, 26, 26, 26, 28, 26, 30, 28, 28, 26, 28, 30, 28, 28, 30, 24, 30, 28, 30, 30, 30, 28, 30, 30, 26, 28, 30, 30, 28, 28, 28, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30")

  blockSpecs = StringToNumberArray("1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2, 4, 1, 2, 4, 4, 2, 4, 4, 4, 2, 4, 6, 5, 2, 4, 6, 6, 2, 5, 8, 8, 4, 5, 8, 8, 4, 5, 8, 11, 4, 8, 10, 11, 4, 9, 12, 16, 4, 9, 16, 16, 6, 10, 12, 18, 6, 10, 17, 16, 6, 11, 16, 19, 6, 13, 18, 21, 7, 14, 21, 25, 8, 16, 20, 25, 8, 17, 23, 25, 9, 17, 23, 34, 9, 18, 25, 30, 10, 20, 27, 32, 12, 21, 29, 35, 12, 23, 34, 37, 12, 25, 34, 40, 13, 26, 35, 42, 14, 28, 38, 45, 15, 29, 40, 48, 16, 31, 43, 51, 17, 33, 45, 54, 18, 35, 48, 57, 19, 37, 51, 60, 19, 38, 53, 63, 20, 40, 56, 66, 21, 43, 59, 70, 22, 45, 62, 74, 24, 47, 65, 77, 25, 49, 68, 81")

  errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevel)

  eccsPerBlock = eccPerBlockSpec[int((version - 1.0)*4.0 + errorCorrectionLevelNumber)]
  nrOfBlocks = blockSpecs[int((version - 1.0)*4.0 + errorCorrectionLevelNumber)]

  blockLengths = QRComputeBlockLengths(len(cws), nrOfBlocks)

  blocks =  [None]*int(nrOfBlocks)
  blockEccs =  [None]*int(nrOfBlocks)

  cw = 0.0
  i = 0.0
  while i < nrOfBlocks:
    # Create block.
    cwsInBlock = blockLengths[int(i)]
    block =  [None]*int(cwsInBlock)
    j = 0.0
    while j < cwsInBlock:
      block[int(j)] = cws[int(cw)]
      cw = cw + 1.0
      j = j + 1.0
    

    # Compute eccs.
    ecc = ComputeReedSolomonCodes(block, eccsPerBlock)

    blocks[int(i)] = NumberArrayReference()
    blocks[int(i)].numberArray = block
    blockEccs[int(i)] = NumberArrayReference()
    blockEccs[int(i)].numberArray = ecc
    i = i + 1.0
  

  # Compose full data block:
  complete =  [None]*int(len(cws) + eccsPerBlock*nrOfBlocks)

  e = 0.0
  # Interleave codewords:
  i = 0.0
  while i < floor(len(cws)/nrOfBlocks):
    j = 0.0
    while j < nrOfBlocks:
      complete[int(e)] = blocks[int(j)].numberArray[int(i)]
      e = e + 1.0
      j = j + 1.0
    
    i = i + 1.0
  

  # Interleave remaining code words:
  i = 0.0
  while i < nrOfBlocks:
    if blockLengths[int(i)] > blockLengths[int(0.0)]:
      complete[int(e)] = blocks[int(i)].numberArray[int(blockLengths[int(i)] - 1.0)]
      e = e + 1.0
    i = i + 1.0
  

  i = 0.0
  while i < eccsPerBlock:
    j = 0.0
    while j < nrOfBlocks:
      complete[int(e)] = blockEccs[int(j)].numberArray[int(i)]
      e = e + 1.0
      j = j + 1.0
    
    i = i + 1.0
  

  return complete

def QRComputeBlockLengths(length, blocks):

  blockLengths =  [None]*int(blocks)

  q = floor(length/blocks)
  r = length % blocks

  i = 0.0
  while i < blocks:
    blockLengths[int(i)] = q
    i = i + 1.0
  

  if r > 0.0:
    i = 0.0
    while i < r:
      blockLengths[int(len(blockLengths) - 1.0 - i)] = q + 1.0
      i = i + 1.0
    

  return blockLengths

def GenerateQRCode(imageReference, chars, errorCorrectionLevel, errorMessage):

  versionReference = NumberReference()
  success = QRGetRequiredVersionFromData(chars, errorCorrectionLevel, versionReference, errorMessage)

  if success:
    version = versionReference.numberValue

    GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, QRQuietZoneSize(), errorMessage)

  return success

def QRGetRequiredVersionFromData(chars, errorCorrectionLevelCode, versionReference, errorMessage):

  modeReference = StringReference()
  success = QRDetectMode(chars, modeReference, errorMessage)

  if success:
    modeName = modeReference.string

    symbolBitsSpec = GetQRSymbolLengthsForVersions()

    errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

    done = False
    lengthReference = NumberReference()
    i = 1.0
    while i <= 40.0 and  not done :
      success = QRComputeNumberOfCodewords(len(chars), i, modeName, lengthReference, errorMessage)

      if success:
        l = lengthReference.numberValue

        if l <= symbolBitsSpec[int((i - 1.0)*4.0 + errorCorrectionLevelNumber)]:
          versionReference.numberValue = i
          done = True
      else:
        done = True
      i = i + 1.0
    

    if  not done :
      success = False
      errorMessage.string = "Too much data for any QR code."

  return success

def GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, quietZoneSize, errorMessage):

  modeReference = StringReference()
  success = QRDetectMode(chars, modeReference, errorMessage)

  if success:
    mode = modeReference.string

    size = QRVersionToModules(version)

    image = CreateImage(size, size, GetTransparent())

    QRAddTimingPattern(image, version)

    QRAddFinderPattern(image, version)

    QRAddAlignmentPatterns(image, version)

    QRAddDummyFormatBits(image, version)

    if version >= 7.0:
      QRAddVersionBits(image, version)

    bsReference = StringReference()

    success = GetQRCodewordBitSequence(chars, version, mode, bsReference, errorMessage)

    if success:
      bs = bsReference.string

      cws = QRSegmentsToCodeWords(bs, version, errorCorrectionLevel)
      allcws = QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel)

      basis = CopyImage(image)

      QRAddCodewords(image, version, allcws)

      formatbits =  [None]*int(15.0)

      masks =  [None]*int(8.0)
      withMasks =  [None]*int(8.0)
      pentalies =  [None]*int(8.0)
      i = 0.0
      while i < 8.0:
        masks[int(i)] = CreateMask(i, version)
        withMasks[int(i)] = QRApplyMask(basis, image, masks[int(i)])
        QRComputeFormatBits(formatbits, errorCorrectionLevel, i)
        QRAddFormatBits(withMasks[int(i)], formatbits)
        #System.out.println("Mask " + (int)i);
        pentalies[int(i)] = QRComputePenalty(withMasks[int(i)])
        i = i + 1.0
      

      choice = 0.0
      min = pentalies[int(choice)]
      i = 0.0
      while i < 8.0:
        if pentalies[int(i)] < min:
          choice = i
          min = pentalies[int(choice)]
        i = i + 1.0
      

      image = withMasks[int(choice)]

      sizeWithQuietZone = size + 2.0*quietZoneSize
      quietZoneImage = CreateImage(sizeWithQuietZone, sizeWithQuietZone, GetWhite())
      DrawImageOnImage(quietZoneImage, image, quietZoneSize, quietZoneSize)

      imageReference.image = quietZoneImage

  return success

def GetQRCodewordBitSequence(chars, version, modeName, bsReference, errorMessage):

  if arraysStringsEqual(modeName, "Numeric"):
    success = QRNumericDataToSegment(chars, version, bsReference, errorMessage)
  elif arraysStringsEqual(modeName, "Alphanumeric"):
    success = QRAlphanumericDataToSegment(chars, version, bsReference, errorMessage)
  elif arraysStringsEqual(modeName, "8-bit Byte"):
    success = QR8BitByteDataToSegment(chars, version, bsReference, errorMessage)
  else:
    success = False
    errorMessage.string = "Invalid data mode."

  return success

def QRComputeNumberOfCodewords(dataLength, version, modeName, lengthReference, errorMessage):

  length = 0.0
  countReference = NumberReference()

  success = QRGetCountLength(version, modeName, countReference, errorMessage)

  if success:
    c = countReference.numberValue

    if arraysStringsEqual(modeName, "Numeric"):
      r = 0.0
      last = dataLength % 3.0
      if last == 0.0:
        r = 0.0
      elif last == 1.0:
        r = 4.0
      elif last == 2.0:
        r = 7.0

      length = 4.0 + c + 10.0*floor(dataLength/3.0) + r
    elif arraysStringsEqual(modeName, "Alphanumeric"):
      length = 4.0 + c + 11.0*floor(dataLength/2.0) + 6.0*(dataLength % 2.0)
    elif arraysStringsEqual(modeName, "8-bit Byte"):
      length = 4.0 + c + 8.0*dataLength
    else:
      success = False
  else:
    success = False

  if success:
    lengthReference.numberValue = length

  return success

def QRAddVersionBits(image, version):

  ecc = ComputeBHC18_6Code(version)

  code =  [None]*int(18.0)

  str = StringReference()
  CreateStringFromNumberWithCheck(version, 2.0, str)

  offset = 6.0 - len(str.string)
  i = 0.0
  while i < 6.0:
    if i < offset:
      code[int(i)] = '0'
    else:
      code[int(i)] = str.string[int(i - offset)]
    i = i + 1.0
  

  CreateStringFromNumberWithCheck(ecc, 2.0, str)

  offset = 12.0 - len(str.string)
  i = 0.0
  while i < 12.0:
    if i < offset:
      code[int(6.0 + i)] = '0'
    else:
      code[int(6.0 + i)] = str.string[int(i - offset)]
    i = i + 1.0
  

  i = 0.0
  while i < 18.0:
    x = ImageWidth(image) - 11.0 + i % 3.0
    y = 0.0 + floor(i/3.0)

    if code[int(18.0 - 1.0 - i)] == '1':
      SetPixel(image, x, y, GetBlack())
      SetPixel(image, y, x, GetBlack())
    else:
      SetPixel(image, x, y, GetWhite())
      SetPixel(image, y, x, GetWhite())
    i = i + 1.0
  

def QRAddAlignmentPatterns(image, version):

  positions =  [None]*int(7.0)

  col2 = StringToNumberArray("18, 22, 26, 30, 34, 22, 24, 26, 28, 30, 32, 34, 26, 26, 26, 30, 30, 30, 34, 28, 26, 30, 28, 32, 30, 34, 26, 30, 26, 30, 34, 30, 34, 30, 24, 28, 32, 26, 30")
  col3 = StringToNumberArray("38, 42, 46, 50, 54, 58, 62, 46, 48, 50, 54, 56, 58, 62, 50, 50, 54, 54, 58, 58, 62, 50, 54, 52, 56, 60, 58, 62, 54, 50, 54, 58, 54, 58")
  col4 = StringToNumberArray("66, 70, 74, 78, 82, 86, 90, 72, 74, 78, 80, 84, 86, 90, 74, 78, 78, 82, 86, 86, 90, 78, 76, 80, 84, 82, 86")
  col5 = StringToNumberArray("94, 98, 102, 106, 110, 114, 118, 98, 102, 104, 108, 112, 114, 118, 102, 102, 106, 110, 110, 114")
  col6 = StringToNumberArray("122, 126, 130, 134, 138, 142, 146, 126, 128, 132, 136, 138, 142")
  col7 = StringToNumberArray("150, 154, 158, 162, 166, 170")

  positions[int(0.0)] = 6.0
  nrOfPositions = 0.0

  if version == 1.0:
    nrOfPositions = 0.0
  if version >= 2.0:
    nrOfPositions = 2.0
    positions[int(1.0)] = col2[int(version - 2.0)]
  if version >= 7.0:
    nrOfPositions = 3.0
    positions[int(2.0)] = col3[int(version - 7.0)]
  if version >= 14.0:
    nrOfPositions = 4.0
    positions[int(3.0)] = col4[int(version - 14.0)]
  if version >= 21.0:
    nrOfPositions = 5.0
    positions[int(4.0)] = col5[int(version - 21.0)]
  if version >= 28.0:
    nrOfPositions = 6.0
    positions[int(5.0)] = col6[int(version - 28.0)]
  if version >= 35.0:
    nrOfPositions = 7.0
    positions[int(6.0)] = col7[int(version - 35.0)]

  i = 0.0
  while i < nrOfPositions:
    j = 0.0
    while j < nrOfPositions:
      x = positions[int(i)]
      y = positions[int(j)]

      if x <= 8.0 and y <= 8.0:
        includePattern = False
      elif x >= ImageWidth(image) - 8.0 and y <= 8.0:
        includePattern = False
      elif x <= 8.0 and y >= ImageWidth(image) - 7.0:
        includePattern = False
      else:
        includePattern = True

      if includePattern:
        QRAddAlignmentPattern(image, x, y)
      j = j + 1.0
    
    i = i + 1.0
  

def QRAddAlignmentPattern(image, x, y):
  DrawRectangle1px(image, x, y, 0.0, 0.0, GetBlack())
  DrawRectangle1px(image, x - 1.0, y - 1.0, 2.0, 2.0, GetWhite())
  DrawRectangle1px(image, x - 2.0, y - 2.0, 4.0, 4.0, GetBlack())

def QR8BitByteDataToSegment(data, version, bsReference, errorMessage):

  countReference = NumberReference()
  success = QRGetCountLength(version, "8-bit Byte", countReference, errorMessage)

  if success:
    c = countReference.numberValue
    d = len(data)

    lengthReference = NumberReference()
    success = QRComputeNumberOfCodewords(len(data), version, "8-bit Byte", lengthReference, errorMessage)

    if success:
      length = lengthReference.numberValue

      bs = arraysCreateString(length, '0')

      # Characters
      nstr = StringReference()

      i = 0.0
      while i < d:
        n = ord(data[int(i)])

        CreateStringFromNumberWithCheck(n, 2.0, nstr)

        offset = 8.0 - len(nstr.string)
        j = 0.0
        while j < len(nstr.string):
          bs[int(4.0 + c + 8.0*i + j + offset)] = nstr.string[int(j)]
          j = j + 1.0
        
        i = i + 1.0
      

      # Character count
      CreateStringFromNumberWithCheck(d, 2.0, nstr)
      offset = 4.0 + c - len(nstr.string)
      j = 0.0
      while j < len(nstr.string):
        bs[int(offset + j)] = nstr.string[int(j)]
        j = j + 1.0
      

      # Mode
      mode = QR8BitByteModeIndicator()
      j = 0.0
      while j < 4.0:
        bs[int(j)] = mode[int(j)]
        j = j + 1.0
      

      bsReference.string = bs

  return success

def QRDetectMode(chars, modeReference, errorMessage):

  mode = 0.0
  success = False

  i = 0.0
  while i < len(chars):
    c = chars[int(i)]

    if cIsNumber(c):
      if mode == 0.0:
        mode = 1.0
        success = True
    elif IsQRAlphanumericCharacter(c):
      if mode <= 1.0:
        mode = 2.0
        success = True
    elif IsQRJIS8Character(c):
      if mode <= 2.0:
        mode = 3.0
        success = True
    else:
      mode = 5.0
      success = False
      errorMessage.string = "Data contains invalid characters"
    i = i + 1.0
  

  if mode == 0.0:
    errorMessage.string = "There is no data to put in the QR code."
  if mode == 1.0:
    modeReference.string = "Numeric"
  if mode == 2.0:
    modeReference.string = "Alphanumeric"
  if mode == 3.0:
    modeReference.string = "8-bit Byte"

  return success

def QRComputePenalty(image):

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

def QRComputePenaltyForBalance(image):

  h = ImageHeight(image)
  w = ImageWidth(image)

  total = h*w
  black = 0.0

  y = 0.0
  while y < h:
    x = 0.0
    while x < w:
      isBlack = PixelIsBlack(image, x, y)

      if isBlack:
        black = black + 1.0
      x = x + 1.0
    
    y = y + 1.0
  

  deviation = fabs(100.0*black/total - 50.0)
  balP = floor(deviation/5.0)*10.0

  return balP

def QRComputePenaltyForFinders(image):

  h = ImageHeight(image)
  w = ImageWidth(image)

  findP = 0.0
  y = 0.0
  while y < h:
    x = 0.0
    while x < w - 10.0:
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

      if d1 and  not w1  and d2 and d3 and d4 and  not w2  and d5 and  not w3  and  not w4  and  not w5  and  not w6 :
        findP = findP + 40.0

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

      if d1 and  not w1  and d2 and d3 and d4 and  not w2  and d5 and  not w3  and  not w4  and  not w5  and  not w6 :
        findP = findP + 40.0
      x = x + 1.0
    
    y = y + 1.0
  

  x = 0.0
  while x < w:
    y = 0.0
    while y < h - 10.0:
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

      if d1 and  not w1  and d2 and d3 and d4 and  not w2  and d5 and  not w3  and  not w4  and  not w5  and  not w6 :
        findP = findP + 40.0

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

      if d1 and  not w1  and d2 and d3 and d4 and  not w2  and d5 and  not w3  and  not w4  and  not w5  and  not w6 :
        findP = findP + 40.0
      y = y + 1.0
    
    x = x + 1.0
  

  return findP

def QRComputePenaltyForBoxes(image):

  h = ImageHeight(image)
  w = ImageWidth(image)

  boxP = 0.0
  y = 0.0
  while y < h - 1.0:
    x = 0.0
    while x < w - 1.0:
      ul = PixelIsBlack(image, x + 0.0, y + 0.0)
      ur = PixelIsBlack(image, x + 1.0, y + 0.0)
      ll = PixelIsBlack(image, x + 0.0, y + 1.0)
      lr = PixelIsBlack(image, x + 1.0, y + 1.0)

      if ul and ur and ll and lr or  not ul  and  not ur  and  not ll  and  not lr :
        boxP = boxP + 3.0
      x = x + 1.0
    
    y = y + 1.0
  

  return boxP

def PixelIsBlack(image, x, y):
  return GetImagePixel(image, x, y).r == 0.0

def QRComputePenaltyForRuns(image):

  h = ImageHeight(image)
  w = ImageWidth(image)

  runP = 0.0

  # Horizontal penalty
  y = 0.0
  while y < h:
    first = True
    prev = True
    cur = True
    run = 1.0

    x = 0.0
    while x <= w:
      last = x == w
      if  not last :
        cur = PixelIsBlack(image, x, y)

      if  not first :
        if prev == cur and  not last :
          run = run + 1.0

        if prev != cur or last:
          if run >= 5.0:
            runP = runP + 3.0 + run - 5.0
          run = 1.0

      first = False
      prev = cur
      x = x + 1.0
    
    y = y + 1.0
  

  # Vertical penalty
  x = 0.0
  while x < w:
    first = True
    prev = True
    cur = True
    run = 1.0

    y = 0.0
    while y <= h:
      last = y == h
      if  not last :
        cur = PixelIsBlack(image, x, y)

      if  not first :
        if prev == cur and  not last :
          run = run + 1.0

        if prev != cur or last:
          if run >= 5.0:
            runP = runP + 3.0 + run - 5.0
          run = 1.0

      first = False
      prev = cur
      y = y + 1.0
    
    x = x + 1.0
  
  return runP

def QRAddFormatBits(image, formatbits):

  black = GetBlack()
  white = GetWhite()

  x = 8.0
  y = 0.0

  # Upper-left
  i = 0.0
  while i < len(formatbits):
    b = formatbits[int(14.0 - i)]
    if b == '1':
      color = black
    else:
      color = white

    SetPixel(image, x, y, color)

    if i < 7.0:
      y = y + 1.0
    if i == 5.0:
      y = y + 1.0

    if i >= 7.0:
      x = x - 1.0
    if i == 8.0:
      x = x - 1.0
    i = i + 1.0
  

  # Lower left and top right
  x = ImageWidth(image) - 1.0
  y = 8.0

  i = 0.0
  while i < len(formatbits):
    b = formatbits[int(14.0 - i)]
    if b == '1':
      color = black
    else:
      color = white

    SetPixel(image, x, y, color)

    if i < 7.0:
      x = x - 1.0
    if i == 7.0:
      y = ImageHeight(image) - 7.0
      x = 8.0

    if i > 7.0:
      y = y + 1.0
    i = i + 1.0
  

def QRComputeFormatBits(bits, errorCorrectionLevel, mask):

  errorCorrectionCode = 0.0
  if errorCorrectionLevel == 'L':
    errorCorrectionCode = 1.0
  elif errorCorrectionLevel == 'M':
    errorCorrectionCode = 0.0
  elif errorCorrectionLevel == 'Q':
    errorCorrectionCode = 3.0
  elif errorCorrectionLevel == 'H':
    errorCorrectionCode = 2.0

  n = OrByte(ShiftLeftByte(errorCorrectionCode, 3.0), mask)

  bhc = ComputeBHC15_5Code(n)

  n = Or4Byte(ShiftLeft4Byte(n, 10.0), bhc)

  str = StringReference()
  CreateStringFromNumberWithCheck(n, 2.0, str)

  offset = 15.0 - len(str.string)
  i = 0.0
  while i < 15.0:
    if i < offset:
      bits[int(i)] = '0'
    else:
      bits[int(i)] = str.string[int(i - offset)]
    i = i + 1.0
  

  xorpattern = "101010000010010"

  i = 0.0
  while i < 15.0:
    a = bits[int(i)] == '1'
    b = xorpattern[int(i)] == '1'

    r = Xor(a, b)

    if r:
      bits[int(i)] = '1'
    else:
      bits[int(i)] = '0'
    i = i + 1.0
  

def QRApplyMask(basis, image, mask):

  withMask = CopyImage(image)

  i = 0.0
  while i < ImageWidth(basis):
    j = 0.0
    while j < ImageHeight(basis):
      if GetImagePixel(basis, i, j).a == 0.0:
        a = PixelIsBlack(image, i, j)
        b = PixelIsBlack(mask, i, j)

        # xor
        r = Xor(a, b)

        if r:
          SetPixel(withMask, i, j, GetBlack())
        else:
          SetPixel(withMask, i, j, GetWhite())
      j = j + 1.0
    
    i = i + 1.0
  

  return withMask

def Xor(a, b):
  return a and  not b  or  not a  and b

def CreateMask(mask, version):

  size = QRVersionToModules(version)

  image = CreateImage(size, size, GetTransparent())

  black = True
  i = 0.0
  while i < size:
    j = 0.0
    while j < size:
      if mask == 0.0:
        black = (i + j) % 2.0 == 0.0
      elif mask == 1.0:
        black = i % 2.0 == 0.0
      elif mask == 2.0:
        black = j % 3.0 == 0.0
      elif mask == 3.0:
        black = (i + j) % 3.0 == 0.0
      elif mask == 4.0:
        black = (floor(i/2.0) + floor(j/3.0)) % 2.0 == 0.0
      elif mask == 5.0:
        black = (i*j) % 2.0 + (i*j) % 3.0 == 0.0
      elif mask == 6.0:
        black = ((i*j) % 2.0 + (i*j) % 3.0) % 2.0 == 0.0
      elif mask == 7.0:
        black = ((i*j) % 3.0 + (i + j) % 2.0) % 2.0 == 0.0

      if black:
        SetPixel(image, j, i, GetBlack())
      else:
        SetPixel(image, j, i, GetWhite())
      j = j + 1.0
    
    i = i + 1.0
  

  return image

def QRAddDummyFormatBits(image, version):

  size = QRVersionToModules(version)

  i = 0.0
  while i < 9.0:
    if i != 6.0:
      SetPixel(image, i, 8.0, GetWhite())
      SetPixel(image, 8.0, i, GetWhite())
    if i != 8.0:
      SetPixel(image, size - 1.0 - i, 8.0, GetWhite())
      SetPixel(image, 8.0, size - 1.0 - i, GetWhite())
    i = i + 1.0
  

  SetPixel(image, 8.0, size - 8.0, GetBlack())

def QRAddCodewords(image, version, cws):
        
  ll = CreateLinkedListCharacter()
  s = StringReference()
        
  i = 0.0
  while i < len(cws):
    CreateStringFromNumberWithCheck(cws[int(i)], 2.0, s)

    offset = 8.0 - len(s.string)
    j = 0.0
    while j < 8.0:
      if j < offset:
        LinkedListAddCharacter(ll, '0')
      else:
        LinkedListAddCharacter(ll, s.string[int(j - offset)])
      j = j + 1.0
    

    s.string = None
    i = i + 1.0
  

  bits = LinkedListCharactersToArray(ll)

  size = QRVersionToModules(version)
  x = size - 1.0
  y = size - 1.0
  d = True
  w = True
  bit = 0.0
  offset = 0.0
  i = 0.0
  while i < size**2.0 - size:
    if GetImagePixel(image, x - offset, y).a == 0.0:
      if bit < len(bits):
        b = bits[int(bit)]

        if b == '1':
          SetPixel(image, (x - offset), y, GetBlack())
        else:
          SetPixel(image, (x - offset), y, GetWhite())

        bit = bit + 1.0
      else:
        # Some symbols have nothing at the end.
        SetPixel(image, (x - offset), y, GetWhite())

    if d:
      if w:
        x = x - 1.0
      else:
        x = x + 1.0
        y = y - 1.0
    elif w:
      x = x - 1.0
    else:
      x = x + 1.0
      y = y + 1.0

    w =  not w 

    if i % (2.0*size) == 2.0*size - 1.0:
      if d:
        x = x - 2.0
        y = y + 1.0
        w = True
      else:
        x = x - 2.0
        y = y - 1.0
        w = True

      d =  not d 

    if x == 6.0:
      offset = 1.0
    i = i + 1.0
  

def QRAddTimingPattern(image, version):

  size = QRVersionToModules(version)

  black = True
  i = 0.0
  while i < size:
    if black:
      SetPixel(image, i, 6.0, GetBlack())
      SetPixel(image, 6.0, i, GetBlack())
    else:
      SetPixel(image, i, 6.0, GetWhite())
      SetPixel(image, 6.0, i, GetWhite())

    black =  not black 
    i = i + 1.0
  

def QRAddFinderPattern(image, version):

  size = QRVersionToModules(version)
  finderPattern = GetQRFinderPattern()
  DrawImageOnImage(image, finderPattern,  -1.0,  -1.0)
  DrawImageOnImage(image, finderPattern, size - 7.0 - 1.0,  -1.0)
  DrawImageOnImage(image, finderPattern,  -1.0, size - 7.0 - 1.0)

def GetQRFinderPattern():

  fp = CreateImage(9.0, 9.0, GetBlack())

  DrawRectangle1px(fp, 2.0, 2.0, 4.0, 4.0, GetWhite())
  DrawRectangle1px(fp, 0.0, 0.0, 8.0, 8.0, GetWhite())

  return fp

def QRQuietZoneSize():
  return 4.0

def QRVersionToModules(version):
  return 17.0 + 4.0*version

def QRNumericDataToSegment(data, version, bsReference, errorMessage):

  countReference = NumberReference()
  success = QRGetCountLength(version, "Numeric", countReference, errorMessage)

  if success:
    c = countReference.numberValue
    d = len(data)

    r = 0.0
    last = d % 3.0
    if last == 0.0:
      r = 0.0
    elif last == 1.0:
      r = 4.0
    elif last == 2.0:
      r = 7.0

    lengthReference = NumberReference()
    success = QRComputeNumberOfCodewords(len(data), version, "Numeric", lengthReference, errorMessage)
    if success:
      length = lengthReference.numberValue

      bs = arraysCreateString(length, '0')

      # Characters
      group =  [None]*int(3.0)
      nstr = StringReference()

      i = 0.0
      while i < floor(d/3.0):
        group[int(0.0)] = data[int(i*3.0 + 0.0)]
        group[int(1.0)] = data[int(i*3.0 + 1.0)]
        group[int(2.0)] = data[int(i*3.0 + 2.0)]

        n = CreateNumberFromDecimalString(group)
        CreateStringFromNumberWithCheck(n, 2.0, nstr)

        offset = 10.0 - len(nstr.string)
        j = 0.0
        while j < len(nstr.string):
          bs[int(4.0 + c + i*10.0 + offset + j)] = nstr.string[int(j)]
          j = j + 1.0
        
        i = i + 1.0
      

      if last == 1.0:
        group[int(0.0)] = '0'
        group[int(1.0)] = '0'
        group[int(2.0)] = data[int(len(data) - 1.0)]

      if last == 2.0:
        group[int(0.0)] = '0'
        group[int(1.0)] = data[int(len(data) - 2.0)]
        group[int(2.0)] = data[int(len(data) - 1.0)]

      if last == 1.0 or last == 2.0:
        n = CreateNumberFromDecimalString(group)
        CreateStringFromNumberWithCheck(n, 2.0, nstr)

        offset = r - len(nstr.string)
        j = 0.0
        while j < len(nstr.string):
          bs[int(len(bs) - r + offset + j)] = nstr.string[int(j)]
          j = j + 1.0
        

      # Character count
      CreateStringFromNumberWithCheck(d, 2.0, nstr)
      offset = 4.0 + c - len(nstr.string)
      j = 0.0
      while j < len(nstr.string):
        bs[int(offset + j)] = nstr.string[int(j)]
        j = j + 1.0
      

      # Mode
      mode = QRNumericModeIndicator()
      j = 0.0
      while j < 4.0:
        bs[int(j)] = mode[int(j)]
        j = j + 1.0
      

      bsReference.string = bs

  return success

def QRGetCountLength(version, modeName, cReference, errorMessage):

  success = True
  c = 0.0

  if arraysStringsEqual(modeName, "Numeric"):
    if version >= 1.0 and version <= 9.0:
      c = 10.0
    elif version >= 10.0 and version <= 26.0:
      c = 12.0
    elif version >= 27.0 and version <= 40.0:
      c = 14.0
    else:
      success = False
      errorMessage.string = "Invalid version number."
  elif arraysStringsEqual(modeName, "Alphanumeric"):
    if version >= 1.0 and version <= 9.0:
      c = 9.0
    elif version >= 10.0 and version <= 26.0:
      c = 11.0
    elif version >= 27.0 and version <= 40.0:
      c = 13.0
    else:
      success = False
      errorMessage.string = "Invalid version number."
  elif arraysStringsEqual(modeName, "8-bit Byte"):
    if version >= 1.0 and version <= 9.0:
      c = 8.0
    elif version >= 10.0 and version <= 26.0:
      c = 16.0
    elif version >= 27.0 and version <= 40.0:
      c = 16.0
    else:
      success = False
      errorMessage.string = "Invalid version number."
  else:
    success = False
    errorMessage.string = "Invalid mode name."

  if success:
    cReference.numberValue = c

  return success

def QRNumericModeIndicator():
  return "0001"

def QRAlphanumericModeIndicator():
  return "0010"

def QRTerminatorModeIndicator():
  return "0000"

def QR8BitByteModeIndicator():
  return "0100"

def QRKanjiModeIndicator():
  return "1000"

def QRAlphanumericDataToSegment(data, version, bsReference, errorMessage):

  countReference = NumberReference()
  success = QRGetCountLength(version, "Alphanumeric", countReference, errorMessage)

  if success:
    c = countReference.numberValue
    d = len(data)

    lengthReference = NumberReference()
    success = QRComputeNumberOfCodewords(len(data), version, "Alphanumeric", lengthReference, errorMessage)

    if success:
      length = lengthReference.numberValue

      bs = arraysCreateString(length, '0')

      # Characters
      nstr = StringReference()

      i = 0.0
      while i < floor(d/2.0):
        c0 = QRAlphanumericToCode(data[int(i*2.0 + 0.0)])
        c1 = QRAlphanumericToCode(data[int(i*2.0 + 1.0)])

        n = c0*45.0 + c1

        CreateStringFromNumberWithCheck(n, 2.0, nstr)

        offset = 11.0 - len(nstr.string)
        j = 0.0
        while j < len(nstr.string):
          bs[int(4.0 + c + i*11.0 + offset + j)] = nstr.string[int(j)]
          j = j + 1.0
        
        i = i + 1.0
      

      if d % 2.0 == 1.0:
        n = QRAlphanumericToCode(data[int(len(data) - 1.0)])

        CreateStringFromNumberWithCheck(n, 2.0, nstr)

        offset = 6.0 - len(nstr.string)
        j = 0.0
        while j < len(nstr.string):
          bs[int(len(bs) - 6.0 + offset + j)] = nstr.string[int(j)]
          j = j + 1.0
        

      # Character count
      CreateStringFromNumberWithCheck(d, 2.0, nstr)
      offset = 4.0 + c - len(nstr.string)
      j = 0.0
      while j < len(nstr.string):
        bs[int(offset + j)] = nstr.string[int(j)]
        j = j + 1.0
      

      # Mode
      mode = QRAlphanumericModeIndicator()
      j = 0.0
      while j < 4.0:
        bs[int(j)] = mode[int(j)]
        j = j + 1.0
      

      bsReference.string = bs

  return success

def QRSegmentsToCodeWords(data, version, errorCorrectionLevelCode):

  symbolBitsSpec = GetQRSymbolLengthsForVersions()

  errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode)

  symbolBits = symbolBitsSpec[int((version - 1.0)*4.0 + errorCorrectionLevelNumber)]

  terminatorLength = min(symbolBits - len(data),4.0)

  d = len(data) + terminatorLength
  n = ceil(d/8.0)
  padding = n*8.0 - d

  codewords =  [None]*int(floor(symbolBits/8.0))

  str =  [None]*int(8.0)
  nref = NumberReference()
  errorMessage = StringReference()

  cw = 0.0
  while cw < floor(len(data)/8.0):
    str[int(0.0)] = data[int(cw*8.0 + 0.0)]
    str[int(1.0)] = data[int(cw*8.0 + 1.0)]
    str[int(2.0)] = data[int(cw*8.0 + 2.0)]
    str[int(3.0)] = data[int(cw*8.0 + 3.0)]
    str[int(4.0)] = data[int(cw*8.0 + 4.0)]
    str[int(5.0)] = data[int(cw*8.0 + 5.0)]
    str[int(6.0)] = data[int(cw*8.0 + 6.0)]
    str[int(7.0)] = data[int(cw*8.0 + 7.0)]

    CreateNumberFromStringWithCheck(str, 2.0, nref, errorMessage)

    codewords[int(cw)] = nref.numberValue
    cw = cw + 1.0
  

  # Remaining data, terminator and bit-padding.
  r = len(data) % 8.0
  if r != 0.0:
    j = 0.0
    while j < 8.0:
      if j < r:
        str[int(j)] = data[int(len(data) - r + j)]
      else:
        str[int(j)] = '0'
      j = j + 1.0
    

    CreateNumberFromStringWithCheck(str, 2.0, nref, errorMessage)

    codewords[int(cw)] = nref.numberValue
    cw = cw + 1.0

  if r == 0.0 and terminatorLength + padding == 8.0:
    codewords[int(cw)] = 0.0
    cw = cw + 1.0
  elif 8.0 - r >= terminatorLength + padding:
    pass
  else:
    codewords[int(cw)] = 0.0
    cw = cw + 1.0

  # Byte Padding
  padSymbol = True
  while cw < len(codewords):
    if padSymbol:
      codewords[int(cw)] = 236.0
    else:
      codewords[int(cw)] = 17.0
    padSymbol =  not padSymbol 
    cw = cw + 1.0
  

  return codewords

def GetQRSymbolLengthsForVersions():
  return StringToNumberArray("152, 128, 104, 72, 272, 224, 176, 128, 440, 352, 272, 208, 640, 512, 384, 288, 864, 688, 496, 368, 1088, 864, 608, 480, 1248, 992, 704, 528, 1552, 1232, 880, 688, 1856, 1456, 1056, 800, 2192, 1728, 1232, 976, 2592, 2032, 1440, 1120, 2960, 2320, 1648, 1264, 3424, 2672, 1952, 1440, 3688, 2920, 2088, 1576, 4184, 3320, 2360, 1784, 4712, 3624, 2600, 2024, 5176, 4056, 2936, 2264, 5768, 4504, 3176, 2504, 6360, 5016, 3560, 2728, 6888, 5352, 3880, 3080, 7456, 5712, 4096, 3248, 8048, 6256, 4544, 3536, 8752, 6880, 4912, 3712, 9392, 7312, 5312, 4112, 10208, 8000, 5744, 4304, 10960, 8496, 6032, 4768, 11744, 9024, 6464, 5024, 12248, 9544, 6968, 5288, 13048, 10136, 7288, 5608, 13880, 10984, 7880, 5960, 14744, 11640, 8264, 6344, 15640, 12328, 8920, 6760, 16568, 13048, 9368, 7208, 17528, 13800, 9848, 7688, 18448, 14496, 10288, 7888, 19472, 15312, 10832, 8432, 20528, 15936, 11408, 8768, 21616, 16816, 12016, 9136, 22496, 17728, 12656, 9776, 23648, 18672, 13328, 10208")

def QREccLetterToNumber(errorCorrectionLevelCode):

  errorCorrectionLevelNumber = 0.0

  if errorCorrectionLevelCode == 'L':
    errorCorrectionLevelNumber = 0.0
  elif errorCorrectionLevelCode == 'M':
    errorCorrectionLevelNumber = 1.0
  elif errorCorrectionLevelCode == 'Q':
    errorCorrectionLevelNumber = 2.0
  elif errorCorrectionLevelCode == 'H':
    errorCorrectionLevelNumber = 3.0
  return errorCorrectionLevelNumber

def ErGyldigOrgNummerString(orgnummer):

  o =  [None]*int(9.0)

  gyldig = True

  if len(orgnummer) == 9.0:

    i = 0.0
    while i < 9.0:
      if cIsNumber(orgnummer[int(i)]):
        o[int(i)] = cCharacterToDecimalDigit(orgnummer[int(i)])
      else:
        gyldig = False
      i = i + 1.0
    

    if gyldig:
      gyldig = ErGyldigOrgNummer(o)
  else:
    gyldig = False

  return gyldig

def ErGyldigOrgNummer(o):

  if len(o) == 9.0:
    sum = o[int(0.0)]*3.0 + o[int(1.0)]*2.0 + o[int(2.0)]*7.0 + o[int(3.0)]*6.0 + o[int(4.0)]*5.0 + o[int(5.0)]*4.0 + o[int(6.0)]*3.0 + o[int(7.0)]*2.0
    rest = sum % 11.0
    if rest == 0.0:
      kontrollsiffer = 0.0
    else:
      kontrollsiffer = 11.0 - rest

    gyldig = rest != 1.0 and kontrollsiffer == o[int(8.0)]
  else:
    gyldig = False

  return gyldig

def IsValidNorwegianPersonalIdentificationNumber(fnummer, message):

  valid = len(fnummer) == 11.0
  if valid:
    i = 0.0
    while i < len(fnummer):
      if cIsNumber(fnummer[int(i)]):
        pass
      else:
        valid = False
      i = i + 1.0
    

    if valid:
      d1 = cCharacterToDecimalDigit(fnummer[int(0.0)])
      d2 = cCharacterToDecimalDigit(fnummer[int(1.0)])
      d3 = cCharacterToDecimalDigit(fnummer[int(2.0)])
      d4 = cCharacterToDecimalDigit(fnummer[int(3.0)])
      d5 = cCharacterToDecimalDigit(fnummer[int(4.0)])
      d6 = cCharacterToDecimalDigit(fnummer[int(5.0)])
      d7 = cCharacterToDecimalDigit(fnummer[int(6.0)])
      d8 = cCharacterToDecimalDigit(fnummer[int(7.0)])
      d9 = cCharacterToDecimalDigit(fnummer[int(8.0)])
      d10 = cCharacterToDecimalDigit(fnummer[int(9.0)])
      d11 = cCharacterToDecimalDigit(fnummer[int(10.0)])

      dateRef = DateReference()
      valid = GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message)

      if valid:
        valid = IsValidDate(dateRef.date, message)
        if valid:
          k1 = d1*3.0 + d2*7.0 + d3*6.0 + d4*1.0 + d5*8.0 + d6*9.0 + d7*4.0 + d8*5.0 + d9*2.0
          k1 = k1 % 11.0
          if k1 != 0.0:
            k1 = 11.0 - k1
          if k1 == 10.0:
            valid = False
            message.string = "Control digit 1 is 10, which is invalid."

          if valid:
            k2 = d1*5.0 + d2*4.0 + d3*3.0 + d4*2.0 + d5*7.0 + d6*6.0 + d7*5.0 + d8*4.0 + d9*3.0 + k1*2.0
            k2 = k2 % 11.0
            if k2 != 0.0:
              k2 = 11.0 - k2
            if k2 == 10.0:
              valid = False
              message.string = "Control digit 2 is 10, which is invalid."

            if valid:
              if k1 == d10:
                if k2 == d11:
                  valid = True
                else:
                  valid = False
                  message.string = "Check of control digit 2 failed."
              else:
                valid = False
                message.string = "Check of control digit 1 failed."
        else:
          message.string = "The date is not a valid date."
    else:
      message.string = "Each character must be a decimal digit."
  else:
    message.string = "Must be exactly 11 digits long."

  return valid

def GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message):

  dateRef.date = Date()

  success = len(fnummer) == 11.0
  if success:
    i = 0.0
    while i < len(fnummer):
      if cIsNumber(fnummer[int(i)]):
        pass
      else:
        success = False
      i = i + 1.0
    

    if success:
      d1 = cCharacterToDecimalDigit(fnummer[int(0.0)])
      d2 = cCharacterToDecimalDigit(fnummer[int(1.0)])
      d3 = cCharacterToDecimalDigit(fnummer[int(2.0)])
      d4 = cCharacterToDecimalDigit(fnummer[int(3.0)])
      d5 = cCharacterToDecimalDigit(fnummer[int(4.0)])
      d6 = cCharacterToDecimalDigit(fnummer[int(5.0)])
      d7 = cCharacterToDecimalDigit(fnummer[int(6.0)])
      d8 = cCharacterToDecimalDigit(fnummer[int(7.0)])
      d9 = cCharacterToDecimalDigit(fnummer[int(8.0)])

      # Individnummer
      individnummer = d7*100.0 + d8*10.0 + d9

      # Make date
      day = d1*10.0 + d2
      month = d3*10.0 + d4
      year = d5*10.0 + d6

      if individnummer >= 0.0 and individnummer <= 499.0:
        year = year + 1900.0
      elif individnummer >= 500.0 and individnummer <= 749.0 and year >= 54.0 and year <= 99.0:
        year = year + 1800.0
      elif individnummer >= 900.0 and individnummer <= 999.0 and year >= 40.0 and year <= 99.0:
        year = year + 1900.0
      elif individnummer >= 500.0 and individnummer <= 999.0 and year >= 0.0 and year <= 39.0:
        year = year + 2000.0
      else:
        success = False
        message.string = "Invalid combination of individnummer and year."

      if success:
        dateRef.date.year = year
        dateRef.date.month = month
        dateRef.date.day = day
    else:
      message.string = "Each character must be a decimal digit."
  else:
    message.string = "Must be exactly 11 digits long."

  return success

def HentKommunenavnFraNummer(kommunenummer, kommunenavnReference, errorMessages):

  kommunenavn = HentKommunenavn()

  nummer = HentGyldigeKommunenummer()
  success = False

  nr = 0.0
  while nr < len(nummer) and  not success :
    if arraysStringsEqual(nummer[int(nr)].string, kommunenummer):
      success = True
      kommunenavnReference.string = kommunenavn[int(nr)].string
    nr = nr + 1.0
  

  if  not success :
    errorMessages.string = "Kommunenummer er ikke gyldig."

  return success

def ErGyldigKommunenummer(kommunenummer):

  gyldig = False

  if len(kommunenummer) == 4.0:
    nummer = HentGyldigeKommunenummer()

    i = 0.0
    while i < len(nummer) and  not gyldig :
      if arraysStringsEqual(nummer[int(i)].string, kommunenummer):
        gyldig = True
      i = i + 1.0
    

  return gyldig

def HentKommunenavn():

  kommunenavnliste = "\u00c5fjord, Agdenes, \u00c5l, \u00c5lesund, Alstahaug, Alta, Alvdal, \u00c5mli, \u00c5mot, And\u00f8y, \u00c5rdal, Aremark, Arendal, \u00c5s, \u00c5seral, Asker, Askim, Ask\u00f8y, Askvoll, \u00c5snes, Audnedal, Aukra, Aure, Aurland, Aurskog-H\u00f8land, Austevoll, Austrheim, Aver\u00f8y, B\u00e6rum, Balestrand, Ballangen, Balsfjord, Bamble, Bardu, B\u00e5tsfjord, Beiarn, Berg, Bergen, Berlev\u00e5g, Bindal, Birkenes, Bjerkreim, Bjugn, B\u00f8 i Nordland , B\u00f8 i Telemark, Bod\u00f8, Bokn, B\u00f8mlo, Bremanger, Br\u00f8nn\u00f8y, Bygland, Bykle, Deatnu - Tana, Divtasvuodna - Tysfjord, D\u00f8nna, Dovre, Drammen, Drangedal, Dyr\u00f8y, Eid, Eide, Eidfjord, Eidsberg, Eidskog, Eidsvoll, Eigersund, Elverum, Enebakk, Engerdal, Etne, Etnedal, Evenes, Evje og Hornnes, F\u00e6rder, Farsund, Fauske - Fuossko, Fedje, Fet, Finn\u00f8y, Fitjar, Fjaler, Fjell, Fl\u00e5, Flakstad, Flatanger, Flekkefjord, Flesberg, Flora, Folldal, F\u00f8rde, Forsand, Fosnes, Fr\u00e6na, Fredrikstad, Frogn, Froland, Frosta, Fr\u00f8ya, Fusa, Fyresdal, G\u00e1ivuotna - K\u00e5fjord - Kaivuono, Gamvik, Gaular, Gausdal, Gildesk\u00e5l, Giske, Gjemnes, Gjerdrum, Gjerstad, Gjesdal, Gj\u00f8vik, Gloppen, Gol, Gran, Grane, Granvin, Gratangen, Grimstad, Grong, Grue, Gulen, Guovdageaidnu - Kautokeino, H\u00e5, Hadsel, H\u00e6gebostad, Halden, Halsa, Hamar, Hamar\u00f8y - H\u00e1bmer, Hammerfest, Haram, Hareid, Harstad - H\u00e1rstt\u00e1k, Hasvik, Hattfjelldal, Haugesund, Hemne, Hemnes, Hemsedal, Her\u00f8y i  M\u00f8re og Romsdal, Her\u00f8y i Nordland, Hitra, Hjartdal, Hjelmeland, Hob\u00f8l, Hol, Hole, Holmestrand, Holt\u00e5len, Hornindal, Horten, H\u00f8yanger, H\u00f8ylandet, Hurdal, Hurum, Hvaler, Hyllestad, Ibestad, Inder\u00f8y, Indre Fosen, Iveland, Jevnaker, J\u00f8lster, Jondal, K\u00e1r\u00e1\u0161johka - Karasjok, Karls\u00f8y, Karm\u00f8y, Kl\u00e6bu, Klepp, Kongsberg, Kongsvinger, Krager\u00f8, Kristiansand, Kristiansund, Kr\u00f8dsherad, Kv\u00e6fjord, Kv\u00e6nangen, Kvalsund, Kvam, Kvinesdal, Kvinnherad, Kviteseid, Kvits\u00f8y, L\u00e6rdal, Larvik, Lebesby, Leikanger, Leirfjord, Leka, Lenvik, Lesja, Levanger, Lier, Lierne, Lillehammer, Lillesand, Lind\u00e5s, Lindesnes, Loab\u00e1k - Lavangen, L\u00f8dingen, Lom, Loppa, L\u00f8renskog, L\u00f8ten, Lund, Lunner, Lur\u00f8y, Luster, Lyngdal, Lyngen, M\u00e5lselv, Malvik, Mandal, Marker, Marnardal, Masfjorden, M\u00e5s\u00f8y, Meland, Meldal, Melhus, Mel\u00f8y, Mer\u00e5ker, Midsund, Midtre Gauldal, Modalen, Modum, Molde, Moskenes, Moss, N\u00e6r\u00f8y, Namdalseid, Namsos, Namsskogan, Nannestad, Narvik, Naustdal, Nedre Eiker, Nes i Akershus, Nes i Buskerud, Nesna, Nesodden, Nesset, Nissedal, Nittedal, Nome, Nord-Aurdal, Norddal, Nord-Fron, Nordkapp, Nord-Odal, Nordre Land, Nordreisa - R\u00e1isa - Raisi, Nore og Uvdal, Notodden, Odda, \u00d8ksnes, Oppdal, Oppeg\u00e5rd, Orkdal, \u00d8rland, \u00d8rskog, \u00d8rsta, Os i Hedmark, Os i Hordaland, Osen, Oslo, Oster\u00f8y, \u00d8stre Toten, Overhalla, \u00d8vre Eiker, \u00d8yer, \u00d8ygarden, \u00d8ystre Slidre, Porsanger - Pors\u00e1\u014bgu - Porsanki, Porsgrunn, Raarvikhe - R\u00f8yrvik, R\u00e5de, Rad\u00f8y, R\u00e6lingen, Rakkestad, Rana, Randaberg, Rauma, Re, Rendalen, Rennebu, Rennes\u00f8y, Rindal, Ringebu, Ringerike, Ringsaker, Ris\u00f8r, Roan, R\u00f8d\u00f8y, Rollag, R\u00f8mskog, R\u00f8ros, R\u00f8st, R\u00f8yken, Rygge, Salangen, Saltdal, Samnanger, Sande i M\u00f8re og Romsdal, Sande i Vestfold, Sandefjord, Sandnes, Sand\u00f8y, Sarpsborg, Sauda, Sauherad, Sel, Selbu, Selje, Seljord, Sigdal, Siljan, Sirdal, Sk\u00e5nland, Skaun, Skedsmo, Ski, Skien, Skiptvet, Skj\u00e5k, Skjerv\u00f8y, Skodje, Sm\u00f8la, Sn\u00e5ase - Sn\u00e5sa, Snillfjord, Sogndal, S\u00f8gne, Sokndal, Sola, Solund, S\u00f8mna, S\u00f8ndre Land, Songdalen, S\u00f8r-Aurdal, S\u00f8rfold, S\u00f8r-Fron, S\u00f8r-Odal, S\u00f8rreisa, Sortland - Suort\u00e1, S\u00f8rum, S\u00f8r-Varanger, Spydeberg, Stange, Stavanger, Steigen, Steinkjer, Stj\u00f8rdal, Stord, Stordal, Stor-Elvdal, Storfjord - Omasvuotna - Omasvuono, Strand, Stranda, Stryn, Sula, Suldal, Sund, Sunndal, Surnadal, Sveio, Svelvik, Sykkylven, Time, Tingvoll, Tinn, Tjeldsund, Tokke, Tolga, T\u00f8nsberg, Torsken, Tr\u00e6na, Tran\u00f8y, Tr\u00f8gstad, Troms\u00f8, Trondheim , Trysil, Tvedestrand, Tydal, Tynset, Tysnes, Tysv\u00e6r, Ullensaker, Ullensvang, Ulstein, Ulvik, Unj\u00e1rga - Nesseby, Utsira, Vads\u00f8, V\u00e6r\u00f8y, V\u00e5g\u00e5, V\u00e5gan, V\u00e5gs\u00f8y, Vaksdal, V\u00e5ler i Hedmark, V\u00e5ler i \u00d8stfold, Valle, Vang, Vanylven, Vard\u00f8, Vefsn, Vega, Veg\u00e5rshei, Vennesla, Verdal, Verran, Vestby, Vestnes, Vestre Slidre, Vestre Toten, Vestv\u00e5g\u00f8y, Vevelstad, Vik, Vikna, Vindafjord, Vinje, Volda, Voss, "

  kommunenavn = strSplitByString(kommunenavnliste, ", ")

  return kommunenavn

def HentGyldigeKommunenummer():

  kommunenummerliste = "5018, 5016, 0619, 1504, 1820, 2012, 0438, 0929, 0429, 1871, 1424, 0118, 0906, 0214, 1026, 0220, 0124, 1247, 1428, 0425, 1027, 1547, 1576, 1421, 0221, 1244, 1264, 1554, 0219, 1418, 1854, 1933, 0814, 1922, 2028, 1839, 1929, 1201, 2024, 1811, 0928, 1114, 5017, 1867, 0821, 1804, 1145, 1219, 1438, 1813, 0938, 0941, 2025, 1850, 1827, 0511, 0602, 0817, 1926, 1443, 1551, 1232, 0125, 0420, 0237, 1101, 0427, 0229, 0434, 1211, 0541, 1853, 0937, 0729, 1003, 1841, 1265, 0227, 1141, 1222, 1429, 1246, 0615, 1859, 5049, 1004, 0631, 1401, 0439, 1432, 1129, 5048, 1548, 0106, 0215, 0919, 5036, 5014, 1241, 0831, 1940, 2023, 1430, 0522, 1838, 1532, 1557, 0234, 0911, 1122, 0502, 1445, 0617, 0534, 1825, 1234, 1919, 0904, 5045, 0423, 1411, 2011, 1119, 1866, 1034, 0101, 1571, 0403, 1849, 2004, 1534, 1517, 1903, 2015, 1826, 1106, 5011, 1832, 0618, 1515, 1818, 5013, 0827, 1133, 0138, 0620, 0612, 0715, 5026, 1444, 0701, 1416, 5046, 0239, 0628, 0111, 1413, 1917, 5053, 5054, 0935, 0532, 1431, 1227, 2021, 1936, 1149, 5030, 1120, 0604, 0402, 0815, 1001, 1505, 0622, 1911, 1943, 2017, 1238, 1037, 1224, 0829, 1144, 1422, 0712, 2022, 1419, 1822, 5052, 1931, 0512, 5037, 0626, 5042, 0501, 0926, 1263, 1029, 1920, 1851, 0514, 2014, 0230, 0415, 1112, 0533, 1834, 1426, 1032, 1938, 1924, 5031, 1002, 0119, 1021, 1266, 2018, 1256, 5023, 5028, 1837, 5034, 1545, 5027, 1252, 0623, 1502, 1874, 0104, 5051, 5040, 5005, 5044, 0238, 1805, 1433, 0625, 0236, 0616, 1828, 0216, 1543, 0830, 0233, 0819, 0542, 1524, 0516, 2019, 0418, 0538, 1942, 0633, 0807, 1228, 1868, 5021, 0217, 5024, 5015, 1523, 1520, 0441, 1243, 5020, 0301, 1253, 0528, 5047, 0624, 0521, 1259, 0544, 2020, 0805, 5043, 0135, 1260, 0228, 0128, 1833, 1127, 1539, 0716, 0432, 5022, 1142, 5061, 0520, 0605, 0412, 0901, 5019, 1836, 0632, 0121, 5025, 1856, 0627, 0136, 1923, 1840, 1242, 1514, 0713, 0710, 1102, 1546, 0105, 1135, 0822, 0517, 5032, 1441, 0828, 0621, 0811, 1046, 1913, 5029, 0231, 0213, 0806, 0127, 0513, 1941, 1529, 1573, 5041, 5012, 1420, 1018, 1111, 1124, 1412, 1812, 0536, 1017, 0540, 1845, 0519, 0419, 1925, 1870, 0226, 2030, 0123, 0417, 1103, 1848, 5004, 5035, 1221, 1526, 0430, 1939, 1130, 1525, 1449, 1531, 1134, 1245, 1563, 1566, 1216, 0711, 1528, 1121, 1560, 0826, 1852, 0833, 0436, 0704, 1928, 1835, 1927, 0122, 1902, 5001, 0428, 0914, 5033, 0437, 1223, 1146, 0235, 1231, 1516, 1233, 2027, 1151, 2003, 1857, 0515, 1865, 1439, 1251, 0426, 0137, 0940, 0545, 1511, 2002, 1824, 1815, 0912, 1014, 5038, 5039, 0211, 1535, 0543, 0529, 1860, 1816, 1417, 5050, 1160, 0834, 1519, 1235"

  kommunenummer = strSplitByString(kommunenummerliste, ", ")

  return kommunenummer

def HentPoststedListe():

  poststeder = "OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, OSLO, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, SANDVIKA, HASLUM, SANDVIKA, FORNEBU, JAR, RUD, H\u00d8VIKODDEN, SLEPENDEN, V\u00d8YENENGA, V\u00d8YENENGA, EIKSMARKA, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, STABEKK, H\u00d8VIK, H\u00d8VIK, LYSAKER, LYSAKER, LYSAKER, LYSAKER, H\u00d8VIK, LOMMEDALEN, FORNEBU, FORNEBU, \u00d8STER\u00c5S, KOLS\u00c5S, RYKKINN, SNAR\u00d8YA, SANDVIKA, SANDVIKA, SANDVIKA, V\u00d8YENENGA, SKUI, SLEPENDEN, GJETTUM, HASLUM, GJETTUM, RYKKINN, RYKKINN, LOMMEDALEN, RUD, KOLS\u00c5S, B\u00c6RUMS VERK, B\u00c6RUMS VERK, BEKKESTUA, BEKKESTUA, JAR, EIKSMARKA, FORNEBU, \u00d8STER\u00c5S, HOSLE, H\u00d8VIK, FORNEBU, BLOMMENHOLM, LYSAKER, SNAR\u00d8YA, STABEKK, STABEKK, ASKER, ASKER, ASKER, BILLINGSTAD, BILLINGSTAD, BILLINGSTAD, NESBRU, NESBRU, HEGGEDAL, VETTRE, ASKER, ASKER, ASKER, ASKER, ASKER, BORGEN, HEGGEDAL, VOLLEN, VOLLEN, VETTRE, VOLLEN, NESBRU, HVALSTAD, BILLINGSTAD, NES\u00d8YA, ASKER, SKI, SKI, SKI, LANGHUS, SIGGERUD, LANGHUS, SKI, VINTERBRO, KR\u00c5KSTAD, SKOTBU, KOLBOTN, KOLBOTN, SOFIEMYR, T\u00c5RN\u00c5SEN, TROLL\u00c5SEN, OPPEG\u00c5RD, OPPEG\u00c5RD, SOFIEMYR, KOLBOTN, OPPEG\u00c5RD, SVARTSKOG, TROLL\u00c5SEN, SIGGERUD, VINTERBRO, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, \u00c5S, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, DR\u00d8BAK, NESODDTANGEN, NESODDTANGEN, NESODDTANGEN, BJ\u00d8RNEMYR, FAGERSTRAND, NORDRE FROGN, NESODDTANGEN, FAGERSTRAND, FJELLSTRAND, NESODDEN, STR\u00d8MMEN, STR\u00d8MMEN, STR\u00d8MMEN, FINSTADJORDET, RASTA, L\u00d8RENSKOG, L\u00d8RENSKOG, FJELLHAMAR, L\u00d8RENSKOG, L\u00d8RENSKOG, FINSTADJORDET, RASTA, FJELLHAMAR, L\u00d8RENSKOG, KURLAND, SLATTUM, HAGAN, NITTEDAL, HAGAN, HAKADAL, HAKADAL, NITTEDAL, HAKADAL, HAKADAL, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, MOSS, VESTBY, VESTBY, HVITSTEN, H\u00d8LEN, SON, SON, LARKOLLEN, LARKOLLEN, DILLING, RYGGE, RYGGE, RYGGE, SPERREBOTN, V\u00c5LER I \u00d8STFOLD, SVINNDAL, V\u00c5LER I \u00d8STFOLD, MOSS, MOSS, MOSS, MOSS, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, FREDRIKSTAD, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, GRESSVIK, MANSTAD, MANSTAD, ENGELSVIKEN, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, GAMLE FREDRIKSTAD, R\u00c5DE, R\u00c5DE, SALTNES, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, SELLEBAKK, TORP, TORP, TORP, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, ROLVS\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, KR\u00c5KER\u00d8Y, SKJ\u00c6RHALDEN, SKJ\u00c6RHALDEN, VESTER\u00d8Y, VESTER\u00d8Y, HERF\u00d8L, NEDG\u00c5RDEN, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, GR\u00c5LUM, GR\u00c5LUM, GR\u00c5LUM, YVEN, GRE\u00c5KER, GRE\u00c5KER, GRE\u00c5KER, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, SARPSBORG, ISE, HAFSLUNDS\u00d8Y, HAFSLUNDS\u00d8Y, VARTEIG, BORGENHAUGEN, BORGENHAUGEN, BORGENHAUGEN, KLAVESTADHAUGEN, KLAVESTADHAUGEN, SKJEBERG, SKJEBERG, SKJEBERG, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, HALDEN, BERG I \u00d8STFOLD, TISTEDAL, TISTEDAL, TISTEDAL, TISTEDAL, SPONVIKA, KORNSJ\u00d8, AREMARK, AREMARK, ASKIM, ASKIM, ASKIM, SPYDEBERG, TOMTER, SKIPTVET, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, ASKIM, SKIPTVET, SPYDEBERG, SPYDEBERG, KNAPSTAD, TOMTER, HOB\u00d8L, ASKIM, ASKIM, ASKIM, ASKIM, MYSEN, MYSEN, MYSEN, SLITU, TR\u00d8GSTAD, TR\u00d8GSTAD, B\u00c5STAD, B\u00c5STAD, \u00d8RJE, \u00d8RJE, OTTEID, H\u00c6RLAND, EIDSBERG, RAKKESTAD, RAKKESTAD, DEGERNES, DEGERNES, RAKKESTAD, FETSUND, FETSUND, GAN, ENEBAKKNESET, FLATEBY, ENEBAKK, YTRE ENEBAKK, FLATEBY, YTRE ENEBAKK, S\u00d8RUMSAND, S\u00d8RUMSAND, S\u00d8RUM, S\u00d8RUM, BLAKER, BLAKER, R\u00c5N\u00c5SFOSS, AULI, AULI, AURSKOG, AURSKOG, BJ\u00d8RKELANGEN, BJ\u00d8RKELANGEN, R\u00d8MSKOG, SETSKOG, L\u00d8KEN, L\u00d8KEN, FOSSER, HEMNES, HEMNES, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, LILLESTR\u00d8M, R\u00c6LINGEN, L\u00d8VENSTAD, KJELLER, FJERDINGBY, NORDBY, STR\u00d8MMEN, STR\u00d8MMEN, LILLESTR\u00d8M, SKJETTEN, BLYSTADLIA, LEIRSUND, FROGNER, FROGNER, L\u00d8VENSTAD, SKEDSMOKORSET, SKEDSMOKORSET, SKEDSMOKORSET, GJERDRUM, SKEDSMOKORSET, GJERDRUM, FJERDINGBY, SKJETTEN, KJELLER, LILLESTR\u00d8M, R\u00c6LINGEN, NANNESTAD, NANNESTAD, MAURA, \u00c5SGREINA, HOLTER, HOLTER, MAURA, KL\u00d8FTA, KL\u00d8FTA, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, MOGREINA, NORDKISA, ALGARHEIM, JESSHEIM, SESSVOLLMOEN, GARDERMOEN, GARDERMOEN, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, JESSHEIM, R\u00c5HOLT, R\u00c5HOLT, DAL, B\u00d8N, EIDSVOLL VERK, DAL, EIDSVOLL, EIDSVOLL, HURDAL, HURDAL, MINNESUND, FEIRING, MINNESUND, SKARNES, SKARNES, SL\u00c5STAD, DISEN\u00c5, SANDER, SAGSTUA, SAGSTUA, BRUVOLL, KNAPPER, GARDVIK, GARDVIK, AUSTVATN, \u00c5RNES, \u00c5RNES, VORMSUND, VORMSUND, BR\u00c5RUD, SKOGBYGDA, SKOGBYGDA, HVAM, OPPAKER, HVAM, FENSTAD, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, GRANLI, KONGSVINGER, KONGSVINGER, KONGSVINGER, KONGSVINGER, ROVERUD, ROVERUD, HOKK\u00c5SEN, LUNDERS\u00c6TER, BRANDVAL, \u00c5BOGEN, GALTERUD, AUSTMARKA, KONGSVINGER, KONGSVINGER, AUSTMARKA, SKOTTERUD, SKOTTERUD, TOB\u00d8L, VESTMARKA, MATRAND, MAGNOR, MAGNOR, GRUE FINNSKOG, GRUE FINNSKOG, KIRKEN\u00c6R, KIRKEN\u00c6R, GRINDER, NAMN\u00c5, ARNEBERG, FLISA, FLISA, GJES\u00c5SEN, \u00c5SNES FINNSKOG, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, OTTESTAD, OTTESTAD, OTTESTAD, HAMAR, HAMAR, HAMAR, HAMAR, HAMAR, FURNES, HAMAR, RIDABU, INGEBERG, VANG P\u00c5 HEDMARKEN, HAMAR, HAMAR, FURNES, RIDABU, VANG P\u00c5 HEDMARKEN, VALLSET, VALLSET, \u00c5SVANG, ROMEDAL, ROMEDAL, STANGE, STANGE, TANGEN, ESPA, TANGEN, L\u00d8TEN, L\u00d8TEN, ILSENG, \u00c5DALSBRUK, ILSENG, NES P\u00c5 HEDMARKEN, NES P\u00c5 HEDMARKEN, STAVSJ\u00d8, GAUPEN, RUDSH\u00d8GDA, RUDSH\u00d8GDA, N\u00c6ROSET, \u00c5SMARKA, BR\u00d8TTUM, BR\u00d8TTUM, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, BRUMUNDDAL, MOELV, MOELV, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, ELVERUM, HERNES, ELVERUM, S\u00d8RSKOGBYGDA, ELVERUM, ELVERUM, HERADSBYGD, J\u00d8MNA, ELVERUM, ELVERUM, ELVERUM, TRYSIL, TRYSIL, NYBERGSUND, \u00d8STBY, \u00d8STBY, LJ\u00d8RDALEN, LJ\u00d8RDALEN, PLASSEN, S\u00d8RE OSEN, T\u00d8RBERGET, JORDET, SLETT\u00c5S, BRASKEREIDFOSS, BRASKEREIDFOSS, V\u00c5LER I SOL\u00d8R, HASLEMOEN, GRAVBERGET, V\u00c5LER I SOL\u00d8R, ENGERDAL, ENGERDAL, HERADSBYGD, DREVSJ\u00d8, DREVSJ\u00d8, ELG\u00c5, S\u00d8RE OSEN, S\u00d8M\u00c5DALEN, RENA, RENA, OSEN, OSEN, ATNA, SOLLIA, HANESTAD, KOPPANG, KOPPANG, RENDALEN, RENDALEN, RENDALEN, RENDALEN, RENDALEN, TYNSET, TYNSET, TYLLDALEN, KVIKNE, KVIKNE, TOLGA, TOLGA, VINGELEN, \u00d8VERSJ\u00d8DALEN, OS I \u00d8STERDALEN, OS I \u00d8STERDALEN, DALSBYGDA, TUFSINGDALEN, ALVDAL, ALVDAL, FOLLDAL, FOLLDAL, GRIMSBU, DALHOLEN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, VINGROM, LILLEHAMMER, LILLEHAMMER, MESNALI, LILLEHAMMER, SJUSJ\u00d8EN, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, LISMARKA, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, MESNALI, VINGROM, LILLEHAMMER, LILLEHAMMER, LILLEHAMMER, F\u00c5BERG, LILLEHAMMER, F\u00c5BERG, SJUSJ\u00d8EN, LILLEHAMMER, RINGEBU, RINGEBU, VENABYGD, F\u00c5VANG, F\u00c5VANG, TRETTEN, \u00d8YER, \u00d8YER, TRETTEN, VINSTRA, VINSTRA, KVAM, KVAM, SK\u00c5BU, SK\u00c5BU, S\u00d8R-FRON, G\u00c5L\u00c5, S\u00d8R-FRON, S\u00d8R-FRON, \u00d8STRE GAUSDAL, \u00d8STRE GAUSDAL, SVINGVOLL, VESTRE GAUSDAL, VESTRE GAUSDAL, FOLLEBU, SVATSUM, ESPEDALEN, DOMB\u00c5S, DOMB\u00c5S, HJERKINN, DOVRE, DOVRESKOGEN, DOVRE, LESJA, LORA, LESJAVERK, LESJASKOG, BJORLI, OTTA, LESJA, SEL, H\u00d8VRINGEN, MYSUS\u00c6TER, OTTA, HEIDAL, NEDRE HEIDAL, SEL, HEIDAL, V\u00c5G\u00c5, LALM, LALM, TESSANDEN, V\u00c5G\u00c5, GARMO, LOM, B\u00d8VERDALEN, LOM, SKJ\u00c5K, NORDBERG, SKJ\u00c5K, GROTLI, GRAN, BRANDBU, ROA, JAREN, LUNNER, HARESTUA, GRUA, BRANDBU, GRINDVOLL, LUNNER, ROA, GRUA, HARESTUA, GRAN, BRANDBU, JAREN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, HUNNDALEN, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, GJ\u00d8VIK, NORDRE TOTEN, GJ\u00d8VIK, BYBRUA, GJ\u00d8VIK, HUNNDALEN, RAUFOSS, RAUFOSS, BIRI, RAUFOSS, RAUFOSS, RAUFOSS, BIRI, BIRISTRAND, SNERTINGDAL, \u00d8VRE SNERTINGDAL, REINSVOLL, SNERTINGDAL, EINA, KOLBU, B\u00d8VERBRU, B\u00d8VERBRU, KOLBU, SKREIA, KAPP, LENA, LENA, REINSVOLL, EINA, SKREIA, KAPP, HOV, LAND\u00c5SBYGDA, FLUBERG, FALL, ENGER, HOV, DOKKA, ODNES, NORD-TORPA, AUST-TORPA, DOKKA, ETNEDAL, ETNEDAL, FAGERNES, FAGERNES, LEIRA I VALDRES, AURDAL, AURDAL, SKRAUTV\u00c5L, ULNES, LEIRA I VALDRES, TISLEIDALEN, BAGN, BAGN, REINLI, BEGNADALEN, BEGNA, HEGGENES, HEGGENES, ROGNE, SKAMMESTEIN, BEITO, BEITOST\u00d8LEN, BEITOST\u00d8LEN, R\u00d8N, R\u00d8N, SLIDRE, SLIDRE, LOMEN, RYFOSS, RYFOSS, VANG I VALDRES, VANG I VALDRES, \u00d8YE, TYINKRYSSET, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, MJ\u00d8NDALEN, MJ\u00d8NDALEN, STEINBERG, KROKSTADELVA, KROKSTADELVA, SOLBERGELVA, SOLBERGELVA, SOLBERGMOEN, SVELVIK, SVELVIK, DRAMMEN, DRAMMEN, DRAMMEN, DRAMMEN, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, SANDE I VESTFOLD, BERGER, SANDE I VESTFOLD, SANDE I VESTFOLD, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOLMESTRAND, HOF, HOF, SUNDBYFOSS, EIDSFOSS, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, SEM, VEAR, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, T\u00d8NSBERG, N\u00d8TTER\u00d8Y, T\u00d8NSBERG, HUS\u00d8YSUND, HUS\u00d8YSUND, DUKEN, T\u00d8NSBERG, TOR\u00d8D, TOR\u00d8D, SKALLESTAD, SKALLESTAD, N\u00d8TTER\u00d8Y, KJ\u00d8PMANNSKJ\u00c6R, VESTSKOGEN, KJ\u00d8PMANNSKJ\u00c6R, VEIERLAND, TJ\u00d8ME, HVASSER, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, TOLVSR\u00d8D, MELSOMVIK, BARK\u00c5KER, ANDEBU, MELSOMVIK, STOKKE, STOKKE, ANDEBU, N\u00d8TTER\u00d8Y, REVETAL, TJ\u00d8ME, TOLVSR\u00d8D, \u00c5SG\u00c5RDSTRAND, MELSOMVIK, STOKKE, SEM, SEM, VEAR, VEAR, REVETAL, RAMNES, UNDRUMSDAL, V\u00c5LE, V\u00c5LE, \u00c5SG\u00c5RDSTRAND, NYKIRKE, HORTEN, HORTEN, HORTEN, BORRE, SKOPPUM, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, HORTEN, SKOPPUM, HORTEN, NYKIRKE, BORRE, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, KODAL, SANDEFJORD, KODAL, SANDEFJORD, SANDEFJORD, SANDEFJORD, SANDEFJORD, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, LARVIK, SVARSTAD, SVARSTAD, STEINSHOLT, TJODALYNG, TJODALYNG, KVELDE, KVELDE, LARVIK, STAVERN, STAVERN, STAVERN, STAVERN, HELGEROA, NEVLUNGHAVN, HELGEROA, HOKKSUND, HOKKSUND, HOKKSUND, HOKKSUND, VESTFOSSEN, VESTFOSSEN, FISKUM, SKOTSELV, SKOTSELV, \u00c5MOT, \u00c5MOT, \u00c5MOT, PRESTFOSS, PRESTFOSS, SOLUMSMOEN, EGGEDAL, NEDRE EGGEDAL, EGGEDAL, GEITHUS, GEITHUS, VIKERSUND, VIKERSUND, LIER, LIER, LIER, LIER, LIER, TRANBY, TRANBY, TRANBY, TRANBY, SYLLING, SYLLING, LIERSTRANDA, LIER, LIERSTRANDA, LIERSKOGEN, LIERSKOGEN, REISTAD, GULLAUG, GULLAUG, GULLAUG, SPIKKESTAD, SPIKKESTAD, R\u00d8YKEN, R\u00d8YKEN, HYGGEN, SLEMMESTAD, SLEMMESTAD, B\u00d8DALEN, \u00c5ROS, S\u00c6TRE, S\u00c6TRE, B\u00c5TST\u00d8, N\u00c6RSNES, N\u00c6RSNES, FILTVET, TOFTE, TOFTE, KANA, HOLMSBU, FILTVET, KLOKKARSTUA, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, H\u00d8NEFOSS, JEVNAKER, JEVNAKER, BJONEROA, NES I \u00c5DAL, NES I \u00c5DAL, HALLINGBY, HALLINGBY, BJONEROA, HEDALEN, R\u00d8YSE, R\u00d8YSE, KROKKLEIVA, TYRISTRAND, TYRISTRAND, SOKNA, KR\u00d8DEREN, NORESUND, KR\u00d8DEREN, SOLLIH\u00d8GDA, FL\u00c5, NESBYEN, NESBYEN, NORESUND, TUNHOVD, FL\u00c5, GOL, GOL, HEMSEDAL, HEMSEDAL, \u00c5L, \u00c5L, HOL, HOL, HOVET, TORPO, GEILO, GEILO, DAGALI, USTAOSET, HAUGAST\u00d8L, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, HEISTADMOEN, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, KONGSBERG, SKOLLENBORG, SKOLLENBORG, FLESBERG, LAMPELAND, SVENE, LAMPELAND, LYNGDAL I NUMEDAL, SKOLLENBORG, ROLLAG, VEGGLI, VEGGLI, NORE, R\u00d8DBERG, R\u00d8DBERG, UVDAL, NORE, HVITTINGFOSS, HVITTINGFOSS, PASSEBEKK, TINN AUSTBYGD, HOVIN I TELEMARK, ATR\u00c5, MILAND, RJUKAN, RJUKAN, SAULAND, ATR\u00c5, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, NOTODDEN, HJARTDAL, GRANSHERAD, SAULAND, TUDDAL, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SKIEN, SILJAN, SILJAN, DRANGEDAL, T\u00d8RDAL, NESLANDSVATN, SANNIDAL, KRAGER\u00d8, KRAGER\u00d8, SK\u00c5T\u00d8Y, JOMFRULAND, KRAGER\u00d8 SKJ\u00c6RG\u00c5RD, SKIEN, SKIEN, STABBESTAD, KRAGER\u00d8, HELLE, KRAGER\u00d8, SKIEN, SANNIDAL, HELLE, DRANGEDAL, SKIEN, SKIEN, SKIEN, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, B\u00d8 I TELEMARK, GVARV, H\u00d8RTE, AKKERHAUGEN, NORDAGUTU, LUNDE, ULEFOSS, ULEFOSS, LUNDE, B\u00d8 I TELEMARK, GVARV, SELJORD, KVITESEID, SELJORD, FLATDAL, \u00c5MOTSDAL, MORGEDAL, VR\u00c5LIOSEN, KVITESEID, VR\u00c5DAL, VR\u00c5DAL, NISSEDAL, TREUNGEN, RAULAND, FYRESDAL, DALEN, \u00c5MDALS VERK, TREUNGEN, RAULAND, FYRESDAL, DALEN, VINJE, EDLAND, VINJE, H\u00d8YDALSMO, VINJESVINGEN, EDLAND, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, PORSGRUNN, LANGANGEN, PORSGRUNN, PORSGRUNN, BREVIK, STATHELLE, STATHELLE, STATHELLE, HERRE, STATHELLE, STATHELLE, LANGESUND, BREVIK, LANGESUND, LANGESUND, STATHELLE, PORSGRUNN, PORSGRUNN, PORSGRUNN, HERRE, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, SOLA, SOLA, R\u00d8YNEBERG, R\u00c6GE, TJELTA, SOLA, TANANGER, TANANGER, TANANGER, R\u00d8YNEBERG, TJELTA, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, RANDABERG, RANDABERG, RANDABERG, VASS\u00d8Y, HUNDV\u00c5G, STAVANGER, STAVANGER, STAVANGER, STAVANGER, HUNDV\u00c5G, STAVANGER, HUNDV\u00c5G, HUNDV\u00c5G, STAVANGER, STAVANGER, HAFRSFJORD, HAFRSFJORD, HAFRSFJORD, STAVANGER, STAVANGER, STAVANGER, STAVANGER, RANDABERG, SOLA, TANANGER, STAVANGER, J\u00d8RPELAND, IDSE, FORSAND, FORSAND, TAU, S\u00d8R-HIDLE, TAU, J\u00d8RPELAND, LYSEBOTN, FL\u00d8YRLI, SONGESAND, HJELMELAND, J\u00d8SENFJORDEN, \u00c5RDAL I RYFYLKE, FISTER, SKIFTUN, HJELMELAND, RENNES\u00d8Y, VESTRE \u00c5M\u00d8Y, BRIMSE, AUSTRE \u00c5M\u00d8Y, MOSTER\u00d8Y, BRU, RENNES\u00d8Y, FINN\u00d8Y, FINN\u00d8Y, TALGJE, FOGN, HELG\u00d8Y I RYFYLKE, BYRE, S\u00d8RBOKN, SJERNAR\u00d8Y, NORD-HIDLE, SJERNAR\u00d8Y, KVITS\u00d8Y, KVITS\u00d8Y, SKARTVEIT, OMBO, FOLD\u00d8Y, SAUDA, SAUDA, SAUDASJ\u00d8EN, VANVIK, SAND, ERFJORD, JELSA, HEBNES, SULDALSOSEN, SAND, SULDALSOSEN, NESFLATEN, KOPERVIK, TORVASTAD, AVALDSNES, KVALAV\u00c5G, H\u00c5VIK, \u00c5KREHAMN, SANDVE, STOL, S\u00c6VELANDSVIK, VEAV\u00c5GEN, SKUDENESHAVN, KOPERVIK, KOPERVIK, VEAV\u00c5GEN, \u00c5KREHAMN, SKUDENESHAVN, TORVASTAD, AVALDSNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, FIGGJO, OLTEDAL, DIRDAL, SANDNES, SANDNES, SANDNES, \u00c5LG\u00c5RD, BRYNE, BRYNE, UNDHEIM, ORRE, BRYNE, BRYNE, BRYNE, LYE, LYE, BRYNE, KLEPPE, KLEPP STASJON, VOLL, KVERNALAND, KVERNALAND, KLEPP STASJON, KLEPPE, VARHAUG, SIREV\u00c5G, VIGRESTAD, BRUSAND, SIREV\u00c5G, N\u00c6RB\u00d8, N\u00c6RB\u00d8, VARHAUG, VIGRESTAD, EGERSUND, EGERSUND, EGERSUND, EGERSUND, EGERSUND, HELLVIK, HELLELAND, EGERSUND, EGERSUND, HAUGE I DALANE, HAUGE I DALANE, VIKES\u00c5, HELLELAND, BJERKREIM, VIKES\u00c5, OLTEDAL, SANDNES, SANDNES, SANDNES, SANDNES, HOMMERS\u00c5K, SANDNES, SANDNES, SANDNES, SANDNES, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, FLEKKEFJORD, \u00c5NA-SIRA, HIDRASUND, ANDABEL\u00d8Y, GYLAND, SIRA, SIRA, TONSTAD, TONSTAD, TJ\u00d8RHOM, MOI, HOVSHERAD, UALAND, MOI, KVINLOG, KVINESDAL, \u00d8YESTRANDA, FEDA, KVINESDAL, KVINESDAL, KVINESDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, MANDAL, HOLUM, LINDESNES, LINDESNES, LINDESNES, LINDESNES, LINDESNES, KONSMO, KONSMO, KOLLUNGTVEIT, BYREMO, \u00d8YSLEB\u00d8, MARNARDAL, MARNARDAL, BJELLAND, \u00c5SERAL, \u00c5SERAL, FOSSDAL, FARSUND, FARSUND, FARSUND, FARSUND, FARSUND, VANSE, VANSE, VANSE, BORHAUG, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, LYNGDAL, KORSHAMN, KV\u00c5S, SNARTEMO, TINGVATN, EIKEN, EIKEN, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KARDEMOMME BY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, MOSBY, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, NODELAND, FINSLAND, BRENN\u00c5SEN, FINSLAND, HAMRESANDEN, KJEVIK, TVEIT, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, FLEKKER\u00d8Y, S\u00d8GNE, S\u00d8GNE, S\u00d8GNE, BRENN\u00c5SEN, NODELAND, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, KRISTIANSAND S, TVEIT, VENNESLA, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, VENNESLA, VENNESLA, VENNESLA, \u00d8VREB\u00d8, H\u00c6GELAND, H\u00c6GELAND, IVELAND, IVELAND, VATNESTR\u00d8M, EVJE, EVJE, EVJE, HORNNES, BYGLANDSFJORD, GRENDI, BYGLAND, BYGLAND, VALLE, VALLE, RYSSTAD, RYSSTAD, BYKLE, HOVDEN I SETESDAL, HOVDEN I SETESDAL, BIRKELAND, HEREFOSS, ENGESLAND, H\u00d8V\u00c5G, BREKKEST\u00d8, LILLESAND, LILLESAND, LILLESAND, H\u00d8V\u00c5G, LILLESAND, BIRKELAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, KONGSHAVN, SALTR\u00d8D, KOLBJ\u00d8RNSVIK, HIS, F\u00c6RVIK, FROLAND, RYKENE, RYKENE, NEDENES, BJORBEKK, ARENDAL, FROLANDS VERK, MJ\u00c5VATN, HYNNEKLEIV, MYKLAND, RISDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, ARENDAL, SALTR\u00d8D, F\u00c6RVIK, HIS, NEDENES, FROLAND, ARENDAL, ARENDAL, ARENDAL, ARENDAL, EYDEHAVN, NELAUG, \u00c5MLI, \u00c5MLI, SEL\u00c5SVATN, D\u00d8LEMO, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, HOMBORSUND, FEVIK, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, GRIMSTAD, TVEDESTRAND, TVEDESTRAND, TVEDESTRAND, SONGE, LYNG\u00d8R, GJEVING, VESTRE SAND\u00d8YA, BOR\u00d8Y, STAUB\u00d8, STAUB\u00d8, NES VERK, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, RIS\u00d8R, SUNDEBRU, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, GJERSTAD, VEG\u00c5RSHEI, S\u00d8NDELED, SUNDEBRU, AKLAND, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, EIDSV\u00c5GNESET, EIDSV\u00c5G I \u00c5SANE, EIDSV\u00c5G I \u00c5SANE, \u00d8VRE ERVIK, SALHUS, HORDVIK, HYLKJE, BREISTEIN, TERTNES, TERTNES, ULSET, ULSET, ULSET, ULSET, ULSET, ULSET, MORVIK, MORVIK, NYBORG, NYBORG, NYBORG, FLAKTVEIT, FLAKTVEIT, MJ\u00d8LKER\u00c5EN, MJ\u00d8LKER\u00c5EN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, FYLLINGSDALEN, STRAUMSGREND, B\u00d8NES, B\u00d8NES, B\u00d8NES, B\u00d8NES, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, LAKSEV\u00c5G, BJ\u00d8RNDALSTR\u00c6, LODDEFJORD, LODDEFJORD, LODDEFJORD, MATHOPEN, LODDEFJORD, BJ\u00d8R\u00d8YHAMN, LODDEFJORD, GODVIK, OLSVIK, OLSVIK, OS, OS, OS, OS, OS, S\u00d8FTELAND, OS, OS, OS, OS, S\u00d8FTELAND, LEPS\u00d8Y, LYSEKLOSTER, LYSEKLOSTER, LEPS\u00d8Y, HAGAVIK, NORDSTR\u00d8NO, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, NESTTUN, KALANDSEIDET, PARADIS, PARADIS, PARADIS, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, R\u00c5DAL, FANA, FANA, S\u00d8REIDGREND, S\u00d8REIDGREND, SANDSLI, SANDSLI, KOKSTAD, BLOMSTERDALEN, HJELLESTAD, INDRE ARNA, INDRE ARNA, ARNATVEIT, TRENGEREID, GARNES, YTRE ARNA, ESPELAND, HAUKELAND, VALESTRANDSFOSSEN, LONEV\u00c5G, FOTLANDSV\u00c5G, TYSSEBOTNEN, BRUVIK, HAUS, VALESTRANDSFOSSEN, LONEV\u00c5G, HAUS, KLEPPEST\u00d8, KLEPPEST\u00d8, STRUSSHAMN, FOLLESE, HETLEVIK, FLORV\u00c5G, ERDAL, ASK, KLEPPEST\u00d8, KLEPPEST\u00d8, HAUGLANDSHELLA, KJERRGARDEN, KJERRGARDEN, HERDLA, STRUSSHAMN, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, KLEPPEST\u00d8, FOLLESE, ASK, HAUGLANDSHELLA, FLORV\u00c5G, RONG, TJELDST\u00d8, HELLES\u00d8Y, HERNAR, TJELDST\u00d8, RONG, STRAUME, STRAUME, STRAUME, KNARREVIK, \u00c5GOTNES, \u00c5GOTNES, BRATTHOLMEN, STRAUME, STRAUME, KNARREVIK, FJELL, FJELL, KOLLTVEIT, \u00c5GOTNES, TUR\u00d8Y, MISJE, SKOGSV\u00c5G, STEINSLAND, KLOKKARVIK, STEINSLAND, T\u00c6LAV\u00c5G, GLESV\u00c6R, SKOGSV\u00c5G, TORANGSV\u00c5G, BAKKASUND, M\u00d8KSTER, LITLAKALS\u00d8Y, STOREB\u00d8, STOREB\u00d8, KOLBEINSVIK, VESTRE VINNESV\u00c5G, BEKKJARVIK, STOLMEN, BEKKJARVIK, STORD, STORD, STORD, STORD, STORD, STORD, SAGV\u00c5G, STORD, SAGV\u00c5G, STORD, STORD, HUGLO, STORD, STORD, STORD, STORD, FITJAR, FITJAR, RUBBESTADNESET, BRANDASUND, URANGSV\u00c5G, FOLDR\u00d8YHAMN, BREMNES, FINN\u00c5S, MOSTERHAMN, B\u00d8MLO, ESPEV\u00c6R, BREMNES, MOSTERHAMN, B\u00d8MLO, SUNDE I SUNNHORDLAND, VALEN, SANDVOLL, UT\u00c5KER, S\u00c6B\u00d8VIK, HALSN\u00d8Y KLOSTER, H\u00d8YLANDSBYGD, ARNAVIK, FJELBERG, HUSNES, HER\u00d8YSUNDET, USKEDALEN, DIMMELSVIK, USKEDALEN, ROSENDAL, SEIMSFOSS, SNILSTVEIT\u00d8Y, L\u00d8FALLSTRAND, \u00c6NES, MAURANGER, HUSNES, S\u00c6B\u00d8VIK, ROSENDAL, MATRE, \u00c5KRA, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KARMSUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, HAUGESUND, KOLNES, KARMSUND, VORMEDAL, VORMEDAL, R\u00d8YKSUND, UTSIRA, FE\u00d8Y, R\u00d8V\u00c6R, SVEIO, AUKLANDSHAMN, VALEV\u00c5G, F\u00d8RDE I HORDALAND, F\u00d8RDE I HORDALAND, SVEIO, NEDSTRAND, BOKN, NEDSTRAND, F\u00d8RRESFJORDEN, TYSV\u00c6RV\u00c5G, HERVIK, SKJOLDASTRAUMEN, VIKEBYGD, BOKN, AKSDAL, SKJOLD, AKSDAL, \u00d8VRE VATS, NEDRE VATS, \u00d8LEN, \u00d8LENSV\u00c5G, VIKEDAL, BJOA, SANDEID, VIKEDAL, \u00d8LEN, SANDEID, ETNE, ETNE, SK\u00c5NEVIK, SK\u00c5NEVIK, F\u00d8RRESFJORDEN, MARKHUS, FJ\u00c6RA, NORHEIMSUND, NORHEIMSUND, NORHEIMSUND, \u00d8YSTESE, \u00c5LVIK, \u00d8YSTESE, STEINST\u00d8, \u00c5LVIK, T\u00d8RVIKBYGD, KYSNESSTRAND, JONDAL, HERAND, JONDAL, STRANDEBARM, STRANDEBARM, OMASTRAND, OMASTRAND, HATLESTRAND, VARALDS\u00d8Y, \u00d8LVE, EIKELANDSOSEN, FUSA, HOLMEFJORD, STRANDVIK, S\u00c6VAREID, S\u00c6VAREID, NORDTVEITGREND, BALDERSHEIM, FUSA, EIKELANDSOSEN, TYSSE, TYSSE, \u00c5RLAND, \u00c5RLAND, TYSNES, REKSTEREN, UGGDAL, FLATR\u00c5KER, LUNDEGREND, \u00c5RBAKKA, ONARHEIM, UGGDAL, TYSNES, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, VOSS, EVANGER, VOSS, VOSS, SKULESTADMO, SKULESTADMO, VOSSESTRAND, VOSSESTRAND, VOSS, STALHEIM, MYRDAL, FINSE, STANGHELLE, DALEKVAM, DALEKVAM, BOLSTAD\u00d8YRI, STANGHELLE, VAKSDAL, VAKSDAL, STAMNES, EIDSLANDET, MODALEN, ULVIK, ULVIK, MODALEN, GRANVIN, VALLAVIK, GRANVIN, AURLAND, FL\u00c5M, FL\u00c5M, AURLAND, UNDREDAL, GUDVANGEN, STYVI, ODDA, ODDA, ODDA, R\u00d8LDAL, SKARE, TYSSEDAL, HOVLAND, N\u00c5, N\u00c5, GRIMO, UTNE, UTNE, KINSARVIK, LOFTHUS, KINSARVIK, EIDFJORD, \u00d8VRE EIDFJORD, V\u00d8RINGSFOSS, EIDFJORD, LOFTHUS, KINSARVIK, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, BERGEN, ISDALST\u00d8, ISDALST\u00d8, ISDALST\u00d8, FREKHAUG, ALVERSUND, ISDALST\u00d8, ALVERSUND, SEIM, EIKANGERV\u00c5G, ISDALST\u00d8, HJELM\u00c5S, ISDALST\u00d8, ROSSLAND, FREKHAUG, FREKHAUG, MANGER, B\u00d8V\u00c5GEN, MANGER, B\u00d8V\u00c5GEN, S\u00c6B\u00d8V\u00c5GEN, SLETTA, AUSTRHEIM, AUSTRHEIM, FEDJE, FEDJE, LIND\u00c5S, FONNES, FONNES, MONGSTAD, LIND\u00c5S, HUNDVIN, MYKING, DALS\u00d8YRA, BREKKE, BJORDAL, DALS\u00d8YRA, BREKKE, BJORDAL, EIVINDVIK, EIVINDVIK, BYRKNES\u00d8Y, \u00c5NNELAND, MJ\u00d8MNA, BYRKNES\u00d8Y, MASFJORDNES, MASFJORDNES, HAUGSV\u00c6R, MATREDAL, HAUGSV\u00c6R, HOSTELAND, HOSTELAND, OSTEREIDET, OSTEREIDET, VIKANES, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, LANGEV\u00c5G, EIDSNES, FISKARSTRAND, MAUSEIDV\u00c5G, EIDSNES, FISKARSTRAND, LANGEV\u00c5G, VIGRA, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, \u00c5LESUND, VALDER\u00d8YA, VALDER\u00d8YA, GISKE, GOD\u00d8YA, GOD\u00d8YA, ELLINGS\u00d8Y, VALDER\u00d8YA, VIGRA, HAREID, BRANDAL, HJ\u00d8RUNGAV\u00c5G, HADDAL, ULSTEINVIK, ULSTEINVIK, EIKSUND, HAREID, TJ\u00d8RV\u00c5G, MOLTUSTRANDA, MOLTUSTRANDA, GJERDSVIKA, GURSK\u00d8Y, GURSK\u00d8Y, GURSKEN, GJERDSVIKA, LARSNES, LARSNES, KVAMS\u00d8Y, KVAMS\u00d8Y, SANDSHAMN, SANDSHAMN, FOSNAV\u00c5G, FOSNAV\u00c5G, FOSNAV\u00c5G, LEIN\u00d8Y, B\u00d8LANDET, RUNDE, NERLANDS\u00d8Y, FOSNAV\u00c5G, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, VOLDA, AUSTEFJORDEN, FOLKESTAD, LAUVSTAD, LAUVSTAD, SYVDE, FISK\u00c5, SYVDE, ROVDE, EIDS\u00c5, FISK\u00c5, SYLTE, \u00c5HEIM, \u00c5HEIM, \u00c5RAM, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, \u00d8RSTA, HOVDEBYGDA, HOVDEBYGDA, S\u00c6B\u00d8, S\u00c6B\u00d8, VARTDAL, VARTDAL, BARSTADVIK, TRANDAL, STORESTANDAL, BJ\u00d8RKE, NORANGSFJORDEN, STRANDA, STRANDA, VALLDAL, VALLDAL, LIABYGDA, TAFJORD, NORDDAL, EIDSDAL, GEIRANGER, GEIRANGER, HELLESYLT, HELLESYLT, STRAUMGJERDE, IKORNNES, IKORNNES, HUNDEIDVIK, SYKKYLVEN, STRAUMGJERDE, SYKKYLVEN, \u00d8RSKOG, \u00d8RSKOG, STORDAL, EIDSDAL, STORDAL, SKODJE, SKODJE, TENNFJORD, VATNE, BRATTV\u00c5G, HILDRE, S\u00d8VIK, S\u00d8VIK, BRATTV\u00c5G, VATNE, STOREKALV\u00d8Y, HARAMS\u00d8Y, HARAMS\u00d8Y, KJERSTAD, LONGVA, FJ\u00d8RTOFT, \u00c5NDALSNES, \u00c5NDALSNES, VEBLUNGSNES, INNFJORDEN, ISFJORDEN, VERMA, VERMA, ISFJORDEN, EIDSBYGDA, \u00c5FARNES, \u00c5FARNES, MITTET, VISTDAL, VISTDAL, M\u00c5NDALEN, M\u00c5NDALEN, V\u00c5GSTRANDA, V\u00c5GSTRANDA, FIKSDAL, VESTNES, TRESFJORD, VIKEBUKT, TOMREFJORD, FIKSDAL, REKDAL, VIKEBUKT, TRESFJORD, TOMREFJORD, VESTNES, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, AUREOSEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, SEKKEN, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, MOLDE, BUD, BUD, HUSTAD, MOLDE, MOLDE, MOLDE, ELNESV\u00c5GEN, TORNES I ROMSDAL, FARSTAD, MALMEFJORDEN, FARSTAD, ELNESV\u00c5GEN, HJELSET, KLEIVE, KLEIVE, HJELSET, KORTGARDEN, SK\u00c5LA, BOLS\u00d8YA, SK\u00c5LA, EIDSV\u00c5G I ROMSDAL, EIDSV\u00c5G I ROMSDAL, RAUDSAND, ERESFJORD, ERESFJORD, EIKESDAL, MIDSUND, MIDSUND, AUKRA, AUKRA, ONA, SAND\u00d8Y, HAR\u00d8Y, ORTEN, HAR\u00d8Y, MYKLEBOST, EIDE, LYNGSTAD, VEVANG, EIDE, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, FREI, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, AVER\u00d8Y, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, KRISTIANSUND N, SM\u00d8LA, SM\u00d8LA, TUSTNA, TUSTNA, SUNNDALS\u00d8RA, SUNNDALS\u00d8RA, \u00d8KSENDAL, FURUGRENDA, GR\u00d8A, GJ\u00d8RA, GJ\u00d8RA, \u00c5LVUNDEID, \u00c5LVUNDFJORD, \u00c5LVUNDFJORD, TINGVOLL, MEISINGSET, TORJULV\u00c5GEN, TINGVOLL, BATNFJORDS\u00d8RA, BATNFJORDS\u00d8RA, GJEMNES, ANGVIK, FLEMMA, OSMARKA, TORVIKBUKT, KVANNE, TORVIKBUKT, STANGVIK, B\u00d8FJORDEN, B\u00c6VERFJORD, TODALEN, SURNADAL, SURNADAL, \u00d8VRE SURNADAL, VIND\u00d8LA, SURNADAL, RINDAL, RINDALSSKOGEN, RINDAL, \u00d8YDEGARD, \u00d8YDEGARD, KVISVIK, HALSANAUSTAN, V\u00c5GLAND, VALS\u00d8YBOTN, VALS\u00d8YFJORD, V\u00c5GLAND, AURE, AURE, MJOSUNDET, FOLDFJORDEN, VIHALS, LESUND, KJ\u00d8RSVIKBUGEN, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, M\u00c5L\u00d8Y, DEKNEPOLLEN, RAUDEBERG, BRYGGJA, RAUDEBERG, BRYGGJA, ALMENNINGEN, SILDA, BARMEN, HUSEV\u00c5G, FLATRAKET, DEKNEPOLLEN, SKATESTRAUMEN, SVELGEN, SVELGEN, BREMANGER, BREMANGER, KALV\u00c5G, KALV\u00c5G, DAVIK, RUGSUND, \u00c5LFOTEN, SELJE, SELJE, STADLANDET, STADLANDET, HORNINDAL, HORNINDAL, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, NORDFJORDEID, KJ\u00d8LSDALEN, ST\u00c5RHEIM, LOTE, HOLM\u00d8YANE, STRYN, STRYN, STRYN, OLDEN, OLDEN, LOEN, LOEN, OLDEDALEN, BRIKSDALSBRE, INNVIK, INNVIK, BLAKS\u00c6TER, HOPLAND, UTVIK, HJELLEDALEN, OPPSTRYN, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, F\u00d8RDE, NAUSTDAL, HAUKEDALEN, F\u00d8RDE, F\u00d8RDE, SANDANE, SANDANE, SANDANE, BYRKJELO, BREIM, HESTENES\u00d8YRA, HYEN, BYRKJELO, HYEN, SKEI I J\u00d8LSTER, SKEI I J\u00d8LSTER, VASSENDEN, FJ\u00c6RLAND, VASSENDEN, FJ\u00c6RLAND, KAUPANGER, SOGNDAL, SOGNDAL, SOGNDAL, KAUPANGER, FR\u00d8NNINGEN, SOGNDAL, FARDAL, SLINDE, LEIKANGER, LEIKANGER, GAUPNE, HAFSLO, GAUPNE, HAFSLO, ORNES, JOSTEDAL, LUSTER, MARIFJ\u00d8RA, LUSTER, H\u00d8YHEIMSVIK, SKJOLDEN, FORTUN, VEITASTROND, SOLVORN, \u00c5RDALSTANGEN, \u00d8VRE \u00c5RDAL, \u00d8VRE \u00c5RDAL, \u00c5RDALSTANGEN, L\u00c6RDAL, L\u00c6RDAL, BORGUND, VIK I SOGN, VIK I SOGN, VANGSNES, FEIOS, FRESVIK, BALESTRAND, BALESTRAND, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, FLOR\u00d8, KINN, FLOR\u00d8, SVAN\u00d8YBUKT, ROGNALDSV\u00c5G, BAREKSTAD, BATALDEN, S\u00d8R-SKORPA, TANS\u00d8Y, HARDBAKKE, HARDBAKKE, KRAKHELLA, YTR\u00d8YGREND, KOLGROV, HERSVIKBYGDA, EIKEFJORD, EIKEFJORD, SVORTEVIK, STAVANG, LAVIK, LAVIK, LEIRVIK I SOGN, LEIRVIK I SOGN, HYLLESTAD, S\u00d8RB\u00d8V\u00c5G, S\u00d8RB\u00d8V\u00c5G, DALE I SUNNFJORD, DALE I SUNNFJORD, KORSSUND, GUDDAL, HELLEVIK I FJALER, FLEKKE, STRAUMSNES, SANDE I SUNNFJORD, SANDE I SUNNFJORD, SKILBREI, BYGSTAD, BYGSTAD, VIKSDALEN, ASKVOLL, HOLMEDAL, KVAMMEN, STONGFJORDEN, ATL\u00d8Y, V\u00c6RLANDET, BULANDET, ASKVOLL, H\u00d8YANGER, H\u00d8YANGER, KYRKJEB\u00d8, VADHEIM, VADHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, RANHEIM, RANHEIM, RANHEIM, RANHEIM, JONSVATNET, JAKOBSLI, JAKOBSLI, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, BOSBERG, TRONDHEIM, HEIMDAL, SPONGDAL, TILLER, SAUPSTAD, FLAT\u00c5SEN, HEIMDAL, SJETNEMARKA, KATTEM, LEINSTRAND, HEIMDAL, HEIMDAL, TILLER, TILLER, TILLER, SAUPSTAD, SAUPSTAD, FLAT\u00c5SEN, RISSA, RISSA, STADSBYGD, FEV\u00c5G, HASSELVIKA, HASSELVIKA, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, HUSBYSJ\u00d8EN, R\u00c5KV\u00c5G, STADSBYGD, LEKSVIK, LEKSVIK, VANVIKAN, VANVIKAN, OPPHAUG, BREKSTAD, BREKSTAD, OPPHAUG, UTHAUG, STORFOSNA, STORFOSNA, KR\u00c5KV\u00c5G, GARTEN, LEKSA, BJUGN, BJUGN, LYS\u00d8YSUNDET, OKSVOLL, TARVA, VALLERSUND, LYS\u00d8YSUNDET, \u00c5FJORD, \u00c5FJORD, REVSNES, STOKK\u00d8Y, LINES\u00d8YA, REVSNES, STOKK\u00d8Y, ROAN, ROAN, BESSAKER, BRANDSFJORD, KYRKS\u00c6TER\u00d8RA, KYRKS\u00c6TER\u00d8RA, VINJE\u00d8RA, HELLANDSJ\u00d8EN, KORSVEGEN, KORSVEGEN, G\u00c5SBAKKEN, MELHUS, MELHUS, MELHUS, GIMSE, KV\u00c5L, LUNDAMO, LUNDAMO, LER, LER, HOVIN I GAULDAL, HOVIN I GAULDAL, HITRA, HITRA, ANSNES, KNARRLAGSUND, KVENV\u00c6R, KNARRLAGSUND, KVENV\u00c6R, SANDSTAD, HESTVIKA, MELANDSJ\u00d8, DOLM\u00d8Y, SUNDLANDET, HEMNSKJELA, SNILLFJORD, SNILLFJORD, SISTRANDA, SISTRANDA, HAMARVIK, HAMARVIK, KVERVA, KVERVA, TITRAN, DYRVIK, NORDDYR\u00d8Y, NORDDYR\u00d8Y, SULA, BOG\u00d8YV\u00c6R, MAUSUND, GJ\u00c6SINGEN, S\u00d8RBUR\u00d8Y, SAU\u00d8Y, SOKNEDAL, SOKNEDAL, ST\u00d8REN, ST\u00d8REN, ROGNES, BUDALEN, ORKANGER, ORKANGER, ORKANGER, GJ\u00d8LME, LENSVIK, LENSVIK, AGDENES, AGDENES, FANNREM, FANNREM, SVORKMO, SVORKMO, L\u00d8KKEN VERK, L\u00d8KKEN VERK, STOR\u00c5S, STOR\u00c5S, JERPSTAD, MELDAL, MELDAL, OPPDAL, OPPDAL, L\u00d8NSET, VOGNILL, DRIVA, BUVIKA, BUVIKA, B\u00d8RSA, VIGGJA, EGGKLEIVA, SKAUN, SKAUN, B\u00d8RSA, R\u00d8ROS, BREKKEBYGD, GL\u00c5MOS, R\u00d8ROS, \u00c5LEN, HALTDALEN, \u00c5LEN, SINGS\u00c5S, SINGS\u00c5S, SINGS\u00c5S, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, RENNEBU, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, TRONDHEIM, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, SKATVAL, SKATVAL, STJ\u00d8RDAL, STJ\u00d8RDAL, STJ\u00d8RDAL, HELL, ELVARLI, HEGRA, FLORNES, HEGRA, MER\u00c5KER, MER\u00c5KER, KOPPER\u00c5, KL\u00c6BU, KL\u00c6BU, TANEM, HOMMELVIK, HOMMELVIK, VIKHAMMER, SAKSVIK, MALVIK, VIKHAMMER, HELL, SELBU, SELBU, SELBU, SELBUSTRAND, TYDAL, TYDAL, FLAKNAN, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, LEVANGER, SKOGN, SKOGN, MARKABYGDA, RONGLAN, EKNE, YTTER\u00d8Y, \u00c5SEN, \u00c5SEN, \u00c5SENFJORD, FROSTA, FROSTA, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VERDAL, VUKU, VUKU, INDER\u00d8Y, INDER\u00d8Y, INDER\u00d8Y, MOSVIK, MOSVIK, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINKJER, SPARBU, STEINKJER, STEINKJER, STEINKJER, STEINKJER, STEINKJER, BEITSTAD, STEINSDALEN, STEINSDALEN, YTTERV\u00c5G, HEPS\u00d8Y, OPPLAND, HASV\u00c5G, S\u00c6TERVIK, NAMDALSEID, NAMDALSEID, SN\u00c5SA, SN\u00c5SA, FLATANGER, FLATANGER, NORD-STATLAND, MALM, MALM, FOLLAFOSS, FOLLAFOSS, VERRABOTN, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, NAMSOS, SALSNES, LUND, FOSSLANDSOSEN, SPILLUM, SPILLUM, BANGSUND, BANGSUND, J\u00d8A, SKAGE I NAMDALEN, OVERHALLA, OVERHALLA, SKAGE I NAMDALEN, GRONG, GRONG, HARRAN, HARRAN, KONGSMOEN, H\u00d8YLANDET, H\u00d8YLANDET, NORDLI, NORDLI, S\u00d8RLI, S\u00d8RLI, NAMSSKOGAN, NAMSSKOGAN, TRONES, SKOROVATN, BREKKVASSELV, LIMINGEN, LIMINGEN, R\u00d8RVIK, R\u00d8RVIK, R\u00d8RVIK, OTTERS\u00d8Y, OTTERS\u00d8Y, INDRE N\u00c6R\u00d8Y, ABELV\u00c6R, SALSBRUKET, KOLVEREID, KOLVEREID, GJERDINGA, TERR\u00c5K, TERR\u00c5K, HARANGSFJORD, BINDALSEIDET, BINDALSEIDET, FOLDEREID, FOLDEREID, NAUSTBUKTA, GUTVIK, LEKA, LEKA, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, TVERLANDET, SALTSTRAUMEN, SALTSTRAUMEN, TVERLANDET, V\u00c6R\u00d8Y, V\u00c6R\u00d8Y, R\u00d8ST, R\u00d8ST, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, BOD\u00d8, KJERRING\u00d8Y, FLEINV\u00c6R, HELLIGV\u00c6R, BLIKSV\u00c6R, GIV\u00c6R, LANDEGODE, JAN MAYEN, MISV\u00c6R, SKJERSTAD, BREIVIK I SALTEN, MISV\u00c6R, MOLDJORD, TOLL\u00c5, MOLDJORD, NYG\u00c5RDSJ\u00d8EN, YTRE BEIARN, SANDHORN\u00d8Y, S\u00d8RARN\u00d8Y, S\u00d8RARN\u00d8Y, NORDARN\u00d8Y, INNDYR, INNDYR, STORVIK, REIP\u00c5, NEVERDAL, \u00d8RNES, \u00d8RNES, MEL\u00d8Y, BOLGA, ST\u00d8TT, GLOMFJORD, GLOMFJORD, ENGAV\u00c5GEN, ENGAV\u00c5GEN, HALSA, HALSA, MYKEN, MELFJORDBOTN, V\u00c5GAHOLMEN, \u00c5GSKARDET, V\u00c5GAHOLMEN, TJONGSFJORDEN, JEKTVIK, NORDVERNES, GJERSVIKGRENDA, S\u00d8RFJORDEN, R\u00d8D\u00d8Y, GJER\u00d8Y, SELS\u00d8YVIK, STORSELS\u00d8Y, NORDNES\u00d8Y, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, FAUSKE, VALNESFJORD, FAUSKE, FAUSKE, R\u00d8SVIK, STRAUMEN, SULITJELMA, SULITJELMA, STRAUMEN, VALNESFJORD, ROGNAN, ROGNAN, R\u00d8KLAND, R\u00d8KLAND, INNHAVET, INNHAVET, ENGAN, M\u00d8RSVIKBOTN, DRAG, DRAG, NEVERVIK, MUSKEN, STORJORD I TYSFJORD, ULVSV\u00c5G, STOR\u00c5, LEINESFJORD, LEINESFJORD, LEINES, NORDFOLD, ENGEL\u00d8YA, BOG\u00d8Y, ENGEL\u00d8YA, SKUTVIK, HAMAR\u00d8Y, TRAN\u00d8Y, HAMAR\u00d8Y, SVOLV\u00c6R, SVOLV\u00c6R, SVOLV\u00c6R, KABELV\u00c5G, KABELV\u00c5G, HENNINGSV\u00c6R, HENNINGSV\u00c6R, KLEPPSTAD, GIMS\u00d8YSAND, LAUKVIK, LAUPSTAD, STR\u00d8NSTAD, SKROVA, BRETTESNES, STORFJELL, DIGERMULEN, TENGELFJORD, MYRLAND, STORMOLLA, STAMSUND, SENNESVIK, VALBERG, B\u00d8STAD, B\u00d8STAD, LEKNES, GRAVDAL, BALLSTAD, BALLSTAD, LEKNES, GRAVDAL, STAMSUND, RAMBERG, NAPP, SUND I LOFOTEN, FREDVANG, RAMBERG, REINE, S\u00d8RV\u00c5GEN, S\u00d8RV\u00c5GEN, REINE, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, SORTLAND, GULLESFJORD, L\u00d8DINGEN, L\u00d8DINGEN, VESTBYGD, KVITNES, HENNES, SORTLAND, SORTLAND, SORTLAND, BARKESTAD, TUNSTAD, MYRE, ALSV\u00c5G, ST\u00d8, MYRE, MELBU, LONKAN, STOKMARKNES, STOKMARKNES, MELBU, STRAUMSJ\u00d8EN, B\u00d8 I VESTER\u00c5LEN, B\u00d8 I VESTER\u00c5LEN, STRAUMSJ\u00d8EN, ANDENES, BLEIK, ANDENES, RIS\u00d8YHAMN, DVERBERG, N\u00d8SS, NORDMELA, RIS\u00d8YHAMN, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, NARVIK, NARVIK, NARVIK, NARVIK, NARVIK, ANKENES, BEISFJORD, ELVEG\u00c5RD, BJERKVIK, BJERKVIK, BOGEN I OFOTEN, LILAND, T\u00c5RSTAD, EVENES, BOGEN I OFOTEN, BALLANGEN, KJELDEBOTN, BALLANGEN, KJ\u00d8PSVIK, KJ\u00d8PSVIK, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, SKONSENG, MO I RANA, DALSGRENDA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, MO I RANA, STORFORSHEI, MO I RANA, STORFORSHEI, HEMNESBERGET, HEMNESBERGET, FINNEIDFJORD, BJERKA, BJERKA, KORGEN, BLEIKVASSLIA, KORGEN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, MOSJ\u00d8EN, ELSFJORD, TROFORS, TROFORS, HATTFJELLDAL, HATTFJELLDAL, NESNA, NESNA, VIKHOLMEN, HUSBY, SAURA, UTSKARPEN, BRATLAND, ALDRA, STUVLAND, STOKKV\u00c5GEN, NORD-SOLV\u00c6R, SELV\u00c6R, INDRE KVAR\u00d8Y, TONNES, KONSVIKOSEN, KONSVIKOSEN, \u00d8RESVIK, SLENESET, LOVUND, LUR\u00d8Y, LUR\u00d8Y, TR\u00c6NA, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, SANDNESSJ\u00d8EN, L\u00d8KTA, D\u00d8NNA, D\u00d8NNA, VANDVE, BRAS\u00d8Y, SANDV\u00c6R, HER\u00d8Y, HER\u00d8Y, HER\u00d8Y, AUSTB\u00d8, TJ\u00d8TTA, TJ\u00d8TTA, TRO, VISTHUS, B\u00c6R\u00d8YV\u00c5GEN, LEIRFJORD, LEIRFJORD, SUND\u00d8Y, BARDAL, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, BR\u00d8NN\u00d8YSUND, S\u00d8MNA, S\u00d8MNA, S\u00d8MNA, VELFJORD, VELFJORD, VEVELSTAD, VEVELSTAD, VEGA, VEGA, YLVINGEN, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMSDALEN, TROMSDALEN, KROKELVDALEN, KROKELVDALEN, TOMASJORD, RAMFJORDBOTN, TROMSDALEN, SJURSNES, OLDERVIK, TROMS\u00d8, TROMS\u00d8, NORDKJOSBOTN, LAKSVATN, J\u00d8VIK, OTEREN, NORDKJOSBOTN, STORSTEINNES, MEISTERVIK, MORTENHALS, VIKRAN, STORSTEINNES, LYNGSEIDET, FURUFLATEN, SVENSBY, NORD-LENANGEN, LYNGSEIDET, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YSLETTA, KVAL\u00d8YA, KVAL\u00d8YA, KVAL\u00d8YA, STRAUMSBUKTA, KVAL\u00d8YA, KVAL\u00d8YA, SOMMAR\u00d8Y, BRENSHOLMEN, SOMMAR\u00d8Y, VENGS\u00d8Y, TUSS\u00d8Y, HANSNES, K\u00c5RVIK, STAKKVIK, HANSNES, VANNV\u00c5G, VANNAREID, VANNV\u00c5G, KARLS\u00d8Y, REBBENES, MJ\u00d8LVIK, SKIBOTN, SKIBOTN, SAMUELSBERG, SAMUELSBERG, OLDERDALEN, BIRTAVARRE, OLDERDALEN, BIRTAVARRE, STORSLETT, S\u00d8RKJOSEN, ROTSUND, S\u00d8RKJOSEN, STORSLETT, HAVNNES, BURFJORD, S\u00d8RSTRAUMEN, J\u00d8KELFJORD, BURFJORD, LONGYEARBYEN, LONGYEARBYEN, NY-\u00c5LESUND, HOPEN, SVEAGRUVA, BJ\u00d8RN\u00d8YA, BARENTSBURG, SKJERV\u00d8Y, HAMNEIDET, SEGLVIK, REINFJORD, SPILDRA, ANDSNES, VALANHAMN, SKJERV\u00d8Y, AKKARVIK, ARN\u00d8YHAMN, NIKKEBY, LAUKSLETTA, \u00c5RVIKSAND, UL\u00d8YBUKT, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, TROMS\u00d8, FINNSNES, ROSSFJORDSTRAUMEN, SILSAND, VANGSVIK, FINNSNES, FINNSNES, FINNSNES, FINNSNES, FINNSNES, S\u00d8RREISA, BR\u00d8STADBOTN, S\u00d8RREISA, BR\u00d8STADBOTN, MOEN, KARLSTAD, BARDUFOSS, BARDUFOSS, MOEN, \u00d8VERBYGD, \u00d8VERBYGD, RUNDHAUG, SJ\u00d8VEGAN, SJ\u00d8VEGAN, TENNEVOLL, TENNEVOLL, BARDU, BARDU, SILSAND, GIBOSTAD, BOTNHAMN, SKATVIK, GRYLLEFJORD, GRYLLEFJORD, TORSKEN, GIBOSTAD, SKALAND, SKALAND, SENJAHOPEN, SENJAHOPEN, FJORDGARD, HUS\u00d8Y I SENJA, STONGLANDSEIDET, STONGLANDSEIDET, FLAKSTADV\u00c5G, KALDFARNES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, S\u00d8RVIK, LUNDENES, GR\u00d8TAV\u00c6R, KJ\u00d8TTA, SANDS\u00d8Y, BJARK\u00d8Y, MEL\u00d8YV\u00c6R, SANDTORG, KONGSVIK, EVENSKJER, EVENSKJER, FJELLDAL, RAMSUND, MYKLEBOSTAD, HOL I TJELDSUND, TOVIK, GROVFJORD, GROVFJORD, RAMSUND, HAMNVIK, HAMNVIK, KR\u00c5KR\u00d8HAMN, \u00c5NSTAD, ENGENES, ENGENES, GRATANGEN, GRATANGEN, BORKENES, BORKENES, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, HARSTAD, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, ALTA, KVIBY, KAUTOKEINO, KAUTOKEINO, MAZE, KVALFJORD, HAKKSTABBEN, KONGSHUS, KORSFJORDEN, TALVIK, LANGFJORDBOTN, \u00d8KSFJORD, BERGSFJORD, NUVSV\u00c5G, LANGFJORDHAMN, S\u00d8R-TVERRFJORD, SANDLAND, LOPPA, SKAVNAKK, HASVIK, HASVIK, BREIVIKBOTN, S\u00d8RV\u00c6R, HAMMERFEST, HAMMERFEST, HAMMERFEST, HAMMERFEST, NORDRE SEILAND, RYPEFJORD, RYPEFJORD, FORS\u00d8L, HAMMERFEST, HAMMERFEST, KVALSUND, KVALSUND, REVSNESHAMN, AKKARFJORD, LANGSTRAND, K\u00c5RHAMN, SAND\u00d8YBOTN, TUFJORD, ING\u00d8Y, HAV\u00d8YSUND, HAV\u00d8YSUND, M\u00c5S\u00d8Y, LAKSELV, PORSANGMOEN, INDRE BILLEFJORD, LAKSELV, LAKSELV, RUSSENES, SNEFJORD, KOKELV, B\u00d8RSELV, VEIDNESKLUBBEN, SKOGANVARRE, KARASJOK, KARASJOK, LEBESBY, KUNES, HONNINGSV\u00c5G, HONNINGSV\u00c5G, NORDV\u00c5GEN, SKARSV\u00c5G, NORDKAPP, GJESV\u00c6R, REPV\u00c5G, MEHAMN, SKJ\u00c5NES, LANGFJORDNES, NERVEI, GAMVIK, DYFJORD, KJ\u00d8LLEFJORD, VADS\u00d8, VESTRE JAKOBSELV, VESTRE JAKOBSELV, VADS\u00d8, VADS\u00d8, VARANGERBOTN, SIRMA, VARANGERBOTN, TANA, TANA, KIRKENES, BJ\u00d8RNEVATN, HESSENG, BJ\u00d8RNEVATN, KIRKENES, HESSENG, KIRKENES, SVANVIK, NEIDEN, BUG\u00d8YNES, VARD\u00d8, VARD\u00d8, KIBERG, BERLEV\u00c5G, BERLEV\u00c5G, KONGSFJORD, B\u00c5TSFJORD, B\u00c5TSFJORD"

  l =  [None]*int(10000.0)

  p = strSplitByString(poststeder, ", ")

  nr = HentPostnummerListe()

  i = 0.0
  while i < len(nr):
    l[int(nr[int(i)])] = p[int(i)]
    i = i + 1.0
  

  return l

def HentPostnummerListe():

  n = StringToNumberArray("0001, 0010, 0015, 0018, 0021, 0024, 0026, 0028, 0030, 0031, 0032, 0033, 0034, 0037, 0040, 0045, 0046, 0047, 0048, 0050, 0055, 0060, 0081, 0101, 0102, 0103, 0104, 0105, 0106, 0107, 0109, 0110, 0111, 0112, 0113, 0114, 0115, 0116, 0117, 0118, 0119, 0120, 0121, 0122, 0123, 0124, 0125, 0128, 0129, 0130, 0131, 0132, 0133, 0134, 0135, 0136, 0138, 0139, 0140, 0150, 0151, 0152, 0153, 0154, 0155, 0157, 0158, 0159, 0160, 0161, 0162, 0164, 0165, 0166, 0167, 0168, 0169, 0170, 0171, 0172, 0173, 0174, 0175, 0176, 0177, 0178, 0179, 0180, 0181, 0182, 0183, 0184, 0185, 0186, 0187, 0188, 0190, 0191, 0192, 0193, 0194, 0195, 0196, 0198, 0201, 0202, 0203, 0204, 0207, 0208, 0211, 0212, 0213, 0214, 0215, 0216, 0217, 0218, 0230, 0240, 0244, 0247, 0250, 0251, 0252, 0253, 0254, 0255, 0256, 0257, 0258, 0259, 0260, 0262, 0263, 0264, 0265, 0266, 0267, 0268, 0270, 0271, 0272, 0273, 0274, 0275, 0276, 0277, 0278, 0279, 0280, 0281, 0282, 0283, 0284, 0286, 0287, 0301, 0302, 0303, 0304, 0305, 0306, 0307, 0308, 0309, 0311, 0313, 0314, 0315, 0316, 0317, 0318, 0319, 0323, 0330, 0340, 0349, 0350, 0351, 0352, 0353, 0354, 0355, 0356, 0357, 0358, 0359, 0360, 0361, 0362, 0363, 0364, 0365, 0366, 0367, 0368, 0369, 0370, 0371, 0372, 0373, 0374, 0375, 0376, 0377, 0378, 0379, 0380, 0381, 0382, 0383, 0401, 0402, 0403, 0404, 0405, 0406, 0409, 0410, 0411, 0412, 0413, 0415, 0421, 0422, 0423, 0424, 0440, 0441, 0442, 0445, 0450, 0451, 0452, 0454, 0455, 0456, 0457, 0458, 0459, 0460, 0461, 0462, 0463, 0464, 0465, 0467, 0468, 0469, 0470, 0472, 0473, 0474, 0475, 0476, 0477, 0478, 0479, 0480, 0481, 0482, 0483, 0484, 0485, 0486, 0487, 0488, 0489, 0490, 0491, 0492, 0493, 0494, 0495, 0496, 0501, 0502, 0503, 0504, 0505, 0506, 0507, 0508, 0509, 0510, 0511, 0512, 0513, 0515, 0516, 0517, 0518, 0520, 0540, 0550, 0551, 0552, 0553, 0554, 0555, 0556, 0557, 0558, 0559, 0560, 0561, 0562, 0563, 0564, 0565, 0566, 0567, 0568, 0569, 0570, 0571, 0572, 0573, 0574, 0575, 0576, 0577, 0578, 0579, 0580, 0581, 0582, 0583, 0584, 0585, 0586, 0587, 0588, 0589, 0590, 0591, 0592, 0593, 0594, 0595, 0596, 0597, 0598, 0601, 0602, 0603, 0604, 0605, 0606, 0607, 0608, 0609, 0611, 0612, 0613, 0614, 0615, 0616, 0617, 0618, 0619, 0620, 0621, 0622, 0623, 0624, 0626, 0650, 0651, 0652, 0653, 0654, 0655, 0656, 0657, 0658, 0659, 0660, 0661, 0662, 0663, 0664, 0665, 0666, 0667, 0668, 0669, 0670, 0671, 0672, 0673, 0674, 0675, 0676, 0677, 0678, 0679, 0680, 0681, 0682, 0683, 0684, 0685, 0686, 0687, 0688, 0689, 0690, 0691, 0692, 0693, 0694, 0701, 0702, 0705, 0710, 0712, 0750, 0751, 0752, 0753, 0754, 0755, 0756, 0757, 0758, 0760, 0763, 0764, 0765, 0766, 0767, 0768, 0770, 0771, 0772, 0773, 0774, 0775, 0776, 0777, 0778, 0779, 0781, 0782, 0783, 0784, 0785, 0786, 0787, 0788, 0789, 0790, 0791, 0801, 0805, 0806, 0807, 0840, 0850, 0851, 0852, 0853, 0854, 0855, 0856, 0857, 0858, 0860, 0861, 0862, 0863, 0864, 0870, 0871, 0872, 0873, 0874, 0875, 0876, 0877, 0880, 0881, 0882, 0883, 0884, 0890, 0891, 0901, 0902, 0903, 0904, 0905, 0907, 0908, 0913, 0914, 0915, 0950, 0951, 0952, 0953, 0954, 0955, 0956, 0957, 0958, 0959, 0960, 0962, 0963, 0964, 0968, 0969, 0970, 0971, 0972, 0973, 0975, 0976, 0977, 0978, 0979, 0980, 0981, 0982, 0983, 0984, 0985, 0986, 0987, 0988, 1001, 1003, 1005, 1006, 1007, 1008, 1009, 1011, 1051, 1052, 1053, 1054, 1055, 1056, 1061, 1062, 1063, 1064, 1065, 1067, 1068, 1069, 1071, 1081, 1083, 1084, 1086, 1087, 1088, 1089, 1101, 1102, 1108, 1109, 1112, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1172, 1176, 1177, 1178, 1179, 1181, 1182, 1184, 1185, 1187, 1188, 1189, 1201, 1203, 1204, 1205, 1207, 1214, 1215, 1250, 1251, 1252, 1253, 1254, 1255, 1256, 1257, 1258, 1259, 1262, 1263, 1266, 1270, 1271, 1272, 1273, 1274, 1275, 1278, 1279, 1281, 1283, 1284, 1285, 1286, 1290, 1291, 1294, 1295, 1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1311, 1312, 1313, 1314, 1316, 1317, 1318, 1319, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1344, 1346, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1371, 1372, 1373, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1501, 1502, 1503, 1504, 1506, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540, 1541, 1545, 1550, 1555, 1556, 1560, 1561, 1570, 1580, 1581, 1590, 1591, 1592, 1593, 1594, 1596, 1597, 1598, 1599, 1601, 1602, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621, 1622, 1623, 1624, 1625, 1626, 1628, 1629, 1630, 1632, 1633, 1634, 1636, 1637, 1638, 1639, 1640, 1641, 1642, 1650, 1651, 1653, 1654, 1655, 1657, 1658, 1659, 1661, 1662, 1663, 1664, 1665, 1666, 1667, 1670, 1671, 1672, 1673, 1675, 1676, 1678, 1679, 1680, 1682, 1683, 1684, 1690, 1692, 1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1730, 1733, 1734, 1735, 1738, 1739, 1740, 1742, 1743, 1745, 1746, 1747, 1751, 1752, 1753, 1754, 1757, 1759, 1760, 1761, 1762, 1763, 1764, 1765, 1766, 1767, 1768, 1769, 1771, 1772, 1776, 1777, 1778, 1779, 1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1796, 1798, 1799, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1811, 1812, 1813, 1814, 1815, 1816, 1820, 1821, 1823, 1825, 1827, 1830, 1831, 1832, 1833, 1850, 1851, 1852, 1859, 1860, 1861, 1866, 1867, 1870, 1871, 1875, 1878, 1880, 1890, 1891, 1892, 1893, 1894, 1900, 1901, 1903, 1910, 1911, 1912, 1914, 1916, 1917, 1920, 1921, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1940, 1941, 1950, 1954, 1960, 1961, 1963, 1970, 1971, 2000, 2001, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2040, 2041, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2060, 2061, 2062, 2063, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2076, 2080, 2081, 2090, 2091, 2092, 2093, 2094, 2100, 2101, 2110, 2114, 2116, 2120, 2121, 2123, 2130, 2132, 2133, 2134, 2150, 2151, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2170, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2223, 2224, 2225, 2226, 2227, 2230, 2231, 2232, 2233, 2235, 2240, 2241, 2251, 2256, 2260, 2261, 2264, 2265, 2266, 2270, 2271, 2280, 2283, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2344, 2345, 2346, 2350, 2351, 2353, 2355, 2360, 2361, 2364, 2365, 2372, 2373, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2432, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2446, 2447, 2448, 2450, 2451, 2460, 2461, 2476, 2477, 2478, 2480, 2481, 2484, 2485, 2486, 2487, 2488, 2500, 2501, 2510, 2512, 2513, 2540, 2541, 2542, 2544, 2550, 2551, 2552, 2555, 2560, 2561, 2580, 2581, 2582, 2584, 2601, 2602, 2603, 2604, 2605, 2606, 2607, 2608, 2609, 2610, 2611, 2612, 2613, 2614, 2615, 2616, 2617, 2618, 2619, 2620, 2621, 2622, 2623, 2624, 2625, 2626, 2627, 2628, 2629, 2630, 2631, 2632, 2633, 2634, 2635, 2636, 2637, 2638, 2639, 2640, 2641, 2642, 2643, 2644, 2645, 2646, 2647, 2648, 2649, 2651, 2652, 2653, 2654, 2656, 2657, 2658, 2659, 2660, 2661, 2662, 2663, 2664, 2665, 2666, 2667, 2668, 2669, 2670, 2671, 2672, 2673, 2674, 2675, 2676, 2677, 2678, 2679, 2680, 2681, 2682, 2683, 2684, 2685, 2686, 2687, 2688, 2690, 2693, 2694, 2695, 2711, 2712, 2713, 2714, 2715, 2716, 2717, 2718, 2720, 2730, 2740, 2742, 2743, 2750, 2760, 2770, 2801, 2802, 2803, 2804, 2805, 2806, 2807, 2808, 2809, 2810, 2811, 2812, 2815, 2816, 2817, 2818, 2819, 2820, 2821, 2822, 2825, 2827, 2830, 2831, 2832, 2833, 2834, 2835, 2836, 2837, 2838, 2839, 2840, 2841, 2843, 2844, 2845, 2846, 2847, 2848, 2849, 2850, 2851, 2853, 2854, 2857, 2858, 2860, 2861, 2862, 2864, 2866, 2867, 2870, 2879, 2880, 2881, 2882, 2890, 2893, 2900, 2901, 2907, 2909, 2910, 2917, 2918, 2920, 2923, 2929, 2930, 2933, 2936, 2937, 2939, 2940, 2943, 2950, 2952, 2953, 2954, 2959, 2960, 2965, 2966, 2967, 2972, 2973, 2974, 2975, 2977, 2985, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3050, 3051, 3053, 3054, 3055, 3056, 3057, 3058, 3060, 3061, 3063, 3064, 3065, 3066, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3095, 3101, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3131, 3132, 3133, 3134, 3135, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3148, 3150, 3151, 3152, 3153, 3154, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3199, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3251, 3252, 3253, 3254, 3255, 3256, 3257, 3258, 3259, 3260, 3261, 3262, 3263, 3264, 3265, 3267, 3268, 3269, 3270, 3271, 3274, 3275, 3276, 3277, 3280, 3281, 3282, 3284, 3285, 3290, 3291, 3292, 3294, 3295, 3296, 3297, 3300, 3301, 3302, 3303, 3320, 3321, 3322, 3330, 3331, 3340, 3341, 3342, 3350, 3351, 3355, 3357, 3358, 3359, 3360, 3361, 3370, 3371, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3420, 3421, 3425, 3426, 3427, 3428, 3430, 3431, 3440, 3441, 3442, 3470, 3471, 3472, 3474, 3475, 3476, 3477, 3478, 3479, 3480, 3481, 3482, 3483, 3484, 3485, 3490, 3501, 3502, 3503, 3504, 3507, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521, 3522, 3523, 3524, 3525, 3526, 3527, 3528, 3529, 3530, 3531, 3532, 3533, 3534, 3535, 3536, 3537, 3538, 3539, 3540, 3541, 3543, 3544, 3545, 3550, 3551, 3560, 3561, 3570, 3571, 3575, 3576, 3577, 3579, 3580, 3581, 3588, 3593, 3595, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3621, 3622, 3623, 3624, 3625, 3626, 3627, 3628, 3629, 3630, 3631, 3632, 3634, 3646, 3647, 3648, 3650, 3652, 3656, 3658, 3660, 3661, 3665, 3666, 3671, 3672, 3673, 3674, 3675, 3676, 3677, 3678, 3679, 3680, 3681, 3683, 3684, 3690, 3691, 3692, 3697, 3701, 3702, 3703, 3704, 3705, 3707, 3710, 3711, 3712, 3713, 3714, 3715, 3716, 3717, 3718, 3719, 3720, 3721, 3722, 3723, 3724, 3725, 3726, 3727, 3728, 3729, 3730, 3731, 3732, 3733, 3734, 3735, 3736, 3737, 3738, 3739, 3740, 3741, 3742, 3743, 3744, 3746, 3747, 3748, 3749, 3750, 3753, 3760, 3766, 3770, 3772, 3780, 3781, 3783, 3785, 3787, 3788, 3789, 3790, 3791, 3792, 3793, 3794, 3795, 3796, 3798, 3799, 3800, 3801, 3802, 3803, 3804, 3805, 3810, 3811, 3812, 3820, 3825, 3830, 3831, 3832, 3833, 3834, 3835, 3836, 3840, 3841, 3844, 3848, 3849, 3850, 3852, 3853, 3854, 3855, 3864, 3870, 3880, 3882, 3883, 3884, 3885, 3886, 3887, 3888, 3890, 3891, 3893, 3895, 3901, 3902, 3903, 3904, 3905, 3906, 3910, 3911, 3912, 3913, 3914, 3915, 3916, 3917, 3918, 3919, 3920, 3921, 3922, 3924, 3925, 3928, 3929, 3930, 3931, 3933, 3936, 3937, 3939, 3940, 3941, 3942, 3943, 3944, 3946, 3947, 3948, 3949, 3950, 3960, 3961, 3962, 3965, 3966, 3967, 3970, 3991, 3993, 3994, 3995, 3996, 3997, 3998, 3999, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4031, 4032, 4033, 4034, 4035, 4036, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071, 4072, 4073, 4076, 4077, 4078, 4079, 4081, 4082, 4083, 4084, 4085, 4086, 4087, 4088, 4089, 4090, 4091, 4092, 4093, 4094, 4095, 4096, 4097, 4098, 4099, 4100, 4102, 4110, 4119, 4120, 4123, 4124, 4126, 4127, 4128, 4129, 4130, 4134, 4137, 4139, 4146, 4148, 4150, 4152, 4153, 4154, 4156, 4158, 4159, 4160, 4161, 4163, 4164, 4167, 4168, 4169, 4170, 4173, 4174, 4180, 4181, 4182, 4187, 4198, 4200, 4201, 4208, 4209, 4230, 4233, 4234, 4235, 4237, 4239, 4240, 4244, 4250, 4260, 4262, 4264, 4265, 4270, 4272, 4274, 4275, 4276, 4280, 4291, 4294, 4295, 4296, 4297, 4298, 4299, 4301, 4302, 4306, 4307, 4308, 4309, 4310, 4311, 4312, 4313, 4314, 4315, 4316, 4317, 4318, 4319, 4320, 4321, 4322, 4323, 4324, 4325, 4326, 4327, 4328, 4329, 4330, 4332, 4333, 4335, 4336, 4337, 4338, 4339, 4340, 4341, 4342, 4343, 4344, 4345, 4346, 4347, 4348, 4349, 4352, 4353, 4354, 4355, 4356, 4357, 4358, 4360, 4361, 4362, 4363, 4364, 4365, 4367, 4368, 4369, 4370, 4371, 4372, 4373, 4374, 4375, 4376, 4378, 4379, 4380, 4381, 4384, 4385, 4387, 4389, 4390, 4391, 4392, 4393, 4394, 4395, 4396, 4397, 4398, 4399, 4400, 4401, 4402, 4403, 4420, 4432, 4434, 4436, 4438, 4439, 4440, 4441, 4443, 4460, 4462, 4463, 4465, 4473, 4480, 4484, 4485, 4490, 4491, 4492, 4501, 4502, 4503, 4504, 4507, 4508, 4509, 4513, 4514, 4515, 4516, 4517, 4519, 4520, 4521, 4522, 4523, 4524, 4525, 4526, 4528, 4529, 4532, 4534, 4535, 4536, 4540, 4541, 4544, 4550, 4551, 4552, 4553, 4554, 4557, 4558, 4560, 4563, 4575, 4576, 4577, 4579, 4580, 4586, 4588, 4590, 4595, 4596, 4597, 4604, 4605, 4606, 4608, 4609, 4610, 4611, 4612, 4613, 4614, 4615, 4616, 4617, 4618, 4619, 4620, 4621, 4622, 4623, 4624, 4625, 4626, 4628, 4629, 4630, 4631, 4632, 4633, 4634, 4635, 4636, 4637, 4638, 4639, 4640, 4641, 4642, 4643, 4644, 4645, 4646, 4647, 4649, 4656, 4657, 4658, 4661, 4662, 4663, 4664, 4665, 4666, 4670, 4671, 4672, 4673, 4674, 4675, 4676, 4677, 4678, 4679, 4681, 4682, 4683, 4684, 4685, 4686, 4687, 4688, 4689, 4691, 4693, 4694, 4695, 4696, 4697, 4698, 4699, 4700, 4701, 4702, 4703, 4705, 4706, 4707, 4708, 4715, 4720, 4721, 4724, 4725, 4730, 4733, 4734, 4735, 4737, 4741, 4742, 4744, 4745, 4746, 4747, 4748, 4749, 4754, 4755, 4756, 4760, 4766, 4768, 4770, 4780, 4790, 4791, 4792, 4793, 4794, 4795, 4801, 4802, 4803, 4804, 4808, 4809, 4810, 4812, 4815, 4816, 4817, 4818, 4820, 4821, 4822, 4823, 4824, 4825, 4827, 4828, 4830, 4832, 4834, 4836, 4838, 4839, 4841, 4842, 4843, 4844, 4846, 4847, 4848, 4849, 4851, 4852, 4853, 4854, 4855, 4856, 4857, 4858, 4859, 4862, 4863, 4864, 4865, 4868, 4869, 4870, 4876, 4877, 4878, 4879, 4884, 4885, 4886, 4887, 4888, 4889, 4891, 4892, 4893, 4894, 4896, 4898, 4900, 4901, 4902, 4909, 4910, 4912, 4915, 4916, 4920, 4921, 4934, 4950, 4951, 4952, 4953, 4955, 4956, 4957, 4971, 4972, 4973, 4974, 4980, 4985, 4990, 4993, 4994, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5041, 5042, 5043, 5045, 5052, 5053, 5054, 5055, 5056, 5057, 5058, 5059, 5063, 5067, 5068, 5072, 5073, 5075, 5081, 5082, 5089, 5093, 5094, 5096, 5097, 5098, 5099, 5101, 5104, 5105, 5106, 5107, 5108, 5109, 5111, 5113, 5114, 5115, 5116, 5117, 5118, 5119, 5121, 5122, 5124, 5130, 5131, 5132, 5134, 5135, 5136, 5137, 5141, 5142, 5143, 5144, 5145, 5146, 5147, 5148, 5151, 5152, 5153, 5154, 5155, 5160, 5161, 5162, 5163, 5164, 5165, 5170, 5171, 5172, 5173, 5174, 5176, 5177, 5178, 5179, 5183, 5184, 5200, 5201, 5202, 5203, 5206, 5207, 5208, 5209, 5210, 5211, 5212, 5213, 5214, 5215, 5216, 5217, 5218, 5221, 5222, 5223, 5224, 5225, 5226, 5227, 5228, 5229, 5230, 5231, 5232, 5235, 5236, 5237, 5238, 5239, 5243, 5244, 5251, 5252, 5253, 5254, 5257, 5258, 5259, 5260, 5261, 5262, 5263, 5264, 5265, 5267, 5268, 5281, 5282, 5283, 5284, 5285, 5286, 5291, 5293, 5299, 5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5314, 5315, 5318, 5319, 5321, 5322, 5323, 5325, 5326, 5327, 5329, 5331, 5333, 5334, 5335, 5336, 5337, 5341, 5342, 5343, 5345, 5346, 5347, 5350, 5353, 5354, 5355, 5357, 5358, 5360, 5363, 5365, 5366, 5371, 5374, 5378, 5379, 5380, 5381, 5382, 5384, 5385, 5387, 5388, 5392, 5393, 5394, 5396, 5397, 5398, 5399, 5401, 5402, 5403, 5404, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416, 5417, 5418, 5419, 5420, 5423, 5427, 5428, 5430, 5437, 5440, 5443, 5444, 5445, 5447, 5449, 5450, 5451, 5452, 5453, 5454, 5455, 5457, 5458, 5459, 5460, 5462, 5463, 5464, 5465, 5470, 5472, 5473, 5474, 5475, 5476, 5480, 5484, 5486, 5498, 5499, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5511, 5512, 5514, 5515, 5516, 5517, 5518, 5519, 5521, 5522, 5523, 5525, 5527, 5528, 5529, 5531, 5532, 5533, 5534, 5535, 5536, 5537, 5538, 5541, 5542, 5544, 5545, 5546, 5547, 5548, 5549, 5550, 5551, 5554, 5555, 5556, 5559, 5560, 5561, 5562, 5563, 5565, 5566, 5567, 5568, 5569, 5570, 5574, 5575, 5576, 5578, 5580, 5582, 5583, 5584, 5585, 5586, 5588, 5589, 5590, 5591, 5593, 5594, 5595, 5596, 5598, 5600, 5601, 5602, 5604, 5605, 5610, 5612, 5614, 5620, 5626, 5627, 5628, 5629, 5630, 5631, 5632, 5633, 5635, 5636, 5637, 5640, 5641, 5642, 5643, 5644, 5645, 5646, 5647, 5648, 5649, 5650, 5651, 5652, 5653, 5680, 5683, 5685, 5687, 5690, 5693, 5694, 5695, 5696, 5700, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5718, 5719, 5720, 5721, 5722, 5723, 5724, 5725, 5726, 5727, 5728, 5729, 5730, 5731, 5732, 5733, 5734, 5736, 5741, 5742, 5743, 5745, 5746, 5747, 5748, 5750, 5751, 5752, 5760, 5763, 5770, 5773, 5775, 5776, 5777, 5778, 5779, 5780, 5781, 5782, 5783, 5784, 5785, 5786, 5787, 5788, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5823, 5824, 5825, 5826, 5827, 5828, 5829, 5830, 5831, 5832, 5833, 5834, 5835, 5836, 5837, 5838, 5841, 5843, 5844, 5845, 5847, 5848, 5849, 5851, 5852, 5853, 5854, 5855, 5857, 5858, 5859, 5861, 5862, 5863, 5864, 5865, 5866, 5867, 5868, 5869, 5872, 5873, 5876, 5877, 5878, 5879, 5881, 5884, 5886, 5887, 5888, 5889, 5892, 5893, 5895, 5896, 5899, 5902, 5903, 5904, 5906, 5907, 5908, 5911, 5912, 5913, 5914, 5915, 5916, 5917, 5918, 5919, 5931, 5935, 5936, 5937, 5938, 5939, 5941, 5943, 5947, 5948, 5951, 5952, 5953, 5954, 5955, 5956, 5957, 5960, 5961, 5962, 5963, 5964, 5965, 5966, 5967, 5970, 5977, 5978, 5979, 5981, 5982, 5983, 5984, 5985, 5986, 5987, 5991, 5993, 5994, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6028, 6030, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6044, 6045, 6046, 6047, 6048, 6050, 6051, 6052, 6054, 6055, 6057, 6058, 6059, 6060, 6062, 6063, 6064, 6065, 6067, 6068, 6069, 6070, 6075, 6076, 6078, 6079, 6080, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6094, 6095, 6096, 6098, 6099, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6110, 6120, 6133, 6134, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6146, 6147, 6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6160, 6161, 6165, 6166, 6170, 6171, 6174, 6183, 6184, 6190, 6196, 6200, 6201, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6222, 6223, 6224, 6230, 6238, 6239, 6240, 6249, 6250, 6255, 6259, 6260, 6263, 6264, 6265, 6270, 6272, 6280, 6281, 6282, 6283, 6285, 6290, 6291, 6292, 6293, 6294, 6300, 6301, 6310, 6315, 6320, 6330, 6331, 6339, 6350, 6360, 6361, 6363, 6364, 6365, 6385, 6386, 6387, 6388, 6389, 6390, 6391, 6392, 6393, 6394, 6395, 6396, 6397, 6398, 6399, 6401, 6402, 6403, 6404, 6405, 6407, 6408, 6409, 6410, 6411, 6412, 6413, 6414, 6415, 6416, 6418, 6419, 6421, 6422, 6423, 6425, 6429, 6430, 6431, 6433, 6434, 6435, 6436, 6440, 6443, 6444, 6445, 6446, 6447, 6450, 6452, 6453, 6454, 6455, 6456, 6457, 6458, 6460, 6461, 6462, 6470, 6471, 6472, 6475, 6476, 6480, 6481, 6483, 6484, 6485, 6486, 6487, 6488, 6490, 6493, 6494, 6499, 6501, 6502, 6503, 6504, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6514, 6515, 6516, 6517, 6518, 6520, 6521, 6522, 6523, 6524, 6525, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6538, 6539, 6546, 6547, 6548, 6549, 6570, 6571, 6590, 6591, 6600, 6601, 6610, 6611, 6612, 6613, 6614, 6620, 6622, 6623, 6627, 6628, 6629, 6630, 6631, 6632, 6633, 6636, 6637, 6638, 6639, 6640, 6641, 6642, 6643, 6644, 6645, 6650, 6652, 6653, 6655, 6656, 6657, 6658, 6659, 6670, 6671, 6674, 6680, 6683, 6686, 6687, 6688, 6689, 6690, 6693, 6694, 6697, 6698, 6699, 6700, 6701, 6702, 6703, 6704, 6707, 6708, 6710, 6711, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6721, 6723, 6726, 6727, 6728, 6729, 6730, 6734, 6737, 6740, 6741, 6750, 6751, 6761, 6763, 6770, 6771, 6772, 6773, 6774, 6776, 6777, 6778, 6779, 6781, 6782, 6783, 6784, 6788, 6789, 6790, 6791, 6792, 6793, 6794, 6795, 6796, 6797, 6798, 6799, 6800, 6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810, 6811, 6812, 6813, 6814, 6815, 6817, 6818, 6819, 6820, 6821, 6822, 6823, 6826, 6827, 6828, 6829, 6830, 6831, 6841, 6843, 6844, 6845, 6847, 6848, 6849, 6851, 6852, 6853, 6854, 6855, 6856, 6858, 6859, 6861, 6863, 6866, 6867, 6868, 6869, 6870, 6871, 6872, 6873, 6874, 6875, 6876, 6877, 6878, 6879, 6881, 6882, 6884, 6885, 6886, 6887, 6888, 6891, 6893, 6894, 6895, 6896, 6898, 6899, 6900, 6901, 6902, 6903, 6905, 6906, 6907, 6908, 6909, 6910, 6912, 6913, 6914, 6915, 6916, 6917, 6918, 6919, 6921, 6924, 6926, 6927, 6928, 6929, 6940, 6941, 6942, 6944, 6946, 6947, 6951, 6953, 6957, 6958, 6959, 6961, 6963, 6964, 6966, 6967, 6968, 6969, 6971, 6973, 6975, 6976, 6977, 6978, 6980, 6982, 6983, 6984, 6985, 6986, 6987, 6988, 6991, 6993, 6995, 6996, 6997, 7003, 7004, 7005, 7006, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050, 7051, 7052, 7053, 7054, 7055, 7056, 7057, 7058, 7059, 7066, 7067, 7068, 7069, 7070, 7071, 7072, 7074, 7075, 7078, 7079, 7080, 7081, 7082, 7083, 7088, 7089, 7091, 7092, 7093, 7097, 7098, 7099, 7100, 7101, 7105, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7119, 7120, 7121, 7125, 7126, 7127, 7129, 7130, 7140, 7142, 7150, 7151, 7152, 7153, 7156, 7159, 7160, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7174, 7175, 7176, 7177, 7178, 7180, 7181, 7190, 7194, 7200, 7201, 7203, 7206, 7211, 7212, 7213, 7221, 7223, 7224, 7227, 7228, 7231, 7232, 7234, 7235, 7236, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7250, 7252, 7255, 7256, 7257, 7259, 7260, 7261, 7263, 7264, 7266, 7267, 7268, 7270, 7273, 7274, 7280, 7282, 7284, 7285, 7286, 7287, 7288, 7289, 7290, 7291, 7295, 7298, 7300, 7301, 7302, 7310, 7315, 7316, 7318, 7319, 7320, 7321, 7327, 7329, 7331, 7332, 7333, 7334, 7335, 7336, 7338, 7340, 7341, 7342, 7343, 7345, 7350, 7351, 7353, 7354, 7355, 7356, 7357, 7358, 7361, 7370, 7372, 7374, 7380, 7383, 7384, 7386, 7387, 7388, 7391, 7392, 7393, 7397, 7398, 7399, 7400, 7401, 7402, 7403, 7404, 7405, 7406, 7407, 7408, 7409, 7410, 7411, 7412, 7413, 7414, 7415, 7416, 7417, 7418, 7419, 7420, 7421, 7422, 7424, 7425, 7426, 7427, 7428, 7429, 7430, 7431, 7432, 7433, 7434, 7435, 7436, 7437, 7438, 7439, 7440, 7441, 7442, 7443, 7444, 7445, 7446, 7447, 7448, 7449, 7450, 7451, 7452, 7453, 7454, 7455, 7456, 7457, 7458, 7459, 7462, 7463, 7464, 7465, 7466, 7467, 7468, 7469, 7470, 7471, 7472, 7473, 7474, 7475, 7476, 7477, 7478, 7479, 7480, 7481, 7482, 7483, 7484, 7485, 7486, 7487, 7488, 7489, 7490, 7491, 7492, 7493, 7494, 7495, 7496, 7497, 7498, 7500, 7501, 7502, 7503, 7504, 7505, 7506, 7507, 7508, 7509, 7510, 7511, 7512, 7513, 7514, 7517, 7519, 7520, 7525, 7529, 7530, 7531, 7533, 7540, 7541, 7549, 7550, 7551, 7560, 7562, 7563, 7566, 7570, 7580, 7581, 7583, 7584, 7590, 7591, 7596, 7600, 7601, 7602, 7603, 7604, 7605, 7606, 7607, 7608, 7609, 7610, 7619, 7620, 7622, 7623, 7624, 7629, 7630, 7631, 7632, 7633, 7634, 7650, 7651, 7652, 7653, 7654, 7655, 7656, 7657, 7658, 7660, 7661, 7670, 7671, 7672, 7690, 7691, 7701, 7702, 7703, 7704, 7705, 7707, 7708, 7709, 7710, 7711, 7712, 7713, 7714, 7715, 7716, 7717, 7718, 7724, 7725, 7726, 7729, 7730, 7732, 7733, 7734, 7735, 7736, 7737, 7738, 7739, 7740, 7741, 7742, 7744, 7745, 7746, 7748, 7750, 7751, 7760, 7761, 7770, 7771, 7777, 7790, 7791, 7795, 7796, 7797, 7800, 7801, 7802, 7803, 7804, 7805, 7808, 7810, 7817, 7818, 7819, 7820, 7821, 7822, 7823, 7856, 7860, 7863, 7864, 7869, 7870, 7871, 7873, 7874, 7876, 7877, 7878, 7881, 7882, 7884, 7885, 7890, 7891, 7892, 7893, 7896, 7897, 7898, 7900, 7901, 7902, 7940, 7941, 7944, 7950, 7960, 7970, 7971, 7973, 7979, 7980, 7981, 7982, 7983, 7985, 7986, 7990, 7993, 7994, 7995, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8019, 8020, 8021, 8022, 8023, 8026, 8027, 8028, 8029, 8030, 8031, 8037, 8038, 8041, 8047, 8048, 8049, 8050, 8056, 8057, 8058, 8062, 8063, 8064, 8065, 8070, 8071, 8072, 8073, 8074, 8075, 8076, 8079, 8084, 8086, 8087, 8088, 8089, 8091, 8092, 8093, 8094, 8095, 8096, 8097, 8098, 8099, 8100, 8102, 8103, 8108, 8110, 8114, 8118, 8120, 8128, 8130, 8134, 8135, 8136, 8138, 8140, 8145, 8146, 8149, 8150, 8151, 8157, 8158, 8159, 8160, 8161, 8168, 8170, 8178, 8179, 8181, 8182, 8183, 8184, 8185, 8186, 8187, 8188, 8189, 8190, 8193, 8195, 8196, 8197, 8198, 8200, 8201, 8202, 8203, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8214, 8215, 8218, 8219, 8220, 8226, 8230, 8231, 8232, 8233, 8250, 8251, 8255, 8256, 8260, 8261, 8264, 8266, 8270, 8271, 8273, 8274, 8275, 8276, 8278, 8281, 8283, 8285, 8286, 8287, 8288, 8289, 8290, 8294, 8297, 8298, 8300, 8301, 8305, 8309, 8310, 8311, 8312, 8313, 8314, 8315, 8316, 8317, 8320, 8322, 8323, 8324, 8325, 8326, 8328, 8340, 8352, 8357, 8360, 8361, 8370, 8372, 8373, 8374, 8376, 8377, 8378, 8380, 8382, 8384, 8387, 8388, 8390, 8392, 8393, 8398, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8419, 8426, 8428, 8430, 8432, 8438, 8439, 8445, 8447, 8450, 8455, 8459, 8465, 8469, 8470, 8475, 8480, 8481, 8483, 8484, 8485, 8488, 8489, 8493, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8512, 8513, 8514, 8515, 8516, 8517, 8518, 8520, 8522, 8523, 8530, 8531, 8533, 8534, 8535, 8536, 8539, 8540, 8543, 8546, 8590, 8591, 8601, 8602, 8603, 8604, 8607, 8608, 8609, 8610, 8613, 8614, 8615, 8616, 8617, 8618, 8619, 8622, 8624, 8626, 8630, 8634, 8638, 8640, 8641, 8642, 8643, 8644, 8646, 8647, 8648, 8651, 8652, 8654, 8655, 8656, 8657, 8658, 8659, 8660, 8661, 8663, 8664, 8665, 8666, 8672, 8680, 8681, 8690, 8691, 8700, 8701, 8720, 8723, 8724, 8725, 8730, 8732, 8733, 8735, 8740, 8742, 8743, 8750, 8752, 8753, 8754, 8762, 8764, 8766, 8767, 8770, 8800, 8801, 8802, 8803, 8804, 8805, 8809, 8813, 8820, 8827, 8830, 8842, 8844, 8850, 8851, 8852, 8854, 8860, 8861, 8865, 8870, 8880, 8890, 8891, 8892, 8897, 8900, 8901, 8902, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8920, 8921, 8922, 8960, 8961, 8976, 8977, 8980, 8981, 8985, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9027, 9029, 9030, 9034, 9037, 9038, 9040, 9042, 9043, 9046, 9049, 9050, 9055, 9056, 9057, 9059, 9060, 9062, 9064, 9068, 9069, 9100, 9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9110, 9118, 9119, 9120, 9128, 9130, 9131, 9132, 9134, 9135, 9136, 9137, 9138, 9140, 9141, 9142, 9143, 9144, 9145, 9146, 9147, 9148, 9149, 9151, 9152, 9153, 9155, 9156, 9159, 9161, 9162, 9163, 9169, 9170, 9171, 9173, 9174, 9175, 9176, 9178, 9180, 9181, 9182, 9184, 9185, 9186, 9187, 9189, 9190, 9192, 9193, 9194, 9195, 9197, 9240, 9251, 9252, 9253, 9254, 9255, 9256, 9257, 9258, 9259, 9260, 9261, 9262, 9263, 9265, 9266, 9267, 9268, 9269, 9270, 9271, 9272, 9273, 9274, 9275, 9276, 9277, 9278, 9279, 9280, 9281, 9282, 9283, 9284, 9285, 9286, 9287, 9288, 9290, 9291, 9292, 9293, 9294, 9296, 9298, 9299, 9300, 9302, 9303, 9304, 9305, 9306, 9307, 9308, 9309, 9310, 9311, 9315, 9316, 9321, 9322, 9325, 9326, 9329, 9334, 9335, 9336, 9350, 9355, 9357, 9358, 9360, 9365, 9370, 9372, 9373, 9376, 9379, 9380, 9381, 9382, 9384, 9385, 9386, 9387, 9388, 9389, 9391, 9392, 9393, 9395, 9402, 9403, 9404, 9405, 9406, 9407, 9408, 9409, 9411, 9414, 9415, 9416, 9419, 9420, 9423, 9424, 9425, 9426, 9427, 9430, 9436, 9439, 9440, 9441, 9442, 9443, 9444, 9445, 9446, 9447, 9448, 9450, 9451, 9453, 9454, 9455, 9456, 9470, 9471, 9475, 9476, 9479, 9480, 9481, 9482, 9483, 9484, 9485, 9486, 9487, 9488, 9489, 9496, 9497, 9498, 9501, 9502, 9503, 9504, 9505, 9506, 9507, 9508, 9509, 9510, 9511, 9512, 9513, 9514, 9515, 9516, 9517, 9518, 9519, 9520, 9521, 9525, 9531, 9532, 9533, 9536, 9540, 9545, 9550, 9580, 9582, 9583, 9584, 9585, 9586, 9587, 9590, 9591, 9593, 9595, 9600, 9601, 9602, 9603, 9609, 9610, 9611, 9612, 9615, 9616, 9620, 9621, 9624, 9650, 9651, 9657, 9664, 9670, 9672, 9690, 9691, 9692, 9700, 9709, 9710, 9711, 9712, 9713, 9714, 9715, 9716, 9717, 9722, 9730, 9735, 9740, 9742, 9750, 9751, 9760, 9763, 9764, 9765, 9768, 9770, 9771, 9772, 9773, 9775, 9782, 9790, 9800, 9802, 9810, 9811, 9815, 9820, 9826, 9840, 9845, 9846, 9900, 9910, 9912, 9914, 9915, 9916, 9917, 9925, 9930, 9935, 9950, 9951, 9960, 9980, 9981, 9982, 9990, 9991")

  return n

def HentPoststed(nrString, feilmelding):

  nr = CreateNumberFromDecimalString(nrString)
  respons = ""

  if ErGyldigPostnummer(nrString):
    feilmelding.success = True
    poststedListe = HentPoststedListe()
    respons = poststedListe[int(nr)].string
  else:
    feilmelding.success = False
    feilmelding.feilmelding = "Postnummer er ikke gyldig."

  return respons

def ErGyldigPostnummer(nrString):

  nr = CreateNumberFromDecimalString(nrString)
  gyldigePostnummer = GyldigPostnummertabell()

  if nr > 0.0 and nr < 10000.0 and IsInteger(nr) and len(nrString) == 4.0:
    erGyldig = gyldigePostnummer[int(nr)]
  else:
    erGyldig = False

  return erGyldig

def GyldigPostnummertabell():

  postnummerliste = HentPostnummerListe()
  maxnummer = 0.0

  i = 0.0
  while i < len(postnummerliste):
    maxnummer = max(maxnummer,postnummerliste[int(i)])
    i = i + 1.0
  

  rev =  [None]*int(maxnummer + 1.0)

  i = 0.0
  while i < maxnummer:
    rev[int(i)] = False
    i = i + 1.0
  

  i = 0.0
  while i < len(postnummerliste):
    rev[int(postnummerliste[int(i)])] = True
    i = i + 1.0
  

  return rev

def Loess(xs, ys, bandwidth, robustnessIters, accuracy, resultXs, errorMessage):

  weights =  [None]*int(len(xs))
  arraysFillNumberArray(weights, 1.0)

  return Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage)

def Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage):

  # Sort arrays
  indexes = QuickSortNumbersWithIndexes(xs)
  RearrangeArray(ys, indexes)

  if len(xs) == len(ys) and len(xs) != 0.0:
    n = len(xs)

    if n == 1.0 or n == 2.0:
      if n == 1.0:
        res =  [None]*int(1.0)
        res[int(0.0)] = ys[int(0.0)]
      else:
        res =  [None]*int(2.0)
        res[int(0.0)] = ys[int(0.0)]
        res[int(1.0)] = ys[int(1.0)]

      resultXs.numberArray = res
      success = True
    else:
      bandwidthInPoints = Truncate(bandwidth*n)

      if bandwidthInPoints >= 2.0:
        res =  [None]*int(n)
        residuals =  [None]*int(n)

        robustnessWeights =  [None]*int(n)
        arraysFillNumberArray(robustnessWeights, 1.0)

        done = False
        iter = 0.0
        while iter <= robustnessIters and  not done :
          bandwidthInterval =  [None]*int(2.0)
          bandwidthInterval[int(0.0)] = 0.0
          bandwidthInterval[int(1.0)] = bandwidthInPoints - 1.0

          i = 0.0
          while i < n:
            x = xs[int(i)]

            if i > 0.0:
              left = bandwidthInterval[int(0.0)]
              right = bandwidthInterval[int(1.0)]

              nextRight = FindNextNonZeroElement(weights, right)
              nextLeft = left
              while nextRight < len(xs) and xs[int(nextRight)] - xs[int(i)] < xs[int(i)] - xs[int(nextLeft)]:
                nextLeft = FindNextNonZeroElement(weights, bandwidthInterval[int(0.0)])
                bandwidthInterval[int(0.0)] = nextLeft
                bandwidthInterval[int(1.0)] = nextRight
                nextRight = FindNextNonZeroElement(weights, nextRight)
              

            ileft = bandwidthInterval[int(0.0)]
            iright = bandwidthInterval[int(1.0)]

            if xs[int(i)] - xs[int(ileft)] > xs[int(iright)] - xs[int(i)]:
              edge = ileft
            else:
              edge = iright

            sumWeights = 0.0
            sumX = 0.0
            sumXSquared = 0.0
            sumY = 0.0
            sumXY = 0.0
            denom = fabs(1.0/(xs[int(edge)] - x))
            k = ileft
            while k <= iright:
              xk = xs[int(k)]
              yk = ys[int(k)]

              if k < i:
                dist = x - xk
              else:
                dist = xk - x

              w = Tricube(dist*denom)*robustnessWeights[int(k)]*weights[int(k)]
              xkw = xk*w
              sumWeights = sumWeights + w
              sumX = sumX + xkw
              sumXSquared = sumXSquared + xk*xkw
              sumY = sumY + yk*w
              sumXY = sumXY + yk*xkw
              k = k + 1.0
            

            meanX = sumX/sumWeights
            meanY = sumY/sumWeights
            meanXY = sumXY/sumWeights
            meanXSquared = sumXSquared/sumWeights

            if sqrt(fabs(meanXSquared - meanX*meanX)) < accuracy:
              beta = 0.0
            else:
              beta = (meanXY - meanX*meanY)/(meanXSquared - meanX*meanX)

            alpha = meanY - beta*meanX

            res[int(i)] = beta*x + alpha

            residuals[int(i)] = fabs(ys[int(i)] - res[int(i)])
            i = i + 1.0
          

          if iter == robustnessIters:
            done = True

          if  not done :
            sortedResiduals = arraysCopyNumberArray(residuals)
            QuickSortNumbers(sortedResiduals)

            medianResidual = sortedResiduals[int(n/2.0)]

            if fabs(medianResidual) < accuracy:
              done = True

            if  not done :
              i = 0.0
              while i < n:
                arg = residuals[int(i)]/(6.0*medianResidual)
                if arg >= 1.0:
                  robustnessWeights[int(i)] = 0.0
                else:
                  w = 1.0 - arg*arg
                  robustnessWeights[int(i)] = w*w
                i = i + 1.0
              
          iter = iter + 1.0
        

        resultXs.numberArray = res
        success = True
      else:
        success = False
        errorMessage.string = "There must be at least two points."
  else:
    success = False
    errorMessage.string = "There must be equal number of points, and over zero."

  return success

def RearrangeArray(asx, indexes):

  bs =  [None]*int(len(asx))

  AssignNumberArray(bs, asx)

  i = 0.0
  while i < len(indexes):
    asx[int(i)] = bs[int(indexes[int(i)])]
    i = i + 1.0
  

  bs = None

def AssignNumberArray(asx, bs):

  i = 0.0
  while i < min(len(asx),len(bs)):
    asx[int(i)] = bs[int(i)]
    i = i + 1.0
  

def FindNextNonZeroElement(array, offset):

  done = False
  position = offset + 1.0
  while position < len(array) and  not done :
    if array[int(position)] != 0.0:
      done = True
    position = position + 1.0
  

  return position

def Tricube(x):

  ax = fabs(x)

  if ax >= 1.0:
    result = 0.0
  else:
    result = 1.0 - ax*ax*ax
    result = result*result*result

  return result

def CropLineWithinBoundary(x1Ref, y1Ref, x2Ref, y2Ref, xMin, xMax, yMin, yMax):

  x1 = x1Ref.numberValue
  y1 = y1Ref.numberValue
  x2 = x2Ref.numberValue
  y2 = y2Ref.numberValue

  p1In = x1 >= xMin and x1 <= xMax and y1 >= yMin and y1 <= yMax
  p2In = x2 >= xMin and x2 <= xMax and y2 >= yMin and y2 <= yMax

  if p1In and p2In:
    success = True
  elif  not p1In  and p2In:
    dx = x1 - x2
    dy = y1 - y2

    if dx != 0.0:
      f1 = (xMin - x2)/dx
      f2 = (xMax - x2)/dx
    else:
      f1 = 1.0
      f2 = 1.0
    if dy != 0.0:
      f3 = (yMin - y2)/dy
      f4 = (yMax - y2)/dy
    else:
      f3 = 1.0
      f4 = 1.0

    if f1 < 0.0:
      f1 = 1.0
    if f2 < 0.0:
      f2 = 1.0
    if f3 < 0.0:
      f3 = 1.0
    if f4 < 0.0:
      f4 = 1.0

    f = min(f1,min(f2,min(f3,f4)))

    x1 = x2 + f*dx
    y1 = y2 + f*dy

    success = True
  elif p1In and  not p2In :
    dx = x2 - x1
    dy = y2 - y1

    if dx != 0.0:
      f1 = (xMin - x1)/dx
      f2 = (xMax - x1)/dx
    else:
      f1 = 1.0
      f2 = 1.0
    if dy != 0.0:
      f3 = (yMin - y1)/dy
      f4 = (yMax - y1)/dy
    else:
      f3 = 1.0
      f4 = 1.0

    if f1 < 0.0:
      f1 = 1.0
    if f2 < 0.0:
      f2 = 1.0
    if f3 < 0.0:
      f3 = 1.0
    if f4 < 0.0:
      f4 = 1.0

    f = min(f1,min(f2,min(f3,f4)))

    x2 = x1 + f*dx
    y2 = y1 + f*dy

    success = True
  else:
    success = False

  x1Ref.numberValue = x1
  y1Ref.numberValue = y1
  x2Ref.numberValue = x2
  y2Ref.numberValue = y2

  return success

def IncrementFromCoordinates(x1, y1, x2, y2):
  return (x2 - x1)/(y2 - y1)

def InterceptFromCoordinates(x1, y1, x2, y2):

  a = IncrementFromCoordinates(x1, y1, x2, y2)
  b = y1 - a*x1

  return b

def Get8HighContrastColors():
  colors =  [None]*int(8.0)
  colors[int(0.0)] = CreateRGBColor(3.0/256.0, 146.0/256.0, 206.0/256.0)
  colors[int(1.0)] = CreateRGBColor(253.0/256.0, 83.0/256.0, 8.0/256.0)
  colors[int(2.0)] = CreateRGBColor(102.0/256.0, 176.0/256.0, 50.0/256.0)
  colors[int(3.0)] = CreateRGBColor(208.0/256.0, 234.0/256.0, 43.0/256.0)
  colors[int(4.0)] = CreateRGBColor(167.0/256.0, 25.0/256.0, 75.0/256.0)
  colors[int(5.0)] = CreateRGBColor(254.0/256.0, 254.0/256.0, 51.0/256.0)
  colors[int(6.0)] = CreateRGBColor(134.0/256.0, 1.0/256.0, 175.0/256.0)
  colors[int(7.0)] = CreateRGBColor(251.0/256.0, 153.0/256.0, 2.0/256.0)
  return colors

def DrawFilledRectangleWithBorder(image, x, y, w, h, borderColor, fillColor):
  if h > 0.0 and w > 0.0:
    DrawFilledRectangle(image, x, y, w, h, fillColor)
    DrawRectangle1px(image, x, y, w, h, borderColor)

def CreateRGBABitmapImageReference():

  reference = RGBABitmapImageReference()
  reference.image = RGBABitmapImage()
  reference.image.x =  [None]*int(0.0)

  return reference

def RectanglesOverlap(r1, r2):

  overlap = False

  overlap = overlap or (r2.x1 >= r1.x1 and r2.x1 <= r1.x2 and r2.y1 >= r1.y1 and r2.y1 <= r1.y2)
  overlap = overlap or (r2.x2 >= r1.x1 and r2.x2 <= r1.x2 and r2.y1 >= r1.y1 and r2.y1 <= r1.y2)
  overlap = overlap or (r2.x1 >= r1.x1 and r2.x1 <= r1.x2 and r2.y2 >= r1.y1 and r2.y2 <= r1.y2)
  overlap = overlap or (r2.x2 >= r1.x1 and r2.x2 <= r1.x2 and r2.y2 >= r1.y1 and r2.y2 <= r1.y2)

  return overlap

def CreateRectangle(x1, y1, x2, y2):
  r = Rectangle()
  r.x1 = x1
  r.y1 = y1
  r.x2 = x2
  r.y2 = y2
  return r

def CopyRectangleValues(rd, rs):
  rd.x1 = rs.x1
  rd.y1 = rs.y1
  rd.x2 = rs.x2
  rd.y2 = rs.y2

def DrawXLabelsForPriority(p, xMin, oy, xMax, xPixelMin, xPixelMax, nextRectangle, gridLabelColor, canvas, xGridPositions, xLabels, xLabelPriorities, occupied, textOnBottom):

  r = Rectangle()
  padding = 10.0

  overlap = False
  i = 0.0
  while i < len(xLabels.stringArray):
    if xLabelPriorities.numberArray[int(i)] == p:

      x = xGridPositions[int(i)]
      px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
      text = xLabels.stringArray[int(i)].string

      r.x1 = floor(px - GetTextWidth(text)/2.0)
      if textOnBottom:
        r.y1 = floor(oy + 5.0)
      else:
        r.y1 = floor(oy - 20.0)
      r.x2 = r.x1 + GetTextWidth(text)
      r.y2 = r.y1 + GetTextHeight(text)

      # Add padding
      r.x1 = r.x1 - padding
      r.y1 = r.y1 - padding
      r.x2 = r.x2 + padding
      r.y2 = r.y2 + padding

      currentOverlaps = False

      j = 0.0
      while j < nextRectangle.numberValue:
        currentOverlaps = currentOverlaps or RectanglesOverlap(r, occupied[int(j)])
        j = j + 1.0
      

      if  not currentOverlaps  and p == 1.0:
        DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor)

        CopyRectangleValues(occupied[int(nextRectangle.numberValue)], r)
        nextRectangle.numberValue = nextRectangle.numberValue + 1.0

      overlap = overlap or currentOverlaps
    i = i + 1.0
  
  if  not overlap  and p != 1.0:
    i = 0.0
    while i < len(xGridPositions):
      x = xGridPositions[int(i)]
      px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)

      if xLabelPriorities.numberArray[int(i)] == p:
        text = xLabels.stringArray[int(i)].string

        r.x1 = floor(px - GetTextWidth(text)/2.0)
        if textOnBottom:
          r.y1 = floor(oy + 5.0)
        else:
          r.y1 = floor(oy - 20.0)
        r.x2 = r.x1 + GetTextWidth(text)
        r.y2 = r.y1 + GetTextHeight(text)

        DrawText(canvas, r.x1, r.y1, text, gridLabelColor)

        CopyRectangleValues(occupied[int(nextRectangle.numberValue)], r)
        nextRectangle.numberValue = nextRectangle.numberValue + 1.0
      i = i + 1.0
    

def DrawYLabelsForPriority(p, yMin, ox, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, textOnLeft):

  r = Rectangle()
  padding = 10.0

  overlap = False
  i = 0.0
  while i < len(yLabels.stringArray):
    if yLabelPriorities.numberArray[int(i)] == p:

      y = yGridPositions[int(i)]
      py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
      text = yLabels.stringArray[int(i)].string

      if textOnLeft:
        r.x1 = floor(ox - GetTextWidth(text) - 10.0)
      else:
        r.x1 = floor(ox + 10.0)
      r.y1 = floor(py - 6.0)
      r.x2 = r.x1 + GetTextWidth(text)
      r.y2 = r.y1 + GetTextHeight(text)

      # Add padding
      r.x1 = r.x1 - padding
      r.y1 = r.y1 - padding
      r.x2 = r.x2 + padding
      r.y2 = r.y2 + padding

      currentOverlaps = False

      j = 0.0
      while j < nextRectangle.numberValue:
        currentOverlaps = currentOverlaps or RectanglesOverlap(r, occupied[int(j)])
        j = j + 1.0
      

      # Draw labels with priority 1 if they do not overlap anything else.
      if  not currentOverlaps  and p == 1.0:
        DrawText(canvas, r.x1 + padding, r.y1 + padding, text, gridLabelColor)

        CopyRectangleValues(occupied[int(nextRectangle.numberValue)], r)
        nextRectangle.numberValue = nextRectangle.numberValue + 1.0

      overlap = overlap or currentOverlaps
    i = i + 1.0
  
  if  not overlap  and p != 1.0:
    i = 0.0
    while i < len(yGridPositions):
      y = yGridPositions[int(i)]
      py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)

      if yLabelPriorities.numberArray[int(i)] == p:
        text = yLabels.stringArray[int(i)].string

        if textOnLeft:
          r.x1 = floor(ox - GetTextWidth(text) - 10.0)
        else:
          r.x1 = floor(ox + 10.0)
        r.y1 = floor(py - 6.0)
        r.x2 = r.x1 + GetTextWidth(text)
        r.y2 = r.y1 + GetTextHeight(text)

        DrawText(canvas, r.x1, r.y1, text, gridLabelColor)

        CopyRectangleValues(occupied[int(nextRectangle.numberValue)], r)
        nextRectangle.numberValue = nextRectangle.numberValue + 1.0
      i = i + 1.0
    

def ComputeGridLinePositions(cMin, cMax, labels, priorities):

  cLength = cMax - cMin

  p = floor(log10(cLength))
  pInterval = 10.0**p
  # gives 10-1 lines for 100-10 diff
  pMin = ceil(cMin/pInterval)*pInterval
  pMax = floor(cMax/pInterval)*pInterval
  pNum = Round((pMax - pMin)/pInterval + 1.0)

  mode = 1.0

  if pNum <= 3.0:
    p = floor(log10(cLength) - 1.0)
    # gives 100-10 lines for 100-10 diff
    pInterval = 10.0**p
    pMin = ceil(cMin/pInterval)*pInterval
    pMax = floor(cMax/pInterval)*pInterval
    pNum = Round((pMax - pMin)/pInterval + 1.0)

    mode = 4.0
  elif pNum <= 6.0:
    p = floor(log10(cLength))
    pInterval = 10.0**p/4.0
    # gives 40-5 lines for 100-10 diff
    pMin = ceil(cMin/pInterval)*pInterval
    pMax = floor(cMax/pInterval)*pInterval
    pNum = Round((pMax - pMin)/pInterval + 1.0)

    mode = 3.0
  elif pNum <= 10.0:
    p = floor(log10(cLength))
    pInterval = 10.0**p/2.0
    # gives 20-3 lines for 100-10 diff
    pMin = ceil(cMin/pInterval)*pInterval
    pMax = floor(cMax/pInterval)*pInterval
    pNum = Round((pMax - pMin)/pInterval + 1.0)

    mode = 2.0

  positions =  [None]*int(pNum)
  labels.stringArray =  [None]*int(pNum)
  priorities.numberArray =  [None]*int(pNum)

  i = 0.0
  while i < pNum:
    num = pMin + pInterval*i
    positions[int(i)] = num

    # Always print priority 1 labels. Only draw priority 2 if they can all be drawn. Then, only draw priority 3 if they can all be drawn.
    priority = 1.0

    # Prioritize x.25, x.5 and x.75 lower.
    if mode == 2.0 or mode == 3.0:
      rem = fabs(round(num/10.0**(p - 2.0))) % 100.0

      priority = 1.0
      if rem == 50.0:
        priority = 2.0
      elif rem == 25.0 or rem == 75.0:
        priority = 3.0

    # Prioritize x.1-x.4 and x.6-x.9 lower
    if mode == 4.0:
      rem = fabs(Round(num/10.0**p)) % 10.0

      priority = 1.0
      if rem == 1.0 or rem == 2.0 or rem == 3.0 or rem == 4.0 or rem == 6.0 or rem == 7.0 or rem == 8.0 or rem == 9.0:
        priority = 2.0

    # 0 has lowest priority.
    if EpsilonCompare(num, 0.0, 10.0**(p - 5.0)):
      priority = 3.0

    priorities.numberArray[int(i)] = priority

    # The label itself.
    labels.stringArray[int(i)] = StringReference()
    if p < 0.0:
      if mode == 2.0 or mode == 3.0:
        num = RoundToDigits(num,  -(p - 1.0))
      else:
        num = RoundToDigits(num,  -p)
    labels.stringArray[int(i)].string = CreateStringDecimalFromNumber(num)
    i = i + 1.0
  

  return positions

def MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax):

  yLength = yMax - yMin
  yPixelLength = yPixelMax - yPixelMin

  y = y - yMin
  y = y*yPixelLength/yLength
  y = yPixelLength - y
  y = y + yPixelMin
  return y

def MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax):

  xLength = xMax - xMin
  xPixelLength = xPixelMax - xPixelMin

  x = x - xMin
  x = x*xPixelLength/xLength
  x = x + xPixelMin
  return x

def MapXCoordinateAutoSettings(x, image, xs):
  return MapXCoordinate(x, GetMinimum(xs), GetMaximum(xs), GetDefaultPaddingPercentage()*ImageWidth(image), (1.0 - GetDefaultPaddingPercentage())*ImageWidth(image))

def MapYCoordinateAutoSettings(y, image, ys):
  return MapYCoordinate(y, GetMinimum(ys), GetMaximum(ys), GetDefaultPaddingPercentage()*ImageHeight(image), (1.0 - GetDefaultPaddingPercentage())*ImageHeight(image))

def MapXCoordinateBasedOnSettings(x, settings):

  boundaries = Rectangle()
  ComputeBoundariesBasedOnSettings(settings, boundaries)
  xMin = boundaries.x1
  xMax = boundaries.x2

  if settings.autoPadding:
    xPadding = floor(GetDefaultPaddingPercentage()*settings.width)
  else:
    xPadding = settings.xPadding

  xPixelMin = xPadding
  xPixelMax = settings.width - xPadding

  return MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)

def MapYCoordinateBasedOnSettings(y, settings):

  boundaries = Rectangle()
  ComputeBoundariesBasedOnSettings(settings, boundaries)
  yMin = boundaries.y1
  yMax = boundaries.y2

  if settings.autoPadding:
    yPadding = floor(GetDefaultPaddingPercentage()*settings.height)
  else:
    yPadding = settings.yPadding

  yPixelMin = yPadding
  yPixelMax = settings.height - yPadding

  return MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)

def GetDefaultPaddingPercentage():
  return 0.10

def DrawText(canvas, x, y, text, color):

  charWidth = 8.0
  spacing = 2.0

  i = 0.0
  while i < len(text):
    DrawAsciiCharacter(canvas, x + i*(charWidth + spacing), y, text[int(i)], color)
    i = i + 1.0
  

def DrawTextUpwards(canvas, x, y, text, color):

  buffer = CreateImage(GetTextWidth(text), GetTextHeight(text), GetTransparent())
  DrawText(buffer, 0.0, 0.0, text, color)
  rotated = RotateAntiClockwise90Degrees(buffer)
  DrawImageOnImage(canvas, rotated, x, y)
  DeleteImage(buffer)
  DeleteImage(rotated)

def GetDefaultScatterPlotSettings():

  settings = ScatterPlotSettings()

  settings.autoBoundaries = True
  settings.xMax = 0.0
  settings.xMin = 0.0
  settings.yMax = 0.0
  settings.yMin = 0.0
  settings.autoPadding = True
  settings.xPadding = 0.0
  settings.yPadding = 0.0
  settings.title = ""
  settings.xLabel = ""
  settings.yLabel = ""
  settings.scatterPlotSeries =  [None]*int(0.0)
  settings.showGrid = True
  settings.gridColor = GetGray(0.1)
  settings.xAxisAuto = True
  settings.xAxisTop = False
  settings.xAxisBottom = False
  settings.yAxisAuto = True
  settings.yAxisLeft = False
  settings.yAxisRight = False

  return settings

def GetDefaultScatterPlotSeriesSettings():

  series = ScatterPlotSeries()

  series.linearInterpolation = True
  series.pointType = "pixels"
  series.lineType = "solid"
  series.lineThickness = 1.0
  series.xs =  [None]*int(0.0)
  series.ys =  [None]*int(0.0)
  series.color = GetBlack()

  return series

def DrawScatterPlot(canvasReference, width, height, xs, ys, errorMessage):

  settings = GetDefaultScatterPlotSettings()

  settings.width = width
  settings.height = height
  settings.scatterPlotSeries =  [None]*int(1.0)
  settings.scatterPlotSeries[int(0.0)] = GetDefaultScatterPlotSeriesSettings()
  settings.scatterPlotSeries[int(0.0)].xs = None
  settings.scatterPlotSeries[int(0.0)].xs = xs
  settings.scatterPlotSeries[int(0.0)].ys = None
  settings.scatterPlotSeries[int(0.0)].ys = ys

  success = DrawScatterPlotFromSettings(canvasReference, settings, errorMessage)

  return success

def DrawScatterPlotFromSettings(canvasReference, settings, errorMessage):

  canvas = CreateImage(settings.width, settings.height, GetWhite())
  patternOffset = CreateNumberReference(0.0)

  success = ScatterPlotFromSettingsValid(settings, errorMessage)

  if success:

    boundaries = Rectangle()
    ComputeBoundariesBasedOnSettings(settings, boundaries)
    xMin = boundaries.x1
    yMin = boundaries.y1
    xMax = boundaries.x2
    yMax = boundaries.y2

    # If zero, set to defaults.
    if xMin - xMax == 0.0:
      xMin = 0.0
      xMax = 10.0

    if yMin - yMax == 0.0:
      yMin = 0.0
      yMax = 10.0

    xLength = xMax - xMin
    yLength = yMax - yMin

    if settings.autoPadding:
      xPadding = floor(GetDefaultPaddingPercentage()*settings.width)
      yPadding = floor(GetDefaultPaddingPercentage()*settings.height)
    else:
      xPadding = settings.xPadding
      yPadding = settings.yPadding

    # Draw title
    DrawText(canvas, floor(settings.width/2.0 - GetTextWidth(settings.title)/2.0), floor(yPadding/3.0), settings.title, GetBlack())

    # Draw grid
    xPixelMin = xPadding
    yPixelMin = yPadding
    xPixelMax = settings.width - xPadding
    yPixelMax = settings.height - yPadding
    xLengthPixels = xPixelMax - xPixelMin
    yLengthPixels = yPixelMax - yPixelMin
    DrawRectangle1px(canvas, xPixelMin, yPixelMin, xLengthPixels, yLengthPixels, settings.gridColor)

    gridLabelColor = GetGray(0.5)

    xLabels = StringArrayReference()
    xLabelPriorities = NumberArrayReference()
    yLabels = StringArrayReference()
    yLabelPriorities = NumberArrayReference()
    xGridPositions = ComputeGridLinePositions(xMin, xMax, xLabels, xLabelPriorities)
    yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities)

    if settings.showGrid:
      # X-grid
      i = 0.0
      while i < len(xGridPositions):
        x = xGridPositions[int(i)]
        px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
        DrawLine1px(canvas, px, yPixelMin, px, yPixelMax, settings.gridColor)
        i = i + 1.0
      

      # Y-grid
      i = 0.0
      while i < len(yGridPositions):
        y = yGridPositions[int(i)]
        py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
        DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
        i = i + 1.0
      

    # Compute origin information.
    originYInside = yMin < 0.0 and yMax > 0.0
    originY = 0.0
    if settings.xAxisAuto:
      if originYInside:
        originY = 0.0
      else:
        originY = yMin
    else:
      if settings.xAxisTop:
        originY = yMax
      if settings.xAxisBottom:
        originY = yMin
    originYPixels = MapYCoordinate(originY, yMin, yMax, yPixelMin, yPixelMax)

    originXInside = xMin < 0.0 and xMax > 0.0
    originX = 0.0
    if settings.yAxisAuto:
      if originXInside:
        originX = 0.0
      else:
        originX = xMin
    else:
      if settings.yAxisLeft:
        originX = xMin
      if settings.yAxisRight:
        originX = xMax
    originXPixels = MapXCoordinate(originX, xMin, xMax, xPixelMin, xPixelMax)

    if originYInside:
      originTextY = 0.0
    else:
      originTextY = yMin + yLength/2.0
    originTextYPixels = MapYCoordinate(originTextY, yMin, yMax, yPixelMin, yPixelMax)

    if originXInside:
      originTextX = 0.0
    else:
      originTextX = xMin + xLength/2.0
    originTextXPixels = MapXCoordinate(originTextX, xMin, xMax, xPixelMin, xPixelMax)

    # Labels
    occupied =  [None]*int(len(xLabels.stringArray) + len(yLabels.stringArray))
    i = 0.0
    while i < len(occupied):
      occupied[int(i)] = CreateRectangle(0.0, 0.0, 0.0, 0.0)
      i = i + 1.0
    
    nextRectangle = CreateNumberReference(0.0)

    # x labels
    i = 1.0
    while i <= 5.0:
      textOnBottom = True
      if  not settings.xAxisAuto  and settings.xAxisTop:
        textOnBottom = False
      DrawXLabelsForPriority(i, xMin, originYPixels, xMax, xPixelMin, xPixelMax, nextRectangle, gridLabelColor, canvas, xGridPositions, xLabels, xLabelPriorities, occupied, textOnBottom)
      i = i + 1.0
    

    # y labels
    i = 1.0
    while i <= 5.0:
      textOnLeft = True
      if  not settings.yAxisAuto  and settings.yAxisRight:
        textOnLeft = False
      DrawYLabelsForPriority(i, yMin, originXPixels, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, textOnLeft)
      i = i + 1.0
    

    # Draw origin line axis titles.
    axisLabelPadding = 20.0

    # x origin line
    if originYInside:
      DrawLine1px(canvas, Round(xPixelMin), Round(originYPixels), Round(xPixelMax), Round(originYPixels), GetBlack())

    # y origin line
    if originXInside:
      DrawLine1px(canvas, Round(originXPixels), Round(yPixelMin), Round(originXPixels), Round(yPixelMax), GetBlack())

    # Draw origin axis titles.
    DrawTextUpwards(canvas, 10.0, floor(originTextYPixels - GetTextWidth(settings.yLabel)/2.0), settings.yLabel, GetBlack())
    DrawText(canvas, floor(originTextXPixels - GetTextWidth(settings.xLabel)/2.0), yPixelMax + axisLabelPadding, settings.xLabel, GetBlack())

    # X-grid-markers
    i = 0.0
    while i < len(xGridPositions):
      x = xGridPositions[int(i)]
      px = MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax)
      p = xLabelPriorities.numberArray[int(i)]
      l = 1.0
      if p == 1.0:
        l = 8.0
      elif p == 2.0:
        l = 3.0
      side =  -1.0
      if  not settings.xAxisAuto  and settings.xAxisTop:
        side = 1.0
      DrawLine1px(canvas, px, originYPixels, px, originYPixels + side*l, GetBlack())
      i = i + 1.0
    

    # Y-grid-markers
    i = 0.0
    while i < len(yGridPositions):
      y = yGridPositions[int(i)]
      py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
      p = yLabelPriorities.numberArray[int(i)]
      l = 1.0
      if p == 1.0:
        l = 8.0
      elif p == 2.0:
        l = 3.0
      side = 1.0
      if  not settings.yAxisAuto  and settings.yAxisRight:
        side =  -1.0
      DrawLine1px(canvas, originXPixels, py, originXPixels + side*l, py, GetBlack())
      i = i + 1.0
    

    # Draw points
    plot = 0.0
    while plot < len(settings.scatterPlotSeries):
      sp = settings.scatterPlotSeries[int(plot)]

      xs = sp.xs
      ys = sp.ys
      linearInterpolation = sp.linearInterpolation

      x1Ref = NumberReference()
      y1Ref = NumberReference()
      x2Ref = NumberReference()
      y2Ref = NumberReference()
      if linearInterpolation:
        prevSet = False
        xPrev = 0.0
        yPrev = 0.0
        i = 0.0
        while i < len(xs):
          x = xs[int(i)]
          y = ys[int(i)]

          if prevSet:
            x1Ref.numberValue = xPrev
            y1Ref.numberValue = yPrev
            x2Ref.numberValue = x
            y2Ref.numberValue = y

            success = CropLineWithinBoundary(x1Ref, y1Ref, x2Ref, y2Ref, xMin, xMax, yMin, yMax)

            if success:
              pxPrev = floor(MapXCoordinate(x1Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax))
              pyPrev = floor(MapYCoordinate(y1Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax))
              px = floor(MapXCoordinate(x2Ref.numberValue, xMin, xMax, xPixelMin, xPixelMax))
              py = floor(MapYCoordinate(y2Ref.numberValue, yMin, yMax, yPixelMin, yPixelMax))

              if arraysStringsEqual(sp.lineType, "solid") and sp.lineThickness == 1.0:
                DrawLine1px(canvas, pxPrev, pyPrev, px, py, sp.color)
              elif arraysStringsEqual(sp.lineType, "solid"):
                DrawLine(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, sp.color)
              elif arraysStringsEqual(sp.lineType, "dashed"):
                linePattern = GetLinePattern1()
                DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
              elif arraysStringsEqual(sp.lineType, "dotted"):
                linePattern = GetLinePattern2()
                DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
              elif arraysStringsEqual(sp.lineType, "dotdash"):
                linePattern = GetLinePattern3()
                DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
              elif arraysStringsEqual(sp.lineType, "longdash"):
                linePattern = GetLinePattern4()
                DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)
              elif arraysStringsEqual(sp.lineType, "twodash"):
                linePattern = GetLinePattern5()
                DrawLineBresenhamsAlgorithmThickPatterned(canvas, pxPrev, pyPrev, px, py, sp.lineThickness, linePattern, patternOffset, sp.color)

          prevSet = True
          xPrev = x
          yPrev = y
          i = i + 1.0
        
      else:
        i = 0.0
        while i < len(xs):
          x = xs[int(i)]
          y = ys[int(i)]

          if x > xMin and x < xMax and y > yMin and y < yMax:

            x = floor(MapXCoordinate(x, xMin, xMax, xPixelMin, xPixelMax))
            y = floor(MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax))

            if arraysStringsEqual(sp.pointType, "crosses"):
              DrawPixel(canvas, x, y, sp.color)
              DrawPixel(canvas, x + 1.0, y, sp.color)
              DrawPixel(canvas, x + 2.0, y, sp.color)
              DrawPixel(canvas, x - 1.0, y, sp.color)
              DrawPixel(canvas, x - 2.0, y, sp.color)
              DrawPixel(canvas, x, y + 1.0, sp.color)
              DrawPixel(canvas, x, y + 2.0, sp.color)
              DrawPixel(canvas, x, y - 1.0, sp.color)
              DrawPixel(canvas, x, y - 2.0, sp.color)
            elif arraysStringsEqual(sp.pointType, "circles"):
              DrawCircle(canvas, x, y, 3.0, sp.color)
            elif arraysStringsEqual(sp.pointType, "dots"):
              DrawFilledCircle(canvas, x, y, 3.0, sp.color)
            elif arraysStringsEqual(sp.pointType, "triangles"):
              DrawTriangle(canvas, x, y, 3.0, sp.color)
            elif arraysStringsEqual(sp.pointType, "filled triangles"):
              DrawFilledTriangle(canvas, x, y, 3.0, sp.color)
            elif arraysStringsEqual(sp.pointType, "pixels"):
              DrawPixel(canvas, x, y, sp.color)
            elif arraysStringsEqual(sp.pointType, "dotlinetoxaxis"):
              DrawFilledCircle(canvas, x, y, 3.0, sp.color)
              yaxis = floor(MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax))
              yaxis = min(max(yaxis,yPixelMin),yPixelMax)
              DrawLine(canvas, x, y, x, yaxis, sp.lineThickness, sp.color)
          i = i + 1.0
        
      plot = plot + 1.0
    

    canvasReference.image = canvas

  return success

def ComputeBoundariesBasedOnSettings(settings, boundaries):

  if len(settings.scatterPlotSeries) >= 1.0:
    xMin = GetMinimum(settings.scatterPlotSeries[int(0.0)].xs)*1.05
    xMax = GetMaximum(settings.scatterPlotSeries[int(0.0)].xs)*1.05
    yMin = GetMinimum(settings.scatterPlotSeries[int(0.0)].ys)*1.05
    yMax = GetMaximum(settings.scatterPlotSeries[int(0.0)].ys)*1.05
  else:
    xMin =  -10.0
    xMax = 10.0
    yMin =  -10.0
    yMax = 10.0

  if  not settings.autoBoundaries :
    xMin = settings.xMin
    xMax = settings.xMax
    yMin = settings.yMin
    yMax = settings.yMax
  else:
    plot = 1.0
    while plot < len(settings.scatterPlotSeries):
      sp = settings.scatterPlotSeries[int(plot)]

      xMin = min(xMin,GetMinimum(sp.xs))
      xMax = max(xMax,GetMaximum(sp.xs))
      yMin = min(yMin,GetMinimum(sp.ys))
      yMax = max(yMax,GetMaximum(sp.ys))
      plot = plot + 1.0
    

  boundaries.x1 = xMin
  boundaries.y1 = yMin
  boundaries.x2 = xMax
  boundaries.y2 = yMax

def ScatterPlotFromSettingsValid(settings, errorMessage):

  success = True

  # Check axis placement.
  if  not settings.xAxisAuto :
    if settings.xAxisTop and settings.xAxisBottom:
      success = False
      errorMessage.string = "x-axis not automatic and configured to be both on top and on bottom."
    if  not settings.xAxisTop  and  not settings.xAxisBottom :
      success = False
      errorMessage.string = "x-axis not automatic and configured to be neither on top nor on bottom."

  if  not settings.yAxisAuto :
    if settings.yAxisLeft and settings.yAxisRight:
      success = False
      errorMessage.string = "y-axis not automatic and configured to be both on top and on bottom."
    if  not settings.yAxisLeft  and  not settings.yAxisRight :
      success = False
      errorMessage.string = "y-axis not automatic and configured to be neither on top nor on bottom."

  # Check series lengths.
  i = 0.0
  while i < len(settings.scatterPlotSeries):
    series = settings.scatterPlotSeries[int(i)]
    if len(series.xs) != len(series.ys):
      success = False
      errorMessage.string = "x and y series must be of the same length."
    if len(series.xs) == 0.0:
      success = False
      errorMessage.string = "There must be data in the series to be plotted."
    if series.linearInterpolation and len(series.xs) == 1.0:
      success = False
      errorMessage.string = "Linear interpolation requires at least two data points to be plotted."
    i = i + 1.0
  

  # Check bounds.
  if  not settings.autoBoundaries :
    if settings.xMin >= settings.xMax:
      success = False
      errorMessage.string = "x min is higher than or equal to x max."
    if settings.yMin >= settings.yMax:
      success = False
      errorMessage.string = "y min is higher than or equal to y max."

  # Check padding.
  if  not settings.autoPadding :
    if 2.0*settings.xPadding >= settings.width:
      success = False
      errorMessage.string = "The x padding is more then the width."
    if 2.0*settings.yPadding >= settings.height:
      success = False
      errorMessage.string = "The y padding is more then the height."

  # Check width and height.
  if settings.width < 0.0:
    success = False
    errorMessage.string = "The width is less than 0."
  if settings.height < 0.0:
    success = False
    errorMessage.string = "The height is less than 0."

  # Check point types.
  i = 0.0
  while i < len(settings.scatterPlotSeries):
    series = settings.scatterPlotSeries[int(i)]

    if series.lineThickness < 0.0:
      success = False
      errorMessage.string = "The line thickness is less than 0."

    if  not series.linearInterpolation :
      # Point type.
      found = False
      if arraysStringsEqual(series.pointType, "crosses"):
        found = True
      elif arraysStringsEqual(series.pointType, "circles"):
        found = True
      elif arraysStringsEqual(series.pointType, "dots"):
        found = True
      elif arraysStringsEqual(series.pointType, "triangles"):
        found = True
      elif arraysStringsEqual(series.pointType, "filled triangles"):
        found = True
      elif arraysStringsEqual(series.pointType, "pixels"):
        found = True
      elif arraysStringsEqual(series.pointType, "dotlinetoxaxis"):
        found = True
      if  not found :
        success = False
        errorMessage.string = "The point type is unknown."
    else:
      # Line type.
      found = False
      if arraysStringsEqual(series.lineType, "solid"):
        found = True
      elif arraysStringsEqual(series.lineType, "dashed"):
        found = True
      elif arraysStringsEqual(series.lineType, "dotted"):
        found = True
      elif arraysStringsEqual(series.lineType, "dotdash"):
        found = True
      elif arraysStringsEqual(series.lineType, "longdash"):
        found = True
      elif arraysStringsEqual(series.lineType, "twodash"):
        found = True

      if  not found :
        success = False
        errorMessage.string = "The line type is unknown."
    i = i + 1.0
  

  return success

def GetDefaultBarPlotSettings():

  settings = BarPlotSettings()

  settings.width = 800.0
  settings.height = 600.0
  settings.autoBoundaries = True
  settings.yMax = 0.0
  settings.yMin = 0.0
  settings.autoPadding = True
  settings.xPadding = 0.0
  settings.yPadding = 0.0
  settings.title = ""
  settings.yLabel = ""
  settings.barPlotSeries =  [None]*int(0.0)
  settings.showGrid = True
  settings.gridColor = GetGray(0.1)
  settings.autoColor = True
  settings.grayscaleAutoColor = False
  settings.autoSpacing = True
  settings.groupSeparation = 0.0
  settings.barSeparation = 0.0
  settings.autoLabels = True
  settings.xLabels =  [None]*int(0.0)
  #settings.autoLabels = false;
  #        settings.xLabels = new StringReference [5];
  #        settings.xLabels[0] = CreateStringReference("may 20".toCharArray());
  #        settings.xLabels[1] = CreateStringReference("jun 20".toCharArray());
  #        settings.xLabels[2] = CreateStringReference("jul 20".toCharArray());
  #        settings.xLabels[3] = CreateStringReference("aug 20".toCharArray());
  #        settings.xLabels[4] = CreateStringReference("sep 20".toCharArray());
  settings.barBorder = False

  return settings

def GetDefaultBarPlotSeriesSettings():

  series = BarPlotSeries()

  series.ys =  [None]*int(0.0)
  series.color = GetBlack()

  return series

def DrawBarPlotNoErrorCheck(width, height, ys):

  errorMessage = StringReference()
  canvasReference = CreateRGBABitmapImageReference()

  success = DrawBarPlot(canvasReference, width, height, ys, errorMessage)

  FreeStringReference(errorMessage)

  return canvasReference.image

def DrawBarPlot(canvasReference, width, height, ys, errorMessage):

  errorMessage = StringReference()
  settings = GetDefaultBarPlotSettings()

  settings.barPlotSeries =  [None]*int(1.0)
  settings.barPlotSeries[int(0.0)] = GetDefaultBarPlotSeriesSettings()
  settings.barPlotSeries[int(0.0)].ys = None
  settings.barPlotSeries[int(0.0)].ys = ys
  settings.width = width
  settings.height = height

  success = DrawBarPlotFromSettings(canvasReference, settings, errorMessage)

  return success

def DrawBarPlotFromSettings(canvasReference, settings, errorMessage):

  success = BarPlotSettingsIsValid(settings, errorMessage)

  if success:
    canvas = CreateImage(settings.width, settings.height, GetWhite())

    ss = len(settings.barPlotSeries)
    gridLabelColor = GetGray(0.5)

    # padding
    if settings.autoPadding:
      xPadding = floor(GetDefaultPaddingPercentage()*ImageWidth(canvas))
      yPadding = floor(GetDefaultPaddingPercentage()*ImageHeight(canvas))
    else:
      xPadding = settings.xPadding
      yPadding = settings.yPadding

    # Draw title
    DrawText(canvas, floor(ImageWidth(canvas)/2.0 - GetTextWidth(settings.title)/2.0), floor(yPadding/3.0), settings.title, GetBlack())
    DrawTextUpwards(canvas, 10.0, floor(ImageHeight(canvas)/2.0 - GetTextWidth(settings.yLabel)/2.0), settings.yLabel, GetBlack())

    # min and max
    if settings.autoBoundaries:
      if ss >= 1.0:
        yMax = GetMaximum(settings.barPlotSeries[int(0.0)].ys)*1.05
        yMin = min(0.0,GetMinimum(settings.barPlotSeries[int(0.0)].ys))*1.05

        s = 0.0
        while s < ss:
          yMax = max(yMax,GetMaximum(settings.barPlotSeries[int(s)].ys))
          yMin = min(yMin,GetMinimum(settings.barPlotSeries[int(s)].ys))
          s = s + 1.0
        
      else:
        yMax = 10.0
        yMin = 0.0
    else:
      yMin = settings.yMin
      yMax = settings.yMax

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
    yLabels = StringArrayReference()
    yLabelPriorities = NumberArrayReference()
    yGridPositions = ComputeGridLinePositions(yMin, yMax, yLabels, yLabelPriorities)

    if settings.showGrid:
      # Y-grid
      i = 0.0
      while i < len(yGridPositions):
        y = yGridPositions[int(i)]
        py = MapYCoordinate(y, yMin, yMax, yPixelMin, yPixelMax)
        DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)
        i = i + 1.0
      

    # Draw origin.
    if yMin < 0.0 and yMax > 0.0:
      py = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)
      DrawLine1px(canvas, xPixelMin, py, xPixelMax, py, settings.gridColor)

    # Labels
    occupied =  [None]*int(len(yLabels.stringArray))
    i = 0.0
    while i < len(occupied):
      occupied[int(i)] = CreateRectangle(0.0, 0.0, 0.0, 0.0)
      i = i + 1.0
    
    nextRectangle = CreateNumberReference(0.0)

    i = 1.0
    while i <= 5.0:
      DrawYLabelsForPriority(i, yMin, xPixelMin, yMax, yPixelMin, yPixelMax, nextRectangle, gridLabelColor, canvas, yGridPositions, yLabels, yLabelPriorities, occupied, True)
      i = i + 1.0
    

    # Draw bars.
    if settings.autoColor:
      if  not settings.grayscaleAutoColor :
        colors = Get8HighContrastColors()
      else:
        colors =  [None]*int(ss)
        if ss > 1.0:
          i = 0.0
          while i < ss:
            colors[int(i)] = GetGray(0.7 - (i/ss)*0.7)
            i = i + 1.0
          
        else:
          colors[int(0.0)] = GetGray(0.5)
    else:
      colors =  [None]*int(0.0)

    # distances
    bs = len(settings.barPlotSeries[int(0.0)].ys)

    if settings.autoSpacing:
      groupSeparation = ImageWidth(canvas)*0.05
      barSeparation = ImageWidth(canvas)*0.005
    else:
      groupSeparation = settings.groupSeparation
      barSeparation = settings.barSeparation

    barWidth = (xLengthPixels - groupSeparation*(bs - 1.0) - barSeparation*(bs*(ss - 1.0)))/(bs*ss)

    # Draw bars.
    b = 0.0
    n = 0.0
    while n < bs:
      s = 0.0
      while s < ss:
        ys = settings.barPlotSeries[int(s)].ys

        yValue = ys[int(n)]

        yBottom = MapYCoordinate(yValue, yMin, yMax, yPixelMin, yPixelMax)
        yTop = MapYCoordinate(0.0, yMin, yMax, yPixelMin, yPixelMax)

        x = xPixelMin + n*(groupSeparation + ss*barWidth) + s*(barWidth) + b*barSeparation
        w = barWidth

        if yValue >= 0.0:
          y = yBottom
          h = yTop - y
        else:
          y = yTop
          h = yBottom - yTop

        # Cut at boundaries.
        if y < yPixelMin and y + h > yPixelMax:
          y = yPixelMin
          h = yPixelMax - yPixelMin
        elif y < yPixelMin:
          y = yPixelMin
          if yValue >= 0.0:
            h = yTop - y
          else:
            h = yBottom - y
        elif y + h > yPixelMax:
          h = yPixelMax - y

        # Get color
        if settings.autoColor:
          barColor = colors[int(s)]
        else:
          barColor = settings.barPlotSeries[int(s)].color

        # Draw
        if settings.barBorder:
          DrawFilledRectangleWithBorder(canvas, Round(x), Round(y), Round(w), Round(h), GetBlack(), barColor)
        else:
          DrawFilledRectangle(canvas, Round(x), Round(y), Round(w), Round(h), barColor)

        b = b + 1.0
        s = s + 1.0
      
      b = b - 1.0
      n = n + 1.0
    

    # x-labels
    n = 0.0
    while n < bs:
      if settings.autoLabels:
        label = CreateStringDecimalFromNumber(n + 1.0)
      else:
        label = settings.xLabels[int(n)].string

      textwidth = GetTextWidth(label)

      x = xPixelMin + (n + 0.5)*(ss*barWidth + (ss - 1.0)*barSeparation) + n*groupSeparation - textwidth/2.0

      DrawText(canvas, floor(x), ImageHeight(canvas) - yPadding + 20.0, label, gridLabelColor)

      b = b + 1.0
      n = n + 1.0
    

    canvasReference.image = canvas

  return success

def BarPlotSettingsIsValid(settings, errorMessage):

  success = True

  # Check series lengths.
  lengthSet = False
  length = 0.0
  i = 0.0
  while i < len(settings.barPlotSeries):
    series = settings.barPlotSeries[int(i)]

    if  not lengthSet :
      length = len(series.ys)
      lengthSet = True
    elif length != len(series.ys):
      success = False
      errorMessage.string = "The number of data points must be equal for all series."
    i = i + 1.0
  

  # Check bounds.
  if  not settings.autoBoundaries :
    if settings.yMin >= settings.yMax:
      success = False
      errorMessage.string = "Minimum y lower than maximum y."

  # Check padding.
  if  not settings.autoPadding :
    if 2.0*settings.xPadding >= settings.width:
      success = False
      errorMessage.string = "Double the horizontal padding is larger than or equal to the width."
    if 2.0*settings.yPadding >= settings.height:
      success = False
      errorMessage.string = "Double the vertical padding is larger than or equal to the height."

  # Check width and height.
  if settings.width < 0.0:
    success = False
    errorMessage.string = "Width lower than zero."
  if settings.height < 0.0:
    success = False
    errorMessage.string = "Height lower than zero."

  # Check spacing
  if  not settings.autoSpacing :
    if settings.groupSeparation < 0.0:
      success = False
      errorMessage.string = "Group separation lower than zero."
    if settings.barSeparation < 0.0:
      success = False
      errorMessage.string = "Bar separation lower than zero."

  return success

def GetMinimum(data):

  minimum = data[int(0.0)]
  i = 0.0
  while i < len(data):
    minimum = min(minimum,data[int(i)])
    i = i + 1.0
  

  return minimum

def GetMaximum(data):

  maximum = data[int(0.0)]
  i = 0.0
  while i < len(data):
    maximum = max(maximum,data[int(i)])
    i = i + 1.0
  

  return maximum

def BinomialDensity(x, size, p):
  return Combinations(size, x)*p**x*(1.0 - p)**(size - x)

def BinomialRandom(prg, n, size, p):

  ns =  [None]*int(n)

  i = 0.0
  while i < n:
    c = 0.0

    j = 0.0
    while j < size:
      nr = PseudorandomNextNumber(prg)
      if nr < p:
        c = c + 1.0
      j = j + 1.0
    

    ns[int(i)] = c
    i = i + 1.0
  

  return ns

def BinomialProbability(x, size, prob):

  sum = 0.0
  i = 0.0
  while i <= x:
    sum = sum + BinomialDensity(i, size, prob)
    i = i + 1.0
  

  return sum

def BinomialQuantile(u, size, prob):

  sum = 0.0
  done = False
  i = 0.0
  while i <= size and  not done :
    sum = sum + BinomialDensity(i, size, prob)
    if sum > u:
      done = True
    i = i + 1.0
  

  return i - 1.0

def NormalDensity(x, mu, sd):
  return 1.0/(sqrt(2.0*pi)*sd)*exp( -((x - mu)**2.0/(2.0*sd**2.0)))

def NormalRandom(prg, n, mean, sd):

  ns =  [None]*int(n)

  i = 0.0
  while i < n:
    nr = PseudorandomNextNumber(prg)
    ns[int(i)] = NormalQuantile(nr, mean, sd)
    i = i + 1.0
  

  return ns

def NormalProbability(q, mean, sd):
  return NormalProbabilityMethod2(q, mean, sd)

def NormalProbabilityMethod1(q, mean, sd):

  q = (q - mean)/sd

  if q < 0.0:
    p = 1.0 - NormalProbabilityMethod1( -q, 0.0, 1.0)
  else:
    c0 = 0.2316419
    c1 = 0.319381530
    c2 =  -0.356563782
    c3 = 1.781477937
    c4 =  -1.821255978
    c5 = 1.330274429

    z = 1.0/(1.0 + c0*q)
    qz = z*(c1 + z*(c2 + z*(c3 + z*(c4 + c5*z))))

    p = 1.0 - qz*NormalDensity(q, 0.0, 1.0)

  return p

def NormalProbabilityMethod2(x, mean, sd):
  return 1.0/2.0*(1.0 + Error((x - mean)/(sd*sqrt(2.0))))

def NormalQuantile(u, mean, sd):
  return NormalQuantileMethod1(u, mean, sd)

def NormalQuantileMethod1(u, mean, sd):

  if u < 1.0/2.0:
    q =  -NormalQuantile(1.0 - u, 0.0, 1.0)
  else:
    z = sqrt( -2.0*log(1.0 - u))
    c0 =  -0.322232431088
    c1 =  -0.342242088547
    c2 =  -0.020423121024
    c3 =  -0.0000453642210148
    c4 = 0.099348462606
    c5 = 0.58858157049
    c6 = 0.531103462366
    c7 = 0.10353775285
    c8 = 0.0038560700634
    q1z = c0 + z*( -1.0 + z*(c1 + z*(c2 + c3*z)))
    q2z = c4 + z*(c5 + z*(c6 + z*(c7 + c8*z)))
    q = z + q1z/q2z

  q = mean + q*sd

  return q

def NormalQuantileMethod2(u, mean, sd):
  return mean + sd*sqrt(2.0)*ErrorInverse(2.0*u - 1.0)

def PossionMass(k, lambdax):
  return lambdax**k*exp( -lambdax)/Factorial(k)

def PoissonRandom(prg, n, lambdax):

  ns =  [None]*int(n)

  i = 0.0
  while i < n:
    nr = PseudorandomNextNumber(prg)
    ns[int(i)] = PoissonQuantile(nr, lambdax)
    i = i + 1.0
  

  return ns

def PoissonQuantile(p, lambdax):

  sum = 0.0
  done = False
  i = 0.0
  while i <= lambdax and  not done :
    sum = sum + PossionMass(i, lambdax)
    if sum > p:
      done = True
    i = i + 1.0
  

  return i - 1.0

def PoissonProbability(k, lambdax):

  t = 0.0
  i = 0.0
  while i <= k:
    t = t + lambdax**i/Factorial(i)
    i = i + 1.0
  

  return t/exp(lambdax)

def SampleWithReplacement(prg, k, n):

  ss =  [None]*int(k)

  i = 0.0
  while i < k:
    ss[int(i)] = PseudorandomNextInteger(prg, n)
    i = i + 1.0
  

  return ss

def Sample(prg, k, n):

  ss =  [None]*int(k)
  if n/10.0 < k:
    # If k is relatively high:
    list = RandomPermutation(prg, n)

    ssReference = NumberArrayReference()
    arraysCopyNumberArrayRange(list, 0.0, k, ssReference)
    ss = ssReference.numberArray
    ssReference = None
    list = None
  else:
    # If k is relatively low:
    hasPicked = arraysCreateBooleanArray(n, False)

    i = 0.0
    while i < n:
      next = PseudorandomNextInteger(prg, n)
      if  not hasPicked[int(next)] :
        hasPicked[int(next)] = True
        ss[int(i)] = next
        i = i + 1.0
    

    hasPicked = None

  return ss

def Shuffle(prg, list):
  FisherYatesShuffle(prg, list)

def FisherYatesShuffle(prg, a):

  n = len(a)

  i = 0.0
  while i < n - 2.0:
    j = PseudorandomNextIntegerBetween(prg, i, n)
    arraysSwapElementsOfNumberArray(a, i, j)
    i = i + 1.0
  

def SampleWithReplacementFromArray(prg, a, k):

  source = SampleWithReplacement(prg, k, len(a))

  list =  [None]*int(k)

  i = 0.0
  while i < k:
    list[int(i)] = a[int(source[int(i)])]
    i = i + 1.0
  

  source = None

  return list

def SampleFromArray(prg, a, k):

  source = Sample(prg, k, len(a))

  list =  [None]*int(k)

  i = 0.0
  while i < k:
    list[int(i)] = a[int(source[int(i)])]
    i = i + 1.0
  

  source = None

  return list

def RandomPermutation(prg, n):

  list =  [None]*int(n)

  i = 0.0
  while i < n:
    list[int(i)] = i
    i = i + 1.0
  

  Shuffle(prg, list)

  return list

def StudentTDensity(x, v):
  return Gamma((v + 1.0)/2.0)/(sqrt(v*pi)*Gamma(v/2.0))*(1.0 + x**2.0/v)**( -((v + 1.0)/2.0))

def StudentTProbability(x, v):
  return 1.0/2.0 + x*Gamma((v + 1.0)/2.0)*Hypergeometric(1.0/2.0, (v + 1.0)/2.0, 3.0/2.0,  -x**2.0/v, 50.0, 0.00001)/(sqrt(pi*v)*Gamma(v/2.0))

def StudentTRandom(prg, n, v):

  ns =  [None]*int(n)

  i = 0.0
  while i < n:
    nr = PseudorandomNextNumber(prg)
    ns[int(i)] = StudentTQuantile(nr, v)
    i = i + 1.0
  

  return ns

def StudentTQuantile(p, v):

  if v == 1.0:
    q = tan(pi*(p - 1.0/2.0))
  elif v == 2.0:
    a = 4.0*p*(1.0 - p)
    q = (2.0*p - 1.0)*sqrt(2.0/a)
  elif v == 4.0:
    a = 4.0*p*(1.0 - p)
    q = cos(1.0/3.0*acos(sqrt(a)))/sqrt(a)
    q = Sign(p - 1.0/2.0)*2.0*sqrt(q - 1.0)
  elif DivisibleBy(v, 2.0):
    q = ChengFuStudentTQuantileAlgorithm(p, v)
  else:
    q = HillsAlgorithm396(p, v)

  return q

def ChengFuStudentTQuantileAlgorithm(p, v):

  k = ceil(v/2.0)
  a = 1.0 - p

  if a != 0.5:
    qi = sqrt(2.0*(1.0 - 2.0*a)**2.0/(1.0 - (1.0 - 2.0*a)**2.0))

    i = 0.0
    while i < 20.0:
      gy = 0.0
      j = 0.0
      while j <= k - 1.0:
        gy = gy + Factorial(2.0*j)/2.0**(2.0*j)/Factorial(j)**2.0*(1.0 + qi**2.0/(2.0*k))**( -j)
        j = j + 1.0
      

      qip1 = 1.0/sqrt(1.0/(2.0*k)*((gy/(1.0 - 2.0*a))**2.0 - 1.0))

      qi = qip1
      i = i + 1.0
    

    if a > 0.5:
      q =  -qi
    else:
      q = qi
  else:
    q = 0.0
  return q

def HillsAlgorithm396(p, v):

  if p > 0.5:
    negate = False
    z = 2.0*(1.0 - p)
  else:
    negate = True
    z = 2.0*p

  a = 1.0/(v - 0.5)
  b = 48.0/(a*a)
  c = ((20700.0*a/b - 98.0)*a - 16.0)*a + 96.36
  d = ((94.5/(b + c) - 3.0)/b + 1.0)*sqrt(a*pi/2.0)*v
  x = z*d
  y = x**(2.0/v)

  if y > 0.05 + a:
    x = NormalQuantile(z*0.5, 0.0, 1.0)
    y = x*x
    if v < 5.0:
      c = c + 0.3*(v - 4.5)*(x + 0.6)
    c = c + (((0.05*d*x - 5.0)*x - 7.0)*x - 2.0)*x + b
    y = (((((0.4*y + 6.3)*y + 36.0)*y + 94.5)/c - y - 3.0)/b + 1.0)*x
    y = a*y*y
    if y > 0.002:
      y = exp(y) - 1.0
    else:
      y = y + 0.5*y*y
  else:
    y = ((1.0/(((v + 6.0)/(v*y) - 0.089*d - 0.822)*(v + 2.0)*3.0) + 0.5/(v + 4.0))*y - 1.0)*(v + 1.0)/(v + 2.0) + 1.0/y

  q = sqrt(v*y)

  if negate:
    q =  -q

  return q

def Mean(list):

  sum = 0.0
  i = 0.0
  while i < len(list):
    sum = sum + list[int(i)]
    i = i + 1.0
  

  return sum/len(list)

def MeanOfRows(list):

  means =  [None]*int(len(list.r))

  i = 0.0
  while i < len(list.r):
    means[int(i)] = Mean(list.r[int(i)].c)
    i = i + 1.0
  

  return means

def MeanOfColumns(list):

  listT = TransposeToNew(list)

  means = MeanOfRows(listT)

  listT = None

  return means

def Variance(list):

  mu = Mean(list)

  sum = 0.0
  i = 0.0
  while i < len(list):
    sum = sum + (list[int(i)] - mu)**2.0
    i = i + 1.0
  

  return sum/len(list)

def Covariance(list1, list2):

  sum = 0.0
  if len(list1) == len(list2):

    mu1 = Mean(list1)
    mu2 = Mean(list2)

    sum = 0.0
    i = 0.0
    while i < len(list1):
      sum = sum + (list1[int(i)] - mu1)*(list2[int(i)] - mu2)
      i = i + 1.0
    

  return sum/len(list1)

def CovarianceMatrix(X):

  mu = MeanOfColumns(X)
  muMatrix = CreateMatrixFromRowCopies(mu, NumberOfRows(X))

  XCentered = CreateCopyOfMatrix(X)
  Subtract(XCentered, muMatrix)

  A = MultiplyToNew(TransposeToNew(XCentered), XCentered)
  ScalarDivide(A, NumberOfRows(X))

  return A

def CorrelationMatrix(X):

  sigma = SampleCovarianceMatrix(X)

  n = NumberOfRows(sigma)
  variances =  [None]*int(n)
  ExtractDiagonal(sigma, variances)
  vectorPower(variances,  -1.0/2.0)
  variancesMatrix = CreateDiagonalMatrixFromArray(variances)
  t1 = CreateCopyOfMatrix(variancesMatrix)
  Multiply(t1, variancesMatrix, sigma)
  correlationMatrixResult = CreateCopyOfMatrix(variancesMatrix)
  Multiply(correlationMatrixResult, t1, variancesMatrix)

  return correlationMatrixResult

def SampleCovarianceMatrix(X):

  A = CovarianceMatrix(X)
  ScalarMultiply(A, NumberOfRows(X)/(NumberOfRows(X) - 1.0))

  return A

def Correlation(list1, list2):

  cv = Covariance(list1, list2)
  sd1 = StandardDeviation(list1)
  sd2 = StandardDeviation(list2)

  return cv/(sd1*sd2)

def Percentile(list, p):
  return list[int(ceil(len(list)*p) - 1.0)]

def VarianceSample(list):
  return Variance(list)*len(list)/(len(list) - 1.0)

def StandardDeviation(list):
  return sqrt(Variance(list))

def StandardDeviationSample(list):
  return sqrt(VarianceSample(list))

def Median(list):

  QuickSortNumbers(list)

  if len(list) % 2.0 == 1.0:
    m = list[int(floor(len(list)/2.0))]
  else:
    m = (list[int(len(list)/2.0)] + list[int(len(list)/2.0 - 1.0)])/2.0

  return m

def Mode(list):

  modes =  [None]*int(0.0)
  if len(list) > 0.0:
    QuickSortNumbers(list)
    unique = CountUniqueNumbers(list)
    counts = CountOccurrenceOfEachNumber(list, unique)
    mostFrequent = FindMostFrequentNumber(counts)
    valuesMostFrequent = CountNumberOfHighestOccurrences(mostFrequent, counts)
    modes = None
    modes = GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts)
    counts = None

  return modes

def CountUniqueNumbers(list):

  last = list[int(0.0)]
  unique = 1.0
  i = 1.0
  while i < len(list):
    if list[int(i)] != last:
      unique = unique + 1.0
      last = list[int(i)]
    i = i + 1.0
  

  return unique

def CountOccurrenceOfEachNumber(list, unique):

  counts =  [None]*int(unique)

  current = 0.0
  counts[int(0.0)] = 1.0
  last = list[int(0.0)]
  i = 1.0
  while i < len(list):
    if list[int(i)] != last:
      current = current + 1.0
      counts[int(current)] = 1.0
    else:
      counts[int(current)] = counts[int(current)] + 1.0
    last = list[int(i)]
    i = i + 1.0
  

  return counts

def FindMostFrequentNumber(counts):

  mostFrequent = 0.0
  i = 0.0
  while i < len(counts):
    mostFrequent = max(counts[int(i)],mostFrequent)
    i = i + 1.0
  
  return mostFrequent

def CountNumberOfHighestOccurrences(mostFrequent, counts):

  valuesMostFrequent = 0.0
  i = 0.0
  while i < len(counts):
    if counts[int(i)] == mostFrequent:
      valuesMostFrequent = valuesMostFrequent + 1.0
    i = i + 1.0
  
  return valuesMostFrequent

def GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts):

  modes =  [None]*int(valuesMostFrequent)

  current = 0.0
  currentInsert = 0.0
  i = 0.0
  while i < len(counts):
    if counts[int(i)] == mostFrequent:
      modes[int(currentInsert)] = list[int(current)]
      currentInsert = currentInsert + 1.0

    current = current + counts[int(i)]
    i = i + 1.0
  

  return modes

def LogNormalDensity(x, mean, sd):
  return 1.0/(x*sd*sqrt(2.0*pi))*exp( -((log(x) - mean)**2.0/(2.0*sd**2.0)))

def LogNormalRandom(prg, n, mean, sd):

  rs = NormalRandom(prg, n, mean, sd)

  i = 0.0
  while i < n:
    rs[int(i)] = exp(rs[int(i)])
    i = i + 1.0
  

  return rs

def LogNormalProbability(q, mean, sd):
  return NormalProbability(log(q), mean, sd)

def LogNormalQuantile(p, mean, sd):
  return exp(NormalQuantile(p, mean, sd))

def CreateUnsignedInteger(digits):

  x = UnsignedInteger()
  x.digits =  [None]*int(digits)

  ClearUnsignedInteger(x)

  return x

def FreeUnsignedInteger(x):
  x.digits = None
  x = None

def ClearUnsignedInteger(x):

  i = 0.0
  while i < DigitCapacityUnsignedInteger(x):
    x.digits[int(i)] = 0.0
    i = i + 1.0
  

def TrimUnsignedInteger(x):

  capacity = DigitCapacityUnsignedInteger(x)
  digits = DigitsUnsignedInteger(x)

  if capacity > digits:
    newCapacity = digits
    newDigits =  [None]*int(newCapacity)

    i = 0.0
    while i < newCapacity:
      newDigits[int(i)] = x.digits[int(i)]
      i = i + 1.0
    

    x.digits = None
    x.digits = newDigits

def ToStringUnsignedInteger(x):

  digits = DigitsUnsignedInteger(x)
  str =  [None]*int(digits)

  i = 0.0
  while i < digits:
    digit = DigitUnsignedInteger(x, i)

    c = DecimalDigitToCharacter(digit)

    str[int(digits - i - 1.0)] = c
    i = i + 1.0
  

  return str

def AddUnsignedInteger(x, a, b):

  overflow =  not AddFixedUnsignedInteger(x, a, b) 

  if overflow:
    x.digits = None

    ads = DigitsUnsignedInteger(a)
    bds = DigitsUnsignedInteger(b)
    capacity = max(ads,bds) + 1.0
    x.digits =  [None]*int(capacity)

    AddFixedUnsignedInteger(x, a, b)

def SubtractUnsignedInteger(x, a, b):

  ads = DigitsUnsignedInteger(a)
  xds = DigitCapacityUnsignedInteger(x)

  if xds < ads:
    x.digits = None
    x.digits =  [None]*int(ads)

  return SubtractFixedUnsignedInteger(x, a, b)

def MultiplyUnsignedInteger(x, a, b):

  overflow =  not MultiplyFixedUnsignedInteger(x, a, b) 

  if overflow:
    x.digits = None

    ads = DigitsUnsignedInteger(a)
    bds = DigitsUnsignedInteger(b)
    capacity = ads + bds
    x.digits =  [None]*int(capacity)

    MultiplyFixedUnsignedInteger(x, a, b)

def DivideUnsignedInteger(q, r, a, b):

  ads = DigitsUnsignedInteger(a)
  bds = DigitsUnsignedInteger(b)
  qds = DigitCapacityUnsignedInteger(q)
  rds = DigitCapacityUnsignedInteger(r)

  if qds < ads - bds + 1.0:
    capacity = ads - bds + 1.0
    q.digits =  [None]*int(capacity)

  if rds < bds:
    capacity = bds
    r.digits =  [None]*int(capacity)

  return DivideFixedUnsignedInteger(q, r, a, b)

def ShiftLeftUnsignedInteger(x, shifts):

  xds = DigitsUnsignedInteger(x)
  capacity = DigitCapacityUnsignedInteger(x)

  if xds + shifts > capacity:
    capacity = xds + shifts
    oldDigits = x.digits
    x.digits =  [None]*int(capacity)
  else:
    oldDigits = x.digits

  i = 0.0
  while i < len(oldDigits) - shifts:
    x.digits[int(len(oldDigits) - i - 1.0)] = oldDigits[int(len(oldDigits) - shifts - i - 1.0)]
    i = i + 1.0
  

  while i < len(oldDigits):
    x.digits[int(len(oldDigits) - i - 1.0)] = 0.0
    i = i + 1.0
  

def CreateArbitraryPrecisionInteger(digits):

  x = ArbitraryPrecisionInteger()
  x.sign = True
  x.number = CreateUnsignedInteger(digits)

  return x

def FreeArbitraryPrecisionInteger(x):
  FreeUnsignedInteger(x.number)
  x = None

def ClearArbitraryPrecisionInteger(x):
  x.sign = True
  ClearUnsignedInteger(x.number)

def TrimArbitraryPrecisionInteger(x):
  TrimUnsignedInteger(x.number)

def ToStringArbitraryPrecisionInteger(x):

  if len(x.number.digits) > 0.0:

    digits = DigitsUnsignedInteger(x.number)
    str =  [None]*int(1.0 + digits)

    if x.sign:
      str[int(0.0)] = '+'
    else:
      str[int(0.0)] = '-'

    i = 0.0
    while i < digits:
      digit = DigitUnsignedInteger(x.number, i)

      c = DecimalDigitToCharacter(digit)

      str[int(1.0 + digits - i - 1.0)] = c
      i = i + 1.0
    
  else:
    str =  [None]*int(2.0)
    str[int(0.0)] = '+'
    str[int(1.0)] = '0'

  return str

def CreateArbitraryPrecisionIntegerFromString(str):

  hasSign = 0.0
  if len(str) > 0.0:
    if str[int(0.0)] == '-' or str[int(0.0)] == '+':
      hasSign = 1.0

  x = CreateArbitraryPrecisionInteger(len(str) - hasSign)
  stringDigits = len(str)

  if len(str) > 0.0:
    x.sign = True
    if str[int(0.0)] == '-':
      x.sign = False
    elif str[int(0.0)] == '+':
      x.sign = True

  i = 0.0
  while i < stringDigits - hasSign:
    c = str[int(stringDigits - i - 1.0)]
    digit = CharacterToDecimalDigit(c)
    x.number.digits[int(i)] = digit
    i = i + 1.0
  

  return x

def AddArbitraryPrecisionInteger(x, a, b):

  asx = a.sign
  bs = b.sign

  if asx == bs:
    AddUnsignedInteger(x.number, a.number, b.number)
    x.sign = asx
  elif asx == True:
    comparisonResult = CompareFixedUnsignedInteger(a.number, b.number)

    if comparisonResult == 1.0 or comparisonResult == 0.0:
      SubtractUnsignedInteger(x.number, a.number, b.number)
    else:
      SubtractUnsignedInteger(x.number, b.number, a.number)
      x.sign = False
  else:
    comparisonResult = CompareFixedUnsignedInteger(b.number, a.number)

    if comparisonResult == 1.0 or comparisonResult == 0.0:
      SubtractUnsignedInteger(x.number, b.number, a.number)
    else:
      SubtractUnsignedInteger(x.number, a.number, b.number)
      x.sign = False

def SubtractArbitraryPrecisionInteger(x, a, b):

  asx = a.sign
  bs = b.sign

  if asx == bs:
    if asx == True:
      comparisonResult = CompareFixedUnsignedInteger(a.number, b.number)

      if comparisonResult == 1.0 or comparisonResult == 0.0:
        SubtractUnsignedInteger(x.number, a.number, b.number)
      else:
        SubtractUnsignedInteger(x.number, b.number, a.number)
        x.sign = False
    else:
      comparisonResult = CompareFixedUnsignedInteger(b.number, a.number)

      if comparisonResult == 1.0 or comparisonResult == 0.0:
        SubtractUnsignedInteger(x.number, b.number, a.number)
      else:
        SubtractUnsignedInteger(x.number, a.number, b.number)
        x.sign = False
  elif asx == False:
    AddUnsignedInteger(x.number, a.number, b.number)
    x.sign = False
  else:
    AddUnsignedInteger(x.number, a.number, b.number)
    x.sign = True

def MultiplyArbitraryPrecisionInteger(x, a, b):
  MultiplyUnsignedInteger(x.number, a.number, b.number)
  if a.sign != b.sign:
    x.sign = False

def DivideArbitraryPrecisionInteger(q, r, a, b):

  if a.sign == b.sign:
    success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

    if success:
      q.sign = True
      r.sign = True
  elif a.sign == False:
    success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

    if success:
      q.sign = False
      r.sign = True

    rIsZero = True
    i = 0.0
    while i < len(r.number.digits):
      if r.number.digits[int(i)] != 0.0:
        rIsZero = False
      i = i + 1.0
    

    if  not rIsZero :
      AddUnsignedInteger(a.number, a.number, b.number)
      success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)
      SubtractUnsignedInteger(r.number, b.number, r.number)
      SubtractUnsignedInteger(a.number, a.number, b.number)
  else:
    AddUnsignedInteger(a.number, a.number, b.number)

    success = DivideUnsignedInteger(q.number, r.number, a.number, b.number)

    if success:
      q.sign = False
      r.sign = False

  return success

def AddArbitraryPrecisionIntegerStrings(aStr, bStr):

  a = CreateArbitraryPrecisionIntegerFromString(aStr)
  b = CreateArbitraryPrecisionIntegerFromString(bStr)
  c = CreateArbitraryPrecisionInteger(0.0)

  AddArbitraryPrecisionInteger(c, a, b)

  cStr = ToStringArbitraryPrecisionInteger(c)

  return cStr

def SubtractArbitraryPrecisionIntegerStrings(aStr, bStr):

  a = CreateArbitraryPrecisionIntegerFromString(aStr)
  b = CreateArbitraryPrecisionIntegerFromString(bStr)
  c = CreateArbitraryPrecisionInteger(0.0)

  SubtractArbitraryPrecisionInteger(c, a, b)

  cStr = ToStringArbitraryPrecisionInteger(c)

  return cStr

def MultiplyArbitraryPrecisionIntegerStrings(aStr, bStr):

  a = CreateArbitraryPrecisionIntegerFromString(aStr)
  b = CreateArbitraryPrecisionIntegerFromString(bStr)
  c = CreateArbitraryPrecisionInteger(0.0)

  MultiplyArbitraryPrecisionInteger(c, a, b)

  cStr = ToStringArbitraryPrecisionInteger(c)

  return cStr

def DivideArbitraryPrecisionIntegerStrings(aStr, bStr, rStr):

  a = CreateArbitraryPrecisionIntegerFromString(aStr)
  b = CreateArbitraryPrecisionIntegerFromString(bStr)
  q = CreateArbitraryPrecisionInteger(0.0)
  r = CreateArbitraryPrecisionInteger(0.0)

  DivideArbitraryPrecisionInteger(q, r, a, b)

  qStr = ToStringArbitraryPrecisionInteger(q)
  rStr.string = ToStringArbitraryPrecisionInteger(r)

  return qStr

def CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint):

  x = ArbitraryPrecisionFixedPointNumber()
  x.baseNumber = CreateArbitraryPrecisionInteger(digitsBeforePoint + digitsAfterPoint)
  x.pointPosition = digitsAfterPoint

  return x

def FreeArbitraryPrecisionFixedPointNumber(x):
  FreeArbitraryPrecisionInteger(x.baseNumber)
  x = None

def AddArbitraryPrecisionFixedPoint(x, a, b):

  aDigitsBeforePoint = GetDigitsBeforePoint(a)
  aDigitsAfterPoint = GetDigitsAfterPoint(a)

  bDigitsBeforePoint = GetDigitsBeforePoint(b)
  bDigitsAfterPoint = GetDigitsAfterPoint(b)

  digitsBeforePoint = max(aDigitsBeforePoint,bDigitsBeforePoint)
  digitsAfterPoint = max(aDigitsAfterPoint,bDigitsAfterPoint)

  x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
  x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
  AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

  ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
  ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

  AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber)

  success = AssignArbitraryPrecisionFixedPoint(x, x1)

  return success

def AssignArbitraryPrecisionFixedPoint(x, a):

  xDigitsBeforePoint = GetDigitsBeforePoint(x)
  aDigitsBeforePoint = GetDigitsBeforePoint(a)
  xDigitsAfterPoint = GetDigitsAfterPoint(x)
  aDigitsAfterPoint = GetDigitsAfterPoint(a)

  zeroOverflow = True
  if xDigitsBeforePoint < aDigitsBeforePoint:
    i = 0.0
    while i < aDigitsBeforePoint - xDigitsBeforePoint:
      if DigitUnsignedInteger(a.baseNumber.number, aDigitsBeforePoint + aDigitsAfterPoint - i - 1.0) != 0.0:
        zeroOverflow = False
      i = i + 1.0
    

  if zeroOverflow:
    # Assign before point.
    i = 0.0
    while i < xDigitsBeforePoint:
      if i >= aDigitsBeforePoint:
        x.baseNumber.number.digits[int(xDigitsAfterPoint + i)] = 0.0
      else:
        x.baseNumber.number.digits[int(xDigitsAfterPoint + i)] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint + i)
      i = i + 1.0
    

    # Assign after point:
    i = 0.0
    while i < xDigitsAfterPoint:
      if aDigitsAfterPoint - i - 1.0 < 0.0:
        x.baseNumber.number.digits[int(xDigitsAfterPoint - i - 1.0)] = 0.0
      else:
        x.baseNumber.number.digits[int(xDigitsAfterPoint - i - 1.0)] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - i - 1.0)
      i = i + 1.0
    

    # Assign sign.
    x.baseNumber.sign = a.baseNumber.sign

    # Round if necessary.
    if aDigitsAfterPoint > xDigitsAfterPoint:
      if x.baseNumber.sign == True:
        digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

        if digit >= 5.0:
          # Make epsilon.
          epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint)
          epsilon.digits[int(0.0)] = 1.0
          success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon)
          FreeUnsignedInteger(epsilon)
        else:
          success = True
      else:
        digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1.0)

        isPointFive = True
        if digit == 5.0:
          i = aDigitsAfterPoint - xDigitsAfterPoint - 2.0
          while i >= 0.0:
            if DigitUnsignedInteger(a.baseNumber.number, i) != 0.0:
              isPointFive = False
            i = i - 1.0
          
        else:
          isPointFive = False

        if digit <= 4.0 or isPointFive:
          success = True
        else:
          epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint)
          epsilon.digits[int(0.0)] = 1.0
          success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon)
          FreeUnsignedInteger(epsilon)
    else:
      success = True
  else:
    success = False

  return success

def GetDigitsBeforePoint(a):

  digitsAfterPoint = GetDigitsAfterPoint(a)
  sum = DigitCapacityUnsignedInteger(a.baseNumber.number)
  digitsBeforePoint = sum - digitsAfterPoint

  return digitsBeforePoint

def GetDigitsAfterPoint(a):
  return a.pointPosition

def ToStringArbitraryPrecisionFixedPoint(x):

  if len(x.baseNumber.number.digits) > 0.0:

    digits = GetDigitsBeforePoint(x) + GetDigitsAfterPoint(x)
    str =  [None]*int(1.0 + GetDigitsBeforePoint(x) + 1.0 + GetDigitsAfterPoint(x))

    if x.baseNumber.sign:
      str[int(0.0)] = '+'
    else:
      str[int(0.0)] = '-'

    point = 1.0

    i = 0.0
    while i < digits:
      digit = DigitUnsignedInteger(x.baseNumber.number, i)

      if i == x.pointPosition:
        str[int(1.0 + digits - i - 1.0 + point)] = '.'
        point = 0.0

      c = DecimalDigitToCharacter(digit)

      str[int(1.0 + digits - i - 1.0 + point)] = c
      i = i + 1.0
    
  else:
    str =  [None]*int(3.0)
    str[int(0.0)] = '+'
    str[int(1.0)] = '0'
    str[int(2.0)] = '.'

  return str

def CreateArbitraryPrecisionFixedPointFromString(digitsBeforePoint, digitsAfterPoint, str):

  x = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  hasSign = 0.0
  if len(str) > 0.0:
    if str[int(0.0)] == '-' or str[int(0.0)] == '+':
      hasSign = 1.0

  pointPosition = len(str)
  hasPoint = 0.0
  i = 0.0
  while i < len(str) and hasPoint == 0.0:
    if str[int(len(str) - i - 1.0)] == '.':
      pointPosition = i
      hasPoint = 1.0
    i = i + 1.0
  
  stringDigits = len(str)

  if len(str) > 0.0:
    x.baseNumber.sign = True
    if str[int(0.0)] == '-':
      x.baseNumber.sign = False
    elif str[int(0.0)] == '+':
      x.baseNumber.sign = True

  point = 0.0
  i = 0.0
  while i < stringDigits - hasSign - hasPoint:
    if i == pointPosition:
      point = 1.0
    c = str[int(stringDigits - point - i - 1.0)]
    digit = CharacterToDecimalDigit(c)
    x.baseNumber.number.digits[int(i)] = digit
    i = i + 1.0
  

  return x

def SubtractArbitraryPrecisionFixedPoint(x, a, b):

  aDigitsBeforePoint = GetDigitsBeforePoint(a)
  aDigitsAfterPoint = GetDigitsAfterPoint(a)

  bDigitsBeforePoint = GetDigitsBeforePoint(b)
  bDigitsAfterPoint = GetDigitsAfterPoint(b)

  digitsBeforePoint = max(aDigitsBeforePoint,bDigitsBeforePoint)
  digitsAfterPoint = max(aDigitsAfterPoint,bDigitsAfterPoint)

  x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)
  x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber)
  AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber)

  ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint)
  ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint)

  SubtractArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber)

  success = AssignArbitraryPrecisionFixedPoint(x, x1)

  return success

def MultiplyArbitraryPrecisionFixedPoint(x, a, b):

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

def DivideArbitraryPrecisionFixedPoint(q, a, b):

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

def AddArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint):

  a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
  b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
  c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  AddArbitraryPrecisionFixedPoint(c, a, b)

  cStr = ToStringArbitraryPrecisionFixedPoint(c)

  return cStr

def SubtractArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint):

  a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
  b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
  c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  SubtractArbitraryPrecisionFixedPoint(c, a, b)

  cStr = ToStringArbitraryPrecisionFixedPoint(c)

  return cStr

def MultiplyArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint):

  a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
  b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
  c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  MultiplyArbitraryPrecisionFixedPoint(c, a, b)

  cStr = ToStringArbitraryPrecisionFixedPoint(c)

  return cStr

def DivideArbitraryPrecisionFixedPointStrings(aStr, bStr, digitsBeforePoint, digitsAfterPoint):

  a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr)
  b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr)
  q = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint)

  DivideArbitraryPrecisionFixedPoint(q, a, b)

  qStr = ToStringArbitraryPrecisionFixedPoint(q)

  return qStr

def GetDigitsAfterAPFPString(str):

  pointPosition = len(str)
  hasPoint = 0.0
  i = 0.0
  while i < len(str) and hasPoint == 0.0:
    if str[int(len(str) - i - 1.0)] == '.':
      pointPosition = i
      hasPoint = 1.0
    i = i + 1.0
  

  if hasPoint == 0.0:
    digitsAfter = 0.0
  else:
    digitsAfter = pointPosition

  return digitsAfter

def GetDigitsBeforeAPFPString(str):

  hasSign = 0.0
  if len(str) > 0.0:
    if str[int(0.0)] == '-' or str[int(0.0)] == '+':
      hasSign = 1.0

  pointPosition = 0.0
  hasPoint = 0.0
  i = 0.0
  while i < len(str) and hasPoint == 0.0:
    if str[int(len(str) - i - 1.0)] == '.':
      pointPosition = i
      hasPoint = 1.0
    i = i + 1.0
  

  if hasPoint == 0.0:
    digitsBefore = len(str) - hasPoint
  else:
    digitsBefore = len(str) - pointPosition - hasSign - 1.0

  return digitsBefore

def DecimalDigitToCharacter(digit):
  if digit == 1.0:
    c = '1'
  elif digit == 2.0:
    c = '2'
  elif digit == 3.0:
    c = '3'
  elif digit == 4.0:
    c = '4'
  elif digit == 5.0:
    c = '5'
  elif digit == 6.0:
    c = '6'
  elif digit == 7.0:
    c = '7'
  elif digit == 8.0:
    c = '8'
  elif digit == 9.0:
    c = '9'
  else:
    c = '0'
  return c

def DigitUnsignedInteger(x, i):
  return x.digits[int(i)]

def DigitsUnsignedInteger(x):

  capacity = DigitCapacityUnsignedInteger(x)
  done = False
  digits = capacity

  i = capacity - 1.0
  while i >= 0.0 and  not done :
    if DigitUnsignedInteger(x, i) == 0.0:
      digits = digits - 1.0
    else:
      done = True
    i = i - 1.0
  

  if digits == 0.0:
    digits = 1.0

  return digits

def ToStringFixedUnsignedInteger(x):

  digits = DigitCapacityUnsignedInteger(x)
  str =  [None]*int(digits)

  i = 0.0
  while i < digits:
    digit = DigitUnsignedInteger(x, i)

    c = DecimalDigitToCharacter(digit)

    str[int(digits - i - 1.0)] = c
    i = i + 1.0
  

  return str

def DigitCapacityUnsignedInteger(x):
  return len(x.digits)

def CreateFixedUnsignedIntegerFromString(digits, str):

  x = CreateUnsignedInteger(digits)
  stringDigits = len(str)

  i = 0.0
  while i < stringDigits:
    c = str[int(stringDigits - i - 1.0)]

    digit = CharacterToDecimalDigit(c)

    x.digits[int(i)] = digit
    i = i + 1.0
  

  return x

def CharacterToDecimalDigit(c):

  if c == '1':
    digit = 1.0
  elif c == '2':
    digit = 2.0
  elif c == '3':
    digit = 3.0
  elif c == '4':
    digit = 4.0
  elif c == '5':
    digit = 5.0
  elif c == '6':
    digit = 6.0
  elif c == '7':
    digit = 7.0
  elif c == '8':
    digit = 8.0
  elif c == '9':
    digit = 9.0
  else:
    digit = 0.0

  return digit

def AddFixedUnsignedInteger(x, a, b):
  return AddFixedUnsignedIntegerWithShift(x, a, b, 0.0, 0.0)

def AddFixedUnsignedIntegerWithShift(x, a, b, aShift, bShift):

  ads = DigitsUnsignedInteger(a)
  bds = DigitsUnsignedInteger(b)
  xds = DigitCapacityUnsignedInteger(x)

  if xds >= ads and xds >= bds:
    carry = 0.0

    i = 0.0
    while i < xds:
      apos = i - aShift
      if apos >= 0.0 and apos < ads:
        ad = DigitUnsignedInteger(a, apos)
      else:
        ad = 0.0

      bpos = i - bShift
      if bpos >= 0.0 and bpos < bds:
        bd = DigitUnsignedInteger(b, bpos)
      else:
        bd = 0.0

      remainder = ad + bd + carry

      if remainder >= 10.0:
        carry = 1.0
        remainder = remainder - 10.0
      else:
        carry = 0.0

      x.digits[int(i)] = remainder
      i = i + 1.0
    

    if carry == 1.0:
      overflow = True
    else:
      overflow = False
  else:
    overflow = True

  return  not overflow 

def SubtractFixedUnsignedInteger(x, a, b):
  return SubtractFixedUnsignedIntegerWithShift(x, a, b, 0.0, 0.0)

def SubtractFixedUnsignedIntegerWithShift(x, a, b, aShift, bShift):

  ads = DigitsUnsignedInteger(a)
  bds = DigitsUnsignedInteger(b)
  xds = DigitCapacityUnsignedInteger(x)

  borrow = 0.0
  overflow = False

  i = 0.0
  while i < max(max(ads,bds),xds) and  not overflow :
    apos = i - aShift
    if apos >= 0.0 and apos < ads:
      ad = DigitUnsignedInteger(a, apos)
    else:
      ad = 0.0

    bpos = i - bShift
    if bpos >= 0.0 and bpos < bds:
      bd = DigitUnsignedInteger(b, bpos)
    else:
      bd = 0.0

    remainder = ad - bd - borrow

    if remainder < 0.0:
      borrow = 1.0
      remainder = remainder + 10.0
    else:
      borrow = 0.0

    if remainder != 0.0:
      if i < xds:
        pass
      else:
        overflow = True

    if i < xds:
      x.digits[int(i)] = remainder
    i = i + 1.0
  

  if borrow == 1.0:
    underflow = True
  else:
    underflow = False

  return  not underflow  and  not overflow 

def MultiplyFixedUnsignedInteger(c, a, b):

  success = True

  ClearUnsignedInteger(c)

  ads = DigitsUnsignedInteger(a)
  i = 0.0
  while i < ads:
    ad = DigitUnsignedInteger(a, i)

    j = 0.0
    while j < ad:
      success = success and AddFixedUnsignedIntegerWithShift(c, c, b, 0.0, i)
      j = j + 1.0
    
    i = i + 1.0
  

  if len(c.digits) == 0.0:
    success = False

  return success

def CompareFixedUnsignedInteger(a, b):

  ads = DigitsUnsignedInteger(a)
  bds = DigitsUnsignedInteger(b)

  comparizonResult = 0.0

  if ads > bds:
    comparizonResult = 1.0
  elif ads < bds:
    comparizonResult =  -1.0
  else:
    done = False
    i = ads - 1.0
    while i >= 0.0 and  not done :
      ad = DigitUnsignedInteger(a, i)
      bd = DigitUnsignedInteger(b, i)

      if ad > bd:
        comparizonResult = 1.0
        done = True
      elif ad < bd:
        comparizonResult =  -1.0
        done = True
      i = i - 1.0
    

  return comparizonResult

def CompareFixedUnsignedIntegerWithShift(a, b, aShift, bShift):

  ads = DigitsUnsignedInteger(a)
  if ads > 0.0:
    ads = ads + aShift
  bds = DigitsUnsignedInteger(b)
  if bds > 0.0:
    bds = bds + bShift

  comparizonResult = 0.0

  if ads > bds:
    comparizonResult = 1.0
  elif ads < bds:
    comparizonResult =  -1.0
  else:
    done = False
    i = ads - 1.0
    while i >= 0.0 and  not done :
      apos = i - aShift
      if apos >= 0.0 and apos < ads:
        ad = DigitUnsignedInteger(a, apos)
      else:
        ad = 0.0

      bpos = i - bShift
      if bpos >= 0.0 and bpos < bds:
        bd = DigitUnsignedInteger(b, bpos)
      else:
        bd = 0.0

      if ad > bd:
        comparizonResult = 1.0
        done = True
      elif ad < bd:
        comparizonResult =  -1.0
        done = True
      i = i - 1.0
    

  return comparizonResult

def DivideFixedUnsignedInteger(q, r, a, b):

  success = True

  ClearUnsignedInteger(q)
  ClearUnsignedInteger(r)

  ads = DigitsUnsignedInteger(a)
  bds = DigitsUnsignedInteger(b)
  qdsCapacity = DigitCapacityUnsignedInteger(q)

  # bds == 0 -> b.digits[0] != 0
  if bds != 1.0 or b.digits[int(0.0)] != 0.0:
    if ads >= bds:
      i = ads - bds
      while i >= 0.0 and success:
        qd = 0.0
        done = False
        j = 0.0
        while j <= 9.0 and  not done :
          comparisonResult = CompareFixedUnsignedIntegerWithShift(a, b, 0.0, i)
          if comparisonResult == 1.0 or comparisonResult == 0.0:
            SubtractFixedUnsignedIntegerWithShift(a, a, b, 0.0, i)
            qd = qd + 1.0
          else:
            done = True
          j = j + 1.0
        
        if i < qdsCapacity:
          q.digits[int(i)] = qd
        else:
          success = False
        i = i - 1.0
      
      if success:
        # Put the rest in the remainder.
        success = AddFixedUnsignedInteger(r, r, a)

        if success:
          # Reconstruct a.
          MultiplyFixedUnsignedInteger(a, q, b)
          AddFixedUnsignedInteger(a, a, r)
    else:
      # Put everything in the remainder.
      AddFixedUnsignedInteger(r, r, a)
  else:
    # division by zero
    success = False

  return success

def AssertFalse(b, failures):
  if b:
    failures.numberValue = failures.numberValue + 1.0

def AssertTrue(b, failures):
  if  not b :
    failures.numberValue = failures.numberValue + 1.0

def AssertEquals(a, b, failures):
  if a != b:
    failures.numberValue = failures.numberValue + 1.0

def AssertBooleansEqual(a, b, failures):
  if a != b:
    failures.numberValue = failures.numberValue + 1.0

def AssertCharactersEqual(a, b, failures):
  if a != b:
    failures.numberValue = failures.numberValue + 1.0

def AssertStringEquals(a, b, failures):
  if  not arraysStringsEqual(a, b) :
    failures.numberValue = failures.numberValue + 1.0

def AssertNumberArraysEqual(a, b, failures):

  if len(a) == len(b):
    i = 0.0
    while i < len(a):
      AssertEquals(a[int(i)], b[int(i)], failures)
      i = i + 1.0
    
  else:
    failures.numberValue = failures.numberValue + 1.0

def AssertBooleanArraysEqual(a, b, failures):

  if len(a) == len(b):
    i = 0.0
    while i < len(a):
      AssertBooleansEqual(a[int(i)], b[int(i)], failures)
      i = i + 1.0
    
  else:
    failures.numberValue = failures.numberValue + 1.0

def AssertStringArraysEqual(a, b, failures):

  if len(a) == len(b):
    i = 0.0
    while i < len(a):
      AssertStringEquals(a[int(i)].string, b[int(i)].string, failures)
      i = i + 1.0
    
  else:
    failures.numberValue = failures.numberValue + 1.0

def CreateBooleanReference(value):

  ref = BooleanReference()
  ref.booleanValue = value

  return ref

def CreateBooleanArrayReference(value):

  ref = BooleanArrayReference()
  ref.booleanArray = value

  return ref

def CreateBooleanArrayReferenceLengthValue(length, value):

  ref = BooleanArrayReference()
  ref.booleanArray =  [None]*int(length)

  i = 0.0
  while i < length:
    ref.booleanArray[int(i)] = value
    i = i + 1.0
  

  return ref

def FreeBooleanArrayReference(booleanArrayReference):
  booleanArrayReference.booleanArray = None
  booleanArrayReference = None

def CreateCharacterReference(value):

  ref = CharacterReference()
  ref.characterValue = value

  return ref

def CreateNumberReference(value):

  ref = NumberReference()
  ref.numberValue = value

  return ref

def CreateNumberArrayReference(value):

  ref = NumberArrayReference()
  ref.numberArray = value

  return ref

def CreateNumberArrayReferenceLengthValue(length, value):

  ref = NumberArrayReference()
  ref.numberArray =  [None]*int(length)

  i = 0.0
  while i < length:
    ref.numberArray[int(i)] = value
    i = i + 1.0
  

  return ref

def FreeNumberArrayReference(numberArrayReference):
  numberArrayReference.numberArray = None
  numberArrayReference = None

def CreateStringReference(value):

  ref = StringReference()
  ref.string =  [None]*int(len(value))
  i = 0.0
  while i < len(value):
    ref.string[int(i)] = value[int(i)]
    i = i + 1.0
  

  return ref

def CreateStringReferenceLengthValue(length, value):

  ref = StringReference()
  ref.string =  [None]*int(length)

  i = 0.0
  while i < length:
    ref.string[int(i)] = value
    i = i + 1.0
  

  return ref

def FreeStringReference(stringReference):
  stringReference.string = None
  stringReference = None

def CreateStringArrayReference(strings):

  ref = StringArrayReference()
  ref.stringArray = strings

  return ref

def CreateStringArrayReferenceLengthValue(length, value):

  ref = StringArrayReference()
  ref.stringArray =  [None]*int(length)

  i = 0.0
  while i < length:
    ref.stringArray[int(i)] = CreateStringReference(value)
    i = i + 1.0
  

  return ref

def FreeStringArrayReference(stringArrayReference):
  FreeStringReferenceArray(stringArrayReference.stringArray)
  stringArrayReference = None

def FreeStringReferenceArray(stringReferencesArray):
  i = 0.0
  while i < len(stringReferencesArray):
    stringReferencesArray[int(i)] = None
    i = i + 1.0
  
  stringReferencesArray = None

def Increase(nRef):
  nRef.numberValue = nRef.numberValue + 1.0

  return nRef.numberValue

def Decrease(nRef):
  nRef.numberValue = nRef.numberValue - 1.0

  return nRef.numberValue

def AddToReference(nRef, n):
  nRef.numberValue = nRef.numberValue + n

  return nRef.numberValue

def CreateDate(year, month, day):

  date = Date()

  date.year = year
  date.month = month
  date.day = day

  return date

def IsLeapYearWithCheck(year, isLeapYearReference, message):

  if year >= 1752.0:
    success = True
    itIsLeapYear = IsLeapYear(year)
  else:
    success = False
    itIsLeapYear = False
    message.string = "Gregorian calendar was not in general use."

  isLeapYearReference.booleanValue = itIsLeapYear
  return success

def IsLeapYear(year):

  if DivisibleBy(year, 4.0):
    if DivisibleBy(year, 100.0):
      if DivisibleBy(year, 400.0):
        itIsLeapYear = True
      else:
        itIsLeapYear = False
    else:
      itIsLeapYear = True
  else:
    itIsLeapYear = False

  return itIsLeapYear

def DayToDateWithCheck(dayNr, dateReference, message):

  if dayNr >=  -79623.0:
    date = Date()
    remainder = NumberReference()
    remainder.numberValue = dayNr + 79623.0
    # Days since 1752-01-01. Day 0: Thursday, 1970-01-01
    # Find year.
    date.year = GetYearFromDayNr(remainder.numberValue, remainder)

    # Find month.
    date.month = GetMonthFromDayNr(remainder.numberValue, date.year, remainder)

    # Find day.
    date.day = 1.0 + remainder.numberValue

    dateReference.date = date
    success = True
  else:
    success = False
    message.string = "Gregorian calendar was not in general use before 1752."

  return success

def DayToDate(dayNr):

  dateRef = DateReference()
  message = StringReference()

  success = DayToDateWithCheck(dayNr, dateRef, message)
  if success:
    date = dateRef.date
    dateRef = None
    FreeStringReference(message)
  else:
    date = CreateDate(1970.0, 1.0, 1.0)

  return date

def GetMonthFromDayNrWithCheck(dayNr, year, monthReference, remainderReference, message):

  if dayNr >=  -79623.0:
    month = GetMonthFromDayNr(dayNr, year, remainderReference)
    monthReference.numberValue = month
    success = True
  else:
    success = False
    message.string = "Gregorian calendar not in general use before 1752."

  return success

def GetMonthFromDayNr(dayNr, year, remainderReference):

  daysInMonth = GetDaysInMonth(year)
  done = False
  month = 1.0

  while  not done :
    if dayNr >= daysInMonth[int(month)]:
      dayNr = dayNr - daysInMonth[int(month)]
      month = month + 1.0
    else:
      done = True
  
  remainderReference.numberValue = dayNr

  return month

def GetYearFromDayNrWithCheck(dayNr, yearReference, remainder, message):

  if dayNr >= 0.0:
    success = True
    year = GetYearFromDayNr(dayNr, remainder)
    yearReference.numberValue = year
  else:
    success = False
    message.string = "Day number must be 0 or higher. 0 is 1752-01-01."

  return success

def GetYearFromDayNr(dayNr, remainder):

  done = False
  year = 1752.0

  while  not done :
    if IsLeapYear(year):
      nrOfDays = 366.0
    else:
      nrOfDays = 365.0

    if dayNr >= nrOfDays:
      # First day is 0.
      dayNr = dayNr - nrOfDays
      year = year + 1.0
    else:
      done = True
  
  remainder.numberValue = dayNr

  return year

def DaysBetweenDates(A, B):

  daysA = DateToDays(A)
  daysB = DateToDays(B)

  daysBetween = daysB - daysA

  return daysBetween

def GetDaysInMonthWithCheck(year, daysInMonthReference, message):

  date = CreateDate(year, 1.0, 1.0)

  success = IsValidDate(date, message)
  if success:
    daysInMonth = GetDaysInMonth(year)

    daysInMonthReference.numberArray = daysInMonth

  return success

def GetDaysInMonth(year):

  daysInMonth =  [None]*int(1.0 + 12.0)

  daysInMonth[int(0.0)] = 0.0
  daysInMonth[int(1.0)] = 31.0

  if IsLeapYear(year):
    daysInMonth[int(2.0)] = 29.0
  else:
    daysInMonth[int(2.0)] = 28.0
  daysInMonth[int(3.0)] = 31.0
  daysInMonth[int(4.0)] = 30.0
  daysInMonth[int(5.0)] = 31.0
  daysInMonth[int(6.0)] = 30.0
  daysInMonth[int(7.0)] = 31.0
  daysInMonth[int(8.0)] = 31.0
  daysInMonth[int(9.0)] = 30.0
  daysInMonth[int(10.0)] = 31.0
  daysInMonth[int(11.0)] = 30.0
  daysInMonth[int(12.0)] = 31.0

  return daysInMonth

def DateToDaysWithCheck(date, dayNumberReferenceReference, message):

  success = IsValidDate(date, message)
  if success:
    days = DateToDays(date)
    dayNumberReferenceReference.numberValue = days

  return success

def DateToDays(date):

  # Day 1752-01-01
  days =  -79623.0

  days = days + DaysInYears(date.year)
  days = days + DaysInMonths(date.month, date.year)
  days = days + date.day - 1.0

  return days

def DateToWeekdayNumberWithCheck(date, weekDayNumberReference, message):

  success = IsValidDate(date, message)
  if success:
    weekDay = DateToWeekdayNumber(date)
    weekDayNumberReference.numberValue = weekDay

  return success

def DateToWeekdayNumber(date):

  days = DateToDays(date)

  days = days + 79623.0
  days = days + 5.0

  weekDay = days % 7.0 + 1.0

  return weekDay

def DateToWeeknumber(date, yearRef):

  week1Start = CopyDate(date)

  week1Start.day = 1.0
  week1Start.month = 1.0
  weekday = DateToWeekdayNumber(week1Start)

  # Set week1Start to the start of the Week 1.
  # If monday, week 1 begins on Jan. 1st
  if weekday == 1.0:
    week1Start.day = 1.0
  # If tuesday, week 1 begins on Dec. 31st
  if weekday == 2.0:
    week1Start.year = week1Start.year - 1.0
    week1Start.month = 12.0
    week1Start.day = 31.0
  # If wednesday, week 1 begins on Dec. 30th
  if weekday == 3.0:
    week1Start.year = week1Start.year - 1.0
    week1Start.month = 12.0
    week1Start.day = 30.0
  # If thursday, week 1 begins on Dec. 29th
  if weekday == 4.0:
    week1Start.year = week1Start.year - 1.0
    week1Start.month = 12.0
    week1Start.day = 29.0
  # If friday, week 1 begins on Jan. 4th
  if weekday == 5.0:
    week1Start.day = 4.0
  # If saturday, week 1 begins on Jan. 3rd
  if weekday == 6.0:
    week1Start.day = 3.0
  # If sunday, week 1 begins on Jan. 2nd
  if weekday == 7.0:
    week1Start.day = 2.0

  days = DateToDays(date)
  daysWeek1Start = DateToDays(week1Start)

  if days >= daysWeek1Start:
    weekNumber = 1.0 + floor((days - daysWeek1Start)/7.0)

    if weekNumber >= 1.0 and weekNumber <= 52.0:
      # Week is between 1 and 52 in the current year.
      yearRef.numberValue = date.year
    else:
      # Is week nr 53 or 1 next year?
      newyears = CopyDate(date)
      newyears.month = 12.0
      newyears.day = 31.0
      weekdayNewYears = DateToWeekdayNumber(newyears)
      if weekdayNewYears == 1.0 or weekdayNewYears == 2.0 or weekdayNewYears == 3.0:
        # Week 1 next year.
        weekNumber = 1.0
        yearRef.numberValue = date.year + 1.0
      else:
        # Week 53
        yearRef.numberValue = date.year
      newyears = None
  else:
    # Week is in previous year. Either 52nd or 53rd.
    newyears = CopyDate(date)
    newyears.month = 12.0
    newyears.day = 31.0
    newyears.year = date.year - 1.0
    weekNumber = DateToWeeknumber(newyears, yearRef)
    newyears = None

  week1Start = None

  return weekNumber

def DaysInMonthsWithCheck(month, year, daysInMonthsReference, message):

  date = CreateDate(year, month, 1.0)

  success = IsValidDate(date, message)
  if success:
    days = DaysInMonths(month, year)

    daysInMonthsReference.numberValue = days

  return success

def DaysInMonths(month, year):

  daysInMonth = GetDaysInMonth(year)

  days = 0.0
  i = 1.0
  while i < month:
    days = days + daysInMonth[int(i)]
    i = i + 1.0
  

  return days

def DaysInYearsWithCheck(years, daysReference, message):

  date = CreateDate(years, 1.0, 1.0)

  success = IsValidDate(date, message)
  if success:
    days = DaysInYears(years)
    daysReference.numberValue = days

  return success

def DaysInYears(years):

  days = 0.0
  i = 1752.0
  while i < years:
    if IsLeapYear(i):
      nrOfDays = 366.0
    else:
      nrOfDays = 365.0
    days = days + nrOfDays
    i = i + 1.0
  

  return days

def IsValidDate(date, message):

  if date.year >= 1752.0:
    if IsInteger(date.year):
      if date.month >= 1.0 and date.month <= 12.0:
        if IsInteger(date.month):
          daysInMonth = GetDaysInMonth(date.year)
          daysInThisMonth = daysInMonth[int(date.month)]
          if date.day >= 1.0 and date.day <= daysInThisMonth:
            if IsInteger(date.day):
              valid = True
            else:
              valid = False
              message.string = "Day must be an integer."
          else:
            valid = False
            message.string = "The month does not have the given day number."
        else:
          valid = False
          message.string = "Month must be an integer."
      else:
        valid = False
        message.string = "Month must be between 1 and 12, inclusive."
    else:
      valid = False
      message.string = "Year must be an integer."
  else:
    valid = False
    message.string = "Gregorian calendar was not in general use before 1752."

  return valid

def AddDaysToDate(date, days, message):

  daysRef = NumberReference()
  success = DateToDaysWithCheck(date, daysRef, message)

  if success:
    n = daysRef.numberValue
    n = n + days

    dateReference = DateReference()
    success = DayToDateWithCheck(n, dateReference, message)
    if success:
      AssignDate(date, dateReference.date)

  return success

def AssignDate(a, b):
  a.year = b.year
  a.month = b.month
  a.day = b.day

def AddMonthsToDate(date, months, message):

  backup = CopyDate(date)

  if months > 0.0:
    i = 0.0
    while i < months:
      date.month = date.month + 1.0

      if date.month == 13.0:
        date.month = 1.0
        date.year = date.year + 1.0
      i = i + 1.0
    
  if months < 0.0:
    i = 0.0
    while i <  -months:
      date.month = date.month - 1.0

      if date.month == 0.0:
        date.month = 12.0
        date.year = date.year - 1.0
      i = i + 1.0
    

  success = IsValidDate(date, message)

  if success:
    pass
  else:
    # Restore old date
    AssignDate(date, backup)

  return success

def DateToStringISO8601WithCheck(date, datestr, message):

  success = IsValidDate(date, message)

  if success:
    if date.year <= 9999.0:
      datestr.string = DateToStringISO8601(date)
    else:
      message.string = "This library works from 1752 to 9999."

  return success

def DateToStringISO8601(date):

  str =  [None]*int(10.0)

  str[int(0.0)] = cDecimalDigitToCharacter(floor(date.year/1000.0))
  str[int(1.0)] = cDecimalDigitToCharacter(floor((date.year % 1000.0)/100.0))
  str[int(2.0)] = cDecimalDigitToCharacter(floor((date.year % 100.0)/10.0))
  str[int(3.0)] = cDecimalDigitToCharacter(floor(date.year % 10.0))

  str[int(4.0)] = '-'

  str[int(5.0)] = cDecimalDigitToCharacter(floor((date.month % 100.0)/10.0))
  str[int(6.0)] = cDecimalDigitToCharacter(floor(date.month % 10.0))

  str[int(7.0)] = '-'

  str[int(8.0)] = cDecimalDigitToCharacter(floor((date.day % 100.0)/10.0))
  str[int(9.0)] = cDecimalDigitToCharacter(floor(date.day % 10.0))

  return str

def DateFromStringISO8601(str):

  date = Date()

  n = cCharacterToDecimalDigit(str[int(0.0)])*1000.0
  n = n + cCharacterToDecimalDigit(str[int(1.0)])*100.0
  n = n + cCharacterToDecimalDigit(str[int(2.0)])*10.0
  n = n + cCharacterToDecimalDigit(str[int(3.0)])*1.0

  date.year = n

  n = cCharacterToDecimalDigit(str[int(5.0)])*10.0
  n = n + cCharacterToDecimalDigit(str[int(6.0)])*1.0

  date.month = n

  n = cCharacterToDecimalDigit(str[int(8.0)])*10.0
  n = n + cCharacterToDecimalDigit(str[int(9.0)])*1.0

  date.day = n

  return date

def DateFromStringISO8601WithCheck(str, dateRef, message):

  valid = IsValidDateISO8601(str, message)

  if valid:
    dateRef.date = DateFromStringISO8601(str)

  return valid

def IsValidDateISO8601(str, message):

  if len(str) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0:

    if cIsNumber(str[int(0.0)]) and cIsNumber(str[int(1.0)]) and cIsNumber(str[int(2.0)]) and cIsNumber(str[int(3.0)]) and cIsNumber(str[int(5.0)]) and cIsNumber(str[int(6.0)]) and cIsNumber(str[int(8.0)]) and cIsNumber(str[int(9.0)]):
      if str[int(4.0)] == '-' and str[int(7.0)] == '-':
        valid = True
      else:
        valid = False
        message.string = "ISO8601 date must use \'-\' in positions 5 and 8."
    else:
      valid = False
      message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10."
  else:
    valid = False
    message.string = "ISO8601 date must be exactly 10 characters long."

  return valid

def DateEquals(a, b):
  return a.year == b.year and a.month == b.month and a.day == b.day

def CopyDate(a):

  b = CreateDate(a.year, a.month, a.day)

  return b

def GetSecondsFromDate(date):

  seconds = 0.0
  dayNumberReferenceReference = NumberReference()
  message = StringReference()

  success = DateToDaysWithCheck(date, dayNumberReferenceReference, message)
  if success:
    days = dayNumberReferenceReference.numberValue

    secondsInMinute = 60.0
    secondsInHour = 60.0*secondsInMinute
    secondsInDay = 24.0*secondsInHour

    seconds = seconds + secondsInDay*days

  dayNumberReferenceReference = None
  message = None

  return seconds

def DateIsInInterval(interval, date):

  fromx = DateToDays(interval.first)
  to = DateToDays(interval.last)
  day = DateToDays(date)

  return day >= fromx and day <= to

def DateLessThan(a, b):

  less = False

  if a.year < b.year:
    less = True
  elif a.year == b.year:
    if a.month < b.month:
      less = True
    elif a.month == b.month:
      if a.day < b.day:
        less = True
      else:
        pass

  return less

def CreateDateTimeTimezone(year, month, day, hours, minutes, seconds, timezoneOffsetSeconds):

  dateTimeTimezone = DateTimeTimezone()

  dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds)
  dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

  return dateTimeTimezone

def CreateDateTimeTimezoneInHoursAndMinutes(year, month, day, hours, minutes, seconds, timezoneOffsetHours, timezoneOffsetMinutes):

  dateTimeTimezone = DateTimeTimezone()

  dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds)
  dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes)

  return dateTimeTimezone

def GetDateFromDateTimeTimeZone(dateTimeTimezone, dateTimeReference, message):

  dateTime = dateTimeTimezone.dateTime

  return AddSecondsToDateTimeWithCheck(dateTime,  -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message)

def CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, timezoneOffsetSeconds, dateTimeTimezoneReference, message):

  adjustedDateTimeReference = DateTimeReference()
  dateTimeTimezone = DateTimeTimezone()

  success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message)

  if success:
    dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime
    dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds

    dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone

  return success

def CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(dateTime, timezoneOffsetHours, timezoneOffsetMinutes, dateTimeTimezoneReference, message):
  return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message)

def GetDateTimeTimezoneFromSeconds(dateTimeTzRef, seconds, offset, message):

  dateTimeRef = DateTimeReference()
  success = GetDateTimeFromSeconds(seconds, dateTimeRef, message)

  if success:
    success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTime, offset, dateTimeTzRef, message)

  return success

def CreateDateTime(year, month, day, hours, minutes, seconds):

  dateTime = DateTime()

  dateTime.date = CreateDate(year, month, day)
  dateTime.hours = hours
  dateTime.minutes = minutes
  dateTime.seconds = seconds

  return dateTime

def GetDateTimeFromSeconds(seconds, dateTimeReference, message):

  secondsInMinute = 60.0
  secondsInHour = 60.0*secondsInMinute
  secondsInDay = 24.0*secondsInHour
  days = floor(seconds/secondsInDay)
  remainder = seconds - days*secondsInDay
  dateReference = DateReference()

  success = DayToDateWithCheck(days, dateReference, message)
  if success:
    date = dateReference.date

    dateTime = DateTime()
    dateTime.date = date
    dateTime.hours = floor(remainder/secondsInHour)
    remainder = remainder - dateTime.hours*secondsInHour
    dateTime.minutes = floor(remainder/secondsInMinute)
    remainder = remainder - dateTime.minutes*secondsInMinute
    dateTime.seconds = remainder

    dateTimeReference.dateTime = dateTime

  return success

def GetSecondsFromDateTime(dateTime):

  secondsInMinute = 60.0
  secondsInHour = 60.0*secondsInMinute

  seconds = GetSecondsFromDate(dateTime.date)
  seconds = seconds + secondsInHour*dateTime.hours
  seconds = seconds + secondsInMinute*dateTime.minutes
  seconds = seconds + dateTime.seconds

  return seconds

def GetSecondsFromMinutes(minutes):
  return minutes*60.0

def GetSecondsFromHours(hours):
  return GetSecondsFromMinutes(hours*60.0)

def GetSecondsFromDays(days):
  return GetSecondsFromHours(days*24.0)

def GetSecondsFromWeeks(weeks):
  return GetSecondsFromDays(weeks*7.0)

def GetMinutesFromSeconds(seconds):
  return seconds/60.0

def GetHoursFromSeconds(seconds):
  return GetMinutesFromSeconds(seconds)/60.0

def GetDaysFromSeconds(seconds):
  return GetHoursFromSeconds(seconds)/24.0

def GetWeeksFromSeconds(seconds):
  return GetDaysFromSeconds(seconds)/7.0

def GetDateFromDateTime(dateTime):
  return dateTime.date

def AddSecondsToDateTimeWithCheck(dateTime, seconds, dateTimeReference, message):

  if IsValidDateTime(dateTime, message):
    secondsInDateTime = GetSecondsFromDateTime(dateTime)
    secondsInDateTime = secondsInDateTime + seconds

    success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message)
  else:
    success = False

  return success

def AddSecondsToDateTime(dateTime, seconds, dateTimeReference, message):

  secondsInDateTime = GetSecondsFromDateTime(dateTime)
  secondsInDateTime = secondsInDateTime + seconds

  return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message)

def AddMinutesToDateTime(dateTime, minutes, dateTimeReference, message):
  return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message)

def AddHoursToDateTime(dateTime, hours, dateTimeReference, message):
  return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message)

def AddDaysToDateTime(dateTime, days, dateTimeReference, message):
  return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message)

def AddWeeksToDateTime(dateTime, weeks, dateTimeReference, message):
  return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message)

def DateTimeToStringISO8601WithCheck(datetime, dateStr, message):

  success = DateToStringISO8601WithCheck(datetime.date, dateStr, message)

  if success:
    dateStr.string = None

    success = IsValidDateTime(datetime, message)
    if success:
      dateStr.string = DateTimeToStringISO8601(datetime)

  return success

def IsValidDateTime(datetime, message):

  success = IsValidDate(datetime.date, message)

  if success:
    if datetime.hours <= 23.0 and datetime.hours >= 0.0:
      if datetime.minutes <= 59.0 and datetime.minutes >= 0.0:
        if datetime.seconds <= 59.0 and datetime.seconds >= 0.0:
          success = True
        else:
          success = False
          message.string = "Seconds must be between 0 and 59."
      else:
        success = False
        message.string = "Minutes must be between 0 and 59."
    else:
      success = False
      message.string = "Hours must be between 0 and 23."

  return success

def DateTimeToStringISO8601(datetime):

  str =  [None]*int(19.0)

  datestr = DateToStringISO8601(datetime.date)
  i = 0.0
  while i < len(datestr):
    str[int(i)] = datestr[int(i)]
    i = i + 1.0
  

  str[int(10.0)] = 'T'
  str[int(11.0)] = cDecimalDigitToCharacter(floor((datetime.hours % 100.0)/10.0))
  str[int(12.0)] = cDecimalDigitToCharacter(floor(datetime.hours % 10.0))

  str[int(13.0)] = ':'

  str[int(14.0)] = cDecimalDigitToCharacter(floor((datetime.minutes % 100.0)/10.0))
  str[int(15.0)] = cDecimalDigitToCharacter(floor(datetime.minutes % 10.0))

  str[int(16.0)] = ':'

  str[int(17.0)] = cDecimalDigitToCharacter(floor((datetime.seconds % 100.0)/10.0))
  str[int(18.0)] = cDecimalDigitToCharacter(floor(datetime.seconds % 10.0))

  return str

def DateTimeFromStringISO8601(str):

  dateTime = DateTime()

  dateTime.date = DateFromStringISO8601(str)

  n = cCharacterToDecimalDigit(str[int(11.0)])*10.0
  n = n + cCharacterToDecimalDigit(str[int(12.0)])*1.0

  dateTime.hours = n

  n = cCharacterToDecimalDigit(str[int(14.0)])*10.0
  n = n + cCharacterToDecimalDigit(str[int(15.0)])*1.0

  dateTime.minutes = n

  n = cCharacterToDecimalDigit(str[int(17.0)])*10.0
  n = n + cCharacterToDecimalDigit(str[int(18.0)])*1.0

  dateTime.seconds = n

  return dateTime

def DateTimeFromStringISO8601WithCheck(str, dateTimeRef, message):

  valid = IsValidDateTimeISO8601(str, message)

  if valid:
    dateTimeRef.dateTime = DateTimeFromStringISO8601(str)

  return valid

def IsValidDateTimeISO8601(str, message):

  if len(str) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0:

    if cIsNumber(str[int(0.0)]) and cIsNumber(str[int(1.0)]) and cIsNumber(str[int(2.0)]) and cIsNumber(str[int(3.0)]) and cIsNumber(str[int(5.0)]) and cIsNumber(str[int(6.0)]) and cIsNumber(str[int(8.0)]) and cIsNumber(str[int(9.0)]) and cIsNumber(str[int(11.0)]) and cIsNumber(str[int(12.0)]) and cIsNumber(str[int(14.0)]) and cIsNumber(str[int(15.0)]) and cIsNumber(str[int(17.0)]) and cIsNumber(str[int(18.0)]):
      if str[int(4.0)] == '-' and str[int(7.0)] == '-' and str[int(10.0)] == 'T' and str[int(13.0)] == ':' and str[int(16.0)] == ':':
        valid = True
      else:
        valid = False
        message.string = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17."
    else:
      valid = False
      message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19."
  else:
    valid = False
    message.string = "ISO8601 date must be exactly 19 characters long."

  return valid

def DateTimeEquals(a, b):
  return DateEquals(a.date, b.date) and a.hours == b.hours and a.minutes == b.minutes and a.seconds == b.seconds

def FreeDateTime(datetime):
  datetime.date = None
  datetime = None

def CreateFixedPoint30d(digitsBeforeDecimalPoint, digitsAfterDecimalPoint):

  fp = FixedPoint30d()
  fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
  fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
  fp.part1 = 0.0
  fp.part2 = 0.0

  return fp

def CreateFixedPoint15d(digitsBeforeDecimalPoint, digitsAfterDecimalPoint):

  fp = FixedPoint15d()
  fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint
  fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint
  fp.number = 0.0

  return fp

def ToNumber15d(n):
  return n.number

def Number15d(number):

  fp = FixedPoint15d()
  fp.digitsBeforeDecimalPoint = 7.0
  fp.digitsAfterDecimalPoint = 7.0
  fp.number = number

  return fp

def Assign15d(fp, number):

  success =  not WillOverflow15d(fp, number) 
  success = success and FixedPointIsValid15d(fp)

  if success:
    fp.number = number
    fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint)

  return success

def Assign15dFloor(fp, number):

  success =  not WillOverflow15d(fp, number) 
  success = success and FixedPointIsValid15d(fp)

  if success:
    fp.number = number
    fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint)

  return success

def FixedPointIsValid15d(fp):

  if IsInteger(fp.digitsAfterDecimalPoint) and IsInteger(fp.digitsBeforeDecimalPoint):
    if fp.digitsBeforeDecimalPoint >= 0.0 and fp.digitsBeforeDecimalPoint <= 15.0:
      if fp.digitsAfterDecimalPoint >= 0.0 and fp.digitsAfterDecimalPoint <= 15.0:
        if fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15.0:
          if fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0.0:
            valid = True
          else:
            valid = False
        else:
          valid = False
      else:
        valid = False
    else:
      valid = False
  else:
    valid = False

  return valid

def WillOverflow15d(fp, number):

  if fabs(number) < 10.0**fp.digitsBeforeDecimalPoint:
    overflow = False
  else:
    overflow = True

  return overflow

def FloorToDigits(value, digits):
  return floor(value*10.0**digits)/10.0**digits

def ToString15d(fp):

  string =  [None]*int(1.0 + fp.digitsBeforeDecimalPoint + 1.0 + fp.digitsAfterDecimalPoint)

  decimal = fp.number*10.0**fp.digitsAfterDecimalPoint

  if decimal < 0.0:
    decimal =  -decimal
    string[int(0.0)] = '-'
  else:
    string[int(0.0)] = '+'

  decimal = Round(decimal)

  characterReference = CharacterReference()

  digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint
  digitPosition = 1.0

  i = 0.0
  while i < digits:
    if i == fp.digitsBeforeDecimalPoint:
      string[int(digitPosition)] = '.'

      digitPosition = digitPosition + 1.0

    d = floor(decimal/10.0**(digits - i - 1.0))
    d = d % 10.0

    GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference)
    string[int(digitPosition)] = characterReference.characterValue

    digitPosition = digitPosition + 1.0
    i = i + 1.0
  

  characterReference = None

  return string

def Add15d(a, b, c):
  return Assign15d(a, b.number + c.number)

def Subtract15d(a, b, c):
  return Assign15d(a, b.number - c.number)

def Multiply15d(a, b, c):
  return Assign15d(a, b.number*c.number)

def DivideFloored15d(q, r, a, b):

  t = Copy15d(r)

  if b.number != 0.0:
    xDivisor = Round(a.number*10.0**q.digitsAfterDecimalPoint*10.0**q.digitsAfterDecimalPoint)
    xDividend = Round(b.number*10.0**q.digitsAfterDecimalPoint)
    x = floor(xDivisor/xDividend)
    x = x/10.0**q.digitsAfterDecimalPoint
    success = Assign15d(q, x)
    Multiply15d(t, q, b)
    Subtract15d(r, a, t)
  else:
    success = False

  t = None

  return success

def Copy15d(r):

  t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint)
  t.number = r.number

  return t

def Negate15d(a):
  a.number =  -a.number

def Positive15d(a):
  a.number =  +a.number

def Factorial15d(x):

  if x.number >= 0.0:
    success = Assign15d(x, Factorial(x.number))
  else:
    success = False

  return success

def Round15d(x):
  return Assign15d(x, Round(x.number))

def BankersRound15d(x):
  return Assign15d(x, BankersRound(x.number))

def Ceil15d(x):
  return Assign15d(x, Ceil(x.number))

def Floor15d(x):
  return Assign15d(x, floor(x.number))

def Truncate15d(x):
  x.number = Truncate(x.number)

def Absolute15d(x):
  x.number = fabs(x.number)

def Logarithm15d(x):

  if x.number > 0.0:
    success = Assign15d(x, Logarithm(x.number))
  else:
    success = False

  return success

def NaturalLogarithm15d(x):

  if x.number > 0.0:
    success = Assign15d(x, NaturalLogarithm(x.number))
  else:
    success = False

  return success

def Sin15d(x):
  return Assign15d(x, Sin(x.number))

def Cos15d(x):
  return Assign15d(x, Cos(x.number))

def Tan15d(x):
  return Assign15d(x, Tan(x.number))

def Asin15d(x):

  if x.number >=  -1.0 and x.number <= 1.0:
    success = Assign15d(x, Asin(x.number))
  else:
    success = False

  return success

def Acos15d(x):

  if x.number >=  -1.0 and x.number <= 1.0:
    success = Assign15d(x, Acos(x.number))
  else:
    success = False

  return success

def Atan15d(x):
  return Assign15d(x, Atan(x.number))

def Atan2_15d(a, y, x):
  return Assign15d(a, Atan2(y.number, x.number))

def Squareroot15d(x):

  if x.number >= 0.0:
    success = Assign15d(x, sqrt(x.number))
  else:
    success = False

  return success

def Exp15d(x):
  return Assign15d(x, Exp(x.number))

def DivisibleBy15d(a, b):
  return ((a.number % b.number) == 0.0)

def Combinations15d(x, n, k):

  if IsInteger(n.number) and IsInteger(k.number):
    if n.number >= 1.0 and k.number >= 0.0 and n.number >= k.number:
      success = Assign15d(x, Combinations(n.number, k.number))
    else:
      success = False
  else:
    success = False

  return success

def Permutations15d(x, n, k):

  if IsInteger(n.number) and IsInteger(k.number):
    if n.number >= 1.0 and k.number >= 0.0 and n.number >= k.number:
      success = Assign15d(x, Permutations(n.number, k.number))
    else:
      success = False
  else:
    success = False

  return success

def Equals15d(a, b):

  an = ToNumber15d(a)
  bn = ToNumber15d(b)

  p = max(a.digitsAfterDecimalPoint,b.digitsAfterDecimalPoint)

  equals = EpsilonCompare(an, bn, 10.0**( -p))

  return equals

def GreaterThan15d(a, b):

  an = ToNumber15d(a)
  bn = ToNumber15d(b)

  return an > bn

def LessThan15d(a, b):

  an = ToNumber15d(a)
  bn = ToNumber15d(b)

  return an < bn

def GreaterThanOrEqual15d(a, b):

  an = ToNumber15d(a)
  bn = ToNumber15d(b)

  equal = Equals15d(a, b)

  return an > bn or equal

def LessThanOrEqual15d(a, b):

  an = ToNumber15d(a)
  bn = ToNumber15d(b)

  equal = Equals15d(a, b)

  return an < bn or equal

def EpsilonCompare15d(a, b, epsilon):
  return EpsilonCompare(a.number, b.number, epsilon.number)

def GreatestCommonDivisor15d(x, a, b):

  if IsInteger(a.number) and IsInteger(b.number):
    if a.number >= 0.0 and b.number >= 0.0:
      success = Assign15d(x, GreatestCommonDivisor(a.number, b.number))
    else:
      success = False
  else:
    success = False

  return success

def GCDWithSubtraction15d(x, a, b):

  if IsInteger(a.number) and IsInteger(b.number):
    if a.number >= 0.0 and b.number >= 0.0:
      success = Assign15d(x, GCDWithSubtraction(a.number, b.number))
    else:
      success = False
  else:
    success = False

  return success

def IsInteger15d(a):
  return IsInteger(a.number)

def LeastCommonMultiple15d(x, a, b):

  if IsInteger(a.number) and IsInteger(b.number):
    if a.number != 0.0 and b.number != 0.0:
      success = Assign15d(x, LeastCommonMultiple(a.number, b.number))
    else:
      success = False
  else:
    success = False

  return success

def Sign15d(a):
  return Sign(a.number)

def Max15d(x, a, b):
  return Assign15d(x, Max(a.number, b.number))

def Min15d(x, a, b):
  return Assign15d(x, Min(a.number, b.number))

def Power15d(x, a, b):

  if a.number != 0.0 or b.number != 0.0:
    if  not (a.number < 0.0 and  not IsInteger(b.number) ) :
      success = Assign15d(x, Power(a.number, b.number))
    else:
      success = False
  else:
    success = False

  return success

def FormatToString15d(fp, digitsAfter):

  result = FormatToStringWithSymbols15d(fp, digitsAfter, "", ".")

  return result

def FormatToStringWithSymbols15d(fp, digitsAfter, thousandsSeparator, decimalPoint):

  characterReference = CharacterReference()

  decimal = Round(fp.number*10.0**digitsAfter)

  sign = 0.0
  if decimal < 0.0:
    sign = 1.0
    decimal =  -decimal

  if decimal != 0.0:
    digits = floor(log10(decimal) + 1.0)
  else:
    digits = 1.0
  digitsBefore = digits - digitsAfter

  if digitsBefore <= 0.0:
    digitsBefore = 0.0
    thousandsTimes = 0.0
    digits = digitsAfter + 1.0
  else:
    thousandsTimes = floor((digitsBefore - 1.0)/3.0)
  thousandsChars = thousandsTimes*len(thousandsSeparator)

  if digitsAfter == 0.0:
    decimalPointChars = 0.0
  else:
    decimalPointChars = len(decimalPoint)

  string =  [None]*int(sign + digits + thousandsChars + decimalPointChars)
  p = 0.0

  if sign > 0.0:
    string[int(p)] = '-'
    p = p + 1.0

  i = 0.0
  while i < digits:
    if i == digitsBefore:
      if i == 0.0:
        string[int(p)] = '0'
        p = p + 1.0
        digits = digits - 1.0

      j = 0.0
      while j < len(decimalPoint):
        string[int(p)] = decimalPoint[int(j)]
        p = p + 1.0
        j = j + 1.0
      

    if i < digitsBefore:
      if (digitsBefore - i) % 3.0 == 0.0 and i != 0.0:
        j = 0.0
        while j < len(thousandsSeparator):
          string[int(p)] = thousandsSeparator[int(j)]
          p = p + 1.0
          j = j + 1.0
        

    d = floor(decimal/10.0**(digits - i - 1.0))
    d = d % 10.0

    GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference)
    string[int(p)] = characterReference.characterValue

    p = p + 1.0
    i = i + 1.0
  

  # System.out.println(new String(string));
  return string

def NumberToHumanReadable(n, digitsAfter, thousandsSeparator, decimalPoint):

  if fabs(n) < 1.0:
    str = CreateStringDecimalFromNumber(n)
  else:
    d = log10(n)

    p3 = min(floor(d/3.0),8.0)

    if p3 == 0.0:
      u = 'B'
    elif p3 == 1.0:
      u = 'K'
    elif p3 == 2.0:
      u = 'M'
    elif p3 == 3.0:
      u = 'G'
    elif p3 == 4.0:
      u = 'T'
    elif p3 == 5.0:
      u = 'P'
    elif p3 == 6.0:
      u = 'E'
    elif p3 == 7.0:
      u = 'Z'
    else:
      u = 'Y'

    if p3 > 1.0:
      n = n/10.0**(p3*3.0)

    str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint)

    if p3 > 1.0:
      str = strAppendCharacter(str, u)

  return str

def NumberToHumanReadableBinaryPrefix(n, digitsAfter, thousandsSeparator, decimalPoint):

  if fabs(n) < 1.0:
    str = CreateStringDecimalFromNumber(n)
  else:
    d = floor(log(n)/log(2.0)) + 1.0

    p3 = min(floor(d/10.0),8.0)

    if p3 == 0.0:
      u = "B"
    elif p3 == 1.0:
      u = "Ki"
    elif p3 == 2.0:
      u = "Mi"
    elif p3 == 3.0:
      u = "Gi"
    elif p3 == 4.0:
      u = "Ti"
    elif p3 == 5.0:
      u = "Pi"
    elif p3 == 6.0:
      u = "Ei"
    elif p3 == 7.0:
      u = "Zi"
    else:
      u = "Yi"

    if p3 > 1.0:
      n = n/2.0**(p3*10.0)

    str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint)

    if p3 > 1.0:
      str = strAppendString(str, u)

  return str

def AddNumber(list, a):

  newlist =  [None]*int(len(list) + 1.0)
  i = 0.0
  while i < len(list):
    newlist[int(i)] = list[int(i)]
    i = i + 1.0
  
  newlist[int(len(list))] = a
		
  list = None
		
  return newlist

def AddNumberRef(list, i):
  list.numberArray = AddNumber(list.numberArray, i)

def RemoveNumber(list, n):

  newlist =  [None]*int(len(list) - 1.0)

  if n >= 0.0 and n < len(list):
    i = 0.0
    while i < len(list):
      if i < n:
        newlist[int(i)] = list[int(i)]
      if i > n:
        newlist[int(i - 1.0)] = list[int(i)]
      i = i + 1.0
    

    list = None
  else:
    newlist = None
		
  return newlist

def GetNumberRef(list, i):
  return list.numberArray[int(i)]

def RemoveNumberRef(list, i):
  list.numberArray = RemoveNumber(list.numberArray, i)

def AddString(list, a):

  newlist =  [None]*int(len(list) + 1.0)

  i = 0.0
  while i < len(list):
    newlist[int(i)] = list[int(i)]
    i = i + 1.0
  
  newlist[int(len(list))] = a
		
  list = None
		
  return newlist

def AddStringRef(list, i):
  list.stringArray = AddString(list.stringArray, i)

def RemoveString(list, n):

  newlist =  [None]*int(len(list) - 1.0)

  if n >= 0.0 and n < len(list):
    i = 0.0
    while i < len(list):
      if i < n:
        newlist[int(i)] = list[int(i)]
      if i > n:
        newlist[int(i - 1.0)] = list[int(i)]
      i = i + 1.0
    

    list = None
  else:
    newlist = None
		
  return newlist

def GetStringRef(list, i):
  return list.stringArray[int(i)]

def RemoveStringRef(list, i):
  list.stringArray = RemoveString(list.stringArray, i)

def CreateDynamicArrayCharacters():

  da = DynamicArrayCharacters()
  da.array =  [None]*int(10.0)
  da.length = 0.0

  return da

def CreateDynamicArrayCharactersWithInitialCapacity(capacity):

  da = DynamicArrayCharacters()
  da.array =  [None]*int(capacity)
  da.length = 0.0

  return da

def DynamicArrayAddCharacter(da, value):
  if da.length == len(da.array):
    DynamicArrayCharactersIncreaseSize(da)

  da.array[int(da.length)] = value
  da.length = da.length + 1.0

def DynamicArrayAddString(da, str):

  i = 0.0
  while i < len(str):
    DynamicArrayAddCharacter(da, str[int(i)])
    i = i + 1.0
  

def DynamicArrayCharactersIncreaseSize(da):

  newLength = round(len(da.array)*3.0/2.0)
  newArray =  [None]*int(newLength)

  i = 0.0
  while i < len(da.array):
    newArray[int(i)] = da.array[int(i)]
    i = i + 1.0
  

  da.array = None

  da.array = newArray

def DynamicArrayCharactersDecreaseSizeNecessary(da):

  needsDecrease = False

  if da.length > 10.0:
    needsDecrease = da.length <= round(len(da.array)*2.0/3.0)

  return needsDecrease

def DynamicArrayCharactersDecreaseSize(da):

  newLength = round(len(da.array)*2.0/3.0)
  newArray =  [None]*int(newLength)

  i = 0.0
  while i < newLength:
    newArray[int(i)] = da.array[int(i)]
    i = i + 1.0
  

  da.array = None

  da.array = newArray

def DynamicArrayCharactersIndex(da, index):
  return da.array[int(index)]

def DynamicArrayCharactersLength(da):
  return da.length

def DynamicArrayInsertCharacter(da, index, value):

  if da.length == len(da.array):
    DynamicArrayCharactersIncreaseSize(da)

  i = da.length
  while i > index:
    da.array[int(i)] = da.array[int(i - 1.0)]
    i = i - 1.0
  

  da.array[int(index)] = value

  da.length = da.length + 1.0

def DynamicArrayCharacterSet(da, index, value):

  if index < da.length:
    da.array[int(index)] = value
    success = True
  else:
    success = False

  return success

def DynamicArrayRemoveCharacter(da, index):

  i = index
  while i < da.length - 1.0:
    da.array[int(i)] = da.array[int(i + 1.0)]
    i = i + 1.0
  

  da.length = da.length - 1.0

  if DynamicArrayCharactersDecreaseSizeNecessary(da):
    DynamicArrayCharactersDecreaseSize(da)

def FreeDynamicArrayCharacters(da):
  da.array = None
  da = None

def DynamicArrayCharactersToArray(da):

  array =  [None]*int(da.length)

  i = 0.0
  while i < da.length:
    array[int(i)] = da.array[int(i)]
    i = i + 1.0
  

  return array

def ArrayToDynamicArrayCharactersWithOptimalSize(array):

  c = len(array)
  n = (log(c) - 1.0)/log(3.0/2.0)
  newCapacity = ceil(10.0*(3.0/2.0)**n)

  da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity)

  i = 0.0
  while i < len(array):
    da.array[int(i)] = array[int(i)]
    i = i + 1.0
  

  return da

def ArrayToDynamicArrayCharacters(array):

  da = DynamicArrayCharacters()
  da.array = arraysCopyString(array)
  da.length = len(array)

  return da

def DynamicArrayCharactersEqual(a, b):

  equal = True
  if a.length == b.length:
    i = 0.0
    while i < a.length and equal:
      if a.array[int(i)] != b.array[int(i)]:
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def DynamicArrayCharactersToLinkedList(da):

  ll = CreateLinkedListCharacter()

  i = 0.0
  while i < da.length:
    LinkedListAddCharacter(ll, da.array[int(i)])
    i = i + 1.0
  

  return ll

def LinkedListToDynamicArrayCharacters(ll):

  node = ll.first

  da = DynamicArrayCharacters()
  da.length = LinkedListCharactersLength(ll)

  da.array =  [None]*int(da.length)

  i = 0.0
  while i < da.length:
    da.array[int(i)] = node.value
    node = node.next
    i = i + 1.0
  

  return da

def AddBoolean(list, a):

  newlist =  [None]*int(len(list) + 1.0)
  i = 0.0
  while i < len(list):
    newlist[int(i)] = list[int(i)]
    i = i + 1.0
  
  newlist[int(len(list))] = a
		
  list = None
		
  return newlist

def AddBooleanRef(list, i):
  list.booleanArray = AddBoolean(list.booleanArray, i)

def RemoveBoolean(list, n):

  newlist =  [None]*int(len(list) - 1.0)

  if n >= 0.0 and n < len(list):
    i = 0.0
    while i < len(list):
      if i < n:
        newlist[int(i)] = list[int(i)]
      if i > n:
        newlist[int(i - 1.0)] = list[int(i)]
      i = i + 1.0
    

    list = None
  else:
    newlist = None
		
  return newlist

def GetBooleanRef(list, i):
  return list.booleanArray[int(i)]

def RemoveDecimalRef(list, i):
  list.booleanArray = RemoveBoolean(list.booleanArray, i)

def CreateLinkedListString():

  ll = LinkedListStrings()
  ll.first = LinkedListNodeStrings()
  ll.last = ll.first
  ll.last.end = True

  return ll

def LinkedListAddString(ll, value):
  ll.last.end = False
  ll.last.value = value
  ll.last.next = LinkedListNodeStrings()
  ll.last.next.end = True
  ll.last = ll.last.next

def LinkedListStringsToArray(ll):

  node = ll.first

  length = LinkedListStringsLength(ll)

  array =  [None]*int(length)

  i = 0.0
  while i < length:
    array[int(i)] = StringReference()
    array[int(i)].string = node.value
    node = node.next
    i = i + 1.0
  

  return array

def LinkedListStringsLength(ll):

  l = 0.0
  node = ll.first
  while  not node.end :
    node = node.next
    l = l + 1.0
  

  return l

def FreeLinkedListString(ll):

  node = ll.first

  while  not node.end :
    prev = node
    node = node.next
    prev = None
  

  node = None

def LinkedListInsertString(ll, index, value):

  if index == 0.0:
    tmp = ll.first
    ll.first = LinkedListNodeStrings()
    ll.first.next = tmp
    ll.first.value = value
    ll.first.end = False
  else:
    node = ll.first
    i = 0.0
    while i < index - 1.0:
      node = node.next
      i = i + 1.0
    

    tmp = node.next
    node.next = LinkedListNodeStrings()
    node.next.next = tmp
    node.next.value = value
    node.next.end = False

def CreateLinkedListNumbers():

  ll = LinkedListNumbers()
  ll.first = LinkedListNodeNumbers()
  ll.last = ll.first
  ll.last.end = True

  return ll

def CreateLinkedListNumbersArray(length):

  lls =  [None]*int(length)
  i = 0.0
  while i < len(lls):
    lls[int(i)] = CreateLinkedListNumbers()
    i = i + 1.0
  

  return lls

def LinkedListAddNumber(ll, value):
  ll.last.end = False
  ll.last.value = value
  ll.last.next = LinkedListNodeNumbers()
  ll.last.next.end = True
  ll.last = ll.last.next

def LinkedListNumbersLength(ll):

  l = 0.0
  node = ll.first
  while  not node.end :
    node = node.next
    l = l + 1.0
  

  return l

def LinkedListNumbersIndex(ll, index):

  node = ll.first
  i = 0.0
  while i < index:
    node = node.next
    i = i + 1.0
  

  return node.value

def LinkedListInsertNumber(ll, index, value):

  if index == 0.0:
    tmp = ll.first
    ll.first = LinkedListNodeNumbers()
    ll.first.next = tmp
    ll.first.value = value
    ll.first.end = False
  else:
    node = ll.first
    i = 0.0
    while i < index - 1.0:
      node = node.next
      i = i + 1.0
    

    tmp = node.next
    node.next = LinkedListNodeNumbers()
    node.next.next = tmp
    node.next.value = value
    node.next.end = False

def LinkedListSet(ll, index, value):

  node = ll.first
  i = 0.0
  while i < index:
    node = node.next
    i = i + 1.0
  

  node.next.value = value

def LinkedListRemoveNumber(ll, index):

  node = ll.first
  prev = ll.first

  i = 0.0
  while i < index:
    prev = node
    node = node.next
    i = i + 1.0
  

  if index == 0.0:
    ll.first = prev.next
  if  not prev.next.end :
    prev.next = prev.next.next

def FreeLinkedListNumbers(ll):

  node = ll.first

  while  not node.end :
    prev = node
    node = node.next
    prev = None
  

  node = None

def FreeLinkedListNumbersArray(lls):

  i = 0.0
  while i < len(lls):
    FreeLinkedListNumbers(lls[int(i)])
    i = i + 1.0
  
  lls = None

def LinkedListNumbersToArray(ll):

  node = ll.first

  length = LinkedListNumbersLength(ll)

  array =  [None]*int(length)

  i = 0.0
  while i < length:
    array[int(i)] = node.value
    node = node.next
    i = i + 1.0
  

  return array

def ArrayToLinkedListNumbers(array):

  ll = CreateLinkedListNumbers()

  i = 0.0
  while i < len(array):
    LinkedListAddNumber(ll, array[int(i)])
    i = i + 1.0
  

  return ll

def LinkedListNumbersEqual(a, b):

  an = a.first
  bn = b.first

  equal = True
  done = False
  while equal and  not done :
    if an.end == bn.end:
      if an.end:
        done = True
      elif an.value == bn.value:
        an = an.next
        bn = bn.next
      else:
        equal = False
    else:
      equal = False
  

  return equal

def CreateLinkedListCharacter():

  ll = LinkedListCharacters()
  ll.first = LinkedListNodeCharacters()
  ll.last = ll.first
  ll.last.end = True

  return ll

def LinkedListAddCharacter(ll, value):
  ll.last.end = False
  ll.last.value = value
  ll.last.next = LinkedListNodeCharacters()
  ll.last.next.end = True
  ll.last = ll.last.next

def LinkedListCharactersToArray(ll):

  node = ll.first

  length = LinkedListCharactersLength(ll)

  array =  [None]*int(length)

  i = 0.0
  while i < length:
    array[int(i)] = node.value
    node = node.next
    i = i + 1.0
  

  return array

def LinkedListCharactersLength(ll):

  l = 0.0
  node = ll.first
  while  not node.end :
    node = node.next
    l = l + 1.0
  

  return l

def FreeLinkedListCharacter(ll):

  node = ll.first

  while  not node.end :
    prev = node
    node = node.next
    prev = None
  

  node = None

def LinkedListCharactersAddString(ll, str):

  i = 0.0
  while i < len(str):
    LinkedListAddCharacter(ll, str[int(i)])
    i = i + 1.0
  

def LinkedListInsertCharacter(ll, index, value):

  if index == 0.0:
    tmp = ll.first
    ll.first = LinkedListNodeCharacters()
    ll.first.next = tmp
    ll.first.value = value
    ll.first.end = False
  else:
    node = ll.first
    i = 0.0
    while i < index - 1.0:
      node = node.next
      i = i + 1.0
    

    tmp = node.next
    node.next = LinkedListNodeCharacters()
    node.next.next = tmp
    node.next.value = value
    node.next.end = False

def CreateDynamicArrayNumbers():

  da = DynamicArrayNumbers()
  da.array =  [None]*int(10.0)
  da.length = 0.0

  return da

def CreateDynamicArrayNumbersWithInitialCapacity(capacity):

  da = DynamicArrayNumbers()
  da.array =  [None]*int(capacity)
  da.length = 0.0

  return da

def DynamicArrayAddNumber(da, value):
  if da.length == len(da.array):
    DynamicArrayNumbersIncreaseSize(da)

  da.array[int(da.length)] = value
  da.length = da.length + 1.0

def DynamicArrayNumbersIncreaseSize(da):

  newLength = round(len(da.array)*3.0/2.0)
  newArray =  [None]*int(newLength)

  i = 0.0
  while i < len(da.array):
    newArray[int(i)] = da.array[int(i)]
    i = i + 1.0
  

  da.array = None

  da.array = newArray

def DynamicArrayNumbersDecreaseSizeNecessary(da):

  needsDecrease = False

  if da.length > 10.0:
    needsDecrease = da.length <= round(len(da.array)*2.0/3.0)

  return needsDecrease

def DynamicArrayNumbersDecreaseSize(da):

  newLength = round(len(da.array)*2.0/3.0)
  newArray =  [None]*int(newLength)

  i = 0.0
  while i < newLength:
    newArray[int(i)] = da.array[int(i)]
    i = i + 1.0
  

  da.array = None

  da.array = newArray

def DynamicArrayNumbersIndex(da, index):
  return da.array[int(index)]

def DynamicArrayNumbersLength(da):
  return da.length

def DynamicArrayInsertNumber(da, index, value):

  if da.length == len(da.array):
    DynamicArrayNumbersIncreaseSize(da)

  i = da.length
  while i > index:
    da.array[int(i)] = da.array[int(i - 1.0)]
    i = i - 1.0
  

  da.array[int(index)] = value

  da.length = da.length + 1.0

def DynamicArrayNumberSet(da, index, value):

  if index < da.length:
    da.array[int(index)] = value
    success = True
  else:
    success = False

  return success

def DynamicArrayRemoveNumber(da, index):

  i = index
  while i < da.length - 1.0:
    da.array[int(i)] = da.array[int(i + 1.0)]
    i = i + 1.0
  

  da.length = da.length - 1.0

  if DynamicArrayNumbersDecreaseSizeNecessary(da):
    DynamicArrayNumbersDecreaseSize(da)

def FreeDynamicArrayNumbers(da):
  da.array = None
  da = None

def DynamicArrayNumbersToArray(da):

  array =  [None]*int(da.length)

  i = 0.0
  while i < da.length:
    array[int(i)] = da.array[int(i)]
    i = i + 1.0
  

  return array

def ArrayToDynamicArrayNumbersWithOptimalSize(array):

  #
  #         c = 10*(3/2)^n
  #         log(c) = log(10*(3/2)^n)
  #         log(c) = log(10) + log((3/2)^n)
  #         log(c) = 1 + log((3/2)^n)
  #         log(c) - 1 = log((3/2)^n)
  #         log(c) - 1 = n*log(3/2)
  #         n = (log(c) - 1)/log(3/2)
  #        
  c = len(array)
  n = (log(c) - 1.0)/log(3.0/2.0)
  newCapacity = ceil(10.0*(3.0/2.0)**n)

  da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity)

  i = 0.0
  while i < len(array):
    da.array[int(i)] = array[int(i)]
    i = i + 1.0
  

  return da

def ArrayToDynamicArrayNumbers(array):

  da = DynamicArrayNumbers()
  da.array = arraysCopyNumberArray(array)
  da.length = len(array)

  return da

def DynamicArrayNumbersEqual(a, b):

  equal = True
  if a.length == b.length:
    i = 0.0
    while i < a.length and equal:
      if a.array[int(i)] != b.array[int(i)]:
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def DynamicArrayNumbersToLinkedList(da):

  ll = CreateLinkedListNumbers()

  i = 0.0
  while i < da.length:
    LinkedListAddNumber(ll, da.array[int(i)])
    i = i + 1.0
  

  return ll

def LinkedListToDynamicArrayNumbers(ll):

  node = ll.first

  da = DynamicArrayNumbers()
  da.length = LinkedListNumbersLength(ll)

  da.array =  [None]*int(da.length)

  i = 0.0
  while i < da.length:
    da.array[int(i)] = node.value
    node = node.next
    i = i + 1.0
  

  return da

def DynamicArrayNumbersIndexOf(arr, n, foundReference):

  found = False
  i = 0.0
  while i < arr.length and  not found :
    if arr.array[int(i)] == n:
      found = True
    i = i + 1.0
  
  if  not found :
    i =  -1.0
  else:
    i = i - 1.0

  foundReference.booleanValue = found

  return i

def DynamicArrayNumbersIsInArray(arr, n):

  found = False
  i = 0.0
  while i < arr.length and  not found :
    if arr.array[int(i)] == n:
      found = True
    i = i + 1.0
  

  return found

def AddCharacter(list, a):

  newlist =  [None]*int(len(list) + 1.0)
  i = 0.0
  while i < len(list):
    newlist[int(i)] = list[int(i)]
    i = i + 1.0
  
  newlist[int(len(list))] = a
		
  list = None
		
  return newlist

def AddCharacterRef(list, i):
  list.string = AddCharacter(list.string, i)

def RemoveCharacter(list, n):

  newlist =  [None]*int(len(list) - 1.0)

  if n >= 0.0 and n < len(list):
    i = 0.0
    while i < len(list):
      if i < n:
        newlist[int(i)] = list[int(i)]
      if i > n:
        newlist[int(i - 1.0)] = list[int(i)]
      i = i + 1.0
    

    list = None
  else:
    newlist = None

  return newlist

def GetCharacterRef(list, i):
  return list.string[int(i)]

def RemoveCharacterRef(list, i):
  list.string = RemoveCharacter(list.string, i)

def GetAccrualAmount(total, fromYear, fromMonth, fromDay, toYear, toMonth, toDay, yearOfInterest, monthOfInterest):

  fromx = CreateDate(fromYear, fromMonth, fromDay)
  to = CreateDate(toYear, toMonth, toDay)

  amount = GetAccrualAmountWithDates(total, fromx, to, yearOfInterest, monthOfInterest)

  return amount

def GetAccruals(total, fromYear, fromMonth, fromDay, toYear, toMonth, toDay):

  fromx = CreateDate(fromYear, fromMonth, fromDay)
  to = CreateDate(toYear, toMonth, toDay)

  amounts = GetAccrualsWithDates(total, fromx, to)

  return amounts

def GetAccrualsWithDates(total, fromx, to):

  list = CreateLinkedListNumbers()
  message = StringReference()

  done = False
  dateOfInterest = Date()
  AssignDate(dateOfInterest, fromx)
  while  not done :
    if dateOfInterest.year == to.year and dateOfInterest.month == to.month:
      done = True

    entry = GetAccrualAmountWithDates(total, fromx, to, dateOfInterest.year, dateOfInterest.month)
    LinkedListAddNumber(list, entry)
    success = AddMonthsToDate(dateOfInterest, 1.0, message)
  

  result = LinkedListNumbersToArray(list)
  FreeLinkedListNumbers(list)

  return result

def GetAccrualAmountWithDates(total, fromx, to, yearOfInterest, monthOfInterest):

  message = StringReference()

  valuePerDay = CreateFixedPoint15d(13.0, 2.0)
  divisibleRemaining = CreateFixedPoint15d(13.0, 2.0)
  divisibleTotal = CreateFixedPoint15d(13.0, 2.0)
  amount = CreateFixedPoint15d(13.0, 2.0)

  days = DaysBetweenDates(fromx, to) + 1.0

  # DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining
  DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days))

  Multiply15d(divisibleTotal, valuePerDay, Number15d(days))
  unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, fromx, to, yearOfInterest, monthOfInterest)

  if  not Equals15d(divisibleRemaining, Number15d(0.0)) :
    daysToAdjust = Round(ToNumber15d(divisibleRemaining)*100.0)
    adjustTo = Date()
    AssignDate(adjustTo, fromx)
    AddDaysToDate(adjustTo, daysToAdjust - 1.0, message)

    adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, fromx, adjustTo, yearOfInterest, monthOfInterest)

    adjustTo = None
  else:
    adjustment = 0.0

  Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment))

  n = ToNumber15d(amount)

  valuePerDay = None
  divisibleRemaining = None
  divisibleTotal = None
  amount = None

  return n

def GetUnadjustedAccrualAmountWithDates(total, fromx, to, yearOfInterest, monthOfInterest):

  value = CreateFixedPoint15d(13.0, 2.0)
  valuePerDay = CreateFixedPoint15d(13.0, 2.0)
  remainder = CreateFixedPoint15d(13.0, 2.0)

  days = DaysBetweenDates(fromx, to) + 1.0
  # DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...
  success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days))

  if success:
    daysInMonth = GetDaysInMonth(yearOfInterest)

    if yearOfInterest < fromx.year:
      Assign15d(value, 0.0)
    elif yearOfInterest == fromx.year and monthOfInterest < fromx.month:
      Assign15d(value, 0.0)
    elif yearOfInterest > to.year:
      Assign15d(value, 0.0)
    elif yearOfInterest == to.year and monthOfInterest > to.month:
      Assign15d(value, 0.0)
    else:
      if fromx.year == yearOfInterest and fromx.month == monthOfInterest and to.year == yearOfInterest and to.month == monthOfInterest:
        daysInMonthOfInterest = days
      elif fromx.year == yearOfInterest and fromx.month == monthOfInterest:
        lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[int(monthOfInterest)])
        daysInMonthOfInterest = DaysBetweenDates(fromx, lastDayInMonth) + 1.0
      elif to.year == yearOfInterest and to.month == monthOfInterest:
        firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0)
        daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1.0
      else:
        daysInMonthOfInterest = daysInMonth[int(monthOfInterest)]

      # MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value
      Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest))

    daysInMonth = None

  n = ToNumber15d(value)

  value = None
  valuePerDay = None
  remainder = None

  return n

def CreateNewArrayData():

  data = Data()
  data.isArray = True
  data.isStruture = False
  data.isNumber = False
  data.isBoolean = False
  data.isString = False
  data.array = CreateArray()

  return data

def CreateNewStructData():

  data = Data()
  data.isStruture = True
  data.isArray = False
  data.isNumber = False
  data.isBoolean = False
  data.isString = False
  data.structure = CreateStructure()

  return data

def CreateStructure():

  st = Structure()
  st.keys = CreateArray()
  st.values = CreateArray()

  return st

def CreateNumberData(n):

  data = Data()
  data.isNumber = True
  data.isStruture = False
  data.isArray = False
  data.isBoolean = False
  data.isString = False
  data.number = n

  return data

def CreateBooleanData(b):

  data = Data()
  data.isBoolean = True
  data.isStruture = False
  data.isArray = False
  data.isNumber = False
  data.isString = False
  data.booleanx = b

  return data

def CreateStringData(string):

  data = Data()
  data.isString = True
  data.isStruture = False
  data.isArray = False
  data.isNumber = False
  data.isBoolean = False
  data.string = string

  return data

def CreateStructData(structure):

  data = Data()
  data.isString = False
  data.isStruture = True
  data.isArray = False
  data.isNumber = False
  data.isBoolean = False
  data.structure = structure

  return data

def CreateArrayData(array):

  data = Data()
  data.isString = False
  data.isStruture = False
  data.isArray = True
  data.isNumber = False
  data.isBoolean = False
  data.array = array

  return data

def CreateNoTypeData():

  data = Data()
  data.isStruture = False
  data.isArray = False
  data.isNumber = False
  data.isBoolean = False
  data.isString = False

  return data

def AddStructToArray(ar, st):

  data = CreateNewStructData()
  data.structure = None
  data.structure = st

  ArrayAdd(ar, data)

def AddArrayToArray(ar, ar2):

  data = CreateNewArrayData()
  data.array = None
  data.array = ar2

  ArrayAdd(ar, data)

def AddNumberToArray(ar, n):
  ArrayAdd(ar, CreateNumberData(n))

def AddBooleanToArray(ar, b):
  ArrayAdd(ar, CreateBooleanData(b))

def AddStringToArray(ar, str):
  ArrayAdd(ar, CreateStringData(str))

def AddDataToArray(ar, data):
  ArrayAdd(ar, data)

def StructKeys(st):
  return ArrayLength(st.keys)

def StructHasKey(st, key):

  hasKey = False
  i = 0.0
  while i < StructKeys(st):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      hasKey = True
    i = i + 1.0
  

  return hasKey

def StructKeyIndex(st, key):

  index =  -1.0
  i = 0.0
  while i < StructKeys(st):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      index = i
    i = i + 1.0
  

  return index

def GetStructKeys(st):

  nr = StructKeys(st)

  keys =  [None]*int(nr)

  i = 0.0
  while i < nr:
    keys[int(i)] = StringReference()
    keys[int(i)].string = arraysCopyString(st.keys.array[int(i)].string)
    i = i + 1.0
  

  return keys

def GetStructFromStruct(st, key):

  r = Structure()
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = st.values.array[int(i)].structure
    i = i + 1.0
  

  return r

def GetArrayFromStruct(st, key):

  r = Array()
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = st.values.array[int(i)].array
    i = i + 1.0
  

  return r

def GetNumberFromStruct(st, key):

  r = 0.0
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = st.values.array[int(i)].number
    i = i + 1.0
  

  return r

def GetBooleanFromStruct(st, key):

  r = False
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = st.values.array[int(i)].booleanx
    i = i + 1.0
  

  return r

def GetStringFromStruct(st, key):

  r = ""
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = st.values.array[int(i)].string
    i = i + 1.0
  

  return r

def GetDataFromStruct(st, key):

  r = Data()
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = None
      r = st.values.array[int(i)]
    i = i + 1.0
  

  return r

def GetDataFromStructWithCheck(st, key, foundRef):

  r = Data()
  foundRef.booleanValue = False
  i = 0.0
  while i < ArrayLength(st.keys):
    if arraysStringsEqual(st.keys.array[int(i)].string, key):
      r = None
      foundRef.booleanValue = True
      r = st.values.array[int(i)]
    i = i + 1.0
  

  return r

def AddStructToStruct(st, key, struct):

  if StructHasKey(st, key):
    i = StructKeyIndex(st, key)
    st.values.array[int(i)].structure = None
    st.values.array[int(i)].structure = struct
  else:
    AddStringToArray(st.keys, key)
    AddStructToArray(st.values, struct)

def AddArrayToStruct(st, key, ar):

  if StructHasKey(st, key):
    i = StructKeyIndex(st, key)
    st.values.array[int(i)].array = None
    st.values.array[int(i)].array = ar
  else:
    AddStringToArray(st.keys, key)
    AddArrayToArray(st.values, ar)

def AddNumberToStruct(st, key, n):

  if StructHasKey(st, key):
    i = StructKeyIndex(st, key)
    st.values.array[int(i)].number = n
  else:
    AddStringToArray(st.keys, key)
    AddNumberToArray(st.values, n)

def AddBooleanToStruct(st, key, b):

  if StructHasKey(st, key):
    i = StructKeyIndex(st, key)
    st.values.array[int(i)].booleanx = b
  else:
    AddStringToArray(st.keys, key)
    AddBooleanToArray(st.values, b)

def AddStringToStruct(st, key, value):

  if StructHasKey(st, key):
    i = StructKeyIndex(st, key)
    st.values.array[int(i)].string = None
    st.values.array[int(i)].string = value
  else:
    AddStringToArray(st.keys, key)
    AddStringToArray(st.values, value)

def AddDataToStruct(st, key, data):

  if StructHasKey(st, key):
    i = StructKeyIndex(st, key)
    FreeData(st.values.array[int(i)])
    st.values.array[int(i)] = data
  else:
    AddStringToArray(st.keys, key)
    AddDataToArray(st.values, data)

def FreeData(data):

  if data.isStruture:
    st = data.structure
    i = 0.0
    while i < StructKeys(st):
      FreeData(ArrayIndex(st.keys, i))
      FreeData(ArrayIndex(st.values, i))
      i = i + 1.0
    
    st = None
  elif data.isArray:
    FreeArray(data.array)

  data = None

def FreeArray(array):

  i = 0.0
  while i < ArrayLength(array):
    FreeData(array.array[int(i)])
    i = i + 1.0
  

  array.array = None
  array = None

def DataTypeEquals(a, b):

  equal = True
  equal = equal and a.isStruture == b.isStruture
  equal = equal and a.isArray == b.isArray
  equal = equal and a.isNumber == b.isNumber
  equal = equal and a.isBoolean == b.isBoolean
  equal = equal and a.isString == b.isString

  return equal

def IsStructure(a):

  itis = a.isStruture
  if a.isArray or a.isNumber or a.isBoolean or a.isString:
    itis = False

  return itis

def IsArray(a):

  itis = a.isArray
  if a.isStruture or a.isNumber or a.isBoolean or a.isString:
    itis = False

  return itis

def IsNumber(a):

  itis = a.isNumber
  if a.isStruture or a.isArray or a.isBoolean or a.isString:
    itis = False

  return itis

def IsBoolean(a):

  itis = a.isBoolean
  if a.isStruture or a.isArray or a.isNumber or a.isString:
    itis = False

  return itis

def IsString(a):

  itis = a.isString
  if a.isStruture or a.isArray or a.isNumber or a.isBoolean:
    itis = False

  return itis

def IsNoType(a):

  if  not a.isString  and  not a.isStruture  and  not a.isArray  and  not a.isNumber  and  not a.isBoolean :
    itis = True
  else:
    itis = False

  return itis

def CreateArray():

  array = Array()
  array.array =  [None]*int(10.0)
  array.length = 0.0

  return array

def CreateArrayWithInitialCapacity(capacity):

  array = Array()
  array.array =  [None]*int(capacity)
  array.length = 0.0

  return array

def ArrayAdd(array, value):
  if array.length == len(array.array):
    ArrayIncreaseSize(array)

  array.array[int(array.length)] = value
  array.length = array.length + 1.0

def ArrayAddString(array, value):

  data = CreateStringData(value)

  ArrayAdd(array, data)

def ArrayAddBoolean(array, value):

  data = CreateBooleanData(value)

  ArrayAdd(array, data)

def ArrayAddNumber(array, value):

  data = CreateNumberData(value)

  ArrayAdd(array, data)

def ArrayAddStruct(array, value):

  data = CreateStructData(value)

  ArrayAdd(array, data)

def ArrayAddArray(array, value):

  data = CreateArrayData(value)

  ArrayAdd(array, data)

def ArrayIncreaseSize(array):

  newLength = round(len(array.array)*3.0/2.0)
  newArray =  [None]*int(newLength)

  i = 0.0
  while i < len(array.array):
    newArray[int(i)] = array.array[int(i)]
    i = i + 1.0
  

  array.array = None

  array.array = newArray

def ArrayDecreaseSizeNecessary(array):

  needsDecrease = False

  if array.length > 10.0:
    needsDecrease = array.length <= round(len(array.array)*2.0/3.0)

  return needsDecrease

def ArrayDecreaseSize(array):

  newLength = round(len(array.array)*2.0/3.0)
  newArray =  [None]*int(newLength)

  i = 0.0
  while i < newLength:
    newArray[int(i)] = array.array[int(i)]
    i = i + 1.0
  

  array.array = None

  array.array = newArray

def ArrayIndex(array, index):
  return array.array[int(index)]

def ArrayIndexArray(array, index):
  return array.array[int(index)].array

def ArrayIndexStruct(array, index):
  return array.array[int(index)].structure

def ArrayIndexBoolean(array, index):
  return array.array[int(index)].booleanx

def ArrayIndexString(array, index):
  return array.array[int(index)].string

def ArrayIndexNumber(array, index):
  return array.array[int(index)].number

def ArrayLength(array):
  return array.length

def ArrayInsert(array, index, value):

  if array.length == len(array.array):
    ArrayIncreaseSize(array)

  i = array.length
  while i > index:
    array.array[int(i)] = array.array[int(i - 1.0)]
    i = i - 1.0
  

  array.array[int(index)] = value

  array.length = array.length + 1.0

def ArrayInsertString(array, index, value):

  data = CreateStringData(value)

  ArrayInsert(array, index, data)

def ArrayInsertBoolean(array, index, value):

  data = CreateBooleanData(value)

  ArrayInsert(array, index, data)

def ArrayInsertNumber(array, index, value):

  data = CreateNumberData(value)

  ArrayInsert(array, index, data)

def ArrayInsertStruct(array, index, value):

  data = CreateStructData(value)

  ArrayInsert(array, index, data)

def ArrayInsertArray(array, index, value):

  data = CreateArrayData(value)

  ArrayInsert(array, index, data)

def ArraySet(array, index, value):

  if index < array.length:
    array.array[int(index)] = value
    success = True
  else:
    success = False

  return success

def ArraySetString(array, index, value):

  data = CreateStringData(value)

  ArraySet(array, index, data)

def ArraySetBoolean(array, index, value):

  data = CreateBooleanData(value)

  ArraySet(array, index, data)

def ArraySetNumber(array, index, value):

  data = CreateNumberData(value)

  ArraySet(array, index, data)

def ArraySetStruct(array, index, value):

  data = CreateStructData(value)

  ArraySet(array, index, data)

def ArraySetArray(array, index, value):

  data = CreateArrayData(value)

  ArraySet(array, index, data)

def ArrayRemove(array, index):

  i = index
  while i < array.length - 1.0:
    array.array[int(i)] = array.array[int(i + 1.0)]
    i = i + 1.0
  

  array.length = array.length - 1.0

  if ArrayDecreaseSizeNecessary(array):
    ArrayDecreaseSize(array)

def ToStaticArray(arc):

  array =  [None]*int(arc.length)

  i = 0.0
  while i < arc.length:
    array[int(i)] = arc.array[int(i)]
    i = i + 1.0
  

  return array

def ToStaticNumberArray(array):

  n = ArrayLength(array)

  result =  [None]*int(n)

  i = 0.0
  while i < n:
    result[int(i)] = ArrayIndex(array, i).number
    i = i + 1.0
  

  return result

def ToStaticBooleanArray(array):

  n = ArrayLength(array)

  result =  [None]*int(n)

  i = 0.0
  while i < n:
    result[int(i)] = ArrayIndex(array, i).booleanx
    i = i + 1.0
  

  return result

def ToStaticStringArray(array):

  n = ArrayLength(array)

  result =  [None]*int(n)

  i = 0.0
  while i < n:
    result[int(i)] = StringReference()
    result[int(i)].string = ArrayIndex(array, i).string
    i = i + 1.0
  

  return result

def ToStaticArrayArray(array):

  n = ArrayLength(array)

  result =  [None]*int(n)

  i = 0.0
  while i < n:
    result[int(i)] = ArrayIndex(array, i).array
    i = i + 1.0
  

  return result

def ToStaticStructArray(array):

  n = ArrayLength(array)

  result =  [None]*int(n)

  i = 0.0
  while i < n:
    result[int(i)] = ArrayIndex(array, i).structure
    i = i + 1.0
  

  return result

def StaticArrayToArrayWithOptimalSize(src):

  #
  #         c = 10*(3/2)^n
  #         log(c) = log(10*(3/2)^n)
  #         log(c) = log(10) + log((3/2)^n)
  #         log(c) = 1 + log((3/2)^n)
  #         log(c) - 1 = log((3/2)^n)
  #         log(c) - 1 = n*log(3/2)
  #         n = (log(c) - 1)/log(3/2)
  #        

  c = len(src)
  n = (log(c) - 1.0)/log(3.0/2.0)

  newCapacity = ceil(10.0*(3.0/2.0)**ceil(n))

  dst = CreateArrayWithInitialCapacity(newCapacity)

  i = 0.0
  while i < len(src):
    dst.array[int(i)] = src[int(i)]
    i = i + 1.0
  

  return dst

def StaticArrayToArray(src):

  dst = CreateArrayWithInitialCapacity(len(src))
  i = 0.0
  while i < len(src):
    dst.array[int(i)] = src[int(i)]
    i = i + 1.0
  
  dst.length = len(src)

  return dst

def ArrayAddAll(backups, fromx):

  i = 0.0
  while i < ArrayLength(fromx):
    data = ArrayIndex(fromx, i)
    AddDataToArray(backups, data)
    i = i + 1.0
  

def SortStringArray(a):
  return SortStringArrayWithOptions(a, True)

def SortStringArrayDescending(a):
  return SortStringArrayWithOptions(a, False)

def SortStringArrayWithOptions(a, asc):

  len = ArrayLength(a)
  success = True
  i = 0.0
  while i < len and success:
    if IsString(ArrayIndex(a, i)):
      pass
    else:
      success = False
    i = i + 1.0
  

  if success:
    swapped = True
    i = 0.0
    while i < len - 1.0 and swapped:
      swapped = False
      j = 0.0
      while j < len - i - 1.0:
        da = a.array[int(j)]
        db = a.array[int(j + 1.0)]

        cmp = StringOrder(da.string, db.string)
        if asc:
          swap = cmp < 0.0
        else:
          swap = cmp > 0.0

        if swap:
          tmp = da.string
          da.string = db.string
          db.string = tmp
          swapped = True
        j = j + 1.0
      
      i = i + 1.0
    

  return success

def StringOrder(a, b):

  minimum = min(len(a),len(b))

  done = False
  order = 0.0
  i = 0.0
  while i < minimum and  not done :
    ac = ord(a[int(i)])
    bc = ord(b[int(i)])

    if ac < bc:
      done = True
      order = 1.0
    elif ac > bc:
      done = True
      order =  -1.0
    i = i + 1.0
  

  if  not done :
    if len(a) < len(b):
      order = 1.0
    elif len(a) > len(b):
      order =  -1.0

  return order

def SortNumberArray(a):
  return SortNumberArrayWithOptions(a, True)

def SortNumberArrayDescending(a):
  return SortNumberArrayWithOptions(a, False)

def SortNumberArrayWithOptions(a, asc):

  len = ArrayLength(a)
  success = True
  i = 0.0
  while i < len and success:
    if IsNumber(ArrayIndex(a, i)):
      pass
    else:
      success = False
    i = i + 1.0
  

  if success:
    swapped = True
    i = 0.0
    while i < len - 1.0 and swapped:
      swapped = False
      j = 0.0
      while j < len - i - 1.0:
        da = a.array[int(j)]
        db = a.array[int(j + 1.0)]

        if asc:
          swap = da.number > db.number
        else:
          swap = da.number < db.number

        if swap:
          tmp = da.number
          da.number = db.number
          db.number = tmp
          swapped = True
        j = j + 1.0
      
      i = i + 1.0
    

  return success

def SortStructArrayByNumberKey(a, key):
  return SortStructArrayByNumberKeyWithOptions(a, key, True)

def SortStructArrayByNumberKeyDescending(a, key):
  return SortStructArrayByNumberKeyWithOptions(a, key, False)

def SortStructArrayByNumberKeyWithOptions(a, key, asc):

  len = ArrayLength(a)
  success = True
  i = 0.0
  while i < len and success:
    da = ArrayIndex(a, i)
    if IsStructure(da):
      if StructHasKey(da.structure, key):
        da = GetDataFromStruct(da.structure, key)
        if IsNumber(da):
          pass
        else:
          success = False
      else:
        success = False
    else:
      success = False
    i = i + 1.0
  

  if success:
    swapped = True
    i = 0.0
    while i < len - 1.0 and swapped:
      swapped = False
      j = 0.0
      while j < len - i - 1.0:
        da = ArrayIndex(a, j)
        db = ArrayIndex(a, j + 1.0)

        na = GetNumberFromStruct(da.structure, key)
        nb = GetNumberFromStruct(db.structure, key)

        if asc:
          swap = na > nb
        else:
          swap = na < nb

        if swap:
          tmp = da.structure
          da.structure = db.structure
          db.structure = tmp
          swapped = True
        j = j + 1.0
      
      i = i + 1.0
    

  return success

def SortStructArrayByStringKey(a, key):
  return SortStructArrayByStringKeyWithOptions(a, key, True)

def SortStructArrayByStringKeyDescending(a, key):
  return SortStructArrayByStringKeyWithOptions(a, key, False)

def SortStructArrayByStringKeyWithOptions(a, key, asc):

  len = ArrayLength(a)
  success = True
  i = 0.0
  while i < len and success:
    da = ArrayIndex(a, i)
    if IsStructure(da):
      if StructHasKey(da.structure, key):
        da = GetDataFromStruct(da.structure, key)
        if IsString(da):
          pass
        else:
          success = False
      else:
        success = False
    else:
      success = False
    i = i + 1.0
  

  if success:
    swapped = True
    i = 0.0
    while i < len - 1.0 and swapped:
      swapped = False
      j = 0.0
      while j < len - i - 1.0:
        da = ArrayIndex(a, j)
        db = ArrayIndex(a, j + 1.0)

        sa = GetStringFromStruct(da.structure, key)
        sb = GetStringFromStruct(db.structure, key)

        cmp = StringOrder(sa, sb)
        if asc:
          swap = cmp < 0.0
        else:
          swap = cmp > 0.0
        if swap:
          tmp = da.structure
          da.structure = db.structure
          db.structure = tmp
          swapped = True
        j = j + 1.0
      
      i = i + 1.0
    

  return success

def arraysStringToNumberArray(string):

  array =  [None]*int(len(string))

  i = 0.0
  while i < len(string):
    array[int(i)] = ord(string[int(i)])
    i = i + 1.0
  
  return array

def arraysNumberArrayToString(array):

  string =  [None]*int(len(array))

  i = 0.0
  while i < len(array):
    string[int(i)] = unichr(int(array[int(i)]))
    i = i + 1.0
  
  return string

def arraysNumberArraysEqual(a, b):

  equal = True
  if len(a) == len(b):
    i = 0.0
    while i < len(a) and equal:
      if a[int(i)] != b[int(i)]:
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def arraysBooleanArraysEqual(a, b):

  equal = True
  if len(a) == len(b):
    i = 0.0
    while i < len(a) and equal:
      if a[int(i)] != b[int(i)]:
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def arraysStringsEqual(a, b):

  equal = True
  if len(a) == len(b):
    i = 0.0
    while i < len(a) and equal:
      if a[int(i)] != b[int(i)]:
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def arraysFillNumberArray(a, value):

  i = 0.0
  while i < len(a):
    a[int(i)] = value
    i = i + 1.0
  

def arraysFillString(a, value):

  i = 0.0
  while i < len(a):
    a[int(i)] = value
    i = i + 1.0
  

def arraysFillBooleanArray(a, value):

  i = 0.0
  while i < len(a):
    a[int(i)] = value
    i = i + 1.0
  

def arraysFillNumberArrayRange(a, value, fromx, to):

  if fromx >= 0.0 and fromx <= len(a) and to >= 0.0 and to <= len(a) and fromx <= to:
    length = to - fromx
    i = 0.0
    while i < length:
      a[int(fromx + i)] = value
      i = i + 1.0
    

    success = True
  else:
    success = False

  return success

def arraysFillBooleanArrayRange(a, value, fromx, to):

  if fromx >= 0.0 and fromx <= len(a) and to >= 0.0 and to <= len(a) and fromx <= to:
    length = to - fromx
    i = 0.0
    while i < length:
      a[int(fromx + i)] = value
      i = i + 1.0
    

    success = True
  else:
    success = False

  return success

def arraysFillStringRange(a, value, fromx, to):

  if fromx >= 0.0 and fromx <= len(a) and to >= 0.0 and to <= len(a) and fromx <= to:
    length = to - fromx
    i = 0.0
    while i < length:
      a[int(fromx + i)] = value
      i = i + 1.0
    

    success = True
  else:
    success = False

  return success

def arraysCopyNumberArray(a):

  n =  [None]*int(len(a))

  i = 0.0
  while i < len(a):
    n[int(i)] = a[int(i)]
    i = i + 1.0
  

  return n

def arraysCopyBooleanArray(a):

  n =  [None]*int(len(a))

  i = 0.0
  while i < len(a):
    n[int(i)] = a[int(i)]
    i = i + 1.0
  

  return n

def arraysCopyString(a):

  n =  [None]*int(len(a))

  i = 0.0
  while i < len(a):
    n[int(i)] = a[int(i)]
    i = i + 1.0
  

  return n

def arraysCopyNumberArrayRange(a, fromx, to, copyReference):

  if fromx >= 0.0 and fromx <= len(a) and to >= 0.0 and to <= len(a) and fromx <= to:
    length = to - fromx
    n =  [None]*int(length)

    i = 0.0
    while i < length:
      n[int(i)] = a[int(fromx + i)]
      i = i + 1.0
    

    copyReference.numberArray = n
    success = True
  else:
    success = False

  return success

def arraysCopyBooleanArrayRange(a, fromx, to, copyReference):

  if fromx >= 0.0 and fromx <= len(a) and to >= 0.0 and to <= len(a) and fromx <= to:
    length = to - fromx
    n =  [None]*int(length)

    i = 0.0
    while i < length:
      n[int(i)] = a[int(fromx + i)]
      i = i + 1.0
    

    copyReference.booleanArray = n
    success = True
  else:
    success = False

  return success

def arraysCopyStringRange(a, fromx, to, copyReference):

  if fromx >= 0.0 and fromx <= len(a) and to >= 0.0 and to <= len(a) and fromx <= to:
    length = to - fromx
    n =  [None]*int(length)

    i = 0.0
    while i < length:
      n[int(i)] = a[int(fromx + i)]
      i = i + 1.0
    

    copyReference.string = n
    success = True
  else:
    success = False

  return success

def arraysIsLastElement(length, index):
  return index + 1.0 == length

def arraysCreateNumberArray(length, value):

  array =  [None]*int(length)
  arraysFillNumberArray(array, value)

  return array

def arraysCreateBooleanArray(length, value):

  array =  [None]*int(length)
  arraysFillBooleanArray(array, value)

  return array

def arraysCreateString(length, value):

  array =  [None]*int(length)
  arraysFillString(array, value)

  return array

def arraysSwapElementsOfNumberArray(A, ai, bi):

  tmp = A[int(ai)]
  A[int(ai)] = A[int(bi)]
  A[int(bi)] = tmp

def arraysSwapElementsOfStringArray(A, ai, bi):

  tmp = A.stringArray[int(ai)]
  A.stringArray[int(ai)] = A.stringArray[int(bi)]
  A.stringArray[int(bi)] = tmp

def arraysReverseNumberArray(array):

  i = 0.0
  while i < len(array)/2.0:
    arraysSwapElementsOfNumberArray(array, i, len(array) - i - 1.0)
    i = i + 1.0
  

def arraysNumberArrayContains(a, e):

  found = False

  i = 0.0
  while i < len(a) and  not found :
    if arraysIndexNumber(a, i) == e:
      found = True
    i = i + 1.0
  

  return found

def arraysIndexNumber(array, index):
  return array[int(index)]

def arraysIndexChar(array, index):
  return array[int(index)]

def arraysIndexBoolean(array, index):
  return array[int(index)]

def arraysIndexString(array, index):
  return array[int(index)].string

def arraysGetMinimum(data, minimumReference):

  if len(data) >= 1.0:
    minimum = data[int(0.0)]
    i = 0.0
    while i < len(data):
      minimum = min(minimum,data[int(i)])
      i = i + 1.0
    
    minimumReference.numberValue = minimum
    success = True
  else:
    success = False

  return success

def arraysGetMaximum(data, maximumReference):

  if len(data) >= 1.0:
    maximum = data[int(0.0)]
    i = 0.0
    while i < len(data):
      maximum = max(maximum,data[int(i)])
      i = i + 1.0
    
    maximumReference.numberValue = maximum
    success = True
  else:
    success = False

  return success

def arraysAssignNumberArray(asx, bs):

  i = 0.0
  while i < min(len(asx),len(bs)):
    asx[int(i)] = bs[int(i)]
    i = i + 1.0
  

def arraysAssignBooleanArray(asx, bs):

  i = 0.0
  while i < min(len(asx),len(bs)):
    asx[int(i)] = bs[int(i)]
    i = i + 1.0
  

def arraysAssignString(asx, bs):

  i = 0.0
  while i < min(len(asx),len(bs)):
    asx[int(i)] = bs[int(i)]
    i = i + 1.0
  

def arraysRearrangeArray(asx, indexes):

  bs =  [None]*int(len(asx))

  arraysAssignNumberArray(bs, asx)

  i = 0.0
  while i < len(indexes):
    asx[int(i)] = bs[int(indexes[int(i)])]
    i = i + 1.0
  

  bs = None

def arraysSetNumberArrayRange(data, offset, str):

  i = 0.0
  while i < len(str) and offset + i < len(data):
    data[int(offset + i)] = str[int(i)]
    i = i + 1.0
  

def arraysCopyNumberArrayValues(a, b):

  success = len(a) == len(b)

  if success:
    i = 0.0
    while i < len(a):
      a[int(i)] = b[int(i)]
      i = i + 1.0
    

  return success

def arraysCopyBooleanArrayValues(a, b):

  success = len(a) == len(b)

  if success:
    i = 0.0
    while i < len(a):
      a[int(i)] = b[int(i)]
      i = i + 1.0
    

  return success

def arraysCopyStringValues(a, b):

  success = len(a) == len(b)

  if success:
    i = 0.0
    while i < len(a):
      a[int(i)] = b[int(i)]
      i = i + 1.0
    

  return success

def CreateStringScientificNotationDecimalFromNumber(n):

  mantissaReference = StringReference()
  exponentReference = StringReference()
  result =  [None]*int(0.0)

  if n < 0.0:
    isPositive = False
    n =  -n
  else:
    isPositive = True

  if n == 0.0:
    e = 0.0
  else:
    e = GetFirstDecimalDigitPosition(n)

    if e < 0.0:
      n = n*10.0**fabs(e)
    else:
      n = n/10.0**e

  mantissaReference.string = CreateStringDecimalFromNumber(n)
  exponentReference.string = CreateStringDecimalFromNumber(e)

  if  not isPositive :
    result = strAppendString(result, "-")

  result = strAppendString(result, mantissaReference.string)
  result = strAppendString(result, "e")
  result = strAppendString(result, exponentReference.string)

  return result

def CreateStringDecimalFromNumber(number):

  factorRef = NumberReference()

  isPositive = True

  if number < 0.0:
    isPositive = False
    number = fabs(number)

  if number == 0.0:
    str = "0"
  elif number > 999999999999999e99:
    # Guard the number against relaxations.
    if isPositive:
      str = "Infinity"
    else:
      str = "-Infinity"
  else:
    lessThan1 = number < 1.0

    # Guard the number against relaxations.
    if number < 1e-99:
      number = 0.0

    # 1. Turn number into an integer with 15 digits.
    number = NumberTo15DigitInteger(number, factorRef)
    factor = factorRef.numberValue
    factorRef = None

    # 2. Extract the 15 digits
    ds =  [None]*int(15.0)

    a = number
    zero = ord('0')
    d = 0.0
    while d < 15.0:
      x = a - floor(a/10.0)*10.0
      ds[int(15.0 - d - 1.0)] = unichr(int((x + zero)))
      a = floor(a/10.0)
      d = d + 1.0
    

    # 3. Remove trailing zeros
    tz = 0.0
    done = False
    d = 0.0
    while d < 15.0 and  not done :
      if ds[int(15.0 - d - 1.0)] == '0':
        tz = tz + 1.0
      else:
        done = True
      d = d + 1.0
    
    ds = strSubstring(ds, 0.0, 15.0 - tz)

    # 4. Determine if integer
    isInt = factor + tz >= 0.0

    # 5. Fill into formats
    if isInt:
      # |-----|
      # AAAAAAA00000000
      str =  [None]*int(15.0 + factor)
      d = 0.0
      while d < len(str):
        str[int(d)] = '0'
        d = d + 1.0
      
      d = 0.0
      while d < len(ds):
        str[int(d)] = ds[int(d)]
        d = d + 1.0
      
    elif lessThan1:
      #       |-----|
      # 0.0000AAAAAAA
      extra =  -factor - 15.0
      str =  [None]*int(2.0 + extra + 15.0 - tz)
      d = 0.0
      while d < len(str):
        str[int(d)] = '0'
        d = d + 1.0
      
      str[int(1.0)] = '.'
      d = 0.0
      while d < len(ds):
        str[int(2.0 + extra + d)] = ds[int(d)]
        d = d + 1.0
      
    else:
      # |-------|
      # AAAA.AAAA
      str =  [None]*int(1.0 + 15.0 - tz)
      dotpos = 15.0 + factor
      p = 0.0
      d = 0.0
      while d < len(str):
        if d == dotpos:
          str[int(d)] = '.'
        else:
          str[int(d)] = ds[int(p)]
          p = p + 1.0
        d = d + 1.0
      

  # Done
  if  not isPositive :
    str = strConcatenateString("-", str)

  return str

def CreateStringFromNumberWithCheck(number, base, stringRef):

  string = CreateDynamicArrayCharacters()
  isPositive = True

  if number < 0.0:
    isPositive = False
    number =  -number

  if number == 0.0:
    DynamicArrayAddCharacter(string, '0')
    success = True
  else:
    characterReference = CharacterReference()

    if IsInteger(base):
      success = True

      maximumDigits = GetMaximumDigitsForBase(base)

      digitPosition = GetFirstDigitPosition(number, base)

      hasPrintedPoint = False

      if  not isPositive :
        DynamicArrayAddCharacter(string, '-')

      # Print leading zeros.
      if digitPosition < 0.0:
        DynamicArrayAddCharacter(string, '0')
        DynamicArrayAddCharacter(string, '.')
        hasPrintedPoint = True
        i = 0.0
        while i <  -digitPosition - 1.0:
          DynamicArrayAddCharacter(string, '0')
          i = i + 1.0
        

      # Count trailing zeros
      trailingZeros = 0.0
      done = False
      i = 0.0
      while i < maximumDigits and  not done :
        d = GetDigit(number, base, maximumDigits - i - 1.0)
        if d == 0.0:
          trailingZeros = trailingZeros + 1.0
        else:
          done = True
        i = i + 1.0
      

      # Print number.
      i = 0.0
      while i < maximumDigits and success:
        d = GetDigit(number, base, i)

        if d >= base:
          d = base - 1.0

        if  not hasPrintedPoint  and digitPosition - i + 1.0 == 0.0:
          if maximumDigits - i > trailingZeros:
            DynamicArrayAddCharacter(string, '.')
          hasPrintedPoint = True

        if maximumDigits - i <= trailingZeros and hasPrintedPoint:
          pass
        else:
          success = GetSingleDigitCharacterFromNumberWithCheck(d, base, characterReference)
          if success:
            c = characterReference.characterValue
            DynamicArrayAddCharacter(string, c)
        i = i + 1.0
      

      if success:
        # Print trailing zeros.
        i = 0.0
        while i < digitPosition - maximumDigits + 1.0:
          DynamicArrayAddCharacter(string, '0')
          i = i + 1.0
        
    else:
      success = False

  if success:
    stringRef.string = DynamicArrayCharactersToArray(string)
    FreeDynamicArrayCharacters(string)

  # Done
  return success

def GetMaximumDigitsForBase(base):

  t = 10.0**15.0
  return floor(log10(t)/log10(base))

def GetMaximumDigitsForDecimal():
  return 15.0

def NumberTo15DigitInteger(n, factorRef):

  factors = GetPowersOfTenFor15d2e()
  dp = GetFirstDecimalDigitPosition(n)
  factorRef.numberValue = dp - 14.0

  i = 14.0 +  -dp

  n = MultiplyWithIntegerPowerOf10(n, factors, i)

  factors = None

  n = Round(n)

  if n >= 1e15:
    n = n/10.0
    factorRef.numberValue = factorRef.numberValue + 1.0

  return n

def MultiplyWithIntegerPowerOf10(n, factors, power):
  n = n*factors[int(power + 99.0)]

  return n

def GetFirstDecimalDigitPosition(n):

  n = fabs(n)

  factors = GetPowersOfTenFor15d2e()

  power = 1.0

  if n == 0.0:
    power = 0.0
  elif n > 999999999999999e99:
    # This guards against relaxed variables' max value
    power = 114.0
  elif n < 1e-99:
    # This guards against relaxed variables' min value
    power = -100.0
  else:
    found = False
    # Search the most likely space first.
    i = 99.0 - 20.0
    while i < 99.0 + 20.0 and  not found :
      if n >= factors[int(i)] and n < factors[int(i + 1.0)]:
        power = i - 99.0
        found = True
      i = i + 1.0
    
    # Search the whole space
    i = 0.0
    while i < len(factors) - 1.0 and  not found :
      if n >= factors[int(i)] and n < factors[int(i + 1.0)]:
        power = i - 99.0
        found = True
      i = i + 1.0
    
    if  not found :
      if n >= 100000000000000e99 and n <= 999999999999999e99:
        power = i - 99.0

  factors = None

  # Normal returns are -99 to 113. If -100 or 114 is returned, it means a relaxation is used.
  return power

def GetPowersOfTenFor15d2e():

  factors =  [None]*int(213.0)

  factors[int(0.0)] = 1e-99
  factors[int(1.0)] = 1e-98
  factors[int(2.0)] = 1e-97
  factors[int(3.0)] = 1e-96
  factors[int(4.0)] = 1e-95
  factors[int(5.0)] = 1e-94
  factors[int(6.0)] = 1e-93
  factors[int(7.0)] = 1e-92
  factors[int(8.0)] = 1e-91
  factors[int(9.0)] = 1e-90
  factors[int(10.0)] = 1e-89
  factors[int(11.0)] = 1e-88
  factors[int(12.0)] = 1e-87
  factors[int(13.0)] = 1e-86
  factors[int(14.0)] = 1e-85
  factors[int(15.0)] = 1e-84
  factors[int(16.0)] = 1e-83
  factors[int(17.0)] = 1e-82
  factors[int(18.0)] = 1e-81
  factors[int(19.0)] = 1e-80
  factors[int(20.0)] = 1e-79
  factors[int(21.0)] = 1e-78
  factors[int(22.0)] = 1e-77
  factors[int(23.0)] = 1e-76
  factors[int(24.0)] = 1e-75
  factors[int(25.0)] = 1e-74
  factors[int(26.0)] = 1e-73
  factors[int(27.0)] = 1e-72
  factors[int(28.0)] = 1e-71
  factors[int(29.0)] = 1e-70
  factors[int(30.0)] = 1e-69
  factors[int(31.0)] = 1e-68
  factors[int(32.0)] = 1e-67
  factors[int(33.0)] = 1e-66
  factors[int(34.0)] = 1e-65
  factors[int(35.0)] = 1e-64
  factors[int(36.0)] = 1e-63
  factors[int(37.0)] = 1e-62
  factors[int(38.0)] = 1e-61
  factors[int(39.0)] = 1e-60
  factors[int(40.0)] = 1e-59
  factors[int(41.0)] = 1e-58
  factors[int(42.0)] = 1e-57
  factors[int(43.0)] = 1e-56
  factors[int(44.0)] = 1e-55
  factors[int(45.0)] = 1e-54
  factors[int(46.0)] = 1e-53
  factors[int(47.0)] = 1e-52
  factors[int(48.0)] = 1e-51
  factors[int(49.0)] = 1e-50
  factors[int(50.0)] = 1e-49
  factors[int(51.0)] = 1e-48
  factors[int(52.0)] = 1e-47
  factors[int(53.0)] = 1e-46
  factors[int(54.0)] = 1e-45
  factors[int(55.0)] = 1e-44
  factors[int(56.0)] = 1e-43
  factors[int(57.0)] = 1e-42
  factors[int(58.0)] = 1e-41
  factors[int(59.0)] = 1e-40
  factors[int(60.0)] = 1e-39
  factors[int(61.0)] = 1e-38
  factors[int(62.0)] = 1e-37
  factors[int(63.0)] = 1e-36
  factors[int(64.0)] = 1e-35
  factors[int(65.0)] = 1e-34
  factors[int(66.0)] = 1e-33
  factors[int(67.0)] = 1e-32
  factors[int(68.0)] = 1e-31
  factors[int(69.0)] = 1e-30
  factors[int(70.0)] = 1e-29
  factors[int(71.0)] = 1e-28
  factors[int(72.0)] = 1e-27
  factors[int(73.0)] = 1e-26
  factors[int(74.0)] = 1e-25
  factors[int(75.0)] = 1e-24
  factors[int(76.0)] = 1e-23
  factors[int(77.0)] = 1e-22
  factors[int(78.0)] = 1e-21
  factors[int(79.0)] = 1e-20
  factors[int(80.0)] = 1e-19
  factors[int(81.0)] = 1e-18
  factors[int(82.0)] = 1e-17
  factors[int(83.0)] = 1e-16
  factors[int(84.0)] = 1e-15
  factors[int(85.0)] = 1e-14
  factors[int(86.0)] = 1e-13
  factors[int(87.0)] = 1e-12
  factors[int(88.0)] = 1e-11
  factors[int(89.0)] = 1e-10
  factors[int(90.0)] = 1e-9
  factors[int(91.0)] = 1e-8
  factors[int(92.0)] = 1e-7
  factors[int(93.0)] = 1e-6
  factors[int(94.0)] = 1e-5
  factors[int(95.0)] = 1e-4
  factors[int(96.0)] = 1e-3
  factors[int(97.0)] = 1e-2
  factors[int(98.0)] = 1e-1
  factors[int(99.0)] = 1e0
  factors[int(100.0)] = 1e1
  factors[int(101.0)] = 1e2
  factors[int(102.0)] = 1e3
  factors[int(103.0)] = 1e4
  factors[int(104.0)] = 1e5
  factors[int(105.0)] = 1e6
  factors[int(106.0)] = 1e7
  factors[int(107.0)] = 1e8
  factors[int(108.0)] = 1e9
  factors[int(109.0)] = 1e10
  factors[int(110.0)] = 1e11
  factors[int(111.0)] = 1e12
  factors[int(112.0)] = 1e13
  factors[int(113.0)] = 1e14
  factors[int(114.0)] = 1e15
  factors[int(115.0)] = 1e16
  factors[int(116.0)] = 1e17
  factors[int(117.0)] = 1e18
  factors[int(118.0)] = 1e19
  factors[int(119.0)] = 1e20
  factors[int(120.0)] = 1e21
  factors[int(121.0)] = 1e22
  factors[int(122.0)] = 1e23
  factors[int(123.0)] = 1e24
  factors[int(124.0)] = 1e25
  factors[int(125.0)] = 1e26
  factors[int(126.0)] = 1e27
  factors[int(127.0)] = 1e28
  factors[int(128.0)] = 1e29
  factors[int(129.0)] = 1e30
  factors[int(130.0)] = 1e31
  factors[int(131.0)] = 1e32
  factors[int(132.0)] = 1e33
  factors[int(133.0)] = 1e34
  factors[int(134.0)] = 1e35
  factors[int(135.0)] = 1e36
  factors[int(136.0)] = 1e37
  factors[int(137.0)] = 1e38
  factors[int(138.0)] = 1e39
  factors[int(139.0)] = 1e40
  factors[int(140.0)] = 1e41
  factors[int(141.0)] = 1e42
  factors[int(142.0)] = 1e43
  factors[int(143.0)] = 1e44
  factors[int(144.0)] = 1e45
  factors[int(145.0)] = 1e46
  factors[int(146.0)] = 1e47
  factors[int(147.0)] = 1e48
  factors[int(148.0)] = 1e49
  factors[int(149.0)] = 1e50
  factors[int(150.0)] = 1e51
  factors[int(151.0)] = 1e52
  factors[int(152.0)] = 1e53
  factors[int(153.0)] = 1e54
  factors[int(154.0)] = 1e55
  factors[int(155.0)] = 1e56
  factors[int(156.0)] = 1e57
  factors[int(157.0)] = 1e58
  factors[int(158.0)] = 1e59
  factors[int(159.0)] = 1e60
  factors[int(160.0)] = 1e61
  factors[int(161.0)] = 1e62
  factors[int(162.0)] = 1e63
  factors[int(163.0)] = 1e64
  factors[int(164.0)] = 1e65
  factors[int(165.0)] = 1e66
  factors[int(166.0)] = 1e67
  factors[int(167.0)] = 1e68
  factors[int(168.0)] = 1e69
  factors[int(169.0)] = 1e70
  factors[int(170.0)] = 1e71
  factors[int(171.0)] = 1e72
  factors[int(172.0)] = 1e73
  factors[int(173.0)] = 1e74
  factors[int(174.0)] = 1e75
  factors[int(175.0)] = 1e76
  factors[int(176.0)] = 1e77
  factors[int(177.0)] = 1e78
  factors[int(178.0)] = 1e79
  factors[int(179.0)] = 1e80
  factors[int(180.0)] = 1e81
  factors[int(181.0)] = 1e82
  factors[int(182.0)] = 1e83
  factors[int(183.0)] = 1e84
  factors[int(184.0)] = 1e85
  factors[int(185.0)] = 1e86
  factors[int(186.0)] = 1e87
  factors[int(187.0)] = 1e88
  factors[int(188.0)] = 1e89
  factors[int(189.0)] = 1e90
  factors[int(190.0)] = 1e91
  factors[int(191.0)] = 1e92
  factors[int(192.0)] = 1e93
  factors[int(193.0)] = 1e94
  factors[int(194.0)] = 1e95
  factors[int(195.0)] = 1e96
  factors[int(196.0)] = 1e97
  factors[int(197.0)] = 1e98
  factors[int(198.0)] = 1e99
  factors[int(199.0)] = 10e99
  factors[int(200.0)] = 100e99
  factors[int(201.0)] = 1000e99
  factors[int(202.0)] = 10000e99
  factors[int(203.0)] = 100000e99
  factors[int(204.0)] = 1000000e99
  factors[int(205.0)] = 10000000e99
  factors[int(206.0)] = 100000000e99
  factors[int(207.0)] = 1000000000e99
  factors[int(208.0)] = 10000000000e99
  factors[int(209.0)] = 100000000000e99
  factors[int(210.0)] = 1000000000000e99
  factors[int(211.0)] = 10000000000000e99
  factors[int(212.0)] = 100000000000000e99

  return factors

def GetFirstDigitPosition(n, base):

  maximumDigits = GetMaximumDigitsForBase(base)
  n = fabs(n)

  if n != 0.0:
    if floor(n) < base**maximumDigits:
      multiply = True
    else:
      multiply = False

    done = False
    m = 0.0
    i = 0.0
    while  not done :
      if multiply:
        m = n*base**i
        if floor(m) >= base**(maximumDigits - 1.0):
          done = True
      else:
        m = n/base**i
        if floor(m) < base**maximumDigits:
          done = True
      i = i + 1.0
    

    if multiply:
      power = maximumDigits - i
    else:
      power = maximumDigits + i - 2.0

    if Round(m) >= base**maximumDigits:
      power = power + 1.0
  else:
    power = 1.0

  return power

def GetSingleDigitCharacterFromNumberWithCheck(c, base, characterReference):

  numberTable = GetDigitCharacterTable()

  if c < base or c < len(numberTable):
    success = True
    characterReference.characterValue = numberTable[int(c)]
  else:
    success = False

  return success

def GetDecimalDigitCharacterFromNumberWithCheck(c, characterRef):

  numberTable = "0123456789"

  if c >= 0.0 and c < 10.0:
    success = True
    characterRef.characterValue = numberTable[int(c)]
  else:
    success = False

  return success

def GetDigitCharacterTable():

  numberTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"

  return numberTable

def GetDecimalDigit(n, index):

  digitPosition = GetFirstDecimalDigitPosition(n)

  return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index)

def GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index):

  n = fabs(n)

  factorRef = NumberReference()
  n = NumberTo15DigitInteger(n, factorRef)
  factorRef = None

  m = n
  d = 0.0
  i = 0.0
  while i < 15.0 - index:
    d = round(m % 10.0)
    m = m - d
    m = round(m/10.0)
    i = i + 1.0
  

  return d

def GetDigit(n, base, index):

  n = fabs(n)
  maximumDigits = GetMaximumDigitsForBase(base)
  digitPosition = GetFirstDigitPosition(n, base)

  e = maximumDigits - digitPosition - 1.0
  if e < 0.0:
    n = round(n/base**fabs(e))
  else:
    n = round(n*base**e)

  m = n
  d = 0.0
  i = 0.0
  while i < maximumDigits - index:
    d = round(m % base)
    m = m - d
    m = round(m/base)
    i = i + 1.0
  

  return d

def NumberToHumanReadableShortScale(n):

  k = 1000.0
  M = k*1000.0
  B = M*1000.0
  T = B*1000.0
  Q = T*1000.0
  suffix = " "

  if n < k:
    hasSuffix = False
  else:
    hasSuffix = True

  if n >= k and n < M:
    if n < 10.0*k:
      n = Round(n/100.0)
      n = n/10.0
    else:
      n = Round(n/k)
    suffix = "k"
  elif n >= M and n < B:
    if n < 10.0*M:
      n = Round(n/(k*100.0))
      n = n/10.0
    else:
      n = Round(n/M)
    suffix = "M"
  elif n >= B and n < T:
    if n < 10.0*B:
      n = Round(n/(M*100.0))
      n = n/10.0
    else:
      n = Round(n/B)
    suffix = "B"
  elif n >= T and n < Q:
    if n < 10.0*T:
      n = Round(n/(B*100.0))
      n = n/10.0
    else:
      n = Round(n/T)
    suffix = "T"
  elif n >= Q:
    if n < 10.0*Q:
      n = Round(n/(T*100.0))
      n = n/10.0
    else:
      n = Round(n/Q)
    suffix = "Q"

  res = CreateStringDecimalFromNumber(n)
  if hasSuffix:
    res = strAppendString(res, suffix)
        
  return res

def NumberToHumanReadableBinary(n):

  Ki = 1024.0
  Mi = Ki*1024.0
  Gi = Mi*1024.0
  Ti = Gi*1024.0
  Pi = Ti*1024.0
  Ei = Pi*1024.0
  Zi = Ei*1024.0
  Yi = Zi*1024.0
  suffix = " "

  if n < Ki:
    hasSuffix = False
  else:
    hasSuffix = True

  if n >= Ki and n < Mi:
    if n < 10.0*Ki:
      n = Round(n/(Ki/10.0))
      n = n/10.0
    else:
      n = Round(n/Ki)
    suffix = "Ki"
  elif n >= Mi and n < Gi:
    if n < 10.0*Mi:
      n = Round(n/(Mi/10.0))
      n = n/10.0
    else:
      n = Round(n/Mi)
    suffix = "Mi"
  elif n >= Gi and n < Ti:
    if n < 10.0*Gi:
      n = Round(n/(Gi/10.0))
      n = n/10.0
    else:
      n = Round(n/Gi)
    suffix = "Gi"
  elif n >= Ti and n < Pi:
    if n < 10.0*Ti:
      n = Round(n/(Ti/10.0))
      n = n/10.0
    else:
      n = Round(n/Ti)
    suffix = "Ti"
  elif n >= Pi and n < Ei:
    if n < 10.0*Pi:
      n = Round(n/(Pi/10.0))
      n = n/10.0
    else:
      n = Round(n/Pi)
    suffix = "Pi"
  elif n >= Ei and n < Zi:
    if n < 10.0*Ei:
      n = Round(n/(Ei/10.0))
      n = n/10.0
    else:
      n = Round(n/Ei)
    suffix = "Ei"
  elif n >= Zi and n < Yi:
    if n < 10.0*Zi:
      n = Round(n/(Zi/10.0))
      n = n/10.0
    else:
      n = Round(n/Zi)
    suffix = "Zi"
  elif n >= Yi:
    if n < 10.0*Yi:
      n = Round(n/(Yi/10.0))
      n = n/10.0
    else:
      n = Round(n/Yi)
    suffix = "Yi"

  res = CreateStringDecimalFromNumber(n)
  if hasSuffix:
    res = strAppendString(res, suffix)

  return res

def NumberToHumanReadableMetric(n):

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
  suffix = " "

  if n < k:
    hasSuffix = False
  else:
    hasSuffix = True

  if n >= k and n < M:
    if n < 10.0*k:
      n = Round(n/100.0)
      n = n/10.0
    else:
      n = Round(n/k)
    suffix = "k"
  elif n >= M and n < G:
    if n < 10.0*M:
      n = Round(n/(k*100.0))
      n = n/10.0
    else:
      n = Round(n/M)
    suffix = "M"
  elif n >= G and n < T:
    if n < 10.0*G:
      n = Round(n/(M*100.0))
      n = n/10.0
    else:
      n = Round(n/G)
    suffix = "G"
  elif n >= T and n < P:
    if n < 10.0*T:
      n = Round(n/(G*100.0))
      n = n/10.0
    else:
      n = Round(n/T)
    suffix = "T"
  elif n >= P and n < Ex:
    if n < 10.0*P:
      n = Round(n/(T*100.0))
      n = n/10.0
    else:
      n = Round(n/P)
    suffix = "P"
  elif n >= Ex and n < Z:
    if n < 10.0*Ex:
      n = Round(n/(P*100.0))
      n = n/10.0
    else:
      n = Round(n/Ex)
    suffix = "E"
  elif n >= Z and n < Y:
    if n < 10.0*Z:
      n = Round(n/(Ex*100.0))
      n = n/10.0
    else:
      n = Round(n/Z)
    suffix = "Z"
  elif n >= Y and n < R:
    if n < 10.0*Y:
      n = Round(n/(Z*100.0))
      n = n/10.0
    else:
      n = Round(n/Y)
    suffix = "Y"
  elif n >= R and n < Q:
    if n < 10.0*R:
      n = Round(n/(Y*100.0))
      n = n/10.0
    else:
      n = Round(n/R)
    suffix = "R"
  elif n >= Q:
    if n < 10.0*Q:
      n = Round(n/(R*100.0))
      n = n/10.0
    else:
      n = Round(n/Q)
    suffix = "Q"

  res = CreateStringDecimalFromNumber(n)
  if hasSuffix:
    res = strAppendString(res, suffix)

  return res

def IsValidNumber(str):

  numberRef = NumberReference()
  message = StringReference()

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

  numberRef = None
  message = None

  return valid

def IsValidInteger(str):

  numberRef = NumberReference()
  message = StringReference()

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

  if valid:
    valid = IsInteger(numberRef.numberValue)

  numberRef = None
  message = None

  return valid

def IsValidPositiveInteger(str):

  numberRef = NumberReference()
  message = StringReference()

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message)

  if valid:
    valid = IsInteger(numberRef.numberValue)
    if valid:
      valid = numberRef.numberValue >= 0.0

  numberRef = None
  message = None

  return valid

def CreateNumberFromDecimalStringWithCheck(string, decimalReference, message):
  return CreateDecimalNumberFromStringWithCheck(string, decimalReference, message)

def CreateNumberFromDecimalString(string):

  numberRef = CreateNumberReference(0.0)
  message = CreateStringReference("")
  CreateDecimalNumberFromStringWithCheck(string, numberRef, message)
  number = numberRef.numberValue

  numberRef = None
  message = None

  return number

def CreateNumberFromStringWithCheck(string, base, numberReference, message):

  numberIsPositive = CreateBooleanReference(True)
  exponentIsPositive = CreateBooleanReference(True)
  beforePoint = NumberArrayReference()
  afterPoint = NumberArrayReference()
  exponent = NumberArrayReference()

  if base >= 2.0 and base <= 36.0:
    success = ExtractPartsFromNumberString(string, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

    if success:
      numberReference.numberValue = CreateNumberFromParts(base, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray)
  else:
    success = False
    message.string = "Base must be from 2 to 36."

  return success

def CreateDecimalNumberFromStringWithCheck(string, numberReference, message):

  numberIsPositive = CreateBooleanReference(True)
  exponentIsPositive = CreateBooleanReference(True)
  beforePoint = NumberArrayReference()
  afterPoint = NumberArrayReference()
  exponent = NumberArrayReference()

  success = ExtractPartsFromNumberString(string, 10.0, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message)

  if success:
    numberReference.numberValue = CreateDecimalNumberFromParts(numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray)

  numberIsPositive = None
  exponentIsPositive = None
  beforePoint = None
  afterPoint = None
  exponent = None

  return success

def CreateNumberFromParts(base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent):

  n = 0.0
  e = 0.0
  digits = 0.0
  digitsStarted = False
  integerOffset = 0.0
  maxDigits = floor(15.0*log(10.0)/log(base))
  roundingDigitSet = False
  roundingDigit = 0.0

  # We construct an integer n, inserting one and one digit and shifting left.
  # We read up to a certain amount of digits.
  i = 0.0
  while i < len(beforePoint) + len(afterPoint) and digits < maxDigits + 1.0:
    if i < len(beforePoint):
      d = beforePoint[int(i)]
    else:
      d = afterPoint[int(i - len(beforePoint))]

    if digits < maxDigits:
      if d != 0.0:
        digitsStarted = True
        integerOffset = len(beforePoint) - i

      n = n*base
      n = n + d

      integerOffset = integerOffset - 1.0
    else:
      roundingDigitSet = True
      roundingDigit = d

    if digitsStarted:
      digits = digits + 1.0
    i = i + 1.0
  

  if roundingDigitSet:
    if roundingDigit >= base/2.0:
      n = n + 1.0

  i = 0.0
  while i < len(exponent):
    d = exponent[int(i)]
    e = e*base
    e = e + d
    i = i + 1.0
  

  if  not exponentIsPositive :
    e =  -e

  if  not numberIsPositive :
    n =  -n

  n = n*base**(e + integerOffset)

  return n

def CreateDecimalNumberFromParts(numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent):

  n = 0.0
  e = 0.0
  digits = 0.0
  digitsStarted = False
  integerOffset = 0.0
  maxDigits = 15.0
  roundingDigitSet = False
  roundingDigit = 0.0

  # We construct an integer n, inserting one and one digit and shifting left.
  # We read up to 15 digits, but we note a 16th digit to correctly round the result.
  i = 0.0
  while i < len(beforePoint) + len(afterPoint) and digits < maxDigits + 1.0:
    if i < len(beforePoint):
      d = beforePoint[int(i)]
    else:
      d = afterPoint[int(i - len(beforePoint))]

    if digits < maxDigits:
      if d != 0.0:
        digitsStarted = True
        integerOffset = len(beforePoint) - i

      n = n*10.0
      n = n + d

      integerOffset = integerOffset - 1.0
    else:
      roundingDigitSet = True
      roundingDigit = d

    if digitsStarted:
      digits = digits + 1.0
    i = i + 1.0
  

  if roundingDigitSet:
    if roundingDigit >= 5.0:
      n = n + 1.0

  i = 0.0
  while i < len(exponent):
    d = exponent[int(i)]
    e = e*10.0
    e = e + d
    i = i + 1.0
  

  if  not exponentIsPositive :
    e =  -e

  if  not numberIsPositive :
    n =  -n

  n = n*10.0**(e + integerOffset)

  return n

def ExtractPartsFromNumberString(n, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message):

  i = 0.0
  complete = False

  if i < len(n):
    if n[int(i)] == '-':
      numberIsPositive.booleanValue = False
      i = i + 1.0
    elif n[int(i)] == '+':
      numberIsPositive.booleanValue = True
      i = i + 1.0

    success = True
  else:
    success = False
    message.string = "Number cannot have length zero."

  if success:
    done = False
    count = 0.0
    while i + count < len(n) and  not done :
      if CharacterIsNumberCharacterInBase(n[int(i + count)], base):
        count = count + 1.0
      else:
        done = True
    

    if count >= 1.0:
      beforePoint.numberArray =  [None]*int(count)

      j = 0.0
      while j < count:
        beforePoint.numberArray[int(j)] = GetNumberFromNumberCharacterForBase(n[int(i + j)], base)
        j = j + 1.0
      

      i = i + count

      if i < len(n):
        success = True
      else:
        afterPoint.numberArray =  [None]*int(0.0)
        exponent.numberArray =  [None]*int(0.0)
        success = True
        complete = True
    else:
      success = False
      message.string = "Number must have at least one number after the optional sign."

  if success and  not complete :
    if n[int(i)] == '.':
      i = i + 1.0

      if i < len(n):
        done = False
        count = 0.0
        while i + count < len(n) and  not done :
          if CharacterIsNumberCharacterInBase(n[int(i + count)], base):
            count = count + 1.0
          else:
            done = True
        

        if count >= 1.0:
          afterPoint.numberArray =  [None]*int(count)

          j = 0.0
          while j < count:
            afterPoint.numberArray[int(j)] = GetNumberFromNumberCharacterForBase(n[int(i + j)], base)
            j = j + 1.0
          

          i = i + count

          if i < len(n):
            success = True
          else:
            exponent.numberArray =  [None]*int(0.0)
            success = True
            complete = True
        else:
          success = False
          message.string = "There must be at least one digit after the decimal point."
      else:
        success = False
        message.string = "There must be at least one digit after the decimal point."
    elif base <= 14.0 and (n[int(i)] == 'e' or n[int(i)] == 'E'):
      if i < len(n):
        success = True
        afterPoint.numberArray =  [None]*int(0.0)
      else:
        success = False
        message.string = "There must be at least one digit after the exponent."
    else:
      success = False
      message.string = "Expected decimal point or exponent symbol."

  if success and  not complete :
    if base <= 14.0 and (n[int(i)] == 'e' or n[int(i)] == 'E'):
      i = i + 1.0

      if i < len(n):
        if n[int(i)] == '-':
          exponentIsPositive.booleanValue = False
          i = i + 1.0
        elif n[int(i)] == '+':
          exponentIsPositive.booleanValue = True
          i = i + 1.0

        if i < len(n):
          done = False
          count = 0.0
          while i + count < len(n) and  not done :
            if CharacterIsNumberCharacterInBase(n[int(i + count)], base):
              count = count + 1.0
            else:
              done = True
          

          if count >= 1.0:
            exponent.numberArray =  [None]*int(count)

            j = 0.0
            while j < count:
              exponent.numberArray[int(j)] = GetNumberFromNumberCharacterForBase(n[int(i + j)], base)
              j = j + 1.0
            

            i = i + count

            if i == len(n):
              success = True
            else:
              success = False
              message.string = "There cannot be any characters past the exponent of the number."
          else:
            success = False
            message.string = "There must be at least one digit after the decimal point."
        else:
          success = False
          message.string = "There must be at least one digit after the exponent symbol."
      else:
        success = False
        message.string = "There must be at least one digit after the exponent symbol."
    else:
      success = False
      message.string = "Expected exponent symbol."

  return success

def GetNumberFromNumberCharacterForBase(c, base):

  numberTable = GetDigitCharacterTable()
  position = 0.0

  i = 0.0
  while i < base:
    if numberTable[int(i)] == c:
      position = i
    i = i + 1.0
  

  return position

def CharacterIsNumberCharacterInBase(c, base):

  numberTable = GetDigitCharacterTable()
  found = False

  i = 0.0
  while i < base:
    if numberTable[int(i)] == c:
      found = True
    i = i + 1.0
  

  return found

def StringToNumberArray(str):

  numberArrayReference = NumberArrayReference()
  stringReference = StringReference()

  StringToNumberArrayWithCheck(str, numberArrayReference, stringReference)

  numbers = numberArrayReference.numberArray

  numberArrayReference = None
  stringReference = None

  return numbers

def StringToNumberArrayWithCheck(str, numberArrayReference, errorMessage):

  numberStrings = strSplitByString(str, ",")

  numbers =  [None]*int(len(numberStrings))
  success = True
  numberReference = NumberReference()

  i = 0.0
  while i < len(numberStrings):
    numberString = numberStrings[int(i)].string
    trimmedNumberString = strTrim(numberString)
    success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage)
    numbers[int(i)] = numberReference.numberValue

    FreeStringReference(numberStrings[int(i)])
    trimmedNumberString = None
    i = i + 1.0
  

  numberStrings = None
  numberReference = None

  numberArrayReference.numberArray = numbers

  return success

def strWriteStringToStingStream(stream, index, src):

  i = 0.0
  while i < len(src):
    stream[int(index.numberValue + i)] = src[int(i)]
    i = i + 1.0
  
  index.numberValue = index.numberValue + len(src)

def strWriteCharacterToStingStream(stream, index, src):
  stream[int(index.numberValue)] = src
  index.numberValue = index.numberValue + 1.0

def strWriteBooleanToStingStream(stream, index, src):
  if src:
    strWriteStringToStingStream(stream, index, "true")
  else:
    strWriteStringToStingStream(stream, index, "false")

def strSubstringWithCheck(string, fromx, to, stringReference):

  if fromx >= 0.0 and fromx <= len(string) and to >= 0.0 and to <= len(string) and fromx <= to:
    stringReference.string = strSubstring(string, fromx, to)
    success = True
  else:
    success = False

  return success

def strSubstring(string, fromx, to):

  length = to - fromx

  n =  [None]*int(length)

  i = fromx
  while i < to:
    n[int(i - fromx)] = string[int(i)]
    i = i + 1.0
  

  return n

def strAppendString(s1, s2):

  newString = strConcatenateString(s1, s2)

  s1 = None

  return newString

def strConcatenateString(s1, s2):

  newString =  [None]*int(len(s1) + len(s2))

  i = 0.0
  while i < len(s1):
    newString[int(i)] = s1[int(i)]
    i = i + 1.0
  

  i = 0.0
  while i < len(s2):
    newString[int(len(s1) + i)] = s2[int(i)]
    i = i + 1.0
  

  return newString

def strAppendCharacter(string, c):

  newString = strConcatenateCharacter(string, c)

  string = None

  return newString

def strConcatenateCharacter(string, c):
  newString =  [None]*int(len(string) + 1.0)

  i = 0.0
  while i < len(string):
    newString[int(i)] = string[int(i)]
    i = i + 1.0
  

  newString[int(len(string))] = c

  return newString

def strSplitByCharacter(toSplit, splitBy):

  ll = CreateLinkedListString()

  next = CreateLinkedListCharacter()
  i = 0.0
  while i < len(toSplit):
    c = toSplit[int(i)]

    if c == splitBy:
      part = LinkedListCharactersToArray(next)
      LinkedListAddString(ll, part)
      FreeLinkedListCharacter(next)
      next = CreateLinkedListCharacter()
    else:
      LinkedListAddCharacter(next, c)
    i = i + 1.0
  

  part = LinkedListCharactersToArray(next)
  LinkedListAddString(ll, part)
  FreeLinkedListCharacter(next)

  parts = LinkedListStringsToArray(ll)
  FreeLinkedListString(ll)

  return parts

def strIndexOfCharacter(string, character, indexReference):

  found = False
  i = 0.0
  while i < len(string) and  not found :
    if string[int(i)] == character:
      found = True
      indexReference.numberValue = i
    i = i + 1.0
  

  return found

def strLastIndexOfCharacter(string, character, indexReference):

  found = False
  i = 0.0
  while i < len(string):
    if string[int(i)] == character:
      found = True
      indexReference.numberValue = i
    i = i + 1.0
  

  return found

def strSubstringEqualsWithCheck(string, fromx, substring, equalsReference):

  if fromx < len(string):
    success = True
    equalsReference.booleanValue = strSubstringEquals(string, fromx, substring)
  else:
    success = False

  return success

def strSubstringEquals(string, fromx, substring):

  equal = True
  if len(string) - fromx >= len(substring):
    i = 0.0
    while i < len(substring) and equal:
      if string[int(fromx + i)] != substring[int(i)]:
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def strIndexOfString(string, substring, indexReference):

  found = False
  i = 0.0
  while i < len(string) - len(substring) + 1.0 and  not found :
    if strSubstringEquals(string, i, substring):
      found = True
      indexReference.numberValue = i
    i = i + 1.0
  

  return found

def strContainsCharacter(string, character):

  found = False
  i = 0.0
  while i < len(string) and  not found :
    if string[int(i)] == character:
      found = True
    i = i + 1.0
  

  return found

def strContainsString(string, substring):
  return strIndexOfString(string, substring, NumberReference())

def strToUpperCase(string):

  i = 0.0
  while i < len(string):
    string[int(i)] = cToUpperCase(string[int(i)])
    i = i + 1.0
  

def strToLowerCase(string):

  i = 0.0
  while i < len(string):
    string[int(i)] = cToLowerCase(string[int(i)])
    i = i + 1.0
  

def strEqualsIgnoreCase(a, b):

  if len(a) == len(b):
    equal = True
    i = 0.0
    while i < len(a) and equal:
      if cToLowerCase(a[int(i)]) != cToLowerCase(b[int(i)]):
        equal = False
      i = i + 1.0
    
  else:
    equal = False

  return equal

def strReplaceString(string, toReplace, replaceWith):

  da = CreateDynamicArrayCharacters()

  equalsReference = BooleanReference()

  i = 0.0
  while i < len(string):
    success = strSubstringEqualsWithCheck(string, i, toReplace, equalsReference)
    if success:
      success = equalsReference.booleanValue

    if success and len(toReplace) > 0.0:
      j = 0.0
      while j < len(replaceWith):
        DynamicArrayAddCharacter(da, replaceWith[int(j)])
        j = j + 1.0
      
      i = i + len(toReplace)
    else:
      DynamicArrayAddCharacter(da, string[int(i)])
      i = i + 1.0
  

  result = DynamicArrayCharactersToArray(da)

  FreeDynamicArrayCharacters(da)

  return result

def strReplaceCharacterToNew(string, toReplace, replaceWith):

  result =  [None]*int(len(string))

  i = 0.0
  while i < len(string):
    if string[int(i)] == toReplace:
      result[int(i)] = replaceWith
    else:
      result[int(i)] = string[int(i)]
    i = i + 1.0
  

  return result

def strReplaceCharacter(string, toReplace, replaceWith):

  i = 0.0
  while i < len(string):
    if string[int(i)] == toReplace:
      string[int(i)] = replaceWith
    i = i + 1.0
  

def strTrim(string):

  # Find whitepaces at the start.
  lastWhitespaceLocationStart =  -1.0
  firstNonWhitespaceFound = False
  i = 0.0
  while i < len(string) and  not firstNonWhitespaceFound :
    if cIsWhiteSpace(string[int(i)]):
      lastWhitespaceLocationStart = i
    else:
      firstNonWhitespaceFound = True
    i = i + 1.0
  

  # Find whitepaces at the end.
  lastWhitespaceLocationEnd = len(string)
  firstNonWhitespaceFound = False
  i = len(string) - 1.0
  while i >= 0.0 and  not firstNonWhitespaceFound :
    if cIsWhiteSpace(string[int(i)]):
      lastWhitespaceLocationEnd = i
    else:
      firstNonWhitespaceFound = True
    i = i - 1.0
  

  if lastWhitespaceLocationStart < lastWhitespaceLocationEnd:
    result = strSubstring(string, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd)
  else:
    result =  [None]*int(0.0)

  return result

def strStartsWith(string, start):

  startsWithString = False
  if len(string) >= len(start):
    startsWithString = strSubstringEquals(string, 0.0, start)

  return startsWithString

def strEndsWith(string, end):

  endsWithString = False
  if len(string) >= len(end):
    endsWithString = strSubstringEquals(string, len(string) - len(end), end)

  return endsWithString

def strSplitByWhitespace(toSplit):

  ll = CreateLinkedListString()

  next = CreateLinkedListCharacter()
  i = 0.0
  while i < len(toSplit):
    c = toSplit[int(i)]

    split = False
    skip = 0.0
    while (c == ' ' or c == '\n' or c == '\t') and i + skip <= len(toSplit):
      if i + skip != len(toSplit):
        c = toSplit[int(i + skip)]
      skip = skip + 1.0
      split = True
    

    if split:
      part = LinkedListCharactersToArray(next)
      LinkedListAddString(ll, part)
      FreeLinkedListCharacter(next)
      next = CreateLinkedListCharacter()
      i = i + skip - 1.0
    else:
      LinkedListAddCharacter(next, c)
      i = i + 1.0
  

  part = LinkedListCharactersToArray(next)
  LinkedListAddString(ll, part)
  FreeLinkedListCharacter(next)

  parts = LinkedListStringsToArray(ll)
  FreeLinkedListString(ll)

  return parts

def strSplitByString(toSplit, splitBy):

  ll = CreateLinkedListString()

  next = CreateLinkedListCharacter()
  i = 0.0
  while i < len(toSplit):
    c = toSplit[int(i)]

    if strSubstringEquals(toSplit, i, splitBy):
      part = LinkedListCharactersToArray(next)
      LinkedListAddString(ll, part)
      FreeLinkedListCharacter(next)
      next = CreateLinkedListCharacter()
      i = i + len(splitBy)
    else:
      LinkedListAddCharacter(next, c)
      i = i + 1.0
  

  part = LinkedListCharactersToArray(next)
  LinkedListAddString(ll, part)
  FreeLinkedListCharacter(next)

  parts = LinkedListStringsToArray(ll)
  FreeLinkedListString(ll)

  return parts

def strStringIsBefore(a, b):

  before = False
  equal = True
  done = False

  if len(a) == 0.0 and len(b) > 0.0:
    before = True
  else:
    i = 0.0
    while i < len(a) and i < len(b) and  not done :
      if a[int(i)] != b[int(i)]:
        equal = False
      if cCharacterIsBefore(a[int(i)], b[int(i)]):
        before = True
      if cCharacterIsBefore(b[int(i)], a[int(i)]):
        done = True
      i = i + 1.0
    

    if equal:
      if len(a) < len(b):
        before = True

  return before

def strJoinStringsWithSeparator(strings, separator):

  index = CreateNumberReference(0.0)

  length = 0.0
  i = 0.0
  while i < len(strings):
    length = length + len(strings[int(i)].string)
    i = i + 1.0
  
  length = length + (len(strings) - 1.0)*len(separator)

  result =  [None]*int(length)

  i = 0.0
  while i < len(strings):
    string = strings[int(i)].string
    strWriteStringToStingStream(result, index, string)
    if i + 1.0 < len(strings):
      strWriteStringToStingStream(result, index, separator)
    i = i + 1.0
  

  index = None

  return result

def strJoinStrings(strings):

  index = CreateNumberReference(0.0)

  length = 0.0
  i = 0.0
  while i < len(strings):
    length = length + len(strings[int(i)].string)
    i = i + 1.0
  

  result =  [None]*int(length)

  i = 0.0
  while i < len(strings):
    string = strings[int(i)].string
    strWriteStringToStingStream(result, index, string)
    i = i + 1.0
  

  index = None

  return result

def strStringOrder(a, b):

  minimum = min(len(a),len(b))

  done = False
  order = 0.0
  i = 0.0
  while i < minimum and  not done :
    ac = ord(a[int(i)])
    bc = ord(b[int(i)])

    if ac < bc:
      done = True
      order = 1.0
    elif ac > bc:
      done = True
      order =  -1.0
    i = i + 1.0
  

  if  not done :
    if len(a) < len(b):
      order = 1.0
    elif len(a) > len(b):
      order =  -1.0

  return order

def strLeftPad(str, width):

  padded =  [None]*int(width)
  arraysFillString(padded, ' ')

  i = 0.0
  while i < len(str):
    padded[int(width - len(str) + i)] = str[int(i)]
    i = i + 1.0
  

  return padded

def strRightPad(str, width):

  padded =  [None]*int(width)
  arraysFillString(padded, ' ')

  i = 0.0
  while i < len(str):
    padded[int(i)] = str[int(i)]
    i = i + 1.0
  

  return padded

def cToLowerCase(character):

  toReturn = character
  if character == 'A':
    toReturn = 'a'
  elif character == 'B':
    toReturn = 'b'
  elif character == 'C':
    toReturn = 'c'
  elif character == 'D':
    toReturn = 'd'
  elif character == 'E':
    toReturn = 'e'
  elif character == 'F':
    toReturn = 'f'
  elif character == 'G':
    toReturn = 'g'
  elif character == 'H':
    toReturn = 'h'
  elif character == 'I':
    toReturn = 'i'
  elif character == 'J':
    toReturn = 'j'
  elif character == 'K':
    toReturn = 'k'
  elif character == 'L':
    toReturn = 'l'
  elif character == 'M':
    toReturn = 'm'
  elif character == 'N':
    toReturn = 'n'
  elif character == 'O':
    toReturn = 'o'
  elif character == 'P':
    toReturn = 'p'
  elif character == 'Q':
    toReturn = 'q'
  elif character == 'R':
    toReturn = 'r'
  elif character == 'S':
    toReturn = 's'
  elif character == 'T':
    toReturn = 't'
  elif character == 'U':
    toReturn = 'u'
  elif character == 'V':
    toReturn = 'v'
  elif character == 'W':
    toReturn = 'w'
  elif character == 'X':
    toReturn = 'x'
  elif character == 'Y':
    toReturn = 'y'
  elif character == 'Z':
    toReturn = 'z'

  return toReturn

def cToUpperCase(character):

  toReturn = character
  if character == 'a':
    toReturn = 'A'
  elif character == 'b':
    toReturn = 'B'
  elif character == 'c':
    toReturn = 'C'
  elif character == 'd':
    toReturn = 'D'
  elif character == 'e':
    toReturn = 'E'
  elif character == 'f':
    toReturn = 'F'
  elif character == 'g':
    toReturn = 'G'
  elif character == 'h':
    toReturn = 'H'
  elif character == 'i':
    toReturn = 'I'
  elif character == 'j':
    toReturn = 'J'
  elif character == 'k':
    toReturn = 'K'
  elif character == 'l':
    toReturn = 'L'
  elif character == 'm':
    toReturn = 'M'
  elif character == 'n':
    toReturn = 'N'
  elif character == 'o':
    toReturn = 'O'
  elif character == 'p':
    toReturn = 'P'
  elif character == 'q':
    toReturn = 'Q'
  elif character == 'r':
    toReturn = 'R'
  elif character == 's':
    toReturn = 'S'
  elif character == 't':
    toReturn = 'T'
  elif character == 'u':
    toReturn = 'U'
  elif character == 'v':
    toReturn = 'V'
  elif character == 'w':
    toReturn = 'W'
  elif character == 'x':
    toReturn = 'X'
  elif character == 'y':
    toReturn = 'Y'
  elif character == 'z':
    toReturn = 'Z'

  return toReturn

def cIsUpperCase(character):

  isUpper = True
  if character == 'A':
    pass
  elif character == 'B':
    pass
  elif character == 'C':
    pass
  elif character == 'D':
    pass
  elif character == 'E':
    pass
  elif character == 'F':
    pass
  elif character == 'G':
    pass
  elif character == 'H':
    pass
  elif character == 'I':
    pass
  elif character == 'J':
    pass
  elif character == 'K':
    pass
  elif character == 'L':
    pass
  elif character == 'M':
    pass
  elif character == 'N':
    pass
  elif character == 'O':
    pass
  elif character == 'P':
    pass
  elif character == 'Q':
    pass
  elif character == 'R':
    pass
  elif character == 'S':
    pass
  elif character == 'T':
    pass
  elif character == 'U':
    pass
  elif character == 'V':
    pass
  elif character == 'W':
    pass
  elif character == 'X':
    pass
  elif character == 'Y':
    pass
  elif character == 'Z':
    pass
  else:
    isUpper = False

  return isUpper

def cIsLowerCase(character):

  isLower = True
  if character == 'a':
    pass
  elif character == 'b':
    pass
  elif character == 'c':
    pass
  elif character == 'd':
    pass
  elif character == 'e':
    pass
  elif character == 'f':
    pass
  elif character == 'g':
    pass
  elif character == 'h':
    pass
  elif character == 'i':
    pass
  elif character == 'j':
    pass
  elif character == 'k':
    pass
  elif character == 'l':
    pass
  elif character == 'm':
    pass
  elif character == 'n':
    pass
  elif character == 'o':
    pass
  elif character == 'p':
    pass
  elif character == 'q':
    pass
  elif character == 'r':
    pass
  elif character == 's':
    pass
  elif character == 't':
    pass
  elif character == 'u':
    pass
  elif character == 'v':
    pass
  elif character == 'w':
    pass
  elif character == 'x':
    pass
  elif character == 'y':
    pass
  elif character == 'z':
    pass
  else:
    isLower = False

  return isLower

def cIsLetter(character):
  return cIsUpperCase(character) or cIsLowerCase(character)

def cIsNumber(character):

  isNumberx = True
  if character == '0':
    pass
  elif character == '1':
    pass
  elif character == '2':
    pass
  elif character == '3':
    pass
  elif character == '4':
    pass
  elif character == '5':
    pass
  elif character == '6':
    pass
  elif character == '7':
    pass
  elif character == '8':
    pass
  elif character == '9':
    pass
  else:
    isNumberx = False

  return isNumberx

def cIsWhiteSpace(character):

  isWhiteSpacex = True
  if character == ' ':
    pass
  elif character == '\t':
    pass
  elif character == '\n':
    pass
  elif character == '\r':
    pass
  else:
    isWhiteSpacex = False

  return isWhiteSpacex

def cIsSymbol(character):

  isSymbolx = True
  if character == '!':
    pass
  elif character == '\"':
    pass
  elif character == '#':
    pass
  elif character == '$':
    pass
  elif character == '%':
    pass
  elif character == '&':
    pass
  elif character == '\'':
    pass
  elif character == '(':
    pass
  elif character == ')':
    pass
  elif character == '*':
    pass
  elif character == '+':
    pass
  elif character == ',':
    pass
  elif character == '-':
    pass
  elif character == '.':
    pass
  elif character == '/':
    pass
  elif character == ':':
    pass
  elif character == ';':
    pass
  elif character == '<':
    pass
  elif character == '=':
    pass
  elif character == '>':
    pass
  elif character == '?':
    pass
  elif character == '@':
    pass
  elif character == '[':
    pass
  elif character == '\\':
    pass
  elif character == ']':
    pass
  elif character == '^':
    pass
  elif character == '_':
    pass
  elif character == '`':
    pass
  elif character == '{':
    pass
  elif character == '|':
    pass
  elif character == '}':
    pass
  elif character == '~':
    pass
  else:
    isSymbolx = False

  return isSymbolx

def cCharacterIsBefore(a, b):

  ad = ord(a)
  bd = ord(b)

  return ad < bd

def cDecimalDigitToCharacter(digit):

  if digit == 1.0:
    c = '1'
  elif digit == 2.0:
    c = '2'
  elif digit == 3.0:
    c = '3'
  elif digit == 4.0:
    c = '4'
  elif digit == 5.0:
    c = '5'
  elif digit == 6.0:
    c = '6'
  elif digit == 7.0:
    c = '7'
  elif digit == 8.0:
    c = '8'
  elif digit == 9.0:
    c = '9'
  else:
    c = '0'

  return c

def cCharacterToDecimalDigit(c):

  if c == '1':
    digit = 1.0
  elif c == '2':
    digit = 2.0
  elif c == '3':
    digit = 3.0
  elif c == '4':
    digit = 4.0
  elif c == '5':
    digit = 5.0
  elif c == '6':
    digit = 6.0
  elif c == '7':
    digit = 7.0
  elif c == '8':
    digit = 8.0
  elif c == '9':
    digit = 9.0
  else:
    digit = 0.0

  return digit

def cHexadecimalDigitToCharacter(digit):

  if digit == 1.0:
    c = '1'
  elif digit == 2.0:
    c = '2'
  elif digit == 3.0:
    c = '3'
  elif digit == 4.0:
    c = '4'
  elif digit == 5.0:
    c = '5'
  elif digit == 6.0:
    c = '6'
  elif digit == 7.0:
    c = '7'
  elif digit == 8.0:
    c = '8'
  elif digit == 9.0:
    c = '9'
  elif digit == 10.0:
    c = 'A'
  elif digit == 11.0:
    c = 'B'
  elif digit == 12.0:
    c = 'C'
  elif digit == 13.0:
    c = 'D'
  elif digit == 14.0:
    c = 'E'
  elif digit == 15.0:
    c = 'F'
  else:
    c = '0'

  return c

def cCharacterToHexadecimalDigit(c):

  if c == '1':
    digit = 1.0
  elif c == '2':
    digit = 2.0
  elif c == '3':
    digit = 3.0
  elif c == '4':
    digit = 4.0
  elif c == '5':
    digit = 5.0
  elif c == '6':
    digit = 6.0
  elif c == '7':
    digit = 7.0
  elif c == '8':
    digit = 8.0
  elif c == '9':
    digit = 9.0
  elif c == 'A':
    digit = 10.0
  elif c == 'B':
    digit = 11.0
  elif c == 'C':
    digit = 12.0
  elif c == 'D':
    digit = 13.0
  elif c == 'E':
    digit = 14.0
  elif c == 'F':
    digit = 15.0
  else:
    digit = 0.0

  return digit

def GetBlack():
  black = RGBA()
  black.a = 1.0
  black.r = 0.0
  black.g = 0.0
  black.b = 0.0
  return black

def GetWhite():
  white = RGBA()
  white.a = 1.0
  white.r = 1.0
  white.g = 1.0
  white.b = 1.0
  return white

def GetTransparent():
  transparent = RGBA()
  transparent.a = 0.0
  transparent.r = 0.0
  transparent.g = 0.0
  transparent.b = 0.0
  return transparent

def GetGray(percentage):
  black = RGBA()
  black.a = 1.0
  black.r = 1.0 - percentage
  black.g = 1.0 - percentage
  black.b = 1.0 - percentage
  return black

def CreateRGBColor(r, g, b):
  color = RGBA()
  color.a = 1.0
  color.r = r
  color.g = g
  color.b = b
  return color

def CreateRGBAColor(r, g, b, a):
  color = RGBA()
  color.a = a
  color.r = r
  color.g = g
  color.b = b
  return color

def CreateImage(w, h, color):

  image = RGBABitmapImage()
  image.x =  [None]*int(w)
  i = 0.0
  while i < w:
    image.x[int(i)] = RGBABitmap()
    image.x[int(i)].y =  [None]*int(h)
    j = 0.0
    while j < h:
      image.x[int(i)].y[int(j)] = RGBA()
      SetPixel(image, i, j, color)
      j = j + 1.0
    
    i = i + 1.0
  

  return image

def DeleteImage(image):

  w = ImageWidth(image)
  h = ImageHeight(image)

  i = 0.0
  while i < w:
    j = 0.0
    while j < h:
      image.x[int(i)].y[int(j)] = None
      j = j + 1.0
    
    image.x[int(i)] = None
    i = i + 1.0
  
  image = None

def ImageWidth(image):
  return len(image.x)

def ImageHeight(image):

  if ImageWidth(image) == 0.0:
    height = 0.0
  else:
    height = len(image.x[int(0.0)].y)

  return height

def SetPixel(image, x, y, color):
  if x >= 0.0 and x < ImageWidth(image) and y >= 0.0 and y < ImageHeight(image):
    image.x[int(x)].y[int(y)].a = color.a
    image.x[int(x)].y[int(y)].r = color.r
    image.x[int(x)].y[int(y)].g = color.g
    image.x[int(x)].y[int(y)].b = color.b

def DrawPixel(image, x, y, color):

  if x >= 0.0 and x < ImageWidth(image) and y >= 0.0 and y < ImageHeight(image):
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

    image.x[int(x)].y[int(y)].r = ro
    image.x[int(x)].y[int(y)].g = go
    image.x[int(x)].y[int(y)].b = bo
    image.x[int(x)].y[int(y)].a = ao

def CombineAlpha(asx, ad):
  return asx + ad*(1.0 - asx)

def AlphaBlend(cs, asx, cd, ad, ao):
  return (cs*asx + cd*ad*(1.0 - asx))/ao

def DrawHorizontalLine1px(image, x, y, length, color):

  i = 0.0
  while i < length:
    DrawPixel(image, x + i, y, color)
    i = i + 1.0
  

def DrawVerticalLine1px(image, x, y, height, color):

  i = 0.0
  while i < height:
    DrawPixel(image, x, y + i, color)
    i = i + 1.0
  

def DrawRectangle1px(image, x, y, width, height, color):
  DrawHorizontalLine1px(image, x, y, width + 1.0, color)
  DrawVerticalLine1px(image, x, y + 1.0, height + 1.0 - 1.0, color)
  DrawVerticalLine1px(image, x + width, y + 1.0, height + 1.0 - 1.0, color)
  DrawHorizontalLine1px(image, x + 1.0, y + height, width + 1.0 - 2.0, color)

def DrawImageOnImage(dst, src, topx, topy):

  y = 0.0
  while y < ImageHeight(src):
    x = 0.0
    while x < ImageWidth(src):
      if topx + x >= 0.0 and topx + x < ImageWidth(dst) and topy + y >= 0.0 and topy + y < ImageHeight(dst):
        DrawPixel(dst, topx + x, topy + y, GetImagePixel(src, x, y))
      x = x + 1.0
    
    y = y + 1.0
  

def DrawLine1px(image, x0, y0, x1, y1, color):
  XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color)

def XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color):

  olda = color.a

  steep = fabs(y1 - y0) > fabs(x1 - x0)

  if steep:
    t = x0
    x0 = y0
    y0 = t

    t = x1
    x1 = y1
    y1 = t
  if x0 > x1:
    t = x0
    x0 = x1
    x1 = t

    t = y0
    y0 = y1
    y1 = t

  dx = x1 - x0
  dy = y1 - y0
  g = dy/dx

  if dx == 0.0:
    g = 1.0

  xEnd = Round(x0)
  yEnd = y0 + g*(xEnd - x0)
  xGap = OneMinusFractionalPart(x0 + 0.5)
  xpxl1 = xEnd
  ypxl1 = floor(yEnd)
  if steep:
    DrawPixel(image, ypxl1, xpxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
    DrawPixel(image, ypxl1 + 1.0, xpxl1, SetBrightness(color, FractionalPart(yEnd)*xGap))
  else:
    DrawPixel(image, xpxl1, ypxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
    DrawPixel(image, xpxl1, ypxl1 + 1.0, SetBrightness(color, FractionalPart(yEnd)*xGap))
  intery = yEnd + g

  xEnd = Round(x1)
  yEnd = y1 + g*(xEnd - x1)
  xGap = FractionalPart(x1 + 0.5)
  xpxl2 = xEnd
  ypxl2 = floor(yEnd)
  if steep:
    DrawPixel(image, ypxl2, xpxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
    DrawPixel(image, ypxl2 + 1.0, xpxl2, SetBrightness(color, FractionalPart(yEnd)*xGap))
  else:
    DrawPixel(image, xpxl2, ypxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap))
    DrawPixel(image, xpxl2, ypxl2 + 1.0, SetBrightness(color, FractionalPart(yEnd)*xGap))

  if steep:
    x = xpxl1 + 1.0
    while x <= xpxl2 - 1.0:
      DrawPixel(image, floor(intery), x, SetBrightness(color, OneMinusFractionalPart(intery)))
      DrawPixel(image, floor(intery) + 1.0, x, SetBrightness(color, FractionalPart(intery)))
      intery = intery + g
      x = x + 1.0
    
  else:
    x = xpxl1 + 1.0
    while x <= xpxl2 - 1.0:
      DrawPixel(image, x, floor(intery), SetBrightness(color, OneMinusFractionalPart(intery)))
      DrawPixel(image, x, floor(intery) + 1.0, SetBrightness(color, FractionalPart(intery)))
      intery = intery + g
      x = x + 1.0
    

  color.a = olda

def OneMinusFractionalPart(x):
  return 1.0 - FractionalPart(x)

def FractionalPart(x):
  return x - floor(x)

def SetBrightness(color, newBrightness):
  color.a = newBrightness
  return color

def DrawQuadraticBezierCurve(image, x0, y0, cx, cy, x1, y1, color):

  dx = fabs(x0 - x1)
  dy = fabs(y0 - y1)

  dt = 1.0/sqrt(dx**2.0 + dy**2.0)

  xs = NumberReference()
  ys = NumberReference()
  xe = NumberReference()
  ye = NumberReference()

  QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, 0.0, xs, ys)
  t = dt
  while t <= 1.0:
    QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, xe, ye)
    DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color)
    xs.numberValue = xe.numberValue
    ys.numberValue = ye.numberValue
    t = t + dt
  

  xs = None
  ys = None
  xe = None
  ye = None

def QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, x, y):
  x.numberValue = (1.0 - t)**2.0*x0 + (1.0 - t)*2.0*t*cx + t**2.0*x1
  y.numberValue = (1.0 - t)**2.0*y0 + (1.0 - t)*2.0*t*cy + t**2.0*y1

def DrawCubicBezierCurve(image, x0, y0, c0x, c0y, c1x, c1y, x1, y1, color):

  dx = fabs(x0 - x1)
  dy = fabs(y0 - y1)

  dt = 1.0/sqrt(dx**2.0 + dy**2.0)

  xs = NumberReference()
  ys = NumberReference()
  xe = NumberReference()
  ye = NumberReference()

  CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, 0.0, xs, ys)
  t = dt
  while t <= 1.0:
    CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, xe, ye)
    DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color)
    xs.numberValue = xe.numberValue
    ys.numberValue = ye.numberValue
    t = t + dt
  

  xs = None
  ys = None
  xe = None
  ye = None

def CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, x, y):
  x.numberValue = (1.0 - t)**3.0*x0 + (1.0 - t)**2.0*3.0*t*c0x + (1.0 - t)*3.0*t**2.0*c1x + t**3.0*x1

  y.numberValue = (1.0 - t)**3.0*y0 + (1.0 - t)**2.0*3.0*t*c0y + (1.0 - t)*3.0*t**2.0*c1y + t**3.0*y1

def CopyImage(image):

  copy = CreateImage(ImageWidth(image), ImageHeight(image), GetTransparent())

  i = 0.0
  while i < ImageWidth(image):
    j = 0.0
    while j < ImageHeight(image):
      SetPixel(copy, i, j, GetImagePixel(image, i, j))
      j = j + 1.0
    
    i = i + 1.0
  

  return copy

def GetImagePixel(image, x, y):
  return image.x[int(x)].y[int(y)]

def HorizontalFlip(img):

  y = 0.0
  while y < ImageHeight(img):
    x = 0.0
    while x < ImageWidth(img)/2.0:
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
    
    y = y + 1.0
  

def DrawFilledRectangle(image, x, y, w, h, color):

  i = 0.0
  while i < w:
    j = 0.0
    while j < h:
      SetPixel(image, x + i, y + j, color)
      j = j + 1.0
    
    i = i + 1.0
  

def RotateAntiClockwise90Degrees(image):

  rotated = CreateImage(ImageHeight(image), ImageWidth(image), GetBlack())

  y = 0.0
  while y < ImageHeight(image):
    x = 0.0
    while x < ImageWidth(image):
      SetPixel(rotated, y, ImageWidth(image) - 1.0 - x, GetImagePixel(image, x, y))
      x = x + 1.0
    
    y = y + 1.0
  

  return rotated

def DrawCircle(canvas, xCenter, yCenter, radius, color):
  DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color)

def BresenhamsCircleDrawingAlgorithm(canvas, xCenter, yCenter, radius, color):

  y = radius
  x = 0.0

  delta = 3.0 - 2.0*radius
  while y >= x:
    DrawLine1px(canvas, xCenter + x, yCenter + y, xCenter + x, yCenter + y, color)
    DrawLine1px(canvas, xCenter + x, yCenter - y, xCenter + x, yCenter - y, color)
    DrawLine1px(canvas, xCenter - x, yCenter + y, xCenter - x, yCenter + y, color)
    DrawLine1px(canvas, xCenter - x, yCenter - y, xCenter - x, yCenter - y, color)

    DrawLine1px(canvas, xCenter - y, yCenter + x, xCenter - y, yCenter + x, color)
    DrawLine1px(canvas, xCenter - y, yCenter - x, xCenter - y, yCenter - x, color)
    DrawLine1px(canvas, xCenter + y, yCenter + x, xCenter + y, yCenter + x, color)
    DrawLine1px(canvas, xCenter + y, yCenter - x, xCenter + y, yCenter - x, color)

    if delta < 0.0:
      delta = delta + 4.0*x + 6.0
    else:
      delta = delta + 4.0*(x - y) + 10.0
      y = y - 1.0
    x = x + 1.0
  

def DrawCircleMidpointAlgorithm(canvas, xCenter, yCenter, radius, color):

  d = floor((5.0 - radius*4.0)/4.0)
  x = 0.0
  y = radius

  while x <= y:
    DrawPixel(canvas, xCenter + x, yCenter + y, color)
    DrawPixel(canvas, xCenter + x, yCenter - y, color)
    DrawPixel(canvas, xCenter - x, yCenter + y, color)
    DrawPixel(canvas, xCenter - x, yCenter - y, color)
    DrawPixel(canvas, xCenter + y, yCenter + x, color)
    DrawPixel(canvas, xCenter + y, yCenter - x, color)
    DrawPixel(canvas, xCenter - y, yCenter + x, color)
    DrawPixel(canvas, xCenter - y, yCenter - x, color)

    if d < 0.0:
      d = d + 2.0*x + 1.0
    else:
      d = d + 2.0*(x - y) + 1.0
      y = y - 1.0
    x = x + 1.0
  

def DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color):

  # Place the circle in the center of the pixel.
  xCenter = floor(xCenter) + 0.5
  yCenter = floor(yCenter) + 0.5

  pixels = 2.0*pi*radius

  # Below a radius of 10 pixels, over-compensate to get a smoother circle.
  if radius < 10.0:
    pixels = pixels*10.0

  da = 2.0*pi/pixels

  a = 0.0
  while a < 2.0*pi:
    dx = cos(a)*radius
    dy = sin(a)*radius

    # Floor to get the pixel coordinate.
    DrawPixel(canvas, floor(xCenter + dx), floor(yCenter + dy), color)
    a = a + da
  

def DrawFilledCircle(canvas, x, y, r, color):
  DrawFilledCircleBasicAlgorithm(canvas, x, y, r, color)

def DrawFilledCircleMidpointAlgorithm(canvas, xCenter, yCenter, radius, color):

  d = floor((5.0 - radius*4.0)/4.0)
  x = 0.0
  y = radius

  while x <= y:
    DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter + y, xCenter - x, yCenter + y, color)
    DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter - y, xCenter - x, yCenter - y, color)
    DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter + x, xCenter - y, yCenter + x, color)
    DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter - x, xCenter - y, yCenter - x, color)

    if d < 0.0:
      d = d + 2.0*x + 1.0
    else:
      d = d + 2.0*(x - y) + 1.0
      y = y - 1.0
    x = x + 1.0
  

def DrawFilledCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color):

  # Place the circle in the center of the pixel.
  xCenter = floor(xCenter) + 0.5
  yCenter = floor(yCenter) + 0.5

  pixels = 2.0*pi*radius

  # Below a radius of 10 pixels, over-compensate to get a smoother circle.
  if radius < 10.0:
    pixels = pixels*10.0

  da = 2.0*pi/pixels

  # Draw lines for a half-circle to fill an entire circle.
  a = 0.0
  while a < pi:
    dx = cos(a)*radius
    dy = sin(a)*radius

    # Floor to get the pixel coordinate.
    DrawVerticalLine1px(canvas, floor(xCenter - dx), floor(yCenter - dy), floor(2.0*dy) + 1.0, color)
    a = a + da
  

def DrawTriangle(canvas, xCenter, yCenter, height, color):

  x1 = floor(xCenter + 0.5)
  y1 = floor(floor(yCenter + 0.5) - height)
  x2 = x1 - 2.0*height*tan(pi/6.0)
  y2 = floor(y1 + 2.0*height)
  x3 = x1 + 2.0*height*tan(pi/6.0)
  y3 = floor(y1 + 2.0*height)

  DrawLine1px(canvas, x1, y1, x2, y2, color)
  DrawLine1px(canvas, x1, y1, x3, y3, color)
  DrawLine1px(canvas, x2, y2, x3, y3, color)

def DrawFilledTriangle(canvas, xCenter, yCenter, height, color):

  x1 = floor(xCenter + 0.5)
  y1 = floor(floor(yCenter + 0.5) - height)

  i = 0.0
  while i <= 2.0*height:
    offset = floor(i*tan(pi/6.0))
    DrawHorizontalLine1px(canvas, x1 - offset, y1 + i, 2.0*offset, color)
    i = i + 1.0
  

def DrawLine(canvas, x1, y1, x2, y2, thickness, color):
  DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color)

def DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color):

  dx = x2 - x1
  dy = y2 - y1

  incX = Sign(dx)
  incY = Sign(dy)

  dx = fabs(dx)
  dy = fabs(dy)

  if dx > dy:
    pdx = incX
    pdy = 0.0
    es = dy
    el = dx
  else:
    pdx = 0.0
    pdy = incY
    es = dx
    el = dy

  x = x1
  y = y1
  err = el/2.0

  if thickness >= 3.0:
    r = thickness/2.0
    DrawCircle(canvas, x, y, r, color)
  elif floor(thickness) == 2.0:
    DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
  elif floor(thickness) == 1.0:
    DrawPixel(canvas, x, y, color)

  t = 0.0
  while t < el:
    err = err - es
    if err < 0.0:
      err = err + el
      x = x + incX
      y = y + incY
    else:
      x = x + pdx
      y = y + pdy

    if thickness >= 3.0:
      r = thickness/2.0
      DrawCircle(canvas, x, y, r, color)
    elif floor(thickness) == 2.0:
      DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
    elif floor(thickness) == 1.0:
      DrawPixel(canvas, x, y, color)
    t = t + 1.0
  

def DrawLineBresenhamsAlgorithm(canvas, x1, y1, x2, y2, color):

  dx = x2 - x1
  dy = y2 - y1

  incX = Sign(dx)
  incY = Sign(dy)

  dx = fabs(dx)
  dy = fabs(dy)

  if dx > dy:
    pdx = incX
    pdy = 0.0
    es = dy
    el = dx
  else:
    pdx = 0.0
    pdy = incY
    es = dx
    el = dy

  x = x1
  y = y1
  err = el/2.0
  DrawPixel(canvas, x, y, color)

  t = 0.0
  while t < el:
    err = err - es
    if err < 0.0:
      err = err + el
      x = x + incX
      y = y + incY
    else:
      x = x + pdx
      y = y + pdy

    DrawPixel(canvas, x, y, color)
    t = t + 1.0
  

def DrawLineBresenhamsAlgorithmThickPatterned(canvas, x1, y1, x2, y2, thickness, pattern, offset, color):

  dx = x2 - x1
  dy = y2 - y1

  incX = Sign(dx)
  incY = Sign(dy)

  dx = fabs(dx)
  dy = fabs(dy)

  if dx > dy:
    pdx = incX
    pdy = 0.0
    es = dy
    el = dx
  else:
    pdx = 0.0
    pdy = incY
    es = dx
    el = dy

  x = x1
  y = y1
  err = el/2.0

  offset.numberValue = (offset.numberValue + 1.0) % (len(pattern)*thickness)

  if pattern[int(floor(offset.numberValue/thickness))]:
    if thickness >= 3.0:
      r = thickness/2.0
      DrawCircle(canvas, x, y, r, color)
    elif floor(thickness) == 2.0:
      DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
    elif floor(thickness) == 1.0:
      DrawPixel(canvas, x, y, color)

  t = 0.0
  while t < el:
    err = err - es
    if err < 0.0:
      err = err + el
      x = x + incX
      y = y + incY
    else:
      x = x + pdx
      y = y + pdy

    offset.numberValue = (offset.numberValue + 1.0) % (len(pattern)*thickness)

    if pattern[int(floor(offset.numberValue/thickness))]:
      if thickness >= 3.0:
        r = thickness/2.0
        DrawCircle(canvas, x, y, r, color)
      elif floor(thickness) == 2.0:
        DrawFilledRectangle(canvas, x, y, 2.0, 2.0, color)
      elif floor(thickness) == 1.0:
        DrawPixel(canvas, x, y, color)
    t = t + 1.0
  

def GetLinePattern5():

  pattern =  [None]*int(19.0)

  pattern[int(0.0)] = True
  pattern[int(1.0)] = True
  pattern[int(2.0)] = True
  pattern[int(3.0)] = True
  pattern[int(4.0)] = True
  pattern[int(5.0)] = True
  pattern[int(6.0)] = True
  pattern[int(7.0)] = True
  pattern[int(8.0)] = True
  pattern[int(9.0)] = True
  pattern[int(10.0)] = False
  pattern[int(11.0)] = False
  pattern[int(12.0)] = False
  pattern[int(13.0)] = True
  pattern[int(14.0)] = True
  pattern[int(15.0)] = True
  pattern[int(16.0)] = False
  pattern[int(17.0)] = False
  pattern[int(18.0)] = False

  return pattern

def GetLinePattern4():

  pattern =  [None]*int(13.0)

  pattern[int(0.0)] = True
  pattern[int(1.0)] = True
  pattern[int(2.0)] = True
  pattern[int(3.0)] = True
  pattern[int(4.0)] = True
  pattern[int(5.0)] = True
  pattern[int(6.0)] = True
  pattern[int(7.0)] = True
  pattern[int(8.0)] = True
  pattern[int(9.0)] = True
  pattern[int(10.0)] = False
  pattern[int(11.0)] = False
  pattern[int(12.0)] = False

  return pattern

def GetLinePattern3():

  pattern =  [None]*int(13.0)

  pattern[int(0.0)] = True
  pattern[int(1.0)] = True
  pattern[int(2.0)] = True
  pattern[int(3.0)] = True
  pattern[int(4.0)] = True
  pattern[int(5.0)] = True
  pattern[int(6.0)] = False
  pattern[int(7.0)] = False
  pattern[int(8.0)] = False
  pattern[int(9.0)] = True
  pattern[int(10.0)] = True
  pattern[int(11.0)] = False
  pattern[int(12.0)] = False

  return pattern

def GetLinePattern2():

  pattern =  [None]*int(4.0)

  pattern[int(0.0)] = True
  pattern[int(1.0)] = True
  pattern[int(2.0)] = False
  pattern[int(3.0)] = False

  return pattern

def GetLinePattern1():

  pattern =  [None]*int(8.0)

  pattern[int(0.0)] = True
  pattern[int(1.0)] = True
  pattern[int(2.0)] = True
  pattern[int(3.0)] = True
  pattern[int(4.0)] = True
  pattern[int(5.0)] = False
  pattern[int(6.0)] = False
  pattern[int(7.0)] = False

  return pattern

def Blur(src, pixels):

  w = ImageWidth(src)
  h = ImageHeight(src)
  dst = CreateImage(w, h, GetTransparent())

  x = 0.0
  while x < w:
    y = 0.0
    while y < h:
      SetPixel(dst, x, y, CreateBlurForPoint(src, x, y, pixels))
      y = y + 1.0
    
    x = x + 1.0
  

  return dst

def CreateBlurForPoint(src, x, y, pixels):

  w = ImageWidth(src)
  h = ImageHeight(src)

  rgba = RGBA()
  rgba.r = 0.0
  rgba.g = 0.0
  rgba.b = 0.0
  rgba.a = 0.0

  fromxx = x - pixels
  fromxx = max(fromxx,0.0)

  tox = x + pixels
  tox = min(tox,w - 1.0)

  fromy = y - pixels
  fromy = max(fromy,0.0)

  toy = y + pixels
  toy = min(toy,h - 1.0)

  countColor = 0.0
  countTransparent = 0.0
  i = fromxx
  while i < tox:
    j = fromy
    while j < toy:
      alpha = src.x[int(i)].y[int(j)].a
      if alpha > 0.0:
        rgba.r = rgba.r + src.x[int(i)].y[int(j)].r
        rgba.g = rgba.g + src.x[int(i)].y[int(j)].g
        rgba.b = rgba.b + src.x[int(i)].y[int(j)].b
        countColor = countColor + 1.0
      rgba.a = rgba.a + alpha
      countTransparent = countTransparent + 1.0
      j = j + 1.0
    
    i = i + 1.0
  

  if countColor > 0.0:
    rgba.r = rgba.r/countColor
    rgba.g = rgba.g/countColor
    rgba.b = rgba.b/countColor
  else:
    rgba.r = 0.0
    rgba.g = 0.0
    rgba.b = 0.0

  if countTransparent > 0.0:
    rgba.a = rgba.a/countTransparent
  else:
    rgba.a = 0.0

  return rgba

def ScaleNearestNeighborFloorFactor(src, factor):

  w = ImageWidth(src)
  h = ImageHeight(src)

  newWidth = Round(w*factor)
  newHeight = Round(h*factor)

  dst = ScaleNearestNeighborFloor(src, newWidth, newHeight)

  return dst

def ScaleNearestNeighborFloor(src, newWidth, newHeight):

  dst = CreateImage(newWidth, newHeight, GetTransparent())

  x = 0.0
  while x < newWidth:
    y = 0.0
    while y < newHeight:
      SetPixel(dst, x, y, GetNearestNeighborFloor(src, dst, x, y))
      y = y + 1.0
    
    x = x + 1.0
  

  return dst

def GetNearestNeighborFloor(src, dst, x, y):

  srcw = ImageWidth(src)
  srch = ImageHeight(src)
  dstw = ImageWidth(dst)
  dsth = ImageHeight(dst)

  nnx = floor(x*srcw/dstw)
  nny = floor(y*srch/dsth)

  return src.x[int(nnx)].y[int(nny)]

def ScaleNearestNeighborFactor(src, factor):

  w = ImageWidth(src)
  h = ImageHeight(src)

  newWidth = Round(w*factor)
  newHeight = Round(h*factor)

  dst = ScaleNearestNeighbor(src, newWidth, newHeight)

  return dst

def ScaleNearestNeighbor(src, newWidth, newHeight):

  dst = CreateImage(newWidth, newHeight, GetTransparent())

  x = 0.0
  while x < newWidth:
    y = 0.0
    while y < newHeight:
      SetPixel(dst, x, y, GetNearestNeighbor(src, dst, x, y))
      y = y + 1.0
    
    x = x + 1.0
  

  return dst

def GetNearestNeighbor(src, dst, x, y):

  srcw = ImageWidth(src)
  srch = ImageHeight(src)
  dstw = ImageWidth(dst)
  dsth = ImageHeight(dst)

  nnx = min(Round(x*srcw/dstw),srcw - 1.0)
  nny = min(Round(y*srch/dsth),srch - 1.0)

  return src.x[int(nnx)].y[int(nny)]

def BilinaerScaleUpFactor(src, factor):

  w = ImageWidth(src)
  h = ImageHeight(src)

  newWidth = Round(w*factor)
  newHeight = Round(h*factor)

  dst = BilinaerScaleUp(src, newWidth, newHeight)

  return dst

def BilinaerScaleUp(src, newWidth, newHeight):

  dst = CreateImage(newWidth, newHeight, GetTransparent())

  y = 0.0
  while y < newHeight:
    x = 0.0
    while x < newWidth:
      SetPixel(dst, x, y, GetBilinearlyScaledPixel(src, dst, x, y))
      x = x + 1.0
    
    y = y + 1.0
  

  return dst

def GetBilinearlyScaledPixel(src, dst, dstx, dsty):

  srcw = ImageWidth(src)
  srch = ImageHeight(src)
  dstw = ImageWidth(dst)
  dsth = ImageHeight(dst)

  x = dstx*srcw/dstw
  y = dsty*srch/dsth

  x = x + 0.25
  y = y + 0.25

  x1 = min(floor(x),srcw - 1.0)
  x2 = min(ceil(x),srcw - 1.0)
  y1 = min(floor(y),srch - 1.0)
  y2 = min(ceil(y),srch - 1.0)

  x1y1 = src.x[int(x1)].y[int(y1)]
  x1y2 = src.x[int(x1)].y[int(y2)]
  x2y1 = src.x[int(x2)].y[int(y1)]
  x2y2 = src.x[int(x2)].y[int(y2)]

  if x1 == x2:
    x2 = x2 + 1.0
  if y1 == y2:
    y2 = y2 + 1.0

  result = RGBA()

  result.r = GetBilinearInterpolation(x1y1.r, x2y1.r, x1y2.r, x2y2.r, x, y, x1, x2, y1, y2)
  result.g = GetBilinearInterpolation(x1y1.g, x2y1.g, x1y2.g, x2y2.g, x, y, x1, x2, y1, y2)
  result.b = GetBilinearInterpolation(x1y1.b, x2y1.b, x1y2.b, x2y2.b, x, y, x1, x2, y1, y2)
  result.a = GetBilinearInterpolation(x1y1.a, x2y1.a, x1y2.a, x2y2.a, x, y, x1, x2, y1, y2)

  return result

def GetBilinearInterpolation(q11, q12, q21, q22, x, y, x1, x2, y1, y2):

  h1 = (x2 - x)/(x2 - x1)*q11 + (x - x1)/(x2 - x1)*q12
  h2 = (x2 - x)/(x2 - x1)*q21 + (x - x1)/(x2 - x1)*q22

  v = (y2 - y)/(y2 - y1)*h1 + (y - y1)/(y2 - y1)*h2

  return v

def Negate(x):
  return  -x

def Positive(x):
  return  +x

def Factorial(x):

  f = 1.0

  i = 2.0
  while i <= x:
    f = f*i
    i = i + 1.0
  

  return f

def Round(x):
  return floor(x + 0.5)

def RoundToDigits(element, digitsAfterPoint):
  return Round(element*10.0**digitsAfterPoint)/10.0**digitsAfterPoint

def BankersRound(x):

  if Absolute(x - Truncate(x)) == 0.5:
    if  not DivisibleBy(Round(x), 2.0) :
      r = Round(x) - 1.0
    else:
      r = Round(x)
  else:
    r = Round(x)

  return r

def Ceil(x):
  return ceil(x)

def Floor(x):
  return floor(x)

def Truncate(x):

  if x >= 0.0:
    t = floor(x)
  else:
    t = ceil(x)

  return t

def Absolute(x):
  return fabs(x)

def Logarithm(x):
  return log10(x)

def NaturalLogarithm(x):
  return log(x)

def Sin(x):
  return sin(x)

def Cos(x):
  return cos(x)

def Tan(x):
  return tan(x)

def Asin(x):
  return asin(x)

def Acos(x):
  return acos(x)

def Atan(x):
  return atan(x)

def Atan2(y, x):

  # Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors.
  a = 0.0

  if x > 0.0:
    a = Atan(y/x)
  elif x < 0.0 and y >= 0.0:
    a = Atan(y/x) + pi
  elif x < 0.0 and y < 0.0:
    a = Atan(y/x) - pi
  elif x == 0.0 and y > 0.0:
    a = pi/2.0
  elif x == 0.0 and y < 0.0:
    a =  -pi/2.0

  return a

def Squareroot(x):
  return sqrt(x)

def Exp(x):
  return exp(x)

def DivisibleBy(a, b):
  return ((a % b) == 0.0)

def Combinations(n, k):

  c = 1.0
  j = 1.0
  i = n - k + 1.0

  while i <= n:
    c = c*i
    c = c/j

    i = i + 1.0
    j = j + 1.0
  

  return c

def Permutations(n, k):

  c = 1.0

  i = n - k + 1.0
  while i <= n:
    c = c*i
    i = i + 1.0
  

  return c

def EpsilonCompare(a, b, epsilon):
  return fabs(a - b) < epsilon

def GreatestCommonDivisor(a, b):

  while b != 0.0:
    t = b
    b = a % b
    a = t
  

  return a

def GCDWithSubtraction(a, b):

  if a == 0.0:
    g = b
  else:
    while b != 0.0:
      if a > b:
        a = a - b
      else:
        b = b - a
    

    g = a

  return g

def IsInteger(a):
  return (a - floor(a)) == 0.0

def GreatestCommonDivisorWithCheck(a, b, gcdReference):

  if IsInteger(a) and IsInteger(b):
    gcd = GreatestCommonDivisor(a, b)
    gcdReference.numberValue = gcd
    success = True
  else:
    success = False

  return success

def LeastCommonMultiple(a, b):

  if a > 0.0 and b > 0.0:
    lcm = fabs(a*b)/GreatestCommonDivisor(a, b)
  else:
    lcm = 0.0

  return lcm

def Sign(a):

  if a > 0.0:
    s = 1.0
  elif a < 0.0:
    s =  -1.0
  else:
    s = 0.0

  return s

def Max(a, b):
  return max(a,b)

def Min(a, b):
  return min(a,b)

def Power(a, b):
  return a**b

def Gamma(x):
  return LanczosApproximation(x)

def LogGamma(x):
  return log(Gamma(x))

def LanczosApproximation(z):

  p =  [None]*int(8.0)
  p[int(0.0)] = 676.5203681218851
  p[int(1.0)] =  -1259.1392167224028
  p[int(2.0)] = 771.32342877765313
  p[int(3.0)] =  -176.61502916214059
  p[int(4.0)] = 12.507343278686905
  p[int(5.0)] =  -0.13857109526572012
  p[int(6.0)] = 9.9843695780195716e-6
  p[int(7.0)] = 1.5056327351493116e-7

  if z < 0.5:
    y = pi/(sin(pi*z)*LanczosApproximation(1.0 - z))
  else:
    z = z - 1.0
    x = 0.99999999999980993
    i = 0.0
    while i < len(p):
      x = x + p[int(i)]/(z + i + 1.0)
      i = i + 1.0
    
    t = z + len(p) - 0.5
    y = sqrt(2.0*pi)*t**(z + 0.5)*exp( -t)*x

  return y

def Beta(x, y):
  return Gamma(x)*Gamma(y)/Gamma(x + y)

def Sinh(x):
  return (exp(x) - exp( -x))/2.0

def Cosh(x):
  return (exp(x) + exp( -x))/2.0

def Tanh(x):
  return Sinh(x)/Cosh(x)

def Cot(x):
  return 1.0/tan(x)

def Sec(x):
  return 1.0/cos(x)

def Csc(x):
  return 1.0/sin(x)

def Coth(x):
  return Cosh(x)/Sinh(x)

def Sech(x):
  return 1.0/Cosh(x)

def Csch(x):
  return 1.0/Sinh(x)

def Error(x):

  if x == 0.0:
    y = 0.0
  elif x < 0.0:
    y =  -Error( -x)
  else:
    c1 =  -1.26551223
    c2 =  +1.00002368
    c3 =  +0.37409196
    c4 =  +0.09678418
    c5 =  -0.18628806
    c6 =  +0.27886807
    c7 =  -1.13520398
    c8 =  +1.48851587
    c9 =  -0.82215223
    c10 =  +0.17087277

    t = 1.0/(1.0 + 0.5*fabs(x))

    tau = t*exp( -x**2.0 + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))))

    y = 1.0 - tau

  return y

def ErrorInverse(x):

  a = (8.0*(pi - 3.0))/(3.0*pi*(4.0 - pi))

  t = 2.0/(pi*a) + log(1.0 - x**2.0)/2.0
  y = Sign(x)*sqrt(sqrt(t**2.0 - log(1.0 - x**2.0)/a) - t)

  return y

def FallingFactorial(x, n):

  y = 1.0

  k = 0.0
  while k <= n - 1.0:
    y = y*(x - k)
    k = k + 1.0
  

  return y

def RisingFactorial(x, n):

  y = 1.0

  k = 0.0
  while k <= n - 1.0:
    y = y*(x + k)
    k = k + 1.0
  

  return y

def Hypergeometric(a, b, c, z, maxIterations, precision):

  if fabs(z) >= 0.5:
    y = (1.0 - z)**( -a)*HypergeometricDirect(a, c - b, c, z/(z - 1.0), maxIterations, precision)
  else:
    y = HypergeometricDirect(a, b, c, z, maxIterations, precision)

  return y

def HypergeometricDirect(a, b, c, z, maxIterations, precision):

  y = 0.0
  done = False

  n = 0.0
  while n < maxIterations and  not done :
    yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*z**n/Factorial(n)
    if fabs(yp) < precision:
      done = True
    y = y + yp
    n = n + 1.0
  

  return y

def BernouilliNumber(n):
  return AkiyamaTanigawaAlgorithm(n)

def AkiyamaTanigawaAlgorithm(n):

  A =  [None]*int(n + 1.0)

  m = 0.0
  while m <= n:
    A[int(m)] = 1.0/(m + 1.0)
    j = m
    while j >= 1.0:
      A[int(j - 1.0)] = j*(A[int(j - 1.0)] - A[int(j)])
      j = j - 1.0
    
    m = m + 1.0
  

  B = A[int(0.0)]

  A = None

  return B

def D15Add(a, b, overflow):

  x = a + b

  if x > D15MaxValue() or x < D15MinValue():
    overflow.booleanValue = True
    x = 0.0
  else:
    overflow.booleanValue = False
    x = RoundTo15Digits(x)

  return x

def RoundTo15Digits(x):

  p = floor(log10(x))
  x = x*10.0**(15.0 - p)
  x = Round(x)
  x = x/10.0**(15.0 - p)

  return x

def D15MaxValue():
  return  +9.99999999999999e99

def D15MinValue():
  return  -9.99999999999999e99

def D15Multiply(a, b, overflow):

  x = a*b

  if x > D15MaxValue() or x < D15MinValue():
    overflow.booleanValue = True
    x = 0.0
  else:
    overflow.booleanValue = False
    x = RoundTo15Digits(x)

  return x

def D15Divide(a, b, reminder, overflow, invalidOperation):

  if b != 0.0:
    invalidOperation.booleanValue = False

    x = a/b
    r = a % b

    if x > D15MaxValue() or x < D15MinValue():
      overflow.booleanValue = True
      x = 0.0
      r = 0.0
    else:
      overflow.booleanValue = False
      x = RoundTo15Digits(x)
      r = RoundTo15Digits(r)
  else:
    invalidOperation.booleanValue = True
    overflow.booleanValue = False
    x = 0.0
    r = 0.0

  reminder.numberValue = r

  return x

def D15Exponentiation(a, b, overflow, invalidOperation):

  if a == 0.0 and b == 0.0:
    invalidOperation.booleanValue = True
    overflow.booleanValue = False
    x = 0.0
  elif a < 0.0 and  not IsInteger(b) :
    invalidOperation.booleanValue = True
    overflow.booleanValue = False
    x = 0.0
  else:
    invalidOperation.booleanValue = False

    x = a**b

    if x > D15MaxValue() or x < D15MinValue():
      overflow.booleanValue = True
      x = 0.0
    else:
      overflow.booleanValue = False
      x = RoundTo15Digits(x)

  return x

def D15Modulus(a, b, invalidOperation):

  if a < 0.0 or b == 0.0 or b < 0.0:
    invalidOperation.booleanValue = True
    x = 0.0
  else:
    invalidOperation.booleanValue = False
    x = a % b
    x = RoundTo15Digits(x)

  return x

def D15Logarithm(a, invalidOperation):

  if a <= 0.0:
    invalidOperation.booleanValue = True
    x = 0.0
  else:
    invalidOperation.booleanValue = False
    x = log10(a)
    x = RoundTo15Digits(x)

  return x

def D15NaturalLogarithm(a, invalidOperation):

  if a <= 0.0:
    invalidOperation.booleanValue = True
    x = 0.0
  else:
    invalidOperation.booleanValue = False
    x = log(a)
    x = RoundTo15Digits(x)

  return x

def D15Sin(a):

  x = sin(a)
  x = RoundTo15Digits(x)

  return x

def D15Cos(x):

  x = fabs(x)

  limit = pi + 3.1/2.0

  if x > limit:
    f = floor(x/pi)
    x = x - pi*f

  piBy2Part1 =  +1.57079632679490
  piBy2Part2 =  -3.38076867830836e-15

  if x > 3.1/2.0 and x < 3.3/2.0:
    a = x - piBy2Part1
    a = round(a*10.0**15.0)/10.0**15.0
    a = a - piBy2Part2
    y =  -sin(a)
  else:
    y = cos(x)
    y = RoundTo15Digits(y)

  return y

def D15Tan(a, overflow):

  x = tan(a)

  if x > D15MaxValue() or x < D15MinValue():
    overflow.booleanValue = True
    x = 0.0
  else:
    overflow.booleanValue = False
    x = RoundTo15Digits(x)

  return x

def D15Asin(a, invalidOperation):

  if a <  -1.0 or a > 1.0:
    invalidOperation.booleanValue = True
    x = 0.0
  else:
    invalidOperation.booleanValue = False
    x = asin(a)
    x = RoundTo15Digits(x)

  return x

def D15Acos(a, invalidOperation):

  if a <  -1.0 or a > 1.0:
    invalidOperation.booleanValue = True
    x = 0.0
  else:
    invalidOperation.booleanValue = False
    x = acos(a)
    x = RoundTo15Digits(x)

  return x

def D15Atan(a):

  x = atan(a)
  x = RoundTo15Digits(x)

  return x

def D15Sqrt(a):

  x = sqrt(a)
  x = RoundTo15Digits(x)

  return x

def D15Exponential(a, overflow):

  x = exp(a)

  if x > D15MaxValue() or x < D15MinValue():
    overflow.booleanValue = True
    x = 0.0
  else:
    overflow.booleanValue = False
    x = RoundTo15Digits(x)

  return x

def Decimal15E2ToString(decimal):

  len = 21.0
  # 1+1+1+14+1+1+2 -- "+0.00000000000000e+00"
  result =  [None]*int(len)

  done = False
  exponent = 0.0

  if decimal < 0.0:
    isPositive = False
    decimal =  -decimal
  else:
    isPositive = True

  if decimal == 0.0:
    done = True

  if  not done :
    multiplier = 0.0
    inc = 0.0

    if decimal < 1.0:
      multiplier = 10.0
      inc =  -1.0
    elif decimal >= 10.0:
      multiplier = 0.1
      inc = 1.0
    else:
      done = True

    if  not done :
      exponent = round(log10(decimal))
      exponent = min(99.0,exponent)
      exponent = max( -99.0,exponent)

      decimal = decimal/10.0**exponent

      # Adjust
      while (decimal >= 10.0 or decimal < 1.0) and fabs(exponent) < 99.0:
        decimal = decimal*multiplier
        exponent = exponent + inc
      

  isPositiveExponent = exponent >= 0.0
  if  not isPositiveExponent :
    exponent =  -exponent

  if isPositive:
    result[int(0.0)] = '+'
  else:
    result[int(0.0)] = '-'

  decimal = round(decimal*10.0**14.0)

  d = floor(decimal/10.0**14.0)
  result[int(1.0)] = SingleDigitNumberToCharacter(d)
  decimal = decimal - d*10.0**14.0

  result[int(2.0)] = '.'

  i = 0.0
  while i < 14.0:
    d = floor(decimal/10.0**(13.0 - i))
    result[int(3.0 + i)] = SingleDigitNumberToCharacter(d)
    decimal = decimal - d*10.0**(13.0 - i)
    i = i + 1.0
  

  result[int(17.0)] = 'e'

  if isPositiveExponent:
    result[int(18.0)] = '+'
  else:
    result[int(18.0)] = '-'

  result[int(19.0)] = SingleDigitNumberToCharacter(floor(exponent/10.0))
  result[int(20.0)] = SingleDigitNumberToCharacter(floor(exponent % 10.0))

  return result

def SingleDigitNumberToCharacter(n):

  c = '0'
  if n == 0.0:
    c = '0'
  elif n == 1.0:
    c = '1'
  elif n == 2.0:
    c = '2'
  elif n == 3.0:
    c = '3'
  elif n == 4.0:
    c = '4'
  elif n == 5.0:
    c = '5'
  elif n == 6.0:
    c = '6'
  elif n == 7.0:
    c = '7'
  elif n == 8.0:
    c = '8'
  elif n == 9.0:
    c = '9'

  return c

def DigitDataBase16():
  return "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe891412108153069c4ffffffffffffffffffffffffffffffffffffffff9409000000000000000049e7ffffffffffffffffffffffffffffffffff61000000000000000000000017ddffffffffffffffffffffffffffffff840000000573d3f5e5a62b00000028f0ffffffffffffffffffffffffffda04000008bcfffffffffff44200000073ffffffffffffffffffffffffff5700000088ffffffffffffffe812000008e3ffffffffffffffffffffffea02000015f9ffffffffffffffff8100000080ffffffffffffffffffffff9c00000072ffffffffffffffffffe40100002fffffffffffffffffffffff51000000b8ffffffffffffffffffff2a000000e2ffffffffffffffffffff21000001f0ffffffffffffffffffff65000000b3fffffffffffffffffff602000018ffffffffffffffffffffff8b0000008affffffffffffffffffd200000036ffffffffffffffffffffffa900000063ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffb500000057ffffffffffffffffffffffc900000046ffffffffffffffffffa90000005fffffffffffffffffffffffd20000003affffffffffffffffffa900000060ffffffffffffffffffffffd30000003affffffffffffffffffb400000057ffffffffffffffffffffffca00000046ffffffffffffffffffc00000004effffffffffffffffffffffc100000052ffffffffffffffffffd100000037ffffffffffffffffffffffa900000063fffffffffffffffffff602000019ffffffffffffffffffffff8b00000089ffffffffffffffffffff21000001f1ffffffffffffffffffff66000000b3ffffffffffffffffffff50000000b8ffffffffffffffffffff2a000000e1ffffffffffffffffffff9c00000073ffffffffffffffffffe40100002fffffffffffffffffffffffea02000015f9ffffffffffffffff8200000080ffffffffffffffffffffffff5700000088ffffffffffffffe812000008e2ffffffffffffffffffffffffda04000008bcfffffffffff44300000073ffffffffffffffffffffffffffff830000000674d3f6e6a72b00000028f0ffffffffffffffffffffffffffffff60000000000000000000000016ddfffffffffffffffffffffffffffffffffe9309000000000000000048e6ffffffffffffffffffffffffffffffffffffffe88f3f1f07132e68c3fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9d7b28e69441f02000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6300000000000000000000afffffffffffffffffffffffffffffffffffff6a274c7095b9de64000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000afffffffffffffffffffffffffffffffffffffffffffffffffff67000000affffffffffffffffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bfffffffffffffffffffffffff7000000000000000000000000000000003bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffd48b56271005142a5ea0f6ffffffffffffffffffffffffffffffffdb7c20000000000000000000001392feffffffffffffffffffffffffffff1f00000000000000000000000000004cf9ffffffffffffffffffffffffff1f0000003784c7e7f9e8b1480000000056ffffffffffffffffffffffffff1f015accffffffffffffffff9701000000b0ffffffffffffffffffffffff58caffffffffffffffffffffff770000003cfffffffffffffffffffffffffffffffffffffffffffffffffff107000002edffffffffffffffffffffffffffffffffffffffffffffffffff3a000000ccffffffffffffffffffffffffffffffffffffffffffffffffff4c000000baffffffffffffffffffffffffffffffffffffffffffffffffff32000000cbffffffffffffffffffffffffffffffffffffffffffffffffec05000002edffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffeb140000009affffffffffffffffffffffffffffffffffffffffffffffff520000002afbffffffffffffffffffffffffffffffffffffffffffffff8c00000003c7ffffffffffffffffffffffffffffffffffffffffffffffb30300000085ffffffffffffffffffffffffffffffffffffffffffffffc50a0000005dfeffffffffffffffffffffffffffffffffffffffffffffd2110000004efbffffffffffffffffffffffffffffffffffffffffffffdb1800000042f8ffffffffffffffffffffffffffffffffffffffffffffe21f00000039f3ffffffffffffffffffffffffffffffffffffffffffffe92600000030efffffffffffffffffffffffffffffffffffffffffffffee2e00000029eafffffffffffffffffffffffffffffffffffffffffffff33700000022e5fffffffffffffffffffffffffffffffffffffffffffff7410000001cdffffffffffffffffffffffffffffffffffffffffffffffb4c00000017d9fffffffffffffffffffffffffffffffffffffffffffffd5900000012d2ffffffffffffffffffffffffffffffffffffffffffffff680000000ecbffffffffffffffffffffffffffffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffef0000000000000000000000000000000000008bffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe2af8058392817060a1a3f74c8ffffffffffffffffffffffffffffffffeb0000000000000000000000000036cfffffffffffffffffffffffffffffeb000000000000000000000000000004a7ffffffffffffffffffffffffffeb00000f5a9dd0edfbf0ca841900000003c2ffffffffffffffffffffffffec3da8f9fffffffffffffffff0410000002bffffffffffffffffffffffffffffffffffffffffffffffffffee12000000cbffffffffffffffffffffffffffffffffffffffffffffffffff6900000090ffffffffffffffffffffffffffffffffffffffffffffffffff9600000078ffffffffffffffffffffffffffffffffffffffffffffffffff9a0000007effffffffffffffffffffffffffffffffffffffffffffffffff73000000a5fffffffffffffffffffffffffffffffffffffffffffffffff51b000009edfffffffffffffffffffffffffffffffffffffffffffffff7540000007efffffffffffffffffffffffffffffffffffffffffff3d3912400000055fcffffffffffffffffffffffffffffffffff1700000000000000001692feffffffffffffffffffffffffffffffffffff17000000000000002db8feffffffffffffffffffffffffffffffffffffff170000000000000000002bc3fffffffffffffffffffffffffffffffffffffffffffdf0cf922e00000003a5fffffffffffffffffffffffffffffffffffffffffffffffffd8700000007d1ffffffffffffffffffffffffffffffffffffffffffffffffff780000004ffffffffffffffffffffffffffffffffffffffffffffffffffff308000006f6ffffffffffffffffffffffffffffffffffffffffffffffffff3c000000d0ffffffffffffffffffffffffffffffffffffffffffffffffff4d000000c6ffffffffffffffffffffffffffffffffffffffffffffffffff35000000ddffffffffffffffffffffffffffffffffffffffffffffffffea0300000bf9ffffffffffffffffffffffffffffffffffffffffffffffff6200000054ffffffffffffffffffffff47bafefffffffffffffffffff56b00000002cbffffffffffffffffffffff0b001e71a9d7edfbf6e4ba771a000000007cffffffffffffffffffffffff0b0000000000000000000000000000017dffffffffffffffffffffffffff0b000000000000000000000000003cc8ffffffffffffffffffffffffffffe9b989593827160608162a5689dbffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffbd0100000000f3fffffffffffffffffffffffffffffffffffffffffffff3200000000000f3ffffffffffffffffffffffffffffffffffffffffffff69000000000000f3ffffffffffffffffffffffffffffffffffffffffffbf01000b0e000000f3fffffffffffffffffffffffffffffffffffffffff42100008e1f000000f3ffffffffffffffffffffffffffffffffffffffff6a000035fc1f000000f3ffffffffffffffffffffffffffffffffffffffc0010004d1ff1f000000f3fffffffffffffffffffffffffffffffffffff42200007affff1f000000f3ffffffffffffffffffffffffffffffffffff6c000026f7ffff1f000000f3ffffffffffffffffffffffffffffffffffc1010001c1ffffff1f000000f3fffffffffffffffffffffffffffffffff523000066ffffffff1f000000f3ffffffffffffffffffffffffffffffff6d000019f0ffffffff1f000000f3ffffffffffffffffffffffffffffffc2010000aeffffffffff1f000000f3fffffffffffffffffffffffffffff524000052ffffffffffff1f000000f3ffffffffffffffffffffffffffff6e00000fe6ffffffffffff1f000000f3ffffffffffffffffffffffffffc30200009affffffffffffff1f000000f3fffffffffffffffffffffffff62400003ffeffffffffffffff1f000000f3ffffffffffffffffffffffff70000008daffffffffffffffff1f000000f3fffffffffffffffffffffff602000086ffffffffffffffffff1f000000f3fffffffffffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbfffffffffffffff3000000000000000000000000000000000000000000cbffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffff1f000000f3ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000000000000000000000000002fffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f00000fffffffffffffffffffffffffffffffffffffffffffffffffffff4f000008672f120514275997efffffffffffffffffffffffffffffffffff4f00000000000000000000000b73f6ffffffffffffffffffffffffffffff4f000000000000000000000000002bdeffffffffffffffffffffffffffff60538cbad2e7faf0d599370000000025ebffffffffffffffffffffffffffffffffffffffffffffffffa0090000005bffffffffffffffffffffffffffffffffffffffffffffffffffb100000001d2ffffffffffffffffffffffffffffffffffffffffffffffffff560000007effffffffffffffffffffffffffffffffffffffffffffffffffb80000003dffffffffffffffffffffffffffffffffffffffffffffffffffec00000022fffffffffffffffffffffffffffffffffffffffffffffffffffd00000011ffffffffffffffffffffffffffffffffffffffffffffffffffec00000022ffffffffffffffffffffffffffffffffffffffffffffffffffb80000003cffffffffffffffffffffffffffffffffffffffffffffffffff580000007dffffffffffffffffffffffffffffffffffffffffffffffffb301000000cfffffffffffffffffffffff4cb1fdffffffffffffffffffa40a00000058ffffffffffffffffffffffff17001a6ea9d7eefbf2d69b380000000024e8ffffffffffffffffffffffff1700000000000000000000000000002de0ffffffffffffffffffffffffff17000000000000000000000000127ef9ffffffffffffffffffffffffffffebba8a59372615050a1a3569a6f7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffca753915050d233866a3e0ffffffffffffffffffffffffffffffffffd13f0000000000000000000000f7ffffffffffffffffffffffffffffff9d07000000000000000000000000f7ffffffffffffffffffffffffffff9700000000469fdbf3f5da9e490100f7ffffffffffffffffffffffffffca0300000eb3ffffffffffffffffd84df8fffffffffffffffffffffffffa2d000007c8ffffffffffffffffffffffffffffffffffffffffffffffff9100000081ffffffffffffffffffffffffffffffffffffffffffffffffff28000010f6ffffffffffffffffffffffffffffffffffffffffffffffffc20000006affffffffffffffffffffffffffffffffffffffffffffffffff79000000b2ffffffffffffffffffffffffffffffffffffffffffffffffff43000000ebffeb903d1a0616306fc0ffffffffffffffffffffffffffffff0f000015ffa211000000000000000041dcfffffffffffffffffffffffff30000003087000000000000000000000013c6ffffffffffffffffffffffe30000000f00000055beeef7d8881000000017e6ffffffffffffffffffffd30000000000019dffffffffffffe12200000056ffffffffffffffffffffd100000000006effffffffffffffffce04000002dbffffffffffffffffffdd0000000006eaffffffffffffffffff550000008bffffffffffffffffffe90000000043ffffffffffffffffffffa90000004dfffffffffffffffffff80200000074ffffffffffffffffffffdb0000002cffffffffffffffffffff2200000088ffffffffffffffffffffef00000019ffffffffffffffffffff4d00000088ffffffffffffffffffffee0000001affffffffffffffffffff7e00000074ffffffffffffffffffffdb0000002dffffffffffffffffffffcd00000042ffffffffffffffffffffa900000052ffffffffffffffffffffff21000005e9ffffffffffffffffff5400000093ffffffffffffffffffffff8f0000006dffffffffffffffffcd04000007e6fffffffffffffffffffffff9220000019effffffffffffe1230000006cffffffffffffffffffffffffffc00600000056beeff8d888110000002af3ffffffffffffffffffffffffffffa603000000000000000000000026ddffffffffffffffffffffffffffffffffc8280000000000000000025deffffffffffffffffffffffffffffffffffffffab25a2a1106193b7ed7ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff47000000000000000000000000000000000000f7ffffffffffffffffffff47000000000000000000000000000000000003faffffffffffffffffffff4700000000000000000000000000000000004afffffffffffffffffffffffffffffffffffffffffffffffffc1a000000adffffffffffffffffffffffffffffffffffffffffffffffffb300000015faffffffffffffffffffffffffffffffffffffffffffffffff5100000073ffffffffffffffffffffffffffffffffffffffffffffffffea05000000d6ffffffffffffffffffffffffffffffffffffffffffffffff8d00000039ffffffffffffffffffffffffffffffffffffffffffffffffff2c0000009dffffffffffffffffffffffffffffffffffffffffffffffffc90000000cf3ffffffffffffffffffffffffffffffffffffffffffffffff6700000063fffffffffffffffffffffffffffffffffffffffffffffffff60f000000c6ffffffffffffffffffffffffffffffffffffffffffffffffa300000029ffffffffffffffffffffffffffffffffffffffffffffffffff410000008cffffffffffffffffffffffffffffffffffffffffffffffffdf01000005e9ffffffffffffffffffffffffffffffffffffffffffffffff7d00000052fffffffffffffffffffffffffffffffffffffffffffffffffd1e000000b5ffffffffffffffffffffffffffffffffffffffffffffffffb90000001bfcffffffffffffffffffffffffffffffffffffffffffffffff570000007bffffffffffffffffffffffffffffffffffffffffffffffffee07000001ddffffffffffffffffffffffffffffffffffffffffffffffff9300000042ffffffffffffffffffffffffffffffffffffffffffffffffff31000000a5ffffffffffffffffffffffffffffffffffffffffffffffffd000000010f7ffffffffffffffffffffffffffffffffffffffffffffffff6d0000006bfffffffffffffffffffffffffffffffffffffffffffffffff913000000ceffffffffffffffffffffffffffffffffffffffffffffffffa900000031ffffffffffffffffffffffffffffffffffffffffffffffffff4700000094ffffffffffffffffffffffffffffffffffffffffffffffffe302000008eeffffffffffffffffffffffffffffffffffffffffffffffff840000005afffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff9a8602c13050c1d4882dfffffffffffffffffffffffffffffffffffffa918000000000000000000025eeeffffffffffffffffffffffffffffff780000000000000000000000000023e5ffffffffffffffffffffffffff9f0000000037a8e4faf1c66d0500000033fdfffffffffffffffffffffff81600000065fdffffffffffffc40a0000009fffffffffffffffffffffffb600000021faffffffffffffffff8d00000047ffffffffffffffffffffff820000007bffffffffffffffffffeb01000014ffffffffffffffffffffff6d000000a2ffffffffffffffffffff15000001fdffffffffffffffffffff76000000a2ffffffffffffffffffff14000007ffffffffffffffffffffffa10000007bffffffffffffffffffec01000033ffffffffffffffffffffffec08000022fbffffffffffffffff8e00000087ffffffffffffffffffffffff7d00000068fdffffffffffffc70b00001ef2fffffffffffffffffffffffffb5500000039aae5fbf2c87006000013d0fffffffffffffffffffffffffffffe93160000000000000000000153e3ffffffffffffffffffffffffffffffffffbd2e000000000000000780f0ffffffffffffffffffffffffffffffffce3500000000000000000000000e87fcffffffffffffffffffffffffffb3060000004fb2e6faf0cd82150000004ffaffffffffffffffffffffffda0b000004a9ffffffffffffffe93600000076ffffffffffffffffffffff5600000084ffffffffffffffffffe80e000005e2fffffffffffffffffff606000008f4ffffffffffffffffffff6f0000008dffffffffffffffffffcb00000039ffffffffffffffffffffffac0000005cffffffffffffffffffbc0000004affffffffffffffffffffffbe0000004dffffffffffffffffffcc00000039ffffffffffffffffffffffac0000005effffffffffffffffffea00000008f4ffffffffffffffffffff6e0000007cffffffffffffffffffff2f00000085ffffffffffffffffffe70d000000c1ffffffffffffffffffff9300000004a9ffffffffffffffe83400000028fcfffffffffffffffffffffa2d0000000050b2e7fbf2cd821400000002b8ffffffffffffffffffffffffe523000000000000000000000000000299fffffffffffffffffffffffffffff16605000000000000000000002cc5ffffffffffffffffffffffffffffffffffe88e542512040b1b3d72c1fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff8a259251008203f8be2ffffffffffffffffffffffffffffffffffffffa91d0000000000000000047ffaffffffffffffffffffffffffffffffff7b00000000000000000000000040f8ffffffffffffffffffffffffffff94000000004db9ecf7da8b1300000057ffffffffffffffffffffffffffdc050000008fffffffffffffe527000000acffffffffffffffffffffffff630000005fffffffffffffffffd406000025fbfffffffffffffffffffffb0c000002e0ffffffffffffffffff5f000000b2ffffffffffffffffffffc600000036ffffffffffffffffffffb50000005fffffffffffffffffffffa000000068ffffffffffffffffffffe700000011feffffffffffffffffff8d0000007cfffffffffffffffffffffb00000000dfffffffffffffffffff8c0000007cfffffffffffffffffffffb00000000b4ffffffffffffffffff9e00000069ffffffffffffffffffffe7000000008dffffffffffffffffffbe00000038ffffffffffffffffffffb6000000007bfffffffffffffffffff606000003e2ffffffffffffffffff62000000006fffffffffffffffffffff4f00000064ffffffffffffffffd8080000000062ffffffffffffffffffffc50000000096ffffffffffffe82b000000000064ffffffffffffffffffffff6c0000000051bbeff8dc8e1500001000000074fffffffffffffffffffffff94f0000000000000000000000288c00000084fffffffffffffffffffffffffd810b000000000000000052ea830000009fffffffffffffffffffffffffffffea8d471d090d2864c1ffff5b000000d4ffffffffffffffffffffffffffffffffffffffffffffffffff2100000dfdffffffffffffffffffffffffffffffffffffffffffffffffd900000052ffffffffffffffffffffffffffffffffffffffffffffffffff75000000b8ffffffffffffffffffffffffffffffffffffffffffffffffe30d000023fefffffffffffffffffffffffffffffffffffffffffffffff945000000b7ffffffffffffffffffffffffff7fa2fdffffffffffffffe8480000005effffffffffffffffffffffffffff63002080c4ecfae7c0740e00000034f4ffffffffffffffffffffffffffff6300000000000000000000000043f0ffffffffffffffffffffffffffffff6300000000000000000000118efdfffffffffffffffffffffffffffffffff4bb7f462b15040b25569ff4ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff"

def DrawDigitCharacter(image, topx, topy, digit):

  colorReference = NumberReference()
  errorMessage = StringReference()
  color = RGBA()

  colorChars =  [None]*int(2.0)

  allCharData = DigitDataBase16()

  y = 0.0
  while y < 37.0:
    x = 0.0
    while x < 30.0:
      colorChars[int(0.0)] = allCharData[int(digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 0.0)]
      colorChars[int(1.0)] = allCharData[int(digit*30.0*37.0*2.0 + y*2.0*30.0 + x*2.0 + 1.0)]

      strToUpperCase(colorChars)
      CreateNumberFromStringWithCheck(colorChars, 16.0, colorReference, errorMessage)
      color.r = colorReference.numberValue/255.0
      color.g = colorReference.numberValue/255.0
      color.b = colorReference.numberValue/255.0
      color.a = 1.0
      SetPixel(image, topx + x, topy + y, color)
      x = x + 1.0
    
    y = y + 1.0
  

def GetPixelFontData():
  return "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001100000011000000000000000000000011000000110000001100000011000000110000001100000011000000000000000000000000000000000000000000000000000000000000000000000000000011011000110110001101100011011000000000000000000000000000110011001100110111111110110011001100110111111110110011001100110000000000000000000000000000000000001100001111110111111111101100011111000011111100001111100011011111111110111111000011000000000000000000001110000110110001101101101110110000011000001100000110000011011101101101100011011000011100000000000000000111111100110001111110011000110110000111000001110000110110011001100110011001101100001110000000000000000000000000000000000000000000000000000000000000000000000000000011000001110000011000001110000000000000000000000110000000110000000110000001100000011000000110000001100000011000000110000011000001100000000000000000000000011000001100000110000001100000011000000110000001100000011000000110000000110000000110000000000000000000000000000000000100110010101101000111100111111110011110001011010100110010000000000000000000000000000000000000000000110000001100000011000111111111111111100011000000110000001100000000000000000000000000000000000000011000001100000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011111111111111110000000000000000000000000000000000000000000000000000000000000000000111000001110000000000000000000000000000000000000000000000000000000000000000000000000000000110000001100000110000001100000110000001100000110000001100000110000001100000110000001100000000000000000000000011110001100110110000111100011111001111110110111111001111100011110000110110011000111100000000000000000001111110000110000001100000011000000110000001100000011000000110000001111000011100000110000000000000000000111111110000001100000011000001100000110000011000001100000110000011000000111001110111111000000000000000000111111011100111110000001100000011100000011111101110000011000000110000001110011101111110000000000000000000110000001100000011000000110000001100001111111100110011001101100011110000111000001100000000000000000000011111101110011111000000110000001110000001111111000000110000001100000011000000111111111100000000000000000111111011100111110000111100001111100011011111110000001100000011000000111110011101111110000000000000000000001100000011000000110000001100000110000011000001100000110000001100000011000000111111110000000000000000011111101110011111000011110000111110011101111110111001111100001111000011111001110111111000000000000000000111111011100111110000001100000011000000111111101110011111000011110000111110011101111110000000000000000000000000000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000000000000011000001100000111000001110000000000000000000001110000011100000000000000000000000000000000000000000000110000000110000000110000000110000000110000000110000011000001100000110000011000001100000000000000000000000000000000000001111111111111111000000001111111111111111000000000000000000000000000000000000000000000000000001100000110000011000001100000110000011000000011000000011000000011000000011000000011000000000000000000001100000000000000000000001100000011000001100000110000011000000110000111100001101111110000000000000000011111100000001101111001111011011110010111011101111000011011111100000000000000000000000000000000000000000110000111100001111000011110000111111111111000011110000111100001101100110001111000001100000000000000000000111111111100011110000111100001111100011011111111110001111000011110000111110001101111111000000000000000001111110111001110000001100000011000000110000001100000011000000110000001111100111011111100000000000000000001111110111001111100011110000111100001111000011110000111100001111100011011100110011111100000000000000001111111100000011000000110000001100000011001111110000001100000011000000110000001111111111000000000000000000000011000000110000001100000011000000110000001100111111000000110000001100000011111111110000000000000000011111101110011111000011110000111111001100000011000000110000001100000011111001110111111000000000000000001100001111000011110000111100001111000011111111111100001111000011110000111100001111000011000000000000000001111110000110000001100000011000000110000001100000011000000110000001100000011000011111100000000000000000001111100111011101100011011000000110000001100000011000000110000001100000011000000110000000000000000000001100001101100011001100110001101100001111000001110000111100011011001100110110001111000011000000000000000011111111000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000110000111100001111000011110000111100001111000011110110111111111111111111111001111100001100000000000000001110001111100011111100111111001111111011110110111101111111001111110011111100011111000111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111100111011111100000000000000000000000110000001100000011000000110000001101111111111000111100001111000011111000110111111100000000000000001111110001110110111110111101101111000011110000111100001111000011110000110110011000111100000000000000000011000011011000110011001100011011000011110111111111100011110000111100001111100011011111110000000000000000011111101110011111000000110000001110000001111110000001110000001100000011111001110111111000000000000000000001100000011000000110000001100000011000000110000001100000011000000110000001100011111111000000000000000001111110111001111100001111000011110000111100001111000011110000111100001111000011110000110000000000000000000110000011110000111100011001100110011011000011110000111100001111000011110000111100001100000000000000001100001111100111111111111111111111011011110110111100001111000011110000111100001111000011000000000000000011000011011001100110011000111100001111000001100000111100001111000110011001100110110000110000000000000000000110000001100000011000000110000001100000011000001111000011110001100110011001101100001100000000000000001111111100000011000000110000011000001100011111100011000001100000110000001100000011111111000000000000000000111100000011000000110000001100000011000000110000001100000011000000110000001100001111000000000011000000110000000110000001100000001100000011000000011000000110000000110000001100000001100000011000000000000000000011110000110000001100000011000000110000001100000011000000110000001100000011000000111100000000000000000000000000000000000000000000000000000000000000000000000000110000110110011000111100000110001111111111111111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000111000000110000001110000000000000000011111110110000111100001111111110110000001100001101111110000000000000000000000000000000000000000000000000011111111100001111000011110000111100001101111111000000110000001100000011000000110000001100000000000000000111111011000011000000110000001100000011110000110111111000000000000000000000000000000000000000000000000011111110110000111100001111000011110000111111111011000000110000001100000011000000110000000000000000000000111111100000001100000011011111111100001111000011011111100000000000000000000000000000000000000000000000000000110000001100000011000000110000001100001111110000110000001100000011001100110001111000011111101100001111000000110000001111111011000011110000111100001101111110000000000000000000000000000000000000000000000000110000111100001111000011110000111100001111000011011111110000001100000011000000110000001100000000000000000001100000011000000110000001100000011000000110000001100000000000000000000001100000000000000111000011011000110000001100000011000000110000001100000011000000110000000000000000000000110000000000000000000000000000011000110011001100011111000011110001101100110011011000110000001100000011000000110000001100000000000000000111111000011000000110000001100000011000000110000001100000011000000110000001100000011110000000000000000011011011110110111101101111011011110110111101101101111111000000000000000000000000000000000000000000000000011000110110001101100011011000110110001101100011001111110000000000000000000000000000000000000000000000000011111001100011011000110110001101100011011000110011111000000000000000000000000000000000000000110000001100000011011111111100001111000011110000111100001101111111000000000000000000000000000000001100000011000000110000001111111011000011110000111100001111000011111111100000000000000000000000000000000000000000000000000000001100000011000000110000001100000011000001110111111100000000000000000000000000000000000000000000000001111111110000001100000001111110000000110000001111111110000000000000000000000000000000000000000000000000001110000110110000001100000011000000110000001100001111110000110000001100000011000000000000000000000000000111111001100011011000110110001101100011011000110110001100000000000000000000000000000000000000000000000000011000001111000011110001100110011001101100001111000011000000000000000000000000000000000000000000000000110000111110011111111111110110111100001111000011110000110000000000000000000000000000000000000000000000001100001101100110001111000001100000111100011001101100001100000000000000000000000000000000000000110000011000000110000011000001100000111100011001100110011011000011000000000000000000000000000000000000000000000000111111110000011000001100000110000011000001100000111111110000000000000000000000000000000000000000000000001111000000011000000110000001100000011100000011110001110000011000000110000001100011110000000110000001100000011000000110000001100000011000000110000001100000011000000110000001100000011000000110000000000000000000000011110001100000011000000110000011100011110000001110000001100000011000000110000000111100000000000000000000000000000000000000000000000000000000000000000000000000000000001110110110111000000000"

def DrawAsciiCharacter(image, topx, topy, a, color):

  index = ord(a)
  index = index - 32.0
  allCharData = GetPixelFontData()

  basis = index*8.0*13.0

  y = 0.0
  while y < 13.0:
    ybasis = basis + y*8.0
    x = 0.0
    while x < 8.0:
      pixel = ord(allCharData[int(ybasis + x)])
      if pixel == ord('1'):
        DrawPixel(image, topx + 8.0 - 1.0 - x, topy + 13.0 - 1.0 - y, color)
      x = x + 1.0
    
    y = y + 1.0
  

def GetTextWidth(text):

  charWidth = 8.0
  spacing = 2.0

  if len(text) == 0.0:
    width = 0.0
  else:
    width = len(text)*charWidth + (len(text) - 1.0)*spacing

  return width

def GetTextHeight(text):
  return 13.0

def DPIToDotsPerMm(dpi):
  return dpi/25.4

def DotsPerMmDPI(dotsPerMm):
  return dotsPerMm*25.4

def MmToInch(mm):
  return mm/25.4

def InchToMm(inch):
  return inch*25.4

def MmToDots(mm, dpi):
  return MmToInch(mm)*dpi

def DotsToMm(dots, dpi):
  return InchToMm(dots/dpi)

def PtsToInch(pts):
  return pts*1.0/72.0

def InchToPts(inch):
  return inch*72.0

def PtsToMm(pts):
  return InchToMm(PtsToInch(pts))

def MmToPts(mm):
  return InchToPts(MmToInch(mm))

def ComputeReedSolomonCodes(data, eccs):

  rsDiv = ReedSolomonComputeDivisor(eccs)
  ecc = ReedSolomonComputeRemainder(data, rsDiv)

  return ecc

def ReedSolomonComputeDivisor(eccs):

  result = arraysCreateNumberArray(eccs, 0.0)
  result[int(len(result) - 1.0)] = 1.0

  root = 1.0
  i = 0.0
  while i < eccs:
    j = 0.0
    while j < len(result):
      result[int(j)] = GaloisField2e8Mul(result[int(j)], root, 285.0)
      if j + 1.0 < len(result):
        result[int(j)] = XorByte(result[int(j)], result[int(j + 1.0)])
      j = j + 1.0
    
    root = GaloisField2e8Mul(root, 2.0, 285.0)
    i = i + 1.0
  

  return result

def ReedSolomonComputeRemainder(data, divisor):

  result = arraysCreateNumberArray(len(divisor), 0.0)

  i = 0.0
  while i < len(data):
    b = data[int(i)]

    factor = XorByte(b, result[int(0.0)])

    j = 0.0
    while j < len(result) - 1.0:
      result[int(j)] = result[int(j + 1.0)]
      j = j + 1.0
    
    result[int(j)] = 0.0

    j = 0.0
    while j < len(divisor):
      coef = divisor[int(j)]
      result[int(j)] = XorByte(result[int(j)], GaloisField2e8Mul(coef, factor, 285.0))
      j = j + 1.0
    
    i = i + 1.0
  

  return result

def ComputeBHC15_5Code(data):

  # x^10 + x^8 + x^5 + x^4 + x^2 + x + 1 is encoded as 10100110111b = 1335
  gp = 1335.0

  i = 0.0
  while i < 10.0:
    data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 9.0)*gp)
    i = i + 1.0
  

  return data

def ComputeBHC18_6Code(data):

  # x^12 + x^11 + x^10 + x^9 + x^8 + x^5 + x^2 + 1 is encoded as 1111100100101b = 7973
  gp = 7973.0

  i = 0.0
  while i < 12.0:
    data = Xor4Byte(ShiftLeft4Byte(data, 1.0), ShiftRight4Byte(data, 11.0)*gp)
    i = i + 1.0
  

  return data

def And4Byte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsigned4Bytes(a)
  b = ToUnsigned4Bytes(b)

  i = 0.0
  while i < 32.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab == 1.0 and bb == 1.0:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def ToUnsigned4Bytes(a):
  if a < 0.0:
    a = 4294967296.0 - Truncate(( -a) % 4294967296.0)
  else:
    a = Truncate(a % 4294967296.0)
  return a

def ToUnsigned2Bytes(a):
  if a < 0.0:
    a = 65536.0 - Truncate(( -a) % 65536.0)
  else:
    a = Truncate(a % 65536.0)
  return a

def ToUnsignedByte(a):
  if a < 0.0:
    a = 256.0 - Truncate(( -a) % 256.0)
  else:
    a = Truncate(a % 256.0)
  return a

def And2Byte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsigned2Bytes(a)
  b = ToUnsigned2Bytes(b)

  i = 0.0
  while i < 16.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab == 1.0 and bb == 1.0:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def AndByte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsignedByte(a)
  b = ToUnsignedByte(b)

  i = 0.0
  while i < 8.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab == 1.0 and bb == 1.0:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def Or4Byte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsigned4Bytes(a)
  b = ToUnsigned4Bytes(b)

  i = 0.0
  while i < 32.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab == 1.0 or bb == 1.0:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def Or2Byte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsigned2Bytes(a)
  b = ToUnsigned2Bytes(b)

  i = 0.0
  while i < 16.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab == 1.0 or bb == 1.0:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def OrByte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsignedByte(a)
  b = ToUnsignedByte(b)

  i = 0.0
  while i < 8.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab == 1.0 or bb == 1.0:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def Xor4Byte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsigned4Bytes(a)
  b = ToUnsigned4Bytes(b)

  i = 0.0
  while i < 32.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab != bb:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def Xor2Byte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsigned2Bytes(a)
  b = ToUnsigned2Bytes(b)

  i = 0.0
  while i < 16.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab != bb:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def XorByte(a, b):

  byteVal = 1.0
  result = 0.0

  a = ToUnsignedByte(a)
  b = ToUnsignedByte(b)

  i = 0.0
  while i < 8.0:
    ab = a % 2.0
    bb = b % 2.0

    if ab != bb:
      result = result + byteVal

    a = floor(a/2.0)
    b = floor(b/2.0)
    byteVal = byteVal*2.0
    i = i + 1.0
  

  return result

def Not4Byte(a):

  a = ToUnsigned4Bytes(a)

  result = 4294967296.0 - a - 1.0

  return result

def Not2Byte(a):

  a = ToUnsigned2Bytes(a)

  result = 65536.0 - a - 1.0

  return result

def NotByte(a):

  a = ToUnsignedByte(a)

  result = 256.0 - a - 1.0

  return result

def ShiftLeft4Byte(a, n):

  a = Truncate(a % 4294967296.0)
  n = Truncate(max(n,0.0))

  result = a*2.0**n

  return result

def ShiftLeft2Byte(a, n):

  a = Truncate(a % 65536.0)
  n = Truncate(max(n,0.0))

  result = a*2.0**n

  return result

def ShiftLeftByte(a, n):

  a = Truncate(a % 256.0)
  n = Truncate(max(n,0.0))

  result = a*2.0**n

  return result

def ShiftRight4Byte(a, n):

  a = Truncate(a % 4294967296.0)
  n = Truncate(max(n,0.0))

  result = Truncate(a/2.0**n)

  return result

def ShiftRight2Byte(a, n):

  a = Truncate(a % 65536.0)
  n = Truncate(max(n,0.0))

  result = Truncate(a/2.0**n)

  return result

def ShiftRightByte(a, n):

  a = Truncate(a % 256.0)
  n = Truncate(max(n,0.0))

  result = Truncate(a/2.0**n)

  return result

def RotateLeft4Byte(a, n):

  a = ToUnsigned4Bytes(a)
  n = Truncate(n)

  #return (a << n) | (a >> (32 - n));
  # Mask the upper bits first, then rotate.
  x = And4Byte(a, Not4Byte(ShiftLeft4Byte(1.0, n) - 1.0))
  x = Or4Byte(ShiftLeft4Byte(x, n), ShiftRight4Byte(a, (32.0 - n)))

  return x

def RotateRight4Byte(a, n):

  a = ToUnsigned4Bytes(a)
  n = Truncate(n)

  # return (a >> d) | (a << (32 - n));
  # Mask away the upper bits first, then perform the shift.
  x = And4Byte(a, ShiftLeft4Byte(1.0, n) - 1.0)
  x = Or4Byte(ShiftRight4Byte(a, n), ShiftLeft4Byte(x, 32.0 - n))

  return x

def CreateBooleanArrayFromNumber(w, size):

  out = arraysCreateBooleanArray(size, False)

  j = 0.0
  p = 1.0
  while p < w:
    p = p*2.0
    j = j + 1.0
  

  while j >= 0.0:
    if w >= p:
      w = w - p
      if j < size:
        out[int(size - 1.0 - j)] = True
    p = p/2.0
    j = j - 1.0
  

  return out

def BooleanArrayToNumber(bits):

  w = 0.0
  p = 1.0
  i = 31.0
  while i >= 0.0:
    if bits[int(i)]:
      w = w + p
    p = p*2.0
    i = i - 1.0
  

  return w

def BooleanAnd(a, b):

  length = len(a)

  out =  [None]*int(length)

  i = 0.0
  while i < length:
    out[int(i)] = a[int(i)] and b[int(i)]
    i = i + 1.0
  
  return out

def BooleanXor(a, b):

  length = len(a)

  out =  [None]*int(length)

  i = 0.0
  while i < length:
    if a[int(i)] or b[int(i)]:
      if  not (a[int(i)] and b[int(i)]) :
        out[int(i)] = True
    i = i + 1.0
  
  return out

def BooleanNot(a):

  length = len(a)

  out =  [None]*int(length)

  i = 0.0
  while i < length:
    out[int(i)] =  not a[int(i)] 
    i = i + 1.0
  
  return out

def ShiftBitsRight4Byte(w, n):
  f = False

  if n == 0.0:
    ob = w
  else:
    wb = w
    ob =  [None]*int(32.0)

    i = 0.0
    while i < 32.0:
      it = i - n

      if it < 0.0:
        f = False
      else:
        f = wb[int(it)]

      ob[int(i)] = f
      i = i + 1.0
    

  return ob

def ReadNextBit(data, nextbit):

  bytenr = floor(nextbit.numberValue/8.0)
  bitnumber = nextbit.numberValue % 8.0

  b = data[int(bytenr)]

  bit = floor(b/2.0**bitnumber) % 2.0

  nextbit.numberValue = nextbit.numberValue + 1.0

  return bit

def BitExtract(b, fromInc, toInc):
  return floor(b/2.0**fromInc) % 2.0**(toInc + 1.0 - fromInc)

def ReadBitRange(data, nextbit, length):

  number = 0.0

  startbyte = floor(nextbit.numberValue/8.0)
  endbyte = floor((nextbit.numberValue + length)/8.0)

  startbit = nextbit.numberValue % 8.0
  endbit = (nextbit.numberValue + length - 1.0) % 8.0

  if startbyte == endbyte:
    number = BitExtract(data[int(startbyte)], startbit, endbit)

  nextbit.numberValue = nextbit.numberValue + length

  return number

def SkipToBoundary(nextbit):

  skip = 8.0 - nextbit.numberValue % 8.0
  nextbit.numberValue = nextbit.numberValue + skip

def ReadNextByteBoundary(data, nextbit):

  bytenr = floor(nextbit.numberValue/8.0)
  b = data[int(bytenr)]
  nextbit.numberValue = nextbit.numberValue + 8.0

  return b

def Read2bytesByteBoundary(data, nextbit):

  r = 0.0
  r = r + 2.0**8.0*ReadNextByteBoundary(data, nextbit)
  r = r + ReadNextByteBoundary(data, nextbit)

  return r

def QuickSortStrings(list):
  QuickSortStringsBounds(list, 0.0, len(list.stringArray) - 1.0)

def QuickSortStringsBounds(A, lo, hi):

  if lo < hi:
    p = QuickSortStringsPartition(A, lo, hi)
    QuickSortStringsBounds(A, lo, p - 1.0)
    QuickSortStringsBounds(A, p + 1.0, hi)

def QuickSortStringsPartition(A, lo, hi):

  pivot = A.stringArray[int(hi)].string
  i = lo - 1.0
  j = lo
  while j <= hi - 1.0:
    if strStringIsBefore(A.stringArray[int(j)].string, pivot):
      i = i + 1.0
      arraysSwapElementsOfStringArray(A, i, j)
    j = j + 1.0
  
  arraysSwapElementsOfStringArray(A, i + 1.0, hi)

  return i + 1.0

def QuickSortStringsWithIndexes(A):

  indexes =  [None]*int(len(A.stringArray))

  i = 0.0
  while i < len(A.stringArray):
    indexes[int(i)] = i
    i = i + 1.0
  

  QuickSortStringsBoundsWithIndexes(A, indexes, 0.0, len(A.stringArray) - 1.0)

  return indexes

def QuickSortStringsBoundsWithIndexes(A, indexes, lo, hi):

  if lo < hi:
    p = QuickSortStringsPartitionWithIndexes(A, indexes, lo, hi)
    QuickSortStringsBoundsWithIndexes(A, indexes, lo, p - 1.0)
    QuickSortStringsBoundsWithIndexes(A, indexes, p + 1.0, hi)

def QuickSortStringsPartitionWithIndexes(A, indexes, lo, hi):

  pivot = A.stringArray[int(hi)].string
  i = lo - 1.0
  j = lo
  while j <= hi - 1.0:
    if strStringIsBefore(A.stringArray[int(j)].string, pivot):
      i = i + 1.0
      arraysSwapElementsOfStringArray(A, i, j)
      arraysSwapElementsOfNumberArray(indexes, i, j)
    j = j + 1.0
  
  arraysSwapElementsOfStringArray(A, i + 1.0, hi)
  arraysSwapElementsOfNumberArray(indexes, i + 1.0, hi)

  return i + 1.0

def QuickSortNumbers(list):
  QuickSortNumbersBounds(list, 0.0, len(list) - 1.0)

def QuickSortNumbersBounds(A, lo, hi):

  if lo < hi:
    p = QuickSortNumbersPartition(A, lo, hi)
    QuickSortNumbersBounds(A, lo, p - 1.0)
    QuickSortNumbersBounds(A, p + 1.0, hi)

def QuickSortNumbersPartition(A, lo, hi):

  pivot = A[int(hi)]
  lowPos = lo
  j = lo
  while j <= hi - 1.0:
    if A[int(j)] < pivot:
      arraysSwapElementsOfNumberArray(A, lowPos, j)
      lowPos = lowPos + 1.0
    j = j + 1.0
  
  arraysSwapElementsOfNumberArray(A, lowPos, hi)

  return lowPos

def QuickSortNumbersWithIndexes(A):

  indexes =  [None]*int(len(A))

  i = 0.0
  while i < len(A):
    indexes[int(i)] = i
    i = i + 1.0
  

  QuickSortNumbersBoundsWithIndexes(A, indexes, 0.0, len(A) - 1.0)

  return indexes

def QuickSortNumbersBoundsWithIndexes(A, indexes, lo, hi):

  if lo < hi:
    p = QuickSortNumbersPartitionWithIndexes(A, indexes, lo, hi)
    QuickSortNumbersBoundsWithIndexes(A, indexes, lo, p - 1.0)
    QuickSortNumbersBoundsWithIndexes(A, indexes, p + 1.0, hi)

def QuickSortNumbersPartitionWithIndexes(A, indexes, lo, hi):

  pivot = A[int(hi)]
  i = lo - 1.0
  j = lo
  while j <= hi - 1.0:
    if A[int(j)] < pivot:
      i = i + 1.0
      arraysSwapElementsOfNumberArray(A, i, j)
      arraysSwapElementsOfNumberArray(indexes, i, j)
    j = j + 1.0
  
  arraysSwapElementsOfNumberArray(A, i + 1.0, hi)
  arraysSwapElementsOfNumberArray(indexes, i + 1.0, hi)

  return i + 1.0

def Add(a, b):

  r = NumberOfRows(a)
  c = NumberOfColumns(a)
  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      a.r[int(m)].c[int(n)] = Element(a, m, n) + Element(b, m, n)
      n = n + 1.0
    
    m = m + 1.0
  

def Assign(A, B):

  r = NumberOfRows(A)
  c = NumberOfColumns(A)
  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      A.r[int(m)].c[int(n)] = Element(B, m, n)
      n = n + 1.0
    
    m = m + 1.0
  

def Resize(A, r, c):

  C = CreateMatrix(r, c)

  ar = NumberOfRows(A)
  ac = NumberOfColumns(A)

  m = 0.0
  while m < min(r,ar):
    n = 0.0
    while n < min(c,ac):
      C.r[int(m)].c[int(n)] = Element(A, m, n)
      n = n + 1.0
    
    m = m + 1.0
  

  FreeMatrixRows(A.r)
  A.r = C.r

def Subtract(a, b):

  r = NumberOfRows(a)
  c = NumberOfColumns(a)
  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      a.r[int(m)].c[int(n)] = Element(a, m, n) - Element(b, m, n)
      n = n + 1.0
    
    m = m + 1.0
  

def SubtractToNew(a, b):

  X = CreateCopyOfMatrix(a)
  Subtract(X, b)

  return X

def ScalarMultiply(A, b):

  r = NumberOfRows(A)
  c = NumberOfColumns(A)
  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      A.r[int(m)].c[int(n)] = b*A.r[int(m)].c[int(n)]
      n = n + 1.0
    
    m = m + 1.0
  

def ScalarDivide(A, b):

  r = NumberOfRows(A)
  c = NumberOfColumns(A)
  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      A.r[int(m)].c[int(n)] = Element(A, m, n)/b
      n = n + 1.0
    
    m = m + 1.0
  

def ElementWisePower(A, p):

  r = NumberOfRows(A)
  c = NumberOfColumns(A)

  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      A.r[int(m)].c[int(n)] = A.r[int(m)].c[int(n)]**p
      n = n + 1.0
    
    m = m + 1.0
  

def ScalarMultiplyToNew(A, b):

  matrix = CreateCopyOfMatrix(A)
  ScalarMultiply(matrix, b)

  return matrix

def MultiplyToNew(a, b):

  rows = NumberOfRows(a)
  cols = NumberOfColumns(b)
  x = CreateMatrix(rows, cols)
  Multiply(x, a, b)

  return x

def Multiply(x, a, b):

  rows = NumberOfRows(a)
  cols = NumberOfColumns(b)
  d = NumberOfColumns(a)

  m = 0.0
  while m < rows:
    n = 0.0
    while n < cols:
      s = 0.0

      i = 0.0
      while i < d:
        s = s + a.r[int(m)].c[int(i)]*b.r[int(i)].c[int(n)]
        i = i + 1.0
      

      x.r[int(m)].c[int(n)] = s
      n = n + 1.0
    
    m = m + 1.0
  

def CreateSquareMatrix(d):

  matrix = Matrix()
  matrix.r =  [None]*int(d)
  m = 0.0
  while m < d:
    matrix.r[int(m)] = MatrixRow()
    matrix.r[int(m)].c =  [None]*int(d)
    n = 0.0
    while n < d:
      matrix.r[int(m)].c[int(n)] = 0.0
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def CreateMatrix(rows, cols):

  matrix = Matrix()
  matrix.r =  [None]*int(rows)
  m = 0.0
  while m < rows:
    matrix.r[int(m)] = MatrixRow()
    matrix.r[int(m)].c =  [None]*int(cols)
    n = 0.0
    while n < cols:
      matrix.r[int(m)].c[int(n)] = 0.0
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def CreateIdentityMatrix(d):

  matrix = CreateSquareMatrix(d)
  Fill(matrix, 0.0)

  m = 0.0
  while m < d:
    matrix.r[int(m)].c[int(m)] = 1.0
    m = m + 1.0
  

  return matrix

def Transpose(a):

  ap = TransposeToNew(a)

  FreeMatrixRows(a.r)
  a.r = ap.r

def TransposeAssign(t, a):

  cols = NumberOfRows(a)
  rows = NumberOfColumns(a)

  m = 0.0
  while m < cols:
    n = 0.0
    while n < rows:
      t.r[int(n)].c[int(m)] = a.r[int(m)].c[int(n)]
      n = n + 1.0
    
    m = m + 1.0
  

def TransposeToNew(a):

  cols = NumberOfRows(a)
  rows = NumberOfColumns(a)

  c = CreateMatrix(rows, cols)

  m = 0.0
  while m < cols:
    n = 0.0
    while n < rows:
      c.r[int(n)].c[int(m)] = a.r[int(m)].c[int(n)]
      n = n + 1.0
    
    m = m + 1.0
  

  return c

def CofactorOfMatrix(mat, temp, p, q, n):

  i = 0.0
  j = 0.0

  row = 0.0
  while row < n:
    col = 0.0
    while col < n:
      if row != p and col != q:
        temp.r[int(i)].c[int(j)] = mat.r[int(row)].c[int(col)]
        j = j + 1.0

        if j == n - 1.0:
          j = 0.0
          i = i + 1.0
      col = col + 1.0
    
    row = row + 1.0
  

def DeterminantOfSubmatrix(mat, n):

  D = 0.0

  if n == 1.0:
    D = mat.r[int(0.0)].c[int(0.0)]
  else:
    temp = CreateSquareMatrix(n)

    sign = 1.0

    f = 0.0
    while f < n:
      CofactorOfMatrix(mat, temp, 0.0, f, n)
      D = D + sign*mat.r[int(0.0)].c[int(f)]*DeterminantOfSubmatrix(temp, n - 1.0)
      sign =  -sign
      f = f + 1.0
    

    FreeMatrix(temp)

  return D

def Determinant(m):

  n = NumberOfRows(m)
  D = DeterminantOfSubmatrix(m, n)

  return D

def Adjoint(A, adj):

  n = len(A.r)

  if n == 1.0:
    adj.r[int(0.0)].c[int(0.0)] = 1.0
  else:
    cofactors = CreateSquareMatrix(n)

    i = 0.0
    while i < n:
      j = 0.0
      while j < n:
        CofactorOfMatrix(A, cofactors, i, j, n)

        if (i + j) % 2.0 == 0.0:
          sign = 1.0
        else:
          sign =  -1.0

        adj.r[int(j)].c[int(i)] = sign*DeterminantOfSubmatrix(cofactors, n - 1.0)
        j = j + 1.0
      
      i = i + 1.0
    

    FreeMatrix(cofactors)

def Inverse(A, inverseResult):
  return InverseUsingLUDecomposition(A, inverseResult)

def InverseUsingAdjoint(A, inverseResult):

  if NumberOfColumns(A) == NumberOfRows(A):
    n = NumberOfColumns(A)

    det = Determinant(A)
    if det != 0.0:
      adj = CreateSquareMatrix(n)
      Adjoint(A, adj)

      i = 0.0
      while i < n:
        j = 0.0
        while j < n:
          inverseResult.r[int(i)].c[int(j)] = adj.r[int(i)].c[int(j)]/det
          j = j + 1.0
        
        i = i + 1.0
      

      success = True
      FreeMatrix(adj)
    else:
      success = False
  else:
    success = False

  return success

def InverseUsingLUDecomposition(A, inverseResult):

  l = CreateCopyOfMatrix(A)
  u = CreateCopyOfMatrix(A)
  li = CreateCopyOfMatrix(A)
  ui = CreateCopyOfMatrix(A)
  inverseResult.r = CreateCopyOfMatrix(A).r

  success = LUDecomposition(A, l, u)
  if success:
    success = InvertLowerTriangularMatrix(l, li)
    if success:
      success = InvertUpperTriangularMatrix(u, ui)
      if success:
        Multiply(inverseResult, ui, li)

  FreeMatrix(l)
  FreeMatrix(u)
  FreeMatrix(li)
  FreeMatrix(ui)

  return success

def LUDecomposition(A, L, U):

  n = NumberOfRows(A)

  L.r = CreateSquareMatrix(n).r
  U.r = CreateSquareMatrix(n).r

  if IsSquare(A):
    success = True

    i = 0.0
    while i < n and success:
      k = i
      while k < n:
        sum = 0.0
        j = 0.0
        while j < i:
          sum = sum + (Element(L, i, j)*Element(U, j, k))
          j = j + 1.0
        

        U.r[int(i)].c[int(k)] = Element(A, i, k) - sum
        k = k + 1.0
      

      k = i
      while k < n and success:
        if i == k:
          L.r[int(i)].c[int(i)] = 1.0
        else:
          sum = 0.0
          j = 0.0
          while j < i:
            sum = sum + (Element(L, k, j)*Element(U, j, i))
            j = j + 1.0
          

          if Element(U, i, i) == 0.0:
            success = False
          else:
            L.r[int(k)].c[int(i)] = (Element(A, k, i) - sum)/Element(U, i, i)
        k = k + 1.0
      
      i = i + 1.0
    
  else:
    success = False

  return success

def IsSymmetric(A):

  N = NumberOfRows(A)

  done = False
  isx = True
  i = 0.0
  while i < N and  not done :
    j = 0.0
    while j < i and  not done :
      if A.r[int(i)].c[int(j)] != A.r[int(j)].c[int(i)]:
        isx = False
        done = True
      j = j + 1.0
    
    i = i + 1.0
  

  return isx

def IsSquare(A):

  if NumberOfRows(A) == NumberOfColumns(A):
    isx = True
  else:
    isx = False

  return isx

def Cholesky(A, L):

  Clear(L)

  if IsSquare(A) and IsSymmetric(A):
    success = True

    N = NumberOfRows(A)

    i = 0.0
    while i < N and success:
      j = 0.0
      while j <= i and success:
        s = 0.0
        k = 0.0
        while k < j:
          s = s + L.r[int(i)].c[int(k)]*L.r[int(j)].c[int(k)]
          k = k + 1.0
        
        if i == j:
          L.r[int(i)].c[int(i)] = sqrt(A.r[int(i)].c[int(i)] - s)
        else:
          L.r[int(i)].c[int(j)] = 1.0/L.r[int(j)].c[int(j)]*(A.r[int(i)].c[int(j)] - s)
        j = j + 1.0
      
      if L.r[int(i)].c[int(i)] <= 0.0:
        success = False
      i = i + 1.0
    

    success = True
  else:
    success = False

  return success

def Clear(a):
  Fill(a, 0.0)

def Fill(a, value):

  m = 0.0
  while m < NumberOfRows(a):
    n = 0.0
    while n < NumberOfColumns(a):
      a.r[int(m)].c[int(n)] = value
      n = n + 1.0
    
    m = m + 1.0
  

def Element(matrix, m, n):
  return matrix.r[int(m)].c[int(n)]

def Trace(a):

  tr = 0.0

  d = len(a.r)
  m = 0.0
  while m < d:
    tr = tr + a.r[int(m)].c[int(m)]
    m = m + 1.0
  

  return tr

def ColumnCombineMatricesToNew(A, B):

  X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A) + NumberOfColumns(B))

  m = 0.0
  while m < NumberOfRows(A):
    n = 0.0
    while n < NumberOfColumns(A):
      X.r[int(m)].c[int(n)] = A.r[int(m)].c[int(n)]
      n = n + 1.0
    
    m = m + 1.0
  

  m = 0.0
  while m < NumberOfRows(B):
    n = 0.0
    while n < NumberOfColumns(B):
      X.r[int(m)].c[int(NumberOfColumns(A) + n)] = B.r[int(m)].c[int(n)]
      n = n + 1.0
    
    m = m + 1.0
  

  return X

def NumberOfRows(A):
  return len(A.r)

def NumberOfColumns(A):
  return len(A.r[int(0.0)].c)

def CharacteristicPolynomial(A):

  dummy = CreateSquareMatrix(NumberOfRows(A))

  coeffs = NumberArrayReference()
  determinant = NumberReference()
  CharacteristicPolynomialWithInverse(A, dummy, coeffs, determinant)

  FreeMatrix(dummy)

  return coeffs.numberArray

def CharacteristicPolynomialWithInverse(A, AInverse, cp, determinant):
  FaddeevLeVerrierAlgorithm(A, AInverse, cp, determinant)

def FaddeevLeVerrierAlgorithm(A, AInverse, cp, determinant):

  n = NumberOfRows(A)
  p =  [None]*int(n + 1.0)
  p[int(n)] = 1.0
  Mkm1 = CreateSquareMatrix(n)
  Fill(Mkm1, 0.0)
  I = CreateIdentityMatrix(n)
  Mk = CreateSquareMatrix(n)
  t1 = CreateSquareMatrix(n)

  k = 1.0
  while k <= n:
    # M_k = A * M_(k-1) + c_(n-k+1) * I
    Multiply(Mk, A, Mkm1)
    Assign(t1, I)
    ScalarMultiply(t1, p[int(n - k + 1.0)])
    Add(Mk, t1)

    # c_(n-k) = -1/k * trace(A * M_k)
    Multiply(t1, A, Mk)
    p[int(n - k)] =  -1.0/k*Trace(t1)

    # done
    Assign(Mkm1, Mk)

    if k == n:
      Assign(AInverse, Mk)
      determinant.numberValue =  -p[int(0.0)]
      if p[int(0.0)] == 0.0:
        pass
      else:
        ScalarDivide(AInverse, determinant.numberValue)
    k = k + 1.0
  

  FreeMatrix(Mkm1)
  FreeMatrix(I)
  FreeMatrix(Mk)
  FreeMatrix(t1)

  cp.numberArray = p

def InverseUsingCharacteristicPolynomial(A):

  inverse = CreateSquareMatrix(NumberOfRows(A))
  coeffs = NumberArrayReference()
  determinant = NumberReference()
  CharacteristicPolynomialWithInverse(A, inverse, coeffs, determinant)
  coeffs.numberArray = None
  coeffs = None

  return inverse

def Eigenvalues(A, eigenValuesReference):

  eigenVectorsReference = MatrixArrayReference()
  success = Eigenpairs(A, eigenValuesReference, eigenVectorsReference)
  if success:
    i = 0.0
    while i < len(eigenVectorsReference.matrices):
      FreeMatrix(eigenVectorsReference.matrices[int(i)])
      i = i + 1.0
    
    eigenVectorsReference.matrices = None
    eigenVectorsReference = None

  return success

def EigenvaluesUsingQRAlgorithm(A, eigenValuesReference, precision, maxIterations):

  n = NumberOfRows(A)
  x = CreateSquareMatrix(n)
  q = CreateSquareMatrix(n)
  r = CreateSquareMatrix(n)
  eigenValuesReference.numberArray =  [None]*int(n)
  success = QRAlgorithm(A, r, x, q, precision, maxIterations)
  found = 0.0
  if success:
    ExtractDiagonal(x, eigenValuesReference.numberArray)

    # find the correct sign of the eigenvalue.
    cp = CharacteristicPolynomial(A)
    i = 0.0
    while i < n:
      ev = eigenValuesReference.numberArray[int(i)]

      v1 = pEvaluate(cp, ev)
      v2 = pEvaluate(cp,  -ev)

      if fabs(v2) < fabs(v1):
        eigenValuesReference.numberArray[int(i)] =  -ev
        v = v2
      else:
        v = v1

      if fabs(v) < precision*10.0**4.0:
        found = found + 1.0
      i = i + 1.0
    

    FreeMatrix(x)
    FreeMatrix(q)
    FreeMatrix(r)

  if found != n:
    success = False

  return success

def EigenvaluesUsingLaguerreIterations(A, eigenValuesReference):

  p = CharacteristicPolynomial(A)
  success = FindRoots(p, eigenValuesReference)

  return success

def GaussianElimination(A):

  m = NumberOfRows(A)
  n = NumberOfColumns(A)

  h = 0.0
  k = 0.0
  while h < m and k < n:
    maxElement = h
    max = 0.0
    i = h
    while i < m:
      maxCandidate = fabs(Element(A, i, k))
      if max < maxCandidate:
        maxElement = i
        max = maxCandidate
      i = i + 1.0
    
    if A.r[int(maxElement)].c[int(k)] == 0.0:
      k = k + 1.0
    else:
      SwapRows(A, h, maxElement)
      i = h + 1.0
      while i < m:
        f = Element(A, i, k)/Element(A, h, k)
        A.r[int(i)].c[int(k)] = 0.0
        j = k + 1.0
        while j < n:
          A.r[int(i)].c[int(j)] = Element(A, i, j) - Element(A, h, j)*f
          j = j + 1.0
        
        i = i + 1.0
      
      h = h + 1.0
      k = k + 1.0
  

def GaussianEliminationToNew(A):

  X = CreateCopyOfMatrix(A)
  GaussianElimination(X)

  return X

def CreateCopyOfMatrix(A):

  X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A))
  Assign(X, A)

  return X

def SwapRows(A, to, fromx):

  c = NumberOfRows(A)
  n = 0.0
  while n < c:
    t = A.r[int(to)].c[int(n)]
    A.r[int(to)].c[int(n)] = A.r[int(fromx)].c[int(n)]
    A.r[int(fromx)].c[int(n)] = t
    n = n + 1.0
  

def UnnormalizeVector(numberArray):

  mSet = False
  m = 0.0

  i = 0.0
  while i < len(numberArray):
    if numberArray[int(i)] - Truncate(numberArray[int(i)]) < 0.001:
      if  not mSet :
        m = fabs(numberArray[int(i)])
        mSet = True
      else:
        m = min(m,fabs(numberArray[int(i)]))
    i = i + 1.0
  

  if mSet:
    i = 0.0
    while i < len(numberArray):
      numberArray[int(i)] = numberArray[int(i)]/m
      i = i + 1.0
    

def InversePowerMethod(A, eigenvalue, maxIterations, eigenvector):

  n = NumberOfRows(A)

  x = CreateIdentityMatrix(n)
  ScalarMultiply(x, eigenvalue)
  y = SubtractToNew(A, x)
  z = CreateSquareMatrix(n)
  singular =  not Inverse(y, z) 
  if singular:
    # Try again with more erroneous eigenvalue estimate.
    x = CreateIdentityMatrix(n)
    ScalarMultiply(x, eigenvalue*1.01)
    y = SubtractToNew(A, x)
    z = CreateSquareMatrix(n)
    singular =  not Inverse(y, z) 

  if  not singular :
    b = CreateMatrix(n, 1.0)

    i = 0.0
    while i < n:
      b.r[int(i)].c[int(0.0)] = 1.0
      i = i + 1.0
    

    i = 0.0
    while i < maxIterations:
      t = MultiplyToNew(z, b)
      c = Norm(t)
      ScalarDivide(t, c)
      Assign(b, t)
      i = i + 1.0
    

    eigenvector.numberArray =  [None]*int(n)
    i = 0.0
    while i < n:
      eigenvector.numberArray[int(i)] = b.r[int(i)].c[int(0.0)]
      i = i + 1.0
    

  return  not singular 

def Eigenvectors(A, eigenVectorsReference):

  evsReference = NumberArrayReference()
  success = Eigenpairs(A, evsReference, eigenVectorsReference)
  if success:
    evsReference.numberArray = None
    evsReference = None

  return success

def Eigenpairs(A, eigenValuesReference, eigenVectorsReference):
  return EigenpairsUsingQRAlgorithmAndInversePowerMethod(A, eigenValuesReference, eigenVectorsReference, 0.00000000001, 100.0)

def EigenpairsUsingQRAlgorithmAndInversePowerMethod(M, eigenValuesReference, eigenVectorsReference, precision, maxIterations):

  N = NumberOfRows(M)

  A = CreateCopyOfMatrix(M)
  Q = CreateCopyOfMatrix(M)
  R = CreateCopyOfMatrix(M)

  done = False
  eigenVectorsReference.matrices =  [None]*int(N)
  evecReference = NumberArrayReference()
  eigenValuesReference.numberArray =  [None]*int(N)
  cp = CharacteristicPolynomial(M)

  j = 0.0
  while j < N:
    eigenVectorsReference.matrices[int(j)] = CreateMatrix(N, 1.0)
    j = j + 1.0
  

  i = 0.0
  while i < maxIterations and  not done :
    QRDecomposition(A, Q, R)
    Multiply(A, R, Q)

    # Check
    withinPrecision = 0.0
    ExtractDiagonal(R, eigenValuesReference.numberArray)

    j = 0.0
    while j < N:
      # Find the correct sign of the eigenvalue.
      eigenValue = eigenValuesReference.numberArray[int(j)]
      v1 = pEvaluate(cp, eigenValue)
      v2 = pEvaluate(cp,  -eigenValue)
      if fabs(v2) < fabs(v1):
        eigenValuesReference.numberArray[int(j)] =  -eigenValue
        eigenValue =  -eigenValue

      # Calculate the eigenvector corresponding to the eigenvalue.
      inverseSuccess = InversePowerMethod(M, eigenValue, i + 1.0, evecReference)
      if inverseSuccess:
        k = 0.0
        while k < N:
          eigenVectorsReference.matrices[int(j)].r[int(k)].c[int(0.0)] = evecReference.numberArray[int(k)]
          k = k + 1.0
        

        # Check eigenpair agains precision.
        eigenVector = eigenVectorsReference.matrices[int(j)]

        if CheckEigenpairPrecision(M, eigenValue, eigenVector, precision):
          withinPrecision = withinPrecision + 1.0
      j = j + 1.0
    

    if withinPrecision == N:
      done = True
    i = i + 1.0
  

  FreeMatrix(A)
  FreeMatrix(Q)
  FreeMatrix(R)
  evecReference = None
  cp = None

  return done

def CheckEigenpairPrecision(a, lambdax, e, precision):

  vec1 = MultiplyToNew(a, e)
  vec2 = ScalarMultiplyToNew(e, lambdax)

  equal = MatrixEqualsEpsilon(vec1, vec2, precision)

  return equal

def EigenvectorsLaguerreIterationsAndGaussianEliminations(A, eigenVectorsReference):

  N = NumberOfRows(A)

  eigenValuesReference = NumberArrayReference()
  success = Eigenvalues(A, eigenValuesReference)

  eigenVectorsResult =  [None]*int(N)

  if success:
    ev = eigenValuesReference.numberArray

    Id = CreateIdentityMatrix(N)
    t1 = CreateSquareMatrix(N)
    B = CreateSquareMatrix(N)

    j = 0.0
    while j < len(ev) and success:
      lambdax = ev[int(j)]

      # B = A - lambda * Id
      Assign(t1, Id)
      ScalarMultiply(t1, lambdax)

      Assign(B, A)
      Subtract(B, t1)

      GaussianElimination(B)

      v = CreateMatrix(N, 1.0)
      v.r[int(N - 1.0)].c[int(0.0)] = 1.0
      i = N - 2.0
      while i >= 0.0 and success:
        if  not RowIsZero(B, i) :
          x = 0.0

          k = N - 1.0
          while k > i:
            x = x - Element(B, i, k)*Element(v, k, 0.0)
            k = k - 1.0
          

          v.r[int(i)].c[int(0.0)] = x/Element(B, i, i)
        else:
          success = False
        i = i - 1.0
      

      eigenVectorsResult[int(j)] = v
      j = j + 1.0
    

    FreeMatrix(t1)
    FreeMatrix(B)
    FreeMatrix(Id)

    eigenVectorsReference.matrices = eigenVectorsResult

  return success

def RowIsZero(X, r):

  isZero = True

  columns = NumberOfColumns(X)
  i = 0.0
  while i < columns and isZero:
    if Element(X, r, i) != 0.0:
      isZero = False
    i = i + 1.0
  

  return isZero

def FreeMatrix(X):
  FreeMatrixRows(X.r)
  X = None

def FreeMatrixRows(r):

  rows = len(r)
  m = 0.0
  while m < rows:
    r[int(m)].c = None
    r[int(m)] = None
    m = m + 1.0
  

  r = None

def CreateDiagonalMatrixFromArray(array):

  matrix = CreateSquareMatrix(len(array))
  Fill(matrix, 0.0)

  m = 0.0
  while m < len(array):
    matrix.r[int(m)].c[int(m)] = array[int(m)]
    m = m + 1.0
  

  return matrix

def CreateMatrixFromRowCopies(row, times):

  matrix = CreateMatrix(times, len(row))

  m = 0.0
  while m < times:
    n = 0.0
    while n < len(row):
      matrix.r[int(m)].c[int(n)] = row[int(n)]
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def ExtractDiagonal(X, diag):

  n = NumberOfRows(X)

  i = 0.0
  while i < n:
    diag[int(i)] = X.r[int(i)].c[int(i)]
    i = i + 1.0
  

def ExtractDiagonalToNew(X):

  n = NumberOfRows(X)
  diag =  [None]*int(n)

  i = 0.0
  while i < n:
    diag[int(i)] = X.r[int(i)].c[int(i)]
    i = i + 1.0
  

  return diag

def MatrixEqualsEpsilon(a, b, epsilon):

  equals = True

  if NumberOfRows(a) == NumberOfRows(b) and NumberOfColumns(a) == NumberOfColumns(b):
    columns = NumberOfColumns(a)
    rows = NumberOfRows(a)

    x = 0.0
    while x < rows:
      y = 0.0
      while y < columns:
        equals = equals and EpsilonCompare(Element(a, x, y), Element(b, x, y), epsilon)
        y = y + 1.0
      
      x = x + 1.0
    
  else:
    equals = False

  return equals

def Minor(x, row, column):

  rows = NumberOfRows(x) - 1.0
  cols = NumberOfColumns(x) - 1.0

  theMinor = CreateMatrix(rows, cols)

  i = 0.0
  while i < rows:
    if i < row:
      m = i
    else:
      m = i + 1.0

    j = 0.0
    while i != row and j < cols:
      if j != column:

        if j < column:
          n = j
        else:
          n = j + 1.0

        theMinor.r[int(m)].c[int(n)] = x.r[int(i)].c[int(j)]
      j = j + 1.0
    
    i = i + 1.0
  

  return theMinor

def QRDecomposition(m, Q, R):
  HouseholderMethod(m, Q, R)

def HouseholderTriangularizationAlgorithm(m, Qout, Rout):

  rows = NumberOfRows(m)
  cols = NumberOfColumns(m)

  P = CreateIdentityMatrix(rows)
  A = CreateCopyOfMatrix(m)
  AA = CreateMatrix(rows, cols)

  t = CreateMatrix(rows, cols)
  PP = CreateIdentityMatrix(rows)
  vt = CreateMatrix(1.0, rows)

  j = 0.0
  while j < cols:
    v = ExtractSubMatrix(A, 0.0, rows - 1.0, j, j)
    if j > 0.0:
      i = 0.0
      while i < j:
        v.r[int(i)].c[int(0.0)] = 0.0
        i = i + 1.0
      

    s = Sign(v.r[int(j)].c[int(0.0)])
    if s == 0.0:
      s = 1.0
    v.r[int(j)].c[int(0.0)] = v.r[int(j)].c[int(0.0)] + Norm(v)*s
    r =  -2.0/(Norm(v)*Norm(v))
    Assign(AA, A)

    TransposeAssign(vt, v)
    Multiply(t, vt, A)
    Assign(A, t)
    Multiply(t, v, A)
    Assign(A, t)
    ScalarMultiply(A, r)
    Assign(t, AA)
    Add(A, AA)

    Assign(PP, P)

    Multiply(t, vt, P)
    Assign(P, t)
    Multiply(t, v, P)
    Assign(P, t)
    ScalarMultiply(P, r)
    Assign(t, AA)
    Add(P, PP)
    j = j + 1.0
  

  Assign(Rout, A)
  Assign(Qout, P)
  Transpose(Qout)

def HouseholderMethod(A, q, r):

  # Initialize.
  QR = CreateCopyOfMatrix(A)
  m = NumberOfRows(A)
  n = NumberOfColumns(A)
  Rdiag =  [None]*int(n)

  # Main loop.
  k = 0.0
  while k < n:
    # Compute 2-norm of k-th column without under/overflow.
    nrm = 0.0
    i = k
    while i < m:
      nrm = Hypothenuse(nrm, Element(QR, i, k))
      i = i + 1.0
    

    if nrm != 0.0:
      # Form k-th Householder vector.
      if Element(QR, k, k) < 0.0:
        nrm =  -nrm
      i = k
      while i < m:
        QR.r[int(i)].c[int(k)] = Element(QR, i, k)/nrm
        i = i + 1.0
      
      QR.r[int(k)].c[int(k)] = Element(QR, k, k) + 1.0

      # Apply transformation to remaining columns.
      j = k + 1.0
      while j < n:
        s = 0.0
        i = k
        while i < m:
          s = s + Element(QR, i, k)*Element(QR, i, j)
          i = i + 1.0
        
        s =  -s/Element(QR, k, k)
        i = k
        while i < m:
          QR.r[int(i)].c[int(j)] = Element(QR, i, j) + s*Element(QR, i, k)
          i = i + 1.0
        
        j = j + 1.0
      
    Rdiag[int(k)] =  -nrm
    k = k + 1.0
  

  # Compute R
  R = CreateSquareMatrix(n)
  i = 0.0
  while i < n:
    j = 0.0
    while j < n:
      if i < j:
        R.r[int(i)].c[int(j)] = Element(QR, i, j)
      elif i == j:
        R.r[int(i)].c[int(j)] = Rdiag[int(i)]
      else:
        R.r[int(i)].c[int(j)] = 0.0
      j = j + 1.0
    
    i = i + 1.0
  
  Assign(r, R)

  # Compute Q
  Q = CreateMatrix(m, n)
  k = n - 1.0
  while k >= 0.0:
    i = 0.0
    while i < m:
      Q.r[int(i)].c[int(k)] = 0.0
      i = i + 1.0
    
    Q.r[int(k)].c[int(k)] = 1.0
    j = k
    while j < n:
      if Element(QR, k, k) != 0.0:
        s = 0.0
        i = k
        while i < m:
          s = s + Element(QR, i, k)*Element(Q, i, j)
          i = i + 1.0
        
        s =  -s/Element(QR, k, k)
        i = k
        while i < m:
          Q.r[int(i)].c[int(j)] = Element(Q, i, j) + s*Element(QR, i, k)
          i = i + 1.0
        
      j = j + 1.0
    
    k = k - 1.0
  
  Assign(q, Q)

  # Adjust for positive R.
  n = NumberOfRows(r)

  N = CreateIdentityMatrix(n)

  i = 0.0
  while i < n:
    e = Element(r, i, i)

    if e < 0.0:
      N.r[int(i)].c[int(i)] =  -1.0
    i = i + 1.0
  

  ra = MultiplyToNew(N, r)
  Assign(r, ra)
  rq = MultiplyToNew(q, N)
  Assign(q, rq)

  FreeMatrix(ra)
  FreeMatrix(rq)
  FreeMatrix(Q)
  FreeMatrix(R)
  FreeMatrix(QR)

def Hypothenuse(a, b):
  return sqrt(a**2.0 + b**2.0)

def Norm(a):

  l = 0.0

  rows = NumberOfRows(a)
  cols = NumberOfColumns(a)

  i = 0.0
  while i < rows:
    j = 0.0
    while j < cols:
      l = l + a.r[int(i)].c[int(j)]*a.r[int(i)].c[int(j)]
      j = j + 1.0
    
    i = i + 1.0
  
  l = sqrt(l)

  return l

def ExtractSubMatrix(M, r1, r2, c1, c2):

  A = CreateMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0)

  i = r1
  while i <= r2:
    j = c1
    while j <= c2:
      A.r[int(i - r1)].c[int(j - c1)] = M.r[int(i)].c[int(j)]
      j = j + 1.0
    
    i = i + 1.0
  

  return A

def QRAlgorithm(M, R, A, Q, precision, maxIterations):

  Assign(A, M)
  n = NumberOfRows(M)
  previous =  [None]*int(n)
  previousSet = False

  done = False
  i = 0.0
  while i < maxIterations and  not done :
    QRDecomposition(A, Q, R)
    Multiply(A, R, Q)

    # Check precision.
    if previousSet:
      withinPrecision = 0.0
      j = 0.0
      while j < n:
        v = previous[int(j)] - Element(A, j, j)
        if fabs(v) < precision or v == 0.0:
          withinPrecision = withinPrecision + 1.0
        j = j + 1.0
      
      if withinPrecision == n:
        done = True

    j = 0.0
    while j < n:
      previous[int(j)] = Element(A, j, j)
      j = j + 1.0
    
    previousSet = True
    i = i + 1.0
  

  return done

def InvertUpperTriangularMatrix(A, inverse):

  inverse.r = CreateCopyOfMatrix(A).r
  n = NumberOfRows(inverse)
  success = True

  i = n - 1.0
  while i >= 0.0 and success:
    if Element(inverse, i, i) == 0.0:
      success = False
    else:
      inverse.r[int(i)].c[int(i)] = 1.0/Element(inverse, i, i)
      j = i - 1.0
      while j >= 0.0 and success:
        sum = 0.0
        k = i
        while k > j:
          sum = sum - Element(inverse, j, k)*Element(inverse, k, i)
          k = k - 1.0
        
        if Element(inverse, j, j) == 0.0:
          success = False
        else:
          inverse.r[int(j)].c[int(i)] = sum/Element(inverse, j, j)
        j = j - 1.0
      
    i = i - 1.0
  

  return success

def InvertLowerTriangularMatrix(A, inverse):

  inverse.r = CreateCopyOfMatrix(A).r
  n = NumberOfRows(inverse)
  success = True

  i = 0.0
  while i < n and success:
    if Element(inverse, i, i) == 0.0:
      success = False
    else:
      inverse.r[int(i)].c[int(i)] = 1.0/Element(inverse, i, i)
      j = i + 1.0
      while j < n:
        sum = 0.0
        k = i
        while k < j and success:
          sum = sum - Element(inverse, j, k)*Element(inverse, k, i)
          k = k + 1.0
        
        if Element(inverse, j, j) == 0.0:
          success = False
        else:
          inverse.r[int(j)].c[int(i)] = sum/Element(inverse, j, j)
        j = j + 1.0
      
    i = i + 1.0
  

  return success

def ParseMatrixFromString(aref, matrixString, errorMessage):

  replaced = strReplaceString(matrixString, "\r", "")
  trimmed = strTrim(replaced)
  lines = strSplitByCharacter(trimmed, '\n')

  replaced = None
  trimmed = None

  success = True

  rows = len(lines)
  if rows == 0.0:
    aref.matrix = CreateMatrix(0.0, 0.0)
  else:
    row = StringToNumberArray(lines[int(0.0)].string)
    cols = len(row)
    row = None

    aref.matrix = CreateMatrix(rows, cols)

    i = 0.0
    while i < rows and success:
      aref.matrix.r[int(i)].c = None
      aref.matrix.r[int(i)].c = StringToNumberArray(lines[int(i)].string)

      if len(aref.matrix.r[int(i)].c) != cols:
        success = False
        errorMessage.string = "All rows must have the same number of columns."
      i = i + 1.0
    

  FreeStringReferenceArray(lines)

  return success

def MatrixToString(matrix, digitsAfterPoint):

  s1 =  [None]*int(0.0)

  n = 0.0
  while n < NumberOfRows(matrix):
    m = 0.0
    while m < NumberOfColumns(matrix):
      element = Element(matrix, n, m)
      element = RoundToDigits(element, digitsAfterPoint)
      s2 = strAppendString(s1, CreateStringDecimalFromNumber(element))
      s1 = None
      s1 = s2
      if m + 1.0 != NumberOfColumns(matrix):
        s2 = strAppendString(s1, ", ")
        s1 = None
        s1 = s2
      m = m + 1.0
    
    s2 = strAppendString(s1, "\n")
    s1 = None
    s1 = s2
    n = n + 1.0
  

  return s1

def MatrixArrayToString(matrices, digitsAfterPoint):

  s1 =  [None]*int(0.0)

  i = 0.0
  while i < len(matrices):
    s2 = strAppendString(s1, MatrixToString(matrices[int(i)], digitsAfterPoint))
    s1 = None
    s1 = s2

    s2 = strAppendString(s1, "\n")
    s1 = None
    s1 = s2
    i = i + 1.0
  

  return s1

def RoundMatrixElementsToDigits(a, digits):

  m = 0.0
  while m < NumberOfRows(a):
    n = 0.0
    while n < NumberOfColumns(a):
      a.r[int(m)].c[int(n)] = RoundToDigits(Element(a, m, n), digits)
      if a.r[int(m)].c[int(n)] ==  -0.0:
        a.r[int(m)].c[int(n)] = 0.0
      n = n + 1.0
    
    m = m + 1.0
  

def SingularValueDecomposition(Ap, URef, SigmaRef, VRef):

  # Square matrix, adjust results correspondingly.
  orgm = NumberOfRows(Ap)
  orgn = NumberOfColumns(Ap)
  size = max(orgm,orgn)
  A = CreateCopyOfMatrix(Ap)
  Resize(A, size, size)

  # Initialize.
  m = size
  n = size

  # Compute
  nu = min(m,n)
  s =  [None]*int(min(m + 1.0,n))
  U = CreateMatrix(m, nu)
  V = CreateSquareMatrix(n)
  e =  [None]*int(n)
  work =  [None]*int(m)

  # Reduce A to bidiagonal form, storing the diagonal elements in s and the super-diagonal elements in e.
  nct = min(m - 1.0,n)
  nrt = max(0.0,min(n - 2.0,m))
  k = 0.0
  while k < max(nct,nrt):
    if k < nct:

      # Compute the transformation for the k-th column and place the k-th diagonal in s[k].
      # Compute 2-norm of k-th column without under/overflow.
      s[int(k)] = 0.0
      i = k
      while i < m:
        s[int(k)] = Hypothenuse(s[int(k)], Element(A, i, k))
        i = i + 1.0
      
      if s[int(k)] != 0.0:
        if Element(A, k, k) < 0.0:
          s[int(k)] =  -s[int(k)]
        i = k
        while i < m:
          A.r[int(i)].c[int(k)] = Element(A, i, k)/s[int(k)]
          i = i + 1.0
        
        A.r[int(k)].c[int(k)] = Element(A, k, k) + 1.0
      s[int(k)] =  -s[int(k)]
    j = k + 1.0
    while j < n:
      if (k < nct) and (s[int(k)] != 0.0):

        # Apply the transformation.
        t = 0.0
        i = k
        while i < m:
          t = t + Element(A, i, k)*Element(A, i, j)
          i = i + 1.0
        
        t =  -t/Element(A, k, k)
        i = k
        while i < m:
          A.r[int(i)].c[int(j)] = Element(A, i, j) + t*Element(A, i, k)
          i = i + 1.0
        

      # Place the k-th row of A into e for the subsequent calculation of the row transformation.
      e[int(j)] = Element(A, k, j)
      j = j + 1.0
    
    if k < nct:

      # Place the transformation in U for subsequent back
      # multiplication.
      i = k
      while i < m:
        U.r[int(i)].c[int(k)] = Element(A, i, k)
        i = i + 1.0
      
    if k < nrt:
      # Compute the k-th row transformation and place the k-th super-diagonal in e[k].
      # Compute 2-norm without under/overflow.
      e[int(k)] = 0.0
      i = k + 1.0
      while i < n:
        e[int(k)] = Hypothenuse(e[int(k)], e[int(i)])
        i = i + 1.0
      
      if e[int(k)] != 0.0:
        if e[int(k + 1.0)] < 0.0:
          e[int(k)] =  -e[int(k)]
        i = k + 1.0
        while i < n:
          e[int(i)] = e[int(i)]/e[int(k)]
          i = i + 1.0
        
        e[int(k + 1.0)] = e[int(k + 1.0)] + 1.0
      e[int(k)] =  -e[int(k)]
      if (k + 1.0 < m) and (e[int(k)] != 0.0):

        # Apply the transformation.
        i = k + 1.0
        while i < m:
          work[int(i)] = 0.0
          i = i + 1.0
        
        j = k + 1.0
        while j < n:
          i = k + 1.0
          while i < m:
            work[int(i)] = work[int(i)] + e[int(j)]*Element(A, i, j)
            i = i + 1.0
          
          j = j + 1.0
        
        j = k + 1.0
        while j < n:
          t =  -e[int(j)]/e[int(k + 1.0)]
          i = k + 1.0
          while i < m:
            A.r[int(i)].c[int(j)] = Element(A, i, j) + t*work[int(i)]
            i = i + 1.0
          
          j = j + 1.0
        

      # Place the transformation in V for subsequent back multiplication.
      i = k + 1.0
      while i < n:
        V.r[int(i)].c[int(k)] = e[int(i)]
        i = i + 1.0
      
    k = k + 1.0
  

  # Set up the final bidiagonal matrix or order p.
  p = min(n,m + 1.0)
  if nct < n:
    s[int(nct)] = Element(A, nct, nct)
  if m < p:
    s[int(p - 1.0)] = 0.0
  if nrt + 1.0 < p:
    e[int(nrt)] = Element(A, nrt, p - 1.0)
  e[int(p - 1.0)] = 0.0

  # Generate U.
  j = nct
  while j < nu:
    i = 0.0
    while i < m:
      U.r[int(i)].c[int(j)] = 0.0
      i = i + 1.0
    
    U.r[int(j)].c[int(j)] = 1.0
    j = j + 1.0
  
  k = nct - 1.0
  while k >= 0.0:
    if s[int(k)] != 0.0:
      j = k + 1.0
      while j < nu:
        t = 0.0
        i = k
        while i < m:
          t = t + Element(U, i, k)*Element(U, i, j)
          i = i + 1.0
        
        t =  -t/Element(U, k, k)
        i = k
        while i < m:
          U.r[int(i)].c[int(j)] = Element(U, i, j) + t*Element(U, i, k)
          i = i + 1.0
        
        j = j + 1.0
      
      i = k
      while i < m:
        U.r[int(i)].c[int(k)] =  -Element(U, i, k)
        i = i + 1.0
      
      U.r[int(k)].c[int(k)] = 1.0 + Element(U, k, k)
      i = 0.0
      while i < k - 1.0:
        U.r[int(i)].c[int(k)] = 0.0
        i = i + 1.0
      
    else:
      i = 0.0
      while i < m:
        U.r[int(i)].c[int(k)] = 0.0
        i = i + 1.0
      
      U.r[int(k)].c[int(k)] = 1.0
    k = k - 1.0
  

  # Generate V.
  k = n - 1.0
  while k >= 0.0:
    if (k < nrt) and (e[int(k)] != 0.0):
      j = k + 1.0
      while j < nu:
        t = 0.0
        i = k + 1.0
        while i < n:
          t = t + Element(V, i, k)*Element(V, i, j)
          i = i + 1.0
        
        t =  -t/Element(V, k + 1.0, k)
        i = k + 1.0
        while i < n:
          V.r[int(i)].c[int(j)] = Element(V, i, j) + t*Element(V, i, k)
          i = i + 1.0
        
        j = j + 1.0
      
    i = 0.0
    while i < n:
      V.r[int(i)].c[int(k)] = 0.0
      i = i + 1.0
    
    V.r[int(k)].c[int(k)] = 1.0
    k = k - 1.0
  

  # Main iteration loop for the singular values.
  pp = p - 1.0
  iter = 0.0
  eps = 2.0**( -52.0)
  tiny = 2.0**( -966.0)
  while p > 0.0:
    # Here is where a test for too many iterations would go.
    # This section of the program inspects for negligible elements in the s and e arrays.
    # On completion the variables kase and k are set as follows.
    # kase = 1, if s(p) and e[k-1] are negligible and k<p
    # kase = 2, if s(k) is negligible and k<p
    # kase = 3, if e[k-1] is negligible, k<p, and s(k), ..., s(p) are not negligible (qr step).
    # kase = 4, if e(p-1) is negligible (convergence).
    done = False
    k = p - 2.0
    while k >  -1.0 and  not done :
      if fabs(e[int(k)]) <= tiny + eps*(fabs(s[int(k)]) + fabs(s[int(k + 1.0)])):
        e[int(k)] = 0.0
        done = True
      else:
        k = k - 1.0
    
    if k == p - 2.0:
      kase = 4.0
    else:
      done = False
      ks = p - 1.0
      while ks > k and  not done :
        if ks != p:
          t = fabs(e[int(ks)])
        else:
          t = 0.0

        if ks != k + 1.0:
          t = t + fabs(e[int(ks - 1.0)])

        if fabs(s[int(ks)]) <= tiny + eps*t:
          s[int(ks)] = 0.0
          done = True
        else:
          ks = ks - 1.0
      
      if ks == k:
        kase = 3.0
      elif ks == p - 1.0:
        kase = 1.0
      else:
        kase = 2.0
        k = ks
    k = k + 1.0

    # Perform the task indicated by kase.
    if kase == 1.0:
      # Deflate negligible s(p).
      f = e[int(p - 2.0)]
      e[int(p - 2.0)] = 0.0
      j = p - 2.0
      while j >= k:
        t = Hypothenuse(s[int(j)], f)
        cs = s[int(j)]/t
        sn = f/t
        s[int(j)] = t
        if j != k:
          f =  -sn*e[int(j - 1.0)]
          e[int(j - 1.0)] = cs*e[int(j - 1.0)]

        i = 0.0
        while i < n:
          t = cs*Element(V, i, j) + sn*Element(V, i, p - 1.0)
          V.r[int(i)].c[int(p - 1.0)] =  -sn*Element(V, i, j) + cs*Element(V, i, p - 1.0)
          V.r[int(i)].c[int(j)] = t
          i = i + 1.0
        
        j = j - 1.0
      
    elif kase == 2.0:
      # Split at negligible s(k).
      f = e[int(k - 1.0)]
      e[int(k - 1.0)] = 0.0
      j = k
      while j < p:
        t = Hypothenuse(s[int(j)], f)
        cs = s[int(j)]/t
        sn = f/t
        s[int(j)] = t
        f =  -sn*e[int(j)]
        e[int(j)] = cs*e[int(j)]

        i = 0.0
        while i < m:
          t = cs*Element(U, i, j) + sn*Element(U, i, k + 1.0)
          U.r[int(i)].c[int(k - 1.0)] =  -sn*Element(U, i, j) + cs*Element(U, i, k + 1.0)
          U.r[int(i)].c[int(j)] = t
          i = i + 1.0
        
        j = j + 1.0
      
    elif kase == 3.0:
      # Perform one qr step.
      # Calculate the shift.
      scale = max(max(max(max(fabs(s[int(p - 1.0)]),fabs(s[int(p - 2.0)])),fabs(e[int(p - 2.0)])),fabs(s[int(k)])),fabs(e[int(k)]))
      sp = s[int(p - 1.0)]/scale
      spm1 = s[int(p - 2.0)]/scale
      epm1 = e[int(p - 2.0)]/scale
      sk = s[int(k)]/scale
      ek = e[int(k)]/scale
      b = ((spm1 + sp)*(spm1 - sp) + epm1*epm1)/2.0
      c = (sp*epm1)*(sp*epm1)
      shift = 0.0
      if (b != 0.0) or (c != 0.0):
        shift = sqrt(b*b + c)
        if b < 0.0:
          shift =  -shift
        shift = c/(b + shift)
      f = (sk + sp)*(sk - sp) + shift
      g = sk*ek

      # Chase zeros.
      j = k
      while j < p - 1.0:
        t = Hypothenuse(f, g)
        cs = f/t
        sn = g/t
        if j != k:
          e[int(j - 1.0)] = t
        f = cs*s[int(j)] + sn*e[int(j)]
        e[int(j)] = cs*e[int(j)] - sn*s[int(j)]
        g = sn*s[int(j + 1.0)]
        s[int(j + 1.0)] = cs*s[int(j + 1.0)]
        i = 0.0
        while i < n:
          t = cs*Element(V, i, j) + sn*Element(V, i, j + 1.0)
          V.r[int(i)].c[int(j + 1.0)] =  -sn*Element(V, i, j) + cs*Element(V, i, j + 1.0)
          V.r[int(i)].c[int(j)] = t
          i = i + 1.0
        
        t = Hypothenuse(f, g)
        cs = f/t
        sn = g/t
        s[int(j)] = t
        f = cs*e[int(j)] + sn*s[int(j + 1.0)]
        s[int(j + 1.0)] =  -sn*e[int(j)] + cs*s[int(j + 1.0)]
        g = sn*e[int(j + 1.0)]
        e[int(j + 1.0)] = cs*e[int(j + 1.0)]
        if j < m - 1.0:
          i = 0.0
          while i < m:
            t = cs*Element(U, i, j) + sn*Element(U, i, j + 1.0)
            U.r[int(i)].c[int(j + 1.0)] =  -sn*Element(U, i, j) + cs*Element(U, i, j + 1.0)
            U.r[int(i)].c[int(j)] = t
            i = i + 1.0
          
        j = j + 1.0
      
      e[int(p - 2.0)] = f
      iter = iter + 1.0
    elif kase == 4.0:
      # Make the singular values positive.
      if s[int(k)] <= 0.0:
        if s[int(k)] < 0.0:
          s[int(k)] =  -s[int(k)]
        else:
          s[int(k)] = 0.0

        i = 0.0
        while i <= pp:
          V.r[int(i)].c[int(k)] =  -Element(V, i, k)
          i = i + 1.0
        

      # Order the singular values.
      while k < pp and s[int(k)] < s[int(k + 1.0)]:
        t = s[int(k)]
        s[int(k)] = s[int(k + 1.0)]
        s[int(k + 1.0)] = t
        if k < n - 1.0:
          i = 0.0
          while i < n:
            t = Element(V, i, k + 1.0)
            V.r[int(i)].c[int(k + 1.0)] = Element(V, i, k)
            V.r[int(i)].c[int(k)] = t
            i = i + 1.0
          
        if k < m - 1.0:
          i = 0.0
          while i < m:
            t = Element(U, i, k + 1.0)
            U.r[int(i)].c[int(k + 1.0)] = Element(U, i, k)
            U.r[int(i)].c[int(k)] = t
            i = i + 1.0
          
        k = k + 1.0
      
      iter = 0.0
      p = p - 1.0
  

  Resize(U, orgm, orgm)
  Resize(V, orgn, orgn)

  URef.matrix = U
  VRef.matrix = V
  SigmaRef.matrix = CreateMatrix(orgm, orgn)
  i = 0.0
  while i < min(orgm,orgn):
    SigmaRef.matrix.r[int(i)].c[int(i)] = s[int(i)]
    i = i + 1.0
  

  return True

def CreateComplexMatrix(rows, cols):

  matrix = ComplexMatrix()
  matrix.r =  [None]*int(rows)
  m = 0.0
  while m < rows:
    matrix.r[int(m)] = ComplexMatrixRow()
    matrix.r[int(m)].c =  [None]*int(cols)
    n = 0.0
    while n < cols:
      matrix.r[int(m)].c[int(n)] = cCreateComplexNumber(0.0, 0.0)
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def CreateComplexMatrixFromMatrix(a):

  rows = NumberOfRows(a)
  cols = NumberOfColumns(a)

  matrix = ComplexMatrix()
  matrix.r =  [None]*int(rows)
  m = 0.0
  while m < rows:
    matrix.r[int(m)] = ComplexMatrixRow()
    matrix.r[int(m)].c =  [None]*int(cols)
    n = 0.0
    while n < cols:
      matrix.r[int(m)].c[int(n)] = cCreateComplexNumber(a.r[int(m)].c[int(n)], 0.0)
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def CreateReMatrixFromComplexMatrix(a):

  rows = NumberOfRowsComplex(a)
  cols = NumberOfColumnsComplex(a)

  matrix = Matrix()
  matrix.r =  [None]*int(rows)
  m = 0.0
  while m < rows:
    matrix.r[int(m)] = MatrixRow()
    matrix.r[int(m)].c =  [None]*int(cols)
    n = 0.0
    while n < cols:
      matrix.r[int(m)].c[int(n)] = IndexComplex(a, m, n).re
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def CreateImMatrixFromComplexMatrix(a):

  rows = NumberOfRowsComplex(a)
  cols = NumberOfColumnsComplex(a)

  matrix = Matrix()
  matrix.r =  [None]*int(rows)
  m = 0.0
  while m < rows:
    matrix.r[int(m)] = MatrixRow()
    matrix.r[int(m)].c =  [None]*int(cols)
    n = 0.0
    while n < cols:
      matrix.r[int(m)].c[int(n)] = IndexComplex(a, m, n).im
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def NumberOfRowsComplex(A):
  return len(A.r)

def NumberOfColumnsComplex(A):
  return len(A.r[int(0.0)].c)

def IndexComplex(a, m, n):
  return a.r[int(m)].c[int(n)]

def AddComplex(a, b):

  d = NumberOfRowsComplex(a)

  m = 0.0
  while m < d:
    n = 0.0
    while n < d:
      cAdd(IndexComplex(a, m, n), IndexComplex(b, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

def SubtractComplex(a, b):

  r = NumberOfRowsComplex(a)
  c = NumberOfColumnsComplex(a)

  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      cSub(IndexComplex(a, m, n), IndexComplex(b, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

def SubtractComplexToNew(a, b):

  X = CreateCopyOfComplexMatrix(a)
  SubtractComplex(X, b)

  return X

def MultiplyComplex(x, a, b):

  rows = NumberOfRowsComplex(a)
  cols = NumberOfColumnsComplex(b)
  d = NumberOfColumnsComplex(a)
  t = cCreateComplexNumber(0.0, 0.0)

  m = 0.0
  while m < rows:
    n = 0.0
    while n < cols:
      s = cCreateComplexNumber(0.0, 0.0)

      i = 0.0
      while i < d:
        cAssignComplex(t, s)
        cAssignComplex(s, IndexComplex(a, m, i))
        cMul(s, IndexComplex(b, i, n))
        cAdd(s, t)
        i = i + 1.0
      

      x.r[int(m)].c[int(n)] = s
      n = n + 1.0
    
    m = m + 1.0
  

def MultiplyComplexToNew(a, b):

  rows = NumberOfRowsComplex(a)
  cols = NumberOfColumnsComplex(b)
  x = CreateComplexMatrix(rows, cols)
  MultiplyComplex(x, a, b)

  return x

def Conjugate(a):

  rows = NumberOfRowsComplex(a)
  cols = NumberOfRowsComplex(a)

  m = 0.0
  while m < rows:
    n = 0.0
    while n < cols:
      cConjugate(IndexComplex(a, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

def AssignComplexMatrix(A, B):

  r = NumberOfRowsComplex(A)
  c = NumberOfColumnsComplex(A)

  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

def ScalarMultiplyComplex(A, b):

  r = NumberOfRowsComplex(A)
  c = NumberOfColumnsComplex(A)

  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      cMul(IndexComplex(A, m, n), b)
      n = n + 1.0
    
    m = m + 1.0
  

def ScalarMultiplyComplexToNew(A, b):

  matrix = CreateCopyOfComplexMatrix(A)
  ScalarMultiplyComplex(matrix, b)

  return matrix

def ScalarDivideComplex(A, b):

  r = NumberOfRowsComplex(A)
  c = NumberOfColumnsComplex(A)

  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      cDiv(IndexComplex(A, m, n), b)
      n = n + 1.0
    
    m = m + 1.0
  

def ElementWisePowerComplex(A, p):

  r = NumberOfRowsComplex(A)
  c = NumberOfColumnsComplex(A)

  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      cPower(IndexComplex(A, m, n), p)
      n = n + 1.0
    
    m = m + 1.0
  

def CreateComplexIdentityMatrix(d):

  matrix = CreateSquareComplexMatrix(d)
  FillComplex(matrix, 0.0, 0.0)

  m = 0.0
  while m < d:
    IndexComplex(matrix, m, m).re = 1.0
    m = m + 1.0
  

  return matrix

def CreateSquareComplexMatrix(d):

  matrix = ComplexMatrix()
  matrix.r =  [None]*int(d)
  m = 0.0
  while m < d:
    matrix.r[int(m)] = ComplexMatrixRow()
    matrix.r[int(m)].c =  [None]*int(d)
    n = 0.0
    while n < d:
      matrix.r[int(m)].c[int(n)] = cCreateComplexNumber(0.0, 0.0)
      n = n + 1.0
    
    m = m + 1.0
  

  return matrix

def ClearComplex(a):
  FillComplex(a, 0.0, 0.0)

def FillComplex(a, re, im):

  m = 0.0
  while m < NumberOfRowsComplex(a):
    n = 0.0
    while n < NumberOfColumnsComplex(a):
      IndexComplex(a, m, n).re = re
      IndexComplex(a, m, n).im = im
      n = n + 1.0
    
    m = m + 1.0
  

def TraceComplex(a):

  tr = cCreateComplexNumber(0.0, 0.0)

  d = len(a.r)
  m = 0.0
  while m < d:
    cAdd(tr, IndexComplex(a, m, m))
    m = m + 1.0
  

  return tr

def CofactorOfComplexMatrix(mat, temp, p, q, n):

  i = 0.0
  j = 0.0

  row = 0.0
  while row < n:
    col = 0.0
    while col < n:
      if row != p and col != q:
        cAssignComplex(IndexComplex(temp, i, j), IndexComplex(mat, row, col))
        j = j + 1.0

        if j == n - 1.0:
          j = 0.0
          i = i + 1.0
      col = col + 1.0
    
    row = row + 1.0
  

def DeterminantOfComplexSubmatrix(mat, n):

  D = cCreateComplexNumber(0.0, 0.0)
  t = cCreateComplexNumber(0.0, 0.0)

  if n == 1.0:
    D = mat.r[int(0.0)].c[int(0.0)]
  else:
    temp = CreateSquareComplexMatrix(n)

    sign = 1.0

    f = 0.0
    while f < n:
      CofactorOfComplexMatrix(mat, temp, 0.0, f, n)
      cAssignComplexByValues(t, sign, 0.0)
      cMul(t, IndexComplex(mat, 0.0, f))
      cMul(t, DeterminantOfComplexSubmatrix(temp, n - 1.0))
      cAdd(D, t)
      sign =  -sign
      f = f + 1.0
    

    DeleteComplexMatrix(temp)

  return D

def DeleteComplexMatrix(X):

  rows = NumberOfRowsComplex(X)
  cols = NumberOfColumnsComplex(X)
  m = 0.0
  while m < rows:
    n = 0.0
    while n < cols:
      X.r[int(m)].c[int(n)] = None
      n = n + 1.0
    
    X.r[int(m)].c = None
    X.r[int(m)] = None
    m = m + 1.0
  

  X.r = None
  X = None

def DeterminantComplex(m):

  n = NumberOfRowsComplex(m)
  D = DeterminantOfComplexSubmatrix(m, n)

  return D

def AdjointComplex(A, adj):

  n = len(A.r)
  t = cCreateComplexNumber(0.0, 0.0)
  sign = cCreateComplexNumber(0.0, 0.0)

  if n == 1.0:
    cAssignComplexByValues(IndexComplex(adj, 0.0, 0.0), 1.0, 0.0)
  else:
    cofactors = CreateSquareComplexMatrix(n)

    i = 0.0
    while i < n:
      j = 0.0
      while j < n:
        CofactorOfComplexMatrix(A, cofactors, i, j, n)

        if (i + j) % 2.0 == 0.0:
          cAssignComplexByValues(sign, 1.0, 0.0)
        else:
          cAssignComplexByValues(sign,  -1.0, 0.0)

        cAssignComplex(t, sign)
        cMul(t, DeterminantOfComplexSubmatrix(cofactors, n - 1.0))
        cAssignComplex(IndexComplex(adj, j, i), t)
        j = j + 1.0
      
      i = i + 1.0
    

    DeleteComplexMatrix(cofactors)

def InverseComplex(A, inverseResult):

  t = cCreateComplexNumber(0.0, 0.0)

  if NumberOfColumnsComplex(A) == NumberOfRowsComplex(A):
    n = NumberOfColumnsComplex(A)

    det = DeterminantComplex(A)
    if det.re != 0.0 or det.im != 0.0:
      adj = CreateSquareComplexMatrix(n)
      AdjointComplex(A, adj)

      i = 0.0
      while i < n:
        j = 0.0
        while j < n:
          cAssignComplex(t, IndexComplex(adj, i, j))
          cDiv(t, det)
          cAssignComplex(IndexComplex(inverseResult, i, j), t)
          j = j + 1.0
        
        i = i + 1.0
      

      success = True
      DeleteComplexMatrix(adj)
    else:
      success = False
  else:
    success = False

  return success

def ComplexMatrixEqualsEpsilon(b, f, epsilon):

  equals = True

  if NumberOfRowsComplex(b) == NumberOfRowsComplex(f) and NumberOfColumnsComplex(b) == NumberOfColumnsComplex(f):
    columns = NumberOfColumnsComplex(b)
    rows = NumberOfRowsComplex(b)

    x = 0.0
    while x < rows:
      y = 0.0
      while y < columns:
        equals = equals and cEpsilonCompareComplex(IndexComplex(b, x, y), IndexComplex(f, x, y), epsilon)
        y = y + 1.0
      
      x = x + 1.0
    
  else:
    equals = False

  return equals

def MinorComplex(x, row, column):

  rows = NumberOfRowsComplex(x) - 1.0
  cols = NumberOfColumnsComplex(x) - 1.0

  minor = CreateComplexMatrix(rows, cols)

  i = 0.0
  while i < rows:
    if i < row:
      m = i
    else:
      m = i + 1.0

    j = 0.0
    while i != row and j < cols:
      if j != column:

        if j < column:
          n = j
        else:
          n = j + 1.0

        cAssignComplex(IndexComplex(minor, m, n), IndexComplex(x, i, j))
      j = j + 1.0
    
    i = i + 1.0
  

  return minor

def AssignComplex(A, B):

  r = NumberOfRowsComplex(A)
  c = NumberOfColumnsComplex(A)
  m = 0.0
  while m < r:
    n = 0.0
    while n < c:
      cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

def CreateCopyOfComplexMatrix(A):

  X = CreateComplexMatrix(NumberOfRowsComplex(A), NumberOfColumnsComplex(A))
  AssignComplex(X, A)

  return X

def TransposeComplex(a):

  tmp = cCreateComplexNumber(0.0, 0.0)

  square = IsSquareComplexMatrix(a)
  if square:
    rows = NumberOfColumnsComplex(a)

    m = 0.0
    while m < rows:
      n = 0.0
      while n < m:
        cAssignComplex(tmp, IndexComplex(a, n, m))
        cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n))
        cAssignComplex(IndexComplex(a, m, n), tmp)
        n = n + 1.0
      
      m = m + 1.0
    

  return square

def ConjugateTransposeComplex(a):

  tmp = cCreateComplexNumber(0.0, 0.0)

  square = IsSquareComplexMatrix(a)
  if square:
    rows = NumberOfColumnsComplex(a)

    m = 0.0
    while m < rows:
      n = 0.0
      while n < m:
        cAssignComplex(tmp, IndexComplex(a, n, m))
        cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n))
        cAssignComplex(IndexComplex(a, m, n), tmp)
        cConjugate(IndexComplex(a, m, n))
        n = n + 1.0
      
      m = m + 1.0
    

  return square

def IsSquareComplexMatrix(A):

  if NumberOfRowsComplex(A) == NumberOfColumnsComplex(A):
    isx = True
  else:
    isx = False

  return isx

def TransposeComplexAssign(t, a):

  cols = NumberOfRowsComplex(a)
  rows = NumberOfColumnsComplex(a)

  m = 0.0
  while m < cols:
    n = 0.0
    while n < rows:
      cAssignComplex(IndexComplex(t, n, m), IndexComplex(a, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

def TransposeComplexToNew(a):

  cols = NumberOfRowsComplex(a)
  rows = NumberOfColumnsComplex(a)

  c = CreateComplexMatrix(rows, cols)

  m = 0.0
  while m < cols:
    n = 0.0
    while n < rows:
      cAssignComplex(IndexComplex(c, n, m), IndexComplex(a, m, n))
      n = n + 1.0
    
    m = m + 1.0
  

  return c

def ExtractComplexSubMatrix(M, r1, r2, c1, c2):

  A = CreateComplexMatrix(r2 - r1 + 1.0, c2 - c1 + 1.0)

  i = r1
  while i <= r2:
    j = c1
    while j <= c2:
      cAssignComplex(IndexComplex(A, i - r1, j - c1), IndexComplex(M, i, j))
      j = j + 1.0
    
    i = i + 1.0
  

  return A

def NormComplex(a):

  l = 0.0

  rows = NumberOfRowsComplex(a)
  cols = NumberOfColumnsComplex(a)

  i = 0.0
  while i < rows:
    j = 0.0
    while j < cols:
      cComplexNumber = IndexComplex(a, i, j)
      l = l + cComplexNumber.re**2.0 + cComplexNumber.im**2.0
      j = j + 1.0
    
    i = i + 1.0
  
  l = sqrt(l)

  return l

def ComplexCharacteristicPolynomial(A, p):

  cp = CreateSquareComplexMatrix(NumberOfRowsComplex(A))
  determinant = cComplexNumber()

  ComplexCharacteristicPolynomialWithInverse(A, cp, p, determinant)

  DeleteComplexMatrix(cp)

def ComplexCharacteristicPolynomialWithInverse(A, AInverse, p, determinant):
  FaddeevLeVerrierAlgorithmComplex(A, AInverse, p, determinant)

def FaddeevLeVerrierAlgorithmComplex(A, AInverse, p, determinant):

  n1 = cCreateComplexNumber( -1.0, 0.0)
  n = NumberOfRowsComplex(A)
  p.cs =  [None]*int(n + 1.0)
  i = 0.0
  while i < n + 1.0:
    p.cs[int(i)] = cComplexNumber()
    i = i + 1.0
  
  cAssignComplexByValues(p.cs[int(n)], 1.0, 0.0)
  Mkm1 = CreateSquareComplexMatrix(n)
  FillComplex(Mkm1, 0.0, 0.0)
  Id = CreateComplexIdentityMatrix(n)
  Mk = CreateSquareComplexMatrix(n)
  t1 = CreateSquareComplexMatrix(n)

  k = 1.0
  while k <= n:
    MultiplyComplex(Mk, A, Mkm1)
    AssignComplex(t1, Id)
    ScalarMultiplyComplex(t1, p.cs[int(n - k + 1.0)])
    AddComplex(Mk, t1)

    MultiplyComplex(t1, A, Mk)
    t = TraceComplex(t1)
    t2 = cCreateComplexNumber( -1.0/k, 0.0)
    cMul(t, t2)
    cAssignComplex(p.cs[int(n - k)], t)

    # done
    AssignComplex(Mkm1, Mk)

    if k == n:
      AssignComplex(AInverse, Mk)
      cAssignComplex(t, p.cs[int(0.0)])
      cMul(t, n1)
      cAssignComplex(determinant, t)
      if t.re == 0.0 and t.im == 0.0:
        pass
      else:
        ScalarDivideComplex(AInverse, t)
    k = k + 1.0
  

  DeleteComplexMatrix(Mkm1)
  DeleteComplexMatrix(Id)
  DeleteComplexMatrix(Mk)
  DeleteComplexMatrix(t1)

def EigenvaluesComplex(A, eigenValuesReference):

  eigenVectorsReference = ComplexMatrixArrayReference()
  success = EigenpairsComplex(A, eigenValuesReference, eigenVectorsReference)
  if success:
    i = 0.0
    while i < len(eigenVectorsReference.matrices):
      DeleteComplexMatrix(eigenVectorsReference.matrices[int(i)])
      i = i + 1.0
    
    eigenVectorsReference.matrices = None
    eigenVectorsReference = None

  return success

def EigenvectorsComplex(A, eigenVectorsReference):

  evsReference = cComplexNumberArrayReference()
  success = EigenpairsComplex(A, evsReference, eigenVectorsReference)
  if success:
    i = 0.0
    while i < len(evsReference.complexNumbers):
      evsReference.complexNumbers[int(i)] = None
      i = i + 1.0
    
    evsReference.complexNumbers = None
    evsReference = None

  return success

def InversePowerMethodComplex(A, eigenvalue, maxIterations, eigenvector):

  n = NumberOfRowsComplex(A)

  t2 = CreateComplexIdentityMatrix(n)
  ScalarMultiplyComplex(t2, eigenvalue)
  t3 = SubtractComplexToNew(A, t2)
  t4 = CreateSquareComplexMatrix(n)
  isSingular =  not InverseComplex(t3, t4) 
  cc = cCreateComplexNumber(0.0, 0.0)
  t1 = CreateComplexMatrix(n, 1.0)

  if isSingular:
    DeleteComplexMatrix(t2)
    DeleteComplexMatrix(t3)
    DeleteComplexMatrix(t4)

    c101 = cCreateComplexNumber(1.01, 0.0)
    # Try again with more erroneous eigenvalue estimate.
    t2 = CreateComplexIdentityMatrix(n)
    k = cMulToNew(eigenvalue, c101)
    ScalarMultiplyComplex(t2, k)
    t3 = SubtractComplexToNew(A, t2)
    t4 = CreateSquareComplexMatrix(n)
    isSingular =  not InverseComplex(t3, t4) 
    c101 = None

  if  not isSingular :
    b = CreateComplexMatrix(n, 1.0)

    i = 0.0
    while i < n:
      cAssignComplexByValues(b.r[int(i)].c[int(0.0)], 1.0, 1.0)
      i = i + 1.0
    

    i = 0.0
    while i < maxIterations:
      MultiplyComplex(t1, t4, b)
      c = NormComplex(t1)
      cAssignComplexByValues(cc, c, 0.0)
      ScalarDivideComplex(t1, cc)
      AssignComplex(b, t1)
      i = i + 1.0
    

    eigenvector.complexNumbers =  [None]*int(n)
    i = 0.0
    while i < n:
      eigenvector.complexNumbers[int(i)] = b.r[int(i)].c[int(0.0)]
      i = i + 1.0
    

  DeleteComplexMatrix(t1)
  DeleteComplexMatrix(t2)
  DeleteComplexMatrix(t3)
  DeleteComplexMatrix(t4)
  cc = None

  return  not isSingular 

def EigenpairsComplex(M, eigenValuesReference, eigenVectorsReference):
  return ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(M, eigenValuesReference, eigenVectorsReference, 0.000001, 100.0)

def ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(M, eigenValuesReference, eigenVectorsReference, precision, maxIterations):

  evecReference = cComplexNumberArrayReference()

  p = pComplexPolynomial()
  ComplexCharacteristicPolynomial(M, p)

  n = len(p.cs) - 1.0
  rs =  [None]*int(n)
  i = 0.0
  while i < n:
    rs[int(i)] = cCreateComplexNumber(0.0, 0.0)
    i = i + 1.0
  
  rsPrev =  [None]*int(n)
  i = 0.0
  while i < n:
    rsPrev[int(i)] = cCreateComplexNumber(0.4, 0.9)
    cPower(rsPrev[int(i)], i)
    i = i + 1.0
  
  t2 = cCreateComplexNumber(0.0, 0.0)
  t3 = cCreateComplexNumber(0.0, 0.0)

  success = False

  eigenVectorsReference.matrices =  [None]*int(n)
  i = 0.0
  while i < n:
    eigenVectorsReference.matrices[int(i)] = CreateComplexMatrix(n, 1.0)
    i = i + 1.0
  

  i = 0.0
  while i < maxIterations and  not success :
    j = 0.0
    while j < n:
      xn1 = rsPrev[int(j)]

      t1 = pEvaluateComplex(p, xn1)
      cAssignComplexByValues(t2, 1.0, 0.0)
      k = 0.0
      while k < n:
        if k < j:
          cAssignComplex(t3, xn1)
          cSub(t3, rs[int(k)])
          cMul(t2, t3)
        if k > j:
          cAssignComplex(t3, xn1)
          cSub(t3, rsPrev[int(k)])
          cMul(t2, t3)
        k = k + 1.0
      
      cDiv(t1, t2)
      cAssignComplex(rs[int(j)], xn1)
      cSub(rs[int(j)], t1)

      t1 = None
      j = j + 1.0
    
    withinPrecision = 0.0
    j = 0.0
    while j < n:
      eigenValue = rs[int(j)]

      # Calculate the eigenvector corresponding to the eigenvalue.
      inverseSuccess = InversePowerMethodComplex(M, eigenValue, i + 1.0, evecReference)
      if inverseSuccess:
        k = 0.0
        while k < n:
          eigenVectorsReference.matrices[int(j)].r[int(k)].c[int(0.0)] = evecReference.complexNumbers[int(k)]
          k = k + 1.0
        

        # Check eigenpair agains precision.
        eigenVector = eigenVectorsReference.matrices[int(j)]

        if CheckComplexEigenpairPrecision(M, eigenValue, eigenVector, precision):
          withinPrecision = withinPrecision + 1.0
        cAssignComplex(rsPrev[int(j)], rs[int(j)])
      j = j + 1.0
    
    if withinPrecision == n:
      success = True
    i = i + 1.0
  

  eigenValuesReference.complexNumbers = rs

  return success

def CheckComplexEigenpairPrecision(a, lambdax, e, precision):

  vec1 = MultiplyComplexToNew(a, e)
  vec2 = ScalarMultiplyComplexToNew(e, lambdax)

  equal = ComplexMatrixEqualsEpsilon(vec1, vec2, precision)

  return equal

def vectorCreate2DVector(a0, a1):

  vector =  [None]*int(2.0)
  vector[int(0.0)] = a0
  vector[int(1.0)] = a1

  return vector

def vectorCreate3DVector(a0, a1, a2):

  vector =  [None]*int(3.0)
  vector[int(0.0)] = a0
  vector[int(1.0)] = a1
  vector[int(2.0)] = a2

  return vector

def vectorCreate4DVector(a0, a1, a2, a3):

  vector =  [None]*int(4.0)
  vector[int(0.0)] = a0
  vector[int(1.0)] = a1
  vector[int(2.0)] = a2
  vector[int(3.0)] = a3

  return vector

def vectorDotProductWithCheck(a, b, answer, errorMessage):

  sum = 0.0

  if len(a) == len(b):
    sum = vectorDotProduct(a, b)
    success = True
  else:
    errorMessage.string = "The dimensions have to be equal."
    success = False

  answer.numberValue = sum

  return success

def vectorDotProduct(a, b):

  sum = 0.0
  # Dot product is the sum of the products of the corresponding entries of two vectors.
  i = 0.0
  while i < len(a):
    sum = sum + a[int(i)]*b[int(i)]
    i = i + 1.0
  

  return sum

def vectorMagnitude(a):

  sum = 0.0

  i = 0.0
  while i < len(a):
    sum = sum + a[int(i)]**2.0
    i = i + 1.0
  
  sum = sqrt(sum)

  return sum

def vectorCrossProduct3dWithCheck(a, b, answer, errorMessage):

  crossProduct =  [None]*int(3.0)

  if len(a) == 3.0 and len(b) == 3.0:
    crossProduct[int(0.0)] = a[int(1.0)]*b[int(2.0)] - b[int(1.0)]*a[int(2.0)]
    crossProduct[int(1.0)] = a[int(2.0)]*b[int(0.0)] - b[int(2.0)]*a[int(0.0)]
    crossProduct[int(2.0)] = a[int(0.0)]*b[int(1.0)] - b[int(0.0)]*a[int(1.0)]

    success = True
  else:
    errorMessage.string = "The dimensions must be 3."
    success = False

  answer.numberArray = crossProduct

  return success

def vectorSum(a):

  s = 0.0

  i = 0.0
  while i < len(a):
    s = s + a[int(i)]
    i = i + 1.0
  

  return s

def vectorProduct(a):

  p = 1.0

  i = 0.0
  while i < len(a):
    p = p*a[int(i)]
    i = i + 1.0
  

  return p

def vectorCumulativeSum(a):

  s = 0.0

  i = 0.0
  while i < len(a):
    s = s + a[int(i)]
    a[int(i)] = s
    i = i + 1.0
  

def vectorCumulativeProduct(a):

  p = 1.0

  i = 0.0
  while i < len(a):
    p = p*a[int(i)]
    a[int(i)] = p
    i = i + 1.0
  

def vectorAdd(a, b):

  i = 0.0
  while i < len(a) and i < len(b):
    a[int(i)] = a[int(i)] + b[int(i)]
    i = i + 1.0
  

def vectorSubtract(a, b):

  i = 0.0
  while i < len(a) and i < len(b):
    a[int(i)] = a[int(i)] - b[int(i)]
    i = i + 1.0
  

def vectorMultiply(a, b):

  i = 0.0
  while i < len(a) and i < len(b):
    a[int(i)] = a[int(i)]*b[int(i)]
    i = i + 1.0
  

def vectorDivide(a, b):

  i = 0.0
  while i < len(a) and i < len(b):
    a[int(i)] = a[int(i)]/b[int(i)]
    i = i + 1.0
  

def vectorAddToNew(a, b):

  c =  [None]*int(min(len(a),len(b)))

  i = 0.0
  while i < len(a) and i < len(b):
    c[int(i)] = a[int(i)] + b[int(i)]
    i = i + 1.0
  

  return c

def vectorSubtractToNew(a, b):

  c =  [None]*int(min(len(a),len(b)))

  i = 0.0
  while i < len(a) and i < len(b):
    c[int(i)] = a[int(i)] - b[int(i)]
    i = i + 1.0
  

  return c

def vectorMultiplyToNew(a, b):

  c =  [None]*int(min(len(a),len(b)))

  i = 0.0
  while i < len(a) and i < len(b):
    c[int(i)] = a[int(i)]*b[int(i)]
    i = i + 1.0
  

  return c

def vectorDivideToNew(a, b):

  c =  [None]*int(min(len(a),len(b)))

  i = 0.0
  while i < len(a) and i < len(b):
    c[int(i)] = a[int(i)]/b[int(i)]
    i = i + 1.0
  

  return c

def vectorPower(a, p):

  i = 0.0
  while i < len(a):
    a[int(i)] = a[int(i)]**p
    i = i + 1.0
  

def CreateLinearCongruentialGeneratorNumericalRecipes(seed):
  return CreateLinearCongruentialGeneratorCustom(2.0**29.0, 1664525.0, 1013904223.0, seed)

def CreateLinearCongruentialGeneratorCustom(modulus, multiplier, increment, seed):

  lcg = LinearCongruentialGenerator()
  lcg.m = modulus
  lcg.a = multiplier
  lcg.c = increment
  lcg.x = seed

  return lcg

def LinearCongruentialGeneratorNextNumber(lcg):
  lcg.x = floor((lcg.a*lcg.x + lcg.c) % lcg.m)

  return lcg.x/lcg.m

def CreatePseudorandomNumberGenerator(seed):

  prg = PseudorandomGenerator()
  prg.lcg = CreateLinearCongruentialGeneratorNumericalRecipes(seed)

  return prg

def PseudorandomNextNumber(prg):
  return LinearCongruentialGeneratorNextNumber(prg.lcg)

def PseudorandomNextInteger(prg, n):
  return floor(PseudorandomNextNumber(prg)*n)

def PseudorandomNextIntegerBetween(prg, a, b):
  return ceil(a) + floor(PseudorandomNextNumber(prg)*(b - a))

def GaloisField2e8Add(a, b):
  return Xor2Byte(a, b)

def GaloisField2e8Sub(a, b):
  return Xor2Byte(a, b)

def GaloisField2e8Mul(a, b, modulusPolynomial):

  r = 0.0

  while b != 0.0:
    if And2Byte(b, 1.0) == 1.0:
      r = Xor2Byte(r, a)
    b = ShiftRight2Byte(b, 1.0)
    a = ShiftLeft2Byte(a, 1.0)
    if (And2Byte(a, 256.0) == 256.0):
      a = Xor2Byte(a, modulusPolynomial)
  

  return r

def GaloisField2e8Reciprocal(a, modulusPolynomial):

  ga = a
  done = False
  inv = 0.0

  i = 0.0
  while i < ShiftLeft2Byte(1.0, 8.0) and  not done :
    if GaloisField2e8Mul(ga, i, modulusPolynomial) == 1.0:
      done = True
      inv = i
    i = i + 1.0
  

  return inv

def FindRoots(p, rootsReference):
  return DurandKernerMethod(p, 0.000001, 100.0, rootsReference)

def LaguerresMethodWithRepeatedDivision(p, maxIterations, precision, guess, rootsReference):

  n = pDegree(p)

  x =  [None]*int(n)

  q = pCreatePolynomial(n)
  r = pCreatePolynomial(n)
  d = pCreatePolynomial(n)

  success = True
  xkReference = CreateNumberReference(0.0)

  nr = 0.0
  while nr < n and success:
    success = LaguerresMethod(p, guess, maxIterations, precision, xkReference)

    if success:
      xk = xkReference.numberValue
      x[int(nr)] = xk

      pFill(d, 0.0)
      d[int(0.0)] =  -xk
      d[int(1.0)] = 1.0
      pDivide(q, r, p, d)
      pAssign(p, q)
    nr = nr + 1.0
  

  q = None
  r = None
  d = None
        
  rootsReference.numberArray = x

  return success

def LaguerresMethod(p, guess, maxIterations, precision, rootReference):

  n = pDegree(p)
  success = True

  xk = guess

  k = 0.0
  while (k < maxIterations) and (fabs(pEvaluate(p, xk)) >= precision) and success:
    G = pEvaluateDerivative(p, xk, 1.0)/pEvaluate(p, xk)
    H = G**2.0 - pEvaluateDerivative(p, xk, 2.0)/pEvaluate(p, xk)
    t1 = (n - 1.0)*(n*H - G**2.0)
    if t1 >= 0.0:
      denom = sqrt(t1)
      denom1 = G + denom
      denom2 = G - denom
      if fabs(denom1) >= fabs(denom2):
        denom = denom1
      else:
        denom = denom2
      a = n/denom

      xk = xk - a
    else:
      success = False
    k = k + 1.0
  

  if k == maxIterations:
    success = False

  if fabs(pEvaluate(p, xk)) >= precision:
    success = False

  rootReference.numberValue = xk

  return success

def DurandKernerMethod(p, precision, maxIterations, rootsReference):

  n = len(p) - 1.0
  rs =  [None]*int(n)
  rsPrev =  [None]*int(n)

  i = 0.0
  while i < n:
    rsPrev[int(i)] = i
    i = i + 1.0
  

  success = False

  i = 0.0
  while i < maxIterations and  not success :
    j = 0.0
    while j < n:
      xn1 = rsPrev[int(j)]

      t1 = pEvaluate(p, xn1)
      t2 = 1.0
      k = 0.0
      while k < n:
        if k < j:
          t2 = t2*(xn1 - rs[int(k)])
        if k > j:
          t2 = t2*(xn1 - rsPrev[int(k)])
        k = k + 1.0
      
      t1 = t1/t2
      rs[int(j)] = xn1 - t1
      j = j + 1.0
    
    withinPrecision = 0.0
    j = 0.0
    while j < n:
      if EpsilonCompare(rsPrev[int(j)], rs[int(j)], precision):
        withinPrecision = withinPrecision + 1.0
      rsPrev[int(j)] = rs[int(j)]
      j = j + 1.0
    
    if withinPrecision == n:
      success = True
    i = i + 1.0
  

  rootsReference.numberArray = rs

  return success

def FindRootsComplex(p, rootsReference):
  return DurandKernerMethodComplex(p, 0.000001, 100.0, rootsReference)

def DurandKernerMethodComplex(p, precision, maxIterations, rootsReference):

  n = len(p.cs) - 1.0
  rs =  [None]*int(n)
  i = 0.0
  while i < n:
    rs[int(i)] = cCreateComplexNumber(0.0, 0.0)
    i = i + 1.0
  
  rsPrev =  [None]*int(n)
  i = 0.0
  while i < n:
    rsPrev[int(i)] = cCreateComplexNumber(0.4, 0.9)
    cPower(rsPrev[int(i)], i)
    i = i + 1.0
  
  t2 = cCreateComplexNumber(0.0, 0.0)
  t3 = cCreateComplexNumber(0.0, 0.0)

  success = False

  i = 0.0
  while i < maxIterations and  not success :
    j = 0.0
    while j < n:
      xn1 = rsPrev[int(j)]

      t1 = pEvaluateComplex(p, xn1)
      cAssignComplexByValues(t2, 1.0, 0.0)
      k = 0.0
      while k < n:
        if k < j:
          cAssignComplex(t3, xn1)
          cSub(t3, rs[int(k)])
          cMul(t2, t3)
        if k > j:
          cAssignComplex(t3, xn1)
          cSub(t3, rsPrev[int(k)])
          cMul(t2, t3)
        k = k + 1.0
      
      cDiv(t1, t2)
      cAssignComplex(rs[int(j)], xn1)
      cSub(rs[int(j)], t1)
      j = j + 1.0
    
    withinPrecision = 0.0
    j = 0.0
    while j < n:
      if cEpsilonCompareComplex(rsPrev[int(j)], rs[int(j)], precision):
        withinPrecision = withinPrecision + 1.0
      cAssignComplex(rsPrev[int(j)], rs[int(j)])
      j = j + 1.0
    
    if withinPrecision == n:
      success = True
    i = i + 1.0
  

  rootsReference.complexNumbers = rs

  return success

def cCreateComplexNumber(re, im):

  z = cComplexNumber()
  z.re = re
  z.im = im

  return z

def cCreatePolarComplexNumber(r, phi):

  p = cPolarComplexNumber()
  p.r = r
  p.phi = phi

  return p

def cAdd(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  z1.re = a + c
  z1.im = b + d

def cAddToNew(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  x = cComplexNumber()

  x.re = a + c
  x.im = b + d

  return x

def cSub(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  z1.re = a - c
  z1.im = b - d

def cSubToNew(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  x = cComplexNumber()

  x.re = a - c
  x.im = b - d

  return x

def cMul(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  z1.re = a*c - b*d
  z1.im = b*c + a*d

def cMulToNew(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  x = cComplexNumber()

  x.re = a*c - b*d
  x.im = b*c + a*d

  return x

def cDiv(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  z1.re = (a*c + b*d)/(c**2.0 + d**2.0)
  z1.im = (b*c - a*d)/(c**2.0 + d**2.0)

def cDivToNew(z1, z2):

  a = z1.re
  b = z1.im
  c = z2.re
  d = z2.im

  x = cComplexNumber()

  x.re = (a*c + b*d)/(c**2.0 + d**2.0)
  x.im = (b*c - a*d)/(c**2.0 + d**2.0)

  return x

def cConjugate(z):
  z.im =  -z.im

def cConjugateToNew(z):

  x = cComplexNumber()

  x.re = z.re
  x.im =  -z.im

  return x

def cAbs(z):

  x = sqrt(z.re**2.0 + z.im**2.0)

  return x

def cArg(z):

  x = Atan2(z.im, z.re)

  return x

def cCreatePolarFromComplexNumber(z):

  x = cPolarComplexNumber()

  x.r = cAbs(z)
  x.phi = cArg(z)

  return x

def cCreateComplexFromPolar(p):

  z = cComplexNumber()

  z.re = p.r*cos(p.phi)
  z.im = p.r*sin(p.phi)

  return z

def cRe(z):
  return z.re

def cIm(z):
  return z.im

def cAddPolar(p1, p2):

  z1 = cCreateComplexFromPolar(p1)
  z2 = cCreateComplexFromPolar(p2)

  cAdd(z1, z2)

  x = cCreatePolarFromComplexNumber(z1)

  p1.r = x.r
  p1.phi = x.phi

  z1 = None
  z2 = None
  x = None

def cAddPolarToNew(p1, p2):

  z1 = cCreateComplexFromPolar(p1)
  z2 = cCreateComplexFromPolar(p2)

  cAdd(z1, z2)

  x = cCreatePolarFromComplexNumber(z1)

  z1 = None
  z2 = None

  return x

def cSubPolar(p1, p2):

  z1 = cCreateComplexFromPolar(p1)
  z2 = cCreateComplexFromPolar(p2)

  cSub(z1, z2)

  x = cCreatePolarFromComplexNumber(z1)

  p1.r = x.r
  p1.phi = x.phi

  z1 = None
  z2 = None
  x = None

def cSubPolarToNew(p1, p2):

  z1 = cCreateComplexFromPolar(p1)
  z2 = cCreateComplexFromPolar(p2)

  cSub(z1, z2)

  x = cCreatePolarFromComplexNumber(z1)

  z1 = None
  z2 = None

  return x

def cMulPolar(p1, p2):

  r1 = p1.r
  r2 = p2.r
  phi1 = p1.phi
  phi2 = p2.phi

  p1.r = r1*r2
  p1.phi = phi1 + phi2

def cMulPolarToNew(p1, p2):

  r1 = p1.r
  r2 = p2.r
  phi1 = p1.phi
  phi2 = p2.phi

  x = cPolarComplexNumber()

  x.r = r1*r2
  x.phi = phi1 + phi2

  return x

def cDivPolar(p1, p2):

  r1 = p1.r
  r2 = p2.r
  phi1 = p1.phi
  phi2 = p2.phi

  p1.r = r1/r2
  p1.phi = phi1 - phi2

def cDivPolarToNew(p1, p2):

  r1 = p1.r
  r2 = p2.r
  phi1 = p1.phi
  phi2 = p2.phi

  x = cPolarComplexNumber()

  x.r = r1/r2
  x.phi = phi1 - phi2

  return x

def cSquareRoot(z):

  a = z.re
  b = z.im

  m = sqrt(a**2.0 + b**2.0)

  z.re = sqrt((m + a)/2.0)
  z.im = Sign(b)*sqrt((m - a)/2.0)

def cPowerPolar(p, n):
  p.r = p.r**n
  p.phi = p.phi*n

def cPowerToNew(z, n):

  p = cCreatePolarFromComplexNumber(z)
  cPowerPolar(p, n)
  zp = cCreateComplexFromPolar(p)

  p = None

  return zp

def cPower(z, n):

  zp = cPowerToNew(z, n)
  z.re = zp.re
  z.im = zp.im

  zp = None

def cNegate(z):
  z.re = Negate(z.re)
  z.im = Negate(z.im)

def cAssignComplexByValues(s, re, im):
  s.re = re
  s.im = im

def cAssignComplex(a, b):
  a.re = b.re
  a.im = b.im

def cEpsilonCompareComplex(a, b, epsilon):
  return EpsilonCompare(a.re, b.re, epsilon) and EpsilonCompare(a.im, b.im, epsilon)

def cExpComplex(x):

  re = exp(x.re)*cos(x.im)
  im = exp(x.re)*sin(x.im)
  x.re = re
  x.im = im

def cSineComplex(x):

  re = sin(x.re)*Cosh(x.im)
  im = cos(x.re)*Sinh(x.im)
  x.re = re
  x.im = im

def cCosineComplex(x):

  re = cos(x.re)*Cosh(x.im)
  im = sin(x.re)*Sinh(x.im)
  x.re = re
  x.im = im

def cComplexToString(a):

  ll = CreateLinkedListCharacter()

  number = CreateStringDecimalFromNumber(a.re)

  i = 0.0
  while i < len(number):
    LinkedListAddCharacter(ll, number[int(i)])
    i = i + 1.0
  

  number = None

  if a.im < 0.0:
    LinkedListAddCharacter(ll, '-')
    number = CreateStringDecimalFromNumber( -a.im)
  else:
    LinkedListAddCharacter(ll, '+')
    number = CreateStringDecimalFromNumber(a.im)

  i = 0.0
  while i < len(number):
    LinkedListAddCharacter(ll, number[int(i)])
    i = i + 1.0
  

  number = None

  LinkedListAddCharacter(ll, 'i')

  str = LinkedListCharactersToArray(ll)
  FreeLinkedListCharacter(ll)

  return str

def pPolynomialToTextDirect(p, x):

  buffer = StringReference()

  ll = CreateLinkedListCharacter()

  if len(p) == 0.0:
    LinkedListAddCharacter(ll, '0')
  else:
    i = 0.0
    while i < len(p):
      c = p[int(i)]
      if c < 0.0:
        LinkedListAddCharacter(ll, '-')
      else:
        LinkedListAddCharacter(ll, '+')

      CreateStringFromNumberWithCheck(fabs(c), 10.0, buffer)
      LinkedListCharactersAddString(ll, buffer.string)
      buffer.string = None

      LinkedListCharactersAddString(ll, x)
      LinkedListAddCharacter(ll, '^')

      CreateStringFromNumberWithCheck(i, 10.0, buffer)
      LinkedListCharactersAddString(ll, buffer.string)
      buffer.string = None
      i = i + 1.0
    

  str = LinkedListCharactersToArray(ll)
  FreeLinkedListCharacter(ll)

  return str

def pGenerateCommonRenderSpecification(p, showCoefficient, sign, coefficient, showPower, showX):

  setZero = False

  if len(p) == 0.0:
    setZero = True
  else:
    zeros = 0.0
    i = 0.0
    while i < len(p):
      if p[int(i)] == 0.0:
        zeros = zeros + 1.0
      i = i + 1.0
    

    if zeros == len(p):
      setZero = True
    else:
      showCoefficient.booleanArray =  [None]*int(len(p))
      sign.string =  [None]*int(len(p))
      coefficient.numberArray =  [None]*int(len(p))
      showPower.booleanArray =  [None]*int(len(p))
      showX.booleanArray =  [None]*int(len(p))

      i = 0.0
      while i < len(p):
        c = p[int(i)]

        if c < 0.0:
          sign.string[int(i)] = '-'
        else:
          sign.string[int(i)] = '+'
        coefficient.numberArray[int(i)] = fabs(p[int(i)])
        if c == 0.0:
          showCoefficient.booleanArray[int(i)] = False
        else:
          if fabs(c) == 1.0 and i > 0.0:
            showCoefficient.booleanArray[int(i)] = False
          else:
            showCoefficient.booleanArray[int(i)] = True

          if i == 0.0:
            showX.booleanArray[int(i)] = False
            showPower.booleanArray[int(i)] = False
          else:
            showX.booleanArray[int(i)] = True
            if i == 1.0:
              showPower.booleanArray[int(i)] = False
            else:
              showPower.booleanArray[int(i)] = True
        i = i + 1.0
      

  if setZero:
    showCoefficient.booleanArray =  [None]*int(1.0)
    sign.string =  [None]*int(1.0)
    coefficient.numberArray =  [None]*int(1.0)
    showPower.booleanArray =  [None]*int(1.0)
    showX.booleanArray =  [None]*int(1.0)

    showCoefficient.booleanArray[int(0.0)] = True
    sign.string[int(0.0)] = '+'
    coefficient.numberArray[int(0.0)] = 0.0
    showPower.booleanArray[int(0.0)] = True
    showX.booleanArray[int(0.0)] = False

def pPolynomialToText(p, x):

  showCoefficient = CreateBooleanArrayReferenceLengthValue(0.0, False)
  showPower = CreateBooleanArrayReferenceLengthValue(0.0, False)
  showX = CreateBooleanArrayReferenceLengthValue(0.0, False)
  sign = CreateStringReferenceLengthValue(0.0, ' ')
  coefficient = CreateNumberArrayReferenceLengthValue(0.0, 0.0)

  pGenerateCommonRenderSpecification(p, showCoefficient, sign, coefficient, showPower, showX)

  buffer = CreateStringReferenceLengthValue(0.0, ' ')

  ll = CreateLinkedListCharacter()

  hasPrinted = False
  i = 0.0
  while i < len(showCoefficient.booleanArray):
    c = p[int(i)]

    if showCoefficient.booleanArray[int(i)] or showX.booleanArray[int(i)]:
      if  not hasPrinted  and c >= 0.0:
        pass
      else:
        LinkedListAddCharacter(ll, sign.string[int(i)])

      if showCoefficient.booleanArray[int(i)]:
        CreateStringFromNumberWithCheck(coefficient.numberArray[int(i)], 10.0, buffer)
        LinkedListCharactersAddString(ll, buffer.string)
        buffer.string = None
        hasPrinted = True

      if showX.booleanArray[int(i)]:
        LinkedListCharactersAddString(ll, x)
        hasPrinted = True
        if showPower.booleanArray[int(i)]:
          LinkedListAddCharacter(ll, '^')
          CreateStringFromNumberWithCheck(i, 10.0, buffer)
          LinkedListCharactersAddString(ll, buffer.string)
          buffer.string = None
    i = i + 1.0
  

  str = LinkedListCharactersToArray(ll)
  FreeLinkedListCharacter(ll)

  return str

def pComplexPolynomialToTextDirect(p, x):

  buffer = StringReference()

  ll = CreateLinkedListCharacter()

  if len(p.cs) == 0.0:
    LinkedListAddCharacter(ll, '0')
  else:
    i = 0.0
    while i < len(p.cs):
      c = p.cs[int(i)]
      if i > 0.0:
        LinkedListAddCharacter(ll, '+')

      number = cComplexToString(c)
      LinkedListAddCharacter(ll, '(')
      LinkedListCharactersAddString(ll, number)
      LinkedListAddCharacter(ll, ')')
      number = None

      LinkedListCharactersAddString(ll, x)
      LinkedListAddCharacter(ll, '^')

      CreateStringFromNumberWithCheck(i, 10.0, buffer)
      LinkedListCharactersAddString(ll, buffer.string)
      buffer.string = None
      i = i + 1.0
    

  str = LinkedListCharactersToArray(ll)
  FreeLinkedListCharacter(ll)

  return str

def pAdd(a, b):

  nr = len(b)

  i = 0.0
  while i < nr:
    a[int(i)] = a[int(i)] + b[int(i)]
    i = i + 1.0
  

def pSubtract(a, b):

  nr = len(b)

  i = 0.0
  while i < nr:
    a[int(i)] = a[int(i)] - b[int(i)]
    i = i + 1.0
  

def pMultiply(c, a, b):

  n = pDegree(a)
  m = pDegree(b)

  pFill(c, 0.0)

  i = 0.0
  while i <= n + m:
    c[int(i)] = 0.0
    k = 0.0
    while k <= i and k < len(a) and i - k < len(b):
      av = a[int(k)]
      bv = b[int(i - k)]
      c[int(i)] = c[int(i)] + av*bv
      k = k + 1.0
    
    i = i + 1.0
  

def pDivide(q, r, n, d):

  pFill(q, 0.0)
  pAssign(r, n)
  deg = pDegree(n)
  t = pCreatePolynomial(deg)
  t1 = pCreatePolynomial(deg)

  rd = pDegree(r)
  dd = pDegree(d)
  i = 0.0
  while i < deg + 1.0 and  not pIsZero(r)  and rd - i >= dd:
    pFill(t, 0.0)
    tdegree = rd - i - dd
    tcoff = r[int(rd - i)]/d[int(dd)]
    t[int(tdegree)] = tcoff
    pAdd(q, t)
    pFill(t1, 0.0)
    pMultiply(t1, t, d)
    pSubtract(r, t1)
    i = i + 1.0
  

  t = None
  t1 = None

def pIsZero(a):

  itIsZero = True

  i = 0.0
  while i < len(a):
    if a[int(i)] != 0.0:
      itIsZero = False
    i = i + 1.0
  

  return itIsZero

def pAssign(a, b):

  nr = len(b)

  i = 0.0
  while i < nr:
    a[int(i)] = b[int(i)]
    i = i + 1.0
  

def pCreatePolynomial(deg):

  p =  [None]*int(deg + 1.0)

  pFill(p, 0.0)

  return p

def pFill(p, value):

  i = 0.0
  while i < len(p):
    p[int(i)] = value
    i = i + 1.0
  

def pDegree(A):

  done = False
  deg = 0.0
  i = len(A) - 1.0
  while i >= 0.0 and  not done :
    if A[int(i)] != 0.0:
      deg = i
      done = True
    i = i - 1.0
  

  return deg

def pLead(A):

  deg = pDegree(A)

  return A[int(deg)]

def pEvaluate(A, x):
  return pEvaluateWithHornersMethod(A, x)

def pEvaluateWithHornersMethod(A, x):

  r = 0.0

  i = len(A) - 1.0
  while i >= 0.0:
    r = r*x
    r = A[int(i)] + r
    i = i - 1.0
  

  return r

def pEvaluateWithPowers(A, x):

  r = 0.0

  i = 0.0
  while i < len(A):
    r = r + A[int(i)]*x**i
    i = i + 1.0
  

  return r

def pEvaluateDerivative(A, x, n):

  r = 0.0

  i = 0.0
  while i < len(A):
    if i - n >= 0.0:
      v = A[int(i)]*Permutations(i, n)*x**(i - n)
      r = r + v
    i = i + 1.0
  

  return r

def pDerivative(A):

  degree = 0.0
  i = 1.0
  while i < len(A):
    degree = degree + 1.0
    A[int(i - 1.0)] = degree*A[int(i)]
    i = i + 1.0
  

  A[int(len(A) - 1.0)] = 0.0

def pAddComplex(a, b):

  nr = len(a.cs)

  i = 0.0
  while i < nr:
    cAdd(a.cs[int(i)], b.cs[int(i)])
    i = i + 1.0
  

def pSubtractComplex(a, b):

  nr = len(a.cs)

  i = 0.0
  while i < nr:
    cSub(a.cs[int(i)], b.cs[int(i)])
    i = i + 1.0
  

def pIsZeroComplex(a):

  itIsZero = True

  i = 0.0
  while i < len(a.cs):
    if a.cs[int(i)].re != 0.0 and a.cs[int(i)].im != 0.0:
      itIsZero = False
    i = i + 1.0
  

  return itIsZero

def pAssignComplex(a, b):

  nr = len(b.cs)

  i = 0.0
  while i < nr:
    cAssignComplex(a.cs[int(i)], b.cs[int(i)])
    i = i + 1.0
  

def pCreateComplexPolynomial(deg):

  p = pComplexPolynomial()
  p.cs =  [None]*int(deg + 1.0)

  i = 0.0
  while i < deg + 1.0:
    p.cs[int(i)] = cComplexNumber()
    i = i + 1.0
  

  pFillComplex(p, 0.0, 0.0)

  return p

def pFillComplex(p, re, im):

  c = cCreateComplexNumber(re, im)

  i = 0.0
  while i < len(p.cs):
    cAssignComplex(p.cs[int(i)], c)
    i = i + 1.0
  

  c = None

def pDegreeComplex(A):

  done = False
  deg = 0.0
  i = len(A.cs) - 1.0
  while i >= 0.0 and  not done :
    if A.cs[int(i)].re != 0.0 and A.cs[int(i)].im != 0.0:
      deg = i
      done = True
    i = i - 1.0
  

  return deg

def pLeadComplex(A):

  deg = pDegreeComplex(A)

  return A.cs[int(deg)]

def pEvaluateComplex(A, x):

  r = cCreateComplexNumber(0.0, 0.0)
  t = cCreateComplexNumber(0.0, 0.0)

  i = 0.0
  while i < len(A.cs):
    cAssignComplex(t, x)
    cPower(t, i)
    cMul(t, A.cs[int(i)])
    cAdd(r, t)
    i = i + 1.0
  

  return r

def pTotalNumberOfRoots(p):
  return pDegree(p)


