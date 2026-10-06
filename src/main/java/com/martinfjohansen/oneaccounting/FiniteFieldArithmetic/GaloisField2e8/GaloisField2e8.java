package com.martinfjohansen.oneaccounting.FiniteFieldArithmetic.GaloisField2e8;

import static com.martinfjohansen.oneaccounting.Bits.Bitwise.Bitwise.*;


public class GaloisField2e8{
	public static double GaloisField2e8Add(double a, double b){
		return Xor2Byte(a, b);
	}

	public static double GaloisField2e8Sub(double a, double b){
		return Xor2Byte(a, b);
	}

	public static double GaloisField2e8Mul(double a, double b, double modulusPolynomial){
		double r;

		r = 0d;

		for(; b != 0d; ){
			if(And2Byte(b, 1d) == 1d){
				r = Xor2Byte(r, a);
			}
			b = ShiftRight2Byte(b, 1d);
			a = ShiftLeft2Byte(a, 1d);
			if((And2Byte(a, 256d) == 256d)){
				a = Xor2Byte(a, modulusPolynomial);
			}
		}

		return r;
	}

	public static double GaloisField2e8Reciprocal(double a, double modulusPolynomial){
		double ga, i, inv;
		boolean done;

		ga = a;
		done = false;
		inv = 0d;

		for(i = 0d; i < ShiftLeft2Byte(1d, 8d) && !done; i = i + 1d){
			if(GaloisField2e8Mul(ga, i, modulusPolynomial) == 1d){
				done = true;
				inv = i;
			}
		}

		return inv;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
