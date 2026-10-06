package com.martinfjohansen.oneaccounting.Matrices.ComplexMatrices;

import com.martinfjohansen.oneaccounting.Matrices.Matrices.Matrix;
import com.martinfjohansen.oneaccounting.Matrices.Matrices.MatrixRow;
import com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.cComplexNumber;
import com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.cComplexNumberArrayReference;
import com.martinfjohansen.oneaccounting.pPolynomials.ComplexPolynomials.pComplexPolynomial;

import static com.martinfjohansen.oneaccounting.Matrices.Matrices.Matrices.NumberOfColumns;
import static com.martinfjohansen.oneaccounting.Matrices.Matrices.Matrices.NumberOfRows;
import static com.martinfjohansen.oneaccounting.cComplexNumbers.ComplexNumbers.ComplexNumbers.*;
import static com.martinfjohansen.oneaccounting.pPolynomials.ComplexPolynomials.ComplexPolynomials.pEvaluateComplex;
import static java.lang.Math.pow;
import static java.lang.Math.sqrt;

public class ComplexMatrices{
	public static ComplexMatrix CreateComplexMatrix(double rows, double cols){
		double m, n;
		ComplexMatrix matrix;

		matrix = new ComplexMatrix();
		matrix.r = new ComplexMatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new ComplexMatrixRow();
			matrix.r[(int)(m)].c = new cComplexNumber[(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = cCreateComplexNumber(0d, 0d);
			}
		}

		return matrix;
	}

	public static ComplexMatrix CreateComplexMatrixFromMatrix(Matrix a){
		double m, n, rows, cols;
		ComplexMatrix matrix;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(a);

		matrix = new ComplexMatrix();
		matrix.r = new ComplexMatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new ComplexMatrixRow();
			matrix.r[(int)(m)].c = new cComplexNumber [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = cCreateComplexNumber(a.r[(int)(m)].c[(int)(n)], 0d);
			}
		}

		return matrix;
	}

	public static Matrix CreateReMatrixFromComplexMatrix(ComplexMatrix a){
		double m, n, rows, cols;
		Matrix matrix;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(a);

		matrix = new Matrix();
		matrix.r = new MatrixRow[(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = IndexComplex(a, m, n).re;
			}
		}

		return matrix;
	}

	public static Matrix CreateImMatrixFromComplexMatrix(ComplexMatrix a){
		double m, n, rows, cols;
		Matrix matrix;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(a);

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = IndexComplex(a, m, n).im;
			}
		}

		return matrix;
	}

	public static double NumberOfRowsComplex(ComplexMatrix A){
		return A.r.length;
	}

	public static double NumberOfColumnsComplex(ComplexMatrix A){
		return A.r[0].c.length;
	}

	public static cComplexNumber IndexComplex(ComplexMatrix a, double m, double n){
		return a.r[(int)(m)].c[(int)(n)];
	}

	public static void AddComplex(ComplexMatrix a, ComplexMatrix b){
		double m, n;
		double d;

		d = NumberOfRowsComplex(a);

		for(m = 0d; m < d; m = m + 1d){
			for(n = 0d; n < d; n = n + 1d){
				cAdd(IndexComplex(a, m, n), IndexComplex(b, m, n));
			}
		}
	}

	public static void SubtractComplex(ComplexMatrix a, ComplexMatrix b){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(a);
		c = NumberOfColumnsComplex(a);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cSub(IndexComplex(a, m, n), IndexComplex(b, m, n));
			}
		}
	}

	public static ComplexMatrix SubtractComplexToNew(ComplexMatrix a, ComplexMatrix b){
		ComplexMatrix X;

		X = CreateCopyOfComplexMatrix(a);
		SubtractComplex(X, b);

		return X;
	}

	public static void MultiplyComplex(ComplexMatrix x, ComplexMatrix a, ComplexMatrix b){
		double m, n;
		double rows, cols, d;
		double i;
		cComplexNumber s, t;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(b);
		d = NumberOfColumnsComplex(a);
		t = cCreateComplexNumber(0d, 0d);

		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				s = cCreateComplexNumber(0d, 0d);

				for(i = 0d; i < d; i = i + 1d){
					cAssignComplex(t, s);
					cAssignComplex(s, IndexComplex(a, m, i));
					cMul(s, IndexComplex(b, i, n));
					cAdd(s, t);
				}

				x.r[(int)(m)].c[(int)(n)] = s;
			}
		}
	}

	public static ComplexMatrix MultiplyComplexToNew(ComplexMatrix a, ComplexMatrix b){
		double rows, cols;
		ComplexMatrix x;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(b);
		x = CreateComplexMatrix(rows, cols);
		MultiplyComplex(x, a, b);

		return x;
	}

	public static void Conjugate(ComplexMatrix a){
		double m, n;
		double rows, cols;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfRowsComplex(a);

		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				cConjugate(IndexComplex(a, m, n));
			}
		}
	}

	public static void AssignComplexMatrix(ComplexMatrix A, ComplexMatrix B){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n));
			}
		}
	}

	public static void ScalarMultiplyComplex(ComplexMatrix A, cComplexNumber b){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cMul(IndexComplex(A, m, n), b);
			}
		}
	}

	public static ComplexMatrix ScalarMultiplyComplexToNew(ComplexMatrix A, cComplexNumber b){
		ComplexMatrix matrix;

		matrix = CreateCopyOfComplexMatrix(A);
		ScalarMultiplyComplex(matrix, b);

		return matrix;
	}

	public static void ScalarDivideComplex(ComplexMatrix A, cComplexNumber b){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cDiv(IndexComplex(A, m, n), b);
			}
		}
	}

	public static void ElementWisePowerComplex(ComplexMatrix A, double p){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cPower(IndexComplex(A, m, n), p);
			}
		}
	}

	public static ComplexMatrix CreateComplexIdentityMatrix(double d){
		double m;
		ComplexMatrix matrix;

		matrix = CreateSquareComplexMatrix(d);
		FillComplex(matrix, 0d, 0d);

		for(m = 0d; m < d; m = m + 1d){
			IndexComplex(matrix, m, m).re = 1d;
		}

		return matrix;
	}

	public static ComplexMatrix CreateSquareComplexMatrix(double d){
		double m, n;
		ComplexMatrix matrix;

		matrix = new ComplexMatrix();
		matrix.r = new ComplexMatrixRow [(int)(d)];
		for(m = 0d; m < d; m = m + 1d){
			matrix.r[(int)(m)] = new ComplexMatrixRow();
			matrix.r[(int)(m)].c = new cComplexNumber [(int)(d)];
			for(n = 0d; n < d; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = cCreateComplexNumber(0d, 0d);
			}
		}

		return matrix;
	}

	public static void ClearComplex(ComplexMatrix a){
		FillComplex(a, 0d, 0d);
	}

	public static void FillComplex(ComplexMatrix a, double re, double im){
		double m, n;

		for(m = 0d; m < NumberOfRowsComplex(a); m = m + 1d){
			for(n = 0d; n < NumberOfColumnsComplex(a); n = n + 1d){
				IndexComplex(a, m, n).re = re;
				IndexComplex(a, m, n).im = im;
			}
		}
	}

	public static cComplexNumber TraceComplex(ComplexMatrix a){
		double m;
		double d;
		cComplexNumber tr;

		tr = cCreateComplexNumber(0d, 0d);

		d = a.r.length;
		for(m = 0d; m < d; m = m + 1d){
			cAdd(tr, IndexComplex(a, m, m));
		}

		return tr;
	}

	public static void CofactorOfComplexMatrix(ComplexMatrix mat, ComplexMatrix temp, double p, double q, double n){
		double i, j;
		double row, col;

		i = 0d;
		j = 0d;

		for(row = 0d; row < n; row = row + 1d){
			for(col = 0d; col < n; col = col + 1d){
				if(row != p && col != q){
					cAssignComplex(IndexComplex(temp, i, j), IndexComplex(mat, row, col));
					j = j + 1d;

					if(j == n - 1d){
						j = 0d;
						i = i + 1d;
					}
				}
			}
		}
	}

	public static cComplexNumber DeterminantOfComplexSubmatrix(ComplexMatrix mat, double n){
		double f, sign;
		cComplexNumber D, t;
		ComplexMatrix temp;

		D = cCreateComplexNumber(0d, 0d);
		t = cCreateComplexNumber(0d, 0d);

		if(n == 1d){
			D = mat.r[0].c[0];
		}else{
			temp = CreateSquareComplexMatrix(n);

			sign = 1d;

			for(f = 0d; f < n; f = f + 1d){
				CofactorOfComplexMatrix(mat, temp, 0d, f, n);
				cAssignComplexByValues(t, sign, 0d);
				cMul(t, IndexComplex(mat, 0d, f));
				cMul(t, DeterminantOfComplexSubmatrix(temp, n - 1d));
				cAdd(D, t);
				sign = -sign;
			}

			DeleteComplexMatrix(temp);
		}

		return D;
	}

	public static void DeleteComplexMatrix(ComplexMatrix X){
		double m, n, rows, cols;

		rows = NumberOfRowsComplex(X);
		cols = NumberOfColumnsComplex(X);
		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				delete(X.r[(int)(m)].c[(int)(n)]);
			}
			delete(X.r[(int)(m)].c);
			delete(X.r[(int)(m)]);
		}

		delete(X.r);
		delete(X);
	}

	public static cComplexNumber DeterminantComplex(ComplexMatrix m){
		double n;
		cComplexNumber D;

		n = NumberOfRowsComplex(m);
		D = DeterminantOfComplexSubmatrix(m, n);

		return D;
	}

	public static void AdjointComplex(ComplexMatrix A, ComplexMatrix adj){
		double n;
		ComplexMatrix cofactors;
		double i, j;
		cComplexNumber t, sign;

		n = A.r.length;
		t = cCreateComplexNumber(0d, 0d);
		sign = cCreateComplexNumber(0d, 0d);

		if(n == 1d){
			cAssignComplexByValues(IndexComplex(adj, 0d, 0d), 1d, 0d);
		}else{
			cofactors = CreateSquareComplexMatrix(n);

			for(i = 0d; i < n; i = i + 1d){
				for(j = 0d; j < n; j = j + 1d){
					CofactorOfComplexMatrix(A, cofactors, i, j, n);

					if((i + j)%2d == 0d){
						cAssignComplexByValues(sign, 1d, 0d);
					}else{
						cAssignComplexByValues(sign, -1d, 0d);
					}

					cAssignComplex(t, sign);
					cMul(t, DeterminantOfComplexSubmatrix(cofactors, n - 1d));
					cAssignComplex(IndexComplex(adj, j, i), t);
				}
			}

			DeleteComplexMatrix(cofactors);
		}
	}

	public static boolean InverseComplex(ComplexMatrix A, ComplexMatrix inverseResult){
		boolean success;
		ComplexMatrix adj;
		double n, i, j;
		cComplexNumber det, t;

		t = cCreateComplexNumber(0d, 0d);

		if(NumberOfColumnsComplex(A) == NumberOfRowsComplex(A)){
			n = NumberOfColumnsComplex(A);

			det = DeterminantComplex(A);
			if(det.re != 0d || det.im != 0d){
				adj = CreateSquareComplexMatrix(n);
				AdjointComplex(A, adj);

				for(i = 0d; i < n; i = i + 1d){
					for(j = 0d; j < n; j = j + 1d){
						cAssignComplex(t, IndexComplex(adj, i, j));
						cDiv(t, det);
						cAssignComplex(IndexComplex(inverseResult, i, j), t);
					}
				}

				success = true;
				DeleteComplexMatrix(adj);
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean ComplexMatrixEqualsEpsilon(ComplexMatrix b, ComplexMatrix f, double epsilon){
		double x, y, columns, rows;
		boolean equals;

		equals = true;

		if(NumberOfRowsComplex(b) == NumberOfRowsComplex(f) && NumberOfColumnsComplex(b) == NumberOfColumnsComplex(f)){
			columns = NumberOfColumnsComplex(b);
			rows = NumberOfRowsComplex(b);

			for(x = 0d; x < rows; x = x + 1d){
				for(y = 0d; y < columns; y = y + 1d){
					equals = equals && cEpsilonCompareComplex(IndexComplex(b, x, y), IndexComplex(f, x, y), epsilon);
				}
			}
		}else{
			equals = false;
		}

		return equals;
	}

	public static ComplexMatrix MinorComplex(ComplexMatrix x, double row, double column){
		ComplexMatrix minor;
		double cols, rows, i, j, m, n;

		rows = NumberOfRowsComplex(x) - 1d;
		cols = NumberOfColumnsComplex(x) - 1d;

		minor = CreateComplexMatrix(rows, cols);

		for(i = 0d; i < rows; i = i + 1d){
			if(i < row){
				m = i;
			}else{
				m = i + 1d;
			}

			for(j = 0d; i != row && j < cols; j = j + 1d){
				if(j != column){

					if(j < column){
						n = j;
					}else{
						n = j + 1d;
					}

					cAssignComplex(IndexComplex(minor, m, n), IndexComplex(x, i, j));
				}
			}
		}

		return minor;
	}

	public static void AssignComplex(ComplexMatrix A, ComplexMatrix B){
		double m, n;
		double r, c;

		r = NumberOfRowsComplex(A);
		c = NumberOfColumnsComplex(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				cAssignComplex(IndexComplex(A, m, n), IndexComplex(B, m, n));
			}
		}
	}

	public static ComplexMatrix CreateCopyOfComplexMatrix(ComplexMatrix A){
		ComplexMatrix X;

		X = CreateComplexMatrix(NumberOfRowsComplex(A), NumberOfColumnsComplex(A));
		AssignComplex(X, A);

		return X;
	}

	public static boolean TransposeComplex(ComplexMatrix a){
		double m, n;
		double rows;
		boolean square;
		cComplexNumber tmp;

		tmp = cCreateComplexNumber(0d, 0d);

		square = IsSquareComplexMatrix(a);
		if(square){
			rows = NumberOfColumnsComplex(a);

			for(m = 0d; m < rows; m = m + 1d){
				for(n = 0d; n < m; n = n + 1d){
					cAssignComplex(tmp, IndexComplex(a, n, m));
					cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n));
					cAssignComplex(IndexComplex(a, m, n), tmp);
				}
			}
		}

		return square;
	}

	public static boolean ConjugateTransposeComplex(ComplexMatrix a){
		double m, n;
		double rows;
		boolean square;
		cComplexNumber tmp;

		tmp = cCreateComplexNumber(0d, 0d);

		square = IsSquareComplexMatrix(a);
		if(square){
			rows = NumberOfColumnsComplex(a);

			for(m = 0d; m < rows; m = m + 1d){
				for(n = 0d; n < m; n = n + 1d){
					cAssignComplex(tmp, IndexComplex(a, n, m));
					cAssignComplex(IndexComplex(a, n, m), IndexComplex(a, m, n));
					cAssignComplex(IndexComplex(a, m, n), tmp);
					cConjugate(IndexComplex(a, m, n));
				}
			}
		}

		return square;
	}

	public static boolean IsSquareComplexMatrix(ComplexMatrix A){
		boolean is;

		if(NumberOfRowsComplex(A) == NumberOfColumnsComplex(A)){
			is = true;
		}else{
			is = false;
		}

		return is;
	}

	public static void TransposeComplexAssign(ComplexMatrix t, ComplexMatrix a){
		double m, n;
		double rows, cols;

		cols = NumberOfRowsComplex(a);
		rows = NumberOfColumnsComplex(a);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				cAssignComplex(IndexComplex(t, n, m), IndexComplex(a, m, n));
			}
		}
	}

	public static ComplexMatrix TransposeComplexToNew(ComplexMatrix a){
		double m, n;
		double rows, cols;
		ComplexMatrix c;

		cols = NumberOfRowsComplex(a);
		rows = NumberOfColumnsComplex(a);

		c = CreateComplexMatrix(rows, cols);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				cAssignComplex(IndexComplex(c, n, m), IndexComplex(a, m, n));
			}
		}

		return c;
	}

	public static ComplexMatrix ExtractComplexSubMatrix(ComplexMatrix M, double r1, double r2, double c1, double c2){
		ComplexMatrix A;
		double i, j;

		A = CreateComplexMatrix(r2 - r1 + 1d, c2 - c1 + 1d);

		for(i = r1; i <= r2; i = i + 1d){
			for(j = c1; j <= c2; j = j + 1d){
				cAssignComplex(IndexComplex(A, i - r1, j - c1), IndexComplex(M, i, j));
			}
		}

		return A;
	}

	public static double NormComplex(ComplexMatrix a){
		double l, i, j, rows, cols;
		cComplexNumber cComplexNumber;

		l = 0d;

		rows = NumberOfRowsComplex(a);
		cols = NumberOfColumnsComplex(a);

		for(i = 0d; i < rows; i = i + 1d){
			for(j = 0d; j < cols; j = j + 1d){
				cComplexNumber = IndexComplex(a, i, j);
				l = l + pow(cComplexNumber.re, 2d) + pow(cComplexNumber.im, 2d);
			}
		}
		l = sqrt(l);

		return l;
	}

	public static void ComplexCharacteristicPolynomial(ComplexMatrix A, pComplexPolynomial p){
		ComplexMatrix cp;
		cComplexNumber determinant;

		cp = CreateSquareComplexMatrix(NumberOfRowsComplex(A));
		determinant = new cComplexNumber();

		ComplexCharacteristicPolynomialWithInverse(A, cp, p, determinant);

		DeleteComplexMatrix(cp);
	}

	public static void ComplexCharacteristicPolynomialWithInverse(ComplexMatrix A, ComplexMatrix AInverse, pComplexPolynomial p, cComplexNumber determinant){
		FaddeevLeVerrierAlgorithmComplex(A, AInverse, p, determinant);
	}

	public static void FaddeevLeVerrierAlgorithmComplex(ComplexMatrix A, ComplexMatrix AInverse, pComplexPolynomial p, cComplexNumber determinant){
		ComplexMatrix Mk, Mkm1, t1, Id;
		cComplexNumber t, t2, n1;
		double i, n, k;

		n1 = cCreateComplexNumber(-1d, 0d);
		n = NumberOfRowsComplex(A);
		p.cs = new cComplexNumber [(int)(n + 1d)];
		for(i = 0d; i < n + 1d; i = i + 1d){
			p.cs[(int)(i)] = new cComplexNumber();
		}
		cAssignComplexByValues(p.cs[(int)(n)], 1d, 0d);
		Mkm1 = CreateSquareComplexMatrix(n);
		FillComplex(Mkm1, 0d, 0d);
		Id = CreateComplexIdentityMatrix(n);
		Mk = CreateSquareComplexMatrix(n);
		t1 = CreateSquareComplexMatrix(n);

		for(k = 1d; k <= n; k = k + 1d){
			MultiplyComplex(Mk, A, Mkm1);
			AssignComplex(t1, Id);
			ScalarMultiplyComplex(t1, p.cs[(int)(n - k + 1d)]);
			AddComplex(Mk, t1);

			MultiplyComplex(t1, A, Mk);
			t = TraceComplex(t1);
			t2 = cCreateComplexNumber(-1d/k, 0d);
			cMul(t, t2);
			cAssignComplex(p.cs[(int)(n - k)], t);

			/* done*/
			AssignComplex(Mkm1, Mk);

			if(k == n){
				AssignComplex(AInverse, Mk);
				cAssignComplex(t, p.cs[0]);
				cMul(t, n1);
				cAssignComplex(determinant, t);
				if(t.re == 0d && t.im == 0d){
				}else{
					ScalarDivideComplex(AInverse, t);
				}
			}
		}

		DeleteComplexMatrix(Mkm1);
		DeleteComplexMatrix(Id);
		DeleteComplexMatrix(Mk);
		DeleteComplexMatrix(t1);
	}

	public static boolean EigenvaluesComplex(ComplexMatrix A, cComplexNumberArrayReference eigenValuesReference){
		ComplexMatrixArrayReference eigenVectorsReference;
		boolean success;
		double i;

		eigenVectorsReference = new ComplexMatrixArrayReference();
		success = EigenpairsComplex(A, eigenValuesReference, eigenVectorsReference);
		if(success){
			for(i = 0d; i < eigenVectorsReference.matrices.length; i = i + 1d){
				DeleteComplexMatrix(eigenVectorsReference.matrices[(int)(i)]);
			}
			delete(eigenVectorsReference.matrices);
			delete(eigenVectorsReference);
		}

		return success;
	}

	public static boolean EigenvectorsComplex(ComplexMatrix A, ComplexMatrixArrayReference eigenVectorsReference){
		cComplexNumberArrayReference evsReference;
		boolean success;
		double i;

		evsReference = new cComplexNumberArrayReference();
		success = EigenpairsComplex(A, evsReference, eigenVectorsReference);
		if(success){
			for(i = 0d; i < evsReference.complexNumbers.length; i = i + 1d){
				delete(evsReference.complexNumbers[(int)(i)]);
			}
			delete(evsReference.complexNumbers);
			delete(evsReference);
		}

		return success;
	}

	public static boolean InversePowerMethodComplex(ComplexMatrix A, cComplexNumber eigenvalue, double maxIterations, cComplexNumberArrayReference eigenvector){
		ComplexMatrix t1, t2, t3, t4, b;
		double n, i, c;
		boolean isSingular;
		cComplexNumber c101, k, cc;

		n = NumberOfRowsComplex(A);

		t2 = CreateComplexIdentityMatrix(n);
		ScalarMultiplyComplex(t2, eigenvalue);
		t3 = SubtractComplexToNew(A, t2);
		t4 = CreateSquareComplexMatrix(n);
		isSingular = !InverseComplex(t3, t4);
		cc = cCreateComplexNumber(0d, 0d);
		t1 = CreateComplexMatrix(n, 1d);

		if(isSingular){
			DeleteComplexMatrix(t2);
			DeleteComplexMatrix(t3);
			DeleteComplexMatrix(t4);

			c101 = cCreateComplexNumber(1.01, 0d);
			/* Try again with more erroneous eigenvalue estimate.*/
			t2 = CreateComplexIdentityMatrix(n);
			k = cMulToNew(eigenvalue, c101);
			ScalarMultiplyComplex(t2, k);
			t3 = SubtractComplexToNew(A, t2);
			t4 = CreateSquareComplexMatrix(n);
			isSingular = !InverseComplex(t3, t4);
			delete(c101);
		}

		if(!isSingular){
			b = CreateComplexMatrix(n, 1d);

			for(i = 0d; i < n; i = i + 1d){
				cAssignComplexByValues(b.r[(int)(i)].c[0], 1d, 1d);
			}

			for(i = 0d; i < maxIterations; i = i + 1d){
				MultiplyComplex(t1, t4, b);
				c = NormComplex(t1);
				cAssignComplexByValues(cc, c, 0d);
				ScalarDivideComplex(t1, cc);
				AssignComplex(b, t1);
			}

			eigenvector.complexNumbers = new cComplexNumber [(int)(n)];
			for(i = 0d; i < n; i = i + 1d){
				eigenvector.complexNumbers[(int)(i)] = b.r[(int)(i)].c[0];
			}
		}

		DeleteComplexMatrix(t1);
		DeleteComplexMatrix(t2);
		DeleteComplexMatrix(t3);
		DeleteComplexMatrix(t4);
		delete(cc);

		return !isSingular;
	}

	public static boolean EigenpairsComplex(ComplexMatrix M, cComplexNumberArrayReference eigenValuesReference, ComplexMatrixArrayReference eigenVectorsReference){
		return ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(M, eigenValuesReference, eigenVectorsReference, 0.000001, 100d);
	}

	public static boolean ComplexEigenpairsUsingDurandKernerAndInversePowerMethod(ComplexMatrix M, cComplexNumberArrayReference eigenValuesReference, ComplexMatrixArrayReference eigenVectorsReference, double precision, double maxIterations){
		boolean success, inverseSuccess;
		double n, i, j, k, withinPrecision;
		cComplexNumber t1, t2, t3, xn1, eigenValue;
		cComplexNumber [] rs, rsPrev;
		pComplexPolynomial p;
		cComplexNumberArrayReference evecReference;
		ComplexMatrix eigenVector;

		evecReference = new cComplexNumberArrayReference();

		p = new pComplexPolynomial();
		ComplexCharacteristicPolynomial(M, p);

		n = p.cs.length - 1d;
		rs = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rs[(int)(i)] = cCreateComplexNumber(0d, 0d);
		}
		rsPrev = new cComplexNumber [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			rsPrev[(int)(i)] = cCreateComplexNumber(0.4, 0.9);
			cPower(rsPrev[(int)(i)], i);
		}
		t2 = cCreateComplexNumber(0d, 0d);
		t3 = cCreateComplexNumber(0d, 0d);

		success = false;

		eigenVectorsReference.matrices = new ComplexMatrix [(int)(n)];
		for(i = 0d; i < n; i = i + 1d){
			eigenVectorsReference.matrices[(int)(i)] = CreateComplexMatrix(n, 1d);
		}

		for(i = 0d; i < maxIterations && !success; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				xn1 = rsPrev[(int)(j)];

				t1 = pEvaluateComplex(p, xn1);
				cAssignComplexByValues(t2, 1d, 0d);
				for(k = 0d; k < n; k = k + 1d){
					if(k < j){
						cAssignComplex(t3, xn1);
						cSub(t3, rs[(int)(k)]);
						cMul(t2, t3);
					}
					if(k > j){
						cAssignComplex(t3, xn1);
						cSub(t3, rsPrev[(int)(k)]);
						cMul(t2, t3);
					}
				}
				cDiv(t1, t2);
				cAssignComplex(rs[(int)(j)], xn1);
				cSub(rs[(int)(j)], t1);

				delete(t1);
			}
			withinPrecision = 0d;
			for(j = 0d; j < n; j = j + 1d){
				eigenValue = rs[(int)(j)];

				/* Calculate the eigenvector corresponding to the eigenvalue.*/
				inverseSuccess = InversePowerMethodComplex(M, eigenValue, i + 1d, evecReference);
				if(inverseSuccess){
					for(k = 0d; k < n; k = k + 1d){
						eigenVectorsReference.matrices[(int)(j)].r[(int)(k)].c[0] = evecReference.complexNumbers[(int)(k)];
					}

					/* Check eigenpair agains precision.*/
					eigenVector = eigenVectorsReference.matrices[(int)(j)];

					if(CheckComplexEigenpairPrecision(M, eigenValue, eigenVector, precision)){
						withinPrecision = withinPrecision + 1d;
					}
					cAssignComplex(rsPrev[(int)(j)], rs[(int)(j)]);
				}
			}
			if(withinPrecision == n){
				success = true;
			}
		}

		eigenValuesReference.complexNumbers = rs;

		return success;
	}

	public static boolean CheckComplexEigenpairPrecision(ComplexMatrix a, cComplexNumber lambda, ComplexMatrix e, double precision){
		ComplexMatrix vec1, vec2;
		boolean equal;

		vec1 = MultiplyComplexToNew(a, e);
		vec2 = ScalarMultiplyComplexToNew(e, lambda);

		equal = ComplexMatrixEqualsEpsilon(vec1, vec2, precision);

		return equal;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
