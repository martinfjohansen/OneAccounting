package Bytes.Bytes;

public class Bytes {
    public static ByteArray CreateByteArray(double len){
        ByteArray bytes = new ByteArray();

        bytes.bytes = new byte[(int)len];

        return bytes;
    }

    public static ByteArray CreateAndFillByteArray(double len, double value) {
        int i;
        ByteArray bytes = new ByteArray();

        bytes.bytes = new byte[(int)len];
        for(i = 0; i < len; i++){
            bytes.bytes[i] = (byte)value;
        }

        return bytes;
    }

    public static double GetByte(ByteArray bytes, double index) {
        return ByteToDouble(bytes.bytes[(int)index]);
    }

    public static void SetByte(ByteArray bytes, double i, double b) {
        bytes.bytes[(int)i] = (byte)b;
    }

    public static double [] ByteArrayToNumberArray(ByteArray src){
        double [] dst;
        double i, len;

        len = src.bytes.length;
        dst = new double[(int)len];
        for(i = 0d; i < len; i = i + 1d){
            dst[(int)i] = ByteToDouble(src.bytes[(int)i]);
        }

        return dst;
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

    public static ByteArray NumberArrayToByteArray(double [] src){
        ByteArray dst;
        double i, len;

        len = src.length;
        dst = new ByteArray();
        dst.bytes = new byte[(int)len];
        for(i = 0d; i < len; i = i + 1d){
            // This will convert 0 – 127 to 0 – 127 and 128 – 255 -> -128 – -1
            dst.bytes[(int)i] = (byte)src[(int)i];
        }

        return dst;
    }

    public static void FreeByteArray(ByteArray decoded) {
        delete(decoded.bytes);
        delete(decoded);
    }

    public static void delete(Object object){
        // Java has garbage collection.
    }

    public static double ByteArrayLength(ByteArray data) {
        return data.bytes.length;
    }

    public static boolean ByteArraysEqual(ByteArray a, ByteArray b) {
        boolean equal;
        double i;

        equal = true;
        if(a.bytes.length == b.bytes.length){
            for(i = 0d; i < a.bytes.length && equal; i = i + 1d){
                if(a.bytes[(int)(i)] != b.bytes[(int)(i)]){
                    equal = false;
                }
            }
        }else{
            equal = false;
        }

        return equal;
    }

    public static ByteArray CopyByteArray(ByteArray a) {
        double i;
        ByteArray n;

        n = CreateByteArray(a.bytes.length);

        for(i = 0d; i < a.bytes.length; i = i + 1d){
            n.bytes[(int)(i)] = a.bytes[(int)(i)];
        }

        return n;
    }

    public static boolean CopyByteArrayRange(ByteArray a, double from, double to, ByteArray b){
        double i, length;
        byte [] n;
        boolean success;

        if(from >= 0d && from <= a.bytes.length && to >= 0d && to <= a.bytes.length && from <= to){
            length = to - from;
            n = new byte [(int)(length)];

            for(i = 0d; i < length; i = i + 1d){
                n[(int)(i)] = a.bytes[(int)(from + i)];
            }

            b.bytes = n;
            success = true;
        }else{
            success = false;
        }

        return success;
    }
}
