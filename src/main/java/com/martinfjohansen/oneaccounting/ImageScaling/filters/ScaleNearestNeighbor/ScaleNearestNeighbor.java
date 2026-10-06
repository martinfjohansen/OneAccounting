package com.martinfjohansen.oneaccounting.ImageScaling.filters.ScaleNearestNeighbor;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetTransparent;
import static com.martinfjohansen.oneaccounting.math.math.math.Round;
import static java.lang.Math.min;

public class ScaleNearestNeighbor{
	public static RGBABitmapImage ScaleNearestNeighborFactor(RGBABitmapImage src, double factor){
		RGBABitmapImage dst;
		double w, h, newWidth, newHeight;

		w = ImageWidth(src);
		h = ImageHeight(src);

		newWidth = Round(w*factor);
		newHeight = Round(h*factor);

		dst = ScaleNearestNeighbor(src, newWidth, newHeight);

		return dst;
	}

	public static RGBABitmapImage ScaleNearestNeighbor(RGBABitmapImage src, double newWidth, double newHeight){
		RGBABitmapImage dst;
		double x, y;

		dst = CreateImage(newWidth, newHeight, GetTransparent());

		for(x = 0d; x < newWidth; x = x + 1d){
			for(y = 0d; y < newHeight; y = y + 1d){
				SetPixel(dst, x, y, GetNearestNeighbor(src, dst, x, y));
			}
		}

		return dst;
	}

	public static RGBA GetNearestNeighbor(RGBABitmapImage src, RGBABitmapImage dst, double x, double y){
		double nnx, nny, srcw, srch, dstw, dsth;

		srcw = ImageWidth(src);
		srch = ImageHeight(src);
		dstw = ImageWidth(dst);
		dsth = ImageHeight(dst);

		nnx = min(Round(x*srcw/dstw), srcw - 1d);
		nny = min(Round(y*srch/dsth), srch - 1d);

		return src.x[(int)(nnx)].y[(int)(nny)];
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
