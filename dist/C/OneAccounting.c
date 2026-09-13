/* Downloaded from https://repo.progsbase.com - Code Developed Using progsbase. */

#include <stdlib.h>
#include <stdbool.h>
#include <math.h>
#include <string.h>
#include <fenv.h>
#include <uchar.h>
size_t c16len(char16_t* str) {
    const char16_t* s = str;
    while (*s) {
        s++;
    }
    return s - str;
}

#define strparam(str) (str), c16len(str)

#ifndef M_PI
#define M_PI 3.14159265358979323846
#endif

struct Account;
typedef struct Account Account;

struct AccountDefinition;
typedef struct AccountDefinition AccountDefinition;

struct AccountPlan;
typedef struct AccountPlan AccountPlan;

struct Ledger;
typedef struct Ledger Ledger;

struct Line;
typedef struct Line Line;

struct Transaction;
typedef struct Transaction Transaction;

struct BooleanArrayReference;
typedef struct BooleanArrayReference BooleanArrayReference;

struct BooleanReference;
typedef struct BooleanReference BooleanReference;

struct CharacterReference;
typedef struct CharacterReference CharacterReference;

struct NumberArrayReference;
typedef struct NumberArrayReference NumberArrayReference;

struct NumberReference;
typedef struct NumberReference NumberReference;

struct StringArrayReference;
typedef struct StringArrayReference StringArrayReference;

struct StringReference;
typedef struct StringReference StringReference;

struct Date;
typedef struct Date Date;

struct DateReference;
typedef struct DateReference DateReference;

struct Interval;
typedef struct Interval Interval;

struct DateTimeTimezone;
typedef struct DateTimeTimezone DateTimeTimezone;

struct DateTimeTimezoneReference;
typedef struct DateTimeTimezoneReference DateTimeTimezoneReference;

struct DateTime;
typedef struct DateTime DateTime;

struct DateTimeReference;
typedef struct DateTimeReference DateTimeReference;

struct FixedPoint30d;
typedef struct FixedPoint30d FixedPoint30d;

struct FixedPoint15d;
typedef struct FixedPoint15d FixedPoint15d;

struct DynamicArrayCharacters;
typedef struct DynamicArrayCharacters DynamicArrayCharacters;

struct LinkedListNodeStrings;
typedef struct LinkedListNodeStrings LinkedListNodeStrings;

struct LinkedListStrings;
typedef struct LinkedListStrings LinkedListStrings;

struct LinkedListNodeNumbers;
typedef struct LinkedListNodeNumbers LinkedListNodeNumbers;

struct LinkedListNumbers;
typedef struct LinkedListNumbers LinkedListNumbers;

struct LinkedListCharacters;
typedef struct LinkedListCharacters LinkedListCharacters;

struct LinkedListNodeCharacters;
typedef struct LinkedListNodeCharacters LinkedListNodeCharacters;

struct DynamicArrayNumbers;
typedef struct DynamicArrayNumbers DynamicArrayNumbers;

struct Array;
typedef struct Array Array;

struct Data;
typedef struct Data Data;

struct DataReference;
typedef struct DataReference DataReference;

struct Structure;
typedef struct Structure Structure;

struct Account{
  char16_t *name;
  size_t nameLength;
  FixedPoint15d *endingBalance;
  FixedPoint15d *startingBalance;
  Date *from;
  Date *to;
  FixedPoint15d *sumDebit;
  FixedPoint15d *sumCredit;
};

struct AccountDefinition{
  char16_t *accountName;
  size_t accountNameLength;
  char16_t *number;
  size_t numberLength;
  char16_t *role;
  size_t roleLength;
  _Bool debitBalance;
};

struct AccountPlan{
  AccountDefinition **accountDefinitions;
  size_t accountDefinitionsLength;
};

struct Ledger{
  double decimals;
  Transaction **transactions;
  size_t transactionsLength;
  AccountPlan *accountPlan;
};

struct Line{
  char16_t *account;
  size_t accountLength;
  FixedPoint15d *debit;
  FixedPoint15d *credit;
  char16_t *description;
  size_t descriptionLength;
  Date *date;
};

struct Transaction{
  Line **lines;
  size_t linesLength;
};

struct BooleanArrayReference{
  _Bool *booleanArray;
  size_t booleanArrayLength;
};

struct BooleanReference{
  _Bool booleanValue;
};

struct CharacterReference{
  char16_t characterValue;
};

struct NumberArrayReference{
  double *numberArray;
  size_t numberArrayLength;
};

struct NumberReference{
  double numberValue;
};

struct StringArrayReference{
  StringReference **stringArray;
  size_t stringArrayLength;
};

struct StringReference{
  char16_t *string;
  size_t stringLength;
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
  char16_t *array;
  size_t arrayLength;
  double length;
};

struct LinkedListNodeStrings{
  _Bool end;
  char16_t *value;
  size_t valueLength;
  LinkedListNodeStrings *next;
};

struct LinkedListStrings{
  LinkedListNodeStrings *first;
  LinkedListNodeStrings *last;
};

struct LinkedListNodeNumbers{
  LinkedListNodeNumbers *next;
  _Bool end;
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
  _Bool end;
  char16_t value;
  LinkedListNodeCharacters *next;
};

struct DynamicArrayNumbers{
  double *array;
  size_t arrayLength;
  double length;
};

struct Array{
  Data **array;
  size_t arrayLength;
  double length;
};

struct Data{
  _Bool isStruture;
  _Bool isArray;
  _Bool isNumber;
  _Bool isString;
  _Bool isBoolean;
  Structure *structure;
  Array *array;
  double number;
  _Bool booleanx;
  char16_t *string;
  size_t stringLength;
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
Line *CreateLine(char16_t *account, size_t accountLength, FixedPoint15d *debit, FixedPoint15d *credit, char16_t *description, size_t descriptionLength, Date *date);
void AddTransactionToLedger(Array *ledger, Line *src);
void AddTransactionsToLedger(Array *ledger, Line **ts, size_t tsLength);
_Bool ValidateAndAddTransactionToLedger(Structure *ledger, Line **ls, size_t lsLength);
Line *GetTransactionFromLedger(Structure *ledger, double index);
Structure *LineToStructure(Line *src);
Line *LineFromStructure(Structure *src, Structure *ledger);
Ledger *LedgerDynamicToStatic(Structure *src);
_Bool ValidateTransaction(Line **ts, size_t tsLength, Structure *ledger);
_Bool ValidateTransactions(Line **ts, size_t tsLength, NumberArrayReference *invalidIds);
Account *ComputeAccountBalance(Ledger *ledger, char16_t *accountName, size_t accountNameLength, Date *fromDate, Date *toDate);
char16_t *AccountToString(size_t *returnArrayLength, Account *account);
void AddMonthlyAccruals(Structure *ledger, Date *from, Date *to, double amount, char16_t *fromAccount, size_t fromAccountLength, char16_t *toAccount, size_t toAccountLength);
FixedPoint15d *ComputeAccountBalancePrefixAccount(Ledger *ledger, char16_t *accountNr, size_t accountNrLength, Date *toDate, _Bool debitBalance);
AccountPlan *GetIFRSAccountPlan();
AccountPlan *ParseAccountPlanString(char16_t *accountPlanString, size_t accountPlanStringLength, BooleanReference *valid);
_Bool ComputeAccountBalances(Ledger *sledger, double depth, Date *date, DataReference *balanceSheet);
char16_t *AccountBalancesToString(size_t *returnArrayLength, Structure *balanceSheet);
AccountDefinition *FindAccountWithRole(AccountPlan *accountPlan, char16_t *role, size_t roleLength, BooleanReference *foundRef);
AccountDefinition *CreateAccountDefinition(char16_t *name, size_t nameLength, char16_t *number, size_t numberLength, char16_t *role, size_t roleLength, _Bool debitBalance);
void ComputeBalanceDiffs(Ledger *sledger, Array *balances);
char16_t *BalancesArrayToHTML(size_t *returnArrayLength, Array *balances, _Bool includeBalance, _Bool includeDiff);
Line *CreateLineFromScript(Structure *ledger, char16_t *script, size_t scriptLength, Date *date);

double test();
void TestIFRSAccountPlan(NumberReference *failures);
void TestBasicAccounting(NumberReference *failures);
void TestAccruals(NumberReference *failures);

BooleanReference *CreateBooleanReference(_Bool value);
BooleanArrayReference *CreateBooleanArrayReference(_Bool *value, size_t valueLength);
BooleanArrayReference *CreateBooleanArrayReferenceLengthValue(double length, _Bool value);
void FreeBooleanArrayReference(BooleanArrayReference *booleanArrayReference);
CharacterReference *CreateCharacterReference(char16_t value);
NumberReference *CreateNumberReference(double value);
NumberArrayReference *CreateNumberArrayReference(double *value, size_t valueLength);
NumberArrayReference *CreateNumberArrayReferenceLengthValue(double length, double value);
void FreeNumberArrayReference(NumberArrayReference *numberArrayReference);
StringReference *CreateStringReference(char16_t *value, size_t valueLength);
StringReference *CreateStringReferenceLengthValue(double length, char16_t value);
void FreeStringReference(StringReference *stringReference);
StringArrayReference *CreateStringArrayReference(StringReference **strings, size_t stringsLength);
StringArrayReference *CreateStringArrayReferenceLengthValue(double length, char16_t *value, size_t valueLength);
void FreeStringArrayReference(StringArrayReference *stringArrayReference);

Date *CreateDate(double year, double month, double day);
_Bool IsLeapYearWithCheck(double year, BooleanReference *isLeapYearReference, StringReference *message);
_Bool IsLeapYear(double year);
_Bool DayToDateWithCheck(double dayNr, DateReference *dateReference, StringReference *message);
Date *DayToDate(double dayNr);
_Bool GetMonthFromDayNrWithCheck(double dayNr, double year, NumberReference *monthReference, NumberReference *remainderReference, StringReference *message);
double GetMonthFromDayNr(double dayNr, double year, NumberReference *remainderReference);
_Bool GetYearFromDayNrWithCheck(double dayNr, NumberReference *yearReference, NumberReference *remainder, StringReference *message);
double GetYearFromDayNr(double dayNr, NumberReference *remainder);
double DaysBetweenDates(Date *A, Date *B);
_Bool GetDaysInMonthWithCheck(double year, NumberArrayReference *daysInMonthReference, StringReference *message);
double *GetDaysInMonth(size_t *returnArrayLength, double year);
_Bool DateToDaysWithCheck(Date *date, NumberReference *dayNumberReferenceReference, StringReference *message);
double DateToDays(Date *date);
_Bool DateToWeekdayNumberWithCheck(Date *date, NumberReference *weekDayNumberReference, StringReference *message);
double DateToWeekdayNumber(Date *date);
double DateToWeeknumber(Date *date, NumberReference *yearRef);
_Bool DaysInMonthsWithCheck(double month, double year, NumberReference *daysInMonthsReference, StringReference *message);
double DaysInMonths(double month, double year);
_Bool DaysInYearsWithCheck(double years, NumberReference *daysReference, StringReference *message);
double DaysInYears(double years);
_Bool IsValidDate(Date *date, StringReference *message);
_Bool AddDaysToDate(Date *date, double days, StringReference *message);
void AssignDate(Date *a, Date *b);
void AddMonthsToDate(Date *date, double months);
_Bool DateToStringISO8601WithCheck(Date *date, StringReference *datestr, StringReference *message);
char16_t *DateToStringISO8601(size_t *returnArrayLength, Date *date);
Date *DateFromStringISO8601(char16_t *str, size_t strLength);
_Bool DateFromStringISO8601WithCheck(char16_t *str, size_t strLength, DateReference *dateRef, StringReference *message);
_Bool IsValidDateISO8601(char16_t *str, size_t strLength, StringReference *message);
_Bool DateEquals(Date *a, Date *b);
Date *CopyDate(Date *a);
double GetSecondsFromDate(Date *date);
_Bool DateIsInInterval(Interval *interval, Date *date);
_Bool DateLessThan(Date *a, Date *b);

DateTimeTimezone *CreateDateTimeTimezone(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetSeconds);
DateTimeTimezone *CreateDateTimeTimezoneInHoursAndMinutes(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetHours, double timezoneOffsetMinutes);
_Bool GetDateFromDateTimeTimeZone(DateTimeTimezone *dateTimeTimezone, DateTimeReference *dateTimeReference, StringReference *message);
_Bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(DateTime *dateTime, double timezoneOffsetSeconds, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message);
_Bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(DateTime *dateTime, double timezoneOffsetHours, double timezoneOffsetMinutes, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message);
_Bool GetDateTimeTimezoneFromSeconds(DateTimeTimezoneReference *dateTimeTzRef, double seconds, double offset, StringReference *message);

DateTime *CreateDateTime(double year, double month, double day, double hours, double minutes, double seconds);
_Bool GetDateTimeFromSeconds(double seconds, DateTimeReference *dateTimeReference, StringReference *message);
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
_Bool AddSecondsToDateTimeWithCheck(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message);
_Bool AddSecondsToDateTime(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message);
_Bool AddMinutesToDateTime(DateTime *dateTime, double minutes, DateTimeReference *dateTimeReference, StringReference *message);
_Bool AddHoursToDateTime(DateTime *dateTime, double hours, DateTimeReference *dateTimeReference, StringReference *message);
_Bool AddDaysToDateTime(DateTime *dateTime, double days, DateTimeReference *dateTimeReference, StringReference *message);
_Bool AddWeeksToDateTime(DateTime *dateTime, double weeks, DateTimeReference *dateTimeReference, StringReference *message);
_Bool DateTimeToStringISO8601WithCheck(DateTime *datetime, StringReference *dateStr, StringReference *message);
_Bool IsValidDateTime(DateTime *datetime, StringReference *message);
char16_t *DateTimeToStringISO8601(size_t *returnArrayLength, DateTime *datetime);
DateTime *DateTimeFromStringISO8601(char16_t *str, size_t strLength);
_Bool DateTimeFromStringISO8601WithCheck(char16_t *str, size_t strLength, DateTimeReference *dateTimeRef, StringReference *message);
_Bool IsValidDateTimeISO8601(char16_t *str, size_t strLength, StringReference *message);
_Bool DateTimeEquals(DateTime *a, DateTime *b);
void FreeDateTime(DateTime *datetime);

FixedPoint30d *CreateFixedPoint30d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint);

FixedPoint15d *CreateFixedPoint15d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint);
double ToNumber15d(FixedPoint15d *n);
FixedPoint15d *Number15d(double number);
_Bool Assign15d(FixedPoint15d *fp, double number);
_Bool Assign15dFloor(FixedPoint15d *fp, double number);
_Bool FixedPointIsValid15d(FixedPoint15d *fp);
_Bool WillOverflow15d(FixedPoint15d *fp, double number);
double FloorToDigits(double value, double digits);
char16_t *ToString15d(size_t *returnArrayLength, FixedPoint15d *fp);
_Bool Add15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c);
_Bool Subtract15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c);
_Bool Multiply15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c);
_Bool DivideFloored15d(FixedPoint15d *q, FixedPoint15d *r, FixedPoint15d *a, FixedPoint15d *b);
FixedPoint15d *Copy15d(FixedPoint15d *r);
void Negate15d(FixedPoint15d *a);
void Positive15d(FixedPoint15d *a);
_Bool Factorial15d(FixedPoint15d *x);
_Bool Round15d(FixedPoint15d *x);
_Bool BankersRound15d(FixedPoint15d *x);
_Bool Ceil15d(FixedPoint15d *x);
_Bool Floor15d(FixedPoint15d *x);
void Truncate15d(FixedPoint15d *x);
void Absolute15d(FixedPoint15d *x);
_Bool Logarithm15d(FixedPoint15d *x);
_Bool NaturalLogarithm15d(FixedPoint15d *x);
_Bool Sin15d(FixedPoint15d *x);
_Bool Cos15d(FixedPoint15d *x);
_Bool Tan15d(FixedPoint15d *x);
_Bool Asin15d(FixedPoint15d *x);
_Bool Acos15d(FixedPoint15d *x);
_Bool Atan15d(FixedPoint15d *x);
_Bool Atan2_15d(FixedPoint15d *a, FixedPoint15d *y, FixedPoint15d *x);
_Bool Squareroot15d(FixedPoint15d *x);
_Bool Exp15d(FixedPoint15d *x);
_Bool DivisibleBy15d(FixedPoint15d *a, FixedPoint15d *b);
_Bool Combinations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k);
_Bool Permutations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k);
_Bool Equals15d(FixedPoint15d *a, FixedPoint15d *b);
_Bool GreaterThan15d(FixedPoint15d *a, FixedPoint15d *b);
_Bool LessThan15d(FixedPoint15d *a, FixedPoint15d *b);
_Bool GreaterThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b);
_Bool LessThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b);
_Bool EpsilonCompare15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *epsilon);
_Bool GreatestCommonDivisor15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
_Bool GCDWithSubtraction15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
_Bool IsInteger15d(FixedPoint15d *a);
_Bool LeastCommonMultiple15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
double Sign15d(FixedPoint15d *a);
_Bool Max15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
_Bool Min15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
_Bool Power15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b);
char16_t *FormatToString15d(size_t *returnArrayLength, FixedPoint15d *fp, double digitsAfter);
char16_t *FormatToStringWithSymbols15d(size_t *returnArrayLength, FixedPoint15d *fp, double digitsAfter, char16_t *thousandsSeparator, size_t thousandsSeparatorLength, char16_t *decimalPoint, size_t decimalPointLength);
char16_t *NumberToHumanReadable(size_t *returnArrayLength, double n, double digitsAfter, char16_t *thousandsSeparator, size_t thousandsSeparatorLength, char16_t *decimalPoint, size_t decimalPointLength);
char16_t *NumberToHumanReadableBinaryPrefix(size_t *returnArrayLength, double n, double digitsAfter, char16_t *thousandsSeparator, size_t thousandsSeparatorLength, char16_t *decimalPoint, size_t decimalPointLength);

double *AddNumber(size_t *returnArrayLength, double *list, size_t listLength, double a);
void AddNumberRef(NumberArrayReference *list, double i);
double *RemoveNumber(size_t *returnArrayLength, double *list, size_t listLength, double n);
double GetNumberRef(NumberArrayReference *list, double i);
void RemoveNumberRef(NumberArrayReference *list, double i);

StringReference **AddString(size_t *returnArrayLength, StringReference **list, size_t listLength, StringReference *a);
void AddStringRef(StringArrayReference *list, StringReference *i);
StringReference **RemoveString(size_t *returnArrayLength, StringReference **list, size_t listLength, double n);
StringReference *GetStringRef(StringArrayReference *list, double i);
void RemoveStringRef(StringArrayReference *list, double i);


DynamicArrayCharacters *CreateDynamicArrayCharacters();
DynamicArrayCharacters *CreateDynamicArrayCharactersWithInitialCapacity(double capacity);
void DynamicArrayAddCharacter(DynamicArrayCharacters *da, char16_t value);
void DynamicArrayAddString(DynamicArrayCharacters *da, char16_t *str, size_t strLength);
void DynamicArrayCharactersIncreaseSize(DynamicArrayCharacters *da);
_Bool DynamicArrayCharactersDecreaseSizeNecessary(DynamicArrayCharacters *da);
void DynamicArrayCharactersDecreaseSize(DynamicArrayCharacters *da);
char16_t DynamicArrayCharactersIndex(DynamicArrayCharacters *da, double index);
double DynamicArrayCharactersLength(DynamicArrayCharacters *da);
void DynamicArrayInsertCharacter(DynamicArrayCharacters *da, double index, char16_t value);
_Bool DynamicArrayCharacterSet(DynamicArrayCharacters *da, double index, char16_t value);
void DynamicArrayRemoveCharacter(DynamicArrayCharacters *da, double index);
void FreeDynamicArrayCharacters(DynamicArrayCharacters *da);
char16_t *DynamicArrayCharactersToArray(size_t *returnArrayLength, DynamicArrayCharacters *da);
DynamicArrayCharacters *ArrayToDynamicArrayCharactersWithOptimalSize(char16_t *array, size_t arrayLength);
DynamicArrayCharacters *ArrayToDynamicArrayCharacters(char16_t *array, size_t arrayLength);
_Bool DynamicArrayCharactersEqual(DynamicArrayCharacters *a, DynamicArrayCharacters *b);
LinkedListCharacters *DynamicArrayCharactersToLinkedList(DynamicArrayCharacters *da);
DynamicArrayCharacters *LinkedListToDynamicArrayCharacters(LinkedListCharacters *ll);

_Bool *AddBoolean(size_t *returnArrayLength, _Bool *list, size_t listLength, _Bool a);
void AddBooleanRef(BooleanArrayReference *list, _Bool i);
_Bool *RemoveBoolean(size_t *returnArrayLength, _Bool *list, size_t listLength, double n);
_Bool GetBooleanRef(BooleanArrayReference *list, double i);
void RemoveDecimalRef(BooleanArrayReference *list, double i);


LinkedListStrings *CreateLinkedListString();
void LinkedListAddString(LinkedListStrings *ll, char16_t *value, size_t valueLength);
StringReference **LinkedListStringsToArray(size_t *returnArrayLength, LinkedListStrings *ll);
double LinkedListStringsLength(LinkedListStrings *ll);
void FreeLinkedListString(LinkedListStrings *ll);
void LinkedListInsertString(LinkedListStrings *ll, double index, char16_t *value, size_t valueLength);


LinkedListNumbers *CreateLinkedListNumbers();
LinkedListNumbers **CreateLinkedListNumbersArray(size_t *returnArrayLength, double length);
void LinkedListAddNumber(LinkedListNumbers *ll, double value);
double LinkedListNumbersLength(LinkedListNumbers *ll);
double LinkedListNumbersIndex(LinkedListNumbers *ll, double index);
void LinkedListInsertNumber(LinkedListNumbers *ll, double index, double value);
void LinkedListSet(LinkedListNumbers *ll, double index, double value);
void LinkedListRemoveNumber(LinkedListNumbers *ll, double index);
void FreeLinkedListNumbers(LinkedListNumbers *ll);
void FreeLinkedListNumbersArray(LinkedListNumbers **lls, size_t llsLength);
double *LinkedListNumbersToArray(size_t *returnArrayLength, LinkedListNumbers *ll);
LinkedListNumbers *ArrayToLinkedListNumbers(double *array, size_t arrayLength);
_Bool LinkedListNumbersEqual(LinkedListNumbers *a, LinkedListNumbers *b);

LinkedListCharacters *CreateLinkedListCharacter();
void LinkedListAddCharacter(LinkedListCharacters *ll, char16_t value);
char16_t *LinkedListCharactersToArray(size_t *returnArrayLength, LinkedListCharacters *ll);
double LinkedListCharactersLength(LinkedListCharacters *ll);
void FreeLinkedListCharacter(LinkedListCharacters *ll);
void LinkedListCharactersAddString(LinkedListCharacters *ll, char16_t *str, size_t strLength);
void LinkedListInsertCharacter(LinkedListCharacters *ll, double index, char16_t value);



DynamicArrayNumbers *CreateDynamicArrayNumbers();
DynamicArrayNumbers *CreateDynamicArrayNumbersWithInitialCapacity(double capacity);
void DynamicArrayAddNumber(DynamicArrayNumbers *da, double value);
void DynamicArrayNumbersIncreaseSize(DynamicArrayNumbers *da);
_Bool DynamicArrayNumbersDecreaseSizeNecessary(DynamicArrayNumbers *da);
void DynamicArrayNumbersDecreaseSize(DynamicArrayNumbers *da);
double DynamicArrayNumbersIndex(DynamicArrayNumbers *da, double index);
double DynamicArrayNumbersLength(DynamicArrayNumbers *da);
void DynamicArrayInsertNumber(DynamicArrayNumbers *da, double index, double value);
_Bool DynamicArrayNumberSet(DynamicArrayNumbers *da, double index, double value);
void DynamicArrayRemoveNumber(DynamicArrayNumbers *da, double index);
void FreeDynamicArrayNumbers(DynamicArrayNumbers *da);
double *DynamicArrayNumbersToArray(size_t *returnArrayLength, DynamicArrayNumbers *da);
DynamicArrayNumbers *ArrayToDynamicArrayNumbersWithOptimalSize(double *array, size_t arrayLength);
DynamicArrayNumbers *ArrayToDynamicArrayNumbers(double *array, size_t arrayLength);
_Bool DynamicArrayNumbersEqual(DynamicArrayNumbers *a, DynamicArrayNumbers *b);
LinkedListNumbers *DynamicArrayNumbersToLinkedList(DynamicArrayNumbers *da);
DynamicArrayNumbers *LinkedListToDynamicArrayNumbers(LinkedListNumbers *ll);
double DynamicArrayNumbersIndexOf(DynamicArrayNumbers *arr, double n, BooleanReference *foundReference);
_Bool DynamicArrayNumbersIsInArray(DynamicArrayNumbers *arr, double n);

char16_t *AddCharacter(size_t *returnArrayLength, char16_t *list, size_t listLength, char16_t a);
void AddCharacterRef(StringReference *list, char16_t i);
char16_t *RemoveCharacter(size_t *returnArrayLength, char16_t *list, size_t listLength, double n);
char16_t GetCharacterRef(StringReference *list, double i);
void RemoveCharacterRef(StringReference *list, double i);

double GetAccrualAmount(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay, double yearOfInterest, double monthOfInterest);
double *GetAccruals(size_t *returnArrayLength, double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay);
double *GetAccrualsWithDates(size_t *returnArrayLength, double total, Date *from, Date *to);
double GetAccrualAmountWithDates(double total, Date *from, Date *to, double yearOfInterest, double monthOfInterest);
double GetUnadjustedAccrualAmountWithDates(FixedPoint15d *total, Date *from, Date *to, double yearOfInterest, double monthOfInterest);

Data *CreateNewArrayData();
Data *CreateNewStructData();
Structure *CreateStructure();
Data *CreateNumberData(double n);
Data *CreateBooleanData(_Bool b);
Data *CreateStringData(char16_t *string, size_t stringLength);
Data *CreateStructData(Structure *structure);
Data *CreateArrayData(Array *array);
Data *CreateNoTypeData();
void AddStructToArray(Array *ar, Structure *st);
void AddArrayToArray(Array *ar, Array *ar2);
void AddNumberToArray(Array *ar, double n);
void AddBooleanToArray(Array *ar, _Bool b);
void AddStringToArray(Array *ar, char16_t *str, size_t strLength);
void AddDataToArray(Array *ar, Data *data);
double StructKeys(Structure *st);
_Bool StructHasKey(Structure *st, char16_t *key, size_t keyLength);
double StructKeyIndex(Structure *st, char16_t *key, size_t keyLength);
StringReference **GetStructKeys(size_t *returnArrayLength, Structure *st);
Structure *GetStructFromStruct(Structure *st, char16_t *key, size_t keyLength);
Array *GetArrayFromStruct(Structure *st, char16_t *key, size_t keyLength);
double GetNumberFromStruct(Structure *st, char16_t *key, size_t keyLength);
_Bool GetBooleanFromStruct(Structure *st, char16_t *key, size_t keyLength);
char16_t *GetStringFromStruct(size_t *returnArrayLength, Structure *st, char16_t *key, size_t keyLength);
Data *GetDataFromStruct(Structure *st, char16_t *key, size_t keyLength);
Data *GetDataFromStructWithCheck(Structure *st, char16_t *key, size_t keyLength, BooleanReference *foundRef);
void AddStructToStruct(Structure *st, char16_t *key, size_t keyLength, Structure *structx);
void AddArrayToStruct(Structure *st, char16_t *key, size_t keyLength, Array *ar);
void AddNumberToStruct(Structure *st, char16_t *key, size_t keyLength, double n);
void AddBooleanToStruct(Structure *st, char16_t *key, size_t keyLength, _Bool b);
void AddStringToStruct(Structure *st, char16_t *key, size_t keyLength, char16_t *value, size_t valueLength);
void AddDataToStruct(Structure *st, char16_t *key, size_t keyLength, Data *data);
void FreeData(Data *data);
void FreeArray(Array *array);
_Bool DataTypeEquals(Data *a, Data *b);
_Bool IsStructure(Data *a);
_Bool IsArray(Data *a);
_Bool IsNumber(Data *a);
_Bool IsBoolean(Data *a);
_Bool IsString(Data *a);
_Bool IsNoType(Data *a);

Array *CreateArray();
Array *CreateArrayWithInitialCapacity(double capacity);
void ArrayAdd(Array *array, Data *value);
void ArrayAddString(Array *array, char16_t *value, size_t valueLength);
void ArrayAddBoolean(Array *array, _Bool value);
void ArrayAddNumber(Array *array, double value);
void ArrayAddStruct(Array *array, Structure *value);
void ArrayAddArray(Array *array, Array *value);
void ArrayIncreaseSize(Array *array);
_Bool ArrayDecreaseSizeNecessary(Array *array);
void ArrayDecreaseSize(Array *array);
Data *ArrayIndex(Array *array, double index);
Array *ArrayIndexArray(Array *array, double index);
Structure *ArrayIndexStruct(Array *array, double index);
_Bool ArrayIndexBoolean(Array *array, double index);
char16_t *ArrayIndexString(size_t *returnArrayLength, Array *array, double index);
double ArrayIndexNumber(Array *array, double index);
double ArrayLength(Array *array);
void ArrayInsert(Array *array, double index, Data *value);
void ArrayInsertString(Array *array, double index, char16_t *value, size_t valueLength);
void ArrayInsertBoolean(Array *array, double index, _Bool value);
void ArrayInsertNumber(Array *array, double index, double value);
void ArrayInsertStruct(Array *array, double index, Structure *value);
void ArrayInsertArray(Array *array, double index, Array *value);
_Bool ArraySet(Array *array, double index, Data *value);
void ArraySetString(Array *array, double index, char16_t *value, size_t valueLength);
void ArraySetBoolean(Array *array, double index, _Bool value);
void ArraySetNumber(Array *array, double index, double value);
void ArraySetStruct(Array *array, double index, Structure *value);
void ArraySetArray(Array *array, double index, Array *value);
void ArrayRemove(Array *array, double index);
Data **ToStaticArray(size_t *returnArrayLength, Array *arc);
double *ToStaticNumberArray(size_t *returnArrayLength, Array *array);
_Bool *ToStaticBooleanArray(size_t *returnArrayLength, Array *array);
StringReference **ToStaticStringArray(size_t *returnArrayLength, Array *array);
Array **ToStaticArrayArray(size_t *returnArrayLength, Array *array);
Structure **ToStaticStructArray(size_t *returnArrayLength, Array *array);
Array *StaticArrayToArrayWithOptimalSize(Data **src, size_t srcLength);
Array *StaticArrayToArray(Data **src, size_t srcLength);

double *arraysStringToNumberArray(size_t *returnArrayLength, char16_t *string, size_t stringLength);
char16_t *arraysNumberArrayToString(size_t *returnArrayLength, double *array, size_t arrayLength);
_Bool arraysNumberArraysEqual(double *a, size_t aLength, double *b, size_t bLength);
_Bool arraysBooleanArraysEqual(_Bool *a, size_t aLength, _Bool *b, size_t bLength);
_Bool arraysStringsEqual(char16_t *a, size_t aLength, char16_t *b, size_t bLength);
void arraysFillNumberArray(double *a, size_t aLength, double value);
void arraysFillString(char16_t *a, size_t aLength, char16_t value);
void arraysFillBooleanArray(_Bool *a, size_t aLength, _Bool value);
_Bool arraysFillNumberArrayRange(double *a, size_t aLength, double value, double from, double to);
_Bool arraysFillBooleanArrayRange(_Bool *a, size_t aLength, _Bool value, double from, double to);
_Bool arraysFillStringRange(char16_t *a, size_t aLength, char16_t value, double from, double to);
double *arraysCopyNumberArray(size_t *returnArrayLength, double *a, size_t aLength);
_Bool *arraysCopyBooleanArray(size_t *returnArrayLength, _Bool *a, size_t aLength);
char16_t *arraysCopyString(size_t *returnArrayLength, char16_t *a, size_t aLength);
_Bool arraysCopyNumberArrayRange(double *a, size_t aLength, double from, double to, NumberArrayReference *copyReference);
_Bool arraysCopyBooleanArrayRange(_Bool *a, size_t aLength, double from, double to, BooleanArrayReference *copyReference);
_Bool arraysCopyStringRange(char16_t *a, size_t aLength, double from, double to, StringReference *copyReference);
_Bool arraysIsLastElement(double length, double index);
double *arraysCreateNumberArray(size_t *returnArrayLength, double length, double value);
_Bool *arraysCreateBooleanArray(size_t *returnArrayLength, double length, _Bool value);
char16_t *arraysCreateString(size_t *returnArrayLength, double length, char16_t value);
void arraysSwapElementsOfNumberArray(double *A, size_t ALength, double ai, double bi);
void arraysSwapElementsOfStringArray(StringArrayReference *A, double ai, double bi);
void arraysReverseNumberArray(double *array, size_t arrayLength);

char16_t *CreateStringScientificNotationDecimalFromNumber(size_t *returnArrayLength, double n);
char16_t *CreateStringDecimalFromNumber(size_t *returnArrayLength, double number);
_Bool CreateStringFromNumberWithCheck(double number, double base, StringReference *stringRef);
double GetMaximumDigitsForBase(double base);
double GetMaximumDigitsForDecimal();
double GetFirstDecimalDigitPosition(double n);
double GetFirstDigitPosition(double n, double base);
_Bool GetSingleDigitCharacterFromNumberWithCheck(double c, double base, CharacterReference *characterReference);
_Bool GetDecimalDigitCharacterFromNumberWithCheck(double c, CharacterReference *characterRef);
char16_t *GetDigitCharacterTable(size_t *returnArrayLength);
double GetDecimalDigit(double n, double index);
double GetDecimalDigitWithFirstDigitPosition(double n, double digitPosition, double index);
double GetDigit(double n, double base, double index);
char16_t *NumberToHumanReadableShortScale(size_t *returnArrayLength, double n);
char16_t *NumberToHumanReadableBinary(size_t *returnArrayLength, double n);
char16_t *NumberToHumanReadableMetric(size_t *returnArrayLength, double n);

_Bool IsValidNumber(char16_t *str, size_t strLength);
_Bool IsValidInteger(char16_t *str, size_t strLength);
_Bool IsValidPositiveInteger(char16_t *str, size_t strLength);

_Bool CreateNumberFromDecimalStringWithCheck(char16_t *string, size_t stringLength, NumberReference *decimalReference, StringReference *message);
double CreateNumberFromDecimalString(char16_t *string, size_t stringLength);
_Bool CreateNumberFromStringWithCheck(char16_t *string, size_t stringLength, double base, NumberReference *numberReference, StringReference *message);
double CreateNumberFromParts(double base, _Bool numberIsPositive, double *beforePoint, size_t beforePointLength, double *afterPoint, size_t afterPointLength, _Bool exponentIsPositive, double *exponent, size_t exponentLength);
_Bool ExtractPartsFromNumberString(char16_t *n, size_t nLength, double base, BooleanReference *numberIsPositive, NumberArrayReference *beforePoint, NumberArrayReference *afterPoint, BooleanReference *exponentIsPositive, NumberArrayReference *exponent, StringReference *errorMessages);
double GetNumberFromNumberCharacterForBase(char16_t c, double base);
_Bool CharacterIsNumberCharacterInBase(char16_t c, double base);
double *StringToNumberArray(size_t *returnArrayLength, char16_t *str, size_t strLength);
_Bool StringToNumberArrayWithCheck(char16_t *str, size_t strLength, NumberArrayReference *numberArrayReference, StringReference *errorMessage);

void strWriteStringToStingStream(char16_t *stream, size_t streamLength, NumberReference *index, char16_t *src, size_t srcLength);
void strWriteCharacterToStingStream(char16_t *stream, size_t streamLength, NumberReference *index, char16_t src);
void strWriteBooleanToStingStream(char16_t *stream, size_t streamLength, NumberReference *index, _Bool src);

_Bool strSubstringWithCheck(char16_t *string, size_t stringLength, double from, double to, StringReference *stringReference);
char16_t *strSubstring(size_t *returnArrayLength, char16_t *string, size_t stringLength, double from, double to);
char16_t *strAppendString(size_t *returnArrayLength, char16_t *s1, size_t s1Length, char16_t *s2, size_t s2Length);
char16_t *strConcatenateString(size_t *returnArrayLength, char16_t *s1, size_t s1Length, char16_t *s2, size_t s2Length);
char16_t *strAppendCharacter(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t c);
char16_t *strConcatenateCharacter(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t c);
StringReference **strSplitByCharacter(size_t *returnArrayLength, char16_t *toSplit, size_t toSplitLength, char16_t splitBy);
_Bool strIndexOfCharacter(char16_t *string, size_t stringLength, char16_t character, NumberReference *indexReference);
_Bool strLastIndexOfCharacter(char16_t *string, size_t stringLength, char16_t character, NumberReference *indexReference);
_Bool strSubstringEqualsWithCheck(char16_t *string, size_t stringLength, double from, char16_t *substring, size_t substringLength, BooleanReference *equalsReference);
_Bool strSubstringEquals(char16_t *string, size_t stringLength, double from, char16_t *substring, size_t substringLength);
_Bool strIndexOfString(char16_t *string, size_t stringLength, char16_t *substring, size_t substringLength, NumberReference *indexReference);
_Bool strContainsCharacter(char16_t *string, size_t stringLength, char16_t character);
_Bool strContainsString(char16_t *string, size_t stringLength, char16_t *substring, size_t substringLength);
void strToUpperCase(char16_t *string, size_t stringLength);
void strToLowerCase(char16_t *string, size_t stringLength);
_Bool strEqualsIgnoreCase(char16_t *a, size_t aLength, char16_t *b, size_t bLength);
char16_t *strReplaceString(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t *toReplace, size_t toReplaceLength, char16_t *replaceWith, size_t replaceWithLength);
char16_t *strReplaceCharacterToNew(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t toReplace, char16_t replaceWith);
void strReplaceCharacter(char16_t *string, size_t stringLength, char16_t toReplace, char16_t replaceWith);
char16_t *strTrim(size_t *returnArrayLength, char16_t *string, size_t stringLength);
_Bool strStartsWith(char16_t *string, size_t stringLength, char16_t *start, size_t startLength);
_Bool strEndsWith(char16_t *string, size_t stringLength, char16_t *end, size_t endLength);
StringReference **strSplitByString(size_t *returnArrayLength, char16_t *toSplit, size_t toSplitLength, char16_t *splitBy, size_t splitByLength);
_Bool strStringIsBefore(char16_t *a, size_t aLength, char16_t *b, size_t bLength);
char16_t *strJoinStringsWithSeparator(size_t *returnArrayLength, StringReference **strings, size_t stringsLength, char16_t *separator, size_t separatorLength);
char16_t *strJoinStrings(size_t *returnArrayLength, StringReference **strings, size_t stringsLength);
double strStringOrder(char16_t *a, size_t aLength, char16_t *b, size_t bLength);
char16_t *strLeftPad(size_t *returnArrayLength, char16_t *str, size_t strLength, double width);
char16_t *strRightPad(size_t *returnArrayLength, char16_t *str, size_t strLength, double width);

void AssertFalse(_Bool b, NumberReference *failures);
void AssertTrue(_Bool b, NumberReference *failures);
void AssertEquals(double a, double b, NumberReference *failures);
void AssertBooleansEqual(_Bool a, _Bool b, NumberReference *failures);
void AssertCharactersEqual(char16_t a, char16_t b, NumberReference *failures);
void AssertStringEquals(char16_t *a, size_t aLength, char16_t *b, size_t bLength, NumberReference *failures);
void AssertNumberArraysEqual(double *a, size_t aLength, double *b, size_t bLength, NumberReference *failures);
void AssertBooleanArraysEqual(_Bool *a, size_t aLength, _Bool *b, size_t bLength, NumberReference *failures);
void AssertStringArraysEqual(StringReference **a, size_t aLength, StringReference **b, size_t bLength, NumberReference *failures);

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
_Bool DivisibleBy(double a, double b);
double Combinations(double n, double k);
double Permutations(double n, double k);
_Bool EpsilonCompare(double a, double b, double epsilon);
double GreatestCommonDivisor(double a, double b);
double GCDWithSubtraction(double a, double b);
_Bool IsInteger(double a);
_Bool GreatestCommonDivisorWithCheck(double a, double b, NumberReference *gcdReference);
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
char16_t *Decimal15E2ToString(size_t *returnArrayLength, double decimal);
char16_t SingleDigitNumberToCharacter(double n);

char16_t cToLowerCase(char16_t character);
char16_t cToUpperCase(char16_t character);
_Bool cIsUpperCase(char16_t character);
_Bool cIsLowerCase(char16_t character);
_Bool cIsLetter(char16_t character);
_Bool cIsNumber(char16_t character);
_Bool cIsWhiteSpace(char16_t character);
_Bool cIsSymbol(char16_t character);
_Bool cCharacterIsBefore(char16_t a, char16_t b);
char16_t cDecimalDigitToCharacter(double digit);
double cCharacterToDecimalDigit(char16_t c);

Structure *CreateLedger(double decimals){
  Structure *ledger;
  Array *transactions;

  ledger = CreateStructure();
  transactions = CreateArray();
  AddNumberToStruct(ledger, strparam(u"decimals"), decimals);
  AddArrayToStruct(ledger, strparam(u"transactions"), transactions);

  return ledger;
}
FixedPoint15d *CreateFixedPointForDynamicLedger(Structure *ledger){
  FixedPoint15d *n;
  double d;

  d = GetNumberFromStruct(ledger, strparam(u"decimals"));
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
Line *CreateLine(char16_t *account, size_t accountLength, FixedPoint15d *debit, FixedPoint15d *credit, char16_t *description, size_t descriptionLength, Date *date){
  Line *t;

  t = (Line *)calloc(sizeof(Line), 1);

  t->account = arraysCopyString(&t->accountLength, account, accountLength);
  t->debit = Copy15d(debit);
  t->credit = Copy15d(credit);
  t->description = arraysCopyString(&t->descriptionLength, description, descriptionLength);
  t->date = CopyDate(date);

  return t;
}
void AddTransactionToLedger(Array *ledger, Line *src){
  Structure *dst;

  dst = LineToStructure(src);

  AddStructToArray(ledger, dst);
}
void AddTransactionsToLedger(Array *ledger, Line **ts, size_t tsLength){
  Structure *dst;
  double i;

  for(i = 0.0; i < (double)tsLength; i = i + 1.0){
    dst = LineToStructure(ts[(int)(i)]);
    AddStructToArray(ledger, dst);
  }
}
_Bool ValidateAndAddTransactionToLedger(Structure *ledger, Line **ls, size_t lsLength){
  Structure *dst;
  double i;
  _Bool valid;
  Array *transactions;
  Array *lines;

  transactions = GetArrayFromStruct(ledger, strparam(u"transactions"));

  valid = ValidateTransaction(ls, lsLength, ledger);

  if(valid){
    lines = CreateArray();

    for(i = 0.0; i < (double)lsLength; i = i + 1.0){
      dst = LineToStructure(ls[(int)(i)]);
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

  transactions = GetArrayFromStruct(ledger, strparam(u"transactions"));
  decimals = GetNumberFromStruct(ledger, strparam(u"decimals"));

  dst = ArrayIndexStruct(transactions, index);

  t = LineFromStructure(dst, ledger);

  return t;
}
Structure *LineToStructure(Line *src){
  Structure *dst;
  char16_t *debitStr, *creditStr, *dateStr;
  size_t debitStrLength, creditStrLength, dateStrLength;

  dst = CreateStructure();

  debitStr = ToString15d(&debitStrLength, src->debit);
  creditStr = ToString15d(&creditStrLength, src->credit);
  dateStr = DateToStringISO8601(&dateStrLength, src->date);

  AddStringToStruct(dst, strparam(u"account"), src->account, src->accountLength);
  AddStringToStruct(dst, strparam(u"debit"), debitStr, debitStrLength);
  AddStringToStruct(dst, strparam(u"credit"), creditStr, creditStrLength);
  AddStringToStruct(dst, strparam(u"date"), dateStr, dateStrLength);
  AddStringToStruct(dst, strparam(u"description"), src->description, src->descriptionLength);

  return dst;
}
Line *LineFromStructure(Structure *src, Structure *ledger){
  Line *dst;
  char16_t *account, *debitStr, *creditStr, *dateStr, *description;
  size_t accountLength, debitStrLength, creditStrLength, dateStrLength, descriptionLength;
  FixedPoint15d *debit, *credit;
  Date *date;
  double debitNumber, creditNumber;

  account = GetStringFromStruct(&accountLength, src, strparam(u"account"));
  debitStr = GetStringFromStruct(&debitStrLength, src, strparam(u"debit"));
  creditStr = GetStringFromStruct(&creditStrLength, src, strparam(u"credit"));
  dateStr = GetStringFromStruct(&dateStrLength, src, strparam(u"date"));
  description = GetStringFromStruct(&descriptionLength, src, strparam(u"description"));

  debitNumber = CreateNumberFromDecimalString(debitStr, debitStrLength);
  creditNumber = CreateNumberFromDecimalString(creditStr, creditStrLength);

  debit = CreateFixedPointForDynamicLedger(ledger);
  credit = CreateFixedPointForDynamicLedger(ledger);
  Assign15d(debit, debitNumber);
  Assign15d(credit, creditNumber);

  date = DateFromStringISO8601(dateStr, dateStrLength);

  dst = CreateLine(account, accountLength, debit, credit, description, descriptionLength, date);

  return dst;
}
Ledger *LedgerDynamicToStatic(Structure *src){
  Ledger *dst;
  double ts, ls, i, j, decimals;
  Structure *line;
  Array *transactions, *lines;
  Line *sline;
  Transaction *t;

  dst = (Ledger *)calloc(sizeof(Ledger), 1);

  transactions = GetArrayFromStruct(src, strparam(u"transactions"));
  decimals = GetNumberFromStruct(src, strparam(u"decimals"));
  ts = ArrayLength(transactions);

  dst->decimals = decimals;
  dst->transactions = (Transaction**)calloc(sizeof(Transaction) * (ts), 1);
  dst->transactionsLength = ts;

  for(i = 0.0; i < ts; i = i + 1.0){
    lines = ArrayIndexArray(transactions, i);
    ls = ArrayLength(lines);

    t = (Transaction *)calloc(sizeof(Transaction), 1);
    t->lines = (Line**)calloc(sizeof(Line) * (ls), 1);
    t->linesLength = ls;

    for(j = 0.0; j < ls; j = j + 1.0){
      line = ArrayIndexStruct(lines, j);
      sline = LineFromStructure(line, src);
      t->lines[(int)(j)] = sline;
    }

    dst->transactions[(int)(i)] = t;
  }

  return dst;
}
_Bool ValidateTransaction(Line **ts, size_t tsLength, Structure *ledger){
  _Bool valid;
  FixedPoint15d *creditSum, *debitSum;
  double i, d, c;
  Line *t;
  char16_t *creditStr, *debitStr;
  size_t creditStrLength, debitStrLength;
  Date *date;

  valid = true;

  if((double)tsLength > 0.0){
    date = ts[0]->date;

    creditSum = CreateFixedPointForDynamicLedger(ledger);
    debitSum = CreateFixedPointForDynamicLedger(ledger);

    for(i = 0.0; i < (double)tsLength && valid; i = i + 1.0){
      t = ts[(int)(i)];

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
      creditStr = ToString15d(&creditStrLength, creditSum);
      debitStr = ToString15d(&debitStrLength, creditSum);

      valid = arraysStringsEqual(creditStr, creditStrLength, debitStr, debitStrLength);
    }
  }

  return valid;
}
_Bool ValidateTransactions(Line **ts, size_t tsLength, NumberArrayReference *invalidIds){
  _Bool valid;

  /* TODO */
  valid = true;

  return valid;
}
Account *ComputeAccountBalance(Ledger *ledger, char16_t *accountName, size_t accountNameLength, Date *fromDate, Date *toDate){
  Account *a;
  double i, j;
  Transaction *t;
  Transaction **ts;
  size_t tsLength;
  Line *l;

  ts = ledger->transactions;
  tsLength = ledger->transactionsLength;

  a = (Account *)calloc(sizeof(Account), 1);

  a->name = arraysCopyString(&a->nameLength, accountName, accountNameLength);
  a->endingBalance = CreateFixedPointForStaticLedger(ledger);
  a->startingBalance = CreateFixedPointForStaticLedger(ledger);
  a->from = CopyDate(fromDate);
  a->to = CopyDate(toDate);
  a->sumDebit = CreateFixedPointForStaticLedger(ledger);
  a->sumCredit = CreateFixedPointForStaticLedger(ledger);

  for(i = 0.0; i < (double)tsLength; i = i + 1.0){
    t = ts[(int)(i)];

    for(j = 0.0; j < (double)t->linesLength; j = j + 1.0){
      l = t->lines[(int)(j)];

      if(arraysStringsEqual(l->account, l->accountLength, accountName, accountNameLength)){

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
char16_t *AccountToString(size_t *returnArrayLength, Account *account){
  LinkedListCharacters *ll;
  FixedPoint15d *diff;
  char16_t *tmp1, *tmp2;
  size_t tmp1Length, tmp2Length;

  ll = CreateLinkedListCharacter();

  diff = Copy15d(account->endingBalance);
  Subtract15d(diff, diff, account->startingBalance);

  LinkedListCharactersAddString(ll, account->name, account->nameLength);
  LinkedListCharactersAddString(ll, strparam(u": "));
  
  tmp1 = FormatToStringWithSymbols15d(&tmp1Length, account->startingBalance, 2.0, strparam(u""), strparam(u"."));
  LinkedListCharactersAddString(ll, tmp1, tmp1Length);
  LinkedListCharactersAddString(ll, strparam(u" -> "));
  tmp1 = FormatToStringWithSymbols15d(&tmp1Length, account->endingBalance, 2.0, strparam(u""), strparam(u"."));
  LinkedListCharactersAddString(ll, tmp1, tmp1Length);
  LinkedListCharactersAddString(ll, strparam(u": "));
  tmp1 = FormatToStringWithSymbols15d(&tmp1Length, diff, 2.0, strparam(u","), strparam(u"."));
  LinkedListCharactersAddString(ll, tmp1, tmp1Length);
  LinkedListCharactersAddString(ll, strparam(u" (+"));
  tmp1 = FormatToStringWithSymbols15d(&tmp1Length, account->sumDebit, 2.0, strparam(u""), strparam(u"."));
  LinkedListCharactersAddString(ll, tmp1, tmp1Length);
  LinkedListCharactersAddString(ll, strparam(u", -"));
  tmp1 = FormatToStringWithSymbols15d(&tmp1Length, account->sumCredit, 2.0, strparam(u""), strparam(u"."));
  LinkedListCharactersAddString(ll, tmp1, tmp1Length);
  LinkedListCharactersAddString(ll, strparam(u")"));

    return LinkedListCharactersToArray(returnArrayLength, ll);
}
void AddMonthlyAccruals(Structure *ledger, Date *from, Date *to, double amount, char16_t *fromAccount, size_t fromAccountLength, char16_t *toAccount, size_t toAccountLength){
  double i;
  char16_t *accountName, *desc;
  size_t accountNameLength, descLength;
  double *amounts;
  size_t amountsLength;
  Line **transaction;
  size_t transactionLength;
  _Bool valid;
  Date *date;
  FixedPoint15d *c, *d;

  amounts = GetAccrualsWithDates(&amountsLength, amount, from, to);

  date = CopyDate(from);
  date->day = 1.0;

  c = CreateFixedPointForDynamicLedger(ledger);
  d = CreateFixedPointForDynamicLedger(ledger);

  for(i = 0.0; i < (double)amountsLength; i = i + 1.0){
    transaction = (Line**)calloc(sizeof(Line) * (2.0), 1);
    transactionLength = 2.0;

    accountName = fromAccount;
    accountNameLength = fromAccountLength;
    Assign15d(d, amounts[(int)(i)]);
    Assign15d(c, 0.0);
    desc = u"x";
    descLength = c16len(desc);
    transaction[0] = CreateLine(accountName, accountNameLength, d, c, desc, descLength, date);

    accountName = toAccount;
    accountNameLength = toAccountLength;
    Assign15d(d, 0.0);
    Assign15d(c, amounts[(int)(i)]);
    desc = u"x";
    descLength = c16len(desc);
    transaction[1] = CreateLine(accountName, accountNameLength, d, c, desc, descLength, date);

    valid = ValidateAndAddTransactionToLedger(ledger, transaction, transactionLength);

    AddMonthsToDate(date, 1.0);
  }
}
FixedPoint15d *ComputeAccountBalancePrefixAccount(Ledger *ledger, char16_t *accountNr, size_t accountNrLength, Date *toDate, _Bool debitBalance){
  double i, j;
  Transaction *t;
  Transaction **ts;
  size_t tsLength;
  Line *l;
  FixedPoint15d *balance;
  LinkedListCharacters *prefixL;
  char16_t *prefixed;
  size_t prefixedLength;

  prefixL = CreateLinkedListCharacter();
  LinkedListCharactersAddString(prefixL, accountNr, accountNrLength);
  LinkedListCharactersAddString(prefixL, strparam(u"."));

  prefixed = LinkedListCharactersToArray(&prefixedLength, prefixL);

  ts = ledger->transactions;
  tsLength = ledger->transactionsLength;

  balance = CreateFixedPointForStaticLedger(ledger);

  for(i = 0.0; i < (double)tsLength; i = i + 1.0){
    t = ts[(int)(i)];

    for(j = 0.0; j < (double)t->linesLength; j = j + 1.0){
      l = t->lines[(int)(j)];

      if(strStartsWith(l->account, l->accountLength, prefixed, prefixedLength) || arraysStringsEqual(l->account, l->accountLength, accountNr, accountNrLength)){
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
  char16_t *accountPlanString;
  size_t accountPlanStringLength;
  BooleanReference *validRef;
  LinkedListCharacters *ll;

  ll = CreateLinkedListCharacter();

  /* https://www.ifrs-gaap.com/ifrs-chart-accounts */
  validRef = CreateBooleanReference(false);

  LinkedListCharactersAddString(ll, strparam(u"1\tAssets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1\tProperty, plant and equipment\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.1\tLand and land improvements\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.2\tBuildings, structures and improvements\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.3\tMachinery and equipment\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.4\tFixtures and fittings\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.5\tRight of use assets (classified as PP&E)\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.6\tAdditional property, plant and equipment\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1.7\tConstruction in progress\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.2\tInvestment property\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.2.1\tCompleted\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.2.2\tUnder construction or development\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.3\tGoodwill\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4\tIntangible assets excluding goodwill\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.1\tIntellectual property\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.2\tComputer software\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.3\tTrade and distribution assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.4\tContracts and rights\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.5\tRight of use assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.6\tCrypto assets (classified as intangible)\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.7\tAdditional intangible assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.4.8\tAcquisition in progress\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.5\tFinancial assets and investments\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.5.1\tNon-derivative financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.5.2\tDerivative financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.5.3\tAdditional financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.5.4\tCrypto assets (classified as financial assets)\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.6\tInventories\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.6.1\tMerchandise\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.6.2\tRaw materials and production supplies\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.6.3\tWork in progress\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.6.4\tFinished goods\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.6.5\tOther inventories\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.7\tPrepayments and accrued income\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.7.1\tPrepayments\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.7.2\tAccrued income\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.7.3\tService provider work in process (not classified as inventory)\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.7.4\tAdditional assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.8\tReceivables and contracts\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.8.1\tLoans and receivables\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.8.2\tContracts with customers\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.8.3\tNontrade and other receivables\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.9\tTax assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.9.1\tTax assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.9.2\tDeferred tax assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.9.3\tOther tax assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.1\tAgricultural biological assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.10.1\tBearer plants\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.10.2\tAnimals\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.10.3\tOther agricultural assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.11\tCash and cash equivalents\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.11.1\tCash\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.11.2\tCash equivalents\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"1.11.3\tRestricted cash and financial assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"2\tEquity\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.1\tTotal equity attributable to owners of parent\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.1.1\tIssued capital\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.1.2\tAdditional item paid-in capital\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.1.3\tPartner\'s capital\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.1.4\tMember\'s equity\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.1.5\tOther equity interest\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.2\tRetained earnings\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.2.1\tRetained earnings profit loss for reporting period\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.2.2\tRetained earnings excluding profit loss for reporting period\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.2.3\tIn suspense\tZero\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.3\tAccumulated other comprehensive income\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.3.1\tAccumulated OCI, reserves\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.3.2\tMiscellaneous equity\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.4\tOwners equity (non-shareholder)\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"2.5\tNon-controlling interests\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3\tLiabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.1\tTrade and other payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.1.1\tTrade payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.1.2\tDividend payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.1.3\tInterest payable\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.1.4\tOther payables\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.2\tProvisions\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.2.1\tCustomer related provisions\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.2.2\tLitigation and regulatory\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.2.3\tAdditional provisions\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3\tOther financial liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3.1\tNotes payable\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3.2\tLoans received\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3.3\tBonds (debentures)\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3.4\tOther debts and borrowings\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3.5\tLease obligations\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.3.6\tDerivative financial liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.4\tAccruals, deferrals and additional liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.4.1\tAccruals\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.4.2\tDeferred income and refund liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.4.3\tAccrued taxes other than payroll\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"3.4.4\tAdditional liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4\tRevenue\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.1\tRecognized point of time\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.1.1\tGoods\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.1.2\tServices\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.2\tRecognized over time\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.2.1\tProducts and projects\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.2.2\tServices\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.3\tAdjustments\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.3.1\tVariable consideration\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.3.2\tConsideration paid payable to customers\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"4.3.3\tOther adjustments\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5\tExpenses\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1\tExpenses (classified by nature)\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1.1\tMaterial and merchandise\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1.2\tEmployee benefits expense\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1.3\tServices expense\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1.4\tRent, depreciation, amortization and depletion\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1.5\tIncrease in decrease in inventories of finished goods and work in progress\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.1.6\tOther work performed by entity and capitalized\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.2\tExpenses (classified by function)\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.2.1\tCost of sales\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"5.2.2\tSelling, general and administrative expense\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"6\tOther non-operating income and expenses\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"6.1\tOther revenue and expenses\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"6.1.1\tOther revenue\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"6.1.2\tOther expenses\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"6.2\tGains and losses\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"6.3\tTaxes other than income and payroll and fees\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"6.4\tTax income (expense)\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7\tIntercompany and related party accounts\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.1\tIntercompany and related party assets\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.1.1\tIntercompany balances eliminated in consolidation\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.1.2\tRelated party balances reported or disclosed\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.1.3\tIntercompany investments\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.2\tIntercompany and related party liabilities\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.2.1\tIntercompany balances eliminated in consolidation\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.2.2\tRelated party balances reported or disclosed\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.3\tIntercompany and related party income and expense\tDr or (Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.3.1\tIntercompany and related party income\t(Cr)\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.3.2\tIntercompany and related party expenses\tDr\n"));
  LinkedListCharactersAddString(ll, strparam(u"7.3.3\tIncome loss from equity method investments\tDr or (Cr)\n"));

  accountPlanString = LinkedListCharactersToArray(&accountPlanStringLength, ll);

  FreeLinkedListCharacter(ll);

  return ParseAccountPlanString(accountPlanString, accountPlanStringLength, validRef);
}
AccountPlan *ParseAccountPlanString(char16_t *accountPlanString, size_t accountPlanStringLength, BooleanReference *valid){
  AccountPlan *ap;
  double i;
  char16_t *line;
  size_t lineLength;
  StringReference **lines, **parts;
  size_t linesLength, partsLength;
  AccountDefinition *ad;

  ap = (AccountPlan *)calloc(sizeof(AccountPlan), 1);

  accountPlanString = strTrim(&accountPlanStringLength, accountPlanString, accountPlanStringLength);
  lines = strSplitByCharacter(&linesLength, accountPlanString, accountPlanStringLength, '\n');

  ap->accountDefinitions = (AccountDefinition**)calloc(sizeof(AccountDefinition) * ((double)linesLength), 1);
  ap->accountDefinitionsLength = (double)linesLength;

  for(i = 0.0; i < (double)linesLength; i = i + 1.0){
    line = lines[(int)(i)]->string;
    lineLength = lines[(int)(i)]->stringLength;
    /*System.out.println(line); */
    parts = strSplitByCharacter(&partsLength, line, lineLength, '\t');

    ad = (AccountDefinition *)calloc(sizeof(AccountDefinition), 1);

    ad->accountName = parts[1]->string;
    ad->accountNameLength = parts[1]->stringLength;
    ad->number = parts[0]->string;
    ad->numberLength = parts[0]->stringLength;
    if(arraysStringsEqual(parts[2]->string, parts[2]->stringLength, strparam(u"(Cr)"))){
      ad->debitBalance = false;
    }else{
      ad->debitBalance = true;
    }
    ad->role = u"";
    ad->roleLength = c16len(ad->role);
    if(arraysStringsEqual(ad->number, ad->numberLength, strparam(u"1"))){
      ad->role = u"Assets";
      ad->roleLength = c16len(ad->role);
    }else if(arraysStringsEqual(ad->number, ad->numberLength, strparam(u"2"))){
      ad->role = u"Equities";
      ad->roleLength = c16len(ad->role);
    }else if(arraysStringsEqual(ad->number, ad->numberLength, strparam(u"3"))){
      ad->role = u"Liabilities";
      ad->roleLength = c16len(ad->role);
    }else if(arraysStringsEqual(ad->number, ad->numberLength, strparam(u"4"))){
      ad->role = u"Revenue";
      ad->roleLength = c16len(ad->role);
    }else if(arraysStringsEqual(ad->number, ad->numberLength, strparam(u"5"))){
      ad->role = u"Expenses";
      ad->roleLength = c16len(ad->role);
    }

    ap->accountDefinitions[(int)(i)] = ad;
  }

  return ap;
}
_Bool ComputeAccountBalances(Ledger *sledger, double depth, Date *date, DataReference *balanceSheet){
  AccountPlan *accountPlan;
  FixedPoint15d *assetsBalance, *liabilitiesBalance, *equitiesBalance, *revenueBalanace, *expensesBalance, *resultBalance, *sum, *balance;
  char16_t *balanceStr;
  size_t balanceStrLength;
  AccountDefinition *assetsDef, *liabilitiesDef, *equitiesDef, *revenueDef, *expensesDef, *accountDef;
  _Bool success, isBalanced;
  double i;
  StringReference **parts;
  size_t partsLength;
  BooleanReference *foundRef;
  Array *accounts;
  Structure *account;
  char16_t *dateStr;
  size_t dateStrLength;

  balanceSheet->data = CreateNewStructData();
  success = true;

  foundRef = CreateBooleanReference(false);

  accountPlan = sledger->accountPlan;

  assetsDef = FindAccountWithRole(accountPlan, strparam(u"Assets"), foundRef);
  success = success && foundRef->booleanValue;
  liabilitiesDef = FindAccountWithRole(accountPlan, strparam(u"Liabilities"), foundRef);
  success = success && foundRef->booleanValue;
  equitiesDef = FindAccountWithRole(accountPlan, strparam(u"Equities"), foundRef);
  success = success && foundRef->booleanValue;
  revenueDef = FindAccountWithRole(accountPlan, strparam(u"Revenue"), foundRef);
  success = success && foundRef->booleanValue;
  expensesDef = FindAccountWithRole(accountPlan, strparam(u"Expenses"), foundRef);
  success = success && foundRef->booleanValue;

  if(success){
    assetsBalance = ComputeAccountBalancePrefixAccount(sledger, assetsDef->number, assetsDef->numberLength, date, assetsDef->debitBalance);
    liabilitiesBalance = ComputeAccountBalancePrefixAccount(sledger, liabilitiesDef->number, liabilitiesDef->numberLength, date, liabilitiesDef->debitBalance);

    /* TODO: This must be for a period */
    revenueBalanace = ComputeAccountBalancePrefixAccount(sledger, revenueDef->number, revenueDef->numberLength, date, revenueDef->debitBalance);
    expensesBalance = ComputeAccountBalancePrefixAccount(sledger, expensesDef->number, expensesDef->numberLength, date, expensesDef->debitBalance);
    resultBalance = CreateFixedPointForStaticLedger(sledger);
    Subtract15d(resultBalance, revenueBalanace, expensesBalance);
    balanceStr = FormatToStringWithSymbols15d(&balanceStrLength, resultBalance, 2.0, strparam(u""), strparam(u"."));
    AddStringToStruct(balanceSheet->data->structure, strparam(u"result"), balanceStr, balanceStrLength);

    equitiesBalance = ComputeAccountBalancePrefixAccount(sledger, equitiesDef->number, equitiesDef->numberLength, date, equitiesDef->debitBalance);
    Add15d(equitiesBalance, equitiesBalance, resultBalance);

    /* Compute accounts */
    accounts = CreateArray();

    for(i = 0.0; i < (double)accountPlan->accountDefinitionsLength; i = i + 1.0){
      accountDef = accountPlan->accountDefinitions[(int)(i)];

      parts = strSplitByCharacter(&partsLength, accountDef->number, accountDef->numberLength, '.');

      if((double)partsLength <= depth + 1.0){
        account = CreateStructure();

        balance = ComputeAccountBalancePrefixAccount(sledger, accountDef->number, accountDef->numberLength, date, accountDef->debitBalance);

        balanceStr = FormatToStringWithSymbols15d(&balanceStrLength, balance, 2.0, strparam(u""), strparam(u"."));

        AddStringToStruct(account, strparam(u"number"), accountDef->number, accountDef->numberLength);
        AddStringToStruct(account, strparam(u"name"), accountDef->accountName, accountDef->accountNameLength);
        AddStringToStruct(account, strparam(u"balance"), balanceStr, balanceStrLength);
        AddNumberToStruct(account, strparam(u"depth"), (double)partsLength - 1.0);

        AddStructToArray(accounts, account);
      }
    }

    AddArrayToStruct(balanceSheet->data->structure, strparam(u"accounts"), accounts);

    /* End conclusion */
    balanceStr = FormatToStringWithSymbols15d(&balanceStrLength, assetsBalance, 2.0, strparam(u""), strparam(u"."));
    AddStringToStruct(balanceSheet->data->structure, strparam(u"assets"), balanceStr, balanceStrLength);

    sum = CreateFixedPointForStaticLedger(sledger);
    Add15d(sum, liabilitiesBalance, equitiesBalance);
    balanceStr = FormatToStringWithSymbols15d(&balanceStrLength, sum, 2.0, strparam(u""), strparam(u"."));
    AddStringToStruct(balanceSheet->data->structure, strparam(u"liabilitiesAndEquity"), balanceStr, balanceStrLength);

    isBalanced = Equals15d(sum, assetsBalance);
    AddBooleanToStruct(balanceSheet->data->structure, strparam(u"balanced"), isBalanced);

    dateStr = DateToStringISO8601(&dateStrLength, date);
    AddStringToStruct(balanceSheet->data->structure, strparam(u"date"), dateStr, dateStrLength);
  }

  return success;
}
char16_t *AccountBalancesToString(size_t *returnArrayLength, Structure *balanceSheet){
  LinkedListCharacters *ll;
  char16_t *balanceStr;
  size_t balanceStrLength;
  _Bool isBalanced;
  double i, j, depth;
  Array *accounts;
  Structure *account;
  char16_t *accountNumber, *accountName;
  size_t accountNumberLength, accountNameLength;

  ll = CreateLinkedListCharacter();

  /* Print accounts */
  accounts = GetArrayFromStruct(balanceSheet, strparam(u"accounts"));

  for(i = 0.0; i < ArrayLength(accounts); i = i + 1.0){
    account = ArrayIndexStruct(accounts, i);

    accountNumber = GetStringFromStruct(&accountNumberLength, account, strparam(u"number"));
    accountName = GetStringFromStruct(&accountNameLength, account, strparam(u"name"));
    balanceStr = GetStringFromStruct(&balanceStrLength, account, strparam(u"balance"));
    depth = GetNumberFromStruct(account, strparam(u"depth"));

    for(j = 0.0; j < depth; j = j + 1.0){
      LinkedListCharactersAddString(ll, strparam(u"  "));
    }

    LinkedListCharactersAddString(ll, accountNumber, accountNumberLength);
    LinkedListCharactersAddString(ll, strparam(u". "));
    LinkedListCharactersAddString(ll, accountName, accountNameLength);
    LinkedListCharactersAddString(ll, strparam(u": "));
    LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
    LinkedListCharactersAddString(ll, strparam(u"\n"));
  }

  /* End conclusion */
  LinkedListCharactersAddString(ll, strparam(u"\n"));

  LinkedListCharactersAddString(ll, strparam(u"Result: "));
  balanceStr = GetStringFromStruct(&balanceStrLength, balanceSheet, strparam(u"result"));
  LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
  LinkedListCharactersAddString(ll, strparam(u"\n"));

  LinkedListCharactersAddString(ll, strparam(u"Assets: "));
  balanceStr = GetStringFromStruct(&balanceStrLength, balanceSheet, strparam(u"assets"));
  LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
  LinkedListCharactersAddString(ll, strparam(u"\n"));

  LinkedListCharactersAddString(ll, strparam(u"Liabilities + Equities: "));
  balanceStr = GetStringFromStruct(&balanceStrLength, balanceSheet, strparam(u"liabilitiesAndEquity"));
  LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
  LinkedListCharactersAddString(ll, strparam(u"\n"));

  isBalanced = GetBooleanFromStruct(balanceSheet, strparam(u"balanced"));
  LinkedListCharactersAddString(ll, strparam(u"Balance: "));
  if(isBalanced){
    LinkedListCharactersAddString(ll, strparam(u"true"));
  }else{
    LinkedListCharactersAddString(ll, strparam(u"false"));
  }
  LinkedListCharactersAddString(ll, strparam(u"\n"));

    return LinkedListCharactersToArray(returnArrayLength, ll);
}
AccountDefinition *FindAccountWithRole(AccountPlan *accountPlan, char16_t *role, size_t roleLength, BooleanReference *foundRef){
  double i;
  AccountDefinition *ad;
  _Bool done;

  ad = (AccountDefinition *)calloc(sizeof(AccountDefinition), 1);

  done = false;
  for(i = 0.0; i < (double)accountPlan->accountDefinitionsLength &&  !done ; i = i + 1.0){
    ad = accountPlan->accountDefinitions[(int)(i)];
    if(arraysStringsEqual(ad->role, ad->roleLength, role, roleLength)){
      done = true;
    }
  }

  foundRef->booleanValue = done;

  return ad;
}
AccountDefinition *CreateAccountDefinition(char16_t *name, size_t nameLength, char16_t *number, size_t numberLength, char16_t *role, size_t roleLength, _Bool debitBalance){
  AccountDefinition *def;

  def = (AccountDefinition *)calloc(sizeof(AccountDefinition), 1);
  def->accountName = name;
  def->accountNameLength = nameLength;
  def->number = number;
  def->numberLength = numberLength;
  def->role = role;
  def->roleLength = roleLength;
  def->debitBalance = debitBalance;

  return def;
}
void ComputeBalanceDiffs(Ledger *sledger, Array *balances){
  double i, j;
  Structure *balance, *first, *balance1, *balance2;
  Structure *account1, *account2;
  char16_t *b1, *b2, *diffStr;
  size_t b1Length, b2Length, diffStrLength;
  FixedPoint15d *f1, *f2, *diff;
  Array *accountsO, *accounts1, *accounts2;

  first = ArrayIndexStruct(balances, 0.0);
  accountsO = GetArrayFromStruct(first, strparam(u"accounts"));

  for(j = 0.0; j < ArrayLength(accountsO); j = j + 1.0){
    for(i = 1.0; i < ArrayLength(balances); i = i + 1.0){
      balance1 = ArrayIndexStruct(balances, i - 1.0);
      balance2 = ArrayIndexStruct(balances, i);
      accounts1 = GetArrayFromStruct(balance1, strparam(u"accounts"));
      accounts2 = GetArrayFromStruct(balance2, strparam(u"accounts"));

      account1 = ArrayIndexStruct(accounts1, j);
      account2 = ArrayIndexStruct(accounts2, j);

      b1 = GetStringFromStruct(&b1Length, account1, strparam(u"balance"));
      b2 = GetStringFromStruct(&b2Length, account2, strparam(u"balance"));

      f1 = CreateFixedPointForStaticLedger(sledger);
      f2 = CreateFixedPointForStaticLedger(sledger);
      diff = CreateFixedPointForStaticLedger(sledger);

      Assign15d(f1, CreateNumberFromDecimalString(b1, b1Length));
      Assign15d(f2, CreateNumberFromDecimalString(b2, b2Length));

      Subtract15d(diff, f2, f1);

      diffStr = FormatToStringWithSymbols15d(&diffStrLength, diff, sledger->decimals, strparam(u""), strparam(u"."));

      /*System.out.println(diffStr); */
      if(i == 1.0){
        AddStringToStruct(account1, strparam(u"change"), strparam(u"0.00"));
      }
      AddStringToStruct(account2, strparam(u"change"), diffStr, diffStrLength);
    }
  }

  for(i = 1.0; i < ArrayLength(balances); i = i + 1.0){
    balance1 = ArrayIndexStruct(balances, i - 1.0);
    balance2 = ArrayIndexStruct(balances, i);
    b1 = GetStringFromStruct(&b1Length, balance1, strparam(u"result"));
    b2 = GetStringFromStruct(&b2Length, balance2, strparam(u"result"));

    f1 = CreateFixedPointForStaticLedger(sledger);
    f2 = CreateFixedPointForStaticLedger(sledger);
    diff = CreateFixedPointForStaticLedger(sledger);

    Assign15d(f1, CreateNumberFromDecimalString(b1, b1Length));
    Assign15d(f2, CreateNumberFromDecimalString(b2, b2Length));

    Subtract15d(diff, f2, f1);

    diffStr = FormatToStringWithSymbols15d(&diffStrLength, diff, sledger->decimals, strparam(u""), strparam(u"."));

    /*System.out.println(diffStr); */
    if(i == 1.0){
      AddStringToStruct(balance1, strparam(u"rchange"), strparam(u"0.00"));
    }
    AddStringToStruct(balance2, strparam(u"rchange"), diffStr, diffStrLength);
  }
}
char16_t *BalancesArrayToHTML(size_t *returnArrayLength, Array *balances, _Bool includeBalance, _Bool includeDiff){
  LinkedListCharacters *ll;
  double i, j;
  Structure *balance, *first;
  char16_t *dateStr, *name, *number, *balanceStr, *changeStr;
  size_t dateStrLength, nameLength, numberLength, balanceStrLength, changeStrLength;
  Structure *account;
  Array *accounts;

  ll = CreateLinkedListCharacter();

  LinkedListCharactersAddString(ll, strparam(u"<html>"));
  LinkedListCharactersAddString(ll, strparam(u"<body>"));
  LinkedListCharactersAddString(ll, strparam(u"<table>"));

  /* Headers */
  LinkedListCharactersAddString(ll, strparam(u"<tr>"));

  LinkedListCharactersAddString(ll, strparam(u"<td>"));
  LinkedListCharactersAddString(ll, strparam(u"</td>"));
  LinkedListCharactersAddString(ll, strparam(u"<td>"));
  LinkedListCharactersAddString(ll, strparam(u"</td>"));

  for(i = 0.0; i < ArrayLength(balances); i = i + 1.0){
    balance = ArrayIndexStruct(balances, i);
    dateStr = GetStringFromStruct(&dateStrLength, balance, strparam(u"date"));
    dateStr = strSubstring(&dateStrLength, dateStr, dateStrLength, 0.0, 7.0);

    LinkedListCharactersAddString(ll, strparam(u"<td>"));
    LinkedListCharactersAddString(ll, dateStr, dateStrLength);
    LinkedListCharactersAddString(ll, strparam(u"</td>"));
  }

  LinkedListCharactersAddString(ll, strparam(u"</tr>"));

  /* Each account */
  first = ArrayIndexStruct(balances, 0.0);
  accounts = GetArrayFromStruct(first, strparam(u"accounts"));
  for(j = 0.0; j < ArrayLength(accounts); j = j + 1.0){
    LinkedListCharactersAddString(ll, strparam(u"<tr>"));

    account = ArrayIndexStruct(accounts, j);
    name = GetStringFromStruct(&nameLength, account, strparam(u"name"));
    number = GetStringFromStruct(&numberLength, account, strparam(u"number"));

    LinkedListCharactersAddString(ll, strparam(u"<td>"));
    LinkedListCharactersAddString(ll, number, numberLength);
    LinkedListCharactersAddString(ll, strparam(u"</td>"));

    LinkedListCharactersAddString(ll, strparam(u"<td>"));
    LinkedListCharactersAddString(ll, name, nameLength);
    LinkedListCharactersAddString(ll, strparam(u"</td>"));

    for(i = 0.0; i < ArrayLength(balances); i = i + 1.0){
      balance = ArrayIndexStruct(balances, i);
      accounts = GetArrayFromStruct(balance, strparam(u"accounts"));
      account = ArrayIndexStruct(accounts, j);
      balanceStr = GetStringFromStruct(&balanceStrLength, account, strparam(u"balance"));
      changeStr = GetStringFromStruct(&changeStrLength, account, strparam(u"change"));

      LinkedListCharactersAddString(ll, strparam(u"<td style=\"text-align: right;\">"));

      if(includeBalance && includeDiff){
        LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
        LinkedListCharactersAddString(ll, strparam(u"<br><small style=\"color: grey\">"));
        LinkedListCharactersAddString(ll, changeStr, changeStrLength);
        LinkedListCharactersAddString(ll, strparam(u"</small>"));
      }else if(includeBalance){
        LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
      }else if(includeDiff){
        LinkedListCharactersAddString(ll, changeStr, changeStrLength);
      }

      LinkedListCharactersAddString(ll, strparam(u"</td>"));
    }

    LinkedListCharactersAddString(ll, strparam(u"</tr>"));
  }

  /* Result */
  LinkedListCharactersAddString(ll, strparam(u"<tr>"));

  LinkedListCharactersAddString(ll, strparam(u"<td>"));
  LinkedListCharactersAddString(ll, strparam(u""));
  LinkedListCharactersAddString(ll, strparam(u"</td>"));

  LinkedListCharactersAddString(ll, strparam(u"<td>"));
  LinkedListCharactersAddString(ll, strparam(u"Result"));
  LinkedListCharactersAddString(ll, strparam(u"</td>"));

  for(i = 0.0; i < ArrayLength(balances); i = i + 1.0){
    balance = ArrayIndexStruct(balances, i);
    balanceStr = GetStringFromStruct(&balanceStrLength, balance, strparam(u"result"));
    changeStr = GetStringFromStruct(&changeStrLength, balance, strparam(u"rchange"));

    LinkedListCharactersAddString(ll, strparam(u"<td style=\"text-align: right;\">"));

    if(includeBalance && includeDiff){
      LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
      LinkedListCharactersAddString(ll, strparam(u"<br><small style=\"color: grey\">"));
      LinkedListCharactersAddString(ll, changeStr, changeStrLength);
      LinkedListCharactersAddString(ll, strparam(u"</small>"));
    }else if(includeBalance){
      LinkedListCharactersAddString(ll, balanceStr, balanceStrLength);
    }else if(includeDiff){
      LinkedListCharactersAddString(ll, changeStr, changeStrLength);
    }

    LinkedListCharactersAddString(ll, strparam(u"</td>"));
  }

  LinkedListCharactersAddString(ll, strparam(u"</tr>"));

  /* Footer */
  LinkedListCharactersAddString(ll, strparam(u"</table>"));
  LinkedListCharactersAddString(ll, strparam(u"</body>"));
  LinkedListCharactersAddString(ll, strparam(u"</html>"));

    return LinkedListCharactersToArray(returnArrayLength, ll);
}
Line *CreateLineFromScript(Structure *ledger, char16_t *script, size_t scriptLength, Date *date){
  StringReference **parts;
  size_t partsLength;
  FixedPoint15d *c, *d;
  Line *line;
  double i, n;

  c = CreateFixedPointForDynamicLedger(ledger);
  d = CreateFixedPointForDynamicLedger(ledger);

  parts = strSplitByCharacter(&partsLength, script, scriptLength, ',');

  for(i = 0.0; i < (double)partsLength; i = i + 1.0){
    parts[(int)(i)]->string = strTrim(&parts[(int)(i)]->stringLength, parts[(int)(i)]->string, parts[(int)(i)]->stringLength);
  }

  line = (Line *)calloc(sizeof(Line), 1);

  n = CreateNumberFromDecimalString(parts[2]->string, parts[2]->stringLength);

  line->date = date;
  if(arraysStringsEqual(parts[0]->string, parts[0]->stringLength, strparam(u"Debit"))){
    Assign15d(d, n);
    Assign15d(c, 0.0);
  }else if(arraysStringsEqual(parts[0]->string, parts[0]->stringLength, strparam(u"Credit"))){
    Assign15d(d, 0.0);
    Assign15d(c, n);
  }

  line = CreateLine(parts[1]->string, parts[1]->stringLength, d, c, parts[3]->string, parts[3]->stringLength, date);

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
  Line **transaction;
  size_t transactionLength;
  _Bool valid;
  Date *date, *from, *to;
  Account *account;
  char16_t *accountName, *accountStr, *desc;
  size_t accountNameLength, accountStrLength, descLength;
  Ledger *sledger;

  ledger = CreateLedger(2.0);

  /*c = CreateFixedPointForDynamicLedger(ledger); */
  /*d = CreateFixedPointForDynamicLedger(ledger); */
  /* Transaction 1: */
  transaction = (Line**)calloc(sizeof(Line) * (2.0), 1);
  transactionLength = 2.0;
  /*date = CreateDate(2026d, 2d, 18d); */
  date = DateFromStringISO8601(strparam(u"2026-02-18"));

  /* Debit, 100, 1000, l1, 2026-02-18 */
  /*
        accountName = "1000".toCharArray();
        Assign15d(d, 100d);
        Assign15d(c, 0d);
        desc = "l1".toCharArray();
        transaction[0] = CreateLine(accountName, d, c, desc, date);
         */
  transaction[0] = CreateLineFromScript(ledger, strparam(u"Debit, 1000, 100, l1"), date);

  /* Credit, 100, 2000, l2, 2026-02-18 */
  /*
        accountName = "2000".toCharArray();
        Assign15d(d, 0d);
        Assign15d(c, 100d);
        desc = "l2".toCharArray();
        transaction[1] = CreateLine(accountName, d, c, desc, date);
         */
  transaction[1] = CreateLineFromScript(ledger, strparam(u"Credit, 2000, 100, l2"), date);

  valid = ValidateAndAddTransactionToLedger(ledger, transaction, transactionLength);

  AssertTrue(valid, failures);

  /* Compute */
  sledger = LedgerDynamicToStatic(ledger);

  accountName = u"1000";
  accountNameLength = c16len(accountName);
  from = DateFromStringISO8601(strparam(u"2026-02-17"));
  to = DateFromStringISO8601(strparam(u"2026-02-19"));
  account = ComputeAccountBalance(sledger, accountName, accountNameLength, from, to);

  accountStr = AccountToString(&accountStrLength, account);

  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1000: 0.00 -> 100.00: 100.00 (+100.00, -0.00)"), failures);
}
void TestAccruals(NumberReference *failures){
  Structure *ledger;
  FixedPoint15d *c, *d;
  Line **transaction;
  size_t transactionLength;
  _Bool valid, success;
  Date *date, *from, *to;
  Account *account;
  char16_t *accountName, *desc, *accountStr, *accountSummaryStr;
  size_t accountNameLength, descLength, accountStrLength, accountSummaryStrLength;
  Ledger *sledger;
  double *amounts;
  size_t amountsLength;
  double i;
  AccountDefinition *assetsDef, *liabilitiesDef, *equitiesDef, *incomeDef, *expensesDef, *accountDef;
  AccountDefinition *a148, *a150, *a192, *a290, *a300, *a600;
  AccountPlan *accountPlan;
  DataReference *balanceSheetRef;
  char16_t *html;
  size_t htmlLength;
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
  transaction = (Line**)calloc(sizeof(Line) * (2.0), 1);
  transactionLength = 2.0;
  date = DateFromStringISO8601(strparam(u"2025-09-17"));
  transaction[0] = CreateLineFromScript(ledger, strparam(u"Debit, 1.8.1, 125, x"), date);
  transaction[1] = CreateLineFromScript(ledger, strparam(u"Credit, 3.4.2, 125, x"), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction, transactionLength);
  AssertTrue(valid, failures);

  /* Transaction: Invoice paid */
  transaction = (Line**)calloc(sizeof(Line) * (2.0), 1);
  transactionLength = 2.0;
  date = DateFromStringISO8601(strparam(u"2025-10-01"));
  transaction[0] = CreateLineFromScript(ledger, strparam(u"Debit, 1.11.1, 125, x"), date);
  transaction[1] = CreateLineFromScript(ledger, strparam(u"Credit, 1.8.1, 125, x"), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction, transactionLength);
  AssertTrue(valid, failures);

  /* Transaction: Renewal paid */
  transaction = (Line**)calloc(sizeof(Line) * (2.0), 1);
  transactionLength = 2.0;
  date = DateFromStringISO8601(strparam(u"2025-11-08"));
  transaction[0] = CreateLineFromScript(ledger, strparam(u"Debit, 1.7.1, 112.50, x"), date);
  transaction[1] = CreateLineFromScript(ledger, strparam(u"Credit, 1.11.1, 112.50, x"), date);
  valid = ValidateAndAddTransactionToLedger(ledger, transaction, transactionLength);
  AssertTrue(valid, failures);

  /* Accruals income */
  from = DateFromStringISO8601(strparam(u"2025-12-06"));
  to = DateFromStringISO8601(strparam(u"2026-12-05"));
  AddMonthlyAccruals(ledger, from, to, 125.0, strparam(u"3.4.2"), strparam(u"4.1.2"));

  /* Accruals cost */
  from = DateFromStringISO8601(strparam(u"2025-12-06"));
  to = DateFromStringISO8601(strparam(u"2026-12-05"));
  AddMonthlyAccruals(ledger, from, to, 112.50, strparam(u"5.1.3"), strparam(u"1.7.1"));

  /* Compute */
  sledger = LedgerDynamicToStatic(ledger);

  from = DateFromStringISO8601(strparam(u"2027-01-01"));
  to = DateFromStringISO8601(strparam(u"2027-01-01"));

  account = ComputeAccountBalance(sledger, strparam(u"5.1.3"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"5.1.3: 112.50 -> 112.50: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"4.1.2"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"4.1.2: -125.00 -> -125.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"1.8.1"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"3.4.2"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"3.4.2: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"1.11.1"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"1.7.1"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1.7.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  /*System.out.println(""); */
  /* In between */
  from = DateFromStringISO8601(strparam(u"2026-06-15"));
  to = DateFromStringISO8601(strparam(u"2026-06-16"));

  account = ComputeAccountBalance(sledger, strparam(u"5.1.3"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"5.1.3: 64.17 -> 64.17: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"4.1.2"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"4.1.2: -71.28 -> -71.28: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"1.8.1"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1.8.1: 0.00 -> 0.00: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"3.4.2"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"3.4.2: -53.72 -> -53.72: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"1.11.1"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1.11.1: 12.50 -> 12.50: 0.00 (+0.00, -0.00)"), failures);

  account = ComputeAccountBalance(sledger, strparam(u"1.7.1"), from, to);
  accountStr = AccountToString(&accountStrLength, account);
  /*System.out.println(accountStr); */
  AssertStringEquals(accountStr, accountStrLength, strparam(u"1.7.1: 48.33 -> 48.33: 0.00 (+0.00, -0.00)"), failures);

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

  to = DateFromStringISO8601(strparam(u"2026-02-16"));
  balanceSheetRef = (DataReference *)calloc(sizeof(DataReference), 1);
  success = ComputeAccountBalances(sledger, 2.0, to, balanceSheetRef);
  accountSummaryStr = AccountBalancesToString(&accountSummaryStrLength, balanceSheetRef->data->structure);
  AssertTrue(success, failures);
  /*System.out.println(accountSummaryStr); */
  /* Compute monthly table */
  to = DateFromStringISO8601(strparam(u"2025-08-01"));
  message = (StringReference *)calloc(sizeof(StringReference), 1);
  AddDaysToDate(to,  -1.0, message);
  balances = CreateArray();
  for(i = 0.0; i < 12.0 + 6.0; i = i + 1.0){
    AddDaysToDate(to, 1.0, message);
    AddMonthsToDate(to, 1.0);
    AddDaysToDate(to,  -1.0, message);

    balanceSheetRef = (DataReference *)calloc(sizeof(DataReference), 1);
    success = ComputeAccountBalances(sledger, 1.0, to, balanceSheetRef);

    if(success){
      AddStructToArray(balances, balanceSheetRef->data->structure);
    }
  }
  ComputeBalanceDiffs(sledger, balances);

  html = BalancesArrayToHTML(&htmlLength, balances, true, false);

  /*StringToFile("x.html", html); */
  html = BalancesArrayToHTML(&htmlLength, balances, false, true);

  /*StringToFile("x-diff.html", html); */
  html = BalancesArrayToHTML(&htmlLength, balances, true, true);
}
BooleanReference *CreateBooleanReference(_Bool value){
  BooleanReference *ref;

  ref = (BooleanReference *)calloc(sizeof(BooleanReference), 1);
  ref->booleanValue = value;

  return ref;
}
BooleanArrayReference *CreateBooleanArrayReference(_Bool *value, size_t valueLength){
  BooleanArrayReference *ref;

  ref = (BooleanArrayReference *)calloc(sizeof(BooleanArrayReference), 1);
  ref->booleanArray = value;
  ref->booleanArrayLength = valueLength;

  return ref;
}
BooleanArrayReference *CreateBooleanArrayReferenceLengthValue(double length, _Bool value){
  BooleanArrayReference *ref;
  double i;

  ref = (BooleanArrayReference *)calloc(sizeof(BooleanArrayReference), 1);
  ref->booleanArray = (_Bool*)calloc(sizeof(_Bool) * (length), 1);
  ref->booleanArrayLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    ref->booleanArray[(int)(i)] = value;
  }

  return ref;
}
void FreeBooleanArrayReference(BooleanArrayReference *booleanArrayReference){
  free(booleanArrayReference->booleanArray);
  free(booleanArrayReference);
}
CharacterReference *CreateCharacterReference(char16_t value){
  CharacterReference *ref;

  ref = (CharacterReference *)calloc(sizeof(CharacterReference), 1);
  ref->characterValue = value;

  return ref;
}
NumberReference *CreateNumberReference(double value){
  NumberReference *ref;

  ref = (NumberReference *)calloc(sizeof(NumberReference), 1);
  ref->numberValue = value;

  return ref;
}
NumberArrayReference *CreateNumberArrayReference(double *value, size_t valueLength){
  NumberArrayReference *ref;

  ref = (NumberArrayReference *)calloc(sizeof(NumberArrayReference), 1);
  ref->numberArray = value;
  ref->numberArrayLength = valueLength;

  return ref;
}
NumberArrayReference *CreateNumberArrayReferenceLengthValue(double length, double value){
  NumberArrayReference *ref;
  double i;

  ref = (NumberArrayReference *)calloc(sizeof(NumberArrayReference), 1);
  ref->numberArray = (double*)calloc(sizeof(double) * (length), 1);
  ref->numberArrayLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    ref->numberArray[(int)(i)] = value;
  }

  return ref;
}
void FreeNumberArrayReference(NumberArrayReference *numberArrayReference){
  free(numberArrayReference->numberArray);
  free(numberArrayReference);
}
StringReference *CreateStringReference(char16_t *value, size_t valueLength){
  StringReference *ref;

  ref = (StringReference *)calloc(sizeof(StringReference), 1);
  ref->string = value;
  ref->stringLength = valueLength;

  return ref;
}
StringReference *CreateStringReferenceLengthValue(double length, char16_t value){
  StringReference *ref;
  double i;

  ref = (StringReference *)calloc(sizeof(StringReference), 1);
  ref->string = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
  ref->stringLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    ref->string[(int)(i)] = value;
  }

  return ref;
}
void FreeStringReference(StringReference *stringReference){
  free(stringReference->string);
  free(stringReference);
}
StringArrayReference *CreateStringArrayReference(StringReference **strings, size_t stringsLength){
  StringArrayReference *ref;

  ref = (StringArrayReference *)calloc(sizeof(StringArrayReference), 1);
  ref->stringArray = strings;
  ref->stringArrayLength = stringsLength;

  return ref;
}
StringArrayReference *CreateStringArrayReferenceLengthValue(double length, char16_t *value, size_t valueLength){
  StringArrayReference *ref;
  double i;

  ref = (StringArrayReference *)calloc(sizeof(StringArrayReference), 1);
  ref->stringArray = (StringReference**)calloc(sizeof(StringReference) * (length), 1);
  ref->stringArrayLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    ref->stringArray[(int)(i)] = CreateStringReference(value, valueLength);
  }

  return ref;
}
void FreeStringArrayReference(StringArrayReference *stringArrayReference){
  double i;

  for(i = 0.0; i < (double)stringArrayReference->stringArrayLength; i = i + 1.0){
    free(stringArrayReference->stringArray[(int)(i)]);
  }
  free(stringArrayReference->stringArray);
  free(stringArrayReference);
}
Date *CreateDate(double year, double month, double day){
  Date *date;

  date = (Date *)calloc(sizeof(Date), 1);

  date->year = year;
  date->month = month;
  date->day = day;

  return date;
}
_Bool IsLeapYearWithCheck(double year, BooleanReference *isLeapYearReference, StringReference *message){
  _Bool itIsLeapYear;
  _Bool success;

  if(year >= 1752.0){
    success = true;
    itIsLeapYear = IsLeapYear(year);
  }else{
    success = false;
    itIsLeapYear = false;
    message->string = u"Gregorian calendar was not in general use.";
    message->stringLength = c16len(message->string);
  }

  isLeapYearReference->booleanValue = itIsLeapYear;
  return success;
}
_Bool IsLeapYear(double year){
  _Bool itIsLeapYear;

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
_Bool DayToDateWithCheck(double dayNr, DateReference *dateReference, StringReference *message){
  Date *date;
  NumberReference *remainder;
  _Bool success;

  if(dayNr >=  -79623.0){
    date = (Date *)calloc(sizeof(Date), 1);
    remainder = (NumberReference *)calloc(sizeof(NumberReference), 1);
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
    message->string = u"Gregorian calendar was not in general use before 1752.";
    message->stringLength = c16len(message->string);
  }

  return success;
}
Date *DayToDate(double dayNr){
  Date *date;
  _Bool success;
  DateReference *dateRef;
  StringReference *message;

  dateRef = (DateReference *)calloc(sizeof(DateReference), 1);
  message = (StringReference *)calloc(sizeof(StringReference), 1);

  success = DayToDateWithCheck(dayNr, dateRef, message);
  if(success){
    date = dateRef->date;
    free(dateRef);
    FreeStringReference(message);
  }else{
    date = CreateDate(1970.0, 1.0, 1.0);
  }

  return date;
}
_Bool GetMonthFromDayNrWithCheck(double dayNr, double year, NumberReference *monthReference, NumberReference *remainderReference, StringReference *message){
  double month;
  _Bool success;

  if(dayNr >=  -79623.0){
    month = GetMonthFromDayNr(dayNr, year, remainderReference);
    monthReference->numberValue = month;
    success = true;
  }else{
    success = false;
    message->string = u"Gregorian calendar not in general use before 1752.";
    message->stringLength = c16len(message->string);
  }

  return success;
}
double GetMonthFromDayNr(double dayNr, double year, NumberReference *remainderReference){
  double *daysInMonth;
  size_t daysInMonthLength;
  _Bool done;
  double month;

  daysInMonth = GetDaysInMonth(&daysInMonthLength, year);
  done = false;
  month = 1.0;

  for(;  !done ; ){
    if(dayNr >= daysInMonth[(int)(month)]){
      dayNr = dayNr - daysInMonth[(int)(month)];
      month = month + 1.0;
    }else{
      done = true;
    }
  }
  remainderReference->numberValue = dayNr;

  return month;
}
_Bool GetYearFromDayNrWithCheck(double dayNr, NumberReference *yearReference, NumberReference *remainder, StringReference *message){
  _Bool success;
  double year;

  if(dayNr >= 0.0){
    success = true;
    year = GetYearFromDayNr(dayNr, remainder);
    yearReference->numberValue = year;
  }else{
    success = false;
    message->string = u"Day number must be 0 or higher. 0 is 1752-01-01.";
    message->stringLength = c16len(message->string);
  }

  return success;
}
double GetYearFromDayNr(double dayNr, NumberReference *remainder){
  double nrOfDays;
  _Bool done;
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
_Bool GetDaysInMonthWithCheck(double year, NumberArrayReference *daysInMonthReference, StringReference *message){
  double *daysInMonth;
  size_t daysInMonthLength;
  _Bool success;
  Date *date;

  date = CreateDate(year, 1.0, 1.0);

  success = IsValidDate(date, message);
  if(success){
    daysInMonth = GetDaysInMonth(&daysInMonthLength, year);

    daysInMonthReference->numberArray = daysInMonth;
    daysInMonthReference->numberArrayLength = daysInMonthLength;
  }

  return success;
}
double *GetDaysInMonth(size_t *returnArrayLength, double year){
  double *daysInMonth;
  size_t daysInMonthLength;

  daysInMonth = (double*)calloc(sizeof(double) * (1.0 + 12.0), 1);
  daysInMonthLength = 1.0 + 12.0;

  daysInMonth[0] = 0.0;
  daysInMonth[1] = 31.0;

  if(IsLeapYear(year)){
    daysInMonth[2] = 29.0;
  }else{
    daysInMonth[2] = 28.0;
  }
  daysInMonth[3] = 31.0;
  daysInMonth[4] = 30.0;
  daysInMonth[5] = 31.0;
  daysInMonth[6] = 30.0;
  daysInMonth[7] = 31.0;
  daysInMonth[8] = 31.0;
  daysInMonth[9] = 30.0;
  daysInMonth[10] = 31.0;
  daysInMonth[11] = 30.0;
  daysInMonth[12] = 31.0;

  *returnArrayLength = daysInMonthLength;
  return daysInMonth;
}
_Bool DateToDaysWithCheck(Date *date, NumberReference *dayNumberReferenceReference, StringReference *message){
  double days;
  _Bool success;

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
_Bool DateToWeekdayNumberWithCheck(Date *date, NumberReference *weekDayNumberReference, StringReference *message){
  double weekDay;
  _Bool success;

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
      free(newyears);
    }
  }else{
    /* Week is in previous year. Either 52nd or 53rd. */
    newyears = CopyDate(date);
    newyears->month = 12.0;
    newyears->day = 31.0;
    newyears->year = date->year - 1.0;
    weekNumber = DateToWeeknumber(newyears, yearRef);
    free(newyears);
  }

  free(week1Start);

  return weekNumber;
}
_Bool DaysInMonthsWithCheck(double month, double year, NumberReference *daysInMonthsReference, StringReference *message){
  double days;
  _Bool success;
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
  double *daysInMonth;
  size_t daysInMonthLength;
  double days;
  double i;

  daysInMonth = GetDaysInMonth(&daysInMonthLength, year);

  days = 0.0;
  for(i = 1.0; i < month; i = i + 1.0){
    days = days + daysInMonth[(int)(i)];
  }

  return days;
}
_Bool DaysInYearsWithCheck(double years, NumberReference *daysReference, StringReference *message){
  double days;
  _Bool success;
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
_Bool IsValidDate(Date *date, StringReference *message){
  _Bool valid;
  double *daysInMonth;
  size_t daysInMonthLength;
  double daysInThisMonth;

  if(date->year >= 1752.0){
    if(date->month >= 1.0 && date->month <= 12.0){
      daysInMonth = GetDaysInMonth(&daysInMonthLength, date->year);
      daysInThisMonth = daysInMonth[(int)(date->month)];
      if(date->day >= 1.0 && date->day <= daysInThisMonth){
        valid = true;
      }else{
        valid = false;
        message->string = u"The month does not have the given day number.";
        message->stringLength = c16len(message->string);
      }
    }else{
      valid = false;
      message->string = u"Month must be between 1 and 12, inclusive.";
      message->stringLength = c16len(message->string);
    }
  }else{
    valid = false;
    message->string = u"Gregorian calendar was not in general use before 1752.";
    message->stringLength = c16len(message->string);
  }

  return valid;
}
_Bool AddDaysToDate(Date *date, double days, StringReference *message){
  double n;
  _Bool success;
  DateReference *dateReference;
  NumberReference *daysRef;

  daysRef = (NumberReference *)calloc(sizeof(NumberReference), 1);
  success = DateToDaysWithCheck(date, daysRef, message);

  if(success){
    n = daysRef->numberValue;
    n = n + days;

    dateReference = (DateReference *)calloc(sizeof(DateReference), 1);
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
_Bool DateToStringISO8601WithCheck(Date *date, StringReference *datestr, StringReference *message){
  _Bool success;

  success = IsValidDate(date, message);

  if(success){
    if(date->year <= 9999.0){
      datestr->string = DateToStringISO8601(&datestr->stringLength, date);
    }else{
      message->string = u"This library works from 1752 to 9999.";
      message->stringLength = c16len(message->string);
    }
  }

  return success;
}
char16_t *DateToStringISO8601(size_t *returnArrayLength, Date *date){
  char16_t *str;
  size_t strLength;

  str = (char16_t*)calloc(sizeof(char16_t) * (10.0), 1);
  strLength = 10.0;

  str[0] = cDecimalDigitToCharacter(floor(date->year/1000.0));
  str[1] = cDecimalDigitToCharacter(floor((fmod(date->year, 1000.0))/100.0));
  str[2] = cDecimalDigitToCharacter(floor((fmod(date->year, 100.0))/10.0));
  str[3] = cDecimalDigitToCharacter(floor(fmod(date->year, 10.0)));

  str[4] = '-';

  str[5] = cDecimalDigitToCharacter(floor((fmod(date->month, 100.0))/10.0));
  str[6] = cDecimalDigitToCharacter(floor(fmod(date->month, 10.0)));

  str[7] = '-';

  str[8] = cDecimalDigitToCharacter(floor((fmod(date->day, 100.0))/10.0));
  str[9] = cDecimalDigitToCharacter(floor(fmod(date->day, 10.0)));

  *returnArrayLength = strLength;
  return str;
}
Date *DateFromStringISO8601(char16_t *str, size_t strLength){
  Date *date;
  double n;

  date = (Date *)calloc(sizeof(Date), 1);

  n = cCharacterToDecimalDigit(str[0])*1000.0;
  n = n + cCharacterToDecimalDigit(str[1])*100.0;
  n = n + cCharacterToDecimalDigit(str[2])*10.0;
  n = n + cCharacterToDecimalDigit(str[3])*1.0;

  date->year = n;

  n = cCharacterToDecimalDigit(str[5])*10.0;
  n = n + cCharacterToDecimalDigit(str[6])*1.0;

  date->month = n;

  n = cCharacterToDecimalDigit(str[8])*10.0;
  n = n + cCharacterToDecimalDigit(str[9])*1.0;

  date->day = n;

  return date;
}
_Bool DateFromStringISO8601WithCheck(char16_t *str, size_t strLength, DateReference *dateRef, StringReference *message){
  _Bool valid;

  valid = IsValidDateISO8601(str, strLength, message);

  if(valid){
    dateRef->date = DateFromStringISO8601(str, strLength);
  }

  return valid;
}
_Bool IsValidDateISO8601(char16_t *str, size_t strLength, StringReference *message){
  _Bool valid;

  if((double)strLength == 4.0 + 1.0 + 2.0 + 1.0 + 2.0){

    if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9])){
      if(str[4] == '-' && str[7] == '-'){
        valid = true;
      }else{
        valid = false;
        message->string = u"ISO8601 date must use \'-\' in positions 5 and 8.";
        message->stringLength = c16len(message->string);
      }
    }else{
      valid = false;
      message->string = u"ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.";
      message->stringLength = c16len(message->string);
    }
  }else{
    valid = false;
    message->string = u"ISO8601 date must be exactly 10 characters long.";
    message->stringLength = c16len(message->string);
  }

  return valid;
}
_Bool DateEquals(Date *a, Date *b){
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
  _Bool success;

  seconds = 0.0;
  dayNumberReferenceReference = (NumberReference *)calloc(sizeof(NumberReference), 1);
  message = (StringReference *)calloc(sizeof(StringReference), 1);

  success = DateToDaysWithCheck(date, dayNumberReferenceReference, message);
  if(success){
    days = dayNumberReferenceReference->numberValue;

    secondsInMinute = 60.0;
    secondsInHour = 60.0*secondsInMinute;
    secondsInDay = 24.0*secondsInHour;

    seconds = seconds + secondsInDay*days;
  }

  free(dayNumberReferenceReference);
  free(message);

  return seconds;
}
_Bool DateIsInInterval(Interval *interval, Date *date){
  double from, to, day;

  from = DateToDays(interval->first);
  to = DateToDays(interval->last);
  day = DateToDays(date);

  return day >= from && day <= to;
}
_Bool DateLessThan(Date *a, Date *b){
  double aDays, bDays;

  aDays = DateToDays(a);
  bDays = DateToDays(b);

  return aDays < bDays;
}
DateTimeTimezone *CreateDateTimeTimezone(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetSeconds){
  DateTimeTimezone *dateTimeTimezone;

  dateTimeTimezone = (DateTimeTimezone *)calloc(sizeof(DateTimeTimezone), 1);

  dateTimeTimezone->dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
  dateTimeTimezone->timezoneOffsetSeconds = timezoneOffsetSeconds;

  return dateTimeTimezone;
}
DateTimeTimezone *CreateDateTimeTimezoneInHoursAndMinutes(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetHours, double timezoneOffsetMinutes){
  DateTimeTimezone *dateTimeTimezone;

  dateTimeTimezone = (DateTimeTimezone *)calloc(sizeof(DateTimeTimezone), 1);

  dateTimeTimezone->dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
  dateTimeTimezone->timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes);

  return dateTimeTimezone;
}
_Bool GetDateFromDateTimeTimeZone(DateTimeTimezone *dateTimeTimezone, DateTimeReference *dateTimeReference, StringReference *message){
  DateTime *dateTime;

  dateTime = dateTimeTimezone->dateTime;

  return AddSecondsToDateTimeWithCheck(dateTime,  -dateTimeTimezone->timezoneOffsetSeconds, dateTimeReference, message);
}
_Bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(DateTime *dateTime, double timezoneOffsetSeconds, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message){
  _Bool success;
  DateTimeReference *adjustedDateTimeReference;
  DateTimeTimezone *dateTimeTimezone;

  adjustedDateTimeReference = (DateTimeReference *)calloc(sizeof(DateTimeReference), 1);
  dateTimeTimezone = (DateTimeTimezone *)calloc(sizeof(DateTimeTimezone), 1);

  success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message);

  if(success){
    dateTimeTimezone->dateTime = adjustedDateTimeReference->dateTime;
    dateTimeTimezone->timezoneOffsetSeconds = timezoneOffsetSeconds;

    dateTimeTimezoneReference->dateTimeTimezone = dateTimeTimezone;
  }

  return success;
}
_Bool CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(DateTime *dateTime, double timezoneOffsetHours, double timezoneOffsetMinutes, DateTimeTimezoneReference *dateTimeTimezoneReference, StringReference *message){
  return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message);
}
_Bool GetDateTimeTimezoneFromSeconds(DateTimeTimezoneReference *dateTimeTzRef, double seconds, double offset, StringReference *message){
  _Bool success;
  DateTimeReference *dateTimeRef;

  dateTimeRef = (DateTimeReference *)calloc(sizeof(DateTimeReference), 1);
  success = GetDateTimeFromSeconds(seconds, dateTimeRef, message);

  if(success){
    success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef->dateTime, offset, dateTimeTzRef, message);
  }

  return success;
}
DateTime *CreateDateTime(double year, double month, double day, double hours, double minutes, double seconds){
  DateTime *dateTime;

  dateTime = (DateTime *)calloc(sizeof(DateTime), 1);

  dateTime->date = CreateDate(year, month, day);
  dateTime->hours = hours;
  dateTime->minutes = minutes;
  dateTime->seconds = seconds;

  return dateTime;
}
_Bool GetDateTimeFromSeconds(double seconds, DateTimeReference *dateTimeReference, StringReference *message){
  DateTime *dateTime;
  double secondsInMinute, secondsInHour, secondsInDay, days, remainder;
  Date *date;
  DateReference *dateReference;
  _Bool success;

  secondsInMinute = 60.0;
  secondsInHour = 60.0*secondsInMinute;
  secondsInDay = 24.0*secondsInHour;
  days = floor(seconds/secondsInDay);
  remainder = seconds - days*secondsInDay;
  dateReference = (DateReference *)calloc(sizeof(DateReference), 1);

  success = DayToDateWithCheck(days, dateReference, message);
  if(success){
    date = dateReference->date;

    dateTime = (DateTime *)calloc(sizeof(DateTime), 1);
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
_Bool AddSecondsToDateTimeWithCheck(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message){
  double secondsInDateTime;
  _Bool success;

  if(IsValidDateTime(dateTime, message)){
    secondsInDateTime = GetSecondsFromDateTime(dateTime);
    secondsInDateTime = secondsInDateTime + seconds;

    success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
  }else{
    success = false;
  }

  return success;
}
_Bool AddSecondsToDateTime(DateTime *dateTime, double seconds, DateTimeReference *dateTimeReference, StringReference *message){
  double secondsInDateTime;

  secondsInDateTime = GetSecondsFromDateTime(dateTime);
  secondsInDateTime = secondsInDateTime + seconds;

  return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
}
_Bool AddMinutesToDateTime(DateTime *dateTime, double minutes, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message);
}
_Bool AddHoursToDateTime(DateTime *dateTime, double hours, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message);
}
_Bool AddDaysToDateTime(DateTime *dateTime, double days, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message);
}
_Bool AddWeeksToDateTime(DateTime *dateTime, double weeks, DateTimeReference *dateTimeReference, StringReference *message){
  return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message);
}
_Bool DateTimeToStringISO8601WithCheck(DateTime *datetime, StringReference *dateStr, StringReference *message){
  _Bool success;

  success = DateToStringISO8601WithCheck(datetime->date, dateStr, message);

  if(success){
    free(dateStr->string);

    success = IsValidDateTime(datetime, message);
    if(success){
      dateStr->string = DateTimeToStringISO8601(&dateStr->stringLength, datetime);
    }
  }

  return success;
}
_Bool IsValidDateTime(DateTime *datetime, StringReference *message){
  _Bool success;

  success = IsValidDate(datetime->date, message);

  if(success){
    if(datetime->hours <= 23.0 && datetime->hours >= 0.0){
      if(datetime->minutes <= 59.0 && datetime->minutes >= 0.0){
        if(datetime->seconds <= 59.0 && datetime->seconds >= 0.0){
          success = true;
        }else{
          success = false;
          message->string = u"Seconds must be between 0 and 59.";
          message->stringLength = c16len(message->string);
        }
      }else{
        success = false;
        message->string = u"Minutes must be between 0 and 59.";
        message->stringLength = c16len(message->string);
      }
    }else{
      success = false;
      message->string = u"Hours must be between 0 and 23.";
      message->stringLength = c16len(message->string);
    }
  }

  return success;
}
char16_t *DateTimeToStringISO8601(size_t *returnArrayLength, DateTime *datetime){
  char16_t *datestr, *str;
  size_t datestrLength, strLength;
  double i;

  str = (char16_t*)calloc(sizeof(char16_t) * (19.0), 1);
  strLength = 19.0;

  datestr = DateToStringISO8601(&datestrLength, datetime->date);
  for(i = 0.0; i < (double)datestrLength; i = i + 1.0){
    str[(int)(i)] = datestr[(int)(i)];
  }

  str[10] = 'T';
  str[11] = cDecimalDigitToCharacter(floor((fmod(datetime->hours, 100.0))/10.0));
  str[12] = cDecimalDigitToCharacter(floor(fmod(datetime->hours, 10.0)));

  str[13] = ':';

  str[14] = cDecimalDigitToCharacter(floor((fmod(datetime->minutes, 100.0))/10.0));
  str[15] = cDecimalDigitToCharacter(floor(fmod(datetime->minutes, 10.0)));

  str[16] = ':';

  str[17] = cDecimalDigitToCharacter(floor((fmod(datetime->seconds, 100.0))/10.0));
  str[18] = cDecimalDigitToCharacter(floor(fmod(datetime->seconds, 10.0)));

  *returnArrayLength = strLength;
  return str;
}
DateTime *DateTimeFromStringISO8601(char16_t *str, size_t strLength){
  DateTime *dateTime;
  double n;

  dateTime = (DateTime *)calloc(sizeof(DateTime), 1);

  dateTime->date = DateFromStringISO8601(str, strLength);

  n = cCharacterToDecimalDigit(str[11])*10.0;
  n = n + cCharacterToDecimalDigit(str[12])*1.0;

  dateTime->hours = n;

  n = cCharacterToDecimalDigit(str[14])*10.0;
  n = n + cCharacterToDecimalDigit(str[15])*1.0;

  dateTime->minutes = n;

  n = cCharacterToDecimalDigit(str[17])*10.0;
  n = n + cCharacterToDecimalDigit(str[18])*1.0;

  dateTime->seconds = n;

  return dateTime;
}
_Bool DateTimeFromStringISO8601WithCheck(char16_t *str, size_t strLength, DateTimeReference *dateTimeRef, StringReference *message){
  _Bool valid;

  valid = IsValidDateTimeISO8601(str, strLength, message);

  if(valid){
    dateTimeRef->dateTime = DateTimeFromStringISO8601(str, strLength);
  }

  return valid;
}
_Bool IsValidDateTimeISO8601(char16_t *str, size_t strLength, StringReference *message){
  _Bool valid;

  if((double)strLength == 4.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0 + 1.0 + 2.0){

    if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9]) && cIsNumber(str[11]) && cIsNumber(str[12]) && cIsNumber(str[14]) && cIsNumber(str[15]) && cIsNumber(str[17]) && cIsNumber(str[18])){
      if(str[4] == '-' && str[7] == '-' && str[10] == 'T' && str[13] == ':' && str[16] == ':'){
        valid = true;
      }else{
        valid = false;
        message->string = u"ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.";
        message->stringLength = c16len(message->string);
      }
    }else{
      valid = false;
      message->string = u"ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.";
      message->stringLength = c16len(message->string);
    }
  }else{
    valid = false;
    message->string = u"ISO8601 date must be exactly 19 characters long.";
    message->stringLength = c16len(message->string);
  }

  return valid;
}
_Bool DateTimeEquals(DateTime *a, DateTime *b){
  return DateEquals(a->date, b->date) && a->hours == b->hours && a->minutes == b->minutes && a->seconds == b->seconds;
}
void FreeDateTime(DateTime *datetime){
  free(datetime->date);
  free(datetime);
}
FixedPoint30d *CreateFixedPoint30d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
  FixedPoint30d *fp;

  fp = (FixedPoint30d *)calloc(sizeof(FixedPoint30d), 1);
  fp->digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
  fp->digitsAfterDecimalPoint = digitsAfterDecimalPoint;
  fp->part1 = 0.0;
  fp->part2 = 0.0;

  return fp;
}
FixedPoint15d *CreateFixedPoint15d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
  FixedPoint15d *fp;

  fp = (FixedPoint15d *)calloc(sizeof(FixedPoint15d), 1);
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

  fp = (FixedPoint15d *)calloc(sizeof(FixedPoint15d), 1);
  fp->digitsBeforeDecimalPoint = 7.0;
  fp->digitsAfterDecimalPoint = 7.0;
  fp->number = number;

  return fp;
}
_Bool Assign15d(FixedPoint15d *fp, double number){
  _Bool success;

  success =  !WillOverflow15d(fp, number) ;
  success = success && FixedPointIsValid15d(fp);

  if(success){
    fp->number = number;
    fp->number = RoundToDigits(fp->number, fp->digitsAfterDecimalPoint);
  }

  return success;
}
_Bool Assign15dFloor(FixedPoint15d *fp, double number){
  _Bool success;

  success =  !WillOverflow15d(fp, number) ;
  success = success && FixedPointIsValid15d(fp);

  if(success){
    fp->number = number;
    fp->number = FloorToDigits(fp->number, fp->digitsAfterDecimalPoint);
  }

  return success;
}
_Bool FixedPointIsValid15d(FixedPoint15d *fp){
  _Bool valid;

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
_Bool WillOverflow15d(FixedPoint15d *fp, double number){
  _Bool overflow;

  if(fabs(number) < pow(10.0, fp->digitsBeforeDecimalPoint)){
    overflow = false;
  }else{
    overflow = true;
  }

  return overflow;
}
double FloorToDigits(double value, double digits){
  return floor(value*pow(10.0, digits))/pow(10.0, digits);
}
char16_t *ToString15d(size_t *returnArrayLength, FixedPoint15d *fp){
  char16_t *string;
  size_t stringLength;
  double digits;
  double digitPosition;
  double i, d, decimal;
  CharacterReference *characterReference;

  string = (char16_t*)calloc(sizeof(char16_t) * (1.0 + fp->digitsBeforeDecimalPoint + 1.0 + fp->digitsAfterDecimalPoint), 1);
  stringLength = 1.0 + fp->digitsBeforeDecimalPoint + 1.0 + fp->digitsAfterDecimalPoint;

  decimal = fp->number*pow(10.0, fp->digitsAfterDecimalPoint);

  if(decimal < 0.0){
    decimal =  -decimal;
    string[0] = '-';
  }else{
    string[0] = '+';
  }

  decimal = Round(decimal);

  characterReference = (CharacterReference *)calloc(sizeof(CharacterReference), 1);

  digits = fp->digitsBeforeDecimalPoint + fp->digitsAfterDecimalPoint;
  digitPosition = 1.0;

  for(i = 0.0; i < digits; i = i + 1.0){
    if(i == fp->digitsBeforeDecimalPoint){
      string[(int)(digitPosition)] = '.';

      digitPosition = digitPosition + 1.0;
    }

    d = floor(decimal/pow(10.0, digits - i - 1.0));
    d = fmod(d, 10.0);

    GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference);
    string[(int)(digitPosition)] = characterReference->characterValue;

    digitPosition = digitPosition + 1.0;
  }

  free(characterReference);

  *returnArrayLength = stringLength;
  return string;
}
_Bool Add15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c){
  return Assign15d(a, b->number + c->number);
}
_Bool Subtract15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c){
  return Assign15d(a, b->number - c->number);
}
_Bool Multiply15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *c){
  return Assign15d(a, b->number*c->number);
}
_Bool DivideFloored15d(FixedPoint15d *q, FixedPoint15d *r, FixedPoint15d *a, FixedPoint15d *b){
  _Bool success;
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

  free(t);

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
_Bool Factorial15d(FixedPoint15d *x){
  _Bool success;

  if(x->number >= 0.0){
    success = Assign15d(x, Factorial(x->number));
  }else{
    success = false;
  }

  return success;
}
_Bool Round15d(FixedPoint15d *x){
  return Assign15d(x, Round(x->number));
}
_Bool BankersRound15d(FixedPoint15d *x){
  return Assign15d(x, BankersRound(x->number));
}
_Bool Ceil15d(FixedPoint15d *x){
  return Assign15d(x, Ceil(x->number));
}
_Bool Floor15d(FixedPoint15d *x){
  return Assign15d(x, floor(x->number));
}
void Truncate15d(FixedPoint15d *x){
  x->number = Truncate(x->number);
}
void Absolute15d(FixedPoint15d *x){
  x->number = fabs(x->number);
}
_Bool Logarithm15d(FixedPoint15d *x){
  _Bool success;

  if(x->number > 0.0){
    success = Assign15d(x, Logarithm(x->number));
  }else{
    success = false;
  }

  return success;
}
_Bool NaturalLogarithm15d(FixedPoint15d *x){
  _Bool success;

  if(x->number > 0.0){
    success = Assign15d(x, NaturalLogarithm(x->number));
  }else{
    success = false;
  }

  return success;
}
_Bool Sin15d(FixedPoint15d *x){
  return Assign15d(x, Sin(x->number));
}
_Bool Cos15d(FixedPoint15d *x){
  return Assign15d(x, Cos(x->number));
}
_Bool Tan15d(FixedPoint15d *x){
  return Assign15d(x, Tan(x->number));
}
_Bool Asin15d(FixedPoint15d *x){
  _Bool success;

  if(x->number >=  -1.0 && x->number <= 1.0){
    success = Assign15d(x, Asin(x->number));
  }else{
    success = false;
  }

  return success;
}
_Bool Acos15d(FixedPoint15d *x){
  _Bool success;

  if(x->number >=  -1.0 && x->number <= 1.0){
    success = Assign15d(x, Acos(x->number));
  }else{
    success = false;
  }

  return success;
}
_Bool Atan15d(FixedPoint15d *x){
  return Assign15d(x, Atan(x->number));
}
_Bool Atan2_15d(FixedPoint15d *a, FixedPoint15d *y, FixedPoint15d *x){
  return Assign15d(a, Atan2(y->number, x->number));
}
_Bool Squareroot15d(FixedPoint15d *x){
  _Bool success;

  if(x->number >= 0.0){
    success = Assign15d(x, sqrt(x->number));
  }else{
    success = false;
  }

  return success;
}
_Bool Exp15d(FixedPoint15d *x){
  return Assign15d(x, Exp(x->number));
}
_Bool DivisibleBy15d(FixedPoint15d *a, FixedPoint15d *b){
  return ((fmod(a->number, b->number)) == 0.0);
}
_Bool Combinations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k){
  _Bool success;

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
_Bool Permutations15d(FixedPoint15d *x, FixedPoint15d *n, FixedPoint15d *k){
  _Bool success;

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
_Bool Equals15d(FixedPoint15d *a, FixedPoint15d *b){
  double p, an, bn;
  _Bool equals;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  p = fmax(a->digitsAfterDecimalPoint, b->digitsAfterDecimalPoint);

  equals = EpsilonCompare(an, bn, pow(10.0,  -p));

  return equals;
}
_Bool GreaterThan15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  return an > bn;
}
_Bool LessThan15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  return an < bn;
}
_Bool GreaterThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;
  _Bool equal;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  equal = Equals15d(a, b);

  return an > bn || equal;
}
_Bool LessThanOrEqual15d(FixedPoint15d *a, FixedPoint15d *b){
  double an, bn;
  _Bool equal;

  an = ToNumber15d(a);
  bn = ToNumber15d(b);

  equal = Equals15d(a, b);

  return an < bn || equal;
}
_Bool EpsilonCompare15d(FixedPoint15d *a, FixedPoint15d *b, FixedPoint15d *epsilon){
  return EpsilonCompare(a->number, b->number, epsilon->number);
}
_Bool GreatestCommonDivisor15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  _Bool success;

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
_Bool GCDWithSubtraction15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  _Bool success;

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
_Bool IsInteger15d(FixedPoint15d *a){
  return IsInteger(a->number);
}
_Bool LeastCommonMultiple15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  _Bool success;

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
_Bool Max15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  return Assign15d(x, Max(a->number, b->number));
}
_Bool Min15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  return Assign15d(x, Min(a->number, b->number));
}
_Bool Power15d(FixedPoint15d *x, FixedPoint15d *a, FixedPoint15d *b){
  _Bool success;

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
char16_t *FormatToString15d(size_t *returnArrayLength, FixedPoint15d *fp, double digitsAfter){
  char16_t *result;
  size_t resultLength;

  result = FormatToStringWithSymbols15d(&resultLength, fp, digitsAfter, strparam(u""), strparam(u"."));

  *returnArrayLength = resultLength;
  return result;
}
char16_t *FormatToStringWithSymbols15d(size_t *returnArrayLength, FixedPoint15d *fp, double digitsAfter, char16_t *thousandsSeparator, size_t thousandsSeparatorLength, char16_t *decimalPoint, size_t decimalPointLength){
  char16_t *string;
  size_t stringLength;
  double i, j, p, d, t, sign, extra, decimal, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars;
  CharacterReference *characterReference;

  characterReference = (CharacterReference *)calloc(sizeof(CharacterReference), 1);

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
  thousandsChars = thousandsTimes*(double)thousandsSeparatorLength;

  if(digitsAfter == 0.0){
    decimalPointChars = 0.0;
  }else{
    decimalPointChars = (double)decimalPointLength;
  }

  string = (char16_t*)calloc(sizeof(char16_t) * (sign + digits + thousandsChars + decimalPointChars), 1);
  stringLength = sign + digits + thousandsChars + decimalPointChars;
  p = 0.0;

  if(sign > 0.0){
    string[(int)(p)] = '-';
    p = p + 1.0;
  }

  for(i = 0.0; i < digits; i = i + 1.0){
    if(i == digitsBefore){
      if(i == 0.0){
        string[(int)(p)] = '0';
        p = p + 1.0;
        digits = digits - 1.0;
      }

      for(j = 0.0; j < (double)decimalPointLength; j = j + 1.0){
        string[(int)(p)] = decimalPoint[(int)(j)];
        p = p + 1.0;
      }
    }

    if(i < digitsBefore){
      if(fmod(digitsBefore - i, 3.0) == 0.0 && i != 0.0){
        for(j = 0.0; j < (double)thousandsSeparatorLength; j = j + 1.0){
          string[(int)(p)] = thousandsSeparator[(int)(j)];
          p = p + 1.0;
        }
      }
    }

    d = floor(decimal/pow(10.0, digits - i - 1.0));
    d = fmod(d, 10.0);

    GetSingleDigitCharacterFromNumberWithCheck(d, 10.0, characterReference);
    string[(int)(p)] = characterReference->characterValue;

    p = p + 1.0;
  }

  /* System.out.println(new String(string)); */
  *returnArrayLength = stringLength;
  return string;
}
char16_t *NumberToHumanReadable(size_t *returnArrayLength, double n, double digitsAfter, char16_t *thousandsSeparator, size_t thousandsSeparatorLength, char16_t *decimalPoint, size_t decimalPointLength){
  char16_t *str;
  size_t strLength;
  char16_t u;
  double d, p3;

  if(fabs(n) < 1.0){
    str = CreateStringDecimalFromNumber(&strLength, n);
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

    str = FormatToStringWithSymbols15d(&strLength, Number15d(n), digitsAfter, thousandsSeparator, thousandsSeparatorLength, decimalPoint, decimalPointLength);

    if(p3 > 1.0){
      str = strAppendCharacter(&strLength, str, strLength, u);
    }
  }

  *returnArrayLength = strLength;
  return str;
}
char16_t *NumberToHumanReadableBinaryPrefix(size_t *returnArrayLength, double n, double digitsAfter, char16_t *thousandsSeparator, size_t thousandsSeparatorLength, char16_t *decimalPoint, size_t decimalPointLength){
  char16_t *str;
  size_t strLength;
  char16_t *u;
  size_t uLength;
  double d, p3;

  if(fabs(n) < 1.0){
    str = CreateStringDecimalFromNumber(&strLength, n);
  }else{
    d = floor(log(n)/log(2.0)) + 1.0;

    p3 = fmin(floor(d/10.0), 8.0);

    if(p3 == 0.0){
      u = u"B";
      uLength = c16len(u);
    }else if(p3 == 1.0){
      u = u"Ki";
      uLength = c16len(u);
    }else if(p3 == 2.0){
      u = u"Mi";
      uLength = c16len(u);
    }else if(p3 == 3.0){
      u = u"Gi";
      uLength = c16len(u);
    }else if(p3 == 4.0){
      u = u"Ti";
      uLength = c16len(u);
    }else if(p3 == 5.0){
      u = u"Pi";
      uLength = c16len(u);
    }else if(p3 == 6.0){
      u = u"Ei";
      uLength = c16len(u);
    }else if(p3 == 7.0){
      u = u"Zi";
      uLength = c16len(u);
    }else{
      u = u"Yi";
      uLength = c16len(u);
    }

    if(p3 > 1.0){
      n = n/pow(2.0, p3*10.0);
    }

    str = FormatToStringWithSymbols15d(&strLength, Number15d(n), digitsAfter, thousandsSeparator, thousandsSeparatorLength, decimalPoint, decimalPointLength);

    if(p3 > 1.0){
      str = strAppendString(&strLength, str, strLength, u, uLength);
    }
  }

  *returnArrayLength = strLength;
  return str;
}
double *AddNumber(size_t *returnArrayLength, double *list, size_t listLength, double a){
  double *newlist;
  size_t newlistLength;
  double i;

  newlist = (double*)calloc(sizeof(double) * ((double)listLength + 1.0), 1);
  newlistLength = (double)listLength + 1.0;
  for(i = 0.0; i < (double)listLength; i = i + 1.0){
    newlist[(int)(i)] = list[(int)(i)];
  }
  newlist[(int)((double)listLength)] = a;
		
  free(list);
		
  *returnArrayLength = newlistLength;
  return newlist;
}
void AddNumberRef(NumberArrayReference *list, double i){
  list->numberArray = AddNumber(&list->numberArrayLength, list->numberArray, list->numberArrayLength, i);
}
double *RemoveNumber(size_t *returnArrayLength, double *list, size_t listLength, double n){
  double *newlist;
  size_t newlistLength;
  double i;

  newlist = (double*)calloc(sizeof(double) * ((double)listLength - 1.0), 1);
  newlistLength = (double)listLength - 1.0;

  if(n >= 0.0 && n < (double)listLength){
    for(i = 0.0; i < (double)listLength; i = i + 1.0){
      if(i < n){
        newlist[(int)(i)] = list[(int)(i)];
      }
      if(i > n){
        newlist[(int)(i - 1.0)] = list[(int)(i)];
      }
    }

    free(list);
  }else{
    free(newlist);
  }
		
  *returnArrayLength = newlistLength;
  return newlist;
}
double GetNumberRef(NumberArrayReference *list, double i){
  return list->numberArray[(int)(i)];
}
void RemoveNumberRef(NumberArrayReference *list, double i){
  list->numberArray = RemoveNumber(&list->numberArrayLength, list->numberArray, list->numberArrayLength, i);
}
StringReference **AddString(size_t *returnArrayLength, StringReference **list, size_t listLength, StringReference *a){
  StringReference **newlist;
  size_t newlistLength;
  double i;

  newlist = (StringReference**)calloc(sizeof(StringReference) * ((double)listLength + 1.0), 1);
  newlistLength = (double)listLength + 1.0;

  for(i = 0.0; i < (double)listLength; i = i + 1.0){
    newlist[(int)(i)] = list[(int)(i)];
  }
  newlist[(int)((double)listLength)] = a;
		
  free(list);
		
  *returnArrayLength = newlistLength;
  return newlist;
}
void AddStringRef(StringArrayReference *list, StringReference *i){
  list->stringArray = AddString(&list->stringArrayLength, list->stringArray, list->stringArrayLength, i);
}
StringReference **RemoveString(size_t *returnArrayLength, StringReference **list, size_t listLength, double n){
  StringReference **newlist;
  size_t newlistLength;
  double i;

  newlist = (StringReference**)calloc(sizeof(StringReference) * ((double)listLength - 1.0), 1);
  newlistLength = (double)listLength - 1.0;

  if(n >= 0.0 && n < (double)listLength){
    for(i = 0.0; i < (double)listLength; i = i + 1.0){
      if(i < n){
        newlist[(int)(i)] = list[(int)(i)];
      }
      if(i > n){
        newlist[(int)(i - 1.0)] = list[(int)(i)];
      }
    }

    free(list);
  }else{
    free(newlist);
  }
		
  *returnArrayLength = newlistLength;
  return newlist;
}
StringReference *GetStringRef(StringArrayReference *list, double i){
  return list->stringArray[(int)(i)];
}
void RemoveStringRef(StringArrayReference *list, double i){
  list->stringArray = RemoveString(&list->stringArrayLength, list->stringArray, list->stringArrayLength, i);
}
DynamicArrayCharacters *CreateDynamicArrayCharacters(){
  DynamicArrayCharacters *da;

  da = (DynamicArrayCharacters *)calloc(sizeof(DynamicArrayCharacters), 1);
  da->array = (char16_t*)calloc(sizeof(char16_t) * (10.0), 1);
  da->arrayLength = 10.0;
  da->length = 0.0;

  return da;
}
DynamicArrayCharacters *CreateDynamicArrayCharactersWithInitialCapacity(double capacity){
  DynamicArrayCharacters *da;

  da = (DynamicArrayCharacters *)calloc(sizeof(DynamicArrayCharacters), 1);
  da->array = (char16_t*)calloc(sizeof(char16_t) * (capacity), 1);
  da->arrayLength = capacity;
  da->length = 0.0;

  return da;
}
void DynamicArrayAddCharacter(DynamicArrayCharacters *da, char16_t value){
  if(da->length == (double)da->arrayLength){
    DynamicArrayCharactersIncreaseSize(da);
  }

  da->array[(int)(da->length)] = value;
  da->length = da->length + 1.0;
}
void DynamicArrayAddString(DynamicArrayCharacters *da, char16_t *str, size_t strLength){
  double i;

  for(i = 0.0; i < (double)strLength; i = i + 1.0){
    DynamicArrayAddCharacter(da, str[(int)(i)]);
  }
}
void DynamicArrayCharactersIncreaseSize(DynamicArrayCharacters *da){
  double newLength, i;
  char16_t *newArray;
  size_t newArrayLength;

  newLength = round((double)da->arrayLength*3.0/2.0);
  newArray = (char16_t*)calloc(sizeof(char16_t) * (newLength), 1);
  newArrayLength = newLength;

  for(i = 0.0; i < (double)da->arrayLength; i = i + 1.0){
    newArray[(int)(i)] = da->array[(int)(i)];
  }

  free(da->array);

  da->array = newArray;
  da->arrayLength = newArrayLength;
}
_Bool DynamicArrayCharactersDecreaseSizeNecessary(DynamicArrayCharacters *da){
  _Bool needsDecrease;

  needsDecrease = false;

  if(da->length > 10.0){
    needsDecrease = da->length <= round((double)da->arrayLength*2.0/3.0);
  }

  return needsDecrease;
}
void DynamicArrayCharactersDecreaseSize(DynamicArrayCharacters *da){
  double newLength, i;
  char16_t *newArray;
  size_t newArrayLength;

  newLength = round((double)da->arrayLength*2.0/3.0);
  newArray = (char16_t*)calloc(sizeof(char16_t) * (newLength), 1);
  newArrayLength = newLength;

  for(i = 0.0; i < newLength; i = i + 1.0){
    newArray[(int)(i)] = da->array[(int)(i)];
  }

  free(da->array);

  da->array = newArray;
  da->arrayLength = newArrayLength;
}
char16_t DynamicArrayCharactersIndex(DynamicArrayCharacters *da, double index){
  return da->array[(int)(index)];
}
double DynamicArrayCharactersLength(DynamicArrayCharacters *da){
  return da->length;
}
void DynamicArrayInsertCharacter(DynamicArrayCharacters *da, double index, char16_t value){
  double i;

  if(da->length == (double)da->arrayLength){
    DynamicArrayCharactersIncreaseSize(da);
  }

  for(i = da->length; i > index; i = i - 1.0){
    da->array[(int)(i)] = da->array[(int)(i - 1.0)];
  }

  da->array[(int)(index)] = value;

  da->length = da->length + 1.0;
}
_Bool DynamicArrayCharacterSet(DynamicArrayCharacters *da, double index, char16_t value){
  _Bool success;

  if(index < da->length){
    da->array[(int)(index)] = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
void DynamicArrayRemoveCharacter(DynamicArrayCharacters *da, double index){
  double i;

  for(i = index; i < da->length - 1.0; i = i + 1.0){
    da->array[(int)(i)] = da->array[(int)(i + 1.0)];
  }

  da->length = da->length - 1.0;

  if(DynamicArrayCharactersDecreaseSizeNecessary(da)){
    DynamicArrayCharactersDecreaseSize(da);
  }
}
void FreeDynamicArrayCharacters(DynamicArrayCharacters *da){
  free(da->array);
  free(da);
}
char16_t *DynamicArrayCharactersToArray(size_t *returnArrayLength, DynamicArrayCharacters *da){
  char16_t *array;
  size_t arrayLength;
  double i;

  array = (char16_t*)calloc(sizeof(char16_t) * (da->length), 1);
  arrayLength = da->length;

  for(i = 0.0; i < da->length; i = i + 1.0){
    array[(int)(i)] = da->array[(int)(i)];
  }

  *returnArrayLength = arrayLength;
  return array;
}
DynamicArrayCharacters *ArrayToDynamicArrayCharactersWithOptimalSize(char16_t *array, size_t arrayLength){
  DynamicArrayCharacters *da;
  double i;
  double c, n, newCapacity;

  c = (double)arrayLength;
  n = (log(c) - 1.0)/log(3.0/2.0);
  newCapacity = ceil(10.0*pow(3.0/2.0, n));

  da = CreateDynamicArrayCharactersWithInitialCapacity(newCapacity);

  for(i = 0.0; i < (double)arrayLength; i = i + 1.0){
    da->array[(int)(i)] = array[(int)(i)];
  }

  return da;
}
DynamicArrayCharacters *ArrayToDynamicArrayCharacters(char16_t *array, size_t arrayLength){
  DynamicArrayCharacters *da;

  da = (DynamicArrayCharacters *)calloc(sizeof(DynamicArrayCharacters), 1);
  da->array = arraysCopyString(&da->arrayLength, array, arrayLength);
  da->length = (double)arrayLength;

  return da;
}
_Bool DynamicArrayCharactersEqual(DynamicArrayCharacters *a, DynamicArrayCharacters *b){
  _Bool equal;
  double i;

  equal = true;
  if(a->length == b->length){
    for(i = 0.0; i < a->length && equal; i = i + 1.0){
      if(a->array[(int)(i)] != b->array[(int)(i)]){
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
    LinkedListAddCharacter(ll, da->array[(int)(i)]);
  }

  return ll;
}
DynamicArrayCharacters *LinkedListToDynamicArrayCharacters(LinkedListCharacters *ll){
  DynamicArrayCharacters *da;
  double i;
  LinkedListNodeCharacters *node;

  node = ll->first;

  da = (DynamicArrayCharacters *)calloc(sizeof(DynamicArrayCharacters), 1);
  da->length = LinkedListCharactersLength(ll);

  da->array = (char16_t*)calloc(sizeof(char16_t) * (da->length), 1);
  da->arrayLength = da->length;

  for(i = 0.0; i < da->length; i = i + 1.0){
    da->array[(int)(i)] = node->value;
    node = node->next;
  }

  return da;
}
_Bool *AddBoolean(size_t *returnArrayLength, _Bool *list, size_t listLength, _Bool a){
  _Bool *newlist;
  size_t newlistLength;
  double i;

  newlist = (_Bool*)calloc(sizeof(_Bool) * ((double)listLength + 1.0), 1);
  newlistLength = (double)listLength + 1.0;
  for(i = 0.0; i < (double)listLength; i = i + 1.0){
    newlist[(int)(i)] = list[(int)(i)];
  }
  newlist[(int)((double)listLength)] = a;
		
  free(list);
		
  *returnArrayLength = newlistLength;
  return newlist;
}
void AddBooleanRef(BooleanArrayReference *list, _Bool i){
  list->booleanArray = AddBoolean(&list->booleanArrayLength, list->booleanArray, list->booleanArrayLength, i);
}
_Bool *RemoveBoolean(size_t *returnArrayLength, _Bool *list, size_t listLength, double n){
  _Bool *newlist;
  size_t newlistLength;
  double i;

  newlist = (_Bool*)calloc(sizeof(_Bool) * ((double)listLength - 1.0), 1);
  newlistLength = (double)listLength - 1.0;

  if(n >= 0.0 && n < (double)listLength){
    for(i = 0.0; i < (double)listLength; i = i + 1.0){
      if(i < n){
        newlist[(int)(i)] = list[(int)(i)];
      }
      if(i > n){
        newlist[(int)(i - 1.0)] = list[(int)(i)];
      }
    }

    free(list);
  }else{
    free(newlist);
  }
		
  *returnArrayLength = newlistLength;
  return newlist;
}
_Bool GetBooleanRef(BooleanArrayReference *list, double i){
  return list->booleanArray[(int)(i)];
}
void RemoveDecimalRef(BooleanArrayReference *list, double i){
  list->booleanArray = RemoveBoolean(&list->booleanArrayLength, list->booleanArray, list->booleanArrayLength, i);
}
LinkedListStrings *CreateLinkedListString(){
  LinkedListStrings *ll;

  ll = (LinkedListStrings *)calloc(sizeof(LinkedListStrings), 1);
  ll->first = (LinkedListNodeStrings *)calloc(sizeof(LinkedListNodeStrings), 1);
  ll->last = ll->first;
  ll->last->end = true;

  return ll;
}
void LinkedListAddString(LinkedListStrings *ll, char16_t *value, size_t valueLength){
  ll->last->end = false;
  ll->last->value = value;
  ll->last->valueLength = valueLength;
  ll->last->next = (LinkedListNodeStrings *)calloc(sizeof(LinkedListNodeStrings), 1);
  ll->last->next->end = true;
  ll->last = ll->last->next;
}
StringReference **LinkedListStringsToArray(size_t *returnArrayLength, LinkedListStrings *ll){
  StringReference **array;
  size_t arrayLength;
  double length, i;
  LinkedListNodeStrings *node;

  node = ll->first;

  length = LinkedListStringsLength(ll);

  array = (StringReference**)calloc(sizeof(StringReference) * (length), 1);
  arrayLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    array[(int)(i)] = (StringReference *)calloc(sizeof(StringReference), 1);
    array[(int)(i)]->string = node->value;
    array[(int)(i)]->stringLength = node->valueLength;
    node = node->next;
  }

  *returnArrayLength = arrayLength;
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
    free(prev);
  }

  free(node);
}
void LinkedListInsertString(LinkedListStrings *ll, double index, char16_t *value, size_t valueLength){
  double i;
  LinkedListNodeStrings *node, *tmp;

  if(index == 0.0){
    tmp = ll->first;
    ll->first = (LinkedListNodeStrings *)calloc(sizeof(LinkedListNodeStrings), 1);
    ll->first->next = tmp;
    ll->first->value = value;
    ll->first->valueLength = valueLength;
    ll->first->end = false;
  }else{
    node = ll->first;
    for(i = 0.0; i < index - 1.0; i = i + 1.0){
      node = node->next;
    }

    tmp = node->next;
    node->next = (LinkedListNodeStrings *)calloc(sizeof(LinkedListNodeStrings), 1);
    node->next->next = tmp;
    node->next->value = value;
    node->next->valueLength = valueLength;
    node->next->end = false;
  }
}
LinkedListNumbers *CreateLinkedListNumbers(){
  LinkedListNumbers *ll;

  ll = (LinkedListNumbers *)calloc(sizeof(LinkedListNumbers), 1);
  ll->first = (LinkedListNodeNumbers *)calloc(sizeof(LinkedListNodeNumbers), 1);
  ll->last = ll->first;
  ll->last->end = true;

  return ll;
}
LinkedListNumbers **CreateLinkedListNumbersArray(size_t *returnArrayLength, double length){
  LinkedListNumbers **lls;
  size_t llsLength;
  double i;

  lls = (LinkedListNumbers**)calloc(sizeof(LinkedListNumbers) * (length), 1);
  llsLength = length;
  for(i = 0.0; i < (double)llsLength; i = i + 1.0){
    lls[(int)(i)] = CreateLinkedListNumbers();
  }

  *returnArrayLength = llsLength;
  return lls;
}
void LinkedListAddNumber(LinkedListNumbers *ll, double value){
  ll->last->end = false;
  ll->last->value = value;
  ll->last->next = (LinkedListNodeNumbers *)calloc(sizeof(LinkedListNodeNumbers), 1);
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
    ll->first = (LinkedListNodeNumbers *)calloc(sizeof(LinkedListNodeNumbers), 1);
    ll->first->next = tmp;
    ll->first->value = value;
    ll->first->end = false;
  }else{
    node = ll->first;
    for(i = 0.0; i < index - 1.0; i = i + 1.0){
      node = node->next;
    }

    tmp = node->next;
    node->next = (LinkedListNodeNumbers *)calloc(sizeof(LinkedListNodeNumbers), 1);
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
    free(prev);
  }

  free(node);
}
void FreeLinkedListNumbersArray(LinkedListNumbers **lls, size_t llsLength){
  double i;

  for(i = 0.0; i < (double)llsLength; i = i + 1.0){
    FreeLinkedListNumbers(lls[(int)(i)]);
  }
  free(lls);
}
double *LinkedListNumbersToArray(size_t *returnArrayLength, LinkedListNumbers *ll){
  double *array;
  size_t arrayLength;
  double length, i;
  LinkedListNodeNumbers *node;

  node = ll->first;

  length = LinkedListNumbersLength(ll);

  array = (double*)calloc(sizeof(double) * (length), 1);
  arrayLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    array[(int)(i)] = node->value;
    node = node->next;
  }

  *returnArrayLength = arrayLength;
  return array;
}
LinkedListNumbers *ArrayToLinkedListNumbers(double *array, size_t arrayLength){
  LinkedListNumbers *ll;
  double i;

  ll = CreateLinkedListNumbers();

  for(i = 0.0; i < (double)arrayLength; i = i + 1.0){
    LinkedListAddNumber(ll, array[(int)(i)]);
  }

  return ll;
}
_Bool LinkedListNumbersEqual(LinkedListNumbers *a, LinkedListNumbers *b){
  _Bool equal, done;
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

  ll = (LinkedListCharacters *)calloc(sizeof(LinkedListCharacters), 1);
  ll->first = (LinkedListNodeCharacters *)calloc(sizeof(LinkedListNodeCharacters), 1);
  ll->last = ll->first;
  ll->last->end = true;

  return ll;
}
void LinkedListAddCharacter(LinkedListCharacters *ll, char16_t value){
  ll->last->end = false;
  ll->last->value = value;
  ll->last->next = (LinkedListNodeCharacters *)calloc(sizeof(LinkedListNodeCharacters), 1);
  ll->last->next->end = true;
  ll->last = ll->last->next;
}
char16_t *LinkedListCharactersToArray(size_t *returnArrayLength, LinkedListCharacters *ll){
  char16_t *array;
  size_t arrayLength;
  double length, i;
  LinkedListNodeCharacters *node;

  node = ll->first;

  length = LinkedListCharactersLength(ll);

  array = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
  arrayLength = length;

  for(i = 0.0; i < length; i = i + 1.0){
    array[(int)(i)] = node->value;
    node = node->next;
  }

  *returnArrayLength = arrayLength;
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
    free(prev);
  }

  free(node);
}
void LinkedListCharactersAddString(LinkedListCharacters *ll, char16_t *str, size_t strLength){
  double i;

  for(i = 0.0; i < (double)strLength; i = i + 1.0){
    LinkedListAddCharacter(ll, str[(int)(i)]);
  }
}
void LinkedListInsertCharacter(LinkedListCharacters *ll, double index, char16_t value){
  double i;
  LinkedListNodeCharacters *node, *tmp;

  if(index == 0.0){
    tmp = ll->first;
    ll->first = (LinkedListNodeCharacters *)calloc(sizeof(LinkedListNodeCharacters), 1);
    ll->first->next = tmp;
    ll->first->value = value;
    ll->first->end = false;
  }else{
    node = ll->first;
    for(i = 0.0; i < index - 1.0; i = i + 1.0){
      node = node->next;
    }

    tmp = node->next;
    node->next = (LinkedListNodeCharacters *)calloc(sizeof(LinkedListNodeCharacters), 1);
    node->next->next = tmp;
    node->next->value = value;
    node->next->end = false;
  }
}
DynamicArrayNumbers *CreateDynamicArrayNumbers(){
  DynamicArrayNumbers *da;

  da = (DynamicArrayNumbers *)calloc(sizeof(DynamicArrayNumbers), 1);
  da->array = (double*)calloc(sizeof(double) * (10.0), 1);
  da->arrayLength = 10.0;
  da->length = 0.0;

  return da;
}
DynamicArrayNumbers *CreateDynamicArrayNumbersWithInitialCapacity(double capacity){
  DynamicArrayNumbers *da;

  da = (DynamicArrayNumbers *)calloc(sizeof(DynamicArrayNumbers), 1);
  da->array = (double*)calloc(sizeof(double) * (capacity), 1);
  da->arrayLength = capacity;
  da->length = 0.0;

  return da;
}
void DynamicArrayAddNumber(DynamicArrayNumbers *da, double value){
  if(da->length == (double)da->arrayLength){
    DynamicArrayNumbersIncreaseSize(da);
  }

  da->array[(int)(da->length)] = value;
  da->length = da->length + 1.0;
}
void DynamicArrayNumbersIncreaseSize(DynamicArrayNumbers *da){
  double newLength, i;
  double *newArray;
  size_t newArrayLength;

  newLength = round((double)da->arrayLength*3.0/2.0);
  newArray = (double*)calloc(sizeof(double) * (newLength), 1);
  newArrayLength = newLength;

  for(i = 0.0; i < (double)da->arrayLength; i = i + 1.0){
    newArray[(int)(i)] = da->array[(int)(i)];
  }

  free(da->array);

  da->array = newArray;
  da->arrayLength = newArrayLength;
}
_Bool DynamicArrayNumbersDecreaseSizeNecessary(DynamicArrayNumbers *da){
  _Bool needsDecrease;

  needsDecrease = false;

  if(da->length > 10.0){
    needsDecrease = da->length <= round((double)da->arrayLength*2.0/3.0);
  }

  return needsDecrease;
}
void DynamicArrayNumbersDecreaseSize(DynamicArrayNumbers *da){
  double newLength, i;
  double *newArray;
  size_t newArrayLength;

  newLength = round((double)da->arrayLength*2.0/3.0);
  newArray = (double*)calloc(sizeof(double) * (newLength), 1);
  newArrayLength = newLength;

  for(i = 0.0; i < newLength; i = i + 1.0){
    newArray[(int)(i)] = da->array[(int)(i)];
  }

  free(da->array);

  da->array = newArray;
  da->arrayLength = newArrayLength;
}
double DynamicArrayNumbersIndex(DynamicArrayNumbers *da, double index){
  return da->array[(int)(index)];
}
double DynamicArrayNumbersLength(DynamicArrayNumbers *da){
  return da->length;
}
void DynamicArrayInsertNumber(DynamicArrayNumbers *da, double index, double value){
  double i;

  if(da->length == (double)da->arrayLength){
    DynamicArrayNumbersIncreaseSize(da);
  }

  for(i = da->length; i > index; i = i - 1.0){
    da->array[(int)(i)] = da->array[(int)(i - 1.0)];
  }

  da->array[(int)(index)] = value;

  da->length = da->length + 1.0;
}
_Bool DynamicArrayNumberSet(DynamicArrayNumbers *da, double index, double value){
  _Bool success;

  if(index < da->length){
    da->array[(int)(index)] = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
void DynamicArrayRemoveNumber(DynamicArrayNumbers *da, double index){
  double i;

  for(i = index; i < da->length - 1.0; i = i + 1.0){
    da->array[(int)(i)] = da->array[(int)(i + 1.0)];
  }

  da->length = da->length - 1.0;

  if(DynamicArrayNumbersDecreaseSizeNecessary(da)){
    DynamicArrayNumbersDecreaseSize(da);
  }
}
void FreeDynamicArrayNumbers(DynamicArrayNumbers *da){
  free(da->array);
  free(da);
}
double *DynamicArrayNumbersToArray(size_t *returnArrayLength, DynamicArrayNumbers *da){
  double *array;
  size_t arrayLength;
  double i;

  array = (double*)calloc(sizeof(double) * (da->length), 1);
  arrayLength = da->length;

  for(i = 0.0; i < da->length; i = i + 1.0){
    array[(int)(i)] = da->array[(int)(i)];
  }

  *returnArrayLength = arrayLength;
  return array;
}
DynamicArrayNumbers *ArrayToDynamicArrayNumbersWithOptimalSize(double *array, size_t arrayLength){
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
  c = (double)arrayLength;
  n = (log(c) - 1.0)/log(3.0/2.0);
  newCapacity = ceil(10.0*pow(3.0/2.0, n));

  da = CreateDynamicArrayNumbersWithInitialCapacity(newCapacity);

  for(i = 0.0; i < (double)arrayLength; i = i + 1.0){
    da->array[(int)(i)] = array[(int)(i)];
  }

  return da;
}
DynamicArrayNumbers *ArrayToDynamicArrayNumbers(double *array, size_t arrayLength){
  DynamicArrayNumbers *da;

  da = (DynamicArrayNumbers *)calloc(sizeof(DynamicArrayNumbers), 1);
  da->array = arraysCopyNumberArray(&da->arrayLength, array, arrayLength);
  da->length = (double)arrayLength;

  return da;
}
_Bool DynamicArrayNumbersEqual(DynamicArrayNumbers *a, DynamicArrayNumbers *b){
  _Bool equal;
  double i;

  equal = true;
  if(a->length == b->length){
    for(i = 0.0; i < a->length && equal; i = i + 1.0){
      if(a->array[(int)(i)] != b->array[(int)(i)]){
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
    LinkedListAddNumber(ll, da->array[(int)(i)]);
  }

  return ll;
}
DynamicArrayNumbers *LinkedListToDynamicArrayNumbers(LinkedListNumbers *ll){
  DynamicArrayNumbers *da;
  double i;
  LinkedListNodeNumbers *node;

  node = ll->first;

  da = (DynamicArrayNumbers *)calloc(sizeof(DynamicArrayNumbers), 1);
  da->length = LinkedListNumbersLength(ll);

  da->array = (double*)calloc(sizeof(double) * (da->length), 1);
  da->arrayLength = da->length;

  for(i = 0.0; i < da->length; i = i + 1.0){
    da->array[(int)(i)] = node->value;
    node = node->next;
  }

  return da;
}
double DynamicArrayNumbersIndexOf(DynamicArrayNumbers *arr, double n, BooleanReference *foundReference){
  _Bool found;
  double i;

  found = false;
  for(i = 0.0; i < arr->length &&  !found ; i = i + 1.0){
    if(arr->array[(int)(i)] == n){
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
_Bool DynamicArrayNumbersIsInArray(DynamicArrayNumbers *arr, double n){
  _Bool found;
  double i;

  found = false;
  for(i = 0.0; i < arr->length &&  !found ; i = i + 1.0){
    if(arr->array[(int)(i)] == n){
      found = true;
    }
  }

  return found;
}
char16_t *AddCharacter(size_t *returnArrayLength, char16_t *list, size_t listLength, char16_t a){
  char16_t *newlist;
  size_t newlistLength;
  double i;

  newlist = (char16_t*)calloc(sizeof(char16_t) * ((double)listLength + 1.0), 1);
  newlistLength = (double)listLength + 1.0;
  for(i = 0.0; i < (double)listLength; i = i + 1.0){
    newlist[(int)(i)] = list[(int)(i)];
  }
  newlist[(int)((double)listLength)] = a;
		
  free(list);
		
  *returnArrayLength = newlistLength;
  return newlist;
}
void AddCharacterRef(StringReference *list, char16_t i){
  list->string = AddCharacter(&list->stringLength, list->string, list->stringLength, i);
}
char16_t *RemoveCharacter(size_t *returnArrayLength, char16_t *list, size_t listLength, double n){
  char16_t *newlist;
  size_t newlistLength;
  double i;

  newlist = (char16_t*)calloc(sizeof(char16_t) * ((double)listLength - 1.0), 1);
  newlistLength = (double)listLength - 1.0;

  if(n >= 0.0 && n < (double)listLength){
    for(i = 0.0; i < (double)listLength; i = i + 1.0){
      if(i < n){
        newlist[(int)(i)] = list[(int)(i)];
      }
      if(i > n){
        newlist[(int)(i - 1.0)] = list[(int)(i)];
      }
    }

    free(list);
  }else{
    free(newlist);
  }

  *returnArrayLength = newlistLength;
  return newlist;
}
char16_t GetCharacterRef(StringReference *list, double i){
  return list->string[(int)(i)];
}
void RemoveCharacterRef(StringReference *list, double i){
  list->string = RemoveCharacter(&list->stringLength, list->string, list->stringLength, i);
}
double GetAccrualAmount(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay, double yearOfInterest, double monthOfInterest){
  Date *from, *to;
  double amount;

  from = CreateDate(fromYear, fromMonth, fromDay);
  to = CreateDate(toYear, toMonth, toDay);

  amount = GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest);

  return amount;
}
double *GetAccruals(size_t *returnArrayLength, double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay){
  Date *from, *to;
  double *amounts;
  size_t amountsLength;

  from = CreateDate(fromYear, fromMonth, fromDay);
  to = CreateDate(toYear, toMonth, toDay);

  amounts = GetAccrualsWithDates(&amountsLength, total, from, to);

  *returnArrayLength = amountsLength;
  return amounts;
}
double *GetAccrualsWithDates(size_t *returnArrayLength, double total, Date *from, Date *to){
  double entry;
  _Bool done;
  Date *dateOfInterest;
  LinkedListNumbers *list;
  double *result;
  size_t resultLength;

  list = CreateLinkedListNumbers();

  done = false;
  dateOfInterest = (Date *)calloc(sizeof(Date), 1);
  AssignDate(dateOfInterest, from);
  for(;  !done ; ){
    if(dateOfInterest->year == to->year && dateOfInterest->month == to->month){
      done = true;
    }

    entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest->year, dateOfInterest->month);
    LinkedListAddNumber(list, entry);
    AddMonthsToDate(dateOfInterest, 1.0);
  }

  result = LinkedListNumbersToArray(&resultLength, list);
  FreeLinkedListNumbers(list);

  *returnArrayLength = resultLength;
  return result;
}
double GetAccrualAmountWithDates(double total, Date *from, Date *to, double yearOfInterest, double monthOfInterest){
  double unadjustedAmount, adjustment, days, daysToAdjust, n;
  Date *adjustTo;
  FixedPoint15d *valuePerDay, *divisibleRemaining, *divisibleTotal, *amount;
  StringReference *message;

  message = (StringReference *)calloc(sizeof(StringReference), 1);

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
    adjustTo = (Date *)calloc(sizeof(Date), 1);
    AssignDate(adjustTo, from);
    AddDaysToDate(adjustTo, daysToAdjust - 1.0, message);

    adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest);

    free(adjustTo);
  }else{
    adjustment = 0.0;
  }

  Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment));

  n = ToNumber15d(amount);

  free(valuePerDay);
  free(divisibleRemaining);
  free(divisibleTotal);
  free(amount);

  return n;
}
double GetUnadjustedAccrualAmountWithDates(FixedPoint15d *total, Date *from, Date *to, double yearOfInterest, double monthOfInterest){
  double days, daysInMonthOfInterest, n;
  Date *lastDayInMonth, *firstDateInMonth;
  double *daysInMonth;
  size_t daysInMonthLength;
  FixedPoint15d *valuePerDay, *value, *remainder;
  _Bool success;

  value = CreateFixedPoint15d(13.0, 2.0);
  valuePerDay = CreateFixedPoint15d(13.0, 2.0);
  remainder = CreateFixedPoint15d(13.0, 2.0);

  days = DaysBetweenDates(from, to) + 1.0;
  /* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ... */
  success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days));

  if(success){
    daysInMonth = GetDaysInMonth(&daysInMonthLength, yearOfInterest);

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
        lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[(int)(monthOfInterest)]);
        daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1.0;
      }else if(to->year == yearOfInterest && to->month == monthOfInterest){
        firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1.0);
        daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1.0;
      }else{
        daysInMonthOfInterest = daysInMonth[(int)(monthOfInterest)];
      }

      /* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value */
      Multiply15d(value, valuePerDay, Number15d(daysInMonthOfInterest));
    }

    free(daysInMonth);
  }

  n = ToNumber15d(value);

  free(value);
  free(valuePerDay);
  free(remainder);

  return n;
}
Data *CreateNewArrayData(){
  Data *data;

  data = (Data *)calloc(sizeof(Data), 1);
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

  data = (Data *)calloc(sizeof(Data), 1);
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

  st = (Structure *)calloc(sizeof(Structure), 1);
  st->keys = CreateArray();
  st->values = CreateArray();

  return st;
}
Data *CreateNumberData(double n){
  Data *data;

  data = (Data *)calloc(sizeof(Data), 1);
  data->isNumber = true;
  data->isStruture = false;
  data->isArray = false;
  data->isBoolean = false;
  data->isString = false;
  data->number = n;

  return data;
}
Data *CreateBooleanData(_Bool b){
  Data *data;

  data = (Data *)calloc(sizeof(Data), 1);
  data->isBoolean = true;
  data->isStruture = false;
  data->isArray = false;
  data->isNumber = false;
  data->isString = false;
  data->booleanx = b;

  return data;
}
Data *CreateStringData(char16_t *string, size_t stringLength){
  Data *data;

  data = (Data *)calloc(sizeof(Data), 1);
  data->isString = true;
  data->isStruture = false;
  data->isArray = false;
  data->isNumber = false;
  data->isBoolean = false;
  data->string = string;
  data->stringLength = stringLength;

  return data;
}
Data *CreateStructData(Structure *structure){
  Data *data;

  data = (Data *)calloc(sizeof(Data), 1);
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

  data = (Data *)calloc(sizeof(Data), 1);
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

  data = (Data *)calloc(sizeof(Data), 1);
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
  free(data->structure);
  data->structure = st;

  ArrayAdd(ar, data);
}
void AddArrayToArray(Array *ar, Array *ar2){
  Data *data;

  data = CreateNewArrayData();
  free(data->array);
  data->array = ar2;

  ArrayAdd(ar, data);
}
void AddNumberToArray(Array *ar, double n){
  ArrayAdd(ar, CreateNumberData(n));
}
void AddBooleanToArray(Array *ar, _Bool b){
  ArrayAdd(ar, CreateBooleanData(b));
}
void AddStringToArray(Array *ar, char16_t *str, size_t strLength){
  ArrayAdd(ar, CreateStringData(str, strLength));
}
void AddDataToArray(Array *ar, Data *data){
  ArrayAdd(ar, data);
}
double StructKeys(Structure *st){
  return ArrayLength(st->keys);
}
_Bool StructHasKey(Structure *st, char16_t *key, size_t keyLength){
  double i;
  _Bool hasKey;

  hasKey = false;
  for(i = 0.0; i < StructKeys(st); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      hasKey = true;
    }
  }

  return hasKey;
}
double StructKeyIndex(Structure *st, char16_t *key, size_t keyLength){
  double i;
  double index;

  index =  -1.0;
  for(i = 0.0; i < StructKeys(st); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      index = i;
    }
  }

  return index;
}
StringReference **GetStructKeys(size_t *returnArrayLength, Structure *st){
  StringReference **keys;
  size_t keysLength;
  double nr, i;

  nr = StructKeys(st);

  keys = (StringReference**)calloc(sizeof(StringReference) * (nr), 1);
  keysLength = nr;

  for(i = 0.0; i < nr; i = i + 1.0){
    keys[(int)(i)] = (StringReference *)calloc(sizeof(StringReference), 1);
    keys[(int)(i)]->string = arraysCopyString(&keys[(int)(i)]->stringLength, st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength);
  }

  *returnArrayLength = keysLength;
  return keys;
}
Structure *GetStructFromStruct(Structure *st, char16_t *key, size_t keyLength){
  double i;
  Structure *r;

  r = (Structure *)calloc(sizeof(Structure), 1);
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      r = st->values->array[(int)(i)]->structure;
    }
  }

  return r;
}
Array *GetArrayFromStruct(Structure *st, char16_t *key, size_t keyLength){
  double i;
  Array *r;

  r = (Array *)calloc(sizeof(Array), 1);
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      r = st->values->array[(int)(i)]->array;
    }
  }

  return r;
}
double GetNumberFromStruct(Structure *st, char16_t *key, size_t keyLength){
  double i, r;

  r = 0.0;
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      r = st->values->array[(int)(i)]->number;
    }
  }

  return r;
}
_Bool GetBooleanFromStruct(Structure *st, char16_t *key, size_t keyLength){
  double i;
  _Bool r;

  r = false;
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      r = st->values->array[(int)(i)]->booleanx;
    }
  }

  return r;
}
char16_t *GetStringFromStruct(size_t *returnArrayLength, Structure *st, char16_t *key, size_t keyLength){
  double i;
  char16_t *r;
  size_t rLength;

  r = u"";
  rLength = c16len(r);
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      r = st->values->array[(int)(i)]->string;
      rLength = st->values->array[(int)(i)]->stringLength;
    }
  }

  *returnArrayLength = rLength;
  return r;
}
Data *GetDataFromStruct(Structure *st, char16_t *key, size_t keyLength){
  double i;
  Data *r;

  r = (Data *)calloc(sizeof(Data), 1);
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      free(r);
      r = st->values->array[(int)(i)];
    }
  }

  return r;
}
Data *GetDataFromStructWithCheck(Structure *st, char16_t *key, size_t keyLength, BooleanReference *foundRef){
  double i;
  Data *r;

  r = (Data *)calloc(sizeof(Data), 1);
  foundRef->booleanValue = false;
  for(i = 0.0; i < ArrayLength(st->keys); i = i + 1.0){
    if(arraysStringsEqual(st->keys->array[(int)(i)]->string, st->keys->array[(int)(i)]->stringLength, key, keyLength)){
      free(r);
      foundRef->booleanValue = true;
      r = st->values->array[(int)(i)];
    }
  }

  return r;
}
void AddStructToStruct(Structure *st, char16_t *key, size_t keyLength, Structure *structx){
  double i;

  if(StructHasKey(st, key, keyLength)){
    i = StructKeyIndex(st, key, keyLength);
    free(st->values->array[(int)(i)]->structure);
    st->values->array[(int)(i)]->structure = structx;
  }else{
    AddStringToArray(st->keys, key, keyLength);
    AddStructToArray(st->values, structx);
  }
}
void AddArrayToStruct(Structure *st, char16_t *key, size_t keyLength, Array *ar){
  double i;

  if(StructHasKey(st, key, keyLength)){
    i = StructKeyIndex(st, key, keyLength);
    free(st->values->array[(int)(i)]->array);
    st->values->array[(int)(i)]->array = ar;
  }else{
    AddStringToArray(st->keys, key, keyLength);
    AddArrayToArray(st->values, ar);
  }
}
void AddNumberToStruct(Structure *st, char16_t *key, size_t keyLength, double n){
  double i;

  if(StructHasKey(st, key, keyLength)){
    i = StructKeyIndex(st, key, keyLength);
    st->values->array[(int)(i)]->number = n;
  }else{
    AddStringToArray(st->keys, key, keyLength);
    AddNumberToArray(st->values, n);
  }
}
void AddBooleanToStruct(Structure *st, char16_t *key, size_t keyLength, _Bool b){
  double i;

  if(StructHasKey(st, key, keyLength)){
    i = StructKeyIndex(st, key, keyLength);
    st->values->array[(int)(i)]->booleanx = b;
  }else{
    AddStringToArray(st->keys, key, keyLength);
    AddBooleanToArray(st->values, b);
  }
}
void AddStringToStruct(Structure *st, char16_t *key, size_t keyLength, char16_t *value, size_t valueLength){
  double i;

  if(StructHasKey(st, key, keyLength)){
    i = StructKeyIndex(st, key, keyLength);
    free(st->values->array[(int)(i)]->string);
    st->values->array[(int)(i)]->string = value;
    st->values->array[(int)(i)]->stringLength = valueLength;
  }else{
    AddStringToArray(st->keys, key, keyLength);
    AddStringToArray(st->values, value, valueLength);
  }
}
void AddDataToStruct(Structure *st, char16_t *key, size_t keyLength, Data *data){
  double i;

  if(StructHasKey(st, key, keyLength)){
    i = StructKeyIndex(st, key, keyLength);
    FreeData(st->values->array[(int)(i)]);
    st->values->array[(int)(i)] = data;
  }else{
    AddStringToArray(st->keys, key, keyLength);
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
    free(st);
  }else if(data->isArray){
    FreeArray(data->array);
  }

  free(data);
}
void FreeArray(Array *array){
  double i;

  for(i = 0.0; i < ArrayLength(array); i = i + 1.0){
    FreeData(array->array[(int)(i)]);
  }

  free(array->array);
  free(array);
}
_Bool DataTypeEquals(Data *a, Data *b){
  _Bool equal;

  equal = true;
  equal = equal && a->isStruture == b->isStruture;
  equal = equal && a->isArray == b->isArray;
  equal = equal && a->isNumber == b->isNumber;
  equal = equal && a->isBoolean == b->isBoolean;
  equal = equal && a->isString == b->isString;

  return equal;
}
_Bool IsStructure(Data *a){
  _Bool itis;

  itis = a->isStruture;
  if(a->isArray || a->isNumber || a->isBoolean || a->isString){
    itis = false;
  }

  return itis;
}
_Bool IsArray(Data *a){
  _Bool itis;

  itis = a->isArray;
  if(a->isStruture || a->isNumber || a->isBoolean || a->isString){
    itis = false;
  }

  return itis;
}
_Bool IsNumber(Data *a){
  _Bool itis;

  itis = a->isNumber;
  if(a->isStruture || a->isArray || a->isBoolean || a->isString){
    itis = false;
  }

  return itis;
}
_Bool IsBoolean(Data *a){
  _Bool itis;

  itis = a->isBoolean;
  if(a->isStruture || a->isArray || a->isNumber || a->isString){
    itis = false;
  }

  return itis;
}
_Bool IsString(Data *a){
  _Bool itis;

  itis = a->isString;
  if(a->isStruture || a->isArray || a->isNumber || a->isBoolean){
    itis = false;
  }

  return itis;
}
_Bool IsNoType(Data *a){
  _Bool itis;

  if( !a->isString  &&  !a->isStruture  &&  !a->isArray  &&  !a->isNumber  &&  !a->isBoolean ){
    itis = true;
  }else{
    itis = false;
  }

  return itis;
}
Array *CreateArray(){
  Array *array;

  array = (Array *)calloc(sizeof(Array), 1);
  array->array = (Data**)calloc(sizeof(Data) * (10.0), 1);
  array->arrayLength = 10.0;
  array->length = 0.0;

  return array;
}
Array *CreateArrayWithInitialCapacity(double capacity){
  Array *array;

  array = (Array *)calloc(sizeof(Array), 1);
  array->array = (Data**)calloc(sizeof(Data) * (capacity), 1);
  array->arrayLength = capacity;
  array->length = 0.0;

  return array;
}
void ArrayAdd(Array *array, Data *value){
  if(array->length == (double)array->arrayLength){
    ArrayIncreaseSize(array);
  }

  array->array[(int)(array->length)] = value;
  array->length = array->length + 1.0;
}
void ArrayAddString(Array *array, char16_t *value, size_t valueLength){
  Data *data;

  data = CreateStringData(value, valueLength);

  ArrayAdd(array, data);
}
void ArrayAddBoolean(Array *array, _Bool value){
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
  Data **newArray;
  size_t newArrayLength;

  newLength = round((double)array->arrayLength*3.0/2.0);
  newArray = (Data**)calloc(sizeof(Data) * (newLength), 1);
  newArrayLength = newLength;

  for(i = 0.0; i < (double)array->arrayLength; i = i + 1.0){
    newArray[(int)(i)] = array->array[(int)(i)];
  }

  free(array->array);

  array->array = newArray;
  array->arrayLength = newArrayLength;
}
_Bool ArrayDecreaseSizeNecessary(Array *array){
  _Bool needsDecrease;

  needsDecrease = false;

  if(array->length > 10.0){
    needsDecrease = array->length <= round((double)array->arrayLength*2.0/3.0);
  }

  return needsDecrease;
}
void ArrayDecreaseSize(Array *array){
  double newLength, i;
  Data **newArray;
  size_t newArrayLength;

  newLength = round((double)array->arrayLength*2.0/3.0);
  newArray = (Data**)calloc(sizeof(Data) * (newLength), 1);
  newArrayLength = newLength;

  for(i = 0.0; i < newLength; i = i + 1.0){
    newArray[(int)(i)] = array->array[(int)(i)];
  }

  free(array->array);

  array->array = newArray;
  array->arrayLength = newArrayLength;
}
Data *ArrayIndex(Array *array, double index){
  return array->array[(int)(index)];
}
Array *ArrayIndexArray(Array *array, double index){
  return array->array[(int)(index)]->array;
}
Structure *ArrayIndexStruct(Array *array, double index){
  return array->array[(int)(index)]->structure;
}
_Bool ArrayIndexBoolean(Array *array, double index){
  return array->array[(int)(index)]->booleanx;
}
char16_t *ArrayIndexString(size_t *returnArrayLength, Array *array, double index){
  *returnArrayLength = array->array[(int)(index)]->stringLength;
  return array->array[(int)(index)]->string;
}
double ArrayIndexNumber(Array *array, double index){
  return array->array[(int)(index)]->number;
}
double ArrayLength(Array *array){
  return array->length;
}
void ArrayInsert(Array *array, double index, Data *value){
  double i;

  if(array->length == (double)array->arrayLength){
    ArrayIncreaseSize(array);
  }

  for(i = array->length; i > index; i = i - 1.0){
    array->array[(int)(i)] = array->array[(int)(i - 1.0)];
  }

  array->array[(int)(index)] = value;

  array->length = array->length + 1.0;
}
void ArrayInsertString(Array *array, double index, char16_t *value, size_t valueLength){
  Data *data;

  data = CreateStringData(value, valueLength);

  ArrayInsert(array, index, data);
}
void ArrayInsertBoolean(Array *array, double index, _Bool value){
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
_Bool ArraySet(Array *array, double index, Data *value){
  _Bool success;

  if(index < array->length){
    array->array[(int)(index)] = value;
    success = true;
  }else{
    success = false;
  }

  return success;
}
void ArraySetString(Array *array, double index, char16_t *value, size_t valueLength){
  Data *data;

  data = CreateStringData(value, valueLength);

  ArraySet(array, index, data);
}
void ArraySetBoolean(Array *array, double index, _Bool value){
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
    array->array[(int)(i)] = array->array[(int)(i + 1.0)];
  }

  array->length = array->length - 1.0;

  if(ArrayDecreaseSizeNecessary(array)){
    ArrayDecreaseSize(array);
  }
}
Data **ToStaticArray(size_t *returnArrayLength, Array *arc){
  Data **array;
  size_t arrayLength;
  double i;

  array = (Data**)calloc(sizeof(Data) * (arc->length), 1);
  arrayLength = arc->length;

  for(i = 0.0; i < arc->length; i = i + 1.0){
    array[(int)(i)] = arc->array[(int)(i)];
  }

  *returnArrayLength = arrayLength;
  return array;
}
double *ToStaticNumberArray(size_t *returnArrayLength, Array *array){
  double *result;
  size_t resultLength;
  double i, n;

  n = ArrayLength(array);

  result = (double*)calloc(sizeof(double) * (n), 1);
  resultLength = n;

  for(i = 0.0; i < n; i = i + 1.0){
    result[(int)(i)] = ArrayIndex(array, i)->number;
  }

  *returnArrayLength = resultLength;
  return result;
}
_Bool *ToStaticBooleanArray(size_t *returnArrayLength, Array *array){
  _Bool *result;
  size_t resultLength;
  double i, n;

  n = ArrayLength(array);

  result = (_Bool*)calloc(sizeof(_Bool) * (n), 1);
  resultLength = n;

  for(i = 0.0; i < n; i = i + 1.0){
    result[(int)(i)] = ArrayIndex(array, i)->booleanx;
  }

  *returnArrayLength = resultLength;
  return result;
}
StringReference **ToStaticStringArray(size_t *returnArrayLength, Array *array){
  StringReference **result;
  size_t resultLength;
  double i, n;

  n = ArrayLength(array);

  result = (StringReference**)calloc(sizeof(StringReference) * (n), 1);
  resultLength = n;

  for(i = 0.0; i < n; i = i + 1.0){
    result[(int)(i)] = (StringReference *)calloc(sizeof(StringReference), 1);
    result[(int)(i)]->string = ArrayIndex(array, i)->string;
    result[(int)(i)]->stringLength = ArrayIndex(array, i)->stringLength;
  }

  *returnArrayLength = resultLength;
  return result;
}
Array **ToStaticArrayArray(size_t *returnArrayLength, Array *array){
  Array **result;
  size_t resultLength;
  double i, n;

  n = ArrayLength(array);

  result = (Array**)calloc(sizeof(Array) * (n), 1);
  resultLength = n;

  for(i = 0.0; i < n; i = i + 1.0){
    result[(int)(i)] = ArrayIndex(array, i)->array;
  }

  *returnArrayLength = resultLength;
  return result;
}
Structure **ToStaticStructArray(size_t *returnArrayLength, Array *array){
  Structure **result;
  size_t resultLength;
  double i, n;

  n = ArrayLength(array);

  result = (Structure**)calloc(sizeof(Structure) * (n), 1);
  resultLength = n;

  for(i = 0.0; i < n; i = i + 1.0){
    result[(int)(i)] = ArrayIndex(array, i)->structure;
  }

  *returnArrayLength = resultLength;
  return result;
}
Array *StaticArrayToArrayWithOptimalSize(Data **src, size_t srcLength){
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

  c = (double)srcLength;
  n = (log(c) - 1.0)/log(3.0/2.0);

  newCapacity = ceil(10.0*pow(3.0/2.0, ceil(n)));

  dst = CreateArrayWithInitialCapacity(newCapacity);

  for(i = 0.0; i < (double)srcLength; i = i + 1.0){
    dst->array[(int)(i)] = src[(int)(i)];
  }

  return dst;
}
Array *StaticArrayToArray(Data **src, size_t srcLength){
  double i;
  Array *dst;

  dst = CreateArrayWithInitialCapacity((double)srcLength);
  for(i = 0.0; i < (double)srcLength; i = i + 1.0){
    dst->array[(int)(i)] = src[(int)(i)];
  }
  dst->length = (double)srcLength;

  return dst;
}
double *arraysStringToNumberArray(size_t *returnArrayLength, char16_t *string, size_t stringLength){
  double i;
  double *array;
  size_t arrayLength;

  array = (double*)calloc(sizeof(double) * ((double)stringLength), 1);
  arrayLength = (double)stringLength;

  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    array[(int)(i)] = string[(int)(i)];
  }
  *returnArrayLength = arrayLength;
  return array;
}
char16_t *arraysNumberArrayToString(size_t *returnArrayLength, double *array, size_t arrayLength){
  double i;
  char16_t *string;
  size_t stringLength;

  string = (char16_t*)calloc(sizeof(char16_t) * ((double)arrayLength), 1);
  stringLength = (double)arrayLength;

  for(i = 0.0; i < (double)arrayLength; i = i + 1.0){
    string[(int)(i)] = array[(int)(i)];
  }
  *returnArrayLength = stringLength;
  return string;
}
_Bool arraysNumberArraysEqual(double *a, size_t aLength, double *b, size_t bLength){
  _Bool equal;
  double i;

  equal = true;
  if((double)aLength == (double)bLength){
    for(i = 0.0; i < (double)aLength && equal; i = i + 1.0){
      if(a[(int)(i)] != b[(int)(i)]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
_Bool arraysBooleanArraysEqual(_Bool *a, size_t aLength, _Bool *b, size_t bLength){
  _Bool equal;
  double i;

  equal = true;
  if((double)aLength == (double)bLength){
    for(i = 0.0; i < (double)aLength && equal; i = i + 1.0){
      if(a[(int)(i)] != b[(int)(i)]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
_Bool arraysStringsEqual(char16_t *a, size_t aLength, char16_t *b, size_t bLength){
  _Bool equal;
  double i;

  equal = true;
  if((double)aLength == (double)bLength){
    for(i = 0.0; i < (double)aLength && equal; i = i + 1.0){
      if(a[(int)(i)] != b[(int)(i)]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
void arraysFillNumberArray(double *a, size_t aLength, double value){
  double i;

  for(i = 0.0; i < (double)aLength; i = i + 1.0){
    a[(int)(i)] = value;
  }
}
void arraysFillString(char16_t *a, size_t aLength, char16_t value){
  double i;

  for(i = 0.0; i < (double)aLength; i = i + 1.0){
    a[(int)(i)] = value;
  }
}
void arraysFillBooleanArray(_Bool *a, size_t aLength, _Bool value){
  double i;

  for(i = 0.0; i < (double)aLength; i = i + 1.0){
    a[(int)(i)] = value;
  }
}
_Bool arraysFillNumberArrayRange(double *a, size_t aLength, double value, double from, double to){
  double i, length;
  _Bool success;

  if(from >= 0.0 && from <= (double)aLength && to >= 0.0 && to <= (double)aLength && from <= to){
    length = to - from;
    for(i = 0.0; i < length; i = i + 1.0){
      a[(int)(from + i)] = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
_Bool arraysFillBooleanArrayRange(_Bool *a, size_t aLength, _Bool value, double from, double to){
  double i, length;
  _Bool success;

  if(from >= 0.0 && from <= (double)aLength && to >= 0.0 && to <= (double)aLength && from <= to){
    length = to - from;
    for(i = 0.0; i < length; i = i + 1.0){
      a[(int)(from + i)] = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
_Bool arraysFillStringRange(char16_t *a, size_t aLength, char16_t value, double from, double to){
  double i, length;
  _Bool success;

  if(from >= 0.0 && from <= (double)aLength && to >= 0.0 && to <= (double)aLength && from <= to){
    length = to - from;
    for(i = 0.0; i < length; i = i + 1.0){
      a[(int)(from + i)] = value;
    }

    success = true;
  }else{
    success = false;
  }

  return success;
}
double *arraysCopyNumberArray(size_t *returnArrayLength, double *a, size_t aLength){
  double i;
  double *n;
  size_t nLength;

  n = (double*)calloc(sizeof(double) * ((double)aLength), 1);
  nLength = (double)aLength;

  for(i = 0.0; i < (double)aLength; i = i + 1.0){
    n[(int)(i)] = a[(int)(i)];
  }

  *returnArrayLength = nLength;
  return n;
}
_Bool *arraysCopyBooleanArray(size_t *returnArrayLength, _Bool *a, size_t aLength){
  double i;
  _Bool *n;
  size_t nLength;

  n = (_Bool*)calloc(sizeof(_Bool) * ((double)aLength), 1);
  nLength = (double)aLength;

  for(i = 0.0; i < (double)aLength; i = i + 1.0){
    n[(int)(i)] = a[(int)(i)];
  }

  *returnArrayLength = nLength;
  return n;
}
char16_t *arraysCopyString(size_t *returnArrayLength, char16_t *a, size_t aLength){
  double i;
  char16_t *n;
  size_t nLength;

  n = (char16_t*)calloc(sizeof(char16_t) * ((double)aLength), 1);
  nLength = (double)aLength;

  for(i = 0.0; i < (double)aLength; i = i + 1.0){
    n[(int)(i)] = a[(int)(i)];
  }

  *returnArrayLength = nLength;
  return n;
}
_Bool arraysCopyNumberArrayRange(double *a, size_t aLength, double from, double to, NumberArrayReference *copyReference){
  double i, length;
  double *n;
  size_t nLength;
  _Bool success;

  if(from >= 0.0 && from <= (double)aLength && to >= 0.0 && to <= (double)aLength && from <= to){
    length = to - from;
    n = (double*)calloc(sizeof(double) * (length), 1);
    nLength = length;

    for(i = 0.0; i < length; i = i + 1.0){
      n[(int)(i)] = a[(int)(from + i)];
    }

    copyReference->numberArray = n;
    copyReference->numberArrayLength = nLength;
    success = true;
  }else{
    success = false;
  }

  return success;
}
_Bool arraysCopyBooleanArrayRange(_Bool *a, size_t aLength, double from, double to, BooleanArrayReference *copyReference){
  double i, length;
  _Bool *n;
  size_t nLength;
  _Bool success;

  if(from >= 0.0 && from <= (double)aLength && to >= 0.0 && to <= (double)aLength && from <= to){
    length = to - from;
    n = (_Bool*)calloc(sizeof(_Bool) * (length), 1);
    nLength = length;

    for(i = 0.0; i < length; i = i + 1.0){
      n[(int)(i)] = a[(int)(from + i)];
    }

    copyReference->booleanArray = n;
    copyReference->booleanArrayLength = nLength;
    success = true;
  }else{
    success = false;
  }

  return success;
}
_Bool arraysCopyStringRange(char16_t *a, size_t aLength, double from, double to, StringReference *copyReference){
  double i, length;
  char16_t *n;
  size_t nLength;
  _Bool success;

  if(from >= 0.0 && from <= (double)aLength && to >= 0.0 && to <= (double)aLength && from <= to){
    length = to - from;
    n = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
    nLength = length;

    for(i = 0.0; i < length; i = i + 1.0){
      n[(int)(i)] = a[(int)(from + i)];
    }

    copyReference->string = n;
    copyReference->stringLength = nLength;
    success = true;
  }else{
    success = false;
  }

  return success;
}
_Bool arraysIsLastElement(double length, double index){
  return index + 1.0 == length;
}
double *arraysCreateNumberArray(size_t *returnArrayLength, double length, double value){
  double *array;
  size_t arrayLength;

  array = (double*)calloc(sizeof(double) * (length), 1);
  arrayLength = length;
  arraysFillNumberArray(array, arrayLength, value);

  *returnArrayLength = arrayLength;
  return array;
}
_Bool *arraysCreateBooleanArray(size_t *returnArrayLength, double length, _Bool value){
  _Bool *array;
  size_t arrayLength;

  array = (_Bool*)calloc(sizeof(_Bool) * (length), 1);
  arrayLength = length;
  arraysFillBooleanArray(array, arrayLength, value);

  *returnArrayLength = arrayLength;
  return array;
}
char16_t *arraysCreateString(size_t *returnArrayLength, double length, char16_t value){
  char16_t *array;
  size_t arrayLength;

  array = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
  arrayLength = length;
  arraysFillString(array, arrayLength, value);

  *returnArrayLength = arrayLength;
  return array;
}
void arraysSwapElementsOfNumberArray(double *A, size_t ALength, double ai, double bi){
  double tmp;

  tmp = A[(int)(ai)];
  A[(int)(ai)] = A[(int)(bi)];
  A[(int)(bi)] = tmp;
}
void arraysSwapElementsOfStringArray(StringArrayReference *A, double ai, double bi){
  StringReference *tmp;

  tmp = A->stringArray[(int)(ai)];
  A->stringArray[(int)(ai)] = A->stringArray[(int)(bi)];
  A->stringArray[(int)(bi)] = tmp;
}
void arraysReverseNumberArray(double *array, size_t arrayLength){
  double i;

  for(i = 0.0; i < (double)arrayLength/2.0; i = i + 1.0){
    arraysSwapElementsOfNumberArray(array, arrayLength, i, (double)arrayLength - i - 1.0);
  }
}
char16_t *CreateStringScientificNotationDecimalFromNumber(size_t *returnArrayLength, double n){
  StringReference *mantissaReference, *exponentReference;
  double e;
  _Bool isPositive;
  char16_t *result;
  size_t resultLength;

  mantissaReference = (StringReference *)calloc(sizeof(StringReference), 1);
  exponentReference = (StringReference *)calloc(sizeof(StringReference), 1);
  result = (char16_t*)calloc(sizeof(char16_t) * (0.0), 1);
  resultLength = 0.0;

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
      n = n*pow(10.0, fabs(e));
    }else{
      n = n/pow(10.0, e);
    }
  }

  mantissaReference->string = CreateStringDecimalFromNumber(&mantissaReference->stringLength, n);
  exponentReference->string = CreateStringDecimalFromNumber(&exponentReference->stringLength, e);

  if( !isPositive ){
    result = strAppendString(&resultLength, result, resultLength, strparam(u"-"));
  }

  result = strAppendString(&resultLength, result, resultLength, mantissaReference->string, mantissaReference->stringLength);
  result = strAppendString(&resultLength, result, resultLength, strparam(u"e"));
  result = strAppendString(&resultLength, result, resultLength, exponentReference->string, exponentReference->stringLength);

  *returnArrayLength = resultLength;
  return result;
}
char16_t *CreateStringDecimalFromNumber(size_t *returnArrayLength, double number){
  DynamicArrayCharacters *string;
  double maximumDigits, i, d, digitPosition, trailingZeros;
  _Bool hasPrintedPoint, isPositive, done;
  CharacterReference *characterReference;
  char16_t c;
  char16_t *str;
  size_t strLength;

  string = CreateDynamicArrayCharacters();
  isPositive = true;

  if(number < 0.0){
    isPositive = false;
    number =  -number;
  }

  if(number == 0.0){
    DynamicArrayAddCharacter(string, '0');
  }else{
    characterReference = (CharacterReference *)calloc(sizeof(CharacterReference), 1);

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
  str = DynamicArrayCharactersToArray(&strLength, string);
  FreeDynamicArrayCharacters(string);
  *returnArrayLength = strLength;
  return str;
}
_Bool CreateStringFromNumberWithCheck(double number, double base, StringReference *stringRef){
  DynamicArrayCharacters *string;
  double maximumDigits, i, d, digitPosition, trailingZeros;
  _Bool success, hasPrintedPoint, isPositive, done;
  CharacterReference *characterReference;
  char16_t c;

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
    characterReference = (CharacterReference *)calloc(sizeof(CharacterReference), 1);

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
    stringRef->string = DynamicArrayCharactersToArray(&stringRef->stringLength, string);
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
  _Bool multiply, done;

  n = fabs(n);

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
  _Bool multiply, done;

  maximumDigits = GetMaximumDigitsForBase(base);
  n = fabs(n);

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
_Bool GetSingleDigitCharacterFromNumberWithCheck(double c, double base, CharacterReference *characterReference){
  char16_t *numberTable;
  size_t numberTableLength;
  _Bool success;

  numberTable = GetDigitCharacterTable(&numberTableLength);

  if(c < base || c < (double)numberTableLength){
    success = true;
    characterReference->characterValue = numberTable[(int)(c)];
  }else{
    success = false;
  }

  return success;
}
_Bool GetDecimalDigitCharacterFromNumberWithCheck(double c, CharacterReference *characterRef){
  char16_t *numberTable;
  size_t numberTableLength;
  _Bool success;

  numberTable = u"0123456789";
  numberTableLength = c16len(numberTable);

  if(c >= 0.0 && c < 10.0){
    success = true;
    characterRef->characterValue = numberTable[(int)(c)];
  }else{
    success = false;
  }

  return success;
}
char16_t *GetDigitCharacterTable(size_t *returnArrayLength){
  char16_t *numberTable;
  size_t numberTableLength;

  numberTable = u"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  numberTableLength = c16len(numberTable);

  *returnArrayLength = numberTableLength;
  return numberTable;
}
double GetDecimalDigit(double n, double index){
  double digitPosition;

  digitPosition = GetFirstDecimalDigitPosition(n);

  return GetDecimalDigitWithFirstDigitPosition(n, digitPosition, index);
}
double GetDecimalDigitWithFirstDigitPosition(double n, double digitPosition, double index){
  double d, e, m, i;

  n = fabs(n);

  e = 15.0 - digitPosition - 1.0;
  if(e < 0.0){
    n = round(n/pow(10.0, fabs(e)));
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

  n = fabs(n);
  maximumDigits = GetMaximumDigitsForBase(base);
  digitPosition = GetFirstDigitPosition(n, base);

  e = maximumDigits - digitPosition - 1.0;
  if(e < 0.0){
    n = round(n/pow(base, fabs(e)));
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
char16_t *NumberToHumanReadableShortScale(size_t *returnArrayLength, double n){
  char16_t *res, *suffix;
  size_t resLength, suffixLength;
  _Bool hasSuffix;
  double k, M, B, T, Q;

  k = 1000.0;
  M = k*1000.0;
  B = M*1000.0;
  T = B*1000.0;
  Q = T*1000.0;
  suffix = u" ";
  suffixLength = c16len(suffix);

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
    suffix = u"k";
    suffixLength = c16len(suffix);
  }else if(n >= M && n < B){
    if(n < 10.0*M){
      n = Round(n/(k*100.0));
      n = n/10.0;
    }else{
      n = Round(n/M);
    }
    suffix = u"M";
    suffixLength = c16len(suffix);
  }else if(n >= B && n < T){
    if(n < 10.0*B){
      n = Round(n/(M*100.0));
      n = n/10.0;
    }else{
      n = Round(n/B);
    }
    suffix = u"B";
    suffixLength = c16len(suffix);
  }else if(n >= T && n < Q){
    if(n < 10.0*T){
      n = Round(n/(B*100.0));
      n = n/10.0;
    }else{
      n = Round(n/T);
    }
    suffix = u"T";
    suffixLength = c16len(suffix);
  }else if(n >= Q){
    if(n < 10.0*Q){
      n = Round(n/(T*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Q);
    }
    suffix = u"Q";
    suffixLength = c16len(suffix);
  }

  res = CreateStringDecimalFromNumber(&resLength, n);
  if(hasSuffix){
    res = strAppendString(&resLength, res, resLength, suffix, suffixLength);
  }
        
  *returnArrayLength = resLength;
  return res;
}
char16_t *NumberToHumanReadableBinary(size_t *returnArrayLength, double n){
  char16_t *res, *suffix;
  size_t resLength, suffixLength;
  _Bool hasSuffix;
  double Ki, Mi, Gi, Ti, Pi, Ei, Zi, Yi;

  Ki = 1024.0;
  Mi = Ki*1024.0;
  Gi = Mi*1024.0;
  Ti = Gi*1024.0;
  Pi = Ti*1024.0;
  Ei = Pi*1024.0;
  Zi = Ei*1024.0;
  Yi = Zi*1024.0;
  suffix = u" ";
  suffixLength = c16len(suffix);

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
    suffix = u"Ki";
    suffixLength = c16len(suffix);
  }else if(n >= Mi && n < Gi){
    if(n < 10.0*Mi){
      n = Round(n/(Mi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Mi);
    }
    suffix = u"Mi";
    suffixLength = c16len(suffix);
  }else if(n >= Gi && n < Ti){
    if(n < 10.0*Gi){
      n = Round(n/(Gi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Gi);
    }
    suffix = u"Gi";
    suffixLength = c16len(suffix);
  }else if(n >= Ti && n < Pi){
    if(n < 10.0*Ti){
      n = Round(n/(Ti/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Ti);
    }
    suffix = u"Ti";
    suffixLength = c16len(suffix);
  }else if(n >= Pi && n < Ei){
    if(n < 10.0*Pi){
      n = Round(n/(Pi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Pi);
    }
    suffix = u"Pi";
    suffixLength = c16len(suffix);
  }else if(n >= Ei && n < Zi){
    if(n < 10.0*Ei){
      n = Round(n/(Ei/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Ei);
    }
    suffix = u"Ei";
    suffixLength = c16len(suffix);
  }else if(n >= Zi && n < Yi){
    if(n < 10.0*Zi){
      n = Round(n/(Zi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Zi);
    }
    suffix = u"Zi";
    suffixLength = c16len(suffix);
  }else if(n >= Yi){
    if(n < 10.0*Yi){
      n = Round(n/(Yi/10.0));
      n = n/10.0;
    }else{
      n = Round(n/Yi);
    }
    suffix = u"Yi";
    suffixLength = c16len(suffix);
  }

  res = CreateStringDecimalFromNumber(&resLength, n);
  if(hasSuffix){
    res = strAppendString(&resLength, res, resLength, suffix, suffixLength);
  }

  *returnArrayLength = resLength;
  return res;
}
char16_t *NumberToHumanReadableMetric(size_t *returnArrayLength, double n){
  char16_t *res, *suffix;
  size_t resLength, suffixLength;
  _Bool hasSuffix;
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
  suffix = u" ";
  suffixLength = c16len(suffix);

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
    suffix = u"k";
    suffixLength = c16len(suffix);
  }else if(n >= M && n < G){
    if(n < 10.0*M){
      n = Round(n/(k*100.0));
      n = n/10.0;
    }else{
      n = Round(n/M);
    }
    suffix = u"M";
    suffixLength = c16len(suffix);
  }else if(n >= G && n < T){
    if(n < 10.0*G){
      n = Round(n/(M*100.0));
      n = n/10.0;
    }else{
      n = Round(n/G);
    }
    suffix = u"G";
    suffixLength = c16len(suffix);
  }else if(n >= T && n < P){
    if(n < 10.0*T){
      n = Round(n/(G*100.0));
      n = n/10.0;
    }else{
      n = Round(n/T);
    }
    suffix = u"T";
    suffixLength = c16len(suffix);
  }else if(n >= P && n < Ex){
    if(n < 10.0*P){
      n = Round(n/(T*100.0));
      n = n/10.0;
    }else{
      n = Round(n/P);
    }
    suffix = u"P";
    suffixLength = c16len(suffix);
  }else if(n >= Ex && n < Z){
    if(n < 10.0*Ex){
      n = Round(n/(P*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Ex);
    }
    suffix = u"E";
    suffixLength = c16len(suffix);
  }else if(n >= Z && n < Y){
    if(n < 10.0*Z){
      n = Round(n/(Ex*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Z);
    }
    suffix = u"Z";
    suffixLength = c16len(suffix);
  }else if(n >= Y && n < R){
    if(n < 10.0*Y){
      n = Round(n/(Z*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Y);
    }
    suffix = u"Y";
    suffixLength = c16len(suffix);
  }else if(n >= R && n < Q){
    if(n < 10.0*R){
      n = Round(n/(Y*100.0));
      n = n/10.0;
    }else{
      n = Round(n/R);
    }
    suffix = u"R";
    suffixLength = c16len(suffix);
  }else if(n >= Q){
    if(n < 10.0*Q){
      n = Round(n/(R*100.0));
      n = n/10.0;
    }else{
      n = Round(n/Q);
    }
    suffix = u"Q";
    suffixLength = c16len(suffix);
  }

  res = CreateStringDecimalFromNumber(&resLength, n);
  if(hasSuffix){
    res = strAppendString(&resLength, res, resLength, suffix, suffixLength);
  }

  *returnArrayLength = resLength;
  return res;
}
_Bool IsValidNumber(char16_t *str, size_t strLength){
  _Bool valid;
  NumberReference *numberRef;
  StringReference *message;

  numberRef = (NumberReference *)calloc(sizeof(NumberReference), 1);
  message = (StringReference *)calloc(sizeof(StringReference), 1);

  valid = CreateNumberFromDecimalStringWithCheck(str, strLength, numberRef, message);

  free(numberRef);
  free(message);

  return valid;
}
_Bool IsValidInteger(char16_t *str, size_t strLength){
  _Bool valid;
  NumberReference *numberRef;
  StringReference *message;

  numberRef = (NumberReference *)calloc(sizeof(NumberReference), 1);
  message = (StringReference *)calloc(sizeof(StringReference), 1);

  valid = CreateNumberFromDecimalStringWithCheck(str, strLength, numberRef, message);

  if(valid){
    valid = IsInteger(numberRef->numberValue);
  }

  free(numberRef);
  free(message);

  return valid;
}
_Bool IsValidPositiveInteger(char16_t *str, size_t strLength){
  _Bool valid;
  NumberReference *numberRef;
  StringReference *message;

  numberRef = (NumberReference *)calloc(sizeof(NumberReference), 1);
  message = (StringReference *)calloc(sizeof(StringReference), 1);

  valid = CreateNumberFromDecimalStringWithCheck(str, strLength, numberRef, message);

  if(valid){
    valid = IsInteger(numberRef->numberValue);
    if(valid){
      valid = numberRef->numberValue >= 0.0;
    }
  }

  free(numberRef);
  free(message);

  return valid;
}
_Bool CreateNumberFromDecimalStringWithCheck(char16_t *string, size_t stringLength, NumberReference *decimalReference, StringReference *message){
  return CreateNumberFromStringWithCheck(string, stringLength, 10.0, decimalReference, message);
}
double CreateNumberFromDecimalString(char16_t *string, size_t stringLength){
  NumberReference *doubleReference;
  StringReference *stringReference;
  double number;

  doubleReference = CreateNumberReference(0.0);
  stringReference = CreateStringReference(strparam(u""));
  CreateNumberFromStringWithCheck(string, stringLength, 10.0, doubleReference, stringReference);
  number = doubleReference->numberValue;

  free(doubleReference);
  free(stringReference);

  return number;
}
_Bool CreateNumberFromStringWithCheck(char16_t *string, size_t stringLength, double base, NumberReference *numberReference, StringReference *message){
  _Bool success;
  BooleanReference *numberIsPositive, *exponentIsPositive;
  NumberArrayReference *beforePoint, *afterPoint, *exponent;

  numberIsPositive = CreateBooleanReference(true);
  exponentIsPositive = CreateBooleanReference(true);
  beforePoint = (NumberArrayReference *)calloc(sizeof(NumberArrayReference), 1);
  afterPoint = (NumberArrayReference *)calloc(sizeof(NumberArrayReference), 1);
  exponent = (NumberArrayReference *)calloc(sizeof(NumberArrayReference), 1);

  if(base >= 2.0 && base <= 36.0){
    success = ExtractPartsFromNumberString(string, stringLength, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

    if(success){
      numberReference->numberValue = CreateNumberFromParts(base, numberIsPositive->booleanValue, beforePoint->numberArray, beforePoint->numberArrayLength, afterPoint->numberArray, afterPoint->numberArrayLength, exponentIsPositive->booleanValue, exponent->numberArray, exponent->numberArrayLength);
    }
  }else{
    success = false;
    message->string = u"Base must be from 2 to 36.";
    message->stringLength = c16len(message->string);
  }

  return success;
}
double CreateNumberFromParts(double base, _Bool numberIsPositive, double *beforePoint, size_t beforePointLength, double *afterPoint, size_t afterPointLength, _Bool exponentIsPositive, double *exponent, size_t exponentLength){
  double n, i, p, e;

  n = 0.0;

  for(i = 0.0; i < (double)beforePointLength; i = i + 1.0){
    p = beforePoint[(int)((double)beforePointLength - i - 1.0)];

    n = n + p*pow(base, i);
  }

  for(i = 0.0; i < (double)afterPointLength; i = i + 1.0){
    p = afterPoint[(int)(i)];

    n = n + p/pow(base, i + 1.0);
  }

  if((double)exponentLength > 0.0){
    e = 0.0;
    for(i = 0.0; i < (double)exponentLength; i = i + 1.0){
      p = exponent[(int)((double)exponentLength - i - 1.0)];

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
_Bool ExtractPartsFromNumberString(char16_t *n, size_t nLength, double base, BooleanReference *numberIsPositive, NumberArrayReference *beforePoint, NumberArrayReference *afterPoint, BooleanReference *exponentIsPositive, NumberArrayReference *exponent, StringReference *errorMessages){
  double i, j, count;
  _Bool success, done, complete;

  i = 0.0;
  complete = false;

  if(i < (double)nLength){
    if(n[(int)(i)] == '-'){
      numberIsPositive->booleanValue = false;
      i = i + 1.0;
    }else if(n[(int)(i)] == '+'){
      numberIsPositive->booleanValue = true;
      i = i + 1.0;
    }

    success = true;
  }else{
    success = false;
    errorMessages->string = u"Number cannot have length zero.";
    errorMessages->stringLength = c16len(errorMessages->string);
  }

  if(success){
    done = false;
    count = 0.0;
    for(; i + count < (double)nLength &&  !done ; ){
      if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], base)){
        count = count + 1.0;
      }else{
        done = true;
      }
    }

    if(count >= 1.0){
      beforePoint->numberArray = (double*)calloc(sizeof(double) * (count), 1);
      beforePoint->numberArrayLength = count;

      for(j = 0.0; j < count; j = j + 1.0){
        beforePoint->numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], base);
      }

      i = i + count;

      if(i < (double)nLength){
        success = true;
      }else{
        afterPoint->numberArray = (double*)calloc(sizeof(double) * (0.0), 1);
        afterPoint->numberArrayLength = 0.0;
        exponent->numberArray = (double*)calloc(sizeof(double) * (0.0), 1);
        exponent->numberArrayLength = 0.0;
        success = true;
        complete = true;
      }
    }else{
      success = false;
      errorMessages->string = u"Number must have at least one number after the optional sign.";
      errorMessages->stringLength = c16len(errorMessages->string);
    }
  }

  if(success &&  !complete ){
    if(n[(int)(i)] == '.'){
      i = i + 1.0;

      if(i < (double)nLength){
        done = false;
        count = 0.0;
        for(; i + count < (double)nLength &&  !done ; ){
          if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], base)){
            count = count + 1.0;
          }else{
            done = true;
          }
        }

        if(count >= 1.0){
          afterPoint->numberArray = (double*)calloc(sizeof(double) * (count), 1);
          afterPoint->numberArrayLength = count;

          for(j = 0.0; j < count; j = j + 1.0){
            afterPoint->numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], base);
          }

          i = i + count;

          if(i < (double)nLength){
            success = true;
          }else{
            exponent->numberArray = (double*)calloc(sizeof(double) * (0.0), 1);
            exponent->numberArrayLength = 0.0;
            success = true;
            complete = true;
          }
        }else{
          success = false;
          errorMessages->string = u"There must be at least one digit after the decimal point.";
          errorMessages->stringLength = c16len(errorMessages->string);
        }
      }else{
        success = false;
        errorMessages->string = u"There must be at least one digit after the decimal point.";
        errorMessages->stringLength = c16len(errorMessages->string);
      }
    }else if(base <= 14.0 && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
      if(i < (double)nLength){
        success = true;
        afterPoint->numberArray = (double*)calloc(sizeof(double) * (0.0), 1);
        afterPoint->numberArrayLength = 0.0;
      }else{
        success = false;
        errorMessages->string = u"There must be at least one digit after the exponent.";
        errorMessages->stringLength = c16len(errorMessages->string);
      }
    }else{
      success = false;
      errorMessages->string = u"Expected decimal point or exponent symbol.";
      errorMessages->stringLength = c16len(errorMessages->string);
    }
  }

  if(success &&  !complete ){
    if(base <= 14.0 && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
      i = i + 1.0;

      if(i < (double)nLength){
        if(n[(int)(i)] == '-'){
          exponentIsPositive->booleanValue = false;
          i = i + 1.0;
        }else if(n[(int)(i)] == '+'){
          exponentIsPositive->booleanValue = true;
          i = i + 1.0;
        }

        if(i < (double)nLength){
          done = false;
          count = 0.0;
          for(; i + count < (double)nLength &&  !done ; ){
            if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], base)){
              count = count + 1.0;
            }else{
              done = true;
            }
          }

          if(count >= 1.0){
            exponent->numberArray = (double*)calloc(sizeof(double) * (count), 1);
            exponent->numberArrayLength = count;

            for(j = 0.0; j < count; j = j + 1.0){
              exponent->numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], base);
            }

            i = i + count;

            if(i == (double)nLength){
              success = true;
            }else{
              success = false;
              errorMessages->string = u"There cannot be any characters past the exponent of the number.";
              errorMessages->stringLength = c16len(errorMessages->string);
            }
          }else{
            success = false;
            errorMessages->string = u"There must be at least one digit after the decimal point.";
            errorMessages->stringLength = c16len(errorMessages->string);
          }
        }else{
          success = false;
          errorMessages->string = u"There must be at least one digit after the exponent symbol.";
          errorMessages->stringLength = c16len(errorMessages->string);
        }
      }else{
        success = false;
        errorMessages->string = u"There must be at least one digit after the exponent symbol.";
        errorMessages->stringLength = c16len(errorMessages->string);
      }
    }else{
      success = false;
      errorMessages->string = u"Expected exponent symbol.";
      errorMessages->stringLength = c16len(errorMessages->string);
    }
  }

  return success;
}
double GetNumberFromNumberCharacterForBase(char16_t c, double base){
  char16_t *numberTable;
  size_t numberTableLength;
  double i;
  double position;

  numberTable = GetDigitCharacterTable(&numberTableLength);
  position = 0.0;

  for(i = 0.0; i < base; i = i + 1.0){
    if(numberTable[(int)(i)] == c){
      position = i;
    }
  }

  return position;
}
_Bool CharacterIsNumberCharacterInBase(char16_t c, double base){
  char16_t *numberTable;
  size_t numberTableLength;
  double i;
  _Bool found;

  numberTable = GetDigitCharacterTable(&numberTableLength);
  found = false;

  for(i = 0.0; i < base; i = i + 1.0){
    if(numberTable[(int)(i)] == c){
      found = true;
    }
  }

  return found;
}
double *StringToNumberArray(size_t *returnArrayLength, char16_t *str, size_t strLength){
  NumberArrayReference *numberArrayReference;
  StringReference *stringReference;
  double *numbers;
  size_t numbersLength;

  numberArrayReference = (NumberArrayReference *)calloc(sizeof(NumberArrayReference), 1);
  stringReference = (StringReference *)calloc(sizeof(StringReference), 1);

  StringToNumberArrayWithCheck(str, strLength, numberArrayReference, stringReference);

  numbers = numberArrayReference->numberArray;
  numbersLength = numberArrayReference->numberArrayLength;

  free(numberArrayReference);
  free(stringReference);

  *returnArrayLength = numbersLength;
  return numbers;
}
_Bool StringToNumberArrayWithCheck(char16_t *str, size_t strLength, NumberArrayReference *numberArrayReference, StringReference *errorMessage){
  StringReference **numberStrings;
  size_t numberStringsLength;
  double *numbers;
  size_t numbersLength;
  double i;
  char16_t *numberString, *trimmedNumberString;
  size_t numberStringLength, trimmedNumberStringLength;
  _Bool success;
  NumberReference *numberReference;

  numberStrings = strSplitByString(&numberStringsLength, str, strLength, strparam(u","));

  numbers = (double*)calloc(sizeof(double) * ((double)numberStringsLength), 1);
  numbersLength = (double)numberStringsLength;
  success = true;
  numberReference = (NumberReference *)calloc(sizeof(NumberReference), 1);

  for(i = 0.0; i < (double)numberStringsLength; i = i + 1.0){
    numberString = numberStrings[(int)(i)]->string;
    numberStringLength = numberStrings[(int)(i)]->stringLength;
    trimmedNumberString = strTrim(&trimmedNumberStringLength, numberString, numberStringLength);
    success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, trimmedNumberStringLength, numberReference, errorMessage);
    numbers[(int)(i)] = numberReference->numberValue;

    FreeStringReference(numberStrings[(int)(i)]);
    free(trimmedNumberString);
  }

  free(numberStrings);
  free(numberReference);

  numberArrayReference->numberArray = numbers;
  numberArrayReference->numberArrayLength = numbersLength;

  return success;
}
void strWriteStringToStingStream(char16_t *stream, size_t streamLength, NumberReference *index, char16_t *src, size_t srcLength){
  double i;

  for(i = 0.0; i < (double)srcLength; i = i + 1.0){
    stream[(int)(index->numberValue + i)] = src[(int)(i)];
  }
  index->numberValue = index->numberValue + (double)srcLength;
}
void strWriteCharacterToStingStream(char16_t *stream, size_t streamLength, NumberReference *index, char16_t src){
  stream[(int)(index->numberValue)] = src;
  index->numberValue = index->numberValue + 1.0;
}
void strWriteBooleanToStingStream(char16_t *stream, size_t streamLength, NumberReference *index, _Bool src){
  if(src){
    strWriteStringToStingStream(stream, streamLength, index, strparam(u"true"));
  }else{
    strWriteStringToStingStream(stream, streamLength, index, strparam(u"false"));
  }
}
_Bool strSubstringWithCheck(char16_t *string, size_t stringLength, double from, double to, StringReference *stringReference){
  _Bool success;

  if(from >= 0.0 && from <= (double)stringLength && to >= 0.0 && to <= (double)stringLength && from <= to){
    stringReference->string = strSubstring(&stringReference->stringLength, string, stringLength, from, to);
    success = true;
  }else{
    success = false;
  }

  return success;
}
char16_t *strSubstring(size_t *returnArrayLength, char16_t *string, size_t stringLength, double from, double to){
  char16_t *n;
  size_t nLength;
  double i, length;

  length = to - from;

  n = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
  nLength = length;

  for(i = from; i < to; i = i + 1.0){
    n[(int)(i - from)] = string[(int)(i)];
  }

  *returnArrayLength = nLength;
  return n;
}
char16_t *strAppendString(size_t *returnArrayLength, char16_t *s1, size_t s1Length, char16_t *s2, size_t s2Length){
  char16_t *newString;
  size_t newStringLength;

  newString = strConcatenateString(&newStringLength, s1, s1Length, s2, s2Length);

  free(s1);

  *returnArrayLength = newStringLength;
  return newString;
}
char16_t *strConcatenateString(size_t *returnArrayLength, char16_t *s1, size_t s1Length, char16_t *s2, size_t s2Length){
  char16_t *newString;
  size_t newStringLength;
  double i;

  newString = (char16_t*)calloc(sizeof(char16_t) * ((double)s1Length + (double)s2Length), 1);
  newStringLength = (double)s1Length + (double)s2Length;

  for(i = 0.0; i < (double)s1Length; i = i + 1.0){
    newString[(int)(i)] = s1[(int)(i)];
  }

  for(i = 0.0; i < (double)s2Length; i = i + 1.0){
    newString[(int)((double)s1Length + i)] = s2[(int)(i)];
  }

  *returnArrayLength = newStringLength;
  return newString;
}
char16_t *strAppendCharacter(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t c){
  char16_t *newString;
  size_t newStringLength;

  newString = strConcatenateCharacter(&newStringLength, string, stringLength, c);

  free(string);

  *returnArrayLength = newStringLength;
  return newString;
}
char16_t *strConcatenateCharacter(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t c){
  char16_t *newString;
  size_t newStringLength;
  double i;
  newString = (char16_t*)calloc(sizeof(char16_t) * ((double)stringLength + 1.0), 1);
  newStringLength = (double)stringLength + 1.0;

  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    newString[(int)(i)] = string[(int)(i)];
  }

  newString[(int)((double)stringLength)] = c;

  *returnArrayLength = newStringLength;
  return newString;
}
StringReference **strSplitByCharacter(size_t *returnArrayLength, char16_t *toSplit, size_t toSplitLength, char16_t splitBy){
  StringReference **parts;
  size_t partsLength;
  double i;
  char16_t c;
  LinkedListStrings *ll;
  LinkedListCharacters *next;
  char16_t *part;
  size_t partLength;

  ll = CreateLinkedListString();

  next = CreateLinkedListCharacter();
  for(i = 0.0; i < (double)toSplitLength; i = i + 1.0){
    c = toSplit[(int)(i)];

    if(c == splitBy){
      part = LinkedListCharactersToArray(&partLength, next);
      LinkedListAddString(ll, part, partLength);
      FreeLinkedListCharacter(next);
      next = CreateLinkedListCharacter();
    }else{
      LinkedListAddCharacter(next, c);
    }
  }

  part = LinkedListCharactersToArray(&partLength, next);
  LinkedListAddString(ll, part, partLength);
  FreeLinkedListCharacter(next);

  parts = LinkedListStringsToArray(&partsLength, ll);
  FreeLinkedListString(ll);

  *returnArrayLength = partsLength;
  return parts;
}
_Bool strIndexOfCharacter(char16_t *string, size_t stringLength, char16_t character, NumberReference *indexReference){
  double i;
  _Bool found;

  found = false;
  for(i = 0.0; i < (double)stringLength &&  !found ; i = i + 1.0){
    if(string[(int)(i)] == character){
      found = true;
      indexReference->numberValue = i;
    }
  }

  return found;
}
_Bool strLastIndexOfCharacter(char16_t *string, size_t stringLength, char16_t character, NumberReference *indexReference){
  double i;
  _Bool found;

  found = false;
  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    if(string[(int)(i)] == character){
      found = true;
      indexReference->numberValue = i;
    }
  }

  return found;
}
_Bool strSubstringEqualsWithCheck(char16_t *string, size_t stringLength, double from, char16_t *substring, size_t substringLength, BooleanReference *equalsReference){
  _Bool success;

  if(from < (double)stringLength){
    success = true;
    equalsReference->booleanValue = strSubstringEquals(string, stringLength, from, substring, substringLength);
  }else{
    success = false;
  }

  return success;
}
_Bool strSubstringEquals(char16_t *string, size_t stringLength, double from, char16_t *substring, size_t substringLength){
  double i;
  _Bool equal;

  equal = true;
  if((double)stringLength - from >= (double)substringLength){
    for(i = 0.0; i < (double)substringLength && equal; i = i + 1.0){
      if(string[(int)(from + i)] != substring[(int)(i)]){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
_Bool strIndexOfString(char16_t *string, size_t stringLength, char16_t *substring, size_t substringLength, NumberReference *indexReference){
  double i;
  _Bool found;

  found = false;
  for(i = 0.0; i < (double)stringLength - (double)substringLength + 1.0 &&  !found ; i = i + 1.0){
    if(strSubstringEquals(string, stringLength, i, substring, substringLength)){
      found = true;
      indexReference->numberValue = i;
    }
  }

  return found;
}
_Bool strContainsCharacter(char16_t *string, size_t stringLength, char16_t character){
  double i;
  _Bool found;

  found = false;
  for(i = 0.0; i < (double)stringLength &&  !found ; i = i + 1.0){
    if(string[(int)(i)] == character){
      found = true;
    }
  }

  return found;
}
_Bool strContainsString(char16_t *string, size_t stringLength, char16_t *substring, size_t substringLength){
  return strIndexOfString(string, stringLength, substring, substringLength, (NumberReference *)calloc(sizeof(NumberReference), 1));
}
void strToUpperCase(char16_t *string, size_t stringLength){
  double i;

  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    string[(int)(i)] = cToUpperCase(string[(int)(i)]);
  }
}
void strToLowerCase(char16_t *string, size_t stringLength){
  double i;

  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    string[(int)(i)] = cToLowerCase(string[(int)(i)]);
  }
}
_Bool strEqualsIgnoreCase(char16_t *a, size_t aLength, char16_t *b, size_t bLength){
  _Bool equal;
  double i;

  if((double)aLength == (double)bLength){
    equal = true;
    for(i = 0.0; i < (double)aLength && equal; i = i + 1.0){
      if(cToLowerCase(a[(int)(i)]) != cToLowerCase(b[(int)(i)])){
        equal = false;
      }
    }
  }else{
    equal = false;
  }

  return equal;
}
char16_t *strReplaceString(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t *toReplace, size_t toReplaceLength, char16_t *replaceWith, size_t replaceWithLength){
  char16_t *result;
  size_t resultLength;
  double i, j;
  BooleanReference *equalsReference;
  _Bool success;
  DynamicArrayCharacters *da;

  da = CreateDynamicArrayCharacters();

  equalsReference = (BooleanReference *)calloc(sizeof(BooleanReference), 1);

  for(i = 0.0; i < (double)stringLength; ){
    success = strSubstringEqualsWithCheck(string, stringLength, i, toReplace, toReplaceLength, equalsReference);
    if(success){
      success = equalsReference->booleanValue;
    }

    if(success && (double)toReplaceLength > 0.0){
      for(j = 0.0; j < (double)replaceWithLength; j = j + 1.0){
        DynamicArrayAddCharacter(da, replaceWith[(int)(j)]);
      }
      i = i + (double)toReplaceLength;
    }else{
      DynamicArrayAddCharacter(da, string[(int)(i)]);
      i = i + 1.0;
    }
  }

  result = DynamicArrayCharactersToArray(&resultLength, da);

  FreeDynamicArrayCharacters(da);

  *returnArrayLength = resultLength;
  return result;
}
char16_t *strReplaceCharacterToNew(size_t *returnArrayLength, char16_t *string, size_t stringLength, char16_t toReplace, char16_t replaceWith){
  char16_t *result;
  size_t resultLength;
  double i;

  result = (char16_t*)calloc(sizeof(char16_t) * ((double)stringLength), 1);
  resultLength = (double)stringLength;

  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    if(string[(int)(i)] == toReplace){
      result[(int)(i)] = replaceWith;
    }else{
      result[(int)(i)] = string[(int)(i)];
    }
  }

  *returnArrayLength = resultLength;
  return result;
}
void strReplaceCharacter(char16_t *string, size_t stringLength, char16_t toReplace, char16_t replaceWith){
  double i;

  for(i = 0.0; i < (double)stringLength; i = i + 1.0){
    if(string[(int)(i)] == toReplace){
      string[(int)(i)] = replaceWith;
    }
  }
}
char16_t *strTrim(size_t *returnArrayLength, char16_t *string, size_t stringLength){
  char16_t *result;
  size_t resultLength;
  double i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd;
  _Bool firstNonWhitespaceFound;

  /* Find whitepaces at the start. */
  lastWhitespaceLocationStart =  -1.0;
  firstNonWhitespaceFound = false;
  for(i = 0.0; i < (double)stringLength &&  !firstNonWhitespaceFound ; i = i + 1.0){
    if(cIsWhiteSpace(string[(int)(i)])){
      lastWhitespaceLocationStart = i;
    }else{
      firstNonWhitespaceFound = true;
    }
  }

  /* Find whitepaces at the end. */
  lastWhitespaceLocationEnd = (double)stringLength;
  firstNonWhitespaceFound = false;
  for(i = (double)stringLength - 1.0; i >= 0.0 &&  !firstNonWhitespaceFound ; i = i - 1.0){
    if(cIsWhiteSpace(string[(int)(i)])){
      lastWhitespaceLocationEnd = i;
    }else{
      firstNonWhitespaceFound = true;
    }
  }

  if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
    result = strSubstring(&resultLength, string, stringLength, lastWhitespaceLocationStart + 1.0, lastWhitespaceLocationEnd);
  }else{
    result = (char16_t*)calloc(sizeof(char16_t) * (0.0), 1);
    resultLength = 0.0;
  }

  *returnArrayLength = resultLength;
  return result;
}
_Bool strStartsWith(char16_t *string, size_t stringLength, char16_t *start, size_t startLength){
  _Bool startsWithString;

  startsWithString = false;
  if((double)stringLength >= (double)startLength){
    startsWithString = strSubstringEquals(string, stringLength, 0.0, start, startLength);
  }

  return startsWithString;
}
_Bool strEndsWith(char16_t *string, size_t stringLength, char16_t *end, size_t endLength){
  _Bool endsWithString;

  endsWithString = false;
  if((double)stringLength >= (double)endLength){
    endsWithString = strSubstringEquals(string, stringLength, (double)stringLength - (double)endLength, end, endLength);
  }

  return endsWithString;
}
StringReference **strSplitByString(size_t *returnArrayLength, char16_t *toSplit, size_t toSplitLength, char16_t *splitBy, size_t splitByLength){
  StringReference **parts;
  size_t partsLength;
  double i;
  char16_t c;
  LinkedListStrings *ll;
  LinkedListCharacters *next;
  char16_t *part;
  size_t partLength;

  ll = CreateLinkedListString();

  next = CreateLinkedListCharacter();
  for(i = 0.0; i < (double)toSplitLength; ){
    c = toSplit[(int)(i)];

    if(strSubstringEquals(toSplit, toSplitLength, i, splitBy, splitByLength)){
      part = LinkedListCharactersToArray(&partLength, next);
      LinkedListAddString(ll, part, partLength);
      FreeLinkedListCharacter(next);
      next = CreateLinkedListCharacter();
      i = i + (double)splitByLength;
    }else{
      LinkedListAddCharacter(next, c);
      i = i + 1.0;
    }
  }

  part = LinkedListCharactersToArray(&partLength, next);
  LinkedListAddString(ll, part, partLength);
  FreeLinkedListCharacter(next);

  parts = LinkedListStringsToArray(&partsLength, ll);
  FreeLinkedListString(ll);

  *returnArrayLength = partsLength;
  return parts;
}
_Bool strStringIsBefore(char16_t *a, size_t aLength, char16_t *b, size_t bLength){
  _Bool before, equal, done;
  double i;

  before = false;
  equal = true;
  done = false;

  if((double)aLength == 0.0 && (double)bLength > 0.0){
    before = true;
  }else{
    for(i = 0.0; i < (double)aLength && i < (double)bLength &&  !done ; i = i + 1.0){
      if(a[(int)(i)] != b[(int)(i)]){
        equal = false;
      }
      if(cCharacterIsBefore(a[(int)(i)], b[(int)(i)])){
        before = true;
      }
      if(cCharacterIsBefore(b[(int)(i)], a[(int)(i)])){
        done = true;
      }
    }

    if(equal){
      if((double)aLength < (double)bLength){
        before = true;
      }
    }
  }

  return before;
}
char16_t *strJoinStringsWithSeparator(size_t *returnArrayLength, StringReference **strings, size_t stringsLength, char16_t *separator, size_t separatorLength){
  char16_t *result, *string;
  size_t resultLength, stringLength;
  double length, i;
  NumberReference *index;

  index = CreateNumberReference(0.0);

  length = 0.0;
  for(i = 0.0; i < (double)stringsLength; i = i + 1.0){
    length = length + (double)strings[(int)(i)]->stringLength;
  }
  length = length + ((double)stringsLength - 1.0)*(double)separatorLength;

  result = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
  resultLength = length;

  for(i = 0.0; i < (double)stringsLength; i = i + 1.0){
    string = strings[(int)(i)]->string;
    stringLength = strings[(int)(i)]->stringLength;
    strWriteStringToStingStream(result, resultLength, index, string, stringLength);
    if(i + 1.0 < (double)stringsLength){
      strWriteStringToStingStream(result, resultLength, index, separator, separatorLength);
    }
  }

  free(index);

  *returnArrayLength = resultLength;
  return result;
}
char16_t *strJoinStrings(size_t *returnArrayLength, StringReference **strings, size_t stringsLength){
  char16_t *result, *string;
  size_t resultLength, stringLength;
  double length, i;
  NumberReference *index;

  index = CreateNumberReference(0.0);

  length = 0.0;
  for(i = 0.0; i < (double)stringsLength; i = i + 1.0){
    length = length + (double)strings[(int)(i)]->stringLength;
  }

  result = (char16_t*)calloc(sizeof(char16_t) * (length), 1);
  resultLength = length;

  for(i = 0.0; i < (double)stringsLength; i = i + 1.0){
    string = strings[(int)(i)]->string;
    stringLength = strings[(int)(i)]->stringLength;
    strWriteStringToStingStream(result, resultLength, index, string, stringLength);
  }

  free(index);

  *returnArrayLength = resultLength;
  return result;
}
double strStringOrder(char16_t *a, size_t aLength, char16_t *b, size_t bLength){
  double order, minimum, i, ac, bc;
  _Bool done;

  minimum = fmin((double)aLength, (double)bLength);

  done = false;
  order = 0.0;
  for(i = 0.0; i < minimum &&  !done ; i = i + 1.0){
    ac = a[(int)(i)];
    bc = b[(int)(i)];

    if(ac < bc){
      done = true;
      order = 1.0;
    }else if(ac > bc){
      done = true;
      order =  -1.0;
    }
  }

  if( !done ){
    if((double)aLength < (double)bLength){
      order = 1.0;
    }else if((double)aLength > (double)bLength){
      order =  -1.0;
    }
  }

  return order;
}
char16_t *strLeftPad(size_t *returnArrayLength, char16_t *str, size_t strLength, double width){
  double i;
  char16_t *padded;
  size_t paddedLength;

  padded = (char16_t*)calloc(sizeof(char16_t) * (width), 1);
  paddedLength = width;
  arraysFillString(padded, paddedLength, ' ');

  for(i = 0.0; i < (double)strLength; i = i + 1.0){
    padded[(int)(width - (double)strLength + i)] = str[(int)(i)];
  }

  *returnArrayLength = paddedLength;
  return padded;
}
char16_t *strRightPad(size_t *returnArrayLength, char16_t *str, size_t strLength, double width){
  double i;
  char16_t *padded;
  size_t paddedLength;

  padded = (char16_t*)calloc(sizeof(char16_t) * (width), 1);
  paddedLength = width;
  arraysFillString(padded, paddedLength, ' ');

  for(i = 0.0; i < (double)strLength; i = i + 1.0){
    padded[(int)(i)] = str[(int)(i)];
  }

  *returnArrayLength = paddedLength;
  return padded;
}
void AssertFalse(_Bool b, NumberReference *failures){
  if(b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertTrue(_Bool b, NumberReference *failures){
  if( !b ){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertEquals(double a, double b, NumberReference *failures){
  if(a != b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertBooleansEqual(_Bool a, _Bool b, NumberReference *failures){
  if(a != b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertCharactersEqual(char16_t a, char16_t b, NumberReference *failures){
  if(a != b){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertStringEquals(char16_t *a, size_t aLength, char16_t *b, size_t bLength, NumberReference *failures){
  if( !arraysStringsEqual(a, aLength, b, bLength) ){
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertNumberArraysEqual(double *a, size_t aLength, double *b, size_t bLength, NumberReference *failures){
  double i;

  if((double)aLength == (double)bLength){
    for(i = 0.0; i < (double)aLength; i = i + 1.0){
      AssertEquals(a[(int)(i)], b[(int)(i)], failures);
    }
  }else{
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertBooleanArraysEqual(_Bool *a, size_t aLength, _Bool *b, size_t bLength, NumberReference *failures){
  double i;

  if((double)aLength == (double)bLength){
    for(i = 0.0; i < (double)aLength; i = i + 1.0){
      AssertBooleansEqual(a[(int)(i)], b[(int)(i)], failures);
    }
  }else{
    failures->numberValue = failures->numberValue + 1.0;
  }
}
void AssertStringArraysEqual(StringReference **a, size_t aLength, StringReference **b, size_t bLength, NumberReference *failures){
  double i;

  if((double)aLength == (double)bLength){
    for(i = 0.0; i < (double)aLength; i = i + 1.0){
      AssertStringEquals(a[(int)(i)]->string, a[(int)(i)]->stringLength, b[(int)(i)]->string, b[(int)(i)]->stringLength, failures);
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
  return fabs(x);
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
_Bool DivisibleBy(double a, double b){
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
_Bool EpsilonCompare(double a, double b, double epsilon){
  return fabs(a - b) < epsilon;
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
_Bool IsInteger(double a){
  return (a - floor(a)) == 0.0;
}
_Bool GreatestCommonDivisorWithCheck(double a, double b, NumberReference *gcdReference){
  _Bool success;
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
    lcm = fabs(a*b)/GreatestCommonDivisor(a, b);
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
  double *p;
  size_t pLength;
  double i, y, t, x;

  p = (double*)calloc(sizeof(double) * (8.0), 1);
  pLength = 8.0;
  p[0] = 676.5203681218851;
  p[1] =  -1259.1392167224028;
  p[2] = 771.32342877765313;
  p[3] =  -176.61502916214059;
  p[4] = 12.507343278686905;
  p[5] =  -0.13857109526572012;
  p[6] = 9.9843695780195716e-6;
  p[7] = 1.5056327351493116e-7;

  if(z < 0.5){
    y = M_PI/(sin(M_PI*z)*LanczosApproximation(1.0 - z));
  }else{
    z = z - 1.0;
    x = 0.99999999999980993;
    for(i = 0.0; i < (double)pLength; i = i + 1.0){
      x = x + p[(int)(i)]/(z + i + 1.0);
    }
    t = z + (double)pLength - 0.5;
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

    t = 1.0/(1.0 + 0.5*fabs(x));

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

  if(fabs(z) >= 0.5){
    y = pow(1.0 - z,  -a)*HypergeometricDirect(a, c - b, c, z/(z - 1.0), maxIterations, precision);
  }else{
    y = HypergeometricDirect(a, b, c, z, maxIterations, precision);
  }

  return y;
}
double HypergeometricDirect(double a, double b, double c, double z, double maxIterations, double precision){
  double y, yp, n;
  _Bool done;

  y = 0.0;
  done = false;

  for(n = 0.0; n < maxIterations &&  !done ; n = n + 1.0){
    yp = RisingFactorial(a, n)*RisingFactorial(b, n)/RisingFactorial(c, n)*pow(z, n)/Factorial(n);
    if(fabs(yp) < precision){
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
  double *A;
  size_t ALength;

  A = (double*)calloc(sizeof(double) * (n + 1.0), 1);
  ALength = n + 1.0;

  for(m = 0.0; m <= n; m = m + 1.0){
    A[(int)(m)] = 1.0/(m + 1.0);
    for(j = m; j >= 1.0; j = j - 1.0){
      A[(int)(j - 1.0)] = j*(A[(int)(j - 1.0)] - A[(int)(j)]);
    }
  }

  B = A[0];

  free(A);

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

  x = fabs(x);

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
char16_t *Decimal15E2ToString(size_t *returnArrayLength, double decimal){
  double multiplier, inc, i, d;
  double exponent;
  _Bool done, isPositive, isPositiveExponent;
  char16_t *result;
  size_t resultLength;
  double len;

  len = 21.0;
  /* 1+1+1+14+1+1+2 -- "+0.00000000000000e+00" */
  result = (char16_t*)calloc(sizeof(char16_t) * (len), 1);
  resultLength = len;

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
      for(; (decimal >= 10.0 || decimal < 1.0) && fabs(exponent) < 99.0; ){
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
    result[0] = '+';
  }else{
    result[0] = '-';
  }

  decimal = round(decimal*pow(10.0, 14.0));

  d = floor(decimal/pow(10.0, 14.0));
  result[1] = SingleDigitNumberToCharacter(d);
  decimal = decimal - d*pow(10.0, 14.0);

  result[2] = '.';

  for(i = 0.0; i < 14.0; i = i + 1.0){
    d = floor(decimal/pow(10.0, 13.0 - i));
    result[(int)(3.0 + i)] = SingleDigitNumberToCharacter(d);
    decimal = decimal - d*pow(10.0, 13.0 - i);
  }

  result[17] = 'e';

  if(isPositiveExponent){
    result[18] = '+';
  }else{
    result[18] = '-';
  }

  result[19] = SingleDigitNumberToCharacter(floor(exponent/10.0));
  result[20] = SingleDigitNumberToCharacter(floor(fmod(exponent, 10.0)));

  *returnArrayLength = resultLength;
  return result;
}
char16_t SingleDigitNumberToCharacter(double n){
  char16_t c;

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
char16_t cToLowerCase(char16_t character){
  char16_t toReturn;

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
char16_t cToUpperCase(char16_t character){
  char16_t toReturn;

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
_Bool cIsUpperCase(char16_t character){
  _Bool isUpper;

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
_Bool cIsLowerCase(char16_t character){
  _Bool isLower;

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
_Bool cIsLetter(char16_t character){
  return cIsUpperCase(character) || cIsLowerCase(character);
}
_Bool cIsNumber(char16_t character){
  _Bool isNumberx;

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
_Bool cIsWhiteSpace(char16_t character){
  _Bool isWhiteSpacex;

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
_Bool cIsSymbol(char16_t character){
  _Bool isSymbolx;

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
_Bool cCharacterIsBefore(char16_t a, char16_t b){
  double ad, bd;

  ad = a;
  bd = b;

  return ad < bd;
}
char16_t cDecimalDigitToCharacter(double digit){
  char16_t c;
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
double cCharacterToDecimalDigit(char16_t c){
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

