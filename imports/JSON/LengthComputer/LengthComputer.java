package JSON.LengthComputer;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static JSON.Writer.Writer.JSONEscapedStringLength;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.ArrayIndex;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.CreateStringDecimalFromNumber;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.CreateStringScientificNotationDecimalFromNumber;
import static java.lang.Math.*;

public class LengthComputer {
    public static double ComputeJSONStringLength(Data data) {
        double result;

        result = 0d;

        if(IsStructure(data)){
            result = result + ComputeJSONObjectStringLength(data);
        }else if(IsString(data)){
            result = JSONEscapedStringLength(data.string) + 2d;
        }else if(IsArray(data)){
            result = result + ComputeJSONArrayStringLength(data);
        }else if(IsNumber(data)){
            result = result + ComputeJSONNumberStringLength(data);
        }else if(IsNoType(data)){
            result = result + "null".toCharArray().length;
        }else if(IsBoolean(data)){
            result = result + ComputeJSONBooleanStringLength(data);
        }

        return result;
    }

    public static double ComputeJSONBooleanStringLength(Data data) {
        double result;

        if(data.booleanx){
            result = "true".toCharArray().length;
        }else{
            result = "false".toCharArray().length;
        }

        return result;
    }

    public static double ComputeJSONNumberStringLength(Data data) {
        double length;
        char[] a;

        if(data.number != 0d) {
            if (abs(data.number) >= pow(10d, 15d) || abs(data.number) <= pow(10d, -15d)) {
                a = CreateStringScientificNotationDecimalFromNumber(data.number);
                length = a.length;
            } else {
                a = CreateStringDecimalFromNumber(data.number);
                length = a.length;
            }
        }else{
            length = 1d;
        }

        return length;
    }

    public static double ComputeJSONArrayStringLength(Data data) {
        Data arrayElement;
        double i;
        double length;

        length = 1d;

        for(i = 0d; i < data.array.length; i = i + 1d){
            arrayElement = ArrayIndex(data.array, i);

            length = length + ComputeJSONStringLength(arrayElement);

            if(i + 1d != data.array.length){
                length = length + 1d;
            }
        }

        length = length + 1d;

        return length;
    }

    public static double ComputeJSONObjectStringLength(Data data) {
        char [] key;
        double i;
        StringReference[] keys;
        Data objectElement;
        double length;

        length = 1d;

        keys = GetStructKeys(data.structure);
        for(i = 0; i < keys.length; i = i + 1d){
            key = keys[(int)i].string;
            objectElement = GetDataFromStruct(data.structure, key);

            length = length + 1d;
            length = length + JSONEscapedStringLength(key);
            length = length + 1d;
            length = length + 1d;

            length = length + ComputeJSONStringLength(objectElement);

            if(i + 1d != keys.length){
                length = length + 1d;
            }
        }

        length = length + 1d;

        return length;
    }
}
