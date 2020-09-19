using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppBaccarat.Utils;

namespace WpfAppBaccarat
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AfficherResultat_Click(object sender, RoutedEventArgs e)
        {           
            string numerosSortisString = txtNumsTombes.Text;
            string numerosJouesString = txtNumsJoues.Text;
            string[] numerosSortisArray = ArrayStringFunctions.StrToArray(numerosSortisString);
            string[] numerosJouesArray = ArrayStringFunctions.StrToArray(numerosJouesString);
            string[] resultatsArray = ArrayFunctions.GainOrLoss(numerosSortisArray, numerosJouesArray);
            txtResultats.Text = ArrayStringFunctions.ArrayToString(resultatsArray);

        }
    }
}
