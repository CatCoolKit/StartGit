/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.chambas.math.util.core;

import static com.chambas.math.util.core.MathUtil.getFactorial;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.function.Executable;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.MethodSource;

/**
 *
 * @author manhc
 */
public class MathUtilTest {
    
    public static Object[][] initData(){
        return new Integer[][]{
            {1, 1},
            {2, 2},
            {5, 120},
            {6, 720}
        };
    }
    
    @ParameterizedTest
    @MethodSource(value = "initData")
    public void testGetFactorialGivenRichArightArgReturnsWell(int input, long expected) {
        assertEquals(expected, getFactorial(input));
    }
    
    @Test()
    public void testGetFactorialGivenWrongArgThrowException(){
        Executable exObject = new Executable() {
            @Override
            public void execute() throws Throwable {
                getFactorial(-5);
            }
        };
        assertThrows(IllegalArgumentException.class, () -> getFactorial(-5));
    }
    
}
