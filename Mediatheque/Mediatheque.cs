using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    class Mediatheque
    {
        Hashtable documents;

        public Mediatheque()
        {
            documents = new Hashtable();

            //hahaha

        }

        public void Ajouter(Document _doc){
            documents.Add(_doc.id, _doc);
        }
    }
}
