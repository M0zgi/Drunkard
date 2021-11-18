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
    enum PointKart
    {
        Six = 6,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 2,
        Queen,
        King,
        Ace = 11
    }

    enum WeihgtKart
    {
        Six=6,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    interface IDeckOfCards
    {
        //создание колоды карт
        void FillCard();

        //тусовка колоды
        void Shuffle();
        
        //свой-во доступа к карте в колоде
        List<Karta> AllSuitProperty { get; }
    }

    interface IKarta
    {
        //сравнение карт
        bool _Equals(Karta karta);
    }

    class Karta: IKarta
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

        //static public string NAME_6 { get => "Шестерка"; }
        //static public string NAME_7 { get => "Семерка"; }
        //static public string NAME_8 { get => "Восьмерка"; }
        //static public string NAME_9 { get => "Девятка"; }
        //static public string NAME_10 { get => "Десятка"; }
        //static public string NAME_Jack { get => "Валет"; }
        //static public string NAME_Queen { get => "Дама"; }
        //static public string NAME_King { get => "Король"; }
        //static public string NAME_Ace { get => "Туз"; }
        //
        public static readonly string NAME_6;
        public static readonly string NAME_7;
        public static readonly string NAME_8;
        public static readonly string NAME_9;
        public static readonly string NAME_10;
        public static readonly string NAME_Jack;
        public static readonly string NAME_Queen;
        public static readonly string NAME_King;
        public static readonly string NAME_Ace;

        static Karta()
        {
            NAME_6 = "Шестерка";
            NAME_7 = "Семерка";
            NAME_8 = "Восьмерка";
            NAME_9 = "Девятка";
            NAME_10 = "Десятка";
            NAME_Jack = "Валет";
            NAME_Queen = "Дама";
            NAME_King = "Король";
            NAME_Ace = "Туз";
        }
        public override string ToString()
        {
            return $"Имя карты { _name}, Масть {_suit}, Количество очков {_point}";
        }

        public bool _Equals(Karta karta)
        {
            if (this._weight == karta._weight)
            {
                Random random = new Random();
                this._weight = random.Next(0, 100);
                karta._weight = random.Next(0, 100);
            }

            if (this._weight > karta._weight)
                return true;
            else
                return false;
        }
    }

    class DeckOfCards36: IDeckOfCards
    {
        //кол-во различных наименований карт в колоде
        private int AMOUNT_NAME_KART = Enum.GetNames(typeof(NameKart)).Length;//9

        //кол-во мастей в колоде
        private int AMOUNT_SUIT = Enum.GetNames(typeof(SuitKart)).Length;//4
        
        public DeckOfCards36()
        {
            this.FillCard();         
        }

        private List<Karta> AllSuit = new List<Karta>();
        public List<Karta> AllSuitProperty { get => AllSuit; }       

        public void FillCard()
        {
            //suite - масть карты
            string suite = null;
           
            for (int i = 0; i < AMOUNT_NAME_KART; i++)
            {
                for (int j = 0; j < AMOUNT_SUIT; j++)
                {  
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
                        var karta = new Karta(Karta.NAME_6, suite, (int)WeihgtKart.Six, (int)PointKart.Six);
                        AllSuit.Add(karta);                        
                    }

                    if (i == (int)NameKart.Seven)
                    {
                        var karta = new Karta(Karta.NAME_7, suite, (int)WeihgtKart.Seven, (int)PointKart.Seven);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Eight)
                    {
                        var karta = new Karta(Karta.NAME_8, suite, (int)WeihgtKart.Eight, (int)PointKart.Eight);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Nine)
                    {
                        var karta = new Karta(Karta.NAME_9, suite, (int)WeihgtKart.Nine, (int)PointKart.Nine);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Ten)
                    {
                        var karta = new Karta(Karta.NAME_10, suite, (int)WeihgtKart.Ten, (int)PointKart.Ten);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Jack)
                    {
                        var karta = new Karta(Karta.NAME_Jack, suite, (int)WeihgtKart.Jack, (int)PointKart.Jack);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Queen)
                    {
                        var karta = new Karta(Karta.NAME_Queen, suite, (int)WeihgtKart.Queen, (int)PointKart.Queen);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.King)
                    {
                        var karta = new Karta(Karta.NAME_King, suite, (int)WeihgtKart.King, (int)PointKart.King);
                        AllSuit.Add(karta);
                    }

                    if (i == (int)NameKart.Ace)
                    {
                        var karta = new Karta(Karta.NAME_Ace, suite, (int)WeihgtKart.Ace, (int)PointKart.Ace);
                        AllSuit.Add(karta);
                    }
                }
            }
        }       

        //алгоритм сортировки массива в случайном порядке(методом Фишера – Йетса)
        public void Shuffle()
        {
            Random rand = new Random();
           
            for (int i = this.AllSuit.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                var tmp = this.AllSuit[j];
                this.AllSuit[j] = this.AllSuit[i];
                this.AllSuit[i] = tmp;
            }           
        }        
    }       
}


//Karta karta;

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


//public void Arr(ref List<Karta> lst)
//{
//    lst = this.AllSuit;
//}

//public override string ToString()
//{
//    return $"Имя карты { karta._name}, Масть {karta._suit}, Количество очков {karta._point}";
//}

////шаблонный вариант сортировки
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