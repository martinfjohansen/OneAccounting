package com.martinfjohansen.oneaccounting;

import Disk.Disk.DiskStructure;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.DataReference;
import com.martinfjohansen.oneaccounting.accountingops.LedgerOperations;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static com.martinfjohansen.oneaccounting.accountingops.LedgerOperations.*;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.accountingops.DiskOperations.*;

public class CommandHandler {
    public static boolean HandleCommand(DiskStructure disk, Data input, OneAccountingState state, DataReference outputDataRef, StringReference message) {
        boolean success;
        char [] command;
        Data commandData;

        outputDataRef.data = CreateNewStructData();

        success = IsStructure(input);
        if(success){
            success = StructHasKey(input.structure, "command".toCharArray());
            if(success){
                commandData = GetDataFromStruct(input.structure, "command".toCharArray());
                success = IsString(commandData);
                if(success){
                    command = GetStringFromStruct(input.structure, "command".toCharArray());

                    if(arraysStringsEqual(command, "Ping".toCharArray())){
                        outputDataRef.data = CreateStringData("Pong".toCharArray());
                    }else if(arraysStringsEqual(command, "FormatDisk".toCharArray())){
                        success = FormatDisk(disk, state, message);
                    }else if(arraysStringsEqual(command, "LoadFromDisk".toCharArray())){
                        success = LoadFromDisk(disk, state, message);
                    }else if(arraysStringsEqual(command, "SaveToDisk".toCharArray())){
                        success = SaveToDisk(disk, state, message);
                    }else if(arraysStringsEqual(command, "IsValidDiskFormat".toCharArray())){
                        success = IsValidDiskFormat(disk, message);
                    }else if(arraysStringsEqual(command, "AddTransactionToLedger".toCharArray())){
                        success = AddTransactionToLedger(input.structure, state, message);
                    }else if(arraysStringsEqual(command, "ComputeAccountBalance".toCharArray())){
                        success = ComputeAccountBalance(input.structure, outputDataRef, state, message);
                    }else if(arraysStringsEqual(command, "ComputeAccountBalancePrefixAccount".toCharArray())){
                        success = ComputeAccountBalancePrefixAccount(input.structure, outputDataRef, state, message);
                    }else if(arraysStringsEqual(command, "AddMonthlyAccruals".toCharArray())){
                        success = AddMonthlyAccruals(input.structure, outputDataRef, state, message);
                    }else if(arraysStringsEqual(command, "ComputeAccountBalances".toCharArray())){
                        success = ComputeAccountBalances(input.structure, outputDataRef, state, message);
                    }else{
                        success = false;
                        message.string = "Unknown command.".toCharArray();
                    }
                }else{
                    message.string = "Command must be string.".toCharArray();
                }
            }else{
                message.string = "Request must have key command.".toCharArray();
            }
        }else{
            message.string = "Request data must be structure.".toCharArray();
        }


        return success;
    }


}
