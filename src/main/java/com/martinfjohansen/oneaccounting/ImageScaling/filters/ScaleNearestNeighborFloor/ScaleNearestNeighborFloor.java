package com.martinfjohansen.oneaccounting.ImageScaling.filters.ScaleNearestNeighborFloor;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetTransparent;
import static com.martinfjohansen.oneaccounting.math.math.math.Round;
import static java.lang.Math.floor;

public class ScaleNearestNeighborFloor{
	public static RGBABitmapImage ScaleNearestNeighborFloorFactor(RGBABitmapImage src, double factor){
		RGBABitmapImage dst;
		double w, h, newWidth, newHeight;

		w = ImageWidth(src);
		h = ImageHeight(src);

		newWidth = Round(w*factor);
		newHeight = Round(h*factor);

		dst = ScaleNearestNeighborFloor(src, newWidth, newHeight);

		return dst;
	}

	public static RGBABitmapImage ScaleNearestNeighborFloor(RGBABitmapImage src, double newWidth, double newHeight){
		RGBABitmapImage dst;
		double x, y;

		dst = CreateImage(newWidth, newHeight, GetTransparent());

		for(x = 0d; x < newWidth; x = x + 1d){
			for(y = 0d; y < newHeight; y = y + 1d){
				SetPixel(dst, x, y, GetNearestNeighborFloor(src, dst, x, y));
			}
		}

		return dst;
	}

	public static RGBA GetNearestNeighborFloor(RGBABitmapImage src, RGBABitmapImage dst, double x, double y){
		double nnx, nny, srcw, srch, dstw, dsth;

		srcw = ImageWidth(src);
		srch = ImageHeight(src);
		dstw = ImageWidth(dst);
		dsth = ImageHeight(dst);

		nnx = floor(x*srcw/dstw);
		nny = floor(y*srch/dsth);

		return src.x[(int)(nnx)].y[(int)(nny)];
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
