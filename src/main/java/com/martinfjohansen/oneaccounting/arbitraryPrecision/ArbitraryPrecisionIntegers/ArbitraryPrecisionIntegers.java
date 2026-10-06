package com.martinfjohansen.oneaccounting.arbitraryPrecision.ArbitraryPrecisionIntegers;

import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.arbitraryPrecision.FixedUnsignedIntegers.FixedUnsignedIntegers.*;
import static com.martinfjohansen.oneaccounting.arbitraryPrecision.UnsignedIntegers.UnsignedIntegers.*;

public class ArbitraryPrecisionIntegers{
	public static ArbitraryPrecisionInteger CreateArbitraryPrecisionInteger(double digits){
		ArbitraryPrecisionInteger x;

		x = new ArbitraryPrecisionInteger();
		x.sign = true;
		x.number = CreateUnsignedInteger(digits);

		return x;
	}

	public static void FreeArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		FreeUnsignedInteger(x.number);
		delete(x);
	}

	public static void ClearArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		x.sign = true;
		ClearUnsignedInteger(x.number);
	}

	public static void TrimArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		TrimUnsignedInteger(x.number);
	}

	public static char [] ToStringArbitraryPrecisionInteger(ArbitraryPrecisionInteger x){
		char [] str;
		char c;
		double i, digits, digit;

		if(x.number.digits.length > 0d){

			digits = DigitsUnsignedInteger(x.number);
			str = new char [(int)(1d + digits)];

			if(x.sign){
				str[0] = '+';
			}else{
				str[0] = '-';
			}

			for(i = 0d; i < digits; i = i + 1d){
				digit = DigitUnsignedInteger(x.number, i);

				c = DecimalDigitToCharacter(digit);

				str[(int)(1d + digits - i - 1d)] = c;
			}
		}else{
			str = new char [2];
			str[0] = '+';
			str[1] = '0';
		}

		return str;
	}

	public static ArbitraryPrecisionInteger CreateArbitraryPrecisionIntegerFromString(char [] str){
		ArbitraryPrecisionInteger x;
		char c;
		double i, digit, stringDigits, hasSign;

		hasSign = 0d;
		if(str.length > 0d){
			if(str[0] == '-' || str[0] == '+'){
				hasSign = 1d;
			}
		}

		x = CreateArbitraryPrecisionInteger(str.length - hasSign);
		stringDigits = str.length;

		if(str.length > 0d){
			x.sign = true;
			if(str[0] == '-'){
				x.sign = false;
			}else if(str[0] == '+'){
				x.sign = true;
			}
		}

		for(i = 0d; i < stringDigits - hasSign; i = i + 1d){
			c = str[(int)(stringDigits - i - 1d)];
			digit = CharacterToDecimalDigit(c);
			x.number.digits[(int)(i)] = digit;
		}

		return x;
	}

	public static void AddArbitraryPrecisionInteger(ArbitraryPrecisionInteger x, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		boolean as, bs;
		double comparisonResult;

		as = a.sign;
		bs = b.sign;

		if(as == bs){
			AddUnsignedInteger(x.number, a.number, b.number);
			x.sign = as;
		}else if(as == true){
			comparisonResult = CompareFixedUnsignedInteger(a.number, b.number);

			if(comparisonResult == 1d || comparisonResult == 0d){
				SubtractUnsignedInteger(x.number, a.number, b.number);
			}else{
				SubtractUnsignedInteger(x.number, b.number, a.number);
				x.sign = false;
			}
		}else{
			comparisonResult = CompareFixedUnsignedInteger(b.number, a.number);

			if(comparisonResult == 1d || comparisonResult == 0d){
				SubtractUnsignedInteger(x.number, b.number, a.number);
			}else{
				SubtractUnsignedInteger(x.number, a.number, b.number);
				x.sign = false;
			}
		}
	}

	public static void SubtractArbitraryPrecisionInteger(ArbitraryPrecisionInteger x, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		boolean as, bs;
		double comparisonResult;

		as = a.sign;
		bs = b.sign;

		if(as == bs){
			if(as == true){
				comparisonResult = CompareFixedUnsignedInteger(a.number, b.number);

				if(comparisonResult == 1d || comparisonResult == 0d){
					SubtractUnsignedInteger(x.number, a.number, b.number);
				}else{
					SubtractUnsignedInteger(x.number, b.number, a.number);
					x.sign = false;
				}
			}else{
				comparisonResult = CompareFixedUnsignedInteger(b.number, a.number);

				if(comparisonResult == 1d || comparisonResult == 0d){
					SubtractUnsignedInteger(x.number, b.number, a.number);
				}else{
					SubtractUnsignedInteger(x.number, a.number, b.number);
					x.sign = false;
				}
			}
		}else if(as == false){
			AddUnsignedInteger(x.number, a.number, b.number);
			x.sign = false;
		}else{
			AddUnsignedInteger(x.number, a.number, b.number);
			x.sign = true;
		}
	}

	public static void MultiplyArbitraryPrecisionInteger(ArbitraryPrecisionInteger x, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		MultiplyUnsignedInteger(x.number, a.number, b.number);
		if(a.sign != b.sign){
			x.sign = false;
		}
	}

	public static boolean DivideArbitraryPrecisionInteger(ArbitraryPrecisionInteger q, ArbitraryPrecisionInteger r, ArbitraryPrecisionInteger a, ArbitraryPrecisionInteger b){
		boolean success, rIsZero;
		double i;

		if(a.sign == b.sign){
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);

			if(success){
				q.sign = true;
				r.sign = true;
			}
		}else if(a.sign == false){
			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);

			if(success){
				q.sign = false;
				r.sign = true;
			}

			rIsZero = true;
			for(i = 0d; i < r.number.digits.length; i = i + 1d){
				if(r.number.digits[(int)(i)] != 0d){
					rIsZero = false;
				}
			}

			if(!rIsZero){
				AddUnsignedInteger(a.number, a.number, b.number);
				success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);
				SubtractUnsignedInteger(r.number, b.number, r.number);
				SubtractUnsignedInteger(a.number, a.number, b.number);
			}
		}else{
			AddUnsignedInteger(a.number, a.number, b.number);

			success = DivideUnsignedInteger(q.number, r.number, a.number, b.number);

			if(success){
				q.sign = false;
				r.sign = false;
			}
		}

		return success;
	}

	public static char [] AddArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr){
		ArbitraryPrecisionInteger a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		c = CreateArbitraryPrecisionInteger(0d);

		AddArbitraryPrecisionInteger(c, a, b);

		cStr = ToStringArbitraryPrecisionInteger(c);

		return cStr;
	}

	public static char [] SubtractArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr){
		ArbitraryPrecisionInteger a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		c = CreateArbitraryPrecisionInteger(0d);

		SubtractArbitraryPrecisionInteger(c, a, b);

		cStr = ToStringArbitraryPrecisionInteger(c);

		return cStr;
	}

	public static char [] MultiplyArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr){
		ArbitraryPrecisionInteger a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		c = CreateArbitraryPrecisionInteger(0d);

		MultiplyArbitraryPrecisionInteger(c, a, b);

		cStr = ToStringArbitraryPrecisionInteger(c);

		return cStr;
	}

	public static char [] DivideArbitraryPrecisionIntegerStrings(char [] aStr, char [] bStr, StringReference rStr){
		ArbitraryPrecisionInteger a, b, q, r;
		char [] qStr;

		a = CreateArbitraryPrecisionIntegerFromString(aStr);
		b = CreateArbitraryPrecisionIntegerFromString(bStr);
		q = CreateArbitraryPrecisionInteger(0d);
		r = CreateArbitraryPrecisionInteger(0d);

		DivideArbitraryPrecisionInteger(q, r, a, b);

		qStr = ToStringArbitraryPrecisionInteger(q);
		rStr.string = ToStringArbitraryPrecisionInteger(r);

		return qStr;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
