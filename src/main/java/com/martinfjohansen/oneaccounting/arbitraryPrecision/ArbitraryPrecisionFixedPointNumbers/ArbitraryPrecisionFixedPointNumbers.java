package com.martinfjohansen.oneaccounting.arbitraryPrecision.ArbitraryPrecisionFixedPointNumbers;

import com.martinfjohansen.oneaccounting.arbitraryPrecision.FixedUnsignedIntegers.UnsignedInteger;

import static com.martinfjohansen.oneaccounting.arbitraryPrecision.ArbitraryPrecisionIntegers.ArbitraryPrecisionIntegers.*;
import static com.martinfjohansen.oneaccounting.arbitraryPrecision.FixedUnsignedIntegers.FixedUnsignedIntegers.*;
import static com.martinfjohansen.oneaccounting.arbitraryPrecision.UnsignedIntegers.UnsignedIntegers.*;
import static java.lang.Math.max;

public class ArbitraryPrecisionFixedPointNumbers{
	public static ArbitraryPrecisionFixedPointNumber CreateArbitraryPrecisionFixedPointNumber(double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber x;

		x = new ArbitraryPrecisionFixedPointNumber();
		x.baseNumber = CreateArbitraryPrecisionInteger(digitsBeforePoint + digitsAfterPoint);
		x.pointPosition = digitsAfterPoint;

		return x;
	}

	public static void FreeArbitraryPrecisionFixedPointNumber(ArbitraryPrecisionFixedPointNumber x){
		FreeArbitraryPrecisionInteger(x.baseNumber);
		delete(x);
	}

	public static boolean AddArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint;
		boolean success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		digitsBeforePoint = max(aDigitsBeforePoint, bDigitsBeforePoint);
		digitsAfterPoint = max(aDigitsAfterPoint, bDigitsAfterPoint);

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint);
		ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber);

		success = AssignArbitraryPrecisionFixedPoint(x, x1);

		return success;
	}

	public static boolean AssignArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a){
		boolean success, isPointFive, zeroOverflow;
		double aDigitsBeforePoint, aDigitsAfterPoint, xDigitsBeforePoint, xDigitsAfterPoint, i, digit;
		UnsignedInteger epsilon;

		xDigitsBeforePoint = GetDigitsBeforePoint(x);
		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		xDigitsAfterPoint = GetDigitsAfterPoint(x);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		zeroOverflow = true;
		if(xDigitsBeforePoint < aDigitsBeforePoint){
			for(i = 0d; i < aDigitsBeforePoint - xDigitsBeforePoint; i = i + 1d){
				if(DigitUnsignedInteger(a.baseNumber.number, aDigitsBeforePoint + aDigitsAfterPoint - i - 1d) != 0d){
					zeroOverflow = false;
				}
			}
		}

		if(zeroOverflow){
			/* Assign before point.*/
			for(i = 0d; i < xDigitsBeforePoint; i = i + 1d){
				if(i >= aDigitsBeforePoint){
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint + i)] = 0d;
				}else{
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint + i)] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint + i);
				}
			}

			/* Assign after point:*/
			for(i = 0d; i < xDigitsAfterPoint; i = i + 1d){
				if(aDigitsAfterPoint - i - 1d < 0d){
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint - i - 1d)] = 0d;
				}else{
					x.baseNumber.number.digits[(int)(xDigitsAfterPoint - i - 1d)] = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - i - 1d);
				}
			}

			/* Assign sign.*/
			x.baseNumber.sign = a.baseNumber.sign;

			/* Round if necessary.*/
			if(aDigitsAfterPoint > xDigitsAfterPoint){
				if(x.baseNumber.sign == true){
					digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1d);

					if(digit >= 5d){
						/* Make epsilon.*/
						epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint);
						epsilon.digits[0] = 1d;
						success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon);
						FreeUnsignedInteger(epsilon);
					}else{
						success = true;
					}
				}else{
					digit = DigitUnsignedInteger(a.baseNumber.number, aDigitsAfterPoint - xDigitsAfterPoint - 1d);

					isPointFive = true;
					if(digit == 5d){
						for(i = aDigitsAfterPoint - xDigitsAfterPoint - 2d; i >= 0d; i = i - 1d){
							if(DigitUnsignedInteger(a.baseNumber.number, i) != 0d){
								isPointFive = false;
							}
						}
					}else{
						isPointFive = false;
					}

					if(digit <= 4d || isPointFive){
						success = true;
					}else{
						epsilon = CreateUnsignedInteger(xDigitsBeforePoint + xDigitsAfterPoint);
						epsilon.digits[0] = 1d;
						success = AddFixedUnsignedInteger(x.baseNumber.number, x.baseNumber.number, epsilon);
						FreeUnsignedInteger(epsilon);
					}
				}
			}else{
				success = true;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static double GetDigitsBeforePoint(ArbitraryPrecisionFixedPointNumber a){
		double sum;
		double digitsBeforePoint, digitsAfterPoint;

		digitsAfterPoint = GetDigitsAfterPoint(a);
		sum = DigitCapacityUnsignedInteger(a.baseNumber.number);
		digitsBeforePoint = sum - digitsAfterPoint;

		return digitsBeforePoint;
	}

	public static double GetDigitsAfterPoint(ArbitraryPrecisionFixedPointNumber a){
		return a.pointPosition;
	}

	public static char [] ToStringArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x){
		char [] str;
		char c;
		double i, digits, digit, point;

		if(x.baseNumber.number.digits.length > 0d){

			digits = GetDigitsBeforePoint(x) + GetDigitsAfterPoint(x);
			str = new char [(int)(1d + GetDigitsBeforePoint(x) + 1d + GetDigitsAfterPoint(x))];

			if(x.baseNumber.sign){
				str[0] = '+';
			}else{
				str[0] = '-';
			}

			point = 1d;

			for(i = 0d; i < digits; i = i + 1d){
				digit = DigitUnsignedInteger(x.baseNumber.number, i);

				if(i == x.pointPosition){
					str[(int)(1d + digits - i - 1d + point)] = '.';
					point = 0d;
				}

				c = DecimalDigitToCharacter(digit);

				str[(int)(1d + digits - i - 1d + point)] = c;
			}
		}else{
			str = new char [3];
			str[0] = '+';
			str[1] = '0';
			str[2] = '.';
		}

		return str;
	}

	public static ArbitraryPrecisionFixedPointNumber CreateArbitraryPrecisionFixedPointFromString(double digitsBeforePoint, double digitsAfterPoint, char [] str){
		ArbitraryPrecisionFixedPointNumber x;
		char c;
		double i, digit, stringDigits, hasSign, pointPosition, hasPoint, point;

		x = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		hasSign = 0d;
		if(str.length > 0d){
			if(str[0] == '-' || str[0] == '+'){
				hasSign = 1d;
			}
		}

		pointPosition = str.length;
		hasPoint = 0d;
		for(i = 0d; i < str.length && hasPoint == 0d; i = i + 1d){
			if(str[(int)(str.length - i - 1d)] == '.'){
				pointPosition = i;
				hasPoint = 1d;
			}
		}
		stringDigits = str.length;

		if(str.length > 0d){
			x.baseNumber.sign = true;
			if(str[0] == '-'){
				x.baseNumber.sign = false;
			}else if(str[0] == '+'){
				x.baseNumber.sign = true;
			}
		}

		point = 0d;
		for(i = 0d; i < stringDigits - hasSign - hasPoint; i = i + 1d){
			if(i == pointPosition){
				point = 1d;
			}
			c = str[(int)(stringDigits - point - i - 1d)];
			digit = CharacterToDecimalDigit(c);
			x.baseNumber.number.digits[(int)(i)] = digit;
		}

		return x;
	}

	public static boolean SubtractArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint;
		boolean success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		digitsBeforePoint = max(aDigitsBeforePoint, bDigitsBeforePoint);
		digitsAfterPoint = max(aDigitsAfterPoint, bDigitsAfterPoint);

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint);
		ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint);

		SubtractArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, x2.baseNumber);

		success = AssignArbitraryPrecisionFixedPoint(x, x1);

		return success;
	}

	public static boolean MultiplyArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber x, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2, t;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint;
		boolean success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint;
		digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint;

		x1 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, digitsAfterPoint - aDigitsAfterPoint);
		ShiftLeftUnsignedInteger(x2.baseNumber.number, digitsAfterPoint - bDigitsAfterPoint);

		t = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint, 2d*digitsAfterPoint);
		MultiplyArbitraryPrecisionInteger(t.baseNumber, x1.baseNumber, x2.baseNumber);

		success = AssignArbitraryPrecisionFixedPoint(x, t);

		return success;
	}

	public static boolean DivideArbitraryPrecisionFixedPoint(ArbitraryPrecisionFixedPointNumber q, ArbitraryPrecisionFixedPointNumber a, ArbitraryPrecisionFixedPointNumber b){
		ArbitraryPrecisionFixedPointNumber x1, x2, qx, rx;
		double aDigitsBeforePoint, aDigitsAfterPoint, bDigitsBeforePoint, bDigitsAfterPoint, digitsBeforePoint, digitsAfterPoint, qDigitsBeforePoint, qDigitsAfterPoint;
		boolean success;

		aDigitsBeforePoint = GetDigitsBeforePoint(a);
		aDigitsAfterPoint = GetDigitsAfterPoint(a);

		bDigitsBeforePoint = GetDigitsBeforePoint(b);
		bDigitsAfterPoint = GetDigitsAfterPoint(b);

		qDigitsAfterPoint = GetDigitsAfterPoint(q);

		digitsBeforePoint = aDigitsBeforePoint + bDigitsBeforePoint;
		digitsAfterPoint = aDigitsAfterPoint + bDigitsAfterPoint;

		x1 = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint + qDigitsAfterPoint + 1d + bDigitsAfterPoint, 2d*digitsAfterPoint);
		x2 = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint, 2d*digitsAfterPoint);

		AddArbitraryPrecisionInteger(x1.baseNumber, x1.baseNumber, a.baseNumber);
		AddArbitraryPrecisionInteger(x2.baseNumber, x2.baseNumber, b.baseNumber);

		ShiftLeftUnsignedInteger(x1.baseNumber.number, qDigitsAfterPoint + 1d + bDigitsAfterPoint);

		qx = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint + qDigitsAfterPoint + 1d + bDigitsAfterPoint, 2d*digitsAfterPoint);
		rx = CreateArbitraryPrecisionFixedPointNumber(2d*digitsBeforePoint + qDigitsAfterPoint + 1d + bDigitsAfterPoint, 2d*digitsAfterPoint);
		DivideArbitraryPrecisionInteger(qx.baseNumber, rx.baseNumber, x1.baseNumber, x2.baseNumber);
		qx.pointPosition = qx.pointPosition + qDigitsAfterPoint - aDigitsAfterPoint + 1d - 2d*bDigitsAfterPoint;

		success = AssignArbitraryPrecisionFixedPoint(q, qx);

		return success;
	}

	public static char [] AddArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		AddArbitraryPrecisionFixedPoint(c, a, b);

		cStr = ToStringArbitraryPrecisionFixedPoint(c);

		return cStr;
	}

	public static char [] SubtractArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		SubtractArbitraryPrecisionFixedPoint(c, a, b);

		cStr = ToStringArbitraryPrecisionFixedPoint(c);

		return cStr;
	}

	public static char [] MultiplyArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, c;
		char [] cStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		c = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		MultiplyArbitraryPrecisionFixedPoint(c, a, b);

		cStr = ToStringArbitraryPrecisionFixedPoint(c);

		return cStr;
	}

	public static char [] DivideArbitraryPrecisionFixedPointStrings(char [] aStr, char [] bStr, double digitsBeforePoint, double digitsAfterPoint){
		ArbitraryPrecisionFixedPointNumber a, b, q, r;
		char [] qStr;

		a = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(aStr), GetDigitsAfterAPFPString(aStr), aStr);
		b = CreateArbitraryPrecisionFixedPointFromString(GetDigitsBeforeAPFPString(bStr), GetDigitsAfterAPFPString(bStr), bStr);
		q = CreateArbitraryPrecisionFixedPointNumber(digitsBeforePoint, digitsAfterPoint);

		DivideArbitraryPrecisionFixedPoint(q, a, b);

		qStr = ToStringArbitraryPrecisionFixedPoint(q);

		return qStr;
	}

	public static double GetDigitsAfterAPFPString(char [] str){
		double pointPosition, hasPoint, i, digitsAfter;

		pointPosition = str.length;
		hasPoint = 0d;
		for(i = 0d; i < str.length && hasPoint == 0d; i = i + 1d){
			if(str[(int)(str.length - i - 1d)] == '.'){
				pointPosition = i;
				hasPoint = 1d;
			}
		}

		if(hasPoint == 0d){
			digitsAfter = 0d;
		}else{
			digitsAfter = pointPosition;
		}

		return digitsAfter;
	}

	public static double GetDigitsBeforeAPFPString(char [] str){
		double hasSign, pointPosition, hasPoint, i, digitsBefore;

		hasSign = 0d;
		if(str.length > 0d){
			if(str[0] == '-' || str[0] == '+'){
				hasSign = 1d;
			}
		}

		pointPosition = 0d;
		hasPoint = 0d;
		for(i = 0d; i < str.length && hasPoint == 0d; i = i + 1d){
			if(str[(int)(str.length - i - 1d)] == '.'){
				pointPosition = i;
				hasPoint = 1d;
			}
		}

		if(hasPoint == 0d){
			digitsBefore = str.length - hasPoint;
		}else{
			digitsBefore = str.length - pointPosition - hasSign - 1d;
		}

		return digitsBefore;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
