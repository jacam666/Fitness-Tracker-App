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

            UI.TodaysSessionDetails();
            UI.RepsSetsCompleted();

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
