package com.martinfjohansen.oneaccounting.PolynomialSolver.ComplexPolynomialSolver;

import com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.cComplexNumber;
import com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.cComplexNumberArrayReference;
import com.martinfjohansen.oneaccounting.pPolynomials.ComplexPolynomials.pComplexPolynomial;

import static com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.ComplexNumbers.*;
import static com.martinfjohansen.oneaccounting.pPolynomials.ComplexPolynomials.ComplexPolynomials.pEvaluateComplex;

public class ComplexPolynomialSolver{
	public static boolean FindRootsComplex(pComplexPolynomial p, cComplexNumberArrayReference rootsReference){
		return DurandKernerMethodComplex(p, 0.000001, 100d, rootsReference);
	}

	public static boolean DurandKernerMethodComplex(pComplexPolynomial p, double precision, double maxIterations, cComplexNumberArrayReference rootsReference){
		boolean success;
		double n, i, j, k, withinPrecision;
		cComplexNumber t1, t2, t3, xn1;
		cComplexNumber [] rs, rsPrev;

		n = p.cs.length - 1d;
		rs = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rs[(int)(i)] = cCreateComplexNumber(0d, 0d);
		}
		rsPrev = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rsPrev[(int)(i)] = cCreateComplexNumber(0.4, 0.9);
			cPower(rsPrev[(int)(i)], i);
		}
		t2 = cCreateComplexNumber(0d, 0d);
		t3 = cCreateComplexNumber(0d, 0d);

		success = false;

		for(i = 0d; i < maxIterations && !success; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				xn1 = rsPrev[(int)(j)];

				t1 = pEvaluateComplex(p, xn1);
				cAssignComplexByValues(t2, 1d, 0d);
				for(k = 0d; k < n; k = k + 1d){
					if(k < j){
						cAssignComplex(t3, xn1);
						cSub(t3, rs[(int)(k)]);
						cMul(t2, t3);
					}
					if(k > j){
						cAssignComplex(t3, xn1);
						cSub(t3, rsPrev[(int)(k)]);
						cMul(t2, t3);
					}
				}
				cDiv(t1, t2);
				cAssignComplex(rs[(int)(j)], xn1);
				cSub(rs[(int)(j)], t1);
			}
			withinPrecision = 0d;
			for(j = 0d; j < n; j = j + 1d){
				if(cEpsilonCompareComplex(rsPrev[(int)(j)], rs[(int)(j)], precision)){
					withinPrecision = withinPrecision + 1d;
				}
				cAssignComplex(rsPrev[(int)(j)], rs[(int)(j)]);
			}
			if(withinPrecision == n){
				success = true;
			}
		}

		rootsReference.complexNumbers = rs;

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
