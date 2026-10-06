package com.martinfjohansen.oneaccounting.pPolynomials.Polynomials;

import static com.martinfjohansen.oneaccounting.math.math.math.Permutations;
import static java.lang.Math.pow;

public class Polynomials{
	public static void pAdd(double [] a, double [] b){
		double i, nr;

		nr = b.length;

		for(i = 0d; i < nr; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] + b[(int)(i)];
		}
	}

	public static void pSubtract(double [] a, double [] b){
		double i, nr;

		nr = b.length;

		for(i = 0d; i < nr; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] - b[(int)(i)];
		}
	}

	public static void pMultiply(double [] c, double [] a, double [] b){
		double k, n, m, i;
		double av, bv;

		n = pDegree(a);
		m = pDegree(b);

		pFill(c, 0d);

		for(i = 0d; i <= n + m; i = i + 1d){
			c[(int)(i)] = 0d;
			for(k = 0d; k <= i && k < a.length && i - k < b.length; k = k + 1d){
				av = a[(int)(k)];
				bv = b[(int)(i - k)];
				c[(int)(i)] = c[(int)(i)] + av*bv;
			}
		}
	}

	public static void pDivide(double [] q, double [] r, double [] n, double [] d){
		double [] t, t1;
		double tcoff, tdegree, i;
		double deg;
		double rd, dd;

		pFill(q, 0d);
		pAssign(r, n);
		deg = pDegree(n);
		t = pCreatePolynomial(deg);
		t1 = pCreatePolynomial(deg);

		rd = pDegree(r);
		dd = pDegree(d);
		for(i = 0d; i < deg + 1d && !pIsZero(r) && rd - i >= dd; i = i + 1d){
			pFill(t, 0d);
			tdegree = rd - i - dd;
			tcoff = r[(int)(rd - i)]/d[(int)(dd)];
			t[(int)(tdegree)] = tcoff;
			pAdd(q, t);
			pFill(t1, 0d);
			pMultiply(t1, t, d);
			pSubtract(r, t1);
		}

		delete(t);
		delete(t1);
	}

	public static boolean pIsZero(double [] a){
		double i;
		boolean itIsZero;

		itIsZero = true;

		for(i = 0d; i < a.length; i = i + 1d){
			if(a[(int)(i)] != 0d){
				itIsZero = false;
			}
		}

		return itIsZero;
	}

	public static void pAssign(double [] a, double [] b){
		double i, nr;

		nr = b.length;

		for(i = 0d; i < nr; i = i + 1d){
			a[(int)(i)] = b[(int)(i)];
		}
	}

	public static double [] pCreatePolynomial(double deg){
		double [] p;

		p = new double [(int)(deg + 1d)];

		pFill(p, 0d);

		return p;
	}

	public static void pFill(double [] p, double value){
		double i;

		for(i = 0d; i < p.length; i = i + 1d){
			p[(int)(i)] = value;
		}
	}

	public static double pDegree(double [] A){
		double i;
		double deg;
		boolean done;

		done = false;
		deg = 0d;
		for(i = A.length - 1d; i >= 0d && !done; i = i - 1d){
			if(A[(int)(i)] != 0d){
				deg = i;
				done = true;
			}
		}

		return deg;
	}

	public static double pLead(double [] A){
		double deg;

		deg = pDegree(A);

		return A[(int)(deg)];
	}

	public static double pEvaluate(double [] A, double x){
		return pEvaluateWithHornersMethod(A, x);
	}

	public static double pEvaluateWithHornersMethod(double [] A, double x){
		double r, i;

		r = 0d;

		for(i = A.length - 1d; i >= 0d; i = i - 1d){
			r = r*x;
			r = A[(int)(i)] + r;
		}

		return r;
	}

	public static double pEvaluateWithPowers(double [] A, double x){
		double r, i;

		r = 0d;

		for(i = 0d; i < A.length; i = i + 1d){
			r = r + A[(int)(i)]*pow(x, i);
		}

		return r;
	}

	public static double pEvaluateDerivative(double [] A, double x, double n){
		double r, i, v;

		r = 0d;

		for(i = 0d; i < A.length; i = i + 1d){
			if(i - n >= 0d){
				v = A[(int)(i)]*Permutations(i, n)*pow(x, i - n);
				r = r + v;
			}
		}

		return r;
	}

	public static void pDerivative(double [] A){
		double i, degree;

		degree = 0d;
		for(i = 1d; i < A.length; i = i + 1d){
			degree = degree + 1d;
			A[(int)(i - 1d)] = degree*A[(int)(i)];
		}

		A[(int)(A.length - 1d)] = 0d;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
