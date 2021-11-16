using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drunkard
{
    interface IPlayer
    {       
        string Name { get; set; }
        int Score { get; set; }
        int Winner { get; set; }
    }
    class Player : IPlayer
    {
        public Player(string name, int score = 0, int winner = 0) 
        {
            _name = name;
            _score = score;
            _winner = winner;
        }        
       
        public string Name { get => _name; set { _name = value; } }
        public int Score { get => _score; set { _score = value; } }
        public int Winner { get => _winner; set { _winner = value; } }

        private string _name;
        private int _score;
        private int _winner;

        public Queue PropertyQueue { get; set; }

        //раздача карт на руки каждому игрокуы
        public void QueueOfKatrs(Player player2, IDeckOfCards deckofcards)
        {
            Queue myQ = new Queue();
            Queue myQ2 = new Queue();            

            for (int i = 0; i < deckofcards.AllSuitProperty.Count; i += 2)
            {
                myQ.Enqueue(deckofcards.AllSuitProperty[i]);
                myQ2.Enqueue(deckofcards.AllSuitProperty[i + 1]);
            }

            this.PropertyQueue = myQ;
            player2.PropertyQueue = myQ2;
        }           
    }
}
