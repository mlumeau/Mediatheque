using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    class Multimedia : Document, Imprimable
    {
        public Multimedia(string _titre, string _path, bool _hasCopyright)
            : base(_titre,_path,_hasCopyright){}

        public override void Afficher()
        {

        }

        public void Print()
        {

        }
    }
}
