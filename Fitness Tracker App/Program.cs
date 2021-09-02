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
            User testUser = UI.EnterNewUser();
            UI.TodaysSessionDetails();
            //UI.ChestExercise();
            //UI.TodaysSessionDetails();
            Workout workout = new();
            workout.AmountOfReps = Convert.ToInt32(Console.ReadLine());
            workout.AmountOfSets = Convert.ToInt32(Console.ReadLine());
            workout.Date = DateTime.Today;
            Console.WriteLine("Pleas enter the amount of Reps completed :");
            Console.WriteLine($"The amount of Reps you completed for this exercise are {workout.AmountOfReps}:");
            





        }

    }
    
}
