using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public class Audio : Document
    {
        public Audio(){}

        public Audio(string _titre="", string _path="", bool _hasCopyright=false)
            : base(_titre, _path, _hasCopyright) {type = Type.AUDIO;} 

        public override void Afficher()
        {

        }
    }
}
