using System;
using System.Collections.Generic;

namespace Fitness_Tracker_App.Data
{
    public class TrainingDay
    {
        public DateTime TodaysDate;
        public List<Workout> Workouts = new List<Workout>();
        public double BodyWeight;
    }
}
