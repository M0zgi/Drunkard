using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drunkard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Карточная игра \" Пьяница\"";

            Game game = new Game();

            game.GameBegin();

            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
