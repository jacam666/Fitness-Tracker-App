using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker_App
{
    class UI
    {
        public static void UsersNameWelcomeMessage()
        {
            Console.WriteLine("Hi there, please enter your name :");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine($"Hi {Name},Welcome to your fitness tracker.");
        }
        

    }
}
