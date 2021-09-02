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
            Console.WriteLine($"Hi {u.FirstName} {u.LastName} you are currently {String.Format("{0:0.}", Age)} years old and weigh {BodyWeight} Kg's.");

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
           // bool BodyPartSelection;
            Console.WriteLine("Please select what BodyPart you would like to Train :");
            //BodyPartSelection = UsersWorkoutChoice();
            Console.WriteLine($"Perfect on the {Today} you will be training {UsersWorkoutChoice()}");
            return train;
        }
        /// <summary>
        /// list of chest exercises
        /// </summary>
        /// <returns>chestexercises</returns>
        public static Workout ChestExercise()
        {
            Workout ChestExercise = new();
            List<string> ChestExercises = new();
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
            return ChestExercise;
        }
        /// <summary>
        /// list of leg exercises
        /// </summary>
        /// <returns>leg exercises</returns>
        public static Workout LegExercise()
        {
            Workout LegExercise = new();
            List<string> LegExercises = new();
            LegExercises.Add("Barbell Squats");
            LegExercises.Add("Leg Press");
            LegExercises.Add("Leg extensions");
            LegExercises.Add("Hack Squats");
            LegExercises.Add("Walking Lunges");
            LegExercises.Add("Pec Dec");
            LegExercises.Add("Lying Leg Curl");
            LegExercises.Add("Seated Leg Curl");
            Console.WriteLine("So these will be the exercises that you complete today :");
            //foreach (var i in LegExercises)
            //{
            //    Console.WriteLine(i);
            //}
            return LegExercise;
        }
        /// <summary>
        /// list of backexercises
        /// </summary>
        /// <returns>Backexercises</returns>
        public static Workout BackExercise()
        {
            Workout BackExercise = new();
            List<string> BackExercises = new();
            BackExercises.Add("Barbell Row");
            BackExercises.Add("Cable Lat Pulldown");
            BackExercises.Add("Close grip Cable Pulldown");
            BackExercises.Add("Single Arm Dumbbell row");
            BackExercises.Add("Machine Back extension");
            BackExercises.Add("Seated Cable row");

            return BackExercise;
        }
        /// <summary>
        /// list of ShoulderExercises
        /// </summary>
        /// <returns>ShoulderExercise</returns>
        public static Workout ShoulderExercise()
        {
            Workout ShoulderExercise = new();
            List<string> ShoulderExercises = new();
            ShoulderExercises.Add("Barbell Press");
            ShoulderExercises.Add("Dumbbell Press");
            ShoulderExercises.Add("Dumbbell side raises");
            ShoulderExercises.Add("Dumbbell Front raises");
            ShoulderExercises.Add("Reverse Pec Dec");
            ShoulderExercises.Add("Barbell Shrugs");
            ShoulderExercises.Add("Cable Upright Rows");

            return ShoulderExercise;
        }
        /// <summary>
        /// list of arm exercises
        /// </summary>
        /// <returns>ArmExercise</returns>
        public static Workout ArmExercise()
        {
            Workout ArmExercises = new();
            List<string> ArmExercise = new();
            ArmExercise.Add("Barbell Curls");
            ArmExercise.Add("Cable Rope curls");
            ArmExercise.Add("Seated machine curls");
            ArmExercise.Add("Dumbbell Concertration curls");
            ArmExercise.Add("Close grip Bench press");
            ArmExercise.Add("Rope cable Pushdown");
            ArmExercise.Add("Dumbbell Tricep Extension");
            ArmExercise.Add("Dumbbell Kickbacks");
            ArmExercise.Add("Single arm cable pushdowns");
            return ArmExercises;
        }
        /// <summary>
        /// User chooses what bodypart they would like to train, program prints out list of exercises for that bodypart
        /// </summary>
        /// <returns>ExerciseChosen</returns>
        public static bool UsersWorkoutChoice()
        {
            string Choice;
            bool ExerciseChosen = false;
            Choice = Console.ReadLine().ToUpper();
            if (Choice == "CHEST")
            { 
                Console.WriteLine(ChestExercise());  
            }
            if(Choice == "LEGS")
            {               
                Console.WriteLine(LegExercise());
            }
            if (Choice == "BACK")
            {
                Console.WriteLine(BackExercise());
            }
            if (Choice == "ARM")
            {
                Console.WriteLine(ArmExercise());
            }
            if (Choice == "SHOULDER")
            {
                Console.WriteLine(ShoulderExercise());
            }
            return ExerciseChosen;
        }
        /// <summary>
        /// user inputs amount of reps and sets completed
        /// </summary>
        public static void RepsSetsCompleted()
        {
            Workout CompletedSetsReps = new();
            Console.WriteLine("Please enter the amount of Reps completed :");
            CompletedSetsReps.AmountOfReps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the amount of Sets completed :");
            CompletedSetsReps.AmountOfSets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"On the {CompletedSetsReps.Date} you completed {CompletedSetsReps.AmountOfSets} sets of {CompletedSetsReps.AmountOfReps} Reps");
        }
       
    }
}
