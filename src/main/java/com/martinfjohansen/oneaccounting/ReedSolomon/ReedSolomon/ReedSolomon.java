package com.martinfjohansen.oneaccounting.ReedSolomon.ReedSolomon;

import static com.martinfjohansen.oneaccounting.Bits.Bitwise.Bitwise.XorByte;
import static com.martinfjohansen.oneaccounting.FiniteFieldArithmetic.GaloisField2e8.GaloisField2e8.GaloisField2e8Mul;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCreateNumberArray;


public class ReedSolomon{
	public static double [] ComputeReedSolomonCodes(double [] data, double eccs){
		double [] rsDiv, ecc;

		rsDiv = ReedSolomonComputeDivisor(eccs);
		ecc = ReedSolomonComputeRemainder(data, rsDiv);

		return ecc;
	}

	public static double [] ReedSolomonComputeDivisor(double eccs){
		double [] result;
		double root, i, j;

		result = arraysCreateNumberArray(eccs, 0d);
		result[(int)(result.length - 1d)] = 1d;

		root = 1d;
		for(i = 0d; i < eccs; i = i + 1d){
			for(j = 0d; j < result.length; j = j + 1d){
				result[(int)(j)] = GaloisField2e8Mul(result[(int)(j)], root, 285d);
				if(j + 1d < result.length){
					result[(int)(j)] = XorByte(result[(int)(j)], result[(int)(j + 1d)]);
				}
			}
			root = GaloisField2e8Mul(root, 2d, 285d);
		}

		return result;
	}

	public static double [] ReedSolomonComputeRemainder(double [] data, double [] divisor){
		double [] result;
		double i, j, b, factor, coef;

		result = arraysCreateNumberArray(divisor.length, 0d);

		for(i = 0d; i < data.length; i = i + 1d){
			b = data[(int)(i)];

			factor = XorByte(b, result[0]);

			for(j = 0d; j < result.length - 1d; j = j + 1d){
				result[(int)(j)] = result[(int)(j + 1d)];
			}
			result[(int)(j)] = 0d;

			for(j = 0d; j < divisor.length; j = j + 1d){
				coef = divisor[(int)(j)];
				result[(int)(j)] = XorByte(result[(int)(j)], GaloisField2e8Mul(coef, factor, 285d));
			}
		}

		return result;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
