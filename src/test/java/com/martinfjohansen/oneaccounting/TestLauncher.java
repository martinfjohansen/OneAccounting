package com.martinfjohansen.oneaccounting;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class TestLauncher {
    @Test
    public void runTest(){
        double failures;
        failures = com.martinfjohansen.oneaccounting.tests.test();
        assertEquals(0, (int)failures);
    }
}
