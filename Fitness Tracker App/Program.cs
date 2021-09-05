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
            UI.UsersBodyPartChoice();
            UI.TodaysSessionDetails();
            UI.RepsSetsCompleted();
        }
        public static void TraingDay()
        {
            DateTime Today = DateTime.Today;
            double Bodyweight;
            Bodyweight = UI.UsersBodyweight();
        }
        public static void Exercise()
        {
            UI.UsersBodyPartChoice();
            bool BodyPart = UI.UsersWorkoutChoice();
        }
        public static void User()
        {
            string FirstName;
            string LastName;
            DateTime DOB;
            DateTime Today = DateTime.Today;
            UI.UsersDateOfBirth();
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
