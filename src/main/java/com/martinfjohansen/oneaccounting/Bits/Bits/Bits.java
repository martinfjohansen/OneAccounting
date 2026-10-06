package com.martinfjohansen.oneaccounting.Bits.Bits;

import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static java.lang.Math.floor;
import static java.lang.Math.pow;

public class Bits{
	public static double ReadNextBit(double [] data, NumberReference nextbit){
		double bytenr, bitnumber, bit, b;

		bytenr = floor(nextbit.numberValue/8d);
		bitnumber = nextbit.numberValue%8d;

		b = data[(int)(bytenr)];

		bit = floor(b/pow(2d, bitnumber))%2d;

		nextbit.numberValue = nextbit.numberValue + 1d;

		return bit;
	}

	public static double BitExtract(double b, double fromInc, double toInc){
		return floor(b/pow(2d, fromInc))%pow(2d, toInc + 1d - fromInc);
	}

	public static double ReadBitRange(double [] data, NumberReference nextbit, double length){
		double startbyte, endbyte;
		double startbit, endbit;
		double number, i;

		number = 0d;

		startbyte = floor(nextbit.numberValue/8d);
		endbyte = floor((nextbit.numberValue + length)/8d);

		startbit = nextbit.numberValue%8d;
		endbit = (nextbit.numberValue + length - 1d)%8d;

		if(startbyte == endbyte){
			number = BitExtract(data[(int)(startbyte)], startbit, endbit);
		}

		nextbit.numberValue = nextbit.numberValue + length;

		return number;
	}

	public static void SkipToBoundary(NumberReference nextbit){
		double skip;

		skip = 8d - nextbit.numberValue%8d;
		nextbit.numberValue = nextbit.numberValue + skip;
	}

	public static double ReadNextByteBoundary(double [] data, NumberReference nextbit){
		double bytenr, b;

		bytenr = floor(nextbit.numberValue/8d);
		b = data[(int)(bytenr)];
		nextbit.numberValue = nextbit.numberValue + 8d;

		return b;
	}

	public static double Read2bytesByteBoundary(double [] data, NumberReference nextbit){
		double r;

		r = 0d;
		r = r + pow(2d, 8d)*ReadNextByteBoundary(data, nextbit);
		r = r + ReadNextByteBoundary(data, nextbit);

		return r;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
