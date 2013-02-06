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
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Article))
                {
                    ModifArticleForm f = new ModifArticleForm((Article)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Audio))
                {
                    ModifAudioForm f = new ModifAudioForm((Audio)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Livre))
                {
                    ModifLivreForm f = new ModifLivreForm((Livre)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Multimedia))
                {
                    ModifMMForm f = new ModifMMForm((Multimedia)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Video))
                {
                    ModifVideoForm f = new ModifVideoForm((Video)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == textPage)
            {
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Article))
                {
                    ModifArticleForm f = new ModifArticleForm((Article)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Livre))
                {
                    ModifLivreForm f = new ModifLivreForm((Livre)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == audioPage)
            {
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Audio))
                {
                    ModifAudioForm f = new ModifAudioForm((Audio)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == mmPage)
            {
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Multimedia))
                {
                    ModifMMForm f = new ModifMMForm((Multimedia)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
            if (tabControl.SelectedTab == videoPage)
            {
                if (allGridView.SelectedRows[0].DataBoundItem.GetType() == typeof(Video))
                {
                    ModifVideoForm f = new ModifVideoForm((Video)allGridView.SelectedRows[0].DataBoundItem, ctrl);
                    f.ShowDialog();
                }
            }
        }

        public void refreshLists()
        {

            foreach (Document d in m.documents)
            {
                if (!documentBindingSource.Contains(d))
                    documentBindingSource.Add(d);
            }
            foreach (Audio a in m.GetDocuments<Audio>())
            {
                if (!audioBindingSource.Contains(a))
                    audioBindingSource.Add(a);
            }
            foreach (Video v in m.GetDocuments<Video>())
            {
                if (!videoBindingSource.Contains(v))
                    videoBindingSource.Add(v);
            }
            foreach (Texte t in m.GetDocuments<Texte>())
            {
                if (!texteBindingSource.Contains(t))
                    texteBindingSource.Add(t);
            }
            foreach (Multimedia mm in m.GetDocuments<Multimedia>())
            {
                if (!multimediaBindingSource.Contains(mm))
                    multimediaBindingSource.Add(mm);
            }
            
            m.Sauvegarder();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void allGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ctrl.mediatheque.documents.Count() > 0)
            {
                allSplitContainer.Panel2.Controls.Clear();
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Courier New", text.Font.Size);
                Document d = (Document)allGridView.CurrentRow.DataBoundItem;
                text.Text = d.Afficher();
                allSplitContainer.Panel2.Controls.Add(text);
                allSplitContainer.Panel2.Refresh();
            }
        }

        private void audioGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ctrl.mediatheque.GetDocuments<Audio>().Count() > 0)
            {
                audioSplitContainer.Panel2.Controls.Clear();
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Courier New", text.Font.Size);
                Document d = (Document)audioGridView.CurrentRow.DataBoundItem;
                text.Text = d.Afficher();
                audioSplitContainer.Panel2.Controls.Add(text);
                audioSplitContainer.Panel2.Refresh();
            }
        }

        private void videoGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ctrl.mediatheque.GetDocuments<Video>().Count() > 0)
            {
                videoSplitContainer.Panel2.Controls.Clear();
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Courier New", text.Font.Size);
                Document d = (Document)videoGridView.CurrentRow.DataBoundItem;
                text.Text = d.Afficher();
                videoSplitContainer.Panel2.Controls.Add(text);
                videoSplitContainer.Panel2.Refresh();
            }
        }

        private void textGridView_SelectionChanged(object sender, EventArgs e)
        {
            textSplitContainer.Panel2.Controls.Clear();
            if (ctrl.mediatheque.GetDocuments<Texte>().Count() > 0)
            {
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Courier New", text.Font.Size);
                Document d = (Document)textGridView.CurrentRow.DataBoundItem;
                text.Text = d.Afficher();
                textSplitContainer.Panel2.Controls.Add(text);
                textSplitContainer.Panel2.Refresh();
            }
        }

        private void mmGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ctrl.mediatheque.GetDocuments<Multimedia>().Count() > 0)
            {
                mmSplitContainer.Panel2.Controls.Clear();
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Courier New", text.Font.Size);
                Document d = (Document)mmGridView.CurrentRow.DataBoundItem;
                text.Text = d.Afficher();
                textSplitContainer.Panel2.Controls.Add(text);
                textSplitContainer.Panel2.Refresh();
            }
        }

        private void allGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void allGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Document d = (Document)allGridView.SelectedRows[0].DataBoundItem;
                System.Diagnostics.Process.Start(d.path);
            }
        }

        private void audioGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Document d = (Document)audioGridView.SelectedRows[0].DataBoundItem;
                System.Diagnostics.Process.Start(d.path);
            }
        }

        private void videoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Document d = (Document)videoGridView.SelectedRows[0].DataBoundItem;
                System.Diagnostics.Process.Start(d.path);
            }
        }

        private void textGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Document d = (Document)textGridView.SelectedRows[0].DataBoundItem;
                System.Diagnostics.Process.Start(d.path);
            }
        }

        private void mmGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Document d = (Document)mmGridView.SelectedRows[0].DataBoundItem;
                System.Diagnostics.Process.Start(d.path);
            }
        }
    }
}
