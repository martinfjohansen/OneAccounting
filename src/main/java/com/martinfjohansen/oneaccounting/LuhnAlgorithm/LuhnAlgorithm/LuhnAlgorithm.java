package com.martinfjohansen.oneaccounting.LuhnAlgorithm.LuhnAlgorithm;

import com.martinfjohansen.oneaccounting.references.references.CharacterReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCopyStringRange;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.GetSingleDigitCharacterFromNumberWithCheck;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.CreateNumberFromDecimalStringWithCheck;


public class LuhnAlgorithm{
	public static boolean LuhnCheck(char [] number, StringReference errorMessage){
		boolean isValid;
		StringReference numberReference;
		CharacterReference checkDigitReference;
		char [] numberString;
		NumberReference digitReference;

		numberReference = new StringReference();
		checkDigitReference = new CharacterReference();
		numberString = new char [1];
		digitReference = new NumberReference();

		isValid = arraysCopyStringRange(number, 0d, number.length - 1d, numberReference);
		if(isValid){
			isValid = LuhnComputeCheckDigit(numberReference.string, checkDigitReference, errorMessage);
			if(isValid){
				if(checkDigitReference.characterValue == number[(int)(number.length - 1d)]){
				}else{
					numberString[0] = number[(int)(number.length - 1d)];
					isValid = CreateNumberFromDecimalStringWithCheck(numberString, digitReference, errorMessage);
					if(isValid){
						errorMessage.string = "Check digit wrong.".toCharArray();
					}else{
						errorMessage.string = "Check symbol not a digit.".toCharArray();
					}
					isValid = false;
				}
			}
		}else{
			errorMessage.string = "Number is too short: must be at least one digit.".toCharArray();
		}

		return isValid;
	}

	public static boolean LuhnComputeCheckDigit(char [] number, CharacterReference checkDigitReference, StringReference errorMessage){
		double sum, n, i, check;
		boolean alternate, isValid;
		NumberReference numberReference;
		char [] numberString;

		sum = 0d;
		alternate = true;
		numberString = new char [1];
		numberReference = new NumberReference();
		isValid = true;

		for(i = number.length - 1d; i >= 0d && isValid; i = i - 1d){
			numberString[0] = number[(int)(i)];
			isValid = CreateNumberFromDecimalStringWithCheck(numberString, numberReference, errorMessage);
			if(isValid){
				n = numberReference.numberValue;
				if(alternate){
					n = n*2d;
					if(n > 9d){
						n = (n%10d) + 1d;
					}
				}
				sum = sum + n;
				alternate = !alternate;
			}else{
				errorMessage.string = "Invalid digit in number string.".toCharArray();
			}
		}

		if(isValid){
			check = sum%10d;

			if(check != 0d){
				check = 10d - check;
			}

			GetSingleDigitCharacterFromNumberWithCheck(check, 10d, checkDigitReference);
		}

		return isValid;
	}

	public static boolean LuhnExtendWithCheckDigit(char [] number, StringReference extended, StringReference errorMessage){
		boolean isValid;
		double i;
		CharacterReference checkDigitReference;

		checkDigitReference = new CharacterReference();
		isValid = LuhnComputeCheckDigit(number, checkDigitReference, errorMessage);

		if(isValid){
			extended.string = new char [(int)(number.length + 1d)];
			for(i = 0d; i < number.length; i = i + 1d){
				extended.string[(int)(i)] = number[(int)(i)];
			}
			extended.string[(int)(i)] = checkDigitReference.characterValue;
		}

		return isValid;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
