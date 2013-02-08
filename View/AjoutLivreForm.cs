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
using Model;
using System.Globalization;

namespace View
{
    public partial class AjoutLivreForm : Form
    {
        private Ctrl ctrl;

        public AjoutLivreForm(Ctrl _ctrl)
        {
            ctrl = _ctrl;

            InitializeComponent();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openLivreFileDialog.ShowDialog();

        }

        private void openLivreFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string file = openLivreFileDialog.FileName;
            cheminTextBox.Text = string.Format("{1}", Path.GetDirectoryName(file), openLivreFileDialog.FileName);
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (titreTextBox.Text == "" || auteurTextBox.Text == "" || editeurTextBox.Text == "" || cheminTextBox.Text == "" || DateTime.ParseExact(anneeParutionTextBox.Text, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy") != anneeParutionTextBox.Text)
                {
                    MessageBox.Show("Veuillez remplir tous les champs correctement.");
                }
                else
                {
                    Livre l = new Livre(titreTextBox.Text, auteurTextBox.Text, cheminTextBox.Text, copyrightCheckBox.Checked, DateTime.ParseExact(anneeParutionTextBox.Text, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture), editeurTextBox.Text);
                    bool found = false;
                    foreach (Document d in ctrl.mediatheque.GetDocuments<Texte>())
                    {
                        if (l.path == d.path)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        ctrl.mediatheque.Ajouter(l);
                        ctrl.mainform.refreshLists();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ce fichier est déjà présent dans la médiathèque.");
                    }
                }
            }
            catch(FormatException)
            {
               
                MessageBox.Show("Date incorrecte !\nSaisissez une date au format jj/mm/aaaa.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }
    }
}
