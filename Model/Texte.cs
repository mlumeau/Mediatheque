using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Model
{
    public class Texte : Document, Imprimable
    {

        public Texte() { }

        public Texte(string _titre, string _auteur, string _path, bool _hasCopyright)
            : base(_titre, _auteur, _path, _hasCopyright) { type = typeof(Texte).Name; }

        public override string Afficher()
        {
            return "";
        }

        public void Print()
        {
            MessageBox.Show("Document imprimé !");
        }
    }
}
