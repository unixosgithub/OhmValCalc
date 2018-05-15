using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestOhmValueCalc
{
    [TestClass]
    public class CalculatorTest
    {
        IOhmValueCalculator _ohmValCalculator;

        public CalculatorTest()
        {
            _ohmValCalculator = new OhmValueCalculator();
        }

        [TestMethod]
        public void TestCalculateOhmValueSuccess()
        {
            string bandAColor = "Yellow";
            string bandBColor = "Violet";
            string bandCColor = "Red";
            string bandDColor = "Gold";

            int ohmValue = _ohmValCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            Assert.AreEqual(4700, ohmValue);                        
        }

        [TestMethod]
        public void TestCalculateOhmValueFail()
        {
            string bandAColor = "Red";
            string bandBColor = "Blue";
            string bandCColor = "Brown";
            string bandDColor = "Gold";

            int ohmValue = _ohmValCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            Assert.AreNotEqual(700, ohmValue);
        }
    }
}
