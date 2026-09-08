package com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d;

import static java.lang.Math.*;

import com.martinfjohansen.oneaccounting.references.references.CharacterReference;
import com.martinfjohansen.oneaccounting.references.references.*;

import static com.martinfjohansen.oneaccounting.math.math.math.*;

import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.*;

import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.*;

public class FixedPointArithmetic15d{
	public static FixedPoint15d CreateFixedPoint15d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
		FixedPoint15d fp;

		fp = new FixedPoint15d();
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
		fp.number = 0d;

		return fp;
	}

	public static double ToNumber15d(FixedPoint15d n){
		return n.number;
	}

	public static FixedPoint15d Number15d(double number){
		FixedPoint15d fp;

		fp = new FixedPoint15d();
		fp.digitsBeforeDecimalPoint = 7d;
		fp.digitsAfterDecimalPoint = 7d;
		fp.number = number;

		return fp;
	}

	public static boolean Assign15d(FixedPoint15d fp, double number){
		boolean success;

		success = !WillOverflow15d(fp, number);
		success = success && FixedPointIsValid15d(fp);

		if(success){
			fp.number = number;
			fp.number = RoundToDigits(fp.number, fp.digitsAfterDecimalPoint);
		}

		return success;
	}

	public static boolean Assign15dFloor(FixedPoint15d fp, double number){
		boolean success;

		success = !WillOverflow15d(fp, number);
		success = success && FixedPointIsValid15d(fp);

		if(success){
			fp.number = number;
			fp.number = FloorToDigits(fp.number, fp.digitsAfterDecimalPoint);
		}

		return success;
	}

	public static boolean FixedPointIsValid15d(FixedPoint15d fp){
		boolean valid;

		if(IsInteger(fp.digitsAfterDecimalPoint) && IsInteger(fp.digitsBeforeDecimalPoint)){
			if(fp.digitsBeforeDecimalPoint >= 0d && fp.digitsBeforeDecimalPoint <= 15d){
				if(fp.digitsAfterDecimalPoint >= 0d && fp.digitsAfterDecimalPoint <= 15d){
					if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint <= 15d){
						if(fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint > 0d){
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

	public static boolean WillOverflow15d(FixedPoint15d fp, double number){
		boolean overflow;

		if(abs(number) < pow(10d, fp.digitsBeforeDecimalPoint)){
			overflow = false;
		}else{
			overflow = true;
		}

		return overflow;
	}

	public static double FloorToDigits(double value, double digits){
		return floor(value*pow(10d, digits))/pow(10d, digits);
	}

	public static char [] ToString15d(FixedPoint15d fp){
		char [] string;
		double digits;
		double digitPosition;
		double i, d, decimal;
		CharacterReference characterReference;

		string = new char [(int)(1d + fp.digitsBeforeDecimalPoint + 1d + fp.digitsAfterDecimalPoint)];

		decimal = fp.number*pow(10d, fp.digitsAfterDecimalPoint);

		if(decimal < 0d){
			decimal = -decimal;
			string[0] = '-';
		}else{
			string[0] = '+';
		}

		decimal = Round(decimal);

		characterReference = new CharacterReference();

		digits = fp.digitsBeforeDecimalPoint + fp.digitsAfterDecimalPoint;
		digitPosition = 1d;

		for(i = 0d; i < digits; i = i + 1d){
			if(i == fp.digitsBeforeDecimalPoint){
				string[(int)(digitPosition)] = '.';

				digitPosition = digitPosition + 1d;
			}

			d = floor(decimal/pow(10d, digits - i - 1d));
			d = d%10d;

			GetSingleDigitCharacterFromNumberWithCheck(d, 10d, characterReference);
			string[(int)(digitPosition)] = characterReference.characterValue;

			digitPosition = digitPosition + 1d;
		}

		delete(characterReference);

		return string;
	}

	public static boolean Add15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d c){
		return Assign15d(a, b.number + c.number);
	}

	public static boolean Subtract15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d c){
		return Assign15d(a, b.number - c.number);
	}

	public static boolean Multiply15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d c){
		return Assign15d(a, b.number*c.number);
	}

	public static boolean DivideFloored15d(FixedPoint15d q, FixedPoint15d r, FixedPoint15d a, FixedPoint15d b){
		boolean success;
		double x, xDivisor, xDividend;
		FixedPoint15d t;

		t = Copy15d(r);

		if(b.number != 0d){
			xDivisor = Round(a.number*pow(10d, q.digitsAfterDecimalPoint)*pow(10d, q.digitsAfterDecimalPoint));
			xDividend = Round(b.number*pow(10d, q.digitsAfterDecimalPoint));
			x = floor(xDivisor/xDividend);
			x = x/pow(10d, q.digitsAfterDecimalPoint);
			success = Assign15d(q, x);
			Multiply15d(t, q, b);
			Subtract15d(r, a, t);
		}else{
			success = false;
		}

		delete(t);

		return success;
	}

	public static FixedPoint15d Copy15d(FixedPoint15d r){
		FixedPoint15d t;

		t = CreateFixedPoint15d(r.digitsBeforeDecimalPoint, r.digitsAfterDecimalPoint);
		t.number = r.number;

		return t;
	}

	public static void Negate15d(FixedPoint15d a){
		a.number = -a.number;
	}

	public static void Positive15d(FixedPoint15d a){
		a.number = +a.number;
	}

	public static boolean Factorial15d(FixedPoint15d x){
		boolean success;

		if(x.number >= 0d){
			success = Assign15d(x, Factorial(x.number));
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Round15d(FixedPoint15d x){
		return Assign15d(x, Round(x.number));
	}

	public static boolean BankersRound15d(FixedPoint15d x){
		return Assign15d(x, BankersRound(x.number));
	}

	public static boolean Ceil15d(FixedPoint15d x){
		return Assign15d(x, Ceil(x.number));
	}

	public static boolean Floor15d(FixedPoint15d x){
		return Assign15d(x, floor(x.number));
	}

	public static void Truncate15d(FixedPoint15d x){
		x.number = Truncate(x.number);
	}

	public static void Absolute15d(FixedPoint15d x){
		x.number = abs(x.number);
	}

	public static boolean Logarithm15d(FixedPoint15d x){
		boolean success;

		if(x.number > 0d){
			success = Assign15d(x, Logarithm(x.number));
		}else{
			success = false;
		}

		return success;
	}

	public static boolean NaturalLogarithm15d(FixedPoint15d x){
		boolean success;

		if(x.number > 0d){
			success = Assign15d(x, NaturalLogarithm(x.number));
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Sin15d(FixedPoint15d x){
		return Assign15d(x, Sin(x.number));
	}

	public static boolean Cos15d(FixedPoint15d x){
		return Assign15d(x, Cos(x.number));
	}

	public static boolean Tan15d(FixedPoint15d x){
		return Assign15d(x, Tan(x.number));
	}

	public static boolean Asin15d(FixedPoint15d x){
		boolean success;

		if(x.number >= -1d && x.number <= 1d){
			success = Assign15d(x, Asin(x.number));
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Acos15d(FixedPoint15d x){
		boolean success;

		if(x.number >= -1d && x.number <= 1d){
			success = Assign15d(x, Acos(x.number));
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Atan15d(FixedPoint15d x){
		return Assign15d(x, Atan(x.number));
	}

	public static boolean Atan2_15d(FixedPoint15d a, FixedPoint15d y, FixedPoint15d x){
		return Assign15d(a, Atan2(y.number, x.number));
	}

	public static boolean Squareroot15d(FixedPoint15d x){
		boolean success;

		if(x.number >= 0d){
			success = Assign15d(x, sqrt(x.number));
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Exp15d(FixedPoint15d x){
		return Assign15d(x, Exp(x.number));
	}

	public static boolean DivisibleBy15d(FixedPoint15d a, FixedPoint15d b){
		return ((a.number%b.number) == 0d);
	}

	public static boolean Combinations15d(FixedPoint15d x, FixedPoint15d n, FixedPoint15d k){
		boolean success;

		if(IsInteger(n.number) && IsInteger(k.number)){
			if(n.number >= 1d && k.number >= 0d && n.number >= k.number){
				success = Assign15d(x, Combinations(n.number, k.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Permutations15d(FixedPoint15d x, FixedPoint15d n, FixedPoint15d k){
		boolean success;

		if(IsInteger(n.number) && IsInteger(k.number)){
			if(n.number >= 1d && k.number >= 0d && n.number >= k.number){
				success = Assign15d(x, Permutations(n.number, k.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean Equals15d(FixedPoint15d a, FixedPoint15d b){
		double p, an, bn;
		boolean equals;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		p = max(a.digitsAfterDecimalPoint, b.digitsAfterDecimalPoint);

		equals = EpsilonCompare(an, bn, pow(10d, -p));

		return equals;
	}

	public static boolean GreaterThan15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		return an > bn;
	}

	public static boolean LessThan15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		return an < bn;
	}

	public static boolean GreaterThanOrEqual15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;
		boolean equal;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		equal = Equals15d(a, b);

		return an > bn || equal;
	}

	public static boolean LessThanOrEqual15d(FixedPoint15d a, FixedPoint15d b){
		double an, bn;
		boolean equal;

		an = ToNumber15d(a);
		bn = ToNumber15d(b);

		equal = Equals15d(a, b);

		return an < bn || equal;
	}

	public static boolean EpsilonCompare15d(FixedPoint15d a, FixedPoint15d b, FixedPoint15d epsilon){
		return EpsilonCompare(a.number, b.number, epsilon.number);
	}

	public static boolean GreatestCommonDivisor15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		boolean success;

		if(IsInteger(a.number) && IsInteger(b.number)){
			if(a.number >= 0d && b.number >= 0d){
				success = Assign15d(x, GreatestCommonDivisor(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean GCDWithSubtraction15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		boolean success;

		if(IsInteger(a.number) && IsInteger(b.number)){
			if(a.number >= 0d && b.number >= 0d){
				success = Assign15d(x, GCDWithSubtraction(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean IsInteger15d(FixedPoint15d a){
		return IsInteger(a.number);
	}

	public static boolean LeastCommonMultiple15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		boolean success;

		if(IsInteger(a.number) && IsInteger(b.number)){
			if(a.number != 0d && b.number != 0d){
				success = Assign15d(x, LeastCommonMultiple(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static double Sign15d(FixedPoint15d a){
		return Sign(a.number);
	}

	public static boolean Max15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		return Assign15d(x, Max(a.number, b.number));
	}

	public static boolean Min15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		return Assign15d(x, Min(a.number, b.number));
	}

	public static boolean Power15d(FixedPoint15d x, FixedPoint15d a, FixedPoint15d b){
		boolean success;

		if(a.number != 0d || b.number != 0d){
			if(!(a.number < 0d && !IsInteger(b.number))){
				success = Assign15d(x, Power(a.number, b.number));
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static char [] FormatToString15d(FixedPoint15d fp, double digitsAfter){
		char [] result;

		result = FormatToStringWithSymbols15d(fp, digitsAfter, "".toCharArray(), ".".toCharArray());

		return result;
	}

	public static char [] FormatToStringWithSymbols15d(FixedPoint15d fp, double digitsAfter, char [] thousandsSeparator, char [] decimalPoint){
		char [] string;
		double i, j, p, d, t, sign, extra, decimal, digits, digitsBefore, thousandsChars, thousandsTimes, decimalPointChars;
		CharacterReference characterReference;

		characterReference = new CharacterReference();

		decimal = Round(fp.number*pow(10d, digitsAfter));

		sign = 0d;
		if(decimal < 0d){
			sign = 1d;
			decimal = -decimal;
		}

		if(decimal != 0d){
			digits = floor(log10(decimal) + 1d);
		}else{
			digits = 1d;
		}
		digitsBefore = digits - digitsAfter;

		if(digitsBefore <= 0d){
			digitsBefore = 0d;
			thousandsTimes = 0d;
			digits = digitsAfter + 1d;
		}else{
			thousandsTimes = floor((digitsBefore - 1d)/3d);
		}
		thousandsChars = thousandsTimes*thousandsSeparator.length;

		if(digitsAfter == 0d){
			decimalPointChars = 0d;
		}else{
			decimalPointChars = decimalPoint.length;
		}

		string = new char [(int)(sign + digits + thousandsChars + decimalPointChars)];
		p = 0d;

		if(sign > 0d){
			string[(int)(p)] = '-';
			p = p + 1d;
		}

		for(i = 0d; i < digits; i = i + 1d){
			if(i == digitsBefore){
				if(i == 0d){
					string[(int)(p)] = '0';
					p = p + 1d;
					digits = digits - 1d;
				}

				for(j = 0d; j < decimalPoint.length; j = j + 1d){
					string[(int)(p)] = decimalPoint[(int)(j)];
					p = p + 1d;
				}
			}

			if(i < digitsBefore){
				if((digitsBefore - i)%3d == 0d && i != 0d){
					for(j = 0d; j < thousandsSeparator.length; j = j + 1d){
						string[(int)(p)] = thousandsSeparator[(int)(j)];
						p = p + 1d;
					}
				}
			}

			d = floor(decimal/pow(10d, digits - i - 1d));
			d = d%10d;

			GetSingleDigitCharacterFromNumberWithCheck(d, 10d, characterReference);
			string[(int)(p)] = characterReference.characterValue;

			p = p + 1d;
		}

		/* System.out.println(new String(string));*/
		return string;
	}

	public static char [] NumberToHumanReadable(double n, double digitsAfter, char [] thousandsSeparator, char [] decimalPoint){
		char [] str;
		char u;
		double d, p3;

		if(abs(n) < 1d){
			str = CreateStringDecimalFromNumber(n);
		}else{
			d = log10(n);

			p3 = min(floor(d/3d), 8d);

			if(p3 == 0d){
				u = 'B';
			}else if(p3 == 1d){
				u = 'K';
			}else if(p3 == 2d){
				u = 'M';
			}else if(p3 == 3d){
				u = 'G';
			}else if(p3 == 4d){
				u = 'T';
			}else if(p3 == 5d){
				u = 'P';
			}else if(p3 == 6d){
				u = 'E';
			}else if(p3 == 7d){
				u = 'Z';
			}else{
				u = 'Y';
			}

			if(p3 > 1d){
				n = n/pow(10d, p3*3d);
			}

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

			if(p3 > 1d){
				str = strAppendCharacter(str, u);
			}
		}

		return str;
	}

	public static char [] NumberToHumanReadableBinaryPrefix(double n, double digitsAfter, char [] thousandsSeparator, char [] decimalPoint){
		char [] str;
		char [] u;
		double d, p3;

		if(abs(n) < 1d){
			str = CreateStringDecimalFromNumber(n);
		}else{
			d = floor(log(n)/log(2d)) + 1d;

			p3 = min(floor(d/10d), 8d);

			if(p3 == 0d){
				u = "B".toCharArray();
			}else if(p3 == 1d){
				u = "Ki".toCharArray();
			}else if(p3 == 2d){
				u = "Mi".toCharArray();
			}else if(p3 == 3d){
				u = "Gi".toCharArray();
			}else if(p3 == 4d){
				u = "Ti".toCharArray();
			}else if(p3 == 5d){
				u = "Pi".toCharArray();
			}else if(p3 == 6d){
				u = "Ei".toCharArray();
			}else if(p3 == 7d){
				u = "Zi".toCharArray();
			}else{
				u = "Yi".toCharArray();
			}

			if(p3 > 1d){
				n = n/pow(2d, p3*10d);
			}

			str = FormatToStringWithSymbols15d(Number15d(n), digitsAfter, thousandsSeparator, decimalPoint);

			if(p3 > 1d){
				str = strAppendString(str, u);
			}
		}

		return str;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
