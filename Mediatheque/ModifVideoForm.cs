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
    public partial class ModifVideoForm : Form
    {
        Video v;

        public ModifVideoForm(Video _v)
        {
            InitializeComponent();

            v = _v;

            titreTextBox.Text = v.titre;
            auteurTextBox.Text = v.auteur;
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
                v.titre = titreTextBox.Text;
                v.auteur = auteurTextBox.Text;

                this.Close();
            }
        }
    }
}
