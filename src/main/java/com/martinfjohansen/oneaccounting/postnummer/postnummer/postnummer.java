package com.martinfjohansen.oneaccounting.postnummer.postnummer;

import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.math.math.math.IsInteger;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.CreateNumberFromDecimalString;
import static com.martinfjohansen.oneaccounting.postnummer.db.db.HentPostnummerListe;
import static com.martinfjohansen.oneaccounting.postnummer.db.db.HentPoststedListe;
import static java.lang.Math.max;

public class postnummer{
	public static char [] HentPoststed(char [] nrString, Success feilmelding){
		double nr;
		char [] respons;
		StringReference[] poststedListe;

		nr = CreateNumberFromDecimalString(nrString);
		respons = "".toCharArray();

		if(ErGyldigPostnummer(nrString)){
			feilmelding.success = true;
			poststedListe = HentPoststedListe();
			respons = poststedListe[(int)(nr)].string;
		}else{
			feilmelding.success = false;
			feilmelding.feilmelding = "Postnummer er ikke gyldig.".toCharArray();
		}

		return respons;
	}

	public static boolean ErGyldigPostnummer(char [] nrString){
		double nr;
		boolean [] gyldigePostnummer;
		boolean erGyldig;

		nr = CreateNumberFromDecimalString(nrString);
		gyldigePostnummer = GyldigPostnummertabell();

		if(nr > 0d && nr < 10000d && IsInteger(nr) && nrString.length == 4d){
			erGyldig = gyldigePostnummer[(int)(nr)];
		}else{
			erGyldig = false;
		}

		return erGyldig;
	}

	public static boolean [] GyldigPostnummertabell(){
		double i, maxnummer;
		double [] postnummerliste;
		boolean [] rev;

		postnummerliste = HentPostnummerListe();
		maxnummer = 0d;

		for(i = 0d; i < postnummerliste.length; i = i + 1d){
			maxnummer = max(maxnummer, postnummerliste[(int)(i)]);
		}

		rev = new boolean [(int)(maxnummer + 1d)];

		for(i = 0d; i < maxnummer; i = i + 1d){
			rev[(int)(i)] = false;
		}

		for(i = 0d; i < postnummerliste.length; i = i + 1d){
			rev[(int)(postnummerliste[(int)(i)])] = true;
		}

		return rev;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
