package com.martinfjohansen.oneaccounting.BasicStatistics.NormalDistribution;

import com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerator;

import static com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerators.PseudorandomNextNumber;
import static com.martinfjohansen.oneaccounting.math.math.math.Error;
import static com.martinfjohansen.oneaccounting.math.math.math.ErrorInverse;
import static java.lang.Math.*;

public class NormalDistribution{
	public static double NormalDensity(double x, double mu, double sd){
		return 1d/(sqrt(2d*PI)*sd)*exp(-(pow(x - mu, 2d)/(2d*pow(sd, 2d))));
	}

	public static double [] NormalRandom(PseudorandomGenerator prg, double n, double mean, double sd){
		double [] ns;
		double i, nr;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			nr = PseudorandomNextNumber(prg);
			ns[(int)(i)] = NormalQuantile(nr, mean, sd);
		}

		return ns;
	}

	public static double NormalProbability(double q, double mean, double sd){
		return NormalProbabilityMethod2(q, mean, sd);
	}

	public static double NormalProbabilityMethod1(double q, double mean, double sd){
		double p, z, qz, c0, c1, c2, c3, c4, c5;

		q = (q - mean)/sd;

		if(q < 0d){
			p = 1d - NormalProbabilityMethod1(-q, 0d, 1d);
		}else{
			c0 = 0.2316419;
			c1 = 0.319381530;
			c2 = -0.356563782;
			c3 = 1.781477937;
			c4 = -1.821255978;
			c5 = 1.330274429;

			z = 1d/(1d + c0*q);
			qz = z*(c1 + z*(c2 + z*(c3 + z*(c4 + c5*z))));

			p = 1d - qz*NormalDensity(q, 0d, 1d);
		}

		return p;
	}

	public static double NormalProbabilityMethod2(double x, double mean, double sd){
		return 1d/2d*(1d + Error((x - mean)/(sd*sqrt(2d))));
	}

	public static double NormalQuantile(double u, double mean, double sd){
		return NormalQuantileMethod1(u, mean, sd);
	}

	public static double NormalQuantileMethod1(double u, double mean, double sd){
		double q, z, q1z, q2z, c0, c1, c2, c3, c4, c5, c6, c7, c8;

		if(u < 1d/2d){
			q = -NormalQuantile(1d - u, 0d, 1d);
		}else{
			z = sqrt(-2d*log(1d - u));
			c0 = -0.322232431088;
			c1 = -0.342242088547;
			c2 = -0.020423121024;
			c3 = -0.0000453642210148;
			c4 = 0.099348462606;
			c5 = 0.58858157049;
			c6 = 0.531103462366;
			c7 = 0.10353775285;
			c8 = 0.0038560700634;
			q1z = c0 + z*(-1d + z*(c1 + z*(c2 + c3*z)));
			q2z = c4 + z*(c5 + z*(c6 + z*(c7 + c8*z)));
			q = z + q1z/q2z;
		}

		q = mean + q*sd;

		return q;
	}

	public static double NormalQuantileMethod2(double u, double mean, double sd){
		return mean + sd*sqrt(2d)*ErrorInverse(2d*u - 1d);
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
