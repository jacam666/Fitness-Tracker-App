using Fitness_Tracker_App.Data;
using System;
using System.Collections.Generic;

namespace Fitness_Tracker_App
{
    public class UI
    {
        /// <summary>
        /// takes users name, dob, and bodyweight info
        /// </summary>
        /// <returns>userdata</returns>
        public static User EnterNewUser()
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


        public static void PrintSpecificWorkoutOptions(List<string> options)
        {
            List<Workout> Workouts = new();
            foreach (string option in options)
            {
                var workout = new Workout();
                workout.ExerciseName = option;

                Console.WriteLine(option);
                workout.AmountOfReps = InputReps();
                //    workout.AmountOfSets = InputSets();
                Workouts.Add(workout);
            }
        }

        /// <summary>
        /// list of leg exercises
        /// </summary>
        /// <returns>leg exercises</returns>

        ///// <summary>
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

            //switch (Choice)
            //{
            //    case "CHEST":
            //    case "CHESTY":
            //    case "superchest":
            //        return BodyPart.Chest;
            //    case "LEGS":
            //        return BodyPart.Legs;
            //    default:
            //        return BodyPart.UNDEFINED;
            //}

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

        public static Workout InputSets()//int SetsCompleted)
        {
            Workout CompletedSets = new();
            //CompletedSets.AmountOfSets = SetsCompleted;
            Console.WriteLine("Please input the ampount of sets completed for this exercise.");
            Console.ReadLine();
            return CompletedSets;
        }

        public static int InputReps()//int RepsCompleted)
        {

            Console.WriteLine("Please input the ampount of reps completed for this exercise.");
            int reps = 0;//Console.ReadLine();
            return reps;
        }
        public static Exercise InputSpecificExercise()
        {
            Exercise exercise = new();
            return exercise;
        }
    }
}
