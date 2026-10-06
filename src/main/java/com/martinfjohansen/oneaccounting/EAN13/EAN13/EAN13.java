package com.martinfjohansen.oneaccounting.EAN13.EAN13;

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


public class EAN13{
	public static RGBABitmapImage GenerateBarcodeEAN13(char [] code, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100;
		char c, type, character;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, group1Pattern, symbolWidths;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Round(heightInMm*pixelsPerMm);
		w = Round(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (11d + 3d + 7d*6d + 5d + 7d*6d + 7d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 11d*moduleWidthWholePixels;
		leftQuietZonePixels = 11d*moduleWidthPixels;
		group1x = leftQuietZonePixels + 3d*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*6d + 4d)*moduleWidthPixels;
		betweenCharatcers = charwidth*92d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		group1Pattern = GetEAN13Group1Pattern(code[0]);

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		for(i = 1d; i < code.length; i = i + 1d){
			c = code[(int)(i)];
			if(i <= 6d){
				type = group1Pattern[(int)(i - 1d)];
				if(type == 'L'){
					widths = GetUPCLCodeWidths(c);
				}else{
					widths = GetUPCGCodeWidths(c);
				}
			}else{
				widths = GetUPCRCodeWidths(c);
			}
			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);

			if(i == 6d){
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
			if(i == 0d){
				DrawDigitOnBarcode(image, 0d, textY, digit, pixelsPerMm, zoom);
			}else if(i <= 6d){
				DrawDigitOnBarcode(image, group1x + (i - 1d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}else{
				DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}

	public static char [] GetEAN13Group1Pattern(char code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == '0'){
			spaces = "LLLLLL".toCharArray();
		}
		if(code == '1'){
			spaces = "LLGLGG".toCharArray();
		}
		if(code == '2'){
			spaces = "LLGGLG".toCharArray();
		}
		if(code == '3'){
			spaces = "LLGGGL".toCharArray();
		}
		if(code == '4'){
			spaces = "LGLLGG".toCharArray();
		}
		if(code == '5'){
			spaces = "LGGLLG".toCharArray();
		}
		if(code == '6'){
			spaces = "LGGGLL".toCharArray();
		}
		if(code == '7'){
			spaces = "LGLGLG".toCharArray();
		}
		if(code == '8'){
			spaces = "LGLGGL".toCharArray();
		}
		if(code == '9'){
			spaces = "LGGLGL".toCharArray();
		}

		return spaces;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
