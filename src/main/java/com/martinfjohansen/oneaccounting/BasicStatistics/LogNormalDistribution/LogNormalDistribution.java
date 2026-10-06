package com.martinfjohansen.oneaccounting.BasicStatistics.LogNormalDistribution;

import com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerator;

import static com.martinfjohansen.oneaccounting.BasicStatistics.NormalDistribution.NormalDistribution.*;
import static java.lang.Math.*;

public class LogNormalDistribution{
	public static double LogNormalDensity(double x, double mean, double sd){
		return 1d/(x*sd*sqrt(2d*PI))*exp(-(pow(log(x) - mean, 2d)/(2d*pow(sd, 2d))));
	}

	public static double [] LogNormalRandom(PseudorandomGenerator prg, double n, double mean, double sd){
		double i;
		double [] rs;

		rs = NormalRandom(prg, n, mean, sd);

		for(i = 0d; i < n; i = i + 1d){
			rs[(int)(i)] = exp(rs[(int)(i)]);
		}

		return rs;
	}

	public static double LogNormalProbability(double q, double mean, double sd){
		return NormalProbability(log(q), mean, sd);
	}

	public static double LogNormalQuantile(double p, double mean, double sd){
		return exp(NormalQuantile(p, mean, sd));
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
