using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCSchp06ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardRank = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            string [] colors = { "Spades", "Hearts", "Clubs", "Diamonds" };

            
            foreach (var rank in cardRank)
            {
                foreach (var color in colors)
                {
                    Console.WriteLine(rank + " of " + color);
                }
            }

        }

     }
 }

