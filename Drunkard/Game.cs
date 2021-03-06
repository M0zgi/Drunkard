using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunkard
{
    class Game 
    {
        //координаты для вывода в консоли значений карт колоды
        public int coordinationX1 { get; }
        public int coordinationX2 { get; set; }
        public int coordinationY{ get; set; }

        public Game()
        {
            coordinationX1 = 0;
            coordinationX2 = 60;
            coordinationY = 0;
        }
        
        public void GameBegin()
        {
            //создаем игроков
            Player player1 = new Player("Иван Петрович");
            Player player2 = new Player("Раиса Захаровна");

            //создаем колоду на 36 карт
            DeckOfCards36 deckOfCards36 = new DeckOfCards36();
            IDeckOfCards fillCard = deckOfCards36 as IDeckOfCards;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Текущая колода карт");
            Console.ResetColor();

            foreach (var item in fillCard.AllSuitProperty)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(new string('-', 20));

            //тусуем карты
            fillCard.Shuffle();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(coordinationX2, coordinationY);
            Console.WriteLine("Тусованная колода карт");
            Console.ResetColor();
            foreach (var item in fillCard.AllSuitProperty)
            {                
                Console.SetCursorPosition(coordinationX2, coordinationY += 1);
                Console.WriteLine(item);
            }

            //делим карты между игроками поровну
            player1.QueueOfKatrs(player2, fillCard);

            Console.WriteLine(new string('-', 20));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Колода карт {player1.Name}");
            Console.ResetColor();
            foreach (var item in player1.PropertyQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(coordinationX2, coordinationY += 2);
            Console.WriteLine($"Колода карт {player2.Name}");
            Console.ResetColor();
            foreach (var item in player2.PropertyQueue)
            {
                Console.SetCursorPosition(coordinationX2, coordinationY += 1);
                Console.WriteLine(item);
            }

            //Битва титанов
            Karta[] arr = new Karta[2];

            //Так как игрока 2 карты поделены поровну. Итерируемся в сравнении по общему кол-ву карт в колоде / 2
            for (int i = 0; i < fillCard.AllSuitProperty.Count / 2; i++)
            {
                
                //помещаем в массив верхние карты каждого игрока
                arr[0] = player1.PropertyQueue.Peek() as Karta;
                arr[1] = player2.PropertyQueue.Peek() as Karta;

                //сравнение карт игроков по весу _weight
                bool b = arr[0]._Equals(arr[1]);

                if (b)
                {
                    //удаляем первую карту игрока в очереди и ставим ее в конец очереди
                    player1.PropertyQueue.Enqueue(player1.PropertyQueue.Dequeue());
                    //удаляем первую карту игрока 2 в очереди и ставим ее в конец очереди игроку 1
                    player1.PropertyQueue.Enqueue(player2.PropertyQueue.Dequeue());
                    //увеличиваем кол-во очков у игрока по значениям очков выигранных карт
                    player1.Score += arr[0]._point + arr[1]._point;
                }

                else
                {
                    //удаляем первую карту игрока 2 в очереди и ставим ее в конец очереди
                    player2.PropertyQueue.Enqueue(player2.PropertyQueue.Dequeue());
                    //удаляем первую карту игрока 1 в очереди и ставим ее в конец очереди игроку 2
                    player2.PropertyQueue.Enqueue(player1.PropertyQueue.Dequeue());
                    //увеличиваем кол-во очков у игрока по значениям очков выигранных карт
                    player2.Score += arr[0]._point + arr[1]._point;
                }
            }

            Console.WriteLine(new string('-', 20));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Колода карт после игры у {player1.Name}: {player1.PropertyQueue.Count}");
            Console.ResetColor();
            foreach (var item in player1.PropertyQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(coordinationX2, coordinationY += 2);
            Console.WriteLine($"Колода карт после игры у {player2.Name} : {player2.PropertyQueue.Count}");
            Console.ResetColor();

            foreach (var item in player2.PropertyQueue)
            {
                Console.SetCursorPosition(coordinationX2, coordinationY += 1);
                Console.WriteLine(item);
            }

            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(coordinationX1 + 20, coordinationY += 14);
            Console.Write("Результат: ");

            if (player1.PropertyQueue.Count > player2.PropertyQueue.Count)
            {
                player1.Winner++;
                Console.WriteLine($"Победил игрок {player1.Name}, Кол-во карточных очков: {player1.Score}, Кол-во побед: {player1.Winner}");                
            }

            else if (player1.PropertyQueue.Count == player2.PropertyQueue.Count)
            {
                Console.WriteLine("Ничья");
            }

            else
            {
                player2.Winner++;
                Console.WriteLine($"Победил игрок {player2.Name}, Кол-во карточных очков: {player2.Score}, Кол-во побед: {player2.Winner}");
            }
            Console.ResetColor();           
        }        
    }
}