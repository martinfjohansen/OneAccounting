package com.martinfjohansen.oneaccounting.strstrings.strings;

import static java.lang.Math.*;

import com.martinfjohansen.oneaccounting.lists.DynamicArrayCharacters.Structures.DynamicArrayCharacters;
import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.LinkedListCharacters;
import com.martinfjohansen.oneaccounting.lists.LinkedListStrings.Structures.LinkedListStrings;
import com.martinfjohansen.oneaccounting.references.references.BooleanReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;
import com.martinfjohansen.oneaccounting.lists.DynamicArrayCharacters.Structures.*;

import static com.martinfjohansen.oneaccounting.lists.DynamicArrayCharacters.DynamicArrayCharactersFunctions.DynamicArrayCharactersFunctions.*;

import com.martinfjohansen.oneaccounting.lists.LinkedListStrings.Structures.*;

import static com.martinfjohansen.oneaccounting.lists.LinkedListStrings.LinkedListStringsFunctions.LinkedListStringsFunctions.*;

import static com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.LinkedListCharactersFunctions.LinkedListCharactersFunctions.*;

import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.*;

import com.martinfjohansen.oneaccounting.references.references.*;
import static com.martinfjohansen.oneaccounting.references.references.references.*;

import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.*;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.*;


import static com.martinfjohansen.oneaccounting.strstrings.stream.stream.*;

public class strings{
	public static boolean strSubstringWithCheck(char [] string, double from, double to, StringReference stringReference){
		boolean success;

		if(from >= 0d && from <= string.length && to >= 0d && to <= string.length && from <= to){
			stringReference.string = strSubstring(string, from, to);
			success = true;
		}else{
			success = false;
		}

		return success;
	}

	public static char [] strSubstring(char [] string, double from, double to){
		char [] n;
		double i, length;

		length = to - from;

		n = new char [(int)(length)];

		for(i = from; i < to; i = i + 1d){
			n[(int)(i - from)] = string[(int)(i)];
		}

		return n;
	}

	public static char [] strAppendString(char [] s1, char [] s2){
		char [] newString;

		newString = strConcatenateString(s1, s2);

		delete(s1);

		return newString;
	}

	public static char [] strConcatenateString(char [] s1, char [] s2){
		char [] newString;
		double i;

		newString = new char [(int)(s1.length + s2.length)];

		for(i = 0d; i < s1.length; i = i + 1d){
			newString[(int)(i)] = s1[(int)(i)];
		}

		for(i = 0d; i < s2.length; i = i + 1d){
			newString[(int)(s1.length + i)] = s2[(int)(i)];
		}

		return newString;
	}

	public static char [] strAppendCharacter(char [] string, char c){
		char [] newString;

		newString = strConcatenateCharacter(string, c);

		delete(string);

		return newString;
	}

	public static char [] strConcatenateCharacter(char [] string, char c){
		char [] newString;
		double i;
		newString = new char [(int)(string.length + 1d)];

		for(i = 0d; i < string.length; i = i + 1d){
			newString[(int)(i)] = string[(int)(i)];
		}

		newString[(int)(string.length)] = c;

		return newString;
	}

	public static StringReference [] strSplitByCharacter(char [] toSplit, char splitBy){
		StringReference [] parts;
		double i;
		char c;
		LinkedListStrings ll;
		LinkedListCharacters next;
		char [] part;

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0d; i < toSplit.length; i = i + 1d){
			c = toSplit[(int)(i)];

			if(c == splitBy){
				part = LinkedListCharactersToArray(next);
				LinkedListAddString(ll, part);
				FreeLinkedListCharacter(next);
				next = CreateLinkedListCharacter();
			}else{
				LinkedListAddCharacter(next, c);
			}
		}

		part = LinkedListCharactersToArray(next);
		LinkedListAddString(ll, part);
		FreeLinkedListCharacter(next);

		parts = LinkedListStringsToArray(ll);
		FreeLinkedListString(ll);

		return parts;
	}

	public static boolean strIndexOfCharacter(char [] string, char character, NumberReference indexReference){
		double i;
		boolean found;

		found = false;
		for(i = 0d; i < string.length && !found; i = i + 1d){
			if(string[(int)(i)] == character){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}

	public static boolean strLastIndexOfCharacter(char [] string, char character, NumberReference indexReference){
		double i;
		boolean found;

		found = false;
		for(i = 0d; i < string.length; i = i + 1d){
			if(string[(int)(i)] == character){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}

	public static boolean strSubstringEqualsWithCheck(char [] string, double from, char [] substring, BooleanReference equalsReference){
		boolean success;

		if(from < string.length){
			success = true;
			equalsReference.booleanValue = strSubstringEquals(string, from, substring);
		}else{
			success = false;
		}

		return success;
	}

	public static boolean strSubstringEquals(char [] string, double from, char [] substring){
		double i;
		boolean equal;

		equal = true;
		if(string.length - from >= substring.length){
			for(i = 0d; i < substring.length && equal; i = i + 1d){
				if(string[(int)(from + i)] != substring[(int)(i)]){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}

	public static boolean strIndexOfString(char [] string, char [] substring, NumberReference indexReference){
		double i;
		boolean found;

		found = false;
		for(i = 0d; i < string.length - substring.length + 1d && !found; i = i + 1d){
			if(strSubstringEquals(string, i, substring)){
				found = true;
				indexReference.numberValue = i;
			}
		}

		return found;
	}

	public static boolean strContainsCharacter(char [] string, char character){
		double i;
		boolean found;

		found = false;
		for(i = 0d; i < string.length && !found; i = i + 1d){
			if(string[(int)(i)] == character){
				found = true;
			}
		}

		return found;
	}

	public static boolean strContainsString(char [] string, char [] substring){
		return strIndexOfString(string, substring, new NumberReference());
	}

	public static void strToUpperCase(char [] string){
		double i;

		for(i = 0d; i < string.length; i = i + 1d){
			string[(int)(i)] = cToUpperCase(string[(int)(i)]);
		}
	}

	public static void strToLowerCase(char [] string){
		double i;

		for(i = 0d; i < string.length; i = i + 1d){
			string[(int)(i)] = cToLowerCase(string[(int)(i)]);
		}
	}

	public static boolean strEqualsIgnoreCase(char [] a, char [] b){
		boolean equal;
		double i;

		if(a.length == b.length){
			equal = true;
			for(i = 0d; i < a.length && equal; i = i + 1d){
				if(cToLowerCase(a[(int)(i)]) != cToLowerCase(b[(int)(i)])){
					equal = false;
				}
			}
		}else{
			equal = false;
		}

		return equal;
	}

	public static char [] strReplaceString(char [] string, char [] toReplace, char [] replaceWith){
		char [] result;
		double i, j;
		BooleanReference equalsReference;
		boolean success;
		DynamicArrayCharacters da;

		da = CreateDynamicArrayCharacters();

		equalsReference = new BooleanReference();

		for(i = 0d; i < string.length; ){
			success = strSubstringEqualsWithCheck(string, i, toReplace, equalsReference);
			if(success){
				success = equalsReference.booleanValue;
			}

			if(success && toReplace.length > 0d){
				for(j = 0d; j < replaceWith.length; j = j + 1d){
					DynamicArrayAddCharacter(da, replaceWith[(int)(j)]);
				}
				i = i + toReplace.length;
			}else{
				DynamicArrayAddCharacter(da, string[(int)(i)]);
				i = i + 1d;
			}
		}

		result = DynamicArrayCharactersToArray(da);

		FreeDynamicArrayCharacters(da);

		return result;
	}

	public static char [] strReplaceCharacterToNew(char [] string, char toReplace, char replaceWith){
		char [] result;
		double i;

		result = new char [(int)(string.length)];

		for(i = 0d; i < string.length; i = i + 1d){
			if(string[(int)(i)] == toReplace){
				result[(int)(i)] = replaceWith;
			}else{
				result[(int)(i)] = string[(int)(i)];
			}
		}

		return result;
	}

	public static void strReplaceCharacter(char [] string, char toReplace, char replaceWith){
		double i;

		for(i = 0d; i < string.length; i = i + 1d){
			if(string[(int)(i)] == toReplace){
				string[(int)(i)] = replaceWith;
			}
		}
	}

	public static char [] strTrim(char [] string){
		char [] result;
		double i, lastWhitespaceLocationStart, lastWhitespaceLocationEnd;
		boolean firstNonWhitespaceFound;

		/* Find whitepaces at the start.*/
		lastWhitespaceLocationStart = -1d;
		firstNonWhitespaceFound = false;
		for(i = 0d; i < string.length && !firstNonWhitespaceFound; i = i + 1d){
			if(cIsWhiteSpace(string[(int)(i)])){
				lastWhitespaceLocationStart = i;
			}else{
				firstNonWhitespaceFound = true;
			}
		}

		/* Find whitepaces at the end.*/
		lastWhitespaceLocationEnd = string.length;
		firstNonWhitespaceFound = false;
		for(i = string.length - 1d; i >= 0d && !firstNonWhitespaceFound; i = i - 1d){
			if(cIsWhiteSpace(string[(int)(i)])){
				lastWhitespaceLocationEnd = i;
			}else{
				firstNonWhitespaceFound = true;
			}
		}

		if(lastWhitespaceLocationStart < lastWhitespaceLocationEnd){
			result = strSubstring(string, lastWhitespaceLocationStart + 1d, lastWhitespaceLocationEnd);
		}else{
			result = new char [0];
		}

		return result;
	}

	public static boolean strStartsWith(char [] string, char [] start){
		boolean startsWithString;

		startsWithString = false;
		if(string.length >= start.length){
			startsWithString = strSubstringEquals(string, 0d, start);
		}

		return startsWithString;
	}

	public static boolean strEndsWith(char [] string, char [] end){
		boolean endsWithString;

		endsWithString = false;
		if(string.length >= end.length){
			endsWithString = strSubstringEquals(string, string.length - end.length, end);
		}

		return endsWithString;
	}

	public static StringReference [] strSplitByString(char [] toSplit, char [] splitBy){
		StringReference [] parts;
		double i;
		char c;
		LinkedListStrings ll;
		LinkedListCharacters next;
		char [] part;

		ll = CreateLinkedListString();

		next = CreateLinkedListCharacter();
		for(i = 0d; i < toSplit.length; ){
			c = toSplit[(int)(i)];

			if(strSubstringEquals(toSplit, i, splitBy)){
				part = LinkedListCharactersToArray(next);
				LinkedListAddString(ll, part);
				FreeLinkedListCharacter(next);
				next = CreateLinkedListCharacter();
				i = i + splitBy.length;
			}else{
				LinkedListAddCharacter(next, c);
				i = i + 1d;
			}
		}

		part = LinkedListCharactersToArray(next);
		LinkedListAddString(ll, part);
		FreeLinkedListCharacter(next);

		parts = LinkedListStringsToArray(ll);
		FreeLinkedListString(ll);

		return parts;
	}

	public static boolean strStringIsBefore(char [] a, char [] b){
		boolean before, equal, done;
		double i;

		before = false;
		equal = true;
		done = false;

		if(a.length == 0d && b.length > 0d){
			before = true;
		}else{
			for(i = 0d; i < a.length && i < b.length && !done; i = i + 1d){
				if(a[(int)(i)] != b[(int)(i)]){
					equal = false;
				}
				if(cCharacterIsBefore(a[(int)(i)], b[(int)(i)])){
					before = true;
				}
				if(cCharacterIsBefore(b[(int)(i)], a[(int)(i)])){
					done = true;
				}
			}

			if(equal){
				if(a.length < b.length){
					before = true;
				}
			}
		}

		return before;
	}

	public static char [] strJoinStringsWithSeparator(StringReference [] strings, char [] separator){
		char [] result, string;
		double length, i;
		NumberReference index;

		index = CreateNumberReference(0d);

		length = 0d;
		for(i = 0d; i < strings.length; i = i + 1d){
			length = length + strings[(int)(i)].string.length;
		}
		length = length + (strings.length - 1d)*separator.length;

		result = new char [(int)(length)];

		for(i = 0d; i < strings.length; i = i + 1d){
			string = strings[(int)(i)].string;
			strWriteStringToStingStream(result, index, string);
			if(i + 1d < strings.length){
				strWriteStringToStingStream(result, index, separator);
			}
		}

		delete(index);

		return result;
	}

	public static char [] strJoinStrings(StringReference [] strings){
		char [] result, string;
		double length, i;
		NumberReference index;

		index = CreateNumberReference(0d);

		length = 0d;
		for(i = 0d; i < strings.length; i = i + 1d){
			length = length + strings[(int)(i)].string.length;
		}

		result = new char [(int)(length)];

		for(i = 0d; i < strings.length; i = i + 1d){
			string = strings[(int)(i)].string;
			strWriteStringToStingStream(result, index, string);
		}

		delete(index);

		return result;
	}

	public static double strStringOrder(char [] a, char [] b){
		double order, minimum, i, ac, bc;
		boolean done;

		minimum = min(a.length, b.length);

		done = false;
		order = 0d;
		for(i = 0d; i < minimum && !done; i = i + 1d){
			ac = a[(int)(i)];
			bc = b[(int)(i)];

			if(ac < bc){
				done = true;
				order = 1d;
			}else if(ac > bc){
				done = true;
				order = -1d;
			}
		}

		if(!done){
			if(a.length < b.length){
				order = 1d;
			}else if(a.length > b.length){
				order = -1d;
			}
		}

		return order;
	}

	public static char [] strLeftPad(char [] str, double width){
		double i;
		char [] padded;

		padded = new char [(int)(width)];
		arraysFillString(padded, ' ');

		for(i = 0d; i < str.length; i = i + 1d){
			padded[(int)(width - str.length + i)] = str[(int)(i)];
		}

		return padded;
	}

	public static char [] strRightPad(char [] str, double width){
		double i;
		char [] padded;

		padded = new char [(int)(width)];
		arraysFillString(padded, ' ');

		for(i = 0d; i < str.length; i = i + 1d){
			padded[(int)(i)] = str[(int)(i)];
		}

		return padded;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
