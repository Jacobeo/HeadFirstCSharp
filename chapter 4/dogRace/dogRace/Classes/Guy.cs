using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
    class Guy
    {
        public String Name;
        public Bet MyBet;
        public int Cash;

        //GUI
        public RadioButton MyRadioButton;
        public Label MyLabel;
    
        public void UpDateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + "has" + Cash + "Bucks";
        }

        public void ClearBet()
        {
            //TODO
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //TODO: amount and dog must be taken from form
            MyBet = new Bet() {Amount = Amount, Dog = Dog};
            
            if (Cash >= Amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect (int Winner)
        {
            Cash = MyBet.PayOut(Winner);

        }
    
    }
}
