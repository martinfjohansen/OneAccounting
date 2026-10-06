package com.martinfjohansen.oneaccounting.BasicStatistics.PoissonDistribution;

import com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerator;

import static com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerators.PseudorandomNextNumber;
import static com.martinfjohansen.oneaccounting.math.math.math.Factorial;
import static java.lang.Math.exp;
import static java.lang.Math.pow;

public class PoissonDistribution{
	public static double PossionMass(double k, double lambda){
		return pow(lambda, k)*exp(-lambda)/Factorial(k);
	}

	public static double [] PoissonRandom(PseudorandomGenerator prg, double n, double lambda){
		double [] ns;
		double i, nr;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			nr = PseudorandomNextNumber(prg);
			ns[(int)(i)] = PoissonQuantile(nr, lambda);
		}

		return ns;
	}

	public static double PoissonQuantile(double p, double lambda){
		double sum, i;
		boolean done;

		sum = 0d;
		done = false;
		for(i = 0d; i <= lambda && !done; i = i + 1d){
			sum = sum + PossionMass(i, lambda);
			if(sum > p){
				done = true;
			}
		}

		return i - 1d;
	}

	public static double PoissonProbability(double k, double lambda){
		double i, t;

		t = 0d;
		for(i = 0d; i <= k; i = i + 1d){
			t = t + pow(lambda, i)/Factorial(i);
		}

		return t/exp(lambda);
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
