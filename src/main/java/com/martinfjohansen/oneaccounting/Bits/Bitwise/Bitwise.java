package com.martinfjohansen.oneaccounting.Bits.Bitwise;

import static com.martinfjohansen.oneaccounting.math.math.math.Truncate;
import static java.lang.Math.*;

public class Bitwise{
	public static double And4Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned4Bytes(a);
		b = ToUnsigned4Bytes(b);

		for(i = 0d; i < 32d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d && bb == 1d){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double ToUnsigned4Bytes(double a){
		if(a < 0d){
			a = 4294967296d - Truncate((-a)%4294967296d);
		}else{
			a = Truncate(a%4294967296d);
		}
		return a;
	}

	public static double ToUnsigned2Bytes(double a){
		if(a < 0d){
			a = 65536d - Truncate((-a)%65536d);
		}else{
			a = Truncate(a%65536d);
		}
		return a;
	}

	public static double ToUnsignedByte(double a){
		if(a < 0d){
			a = 256d - Truncate((-a)%256d);
		}else{
			a = Truncate(a%256d);
		}
		return a;
	}

	public static double And2Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned2Bytes(a);
		b = ToUnsigned2Bytes(b);

		for(i = 0d; i < 16d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d && bb == 1d){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double AndByte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsignedByte(a);
		b = ToUnsignedByte(b);

		for(i = 0d; i < 8d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d && bb == 1d){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double Or4Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned4Bytes(a);
		b = ToUnsigned4Bytes(b);

		for(i = 0d; i < 32d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d || bb == 1d){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double Or2Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned2Bytes(a);
		b = ToUnsigned2Bytes(b);

		for(i = 0d; i < 16d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d || bb == 1d){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double OrByte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsignedByte(a);
		b = ToUnsignedByte(b);

		for(i = 0d; i < 8d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab == 1d || bb == 1d){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double Xor4Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned4Bytes(a);
		b = ToUnsigned4Bytes(b);

		for(i = 0d; i < 32d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab != bb){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double Xor2Byte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsigned2Bytes(a);
		b = ToUnsigned2Bytes(b);

		for(i = 0d; i < 16d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab != bb){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double XorByte(double a, double b){
		double byteVal, result, i, ab, bb;

		byteVal = 1d;
		result = 0d;

		a = ToUnsignedByte(a);
		b = ToUnsignedByte(b);

		for(i = 0d; i < 8d; i = i + 1d){
			ab = a%2d;
			bb = b%2d;

			if(ab != bb){
				result = result + byteVal;
			}

			a = floor(a/2d);
			b = floor(b/2d);
			byteVal = byteVal*2d;
		}

		return result;
	}

	public static double Not4Byte(double a){
		double result;

		a = ToUnsigned4Bytes(a);

		result = 4294967296d - a - 1d;

		return result;
	}

	public static double Not2Byte(double a){
		double result;

		a = ToUnsigned2Bytes(a);

		result = 65536d - a - 1d;

		return result;
	}

	public static double NotByte(double a){
		double result;

		a = ToUnsignedByte(a);

		result = 256d - a - 1d;

		return result;
	}

	public static double ShiftLeft4Byte(double a, double n){
		double result;

		a = Truncate(a%4294967296d);
		n = Truncate(max(n, 0d));

		result = a*pow(2d, n);

		return result;
	}

	public static double ShiftLeft2Byte(double a, double n){
		double result;

		a = Truncate(a%65536d);
		n = Truncate(max(n, 0d));

		result = a*pow(2d, n);

		return result;
	}

	public static double ShiftLeftByte(double a, double n){
		double result;

		a = Truncate(a%256d);
		n = Truncate(max(n, 0d));

		result = a*pow(2d, n);

		return result;
	}

	public static double ShiftRight4Byte(double a, double n){
		double result;

		a = Truncate(a%4294967296d);
		n = Truncate(max(n, 0d));

		result = Truncate(a/pow(2d, n));

		return result;
	}

	public static double ShiftRight2Byte(double a, double n){
		double result;

		a = Truncate(a%65536d);
		n = Truncate(max(n, 0d));

		result = Truncate(a/pow(2d, n));

		return result;
	}

	public static double ShiftRightByte(double a, double n){
		double result;

		a = Truncate(a%256d);
		n = Truncate(max(n, 0d));

		result = Truncate(a/pow(2d, n));

		return result;
	}

	public static double RotateLeft4Byte(double a, double n){
		double x;

		a = ToUnsigned4Bytes(a);
		n = Truncate(n);

		/*return (a << n) | (a >> (32 - n));*/
		/* Mask the upper bits first, then rotate.*/
		x = And4Byte(a, Not4Byte(ShiftLeft4Byte(1d, n) - 1d));
		x = Or4Byte(ShiftLeft4Byte(x, n), ShiftRight4Byte(a, (32d - n)));

		return x;
	}

	public static double RotateRight4Byte(double a, double n){
		double x;

		a = ToUnsigned4Bytes(a);
		n = Truncate(n);

		/* return (a >> d) | (a << (32 - n));*/
		/* Mask away the upper bits first, then perform the shift.*/
		x = And4Byte(a, ShiftLeft4Byte(1d, n) - 1d);
		x = Or4Byte(ShiftRight4Byte(a, n), ShiftLeft4Byte(x, 32d - n));

		return x;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
