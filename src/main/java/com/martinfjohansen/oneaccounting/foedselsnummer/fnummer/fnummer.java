package com.martinfjohansen.oneaccounting.foedselsnummer.fnummer;

import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cCharacterToDecimalDigit;
import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cIsNumber;
import static com.martinfjohansen.oneaccounting.datetime.DateCalculations.DateCalculations.IsValidDate;


public class fnummer{
	public static boolean IsValidNorwegianPersonalIdentificationNumber(char [] fnummer, StringReference message){
		boolean valid;
		double i, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11;
		double k1, k2;
		DateReference dateRef;

		valid = fnummer.length == 11d;
		if(valid){
			for(i = 0d; i < fnummer.length; i = i + 1d){
				if(cIsNumber(fnummer[(int)(i)])){
				}else{
					valid = false;
				}
			}

			if(valid){
				d1 = cCharacterToDecimalDigit(fnummer[0]);
				d2 = cCharacterToDecimalDigit(fnummer[1]);
				d3 = cCharacterToDecimalDigit(fnummer[2]);
				d4 = cCharacterToDecimalDigit(fnummer[3]);
				d5 = cCharacterToDecimalDigit(fnummer[4]);
				d6 = cCharacterToDecimalDigit(fnummer[5]);
				d7 = cCharacterToDecimalDigit(fnummer[6]);
				d8 = cCharacterToDecimalDigit(fnummer[7]);
				d9 = cCharacterToDecimalDigit(fnummer[8]);
				d10 = cCharacterToDecimalDigit(fnummer[9]);
				d11 = cCharacterToDecimalDigit(fnummer[10]);

				dateRef = new DateReference();
				valid = GetDateFromNorwegianPersonalIdentificationNumber(fnummer, dateRef, message);

				if(valid){
					valid = IsValidDate(dateRef.date, message);
					if(valid){
						k1 = d1*3d + d2*7d + d3*6d + d4*1d + d5*8d + d6*9d + d7*4d + d8*5d + d9*2d;
						k1 = k1%11d;
						if(k1 != 0d){
							k1 = 11d - k1;
						}
						if(k1 == 10d){
							valid = false;
							message.string = "Control digit 1 is 10, which is invalid.".toCharArray();
						}

						if(valid){
							k2 = d1*5d + d2*4d + d3*3d + d4*2d + d5*7d + d6*6d + d7*5d + d8*4d + d9*3d + k1*2d;
							k2 = k2%11d;
							if(k2 != 0d){
								k2 = 11d - k2;
							}
							if(k2 == 10d){
								valid = false;
								message.string = "Control digit 2 is 10, which is invalid.".toCharArray();
							}

							if(valid){
								if(k1 == d10){
									if(k2 == d11){
										valid = true;
									}else{
										valid = false;
										message.string = "Check of control digit 2 failed.".toCharArray();
									}
								}else{
									valid = false;
									message.string = "Check of control digit 1 failed.".toCharArray();
								}
							}
						}
					}else{
						message.string = "The date is not a valid date.".toCharArray();
					}
				}
			}else{
				message.string = "Each character must be a decimal digit.".toCharArray();
			}
		}else{
			message.string = "Must be exactly 11 digits long.".toCharArray();
		}

		return valid;
	}

	public static boolean GetDateFromNorwegianPersonalIdentificationNumber(char [] fnummer, DateReference dateRef, StringReference message){
		double individnummer;
		double day, month, year;
		double i, d1, d2, d3, d4, d5, d6, d7, d8, d9;
		boolean success;

		dateRef.date = new Date();

		success = fnummer.length == 11d;
		if(success){
			for(i = 0d; i < fnummer.length; i = i + 1d){
				if(cIsNumber(fnummer[(int)(i)])){
				}else{
					success = false;
				}
			}

			if(success){
				d1 = cCharacterToDecimalDigit(fnummer[0]);
				d2 = cCharacterToDecimalDigit(fnummer[1]);
				d3 = cCharacterToDecimalDigit(fnummer[2]);
				d4 = cCharacterToDecimalDigit(fnummer[3]);
				d5 = cCharacterToDecimalDigit(fnummer[4]);
				d6 = cCharacterToDecimalDigit(fnummer[5]);
				d7 = cCharacterToDecimalDigit(fnummer[6]);
				d8 = cCharacterToDecimalDigit(fnummer[7]);
				d9 = cCharacterToDecimalDigit(fnummer[8]);

				/* Individnummer*/
				individnummer = d7*100d + d8*10d + d9;

				/* Make date*/
				day = d1*10d + d2;
				month = d3*10d + d4;
				year = d5*10d + d6;

				if(individnummer >= 0d && individnummer <= 499d){
					year = year + 1900d;
				}else if(individnummer >= 500d && individnummer <= 749d && year >= 54d && year <= 99d){
					year = year + 1800d;
				}else if(individnummer >= 900d && individnummer <= 999d && year >= 40d && year <= 99d){
					year = year + 1900d;
				}else if(individnummer >= 500d && individnummer <= 999d && year >= 0d && year <= 39d){
					year = year + 2000d;
				}else{
					success = false;
					message.string = "Invalid combination of individnummer and year.".toCharArray();
				}

				if(success){
					dateRef.date.year = year;
					dateRef.date.month = month;
					dateRef.date.day = day;
				}
			}else{
				message.string = "Each character must be a decimal digit.".toCharArray();
			}
		}else{
			message.string = "Must be exactly 11 digits long.".toCharArray();
		}

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
