package com.martinfjohansen.oneaccounting.numbers.NumberComputations;

import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.references.references.*;

import static com.martinfjohansen.oneaccounting.math.math.math.*;


import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.*;

public class NumberComputations{
	public static boolean IsValidNumber(char [] str){
		boolean valid;
		NumberReference numberRef;
		StringReference message;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		delete(numberRef);
		delete(message);

		return valid;
	}

	public static boolean IsValidInteger(char [] str){
		boolean valid;
		NumberReference numberRef;
		StringReference message;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		if(valid){
			valid = IsInteger(numberRef.numberValue);
		}

		delete(numberRef);
		delete(message);

		return valid;
	}

	public static boolean IsValidPositiveInteger(char [] str){
		boolean valid;
		NumberReference numberRef;
		StringReference message;

		numberRef = new NumberReference();
		message = new StringReference();

		valid = CreateNumberFromDecimalStringWithCheck(str, numberRef, message);

		if(valid){
			valid = IsInteger(numberRef.numberValue);
			if(valid){
				valid = numberRef.numberValue >= 0d;
			}
		}

		delete(numberRef);
		delete(message);

		return valid;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
