package com.martinfjohansen.oneaccounting.BCHCodes.BCHCodes;

import static com.martinfjohansen.oneaccounting.Bits.Bitwise.Bitwise.*;


public class BCHCodes{
	public static double ComputeBHC15_5Code(double data){
		double i, gp;

		/* x^10 + x^8 + x^5 + x^4 + x^2 + x + 1 is encoded as 10100110111b = 1335*/
		gp = 1335d;

		for(i = 0d; i < 10d; i = i + 1d){
			data = Xor4Byte(ShiftLeft4Byte(data, 1d), ShiftRight4Byte(data, 9d)*gp);
		}

		return data;
	}

	public static double ComputeBHC18_6Code(double data){
		double i, gp;

		/* x^12 + x^11 + x^10 + x^9 + x^8 + x^5 + x^2 + 1 is encoded as 1111100100101b = 7973*/
		gp = 7973d;

		for(i = 0d; i < 12d; i = i + 1d){
			data = Xor4Byte(ShiftLeft4Byte(data, 1d), ShiftRight4Byte(data, 11d)*gp);
		}

		return data;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
