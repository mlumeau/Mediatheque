﻿using System;
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
    public partial class AjoutVideoForm : Form
    {
        public AjoutVideoForm()
        {
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
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}