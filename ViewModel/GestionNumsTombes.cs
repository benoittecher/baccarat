using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppBaccarat.Model;

namespace WpfAppBaccarat.ViewModel
{
    public class GestionNumsTombes
    {
        public NumsTombes NumsTombesVM { get; set; }
        public GestionNumsTombes(NumsTombes numsTombes)
        {
            NumsTombesVM = numsTombes;
        }
    }
}
