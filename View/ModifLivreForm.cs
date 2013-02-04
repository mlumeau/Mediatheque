using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class ModifLivreForm : Form
    {
        private Model.Livre l;

        public ModifLivreForm(Livre _l)
        {
            InitializeComponent();

            l = _l;

            titreTextBox.Text = l.titre;
            auteurTextBox.Text = l.auteur;
            editeurTextBox.Text = l.editeur;
            anneeParutionTextBox.Text = l.parution.ToString();
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || auteurTextBox.Text == "" || editeurTextBox.Text == "" || DateTime.Parse(anneeParutionTextBox.Text).ToString() != anneeParutionTextBox.Text)
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                l.titre = titreTextBox.Text;
                l.auteur = auteurTextBox.Text;
                l.editeur = editeurTextBox.Text;
                l.parution = DateTime.Parse(anneeParutionTextBox.Text);

                this.Close();
            }
        }
    }
}
