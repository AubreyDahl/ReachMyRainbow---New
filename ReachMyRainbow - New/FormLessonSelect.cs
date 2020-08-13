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
    public partial class FormLessonSelect : Form
    {
        public FormLessonSelect()
        {
            InitializeComponent();
        }

        private void FormLessonSelect_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ReachMyRainbow_Credits_Options);
            soundPlayer.PlayLooping();
        }

        private void ButtonBackLessonSelect_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            this.Hide();

            FormStartMenu formStartMenu = new FormStartMenu();
            formStartMenu.ShowDialog();
        }

        private void buttonLevel1Select_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play(); 
        }
    }
}
