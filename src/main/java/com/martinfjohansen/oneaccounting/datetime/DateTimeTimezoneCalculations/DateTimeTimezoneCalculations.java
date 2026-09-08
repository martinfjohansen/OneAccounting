package com.martinfjohansen.oneaccounting.datetime.DateTimeTimezoneCalculations;

import com.martinfjohansen.oneaccounting.datetime.DateTimeCalculations.DateTime;
import com.martinfjohansen.oneaccounting.datetime.DateTimeCalculations.DateTimeReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;


import com.martinfjohansen.oneaccounting.datetime.DateTimeCalculations.*;
import static com.martinfjohansen.oneaccounting.datetime.DateTimeCalculations.DateTimeCalculations.*;

public class DateTimeTimezoneCalculations{
	public static DateTimeTimezone CreateDateTimeTimezone(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetSeconds){
		DateTimeTimezone dateTimeTimezone;

		dateTimeTimezone = new DateTimeTimezone();

		dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
		dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

		return dateTimeTimezone;
	}

	public static DateTimeTimezone CreateDateTimeTimezoneInHoursAndMinutes(double year, double month, double day, double hours, double minutes, double seconds, double timezoneOffsetHours, double timezoneOffsetMinutes){
		DateTimeTimezone dateTimeTimezone;

		dateTimeTimezone = new DateTimeTimezone();

		dateTimeTimezone.dateTime = CreateDateTime(year, month, day, hours, minutes, seconds);
		dateTimeTimezone.timezoneOffsetSeconds = GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes);

		return dateTimeTimezone;
	}

	public static boolean GetDateFromDateTimeTimeZone(DateTimeTimezone dateTimeTimezone, DateTimeReference dateTimeReference, StringReference message){
		DateTime dateTime;

		dateTime = dateTimeTimezone.dateTime;

		return AddSecondsToDateTimeWithCheck(dateTime, -dateTimeTimezone.timezoneOffsetSeconds, dateTimeReference, message);
	}

	public static boolean CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(DateTime dateTime, double timezoneOffsetSeconds, DateTimeTimezoneReference dateTimeTimezoneReference, StringReference message){
		boolean success;
		DateTimeReference adjustedDateTimeReference;
		DateTimeTimezone dateTimeTimezone;

		adjustedDateTimeReference = new DateTimeReference();
		dateTimeTimezone = new DateTimeTimezone();

		success = AddSecondsToDateTime(dateTime, timezoneOffsetSeconds, adjustedDateTimeReference, message);

		if(success){
			dateTimeTimezone.dateTime = adjustedDateTimeReference.dateTime;
			dateTimeTimezone.timezoneOffsetSeconds = timezoneOffsetSeconds;

			dateTimeTimezoneReference.dateTimeTimezone = dateTimeTimezone;
		}

		return success;
	}

	public static boolean CreateDateTimeTimezoneFromDateTimeAndTimeZoneInHoursAndMinutes(DateTime dateTime, double timezoneOffsetHours, double timezoneOffsetMinutes, DateTimeTimezoneReference dateTimeTimezoneReference, StringReference message){
		return CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTime, GetSecondsFromHours(timezoneOffsetHours) + GetSecondsFromMinutes(timezoneOffsetMinutes), dateTimeTimezoneReference, message);
	}

	public static boolean GetDateTimeTimezoneFromSeconds(DateTimeTimezoneReference dateTimeTzRef, double seconds, double offset, StringReference message){
		boolean success;
		DateTimeReference dateTimeRef;

		dateTimeRef = new DateTimeReference();
		success = GetDateTimeFromSeconds(seconds, dateTimeRef, message);

		if(success){
			success = CreateDateTimeTimezoneFromDateTimeAndTimeZoneInSeconds(dateTimeRef.dateTime, offset, dateTimeTzRef, message);
		}

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
