using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class Ctrl
    {
        public Mediatheque mediatheque {get; set;}
        public MainForm mainform { get; set; }

        public Ctrl(Mediatheque _m, MainForm _mf)
        {
            mediatheque = _m;
            mainform = _mf;
        }
    }
}
