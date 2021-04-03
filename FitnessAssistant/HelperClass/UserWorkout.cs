using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant.EF
{
    public partial class UserWorkout
    {
        // для подчета потраченных калорий будем использовать формулу
        // коэф тренировки * длительность тренировки / 60 * массу тела
        public string GetCountCalories
        {
            get
            {
                return (HelperClass.Calculations.GetCountCalories(TypeWorkout.CalorieConsumptionRatio, Convert.ToInt32(DurationWorkout), Convert.ToInt32(Users.Weight)).ToString());
               
            }
        }
    }
}

