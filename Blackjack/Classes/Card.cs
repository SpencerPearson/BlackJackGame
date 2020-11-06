using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes;

namespace Blackjack
{
    public class Card
    {
        //fields
        //props
        public Suit Suit { get; set; }
        public Value Value { get; set; }
        public int Score { get; set; }
        public char Number { get; set; }
        //ctors
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;


        }
        //methods
    }
}
