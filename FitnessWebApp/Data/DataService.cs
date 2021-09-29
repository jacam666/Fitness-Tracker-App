﻿using Fitness_Tracker_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApp.Data
{
    public class DataService
    {
        private List<User> _users = new List<User>();

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        private List<String> _chestExerciseNames = new()
        {
            "Barbell Bench Press",
            "Incline Barbell Bench",
            "Cable Flyes",
            "Decline Barbell Bench",
            "Dumbbell Flyes",
            "Pec Dec",
            "Cable Crossover"
        };

        public List<String> ChestExerciseNames
        {
            get { return _chestExerciseNames; }
            set { _chestExerciseNames = value; }
        }

        private List<String> _LegExerciseNames = new()
        {
            "Barbell Squats",
            "Leg Press",
            "Leg extensions",
            "Hack Squats",
            "Walking Lunges",
            "Seated leg curl",
            "Lying Leg Curl"
        };

        public List<String> LegExerciseNames
        {
            get { return _LegExerciseNames; }
            set { _LegExerciseNames = value; }
        }




        public void AddUser(User u)
        {
            _users.Add(u);
            //store (maybe xml, maybe database)
        }



    }
}
