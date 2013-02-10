using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        Mediatheque m;
        public Ctrl ctrl;

        public MainForm(Model.Mediatheque _m)
        {
            InitializeComponent();

            m = _m;

            ctrl = new Ctrl(m, this);

            documentBindingSource.DataSource = m.documents;
            audioBindingSource.DataSource = m.GetDocuments<Audio>();
            videoBindingSource.DataSource = m.GetDocuments<Video>();
            texteBindingSource.DataSource = m.GetDocuments<Texte>();
            multimediaBindingSource.DataSource = m.GetDocuments<Multimedia>();


            tabControl.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            _textBrush = new System.Drawing.SolidBrush(e.ForeColor);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                g.FillRectangle(SystemBrushes.ControlDark, e.Bounds);
                e.DrawBackground();
            }

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, SystemFonts.DefaultFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutAudioForm af = new AjoutAudioForm(ctrl);
            af.ShowDialog();
        }

        private void vidéoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutVideoForm vf = new AjoutVideoForm(ctrl);
            vf.ShowDialog();
        }

        private void multimédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMMForm mmf = new AjoutMMForm(ctrl);
            mmf.ShowDialog();
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutLivreForm lf = new AjoutLivreForm(ctrl);
            lf.ShowDialog();
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutArticleForm af = new AjoutArticleForm(ctrl);
            af.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == allPage)
            {
                switch (allGridView.CurrentRow.DataBoundItem.GetType().Name)
                {
                    case "Article" : 
                        ModifArticleForm f = new ModifArticleForm((Article)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                        f.ShowDialog();
                        break;

                    case "Audio" :
                        ModifAudioForm f2 = new ModifAudioForm((Audio)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                        f2.ShowDialog();
                        break;

                    case "Livre" : 
                        ModifLivreForm f3 = new ModifLivreForm((Livre)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                        f3.ShowDialog();
                        break;

                    case "Multimedia" :
                        ModifMMForm f4 = new ModifMMForm((Multimedia)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                        f4.ShowDialog();
                        break;

                    case "Video" : 
                        ModifVideoForm f5 = new ModifVideoForm((Video)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                        f5.ShowDialog();
                        break;
                }
            }

            if (tabControl.SelectedTab == textPage)
            {
                if (textGridView.CurrentRow.DataBoundItem.GetType() == typeof(Article))
                {
                    ModifArticleForm f = new ModifArticleForm((Article)textGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
                else if (allGridView.CurrentRow.DataBoundItem.GetType() == typeof(Livre))
                {
                    ModifLivreForm f = new ModifLivreForm((Livre)textGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == audioPage)
            {
                if (audioGridView.CurrentRow.DataBoundItem.GetType() == typeof(Audio))
                {
                    ModifAudioForm f = new ModifAudioForm((Audio)audioGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == mmPage)
            {
                if (mmGridView.CurrentRow.DataBoundItem.GetType() == typeof(Multimedia))
                {
                    ModifMMForm f = new ModifMMForm((Multimedia)mmGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == videoPage)
            {
                if (videoGridView.CurrentRow.DataBoundItem.GetType() == typeof(Video))
                {
                    ModifVideoForm f = new ModifVideoForm((Video)videoGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
        }


        public void refreshLists()
        {
            audioBindingSource.DataSource = null;
            texteBindingSource.DataSource = null;
            multimediaBindingSource.DataSource = null;
            videoBindingSource.DataSource = null;
            documentBindingSource.DataSource = null;

            documentBindingSource.DataSource = m.documents;
            audioBindingSource.DataSource = m.GetDocuments<Audio>();
            videoBindingSource.DataSource = m.GetDocuments<Video>();
            texteBindingSource.DataSource = m.GetDocuments<Texte>();
            multimediaBindingSource.DataSource = m.GetDocuments<Multimedia>();


            m.Sauvegarder();
        }

        public void refreshInfo(DataGridView grid, Panel panel)
        {
            if (grid.CurrentRow != null)
            {
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Courier New", text.Font.Size);
                Document d = (Document)grid.CurrentRow.DataBoundItem;
                text.Text = d.Afficher();
                panel.Controls.Add(text);
                panel.Refresh();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tabControl.SelectedTab == allPage)
            {
                m.Supprimer((Document)allGridView.SelectedRows[0].DataBoundItem);
            }
            if (tabControl.SelectedTab == textPage)
            {
                m.Supprimer((Document)textGridView.SelectedRows[0].DataBoundItem);
            }
            if (tabControl.SelectedTab == audioPage)
            {
                m.Supprimer((Document)audioGridView.SelectedRows[0].DataBoundItem);
            }
            if (tabControl.SelectedTab == mmPage)
            {
                m.Supprimer((Document)mmGridView.SelectedRows[0].DataBoundItem);
            }
            if (tabControl.SelectedTab == videoPage)
            {
                m.Supprimer((Document)videoGridView.SelectedRows[0].DataBoundItem);
            }
            refreshLists();
        }

        private void allGridView_SelectionChanged(object sender, EventArgs e)
        {
            allSplitContainer.Panel2.Controls.Clear();
            refreshInfo(allGridView, allSplitContainer.Panel2);
        }

        private void audioGridView_SelectionChanged(object sender, EventArgs e)
        {
            audioSplitContainer.Panel2.Controls.Clear();

            refreshInfo(audioGridView, audioSplitContainer.Panel2);
        }

        private void videoGridView_SelectionChanged(object sender, EventArgs e)
        {
            videoSplitContainer.Panel2.Controls.Clear();

            refreshInfo(videoGridView, videoSplitContainer.Panel2);
        }

        private void textGridView_SelectionChanged(object sender, EventArgs e)
        {
            textSplitContainer.Panel2.Controls.Clear();

            refreshInfo(textGridView, textSplitContainer.Panel2);
        }

        private void mmGridView_SelectionChanged(object sender, EventArgs e)
        {
            mmSplitContainer.Panel2.Controls.Clear();

            refreshInfo(mmGridView, mmSplitContainer.Panel2);
        }


        private void allGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (allGridView.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Document d = (Document)allGridView.SelectedRows[0].DataBoundItem;
                    System.Diagnostics.Process.Start(d.path);
                }
            }
        }

        private void audioGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (audioGridView.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Document d = (Document)audioGridView.SelectedRows[0].DataBoundItem;
                    System.Diagnostics.Process.Start(d.path);
                }
            }
        }

        private void videoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (videoGridView.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Document d = (Document)videoGridView.SelectedRows[0].DataBoundItem;
                    System.Diagnostics.Process.Start(d.path);
                }
            }
        }

        private void textGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (textGridView.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Document d = (Document)textGridView.SelectedRows[0].DataBoundItem;
                    System.Diagnostics.Process.Start(d.path);
                }
            }
        }

        private void mmGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (mmGridView.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Document d = (Document)mmGridView.SelectedRows[0].DataBoundItem;
                    System.Diagnostics.Process.Start(d.path);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                BindingSource searchBindingSource = new BindingSource();

                IEnumerable<Document> res = from doc in m.GetDocuments<Document>()
                                     where doc.auteur.ToLower().Contains(searchBox.Text.ToLower())
                                        || doc.titre.ToLower().Contains(searchBox.Text.ToLower())
                                     select doc;

                searchBindingSource.DataSource = res.ToList<Document>();

                allGridView.DataSource = searchBindingSource;

                tabControl.SelectedTab = allPage;

                searchBox.Focus();
            }
            else
            {
                allGridView.DataSource = documentBindingSource;
            }
        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application développée par Maxime Lumeau et Mathieu Pédoussaut.\n © 2013 GrumpyCorp Ltd. All rights reserved.","Médiathèque", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void allGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 0)
                {
                    documentBindingSource.DataSource = m.GetDocumentsByTitre<Document>();
                }
                if (e.ColumnIndex == 1)
                {
                    documentBindingSource.DataSource = m.GetDocumentsByAuteur<Document>();
                }
            } 
        }

        private void audioGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 0)
                {
                   audioBindingSource.DataSource = m.GetDocumentsByTitre<Audio>();
                }
                if (e.ColumnIndex == 1)
                {
                    audioBindingSource.DataSource = m.GetDocumentsByAuteur<Audio>();
                }
            }
        }

        private void videoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 0)
                {
                    videoBindingSource.DataSource = m.GetDocumentsByTitre<Video>();
                }
                if (e.ColumnIndex == 1)
                {
                    videoBindingSource.DataSource = m.GetDocumentsByAuteur<Video>();
                }
            }
        }

        private void textGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 0)
                {
                    texteBindingSource.DataSource = m.GetDocumentsByTitre<Texte>();
                }
                if (e.ColumnIndex == 1)
                {
                    texteBindingSource.DataSource = m.GetDocumentsByAuteur<Texte>();
                }
            }
        }

        private void mmGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 0)
                {
                   multimediaBindingSource.DataSource = m.GetDocumentsByTitre<Multimedia>();
                }
                if (e.ColumnIndex == 1)
                {
                    multimediaBindingSource.DataSource = m.GetDocumentsByAuteur<Multimedia>();
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Imprimable)allGridView.SelectedRows[0].DataBoundItem).Print();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == allPage)
            {
                if (allGridView.CurrentRow == null)
                {
                    supprimerToolStripMenuItem.Enabled = false;
                    modifierToolStripMenuItem.Enabled = false;
                }
                else
                {
                    supprimerToolStripMenuItem.Enabled = true;
                    modifierToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == textPage)
            {
                if (textGridView.CurrentRow == null)
                {
                    supprimerToolStripMenuItem.Enabled = false;
                    modifierToolStripMenuItem.Enabled = false;
                }
                else
                {
                    supprimerToolStripMenuItem.Enabled = true;
                    modifierToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == audioPage)
            {
                if (audioGridView.CurrentRow == null)
                {
                    supprimerToolStripMenuItem.Enabled = false;
                    modifierToolStripMenuItem.Enabled = false;
                }
                else
                {
                    supprimerToolStripMenuItem.Enabled = true;
                    modifierToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == mmPage)
            {
                if (mmGridView.CurrentRow == null)
                {
                    supprimerToolStripMenuItem.Enabled = false;
                    modifierToolStripMenuItem.Enabled = false;
                }
                else
                {
                    supprimerToolStripMenuItem.Enabled = true;
                    modifierToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == videoPage)
            {
                if (videoGridView.CurrentRow == null)
                {
                    supprimerToolStripMenuItem.Enabled = false;
                    modifierToolStripMenuItem.Enabled = false;
                }
                else
                {
                    supprimerToolStripMenuItem.Enabled = true;
                    modifierToolStripMenuItem.Enabled = true;
                }
            }
           
        }

        private void outilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == allPage)
            {
                if (allGridView.CurrentRow == null)
                {
                    optionsToolStripMenuItem.Enabled = false;
                }
                else if (allGridView.CurrentRow.DataBoundItem is Imprimable)
                {
                    optionsToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == textPage)
            {
                if (textGridView.CurrentRow == null)
                {
                    optionsToolStripMenuItem.Enabled = false;
                }
                else if (textGridView.CurrentRow.DataBoundItem is Imprimable)
                {
                    optionsToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == audioPage)
            {
                if (audioGridView.CurrentRow == null)
                {
                    optionsToolStripMenuItem.Enabled = false;
                }
                else if (audioGridView.CurrentRow.DataBoundItem is Imprimable)
                {
                    optionsToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == mmPage)
            {
                if (mmGridView.CurrentRow == null)
                {
                    optionsToolStripMenuItem.Enabled = false;
                }
                else if (mmGridView.CurrentRow.DataBoundItem is Imprimable)
                {
                    optionsToolStripMenuItem.Enabled = true;
                }
            }
            else if (tabControl.SelectedTab == videoPage)
            {
                if (videoGridView.CurrentRow == null)
                {
                    optionsToolStripMenuItem.Enabled = false;
                }
                else if (videoGridView.CurrentRow.DataBoundItem is Imprimable)
                {
                    optionsToolStripMenuItem.Enabled = true;
                }
            }
        }
    }
}
