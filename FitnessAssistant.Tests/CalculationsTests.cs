using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAssistant.Tests
{
    [TestClass]
    public class CalculationsTests
    {
        // Тестирвание метода BMI
        [TestMethod]
        public void GetBMI_50and170_17returned()
        {
            // arrange
            double w = 50;
            double h = 170;
            string ex = "17 Недостаточная масса тела (дефицит)";

            // act
                        
            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w,h);

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

            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

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

            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

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

            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

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

            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

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

            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

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

           string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

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

            string result = FitnessAssistant.HelperClass.Calculations.GetBMI(w, h);

            // assert
            Assert.AreEqual(ex, result);
        }



        // Тестирвание метода BMR
        [TestMethod]
        public void GetBMR_2and146and118_1933returned()
        {
            // arrange
            int g = 2;
            int h = 146;
            int w = 118;
            int a = 25;

            double ex = 1933;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetBMR(g,h,w,a);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMR_1and151and57_1044returned()
        {
            // arrange
            int g = 1;
            int h = 151;
            int w = 57;
            int a = 82;

            double ex = 1044;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetBMR(g, h, w, a);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetBMR_1and178and53_1573returned()
        {
            // arrange
            int g = 1;
            int h = 178;
            int w = 53;
            int a = 16;

            double ex = 1573;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetBMR(g, h, w, a);

            // assert
            Assert.AreEqual(ex, result);
        }


        // Блок тестов для рассчета потраченных калорий
        [TestMethod]
        public void GetCountCalories_17and60and54_918returned()
        {
            // arrange
            double calorieConsumptionRatio = 17;
            int durationWorkout = 60;
            int wight = 54;

            double ex = 918;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetCountCalories(calorieConsumptionRatio, durationWorkout, wight);

            // assert
            Assert.AreEqual(ex, result);
        }


        [TestMethod]
        public void GetCountCalories_15and120and54_1620returned()
        {
            // arrange
            double calorieConsumptionRatio = 15;
            int durationWorkout = 120;
            int wight = 54;

            double ex = 1620;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetCountCalories(calorieConsumptionRatio, durationWorkout, wight);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetCountCalories_11and30and54_297returned()
        {
            // arrange
            double calorieConsumptionRatio = 11;
            int durationWorkout = 30;
            int wight = 54;

            double ex = 297;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetCountCalories(calorieConsumptionRatio, durationWorkout, wight);

            // assert
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void GetCountCalories_0and0and0_0returned()
        {
            // arrange
            double calorieConsumptionRatio = 0;
            int durationWorkout = 0;
            int wight = 0;

            double ex = 0;

            // act

            double result = FitnessAssistant.HelperClass.Calculations.GetCountCalories(calorieConsumptionRatio, durationWorkout, wight);

            // assert
            Assert.AreEqual(ex, result);
        }
    }
}
