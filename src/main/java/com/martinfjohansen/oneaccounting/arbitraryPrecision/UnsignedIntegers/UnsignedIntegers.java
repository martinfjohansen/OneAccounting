package com.martinfjohansen.oneaccounting.arbitraryPrecision.UnsignedIntegers;

import com.martinfjohansen.oneaccounting.arbitraryPrecision.FixedUnsignedIntegers.UnsignedInteger;

import static com.martinfjohansen.oneaccounting.arbitraryPrecision.FixedUnsignedIntegers.FixedUnsignedIntegers.*;
import static java.lang.Math.max;

public class UnsignedIntegers{
	public static UnsignedInteger CreateUnsignedInteger(double digits){
		UnsignedInteger x;

		x = new UnsignedInteger();
		x.digits = new double [(int)(digits)];

		ClearUnsignedInteger(x);

		return x;
	}

	public static void FreeUnsignedInteger(UnsignedInteger x){
		delete(x.digits);
		delete(x);
	}

	public static void ClearUnsignedInteger(UnsignedInteger x){
		double i;

		for(i = 0d; i < DigitCapacityUnsignedInteger(x); i = i + 1d){
			x.digits[(int)(i)] = 0d;
		}
	}

	public static void TrimUnsignedInteger(UnsignedInteger x){
		double capacity, digits, newCapacity, i;
		double [] newDigits;

		capacity = DigitCapacityUnsignedInteger(x);
		digits = DigitsUnsignedInteger(x);

		if(capacity > digits){
			newCapacity = digits;
			newDigits = new double [(int)(newCapacity)];

			for(i = 0d; i < newCapacity; i = i + 1d){
				newDigits[(int)(i)] = x.digits[(int)(i)];
			}

			delete(x.digits);
			x.digits = newDigits;
		}
	}

	public static char [] ToStringUnsignedInteger(UnsignedInteger x){
		char [] str;
		char c;
		double i, digits, digit;

		digits = DigitsUnsignedInteger(x);
		str = new char [(int)(digits)];

		for(i = 0d; i < digits; i = i + 1d){
			digit = DigitUnsignedInteger(x, i);

			c = DecimalDigitToCharacter(digit);

			str[(int)(digits - i - 1d)] = c;
		}

		return str;
	}

	public static void AddUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		boolean overflow;
		double capacity, ads, bds;

		overflow = !AddFixedUnsignedInteger(x, a, b);

		if(overflow){
			delete(x.digits);

			ads = DigitsUnsignedInteger(a);
			bds = DigitsUnsignedInteger(b);
			capacity = max(ads, bds) + 1d;
			x.digits = new double [(int)(capacity)];

			AddFixedUnsignedInteger(x, a, b);
		}
	}

	public static boolean SubtractUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		double ads, xds;

		ads = DigitsUnsignedInteger(a);
		xds = DigitCapacityUnsignedInteger(x);

		if(xds < ads){
			delete(x.digits);
			x.digits = new double [(int)(ads)];
		}

		return SubtractFixedUnsignedInteger(x, a, b);
	}

	public static void MultiplyUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		boolean overflow;
		double capacity, ads, bds;

		overflow = !MultiplyFixedUnsignedInteger(x, a, b);

		if(overflow){
			delete(x.digits);

			ads = DigitsUnsignedInteger(a);
			bds = DigitsUnsignedInteger(b);
			capacity = ads + bds;
			x.digits = new double [(int)(capacity)];

			MultiplyFixedUnsignedInteger(x, a, b);
		}
	}

	public static boolean DivideUnsignedInteger(UnsignedInteger q, UnsignedInteger r, UnsignedInteger a, UnsignedInteger b){
		double capacity, ads, bds, qds, rds;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		qds = DigitCapacityUnsignedInteger(q);
		rds = DigitCapacityUnsignedInteger(r);

		if(qds < ads - bds + 1d){
			capacity = ads - bds + 1d;
			q.digits = new double [(int)(capacity)];
		}

		if(rds < bds){
			capacity = bds;
			r.digits = new double [(int)(capacity)];
		}

		return DivideFixedUnsignedInteger(q, r, a, b);
	}

	public static void ShiftLeftUnsignedInteger(UnsignedInteger x, double shifts){
		double xds, capacity, i;
		double [] oldDigits;

		xds = DigitsUnsignedInteger(x);
		capacity = DigitCapacityUnsignedInteger(x);

		if(xds + shifts > capacity){
			capacity = xds + shifts;
			oldDigits = x.digits;
			x.digits = new double [(int)(capacity)];
		}else{
			oldDigits = x.digits;
		}

		for(i = 0d; i < oldDigits.length - shifts; i = i + 1d){
			x.digits[(int)(oldDigits.length - i - 1d)] = oldDigits[(int)(oldDigits.length - shifts - i - 1d)];
		}

		for(; i < oldDigits.length; i = i + 1d){
			x.digits[(int)(oldDigits.length - i - 1d)] = 0d;
		}
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
