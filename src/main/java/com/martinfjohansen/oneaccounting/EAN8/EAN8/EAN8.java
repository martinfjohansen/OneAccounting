package com.martinfjohansen.oneaccounting.EAN8.EAN8;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.references.references.CharacterReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.CreateImage;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.DrawImageOnImage;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetWhite;
import static com.martinfjohansen.oneaccounting.ImageScaling.filters.BilinaerScaleUp.BilinaerScaleUp.BilinaerScaleUp;
import static com.martinfjohansen.oneaccounting.UPC.UPC.UPC.*;
import static com.martinfjohansen.oneaccounting.math.math.math.Round;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.GetSingleDigitCharacterFromNumberWithCheck;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.GetNumberFromNumberCharacterForBase;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateNumberReference;
import static java.lang.Math.ceil;
import static java.lang.Math.floor;


public class EAN8{
	public static RGBABitmapImage GenerateBarcodeEAN8(char [] code, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100;
		char c, character;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, symbolWidths;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Round(heightInMm*pixelsPerMm);
		w = Round(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (3d + 3d + 7d*4d + 5d + 7d*4d + 3d + 3d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 3d*moduleWidthWholePixels;
		leftQuietZonePixels = 3d*moduleWidthPixels;
		group1x = leftQuietZonePixels + 3d*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*3d + 4d)*moduleWidthPixels;
		betweenCharatcers = charwidth*92d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		for(i = 0d; i < code.length; i = i + 1d){
			c = code[(int)(i)];
			if(i <= 3d){
				widths = GetUPCLCodeWidths(c);
			}else{
				widths = GetUPCRCodeWidths(c);
			}
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);

			if(i == 3d){
				symbolWidths = GetUPCWidths(11d);
				DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);
			}
		}

		/* Checksum*/
		checksum = GetCalculateUPCChecksum(code);
		characterReference = new CharacterReference();
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10d, characterReference);
		character = characterReference.characterValue;
		delete(characterReference);
		symbolWidths = GetUPCRCodeWidths(character);
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, shortHeight, counterReference, moduleWidthWholePixels);

		/* Stop symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h);
		DrawImageOnImage(image, barcode, 0d, 0d);

		/* Draw digits*/
		for(i = 0d; i < code.length; i = i + 1d){
			digit = GetNumberFromNumberCharacterForBase(code[(int)(i)], 10d);
			if(i <= 3d){
				DrawDigitOnBarcode(image, group1x + i*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}else{
				DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 3d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
