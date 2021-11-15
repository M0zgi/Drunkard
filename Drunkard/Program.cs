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
        //алгоритм сортировки массива в случайном порядке (методом Фишера – Йетса)
        //public static void Shuffle<T>(T[]  arr)
        //{
        //    Random rand = new Random();

        //    for (int i = arr.Length - 1; i >= 1; i--)
        //    {
        //        int j = rand.Next(i + 1);

        //        T tmp = arr[j];
        //        arr[j] = arr[i];
        //        arr[i] = tmp;
        //    }
        //}

        //public static void Shuffle<T>(T[,] arr)
        //{
        //    Random rand = new Random();

        //    for (int i = arr.GetLength(0) - 1; i >= 1; i--)
        //    {
        //        int k = rand.Next(i + 1);

        //        for (int j = arr.GetLength(1) - 1; i >= 1; i--)
        //        {
        //            T tmp = arr[i][k];
        //            arr[k] = arr[i];
        //            arr[i] = tmp;
        //        }

        //    }
        //}
        static void Main(string[] args)
        {
            DeckOfCards36 deckOfCards36 = new DeckOfCards36();

            Random random = new Random();

            deckOfCards36.FillCard();
            // karta.PrintAllSuit();

            Karta[] arr = new Karta[36];
            int count = 0;

            ArrayList lst = new ArrayList();

            deckOfCards36.Arr(lst);

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        arr[count] = deckOfCards36[i, j]._name + " " + deckOfCards36[i, j]._suit;
            //        count++;
            //    }
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        lst.Add(new Karta(deckOfCards36[i, j]._name, deckOfCards36[i, j]._suit, deckOfCards36[i, j]._weight, deckOfCards36[i, j]._point));

            //        //lst[count]._name = deckOfCards36[i, j]._name;
            //        //lst[count]._suit = deckOfCards36[i, j]._suit;
            //        //lst[count]._weight = deckOfCards36[i, j]._weight;
            //        //count++;
            //    }
            //}

            foreach (var item in lst)
            {
                Console.WriteLine(item);                
            }

            Console.WriteLine(new string ('-', 20));

            //Shuffle(lst.ToArray());

            // lst.Reverse();

            deckOfCards36.Shuffle(lst.ToArray());

            foreach (var item in lst)
            {
                Console.WriteLine(item);                
            }

            //List<Karta> list = new List<Karta>();

            //Dictionary<string, string> openWith = new Dictionary<string, string>();

            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("txt", "paint.exe");

            //foreach (var item in openWith)
            //{
            //    Console.WriteLine(item);
            //}

            //Shuffle(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //try
            //{
            //    Console.WriteLine(karta[10, 67]);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex);
            //}

            //deckOfCards36[10, 67] = "111";


            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine(karta[i, j]);

            //    }

            //}
        }
    }
}
