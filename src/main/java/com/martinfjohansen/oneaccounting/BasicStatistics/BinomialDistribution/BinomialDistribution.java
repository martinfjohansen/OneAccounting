package com.martinfjohansen.oneaccounting.BasicStatistics.BinomialDistribution;

import com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerator;

import static com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerators.PseudorandomNextNumber;
import static com.martinfjohansen.oneaccounting.math.math.math.Combinations;
import static java.lang.Math.pow;

public class BinomialDistribution{
	public static double BinomialDensity(double x, double size, double p){
		return Combinations(size, x)*pow(p, x)*pow(1d - p, size - x);
	}

	public static double [] BinomialRandom(PseudorandomGenerator prg, double n, double size, double p){
		double [] ns;
		double i, j, nr, c;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			c = 0d;

			for(j = 0d; j < size; j = j + 1d){
				nr = PseudorandomNextNumber(prg);
				if(nr < p){
					c = c + 1d;
				}
			}

			ns[(int)(i)] = c;
		}

		return ns;
	}

	public static double BinomialProbability(double x, double size, double prob){
		double sum, i;

		sum = 0d;
		for(i = 0d; i <= x; i = i + 1d){
			sum = sum + BinomialDensity(i, size, prob);
		}

		return sum;
	}

	public static double BinomialQuantile(double u, double size, double prob){
		double sum, i;
		boolean done;

		sum = 0d;
		done = false;
		for(i = 0d; i <= size && !done; i = i + 1d){
			sum = sum + BinomialDensity(i, size, prob);
			if(sum > u){
				done = true;
			}
		}

		return i - 1d;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
