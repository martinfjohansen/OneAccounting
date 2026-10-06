package com.martinfjohansen.oneaccounting.vectorVectorMath.VectorMath;

import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static java.lang.Math.*;


public class VectorMath{
	public static double [] vectorCreate2DVector(double a0, double a1){
		double [] vector;

		vector = new double [2];
		vector[0] = a0;
		vector[1] = a1;

		return vector;
	}

	public static double [] vectorCreate3DVector(double a0, double a1, double a2){
		double [] vector;

		vector = new double [3];
		vector[0] = a0;
		vector[1] = a1;
		vector[2] = a2;

		return vector;
	}

	public static double [] vectorCreate4DVector(double a0, double a1, double a2, double a3){
		double [] vector;

		vector = new double [4];
		vector[0] = a0;
		vector[1] = a1;
		vector[2] = a2;
		vector[3] = a3;

		return vector;
	}

	public static boolean vectorDotProductWithCheck(double [] a, double [] b, NumberReference answer, StringReference errorMessage){
		double sum;
		boolean success;

		sum = 0d;

		if(a.length == b.length){
			sum = vectorDotProduct(a, b);
			success = true;
		}else{
			errorMessage.string = "The dimensions have to be equal.".toCharArray();
			success = false;
		}

		answer.numberValue = sum;

		return success;
	}

	public static double vectorDotProduct(double [] a, double [] b){
		double sum, i;

		sum = 0d;
		/* Dot product is the sum of the products of the corresponding entries of two vectors.*/
		for(i = 0d; i < a.length; i = i + 1d){
			sum = sum + a[(int)(i)]*b[(int)(i)];
		}

		return sum;
	}

	public static double vectorMagnitude(double [] a){
		double sum, i;

		sum = 0d;

		for(i = 0d; i < a.length; i = i + 1d){
			sum = sum + pow(a[(int)(i)], 2d);
		}
		sum = sqrt(sum);

		return sum;
	}

	public static boolean vectorCrossProduct3dWithCheck(double [] a, double [] b, NumberArrayReference answer, StringReference errorMessage){
		double [] crossProduct;
		boolean success;

		crossProduct = new double [3];

		if(a.length == 3d && b.length == 3d){
			crossProduct[0] = a[1]*b[2] - b[1]*a[2];
			crossProduct[1] = a[2]*b[0] - b[2]*a[0];
			crossProduct[2] = a[0]*b[1] - b[0]*a[1];

			success = true;
		}else{
			errorMessage.string = "The dimensions must be 3.".toCharArray();
			success = false;
		}

		answer.numberArray = crossProduct;

		return success;
	}

	public static double vectorSum(double [] a){
		double s, i;

		s = 0d;

		for(i = 0d; i < a.length; i = i + 1d){
			s = s + a[(int)(i)];
		}

		return s;
	}

	public static double vectorProduct(double [] a){
		double p, i;

		p = 1d;

		for(i = 0d; i < a.length; i = i + 1d){
			p = p*a[(int)(i)];
		}

		return p;
	}

	public static void vectorCumulativeSum(double [] a){
		double s, i;

		s = 0d;

		for(i = 0d; i < a.length; i = i + 1d){
			s = s + a[(int)(i)];
			a[(int)(i)] = s;
		}
	}

	public static void vectorCumulativeProduct(double [] a){
		double p, i;

		p = 1d;

		for(i = 0d; i < a.length; i = i + 1d){
			p = p*a[(int)(i)];
			a[(int)(i)] = p;
		}
	}

	public static void vectorAdd(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] + b[(int)(i)];
		}
	}

	public static void vectorSubtract(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)] - b[(int)(i)];
		}
	}

	public static void vectorMultiply(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)]*b[(int)(i)];
		}
	}

	public static void vectorDivide(double [] a, double [] b){
		double i;

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			a[(int)(i)] = a[(int)(i)]/b[(int)(i)];
		}
	}

	public static double [] vectorAddToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(min(a.length, b.length))];

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)] + b[(int)(i)];
		}

		return c;
	}

	public static double [] vectorSubtractToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(min(a.length, b.length))];

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)] - b[(int)(i)];
		}

		return c;
	}

	public static double [] vectorMultiplyToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(min(a.length, b.length))];

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)]*b[(int)(i)];
		}

		return c;
	}

	public static double [] vectorDivideToNew(double [] a, double [] b){
		double i;
		double [] c;

		c = new double [(int)(min(a.length, b.length))];

		for(i = 0d; i < a.length && i < b.length; i = i + 1d){
			c[(int)(i)] = a[(int)(i)]/b[(int)(i)];
		}

		return c;
	}

	public static void vectorPower(double [] a, double p){
		double i;

		for(i = 0d; i < a.length; i = i + 1d){
			a[(int)(i)] = pow(a[(int)(i)], p);
		}
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
