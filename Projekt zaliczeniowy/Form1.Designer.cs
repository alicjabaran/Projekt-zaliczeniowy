﻿namespace Projekt_zaliczeniowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.pictureCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextCountdown = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listViewHistory = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCode)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(120, 395);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(122, 28);
            this.buttonPaper.TabIndex = 0;
            this.buttonPaper.Text = "Papier";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(341, 395);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(122, 28);
            this.buttonRock.TabIndex = 1;
            this.buttonRock.Text = "Kamień";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(563, 395);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(122, 28);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Text = "Nożyce";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(341, 261);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(122, 28);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // picturePlayer
            // 
            this.picturePlayer.Image = global::Projekt_zaliczeniowy.Properties.Resources.puste;
            this.picturePlayer.Location = new System.Drawing.Point(68, 114);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(174, 175);
            this.picturePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer.TabIndex = 4;
            this.picturePlayer.TabStop = false;
            // 
            // pictureCode
            // 
            this.pictureCode.Image = global::Projekt_zaliczeniowy.Properties.Resources.puste;
            this.pictureCode.Location = new System.Drawing.Point(563, 114);
            this.pictureCode.Name = "pictureCode";
            this.pictureCode.Size = new System.Drawing.Size(174, 175);
            this.pictureCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCode.TabIndex = 5;
            this.pictureCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gracz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textRound
            // 
            this.textRound.AutoSize = true;
            this.textRound.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRound.Location = new System.Drawing.Point(369, 215);
            this.textRound.Name = "textRound";
            this.textRound.Size = new System.Drawing.Size(67, 16);
            this.textRound.TabIndex = 7;
            this.textRound.Text = "Runda 3";
            this.textRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mistrz Gry";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextCountdown
            // 
            this.TextCountdown.AutoSize = true;
            this.TextCountdown.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCountdown.Location = new System.Drawing.Point(394, 168);
            this.TextCountdown.Name = "TextCountdown";
            this.TextCountdown.Size = new System.Drawing.Size(16, 16);
            this.TextCountdown.TabIndex = 9;
            this.TextCountdown.Text = "7";
            this.TextCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextCountdown.Click += new System.EventHandler(this.TextCountdown_Click);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(366, 114);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(75, 32);
            this.textScore.TabIndex = 10;
            this.textScore.Text = "0 - 0";
            this.textScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TimerCountDown);
            // 
            // listViewHistory
            // 
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(268, 25);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(268, 61);
            this.listViewHistory.TabIndex = 11;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.TextCountdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCode);
            this.Controls.Add(this.picturePlayer);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.buttonPaper);
            this.Name = "Form1";
            this.Text = "Papier Kamień Nożyce";
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.PictureBox pictureCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TextCountdown;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListView listViewHistory;
    }
}

