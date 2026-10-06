package com.martinfjohansen.oneaccounting.QuickSort.QuickSortStrings;

import com.martinfjohansen.oneaccounting.references.references.StringArrayReference;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysSwapElementsOfNumberArray;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysSwapElementsOfStringArray;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strStringIsBefore;

public class QuickSortStrings{
	public static void QuickSortStrings(StringArrayReference list){
		QuickSortStringsBounds(list, 0d, list.stringArray.length - 1d);
	}

	public static void QuickSortStringsBounds(StringArrayReference A, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortStringsPartition(A, lo, hi);
			QuickSortStringsBounds(A, lo, p - 1d);
			QuickSortStringsBounds(A, p + 1d, hi);
		}
	}

	public static double QuickSortStringsPartition(StringArrayReference A, double lo, double hi){
		char [] pivot;
		double i, j;

		pivot = A.stringArray[(int)(hi)].string;
		i = lo - 1d;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(strStringIsBefore(A.stringArray[(int)(j)].string, pivot)){
				i = i + 1d;
				arraysSwapElementsOfStringArray(A, i, j);
			}
		}
		arraysSwapElementsOfStringArray(A, i + 1d, hi);

		return i + 1d;
	}

	public static double [] QuickSortStringsWithIndexes(StringArrayReference A){
		double [] indexes;
		double i;

		indexes = new double [(int)(A.stringArray.length)];

		for(i = 0d; i < A.stringArray.length; i = i + 1d){
			indexes[(int)(i)] = i;
		}

		QuickSortStringsBoundsWithIndexes(A, indexes, 0d, A.stringArray.length - 1d);

		return indexes;
	}

	public static void QuickSortStringsBoundsWithIndexes(StringArrayReference A, double [] indexes, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortStringsPartitionWithIndexes(A, indexes, lo, hi);
			QuickSortStringsBoundsWithIndexes(A, indexes, lo, p - 1d);
			QuickSortStringsBoundsWithIndexes(A, indexes, p + 1d, hi);
		}
	}

	public static double QuickSortStringsPartitionWithIndexes(StringArrayReference A, double [] indexes, double lo, double hi){
		double i, j;
		char [] pivot;

		pivot = A.stringArray[(int)(hi)].string;
		i = lo - 1d;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(strStringIsBefore(A.stringArray[(int)(j)].string, pivot)){
				i = i + 1d;
				arraysSwapElementsOfStringArray(A, i, j);
				arraysSwapElementsOfNumberArray(indexes, i, j);
			}
		}
		arraysSwapElementsOfStringArray(A, i + 1d, hi);
		arraysSwapElementsOfNumberArray(indexes, i + 1d, hi);

		return i + 1d;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
