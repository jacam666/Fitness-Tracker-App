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
            UI.EnterNewUser();


            List<string> ChestExercises = new();
            ChestExercises.Add("Barbell Bench Press");
            ChestExercises.Add("Incline Barbell Bench");
            ChestExercises.Add("Cable Flyes");
            ChestExercises.Add("Decline Barbell Bench");
            ChestExercises.Add("Dumbbell Flyes");
            ChestExercises.Add("Pec Dec");
            ChestExercises.Add("Cable Crossover");

            List<string> LegExercises = new();
            LegExercises.Add("Barbell Squats");
            LegExercises.Add("Leg Press");
            LegExercises.Add("Leg extensions");
            LegExercises.Add("Hack Squats");
            LegExercises.Add("Walking Lunges");
            LegExercises.Add("Pec Dec");
            LegExercises.Add("Lying Leg Curl");

            List<string> BackExercises = new();
            BackExercises.Add("Barbell Row");
            BackExercises.Add("Cable Lat Pulldown");
            BackExercises.Add("Close grip Cable Pulldown");
            BackExercises.Add("Single Arm Dumbbell row");
            BackExercises.Add("Machine Back extension");
            BackExercises.Add("Seated Cable row");

            List<string> ShoulderExercises = new();
            ShoulderExercises.Add("Barbell Press");
            ShoulderExercises.Add("Dumbbell Press");
            ShoulderExercises.Add("Dumbbell side raises");
            ShoulderExercises.Add("Dumbbell Front raises");
            ShoulderExercises.Add("Reverse Pec Dec");
            ShoulderExercises.Add("Barbell Shrugs");
            ShoulderExercises.Add("Cable Upright Rows");

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

            User currentUser = new User();

            BodyPart SelectedBodyPart = UI.SelectBodyPart();
            string SpecificExercise="";

            if (SelectedBodyPart == BodyPart.Chest)
            {
                UI.PrintSpecificWorkoutOptions(ChestExercises);
                 //SpecificExercise = UI.InputSpecificExercise();
            }
            if (SelectedBodyPart == BodyPart.Arms)
            {
                UI.PrintSpecificWorkoutOptions(ArmExercises);
                //SpecificExercise = UI.InputSpecificExercise();
            }

            //get sets and reps
            var ex = new Workout();
            ex.ExerciseName = SpecificExercise;
            //ex.AmountOfSets = UI.InputSets();
            //ex.AmountOfReps = UI.InputReps();

            //is it still the same day?
            var td = new TrainingDay();
            td.TodaysDate = DateTime.Now;
            td.Workouts.Add(ex);

            //last question:
            td.BodyWeight = UI.EnterBodyweight();

            currentUser.TrainingDays.Add(td);

            //xml serialize the currentUser object to a file

            UI.EnterNewUser();
            UI.UsersBodyPartChoice();
            UI.TodaysSessionDetails();
            //UI.RepsSetsCompleted();
        }
        public static void TraingDay()
        {
            DateTime Today = DateTime.Today;
            double Bodyweight;
            Bodyweight = UI.EnterBodyweight();
        }
        public static void Exercise()
        {
            UI.UsersBodyPartChoice();
            //bool BodyPart = UI.SelectBodyPart();
        }
        public static void User()
        {
            string FirstName;
            string LastName;
            DateTime DOB;
            DateTime Today = DateTime.Today;
            UI.EnterDateOfBirth();
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            double totalDays = (Today - DateOfBirth).TotalDays;
            double totalYears = totalDays / 365;
        }




        //public static void DateOfBirth()
        //{
        //    DateTime Today = DateTime.Today;
        //    DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
        //    double totalDays = (Today - DateOfBirth).TotalDays;
        //    double totalYears = totalDays / 365;
        //}

    }




}
