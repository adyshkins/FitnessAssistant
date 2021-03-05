using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant.HelperClass
{
    /// <summary>
    /// Калькулятор индекса массы тела
    /// </summary>
    public static class Calculations
    {
        public static string GetBMI(double wight, double height)
        {
            double bmi = wight / (Math.Pow((height / 100), 2));

            if (bmi <= 16 && bmi > 0)
            {
                return Math.Round(bmi).ToString() + " Выраженный дефицит массы тела";
            }
            else if (bmi > 16 && bmi <= 18.5)
            {
                return Math.Round(bmi).ToString() + " Недостаточная масса тела (дефицит)";
            }
            else if (bmi > 18.5 && bmi <= 24)
            {
                return Math.Round(bmi).ToString() + " Нормальная масса тела";
            }
            else if (bmi > 25 && bmi <= 30)
            {
                return Math.Round(bmi).ToString() + " Избыточная масса тела(предожирение)";
            }
            else if (bmi > 30 && bmi <= 35)
            {
                return Math.Round(bmi).ToString() + " Ожирение I степени";
            }
            else if (bmi > 35 && bmi <= 40)
            {
                return Math.Round(bmi).ToString() + " Ожирение II степени";
            }
            else if (bmi > 40)
            {
                return Math.Round(bmi).ToString() + " Ожирение III степени";
            }
            else
            {
                return "Ошибка при вводе данных";
            }
        }

        public static double GetBMR(int genderId, int height, int weight, int age)
        {
            double bmr;
            if (genderId == 1) // если мужской пол
            {
                bmr = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
            }
            else if (genderId == 2) // если женский пол
            {
                bmr = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
            }
            else // Если что-то пошло не так, вернуть ноль
            {
                bmr = 0;
            }
            return bmr;
        }
    }
}
