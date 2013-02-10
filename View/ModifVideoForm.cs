using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace View
{
    public partial class ModifVideoForm : Form
    {
        Video v;
        Ctrl ctrl;

        public ModifVideoForm(Video _v, Ctrl _ctrl)
        {
            InitializeComponent();

            v = _v;
            ctrl = _ctrl;

            titreTextBox.Text = v.titre;
            auteurTextBox.Text = v.auteur;
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            if (titreTextBox.Text == "" || auteurTextBox.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement.");
            }
            else
            {
                v.titre = titreTextBox.Text;
                v.auteur = auteurTextBox.Text;
                ctrl.mainform.refreshLists();
                ctrl.mediatheque.Sauvegarder();

                this.Close();
            }
        }
    }
}
