using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppBaccarat.Model;

namespace WpfAppBaccarat.ViewModel
{
    public class GestionNumsJoues
    {
        public NumsJoues NumsJouesVM { get; set; }
        public GestionNumsJoues(NumsJoues numsJoues)
        {
            NumsJouesVM = numsJoues;
        }
    }
}
