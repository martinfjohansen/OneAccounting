package com.martinfjohansen.oneaccounting.BasicStatistics.StudentTDistribution;

import com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerator;

import static com.martinfjohansen.oneaccounting.BasicStatistics.NormalDistribution.NormalDistribution.NormalQuantile;
import static com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators.PseudorandomGenerators.PseudorandomNextNumber;
import static com.martinfjohansen.oneaccounting.math.math.math.*;
import static java.lang.Math.*;

public class StudentTDistribution{
	public static double StudentTDensity(double x, double v){
		return Gamma((v + 1d)/2d)/(sqrt(v*PI)*Gamma(v/2d))*pow(1d + pow(x, 2d)/v, -((v + 1d)/2d));
	}

	public static double StudentTProbability(double x, double v){
		return 1d/2d + x*Gamma((v + 1d)/2d)*Hypergeometric(1d/2d, (v + 1d)/2d, 3d/2d, -pow(x, 2d)/v, 50d, 0.00001)/(sqrt(PI*v)*Gamma(v/2d));
	}

	public static double [] StudentTRandom(PseudorandomGenerator prg, double n, double v){
		double [] ns;
		double i, nr;

		ns = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			nr = PseudorandomNextNumber(prg);
			ns[(int)(i)] = StudentTQuantile(nr, v);
		}

		return ns;
	}

	public static double StudentTQuantile(double p, double v){
		double t, i, j, q, hy, qi, qip1, gy, a;

		if(v == 1d){
			q = tan(PI*(p - 1d/2d));
		}else if(v == 2d){
			a = 4d*p*(1d - p);
			q = (2d*p - 1d)*sqrt(2d/a);
		}else if(v == 4d){
			a = 4d*p*(1d - p);
			q = cos(1d/3d*acos(sqrt(a)))/sqrt(a);
			q = Sign(p - 1d/2d)*2d*sqrt(q - 1d);
		}else if(DivisibleBy(v, 2d)){
			q = ChengFuStudentTQuantileAlgorithm(p, v);
		}else{
			q = HillsAlgorithm396(p, v);
		}

		return q;
	}

	public static double ChengFuStudentTQuantileAlgorithm(double p, double v){
		double a, qi, i, gy, j, qip1, q, k;

		k = ceil(v/2d);
		a = 1d - p;

		if(a != 0.5){
			qi = sqrt(2d*pow(1d - 2d*a, 2d)/(1d - pow(1d - 2d*a, 2d)));

			for(i = 0d; i < 20d; i = i + 1d){
				gy = 0d;
				for(j = 0d; j <= k - 1d; j = j + 1d){
					gy = gy + Factorial(2d*j)/pow(2d, 2d*j)/pow(Factorial(j), 2d)*pow(1d + pow(qi, 2d)/(2d*k), -j);
				}

				qip1 = 1d/sqrt(1d/(2d*k)*(pow(gy/(1d - 2d*a), 2d) - 1d));

				qi = qip1;
			}

			if(a > 0.5){
				q = -qi;
			}else{
				q = qi;
			}
		}else{
			q = 0d;
		}
		return q;
	}

	public static double HillsAlgorithm396(double p, double v){
		double q, t, z;
		double a, b, c, d, x, y;
		boolean negate;

		if(p > 0.5){
			negate = false;
			z = 2d*(1d - p);
		}else{
			negate = true;
			z = 2d*p;
		}

		a = 1d/(v - 0.5);
		b = 48d/(a*a);
		c = ((20700d*a/b - 98d)*a - 16d)*a + 96.36;
		d = ((94.5/(b + c) - 3d)/b + 1d)*sqrt(a*PI/2d)*v;
		x = z*d;
		y = pow(x, 2d/v);

		if(y > 0.05 + a){
			x = NormalQuantile(z*0.5, 0d, 1d);
			y = x*x;
			if(v < 5d){
				c = c + 0.3*(v - 4.5)*(x + 0.6);
			}
			c = c + (((0.05*d*x - 5d)*x - 7d)*x - 2d)*x + b;
			y = (((((0.4*y + 6.3)*y + 36d)*y + 94.5)/c - y - 3d)/b + 1d)*x;
			y = a*y*y;
			if(y > 0.002){
				y = exp(y) - 1d;
			}else{
				y = y + 0.5*y*y;
			}
		}else{
			y = ((1d/(((v + 6d)/(v*y) - 0.089*d - 0.822)*(v + 2d)*3d) + 0.5/(v + 4d))*y - 1d)*(v + 1d)/(v + 2d) + 1d/y;
		}

		q = sqrt(v*y);

		if(negate){
			q = -q;
		}

		return q;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
