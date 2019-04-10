using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Guessing_Game.Classes;

namespace Number_Guessing_Game.Classes
{
    class Game
    {

        int score;
        int attempt;

        public void gameStart(int dif)
        {

            Console.WriteLine("Please Make a guess");
            Random rn = new Random();
            int num = rn.Next(1, dif);
            
            string guess = Console.ReadLine();
            guessHandler(guess, num, dif);

        }

        public void guessChecker(int guess, int rn, int dif)
        {

            if (guess == rn)
            {

                score++;
                attempt++;

                Console.WriteLine("You guessed correctly your score is" + " : " + score);

                AttemptChecker(dif, attempt);

            }
            else if(guess < rn)
            {

                attempt++;
                Console.WriteLine("Too low Your Score" + " : " + score);
                AttemptChecker(dif, attempt);

            }
            else
            {

                attempt++;
                
                Console.WriteLine("Too High Your Score" + " : " + score);
                AttemptChecker(dif, attempt);

            }

        }

        public void AttemptChecker(int dif, int att)
        {

            if(att < 5)
            {

                EndGame(dif);

            }
            else if(att == 5)
            {

                MainMenu mm = new MainMenu();
                mm.EndGame(score);

            }

        }

        public void EndGame(int dif)
        {

            Console.WriteLine("Do you Wish to continue");
            Console.WriteLine("Yes or no");
            string choice = Console.ReadLine();
            
            if(choice.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {

                gameStart(dif);

            }
            else if(choice.Equals("no", StringComparison.InvariantCultureIgnoreCase))
            {

                MainMenu mm = new MainMenu();
                mm.EndGame(score);

            }
            else
            {

                EndGame(dif);

            }

        }

        public void guessHandler(string guess, int rn, int dif)
        {

            try
            {

                int guessInt = Int32.Parse(guess);
                Game g = new Game();
                guessChecker(guessInt, rn, dif);

            }
            catch (FormatException e)
            {

                Console.WriteLine("Invalid Input");
                gameStart(dif);

            }


        }

    }
}
