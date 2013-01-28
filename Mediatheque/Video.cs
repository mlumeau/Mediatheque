using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public class Video : Document
    {
        public Video(){}

        public Video(string _titre="", string _path="", bool _hasCopyright=false)
            : base(_titre, _path, _hasCopyright) { type = Type.VIDEO; }

        public override string Afficher()
        {

        }
    }
}
