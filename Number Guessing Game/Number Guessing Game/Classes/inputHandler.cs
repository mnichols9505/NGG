using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Guessing_Game.Classes;

namespace Number_Guessing_Game.Classes
{
    class inputHandler
    {

        public void inputValidator(string choice)
        {
            
            NumberGetter rm = new NumberGetter();

            if (choice.Equals("Easy", StringComparison.InvariantCultureIgnoreCase))
            {

                rm.gameStart(10);

            }
            else if(choice.Equals("medium", StringComparison.InvariantCultureIgnoreCase)) 
            {

                rm.gameStart(50);

            }
            else if(choice.Equals("Hard", StringComparison.InvariantCultureIgnoreCase))
            {

                rm.gameStart(100);

            }
            else if(choice.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
            {

                Console.WriteLine("Goodbye");

            }
            else
            {

                MainMenu mm = new MainMenu();
                mm.invalidInput();

            }


        }

    }
}
