package Disk.DiskServer;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static Bytes.Bytes.Bytes.CopyByteArray;

public class DiskServer {
    public static boolean DiskServerCheck(DiskServerStructure disk){
        boolean available;

        if(disk.currentEvent < disk.eventlist.length) {
            available = true;
        }else{
            available = false;
        }

        return available;
    }

    // ****

    public static boolean ServerReceiveEntries(DiskServerStructure disk){
        boolean available;

        available = false;

        if(disk.currentEvent < disk.eventlist.length){
            if(disk.eventlist[(int)disk.currentEvent] == 1d){
                available = true;
                disk.currentEvent = disk.currentEvent + 1d;
                disk.pendingRequest = true;
                disk.pendingRequestCommand = 1d;
            }
        }

        return available;
    }

    public static boolean ServerReceiveWrite(DiskServerStructure disk, NumberReference entry, ByteArrayReference data){
        boolean available;

        available = false;

        if(disk.currentEvent < disk.eventlist.length){
            if(disk.eventlist[(int)disk.currentEvent] == 2d){
                available = true;
                disk.currentEvent = disk.currentEvent + 1d;
                disk.pendingRequest = true;
                disk.pendingRequestCommand = 2d;
                entry.numberValue = disk.entryRequests[(int)disk.requests];
                data.bytes = CopyByteArray(disk.dataRequests[(int)disk.requests]);
                disk.requests = disk.requests + 1d;
            }
        }

        return available;
    }

    public static boolean ServerReceiveRead(DiskServerStructure disk, NumberReference entry){
        boolean available;

        available = false;

        if(disk.currentEvent < disk.eventlist.length){
            if(disk.eventlist[(int)disk.currentEvent] == 3d){
                available = true;
                disk.currentEvent = disk.currentEvent + 1d;
                disk.pendingRequest = true;
                disk.pendingRequestCommand = 3d;
                entry.numberValue = disk.entryRequests[(int)disk.requests];
            }
        }

        return available;
    }

    public static void ServerSendEntries(DiskServerStructure disk, double entries, double entrysize){
        if(disk.pendingRequest && disk.pendingRequestCommand == 1d) {
            disk.entriesResponses[(int) disk.responses] = entries;
            disk.entrySizeResponses[(int) disk.responses] = entrysize;
            disk.responses = disk.responses + 1d;
            disk.pendingRequest = false;
        }
    }

    public static void ServerSendWrite(DiskServerStructure disk, boolean success){
        if(disk.pendingRequest && disk.pendingRequestCommand == 2d) {
            disk.successResponses[(int) disk.responses] = success;
            disk.responses = disk.responses + 1d;
            disk.pendingRequest = false;
        }
    }

    public static void ServerSendRead(DiskServerStructure disk, ByteArray data, boolean success){
        if(disk.pendingRequest && disk.pendingRequestCommand == 3d) {
            disk.successResponses[(int) disk.responses] = success;
            disk.dataResponses[(int)disk.responses] = CopyByteArray(data);
            disk.responses = disk.responses + 1d;
            disk.pendingRequest = false;
        }
    }
}