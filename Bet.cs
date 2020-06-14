using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
    public class Bet
    {
        public int amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            
            if (amount > 0)
            {
                return Bettor.Name + " bets " + amount + " on dog #" + Dog;
                
            }
            else
            {
                return Bettor.Name + " hasn't placed a bet";
            }
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return amount;
            }
            else
            {
                return amount * -1;
            }
        }

    }
}
