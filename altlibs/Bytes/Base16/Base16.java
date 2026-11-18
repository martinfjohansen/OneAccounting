package Bytes.Base16;

import Bytes.Bytes.ByteArray;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static Bytes.Bytes.Bytes.*;
import static com.martinfjohansen.oneaccounting.references.references.references.FreeStringReference;

public class Base16 {
    public static char [] BytesToTextBase16(ByteArray bytes) {
        StringReference[] comb;
        double i, v;
        char [] r;

        r = new char[(int)(bytes.bytes.length * 2d)];
        comb = GenerateBase16ByteCombinations();

        for(i = 0d; i < bytes.bytes.length; i = i + 1d){
            v = ByteToUnsignedInt(bytes.bytes[(int) i]);
            r[(int)(2d*i + 0d)] = comb[(int)v].string[0];
            r[(int)(2d*i + 1d)] = comb[(int)v].string[1];
        }

        FreeBase64ByteCombinations(comb);

        return r;
    }

    public static ByteArray TextToBytesBase16(char [] string) {
        StringReference[] comb;
        double i, n, c, d;
        ByteArray r;
        double [] reverseBase16;
        char[] codes;
        char ch;

        codes = "0123456789ABCDEF".toCharArray();

        reverseBase16 = new double [128];
        for(i = 0; i < codes.length; i = i + 1d) {
            n = codes[(int) i];
            reverseBase16[(int)n] = i;
        }

        if(string.length % 2d == 0d) {
            r = CreateByteArray(string.length / 2d);
            comb = GenerateBase16ByteCombinations();

            for (i = 0d; i < string.length / 2d; i = i + 1d) {
                c = string[(int)(2d * i + 0d)];
                d = string[(int)(2d * i + 1d)];

                n = reverseBase16[(int)c] * 16d + reverseBase16[(int)d];

                SetByte(r, i, n);
            }

            FreeBase64ByteCombinations(comb);
        }else{
            r = CreateByteArray(0d);
        }

        delete(reverseBase16);

        return r;
    }

    public static void FreeBase64ByteCombinations(StringReference[] comb) {
        double i;
        for (i = 0d; i < 256d; i = i + 1d) {
            FreeStringReference(comb[(int)i]);
        }
        delete(comb);
    }

    public static void delete(Object o) {
        // Java has garbage collection.
    }

    public static StringReference[] GenerateBase16ByteCombinations() {
        StringReference[] comb;
        char[] codes;
        double i, j;
        comb = new StringReference[256];

        codes = "0123456789ABCDEF".toCharArray();

        for (i = 0d; i < 256d; i = i + 1d) {
            comb[(int)i] = new StringReference();
            comb[(int)i].string = new char[2];
        }

        for (j = 0d; j < 16d; j = j + 1d) {
            for (i = 0d; i < 16d; i = i + 1d) {
                comb[(int)(j*16d + i)].string[1] = codes[(int)i];
                comb[(int)(j*16d + i)].string[0] = codes[(int)j];
            }
        }

        return comb;
    }
}
