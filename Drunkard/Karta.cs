using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunkard
{
    //♣️ Трефы — clubs
    //♦️ Бубны — diamonds
    //♥️ Червы — hearts
    //♠️ Пики — spades
    enum NameKart
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    enum SuitKart
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    class Karta
    {
        private string [,]AllSuit = new string[9 , 4];

        //Индексатор
        public string this[int col, int row]
        {
            get //Аксессор
            {
                var w = AllSuit.GetLength(0); 
                var h = AllSuit.GetLength(1);
                if (col >= 0 && col < w && row >= 0 && row < h)
                    return AllSuit[col, row];
                else
                    return "Выход за пределы массива";     
            }
            
            set //Мутатор
            {
                var w = AllSuit.GetLength(0);
                var h = AllSuit.GetLength(1);
                if (col >= 0 && col < w && row >= 0 && row < h)
                    AllSuit[col, row] = value;
                else
                    Console.WriteLine("Выход за пределы массива");
            }
        }

        public string Name { get; set; }
        public string Suit { get; set; }

        //вес карты
        public int Weight { get; set; }

        public void FillCard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //NameKart Name = (NameKart)Enum.GetValues(typeof(NameKart)).GetValue(i);
                   // SuitKart Suit = (SuitKart)Enum.GetValues(typeof(SuitKart)).GetValue(j);

                    AllSuit[i, j] = (NameKart)Enum.GetValues(typeof(NameKart)).GetValue(i) + " " + (SuitKart)Enum.GetValues(typeof(SuitKart)).GetValue(j);

                    if(j == 0)
                        AllSuit[i, j] += " (трефа)";
                    if (j == 1)
                        AllSuit[i, j] += " (бубна)";
                    if (j == 2)
                        AllSuit[i, j] += " (чирва)";
                    if (j == 3)
                        AllSuit[i, j] += " (пика)";

                }

            }
        }

        public void PrintAllSuit()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {                    
                    Console.WriteLine(AllSuit[i, j]);          
                }
            }
        }

     

    }
}
