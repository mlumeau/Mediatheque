using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Article : Texte
    {

        public string numEdition { get; set; }
        public string editeur { get; set; }

        public Article() { }
        public Article(string _titre, string _auteur, string _path, bool _hasCopyright, string _numEdition, string _editeur)
            : base(_titre, _auteur, _path, _hasCopyright)
        {
            numEdition = _numEdition;
            editeur = _editeur;
            type = typeof(Article).Name; 
        }

        public override string Afficher()
        {
            string res = 
                "Auteur      : " + this.auteur + "\n" +
                "Editeur     : " + this.editeur + "\n" + 
                "N° Edition  : " + this.numEdition +"\n";
            return res;
        }
    }
}
