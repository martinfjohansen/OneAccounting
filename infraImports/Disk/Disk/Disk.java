package Disk.Disk;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;

public class Disk {
    public static boolean CreateFileDisk(DiskStructure disk, String filename, double entries, double entrySize){
        boolean success;
        double fileSize;

        disk.file = new File(filename);
        disk.entries = entries;
        disk.entrySize = entrySize;

        try {
            if (!disk.file.exists()) {
                disk.file.createNewFile();
                disk.rafile = new RandomAccessFile(disk.file, "rw");
                disk.rafile.setLength((long)(entries * entrySize));
            }else{
                disk.rafile = new RandomAccessFile(disk.file, "rw");
            }

            fileSize = disk.rafile.length();

            success = fileSize == entries * entrySize;
        } catch (IOException e) {
            success = false;
        }

        return success;
    }

    public static void Entries(DiskStructure disk, NumberReference entries, NumberReference entrysize){
        entries.numberValue = disk.entries;
        entrysize.numberValue = disk.entrySize;
    }

    public static boolean Write(DiskStructure disk, double entry, ByteArray data){
        byte [] b;
        boolean success;

        b = no.inductive.progsbase.supportlibs.ArrayConversions.DoubleArrayToByteArray(data.bytes);

        try {
            disk.rafile.seek((int)(entry * disk.entrySize));
            disk.rafile.write(b, 0, (int)disk.entrySize);
            success = true;
        } catch (IOException e) {
            success = false;
        }

        return success;
    }

    public static boolean Read(DiskStructure disk, double entry, ByteArrayReference data){
        byte [] b;
        boolean success;

        b = new byte[(int)disk.entrySize];

        try {
            disk.rafile.seek((int)(entry * disk.entrySize));
            disk.rafile.read(b, 0, (int)disk.entrySize);
            data.bytes = new ByteArray();
            data.bytes.bytes = no.inductive.progsbase.supportlibs.ArrayConversions.ByteArrayToDoubleArray(b);
            success = true;
        } catch (IOException e) {
            success = false;
        }

        return success;
    }

    public static void SendEntries(DiskStructure disk){
    }

    public static void SendWrite(DiskStructure disk, double entry, double [] data){
    }

    public static void SendRead(DiskStructure disk, double entry){
    }

    public static void ReceiveEntries(DiskStructure disk, NumberReference entries, NumberReference entrysize){
    }

    public static boolean ReceiveWrite(DiskStructure disk){
        return false;
    }

    public static boolean ReceiveRead(DiskStructure disk, NumberArrayReference data){
        return false;
    }

    public static boolean ClientCheck(DiskStructure disk){
        return false;
    }

    public static void delete(Object object){
        // Java has garbage collection.
    }
}
