using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBaccarat.Utils
{
    public abstract class ArrayFunctions
    {
        public static string[] GainOrLoss(string[] numerosSortis, string[] numerosJoues)
        {
            int i = numerosSortis.Length;
            int j = numerosJoues.Length;
            string[] result = new string[i];
            for (int k = 0; k < j; k++)
            {
                if (numerosSortis[k].Equals("T")) result[k] = "Nul";
                else result[k] = (numerosSortis[k].Equals(numerosJoues[k])) ? "Gagné" : "Perdu";
            }
            for (int k = j; k < i; k++)
            {
                result[k] = "Nul";
            }
            return result;
        }


    }
}
