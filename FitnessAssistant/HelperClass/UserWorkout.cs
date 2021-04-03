﻿using System;
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
        public string GetCountSalories
        {
            get
            {
                return $"{(Workout.TypeWorkout.CalorieConsumptionRatio * Workout.DurationWorkout / 60 * Users.Weight).ToString()}";
            }
        }
    }
}
//
