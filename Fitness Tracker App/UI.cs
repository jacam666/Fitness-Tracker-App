using Fitness_Tracker_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker_App
{
    class UI
    {
        internal static User EnterNewUser()
        {
            User u = new();
            Console.WriteLine("Please Enter your First name :");
            u.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter your last name :");
            u.LastName = Console.ReadLine();
            double Age;
            Age = CalculateUsersDateOfBirth();
            double BodyWeight;
            Console.WriteLine("Now please Enter your bodyweight in kilograms :");
            BodyWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hi {u.FirstName} {u.LastName} you are currently {String.Format("{0:0.}" , Age)} years old and weigh {BodyWeight} Kg's.");

            //get all the data

            return u;
        }

        public static double CalculateUsersDateOfBirth()
        {
            DateTime Today = DateTime.Today;
            Console.WriteLine("Please enter you Date Of Birth yyyy, m, dd");
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            double totalDays = (Today - DateOfBirth).TotalDays;
            double totalYears = totalDays / 365;

            return totalYears;           
        }
        public static TrainingDay TodaysSessionDetails()
        {
            TrainingDay train = new();
            DateTime Today = DateTime.Today;
            string BodyPartSelection;      
            Console.WriteLine("Please select what BodyPart you would like to Train :");
            BodyPartSelection = Console.ReadLine().ToUpper();             
            Console.WriteLine($"Perfect on the {Today} you will be training {BodyPartSelection}");
            return train;
        }

        public static ChestWorkout ChestExercise()
        {
            ChestWorkout ChestExercise = new();
            List<string> ChestExercises= new();
            ChestExercises.Add("Barbell Bench Press");
            ChestExercises.Add("Incline Barbell Bench");
            ChestExercises.Add("Cable Flyes");
            ChestExercises.Add("Decline Barbell Bench");
            ChestExercises.Add("Dumbbell Flyes");
            ChestExercises.Add("Pec Dec");
            ChestExercises.Add("Cable Crossover");
            Console.WriteLine("So these will be the exercises that you complete today :");
            foreach (var i in ChestExercises)
            {
                Console.WriteLine(i);
            }
            return ChestExercise ;
            
        }
    }
}
