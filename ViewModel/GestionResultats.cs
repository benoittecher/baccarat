using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppBaccarat.Model;

namespace WpfAppBaccarat.ViewModel
{
    public class GestionResultats
    {
        public Resultats ResultatVM { get; set; }
        public GestionResultats(Resultats resultats)
        {
            ResultatVM = resultats;
        }
    }
}
