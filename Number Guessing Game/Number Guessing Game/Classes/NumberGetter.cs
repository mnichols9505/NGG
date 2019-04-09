using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game.Classes
{
    class NumberGetter
    {

        public void gameStart(int difficulty)
        {

            Random r = new Random();
            int num = r.Next(1, difficulty);
            Console.WriteLine(num);

        }

    }
}
