package com.martinfjohansen.oneaccounting.PolynomialSolver.PolynomialSolver;

import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static com.martinfjohansen.oneaccounting.math.math.math.EpsilonCompare;
import static com.martinfjohansen.oneaccounting.pPolynomials.Polynomials.Polynomials.*;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateNumberReference;
import static java.lang.Math.*;

public class PolynomialSolver{
	public static boolean FindRoots(double [] p, NumberArrayReference rootsReference){
		return DurandKernerMethod(p, 0.000001, 100d, rootsReference);
	}

	public static boolean LaguerresMethodWithRepeatedDivision(double [] p, double maxIterations, double precision, double guess, NumberArrayReference rootsReference){
		double n, nr, xk;
		double [] x;
		double [] q, r, d;
		boolean success;
		NumberReference xkReference;

		n = pDegree(p);

		x = new double [(int)(n)];

		q = pCreatePolynomial(n);
		r = pCreatePolynomial(n);
		d = pCreatePolynomial(n);

		success = true;
		xkReference = CreateNumberReference(0d);

		for(nr = 0d; nr < n && success; nr = nr + 1d){
			success = LaguerresMethod(p, guess, maxIterations, precision, xkReference);

			if(success){
				xk = xkReference.numberValue;
				x[(int)(nr)] = xk;

				pFill(d, 0d);
				d[0] = -xk;
				d[1] = 1d;
				pDivide(q, r, p, d);
				pAssign(p, q);
			}
		}

		delete(q);
		delete(r);
		delete(d);
        
		rootsReference.numberArray = x;

		return success;
	}

	public static boolean LaguerresMethod(double [] p, double guess, double maxIterations, double precision, NumberReference rootReference){
		double k, a, G, H, xk, denom1, denom2, denom, t1, n;
		boolean success;

		n = pDegree(p);
		success = true;

		xk = guess;

		for(k = 0d; (k < maxIterations) && (abs(pEvaluate(p, xk)) >= precision) && success; k = k + 1d){
			G = pEvaluateDerivative(p, xk, 1d)/pEvaluate(p, xk);
			H = pow(G, 2d) - pEvaluateDerivative(p, xk, 2d)/pEvaluate(p, xk);
			t1 = (n - 1d)*(n*H - pow(G, 2d));
			if(t1 >= 0d){
				denom = sqrt(t1);
				denom1 = G + denom;
				denom2 = G - denom;
				if(abs(denom1) >= abs(denom2)){
					denom = denom1;
				}else{
					denom = denom2;
				}
				a = n/denom;

				xk = xk - a;
			}else{
				success = false;
			}
		}

		if(k == maxIterations){
			success = false;
		}

		if(abs(pEvaluate(p, xk)) >= precision){
			success = false;
		}

		rootReference.numberValue = xk;

		return success;
	}

	public static boolean DurandKernerMethod(double [] p, double precision, double maxIterations, NumberArrayReference rootsReference){
		boolean success;
		double n, i, j, k, t1, t2, xn1, withinPrecision;
		double [] rs, rsPrev;

		n = p.length - 1d;
		rs = new double [(int)(n)];
		rsPrev = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			rsPrev[(int)(i)] = i;
		}

		success = false;

		for(i = 0d; i < maxIterations && !success; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				xn1 = rsPrev[(int)(j)];

				t1 = pEvaluate(p, xn1);
				t2 = 1d;
				for(k = 0d; k < n; k = k + 1d){
					if(k < j){
						t2 = t2*(xn1 - rs[(int)(k)]);
					}
					if(k > j){
						t2 = t2*(xn1 - rsPrev[(int)(k)]);
					}
				}
				t1 = t1/t2;
				rs[(int)(j)] = xn1 - t1;
			}
			withinPrecision = 0d;
			for(j = 0d; j < n; j = j + 1d){
				if(EpsilonCompare(rsPrev[(int)(j)], rs[(int)(j)], precision)){
					withinPrecision = withinPrecision + 1d;
				}
				rsPrev[(int)(j)] = rs[(int)(j)];
			}
			if(withinPrecision == n){
				success = true;
			}
		}

		rootsReference.numberArray = rs;

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
