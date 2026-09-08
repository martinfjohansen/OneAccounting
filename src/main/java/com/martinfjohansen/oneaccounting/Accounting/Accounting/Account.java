package com.martinfjohansen.oneaccounting.Accounting.Accounting;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.FixedPoint15d;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.Date;
import com.martinfjohansen.oneaccounting.datetime.DateCalculations.*;

import com.martinfjohansen.oneaccounting.FixedPointArithmetic.FixedPointArithmetic15d.*;


public class Account{
	public char [] name;
	public FixedPoint15d endingBalance;
	public FixedPoint15d startingBalance;
	public Date from;
	public Date to;
	public FixedPoint15d sumDebit;
	public FixedPoint15d sumCredit;
}
