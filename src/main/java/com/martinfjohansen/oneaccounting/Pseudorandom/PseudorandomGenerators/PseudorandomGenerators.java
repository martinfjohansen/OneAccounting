package com.martinfjohansen.oneaccounting.Pseudorandom.PseudorandomGenerators;

import static com.martinfjohansen.oneaccounting.Pseudorandom.LinearCongruentialGenerators.LinearCongruentialGenerators.CreateLinearCongruentialGeneratorNumericalRecipes;
import static com.martinfjohansen.oneaccounting.Pseudorandom.LinearCongruentialGenerators.LinearCongruentialGenerators.LinearCongruentialGeneratorNextNumber;
import static java.lang.Math.ceil;
import static java.lang.Math.floor;

public class PseudorandomGenerators{
	public static PseudorandomGenerator CreatePseudorandomNumberGenerator(double seed){
		PseudorandomGenerator prg;

		prg = new PseudorandomGenerator();
		prg.lcg = CreateLinearCongruentialGeneratorNumericalRecipes(seed);

		return prg;
	}

	public static double PseudorandomNextNumber(PseudorandomGenerator prg){
		return LinearCongruentialGeneratorNextNumber(prg.lcg);
	}

	public static double PseudorandomNextInteger(PseudorandomGenerator prg, double n){
		return floor(PseudorandomNextNumber(prg)*n);
	}

	public static double PseudorandomNextIntegerBetween(PseudorandomGenerator prg, double a, double b){
		return ceil(a) + floor(PseudorandomNextNumber(prg)*(b - a));
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
