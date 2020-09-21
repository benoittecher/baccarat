using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBaccarat.Utils
{
    // Cette classe sert à convertir les strings avec saut de ligne en string[] et vice-versa
    public class ArrayStringFunctions
    {
        // Une méthode pour passer d'une string avec saut de ligne à un tableau. Trims effectués.
        public static string[] StrToArray(string strBrute)
        {
            char[] spliter = Environment.NewLine.ToCharArray();
            string[] strSplit = strBrute.Split(spliter, 1000, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strSplit.Length; i++)
            {
                strSplit[i] = strSplit[i].Trim();
            }
            return strSplit;
        }

        // Une qui passe d'un string[] à une string avec saut de ligne
        public static string ArrayToString(string[] arrayToConvert)
        {
            string result = "";
            for (int i = 0; i < arrayToConvert.Length; i++)
            {
                result += arrayToConvert[i].Trim() + " " + Environment.NewLine;
            }
            return result;
        }
        // Surcharge pour les tableaux de nombres à convertir en string
        public static string ArrayToString(float[] arrayToConvert)
        {
            int _l = arrayToConvert.Length;
            string[] stringArray = new string[_l];
            for (int i = 0; i < _l; i++)
            {
                stringArray[i] = arrayToConvert[i].ToString();
            }
            return ArrayToString(stringArray);
        }
    }
}
