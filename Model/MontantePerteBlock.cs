using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBaccarat.Model
{
    public class MontantePerteBlock : Montante
    {
        public override float[] ListeMise()
        {
            int _l = ListeResultats.Length;
            float[] listeMise = new float[_l];
            listeMise[0] = MiseInitiale;
            for (int i = 0; i < _l-1; i++)
            {
                int cycle = 0;
                int etape = 0;
                switch (ListeResultats[i])
                {
                    case "Gagné":
                        listeMise[i + 1] = MiseInitiale;
                        break;
                    case "Nul":
                        listeMise[i + 1] = listeMise[i];
                        break;
                    case "Perdu":
                        if (etape == 3)
                        {
                            cycle++;
                            etape = 0;
                            listeMise[i + 1] = (long)Math.Pow(2, cycle) * MiseInitiale;
                        } else
                        {
                            listeMise[i + 1] = 2 * listeMise[i];
                            etape++;
                        }
                        break;
                    default:
                        break;
                }
            }
            return listeMise;
        }

        
        
    }
}
