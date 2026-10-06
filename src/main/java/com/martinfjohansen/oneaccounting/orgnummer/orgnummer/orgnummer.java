package com.martinfjohansen.oneaccounting.orgnummer.orgnummer;

import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cCharacterToDecimalDigit;
import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cIsNumber;


public class orgnummer{
	public static boolean ErGyldigOrgNummerString(char [] orgnummer){
		boolean gyldig;
		double [] o;
		double i;

		o = new double [9];

		gyldig = true;

		if(orgnummer.length == 9d){

			for(i = 0d; i < 9d; i = i + 1d){
				if(cIsNumber(orgnummer[(int)(i)])){
					o[(int)(i)] = cCharacterToDecimalDigit(orgnummer[(int)(i)]);
				}else{
					gyldig = false;
				}
			}

			if(gyldig){
				gyldig = ErGyldigOrgNummer(o);
			}
		}else{
			gyldig = false;
		}

		return gyldig;
	}

	public static boolean ErGyldigOrgNummer(double [] o){
		boolean gyldig;
		double sum, rest, kontrollsiffer;

		if(o.length == 9d){
			sum = o[0]*3d + o[1]*2d + o[2]*7d + o[3]*6d + o[4]*5d + o[5]*4d + o[6]*3d + o[7]*2d;
			rest = sum%11d;
			if(rest == 0d){
				kontrollsiffer = 0d;
			}else{
				kontrollsiffer = 11d - rest;
			}

			gyldig = rest != 1d && kontrollsiffer == o[8];
		}else{
			gyldig = false;
		}

		return gyldig;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
