using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppBaccarat.Model;
using WpfAppBaccarat.Utils;

namespace WpfAppBaccarat.ViewModel
{
    public class GestionJeu
    {
        public Jeu jeu;

        public GestionJeu()
        {
        }

        public GestionJeu(Jeu jeu)
        {
            this.jeu = jeu;
        }

        public string[] GetResults()
        {
            return ArrayFunctions.GainOrLoss(jeu.NumsTombes, jeu.NumsJoues);
        }
    }
}
