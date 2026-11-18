package JSON.Comparator;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Array;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.references.references.BooleanReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static JSON.Parser.Parser.ReadJSON;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays.Arrays.ArrayIndex;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.math.math.math.EpsilonCompare;
import static com.martinfjohansen.oneaccounting.references.references.references.FreeStringReferenceArray;

public class Comparator {
    public static boolean JSONCompare(char [] a, char [] b, double epsilon, BooleanReference equal, StringReference message){
        boolean success;
        DataReference eaRef, ebRef;
        Data ea, eb;

        eaRef = new DataReference();
        ebRef = new DataReference();

        success = ReadJSON(a, eaRef, message);

        if(success) {
            ea = eaRef.data;

            success = ReadJSON(b, ebRef, message);

            if(success){
                eb = ebRef.data;

                equal.booleanValue = JSONCompareElements(ea, eb, epsilon);

                FreeData(eb);
            }

            FreeData(ea);
        }

        return success;
    }

    public static boolean JSONCompareElements(Data ea, Data eb, double epsilon){
        boolean equal;

        equal = DataTypeEquals(ea, eb);
        
        if(equal){
            if(IsStructure(ea)){
                equal = JSONCompareObjects(ea.structure, eb.structure, epsilon);
            }else if(IsString(ea)){
                equal = arraysStringsEqual(ea.string, eb.string);
            }else if(IsArray(ea)){
                equal = JSONCompareArrays(ea.array, eb.array, epsilon);
            }else if(IsNumber(ea)){
                equal = EpsilonCompare(ea.number, eb.number, epsilon);
            }else if(IsNoType(ea)){
                equal = true;
            }else if(IsBoolean(ea)){
                equal = ea.booleanx == eb.booleanx;
            }
        }
        
        return equal;
    }

    public static boolean JSONCompareArrays(Array ea, Array eb, double epsilon) {
        boolean equals;
        double i, length;

        equals = ea.length == eb.length;

        if(equals){
            length = ea.length;
            for(i = 0d; i < length && equals; i = i + 1d){
                equals = JSONCompareElements(ArrayIndex(ea, i), ArrayIndex(eb, i), epsilon);
            }
        }

        return equals;
    }

    public static boolean JSONCompareObjects(Structure ea, Structure eb, double epsilon) {
        boolean equals;
        double akeys, bkeys, i;
        StringReference [] keys;
        char [] key;
        BooleanReference aFoundReference, bFoundReference;
        Data eaValue, ebValue;

        aFoundReference = new BooleanReference();
        bFoundReference = new BooleanReference();

        akeys = StructKeys(ea);
        bkeys = StructKeys(eb);

        equals = akeys == bkeys;

        if(equals){
            keys = GetStructKeys(ea);

            for(i = 0d; i < keys.length && equals; i = i + 1d){
                key = keys[(int)i].string;

                eaValue = GetDataFromStructWithCheck(ea, key, aFoundReference);
                ebValue = GetDataFromStructWithCheck(eb, key, bFoundReference);

                if(aFoundReference.booleanValue && bFoundReference.booleanValue){
                    equals = JSONCompareElements(eaValue, ebValue, epsilon);
                }else{
                    equals = false;
                }
            }

            FreeStringReferenceArray(keys);
        }

        return equals;
    }

    public static void delete(Object object){
        // Java has garbage collection.
    }
}
