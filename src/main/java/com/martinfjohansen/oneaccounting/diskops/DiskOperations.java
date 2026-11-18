package com.martinfjohansen.oneaccounting.diskops;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import Disk.Disk.DiskStructure;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.OneAccountingState;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static Bytes.Bytes.Bytes.*;
import static Disk.Disk.Disk.Read;
import static Disk.Disk.Disk.Write;
import static DiskRanges.DiskRanges.DiskRanges.WriteRange;
import static JSON.Parser.Parser.ReadJSON;
import static JSON.Writer.Writer.WriteJSON;
import static JSON.Writer.Writer.WriteJSONFromStruct;
import static Unicode.Unicode.Unicode.UTF16ToUTF8;
import static Unicode.Unicode.Unicode.UTF8ToUTF16;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;

public class DiskOperations {
    public static boolean FormatDisk(DiskStructure disk, OneAccountingState state, StringReference message) {
        boolean success;
        Structure header;
        char [] bodyJSON;
        char [] headerJSON;
        double version, bodyLength, i;
        ByteArrayReference bodyBytes, headerBytes;
        ByteArray entryData;

        message.string = "".toCharArray();

        // Clear data
        state.data = CreateNewStructData();

        version = 1d;

        bodyBytes = new ByteArrayReference();
        headerBytes = new ByteArrayReference();
        bodyJSON = WriteJSON(state.data);
        success = UTF16ToUTF8(bodyJSON, bodyBytes);

        if(success) {
            bodyLength = ByteArrayLength(bodyBytes.bytes);

            header = CreateStructure();
            AddNumberToStruct(header, "version".toCharArray(), version);
            AddNumberToStruct(header, "bodyLength".toCharArray(), bodyLength);
            headerJSON = WriteJSONFromStruct(header);
            success = UTF16ToUTF8(headerJSON, headerBytes);

            if (success) {
                // Write header to first entry.
                entryData = CreateAndFillByteArray(state.entrySize, ' ');
                for(i = 0d; i < ByteArrayLength(headerBytes.bytes); i = i + 1d){
                    SetByte(entryData, i, GetByte(headerBytes.bytes, i));
                }

                Write(disk, 0d, entryData);

                // Write body
                WriteRange(disk, state.entrySize, bodyLength, bodyBytes.bytes);
            }

        }

        return success;
    }

    public static boolean IsValidDiskFormat(DiskStructure disk, StringReference message) {
        boolean success;
        ByteArrayReference entryData;
        StringReference jsonRef;
        DataReference dataRef;

        entryData = new ByteArrayReference();
        jsonRef = new StringReference();

        message.string = "".toCharArray();

        // Read and parse header.
        success = Read(disk, 0d, entryData);

        if(success) {
            success = UTF8ToUTF16(entryData.bytes, jsonRef);

            if (success) {
                dataRef = new DataReference();
                success = ReadJSON(jsonRef.string, dataRef, message);

                if (success) {

                } else {
                    message.string = "Header is invalid JSON.".toCharArray();
                }
            } else {
                message.string = "Header is invalid UTF-16.".toCharArray();
            }
        }else{
            message.string = "Reading first disk entry failed.".toCharArray();
        }

        // Validate header.
        // TODO

        // Read body.
        // TODO

        // Validate body.
        // TODO

        return success;
    }

    public static boolean SaveToDisk(DiskStructure disk, OneAccountingState state, StringReference message) {
        boolean success;

        success = false;

        message.string = "Not implemented.".toCharArray();

        return false;
    }

    public static boolean LoadFromDisk(DiskStructure disk, OneAccountingState state, StringReference message) {
        boolean success;

        success = false;

        message.string = "Not implemented.".toCharArray();

        return false;
    }
}
