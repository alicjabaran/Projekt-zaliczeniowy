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
        int rounds = 3, timerround = 7;

        bool gameover = false;

        string[] MistrzChoiceList = { "Kamień", "Papier", "Nożyce", "Papier", "Nożyce", "Kamień" };

        int randomNumber = 0;

        Random rnd = new Random();

        string MistrzChoice, GraczChoice;
        int MistrzScore, GraczScore;



        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            GraczChoice = "none";

            TextCountdown.Text = "7";


            /*Tabela rozgrywek*/

            listViewHistory.Columns.Add("Gracz", 80);
            listViewHistory.Columns.Add("Mistrz", 80);
            listViewHistory.Columns.Add("Wynik", 80);

            listViewHistory.View = View.Details;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            picturePlayer.Image = Properties.Resources.kamień;
            GraczChoice = "Kamień";

        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            picturePlayer.Image = Properties.Resources.nożyce;
            GraczChoice = "Nożyce";

            
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            picturePlayer.Image = Properties.Resources.papier;
            GraczChoice = "Papier";

            
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            /*Reset gier*/ 

            GraczScore = 0;
            MistrzScore = 0;
            rounds = 3;

            textScore.Text = GraczScore + " - " + MistrzScore;

            GraczChoice = "none";

            timer.Enabled = true;

            picturePlayer.Image = Properties.Resources.puste;
            pictureCode.Image = Properties.Resources.puste;

            gameover = false;

            listViewHistory.Items.Clear();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextCountdown_Click(object sender, EventArgs e)
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
                timerround = 7;
                randomNumber = rnd.Next(0, MistrzChoiceList.Length);

                MistrzChoice = MistrzChoiceList[randomNumber];

                switch(MistrzChoice)
                {
                    case "Kamień":
                        pictureCode.Image = Properties.Resources.kamień;
                        break;

                    case "Papier":
                        pictureCode.Image = Properties.Resources.papier;
                        break;

                    case "Nożyce":
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

            /*Komentarze wyników*/


            if (GraczChoice == "Kamień" && MistrzChoice == "Papier")
            {
                MistrzScore += 1;
                rounds -= 1;

                MessageBox.Show("Mistrz Gry wygrywa! Papier bije kamień.");


                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Przegrana"); 

                listViewHistory.Items.Add(item);
            }

            else if (GraczChoice == "Nożyce" && MistrzChoice == "Kamień")
            {
                MistrzScore += 1;
                rounds -= 1;

                MessageBox.Show("Mistrz Gry wygrywa! Kamień bije nożyce.");

                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Przegrana"); 

                listViewHistory.Items.Add(item);
            }

            else if (GraczChoice == "Papier" && MistrzChoice == "Nożyce")
            {
                MistrzScore += 1;
                rounds -= 1;

                MessageBox.Show("Mistrz Gry wygrywa! Nożyce biją papier.");

                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Przegrana"); 

                listViewHistory.Items.Add(item);
            }

            else if (GraczChoice == "Papier" && MistrzChoice == "Kamień")
            {
                GraczScore += 1;
                rounds -= 1;

                MessageBox.Show("Wygrywasz! Papier bije kamień.");

                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Wygrana"); 

                listViewHistory.Items.Add(item);
            }

            else if (GraczChoice == "Kamień" && MistrzChoice == "Nożyce")
            {
                GraczScore += 1;
                rounds -= 1;

                MessageBox.Show("Wygrywasz! Kamień bije nożyce.");

                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Wygrana"); 

                listViewHistory.Items.Add(item);
            }

            else if (GraczChoice == "Nożyce" && MistrzChoice == "Papier")
            {
                GraczScore += 1;
                rounds -= 1;

                MessageBox.Show("Wygrywasz! Nożyce biją papier.");

                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Wygrana"); 

                listViewHistory.Items.Add(item);
            }

            else if (GraczChoice == "none")
            {
                MessageBox.Show("Wybierz przedmiot.");
            }

            else
            {
                MessageBox.Show("Remis!");

                ListViewItem item = new ListViewItem(GraczChoice);
                item.SubItems.Add(MistrzChoice);
                item.SubItems.Add("Remis"); 

                listViewHistory.Items.Add(item);
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
