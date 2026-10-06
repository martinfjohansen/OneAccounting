package com.martinfjohansen.oneaccounting.numbers.StringToNumber;

import com.martinfjohansen.oneaccounting.references.references.BooleanReference;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.GetDigitCharacterTable;
import static com.martinfjohansen.oneaccounting.references.references.references.*;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strSplitByString;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strTrim;
import static java.lang.Math.*;

public class StringToNumber{
	public static boolean CreateNumberFromDecimalStringWithCheck(char [] string, NumberReference decimalReference, StringReference message){
		return CreateDecimalNumberFromStringWithCheck(string, decimalReference, message);
	}

	public static double CreateNumberFromDecimalString(char [] string){
		NumberReference numberRef;
		StringReference message;
		double number;

		numberRef = CreateNumberReference(0d);
		message = CreateStringReference("".toCharArray());
		CreateDecimalNumberFromStringWithCheck(string, numberRef, message);
		number = numberRef.numberValue;

		delete(numberRef);
		delete(message);

		return number;
	}

	public static boolean CreateNumberFromStringWithCheck(char [] string, double base, NumberReference numberReference, StringReference message){
		boolean success;
		BooleanReference numberIsPositive, exponentIsPositive;
		NumberArrayReference beforePoint, afterPoint, exponent;

		numberIsPositive = CreateBooleanReference(true);
		exponentIsPositive = CreateBooleanReference(true);
		beforePoint = new NumberArrayReference();
		afterPoint = new NumberArrayReference();
		exponent = new NumberArrayReference();

		if(base >= 2d && base <= 36d){
			success = ExtractPartsFromNumberString(string, base, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

			if(success){
				numberReference.numberValue = CreateNumberFromParts(base, numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray);
			}
		}else{
			success = false;
			message.string = "Base must be from 2 to 36.".toCharArray();
		}

		return success;
	}

	public static boolean CreateDecimalNumberFromStringWithCheck(char [] string, NumberReference numberReference, StringReference message){
		boolean success;
		BooleanReference numberIsPositive, exponentIsPositive;
		NumberArrayReference beforePoint, afterPoint, exponent;

		numberIsPositive = CreateBooleanReference(true);
		exponentIsPositive = CreateBooleanReference(true);
		beforePoint = new NumberArrayReference();
		afterPoint = new NumberArrayReference();
		exponent = new NumberArrayReference();

		success = ExtractPartsFromNumberString(string, 10d, numberIsPositive, beforePoint, afterPoint, exponentIsPositive, exponent, message);

		if(success){
			numberReference.numberValue = CreateDecimalNumberFromParts(numberIsPositive.booleanValue, beforePoint.numberArray, afterPoint.numberArray, exponentIsPositive.booleanValue, exponent.numberArray);
		}

		delete(numberIsPositive);
		delete(exponentIsPositive);
		delete(beforePoint);
		delete(afterPoint);
		delete(exponent);

		return success;
	}

	public static double CreateNumberFromParts(double base, boolean numberIsPositive, double [] beforePoint, double [] afterPoint, boolean exponentIsPositive, double [] exponent){
		double n, i, d, e, digits, integerOffset, maxDigits, roundingDigit;
		boolean digitsStarted, roundingDigitSet;

		n = 0d;
		e = 0d;
		digits = 0d;
		digitsStarted = false;
		integerOffset = 0d;
		maxDigits = floor(15d*log(10d)/log(base));
		roundingDigitSet = false;
		roundingDigit = 0d;

		/* We construct an integer n, inserting one and one digit and shifting left.*/
		/* We read up to a certain amount of digits.*/
		for(i = 0d; i < beforePoint.length + afterPoint.length && digits < maxDigits + 1d; i = i + 1d){
			if(i < beforePoint.length){
				d = beforePoint[(int)(i)];
			}else{
				d = afterPoint[(int)(i - beforePoint.length)];
			}

			if(digits < maxDigits){
				if(d != 0d){
					digitsStarted = true;
					integerOffset = beforePoint.length - i;
				}

				n = n*base;
				n = n + d;

				integerOffset = integerOffset - 1d;
			}else{
				roundingDigitSet = true;
				roundingDigit = d;
			}

			if(digitsStarted){
				digits = digits + 1d;
			}
		}

		if(roundingDigitSet){
			if(roundingDigit >= base/2d){
				n = n + 1d;
			}
		}

		for(i = 0d; i < exponent.length; i = i + 1d){
			d = exponent[(int)(i)];
			e = e*base;
			e = e + d;
		}

		if(!exponentIsPositive){
			e = -e;
		}

		if(!numberIsPositive){
			n = -n;
		}

		n = n*pow(base, e + integerOffset);

		return n;
	}

	public static double CreateDecimalNumberFromParts(boolean numberIsPositive, double [] beforePoint, double [] afterPoint, boolean exponentIsPositive, double [] exponent){
		double n, i, d, e, digits, integerOffset, maxDigits, roundingDigit;
		boolean digitsStarted, roundingDigitSet;

		n = 0d;
		e = 0d;
		digits = 0d;
		digitsStarted = false;
		integerOffset = 0d;
		maxDigits = 15d;
		roundingDigitSet = false;
		roundingDigit = 0d;

		/* We construct an integer n, inserting one and one digit and shifting left.*/
		/* We read up to 15 digits, but we note a 16th digit to correctly round the result.*/
		for(i = 0d; i < beforePoint.length + afterPoint.length && digits < maxDigits + 1d; i = i + 1d){
			if(i < beforePoint.length){
				d = beforePoint[(int)(i)];
			}else{
				d = afterPoint[(int)(i - beforePoint.length)];
			}

			if(digits < maxDigits){
				if(d != 0d){
					digitsStarted = true;
					integerOffset = beforePoint.length - i;
				}

				n = n*10d;
				n = n + d;

				integerOffset = integerOffset - 1d;
			}else{
				roundingDigitSet = true;
				roundingDigit = d;
			}

			if(digitsStarted){
				digits = digits + 1d;
			}
		}

		if(roundingDigitSet){
			if(roundingDigit >= 5d){
				n = n + 1d;
			}
		}

		for(i = 0d; i < exponent.length; i = i + 1d){
			d = exponent[(int)(i)];
			e = e*10d;
			e = e + d;
		}

		if(!exponentIsPositive){
			e = -e;
		}

		if(!numberIsPositive){
			n = -n;
		}

		n = n*pow(10d, e + integerOffset);

		return n;
	}

	public static boolean ExtractPartsFromNumberString(char [] n, double base, BooleanReference numberIsPositive, NumberArrayReference beforePoint, NumberArrayReference afterPoint, BooleanReference exponentIsPositive, NumberArrayReference exponent, StringReference message){
		double i, j, count;
		boolean success, done, complete;

		i = 0d;
		complete = false;

		if(i < n.length){
			if(n[(int)(i)] == '-'){
				numberIsPositive.booleanValue = false;
				i = i + 1d;
			}else if(n[(int)(i)] == '+'){
				numberIsPositive.booleanValue = true;
				i = i + 1d;
			}

			success = true;
		}else{
			success = false;
			message.string = "Number cannot have length zero.".toCharArray();
		}

		if(success){
			done = false;
			count = 0d;
			for(; i + count < n.length && !done; ){
				if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], base)){
					count = count + 1d;
				}else{
					done = true;
				}
			}

			if(count >= 1d){
				beforePoint.numberArray = new double [(int)(count)];

				for(j = 0d; j < count; j = j + 1d){
					beforePoint.numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], base);
				}

				i = i + count;

				if(i < n.length){
					success = true;
				}else{
					afterPoint.numberArray = new double [0];
					exponent.numberArray = new double [0];
					success = true;
					complete = true;
				}
			}else{
				success = false;
				message.string = "Number must have at least one number after the optional sign.".toCharArray();
			}
		}

		if(success && !complete){
			if(n[(int)(i)] == '.'){
				i = i + 1d;

				if(i < n.length){
					done = false;
					count = 0d;
					for(; i + count < n.length && !done; ){
						if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], base)){
							count = count + 1d;
						}else{
							done = true;
						}
					}

					if(count >= 1d){
						afterPoint.numberArray = new double [(int)(count)];

						for(j = 0d; j < count; j = j + 1d){
							afterPoint.numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], base);
						}

						i = i + count;

						if(i < n.length){
							success = true;
						}else{
							exponent.numberArray = new double [0];
							success = true;
							complete = true;
						}
					}else{
						success = false;
						message.string = "There must be at least one digit after the decimal point.".toCharArray();
					}
				}else{
					success = false;
					message.string = "There must be at least one digit after the decimal point.".toCharArray();
				}
			}else if(base <= 14d && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
				if(i < n.length){
					success = true;
					afterPoint.numberArray = new double [0];
				}else{
					success = false;
					message.string = "There must be at least one digit after the exponent.".toCharArray();
				}
			}else{
				success = false;
				message.string = "Expected decimal point or exponent symbol.".toCharArray();
			}
		}

		if(success && !complete){
			if(base <= 14d && (n[(int)(i)] == 'e' || n[(int)(i)] == 'E')){
				i = i + 1d;

				if(i < n.length){
					if(n[(int)(i)] == '-'){
						exponentIsPositive.booleanValue = false;
						i = i + 1d;
					}else if(n[(int)(i)] == '+'){
						exponentIsPositive.booleanValue = true;
						i = i + 1d;
					}

					if(i < n.length){
						done = false;
						count = 0d;
						for(; i + count < n.length && !done; ){
							if(CharacterIsNumberCharacterInBase(n[(int)(i + count)], base)){
								count = count + 1d;
							}else{
								done = true;
							}
						}

						if(count >= 1d){
							exponent.numberArray = new double [(int)(count)];

							for(j = 0d; j < count; j = j + 1d){
								exponent.numberArray[(int)(j)] = GetNumberFromNumberCharacterForBase(n[(int)(i + j)], base);
							}

							i = i + count;

							if(i == n.length){
								success = true;
							}else{
								success = false;
								message.string = "There cannot be any characters past the exponent of the number.".toCharArray();
							}
						}else{
							success = false;
							message.string = "There must be at least one digit after the decimal point.".toCharArray();
						}
					}else{
						success = false;
						message.string = "There must be at least one digit after the exponent symbol.".toCharArray();
					}
				}else{
					success = false;
					message.string = "There must be at least one digit after the exponent symbol.".toCharArray();
				}
			}else{
				success = false;
				message.string = "Expected exponent symbol.".toCharArray();
			}
		}

		return success;
	}

	public static double GetNumberFromNumberCharacterForBase(char c, double base){
		char [] numberTable;
		double i;
		double position;

		numberTable = GetDigitCharacterTable();
		position = 0d;

		for(i = 0d; i < base; i = i + 1d){
			if(numberTable[(int)(i)] == c){
				position = i;
			}
		}

		return position;
	}

	public static boolean CharacterIsNumberCharacterInBase(char c, double base){
		char [] numberTable;
		double i;
		boolean found;

		numberTable = GetDigitCharacterTable();
		found = false;

		for(i = 0d; i < base; i = i + 1d){
			if(numberTable[(int)(i)] == c){
				found = true;
			}
		}

		return found;
	}

	public static double [] StringToNumberArray(char [] str){
		NumberArrayReference numberArrayReference;
		StringReference stringReference;
		double [] numbers;

		numberArrayReference = new NumberArrayReference();
		stringReference = new StringReference();

		StringToNumberArrayWithCheck(str, numberArrayReference, stringReference);

		numbers = numberArrayReference.numberArray;

		delete(numberArrayReference);
		delete(stringReference);

		return numbers;
	}

	public static boolean StringToNumberArrayWithCheck(char [] str, NumberArrayReference numberArrayReference, StringReference errorMessage){
		StringReference [] numberStrings;
		double [] numbers;
		double i;
		char [] numberString, trimmedNumberString;
		boolean success;
		NumberReference numberReference;

		numberStrings = strSplitByString(str, ",".toCharArray());

		numbers = new double [(int)(numberStrings.length)];
		success = true;
		numberReference = new NumberReference();

		for(i = 0d; i < numberStrings.length; i = i + 1d){
			numberString = numberStrings[(int)(i)].string;
			trimmedNumberString = strTrim(numberString);
			success = CreateNumberFromDecimalStringWithCheck(trimmedNumberString, numberReference, errorMessage);
			numbers[(int)(i)] = numberReference.numberValue;

			FreeStringReference(numberStrings[(int)(i)]);
			delete(trimmedNumberString);
		}

		delete(numberStrings);
		delete(numberReference);

		numberArrayReference.numberArray = numbers;

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
