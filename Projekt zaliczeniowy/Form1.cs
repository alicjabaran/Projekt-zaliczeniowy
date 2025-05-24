using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_zaliczeniowy
{
    public partial class Form1 : Form
    {
        int rounds = 3, timerround = 10;

        bool gameover = false;

        string[] MistrzChoiceList = { "rock", "paper", "scissor", "paper", "scissor", "rock" };

        int randomNumber = 0;

        Random rnd = new Random();

        string MistrzChoice, GraczChoice;
        int MistrzScore, GraczScore;






        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            GraczChoice = "none";

            TextCountdown.Text = "5";
        }

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            picturePlayer.Image = Properties.Resources.kamień;
            GraczChoice = "rock";
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            picturePlayer.Image = Properties.Resources.nożyce;
            GraczChoice = "scissor";
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            picturePlayer.Image = Properties.Resources.papier;
            GraczChoice = "paper";
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {

        }

        private void TimerCountDown(object sender, EventArgs e)
        {
            timerround -= 1;

            TextCountdown.Text = timerround.ToString();

            textRound.Text = "Runda: " + rounds;

            if (timerround < 1)
            {
                timer.Enabled = false;
                timerround = 10;
                randomNumber = rnd.Next(0, MistrzChoiceList.Length);

                MistrzChoice = MistrzChoiceList[randomNumber];

                switch(MistrzChoice)
                {
                    case "rock":
                        pictureCode.Image = Properties.Resources.kamień;
                        break;

                    case "paper":
                        pictureCode.Image = Properties.Resources.papier;
                        break;

                    case "scissor":
                        pictureCode.Image = Properties.Resources.nożyce;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if(GraczScore > MistrzScore)
                    {
                        MessageBox.Show("Gracz wygrywa.");
                    }

                    else
                    {
                        MessageBox.Show("Mistrz Gry wygrywa.");
                    }

                    gameover = true;
                }

            }



        }

        private void checkGame()
        {
            if (GraczChoice == "rock" && MistrzChoice == "paper")
            {
                MistrzScore += 1;
                rounds -= 1;

                MessageBox.Show("Mistrz Gry wygrywa! Papier bije kamień.");
            }

            else if (GraczChoice == "scissor" && MistrzChoice == "rock")
            {
                MistrzScore += 1;
                rounds -= 1;

                MessageBox.Show("Mistrz Gry wygrywa! Kamień bije nożyce.");
            }

            else if (GraczChoice == "paper" && MistrzChoice == "scissor")
            {
                MistrzScore += 1;
                rounds -= 1;

                MessageBox.Show("Mistrz Gry wygrywa! Nożyce biją papier.");
            }

            else if (GraczChoice == "paper" && MistrzChoice == "rock")
            {
                GraczScore += 1;
                rounds -= 1;

                MessageBox.Show("Wygrywasz! Papier bije kamień.");
            }

            else if (GraczChoice == "rock" && MistrzChoice == "scissor")
            {
                GraczScore += 1;
                rounds -= 1;

                MessageBox.Show("Wygrywasz! Kamień bije nożyce.");
            }

            else if (GraczChoice == "scissor" && MistrzChoice == "paper")
            {
                GraczScore += 1;
                rounds -= 1;

                MessageBox.Show("Wygrywasz! Nożyce biją papier.");
            }

            else if (GraczChoice == "none")
            {
                MessageBox.Show("Wybierz przedmiot.");
            }

            else
            {
                MessageBox.Show("Remis!");
            }

            startNextRound();
        }


        private void startNextRound()
        {
            if (gameover == true)
            {
                return;
            }

            textScore.Text = GraczScore + " - " + MistrzScore;

            GraczChoice = "none";

            timer.Enabled = true;

            picturePlayer.Image = Properties.Resources.puste;
            pictureCode.Image = Properties.Resources.puste;
        }
    }
}
