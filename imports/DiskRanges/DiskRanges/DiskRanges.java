package DiskRanges.DiskRanges;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import Disk.Disk.DiskStructure;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;

import static Bytes.Bytes.Bytes.*;
import static Disk.Disk.Disk.Entries;
import static Disk.Disk.Disk.Read;
import static Disk.Disk.Disk.Write;
import static java.lang.Math.*;

public class DiskRanges {
    public static boolean ReadRange(DiskStructure disk, double from, double length, ByteArrayReference data){
        boolean success;
        double firstBlock, firstPos, lastBlock, lastPos, to;
        double es, e, i, pos, b;
        ByteArrayReference block;
        NumberReference entries, entrySize;

        entries = new NumberReference();
        entrySize = new NumberReference();
        Entries(disk, entries, entrySize);
        e = entrySize.numberValue;
        es = entries.numberValue;
        block = new ByteArrayReference();
        block.bytes = CreateAndFillByteArray(e, 0d);
        data.bytes = CreateByteArray(length);

        firstBlock = floor(from / e);
        firstPos = from - firstBlock * e;

        to = from + length;

        lastBlock = floor(to / e);
        lastPos = to - lastBlock * e;

        if(firstBlock <= lastBlock){
            if(firstBlock < es && lastBlock < es){
                success = true;
            }else{
                success = false;
            }
        }else{
            success = false;
        }

        if(success){
            if(firstBlock == lastBlock){
                Read(disk, firstBlock, block);
                for(i = 0; i < length; i = i + 1d){
                    SetByte(data.bytes, i, GetByte(block.bytes, firstPos + i));
                }
            }else{
                pos = 0d;

                // First block
                Read(disk, firstBlock, block);
                for(i = 0; i < e - firstPos; i = i + 1d){
                    SetByte(data.bytes, pos, GetByte(block.bytes, firstPos + i));
                    pos = pos + 1d;
                }

                // Middle blocks
                for(b = 0d; b < lastBlock - firstBlock - 1d; b = b + 1d){
                    Read(disk, firstBlock +1d + b, block);
                    for(i = 0; i < e; i = i + 1d){
                        SetByte(data.bytes, pos, GetByte(block.bytes, i));
                        pos = pos + 1d;
                    }
                }

                // Last block
                Read(disk, lastBlock, block);
                for(i = 0; i < lastPos; i = i + 1d){
                    SetByte(data.bytes, pos, GetByte(block.bytes, i));
                    pos = pos + 1d;
                }
            }
        }

        return success;
    }

    public static boolean WriteRange(DiskStructure disk, double from, double length, ByteArray data){
        boolean success;
        double firstBlock, firstPos, lastBlock, lastPos, to;
        double es, e, i, pos, b;
        ByteArrayReference block;
        NumberReference entries, entrySize;

        entries = new NumberReference();
        entrySize = new NumberReference();
        Entries(disk, entries, entrySize);
        e = entrySize.numberValue;
        es = entries.numberValue;
        block = new ByteArrayReference();
        block.bytes = CreateAndFillByteArray(e, 0d);

        firstBlock = floor(from / e);
        firstPos = from - firstBlock * e;

        to = from + length;

        lastBlock = floor(to / e);
        lastPos = to - lastBlock * e;

        if(firstBlock <= lastBlock){
            if(firstBlock < es && lastBlock < es){
                success = true;
            }else{
                success = false;
            }
        }else{
            success = false;
        }

        if(success){
            if(firstBlock == lastBlock){
                Read(disk, firstBlock, block);
                for(i = 0; i < length; i = i + 1d){
                    SetByte(block.bytes, firstPos + i, GetByte(data, i));
                }
                Write(disk, firstBlock, block.bytes);
            }else{
                pos = 0d;

                // First block
                Read(disk, firstBlock, block);
                for(i = 0; i < e - firstPos; i = i + 1d){
                    SetByte(block.bytes, firstPos + i, GetByte(data, pos));
                    pos = pos + 1d;
                }
                Write(disk, firstBlock, block.bytes);

                // Middle blocks
                for(b = 0d; b < lastBlock - firstBlock - 1d; b = b + 1d){
                    for(i = 0; i < e; i = i + 1d){
                        SetByte(block.bytes, i, GetByte(data, pos));
                        pos = pos + 1d;
                    }
                    Write(disk, firstBlock + 1d + b, block.bytes);
                }

                // Last block
                Read(disk, lastBlock, block);
                for(i = 0; i < lastPos; i = i + 1d){
                    SetByte(block.bytes, i, GetByte(data, pos));
                    pos = pos + 1d;
                }
                Write(disk, lastBlock, block.bytes);
            }
        }

        return success;
    }
}
