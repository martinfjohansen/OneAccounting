package JSON.Parser;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringArrayReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static JSON.TokenReader.TokenReader.JSONTokenize;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.cCharacters.Characters.Characters.cIsNumber;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.CreateNumberFromDecimalString;
import static com.martinfjohansen.oneaccounting.references.references.references.CreateNumberReference;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.*;

public class Parser {
    public static boolean ReadJSON(char[] string, DataReference dataReference, StringReference message) {
        StringArrayReference tokenArrayReference;
        boolean success;

        // Tokenize.
        tokenArrayReference = new StringArrayReference();
        success = JSONTokenize(string, tokenArrayReference, message);

        if (success) {
            // Parse.
            success = GetJSONValue(tokenArrayReference.stringArray, dataReference, message);
        }

        return success;
    }

    public static boolean GetJSONValue(StringReference [] tokens, DataReference dataReference, StringReference message){
        NumberReference i;
        boolean success;

        i = CreateNumberReference(0d);
        success = GetJSONValueRecursive(tokens, i, 0d, dataReference, message);

        return success;
    }

    public static boolean GetJSONValueRecursive(StringReference [] tokens, NumberReference i, double depth, DataReference dataReference, StringReference message){
        char [] str, substr, token;
        double stringToDecimalResult;
        boolean success;

        success = true;
        token = tokens[(int)i.numberValue].string;

        if(arraysStringsEqual(token, "{".toCharArray())){
            success = GetJSONObject(tokens, i, depth + 1d, dataReference, message);
        }else if(arraysStringsEqual(token, "[".toCharArray())){
            success = GetJSONArray(tokens, i, depth + 1d, dataReference, message);
        }else if(arraysStringsEqual(token, "true".toCharArray())){
            dataReference.data = CreateBooleanData(true);
            i.numberValue  = i.numberValue + 1d;
        }else if(arraysStringsEqual(token, "false".toCharArray())){
            dataReference.data = CreateBooleanData(false);
            i.numberValue  = i.numberValue + 1d;
        }else if(arraysStringsEqual(token, "null".toCharArray())){
            dataReference.data = CreateNoTypeData();
            i.numberValue  = i.numberValue + 1d;
        }else if(cIsNumber(token[0]) || token[0] == '-'){
            stringToDecimalResult = CreateNumberFromDecimalString(token);
            dataReference.data = CreateNumberData(stringToDecimalResult);
            i.numberValue  = i.numberValue + 1d;
        }else if(token[0] == '\"'){
            substr = strSubstring(token, 1d, token.length - 1d);
            dataReference.data = CreateStringData(substr);
            i.numberValue  = i.numberValue + 1d;
        }else{
            str = "".toCharArray();
            str = strConcatenateString(str, "Invalid token first in value: ".toCharArray());
            str = strAppendString(str, token);
            message.string = str;
            success = false;
        }

        if(success && depth == 0d){
            if(arraysStringsEqual(tokens[(int)i.numberValue].string, "<end>".toCharArray())){
            }else{
                message.string = "The outer value cannot have any tokens following it.".toCharArray();
                success = false;
            }
        }

        return success;
    }

    public static boolean GetJSONObject(StringReference [] tokens, NumberReference i, double depth, DataReference dataReference, StringReference message) {
        Data data, value;
        boolean done, success;
        char [] key, colon, comma, closeCurly;
        char [] keystring, str;
        DataReference valueReference;

        data = CreateNewStructData();
        valueReference = new DataReference();
        success = true;
        i.numberValue  = i.numberValue + 1d;

        if (!arraysStringsEqual(tokens[(int)i.numberValue].string, "}".toCharArray())){
            done = false;

            for (; !done && success; ) {
                key = tokens[(int) i.numberValue].string;

                if (key[0] == '\"') {
                    i.numberValue = i.numberValue + 1d;
                    colon = tokens[(int) i.numberValue].string;
                    if (arraysStringsEqual(colon, ":".toCharArray())) {
                        i.numberValue = i.numberValue + 1d;
                        success = GetJSONValueRecursive(tokens, i, depth, valueReference, message);

                        if (success) {
                            keystring = strSubstring(key, 1d, key.length - 1d);
                            value = valueReference.data;

                            AddDataToStruct(data.structure, keystring, value);

                            comma = tokens[(int) i.numberValue].string;
                            if (arraysStringsEqual(comma, ",".toCharArray())) {
                                // OK
                                i.numberValue = i.numberValue + 1d;
                            } else {
                                done = true;
                            }
                        }
                    } else {
                        str = "".toCharArray();
                        str = strConcatenateString(str, "Expected colon after key in object: ".toCharArray());
                        str = strAppendString(str, colon);
                        message.string = str;

                        success = false;
                        done = true;
                    }
                } else {
                    message.string = "Expected string as key in object.".toCharArray();

                    done = true;
                    success = false;
                }
            }
        }

        if(success) {
            closeCurly = tokens[(int) i.numberValue].string;

            if (arraysStringsEqual(closeCurly, "}".toCharArray())) {
                // OK
                dataReference.data = data;
                i.numberValue  = i.numberValue + 1d;
            } else {
                message.string = "Expected close curly brackets at end of object value.".toCharArray();
                success = false;
            }
        }

        delete(valueReference);

        return success;
    }

    public static boolean GetJSONArray(StringReference [] tokens, NumberReference i, double depth, DataReference dataReference, StringReference message) {
        Data data, value;
        char [] nextToken, comma;
        boolean done, success;
        DataReference valueReference;

        i.numberValue  = i.numberValue + 1d;

        valueReference = new DataReference();
        success = true;
        data = CreateNewArrayData();

        nextToken = tokens[(int)i.numberValue].string;

        if(!arraysStringsEqual(nextToken, "]".toCharArray())) {
            done = false;
            for (; !done && success; ) {
                success = GetJSONValueRecursive(tokens, i, depth, valueReference, message);

                if(success){
                    value = valueReference.data;
                    AddDataToArray(data.array, value);

                    comma = tokens[(int) i.numberValue].string;

                    if (arraysStringsEqual(comma, ",".toCharArray())) {
                        // OK
                        i.numberValue = i.numberValue + 1d;
                    } else {
                        done = true;
                    }
                }
            }
        }

        nextToken = tokens[(int)i.numberValue].string;
        if (arraysStringsEqual(nextToken, "]".toCharArray())) {
            // OK
            i.numberValue = i.numberValue + 1d;
        } else {
            message.string = "Expected close square bracket at end of array.".toCharArray();
            success = false;
        }

        dataReference.data = data;
        delete(valueReference);

        return success;
    }

    public static void delete(Object o){
        // Java has garbage collection.
    }
}
