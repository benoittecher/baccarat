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

        private void AddPlayerToJoue_Click(object sender, RoutedEventArgs e)
        {
            txtNumsJoues.Text += "P" + Environment.NewLine;
        }

        private void AddBankerToJoue_Click(object sender, RoutedEventArgs e)
        {
            txtNumsJoues.Text += "B" + Environment.NewLine;
        }

        private void AddTieToJoue_Click(object sender, RoutedEventArgs e)
        {
            txtNumsJoues.Text += "T" + Environment.NewLine;
        }

        private void AddPlayerToReel_Click(object sender, RoutedEventArgs e)
        {
            txtNumsTombes.Text += "P" + Environment.NewLine;
        }
        private void AddBankerToReel_Click(object sender, RoutedEventArgs e)
        {
            txtNumsTombes.Text += "B" + Environment.NewLine;
        }
        private void AddTieToReel_Click(object sender, RoutedEventArgs e)
        {
            txtNumsTombes.Text += "T" + Environment.NewLine;
        }

        private void Initialisation_Click(object sender, RoutedEventArgs e)
        {
            txtNumsJoues.Text = String.Empty;
            for (int i = 0; i < 17; i++)
            {
                txtNumsJoues.Text += "I " + Environment.NewLine;
            }
        }

        private void AddIgnoreToJoue_Click(object sender, RoutedEventArgs e)
        {
            txtNumsJoues.Text += "I" + Environment.NewLine;
        }

        private void AddIgnoreToReel_Click(object sender, RoutedEventArgs e)
        {
            txtNumsTombes.Text += "I" + Environment.NewLine;
        }
    }
}
