package com.martinfjohansen.oneaccounting.strstrings.stream;

import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.*;

public class stream{
	public static void strWriteStringToStingStream(char [] stream, NumberReference index, char [] src){
		double i;

		for(i = 0d; i < src.length; i = i + 1d){
			stream[(int)(index.numberValue + i)] = src[(int)(i)];
		}
		index.numberValue = index.numberValue + src.length;
	}

	public static void strWriteCharacterToStingStream(char [] stream, NumberReference index, char src){
		stream[(int)(index.numberValue)] = src;
		index.numberValue = index.numberValue + 1d;
	}

	public static void strWriteBooleanToStingStream(char [] stream, NumberReference index, boolean src){
		if(src){
			strWriteStringToStingStream(stream, index, "true".toCharArray());
		}else{
			strWriteStringToStingStream(stream, index, "false".toCharArray());
		}
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
