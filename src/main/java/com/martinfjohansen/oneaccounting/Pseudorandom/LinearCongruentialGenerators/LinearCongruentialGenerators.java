package com.martinfjohansen.oneaccounting.Pseudorandom.LinearCongruentialGenerators;

import static java.lang.Math.floor;
import static java.lang.Math.pow;

public class LinearCongruentialGenerators{
	public static LinearCongruentialGenerator CreateLinearCongruentialGeneratorNumericalRecipes(double seed){
		return CreateLinearCongruentialGeneratorCustom(pow(2d, 29d), 1664525d, 1013904223d, seed);
	}

	public static LinearCongruentialGenerator CreateLinearCongruentialGeneratorCustom(double modulus, double multiplier, double increment, double seed){
		LinearCongruentialGenerator lcg;

		lcg = new LinearCongruentialGenerator();
		lcg.m = modulus;
		lcg.a = multiplier;
		lcg.c = increment;
		lcg.x = seed;

		return lcg;
	}

	public static double LinearCongruentialGeneratorNextNumber(LinearCongruentialGenerator lcg){
		lcg.x = floor((lcg.a*lcg.x + lcg.c)%lcg.m);

		return lcg.x/lcg.m;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
