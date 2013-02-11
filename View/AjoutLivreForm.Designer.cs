namespace View
{
    partial class AjoutLivreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editeurLabel = new System.Windows.Forms.Label();
            this.copyrightCheckBox = new System.Windows.Forms.CheckBox();
            this.cheminTitleLabel = new System.Windows.Forms.Label();
            this.titreLabel = new System.Windows.Forms.Label();
            this.auteurLabel = new System.Windows.Forms.Label();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cheminTextBox = new System.Windows.Forms.TextBox();
            this.parcourirButton = new System.Windows.Forms.Button();
            this.anneeParutionLabel = new System.Windows.Forms.Label();
            this.editeurTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.validerButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.anneeParutionTextBox = new System.Windows.Forms.TextBox();
            this.openLivreFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.Controls.Add(this.editeurLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.copyrightCheckBox, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cheminTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titreLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.auteurLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.auteurTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.titreTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.anneeParutionLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.editeurTextBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.anneeParutionTextBox, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 294);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // editeurLabel
            // 
            this.editeurLabel.AutoSize = true;
            this.editeurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeurLabel.Location = new System.Drawing.Point(3, 135);
            this.editeurLabel.Name = "editeurLabel";
            this.editeurLabel.Size = new System.Drawing.Size(41, 12);
            this.editeurLabel.TabIndex = 10;
            this.editeurLabel.Text = "Éditeur";
            this.editeurLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // copyrightCheckBox
            // 
            this.copyrightCheckBox.AutoSize = true;
            this.copyrightCheckBox.Location = new System.Drawing.Point(3, 228);
            this.copyrightCheckBox.Name = "copyrightCheckBox";
            this.copyrightCheckBox.Size = new System.Drawing.Size(73, 17);
            this.copyrightCheckBox.TabIndex = 19;
            this.copyrightCheckBox.Text = " Copyright";
            this.copyrightCheckBox.UseVisualStyleBackColor = true;
            // 
            // cheminTitleLabel
            // 
            this.cheminTitleLabel.AutoSize = true;
            this.cheminTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheminTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.cheminTitleLabel.Name = "cheminTitleLabel";
            this.cheminTitleLabel.Size = new System.Drawing.Size(43, 12);
            this.cheminTitleLabel.TabIndex = 4;
            this.cheminTitleLabel.Text = "Chemin";
            this.cheminTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLabel.Location = new System.Drawing.Point(3, 45);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(28, 12);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Titre";
            this.titreLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // auteurLabel
            // 
            this.auteurLabel.AutoSize = true;
            this.auteurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteurLabel.Location = new System.Drawing.Point(3, 90);
            this.auteurLabel.Name = "auteurLabel";
            this.auteurLabel.Size = new System.Drawing.Size(39, 12);
            this.auteurLabel.TabIndex = 2;
            this.auteurLabel.Text = "Auteur";
            this.auteurLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.Location = new System.Drawing.Point(3, 108);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(278, 20);
            this.auteurTextBox.TabIndex = 3;
            // 
            // titreTextBox
            // 
            this.titreTextBox.Location = new System.Drawing.Point(3, 63);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(278, 20);
            this.titreTextBox.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cheminTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.parcourirButton);
            this.splitContainer1.Size = new System.Drawing.Size(278, 25);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 8;
            // 
            // cheminTextBox
            // 
            this.cheminTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cheminTextBox.Location = new System.Drawing.Point(3, 2);
            this.cheminTextBox.Name = "cheminTextBox";
            this.cheminTextBox.ReadOnly = true;
            this.cheminTextBox.Size = new System.Drawing.Size(202, 20);
            this.cheminTextBox.TabIndex = 2;
            // 
            // parcourirButton
            // 
            this.parcourirButton.Location = new System.Drawing.Point(2, 0);
            this.parcourirButton.Name = "parcourirButton";
            this.parcourirButton.Size = new System.Drawing.Size(66, 23);
            this.parcourirButton.TabIndex = 0;
            this.parcourirButton.Text = "Parcourir...";
            this.parcourirButton.UseVisualStyleBackColor = true;
            this.parcourirButton.Click += new System.EventHandler(this.parcourirButton_Click);
            // 
            // anneeParutionLabel
            // 
            this.anneeParutionLabel.AutoSize = true;
            this.anneeParutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneeParutionLabel.Location = new System.Drawing.Point(3, 180);
            this.anneeParutionLabel.Name = "anneeParutionLabel";
            this.anneeParutionLabel.Size = new System.Drawing.Size(155, 12);
            this.anneeParutionLabel.TabIndex = 12;
            this.anneeParutionLabel.Text = "Date de parution (jj/mm/aaaa)";
            this.anneeParutionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // editeurTextBox
            // 
            this.editeurTextBox.Location = new System.Drawing.Point(3, 153);
            this.editeurTextBox.Name = "editeurTextBox";
            this.editeurTextBox.Size = new System.Drawing.Size(278, 20);
            this.editeurTextBox.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 258);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.validerButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.annulerButton);
            this.splitContainer2.Size = new System.Drawing.Size(278, 32);
            this.splitContainer2.SplitterDistance = 138;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 9;
            // 
            // validerButton
            // 
            this.validerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.validerButton.Location = new System.Drawing.Point(28, 3);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(82, 26);
            this.validerButton.TabIndex = 0;
            this.validerButton.Text = "&Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.annulerButton.Location = new System.Drawing.Point(36, 3);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(82, 26);
            this.annulerButton.TabIndex = 1;
            this.annulerButton.Text = "&Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // anneeParutionTextBox
            // 
            this.anneeParutionTextBox.Location = new System.Drawing.Point(3, 198);
            this.anneeParutionTextBox.Name = "anneeParutionTextBox";
            this.anneeParutionTextBox.Size = new System.Drawing.Size(278, 20);
            this.anneeParutionTextBox.TabIndex = 11;
            // 
            // openLivreFileDialog
            // 
            this.openLivreFileDialog.Filter = "Fichiers PDF|*.pdf|Fichiers Word 97-03|*.doc|Fichiers Word 07|*.docx|Fichiers EPU" +
    "B|*.epub";
            this.openLivreFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openLivreFileDialog_FileOk);
            // 
            // AjoutLivreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjoutLivreForm";
            this.Text = "Ajouter un livre";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Label cheminTitleLabel;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.Label auteurLabel;
        private System.Windows.Forms.TextBox auteurTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox cheminTextBox;
        private System.Windows.Forms.Button parcourirButton;
        private System.Windows.Forms.OpenFileDialog openLivreFileDialog;
        private System.Windows.Forms.Label editeurLabel;
        private System.Windows.Forms.TextBox anneeParutionTextBox;
        private System.Windows.Forms.Label anneeParutionLabel;
        private System.Windows.Forms.TextBox editeurTextBox;
        private System.Windows.Forms.CheckBox copyrightCheckBox;
    }
}