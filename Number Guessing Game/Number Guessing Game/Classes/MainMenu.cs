﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Guessing_Game.Classes;

namespace Number_Guessing_Game.Classes
{
    class MainMenu
    {

        public void Menu()
        {

            string choice;

            Console.WriteLine("Welcome To the Number Guessing Game");
            Console.WriteLine("Choose a gamemode");
            Console.WriteLine("Easy = 1-10");
            Console.WriteLine("Medium = 1-50");
            Console.WriteLine("Hard = 1-100");
            Console.WriteLine("Exit");
            choice = Console.ReadLine();

            inputHandler ih = new inputHandler();
            ih.inputValidator(choice);

        }

        public void invalidInput()
        {

            string choice;

            Console.WriteLine("That was bad input try again");
            Console.WriteLine("Welcome To the Number Guessing Game");
            Console.WriteLine("Choose a gamemode");
            Console.WriteLine("Easy = 1-10");
            Console.WriteLine("Medium = 1-50");
            Console.WriteLine("Hard = 1-100");
            Console.WriteLine("Exit");
            choice = Console.ReadLine();

            inputHandler ih = new inputHandler();
            ih.inputValidator(choice);

        }

    }

}
