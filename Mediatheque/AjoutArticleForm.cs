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
    public partial class AjoutArticleForm : Form
    {
        public AjoutArticleForm()
        {
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
                Article art = new Article(titreTextBox.Text, cheminTextBox.Text, true, numEditionTextBox.Text, editeurTextBox.Text);


                this.Close();
            }
        }
    }
}
