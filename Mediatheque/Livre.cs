using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public class Livre : Texte
    {

        public DateTime parution { get; set; }
        public string editeur { get; set; }

        public Livre() { }
        public Livre(string _titre, string _path, bool _hasCopyright, DateTime _parution, string _editeur) 
            : base(_titre,_path,_hasCopyright)
        {
            parution = _parution;
            editeur = _editeur;
        }
    }
}
