﻿using Fitness_Tracker_App.Data;
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

            User testUser = UI.EnterNewUser();

            Console.WriteLine($"Hello {testUser.FirstName}{testUser.LastName} Welcome to your Fitness Tracker.");


        }      

    }
}
