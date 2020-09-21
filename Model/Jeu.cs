using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBaccarat.Model
{
    public class Jeu
    {
        public string[] NumsJoues { get; set; }
        public string[] NumsTombes { get; set; }
        // public string[] Resultats { get; set; }
        public float CapitalInitial { get; set; }
        public float[] Mises { get; set; }
    }
}
