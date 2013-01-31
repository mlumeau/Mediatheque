namespace Mediatheque
{
    partial class ModifArticleForm
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
            this.titreLabel = new System.Windows.Forms.Label();
            this.auteurLabel = new System.Windows.Forms.Label();
            this.auteurTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.validerButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.editeurLabel = new System.Windows.Forms.Label();
            this.editeurTextBox = new System.Windows.Forms.TextBox();
            this.numEditionTextBox = new System.Windows.Forms.TextBox();
            this.numEditionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.titreLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.auteurLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.auteurTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.titreTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.editeurLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.editeurTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.numEditionTextBox, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.numEditionLabel, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 218);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLabel.Location = new System.Drawing.Point(3, 0);
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
            this.auteurLabel.Location = new System.Drawing.Point(3, 45);
            this.auteurLabel.Name = "auteurLabel";
            this.auteurLabel.Size = new System.Drawing.Size(39, 12);
            this.auteurLabel.TabIndex = 2;
            this.auteurLabel.Text = "Auteur";
            this.auteurLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // auteurTextBox
            // 
            this.auteurTextBox.Location = new System.Drawing.Point(3, 63);
            this.auteurTextBox.Name = "auteurTextBox";
            this.auteurTextBox.Size = new System.Drawing.Size(278, 20);
            this.auteurTextBox.TabIndex = 3;
            // 
            // titreTextBox
            // 
            this.titreTextBox.Location = new System.Drawing.Point(3, 18);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(278, 20);
            this.titreTextBox.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 183);
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
            // editeurLabel
            // 
            this.editeurLabel.AutoSize = true;
            this.editeurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeurLabel.Location = new System.Drawing.Point(3, 90);
            this.editeurLabel.Name = "editeurLabel";
            this.editeurLabel.Size = new System.Drawing.Size(41, 12);
            this.editeurLabel.TabIndex = 14;
            this.editeurLabel.Text = "Éditeur";
            this.editeurLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // editeurTextBox
            // 
            this.editeurTextBox.Location = new System.Drawing.Point(3, 108);
            this.editeurTextBox.Name = "editeurTextBox";
            this.editeurTextBox.Size = new System.Drawing.Size(278, 20);
            this.editeurTextBox.TabIndex = 17;
            // 
            // numEditionTextBox
            // 
            this.numEditionTextBox.Location = new System.Drawing.Point(3, 153);
            this.numEditionTextBox.Name = "numEditionTextBox";
            this.numEditionTextBox.Size = new System.Drawing.Size(278, 20);
            this.numEditionTextBox.TabIndex = 15;
            // 
            // numEditionLabel
            // 
            this.numEditionLabel.AutoSize = true;
            this.numEditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEditionLabel.Location = new System.Drawing.Point(3, 135);
            this.numEditionLabel.Name = "numEditionLabel";
            this.numEditionLabel.Size = new System.Drawing.Size(90, 12);
            this.numEditionLabel.TabIndex = 16;
            this.numEditionLabel.Text = "Numéro d\'édition";
            this.numEditionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ModifArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModifArticleForm";
            this.Text = "Modifier un article";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.Label auteurLabel;
        private System.Windows.Forms.TextBox auteurTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Label editeurLabel;
        private System.Windows.Forms.TextBox editeurTextBox;
        private System.Windows.Forms.TextBox numEditionTextBox;
        private System.Windows.Forms.Label numEditionLabel;
    }
}