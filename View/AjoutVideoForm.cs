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
    public partial class AjoutVideoForm : Form
    {
        private Ctrl ctrl;

        public AjoutVideoForm(Ctrl _ctrl)
        {
            ctrl=_ctrl;

            InitializeComponent();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openVideoFileDialog.ShowDialog();
        }

        private void openVideoFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string file = openVideoFileDialog.FileName;
            cheminTextBox.Text = string.Format("{1}", Path.GetDirectoryName(file), openVideoFileDialog.FileName);
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
                Video v = new Video(titreTextBox.Text, auteurTextBox.Text, cheminTextBox.Text, copyrightCheckBox.Checked);
                bool found = false;
                foreach (Document d in ctrl.mediatheque.GetDocuments<Video>())
                {
                    if (v.path == d.path)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    ctrl.mediatheque.Ajouter(v);
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
