package com.martinfjohansen.oneaccounting.datetime.DateTimeCalculations;

import static java.lang.Math.*;

import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;

import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.*;


import com.martinfjohansen.oneaccounting.datetime.DateCalculations.*;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.*;

public class DateTimeCalculations{
	public static DateTime CreateDateTime(double year, double month, double day, double hours, double minutes, double seconds){
		DateTime dateTime;

		dateTime = new DateTime();

		dateTime.date = CreateDate(year, month, day);
		dateTime.hours = hours;
		dateTime.minutes = minutes;
		dateTime.seconds = seconds;

		return dateTime;
	}

	public static boolean GetDateTimeFromSeconds(double seconds, DateTimeReference dateTimeReference, StringReference message){
		DateTime dateTime;
		double secondsInMinute, secondsInHour, secondsInDay, days, remainder;
		Date date;
		DateReference dateReference;
		boolean success;

		secondsInMinute = 60d;
		secondsInHour = 60d*secondsInMinute;
		secondsInDay = 24d*secondsInHour;
		days = floor(seconds/secondsInDay);
		remainder = seconds - days*secondsInDay;
		dateReference = new DateReference();

		success = DayToDateWithCheck(days, dateReference, message);
		if(success){
			date = dateReference.date;

			dateTime = new DateTime();
			dateTime.date = date;
			dateTime.hours = floor(remainder/secondsInHour);
			remainder = remainder - dateTime.hours*secondsInHour;
			dateTime.minutes = floor(remainder/secondsInMinute);
			remainder = remainder - dateTime.minutes*secondsInMinute;
			dateTime.seconds = remainder;

			dateTimeReference.dateTime = dateTime;
		}

		return success;
	}

	public static double GetSecondsFromDateTime(DateTime dateTime){
		double seconds, secondsInMinute, secondsInHour;

		secondsInMinute = 60d;
		secondsInHour = 60d*secondsInMinute;

		seconds = GetSecondsFromDate(dateTime.date);
		seconds = seconds + secondsInHour*dateTime.hours;
		seconds = seconds + secondsInMinute*dateTime.minutes;
		seconds = seconds + dateTime.seconds;

		return seconds;
	}

	public static double GetSecondsFromMinutes(double minutes){
		return minutes*60d;
	}

	public static double GetSecondsFromHours(double hours){
		return GetSecondsFromMinutes(hours*60d);
	}

	public static double GetSecondsFromDays(double days){
		return GetSecondsFromHours(days*24d);
	}

	public static double GetSecondsFromWeeks(double weeks){
		return GetSecondsFromDays(weeks*7d);
	}

	public static double GetMinutesFromSeconds(double seconds){
		return seconds/60d;
	}

	public static double GetHoursFromSeconds(double seconds){
		return GetMinutesFromSeconds(seconds)/60d;
	}

	public static double GetDaysFromSeconds(double seconds){
		return GetHoursFromSeconds(seconds)/24d;
	}

	public static double GetWeeksFromSeconds(double seconds){
		return GetDaysFromSeconds(seconds)/7d;
	}

	public static Date GetDateFromDateTime(DateTime dateTime){
		return dateTime.date;
	}

	public static boolean AddSecondsToDateTimeWithCheck(DateTime dateTime, double seconds, DateTimeReference dateTimeReference, StringReference message){
		double secondsInDateTime;
		boolean success;

		if(IsValidDateTime(dateTime, message)){
			secondsInDateTime = GetSecondsFromDateTime(dateTime);
			secondsInDateTime = secondsInDateTime + seconds;

			success = GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
		}else{
			success = false;
		}

		return success;
	}

	public static boolean AddSecondsToDateTime(DateTime dateTime, double seconds, DateTimeReference dateTimeReference, StringReference message){
		double secondsInDateTime;

		secondsInDateTime = GetSecondsFromDateTime(dateTime);
		secondsInDateTime = secondsInDateTime + seconds;

		return GetDateTimeFromSeconds(secondsInDateTime, dateTimeReference, message);
	}

	public static boolean AddMinutesToDateTime(DateTime dateTime, double minutes, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromMinutes(minutes), dateTimeReference, message);
	}

	public static boolean AddHoursToDateTime(DateTime dateTime, double hours, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromHours(hours), dateTimeReference, message);
	}

	public static boolean AddDaysToDateTime(DateTime dateTime, double days, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromDays(days), dateTimeReference, message);
	}

	public static boolean AddWeeksToDateTime(DateTime dateTime, double weeks, DateTimeReference dateTimeReference, StringReference message){
		return AddSecondsToDateTime(dateTime, GetSecondsFromWeeks(weeks), dateTimeReference, message);
	}

	public static boolean DateTimeToStringISO8601WithCheck(DateTime datetime, StringReference dateStr, StringReference message){
		boolean success;

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

	public static boolean IsValidDateTime(DateTime datetime, StringReference message){
		boolean success;

		success = IsValidDate(datetime.date, message);

		if(success){
			if(datetime.hours <= 23d && datetime.hours >= 0d){
				if(datetime.minutes <= 59d && datetime.minutes >= 0d){
					if(datetime.seconds <= 59d && datetime.seconds >= 0d){
						success = true;
					}else{
						success = false;
						message.string = "Seconds must be between 0 and 59.".toCharArray();
					}
				}else{
					success = false;
					message.string = "Minutes must be between 0 and 59.".toCharArray();
				}
			}else{
				success = false;
				message.string = "Hours must be between 0 and 23.".toCharArray();
			}
		}

		return success;
	}

	public static char [] DateTimeToStringISO8601(DateTime datetime){
		char [] datestr, str;
		double i;

		str = new char [19];

		datestr = DateToStringISO8601(datetime.date);
		for(i = 0d; i < datestr.length; i = i + 1d){
			str[(int)(i)] = datestr[(int)(i)];
		}

		str[10] = 'T';
		str[11] = cDecimalDigitToCharacter(floor((datetime.hours%100d)/10d));
		str[12] = cDecimalDigitToCharacter(floor(datetime.hours%10d));

		str[13] = ':';

		str[14] = cDecimalDigitToCharacter(floor((datetime.minutes%100d)/10d));
		str[15] = cDecimalDigitToCharacter(floor(datetime.minutes%10d));

		str[16] = ':';

		str[17] = cDecimalDigitToCharacter(floor((datetime.seconds%100d)/10d));
		str[18] = cDecimalDigitToCharacter(floor(datetime.seconds%10d));

		return str;
	}

	public static DateTime DateTimeFromStringISO8601(char [] str){
		DateTime dateTime;
		double n;

		dateTime = new DateTime();

		dateTime.date = DateFromStringISO8601(str);

		n = cCharacterToDecimalDigit(str[11])*10d;
		n = n + cCharacterToDecimalDigit(str[12])*1d;

		dateTime.hours = n;

		n = cCharacterToDecimalDigit(str[14])*10d;
		n = n + cCharacterToDecimalDigit(str[15])*1d;

		dateTime.minutes = n;

		n = cCharacterToDecimalDigit(str[17])*10d;
		n = n + cCharacterToDecimalDigit(str[18])*1d;

		dateTime.seconds = n;

		return dateTime;
	}

	public static boolean DateTimeFromStringISO8601WithCheck(char [] str, DateTimeReference dateTimeRef, StringReference message){
		boolean valid;

		valid = IsValidDateTimeISO8601(str, message);

		if(valid){
			dateTimeRef.dateTime = DateTimeFromStringISO8601(str);
		}

		return valid;
	}

	public static boolean IsValidDateTimeISO8601(char [] str, StringReference message){
		boolean valid;

		if(str.length == 4d + 1d + 2d + 1d + 2d + 1d + 2d + 1d + 2d + 1d + 2d){

			if(cIsNumber(str[0]) && cIsNumber(str[1]) && cIsNumber(str[2]) && cIsNumber(str[3]) && cIsNumber(str[5]) && cIsNumber(str[6]) && cIsNumber(str[8]) && cIsNumber(str[9]) && cIsNumber(str[11]) && cIsNumber(str[12]) && cIsNumber(str[14]) && cIsNumber(str[15]) && cIsNumber(str[17]) && cIsNumber(str[18])){
				if(str[4] == '-' && str[7] == '-' && str[10] == 'T' && str[13] == ':' && str[16] == ':'){
					valid = true;
				}else{
					valid = false;
					message.string = "ISO8601 date must use \'-\' in positions 5 and 8, \'T\' in position 11 and \':\' in positions 14 and 17.".toCharArray();
				}
			}else{
				valid = false;
				message.string = "ISO8601 date must use decimal digits in positions 1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 15, 16, 18 and 19.".toCharArray();
			}
		}else{
			valid = false;
			message.string = "ISO8601 date must be exactly 19 characters long.".toCharArray();
		}

		return valid;
	}

	public static boolean DateTimeEquals(DateTime a, DateTime b){
		return DateEquals(a.date, b.date) && a.hours == b.hours && a.minutes == b.minutes && a.seconds == b.seconds;
	}

	public static void FreeDateTime(DateTime datetime){
		delete(datetime.date);
		delete(datetime);
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
