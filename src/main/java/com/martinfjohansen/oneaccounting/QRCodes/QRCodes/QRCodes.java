package com.martinfjohansen.oneaccounting.QRCodes.QRCodes;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.LinkedListCharacters;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.BCHCodes.BCHCodes.BCHCodes.ComputeBHC15_5Code;
import static com.martinfjohansen.oneaccounting.BCHCodes.BCHCodes.BCHCodes.ComputeBHC18_6Code;
import static com.martinfjohansen.oneaccounting.Bits.Bitwise.Bitwise.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.*;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.*;
import static com.martinfjohansen.oneaccounting.QRCodes.QRData.QRData.*;
import static com.martinfjohansen.oneaccounting.QRCodes.QRErrorCorrectionCodes.QRErrorCorrectionCodes.QRAddErrorCodesAndInterleave;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCreateString;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cIsNumber;
import static com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.LinkedListCharactersFunctions.LinkedListCharactersFunctions.*;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.CreateStringFromNumberWithCheck;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.*;
import static java.lang.Math.*;

public class QRCodes{
	public static boolean GenerateQRCode(RGBABitmapImageReference imageReference, char [] chars, char errorCorrectionLevel, StringReference errorMessage){
		double version;
		NumberReference versionReference;
		boolean success;

		versionReference = new NumberReference();
		success = QRGetRequiredVersionFromData(chars, errorCorrectionLevel, versionReference, errorMessage);

		if(success){
			version = versionReference.numberValue;

			GenerateQRCodeWithAllOptions(imageReference, chars, version, errorCorrectionLevel, QRQuietZoneSize(), errorMessage);
		}

		return success;
	}

	public static boolean QRGetRequiredVersionFromData(char [] chars, char errorCorrectionLevelCode, NumberReference versionReference, StringReference errorMessage){
		StringReference modeReference;
		boolean success, done;
		double i, l, errorCorrectionLevelNumber;
		char [] modeName;
		double [] symbolBitsSpec;
		NumberReference lengthReference;

		modeReference = new StringReference();
		success = QRDetectMode(chars, modeReference, errorMessage);

		if(success){
			modeName = modeReference.string;

			symbolBitsSpec = GetQRSymbolLengthsForVersions();

			errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode);

			done = false;
			lengthReference = new NumberReference();
			for(i = 1d; i <= 40d && !done; i = i + 1d){
				success = QRComputeNumberOfCodewords(chars.length, i, modeName, lengthReference, errorMessage);

				if(success){
					l = lengthReference.numberValue;

					if(l <= symbolBitsSpec[(int)((i - 1d)*4d + errorCorrectionLevelNumber)]){
						versionReference.numberValue = i;
						done = true;
					}
				}else{
					done = true;
				}
			}

			if(!done){
				success = false;
				errorMessage.string = "Too much data for any QR code.".toCharArray();
			}
		}

		return success;
	}

	public static boolean GenerateQRCodeWithAllOptions(RGBABitmapImageReference imageReference, char [] chars, double version, char errorCorrectionLevel, double quietZoneSize, StringReference errorMessage){
		RGBABitmapImage image, quietZoneImage, basis;
		RGBABitmapImage [] masks, withMasks;
		double size, sizeWithQuietZone, i, min, choice;
		char [] bs, formatbits, mode;
		double [] cws, allcws, pentalies;
		boolean success;
		StringReference modeReference, bsReference;

		modeReference = new StringReference();
		success = QRDetectMode(chars, modeReference, errorMessage);

		if(success){
			mode = modeReference.string;

			size = QRVersionToModules(version);

			image = CreateImage(size, size, GetTransparent());

			QRAddTimingPattern(image, version);

			QRAddFinderPattern(image, version);

			QRAddAlignmentPatterns(image, version);

			QRAddDummyFormatBits(image, version);

			if(version >= 7d){
				QRAddVersionBits(image, version);
			}

			bsReference = new StringReference();

			success = GetQRCodewordBitSequence(chars, version, mode, bsReference, errorMessage);

			if(success){
				bs = bsReference.string;

				cws = QRSegmentsToCodeWords(bs, version, errorCorrectionLevel);
				allcws = QRAddErrorCodesAndInterleave(cws, version, errorCorrectionLevel);

				basis = CopyImage(image);

				QRAddCodewords(image, version, allcws);

				formatbits = new char [15];

				masks = new RGBABitmapImage [8];
				withMasks = new RGBABitmapImage [8];
				pentalies = new double [8];
				for(i = 0d; i < 8d; i = i + 1d){
					masks[(int)(i)] = CreateMask(i, version);
					withMasks[(int)(i)] = QRApplyMask(basis, image, masks[(int)(i)]);
					QRComputeFormatBits(formatbits, errorCorrectionLevel, i);
					QRAddFormatBits(withMasks[(int)(i)], formatbits);
					/*System.out.println("Mask " + (int)i);*/
					pentalies[(int)(i)] = QRComputePenalty(withMasks[(int)(i)]);
				}

				choice = 0d;
				min = pentalies[(int)(choice)];
				for(i = 0d; i < 8d; i = i + 1d){
					if(pentalies[(int)(i)] < min){
						choice = i;
						min = pentalies[(int)(choice)];
					}
				}

				image = withMasks[(int)(choice)];

				sizeWithQuietZone = size + 2d*quietZoneSize;
				quietZoneImage = CreateImage(sizeWithQuietZone, sizeWithQuietZone, GetWhite());
				DrawImageOnImage(quietZoneImage, image, quietZoneSize, quietZoneSize);

				imageReference.image = quietZoneImage;
			}
		}

		return success;
	}

	public static boolean GetQRCodewordBitSequence(char [] chars, double version, char [] modeName, StringReference bsReference, StringReference errorMessage){
		boolean success;

		if(arraysStringsEqual(modeName, "Numeric".toCharArray())){
			success = QRNumericDataToSegment(chars, version, bsReference, errorMessage);
		}else if(arraysStringsEqual(modeName, "Alphanumeric".toCharArray())){
			success = QRAlphanumericDataToSegment(chars, version, bsReference, errorMessage);
		}else if(arraysStringsEqual(modeName, "8-bit Byte".toCharArray())){
			success = QR8BitByteDataToSegment(chars, version, bsReference, errorMessage);
		}else{
			success = false;
			errorMessage.string = "Invalid data mode.".toCharArray();
		}

		return success;
	}

	public static boolean QRComputeNumberOfCodewords(double dataLength, double version, char [] modeName, NumberReference lengthReference, StringReference errorMessage){
		double length, r, last, c;
		boolean success;
		NumberReference countReference;

		length = 0d;
		countReference = new NumberReference();

		success = QRGetCountLength(version, modeName, countReference, errorMessage);

		if(success){
			c = countReference.numberValue;

			if(arraysStringsEqual(modeName, "Numeric".toCharArray())){
				r = 0d;
				last = dataLength%3d;
				if(last == 0d){
					r = 0d;
				}else if(last == 1d){
					r = 4d;
				}else if(last == 2d){
					r = 7d;
				}

				length = 4d + c + 10d*floor(dataLength/3d) + r;
			}else if(arraysStringsEqual(modeName, "Alphanumeric".toCharArray())){
				length = 4d + c + 11d*floor(dataLength/2d) + 6d*(dataLength%2d);
			}else if(arraysStringsEqual(modeName, "8-bit Byte".toCharArray())){
				length = 4d + c + 8d*dataLength;
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		if(success){
			lengthReference.numberValue = length;
		}

		return success;
	}

	public static void QRAddVersionBits(RGBABitmapImage image, double version){
		double ecc, i, x, y, offset;
		StringReference str;
		char [] code;

		ecc = ComputeBHC18_6Code(version);

		code = new char [18];

		str = new StringReference();
		CreateStringFromNumberWithCheck(version, 2d, str);

		offset = 6d - str.string.length;
		for(i = 0d; i < 6d; i = i + 1d){
			if(i < offset){
				code[(int)(i)] = '0';
			}else{
				code[(int)(i)] = str.string[(int)(i - offset)];
			}
		}

		CreateStringFromNumberWithCheck(ecc, 2d, str);

		offset = 12d - str.string.length;
		for(i = 0d; i < 12d; i = i + 1d){
			if(i < offset){
				code[(int)(6d + i)] = '0';
			}else{
				code[(int)(6d + i)] = str.string[(int)(i - offset)];
			}
		}

		for(i = 0d; i < 18d; i = i + 1d){
			x = ImageWidth(image) - 11d + i%3d;
			y = 0d + floor(i/3d);

			if(code[(int)(18d - 1d - i)] == '1'){
				SetPixel(image, x, y, GetBlack());
				SetPixel(image, y, x, GetBlack());
			}else{
				SetPixel(image, x, y, GetWhite());
				SetPixel(image, y, x, GetWhite());
			}
		}
	}

	public static void QRAddAlignmentPatterns(RGBABitmapImage image, double version){
		double i, j, x, y, nrOfPositions;
		double [] positions, col2, col3, col4, col5, col6, col7;
		boolean includePattern;

		positions = new double [7];

		col2 = StringToNumberArray("18, 22, 26, 30, 34, 22, 24, 26, 28, 30, 32, 34, 26, 26, 26, 30, 30, 30, 34, 28, 26, 30, 28, 32, 30, 34, 26, 30, 26, 30, 34, 30, 34, 30, 24, 28, 32, 26, 30".toCharArray());
		col3 = StringToNumberArray("38, 42, 46, 50, 54, 58, 62, 46, 48, 50, 54, 56, 58, 62, 50, 50, 54, 54, 58, 58, 62, 50, 54, 52, 56, 60, 58, 62, 54, 50, 54, 58, 54, 58".toCharArray());
		col4 = StringToNumberArray("66, 70, 74, 78, 82, 86, 90, 72, 74, 78, 80, 84, 86, 90, 74, 78, 78, 82, 86, 86, 90, 78, 76, 80, 84, 82, 86".toCharArray());
		col5 = StringToNumberArray("94, 98, 102, 106, 110, 114, 118, 98, 102, 104, 108, 112, 114, 118, 102, 102, 106, 110, 110, 114".toCharArray());
		col6 = StringToNumberArray("122, 126, 130, 134, 138, 142, 146, 126, 128, 132, 136, 138, 142".toCharArray());
		col7 = StringToNumberArray("150, 154, 158, 162, 166, 170".toCharArray());

		positions[0] = 6d;
		nrOfPositions = 0d;

		if(version == 1d){
			nrOfPositions = 0d;
		}
		if(version >= 2d){
			nrOfPositions = 2d;
			positions[1] = col2[(int)(version - 2d)];
		}
		if(version >= 7d){
			nrOfPositions = 3d;
			positions[2] = col3[(int)(version - 7d)];
		}
		if(version >= 14d){
			nrOfPositions = 4d;
			positions[3] = col4[(int)(version - 14d)];
		}
		if(version >= 21d){
			nrOfPositions = 5d;
			positions[4] = col5[(int)(version - 21d)];
		}
		if(version >= 28d){
			nrOfPositions = 6d;
			positions[5] = col6[(int)(version - 28d)];
		}
		if(version >= 35d){
			nrOfPositions = 7d;
			positions[6] = col7[(int)(version - 35d)];
		}

		for(i = 0d; i < nrOfPositions; i = i + 1d){
			for(j = 0d; j < nrOfPositions; j = j + 1d){
				x = positions[(int)(i)];
				y = positions[(int)(j)];

				if(x <= 8d && y <= 8d){
					includePattern = false;
				}else if(x >= ImageWidth(image) - 8d && y <= 8d){
					includePattern = false;
				}else if(x <= 8d && y >= ImageWidth(image) - 7d){
					includePattern = false;
				}else{
					includePattern = true;
				}

				if(includePattern){
					QRAddAlignmentPattern(image, x, y);
				}
			}
		}
	}

	public static void QRAddAlignmentPattern(RGBABitmapImage image, double x, double y){
		DrawRectangle1px(image, x, y, 0d, 0d, GetBlack());
		DrawRectangle1px(image, x - 1d, y - 1d, 2d, 2d, GetWhite());
		DrawRectangle1px(image, x - 2d, y - 2d, 4d, 4d, GetBlack());
	}

	public static boolean QR8BitByteDataToSegment(char [] data, double version, StringReference bsReference, StringReference errorMessage){
		char [] bs, mode;
		double length, c, d, i, n, j, offset;
		StringReference nstr;
		NumberReference lengthReference, countReference;
		boolean success;

		countReference = new NumberReference();
		success = QRGetCountLength(version, "8-bit Byte".toCharArray(), countReference, errorMessage);

		if(success){
			c = countReference.numberValue;
			d = data.length;

			lengthReference = new NumberReference();
			success = QRComputeNumberOfCodewords(data.length, version, "8-bit Byte".toCharArray(), lengthReference, errorMessage);

			if(success){
				length = lengthReference.numberValue;

				bs = arraysCreateString(length, '0');

				/* Characters*/
				nstr = new StringReference();

				for(i = 0d; i < d; i = i + 1d){
					n = data[(int)(i)];

					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 8d - nstr.string.length;
					for(j = 0d; j < nstr.string.length; j = j + 1d){
						bs[(int)(4d + c + 8d*i + j + offset)] = nstr.string[(int)(j)];
					}
				}

				/* Character count*/
				CreateStringFromNumberWithCheck(d, 2d, nstr);
				offset = 4d + c - nstr.string.length;
				for(j = 0d; j < nstr.string.length; j = j + 1d){
					bs[(int)(offset + j)] = nstr.string[(int)(j)];
				}

				/* Mode*/
				mode = QR8BitByteModeIndicator();
				for(j = 0d; j < 4d; j = j + 1d){
					bs[(int)(j)] = mode[(int)(j)];
				}

				bsReference.string = bs;
			}
		}

		return success;
	}

	public static boolean QRDetectMode(char [] chars, StringReference modeReference, StringReference errorMessage){
		boolean success;
		double i, mode;
		char c;

		mode = 0d;
		success = false;

		for(i = 0d; i < chars.length; i = i + 1d){
			c = chars[(int)(i)];

			if(cIsNumber(c)){
				if(mode == 0d){
					mode = 1d;
					success = true;
				}
			}else if(IsQRAlphanumericCharacter(c)){
				if(mode <= 1d){
					mode = 2d;
					success = true;
				}
			}else if(IsQRJIS8Character(c)){
				if(mode <= 2d){
					mode = 3d;
					success = true;
				}
			}else{
				mode = 5d;
				success = false;
				errorMessage.string = "Data contains invalid characters".toCharArray();
			}
		}

		if(mode == 0d){
			errorMessage.string = "There is no data to put in the QR code.".toCharArray();
		}
		if(mode == 1d){
			modeReference.string = "Numeric".toCharArray();
		}
		if(mode == 2d){
			modeReference.string = "Alphanumeric".toCharArray();
		}
		if(mode == 3d){
			modeReference.string = "8-bit Byte".toCharArray();
		}

		return success;
	}

	public static double QRComputePenalty(RGBABitmapImage image){
		double totalP, runP, boxP, findP, balP;

		runP = QRComputePenaltyForRuns(image);
		/*System.out.println("runP: " + ", " + (int)runP);*/
		boxP = QRComputePenaltyForBoxes(image);
		/*System.out.println("boxP: " + ", " + (int)boxP);*/
		findP = QRComputePenaltyForFinders(image);
		/*System.out.println("findP: " + ", " + (int)findP);*/
		balP = QRComputePenaltyForBalance(image);
		/*System.out.println("balP: " + ", " + (int)balP);*/
		/* Total penalty*/
		totalP = runP + boxP + balP + findP + balP;
		/*System.out.println(totalP);*/
		return totalP;
	}

	public static double QRComputePenaltyForBalance(RGBABitmapImage image){
		double x, y, h, w, balP, total, black, deviation;
		boolean isBlack;

		h = ImageHeight(image);
		w = ImageWidth(image);

		total = h*w;
		black = 0d;

		for(y = 0d; y < h; y = y + 1d){
			for(x = 0d; x < w; x = x + 1d){
				isBlack = PixelIsBlack(image, x, y);

				if(isBlack){
					black = black + 1d;
				}
			}
		}

		deviation = abs(100d*black/total - 50d);
		balP = floor(deviation/5d)*10d;

		return balP;
	}

	public static double QRComputePenaltyForFinders(RGBABitmapImage image){
		double x, y, h, w, findP;
		boolean d1, w1, d2, d3, d4, w2, d5, w3, w4, w5, w6;

		h = ImageHeight(image);
		w = ImageWidth(image);

		findP = 0d;
		for(y = 0d; y < h; y = y + 1d){
			for(x = 0d; x < w - 10d; x = x + 1d){
				d1 = PixelIsBlack(image, x + 0d, y);
				w1 = PixelIsBlack(image, x + 1d, y);
				d2 = PixelIsBlack(image, x + 2d, y);
				d3 = PixelIsBlack(image, x + 3d, y);
				d4 = PixelIsBlack(image, x + 4d, y);
				w2 = PixelIsBlack(image, x + 5d, y);
				d5 = PixelIsBlack(image, x + 6d, y);
				w3 = PixelIsBlack(image, x + 7d, y);
				w4 = PixelIsBlack(image, x + 8d, y);
				w5 = PixelIsBlack(image, x + 9d, y);
				w6 = PixelIsBlack(image, x + 10d, y);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}

				w3 = PixelIsBlack(image, x + 0d, y);
				w4 = PixelIsBlack(image, x + 1d, y);
				w5 = PixelIsBlack(image, x + 2d, y);
				w6 = PixelIsBlack(image, x + 3d, y);
				d1 = PixelIsBlack(image, x + 4d, y);
				w1 = PixelIsBlack(image, x + 5d, y);
				d2 = PixelIsBlack(image, x + 6d, y);
				d3 = PixelIsBlack(image, x + 7d, y);
				d4 = PixelIsBlack(image, x + 8d, y);
				w2 = PixelIsBlack(image, x + 9d, y);
				d5 = PixelIsBlack(image, x + 10d, y);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}
			}
		}

		for(x = 0d; x < w; x = x + 1d){
			for(y = 0d; y < h - 10d; y = y + 1d){
				d1 = PixelIsBlack(image, x, y + 0d);
				w1 = PixelIsBlack(image, x, y + 1d);
				d2 = PixelIsBlack(image, x, y + 2d);
				d3 = PixelIsBlack(image, x, y + 3d);
				d4 = PixelIsBlack(image, x, y + 4d);
				w2 = PixelIsBlack(image, x, y + 5d);
				d5 = PixelIsBlack(image, x, y + 6d);
				w3 = PixelIsBlack(image, x, y + 7d);
				w4 = PixelIsBlack(image, x, y + 8d);
				w5 = PixelIsBlack(image, x, y + 9d);
				w6 = PixelIsBlack(image, x, y + 10d);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}

				w3 = PixelIsBlack(image, x, y + 0d);
				w4 = PixelIsBlack(image, x, y + 1d);
				w5 = PixelIsBlack(image, x, y + 2d);
				w6 = PixelIsBlack(image, x, y + 3d);
				d1 = PixelIsBlack(image, x, y + 4d);
				w1 = PixelIsBlack(image, x, y + 5d);
				d2 = PixelIsBlack(image, x, y + 6d);
				d3 = PixelIsBlack(image, x, y + 7d);
				d4 = PixelIsBlack(image, x, y + 8d);
				w2 = PixelIsBlack(image, x, y + 9d);
				d5 = PixelIsBlack(image, x, y + 10d);

				if(d1 && !w1 && d2 && d3 && d4 && !w2 && d5 && !w3 && !w4 && !w5 && !w6){
					findP = findP + 40d;
				}
			}
		}

		return findP;
	}

	public static double QRComputePenaltyForBoxes(RGBABitmapImage image){
		double x, y, h, w, boxP;
		boolean ul, ur, ll, lr;

		h = ImageHeight(image);
		w = ImageWidth(image);

		boxP = 0d;
		for(y = 0d; y < h - 1d; y = y + 1d){
			for(x = 0d; x < w - 1d; x = x + 1d){
				ul = PixelIsBlack(image, x + 0d, y + 0d);
				ur = PixelIsBlack(image, x + 1d, y + 0d);
				ll = PixelIsBlack(image, x + 0d, y + 1d);
				lr = PixelIsBlack(image, x + 1d, y + 1d);

				if(ul && ur && ll && lr || !ul && !ur && !ll && !lr){
					boxP = boxP + 3d;
				}
			}
		}

		return boxP;
	}

	public static boolean PixelIsBlack(RGBABitmapImage image, double x, double y){
		return GetImagePixel(image, x, y).r == 0d;
	}

	public static double QRComputePenaltyForRuns(RGBABitmapImage image){
		boolean first, prev, cur;
		double run, x, y, h, w, runP;
		boolean last;

		h = ImageHeight(image);
		w = ImageWidth(image);

		runP = 0d;

		/* Horizontal penalty*/
		for(y = 0d; y < h; y = y + 1d){
			first = true;
			prev = true;
			cur = true;
			run = 1d;

			for(x = 0d; x <= w; x = x + 1d){
				last = x == w;
				if(!last){
					cur = PixelIsBlack(image, x, y);
				}

				if(!first){
					if(prev == cur && !last){
						run = run + 1d;
					}

					if(prev != cur || last){
						if(run >= 5d){
							runP = runP + 3d + run - 5d;
						}
						run = 1d;
					}
				}

				first = false;
				prev = cur;
			}
		}

		/* Vertical penalty*/
		for(x = 0d; x < w; x = x + 1d){
			first = true;
			prev = true;
			cur = true;
			run = 1d;

			for(y = 0d; y <= h; y = y + 1d){
				last = y == h;
				if(!last){
					cur = PixelIsBlack(image, x, y);
				}

				if(!first){
					if(prev == cur && !last){
						run = run + 1d;
					}

					if(prev != cur || last){
						if(run >= 5d){
							runP = runP + 3d + run - 5d;
						}
						run = 1d;
					}
				}

				first = false;
				prev = cur;
			}
		}
		return runP;
	}

	public static void QRAddFormatBits(RGBABitmapImage image, char [] formatbits){
		char b;
		double i, x, y;
		RGBA black, white, color;

		black = GetBlack();
		white = GetWhite();

		x = 8d;
		y = 0d;

		/* Upper-left*/
		for(i = 0d; i < formatbits.length; i = i + 1d){
			b = formatbits[(int)(14d - i)];
			if(b == '1'){
				color = black;
			}else{
				color = white;
			}

			SetPixel(image, x, y, color);

			if(i < 7d){
				y = y + 1d;
			}
			if(i == 5d){
				y = y + 1d;
			}

			if(i >= 7d){
				x = x - 1d;
			}
			if(i == 8d){
				x = x - 1d;
			}
		}

		/* Lower left and top right*/
		x = ImageWidth(image) - 1d;
		y = 8d;

		for(i = 0d; i < formatbits.length; i = i + 1d){
			b = formatbits[(int)(14d - i)];
			if(b == '1'){
				color = black;
			}else{
				color = white;
			}

			SetPixel(image, x, y, color);

			if(i < 7d){
				x = x - 1d;
			}
			if(i == 7d){
				y = ImageHeight(image) - 7d;
				x = 8d;
			}

			if(i > 7d){
				y = y + 1d;
			}
		}
	}

	public static void QRComputeFormatBits(char [] bits, char errorCorrectionLevel, double mask){
		double i, bhc, offset, errorCorrectionCode, n;
		char [] xorpattern;
		StringReference str;
		boolean a, b, r;

		errorCorrectionCode = 0d;
		if(errorCorrectionLevel == 'L'){
			errorCorrectionCode = 1d;
		}else if(errorCorrectionLevel == 'M'){
			errorCorrectionCode = 0d;
		}else if(errorCorrectionLevel == 'Q'){
			errorCorrectionCode = 3d;
		}else if(errorCorrectionLevel == 'H'){
			errorCorrectionCode = 2d;
		}

		n = OrByte(ShiftLeftByte(errorCorrectionCode, 3d), mask);

		bhc = ComputeBHC15_5Code(n);

		n = Or4Byte(ShiftLeft4Byte(n, 10d), bhc);

		str = new StringReference();
		CreateStringFromNumberWithCheck(n, 2d, str);

		offset = 15d - str.string.length;
		for(i = 0d; i < 15d; i = i + 1d){
			if(i < offset){
				bits[(int)(i)] = '0';
			}else{
				bits[(int)(i)] = str.string[(int)(i - offset)];
			}
		}

		xorpattern = "101010000010010".toCharArray();

		for(i = 0d; i < 15d; i = i + 1d){
			a = bits[(int)(i)] == '1';
			b = xorpattern[(int)(i)] == '1';

			r = Xor(a, b);

			if(r){
				bits[(int)(i)] = '1';
			}else{
				bits[(int)(i)] = '0';
			}
		}
	}

	public static RGBABitmapImage QRApplyMask(RGBABitmapImage basis, RGBABitmapImage image, RGBABitmapImage mask){
		RGBABitmapImage withMask;
		double i, j;
		boolean a, b, r;

		withMask = CopyImage(image);

		for(i = 0d; i < ImageWidth(basis); i = i + 1d){
			for(j = 0d; j < ImageHeight(basis); j = j + 1d){
				if(GetImagePixel(basis, i, j).a == 0d){
					a = PixelIsBlack(image, i, j);
					b = PixelIsBlack(mask, i, j);

					/* xor*/
					r = Xor(a, b);

					if(r){
						SetPixel(withMask, i, j, GetBlack());
					}else{
						SetPixel(withMask, i, j, GetWhite());
					}
				}
			}
		}

		return withMask;
	}

	public static boolean Xor(boolean a, boolean b){
		return a && !b || !a && b;
	}

	public static RGBABitmapImage CreateMask(double mask, double version){
		double size, i, j;
		boolean black;
		RGBABitmapImage image;

		size = QRVersionToModules(version);

		image = CreateImage(size, size, GetTransparent());

		black = true;
		for(i = 0d; i < size; i = i + 1d){
			for(j = 0d; j < size; j = j + 1d){
				if(mask == 0d){
					black = (i + j)%2d == 0d;
				}else if(mask == 1d){
					black = i%2d == 0d;
				}else if(mask == 2d){
					black = j%3d == 0d;
				}else if(mask == 3d){
					black = (i + j)%3d == 0d;
				}else if(mask == 4d){
					black = (floor(i/2d) + floor(j/3d))%2d == 0d;
				}else if(mask == 5d){
					black = (i*j)%2d + (i*j)%3d == 0d;
				}else if(mask == 6d){
					black = ((i*j)%2d + (i*j)%3d)%2d == 0d;
				}else if(mask == 7d){
					black = ((i*j)%3d + (i + j)%2d)%2d == 0d;
				}

				if(black){
					SetPixel(image, j, i, GetBlack());
				}else{
					SetPixel(image, j, i, GetWhite());
				}
			}
		}

		return image;
	}

	public static void QRAddDummyFormatBits(RGBABitmapImage image, double version){
		double i, size;

		size = QRVersionToModules(version);

		for(i = 0d; i < 9d; i = i + 1d){
			if(i != 6d){
				SetPixel(image, i, 8d, GetWhite());
				SetPixel(image, 8d, i, GetWhite());
			}
			if(i != 8d){
				SetPixel(image, size - 1d - i, 8d, GetWhite());
				SetPixel(image, 8d, size - 1d - i, GetWhite());
			}
		}

		SetPixel(image, 8d, size - 8d, GetBlack());
	}

	public static void QRAddCodewords(RGBABitmapImage image, double version, double [] cws){
		LinkedListCharacters ll;
		double i, j, x, y, size, offset, bit;
		StringReference s;
		char [] bits;
		char b;
		boolean w, d;
        
		ll = CreateLinkedListCharacter();
		s = new StringReference();
        
		for(i = 0d; i < cws.length; i = i + 1d){
			CreateStringFromNumberWithCheck(cws[(int)(i)], 2d, s);

			offset = 8d - s.string.length;
			for(j = 0d; j < 8d; j = j + 1d){
				if(j < offset){
					LinkedListAddCharacter(ll, '0');
				}else{
					LinkedListAddCharacter(ll, s.string[(int)(j - offset)]);
				}
			}

			delete(s.string);
		}

		bits = LinkedListCharactersToArray(ll);

		size = QRVersionToModules(version);
		x = size - 1d;
		y = size - 1d;
		d = true;
		w = true;
		bit = 0d;
		offset = 0d;
		for(i = 0d; i < pow(size, 2d) - size; i = i + 1d){
			if(GetImagePixel(image, x - offset, y).a == 0d){
				if(bit < bits.length){
					b = bits[(int)(bit)];

					if(b == '1'){
						SetPixel(image, (x - offset), y, GetBlack());
					}else{
						SetPixel(image, (x - offset), y, GetWhite());
					}

					bit = bit + 1d;
				}else{
					/* Some symbols have nothing at the end.*/
					SetPixel(image, (x - offset), y, GetWhite());
				}
			}

			if(d){
				if(w){
					x = x - 1d;
				}else{
					x = x + 1d;
					y = y - 1d;
				}
			}else if(w){
				x = x - 1d;
			}else{
				x = x + 1d;
				y = y + 1d;
			}

			w = !w;

			if(i%(2d*size) == 2d*size - 1d){
				if(d){
					x = x - 2d;
					y = y + 1d;
					w = true;
				}else{
					x = x - 2d;
					y = y - 1d;
					w = true;
				}

				d = !d;
			}

			if(x == 6d){
				offset = 1d;
			}
		}
	}

	public static void QRAddTimingPattern(RGBABitmapImage image, double version){
		double size, i;
		boolean black;

		size = QRVersionToModules(version);

		black = true;
		for(i = 0d; i < size; i = i + 1d){
			if(black){
				SetPixel(image, i, 6d, GetBlack());
				SetPixel(image, 6d, i, GetBlack());
			}else{
				SetPixel(image, i, 6d, GetWhite());
				SetPixel(image, 6d, i, GetWhite());
			}

			black = !black;
		}
	}

	public static void QRAddFinderPattern(RGBABitmapImage image, double version){
		RGBABitmapImage finderPattern;
		double size;

		size = QRVersionToModules(version);
		finderPattern = GetQRFinderPattern();
		DrawImageOnImage(image, finderPattern, -1d, -1d);
		DrawImageOnImage(image, finderPattern, size - 7d - 1d, -1d);
		DrawImageOnImage(image, finderPattern, -1d, size - 7d - 1d);
	}

	public static RGBABitmapImage GetQRFinderPattern(){
		RGBABitmapImage fp;

		fp = CreateImage(9d, 9d, GetBlack());

		DrawRectangle1px(fp, 2d, 2d, 4d, 4d, GetWhite());
		DrawRectangle1px(fp, 0d, 0d, 8d, 8d, GetWhite());

		return fp;
	}

	public static double QRQuietZoneSize(){
		return 4d;
	}

	public static double QRVersionToModules(double version){
		return 17d + 4d*version;
	}

	public static boolean QRNumericDataToSegment(char [] data, double version, StringReference bsReference, StringReference errorMessage){
		char [] bs, group, mode;
		double length, c, d, r, i, n, j, offset, last;
		StringReference nstr;
		NumberReference countReference, lengthReference;
		boolean success;

		countReference = new NumberReference();
		success = QRGetCountLength(version, "Numeric".toCharArray(), countReference, errorMessage);

		if(success){
			c = countReference.numberValue;
			d = data.length;

			r = 0d;
			last = d%3d;
			if(last == 0d){
				r = 0d;
			}else if(last == 1d){
				r = 4d;
			}else if(last == 2d){
				r = 7d;
			}

			lengthReference = new NumberReference();
			success = QRComputeNumberOfCodewords(data.length, version, "Numeric".toCharArray(), lengthReference, errorMessage);
			if(success){
				length = lengthReference.numberValue;

				bs = arraysCreateString(length, '0');

				/* Characters*/
				group = new char [3];
				nstr = new StringReference();

				for(i = 0d; i < floor(d/3d); i = i + 1d){
					group[0] = data[(int)(i*3d + 0d)];
					group[1] = data[(int)(i*3d + 1d)];
					group[2] = data[(int)(i*3d + 2d)];

					n = CreateNumberFromDecimalString(group);
					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 10d - nstr.string.length;
					for(j = 0d; j < nstr.string.length; j = j + 1d){
						bs[(int)(4d + c + i*10d + offset + j)] = nstr.string[(int)(j)];
					}
				}

				if(last == 1d){
					group[0] = '0';
					group[1] = '0';
					group[2] = data[(int)(data.length - 1d)];
				}

				if(last == 2d){
					group[0] = '0';
					group[1] = data[(int)(data.length - 2d)];
					group[2] = data[(int)(data.length - 1d)];
				}

				if(last == 1d || last == 2d){
					n = CreateNumberFromDecimalString(group);
					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = r - nstr.string.length;
					for(j = 0d; j < nstr.string.length; j = j + 1d){
						bs[(int)(bs.length - r + offset + j)] = nstr.string[(int)(j)];
					}
				}

				/* Character count*/
				CreateStringFromNumberWithCheck(d, 2d, nstr);
				offset = 4d + c - nstr.string.length;
				for(j = 0d; j < nstr.string.length; j = j + 1d){
					bs[(int)(offset + j)] = nstr.string[(int)(j)];
				}

				/* Mode*/
				mode = QRNumericModeIndicator();
				for(j = 0d; j < 4d; j = j + 1d){
					bs[(int)(j)] = mode[(int)(j)];
				}

				bsReference.string = bs;
			}
		}

		return success;
	}

	public static boolean QRGetCountLength(double version, char [] modeName, NumberReference cReference, StringReference errorMessage){
		double c;
		boolean success;

		success = true;
		c = 0d;

		if(arraysStringsEqual(modeName, "Numeric".toCharArray())){
			if(version >= 1d && version <= 9d){
				c = 10d;
			}else if(version >= 10d && version <= 26d){
				c = 12d;
			}else if(version >= 27d && version <= 40d){
				c = 14d;
			}else{
				success = false;
				errorMessage.string = "Invalid version number.".toCharArray();
			}
		}else if(arraysStringsEqual(modeName, "Alphanumeric".toCharArray())){
			if(version >= 1d && version <= 9d){
				c = 9d;
			}else if(version >= 10d && version <= 26d){
				c = 11d;
			}else if(version >= 27d && version <= 40d){
				c = 13d;
			}else{
				success = false;
				errorMessage.string = "Invalid version number.".toCharArray();
			}
		}else if(arraysStringsEqual(modeName, "8-bit Byte".toCharArray())){
			if(version >= 1d && version <= 9d){
				c = 8d;
			}else if(version >= 10d && version <= 26d){
				c = 16d;
			}else if(version >= 27d && version <= 40d){
				c = 16d;
			}else{
				success = false;
				errorMessage.string = "Invalid version number.".toCharArray();
			}
		}else{
			success = false;
			errorMessage.string = "Invalid mode name.".toCharArray();
		}

		if(success){
			cReference.numberValue = c;
		}

		return success;
	}

	public static char [] QRNumericModeIndicator(){
		return "0001".toCharArray();
	}

	public static char [] QRAlphanumericModeIndicator(){
		return "0010".toCharArray();
	}

	public static char [] QRTerminatorModeIndicator(){
		return "0000".toCharArray();
	}

	public static char [] QR8BitByteModeIndicator(){
		return "0100".toCharArray();
	}

	public static char [] QRKanjiModeIndicator(){
		return "1000".toCharArray();
	}

	public static boolean QRAlphanumericDataToSegment(char [] data, double version, StringReference bsReference, StringReference errorMessage){
		char [] bs, mode;
		double length, c, d, i, n, j, offset, c0, c1;
		StringReference nstr;
		boolean success;
		NumberReference lengthReference, countReference;

		countReference = new NumberReference();
		success = QRGetCountLength(version, "Alphanumeric".toCharArray(), countReference, errorMessage);

		if(success){
			c = countReference.numberValue;
			d = data.length;

			lengthReference = new NumberReference();
			success = QRComputeNumberOfCodewords(data.length, version, "Alphanumeric".toCharArray(), lengthReference, errorMessage);

			if(success){
				length = lengthReference.numberValue;

				bs = arraysCreateString(length, '0');

				/* Characters*/
				nstr = new StringReference();

				for(i = 0d; i < floor(d/2d); i = i + 1d){
					c0 = QRAlphanumericToCode(data[(int)(i*2d + 0d)]);
					c1 = QRAlphanumericToCode(data[(int)(i*2d + 1d)]);

					n = c0*45d + c1;

					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 11d - nstr.string.length;
					for(j = 0d; j < nstr.string.length; j = j + 1d){
						bs[(int)(4d + c + i*11d + offset + j)] = nstr.string[(int)(j)];
					}
				}

				if(d%2d == 1d){
					n = QRAlphanumericToCode(data[(int)(data.length - 1d)]);

					CreateStringFromNumberWithCheck(n, 2d, nstr);

					offset = 6d - nstr.string.length;
					for(j = 0d; j < nstr.string.length; j = j + 1d){
						bs[(int)(bs.length - 6d + offset + j)] = nstr.string[(int)(j)];
					}
				}

				/* Character count*/
				CreateStringFromNumberWithCheck(d, 2d, nstr);
				offset = 4d + c - nstr.string.length;
				for(j = 0d; j < nstr.string.length; j = j + 1d){
					bs[(int)(offset + j)] = nstr.string[(int)(j)];
				}

				/* Mode*/
				mode = QRAlphanumericModeIndicator();
				for(j = 0d; j < 4d; j = j + 1d){
					bs[(int)(j)] = mode[(int)(j)];
				}

				bsReference.string = bs;
			}
		}

		return success;
	}

	public static double [] QRSegmentsToCodeWords(char [] data, double version, char errorCorrectionLevelCode){
		double symbolBits, terminatorLength, d, n, padding, cw, j, r, errorCorrectionLevelNumber;
		double [] codewords, symbolBitsSpec;
		char [] str;
		NumberReference nref;
		StringReference errorMessage;
		boolean padSymbol;

		symbolBitsSpec = GetQRSymbolLengthsForVersions();

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevelCode);

		symbolBits = symbolBitsSpec[(int)((version - 1d)*4d + errorCorrectionLevelNumber)];

		terminatorLength = min(symbolBits - data.length, 4d);

		d = data.length + terminatorLength;
		n = ceil(d/8d);
		padding = n*8d - d;

		codewords = new double [(int)(floor(symbolBits/8d))];

		str = new char [8];
		nref = new NumberReference();
		errorMessage = new StringReference();

		for(cw = 0d; cw < floor(data.length/8d); cw = cw + 1d){
			str[0] = data[(int)(cw*8d + 0d)];
			str[1] = data[(int)(cw*8d + 1d)];
			str[2] = data[(int)(cw*8d + 2d)];
			str[3] = data[(int)(cw*8d + 3d)];
			str[4] = data[(int)(cw*8d + 4d)];
			str[5] = data[(int)(cw*8d + 5d)];
			str[6] = data[(int)(cw*8d + 6d)];
			str[7] = data[(int)(cw*8d + 7d)];

			CreateNumberFromStringWithCheck(str, 2d, nref, errorMessage);

			codewords[(int)(cw)] = nref.numberValue;
		}

		/* Remaining data, terminator and bit-padding.*/
		r = data.length%8d;
		if(r != 0d){
			for(j = 0d; j < 8d; j = j + 1d){
				if(j < r){
					str[(int)(j)] = data[(int)(data.length - r + j)];
				}else{
					str[(int)(j)] = '0';
				}
			}

			CreateNumberFromStringWithCheck(str, 2d, nref, errorMessage);

			codewords[(int)(cw)] = nref.numberValue;
			cw = cw + 1d;
		}

		if(r == 0d && terminatorLength + padding == 8d){
			codewords[(int)(cw)] = 0d;
			cw = cw + 1d;
		}else if(8d - r >= terminatorLength + padding){
		}else{
			codewords[(int)(cw)] = 0d;
			cw = cw + 1d;
		}

		/* Byte Padding*/
		padSymbol = true;
		for(; cw < codewords.length; cw = cw + 1d){
			if(padSymbol){
				codewords[(int)(cw)] = 236d;
			}else{
				codewords[(int)(cw)] = 17d;
			}
			padSymbol = !padSymbol;
		}

		return codewords;
	}

	public static double [] GetQRSymbolLengthsForVersions(){
		return StringToNumberArray("152, 128, 104, 72, 272, 224, 176, 128, 440, 352, 272, 208, 640, 512, 384, 288, 864, 688, 496, 368, 1088, 864, 608, 480, 1248, 992, 704, 528, 1552, 1232, 880, 688, 1856, 1456, 1056, 800, 2192, 1728, 1232, 976, 2592, 2032, 1440, 1120, 2960, 2320, 1648, 1264, 3424, 2672, 1952, 1440, 3688, 2920, 2088, 1576, 4184, 3320, 2360, 1784, 4712, 3624, 2600, 2024, 5176, 4056, 2936, 2264, 5768, 4504, 3176, 2504, 6360, 5016, 3560, 2728, 6888, 5352, 3880, 3080, 7456, 5712, 4096, 3248, 8048, 6256, 4544, 3536, 8752, 6880, 4912, 3712, 9392, 7312, 5312, 4112, 10208, 8000, 5744, 4304, 10960, 8496, 6032, 4768, 11744, 9024, 6464, 5024, 12248, 9544, 6968, 5288, 13048, 10136, 7288, 5608, 13880, 10984, 7880, 5960, 14744, 11640, 8264, 6344, 15640, 12328, 8920, 6760, 16568, 13048, 9368, 7208, 17528, 13800, 9848, 7688, 18448, 14496, 10288, 7888, 19472, 15312, 10832, 8432, 20528, 15936, 11408, 8768, 21616, 16816, 12016, 9136, 22496, 17728, 12656, 9776, 23648, 18672, 13328, 10208".toCharArray());
	}

	public static double QREccLetterToNumber(char errorCorrectionLevelCode){
		double errorCorrectionLevelNumber;

		errorCorrectionLevelNumber = 0d;

		if(errorCorrectionLevelCode == 'L'){
			errorCorrectionLevelNumber = 0d;
		}else if(errorCorrectionLevelCode == 'M'){
			errorCorrectionLevelNumber = 1d;
		}else if(errorCorrectionLevelCode == 'Q'){
			errorCorrectionLevelNumber = 2d;
		}else if(errorCorrectionLevelCode == 'H'){
			errorCorrectionLevelNumber = 3d;
		}
		return errorCorrectionLevelNumber;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
