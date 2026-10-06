package com.martinfjohansen.oneaccounting.QRCodes.QRErrorCorrectionCodes;

import com.martinfjohansen.oneaccounting.references.references.NumberArrayReference;

import static com.martinfjohansen.oneaccounting.QRCodes.QRCodes.QRCodes.QREccLetterToNumber;
import static com.martinfjohansen.oneaccounting.ReedSolomon.ReedSolomon.ReedSolomon.ComputeReedSolomonCodes;
import static com.martinfjohansen.oneaccounting.numbers.StringToNumber.StringToNumber.StringToNumberArray;
import static java.lang.Math.floor;

public class QRErrorCorrectionCodes{
	public static double [] QRAddErrorCodesAndInterleave(double [] cws, double version, char errorCorrectionLevel){
		double eccsPerBlock, errorCorrectionLevelNumber, nrOfBlocks, i, j, cw, cwsInBlock, e;
		double [] ecc, eccPerBlockSpec, blockSpecs, blockLengths, block, complete;
		NumberArrayReference[] blocks, blockEccs;

		eccPerBlockSpec = StringToNumberArray("7, 10, 13, 17, 10, 16, 22, 28, 15, 26, 18, 22, 20, 18, 26, 16, 26, 24, 18, 22, 18, 16, 24, 28, 20, 18, 18, 26, 24, 22, 22, 26, 30, 22, 20, 24, 18, 26, 24, 28, 20, 30, 28, 24, 24, 22, 26, 28, 26, 22, 24, 22, 30, 24, 20, 24, 22, 24, 30, 24, 24, 28, 24, 30, 28, 28, 28, 28, 30, 26, 28, 28, 28, 26, 26, 26, 28, 26, 30, 28, 28, 26, 28, 30, 28, 28, 30, 24, 30, 28, 30, 30, 30, 28, 30, 30, 26, 28, 30, 30, 28, 28, 28, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30, 30, 28, 30, 30".toCharArray());

		blockSpecs = StringToNumberArray("1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2, 4, 1, 2, 4, 4, 2, 4, 4, 4, 2, 4, 6, 5, 2, 4, 6, 6, 2, 5, 8, 8, 4, 5, 8, 8, 4, 5, 8, 11, 4, 8, 10, 11, 4, 9, 12, 16, 4, 9, 16, 16, 6, 10, 12, 18, 6, 10, 17, 16, 6, 11, 16, 19, 6, 13, 18, 21, 7, 14, 21, 25, 8, 16, 20, 25, 8, 17, 23, 25, 9, 17, 23, 34, 9, 18, 25, 30, 10, 20, 27, 32, 12, 21, 29, 35, 12, 23, 34, 37, 12, 25, 34, 40, 13, 26, 35, 42, 14, 28, 38, 45, 15, 29, 40, 48, 16, 31, 43, 51, 17, 33, 45, 54, 18, 35, 48, 57, 19, 37, 51, 60, 19, 38, 53, 63, 20, 40, 56, 66, 21, 43, 59, 70, 22, 45, 62, 74, 24, 47, 65, 77, 25, 49, 68, 81".toCharArray());

		errorCorrectionLevelNumber = QREccLetterToNumber(errorCorrectionLevel);

		eccsPerBlock = eccPerBlockSpec[(int)((version - 1d)*4d + errorCorrectionLevelNumber)];
		nrOfBlocks = blockSpecs[(int)((version - 1d)*4d + errorCorrectionLevelNumber)];

		blockLengths = QRComputeBlockLengths(cws.length, nrOfBlocks);

		blocks = new NumberArrayReference [(int)(nrOfBlocks)];
		blockEccs = new NumberArrayReference [(int)(nrOfBlocks)];

		cw = 0d;
		for(i = 0d; i < nrOfBlocks; i = i + 1d){
			/* Create block.*/
			cwsInBlock = blockLengths[(int)(i)];
			block = new double [(int)(cwsInBlock)];
			for(j = 0d; j < cwsInBlock; j = j + 1d){
				block[(int)(j)] = cws[(int)(cw)];
				cw = cw + 1d;
			}

			/* Compute eccs.*/
			ecc = ComputeReedSolomonCodes(block, eccsPerBlock);

			blocks[(int)(i)] = new NumberArrayReference();
			blocks[(int)(i)].numberArray = block;
			blockEccs[(int)(i)] = new NumberArrayReference();
			blockEccs[(int)(i)].numberArray = ecc;
		}

		/* Compose full data block:*/
		complete = new double [(int)(cws.length + eccsPerBlock*nrOfBlocks)];

		e = 0d;
		/* Interleave codewords:*/
		for(i = 0d; i < floor(cws.length/nrOfBlocks); i = i + 1d){
			for(j = 0d; j < nrOfBlocks; j = j + 1d){
				complete[(int)(e)] = blocks[(int)(j)].numberArray[(int)(i)];
				e = e + 1d;
			}
		}

		/* Interleave remaining code words:*/
		for(i = 0d; i < nrOfBlocks; i = i + 1d){
			if(blockLengths[(int)(i)] > blockLengths[0]){
				complete[(int)(e)] = blocks[(int)(i)].numberArray[(int)(blockLengths[(int)(i)] - 1d)];
				e = e + 1d;
			}
		}

		for(i = 0d; i < eccsPerBlock; i = i + 1d){
			for(j = 0d; j < nrOfBlocks; j = j + 1d){
				complete[(int)(e)] = blockEccs[(int)(j)].numberArray[(int)(i)];
				e = e + 1d;
			}
		}

		return complete;
	}

	public static double [] QRComputeBlockLengths(double length, double blocks){
		double q, r, i;
		double [] blockLengths;

		blockLengths = new double [(int)(blocks)];

		q = floor(length/blocks);
		r = length%blocks;

		for(i = 0d; i < blocks; i = i + 1d){
			blockLengths[(int)(i)] = q;
		}

		if(r > 0d){
			for(i = 0d; i < r; i = i + 1d){
				blockLengths[(int)(blockLengths.length - 1d - i)] = q + 1d;
			}
		}

		return blockLengths;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
