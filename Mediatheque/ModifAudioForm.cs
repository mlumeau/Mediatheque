using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatheque
{
    public partial class ModifAudioForm : Form
    {
        private Audio aud;

        public ModifAudioForm(Audio _aud)
        {
            InitializeComponent();

            aud = _aud;

            titreTextBox.Text = aud.titre;
            auteurTextBox.Text = aud.auteur;
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
                aud.titre = titreTextBox.Text;
                aud.auteur = auteurTextBox.Text;

                this.Close();
            }
        }
    }
}
