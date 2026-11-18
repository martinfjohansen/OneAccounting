package JSON.Validator;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static JSON.Parser.Parser.ReadJSON;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.FreeData;

public class Validator {
    public static boolean IsValidJSON(char [] json, StringReference message){
        boolean success;
        DataReference elementReference;

        elementReference = new DataReference();

        success = ReadJSON(json, elementReference, message);

        if(success) {
            FreeData(elementReference.data);
        }

        return success;
    }
}
