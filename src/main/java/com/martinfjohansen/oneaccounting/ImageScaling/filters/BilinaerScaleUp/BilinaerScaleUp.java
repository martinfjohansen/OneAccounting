package com.martinfjohansen.oneaccounting.ImageScaling.filters.BilinaerScaleUp;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetTransparent;
import static com.martinfjohansen.oneaccounting.math.math.math.Round;
import static java.lang.Math.*;

public class BilinaerScaleUp{
	public static RGBABitmapImage BilinaerScaleUpFactor(RGBABitmapImage src, double factor){
		RGBABitmapImage dst;
		double w, h, newWidth, newHeight;

		w = ImageWidth(src);
		h = ImageHeight(src);

		newWidth = Round(w*factor);
		newHeight = Round(h*factor);

		dst = BilinaerScaleUp(src, newWidth, newHeight);

		return dst;
	}

	public static RGBABitmapImage BilinaerScaleUp(RGBABitmapImage src, double newWidth, double newHeight){
		RGBABitmapImage dst;
		double x, y;

		dst = CreateImage(newWidth, newHeight, GetTransparent());

		for(y = 0d; y < newHeight; y = y + 1d){
			for(x = 0d; x < newWidth; x = x + 1d){
				SetPixel(dst, x, y, GetBilinearlyScaledPixel(src, dst, x, y));
			}
		}

		return dst;
	}

	public static RGBA GetBilinearlyScaledPixel(RGBABitmapImage src, RGBABitmapImage dst, double dstx, double dsty){
		double x1, y1, x2, y2, srcw, srch, dstw, dsth;
		RGBA x1y1, x2y1, x1y2, x2y2;
		RGBA result;
		double x, y;

		srcw = ImageWidth(src);
		srch = ImageHeight(src);
		dstw = ImageWidth(dst);
		dsth = ImageHeight(dst);

		x = dstx*srcw/dstw;
		y = dsty*srch/dsth;

		x = x + 0.25;
		y = y + 0.25;

		x1 = min(floor(x), srcw - 1d);
		x2 = min(ceil(x), srcw - 1d);
		y1 = min(floor(y), srch - 1d);
		y2 = min(ceil(y), srch - 1d);

		x1y1 = src.x[(int)(x1)].y[(int)(y1)];
		x1y2 = src.x[(int)(x1)].y[(int)(y2)];
		x2y1 = src.x[(int)(x2)].y[(int)(y1)];
		x2y2 = src.x[(int)(x2)].y[(int)(y2)];

		if(x1 == x2){
			x2 = x2 + 1d;
		}
		if(y1 == y2){
			y2 = y2 + 1d;
		}

		result = new RGBA();

		result.r = GetBilinearInterpolation(x1y1.r, x2y1.r, x1y2.r, x2y2.r, x, y, x1, x2, y1, y2);
		result.g = GetBilinearInterpolation(x1y1.g, x2y1.g, x1y2.g, x2y2.g, x, y, x1, x2, y1, y2);
		result.b = GetBilinearInterpolation(x1y1.b, x2y1.b, x1y2.b, x2y2.b, x, y, x1, x2, y1, y2);
		result.a = GetBilinearInterpolation(x1y1.a, x2y1.a, x1y2.a, x2y2.a, x, y, x1, x2, y1, y2);

		return result;
	}

	public static double GetBilinearInterpolation(double q11, double q12, double q21, double q22, double x, double y, double x1, double x2, double y1, double y2){
		double h1, h2, v;

		h1 = (x2 - x)/(x2 - x1)*q11 + (x - x1)/(x2 - x1)*q12;
		h2 = (x2 - x)/(x2 - x1)*q21 + (x - x1)/(x2 - x1)*q22;

		v = (y2 - y)/(y2 - y1)*h1 + (y - y1)/(y2 - y1)*h2;

		return v;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
