using Fitness_Tracker_App.Data;
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


        public void AddUser(User u)
        {
            _users.Add(u);
            //store (maybe xml, maybe database)
        }

        private List<ChestExerciseName> _chestExerciseNames = new();

        public List<ChestExerciseName> chestExerciseNames
        {
            get { return _chestExerciseNames; }
            set { _chestExerciseNames = value; }
        }
        public void AddChestExercise(ChestExerciseName chest)
        {
            _chestExerciseNames.Add(chest);
        }
    }
}
