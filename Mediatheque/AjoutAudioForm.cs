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
    public partial class AjoutAudioForm : Form
    {
        public AjoutAudioForm()
        {
            InitializeComponent();
        }

        private void parcourirButton_Click(object sender, EventArgs e)
        {
            openAudioFileDialog.ShowDialog();

        }

        private void openAudioFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string file = openAudioFileDialog.FileName;
            cheminTextBox.Text = string.Format("{1}", Path.GetDirectoryName(file), openAudioFileDialog.FileName);
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
