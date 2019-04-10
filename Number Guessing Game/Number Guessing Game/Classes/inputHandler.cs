using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Guessing_Game.Classes;

namespace Number_Guessing_Game.Classes
{
    class InputHandler
    {

        MainMenu mm = new MainMenu();

        public void inputValidator(string choice)
        {

            Game G = new Game();

            if (choice.Equals("Easy", StringComparison.InvariantCultureIgnoreCase))
            {

                G.gameStart(10);

            }
            else if(choice.Equals("medium", StringComparison.InvariantCultureIgnoreCase)) 
            {

                G.gameStart(50);

            }
            else if(choice.Equals("Hard", StringComparison.InvariantCultureIgnoreCase))
            {

                G.gameStart(100);

            }
            else if(choice.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
            {

                Console.WriteLine("Goodbye");

            }
            else
            {

                mm.invalidInput();

            }


        }

        public void EGValidator(string choice)
        {

            if (choice.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {

                mm.Menu();

            }
            else if(choice.Equals("no", StringComparison.InvariantCultureIgnoreCase))
            {



            }
            else
            {



            }

        }

        

    }
}
