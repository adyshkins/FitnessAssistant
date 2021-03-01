using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAssistant.Tests
{
    [TestClass]
    public class CalculationsTests
    {
        [TestMethod]
        public void GetBMI_50and170_17returned()
        {
            // arrange
            double w = 50;
            double h = 170;
            string ex = "17 Недостаточная масса тела (дефицит)";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w,h);

            // assert
            Assert.AreEqual(ex,result);
        }
    }
}
