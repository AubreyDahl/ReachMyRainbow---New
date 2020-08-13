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
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            //Secondary Menu loading music
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ReachMyRainbow_Credits_Options);
            soundPlayer.PlayLooping();

        }

     

        private void ButtonBackOptions_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();
            this.Hide();

            FormStartMenu formStartMenu = new FormStartMenu();
            formStartMenu.ShowDialog();
        }
    }
}
