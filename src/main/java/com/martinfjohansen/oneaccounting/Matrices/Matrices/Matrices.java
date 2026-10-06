package com.martinfjohansen.oneaccounting.Matrices.Matrices;

import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;
import com.martinfjohansen.oneaccounting.references.references.NumberReference;
import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.PolynomialSolver.PolynomialSolver.PolynomialSolver.FindRoots;
import static com.martinfjohansen.oneaccounting.math.math.math.*;
import static com.martinfjohansen.oneaccounting.numbers.NumberToString.NumberToString.CreateStringDecimalFromNumber;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.StringToNumberArray;
import static com.martinfjohansen.oneaccounting.pPolynomials.Polynomials.Polynomials.pEvaluate;
import static com.martinfjohansen.oneaccounting.references.references.references.FreeStringReferenceArray;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.*;
import static java.lang.Math.*;

public class Matrices{
	public static void Add(Matrix a, Matrix b){
		double m, n;
		double r, c;

		r = NumberOfRows(a);
		c = NumberOfColumns(a);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = Element(a, m, n) + Element(b, m, n);
			}
		}
	}

	public static void Assign(Matrix A, Matrix B){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = Element(B, m, n);
			}
		}
	}

	public static void Resize(Matrix A, double r, double c){
		double m, n, ar, ac;
		Matrix C;

		C = CreateMatrix(r, c);

		ar = NumberOfRows(A);
		ac = NumberOfColumns(A);

		for(m = 0d; m < min(r, ar); m = m + 1d){
			for(n = 0d; n < min(c, ac); n = n + 1d){
				C.r[(int)(m)].c[(int)(n)] = Element(A, m, n);
			}
		}

		FreeMatrixRows(A.r);
		A.r = C.r;
	}

	public static void Subtract(Matrix a, Matrix b){
		double m, n;
		double r, c;

		r = NumberOfRows(a);
		c = NumberOfColumns(a);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = Element(a, m, n) - Element(b, m, n);
			}
		}
	}

	public static Matrix SubtractToNew(Matrix a, Matrix b){
		Matrix X;

		X = CreateCopyOfMatrix(a);
		Subtract(X, b);

		return X;
	}

	public static void ScalarMultiply(Matrix A, double b){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = b*A.r[(int)(m)].c[(int)(n)];
			}
		}
	}

	public static void ScalarDivide(Matrix A, double b){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);
		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = Element(A, m, n)/b;
			}
		}
	}

	public static void ElementWisePower(Matrix A, double p){
		double m, n;
		double r, c;

		r = NumberOfRows(A);
		c = NumberOfColumns(A);

		for(m = 0d; m < r; m = m + 1d){
			for(n = 0d; n < c; n = n + 1d){
				A.r[(int)(m)].c[(int)(n)] = pow(A.r[(int)(m)].c[(int)(n)], p);
			}
		}
	}

	public static Matrix ScalarMultiplyToNew(Matrix A, double b){
		Matrix matrix;

		matrix = CreateCopyOfMatrix(A);
		ScalarMultiply(matrix, b);

		return matrix;
	}

	public static Matrix MultiplyToNew(Matrix a, Matrix b){
		double rows, cols;
		Matrix x;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(b);
		x = CreateMatrix(rows, cols);
		Multiply(x, a, b);

		return x;
	}

	public static void Multiply(Matrix x, Matrix a, Matrix b){
		double m, n;
		double rows, cols, d;
		double i, s;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(b);
		d = NumberOfColumns(a);

		for(m = 0d; m < rows; m = m + 1d){
			for(n = 0d; n < cols; n = n + 1d){
				s = 0d;

				for(i = 0d; i < d; i = i + 1d){
					s = s + a.r[(int)(m)].c[(int)(i)]*b.r[(int)(i)].c[(int)(n)];
				}

				x.r[(int)(m)].c[(int)(n)] = s;
			}
		}
	}

	public static Matrix CreateSquareMatrix(double d){
		double m, n;
		Matrix matrix;

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(d)];
		for(m = 0d; m < d; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(d)];
			for(n = 0d; n < d; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = 0d;
			}
		}

		return matrix;
	}

	public static Matrix CreateMatrix(double rows, double cols){
		double m, n;
		Matrix matrix;

		matrix = new Matrix();
		matrix.r = new MatrixRow [(int)(rows)];
		for(m = 0d; m < rows; m = m + 1d){
			matrix.r[(int)(m)] = new MatrixRow();
			matrix.r[(int)(m)].c = new double [(int)(cols)];
			for(n = 0d; n < cols; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = 0d;
			}
		}

		return matrix;
	}

	public static Matrix CreateIdentityMatrix(double d){
		double m;
		Matrix matrix;

		matrix = CreateSquareMatrix(d);
		Fill(matrix, 0d);

		for(m = 0d; m < d; m = m + 1d){
			matrix.r[(int)(m)].c[(int)(m)] = 1d;
		}

		return matrix;
	}

	public static void Transpose(Matrix a){
		Matrix ap;

		ap = TransposeToNew(a);

		FreeMatrixRows(a.r);
		a.r = ap.r;
	}

	public static void TransposeAssign(Matrix t, Matrix a){
		double m, n;
		double rows, cols;

		cols = NumberOfRows(a);
		rows = NumberOfColumns(a);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				t.r[(int)(n)].c[(int)(m)] = a.r[(int)(m)].c[(int)(n)];
			}
		}
	}

	public static Matrix TransposeToNew(Matrix a){
		double m, n;
		double rows, cols;
		Matrix c;

		cols = NumberOfRows(a);
		rows = NumberOfColumns(a);

		c = CreateMatrix(rows, cols);

		for(m = 0d; m < cols; m = m + 1d){
			for(n = 0d; n < rows; n = n + 1d){
				c.r[(int)(n)].c[(int)(m)] = a.r[(int)(m)].c[(int)(n)];
			}
		}

		return c;
	}

	public static void CofactorOfMatrix(Matrix mat, Matrix temp, double p, double q, double n){
		double i, j;
		double row, col;

		i = 0d;
		j = 0d;

		for(row = 0d; row < n; row = row + 1d){
			for(col = 0d; col < n; col = col + 1d){
				if(row != p && col != q){
					temp.r[(int)(i)].c[(int)(j)] = mat.r[(int)(row)].c[(int)(col)];
					j = j + 1d;

					if(j == n - 1d){
						j = 0d;
						i = i + 1d;
					}
				}
			}
		}
	}

	public static double DeterminantOfSubmatrix(Matrix mat, double n){
		double D, f, sign;
		Matrix temp;

		D = 0d;

		if(n == 1d){
			D = mat.r[0].c[0];
		}else{
			temp = CreateSquareMatrix(n);

			sign = 1d;

			for(f = 0d; f < n; f = f + 1d){
				CofactorOfMatrix(mat, temp, 0d, f, n);
				D = D + sign*mat.r[0].c[(int)(f)]*DeterminantOfSubmatrix(temp, n - 1d);
				sign = -sign;
			}

			FreeMatrix(temp);
		}

		return D;
	}

	public static double Determinant(Matrix m){
		double D, n;

		n = NumberOfRows(m);
		D = DeterminantOfSubmatrix(m, n);

		return D;
	}

	public static void Adjoint(Matrix A, Matrix adj){
		double n, sign;
		Matrix cofactors;
		double i, j;

		n = A.r.length;

		if(n == 1d){
			adj.r[0].c[0] = 1d;
		}else{
			cofactors = CreateSquareMatrix(n);

			for(i = 0d; i < n; i = i + 1d){
				for(j = 0d; j < n; j = j + 1d){
					CofactorOfMatrix(A, cofactors, i, j, n);

					if((i + j)%2d == 0d){
						sign = 1d;
					}else{
						sign = -1d;
					}

					adj.r[(int)(j)].c[(int)(i)] = sign*DeterminantOfSubmatrix(cofactors, n - 1d);
				}
			}

			FreeMatrix(cofactors);
		}
	}

	public static boolean Inverse(Matrix A, Matrix inverseResult){
		return InverseUsingLUDecomposition(A, inverseResult);
	}

	public static boolean InverseUsingAdjoint(Matrix A, Matrix inverseResult){
		boolean success;
		Matrix adj;
		double n, i, j;
		double det;

		if(NumberOfColumns(A) == NumberOfRows(A)){
			n = NumberOfColumns(A);

			det = Determinant(A);
			if(det != 0d){
				adj = CreateSquareMatrix(n);
				Adjoint(A, adj);

				for(i = 0d; i < n; i = i + 1d){
					for(j = 0d; j < n; j = j + 1d){
						inverseResult.r[(int)(i)].c[(int)(j)] = adj.r[(int)(i)].c[(int)(j)]/det;
					}
				}

				success = true;
				FreeMatrix(adj);
			}else{
				success = false;
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean InverseUsingLUDecomposition(Matrix A, Matrix inverseResult){
		boolean success;
		Matrix l, u, li, ui;

		l = CreateCopyOfMatrix(A);
		u = CreateCopyOfMatrix(A);
		li = CreateCopyOfMatrix(A);
		ui = CreateCopyOfMatrix(A);
		inverseResult.r = CreateCopyOfMatrix(A).r;

		success = LUDecomposition(A, l, u);
		if(success){
			success = InvertLowerTriangularMatrix(l, li);
			if(success){
				success = InvertUpperTriangularMatrix(u, ui);
				if(success){
					Multiply(inverseResult, ui, li);
				}
			}
		}

		FreeMatrix(l);
		FreeMatrix(u);
		FreeMatrix(li);
		FreeMatrix(ui);

		return success;
	}

	public static boolean LUDecomposition(Matrix A, Matrix L, Matrix U){
		double n, i, j, k, sum;
		boolean success;

		n = NumberOfRows(A);

		L.r = CreateSquareMatrix(n).r;
		U.r = CreateSquareMatrix(n).r;

		if(IsSquare(A)){
			success = true;

			for(i = 0d; i < n && success; i = i + 1d){
				for(k = i; k < n; k = k + 1d){
					sum = 0d;
					for(j = 0d; j < i; j = j + 1d){
						sum = sum + (Element(L, i, j)*Element(U, j, k));
					}

					U.r[(int)(i)].c[(int)(k)] = Element(A, i, k) - sum;
				}

				for(k = i; k < n && success; k = k + 1d){
					if(i == k){
						L.r[(int)(i)].c[(int)(i)] = 1d;
					}else{
						sum = 0d;
						for(j = 0d; j < i; j = j + 1d){
							sum = sum + (Element(L, k, j)*Element(U, j, i));
						}

						if(Element(U, i, i) == 0d){
							success = false;
						}else{
							L.r[(int)(k)].c[(int)(i)] = (Element(A, k, i) - sum)/Element(U, i, i);
						}
					}
				}
			}
		}else{
			success = false;
		}

		return success;
	}

	public static boolean IsSymmetric(Matrix A){
		double N;
		double i, j;
		boolean is, done;

		N = NumberOfRows(A);

		done = false;
		is = true;
		for(i = 0d; i < N && !done; i = i + 1d){
			for(j = 0d; j < i && !done; j = j + 1d){
				if(A.r[(int)(i)].c[(int)(j)] != A.r[(int)(j)].c[(int)(i)]){
					is = false;
					done = true;
				}
			}
		}

		return is;
	}

	public static boolean IsSquare(Matrix A){
		boolean is;

		if(NumberOfRows(A) == NumberOfColumns(A)){
			is = true;
		}else{
			is = false;
		}

		return is;
	}

	public static boolean Cholesky(Matrix A, Matrix L){
		boolean success;
		double N;
		double i, j, k, s;

		Clear(L);

		if(IsSquare(A) && IsSymmetric(A)){
			success = true;

			N = NumberOfRows(A);

			for(i = 0d; i < N && success; i = i + 1d){
				for(j = 0d; j <= i && success; j = j + 1d){
					s = 0d;
					for(k = 0d; k < j; k = k + 1d){
						s = s + L.r[(int)(i)].c[(int)(k)]*L.r[(int)(j)].c[(int)(k)];
					}
					if(i == j){
						L.r[(int)(i)].c[(int)(i)] = sqrt(A.r[(int)(i)].c[(int)(i)] - s);
					}else{
						L.r[(int)(i)].c[(int)(j)] = 1d/L.r[(int)(j)].c[(int)(j)]*(A.r[(int)(i)].c[(int)(j)] - s);
					}
				}
				if(L.r[(int)(i)].c[(int)(i)] <= 0d){
					success = false;
				}
			}

			success = true;
		}else{
			success = false;
		}

		return success;
	}

	public static void Clear(Matrix a){
		Fill(a, 0d);
	}

	public static void Fill(Matrix a, double value){
		double m, n;

		for(m = 0d; m < NumberOfRows(a); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(a); n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = value;
			}
		}
	}

	public static double Element(Matrix matrix, double m, double n){
		return matrix.r[(int)(m)].c[(int)(n)];
	}

	public static double Trace(Matrix a){
		double m;
		double d, tr;

		tr = 0d;

		d = a.r.length;
		for(m = 0d; m < d; m = m + 1d){
			tr = tr + a.r[(int)(m)].c[(int)(m)];
		}

		return tr;
	}

	public static Matrix ColumnCombineMatricesToNew(Matrix A, Matrix B){
		Matrix X;
		double m, n;

		X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A) + NumberOfColumns(B));

		for(m = 0d; m < NumberOfRows(A); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(A); n = n + 1d){
				X.r[(int)(m)].c[(int)(n)] = A.r[(int)(m)].c[(int)(n)];
			}
		}

		for(m = 0d; m < NumberOfRows(B); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(B); n = n + 1d){
				X.r[(int)(m)].c[(int)(NumberOfColumns(A) + n)] = B.r[(int)(m)].c[(int)(n)];
			}
		}

		return X;
	}

	public static double NumberOfRows(Matrix A){
		return A.r.length;
	}

	public static double NumberOfColumns(Matrix A){
		return A.r[0].c.length;
	}

	public static double [] CharacteristicPolynomial(Matrix A){
		Matrix dummy;
		NumberArrayReference coeffs;
		NumberReference determinant;

		dummy = CreateSquareMatrix(NumberOfRows(A));

		coeffs = new NumberArrayReference();
		determinant = new NumberReference();
		CharacteristicPolynomialWithInverse(A, dummy, coeffs, determinant);

		FreeMatrix(dummy);

		return coeffs.numberArray;
	}

	public static void CharacteristicPolynomialWithInverse(Matrix A, Matrix AInverse, NumberArrayReference cp, NumberReference determinant){
		FaddeevLeVerrierAlgorithm(A, AInverse, cp, determinant);
	}

	public static void FaddeevLeVerrierAlgorithm(Matrix A, Matrix AInverse, NumberArrayReference cp, NumberReference determinant){
		double [] p;
		Matrix Mk, Mkm1, t1, I;
		double n, k;

		n = NumberOfRows(A);
		p = new double [(int)(n + 1d)];
		p[(int)(n)] = 1d;
		Mkm1 = CreateSquareMatrix(n);
		Fill(Mkm1, 0d);
		I = CreateIdentityMatrix(n);
		Mk = CreateSquareMatrix(n);
		t1 = CreateSquareMatrix(n);

		for(k = 1d; k <= n; k = k + 1d){
			/* M_k = A * M_(k-1) + c_(n-k+1) * I*/
			Multiply(Mk, A, Mkm1);
			Assign(t1, I);
			ScalarMultiply(t1, p[(int)(n - k + 1d)]);
			Add(Mk, t1);

			/* c_(n-k) = -1/k * trace(A * M_k)*/
			Multiply(t1, A, Mk);
			p[(int)(n - k)] = -1d/k*Trace(t1);

			/* done*/
			Assign(Mkm1, Mk);

			if(k == n){
				Assign(AInverse, Mk);
				determinant.numberValue = -p[0];
				if(p[0] == 0d){
				}else{
					ScalarDivide(AInverse, determinant.numberValue);
				}
			}
		}

		FreeMatrix(Mkm1);
		FreeMatrix(I);
		FreeMatrix(Mk);
		FreeMatrix(t1);

		cp.numberArray = p;
	}

	public static Matrix InverseUsingCharacteristicPolynomial(Matrix A){
		Matrix inverse;
		NumberArrayReference coeffs;
		NumberReference determinant;

		inverse = CreateSquareMatrix(NumberOfRows(A));
		coeffs = new NumberArrayReference();
		determinant = new NumberReference();
		CharacteristicPolynomialWithInverse(A, inverse, coeffs, determinant);
		delete(coeffs.numberArray);
		delete(coeffs);

		return inverse;
	}

	public static boolean Eigenvalues(Matrix A, NumberArrayReference eigenValuesReference){
		MatrixArrayReference eigenVectorsReference;
		boolean success;
		double i;

		eigenVectorsReference = new MatrixArrayReference();
		success = Eigenpairs(A, eigenValuesReference, eigenVectorsReference);
		if(success){
			for(i = 0d; i < eigenVectorsReference.matrices.length; i = i + 1d){
				FreeMatrix(eigenVectorsReference.matrices[(int)(i)]);
			}
			delete(eigenVectorsReference.matrices);
			delete(eigenVectorsReference);
		}

		return success;
	}

	public static boolean EigenvaluesUsingQRAlgorithm(Matrix A, NumberArrayReference eigenValuesReference, double precision, double maxIterations){
		Matrix x, q, r;
		boolean success;
		double i, n, v, v1, v2, ev, found;
		double [] cp;

		n = NumberOfRows(A);
		x = CreateSquareMatrix(n);
		q = CreateSquareMatrix(n);
		r = CreateSquareMatrix(n);
		eigenValuesReference.numberArray = new double [(int)(n)];
		success = QRAlgorithm(A, r, x, q, precision, maxIterations);
		found = 0d;
		if(success){
			ExtractDiagonal(x, eigenValuesReference.numberArray);

			/* find the correct sign of the eigenvalue.*/
			cp = CharacteristicPolynomial(A);
			for(i = 0d; i < n; i = i + 1d){
				ev = eigenValuesReference.numberArray[(int)(i)];

				v1 = pEvaluate(cp, ev);
				v2 = pEvaluate(cp, -ev);

				if(abs(v2) < abs(v1)){
					eigenValuesReference.numberArray[(int)(i)] = -ev;
					v = v2;
				}else{
					v = v1;
				}

				if(abs(v) < precision*pow(10d, 4d)){
					found = found + 1d;
				}
			}

			FreeMatrix(x);
			FreeMatrix(q);
			FreeMatrix(r);
		}

		if(found != n){
			success = false;
		}

		return success;
	}

	public static boolean EigenvaluesUsingLaguerreIterations(Matrix A, NumberArrayReference eigenValuesReference){
		double [] p;
		boolean success;

		p = CharacteristicPolynomial(A);
		success = FindRoots(p, eigenValuesReference);

		return success;
	}

	public static void GaussianElimination(Matrix A){
		double h, k, m, n, maxElement, i, j, max, maxCandidate, f;

		m = NumberOfRows(A);
		n = NumberOfColumns(A);

		h = 0d;
		k = 0d;
		for(; h < m && k < n; ){
			maxElement = h;
			max = 0d;
			for(i = h; i < m; i = i + 1d){
				maxCandidate = abs(Element(A, i, k));
				if(max < maxCandidate){
					maxElement = i;
					max = maxCandidate;
				}
			}
			if(A.r[(int)(maxElement)].c[(int)(k)] == 0d){
				k = k + 1d;
			}else{
				SwapRows(A, h, maxElement);
				for(i = h + 1d; i < m; i = i + 1d){
					f = Element(A, i, k)/Element(A, h, k);
					A.r[(int)(i)].c[(int)(k)] = 0d;
					for(j = k + 1d; j < n; j = j + 1d){
						A.r[(int)(i)].c[(int)(j)] = Element(A, i, j) - Element(A, h, j)*f;
					}
				}
				h = h + 1d;
				k = k + 1d;
			}
		}
	}

	public static Matrix GaussianEliminationToNew(Matrix A){
		Matrix X;

		X = CreateCopyOfMatrix(A);
		GaussianElimination(X);

		return X;
	}

	public static Matrix CreateCopyOfMatrix(Matrix A){
		Matrix X;

		X = CreateMatrix(NumberOfRows(A), NumberOfColumns(A));
		Assign(X, A);

		return X;
	}

	public static void SwapRows(Matrix A, double to, double from){
		double n;
		double c, t;

		c = NumberOfRows(A);
		for(n = 0d; n < c; n = n + 1d){
			t = A.r[(int)(to)].c[(int)(n)];
			A.r[(int)(to)].c[(int)(n)] = A.r[(int)(from)].c[(int)(n)];
			A.r[(int)(from)].c[(int)(n)] = t;
		}
	}

	public static void UnnormalizeVector(double [] numberArray){
		double i, m;
		boolean mSet;

		mSet = false;
		m = 0d;

		for(i = 0d; i < numberArray.length; i = i + 1d){
			if(numberArray[(int)(i)] - Truncate(numberArray[(int)(i)]) < 0.001){
				if(!mSet){
					m = abs(numberArray[(int)(i)]);
					mSet = true;
				}else{
					m = min(m, abs(numberArray[(int)(i)]));
				}
			}
		}

		if(mSet){
			for(i = 0d; i < numberArray.length; i = i + 1d){
				numberArray[(int)(i)] = numberArray[(int)(i)]/m;
			}
		}
	}

	public static boolean InversePowerMethod(Matrix A, double eigenvalue, double maxIterations, NumberArrayReference eigenvector){
		Matrix x, y, z, b, t;
		double n, i, c;
		boolean singular;

		n = NumberOfRows(A);

		x = CreateIdentityMatrix(n);
		ScalarMultiply(x, eigenvalue);
		y = SubtractToNew(A, x);
		z = CreateSquareMatrix(n);
		singular = !Inverse(y, z);
		if(singular){
			/* Try again with more erroneous eigenvalue estimate.*/
			x = CreateIdentityMatrix(n);
			ScalarMultiply(x, eigenvalue*1.01);
			y = SubtractToNew(A, x);
			z = CreateSquareMatrix(n);
			singular = !Inverse(y, z);
		}

		if(!singular){
			b = CreateMatrix(n, 1d);

			for(i = 0d; i < n; i = i + 1d){
				b.r[(int)(i)].c[0] = 1d;
			}

			for(i = 0d; i < maxIterations; i = i + 1d){
				t = MultiplyToNew(z, b);
				c = Norm(t);
				ScalarDivide(t, c);
				Assign(b, t);
			}

			eigenvector.numberArray = new double [(int)(n)];
			for(i = 0d; i < n; i = i + 1d){
				eigenvector.numberArray[(int)(i)] = b.r[(int)(i)].c[0];
			}
		}

		return !singular;
	}

	public static boolean Eigenvectors(Matrix A, MatrixArrayReference eigenVectorsReference){
		NumberArrayReference evsReference;
		boolean success;

		evsReference = new NumberArrayReference();
		success = Eigenpairs(A, evsReference, eigenVectorsReference);
		if(success){
			delete(evsReference.numberArray);
			delete(evsReference);
		}

		return success;
	}

	public static boolean Eigenpairs(Matrix A, NumberArrayReference eigenValuesReference, MatrixArrayReference eigenVectorsReference){
		return EigenpairsUsingQRAlgorithmAndInversePowerMethod(A, eigenValuesReference, eigenVectorsReference, 0.00000000001, 100d);
	}

	public static boolean EigenpairsUsingQRAlgorithmAndInversePowerMethod(Matrix M, NumberArrayReference eigenValuesReference, MatrixArrayReference eigenVectorsReference, double precision, double maxIterations){
		NumberArrayReference evecReference;
		boolean done, inverseSuccess;
		double i, j, k, N, v1, v2, eigenValue, withinPrecision;
		Matrix A, Q, R, eigenVector;
		double [] cp;

		N = NumberOfRows(M);

		A = CreateCopyOfMatrix(M);
		Q = CreateCopyOfMatrix(M);
		R = CreateCopyOfMatrix(M);

		done = false;
		eigenVectorsReference.matrices = new Matrix [(int)(N)];
		evecReference = new NumberArrayReference();
		eigenValuesReference.numberArray = new double [(int)(N)];
		cp = CharacteristicPolynomial(M);

		for(j = 0d; j < N; j = j + 1d){
			eigenVectorsReference.matrices[(int)(j)] = CreateMatrix(N, 1d);
		}

		for(i = 0d; i < maxIterations && !done; i = i + 1d){
			QRDecomposition(A, Q, R);
			Multiply(A, R, Q);

			/* Check*/
			withinPrecision = 0d;
			ExtractDiagonal(R, eigenValuesReference.numberArray);

			for(j = 0d; j < N; j = j + 1d){
				/* Find the correct sign of the eigenvalue.*/
				eigenValue = eigenValuesReference.numberArray[(int)(j)];
				v1 = pEvaluate(cp, eigenValue);
				v2 = pEvaluate(cp, -eigenValue);
				if(abs(v2) < abs(v1)){
					eigenValuesReference.numberArray[(int)(j)] = -eigenValue;
					eigenValue = -eigenValue;
				}

				/* Calculate the eigenvector corresponding to the eigenvalue.*/
				inverseSuccess = InversePowerMethod(M, eigenValue, i + 1d, evecReference);
				if(inverseSuccess){
					for(k = 0d; k < N; k = k + 1d){
						eigenVectorsReference.matrices[(int)(j)].r[(int)(k)].c[0] = evecReference.numberArray[(int)(k)];
					}

					/* Check eigenpair agains precision.*/
					eigenVector = eigenVectorsReference.matrices[(int)(j)];

					if(CheckEigenpairPrecision(M, eigenValue, eigenVector, precision)){
						withinPrecision = withinPrecision + 1d;
					}
				}
			}

			if(withinPrecision == N){
				done = true;
			}
		}

		FreeMatrix(A);
		FreeMatrix(Q);
		FreeMatrix(R);
		delete(evecReference);
		delete(cp);

		return done;
	}

	public static boolean CheckEigenpairPrecision(Matrix a, double lambda, Matrix e, double precision){
		Matrix vec1, vec2;
		boolean equal;

		vec1 = MultiplyToNew(a, e);
		vec2 = ScalarMultiplyToNew(e, lambda);

		equal = MatrixEqualsEpsilon(vec1, vec2, precision);

		return equal;
	}

	public static boolean EigenvectorsLaguerreIterationsAndGaussianEliminations(Matrix A, MatrixArrayReference eigenVectorsReference){
		Matrix Id, t1, B, v;
		Matrix [] eigenVectorsResult;
		boolean success;
		NumberArrayReference eigenValuesReference;
		double i, lambda, j, N, x, k;
		double [] ev;

		N = NumberOfRows(A);

		eigenValuesReference = new NumberArrayReference();
		success = Eigenvalues(A, eigenValuesReference);

		eigenVectorsResult = new Matrix [(int)(N)];

		if(success){
			ev = eigenValuesReference.numberArray;

			Id = CreateIdentityMatrix(N);
			t1 = CreateSquareMatrix(N);
			B = CreateSquareMatrix(N);

			for(j = 0d; j < ev.length && success; j = j + 1d){
				lambda = ev[(int)(j)];

				/* B = A - lambda * Id*/
				Assign(t1, Id);
				ScalarMultiply(t1, lambda);

				Assign(B, A);
				Subtract(B, t1);

				GaussianElimination(B);

				v = CreateMatrix(N, 1d);
				v.r[(int)(N - 1d)].c[0] = 1d;
				for(i = N - 2d; i >= 0d && success; i = i - 1d){
					if(!RowIsZero(B, i)){
						x = 0d;

						for(k = N - 1d; k > i; k = k - 1d){
							x = x - Element(B, i, k)*Element(v, k, 0d);
						}

						v.r[(int)(i)].c[0] = x/Element(B, i, i);
					}else{
						success = false;
					}
				}

				eigenVectorsResult[(int)(j)] = v;
			}

			FreeMatrix(t1);
			FreeMatrix(B);
			FreeMatrix(Id);

			eigenVectorsReference.matrices = eigenVectorsResult;
		}

		return success;
	}

	public static boolean RowIsZero(Matrix X, double r){
		boolean isZero;
		double columns, i;

		isZero = true;

		columns = NumberOfColumns(X);
		for(i = 0d; i < columns && isZero; i = i + 1d){
			if(Element(X, r, i) != 0d){
				isZero = false;
			}
		}

		return isZero;
	}

	public static void FreeMatrix(Matrix X){
		FreeMatrixRows(X.r);
		delete(X);
	}

	public static void FreeMatrixRows(MatrixRow [] r){
		double m, rows;

		rows = r.length;
		for(m = 0d; m < rows; m = m + 1d){
			delete(r[(int)(m)].c);
			delete(r[(int)(m)]);
		}

		delete(r);
	}

	public static Matrix CreateDiagonalMatrixFromArray(double [] array){
		double m;
		Matrix matrix;

		matrix = CreateSquareMatrix(array.length);
		Fill(matrix, 0d);

		for(m = 0d; m < array.length; m = m + 1d){
			matrix.r[(int)(m)].c[(int)(m)] = array[(int)(m)];
		}

		return matrix;
	}

	public static Matrix CreateMatrixFromRowCopies(double [] row, double times){
		double m, n;
		Matrix matrix;

		matrix = CreateMatrix(times, row.length);

		for(m = 0d; m < times; m = m + 1d){
			for(n = 0d; n < row.length; n = n + 1d){
				matrix.r[(int)(m)].c[(int)(n)] = row[(int)(n)];
			}
		}

		return matrix;
	}

	public static void ExtractDiagonal(Matrix X, double [] diag){
		double n, i;

		n = NumberOfRows(X);

		for(i = 0d; i < n; i = i + 1d){
			diag[(int)(i)] = X.r[(int)(i)].c[(int)(i)];
		}
	}

	public static double [] ExtractDiagonalToNew(Matrix X){
		double [] diag;
		double n, i;

		n = NumberOfRows(X);
		diag = new double [(int)(n)];

		for(i = 0d; i < n; i = i + 1d){
			diag[(int)(i)] = X.r[(int)(i)].c[(int)(i)];
		}

		return diag;
	}

	public static boolean MatrixEqualsEpsilon(Matrix a, Matrix b, double epsilon){
		double x, y, columns, rows;
		boolean equals;

		equals = true;

		if(NumberOfRows(a) == NumberOfRows(b) && NumberOfColumns(a) == NumberOfColumns(b)){
			columns = NumberOfColumns(a);
			rows = NumberOfRows(a);

			for(x = 0d; x < rows; x = x + 1d){
				for(y = 0d; y < columns; y = y + 1d){
					equals = equals && EpsilonCompare(Element(a, x, y), Element(b, x, y), epsilon);
				}
			}
		}else{
			equals = false;
		}

		return equals;
	}

	public static Matrix Minor(Matrix x, double row, double column){
		Matrix theMinor;
		double cols, rows, i, j, m, n;

		rows = NumberOfRows(x) - 1d;
		cols = NumberOfColumns(x) - 1d;

		theMinor = CreateMatrix(rows, cols);

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

					theMinor.r[(int)(m)].c[(int)(n)] = x.r[(int)(i)].c[(int)(j)];
				}
			}
		}

		return theMinor;
	}

	public static void QRDecomposition(Matrix m, Matrix Q, Matrix R){
		HouseholderMethod(m, Q, R);
	}

	public static void HouseholderTriangularizationAlgorithm(Matrix m, Matrix Qout, Matrix Rout){
		Matrix P, AA, A, PP, v, vt, t;
		double i, j, rows, cols, r, s;

		rows = NumberOfRows(m);
		cols = NumberOfColumns(m);

		P = CreateIdentityMatrix(rows);
		A = CreateCopyOfMatrix(m);
		AA = CreateMatrix(rows, cols);

		t = CreateMatrix(rows, cols);
		PP = CreateIdentityMatrix(rows);
		vt = CreateMatrix(1d, rows);

		for(j = 0d; j < cols; j = j + 1d){
			v = ExtractSubMatrix(A, 0d, rows - 1d, j, j);
			if(j > 0d){
				for(i = 0d; i < j; i = i + 1d){
					v.r[(int)(i)].c[0] = 0d;
				}
			}

			s = Sign(v.r[(int)(j)].c[0]);
			if(s == 0d){
				s = 1d;
			}
			v.r[(int)(j)].c[0] = v.r[(int)(j)].c[0] + Norm(v)*s;
			r = -2d/(Norm(v)*Norm(v));
			Assign(AA, A);

			TransposeAssign(vt, v);
			Multiply(t, vt, A);
			Assign(A, t);
			Multiply(t, v, A);
			Assign(A, t);
			ScalarMultiply(A, r);
			Assign(t, AA);
			Add(A, AA);

			Assign(PP, P);

			Multiply(t, vt, P);
			Assign(P, t);
			Multiply(t, v, P);
			Assign(P, t);
			ScalarMultiply(P, r);
			Assign(t, AA);
			Add(P, PP);
		}

		Assign(Rout, A);
		Assign(Qout, P);
		Transpose(Qout);
	}

	public static void HouseholderMethod(Matrix A, Matrix q, Matrix r){
		Matrix QR, R, Q;
		double [] Rdiag;
		double m, n;
		double i, j, k;
		double s, nrm;
		double e;
		Matrix N, ra, rq;

		/* Initialize.*/
		QR = CreateCopyOfMatrix(A);
		m = NumberOfRows(A);
		n = NumberOfColumns(A);
		Rdiag = new double [(int)(n)];

		/* Main loop.*/
		for(k = 0d; k < n; k = k + 1d){
			/* Compute 2-norm of k-th column without under/overflow.*/
			nrm = 0d;
			for(i = k; i < m; i = i + 1d){
				nrm = Hypothenuse(nrm, Element(QR, i, k));
			}

			if(nrm != 0d){
				/* Form k-th Householder vector.*/
				if(Element(QR, k, k) < 0d){
					nrm = -nrm;
				}
				for(i = k; i < m; i = i + 1d){
					QR.r[(int)(i)].c[(int)(k)] = Element(QR, i, k)/nrm;
				}
				QR.r[(int)(k)].c[(int)(k)] = Element(QR, k, k) + 1d;

				/* Apply transformation to remaining columns.*/
				for(j = k + 1d; j < n; j = j + 1d){
					s = 0d;
					for(i = k; i < m; i = i + 1d){
						s = s + Element(QR, i, k)*Element(QR, i, j);
					}
					s = -s/Element(QR, k, k);
					for(i = k; i < m; i = i + 1d){
						QR.r[(int)(i)].c[(int)(j)] = Element(QR, i, j) + s*Element(QR, i, k);
					}
				}
			}
			Rdiag[(int)(k)] = -nrm;
		}

		/* Compute R*/
		R = CreateSquareMatrix(n);
		for(i = 0d; i < n; i = i + 1d){
			for(j = 0d; j < n; j = j + 1d){
				if(i < j){
					R.r[(int)(i)].c[(int)(j)] = Element(QR, i, j);
				}else if(i == j){
					R.r[(int)(i)].c[(int)(j)] = Rdiag[(int)(i)];
				}else{
					R.r[(int)(i)].c[(int)(j)] = 0d;
				}
			}
		}
		Assign(r, R);

		/* Compute Q*/
		Q = CreateMatrix(m, n);
		for(k = n - 1d; k >= 0d; k = k - 1d){
			for(i = 0d; i < m; i = i + 1d){
				Q.r[(int)(i)].c[(int)(k)] = 0d;
			}
			Q.r[(int)(k)].c[(int)(k)] = 1d;
			for(j = k; j < n; j = j + 1d){
				if(Element(QR, k, k) != 0d){
					s = 0d;
					for(i = k; i < m; i = i + 1d){
						s = s + Element(QR, i, k)*Element(Q, i, j);
					}
					s = -s/Element(QR, k, k);
					for(i = k; i < m; i = i + 1d){
						Q.r[(int)(i)].c[(int)(j)] = Element(Q, i, j) + s*Element(QR, i, k);
					}
				}
			}
		}
		Assign(q, Q);

		/* Adjust for positive R.*/
		n = NumberOfRows(r);

		N = CreateIdentityMatrix(n);

		for(i = 0d; i < n; i = i + 1d){
			e = Element(r, i, i);

			if(e < 0d){
				N.r[(int)(i)].c[(int)(i)] = -1d;
			}
		}

		ra = MultiplyToNew(N, r);
		Assign(r, ra);
		rq = MultiplyToNew(q, N);
		Assign(q, rq);

		FreeMatrix(ra);
		FreeMatrix(rq);
		FreeMatrix(Q);
		FreeMatrix(R);
		FreeMatrix(QR);
	}

	public static double Hypothenuse(double a, double b){
		return sqrt(pow(a, 2d) + pow(b, 2d));
	}

	public static double Norm(Matrix a){
		double l, i, j, rows, cols;

		l = 0d;

		rows = NumberOfRows(a);
		cols = NumberOfColumns(a);

		for(i = 0d; i < rows; i = i + 1d){
			for(j = 0d; j < cols; j = j + 1d){
				l = l + a.r[(int)(i)].c[(int)(j)]*a.r[(int)(i)].c[(int)(j)];
			}
		}
		l = sqrt(l);

		return l;
	}

	public static Matrix ExtractSubMatrix(Matrix M, double r1, double r2, double c1, double c2){
		Matrix A;
		double i, j;

		A = CreateMatrix(r2 - r1 + 1d, c2 - c1 + 1d);

		for(i = r1; i <= r2; i = i + 1d){
			for(j = c1; j <= c2; j = j + 1d){
				A.r[(int)(i - r1)].c[(int)(j - c1)] = M.r[(int)(i)].c[(int)(j)];
			}
		}

		return A;
	}

	public static boolean QRAlgorithm(Matrix M, Matrix R, Matrix A, Matrix Q, double precision, double maxIterations){
		double n, i, j, v;
		double [] previous;
		double withinPrecision;
		boolean done, previousSet;

		Assign(A, M);
		n = NumberOfRows(M);
		previous = new double [(int)(n)];
		previousSet = false;

		done = false;
		for(i = 0d; i < maxIterations && !done; i = i + 1d){
			QRDecomposition(A, Q, R);
			Multiply(A, R, Q);

			/* Check precision.*/
			if(previousSet){
				withinPrecision = 0d;
				for(j = 0d; j < n; j = j + 1d){
					v = previous[(int)(j)] - Element(A, j, j);
					if(abs(v) < precision || v == 0d){
						withinPrecision = withinPrecision + 1d;
					}
				}
				if(withinPrecision == n){
					done = true;
				}
			}

			for(j = 0d; j < n; j = j + 1d){
				previous[(int)(j)] = Element(A, j, j);
			}
			previousSet = true;
		}

		return done;
	}

	public static boolean InvertUpperTriangularMatrix(Matrix A, Matrix inverse){
		double sum, i, j, k, n;
		boolean success;

		inverse.r = CreateCopyOfMatrix(A).r;
		n = NumberOfRows(inverse);
		success = true;

		for(i = n - 1d; i >= 0d && success; i = i - 1d){
			if(Element(inverse, i, i) == 0d){
				success = false;
			}else{
				inverse.r[(int)(i)].c[(int)(i)] = 1d/Element(inverse, i, i);
				for(j = i - 1d; j >= 0d && success; j = j - 1d){
					sum = 0d;
					for(k = i; k > j; k = k - 1d){
						sum = sum - Element(inverse, j, k)*Element(inverse, k, i);
					}
					if(Element(inverse, j, j) == 0d){
						success = false;
					}else{
						inverse.r[(int)(j)].c[(int)(i)] = sum/Element(inverse, j, j);
					}
				}
			}
		}

		return success;
	}

	public static boolean InvertLowerTriangularMatrix(Matrix A, Matrix inverse){
		double sum, i, j, k, n;
		boolean success;

		inverse.r = CreateCopyOfMatrix(A).r;
		n = NumberOfRows(inverse);
		success = true;

		for(i = 0d; i < n && success; i = i + 1d){
			if(Element(inverse, i, i) == 0d){
				success = false;
			}else{
				inverse.r[(int)(i)].c[(int)(i)] = 1d/Element(inverse, i, i);
				for(j = i + 1d; j < n; j = j + 1d){
					sum = 0d;
					for(k = i; k < j && success; k = k + 1d){
						sum = sum - Element(inverse, j, k)*Element(inverse, k, i);
					}
					if(Element(inverse, j, j) == 0d){
						success = false;
					}else{
						inverse.r[(int)(j)].c[(int)(i)] = sum/Element(inverse, j, j);
					}
				}
			}
		}

		return success;
	}

	public static boolean ParseMatrixFromString(MatrixReference aref, char [] matrixString, StringReference errorMessage){
		boolean success;
		StringReference [] lines;
		double rows, cols, i;
		double [] row;
		char [] replaced, trimmed;

		replaced = strReplaceString(matrixString, "\r".toCharArray(), "".toCharArray());
		trimmed = strTrim(replaced);
		lines = strSplitByCharacter(trimmed, '\n');

		delete(replaced);
		delete(trimmed);

		success = true;

		rows = lines.length;
		if(rows == 0d){
			aref.matrix = CreateMatrix(0d, 0d);
		}else{
			row = StringToNumberArray(lines[0].string);
			cols = row.length;
			delete(row);

			aref.matrix = CreateMatrix(rows, cols);

			for(i = 0d; i < rows && success; i = i + 1d){
				delete(aref.matrix.r[(int)(i)].c);
				aref.matrix.r[(int)(i)].c = StringToNumberArray(lines[(int)(i)].string);

				if(aref.matrix.r[(int)(i)].c.length != cols){
					success = false;
					errorMessage.string = "All rows must have the same number of columns.".toCharArray();
				}
			}
		}

		FreeStringReferenceArray(lines);

		return success;
	}

	public static char [] MatrixToString(Matrix matrix, double digitsAfterPoint){
		char [] s1, s2;
		double n, m, element;

		s1 = new char [0];

		for(n = 0d; n < NumberOfRows(matrix); n = n + 1d){
			for(m = 0d; m < NumberOfColumns(matrix); m = m + 1d){
				element = Element(matrix, n, m);
				element = RoundToDigits(element, digitsAfterPoint);
				s2 = strAppendString(s1, CreateStringDecimalFromNumber(element));
				delete(s1);
				s1 = s2;
				if(m + 1d != NumberOfColumns(matrix)){
					s2 = strAppendString(s1, ", ".toCharArray());
					delete(s1);
					s1 = s2;
				}
			}
			s2 = strAppendString(s1, "\n".toCharArray());
			delete(s1);
			s1 = s2;
		}

		return s1;
	}

	public static double RoundToDigits(double element, double digitsAfterPoint){
		return Round(element*pow(10d, digitsAfterPoint))/pow(10d, digitsAfterPoint);
	}

	public static char [] MatrixArrayToString(Matrix [] matrices, double digitsAfterPoint){
		char [] s1, s2;
		double i;

		s1 = new char [0];

		for(i = 0d; i < matrices.length; i = i + 1d){
			s2 = strAppendString(s1, MatrixToString(matrices[(int)(i)], digitsAfterPoint));
			delete(s1);
			s1 = s2;

			s2 = strAppendString(s1, "\n".toCharArray());
			delete(s1);
			s1 = s2;
		}

		return s1;
	}

	public static void RoundMatrixElementsToDigits(Matrix a, double digits){
		double m, n;

		for(m = 0d; m < NumberOfRows(a); m = m + 1d){
			for(n = 0d; n < NumberOfColumns(a); n = n + 1d){
				a.r[(int)(m)].c[(int)(n)] = RoundToDigits(Element(a, m, n), digits);
				if(a.r[(int)(m)].c[(int)(n)] == -0d){
					a.r[(int)(m)].c[(int)(n)] = 0d;
				}
			}
		}
	}

	public static boolean SingularValueDecomposition(Matrix Ap, MatrixReference URef, MatrixReference SigmaRef, MatrixReference VRef){
		Matrix A, U, V;
		double m, n, nu, nct, nrt, i, j, k, t, pp, iter, eps, tiny, kase, f, cs, sn, ks, size, orgm, orgn;
		double scale, sp, spm1, epm1, sk, ek, b, c, shift, g, p;
		boolean done;
		double [] s, e, work;

		/* Square matrix, adjust results correspondingly.*/
		orgm = NumberOfRows(Ap);
		orgn = NumberOfColumns(Ap);
		size = max(orgm, orgn);
		A = CreateCopyOfMatrix(Ap);
		Resize(A, size, size);

		/* Initialize.*/
		m = size;
		n = size;

		/* Compute*/
		nu = min(m, n);
		s = new double [(int)(min(m + 1d, n))];
		U = CreateMatrix(m, nu);
		V = CreateSquareMatrix(n);
		e = new double [(int)(n)];
		work = new double [(int)(m)];

		/* Reduce A to bidiagonal form, storing the diagonal elements in s and the super-diagonal elements in e.*/
		nct = min(m - 1d, n);
		nrt = max(0d, min(n - 2d, m));
		for(k = 0d; k < max(nct, nrt); k = k + 1d){
			if(k < nct){

				/* Compute the transformation for the k-th column and place the k-th diagonal in s[k].*/
				/* Compute 2-norm of k-th column without under/overflow.*/
				s[(int)(k)] = 0d;
				for(i = k; i < m; i = i + 1d){
					s[(int)(k)] = Hypothenuse(s[(int)(k)], Element(A, i, k));
				}
				if(s[(int)(k)] != 0d){
					if(Element(A, k, k) < 0d){
						s[(int)(k)] = -s[(int)(k)];
					}
					for(i = k; i < m; i = i + 1d){
						A.r[(int)(i)].c[(int)(k)] = Element(A, i, k)/s[(int)(k)];
					}
					A.r[(int)(k)].c[(int)(k)] = Element(A, k, k) + 1d;
				}
				s[(int)(k)] = -s[(int)(k)];
			}
			for(j = k + 1d; j < n; j = j + 1d){
				if((k < nct) && (s[(int)(k)] != 0d)){

					/* Apply the transformation.*/
					t = 0d;
					for(i = k; i < m; i = i + 1d){
						t = t + Element(A, i, k)*Element(A, i, j);
					}
					t = -t/Element(A, k, k);
					for(i = k; i < m; i = i + 1d){
						A.r[(int)(i)].c[(int)(j)] = Element(A, i, j) + t*Element(A, i, k);
					}
				}

				/* Place the k-th row of A into e for the subsequent calculation of the row transformation.*/
				e[(int)(j)] = Element(A, k, j);
			}
			if(k < nct){

				/* Place the transformation in U for subsequent back*/
				/* multiplication.*/
				for(i = k; i < m; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = Element(A, i, k);
				}
			}
			if(k < nrt){
				/* Compute the k-th row transformation and place the k-th super-diagonal in e[k].*/
				/* Compute 2-norm without under/overflow.*/
				e[(int)(k)] = 0d;
				for(i = k + 1d; i < n; i = i + 1d){
					e[(int)(k)] = Hypothenuse(e[(int)(k)], e[(int)(i)]);
				}
				if(e[(int)(k)] != 0d){
					if(e[(int)(k + 1d)] < 0d){
						e[(int)(k)] = -e[(int)(k)];
					}
					for(i = k + 1d; i < n; i = i + 1d){
						e[(int)(i)] = e[(int)(i)]/e[(int)(k)];
					}
					e[(int)(k + 1d)] = e[(int)(k + 1d)] + 1d;
				}
				e[(int)(k)] = -e[(int)(k)];
				if((k + 1d < m) && (e[(int)(k)] != 0d)){

					/* Apply the transformation.*/
					for(i = k + 1d; i < m; i = i + 1d){
						work[(int)(i)] = 0d;
					}
					for(j = k + 1d; j < n; j = j + 1d){
						for(i = k + 1d; i < m; i = i + 1d){
							work[(int)(i)] = work[(int)(i)] + e[(int)(j)]*Element(A, i, j);
						}
					}
					for(j = k + 1d; j < n; j = j + 1d){
						t = -e[(int)(j)]/e[(int)(k + 1d)];
						for(i = k + 1d; i < m; i = i + 1d){
							A.r[(int)(i)].c[(int)(j)] = Element(A, i, j) + t*work[(int)(i)];
						}
					}
				}

				/* Place the transformation in V for subsequent back multiplication.*/
				for(i = k + 1d; i < n; i = i + 1d){
					V.r[(int)(i)].c[(int)(k)] = e[(int)(i)];
				}
			}
		}

		/* Set up the final bidiagonal matrix or order p.*/
		p = min(n, m + 1d);
		if(nct < n){
			s[(int)(nct)] = Element(A, nct, nct);
		}
		if(m < p){
			s[(int)(p - 1d)] = 0d;
		}
		if(nrt + 1d < p){
			e[(int)(nrt)] = Element(A, nrt, p - 1d);
		}
		e[(int)(p - 1d)] = 0d;

		/* Generate U.*/
		for(j = nct; j < nu; j = j + 1d){
			for(i = 0d; i < m; i = i + 1d){
				U.r[(int)(i)].c[(int)(j)] = 0d;
			}
			U.r[(int)(j)].c[(int)(j)] = 1d;
		}
		for(k = nct - 1d; k >= 0d; k = k - 1d){
			if(s[(int)(k)] != 0d){
				for(j = k + 1d; j < nu; j = j + 1d){
					t = 0d;
					for(i = k; i < m; i = i + 1d){
						t = t + Element(U, i, k)*Element(U, i, j);
					}
					t = -t/Element(U, k, k);
					for(i = k; i < m; i = i + 1d){
						U.r[(int)(i)].c[(int)(j)] = Element(U, i, j) + t*Element(U, i, k);
					}
				}
				for(i = k; i < m; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = -Element(U, i, k);
				}
				U.r[(int)(k)].c[(int)(k)] = 1d + Element(U, k, k);
				for(i = 0d; i < k - 1d; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = 0d;
				}
			}else{
				for(i = 0d; i < m; i = i + 1d){
					U.r[(int)(i)].c[(int)(k)] = 0d;
				}
				U.r[(int)(k)].c[(int)(k)] = 1d;
			}
		}

		/* Generate V.*/
		for(k = n - 1d; k >= 0d; k = k - 1d){
			if((k < nrt) && (e[(int)(k)] != 0d)){
				for(j = k + 1d; j < nu; j = j + 1d){
					t = 0d;
					for(i = k + 1d; i < n; i = i + 1d){
						t = t + Element(V, i, k)*Element(V, i, j);
					}
					t = -t/Element(V, k + 1d, k);
					for(i = k + 1d; i < n; i = i + 1d){
						V.r[(int)(i)].c[(int)(j)] = Element(V, i, j) + t*Element(V, i, k);
					}
				}
			}
			for(i = 0d; i < n; i = i + 1d){
				V.r[(int)(i)].c[(int)(k)] = 0d;
			}
			V.r[(int)(k)].c[(int)(k)] = 1d;
		}

		/* Main iteration loop for the singular values.*/
		pp = p - 1d;
		iter = 0d;
		eps = pow(2d, -52d);
		tiny = pow(2d, -966d);
		for(; p > 0d; ){
			/* Here is where a test for too many iterations would go.*/
			/* This section of the program inspects for negligible elements in the s and e arrays.*/
			/* On completion the variables kase and k are set as follows.*/
			/* kase = 1, if s(p) and e[k-1] are negligible and k<p*/
			/* kase = 2, if s(k) is negligible and k<p*/
			/* kase = 3, if e[k-1] is negligible, k<p, and s(k), ..., s(p) are not negligible (qr step).*/
			/* kase = 4, if e(p-1) is negligible (convergence).*/
			done = false;
			for(k = p - 2d; k > -1d && !done; ){
				if(abs(e[(int)(k)]) <= tiny + eps*(abs(s[(int)(k)]) + abs(s[(int)(k + 1d)]))){
					e[(int)(k)] = 0d;
					done = true;
				}else{
					k = k - 1d;
				}
			}
			if(k == p - 2d){
				kase = 4d;
			}else{
				done = false;
				for(ks = p - 1d; ks > k && !done; ){
					if(ks != p){
						t = abs(e[(int)(ks)]);
					}else{
						t = 0d;
					}

					if(ks != k + 1d){
						t = t + abs(e[(int)(ks - 1d)]);
					}

					if(abs(s[(int)(ks)]) <= tiny + eps*t){
						s[(int)(ks)] = 0d;
						done = true;
					}else{
						ks = ks - 1d;
					}
				}
				if(ks == k){
					kase = 3d;
				}else if(ks == p - 1d){
					kase = 1d;
				}else{
					kase = 2d;
					k = ks;
				}
			}
			k = k + 1d;

			/* Perform the task indicated by kase.*/
			if(kase == 1d){
				/* Deflate negligible s(p).*/
				f = e[(int)(p - 2d)];
				e[(int)(p - 2d)] = 0d;
				for(j = p - 2d; j >= k; j = j - 1d){
					t = Hypothenuse(s[(int)(j)], f);
					cs = s[(int)(j)]/t;
					sn = f/t;
					s[(int)(j)] = t;
					if(j != k){
						f = -sn*e[(int)(j - 1d)];
						e[(int)(j - 1d)] = cs*e[(int)(j - 1d)];
					}

					for(i = 0d; i < n; i = i + 1d){
						t = cs*Element(V, i, j) + sn*Element(V, i, p - 1d);
						V.r[(int)(i)].c[(int)(p - 1d)] = -sn*Element(V, i, j) + cs*Element(V, i, p - 1d);
						V.r[(int)(i)].c[(int)(j)] = t;
					}
				}
			}else if(kase == 2d){
				/* Split at negligible s(k).*/
				f = e[(int)(k - 1d)];
				e[(int)(k - 1d)] = 0d;
				for(j = k; j < p; j = j + 1d){
					t = Hypothenuse(s[(int)(j)], f);
					cs = s[(int)(j)]/t;
					sn = f/t;
					s[(int)(j)] = t;
					f = -sn*e[(int)(j)];
					e[(int)(j)] = cs*e[(int)(j)];

					for(i = 0d; i < m; i = i + 1d){
						t = cs*Element(U, i, j) + sn*Element(U, i, k + 1d);
						U.r[(int)(i)].c[(int)(k - 1d)] = -sn*Element(U, i, j) + cs*Element(U, i, k + 1d);
						U.r[(int)(i)].c[(int)(j)] = t;
					}
				}
			}else if(kase == 3d){
				/* Perform one qr step.*/
				/* Calculate the shift.*/
				scale = max(max(max(max(abs(s[(int)(p - 1d)]), abs(s[(int)(p - 2d)])), abs(e[(int)(p - 2d)])), abs(s[(int)(k)])), abs(e[(int)(k)]));
				sp = s[(int)(p - 1d)]/scale;
				spm1 = s[(int)(p - 2d)]/scale;
				epm1 = e[(int)(p - 2d)]/scale;
				sk = s[(int)(k)]/scale;
				ek = e[(int)(k)]/scale;
				b = ((spm1 + sp)*(spm1 - sp) + epm1*epm1)/2d;
				c = (sp*epm1)*(sp*epm1);
				shift = 0d;
				if((b != 0d) || (c != 0d)){
					shift = sqrt(b*b + c);
					if(b < 0d){
						shift = -shift;
					}
					shift = c/(b + shift);
				}
				f = (sk + sp)*(sk - sp) + shift;
				g = sk*ek;

				/* Chase zeros.*/
				for(j = k; j < p - 1d; j = j + 1d){
					t = Hypothenuse(f, g);
					cs = f/t;
					sn = g/t;
					if(j != k){
						e[(int)(j - 1d)] = t;
					}
					f = cs*s[(int)(j)] + sn*e[(int)(j)];
					e[(int)(j)] = cs*e[(int)(j)] - sn*s[(int)(j)];
					g = sn*s[(int)(j + 1d)];
					s[(int)(j + 1d)] = cs*s[(int)(j + 1d)];
					for(i = 0d; i < n; i = i + 1d){
						t = cs*Element(V, i, j) + sn*Element(V, i, j + 1d);
						V.r[(int)(i)].c[(int)(j + 1d)] = -sn*Element(V, i, j) + cs*Element(V, i, j + 1d);
						V.r[(int)(i)].c[(int)(j)] = t;
					}
					t = Hypothenuse(f, g);
					cs = f/t;
					sn = g/t;
					s[(int)(j)] = t;
					f = cs*e[(int)(j)] + sn*s[(int)(j + 1d)];
					s[(int)(j + 1d)] = -sn*e[(int)(j)] + cs*s[(int)(j + 1d)];
					g = sn*e[(int)(j + 1d)];
					e[(int)(j + 1d)] = cs*e[(int)(j + 1d)];
					if(j < m - 1d){
						for(i = 0d; i < m; i = i + 1d){
							t = cs*Element(U, i, j) + sn*Element(U, i, j + 1d);
							U.r[(int)(i)].c[(int)(j + 1d)] = -sn*Element(U, i, j) + cs*Element(U, i, j + 1d);
							U.r[(int)(i)].c[(int)(j)] = t;
						}
					}
				}
				e[(int)(p - 2d)] = f;
				iter = iter + 1d;
			}else if(kase == 4d){
				/* Make the singular values positive.*/
				if(s[(int)(k)] <= 0d){
					if(s[(int)(k)] < 0d){
						s[(int)(k)] = -s[(int)(k)];
					}else{
						s[(int)(k)] = 0d;
					}

					for(i = 0d; i <= pp; i = i + 1d){
						V.r[(int)(i)].c[(int)(k)] = -Element(V, i, k);
					}
				}

				/* Order the singular values.*/
				for(; k < pp && s[(int)(k)] < s[(int)(k + 1d)]; ){
					t = s[(int)(k)];
					s[(int)(k)] = s[(int)(k + 1d)];
					s[(int)(k + 1d)] = t;
					if(k < n - 1d){
						for(i = 0d; i < n; i = i + 1d){
							t = Element(V, i, k + 1d);
							V.r[(int)(i)].c[(int)(k + 1d)] = Element(V, i, k);
							V.r[(int)(i)].c[(int)(k)] = t;
						}
					}
					if(k < m - 1d){
						for(i = 0d; i < m; i = i + 1d){
							t = Element(U, i, k + 1d);
							U.r[(int)(i)].c[(int)(k + 1d)] = Element(U, i, k);
							U.r[(int)(i)].c[(int)(k)] = t;
						}
					}
					k = k + 1d;
				}
				iter = 0d;
				p = p - 1d;
			}
		}

		Resize(U, orgm, orgm);
		Resize(V, orgn, orgn);

		URef.matrix = U;
		VRef.matrix = V;
		SigmaRef.matrix = CreateMatrix(orgm, orgn);
		for(i = 0d; i < min(orgm, orgn); i = i + 1d){
			SigmaRef.matrix.r[(int)(i)].c[(int)(i)] = s[(int)(i)];
		}

		return true;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
