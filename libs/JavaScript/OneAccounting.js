// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

function CreateLedger(decimals){
  var ledger;
  var transactions;

  ledger = CreateStructure();
  transactions = CreateArray();
  AddNumberToStruct(ledger, "decimals".split(''), decimals);
  AddArrayToStruct(ledger, "transactions".split(''), transactions);

  return ledger;
}
function CreateFixedPointForDynamicLedger(ledger){
  var n;
  var d;

  d = GetNumberFromStruct(ledger, "decimals".split(''));
  n = CreateFixedPoint15d(15 - d, d);

  return n;
}
function CreateFixedPointForStaticLedger(ledger){
  var n;
  var d;

  d = ledger.decimals;
  n = CreateFixedPoint15d(15 - d, d);

  return n;
}
function CreateLine(account, debit, credit, description, date){
  var t;

  t = {};

  t.account = arraysCopyString(account);
  t.debit = Copy15d(debit);
  t.credit = Copy15d(credit);
  t.description = arraysCopyString(description);
  t.date = CopyDate(date);

  return t;
}
function AddTransactionToLedger(ledger, src){
  var dst;

  dst = LineToStructure(src);

  AddStructToArray(ledger, dst);
}
function AddTransactionsToLedger(ledger, ts){
  var dst;
  var i;

  for(i = 0; i < ts.length; i = i + 1){
    dst = LineToStructure(ts[i]);
    AddStructToArray(ledger, dst);
  }
}
function ValidateAndAddTransactionToLedger(ledger, ls){
  var dst;
  var i;
  var valid;
  var transactions;
  var lines;

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
function GetTransactionFromLedger(ledger, index){
  var dst;
  var t;
  var transactions;
  var decimals;

  transactions = GetArrayFromStruct(ledger, "transactions".split(''));
  decimals = GetNumberFromStruct(ledger, "decimals".split(''));

  dst = ArrayIndexStruct(transactions, index);

  t = LineFromStructure(dst, ledger);

  return t;
}
function LineToStructure(src){
  var dst;
  var debitStr, creditStr, dateStr;

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
function LineFromStructure(src, ledger){
  var dst;
  var account, debitStr, creditStr, dateStr, description;
  var debit, credit;
  var date;
  var debitNumber, creditNumber;

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
function LedgerDynamicToStatic(src){
  var dst;
  var ts, ls, i, j, decimals;
  var line;
  var transactions, lines;
  var sline;
  var t;

  dst = {};

  transactions = GetArrayFromStruct(src, "transactions".split(''));
  decimals = GetNumberFromStruct(src, "decimals".split(''));
  ts = ArrayLength(transactions);

  dst.decimals = decimals;
  dst.transactions = [];
  dst.transactions.length = ts;

  for(i = 0; i < ts; i = i + 1){
    lines = ArrayIndexArray(transactions, i);
    ls = ArrayLength(lines);

    t = {};
    t.lines = [];
    t.lines.length = ls;

    for(j = 0; j < ls; j = j + 1){
      line = ArrayIndexStruct(lines, j);
      sline = LineFromStructure(line, src);
      t.lines[j] = sline;
    }

    dst.transactions[i] = t;
  }

  return dst;
}
function ValidateTransaction(ts, ledger){
  var valid;
  var creditSum, debitSum;
  var i, d, c;
  var t;
  var creditStr, debitStr;
  var date;

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
function ValidateTransactions(ts, invalidIds){
  var valid;

  /* TODO */
  valid = true;

  return valid;
}
function ComputeAccountBalance(ledger, accountName, fromDate, toDate){
  var a;
  var i, j;
  var t;
  var ts;
  var l;

  ts = ledger.transactions;

  a = {};

  a.name = arraysCopyString(accountName);
  a.endingBalance = CreateFixedPointForStaticLedger(ledger);
  a.startingBalance = CreateFixedPointForStaticLedger(ledger);
  a.from = CopyDate(fromDate);
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
function AccountToString(account){
  var ll;
  var diff;

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
function AddMonthlyAccruals(ledger, from, to, amount, fromAccount, toAccount){
  var i;
  var accountName, desc;
  var amounts;
  var transaction;
  var valid;
  var date;
  var c, d;

  amounts = GetAccrualsWithDates(amount, from, to);

  date = CopyDate(from);
  date.day = 1;

  c = CreateFixedPointForDynamicLedger(ledger);
  d = CreateFixedPointForDynamicLedger(ledger);

  for(i = 0; i < amounts.length; i = i + 1){
    transaction = [];
    transaction.length = 2;

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
function ComputeAccountBalancePrefixAccount(ledger, accountNr, toDate, debitBalance){
  var i, j;
  var t;
  var ts;
  var l;
  var balance;
  var prefixL;
  var prefixed;

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
function GetIFRSAccountPlan(){
  var accountPlanString;
  var validRef;
  var ll;

  ll = CreateLinkedListCharacter();

  /* https://www.ifrs-gaap.com/ifrs-chart-accounts */
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
function ParseAccountPlanString(accountPlanString, valid){
  var ap;
  var i;
  var line;
  var lines, parts;
  var ad;

  ap = {};

  accountPlanString = strTrim(accountPlanString);
  lines = strSplitByCharacter(accountPlanString, '\n');

  ap.accountDefinitions = [];
  ap.accountDefinitions.length = lines.length;

  for(i = 0; i < lines.length; i = i + 1){
    line = lines[i].string;
    /*System.out.println(line); */
    parts = strSplitByCharacter(line, '\t');

    ad = {};

    ad.accountName = parts[1].string;
    ad.number = parts[0].string;
    if(arraysStringsEqual(parts[2].string, "(Cr)".split(''))){
      ad.debitBalance = false;
    }else{
      ad.debitBalance = true;
    }
    ad.role = "".split('');
    if(arraysStringsEqual(ad.number, "1".split(''))){
      ad.role = "Assets".split('');
    }else if(arraysStringsEqual(ad.number, "2".split(''))){
      ad.role = "Equities".split('');
    }else if(arraysStringsEqual(ad.number, "3".split(''))){
      ad.role = "Liabilities".split('');
    }else if(arraysStringsEqual(ad.number, "4".split(''))){
      ad.role = "Revenue".split('');
    }else if(arraysStringsEqual(ad.number, "5".split(''))){
      ad.role = "Expenses".split('');
    }

    ap.accountDefinitions[i] = ad;
  }

  return ap;
}
function ComputeAccountBalances(sledger, depth, date, balanceSheet){
  var accountPlan;
  var assetsBalance, liabilitiesBalance, equitiesBalance, revenueBalanace, expensesBalance, resultBalance, sum, balance;
  var balanceStr;
  var assetsDef, liabilitiesDef, equitiesDef, revenueDef, expensesDef, accountDef;
  var success, isBalanced;
  var i;
  var parts;
  var foundRef;
  var accounts;
  var account;
  var dateStr;

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
    assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef.number, date, assetsDef.debitBalance);
    liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef.number, date, liabilitiesDef.debitBalance);

    /* TODO: This must be for a period */
    revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef.number, date, revenueDef.debitBalance);
    expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef.number, date, expensesDef.debitBalance);
    resultBalance = CreateFixedPointForStaticLedger(sledger);
    Subtract15d(resultBalance, revenueBalanace, expensesBalance);
    balanceStr = FormatToStringWithSymbols15d(resultBalance, 2, "".split(''), ".".split(''));
    AddStringToStruct(balanceSheet.data.structure, "result".split(''), balanceStr);

    equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef.number, date, equitiesDef.debitBalance);
    Add15d(equitiesBalance, equitiesBalance, resultBalance);

    /* Compute accounts */
    accounts = CreateArray();

    for(i = 0; i < accountPlan.accountDefinitions.length; i = i + 1){
      accountDef = accountPlan.accountDefinitions[i];

      parts = strSplitByCharacter(accountDef.number, '.');

      if(parts.length <= depth + 1){
        account = CreateStructure();

        balance = ComputeAccountBalancePrefixAccount(sledger, accountDef.number, date, accountDef.debitBalance);

        balanceStr = FormatToStringWithSymbols15d(balance, 2, "".split(''), ".".split(''));

        AddStringToStruct(account, "number".split(''), accountDef.number);
        AddStringToStruct(account, "name".split(''), accountDef.accountName);
        AddStringToStruct(account, "balance".split(''), balanceStr);
        AddNumberToStruct(account, "depth".split(''), parts.length - 1);

        AddStructToArray(accounts, account);
      }
    }

    AddArrayToStruct(balanceSheet.data.structure, "accounts".split(''), accounts);

    /* End conclusion */
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
function AccountBalancesToString(balanceSheet){
  var ll;
  var balanceStr;
  var isBalanced;
  var i, j, depth;
  var accounts;
  var account;
  var accountNumber, accountName;

  ll = CreateLinkedListCharacter();

  /* Print accounts */
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

  /* End conclusion */
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
function FindAccountWithRole(accountPlan, role, foundRef){
  var i;
  var ad;
  var done;

  ad = {};

  done = false;
  for(i = 0; i < accountPlan.accountDefinitions.length &&  !done ; i = i + 1){
    ad = accountPlan.accountDefinitions[i];
    if(arraysStringsEqual(ad.role, role)){
      done = true;
    }
  }

  foundRef.booleanValue = done;

  return ad;
}
function CreateAccountDefinition(name, number, role, debitBalance){
  var def;

  def = {};
  def.accountName = name;
  def.number = number;
  def.role = role;
  def.debitBalance = debitBalance;

  return def;
}
function ComputeBalanceDiffs(sledger, balances){
  var i, j;
  var balance, first, balance1, balance2;
  var account1, account2;
  var b1, b2, diffStr;
  var f1, f2, diff;
  var accountsO, accounts1, accounts2;

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

      /*System.out.println(diffStr); */
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

    /*System.out.println(diffStr); */
    if(i == 1){
      AddStringToStruct(balance1, "rchange".split(''), "0.00".split(''));
    }
    AddStringToStruct(balance2, "rchange".split(''), diffStr);
  }
}
function BalancesArrayToHTML(balances, includeBalance, includeDiff){
  var ll;
  var i, j;
  var balance, first;
  var dateStr, name, number, balanceStr, changeStr;
  var account;
  var accounts;

  ll = CreateLinkedListCharacter();

  LinkedListCharactersAddString(ll, "<html>".split(''));
  LinkedListCharactersAddString(ll, "<body>".split(''));
  LinkedListCharactersAddString(ll, "<table>".split(''));

  /* Headers */
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

  /* Each account */
  first = ArrayIndexStruct(balances, 0);
  accounts = GetArrayFromStruct(first, "accounts".split(''));
  for(j = 0; j < ArrayLength(accounts); j = j + 1){
    LinkedListCharactersAddString(ll, "<tr>".split(''));

    account = ArrayIndexStruct(accounts, j);
    name = GetStringFromStruct(account, "name".split(''));
    number = GetStringFromStruct(account, "number".split(''));

    LinkedListCharactersAddString(ll, "<td>".split(''));
    LinkedListCharactersAddString(ll, number);
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

  /* Result */
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

  /* Footer */
  LinkedListCharactersAddString(ll, "</table>".split(''));
  LinkedListCharactersAddString(ll, "</body>".split(''));
  LinkedListCharactersAddString(ll, "</html>".split(''));

  return LinkedListCharactersToArray(ll);
}
function CreateLineFromScript(ledger, script, date){
  var parts;
  var c, d;
  var line;
  var i, n;

  c = CreateFixedPointForDynamicLedger(ledger);
  d = CreateFixedPointForDynamicLedger(ledger);

  parts = strSplitByCharacter(script, ',');

  for(i = 0; i < parts.length; i = i + 1){
    parts[i].string = strTrim(parts[i].string);
  }

  line = {};

  n = CreateNumberFromDecimalString(parts[2].string);

  line.date = date;
  if(arraysStringsEqual(parts[0].string, "Debit".split(''))){
    Assign15d(d, n);
    Assign15d(c, 0);
  }else if(arraysStringsEqual(parts[0].string, "Credit".split(''))){
    Assign15d(d, 0);
    Assign15d(c, n);
  }

  line = CreateLine(parts[1].string, d, c, parts[3].string, date);

  return line;
}
function test(){
  var failures;

  failures = CreateNumberReference(0);

  TestBasicAccounting(failures);
  TestAccruals(failures);
  TestIFRSAccountPlan(failures);

  return failures.numberValue;
}
function TestIFRSAccountPlan(failures){
  GetIFRSAccountPlan();
}
function TestBasicAccounting(failures){
  var ledger;
  var c, d;
  var transaction;
  var valid;
  var date, from, to;
  var account;
  var accountName, accountStr, desc;
  var sledger;

  ledger = CreateLedger(2);

  /*c = CreateFixedPointForDynamicLedger(ledger); */
  /*d = CreateFixedPointForDynamicLedger(ledger); */
  /* Transaction 1: */
  transaction = [];
  transaction.length = 2;
  /*date = CreateDate(2026d, 2d, 18d); */
  date = DateFromStringISO8601("2026-02-18".split(''));

  /* Debit, 100, 1000, l1, 2026-02-18 */
  /*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
         */
  transaction[0] = CreateLineFromScript(ledger, "Debit, 1000, 100, l1".split(''), date);

  /* Credit, 100, 2000, l2, 2026-02-18 */
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

  /* Compute */
  sledger = LedgerDynamicToStatic(ledger);

  accountName = "1000".split('');
  from = DateFromStringISO8601("2026-02-17".split(''));
  to = DateFromStringISO8601("2026-02-19".split(''));
  account = ComputeAccountBalance(sledger, accountName, from, to);

  accountStr = AccountToString(account);

  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)".split(''), failures);
}
function TestAccruals(failures){
  var ledger;
  var c, d;
  var transaction;
  var valid, success;
  var date, from, to;
  var account;
  var accountName, desc, accountStr, accountSummaryStr;
  var sledger;
  var amounts;
  var i;
  var assetsDef, liabilitiesDef, equitiesDef, incomeDef, expensesDef, accountDef;
  var a148, a150, a192, a290, a300, a600;
  var accountPlan;
  var balanceSheetRef;
  var html;
  var message;
  var balances;

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

  /* 1.8.1. Loans and receivables */
  /* 3.4.2. Deferred income and refund liabilities */
  /* 1.11.1. Cash */
  /* 1.8.1. Loans and receivables */
  /* 3.4.2. Deferred income and refund liabilities */
  /* 4.1.2 Services */
  /* 1.11.1. Cash */
  /* 1.7.1. Prepayments */
  /* 5.1.3. Services expense */
  /* 1.7.1. Prepayments */
  /* Transaction: Invoice sent */
  transaction = [];
  transaction.length = 2;
  date = DateFromStringISO8601("2025-09-17".split(''));
  transaction[0] = CreateLineFromScript(ledger, "Debit, 1.8.1, 125, x".split(''), date);
  transaction[1] = CreateLineFromScript(ledger, "Credit, 3.4.2, 125, x".split(''), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction);
  AssertTrue(valid, failures);

  /* Transaction: Invoice paid */
  transaction = [];
  transaction.length = 2;
  date = DateFromStringISO8601("2025-10-01".split(''));
  transaction[0] = CreateLineFromScript(ledger, "Debit, 1.11.1, 125, x".split(''), date);
  transaction[1] = CreateLineFromScript(ledger, "Credit, 1.8.1, 125, x".split(''), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction);
  AssertTrue(valid, failures);

  /* Transaction: Renewal paid */
  transaction = [];
  transaction.length = 2;
  date = DateFromStringISO8601("2025-11-08".split(''));
  transaction[0] = CreateLineFromScript(ledger, "Debit, 1.7.1, 112.50, x".split(''), date);
  transaction[1] = CreateLineFromScript(ledger, "Credit, 1.11.1, 112.50, x".split(''), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction);
  AssertTrue(valid, failures);

  /* Accruals income */
  from = DateFromStringISO8601("2025-12-06".split(''));
  to = DateFromStringISO8601("2026-12-05".split(''));
  AddMonthlyAccruals(ledger, from, to, 125, "3.4.2".split(''), "4.1.2".split(''));

  /* Accruals cost */
  from = DateFromStringISO8601("2025-12-06".split(''));
  to = DateFromStringISO8601("2026-12-05".split(''));
  AddMonthlyAccruals(ledger, from, to, 112.50, "5.1.3".split(''), "1.7.1".split(''));

  /* Compute */
  sledger = LedgerDynamicToStatic(ledger);

  from = DateFromStringISO8601("2027-01-01".split(''));
  to = DateFromStringISO8601("2027-01-01".split(''));

  account = ComputeAccountBalance(sledger, "5.1.3".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "4.1.2".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "1.8.1".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "3.4.2".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "1.11.1".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "1.7.1".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

  /*System.out.println(""); */
  /* In between */
  from = DateFromStringISO8601("2026-06-15".split(''));
  to = DateFromStringISO8601("2026-06-16".split(''));

  account = ComputeAccountBalance(sledger, "5.1.3".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "4.1.2".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "1.8.1".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "3.4.2".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "1.11.1".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)".split(''), failures);

  account = ComputeAccountBalance(sledger, "1.7.1".split(''), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, "1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)".split(''), failures);

  /* Balance Sheet: Snapshots a companys assets, liabilities, and equity at a specific point in time. */
  /* Income Statement (P&L): Shows revenue, expenses, and profit/loss over a period. */
  /* Cash Flow Statement: Tracks cash inflow and outflow from operating, investing, and financing activities. */
  /* Statement of Shareholders' Equity: Details changes in owner interest over time. */
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
        sledger.accountPlan = accountPlan */

  sledger.accountPlan = GetIFRSAccountPlan();

  to = DateFromStringISO8601("2026-02-16".split(''));
  balanceSheetRef = {};
  success = ComputeAccountBalances(sledger, 2, to, balanceSheetRef);
  accountSummaryStr = AccountBalancesToString(balanceSheetRef.data.structure);
  AssertTrue(success, failures);
  /*System.out.println(accountSummaryStr); */
  /* Compute monthly table */
  to = DateFromStringISO8601("2025-08-01".split(''));
  message = {};
  AddDaysToDate(to,  -1, message);
  balances = CreateArray();
  for(i = 0; i < 12 + 6; i = i + 1){
    AddDaysToDate(to, 1, message);
    AddMonthsToDate(to, 1);
    AddDaysToDate(to,  -1, message);

    balanceSheetRef = {};
    success = ComputeAccountBalances(sledger, 1, to, balanceSheetRef);

    if(success){
      AddStructToArray(balances, balanceSheetRef.data.structure);
    }
  }
  ComputeBalanceDiffs(sledger, balances);

  html = BalancesArrayToHTML(balances, true, false);

  /*StringToFile("x.html", html); */
  html = BalancesArrayToHTML(balances, false, true);

  /*StringToFile("x-diff.html", html); */
  html = BalancesArrayToHTML(balances, true, true);
}
function CreateBooleanReference(value){
  var ref;

  ref = {};
  ref.booleanValue = value;

  return ref;
}
function CreateBooleanArrayReference(value){
  var ref;

  ref = {};
  ref.booleanArray = value;

  return ref;
}
function CreateBooleanArrayReferenceLengthValue(lengthx, value){
  var ref;
  var i;

  ref = {};
  ref.booleanArray = [];
  ref.booleanArray.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    ref.booleanArray[i] = value;
  }

  return ref;
}
function FreeBooleanArrayReference(booleanArrayReference){
  delete(booleanArrayReference.booleanArray);
  delete(booleanArrayReference);
}
function CreateCharacterReference(value){
  var ref;

  ref = {};
  ref.characterValue = value;

  return ref;
}
function CreateNumberReference(value){
  var ref;

  ref = {};
  ref.numberValue = value;

  return ref;
}
function CreateNumberArrayReference(value){
  var ref;

  ref = {};
  ref.numberArray = value;

  return ref;
}
function CreateNumberArrayReferenceLengthValue(lengthx, value){
  var ref;
  var i;

  ref = {};
  ref.numberArray = [];
  ref.numberArray.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    ref.numberArray[i] = value;
  }

  return ref;
}
function FreeNumberArrayReference(numberArrayReference){
  delete(numberArrayReference.numberArray);
  delete(numberArrayReference);
}
function CreateStringReference(value){
  var ref;

  ref = {};
  ref.string = value;

  return ref;
}
function CreateStringReferenceLengthValue(lengthx, value){
  var ref;
  var i;

  ref = {};
  ref.string = [];
  ref.string.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    ref.string[i] = value;
  }

  return ref;
}
function FreeStringReference(stringReference){
  delete(stringReference.string);
  delete(stringReference);
}
function CreateStringArrayReference(strings){
  var ref;

  ref = {};
  ref.stringArray = strings;

  return ref;
}
function CreateStringArrayReferenceLengthValue(lengthx, value){
  var ref;
  var i;

  ref = {};
  ref.stringArray = [];
  ref.stringArray.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    ref.stringArray[i] = CreateStringReference(value);
  }

  return ref;
}
function FreeStringArrayReference(stringArrayReference){
  var i;

  for(i = 0; i < stringArrayReference.stringArray.length; i = i + 1){
    delete(stringArrayReference.stringArray[i]);
  }
  delete(stringArrayReference.stringArray);
  delete(stringArrayReference);
}
function CreateDate(year, month, day){
  var date;

  date = {};

  date.year = year;
  date.month = month;
  date.day = day;

  return date;
}
function IsLeapYearWithCheck(year, isLeapYearReference, message){
  var itIsLeapYear;
  var success;

  if(year >= 1752){
    success = true;
    itIsLeapYear = IsLeapYear(year);
  }else{
    success = false;
    itIsLeapYear = false;
    message.string = "Gregorian calendar was not in general use.".split('');
  }

  isLeapYearReference.booleanValue = itIsLeapYear;
  return success;
}
function IsLeapYear(year){
  var itIsLeapYear;

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
function DayToDateWithCheck(dayNr, dateReference, message){
  var date;
  var remainder;
  var success;

  if(dayNr >=  -79623){
    date = {};
    remainder = {};
    remainder.numberValue = dayNr + 79623;
    /* Days since 1752-01-01. Day 0: Thursday, 1970-01-01 */
    /* Find year. */
    date.year = GetYearFromDayNr(remainder.numberValue, remainder);

    /* Find month. */
    date.month = GetMonthFromDayNr(remainder.numberValue, date.year, remainder);

    /* Find day. */
    date.day = 1 + remainder.numberValue;

    dateReference.date = date;
    success = true;
  }else{
    success = false;
    message.string = "Gregorian calendar was not in general use before 1752.".split('');
  }

  return success;
}
function DayToDate(dayNr){
  var date;
  var success;
  var dateRef;
  var message;

  dateRef = {};
  message = {};

  success = DayToDateWithCheck(dayNr, dateRef, message);
  if(success){
    date = dateRef.date;
    delete(dateRef);
    FreeStringReference(message);
  }else{
    date = CreateDate(1970, 1, 1);
  }

  return date;
}
function GetMonthFromDayNrWithCheck(dayNr, year, monthReference, remainderReference, message){
  var month;
  var success;

  if(dayNr >=  -79623){
    month = GetMonthFromDayNr(dayNr, year, remainderReference);
    monthReference.numberValue = month;
    success = true;
  }else{
    success = false;
    message.string = "Gregorian calendar not in general use before 1752.".split('');
  }

  return success;
}
function GetMonthFromDayNr(dayNr, year, remainderReference){
  var daysInMonth;
  var done;
  var month;

  daysInMonth = GetDaysInMonth(year);
  done = false;
  month = 1;

  for(;  !done ; ){
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
function GetYearFromDayNrWithCheck(dayNr, yearReference, remainder, message){
  var success;
  var year;

  if(dayNr >= 0){
    success = true;
    year = GetYearFromDayNr(dayNr, remainder);
    yearReference.numberValue = year;
  }else{
    success = false;
    message.string = "Day number must be 0 or higher. 0 is 1752-01-01.".split('');
  }

  return success;
}
function GetYearFromDayNr(dayNr, remainder){
  var nrOfDays;
  var done;
  var year;

  done = false;
  year = 1752;

  for(;  !done ; ){
    if(IsLeapYear(year)){
      nrOfDays = 366;
    }else{
      nrOfDays = 365;
    }

    if(dayNr >= nrOfDays){
      /* First day is 0. */
      dayNr = dayNr - nrOfDays;
      year = year + 1;
    }else{
      done = true;
    }
  }
  remainder.numberValue = dayNr;

  return year;
}
function DaysBetweenDates(A, B){
  var daysA, daysB, daysBetween;

  daysA = DateToDays(A);
  daysB = DateToDays(B);

  daysBetween = daysB - daysA;

  return daysBetween;
}
function GetDaysInMonthWithCheck(year, daysInMonthReference, message){
  var daysInMonth;
  var success;
  var date;

  date = CreateDate(year, 1, 1);

  success = IsValidDate(date, message);
  if(success){
    daysInMonth = GetDaysInMonth(year);

    daysInMonthReference.numberArray = daysInMonth;
  }

  return success;
}
function GetDaysInMonth(year){
  var daysInMonth;

  daysInMonth = [];
  daysInMonth.length = 1 + 12;

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
function DateToDaysWithCheck(date, dayNumberReferenceReference, message){
  var days;
  var success;

  success = IsValidDate(date, message);
  if(success){
    days = DateToDays(date);
    dayNumberReferenceReference.numberValue = days;
  }

  return success;
}
function DateToDays(date){
  var days;

  /* Day 1752-01-01 */
  days =  -79623;

  days = days + DaysInYears(date.year);
  days = days + DaysInMonths(date.month, date.year);
  days = days + date.day - 1;

  return days;
}
function DateToWeekdayNumberWithCheck(date, weekDayNumberReference, message){
  var weekDay;
  var success;

  success = IsValidDate(date, message);
  if(success){
    weekDay = DateToWeekdayNumber(date);
    weekDayNumberReference.numberValue = weekDay;
  }

  return success;
}
function DateToWeekdayNumber(date){
  var days, weekDay;

  days = DateToDays(date);

  days = days + 79623;
  days = days + 5;

  weekDay = days%7 + 1;

  return weekDay;
}
function DateToWeeknumber(date, yearRef){
  var weekNumber, weekday, days, daysWeek1Start, weekdayNewYears;
  var week1Start, newyears;

  week1Start = CopyDate(date);

  week1Start.day = 1;
  week1Start.month = 1;
  weekday = DateToWeekdayNumber(week1Start);

  /* Set week1Start to the start of the Week 1. */
  /* If monday, week 1 begins on Jan. 1st */
  if(weekday == 1){
    week1Start.day = 1;
  }
  /* If tuesday, week 1 begins on Dec. 31st */
  if(weekday == 2){
    week1Start.year = week1Start.year - 1;
    week1Start.month = 12;
    week1Start.day = 31;
  }
  /* If wednesday, week 1 begins on Dec. 30th */
  if(weekday == 3){
    week1Start.year = week1Start.year - 1;
    week1Start.month = 12;
    week1Start.day = 30;
  }
  /* If thursday, week 1 begins on Dec. 29th */
  if(weekday == 4){
    week1Start.year = week1Start.year - 1;
    week1Start.month = 12;
    week1Start.day = 29;
  }
  /* If friday, week 1 begins on Jan. 4th */
  if(weekday == 5){
    week1Start.day = 4;
  }
  /* If saturday, week 1 begins on Jan. 3rd */
  if(weekday == 6){
    week1Start.day = 3;
  }
  /* If sunday, week 1 begins on Jan. 2nd */
  if(weekday == 7){
    week1Start.day = 2;
  }

  days = DateToDays(date);
  daysWeek1Start = DateToDays(week1Start);

  if(days >= daysWeek1Start){
    weekNumber = 1 + Math.floor((days - daysWeek1Start)/7);

    if(weekNumber >= 1 && weekNumber <= 52){
      /* Week is between 1 and 52 in the current year. */
      yearRef.numberValue = date.year;
    }else{
      /* Is week nr 53 or 1 next year? */
      newyears = CopyDate(date);
      newyears.month = 12;
      newyears.day = 31;
      weekdayNewYears = DateToWeekdayNumber(newyears);
      if(weekdayNewYears == 1 || weekdayNewYears == 2 || weekdayNewYears == 3){
        /* Week 1 next year. */
        weekNumber = 1;
        yearRef.numberValue = date.year + 1;
      }else{
        /* Week 53 */
        yearRef.numberValue = date.year;
      }
      delete(newyears);
    }
  }else{
    /* Week is in previous year. Either 52nd or 53rd. */
    newyears = CopyDate(date);
    newyears.month = 12;
    newyears.day = 31;
    newyears.year = date.year - 1;
    weekNumber = DateToWeeknumber(newyears, yearRef);
    delete(newyears);
  }

  delete(week1Start);

  return weekNumber;
}
function DaysInMonthsWithCheck(month, year, daysInMonthsReference, message){
  var days;
  var success;
  var date;

  date = CreateDate(year, month, 1);

  success = IsValidDate(date, message);
  if(success){
    days = DaysInMonths(month, year);

    daysInMonthsReference.numberValue = days;
  }

  return success;
}
function DaysInMonths(month, year){
  var daysInMonth;
  var days;
  var i;

  daysInMonth = GetDaysInMonth(year);

  days = 0;
  for(i = 1; i < month; i = i + 1){
    days = days + daysInMonth[i];
  }

  return days;
}
function DaysInYearsWithCheck(years, daysReference, message){
  var days;
  var success;
  var date;

  date = CreateDate(years, 1, 1);

  success = IsValidDate(date, message);
  if(success){
    days = DaysInYears(years);
    daysReference.numberValue = days;
  }

  return success;
}
function DaysInYears(years){
  var days;
  var i;
  var nrOfDays;

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
function IsValidDate(date, message){
  var valid;
  var daysInMonth;
  var daysInThisMonth;

  if(date.year >= 1752){
    if(date.month >= 1 && date.month <= 12){
      daysInMonth = GetDaysInMonth(date.year);
      daysInThisMonth = daysInMonth[date.month];
      if(date.day >= 1 && date.day <= daysInThisMonth){
        valid = true;
      }else{
        valid = false;
        message.string = "The month does not have the given day number.".split('');
      }
    }else{
      valid = false;
      message.string = "Month must be between 1 and 12, inclusive.".split('');
    }
  }else{
    valid = false;
    message.string = "Gregorian calendar was not in general use before 1752.".split('');
  }

  return valid;
}
function AddDaysToDate(date, days, message){
  var n;
  var success;
  var dateReference;
  var daysRef;

  daysRef = {};
  success = DateToDaysWithCheck(date, daysRef, message);

  if(success){
    n = daysRef.numberValue;
    n = n + days;

    dateReference = {};
    success = DayToDateWithCheck(n, dateReference, message);
    if(success){
      AssignDate(date, dateReference.date);
    }
  }

  return success;
}
function AssignDate(a, b){
  a.year = b.year;
  a.month = b.month;
  a.day = b.day;
}
function AddMonthsToDate(date, months){
  var i;

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
    for(i = 0; i <  -months; i = i + 1){
      date.month = date.month - 1;

      if(date.month == 0){
        date.month = 12;
        date.year = date.year - 1;
      }
    }
  }
}
function DateToStringISO8601WithCheck(date, datestr, message){
  var success;

  success = IsValidDate(date, message);

  if(success){
    if(date.year <= 9999){
      datestr.string = DateToStringISO8601(date);
    }else{
      message.string = "This library works from 1752 to 9999.".split('');
    }
  }

  return success;
}
function DateToStringISO8601(date){
  var str;

  str = [];
  str.length = 10;

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
function DateFromStringISO8601(str){
  var date;
  var n;

  date = {};

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
function DateFromStringISO8601WithCheck(str, dateRef, message){
  var valid;

  valid = IsValidDateISO8601(str, message);

  if(valid){
    dateRef.date = DateFromStringISO8601(str);
  }

  return valid;
}
function IsValidDateISO8601(str, message){
  var valid;

  if(str.length == 4 + 1 + 2 + 1 + 2){

    if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9])){
      if(str[4] == '-' && str[7] == '-'){
        valid = true;
      }else{
        valid = false;
        message.string = "ISO8601 date must use \'-\' in positions 5 and 8.".split('');
      }
    }else{
      valid = false;
      message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.".split('');
    }
  }else{
    valid = false;
    message.string = "ISO8601 date must be exactly 10 characters long.".split('');
  }

  return valid;
}
function DateEquals(a, b){
  return a.year == b.year && a.month == b.month && a.day == b.day;
}
function CopyDate(a){
  var b;

  b = CreateDate(a.year, a.month, a.day);

  return b;
}
function GetSecondsFromDate(date){
  var seconds, days, secondsInMinute, secondsInHour, secondsInDay;
  var dayNumberReferenceReference;
  var message;
  var success;

  seconds = 0;
  dayNumberReferenceReference = {};
  message = {};

  success = DateToDaysWithCheck(date, dayNumberReferenceReference, message);
  if(success){
    days = dayNumberReferenceReference.numberValue;

    secondsInMinute = 60;
    secondsInHour = 60*secondsInMinute;
    secondsInDay = 24*secondsInHour;

    seconds = seconds + secondsInDay*days;
  }

  delete(dayNumberReferenceReference);
  delete(message);

  return seconds;
}
function DateIsInInterval(interval, date){
  var from, to, day;

  from = DateToDays(interval.first);
  to = DateToDays(interval.last);
  day = DateToDays(date);

  return day >= from && day <= to;
}
function DateLessThan(a, b){
  var aDays, bDays;

  aDays = DateToDays(a);
  bDays = DateToDays(b);

  return aDays < bDays;
}
function CreateDateTimeTimezone(year, month, day, hours, minutes, seconds, timezoneOffsetSeconds){
  var dateTimeTimezone;

  dateTimeTimezone = {};

  dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
  dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

  return dateTimeTimezone;
}
function CreateDateTimeTimezoneInHoursAndMinutes(year, month, day, hours, minutes, seconds, timezoneOffsetHours, timezoneOffsetMinutes){
  var dateTimeTimezone;

  dateTimeTimezone = {};

  dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
  dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes);

  return dateTimeTimezone;
}
function GetDateFromDateTimeTimeZone(dateTimeTimezone, dateTimeReference, message){
  var dateTime;

  dateTime = dateTimeTimezone.dateTime;

  return AddSecondsToDateTimeWithCheck(dateTime,  -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message);
}
function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, timezoneOffsetSeconds, dateTimeTimezoneReference, message){
  var success;
  var adjustedDateTimeReference;
  var dateTimeTimezone;

  adjustedDateTimeReference = {};
  dateTimeTimezone = {};

  success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message);

  if(success){
    dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime;
    dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

    dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone;
  }

  return success;
}
function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(dateTime, timezoneOffsetHours, timezoneOffsetMinutes, dateTimeTimezoneReference, message){
  return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message);
}
function GetDateTimeTimezoneFromSeconds(dateTimeTzRef, seconds, offset, message){
  var success;
  var dateTimeRef;

  dateTimeRef = {};
  success = GetDateTimeFromSeconds(seconds, dateTimeRef, message);

  if(success){
    success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTime, offset, dateTimeTzRef, message);
  }

  return success;
}
function CreateDateTime(year, month, day, hours, minutes, seconds){
  var dateTime;

  dateTime = {};

  dateTime.date = CreateDate(year, month, day);
  dateTime.hours = hours;
  dateTime.minutes = minutes;
  dateTime.seconds = seconds;

  return dateTime;
}
function GetDateTimeFromSeconds(seconds, dateTimeReference, message){
  var dateTime;
  var secondsInMinute, secondsInHour, secondsInDay, days, remainder;
  var date;
  var dateReference;
  var success;

  secondsInMinute = 60;
  secondsInHour = 60*secondsInMinute;
  secondsInDay = 24*secondsInHour;
  days = Math.floor(seconds/secondsInDay);
  remainder = seconds - days*secondsInDay;
  dateReference = {};

  success = DayToDateWithCheck(days, dateReference, message);
  if(success){
    date = dateReference.date;

    dateTime = {};
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
function GetSecondsFromDateTime(dateTime){
  var seconds, secondsInMinute, secondsInHour;

  secondsInMinute = 60;
  secondsInHour = 60*secondsInMinute;

  seconds = GetSecondsFromDate(dateTime.date);
  seconds = seconds + secondsInHour*dateTime.hours;
  seconds = seconds + secondsInMinute*dateTime.minutes;
  seconds = seconds + dateTime.seconds;

  return seconds;
}
function GetSecondsFromMinutes(minutes){
  return minutes*60;
}
function GetSecondsFromHours(hours){
  return GetSecondsFromMinutes(hours*60);
}
function GetSecondsFromDays(days){
  return GetSecondsFromHours(days*24);
}
function GetSecondsFromWeeks(weeks){
  return GetSecondsFromDays(weeks*7);
}
function GetMinutesFromSeconds(seconds){
  return seconds/60;
}
function GetHoursFromSeconds(seconds){
  return GetMinutesFromSeconds(seconds)/60;
}
function GetDaysFromSeconds(seconds){
  return GetHoursFromSeconds(seconds)/24;
}
function GetWeeksFromSeconds(seconds){
  return GetDaysFromSeconds(seconds)/7;
}
function GetDateFromDateTime(dateTime){
  return dateTime.date;
}
function AddSecondsToDateTimeWithCheck(dateTime, seconds, dateTimeReference, message){
  var secondsInDateTime;
  var success;

  if(IsValidDateTime(dateTime, message)){
    secondsInDateTime = GetSecondsFromDateTime(dateTime);
    secondsInDateTime = secondsInDateTime + seconds;

    success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
  }else{
    success = false;
  }

  return success;
}
function AddSecondsToDateTime(dateTime, seconds, dateTimeReference, message){
  var secondsInDateTime;

  secondsInDateTime = GetSecondsFromDateTime(dateTime);
  secondsInDateTime = secondsInDateTime + seconds;

  return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
}
function AddMinutesToDateTime(dateTime, minutes, dateTimeReference, message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message);
}
function AddHoursToDateTime(dateTime, hours, dateTimeReference, message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message);
}
function AddDaysToDateTime(dateTime, days, dateTimeReference, message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message);
}
function AddWeeksToDateTime(dateTime, weeks, dateTimeReference, message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message);
}
function DateTimeToStringISO8601WithCheck(datetime, dateStr, message){
  var success;

  success = DateToStringISO8601WithCheck(datetime.date, dateStr, message);

  if(success){
    delete(dateStr.string);

    success = IsValidDateTime(datetime, message);
    if(success){
      dateStr.string = DateTimeToStringISO8601(datetime);
    }
  }

  return success;
}
function IsValidDateTime(datetime, message){
  var success;

  success = IsValidDate(datetime.date, message);

  if(success){
    if(datetime.hours <= 23 && datetime.hours >= 0){
      if(datetime.minutes <= 59 && datetime.minutes >= 0){
        if(datetime.seconds <= 59 && datetime.seconds >= 0){
          success = true;
        }else{
          success = false;
          message.string = "Seconds must be between 0 and 59.".split('');
        }
      }else{
        success = false;
        message.string = "Minutes must be between 0 and 59.".split('');
      }
    }else{
      success = false;
      message.string = "Hours must be between 0 and 23.".split('');
    }
  }

  return success;
}
function DateTimeToStringISO8601(datetime){
  var datestr, str;
  var i;

  str = [];
  str.length = 19;

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
function DateTimeFromStringISO8601(str){
  var dateTime;
  var n;

  dateTime = {};

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
function DateTimeFromStringISO8601WithCheck(str, dateTimeRef, message){
  var valid;

  valid = IsValidDateTimeISO8601(str, message);

  if(valid){
    dateTimeRef.dateTime = DateTimeFromStringISO8601(str);
  }

  return valid;
}
function IsValidDateTimeISO8601(str, message){
  var valid;

  if(str.length == 4 + 1 + 2 + 1 + 2 + 1 + 2 + 1 + 2 + 1 + 2){

    if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9]) && cIsNumber(str[11]) && cIsNumber(str[12]) && cIsNumber(str[14]) && cIsNumber(str[15]) && cIsNumber(str[17]) && cIsNumber(str[18])){
      if(str[4] == '-' && str[7] == '-' && str[10] == 'T' && str[13] == ':' && str[16] == ':'){
        valid = true;
      }else{
        valid = false;
        message.string = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.".split('');
      }
    }else{
      valid = false;
      message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.".split('');
    }
  }else{
    valid = false;
    message.string = "ISO8601 date must be exactly 19 characters long.".split('');
  }

  return valid;
}
function DateTimeEquals(a, b){
  return DateEquals(a.date, b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds;
}
function FreeDateTime(datetime){
  delete(datetime.date);
  delete(datetime);
}
function CreateFixedPoint30d(digitsBeforeDecimalPoint, digitsAfterDecimalPoint){
  var fp;

  fp = {};
  fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
  fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
  fp.part1 = 0;
  fp.part2 = 0;

  return fp;
}
function CreateFixedPoint15d(digitsBeforeDecimalPoint, digitsAfterDecimalPoint){
  var fp;

  fp = {};
  fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
  fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
  fp.number = 0;

  return fp;
}
function ToNumber15d(n){
  return n.number;
}
function Number15d(number){
  var fp;

  fp = {};
  fp.digitsBeforeDecimalPoint = 7;
  fp.digitsAfterDecimalPoint = 7;
  fp.number = number;

  return fp;
}
function Assign15d(fp, number){
  var success;

  success =  !WillOverflow15d(fp, number) ;
  success = success && FixedPointIsValid15d(fp);

  if(success){
    fp.number = number;
    fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint);
  }

  return success;
}
function Assign15dFloor(fp, number){
  var success;

  success =  !WillOverflow15d(fp, number) ;
  success = success && FixedPointIsValid15d(fp);

  if(success){
    fp.number = number;
    fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint);
  }

  return success;
}
function FixedPointIsValid15d(fp){
  var valid;

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
function WillOverflow15d(fp, number){
  var overflow;

  if(Math.abs(number) < 10**fp.digitsBeforeDecimalPoint){
    overflow = false;
  }else{
    overflow = true;
  }

  return overflow;
}
function FloorToDigits(value, digits){
  return Math.floor(value*10**digits)/10**digits;
}
function ToString15d(fp){
  var string;
  var digits;
  var digitPosition;
  var i, d, decimal;
  var characterReference;

  string = [];
  string.length = 1 + fp.digitsBeforeDecimalPoint + 1 + fp.digitsAfterDecimalPoint;

  decimal = fp.number*10**fp.digitsAfterDecimalPoint;

  if(decimal < 0){
    decimal =  -decimal;
    string[0] = '-';
  }else{
    string[0] = '+';
  }

  decimal = Round(decimal);

  characterReference = {};

  digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint;
  digitPosition = 1;

  for(i = 0; i < digits; i = i + 1){
    if(i == fp.digitsBeforeDecimalPoint){
      string[digitPosition] = '.';

      digitPosition = digitPosition + 1;
    }

    d = Math.floor(decimal/10**(digits - i - 1));
    d = d%10;

    GetSingleDigitCharacterFromNumberWithCheck(d, 10, characterReference);
    string[digitPosition] = characterReference.characterValue;

    digitPosition = digitPosition + 1;
  }

  delete(characterReference);

  return string;
}
function Add15d(a, b, c){
  return Assign15d(a, b.number + c.number);
}
function Subtract15d(a, b, c){
  return Assign15d(a, b.number - c.number);
}
function Multiply15d(a, b, c){
  return Assign15d(a, b.number*c.number);
}
function DivideFloored15d(q, r, a, b){
  var success;
  var x, xDivisor, xDividend;
  var t;

  t = Copy15d(r);

  if(b.number != 0){
    xDivisor = Round(a.number*10**q.digitsAfterDecimalPoint*10**q.digitsAfterDecimalPoint);
    xDividend = Round(b.number*10**q.digitsAfterDecimalPoint);
    x = Math.floor(xDivisor/xDividend);
    x = x/10**q.digitsAfterDecimalPoint;
    success = Assign15d(q, x);
    Multiply15d(t, q, b);
    Subtract15d(r, a, t);
  }else{
    success = false;
  }

  delete(t);

  return success;
}
function Copy15d(r){
  var t;

  t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint);
  t.number = r.number;

  return t;
}
function Negate15d(a){
  a.number =  -a.number;
}
function Positive15d(a){
  a.number =  +a.number;
}
function Factorial15d(x){
  var success;

  if(x.number >= 0){
    success = Assign15d(x, Factorial(x.number));
  }else{
    success = false;
  }

  return success;
}
function Round15d(x){
  return Assign15d(x, Round(x.number));
}
function BankersRound15d(x){
  return Assign15d(x, BankersRound(x.number));
}
function Ceil15d(x){
  return Assign15d(x, Ceil(x.number));
}
function Floor15d(x){
  return Assign15d(x, Math.floor(x.number));
}
function Truncate15d(x){
  x.number = Truncate(x.number);
}
function Absolute15d(x){
  x.number = Math.abs(x.number);
}
function Logarithm15d(x){
  var success;

  if(x.number > 0){
    success = Assign15d(x, Logarithm(x.number));
  }else{
    success = false;
  }

  return success;
}
function NaturalLogarithm15d(x){
  var success;

  if(x.number > 0){
    success = Assign15d(x, NaturalLogarithm(x.number));
  }else{
    success = false;
  }

  return success;
}
function Sin15d(x){
  return Assign15d(x, Sin(x.number));
}
function Cos15d(x){
  return Assign15d(x, Cos(x.number));
}
function Tan15d(x){
  return Assign15d(x, Tan(x.number));
}
function Asin15d(x){
  var success;

  if(x.number >=  -1 && x.number <= 1){
    success = Assign15d(x, Asin(x.number));
  }else{
    success = false;
  }

  return success;
}
function Acos15d(x){
  var success;

  if(x.number >=  -1 && x.number <= 1){
    success = Assign15d(x, Acos(x.number));
  }else{
    success = false;
  }

  return success;
}
function Atan15d(x){
  return Assign15d(x, Atan(x.number));
}
function Atan2_15d(a, y, x){
  return Assign15d(a, Atan2(y.number, x.number));
}
function Squareroot15d(x){
  var success;

  if(x.number >= 0){
    success = Assign15d(x, Math.sqrt(x.number));
  }else{
    success = false;
  }

  return success;
}
function Exp15d(x){
  return Assign15d(x, Exp(x.number));
}
function DivisibleBy15d(a, b){
  return ((a.number%b.number) == 0);
}
function Combinations15d(x, n, k){
  var success;

  if(IsInteger(n.number) && IsInteger(k.number)){
    if(n.number >= 1 && k.number >= 0 && n.number >= k.number){
      success = Assign15d(x, Combinations(n.number, k.number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
function Permutations15d(x, n, k){
  var success;

  if(IsInteger(n.number) && IsInteger(k.number)){
    if(n.number >= 1 && k.number >= 0 && n.number >= k.number){
      success = Assign15d(x, Permutations(n.number, k.number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
function Equals15d(a, b){
  var p, an, bn;
  var equals;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  p = Math.max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint);

  equals = EpsilonCompare(an, bn, 10**( -p));

  return equals;
}
function GreaterThan15d(a, b){
  var an, bn;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  return an > bn;
}
function LessThan15d(a, b){
  var an, bn;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  return an < bn;
}
function GreaterThanOrEqual15d(a, b){
  var an, bn;
  var equal;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  equal = Equals15d(a, b);

  return an > bn || equal;
}
function LessThanOrEqual15d(a, b){
  var an, bn;
  var equal;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  equal = Equals15d(a, b);

  return an < bn || equal;
}
function EpsilonCompare15d(a, b, epsilon){
  return EpsilonCompare(a.number, b.number, epsilon.number);
}
function GreatestCommonDivisor15d(x, a, b){
  var success;

  if(IsInteger(a.number) && IsInteger(b.number)){
    if(a.number >= 0 && b.number >= 0){
      success = Assign15d(x, GreatestCommonDivisor(a.number, b.number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
function GCDWithSubtraction15d(x, a, b){
  var success;

  if(IsInteger(a.number) && IsInteger(b.number)){
    if(a.number >= 0 && b.number >= 0){
      success = Assign15d(x, GCDWithSubtraction(a.number, b.number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
function IsInteger15d(a){
  return IsInteger(a.number);
}
function LeastCommonMultiple15d(x, a, b){
  var success;

  if(IsInteger(a.number) && IsInteger(b.number)){
    if(a.number != 0 && b.number != 0){
      success = Assign15d(x, LeastCommonMultiple(a.number, b.number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
function Sign15d(a){
  return Sign(a.number);
}
function Max15d(x, a, b){
  return Assign15d(x, Max(a.number, b.number));
}
function Min15d(x, a, b){
  return Assign15d(x, Min(a.number, b.number));
}
function Power15d(x, a, b){
  var success;

  if(a.number != 0 || b.number != 0){
    if( !(a.number < 0 &&  !IsInteger(b.number) ) ){
      success = Assign15d(x, Power(a.number, b.number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
function FormatToString15d(fp, digitsAfter){
  var result;

  result = FormatToStringWithSymbols15d(fp, digitsAfter, "".split(''), ".".split(''));

  return result;
}
function FormatToStringWithSymbols15d(fp, digitsAfter, thousandsSeparator, decimalPoint){
  var string;
  var i, j, p, d, t, sign, extra, decimal, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars;
  var characterReference;

  characterReference = {};

  decimal = Round(fp.number*10**digitsAfter);

  sign = 0;
  if(decimal < 0){
    sign = 1;
    decimal =  -decimal;
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

  string = [];
  string.length = sign + digits + thousandsChars + decimalPointChars;
  p = 0;

  if(sign > 0){
    string[p] = '-';
    p = p + 1;
  }

  for(i = 0; i < digits; i = i + 1){
    if(i == digitsBefore){
      if(i == 0){
        string[p] = '0';
        p = p + 1;
        digits = digits - 1;
      }

      for(j = 0; j < decimalPoint.length; j = j + 1){
        string[p] = decimalPoint[j];
        p = p + 1;
      }
    }

    if(i < digitsBefore){
      if((digitsBefore - i)%3 == 0 && i != 0){
        for(j = 0; j < thousandsSeparator.length; j = j + 1){
          string[p] = thousandsSeparator[j];
          p = p + 1;
        }
      }
    }

    d = Math.floor(decimal/10**(digits - i - 1));
    d = d%10;

    GetSingleDigitCharacterFromNumberWithCheck(d, 10, characterReference);
    string[p] = characterReference.characterValue;

    p = p + 1;
  }

  /* System.out.println(new String(string)); */
  return string;
}
function NumberToHumanReadable(n, digitsAfter, thousandsSeparator, decimalPoint){
  var str;
  var u;
  var d, p3;

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
function NumberToHumanReadableBinaryPrefix(n, digitsAfter, thousandsSeparator, decimalPoint){
  var str;
  var u;
  var d, p3;

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
function AddNumber(list, a){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length + 1;
  for(i = 0; i < list.length; i = i + 1){
    newlist[i] = list[i];
  }
  newlist[list.length] = a;
		
  delete(list);
		
  return newlist;
}
function AddNumberRef(list, i){
  list.numberArray = AddNumber(list.numberArray, i);
}
function RemoveNumber(list, n){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length - 1;

  if(n >= 0 && n < list.length){
    for(i = 0; i < list.length; i = i + 1){
      if(i < n){
        newlist[i] = list[i];
      }
      if(i > n){
        newlist[i - 1] = list[i];
      }
    }

    delete(list);
  }else{
    delete(newlist);
  }
		
  return newlist;
}
function GetNumberRef(list, i){
  return list.numberArray[i];
}
function RemoveNumberRef(list, i){
  list.numberArray = RemoveNumber(list.numberArray, i);
}
function AddString(list, a){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length + 1;

  for(i = 0; i < list.length; i = i + 1){
    newlist[i] = list[i];
  }
  newlist[list.length] = a;
		
  delete(list);
		
  return newlist;
}
function AddStringRef(list, i){
  list.stringArray = AddString(list.stringArray, i);
}
function RemoveString(list, n){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length - 1;

  if(n >= 0 && n < list.length){
    for(i = 0; i < list.length; i = i + 1){
      if(i < n){
        newlist[i] = list[i];
      }
      if(i > n){
        newlist[i - 1] = list[i];
      }
    }

    delete(list);
  }else{
    delete(newlist);
  }
		
  return newlist;
}
function GetStringRef(list, i){
  return list.stringArray[i];
}
function RemoveStringRef(list, i){
  list.stringArray = RemoveString(list.stringArray, i);
}
function CreateDynamicArrayCharacters(){
  var da;

  da = {};
  da.array = [];
  da.array.length = 10;
  da.lengthx = 0;

  return da;
}
function CreateDynamicArrayCharactersWithInitialCapacity(capacity){
  var da;

  da = {};
  da.array = [];
  da.array.length = capacity;
  da.lengthx = 0;

  return da;
}
function DynamicArrayAddCharacter(da, value){
  if(da.lengthx == da.array.length){
    DynamicArrayCharactersIncreaseSize(da);
  }

  da.array[da.lengthx] = value;
  da.lengthx = da.lengthx + 1;
}
function DynamicArrayAddString(da, str){
  var i;

  for(i = 0; i < str.length; i = i + 1){
    DynamicArrayAddCharacter(da, str[i]);
  }
}
function DynamicArrayCharactersIncreaseSize(da){
  var newLength, i;
  var newArray;

  newLength = Math.round(da.array.length*3/2);
  newArray = [];
  newArray.length = newLength;

  for(i = 0; i < da.array.length; i = i + 1){
    newArray[i] = da.array[i];
  }

  delete(da.array);

  da.array = newArray;
}
function DynamicArrayCharactersDecreaseSizeNecessary(da){
  var needsDecrease;

  needsDecrease = false;

  if(da.lengthx > 10){
    needsDecrease = da.lengthx <= Math.round(da.array.length*2/3);
  }

  return needsDecrease;
}
function DynamicArrayCharactersDecreaseSize(da){
  var newLength, i;
  var newArray;

  newLength = Math.round(da.array.length*2/3);
  newArray = [];
  newArray.length = newLength;

  for(i = 0; i < newLength; i = i + 1){
    newArray[i] = da.array[i];
  }

  delete(da.array);

  da.array = newArray;
}
function DynamicArrayCharactersIndex(da, index){
  return da.array[index];
}
function DynamicArrayCharactersLength(da){
  return da.lengthx;
}
function DynamicArrayInsertCharacter(da, index, value){
  var i;

  if(da.lengthx == da.array.length){
    DynamicArrayCharactersIncreaseSize(da);
  }

  for(i = da.lengthx; i > index; i = i - 1){
    da.array[i] = da.array[i - 1];
  }

  da.array[index] = value;

  da.lengthx = da.lengthx + 1;
}
function DynamicArrayCharacterSet(da, index, value){
  var success;

  if(index < da.lengthx){
    da.array[index] = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function DynamicArrayRemoveCharacter(da, index){
  var i;

  for(i = index; i < da.lengthx - 1; i = i + 1){
    da.array[i] = da.array[i + 1];
  }

  da.lengthx = da.lengthx - 1;

  if(DynamicArrayCharactersDecreaseSizeNecessary(da)){
    DynamicArrayCharactersDecreaseSize(da);
  }
}
function FreeDynamicArrayCharacters(da){
  delete(da.array);
  delete(da);
}
function DynamicArrayCharactersToArray(da){
  var array;
  var i;

  array = [];
  array.length = da.lengthx;

  for(i = 0; i < da.lengthx; i = i + 1){
    array[i] = da.array[i];
  }

  return array;
}
function ArrayToDynamicArrayCharactersWithOptimalSize(array){
  var da;
  var i;
  var c, n, newCapacity;

  c = array.length;
  n = (Math.log(c) - 1)/Math.log(3/2);
  newCapacity = Math.ceil(10*(3/2)**n);

  da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity);

  for(i = 0; i < array.length; i = i + 1){
    da.array[i] = array[i];
  }

  return da;
}
function ArrayToDynamicArrayCharacters(array){
  var da;

  da = {};
  da.array = arraysCopyString(array);
  da.lengthx = array.length;

  return da;
}
function DynamicArrayCharactersEqual(a, b){
  var equal;
  var i;

  equal = true;
  if(a.lengthx == b.lengthx){
    for(i = 0; i < a.lengthx && equal; i = i + 1){
      if(a.array[i] != b.array[i]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
function DynamicArrayCharactersToLinkedList(da){
  var ll;
  var i;

  ll = CreateLinkedListCharacter();

  for(i = 0; i < da.lengthx; i = i + 1){
    LinkedListAddCharacter(ll, da.array[i]);
  }

  return ll;
}
function LinkedListToDynamicArrayCharacters(ll){
  var da;
  var i;
  var node;

  node = ll.first;

  da = {};
  da.lengthx = LinkedListCharactersLength(ll);

  da.array = [];
  da.array.length = da.lengthx;

  for(i = 0; i < da.lengthx; i = i + 1){
    da.array[i] = node.value;
    node = node.next;
  }

  return da;
}
function AddBoolean(list, a){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length + 1;
  for(i = 0; i < list.length; i = i + 1){
    newlist[i] = list[i];
  }
  newlist[list.length] = a;
		
  delete(list);
		
  return newlist;
}
function AddBooleanRef(list, i){
  list.booleanArray = AddBoolean(list.booleanArray, i);
}
function RemoveBoolean(list, n){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length - 1;

  if(n >= 0 && n < list.length){
    for(i = 0; i < list.length; i = i + 1){
      if(i < n){
        newlist[i] = list[i];
      }
      if(i > n){
        newlist[i - 1] = list[i];
      }
    }

    delete(list);
  }else{
    delete(newlist);
  }
		
  return newlist;
}
function GetBooleanRef(list, i){
  return list.booleanArray[i];
}
function RemoveDecimalRef(list, i){
  list.booleanArray = RemoveBoolean(list.booleanArray, i);
}
function CreateLinkedListString(){
  var ll;

  ll = {};
  ll.first = {};
  ll.last = ll.first;
  ll.last.end = true;

  return ll;
}
function LinkedListAddString(ll, value){
  ll.last.end = false;
  ll.last.value = value;
  ll.last.next = {};
  ll.last.next.end = true;
  ll.last = ll.last.next;
}
function LinkedListStringsToArray(ll){
  var array;
  var lengthx, i;
  var node;

  node = ll.first;

  lengthx = LinkedListStringsLength(ll);

  array = [];
  array.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    array[i] = {};
    array[i].string = node.value;
    node = node.next;
  }

  return array;
}
function LinkedListStringsLength(ll){
  var l;
  var node;

  l = 0;
  node = ll.first;
  for(;  !node.end ; ){
    node = node.next;
    l = l + 1;
  }

  return l;
}
function FreeLinkedListString(ll){
  var node, prev;

  node = ll.first;

  for(;  !node.end ; ){
    prev = node;
    node = node.next;
    delete(prev);
  }

  delete(node);
}
function LinkedListInsertString(ll, index, value){
  var i;
  var node, tmp;

  if(index == 0){
    tmp = ll.first;
    ll.first = {};
    ll.first.next = tmp;
    ll.first.value = value;
    ll.first.end = false;
  }else{
    node = ll.first;
    for(i = 0; i < index - 1; i = i + 1){
      node = node.next;
    }

    tmp = node.next;
    node.next = {};
    node.next.next = tmp;
    node.next.value = value;
    node.next.end = false;
  }
}
function CreateLinkedListNumbers(){
  var ll;

  ll = {};
  ll.first = {};
  ll.last = ll.first;
  ll.last.end = true;

  return ll;
}
function CreateLinkedListNumbersArray(lengthx){
  var lls;
  var i;

  lls = [];
  lls.length = lengthx;
  for(i = 0; i < lls.length; i = i + 1){
    lls[i] = CreateLinkedListNumbers();
  }

  return lls;
}
function LinkedListAddNumber(ll, value){
  ll.last.end = false;
  ll.last.value = value;
  ll.last.next = {};
  ll.last.next.end = true;
  ll.last = ll.last.next;
}
function LinkedListNumbersLength(ll){
  var l;
  var node;

  l = 0;
  node = ll.first;
  for(;  !node.end ; ){
    node = node.next;
    l = l + 1;
  }

  return l;
}
function LinkedListNumbersIndex(ll, index){
  var i;
  var node;

  node = ll.first;
  for(i = 0; i < index; i = i + 1){
    node = node.next;
  }

  return node.value;
}
function LinkedListInsertNumber(ll, index, value){
  var i;
  var node, tmp;

  if(index == 0){
    tmp = ll.first;
    ll.first = {};
    ll.first.next = tmp;
    ll.first.value = value;
    ll.first.end = false;
  }else{
    node = ll.first;
    for(i = 0; i < index - 1; i = i + 1){
      node = node.next;
    }

    tmp = node.next;
    node.next = {};
    node.next.next = tmp;
    node.next.value = value;
    node.next.end = false;
  }
}
function LinkedListSet(ll, index, value){
  var i;
  var node;

  node = ll.first;
  for(i = 0; i < index; i = i + 1){
    node = node.next;
  }

  node.next.value = value;
}
function LinkedListRemoveNumber(ll, index){
  var i;
  var node, prev;

  node = ll.first;
  prev = ll.first;

  for(i = 0; i < index; i = i + 1){
    prev = node;
    node = node.next;
  }

  if(index == 0){
    ll.first = prev.next;
  }
  if( !prev.next.end ){
    prev.next = prev.next.next;
  }
}
function FreeLinkedListNumbers(ll){
  var node, prev;

  node = ll.first;

  for(;  !node.end ; ){
    prev = node;
    node = node.next;
    delete(prev);
  }

  delete(node);
}
function FreeLinkedListNumbersArray(lls){
  var i;

  for(i = 0; i < lls.length; i = i + 1){
    FreeLinkedListNumbers(lls[i]);
  }
  delete(lls);
}
function LinkedListNumbersToArray(ll){
  var array;
  var lengthx, i;
  var node;

  node = ll.first;

  lengthx = LinkedListNumbersLength(ll);

  array = [];
  array.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    array[i] = node.value;
    node = node.next;
  }

  return array;
}
function ArrayToLinkedListNumbers(array){
  var ll;
  var i;

  ll = CreateLinkedListNumbers();

  for(i = 0; i < array.length; i = i + 1){
    LinkedListAddNumber(ll, array[i]);
  }

  return ll;
}
function LinkedListNumbersEqual(a, b){
  var equal, done;
  var an, bn;

  an = a.first;
  bn = b.first;

  equal = true;
  done = false;
  for(; equal &&  !done ; ){
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
function CreateLinkedListCharacter(){
  var ll;

  ll = {};
  ll.first = {};
  ll.last = ll.first;
  ll.last.end = true;

  return ll;
}
function LinkedListAddCharacter(ll, value){
  ll.last.end = false;
  ll.last.value = value;
  ll.last.next = {};
  ll.last.next.end = true;
  ll.last = ll.last.next;
}
function LinkedListCharactersToArray(ll){
  var array;
  var lengthx, i;
  var node;

  node = ll.first;

  lengthx = LinkedListCharactersLength(ll);

  array = [];
  array.length = lengthx;

  for(i = 0; i < lengthx; i = i + 1){
    array[i] = node.value;
    node = node.next;
  }

  return array;
}
function LinkedListCharactersLength(ll){
  var l;
  var node;

  l = 0;
  node = ll.first;
  for(;  !node.end ; ){
    node = node.next;
    l = l + 1;
  }

  return l;
}
function FreeLinkedListCharacter(ll){
  var node, prev;

  node = ll.first;

  for(;  !node.end ; ){
    prev = node;
    node = node.next;
    delete(prev);
  }

  delete(node);
}
function LinkedListCharactersAddString(ll, str){
  var i;

  for(i = 0; i < str.length; i = i + 1){
    LinkedListAddCharacter(ll, str[i]);
  }
}
function LinkedListInsertCharacter(ll, index, value){
  var i;
  var node, tmp;

  if(index == 0){
    tmp = ll.first;
    ll.first = {};
    ll.first.next = tmp;
    ll.first.value = value;
    ll.first.end = false;
  }else{
    node = ll.first;
    for(i = 0; i < index - 1; i = i + 1){
      node = node.next;
    }

    tmp = node.next;
    node.next = {};
    node.next.next = tmp;
    node.next.value = value;
    node.next.end = false;
  }
}
function CreateDynamicArrayNumbers(){
  var da;

  da = {};
  da.array = [];
  da.array.length = 10;
  da.lengthx = 0;

  return da;
}
function CreateDynamicArrayNumbersWithInitialCapacity(capacity){
  var da;

  da = {};
  da.array = [];
  da.array.length = capacity;
  da.lengthx = 0;

  return da;
}
function DynamicArrayAddNumber(da, value){
  if(da.lengthx == da.array.length){
    DynamicArrayNumbersIncreaseSize(da);
  }

  da.array[da.lengthx] = value;
  da.lengthx = da.lengthx + 1;
}
function DynamicArrayNumbersIncreaseSize(da){
  var newLength, i;
  var newArray;

  newLength = Math.round(da.array.length*3/2);
  newArray = [];
  newArray.length = newLength;

  for(i = 0; i < da.array.length; i = i + 1){
    newArray[i] = da.array[i];
  }

  delete(da.array);

  da.array = newArray;
}
function DynamicArrayNumbersDecreaseSizeNecessary(da){
  var needsDecrease;

  needsDecrease = false;

  if(da.lengthx > 10){
    needsDecrease = da.lengthx <= Math.round(da.array.length*2/3);
  }

  return needsDecrease;
}
function DynamicArrayNumbersDecreaseSize(da){
  var newLength, i;
  var newArray;

  newLength = Math.round(da.array.length*2/3);
  newArray = [];
  newArray.length = newLength;

  for(i = 0; i < newLength; i = i + 1){
    newArray[i] = da.array[i];
  }

  delete(da.array);

  da.array = newArray;
}
function DynamicArrayNumbersIndex(da, index){
  return da.array[index];
}
function DynamicArrayNumbersLength(da){
  return da.lengthx;
}
function DynamicArrayInsertNumber(da, index, value){
  var i;

  if(da.lengthx == da.array.length){
    DynamicArrayNumbersIncreaseSize(da);
  }

  for(i = da.lengthx; i > index; i = i - 1){
    da.array[i] = da.array[i - 1];
  }

  da.array[index] = value;

  da.lengthx = da.lengthx + 1;
}
function DynamicArrayNumberSet(da, index, value){
  var success;

  if(index < da.lengthx){
    da.array[index] = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function DynamicArrayRemoveNumber(da, index){
  var i;

  for(i = index; i < da.lengthx - 1; i = i + 1){
    da.array[i] = da.array[i + 1];
  }

  da.lengthx = da.lengthx - 1;

  if(DynamicArrayNumbersDecreaseSizeNecessary(da)){
    DynamicArrayNumbersDecreaseSize(da);
  }
}
function FreeDynamicArrayNumbers(da){
  delete(da.array);
  delete(da);
}
function DynamicArrayNumbersToArray(da){
  var array;
  var i;

  array = [];
  array.length = da.lengthx;

  for(i = 0; i < da.lengthx; i = i + 1){
    array[i] = da.array[i];
  }

  return array;
}
function ArrayToDynamicArrayNumbersWithOptimalSize(array){
  var da;
  var i;
  var c, n, newCapacity;

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
function ArrayToDynamicArrayNumbers(array){
  var da;

  da = {};
  da.array = arraysCopyNumberArray(array);
  da.lengthx = array.length;

  return da;
}
function DynamicArrayNumbersEqual(a, b){
  var equal;
  var i;

  equal = true;
  if(a.lengthx == b.lengthx){
    for(i = 0; i < a.lengthx && equal; i = i + 1){
      if(a.array[i] != b.array[i]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
function DynamicArrayNumbersToLinkedList(da){
  var ll;
  var i;

  ll = CreateLinkedListNumbers();

  for(i = 0; i < da.lengthx; i = i + 1){
    LinkedListAddNumber(ll, da.array[i]);
  }

  return ll;
}
function LinkedListToDynamicArrayNumbers(ll){
  var da;
  var i;
  var node;

  node = ll.first;

  da = {};
  da.lengthx = LinkedListNumbersLength(ll);

  da.array = [];
  da.array.length = da.lengthx;

  for(i = 0; i < da.lengthx; i = i + 1){
    da.array[i] = node.value;
    node = node.next;
  }

  return da;
}
function DynamicArrayNumbersIndexOf(arr, n, foundReference){
  var found;
  var i;

  found = false;
  for(i = 0; i < arr.lengthx &&  !found ; i = i + 1){
    if(arr.array[i] == n){
      found = true;
    }
  }
  if( !found ){
    i =  -1;
  }else{
    i = i - 1;
  }

  foundReference.booleanValue = found;

  return i;
}
function DynamicArrayNumbersIsInArray(arr, n){
  var found;
  var i;

  found = false;
  for(i = 0; i < arr.lengthx &&  !found ; i = i + 1){
    if(arr.array[i] == n){
      found = true;
    }
  }

  return found;
}
function AddCharacter(list, a){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length + 1;
  for(i = 0; i < list.length; i = i + 1){
    newlist[i] = list[i];
  }
  newlist[list.length] = a;
		
  delete(list);
		
  return newlist;
}
function AddCharacterRef(list, i){
  list.string = AddCharacter(list.string, i);
}
function RemoveCharacter(list, n){
  var newlist;
  var i;

  newlist = [];
  newlist.length = list.length - 1;

  if(n >= 0 && n < list.length){
    for(i = 0; i < list.length; i = i + 1){
      if(i < n){
        newlist[i] = list[i];
      }
      if(i > n){
        newlist[i - 1] = list[i];
      }
    }

    delete(list);
  }else{
    delete(newlist);
  }

  return newlist;
}
function GetCharacterRef(list, i){
  return list.string[i];
}
function RemoveCharacterRef(list, i){
  list.string = RemoveCharacter(list.string, i);
}
function GetAccrualAmount(total, fromYear, fromMonth, fromDay, toYear, toMonth, toDay, yearOfInterest, monthOfInterest){
  var from, to;
  var amount;

  from = CreateDate(fromYear, fromMonth, fromDay);
  to = CreateDate(toYear, toMonth, toDay);

  amount = GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest);

  return amount;
}
function GetAccruals(total, fromYear, fromMonth, fromDay, toYear, toMonth, toDay){
  var from, to;
  var amounts;

  from = CreateDate(fromYear, fromMonth, fromDay);
  to = CreateDate(toYear, toMonth, toDay);

  amounts = GetAccrualsWithDates(total, from, to);

  return amounts;
}
function GetAccrualsWithDates(total, from, to){
  var entry;
  var done;
  var dateOfInterest;
  var list;
  var result;

  list = CreateLinkedListNumbers();

  done = false;
  dateOfInterest = {};
  AssignDate(dateOfInterest, from);
  for(;  !done ; ){
    if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
      done = true;
    }

    entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest.year, dateOfInterest.month);
    LinkedListAddNumber(list, entry);
    AddMonthsToDate(dateOfInterest, 1);
  }

  result = LinkedListNumbersToArray(list);
  FreeLinkedListNumbers(list);

  return result;
}
function GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest){
  var unadjustedAmount, adjustment, days, daysToAdjust, n;
  var adjustTo;
  var valuePerDay, divisibleRemaining, divisibleTotal, amount;
  var message;

  message = {};

  valuePerDay = CreateFixedPoint15d(13, 2);
  divisibleRemaining = CreateFixedPoint15d(13, 2);
  divisibleTotal = CreateFixedPoint15d(13, 2);
  amount = CreateFixedPoint15d(13, 2);

  days = DaysBetweenDates(from, to) + 1;

  /* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining */
  DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days));

  Multiply15d(divisibleTotal, valuePerDay, Number15d(days));
  unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, from, to, yearOfInterest, monthOfInterest);

  if( !Equals15d(divisibleRemaining, Number15d(0)) ){
    daysToAdjust = Round(ToNumber15d(divisibleRemaining)*100);
    adjustTo = {};
    AssignDate(adjustTo, from);
    AddDaysToDate(adjustTo, daysToAdjust - 1, message);

    adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest);

    delete(adjustTo);
  }else{
    adjustment = 0;
  }

  Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment));

  n = ToNumber15d(amount);

  delete(valuePerDay);
  delete(divisibleRemaining);
  delete(divisibleTotal);
  delete(amount);

  return n;
}
function GetUnadjustedAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest){
  var days, daysInMonthOfInterest, n;
  var lastDayInMonth, firstDateInMonth;
  var daysInMonth;
  var valuePerDay, value, remainder;
  var success;

  value = CreateFixedPoint15d(13, 2);
  valuePerDay = CreateFixedPoint15d(13, 2);
  remainder = CreateFixedPoint15d(13, 2);

  days = DaysBetweenDates(from, to) + 1;
  /* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ... */
  success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days));

  if(success){
    daysInMonth = GetDaysInMonth(yearOfInterest);

    if(yearOfInterest < from.year){
      Assign15d(value, 0);
    }else if(yearOfInterest == from.year && monthOfInterest < from.month){
      Assign15d(value, 0);
    }else if(yearOfInterest > to.year){
      Assign15d(value, 0);
    }else if(yearOfInterest == to.year && monthOfInterest > to.month){
      Assign15d(value, 0);
    }else{
if(from.year == yearOfInterest && from.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest){
        daysInMonthOfInterest = days;
      }else if(from.year == yearOfInterest && from.month == monthOfInterest){
        lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[monthOfInterest]);
        daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1;
      }else if(to.year == yearOfInterest && to.month == monthOfInterest){
        firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1);
        daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1;
      }else{
        daysInMonthOfInterest = daysInMonth[monthOfInterest];
      }

      /* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value */
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
function CreateNewArrayData(){
  var data;

  data = {};
  data.isArray = true;
  data.isStruture = false;
  data.isNumber = false;
  data.isBoolean = false;
  data.isString = false;
  data.array = CreateArray();

  return data;
}
function CreateNewStructData(){
  var data;

  data = {};
  data.isStruture = true;
  data.isArray = false;
  data.isNumber = false;
  data.isBoolean = false;
  data.isString = false;
  data.structure = CreateStructure();

  return data;
}
function CreateStructure(){
  var st;

  st = {};
  st.keys = CreateArray();
  st.values = CreateArray();

  return st;
}
function CreateNumberData(n){
  var data;

  data = {};
  data.isNumber = true;
  data.isStruture = false;
  data.isArray = false;
  data.isBoolean = false;
  data.isString = false;
  data.number = n;

  return data;
}
function CreateBooleanData(b){
  var data;

  data = {};
  data.isBoolean = true;
  data.isStruture = false;
  data.isArray = false;
  data.isNumber = false;
  data.isString = false;
  data.booleanx = b;

  return data;
}
function CreateStringData(string){
  var data;

  data = {};
  data.isString = true;
  data.isStruture = false;
  data.isArray = false;
  data.isNumber = false;
  data.isBoolean = false;
  data.string = string;

  return data;
}
function CreateStructData(structure){
  var data;

  data = {};
  data.isString = false;
  data.isStruture = true;
  data.isArray = false;
  data.isNumber = false;
  data.isBoolean = false;
  data.structure = structure;

  return data;
}
function CreateArrayData(array){
  var data;

  data = {};
  data.isString = false;
  data.isStruture = false;
  data.isArray = true;
  data.isNumber = false;
  data.isBoolean = false;
  data.array = array;

  return data;
}
function CreateNoTypeData(){
  var data;

  data = {};
  data.isStruture = false;
  data.isArray = false;
  data.isNumber = false;
  data.isBoolean = false;
  data.isString = false;

  return data;
}
function AddStructToArray(ar, st){
  var data;

  data = CreateNewStructData();
  delete(data.structure);
  data.structure = st;

  ArrayAdd(ar, data);
}
function AddArrayToArray(ar, ar2){
  var data;

  data = CreateNewArrayData();
  delete(data.array);
  data.array = ar2;

  ArrayAdd(ar, data);
}
function AddNumberToArray(ar, n){
  ArrayAdd(ar, CreateNumberData(n));
}
function AddBooleanToArray(ar, b){
  ArrayAdd(ar, CreateBooleanData(b));
}
function AddStringToArray(ar, str){
  ArrayAdd(ar, CreateStringData(str));
}
function AddDataToArray(ar, data){
  ArrayAdd(ar, data);
}
function StructKeys(st){
  return ArrayLength(st.keys);
}
function StructHasKey(st, key){
  var i;
  var hasKey;

  hasKey = false;
  for(i = 0; i < StructKeys(st); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      hasKey = true;
    }
  }

  return hasKey;
}
function StructKeyIndex(st, key){
  var i;
  var index;

  index =  -1;
  for(i = 0; i < StructKeys(st); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      index = i;
    }
  }

  return index;
}
function GetStructKeys(st){
  var keys;
  var nr, i;

  nr = StructKeys(st);

  keys = [];
  keys.length = nr;

  for(i = 0; i < nr; i = i + 1){
    keys[i] = {};
    keys[i].string = arraysCopyString(st.keys.array[i].string);
  }

  return keys;
}
function GetStructFromStruct(st, key){
  var i;
  var r;

  r = {};
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      r = st.values.array[i].structure;
    }
  }

  return r;
}
function GetArrayFromStruct(st, key){
  var i;
  var r;

  r = {};
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      r = st.values.array[i].array;
    }
  }

  return r;
}
function GetNumberFromStruct(st, key){
  var i, r;

  r = 0;
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      r = st.values.array[i].number;
    }
  }

  return r;
}
function GetBooleanFromStruct(st, key){
  var i;
  var r;

  r = false;
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      r = st.values.array[i].booleanx;
    }
  }

  return r;
}
function GetStringFromStruct(st, key){
  var i;
  var r;

  r = "".split('');
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      r = st.values.array[i].string;
    }
  }

  return r;
}
function GetDataFromStruct(st, key){
  var i;
  var r;

  r = {};
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      delete(r);
      r = st.values.array[i];
    }
  }

  return r;
}
function GetDataFromStructWithCheck(st, key, foundRef){
  var i;
  var r;

  r = {};
  foundRef.booleanValue = false;
  for(i = 0; i < ArrayLength(st.keys); i = i + 1){
    if(arraysStringsEqual(st.keys.array[i].string, key)){
      delete(r);
      foundRef.booleanValue = true;
      r = st.values.array[i];
    }
  }

  return r;
}
function AddStructToStruct(st, key, struct){
  var i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    delete(st.values.array[i].structure);
    st.values.array[i].structure = struct;
  }else{
    AddStringToArray(st.keys, key);
    AddStructToArray(st.values, struct);
  }
}
function AddArrayToStruct(st, key, ar){
  var i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    delete(st.values.array[i].array);
    st.values.array[i].array = ar;
  }else{
    AddStringToArray(st.keys, key);
    AddArrayToArray(st.values, ar);
  }
}
function AddNumberToStruct(st, key, n){
  var i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    st.values.array[i].number = n;
  }else{
    AddStringToArray(st.keys, key);
    AddNumberToArray(st.values, n);
  }
}
function AddBooleanToStruct(st, key, b){
  var i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    st.values.array[i].booleanx = b;
  }else{
    AddStringToArray(st.keys, key);
    AddBooleanToArray(st.values, b);
  }
}
function AddStringToStruct(st, key, value){
  var i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    delete(st.values.array[i].string);
    st.values.array[i].string = value;
  }else{
    AddStringToArray(st.keys, key);
    AddStringToArray(st.values, value);
  }
}
function AddDataToStruct(st, key, data){
  var i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    FreeData(st.values.array[i]);
    st.values.array[i] = data;
  }else{
    AddStringToArray(st.keys, key);
    AddDataToArray(st.values, data);
  }
}
function FreeData(data){
  var i;
  var st;

  if(data.isStruture){
    st = data.structure;
    for(i = 0; i < StructKeys(st); i = i + 1){
      FreeData(ArrayIndex(st.keys, i));
      FreeData(ArrayIndex(st.values, i));
    }
    delete(st);
  }else if(data.isArray){
    FreeArray(data.array);
  }

  delete(data);
}
function FreeArray(array){
  var i;

  for(i = 0; i < ArrayLength(array); i = i + 1){
    FreeData(array.array[i]);
  }

  delete(array.array);
  delete(array);
}
function DataTypeEquals(a, b){
  var equal;

  equal = true;
  equal = equal && a.isStruture == b.isStruture;
  equal = equal && a.isArray == b.isArray;
  equal = equal && a.isNumber == b.isNumber;
  equal = equal && a.isBoolean == b.isBoolean;
  equal = equal && a.isString == b.isString;

  return equal;
}
function IsStructure(a){
  var itis;

  itis = a.isStruture;
  if(a.isArray || a.isNumber || a.isBoolean || a.isString){
    itis = false;
  }

  return itis;
}
function IsArray(a){
  var itis;

  itis = a.isArray;
  if(a.isStruture || a.isNumber || a.isBoolean || a.isString){
    itis = false;
  }

  return itis;
}
function IsNumber(a){
  var itis;

  itis = a.isNumber;
  if(a.isStruture || a.isArray || a.isBoolean || a.isString){
    itis = false;
  }

  return itis;
}
function IsBoolean(a){
  var itis;

  itis = a.isBoolean;
  if(a.isStruture || a.isArray || a.isNumber || a.isString){
    itis = false;
  }

  return itis;
}
function IsString(a){
  var itis;

  itis = a.isString;
  if(a.isStruture || a.isArray || a.isNumber || a.isBoolean){
    itis = false;
  }

  return itis;
}
function IsNoType(a){
  var itis;

  if( !a.isString  &&  !a.isStruture  &&  !a.isArray  &&  !a.isNumber  &&  !a.isBoolean ){
    itis = true;
  }else{
    itis = false;
  }

  return itis;
}
function CreateArray(){
  var array;

  array = {};
  array.array = [];
  array.array.length = 10;
  array.lengthx = 0;

  return array;
}
function CreateArrayWithInitialCapacity(capacity){
  var array;

  array = {};
  array.array = [];
  array.array.length = capacity;
  array.lengthx = 0;

  return array;
}
function ArrayAdd(array, value){
  if(array.lengthx == array.array.length){
    ArrayIncreaseSize(array);
  }

  array.array[array.lengthx] = value;
  array.lengthx = array.lengthx + 1;
}
function ArrayAddString(array, value){
  var data;

  data = CreateStringData(value);

  ArrayAdd(array, data);
}
function ArrayAddBoolean(array, value){
  var data;

  data = CreateBooleanData(value);

  ArrayAdd(array, data);
}
function ArrayAddNumber(array, value){
  var data;

  data = CreateNumberData(value);

  ArrayAdd(array, data);
}
function ArrayAddStruct(array, value){
  var data;

  data = CreateStructData(value);

  ArrayAdd(array, data);
}
function ArrayAddArray(array, value){
  var data;

  data = CreateArrayData(value);

  ArrayAdd(array, data);
}
function ArrayIncreaseSize(array){
  var newLength, i;
  var newArray;

  newLength = Math.round(array.array.length*3/2);
  newArray = [];
  newArray.length = newLength;

  for(i = 0; i < array.array.length; i = i + 1){
    newArray[i] = array.array[i];
  }

  delete(array.array);

  array.array = newArray;
}
function ArrayDecreaseSizeNecessary(array){
  var needsDecrease;

  needsDecrease = false;

  if(array.lengthx > 10){
    needsDecrease = array.lengthx <= Math.round(array.array.length*2/3);
  }

  return needsDecrease;
}
function ArrayDecreaseSize(array){
  var newLength, i;
  var newArray;

  newLength = Math.round(array.array.length*2/3);
  newArray = [];
  newArray.length = newLength;

  for(i = 0; i < newLength; i = i + 1){
    newArray[i] = array.array[i];
  }

  delete(array.array);

  array.array = newArray;
}
function ArrayIndex(array, index){
  return array.array[index];
}
function ArrayIndexArray(array, index){
  return array.array[index].array;
}
function ArrayIndexStruct(array, index){
  return array.array[index].structure;
}
function ArrayIndexBoolean(array, index){
  return array.array[index].booleanx;
}
function ArrayIndexString(array, index){
  return array.array[index].string;
}
function ArrayIndexNumber(array, index){
  return array.array[index].number;
}
function ArrayLength(array){
  return array.lengthx;
}
function ArrayInsert(array, index, value){
  var i;

  if(array.lengthx == array.array.length){
    ArrayIncreaseSize(array);
  }

  for(i = array.lengthx; i > index; i = i - 1){
    array.array[i] = array.array[i - 1];
  }

  array.array[index] = value;

  array.lengthx = array.lengthx + 1;
}
function ArrayInsertString(array, index, value){
  var data;

  data = CreateStringData(value);

  ArrayInsert(array, index, data);
}
function ArrayInsertBoolean(array, index, value){
  var data;

  data = CreateBooleanData(value);

  ArrayInsert(array, index, data);
}
function ArrayInsertNumber(array, index, value){
  var data;

  data = CreateNumberData(value);

  ArrayInsert(array, index, data);
}
function ArrayInsertStruct(array, index, value){
  var data;

  data = CreateStructData(value);

  ArrayInsert(array, index, data);
}
function ArrayInsertArray(array, index, value){
  var data;

  data = CreateArrayData(value);

  ArrayInsert(array, index, data);
}
function ArraySet(array, index, value){
  var success;

  if(index < array.lengthx){
    array.array[index] = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function ArraySetString(array, index, value){
  var data;

  data = CreateStringData(value);

  ArraySet(array, index, data);
}
function ArraySetBoolean(array, index, value){
  var data;

  data = CreateBooleanData(value);

  ArraySet(array, index, data);
}
function ArraySetNumber(array, index, value){
  var data;

  data = CreateNumberData(value);

  ArraySet(array, index, data);
}
function ArraySetStruct(array, index, value){
  var data;

  data = CreateStructData(value);

  ArraySet(array, index, data);
}
function ArraySetArray(array, index, value){
  var data;

  data = CreateArrayData(value);

  ArraySet(array, index, data);
}
function ArrayRemove(array, index){
  var i;

  for(i = index; i < array.lengthx - 1; i = i + 1){
    array.array[i] = array.array[i + 1];
  }

  array.lengthx = array.lengthx - 1;

  if(ArrayDecreaseSizeNecessary(array)){
    ArrayDecreaseSize(array);
  }
}
function ToStaticArray(arc){
  var array;
  var i;

  array = [];
  array.length = arc.lengthx;

  for(i = 0; i < arc.lengthx; i = i + 1){
    array[i] = arc.array[i];
  }

  return array;
}
function ToStaticNumberArray(array){
  var result;
  var i, n;

  n = ArrayLength(array);

  result = [];
  result.length = n;

  for(i = 0; i < n; i = i + 1){
    result[i] = ArrayIndex(array, i).number;
  }

  return result;
}
function ToStaticBooleanArray(array){
  var result;
  var i, n;

  n = ArrayLength(array);

  result = [];
  result.length = n;

  for(i = 0; i < n; i = i + 1){
    result[i] = ArrayIndex(array, i).booleanx;
  }

  return result;
}
function ToStaticStringArray(array){
  var result;
  var i, n;

  n = ArrayLength(array);

  result = [];
  result.length = n;

  for(i = 0; i < n; i = i + 1){
    result[i] = {};
    result[i].string = ArrayIndex(array, i).string;
  }

  return result;
}
function ToStaticArrayArray(array){
  var result;
  var i, n;

  n = ArrayLength(array);

  result = [];
  result.length = n;

  for(i = 0; i < n; i = i + 1){
    result[i] = ArrayIndex(array, i).array;
  }

  return result;
}
function ToStaticStructArray(array){
  var result;
  var i, n;

  n = ArrayLength(array);

  result = [];
  result.length = n;

  for(i = 0; i < n; i = i + 1){
    result[i] = ArrayIndex(array, i).structure;
  }

  return result;
}
function StaticArrayToArrayWithOptimalSize(src){
  var dst;
  var i;
  var c, n, newCapacity;

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
function StaticArrayToArray(src){
  var i;
  var dst;

  dst = CreateArrayWithInitialCapacity(src.length);
  for(i = 0; i < src.length; i = i + 1){
    dst.array[i] = src[i];
  }
  dst.lengthx = src.length;

  return dst;
}
function arraysStringToNumberArray(string){
  var i;
  var array;

  array = [];
  array.length = string.length;

  for(i = 0; i < string.length; i = i + 1){
    array[i] = string[i].charCodeAt(0);
  }
  return array;
}
function arraysNumberArrayToString(array){
  var i;
  var string;

  string = [];
  string.length = array.length;

  for(i = 0; i < array.length; i = i + 1){
    string[i] = String.fromCharCode(array[i]);
  }
  return string;
}
function arraysNumberArraysEqual(a, b){
  var equal;
  var i;

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
function arraysBooleanArraysEqual(a, b){
  var equal;
  var i;

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
function arraysStringsEqual(a, b){
  var equal;
  var i;

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
function arraysFillNumberArray(a, value){
  var i;

  for(i = 0; i < a.length; i = i + 1){
    a[i] = value;
  }
}
function arraysFillString(a, value){
  var i;

  for(i = 0; i < a.length; i = i + 1){
    a[i] = value;
  }
}
function arraysFillBooleanArray(a, value){
  var i;

  for(i = 0; i < a.length; i = i + 1){
    a[i] = value;
  }
}
function arraysFillNumberArrayRange(a, value, from, to){
  var i, lengthx;
  var success;

  if(from >= 0 && from <= a.length && to >= 0 && to <= a.length && from <= to){
    lengthx = to - from;
    for(i = 0; i < lengthx; i = i + 1){
      a[from + i] = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
function arraysFillBooleanArrayRange(a, value, from, to){
  var i, lengthx;
  var success;

  if(from >= 0 && from <= a.length && to >= 0 && to <= a.length && from <= to){
    lengthx = to - from;
    for(i = 0; i < lengthx; i = i + 1){
      a[from + i] = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
function arraysFillStringRange(a, value, from, to){
  var i, lengthx;
  var success;

  if(from >= 0 && from <= a.length && to >= 0 && to <= a.length && from <= to){
    lengthx = to - from;
    for(i = 0; i < lengthx; i = i + 1){
      a[from + i] = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
function arraysCopyNumberArray(a){
  var i;
  var n;

  n = [];
  n.length = a.length;

  for(i = 0; i < a.length; i = i + 1){
    n[i] = a[i];
  }

  return n;
}
function arraysCopyBooleanArray(a){
  var i;
  var n;

  n = [];
  n.length = a.length;

  for(i = 0; i < a.length; i = i + 1){
    n[i] = a[i];
  }

  return n;
}
function arraysCopyString(a){
  var i;
  var n;

  n = [];
  n.length = a.length;

  for(i = 0; i < a.length; i = i + 1){
    n[i] = a[i];
  }

  return n;
}
function arraysCopyNumberArrayRange(a, from, to, copyReference){
  var i, lengthx;
  var n;
  var success;

  if(from >= 0 && from <= a.length && to >= 0 && to <= a.length && from <= to){
    lengthx = to - from;
    n = [];
    n.length = lengthx;

    for(i = 0; i < lengthx; i = i + 1){
      n[i] = a[from + i];
    }

    copyReference.numberArray = n;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function arraysCopyBooleanArrayRange(a, from, to, copyReference){
  var i, lengthx;
  var n;
  var success;

  if(from >= 0 && from <= a.length && to >= 0 && to <= a.length && from <= to){
    lengthx = to - from;
    n = [];
    n.length = lengthx;

    for(i = 0; i < lengthx; i = i + 1){
      n[i] = a[from + i];
    }

    copyReference.booleanArray = n;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function arraysCopyStringRange(a, from, to, copyReference){
  var i, lengthx;
  var n;
  var success;

  if(from >= 0 && from <= a.length && to >= 0 && to <= a.length && from <= to){
    lengthx = to - from;
    n = [];
    n.length = lengthx;

    for(i = 0; i < lengthx; i = i + 1){
      n[i] = a[from + i];
    }

    copyReference.string = n;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function arraysIsLastElement(lengthx, index){
  return index + 1 == lengthx;
}
function arraysCreateNumberArray(lengthx, value){
  var array;

  array = [];
  array.length = lengthx;
  arraysFillNumberArray(array, value);

  return array;
}
function arraysCreateBooleanArray(lengthx, value){
  var array;

  array = [];
  array.length = lengthx;
  arraysFillBooleanArray(array, value);

  return array;
}
function arraysCreateString(lengthx, value){
  var array;

  array = [];
  array.length = lengthx;
  arraysFillString(array, value);

  return array;
}
function arraysSwapElementsOfNumberArray(A, ai, bi){
  var tmp;

  tmp = A[ai];
  A[ai] = A[bi];
  A[bi] = tmp;
}
function arraysSwapElementsOfStringArray(A, ai, bi){
  var tmp;

  tmp = A.stringArray[ai];
  A.stringArray[ai] = A.stringArray[bi];
  A.stringArray[bi] = tmp;
}
function arraysReverseNumberArray(array){
  var i;

  for(i = 0; i < array.length/2; i = i + 1){
    arraysSwapElementsOfNumberArray(array, i, array.length - i - 1);
  }
}
function CreateStringScientificNotationDecimalFromNumber(n){
  var mantissaReference, exponentReference;
  var e;
  var isPositive;
  var result;

  mantissaReference = {};
  exponentReference = {};
  result = [];
  result.length = 0;

  if(n < 0){
    isPositive = false;
    n =  -n;
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

  mantissaReference.string = CreateStringDecimalFromNumber(n);
  exponentReference.string = CreateStringDecimalFromNumber(e);

  if( !isPositive ){
    result = strAppendString(result, "-".split(''));
  }

  result = strAppendString(result, mantissaReference.string);
  result = strAppendString(result, "e".split(''));
  result = strAppendString(result, exponentReference.string);

  return result;
}
function CreateStringDecimalFromNumber(number){
  var string;
  var maximumDigits, i, d, digitPosition, trailingZeros;
  var hasPrintedPoint, isPositive, done;
  var characterReference;
  var c;
  var str;

  string = CreateDynamicArrayCharacters();
  isPositive = true;

  if(number < 0){
    isPositive = false;
    number =  -number;
  }

  if(number == 0){
    DynamicArrayAddCharacter(string, '0');
  }else{
    characterReference = {};

    maximumDigits = GetMaximumDigitsForDecimal();

    digitPosition = GetFirstDecimalDigitPosition(number);

    hasPrintedPoint = false;

    if( !isPositive ){
      DynamicArrayAddCharacter(string, '-');
    }

    /* Print leading zeros. */
    if(digitPosition < 0){
      DynamicArrayAddCharacter(string, '0');
      DynamicArrayAddCharacter(string, '.');
      hasPrintedPoint = true;
      for(i = 0; i <  -digitPosition - 1; i = i + 1){
        DynamicArrayAddCharacter(string, '0');
      }
    }

    /* Count trailing zeros */
    trailingZeros = 0;
    done = false;
    for(i = 0; i < maximumDigits &&  !done ; i = i + 1){
      d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1);
      if(d == 0){
        trailingZeros = trailingZeros + 1;
      }else{
        done = true;
      }
    }

    /* Print number. */
    for(i = 0; i < maximumDigits; i = i + 1){
      d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i);

      if( !hasPrintedPoint  && digitPosition - i + 1 == 0){
        if(maximumDigits - i > trailingZeros){
          DynamicArrayAddCharacter(string, '.');
        }
        hasPrintedPoint = true;
      }

      if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
      }else{
        GetDecimalDigitCharacterFromNumberWithCheck(d, characterReference);
        c = characterReference.characterValue;
        DynamicArrayAddCharacter(string, c);
      }
    }

    /* Print trailing zeros. */
    for(i = 0; i < digitPosition - maximumDigits + 1; i = i + 1){
      DynamicArrayAddCharacter(string, '0');
    }
  }

  /* Done */
  str = DynamicArrayCharactersToArray(string);
  FreeDynamicArrayCharacters(string);
  return str;
}
function CreateStringFromNumberWithCheck(number, base, stringRef){
  var string;
  var maximumDigits, i, d, digitPosition, trailingZeros;
  var success, hasPrintedPoint, isPositive, done;
  var characterReference;
  var c;

  string = CreateDynamicArrayCharacters();
  isPositive = true;

  if(number < 0){
    isPositive = false;
    number =  -number;
  }

  if(number == 0){
    DynamicArrayAddCharacter(string, '0');
    success = true;
  }else{
    characterReference = {};

    if(IsInteger(base)){
      success = true;

      maximumDigits = GetMaximumDigitsForBase(base);

      digitPosition = GetFirstDigitPosition(number, base);

      hasPrintedPoint = false;

      if( !isPositive ){
        DynamicArrayAddCharacter(string, '-');
      }

      /* Print leading zeros. */
      if(digitPosition < 0){
        DynamicArrayAddCharacter(string, '0');
        DynamicArrayAddCharacter(string, '.');
        hasPrintedPoint = true;
        for(i = 0; i <  -digitPosition - 1; i = i + 1){
          DynamicArrayAddCharacter(string, '0');
        }
      }

      /* Count trailing zeros */
      trailingZeros = 0;
      done = false;
      for(i = 0; i < maximumDigits &&  !done ; i = i + 1){
        d = GetDigit(number, base, maximumDigits - i - 1);
        if(d == 0){
          trailingZeros = trailingZeros + 1;
        }else{
          done = true;
        }
      }

      /* Print number. */
      for(i = 0; i < maximumDigits && success; i = i + 1){
        d = GetDigit(number, base, i);

        if(d >= base){
          d = base - 1;
        }

        if( !hasPrintedPoint  && digitPosition - i + 1 == 0){
          if(maximumDigits - i > trailingZeros){
            DynamicArrayAddCharacter(string, '.');
          }
          hasPrintedPoint = true;
        }

        if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
        }else{
          success = GetSingleDigitCharacterFromNumberWithCheck(d, base, characterReference);
          if(success){
            c = characterReference.characterValue;
            DynamicArrayAddCharacter(string, c);
          }
        }
      }

      if(success){
        /* Print trailing zeros. */
        for(i = 0; i < digitPosition - maximumDigits + 1; i = i + 1){
          DynamicArrayAddCharacter(string, '0');
        }
      }
    }else{
      success = false;
    }
  }

  if(success){
    stringRef.string = DynamicArrayCharactersToArray(string);
    FreeDynamicArrayCharacters(string);
  }

  /* Done */
  return success;
}
function GetMaximumDigitsForBase(base){
  var t;

  t = 10**15;
  return Math.floor(Math.log10(t)/Math.log10(base));
}
function GetMaximumDigitsForDecimal(){
  return 15;
}
function GetFirstDecimalDigitPosition(n){
  var power, m, i;
  var multiply, done;

  n = Math.abs(n);

  if(n != 0){
    if(Math.floor(n) < 10**15){
      multiply = true;
    }else{
      multiply = false;
    }

    done = false;
    m = 0;
    for(i = 0;  !done ; i = i + 1){
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
function GetFirstDigitPosition(n, base){
  var power, m, i, maximumDigits;
  var multiply, done;

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
    for(i = 0;  !done ; i = i + 1){
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
function GetSingleDigitCharacterFromNumberWithCheck(c, base, characterReference){
  var numberTable;
  var success;

  numberTable = GetDigitCharacterTable();

  if(c < base || c < numberTable.length){
    success = true;
    characterReference.characterValue = numberTable[c];
  }else{
    success = false;
  }

  return success;
}
function GetDecimalDigitCharacterFromNumberWithCheck(c, characterRef){
  var numberTable;
  var success;

  numberTable = "0123456789".split('');

  if(c >= 0 && c < 10){
    success = true;
    characterRef.characterValue = numberTable[c];
  }else{
    success = false;
  }

  return success;
}
function GetDigitCharacterTable(){
  var numberTable;

  numberTable = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".split('');

  return numberTable;
}
function GetDecimalDigit(n, index){
  var digitPosition;

  digitPosition = GetFirstDecimalDigitPosition(n);

  return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index);
}
function GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index){
  var d, e, m, i;

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
function GetDigit(n, base, index){
  var d, digitPosition, e, m, maximumDigits, i;

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
function NumberToHumanReadableShortScale(n){
  var res, suffix;
  var hasSuffix;
  var k, M, B, T, Q;

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
function NumberToHumanReadableBinary(n){
  var res, suffix;
  var hasSuffix;
  var Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi;

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
function NumberToHumanReadableMetric(n){
  var res, suffix;
  var hasSuffix;
  var k, M, G, T, P, Ex, Z, Y, R, Q;

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
function IsValidNumber(str){
  var valid;
  var numberRef;
  var message;

  numberRef = {};
  message = {};

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

  delete(numberRef);
  delete(message);

  return valid;
}
function IsValidInteger(str){
  var valid;
  var numberRef;
  var message;

  numberRef = {};
  message = {};

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

  if(valid){
    valid = IsInteger(numberRef.numberValue);
  }

  delete(numberRef);
  delete(message);

  return valid;
}
function IsValidPositiveInteger(str){
  var valid;
  var numberRef;
  var message;

  numberRef = {};
  message = {};

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

  if(valid){
    valid = IsInteger(numberRef.numberValue);
    if(valid){
      valid = numberRef.numberValue >= 0;
    }
  }

  delete(numberRef);
  delete(message);

  return valid;
}
function CreateNumberFromDecimalStringWithCheck(string, decimalReference, message){
  return CreateNumberFromStringWithCheck(string, 10, decimalReference, message);
}
function CreateNumberFromDecimalString(string){
  var doubleReference;
  var stringReference;
  var number;

  doubleReference = CreateNumberReference(0);
  stringReference = CreateStringReference("".split(''));
  CreateNumberFromStringWithCheck(string, 10, doubleReference, stringReference);
  number = doubleReference.numberValue;

  delete(doubleReference);
  delete(stringReference);

  return number;
}
function CreateNumberFromStringWithCheck(string, base, numberReference, message){
  var success;
  var numberIsPositive, exponentIsPositive;
  var beforePoint, afterPoint, exponent;

  numberIsPositive = CreateBooleanReference(true);
  exponentIsPositive = CreateBooleanReference(true);
  beforePoint = {};
  afterPoint = {};
  exponent = {};

  if(base >= 2 && base <= 36){
    success = ExtractPartsFromNumberString(string, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

    if(success){
      numberReference.numberValue = CreateNumberFromParts(base, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray);
    }
  }else{
    success = false;
    message.string = "Base must be from 2 to 36.".split('');
  }

  return success;
}
function CreateNumberFromParts(base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent){
  var n, i, p, e;

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

    if( !exponentIsPositive ){
      e =  -e;
    }

    n = n*base**e;
  }

  if( !numberIsPositive ){
    n =  -n;
  }

  return n;
}
function ExtractPartsFromNumberString(n, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, errorMessages){
  var i, j, count;
  var success, done, complete;

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
    errorMessages.string = "Number cannot have length zero.".split('');
  }

  if(success){
    done = false;
    count = 0;
    for(; i + count < n.length &&  !done ; ){
      if(CharacterIsNumberCharacterInBase(n[i + count], base)){
        count = count + 1;
      }else{
        done = true;
      }
    }

    if(count >= 1){
      beforePoint.numberArray = [];
      beforePoint.numberArray.length = count;

      for(j = 0; j < count; j = j + 1){
        beforePoint.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base);
      }

      i = i + count;

      if(i < n.length){
        success = true;
      }else{
        afterPoint.numberArray = [];
        afterPoint.numberArray.length = 0;
        exponent.numberArray = [];
        exponent.numberArray.length = 0;
        success = true;
        complete = true;
      }
    }else{
      success = false;
      errorMessages.string = "Number must have at least one number after the optional sign.".split('');
    }
  }

  if(success &&  !complete ){
    if(n[i] == '.'){
      i = i + 1;

      if(i < n.length){
        done = false;
        count = 0;
        for(; i + count < n.length &&  !done ; ){
          if(CharacterIsNumberCharacterInBase(n[i + count], base)){
            count = count + 1;
          }else{
            done = true;
          }
        }

        if(count >= 1){
          afterPoint.numberArray = [];
          afterPoint.numberArray.length = count;

          for(j = 0; j < count; j = j + 1){
            afterPoint.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base);
          }

          i = i + count;

          if(i < n.length){
            success = true;
          }else{
            exponent.numberArray = [];
            exponent.numberArray.length = 0;
            success = true;
            complete = true;
          }
        }else{
          success = false;
          errorMessages.string = "There must be at least one digit after the decimal point.".split('');
        }
      }else{
        success = false;
        errorMessages.string = "There must be at least one digit after the decimal point.".split('');
      }
    }else if(base <= 14 && (n[i] == 'e' || n[i] == 'E')){
      if(i < n.length){
        success = true;
        afterPoint.numberArray = [];
        afterPoint.numberArray.length = 0;
      }else{
        success = false;
        errorMessages.string = "There must be at least one digit after the exponent.".split('');
      }
    }else{
      success = false;
      errorMessages.string = "Expected decimal point or exponent symbol.".split('');
    }
  }

  if(success &&  !complete ){
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
          for(; i + count < n.length &&  !done ; ){
            if(CharacterIsNumberCharacterInBase(n[i + count], base)){
              count = count + 1;
            }else{
              done = true;
            }
          }

          if(count >= 1){
            exponent.numberArray = [];
            exponent.numberArray.length = count;

            for(j = 0; j < count; j = j + 1){
              exponent.numberArray[j] = GetNumberFromNumberCharacterForBase(n[i + j], base);
            }

            i = i + count;

            if(i == n.length){
              success = true;
            }else{
              success = false;
              errorMessages.string = "There cannot be any characters past the exponent of the number.".split('');
            }
          }else{
            success = false;
            errorMessages.string = "There must be at least one digit after the decimal point.".split('');
          }
        }else{
          success = false;
          errorMessages.string = "There must be at least one digit after the exponent symbol.".split('');
        }
      }else{
        success = false;
        errorMessages.string = "There must be at least one digit after the exponent symbol.".split('');
      }
    }else{
      success = false;
      errorMessages.string = "Expected exponent symbol.".split('');
    }
  }

  return success;
}
function GetNumberFromNumberCharacterForBase(c, base){
  var numberTable;
  var i;
  var position;

  numberTable = GetDigitCharacterTable();
  position = 0;

  for(i = 0; i < base; i = i + 1){
    if(numberTable[i] == c){
      position = i;
    }
  }

  return position;
}
function CharacterIsNumberCharacterInBase(c, base){
  var numberTable;
  var i;
  var found;

  numberTable = GetDigitCharacterTable();
  found = false;

  for(i = 0; i < base; i = i + 1){
    if(numberTable[i] == c){
      found = true;
    }
  }

  return found;
}
function StringToNumberArray(str){
  var numberArrayReference;
  var stringReference;
  var numbers;

  numberArrayReference = {};
  stringReference = {};

  StringToNumberArrayWithCheck(str, numberArrayReference, stringReference);

  numbers = numberArrayReference.numberArray;

  delete(numberArrayReference);
  delete(stringReference);

  return numbers;
}
function StringToNumberArrayWithCheck(str, numberArrayReference, errorMessage){
  var numberStrings;
  var numbers;
  var i;
  var numberString, trimmedNumberString;
  var success;
  var numberReference;

  numberStrings = strSplitByString(str, ",".split(''));

  numbers = [];
  numbers.length = numberStrings.length;
  success = true;
  numberReference = {};

  for(i = 0; i < numberStrings.length; i = i + 1){
    numberString = numberStrings[i].string;
    trimmedNumberString = strTrim(numberString);
    success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage);
    numbers[i] = numberReference.numberValue;

    FreeStringReference(numberStrings[i]);
    delete(trimmedNumberString);
  }

  delete(numberStrings);
  delete(numberReference);

  numberArrayReference.numberArray = numbers;

  return success;
}
function strWriteStringToStingStream(stream, index, src){
  var i;

  for(i = 0; i < src.length; i = i + 1){
    stream[index.numberValue + i] = src[i];
  }
  index.numberValue = index.numberValue + src.length;
}
function strWriteCharacterToStingStream(stream, index, src){
  stream[index.numberValue] = src;
  index.numberValue = index.numberValue + 1;
}
function strWriteBooleanToStingStream(stream, index, src){
  if(src){
    strWriteStringToStingStream(stream, index, "true".split(''));
  }else{
    strWriteStringToStingStream(stream, index, "false".split(''));
  }
}
function strSubstringWithCheck(string, from, to, stringReference){
  var success;

  if(from >= 0 && from <= string.length && to >= 0 && to <= string.length && from <= to){
    stringReference.string = strSubstring(string, from, to);
    success = true;
  }else{
    success = false;
  }

  return success;
}
function strSubstring(string, from, to){
  var n;
  var i, lengthx;

  lengthx = to - from;

  n = [];
  n.length = lengthx;

  for(i = from; i < to; i = i + 1){
    n[i - from] = string[i];
  }

  return n;
}
function strAppendString(s1, s2){
  var newString;

  newString = strConcatenateString(s1, s2);

  delete(s1);

  return newString;
}
function strConcatenateString(s1, s2){
  var newString;
  var i;

  newString = [];
  newString.length = s1.length + s2.length;

  for(i = 0; i < s1.length; i = i + 1){
    newString[i] = s1[i];
  }

  for(i = 0; i < s2.length; i = i + 1){
    newString[s1.length + i] = s2[i];
  }

  return newString;
}
function strAppendCharacter(string, c){
  var newString;

  newString = strConcatenateCharacter(string, c);

  delete(string);

  return newString;
}
function strConcatenateCharacter(string, c){
  var newString;
  var i;
  newString = [];
  newString.length = string.length + 1;

  for(i = 0; i < string.length; i = i + 1){
    newString[i] = string[i];
  }

  newString[string.length] = c;

  return newString;
}
function strSplitByCharacter(toSplit, splitBy){
  var parts;
  var i;
  var c;
  var ll;
  var next;
  var part;

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
function strIndexOfCharacter(string, character, indexReference){
  var i;
  var found;

  found = false;
  for(i = 0; i < string.length &&  !found ; i = i + 1){
    if(string[i] == character){
      found = true;
      indexReference.numberValue = i;
    }
  }

  return found;
}
function strLastIndexOfCharacter(string, character, indexReference){
  var i;
  var found;

  found = false;
  for(i = 0; i < string.length; i = i + 1){
    if(string[i] == character){
      found = true;
      indexReference.numberValue = i;
    }
  }

  return found;
}
function strSubstringEqualsWithCheck(string, from, substring, equalsReference){
  var success;

  if(from < string.length){
    success = true;
    equalsReference.booleanValue = strSubstringEquals(string, from, substring);
  }else{
    success = false;
  }

  return success;
}
function strSubstringEquals(string, from, substring){
  var i;
  var equal;

  equal = true;
  if(string.length - from >= substring.length){
    for(i = 0; i < substring.length && equal; i = i + 1){
      if(string[from + i] != substring[i]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
function strIndexOfString(string, substring, indexReference){
  var i;
  var found;

  found = false;
  for(i = 0; i < string.length - substring.length + 1 &&  !found ; i = i + 1){
    if(strSubstringEquals(string, i, substring)){
      found = true;
      indexReference.numberValue = i;
    }
  }

  return found;
}
function strContainsCharacter(string, character){
  var i;
  var found;

  found = false;
  for(i = 0; i < string.length &&  !found ; i = i + 1){
    if(string[i] == character){
      found = true;
    }
  }

  return found;
}
function strContainsString(string, substring){
  return strIndexOfString(string, substring, {});
}
function strToUpperCase(string){
  var i;

  for(i = 0; i < string.length; i = i + 1){
    string[i] = cToUpperCase(string[i]);
  }
}
function strToLowerCase(string){
  var i;

  for(i = 0; i < string.length; i = i + 1){
    string[i] = cToLowerCase(string[i]);
  }
}
function strEqualsIgnoreCase(a, b){
  var equal;
  var i;

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
function strReplaceString(string, toReplace, replaceWith){
  var result;
  var i, j;
  var equalsReference;
  var success;
  var da;

  da = CreateDynamicArrayCharacters();

  equalsReference = {};

  for(i = 0; i < string.length; ){
    success = strSubstringEqualsWithCheck(string, i, toReplace, equalsReference);
    if(success){
      success = equalsReference.booleanValue;
    }

    if(success && toReplace.length > 0){
      for(j = 0; j < replaceWith.length; j = j + 1){
        DynamicArrayAddCharacter(da, replaceWith[j]);
      }
      i = i + toReplace.length;
    }else{
      DynamicArrayAddCharacter(da, string[i]);
      i = i + 1;
    }
  }

  result = DynamicArrayCharactersToArray(da);

  FreeDynamicArrayCharacters(da);

  return result;
}
function strReplaceCharacterToNew(string, toReplace, replaceWith){
  var result;
  var i;

  result = [];
  result.length = string.length;

  for(i = 0; i < string.length; i = i + 1){
    if(string[i] == toReplace){
      result[i] = replaceWith;
    }else{
      result[i] = string[i];
    }
  }

  return result;
}
function strReplaceCharacter(string, toReplace, replaceWith){
  var i;

  for(i = 0; i < string.length; i = i + 1){
    if(string[i] == toReplace){
      string[i] = replaceWith;
    }
  }
}
function strTrim(string){
  var result;
  var i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd;
  var firstNonWhitespaceFound;

  /* Find whitepaces at the start. */
  lastWhitespaceLocationStart =  -1;
  firstNonWhitespaceFound = false;
  for(i = 0; i < string.length &&  !firstNonWhitespaceFound ; i = i + 1){
    if(cIsWhiteSpace(string[i])){
      lastWhitespaceLocationStart = i;
    }else{
      firstNonWhitespaceFound = true;
    }
  }

  /* Find whitepaces at the end. */
  lastWhitespaceLocationEnd = string.length;
  firstNonWhitespaceFound = false;
  for(i = string.length - 1; i >= 0 &&  !firstNonWhitespaceFound ; i = i - 1){
    if(cIsWhiteSpace(string[i])){
      lastWhitespaceLocationEnd = i;
    }else{
      firstNonWhitespaceFound = true;
    }
  }

  if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
    result = strSubstring(string, lastWhitespaceLocationStart + 1, lastWhitespaceLocationEnd);
  }else{
    result = [];
    result.length = 0;
  }

  return result;
}
function strStartsWith(string, start){
  var startsWithString;

  startsWithString = false;
  if(string.length >= start.length){
    startsWithString = strSubstringEquals(string, 0, start);
  }

  return startsWithString;
}
function strEndsWith(string, end){
  var endsWithString;

  endsWithString = false;
  if(string.length >= end.length){
    endsWithString = strSubstringEquals(string, string.length - end.length, end);
  }

  return endsWithString;
}
function strSplitByString(toSplit, splitBy){
  var parts;
  var i;
  var c;
  var ll;
  var next;
  var part;

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
function strStringIsBefore(a, b){
  var before, equal, done;
  var i;

  before = false;
  equal = true;
  done = false;

  if(a.length == 0 && b.length > 0){
    before = true;
  }else{
    for(i = 0; i < a.length && i < b.length &&  !done ; i = i + 1){
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
function strJoinStringsWithSeparator(strings, separator){
  var result, string;
  var lengthx, i;
  var index;

  index = CreateNumberReference(0);

  lengthx = 0;
  for(i = 0; i < strings.length; i = i + 1){
    lengthx = lengthx + strings[i].string.length;
  }
  lengthx = lengthx + (strings.length - 1)*separator.length;

  result = [];
  result.length = lengthx;

  for(i = 0; i < strings.length; i = i + 1){
    string = strings[i].string;
    strWriteStringToStingStream(result, index, string);
    if(i + 1 < strings.length){
      strWriteStringToStingStream(result, index, separator);
    }
  }

  delete(index);

  return result;
}
function strJoinStrings(strings){
  var result, string;
  var lengthx, i;
  var index;

  index = CreateNumberReference(0);

  lengthx = 0;
  for(i = 0; i < strings.length; i = i + 1){
    lengthx = lengthx + strings[i].string.length;
  }

  result = [];
  result.length = lengthx;

  for(i = 0; i < strings.length; i = i + 1){
    string = strings[i].string;
    strWriteStringToStingStream(result, index, string);
  }

  delete(index);

  return result;
}
function strStringOrder(a, b){
  var order, minimum, i, ac, bc;
  var done;

  minimum = Math.min(a.length, b.length);

  done = false;
  order = 0;
  for(i = 0; i < minimum &&  !done ; i = i + 1){
    ac = a[i].charCodeAt(0);
    bc = b[i].charCodeAt(0);

    if(ac < bc){
      done = true;
      order = 1;
    }else if(ac > bc){
      done = true;
      order =  -1;
    }
  }

  if( !done ){
    if(a.length < b.length){
      order = 1;
    }else if(a.length > b.length){
      order =  -1;
    }
  }

  return order;
}
function strLeftPad(str, width){
  var i;
  var padded;

  padded = [];
  padded.length = width;
  arraysFillString(padded, ' ');

  for(i = 0; i < str.length; i = i + 1){
    padded[width - str.length + i] = str[i];
  }

  return padded;
}
function strRightPad(str, width){
  var i;
  var padded;

  padded = [];
  padded.length = width;
  arraysFillString(padded, ' ');

  for(i = 0; i < str.length; i = i + 1){
    padded[i] = str[i];
  }

  return padded;
}
function AssertFalse(b, failures){
  if(b){
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertTrue(b, failures){
  if( !b ){
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertEquals(a, b, failures){
  if(a != b){
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertBooleansEqual(a, b, failures){
  if(a != b){
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertCharactersEqual(a, b, failures){
  if(a != b){
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertStringEquals(a, b, failures){
  if( !arraysStringsEqual(a, b) ){
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertNumberArraysEqual(a, b, failures){
  var i;

  if(a.length == b.length){
    for(i = 0; i < a.length; i = i + 1){
      AssertEquals(a[i], b[i], failures);
    }
  }else{
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertBooleanArraysEqual(a, b, failures){
  var i;

  if(a.length == b.length){
    for(i = 0; i < a.length; i = i + 1){
      AssertBooleansEqual(a[i], b[i], failures);
    }
  }else{
    failures.numberValue = failures.numberValue + 1;
  }
}
function AssertStringArraysEqual(a, b, failures){
  var i;

  if(a.length == b.length){
    for(i = 0; i < a.length; i = i + 1){
      AssertStringEquals(a[i].string, b[i].string, failures);
    }
  }else{
    failures.numberValue = failures.numberValue + 1;
  }
}
function Negate(x){
  return  -x;
}
function Positive(x){
  return  +x;
}
function Factorial(x){
  var i, f;

  f = 1;

  for(i = 2; i <= x; i = i + 1){
    f = f*i;
  }

  return f;
}
function Round(x){
  return Math.floor(x + 0.5);
}
function RoundToDigits(element, digitsAfterPoint){
  return Round(element*10**digitsAfterPoint)/10**digitsAfterPoint;
}
function BankersRound(x){
  var r;

  if(Absolute(x - Truncate(x)) == 0.5){
    if( !DivisibleBy(Round(x), 2) ){
      r = Round(x) - 1;
    }else{
      r = Round(x);
    }
  }else{
    r = Round(x);
  }

  return r;
}
function Ceil(x){
  return Math.ceil(x);
}
function Floor(x){
  return Math.floor(x);
}
function Truncate(x){
  var t;

  if(x >= 0){
    t = Math.floor(x);
  }else{
    t = Math.ceil(x);
  }

  return t;
}
function Absolute(x){
  return Math.abs(x);
}
function Logarithm(x){
  return Math.log10(x);
}
function NaturalLogarithm(x){
  return Math.log(x);
}
function Sin(x){
  return Math.sin(x);
}
function Cos(x){
  return Math.cos(x);
}
function Tan(x){
  return Math.tan(x);
}
function Asin(x){
  return Math.asin(x);
}
function Acos(x){
  return Math.acos(x);
}
function Atan(x){
  return Math.atan(x);
}
function Atan2(y, x){
  var a;

  /* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors. */
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
    a =  -Math.PI/2;
  }

  return a;
}
function Squareroot(x){
  return Math.sqrt(x);
}
function Exp(x){
  return Math.exp(x);
}
function DivisibleBy(a, b){
  return ((a%b) == 0);
}
function Combinations(n, k){
  var i, j, c;

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
function Permutations(n, k){
  var i, c;

  c = 1;

  for(i = n - k + 1; i <= n; i = i + 1){
    c = c*i;
  }

  return c;
}
function EpsilonCompare(a, b, epsilon){
  return Math.abs(a - b) < epsilon;
}
function GreatestCommonDivisor(a, b){
  var t;

  for(; b != 0; ){
    t = b;
    b = a%b;
    a = t;
  }

  return a;
}
function GCDWithSubtraction(a, b){
  var g;

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
function IsInteger(a){
  return (a - Math.floor(a)) == 0;
}
function GreatestCommonDivisorWithCheck(a, b, gcdReference){
  var success;
  var gcd;

  if(IsInteger(a) && IsInteger(b)){
    gcd = GreatestCommonDivisor(a, b);
    gcdReference.numberValue = gcd;
    success = true;
  }else{
    success = false;
  }

  return success;
}
function LeastCommonMultiple(a, b){
  var lcm;

  if(a > 0 && b > 0){
    lcm = Math.abs(a*b)/GreatestCommonDivisor(a, b);
  }else{
    lcm = 0;
  }

  return lcm;
}
function Sign(a){
  var s;

  if(a > 0){
    s = 1;
  }else if(a < 0){
    s =  -1;
  }else{
    s = 0;
  }

  return s;
}
function Max(a, b){
  return Math.max(a, b);
}
function Min(a, b){
  return Math.min(a, b);
}
function Power(a, b){
  return a**b;
}
function Gamma(x){
  return LanczosApproximation(x);
}
function LogGamma(x){
  return Math.log(Gamma(x));
}
function LanczosApproximation(z){
  var p;
  var i, y, t, x;

  p = [];
  p.length = 8;
  p[0] = 676.5203681218851;
  p[1] =  -1259.1392167224028;
  p[2] = 771.32342877765313;
  p[3] =  -176.61502916214059;
  p[4] = 12.507343278686905;
  p[5] =  -0.13857109526572012;
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
    y = Math.sqrt(2*Math.PI)*t**(z + 0.5)*Math.exp( -t)*x;
  }

  return y;
}
function Beta(x, y){
  return Gamma(x)*Gamma(y)/Gamma(x + y);
}
function Sinh(x){
  return (Math.exp(x) - Math.exp( -x))/2;
}
function Cosh(x){
  return (Math.exp(x) + Math.exp( -x))/2;
}
function Tanh(x){
  return Sinh(x)/Cosh(x);
}
function Cot(x){
  return 1/Math.tan(x);
}
function Sec(x){
  return 1/Math.cos(x);
}
function Csc(x){
  return 1/Math.sin(x);
}
function Coth(x){
  return Cosh(x)/Sinh(x);
}
function Sech(x){
  return 1/Cosh(x);
}
function Csch(x){
  return 1/Sinh(x);
}
function Error(x){
  var y, t, tau, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

  if(x == 0){
    y = 0;
  }else if(x < 0){
    y =  -Error( -x);
  }else{
    c1 =  -1.26551223;
    c2 =  +1.00002368;
    c3 =  +0.37409196;
    c4 =  +0.09678418;
    c5 =  -0.18628806;
    c6 =  +0.27886807;
    c7 =  -1.13520398;
    c8 =  +1.48851587;
    c9 =  -0.82215223;
    c10 =  +0.17087277;

    t = 1/(1 + 0.5*Math.abs(x));

    tau = t*Math.exp( -(x**2) + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))));

    y = 1 - tau;
  }

  return y;
}
function ErrorInverse(x){
  var y, a, t;

  a = (8*(Math.PI - 3))/(3*Math.PI*(4 - Math.PI));

  t = 2/(Math.PI*a) + Math.log(1 - x**2)/2;
  y = Sign(x)*Math.sqrt(Math.sqrt(t**2 - Math.log(1 - x**2)/a) - t);

  return y;
}
function FallingFactorial(x, n){
  var k, y;

  y = 1;

  for(k = 0; k <= n - 1; k = k + 1){
    y = y*(x - k);
  }

  return y;
}
function RisingFactorial(x, n){
  var k, y;

  y = 1;

  for(k = 0; k <= n - 1; k = k + 1){
    y = y*(x + k);
  }

  return y;
}
function Hypergeometric(a, b, c, z, maxIterations, precision){
  var y;

  if(Math.abs(z) >= 0.5){
    y = (1 - z)**( -a)*HypergeometricDirect(a, c - b, c, z/(z - 1), maxIterations, precision);
  }else{
    y = HypergeometricDirect(a, b, c, z, maxIterations, precision);
  }

  return y;
}
function HypergeometricDirect(a, b, c, z, maxIterations, precision){
  var y, yp, n;
  var done;

  y = 0;
  done = false;

  for(n = 0; n < maxIterations &&  !done ; n = n + 1){
    yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*z**n/Factorial(n);
    if(Math.abs(yp) < precision){
      done = true;
    }
    y = y + yp;
  }

  return y;
}
function BernouilliNumber(n){
  return AkiyamaTanigawaAlgorithm(n);
}
function AkiyamaTanigawaAlgorithm(n){
  var m, j, B;
  var A;

  A = [];
  A.length = n + 1;

  for(m = 0; m <= n; m = m + 1){
    A[m] = 1/(m + 1);
    for(j = m; j >= 1; j = j - 1){
      A[j - 1] = j*(A[j - 1] - A[j]);
    }
  }

  B = A[0];

  delete(A);

  return B;
}
function D15Add(a, b, overflow){
  var x;

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
function RoundTo15Digits(x){
  var p;

  p = Math.floor(Math.log10(x));
  x = x*10**(15 - p);
  x = Round(x);
  x = x/10**(15 - p);

  return x;
}
function D15MaxValue(){
  return  +9.99999999999999e99;
}
function D15MinValue(){
  return  -9.99999999999999e99;
}
function D15Multiply(a, b, overflow){
  var x;

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
function D15Divide(a, b, reminder, overflow, invalidOperation){
  var x, r;

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
function D15Exponentiation(a, b, overflow, invalidOperation){
  var x;

  if(a == 0 && b == 0){
    invalidOperation.booleanValue = true;
    overflow.booleanValue = false;
    x = 0;
  }else if(a < 0 &&  !IsInteger(b) ){
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
function D15Modulus(a, b, invalidOperation){
  var x;

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
function D15Logarithm(a, invalidOperation){
  var x;

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
function D15NaturalLogarithm(a, invalidOperation){
  var x;

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
function D15Sin(a){
  var x;

  x = Math.sin(a);
  x = RoundTo15Digits(x);

  return x;
}
function D15Cos(x){
  var a, y, piBy2Part1, piBy2Part2, limit, f;

  x = Math.abs(x);

  limit = Math.PI + 3.1/2;

  if(x > limit){
    f = Math.floor(x/Math.PI);
    x = x - Math.PI*f;
  }

  piBy2Part1 =  +1.57079632679490;
  piBy2Part2 =  -3.38076867830836e-15;

  if(x > 3.1/2 && x < 3.3/2){
    a = x - piBy2Part1;
    a = Math.round(a*10**15)/10**15;
    a = a - piBy2Part2;
    y =  -Math.sin(a);
  }else{
    y = Math.cos(x);
    y = RoundTo15Digits(y);
  }

  return y;
}
function D15Tan(a, overflow){
  var x;

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
function D15Asin(a, invalidOperation){
  var x;

  if(a <  -1 || a > 1){
    invalidOperation.booleanValue = true;
    x = 0;
  }else{
    invalidOperation.booleanValue = false;
    x = Math.asin(a);
    x = RoundTo15Digits(x);
  }

  return x;
}
function D15Acos(a, invalidOperation){
  var x;

  if(a <  -1 || a > 1){
    invalidOperation.booleanValue = true;
    x = 0;
  }else{
    invalidOperation.booleanValue = false;
    x = Math.acos(a);
    x = RoundTo15Digits(x);
  }

  return x;
}
function D15Atan(a){
  var x;

  x = Math.atan(a);
  x = RoundTo15Digits(x);

  return x;
}
function D15Sqrt(a){
  var x;

  x = Math.sqrt(a);
  x = RoundTo15Digits(x);

  return x;
}
function D15Exponential(a, overflow){
  var x;

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
function Decimal15E2ToString(decimal){
  var multiplier, inc, i, d;
  var exponent;
  var done, isPositive, isPositiveExponent;
  var result;
  var len;

  len = 21;
  /* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00" */
  result = [];
  result.length = len;

  done = false;
  exponent = 0;

  if(decimal < 0){
    isPositive = false;
    decimal =  -decimal;
  }else{
    isPositive = true;
  }

  if(decimal == 0){
    done = true;
  }

  if( !done ){
    multiplier = 0;
    inc = 0;

    if(decimal < 1){
      multiplier = 10;
      inc =  -1;
    }else if(decimal >= 10){
      multiplier = 0.1;
      inc = 1;
    }else{
      done = true;
    }

    if( !done ){
      exponent = Math.round(Math.log10(decimal));
      exponent = Math.min(99, exponent);
      exponent = Math.max( -99, exponent);

      decimal = decimal/10**exponent;

      /* Adjust */
      for(; (decimal >= 10 || decimal < 1) && Math.abs(exponent) < 99; ){
        decimal = decimal*multiplier;
        exponent = exponent + inc;
      }
    }
  }

  isPositiveExponent = exponent >= 0;
  if( !isPositiveExponent ){
    exponent =  -exponent;
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
function SingleDigitNumberToCharacter(n){
  var c;

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
function cToLowerCase(character){
  var toReturn;

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
function cToUpperCase(character){
  var toReturn;

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
function cIsUpperCase(character){
  var isUpper;

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
function cIsLowerCase(character){
  var isLower;

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
function cIsLetter(character){
  return cIsUpperCase(character) || cIsLowerCase(character);
}
function cIsNumber(character){
  var isNumberx;

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
function cIsWhiteSpace(character){
  var isWhiteSpacex;

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
function cIsSymbol(character){
  var isSymbolx;

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
function cCharacterIsBefore(a, b){
  var ad, bd;

  ad = a.charCodeAt(0);
  bd = b.charCodeAt(0);

  return ad < bd;
}
function cDecimalDigitToCharacter(digit){
  var c;
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
function cCharacterToDecimalDigit(c){
  var digit;

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

