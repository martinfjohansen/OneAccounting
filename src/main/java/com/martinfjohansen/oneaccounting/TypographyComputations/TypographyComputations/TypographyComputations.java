package com.martinfjohansen.oneaccounting.TypographyComputations.TypographyComputations;


public class TypographyComputations{
	public static double DPIToDotsPerMm(double dpi){
		return dpi/25.4;
	}

	public static double DotsPerMmDPI(double dotsPerMm){
		return dotsPerMm*25.4;
	}

	public static double MmToInch(double mm){
		return mm/25.4;
	}

	public static double InchToMm(double inch){
		return inch*25.4;
	}

	public static double MmToDots(double mm, double dpi){
		return MmToInch(mm)*dpi;
	}

	public static double DotsToMm(double dots, double dpi){
		return InchToMm(dots/dpi);
	}

	public static double PtsToInch(double pts){
		return pts*1.0/72d;
	}

	public static double InchToPts(double inch){
		return inch*72d;
	}

	public static double PtsToMm(double pts){
		return InchToMm(PtsToInch(pts));
	}

	public static double MmToPts(double mm){
		return InchToPts(MmToInch(mm));
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
