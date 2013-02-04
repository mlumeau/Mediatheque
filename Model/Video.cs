using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Video : Document
    {
        public Video() { }

        public Video(string _titre = "", string _path = "", bool _hasCopyright = false)
            : base(_titre, _path, _hasCopyright) { type = Type.Video; }

        public override string Afficher()
        {
            string res = "";
            TagLib.File f = TagLib.File.Create(this.path);
            if (f.Tag != null)
            {
                res =
                    "Titre         : " + f.Tag.Title + "\n" +
                    "Durée         : " + f.Properties.Duration + "\n" +
                    "Résolution    : " + f.Properties.VideoWidth + "x" + f.Properties.VideoHeight + "\n";
            }
            return res;
        }
    }
}
