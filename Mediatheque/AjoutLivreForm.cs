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

namespace Mediatheque
{
    public partial class AjoutLivreForm : Form
    {
        public AjoutLivreForm()
        {
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
            if (titreTextBox.Text == "" || auteurTextBox.Text == "" || editeurTextBox.Text == "" || DateTime.Parse(anneeParutionTextBox.Text).ToString() != anneeParutionTextBox.Text || cheminTextBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                Livre l = new Livre(titreTextBox.Text, cheminTextBox.Text, true, DateTime.Parse(anneeParutionTextBox.Text), editeurTextBox.Text);


                this.Close();
            }
        }
    }
}
