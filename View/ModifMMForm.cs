using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ModifMMForm : Form
    {
        private Multimedia mm;
        private Ctrl ctrl;

        public ModifMMForm(Multimedia _mm, Ctrl _ctrl)
        {
            InitializeComponent();

            mm = _mm;
            ctrl = _ctrl;

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

                ctrl.mediatheque.Sauvegarder();

                this.Close();
            }
        }
    }
}
