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
            int Age;
            Console.WriteLine("Please enter your age?");
            Age = Convert.ToInt32(Console.ReadLine());
            double BodyWeight;
            Console.WriteLine("Now please enter your bodyweight?");
            BodyWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hi {Name} Welcome to your fitness tracker.");
            Console.WriteLine($"You are currently {Age} and weigh {BodyWeight} Kilograms");
        }
        

    }
}
