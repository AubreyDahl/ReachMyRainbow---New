﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ReachMyRainbow___New
{
    public partial class FormCredits : Form
    {
        public FormCredits()
        {
            InitializeComponent();
        }

        private void ButtonBackCredits_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            this.Hide();

            FormStartMenu formStartMenu = new FormStartMenu();
            formStartMenu.ShowDialog();
        }

        private void FormCredits_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ReachMyRainbow_Credits_Options);
            soundPlayer.PlayLooping();
        }
    }
}
