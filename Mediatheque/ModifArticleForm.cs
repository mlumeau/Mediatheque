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
    public partial class ModifArticleForm : Form
    {
        Article art;

        public ModifArticleForm(Article _art)
        {
            InitializeComponent();

            art = _art;

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

                this.Close();
            }
        }
    }
}
