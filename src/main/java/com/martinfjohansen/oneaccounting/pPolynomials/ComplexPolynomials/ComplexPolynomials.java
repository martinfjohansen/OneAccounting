package com.martinfjohansen.oneaccounting.pPolynomials.ComplexPolynomials;

import com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.cComplexNumber;

import static com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.ComplexNumbers.*;

public class ComplexPolynomials{
	public static void pAddComplex(pComplexPolynomial a, pComplexPolynomial b){
		double i, nr;

		nr = a.cs.length;

		for(i = 0d; i < nr; i = i + 1d){
			cAdd(a.cs[(int)(i)], b.cs[(int)(i)]);
		}
	}

	public static void pSubtractComplex(pComplexPolynomial a, pComplexPolynomial b){
		double i, nr;

		nr = a.cs.length;

		for(i = 0d; i < nr; i = i + 1d){
			cSub(a.cs[(int)(i)], b.cs[(int)(i)]);
		}
	}

	public static boolean pIsZeroComplex(pComplexPolynomial a){
		double i;
		boolean itIsZero;

		itIsZero = true;

		for(i = 0d; i < a.cs.length; i = i + 1d){
			if(a.cs[(int)(i)].re != 0d && a.cs[(int)(i)].im != 0d){
				itIsZero = false;
			}
		}

		return itIsZero;
	}

	public static void pAssignComplex(pComplexPolynomial a, pComplexPolynomial b){
		double i, nr;

		nr = b.cs.length;

		for(i = 0d; i < nr; i = i + 1d){
			cAssignComplex(a.cs[(int)(i)], b.cs[(int)(i)]);
		}
	}

	public static pComplexPolynomial pCreateComplexPolynomial(double deg){
		pComplexPolynomial p;
		double i;

		p = new pComplexPolynomial();
		p.cs = new cComplexNumber[(int)(deg + 1d)];

		for(i = 0d; i < deg + 1d; i = i + 1d){
			p.cs[(int)(i)] = new cComplexNumber();
		}

		pFillComplex(p, 0d, 0d);

		return p;
	}

	public static void pFillComplex(pComplexPolynomial p, double re, double im){
		double i;
		cComplexNumber c;

		c = cCreateComplexNumber(re, im);

		for(i = 0d; i < p.cs.length; i = i + 1d){
			cAssignComplex(p.cs[(int)(i)], c);
		}

		delete(c);
	}

	public static double pDegreeComplex(pComplexPolynomial A){
		double i;
		double deg;
		boolean done;

		done = false;
		deg = 0d;
		for(i = A.cs.length - 1d; i >= 0d && !done; i = i - 1d){
			if(A.cs[(int)(i)].re != 0d && A.cs[(int)(i)].im != 0d){
				deg = i;
				done = true;
			}
		}

		return deg;
	}

	public static cComplexNumber pLeadComplex(pComplexPolynomial A){
		double deg;

		deg = pDegreeComplex(A);

		return A.cs[(int)(deg)];
	}

	public static cComplexNumber pEvaluateComplex(pComplexPolynomial A, cComplexNumber x){
		double i;
		cComplexNumber r, t;

		r = cCreateComplexNumber(0d, 0d);
		t = cCreateComplexNumber(0d, 0d);

		for(i = 0d; i < A.cs.length; i = i + 1d){
			cAssignComplex(t, x);
			cPower(t, i);
			cMul(t, A.cs[(int)(i)]);
			cAdd(r, t);
		}

		return r;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
