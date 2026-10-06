package com.martinfjohansen.oneaccounting.Bits.BooleanArray;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCreateBooleanArray;

public class BooleanArray{
	public static boolean [] CreateBooleanArrayFromNumber(double w, double size){
		boolean [] out;
		double p, j;

		out = arraysCreateBooleanArray(size, false);

		j = 0d;
		p = 1d;
		for(; p < w; ){
			p = p*2d;
			j = j + 1d;
		}

		for(; j >= 0d; j = j - 1d){
			if(w >= p){
				w = w - p;
				if(j < size){
					out[(int)(size - 1d - j)] = true;
				}
			}
			p = p/2d;
		}

		return out;
	}

	public static double BooleanArrayToNumber(boolean [] bits){
		double w, i, p;

		w = 0d;
		p = 1d;
		for(i = 31d; i >= 0d; i = i - 1d){
			if(bits[(int)(i)]){
				w = w + p;
			}
			p = p*2d;
		}

		return w;
	}

	public static boolean [] BooleanAnd(boolean [] a, boolean [] b){
		boolean [] out;
		double i, length;

		length = a.length;

		out = new boolean [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			out[(int)(i)] = a[(int)(i)] && b[(int)(i)];
		}
		return out;
	}

	public static boolean [] BooleanXor(boolean [] a, boolean [] b){
		boolean [] out;
		double i, length;

		length = a.length;

		out = new boolean [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			if(a[(int)(i)] || b[(int)(i)]){
				if(!(a[(int)(i)] && b[(int)(i)])){
					out[(int)(i)] = true;
				}
			}
		}
		return out;
	}

	public static boolean [] BooleanNot(boolean [] a){
		boolean [] out;
		double i, length;

		length = a.length;

		out = new boolean [(int)(length)];

		for(i = 0d; i < length; i = i + 1d){
			out[(int)(i)] = !a[(int)(i)];
		}
		return out;
	}

	public static boolean [] ShiftBitsRight4Byte(boolean [] w, double n){
		boolean [] wb;
		boolean [] ob;
		double i, it;
		boolean f;
		f = false;

		if(n == 0d){
			ob = w;
		}else{
			wb = w;
			ob = new boolean [32];

			for(i = 0d; i < 32d; i = i + 1d){
				it = i - n;

				if(it < 0d){
					f = false;
				}else{
					f = wb[(int)(it)];
				}

				ob[(int)(i)] = f;
			}
		}

		return ob;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
