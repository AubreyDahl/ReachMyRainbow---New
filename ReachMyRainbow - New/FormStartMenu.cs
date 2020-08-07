using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReachMyRainbow___New
{
    public partial class FormStartMenu : Form
    {
        public FormStartMenu()
        {
            InitializeComponent();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play(); 
        }

        private void ButtonPlay_Click(object sender, EventArgs e)

        {   SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            ButtonQuit.Enabled = true;
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();

        }

        private void ButtonCredits_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            this.Hide();
            FormCredits formCredits = new FormCredits();
            formCredits.ShowDialog();
        }

        private void FormStartMenu_Load(object sender, EventArgs e)
        {
            //Function for NEXTbutton  ButtonQuit.Visible = false;        
            ButtonQuit.Enabled = false;
        }
    }
}
