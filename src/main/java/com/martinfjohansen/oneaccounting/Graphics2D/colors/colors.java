package com.martinfjohansen.oneaccounting.Graphics2D.colors;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;

public class colors{
	public static RGBA GetBlack(){
		RGBA black;
		black = new RGBA();
		black.a = 1d;
		black.r = 0d;
		black.g = 0d;
		black.b = 0d;
		return black;
	}

	public static RGBA GetWhite(){
		RGBA white;
		white = new RGBA();
		white.a = 1d;
		white.r = 1d;
		white.g = 1d;
		white.b = 1d;
		return white;
	}

	public static RGBA GetTransparent(){
		RGBA transparent;
		transparent = new RGBA();
		transparent.a = 0d;
		transparent.r = 0d;
		transparent.g = 0d;
		transparent.b = 0d;
		return transparent;
	}

	public static RGBA GetGray(double percentage){
		RGBA black;
		black = new RGBA();
		black.a = 1d;
		black.r = 1d - percentage;
		black.g = 1d - percentage;
		black.b = 1d - percentage;
		return black;
	}

	public static RGBA CreateRGBColor(double r, double g, double b){
		RGBA color;
		color = new RGBA();
		color.a = 1d;
		color.r = r;
		color.g = g;
		color.b = b;
		return color;
	}

	public static RGBA CreateRGBAColor(double r, double g, double b, double a){
		RGBA color;
		color = new RGBA();
		color.a = a;
		color.r = r;
		color.g = g;
		color.b = b;
		return color;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
