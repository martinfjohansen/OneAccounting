package com.martinfjohansen.oneaccounting.pPolynomials.Rendering;

import com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.cComplexNumber;
import com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.Structures.LinkedListCharacters;
import com.martinfjohansen.oneaccounting.pPolynomials.ComplexPolynomials.pComplexPolynomial;
import com.martinfjohansen.oneaccounting.references.references.BooleanArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.ComplexNumbers.cComplexToString;
import static com.martinfjohansen.oneaccounting.lists.LinkedListCharacters.LinkedListCharactersFunctions.LinkedListCharactersFunctions.*;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.CreateStringFromNumberWithCheck;
import static com.martinfjohansen.oneaccounting.references.references.references.*;
import static java.lang.Math.abs;

public class Rendering{
	public static char [] pPolynomialToTextDirect(double [] p, char [] x){
		LinkedListCharacters ll;
		char [] str;
		double i, c, j;
		StringReference buffer;

		buffer = new StringReference();

		ll = CreateLinkedListCharacter();

		if(p.length == 0d){
			LinkedListAddCharacter(ll, '0');
		}else{
			for(i = 0d; i < p.length; i = i + 1d){
				c = p[(int)(i)];
				if(c < 0d){
					LinkedListAddCharacter(ll, '-');
				}else{
					LinkedListAddCharacter(ll, '+');
				}

				CreateStringFromNumberWithCheck(abs(c), 10d, buffer);
				LinkedListCharactersAddString(ll, buffer.string);
				delete(buffer.string);

				LinkedListCharactersAddString(ll, x);
				LinkedListAddCharacter(ll, '^');

				CreateStringFromNumberWithCheck(i, 10d, buffer);
				LinkedListCharactersAddString(ll, buffer.string);
				delete(buffer.string);
			}
		}

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}

	public static void pGenerateCommonRenderSpecification(double [] p, BooleanArrayReference showCoefficient, StringReference sign, NumberArrayReference coefficient, BooleanArrayReference showPower, BooleanArrayReference showX){
		double i, zeros, c;
		boolean setZero;

		setZero = false;

		if(p.length == 0d){
			setZero = true;
		}else{
			zeros = 0d;
			for(i = 0d; i < p.length; i = i + 1d){
				if(p[(int)(i)] == 0d){
					zeros = zeros + 1d;
				}
			}

			if(zeros == p.length){
				setZero = true;
			}else{
				showCoefficient.booleanArray = new boolean [(int)(p.length)];
				sign.string = new char [(int)(p.length)];
				coefficient.numberArray = new double [(int)(p.length)];
				showPower.booleanArray = new boolean [(int)(p.length)];
				showX.booleanArray = new boolean [(int)(p.length)];

				for(i = 0d; i < p.length; i = i + 1d){
					c = p[(int)(i)];

					if(c < 0d){
						sign.string[(int)(i)] = '-';
					}else{
						sign.string[(int)(i)] = '+';
					}
					coefficient.numberArray[(int)(i)] = abs(p[(int)(i)]);
					if(c == 0d){
						showCoefficient.booleanArray[(int)(i)] = false;
					}else{
if(abs(c) == 1d && i > 0d){
							showCoefficient.booleanArray[(int)(i)] = false;
						}else{
							showCoefficient.booleanArray[(int)(i)] = true;
						}

						if(i == 0d){
							showX.booleanArray[(int)(i)] = false;
							showPower.booleanArray[(int)(i)] = false;
						}else{
							showX.booleanArray[(int)(i)] = true;
							if(i == 1d){
								showPower.booleanArray[(int)(i)] = false;
							}else{
								showPower.booleanArray[(int)(i)] = true;
							}
						}
					}
				}
			}
		}

		if(setZero){
			showCoefficient.booleanArray = new boolean [1];
			sign.string = new char [1];
			coefficient.numberArray = new double [1];
			showPower.booleanArray = new boolean [1];
			showX.booleanArray = new boolean [1];

			showCoefficient.booleanArray[0] = true;
			sign.string[0] = '+';
			coefficient.numberArray[0] = 0d;
			showPower.booleanArray[0] = true;
			showX.booleanArray[0] = false;
		}
	}

	public static char [] pPolynomialToText(double [] p, char [] x){
		LinkedListCharacters ll;
		char [] str;
		double i, c;
		StringReference buffer;
		BooleanArrayReference showCoefficient, showPower, showX;
		StringReference sign;
		NumberArrayReference coefficient;
		boolean hasPrinted;

		showCoefficient = CreateBooleanArrayReferenceLengthValue(0d, false);
		showPower = CreateBooleanArrayReferenceLengthValue(0d, false);
		showX = CreateBooleanArrayReferenceLengthValue(0d, false);
		sign = CreateStringReferenceLengthValue(0d, ' ');
		coefficient = CreateNumberArrayReferenceLengthValue(0d, 0d);

		pGenerateCommonRenderSpecification(p, showCoefficient, sign, coefficient, showPower, showX);

		buffer = CreateStringReferenceLengthValue(0d, ' ');

		ll = CreateLinkedListCharacter();

		hasPrinted = false;
		for(i = 0d; i < showCoefficient.booleanArray.length; i = i + 1d){
			c = p[(int)(i)];

			if(showCoefficient.booleanArray[(int)(i)] || showX.booleanArray[(int)(i)]){
				if(!hasPrinted && c >= 0d){
				}else{
					LinkedListAddCharacter(ll, sign.string[(int)(i)]);
				}

				if(showCoefficient.booleanArray[(int)(i)]){
					CreateStringFromNumberWithCheck(coefficient.numberArray[(int)(i)], 10d, buffer);
					LinkedListCharactersAddString(ll, buffer.string);
					delete(buffer.string);
					hasPrinted = true;
				}

				if(showX.booleanArray[(int)(i)]){
					LinkedListCharactersAddString(ll, x);
					hasPrinted = true;
					if(showPower.booleanArray[(int)(i)]){
						LinkedListAddCharacter(ll, '^');
						CreateStringFromNumberWithCheck(i, 10d, buffer);
						LinkedListCharactersAddString(ll, buffer.string);
						delete(buffer.string);
					}
				}
			}
		}

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}

	public static char [] pComplexPolynomialToTextDirect(pComplexPolynomial p, char [] x){
		LinkedListCharacters ll;
		char [] str, number;
		double i;
		cComplexNumber c;
		StringReference buffer;

		buffer = new StringReference();

		ll = CreateLinkedListCharacter();

		if(p.cs.length == 0d){
			LinkedListAddCharacter(ll, '0');
		}else{
			for(i = 0d; i < p.cs.length; i = i + 1d){
				c = p.cs[(int)(i)];
				if(i > 0d){
					LinkedListAddCharacter(ll, '+');
				}

				number = cComplexToString(c);
				LinkedListAddCharacter(ll, '(');
				LinkedListCharactersAddString(ll, number);
				LinkedListAddCharacter(ll, ')');
				delete(number);

				LinkedListCharactersAddString(ll, x);
				LinkedListAddCharacter(ll, '^');

				CreateStringFromNumberWithCheck(i, 10d, buffer);
				LinkedListCharactersAddString(ll, buffer.string);
				delete(buffer.string);
			}
		}

		str = LinkedListCharactersToArray(ll);
		FreeLinkedListCharacter(ll);

		return str;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
