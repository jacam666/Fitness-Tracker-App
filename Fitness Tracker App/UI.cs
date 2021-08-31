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
        //public static void UsersNameAgeBodyWeightWelcomeMessage()
        //{
        //    Console.WriteLine("Hi there, please enter your name :");
        //    string Name;
        //    Name = Console.ReadLine();
        //    double Age = new();
        //    Age = UsersDateOfBirth();           
        //    double BodyWeight;
        //    Console.WriteLine("Now please enter your bodyweight in Kilograms :");
        //    BodyWeight = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine($"Hi {Name}Welcome to your fitness tracker.");

       
            
        //    Console.WriteLine($"You are currently {String.Format("{0:0.#}", Age)} years old and weigh {BodyWeight} Kilograms");
        //}

        internal static User EnterNewUser()
        {
            User u = new User();
            Console.WriteLine("Please Enter your First name :");
            u.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter your last name");
            u.LastName = Console.ReadLine();

            //get all the data

            return u;
        }

        //public static double UsersDateOfBirth()
        //{
        //    DateTime Today = DateTime.Today;
        //    Console.WriteLine("Please enter you Date Of Birth yyyy, m, dd");
        //    DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
        //    double totalDays = (Today - DateOfBirth).TotalDays;
        //    double totalYears = totalDays / 365;


        //    Console.WriteLine($"you are {totalYears} years of age");
        //    return totalYears;
            
        //}
    }
}
