﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque
{
    public abstract class Document
    {
       
        public string titre { get; set; }
        public string auteur { get; set; }
        public string path { get; set; }
        public bool hasCopyright { get; set; }
        public Type type { get; set; }

        public Document() { }

        public Document(string _titre="", string _path="", bool _hasCopyright=false)
        {
            titre = _titre;
            path = _path;
            hasCopyright = _hasCopyright;
        }

        public void Modifier(string _titre, string _path, bool _hasCopyright)
        {
            titre = _titre;
            path = _path;
            hasCopyright = _hasCopyright;
        }

        public abstract string Afficher();
    }
}

