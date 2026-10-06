package com.martinfjohansen.oneaccounting.ISIN.ISIN;

import com.martinfjohansen.oneaccounting.references.references.CharacterReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.LuhnAlgorithm.LuhnAlgorithm.LuhnAlgorithm.LuhnComputeCheckDigit;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCopyStringRange;
import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.*;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.CreateNumberFromDecimalStringWithCheck;


public class ISIN{
	public static boolean ISINCheck(char [] isin, StringReference errorMessage){
		boolean isValid;
		StringReference numberReference;
		CharacterReference checkDigitReference;
		char [] numberString;
		NumberReference digitReference;

		numberReference = new StringReference();
		checkDigitReference = new CharacterReference();
		numberString = new char [1];
		digitReference = new NumberReference();

		if(isin.length == 12d){
			arraysCopyStringRange(isin, 0d, isin.length - 1d, numberReference);

			isValid = ISINComputeCheckDigit(numberReference.string, checkDigitReference, errorMessage);
			if(isValid){
				if(checkDigitReference.characterValue == isin[(int)(isin.length - 1d)]){
				}else{
					numberString[0] = isin[(int)(isin.length - 1d)];
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
			isValid = false;
			errorMessage.string = "ISIN must be 12 alpha-numeric characters.".toCharArray();
		}

		return isValid;
	}

	public static boolean ISINComputeCheckDigit(char [] isin, CharacterReference checkDigitReference, StringReference errorMessage){
		boolean isValid;
		StringReference isinNumericReference;

		isinNumericReference = new StringReference();

		if(isin.length == 11d){
			isValid = ISINToNumericCode(isin, isinNumericReference, errorMessage);

			if(isValid){
				LuhnComputeCheckDigit(isinNumericReference.string, checkDigitReference, errorMessage);
			}
		}else{
			isValid = false;
			errorMessage.string = "ISIN must be 11 digits before the checksum digit to be calculated.".toCharArray();
		}

		return isValid;
	}

	public static boolean ISINExtendWithCheckDigit(char [] isin, StringReference extended, StringReference errorMessage){
		boolean isValid;
		double i;
		CharacterReference checkDigitReference;

		checkDigitReference = new CharacterReference();
		isValid = ISINComputeCheckDigit(isin, checkDigitReference, errorMessage);

		if(isValid){
			extended.string = new char [(int)(isin.length + 1d)];
			for(i = 0d; i < isin.length; i = i + 1d){
				extended.string[(int)(i)] = isin[(int)(i)];
			}
			extended.string[(int)(i)] = checkDigitReference.characterValue;
		}

		return isValid;
	}

	public static boolean ISINToNumericCode(char [] isin, StringReference isinNumericReference, StringReference errorMessage){
		boolean isValid;
		double length, i, pos;
		StringReference code;

		isValid = true;
		code = new StringReference();

		length = 0d;

		for(i = 0d; i < isin.length && isValid; i = i + 1d){
			if(cIsLetter(isin[(int)(i)])){
				length = length + 2d;
			}else if(cIsNumber(isin[(int)(i)])){
				length = length + 1d;
			}else{
				isValid = false;
				errorMessage.string = "ISIN can only contain alpha-numeric characters.".toCharArray();
			}
		}

		if(isValid){
			isinNumericReference.string = new char [(int)(length)];

			pos = 0d;

			for(i = 0d; i < isin.length; i = i + 1d){
				ISINSymbolToCode(isin[(int)(i)], code, errorMessage);

				isinNumericReference.string[(int)(pos)] = code.string[0];
				pos = pos + 1d;
				if(code.string.length == 2d){
					isinNumericReference.string[(int)(pos)] = code.string[1];
					pos = pos + 1d;
				}
			}
		}

		return isValid;
	}

	public static boolean ISINSymbolToCode(char c, StringReference stringReference, StringReference errorMessage){
		boolean isValid;

		if(cIsLetter(c) && cIsUpperCase(c)){
			if(c == 'A'){
				stringReference.string = "10".toCharArray();
			}else if(c == 'B'){
				stringReference.string = "11".toCharArray();
			}else if(c == 'C'){
				stringReference.string = "12".toCharArray();
			}else if(c == 'D'){
				stringReference.string = "13".toCharArray();
			}else if(c == 'E'){
				stringReference.string = "14".toCharArray();
			}else if(c == 'F'){
				stringReference.string = "15".toCharArray();
			}else if(c == 'G'){
				stringReference.string = "16".toCharArray();
			}else if(c == 'H'){
				stringReference.string = "17".toCharArray();
			}else if(c == 'I'){
				stringReference.string = "18".toCharArray();
			}else if(c == 'J'){
				stringReference.string = "19".toCharArray();
			}else if(c == 'K'){
				stringReference.string = "20".toCharArray();
			}else if(c == 'L'){
				stringReference.string = "21".toCharArray();
			}else if(c == 'M'){
				stringReference.string = "22".toCharArray();
			}else if(c == 'N'){
				stringReference.string = "23".toCharArray();
			}else if(c == 'O'){
				stringReference.string = "24".toCharArray();
			}else if(c == 'P'){
				stringReference.string = "25".toCharArray();
			}else if(c == 'Q'){
				stringReference.string = "26".toCharArray();
			}else if(c == 'R'){
				stringReference.string = "27".toCharArray();
			}else if(c == 'S'){
				stringReference.string = "28".toCharArray();
			}else if(c == 'T'){
				stringReference.string = "29".toCharArray();
			}else if(c == 'U'){
				stringReference.string = "30".toCharArray();
			}else if(c == 'V'){
				stringReference.string = "31".toCharArray();
			}else if(c == 'W'){
				stringReference.string = "32".toCharArray();
			}else if(c == 'X'){
				stringReference.string = "33".toCharArray();
			}else if(c == 'Y'){
				stringReference.string = "34".toCharArray();
			}else if(c == 'Z'){
				stringReference.string = "35".toCharArray();
			}

			isValid = true;
		}else if(cIsNumber(c)){
			if(c == '0'){
				stringReference.string = "0".toCharArray();
			}else if(c == '1'){
				stringReference.string = "1".toCharArray();
			}else if(c == '2'){
				stringReference.string = "2".toCharArray();
			}else if(c == '3'){
				stringReference.string = "3".toCharArray();
			}else if(c == '4'){
				stringReference.string = "4".toCharArray();
			}else if(c == '5'){
				stringReference.string = "5".toCharArray();
			}else if(c == '6'){
				stringReference.string = "6".toCharArray();
			}else if(c == '7'){
				stringReference.string = "7".toCharArray();
			}else if(c == '8'){
				stringReference.string = "8".toCharArray();
			}else if(c == '9'){
				stringReference.string = "9".toCharArray();
			}

			isValid = true;
		}else{
			isValid = false;
			errorMessage.string = "Character is not an ISIN alpha-character.".toCharArray();
		}

		return isValid;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
