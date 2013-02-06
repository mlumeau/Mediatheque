using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class AjoutArticleForm : Form
    {
        public Ctrl ctrl;

        public AjoutArticleForm(Ctrl _ctrl)
        {
            ctrl = _ctrl;

            InitializeComponent();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openArticleFileDialog.ShowDialog();

        }

        private void openArticleFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string file = openArticleFileDialog.FileName;
            cheminTextBox.Text = string.Format("{1}", Path.GetDirectoryName(file), openArticleFileDialog.FileName);
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || auteurTextBox.Text == "" || editeurTextBox.Text == "" || numEditionTextBox.Text == "" || cheminTextBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                Article art = new Article(titreTextBox.Text, auteurTextBox.Text, cheminTextBox.Text, copyrightCheckBox.Checked, numEditionTextBox.Text, editeurTextBox.Text);

                ctrl.mediatheque.Ajouter(art);
                ctrl.mainform.refreshLists();
                this.Close();
            }
        }
    }
}
