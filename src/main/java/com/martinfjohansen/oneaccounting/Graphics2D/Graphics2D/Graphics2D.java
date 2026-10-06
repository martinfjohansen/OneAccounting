package com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmap;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetBlack;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetTransparent;
import static com.martinfjohansen.oneaccounting.math.math.math.Round;
import static com.martinfjohansen.oneaccounting.math.math.math.Sign;
import static java.lang.Math.*;

public class Graphics2D{
	public static RGBABitmapImage CreateImage(double w, double h, RGBA color){
		RGBABitmapImage image;
		double i, j;

		image = new RGBABitmapImage();
		image.x = new RGBABitmap[(int)(w)];
		for(i = 0d; i < w; i = i + 1d){
			image.x[(int)(i)] = new RGBABitmap();
			image.x[(int)(i)].y = new RGBA [(int)(h)];
			for(j = 0d; j < h; j = j + 1d){
				image.x[(int)(i)].y[(int)(j)] = new RGBA();
				SetPixel(image, i, j, color);
			}
		}

		return image;
	}

	public static void DeleteImage(RGBABitmapImage image){
		double i, j, w, h;

		w = ImageWidth(image);
		h = ImageHeight(image);

		for(i = 0d; i < w; i = i + 1d){
			for(j = 0d; j < h; j = j + 1d){
				delete(image.x[(int)(i)].y[(int)(j)]);
			}
			delete(image.x[(int)(i)]);
		}
		delete(image);
	}

	public static double ImageWidth(RGBABitmapImage image){
		return image.x.length;
	}

	public static double ImageHeight(RGBABitmapImage image){
		double height;

		if(ImageWidth(image) == 0d){
			height = 0d;
		}else{
			height = image.x[0].y.length;
		}

		return height;
	}

	public static void SetPixel(RGBABitmapImage image, double x, double y, RGBA color){
		if(x >= 0d && x < ImageWidth(image) && y >= 0d && y < ImageHeight(image)){
			image.x[(int)(x)].y[(int)(y)].a = color.a;
			image.x[(int)(x)].y[(int)(y)].r = color.r;
			image.x[(int)(x)].y[(int)(y)].g = color.g;
			image.x[(int)(x)].y[(int)(y)].b = color.b;
		}
	}

	public static void DrawPixel(RGBABitmapImage image, double x, double y, RGBA color){
		double ra, ga, ba, aa;
		double rb, gb, bb, ab;
		double ro, go, bo, ao;
		RGBA c;

		if(x >= 0d && x < ImageWidth(image) && y >= 0d && y < ImageHeight(image)){
			ra = color.r;
			ga = color.g;
			ba = color.b;
			aa = color.a;

			c = GetImagePixel(image, x, y);
			rb = c.r;
			gb = c.g;
			bb = c.b;
			ab = c.a;

			ao = CombineAlpha(aa, ab);

			ro = AlphaBlend(ra, aa, rb, ab, ao);
			go = AlphaBlend(ga, aa, gb, ab, ao);
			bo = AlphaBlend(ba, aa, bb, ab, ao);

			image.x[(int)(x)].y[(int)(y)].r = ro;
			image.x[(int)(x)].y[(int)(y)].g = go;
			image.x[(int)(x)].y[(int)(y)].b = bo;
			image.x[(int)(x)].y[(int)(y)].a = ao;
		}
	}

	public static double CombineAlpha(double as, double ad){
		return as + ad*(1d - as);
	}

	public static double AlphaBlend(double cs, double as, double cd, double ad, double ao){
		return (cs*as + cd*ad*(1d - as))/ao;
	}

	public static void DrawHorizontalLine1px(RGBABitmapImage image, double x, double y, double length, RGBA color){
		double i;

		for(i = 0d; i < length; i = i + 1d){
			DrawPixel(image, x + i, y, color);
		}
	}

	public static void DrawVerticalLine1px(RGBABitmapImage image, double x, double y, double height, RGBA color){
		double i;

		for(i = 0d; i < height; i = i + 1d){
			DrawPixel(image, x, y + i, color);
		}
	}

	public static void DrawRectangle1px(RGBABitmapImage image, double x, double y, double width, double height, RGBA color){
		DrawHorizontalLine1px(image, x, y, width + 1d, color);
		DrawVerticalLine1px(image, x, y + 1d, height + 1d - 1d, color);
		DrawVerticalLine1px(image, x + width, y + 1d, height + 1d - 1d, color);
		DrawHorizontalLine1px(image, x + 1d, y + height, width + 1d - 2d, color);
	}

	public static void DrawImageOnImage(RGBABitmapImage dst, RGBABitmapImage src, double topx, double topy){
		double y, x;

		for(y = 0d; y < ImageHeight(src); y = y + 1d){
			for(x = 0d; x < ImageWidth(src); x = x + 1d){
				if(topx + x >= 0d && topx + x < ImageWidth(dst) && topy + y >= 0d && topy + y < ImageHeight(dst)){
					DrawPixel(dst, topx + x, topy + y, GetImagePixel(src, x, y));
				}
			}
		}
	}

	public static void DrawLine1px(RGBABitmapImage image, double x0, double y0, double x1, double y1, RGBA color){
		XiaolinWusLineAlgorithm(image, x0, y0, x1, y1, color);
	}

	public static void XiaolinWusLineAlgorithm(RGBABitmapImage image, double x0, double y0, double x1, double y1, RGBA color){
		boolean steep;
		double x, t, dx, dy, g, xEnd, yEnd, xGap, xpxl1, ypxl1, intery, xpxl2, ypxl2, olda;

		olda = color.a;

		steep = abs(y1 - y0) > abs(x1 - x0);

		if(steep){
			t = x0;
			x0 = y0;
			y0 = t;

			t = x1;
			x1 = y1;
			y1 = t;
		}
		if(x0 > x1){
			t = x0;
			x0 = x1;
			x1 = t;

			t = y0;
			y0 = y1;
			y1 = t;
		}

		dx = x1 - x0;
		dy = y1 - y0;
		g = dy/dx;

		if(dx == 0d){
			g = 1d;
		}

		xEnd = Round(x0);
		yEnd = y0 + g*(xEnd - x0);
		xGap = OneMinusFractionalPart(x0 + 0.5);
		xpxl1 = xEnd;
		ypxl1 = floor(yEnd);
		if(steep){
			DrawPixel(image, ypxl1, xpxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, ypxl1 + 1d, xpxl1, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}else{
			DrawPixel(image, xpxl1, ypxl1, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, xpxl1, ypxl1 + 1d, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}
		intery = yEnd + g;

		xEnd = Round(x1);
		yEnd = y1 + g*(xEnd - x1);
		xGap = FractionalPart(x1 + 0.5);
		xpxl2 = xEnd;
		ypxl2 = floor(yEnd);
		if(steep){
			DrawPixel(image, ypxl2, xpxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, ypxl2 + 1d, xpxl2, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}else{
			DrawPixel(image, xpxl2, ypxl2, SetBrightness(color, OneMinusFractionalPart(yEnd)*xGap));
			DrawPixel(image, xpxl2, ypxl2 + 1d, SetBrightness(color, FractionalPart(yEnd)*xGap));
		}

		if(steep){
			for(x = xpxl1 + 1d; x <= xpxl2 - 1d; x = x + 1d){
				DrawPixel(image, floor(intery), x, SetBrightness(color, OneMinusFractionalPart(intery)));
				DrawPixel(image, floor(intery) + 1d, x, SetBrightness(color, FractionalPart(intery)));
				intery = intery + g;
			}
		}else{
			for(x = xpxl1 + 1d; x <= xpxl2 - 1d; x = x + 1d){
				DrawPixel(image, x, floor(intery), SetBrightness(color, OneMinusFractionalPart(intery)));
				DrawPixel(image, x, floor(intery) + 1d, SetBrightness(color, FractionalPart(intery)));
				intery = intery + g;
			}
		}

		color.a = olda;
	}

	public static double OneMinusFractionalPart(double x){
		return 1d - FractionalPart(x);
	}

	public static double FractionalPart(double x){
		return x - floor(x);
	}

	public static RGBA SetBrightness(RGBA color, double newBrightness){
		color.a = newBrightness;
		return color;
	}

	public static void DrawQuadraticBezierCurve(RGBABitmapImage image, double x0, double y0, double cx, double cy, double x1, double y1, RGBA color){
		double t, dt, dx, dy;
		NumberReference xs, ys, xe, ye;

		dx = abs(x0 - x1);
		dy = abs(y0 - y1);

		dt = 1d/sqrt(pow(dx, 2d) + pow(dy, 2d));

		xs = new NumberReference();
		ys = new NumberReference();
		xe = new NumberReference();
		ye = new NumberReference();

		QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, 0d, xs, ys);
		for(t = dt; t <= 1d; t = t + dt){
			QuadraticBezierPoint(x0, y0, cx, cy, x1, y1, t, xe, ye);
			DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color);
			xs.numberValue = xe.numberValue;
			ys.numberValue = ye.numberValue;
		}

		delete(xs);
		delete(ys);
		delete(xe);
		delete(ye);
	}

	public static void QuadraticBezierPoint(double x0, double y0, double cx, double cy, double x1, double y1, double t, NumberReference x, NumberReference y){
		x.numberValue = pow(1d - t, 2d)*x0 + (1d - t)*2d*t*cx + pow(t, 2d)*x1;
		y.numberValue = pow(1d - t, 2d)*y0 + (1d - t)*2d*t*cy + pow(t, 2d)*y1;
	}

	public static void DrawCubicBezierCurve(RGBABitmapImage image, double x0, double y0, double c0x, double c0y, double c1x, double c1y, double x1, double y1, RGBA color){
		double t, dt, dx, dy;
		NumberReference xs, ys, xe, ye;

		dx = abs(x0 - x1);
		dy = abs(y0 - y1);

		dt = 1d/sqrt(pow(dx, 2d) + pow(dy, 2d));

		xs = new NumberReference();
		ys = new NumberReference();
		xe = new NumberReference();
		ye = new NumberReference();

		CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, 0d, xs, ys);
		for(t = dt; t <= 1d; t = t + dt){
			CubicBezierPoint(x0, y0, c0x, c0y, c1x, c1y, x1, y1, t, xe, ye);
			DrawLine1px(image, xs.numberValue, ys.numberValue, xe.numberValue, ye.numberValue, color);
			xs.numberValue = xe.numberValue;
			ys.numberValue = ye.numberValue;
		}

		delete(xs);
		delete(ys);
		delete(xe);
		delete(ye);
	}

	public static void CubicBezierPoint(double x0, double y0, double c0x, double c0y, double c1x, double c1y, double x1, double y1, double t, NumberReference x, NumberReference y){
		x.numberValue = pow(1d - t, 3d)*x0 + pow(1d - t, 2d)*3d*t*c0x + (1d - t)*3d*pow(t, 2d)*c1x + pow(t, 3d)*x1;

		y.numberValue = pow(1d - t, 3d)*y0 + pow(1d - t, 2d)*3d*t*c0y + (1d - t)*3d*pow(t, 2d)*c1y + pow(t, 3d)*y1;
	}

	public static RGBABitmapImage CopyImage(RGBABitmapImage image){
		RGBABitmapImage copy;
		double i, j;

		copy = CreateImage(ImageWidth(image), ImageHeight(image), GetTransparent());

		for(i = 0d; i < ImageWidth(image); i = i + 1d){
			for(j = 0d; j < ImageHeight(image); j = j + 1d){
				SetPixel(copy, i, j, GetImagePixel(image, i, j));
			}
		}

		return copy;
	}

	public static RGBA GetImagePixel(RGBABitmapImage image, double x, double y){
		return image.x[(int)(x)].y[(int)(y)];
	}

	public static void HorizontalFlip(RGBABitmapImage img){
		double y, x;
		double tmp;
		RGBA c1, c2;

		for(y = 0d; y < ImageHeight(img); y = y + 1d){
			for(x = 0d; x < ImageWidth(img)/2d; x = x + 1d){
				c1 = GetImagePixel(img, x, y);
				c2 = GetImagePixel(img, ImageWidth(img) - 1d - x, y);

				tmp = c1.a;
				c1.a = c2.a;
				c2.a = tmp;

				tmp = c1.r;
				c1.r = c2.r;
				c2.r = tmp;

				tmp = c1.g;
				c1.g = c2.g;
				c2.g = tmp;

				tmp = c1.b;
				c1.b = c2.b;
				c2.b = tmp;
			}
		}
	}

	public static void DrawFilledRectangle(RGBABitmapImage image, double x, double y, double w, double h, RGBA color){
		double i, j;

		for(i = 0d; i < w; i = i + 1d){
			for(j = 0d; j < h; j = j + 1d){
				SetPixel(image, x + i, y + j, color);
			}
		}
	}

	public static RGBABitmapImage RotateAntiClockwise90Degrees(RGBABitmapImage image){
		RGBABitmapImage rotated;
		double x, y;

		rotated = CreateImage(ImageHeight(image), ImageWidth(image), GetBlack());

		for(y = 0d; y < ImageHeight(image); y = y + 1d){
			for(x = 0d; x < ImageWidth(image); x = x + 1d){
				SetPixel(rotated, y, ImageWidth(image) - 1d - x, GetImagePixel(image, x, y));
			}
		}

		return rotated;
	}

	public static void DrawCircle(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		DrawCircleBasicAlgorithm(canvas, xCenter, yCenter, radius, color);
	}

	public static void BresenhamsCircleDrawingAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double x, y, delta;

		y = radius;
		x = 0d;

		delta = 3d - 2d*radius;
		for(; y >= x; x = x + 1d){
			DrawLine1px(canvas, xCenter + x, yCenter + y, xCenter + x, yCenter + y, color);
			DrawLine1px(canvas, xCenter + x, yCenter - y, xCenter + x, yCenter - y, color);
			DrawLine1px(canvas, xCenter - x, yCenter + y, xCenter - x, yCenter + y, color);
			DrawLine1px(canvas, xCenter - x, yCenter - y, xCenter - x, yCenter - y, color);

			DrawLine1px(canvas, xCenter - y, yCenter + x, xCenter - y, yCenter + x, color);
			DrawLine1px(canvas, xCenter - y, yCenter - x, xCenter - y, yCenter - x, color);
			DrawLine1px(canvas, xCenter + y, yCenter + x, xCenter + y, yCenter + x, color);
			DrawLine1px(canvas, xCenter + y, yCenter - x, xCenter + y, yCenter - x, color);

			if(delta < 0d){
				delta = delta + 4d*x + 6d;
			}else{
				delta = delta + 4d*(x - y) + 10d;
				y = y - 1d;
			}
		}
	}

	public static void DrawCircleMidpointAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double d, x, y;

		d = floor((5d - radius*4d)/4d);
		x = 0d;
		y = radius;

		for(; x <= y; x = x + 1d){
			DrawPixel(canvas, xCenter + x, yCenter + y, color);
			DrawPixel(canvas, xCenter + x, yCenter - y, color);
			DrawPixel(canvas, xCenter - x, yCenter + y, color);
			DrawPixel(canvas, xCenter - x, yCenter - y, color);
			DrawPixel(canvas, xCenter + y, yCenter + x, color);
			DrawPixel(canvas, xCenter + y, yCenter - x, color);
			DrawPixel(canvas, xCenter - y, yCenter + x, color);
			DrawPixel(canvas, xCenter - y, yCenter - x, color);

			if(d < 0d){
				d = d + 2d*x + 1d;
			}else{
				d = d + 2d*(x - y) + 1d;
				y = y - 1d;
			}
		}
	}

	public static void DrawCircleBasicAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double pixels, a, da, dx, dy;

		/* Place the circle in the center of the pixel.*/
		xCenter = floor(xCenter) + 0.5;
		yCenter = floor(yCenter) + 0.5;

		pixels = 2d*PI*radius;

		/* Below a radius of 10 pixels, over-compensate to get a smoother circle.*/
		if(radius < 10d){
			pixels = pixels*10d;
		}

		da = 2d*PI/pixels;

		for(a = 0d; a < 2d*PI; a = a + da){
			dx = cos(a)*radius;
			dy = sin(a)*radius;

			/* Floor to get the pixel coordinate.*/
			DrawPixel(canvas, floor(xCenter + dx), floor(yCenter + dy), color);
		}
	}

	public static void DrawFilledCircle(RGBABitmapImage canvas, double x, double y, double r, RGBA color){
		DrawFilledCircleBasicAlgorithm(canvas, x, y, r, color);
	}

	public static void DrawFilledCircleMidpointAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double d, x, y;

		d = floor((5d - radius*4d)/4d);
		x = 0d;
		y = radius;

		for(; x <= y; x = x + 1d){
			DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter + y, xCenter - x, yCenter + y, color);
			DrawLineBresenhamsAlgorithm(canvas, xCenter + x, yCenter - y, xCenter - x, yCenter - y, color);
			DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter + x, xCenter - y, yCenter + x, color);
			DrawLineBresenhamsAlgorithm(canvas, xCenter + y, yCenter - x, xCenter - y, yCenter - x, color);

			if(d < 0d){
				d = d + 2d*x + 1d;
			}else{
				d = d + 2d*(x - y) + 1d;
				y = y - 1d;
			}
		}
	}

	public static void DrawFilledCircleBasicAlgorithm(RGBABitmapImage canvas, double xCenter, double yCenter, double radius, RGBA color){
		double pixels, a, da, dx, dy;

		/* Place the circle in the center of the pixel.*/
		xCenter = floor(xCenter) + 0.5;
		yCenter = floor(yCenter) + 0.5;

		pixels = 2d*PI*radius;

		/* Below a radius of 10 pixels, over-compensate to get a smoother circle.*/
		if(radius < 10d){
			pixels = pixels*10d;
		}

		da = 2d*PI/pixels;

		/* Draw lines for a half-circle to fill an entire circle.*/
		for(a = 0d; a < PI; a = a + da){
			dx = cos(a)*radius;
			dy = sin(a)*radius;

			/* Floor to get the pixel coordinate.*/
			DrawVerticalLine1px(canvas, floor(xCenter - dx), floor(yCenter - dy), floor(2d*dy) + 1d, color);
		}
	}

	public static void DrawTriangle(RGBABitmapImage canvas, double xCenter, double yCenter, double height, RGBA color){
		double x1, y1, x2, y2, x3, y3;

		x1 = floor(xCenter + 0.5);
		y1 = floor(floor(yCenter + 0.5) - height);
		x2 = x1 - 2d*height*tan(PI/6d);
		y2 = floor(y1 + 2d*height);
		x3 = x1 + 2d*height*tan(PI/6d);
		y3 = floor(y1 + 2d*height);

		DrawLine1px(canvas, x1, y1, x2, y2, color);
		DrawLine1px(canvas, x1, y1, x3, y3, color);
		DrawLine1px(canvas, x2, y2, x3, y3, color);
	}

	public static void DrawFilledTriangle(RGBABitmapImage canvas, double xCenter, double yCenter, double height, RGBA color){
		double i, offset, x1, y1;

		x1 = floor(xCenter + 0.5);
		y1 = floor(floor(yCenter + 0.5) - height);

		for(i = 0d; i <= 2d*height; i = i + 1d){
			offset = floor(i*tan(PI/6d));
			DrawHorizontalLine1px(canvas, x1 - offset, y1 + i, 2d*offset, color);
		}
	}

	public static void DrawLine(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, double thickness, RGBA color){
		DrawLineBresenhamsAlgorithmThick(canvas, x1, y1, x2, y2, thickness, color);
	}

	public static void DrawLineBresenhamsAlgorithmThick(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, double thickness, RGBA color){
		double x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r;

		dx = x2 - x1;
		dy = y2 - y1;

		incX = Sign(dx);
		incY = Sign(dy);

		dx = abs(dx);
		dy = abs(dy);

		if(dx > dy){
			pdx = incX;
			pdy = 0d;
			es = dy;
			el = dx;
		}else{
			pdx = 0d;
			pdy = incY;
			es = dx;
			el = dy;
		}

		x = x1;
		y = y1;
		err = el/2d;

		if(thickness >= 3d){
			r = thickness/2d;
			DrawCircle(canvas, x, y, r, color);
		}else if(floor(thickness) == 2d){
			DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
		}else if(floor(thickness) == 1d){
			DrawPixel(canvas, x, y, color);
		}

		for(t = 0d; t < el; t = t + 1d){
			err = err - es;
			if(err < 0d){
				err = err + el;
				x = x + incX;
				y = y + incY;
			}else{
				x = x + pdx;
				y = y + pdy;
			}

			if(thickness >= 3d){
				r = thickness/2d;
				DrawCircle(canvas, x, y, r, color);
			}else if(floor(thickness) == 2d){
				DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
			}else if(floor(thickness) == 1d){
				DrawPixel(canvas, x, y, color);
			}
		}
	}

	public static void DrawLineBresenhamsAlgorithm(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, RGBA color){
		double x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t;

		dx = x2 - x1;
		dy = y2 - y1;

		incX = Sign(dx);
		incY = Sign(dy);

		dx = abs(dx);
		dy = abs(dy);

		if(dx > dy){
			pdx = incX;
			pdy = 0d;
			es = dy;
			el = dx;
		}else{
			pdx = 0d;
			pdy = incY;
			es = dx;
			el = dy;
		}

		x = x1;
		y = y1;
		err = el/2d;
		DrawPixel(canvas, x, y, color);

		for(t = 0d; t < el; t = t + 1d){
			err = err - es;
			if(err < 0d){
				err = err + el;
				x = x + incX;
				y = y + incY;
			}else{
				x = x + pdx;
				y = y + pdy;
			}

			DrawPixel(canvas, x, y, color);
		}
	}

	public static void DrawLineBresenhamsAlgorithmThickPatterned(RGBABitmapImage canvas, double x1, double y1, double x2, double y2, double thickness, boolean [] pattern, NumberReference offset, RGBA color){
		double x, y, dx, dy, incX, incY, pdx, pdy, es, el, err, t, r;

		dx = x2 - x1;
		dy = y2 - y1;

		incX = Sign(dx);
		incY = Sign(dy);

		dx = abs(dx);
		dy = abs(dy);

		if(dx > dy){
			pdx = incX;
			pdy = 0d;
			es = dy;
			el = dx;
		}else{
			pdx = 0d;
			pdy = incY;
			es = dx;
			el = dy;
		}

		x = x1;
		y = y1;
		err = el/2d;

		offset.numberValue = (offset.numberValue + 1d)%(pattern.length*thickness);

		if(pattern[(int)(floor(offset.numberValue/thickness))]){
			if(thickness >= 3d){
				r = thickness/2d;
				DrawCircle(canvas, x, y, r, color);
			}else if(floor(thickness) == 2d){
				DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
			}else if(floor(thickness) == 1d){
				DrawPixel(canvas, x, y, color);
			}
		}

		for(t = 0d; t < el; t = t + 1d){
			err = err - es;
			if(err < 0d){
				err = err + el;
				x = x + incX;
				y = y + incY;
			}else{
				x = x + pdx;
				y = y + pdy;
			}

			offset.numberValue = (offset.numberValue + 1d)%(pattern.length*thickness);

			if(pattern[(int)(floor(offset.numberValue/thickness))]){
				if(thickness >= 3d){
					r = thickness/2d;
					DrawCircle(canvas, x, y, r, color);
				}else if(floor(thickness) == 2d){
					DrawFilledRectangle(canvas, x, y, 2d, 2d, color);
				}else if(floor(thickness) == 1d){
					DrawPixel(canvas, x, y, color);
				}
			}
		}
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
