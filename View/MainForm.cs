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

            refreshLists();

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
        }

    }
}
