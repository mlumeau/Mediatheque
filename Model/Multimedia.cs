using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Multimedia : Document, Imprimable
    {
        public Multimedia() { }

        public Multimedia(string _titre, string _auteur, string _path, bool _hasCopyright)
            : base(_titre, _auteur, _path, _hasCopyright) { type = typeof(Multimedia).Name; }

        public override string Afficher()
        {
            string res = "";
            TagLib.File f = TagLib.File.Create(this.path);
            if (f.Tag != null)
            {
                res = "";

                if (f.Tag.Title != null)
                    res += "Titre         : " + f.Tag.Title + "\n";

                res += "Durée         : " + f.Properties.Duration.ToString(@"hh\:mm\:ss") + "\n" +
                       "Résolution    : " + f.Properties.VideoWidth + "x" + f.Properties.VideoHeight + "\n";
            }
            return res;
        }

        public void Print()
        {
            MessageBox.Show("Document imprimé !");
        }
    }
}
