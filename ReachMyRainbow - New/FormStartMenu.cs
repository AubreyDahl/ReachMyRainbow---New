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
            //SoundPlayer soundplayer = new SoundPlayer(Properties.Resources.ReachMyRainbow_Title);
            //soundplayer.PlayLooping();

            
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
           
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            this.Hide();

            FormOptions formOptions = new FormOptions();
            formOptions.ShowDialog();
            this.Close();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)

        {   SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            this.Hide();

            FormLessonSelect formLessonSelect = new FormLessonSelect();
            formLessonSelect.ShowDialog();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();

            FormQuitPopUp formQuitPopUp = new FormQuitPopUp();
            formQuitPopUp.ShowDialog();

        }
        /// <summary>
        ///   This will open the CREDITS form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            SoundPlayer soundplayer = new SoundPlayer(Properties.Resources.ReachMyRainbow_Title);
            soundplayer.PlayLooping();


        }
    }
}
