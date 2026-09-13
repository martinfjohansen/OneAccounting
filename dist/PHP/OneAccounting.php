<?php
// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.


function unichr($unicode){
    return mb_convert_encoding("&#{$unicode};", 'UTF-8', 'HTML-ENTITIES');
}
function uniord($s) {
    return unpack('V', iconv('UTF-8', 'UCS-4LE', $s))[1];
}

function CreateLedger($decimals){

  $ledger = CreateStructure();
  $transactions = CreateArray();
  AddNumberToStruct($ledger, mb_str_split("decimals"), $decimals);
  AddArrayToStruct($ledger, mb_str_split("transactions"), $transactions);

  return $ledger;
}
function CreateFixedPointForDynamicLedger($ledger){

  $d = GetNumberFromStruct($ledger, mb_str_split("decimals"));
  $n = CreateFixedPoint15d(15.0 - $d, $d);

  return $n;
}
function CreateFixedPointForStaticLedger($ledger){

  $d = $ledger->decimals;
  $n = CreateFixedPoint15d(15.0 - $d, $d);

  return $n;
}
function CreateLine(&$account, $debit, $credit, &$description, $date){

  $t = new stdClass();

  $t->account = arraysCopyString($account);
  $t->debit = Copy15d($debit);
  $t->credit = Copy15d($credit);
  $t->description = arraysCopyString($description);
  $t->date = CopyDate($date);

  return $t;
}
function AddTransactionToLedger($ledger, $src){

  $dst = LineToStructure($src);

  AddStructToArray($ledger, $dst);
}
function AddTransactionsToLedger($ledger, &$ts){

  for($i = 0.0; $i < count($ts); $i = $i + 1.0){
    $dst = LineToStructure($ts[$i]);
    AddStructToArray($ledger, $dst);
  }
}
function ValidateAndAddTransactionToLedger($ledger, &$ls){

  $transactions = GetArrayFromStruct($ledger, mb_str_split("transactions"));

  $valid = ValidateTransaction($ls, $ledger);

  if($valid){
    $lines = CreateArray();

    for($i = 0.0; $i < count($ls); $i = $i + 1.0){
      $dst = LineToStructure($ls[$i]);
      AddStructToArray($lines, $dst);
    }

    AddArrayToArray($transactions, $lines);
  }

  return $valid;
}
function GetTransactionFromLedger($ledger, $index){

  $transactions = GetArrayFromStruct($ledger, mb_str_split("transactions"));
  $decimals = GetNumberFromStruct($ledger, mb_str_split("decimals"));

  $dst = ArrayIndexStruct($transactions, $index);

  $t = LineFromStructure($dst, $ledger);

  return $t;
}
function LineToStructure($src){

  $dst = CreateStructure();

  $debitStr = ToString15d($src->debit);
  $creditStr = ToString15d($src->credit);
  $dateStr = DateToStringISO8601($src->date);

  AddStringToStruct($dst, mb_str_split("account"), $src->account);
  AddStringToStruct($dst, mb_str_split("debit"), $debitStr);
  AddStringToStruct($dst, mb_str_split("credit"), $creditStr);
  AddStringToStruct($dst, mb_str_split("date"), $dateStr);
  AddStringToStruct($dst, mb_str_split("description"), $src->description);

  return $dst;
}
function LineFromStructure($src, $ledger){

  $account = GetStringFromStruct($src, mb_str_split("account"));
  $debitStr = GetStringFromStruct($src, mb_str_split("debit"));
  $creditStr = GetStringFromStruct($src, mb_str_split("credit"));
  $dateStr = GetStringFromStruct($src, mb_str_split("date"));
  $description = GetStringFromStruct($src, mb_str_split("description"));

  $debitNumber = CreateNumberFromDecimalString($debitStr);
  $creditNumber = CreateNumberFromDecimalString($creditStr);

  $debit = CreateFixedPointForDynamicLedger($ledger);
  $credit = CreateFixedPointForDynamicLedger($ledger);
  Assign15d($debit, $debitNumber);
  Assign15d($credit, $creditNumber);

  $date = DateFromStringISO8601($dateStr);

  $dst = CreateLine($account, $debit, $credit, $description, $date);

  return $dst;
}
function LedgerDynamicToStatic($src){

  $dst = new stdClass();

  $transactions = GetArrayFromStruct($src, mb_str_split("transactions"));
  $decimals = GetNumberFromStruct($src, mb_str_split("decimals"));
  $ts = ArrayLength($transactions);

  $dst->decimals = $decimals;
  $dst->transactions = array_fill(0, $ts, 0);

  for($i = 0.0; $i < $ts; $i = $i + 1.0){
    $lines = ArrayIndexArray($transactions, $i);
    $ls = ArrayLength($lines);

    $t = new stdClass();
    $t->lines = array_fill(0, $ls, 0);

    for($j = 0.0; $j < $ls; $j = $j + 1.0){
      $line = ArrayIndexStruct($lines, $j);
      $sline = LineFromStructure($line, $src);
      $t->lines[$j] = $sline;
    }

    $dst->transactions[$i] = $t;
  }

  return $dst;
}
function ValidateTransaction(&$ts, $ledger){

  $valid = true;

  if(count($ts) > 0.0){
    $date = $ts[0.0]->date;

    $creditSum = CreateFixedPointForDynamicLedger($ledger);
    $debitSum = CreateFixedPointForDynamicLedger($ledger);

    for($i = 0.0; $i < count($ts) && $valid; $i = $i + 1.0){
      $t = $ts[$i];

      $d = ToNumber15d($t->debit);
      $c = ToNumber15d($t->credit);

      Add15d($creditSum, $creditSum, $t->credit);
      Add15d($debitSum, $debitSum, $t->debit);

      if(DateEquals($date, $t->date) && ($d == 0.0 || $c == 0.0)){
      }else{
        $valid = false;
      }
    }

    if($valid){
      $creditStr = ToString15d($creditSum);
      $debitStr = ToString15d($creditSum);

      $valid = arraysStringsEqual($creditStr, $debitStr);
    }
  }

  return $valid;
}
function ValidateTransactions(&$ts, $invalidIds){

  /* TODO */
  $valid = true;

  return $valid;
}
function ComputeAccountBalance($ledger, &$accountName, $fromDate, $toDate){

  $ts = $ledger->transactions;

  $a = new stdClass();

  $a->name = arraysCopyString($accountName);
  $a->endingBalance = CreateFixedPointForStaticLedger($ledger);
  $a->startingBalance = CreateFixedPointForStaticLedger($ledger);
  $a->from = CopyDate($fromDate);
  $a->to = CopyDate($toDate);
  $a->sumDebit = CreateFixedPointForStaticLedger($ledger);
  $a->sumCredit = CreateFixedPointForStaticLedger($ledger);

  for($i = 0.0; $i < count($ts); $i = $i + 1.0){
    $t = $ts[$i];

    for($j = 0.0; $j < count($t->lines); $j = $j + 1.0){
      $l = $t->lines[$j];

      if(arraysStringsEqual($l->account, $accountName)){

        if(DateLessThan($l->date, $fromDate)){
          Add15d($a->startingBalance, $a->startingBalance, $l->debit);
          Subtract15d($a->startingBalance, $a->startingBalance, $l->credit);
        }else if(DateLessThan($l->date, $toDate)){
          Add15d($a->endingBalance, $a->endingBalance, $l->debit);
          Subtract15d($a->endingBalance, $a->endingBalance, $l->credit);

          Add15d($a->sumDebit, $a->sumDebit, $l->debit);
          Add15d($a->sumCredit, $a->sumCredit, $l->credit);
        }
      }
    }
  }

  Add15d($a->endingBalance, $a->endingBalance, $a->startingBalance);

  return $a;
}
function &AccountToString($account){

  $ll = CreateLinkedListCharacter();

  $diff = Copy15d($account->endingBalance);
  Subtract15d($diff, $diff, $account->startingBalance);

  LinkedListCharactersAddString($ll, $account->name);
  LinkedListCharactersAddString($ll, mb_str_split(": "));
  LinkedListCharactersAddString($ll, FormatToStringWithSymbols15d($account->startingBalance, 2.0, mb_str_split(""), mb_str_split(".")));
  LinkedListCharactersAddString($ll, mb_str_split(" -> "));
  LinkedListCharactersAddString($ll, FormatToStringWithSymbols15d($account->endingBalance, 2.0, mb_str_split(""), mb_str_split(".")));
  LinkedListCharactersAddString($ll, mb_str_split(": "));
  LinkedListCharactersAddString($ll, FormatToStringWithSymbols15d($diff, 2.0, mb_str_split(","), mb_str_split(".")));
  LinkedListCharactersAddString($ll, mb_str_split(" (+"));
  LinkedListCharactersAddString($ll, FormatToStringWithSymbols15d($account->sumDebit, 2.0, mb_str_split(""), mb_str_split(".")));
  LinkedListCharactersAddString($ll, mb_str_split(", -"));
  LinkedListCharactersAddString($ll, FormatToStringWithSymbols15d($account->sumCredit, 2.0, mb_str_split(""), mb_str_split(".")));
  LinkedListCharactersAddString($ll, mb_str_split(")"));

  return LinkedListCharactersToArray($ll);
}
function AddMonthlyAccruals($ledger, $from, $to, $amount, &$fromAccount, &$toAccount){

  $amounts = GetAccrualsWithDates($amount, $from, $to);

  $date = CopyDate($from);
  $date->day = 1.0;

  $c = CreateFixedPointForDynamicLedger($ledger);
  $d = CreateFixedPointForDynamicLedger($ledger);

  for($i = 0.0; $i < count($amounts); $i = $i + 1.0){
    $transaction = array_fill(0, 2.0, 0);

    $accountName = $fromAccount;
    Assign15d($d, $amounts[$i]);
    Assign15d($c, 0.0);
    $desc = mb_str_split("x");
    $transaction[0.0] = CreateLine($accountName, $d, $c, $desc, $date);

    $accountName = $toAccount;
    Assign15d($d, 0.0);
    Assign15d($c, $amounts[$i]);
    $desc = mb_str_split("x");
    $transaction[1.0] = CreateLine($accountName, $d, $c, $desc, $date);

    $valid = ValidateAndAddTransactionToLedger($ledger, $transaction);

    AddMonthsToDate($date, 1.0);
  }
}
function ComputeAccountBalancePrefixAccount($ledger, &$accountNr, $toDate, $debitBalance){

  $prefixL = CreateLinkedListCharacter();
  LinkedListCharactersAddString($prefixL, $accountNr);
  LinkedListCharactersAddString($prefixL, mb_str_split("."));

  $prefixed = LinkedListCharactersToArray($prefixL);

  $ts = $ledger->transactions;

  $balance = CreateFixedPointForStaticLedger($ledger);

  for($i = 0.0; $i < count($ts); $i = $i + 1.0){
    $t = $ts[$i];

    for($j = 0.0; $j < count($t->lines); $j = $j + 1.0){
      $l = $t->lines[$j];

      if(strStartsWith($l->account, $prefixed) || arraysStringsEqual($l->account, $accountNr)){
        if(DateLessThan($l->date, $toDate) || DateEquals($l->date, $toDate)){
          if($debitBalance){
            Add15d($balance, $balance, $l->debit);
            Subtract15d($balance, $balance, $l->credit);
          }else{
            Add15d($balance, $balance, $l->credit);
            Subtract15d($balance, $balance, $l->debit);
          }
        }
      }
    }
  }

  return $balance;
}
function GetIFRSAccountPlan(){

  $ll = CreateLinkedListCharacter();

  /* https://www.ifrs-gaap.com/ifrs-chart-accounts */
  $validRef = CreateBooleanReference(false);

  LinkedListCharactersAddString($ll, mb_str_split("1\tAssets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1\tProperty, plant and equipment\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.1\tLand and land improvements\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.2\tBuildings, structures and improvements\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.3\tMachinery and equipment\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.4\tFixtures and fittings\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.5\tRight of use assets (classified as PP&E)\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.6\tAdditional property, plant and equipment\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1.7\tConstruction in progress\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.2\tInvestment property\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.2.1\tCompleted\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.2.2\tUnder construction or development\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.3\tGoodwill\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4\tIntangible assets excluding goodwill\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.1\tIntellectual property\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.2\tComputer software\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.3\tTrade and distribution assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.4\tContracts and rights\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.5\tRight of use assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.6\tCrypto assets (classified as intangible)\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.7\tAdditional intangible assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.4.8\tAcquisition in progress\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.5\tFinancial assets and investments\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.5.1\tNon-derivative financial assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.5.2\tDerivative financial assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.5.3\tAdditional financial assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.5.4\tCrypto assets (classified as financial assets)\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.6\tInventories\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.6.1\tMerchandise\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.6.2\tRaw materials and production supplies\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.6.3\tWork in progress\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.6.4\tFinished goods\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.6.5\tOther inventories\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.7\tPrepayments and accrued income\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.7.1\tPrepayments\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.7.2\tAccrued income\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.7.3\tService provider work in process (not classified as inventory)\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.7.4\tAdditional assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.8\tReceivables and contracts\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.8.1\tLoans and receivables\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.8.2\tContracts with customers\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.8.3\tNontrade and other receivables\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.9\tTax assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.9.1\tTax assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.9.2\tDeferred tax assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.9.3\tOther tax assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.1\tAgricultural biological assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.10.1\tBearer plants\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.10.2\tAnimals\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.10.3\tOther agricultural assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.11\tCash and cash equivalents\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.11.1\tCash\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.11.2\tCash equivalents\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("1.11.3\tRestricted cash and financial assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2\tEquity\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.1\tTotal equity attributable to owners of parent\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.1.1\tIssued capital\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.1.2\tAdditional item paid-in capital\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.1.3\tPartner\'s capital\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.1.4\tMember\'s equity\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.1.5\tOther equity interest\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.2\tRetained earnings\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.2.3\tIn suspense\tZero\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.3\tAccumulated other comprehensive income\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.3.2\tMiscellaneous equity\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.4\tOwners equity (non-shareholder)\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("2.5\tNon-controlling interests\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3\tLiabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.1\tTrade and other payables\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.1.1\tTrade payables\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.1.2\tDividend payables\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.1.3\tInterest payable\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.1.4\tOther payables\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.2\tProvisions\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.2.1\tCustomer related provisions\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.2.2\tLitigation and regulatory\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.2.3\tAdditional provisions\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3\tOther financial liabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3.1\tNotes payable\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3.2\tLoans received\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3.3\tBonds (debentures)\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3.4\tOther debts and borrowings\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3.5\tLease obligations\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.3.6\tDerivative financial liabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.4.1\tAccruals\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.4.2\tDeferred income and refund liabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.4.3\tAccrued taxes other than payroll\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("3.4.4\tAdditional liabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4\tRevenue\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.1\tRecognized point of time\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.1.1\tGoods\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.1.2\tServices\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.2\tRecognized over time\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.2.1\tProducts and projects\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.2.2\tServices\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.3\tAdjustments\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.3.1\tVariable consideration\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.3.2\tConsideration paid payable to customers\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("4.3.3\tOther adjustments\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5\tExpenses\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1\tExpenses (classified by nature)\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1.1\tMaterial and merchandise\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1.2\tEmployee benefits expense\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1.3\tServices expense\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1.4\tRent, depreciation, amortization and depletion\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.1.6\tOther work performed by entity and capitalized\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.2\tExpenses (classified by function)\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.2.1\tCost of sales\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("5.2.2\tSelling, general and administrative expense\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6\tOther non-operating income and expenses\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6.1\tOther revenue and expenses\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6.1.1\tOther revenue\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6.1.2\tOther expenses\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6.2\tGains and losses\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6.3\tTaxes other than income and payroll and fees\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("6.4\tTax income (expense)\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7\tIntercompany and related party accounts\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.1\tIntercompany and related party assets\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.1.1\tIntercompany balances eliminated in consolidation\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.1.2\tRelated party balances reported or disclosed\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.1.3\tIntercompany investments\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.2\tIntercompany and related party liabilities\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.2.2\tRelated party balances reported or disclosed\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.3\tIntercompany and related party income and expense\tDr or (Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.3.1\tIntercompany and related party income\t(Cr)\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.3.2\tIntercompany and related party expenses\tDr\n"));
  LinkedListCharactersAddString($ll, mb_str_split("7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n"));

  $accountPlanString = LinkedListCharactersToArray($ll);

  FreeLinkedListCharacter($ll);

  return ParseAccountPlanString($accountPlanString, $validRef);
}
function ParseAccountPlanString(&$accountPlanString, $valid){

  $ap = new stdClass();

  $accountPlanString = strTrim($accountPlanString);
  $lines = strSplitByCharacter($accountPlanString, "\n");

  $ap->accountDefinitions = array_fill(0, count($lines), 0);

  for($i = 0.0; $i < count($lines); $i = $i + 1.0){
    $line = $lines[$i]->string;
    /*System.out.println(line); */
    $parts = strSplitByCharacter($line, "\t");

    $ad = new stdClass();

    $ad->accountName = $parts[1.0]->string;
    $ad->number = $parts[0.0]->string;
    if(arraysStringsEqual($parts[2.0]->string, mb_str_split("(Cr)"))){
      $ad->debitBalance = false;
    }else{
      $ad->debitBalance = true;
    }
    $ad->role = mb_str_split("");
    if(arraysStringsEqual($ad->number, mb_str_split("1"))){
      $ad->role = mb_str_split("Assets");
    }else if(arraysStringsEqual($ad->number, mb_str_split("2"))){
      $ad->role = mb_str_split("Equities");
    }else if(arraysStringsEqual($ad->number, mb_str_split("3"))){
      $ad->role = mb_str_split("Liabilities");
    }else if(arraysStringsEqual($ad->number, mb_str_split("4"))){
      $ad->role = mb_str_split("Revenue");
    }else if(arraysStringsEqual($ad->number, mb_str_split("5"))){
      $ad->role = mb_str_split("Expenses");
    }

    $ap->accountDefinitions[$i] = $ad;
  }

  return $ap;
}
function ComputeAccountBalances($sledger, $depth, $date, $balanceSheet){

  $balanceSheet->data = CreateNewStructData();
  $success = true;

  $foundRef = CreateBooleanReference(false);

  $accountPlan = $sledger->accountPlan;

  $assetsDef = FindAccountWithRole($accountPlan, mb_str_split("Assets"), $foundRef);
  $success = $success && $foundRef->booleanValue;
  $liabilitiesDef = FindAccountWithRole($accountPlan, mb_str_split("Liabilities"), $foundRef);
  $success = $success && $foundRef->booleanValue;
  $equitiesDef = FindAccountWithRole($accountPlan, mb_str_split("Equities"), $foundRef);
  $success = $success && $foundRef->booleanValue;
  $revenueDef = FindAccountWithRole($accountPlan, mb_str_split("Revenue"), $foundRef);
  $success = $success && $foundRef->booleanValue;
  $expensesDef = FindAccountWithRole($accountPlan, mb_str_split("Expenses"), $foundRef);
  $success = $success && $foundRef->booleanValue;

  if($success){
    $assetsBalance = ComputeAccountBalancePrefixAccount($sledger, $assetsDef->number, $date, $assetsDef->debitBalance);
    $liabilitiesBalance = ComputeAccountBalancePrefixAccount($sledger, $liabilitiesDef->number, $date, $liabilitiesDef->debitBalance);

    /* TODO: This must be for a period */
    $revenueBalanace = ComputeAccountBalancePrefixAccount($sledger, $revenueDef->number, $date, $revenueDef->debitBalance);
    $expensesBalance = ComputeAccountBalancePrefixAccount($sledger, $expensesDef->number, $date, $expensesDef->debitBalance);
    $resultBalance = CreateFixedPointForStaticLedger($sledger);
    Subtract15d($resultBalance, $revenueBalanace, $expensesBalance);
    $balanceStr = FormatToStringWithSymbols15d($resultBalance, 2.0, mb_str_split(""), mb_str_split("."));
    AddStringToStruct($balanceSheet->data->structure, mb_str_split("result"), $balanceStr);

    $equitiesBalance = ComputeAccountBalancePrefixAccount($sledger, $equitiesDef->number, $date, $equitiesDef->debitBalance);
    Add15d($equitiesBalance, $equitiesBalance, $resultBalance);

    /* Compute accounts */
    $accounts = CreateArray();

    for($i = 0.0; $i < count($accountPlan->accountDefinitions); $i = $i + 1.0){
      $accountDef = $accountPlan->accountDefinitions[$i];

      $parts = strSplitByCharacter($accountDef->number, ".");

      if(count($parts) <= $depth + 1.0){
        $account = CreateStructure();

        $balance = ComputeAccountBalancePrefixAccount($sledger, $accountDef->number, $date, $accountDef->debitBalance);

        $balanceStr = FormatToStringWithSymbols15d($balance, 2.0, mb_str_split(""), mb_str_split("."));

        AddStringToStruct($account, mb_str_split("number"), $accountDef->number);
        AddStringToStruct($account, mb_str_split("name"), $accountDef->accountName);
        AddStringToStruct($account, mb_str_split("balance"), $balanceStr);
        AddNumberToStruct($account, mb_str_split("depth"), count($parts) - 1.0);

        AddStructToArray($accounts, $account);
      }
    }

    AddArrayToStruct($balanceSheet->data->structure, mb_str_split("accounts"), $accounts);

    /* End conclusion */
    $balanceStr = FormatToStringWithSymbols15d($assetsBalance, 2.0, mb_str_split(""), mb_str_split("."));
    AddStringToStruct($balanceSheet->data->structure, mb_str_split("assets"), $balanceStr);

    $sum = CreateFixedPointForStaticLedger($sledger);
    Add15d($sum, $liabilitiesBalance, $equitiesBalance);
    $balanceStr = FormatToStringWithSymbols15d($sum, 2.0, mb_str_split(""), mb_str_split("."));
    AddStringToStruct($balanceSheet->data->structure, mb_str_split("liabilitiesAndEquity"), $balanceStr);

    $isBalanced = Equals15d($sum, $assetsBalance);
    AddBooleanToStruct($balanceSheet->data->structure, mb_str_split("balanced"), $isBalanced);

    $dateStr = DateToStringISO8601($date);
    AddStringToStruct($balanceSheet->data->structure, mb_str_split("date"), $dateStr);
  }

  return $success;
}
function &AccountBalancesToString($balanceSheet){

  $ll = CreateLinkedListCharacter();

  /* Print accounts */
  $accounts = GetArrayFromStruct($balanceSheet, mb_str_split("accounts"));

  for($i = 0.0; $i < ArrayLength($accounts); $i = $i + 1.0){
    $account = ArrayIndexStruct($accounts, $i);

    $accountNumber = GetStringFromStruct($account, mb_str_split("number"));
    $accountName = GetStringFromStruct($account, mb_str_split("name"));
    $balanceStr = GetStringFromStruct($account, mb_str_split("balance"));
    $depth = GetNumberFromStruct($account, mb_str_split("depth"));

    for($j = 0.0; $j < $depth; $j = $j + 1.0){
      LinkedListCharactersAddString($ll, mb_str_split("  "));
    }

    LinkedListCharactersAddString($ll, $accountNumber);
    LinkedListCharactersAddString($ll, mb_str_split(". "));
    LinkedListCharactersAddString($ll, $accountName);
    LinkedListCharactersAddString($ll, mb_str_split(": "));
    LinkedListCharactersAddString($ll, $balanceStr);
    LinkedListCharactersAddString($ll, mb_str_split("\n"));
  }

  /* End conclusion */
  LinkedListCharactersAddString($ll, mb_str_split("\n"));

  LinkedListCharactersAddString($ll, mb_str_split("Result: "));
  $balanceStr = GetStringFromStruct($balanceSheet, mb_str_split("result"));
  LinkedListCharactersAddString($ll, $balanceStr);
  LinkedListCharactersAddString($ll, mb_str_split("\n"));

  LinkedListCharactersAddString($ll, mb_str_split("Assets: "));
  $balanceStr = GetStringFromStruct($balanceSheet, mb_str_split("assets"));
  LinkedListCharactersAddString($ll, $balanceStr);
  LinkedListCharactersAddString($ll, mb_str_split("\n"));

  LinkedListCharactersAddString($ll, mb_str_split("Liabilities + Equities: "));
  $balanceStr = GetStringFromStruct($balanceSheet, mb_str_split("liabilitiesAndEquity"));
  LinkedListCharactersAddString($ll, $balanceStr);
  LinkedListCharactersAddString($ll, mb_str_split("\n"));

  $isBalanced = GetBooleanFromStruct($balanceSheet, mb_str_split("balanced"));
  LinkedListCharactersAddString($ll, mb_str_split("Balance: "));
  if($isBalanced){
    LinkedListCharactersAddString($ll, mb_str_split("true"));
  }else{
    LinkedListCharactersAddString($ll, mb_str_split("false"));
  }
  LinkedListCharactersAddString($ll, mb_str_split("\n"));

  return LinkedListCharactersToArray($ll);
}
function FindAccountWithRole($accountPlan, &$role, $foundRef){

  $ad = new stdClass();

  $done = false;
  for($i = 0.0; $i < count($accountPlan->accountDefinitions) &&  !$done ; $i = $i + 1.0){
    $ad = $accountPlan->accountDefinitions[$i];
    if(arraysStringsEqual($ad->role, $role)){
      $done = true;
    }
  }

  $foundRef->booleanValue = $done;

  return $ad;
}
function CreateAccountDefinition(&$name, &$number, &$role, $debitBalance){

  $def = new stdClass();
  $def->accountName = $name;
  $def->number = $number;
  $def->role = $role;
  $def->debitBalance = $debitBalance;

  return $def;
}
function ComputeBalanceDiffs($sledger, $balances){

  $first = ArrayIndexStruct($balances, 0.0);
  $accountsO = GetArrayFromStruct($first, mb_str_split("accounts"));

  for($j = 0.0; $j < ArrayLength($accountsO); $j = $j + 1.0){
    for($i = 1.0; $i < ArrayLength($balances); $i = $i + 1.0){
      $balance1 = ArrayIndexStruct($balances, $i - 1.0);
      $balance2 = ArrayIndexStruct($balances, $i);
      $accounts1 = GetArrayFromStruct($balance1, mb_str_split("accounts"));
      $accounts2 = GetArrayFromStruct($balance2, mb_str_split("accounts"));

      $account1 = ArrayIndexStruct($accounts1, $j);
      $account2 = ArrayIndexStruct($accounts2, $j);

      $b1 = GetStringFromStruct($account1, mb_str_split("balance"));
      $b2 = GetStringFromStruct($account2, mb_str_split("balance"));

      $f1 = CreateFixedPointForStaticLedger($sledger);
      $f2 = CreateFixedPointForStaticLedger($sledger);
      $diff = CreateFixedPointForStaticLedger($sledger);

      Assign15d($f1, CreateNumberFromDecimalString($b1));
      Assign15d($f2, CreateNumberFromDecimalString($b2));

      Subtract15d($diff, $f2, $f1);

      $diffStr = FormatToStringWithSymbols15d($diff, $sledger->decimals, mb_str_split(""), mb_str_split("."));

      /*System.out.println(diffStr); */
      if($i == 1.0){
        AddStringToStruct($account1, mb_str_split("change"), mb_str_split("0.00"));
      }
      AddStringToStruct($account2, mb_str_split("change"), $diffStr);
    }
  }

  for($i = 1.0; $i < ArrayLength($balances); $i = $i + 1.0){
    $balance1 = ArrayIndexStruct($balances, $i - 1.0);
    $balance2 = ArrayIndexStruct($balances, $i);
    $b1 = GetStringFromStruct($balance1, mb_str_split("result"));
    $b2 = GetStringFromStruct($balance2, mb_str_split("result"));

    $f1 = CreateFixedPointForStaticLedger($sledger);
    $f2 = CreateFixedPointForStaticLedger($sledger);
    $diff = CreateFixedPointForStaticLedger($sledger);

    Assign15d($f1, CreateNumberFromDecimalString($b1));
    Assign15d($f2, CreateNumberFromDecimalString($b2));

    Subtract15d($diff, $f2, $f1);

    $diffStr = FormatToStringWithSymbols15d($diff, $sledger->decimals, mb_str_split(""), mb_str_split("."));

    /*System.out.println(diffStr); */
    if($i == 1.0){
      AddStringToStruct($balance1, mb_str_split("rchange"), mb_str_split("0.00"));
    }
    AddStringToStruct($balance2, mb_str_split("rchange"), $diffStr);
  }
}
function &BalancesArrayToHTML($balances, $includeBalance, $includeDiff){

  $ll = CreateLinkedListCharacter();

  LinkedListCharactersAddString($ll, mb_str_split("<html>"));
  LinkedListCharactersAddString($ll, mb_str_split("<body>"));
  LinkedListCharactersAddString($ll, mb_str_split("<table>"));

  /* Headers */
  LinkedListCharactersAddString($ll, mb_str_split("<tr>"));

  LinkedListCharactersAddString($ll, mb_str_split("<td>"));
  LinkedListCharactersAddString($ll, mb_str_split("</td>"));
  LinkedListCharactersAddString($ll, mb_str_split("<td>"));
  LinkedListCharactersAddString($ll, mb_str_split("</td>"));

  for($i = 0.0; $i < ArrayLength($balances); $i = $i + 1.0){
    $balance = ArrayIndexStruct($balances, $i);
    $dateStr = GetStringFromStruct($balance, mb_str_split("date"));
    $dateStr = strSubstring($dateStr, 0.0, 7.0);

    LinkedListCharactersAddString($ll, mb_str_split("<td>"));
    LinkedListCharactersAddString($ll, $dateStr);
    LinkedListCharactersAddString($ll, mb_str_split("</td>"));
  }

  LinkedListCharactersAddString($ll, mb_str_split("</tr>"));

  /* Each account */
  $first = ArrayIndexStruct($balances, 0.0);
  $accounts = GetArrayFromStruct($first, mb_str_split("accounts"));
  for($j = 0.0; $j < ArrayLength($accounts); $j = $j + 1.0){
    LinkedListCharactersAddString($ll, mb_str_split("<tr>"));

    $account = ArrayIndexStruct($accounts, $j);
    $name = GetStringFromStruct($account, mb_str_split("name"));
    $number = GetStringFromStruct($account, mb_str_split("number"));

    LinkedListCharactersAddString($ll, mb_str_split("<td>"));
    LinkedListCharactersAddString($ll, $number);
    LinkedListCharactersAddString($ll, mb_str_split("</td>"));

    LinkedListCharactersAddString($ll, mb_str_split("<td>"));
    LinkedListCharactersAddString($ll, $name);
    LinkedListCharactersAddString($ll, mb_str_split("</td>"));

    for($i = 0.0; $i < ArrayLength($balances); $i = $i + 1.0){
      $balance = ArrayIndexStruct($balances, $i);
      $accounts = GetArrayFromStruct($balance, mb_str_split("accounts"));
      $account = ArrayIndexStruct($accounts, $j);
      $balanceStr = GetStringFromStruct($account, mb_str_split("balance"));
      $changeStr = GetStringFromStruct($account, mb_str_split("change"));

      LinkedListCharactersAddString($ll, mb_str_split("<td style=\"text-align: right;\">"));

      if($includeBalance && $includeDiff){
        LinkedListCharactersAddString($ll, $balanceStr);
        LinkedListCharactersAddString($ll, mb_str_split("<br><small style=\"color: grey\">"));
        LinkedListCharactersAddString($ll, $changeStr);
        LinkedListCharactersAddString($ll, mb_str_split("</small>"));
      }else if($includeBalance){
        LinkedListCharactersAddString($ll, $balanceStr);
      }else if($includeDiff){
        LinkedListCharactersAddString($ll, $changeStr);
      }

      LinkedListCharactersAddString($ll, mb_str_split("</td>"));
    }

    LinkedListCharactersAddString($ll, mb_str_split("</tr>"));
  }

  /* Result */
  LinkedListCharactersAddString($ll, mb_str_split("<tr>"));

  LinkedListCharactersAddString($ll, mb_str_split("<td>"));
  LinkedListCharactersAddString($ll, mb_str_split(""));
  LinkedListCharactersAddString($ll, mb_str_split("</td>"));

  LinkedListCharactersAddString($ll, mb_str_split("<td>"));
  LinkedListCharactersAddString($ll, mb_str_split("Result"));
  LinkedListCharactersAddString($ll, mb_str_split("</td>"));

  for($i = 0.0; $i < ArrayLength($balances); $i = $i + 1.0){
    $balance = ArrayIndexStruct($balances, $i);
    $balanceStr = GetStringFromStruct($balance, mb_str_split("result"));
    $changeStr = GetStringFromStruct($balance, mb_str_split("rchange"));

    LinkedListCharactersAddString($ll, mb_str_split("<td style=\"text-align: right;\">"));

    if($includeBalance && $includeDiff){
      LinkedListCharactersAddString($ll, $balanceStr);
      LinkedListCharactersAddString($ll, mb_str_split("<br><small style=\"color: grey\">"));
      LinkedListCharactersAddString($ll, $changeStr);
      LinkedListCharactersAddString($ll, mb_str_split("</small>"));
    }else if($includeBalance){
      LinkedListCharactersAddString($ll, $balanceStr);
    }else if($includeDiff){
      LinkedListCharactersAddString($ll, $changeStr);
    }

    LinkedListCharactersAddString($ll, mb_str_split("</td>"));
  }

  LinkedListCharactersAddString($ll, mb_str_split("</tr>"));

  /* Footer */
  LinkedListCharactersAddString($ll, mb_str_split("</table>"));
  LinkedListCharactersAddString($ll, mb_str_split("</body>"));
  LinkedListCharactersAddString($ll, mb_str_split("</html>"));

  return LinkedListCharactersToArray($ll);
}
function CreateLineFromScript($ledger, &$script, $date){

  $c = CreateFixedPointForDynamicLedger($ledger);
  $d = CreateFixedPointForDynamicLedger($ledger);

  $parts = strSplitByCharacter($script, ",");

  for($i = 0.0; $i < count($parts); $i = $i + 1.0){
    $parts[$i]->string = strTrim($parts[$i]->string);
  }

  $line = new stdClass();

  $n = CreateNumberFromDecimalString($parts[2.0]->string);

  $line->date = $date;
  if(arraysStringsEqual($parts[0.0]->string, mb_str_split("Debit"))){
    Assign15d($d, $n);
    Assign15d($c, 0.0);
  }else if(arraysStringsEqual($parts[0.0]->string, mb_str_split("Credit"))){
    Assign15d($d, 0.0);
    Assign15d($c, $n);
  }

  $line = CreateLine($parts[1.0]->string, $d, $c, $parts[3.0]->string, $date);

  return $line;
}
function test(){

  $failures = CreateNumberReference(0.0);

  TestBasicAccounting($failures);
  TestAccruals($failures);
  TestIFRSAccountPlan($failures);

  return $failures->numberValue;
}
function TestIFRSAccountPlan($failures){
  GetIFRSAccountPlan();
}
function TestBasicAccounting($failures){

  $ledger = CreateLedger(2.0);

  /*c = CreateFixedPointForDynamicLedger(ledger); */
  /*d = CreateFixedPointForDynamicLedger(ledger); */
  /* Transaction 1: */
  $transaction = array_fill(0, 2.0, 0);
  /*date = CreateDate(2026d, 2d, 18d); */
  $date = DateFromStringISO8601(mb_str_split("2026-02-18"));

  /* Debit, 100, 1000, l1, 2026-02-18 */
  /*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
         */
  $transaction[0.0] = CreateLineFromScript($ledger, mb_str_split("Debit, 1000, 100, l1"), $date);

  /* Credit, 100, 2000, l2, 2026-02-18 */
  /*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
         */
  $transaction[1.0] = CreateLineFromScript($ledger, mb_str_split("Credit, 2000, 100, l2"), $date);

  $valid = ValidateAndAddTransactionToLedger($ledger, $transaction);

  AssertTrue($valid, $failures);

  /* Compute */
  $sledger = LedgerDynamicToStatic($ledger);

  $accountName = mb_str_split("1000");
  $from = DateFromStringISO8601(mb_str_split("2026-02-17"));
  $to = DateFromStringISO8601(mb_str_split("2026-02-19"));
  $account = ComputeAccountBalance($sledger, $accountName, $from, $to);

  $accountStr = AccountToString($account);

  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)"), $failures);
}
function TestAccruals($failures){

  $ledger = CreateLedger(2.0);

  $c = CreateFixedPointForDynamicLedger($ledger);
  $d = CreateFixedPointForDynamicLedger($ledger);

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
  $transaction = array_fill(0, 2.0, 0);
  $date = DateFromStringISO8601(mb_str_split("2025-09-17"));
  $transaction[0.0] = CreateLineFromScript($ledger, mb_str_split("Debit, 1.8.1, 125, x"), $date);
  $transaction[1.0] = CreateLineFromScript($ledger, mb_str_split("Credit, 3.4.2, 125, x"), $date);
  $valid = ValidateAndAddTransactionToLedger($ledger, $transaction);
  AssertTrue($valid, $failures);

  /* Transaction: Invoice paid */
  $transaction = array_fill(0, 2.0, 0);
  $date = DateFromStringISO8601(mb_str_split("2025-10-01"));
  $transaction[0.0] = CreateLineFromScript($ledger, mb_str_split("Debit, 1.11.1, 125, x"), $date);
  $transaction[1.0] = CreateLineFromScript($ledger, mb_str_split("Credit, 1.8.1, 125, x"), $date);
  $valid = ValidateAndAddTransactionToLedger($ledger, $transaction);
  AssertTrue($valid, $failures);

  /* Transaction: Renewal paid */
  $transaction = array_fill(0, 2.0, 0);
  $date = DateFromStringISO8601(mb_str_split("2025-11-08"));
  $transaction[0.0] = CreateLineFromScript($ledger, mb_str_split("Debit, 1.7.1, 112.50, x"), $date);
  $transaction[1.0] = CreateLineFromScript($ledger, mb_str_split("Credit, 1.11.1, 112.50, x"), $date);
  $valid = ValidateAndAddTransactionToLedger($ledger, $transaction);
  AssertTrue($valid, $failures);

  /* Accruals income */
  $from = DateFromStringISO8601(mb_str_split("2025-12-06"));
  $to = DateFromStringISO8601(mb_str_split("2026-12-05"));
  AddMonthlyAccruals($ledger, $from, $to, 125.0, mb_str_split("3.4.2"), mb_str_split("4.1.2"));

  /* Accruals cost */
  $from = DateFromStringISO8601(mb_str_split("2025-12-06"));
  $to = DateFromStringISO8601(mb_str_split("2026-12-05"));
  AddMonthlyAccruals($ledger, $from, $to, 112.50, mb_str_split("5.1.3"), mb_str_split("1.7.1"));

  /* Compute */
  $sledger = LedgerDynamicToStatic($ledger);

  $from = DateFromStringISO8601(mb_str_split("2027-01-01"));
  $to = DateFromStringISO8601(mb_str_split("2027-01-01"));

  $account = ComputeAccountBalance($sledger, mb_str_split("5.1.3"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("4.1.2"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("1.8.1"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("3.4.2"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("1.11.1"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("1.7.1"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), $failures);

  /*System.out.println(""); */
  /* In between */
  $from = DateFromStringISO8601(mb_str_split("2026-06-15"));
  $to = DateFromStringISO8601(mb_str_split("2026-06-16"));

  $account = ComputeAccountBalance($sledger, mb_str_split("5.1.3"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("4.1.2"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("1.8.1"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("3.4.2"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("1.11.1"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)"), $failures);

  $account = ComputeAccountBalance($sledger, mb_str_split("1.7.1"), $from, $to);
  $accountStr = AccountToString($account);
  /*System.out.println(accountStr); */
  AssertStringEquals($accountStr, mb_str_split("1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)"), $failures);

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

  $sledger->accountPlan = GetIFRSAccountPlan();

  $to = DateFromStringISO8601(mb_str_split("2026-02-16"));
  $balanceSheetRef = new stdClass();
  $success = ComputeAccountBalances($sledger, 2.0, $to, $balanceSheetRef);
  $accountSummaryStr = AccountBalancesToString($balanceSheetRef->data->structure);
  AssertTrue($success, $failures);
  /*System.out.println(accountSummaryStr); */
  /* Compute monthly table */
  $to = DateFromStringISO8601(mb_str_split("2025-08-01"));
  $message = new stdClass();
  AddDaysToDate($to, -1.0, $message);
  $balances = CreateArray();
  for($i = 0.0; $i < 12.0 + 6.0; $i = $i + 1.0){
    AddDaysToDate($to, 1.0, $message);
    AddMonthsToDate($to, 1.0);
    AddDaysToDate($to, -1.0, $message);

    $balanceSheetRef = new stdClass();
    $success = ComputeAccountBalances($sledger, 1.0, $to, $balanceSheetRef);

    if($success){
      AddStructToArray($balances, $balanceSheetRef->data->structure);
    }
  }
  ComputeBalanceDiffs($sledger, $balances);

  $html = BalancesArrayToHTML($balances, true, false);

  /*StringToFile("x.html", html); */
  $html = BalancesArrayToHTML($balances, false, true);

  /*StringToFile("x-diff.html", html); */
  $html = BalancesArrayToHTML($balances, true, true);
}
function CreateBooleanReference($value){

  $ref = new stdClass();
  $ref->booleanValue = $value;

  return $ref;
}
function CreateBooleanArrayReference(&$value){

  $ref = new stdClass();
  $ref->booleanArray = $value;

  return $ref;
}
function CreateBooleanArrayReferenceLengthValue($length, $value){

  $ref = new stdClass();
  $ref->booleanArray = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $ref->booleanArray[$i] = $value;
  }

  return $ref;
}
function FreeBooleanArrayReference($booleanArrayReference){
  unset($booleanArrayReference->booleanArray);
  unset($booleanArrayReference);
}
function CreateCharacterReference($value){

  $ref = new stdClass();
  $ref->characterValue = $value;

  return $ref;
}
function CreateNumberReference($value){

  $ref = new stdClass();
  $ref->numberValue = $value;

  return $ref;
}
function CreateNumberArrayReference(&$value){

  $ref = new stdClass();
  $ref->numberArray = $value;

  return $ref;
}
function CreateNumberArrayReferenceLengthValue($length, $value){

  $ref = new stdClass();
  $ref->numberArray = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $ref->numberArray[$i] = $value;
  }

  return $ref;
}
function FreeNumberArrayReference($numberArrayReference){
  unset($numberArrayReference->numberArray);
  unset($numberArrayReference);
}
function CreateStringReference(&$value){

  $ref = new stdClass();
  $ref->string = $value;

  return $ref;
}
function CreateStringReferenceLengthValue($length, $value){

  $ref = new stdClass();
  $ref->string = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $ref->string[$i] = $value;
  }

  return $ref;
}
function FreeStringReference($stringReference){
  unset($stringReference->string);
  unset($stringReference);
}
function CreateStringArrayReference(&$strings){

  $ref = new stdClass();
  $ref->stringArray = $strings;

  return $ref;
}
function CreateStringArrayReferenceLengthValue($length, &$value){

  $ref = new stdClass();
  $ref->stringArray = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $ref->stringArray[$i] = CreateStringReference($value);
  }

  return $ref;
}
function FreeStringArrayReference($stringArrayReference){

  for($i = 0.0; $i < count($stringArrayReference->stringArray); $i = $i + 1.0){
    unset($stringArrayReference->stringArray[$i]);
  }
  unset($stringArrayReference->stringArray);
  unset($stringArrayReference);
}
function CreateDate($year, $month, $day){

  $date = new stdClass();

  $date->year = $year;
  $date->month = $month;
  $date->day = $day;

  return $date;
}
function IsLeapYearWithCheck($year, $isLeapYearReference, $message){

  if($year >= 1752.0){
    $success = true;
    $itIsLeapYear = IsLeapYear($year);
  }else{
    $success = false;
    $itIsLeapYear = false;
    $message->string = mb_str_split("Gregorian calendar was not in general use.");
  }

  $isLeapYearReference->booleanValue = $itIsLeapYear;
  return $success;
}
function IsLeapYear($year){

  if(DivisibleBy($year, 4.0)){
    if(DivisibleBy($year, 100.0)){
      if(DivisibleBy($year, 400.0)){
        $itIsLeapYear = true;
      }else{
        $itIsLeapYear = false;
      }
    }else{
      $itIsLeapYear = true;
    }
  }else{
    $itIsLeapYear = false;
  }

  return $itIsLeapYear;
}
function DayToDateWithCheck($dayNr, $dateReference, $message){

  if($dayNr >= -79623.0){
    $date = new stdClass();
    $remainder = new stdClass();
    $remainder->numberValue = $dayNr + 79623.0;
    /* Days since 1752-01-01. Day 0: Thursday, 1970-01-01 */
    /* Find year. */
    $date->year = GetYearFromDayNr($remainder->numberValue, $remainder);

    /* Find month. */
    $date->month = GetMonthFromDayNr($remainder->numberValue, $date->year, $remainder);

    /* Find day. */
    $date->day = 1.0 + $remainder->numberValue;

    $dateReference->date = $date;
    $success = true;
  }else{
    $success = false;
    $message->string = mb_str_split("Gregorian calendar was not in general use before 1752.");
  }

  return $success;
}
function DayToDate($dayNr){

  $dateRef = new stdClass();
  $message = new stdClass();

  $success = DayToDateWithCheck($dayNr, $dateRef, $message);
  if($success){
    $date = $dateRef->date;
    unset($dateRef);
    FreeStringReference($message);
  }else{
    $date = CreateDate(1970.0, 1.0, 1.0);
  }

  return $date;
}
function GetMonthFromDayNrWithCheck($dayNr, $year, $monthReference, $remainderReference, $message){

  if($dayNr >= -79623.0){
    $month = GetMonthFromDayNr($dayNr, $year, $remainderReference);
    $monthReference->numberValue = $month;
    $success = true;
  }else{
    $success = false;
    $message->string = mb_str_split("Gregorian calendar not in general use before 1752.");
  }

  return $success;
}
function GetMonthFromDayNr($dayNr, $year, $remainderReference){

  $daysInMonth = GetDaysInMonth($year);
  $done = false;
  $month = 1.0;

  for(;  !$done ; ){
    if($dayNr >= $daysInMonth[$month]){
      $dayNr = $dayNr - $daysInMonth[$month];
      $month = $month + 1.0;
    }else{
      $done = true;
    }
  }
  $remainderReference->numberValue = $dayNr;

  return $month;
}
function GetYearFromDayNrWithCheck($dayNr, $yearReference, $remainder, $message){

  if($dayNr >= 0.0){
    $success = true;
    $year = GetYearFromDayNr($dayNr, $remainder);
    $yearReference->numberValue = $year;
  }else{
    $success = false;
    $message->string = mb_str_split("Day number must be 0 or higher. 0 is 1752-01-01.");
  }

  return $success;
}
function GetYearFromDayNr($dayNr, $remainder){

  $done = false;
  $year = 1752.0;

  for(;  !$done ; ){
    if(IsLeapYear($year)){
      $nrOfDays = 366.0;
    }else{
      $nrOfDays = 365.0;
    }

    if($dayNr >= $nrOfDays){
      /* First day is 0. */
      $dayNr = $dayNr - $nrOfDays;
      $year = $year + 1.0;
    }else{
      $done = true;
    }
  }
  $remainder->numberValue = $dayNr;

  return $year;
}
function DaysBetweenDates($A, $B){

  $daysA = DateToDays($A);
  $daysB = DateToDays($B);

  $daysBetween = $daysB - $daysA;

  return $daysBetween;
}
function GetDaysInMonthWithCheck($year, $daysInMonthReference, $message){

  $date = CreateDate($year, 1.0, 1.0);

  $success = IsValidDate($date, $message);
  if($success){
    $daysInMonth = GetDaysInMonth($year);

    $daysInMonthReference->numberArray = $daysInMonth;
  }

  return $success;
}
function &GetDaysInMonth($year){

  $daysInMonth = array_fill(0, 1.0 + 12.0, 0);

  $daysInMonth[0.0] = 0.0;
  $daysInMonth[1.0] = 31.0;

  if(IsLeapYear($year)){
    $daysInMonth[2.0] = 29.0;
  }else{
    $daysInMonth[2.0] = 28.0;
  }
  $daysInMonth[3.0] = 31.0;
  $daysInMonth[4.0] = 30.0;
  $daysInMonth[5.0] = 31.0;
  $daysInMonth[6.0] = 30.0;
  $daysInMonth[7.0] = 31.0;
  $daysInMonth[8.0] = 31.0;
  $daysInMonth[9.0] = 30.0;
  $daysInMonth[10.0] = 31.0;
  $daysInMonth[11.0] = 30.0;
  $daysInMonth[12.0] = 31.0;

  return $daysInMonth;
}
function DateToDaysWithCheck($date, $dayNumberReferenceReference, $message){

  $success = IsValidDate($date, $message);
  if($success){
    $days = DateToDays($date);
    $dayNumberReferenceReference->numberValue = $days;
  }

  return $success;
}
function DateToDays($date){

  /* Day 1752-01-01 */
  $days = -79623.0;

  $days = $days + DaysInYears($date->year);
  $days = $days + DaysInMonths($date->month, $date->year);
  $days = $days + $date->day - 1.0;

  return $days;
}
function DateToWeekdayNumberWithCheck($date, $weekDayNumberReference, $message){

  $success = IsValidDate($date, $message);
  if($success){
    $weekDay = DateToWeekdayNumber($date);
    $weekDayNumberReference->numberValue = $weekDay;
  }

  return $success;
}
function DateToWeekdayNumber($date){

  $days = DateToDays($date);

  $days = $days + 79623.0;
  $days = $days + 5.0;

  $weekDay = $days%7.0 + 1.0;

  return $weekDay;
}
function DateToWeeknumber($date, $yearRef){

  $week1Start = CopyDate($date);

  $week1Start->day = 1.0;
  $week1Start->month = 1.0;
  $weekday = DateToWeekdayNumber($week1Start);

  /* Set week1Start to the start of the Week 1. */
  /* If monday, week 1 begins on Jan. 1st */
  if($weekday == 1.0){
    $week1Start->day = 1.0;
  }
  /* If tuesday, week 1 begins on Dec. 31st */
  if($weekday == 2.0){
    $week1Start->year = $week1Start->year - 1.0;
    $week1Start->month = 12.0;
    $week1Start->day = 31.0;
  }
  /* If wednesday, week 1 begins on Dec. 30th */
  if($weekday == 3.0){
    $week1Start->year = $week1Start->year - 1.0;
    $week1Start->month = 12.0;
    $week1Start->day = 30.0;
  }
  /* If thursday, week 1 begins on Dec. 29th */
  if($weekday == 4.0){
    $week1Start->year = $week1Start->year - 1.0;
    $week1Start->month = 12.0;
    $week1Start->day = 29.0;
  }
  /* If friday, week 1 begins on Jan. 4th */
  if($weekday == 5.0){
    $week1Start->day = 4.0;
  }
  /* If saturday, week 1 begins on Jan. 3rd */
  if($weekday == 6.0){
    $week1Start->day = 3.0;
  }
  /* If sunday, week 1 begins on Jan. 2nd */
  if($weekday == 7.0){
    $week1Start->day = 2.0;
  }

  $days = DateToDays($date);
  $daysWeek1Start = DateToDays($week1Start);

  if($days >= $daysWeek1Start){
    $weekNumber = 1.0 + floor(($days - $daysWeek1Start)/7.0);

    if($weekNumber >= 1.0 && $weekNumber <= 52.0){
      /* Week is between 1 and 52 in the current year. */
      $yearRef->numberValue = $date->year;
    }else{
      /* Is week nr 53 or 1 next year? */
      $newyears = CopyDate($date);
      $newyears->month = 12.0;
      $newyears->day = 31.0;
      $weekdayNewYears = DateToWeekdayNumber($newyears);
      if($weekdayNewYears == 1.0 || $weekdayNewYears == 2.0 || $weekdayNewYears == 3.0){
        /* Week 1 next year. */
        $weekNumber = 1.0;
        $yearRef->numberValue = $date->year + 1.0;
      }else{
        /* Week 53 */
        $yearRef->numberValue = $date->year;
      }
      unset($newyears);
    }
  }else{
    /* Week is in previous year. Either 52nd or 53rd. */
    $newyears = CopyDate($date);
    $newyears->month = 12.0;
    $newyears->day = 31.0;
    $newyears->year = $date->year - 1.0;
    $weekNumber = DateToWeeknumber($newyears, $yearRef);
    unset($newyears);
  }

  unset($week1Start);

  return $weekNumber;
}
function DaysInMonthsWithCheck($month, $year, $daysInMonthsReference, $message){

  $date = CreateDate($year, $month, 1.0);

  $success = IsValidDate($date, $message);
  if($success){
    $days = DaysInMonths($month, $year);

    $daysInMonthsReference->numberValue = $days;
  }

  return $success;
}
function DaysInMonths($month, $year){

  $daysInMonth = GetDaysInMonth($year);

  $days = 0.0;
  for($i = 1.0; $i < $month; $i = $i + 1.0){
    $days = $days + $daysInMonth[$i];
  }

  return $days;
}
function DaysInYearsWithCheck($years, $daysReference, $message){

  $date = CreateDate($years, 1.0, 1.0);

  $success = IsValidDate($date, $message);
  if($success){
    $days = DaysInYears($years);
    $daysReference->numberValue = $days;
  }

  return $success;
}
function DaysInYears($years){

  $days = 0.0;
  for($i = 1752.0; $i < $years; $i = $i + 1.0){
    if(IsLeapYear($i)){
      $nrOfDays = 366.0;
    }else{
      $nrOfDays = 365.0;
    }
    $days = $days + $nrOfDays;
  }

  return $days;
}
function IsValidDate($date, $message){

  if($date->year >= 1752.0){
    if($date->month >= 1.0 && $date->month <= 12.0){
      $daysInMonth = GetDaysInMonth($date->year);
      $daysInThisMonth = $daysInMonth[$date->month];
      if($date->day >= 1.0 && $date->day <= $daysInThisMonth){
        $valid = true;
      }else{
        $valid = false;
        $message->string = mb_str_split("The month does not have the given day number.");
      }
    }else{
      $valid = false;
      $message->string = mb_str_split("Month must be between 1 and 12, inclusive.");
    }
  }else{
    $valid = false;
    $message->string = mb_str_split("Gregorian calendar was not in general use before 1752.");
  }

  return $valid;
}
function AddDaysToDate($date, $days, $message){

  $daysRef = new stdClass();
  $success = DateToDaysWithCheck($date, $daysRef, $message);

  if($success){
    $n = $daysRef->numberValue;
    $n = $n + $days;

    $dateReference = new stdClass();
    $success = DayToDateWithCheck($n, $dateReference, $message);
    if($success){
      AssignDate($date, $dateReference->date);
    }
  }

  return $success;
}
function AssignDate($a, $b){
  $a->year = $b->year;
  $a->month = $b->month;
  $a->day = $b->day;
}
function AddMonthsToDate($date, $months){

  if($months > 0.0){
    for($i = 0.0; $i < $months; $i = $i + 1.0){
      $date->month = $date->month + 1.0;

      if($date->month == 13.0){
        $date->month = 1.0;
        $date->year = $date->year + 1.0;
      }
    }
  }
  if($months < 0.0){
    for($i = 0.0; $i < -$months; $i = $i + 1.0){
      $date->month = $date->month - 1.0;

      if($date->month == 0.0){
        $date->month = 12.0;
        $date->year = $date->year - 1.0;
      }
    }
  }
}
function DateToStringISO8601WithCheck($date, $datestr, $message){

  $success = IsValidDate($date, $message);

  if($success){
    if($date->year <= 9999.0){
      $datestr->string = DateToStringISO8601($date);
    }else{
      $message->string = mb_str_split("This library works from 1752 to 9999.");
    }
  }

  return $success;
}
function &DateToStringISO8601($date){

  $str = array_fill(0, 10.0, 0);

  $str[0.0] = cDecimalDigitToCharacter(floor($date->year/1000.0));
  $str[1.0] = cDecimalDigitToCharacter(floor(($date->year%1000.0)/100.0));
  $str[2.0] = cDecimalDigitToCharacter(floor(($date->year%100.0)/10.0));
  $str[3.0] = cDecimalDigitToCharacter(floor($date->year%10.0));

  $str[4.0] = "-";

  $str[5.0] = cDecimalDigitToCharacter(floor(($date->month%100.0)/10.0));
  $str[6.0] = cDecimalDigitToCharacter(floor($date->month%10.0));

  $str[7.0] = "-";

  $str[8.0] = cDecimalDigitToCharacter(floor(($date->day%100.0)/10.0));
  $str[9.0] = cDecimalDigitToCharacter(floor($date->day%10.0));

  return $str;
}
function DateFromStringISO8601(&$str){

  $date = new stdClass();

  $n = cCharacterToDecimalDigit($str[0.0])*1000.0;
  $n = $n + cCharacterToDecimalDigit($str[1.0])*100.0;
  $n = $n + cCharacterToDecimalDigit($str[2.0])*10.0;
  $n = $n + cCharacterToDecimalDigit($str[3.0])*1.0;

  $date->year = $n;

  $n = cCharacterToDecimalDigit($str[5.0])*10.0;
  $n = $n + cCharacterToDecimalDigit($str[6.0])*1.0;

  $date->month = $n;

  $n = cCharacterToDecimalDigit($str[8.0])*10.0;
  $n = $n + cCharacterToDecimalDigit($str[9.0])*1.0;

  $date->day = $n;

  return $date;
}
function DateFromStringISO8601WithCheck(&$str, $dateRef, $message){

  $valid = IsValidDateISO8601($str, $message);

  if($valid){
    $dateRef->date = DateFromStringISO8601($str);
  }

  return $valid;
}
function IsValidDateISO8601(&$str, $message){

  if(count($str) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0){

    if(cIsNumber($str[0.0]) && cIsNumber($str[1.0]) && cIsNumber($str[2.0]) && cIsNumber($str[3.0]) && cIsNumber($str[5.0]) && cIsNumber($str[6.0]) && cIsNumber($str[8.0]) && cIsNumber($str[9.0])){
      if($str[4.0] == "-" && $str[7.0] == "-"){
        $valid = true;
      }else{
        $valid = false;
        $message->string = mb_str_split("ISO8601 date must use \'-\' in positions 5 and 8.");
      }
    }else{
      $valid = false;
      $message->string = mb_str_split("ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.");
    }
  }else{
    $valid = false;
    $message->string = mb_str_split("ISO8601 date must be exactly 10 characters long.");
  }

  return $valid;
}
function DateEquals($a, $b){
  return $a->year == $b->year && $a->month == $b->month && $a->day == $b->day;
}
function CopyDate($a){

  $b = CreateDate($a->year, $a->month, $a->day);

  return $b;
}
function GetSecondsFromDate($date){

  $seconds = 0.0;
  $dayNumberReferenceReference = new stdClass();
  $message = new stdClass();

  $success = DateToDaysWithCheck($date, $dayNumberReferenceReference, $message);
  if($success){
    $days = $dayNumberReferenceReference->numberValue;

    $secondsInMinute = 60.0;
    $secondsInHour = 60.0*$secondsInMinute;
    $secondsInDay = 24.0*$secondsInHour;

    $seconds = $seconds + $secondsInDay*$days;
  }

  unset($dayNumberReferenceReference);
  unset($message);

  return $seconds;
}
function DateIsInInterval($interval, $date){

  $from = DateToDays($interval->first);
  $to = DateToDays($interval->last);
  $day = DateToDays($date);

  return $day >= $from && $day <= $to;
}
function DateLessThan($a, $b){

  $aDays = DateToDays($a);
  $bDays = DateToDays($b);

  return $aDays < $bDays;
}
function CreateDateTimeTimezone($year, $month, $day, $hours, $minutes, $seconds, $timezoneOffsetSeconds){

  $dateTimeTimezone = new stdClass();

  $dateTimeTimezone->dateTime = CreateDateTime($year, $month, $day, $hours, $minutes, $seconds);
  $dateTimeTimezone->timezoneOffsetSeconds = $timezoneOffsetSeconds;

  return $dateTimeTimezone;
}
function CreateDateTimeTimezoneInHoursAndMinutes($year, $month, $day, $hours, $minutes, $seconds, $timezoneOffsetHours, $timezoneOffsetMinutes){

  $dateTimeTimezone = new stdClass();

  $dateTimeTimezone->dateTime = CreateDateTime($year, $month, $day, $hours, $minutes, $seconds);
  $dateTimeTimezone->timezoneOffsetSeconds = GetSecondsFromHours($timezoneOffsetHours) + GetSecondsFromMinutes($timezoneOffsetMinutes);

  return $dateTimeTimezone;
}
function GetDateFromDateTimeTimeZone($dateTimeTimezone, $dateTimeReference, $message){

  $dateTime = $dateTimeTimezone->dateTime;

  return AddSecondsToDateTimeWithCheck($dateTime, -$dateTimeTimezone->timezoneOffsetSeconds, $dateTimeReference, $message);
}
function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds($dateTime, $timezoneOffsetSeconds, $dateTimeTimezoneReference, $message){

  $adjustedDateTimeReference = new stdClass();
  $dateTimeTimezone = new stdClass();

  $success = AddSecondsToDateTime($dateTime, $timezoneOffsetSeconds, $adjustedDateTimeReference, $message);

  if($success){
    $dateTimeTimezone->dateTime = $adjustedDateTimeReference->dateTime;
    $dateTimeTimezone->timezoneOffsetSeconds = $timezoneOffsetSeconds;

    $dateTimeTimezoneReference->dateTimeTimezone = $dateTimeTimezone;
  }

  return $success;
}
function CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes($dateTime, $timezoneOffsetHours, $timezoneOffsetMinutes, $dateTimeTimezoneReference, $message){
  return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds($dateTime, GetSecondsFromHours($timezoneOffsetHours) + GetSecondsFromMinutes($timezoneOffsetMinutes), $dateTimeTimezoneReference, $message);
}
function GetDateTimeTimezoneFromSeconds($dateTimeTzRef, $seconds, $offset, $message){

  $dateTimeRef = new stdClass();
  $success = GetDateTimeFromSeconds($seconds, $dateTimeRef, $message);

  if($success){
    $success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds($dateTimeRef->dateTime, $offset, $dateTimeTzRef, $message);
  }

  return $success;
}
function CreateDateTime($year, $month, $day, $hours, $minutes, $seconds){

  $dateTime = new stdClass();

  $dateTime->date = CreateDate($year, $month, $day);
  $dateTime->hours = $hours;
  $dateTime->minutes = $minutes;
  $dateTime->seconds = $seconds;

  return $dateTime;
}
function GetDateTimeFromSeconds($seconds, $dateTimeReference, $message){

  $secondsInMinute = 60.0;
  $secondsInHour = 60.0*$secondsInMinute;
  $secondsInDay = 24.0*$secondsInHour;
  $days = floor($seconds/$secondsInDay);
  $remainder = $seconds - $days*$secondsInDay;
  $dateReference = new stdClass();

  $success = DayToDateWithCheck($days, $dateReference, $message);
  if($success){
    $date = $dateReference->date;

    $dateTime = new stdClass();
    $dateTime->date = $date;
    $dateTime->hours = floor($remainder/$secondsInHour);
    $remainder = $remainder - $dateTime->hours*$secondsInHour;
    $dateTime->minutes = floor($remainder/$secondsInMinute);
    $remainder = $remainder - $dateTime->minutes*$secondsInMinute;
    $dateTime->seconds = $remainder;

    $dateTimeReference->dateTime = $dateTime;
  }

  return $success;
}
function GetSecondsFromDateTime($dateTime){

  $secondsInMinute = 60.0;
  $secondsInHour = 60.0*$secondsInMinute;

  $seconds = GetSecondsFromDate($dateTime->date);
  $seconds = $seconds + $secondsInHour*$dateTime->hours;
  $seconds = $seconds + $secondsInMinute*$dateTime->minutes;
  $seconds = $seconds + $dateTime->seconds;

  return $seconds;
}
function GetSecondsFromMinutes($minutes){
  return $minutes*60.0;
}
function GetSecondsFromHours($hours){
  return GetSecondsFromMinutes($hours*60.0);
}
function GetSecondsFromDays($days){
  return GetSecondsFromHours($days*24.0);
}
function GetSecondsFromWeeks($weeks){
  return GetSecondsFromDays($weeks*7.0);
}
function GetMinutesFromSeconds($seconds){
  return $seconds/60.0;
}
function GetHoursFromSeconds($seconds){
  return GetMinutesFromSeconds($seconds)/60.0;
}
function GetDaysFromSeconds($seconds){
  return GetHoursFromSeconds($seconds)/24.0;
}
function GetWeeksFromSeconds($seconds){
  return GetDaysFromSeconds($seconds)/7.0;
}
function GetDateFromDateTime($dateTime){
  return $dateTime->date;
}
function AddSecondsToDateTimeWithCheck($dateTime, $seconds, $dateTimeReference, $message){

  if(IsValidDateTime($dateTime, $message)){
    $secondsInDateTime = GetSecondsFromDateTime($dateTime);
    $secondsInDateTime = $secondsInDateTime + $seconds;

    $success = GetDateTimeFromSeconds($secondsInDateTime, $dateTimeReference, $message);
  }else{
    $success = false;
  }

  return $success;
}
function AddSecondsToDateTime($dateTime, $seconds, $dateTimeReference, $message){

  $secondsInDateTime = GetSecondsFromDateTime($dateTime);
  $secondsInDateTime = $secondsInDateTime + $seconds;

  return GetDateTimeFromSeconds($secondsInDateTime, $dateTimeReference, $message);
}
function AddMinutesToDateTime($dateTime, $minutes, $dateTimeReference, $message){
  return AddSecondsToDateTime($dateTime, GetSecondsFromMinutes($minutes), $dateTimeReference, $message);
}
function AddHoursToDateTime($dateTime, $hours, $dateTimeReference, $message){
  return AddSecondsToDateTime($dateTime, GetSecondsFromHours($hours), $dateTimeReference, $message);
}
function AddDaysToDateTime($dateTime, $days, $dateTimeReference, $message){
  return AddSecondsToDateTime($dateTime, GetSecondsFromDays($days), $dateTimeReference, $message);
}
function AddWeeksToDateTime($dateTime, $weeks, $dateTimeReference, $message){
  return AddSecondsToDateTime($dateTime, GetSecondsFromWeeks($weeks), $dateTimeReference, $message);
}
function DateTimeToStringISO8601WithCheck($datetime, $dateStr, $message){

  $success = DateToStringISO8601WithCheck($datetime->date, $dateStr, $message);

  if($success){
    unset($dateStr->string);

    $success = IsValidDateTime($datetime, $message);
    if($success){
      $dateStr->string = DateTimeToStringISO8601($datetime);
    }
  }

  return $success;
}
function IsValidDateTime($datetime, $message){

  $success = IsValidDate($datetime->date, $message);

  if($success){
    if($datetime->hours <= 23.0 && $datetime->hours >= 0.0){
      if($datetime->minutes <= 59.0 && $datetime->minutes >= 0.0){
        if($datetime->seconds <= 59.0 && $datetime->seconds >= 0.0){
          $success = true;
        }else{
          $success = false;
          $message->string = mb_str_split("Seconds must be between 0 and 59.");
        }
      }else{
        $success = false;
        $message->string = mb_str_split("Minutes must be between 0 and 59.");
      }
    }else{
      $success = false;
      $message->string = mb_str_split("Hours must be between 0 and 23.");
    }
  }

  return $success;
}
function &DateTimeToStringISO8601($datetime){

  $str = array_fill(0, 19.0, 0);

  $datestr = DateToStringISO8601($datetime->date);
  for($i = 0.0; $i < count($datestr); $i = $i + 1.0){
    $str[$i] = $datestr[$i];
  }

  $str[10.0] = "T";
  $str[11.0] = cDecimalDigitToCharacter(floor(($datetime->hours%100.0)/10.0));
  $str[12.0] = cDecimalDigitToCharacter(floor($datetime->hours%10.0));

  $str[13.0] = ":";

  $str[14.0] = cDecimalDigitToCharacter(floor(($datetime->minutes%100.0)/10.0));
  $str[15.0] = cDecimalDigitToCharacter(floor($datetime->minutes%10.0));

  $str[16.0] = ":";

  $str[17.0] = cDecimalDigitToCharacter(floor(($datetime->seconds%100.0)/10.0));
  $str[18.0] = cDecimalDigitToCharacter(floor($datetime->seconds%10.0));

  return $str;
}
function DateTimeFromStringISO8601(&$str){

  $dateTime = new stdClass();

  $dateTime->date = DateFromStringISO8601($str);

  $n = cCharacterToDecimalDigit($str[11.0])*10.0;
  $n = $n + cCharacterToDecimalDigit($str[12.0])*1.0;

  $dateTime->hours = $n;

  $n = cCharacterToDecimalDigit($str[14.0])*10.0;
  $n = $n + cCharacterToDecimalDigit($str[15.0])*1.0;

  $dateTime->minutes = $n;

  $n = cCharacterToDecimalDigit($str[17.0])*10.0;
  $n = $n + cCharacterToDecimalDigit($str[18.0])*1.0;

  $dateTime->seconds = $n;

  return $dateTime;
}
function DateTimeFromStringISO8601WithCheck(&$str, $dateTimeRef, $message){

  $valid = IsValidDateTimeISO8601($str, $message);

  if($valid){
    $dateTimeRef->dateTime = DateTimeFromStringISO8601($str);
  }

  return $valid;
}
function IsValidDateTimeISO8601(&$str, $message){

  if(count($str) == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0){

    if(cIsNumber($str[0.0]) && cIsNumber($str[1.0]) && cIsNumber($str[2.0]) && cIsNumber($str[3.0]) && cIsNumber($str[5.0]) && cIsNumber($str[6.0]) && cIsNumber($str[8.0]) && cIsNumber($str[9.0]) && cIsNumber($str[11.0]) && cIsNumber($str[12.0]) && cIsNumber($str[14.0]) && cIsNumber($str[15.0]) && cIsNumber($str[17.0]) && cIsNumber($str[18.0])){
      if($str[4.0] == "-" && $str[7.0] == "-" && $str[10.0] == "T" && $str[13.0] == ":" && $str[16.0] == ":"){
        $valid = true;
      }else{
        $valid = false;
        $message->string = mb_str_split("ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.");
      }
    }else{
      $valid = false;
      $message->string = mb_str_split("ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.");
    }
  }else{
    $valid = false;
    $message->string = mb_str_split("ISO8601 date must be exactly 19 characters long.");
  }

  return $valid;
}
function DateTimeEquals($a, $b){
  return DateEquals($a->date, $b->date) && $a->hours == $b->hours && $a->minutes == $b->minutes && $a->seconds == $b->seconds;
}
function FreeDateTime($datetime){
  unset($datetime->date);
  unset($datetime);
}
function CreateFixedPoint30d($digitsBeforeDecimalPoint, $digitsAfterDecimalPoint){

  $fp = new stdClass();
  $fp->digitsBeforeDecimalPoint = $digitsBeforeDecimalPoint;
  $fp->digitsAfterDecimalPoint = $digitsAfterDecimalPoint;
  $fp->part1 = 0.0;
  $fp->part2 = 0.0;

  return $fp;
}
function CreateFixedPoint15d($digitsBeforeDecimalPoint, $digitsAfterDecimalPoint){

  $fp = new stdClass();
  $fp->digitsBeforeDecimalPoint = $digitsBeforeDecimalPoint;
  $fp->digitsAfterDecimalPoint = $digitsAfterDecimalPoint;
  $fp->number = 0.0;

  return $fp;
}
function ToNumber15d($n){
  return $n->number;
}
function Number15d($number){

  $fp = new stdClass();
  $fp->digitsBeforeDecimalPoint = 7.0;
  $fp->digitsAfterDecimalPoint = 7.0;
  $fp->number = $number;

  return $fp;
}
function Assign15d($fp, $number){

  $success =  !WillOverflow15d($fp, $number) ;
  $success = $success && FixedPointIsValid15d($fp);

  if($success){
    $fp->number = $number;
    $fp->number = RoundToDigits($fp->number, $fp->digitsAfterDecimalPoint);
  }

  return $success;
}
function Assign15dFloor($fp, $number){

  $success =  !WillOverflow15d($fp, $number) ;
  $success = $success && FixedPointIsValid15d($fp);

  if($success){
    $fp->number = $number;
    $fp->number = FloorToDigits($fp->number, $fp->digitsAfterDecimalPoint);
  }

  return $success;
}
function FixedPointIsValid15d($fp){

  if(IsInteger($fp->digitsAfterDecimalPoint) && IsInteger($fp->digitsBeforeDecimalPoint)){
    if($fp->digitsBeforeDecimalPoint >= 0.0 && $fp->digitsBeforeDecimalPoint <= 15.0){
      if($fp->digitsAfterDecimalPoint >= 0.0 && $fp->digitsAfterDecimalPoint <= 15.0){
        if($fp->digitsBeforeDecimalPoint + $fp->digitsAfterDecimalPoint <= 15.0){
          if($fp->digitsBeforeDecimalPoint + $fp->digitsAfterDecimalPoint > 0.0){
            $valid = true;
          }else{
            $valid = false;
          }
        }else{
          $valid = false;
        }
      }else{
        $valid = false;
      }
    }else{
      $valid = false;
    }
  }else{
    $valid = false;
  }

  return $valid;
}
function WillOverflow15d($fp, $number){

  if(abs($number) < 10.0**$fp->digitsBeforeDecimalPoint){
    $overflow = false;
  }else{
    $overflow = true;
  }

  return $overflow;
}
function FloorToDigits($value, $digits){
  return floor($value*10.0**$digits)/10.0**$digits;
}
function &ToString15d($fp){

  $string = array_fill(0, 1.0 + $fp->digitsBeforeDecimalPoint + 1.0 + $fp->digitsAfterDecimalPoint, 0);

  $decimal = $fp->number*10.0**$fp->digitsAfterDecimalPoint;

  if($decimal < 0.0){
    $decimal = -$decimal;
    $string[0.0] = "-";
  }else{
    $string[0.0] = "+";
  }

  $decimal = Roundx($decimal);

  $characterReference = new stdClass();

  $digits = $fp->digitsBeforeDecimalPoint + $fp->digitsAfterDecimalPoint;
  $digitPosition = 1.0;

  for($i = 0.0; $i < $digits; $i = $i + 1.0){
    if($i == $fp->digitsBeforeDecimalPoint){
      $string[$digitPosition] = ".";

      $digitPosition = $digitPosition + 1.0;
    }

    $d = floor($decimal/10.0**($digits - $i - 1.0));
    $d = $d%10.0;

    GetSingleDigitCharacterFromNumberWithCheck($d, 10.0, $characterReference);
    $string[$digitPosition] = $characterReference->characterValue;

    $digitPosition = $digitPosition + 1.0;
  }

  unset($characterReference);

  return $string;
}
function Add15d($a, $b, $c){
  return Assign15d($a, $b->number + $c->number);
}
function Subtract15d($a, $b, $c){
  return Assign15d($a, $b->number - $c->number);
}
function Multiply15d($a, $b, $c){
  return Assign15d($a, $b->number*$c->number);
}
function DivideFloored15d($q, $r, $a, $b){

  $t = Copy15d($r);

  if($b->number != 0.0){
    $xDivisor = Roundx($a->number*10.0**$q->digitsAfterDecimalPoint*10.0**$q->digitsAfterDecimalPoint);
    $xDividend = Roundx($b->number*10.0**$q->digitsAfterDecimalPoint);
    $x = floor($xDivisor/$xDividend);
    $x = $x/10.0**$q->digitsAfterDecimalPoint;
    $success = Assign15d($q, $x);
    Multiply15d($t, $q, $b);
    Subtract15d($r, $a, $t);
  }else{
    $success = false;
  }

  unset($t);

  return $success;
}
function Copy15d($r){

  $t = CreateFixedPoint15d($r->digitsBeforeDecimalPoint, $r->digitsAfterDecimalPoint);
  $t->number = $r->number;

  return $t;
}
function Negate15d($a){
  $a->number = -$a->number;
}
function Positive15d($a){
  $a->number = +$a->number;
}
function Factorial15d($x){

  if($x->number >= 0.0){
    $success = Assign15d($x, Factorial($x->number));
  }else{
    $success = false;
  }

  return $success;
}
function Round15d($x){
  return Assign15d($x, Roundx($x->number));
}
function BankersRound15d($x){
  return Assign15d($x, BankersRound($x->number));
}
function Ceil15d($x){
  return Assign15d($x, Ceilx($x->number));
}
function Floor15d($x){
  return Assign15d($x, floor($x->number));
}
function Truncate15d($x){
  $x->number = Truncate($x->number);
}
function Absolute15d($x){
  $x->number = abs($x->number);
}
function Logarithm15d($x){

  if($x->number > 0.0){
    $success = Assign15d($x, Logarithm($x->number));
  }else{
    $success = false;
  }

  return $success;
}
function NaturalLogarithm15d($x){

  if($x->number > 0.0){
    $success = Assign15d($x, NaturalLogarithm($x->number));
  }else{
    $success = false;
  }

  return $success;
}
function Sin15d($x){
  return Assign15d($x, Sinx($x->number));
}
function Cos15d($x){
  return Assign15d($x, Cosx($x->number));
}
function Tan15d($x){
  return Assign15d($x, Tanx($x->number));
}
function Asin15d($x){

  if($x->number >= -1.0 && $x->number <= 1.0){
    $success = Assign15d($x, Asinx($x->number));
  }else{
    $success = false;
  }

  return $success;
}
function Acos15d($x){

  if($x->number >= -1.0 && $x->number <= 1.0){
    $success = Assign15d($x, Acosx($x->number));
  }else{
    $success = false;
  }

  return $success;
}
function Atan15d($x){
  return Assign15d($x, Atanx($x->number));
}
function Atan2_15d($a, $y, $x){
  return Assign15d($a, Atan2x($y->number, $x->number));
}
function Squareroot15d($x){

  if($x->number >= 0.0){
    $success = Assign15d($x, sqrt($x->number));
  }else{
    $success = false;
  }

  return $success;
}
function Exp15d($x){
  return Assign15d($x, Expx($x->number));
}
function DivisibleBy15d($a, $b){
  return (($a->number%$b->number) == 0.0);
}
function Combinations15d($x, $n, $k){

  if(IsInteger($n->number) && IsInteger($k->number)){
    if($n->number >= 1.0 && $k->number >= 0.0 && $n->number >= $k->number){
      $success = Assign15d($x, Combinations($n->number, $k->number));
    }else{
      $success = false;
    }
  }else{
    $success = false;
  }

  return $success;
}
function Permutations15d($x, $n, $k){

  if(IsInteger($n->number) && IsInteger($k->number)){
    if($n->number >= 1.0 && $k->number >= 0.0 && $n->number >= $k->number){
      $success = Assign15d($x, Permutations($n->number, $k->number));
    }else{
      $success = false;
    }
  }else{
    $success = false;
  }

  return $success;
}
function Equals15d($a, $b){

  $an = ToNumber15d($a);
  $bn = ToNumber15d($b);

  $p = max($a->digitsAfterDecimalPoint, $b->digitsAfterDecimalPoint);

  $equals = EpsilonCompare($an, $bn, 10.0**(-$p));

  return $equals;
}
function GreaterThan15d($a, $b){

  $an = ToNumber15d($a);
  $bn = ToNumber15d($b);

  return $an > $bn;
}
function LessThan15d($a, $b){

  $an = ToNumber15d($a);
  $bn = ToNumber15d($b);

  return $an < $bn;
}
function GreaterThanOrEqual15d($a, $b){

  $an = ToNumber15d($a);
  $bn = ToNumber15d($b);

  $equal = Equals15d($a, $b);

  return $an > $bn || $equal;
}
function LessThanOrEqual15d($a, $b){

  $an = ToNumber15d($a);
  $bn = ToNumber15d($b);

  $equal = Equals15d($a, $b);

  return $an < $bn || $equal;
}
function EpsilonCompare15d($a, $b, $epsilon){
  return EpsilonCompare($a->number, $b->number, $epsilon->number);
}
function GreatestCommonDivisor15d($x, $a, $b){

  if(IsInteger($a->number) && IsInteger($b->number)){
    if($a->number >= 0.0 && $b->number >= 0.0){
      $success = Assign15d($x, GreatestCommonDivisor($a->number, $b->number));
    }else{
      $success = false;
    }
  }else{
    $success = false;
  }

  return $success;
}
function GCDWithSubtraction15d($x, $a, $b){

  if(IsInteger($a->number) && IsInteger($b->number)){
    if($a->number >= 0.0 && $b->number >= 0.0){
      $success = Assign15d($x, GCDWithSubtraction($a->number, $b->number));
    }else{
      $success = false;
    }
  }else{
    $success = false;
  }

  return $success;
}
function IsInteger15d($a){
  return IsInteger($a->number);
}
function LeastCommonMultiple15d($x, $a, $b){

  if(IsInteger($a->number) && IsInteger($b->number)){
    if($a->number != 0.0 && $b->number != 0.0){
      $success = Assign15d($x, LeastCommonMultiple($a->number, $b->number));
    }else{
      $success = false;
    }
  }else{
    $success = false;
  }

  return $success;
}
function Sign15d($a){
  return Sign($a->number);
}
function Max15d($x, $a, $b){
  return Assign15d($x, Maxx($a->number, $b->number));
}
function Min15d($x, $a, $b){
  return Assign15d($x, Minx($a->number, $b->number));
}
function Power15d($x, $a, $b){

  if($a->number != 0.0 || $b->number != 0.0){
    if( !($a->number < 0.0 &&  !IsInteger($b->number) ) ){
      $success = Assign15d($x, Power($a->number, $b->number));
    }else{
      $success = false;
    }
  }else{
    $success = false;
  }

  return $success;
}
function &FormatToString15d($fp, $digitsAfter){

  $result = FormatToStringWithSymbols15d($fp, $digitsAfter, mb_str_split(""), mb_str_split("."));

  return $result;
}
function &FormatToStringWithSymbols15d($fp, $digitsAfter, &$thousandsSeparator, &$decimalPoint){

  $characterReference = new stdClass();

  $decimal = Roundx($fp->number*10.0**$digitsAfter);

  $sign = 0.0;
  if($decimal < 0.0){
    $sign = 1.0;
    $decimal = -$decimal;
  }

  if($decimal != 0.0){
    $digits = floor(log10($decimal) + 1.0);
  }else{
    $digits = 1.0;
  }
  $digitsBefore = $digits - $digitsAfter;

  if($digitsBefore <= 0.0){
    $digitsBefore = 0.0;
    $thousandsTimes = 0.0;
    $digits = $digitsAfter + 1.0;
  }else{
    $thousandsTimes = floor(($digitsBefore - 1.0)/3.0);
  }
  $thousandsChars = $thousandsTimes*count($thousandsSeparator);

  if($digitsAfter == 0.0){
    $decimalPointChars = 0.0;
  }else{
    $decimalPointChars = count($decimalPoint);
  }

  $string = array_fill(0, $sign + $digits + $thousandsChars + $decimalPointChars, 0);
  $p = 0.0;

  if($sign > 0.0){
    $string[$p] = "-";
    $p = $p + 1.0;
  }

  for($i = 0.0; $i < $digits; $i = $i + 1.0){
    if($i == $digitsBefore){
      if($i == 0.0){
        $string[$p] = "0";
        $p = $p + 1.0;
        $digits = $digits - 1.0;
      }

      for($j = 0.0; $j < count($decimalPoint); $j = $j + 1.0){
        $string[$p] = $decimalPoint[$j];
        $p = $p + 1.0;
      }
    }

    if($i < $digitsBefore){
      if(($digitsBefore - $i)%3.0 == 0.0 && $i != 0.0){
        for($j = 0.0; $j < count($thousandsSeparator); $j = $j + 1.0){
          $string[$p] = $thousandsSeparator[$j];
          $p = $p + 1.0;
        }
      }
    }

    $d = floor($decimal/10.0**($digits - $i - 1.0));
    $d = $d%10.0;

    GetSingleDigitCharacterFromNumberWithCheck($d, 10.0, $characterReference);
    $string[$p] = $characterReference->characterValue;

    $p = $p + 1.0;
  }

  /* System.out.println(new String(string)); */
  return $string;
}
function &NumberToHumanReadable($n, $digitsAfter, &$thousandsSeparator, &$decimalPoint){

  if(abs($n) < 1.0){
    $str = CreateStringDecimalFromNumber($n);
  }else{
    $d = log10($n);

    $p3 = min(floor($d/3.0), 8.0);

    if($p3 == 0.0){
      $u = "B";
    }else if($p3 == 1.0){
      $u = "K";
    }else if($p3 == 2.0){
      $u = "M";
    }else if($p3 == 3.0){
      $u = "G";
    }else if($p3 == 4.0){
      $u = "T";
    }else if($p3 == 5.0){
      $u = "P";
    }else if($p3 == 6.0){
      $u = "E";
    }else if($p3 == 7.0){
      $u = "Z";
    }else{
      $u = "Y";
    }

    if($p3 > 1.0){
      $n = $n/10.0**($p3*3.0);
    }

    $str = FormatToStringWithSymbols15d(Number15d($n), $digitsAfter, $thousandsSeparator, $decimalPoint);

    if($p3 > 1.0){
      $str = strAppendCharacter($str, $u);
    }
  }

  return $str;
}
function &NumberToHumanReadableBinaryPrefix($n, $digitsAfter, &$thousandsSeparator, &$decimalPoint){

  if(abs($n) < 1.0){
    $str = CreateStringDecimalFromNumber($n);
  }else{
    $d = floor(log($n)/log(2.0)) + 1.0;

    $p3 = min(floor($d/10.0), 8.0);

    if($p3 == 0.0){
      $u = mb_str_split("B");
    }else if($p3 == 1.0){
      $u = mb_str_split("Ki");
    }else if($p3 == 2.0){
      $u = mb_str_split("Mi");
    }else if($p3 == 3.0){
      $u = mb_str_split("Gi");
    }else if($p3 == 4.0){
      $u = mb_str_split("Ti");
    }else if($p3 == 5.0){
      $u = mb_str_split("Pi");
    }else if($p3 == 6.0){
      $u = mb_str_split("Ei");
    }else if($p3 == 7.0){
      $u = mb_str_split("Zi");
    }else{
      $u = mb_str_split("Yi");
    }

    if($p3 > 1.0){
      $n = $n/2.0**($p3*10.0);
    }

    $str = FormatToStringWithSymbols15d(Number15d($n), $digitsAfter, $thousandsSeparator, $decimalPoint);

    if($p3 > 1.0){
      $str = strAppendString($str, $u);
    }
  }

  return $str;
}
function &AddNumber(&$list, $a){

  $newlist = array_fill(0, count($list) + 1.0, 0);
  for($i = 0.0; $i < count($list); $i = $i + 1.0){
    $newlist[$i] = $list[$i];
  }
  $newlist[count($list)] = $a;
		
  unset($list);
		
  return $newlist;
}
function AddNumberRef($list, $i){
  $list->numberArray = AddNumber($list->numberArray, $i);
}
function &RemoveNumber(&$list, $n){

  $newlist = array_fill(0, count($list) - 1.0, 0);

  if($n >= 0.0 && $n < count($list)){
    for($i = 0.0; $i < count($list); $i = $i + 1.0){
      if($i < $n){
        $newlist[$i] = $list[$i];
      }
      if($i > $n){
        $newlist[$i - 1.0] = $list[$i];
      }
    }

    unset($list);
  }else{
    unset($newlist);
  }
		
  return $newlist;
}
function GetNumberRef($list, $i){
  return $list->numberArray[$i];
}
function RemoveNumberRef($list, $i){
  $list->numberArray = RemoveNumber($list->numberArray, $i);
}
function &AddString(&$list, $a){

  $newlist = array_fill(0, count($list) + 1.0, 0);

  for($i = 0.0; $i < count($list); $i = $i + 1.0){
    $newlist[$i] = $list[$i];
  }
  $newlist[count($list)] = $a;
		
  unset($list);
		
  return $newlist;
}
function AddStringRef($list, $i){
  $list->stringArray = AddString($list->stringArray, $i);
}
function &RemoveString(&$list, $n){

  $newlist = array_fill(0, count($list) - 1.0, 0);

  if($n >= 0.0 && $n < count($list)){
    for($i = 0.0; $i < count($list); $i = $i + 1.0){
      if($i < $n){
        $newlist[$i] = $list[$i];
      }
      if($i > $n){
        $newlist[$i - 1.0] = $list[$i];
      }
    }

    unset($list);
  }else{
    unset($newlist);
  }
		
  return $newlist;
}
function GetStringRef($list, $i){
  return $list->stringArray[$i];
}
function RemoveStringRef($list, $i){
  $list->stringArray = RemoveString($list->stringArray, $i);
}
function CreateDynamicArrayCharacters(){

  $da = new stdClass();
  $da->array = array_fill(0, 10.0, 0);
  $da->length = 0.0;

  return $da;
}
function CreateDynamicArrayCharactersWithInitialCapacity($capacity){

  $da = new stdClass();
  $da->array = array_fill(0, $capacity, 0);
  $da->length = 0.0;

  return $da;
}
function DynamicArrayAddCharacter($da, $value){
  if($da->length == count($da->array)){
    DynamicArrayCharactersIncreaseSize($da);
  }

  $da->array[$da->length] = $value;
  $da->length = $da->length + 1.0;
}
function DynamicArrayAddString($da, &$str){

  for($i = 0.0; $i < count($str); $i = $i + 1.0){
    DynamicArrayAddCharacter($da, $str[$i]);
  }
}
function DynamicArrayCharactersIncreaseSize($da){

  $newLength = round(count($da->array)*3.0/2.0);
  $newArray = array_fill(0, $newLength, 0);

  for($i = 0.0; $i < count($da->array); $i = $i + 1.0){
    $newArray[$i] = $da->array[$i];
  }

  unset($da->array);

  $da->array = $newArray;
}
function DynamicArrayCharactersDecreaseSizeNecessary($da){

  $needsDecrease = false;

  if($da->length > 10.0){
    $needsDecrease = $da->length <= round(count($da->array)*2.0/3.0);
  }

  return $needsDecrease;
}
function DynamicArrayCharactersDecreaseSize($da){

  $newLength = round(count($da->array)*2.0/3.0);
  $newArray = array_fill(0, $newLength, 0);

  for($i = 0.0; $i < $newLength; $i = $i + 1.0){
    $newArray[$i] = $da->array[$i];
  }

  unset($da->array);

  $da->array = $newArray;
}
function DynamicArrayCharactersIndex($da, $index){
  return $da->array[$index];
}
function DynamicArrayCharactersLength($da){
  return $da->length;
}
function DynamicArrayInsertCharacter($da, $index, $value){

  if($da->length == count($da->array)){
    DynamicArrayCharactersIncreaseSize($da);
  }

  for($i = $da->length; $i > $index; $i = $i - 1.0){
    $da->array[$i] = $da->array[$i - 1.0];
  }

  $da->array[$index] = $value;

  $da->length = $da->length + 1.0;
}
function DynamicArrayCharacterSet($da, $index, $value){

  if($index < $da->length){
    $da->array[$index] = $value;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function DynamicArrayRemoveCharacter($da, $index){

  for($i = $index; $i < $da->length - 1.0; $i = $i + 1.0){
    $da->array[$i] = $da->array[$i + 1.0];
  }

  $da->length = $da->length - 1.0;

  if(DynamicArrayCharactersDecreaseSizeNecessary($da)){
    DynamicArrayCharactersDecreaseSize($da);
  }
}
function FreeDynamicArrayCharacters($da){
  unset($da->array);
  unset($da);
}
function &DynamicArrayCharactersToArray($da){

  $array = array_fill(0, $da->length, 0);

  for($i = 0.0; $i < $da->length; $i = $i + 1.0){
    $array[$i] = $da->array[$i];
  }

  return $array;
}
function ArrayToDynamicArrayCharactersWithOptimalSize(&$array){

  $c = count($array);
  $n = (log($c) - 1.0)/log(3.0/2.0);
  $newCapacity = ceil(10.0*(3.0/2.0)**$n);

  $da = CreateDynamicArrayCharactersWithInitialCapacity($newCapacity);

  for($i = 0.0; $i < count($array); $i = $i + 1.0){
    $da->array[$i] = $array[$i];
  }

  return $da;
}
function ArrayToDynamicArrayCharacters(&$array){

  $da = new stdClass();
  $da->array = arraysCopyString($array);
  $da->length = count($array);

  return $da;
}
function DynamicArrayCharactersEqual($a, $b){

  $equal = true;
  if($a->length == $b->length){
    for($i = 0.0; $i < $a->length && $equal; $i = $i + 1.0){
      if($a->array[$i] != $b->array[$i]){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function DynamicArrayCharactersToLinkedList($da){

  $ll = CreateLinkedListCharacter();

  for($i = 0.0; $i < $da->length; $i = $i + 1.0){
    LinkedListAddCharacter($ll, $da->array[$i]);
  }

  return $ll;
}
function LinkedListToDynamicArrayCharacters($ll){

  $node = $ll->first;

  $da = new stdClass();
  $da->length = LinkedListCharactersLength($ll);

  $da->array = array_fill(0, $da->length, 0);

  for($i = 0.0; $i < $da->length; $i = $i + 1.0){
    $da->array[$i] = $node->value;
    $node = $node->next;
  }

  return $da;
}
function &AddBoolean(&$list, $a){

  $newlist = array_fill(0, count($list) + 1.0, 0);
  for($i = 0.0; $i < count($list); $i = $i + 1.0){
    $newlist[$i] = $list[$i];
  }
  $newlist[count($list)] = $a;
		
  unset($list);
		
  return $newlist;
}
function AddBooleanRef($list, $i){
  $list->booleanArray = AddBoolean($list->booleanArray, $i);
}
function &RemoveBoolean(&$list, $n){

  $newlist = array_fill(0, count($list) - 1.0, 0);

  if($n >= 0.0 && $n < count($list)){
    for($i = 0.0; $i < count($list); $i = $i + 1.0){
      if($i < $n){
        $newlist[$i] = $list[$i];
      }
      if($i > $n){
        $newlist[$i - 1.0] = $list[$i];
      }
    }

    unset($list);
  }else{
    unset($newlist);
  }
		
  return $newlist;
}
function GetBooleanRef($list, $i){
  return $list->booleanArray[$i];
}
function RemoveDecimalRef($list, $i){
  $list->booleanArray = RemoveBoolean($list->booleanArray, $i);
}
function CreateLinkedListString(){

  $ll = new stdClass();
  $ll->first = new stdClass();
  $ll->last = $ll->first;
  $ll->last->end = true;

  return $ll;
}
function LinkedListAddString($ll, &$value){
  $ll->last->end = false;
  $ll->last->value = $value;
  $ll->last->next = new stdClass();
  $ll->last->next->end = true;
  $ll->last = $ll->last->next;
}
function &LinkedListStringsToArray($ll){

  $node = $ll->first;

  $length = LinkedListStringsLength($ll);

  $array = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $array[$i] = new stdClass();
    $array[$i]->string = $node->value;
    $node = $node->next;
  }

  return $array;
}
function LinkedListStringsLength($ll){

  $l = 0.0;
  $node = $ll->first;
  for(;  !$node->end ; ){
    $node = $node->next;
    $l = $l + 1.0;
  }

  return $l;
}
function FreeLinkedListString($ll){

  $node = $ll->first;

  for(;  !$node->end ; ){
    $prev = $node;
    $node = $node->next;
    unset($prev);
  }

  unset($node);
}
function LinkedListInsertString($ll, $index, &$value){

  if($index == 0.0){
    $tmp = $ll->first;
    $ll->first = new stdClass();
    $ll->first->next = $tmp;
    $ll->first->value = $value;
    $ll->first->end = false;
  }else{
    $node = $ll->first;
    for($i = 0.0; $i < $index - 1.0; $i = $i + 1.0){
      $node = $node->next;
    }

    $tmp = $node->next;
    $node->next = new stdClass();
    $node->next->next = $tmp;
    $node->next->value = $value;
    $node->next->end = false;
  }
}
function CreateLinkedListNumbers(){

  $ll = new stdClass();
  $ll->first = new stdClass();
  $ll->last = $ll->first;
  $ll->last->end = true;

  return $ll;
}
function &CreateLinkedListNumbersArray($length){

  $lls = array_fill(0, $length, 0);
  for($i = 0.0; $i < count($lls); $i = $i + 1.0){
    $lls[$i] = CreateLinkedListNumbers();
  }

  return $lls;
}
function LinkedListAddNumber($ll, $value){
  $ll->last->end = false;
  $ll->last->value = $value;
  $ll->last->next = new stdClass();
  $ll->last->next->end = true;
  $ll->last = $ll->last->next;
}
function LinkedListNumbersLength($ll){

  $l = 0.0;
  $node = $ll->first;
  for(;  !$node->end ; ){
    $node = $node->next;
    $l = $l + 1.0;
  }

  return $l;
}
function LinkedListNumbersIndex($ll, $index){

  $node = $ll->first;
  for($i = 0.0; $i < $index; $i = $i + 1.0){
    $node = $node->next;
  }

  return $node->value;
}
function LinkedListInsertNumber($ll, $index, $value){

  if($index == 0.0){
    $tmp = $ll->first;
    $ll->first = new stdClass();
    $ll->first->next = $tmp;
    $ll->first->value = $value;
    $ll->first->end = false;
  }else{
    $node = $ll->first;
    for($i = 0.0; $i < $index - 1.0; $i = $i + 1.0){
      $node = $node->next;
    }

    $tmp = $node->next;
    $node->next = new stdClass();
    $node->next->next = $tmp;
    $node->next->value = $value;
    $node->next->end = false;
  }
}
function LinkedListSet($ll, $index, $value){

  $node = $ll->first;
  for($i = 0.0; $i < $index; $i = $i + 1.0){
    $node = $node->next;
  }

  $node->next->value = $value;
}
function LinkedListRemoveNumber($ll, $index){

  $node = $ll->first;
  $prev = $ll->first;

  for($i = 0.0; $i < $index; $i = $i + 1.0){
    $prev = $node;
    $node = $node->next;
  }

  if($index == 0.0){
    $ll->first = $prev->next;
  }
  if( !$prev->next->end ){
    $prev->next = $prev->next->next;
  }
}
function FreeLinkedListNumbers($ll){

  $node = $ll->first;

  for(;  !$node->end ; ){
    $prev = $node;
    $node = $node->next;
    unset($prev);
  }

  unset($node);
}
function FreeLinkedListNumbersArray(&$lls){

  for($i = 0.0; $i < count($lls); $i = $i + 1.0){
    FreeLinkedListNumbers($lls[$i]);
  }
  unset($lls);
}
function &LinkedListNumbersToArray($ll){

  $node = $ll->first;

  $length = LinkedListNumbersLength($ll);

  $array = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $array[$i] = $node->value;
    $node = $node->next;
  }

  return $array;
}
function ArrayToLinkedListNumbers(&$array){

  $ll = CreateLinkedListNumbers();

  for($i = 0.0; $i < count($array); $i = $i + 1.0){
    LinkedListAddNumber($ll, $array[$i]);
  }

  return $ll;
}
function LinkedListNumbersEqual($a, $b){

  $an = $a->first;
  $bn = $b->first;

  $equal = true;
  $done = false;
  for(; $equal &&  !$done ; ){
    if($an->end == $bn->end){
      if($an->end){
        $done = true;
      }else if($an->value == $bn->value){
        $an = $an->next;
        $bn = $bn->next;
      }else{
        $equal = false;
      }
    }else{
      $equal = false;
    }
  }

  return $equal;
}
function CreateLinkedListCharacter(){

  $ll = new stdClass();
  $ll->first = new stdClass();
  $ll->last = $ll->first;
  $ll->last->end = true;

  return $ll;
}
function LinkedListAddCharacter($ll, $value){
  $ll->last->end = false;
  $ll->last->value = $value;
  $ll->last->next = new stdClass();
  $ll->last->next->end = true;
  $ll->last = $ll->last->next;
}
function &LinkedListCharactersToArray($ll){

  $node = $ll->first;

  $length = LinkedListCharactersLength($ll);

  $array = array_fill(0, $length, 0);

  for($i = 0.0; $i < $length; $i = $i + 1.0){
    $array[$i] = $node->value;
    $node = $node->next;
  }

  return $array;
}
function LinkedListCharactersLength($ll){

  $l = 0.0;
  $node = $ll->first;
  for(;  !$node->end ; ){
    $node = $node->next;
    $l = $l + 1.0;
  }

  return $l;
}
function FreeLinkedListCharacter($ll){

  $node = $ll->first;

  for(;  !$node->end ; ){
    $prev = $node;
    $node = $node->next;
    unset($prev);
  }

  unset($node);
}
function LinkedListCharactersAddString($ll, &$str){

  for($i = 0.0; $i < count($str); $i = $i + 1.0){
    LinkedListAddCharacter($ll, $str[$i]);
  }
}
function LinkedListInsertCharacter($ll, $index, $value){

  if($index == 0.0){
    $tmp = $ll->first;
    $ll->first = new stdClass();
    $ll->first->next = $tmp;
    $ll->first->value = $value;
    $ll->first->end = false;
  }else{
    $node = $ll->first;
    for($i = 0.0; $i < $index - 1.0; $i = $i + 1.0){
      $node = $node->next;
    }

    $tmp = $node->next;
    $node->next = new stdClass();
    $node->next->next = $tmp;
    $node->next->value = $value;
    $node->next->end = false;
  }
}
function CreateDynamicArrayNumbers(){

  $da = new stdClass();
  $da->array = array_fill(0, 10.0, 0);
  $da->length = 0.0;

  return $da;
}
function CreateDynamicArrayNumbersWithInitialCapacity($capacity){

  $da = new stdClass();
  $da->array = array_fill(0, $capacity, 0);
  $da->length = 0.0;

  return $da;
}
function DynamicArrayAddNumber($da, $value){
  if($da->length == count($da->array)){
    DynamicArrayNumbersIncreaseSize($da);
  }

  $da->array[$da->length] = $value;
  $da->length = $da->length + 1.0;
}
function DynamicArrayNumbersIncreaseSize($da){

  $newLength = round(count($da->array)*3.0/2.0);
  $newArray = array_fill(0, $newLength, 0);

  for($i = 0.0; $i < count($da->array); $i = $i + 1.0){
    $newArray[$i] = $da->array[$i];
  }

  unset($da->array);

  $da->array = $newArray;
}
function DynamicArrayNumbersDecreaseSizeNecessary($da){

  $needsDecrease = false;

  if($da->length > 10.0){
    $needsDecrease = $da->length <= round(count($da->array)*2.0/3.0);
  }

  return $needsDecrease;
}
function DynamicArrayNumbersDecreaseSize($da){

  $newLength = round(count($da->array)*2.0/3.0);
  $newArray = array_fill(0, $newLength, 0);

  for($i = 0.0; $i < $newLength; $i = $i + 1.0){
    $newArray[$i] = $da->array[$i];
  }

  unset($da->array);

  $da->array = $newArray;
}
function DynamicArrayNumbersIndex($da, $index){
  return $da->array[$index];
}
function DynamicArrayNumbersLength($da){
  return $da->length;
}
function DynamicArrayInsertNumber($da, $index, $value){

  if($da->length == count($da->array)){
    DynamicArrayNumbersIncreaseSize($da);
  }

  for($i = $da->length; $i > $index; $i = $i - 1.0){
    $da->array[$i] = $da->array[$i - 1.0];
  }

  $da->array[$index] = $value;

  $da->length = $da->length + 1.0;
}
function DynamicArrayNumberSet($da, $index, $value){

  if($index < $da->length){
    $da->array[$index] = $value;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function DynamicArrayRemoveNumber($da, $index){

  for($i = $index; $i < $da->length - 1.0; $i = $i + 1.0){
    $da->array[$i] = $da->array[$i + 1.0];
  }

  $da->length = $da->length - 1.0;

  if(DynamicArrayNumbersDecreaseSizeNecessary($da)){
    DynamicArrayNumbersDecreaseSize($da);
  }
}
function FreeDynamicArrayNumbers($da){
  unset($da->array);
  unset($da);
}
function &DynamicArrayNumbersToArray($da){

  $array = array_fill(0, $da->length, 0);

  for($i = 0.0; $i < $da->length; $i = $i + 1.0){
    $array[$i] = $da->array[$i];
  }

  return $array;
}
function ArrayToDynamicArrayNumbersWithOptimalSize(&$array){

  /*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
         */
  $c = count($array);
  $n = (log($c) - 1.0)/log(3.0/2.0);
  $newCapacity = ceil(10.0*(3.0/2.0)**$n);

  $da = CreateDynamicArrayNumbersWithInitialCapacity($newCapacity);

  for($i = 0.0; $i < count($array); $i = $i + 1.0){
    $da->array[$i] = $array[$i];
  }

  return $da;
}
function ArrayToDynamicArrayNumbers(&$array){

  $da = new stdClass();
  $da->array = arraysCopyNumberArray($array);
  $da->length = count($array);

  return $da;
}
function DynamicArrayNumbersEqual($a, $b){

  $equal = true;
  if($a->length == $b->length){
    for($i = 0.0; $i < $a->length && $equal; $i = $i + 1.0){
      if($a->array[$i] != $b->array[$i]){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function DynamicArrayNumbersToLinkedList($da){

  $ll = CreateLinkedListNumbers();

  for($i = 0.0; $i < $da->length; $i = $i + 1.0){
    LinkedListAddNumber($ll, $da->array[$i]);
  }

  return $ll;
}
function LinkedListToDynamicArrayNumbers($ll){

  $node = $ll->first;

  $da = new stdClass();
  $da->length = LinkedListNumbersLength($ll);

  $da->array = array_fill(0, $da->length, 0);

  for($i = 0.0; $i < $da->length; $i = $i + 1.0){
    $da->array[$i] = $node->value;
    $node = $node->next;
  }

  return $da;
}
function DynamicArrayNumbersIndexOf($arr, $n, $foundReference){

  $found = false;
  for($i = 0.0; $i < $arr->length &&  !$found ; $i = $i + 1.0){
    if($arr->array[$i] == $n){
      $found = true;
    }
  }
  if( !$found ){
    $i = -1.0;
  }else{
    $i = $i - 1.0;
  }

  $foundReference->booleanValue = $found;

  return $i;
}
function DynamicArrayNumbersIsInArray($arr, $n){

  $found = false;
  for($i = 0.0; $i < $arr->length &&  !$found ; $i = $i + 1.0){
    if($arr->array[$i] == $n){
      $found = true;
    }
  }

  return $found;
}
function &AddCharacter(&$list, $a){

  $newlist = array_fill(0, count($list) + 1.0, 0);
  for($i = 0.0; $i < count($list); $i = $i + 1.0){
    $newlist[$i] = $list[$i];
  }
  $newlist[count($list)] = $a;
		
  unset($list);
		
  return $newlist;
}
function AddCharacterRef($list, $i){
  $list->string = AddCharacter($list->string, $i);
}
function &RemoveCharacter(&$list, $n){

  $newlist = array_fill(0, count($list) - 1.0, 0);

  if($n >= 0.0 && $n < count($list)){
    for($i = 0.0; $i < count($list); $i = $i + 1.0){
      if($i < $n){
        $newlist[$i] = $list[$i];
      }
      if($i > $n){
        $newlist[$i - 1.0] = $list[$i];
      }
    }

    unset($list);
  }else{
    unset($newlist);
  }

  return $newlist;
}
function GetCharacterRef($list, $i){
  return $list->string[$i];
}
function RemoveCharacterRef($list, $i){
  $list->string = RemoveCharacter($list->string, $i);
}
function GetAccrualAmount($total, $fromYear, $fromMonth, $fromDay, $toYear, $toMonth, $toDay, $yearOfInterest, $monthOfInterest){

  $from = CreateDate($fromYear, $fromMonth, $fromDay);
  $to = CreateDate($toYear, $toMonth, $toDay);

  $amount = GetAccrualAmountWithDates($total, $from, $to, $yearOfInterest, $monthOfInterest);

  return $amount;
}
function &GetAccruals($total, $fromYear, $fromMonth, $fromDay, $toYear, $toMonth, $toDay){

  $from = CreateDate($fromYear, $fromMonth, $fromDay);
  $to = CreateDate($toYear, $toMonth, $toDay);

  $amounts = GetAccrualsWithDates($total, $from, $to);

  return $amounts;
}
function &GetAccrualsWithDates($total, $from, $to){

  $list = CreateLinkedListNumbers();

  $done = false;
  $dateOfInterest = new stdClass();
  AssignDate($dateOfInterest, $from);
  for(;  !$done ; ){
    if($dateOfInterest->year == $to->year && $dateOfInterest->month == $to->month){
      $done = true;
    }

    $entry = GetAccrualAmountWithDates($total, $from, $to, $dateOfInterest->year, $dateOfInterest->month);
    LinkedListAddNumber($list, $entry);
    AddMonthsToDate($dateOfInterest, 1.0);
  }

  $result = LinkedListNumbersToArray($list);
  FreeLinkedListNumbers($list);

  return $result;
}
function GetAccrualAmountWithDates($total, $from, $to, $yearOfInterest, $monthOfInterest){

  $message = new stdClass();

  $valuePerDay = CreateFixedPoint15d(13.0, 2.0);
  $divisibleRemaining = CreateFixedPoint15d(13.0, 2.0);
  $divisibleTotal = CreateFixedPoint15d(13.0, 2.0);
  $amount = CreateFixedPoint15d(13.0, 2.0);

  $days = DaysBetweenDates($from, $to) + 1.0;

  /* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining */
  DivideFloored15d($valuePerDay, $divisibleRemaining, Number15d($total), Number15d($days));

  Multiply15d($divisibleTotal, $valuePerDay, Number15d($days));
  $unadjustedAmount = GetUnadjustedAccrualAmountWithDates($divisibleTotal, $from, $to, $yearOfInterest, $monthOfInterest);

  if( !Equals15d($divisibleRemaining, Number15d(0.0)) ){
    $daysToAdjust = Roundx(ToNumber15d($divisibleRemaining)*100.0);
    $adjustTo = new stdClass();
    AssignDate($adjustTo, $from);
    AddDaysToDate($adjustTo, $daysToAdjust - 1.0, $message);

    $adjustment = GetUnadjustedAccrualAmountWithDates($divisibleRemaining, $from, $adjustTo, $yearOfInterest, $monthOfInterest);

    unset($adjustTo);
  }else{
    $adjustment = 0.0;
  }

  Add15d($amount, Number15d($unadjustedAmount), Number15d($adjustment));

  $n = ToNumber15d($amount);

  unset($valuePerDay);
  unset($divisibleRemaining);
  unset($divisibleTotal);
  unset($amount);

  return $n;
}
function GetUnadjustedAccrualAmountWithDates($total, $from, $to, $yearOfInterest, $monthOfInterest){

  $value = CreateFixedPoint15d(13.0, 2.0);
  $valuePerDay = CreateFixedPoint15d(13.0, 2.0);
  $remainder = CreateFixedPoint15d(13.0, 2.0);

  $days = DaysBetweenDates($from, $to) + 1.0;
  /* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ... */
  $success = DivideFloored15d($valuePerDay, $remainder, $total, Number15d($days));

  if($success){
    $daysInMonth = GetDaysInMonth($yearOfInterest);

    if($yearOfInterest < $from->year){
      Assign15d($value, 0.0);
    }else if($yearOfInterest == $from->year && $monthOfInterest < $from->month){
      Assign15d($value, 0.0);
    }else if($yearOfInterest > $to->year){
      Assign15d($value, 0.0);
    }else if($yearOfInterest == $to->year && $monthOfInterest > $to->month){
      Assign15d($value, 0.0);
    }else{
if($from->year == $yearOfInterest && $from->month == $monthOfInterest && $to->year == $yearOfInterest && $to->month == $monthOfInterest){
        $daysInMonthOfInterest = $days;
      }else if($from->year == $yearOfInterest && $from->month == $monthOfInterest){
        $lastDayInMonth = CreateDate($yearOfInterest, $monthOfInterest, $daysInMonth[$monthOfInterest]);
        $daysInMonthOfInterest = DaysBetweenDates($from, $lastDayInMonth) + 1.0;
      }else if($to->year == $yearOfInterest && $to->month == $monthOfInterest){
        $firstDateInMonth = CreateDate($yearOfInterest, $monthOfInterest, 1.0);
        $daysInMonthOfInterest = DaysBetweenDates($firstDateInMonth, $to) + 1.0;
      }else{
        $daysInMonthOfInterest = $daysInMonth[$monthOfInterest];
      }

      /* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value */
      Multiply15d($value, $valuePerDay, Number15d($daysInMonthOfInterest));
    }

    unset($daysInMonth);
  }

  $n = ToNumber15d($value);

  unset($value);
  unset($valuePerDay);
  unset($remainder);

  return $n;
}
function CreateNewArrayData(){

  $data = new stdClass();
  $data->isArray = true;
  $data->isStruture = false;
  $data->isNumber = false;
  $data->isBoolean = false;
  $data->isString = false;
  $data->array = CreateArray();

  return $data;
}
function CreateNewStructData(){

  $data = new stdClass();
  $data->isStruture = true;
  $data->isArray = false;
  $data->isNumber = false;
  $data->isBoolean = false;
  $data->isString = false;
  $data->structure = CreateStructure();

  return $data;
}
function CreateStructure(){

  $st = new stdClass();
  $st->keys = CreateArray();
  $st->values = CreateArray();

  return $st;
}
function CreateNumberData($n){

  $data = new stdClass();
  $data->isNumber = true;
  $data->isStruture = false;
  $data->isArray = false;
  $data->isBoolean = false;
  $data->isString = false;
  $data->number = $n;

  return $data;
}
function CreateBooleanData($b){

  $data = new stdClass();
  $data->isBoolean = true;
  $data->isStruture = false;
  $data->isArray = false;
  $data->isNumber = false;
  $data->isString = false;
  $data->booleanx = $b;

  return $data;
}
function CreateStringData(&$string){

  $data = new stdClass();
  $data->isString = true;
  $data->isStruture = false;
  $data->isArray = false;
  $data->isNumber = false;
  $data->isBoolean = false;
  $data->string = $string;

  return $data;
}
function CreateStructData($structure){

  $data = new stdClass();
  $data->isString = false;
  $data->isStruture = true;
  $data->isArray = false;
  $data->isNumber = false;
  $data->isBoolean = false;
  $data->structure = $structure;

  return $data;
}
function CreateArrayData($array){

  $data = new stdClass();
  $data->isString = false;
  $data->isStruture = false;
  $data->isArray = true;
  $data->isNumber = false;
  $data->isBoolean = false;
  $data->array = $array;

  return $data;
}
function CreateNoTypeData(){

  $data = new stdClass();
  $data->isStruture = false;
  $data->isArray = false;
  $data->isNumber = false;
  $data->isBoolean = false;
  $data->isString = false;

  return $data;
}
function AddStructToArray($ar, $st){

  $data = CreateNewStructData();
  unset($data->structure);
  $data->structure = $st;

  ArrayAdd($ar, $data);
}
function AddArrayToArray($ar, $ar2){

  $data = CreateNewArrayData();
  unset($data->array);
  $data->array = $ar2;

  ArrayAdd($ar, $data);
}
function AddNumberToArray($ar, $n){
  ArrayAdd($ar, CreateNumberData($n));
}
function AddBooleanToArray($ar, $b){
  ArrayAdd($ar, CreateBooleanData($b));
}
function AddStringToArray($ar, &$str){
  ArrayAdd($ar, CreateStringData($str));
}
function AddDataToArray($ar, $data){
  ArrayAdd($ar, $data);
}
function StructKeys($st){
  return ArrayLength($st->keys);
}
function StructHasKey($st, &$key){

  $hasKey = false;
  for($i = 0.0; $i < StructKeys($st); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $hasKey = true;
    }
  }

  return $hasKey;
}
function StructKeyIndex($st, &$key){

  $index = -1.0;
  for($i = 0.0; $i < StructKeys($st); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $index = $i;
    }
  }

  return $index;
}
function &GetStructKeys($st){

  $nr = StructKeys($st);

  $keys = array_fill(0, $nr, 0);

  for($i = 0.0; $i < $nr; $i = $i + 1.0){
    $keys[$i] = new stdClass();
    $keys[$i]->string = arraysCopyString($st->keys->array[$i]->string);
  }

  return $keys;
}
function GetStructFromStruct($st, &$key){

  $r = new stdClass();
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $r = $st->values->array[$i]->structure;
    }
  }

  return $r;
}
function GetArrayFromStruct($st, &$key){

  $r = new stdClass();
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $r = $st->values->array[$i]->array;
    }
  }

  return $r;
}
function GetNumberFromStruct($st, &$key){

  $r = 0.0;
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $r = $st->values->array[$i]->number;
    }
  }

  return $r;
}
function GetBooleanFromStruct($st, &$key){

  $r = false;
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $r = $st->values->array[$i]->booleanx;
    }
  }

  return $r;
}
function &GetStringFromStruct($st, &$key){

  $r = mb_str_split("");
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      $r = $st->values->array[$i]->string;
    }
  }

  return $r;
}
function GetDataFromStruct($st, &$key){

  $r = new stdClass();
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      unset($r);
      $r = $st->values->array[$i];
    }
  }

  return $r;
}
function GetDataFromStructWithCheck($st, &$key, $foundRef){

  $r = new stdClass();
  $foundRef->booleanValue = false;
  for($i = 0.0; $i < ArrayLength($st->keys); $i = $i + 1.0){
    if(arraysStringsEqual($st->keys->array[$i]->string, $key)){
      unset($r);
      $foundRef->booleanValue = true;
      $r = $st->values->array[$i];
    }
  }

  return $r;
}
function AddStructToStruct($st, &$key, $struct){

  if(StructHasKey($st, $key)){
    $i = StructKeyIndex($st, $key);
    unset($st->values->array[$i]->structure);
    $st->values->array[$i]->structure = $struct;
  }else{
    AddStringToArray($st->keys, $key);
    AddStructToArray($st->values, $struct);
  }
}
function AddArrayToStruct($st, &$key, $ar){

  if(StructHasKey($st, $key)){
    $i = StructKeyIndex($st, $key);
    unset($st->values->array[$i]->array);
    $st->values->array[$i]->array = $ar;
  }else{
    AddStringToArray($st->keys, $key);
    AddArrayToArray($st->values, $ar);
  }
}
function AddNumberToStruct($st, &$key, $n){

  if(StructHasKey($st, $key)){
    $i = StructKeyIndex($st, $key);
    $st->values->array[$i]->number = $n;
  }else{
    AddStringToArray($st->keys, $key);
    AddNumberToArray($st->values, $n);
  }
}
function AddBooleanToStruct($st, &$key, $b){

  if(StructHasKey($st, $key)){
    $i = StructKeyIndex($st, $key);
    $st->values->array[$i]->booleanx = $b;
  }else{
    AddStringToArray($st->keys, $key);
    AddBooleanToArray($st->values, $b);
  }
}
function AddStringToStruct($st, &$key, &$value){

  if(StructHasKey($st, $key)){
    $i = StructKeyIndex($st, $key);
    unset($st->values->array[$i]->string);
    $st->values->array[$i]->string = $value;
  }else{
    AddStringToArray($st->keys, $key);
    AddStringToArray($st->values, $value);
  }
}
function AddDataToStruct($st, &$key, $data){

  if(StructHasKey($st, $key)){
    $i = StructKeyIndex($st, $key);
    FreeData($st->values->array[$i]);
    $st->values->array[$i] = $data;
  }else{
    AddStringToArray($st->keys, $key);
    AddDataToArray($st->values, $data);
  }
}
function FreeData($data){

  if($data->isStruture){
    $st = $data->structure;
    for($i = 0.0; $i < StructKeys($st); $i = $i + 1.0){
      FreeData(ArrayIndex($st->keys, $i));
      FreeData(ArrayIndex($st->values, $i));
    }
    unset($st);
  }else if($data->isArray){
    FreeArray($data->array);
  }

  unset($data);
}
function FreeArray($array){

  for($i = 0.0; $i < ArrayLength($array); $i = $i + 1.0){
    FreeData($array->array[$i]);
  }

  unset($array->array);
  unset($array);
}
function DataTypeEquals($a, $b){

  $equal = true;
  $equal = $equal && $a->isStruture == $b->isStruture;
  $equal = $equal && $a->isArray == $b->isArray;
  $equal = $equal && $a->isNumber == $b->isNumber;
  $equal = $equal && $a->isBoolean == $b->isBoolean;
  $equal = $equal && $a->isString == $b->isString;

  return $equal;
}
function IsStructure($a){

  $itis = $a->isStruture;
  if($a->isArray || $a->isNumber || $a->isBoolean || $a->isString){
    $itis = false;
  }

  return $itis;
}
function IsArray($a){

  $itis = $a->isArray;
  if($a->isStruture || $a->isNumber || $a->isBoolean || $a->isString){
    $itis = false;
  }

  return $itis;
}
function IsNumber($a){

  $itis = $a->isNumber;
  if($a->isStruture || $a->isArray || $a->isBoolean || $a->isString){
    $itis = false;
  }

  return $itis;
}
function IsBoolean($a){

  $itis = $a->isBoolean;
  if($a->isStruture || $a->isArray || $a->isNumber || $a->isString){
    $itis = false;
  }

  return $itis;
}
function IsString($a){

  $itis = $a->isString;
  if($a->isStruture || $a->isArray || $a->isNumber || $a->isBoolean){
    $itis = false;
  }

  return $itis;
}
function IsNoType($a){

  if( !$a->isString  &&  !$a->isStruture  &&  !$a->isArray  &&  !$a->isNumber  &&  !$a->isBoolean ){
    $itis = true;
  }else{
    $itis = false;
  }

  return $itis;
}
function CreateArray(){

  $array = new stdClass();
  $array->array = array_fill(0, 10.0, 0);
  $array->length = 0.0;

  return $array;
}
function CreateArrayWithInitialCapacity($capacity){

  $array = new stdClass();
  $array->array = array_fill(0, $capacity, 0);
  $array->length = 0.0;

  return $array;
}
function ArrayAdd($array, $value){
  if($array->length == count($array->array)){
    ArrayIncreaseSize($array);
  }

  $array->array[$array->length] = $value;
  $array->length = $array->length + 1.0;
}
function ArrayAddString($array, &$value){

  $data = CreateStringData($value);

  ArrayAdd($array, $data);
}
function ArrayAddBoolean($array, $value){

  $data = CreateBooleanData($value);

  ArrayAdd($array, $data);
}
function ArrayAddNumber($array, $value){

  $data = CreateNumberData($value);

  ArrayAdd($array, $data);
}
function ArrayAddStruct($array, $value){

  $data = CreateStructData($value);

  ArrayAdd($array, $data);
}
function ArrayAddArray($array, $value){

  $data = CreateArrayData($value);

  ArrayAdd($array, $data);
}
function ArrayIncreaseSize($array){

  $newLength = round(count($array->array)*3.0/2.0);
  $newArray = array_fill(0, $newLength, 0);

  for($i = 0.0; $i < count($array->array); $i = $i + 1.0){
    $newArray[$i] = $array->array[$i];
  }

  unset($array->array);

  $array->array = $newArray;
}
function ArrayDecreaseSizeNecessary($array){

  $needsDecrease = false;

  if($array->length > 10.0){
    $needsDecrease = $array->length <= round(count($array->array)*2.0/3.0);
  }

  return $needsDecrease;
}
function ArrayDecreaseSize($array){

  $newLength = round(count($array->array)*2.0/3.0);
  $newArray = array_fill(0, $newLength, 0);

  for($i = 0.0; $i < $newLength; $i = $i + 1.0){
    $newArray[$i] = $array->array[$i];
  }

  unset($array->array);

  $array->array = $newArray;
}
function ArrayIndex($array, $index){
  return $array->array[$index];
}
function ArrayIndexArray($array, $index){
  return $array->array[$index]->array;
}
function ArrayIndexStruct($array, $index){
  return $array->array[$index]->structure;
}
function ArrayIndexBoolean($array, $index){
  return $array->array[$index]->booleanx;
}
function &ArrayIndexString($array, $index){
  return $array->array[$index]->string;
}
function ArrayIndexNumber($array, $index){
  return $array->array[$index]->number;
}
function ArrayLength($array){
  return $array->length;
}
function ArrayInsert($array, $index, $value){

  if($array->length == count($array->array)){
    ArrayIncreaseSize($array);
  }

  for($i = $array->length; $i > $index; $i = $i - 1.0){
    $array->array[$i] = $array->array[$i - 1.0];
  }

  $array->array[$index] = $value;

  $array->length = $array->length + 1.0;
}
function ArrayInsertString($array, $index, &$value){

  $data = CreateStringData($value);

  ArrayInsert($array, $index, $data);
}
function ArrayInsertBoolean($array, $index, $value){

  $data = CreateBooleanData($value);

  ArrayInsert($array, $index, $data);
}
function ArrayInsertNumber($array, $index, $value){

  $data = CreateNumberData($value);

  ArrayInsert($array, $index, $data);
}
function ArrayInsertStruct($array, $index, $value){

  $data = CreateStructData($value);

  ArrayInsert($array, $index, $data);
}
function ArrayInsertArray($array, $index, $value){

  $data = CreateArrayData($value);

  ArrayInsert($array, $index, $data);
}
function ArraySet($array, $index, $value){

  if($index < $array->length){
    $array->array[$index] = $value;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function ArraySetString($array, $index, &$value){

  $data = CreateStringData($value);

  ArraySet($array, $index, $data);
}
function ArraySetBoolean($array, $index, $value){

  $data = CreateBooleanData($value);

  ArraySet($array, $index, $data);
}
function ArraySetNumber($array, $index, $value){

  $data = CreateNumberData($value);

  ArraySet($array, $index, $data);
}
function ArraySetStruct($array, $index, $value){

  $data = CreateStructData($value);

  ArraySet($array, $index, $data);
}
function ArraySetArray($array, $index, $value){

  $data = CreateArrayData($value);

  ArraySet($array, $index, $data);
}
function ArrayRemove($array, $index){

  for($i = $index; $i < $array->length - 1.0; $i = $i + 1.0){
    $array->array[$i] = $array->array[$i + 1.0];
  }

  $array->length = $array->length - 1.0;

  if(ArrayDecreaseSizeNecessary($array)){
    ArrayDecreaseSize($array);
  }
}
function &ToStaticArray($arc){

  $array = array_fill(0, $arc->length, 0);

  for($i = 0.0; $i < $arc->length; $i = $i + 1.0){
    $array[$i] = $arc->array[$i];
  }

  return $array;
}
function &ToStaticNumberArray($array){

  $n = ArrayLength($array);

  $result = array_fill(0, $n, 0);

  for($i = 0.0; $i < $n; $i = $i + 1.0){
    $result[$i] = ArrayIndex($array, $i)->number;
  }

  return $result;
}
function &ToStaticBooleanArray($array){

  $n = ArrayLength($array);

  $result = array_fill(0, $n, 0);

  for($i = 0.0; $i < $n; $i = $i + 1.0){
    $result[$i] = ArrayIndex($array, $i)->booleanx;
  }

  return $result;
}
function &ToStaticStringArray($array){

  $n = ArrayLength($array);

  $result = array_fill(0, $n, 0);

  for($i = 0.0; $i < $n; $i = $i + 1.0){
    $result[$i] = new stdClass();
    $result[$i]->string = ArrayIndex($array, $i)->string;
  }

  return $result;
}
function &ToStaticArrayArray($array){

  $n = ArrayLength($array);

  $result = array_fill(0, $n, 0);

  for($i = 0.0; $i < $n; $i = $i + 1.0){
    $result[$i] = ArrayIndex($array, $i)->array;
  }

  return $result;
}
function &ToStaticStructArray($array){

  $n = ArrayLength($array);

  $result = array_fill(0, $n, 0);

  for($i = 0.0; $i < $n; $i = $i + 1.0){
    $result[$i] = ArrayIndex($array, $i)->structure;
  }

  return $result;
}
function StaticArrayToArrayWithOptimalSize(&$src){

  /*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
         */

  $c = count($src);
  $n = (log($c) - 1.0)/log(3.0/2.0);

  $newCapacity = ceil(10.0*(3.0/2.0)**ceil($n));

  $dst = CreateArrayWithInitialCapacity($newCapacity);

  for($i = 0.0; $i < count($src); $i = $i + 1.0){
    $dst->array[$i] = $src[$i];
  }

  return $dst;
}
function StaticArrayToArray(&$src){

  $dst = CreateArrayWithInitialCapacity(count($src));
  for($i = 0.0; $i < count($src); $i = $i + 1.0){
    $dst->array[$i] = $src[$i];
  }
  $dst->length = count($src);

  return $dst;
}
function &arraysStringToNumberArray(&$string){

  $array = array_fill(0, count($string), 0);

  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    $array[$i] = uniord($string[$i]);
  }
  return $array;
}
function &arraysNumberArrayToString(&$array){

  $string = array_fill(0, count($array), 0);

  for($i = 0.0; $i < count($array); $i = $i + 1.0){
    $string[$i] = unichr($array[$i]);
  }
  return $string;
}
function arraysNumberArraysEqual(&$a, &$b){

  $equal = true;
  if(count($a) == count($b)){
    for($i = 0.0; $i < count($a) && $equal; $i = $i + 1.0){
      if($a[$i] != $b[$i]){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function arraysBooleanArraysEqual(&$a, &$b){

  $equal = true;
  if(count($a) == count($b)){
    for($i = 0.0; $i < count($a) && $equal; $i = $i + 1.0){
      if($a[$i] != $b[$i]){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function arraysStringsEqual(&$a, &$b){

  $equal = true;
  if(count($a) == count($b)){
    for($i = 0.0; $i < count($a) && $equal; $i = $i + 1.0){
      if($a[$i] != $b[$i]){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function arraysFillNumberArray(&$a, $value){

  for($i = 0.0; $i < count($a); $i = $i + 1.0){
    $a[$i] = $value;
  }
}
function arraysFillString(&$a, $value){

  for($i = 0.0; $i < count($a); $i = $i + 1.0){
    $a[$i] = $value;
  }
}
function arraysFillBooleanArray(&$a, $value){

  for($i = 0.0; $i < count($a); $i = $i + 1.0){
    $a[$i] = $value;
  }
}
function arraysFillNumberArrayRange(&$a, $value, $from, $to){

  if($from >= 0.0 && $from <= count($a) && $to >= 0.0 && $to <= count($a) && $from <= $to){
    $length = $to - $from;
    for($i = 0.0; $i < $length; $i = $i + 1.0){
      $a[$from + $i] = $value;
    }

    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function arraysFillBooleanArrayRange(&$a, $value, $from, $to){

  if($from >= 0.0 && $from <= count($a) && $to >= 0.0 && $to <= count($a) && $from <= $to){
    $length = $to - $from;
    for($i = 0.0; $i < $length; $i = $i + 1.0){
      $a[$from + $i] = $value;
    }

    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function arraysFillStringRange(&$a, $value, $from, $to){

  if($from >= 0.0 && $from <= count($a) && $to >= 0.0 && $to <= count($a) && $from <= $to){
    $length = $to - $from;
    for($i = 0.0; $i < $length; $i = $i + 1.0){
      $a[$from + $i] = $value;
    }

    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function &arraysCopyNumberArray(&$a){

  $n = array_fill(0, count($a), 0);

  for($i = 0.0; $i < count($a); $i = $i + 1.0){
    $n[$i] = $a[$i];
  }

  return $n;
}
function &arraysCopyBooleanArray(&$a){

  $n = array_fill(0, count($a), 0);

  for($i = 0.0; $i < count($a); $i = $i + 1.0){
    $n[$i] = $a[$i];
  }

  return $n;
}
function &arraysCopyString(&$a){

  $n = array_fill(0, count($a), 0);

  for($i = 0.0; $i < count($a); $i = $i + 1.0){
    $n[$i] = $a[$i];
  }

  return $n;
}
function arraysCopyNumberArrayRange(&$a, $from, $to, $copyReference){

  if($from >= 0.0 && $from <= count($a) && $to >= 0.0 && $to <= count($a) && $from <= $to){
    $length = $to - $from;
    $n = array_fill(0, $length, 0);

    for($i = 0.0; $i < $length; $i = $i + 1.0){
      $n[$i] = $a[$from + $i];
    }

    $copyReference->numberArray = $n;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function arraysCopyBooleanArrayRange(&$a, $from, $to, $copyReference){

  if($from >= 0.0 && $from <= count($a) && $to >= 0.0 && $to <= count($a) && $from <= $to){
    $length = $to - $from;
    $n = array_fill(0, $length, 0);

    for($i = 0.0; $i < $length; $i = $i + 1.0){
      $n[$i] = $a[$from + $i];
    }

    $copyReference->booleanArray = $n;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function arraysCopyStringRange(&$a, $from, $to, $copyReference){

  if($from >= 0.0 && $from <= count($a) && $to >= 0.0 && $to <= count($a) && $from <= $to){
    $length = $to - $from;
    $n = array_fill(0, $length, 0);

    for($i = 0.0; $i < $length; $i = $i + 1.0){
      $n[$i] = $a[$from + $i];
    }

    $copyReference->string = $n;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function arraysIsLastElement($length, $index){
  return $index + 1.0 == $length;
}
function &arraysCreateNumberArray($length, $value){

  $array = array_fill(0, $length, 0);
  arraysFillNumberArray($array, $value);

  return $array;
}
function &arraysCreateBooleanArray($length, $value){

  $array = array_fill(0, $length, 0);
  arraysFillBooleanArray($array, $value);

  return $array;
}
function &arraysCreateString($length, $value){

  $array = array_fill(0, $length, 0);
  arraysFillString($array, $value);

  return $array;
}
function arraysSwapElementsOfNumberArray(&$A, $ai, $bi){

  $tmp = $A[$ai];
  $A[$ai] = $A[$bi];
  $A[$bi] = $tmp;
}
function arraysSwapElementsOfStringArray($A, $ai, $bi){

  $tmp = $A->stringArray[$ai];
  $A->stringArray[$ai] = $A->stringArray[$bi];
  $A->stringArray[$bi] = $tmp;
}
function arraysReverseNumberArray(&$array){

  for($i = 0.0; $i < count($array)/2.0; $i = $i + 1.0){
    arraysSwapElementsOfNumberArray($array, $i, count($array) - $i - 1.0);
  }
}
function &CreateStringScientificNotationDecimalFromNumber($n){

  $mantissaReference = new stdClass();
  $exponentReference = new stdClass();
  $result = array_fill(0, 0.0, 0);

  if($n < 0.0){
    $isPositive = false;
    $n = -$n;
  }else{
    $isPositive = true;
  }

  if($n == 0.0){
    $e = 0.0;
  }else{
    $e = GetFirstDecimalDigitPosition($n);

    if($e < 0.0){
      $n = $n*10.0**abs($e);
    }else{
      $n = $n/10.0**$e;
    }
  }

  $mantissaReference->string = CreateStringDecimalFromNumber($n);
  $exponentReference->string = CreateStringDecimalFromNumber($e);

  if( !$isPositive ){
    $result = strAppendString($result, mb_str_split("-"));
  }

  $result = strAppendString($result, $mantissaReference->string);
  $result = strAppendString($result, mb_str_split("e"));
  $result = strAppendString($result, $exponentReference->string);

  return $result;
}
function &CreateStringDecimalFromNumber($number){

  $string = CreateDynamicArrayCharacters();
  $isPositive = true;

  if($number < 0.0){
    $isPositive = false;
    $number = -$number;
  }

  if($number == 0.0){
    DynamicArrayAddCharacter($string, "0");
  }else{
    $characterReference = new stdClass();

    $maximumDigits = GetMaximumDigitsForDecimal();

    $digitPosition = GetFirstDecimalDigitPosition($number);

    $hasPrintedPoint = false;

    if( !$isPositive ){
      DynamicArrayAddCharacter($string, "-");
    }

    /* Print leading zeros. */
    if($digitPosition < 0.0){
      DynamicArrayAddCharacter($string, "0");
      DynamicArrayAddCharacter($string, ".");
      $hasPrintedPoint = true;
      for($i = 0.0; $i < -$digitPosition - 1.0; $i = $i + 1.0){
        DynamicArrayAddCharacter($string, "0");
      }
    }

    /* Count trailing zeros */
    $trailingZeros = 0.0;
    $done = false;
    for($i = 0.0; $i < $maximumDigits &&  !$done ; $i = $i + 1.0){
      $d = GetDecimalDigitWithFirstDigitPosition($number, $digitPosition, $maximumDigits - $i - 1.0);
      if($d == 0.0){
        $trailingZeros = $trailingZeros + 1.0;
      }else{
        $done = true;
      }
    }

    /* Print number. */
    for($i = 0.0; $i < $maximumDigits; $i = $i + 1.0){
      $d = GetDecimalDigitWithFirstDigitPosition($number, $digitPosition, $i);

      if( !$hasPrintedPoint  && $digitPosition - $i + 1.0 == 0.0){
        if($maximumDigits - $i > $trailingZeros){
          DynamicArrayAddCharacter($string, ".");
        }
        $hasPrintedPoint = true;
      }

      if($maximumDigits - $i <= $trailingZeros && $hasPrintedPoint){
      }else{
        GetDecimalDigitCharacterFromNumberWithCheck($d, $characterReference);
        $c = $characterReference->characterValue;
        DynamicArrayAddCharacter($string, $c);
      }
    }

    /* Print trailing zeros. */
    for($i = 0.0; $i < $digitPosition - $maximumDigits + 1.0; $i = $i + 1.0){
      DynamicArrayAddCharacter($string, "0");
    }
  }

  /* Done */
  $str = DynamicArrayCharactersToArray($string);
  FreeDynamicArrayCharacters($string);
  return $str;
}
function CreateStringFromNumberWithCheck($number, $base, $stringRef){

  $string = CreateDynamicArrayCharacters();
  $isPositive = true;

  if($number < 0.0){
    $isPositive = false;
    $number = -$number;
  }

  if($number == 0.0){
    DynamicArrayAddCharacter($string, "0");
    $success = true;
  }else{
    $characterReference = new stdClass();

    if(IsInteger($base)){
      $success = true;

      $maximumDigits = GetMaximumDigitsForBase($base);

      $digitPosition = GetFirstDigitPosition($number, $base);

      $hasPrintedPoint = false;

      if( !$isPositive ){
        DynamicArrayAddCharacter($string, "-");
      }

      /* Print leading zeros. */
      if($digitPosition < 0.0){
        DynamicArrayAddCharacter($string, "0");
        DynamicArrayAddCharacter($string, ".");
        $hasPrintedPoint = true;
        for($i = 0.0; $i < -$digitPosition - 1.0; $i = $i + 1.0){
          DynamicArrayAddCharacter($string, "0");
        }
      }

      /* Count trailing zeros */
      $trailingZeros = 0.0;
      $done = false;
      for($i = 0.0; $i < $maximumDigits &&  !$done ; $i = $i + 1.0){
        $d = GetDigit($number, $base, $maximumDigits - $i - 1.0);
        if($d == 0.0){
          $trailingZeros = $trailingZeros + 1.0;
        }else{
          $done = true;
        }
      }

      /* Print number. */
      for($i = 0.0; $i < $maximumDigits && $success; $i = $i + 1.0){
        $d = GetDigit($number, $base, $i);

        if($d >= $base){
          $d = $base - 1.0;
        }

        if( !$hasPrintedPoint  && $digitPosition - $i + 1.0 == 0.0){
          if($maximumDigits - $i > $trailingZeros){
            DynamicArrayAddCharacter($string, ".");
          }
          $hasPrintedPoint = true;
        }

        if($maximumDigits - $i <= $trailingZeros && $hasPrintedPoint){
        }else{
          $success = GetSingleDigitCharacterFromNumberWithCheck($d, $base, $characterReference);
          if($success){
            $c = $characterReference->characterValue;
            DynamicArrayAddCharacter($string, $c);
          }
        }
      }

      if($success){
        /* Print trailing zeros. */
        for($i = 0.0; $i < $digitPosition - $maximumDigits + 1.0; $i = $i + 1.0){
          DynamicArrayAddCharacter($string, "0");
        }
      }
    }else{
      $success = false;
    }
  }

  if($success){
    $stringRef->string = DynamicArrayCharactersToArray($string);
    FreeDynamicArrayCharacters($string);
  }

  /* Done */
  return $success;
}
function GetMaximumDigitsForBase($base){

  $t = 10.0**15.0;
  return floor(log10($t)/log10($base));
}
function GetMaximumDigitsForDecimal(){
  return 15.0;
}
function GetFirstDecimalDigitPosition($n){

  $n = abs($n);

  if($n != 0.0){
    if(floor($n) < 10.0**15.0){
      $multiply = true;
    }else{
      $multiply = false;
    }

    $done = false;
    $m = 0.0;
    for($i = 0.0;  !$done ; $i = $i + 1.0){
      if($multiply){
        $m = $n*10.0**$i;
        if(floor($m) >= 10.0**14.0){
          $done = true;
        }
      }else{
        $m = $n/10.0**$i;
        if(floor($m) < 10.0**15.0){
          $done = true;
        }
      }
    }

    if($multiply){
      $power = 15.0 - $i;
    }else{
      $power = 15.0 + $i - 2.0;
    }

    if(Roundx($m) >= 10.0**15.0){
      $power = $power + 1.0;
    }
  }else{
    $power = 1.0;
  }

  return $power;
}
function GetFirstDigitPosition($n, $base){

  $maximumDigits = GetMaximumDigitsForBase($base);
  $n = abs($n);

  if($n != 0.0){
    if(floor($n) < $base**$maximumDigits){
      $multiply = true;
    }else{
      $multiply = false;
    }

    $done = false;
    $m = 0.0;
    for($i = 0.0;  !$done ; $i = $i + 1.0){
      if($multiply){
        $m = $n*$base**$i;
        if(floor($m) >= $base**($maximumDigits - 1.0)){
          $done = true;
        }
      }else{
        $m = $n/$base**$i;
        if(floor($m) < $base**$maximumDigits){
          $done = true;
        }
      }
    }

    if($multiply){
      $power = $maximumDigits - $i;
    }else{
      $power = $maximumDigits + $i - 2.0;
    }

    if(Roundx($m) >= $base**$maximumDigits){
      $power = $power + 1.0;
    }
  }else{
    $power = 1.0;
  }

  return $power;
}
function GetSingleDigitCharacterFromNumberWithCheck($c, $base, $characterReference){

  $numberTable = GetDigitCharacterTable();

  if($c < $base || $c < count($numberTable)){
    $success = true;
    $characterReference->characterValue = $numberTable[$c];
  }else{
    $success = false;
  }

  return $success;
}
function GetDecimalDigitCharacterFromNumberWithCheck($c, $characterRef){

  $numberTable = mb_str_split("0123456789");

  if($c >= 0.0 && $c < 10.0){
    $success = true;
    $characterRef->characterValue = $numberTable[$c];
  }else{
    $success = false;
  }

  return $success;
}
function &GetDigitCharacterTable(){

  $numberTable = mb_str_split("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");

  return $numberTable;
}
function GetDecimalDigit($n, $index){

  $digitPosition = GetFirstDecimalDigitPosition($n);

  return GetDecimalDigitWithFirstDigitPosition($n, $digitPosition, $index);
}
function GetDecimalDigitWithFirstDigitPosition($n, $digitPosition, $index){

  $n = abs($n);

  $e = 15.0 - $digitPosition - 1.0;
  if($e < 0.0){
    $n = round($n/10.0**abs($e));
  }else{
    $n = round($n*10.0**$e);
  }

  $m = $n;
  $d = 0.0;
  for($i = 0.0; $i < 15.0 - $index; $i = $i + 1.0){
    $d = round($m%10.0);
    $m = $m - $d;
    $m = round($m/10.0);
  }

  return $d;
}
function GetDigit($n, $base, $index){

  $n = abs($n);
  $maximumDigits = GetMaximumDigitsForBase($base);
  $digitPosition = GetFirstDigitPosition($n, $base);

  $e = $maximumDigits - $digitPosition - 1.0;
  if($e < 0.0){
    $n = round($n/$base**abs($e));
  }else{
    $n = round($n*$base**$e);
  }

  $m = $n;
  $d = 0.0;
  for($i = 0.0; $i < $maximumDigits - $index; $i = $i + 1.0){
    $d = round($m%$base);
    $m = $m - $d;
    $m = round($m/$base);
  }

  return $d;
}
function &NumberToHumanReadableShortScale($n){

  $k = 1000.0;
  $M = $k*1000.0;
  $B = $M*1000.0;
  $T = $B*1000.0;
  $Q = $T*1000.0;
  $suffix = mb_str_split(" ");

  if($n < $k){
    $hasSuffix = false;
  }else{
    $hasSuffix = true;
  }

  if($n >= $k && $n < $M){
    if($n < 10.0*$k){
      $n = Roundx($n/100.0);
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$k);
    }
    $suffix = mb_str_split("k");
  }else if($n >= $M && $n < $B){
    if($n < 10.0*$M){
      $n = Roundx($n/($k*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$M);
    }
    $suffix = mb_str_split("M");
  }else if($n >= $B && $n < $T){
    if($n < 10.0*$B){
      $n = Roundx($n/($M*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$B);
    }
    $suffix = mb_str_split("B");
  }else if($n >= $T && $n < $Q){
    if($n < 10.0*$T){
      $n = Roundx($n/($B*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$T);
    }
    $suffix = mb_str_split("T");
  }else if($n >= $Q){
    if($n < 10.0*$Q){
      $n = Roundx($n/($T*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Q);
    }
    $suffix = mb_str_split("Q");
  }

  $res = CreateStringDecimalFromNumber($n);
  if($hasSuffix){
    $res = strAppendString($res, $suffix);
  }
        
  return $res;
}
function &NumberToHumanReadableBinary($n){

  $Ki = 1024.0;
  $Mi = $Ki*1024.0;
  $Gi = $Mi*1024.0;
  $Ti = $Gi*1024.0;
  $Pi = $Ti*1024.0;
  $Ei = $Pi*1024.0;
  $Zi = $Ei*1024.0;
  $Yi = $Zi*1024.0;
  $suffix = mb_str_split(" ");

  if($n < $Ki){
    $hasSuffix = false;
  }else{
    $hasSuffix = true;
  }

  if($n >= $Ki && $n < $Mi){
    if($n < 10.0*$Ki){
      $n = Roundx($n/($Ki/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Ki);
    }
    $suffix = mb_str_split("Ki");
  }else if($n >= $Mi && $n < $Gi){
    if($n < 10.0*$Mi){
      $n = Roundx($n/($Mi/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Mi);
    }
    $suffix = mb_str_split("Mi");
  }else if($n >= $Gi && $n < $Ti){
    if($n < 10.0*$Gi){
      $n = Roundx($n/($Gi/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Gi);
    }
    $suffix = mb_str_split("Gi");
  }else if($n >= $Ti && $n < $Pi){
    if($n < 10.0*$Ti){
      $n = Roundx($n/($Ti/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Ti);
    }
    $suffix = mb_str_split("Ti");
  }else if($n >= $Pi && $n < $Ei){
    if($n < 10.0*$Pi){
      $n = Roundx($n/($Pi/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Pi);
    }
    $suffix = mb_str_split("Pi");
  }else if($n >= $Ei && $n < $Zi){
    if($n < 10.0*$Ei){
      $n = Roundx($n/($Ei/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Ei);
    }
    $suffix = mb_str_split("Ei");
  }else if($n >= $Zi && $n < $Yi){
    if($n < 10.0*$Zi){
      $n = Roundx($n/($Zi/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Zi);
    }
    $suffix = mb_str_split("Zi");
  }else if($n >= $Yi){
    if($n < 10.0*$Yi){
      $n = Roundx($n/($Yi/10.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Yi);
    }
    $suffix = mb_str_split("Yi");
  }

  $res = CreateStringDecimalFromNumber($n);
  if($hasSuffix){
    $res = strAppendString($res, $suffix);
  }

  return $res;
}
function &NumberToHumanReadableMetric($n){

  $k = 1000.0;
  $M = $k*1000.0;
  $G = $M*1000.0;
  $T = $G*1000.0;
  $P = $T*1000.0;
  $Ex = $P*1000.0;
  $Z = $Ex*1000.0;
  $Y = $Z*1000.0;
  $R = $Y*1000.0;
  $Q = $R*1000.0;
  $suffix = mb_str_split(" ");

  if($n < $k){
    $hasSuffix = false;
  }else{
    $hasSuffix = true;
  }

  if($n >= $k && $n < $M){
    if($n < 10.0*$k){
      $n = Roundx($n/100.0);
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$k);
    }
    $suffix = mb_str_split("k");
  }else if($n >= $M && $n < $G){
    if($n < 10.0*$M){
      $n = Roundx($n/($k*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$M);
    }
    $suffix = mb_str_split("M");
  }else if($n >= $G && $n < $T){
    if($n < 10.0*$G){
      $n = Roundx($n/($M*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$G);
    }
    $suffix = mb_str_split("G");
  }else if($n >= $T && $n < $P){
    if($n < 10.0*$T){
      $n = Roundx($n/($G*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$T);
    }
    $suffix = mb_str_split("T");
  }else if($n >= $P && $n < $Ex){
    if($n < 10.0*$P){
      $n = Roundx($n/($T*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$P);
    }
    $suffix = mb_str_split("P");
  }else if($n >= $Ex && $n < $Z){
    if($n < 10.0*$Ex){
      $n = Roundx($n/($P*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Ex);
    }
    $suffix = mb_str_split("E");
  }else if($n >= $Z && $n < $Y){
    if($n < 10.0*$Z){
      $n = Roundx($n/($Ex*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Z);
    }
    $suffix = mb_str_split("Z");
  }else if($n >= $Y && $n < $R){
    if($n < 10.0*$Y){
      $n = Roundx($n/($Z*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Y);
    }
    $suffix = mb_str_split("Y");
  }else if($n >= $R && $n < $Q){
    if($n < 10.0*$R){
      $n = Roundx($n/($Y*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$R);
    }
    $suffix = mb_str_split("R");
  }else if($n >= $Q){
    if($n < 10.0*$Q){
      $n = Roundx($n/($R*100.0));
      $n = $n/10.0;
    }else{
      $n = Roundx($n/$Q);
    }
    $suffix = mb_str_split("Q");
  }

  $res = CreateStringDecimalFromNumber($n);
  if($hasSuffix){
    $res = strAppendString($res, $suffix);
  }

  return $res;
}
function IsValidNumber(&$str){

  $numberRef = new stdClass();
  $message = new stdClass();

  $valid = CreateNumberFromDecimalStringWithCheck($str, $numberRef, $message);

  unset($numberRef);
  unset($message);

  return $valid;
}
function IsValidInteger(&$str){

  $numberRef = new stdClass();
  $message = new stdClass();

  $valid = CreateNumberFromDecimalStringWithCheck($str, $numberRef, $message);

  if($valid){
    $valid = IsInteger($numberRef->numberValue);
  }

  unset($numberRef);
  unset($message);

  return $valid;
}
function IsValidPositiveInteger(&$str){

  $numberRef = new stdClass();
  $message = new stdClass();

  $valid = CreateNumberFromDecimalStringWithCheck($str, $numberRef, $message);

  if($valid){
    $valid = IsInteger($numberRef->numberValue);
    if($valid){
      $valid = $numberRef->numberValue >= 0.0;
    }
  }

  unset($numberRef);
  unset($message);

  return $valid;
}
function CreateNumberFromDecimalStringWithCheck(&$string, $decimalReference, $message){
  return CreateNumberFromStringWithCheck($string, 10.0, $decimalReference, $message);
}
function CreateNumberFromDecimalString(&$string){

  $doubleReference = CreateNumberReference(0.0);
  $stringReference = CreateStringReference(mb_str_split(""));
  CreateNumberFromStringWithCheck($string, 10.0, $doubleReference, $stringReference);
  $number = $doubleReference->numberValue;

  unset($doubleReference);
  unset($stringReference);

  return $number;
}
function CreateNumberFromStringWithCheck(&$string, $base, $numberReference, $message){

  $numberIsPositive = CreateBooleanReference(true);
  $exponentIsPositive = CreateBooleanReference(true);
  $beforePoint = new stdClass();
  $afterPoint = new stdClass();
  $exponent = new stdClass();

  if($base >= 2.0 && $base <= 36.0){
    $success = ExtractPartsFromNumberString($string, $base, $numberIsPositive, $beforePoint, $afterPoint, $exponentIsPositive, $exponent, $message);

    if($success){
      $numberReference->numberValue = CreateNumberFromParts($base, $numberIsPositive->booleanValue, $beforePoint->numberArray, $afterPoint->numberArray, $exponentIsPositive->booleanValue, $exponent->numberArray);
    }
  }else{
    $success = false;
    $message->string = mb_str_split("Base must be from 2 to 36.");
  }

  return $success;
}
function CreateNumberFromParts($base, $numberIsPositive, &$beforePoint, &$afterPoint, $exponentIsPositive, &$exponent){

  $n = 0.0;

  for($i = 0.0; $i < count($beforePoint); $i = $i + 1.0){
    $p = $beforePoint[count($beforePoint) - $i - 1.0];

    $n = $n + $p*$base**$i;
  }

  for($i = 0.0; $i < count($afterPoint); $i = $i + 1.0){
    $p = $afterPoint[$i];

    $n = $n + $p/$base**($i + 1.0);
  }

  if(count($exponent) > 0.0){
    $e = 0.0;
    for($i = 0.0; $i < count($exponent); $i = $i + 1.0){
      $p = $exponent[count($exponent) - $i - 1.0];

      $e = $e + $p*$base**$i;
    }

    if( !$exponentIsPositive ){
      $e = -$e;
    }

    $n = $n*$base**$e;
  }

  if( !$numberIsPositive ){
    $n = -$n;
  }

  return $n;
}
function ExtractPartsFromNumberString(&$n, $base, $numberIsPositive, $beforePoint, $afterPoint, $exponentIsPositive, $exponent, $errorMessages){

  $i = 0.0;
  $complete = false;

  if($i < count($n)){
    if($n[$i] == "-"){
      $numberIsPositive->booleanValue = false;
      $i = $i + 1.0;
    }else if($n[$i] == "+"){
      $numberIsPositive->booleanValue = true;
      $i = $i + 1.0;
    }

    $success = true;
  }else{
    $success = false;
    $errorMessages->string = mb_str_split("Number cannot have length zero.");
  }

  if($success){
    $done = false;
    $count = 0.0;
    for(; $i + $count < count($n) &&  !$done ; ){
      if(CharacterIsNumberCharacterInBase($n[$i + $count], $base)){
        $count = $count + 1.0;
      }else{
        $done = true;
      }
    }

    if($count >= 1.0){
      $beforePoint->numberArray = array_fill(0, $count, 0);

      for($j = 0.0; $j < $count; $j = $j + 1.0){
        $beforePoint->numberArray[$j] = GetNumberFromNumberCharacterForBase($n[$i + $j], $base);
      }

      $i = $i + $count;

      if($i < count($n)){
        $success = true;
      }else{
        $afterPoint->numberArray = array_fill(0, 0.0, 0);
        $exponent->numberArray = array_fill(0, 0.0, 0);
        $success = true;
        $complete = true;
      }
    }else{
      $success = false;
      $errorMessages->string = mb_str_split("Number must have at least one number after the optional sign.");
    }
  }

  if($success &&  !$complete ){
    if($n[$i] == "."){
      $i = $i + 1.0;

      if($i < count($n)){
        $done = false;
        $count = 0.0;
        for(; $i + $count < count($n) &&  !$done ; ){
          if(CharacterIsNumberCharacterInBase($n[$i + $count], $base)){
            $count = $count + 1.0;
          }else{
            $done = true;
          }
        }

        if($count >= 1.0){
          $afterPoint->numberArray = array_fill(0, $count, 0);

          for($j = 0.0; $j < $count; $j = $j + 1.0){
            $afterPoint->numberArray[$j] = GetNumberFromNumberCharacterForBase($n[$i + $j], $base);
          }

          $i = $i + $count;

          if($i < count($n)){
            $success = true;
          }else{
            $exponent->numberArray = array_fill(0, 0.0, 0);
            $success = true;
            $complete = true;
          }
        }else{
          $success = false;
          $errorMessages->string = mb_str_split("There must be at least one digit after the decimal point.");
        }
      }else{
        $success = false;
        $errorMessages->string = mb_str_split("There must be at least one digit after the decimal point.");
      }
    }else if($base <= 14.0 && ($n[$i] == "e" || $n[$i] == "E")){
      if($i < count($n)){
        $success = true;
        $afterPoint->numberArray = array_fill(0, 0.0, 0);
      }else{
        $success = false;
        $errorMessages->string = mb_str_split("There must be at least one digit after the exponent.");
      }
    }else{
      $success = false;
      $errorMessages->string = mb_str_split("Expected decimal point or exponent symbol.");
    }
  }

  if($success &&  !$complete ){
    if($base <= 14.0 && ($n[$i] == "e" || $n[$i] == "E")){
      $i = $i + 1.0;

      if($i < count($n)){
        if($n[$i] == "-"){
          $exponentIsPositive->booleanValue = false;
          $i = $i + 1.0;
        }else if($n[$i] == "+"){
          $exponentIsPositive->booleanValue = true;
          $i = $i + 1.0;
        }

        if($i < count($n)){
          $done = false;
          $count = 0.0;
          for(; $i + $count < count($n) &&  !$done ; ){
            if(CharacterIsNumberCharacterInBase($n[$i + $count], $base)){
              $count = $count + 1.0;
            }else{
              $done = true;
            }
          }

          if($count >= 1.0){
            $exponent->numberArray = array_fill(0, $count, 0);

            for($j = 0.0; $j < $count; $j = $j + 1.0){
              $exponent->numberArray[$j] = GetNumberFromNumberCharacterForBase($n[$i + $j], $base);
            }

            $i = $i + $count;

            if($i == count($n)){
              $success = true;
            }else{
              $success = false;
              $errorMessages->string = mb_str_split("There cannot be any characters past the exponent of the number.");
            }
          }else{
            $success = false;
            $errorMessages->string = mb_str_split("There must be at least one digit after the decimal point.");
          }
        }else{
          $success = false;
          $errorMessages->string = mb_str_split("There must be at least one digit after the exponent symbol.");
        }
      }else{
        $success = false;
        $errorMessages->string = mb_str_split("There must be at least one digit after the exponent symbol.");
      }
    }else{
      $success = false;
      $errorMessages->string = mb_str_split("Expected exponent symbol.");
    }
  }

  return $success;
}
function GetNumberFromNumberCharacterForBase($c, $base){

  $numberTable = GetDigitCharacterTable();
  $position = 0.0;

  for($i = 0.0; $i < $base; $i = $i + 1.0){
    if($numberTable[$i] == $c){
      $position = $i;
    }
  }

  return $position;
}
function CharacterIsNumberCharacterInBase($c, $base){

  $numberTable = GetDigitCharacterTable();
  $found = false;

  for($i = 0.0; $i < $base; $i = $i + 1.0){
    if($numberTable[$i] == $c){
      $found = true;
    }
  }

  return $found;
}
function &StringToNumberArray(&$str){

  $numberArrayReference = new stdClass();
  $stringReference = new stdClass();

  StringToNumberArrayWithCheck($str, $numberArrayReference, $stringReference);

  $numbers = $numberArrayReference->numberArray;

  unset($numberArrayReference);
  unset($stringReference);

  return $numbers;
}
function StringToNumberArrayWithCheck(&$str, $numberArrayReference, $errorMessage){

  $numberStrings = strSplitByString($str, mb_str_split(","));

  $numbers = array_fill(0, count($numberStrings), 0);
  $success = true;
  $numberReference = new stdClass();

  for($i = 0.0; $i < count($numberStrings); $i = $i + 1.0){
    $numberString = $numberStrings[$i]->string;
    $trimmedNumberString = strTrim($numberString);
    $success = CreateNumberFromDecimalStringWithCheck($trimmedNumberString, $numberReference, $errorMessage);
    $numbers[$i] = $numberReference->numberValue;

    FreeStringReference($numberStrings[$i]);
    unset($trimmedNumberString);
  }

  unset($numberStrings);
  unset($numberReference);

  $numberArrayReference->numberArray = $numbers;

  return $success;
}
function strWriteStringToStingStream(&$stream, $index, &$src){

  for($i = 0.0; $i < count($src); $i = $i + 1.0){
    $stream[$index->numberValue + $i] = $src[$i];
  }
  $index->numberValue = $index->numberValue + count($src);
}
function strWriteCharacterToStingStream(&$stream, $index, $src){
  $stream[$index->numberValue] = $src;
  $index->numberValue = $index->numberValue + 1.0;
}
function strWriteBooleanToStingStream(&$stream, $index, $src){
  if($src){
    strWriteStringToStingStream($stream, $index, mb_str_split("true"));
  }else{
    strWriteStringToStingStream($stream, $index, mb_str_split("false"));
  }
}
function strSubstringWithCheck(&$string, $from, $to, $stringReference){

  if($from >= 0.0 && $from <= count($string) && $to >= 0.0 && $to <= count($string) && $from <= $to){
    $stringReference->string = strSubstring($string, $from, $to);
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function &strSubstring(&$string, $from, $to){

  $length = $to - $from;

  $n = array_fill(0, $length, 0);

  for($i = $from; $i < $to; $i = $i + 1.0){
    $n[$i - $from] = $string[$i];
  }

  return $n;
}
function &strAppendString(&$s1, &$s2){

  $newString = strConcatenateString($s1, $s2);

  unset($s1);

  return $newString;
}
function &strConcatenateString(&$s1, &$s2){

  $newString = array_fill(0, count($s1) + count($s2), 0);

  for($i = 0.0; $i < count($s1); $i = $i + 1.0){
    $newString[$i] = $s1[$i];
  }

  for($i = 0.0; $i < count($s2); $i = $i + 1.0){
    $newString[count($s1) + $i] = $s2[$i];
  }

  return $newString;
}
function &strAppendCharacter(&$string, $c){

  $newString = strConcatenateCharacter($string, $c);

  unset($string);

  return $newString;
}
function &strConcatenateCharacter(&$string, $c){
  $newString = array_fill(0, count($string) + 1.0, 0);

  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    $newString[$i] = $string[$i];
  }

  $newString[count($string)] = $c;

  return $newString;
}
function &strSplitByCharacter(&$toSplit, $splitBy){

  $ll = CreateLinkedListString();

  $next = CreateLinkedListCharacter();
  for($i = 0.0; $i < count($toSplit); $i = $i + 1.0){
    $c = $toSplit[$i];

    if($c == $splitBy){
      $part = LinkedListCharactersToArray($next);
      LinkedListAddString($ll, $part);
      FreeLinkedListCharacter($next);
      $next = CreateLinkedListCharacter();
    }else{
      LinkedListAddCharacter($next, $c);
    }
  }

  $part = LinkedListCharactersToArray($next);
  LinkedListAddString($ll, $part);
  FreeLinkedListCharacter($next);

  $parts = LinkedListStringsToArray($ll);
  FreeLinkedListString($ll);

  return $parts;
}
function strIndexOfCharacter(&$string, $character, $indexReference){

  $found = false;
  for($i = 0.0; $i < count($string) &&  !$found ; $i = $i + 1.0){
    if($string[$i] == $character){
      $found = true;
      $indexReference->numberValue = $i;
    }
  }

  return $found;
}
function strLastIndexOfCharacter(&$string, $character, $indexReference){

  $found = false;
  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    if($string[$i] == $character){
      $found = true;
      $indexReference->numberValue = $i;
    }
  }

  return $found;
}
function strSubstringEqualsWithCheck(&$string, $from, &$substring, $equalsReference){

  if($from < count($string)){
    $success = true;
    $equalsReference->booleanValue = strSubstringEquals($string, $from, $substring);
  }else{
    $success = false;
  }

  return $success;
}
function strSubstringEquals(&$string, $from, &$substring){

  $equal = true;
  if(count($string) - $from >= count($substring)){
    for($i = 0.0; $i < count($substring) && $equal; $i = $i + 1.0){
      if($string[$from + $i] != $substring[$i]){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function strIndexOfString(&$string, &$substring, $indexReference){

  $found = false;
  for($i = 0.0; $i < count($string) - count($substring) + 1.0 &&  !$found ; $i = $i + 1.0){
    if(strSubstringEquals($string, $i, $substring)){
      $found = true;
      $indexReference->numberValue = $i;
    }
  }

  return $found;
}
function strContainsCharacter(&$string, $character){

  $found = false;
  for($i = 0.0; $i < count($string) &&  !$found ; $i = $i + 1.0){
    if($string[$i] == $character){
      $found = true;
    }
  }

  return $found;
}
function strContainsString(&$string, &$substring){
  return strIndexOfString($string, $substring, new stdClass());
}
function strToUpperCase(&$string){

  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    $string[$i] = cToUpperCase($string[$i]);
  }
}
function strToLowerCase(&$string){

  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    $string[$i] = cToLowerCase($string[$i]);
  }
}
function strEqualsIgnoreCase(&$a, &$b){

  if(count($a) == count($b)){
    $equal = true;
    for($i = 0.0; $i < count($a) && $equal; $i = $i + 1.0){
      if(cToLowerCase($a[$i]) != cToLowerCase($b[$i])){
        $equal = false;
      }
    }
  }else{
    $equal = false;
  }

  return $equal;
}
function &strReplaceString(&$string, &$toReplace, &$replaceWith){

  $da = CreateDynamicArrayCharacters();

  $equalsReference = new stdClass();

  for($i = 0.0; $i < count($string); ){
    $success = strSubstringEqualsWithCheck($string, $i, $toReplace, $equalsReference);
    if($success){
      $success = $equalsReference->booleanValue;
    }

    if($success && count($toReplace) > 0.0){
      for($j = 0.0; $j < count($replaceWith); $j = $j + 1.0){
        DynamicArrayAddCharacter($da, $replaceWith[$j]);
      }
      $i = $i + count($toReplace);
    }else{
      DynamicArrayAddCharacter($da, $string[$i]);
      $i = $i + 1.0;
    }
  }

  $result = DynamicArrayCharactersToArray($da);

  FreeDynamicArrayCharacters($da);

  return $result;
}
function &strReplaceCharacterToNew(&$string, $toReplace, $replaceWith){

  $result = array_fill(0, count($string), 0);

  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    if($string[$i] == $toReplace){
      $result[$i] = $replaceWith;
    }else{
      $result[$i] = $string[$i];
    }
  }

  return $result;
}
function strReplaceCharacter(&$string, $toReplace, $replaceWith){

  for($i = 0.0; $i < count($string); $i = $i + 1.0){
    if($string[$i] == $toReplace){
      $string[$i] = $replaceWith;
    }
  }
}
function &strTrim(&$string){

  /* Find whitepaces at the start. */
  $lastWhitespaceLocationStart = -1.0;
  $firstNonWhitespaceFound = false;
  for($i = 0.0; $i < count($string) &&  !$firstNonWhitespaceFound ; $i = $i + 1.0){
    if(cIsWhiteSpace($string[$i])){
      $lastWhitespaceLocationStart = $i;
    }else{
      $firstNonWhitespaceFound = true;
    }
  }

  /* Find whitepaces at the end. */
  $lastWhitespaceLocationEnd = count($string);
  $firstNonWhitespaceFound = false;
  for($i = count($string) - 1.0; $i >= 0.0 &&  !$firstNonWhitespaceFound ; $i = $i - 1.0){
    if(cIsWhiteSpace($string[$i])){
      $lastWhitespaceLocationEnd = $i;
    }else{
      $firstNonWhitespaceFound = true;
    }
  }

  if($lastWhitespaceLocationStart < $lastWhitespaceLocationEnd){
    $result = strSubstring($string, $lastWhitespaceLocationStart + 1.0, $lastWhitespaceLocationEnd);
  }else{
    $result = array_fill(0, 0.0, 0);
  }

  return $result;
}
function strStartsWith(&$string, &$start){

  $startsWithString = false;
  if(count($string) >= count($start)){
    $startsWithString = strSubstringEquals($string, 0.0, $start);
  }

  return $startsWithString;
}
function strEndsWith(&$string, &$end){

  $endsWithString = false;
  if(count($string) >= count($end)){
    $endsWithString = strSubstringEquals($string, count($string) - count($end), $end);
  }

  return $endsWithString;
}
function &strSplitByString(&$toSplit, &$splitBy){

  $ll = CreateLinkedListString();

  $next = CreateLinkedListCharacter();
  for($i = 0.0; $i < count($toSplit); ){
    $c = $toSplit[$i];

    if(strSubstringEquals($toSplit, $i, $splitBy)){
      $part = LinkedListCharactersToArray($next);
      LinkedListAddString($ll, $part);
      FreeLinkedListCharacter($next);
      $next = CreateLinkedListCharacter();
      $i = $i + count($splitBy);
    }else{
      LinkedListAddCharacter($next, $c);
      $i = $i + 1.0;
    }
  }

  $part = LinkedListCharactersToArray($next);
  LinkedListAddString($ll, $part);
  FreeLinkedListCharacter($next);

  $parts = LinkedListStringsToArray($ll);
  FreeLinkedListString($ll);

  return $parts;
}
function strStringIsBefore(&$a, &$b){

  $before = false;
  $equal = true;
  $done = false;

  if(count($a) == 0.0 && count($b) > 0.0){
    $before = true;
  }else{
    for($i = 0.0; $i < count($a) && $i < count($b) &&  !$done ; $i = $i + 1.0){
      if($a[$i] != $b[$i]){
        $equal = false;
      }
      if(cCharacterIsBefore($a[$i], $b[$i])){
        $before = true;
      }
      if(cCharacterIsBefore($b[$i], $a[$i])){
        $done = true;
      }
    }

    if($equal){
      if(count($a) < count($b)){
        $before = true;
      }
    }
  }

  return $before;
}
function &strJoinStringsWithSeparator(&$strings, &$separator){

  $index = CreateNumberReference(0.0);

  $length = 0.0;
  for($i = 0.0; $i < count($strings); $i = $i + 1.0){
    $length = $length + count($strings[$i]->string);
  }
  $length = $length + (count($strings) - 1.0)*count($separator);

  $result = array_fill(0, $length, 0);

  for($i = 0.0; $i < count($strings); $i = $i + 1.0){
    $string = $strings[$i]->string;
    strWriteStringToStingStream($result, $index, $string);
    if($i + 1.0 < count($strings)){
      strWriteStringToStingStream($result, $index, $separator);
    }
  }

  unset($index);

  return $result;
}
function &strJoinStrings(&$strings){

  $index = CreateNumberReference(0.0);

  $length = 0.0;
  for($i = 0.0; $i < count($strings); $i = $i + 1.0){
    $length = $length + count($strings[$i]->string);
  }

  $result = array_fill(0, $length, 0);

  for($i = 0.0; $i < count($strings); $i = $i + 1.0){
    $string = $strings[$i]->string;
    strWriteStringToStingStream($result, $index, $string);
  }

  unset($index);

  return $result;
}
function strStringOrder(&$a, &$b){

  $minimum = min(count($a), count($b));

  $done = false;
  $order = 0.0;
  for($i = 0.0; $i < $minimum &&  !$done ; $i = $i + 1.0){
    $ac = uniord($a[$i]);
    $bc = uniord($b[$i]);

    if($ac < $bc){
      $done = true;
      $order = 1.0;
    }else if($ac > $bc){
      $done = true;
      $order = -1.0;
    }
  }

  if( !$done ){
    if(count($a) < count($b)){
      $order = 1.0;
    }else if(count($a) > count($b)){
      $order = -1.0;
    }
  }

  return $order;
}
function &strLeftPad(&$str, $width){

  $padded = array_fill(0, $width, 0);
  arraysFillString($padded, " ");

  for($i = 0.0; $i < count($str); $i = $i + 1.0){
    $padded[$width - count($str) + $i] = $str[$i];
  }

  return $padded;
}
function &strRightPad(&$str, $width){

  $padded = array_fill(0, $width, 0);
  arraysFillString($padded, " ");

  for($i = 0.0; $i < count($str); $i = $i + 1.0){
    $padded[$i] = $str[$i];
  }

  return $padded;
}
function AssertFalse($b, $failures){
  if($b){
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertTrue($b, $failures){
  if( !$b ){
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertEquals($a, $b, $failures){
  if($a != $b){
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertBooleansEqual($a, $b, $failures){
  if($a != $b){
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertCharactersEqual($a, $b, $failures){
  if($a != $b){
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertStringEquals(&$a, &$b, $failures){
  if( !arraysStringsEqual($a, $b) ){
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertNumberArraysEqual(&$a, &$b, $failures){

  if(count($a) == count($b)){
    for($i = 0.0; $i < count($a); $i = $i + 1.0){
      AssertEquals($a[$i], $b[$i], $failures);
    }
  }else{
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertBooleanArraysEqual(&$a, &$b, $failures){

  if(count($a) == count($b)){
    for($i = 0.0; $i < count($a); $i = $i + 1.0){
      AssertBooleansEqual($a[$i], $b[$i], $failures);
    }
  }else{
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function AssertStringArraysEqual(&$a, &$b, $failures){

  if(count($a) == count($b)){
    for($i = 0.0; $i < count($a); $i = $i + 1.0){
      AssertStringEquals($a[$i]->string, $b[$i]->string, $failures);
    }
  }else{
    $failures->numberValue = $failures->numberValue + 1.0;
  }
}
function Negate($x){
  return -$x;
}
function Positive($x){
  return +$x;
}
function Factorial($x){

  $f = 1.0;

  for($i = 2.0; $i <= $x; $i = $i + 1.0){
    $f = $f*$i;
  }

  return $f;
}
function Roundx($x){
  return floor($x + 0.5);
}
function RoundToDigits($element, $digitsAfterPoint){
  return Roundx($element*10.0**$digitsAfterPoint)/10.0**$digitsAfterPoint;
}
function BankersRound($x){

  if(Absolute($x - Truncate($x)) == 0.5){
    if( !DivisibleBy(Roundx($x), 2.0) ){
      $r = Roundx($x) - 1.0;
    }else{
      $r = Roundx($x);
    }
  }else{
    $r = Roundx($x);
  }

  return $r;
}
function Ceilx($x){
  return ceil($x);
}
function Floorx($x){
  return floor($x);
}
function Truncate($x){

  if($x >= 0.0){
    $t = floor($x);
  }else{
    $t = ceil($x);
  }

  return $t;
}
function Absolute($x){
  return abs($x);
}
function Logarithm($x){
  return log10($x);
}
function NaturalLogarithm($x){
  return log($x);
}
function Sinx($x){
  return sin($x);
}
function Cosx($x){
  return cos($x);
}
function Tanx($x){
  return tan($x);
}
function Asinx($x){
  return asin($x);
}
function Acosx($x){
  return acos($x);
}
function Atanx($x){
  return atan($x);
}
function Atan2x($y, $x){

  /* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors. */
  $a = 0.0;

  if($x > 0.0){
    $a = Atanx($y/$x);
  }else if($x < 0.0 && $y >= 0.0){
    $a = Atanx($y/$x) + M_PI;
  }else if($x < 0.0 && $y < 0.0){
    $a = Atanx($y/$x) - M_PI;
  }else if($x == 0.0 && $y > 0.0){
    $a = M_PI/2.0;
  }else if($x == 0.0 && $y < 0.0){
    $a = -M_PI/2.0;
  }

  return $a;
}
function Squareroot($x){
  return sqrt($x);
}
function Expx($x){
  return exp($x);
}
function DivisibleBy($a, $b){
  return (($a%$b) == 0.0);
}
function Combinations($n, $k){

  $c = 1.0;
  $j = 1.0;
  $i = $n - $k + 1.0;

  for(; $i <= $n; ){
    $c = $c*$i;
    $c = $c/$j;

    $i = $i + 1.0;
    $j = $j + 1.0;
  }

  return $c;
}
function Permutations($n, $k){

  $c = 1.0;

  for($i = $n - $k + 1.0; $i <= $n; $i = $i + 1.0){
    $c = $c*$i;
  }

  return $c;
}
function EpsilonCompare($a, $b, $epsilon){
  return abs($a - $b) < $epsilon;
}
function GreatestCommonDivisor($a, $b){

  for(; $b != 0.0; ){
    $t = $b;
    $b = $a%$b;
    $a = $t;
  }

  return $a;
}
function GCDWithSubtraction($a, $b){

  if($a == 0.0){
    $g = $b;
  }else{
    for(; $b != 0.0; ){
      if($a > $b){
        $a = $a - $b;
      }else{
        $b = $b - $a;
      }
    }

    $g = $a;
  }

  return $g;
}
function IsInteger($a){
  return ($a - floor($a)) == 0.0;
}
function GreatestCommonDivisorWithCheck($a, $b, $gcdReference){

  if(IsInteger($a) && IsInteger($b)){
    $gcd = GreatestCommonDivisor($a, $b);
    $gcdReference->numberValue = $gcd;
    $success = true;
  }else{
    $success = false;
  }

  return $success;
}
function LeastCommonMultiple($a, $b){

  if($a > 0.0 && $b > 0.0){
    $lcm = abs($a*$b)/GreatestCommonDivisor($a, $b);
  }else{
    $lcm = 0.0;
  }

  return $lcm;
}
function Sign($a){

  if($a > 0.0){
    $s = 1.0;
  }else if($a < 0.0){
    $s = -1.0;
  }else{
    $s = 0.0;
  }

  return $s;
}
function Maxx($a, $b){
  return max($a, $b);
}
function Minx($a, $b){
  return min($a, $b);
}
function Power($a, $b){
  return $a**$b;
}
function Gamma($x){
  return LanczosApproximation($x);
}
function LogGamma($x){
  return log(Gamma($x));
}
function LanczosApproximation($z){

  $p = array_fill(0, 8.0, 0);
  $p[0.0] = 676.5203681218851;
  $p[1.0] = -1259.1392167224028;
  $p[2.0] = 771.32342877765313;
  $p[3.0] = -176.61502916214059;
  $p[4.0] = 12.507343278686905;
  $p[5.0] = -0.13857109526572012;
  $p[6.0] = 9.9843695780195716e-6;
  $p[7.0] = 1.5056327351493116e-7;

  if($z < 0.5){
    $y = M_PI/(sin(M_PI*$z)*LanczosApproximation(1.0 - $z));
  }else{
    $z = $z - 1.0;
    $x = 0.99999999999980993;
    for($i = 0.0; $i < count($p); $i = $i + 1.0){
      $x = $x + $p[$i]/($z + $i + 1.0);
    }
    $t = $z + count($p) - 0.5;
    $y = sqrt(2.0*M_PI)*$t**($z + 0.5)*exp(-$t)*$x;
  }

  return $y;
}
function Beta($x, $y){
  return Gamma($x)*Gamma($y)/Gamma($x + $y);
}
function Sinhx($x){
  return (exp($x) - exp(-$x))/2.0;
}
function Coshx($x){
  return (exp($x) + exp(-$x))/2.0;
}
function Tanhx($x){
  return Sinhx($x)/Coshx($x);
}
function Cot($x){
  return 1.0/tan($x);
}
function Sec($x){
  return 1.0/cos($x);
}
function Csc($x){
  return 1.0/sin($x);
}
function Coth($x){
  return Coshx($x)/Sinhx($x);
}
function Sech($x){
  return 1.0/Coshx($x);
}
function Csch($x){
  return 1.0/Sinhx($x);
}
function Error($x){

  if($x == 0.0){
    $y = 0.0;
  }else if($x < 0.0){
    $y = -Error(-$x);
  }else{
    $c1 = -1.26551223;
    $c2 = +1.00002368;
    $c3 = +0.37409196;
    $c4 = +0.09678418;
    $c5 = -0.18628806;
    $c6 = +0.27886807;
    $c7 = -1.13520398;
    $c8 = +1.48851587;
    $c9 = -0.82215223;
    $c10 = +0.17087277;

    $t = 1.0/(1.0 + 0.5*abs($x));

    $tau = $t*exp(-$x**2.0 + $c1 + $t*($c2 + $t*($c3 + $t*($c4 + $t*($c5 + $t*($c6 + $t*($c7 + $t*($c8 + $t*($c9 + $t*$c10)))))))));

    $y = 1.0 - $tau;
  }

  return $y;
}
function ErrorInverse($x){

  $a = (8.0*(M_PI - 3.0))/(3.0*M_PI*(4.0 - M_PI));

  $t = 2.0/(M_PI*$a) + log(1.0 - $x**2.0)/2.0;
  $y = Sign($x)*sqrt(sqrt($t**2.0 - log(1.0 - $x**2.0)/$a) - $t);

  return $y;
}
function FallingFactorial($x, $n){

  $y = 1.0;

  for($k = 0.0; $k <= $n - 1.0; $k = $k + 1.0){
    $y = $y*($x - $k);
  }

  return $y;
}
function RisingFactorial($x, $n){

  $y = 1.0;

  for($k = 0.0; $k <= $n - 1.0; $k = $k + 1.0){
    $y = $y*($x + $k);
  }

  return $y;
}
function Hypergeometric($a, $b, $c, $z, $maxIterations, $precision){

  if(abs($z) >= 0.5){
    $y = (1.0 - $z)**(-$a)*HypergeometricDirect($a, $c - $b, $c, $z/($z - 1.0), $maxIterations, $precision);
  }else{
    $y = HypergeometricDirect($a, $b, $c, $z, $maxIterations, $precision);
  }

  return $y;
}
function HypergeometricDirect($a, $b, $c, $z, $maxIterations, $precision){

  $y = 0.0;
  $done = false;

  for($n = 0.0; $n < $maxIterations &&  !$done ; $n = $n + 1.0){
    $yp = RisingFactorial($a, $n)*RisingFactorial($b, $n)/RisingFactorial($c, $n)*$z**$n/Factorial($n);
    if(abs($yp) < $precision){
      $done = true;
    }
    $y = $y + $yp;
  }

  return $y;
}
function BernouilliNumber($n){
  return AkiyamaTanigawaAlgorithm($n);
}
function AkiyamaTanigawaAlgorithm($n){

  $A = array_fill(0, $n + 1.0, 0);

  for($m = 0.0; $m <= $n; $m = $m + 1.0){
    $A[$m] = 1.0/($m + 1.0);
    for($j = $m; $j >= 1.0; $j = $j - 1.0){
      $A[$j - 1.0] = $j*($A[$j - 1.0] - $A[$j]);
    }
  }

  $B = $A[0.0];

  unset($A);

  return $B;
}
function D15Add($a, $b, $overflow){

  $x = $a + $b;

  if($x > D15MaxValue() || $x < D15MinValue()){
    $overflow->booleanValue = true;
    $x = 0.0;
  }else{
    $overflow->booleanValue = false;
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function RoundTo15Digits($x){

  $p = floor(log10($x));
  $x = $x*10.0**(15.0 - $p);
  $x = Roundx($x);
  $x = $x/10.0**(15.0 - $p);

  return $x;
}
function D15MaxValue(){
  return +9.99999999999999e99;
}
function D15MinValue(){
  return -9.99999999999999e99;
}
function D15Multiply($a, $b, $overflow){

  $x = $a*$b;

  if($x > D15MaxValue() || $x < D15MinValue()){
    $overflow->booleanValue = true;
    $x = 0.0;
  }else{
    $overflow->booleanValue = false;
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15Divide($a, $b, $reminder, $overflow, $invalidOperation){

  if($b != 0.0){
    $invalidOperation->booleanValue = false;

    $x = $a/$b;
    $r = $a%$b;

    if($x > D15MaxValue() || $x < D15MinValue()){
      $overflow->booleanValue = true;
      $x = 0.0;
      $r = 0.0;
    }else{
      $overflow->booleanValue = false;
      $x = RoundTo15Digits($x);
      $r = RoundTo15Digits($r);
    }
  }else{
    $invalidOperation->booleanValue = true;
    $overflow->booleanValue = false;
    $x = 0.0;
    $r = 0.0;
  }

  $reminder->numberValue = $r;

  return $x;
}
function D15Exponentiation($a, $b, $overflow, $invalidOperation){

  if($a == 0.0 && $b == 0.0){
    $invalidOperation->booleanValue = true;
    $overflow->booleanValue = false;
    $x = 0.0;
  }else if($a < 0.0 &&  !IsInteger($b) ){
    $invalidOperation->booleanValue = true;
    $overflow->booleanValue = false;
    $x = 0.0;
  }else{
    $invalidOperation->booleanValue = false;

    $x = $a**$b;

    if($x > D15MaxValue() || $x < D15MinValue()){
      $overflow->booleanValue = true;
      $x = 0.0;
    }else{
      $overflow->booleanValue = false;
      $x = RoundTo15Digits($x);
    }
  }

  return $x;
}
function D15Modulus($a, $b, $invalidOperation){

  if($a < 0.0 || $b == 0.0 || $b < 0.0){
    $invalidOperation->booleanValue = true;
    $x = 0.0;
  }else{
    $invalidOperation->booleanValue = false;
    $x = $a%$b;
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15Logarithm($a, $invalidOperation){

  if($a <= 0.0){
    $invalidOperation->booleanValue = true;
    $x = 0.0;
  }else{
    $invalidOperation->booleanValue = false;
    $x = log10($a);
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15NaturalLogarithm($a, $invalidOperation){

  if($a <= 0.0){
    $invalidOperation->booleanValue = true;
    $x = 0.0;
  }else{
    $invalidOperation->booleanValue = false;
    $x = log($a);
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15Sin($a){

  $x = sin($a);
  $x = RoundTo15Digits($x);

  return $x;
}
function D15Cos($x){

  $x = abs($x);

  $limit = M_PI + 3.1/2.0;

  if($x > $limit){
    $f = floor($x/M_PI);
    $x = $x - M_PI*$f;
  }

  $piBy2Part1 = +1.57079632679490;
  $piBy2Part2 = -3.38076867830836e-15;

  if($x > 3.1/2.0 && $x < 3.3/2.0){
    $a = $x - $piBy2Part1;
    $a = round($a*10.0**15.0)/10.0**15.0;
    $a = $a - $piBy2Part2;
    $y = -sin($a);
  }else{
    $y = cos($x);
    $y = RoundTo15Digits($y);
  }

  return $y;
}
function D15Tan($a, $overflow){

  $x = tan($a);

  if($x > D15MaxValue() || $x < D15MinValue()){
    $overflow->booleanValue = true;
    $x = 0.0;
  }else{
    $overflow->booleanValue = false;
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15Asin($a, $invalidOperation){

  if($a < -1.0 || $a > 1.0){
    $invalidOperation->booleanValue = true;
    $x = 0.0;
  }else{
    $invalidOperation->booleanValue = false;
    $x = asin($a);
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15Acos($a, $invalidOperation){

  if($a < -1.0 || $a > 1.0){
    $invalidOperation->booleanValue = true;
    $x = 0.0;
  }else{
    $invalidOperation->booleanValue = false;
    $x = acos($a);
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function D15Atan($a){

  $x = atan($a);
  $x = RoundTo15Digits($x);

  return $x;
}
function D15Sqrt($a){

  $x = sqrt($a);
  $x = RoundTo15Digits($x);

  return $x;
}
function D15Exponential($a, $overflow){

  $x = exp($a);

  if($x > D15MaxValue() || $x < D15MinValue()){
    $overflow->booleanValue = true;
    $x = 0.0;
  }else{
    $overflow->booleanValue = false;
    $x = RoundTo15Digits($x);
  }

  return $x;
}
function &Decimal15E2ToString($decimal){

  $len = 21.0;
  /* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00" */
  $result = array_fill(0, $len, 0);

  $done = false;
  $exponent = 0.0;

  if($decimal < 0.0){
    $isPositive = false;
    $decimal = -$decimal;
  }else{
    $isPositive = true;
  }

  if($decimal == 0.0){
    $done = true;
  }

  if( !$done ){
    $multiplier = 0.0;
    $inc = 0.0;

    if($decimal < 1.0){
      $multiplier = 10.0;
      $inc = -1.0;
    }else if($decimal >= 10.0){
      $multiplier = 0.1;
      $inc = 1.0;
    }else{
      $done = true;
    }

    if( !$done ){
      $exponent = round(log10($decimal));
      $exponent = min(99.0, $exponent);
      $exponent = max(-99.0, $exponent);

      $decimal = $decimal/10.0**$exponent;

      /* Adjust */
      for(; ($decimal >= 10.0 || $decimal < 1.0) && abs($exponent) < 99.0; ){
        $decimal = $decimal*$multiplier;
        $exponent = $exponent + $inc;
      }
    }
  }

  $isPositiveExponent = $exponent >= 0.0;
  if( !$isPositiveExponent ){
    $exponent = -$exponent;
  }

  if($isPositive){
    $result[0.0] = "+";
  }else{
    $result[0.0] = "-";
  }

  $decimal = round($decimal*10.0**14.0);

  $d = floor($decimal/10.0**14.0);
  $result[1.0] = SingleDigitNumberToCharacter($d);
  $decimal = $decimal - $d*10.0**14.0;

  $result[2.0] = ".";

  for($i = 0.0; $i < 14.0; $i = $i + 1.0){
    $d = floor($decimal/10.0**(13.0 - $i));
    $result[3.0 + $i] = SingleDigitNumberToCharacter($d);
    $decimal = $decimal - $d*10.0**(13.0 - $i);
  }

  $result[17.0] = "e";

  if($isPositiveExponent){
    $result[18.0] = "+";
  }else{
    $result[18.0] = "-";
  }

  $result[19.0] = SingleDigitNumberToCharacter(floor($exponent/10.0));
  $result[20.0] = SingleDigitNumberToCharacter(floor($exponent%10.0));

  return $result;
}
function SingleDigitNumberToCharacter($n){

  $c = "0";
  if($n == 0.0){
    $c = "0";
  }else if($n == 1.0){
    $c = "1";
  }else if($n == 2.0){
    $c = "2";
  }else if($n == 3.0){
    $c = "3";
  }else if($n == 4.0){
    $c = "4";
  }else if($n == 5.0){
    $c = "5";
  }else if($n == 6.0){
    $c = "6";
  }else if($n == 7.0){
    $c = "7";
  }else if($n == 8.0){
    $c = "8";
  }else if($n == 9.0){
    $c = "9";
  }

  return $c;
}
function cToLowerCase($character){

  $toReturn = $character;
  if($character == "A"){
    $toReturn = "a";
  }else if($character == "B"){
    $toReturn = "b";
  }else if($character == "C"){
    $toReturn = "c";
  }else if($character == "D"){
    $toReturn = "d";
  }else if($character == "E"){
    $toReturn = "e";
  }else if($character == "F"){
    $toReturn = "f";
  }else if($character == "G"){
    $toReturn = "g";
  }else if($character == "H"){
    $toReturn = "h";
  }else if($character == "I"){
    $toReturn = "i";
  }else if($character == "J"){
    $toReturn = "j";
  }else if($character == "K"){
    $toReturn = "k";
  }else if($character == "L"){
    $toReturn = "l";
  }else if($character == "M"){
    $toReturn = "m";
  }else if($character == "N"){
    $toReturn = "n";
  }else if($character == "O"){
    $toReturn = "o";
  }else if($character == "P"){
    $toReturn = "p";
  }else if($character == "Q"){
    $toReturn = "q";
  }else if($character == "R"){
    $toReturn = "r";
  }else if($character == "S"){
    $toReturn = "s";
  }else if($character == "T"){
    $toReturn = "t";
  }else if($character == "U"){
    $toReturn = "u";
  }else if($character == "V"){
    $toReturn = "v";
  }else if($character == "W"){
    $toReturn = "w";
  }else if($character == "X"){
    $toReturn = "x";
  }else if($character == "Y"){
    $toReturn = "y";
  }else if($character == "Z"){
    $toReturn = "z";
  }

  return $toReturn;
}
function cToUpperCase($character){

  $toReturn = $character;
  if($character == "a"){
    $toReturn = "A";
  }else if($character == "b"){
    $toReturn = "B";
  }else if($character == "c"){
    $toReturn = "C";
  }else if($character == "d"){
    $toReturn = "D";
  }else if($character == "e"){
    $toReturn = "E";
  }else if($character == "f"){
    $toReturn = "F";
  }else if($character == "g"){
    $toReturn = "G";
  }else if($character == "h"){
    $toReturn = "H";
  }else if($character == "i"){
    $toReturn = "I";
  }else if($character == "j"){
    $toReturn = "J";
  }else if($character == "k"){
    $toReturn = "K";
  }else if($character == "l"){
    $toReturn = "L";
  }else if($character == "m"){
    $toReturn = "M";
  }else if($character == "n"){
    $toReturn = "N";
  }else if($character == "o"){
    $toReturn = "O";
  }else if($character == "p"){
    $toReturn = "P";
  }else if($character == "q"){
    $toReturn = "Q";
  }else if($character == "r"){
    $toReturn = "R";
  }else if($character == "s"){
    $toReturn = "S";
  }else if($character == "t"){
    $toReturn = "T";
  }else if($character == "u"){
    $toReturn = "U";
  }else if($character == "v"){
    $toReturn = "V";
  }else if($character == "w"){
    $toReturn = "W";
  }else if($character == "x"){
    $toReturn = "X";
  }else if($character == "y"){
    $toReturn = "Y";
  }else if($character == "z"){
    $toReturn = "Z";
  }

  return $toReturn;
}
function cIsUpperCase($character){

  $isUpper = true;
  if($character == "A"){
  }else if($character == "B"){
  }else if($character == "C"){
  }else if($character == "D"){
  }else if($character == "E"){
  }else if($character == "F"){
  }else if($character == "G"){
  }else if($character == "H"){
  }else if($character == "I"){
  }else if($character == "J"){
  }else if($character == "K"){
  }else if($character == "L"){
  }else if($character == "M"){
  }else if($character == "N"){
  }else if($character == "O"){
  }else if($character == "P"){
  }else if($character == "Q"){
  }else if($character == "R"){
  }else if($character == "S"){
  }else if($character == "T"){
  }else if($character == "U"){
  }else if($character == "V"){
  }else if($character == "W"){
  }else if($character == "X"){
  }else if($character == "Y"){
  }else if($character == "Z"){
  }else{
    $isUpper = false;
  }

  return $isUpper;
}
function cIsLowerCase($character){

  $isLower = true;
  if($character == "a"){
  }else if($character == "b"){
  }else if($character == "c"){
  }else if($character == "d"){
  }else if($character == "e"){
  }else if($character == "f"){
  }else if($character == "g"){
  }else if($character == "h"){
  }else if($character == "i"){
  }else if($character == "j"){
  }else if($character == "k"){
  }else if($character == "l"){
  }else if($character == "m"){
  }else if($character == "n"){
  }else if($character == "o"){
  }else if($character == "p"){
  }else if($character == "q"){
  }else if($character == "r"){
  }else if($character == "s"){
  }else if($character == "t"){
  }else if($character == "u"){
  }else if($character == "v"){
  }else if($character == "w"){
  }else if($character == "x"){
  }else if($character == "y"){
  }else if($character == "z"){
  }else{
    $isLower = false;
  }

  return $isLower;
}
function cIsLetter($character){
  return cIsUpperCase($character) || cIsLowerCase($character);
}
function cIsNumber($character){

  $isNumberx = true;
  if($character == "0"){
  }else if($character == "1"){
  }else if($character == "2"){
  }else if($character == "3"){
  }else if($character == "4"){
  }else if($character == "5"){
  }else if($character == "6"){
  }else if($character == "7"){
  }else if($character == "8"){
  }else if($character == "9"){
  }else{
    $isNumberx = false;
  }

  return $isNumberx;
}
function cIsWhiteSpace($character){

  $isWhiteSpacex = true;
  if($character == " "){
  }else if($character == "\t"){
  }else if($character == "\n"){
  }else if($character == "\r"){
  }else{
    $isWhiteSpacex = false;
  }

  return $isWhiteSpacex;
}
function cIsSymbol($character){

  $isSymbolx = true;
  if($character == "!"){
  }else if($character == "\""){
  }else if($character == "#"){
  }else if($character == "$"){
  }else if($character == "%"){
  }else if($character == "&"){
  }else if($character == "\'"){
  }else if($character == "("){
  }else if($character == ")"){
  }else if($character == "*"){
  }else if($character == "+"){
  }else if($character == ","){
  }else if($character == "-"){
  }else if($character == "."){
  }else if($character == "/"){
  }else if($character == ":"){
  }else if($character == ";"){
  }else if($character == "<"){
  }else if($character == "="){
  }else if($character == ">"){
  }else if($character == "?"){
  }else if($character == "@"){
  }else if($character == "["){
  }else if($character == "\\"){
  }else if($character == "]"){
  }else if($character == "^"){
  }else if($character == "_"){
  }else if($character == "`"){
  }else if($character == "{"){
  }else if($character == "|"){
  }else if($character == "}"){
  }else if($character == "~"){
  }else{
    $isSymbolx = false;
  }

  return $isSymbolx;
}
function cCharacterIsBefore($a, $b){

  $ad = uniord($a);
  $bd = uniord($b);

  return $ad < $bd;
}
function cDecimalDigitToCharacter($digit){
  if($digit == 1.0){
    $c = "1";
  }else if($digit == 2.0){
    $c = "2";
  }else if($digit == 3.0){
    $c = "3";
  }else if($digit == 4.0){
    $c = "4";
  }else if($digit == 5.0){
    $c = "5";
  }else if($digit == 6.0){
    $c = "6";
  }else if($digit == 7.0){
    $c = "7";
  }else if($digit == 8.0){
    $c = "8";
  }else if($digit == 9.0){
    $c = "9";
  }else{
    $c = "0";
  }
  return $c;
}
function cCharacterToDecimalDigit($c){

  if($c == "1"){
    $digit = 1.0;
  }else if($c == "2"){
    $digit = 2.0;
  }else if($c == "3"){
    $digit = 3.0;
  }else if($c == "4"){
    $digit = 4.0;
  }else if($c == "5"){
    $digit = 5.0;
  }else if($c == "6"){
    $digit = 6.0;
  }else if($c == "7"){
    $digit = 7.0;
  }else if($c == "8"){
    $digit = 8.0;
  }else if($c == "9"){
    $digit = 9.0;
  }else{
    $digit = 0.0;
  }

  return $digit;
}

