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

            {            
                DateTime Today = DateTime.Today;  
                Console.WriteLine("Please enter you Date Of Birth yyyy, m, dd");
                DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                var totalDays = (Today - DateOfBirth).TotalDays;
                var totalYears = Math.Truncate(totalDays / 365);
               
                Console.WriteLine($"you are {totalYears} years of age");
            }
        }
        
        
        

        

    }
}
