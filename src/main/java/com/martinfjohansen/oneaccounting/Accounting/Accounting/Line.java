package com.martinfjohansen.oneaccounting.Accounting.Accounting;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.*;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.*;


public class Line{
	public char [] account;
	public FixedPoint15d debit;
	public FixedPoint15d credit;
	public char [] description;
	public Date date;
}
