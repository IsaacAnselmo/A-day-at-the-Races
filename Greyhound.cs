using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
    public class Greyhound
    {
        //clase para control de los persos y su carrera
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MypictureBox = null;
        public int Location = 0 ;
        public Random Randomizer;

        public bool Run()
        {
        
            Location += Randomizer.Next(1, 5);
            MypictureBox.Left = StartingPosition + Location;
            if (MypictureBox.Left >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MypictureBox.Left = StartingPosition;
        }


    }
}
