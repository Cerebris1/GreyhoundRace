using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyhoundRace
{
    public class Bet
    {
        public int Amount { get; set; } // The amount of cash that was bet  
        public int Tortoise { get; set; } // The number of the Tortoise the bet is on
        public Punter Bettor { get; set; } // The punter who placed the bet

        public string GetDescription() // Return a string that says who placed the bet, how much it was, who the Tortoise was
        {
            string description = Bettor.Name + " bet $" + Amount + " on Tortoise " + (Tortoise + 1);
            return description;
            //If amount is zero no bet is placed
        }

        public int PayOut(int winner) // The parameter is the winner of the race, if the dog won, return the amount bet otherwise return negative amount bet
        {
            if (winner == Tortoise)
            {
                return Amount;
            }
            else
            {
                return -1 * Amount;
            }

        }

    }
}
