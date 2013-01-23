using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public class Texte : Document, Imprimable
    {
        public Texte() { }

        public Texte(string _titre, string _path, bool _hasCopyright)
            : base(_titre, _path, _hasCopyright) { type = Type.TEXTE; }

        public override void Afficher()
        {

        }

        public void Print()
        {

        }
    }
}
