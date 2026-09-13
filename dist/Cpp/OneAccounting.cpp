// Downloaded from https://repo.progsbase.com - Code Developed Using progsbase.

#include <cmath>
#include <cstring>
#include <vector>
#include <cwchar>

using namespace std;

#define toVector(s) (new vector<wchar_t> ((s), (s) + wcslen(s)))

struct Account;

struct AccountDefinition;

struct AccountPlan;

struct Ledger;

struct Line;

struct Transaction;

struct BooleanArrayReference;

struct BooleanReference;

struct CharacterReference;

struct NumberArrayReference;

struct NumberReference;

struct StringArrayReference;

struct StringReference;

struct Date;

struct DateReference;

struct Interval;

struct DateTimeTimezone;

struct DateTimeTimezoneReference;

struct DateTime;

struct DateTimeReference;

struct FixedPoint30d;

struct FixedPoint15d;

struct DynamicArrayCharacters;

struct LinkedListNodeStrings;

struct LinkedListStrings;

struct LinkedListNodeNumbers;

struct LinkedListNumbers;

struct LinkedListCharacters;

struct LinkedListNodeCharacters;

struct DynamicArrayNumbers;

struct Array;

struct Data;

struct DataReference;

struct Structure;

struct Account{
  vector<wchar_t> *name;
  FixedPoint15d *endingBalance;
  FixedPoint15d *startingBalance;
  Date *from;
  Date *to;
  FixedPoint15d *sumDebit;
  FixedPoint15d *sumCredit;
};

struct AccountDefinition{
  vector<wchar_t> *accountName;
  vector<wchar_t> *number;
  vector<wchar_t> *role;
  bool debitBalance;
};

struct AccountPlan{
  vector<AccountDefinition*> *accountDefinitions;
};

struct Ledger{
  double decimals;
  vector<Transaction*> *transactions;
  AccountPlan *accountPlan;
};

struct Line{
  vector<wchar_t> *account;
  FixedPoint15d *debit;
  FixedPoint15d *credit;
  vector<wchar_t> *description;
  Date *date;
};

struct Transaction{
  vector<Line*> *lines;
};

struct BooleanArrayReference{
  vector<bool> *booleanArray;
};

struct BooleanReference{
  bool booleanValue;
};

struct CharacterReference{
  wchar_t characterValue;
};

struct NumberArrayReference{
  vector<double> *numberArray;
};

struct NumberReference{
  double numberValue;
};

struct StringArrayReference{
  vector<StringReference*> *stringArray;
};

struct StringReference{
  vector<wchar_t> *string;
};

struct Date{
  double year;
  double month;
  double day;
};

struct DateReference{
  Date *date;
};

struct Interval{
  Date *first;
  Date *last;
};

struct DateTimeTimezone{
  DateTime *dateTime;
  double timezoneOffsetSeconds;
};

struct DateTimeTimezoneReference{
  DateTimeTimezone *dateTimeTimezone;
};

struct DateTime{
  Date *date;
  double hours;
  double minutes;
  double seconds;
};

struct DateTimeReference{
  DateTime *dateTime;
};

struct FixedPoint30d{
  double part1;
  double part2;
  double digitsBeforeDecimalPoint;
  double digitsAfterDecimalPoint;
};

struct FixedPoint15d{
  double number;
  double digitsBeforeDecimalPoint;
  double digitsAfterDecimalPoint;
};

struct DynamicArrayCharacters{
  vector<wchar_t> *array;
  double length;
};

struct LinkedListNodeStrings{
  bool end;
  vector<wchar_t> *value;
  LinkedListNodeStrings *next;
};

struct LinkedListStrings{
  LinkedListNodeStrings *first;
  LinkedListNodeStrings *last;
};

struct LinkedListNodeNumbers{
  LinkedListNodeNumbers *next;
  bool end;
  double value;
};

struct LinkedListNumbers{
  LinkedListNodeNumbers *first;
  LinkedListNodeNumbers *last;
};

struct LinkedListCharacters{
  LinkedListNodeCharacters *first;
  LinkedListNodeCharacters *last;
};

struct LinkedListNodeCharacters{
  bool end;
  wchar_t value;
  LinkedListNodeCharacters *next;
};

struct DynamicArrayNumbers{
  vector<double> *array;
  double length;
};

struct Array{
  vector<Data*> *array;
  double length;
};

struct Data{
  bool isStruture;
  bool isArray;
  bool isNumber;
  bool isString;
  bool isBoolean;
  Structure *structure;
  Array *array;
  double number;
  bool booleanx;
  vector<wchar_t> *string;
};

struct DataReference{
  Data *data;
};

struct Structure{
  Array *keys;
  Array *values;
};

Structure *CreateLedger(double decimals);
FixedPoint15d *CreateFixedPointForDynamicLedger(Structure *ledger);
FixedPoint15d *CreateFixedPointForStaticLedger(Ledger *ledger);
Line *CreateLine(vector<wchar_t> *account, FixedPoint15d *debit, FixedPoint15d *credit, vector<wchar_t> *description, Date *date);
void AddTransactionToLedger(Array *ledger, Line *src);
void AddTransactionsToLedger(Array *ledger, vector<Line*> *ts);
bool ValidateAndAddTransactionToLedger(Structure *ledger, vector<Line*> *ls);
Line *GetTransactionFromLedger(Structure *ledger, double index);
Structure *LineToStructure(Line *src);
Line *LineFromStructure(Structure *src, Structure *ledger);
Ledger *LedgerDynamicToStatic(Structure *src);
bool ValidateTransaction(vector<Line*> *ts, Structure *ledger);
bool ValidateTransactions(vector<Line*> *ts, NumberArrayReference *invalidIds);
Account *ComputeAccountBalance(Ledger *ledger, vector<wchar_t> *accountName, Date *fromDate, Date *toDate);
vector<wchar_t> *AccountToString(Account *account);
void AddMonthlyAccruals(Structure *ledger, Date *from, Date *to, double amount, vector<wchar_t> *fromAccount, vector<wchar_t> *toAccount);
FixedPoint15d *ComputeAccountBalancePrefixAccount(Ledger *ledger, vector<wchar_t> *accountNr, Date *toDate, bool debitBalance);
AccountPlan *GetIFRSAccountPlan();
AccountPlan *ParseAccountPlanString(vector<wchar_t> *accountPlanString, BooleanReference *valid);
bool ComputeAccountBalances(Ledger *sledger, double depth, Date *date, DataReference *balanceSheet);
vector<wchar_t> *AccountBalancesToString(Structure *balanceSheet);
AccountDefinition *FindAccountWithRole(AccountPlan *accountPlan, vector<wchar_t> *role, BooleanReference *foundRef);
AccountDefinition *CreateAccountDefinition(vector<wchar_t> *name, vector<wchar_t> *number, vector<wchar_t> *role, bool debitBalance);
void ComputeBalanceDiffs(Ledger *sledger, Array *balances);
vector<wchar_t> *BalancesArrayToHTML(Array *balances, bool includeBalance, bool includeDiff);
Line *CreateLineFromScript(Structure *ledger, vector<wchar_t> *script, Date *date);

double test();
void TestIFRSAccountPlan(NumberReference *failures);
void TestBasicAccounting(NumberReference *failures);
void TestAccruals(NumberReference *failures);

BooleanReference *CreateBooleanReference(bool value);
BooleanArrayReference *CreateBooleanArrayReference(vector<bool> *value);
BooleanArrayReference *CreateBooleanArrayReferenceLengthValue(double length, bool value);
void FreeBooleanArrayReference(BooleanArrayReference *booleanArrayReference);
CharacterReference *CreateCharacterReference(wchar_t value);
NumberReference *CreateNumberReference(double value);
NumberArrayReference *CreateNumberArrayReference(vector<double> *value);
NumberArrayReference *CreateNumberArrayReferenceLengthValue(double length, double value);
void FreeNumberArrayReference(NumberArrayReference *numberArrayReference);
StringReference *CreateStringReference(vector<wchar_t> *value);
StringReference *CreateStringReferenceLengthValue(double length, wchar_t value);
void FreeStringReference(StringReference *stringReference);
StringArrayReference *CreateStringArrayReference(vector<StringReference*> *strings);
StringArrayReference *CreateStringArrayReferenceLengthValue(double length, vector<wchar_t> *value);
void FreeStringArrayReference(StringArrayReference *stringArrayReference);

Date *CreateDate(double year, double month, double day);
bool IsLeapYearWithCheck(double year, BooleanReference *isLeapYearReference, StringReference *message);
bool IsLeapYear(double year);
bool DayToDateWithCheck(double dayNr, DateReference *dateReference, StringReference *message);
Date *DayToDate(double dayNr);
bool GetMonthFromDayNrWithCheck(double dayNr, double year, NumberReference *monthReference, NumberReference *remainderReference, StringReference *message);
double GetMonthFromDayNr(double dayNr, double year, NumberReference *remainderReference);
bool GetYearFromDayNrWithCheck(double dayNr, NumberReference *yearReference, NumberReference *remainder, StringReference *message);
double GetYearFromDayNr(double dayNr, NumberReference *remainder);
double DaysBetweenDates(Date *A, Date *B);
bool GetDaysInMonthWithCheck(double year, NumberArrayReference *daysInMonthReference, StringReference *message);
vector<double> *GetDaysInMonth(double year);
bool DateToDaysWithCheck(Date *date, NumberReference *dayNumberReferenceReference, StringReference *message);
double DateToDays(Date *date);
bool DateToWeekdayNumberWithCheck(Date *date, NumberReference *weekDayNumberReference, StringReference *message);
double DateToWeekdayNumber(Date *date);
double DateToWeeknumber(Date *date, NumberReference *yearRef);
bool DaysInMonthsWithCheck(double month, double year, NumberReference *daysInMonthsReference, StringReference *message);
double DaysInMonths(double month, double year);
bool DaysInYearsWithCheck(double years, NumberReference *daysReference, StringReference *message);
double DaysInYears(double years);
bool IsValidDate(Date *date, StringReference *message);
bool AddDaysToDate(Date *date, double days, StringReference *message);
void AssignDate(Date *a, Date *b);
void AddMonthsToDate(Date *date, double months);
bool DateToStringISO8601WithCheck(Date *date, StringReference *datestr, StringReference *message);
vector<wchar_t> *DateToStringISO8601(Date *date);
Date *DateFromStringISO8601(vector<wchar_t> *str);
bool DateFromStringISO8601WithCheck(vector<wchar_t> *str, DateReference *dateRef, StringReference *message);
bool IsValidDateISO8601(vector<wchar_t> *str, StringReference *message);
bool DateEquals(Date *a, Date *b);
Date *CopyDate(Date *a);
double GetSecondsFromDate(Date *date);
bool DateIsInInterval(Interval *interval, Date *date);
bool DateLessThan(Date *a, Date *b);

DateTimeTimezone *CreateDateTimeTimezone(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetSeconds);
DateTimeTimezone *CreateDateTimeTimezoneInHoursAndMinutes(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetHours, double timezoneOffsetMinutes);
bool GetDateFromDateTimeTimeZone(DateTimeTimezone *dateTimeTimezone, DateTimeReference *dateTimeReference, StringReference *message);
bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(DateTime *dateTime, double timezoneOffsetSeconds, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message);
bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(DateTime *dateTime, double timezoneOffsetHours, double timezoneOffsetMinutes, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message);
bool GetDateTimeTimezoneFromSeconds(DateTimeTimezoneReference *dateTimeTzRef, double seconds, double offset, StringReference *message);

DateTime *CreateDateTime(double year, double month, double day, double hours, double minutes, double seconds);
bool GetDateTimeFromSeconds(double seconds, DateTimeReference *dateTimeReference, StringReference *message);
double GetSecondsFromDateTime(DateTime *dateTime);
double GetSecondsFromMinutes(double minutes);
double GetSecondsFromHours(double hours);
double GetSecondsFromDays(double days);
double GetSecondsFromWeeks(double weeks);
double GetMinutesFromSeconds(double seconds);
double GetHoursFromSeconds(double seconds);
double GetDaysFromSeconds(double seconds);
double GetWeeksFromSeconds(double seconds);
Date *GetDateFromDateTime(DateTime *dateTime);
bool AddSecondsToDateTimeWithCheck(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message);
bool AddSecondsToDateTime(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message);
bool AddMinutesToDateTime(DateTime *dateTime, double minutes, DateTimeReference *dateTimeReference, StringReference *message);
bool AddHoursToDateTime(DateTime *dateTime, double hours, DateTimeReference *dateTimeReference, StringReference *message);
bool AddDaysToDateTime(DateTime *dateTime, double days, DateTimeReference *dateTimeReference, StringReference *message);
bool AddWeeksToDateTime(DateTime *dateTime, double weeks, DateTimeReference *dateTimeReference, StringReference *message);
bool DateTimeToStringISO8601WithCheck(DateTime *datetime, StringReference *dateStr, StringReference *message);
bool IsValidDateTime(DateTime *datetime, StringReference *message);
vector<wchar_t> *DateTimeToStringISO8601(DateTime *datetime);
DateTime *DateTimeFromStringISO8601(vector<wchar_t> *str);
bool DateTimeFromStringISO8601WithCheck(vector<wchar_t> *str, DateTimeReference *dateTimeRef, StringReference *message);
bool IsValidDateTimeISO8601(vector<wchar_t> *str, StringReference *message);
bool DateTimeEquals(DateTime *a, DateTime *b);
void FreeDateTime(DateTime *datetime);

FixedPoint30d *CreateFixedPoint30d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint);

FixedPoint15d *CreateFixedPoint15d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint);
double ToNumber15d(FixedPoint15d *n);
FixedPoint15d *Number15d(double number);
bool Assign15d(FixedPoint15d *fp, double number);
bool Assign15dFloor(FixedPoint15d *fp, double number);
bool FixedPointIsValid15d(FixedPoint15d *fp);
bool WillOverflow15d(FixedPoint15d *fp, double number);
double FloorToDigits(double value, double digits);
vector<wchar_t> *ToString15d(FixedPoint15d *fp);
bool Add15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c);
bool Subtract15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c);
bool Multiply15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c);
bool DivideFloored15d(FixedPoint15d *q, FixedPoint15d *r, FixedPoint15d *a, FixedPoint15d *b);
FixedPoint15d *Copy15d(FixedPoint15d *r);
void Negate15d(FixedPoint15d *a);
void Positive15d(FixedPoint15d *a);
bool Factorial15d(FixedPoint15d *x);
bool Round15d(FixedPoint15d *x);
bool BankersRound15d(FixedPoint15d *x);
bool Ceil15d(FixedPoint15d *x);
bool Floor15d(FixedPoint15d *x);
void Truncate15d(FixedPoint15d *x);
void Absolute15d(FixedPoint15d *x);
bool Logarithm15d(FixedPoint15d *x);
bool NaturalLogarithm15d(FixedPoint15d *x);
bool Sin15d(FixedPoint15d *x);
bool Cos15d(FixedPoint15d *x);
bool Tan15d(FixedPoint15d *x);
bool Asin15d(FixedPoint15d *x);
bool Acos15d(FixedPoint15d *x);
bool Atan15d(FixedPoint15d *x);
bool Atan2_15d(FixedPoint15d *a, FixedPoint15d *y, FixedPoint15d *x);
bool Squareroot15d(FixedPoint15d *x);
bool Exp15d(FixedPoint15d *x);
bool DivisibleBy15d(FixedPoint15d *a, FixedPoint15d *b);
bool Combinations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k);
bool Permutations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k);
bool Equals15d(FixedPoint15d *a, FixedPoint15d *b);
bool GreaterThan15d(FixedPoint15d *a, FixedPoint15d *b);
bool LessThan15d(FixedPoint15d *a, FixedPoint15d *b);
bool GreaterThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b);
bool LessThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b);
bool EpsilonCompare15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *epsilon);
bool GreatestCommonDivisor15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
bool GCDWithSubtraction15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
bool IsInteger15d(FixedPoint15d *a);
bool LeastCommonMultiple15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
double Sign15d(FixedPoint15d *a);
bool Max15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
bool Min15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
bool Power15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
vector<wchar_t> *FormatToString15d(FixedPoint15d *fp, double digitsAfter);
vector<wchar_t> *FormatToStringWithSymbols15d(FixedPoint15d *fp, double digitsAfter, vector<wchar_t> *thousandsSeparator, vector<wchar_t> *decimalPoint);
vector<wchar_t> *NumberToHumanReadable(double n, double digitsAfter, vector<wchar_t> *thousandsSeparator, vector<wchar_t> *decimalPoint);
vector<wchar_t> *NumberToHumanReadableBinaryPrefix(double n, double digitsAfter, vector<wchar_t> *thousandsSeparator, vector<wchar_t> *decimalPoint);

vector<double> *AddNumber(vector<double> *list, double a);
void AddNumberRef(NumberArrayReference *list, double i);
vector<double> *RemoveNumber(vector<double> *list, double n);
double GetNumberRef(NumberArrayReference *list, double i);
void RemoveNumberRef(NumberArrayReference *list, double i);

vector<StringReference*> *AddString(vector<StringReference*> *list, StringReference *a);
void AddStringRef(StringArrayReference *list, StringReference *i);
vector<StringReference*> *RemoveString(vector<StringReference*> *list, double n);
StringReference *GetStringRef(StringArrayReference *list, double i);
void RemoveStringRef(StringArrayReference *list, double i);


DynamicArrayCharacters *CreateDynamicArrayCharacters();
DynamicArrayCharacters *CreateDynamicArrayCharactersWithInitialCapacity(double capacity);
void DynamicArrayAddCharacter(DynamicArrayCharacters *da, wchar_t value);
void DynamicArrayAddString(DynamicArrayCharacters *da, vector<wchar_t> *str);
void DynamicArrayCharactersIncreaseSize(DynamicArrayCharacters *da);
bool DynamicArrayCharactersDecreaseSizeNecessary(DynamicArrayCharacters *da);
void DynamicArrayCharactersDecreaseSize(DynamicArrayCharacters *da);
wchar_t DynamicArrayCharactersIndex(DynamicArrayCharacters *da, double index);
double DynamicArrayCharactersLength(DynamicArrayCharacters *da);
void DynamicArrayInsertCharacter(DynamicArrayCharacters *da, double index, wchar_t value);
bool DynamicArrayCharacterSet(DynamicArrayCharacters *da, double index, wchar_t value);
void DynamicArrayRemoveCharacter(DynamicArrayCharacters *da, double index);
void FreeDynamicArrayCharacters(DynamicArrayCharacters *da);
vector<wchar_t> *DynamicArrayCharactersToArray(DynamicArrayCharacters *da);
DynamicArrayCharacters *ArrayToDynamicArrayCharactersWithOptimalSize(vector<wchar_t> *array);
DynamicArrayCharacters *ArrayToDynamicArrayCharacters(vector<wchar_t> *array);
bool DynamicArrayCharactersEqual(DynamicArrayCharacters *a, DynamicArrayCharacters *b);
LinkedListCharacters *DynamicArrayCharactersToLinkedList(DynamicArrayCharacters *da);
DynamicArrayCharacters *LinkedListToDynamicArrayCharacters(LinkedListCharacters *ll);

vector<bool> *AddBoolean(vector<bool> *list, bool a);
void AddBooleanRef(BooleanArrayReference *list, bool i);
vector<bool> *RemoveBoolean(vector<bool> *list, double n);
bool GetBooleanRef(BooleanArrayReference *list, double i);
void RemoveDecimalRef(BooleanArrayReference *list, double i);


LinkedListStrings *CreateLinkedListString();
void LinkedListAddString(LinkedListStrings *ll, vector<wchar_t> *value);
vector<StringReference*> *LinkedListStringsToArray(LinkedListStrings *ll);
double LinkedListStringsLength(LinkedListStrings *ll);
void FreeLinkedListString(LinkedListStrings *ll);
void LinkedListInsertString(LinkedListStrings *ll, double index, vector<wchar_t> *value);


LinkedListNumbers *CreateLinkedListNumbers();
vector<LinkedListNumbers*> *CreateLinkedListNumbersArray(double length);
void LinkedListAddNumber(LinkedListNumbers *ll, double value);
double LinkedListNumbersLength(LinkedListNumbers *ll);
double LinkedListNumbersIndex(LinkedListNumbers *ll, double index);
void LinkedListInsertNumber(LinkedListNumbers *ll, double index, double value);
void LinkedListSet(LinkedListNumbers *ll, double index, double value);
void LinkedListRemoveNumber(LinkedListNumbers *ll, double index);
void FreeLinkedListNumbers(LinkedListNumbers *ll);
void FreeLinkedListNumbersArray(vector<LinkedListNumbers*> *lls);
vector<double> *LinkedListNumbersToArray(LinkedListNumbers *ll);
LinkedListNumbers *ArrayToLinkedListNumbers(vector<double> *array);
bool LinkedListNumbersEqual(LinkedListNumbers *a, LinkedListNumbers *b);

LinkedListCharacters *CreateLinkedListCharacter();
void LinkedListAddCharacter(LinkedListCharacters *ll, wchar_t value);
vector<wchar_t> *LinkedListCharactersToArray(LinkedListCharacters *ll);
double LinkedListCharactersLength(LinkedListCharacters *ll);
void FreeLinkedListCharacter(LinkedListCharacters *ll);
void LinkedListCharactersAddString(LinkedListCharacters *ll, vector<wchar_t> *str);
void LinkedListInsertCharacter(LinkedListCharacters *ll, double index, wchar_t value);



DynamicArrayNumbers *CreateDynamicArrayNumbers();
DynamicArrayNumbers *CreateDynamicArrayNumbersWithInitialCapacity(double capacity);
void DynamicArrayAddNumber(DynamicArrayNumbers *da, double value);
void DynamicArrayNumbersIncreaseSize(DynamicArrayNumbers *da);
bool DynamicArrayNumbersDecreaseSizeNecessary(DynamicArrayNumbers *da);
void DynamicArrayNumbersDecreaseSize(DynamicArrayNumbers *da);
double DynamicArrayNumbersIndex(DynamicArrayNumbers *da, double index);
double DynamicArrayNumbersLength(DynamicArrayNumbers *da);
void DynamicArrayInsertNumber(DynamicArrayNumbers *da, double index, double value);
bool DynamicArrayNumberSet(DynamicArrayNumbers *da, double index, double value);
void DynamicArrayRemoveNumber(DynamicArrayNumbers *da, double index);
void FreeDynamicArrayNumbers(DynamicArrayNumbers *da);
vector<double> *DynamicArrayNumbersToArray(DynamicArrayNumbers *da);
DynamicArrayNumbers *ArrayToDynamicArrayNumbersWithOptimalSize(vector<double> *array);
DynamicArrayNumbers *ArrayToDynamicArrayNumbers(vector<double> *array);
bool DynamicArrayNumbersEqual(DynamicArrayNumbers *a, DynamicArrayNumbers *b);
LinkedListNumbers *DynamicArrayNumbersToLinkedList(DynamicArrayNumbers *da);
DynamicArrayNumbers *LinkedListToDynamicArrayNumbers(LinkedListNumbers *ll);
double DynamicArrayNumbersIndexOf(DynamicArrayNumbers *arr, double n, BooleanReference *foundReference);
bool DynamicArrayNumbersIsInArray(DynamicArrayNumbers *arr, double n);

vector<wchar_t> *AddCharacter(vector<wchar_t> *list, wchar_t a);
void AddCharacterRef(StringReference *list, wchar_t i);
vector<wchar_t> *RemoveCharacter(vector<wchar_t> *list, double n);
wchar_t GetCharacterRef(StringReference *list, double i);
void RemoveCharacterRef(StringReference *list, double i);

double GetAccrualAmount(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay, double yearOfInterest, double monthOfInterest);
vector<double> *GetAccruals(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay);
vector<double> *GetAccrualsWithDates(double total, Date *from, Date *to);
double GetAccrualAmountWithDates(double total, Date *from, Date *to, double yearOfInterest, double monthOfInterest);
double GetUnadjustedAccrualAmountWithDates(FixedPoint15d *total, Date *from, Date *to, double yearOfInterest, double monthOfInterest);

Data *CreateNewArrayData();
Data *CreateNewStructData();
Structure *CreateStructure();
Data *CreateNumberData(double n);
Data *CreateBooleanData(bool b);
Data *CreateStringData(vector<wchar_t> *string);
Data *CreateStructData(Structure *structure);
Data *CreateArrayData(Array *array);
Data *CreateNoTypeData();
void AddStructToArray(Array *ar, Structure *st);
void AddArrayToArray(Array *ar, Array *ar2);
void AddNumberToArray(Array *ar, double n);
void AddBooleanToArray(Array *ar, bool b);
void AddStringToArray(Array *ar, vector<wchar_t> *str);
void AddDataToArray(Array *ar, Data *data);
double StructKeys(Structure *st);
bool StructHasKey(Structure *st, vector<wchar_t> *key);
double StructKeyIndex(Structure *st, vector<wchar_t> *key);
vector<StringReference*> *GetStructKeys(Structure *st);
Structure *GetStructFromStruct(Structure *st, vector<wchar_t> *key);
Array *GetArrayFromStruct(Structure *st, vector<wchar_t> *key);
double GetNumberFromStruct(Structure *st, vector<wchar_t> *key);
bool GetBooleanFromStruct(Structure *st, vector<wchar_t> *key);
vector<wchar_t> *GetStringFromStruct(Structure *st, vector<wchar_t> *key);
Data *GetDataFromStruct(Structure *st, vector<wchar_t> *key);
Data *GetDataFromStructWithCheck(Structure *st, vector<wchar_t> *key, BooleanReference *foundRef);
void AddStructToStruct(Structure *st, vector<wchar_t> *key, Structure *structx);
void AddArrayToStruct(Structure *st, vector<wchar_t> *key, Array *ar);
void AddNumberToStruct(Structure *st, vector<wchar_t> *key, double n);
void AddBooleanToStruct(Structure *st, vector<wchar_t> *key, bool b);
void AddStringToStruct(Structure *st, vector<wchar_t> *key, vector<wchar_t> *value);
void AddDataToStruct(Structure *st, vector<wchar_t> *key, Data *data);
void FreeData(Data *data);
void FreeArray(Array *array);
bool DataTypeEquals(Data *a, Data *b);
bool IsStructure(Data *a);
bool IsArray(Data *a);
bool IsNumber(Data *a);
bool IsBoolean(Data *a);
bool IsString(Data *a);
bool IsNoType(Data *a);

Array *CreateArray();
Array *CreateArrayWithInitialCapacity(double capacity);
void ArrayAdd(Array *array, Data *value);
void ArrayAddString(Array *array, vector<wchar_t> *value);
void ArrayAddBoolean(Array *array, bool value);
void ArrayAddNumber(Array *array, double value);
void ArrayAddStruct(Array *array, Structure *value);
void ArrayAddArray(Array *array, Array *value);
void ArrayIncreaseSize(Array *array);
bool ArrayDecreaseSizeNecessary(Array *array);
void ArrayDecreaseSize(Array *array);
Data *ArrayIndex(Array *array, double index);
Array *ArrayIndexArray(Array *array, double index);
Structure *ArrayIndexStruct(Array *array, double index);
bool ArrayIndexBoolean(Array *array, double index);
vector<wchar_t> *ArrayIndexString(Array *array, double index);
double ArrayIndexNumber(Array *array, double index);
double ArrayLength(Array *array);
void ArrayInsert(Array *array, double index, Data *value);
void ArrayInsertString(Array *array, double index, vector<wchar_t> *value);
void ArrayInsertBoolean(Array *array, double index, bool value);
void ArrayInsertNumber(Array *array, double index, double value);
void ArrayInsertStruct(Array *array, double index, Structure *value);
void ArrayInsertArray(Array *array, double index, Array *value);
bool ArraySet(Array *array, double index, Data *value);
void ArraySetString(Array *array, double index, vector<wchar_t> *value);
void ArraySetBoolean(Array *array, double index, bool value);
void ArraySetNumber(Array *array, double index, double value);
void ArraySetStruct(Array *array, double index, Structure *value);
void ArraySetArray(Array *array, double index, Array *value);
void ArrayRemove(Array *array, double index);
vector<Data*> *ToStaticArray(Array *arc);
vector<double> *ToStaticNumberArray(Array *array);
vector<bool> *ToStaticBooleanArray(Array *array);
vector<StringReference*> *ToStaticStringArray(Array *array);
vector<Array*> *ToStaticArrayArray(Array *array);
vector<Structure*> *ToStaticStructArray(Array *array);
Array *StaticArrayToArrayWithOptimalSize(vector<Data*> *src);
Array *StaticArrayToArray(vector<Data*> *src);

vector<double> *arraysStringToNumberArray(vector<wchar_t> *string);
vector<wchar_t> *arraysNumberArrayToString(vector<double> *array);
bool arraysNumberArraysEqual(vector<double> *a, vector<double> *b);
bool arraysBooleanArraysEqual(vector<bool> *a, vector<bool> *b);
bool arraysStringsEqual(vector<wchar_t> *a, vector<wchar_t> *b);
void arraysFillNumberArray(vector<double> *a, double value);
void arraysFillString(vector<wchar_t> *a, wchar_t value);
void arraysFillBooleanArray(vector<bool> *a, bool value);
bool arraysFillNumberArrayRange(vector<double> *a, double value, double from, double to);
bool arraysFillBooleanArrayRange(vector<bool> *a, bool value, double from, double to);
bool arraysFillStringRange(vector<wchar_t> *a, wchar_t value, double from, double to);
vector<double> *arraysCopyNumberArray(vector<double> *a);
vector<bool> *arraysCopyBooleanArray(vector<bool> *a);
vector<wchar_t> *arraysCopyString(vector<wchar_t> *a);
bool arraysCopyNumberArrayRange(vector<double> *a, double from, double to, NumberArrayReference *copyReference);
bool arraysCopyBooleanArrayRange(vector<bool> *a, double from, double to, BooleanArrayReference *copyReference);
bool arraysCopyStringRange(vector<wchar_t> *a, double from, double to, StringReference *copyReference);
bool arraysIsLastElement(double length, double index);
vector<double> *arraysCreateNumberArray(double length, double value);
vector<bool> *arraysCreateBooleanArray(double length, bool value);
vector<wchar_t> *arraysCreateString(double length, wchar_t value);
void arraysSwapElementsOfNumberArray(vector<double> *A, double ai, double bi);
void arraysSwapElementsOfStringArray(StringArrayReference *A, double ai, double bi);
void arraysReverseNumberArray(vector<double> *array);

vector<wchar_t> *CreateStringScientificNotationDecimalFromNumber(double n);
vector<wchar_t> *CreateStringDecimalFromNumber(double number);
bool CreateStringFromNumberWithCheck(double number, double base, StringReference *stringRef);
double GetMaximumDigitsForBase(double base);
double GetMaximumDigitsForDecimal();
double GetFirstDecimalDigitPosition(double n);
double GetFirstDigitPosition(double n, double base);
bool GetSingleDigitCharacterFromNumberWithCheck(double c, double base, CharacterReference *characterReference);
bool GetDecimalDigitCharacterFromNumberWithCheck(double c, CharacterReference *characterRef);
vector<wchar_t> *GetDigitCharacterTable();
double GetDecimalDigit(double n, double index);
double GetDecimalDigitWithFirstDigitPosition(double n, double digitPosition, double index);
double GetDigit(double n, double base, double index);
vector<wchar_t> *NumberToHumanReadableShortScale(double n);
vector<wchar_t> *NumberToHumanReadableBinary(double n);
vector<wchar_t> *NumberToHumanReadableMetric(double n);

bool IsValidNumber(vector<wchar_t> *str);
bool IsValidInteger(vector<wchar_t> *str);
bool IsValidPositiveInteger(vector<wchar_t> *str);

bool CreateNumberFromDecimalStringWithCheck(vector<wchar_t> *string, NumberReference *decimalReference, StringReference *message);
double CreateNumberFromDecimalString(vector<wchar_t> *string);
bool CreateNumberFromStringWithCheck(vector<wchar_t> *string, double base, NumberReference *numberReference, StringReference *message);
double CreateNumberFromParts(double base, bool numberIsPositive, vector<double> *beforePoint, vector<double> *afterPoint, bool exponentIsPositive, vector<double> *exponent);
bool ExtractPartsFromNumberString(vector<wchar_t> *n, double base, BooleanReference *numberIsPositive, NumberArrayReference *beforePoint, NumberArrayReference *afterPoint, BooleanReference *exponentIsPositive, NumberArrayReference *exponent, StringReference *errorMessages);
double GetNumberFromNumberCharacterForBase(wchar_t c, double base);
bool CharacterIsNumberCharacterInBase(wchar_t c, double base);
vector<double> *StringToNumberArray(vector<wchar_t> *str);
bool StringToNumberArrayWithCheck(vector<wchar_t> *str, NumberArrayReference *numberArrayReference, StringReference *errorMessage);

void strWriteStringToStingStream(vector<wchar_t> *stream, NumberReference *index, vector<wchar_t> *src);
void strWriteCharacterToStingStream(vector<wchar_t> *stream, NumberReference *index, wchar_t src);
void strWriteBooleanToStingStream(vector<wchar_t> *stream, NumberReference *index, bool src);

bool strSubstringWithCheck(vector<wchar_t> *string, double from, double to, StringReference *stringReference);
vector<wchar_t> *strSubstring(vector<wchar_t> *string, double from, double to);
vector<wchar_t> *strAppendString(vector<wchar_t> *s1, vector<wchar_t> *s2);
vector<wchar_t> *strConcatenateString(vector<wchar_t> *s1, vector<wchar_t> *s2);
vector<wchar_t> *strAppendCharacter(vector<wchar_t> *string, wchar_t c);
vector<wchar_t> *strConcatenateCharacter(vector<wchar_t> *string, wchar_t c);
vector<StringReference*> *strSplitByCharacter(vector<wchar_t> *toSplit, wchar_t splitBy);
bool strIndexOfCharacter(vector<wchar_t> *string, wchar_t character, NumberReference *indexReference);
bool strLastIndexOfCharacter(vector<wchar_t> *string, wchar_t character, NumberReference *indexReference);
bool strSubstringEqualsWithCheck(vector<wchar_t> *string, double from, vector<wchar_t> *substring, BooleanReference *equalsReference);
bool strSubstringEquals(vector<wchar_t> *string, double from, vector<wchar_t> *substring);
bool strIndexOfString(vector<wchar_t> *string, vector<wchar_t> *substring, NumberReference *indexReference);
bool strContainsCharacter(vector<wchar_t> *string, wchar_t character);
bool strContainsString(vector<wchar_t> *string, vector<wchar_t> *substring);
void strToUpperCase(vector<wchar_t> *string);
void strToLowerCase(vector<wchar_t> *string);
bool strEqualsIgnoreCase(vector<wchar_t> *a, vector<wchar_t> *b);
vector<wchar_t> *strReplaceString(vector<wchar_t> *string, vector<wchar_t> *toReplace, vector<wchar_t> *replaceWith);
vector<wchar_t> *strReplaceCharacterToNew(vector<wchar_t> *string, wchar_t toReplace, wchar_t replaceWith);
void strReplaceCharacter(vector<wchar_t> *string, wchar_t toReplace, wchar_t replaceWith);
vector<wchar_t> *strTrim(vector<wchar_t> *string);
bool strStartsWith(vector<wchar_t> *string, vector<wchar_t> *start);
bool strEndsWith(vector<wchar_t> *string, vector<wchar_t> *end);
vector<StringReference*> *strSplitByString(vector<wchar_t> *toSplit, vector<wchar_t> *splitBy);
bool strStringIsBefore(vector<wchar_t> *a, vector<wchar_t> *b);
vector<wchar_t> *strJoinStringsWithSeparator(vector<StringReference*> *strings, vector<wchar_t> *separator);
vector<wchar_t> *strJoinStrings(vector<StringReference*> *strings);
double strStringOrder(vector<wchar_t> *a, vector<wchar_t> *b);
vector<wchar_t> *strLeftPad(vector<wchar_t> *str, double width);
vector<wchar_t> *strRightPad(vector<wchar_t> *str, double width);

void AssertFalse(bool b, NumberReference *failures);
void AssertTrue(bool b, NumberReference *failures);
void AssertEquals(double a, double b, NumberReference *failures);
void AssertBooleansEqual(bool a, bool b, NumberReference *failures);
void AssertCharactersEqual(wchar_t a, wchar_t b, NumberReference *failures);
void AssertStringEquals(vector<wchar_t> *a, vector<wchar_t> *b, NumberReference *failures);
void AssertNumberArraysEqual(vector<double> *a, vector<double> *b, NumberReference *failures);
void AssertBooleanArraysEqual(vector<bool> *a, vector<bool> *b, NumberReference *failures);
void AssertStringArraysEqual(vector<StringReference*> *a, vector<StringReference*> *b, NumberReference *failures);

double Negate(double x);
double Positive(double x);
double Factorial(double x);
double Round(double x);
double RoundToDigits(double element, double digitsAfterPoint);
double BankersRound(double x);
double Ceil(double x);
double Floor(double x);
double Truncate(double x);
double Absolute(double x);
double Logarithm(double x);
double NaturalLogarithm(double x);
double Sin(double x);
double Cos(double x);
double Tan(double x);
double Asin(double x);
double Acos(double x);
double Atan(double x);
double Atan2(double y, double x);
double Squareroot(double x);
double Exp(double x);
bool DivisibleBy(double a, double b);
double Combinations(double n, double k);
double Permutations(double n, double k);
bool EpsilonCompare(double a, double b, double epsilon);
double GreatestCommonDivisor(double a, double b);
double GCDWithSubtraction(double a, double b);
bool IsInteger(double a);
bool GreatestCommonDivisorWithCheck(double a, double b, NumberReference *gcdReference);
double LeastCommonMultiple(double a, double b);
double Sign(double a);
double Max(double a, double b);
double Min(double a, double b);
double Power(double a, double b);
double Gamma(double x);
double LogGamma(double x);
double LanczosApproximation(double z);
double Beta(double x, double y);
double Sinh(double x);
double Cosh(double x);
double Tanh(double x);
double Cot(double x);
double Sec(double x);
double Csc(double x);
double Coth(double x);
double Sech(double x);
double Csch(double x);
double Error(double x);
double ErrorInverse(double x);
double FallingFactorial(double x, double n);
double RisingFactorial(double x, double n);
double Hypergeometric(double a, double b, double c, double z, double maxIterations, double precision);
double HypergeometricDirect(double a, double b, double c, double z, double maxIterations, double precision);
double BernouilliNumber(double n);
double AkiyamaTanigawaAlgorithm(double n);

double D15Add(double a, double b, BooleanReference *overflow);
double RoundTo15Digits(double x);
double D15MaxValue();
double D15MinValue();
double D15Multiply(double a, double b, BooleanReference *overflow);
double D15Divide(double a, double b, NumberReference *reminder, BooleanReference *overflow, BooleanReference *invalidOperation);
double D15Exponentiation(double a, double b, BooleanReference *overflow, BooleanReference *invalidOperation);
double D15Modulus(double a, double b, BooleanReference *invalidOperation);
double D15Logarithm(double a, BooleanReference *invalidOperation);
double D15NaturalLogarithm(double a, BooleanReference *invalidOperation);
double D15Sin(double a);
double D15Cos(double x);
double D15Tan(double a, BooleanReference *overflow);
double D15Asin(double a, BooleanReference *invalidOperation);
double D15Acos(double a, BooleanReference *invalidOperation);
double D15Atan(double a);
double D15Sqrt(double a);
double D15Exponential(double a, BooleanReference *overflow);
vector<wchar_t> *Decimal15E2ToString(double decimal);
wchar_t SingleDigitNumberToCharacter(double n);

wchar_t cToLowerCase(wchar_t character);
wchar_t cToUpperCase(wchar_t character);
bool cIsUpperCase(wchar_t character);
bool cIsLowerCase(wchar_t character);
bool cIsLetter(wchar_t character);
bool cIsNumber(wchar_t character);
bool cIsWhiteSpace(wchar_t character);
bool cIsSymbol(wchar_t character);
bool cCharacterIsBefore(wchar_t a, wchar_t b);
wchar_t cDecimalDigitToCharacter(double digit);
double cCharacterToDecimalDigit(wchar_t c);

Structure *CreateLedger(double decimals){
  Structure *ledger;
  Array *transactions;

  ledger = CreateStructure();
  transactions = CreateArray();
  AddNumberToStruct(ledger, toVector(L"decimals"), decimals);
  AddArrayToStruct(ledger, toVector(L"transactions"), transactions);

  return ledger;
}
FixedPoint15d *CreateFixedPointForDynamicLedger(Structure *ledger){
  FixedPoint15d *n;
  double d;

  d = GetNumberFromStruct(ledger, toVector(L"decimals"));
  n = CreateFixedPoint15d(15.0 - d, d);

  return n;
}
FixedPoint15d *CreateFixedPointForStaticLedger(Ledger *ledger){
  FixedPoint15d *n;
  double d;

  d = ledger->decimals;
  n = CreateFixedPoint15d(15.0 - d, d);

  return n;
}
Line *CreateLine(vector<wchar_t> *account, FixedPoint15d *debit, FixedPoint15d *credit, vector<wchar_t> *description, Date *date){
  Line *t;

  t = new Line();

  t->account = arraysCopyString(account);
  t->debit = Copy15d(debit);
  t->credit = Copy15d(credit);
  t->description = arraysCopyString(description);
  t->date = CopyDate(date);

  return t;
}
void AddTransactionToLedger(Array *ledger, Line *src){
  Structure *dst;

  dst = LineToStructure(src);

  AddStructToArray(ledger, dst);
}
void AddTransactionsToLedger(Array *ledger, vector<Line*> *ts){
  Structure *dst;
  double i;

  for(i = 0.0; i < (double)ts->size(); i = i + 1.0){
    dst = LineToStructure(ts->at(i));
    AddStructToArray(ledger, dst);
  }
}
bool ValidateAndAddTransactionToLedger(Structure *ledger, vector<Line*> *ls){
  Structure *dst;
  double i;
  bool valid;
  Array *transactions;
  Array *lines;

  transactions = GetArrayFromStruct(ledger, toVector(L"transactions"));

  valid = ValidateTransaction(ls, ledger);

  if(valid){
    lines = CreateArray();

    for(i = 0.0; i < (double)ls->size(); i = i + 1.0){
      dst = LineToStructure(ls->at(i));
      AddStructToArray(lines, dst);
    }

    AddArrayToArray(transactions, lines);
  }

  return valid;
}
Line *GetTransactionFromLedger(Structure *ledger, double index){
  Structure *dst;
  Line *t;
  Array *transactions;
  double decimals;

  transactions = GetArrayFromStruct(ledger, toVector(L"transactions"));
  decimals = GetNumberFromStruct(ledger, toVector(L"decimals"));

  dst = ArrayIndexStruct(transactions, index);

  t = LineFromStructure(dst, ledger);

  return t;
}
Structure *LineToStructure(Line *src){
  Structure *dst;
  vector<wchar_t> *debitStr, *creditStr, *dateStr;

  dst = CreateStructure();

  debitStr = ToString15d(src->debit);
  creditStr = ToString15d(src->credit);
  dateStr = DateToStringISO8601(src->date);

  AddStringToStruct(dst, toVector(L"account"), src->account);
  AddStringToStruct(dst, toVector(L"debit"), debitStr);
  AddStringToStruct(dst, toVector(L"credit"), creditStr);
  AddStringToStruct(dst, toVector(L"date"), dateStr);
  AddStringToStruct(dst, toVector(L"description"), src->description);

  return dst;
}
Line *LineFromStructure(Structure *src, Structure *ledger){
  Line *dst;
  vector<wchar_t> *account, *debitStr, *creditStr, *dateStr, *description;
  FixedPoint15d *debit, *credit;
  Date *date;
  double debitNumber, creditNumber;

  account = GetStringFromStruct(src, toVector(L"account"));
  debitStr = GetStringFromStruct(src, toVector(L"debit"));
  creditStr = GetStringFromStruct(src, toVector(L"credit"));
  dateStr = GetStringFromStruct(src, toVector(L"date"));
  description = GetStringFromStruct(src, toVector(L"description"));

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
Ledger *LedgerDynamicToStatic(Structure *src){
  Ledger *dst;
  double ts, ls, i, j, decimals;
  Structure *line;
  Array *transactions, *lines;
  Line *sline;
  Transaction *t;

  dst = new Ledger();

  transactions = GetArrayFromStruct(src, toVector(L"transactions"));
  decimals = GetNumberFromStruct(src, toVector(L"decimals"));
  ts = ArrayLength(transactions);

  dst->decimals = decimals;
  dst->transactions = new vector<Transaction*> (ts);

  for(i = 0.0; i < ts; i = i + 1.0){
    lines = ArrayIndexArray(transactions, i);
    ls = ArrayLength(lines);

    t = new Transaction();
    t->lines = new vector<Line*> (ls);

    for(j = 0.0; j < ls; j = j + 1.0){
      line = ArrayIndexStruct(lines, j);
      sline = LineFromStructure(line, src);
      t->lines->at(j) = sline;
    }

    dst->transactions->at(i) = t;
  }

  return dst;
}
bool ValidateTransaction(vector<Line*> *ts, Structure *ledger){
  bool valid;
  FixedPoint15d *creditSum, *debitSum;
  double i, d, c;
  Line *t;
  vector<wchar_t> *creditStr, *debitStr;
  Date *date;

  valid = true;

  if((double)ts->size() > 0.0){
    date = ts->at(0)->date;

    creditSum = CreateFixedPointForDynamicLedger(ledger);
    debitSum = CreateFixedPointForDynamicLedger(ledger);

    for(i = 0.0; i < (double)ts->size() && valid; i = i + 1.0){
      t = ts->at(i);

      d = ToNumber15d(t->debit);
      c = ToNumber15d(t->credit);

      Add15d(creditSum, creditSum, t->credit);
      Add15d(debitSum, debitSum, t->debit);

      if(DateEquals(date, t->date) && (d == 0.0 || c == 0.0)){
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
bool ValidateTransactions(vector<Line*> *ts, NumberArrayReference *invalidIds){
  bool valid;

  /* TODO */
  valid = true;

  return valid;
}
Account *ComputeAccountBalance(Ledger *ledger, vector<wchar_t> *accountName, Date *fromDate, Date *toDate){
  Account *a;
  double i, j;
  Transaction *t;
  vector<Transaction*> *ts;
  Line *l;

  ts = ledger->transactions;

  a = new Account();

  a->name = arraysCopyString(accountName);
  a->endingBalance = CreateFixedPointForStaticLedger(ledger);
  a->startingBalance = CreateFixedPointForStaticLedger(ledger);
  a->from = CopyDate(fromDate);
  a->to = CopyDate(toDate);
  a->sumDebit = CreateFixedPointForStaticLedger(ledger);
  a->sumCredit = CreateFixedPointForStaticLedger(ledger);

  for(i = 0.0; i < (double)ts->size(); i = i + 1.0){
    t = ts->at(i);

    for(j = 0.0; j < (double)t->lines->size(); j = j + 1.0){
      l = t->lines->at(j);

      if(arraysStringsEqual(l->account, accountName)){

        if(DateLessThan(l->date, fromDate)){
          Add15d(a->startingBalance, a->startingBalance, l->debit);
          Subtract15d(a->startingBalance, a->startingBalance, l->credit);
        }else if(DateLessThan(l->date, toDate)){
          Add15d(a->endingBalance, a->endingBalance, l->debit);
          Subtract15d(a->endingBalance, a->endingBalance, l->credit);

          Add15d(a->sumDebit, a->sumDebit, l->debit);
          Add15d(a->sumCredit, a->sumCredit, l->credit);
        }
      }
    }
  }

  Add15d(a->endingBalance, a->endingBalance, a->startingBalance);

  return a;
}
vector<wchar_t> *AccountToString(Account *account){
  LinkedListCharacters *ll;
  FixedPoint15d *diff;

  ll = CreateLinkedListCharacter();

  diff = Copy15d(account->endingBalance);
  Subtract15d(diff, diff, account->startingBalance);

  LinkedListCharactersAddString(ll, account->name);
  LinkedListCharactersAddString(ll, toVector(L": "));
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account->startingBalance, 2.0, toVector(L""), toVector(L".")));
  LinkedListCharactersAddString(ll, toVector(L" -> "));
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account->endingBalance, 2.0, toVector(L""), toVector(L".")));
  LinkedListCharactersAddString(ll, toVector(L": "));
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(diff, 2.0, toVector(L","), toVector(L".")));
  LinkedListCharactersAddString(ll, toVector(L" (+"));
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account->sumDebit, 2.0, toVector(L""), toVector(L".")));
  LinkedListCharactersAddString(ll, toVector(L", -"));
  LinkedListCharactersAddString(ll, FormatToStringWithSymbols15d(account->sumCredit, 2.0, toVector(L""), toVector(L".")));
  LinkedListCharactersAddString(ll, toVector(L")"));

  return LinkedListCharactersToArray(ll);
}
void AddMonthlyAccruals(Structure *ledger, Date *from, Date *to, double amount, vector<wchar_t> *fromAccount, vector<wchar_t> *toAccount){
  double i;
  vector<wchar_t> *accountName, *desc;
  vector<double> *amounts;
  vector<Line*> *transaction;
  bool valid;
  Date *date;
  FixedPoint15d *c, *d;

  amounts = GetAccrualsWithDates(amount, from, to);

  date = CopyDate(from);
  date->day = 1.0;

  c = CreateFixedPointForDynamicLedger(ledger);
  d = CreateFixedPointForDynamicLedger(ledger);

  for(i = 0.0; i < (double)amounts->size(); i = i + 1.0){
    transaction = new vector<Line*> (2.0);

    accountName = fromAccount;
    Assign15d(d, amounts->at(i));
    Assign15d(c, 0.0);
    desc = toVector(L"x");
    transaction->at(0) = CreateLine(accountName, d, c, desc, date);

    accountName = toAccount;
    Assign15d(d, 0.0);
    Assign15d(c, amounts->at(i));
    desc = toVector(L"x");
    transaction->at(1) = CreateLine(accountName, d, c, desc, date);

    valid = ValidateAndAddTransactionToLedger(ledger, transaction);

    AddMonthsToDate(date, 1.0);
  }
}
FixedPoint15d *ComputeAccountBalancePrefixAccount(Ledger *ledger, vector<wchar_t> *accountNr, Date *toDate, bool debitBalance){
  double i, j;
  Transaction *t;
  vector<Transaction*> *ts;
  Line *l;
  FixedPoint15d *balance;
  LinkedListCharacters *prefixL;
  vector<wchar_t> *prefixed;

  prefixL = CreateLinkedListCharacter();
  LinkedListCharactersAddString(prefixL, accountNr);
  LinkedListCharactersAddString(prefixL, toVector(L"."));

  prefixed = LinkedListCharactersToArray(prefixL);

  ts = ledger->transactions;

  balance = CreateFixedPointForStaticLedger(ledger);

  for(i = 0.0; i < (double)ts->size(); i = i + 1.0){
    t = ts->at(i);

    for(j = 0.0; j < (double)t->lines->size(); j = j + 1.0){
      l = t->lines->at(j);

      if(strStartsWith(l->account, prefixed) || arraysStringsEqual(l->account, accountNr)){
        if(DateLessThan(l->date, toDate) || DateEquals(l->date, toDate)){
          if(debitBalance){
            Add15d(balance, balance, l->debit);
            Subtract15d(balance, balance, l->credit);
          }else{
            Add15d(balance, balance, l->credit);
            Subtract15d(balance, balance, l->debit);
          }
        }
      }
    }
  }

  return balance;
}
AccountPlan *GetIFRSAccountPlan(){
  vector<wchar_t> *accountPlanString;
  BooleanReference *validRef;
  LinkedListCharacters *ll;

  ll = CreateLinkedListCharacter();

  /* https://www.ifrs-gaap.com/ifrs-chart-accounts */
  validRef = CreateBooleanReference(false);

  LinkedListCharactersAddString(ll, toVector(L"1\tAssets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1\tProperty, plant and equipment\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.1\tLand and land improvements\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.2\tBuildings, structures and improvements\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.3\tMachinery and equipment\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.4\tFixtures and fittings\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.5\tRight of use assets (classified as PP&E)\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.6\tAdditional property, plant and equipment\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1.7\tConstruction in progress\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.2\tInvestment property\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.2.1\tCompleted\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.2.2\tUnder construction or development\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.3\tGoodwill\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4\tIntangible assets excluding goodwill\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.1\tIntellectual property\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.2\tComputer software\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.3\tTrade and distribution assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.4\tContracts and rights\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.5\tRight of use assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.6\tCrypto assets (classified as intangible)\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.7\tAdditional intangible assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.4.8\tAcquisition in progress\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.5\tFinancial assets and investments\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.5.1\tNon-derivative financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.5.2\tDerivative financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.5.3\tAdditional financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.5.4\tCrypto assets (classified as financial assets)\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.6\tInventories\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.6.1\tMerchandise\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.6.2\tRaw materials and production supplies\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.6.3\tWork in progress\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.6.4\tFinished goods\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.6.5\tOther inventories\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.7\tPrepayments and accrued income\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.7.1\tPrepayments\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.7.2\tAccrued income\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.7.3\tService provider work in process (not classified as inventory)\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.7.4\tAdditional assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.8\tReceivables and contracts\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.8.1\tLoans and receivables\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.8.2\tContracts with customers\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.8.3\tNontrade and other receivables\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.9\tTax assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.9.1\tTax assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.9.2\tDeferred tax assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.9.3\tOther tax assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.1\tAgricultural biological assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.10.1\tBearer plants\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.10.2\tAnimals\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.10.3\tOther agricultural assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.11\tCash and cash equivalents\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.11.1\tCash\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.11.2\tCash equivalents\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"1.11.3\tRestricted cash and financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"2\tEquity\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.1\tTotal equity attributable to owners of parent\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.1.1\tIssued capital\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.1.2\tAdditional item paid-in capital\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.1.3\tPartner\'s capital\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.1.4\tMember\'s equity\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.1.5\tOther equity interest\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.2\tRetained earnings\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.2.3\tIn suspense\tZero\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.3\tAccumulated other comprehensive income\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.3.2\tMiscellaneous equity\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.4\tOwners equity (non-shareholder)\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"2.5\tNon-controlling interests\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3\tLiabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.1\tTrade and other payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.1.1\tTrade payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.1.2\tDividend payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.1.3\tInterest payable\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.1.4\tOther payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.2\tProvisions\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.2.1\tCustomer related provisions\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.2.2\tLitigation and regulatory\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.2.3\tAdditional provisions\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3\tOther financial liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3.1\tNotes payable\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3.2\tLoans received\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3.3\tBonds (debentures)\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3.4\tOther debts and borrowings\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3.5\tLease obligations\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.3.6\tDerivative financial liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.4.1\tAccruals\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.4.2\tDeferred income and refund liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.4.3\tAccrued taxes other than payroll\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"3.4.4\tAdditional liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4\tRevenue\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.1\tRecognized point of time\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.1.1\tGoods\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.1.2\tServices\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.2\tRecognized over time\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.2.1\tProducts and projects\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.2.2\tServices\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.3\tAdjustments\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.3.1\tVariable consideration\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.3.2\tConsideration paid payable to customers\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"4.3.3\tOther adjustments\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5\tExpenses\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1\tExpenses (classified by nature)\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1.1\tMaterial and merchandise\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1.2\tEmployee benefits expense\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1.3\tServices expense\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1.4\tRent, depreciation, amortization and depletion\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.1.6\tOther work performed by entity and capitalized\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.2\tExpenses (classified by function)\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.2.1\tCost of sales\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"5.2.2\tSelling, general and administrative expense\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"6\tOther non-operating income and expenses\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"6.1\tOther revenue and expenses\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"6.1.1\tOther revenue\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"6.1.2\tOther expenses\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"6.2\tGains and losses\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"6.3\tTaxes other than income and payroll and fees\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"6.4\tTax income (expense)\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7\tIntercompany and related party accounts\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.1\tIntercompany and related party assets\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.1.1\tIntercompany balances eliminated in consolidation\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.1.2\tRelated party balances reported or disclosed\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.1.3\tIntercompany investments\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.2\tIntercompany and related party liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.2.2\tRelated party balances reported or disclosed\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.3\tIntercompany and related party income and expense\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.3.1\tIntercompany and related party income\t(Cr)\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.3.2\tIntercompany and related party expenses\tDr\n"));
  LinkedListCharactersAddString(ll, toVector(L"7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n"));

  accountPlanString = LinkedListCharactersToArray(ll);

  FreeLinkedListCharacter(ll);

  return ParseAccountPlanString(accountPlanString, validRef);
}
AccountPlan *ParseAccountPlanString(vector<wchar_t> *accountPlanString, BooleanReference *valid){
  AccountPlan *ap;
  double i;
  vector<wchar_t> *line;
  vector<StringReference*> *lines, *parts;
  AccountDefinition *ad;

  ap = new AccountPlan();

  accountPlanString = strTrim(accountPlanString);
  lines = strSplitByCharacter(accountPlanString, '\n');

  ap->accountDefinitions = new vector<AccountDefinition*> ((double)lines->size());

  for(i = 0.0; i < (double)lines->size(); i = i + 1.0){
    line = lines->at(i)->string;
    /*System.out.println(line); */
    parts = strSplitByCharacter(line, '\t');

    ad = new AccountDefinition();

    ad->accountName = parts->at(1)->string;
    ad->number = parts->at(0)->string;
    if(arraysStringsEqual(parts->at(2)->string, toVector(L"(Cr)"))){
      ad->debitBalance = false;
    }else{
      ad->debitBalance = true;
    }
    ad->role = toVector(L"");
    if(arraysStringsEqual(ad->number, toVector(L"1"))){
      ad->role = toVector(L"Assets");
    }else if(arraysStringsEqual(ad->number, toVector(L"2"))){
      ad->role = toVector(L"Equities");
    }else if(arraysStringsEqual(ad->number, toVector(L"3"))){
      ad->role = toVector(L"Liabilities");
    }else if(arraysStringsEqual(ad->number, toVector(L"4"))){
      ad->role = toVector(L"Revenue");
    }else if(arraysStringsEqual(ad->number, toVector(L"5"))){
      ad->role = toVector(L"Expenses");
    }

    ap->accountDefinitions->at(i) = ad;
  }

  return ap;
}
bool ComputeAccountBalances(Ledger *sledger, double depth, Date *date, DataReference *balanceSheet){
  AccountPlan *accountPlan;
  FixedPoint15d *assetsBalance, *liabilitiesBalance, *equitiesBalance, *revenueBalanace, *expensesBalance, *resultBalance, *sum, *balance;
  vector<wchar_t> *balanceStr;
  AccountDefinition *assetsDef, *liabilitiesDef, *equitiesDef, *revenueDef, *expensesDef, *accountDef;
  bool success, isBalanced;
  double i;
  vector<StringReference*> *parts;
  BooleanReference *foundRef;
  Array *accounts;
  Structure *account;
  vector<wchar_t> *dateStr;

  balanceSheet->data = CreateNewStructData();
  success = true;

  foundRef = CreateBooleanReference(false);

  accountPlan = sledger->accountPlan;

  assetsDef = FindAccountWithRole(accountPlan, toVector(L"Assets"), foundRef);
  success = success && foundRef->booleanValue;
  liabilitiesDef = FindAccountWithRole(accountPlan, toVector(L"Liabilities"), foundRef);
  success = success && foundRef->booleanValue;
  equitiesDef = FindAccountWithRole(accountPlan, toVector(L"Equities"), foundRef);
  success = success && foundRef->booleanValue;
  revenueDef = FindAccountWithRole(accountPlan, toVector(L"Revenue"), foundRef);
  success = success && foundRef->booleanValue;
  expensesDef = FindAccountWithRole(accountPlan, toVector(L"Expenses"), foundRef);
  success = success && foundRef->booleanValue;

  if(success){
    assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef->number, date, assetsDef->debitBalance);
    liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef->number, date, liabilitiesDef->debitBalance);

    /* TODO: This must be for a period */
    revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef->number, date, revenueDef->debitBalance);
    expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef->number, date, expensesDef->debitBalance);
    resultBalance = CreateFixedPointForStaticLedger(sledger);
    Subtract15d(resultBalance, revenueBalanace, expensesBalance);
    balanceStr = FormatToStringWithSymbols15d(resultBalance, 2.0, toVector(L""), toVector(L"."));
    AddStringToStruct(balanceSheet->data->structure, toVector(L"result"), balanceStr);

    equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef->number, date, equitiesDef->debitBalance);
    Add15d(equitiesBalance, equitiesBalance, resultBalance);

    /* Compute accounts */
    accounts = CreateArray();

    for(i = 0.0; i < (double)accountPlan->accountDefinitions->size(); i = i + 1.0){
      accountDef = accountPlan->accountDefinitions->at(i);

      parts = strSplitByCharacter(accountDef->number, '.');

      if((double)parts->size() <= depth + 1.0){
        account = CreateStructure();

        balance = ComputeAccountBalancePrefixAccount(sledger, accountDef->number, date, accountDef->debitBalance);

        balanceStr = FormatToStringWithSymbols15d(balance, 2.0, toVector(L""), toVector(L"."));

        AddStringToStruct(account, toVector(L"number"), accountDef->number);
        AddStringToStruct(account, toVector(L"name"), accountDef->accountName);
        AddStringToStruct(account, toVector(L"balance"), balanceStr);
        AddNumberToStruct(account, toVector(L"depth"), (double)parts->size() - 1.0);

        AddStructToArray(accounts, account);
      }
    }

    AddArrayToStruct(balanceSheet->data->structure, toVector(L"accounts"), accounts);

    /* End conclusion */
    balanceStr = FormatToStringWithSymbols15d(assetsBalance, 2.0, toVector(L""), toVector(L"."));
    AddStringToStruct(balanceSheet->data->structure, toVector(L"assets"), balanceStr);

    sum = CreateFixedPointForStaticLedger(sledger);
    Add15d(sum, liabilitiesBalance, equitiesBalance);
    balanceStr = FormatToStringWithSymbols15d(sum, 2.0, toVector(L""), toVector(L"."));
    AddStringToStruct(balanceSheet->data->structure, toVector(L"liabilitiesAndEquity"), balanceStr);

    isBalanced = Equals15d(sum, assetsBalance);
    AddBooleanToStruct(balanceSheet->data->structure, toVector(L"balanced"), isBalanced);

    dateStr = DateToStringISO8601(date);
    AddStringToStruct(balanceSheet->data->structure, toVector(L"date"), dateStr);
  }

  return success;
}
vector<wchar_t> *AccountBalancesToString(Structure *balanceSheet){
  LinkedListCharacters *ll;
  vector<wchar_t> *balanceStr;
  bool isBalanced;
  double i, j, depth;
  Array *accounts;
  Structure *account;
  vector<wchar_t> *accountNumber, *accountName;

  ll = CreateLinkedListCharacter();

  /* Print accounts */
  accounts = GetArrayFromStruct(balanceSheet, toVector(L"accounts"));

  for(i = 0.0; i < ArrayLength(accounts); i = i + 1.0){
    account = ArrayIndexStruct(accounts, i);

    accountNumber = GetStringFromStruct(account, toVector(L"number"));
    accountName = GetStringFromStruct(account, toVector(L"name"));
    balanceStr = GetStringFromStruct(account, toVector(L"balance"));
    depth = GetNumberFromStruct(account, toVector(L"depth"));

    for(j = 0.0; j < depth; j = j + 1.0){
      LinkedListCharactersAddString(ll, toVector(L"  "));
    }

    LinkedListCharactersAddString(ll, accountNumber);
    LinkedListCharactersAddString(ll, toVector(L". "));
    LinkedListCharactersAddString(ll, accountName);
    LinkedListCharactersAddString(ll, toVector(L": "));
    LinkedListCharactersAddString(ll, balanceStr);
    LinkedListCharactersAddString(ll, toVector(L"\n"));
  }

  /* End conclusion */
  LinkedListCharactersAddString(ll, toVector(L"\n"));

  LinkedListCharactersAddString(ll, toVector(L"Result: "));
  balanceStr = GetStringFromStruct(balanceSheet, toVector(L"result"));
  LinkedListCharactersAddString(ll, balanceStr);
  LinkedListCharactersAddString(ll, toVector(L"\n"));

  LinkedListCharactersAddString(ll, toVector(L"Assets: "));
  balanceStr = GetStringFromStruct(balanceSheet, toVector(L"assets"));
  LinkedListCharactersAddString(ll, balanceStr);
  LinkedListCharactersAddString(ll, toVector(L"\n"));

  LinkedListCharactersAddString(ll, toVector(L"Liabilities + Equities: "));
  balanceStr = GetStringFromStruct(balanceSheet, toVector(L"liabilitiesAndEquity"));
  LinkedListCharactersAddString(ll, balanceStr);
  LinkedListCharactersAddString(ll, toVector(L"\n"));

  isBalanced = GetBooleanFromStruct(balanceSheet, toVector(L"balanced"));
  LinkedListCharactersAddString(ll, toVector(L"Balance: "));
  if(isBalanced){
    LinkedListCharactersAddString(ll, toVector(L"true"));
  }else{
    LinkedListCharactersAddString(ll, toVector(L"false"));
  }
  LinkedListCharactersAddString(ll, toVector(L"\n"));

  return LinkedListCharactersToArray(ll);
}
AccountDefinition *FindAccountWithRole(AccountPlan *accountPlan, vector<wchar_t> *role, BooleanReference *foundRef){
  double i;
  AccountDefinition *ad;
  bool done;

  ad = new AccountDefinition();

  done = false;
  for(i = 0.0; i < (double)accountPlan->accountDefinitions->size() &&  !done ; i = i + 1.0){
    ad = accountPlan->accountDefinitions->at(i);
    if(arraysStringsEqual(ad->role, role)){
      done = true;
    }
  }

  foundRef->booleanValue = done;

  return ad;
}
AccountDefinition *CreateAccountDefinition(vector<wchar_t> *name, vector<wchar_t> *number, vector<wchar_t> *role, bool debitBalance){
  AccountDefinition *def;

  def = new AccountDefinition();
  def->accountName = name;
  def->number = number;
  def->role = role;
  def->debitBalance = debitBalance;

  return def;
}
void ComputeBalanceDiffs(Ledger *sledger, Array *balances){
  double i, j;
  Structure *balance, *first, *balance1, *balance2;
  Structure *account1, *account2;
  vector<wchar_t> *b1, *b2, *diffStr;
  FixedPoint15d *f1, *f2, *diff;
  Array *accountsO, *accounts1, *accounts2;

  first = ArrayIndexStruct(balances, 0.0);
  accountsO = GetArrayFromStruct(first, toVector(L"accounts"));

  for(j = 0.0; j < ArrayLength(accountsO); j = j + 1.0){
    for(i = 1.0; i < ArrayLength(balances); i = i + 1.0){
      balance1 = ArrayIndexStruct(balances, i - 1.0);
      balance2 = ArrayIndexStruct(balances, i);
      accounts1 = GetArrayFromStruct(balance1, toVector(L"accounts"));
      accounts2 = GetArrayFromStruct(balance2, toVector(L"accounts"));

      account1 = ArrayIndexStruct(accounts1, j);
      account2 = ArrayIndexStruct(accounts2, j);

      b1 = GetStringFromStruct(account1, toVector(L"balance"));
      b2 = GetStringFromStruct(account2, toVector(L"balance"));

      f1 = CreateFixedPointForStaticLedger(sledger);
      f2 = CreateFixedPointForStaticLedger(sledger);
      diff = CreateFixedPointForStaticLedger(sledger);

      Assign15d(f1, CreateNumberFromDecimalString(b1));
      Assign15d(f2, CreateNumberFromDecimalString(b2));

      Subtract15d(diff, f2, f1);

      diffStr = FormatToStringWithSymbols15d(diff, sledger->decimals, toVector(L""), toVector(L"."));

      /*System.out.println(diffStr); */
      if(i == 1.0){
        AddStringToStruct(account1, toVector(L"change"), toVector(L"0.00"));
      }
      AddStringToStruct(account2, toVector(L"change"), diffStr);
    }
  }

  for(i = 1.0; i < ArrayLength(balances); i = i + 1.0){
    balance1 = ArrayIndexStruct(balances, i - 1.0);
    balance2 = ArrayIndexStruct(balances, i);
    b1 = GetStringFromStruct(balance1, toVector(L"result"));
    b2 = GetStringFromStruct(balance2, toVector(L"result"));

    f1 = CreateFixedPointForStaticLedger(sledger);
    f2 = CreateFixedPointForStaticLedger(sledger);
    diff = CreateFixedPointForStaticLedger(sledger);

    Assign15d(f1, CreateNumberFromDecimalString(b1));
    Assign15d(f2, CreateNumberFromDecimalString(b2));

    Subtract15d(diff, f2, f1);

    diffStr = FormatToStringWithSymbols15d(diff, sledger->decimals, toVector(L""), toVector(L"."));

    /*System.out.println(diffStr); */
    if(i == 1.0){
      AddStringToStruct(balance1, toVector(L"rchange"), toVector(L"0.00"));
    }
    AddStringToStruct(balance2, toVector(L"rchange"), diffStr);
  }
}
vector<wchar_t> *BalancesArrayToHTML(Array *balances, bool includeBalance, bool includeDiff){
  LinkedListCharacters *ll;
  double i, j;
  Structure *balance, *first;
  vector<wchar_t> *dateStr, *name, *number, *balanceStr, *changeStr;
  Structure *account;
  Array *accounts;

  ll = CreateLinkedListCharacter();

  LinkedListCharactersAddString(ll, toVector(L"<html>"));
  LinkedListCharactersAddString(ll, toVector(L"<body>"));
  LinkedListCharactersAddString(ll, toVector(L"<table>"));

  /* Headers */
  LinkedListCharactersAddString(ll, toVector(L"<tr>"));

  LinkedListCharactersAddString(ll, toVector(L"<td>"));
  LinkedListCharactersAddString(ll, toVector(L"</td>"));
  LinkedListCharactersAddString(ll, toVector(L"<td>"));
  LinkedListCharactersAddString(ll, toVector(L"</td>"));

  for(i = 0.0; i < ArrayLength(balances); i = i + 1.0){
    balance = ArrayIndexStruct(balances, i);
    dateStr = GetStringFromStruct(balance, toVector(L"date"));
    dateStr = strSubstring(dateStr, 0.0, 7.0);

    LinkedListCharactersAddString(ll, toVector(L"<td>"));
    LinkedListCharactersAddString(ll, dateStr);
    LinkedListCharactersAddString(ll, toVector(L"</td>"));
  }

  LinkedListCharactersAddString(ll, toVector(L"</tr>"));

  /* Each account */
  first = ArrayIndexStruct(balances, 0.0);
  accounts = GetArrayFromStruct(first, toVector(L"accounts"));
  for(j = 0.0; j < ArrayLength(accounts); j = j + 1.0){
    LinkedListCharactersAddString(ll, toVector(L"<tr>"));

    account = ArrayIndexStruct(accounts, j);
    name = GetStringFromStruct(account, toVector(L"name"));
    number = GetStringFromStruct(account, toVector(L"number"));

    LinkedListCharactersAddString(ll, toVector(L"<td>"));
    LinkedListCharactersAddString(ll, number);
    LinkedListCharactersAddString(ll, toVector(L"</td>"));

    LinkedListCharactersAddString(ll, toVector(L"<td>"));
    LinkedListCharactersAddString(ll, name);
    LinkedListCharactersAddString(ll, toVector(L"</td>"));

    for(i = 0.0; i < ArrayLength(balances); i = i + 1.0){
      balance = ArrayIndexStruct(balances, i);
      accounts = GetArrayFromStruct(balance, toVector(L"accounts"));
      account = ArrayIndexStruct(accounts, j);
      balanceStr = GetStringFromStruct(account, toVector(L"balance"));
      changeStr = GetStringFromStruct(account, toVector(L"change"));

      LinkedListCharactersAddString(ll, toVector(L"<td style=\"text-align: right;\">"));

      if(includeBalance && includeDiff){
        LinkedListCharactersAddString(ll, balanceStr);
        LinkedListCharactersAddString(ll, toVector(L"<br><small style=\"color: grey\">"));
        LinkedListCharactersAddString(ll, changeStr);
        LinkedListCharactersAddString(ll, toVector(L"</small>"));
      }else if(includeBalance){
        LinkedListCharactersAddString(ll, balanceStr);
      }else if(includeDiff){
        LinkedListCharactersAddString(ll, changeStr);
      }

      LinkedListCharactersAddString(ll, toVector(L"</td>"));
    }

    LinkedListCharactersAddString(ll, toVector(L"</tr>"));
  }

  /* Result */
  LinkedListCharactersAddString(ll, toVector(L"<tr>"));

  LinkedListCharactersAddString(ll, toVector(L"<td>"));
  LinkedListCharactersAddString(ll, toVector(L""));
  LinkedListCharactersAddString(ll, toVector(L"</td>"));

  LinkedListCharactersAddString(ll, toVector(L"<td>"));
  LinkedListCharactersAddString(ll, toVector(L"Result"));
  LinkedListCharactersAddString(ll, toVector(L"</td>"));

  for(i = 0.0; i < ArrayLength(balances); i = i + 1.0){
    balance = ArrayIndexStruct(balances, i);
    balanceStr = GetStringFromStruct(balance, toVector(L"result"));
    changeStr = GetStringFromStruct(balance, toVector(L"rchange"));

    LinkedListCharactersAddString(ll, toVector(L"<td style=\"text-align: right;\">"));

    if(includeBalance && includeDiff){
      LinkedListCharactersAddString(ll, balanceStr);
      LinkedListCharactersAddString(ll, toVector(L"<br><small style=\"color: grey\">"));
      LinkedListCharactersAddString(ll, changeStr);
      LinkedListCharactersAddString(ll, toVector(L"</small>"));
    }else if(includeBalance){
      LinkedListCharactersAddString(ll, balanceStr);
    }else if(includeDiff){
      LinkedListCharactersAddString(ll, changeStr);
    }

    LinkedListCharactersAddString(ll, toVector(L"</td>"));
  }

  LinkedListCharactersAddString(ll, toVector(L"</tr>"));

  /* Footer */
  LinkedListCharactersAddString(ll, toVector(L"</table>"));
  LinkedListCharactersAddString(ll, toVector(L"</body>"));
  LinkedListCharactersAddString(ll, toVector(L"</html>"));

  return LinkedListCharactersToArray(ll);
}
Line *CreateLineFromScript(Structure *ledger, vector<wchar_t> *script, Date *date){
  vector<StringReference*> *parts;
  FixedPoint15d *c, *d;
  Line *line;
  double i, n;

  c = CreateFixedPointForDynamicLedger(ledger);
  d = CreateFixedPointForDynamicLedger(ledger);

  parts = strSplitByCharacter(script, ',');

  for(i = 0.0; i < (double)parts->size(); i = i + 1.0){
    parts->at(i)->string = strTrim(parts->at(i)->string);
  }

  line = new Line();

  n = CreateNumberFromDecimalString(parts->at(2)->string);

  line->date = date;
  if(arraysStringsEqual(parts->at(0)->string, toVector(L"Debit"))){
    Assign15d(d, n);
    Assign15d(c, 0.0);
  }else if(arraysStringsEqual(parts->at(0)->string, toVector(L"Credit"))){
    Assign15d(d, 0.0);
    Assign15d(c, n);
  }

  line = CreateLine(parts->at(1)->string, d, c, parts->at(3)->string, date);

  return line;
}
double test(){
  NumberReference *failures;

  failures = CreateNumberReference(0.0);

  TestBasicAccounting(failures);
  TestAccruals(failures);
  TestIFRSAccountPlan(failures);

  return failures->numberValue;
}
void TestIFRSAccountPlan(NumberReference *failures){
  GetIFRSAccountPlan();
}
void TestBasicAccounting(NumberReference *failures){
  Structure *ledger;
  FixedPoint15d *c, *d;
  vector<Line*> *transaction;
  bool valid;
  Date *date, *from, *to;
  Account *account;
  vector<wchar_t> *accountName, *accountStr, *desc;
  Ledger *sledger;

  ledger = CreateLedger(2.0);

  /*c = CreateFixedPointForDynamicLedger(ledger); */
  /*d = CreateFixedPointForDynamicLedger(ledger); */
  /* Transaction 1: */
  transaction = new vector<Line*> (2.0);
  /*date = CreateDate(2026d, 2d, 18d); */
  date = DateFromStringISO8601(toVector(L"2026-02-18"));

  /* Debit, 100, 1000, l1, 2026-02-18 */
  /*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
         */
  transaction->at(0) = CreateLineFromScript(ledger, toVector(L"Debit, 1000, 100, l1"), date);

  /* Credit, 100, 2000, l2, 2026-02-18 */
  /*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
         */
  transaction->at(1) = CreateLineFromScript(ledger, toVector(L"Credit, 2000, 100, l2"), date);

  valid = ValidateAndAddTransactionToLedger(ledger, transaction);

  AssertTrue(valid, failures);

  /* Compute */
  sledger = LedgerDynamicToStatic(ledger);

  accountName = toVector(L"1000");
  from = DateFromStringISO8601(toVector(L"2026-02-17"));
  to = DateFromStringISO8601(toVector(L"2026-02-19"));
  account = ComputeAccountBalance(sledger, accountName, from, to);

  accountStr = AccountToString(account);

  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)"), failures);
}
void TestAccruals(NumberReference *failures){
  Structure *ledger;
  FixedPoint15d *c, *d;
  vector<Line*> *transaction;
  bool valid, success;
  Date *date, *from, *to;
  Account *account;
  vector<wchar_t> *accountName, *desc, *accountStr, *accountSummaryStr;
  Ledger *sledger;
  vector<double> *amounts;
  double i;
  AccountDefinition *assetsDef, *liabilitiesDef, *equitiesDef, *incomeDef, *expensesDef, *accountDef;
  AccountDefinition *a148, *a150, *a192, *a290, *a300, *a600;
  AccountPlan *accountPlan;
  DataReference *balanceSheetRef;
  vector<wchar_t> *html;
  StringReference *message;
  Array *balances;

  ledger = CreateLedger(2.0);

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
  transaction = new vector<Line*> (2.0);
  date = DateFromStringISO8601(toVector(L"2025-09-17"));
  transaction->at(0) = CreateLineFromScript(ledger, toVector(L"Debit, 1.8.1, 125, x"), date);
  transaction->at(1) = CreateLineFromScript(ledger, toVector(L"Credit, 3.4.2, 125, x"), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction);
  AssertTrue(valid, failures);

  /* Transaction: Invoice paid */
  transaction = new vector<Line*> (2.0);
  date = DateFromStringISO8601(toVector(L"2025-10-01"));
  transaction->at(0) = CreateLineFromScript(ledger, toVector(L"Debit, 1.11.1, 125, x"), date);
  transaction->at(1) = CreateLineFromScript(ledger, toVector(L"Credit, 1.8.1, 125, x"), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction);
  AssertTrue(valid, failures);

  /* Transaction: Renewal paid */
  transaction = new vector<Line*> (2.0);
  date = DateFromStringISO8601(toVector(L"2025-11-08"));
  transaction->at(0) = CreateLineFromScript(ledger, toVector(L"Debit, 1.7.1, 112.50, x"), date);
  transaction->at(1) = CreateLineFromScript(ledger, toVector(L"Credit, 1.11.1, 112.50, x"), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction);
  AssertTrue(valid, failures);

  /* Accruals income */
  from = DateFromStringISO8601(toVector(L"2025-12-06"));
  to = DateFromStringISO8601(toVector(L"2026-12-05"));
  AddMonthlyAccruals(ledger, from, to, 125.0, toVector(L"3.4.2"), toVector(L"4.1.2"));

  /* Accruals cost */
  from = DateFromStringISO8601(toVector(L"2025-12-06"));
  to = DateFromStringISO8601(toVector(L"2026-12-05"));
  AddMonthlyAccruals(ledger, from, to, 112.50, toVector(L"5.1.3"), toVector(L"1.7.1"));

  /* Compute */
  sledger = LedgerDynamicToStatic(ledger);

  from = DateFromStringISO8601(toVector(L"2027-01-01"));
  to = DateFromStringISO8601(toVector(L"2027-01-01"));

  account = ComputeAccountBalance(sledger, toVector(L"5.1.3"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"4.1.2"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"1.8.1"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"3.4.2"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"1.11.1"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"1.7.1"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  /*System.out.println(""); */
  /* In between */
  from = DateFromStringISO8601(toVector(L"2026-06-15"));
  to = DateFromStringISO8601(toVector(L"2026-06-16"));

  account = ComputeAccountBalance(sledger, toVector(L"5.1.3"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"4.1.2"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"1.8.1"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"3.4.2"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"1.11.1"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, toVector(L"1.7.1"), from, to);
  accountStr = AccountToString(account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, toVector(L"1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)"), failures);

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

  sledger->accountPlan = GetIFRSAccountPlan();

  to = DateFromStringISO8601(toVector(L"2026-02-16"));
  balanceSheetRef = new DataReference();
  success = ComputeAccountBalances(sledger, 2.0, to, balanceSheetRef);
  accountSummaryStr = AccountBalancesToString(balanceSheetRef->data->structure);
  AssertTrue(success, failures);
  /*System.out.println(accountSummaryStr); */
  /* Compute monthly table */
  to = DateFromStringISO8601(toVector(L"2025-08-01"));
  message = new StringReference();
  AddDaysToDate(to,  -1.0, message);
  balances = CreateArray();
  for(i = 0.0; i < 12.0 + 6.0; i = i + 1.0){
    AddDaysToDate(to, 1.0, message);
    AddMonthsToDate(to, 1.0);
    AddDaysToDate(to,  -1.0, message);

    balanceSheetRef = new DataReference();
    success = ComputeAccountBalances(sledger, 1.0, to, balanceSheetRef);

    if(success){
      AddStructToArray(balances, balanceSheetRef->data->structure);
    }
  }
  ComputeBalanceDiffs(sledger, balances);

  html = BalancesArrayToHTML(balances, true, false);

  /*StringToFile("x.html", html); */
  html = BalancesArrayToHTML(balances, false, true);

  /*StringToFile("x-diff.html", html); */
  html = BalancesArrayToHTML(balances, true, true);
}
BooleanReference *CreateBooleanReference(bool value){
  BooleanReference *ref;

  ref = new BooleanReference();
  ref->booleanValue = value;

  return ref;
}
BooleanArrayReference *CreateBooleanArrayReference(vector<bool> *value){
  BooleanArrayReference *ref;

  ref = new BooleanArrayReference();
  ref->booleanArray = value;

  return ref;
}
BooleanArrayReference *CreateBooleanArrayReferenceLengthValue(double length, bool value){
  BooleanArrayReference *ref;
  double i;

  ref = new BooleanArrayReference();
  ref->booleanArray = new vector<bool> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    ref->booleanArray->at(i) = value;
  }

  return ref;
}
void FreeBooleanArrayReference(BooleanArrayReference *booleanArrayReference){
  delete booleanArrayReference->booleanArray;
  delete booleanArrayReference;
}
CharacterReference *CreateCharacterReference(wchar_t value){
  CharacterReference *ref;

  ref = new CharacterReference();
  ref->characterValue = value;

  return ref;
}
NumberReference *CreateNumberReference(double value){
  NumberReference *ref;

  ref = new NumberReference();
  ref->numberValue = value;

  return ref;
}
NumberArrayReference *CreateNumberArrayReference(vector<double> *value){
  NumberArrayReference *ref;

  ref = new NumberArrayReference();
  ref->numberArray = value;

  return ref;
}
NumberArrayReference *CreateNumberArrayReferenceLengthValue(double length, double value){
  NumberArrayReference *ref;
  double i;

  ref = new NumberArrayReference();
  ref->numberArray = new vector<double> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    ref->numberArray->at(i) = value;
  }

  return ref;
}
void FreeNumberArrayReference(NumberArrayReference *numberArrayReference){
  delete numberArrayReference->numberArray;
  delete numberArrayReference;
}
StringReference *CreateStringReference(vector<wchar_t> *value){
  StringReference *ref;

  ref = new StringReference();
  ref->string = value;

  return ref;
}
StringReference *CreateStringReferenceLengthValue(double length, wchar_t value){
  StringReference *ref;
  double i;

  ref = new StringReference();
  ref->string = new vector<wchar_t> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    ref->string->at(i) = value;
  }

  return ref;
}
void FreeStringReference(StringReference *stringReference){
  delete stringReference->string;
  delete stringReference;
}
StringArrayReference *CreateStringArrayReference(vector<StringReference*> *strings){
  StringArrayReference *ref;

  ref = new StringArrayReference();
  ref->stringArray = strings;

  return ref;
}
StringArrayReference *CreateStringArrayReferenceLengthValue(double length, vector<wchar_t> *value){
  StringArrayReference *ref;
  double i;

  ref = new StringArrayReference();
  ref->stringArray = new vector<StringReference*> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    ref->stringArray->at(i) = CreateStringReference(value);
  }

  return ref;
}
void FreeStringArrayReference(StringArrayReference *stringArrayReference){
  double i;

  for(i = 0.0; i < (double)stringArrayReference->stringArray->size(); i = i + 1.0){
    delete stringArrayReference->stringArray->at(i);
  }
  delete stringArrayReference->stringArray;
  delete stringArrayReference;
}
Date *CreateDate(double year, double month, double day){
  Date *date;

  date = new Date();

  date->year = year;
  date->month = month;
  date->day = day;

  return date;
}
bool IsLeapYearWithCheck(double year, BooleanReference *isLeapYearReference, StringReference *message){
  bool itIsLeapYear;
  bool success;

  if(year >= 1752.0){
    success = true;
    itIsLeapYear = IsLeapYear(year);
  }else{
    success = false;
    itIsLeapYear = false;
    message->string = toVector(L"Gregorian calendar was not in general use.");
  }

  isLeapYearReference->booleanValue = itIsLeapYear;
  return success;
}
bool IsLeapYear(double year){
  bool itIsLeapYear;

  if(DivisibleBy(year, 4.0)){
    if(DivisibleBy(year, 100.0)){
      if(DivisibleBy(year, 400.0)){
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
bool DayToDateWithCheck(double dayNr, DateReference *dateReference, StringReference *message){
  Date *date;
  NumberReference *remainder;
  bool success;

  if(dayNr >=  -79623.0){
    date = new Date();
    remainder = new NumberReference();
    remainder->numberValue = dayNr + 79623.0;
    /* Days since 1752-01-01. Day 0: Thursday, 1970-01-01 */
    /* Find year. */
    date->year = GetYearFromDayNr(remainder->numberValue, remainder);

    /* Find month. */
    date->month = GetMonthFromDayNr(remainder->numberValue, date->year, remainder);

    /* Find day. */
    date->day = 1.0 + remainder->numberValue;

    dateReference->date = date;
    success = true;
  }else{
    success = false;
    message->string = toVector(L"Gregorian calendar was not in general use before 1752.");
  }

  return success;
}
Date *DayToDate(double dayNr){
  Date *date;
  bool success;
  DateReference *dateRef;
  StringReference *message;

  dateRef = new DateReference();
  message = new StringReference();

  success = DayToDateWithCheck(dayNr, dateRef, message);
  if(success){
    date = dateRef->date;
    delete dateRef;
    FreeStringReference(message);
  }else{
    date = CreateDate(1970.0, 1.0, 1.0);
  }

  return date;
}
bool GetMonthFromDayNrWithCheck(double dayNr, double year, NumberReference *monthReference, NumberReference *remainderReference, StringReference *message){
  double month;
  bool success;

  if(dayNr >=  -79623.0){
    month = GetMonthFromDayNr(dayNr, year, remainderReference);
    monthReference->numberValue = month;
    success = true;
  }else{
    success = false;
    message->string = toVector(L"Gregorian calendar not in general use before 1752.");
  }

  return success;
}
double GetMonthFromDayNr(double dayNr, double year, NumberReference *remainderReference){
  vector<double> *daysInMonth;
  bool done;
  double month;

  daysInMonth = GetDaysInMonth(year);
  done = false;
  month = 1.0;

  for(;  !done ; ){
    if(dayNr >= daysInMonth->at(month)){
      dayNr = dayNr - daysInMonth->at(month);
      month = month + 1.0;
    }else{
      done = true;
    }
  }
  remainderReference->numberValue = dayNr;

  return month;
}
bool GetYearFromDayNrWithCheck(double dayNr, NumberReference *yearReference, NumberReference *remainder, StringReference *message){
  bool success;
  double year;

  if(dayNr >= 0.0){
    success = true;
    year = GetYearFromDayNr(dayNr, remainder);
    yearReference->numberValue = year;
  }else{
    success = false;
    message->string = toVector(L"Day number must be 0 or higher. 0 is 1752-01-01.");
  }

  return success;
}
double GetYearFromDayNr(double dayNr, NumberReference *remainder){
  double nrOfDays;
  bool done;
  double year;

  done = false;
  year = 1752.0;

  for(;  !done ; ){
    if(IsLeapYear(year)){
      nrOfDays = 366.0;
    }else{
      nrOfDays = 365.0;
    }

    if(dayNr >= nrOfDays){
      /* First day is 0. */
      dayNr = dayNr - nrOfDays;
      year = year + 1.0;
    }else{
      done = true;
    }
  }
  remainder->numberValue = dayNr;

  return year;
}
double DaysBetweenDates(Date *A, Date *B){
  double daysA, daysB, daysBetween;

  daysA = DateToDays(A);
  daysB = DateToDays(B);

  daysBetween = daysB - daysA;

  return daysBetween;
}
bool GetDaysInMonthWithCheck(double year, NumberArrayReference *daysInMonthReference, StringReference *message){
  vector<double> *daysInMonth;
  bool success;
  Date *date;

  date = CreateDate(year, 1.0, 1.0);

  success = IsValidDate(date, message);
  if(success){
    daysInMonth = GetDaysInMonth(year);

    daysInMonthReference->numberArray = daysInMonth;
  }

  return success;
}
vector<double> *GetDaysInMonth(double year){
  vector<double> *daysInMonth;

  daysInMonth = new vector<double> (1.0 + 12.0);

  daysInMonth->at(0) = 0.0;
  daysInMonth->at(1) = 31.0;

  if(IsLeapYear(year)){
    daysInMonth->at(2) = 29.0;
  }else{
    daysInMonth->at(2) = 28.0;
  }
  daysInMonth->at(3) = 31.0;
  daysInMonth->at(4) = 30.0;
  daysInMonth->at(5) = 31.0;
  daysInMonth->at(6) = 30.0;
  daysInMonth->at(7) = 31.0;
  daysInMonth->at(8) = 31.0;
  daysInMonth->at(9) = 30.0;
  daysInMonth->at(10) = 31.0;
  daysInMonth->at(11) = 30.0;
  daysInMonth->at(12) = 31.0;

  return daysInMonth;
}
bool DateToDaysWithCheck(Date *date, NumberReference *dayNumberReferenceReference, StringReference *message){
  double days;
  bool success;

  success = IsValidDate(date, message);
  if(success){
    days = DateToDays(date);
    dayNumberReferenceReference->numberValue = days;
  }

  return success;
}
double DateToDays(Date *date){
  double days;

  /* Day 1752-01-01 */
  days =  -79623.0;

  days = days + DaysInYears(date->year);
  days = days + DaysInMonths(date->month, date->year);
  days = days + date->day - 1.0;

  return days;
}
bool DateToWeekdayNumberWithCheck(Date *date, NumberReference *weekDayNumberReference, StringReference *message){
  double weekDay;
  bool success;

  success = IsValidDate(date, message);
  if(success){
    weekDay = DateToWeekdayNumber(date);
    weekDayNumberReference->numberValue = weekDay;
  }

  return success;
}
double DateToWeekdayNumber(Date *date){
  double days, weekDay;

  days = DateToDays(date);

  days = days + 79623.0;
  days = days + 5.0;

  weekDay = fmod(days, 7.0) + 1.0;

  return weekDay;
}
double DateToWeeknumber(Date *date, NumberReference *yearRef){
  double weekNumber, weekday, days, daysWeek1Start, weekdayNewYears;
  Date *week1Start, *newyears;

  week1Start = CopyDate(date);

  week1Start->day = 1.0;
  week1Start->month = 1.0;
  weekday = DateToWeekdayNumber(week1Start);

  /* Set week1Start to the start of the Week 1. */
  /* If monday, week 1 begins on Jan. 1st */
  if(weekday == 1.0){
    week1Start->day = 1.0;
  }
  /* If tuesday, week 1 begins on Dec. 31st */
  if(weekday == 2.0){
    week1Start->year = week1Start->year - 1.0;
    week1Start->month = 12.0;
    week1Start->day = 31.0;
  }
  /* If wednesday, week 1 begins on Dec. 30th */
  if(weekday == 3.0){
    week1Start->year = week1Start->year - 1.0;
    week1Start->month = 12.0;
    week1Start->day = 30.0;
  }
  /* If thursday, week 1 begins on Dec. 29th */
  if(weekday == 4.0){
    week1Start->year = week1Start->year - 1.0;
    week1Start->month = 12.0;
    week1Start->day = 29.0;
  }
  /* If friday, week 1 begins on Jan. 4th */
  if(weekday == 5.0){
    week1Start->day = 4.0;
  }
  /* If saturday, week 1 begins on Jan. 3rd */
  if(weekday == 6.0){
    week1Start->day = 3.0;
  }
  /* If sunday, week 1 begins on Jan. 2nd */
  if(weekday == 7.0){
    week1Start->day = 2.0;
  }

  days = DateToDays(date);
  daysWeek1Start = DateToDays(week1Start);

  if(days >= daysWeek1Start){
    weekNumber = 1.0 + floor((days - daysWeek1Start)/7.0);

    if(weekNumber >= 1.0 && weekNumber <= 52.0){
      /* Week is between 1 and 52 in the current year. */
      yearRef->numberValue = date->year;
    }else{
      /* Is week nr 53 or 1 next year? */
      newyears = CopyDate(date);
      newyears->month = 12.0;
      newyears->day = 31.0;
      weekdayNewYears = DateToWeekdayNumber(newyears);
      if(weekdayNewYears == 1.0 || weekdayNewYears == 2.0 || weekdayNewYears == 3.0){
        /* Week 1 next year. */
        weekNumber = 1.0;
        yearRef->numberValue = date->year + 1.0;
      }else{
        /* Week 53 */
        yearRef->numberValue = date->year;
      }
      delete newyears;
    }
  }else{
    /* Week is in previous year. Either 52nd or 53rd. */
    newyears = CopyDate(date);
    newyears->month = 12.0;
    newyears->day = 31.0;
    newyears->year = date->year - 1.0;
    weekNumber = DateToWeeknumber(newyears, yearRef);
    delete newyears;
  }

  delete week1Start;

  return weekNumber;
}
bool DaysInMonthsWithCheck(double month, double year, NumberReference *daysInMonthsReference, StringReference *message){
  double days;
  bool success;
  Date *date;

  date = CreateDate(year, month, 1.0);

  success = IsValidDate(date, message);
  if(success){
    days = DaysInMonths(month, year);

    daysInMonthsReference->numberValue = days;
  }

  return success;
}
double DaysInMonths(double month, double year){
  vector<double> *daysInMonth;
  double days;
  double i;

  daysInMonth = GetDaysInMonth(year);

  days = 0.0;
  for(i = 1.0; i < month; i = i + 1.0){
    days = days + daysInMonth->at(i);
  }

  return days;
}
bool DaysInYearsWithCheck(double years, NumberReference *daysReference, StringReference *message){
  double days;
  bool success;
  Date *date;

  date = CreateDate(years, 1.0, 1.0);

  success = IsValidDate(date, message);
  if(success){
    days = DaysInYears(years);
    daysReference->numberValue = days;
  }

  return success;
}
double DaysInYears(double years){
  double days;
  double i;
  double nrOfDays;

  days = 0.0;
  for(i = 1752.0; i < years; i = i + 1.0){
    if(IsLeapYear(i)){
      nrOfDays = 366.0;
    }else{
      nrOfDays = 365.0;
    }
    days = days + nrOfDays;
  }

  return days;
}
bool IsValidDate(Date *date, StringReference *message){
  bool valid;
  vector<double> *daysInMonth;
  double daysInThisMonth;

  if(date->year >= 1752.0){
    if(date->month >= 1.0 && date->month <= 12.0){
      daysInMonth = GetDaysInMonth(date->year);
      daysInThisMonth = daysInMonth->at(date->month);
      if(date->day >= 1.0 && date->day <= daysInThisMonth){
        valid = true;
      }else{
        valid = false;
        message->string = toVector(L"The month does not have the given day number.");
      }
    }else{
      valid = false;
      message->string = toVector(L"Month must be between 1 and 12, inclusive.");
    }
  }else{
    valid = false;
    message->string = toVector(L"Gregorian calendar was not in general use before 1752.");
  }

  return valid;
}
bool AddDaysToDate(Date *date, double days, StringReference *message){
  double n;
  bool success;
  DateReference *dateReference;
  NumberReference *daysRef;

  daysRef = new NumberReference();
  success = DateToDaysWithCheck(date, daysRef, message);

  if(success){
    n = daysRef->numberValue;
    n = n + days;

    dateReference = new DateReference();
    success = DayToDateWithCheck(n, dateReference, message);
    if(success){
      AssignDate(date, dateReference->date);
    }
  }

  return success;
}
void AssignDate(Date *a, Date *b){
  a->year = b->year;
  a->month = b->month;
  a->day = b->day;
}
void AddMonthsToDate(Date *date, double months){
  double i;

  if(months > 0.0){
    for(i = 0.0; i < months; i = i + 1.0){
      date->month = date->month + 1.0;

      if(date->month == 13.0){
        date->month = 1.0;
        date->year = date->year + 1.0;
      }
    }
  }
  if(months < 0.0){
    for(i = 0.0; i <  -months; i = i + 1.0){
      date->month = date->month - 1.0;

      if(date->month == 0.0){
        date->month = 12.0;
        date->year = date->year - 1.0;
      }
    }
  }
}
bool DateToStringISO8601WithCheck(Date *date, StringReference *datestr, StringReference *message){
  bool success;

  success = IsValidDate(date, message);

  if(success){
    if(date->year <= 9999.0){
      datestr->string = DateToStringISO8601(date);
    }else{
      message->string = toVector(L"This library works from 1752 to 9999.");
    }
  }

  return success;
}
vector<wchar_t> *DateToStringISO8601(Date *date){
  vector<wchar_t> *str;

  str = new vector<wchar_t> (10.0);

  str->at(0) = cDecimalDigitToCharacter(floor(date->year/1000.0));
  str->at(1) = cDecimalDigitToCharacter(floor((fmod(date->year, 1000.0))/100.0));
  str->at(2) = cDecimalDigitToCharacter(floor((fmod(date->year, 100.0))/10.0));
  str->at(3) = cDecimalDigitToCharacter(floor(fmod(date->year, 10.0)));

  str->at(4) = '-';

  str->at(5) = cDecimalDigitToCharacter(floor((fmod(date->month, 100.0))/10.0));
  str->at(6) = cDecimalDigitToCharacter(floor(fmod(date->month, 10.0)));

  str->at(7) = '-';

  str->at(8) = cDecimalDigitToCharacter(floor((fmod(date->day, 100.0))/10.0));
  str->at(9) = cDecimalDigitToCharacter(floor(fmod(date->day, 10.0)));

  return str;
}
Date *DateFromStringISO8601(vector<wchar_t> *str){
  Date *date;
  double n;

  date = new Date();

  n = cCharacterToDecimalDigit(str->at(0))*1000.0;
  n = n + cCharacterToDecimalDigit(str->at(1))*100.0;
  n = n + cCharacterToDecimalDigit(str->at(2))*10.0;
  n = n + cCharacterToDecimalDigit(str->at(3))*1.0;

  date->year = n;

  n = cCharacterToDecimalDigit(str->at(5))*10.0;
  n = n + cCharacterToDecimalDigit(str->at(6))*1.0;

  date->month = n;

  n = cCharacterToDecimalDigit(str->at(8))*10.0;
  n = n + cCharacterToDecimalDigit(str->at(9))*1.0;

  date->day = n;

  return date;
}
bool DateFromStringISO8601WithCheck(vector<wchar_t> *str, DateReference *dateRef, StringReference *message){
  bool valid;

  valid = IsValidDateISO8601(str, message);

  if(valid){
    dateRef->date = DateFromStringISO8601(str);
  }

  return valid;
}
bool IsValidDateISO8601(vector<wchar_t> *str, StringReference *message){
  bool valid;

  if((double)str->size() == 4.0 + 1.0 + 2.0 + 1.0 + 2.0){

    if(cIsNumber(str->at(0)) && cIsNumber(str->at(1)) && cIsNumber(str->at(2)) && cIsNumber(str->at(3)) && cIsNumber(str->at(5)) && cIsNumber(str->at(6)) && cIsNumber(str->at(8)) && cIsNumber(str->at(9))){
      if(str->at(4) == '-' && str->at(7) == '-'){
        valid = true;
      }else{
        valid = false;
        message->string = toVector(L"ISO8601 date must use \'-\' in positions 5 and 8.");
      }
    }else{
      valid = false;
      message->string = toVector(L"ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.");
    }
  }else{
    valid = false;
    message->string = toVector(L"ISO8601 date must be exactly 10 characters long.");
  }

  return valid;
}
bool DateEquals(Date *a, Date *b){
  return a->year == b->year && a->month == b->month && a->day == b->day;
}
Date *CopyDate(Date *a){
  Date *b;

  b = CreateDate(a->year, a->month, a->day);

  return b;
}
double GetSecondsFromDate(Date *date){
  double seconds, days, secondsInMinute, secondsInHour, secondsInDay;
  NumberReference *dayNumberReferenceReference;
  StringReference *message;
  bool success;

  seconds = 0.0;
  dayNumberReferenceReference = new NumberReference();
  message = new StringReference();

  success = DateToDaysWithCheck(date, dayNumberReferenceReference, message);
  if(success){
    days = dayNumberReferenceReference->numberValue;

    secondsInMinute = 60.0;
    secondsInHour = 60.0*secondsInMinute;
    secondsInDay = 24.0*secondsInHour;

    seconds = seconds + secondsInDay*days;
  }

  delete dayNumberReferenceReference;
  delete message;

  return seconds;
}
bool DateIsInInterval(Interval *interval, Date *date){
  double from, to, day;

  from = DateToDays(interval->first);
  to = DateToDays(interval->last);
  day = DateToDays(date);

  return day >= from && day <= to;
}
bool DateLessThan(Date *a, Date *b){
  double aDays, bDays;

  aDays = DateToDays(a);
  bDays = DateToDays(b);

  return aDays < bDays;
}
DateTimeTimezone *CreateDateTimeTimezone(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetSeconds){
  DateTimeTimezone *dateTimeTimezone;

  dateTimeTimezone = new DateTimeTimezone();

  dateTimeTimezone->dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
  dateTimeTimezone->timezoneOffsetSeconds = timezoneOffsetSeconds;

  return dateTimeTimezone;
}
DateTimeTimezone *CreateDateTimeTimezoneInHoursAndMinutes(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetHours, double timezoneOffsetMinutes){
  DateTimeTimezone *dateTimeTimezone;

  dateTimeTimezone = new DateTimeTimezone();

  dateTimeTimezone->dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
  dateTimeTimezone->timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes);

  return dateTimeTimezone;
}
bool GetDateFromDateTimeTimeZone(DateTimeTimezone *dateTimeTimezone, DateTimeReference *dateTimeReference, StringReference *message){
  DateTime *dateTime;

  dateTime = dateTimeTimezone->dateTime;

  return AddSecondsToDateTimeWithCheck(dateTime,  -dateTimeTimezone->timezoneOffsetSeconds, dateTimeReference, message);
}
bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(DateTime *dateTime, double timezoneOffsetSeconds, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message){
  bool success;
  DateTimeReference *adjustedDateTimeReference;
  DateTimeTimezone *dateTimeTimezone;

  adjustedDateTimeReference = new DateTimeReference();
  dateTimeTimezone = new DateTimeTimezone();

  success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message);

  if(success){
    dateTimeTimezone->dateTime = adjustedDateTimeReference->dateTime;
    dateTimeTimezone->timezoneOffsetSeconds = timezoneOffsetSeconds;

    dateTimeTimezoneReference->dateTimeTimezone = dateTimeTimezone;
  }

  return success;
}
bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(DateTime *dateTime, double timezoneOffsetHours, double timezoneOffsetMinutes, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message){
  return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message);
}
bool GetDateTimeTimezoneFromSeconds(DateTimeTimezoneReference *dateTimeTzRef, double seconds, double offset, StringReference *message){
  bool success;
  DateTimeReference *dateTimeRef;

  dateTimeRef = new DateTimeReference();
  success = GetDateTimeFromSeconds(seconds, dateTimeRef, message);

  if(success){
    success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef->dateTime, offset, dateTimeTzRef, message);
  }

  return success;
}
DateTime *CreateDateTime(double year, double month, double day, double hours, double minutes, double seconds){
  DateTime *dateTime;

  dateTime = new DateTime();

  dateTime->date = CreateDate(year, month, day);
  dateTime->hours = hours;
  dateTime->minutes = minutes;
  dateTime->seconds = seconds;

  return dateTime;
}
bool GetDateTimeFromSeconds(double seconds, DateTimeReference *dateTimeReference, StringReference *message){
  DateTime *dateTime;
  double secondsInMinute, secondsInHour, secondsInDay, days, remainder;
  Date *date;
  DateReference *dateReference;
  bool success;

  secondsInMinute = 60.0;
  secondsInHour = 60.0*secondsInMinute;
  secondsInDay = 24.0*secondsInHour;
  days = floor(seconds/secondsInDay);
  remainder = seconds - days*secondsInDay;
  dateReference = new DateReference();

  success = DayToDateWithCheck(days, dateReference, message);
  if(success){
    date = dateReference->date;

    dateTime = new DateTime();
    dateTime->date = date;
    dateTime->hours = floor(remainder/secondsInHour);
    remainder = remainder - dateTime->hours*secondsInHour;
    dateTime->minutes = floor(remainder/secondsInMinute);
    remainder = remainder - dateTime->minutes*secondsInMinute;
    dateTime->seconds = remainder;

    dateTimeReference->dateTime = dateTime;
  }

  return success;
}
double GetSecondsFromDateTime(DateTime *dateTime){
  double seconds, secondsInMinute, secondsInHour;

  secondsInMinute = 60.0;
  secondsInHour = 60.0*secondsInMinute;

  seconds = GetSecondsFromDate(dateTime->date);
  seconds = seconds + secondsInHour*dateTime->hours;
  seconds = seconds + secondsInMinute*dateTime->minutes;
  seconds = seconds + dateTime->seconds;

  return seconds;
}
double GetSecondsFromMinutes(double minutes){
  return minutes*60.0;
}
double GetSecondsFromHours(double hours){
  return GetSecondsFromMinutes(hours*60.0);
}
double GetSecondsFromDays(double days){
  return GetSecondsFromHours(days*24.0);
}
double GetSecondsFromWeeks(double weeks){
  return GetSecondsFromDays(weeks*7.0);
}
double GetMinutesFromSeconds(double seconds){
  return seconds/60.0;
}
double GetHoursFromSeconds(double seconds){
  return GetMinutesFromSeconds(seconds)/60.0;
}
double GetDaysFromSeconds(double seconds){
  return GetHoursFromSeconds(seconds)/24.0;
}
double GetWeeksFromSeconds(double seconds){
  return GetDaysFromSeconds(seconds)/7.0;
}
Date *GetDateFromDateTime(DateTime *dateTime){
  return dateTime->date;
}
bool AddSecondsToDateTimeWithCheck(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message){
  double secondsInDateTime;
  bool success;

  if(IsValidDateTime(dateTime, message)){
    secondsInDateTime = GetSecondsFromDateTime(dateTime);
    secondsInDateTime = secondsInDateTime + seconds;

    success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
  }else{
    success = false;
  }

  return success;
}
bool AddSecondsToDateTime(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message){
  double secondsInDateTime;

  secondsInDateTime = GetSecondsFromDateTime(dateTime);
  secondsInDateTime = secondsInDateTime + seconds;

  return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
}
bool AddMinutesToDateTime(DateTime *dateTime, double minutes, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message);
}
bool AddHoursToDateTime(DateTime *dateTime, double hours, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message);
}
bool AddDaysToDateTime(DateTime *dateTime, double days, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message);
}
bool AddWeeksToDateTime(DateTime *dateTime, double weeks, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message);
}
bool DateTimeToStringISO8601WithCheck(DateTime *datetime, StringReference *dateStr, StringReference *message){
  bool success;

  success = DateToStringISO8601WithCheck(datetime->date, dateStr, message);

  if(success){
    delete dateStr->string;

    success = IsValidDateTime(datetime, message);
    if(success){
      dateStr->string = DateTimeToStringISO8601(datetime);
    }
  }

  return success;
}
bool IsValidDateTime(DateTime *datetime, StringReference *message){
  bool success;

  success = IsValidDate(datetime->date, message);

  if(success){
    if(datetime->hours <= 23.0 && datetime->hours >= 0.0){
      if(datetime->minutes <= 59.0 && datetime->minutes >= 0.0){
        if(datetime->seconds <= 59.0 && datetime->seconds >= 0.0){
          success = true;
        }else{
          success = false;
          message->string = toVector(L"Seconds must be between 0 and 59.");
        }
      }else{
        success = false;
        message->string = toVector(L"Minutes must be between 0 and 59.");
      }
    }else{
      success = false;
      message->string = toVector(L"Hours must be between 0 and 23.");
    }
  }

  return success;
}
vector<wchar_t> *DateTimeToStringISO8601(DateTime *datetime){
  vector<wchar_t> *datestr, *str;
  double i;

  str = new vector<wchar_t> (19.0);

  datestr = DateToStringISO8601(datetime->date);
  for(i = 0.0; i < (double)datestr->size(); i = i + 1.0){
    str->at(i) = datestr->at(i);
  }

  str->at(10) = 'T';
  str->at(11) = cDecimalDigitToCharacter(floor((fmod(datetime->hours, 100.0))/10.0));
  str->at(12) = cDecimalDigitToCharacter(floor(fmod(datetime->hours, 10.0)));

  str->at(13) = ':';

  str->at(14) = cDecimalDigitToCharacter(floor((fmod(datetime->minutes, 100.0))/10.0));
  str->at(15) = cDecimalDigitToCharacter(floor(fmod(datetime->minutes, 10.0)));

  str->at(16) = ':';

  str->at(17) = cDecimalDigitToCharacter(floor((fmod(datetime->seconds, 100.0))/10.0));
  str->at(18) = cDecimalDigitToCharacter(floor(fmod(datetime->seconds, 10.0)));

  return str;
}
DateTime *DateTimeFromStringISO8601(vector<wchar_t> *str){
  DateTime *dateTime;
  double n;

  dateTime = new DateTime();

  dateTime->date = DateFromStringISO8601(str);

  n = cCharacterToDecimalDigit(str->at(11))*10.0;
  n = n + cCharacterToDecimalDigit(str->at(12))*1.0;

  dateTime->hours = n;

  n = cCharacterToDecimalDigit(str->at(14))*10.0;
  n = n + cCharacterToDecimalDigit(str->at(15))*1.0;

  dateTime->minutes = n;

  n = cCharacterToDecimalDigit(str->at(17))*10.0;
  n = n + cCharacterToDecimalDigit(str->at(18))*1.0;

  dateTime->seconds = n;

  return dateTime;
}
bool DateTimeFromStringISO8601WithCheck(vector<wchar_t> *str, DateTimeReference *dateTimeRef, StringReference *message){
  bool valid;

  valid = IsValidDateTimeISO8601(str, message);

  if(valid){
    dateTimeRef->dateTime = DateTimeFromStringISO8601(str);
  }

  return valid;
}
bool IsValidDateTimeISO8601(vector<wchar_t> *str, StringReference *message){
  bool valid;

  if((double)str->size() == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0){

    if(cIsNumber(str->at(0)) && cIsNumber(str->at(1)) && cIsNumber(str->at(2)) && cIsNumber(str->at(3)) && cIsNumber(str->at(5)) && cIsNumber(str->at(6)) && cIsNumber(str->at(8)) && cIsNumber(str->at(9)) && cIsNumber(str->at(11)) && cIsNumber(str->at(12)) && cIsNumber(str->at(14)) && cIsNumber(str->at(15)) && cIsNumber(str->at(17)) && cIsNumber(str->at(18))){
      if(str->at(4) == '-' && str->at(7) == '-' && str->at(10) == 'T' && str->at(13) == ':' && str->at(16) == ':'){
        valid = true;
      }else{
        valid = false;
        message->string = toVector(L"ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.");
      }
    }else{
      valid = false;
      message->string = toVector(L"ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.");
    }
  }else{
    valid = false;
    message->string = toVector(L"ISO8601 date must be exactly 19 characters long.");
  }

  return valid;
}
bool DateTimeEquals(DateTime *a, DateTime *b){
  return DateEquals(a->date, b->date) && a->hours == b->hours && a->minutes == b->minutes && a->seconds == b->seconds;
}
void FreeDateTime(DateTime *datetime){
  delete datetime->date;
  delete datetime;
}
FixedPoint30d *CreateFixedPoint30d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
  FixedPoint30d *fp;

  fp = new FixedPoint30d();
  fp->digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
  fp->digitsAfterDecimalPoint = digitsAfterDecimalPoint;
  fp->part1 = 0.0;
  fp->part2 = 0.0;

  return fp;
}
FixedPoint15d *CreateFixedPoint15d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
  FixedPoint15d *fp;

  fp = new FixedPoint15d();
  fp->digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
  fp->digitsAfterDecimalPoint = digitsAfterDecimalPoint;
  fp->number = 0.0;

  return fp;
}
double ToNumber15d(FixedPoint15d *n){
  return n->number;
}
FixedPoint15d *Number15d(double number){
  FixedPoint15d *fp;

  fp = new FixedPoint15d();
  fp->digitsBeforeDecimalPoint = 7.0;
  fp->digitsAfterDecimalPoint = 7.0;
  fp->number = number;

  return fp;
}
bool Assign15d(FixedPoint15d *fp, double number){
  bool success;

  success =  !WillOverflow15d(fp, number) ;
  success = success && FixedPointIsValid15d(fp);

  if(success){
    fp->number = number;
    fp->number = RoundToDigits(fp->number, fp->digitsAfterDecimalPoint);
  }

  return success;
}
bool Assign15dFloor(FixedPoint15d *fp, double number){
  bool success;

  success =  !WillOverflow15d(fp, number) ;
  success = success && FixedPointIsValid15d(fp);

  if(success){
    fp->number = number;
    fp->number = FloorToDigits(fp->number, fp->digitsAfterDecimalPoint);
  }

  return success;
}
bool FixedPointIsValid15d(FixedPoint15d *fp){
  bool valid;

  if(IsInteger(fp->digitsAfterDecimalPoint) && IsInteger(fp->digitsBeforeDecimalPoint)){
    if(fp->digitsBeforeDecimalPoint >= 0.0 && fp->digitsBeforeDecimalPoint <= 15.0){
      if(fp->digitsAfterDecimalPoint >= 0.0 && fp->digitsAfterDecimalPoint <= 15.0){
        if(fp->digitsBeforeDecimalPoint + fp->digitsAfterDecimalPoint <= 15.0){
          if(fp->digitsBeforeDecimalPoint + fp->digitsAfterDecimalPoint > 0.0){
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
bool WillOverflow15d(FixedPoint15d *fp, double number){
  bool overflow;

  if(abs(number) < pow(10.0, fp->digitsBeforeDecimalPoint)){
    overflow = false;
  }else{
    overflow = true;
  }

  return overflow;
}
double FloorToDigits(double value, double digits){
  return floor(value*pow(10.0, digits))/pow(10.0, digits);
}
vector<wchar_t> *ToString15d(FixedPoint15d *fp){
  vector<wchar_t> *string;
  double digits;
  double digitPosition;
  double i, d, decimal;
  CharacterReference *characterReference;

  string = new vector<wchar_t> (1.0 + fp->digitsBeforeDecimalPoint + 1.0 + fp->digitsAfterDecimalPoint);

  decimal = fp->number*pow(10.0, fp->digitsAfterDecimalPoint);

  if(decimal < 0.0){
    decimal =  -decimal;
    string->at(0) = '-';
  }else{
    string->at(0) = '+';
  }

  decimal = Round(decimal);

  characterReference = new CharacterReference();

  digits = fp->digitsBeforeDecimalPoint + fp->digitsAfterDecimalPoint;
  digitPosition = 1.0;

  for(i = 0.0; i < digits; i = i + 1.0){
    if(i == fp->digitsBeforeDecimalPoint){
      string->at(digitPosition) = '.';

      digitPosition = digitPosition + 1.0;
    }

    d = floor(decimal/pow(10.0, digits - i - 1.0));
    d = fmod(d, 10.0);

    GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference);
    string->at(digitPosition) = characterReference->characterValue;

    digitPosition = digitPosition + 1.0;
  }

  delete characterReference;

  return string;
}
bool Add15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c){
  return Assign15d(a, b->number + c->number);
}
bool Subtract15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c){
  return Assign15d(a, b->number - c->number);
}
bool Multiply15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c){
  return Assign15d(a, b->number*c->number);
}
bool DivideFloored15d(FixedPoint15d *q, FixedPoint15d *r, FixedPoint15d *a, FixedPoint15d *b){
  bool success;
  double x, xDivisor, xDividend;
  FixedPoint15d *t;

  t = Copy15d(r);

  if(b->number != 0.0){
    xDivisor = Round(a->number*pow(10.0, q->digitsAfterDecimalPoint)*pow(10.0, q->digitsAfterDecimalPoint));
    xDividend = Round(b->number*pow(10.0, q->digitsAfterDecimalPoint));
    x = floor(xDivisor/xDividend);
    x = x/pow(10.0, q->digitsAfterDecimalPoint);
    success = Assign15d(q, x);
    Multiply15d(t, q, b);
    Subtract15d(r, a, t);
  }else{
    success = false;
  }

  delete t;

  return success;
}
FixedPoint15d *Copy15d(FixedPoint15d *r){
  FixedPoint15d *t;

  t = CreateFixedPoint15d(r->digitsBeforeDecimalPoint, r->digitsAfterDecimalPoint);
  t->number = r->number;

  return t;
}
void Negate15d(FixedPoint15d *a){
  a->number =  -a->number;
}
void Positive15d(FixedPoint15d *a){
  a->number =  +a->number;
}
bool Factorial15d(FixedPoint15d *x){
  bool success;

  if(x->number >= 0.0){
    success = Assign15d(x, Factorial(x->number));
  }else{
    success = false;
  }

  return success;
}
bool Round15d(FixedPoint15d *x){
  return Assign15d(x, Round(x->number));
}
bool BankersRound15d(FixedPoint15d *x){
  return Assign15d(x, BankersRound(x->number));
}
bool Ceil15d(FixedPoint15d *x){
  return Assign15d(x, Ceil(x->number));
}
bool Floor15d(FixedPoint15d *x){
  return Assign15d(x, floor(x->number));
}
void Truncate15d(FixedPoint15d *x){
  x->number = Truncate(x->number);
}
void Absolute15d(FixedPoint15d *x){
  x->number = abs(x->number);
}
bool Logarithm15d(FixedPoint15d *x){
  bool success;

  if(x->number > 0.0){
    success = Assign15d(x, Logarithm(x->number));
  }else{
    success = false;
  }

  return success;
}
bool NaturalLogarithm15d(FixedPoint15d *x){
  bool success;

  if(x->number > 0.0){
    success = Assign15d(x, NaturalLogarithm(x->number));
  }else{
    success = false;
  }

  return success;
}
bool Sin15d(FixedPoint15d *x){
  return Assign15d(x, Sin(x->number));
}
bool Cos15d(FixedPoint15d *x){
  return Assign15d(x, Cos(x->number));
}
bool Tan15d(FixedPoint15d *x){
  return Assign15d(x, Tan(x->number));
}
bool Asin15d(FixedPoint15d *x){
  bool success;

  if(x->number >=  -1.0 && x->number <= 1.0){
    success = Assign15d(x, Asin(x->number));
  }else{
    success = false;
  }

  return success;
}
bool Acos15d(FixedPoint15d *x){
  bool success;

  if(x->number >=  -1.0 && x->number <= 1.0){
    success = Assign15d(x, Acos(x->number));
  }else{
    success = false;
  }

  return success;
}
bool Atan15d(FixedPoint15d *x){
  return Assign15d(x, Atan(x->number));
}
bool Atan2_15d(FixedPoint15d *a, FixedPoint15d *y, FixedPoint15d *x){
  return Assign15d(a, Atan2(y->number, x->number));
}
bool Squareroot15d(FixedPoint15d *x){
  bool success;

  if(x->number >= 0.0){
    success = Assign15d(x, sqrt(x->number));
  }else{
    success = false;
  }

  return success;
}
bool Exp15d(FixedPoint15d *x){
  return Assign15d(x, Exp(x->number));
}
bool DivisibleBy15d(FixedPoint15d *a, FixedPoint15d *b){
  return ((fmod(a->number, b->number)) == 0.0);
}
bool Combinations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k){
  bool success;

  if(IsInteger(n->number) && IsInteger(k->number)){
    if(n->number >= 1.0 && k->number >= 0.0 && n->number >= k->number){
      success = Assign15d(x, Combinations(n->number, k->number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
bool Permutations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k){
  bool success;

  if(IsInteger(n->number) && IsInteger(k->number)){
    if(n->number >= 1.0 && k->number >= 0.0 && n->number >= k->number){
      success = Assign15d(x, Permutations(n->number, k->number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
bool Equals15d(FixedPoint15d *a, FixedPoint15d *b){
  double p, an, bn;
  bool equals;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  p = fmax(a->digitsAfterDecimalPoint, b->digitsAfterDecimalPoint);

  equals = EpsilonCompare(an, bn, pow(10.0,  -p));

  return equals;
}
bool GreaterThan15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  return an > bn;
}
bool LessThan15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  return an < bn;
}
bool GreaterThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;
  bool equal;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  equal = Equals15d(a, b);

  return an > bn || equal;
}
bool LessThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;
  bool equal;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  equal = Equals15d(a, b);

  return an < bn || equal;
}
bool EpsilonCompare15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *epsilon){
  return EpsilonCompare(a->number, b->number, epsilon->number);
}
bool GreatestCommonDivisor15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  bool success;

  if(IsInteger(a->number) && IsInteger(b->number)){
    if(a->number >= 0.0 && b->number >= 0.0){
      success = Assign15d(x, GreatestCommonDivisor(a->number, b->number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
bool GCDWithSubtraction15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  bool success;

  if(IsInteger(a->number) && IsInteger(b->number)){
    if(a->number >= 0.0 && b->number >= 0.0){
      success = Assign15d(x, GCDWithSubtraction(a->number, b->number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
bool IsInteger15d(FixedPoint15d *a){
  return IsInteger(a->number);
}
bool LeastCommonMultiple15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  bool success;

  if(IsInteger(a->number) && IsInteger(b->number)){
    if(a->number != 0.0 && b->number != 0.0){
      success = Assign15d(x, LeastCommonMultiple(a->number, b->number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
double Sign15d(FixedPoint15d *a){
  return Sign(a->number);
}
bool Max15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  return Assign15d(x, Max(a->number, b->number));
}
bool Min15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  return Assign15d(x, Min(a->number, b->number));
}
bool Power15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  bool success;

  if(a->number != 0.0 || b->number != 0.0){
    if( !(a->number < 0.0 &&  !IsInteger(b->number) ) ){
      success = Assign15d(x, Power(a->number, b->number));
    }else{
      success = false;
    }
  }else{
    success = false;
  }

  return success;
}
vector<wchar_t> *FormatToString15d(FixedPoint15d *fp, double digitsAfter){
  vector<wchar_t> *result;

  result = FormatToStringWithSymbols15d(fp, digitsAfter, toVector(L""), toVector(L"."));

  return result;
}
vector<wchar_t> *FormatToStringWithSymbols15d(FixedPoint15d *fp, double digitsAfter, vector<wchar_t> *thousandsSeparator, vector<wchar_t> *decimalPoint){
  vector<wchar_t> *string;
  double i, j, p, d, t, sign, extra, decimal, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars;
  CharacterReference *characterReference;

  characterReference = new CharacterReference();

  decimal = Round(fp->number*pow(10.0, digitsAfter));

  sign = 0.0;
  if(decimal < 0.0){
    sign = 1.0;
    decimal =  -decimal;
  }

  if(decimal != 0.0){
    digits = floor(log10(decimal) + 1.0);
  }else{
    digits = 1.0;
  }
  digitsBefore = digits - digitsAfter;

  if(digitsBefore <= 0.0){
    digitsBefore = 0.0;
    thousandsTimes = 0.0;
    digits = digitsAfter + 1.0;
  }else{
    thousandsTimes = floor((digitsBefore - 1.0)/3.0);
  }
  thousandsChars = thousandsTimes*(double)thousandsSeparator->size();

  if(digitsAfter == 0.0){
    decimalPointChars = 0.0;
  }else{
    decimalPointChars = (double)decimalPoint->size();
  }

  string = new vector<wchar_t> (sign + digits + thousandsChars + decimalPointChars);
  p = 0.0;

  if(sign > 0.0){
    string->at(p) = '-';
    p = p + 1.0;
  }

  for(i = 0.0; i < digits; i = i + 1.0){
    if(i == digitsBefore){
      if(i == 0.0){
        string->at(p) = '0';
        p = p + 1.0;
        digits = digits - 1.0;
      }

      for(j = 0.0; j < (double)decimalPoint->size(); j = j + 1.0){
        string->at(p) = decimalPoint->at(j);
        p = p + 1.0;
      }
    }

    if(i < digitsBefore){
      if(fmod(digitsBefore - i, 3.0) == 0.0 && i != 0.0){
        for(j = 0.0; j < (double)thousandsSeparator->size(); j = j + 1.0){
          string->at(p) = thousandsSeparator->at(j);
          p = p + 1.0;
        }
      }
    }

    d = floor(decimal/pow(10.0, digits - i - 1.0));
    d = fmod(d, 10.0);

    GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference);
    string->at(p) = characterReference->characterValue;

    p = p + 1.0;
  }

  /* System.out.println(new String(string)); */
  return string;
}
vector<wchar_t> *NumberToHumanReadable(double n, double digitsAfter, vector<wchar_t> *thousandsSeparator, vector<wchar_t> *decimalPoint){
  vector<wchar_t> *str;
  wchar_t u;
  double d, p3;

  if(abs(n) < 1.0){
    str = CreateStringDecimalFromNumber(n);
  }else{
    d = log10(n);

    p3 = fmin(floor(d/3.0), 8.0);

    if(p3 == 0.0){
      u = 'B';
    }else if(p3 == 1.0){
      u = 'K';
    }else if(p3 == 2.0){
      u = 'M';
    }else if(p3 == 3.0){
      u = 'G';
    }else if(p3 == 4.0){
      u = 'T';
    }else if(p3 == 5.0){
      u = 'P';
    }else if(p3 == 6.0){
      u = 'E';
    }else if(p3 == 7.0){
      u = 'Z';
    }else{
      u = 'Y';
    }

    if(p3 > 1.0){
      n = n/pow(10.0, p3*3.0);
    }

    str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

    if(p3 > 1.0){
      str = strAppendCharacter(str, u);
    }
  }

  return str;
}
vector<wchar_t> *NumberToHumanReadableBinaryPrefix(double n, double digitsAfter, vector<wchar_t> *thousandsSeparator, vector<wchar_t> *decimalPoint){
  vector<wchar_t> *str;
  vector<wchar_t> *u;
  double d, p3;

  if(abs(n) < 1.0){
    str = CreateStringDecimalFromNumber(n);
  }else{
    d = floor(log(n)/log(2.0)) + 1.0;

    p3 = fmin(floor(d/10.0), 8.0);

    if(p3 == 0.0){
      u = toVector(L"B");
    }else if(p3 == 1.0){
      u = toVector(L"Ki");
    }else if(p3 == 2.0){
      u = toVector(L"Mi");
    }else if(p3 == 3.0){
      u = toVector(L"Gi");
    }else if(p3 == 4.0){
      u = toVector(L"Ti");
    }else if(p3 == 5.0){
      u = toVector(L"Pi");
    }else if(p3 == 6.0){
      u = toVector(L"Ei");
    }else if(p3 == 7.0){
      u = toVector(L"Zi");
    }else{
      u = toVector(L"Yi");
    }

    if(p3 > 1.0){
      n = n/pow(2.0, p3*10.0);
    }

    str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

    if(p3 > 1.0){
      str = strAppendString(str, u);
    }
  }

  return str;
}
vector<double> *AddNumber(vector<double> *list, double a){
  vector<double> *newlist;
  double i;

  newlist = new vector<double> ((double)list->size() + 1.0);
  for(i = 0.0; i < (double)list->size(); i = i + 1.0){
    newlist->at(i) = list->at(i);
  }
  newlist->at((double)list->size()) = a;
		
  delete list;
		
  return newlist;
}
void AddNumberRef(NumberArrayReference *list, double i){
  list->numberArray = AddNumber(list->numberArray, i);
}
vector<double> *RemoveNumber(vector<double> *list, double n){
  vector<double> *newlist;
  double i;

  newlist = new vector<double> ((double)list->size() - 1.0);

  if(n >= 0.0 && n < (double)list->size()){
    for(i = 0.0; i < (double)list->size(); i = i + 1.0){
      if(i < n){
        newlist->at(i) = list->at(i);
      }
      if(i > n){
        newlist->at(i - 1.0) = list->at(i);
      }
    }

    delete list;
  }else{
    delete newlist;
  }
		
  return newlist;
}
double GetNumberRef(NumberArrayReference *list, double i){
  return list->numberArray->at(i);
}
void RemoveNumberRef(NumberArrayReference *list, double i){
  list->numberArray = RemoveNumber(list->numberArray, i);
}
vector<StringReference*> *AddString(vector<StringReference*> *list, StringReference *a){
  vector<StringReference*> *newlist;
  double i;

  newlist = new vector<StringReference*> ((double)list->size() + 1.0);

  for(i = 0.0; i < (double)list->size(); i = i + 1.0){
    newlist->at(i) = list->at(i);
  }
  newlist->at((double)list->size()) = a;
		
  delete list;
		
  return newlist;
}
void AddStringRef(StringArrayReference *list, StringReference *i){
  list->stringArray = AddString(list->stringArray, i);
}
vector<StringReference*> *RemoveString(vector<StringReference*> *list, double n){
  vector<StringReference*> *newlist;
  double i;

  newlist = new vector<StringReference*> ((double)list->size() - 1.0);

  if(n >= 0.0 && n < (double)list->size()){
    for(i = 0.0; i < (double)list->size(); i = i + 1.0){
      if(i < n){
        newlist->at(i) = list->at(i);
      }
      if(i > n){
        newlist->at(i - 1.0) = list->at(i);
      }
    }

    delete list;
  }else{
    delete newlist;
  }
		
  return newlist;
}
StringReference *GetStringRef(StringArrayReference *list, double i){
  return list->stringArray->at(i);
}
void RemoveStringRef(StringArrayReference *list, double i){
  list->stringArray = RemoveString(list->stringArray, i);
}
DynamicArrayCharacters *CreateDynamicArrayCharacters(){
  DynamicArrayCharacters *da;

  da = new DynamicArrayCharacters();
  da->array = new vector<wchar_t> (10.0);
  da->length = 0.0;

  return da;
}
DynamicArrayCharacters *CreateDynamicArrayCharactersWithInitialCapacity(double capacity){
  DynamicArrayCharacters *da;

  da = new DynamicArrayCharacters();
  da->array = new vector<wchar_t> (capacity);
  da->length = 0.0;

  return da;
}
void DynamicArrayAddCharacter(DynamicArrayCharacters *da, wchar_t value){
  if(da->length == (double)da->array->size()){
    DynamicArrayCharactersIncreaseSize(da);
  }

  da->array->at(da->length) = value;
  da->length = da->length + 1.0;
}
void DynamicArrayAddString(DynamicArrayCharacters *da, vector<wchar_t> *str){
  double i;

  for(i = 0.0; i < (double)str->size(); i = i + 1.0){
    DynamicArrayAddCharacter(da, str->at(i));
  }
}
void DynamicArrayCharactersIncreaseSize(DynamicArrayCharacters *da){
  double newLength, i;
  vector<wchar_t> *newArray;

  newLength = round((double)da->array->size()*3.0/2.0);
  newArray = new vector<wchar_t> (newLength);

  for(i = 0.0; i < (double)da->array->size(); i = i + 1.0){
    newArray->at(i) = da->array->at(i);
  }

  delete da->array;

  da->array = newArray;
}
bool DynamicArrayCharactersDecreaseSizeNecessary(DynamicArrayCharacters *da){
  bool needsDecrease;

  needsDecrease = false;

  if(da->length > 10.0){
    needsDecrease = da->length <= round((double)da->array->size()*2.0/3.0);
  }

  return needsDecrease;
}
void DynamicArrayCharactersDecreaseSize(DynamicArrayCharacters *da){
  double newLength, i;
  vector<wchar_t> *newArray;

  newLength = round((double)da->array->size()*2.0/3.0);
  newArray = new vector<wchar_t> (newLength);

  for(i = 0.0; i < newLength; i = i + 1.0){
    newArray->at(i) = da->array->at(i);
  }

  delete da->array;

  da->array = newArray;
}
wchar_t DynamicArrayCharactersIndex(DynamicArrayCharacters *da, double index){
  return da->array->at(index);
}
double DynamicArrayCharactersLength(DynamicArrayCharacters *da){
  return da->length;
}
void DynamicArrayInsertCharacter(DynamicArrayCharacters *da, double index, wchar_t value){
  double i;

  if(da->length == (double)da->array->size()){
    DynamicArrayCharactersIncreaseSize(da);
  }

  for(i = da->length; i > index; i = i - 1.0){
    da->array->at(i) = da->array->at(i - 1.0);
  }

  da->array->at(index) = value;

  da->length = da->length + 1.0;
}
bool DynamicArrayCharacterSet(DynamicArrayCharacters *da, double index, wchar_t value){
  bool success;

  if(index < da->length){
    da->array->at(index) = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
void DynamicArrayRemoveCharacter(DynamicArrayCharacters *da, double index){
  double i;

  for(i = index; i < da->length - 1.0; i = i + 1.0){
    da->array->at(i) = da->array->at(i + 1.0);
  }

  da->length = da->length - 1.0;

  if(DynamicArrayCharactersDecreaseSizeNecessary(da)){
    DynamicArrayCharactersDecreaseSize(da);
  }
}
void FreeDynamicArrayCharacters(DynamicArrayCharacters *da){
  delete da->array;
  delete da;
}
vector<wchar_t> *DynamicArrayCharactersToArray(DynamicArrayCharacters *da){
  vector<wchar_t> *array;
  double i;

  array = new vector<wchar_t> (da->length);

  for(i = 0.0; i < da->length; i = i + 1.0){
    array->at(i) = da->array->at(i);
  }

  return array;
}
DynamicArrayCharacters *ArrayToDynamicArrayCharactersWithOptimalSize(vector<wchar_t> *array){
  DynamicArrayCharacters *da;
  double i;
  double c, n, newCapacity;

  c = (double)array->size();
  n = (log(c) - 1.0)/log(3.0/2.0);
  newCapacity = ceil(10.0*pow(3.0/2.0, n));

  da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity);

  for(i = 0.0; i < (double)array->size(); i = i + 1.0){
    da->array->at(i) = array->at(i);
  }

  return da;
}
DynamicArrayCharacters *ArrayToDynamicArrayCharacters(vector<wchar_t> *array){
  DynamicArrayCharacters *da;

  da = new DynamicArrayCharacters();
  da->array = arraysCopyString(array);
  da->length = (double)array->size();

  return da;
}
bool DynamicArrayCharactersEqual(DynamicArrayCharacters *a, DynamicArrayCharacters *b){
  bool equal;
  double i;

  equal = true;
  if(a->length == b->length){
    for(i = 0.0; i < a->length && equal; i = i + 1.0){
      if(a->array->at(i) != b->array->at(i)){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
LinkedListCharacters *DynamicArrayCharactersToLinkedList(DynamicArrayCharacters *da){
  LinkedListCharacters *ll;
  double i;

  ll = CreateLinkedListCharacter();

  for(i = 0.0; i < da->length; i = i + 1.0){
    LinkedListAddCharacter(ll, da->array->at(i));
  }

  return ll;
}
DynamicArrayCharacters *LinkedListToDynamicArrayCharacters(LinkedListCharacters *ll){
  DynamicArrayCharacters *da;
  double i;
  LinkedListNodeCharacters *node;

  node = ll->first;

  da = new DynamicArrayCharacters();
  da->length = LinkedListCharactersLength(ll);

  da->array = new vector<wchar_t> (da->length);

  for(i = 0.0; i < da->length; i = i + 1.0){
    da->array->at(i) = node->value;
    node = node->next;
  }

  return da;
}
vector<bool> *AddBoolean(vector<bool> *list, bool a){
  vector<bool> *newlist;
  double i;

  newlist = new vector<bool> ((double)list->size() + 1.0);
  for(i = 0.0; i < (double)list->size(); i = i + 1.0){
    newlist->at(i) = list->at(i);
  }
  newlist->at((double)list->size()) = a;
		
  delete list;
		
  return newlist;
}
void AddBooleanRef(BooleanArrayReference *list, bool i){
  list->booleanArray = AddBoolean(list->booleanArray, i);
}
vector<bool> *RemoveBoolean(vector<bool> *list, double n){
  vector<bool> *newlist;
  double i;

  newlist = new vector<bool> ((double)list->size() - 1.0);

  if(n >= 0.0 && n < (double)list->size()){
    for(i = 0.0; i < (double)list->size(); i = i + 1.0){
      if(i < n){
        newlist->at(i) = list->at(i);
      }
      if(i > n){
        newlist->at(i - 1.0) = list->at(i);
      }
    }

    delete list;
  }else{
    delete newlist;
  }
		
  return newlist;
}
bool GetBooleanRef(BooleanArrayReference *list, double i){
  return list->booleanArray->at(i);
}
void RemoveDecimalRef(BooleanArrayReference *list, double i){
  list->booleanArray = RemoveBoolean(list->booleanArray, i);
}
LinkedListStrings *CreateLinkedListString(){
  LinkedListStrings *ll;

  ll = new LinkedListStrings();
  ll->first = new LinkedListNodeStrings();
  ll->last = ll->first;
  ll->last->end = true;

  return ll;
}
void LinkedListAddString(LinkedListStrings *ll, vector<wchar_t> *value){
  ll->last->end = false;
  ll->last->value = value;
  ll->last->next = new LinkedListNodeStrings();
  ll->last->next->end = true;
  ll->last = ll->last->next;
}
vector<StringReference*> *LinkedListStringsToArray(LinkedListStrings *ll){
  vector<StringReference*> *array;
  double length, i;
  LinkedListNodeStrings *node;

  node = ll->first;

  length = LinkedListStringsLength(ll);

  array = new vector<StringReference*> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    array->at(i) = new StringReference();
    array->at(i)->string = node->value;
    node = node->next;
  }

  return array;
}
double LinkedListStringsLength(LinkedListStrings *ll){
  double l;
  LinkedListNodeStrings *node;

  l = 0.0;
  node = ll->first;
  for(;  !node->end ; ){
    node = node->next;
    l = l + 1.0;
  }

  return l;
}
void FreeLinkedListString(LinkedListStrings *ll){
  LinkedListNodeStrings *node, *prev;

  node = ll->first;

  for(;  !node->end ; ){
    prev = node;
    node = node->next;
    delete prev;
  }

  delete node;
}
void LinkedListInsertString(LinkedListStrings *ll, double index, vector<wchar_t> *value){
  double i;
  LinkedListNodeStrings *node, *tmp;

  if(index == 0.0){
    tmp = ll->first;
    ll->first = new LinkedListNodeStrings();
    ll->first->next = tmp;
    ll->first->value = value;
    ll->first->end = false;
  }else{
    node = ll->first;
    for(i = 0.0; i < index - 1.0; i = i + 1.0){
      node = node->next;
    }

    tmp = node->next;
    node->next = new LinkedListNodeStrings();
    node->next->next = tmp;
    node->next->value = value;
    node->next->end = false;
  }
}
LinkedListNumbers *CreateLinkedListNumbers(){
  LinkedListNumbers *ll;

  ll = new LinkedListNumbers();
  ll->first = new LinkedListNodeNumbers();
  ll->last = ll->first;
  ll->last->end = true;

  return ll;
}
vector<LinkedListNumbers*> *CreateLinkedListNumbersArray(double length){
  vector<LinkedListNumbers*> *lls;
  double i;

  lls = new vector<LinkedListNumbers*> (length);
  for(i = 0.0; i < (double)lls->size(); i = i + 1.0){
    lls->at(i) = CreateLinkedListNumbers();
  }

  return lls;
}
void LinkedListAddNumber(LinkedListNumbers *ll, double value){
  ll->last->end = false;
  ll->last->value = value;
  ll->last->next = new LinkedListNodeNumbers();
  ll->last->next->end = true;
  ll->last = ll->last->next;
}
double LinkedListNumbersLength(LinkedListNumbers *ll){
  double l;
  LinkedListNodeNumbers *node;

  l = 0.0;
  node = ll->first;
  for(;  !node->end ; ){
    node = node->next;
    l = l + 1.0;
  }

  return l;
}
double LinkedListNumbersIndex(LinkedListNumbers *ll, double index){
  double i;
  LinkedListNodeNumbers *node;

  node = ll->first;
  for(i = 0.0; i < index; i = i + 1.0){
    node = node->next;
  }

  return node->value;
}
void LinkedListInsertNumber(LinkedListNumbers *ll, double index, double value){
  double i;
  LinkedListNodeNumbers *node, *tmp;

  if(index == 0.0){
    tmp = ll->first;
    ll->first = new LinkedListNodeNumbers();
    ll->first->next = tmp;
    ll->first->value = value;
    ll->first->end = false;
  }else{
    node = ll->first;
    for(i = 0.0; i < index - 1.0; i = i + 1.0){
      node = node->next;
    }

    tmp = node->next;
    node->next = new LinkedListNodeNumbers();
    node->next->next = tmp;
    node->next->value = value;
    node->next->end = false;
  }
}
void LinkedListSet(LinkedListNumbers *ll, double index, double value){
  double i;
  LinkedListNodeNumbers *node;

  node = ll->first;
  for(i = 0.0; i < index; i = i + 1.0){
    node = node->next;
  }

  node->next->value = value;
}
void LinkedListRemoveNumber(LinkedListNumbers *ll, double index){
  double i;
  LinkedListNodeNumbers *node, *prev;

  node = ll->first;
  prev = ll->first;

  for(i = 0.0; i < index; i = i + 1.0){
    prev = node;
    node = node->next;
  }

  if(index == 0.0){
    ll->first = prev->next;
  }
  if( !prev->next->end ){
    prev->next = prev->next->next;
  }
}
void FreeLinkedListNumbers(LinkedListNumbers *ll){
  LinkedListNodeNumbers *node, *prev;

  node = ll->first;

  for(;  !node->end ; ){
    prev = node;
    node = node->next;
    delete prev;
  }

  delete node;
}
void FreeLinkedListNumbersArray(vector<LinkedListNumbers*> *lls){
  double i;

  for(i = 0.0; i < (double)lls->size(); i = i + 1.0){
    FreeLinkedListNumbers(lls->at(i));
  }
  delete lls;
}
vector<double> *LinkedListNumbersToArray(LinkedListNumbers *ll){
  vector<double> *array;
  double length, i;
  LinkedListNodeNumbers *node;

  node = ll->first;

  length = LinkedListNumbersLength(ll);

  array = new vector<double> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    array->at(i) = node->value;
    node = node->next;
  }

  return array;
}
LinkedListNumbers *ArrayToLinkedListNumbers(vector<double> *array){
  LinkedListNumbers *ll;
  double i;

  ll = CreateLinkedListNumbers();

  for(i = 0.0; i < (double)array->size(); i = i + 1.0){
    LinkedListAddNumber(ll, array->at(i));
  }

  return ll;
}
bool LinkedListNumbersEqual(LinkedListNumbers *a, LinkedListNumbers *b){
  bool equal, done;
  LinkedListNodeNumbers *an, *bn;

  an = a->first;
  bn = b->first;

  equal = true;
  done = false;
  for(; equal &&  !done ; ){
    if(an->end == bn->end){
      if(an->end){
        done = true;
      }else if(an->value == bn->value){
        an = an->next;
        bn = bn->next;
      }else{
        equal = false;
      }
    }else{
      equal = false;
    }
  }

  return equal;
}
LinkedListCharacters *CreateLinkedListCharacter(){
  LinkedListCharacters *ll;

  ll = new LinkedListCharacters();
  ll->first = new LinkedListNodeCharacters();
  ll->last = ll->first;
  ll->last->end = true;

  return ll;
}
void LinkedListAddCharacter(LinkedListCharacters *ll, wchar_t value){
  ll->last->end = false;
  ll->last->value = value;
  ll->last->next = new LinkedListNodeCharacters();
  ll->last->next->end = true;
  ll->last = ll->last->next;
}
vector<wchar_t> *LinkedListCharactersToArray(LinkedListCharacters *ll){
  vector<wchar_t> *array;
  double length, i;
  LinkedListNodeCharacters *node;

  node = ll->first;

  length = LinkedListCharactersLength(ll);

  array = new vector<wchar_t> (length);

  for(i = 0.0; i < length; i = i + 1.0){
    array->at(i) = node->value;
    node = node->next;
  }

  return array;
}
double LinkedListCharactersLength(LinkedListCharacters *ll){
  double l;
  LinkedListNodeCharacters *node;

  l = 0.0;
  node = ll->first;
  for(;  !node->end ; ){
    node = node->next;
    l = l + 1.0;
  }

  return l;
}
void FreeLinkedListCharacter(LinkedListCharacters *ll){
  LinkedListNodeCharacters *node, *prev;

  node = ll->first;

  for(;  !node->end ; ){
    prev = node;
    node = node->next;
    delete prev;
  }

  delete node;
}
void LinkedListCharactersAddString(LinkedListCharacters *ll, vector<wchar_t> *str){
  double i;

  for(i = 0.0; i < (double)str->size(); i = i + 1.0){
    LinkedListAddCharacter(ll, str->at(i));
  }
}
void LinkedListInsertCharacter(LinkedListCharacters *ll, double index, wchar_t value){
  double i;
  LinkedListNodeCharacters *node, *tmp;

  if(index == 0.0){
    tmp = ll->first;
    ll->first = new LinkedListNodeCharacters();
    ll->first->next = tmp;
    ll->first->value = value;
    ll->first->end = false;
  }else{
    node = ll->first;
    for(i = 0.0; i < index - 1.0; i = i + 1.0){
      node = node->next;
    }

    tmp = node->next;
    node->next = new LinkedListNodeCharacters();
    node->next->next = tmp;
    node->next->value = value;
    node->next->end = false;
  }
}
DynamicArrayNumbers *CreateDynamicArrayNumbers(){
  DynamicArrayNumbers *da;

  da = new DynamicArrayNumbers();
  da->array = new vector<double> (10.0);
  da->length = 0.0;

  return da;
}
DynamicArrayNumbers *CreateDynamicArrayNumbersWithInitialCapacity(double capacity){
  DynamicArrayNumbers *da;

  da = new DynamicArrayNumbers();
  da->array = new vector<double> (capacity);
  da->length = 0.0;

  return da;
}
void DynamicArrayAddNumber(DynamicArrayNumbers *da, double value){
  if(da->length == (double)da->array->size()){
    DynamicArrayNumbersIncreaseSize(da);
  }

  da->array->at(da->length) = value;
  da->length = da->length + 1.0;
}
void DynamicArrayNumbersIncreaseSize(DynamicArrayNumbers *da){
  double newLength, i;
  vector<double> *newArray;

  newLength = round((double)da->array->size()*3.0/2.0);
  newArray = new vector<double> (newLength);

  for(i = 0.0; i < (double)da->array->size(); i = i + 1.0){
    newArray->at(i) = da->array->at(i);
  }

  delete da->array;

  da->array = newArray;
}
bool DynamicArrayNumbersDecreaseSizeNecessary(DynamicArrayNumbers *da){
  bool needsDecrease;

  needsDecrease = false;

  if(da->length > 10.0){
    needsDecrease = da->length <= round((double)da->array->size()*2.0/3.0);
  }

  return needsDecrease;
}
void DynamicArrayNumbersDecreaseSize(DynamicArrayNumbers *da){
  double newLength, i;
  vector<double> *newArray;

  newLength = round((double)da->array->size()*2.0/3.0);
  newArray = new vector<double> (newLength);

  for(i = 0.0; i < newLength; i = i + 1.0){
    newArray->at(i) = da->array->at(i);
  }

  delete da->array;

  da->array = newArray;
}
double DynamicArrayNumbersIndex(DynamicArrayNumbers *da, double index){
  return da->array->at(index);
}
double DynamicArrayNumbersLength(DynamicArrayNumbers *da){
  return da->length;
}
void DynamicArrayInsertNumber(DynamicArrayNumbers *da, double index, double value){
  double i;

  if(da->length == (double)da->array->size()){
    DynamicArrayNumbersIncreaseSize(da);
  }

  for(i = da->length; i > index; i = i - 1.0){
    da->array->at(i) = da->array->at(i - 1.0);
  }

  da->array->at(index) = value;

  da->length = da->length + 1.0;
}
bool DynamicArrayNumberSet(DynamicArrayNumbers *da, double index, double value){
  bool success;

  if(index < da->length){
    da->array->at(index) = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
void DynamicArrayRemoveNumber(DynamicArrayNumbers *da, double index){
  double i;

  for(i = index; i < da->length - 1.0; i = i + 1.0){
    da->array->at(i) = da->array->at(i + 1.0);
  }

  da->length = da->length - 1.0;

  if(DynamicArrayNumbersDecreaseSizeNecessary(da)){
    DynamicArrayNumbersDecreaseSize(da);
  }
}
void FreeDynamicArrayNumbers(DynamicArrayNumbers *da){
  delete da->array;
  delete da;
}
vector<double> *DynamicArrayNumbersToArray(DynamicArrayNumbers *da){
  vector<double> *array;
  double i;

  array = new vector<double> (da->length);

  for(i = 0.0; i < da->length; i = i + 1.0){
    array->at(i) = da->array->at(i);
  }

  return array;
}
DynamicArrayNumbers *ArrayToDynamicArrayNumbersWithOptimalSize(vector<double> *array){
  DynamicArrayNumbers *da;
  double i;
  double c, n, newCapacity;

  /*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
         */
  c = (double)array->size();
  n = (log(c) - 1.0)/log(3.0/2.0);
  newCapacity = ceil(10.0*pow(3.0/2.0, n));

  da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity);

  for(i = 0.0; i < (double)array->size(); i = i + 1.0){
    da->array->at(i) = array->at(i);
  }

  return da;
}
DynamicArrayNumbers *ArrayToDynamicArrayNumbers(vector<double> *array){
  DynamicArrayNumbers *da;

  da = new DynamicArrayNumbers();
  da->array = arraysCopyNumberArray(array);
  da->length = (double)array->size();

  return da;
}
bool DynamicArrayNumbersEqual(DynamicArrayNumbers *a, DynamicArrayNumbers *b){
  bool equal;
  double i;

  equal = true;
  if(a->length == b->length){
    for(i = 0.0; i < a->length && equal; i = i + 1.0){
      if(a->array->at(i) != b->array->at(i)){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
LinkedListNumbers *DynamicArrayNumbersToLinkedList(DynamicArrayNumbers *da){
  LinkedListNumbers *ll;
  double i;

  ll = CreateLinkedListNumbers();

  for(i = 0.0; i < da->length; i = i + 1.0){
    LinkedListAddNumber(ll, da->array->at(i));
  }

  return ll;
}
DynamicArrayNumbers *LinkedListToDynamicArrayNumbers(LinkedListNumbers *ll){
  DynamicArrayNumbers *da;
  double i;
  LinkedListNodeNumbers *node;

  node = ll->first;

  da = new DynamicArrayNumbers();
  da->length = LinkedListNumbersLength(ll);

  da->array = new vector<double> (da->length);

  for(i = 0.0; i < da->length; i = i + 1.0){
    da->array->at(i) = node->value;
    node = node->next;
  }

  return da;
}
double DynamicArrayNumbersIndexOf(DynamicArrayNumbers *arr, double n, BooleanReference *foundReference){
  bool found;
  double i;

  found = false;
  for(i = 0.0; i < arr->length &&  !found ; i = i + 1.0){
    if(arr->array->at(i) == n){
      found = true;
    }
  }
  if( !found ){
    i =  -1.0;
  }else{
    i = i - 1.0;
  }

  foundReference->booleanValue = found;

  return i;
}
bool DynamicArrayNumbersIsInArray(DynamicArrayNumbers *arr, double n){
  bool found;
  double i;

  found = false;
  for(i = 0.0; i < arr->length &&  !found ; i = i + 1.0){
    if(arr->array->at(i) == n){
      found = true;
    }
  }

  return found;
}
vector<wchar_t> *AddCharacter(vector<wchar_t> *list, wchar_t a){
  vector<wchar_t> *newlist;
  double i;

  newlist = new vector<wchar_t> ((double)list->size() + 1.0);
  for(i = 0.0; i < (double)list->size(); i = i + 1.0){
    newlist->at(i) = list->at(i);
  }
  newlist->at((double)list->size()) = a;
		
  delete list;
		
  return newlist;
}
void AddCharacterRef(StringReference *list, wchar_t i){
  list->string = AddCharacter(list->string, i);
}
vector<wchar_t> *RemoveCharacter(vector<wchar_t> *list, double n){
  vector<wchar_t> *newlist;
  double i;

  newlist = new vector<wchar_t> ((double)list->size() - 1.0);

  if(n >= 0.0 && n < (double)list->size()){
    for(i = 0.0; i < (double)list->size(); i = i + 1.0){
      if(i < n){
        newlist->at(i) = list->at(i);
      }
      if(i > n){
        newlist->at(i - 1.0) = list->at(i);
      }
    }

    delete list;
  }else{
    delete newlist;
  }

  return newlist;
}
wchar_t GetCharacterRef(StringReference *list, double i){
  return list->string->at(i);
}
void RemoveCharacterRef(StringReference *list, double i){
  list->string = RemoveCharacter(list->string, i);
}
double GetAccrualAmount(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay, double yearOfInterest, double monthOfInterest){
  Date *from, *to;
  double amount;

  from = CreateDate(fromYear, fromMonth, fromDay);
  to = CreateDate(toYear, toMonth, toDay);

  amount = GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest);

  return amount;
}
vector<double> *GetAccruals(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay){
  Date *from, *to;
  vector<double> *amounts;

  from = CreateDate(fromYear, fromMonth, fromDay);
  to = CreateDate(toYear, toMonth, toDay);

  amounts = GetAccrualsWithDates(total, from, to);

  return amounts;
}
vector<double> *GetAccrualsWithDates(double total, Date *from, Date *to){
  double entry;
  bool done;
  Date *dateOfInterest;
  LinkedListNumbers *list;
  vector<double> *result;

  list = CreateLinkedListNumbers();

  done = false;
  dateOfInterest = new Date();
  AssignDate(dateOfInterest, from);
  for(;  !done ; ){
    if(dateOfInterest->year == to->year && dateOfInterest->month == to->month){
      done = true;
    }

    entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest->year, dateOfInterest->month);
    LinkedListAddNumber(list, entry);
    AddMonthsToDate(dateOfInterest, 1.0);
  }

  result = LinkedListNumbersToArray(list);
  FreeLinkedListNumbers(list);

  return result;
}
double GetAccrualAmountWithDates(double total, Date *from, Date *to, double yearOfInterest, double monthOfInterest){
  double unadjustedAmount, adjustment, days, daysToAdjust, n;
  Date *adjustTo;
  FixedPoint15d *valuePerDay, *divisibleRemaining, *divisibleTotal, *amount;
  StringReference *message;

  message = new StringReference();

  valuePerDay = CreateFixedPoint15d(13.0, 2.0);
  divisibleRemaining = CreateFixedPoint15d(13.0, 2.0);
  divisibleTotal = CreateFixedPoint15d(13.0, 2.0);
  amount = CreateFixedPoint15d(13.0, 2.0);

  days = DaysBetweenDates(from, to) + 1.0;

  /* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining */
  DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days));

  Multiply15d(divisibleTotal, valuePerDay, Number15d(days));
  unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, from, to, yearOfInterest, monthOfInterest);

  if( !Equals15d(divisibleRemaining, Number15d(0.0)) ){
    daysToAdjust = Round(ToNumber15d(divisibleRemaining)*100.0);
    adjustTo = new Date();
    AssignDate(adjustTo, from);
    AddDaysToDate(adjustTo, daysToAdjust - 1.0, message);

    adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest);

    delete adjustTo;
  }else{
    adjustment = 0.0;
  }

  Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment));

  n = ToNumber15d(amount);

  delete valuePerDay;
  delete divisibleRemaining;
  delete divisibleTotal;
  delete amount;

  return n;
}
double GetUnadjustedAccrualAmountWithDates(FixedPoint15d *total, Date *from, Date *to, double yearOfInterest, double monthOfInterest){
  double days, daysInMonthOfInterest, n;
  Date *lastDayInMonth, *firstDateInMonth;
  vector<double> *daysInMonth;
  FixedPoint15d *valuePerDay, *value, *remainder;
  bool success;

  value = CreateFixedPoint15d(13.0, 2.0);
  valuePerDay = CreateFixedPoint15d(13.0, 2.0);
  remainder = CreateFixedPoint15d(13.0, 2.0);

  days = DaysBetweenDates(from, to) + 1.0;
  /* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ... */
  success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days));

  if(success){
    daysInMonth = GetDaysInMonth(yearOfInterest);

    if(yearOfInterest < from->year){
      Assign15d(value, 0.0);
    }else if(yearOfInterest == from->year && monthOfInterest < from->month){
      Assign15d(value, 0.0);
    }else if(yearOfInterest > to->year){
      Assign15d(value, 0.0);
    }else if(yearOfInterest == to->year && monthOfInterest > to->month){
      Assign15d(value, 0.0);
    }else{
if(from->year == yearOfInterest && from->month == monthOfInterest && to->year == yearOfInterest && to->month == monthOfInterest){
        daysInMonthOfInterest = days;
      }else if(from->year == yearOfInterest && from->month == monthOfInterest){
        lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth->at(monthOfInterest));
        daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1.0;
      }else if(to->year == yearOfInterest && to->month == monthOfInterest){
        firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0);
        daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1.0;
      }else{
        daysInMonthOfInterest = daysInMonth->at(monthOfInterest);
      }

      /* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value */
      Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest));
    }

    delete daysInMonth;
  }

  n = ToNumber15d(value);

  delete value;
  delete valuePerDay;
  delete remainder;

  return n;
}
Data *CreateNewArrayData(){
  Data *data;

  data = new Data();
  data->isArray = true;
  data->isStruture = false;
  data->isNumber = false;
  data->isBoolean = false;
  data->isString = false;
  data->array = CreateArray();

  return data;
}
Data *CreateNewStructData(){
  Data *data;

  data = new Data();
  data->isStruture = true;
  data->isArray = false;
  data->isNumber = false;
  data->isBoolean = false;
  data->isString = false;
  data->structure = CreateStructure();

  return data;
}
Structure *CreateStructure(){
  Structure *st;

  st = new Structure();
  st->keys = CreateArray();
  st->values = CreateArray();

  return st;
}
Data *CreateNumberData(double n){
  Data *data;

  data = new Data();
  data->isNumber = true;
  data->isStruture = false;
  data->isArray = false;
  data->isBoolean = false;
  data->isString = false;
  data->number = n;

  return data;
}
Data *CreateBooleanData(bool b){
  Data *data;

  data = new Data();
  data->isBoolean = true;
  data->isStruture = false;
  data->isArray = false;
  data->isNumber = false;
  data->isString = false;
  data->booleanx = b;

  return data;
}
Data *CreateStringData(vector<wchar_t> *string){
  Data *data;

  data = new Data();
  data->isString = true;
  data->isStruture = false;
  data->isArray = false;
  data->isNumber = false;
  data->isBoolean = false;
  data->string = string;

  return data;
}
Data *CreateStructData(Structure *structure){
  Data *data;

  data = new Data();
  data->isString = false;
  data->isStruture = true;
  data->isArray = false;
  data->isNumber = false;
  data->isBoolean = false;
  data->structure = structure;

  return data;
}
Data *CreateArrayData(Array *array){
  Data *data;

  data = new Data();
  data->isString = false;
  data->isStruture = false;
  data->isArray = true;
  data->isNumber = false;
  data->isBoolean = false;
  data->array = array;

  return data;
}
Data *CreateNoTypeData(){
  Data *data;

  data = new Data();
  data->isStruture = false;
  data->isArray = false;
  data->isNumber = false;
  data->isBoolean = false;
  data->isString = false;

  return data;
}
void AddStructToArray(Array *ar, Structure *st){
  Data *data;

  data = CreateNewStructData();
  delete data->structure;
  data->structure = st;

  ArrayAdd(ar, data);
}
void AddArrayToArray(Array *ar, Array *ar2){
  Data *data;

  data = CreateNewArrayData();
  delete data->array;
  data->array = ar2;

  ArrayAdd(ar, data);
}
void AddNumberToArray(Array *ar, double n){
  ArrayAdd(ar, CreateNumberData(n));
}
void AddBooleanToArray(Array *ar, bool b){
  ArrayAdd(ar, CreateBooleanData(b));
}
void AddStringToArray(Array *ar, vector<wchar_t> *str){
  ArrayAdd(ar, CreateStringData(str));
}
void AddDataToArray(Array *ar, Data *data){
  ArrayAdd(ar, data);
}
double StructKeys(Structure *st){
  return ArrayLength(st->keys);
}
bool StructHasKey(Structure *st, vector<wchar_t> *key){
  double i;
  bool hasKey;

  hasKey = false;
  for(i = 0.0; i < StructKeys(st); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      hasKey = true;
    }
  }

  return hasKey;
}
double StructKeyIndex(Structure *st, vector<wchar_t> *key){
  double i;
  double index;

  index =  -1.0;
  for(i = 0.0; i < StructKeys(st); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      index = i;
    }
  }

  return index;
}
vector<StringReference*> *GetStructKeys(Structure *st){
  vector<StringReference*> *keys;
  double nr, i;

  nr = StructKeys(st);

  keys = new vector<StringReference*> (nr);

  for(i = 0.0; i < nr; i = i + 1.0){
    keys->at(i) = new StringReference();
    keys->at(i)->string = arraysCopyString(st->keys->array->at(i)->string);
  }

  return keys;
}
Structure *GetStructFromStruct(Structure *st, vector<wchar_t> *key){
  double i;
  Structure *r;

  r = new Structure();
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      r = st->values->array->at(i)->structure;
    }
  }

  return r;
}
Array *GetArrayFromStruct(Structure *st, vector<wchar_t> *key){
  double i;
  Array *r;

  r = new Array();
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      r = st->values->array->at(i)->array;
    }
  }

  return r;
}
double GetNumberFromStruct(Structure *st, vector<wchar_t> *key){
  double i, r;

  r = 0.0;
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      r = st->values->array->at(i)->number;
    }
  }

  return r;
}
bool GetBooleanFromStruct(Structure *st, vector<wchar_t> *key){
  double i;
  bool r;

  r = false;
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      r = st->values->array->at(i)->booleanx;
    }
  }

  return r;
}
vector<wchar_t> *GetStringFromStruct(Structure *st, vector<wchar_t> *key){
  double i;
  vector<wchar_t> *r;

  r = toVector(L"");
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      r = st->values->array->at(i)->string;
    }
  }

  return r;
}
Data *GetDataFromStruct(Structure *st, vector<wchar_t> *key){
  double i;
  Data *r;

  r = new Data();
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      delete r;
      r = st->values->array->at(i);
    }
  }

  return r;
}
Data *GetDataFromStructWithCheck(Structure *st, vector<wchar_t> *key, BooleanReference *foundRef){
  double i;
  Data *r;

  r = new Data();
  foundRef->booleanValue = false;
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array->at(i)->string, key)){
      delete r;
      foundRef->booleanValue = true;
      r = st->values->array->at(i);
    }
  }

  return r;
}
void AddStructToStruct(Structure *st, vector<wchar_t> *key, Structure *structx){
  double i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    delete st->values->array->at(i)->structure;
    st->values->array->at(i)->structure = structx;
  }else{
    AddStringToArray(st->keys, key);
    AddStructToArray(st->values, structx);
  }
}
void AddArrayToStruct(Structure *st, vector<wchar_t> *key, Array *ar){
  double i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    delete st->values->array->at(i)->array;
    st->values->array->at(i)->array = ar;
  }else{
    AddStringToArray(st->keys, key);
    AddArrayToArray(st->values, ar);
  }
}
void AddNumberToStruct(Structure *st, vector<wchar_t> *key, double n){
  double i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    st->values->array->at(i)->number = n;
  }else{
    AddStringToArray(st->keys, key);
    AddNumberToArray(st->values, n);
  }
}
void AddBooleanToStruct(Structure *st, vector<wchar_t> *key, bool b){
  double i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    st->values->array->at(i)->booleanx = b;
  }else{
    AddStringToArray(st->keys, key);
    AddBooleanToArray(st->values, b);
  }
}
void AddStringToStruct(Structure *st, vector<wchar_t> *key, vector<wchar_t> *value){
  double i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    delete st->values->array->at(i)->string;
    st->values->array->at(i)->string = value;
  }else{
    AddStringToArray(st->keys, key);
    AddStringToArray(st->values, value);
  }
}
void AddDataToStruct(Structure *st, vector<wchar_t> *key, Data *data){
  double i;

  if(StructHasKey(st, key)){
    i = StructKeyIndex(st, key);
    FreeData(st->values->array->at(i));
    st->values->array->at(i) = data;
  }else{
    AddStringToArray(st->keys, key);
    AddDataToArray(st->values, data);
  }
}
void FreeData(Data *data){
  double i;
  Structure *st;

  if(data->isStruture){
    st = data->structure;
    for(i = 0.0; i < StructKeys(st); i = i + 1.0){
      FreeData(ArrayIndex(st->keys, i));
      FreeData(ArrayIndex(st->values, i));
    }
    delete st;
  }else if(data->isArray){
    FreeArray(data->array);
  }

  delete data;
}
void FreeArray(Array *array){
  double i;

  for(i = 0.0; i < ArrayLength(array); i = i + 1.0){
    FreeData(array->array->at(i));
  }

  delete array->array;
  delete array;
}
bool DataTypeEquals(Data *a, Data *b){
  bool equal;

  equal = true;
  equal = equal && a->isStruture == b->isStruture;
  equal = equal && a->isArray == b->isArray;
  equal = equal && a->isNumber == b->isNumber;
  equal = equal && a->isBoolean == b->isBoolean;
  equal = equal && a->isString == b->isString;

  return equal;
}
bool IsStructure(Data *a){
  bool itis;

  itis = a->isStruture;
  if(a->isArray || a->isNumber || a->isBoolean || a->isString){
    itis = false;
  }

  return itis;
}
bool IsArray(Data *a){
  bool itis;

  itis = a->isArray;
  if(a->isStruture || a->isNumber || a->isBoolean || a->isString){
    itis = false;
  }

  return itis;
}
bool IsNumber(Data *a){
  bool itis;

  itis = a->isNumber;
  if(a->isStruture || a->isArray || a->isBoolean || a->isString){
    itis = false;
  }

  return itis;
}
bool IsBoolean(Data *a){
  bool itis;

  itis = a->isBoolean;
  if(a->isStruture || a->isArray || a->isNumber || a->isString){
    itis = false;
  }

  return itis;
}
bool IsString(Data *a){
  bool itis;

  itis = a->isString;
  if(a->isStruture || a->isArray || a->isNumber || a->isBoolean){
    itis = false;
  }

  return itis;
}
bool IsNoType(Data *a){
  bool itis;

  if( !a->isString  &&  !a->isStruture  &&  !a->isArray  &&  !a->isNumber  &&  !a->isBoolean ){
    itis = true;
  }else{
    itis = false;
  }

  return itis;
}
Array *CreateArray(){
  Array *array;

  array = new Array();
  array->array = new vector<Data*> (10.0);
  array->length = 0.0;

  return array;
}
Array *CreateArrayWithInitialCapacity(double capacity){
  Array *array;

  array = new Array();
  array->array = new vector<Data*> (capacity);
  array->length = 0.0;

  return array;
}
void ArrayAdd(Array *array, Data *value){
  if(array->length == (double)array->array->size()){
    ArrayIncreaseSize(array);
  }

  array->array->at(array->length) = value;
  array->length = array->length + 1.0;
}
void ArrayAddString(Array *array, vector<wchar_t> *value){
  Data *data;

  data = CreateStringData(value);

  ArrayAdd(array, data);
}
void ArrayAddBoolean(Array *array, bool value){
  Data *data;

  data = CreateBooleanData(value);

  ArrayAdd(array, data);
}
void ArrayAddNumber(Array *array, double value){
  Data *data;

  data = CreateNumberData(value);

  ArrayAdd(array, data);
}
void ArrayAddStruct(Array *array, Structure *value){
  Data *data;

  data = CreateStructData(value);

  ArrayAdd(array, data);
}
void ArrayAddArray(Array *array, Array *value){
  Data *data;

  data = CreateArrayData(value);

  ArrayAdd(array, data);
}
void ArrayIncreaseSize(Array *array){
  double newLength, i;
  vector<Data*> *newArray;

  newLength = round((double)array->array->size()*3.0/2.0);
  newArray = new vector<Data*> (newLength);

  for(i = 0.0; i < (double)array->array->size(); i = i + 1.0){
    newArray->at(i) = array->array->at(i);
  }

  delete array->array;

  array->array = newArray;
}
bool ArrayDecreaseSizeNecessary(Array *array){
  bool needsDecrease;

  needsDecrease = false;

  if(array->length > 10.0){
    needsDecrease = array->length <= round((double)array->array->size()*2.0/3.0);
  }

  return needsDecrease;
}
void ArrayDecreaseSize(Array *array){
  double newLength, i;
  vector<Data*> *newArray;

  newLength = round((double)array->array->size()*2.0/3.0);
  newArray = new vector<Data*> (newLength);

  for(i = 0.0; i < newLength; i = i + 1.0){
    newArray->at(i) = array->array->at(i);
  }

  delete array->array;

  array->array = newArray;
}
Data *ArrayIndex(Array *array, double index){
  return array->array->at(index);
}
Array *ArrayIndexArray(Array *array, double index){
  return array->array->at(index)->array;
}
Structure *ArrayIndexStruct(Array *array, double index){
  return array->array->at(index)->structure;
}
bool ArrayIndexBoolean(Array *array, double index){
  return array->array->at(index)->booleanx;
}
vector<wchar_t> *ArrayIndexString(Array *array, double index){
  return array->array->at(index)->string;
}
double ArrayIndexNumber(Array *array, double index){
  return array->array->at(index)->number;
}
double ArrayLength(Array *array){
  return array->length;
}
void ArrayInsert(Array *array, double index, Data *value){
  double i;

  if(array->length == (double)array->array->size()){
    ArrayIncreaseSize(array);
  }

  for(i = array->length; i > index; i = i - 1.0){
    array->array->at(i) = array->array->at(i - 1.0);
  }

  array->array->at(index) = value;

  array->length = array->length + 1.0;
}
void ArrayInsertString(Array *array, double index, vector<wchar_t> *value){
  Data *data;

  data = CreateStringData(value);

  ArrayInsert(array, index, data);
}
void ArrayInsertBoolean(Array *array, double index, bool value){
  Data *data;

  data = CreateBooleanData(value);

  ArrayInsert(array, index, data);
}
void ArrayInsertNumber(Array *array, double index, double value){
  Data *data;

  data = CreateNumberData(value);

  ArrayInsert(array, index, data);
}
void ArrayInsertStruct(Array *array, double index, Structure *value){
  Data *data;

  data = CreateStructData(value);

  ArrayInsert(array, index, data);
}
void ArrayInsertArray(Array *array, double index, Array *value){
  Data *data;

  data = CreateArrayData(value);

  ArrayInsert(array, index, data);
}
bool ArraySet(Array *array, double index, Data *value){
  bool success;

  if(index < array->length){
    array->array->at(index) = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
void ArraySetString(Array *array, double index, vector<wchar_t> *value){
  Data *data;

  data = CreateStringData(value);

  ArraySet(array, index, data);
}
void ArraySetBoolean(Array *array, double index, bool value){
  Data *data;

  data = CreateBooleanData(value);

  ArraySet(array, index, data);
}
void ArraySetNumber(Array *array, double index, double value){
  Data *data;

  data = CreateNumberData(value);

  ArraySet(array, index, data);
}
void ArraySetStruct(Array *array, double index, Structure *value){
  Data *data;

  data = CreateStructData(value);

  ArraySet(array, index, data);
}
void ArraySetArray(Array *array, double index, Array *value){
  Data *data;

  data = CreateArrayData(value);

  ArraySet(array, index, data);
}
void ArrayRemove(Array *array, double index){
  double i;

  for(i = index; i < array->length - 1.0; i = i + 1.0){
    array->array->at(i) = array->array->at(i + 1.0);
  }

  array->length = array->length - 1.0;

  if(ArrayDecreaseSizeNecessary(array)){
    ArrayDecreaseSize(array);
  }
}
vector<Data*> *ToStaticArray(Array *arc){
  vector<Data*> *array;
  double i;

  array = new vector<Data*> (arc->length);

  for(i = 0.0; i < arc->length; i = i + 1.0){
    array->at(i) = arc->array->at(i);
  }

  return array;
}
vector<double> *ToStaticNumberArray(Array *array){
  vector<double> *result;
  double i, n;

  n = ArrayLength(array);

  result = new vector<double> (n);

  for(i = 0.0; i < n; i = i + 1.0){
    result->at(i) = ArrayIndex(array, i)->number;
  }

  return result;
}
vector<bool> *ToStaticBooleanArray(Array *array){
  vector<bool> *result;
  double i, n;

  n = ArrayLength(array);

  result = new vector<bool> (n);

  for(i = 0.0; i < n; i = i + 1.0){
    result->at(i) = ArrayIndex(array, i)->booleanx;
  }

  return result;
}
vector<StringReference*> *ToStaticStringArray(Array *array){
  vector<StringReference*> *result;
  double i, n;

  n = ArrayLength(array);

  result = new vector<StringReference*> (n);

  for(i = 0.0; i < n; i = i + 1.0){
    result->at(i) = new StringReference();
    result->at(i)->string = ArrayIndex(array, i)->string;
  }

  return result;
}
vector<Array*> *ToStaticArrayArray(Array *array){
  vector<Array*> *result;
  double i, n;

  n = ArrayLength(array);

  result = new vector<Array*> (n);

  for(i = 0.0; i < n; i = i + 1.0){
    result->at(i) = ArrayIndex(array, i)->array;
  }

  return result;
}
vector<Structure*> *ToStaticStructArray(Array *array){
  vector<Structure*> *result;
  double i, n;

  n = ArrayLength(array);

  result = new vector<Structure*> (n);

  for(i = 0.0; i < n; i = i + 1.0){
    result->at(i) = ArrayIndex(array, i)->structure;
  }

  return result;
}
Array *StaticArrayToArrayWithOptimalSize(vector<Data*> *src){
  Array *dst;
  double i;
  double c, n, newCapacity;

  /*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
         */

  c = (double)src->size();
  n = (log(c) - 1.0)/log(3.0/2.0);

  newCapacity = ceil(10.0*pow(3.0/2.0, ceil(n)));

  dst = CreateArrayWithInitialCapacity(newCapacity);

  for(i = 0.0; i < (double)src->size(); i = i + 1.0){
    dst->array->at(i) = src->at(i);
  }

  return dst;
}
Array *StaticArrayToArray(vector<Data*> *src){
  double i;
  Array *dst;

  dst = CreateArrayWithInitialCapacity((double)src->size());
  for(i = 0.0; i < (double)src->size(); i = i + 1.0){
    dst->array->at(i) = src->at(i);
  }
  dst->length = (double)src->size();

  return dst;
}
vector<double> *arraysStringToNumberArray(vector<wchar_t> *string){
  double i;
  vector<double> *array;

  array = new vector<double> ((double)string->size());

  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    array->at(i) = string->at(i);
  }
  return array;
}
vector<wchar_t> *arraysNumberArrayToString(vector<double> *array){
  double i;
  vector<wchar_t> *string;

  string = new vector<wchar_t> ((double)array->size());

  for(i = 0.0; i < (double)array->size(); i = i + 1.0){
    string->at(i) = array->at(i);
  }
  return string;
}
bool arraysNumberArraysEqual(vector<double> *a, vector<double> *b){
  bool equal;
  double i;

  equal = true;
  if((double)a->size() == (double)b->size()){
    for(i = 0.0; i < (double)a->size() && equal; i = i + 1.0){
      if(a->at(i) != b->at(i)){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
bool arraysBooleanArraysEqual(vector<bool> *a, vector<bool> *b){
  bool equal;
  double i;

  equal = true;
  if((double)a->size() == (double)b->size()){
    for(i = 0.0; i < (double)a->size() && equal; i = i + 1.0){
      if(a->at(i) != b->at(i)){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
bool arraysStringsEqual(vector<wchar_t> *a, vector<wchar_t> *b){
  bool equal;
  double i;

  equal = true;
  if((double)a->size() == (double)b->size()){
    for(i = 0.0; i < (double)a->size() && equal; i = i + 1.0){
      if(a->at(i) != b->at(i)){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
void arraysFillNumberArray(vector<double> *a, double value){
  double i;

  for(i = 0.0; i < (double)a->size(); i = i + 1.0){
    a->at(i) = value;
  }
}
void arraysFillString(vector<wchar_t> *a, wchar_t value){
  double i;

  for(i = 0.0; i < (double)a->size(); i = i + 1.0){
    a->at(i) = value;
  }
}
void arraysFillBooleanArray(vector<bool> *a, bool value){
  double i;

  for(i = 0.0; i < (double)a->size(); i = i + 1.0){
    a->at(i) = value;
  }
}
bool arraysFillNumberArrayRange(vector<double> *a, double value, double from, double to){
  double i, length;
  bool success;

  if(from >= 0.0 && from <= (double)a->size() && to >= 0.0 && to <= (double)a->size() && from <= to){
    length = to - from;
    for(i = 0.0; i < length; i = i + 1.0){
      a->at(from + i) = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
bool arraysFillBooleanArrayRange(vector<bool> *a, bool value, double from, double to){
  double i, length;
  bool success;

  if(from >= 0.0 && from <= (double)a->size() && to >= 0.0 && to <= (double)a->size() && from <= to){
    length = to - from;
    for(i = 0.0; i < length; i = i + 1.0){
      a->at(from + i) = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
bool arraysFillStringRange(vector<wchar_t> *a, wchar_t value, double from, double to){
  double i, length;
  bool success;

  if(from >= 0.0 && from <= (double)a->size() && to >= 0.0 && to <= (double)a->size() && from <= to){
    length = to - from;
    for(i = 0.0; i < length; i = i + 1.0){
      a->at(from + i) = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
vector<double> *arraysCopyNumberArray(vector<double> *a){
  double i;
  vector<double> *n;

  n = new vector<double> ((double)a->size());

  for(i = 0.0; i < (double)a->size(); i = i + 1.0){
    n->at(i) = a->at(i);
  }

  return n;
}
vector<bool> *arraysCopyBooleanArray(vector<bool> *a){
  double i;
  vector<bool> *n;

  n = new vector<bool> ((double)a->size());

  for(i = 0.0; i < (double)a->size(); i = i + 1.0){
    n->at(i) = a->at(i);
  }

  return n;
}
vector<wchar_t> *arraysCopyString(vector<wchar_t> *a){
  double i;
  vector<wchar_t> *n;

  n = new vector<wchar_t> ((double)a->size());

  for(i = 0.0; i < (double)a->size(); i = i + 1.0){
    n->at(i) = a->at(i);
  }

  return n;
}
bool arraysCopyNumberArrayRange(vector<double> *a, double from, double to, NumberArrayReference *copyReference){
  double i, length;
  vector<double> *n;
  bool success;

  if(from >= 0.0 && from <= (double)a->size() && to >= 0.0 && to <= (double)a->size() && from <= to){
    length = to - from;
    n = new vector<double> (length);

    for(i = 0.0; i < length; i = i + 1.0){
      n->at(i) = a->at(from + i);
    }

    copyReference->numberArray = n;
    success = true;
  }else{
    success = false;
  }

  return success;
}
bool arraysCopyBooleanArrayRange(vector<bool> *a, double from, double to, BooleanArrayReference *copyReference){
  double i, length;
  vector<bool> *n;
  bool success;

  if(from >= 0.0 && from <= (double)a->size() && to >= 0.0 && to <= (double)a->size() && from <= to){
    length = to - from;
    n = new vector<bool> (length);

    for(i = 0.0; i < length; i = i + 1.0){
      n->at(i) = a->at(from + i);
    }

    copyReference->booleanArray = n;
    success = true;
  }else{
    success = false;
  }

  return success;
}
bool arraysCopyStringRange(vector<wchar_t> *a, double from, double to, StringReference *copyReference){
  double i, length;
  vector<wchar_t> *n;
  bool success;

  if(from >= 0.0 && from <= (double)a->size() && to >= 0.0 && to <= (double)a->size() && from <= to){
    length = to - from;
    n = new vector<wchar_t> (length);

    for(i = 0.0; i < length; i = i + 1.0){
      n->at(i) = a->at(from + i);
    }

    copyReference->string = n;
    success = true;
  }else{
    success = false;
  }

  return success;
}
bool arraysIsLastElement(double length, double index){
  return index + 1.0 == length;
}
vector<double> *arraysCreateNumberArray(double length, double value){
  vector<double> *array;

  array = new vector<double> (length);
  arraysFillNumberArray(array, value);

  return array;
}
vector<bool> *arraysCreateBooleanArray(double length, bool value){
  vector<bool> *array;

  array = new vector<bool> (length);
  arraysFillBooleanArray(array, value);

  return array;
}
vector<wchar_t> *arraysCreateString(double length, wchar_t value){
  vector<wchar_t> *array;

  array = new vector<wchar_t> (length);
  arraysFillString(array, value);

  return array;
}
void arraysSwapElementsOfNumberArray(vector<double> *A, double ai, double bi){
  double tmp;

  tmp = A->at(ai);
  A->at(ai) = A->at(bi);
  A->at(bi) = tmp;
}
void arraysSwapElementsOfStringArray(StringArrayReference *A, double ai, double bi){
  StringReference *tmp;

  tmp = A->stringArray->at(ai);
  A->stringArray->at(ai) = A->stringArray->at(bi);
  A->stringArray->at(bi) = tmp;
}
void arraysReverseNumberArray(vector<double> *array){
  double i;

  for(i = 0.0; i < (double)array->size()/2.0; i = i + 1.0){
    arraysSwapElementsOfNumberArray(array, i, (double)array->size() - i - 1.0);
  }
}
vector<wchar_t> *CreateStringScientificNotationDecimalFromNumber(double n){
  StringReference *mantissaReference, *exponentReference;
  double e;
  bool isPositive;
  vector<wchar_t> *result;

  mantissaReference = new StringReference();
  exponentReference = new StringReference();
  result = new vector<wchar_t> (0.0);

  if(n < 0.0){
    isPositive = false;
    n =  -n;
  }else{
    isPositive = true;
  }

  if(n == 0.0){
    e = 0.0;
  }else{
    e = GetFirstDecimalDigitPosition(n);

    if(e < 0.0){
      n = n*pow(10.0, abs(e));
    }else{
      n = n/pow(10.0, e);
    }
  }

  mantissaReference->string = CreateStringDecimalFromNumber(n);
  exponentReference->string = CreateStringDecimalFromNumber(e);

  if( !isPositive ){
    result = strAppendString(result, toVector(L"-"));
  }

  result = strAppendString(result, mantissaReference->string);
  result = strAppendString(result, toVector(L"e"));
  result = strAppendString(result, exponentReference->string);

  return result;
}
vector<wchar_t> *CreateStringDecimalFromNumber(double number){
  DynamicArrayCharacters *string;
  double maximumDigits, i, d, digitPosition, trailingZeros;
  bool hasPrintedPoint, isPositive, done;
  CharacterReference *characterReference;
  wchar_t c;
  vector<wchar_t> *str;

  string = CreateDynamicArrayCharacters();
  isPositive = true;

  if(number < 0.0){
    isPositive = false;
    number =  -number;
  }

  if(number == 0.0){
    DynamicArrayAddCharacter(string, '0');
  }else{
    characterReference = new CharacterReference();

    maximumDigits = GetMaximumDigitsForDecimal();

    digitPosition = GetFirstDecimalDigitPosition(number);

    hasPrintedPoint = false;

    if( !isPositive ){
      DynamicArrayAddCharacter(string, '-');
    }

    /* Print leading zeros. */
    if(digitPosition < 0.0){
      DynamicArrayAddCharacter(string, '0');
      DynamicArrayAddCharacter(string, '.');
      hasPrintedPoint = true;
      for(i = 0.0; i <  -digitPosition - 1.0; i = i + 1.0){
        DynamicArrayAddCharacter(string, '0');
      }
    }

    /* Count trailing zeros */
    trailingZeros = 0.0;
    done = false;
    for(i = 0.0; i < maximumDigits &&  !done ; i = i + 1.0){
      d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, maximumDigits - i - 1.0);
      if(d == 0.0){
        trailingZeros = trailingZeros + 1.0;
      }else{
        done = true;
      }
    }

    /* Print number. */
    for(i = 0.0; i < maximumDigits; i = i + 1.0){
      d = GetDecimalDigitWithFirstDigitPosition(number, digitPosition, i);

      if( !hasPrintedPoint  && digitPosition - i + 1.0 == 0.0){
        if(maximumDigits - i > trailingZeros){
          DynamicArrayAddCharacter(string, '.');
        }
        hasPrintedPoint = true;
      }

      if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
      }else{
        GetDecimalDigitCharacterFromNumberWithCheck(d, characterReference);
        c = characterReference->characterValue;
        DynamicArrayAddCharacter(string, c);
      }
    }

    /* Print trailing zeros. */
    for(i = 0.0; i < digitPosition - maximumDigits + 1.0; i = i + 1.0){
      DynamicArrayAddCharacter(string, '0');
    }
  }

  /* Done */
  str = DynamicArrayCharactersToArray(string);
  FreeDynamicArrayCharacters(string);
  return str;
}
bool CreateStringFromNumberWithCheck(double number, double base, StringReference *stringRef){
  DynamicArrayCharacters *string;
  double maximumDigits, i, d, digitPosition, trailingZeros;
  bool success, hasPrintedPoint, isPositive, done;
  CharacterReference *characterReference;
  wchar_t c;

  string = CreateDynamicArrayCharacters();
  isPositive = true;

  if(number < 0.0){
    isPositive = false;
    number =  -number;
  }

  if(number == 0.0){
    DynamicArrayAddCharacter(string, '0');
    success = true;
  }else{
    characterReference = new CharacterReference();

    if(IsInteger(base)){
      success = true;

      maximumDigits = GetMaximumDigitsForBase(base);

      digitPosition = GetFirstDigitPosition(number, base);

      hasPrintedPoint = false;

      if( !isPositive ){
        DynamicArrayAddCharacter(string, '-');
      }

      /* Print leading zeros. */
      if(digitPosition < 0.0){
        DynamicArrayAddCharacter(string, '0');
        DynamicArrayAddCharacter(string, '.');
        hasPrintedPoint = true;
        for(i = 0.0; i <  -digitPosition - 1.0; i = i + 1.0){
          DynamicArrayAddCharacter(string, '0');
        }
      }

      /* Count trailing zeros */
      trailingZeros = 0.0;
      done = false;
      for(i = 0.0; i < maximumDigits &&  !done ; i = i + 1.0){
        d = GetDigit(number, base, maximumDigits - i - 1.0);
        if(d == 0.0){
          trailingZeros = trailingZeros + 1.0;
        }else{
          done = true;
        }
      }

      /* Print number. */
      for(i = 0.0; i < maximumDigits && success; i = i + 1.0){
        d = GetDigit(number, base, i);

        if(d >= base){
          d = base - 1.0;
        }

        if( !hasPrintedPoint  && digitPosition - i + 1.0 == 0.0){
          if(maximumDigits - i > trailingZeros){
            DynamicArrayAddCharacter(string, '.');
          }
          hasPrintedPoint = true;
        }

        if(maximumDigits - i <= trailingZeros && hasPrintedPoint){
        }else{
          success = GetSingleDigitCharacterFromNumberWithCheck(d, base, characterReference);
          if(success){
            c = characterReference->characterValue;
            DynamicArrayAddCharacter(string, c);
          }
        }
      }

      if(success){
        /* Print trailing zeros. */
        for(i = 0.0; i < digitPosition - maximumDigits + 1.0; i = i + 1.0){
          DynamicArrayAddCharacter(string, '0');
        }
      }
    }else{
      success = false;
    }
  }

  if(success){
    stringRef->string = DynamicArrayCharactersToArray(string);
    FreeDynamicArrayCharacters(string);
  }

  /* Done */
  return success;
}
double GetMaximumDigitsForBase(double base){
  double t;

  t = pow(10.0, 15.0);
  return floor(log10(t)/log10(base));
}
double GetMaximumDigitsForDecimal(){
  return 15.0;
}
double GetFirstDecimalDigitPosition(double n){
  double power, m, i;
  bool multiply, done;

  n = abs(n);

  if(n != 0.0){
    if(floor(n) < pow(10.0, 15.0)){
      multiply = true;
    }else{
      multiply = false;
    }

    done = false;
    m = 0.0;
    for(i = 0.0;  !done ; i = i + 1.0){
      if(multiply){
        m = n*pow(10.0, i);
        if(floor(m) >= pow(10.0, 14.0)){
          done = true;
        }
      }else{
        m = n/pow(10.0, i);
        if(floor(m) < pow(10.0, 15.0)){
          done = true;
        }
      }
    }

    if(multiply){
      power = 15.0 - i;
    }else{
      power = 15.0 + i - 2.0;
    }

    if(Round(m) >= pow(10.0, 15.0)){
      power = power + 1.0;
    }
  }else{
    power = 1.0;
  }

  return power;
}
double GetFirstDigitPosition(double n, double base){
  double power, m, i, maximumDigits;
  bool multiply, done;

  maximumDigits = GetMaximumDigitsForBase(base);
  n = abs(n);

  if(n != 0.0){
    if(floor(n) < pow(base, maximumDigits)){
      multiply = true;
    }else{
      multiply = false;
    }

    done = false;
    m = 0.0;
    for(i = 0.0;  !done ; i = i + 1.0){
      if(multiply){
        m = n*pow(base, i);
        if(floor(m) >= pow(base, maximumDigits - 1.0)){
          done = true;
        }
      }else{
        m = n/pow(base, i);
        if(floor(m) < pow(base, maximumDigits)){
          done = true;
        }
      }
    }

    if(multiply){
      power = maximumDigits - i;
    }else{
      power = maximumDigits + i - 2.0;
    }

    if(Round(m) >= pow(base, maximumDigits)){
      power = power + 1.0;
    }
  }else{
    power = 1.0;
  }

  return power;
}
bool GetSingleDigitCharacterFromNumberWithCheck(double c, double base, CharacterReference *characterReference){
  vector<wchar_t> *numberTable;
  bool success;

  numberTable = GetDigitCharacterTable();

  if(c < base || c < (double)numberTable->size()){
    success = true;
    characterReference->characterValue = numberTable->at(c);
  }else{
    success = false;
  }

  return success;
}
bool GetDecimalDigitCharacterFromNumberWithCheck(double c, CharacterReference *characterRef){
  vector<wchar_t> *numberTable;
  bool success;

  numberTable = toVector(L"0123456789");

  if(c >= 0.0 && c < 10.0){
    success = true;
    characterRef->characterValue = numberTable->at(c);
  }else{
    success = false;
  }

  return success;
}
vector<wchar_t> *GetDigitCharacterTable(){
  vector<wchar_t> *numberTable;

  numberTable = toVector(L"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");

  return numberTable;
}
double GetDecimalDigit(double n, double index){
  double digitPosition;

  digitPosition = GetFirstDecimalDigitPosition(n);

  return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index);
}
double GetDecimalDigitWithFirstDigitPosition(double n, double digitPosition, double index){
  double d, e, m, i;

  n = abs(n);

  e = 15.0 - digitPosition - 1.0;
  if(e < 0.0){
    n = round(n/pow(10.0, abs(e)));
  }else{
    n = round(n*pow(10.0, e));
  }

  m = n;
  d = 0.0;
  for(i = 0.0; i < 15.0 - index; i = i + 1.0){
    d = round(fmod(m, 10.0));
    m = m - d;
    m = round(m/10.0);
  }

  return d;
}
double GetDigit(double n, double base, double index){
  double d, digitPosition, e, m, maximumDigits, i;

  n = abs(n);
  maximumDigits = GetMaximumDigitsForBase(base);
  digitPosition = GetFirstDigitPosition(n, base);

  e = maximumDigits - digitPosition - 1.0;
  if(e < 0.0){
    n = round(n/pow(base, abs(e)));
  }else{
    n = round(n*pow(base, e));
  }

  m = n;
  d = 0.0;
  for(i = 0.0; i < maximumDigits - index; i = i + 1.0){
    d = round(fmod(m, base));
    m = m - d;
    m = round(m/base);
  }

  return d;
}
vector<wchar_t> *NumberToHumanReadableShortScale(double n){
  vector<wchar_t> *res, *suffix;
  bool hasSuffix;
  double k, M, B, T, Q;

  k = 1000.0;
  M = k*1000.0;
  B = M*1000.0;
  T = B*1000.0;
  Q = T*1000.0;
  suffix = toVector(L" ");

  if(n < k){
    hasSuffix = false;
  }else{
    hasSuffix = true;
  }

  if(n >= k && n < M){
    if(n < 10.0*k){
      n = Round(n/100.0);
      n = n/10.0;
    }else{
      n = Round(n/k);
    }
    suffix = toVector(L"k");
  }else if(n >= M && n < B){
    if(n < 10.0*M){
      n = Round(n/(k*100.0));
      n = n/10.0;
    }else{
      n = Round(n/M);
    }
    suffix = toVector(L"M");
  }else if(n >= B && n < T){
    if(n < 10.0*B){
      n = Round(n/(M*100.0));
      n = n/10.0;
    }else{
      n = Round(n/B);
    }
    suffix = toVector(L"B");
  }else if(n >= T && n < Q){
    if(n < 10.0*T){
      n = Round(n/(B*100.0));
      n = n/10.0;
    }else{
      n = Round(n/T);
    }
    suffix = toVector(L"T");
  }else if(n >= Q){
    if(n < 10.0*Q){
      n = Round(n/(T*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Q);
    }
    suffix = toVector(L"Q");
  }

  res = CreateStringDecimalFromNumber(n);
  if(hasSuffix){
    res = strAppendString(res, suffix);
  }
        
  return res;
}
vector<wchar_t> *NumberToHumanReadableBinary(double n){
  vector<wchar_t> *res, *suffix;
  bool hasSuffix;
  double Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi;

  Ki = 1024.0;
  Mi = Ki*1024.0;
  Gi = Mi*1024.0;
  Ti = Gi*1024.0;
  Pi = Ti*1024.0;
  Ei = Pi*1024.0;
  Zi = Ei*1024.0;
  Yi = Zi*1024.0;
  suffix = toVector(L" ");

  if(n < Ki){
    hasSuffix = false;
  }else{
    hasSuffix = true;
  }

  if(n >= Ki && n < Mi){
    if(n < 10.0*Ki){
      n = Round(n/(Ki/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Ki);
    }
    suffix = toVector(L"Ki");
  }else if(n >= Mi && n < Gi){
    if(n < 10.0*Mi){
      n = Round(n/(Mi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Mi);
    }
    suffix = toVector(L"Mi");
  }else if(n >= Gi && n < Ti){
    if(n < 10.0*Gi){
      n = Round(n/(Gi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Gi);
    }
    suffix = toVector(L"Gi");
  }else if(n >= Ti && n < Pi){
    if(n < 10.0*Ti){
      n = Round(n/(Ti/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Ti);
    }
    suffix = toVector(L"Ti");
  }else if(n >= Pi && n < Ei){
    if(n < 10.0*Pi){
      n = Round(n/(Pi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Pi);
    }
    suffix = toVector(L"Pi");
  }else if(n >= Ei && n < Zi){
    if(n < 10.0*Ei){
      n = Round(n/(Ei/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Ei);
    }
    suffix = toVector(L"Ei");
  }else if(n >= Zi && n < Yi){
    if(n < 10.0*Zi){
      n = Round(n/(Zi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Zi);
    }
    suffix = toVector(L"Zi");
  }else if(n >= Yi){
    if(n < 10.0*Yi){
      n = Round(n/(Yi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Yi);
    }
    suffix = toVector(L"Yi");
  }

  res = CreateStringDecimalFromNumber(n);
  if(hasSuffix){
    res = strAppendString(res, suffix);
  }

  return res;
}
vector<wchar_t> *NumberToHumanReadableMetric(double n){
  vector<wchar_t> *res, *suffix;
  bool hasSuffix;
  double k, M, G, T, P, Ex, Z, Y, R, Q;

  k = 1000.0;
  M = k*1000.0;
  G = M*1000.0;
  T = G*1000.0;
  P = T*1000.0;
  Ex = P*1000.0;
  Z = Ex*1000.0;
  Y = Z*1000.0;
  R = Y*1000.0;
  Q = R*1000.0;
  suffix = toVector(L" ");

  if(n < k){
    hasSuffix = false;
  }else{
    hasSuffix = true;
  }

  if(n >= k && n < M){
    if(n < 10.0*k){
      n = Round(n/100.0);
      n = n/10.0;
    }else{
      n = Round(n/k);
    }
    suffix = toVector(L"k");
  }else if(n >= M && n < G){
    if(n < 10.0*M){
      n = Round(n/(k*100.0));
      n = n/10.0;
    }else{
      n = Round(n/M);
    }
    suffix = toVector(L"M");
  }else if(n >= G && n < T){
    if(n < 10.0*G){
      n = Round(n/(M*100.0));
      n = n/10.0;
    }else{
      n = Round(n/G);
    }
    suffix = toVector(L"G");
  }else if(n >= T && n < P){
    if(n < 10.0*T){
      n = Round(n/(G*100.0));
      n = n/10.0;
    }else{
      n = Round(n/T);
    }
    suffix = toVector(L"T");
  }else if(n >= P && n < Ex){
    if(n < 10.0*P){
      n = Round(n/(T*100.0));
      n = n/10.0;
    }else{
      n = Round(n/P);
    }
    suffix = toVector(L"P");
  }else if(n >= Ex && n < Z){
    if(n < 10.0*Ex){
      n = Round(n/(P*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Ex);
    }
    suffix = toVector(L"E");
  }else if(n >= Z && n < Y){
    if(n < 10.0*Z){
      n = Round(n/(Ex*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Z);
    }
    suffix = toVector(L"Z");
  }else if(n >= Y && n < R){
    if(n < 10.0*Y){
      n = Round(n/(Z*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Y);
    }
    suffix = toVector(L"Y");
  }else if(n >= R && n < Q){
    if(n < 10.0*R){
      n = Round(n/(Y*100.0));
      n = n/10.0;
    }else{
      n = Round(n/R);
    }
    suffix = toVector(L"R");
  }else if(n >= Q){
    if(n < 10.0*Q){
      n = Round(n/(R*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Q);
    }
    suffix = toVector(L"Q");
  }

  res = CreateStringDecimalFromNumber(n);
  if(hasSuffix){
    res = strAppendString(res, suffix);
  }

  return res;
}
bool IsValidNumber(vector<wchar_t> *str){
  bool valid;
  NumberReference *numberRef;
  StringReference *message;

  numberRef = new NumberReference();
  message = new StringReference();

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

  delete numberRef;
  delete message;

  return valid;
}
bool IsValidInteger(vector<wchar_t> *str){
  bool valid;
  NumberReference *numberRef;
  StringReference *message;

  numberRef = new NumberReference();
  message = new StringReference();

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

  if(valid){
    valid = IsInteger(numberRef->numberValue);
  }

  delete numberRef;
  delete message;

  return valid;
}
bool IsValidPositiveInteger(vector<wchar_t> *str){
  bool valid;
  NumberReference *numberRef;
  StringReference *message;

  numberRef = new NumberReference();
  message = new StringReference();

  valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

  if(valid){
    valid = IsInteger(numberRef->numberValue);
    if(valid){
      valid = numberRef->numberValue >= 0.0;
    }
  }

  delete numberRef;
  delete message;

  return valid;
}
bool CreateNumberFromDecimalStringWithCheck(vector<wchar_t> *string, NumberReference *decimalReference, StringReference *message){
  return CreateNumberFromStringWithCheck(string, 10.0, decimalReference, message);
}
double CreateNumberFromDecimalString(vector<wchar_t> *string){
  NumberReference *doubleReference;
  StringReference *stringReference;
  double number;

  doubleReference = CreateNumberReference(0.0);
  stringReference = CreateStringReference(toVector(L""));
  CreateNumberFromStringWithCheck(string, 10.0, doubleReference, stringReference);
  number = doubleReference->numberValue;

  delete doubleReference;
  delete stringReference;

  return number;
}
bool CreateNumberFromStringWithCheck(vector<wchar_t> *string, double base, NumberReference *numberReference, StringReference *message){
  bool success;
  BooleanReference *numberIsPositive, *exponentIsPositive;
  NumberArrayReference *beforePoint, *afterPoint, *exponent;

  numberIsPositive = CreateBooleanReference(true);
  exponentIsPositive = CreateBooleanReference(true);
  beforePoint = new NumberArrayReference();
  afterPoint = new NumberArrayReference();
  exponent = new NumberArrayReference();

  if(base >= 2.0 && base <= 36.0){
    success = ExtractPartsFromNumberString(string, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

    if(success){
      numberReference->numberValue = CreateNumberFromParts(base, numberIsPositive->booleanValue, beforePoint->numberArray, afterPoint->numberArray, exponentIsPositive->booleanValue, exponent->numberArray);
    }
  }else{
    success = false;
    message->string = toVector(L"Base must be from 2 to 36.");
  }

  return success;
}
double CreateNumberFromParts(double base, bool numberIsPositive, vector<double> *beforePoint, vector<double> *afterPoint, bool exponentIsPositive, vector<double> *exponent){
  double n, i, p, e;

  n = 0.0;

  for(i = 0.0; i < (double)beforePoint->size(); i = i + 1.0){
    p = beforePoint->at((double)beforePoint->size() - i - 1.0);

    n = n + p*pow(base, i);
  }

  for(i = 0.0; i < (double)afterPoint->size(); i = i + 1.0){
    p = afterPoint->at(i);

    n = n + p/pow(base, i + 1.0);
  }

  if((double)exponent->size() > 0.0){
    e = 0.0;
    for(i = 0.0; i < (double)exponent->size(); i = i + 1.0){
      p = exponent->at((double)exponent->size() - i - 1.0);

      e = e + p*pow(base, i);
    }

    if( !exponentIsPositive ){
      e =  -e;
    }

    n = n*pow(base, e);
  }

  if( !numberIsPositive ){
    n =  -n;
  }

  return n;
}
bool ExtractPartsFromNumberString(vector<wchar_t> *n, double base, BooleanReference *numberIsPositive, NumberArrayReference *beforePoint, NumberArrayReference *afterPoint, BooleanReference *exponentIsPositive, NumberArrayReference *exponent, StringReference *errorMessages){
  double i, j, count;
  bool success, done, complete;

  i = 0.0;
  complete = false;

  if(i < (double)n->size()){
    if(n->at(i) == '-'){
      numberIsPositive->booleanValue = false;
      i = i + 1.0;
    }else if(n->at(i) == '+'){
      numberIsPositive->booleanValue = true;
      i = i + 1.0;
    }

    success = true;
  }else{
    success = false;
    errorMessages->string = toVector(L"Number cannot have length zero.");
  }

  if(success){
    done = false;
    count = 0.0;
    for(; i + count < (double)n->size() &&  !done ; ){
      if(CharacterIsNumberCharacterInBase(n->at(i + count), base)){
        count = count + 1.0;
      }else{
        done = true;
      }
    }

    if(count >= 1.0){
      beforePoint->numberArray = new vector<double> (count);

      for(j = 0.0; j < count; j = j + 1.0){
        beforePoint->numberArray->at(j) = GetNumberFromNumberCharacterForBase(n->at(i + j), base);
      }

      i = i + count;

      if(i < (double)n->size()){
        success = true;
      }else{
        afterPoint->numberArray = new vector<double> (0.0);
        exponent->numberArray = new vector<double> (0.0);
        success = true;
        complete = true;
      }
    }else{
      success = false;
      errorMessages->string = toVector(L"Number must have at least one number after the optional sign.");
    }
  }

  if(success &&  !complete ){
    if(n->at(i) == '.'){
      i = i + 1.0;

      if(i < (double)n->size()){
        done = false;
        count = 0.0;
        for(; i + count < (double)n->size() &&  !done ; ){
          if(CharacterIsNumberCharacterInBase(n->at(i + count), base)){
            count = count + 1.0;
          }else{
            done = true;
          }
        }

        if(count >= 1.0){
          afterPoint->numberArray = new vector<double> (count);

          for(j = 0.0; j < count; j = j + 1.0){
            afterPoint->numberArray->at(j) = GetNumberFromNumberCharacterForBase(n->at(i + j), base);
          }

          i = i + count;

          if(i < (double)n->size()){
            success = true;
          }else{
            exponent->numberArray = new vector<double> (0.0);
            success = true;
            complete = true;
          }
        }else{
          success = false;
          errorMessages->string = toVector(L"There must be at least one digit after the decimal point.");
        }
      }else{
        success = false;
        errorMessages->string = toVector(L"There must be at least one digit after the decimal point.");
      }
    }else if(base <= 14.0 && (n->at(i) == 'e' || n->at(i) == 'E')){
      if(i < (double)n->size()){
        success = true;
        afterPoint->numberArray = new vector<double> (0.0);
      }else{
        success = false;
        errorMessages->string = toVector(L"There must be at least one digit after the exponent.");
      }
    }else{
      success = false;
      errorMessages->string = toVector(L"Expected decimal point or exponent symbol.");
    }
  }

  if(success &&  !complete ){
    if(base <= 14.0 && (n->at(i) == 'e' || n->at(i) == 'E')){
      i = i + 1.0;

      if(i < (double)n->size()){
        if(n->at(i) == '-'){
          exponentIsPositive->booleanValue = false;
          i = i + 1.0;
        }else if(n->at(i) == '+'){
          exponentIsPositive->booleanValue = true;
          i = i + 1.0;
        }

        if(i < (double)n->size()){
          done = false;
          count = 0.0;
          for(; i + count < (double)n->size() &&  !done ; ){
            if(CharacterIsNumberCharacterInBase(n->at(i + count), base)){
              count = count + 1.0;
            }else{
              done = true;
            }
          }

          if(count >= 1.0){
            exponent->numberArray = new vector<double> (count);

            for(j = 0.0; j < count; j = j + 1.0){
              exponent->numberArray->at(j) = GetNumberFromNumberCharacterForBase(n->at(i + j), base);
            }

            i = i + count;

            if(i == (double)n->size()){
              success = true;
            }else{
              success = false;
              errorMessages->string = toVector(L"There cannot be any characters past the exponent of the number.");
            }
          }else{
            success = false;
            errorMessages->string = toVector(L"There must be at least one digit after the decimal point.");
          }
        }else{
          success = false;
          errorMessages->string = toVector(L"There must be at least one digit after the exponent symbol.");
        }
      }else{
        success = false;
        errorMessages->string = toVector(L"There must be at least one digit after the exponent symbol.");
      }
    }else{
      success = false;
      errorMessages->string = toVector(L"Expected exponent symbol.");
    }
  }

  return success;
}
double GetNumberFromNumberCharacterForBase(wchar_t c, double base){
  vector<wchar_t> *numberTable;
  double i;
  double position;

  numberTable = GetDigitCharacterTable();
  position = 0.0;

  for(i = 0.0; i < base; i = i + 1.0){
    if(numberTable->at(i) == c){
      position = i;
    }
  }

  return position;
}
bool CharacterIsNumberCharacterInBase(wchar_t c, double base){
  vector<wchar_t> *numberTable;
  double i;
  bool found;

  numberTable = GetDigitCharacterTable();
  found = false;

  for(i = 0.0; i < base; i = i + 1.0){
    if(numberTable->at(i) == c){
      found = true;
    }
  }

  return found;
}
vector<double> *StringToNumberArray(vector<wchar_t> *str){
  NumberArrayReference *numberArrayReference;
  StringReference *stringReference;
  vector<double> *numbers;

  numberArrayReference = new NumberArrayReference();
  stringReference = new StringReference();

  StringToNumberArrayWithCheck(str, numberArrayReference, stringReference);

  numbers = numberArrayReference->numberArray;

  delete numberArrayReference;
  delete stringReference;

  return numbers;
}
bool StringToNumberArrayWithCheck(vector<wchar_t> *str, NumberArrayReference *numberArrayReference, StringReference *errorMessage){
  vector<StringReference*> *numberStrings;
  vector<double> *numbers;
  double i;
  vector<wchar_t> *numberString, *trimmedNumberString;
  bool success;
  NumberReference *numberReference;

  numberStrings = strSplitByString(str, toVector(L","));

  numbers = new vector<double> ((double)numberStrings->size());
  success = true;
  numberReference = new NumberReference();

  for(i = 0.0; i < (double)numberStrings->size(); i = i + 1.0){
    numberString = numberStrings->at(i)->string;
    trimmedNumberString = strTrim(numberString);
    success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage);
    numbers->at(i) = numberReference->numberValue;

    FreeStringReference(numberStrings->at(i));
    delete trimmedNumberString;
  }

  delete numberStrings;
  delete numberReference;

  numberArrayReference->numberArray = numbers;

  return success;
}
void strWriteStringToStingStream(vector<wchar_t> *stream, NumberReference *index, vector<wchar_t> *src){
  double i;

  for(i = 0.0; i < (double)src->size(); i = i + 1.0){
    stream->at(index->numberValue + i) = src->at(i);
  }
  index->numberValue = index->numberValue + (double)src->size();
}
void strWriteCharacterToStingStream(vector<wchar_t> *stream, NumberReference *index, wchar_t src){
  stream->at(index->numberValue) = src;
  index->numberValue = index->numberValue + 1.0;
}
void strWriteBooleanToStingStream(vector<wchar_t> *stream, NumberReference *index, bool src){
  if(src){
    strWriteStringToStingStream(stream, index, toVector(L"true"));
  }else{
    strWriteStringToStingStream(stream, index, toVector(L"false"));
  }
}
bool strSubstringWithCheck(vector<wchar_t> *string, double from, double to, StringReference *stringReference){
  bool success;

  if(from >= 0.0 && from <= (double)string->size() && to >= 0.0 && to <= (double)string->size() && from <= to){
    stringReference->string = strSubstring(string, from, to);
    success = true;
  }else{
    success = false;
  }

  return success;
}
vector<wchar_t> *strSubstring(vector<wchar_t> *string, double from, double to){
  vector<wchar_t> *n;
  double i, length;

  length = to - from;

  n = new vector<wchar_t> (length);

  for(i = from; i < to; i = i + 1.0){
    n->at(i - from) = string->at(i);
  }

  return n;
}
vector<wchar_t> *strAppendString(vector<wchar_t> *s1, vector<wchar_t> *s2){
  vector<wchar_t> *newString;

  newString = strConcatenateString(s1, s2);

  delete s1;

  return newString;
}
vector<wchar_t> *strConcatenateString(vector<wchar_t> *s1, vector<wchar_t> *s2){
  vector<wchar_t> *newString;
  double i;

  newString = new vector<wchar_t> ((double)s1->size() + (double)s2->size());

  for(i = 0.0; i < (double)s1->size(); i = i + 1.0){
    newString->at(i) = s1->at(i);
  }

  for(i = 0.0; i < (double)s2->size(); i = i + 1.0){
    newString->at((double)s1->size() + i) = s2->at(i);
  }

  return newString;
}
vector<wchar_t> *strAppendCharacter(vector<wchar_t> *string, wchar_t c){
  vector<wchar_t> *newString;

  newString = strConcatenateCharacter(string, c);

  delete string;

  return newString;
}
vector<wchar_t> *strConcatenateCharacter(vector<wchar_t> *string, wchar_t c){
  vector<wchar_t> *newString;
  double i;
  newString = new vector<wchar_t> ((double)string->size() + 1.0);

  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    newString->at(i) = string->at(i);
  }

  newString->at((double)string->size()) = c;

  return newString;
}
vector<StringReference*> *strSplitByCharacter(vector<wchar_t> *toSplit, wchar_t splitBy){
  vector<StringReference*> *parts;
  double i;
  wchar_t c;
  LinkedListStrings *ll;
  LinkedListCharacters *next;
  vector<wchar_t> *part;

  ll = CreateLinkedListString();

  next = CreateLinkedListCharacter();
  for(i = 0.0; i < (double)toSplit->size(); i = i + 1.0){
    c = toSplit->at(i);

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
bool strIndexOfCharacter(vector<wchar_t> *string, wchar_t character, NumberReference *indexReference){
  double i;
  bool found;

  found = false;
  for(i = 0.0; i < (double)string->size() &&  !found ; i = i + 1.0){
    if(string->at(i) == character){
      found = true;
      indexReference->numberValue = i;
    }
  }

  return found;
}
bool strLastIndexOfCharacter(vector<wchar_t> *string, wchar_t character, NumberReference *indexReference){
  double i;
  bool found;

  found = false;
  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    if(string->at(i) == character){
      found = true;
      indexReference->numberValue = i;
    }
  }

  return found;
}
bool strSubstringEqualsWithCheck(vector<wchar_t> *string, double from, vector<wchar_t> *substring, BooleanReference *equalsReference){
  bool success;

  if(from < (double)string->size()){
    success = true;
    equalsReference->booleanValue = strSubstringEquals(string, from, substring);
  }else{
    success = false;
  }

  return success;
}
bool strSubstringEquals(vector<wchar_t> *string, double from, vector<wchar_t> *substring){
  double i;
  bool equal;

  equal = true;
  if((double)string->size() - from >= (double)substring->size()){
    for(i = 0.0; i < (double)substring->size() && equal; i = i + 1.0){
      if(string->at(from + i) != substring->at(i)){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
bool strIndexOfString(vector<wchar_t> *string, vector<wchar_t> *substring, NumberReference *indexReference){
  double i;
  bool found;

  found = false;
  for(i = 0.0; i < (double)string->size() - (double)substring->size() + 1.0 &&  !found ; i = i + 1.0){
    if(strSubstringEquals(string, i, substring)){
      found = true;
      indexReference->numberValue = i;
    }
  }

  return found;
}
bool strContainsCharacter(vector<wchar_t> *string, wchar_t character){
  double i;
  bool found;

  found = false;
  for(i = 0.0; i < (double)string->size() &&  !found ; i = i + 1.0){
    if(string->at(i) == character){
      found = true;
    }
  }

  return found;
}
bool strContainsString(vector<wchar_t> *string, vector<wchar_t> *substring){
  return strIndexOfString(string, substring, new NumberReference());
}
void strToUpperCase(vector<wchar_t> *string){
  double i;

  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    string->at(i) = cToUpperCase(string->at(i));
  }
}
void strToLowerCase(vector<wchar_t> *string){
  double i;

  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    string->at(i) = cToLowerCase(string->at(i));
  }
}
bool strEqualsIgnoreCase(vector<wchar_t> *a, vector<wchar_t> *b){
  bool equal;
  double i;

  if((double)a->size() == (double)b->size()){
    equal = true;
    for(i = 0.0; i < (double)a->size() && equal; i = i + 1.0){
      if(cToLowerCase(a->at(i)) != cToLowerCase(b->at(i))){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
vector<wchar_t> *strReplaceString(vector<wchar_t> *string, vector<wchar_t> *toReplace, vector<wchar_t> *replaceWith){
  vector<wchar_t> *result;
  double i, j;
  BooleanReference *equalsReference;
  bool success;
  DynamicArrayCharacters *da;

  da = CreateDynamicArrayCharacters();

  equalsReference = new BooleanReference();

  for(i = 0.0; i < (double)string->size(); ){
    success = strSubstringEqualsWithCheck(string, i, toReplace, equalsReference);
    if(success){
      success = equalsReference->booleanValue;
    }

    if(success && (double)toReplace->size() > 0.0){
      for(j = 0.0; j < (double)replaceWith->size(); j = j + 1.0){
        DynamicArrayAddCharacter(da, replaceWith->at(j));
      }
      i = i + (double)toReplace->size();
    }else{
      DynamicArrayAddCharacter(da, string->at(i));
      i = i + 1.0;
    }
  }

  result = DynamicArrayCharactersToArray(da);

  FreeDynamicArrayCharacters(da);

  return result;
}
vector<wchar_t> *strReplaceCharacterToNew(vector<wchar_t> *string, wchar_t toReplace, wchar_t replaceWith){
  vector<wchar_t> *result;
  double i;

  result = new vector<wchar_t> ((double)string->size());

  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    if(string->at(i) == toReplace){
      result->at(i) = replaceWith;
    }else{
      result->at(i) = string->at(i);
    }
  }

  return result;
}
void strReplaceCharacter(vector<wchar_t> *string, wchar_t toReplace, wchar_t replaceWith){
  double i;

  for(i = 0.0; i < (double)string->size(); i = i + 1.0){
    if(string->at(i) == toReplace){
      string->at(i) = replaceWith;
    }
  }
}
vector<wchar_t> *strTrim(vector<wchar_t> *string){
  vector<wchar_t> *result;
  double i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd;
  bool firstNonWhitespaceFound;

  /* Find whitepaces at the start. */
  lastWhitespaceLocationStart =  -1.0;
  firstNonWhitespaceFound = false;
  for(i = 0.0; i < (double)string->size() &&  !firstNonWhitespaceFound ; i = i + 1.0){
    if(cIsWhiteSpace(string->at(i))){
      lastWhitespaceLocationStart = i;
    }else{
      firstNonWhitespaceFound = true;
    }
  }

  /* Find whitepaces at the end. */
  lastWhitespaceLocationEnd = (double)string->size();
  firstNonWhitespaceFound = false;
  for(i = (double)string->size() - 1.0; i >= 0.0 &&  !firstNonWhitespaceFound ; i = i - 1.0){
    if(cIsWhiteSpace(string->at(i))){
      lastWhitespaceLocationEnd = i;
    }else{
      firstNonWhitespaceFound = true;
    }
  }

  if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
    result = strSubstring(string, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd);
  }else{
    result = new vector<wchar_t> (0.0);
  }

  return result;
}
bool strStartsWith(vector<wchar_t> *string, vector<wchar_t> *start){
  bool startsWithString;

  startsWithString = false;
  if((double)string->size() >= (double)start->size()){
    startsWithString = strSubstringEquals(string, 0.0, start);
  }

  return startsWithString;
}
bool strEndsWith(vector<wchar_t> *string, vector<wchar_t> *end){
  bool endsWithString;

  endsWithString = false;
  if((double)string->size() >= (double)end->size()){
    endsWithString = strSubstringEquals(string, (double)string->size() - (double)end->size(), end);
  }

  return endsWithString;
}
vector<StringReference*> *strSplitByString(vector<wchar_t> *toSplit, vector<wchar_t> *splitBy){
  vector<StringReference*> *parts;
  double i;
  wchar_t c;
  LinkedListStrings *ll;
  LinkedListCharacters *next;
  vector<wchar_t> *part;

  ll = CreateLinkedListString();

  next = CreateLinkedListCharacter();
  for(i = 0.0; i < (double)toSplit->size(); ){
    c = toSplit->at(i);

    if(strSubstringEquals(toSplit, i, splitBy)){
      part = LinkedListCharactersToArray(next);
      LinkedListAddString(ll, part);
      FreeLinkedListCharacter(next);
      next = CreateLinkedListCharacter();
      i = i + (double)splitBy->size();
    }else{
      LinkedListAddCharacter(next, c);
      i = i + 1.0;
    }
  }

  part = LinkedListCharactersToArray(next);
  LinkedListAddString(ll, part);
  FreeLinkedListCharacter(next);

  parts = LinkedListStringsToArray(ll);
  FreeLinkedListString(ll);

  return parts;
}
bool strStringIsBefore(vector<wchar_t> *a, vector<wchar_t> *b){
  bool before, equal, done;
  double i;

  before = false;
  equal = true;
  done = false;

  if((double)a->size() == 0.0 && (double)b->size() > 0.0){
    before = true;
  }else{
    for(i = 0.0; i < (double)a->size() && i < (double)b->size() &&  !done ; i = i + 1.0){
      if(a->at(i) != b->at(i)){
        equal = false;
      }
      if(cCharacterIsBefore(a->at(i), b->at(i))){
        before = true;
      }
      if(cCharacterIsBefore(b->at(i), a->at(i))){
        done = true;
      }
    }

    if(equal){
      if((double)a->size() < (double)b->size()){
        before = true;
      }
    }
  }

  return before;
}
vector<wchar_t> *strJoinStringsWithSeparator(vector<StringReference*> *strings, vector<wchar_t> *separator){
  vector<wchar_t> *result, *string;
  double length, i;
  NumberReference *index;

  index = CreateNumberReference(0.0);

  length = 0.0;
  for(i = 0.0; i < (double)strings->size(); i = i + 1.0){
    length = length + (double)strings->at(i)->string->size();
  }
  length = length + ((double)strings->size() - 1.0)*(double)separator->size();

  result = new vector<wchar_t> (length);

  for(i = 0.0; i < (double)strings->size(); i = i + 1.0){
    string = strings->at(i)->string;
    strWriteStringToStingStream(result, index, string);
    if(i + 1.0 < (double)strings->size()){
      strWriteStringToStingStream(result, index, separator);
    }
  }

  delete index;

  return result;
}
vector<wchar_t> *strJoinStrings(vector<StringReference*> *strings){
  vector<wchar_t> *result, *string;
  double length, i;
  NumberReference *index;

  index = CreateNumberReference(0.0);

  length = 0.0;
  for(i = 0.0; i < (double)strings->size(); i = i + 1.0){
    length = length + (double)strings->at(i)->string->size();
  }

  result = new vector<wchar_t> (length);

  for(i = 0.0; i < (double)strings->size(); i = i + 1.0){
    string = strings->at(i)->string;
    strWriteStringToStingStream(result, index, string);
  }

  delete index;

  return result;
}
double strStringOrder(vector<wchar_t> *a, vector<wchar_t> *b){
  double order, minimum, i, ac, bc;
  bool done;

  minimum = fmin((double)a->size(), (double)b->size());

  done = false;
  order = 0.0;
  for(i = 0.0; i < minimum &&  !done ; i = i + 1.0){
    ac = a->at(i);
    bc = b->at(i);

    if(ac < bc){
      done = true;
      order = 1.0;
    }else if(ac > bc){
      done = true;
      order =  -1.0;
    }
  }

  if( !done ){
    if((double)a->size() < (double)b->size()){
      order = 1.0;
    }else if((double)a->size() > (double)b->size()){
      order =  -1.0;
    }
  }

  return order;
}
vector<wchar_t> *strLeftPad(vector<wchar_t> *str, double width){
  double i;
  vector<wchar_t> *padded;

  padded = new vector<wchar_t> (width);
  arraysFillString(padded, ' ');

  for(i = 0.0; i < (double)str->size(); i = i + 1.0){
    padded->at(width - (double)str->size() + i) = str->at(i);
  }

  return padded;
}
vector<wchar_t> *strRightPad(vector<wchar_t> *str, double width){
  double i;
  vector<wchar_t> *padded;

  padded = new vector<wchar_t> (width);
  arraysFillString(padded, ' ');

  for(i = 0.0; i < (double)str->size(); i = i + 1.0){
    padded->at(i) = str->at(i);
  }

  return padded;
}
void AssertFalse(bool b, NumberReference *failures){
  if(b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertTrue(bool b, NumberReference *failures){
  if( !b ){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertEquals(double a, double b, NumberReference *failures){
  if(a != b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertBooleansEqual(bool a, bool b, NumberReference *failures){
  if(a != b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertCharactersEqual(wchar_t a, wchar_t b, NumberReference *failures){
  if(a != b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertStringEquals(vector<wchar_t> *a, vector<wchar_t> *b, NumberReference *failures){
  if( !arraysStringsEqual(a, b) ){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertNumberArraysEqual(vector<double> *a, vector<double> *b, NumberReference *failures){
  double i;

  if((double)a->size() == (double)b->size()){
    for(i = 0.0; i < (double)a->size(); i = i + 1.0){
      AssertEquals(a->at(i), b->at(i), failures);
    }
  }else{
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertBooleanArraysEqual(vector<bool> *a, vector<bool> *b, NumberReference *failures){
  double i;

  if((double)a->size() == (double)b->size()){
    for(i = 0.0; i < (double)a->size(); i = i + 1.0){
      AssertBooleansEqual(a->at(i), b->at(i), failures);
    }
  }else{
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertStringArraysEqual(vector<StringReference*> *a, vector<StringReference*> *b, NumberReference *failures){
  double i;

  if((double)a->size() == (double)b->size()){
    for(i = 0.0; i < (double)a->size(); i = i + 1.0){
      AssertStringEquals(a->at(i)->string, b->at(i)->string, failures);
    }
  }else{
    failures->numberValue = failures->numberValue + 1.0;
  }
}
double Negate(double x){
  return  -x;
}
double Positive(double x){
  return  +x;
}
double Factorial(double x){
  double i, f;

  f = 1.0;

  for(i = 2.0; i <= x; i = i + 1.0){
    f = f*i;
  }

  return f;
}
double Round(double x){
  return floor(x + 0.5);
}
double RoundToDigits(double element, double digitsAfterPoint){
  return Round(element*pow(10.0, digitsAfterPoint))/pow(10.0, digitsAfterPoint);
}
double BankersRound(double x){
  double r;

  if(Absolute(x - Truncate(x)) == 0.5){
    if( !DivisibleBy(Round(x), 2.0) ){
      r = Round(x) - 1.0;
    }else{
      r = Round(x);
    }
  }else{
    r = Round(x);
  }

  return r;
}
double Ceil(double x){
  return ceil(x);
}
double Floor(double x){
  return floor(x);
}
double Truncate(double x){
  double t;

  if(x >= 0.0){
    t = floor(x);
  }else{
    t = ceil(x);
  }

  return t;
}
double Absolute(double x){
  return abs(x);
}
double Logarithm(double x){
  return log10(x);
}
double NaturalLogarithm(double x){
  return log(x);
}
double Sin(double x){
  return sin(x);
}
double Cos(double x){
  return cos(x);
}
double Tan(double x){
  return tan(x);
}
double Asin(double x){
  return asin(x);
}
double Acos(double x){
  return acos(x);
}
double Atan(double x){
  return atan(x);
}
double Atan2(double y, double x){
  double a;

  /* Atan2 is an invalid operation when x = 0 and y = 0, but this method does not return errors. */
  a = 0.0;

  if(x > 0.0){
    a = Atan(y/x);
  }else if(x < 0.0 && y >= 0.0){
    a = Atan(y/x) + M_PI;
  }else if(x < 0.0 && y < 0.0){
    a = Atan(y/x) - M_PI;
  }else if(x == 0.0 && y > 0.0){
    a = M_PI/2.0;
  }else if(x == 0.0 && y < 0.0){
    a =  -M_PI/2.0;
  }

  return a;
}
double Squareroot(double x){
  return sqrt(x);
}
double Exp(double x){
  return exp(x);
}
bool DivisibleBy(double a, double b){
  return ((fmod(a, b)) == 0.0);
}
double Combinations(double n, double k){
  double i, j, c;

  c = 1.0;
  j = 1.0;
  i = n - k + 1.0;

  for(; i <= n; ){
    c = c*i;
    c = c/j;

    i = i + 1.0;
    j = j + 1.0;
  }

  return c;
}
double Permutations(double n, double k){
  double i, c;

  c = 1.0;

  for(i = n - k + 1.0; i <= n; i = i + 1.0){
    c = c*i;
  }

  return c;
}
bool EpsilonCompare(double a, double b, double epsilon){
  return abs(a - b) < epsilon;
}
double GreatestCommonDivisor(double a, double b){
  double t;

  for(; b != 0.0; ){
    t = b;
    b = fmod(a, b);
    a = t;
  }

  return a;
}
double GCDWithSubtraction(double a, double b){
  double g;

  if(a == 0.0){
    g = b;
  }else{
    for(; b != 0.0; ){
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
bool IsInteger(double a){
  return (a - floor(a)) == 0.0;
}
bool GreatestCommonDivisorWithCheck(double a, double b, NumberReference *gcdReference){
  bool success;
  double gcd;

  if(IsInteger(a) && IsInteger(b)){
    gcd = GreatestCommonDivisor(a, b);
    gcdReference->numberValue = gcd;
    success = true;
  }else{
    success = false;
  }

  return success;
}
double LeastCommonMultiple(double a, double b){
  double lcm;

  if(a > 0.0 && b > 0.0){
    lcm = abs(a*b)/GreatestCommonDivisor(a, b);
  }else{
    lcm = 0.0;
  }

  return lcm;
}
double Sign(double a){
  double s;

  if(a > 0.0){
    s = 1.0;
  }else if(a < 0.0){
    s =  -1.0;
  }else{
    s = 0.0;
  }

  return s;
}
double Max(double a, double b){
  return fmax(a, b);
}
double Min(double a, double b){
  return fmin(a, b);
}
double Power(double a, double b){
  return pow(a, b);
}
double Gamma(double x){
  return LanczosApproximation(x);
}
double LogGamma(double x){
  return log(Gamma(x));
}
double LanczosApproximation(double z){
  vector<double> *p;
  double i, y, t, x;

  p = new vector<double> (8.0);
  p->at(0) = 676.5203681218851;
  p->at(1) =  -1259.1392167224028;
  p->at(2) = 771.32342877765313;
  p->at(3) =  -176.61502916214059;
  p->at(4) = 12.507343278686905;
  p->at(5) =  -0.13857109526572012;
  p->at(6) = 9.9843695780195716e-6;
  p->at(7) = 1.5056327351493116e-7;

  if(z < 0.5){
    y = M_PI/(sin(M_PI*z)*LanczosApproximation(1.0 - z));
  }else{
    z = z - 1.0;
    x = 0.99999999999980993;
    for(i = 0.0; i < (double)p->size(); i = i + 1.0){
      x = x + p->at(i)/(z + i + 1.0);
    }
    t = z + (double)p->size() - 0.5;
    y = sqrt(2.0*M_PI)*pow(t, z + 0.5)*exp( -t)*x;
  }

  return y;
}
double Beta(double x, double y){
  return Gamma(x)*Gamma(y)/Gamma(x + y);
}
double Sinh(double x){
  return (exp(x) - exp( -x))/2.0;
}
double Cosh(double x){
  return (exp(x) + exp( -x))/2.0;
}
double Tanh(double x){
  return Sinh(x)/Cosh(x);
}
double Cot(double x){
  return 1.0/tan(x);
}
double Sec(double x){
  return 1.0/cos(x);
}
double Csc(double x){
  return 1.0/sin(x);
}
double Coth(double x){
  return Cosh(x)/Sinh(x);
}
double Sech(double x){
  return 1.0/Cosh(x);
}
double Csch(double x){
  return 1.0/Sinh(x);
}
double Error(double x){
  double y, t, tau, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

  if(x == 0.0){
    y = 0.0;
  }else if(x < 0.0){
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

    t = 1.0/(1.0 + 0.5*abs(x));

    tau = t*exp( -pow(x, 2.0) + c1 + t*(c2 + t*(c3 + t*(c4 + t*(c5 + t*(c6 + t*(c7 + t*(c8 + t*(c9 + t*c10)))))))));

    y = 1.0 - tau;
  }

  return y;
}
double ErrorInverse(double x){
  double y, a, t;

  a = (8.0*(M_PI - 3.0))/(3.0*M_PI*(4.0 - M_PI));

  t = 2.0/(M_PI*a) + log(1.0 - pow(x, 2.0))/2.0;
  y = Sign(x)*sqrt(sqrt(pow(t, 2.0) - log(1.0 - pow(x, 2.0))/a) - t);

  return y;
}
double FallingFactorial(double x, double n){
  double k, y;

  y = 1.0;

  for(k = 0.0; k <= n - 1.0; k = k + 1.0){
    y = y*(x - k);
  }

  return y;
}
double RisingFactorial(double x, double n){
  double k, y;

  y = 1.0;

  for(k = 0.0; k <= n - 1.0; k = k + 1.0){
    y = y*(x + k);
  }

  return y;
}
double Hypergeometric(double a, double b, double c, double z, double maxIterations, double precision){
  double y;

  if(abs(z) >= 0.5){
    y = pow(1.0 - z,  -a)*HypergeometricDirect(a, c - b, c, z/(z - 1.0), maxIterations, precision);
  }else{
    y = HypergeometricDirect(a, b, c, z, maxIterations, precision);
  }

  return y;
}
double HypergeometricDirect(double a, double b, double c, double z, double maxIterations, double precision){
  double y, yp, n;
  bool done;

  y = 0.0;
  done = false;

  for(n = 0.0; n < maxIterations &&  !done ; n = n + 1.0){
    yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*pow(z, n)/Factorial(n);
    if(abs(yp) < precision){
      done = true;
    }
    y = y + yp;
  }

  return y;
}
double BernouilliNumber(double n){
  return AkiyamaTanigawaAlgorithm(n);
}
double AkiyamaTanigawaAlgorithm(double n){
  double m, j, B;
  vector<double> *A;

  A = new vector<double> (n + 1.0);

  for(m = 0.0; m <= n; m = m + 1.0){
    A->at(m) = 1.0/(m + 1.0);
    for(j = m; j >= 1.0; j = j - 1.0){
      A->at(j - 1.0) = j*(A->at(j - 1.0) - A->at(j));
    }
  }

  B = A->at(0);

  delete A;

  return B;
}
double D15Add(double a, double b, BooleanReference *overflow){
  double x;

  x = a + b;

  if(x > D15MaxValue() || x < D15MinValue()){
    overflow->booleanValue = true;
    x = 0.0;
  }else{
    overflow->booleanValue = false;
    x = RoundTo15Digits(x);
  }

  return x;
}
double RoundTo15Digits(double x){
  double p;

  p = floor(log10(x));
  x = x*pow(10.0, 15.0 - p);
  x = Round(x);
  x = x/pow(10.0, 15.0 - p);

  return x;
}
double D15MaxValue(){
  return  +9.99999999999999e99;
}
double D15MinValue(){
  return  -9.99999999999999e99;
}
double D15Multiply(double a, double b, BooleanReference *overflow){
  double x;

  x = a*b;

  if(x > D15MaxValue() || x < D15MinValue()){
    overflow->booleanValue = true;
    x = 0.0;
  }else{
    overflow->booleanValue = false;
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15Divide(double a, double b, NumberReference *reminder, BooleanReference *overflow, BooleanReference *invalidOperation){
  double x, r;

  if(b != 0.0){
    invalidOperation->booleanValue = false;

    x = a/b;
    r = fmod(a, b);

    if(x > D15MaxValue() || x < D15MinValue()){
      overflow->booleanValue = true;
      x = 0.0;
      r = 0.0;
    }else{
      overflow->booleanValue = false;
      x = RoundTo15Digits(x);
      r = RoundTo15Digits(r);
    }
  }else{
    invalidOperation->booleanValue = true;
    overflow->booleanValue = false;
    x = 0.0;
    r = 0.0;
  }

  reminder->numberValue = r;

  return x;
}
double D15Exponentiation(double a, double b, BooleanReference *overflow, BooleanReference *invalidOperation){
  double x;

  if(a == 0.0 && b == 0.0){
    invalidOperation->booleanValue = true;
    overflow->booleanValue = false;
    x = 0.0;
  }else if(a < 0.0 &&  !IsInteger(b) ){
    invalidOperation->booleanValue = true;
    overflow->booleanValue = false;
    x = 0.0;
  }else{
    invalidOperation->booleanValue = false;

    x = pow(a, b);

    if(x > D15MaxValue() || x < D15MinValue()){
      overflow->booleanValue = true;
      x = 0.0;
    }else{
      overflow->booleanValue = false;
      x = RoundTo15Digits(x);
    }
  }

  return x;
}
double D15Modulus(double a, double b, BooleanReference *invalidOperation){
  double x;

  if(a < 0.0 || b == 0.0 || b < 0.0){
    invalidOperation->booleanValue = true;
    x = 0.0;
  }else{
    invalidOperation->booleanValue = false;
    x = fmod(a, b);
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15Logarithm(double a, BooleanReference *invalidOperation){
  double x;

  if(a <= 0.0){
    invalidOperation->booleanValue = true;
    x = 0.0;
  }else{
    invalidOperation->booleanValue = false;
    x = log10(a);
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15NaturalLogarithm(double a, BooleanReference *invalidOperation){
  double x;

  if(a <= 0.0){
    invalidOperation->booleanValue = true;
    x = 0.0;
  }else{
    invalidOperation->booleanValue = false;
    x = log(a);
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15Sin(double a){
  double x;

  x = sin(a);
  x = RoundTo15Digits(x);

  return x;
}
double D15Cos(double x){
  double a, y, piBy2Part1, piBy2Part2, limit, f;

  x = abs(x);

  limit = M_PI + 3.1/2.0;

  if(x > limit){
    f = floor(x/M_PI);
    x = x - M_PI*f;
  }

  piBy2Part1 =  +1.57079632679490;
  piBy2Part2 =  -3.38076867830836e-15;

  if(x > 3.1/2.0 && x < 3.3/2.0){
    a = x - piBy2Part1;
    a = round(a*pow(10.0, 15.0))/pow(10.0, 15.0);
    a = a - piBy2Part2;
    y =  -sin(a);
  }else{
    y = cos(x);
    y = RoundTo15Digits(y);
  }

  return y;
}
double D15Tan(double a, BooleanReference *overflow){
  double x;

  x = tan(a);

  if(x > D15MaxValue() || x < D15MinValue()){
    overflow->booleanValue = true;
    x = 0.0;
  }else{
    overflow->booleanValue = false;
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15Asin(double a, BooleanReference *invalidOperation){
  double x;

  if(a <  -1.0 || a > 1.0){
    invalidOperation->booleanValue = true;
    x = 0.0;
  }else{
    invalidOperation->booleanValue = false;
    x = asin(a);
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15Acos(double a, BooleanReference *invalidOperation){
  double x;

  if(a <  -1.0 || a > 1.0){
    invalidOperation->booleanValue = true;
    x = 0.0;
  }else{
    invalidOperation->booleanValue = false;
    x = acos(a);
    x = RoundTo15Digits(x);
  }

  return x;
}
double D15Atan(double a){
  double x;

  x = atan(a);
  x = RoundTo15Digits(x);

  return x;
}
double D15Sqrt(double a){
  double x;

  x = sqrt(a);
  x = RoundTo15Digits(x);

  return x;
}
double D15Exponential(double a, BooleanReference *overflow){
  double x;

  x = exp(a);

  if(x > D15MaxValue() || x < D15MinValue()){
    overflow->booleanValue = true;
    x = 0.0;
  }else{
    overflow->booleanValue = false;
    x = RoundTo15Digits(x);
  }

  return x;
}
vector<wchar_t> *Decimal15E2ToString(double decimal){
  double multiplier, inc, i, d;
  double exponent;
  bool done, isPositive, isPositiveExponent;
  vector<wchar_t> *result;
  double len;

  len = 21.0;
  /* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00" */
  result = new vector<wchar_t> (len);

  done = false;
  exponent = 0.0;

  if(decimal < 0.0){
    isPositive = false;
    decimal =  -decimal;
  }else{
    isPositive = true;
  }

  if(decimal == 0.0){
    done = true;
  }

  if( !done ){
    multiplier = 0.0;
    inc = 0.0;

    if(decimal < 1.0){
      multiplier = 10.0;
      inc =  -1.0;
    }else if(decimal >= 10.0){
      multiplier = 0.1;
      inc = 1.0;
    }else{
      done = true;
    }

    if( !done ){
      exponent = round(log10(decimal));
      exponent = fmin(99.0, exponent);
      exponent = fmax( -99.0, exponent);

      decimal = decimal/pow(10.0, exponent);

      /* Adjust */
      for(; (decimal >= 10.0 || decimal < 1.0) && abs(exponent) < 99.0; ){
        decimal = decimal*multiplier;
        exponent = exponent + inc;
      }
    }
  }

  isPositiveExponent = exponent >= 0.0;
  if( !isPositiveExponent ){
    exponent =  -exponent;
  }

  if(isPositive){
    result->at(0) = '+';
  }else{
    result->at(0) = '-';
  }

  decimal = round(decimal*pow(10.0, 14.0));

  d = floor(decimal/pow(10.0, 14.0));
  result->at(1) = SingleDigitNumberToCharacter(d);
  decimal = decimal - d*pow(10.0, 14.0);

  result->at(2) = '.';

  for(i = 0.0; i < 14.0; i = i + 1.0){
    d = floor(decimal/pow(10.0, 13.0 - i));
    result->at(3.0 + i) = SingleDigitNumberToCharacter(d);
    decimal = decimal - d*pow(10.0, 13.0 - i);
  }

  result->at(17) = 'e';

  if(isPositiveExponent){
    result->at(18) = '+';
  }else{
    result->at(18) = '-';
  }

  result->at(19) = SingleDigitNumberToCharacter(floor(exponent/10.0));
  result->at(20) = SingleDigitNumberToCharacter(floor(fmod(exponent, 10.0)));

  return result;
}
wchar_t SingleDigitNumberToCharacter(double n){
  wchar_t c;

  c = '0';
  if(n == 0.0){
    c = '0';
  }else if(n == 1.0){
    c = '1';
  }else if(n == 2.0){
    c = '2';
  }else if(n == 3.0){
    c = '3';
  }else if(n == 4.0){
    c = '4';
  }else if(n == 5.0){
    c = '5';
  }else if(n == 6.0){
    c = '6';
  }else if(n == 7.0){
    c = '7';
  }else if(n == 8.0){
    c = '8';
  }else if(n == 9.0){
    c = '9';
  }

  return c;
}
wchar_t cToLowerCase(wchar_t character){
  wchar_t toReturn;

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
wchar_t cToUpperCase(wchar_t character){
  wchar_t toReturn;

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
bool cIsUpperCase(wchar_t character){
  bool isUpper;

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
bool cIsLowerCase(wchar_t character){
  bool isLower;

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
bool cIsLetter(wchar_t character){
  return cIsUpperCase(character) || cIsLowerCase(character);
}
bool cIsNumber(wchar_t character){
  bool isNumberx;

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
bool cIsWhiteSpace(wchar_t character){
  bool isWhiteSpacex;

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
bool cIsSymbol(wchar_t character){
  bool isSymbolx;

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
bool cCharacterIsBefore(wchar_t a, wchar_t b){
  double ad, bd;

  ad = a;
  bd = b;

  return ad < bd;
}
wchar_t cDecimalDigitToCharacter(double digit){
  wchar_t c;
  if(digit == 1.0){
    c = '1';
  }else if(digit == 2.0){
    c = '2';
  }else if(digit == 3.0){
    c = '3';
  }else if(digit == 4.0){
    c = '4';
  }else if(digit == 5.0){
    c = '5';
  }else if(digit == 6.0){
    c = '6';
  }else if(digit == 7.0){
    c = '7';
  }else if(digit == 8.0){
    c = '8';
  }else if(digit == 9.0){
    c = '9';
  }else{
    c = '0';
  }
  return c;
}
double cCharacterToDecimalDigit(wchar_t c){
  double digit;

  if(c == '1'){
    digit = 1.0;
  }else if(c == '2'){
    digit = 2.0;
  }else if(c == '3'){
    digit = 3.0;
  }else if(c == '4'){
    digit = 4.0;
  }else if(c == '5'){
    digit = 5.0;
  }else if(c == '6'){
    digit = 6.0;
  }else if(c == '7'){
    digit = 7.0;
  }else if(c == '8'){
    digit = 8.0;
  }else if(c == '9'){
    digit = 9.0;
  }else{
    digit = 0.0;
  }

  return digit;
}

