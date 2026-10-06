package com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers;

import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.LinkedListCharacters;

import static com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.LinkedListCharactersFunctions.LinkedListCharactersFunctions.*;
import static com.martinfjohansen.oneaccounting.math.math.math.*;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.CreateStringDecimalFromNumber;
import static java.lang.Math.*;


public class ComplexNumbers{
	public static cComplexNumber cCreateComplexNumber(double re, double im){
		cComplexNumber z;

		z = new cComplexNumber();
		z.re = re;
		z.im = im;

		return z;
	}

	public static cPolarComplexNumber cCreatePolarComplexNumber(double r, double phi){
		cPolarComplexNumber p;

		p = new cPolarComplexNumber();
		p.r = r;
		p.phi = phi;

		return p;
	}

	public static void cAdd(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = a + c;
		z1.im = b + d;
	}

	public static cComplexNumber cAddToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = a + c;
		x.im = b + d;

		return x;
	}

	public static void cSub(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = a - c;
		z1.im = b - d;
	}

	public static cComplexNumber cSubToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = a - c;
		x.im = b - d;

		return x;
	}

	public static void cMul(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = a*c - b*d;
		z1.im = b*c + a*d;
	}

	public static cComplexNumber cMulToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = a*c - b*d;
		x.im = b*c + a*d;

		return x;
	}

	public static void cDiv(cComplexNumber z1, cComplexNumber z2){
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		z1.re = (a*c + b*d)/(pow(c, 2d) + pow(d, 2d));
		z1.im = (b*c - a*d)/(pow(c, 2d) + pow(d, 2d));
	}

	public static cComplexNumber cDivToNew(cComplexNumber z1, cComplexNumber z2){
		cComplexNumber x;
		double a, b, c, d;

		a = z1.re;
		b = z1.im;
		c = z2.re;
		d = z2.im;

		x = new cComplexNumber();

		x.re = (a*c + b*d)/(pow(c, 2d) + pow(d, 2d));
		x.im = (b*c - a*d)/(pow(c, 2d) + pow(d, 2d));

		return x;
	}

	public static void cConjugate(cComplexNumber z){
		z.im = -z.im;
	}

	public static cComplexNumber cConjugateToNew(cComplexNumber z){
		cComplexNumber x;

		x = new cComplexNumber();

		x.re = z.re;
		x.im = -z.im;

		return x;
	}

	public static double cAbs(cComplexNumber z){
		double x;

		x = sqrt(pow(z.re, 2d) + pow(z.im, 2d));

		return x;
	}

	public static double cArg(cComplexNumber z){
		double x;

		x = Atan2(z.im, z.re);

		return x;
	}

	public static cPolarComplexNumber cCreatePolarFromComplexNumber(cComplexNumber z){
		cPolarComplexNumber x;

		x = new cPolarComplexNumber();

		x.r = cAbs(z);
		x.phi = cArg(z);

		return x;
	}

	public static cComplexNumber cCreateComplexFromPolar(cPolarComplexNumber p){
		cComplexNumber z;

		z = new cComplexNumber();

		z.re = p.r*cos(p.phi);
		z.im = p.r*sin(p.phi);

		return z;
	}

	public static double cRe(cComplexNumber z){
		return z.re;
	}

	public static double cIm(cComplexNumber z){
		return z.im;
	}

	public static void cAddPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cAdd(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		p1.r = x.r;
		p1.phi = x.phi;

		delete(z1);
		delete(z2);
		delete(x);
	}

	public static cPolarComplexNumber cAddPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cAdd(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		delete(z1);
		delete(z2);

		return x;
	}

	public static void cSubPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cSub(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		p1.r = x.r;
		p1.phi = x.phi;

		delete(z1);
		delete(z2);
		delete(x);
	}

	public static cPolarComplexNumber cSubPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		cComplexNumber z1, z2;

		z1 = cCreateComplexFromPolar(p1);
		z2 = cCreateComplexFromPolar(p2);

		cSub(z1, z2);

		x = cCreatePolarFromComplexNumber(z1);

		delete(z1);
		delete(z2);

		return x;
	}

	public static void cMulPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		p1.r = r1*r2;
		p1.phi = phi1 + phi2;
	}

	public static cPolarComplexNumber cMulPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		x = new cPolarComplexNumber();

		x.r = r1*r2;
		x.phi = phi1 + phi2;

		return x;
	}

	public static void cDivPolar(cPolarComplexNumber p1, cPolarComplexNumber p2){
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		p1.r = r1/r2;
		p1.phi = phi1 - phi2;
	}

	public static cPolarComplexNumber cDivPolarToNew(cPolarComplexNumber p1, cPolarComplexNumber p2){
		cPolarComplexNumber x;
		double r1, r2, phi1, phi2;

		r1 = p1.r;
		r2 = p2.r;
		phi1 = p1.phi;
		phi2 = p2.phi;

		x = new cPolarComplexNumber();

		x.r = r1/r2;
		x.phi = phi1 - phi2;

		return x;
	}

	public static void cSquareRoot(cComplexNumber z){
		double a, b, m;

		a = z.re;
		b = z.im;

		m = sqrt(pow(a, 2d) + pow(b, 2d));

		z.re = sqrt((m + a)/2d);
		z.im = Sign(b)*sqrt((m - a)/2d);
	}

	public static void cPowerPolar(cPolarComplexNumber p, double n){
		p.r = pow(p.r, n);
		p.phi = p.phi*n;
	}

	public static cComplexNumber cPowerToNew(cComplexNumber z, double n){
		cPolarComplexNumber p;
		cComplexNumber zp;

		p = cCreatePolarFromComplexNumber(z);
		cPowerPolar(p, n);
		zp = cCreateComplexFromPolar(p);

		delete(p);

		return zp;
	}

	public static void cPower(cComplexNumber z, double n){
		cComplexNumber zp;

		zp = cPowerToNew(z, n);
		z.re = zp.re;
		z.im = zp.im;

		delete(zp);
	}

	public static void cNegate(cComplexNumber z){
		z.re = Negate(z.re);
		z.im = Negate(z.im);
	}

	public static void cAssignComplexByValues(cComplexNumber s, double re, double im){
		s.re = re;
		s.im = im;
	}

	public static void cAssignComplex(cComplexNumber a, cComplexNumber b){
		a.re = b.re;
		a.im = b.im;
	}

	public static boolean cEpsilonCompareComplex(cComplexNumber a, cComplexNumber b, double epsilon){
		return EpsilonCompare(a.re, b.re, epsilon) && EpsilonCompare(a.im, b.im, epsilon);
	}

	public static void cExpComplex(cComplexNumber x){
		double re, im;

		re = exp(x.re)*cos(x.im);
		im = exp(x.re)*sin(x.im);
		x.re = re;
		x.im = im;
	}

	public static void cSineComplex(cComplexNumber x){
		double re, im;

		re = sin(x.re)*Cosh(x.im);
		im = cos(x.re)*Sinh(x.im);
		x.re = re;
		x.im = im;
	}

	public static void cCosineComplex(cComplexNumber x){
		double re, im;

		re = cos(x.re)*Cosh(x.im);
		im = sin(x.re)*Sinh(x.im);
		x.re = re;
		x.im = im;
	}

	public static char [] cComplexToString(cComplexNumber a){
		char [] str, number;
		LinkedListCharacters ll;
		double i;

		ll = CreateLinkedListCharacter();

		number = CreateStringDecimalFromNumber(a.re);

		for(i = 0d; i < number.length; i = i + 1d){
			LinkedListAddCharacter(ll, number[(int)(i)]);
		}

		delete(number);

		if(a.im < 0d){
			LinkedListAddCharacter(ll, '-');
			number = CreateStringDecimalFromNumber(-a.im);
		}else{
			LinkedListAddCharacter(ll, '+');
			number = CreateStringDecimalFromNumber(a.im);
		}

		for(i = 0d; i < number.length; i = i + 1d){
			LinkedListAddCharacter(ll, number[(int)(i)]);
		}

		delete(number);

		LinkedListAddCharacter(ll, 'i');

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
