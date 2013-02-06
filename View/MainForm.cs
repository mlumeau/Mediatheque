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
            documentBindingSource.DataSource = null;
            documentBindingSource.DataSource = m.documents;
            audioBindingSource.DataSource = null;
            audioBindingSource.DataSource = m.GetDocuments<Audio>();
            videoBindingSource.DataSource = null;
            videoBindingSource.DataSource = m.GetDocuments<Video>();
            texteBindingSource.DataSource = null;
            texteBindingSource.DataSource = m.GetDocuments<Texte>();
            multimediaBindingSource.DataSource = null;
            multimediaBindingSource.DataSource = m.GetDocuments<Multimedia>();
            m.Sauvegarder();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrl.mediatheque.Supprimer((Document)allGridView.CurrentRow.DataBoundItem);
            refreshLists(); 
        }
    }
}
