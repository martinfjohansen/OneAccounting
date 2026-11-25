package com.martinfjohansen.oneaccounting;

import com.martinfjohansen.oneaccounting.Accounting.Accounting.AccountPlan;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Data;
import com.martinfjohansen.oneaccounting.DataStructures.Array.Structures.Structure;

public class OneAccountingState {
    public double idles;
    public double entries;
    public double entrySize;

    public Data data;
    public Structure ledger;
    public AccountPlan accountPlan;
    public boolean accountPlanSet;
}
