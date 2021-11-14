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
        public static void Shuffle<T>(T[] arr)
        {
            Random rand = new Random();

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
        static void Main(string[] args)
        {
            Karta karta = new Karta();

            Random random = new Random();

            karta.FillCard();
            // karta.PrintAllSuit();

            string[] arr = new string [36];
            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[count] = karta[i, j];
                    count++;
                }
            }

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

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

            karta[10, 67] = "111";


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
