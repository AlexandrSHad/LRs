using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LR34_CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Div_ShouldReturnCorrectValue()
        {
            double a = 10.0;
            double b = 2.0;
            double expectedResult = 5.0;

            double result = Calculator.Div(a, b);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_ByZero_ShouldThrowDivideByZeroException()
        {
            double a = 10.0;
            double b = 0.0;

            double result = Calculator.Div(a, b);
        }
    }
}
