using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBaccarat.Model
{
    public abstract class Montante
    {
        public float SoldeInitial { get; set; }
        public float MiseInitiale { get; set; }
        public string[] ListeResultats { get; set; }
        public abstract float[] ListeMise();
        public float[] ListeSolde()
        {
            float[] listeMise = ListeMise();
            int _l = ListeResultats.Length;
            float[] listeSolde = new float[_l + 1];
            listeSolde[0] = SoldeInitial;
            for (int i = 1; i <= _l; i++)
            {
                switch (ListeResultats[i - 1])
                {
                    case "Gagné":
                        listeSolde[i] = listeSolde[i-1] + listeMise[i - 1];
                        break;
                    case "Nul":
                        listeSolde[i] = listeSolde[i - 1];
                        break;
                    case "Perdu":
                        listeSolde[i] = listeSolde[i-1] - listeMise[i - 1];
                        break;
                    default:
                        break;
                }
            }
            return listeSolde;
        }
        public Montante()
        {
            SoldeInitial = 1000;
            MiseInitiale = 1;
        }
    }
}
