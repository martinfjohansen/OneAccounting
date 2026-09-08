package com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic30d;

public class FixedPointArithmetic30d{
	public static FixedPoint30d CreateFixedPoint30d(double digitsBeforeDecimalPoint, double digitsAfterDecimalPoint){
		FixedPoint30d fp;

		fp = new FixedPoint30d();
		fp.digitsBeforeDecimalPoint = digitsBeforeDecimalPoint;
		fp.digitsAfterDecimalPoint = digitsAfterDecimalPoint;
		fp.part1 = 0d;
		fp.part2 = 0d;

		return fp;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
