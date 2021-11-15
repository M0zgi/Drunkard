using System;
using System.Collections;
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
    interface IFillCard
    {
        void FillCard();
    }

    class Karta
    {        
        public Karta(string name, string suit, int weihgt, int point)
        {
            _name = name;
            _suit = suit;
            _weight = weihgt;
            _point = point;
        }
        //имя карты
        public string _name { get; set; }

        //масть карты
        public string _suit { get; set; }

        //вес карты
        public int _weight { get; set; }

        //количество очков
        public int _point { get; set; }

        static public string NAME_6 { get => "Шестерка"; }
        static public string NAME_7 { get => "Семерка"; }
        static public string NAME_8 { get => "Восьмерка"; }
        static public string NAME_9 { get => "Девятка"; }
        static public string NAME_10 { get => "Десятка"; }
        static public string NAME_Jack { get => "Валет"; }
        static public string NAME_Queen { get => "Дама"; }
        static public string NAME_King { get => "Король"; }
        static public string NAME_Ace { get => "Туз"; }      

        public override string ToString()
        {
            return $"Имя карты { _name}, Масть {_suit}, Количество очков {_point}";
        }

    }

    class DeckOfCards36: IFillCard

    {
        public DeckOfCards36()
        {
            this.FillCard();
        }

        Karta karta;

        private List<Karta> AllSuit = new List<Karta>();

        public List<Karta> AllSuitProperty { get => AllSuit; }
       // public List<Karta> AllSuitPropertyS(Karta[] arr) { this.AllSuit = arr; }

        public void FillCard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {           
                    string suite = null;
                    if (j == 0)
                        suite = "(трефа)";
                    if (j == 1)
                        suite = "(бубна)";
                    if (j == 2)
                        suite = "(чирва)";
                    if (j == 3)
                        suite = "(пика)";
                     

                    if (i == (int)NameKart.Six)
                    {                        
                        karta = new Karta(Karta.NAME_6, suite, 6, 6);
                        AllSuit.Add(karta);                        
                    }

                    if (i == (int)NameKart.Seven)
                    {
                        karta = new Karta(Karta.NAME_7, suite, 7, 7);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Eight)
                    {
                        karta = new Karta(Karta.NAME_8, suite, 8, 8);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Nine)
                    {
                        karta = new Karta(Karta.NAME_9, suite, 9, 9);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Ten)
                    {
                        karta = new Karta(Karta.NAME_10, suite, 10, 10);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Jack)
                    {
                        karta = new Karta(Karta.NAME_Jack, suite, 11, 2);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Queen)
                    {
                        karta = new Karta(Karta.NAME_Queen, suite, 12, 3);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.King)
                    {
                        karta = new Karta(Karta.NAME_King, suite, 13, 4);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Ace)
                    {
                        karta = new Karta(Karta.NAME_Ace, suite, 15, 11);
                        AllSuit.Add(karta);
                    }
                }
            }
        }

        public void Arr(ref List<Karta> lst)
        {
            lst = this.AllSuit;
        }

        public override string ToString()
        {
            return $"Имя карты { karta._name}, Масть {karta._suit}, Количество очков {karta._point}";
        }

        //public void Shuffle<T>(T[] arr)
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

        ////рабочий вариант
        //public void Shuffle<T>(T[] arr)
        //{
        //    Random rand = new Random();

        //    for (int i = arr.Length - 1; i >= 1; i--)
        //    {
        //        int j = rand.Next(i + 1);

        //        T tmp = arr[j];
        //        arr[j] = arr[i];
        //        arr[i] = tmp;
        //    }

        //    //AllSuit = arr as List<Karta>;
        //}

        public void Shuffle()
        {
            Random rand = new Random();

            List<Karta> tmp = new List<Karta>();

            for (int i = this.AllSuit.Count; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                tmp = this.AllSuit[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }

            //AllSuit = arr as List<Karta>;
        }
    }
}


// //реализация заполнения колоды карт в двумерный массив и доступ к полям объекта класса
// private Karta[,] AllSuit = new Karta[9, 4];

////Индексатор
//public Karta this[int col, int row]
//{
//    get //Аксессор
//    {
//        var w = AllSuit.GetLength(0);
//        var h = AllSuit.GetLength(1);
//        if (col >= 0 && col < w && row >= 0 && row < h)
//            return AllSuit[col, row];
//        else
//            return karta = new Karta("Неизвестная карта", "", 0, 0);
//    }

//    set //Мутатор
//    {
//        var w = AllSuit.GetLength(0);
//        var h = AllSuit.GetLength(1);
//        if (col >= 0 && col < w && row >= 0 && row < h)
//            AllSuit[col, row] = value;
//        else
//            Console.WriteLine("Выход за пределы массива");
//    }
//}