package com.martinfjohansen.oneaccounting;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import Disk.Disk.DiskStructure;
import Disk.DiskServer.DiskServerStructure;
import ProcessingUnit.ProcessingUnitServer.ProcessingUnitServer;
import ProcessingUnit.ProcessingUnitServer.ProcessingUnitServerStructure;
import ProcessingUnitController.ProcessingUnitController.ProcessingUnitControllerStructure;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static Disk.Disk.Disk.*;
import static Disk.Disk.Disk.Entries;
import static Disk.DiskServer.DiskServer.*;
import static JSON.Writer.Writer.WriteJSON;
import static ProcessingUnit.ProcessingUnitServer.ProcessingUnitServer.*;
import static ProcessingUnitController.ProcessingUnitController.ProcessingUnitController.CreateJavaPUC;
import static ProcessingUnitController.ProcessingUnitController.ProcessingUnitController.WaitInterrupt;
import static Unicode.Unicode.Unicode.UTF16ToUTF8;
import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCopyNumberArrayValues;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysFillNumberArray;
import static com.martinfjohansen.oneaccounting.math.math.math.IsInteger;
import static com.martinfjohansen.oneaccounting.references.references.references.*;
import static java.lang.Math.min;

public class TestModule {
    public static void main(String[] args) {
        System.out.println("One Accounting Library");

        ProcessingUnitControllerStructure puc = CreateJavaPUC();
        ProcessingUnitServerStructure client = CreateHTTPServer(puc,"127.0.0.1", 8081);
        DiskStructure disk = new DiskStructure();
        CreateFileDisk(disk, "disk.dat", 1024, 1024);
        OneAccountingState state = new OneAccountingState();

        OneAccountingInitialize(puc, client, disk, state);

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
        boolean success, apRequestAvailable, vdRequestAvailable;
        ByteArrayReference adminPortOutputBytes;
        NumberReference entryRef, entriesRef, entrySizeRef;
        char [] adminPortOutputJSON;
        ByteArrayReference adminPortRequestBytes, data;
        Data adminPortOutput;

        entriesRef = new NumberReference();
        entryRef = new NumberReference();
        entrySizeRef = new NumberReference();
        data = new ByteArrayReference();

        WaitInterrupt(puc, 10d);

        apRequestAvailable = ServerCheck(clientPort);

        if(apRequestAvailable){
            adminPortRequestBytes = new ByteArrayReference();
            ServerReceive(clientPort, adminPortRequestBytes);

            adminPortOutput = CreateNewStructData();
            AddNumberToStruct(adminPortOutput.structure, "Entry Size".toCharArray(), state.entrySize);
            AddNumberToStruct(adminPortOutput.structure, "Entries".toCharArray(), state.entries);
            AddNumberToStruct(adminPortOutput.structure, "Idle".toCharArray(), state.idles);

            adminPortOutputJSON = WriteJSON(adminPortOutput);

            FreeData(adminPortOutput);

            adminPortOutputBytes = new ByteArrayReference();

            success = UTF16ToUTF8(adminPortOutputJSON, adminPortOutputBytes);

            ServerSend(clientPort, adminPortOutputBytes.bytes);
        }

        if(!apRequestAvailable){
            state.idles = state.idles + 1d;
        }
    }

    public static void delete(Object entry) {
        // Java has garbage collection.
    }
}
