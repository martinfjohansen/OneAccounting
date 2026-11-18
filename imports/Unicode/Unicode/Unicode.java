package Unicode.Unicode;

import Bytes.Bytes.ByteArray;
import Bytes.Bytes.ByteArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static Bytes.Bytes.Bytes.*;
import static com.martinfjohansen.oneaccounting.references.references.references.FreeNumberArrayReference;
import static java.lang.Math.*;

public class Unicode {
    public static boolean UnicodeToUTF8(double [] unicode, ByteArrayReference utf8Ref) {
        boolean success;
        ByteArray utf8;
        double length, i, pos, p1, p2, p3, p4, code;

        success = IsValidUnicode(unicode);

        if(success){
            length = 0d;
            for(i = 0; i < unicode.length; i = i + 1d){
                code = unicode[(int)i];

                length = length + 1d;
                if(code >= 128d){
                    length = length + 1d;
                }
                if(code >= 2048d){
                    length = length + 1d;
                }
                if(code >= 65536d){
                    length = length + 1d;
                }
            }

            utf8 = CreateByteArray(length);

            pos = 0d;
            for(i = 0; i < unicode.length; i = i + 1d){
                code = unicode[(int)i];

                if(code < 128d){
                    SetByte(utf8, pos, code);
                    pos = pos + 1d;
                }else if(code < 2048d){
                    p1 = code % 64d;
                    p2 = floor(code / 64d) % 64d;

                    SetByte(utf8, pos, 128d + 64d + p2);
                    pos = pos + 1d;
                    SetByte(utf8, pos, 128d + p1);
                    pos = pos + 1d;
                }else if(code < 65536d){
                    p1 = code % 64d;
                    p2 = floor(code / 64d) % 64d;
                    p3 = floor(code / 4096d);

                    SetByte(utf8, pos, 128d + 64d + 32d + p3);
                    pos = pos + 1d;
                    SetByte(utf8, pos, 128d + p2);
                    pos = pos + 1d;
                    SetByte(utf8, pos, 128d + p1);
                    pos = pos + 1d;
                }else{
                    p1 = code % 64d;
                    p2 = floor(code / 64d) % 64d;
                    p3 = floor(code / 4096d) % 64d;
                    p4 = floor(code / 262144d);

                    SetByte(utf8, pos, 128d + 64d + 32d + 16d + p4);
                    pos = pos + 1d;
                    SetByte(utf8, pos, 128d + p3);
                    pos = pos + 1d;
                    SetByte(utf8, pos, 128d + p2);
                    pos = pos + 1d;
                    SetByte(utf8, pos, 128d + p1);
                    pos = pos + 1d;
                }
            }

            utf8Ref.bytes = utf8;
        }

        return success;
    }

    public static boolean UTF8ToUnicode(ByteArray utf8, NumberArrayReference unicodeRef) {
        double [] unicode;
        double length, i, pos, p1, p2, p3, p4, code, b;
        boolean success;

        length = 0d;
        success = IsValidUtf8(utf8);
        if(success) {
            for (i = 0; i < ByteArrayLength(utf8) && success; ) {
                b = GetByte(utf8, i);

                // 0xxxxxxx
                code = b;
                if (code < 128d) {
                    length = length + 1d;
                    i = i + 1d;
                } else {
                    // 110xxxxx
                    code = floor(b / 32d) * 32d;

                    if (code < 128d + 64d) {
                        success = false;
                    } else if (code == 128d + 64d) {
                        length = length + 1d;
                        i = i + 2d;
                    } else {
                        // 1110xxxx
                        code = floor(b / 16d) * 16d;

                        if (code == 128d + 64d + 32d) {
                            length = length + 1d;
                            i = i + 3d;
                        } else {
                            // 11110xxx
                            code = floor(b / 8d) * 8d;

                            if (code == 128d + 64d + 32d + 16d) {
                                length = length + 1d;
                                i = i + 4d;
                            } else {
                                success = false;
                            }
                        }
                    }
                }
            }

            if (success) {
                unicode = new double[(int) length];

                pos = 0d;
                for (i = 0; i < ByteArrayLength(utf8) && success; ) {
                    b = GetByte(utf8, i);

                    // 0xxxxxxx
                    code = b;
                    if (code < 128d) {
                        unicode[(int) pos] = GetByte(utf8, i);
                        i = i + 1d;
                        pos = pos + 1d;
                    } else {
                        // 110xxxxx
                        code = floor(b / 32d) * 32d;
                        if (code < 128d + 64d) {
                            success = false;
                        } else if (code == 128d + 64d) {
                            p1 = GetByte(utf8, i + 1d) - 128d;
                            p2 = GetByte(utf8, i) - 128d - 64d;

                            unicode[(int) pos] = p2 * 64d + p1;

                            i = i + 2d;
                            pos = pos + 1d;
                        } else {
                            // 1110xxxx
                            code = floor(b / 16d) * 16d;
                            if (code == 128d + 64d + 32d) {
                                p1 = GetByte(utf8, i + 2d) - 128d;
                                p2 = GetByte(utf8, i + 1d) - 128d;
                                p3 = GetByte(utf8, i) - 128d - 64d - 32d;

                                unicode[(int) pos] = p3 * 4096d + p2 * 64d + p1;

                                i = i + 3d;
                                pos = pos + 1d;
                            } else {
                                // 11110xxx
                                code = floor(b / 8d) * 8d;
                                if (code == 128d + 64d + 32d + 16d) {
                                    p1 = GetByte(utf8, i + 3d) - 128d;
                                    p2 = GetByte(utf8, i + 2d) - 128d;
                                    p3 = GetByte(utf8, i + 1d) - 128d;
                                    p4 = GetByte(utf8, i) - 128d - 64d - 32d - 16d;

                                    unicode[(int) pos] = p4 * 262144d + p3 * 4096d + p2 * 64d + p1;

                                    i = i + 4d;
                                    pos = pos + 1d;
                                } else {
                                    success = false;
                                }
                            }
                        }
                    }
                }

                if (success) {
                    unicodeRef.numberArray = unicode;
                } else {
                    delete(unicode);
                }
            }
        }

        return success;
    }

    public static boolean UTF16ToUnicode(char [] utf16, NumberArrayReference unicodeRef) {
        boolean success;
        double [] unicode;
        double length, i, pos, hs, ls, code;
        double surrogateLowerBound, surrogateUpperBound, highSurrogateBase, lowSurrogateBase, highMultiplier, surrogateBase;

        success = IsValidUtf16(utf16);

        if(success) {
            surrogateLowerBound = 55296;
            surrogateUpperBound = 57344;
            highSurrogateBase = 55296;
            lowSurrogateBase = 56320;
            highMultiplier = 1024;
            surrogateBase = 65536;

            length = 0d;
            for (i = 0; i < utf16.length; ) {
                code = utf16[(int) i];

                if (code < surrogateLowerBound || code >= surrogateUpperBound) {
                    length = length + 1d;
                    i = i + 1d;
                } else {
                    length = length + 1d;
                    i = i + 2d;
                }
            }

            unicode = new double[(int) length];

            pos = 0d;
            for (i = 0; i < utf16.length; ) {
                code = utf16[(int) i];

                if (code < surrogateLowerBound || code >= surrogateUpperBound) {
                    unicode[(int) pos] = utf16[(int) i];
                    i = i + 1d;
                    pos = pos + 1d;
                } else {
                    hs = utf16[(int) i];
                    ls = utf16[(int) (i + 1d)];

                    unicode[(int) pos] = (hs - highSurrogateBase) * highMultiplier + (ls - lowSurrogateBase) + surrogateBase;

                    i = i + 2d;
                    pos = pos + 1d;
                }
            }

            unicodeRef.numberArray = unicode;
        }

        return success;
    }

    public static boolean UnicodeToUTF16(double [] unicode, StringReference utf16ref) {
        boolean success;
        char [] utf16;
        double length, code, i, pos, hs, ls;
        double highSurrogateBase, lowSurrogateBase, highMultiplier, surrogateBase;

        success = IsValidUnicode(unicode);

        if(success) {
            highSurrogateBase = 55296d;
            lowSurrogateBase = 56320d;
            highMultiplier = 1024d;
            surrogateBase = 65536d;

            length = 0d;
            for (i = 0; i < unicode.length; i = i + 1d) {
                if (unicode[(int) i] < surrogateBase) {
                    length = length + 1d;
                } else {
                    length = length + 2d;
                }
            }

            utf16 = new char[(int) length];

            pos = 0d;
            for (i = 0; i < unicode.length; i = i + 1d) {
                if (unicode[(int) i] < surrogateBase) {
                    utf16[(int) pos] = (char) unicode[(int) i];
                    pos = pos + 1d;
                } else {
                    code = unicode[(int) i] - surrogateBase;
                    hs = floor(code / highMultiplier) + highSurrogateBase;
                    ls = code % highMultiplier + lowSurrogateBase;

                    utf16[(int) pos] = (char) hs;
                    pos = pos + 1d;
                    utf16[(int) pos] = (char) ls;
                    pos = pos + 1d;
                }
            }

            utf16ref.string = utf16;
        }

        return success;
    }

    public static boolean UTF8ToUTF16(ByteArray utf8, StringReference utf16) {
        boolean success;
        NumberArrayReference unicodeRef;

        unicodeRef = new NumberArrayReference();

        success = UTF8ToUnicode(utf8, unicodeRef);
        if(success) {
            success = UnicodeToUTF16(unicodeRef.numberArray, utf16);
            FreeNumberArrayReference(unicodeRef);
        }

        return success;
    }

    public static void delete(Object o) {
        // Java har garbage collection.
    }

    public static boolean UTF16ToUTF8(char [] utf16, ByteArrayReference utf8Ref) {
        NumberArrayReference unicodeRef;
        ByteArray utf8;
        boolean success;

        unicodeRef = new NumberArrayReference();
        success = UTF16ToUnicode(utf16, unicodeRef);
        if(success) {
            success = UnicodeToUTF8(unicodeRef.numberArray, utf8Ref);
            FreeNumberArrayReference(unicodeRef);
        }

        return success;
    }

    public static boolean IsValidUnicode(double [] unicode) {
        double lower, upper, i, code;
        boolean valid;

        lower = 0d;
        upper = 1114112d;

        valid = true;
        for(i = 0; i < unicode.length && valid; i = i + 1d){
            code = unicode[(int)i];

            if(code == floor(code)) {
                if (code >= lower && code < upper) {
                }else{
                    valid = false;
                }
            }else{
                valid = false;
            }
        }

        return valid;
    }

    public static boolean IsValidUtf16(char [] utf16) {
        double i, code;
        boolean valid;
        double surrogateLowerBound, surrogateUpperBound;

        surrogateLowerBound = 55296;
        surrogateUpperBound = 57344;

        valid = true;
        for(i = 0; i < utf16.length && valid; i = i + 1d){
            code = utf16[(int)i];

            if(code == floor(code)) {
                if(code < surrogateLowerBound || code >= surrogateUpperBound){
                }else{
                    if(i + 1d < utf16.length){
                        i = i + 1d;
                        code = utf16[(int)i];

                        if(code < surrogateLowerBound || code >= surrogateUpperBound){
                            valid = false; // Unpaired surrogate;
                        }
                    }else{
                        valid = false; // Unpaired surrogate.
                    }
                }
            }else{
                valid = false;
            }
        }

        return valid;
    }

    public static boolean IsValidUtf8(ByteArray utf8) {
        double i, code1, code2, code3, code4;
        boolean valid;

        valid = true;
        for(i = 0; i < ByteArrayLength(utf8) && valid; i = i + 1d){
            code1 = GetByte(utf8, i);

            if(code1 == floor(code1)) {
                if(code1 < 128d) {
                }else if(code1 < 128d + 64d){
                    valid = false;
                }else if(code1 < 128d + 64d + 32d){
                    if(i + 1d < ByteArrayLength(utf8)){
                        i = i + 1d;
                        code2 = GetByte(utf8, i);

                        if(code2 >= 128d && code2 < 128d + 64d){
                        }else{
                            valid = false;
                        }
                    }else{
                        valid = false;
                    }
                }else if(code1 < 128d + 64d + 32d + 16d){
                    if(i + 2d < ByteArrayLength(utf8)){
                        i = i + 1d;
                        code2 = GetByte(utf8, i);
                        i = i + 1d;
                        code3 = GetByte(utf8, i);

                        if(code2 >= 128d && code2 < 128d + 64d && code3 >= 128d && code3 < 128d + 64d){
                        }else{
                            valid = false;
                        }
                    }else{
                        valid = false;
                    }
                }else{
                    if(i + 3d < ByteArrayLength(utf8)){
                        i = i + 1d;
                        code2 = GetByte(utf8, i);
                        i = i + 1d;
                        code3 = GetByte(utf8, i);
                        i = i + 1d;
                        code4 = GetByte(utf8, i);

                        if(code2 >= 128d && code2 < 128d + 64d && code3 >= 128d && code3 < 128d + 64d && code4 >= 128d && code4 < 128d + 64d){
                        }else{
                            valid = false;
                        }
                    }else{
                        valid = false;
                    }
                }
            }else{
                valid = false;
            }
        }

        return valid;
    }
}