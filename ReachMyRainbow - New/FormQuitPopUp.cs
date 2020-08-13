using System;
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
    public partial class FormQuitPopUp : Form
    {
        public FormQuitPopUp()
        {
            InitializeComponent();
        }

        private void buttonQuitNo_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();

            FormQuitPopUp formQuitPopUp = new FormQuitPopUp();
            this.Close();
        }

        private void buttonQuitYes_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Button_Click);
            soundPlayer.Play();

            System.Windows.Forms.Application.ExitThread(); 
        }
    }
}
