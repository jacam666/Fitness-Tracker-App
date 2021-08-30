using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker_App
{
    class UI
    {
        public static void UsersNameAgeBodyWeightWelcomeMessage()
        {
            Console.WriteLine("Hi there, please enter your name :");
            string Name;
            Name = Console.ReadLine();
            int Age = new int();
            Age = UsersDateOfBirth(Age);           
            double BodyWeight;
            Console.WriteLine("Now please enter your bodyweight in Kilograms :");
            BodyWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hi {Name} Welcome to your fitness tracker.");
            Console.WriteLine($"You are currently {Age} and weigh {BodyWeight} Kilograms");
        }
        public static int UsersDateOfBirth(int Age)
        {
            DateTime Today = DateTime.Today;
            Console.WriteLine("Please enter you Date Of Birth yyyy, m, dd");
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            var totalDays = (Today - DateOfBirth).TotalDays;
            var totalYears = Math.Truncate(totalDays / 365);

            Console.WriteLine($"you are {totalYears} years of age");
            return Age;
            
        }
    }
}
