using System;
using System.Collections.Generic;

namespace Fitness_Tracker_App.Data
{
    public class User
    {
        public String FirstName;
        public String LastName;
        public DateTime DOB;
        public List<TrainingDay> TrainingDays = new();
        public Workout Workouts;
    }
}
