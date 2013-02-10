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
using System.Globalization;

namespace View
{
    public partial class ModifLivreForm : Form
    {
        private Livre l;
        private Ctrl ctrl;

        public ModifLivreForm(Livre _l, Ctrl _ctrl)
        {
            InitializeComponent();

            l = _l;
            ctrl = _ctrl;

            titreTextBox.Text = l.titre;
            auteurTextBox.Text = l.auteur;
            editeurTextBox.Text = l.editeur;
            anneeParutionTextBox.Text = l.parution.ToString("dd'/'MM'/'yyyy");
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (titreTextBox.Text == "" || auteurTextBox.Text == "" || editeurTextBox.Text == "" || DateTime.ParseExact(anneeParutionTextBox.Text, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy") != anneeParutionTextBox.Text)
                {
                    MessageBox.Show("Veuillez remplir tous les champs correctement.");
                }
                else
                {
                   
                    l.titre = titreTextBox.Text;
                    l.auteur = auteurTextBox.Text;
                    l.editeur = editeurTextBox.Text;
                    l.parution = DateTime.ParseExact(anneeParutionTextBox.Text, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture);
                    ctrl.mainform.refreshLists();
                    ctrl.mainform.Refresh();
                    ctrl.mediatheque.Sauvegarder();

                    this.Close();
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Date incorrecte !\nSaisissez une date au format jj/mm/aaaa.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
