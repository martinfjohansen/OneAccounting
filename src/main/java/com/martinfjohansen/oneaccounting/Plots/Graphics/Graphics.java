package com.martinfjohansen.oneaccounting.Plots.Graphics;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmap;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.DrawFilledRectangle;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.DrawRectangle1px;

public class Graphics{
	public static void DrawFilledRectangleWithBorder(RGBABitmapImage image, double x, double y, double w, double h, RGBA borderColor, RGBA fillColor){
		if(h > 0d && w > 0d){
			DrawFilledRectangle(image, x, y, w, h, fillColor);
			DrawRectangle1px(image, x, y, w, h, borderColor);
		}
	}

	public static RGBABitmapImageReference CreateRGBABitmapImageReference(){
		RGBABitmapImageReference reference;

		reference = new RGBABitmapImageReference();
		reference.image = new RGBABitmapImage();
		reference.image.x = new RGBABitmap[0];

		return reference;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
