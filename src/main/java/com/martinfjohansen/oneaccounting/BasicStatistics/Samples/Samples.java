package com.martinfjohansen.oneaccounting.BasicStatistics.Samples;

import com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerator;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;

import static com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerators.PseudorandomNextInteger;
import static com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerators.PseudorandomNextIntegerBetween;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.*;

public class Samples{
	public static double [] SampleWithReplacement(PseudorandomGenerator prg, double k, double n){
		double [] ss;
		double i;

		ss = new double [(int)(k)];

		for(i = 0d; i < k; i = i + 1d){
			ss[(int)(i)] = PseudorandomNextInteger(prg, n);
		}

		return ss;
	}

	public static double [] Sample(PseudorandomGenerator prg, double k, double n){
		double [] ss, list;
		double i, next;
		boolean [] hasPicked;
		NumberArrayReference ssReference;

		ss = new double [(int)(k)];
		if(n/10d < k){
			/* If k is relatively high:*/
			list = RandomPermutation(prg, n);

			ssReference = new NumberArrayReference();
			arraysCopyNumberArrayRange(list, 0d, k, ssReference);
			ss = ssReference.numberArray;
			delete(ssReference);
			delete(list);
		}else{
			/* If k is relatively low:*/
			hasPicked = arraysCreateBooleanArray(n, false);

			for(i = 0d; i < n; ){
				next = PseudorandomNextInteger(prg, n);
				if(!hasPicked[(int)(next)]){
					hasPicked[(int)(next)] = true;
					ss[(int)(i)] = next;
					i = i + 1d;
				}
			}

			delete(hasPicked);
		}

		return ss;
	}

	public static void Shuffle(PseudorandomGenerator prg, double [] list){
		FisherYatesShuffle(prg, list);
	}

	public static void FisherYatesShuffle(PseudorandomGenerator prg, double [] a){
		double i, j, n;

		n = a.length;

		for(i = 0d; i < n - 2d; i = i + 1d){
			j = PseudorandomNextIntegerBetween(prg, i, n);
			arraysSwapElementsOfNumberArray(a, i, j);
		}
	}

	public static double [] SampleWithReplacementFromArray(PseudorandomGenerator prg, double [] a, double k){
		double [] source, list;
		double i;

		source = SampleWithReplacement(prg, k, a.length);

		list = new double [(int)(k)];

		for(i = 0d; i < k; i = i + 1d){
			list[(int)(i)] = a[(int)(source[(int)(i)])];
		}

		delete(source);

		return list;
	}

	public static double [] SampleFromArray(PseudorandomGenerator prg, double [] a, double k){
		double [] source, list;
		double i;

		source = Sample(prg, k, a.length);

		list = new double [(int)(k)];

		for(i = 0d; i < k; i = i + 1d){
			list[(int)(i)] = a[(int)(source[(int)(i)])];
		}

		delete(source);

		return list;
	}

	public static double [] RandomPermutation(PseudorandomGenerator prg, double n){
		double [] list;
		double i;

		list = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			list[(int)(i)] = i;
		}

		Shuffle(prg, list);

		return list;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
