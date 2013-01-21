using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public class Mediatheque
    {
        ArrayList documents;

        public Mediatheque()
        {
            documents = new ArrayList();
        }

        public void Ajouter(Document _doc){
            if(!documents.Contains(_doc))
            {
                documents.Add(_doc);
            }
        }

        public void Supprimer(Document _doc)
        {
            if (documents.Contains(_doc))
            {
                documents.Remove(_doc);
            }
        }

        public void Save()
        {

        }
    }
}
