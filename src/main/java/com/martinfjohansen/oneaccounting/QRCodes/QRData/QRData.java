package com.martinfjohansen.oneaccounting.QRCodes.QRData;

import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cIsNumber;

public class QRData{
	public static boolean IsQRNumericString(char [] chars){
		double i;
		boolean valid;

		valid = true;

		for(i = 0d; i < chars.length; i = i + 1d){
			if(IsQRNumericCharacter(chars[(int)(i)])){
			}else{
				valid = false;
			}
		}

		return valid;
	}

	public static boolean IsQRNumericCharacter(char aChar){
		return cIsNumber(aChar);
	}

	public static boolean IsQRAlphanumericString(char [] chars){
		double i;
		boolean valid;
		char c;

		valid = true;

		for(i = 0d; i < chars.length; i = i + 1d){
			c = chars[(int)(i)];

			valid = IsQRAlphanumericCharacter(c);
		}

		return valid;
	}

	public static boolean IsQRAlphanumericCharacter(char c){
		boolean valid;

		valid = true;

		if(cIsNumber(c)){
		}else if(IsQRAlphaUppercase(c)){
		}else if(c == ' '){
		}else if(c == '$'){
		}else if(c == '%'){
		}else if(c == '*'){
		}else if(c == '+'){
		}else if(c == '-'){
		}else if(c == '.'){
		}else if(c == '/'){
		}else if(c == ':'){
		}else{
			valid = false;
		}
		return valid;
	}

	public static boolean IsQRJIS8Character(char c){
		double code;
		boolean valid;

		code = c;

		if(code >= 0d && code < 128d){
			valid = true;
		}else{
			valid = false;
		}

		return valid;
	}

	public static boolean IsQRAlphaUppercase(char character){
		boolean isUpper;

		isUpper = true;
		if(character == 'A'){
		}else if(character == 'B'){
		}else if(character == 'C'){
		}else if(character == 'D'){
		}else if(character == 'E'){
		}else if(character == 'F'){
		}else if(character == 'G'){
		}else if(character == 'H'){
		}else if(character == 'I'){
		}else if(character == 'J'){
		}else if(character == 'K'){
		}else if(character == 'L'){
		}else if(character == 'M'){
		}else if(character == 'N'){
		}else if(character == 'O'){
		}else if(character == 'P'){
		}else if(character == 'Q'){
		}else if(character == 'R'){
		}else if(character == 'S'){
		}else if(character == 'T'){
		}else if(character == 'U'){
		}else if(character == 'V'){
		}else if(character == 'W'){
		}else if(character == 'X'){
		}else if(character == 'Y'){
		}else if(character == 'Z'){
		}else{
			isUpper = false;
		}

		return isUpper;
	}

	public static double QRAlphanumericToCode(char c){
		double code;

		if(c == '0'){
			code = 0d;
		}else if(c == '1'){
			code = 1d;
		}else if(c == '2'){
			code = 2d;
		}else if(c == '3'){
			code = 3d;
		}else if(c == '4'){
			code = 4d;
		}else if(c == '5'){
			code = 5d;
		}else if(c == '6'){
			code = 6d;
		}else if(c == '7'){
			code = 7d;
		}else if(c == '8'){
			code = 8d;
		}else if(c == '9'){
			code = 9d;
		}else if(c == 'A'){
			code = 10d;
		}else if(c == 'B'){
			code = 11d;
		}else if(c == 'C'){
			code = 12d;
		}else if(c == 'D'){
			code = 13d;
		}else if(c == 'E'){
			code = 14d;
		}else if(c == 'F'){
			code = 15d;
		}else if(c == 'G'){
			code = 16d;
		}else if(c == 'H'){
			code = 17d;
		}else if(c == 'I'){
			code = 18d;
		}else if(c == 'J'){
			code = 19d;
		}else if(c == 'K'){
			code = 20d;
		}else if(c == 'L'){
			code = 21d;
		}else if(c == 'M'){
			code = 22d;
		}else if(c == 'N'){
			code = 23d;
		}else if(c == 'O'){
			code = 24d;
		}else if(c == 'P'){
			code = 25d;
		}else if(c == 'Q'){
			code = 26d;
		}else if(c == 'R'){
			code = 27d;
		}else if(c == 'S'){
			code = 28d;
		}else if(c == 'T'){
			code = 29d;
		}else if(c == 'U'){
			code = 30d;
		}else if(c == 'V'){
			code = 31d;
		}else if(c == 'W'){
			code = 32d;
		}else if(c == 'X'){
			code = 33d;
		}else if(c == 'Y'){
			code = 34d;
		}else if(c == 'Z'){
			code = 35d;
		}else if(c == ' '){
			code = 36d;
		}else if(c == '$'){
			code = 37d;
		}else if(c == '%'){
			code = 38d;
		}else if(c == '*'){
			code = 39d;
		}else if(c == '+'){
			code = 40d;
		}else if(c == '-'){
			code = 41d;
		}else if(c == '.'){
			code = 42d;
		}else if(c == '/'){
			code = 43d;
		}else if(c == ':'){
			code = 44d;
		}else{
			code = 0d;
		}

		return code;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
