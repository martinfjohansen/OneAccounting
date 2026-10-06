package com.martinfjohansen.oneaccounting.QuickSort.QuickSort;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysSwapElementsOfNumberArray;

public class QuickSort{
	public static void QuickSortNumbers(double [] list){
		QuickSortNumbersBounds(list, 0d, list.length - 1d);
	}

	public static void QuickSortNumbersBounds(double [] A, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortNumbersPartition(A, lo, hi);
			QuickSortNumbersBounds(A, lo, p - 1d);
			QuickSortNumbersBounds(A, p + 1d, hi);
		}
	}

	public static double QuickSortNumbersPartition(double [] A, double lo, double hi){
		double pivot, lowPos, j;

		pivot = A[(int)(hi)];
		lowPos = lo;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(A[(int)(j)] < pivot){
				arraysSwapElementsOfNumberArray(A, lowPos, j);
				lowPos = lowPos + 1d;
			}
		}
		arraysSwapElementsOfNumberArray(A, lowPos, hi);

		return lowPos;
	}

	public static double [] QuickSortNumbersWithIndexes(double [] A){
		double [] indexes;
		double i;

		indexes = new double [(int)(A.length)];

		for(i = 0d; i < A.length; i = i + 1d){
			indexes[(int)(i)] = i;
		}

		QuickSortNumbersBoundsWithIndexes(A, indexes, 0d, A.length - 1d);

		return indexes;
	}

	public static void QuickSortNumbersBoundsWithIndexes(double [] A, double [] indexes, double lo, double hi){
		double p;

		if(lo < hi){
			p = QuickSortNumbersPartitionWithIndexes(A, indexes, lo, hi);
			QuickSortNumbersBoundsWithIndexes(A, indexes, lo, p - 1d);
			QuickSortNumbersBoundsWithIndexes(A, indexes, p + 1d, hi);
		}
	}

	public static double QuickSortNumbersPartitionWithIndexes(double [] A, double [] indexes, double lo, double hi){
		double pivot, i, j;

		pivot = A[(int)(hi)];
		i = lo - 1d;
		for(j = lo; j <= hi - 1d; j = j + 1d){
			if(A[(int)(j)] < pivot){
				i = i + 1d;
				arraysSwapElementsOfNumberArray(A, i, j);
				arraysSwapElementsOfNumberArray(indexes, i, j);
			}
		}
		arraysSwapElementsOfNumberArray(A, i + 1d, hi);
		arraysSwapElementsOfNumberArray(indexes, i + 1d, hi);

		return i + 1d;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
