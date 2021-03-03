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

        [TestMethod]
        public void GetBMI_45and180_14returned()
        {
            // arrange
            double w = 45;
            double h = 180;
            string ex = "14 Выраженный дефицит массы тела";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMI_60and165_22returned()
        {
            // arrange
            double w = 60;
            double h = 165;
            string ex = "22 Нормальная масса тела";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMI_100and185_29returned()
        {
            // arrange
            double w = 100;
            double h = 185;
            string ex = "29 Избыточная масса тела(предожирение)";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMI_115and186_33returned()
        {
            // arrange
            double w = 115;
            double h = 186;
            string ex = "33 Ожирение I степени";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMI_120and182_36returned()
        {
            // arrange
            double w = 120;
            double h = 182;
            string ex = "36 Ожирение II степени";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMI_94and150_42returned()
        {
            // arrange
            double w = 94;
            double h = 150;
            string ex = "42 Ожирение III степени";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMI_100and150_0returned()
        {
            // arrange
            double w = -100;
            double h = -150;
            string ex = "Ошибка при вводе данных";

            // act

            FitnessAssistant.HelperClass.Calculations c = new HelperClass.Calculations();
            string result = c.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }
    }
}
