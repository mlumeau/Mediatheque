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
            Multimedia mm = new Multimedia(titreTextBox.Text, cheminTextBox.Text, copyrightCheckBox.Checked);

            ctrl.mediatheque.Ajouter(mm);

            this.Close();
        }
        
    }
}
