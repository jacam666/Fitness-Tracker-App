using Fitness_Tracker_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fitness_Tracker_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //User testUser = UI.EnterNewUser();
            UI.TodaysSessionDetails();
            UI.UsersWorkoutChoice();
            Workout workout = new(); 
            workout.Date = DateTime.Today;
            UI.RepsSetsCompleted();

        }

    }
    
}
