package com.martinfjohansen.oneaccounting.Code39.Code39;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.CreateImage;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.DrawVerticalLine1px;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetBlack;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetWhite;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.GetNumberFromNumberCharacterForBase;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateNumberReference;


public class Code39{
	public static RGBABitmapImage GenerateBarcodeCode39(char [] chars, double height){
		return GenerateBarcodeCode39WithChecksumOption(chars, height, false);
	}

	public static RGBABitmapImage GenerateBarcodeCode39WithChecksumOption(char [] chars, double height, boolean includeChecksum){
		double w, h, i, barcodeNr, checksum;
		char c;
		NumberReference counterReference;
		RGBABitmapImage image;

		h = height;
		w = CalculateCode39Width(chars, includeChecksum)*2d;

		image = CreateImage(w, h, GetWhite());

		counterReference = CreateNumberReference(10d*2d);

		/* Start symbol*/
		DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, true);

		for(i = 0d; i < chars.length; i = i + 1d){
			c = chars[(int)(i)];
			barcodeNr = AsciiToCode39(c);
			DrawBarcode39Symbol(image, barcodeNr, h, counterReference, true);
		}

		if(includeChecksum){
			checksum = CalculateCode39Checksum(chars);
			DrawBarcode39Symbol(image, checksum, h, counterReference, true);
		}

		/* Stop symbol*/
		DrawBarcode39Symbol(image, Get39StartAndStopCode(), h, counterReference, false);

		return image;
	}

	public static double CalculateCode39Checksum(char [] chars){
		double checksum, i, value;
		char c;

		checksum = 0d;

		for(i = 0d; i < chars.length; i = i + 1d){
			c = chars[(int)(i)];
			value = AsciiToCode39(c);
			checksum = checksum + value;
		}

		return checksum%43d;
	}

	public static double Get39StartAndStopCode(){
		return 43d;
	}

	public static double CalculateCode39Width(char [] chars, boolean includeChecksum){
		double width;

		/* quiet zone + start + 1 + 12*characters + 1*characters + stop + quiet zone*/
		width = 10d + 12d + 1d + chars.length*12d + chars.length*1d + 12d + 10d;

		if(includeChecksum){
			width = width + 1d + 12d;
		}

		return width;
	}

	public static void DrawBarcode39Symbol(RGBABitmapImage image, double barcodeNr, double h, NumberReference counterReference, boolean addSeparator){
		double j, k, width;
		char widthCharacter;
		char [] widths;
		boolean next;
		RGBA nextColor;

		widths = GetCode39Widths(barcodeNr);

		nextColor = GetBlack();
		next = true;

		for(j = 0d; j < widths.length; j = j + 1d){
			widthCharacter = widths[(int)(j)];
			width = GetNumberFromNumberCharacterForBase(widthCharacter, 10d);

			for(k = 0d; k < width; k = k + 1d){
				DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, nextColor);
				counterReference.numberValue = counterReference.numberValue + 1d;
				DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, nextColor);
				counterReference.numberValue = counterReference.numberValue + 1d;
			}

			if(next){
				nextColor = GetWhite();
			}else{
				nextColor = GetBlack();
			}
			next = !next;
		}

		/* Space*/
		if(addSeparator){
			DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, GetWhite());
			counterReference.numberValue = counterReference.numberValue + 1d;
			DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, GetWhite());
			counterReference.numberValue = counterReference.numberValue + 1d;
		}
	}

	public static char [] GetCode39Widths(double code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == 0d){
			spaces = "111221211".toCharArray();
		}
		if(code == 1d){
			spaces = "211211112".toCharArray();
		}
		if(code == 2d){
			spaces = "112211112".toCharArray();
		}
		if(code == 3d){
			spaces = "212211111".toCharArray();
		}
		if(code == 4d){
			spaces = "111221112".toCharArray();
		}
		if(code == 5d){
			spaces = "211221111".toCharArray();
		}
		if(code == 6d){
			spaces = "112221111".toCharArray();
		}
		if(code == 7d){
			spaces = "111211212".toCharArray();
		}
		if(code == 8d){
			spaces = "211211211".toCharArray();
		}
		if(code == 9d){
			spaces = "112211211".toCharArray();
		}
		if(code == 10d){
			spaces = "211112112".toCharArray();
		}
		if(code == 11d){
			spaces = "112112112".toCharArray();
		}
		if(code == 12d){
			spaces = "212112111".toCharArray();
		}
		if(code == 13d){
			spaces = "111122112".toCharArray();
		}
		if(code == 14d){
			spaces = "211122111".toCharArray();
		}
		if(code == 15d){
			spaces = "112122111".toCharArray();
		}
		if(code == 16d){
			spaces = "111112212".toCharArray();
		}
		if(code == 17d){
			spaces = "211112211".toCharArray();
		}
		if(code == 18d){
			spaces = "112112211".toCharArray();
		}
		if(code == 19d){
			spaces = "111122211".toCharArray();
		}
		if(code == 20d){
			spaces = "211111122".toCharArray();
		}
		if(code == 21d){
			spaces = "112111122".toCharArray();
		}
		if(code == 22d){
			spaces = "212111121".toCharArray();
		}
		if(code == 23d){
			spaces = "111121122".toCharArray();
		}
		if(code == 24d){
			spaces = "211121121".toCharArray();
		}
		if(code == 25d){
			spaces = "112121121".toCharArray();
		}
		if(code == 26d){
			spaces = "111111222".toCharArray();
		}
		if(code == 27d){
			spaces = "211111221".toCharArray();
		}
		if(code == 28d){
			spaces = "112111221".toCharArray();
		}
		if(code == 29d){
			spaces = "111121221".toCharArray();
		}
		if(code == 30d){
			spaces = "221111112".toCharArray();
		}
		if(code == 31d){
			spaces = "122111112".toCharArray();
		}
		if(code == 32d){
			spaces = "222111111".toCharArray();
		}
		if(code == 33d){
			spaces = "121121112".toCharArray();
		}
		if(code == 34d){
			spaces = "221121111".toCharArray();
		}
		if(code == 35d){
			spaces = "122121111".toCharArray();
		}
		if(code == 36d){
			spaces = "121111212".toCharArray();
		}
		if(code == 37d){
			spaces = "221111211".toCharArray();
		}
		if(code == 38d){
			spaces = "122111211".toCharArray();
		}
		if(code == 39d){
			spaces = "121212111".toCharArray();
		}
		if(code == 40d){
			spaces = "121211121".toCharArray();
		}
		if(code == 41d){
			spaces = "121112121".toCharArray();
		}
		if(code == 42d){
			spaces = "111212121".toCharArray();
		}
		if(code == 43d){
			spaces = "121121211".toCharArray();
		}

		return spaces;
	}

	public static double AsciiToCode39(char c){
		double nr;
		double [] asciiToNrTable;

		asciiToNrTable = GetAsciiToCode39Table();
		nr = c;

		return asciiToNrTable[(int)(nr)];
	}

	public static double [] GetAsciiToCode39Table(){
		double [] c;

		c = new double [256];

		c[(int)('0')] = 0d;
		c[(int)('1')] = 1d;
		c[(int)('2')] = 2d;
		c[(int)('3')] = 3d;
		c[(int)('4')] = 4d;
		c[(int)('5')] = 5d;
		c[(int)('6')] = 6d;
		c[(int)('7')] = 7d;
		c[(int)('8')] = 8d;
		c[(int)('9')] = 9d;
		c[(int)('A')] = 10d;
		c[(int)('B')] = 11d;
		c[(int)('C')] = 12d;
		c[(int)('D')] = 13d;
		c[(int)('E')] = 14d;
		c[(int)('F')] = 15d;
		c[(int)('G')] = 16d;
		c[(int)('H')] = 17d;
		c[(int)('I')] = 18d;
		c[(int)('J')] = 19d;
		c[(int)('K')] = 20d;
		c[(int)('L')] = 21d;
		c[(int)('M')] = 22d;
		c[(int)('N')] = 23d;
		c[(int)('O')] = 24d;
		c[(int)('P')] = 25d;
		c[(int)('Q')] = 26d;
		c[(int)('R')] = 27d;
		c[(int)('S')] = 28d;
		c[(int)('T')] = 29d;
		c[(int)('U')] = 30d;
		c[(int)('V')] = 31d;
		c[(int)('W')] = 32d;
		c[(int)('X')] = 33d;
		c[(int)('Y')] = 34d;
		c[(int)('Z')] = 35d;
		c[(int)('-')] = 36d;
		c[(int)('.')] = 37d;
		c[(int)(' ')] = 38d;
		c[(int)('$')] = 39d;
		c[(int)('/')] = 40d;
		c[(int)('+')] = 41d;
		c[(int)('%')] = 42d;
		c[(int)('*')] = 43d;

		return c;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
