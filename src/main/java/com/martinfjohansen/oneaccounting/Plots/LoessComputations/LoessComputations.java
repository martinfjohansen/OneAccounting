package com.martinfjohansen.oneaccounting.Plots.LoessComputations;

import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.QuickSort.QuickSort.QuickSort.QuickSortNumbers;
import static com.martinfjohansen.oneaccounting.QuickSort.QuickSort.QuickSort.QuickSortNumbersWithIndexes;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysCopyNumberArray;
import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysFillNumberArray;
import static com.martinfjohansen.oneaccounting.math.math.math.Truncate;
import static java.lang.Math.*;

public class LoessComputations{
	public static boolean Loess(double [] xs, double [] ys, double bandwidth, double robustnessIters, double accuracy, NumberArrayReference resultXs, StringReference errorMessage){
		double [] weights;

		weights = new double [(int)(xs.length)];
		arraysFillNumberArray(weights, 1d);

		return Lowess(xs, ys, weights, bandwidth, robustnessIters, accuracy, resultXs, errorMessage);
	}

	public static boolean Lowess(double [] xs, double [] ys, double [] weights, double bandwidth, double robustnessIters, double accuracy, NumberArrayReference resultXs, StringReference errorMessage){
		double [] res, residuals, sortedResiduals, robustnessWeights, indexes;
		double n, i, k;
		double x, sumWeights, sumX, sumXSquared, sumY, sumXY, denom;
		double xk, yk, dist, w, xkw;
		double meanX, meanY, meanXY, meanXSquared;
		double alpha, beta;
		double arg, iter, medianResidual;
		double [] bandwidthInterval;
		double ileft, iright, edge;
		double left, right, nextRight, nextLeft, bandwidthInPoints;
		boolean success, done;

		/* Sort arrays*/
		indexes = QuickSortNumbersWithIndexes(xs);
		RearrangeArray(ys, indexes);

		if(xs.length == ys.length && xs.length != 0d){
			n = xs.length;

			if(n == 1d || n == 2d){
				if(n == 1d){
					res = new double [1];
					res[0] = ys[0];
				}else{
					res = new double [2];
					res[0] = ys[0];
					res[1] = ys[1];
				}

				resultXs.numberArray = res;
				success = true;
			}else{
				bandwidthInPoints = Truncate(bandwidth*n);

				if(bandwidthInPoints >= 2d){
					res = new double [(int)(n)];
					residuals = new double [(int)(n)];

					robustnessWeights = new double [(int)(n)];
					arraysFillNumberArray(robustnessWeights, 1d);

					done = false;
					for(iter = 0d; iter <= robustnessIters && !done; iter = iter + 1d){
						bandwidthInterval = new double [2];
						bandwidthInterval[0] = 0d;
						bandwidthInterval[1] = bandwidthInPoints - 1d;

						for(i = 0d; i < n; i = i + 1d){
							x = xs[(int)(i)];

							if(i > 0d){
								left = bandwidthInterval[0];
								right = bandwidthInterval[1];

								nextRight = FindNextNonZeroElement(weights, right);
								nextLeft = left;
								for(; nextRight < xs.length && xs[(int)(nextRight)] - xs[(int)(i)] < xs[(int)(i)] - xs[(int)(nextLeft)]; ){
									nextLeft = FindNextNonZeroElement(weights, bandwidthInterval[0]);
									bandwidthInterval[0] = nextLeft;
									bandwidthInterval[1] = nextRight;
									nextRight = FindNextNonZeroElement(weights, nextRight);
								}
							}

							ileft = bandwidthInterval[0];
							iright = bandwidthInterval[1];

							if(xs[(int)(i)] - xs[(int)(ileft)] > xs[(int)(iright)] - xs[(int)(i)]){
								edge = ileft;
							}else{
								edge = iright;
							}

							sumWeights = 0d;
							sumX = 0d;
							sumXSquared = 0d;
							sumY = 0d;
							sumXY = 0d;
							denom = abs(1d/(xs[(int)(edge)] - x));
							for(k = ileft; k <= iright; k = k + 1d){
								xk = xs[(int)(k)];
								yk = ys[(int)(k)];

								if(k < i){
									dist = x - xk;
								}else{
									dist = xk - x;
								}

								w = Tricube(dist*denom)*robustnessWeights[(int)(k)]*weights[(int)(k)];
								xkw = xk*w;
								sumWeights = sumWeights + w;
								sumX = sumX + xkw;
								sumXSquared = sumXSquared + xk*xkw;
								sumY = sumY + yk*w;
								sumXY = sumXY + yk*xkw;
							}

							meanX = sumX/sumWeights;
							meanY = sumY/sumWeights;
							meanXY = sumXY/sumWeights;
							meanXSquared = sumXSquared/sumWeights;

							if(sqrt(abs(meanXSquared - meanX*meanX)) < accuracy){
								beta = 0d;
							}else{
								beta = (meanXY - meanX*meanY)/(meanXSquared - meanX*meanX);
							}

							alpha = meanY - beta*meanX;

							res[(int)(i)] = beta*x + alpha;

							residuals[(int)(i)] = abs(ys[(int)(i)] - res[(int)(i)]);
						}

						if(iter == robustnessIters){
							done = true;
						}

						if(!done){
							sortedResiduals = arraysCopyNumberArray(residuals);
							QuickSortNumbers(sortedResiduals);

							medianResidual = sortedResiduals[(int)(n/2d)];

							if(abs(medianResidual) < accuracy){
								done = true;
							}

							if(!done){
								for(i = 0d; i < n; i = i + 1d){
									arg = residuals[(int)(i)]/(6d*medianResidual);
									if(arg >= 1d){
										robustnessWeights[(int)(i)] = 0d;
									}else{
										w = 1d - arg*arg;
										robustnessWeights[(int)(i)] = w*w;
									}
								}
							}
						}
					}

					resultXs.numberArray = res;
					success = true;
				}else{
					success = false;
					errorMessage.string = "There must be at least two points.".toCharArray();
				}
			}
		}else{
			success = false;
			errorMessage.string = "There must be equal number of points, and over zero.".toCharArray();
		}

		return success;
	}

	public static void RearrangeArray(double [] as, double [] indexes){
		double [] bs;
		double i;

		bs = new double [(int)(as.length)];

		AssignNumberArray(bs, as);

		for(i = 0d; i < indexes.length; i = i + 1d){
			as[(int)(i)] = bs[(int)(indexes[(int)(i)])];
		}

		delete(bs);
	}

	public static void AssignNumberArray(double [] as, double [] bs){
		double i;

		for(i = 0d; i < min(as.length, bs.length); i = i + 1d){
			as[(int)(i)] = bs[(int)(i)];
		}
	}

	public static double FindNextNonZeroElement(double [] array, double offset){
		double position;
		boolean done;

		done = false;
		for(position = offset + 1d; position < array.length && !done; position = position + 1d){
			if(array[(int)(position)] != 0d){
				done = true;
			}
		}

		return position;
	}

	public static double Tricube(double x){
		double ax, result;

		ax = abs(x);

		if(ax >= 1d){
			result = 0d;
		}else{
			result = 1d - ax*ax*ax;
			result = result*result*result;
		}

		return result;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
