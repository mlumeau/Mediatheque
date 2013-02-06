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
    public partial class ModifArticleForm : Form
    {
        private Article art;
        private Ctrl ctrl;

        public ModifArticleForm(Article _art, Ctrl _ctrl)
        {
            InitializeComponent();

            art = _art;
            ctrl = _ctrl;

            titreTextBox.Text = art.titre;
            auteurTextBox.Text = art.auteur;
            editeurTextBox.Text = art.editeur;
            numEditionTextBox.Text = art.numEdition;
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || auteurTextBox.Text == "" || editeurTextBox.Text == "" || numEditionTextBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                art.titre = titreTextBox.Text;
                art.auteur = auteurTextBox.Text;
                art.editeur = editeurTextBox.Text;
                art.numEdition = numEditionTextBox.Text;

                ctrl.mediatheque.Sauvegarder();

                this.Close();
            }
        }
    }
}
