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
        string Name { get; }
        int Score { get; set; }
    }
    class Player : IPlayer
    {
        public Player(string name, int score = 0) 
        {
            _name = name;
            _score = score;
        }        
       
        public string Name { get => _name; }
        public int Score { get => _score; set { _score = value; } }        
       
        private string _name;
        private int _score;

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
