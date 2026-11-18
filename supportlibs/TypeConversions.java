package no.inductive.progsbase.supportlibs;

public class TypeConversions {
    public static byte DoubleToByte(double d) {
        return (byte)d; // This will convert 0 – 127 to 0 – 127 and 128 – 255 -> -128 – -1
    }

    public static int ByteToUnsignedInt(byte b) {
        if(b >= 0){
            return (int)b;
        }else{
            int val = (int)b;

            val = 256 + val;

            return val;
        }
    }

    public static double ByteToDouble(byte b) {
        return (double) ByteToUnsignedInt(b);
    }
}
