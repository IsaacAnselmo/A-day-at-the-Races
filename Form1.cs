using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRace
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray;
        Random MyRandomizer = new Random();
        Guy[] GuyArray;
        int indiceGuy;
        public Form1()
        {
            InitializeComponent();
            //declarando e inicializando el arreglo para las imagenes
            GreyhoundArray = new Greyhound[4];
            GreyhoundArray[0] = new Greyhound()
            {
                MypictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RaceTrackLength=raceTrackPictureBox.Width-pictureBox1.Width,
                Randomizer=MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MypictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox2.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MypictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox3.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MypictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox4.Width,
                Randomizer = MyRandomizer
            };
            GuyArray = new Guy[3];
            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyLabel=joeBetLabel,
                MyRadioButton=joeRadioButton
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyLabel=bobBetLabel,
                MyRadioButton=bobRadioButton
            };
            GuyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyLabel=alBetLabel,
                MyRadioButton = alRadioButton
            };
        }

        private void betDo_Click(object sender, EventArgs e)
        {
            
            GuyArray[indiceGuy].PlaceBet(Convert.ToInt32(amountBet.Value),Convert.ToInt32(dogBet.Value));
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorsName.Text = "Joe";
            indiceGuy = 0;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorsName.Text = "Bob";
            indiceGuy = 1;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bettorsName.Text = "Al";
            indiceGuy = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            bool timerStop = false;
            for (int i=0;i<GreyhoundArray.Length;i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                     winner= i+1;
                    timerStop = true;
                    MessageBox.Show("The dog #"+winner+" wins");
                    for (int j = 0; i < GuyArray.Length; i++)
                    {
                        GuyArray[j].Collect(winner);
                    }
                    
                }
            }
            if (timerStop)
            {
                bettingParlor.Enabled = true;
                for (int i = 0; i < GreyhoundArray.Length; i++)
                {
                    GreyhoundArray[i].TakeStartingPosition();
                }
            }
        
            


        }

        private void startRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
            bettingParlor.Enabled = false;
        }
    }
}
