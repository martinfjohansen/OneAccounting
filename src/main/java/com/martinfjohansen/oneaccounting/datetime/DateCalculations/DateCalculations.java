package com.martinfjohansen.oneaccounting.datetime.DateCalculations;

import static java.lang.Math.*;

import com.martinfjohansen.oneaccounting.references.references.BooleanReference;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;
import static com.martinfjohansen.oneaccounting.references.references.references.*;

import static com.martinfjohansen.oneaccounting.math.math.math.*;

import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.*;

public class DateCalculations{
	public static Date CreateDate(double year, double month, double day){
		Date date;

		date = new Date();

		date.year = year;
		date.month = month;
		date.day = day;

		return date;
	}

	public static boolean IsLeapYearWithCheck(double year, BooleanReference isLeapYearReference, StringReference message){
		boolean itIsLeapYear;
		boolean success;

		if(year >= 1752d){
			success = true;
			itIsLeapYear = IsLeapYear(year);
		}else{
			success = false;
			itIsLeapYear = false;
			message.string = "Gregorian calendar was not in general use.".toCharArray();
		}

		isLeapYearReference.booleanValue = itIsLeapYear;
		return success;
	}

	public static boolean IsLeapYear(double year){
		boolean itIsLeapYear;

		if(DivisibleBy(year, 4d)){
			if(DivisibleBy(year, 100d)){
				if(DivisibleBy(year, 400d)){
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

	public static boolean DayToDateWithCheck(double dayNr, DateReference dateReference, StringReference message){
		Date date;
		NumberReference remainder;
		boolean success;

		if(dayNr >= -79623d){
			date = new Date();
			remainder = new NumberReference();
			remainder.numberValue = dayNr + 79623d;
			/* Days since 1752-01-01. Day 0: Thursday, 1970-01-01*/
			/* Find year.*/
			date.year = GetYearFromDayNr(remainder.numberValue, remainder);

			/* Find month.*/
			date.month = GetMonthFromDayNr(remainder.numberValue, date.year, remainder);

			/* Find day.*/
			date.day = 1d + remainder.numberValue;

			dateReference.date = date;
			success = true;
		}else{
			success = false;
			message.string = "Gregorian calendar was not in general use before 1752.".toCharArray();
		}

		return success;
	}

	public static Date DayToDate(double dayNr){
		Date date;
		boolean success;
		DateReference dateRef;
		StringReference message;

		dateRef = new DateReference();
		message = new StringReference();

		success = DayToDateWithCheck(dayNr, dateRef, message);
		if(success){
			date = dateRef.date;
			delete(dateRef);
			FreeStringReference(message);
		}else{
			date = CreateDate(1970d, 1d, 1d);
		}

		return date;
	}

	public static boolean GetMonthFromDayNrWithCheck(double dayNr, double year, NumberReference monthReference, NumberReference remainderReference, StringReference message){
		double month;
		boolean success;

		if(dayNr >= -79623d){
			month = GetMonthFromDayNr(dayNr, year, remainderReference);
			monthReference.numberValue = month;
			success = true;
		}else{
			success = false;
			message.string = "Gregorian calendar not in general use before 1752.".toCharArray();
		}

		return success;
	}

	public static double GetMonthFromDayNr(double dayNr, double year, NumberReference remainderReference){
		double [] daysInMonth;
		boolean done;
		double month;

		daysInMonth = GetDaysInMonth(year);
		done = false;
		month = 1d;

		for(; !done; ){
			if(dayNr >= daysInMonth[(int)(month)]){
				dayNr = dayNr - daysInMonth[(int)(month)];
				month = month + 1d;
			}else{
				done = true;
			}
		}
		remainderReference.numberValue = dayNr;

		return month;
	}

	public static boolean GetYearFromDayNrWithCheck(double dayNr, NumberReference yearReference, NumberReference remainder, StringReference message){
		boolean success;
		double year;

		if(dayNr >= 0d){
			success = true;
			year = GetYearFromDayNr(dayNr, remainder);
			yearReference.numberValue = year;
		}else{
			success = false;
			message.string = "Day number must be 0 or higher. 0 is 1752-01-01.".toCharArray();
		}

		return success;
	}

	public static double GetYearFromDayNr(double dayNr, NumberReference remainder){
		double nrOfDays;
		boolean done;
		double year;

		done = false;
		year = 1752d;

		for(; !done; ){
			if(IsLeapYear(year)){
				nrOfDays = 366d;
			}else{
				nrOfDays = 365d;
			}

			if(dayNr >= nrOfDays){
				/* First day is 0.*/
				dayNr = dayNr - nrOfDays;
				year = year + 1d;
			}else{
				done = true;
			}
		}
		remainder.numberValue = dayNr;

		return year;
	}

	public static double DaysBetweenDates(Date A, Date B){
		double daysA, daysB, daysBetween;

		daysA = DateToDays(A);
		daysB = DateToDays(B);

		daysBetween = daysB - daysA;

		return daysBetween;
	}

	public static boolean GetDaysInMonthWithCheck(double year, NumberArrayReference daysInMonthReference, StringReference message){
		double [] daysInMonth;
		boolean success;
		Date date;

		date = CreateDate(year, 1d, 1d);

		success = IsValidDate(date, message);
		if(success){
			daysInMonth = GetDaysInMonth(year);

			daysInMonthReference.numberArray = daysInMonth;
		}

		return success;
	}

	public static double [] GetDaysInMonth(double year){
		double [] daysInMonth;

		daysInMonth = new double [(int)(1d + 12d)];

		daysInMonth[0] = 0d;
		daysInMonth[1] = 31d;

		if(IsLeapYear(year)){
			daysInMonth[2] = 29d;
		}else{
			daysInMonth[2] = 28d;
		}
		daysInMonth[3] = 31d;
		daysInMonth[4] = 30d;
		daysInMonth[5] = 31d;
		daysInMonth[6] = 30d;
		daysInMonth[7] = 31d;
		daysInMonth[8] = 31d;
		daysInMonth[9] = 30d;
		daysInMonth[10] = 31d;
		daysInMonth[11] = 30d;
		daysInMonth[12] = 31d;

		return daysInMonth;
	}

	public static boolean DateToDaysWithCheck(Date date, NumberReference dayNumberReferenceReference, StringReference message){
		double days;
		boolean success;

		success = IsValidDate(date, message);
		if(success){
			days = DateToDays(date);
			dayNumberReferenceReference.numberValue = days;
		}

		return success;
	}

	public static double DateToDays(Date date){
		double days;

		/* Day 1752-01-01*/
		days = -79623d;

		days = days + DaysInYears(date.year);
		days = days + DaysInMonths(date.month, date.year);
		days = days + date.day - 1d;

		return days;
	}

	public static boolean DateToWeekdayNumberWithCheck(Date date, NumberReference weekDayNumberReference, StringReference message){
		double weekDay;
		boolean success;

		success = IsValidDate(date, message);
		if(success){
			weekDay = DateToWeekdayNumber(date);
			weekDayNumberReference.numberValue = weekDay;
		}

		return success;
	}

	public static double DateToWeekdayNumber(Date date){
		double days, weekDay;

		days = DateToDays(date);

		days = days + 79623d;
		days = days + 5d;

		weekDay = days%7d + 1d;

		return weekDay;
	}

	public static double DateToWeeknumber(Date date, NumberReference yearRef){
		double weekNumber, weekday, days, daysWeek1Start, weekdayNewYears;
		Date week1Start, newyears;

		week1Start = CopyDate(date);

		week1Start.day = 1d;
		week1Start.month = 1d;
		weekday = DateToWeekdayNumber(week1Start);

		/* Set week1Start to the start of the Week 1.*/
		/* If monday, week 1 begins on Jan. 1st*/
		if(weekday == 1d){
			week1Start.day = 1d;
		}
		/* If tuesday, week 1 begins on Dec. 31st*/
		if(weekday == 2d){
			week1Start.year = week1Start.year - 1d;
			week1Start.month = 12d;
			week1Start.day = 31d;
		}
		/* If wednesday, week 1 begins on Dec. 30th*/
		if(weekday == 3d){
			week1Start.year = week1Start.year - 1d;
			week1Start.month = 12d;
			week1Start.day = 30d;
		}
		/* If thursday, week 1 begins on Dec. 29th*/
		if(weekday == 4d){
			week1Start.year = week1Start.year - 1d;
			week1Start.month = 12d;
			week1Start.day = 29d;
		}
		/* If friday, week 1 begins on Jan. 4th*/
		if(weekday == 5d){
			week1Start.day = 4d;
		}
		/* If saturday, week 1 begins on Jan. 3rd*/
		if(weekday == 6d){
			week1Start.day = 3d;
		}
		/* If sunday, week 1 begins on Jan. 2nd*/
		if(weekday == 7d){
			week1Start.day = 2d;
		}

		days = DateToDays(date);
		daysWeek1Start = DateToDays(week1Start);

		if(days >= daysWeek1Start){
			weekNumber = 1d + floor((days - daysWeek1Start)/7d);

			if(weekNumber >= 1d && weekNumber <= 52d){
				/* Week is between 1 and 52 in the current year.*/
				yearRef.numberValue = date.year;
			}else{
				/* Is week nr 53 or 1 next year?*/
				newyears = CopyDate(date);
				newyears.month = 12d;
				newyears.day = 31d;
				weekdayNewYears = DateToWeekdayNumber(newyears);
				if(weekdayNewYears == 1d || weekdayNewYears == 2d || weekdayNewYears == 3d){
					/* Week 1 next year.*/
					weekNumber = 1d;
					yearRef.numberValue = date.year + 1d;
				}else{
					/* Week 53*/
					yearRef.numberValue = date.year;
				}
				delete(newyears);
			}
		}else{
			/* Week is in previous year. Either 52nd or 53rd.*/
			newyears = CopyDate(date);
			newyears.month = 12d;
			newyears.day = 31d;
			newyears.year = date.year - 1d;
			weekNumber = DateToWeeknumber(newyears, yearRef);
			delete(newyears);
		}

		delete(week1Start);

		return weekNumber;
	}

	public static boolean DaysInMonthsWithCheck(double month, double year, NumberReference daysInMonthsReference, StringReference message){
		double days;
		boolean success;
		Date date;

		date = CreateDate(year, month, 1d);

		success = IsValidDate(date, message);
		if(success){
			days = DaysInMonths(month, year);

			daysInMonthsReference.numberValue = days;
		}

		return success;
	}

	public static double DaysInMonths(double month, double year){
		double [] daysInMonth;
		double days;
		double i;

		daysInMonth = GetDaysInMonth(year);

		days = 0d;
		for(i = 1d; i < month; i = i + 1d){
			days = days + daysInMonth[(int)(i)];
		}

		return days;
	}

	public static boolean DaysInYearsWithCheck(double years, NumberReference daysReference, StringReference message){
		double days;
		boolean success;
		Date date;

		date = CreateDate(years, 1d, 1d);

		success = IsValidDate(date, message);
		if(success){
			days = DaysInYears(years);
			daysReference.numberValue = days;
		}

		return success;
	}

	public static double DaysInYears(double years){
		double days;
		double i;
		double nrOfDays;

		days = 0d;
		for(i = 1752d; i < years; i = i + 1d){
			if(IsLeapYear(i)){
				nrOfDays = 366d;
			}else{
				nrOfDays = 365d;
			}
			days = days + nrOfDays;
		}

		return days;
	}

	public static boolean IsValidDate(Date date, StringReference message){
		boolean valid;
		double [] daysInMonth;
		double daysInThisMonth;

		if(date.year >= 1752d){
			if(date.month >= 1d && date.month <= 12d){
				daysInMonth = GetDaysInMonth(date.year);
				daysInThisMonth = daysInMonth[(int)(date.month)];
				if(date.day >= 1d && date.day <= daysInThisMonth){
					valid = true;
				}else{
					valid = false;
					message.string = "The month does not have the given day number.".toCharArray();
				}
			}else{
				valid = false;
				message.string = "Month must be between 1 and 12, inclusive.".toCharArray();
			}
		}else{
			valid = false;
			message.string = "Gregorian calendar was not in general use before 1752.".toCharArray();
		}

		return valid;
	}

	public static boolean AddDaysToDate(Date date, double days, StringReference message){
		double n;
		boolean success;
		DateReference dateReference;
		NumberReference daysRef;

		daysRef = new NumberReference();
		success = DateToDaysWithCheck(date, daysRef, message);

		if(success){
			n = daysRef.numberValue;
			n = n + days;

			dateReference = new DateReference();
			success = DayToDateWithCheck(n, dateReference, message);
			if(success){
				AssignDate(date, dateReference.date);
			}
		}

		return success;
	}

	public static void AssignDate(Date a, Date b){
		a.year = b.year;
		a.month = b.month;
		a.day = b.day;
	}

	public static void AddMonthsToDate(Date date, double months){
		double i;

		if(months > 0d){
			for(i = 0d; i < months; i = i + 1d){
				date.month = date.month + 1d;

				if(date.month == 13d){
					date.month = 1d;
					date.year = date.year + 1d;
				}
			}
		}
		if(months < 0d){
			for(i = 0d; i < -months; i = i + 1d){
				date.month = date.month - 1d;

				if(date.month == 0d){
					date.month = 12d;
					date.year = date.year - 1d;
				}
			}
		}
	}

	public static boolean DateToStringISO8601WithCheck(Date date, StringReference datestr, StringReference message){
		boolean success;

		success = IsValidDate(date, message);

		if(success){
			if(date.year <= 9999d){
				datestr.string = DateToStringISO8601(date);
			}else{
				message.string = "This library works from 1752 to 9999.".toCharArray();
			}
		}

		return success;
	}

	public static char [] DateToStringISO8601(Date date){
		char [] str;

		str = new char [10];

		str[0] = cDecimalDigitToCharacter(floor(date.year/1000d));
		str[1] = cDecimalDigitToCharacter(floor((date.year%1000d)/100d));
		str[2] = cDecimalDigitToCharacter(floor((date.year%100d)/10d));
		str[3] = cDecimalDigitToCharacter(floor(date.year%10d));

		str[4] = '-';

		str[5] = cDecimalDigitToCharacter(floor((date.month%100d)/10d));
		str[6] = cDecimalDigitToCharacter(floor(date.month%10d));

		str[7] = '-';

		str[8] = cDecimalDigitToCharacter(floor((date.day%100d)/10d));
		str[9] = cDecimalDigitToCharacter(floor(date.day%10d));

		return str;
	}

	public static Date DateFromStringISO8601(char [] str){
		Date date;
		double n;

		date = new Date();

		n = cCharacterToDecimalDigit(str[0])*1000d;
		n = n + cCharacterToDecimalDigit(str[1])*100d;
		n = n + cCharacterToDecimalDigit(str[2])*10d;
		n = n + cCharacterToDecimalDigit(str[3])*1d;

		date.year = n;

		n = cCharacterToDecimalDigit(str[5])*10d;
		n = n + cCharacterToDecimalDigit(str[6])*1d;

		date.month = n;

		n = cCharacterToDecimalDigit(str[8])*10d;
		n = n + cCharacterToDecimalDigit(str[9])*1d;

		date.day = n;

		return date;
	}

	public static boolean DateFromStringISO8601WithCheck(char [] str, DateReference dateRef, StringReference message){
		boolean valid;

		valid = IsValidDateISO8601(str, message);

		if(valid){
			dateRef.date = DateFromStringISO8601(str);
		}

		return valid;
	}

	public static boolean IsValidDateISO8601(char [] str, StringReference message){
		boolean valid;

		if(str.length == 4d + 1d + 2d + 1d + 2d){

			if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9])){
				if(str[4] == '-' && str[7] == '-'){
					valid = true;
				}else{
					valid = false;
					message.string = "ISO8601 date must use \'-\' in positions 5 and 8.".toCharArray();
				}
			}else{
				valid = false;
				message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9 and 10.".toCharArray();
			}
		}else{
			valid = false;
			message.string = "ISO8601 date must be exactly 10 characters long.".toCharArray();
		}

		return valid;
	}

	public static boolean DateEquals(Date a, Date b){
		return a.year == b.year && a.month == b.month && a.day == b.day;
	}

	public static Date CopyDate(Date a){
		Date b;

		b = CreateDate(a.year, a.month, a.day);

		return b;
	}

	public static double GetSecondsFromDate(Date date){
		double seconds, days, secondsInMinute, secondsInHour, secondsInDay;
		NumberReference dayNumberReferenceReference;
		StringReference message;
		boolean success;

		seconds = 0d;
		dayNumberReferenceReference = new NumberReference();
		message = new StringReference();

		success = DateToDaysWithCheck(date, dayNumberReferenceReference, message);
		if(success){
			days = dayNumberReferenceReference.numberValue;

			secondsInMinute = 60d;
			secondsInHour = 60d*secondsInMinute;
			secondsInDay = 24d*secondsInHour;

			seconds = seconds + secondsInDay*days;
		}

		delete(dayNumberReferenceReference);
		delete(message);

		return seconds;
	}

	public static boolean DateIsInInterval(Interval interval, Date date){
		double from, to, day;

		from = DateToDays(interval.first);
		to = DateToDays(interval.last);
		day = DateToDays(date);

		return day >= from && day <= to;
	}

	public static boolean DateLessThan(Date a, Date b){
		double aDays, bDays;

		aDays = DateToDays(a);
		bDays = DateToDays(b);

		return aDays < bDays;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
