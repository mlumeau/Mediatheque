using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatheque
{
    public partial class AjoutAudioForm : Form
    {
        public AjoutAudioForm()
        {
            InitializeComponent();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openAudioFileDialog.ShowDialog();

        }

        private void openAudioFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string file = openAudioFileDialog.FileName;
            cheminTextBox.Text = string.Format("{1}", Path.GetDirectoryName(file), openAudioFileDialog.FileName);
            //préremplir avec infos id3
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || auteurTextBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                Audio aud = new Audio();

                this.Close();
            }
        }
    }
}
