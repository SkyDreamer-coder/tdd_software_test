using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TinyCalculator;

namespace TinyCalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calc = new Calculator();
        }
        
        [TestMethod]
        public void TestInvalidInput()
        {
            Calculator calc = new Calculator();
            try
            {
                int result = calc.Calculate("abcd");
                Assert.Fail();
            } 
            catch(InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void OnePlusOne()
        {
            DoSumTest("1+1", 2);
        }

        void DoSumTest(string input, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoPlusTwo()
        {
            DoSumTest("2+2", 4);
        }

        [TestMethod]
        public void FourPlusEleven()
        {
            DoSumTest("4+11", 15);
        }

        [TestMethod]
        public void TwoMinusOne()
        {
            DoSumTest("2-1", 1);
        }

        [TestMethod]
        public void FiveMinusTwo()
        {
            DoSumTest("5-2", 3);
        }

        [TestMethod]
        public void FiveTimesTwo()
        {
            DoSumTest("5*2", 10);
        }

        [TestMethod]
        public void EightDividedByTwo()
        {
            DoSumTest("8/2", 4);
        }
    }
}
