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
    public partial class ModifMMForm : Form
    {
        Multimedia mm;

        public ModifMMForm(Multimedia _mm)
        {
            InitializeComponent();

            mm = _mm;

            titreTextBox.Text = mm.titre;
            auteurTextBox.Text = mm.auteur;
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
                mm.titre = titreTextBox.Text;
                mm.auteur = auteurTextBox.Text;

                this.Close();
            }
        }
    }
}
