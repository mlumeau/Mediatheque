using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public class Article : Texte
    {

        public string numEdition { get; set; }
        public string editeur { get; set; }

        public Article() { }
        public Article(string _titre, string _path, bool _hasCopyright, string _numEdition, string _editeur) 
            : base(_titre,_path,_hasCopyright)
        {
            numEdition = _numEdition;
            editeur = _editeur;
        }
    }
}
