package no.inductive.progsbase.supportlibs;

public class ArrayConversions {
    public static byte[] DoubleArrayToByteArray(byte[] data) {
        byte [] bytes = new byte [data.length];
        for(int i = 0; i < data.length; i++){
            bytes[i] = data[i];
        }
        return bytes;
    }

    public static byte[] ByteArrayToDoubleArray(byte[] data) {
        byte [] bytes = new byte [data.length];
        for(int i = 0; i < data.length; i++){
            bytes[i] = data[i];
        }
        return bytes;
    }
}
