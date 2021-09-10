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
        /// <summary>
        /// takes users name, dob, and bodyweight info
        /// </summary>
        /// <returns>userdata</returns>
        internal static User EnterNewUser()
        {
            User u = new();
            Console.WriteLine("Please Enter your First name :");
            u.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter your last name :");
            u.LastName = Console.ReadLine();
            EnterDateOfBirth();
            DateTime today = DateTime.Today;
            Console.WriteLine($"Hi {u.FirstName} {u.LastName} you are currently {string.Format("{0:0.}", u.DOB)} years old.");

            return u;
        }
        /// <summary>
        /// calculates users date of birth
        /// </summary>
        /// <returns>total years</returns>
        /// 
        public static DateTime EnterDateOfBirth()
        {
            Console.WriteLine("Please enter you Date Of Birth yyyy, m, dd");
            string Input = Console.ReadLine();
            DateTime dob = DateTime.Parse(Input);
            return dob;
        }
        public static TrainingDay TodaysSessionDetails()
        {
            TrainingDay train = new();
            DateTime Today = DateTime.Today;
            //Workout = UI.SelectBodyPart();

            return train;
        }
        /// <summary>
        /// list of chest exercises
        /// </summary>
        /// <returns>chestexercises</returns>
        //public static Workout PrintSpecificWorkoutOptions()
        //{
        //    Workout ChestExercise = new();
        //    List<string> ChestExercises = new();
        //    ChestExercises.Add("Barbell Bench Press");
        //    ChestExercises.Add("Incline Barbell Bench");
        //    ChestExercises.Add("Cable Flyes");
        //    ChestExercises.Add("Decline Barbell Bench");
        //    ChestExercises.Add("Dumbbell Flyes");
        //    ChestExercises.Add("Pec Dec");
        //    ChestExercises.Add("Cable Crossover");
        //    Console.WriteLine("So these will be the exercises that you complete today :");
        //    foreach (var i in ChestExercises)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    return ChestExercise;
        //}

        public static void PrintSpecificWorkoutOptions(List<string> options)
        {
            foreach(string option in options)
            {
                Console.WriteLine(option);
            }
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
            foreach (var i in LegExercises)
            {
                Console.WriteLine(i);
            }
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
            Console.WriteLine("So these will be the exercises that you complete today :");
            foreach (var i in BackExercises)
            {
                Console.WriteLine(i);
            }

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
            Console.WriteLine("So these will be the exercises that you complete today :");
            foreach (var i in ShoulderExercises)
            {
                Console.WriteLine(i);
            }

            return ShoulderExercise;
        }
        /// <summary>
        /// list of arm exercises
        /// </summary>
        /// <returns>ArmExercise</returns>
        public static Workout ArmExercise()
        {
            Workout ArmExercise = new();
            List<string> ArmExercises = new();
            ArmExercises.Add("Barbell Curls");
            ArmExercises.Add("Cable Rope curls");
            ArmExercises.Add("Seated machine curls");
            ArmExercises.Add("Dumbbell Concertration curls");
            ArmExercises.Add("Close grip Bench press");
            ArmExercises.Add("Rope cable Pushdown");
            ArmExercises.Add("Dumbbell Tricep Extension");
            ArmExercises.Add("Dumbbell Kickbacks");
            ArmExercises.Add("Single arm cable pushdowns");
            Console.WriteLine("So these will be the exercises that you complete today :");
            foreach (var i in ArmExercises)
            {
                Console.WriteLine(i);
            }

            return ArmExercise;
        }
        /// <summary>
        /// User chooses what bodypart they would like to train, program prints out list of exercises for that bodypart
        /// </summary>
        /// <returns>ExerciseChosen</returns>
        public static BodyPart SelectBodyPart()
        {
            Console.WriteLine("Please choose from the following bodyparts: ");
            BodyPart bodypart = new();
            Console.Write($"{BodyPart.Arms} ,");
            Console.Write($"{BodyPart.Back} ,");
            Console.Write($"{BodyPart.Chest} ,");
            Console.Write($"{BodyPart.Legs} ,");
            Console.WriteLine($"{BodyPart.Shoulders}.");

            //print the list of available bodyparts
            string Choice;
   
            Choice = Console.ReadLine().ToUpper();
            if (Choice == "CHEST")
            {
                return BodyPart.Chest;
            }
            if (Choice == "LEGS")
            {
                return BodyPart.Legs;
            }
            if (Choice == "BACK")
            {
                return BodyPart.Back;
            }
            if (Choice == "ARM")
            {
                return BodyPart.Arms;
            }
            if (Choice == "SHOULDER")
            {
                return BodyPart.Shoulders;
            }
            return bodypart;
        }
        /// <summary>
        /// user inputs amount of reps and sets completed
        /// </summary>
        public static Workout EnterWorkoutData(string exerciseName)
        {
            Workout currentWorkout = new();
            //  DateTime today = DateTime.Today;
            currentWorkout.ExerciseName = exerciseName;
            Console.WriteLine("Please enter the amount of Reps completed :");
            currentWorkout.AmountOfReps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the amount of Sets completed :");
            currentWorkout.AmountOfSets = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine($"On the {today} you completed {CompletedSetsReps.AmountOfSets} sets of {CompletedSetsReps.AmountOfReps} Reps");
            return currentWorkout;
        }

        public static double EnterBodyweight()
        {
            double BodyWeight;
            Console.WriteLine("Now please Enter your bodyweight in kilograms :");
            BodyWeight = Convert.ToDouble(Console.ReadLine());  //maybe use tryparse
            return BodyWeight;
        }

        public static void UsersBodyPartChoice()
        {
            Console.WriteLine("Please select what BodyPart from theses choices you would like to Train :");
            Console.Write("BACK, ");
            Console.Write("CHEST, ");
            Console.Write("LEGS, ");
            Console.Write("ARM, ");
            Console.WriteLine("SHOULDER.");
        }

        public static Workout InputSets(int SetsCompleted)
        {
            Workout CompletedSets = new();
            CompletedSets.AmountOfSets = SetsCompleted;
            Console.WriteLine("Please input the ampount of sets completed for this exercise.");
            Console.ReadLine();
            return CompletedSets;
        }

        public static Workout InputReps(int RepsCompleted)
        {
            Workout CompletedReps = new();
            CompletedReps.AmountOfReps = RepsCompleted;
            Console.WriteLine("Please input the ampount of reps completed for this exercise.");
            Console.ReadLine();
            return CompletedReps;
        }
        public static void InputSpecificExercise()
        {

        }
    }
}
