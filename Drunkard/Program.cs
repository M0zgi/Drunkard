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
        ////алгоритм сортировки массива в случайном порядке (методом Фишера – Йетса)
        //public static void Shuffle<T>(T[] arr)
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

        static void Main(string[] args)
        {
            DeckOfCards36 deckOfCards36 = new DeckOfCards36();

            DeckOfCards fillCard = deckOfCards36 as DeckOfCards;
            fillCard.Shuffle();

            //foreach (var item in fillCard.AllSuitProperty)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(new string('-', 20));
            Queue myQ = new Queue();
            Queue myQ2 = new Queue();
            
            for (int i = 0; i < fillCard.AllSuitProperty.Count; i += 2)
            {
                myQ.Enqueue(fillCard.AllSuitProperty[i]);
                myQ2.Enqueue(fillCard.AllSuitProperty[i + 1]);
            }

            Console.WriteLine(new string('-', 20));

            foreach (var item in myQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            foreach (var item in myQ2)
            {
                Console.WriteLine(item);
            }

            Karta[] arr = new Karta[2];

            for (int i = 0; i < fillCard.AllSuitProperty.Count/2; i++)
            {
                arr[0] = myQ.Peek() as Karta;
                arr[1] = myQ2.Peek() as Karta;

                bool b = arr[0]._Equals(arr[1]);

                if(b)
                {
                    myQ.Enqueue(myQ.Dequeue());
                    myQ.Enqueue(myQ2.Dequeue());
                }

                else
                {
                    myQ2.Enqueue(myQ2.Dequeue());
                    myQ2.Enqueue(myQ.Dequeue());
                }
            }

            Console.WriteLine(new string('-', 20));

            foreach (var item in myQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            foreach (var item in myQ2)
            {
                Console.WriteLine(item);
            }

            if(myQ.Count > myQ2.Count)
                Console.WriteLine("Победил игрок 1");
            else if (myQ.Count == myQ2.Count)
                Console.WriteLine("Ничья");
            else
                Console.WriteLine("Победил игрок 2");


            //foreach (var item in deckOfCards36.AllSuitProperty)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(new string('-', 20));



            //deckOfCards36.Shuffle();

            //foreach (var item in deckOfCards36.AllSuitProperty)
            //{
            //    Console.WriteLine(item);
            //}

            //deckOfCards36.Shuffle(deckOfCards36.AllSuitProperty.ToArray());

            //Karta[] arr = new Karta[36];
            // arr = deckOfCards36.AllSuitProperty.ToArray();

            //Karta[] arr = new Karta[36];

            //arr = deckOfCards36.AllSuitProperty.ToArray();

            //Shuffle(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //deckOfCards36.Shuffle(arr);


            //foreach (var item in deckOfCards36.AllSuitProperty)
            //{
            //    Console.WriteLine(item);
            //}

            ////deckOfCards36.Shuffle(deckOfCards36.AllSuitProperty.ToArray());
            //Console.WriteLine(new string('-', 20));
            //Shuffle(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //deckOfCards36.AllSuitPropertyS(arr);

            //Console.WriteLine(new string('-', 20));



            // deckOfCards36.PrintAllSuit();

            //List<Karta> kartas = new List<Karta>();

            //deckOfCards36.Arr(ref kartas);

            //foreach (var item in kartas)
            //{
            //    Console.WriteLine(item);
            //}








            //Random random = new Random();


            //deckOfCards36.FillCard();
            // karta.PrintAllSuit();

            // List<Karta> arr = new List<Karta>();
            // (DeckOfCards36)arr = deckOfCards36;

            //Console.WriteLine(deckOfCards36);



            //Karta[] arr = new Karta[36];
            //int count = 0;

            //ArrayList lst = new ArrayList();

            // deckOfCards36.Arr(lst);

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

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);                
            //}

            //Console.WriteLine(new string ('-', 20));

            ////Shuffle(lst.ToArray());

            //// lst.Reverse();

            //deckOfCards36.Shuffle(lst.ToArray());

            //foreach (var item in lst)
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
