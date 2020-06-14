using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has $" + Cash;
            
        }

        public void ClearBet()
        {
            MyBet.amount = 0;
            UpdateLabels();
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            
            if (this.Cash >= BetAmount)
            {
                
                MyBet = new Bet()
                {
                    amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                
                UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show("You don't have enough money");
                return false;
            }
            
        }

        public void Collect(int Winner)
        {
            this.Cash+=MyBet.PayOut(Winner);
            ClearBet();
        }

    }
}
