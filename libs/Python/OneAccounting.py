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

    AddMonthsToDate(date, 1.0)
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

def test():

  failures = CreateNumberReference(0.0)

  TestBasicAccounting(failures)
  TestAccruals(failures)
  TestIFRSAccountPlan(failures)

  return failures.numberValue

def TestIFRSAccountPlan(failures):
  GetIFRSAccountPlan()

def TestBasicAccounting(failures):

  ledger = CreateLedger(2.0)

  #c = CreateFixedPointForDynamicLedger(ledger);
  #d = CreateFixedPointForDynamicLedger(ledger);
  # Transaction 1:
  transaction =  [None]*int(2.0)
  #date = CreateDate(2026d, 2d, 18d);
  date = DateFromStringISO8601("2026-02-18")

  # Debit, 100, 1000, l1, 2026-02-18
  #
  #        accountName = "1000".toCharArray();
  #        Assign15d(d, 100d);
  #        Assign15d(c, 0d);
  #        desc = "l1".toCharArray();
  #        transaction[0] = CreateLine(accountName, d, c, desc, date);
  #        
  transaction[int(0.0)] = CreateLineFromScript(ledger, "Debit, 1000, 100, l1", date)

  # Credit, 100, 2000, l2, 2026-02-18
  #
  #        accountName = "2000".toCharArray();
  #        Assign15d(d, 0d);
  #        Assign15d(c, 100d);
  #        desc = "l2".toCharArray();
  #        transaction[1] = CreateLine(accountName, d, c, desc, date);
  #        
  transaction[int(1.0)] = CreateLineFromScript(ledger, "Credit, 2000, 100, l2", date)

  valid = ValidateAndAddTransactionToLedger(ledger, transaction)

  AssertTrue(valid, failures)

  # Compute
  sledger = LedgerDynamicToStatic(ledger)

  accountName = "1000"
  fromx = DateFromStringISO8601("2026-02-17")
  to = DateFromStringISO8601("2026-02-19")
  account = ComputeAccountBalance(sledger, accountName, fromx, to)

  accountStr = AccountToString(account)

  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)", failures)

def TestAccruals(failures):

  ledger = CreateLedger(2.0)

  c = CreateFixedPointForDynamicLedger(ledger)
  d = CreateFixedPointForDynamicLedger(ledger)

  # Case:
  #           * A domain is renewed for the period 2025-12-06 - 2026-12-05.
  #           * it is invoiced 2025-09-17 with a due date 2025-10-01, amount 125.00
  #           * It is paid 2025-10-01.
  #           * It is renewed 2025-11-08 by paying the renewal fee 112.50
  #           * The domain must be correctly accounted for using accruals for each month
  #         

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
  transaction =  [None]*int(2.0)
  date = DateFromStringISO8601("2025-09-17")
  transaction[int(0.0)] = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x", date)
  transaction[int(1.0)] = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x", date)
  valid = ValidateAndAddTransactionToLedger(ledger, transaction)
  AssertTrue(valid, failures)

  # Transaction: Invoice paid
  transaction =  [None]*int(2.0)
  date = DateFromStringISO8601("2025-10-01")
  transaction[int(0.0)] = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x", date)
  transaction[int(1.0)] = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x", date)
  valid = ValidateAndAddTransactionToLedger(ledger, transaction)
  AssertTrue(valid, failures)

  # Transaction: Renewal paid
  transaction =  [None]*int(2.0)
  date = DateFromStringISO8601("2025-11-08")
  transaction[int(0.0)] = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x", date)
  transaction[int(1.0)] = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x", date)
  valid = ValidateAndAddTransactionToLedger(ledger, transaction)
  AssertTrue(valid, failures)

  # Accruals income
  fromx = DateFromStringISO8601("2025-12-06")
  to = DateFromStringISO8601("2026-12-05")
  AddMonthlyAccruals(ledger, fromx, to, 125.0, "3.4.2", "4.1.2")

  # Accruals cost
  fromx = DateFromStringISO8601("2025-12-06")
  to = DateFromStringISO8601("2026-12-05")
  AddMonthlyAccruals(ledger, fromx, to, 112.50, "5.1.3", "1.7.1")

  # Compute
  sledger = LedgerDynamicToStatic(ledger)

  fromx = DateFromStringISO8601("2027-01-01")
  to = DateFromStringISO8601("2027-01-01")

  account = ComputeAccountBalance(sledger, "5.1.3", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "4.1.2", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "1.8.1", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "3.4.2", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "1.11.1", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "1.7.1", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)", failures)

  #System.out.println("");
  # In between
  fromx = DateFromStringISO8601("2026-06-15")
  to = DateFromStringISO8601("2026-06-16")

  account = ComputeAccountBalance(sledger, "5.1.3", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "4.1.2", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "1.8.1", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "3.4.2", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "1.11.1", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)", failures)

  account = ComputeAccountBalance(sledger, "1.7.1", fromx, to)
  accountStr = AccountToString(account)
  #System.out.println(accountStr);
  AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)", failures)

  # Balance Sheet: Snapshots a companys assets, liabilities, and equity at a specific point in time.
  # Income Statement (P&L): Shows revenue, expenses, and profit/loss over a period.
  # Cash Flow Statement: Tracks cash inflow and outflow from operating, investing, and financing activities.
  # Statement of Shareholders' Equity: Details changes in owner interest over time.
  #accountPlan = new AccountPlan();
  #        accountPlan.accountDefinitions = new AccountDefinition[11];
  #        assetsDef = CreateAccountDefinition("Assets".toCharArray(), "1".toCharArray(), "Assets".toCharArray(), true);
  #        a148 = CreateAccountDefinition("Forskuddsbetalt leverandor".toCharArray(), "1.4".toCharArray(), "".toCharArray(), true);
  #        a150 = CreateAccountDefinition("Kundefordringer".toCharArray(), "1.5".toCharArray(), "".toCharArray(), true);
  #        a192 = CreateAccountDefinition("Bankinnskudd".toCharArray(), "1.9".toCharArray(), "".toCharArray(), true);
  #        liabilitiesDef = CreateAccountDefinition("Liabilities".toCharArray(), "2".toCharArray(), "Liabilities".toCharArray(), false);
  #        a290 = CreateAccountDefinition("Forskuddsbetalt inntekt/kortsiktig gjeld".toCharArray(), "2.9".toCharArray(), "".toCharArray(), true);
  #        equitiesDef = CreateAccountDefinition("Equities".toCharArray(), "4".toCharArray(), "Equities".toCharArray(), false);
  #        incomeDef = CreateAccountDefinition("Income".toCharArray(), "3".toCharArray(), "Revenue".toCharArray(), false);
  #        a300 = CreateAccountDefinition("Salgsinntekt".toCharArray(), "2.9".toCharArray(), "".toCharArray(), true);
  #        expensesDef = CreateAccountDefinition("Expenses".toCharArray(), "6".toCharArray(), "Expenses".toCharArray(), true);
  #        a600 = CreateAccountDefinition("Domenekostnader".toCharArray(), "6.0".toCharArray(), "".toCharArray(), true);
  #
  #        accountPlan.accountDefinitions[0] = assetsDef;
  #        accountPlan.accountDefinitions[1] = a148;
  #        accountPlan.accountDefinitions[2] = a150;
  #        accountPlan.accountDefinitions[3] = a192;
  #        accountPlan.accountDefinitions[4] = liabilitiesDef;
  #        accountPlan.accountDefinitions[5] = a290;
  #        accountPlan.accountDefinitions[6] = equitiesDef;
  #        accountPlan.accountDefinitions[7] = incomeDef;
  #        accountPlan.accountDefinitions[8] = a300;
  #        accountPlan.accountDefinitions[9] = expensesDef;
  #        accountPlan.accountDefinitions[10] = a600;
  #        sledger.accountPlan = accountPlan

  sledger.accountPlan = GetIFRSAccountPlan()

  to = DateFromStringISO8601("2026-02-16")
  balanceSheetRef = DataReference()
  success = ComputeAccountBalances(sledger, 2.0, to, balanceSheetRef)
  accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure)
  AssertTrue(success, failures)
  #System.out.println(accountSummaryStr);
  # Compute monthly table
  to = DateFromStringISO8601("2025-08-01")
  message = StringReference()
  AddDaysToDate(to,  -1.0, message)
  balances = CreateArray()
  i = 0.0
  while i < 12.0 + 6.0:
    AddDaysToDate(to, 1.0, message)
    AddMonthsToDate(to, 1.0)
    AddDaysToDate(to,  -1.0, message)

    balanceSheetRef = DataReference()
    success = ComputeAccountBalances(sledger, 1.0, to, balanceSheetRef)

    if success:
      AddStructToArray(balances, balanceSheetRef.data.structure)
    i = i + 1.0
  
  ComputeBalanceDiffs(sledger, balances)

  html = BalancesArrayToHTML(balances, True, False)

  #StringToFile("x.html", html);
  html = BalancesArrayToHTML(balances, False, True)

  #StringToFile("x-diff.html", html);
  html = BalancesArrayToHTML(balances, True, True)

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
  ref.string = value

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

  i = 0.0
  while i < len(stringArrayReference.stringArray):
    stringArrayReference.stringArray[int(i)] = None
    i = i + 1.0
  
  stringArrayReference.stringArray = None
  stringArrayReference = None

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
    if date.month >= 1.0 and date.month <= 12.0:
      daysInMonth = GetDaysInMonth(date.year)
      daysInThisMonth = daysInMonth[int(date.month)]
      if date.day >= 1.0 and date.day <= daysInThisMonth:
        valid = True
      else:
        valid = False
        message.string = "The month does not have the given day number."
    else:
      valid = False
      message.string = "Month must be between 1 and 12, inclusive."
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

def AddMonthsToDate(date, months):

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

  aDays = DateToDays(a)
  bDays = DateToDays(b)

  return aDays < bDays

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

  done = False
  dateOfInterest = Date()
  AssignDate(dateOfInterest, fromx)
  while  not done :
    if dateOfInterest.year == to.year and dateOfInterest.month == to.month:
      done = True

    entry = GetAccrualAmountWithDates(total, fromx, to, dateOfInterest.year, dateOfInterest.month)
    LinkedListAddNumber(list, entry)
    AddMonthsToDate(dateOfInterest, 1.0)
  

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

  string = CreateDynamicArrayCharacters()
  isPositive = True

  if number < 0.0:
    isPositive = False
    number =  -number

  if number == 0.0:
    DynamicArrayAddCharacter(string, '0')
  else:
    characterReference = CharacterReference()

    maximumDigits = GetMaximumDigitsForDecimal()

    digitPosition = GetFirstDecimalDigitPosition(number)

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
      d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1.0)
      if d == 0.0:
        trailingZeros = trailingZeros + 1.0
      else:
        done = True
      i = i + 1.0
    

    # Print number.
    i = 0.0
    while i < maximumDigits:
      d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i)

      if  not hasPrintedPoint  and digitPosition - i + 1.0 == 0.0:
        if maximumDigits - i > trailingZeros:
          DynamicArrayAddCharacter(string, '.')
        hasPrintedPoint = True

      if maximumDigits - i <= trailingZeros and hasPrintedPoint:
        pass
      else:
        GetDecimalDigitCharacterFromNumberWithCheck(d, characterReference)
        c = characterReference.characterValue
        DynamicArrayAddCharacter(string, c)
      i = i + 1.0
    

    # Print trailing zeros.
    i = 0.0
    while i < digitPosition - maximumDigits + 1.0:
      DynamicArrayAddCharacter(string, '0')
      i = i + 1.0
    

  # Done
  str = DynamicArrayCharactersToArray(string)
  FreeDynamicArrayCharacters(string)
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

def GetFirstDecimalDigitPosition(n):

  n = fabs(n)

  if n != 0.0:
    if floor(n) < 10.0**15.0:
      multiply = True
    else:
      multiply = False

    done = False
    m = 0.0
    i = 0.0
    while  not done :
      if multiply:
        m = n*10.0**i
        if floor(m) >= 10.0**14.0:
          done = True
      else:
        m = n/10.0**i
        if floor(m) < 10.0**15.0:
          done = True
      i = i + 1.0
    

    if multiply:
      power = 15.0 - i
    else:
      power = 15.0 + i - 2.0

    if Round(m) >= 10.0**15.0:
      power = power + 1.0
  else:
    power = 1.0

  return power

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

  e = 15.0 - digitPosition - 1.0
  if e < 0.0:
    n = round(n/10.0**fabs(e))
  else:
    n = round(n*10.0**e)

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
  return CreateNumberFromStringWithCheck(string, 10.0, decimalReference, message)

def CreateNumberFromDecimalString(string):

  doubleReference = CreateNumberReference(0.0)
  stringReference = CreateStringReference("")
  CreateNumberFromStringWithCheck(string, 10.0, doubleReference, stringReference)
  number = doubleReference.numberValue

  doubleReference = None
  stringReference = None

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

def CreateNumberFromParts(base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent):

  n = 0.0

  i = 0.0
  while i < len(beforePoint):
    p = beforePoint[int(len(beforePoint) - i - 1.0)]

    n = n + p*base**i
    i = i + 1.0
  

  i = 0.0
  while i < len(afterPoint):
    p = afterPoint[int(i)]

    n = n + p/base**(i + 1.0)
    i = i + 1.0
  

  if len(exponent) > 0.0:
    e = 0.0
    i = 0.0
    while i < len(exponent):
      p = exponent[int(len(exponent) - i - 1.0)]

      e = e + p*base**i
      i = i + 1.0
    

    if  not exponentIsPositive :
      e =  -e

    n = n*base**e

  if  not numberIsPositive :
    n =  -n

  return n

def ExtractPartsFromNumberString(n, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, errorMessages):

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
    errorMessages.string = "Number cannot have length zero."

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
      errorMessages.string = "Number must have at least one number after the optional sign."

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
          errorMessages.string = "There must be at least one digit after the decimal point."
      else:
        success = False
        errorMessages.string = "There must be at least one digit after the decimal point."
    elif base <= 14.0 and (n[int(i)] == 'e' or n[int(i)] == 'E'):
      if i < len(n):
        success = True
        afterPoint.numberArray =  [None]*int(0.0)
      else:
        success = False
        errorMessages.string = "There must be at least one digit after the exponent."
    else:
      success = False
      errorMessages.string = "Expected decimal point or exponent symbol."

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
              errorMessages.string = "There cannot be any characters past the exponent of the number."
          else:
            success = False
            errorMessages.string = "There must be at least one digit after the decimal point."
        else:
          success = False
          errorMessages.string = "There must be at least one digit after the exponent symbol."
      else:
        success = False
        errorMessages.string = "There must be at least one digit after the exponent symbol."
    else:
      success = False
      errorMessages.string = "Expected exponent symbol."

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


