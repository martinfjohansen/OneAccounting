package com.martinfjohansen.oneaccounting.UPCE.UPCE;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.references.references.CharacterReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.CreateImage;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.DrawImageOnImage;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetWhite;
import static com.martinfjohansen.oneaccounting.ImageScaling.filters.BilinaerScaleUp.BilinaerScaleUp.BilinaerScaleUp;
import static com.martinfjohansen.oneaccounting.UPC.UPC.UPC.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.math.math.math.Round;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.GetSingleDigitCharacterFromNumberWithCheck;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.GetNumberFromNumberCharacterForBase;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateNumberReference;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strSubstring;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strSubstringEquals;
import static java.lang.Math.ceil;
import static java.lang.Math.floor;


public class UPCE{
	public static char [] UPCAToUPCE(char [] a){
		char [] mfg, productCode, e;

		e = new char [7];
		e[0] = a[0];

		mfg = strSubstring(a, 1d, 6d);
		productCode = strSubstring(a, 6d, 11d);

		e[1] = mfg[0];
		e[2] = mfg[1];
		if((strSubstringEquals(mfg, 2d, "000".toCharArray()) || strSubstringEquals(mfg, 2d, "100".toCharArray()) || strSubstringEquals(mfg, 2d, "200".toCharArray())) && productCode[0] == '0' && productCode[1] == '0'){
			e[3] = productCode[2];
			e[4] = productCode[3];
			e[5] = productCode[4];
			e[6] = mfg[2];
		}else if(strSubstringEquals(mfg, 3d, "00".toCharArray()) && productCode[0] == '0' && productCode[1] == '0' && productCode[2] == '0'){
			e[3] = mfg[2];
			e[4] = productCode[3];
			e[5] = productCode[4];
			e[6] = '3';
		}else if(strSubstringEquals(mfg, 4d, "0".toCharArray()) && productCode[0] == '0' && productCode[1] == '0' && productCode[2] == '0' && productCode[3] == '0'){
			e[3] = mfg[2];
			e[4] = mfg[3];
			e[5] = productCode[4];
			e[6] = '4';
		}else if(arraysStringsEqual(productCode, "00005".toCharArray()) || arraysStringsEqual(productCode, "00006".toCharArray()) || arraysStringsEqual(productCode, "00006".toCharArray()) || arraysStringsEqual(productCode, "00007".toCharArray()) || arraysStringsEqual(productCode, "00008".toCharArray()) || arraysStringsEqual(productCode, "00009".toCharArray())){
			e[3] = mfg[2];
			e[4] = mfg[3];
			e[5] = mfg[4];
			e[6] = productCode[4];
		}

		return e;
	}

	public static char [] UPCEToUPCA(char [] e){
		char [] a;

		a = new char [11];

		a[0] = e[0];

		if(e[6] == '0' || e[6] == '1' || e[6] == '2'){
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[6];
			a[4] = '0';
			a[5] = '0';
			a[6] = '0';
			a[7] = '0';
			a[8] = e[3];
			a[9] = e[4];
			a[10] = e[5];
		}else if(e[6] == '3'){
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[3];
			a[4] = '0';
			a[5] = '0';
			a[6] = '0';
			a[7] = '0';
			a[8] = '0';
			a[9] = e[4];
			a[10] = e[5];
		}else if(e[6] == '4'){
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[3];
			a[4] = e[4];
			a[5] = '0';
			a[6] = '0';
			a[7] = '0';
			a[8] = '0';
			a[9] = '0';
			a[10] = e[5];
		}else{
			a[1] = e[1];
			a[2] = e[2];
			a[3] = e[3];
			a[4] = e[4];
			a[5] = e[5];
			a[6] = '0';
			a[7] = '0';
			a[8] = '0';
			a[9] = '0';
			a[10] = e[6];
		}

		return a;
	}

	public static RGBABitmapImage GenerateBarcodeUPCE(char [] e, double widthInMm, double heightInMm, double pixelsPerMm){
		double w, h, i, checksum, textY, longHeight, shortHeight, distanceToSecondGroup, betweenCharatcers, group1x, zoom, textheight, textQuietZone;
		double charwidth, leftQuietZoneWholePixels, moduleWidthWholePixels, moduleWidthPixels, leftQuietZonePixels, digit, zoom100, distanceToThirdGroup;
		char c, character, type;
		RGBABitmapImage image, uninterpolatedBarcode, barcode;
		char [] widths, symbolWidths, a, pattern;
		NumberReference counterReference;
		CharacterReference characterReference;

		h = Round(heightInMm*pixelsPerMm);
		w = Round(widthInMm*pixelsPerMm);

		image = CreateImage(w, h, GetWhite());

		zoom100 = (9d + 3d + 7d*6d + 5d + 7d)*0.33;

		zoom = widthInMm/zoom100;
		textheight = zoom*3.08;
		charwidth = textheight*30d/37d;
		textQuietZone = textheight*5d/100d;
		textY = h - textheight*pixelsPerMm;
		shortHeight = textY - textQuietZone*pixelsPerMm;
		longHeight = textY + (textQuietZone + textheight)*pixelsPerMm/2d;
		moduleWidthPixels = 0.33*zoom*pixelsPerMm;
		moduleWidthWholePixels = floor(moduleWidthPixels);
		leftQuietZoneWholePixels = 9d*moduleWidthWholePixels;
		leftQuietZonePixels = 9d*moduleWidthPixels;
		group1x = leftQuietZonePixels + (3d + 1d)*moduleWidthPixels;
		distanceToSecondGroup = group1x + (7d*6d + 5d)*moduleWidthPixels;
		betweenCharatcers = charwidth*89d/100d*pixelsPerMm;

		uninterpolatedBarcode = CreateImage(ceil(w*moduleWidthWholePixels/moduleWidthPixels), h, GetWhite());

		counterReference = CreateNumberReference(leftQuietZoneWholePixels);

		/* Checksum*/
		a = UPCEToUPCA(e);
		checksum = GetCalculateUPCChecksum(a);
		characterReference = new CharacterReference();
		GetSingleDigitCharacterFromNumberWithCheck(checksum, 10d, characterReference);
		character = characterReference.characterValue;

		/* Start symbol*/
		symbolWidths = GetUPCWidths(GetUPCStartAndStopCode());
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, symbolWidths, longHeight, counterReference, moduleWidthWholePixels);

		pattern = GetUPCEPattern(character, e[0]);

		for(i = 1d; i < e.length; i = i + 1d){
			c = e[(int)(i)];
			type = pattern[(int)(i - 1d)];
			if(type == 'O'){
				widths = GetUPCLCodeWidths(c);
			}else{
				widths = GetUPCGCodeWidths(c);
			}

			DrawBarcodeUPCSymbol(uninterpolatedBarcode, widths, shortHeight, counterReference, moduleWidthWholePixels);
		}

		/* Stop symbol*/
		DrawBarcodeUPCSymbol(uninterpolatedBarcode, "010101".toCharArray(), longHeight, counterReference, moduleWidthWholePixels);

		barcode = BilinaerScaleUp(uninterpolatedBarcode, w, h);
		DrawImageOnImage(image, barcode, 0d, 0d);

		/* Draw digits*/
		for(i = 0d; i < e.length; i = i + 1d){
			digit = GetNumberFromNumberCharacterForBase(e[(int)(i)], 10d);
			if(i == 0d){
				DrawDigitOnBarcode(image, 0d, textY, digit, pixelsPerMm, zoom);
			}else if(i <= 6d){
				DrawDigitOnBarcode(image, group1x + (i - 1d)*betweenCharatcers, textY, digit, pixelsPerMm, zoom);
			}
		}
		DrawDigitOnBarcode(image, distanceToSecondGroup + (i - 7d)*betweenCharatcers, textY, checksum, pixelsPerMm, zoom);

		return image;
	}

	public static char [] GetUPCEPattern(char check, char system){
		char [] spaces;

		spaces = "".toCharArray();

		if(system == '0'){
			if(check == '0'){
				spaces = "EEEOOO".toCharArray();
			}
			if(check == '1'){
				spaces = "EEOEOO".toCharArray();
			}
			if(check == '2'){
				spaces = "EEOOEO".toCharArray();
			}
			if(check == '3'){
				spaces = "EEOOOE".toCharArray();
			}
			if(check == '4'){
				spaces = "EOEEOO".toCharArray();
			}
			if(check == '5'){
				spaces = "EOOEEO".toCharArray();
			}
			if(check == '6'){
				spaces = "EOOOEE".toCharArray();
			}
			if(check == '7'){
				spaces = "EOEOEO".toCharArray();
			}
			if(check == '8'){
				spaces = "EOEOOE".toCharArray();
			}
			if(check == '9'){
				spaces = "EOOEOE".toCharArray();
			}
		}else if(system == '1'){
			if(check == '0'){
				spaces = "OOOEEE".toCharArray();
			}
			if(check == '1'){
				spaces = "OOEOEE".toCharArray();
			}
			if(check == '2'){
				spaces = "OOEEOE".toCharArray();
			}
			if(check == '3'){
				spaces = "OOEEEO".toCharArray();
			}
			if(check == '4'){
				spaces = "OEOOEE".toCharArray();
			}
			if(check == '5'){
				spaces = "OEEOOE".toCharArray();
			}
			if(check == '6'){
				spaces = "OEEEOO".toCharArray();
			}
			if(check == '7'){
				spaces = "OEOEOE".toCharArray();
			}
			if(check == '8'){
				spaces = "OEOEEO".toCharArray();
			}
			if(check == '9'){
				spaces = "OEEOEO".toCharArray();
			}
		}

		return spaces;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
