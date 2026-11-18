package com.martinfjohansen.oneaccounting;

import Bytes.Bytes.ByteArrayReference;
import Disk.Disk.DiskStructure;
import ProcessingUnit.ProcessingUnitServer.ProcessingUnitServerStructure;
import ProcessingUnitController.ProcessingUnitController.ProcessingUnitControllerStructure;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static Disk.Disk.Disk.*;
import static Disk.Disk.Disk.Entries;
import static JSON.Parser.Parser.ReadJSON;
import static JSON.Writer.Writer.WriteJSON;
import static ProcessingUnit.ProcessingUnitServer.ProcessingUnitServer.*;
import static ProcessingUnitController.ProcessingUnitController.ProcessingUnitController.CreateJavaPUC;
import static ProcessingUnitController.ProcessingUnitController.ProcessingUnitController.WaitInterrupt;
import static Unicode.Unicode.Unicode.UTF16ToUTF8;
import static Unicode.Unicode.Unicode.UTF8ToUTF16;
import static com.martinfjohansen.oneaccounting.CommandHandler.HandleCommand;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.references.references.references.*;

public class OneAccountingServer {
    public static void main(String[] args) {
        boolean success;

        System.out.println("One Accounting Server");

        ProcessingUnitControllerStructure puc = CreateJavaPUC();
        ProcessingUnitServerStructure client = CreateHTTPServer(puc,"127.0.0.1", 8081);
        DiskStructure disk = new DiskStructure();
        CreateFileDisk(disk, "disk.dat", 100 * 1024, 1024);
        OneAccountingState state = new OneAccountingState();

        success = OneAccountingInitialize(puc, client, disk, state);

        if(success){
            System.out.println("Ready to accept commands");
        }

        for(;;){
            OneAccountingIteration(puc, client, disk, state);
        }
    }

    public static boolean OneAccountingInitialize(ProcessingUnitControllerStructure puc, ProcessingUnitServerStructure adminPort, DiskStructure disk, OneAccountingState state) {
        NumberReference entriesRef, entrySizeRef;

        state.idles = 0d;

        entriesRef = CreateNumberReference(0d);
        entrySizeRef = CreateNumberReference(0d);

        Entries(disk, entriesRef, entrySizeRef);

        state.entries = entriesRef.numberValue;
        state.entrySize = entrySizeRef.numberValue;

        delete(entriesRef);
        delete(entrySizeRef);

        return true;
    }

    public static void OneAccountingIteration(ProcessingUnitControllerStructure puc, ProcessingUnitServerStructure clientPort, DiskStructure disk, OneAccountingState state) {
        boolean success, requestAvailable;
        ByteArrayReference outputBytes;
        char [] outputJSON;
        ByteArrayReference requestBytesRef;
        Data output;
        DataReference outputDataRef;
        StringReference inputJsonRef, message;
        DataReference input;

        message = CreateStringReference("".toCharArray());
        outputBytes = new ByteArrayReference();
        outputDataRef = new DataReference();
        outputDataRef.data = CreateNewStructData();

        WaitInterrupt(puc, 10d);

        requestAvailable = ServerCheck(clientPort);

        if(requestAvailable){
            requestBytesRef = new ByteArrayReference();
            ServerReceive(clientPort, requestBytesRef);

            inputJsonRef = new StringReference();
            success = UTF8ToUTF16(requestBytesRef.bytes, inputJsonRef);

            if(success) {

                input = new DataReference();
                success = ReadJSON(inputJsonRef.string, input, message);

                if(success) {
                    success = HandleCommand(disk, input.data, state, outputDataRef, message);
                }
            }

            if(success){
                output = CreateNewStructData();
                AddBooleanToStruct(output.structure, "success".toCharArray(), success);
                AddStringToStruct(output.structure, "message".toCharArray(), message.string);
                AddDataToStruct(output.structure, "data".toCharArray(), outputDataRef.data);
                outputJSON = WriteJSON(output);
                success = UTF16ToUTF8(outputJSON, outputBytes);
            }

            if(success){

            }else{
                output = CreateNewStructData();
                AddBooleanToStruct(output.structure, "success".toCharArray(), success);
                AddStringToStruct(output.structure, "message".toCharArray(), message.string);
                outputJSON = WriteJSON(output);
                UTF16ToUTF8(outputJSON, outputBytes);
            }

            ServerSend(clientPort, outputBytes.bytes);
        }

        if(!requestAvailable){
            state.idles = state.idles + 1d;
        }
    }

    public static void delete(Object entry) {
        // Java has garbage collection.
    }
}
