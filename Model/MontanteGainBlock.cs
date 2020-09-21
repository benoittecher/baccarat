using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBaccarat.Model
{
    public class MontanteGainBlock : Montante
    {
        public override float[] ListeMise()
        {
            int _l = ListeResultats.Length;
            float[] listeMise = new float[_l];
            listeMise[0] = MiseInitiale;

            return listeMise;
        }
    }
}
