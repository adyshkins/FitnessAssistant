using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant.HelperClass
{
    public class Calculations
    {
        public string GetBMI(double wight, double height)
        {
            double bmi = wight / (Math.Pow((height/100), 2));
            if (bmi <= 16 && bmi > 0)  // была ошибка
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
                return Math.Round(bmi).ToString() + " Ожирение III степени";  // Была ошибка
            }
            else
            {
                return "Ошибка при вводе данных";
            }            
        }
    }
}
