package com.martinfjohansen.oneaccounting.arbitraryPrecision.FixedUnsignedIntegers;

import static com.martinfjohansen.oneaccounting.arbitraryPrecision.UnsignedIntegers.UnsignedIntegers.ClearUnsignedInteger;
import static com.martinfjohansen.oneaccounting.arbitraryPrecision.UnsignedIntegers.UnsignedIntegers.CreateUnsignedInteger;
import static java.lang.Math.max;

public class FixedUnsignedIntegers{
	public static char DecimalDigitToCharacter(double digit){
		char c;
		if(digit == 1d){
			c = '1';
		}else if(digit == 2d){
			c = '2';
		}else if(digit == 3d){
			c = '3';
		}else if(digit == 4d){
			c = '4';
		}else if(digit == 5d){
			c = '5';
		}else if(digit == 6d){
			c = '6';
		}else if(digit == 7d){
			c = '7';
		}else if(digit == 8d){
			c = '8';
		}else if(digit == 9d){
			c = '9';
		}else{
			c = '0';
		}
		return c;
	}

	public static double DigitUnsignedInteger(UnsignedInteger x, double i){
		return x.digits[(int)(i)];
	}

	public static double DigitsUnsignedInteger(UnsignedInteger x){
		double i, capacity, digits;
		boolean done;

		capacity = DigitCapacityUnsignedInteger(x);
		done = false;
		digits = capacity;

		for(i = capacity - 1d; i >= 0d && !done; i = i - 1d){
			if(DigitUnsignedInteger(x, i) == 0d){
				digits = digits - 1d;
			}else{
				done = true;
			}
		}

		if(digits == 0d){
			digits = 1d;
		}

		return digits;
	}

	public static char [] ToStringFixedUnsignedInteger(UnsignedInteger x){
		char [] str;
		char c;
		double i, digits, digit;

		digits = DigitCapacityUnsignedInteger(x);
		str = new char [(int)(digits)];

		for(i = 0d; i < digits; i = i + 1d){
			digit = DigitUnsignedInteger(x, i);

			c = DecimalDigitToCharacter(digit);

			str[(int)(digits - i - 1d)] = c;
		}

		return str;
	}

	public static double DigitCapacityUnsignedInteger(UnsignedInteger x){
		return x.digits.length;
	}

	public static UnsignedInteger CreateFixedUnsignedIntegerFromString(double digits, char [] str){
		UnsignedInteger x;
		char c;
		double i, digit, stringDigits;

		x = CreateUnsignedInteger(digits);
		stringDigits = str.length;

		for(i = 0d; i < stringDigits; i = i + 1d){
			c = str[(int)(stringDigits - i - 1d)];

			digit = CharacterToDecimalDigit(c);

			x.digits[(int)(i)] = digit;
		}

		return x;
	}

	public static double CharacterToDecimalDigit(char c){
		double digit;

		if(c == '1'){
			digit = 1d;
		}else if(c == '2'){
			digit = 2d;
		}else if(c == '3'){
			digit = 3d;
		}else if(c == '4'){
			digit = 4d;
		}else if(c == '5'){
			digit = 5d;
		}else if(c == '6'){
			digit = 6d;
		}else if(c == '7'){
			digit = 7d;
		}else if(c == '8'){
			digit = 8d;
		}else if(c == '9'){
			digit = 9d;
		}else{
			digit = 0d;
		}

		return digit;
	}

	public static boolean AddFixedUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		return AddFixedUnsignedIntegerWithShift(x, a, b, 0d, 0d);
	}

	public static boolean AddFixedUnsignedIntegerWithShift(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b, double aShift, double bShift){
		double ads, bds, xds, i, carry, remainder, ad, bd, apos, bpos;
		boolean overflow;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		xds = DigitCapacityUnsignedInteger(x);

		if(xds >= ads && xds >= bds){
			carry = 0d;

			for(i = 0d; i < xds; i = i + 1d){
				apos = i - aShift;
				if(apos >= 0d && apos < ads){
					ad = DigitUnsignedInteger(a, apos);
				}else{
					ad = 0d;
				}

				bpos = i - bShift;
				if(bpos >= 0d && bpos < bds){
					bd = DigitUnsignedInteger(b, bpos);
				}else{
					bd = 0d;
				}

				remainder = ad + bd + carry;

				if(remainder >= 10d){
					carry = 1d;
					remainder = remainder - 10d;
				}else{
					carry = 0d;
				}

				x.digits[(int)(i)] = remainder;
			}

			if(carry == 1d){
				overflow = true;
			}else{
				overflow = false;
			}
		}else{
			overflow = true;
		}

		return !overflow;
	}

	public static boolean SubtractFixedUnsignedInteger(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b){
		return SubtractFixedUnsignedIntegerWithShift(x, a, b, 0d, 0d);
	}

	public static boolean SubtractFixedUnsignedIntegerWithShift(UnsignedInteger x, UnsignedInteger a, UnsignedInteger b, double aShift, double bShift){
		double ads, bds, xds, i, borrow, remainder, ad, bd, apos, bpos;
		boolean underflow, overflow;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		xds = DigitCapacityUnsignedInteger(x);

		borrow = 0d;
		overflow = false;

		for(i = 0d; i < max(max(ads, bds), xds) && !overflow; i = i + 1d){
			apos = i - aShift;
			if(apos >= 0d && apos < ads){
				ad = DigitUnsignedInteger(a, apos);
			}else{
				ad = 0d;
			}

			bpos = i - bShift;
			if(bpos >= 0d && bpos < bds){
				bd = DigitUnsignedInteger(b, bpos);
			}else{
				bd = 0d;
			}

			remainder = ad - bd - borrow;

			if(remainder < 0d){
				borrow = 1d;
				remainder = remainder + 10d;
			}else{
				borrow = 0d;
			}

			if(remainder != 0d){
				if(i < xds){
				}else{
					overflow = true;
				}
			}

			if(i < xds){
				x.digits[(int)(i)] = remainder;
			}
		}

		if(borrow == 1d){
			underflow = true;
		}else{
			underflow = false;
		}

		return !underflow && !overflow;
	}

	public static boolean MultiplyFixedUnsignedInteger(UnsignedInteger c, UnsignedInteger a, UnsignedInteger b){
		double i, j, ads, ad;
		boolean success;

		success = true;

		ClearUnsignedInteger(c);

		ads = DigitsUnsignedInteger(a);
		for(i = 0d; i < ads; i = i + 1d){
			ad = DigitUnsignedInteger(a, i);

			for(j = 0d; j < ad; j = j + 1d){
				success = success && AddFixedUnsignedIntegerWithShift(c, c, b, 0d, i);
			}
		}

		if(c.digits.length == 0d){
			success = false;
		}

		return success;
	}

	public static double CompareFixedUnsignedInteger(UnsignedInteger a, UnsignedInteger b){
		double comparizonResult, ads, bds, i, ad, bd;
		boolean done;

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);

		comparizonResult = 0d;

		if(ads > bds){
			comparizonResult = 1d;
		}else if(ads < bds){
			comparizonResult = -1d;
		}else{
			done = false;
			for(i = ads - 1d; i >= 0d && !done; i = i - 1d){
				ad = DigitUnsignedInteger(a, i);
				bd = DigitUnsignedInteger(b, i);

				if(ad > bd){
					comparizonResult = 1d;
					done = true;
				}else if(ad < bd){
					comparizonResult = -1d;
					done = true;
				}
			}
		}

		return comparizonResult;
	}

	public static double CompareFixedUnsignedIntegerWithShift(UnsignedInteger a, UnsignedInteger b, double aShift, double bShift){
		double comparizonResult, ads, bds, i, ad, bd, apos, bpos;
		boolean done;

		ads = DigitsUnsignedInteger(a);
		if(ads > 0d){
			ads = ads + aShift;
		}
		bds = DigitsUnsignedInteger(b);
		if(bds > 0d){
			bds = bds + bShift;
		}

		comparizonResult = 0d;

		if(ads > bds){
			comparizonResult = 1d;
		}else if(ads < bds){
			comparizonResult = -1d;
		}else{
			done = false;
			for(i = ads - 1d; i >= 0d && !done; i = i - 1d){
				apos = i - aShift;
				if(apos >= 0d && apos < ads){
					ad = DigitUnsignedInteger(a, apos);
				}else{
					ad = 0d;
				}

				bpos = i - bShift;
				if(bpos >= 0d && bpos < bds){
					bd = DigitUnsignedInteger(b, bpos);
				}else{
					bd = 0d;
				}

				if(ad > bd){
					comparizonResult = 1d;
					done = true;
				}else if(ad < bd){
					comparizonResult = -1d;
					done = true;
				}
			}
		}

		return comparizonResult;
	}

	public static boolean DivideFixedUnsignedInteger(UnsignedInteger q, UnsignedInteger r, UnsignedInteger a, UnsignedInteger b){
		double i, j, ads, bds, qd, comparisonResult, qdsCapacity;
		boolean success, done;

		success = true;

		ClearUnsignedInteger(q);
		ClearUnsignedInteger(r);

		ads = DigitsUnsignedInteger(a);
		bds = DigitsUnsignedInteger(b);
		qdsCapacity = DigitCapacityUnsignedInteger(q);

		/* bds == 0 -> b.digits[0] != 0*/
		if(bds != 1d || b.digits[0] != 0d){
			if(ads >= bds){
				for(i = ads - bds; i >= 0d && success; i = i - 1d){
					qd = 0d;
					done = false;
					for(j = 0d; j <= 9d && !done; j = j + 1d){
						comparisonResult = CompareFixedUnsignedIntegerWithShift(a, b, 0d, i);
						if(comparisonResult == 1d || comparisonResult == 0d){
							SubtractFixedUnsignedIntegerWithShift(a, a, b, 0d, i);
							qd = qd + 1d;
						}else{
							done = true;
						}
					}
					if(i < qdsCapacity){
						q.digits[(int)(i)] = qd;
					}else{
						success = false;
					}
				}
				if(success){
					/* Put the rest in the remainder.*/
					success = AddFixedUnsignedInteger(r, r, a);

					if(success){
						/* Reconstruct a.*/
						MultiplyFixedUnsignedInteger(a, q, b);
						AddFixedUnsignedInteger(a, a, r);
					}
				}
			}else{
				/* Put everything in the remainder.*/
				AddFixedUnsignedInteger(r, r, a);
			}
		}else{
			/* division by zero*/
			success = false;
		}

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
