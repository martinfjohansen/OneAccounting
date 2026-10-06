package com.martinfjohansen.oneaccounting.BasicStatistics.BasicStatistics;

import com.martinfjohansen.oneaccounting.Matrices.Matrices.Matrix;

import static com.martinfjohansen.oneaccounting.Matrices.Matrices.Matrices.*;
import static com.martinfjohansen.oneaccounting.QuickSort.QuickSort.QuickSort.QuickSortNumbers;
import static com.martinfjohansen.oneaccounting.vectorVectorMath.VectorMath.VectorMath.vectorPower;
import static java.lang.Math.*;

public class BasicStatistics{
	public static double Mean(double [] list){
		double sum, i;

		sum = 0d;
		for(i = 0d; i < list.length; i = i + 1d){
			sum = sum + list[(int)(i)];
		}

		return sum/list.length;
	}

	public static double [] MeanOfRows(Matrix list){
		double [] means;
		double i;

		means = new double [(int)(list.r.length)];

		for(i = 0d; i < list.r.length; i = i + 1d){
			means[(int)(i)] = Mean(list.r[(int)(i)].c);
		}

		return means;
	}

	public static double [] MeanOfColumns(Matrix list){
		double [] means;
		Matrix listT;

		listT = TransposeToNew(list);

		means = MeanOfRows(listT);

		delete(listT);

		return means;
	}

	public static double Variance(double [] list){
		double mu, sum, i;

		mu = Mean(list);

		sum = 0d;
		for(i = 0d; i < list.length; i = i + 1d){
			sum = sum + pow(list[(int)(i)] - mu, 2d);
		}

		return sum/list.length;
	}

	public static double Covariance(double [] list1, double [] list2){
		double mu1, mu2, sum, i;

		sum = 0d;
		if(list1.length == list2.length){

			mu1 = Mean(list1);
			mu2 = Mean(list2);

			sum = 0d;
			for(i = 0d; i < list1.length; i = i + 1d){
				sum = sum + (list1[(int)(i)] - mu1)*(list2[(int)(i)] - mu2);
			}
		}

		return sum/list1.length;
	}

	public static Matrix CovarianceMatrix(Matrix X){
		Matrix A, XCentered, muMatrix;
		double [] mu;

		mu = MeanOfColumns(X);
		muMatrix = CreateMatrixFromRowCopies(mu, NumberOfRows(X));

		XCentered = CreateCopyOfMatrix(X);
		Subtract(XCentered, muMatrix);

		A = MultiplyToNew(TransposeToNew(XCentered), XCentered);
		ScalarDivide(A, NumberOfRows(X));

		return A;
	}

	public static Matrix CorrelationMatrix(Matrix X){
		Matrix sigma, variancesMatrix, t1, correlationMatrixResult;
		double [] variances;
		double n;

		sigma = SampleCovarianceMatrix(X);

		n = NumberOfRows(sigma);
		variances = new double [(int)(n)];
		ExtractDiagonal(sigma, variances);
		vectorPower(variances, -1d/2d);
		variancesMatrix = CreateDiagonalMatrixFromArray(variances);
		t1 = CreateCopyOfMatrix(variancesMatrix);
		Multiply(t1, variancesMatrix, sigma);
		correlationMatrixResult = CreateCopyOfMatrix(variancesMatrix);
		Multiply(correlationMatrixResult, t1, variancesMatrix);

		return correlationMatrixResult;
	}

	public static Matrix SampleCovarianceMatrix(Matrix X){
		Matrix A;

		A = CovarianceMatrix(X);
		ScalarMultiply(A, NumberOfRows(X)/(NumberOfRows(X) - 1d));

		return A;
	}

	public static double Correlation(double [] list1, double [] list2){
		double cv, sd1, sd2;

		cv = Covariance(list1, list2);
		sd1 = StandardDeviation(list1);
		sd2 = StandardDeviation(list2);

		return cv/(sd1*sd2);
	}

	public static double Percentile(double [] list, double p){
		return list[(int)(ceil(list.length*p) - 1d)];
	}

	public static double VarianceSample(double [] list){
		return Variance(list)*list.length/(list.length - 1d);
	}

	public static double StandardDeviation(double [] list){
		return sqrt(Variance(list));
	}

	public static double StandardDeviationSample(double [] list){
		return sqrt(VarianceSample(list));
	}

	public static double Median(double [] list){
		double m;

		QuickSortNumbers(list);

		if(list.length%2d == 1d){
			m = list[(int)(floor(list.length/2d))];
		}else{
			m = (list[(int)(list.length/2d)] + list[(int)(list.length/2d - 1d)])/2d;
		}

		return m;
	}

	public static double [] Mode(double [] list){
		double unique, mostFrequent, valuesMostFrequent;
		double [] modes, counts;

		modes = new double [0];
		if(list.length > 0d){
			QuickSortNumbers(list);
			unique = CountUniqueNumbers(list);
			counts = CountOccurrenceOfEachNumber(list, unique);
			mostFrequent = FindMostFrequentNumber(counts);
			valuesMostFrequent = CountNumberOfHighestOccurrences(mostFrequent, counts);
			delete(modes);
			modes = GetListOfNumbersWithHighestOccurrence(list, mostFrequent, valuesMostFrequent, counts);
			delete(counts);
		}

		return modes;
	}

	public static double CountUniqueNumbers(double [] list){
		double last, unique, i;

		last = list[0];
		unique = 1d;
		for(i = 1d; i < list.length; i = i + 1d){
			if(list[(int)(i)] != last){
				unique = unique + 1d;
				last = list[(int)(i)];
			}
		}

		return unique;
	}

	public static double [] CountOccurrenceOfEachNumber(double [] list, double unique){
		double [] counts;
		double current, last, i;

		counts = new double [(int)(unique)];

		current = 0d;
		counts[0] = 1d;
		last = list[0];
		for(i = 1d; i < list.length; i = i + 1d){
			if(list[(int)(i)] != last){
				current = current + 1d;
				counts[(int)(current)] = 1d;
			}else{
				counts[(int)(current)] = counts[(int)(current)] + 1d;
			}
			last = list[(int)(i)];
		}

		return counts;
	}

	public static double FindMostFrequentNumber(double [] counts){
		double mostFrequent, i;

		mostFrequent = 0d;
		for(i = 0d; i < counts.length; i = i + 1d){
			mostFrequent = max(counts[(int)(i)], mostFrequent);
		}
		return mostFrequent;
	}

	public static double CountNumberOfHighestOccurrences(double mostFrequent, double [] counts){
		double valuesMostFrequent, i;

		valuesMostFrequent = 0d;
		for(i = 0d; i < counts.length; i = i + 1d){
			if(counts[(int)(i)] == mostFrequent){
				valuesMostFrequent = valuesMostFrequent + 1d;
			}
		}
		return valuesMostFrequent;
	}

	public static double [] GetListOfNumbersWithHighestOccurrence(double [] list, double mostFrequent, double valuesMostFrequent, double [] counts){
		double [] modes;
		double current, currentInsert, i;

		modes = new double [(int)(valuesMostFrequent)];

		current = 0d;
		currentInsert = 0d;
		for(i = 0d; i < counts.length; i = i + 1d){
			if(counts[(int)(i)] == mostFrequent){
				modes[(int)(currentInsert)] = list[(int)(current)];
				currentInsert = currentInsert + 1d;
			}

			current = current + counts[(int)(i)];
		}

		return modes;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
