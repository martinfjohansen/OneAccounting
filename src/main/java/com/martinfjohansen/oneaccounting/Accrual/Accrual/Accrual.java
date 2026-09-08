package com.martinfjohansen.oneaccounting.Accrual.Accrual;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.lists.LinkedListNumbers.Structures.LinkedListNumbers;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;

import com.martinfjohansen.oneaccounting.datetime.DateCalculations.*;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.*;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.*;
import static com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPointArithmetic15d.*;

import static com.martinfjohansen.oneaccounting.math.math.math.*;

import com.martinfjohansen.oneaccounting.lists.LinkedListNumbers.Structures.*;

import static com.martinfjohansen.oneaccounting.lists.LinkedListNumbers.LinkedListNumbersFunctions.LinkedListNumbersFunctions.*;


public class Accrual{
	public static double GetAccrualAmount(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay, double yearOfInterest, double monthOfInterest){
		Date from, to;
		double amount;

		from = CreateDate(fromYear, fromMonth, fromDay);
		to = CreateDate(toYear, toMonth, toDay);

		amount = GetAccrualAmountWithDates(total, from, to, yearOfInterest, monthOfInterest);

		return amount;
	}

	public static double [] GetAccruals(double total, double fromYear, double fromMonth, double fromDay, double toYear, double toMonth, double toDay){
		Date from, to;
		double [] amounts;

		from = CreateDate(fromYear, fromMonth, fromDay);
		to = CreateDate(toYear, toMonth, toDay);

		amounts = GetAccrualsWithDates(total, from, to);

		return amounts;
	}

	public static double [] GetAccrualsWithDates(double total, Date from, Date to){
		double entry;
		boolean done;
		Date dateOfInterest;
		LinkedListNumbers list;
		double [] result;

		list = CreateLinkedListNumbers();

		done = false;
		dateOfInterest = new Date();
		AssignDate(dateOfInterest, from);
		for(; !done; ){
			if(dateOfInterest.year == to.year && dateOfInterest.month == to.month){
				done = true;
			}

			entry = GetAccrualAmountWithDates(total, from, to, dateOfInterest.year, dateOfInterest.month);
			LinkedListAddNumber(list, entry);
			AddMonthsToDate(dateOfInterest, 1d);
		}

		result = LinkedListNumbersToArray(list);
		FreeLinkedListNumbers(list);

		return result;
	}

	public static double GetAccrualAmountWithDates(double total, Date from, Date to, double yearOfInterest, double monthOfInterest){
		double unadjustedAmount, adjustment, days, daysToAdjust, n;
		Date adjustTo;
		FixedPoint15d valuePerDay, divisibleRemaining, divisibleTotal, amount;
		StringReference message;

		message = new StringReference();

		valuePerDay = CreateFixedPoint15d(13d, 2d);
		divisibleRemaining = CreateFixedPoint15d(13d, 2d);
		divisibleTotal = CreateFixedPoint15d(13d, 2d);
		amount = CreateFixedPoint15d(13d, 2d);

		days = DaysBetweenDates(from, to) + 1d;

		/* DIVIDE total BY days GIVING valuePerDay REMAINDER divisibleRemaining*/
		DivideFloored15d(valuePerDay, divisibleRemaining, Number15d(total), Number15d(days));

		Multiply15d(divisibleTotal, valuePerDay, Number15d(days));
		unadjustedAmount = GetUnadjustedAccrualAmountWithDates(divisibleTotal, from, to, yearOfInterest, monthOfInterest);

		if(!Equals15d(divisibleRemaining, Number15d(0d))){
			daysToAdjust = Round(ToNumber15d(divisibleRemaining)*100d);
			adjustTo = new Date();
			AssignDate(adjustTo, from);
			AddDaysToDate(adjustTo, daysToAdjust - 1d, message);

			adjustment = GetUnadjustedAccrualAmountWithDates(divisibleRemaining, from, adjustTo, yearOfInterest, monthOfInterest);

			delete(adjustTo);
		}else{
			adjustment = 0d;
		}

		Add15d(amount, Number15d(unadjustedAmount), Number15d(adjustment));

		n = ToNumber15d(amount);

		delete(valuePerDay);
		delete(divisibleRemaining);
		delete(divisibleTotal);
		delete(amount);

		return n;
	}

	public static double GetUnadjustedAccrualAmountWithDates(FixedPoint15d total, Date from, Date to, double yearOfInterest, double monthOfInterest){
		double days, daysInMonthOfInterest, n;
		Date lastDayInMonth, firstDateInMonth;
		double [] daysInMonth;
		FixedPoint15d valuePerDay, value, remainder;
		boolean success;

		value = CreateFixedPoint15d(13d, 2d);
		valuePerDay = CreateFixedPoint15d(13d, 2d);
		remainder = CreateFixedPoint15d(13d, 2d);

		days = DaysBetweenDates(from, to) + 1d;
		/* DIVIDE total BY days GIVING valuePerDay ON SIZE ERROR ...*/
		success = DivideFloored15d(valuePerDay, remainder, total, Number15d(days));

		if(success){
			daysInMonth = GetDaysInMonth(yearOfInterest);

			if(yearOfInterest < from.year){
				Assign15d(value, 0d);
			}else if(yearOfInterest == from.year && monthOfInterest < from.month){
				Assign15d(value, 0d);
			}else if(yearOfInterest > to.year){
				Assign15d(value, 0d);
			}else if(yearOfInterest == to.year && monthOfInterest > to.month){
				Assign15d(value, 0d);
			}else{
if(from.year == yearOfInterest && from.month == monthOfInterest && to.year == yearOfInterest && to.month == monthOfInterest){
					daysInMonthOfInterest = days;
				}else if(from.year == yearOfInterest && from.month == monthOfInterest){
					lastDayInMonth = CreateDate(yearOfInterest, monthOfInterest, daysInMonth[(int)(monthOfInterest)]);
					daysInMonthOfInterest = DaysBetweenDates(from, lastDayInMonth) + 1d;
				}else if(to.year == yearOfInterest && to.month == monthOfInterest){
					firstDateInMonth = CreateDate(yearOfInterest, monthOfInterest, 1d);
					daysInMonthOfInterest = DaysBetweenDates(firstDateInMonth, to) + 1d;
				}else{
					daysInMonthOfInterest = daysInMonth[(int)(monthOfInterest)];
				}

				/* MULTIPLY valuePerDay BY daysInMonthOfInterest GIVING value*/
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

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
