using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
   public class greyHound
    {
        public int StartingPosition;
        public int RaceTrackLenght;
       // public PictureBox MyPictureBox = null;
       //public int HoundNumber;
        public int Location;
        public Random Randomizer;


        public bool Run()
        {
            Location = Location + Randomizer.Next(1, 5);

            //TODO: update location on picturebox
          //  Point p = MyPictureBox.Location;
            //p.X += distance;
            //MyPictureBox.Location = p;


            if (Location >= RaceTrackLenght)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void TakeStartingPOsition()
        {
            StartingPosition = 0;
        }
    }
}
