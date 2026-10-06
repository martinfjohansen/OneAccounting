package com.martinfjohansen.oneaccounting.Graphics2D.filters.Blur;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetTransparent;
import static java.lang.Math.max;
import static java.lang.Math.min;

public class Blur{
	public static RGBABitmapImage Blur(RGBABitmapImage src, double pixels){
		RGBABitmapImage dst;
		double x, y, w, h;

		w = ImageWidth(src);
		h = ImageHeight(src);
		dst = CreateImage(w, h, GetTransparent());

		for(x = 0d; x < w; x = x + 1d){
			for(y = 0d; y < h; y = y + 1d){
				SetPixel(dst, x, y, CreateBlurForPoint(src, x, y, pixels));
			}
		}

		return dst;
	}

	public static RGBA CreateBlurForPoint(RGBABitmapImage src, double x, double y, double pixels){
		RGBA rgba;
		double i, j, countColor, countTransparent;
		double fromx, tox, fromy, toy;
		double w, h;
		double alpha;

		w = ImageWidth(src);
		h = ImageHeight(src);

		rgba = new RGBA();
		rgba.r = 0d;
		rgba.g = 0d;
		rgba.b = 0d;
		rgba.a = 0d;

		fromx = x - pixels;
		fromx = max(fromx, 0d);

		tox = x + pixels;
		tox = min(tox, w - 1d);

		fromy = y - pixels;
		fromy = max(fromy, 0d);

		toy = y + pixels;
		toy = min(toy, h - 1d);

		countColor = 0d;
		countTransparent = 0d;
		for(i = fromx; i < tox; i = i + 1d){
			for(j = fromy; j < toy; j = j + 1d){
				alpha = src.x[(int)(i)].y[(int)(j)].a;
				if(alpha > 0d){
					rgba.r = rgba.r + src.x[(int)(i)].y[(int)(j)].r;
					rgba.g = rgba.g + src.x[(int)(i)].y[(int)(j)].g;
					rgba.b = rgba.b + src.x[(int)(i)].y[(int)(j)].b;
					countColor = countColor + 1d;
				}
				rgba.a = rgba.a + alpha;
				countTransparent = countTransparent + 1d;
			}
		}

		if(countColor > 0d){
			rgba.r = rgba.r/countColor;
			rgba.g = rgba.g/countColor;
			rgba.b = rgba.b/countColor;
		}else{
			rgba.r = 0d;
			rgba.g = 0d;
			rgba.b = 0d;
		}

		if(countTransparent > 0d){
			rgba.a = rgba.a/countTransparent;
		}else{
			rgba.a = 0d;
		}

		return rgba;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
