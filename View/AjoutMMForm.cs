using Model;
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

namespace View
{
    public partial class AjoutMMForm : Form
    {
        private Ctrl ctrl;

        public AjoutMMForm(Ctrl _ctrl)
        {
            ctrl = _ctrl;

            InitializeComponent();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openMMFileDialog.ShowDialog();
        }

        private void openMMFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string file = openMMFileDialog.FileName;
            cheminTextBox.Text = string.Format("{1}", Path.GetDirectoryName(file), openMMFileDialog.FileName);
            //préremplir avec infos id3
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || auteurTextBox.Text == "" || cheminTextBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                Multimedia mm = new Multimedia(titreTextBox.Text, auteurTextBox.Text, cheminTextBox.Text, copyrightCheckBox.Checked);
                bool found = false;
                foreach (Document d in ctrl.mediatheque.GetDocuments<Multimedia>())
                {
                    if (mm.path == d.path)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    ctrl.mediatheque.Ajouter(mm);
                    ctrl.mainform.refreshLists();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ce fichier est déjà présent dans la médiathèque.");
                }
            }
        }
        
    }
}
