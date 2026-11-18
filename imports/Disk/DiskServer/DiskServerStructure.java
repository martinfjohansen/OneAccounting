package Disk.DiskServer;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;

public class DiskServerStructure {
    // Disk contents
    public double entries;
    public double entrysize;
    public double[] data;

    // Server, Async
    public double [] eventlist;
    public double currentEvent;

    public boolean pendingRequest;
    public double pendingRequestCommand;

    public double [] entryRequests;
    public ByteArray [] dataRequests;
    double requests;

    public double [] entriesResponses;
    public double [] entrySizeResponses;
    public boolean [] successResponses;
    public ByteArray [] dataResponses;
    double responses;
}
