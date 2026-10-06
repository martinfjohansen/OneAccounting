package com.martinfjohansen.oneaccounting.UPC.UPC;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static com.martinfjohansen.oneaccounting.BasicPixelFont.DecimalPixelFont300.DecimalPixelFont300.DrawDigitCharacter;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetBlack;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetWhite;
import static com.martinfjohansen.oneaccounting.ImageScaling.filters.BilinaerScaleUp.BilinaerScaleUp.BilinaerScaleUpFactor;
import static com.martinfjohansen.oneaccounting.TypographyComputations.TypographyComputations.TypographyComputations.DPIToDotsPerMm;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.CreateNumberFromDecimalString;
import static java.lang.Math.ceil;
import static java.lang.Math.floor;

public class UPC{
	public static double GetCalculateUPCChecksum(char [] chars){
		double checksum, i, nextWeight, value, nearest10;
		boolean next;
		char [] numberString;

		numberString = new char [1];

		checksum = 0d;
		next = true;
		nextWeight = 3d;

		for(i = chars.length - 1d; i >= 0d; i = i - 1d){
			numberString[0] = chars[(int)(i)];
			value = CreateNumberFromDecimalString(numberString);
			checksum = checksum + value*nextWeight;

			if(next){
				nextWeight = 1d;
			}else{
				nextWeight = 3d;
			}
			next = !next;
		}

		nearest10 = ceil(checksum/10d)*10d;

		return nearest10 - checksum;
	}

	public static double GetUPCStartAndStopCode(){
		return 10d;
	}

	public static double GetEAN13Width(){
		return 95d + 11d;
	}

	public static char [] GetUPCWidths(double code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == 10d){
			spaces = "101".toCharArray();
		}
		if(code == 11d){
			spaces = "01010".toCharArray();
		}

		return spaces;
	}

	public static void DrawBarcodeUPCSymbol(RGBABitmapImage image, char [] widths, double h, NumberReference counterReference, double moduleWidthPixels){
		double i, j;
		char widthCharacter;
		RGBA color;

		for(i = 0d; i < widths.length; i = i + 1d){
			widthCharacter = widths[(int)(i)];
			if(widthCharacter == '1'){
				color = GetBlack();
			}else{
				color = GetWhite();
			}

			for(j = 0d; j < moduleWidthPixels; j = j + 1d){
				DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, color);
				counterReference.numberValue = counterReference.numberValue + 1d;
			}
		}
	}

	public static char [] GetUPCLCodeWidths(char code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == '0'){
			spaces = "0001101".toCharArray();
		}
		if(code == '1'){
			spaces = "0011001".toCharArray();
		}
		if(code == '2'){
			spaces = "0010011".toCharArray();
		}
		if(code == '3'){
			spaces = "0111101".toCharArray();
		}
		if(code == '4'){
			spaces = "0100011".toCharArray();
		}
		if(code == '5'){
			spaces = "0110001".toCharArray();
		}
		if(code == '6'){
			spaces = "0101111".toCharArray();
		}
		if(code == '7'){
			spaces = "0111011".toCharArray();
		}
		if(code == '8'){
			spaces = "0110111".toCharArray();
		}
		if(code == '9'){
			spaces = "0001011".toCharArray();
		}

		return spaces;
	}

	public static char [] GetUPCGCodeWidths(char code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == '0'){
			spaces = "0100111".toCharArray();
		}
		if(code == '1'){
			spaces = "0110011".toCharArray();
		}
		if(code == '2'){
			spaces = "0011011".toCharArray();
		}
		if(code == '3'){
			spaces = "0100001".toCharArray();
		}
		if(code == '4'){
			spaces = "0011101".toCharArray();
		}
		if(code == '5'){
			spaces = "0111001".toCharArray();
		}
		if(code == '6'){
			spaces = "0000101".toCharArray();
		}
		if(code == '7'){
			spaces = "0010001".toCharArray();
		}
		if(code == '8'){
			spaces = "0001001".toCharArray();
		}
		if(code == '9'){
			spaces = "0010111".toCharArray();
		}
		return spaces;
	}

	public static char [] GetUPCRCodeWidths(char code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == '0'){
			spaces = "1110010".toCharArray();
		}
		if(code == '1'){
			spaces = "1100110".toCharArray();
		}
		if(code == '2'){
			spaces = "1101100".toCharArray();
		}
		if(code == '3'){
			spaces = "1000010".toCharArray();
		}
		if(code == '4'){
			spaces = "1011100".toCharArray();
		}
		if(code == '5'){
			spaces = "1001110".toCharArray();
		}
		if(code == '6'){
			spaces = "1010000".toCharArray();
		}
		if(code == '7'){
			spaces = "1000100".toCharArray();
		}
		if(code == '8'){
			spaces = "1001000".toCharArray();
		}
		if(code == '9'){
			spaces = "1110100".toCharArray();
		}

		return spaces;
	}

	public static void DrawDigitOnBarcode(RGBABitmapImage image, double topx, double topy, double digit, double pixelsPerMm, double zoom){
		RGBABitmapImage digitImage, scaled;

		digitImage = CreateImage(30d, 37d, GetWhite());
		DrawDigitCharacter(digitImage, 0d, 0d, digit);
		scaled = BilinaerScaleUpFactor(digitImage, pixelsPerMm*zoom/DPIToDotsPerMm(300d));
		DrawImageOnImage(image, scaled, floor(topx), floor(topy));
		delete(digitImage);
		delete(scaled);
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
