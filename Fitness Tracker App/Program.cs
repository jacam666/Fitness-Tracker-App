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
         
            //Console.WriteLine("SO these are your exercises for you to complete today :");
            //foreach (var i in ChestExercises)
            //{              
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("SO these are your exercises for you to complete today :");
            //foreach (var i in LegExercises)
            //{
            //    Console.WriteLine(i);
            //}
        }
       public static void Chestworkout()
        {
            List<string> ChestExercises = new();
            ChestExercises.Add("Barbell Bench Press");
            ChestExercises.Add("Incline Barbell Bench");
            ChestExercises.Add("Cable Flyes");
            ChestExercises.Add("Decline Barbell Bench");
            ChestExercises.Add("Dumbbell Flyes");
            ChestExercises.Add("Pec Dec");
            ChestExercises.Add("Cable Crossover");
        }
        public static void LegWorkout()
        {
            List<string> LegExercises = new();
            LegExercises.Add("Barbell Squats");
            LegExercises.Add("Leg Press");
            LegExercises.Add("Leg extensions");
            LegExercises.Add("Hack Squats");
            LegExercises.Add("Walking Lunges");
            LegExercises.Add("Lying Leg Curl");
            LegExercises.Add("Seated Leg Curl");
        }
    }
    
}
