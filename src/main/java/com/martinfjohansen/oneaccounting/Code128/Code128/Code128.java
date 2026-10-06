package com.martinfjohansen.oneaccounting.Code128.Code128;

import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBA;
import com.martinfjohansen.oneaccounting.RGBABitmapImage.RGBABitmapImage.RGBABitmapImage;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.CreateImage;
import static com.martinfjohansen.oneaccounting.Graphics2D.Graphics2D.Graphics2D.DrawVerticalLine1px;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetBlack;
import static com.martinfjohansen.oneaccounting.Graphics2D.colors.colors.GetWhite;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCreateNumberArray;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCreateString;
import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.*;
import static com.martinfjohansen.oneaccounting.math.math.math.Truncate;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.GetNumberFromNumberCharacterForBase;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateStringReference;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strAppendString;
import static java.lang.Math.floor;


public class Code128{
	public static char [] Code128EncodingParts(char [] cs){
		char [] parts;
		double i;
		char c;

		parts = new char [(int)(cs.length)];

		for(i = 0d; i < cs.length; i = i + 1d){
			c = cs[(int)(i)];

			if(IsCodeA(c) && IsCodeB(c) && IsCodeC(c)){
				parts[(int)(i)] = 'X';
			}else if(IsCodeA(c) && IsCodeB(c)){
				parts[(int)(i)] = 'D';
			}else if(IsCodeA(c)){
				parts[(int)(i)] = 'A';
			}else if(IsCodeB(c)){
				parts[(int)(i)] = 'B';
			}
		}

		return parts;
	}

	public static boolean IsCodeA(char c){
		return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || charIsCode128ASymbol(c);
	}

	public static boolean IsCodeB(char c){
		return cIsNumber(c) || cIsUpperCase(c) || charIsCode128AandBSymbol(c) || cIsLowerCase(c) || charIsCode128BSymbol(c);
	}

	public static boolean IsCodeC(char c){
		return cIsNumber(c);
	}

	public static Sections Code128EncodingSections(char [] cs){
		char [] sections, parts, currentSections;
		double i, c, next, sum;
		char p, selected;
		boolean done;
		Sections sectionsStruct;
		double [] counts, currentCounts;

		parts = Code128EncodingParts(cs);

		sections = arraysCreateString(cs.length, ' ');
		counts = arraysCreateNumberArray(cs.length, 0d);
		next = 0d;

		/* Pick C-sections.*/
		for(i = 0d; i < cs.length; i = i + 1d){
			p = parts[(int)(i)];

			if(p == 'X'){
				done = false;
				for(c = 0d; i + c < cs.length && !done; c = c + 1d){
					if(parts[(int)(i + c)] != 'X'){
						done = true;
						c = c - 1d;
					}
				}
				/* Compress 2 or more if first, or 4 or more if not.*/
				if(c >= 4d || (i == 0d && c >= 2d)){
					sections[(int)(next)] = 'C';
					c = floor(c/2d)*2d;
					counts[(int)(next)] = c;
					next = next + 1d;
					i = i + c - 1d;
				}else{
					sections[(int)(next)] = 'D';
					counts[(int)(next)] = 1d;
					next = next + 1d;
				}
			}else{
				sections[(int)(next)] = p;
				counts[(int)(next)] = 1d;
				next = next + 1d;
			}
		}

		/* Trim*/
		currentSections = new char [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentSections[(int)(i)] = sections[(int)(i)];
		}

		currentCounts = new double [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentCounts[(int)(i)] = counts[(int)(i)];
		}

		sections = arraysCreateString(cs.length, ' ');
		counts = arraysCreateNumberArray(cs.length, 0d);

		/* Compress A+A&D and B+B&D*/
		next = 0d;
		for(i = 0d; i < currentSections.length; i = i + 1d){
			p = currentSections[(int)(i)];

			if(p == 'C' || p == 'D'){
				sections[(int)(next)] = p;
				counts[(int)(next)] = currentCounts[(int)(i)];
				next = next + 1d;
			}else if(p == 'A'){
				sum = 0d;
				done = false;
				for(c = 0d; i + c < currentSections.length && !done; c = c + 1d){
					if(currentSections[(int)(i + c)] == 'A' || currentSections[(int)(i + c)] == 'D'){
						sum = sum + currentCounts[(int)(i + c)];
					}else{
						done = true;
						c = c - 1d;
					}
				}
				sections[(int)(next)] = p;
				counts[(int)(next)] = sum;
				next = next + 1d;
				i = i + c - 1d;
			}else if(p == 'B'){
				sum = 0d;
				done = false;
				for(c = 0d; i + c < currentSections.length && !done; c = c + 1d){
					if(currentSections[(int)(i + c)] == 'B' || currentSections[(int)(i + c)] == 'D'){
						sum = sum + currentCounts[(int)(i + c)];
					}else{
						done = true;
						c = c - 1d;
					}
				}
				sections[(int)(next)] = p;
				counts[(int)(next)] = sum;
				next = next + 1d;
				i = i + c - 1d;
			}
		}

		/* Trim*/
		currentSections = new char [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentSections[(int)(i)] = sections[(int)(i)];
		}

		currentCounts = new double [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentCounts[(int)(i)] = counts[(int)(i)];
		}

		sections = arraysCreateString(cs.length, ' ');
		counts = arraysCreateNumberArray(cs.length, 0d);

		/* Compress D+A&D and D+B&D*/
		next = 0d;
		for(i = 0d; i < currentSections.length; i = i + 1d){
			p = currentSections[(int)(i)];

			sum = 0d;

			if(p == 'C' || p == 'A' || p == 'B'){
				sections[(int)(next)] = p;
				counts[(int)(next)] = currentCounts[(int)(i)];
				next = next + 1d;
			}else if(p == 'D'){
				selected = ' ';
				done = false;

				sum = 0d;
				for(c = 0d; i + c < currentSections.length && !done; c = c + 1d){
					p = currentSections[(int)(i + c)];

					if(p == 'D'){
						sum = sum + currentCounts[(int)(i + c)];
					}else if(p == 'A' || p == 'B'){
						if(selected == ' '){
							selected = p;
							sum = sum + currentCounts[(int)(i + c)];
						}else if(p != selected){
							done = true;
							c = c - 1d;
						}else{
							sum = sum + currentCounts[(int)(i + c)];
						}
					}else{
						done = true;
						c = c - 1d;
					}
				}
				if(selected == ' '){
					selected = 'A';
				}
				sections[(int)(next)] = selected;
				counts[(int)(next)] = sum;
				next = next + 1d;
				i = i + c - 1d;
			}
		}

		/* Trim*/
		currentSections = new char [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentSections[(int)(i)] = sections[(int)(i)];
		}
		sections = currentSections;

		currentCounts = new double [(int)(next)];
		for(i = 0d; i < next; i = i + 1d){
			currentCounts[(int)(i)] = counts[(int)(i)];
		}
		counts = currentCounts;

		/* Done*/
		sectionsStruct = new Sections();
		sectionsStruct.codes = sections;
		sectionsStruct.counts = counts;

		return sectionsStruct;
	}

	public static double [] Code128Encode(char [] cs){
		double [] coded, nextCoded;
		boolean isFirst;
		double n, k, next, cnr, count;
		char section, lastSection;
		Sections sections;

		coded = new double [(int)(cs.length + 2d + 1d + 1d + 10d)];
		cnr = 0d;
		isFirst = true;
		next = 0d;

		lastSection = '0';

		sections = Code128EncodingSections(cs);

		for(n = 0d; n < sections.codes.length; n = n + 1d){
			section = sections.codes[(int)(n)];
			count = sections.counts[(int)(n)];

			/* start code*/
			if(isFirst){
				if(section == 'A'){
					coded[(int)(next)] = 103d;
				}else if(section == 'B'){
					coded[(int)(next)] = 104d;
				}else if(section == 'C'){
					coded[(int)(next)] = 105d;
				}
				next = next + 1d;

				isFirst = false;
			}

			/* Encode*/
			if(section == 'A'){
				if(lastSection == 'B' || lastSection == 'C'){
					coded[(int)(next)] = 101d;
					next = next + 1d;
				}

				for(k = 0d; k < count; k = k + 1d){
					coded[(int)(next)] = GetCode128ACode(cs[(int)(cnr + k)]);
					next = next + 1d;
				}
				cnr = cnr + count;
			}else if(section == 'B'){
				if(lastSection == 'A' || lastSection == 'C'){
					coded[(int)(next)] = 100d;
					next = next + 1d;
				}

				for(k = 0d; k < count; k = k + 1d){
					coded[(int)(next)] = GetCode128BCode(cs[(int)(cnr + k)]);
					next = next + 1d;
				}
				cnr = cnr + count;
			}else if(section == 'C'){
				if(lastSection == 'A' || lastSection == 'B'){
					coded[(int)(next)] = 99d;
					next = next + 1d;
				}

				for(k = 0d; k < count; k = k + 2d){
					coded[(int)(next)] = GetCode128CCode(cs[(int)(cnr + k)], cs[(int)(cnr + k + 1d)]);
					next = next + 1d;
				}
				cnr = cnr + count;
			}

			lastSection = section;
		}

		coded[(int)(next)] = CalculateCode128ChecksumWithLength(coded, next);
		next = next + 1d;

		coded[(int)(next)] = 108d;
		next = next + 1d;

		/* trim array*/
		nextCoded = new double [(int)(next)];
		for(k = 0d; k < next; k = k + 1d){
			nextCoded[(int)(k)] = coded[(int)(k)];
		}
		delete(coded);
		coded = nextCoded;

		return coded;
	}

	public static double GetCode128ACode(char c){
		double code, n;

		n = c;

		if(n >= 32d && n <= 95d){
			code = n - 32d;
		}else if(n >= 0d && n <= 31d){
			code = 64d + n;
		}else{
			code = -1d;
		}

		return code;
	}

	public static double GetCode128BCode(char c){
		double code, n;

		n = c;

		if(n >= 32d && n <= 126d){
			code = n - 32d;
		}else if(n == 127d){
			code = 95d;
		}else{
			code = -1d;
		}

		return code;
	}

	public static double GetCode128CCode(char c1, char c2){
		double n1, n2;

		n1 = GetNumberFromNumberCharacterForBase(c1, 10d);
		n2 = GetNumberFromNumberCharacterForBase(c2, 10d);

		return n1*10d + n2;
	}

	public static boolean charIsCode128AandBSymbol(char character){
		boolean common;

		common = false;
		if(character == ' '){
			common = true;
		}else if(character == '!'){
			common = true;
		}else if(character == '\"'){
			common = true;
		}else if(character == '#'){
			common = true;
		}else if(character == '$'){
			common = true;
		}else if(character == '%'){
			common = true;
		}else if(character == '&'){
			common = true;
		}else if(character == '\''){
			common = true;
		}else if(character == '('){
			common = true;
		}else if(character == ')'){
			common = true;
		}else if(character == '*'){
			common = true;
		}else if(character == '+'){
			common = true;
		}else if(character == ','){
			common = true;
		}else if(character == '-'){
			common = true;
		}else if(character == '.'){
			common = true;
		}else if(character == '/'){
			common = true;
		}else if(character == ':'){
			common = true;
		}else if(character == ';'){
			common = true;
		}else if(character == '<'){
			common = true;
		}else if(character == '='){
			common = true;
		}else if(character == '>'){
			common = true;
		}else if(character == '?'){
			common = true;
		}else if(character == '@'){
			common = true;
		}else if(character == '['){
			common = true;
		}else if(character == '\\'){
			common = true;
		}else if(character == ']'){
			common = true;
		}else if(character == '^'){
			common = true;
		}else if(character == '_'){
			common = true;
		}

		return common;
	}

	public static boolean charIsCode128BSymbol(char character){
		boolean codeB;

		codeB = false;
		if(character == '`'){
			codeB = true;
		}else if(character == '{'){
			codeB = true;
		}else if(character == '|'){
			codeB = true;
		}else if(character == '}'){
			codeB = true;
		}else if(character == '~'){
			codeB = true;
		}else if(character == 127d){
			/* del*/
			codeB = true;
		}

		return codeB;
	}

	public static boolean charIsCode128ASymbol(char character){
		boolean codeA;
		double n;

		n = character;

		codeA = false;
		if(n >= 0d && n <= 31d){
			codeA = true;
		}

		return codeA;
	}

	public static RGBABitmapImage GenerateBarcodeCode128(char [] chars, double height){
		RGBABitmapImage image;
		boolean success;
		StringReference errorMessages;

		image = new RGBABitmapImage();
		errorMessages = CreateStringReference("".toCharArray());

		success = GenerateBarcodeCode128AllParams(chars, height, 2d, image, errorMessages);

		delete(errorMessages);

		return image;
	}

	public static boolean GenerateBarcodeCode128AllParams(char [] chars, double height, double moduleWidth, RGBABitmapImage image, StringReference errorMessages){
		double w, h, i, code;
		NumberReference counterReference;
		double [] codes;
		boolean success;
		RGBABitmapImage newImage;

		success = IsValidCode128Data(chars, height, moduleWidth, errorMessages);

		if(success){
			codes = Code128Encode(chars);

			h = height;
			w = CalculateCode128Width(codes, moduleWidth);

			newImage = CreateImage(w, h, GetWhite());
			image.x = newImage.x;
			delete(newImage);

			counterReference = new NumberReference();

			/* Start Quiet Zone*/
			counterReference.numberValue = 10d*moduleWidth;

			for(i = 0d; i < codes.length; i = i + 1d){
				code = codes[(int)(i)];
				DrawBarcodeSymbol(image, code, h, moduleWidth, counterReference);
			}

			/* End Quiet Zone*/
			counterReference.numberValue = counterReference.numberValue + 10d*moduleWidth;
		}

		return success;
	}

	public static boolean IsValidCode128Data(char [] chars, double height, double moduleWidth, StringReference errorMessages){
		double validCharacters, i;
		boolean valid;

		validCharacters = 0d;

		for(i = 0d; i < chars.length; i = i + 1d){
			if(chars[(int)(i)] >= 0d && chars[(int)(i)] <= 127d){
				validCharacters = validCharacters + 1d;
			}
		}

		if(validCharacters == chars.length){

			if(height > 0d){
				if(Truncate(height) == height){
					if(moduleWidth > 0d){
						if(Truncate(moduleWidth) == moduleWidth){
							valid = true;
						}else{
							valid = false;
							errorMessages.string = strAppendString(errorMessages.string, "Module width must be a whole number of pixels.".toCharArray());
						}
					}else{
						valid = false;
						errorMessages.string = strAppendString(errorMessages.string, "Module width must be at least one pixel.".toCharArray());
					}
				}else{
					valid = false;
					errorMessages.string = strAppendString(errorMessages.string, "Height must be a whole number of pixels.".toCharArray());
				}
			}else{
				valid = false;
				errorMessages.string = strAppendString(errorMessages.string, "Height must be at least one pixel.".toCharArray());
			}
		}else{
			valid = false;
			errorMessages.string = strAppendString(errorMessages.string, "Input data contains character invalid for this implementation of Code 128. Only 0-127 (inclusive) supported in this implementation.".toCharArray());
		}

		return valid;
	}

	public static double CalculateCode128Width(double [] codes, double moduleWidth){
		double width;

		/* Quiet Zone + 11 * codes + stop symbol extra + Quiet Zone.*/
		width = (10d + codes.length*11d + 2d + 10d)*moduleWidth;

		return width;
	}

	public static double CalculateCode128Checksum(double [] codes){
		return CalculateCode128ChecksumWithLength(codes, codes.length);
	}

	public static double CalculateCode128ChecksumWithLength(double [] codes, double length){
		double checksum, i, position, value;

		checksum = 0d;

		position = 1d;
		for(i = 0d; i < length; i = i + 1d){
			if(i > 1d){
				position = position + 1d;
			}
			value = codes[(int)(i)];
			checksum = checksum + position*value;
		}

		return checksum%103d;
	}

	public static void DrawBarcodeSymbol(RGBABitmapImage image, double barcodeNr, double h, double moduleWidth, NumberReference counterReference){
		double i, j, k, width;
		char widthCharacter;
		char [] widths;
		boolean next;
		RGBA nextColor;

		widths = GetCode128Widths(barcodeNr);

		nextColor = GetBlack();
		next = true;

		for(i = 0d; i < widths.length; i = i + 1d){
			widthCharacter = widths[(int)(i)];
			width = GetNumberFromNumberCharacterForBase(widthCharacter, 10d);

			for(j = 0d; j < width; j = j + 1d){
				for(k = 0d; k < moduleWidth; k = k + 1d){
					DrawVerticalLine1px(image, counterReference.numberValue, 0d, h, nextColor);
					counterReference.numberValue = counterReference.numberValue + 1d;
				}
			}

			if(next){
				nextColor = GetWhite();
			}else{
				nextColor = GetBlack();
			}
			next = !next;
		}
	}

	public static char [] GetCode128Widths(double code){
		char [] spaces;

		spaces = "".toCharArray();

		if(code == 0d){
			spaces = "212222".toCharArray();
		}
		if(code == 1d){
			spaces = "222122".toCharArray();
		}
		if(code == 2d){
			spaces = "222221".toCharArray();
		}
		if(code == 3d){
			spaces = "121223".toCharArray();
		}
		if(code == 4d){
			spaces = "121322".toCharArray();
		}
		if(code == 5d){
			spaces = "131222".toCharArray();
		}
		if(code == 6d){
			spaces = "122213".toCharArray();
		}
		if(code == 7d){
			spaces = "122312".toCharArray();
		}
		if(code == 8d){
			spaces = "132212".toCharArray();
		}
		if(code == 9d){
			spaces = "221213".toCharArray();
		}
		if(code == 10d){
			spaces = "221312".toCharArray();
		}
		if(code == 11d){
			spaces = "231212".toCharArray();
		}
		if(code == 12d){
			spaces = "112232".toCharArray();
		}
		if(code == 13d){
			spaces = "122132".toCharArray();
		}
		if(code == 14d){
			spaces = "122231".toCharArray();
		}
		if(code == 15d){
			spaces = "113222".toCharArray();
		}
		if(code == 16d){
			spaces = "123122".toCharArray();
		}
		if(code == 17d){
			spaces = "123221".toCharArray();
		}
		if(code == 18d){
			spaces = "223211".toCharArray();
		}
		if(code == 19d){
			spaces = "221132".toCharArray();
		}
		if(code == 20d){
			spaces = "221231".toCharArray();
		}
		if(code == 21d){
			spaces = "213212".toCharArray();
		}
		if(code == 22d){
			spaces = "223112".toCharArray();
		}
		if(code == 23d){
			spaces = "312131".toCharArray();
		}
		if(code == 24d){
			spaces = "311222".toCharArray();
		}
		if(code == 25d){
			spaces = "321122".toCharArray();
		}
		if(code == 26d){
			spaces = "321221".toCharArray();
		}
		if(code == 27d){
			spaces = "312212".toCharArray();
		}
		if(code == 28d){
			spaces = "322112".toCharArray();
		}
		if(code == 29d){
			spaces = "322211".toCharArray();
		}
		if(code == 30d){
			spaces = "212123".toCharArray();
		}
		if(code == 31d){
			spaces = "212321".toCharArray();
		}
		if(code == 32d){
			spaces = "232121".toCharArray();
		}
		if(code == 33d){
			spaces = "111323".toCharArray();
		}
		if(code == 34d){
			spaces = "131123".toCharArray();
		}
		if(code == 35d){
			spaces = "131321".toCharArray();
		}
		if(code == 36d){
			spaces = "112313".toCharArray();
		}
		if(code == 37d){
			spaces = "132113".toCharArray();
		}
		if(code == 38d){
			spaces = "132311".toCharArray();
		}
		if(code == 39d){
			spaces = "211313".toCharArray();
		}
		if(code == 40d){
			spaces = "231113".toCharArray();
		}
		if(code == 41d){
			spaces = "231311".toCharArray();
		}
		if(code == 42d){
			spaces = "112133".toCharArray();
		}
		if(code == 43d){
			spaces = "112331".toCharArray();
		}
		if(code == 44d){
			spaces = "132131".toCharArray();
		}
		if(code == 45d){
			spaces = "113123".toCharArray();
		}
		if(code == 46d){
			spaces = "113321".toCharArray();
		}
		if(code == 47d){
			spaces = "133121".toCharArray();
		}
		if(code == 48d){
			spaces = "313121".toCharArray();
		}
		if(code == 49d){
			spaces = "211331".toCharArray();
		}
		if(code == 50d){
			spaces = "231131".toCharArray();
		}
		if(code == 51d){
			spaces = "213113".toCharArray();
		}
		if(code == 52d){
			spaces = "213311".toCharArray();
		}
		if(code == 53d){
			spaces = "213131".toCharArray();
		}
		if(code == 54d){
			spaces = "311123".toCharArray();
		}
		if(code == 55d){
			spaces = "311321".toCharArray();
		}
		if(code == 56d){
			spaces = "331121".toCharArray();
		}
		if(code == 57d){
			spaces = "312113".toCharArray();
		}
		if(code == 58d){
			spaces = "312311".toCharArray();
		}
		if(code == 59d){
			spaces = "332111".toCharArray();
		}
		if(code == 60d){
			spaces = "314111".toCharArray();
		}
		if(code == 61d){
			spaces = "221411".toCharArray();
		}
		if(code == 62d){
			spaces = "431111".toCharArray();
		}
		if(code == 63d){
			spaces = "111224".toCharArray();
		}
		if(code == 64d){
			spaces = "111422".toCharArray();
		}
		if(code == 65d){
			spaces = "121124".toCharArray();
		}
		if(code == 66d){
			spaces = "121421".toCharArray();
		}
		if(code == 67d){
			spaces = "141122".toCharArray();
		}
		if(code == 68d){
			spaces = "141221".toCharArray();
		}
		if(code == 69d){
			spaces = "112214".toCharArray();
		}
		if(code == 70d){
			spaces = "112412".toCharArray();
		}
		if(code == 71d){
			spaces = "122114".toCharArray();
		}
		if(code == 72d){
			spaces = "122411".toCharArray();
		}
		if(code == 73d){
			spaces = "142112".toCharArray();
		}
		if(code == 74d){
			spaces = "142211".toCharArray();
		}
		if(code == 75d){
			spaces = "241211".toCharArray();
		}
		if(code == 76d){
			spaces = "221114".toCharArray();
		}
		if(code == 77d){
			spaces = "413111".toCharArray();
		}
		if(code == 78d){
			spaces = "241112".toCharArray();
		}
		if(code == 79d){
			spaces = "134111".toCharArray();
		}
		if(code == 80d){
			spaces = "111242".toCharArray();
		}
		if(code == 81d){
			spaces = "121142".toCharArray();
		}
		if(code == 82d){
			spaces = "121241".toCharArray();
		}
		if(code == 83d){
			spaces = "114212".toCharArray();
		}
		if(code == 84d){
			spaces = "124112".toCharArray();
		}
		if(code == 85d){
			spaces = "124211".toCharArray();
		}
		if(code == 86d){
			spaces = "411212".toCharArray();
		}
		if(code == 87d){
			spaces = "421112".toCharArray();
		}
		if(code == 88d){
			spaces = "421211".toCharArray();
		}
		if(code == 89d){
			spaces = "212141".toCharArray();
		}
		if(code == 90d){
			spaces = "214121".toCharArray();
		}
		if(code == 91d){
			spaces = "412121".toCharArray();
		}
		if(code == 92d){
			spaces = "111143".toCharArray();
		}
		if(code == 93d){
			spaces = "111341".toCharArray();
		}
		if(code == 94d){
			spaces = "131141".toCharArray();
		}
		if(code == 95d){
			spaces = "114113".toCharArray();
		}
		if(code == 96d){
			spaces = "114311".toCharArray();
		}
		if(code == 97d){
			spaces = "411113".toCharArray();
		}
		if(code == 98d){
			spaces = "411311".toCharArray();
		}
		if(code == 99d){
			spaces = "113141".toCharArray();
		}
		if(code == 100d){
			spaces = "114131".toCharArray();
		}
		if(code == 101d){
			spaces = "311141".toCharArray();
		}
		if(code == 102d){
			spaces = "411131".toCharArray();
		}
		if(code == 103d){
			spaces = "211412".toCharArray();
		}
		if(code == 104d){
			spaces = "211214".toCharArray();
		}
		if(code == 105d){
			spaces = "211232".toCharArray();
		}
		if(code == 106d){
			spaces = "233111".toCharArray();
		}
		if(code == 107d){
			spaces = "211133".toCharArray();
		}
		if(code == 108d){
			spaces = "2331112".toCharArray();
		}

		return spaces;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
