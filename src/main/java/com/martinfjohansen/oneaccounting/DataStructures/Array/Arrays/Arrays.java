package com.martinfjohansen.oneaccounting.DataStructures.Array.Arrays;

import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Array;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structures.*;
import static java.lang.Math.*;

public class Arrays{
	public static Array CreateArray(){
		Array array;

		array = new Array();
		array.array = new Data[10];
		array.length = 0d;

		return array;
	}

	public static Array CreateArrayWithInitialCapacity(double capacity){
		Array array;

		array = new Array();
		array.array = new Data [(int)(capacity)];
		array.length = 0d;

		return array;
	}

	public static void ArrayAdd(Array array, Data value){
		if(array.length == array.array.length){
			ArrayIncreaseSize(array);
		}

		array.array[(int)(array.length)] = value;
		array.length = array.length + 1d;
	}

	public static void ArrayAddString(Array array, char [] value){
		Data data;

		data = CreateStringData(value);

		ArrayAdd(array, data);
	}

	public static void ArrayAddBoolean(Array array, boolean value){
		Data data;

		data = CreateBooleanData(value);

		ArrayAdd(array, data);
	}

	public static void ArrayAddNumber(Array array, double value){
		Data data;

		data = CreateNumberData(value);

		ArrayAdd(array, data);
	}

	public static void ArrayAddStruct(Array array, Structure value){
		Data data;

		data = CreateStructData(value);

		ArrayAdd(array, data);
	}

	public static void ArrayAddArray(Array array, Array value){
		Data data;

		data = CreateArrayData(value);

		ArrayAdd(array, data);
	}

	public static void ArrayIncreaseSize(Array array){
		double newLength, i;
		Data [] newArray;

		newLength = (double)round(array.array.length*3d/2d);
		newArray = new Data [(int)(newLength)];

		for(i = 0d; i < array.array.length; i = i + 1d){
			newArray[(int)(i)] = array.array[(int)(i)];
		}

		delete(array.array);

		array.array = newArray;
	}

	public static boolean ArrayDecreaseSizeNecessary(Array array){
		boolean needsDecrease;

		needsDecrease = false;

		if(array.length > 10d){
			needsDecrease = array.length <= (double)round(array.array.length*2d/3d);
		}

		return needsDecrease;
	}

	public static void ArrayDecreaseSize(Array array){
		double newLength, i;
		Data [] newArray;

		newLength = (double)round(array.array.length*2d/3d);
		newArray = new Data [(int)(newLength)];

		for(i = 0d; i < newLength; i = i + 1d){
			newArray[(int)(i)] = array.array[(int)(i)];
		}

		delete(array.array);

		array.array = newArray;
	}

	public static Data ArrayIndex(Array array, double index){
		return array.array[(int)(index)];
	}

	public static Array ArrayIndexArray(Array array, double index){
		return array.array[(int)(index)].array;
	}

	public static Structure ArrayIndexStruct(Array array, double index){
		return array.array[(int)(index)].structure;
	}

	public static boolean ArrayIndexBoolean(Array array, double index){
		return array.array[(int)(index)].booleanx;
	}

	public static char [] ArrayIndexString(Array array, double index){
		return array.array[(int)(index)].string;
	}

	public static double ArrayIndexNumber(Array array, double index){
		return array.array[(int)(index)].number;
	}

	public static double ArrayLength(Array array){
		return array.length;
	}

	public static void ArrayInsert(Array array, double index, Data value){
		double i;

		if(array.length == array.array.length){
			ArrayIncreaseSize(array);
		}

		for(i = array.length; i > index; i = i - 1d){
			array.array[(int)(i)] = array.array[(int)(i - 1d)];
		}

		array.array[(int)(index)] = value;

		array.length = array.length + 1d;
	}

	public static void ArrayInsertString(Array array, double index, char [] value){
		Data data;

		data = CreateStringData(value);

		ArrayInsert(array, index, data);
	}

	public static void ArrayInsertBoolean(Array array, double index, boolean value){
		Data data;

		data = CreateBooleanData(value);

		ArrayInsert(array, index, data);
	}

	public static void ArrayInsertNumber(Array array, double index, double value){
		Data data;

		data = CreateNumberData(value);

		ArrayInsert(array, index, data);
	}

	public static void ArrayInsertStruct(Array array, double index, Structure value){
		Data data;

		data = CreateStructData(value);

		ArrayInsert(array, index, data);
	}

	public static void ArrayInsertArray(Array array, double index, Array value){
		Data data;

		data = CreateArrayData(value);

		ArrayInsert(array, index, data);
	}

	public static boolean ArraySet(Array array, double index, Data value){
		boolean success;

		if(index < array.length){
			array.array[(int)(index)] = value;
			success = true;
		}else{
			success = false;
		}

		return success;
	}

	public static void ArraySetString(Array array, double index, char [] value){
		Data data;

		data = CreateStringData(value);

		ArraySet(array, index, data);
	}

	public static void ArraySetBoolean(Array array, double index, boolean value){
		Data data;

		data = CreateBooleanData(value);

		ArraySet(array, index, data);
	}

	public static void ArraySetNumber(Array array, double index, double value){
		Data data;

		data = CreateNumberData(value);

		ArraySet(array, index, data);
	}

	public static void ArraySetStruct(Array array, double index, Structure value){
		Data data;

		data = CreateStructData(value);

		ArraySet(array, index, data);
	}

	public static void ArraySetArray(Array array, double index, Array value){
		Data data;

		data = CreateArrayData(value);

		ArraySet(array, index, data);
	}

	public static void ArrayRemove(Array array, double index){
		double i;

		for(i = index; i < array.length - 1d; i = i + 1d){
			array.array[(int)(i)] = array.array[(int)(i + 1d)];
		}

		array.length = array.length - 1d;

		if(ArrayDecreaseSizeNecessary(array)){
			ArrayDecreaseSize(array);
		}
	}

	public static Data [] ToStaticArray(Array arc){
		Data [] array;
		double i;

		array = new Data [(int)(arc.length)];

		for(i = 0d; i < arc.length; i = i + 1d){
			array[(int)(i)] = arc.array[(int)(i)];
		}

		return array;
	}

	public static double [] ToStaticNumberArray(Array array){
		double [] result;
		double i, n;

		n = ArrayLength(array);

		result = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).number;
		}

		return result;
	}

	public static boolean [] ToStaticBooleanArray(Array array){
		boolean [] result;
		double i, n;

		n = ArrayLength(array);

		result = new boolean [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).booleanx;
		}

		return result;
	}

	public static StringReference[] ToStaticStringArray(Array array){
		StringReference [] result;
		double i, n;

		n = ArrayLength(array);

		result = new StringReference [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = new StringReference();
			result[(int)(i)].string = ArrayIndex(array, i).string;
		}

		return result;
	}

	public static Array [] ToStaticArrayArray(Array array){
		Array [] result;
		double i, n;

		n = ArrayLength(array);

		result = new Array [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).array;
		}

		return result;
	}

	public static Structure [] ToStaticStructArray(Array array){
		Structure [] result;
		double i, n;

		n = ArrayLength(array);

		result = new Structure [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			result[(int)(i)] = ArrayIndex(array, i).structure;
		}

		return result;
	}

	public static Array StaticArrayToArrayWithOptimalSize(Data [] src){
		Array dst;
		double i;
		double c, n, newCapacity;

		/*
         c = 10*(3/2)^n
         log(c) = log(10*(3/2)^n)
         log(c) = log(10) + log((3/2)^n)
         log(c) = 1 + log((3/2)^n)
         log(c) - 1 = log((3/2)^n)
         log(c) - 1 = n*log(3/2)
         n = (log(c) - 1)/log(3/2)
        */

		c = src.length;
		n = (log(c) - 1d)/log(3d/2d);

		newCapacity = ceil(10d*pow(3d/2d, ceil(n)));

		dst = CreateArrayWithInitialCapacity(newCapacity);

		for(i = 0d; i < src.length; i = i + 1d){
			dst.array[(int)(i)] = src[(int)(i)];
		}

		return dst;
	}

	public static Array StaticArrayToArray(Data [] src){
		double i;
		Array dst;

		dst = CreateArrayWithInitialCapacity(src.length);
		for(i = 0d; i < src.length; i = i + 1d){
			dst.array[(int)(i)] = src[(int)(i)];
		}
		dst.length = src.length;

		return dst;
	}

	public static void ArrayAddAll(Array backups, Array from){
		double i;
		Data data;

		for(i = 0d; i < ArrayLength(from); i = i + 1d){
			data = ArrayIndex(from, i);
			AddDataToArray(backups, data);
		}
	}

	public static boolean SortStringArray(Array a){
		return SortStringArrayWithOptions(a, true);
	}

	public static boolean SortStringArrayDescending(Array a){
		return SortStringArrayWithOptions(a, false);
	}

	public static boolean SortStringArrayWithOptions(Array a, boolean asc){
		boolean success;
		double i, j, len, cmp;
		boolean swapped, swap;
		char [] tmp;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			if(IsString(ArrayIndex(a, i))){
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = a.array[(int)(j)];
					db = a.array[(int)(j + 1d)];

					cmp = StringOrder(da.string, db.string);
					if(asc){
						swap = cmp < 0d;
					}else{
						swap = cmp > 0d;
					}

					if(swap){
						tmp = da.string;
						da.string = db.string;
						db.string = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}

	public static double StringOrder(char [] a, char [] b){
		double order, minimum, i, ac, bc;
		boolean done;

		minimum = min(a.length, b.length);

		done = false;
		order = 0d;
		for(i = 0d; i < minimum && !done; i = i + 1d){
			ac = a[(int)(i)];
			bc = b[(int)(i)];

			if(ac < bc){
				done = true;
				order = 1d;
			}else if(ac > bc){
				done = true;
				order = -1d;
			}
		}

		if(!done){
			if(a.length < b.length){
				order = 1d;
			}else if(a.length > b.length){
				order = -1d;
			}
		}

		return order;
	}

	public static boolean SortNumberArray(Array a){
		return SortNumberArrayWithOptions(a, true);
	}

	public static boolean SortNumberArrayDescending(Array a){
		return SortNumberArrayWithOptions(a, false);
	}

	public static boolean SortNumberArrayWithOptions(Array a, boolean asc){
		boolean success;
		double i, j, len;
		boolean swapped, swap;
		double tmp;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			if(IsNumber(ArrayIndex(a, i))){
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = a.array[(int)(j)];
					db = a.array[(int)(j + 1d)];

					if(asc){
						swap = da.number > db.number;
					}else{
						swap = da.number < db.number;
					}

					if(swap){
						tmp = da.number;
						da.number = db.number;
						db.number = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}

	public static boolean SortStructArrayByNumberKey(Array a, char [] key){
		return SortStructArrayByNumberKeyWithOptions(a, key, true);
	}

	public static boolean SortStructArrayByNumberKeyDescending(Array a, char [] key){
		return SortStructArrayByNumberKeyWithOptions(a, key, false);
	}

	public static boolean SortStructArrayByNumberKeyWithOptions(Array a, char [] key, boolean asc){
		boolean success;
		double i, j, len;
		boolean swapped, swap;
		Structure tmp;
		double na, nb;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			da = ArrayIndex(a, i);
			if(IsStructure(da)){
				if(StructHasKey(da.structure, key)){
					da = GetDataFromStruct(da.structure, key);
					if(IsNumber(da)){
					}else{
						success = false;
					}
				}else{
					success = false;
				}
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = ArrayIndex(a, j);
					db = ArrayIndex(a, j + 1d);

					na = GetNumberFromStruct(da.structure, key);
					nb = GetNumberFromStruct(db.structure, key);

					if(asc){
						swap = na > nb;
					}else{
						swap = na < nb;
					}

					if(swap){
						tmp = da.structure;
						da.structure = db.structure;
						db.structure = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}

	public static boolean SortStructArrayByStringKey(Array a, char [] key){
		return SortStructArrayByStringKeyWithOptions(a, key, true);
	}

	public static boolean SortStructArrayByStringKeyDescending(Array a, char [] key){
		return SortStructArrayByStringKeyWithOptions(a, key, false);
	}

	public static boolean SortStructArrayByStringKeyWithOptions(Array a, char [] key, boolean asc){
		boolean success;
		double i, j, len, cmp;
		boolean swapped, swap;
		Structure tmp;
		char [] sa, sb;
		Data da, db;

		len = ArrayLength(a);
		success = true;
		for(i = 0d; i < len && success; i = i + 1d){
			da = ArrayIndex(a, i);
			if(IsStructure(da)){
				if(StructHasKey(da.structure, key)){
					da = GetDataFromStruct(da.structure, key);
					if(IsString(da)){
					}else{
						success = false;
					}
				}else{
					success = false;
				}
			}else{
				success = false;
			}
		}

		if(success){
			swapped = true;
			for(i = 0d; i < len - 1d && swapped; i = i + 1d){
				swapped = false;
				for(j = 0d; j < len - i - 1d; j = j + 1d){
					da = ArrayIndex(a, j);
					db = ArrayIndex(a, j + 1d);

					sa = GetStringFromStruct(da.structure, key);
					sb = GetStringFromStruct(db.structure, key);

					cmp = StringOrder(sa, sb);
					if(asc){
						swap = cmp < 0d;
					}else{
						swap = cmp > 0d;
					}
					if(swap){
						tmp = da.structure;
						da.structure = db.structure;
						db.structure = tmp;
						swapped = true;
					}
				}
			}
		}

		return success;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
