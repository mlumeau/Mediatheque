using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Livre : Texte
    {

        public DateTime parution { get; set; }
        public string editeur { get; set; }

        public Livre() { }
        public Livre(string _titre, string _auteur, string _path, bool _hasCopyright, DateTime _parution, string _editeur)
            : base(_titre,_auteur, _path, _hasCopyright)
        {
            parution = _parution;
            editeur = _editeur;
            type = typeof(Livre).Name;
        }

        public override string Afficher()
        {
            string res =
                "Auteur      : " + this.auteur + "\n" +
                "Editeur     : " + this.editeur + "\n" +
                "Parution    : " + this.parution + "\n";

            return res;
        }
    }
}
