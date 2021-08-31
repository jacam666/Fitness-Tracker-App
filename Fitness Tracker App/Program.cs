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
            //UI.UsersNameAgeBodyWeightWelcomeMessage();

            User testUser = UI.EnterNewUser();
            UI.TodaysSessionDetails();


            //ChestWorkout chestWorkout = new ChestWorkout();
            List<string> ChestExercises = new();
            ChestExercises.Add("Barbell Bench Press");
            ChestExercises.Add("Incline Barbell Bench");
            ChestExercises.Add("Cable Flyes");
            ChestExercises.Add("Decline Barbell Bench");
            ChestExercises.Add("Dumbbell Flyes");
            ChestExercises.Add("Pec Dec");
            ChestExercises.Add("Cable Crossover");
            Console.WriteLine("SO these are your exercises for you to complete today :");
            foreach (var i in ChestExercises)
            {              
                Console.WriteLine(i);
            }
           

            
            

            
            





        }
       
    }
    
}
