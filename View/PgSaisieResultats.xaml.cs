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
using WpfAppBaccarat.Model;
using WpfAppBaccarat.Utils;
using WpfAppBaccarat.ViewModel;

namespace WpfAppBaccarat.View
{
    /// <summary>
    /// Logique d'interaction pour PgSaisieResultats.xaml
    /// </summary>
    public partial class PgSaisieResultats : Page
    {
        public Jeu jeu;
        public GestionJeu gj;
        public PgSaisieResultats()
        {
            InitializeComponent();
            jeu = new Jeu();
            gj = new GestionJeu(jeu);
            
        }
        public PgSaisieResultats(Jeu jeu)
        {
            InitializeComponent();
            this.jeu = jeu;
            gj = new GestionJeu(jeu);
        }
        private void AfficherResultat_Click(object sender, RoutedEventArgs e)
        {
            
            jeu.NumsJoues = ArrayStringFunctions.StrToArray(txtNumsJoues.Text);
            jeu.NumsTombes = ArrayStringFunctions.StrToArray(txtNumsTombes.Text);
            /*string numerosSortisString = txtNumsTombes.Text;
            string numerosJouesString = txtNumsJoues.Text;
            string[] numerosSortisArray = ArrayStringFunctions.StrToArray(numerosSortisString);
            NumsTombes nt = new NumsTombes();
            nt.List = numerosSortisArray;
            string[] numerosJouesArray = ArrayStringFunctions.StrToArray(numerosJouesString);
            string[] resultatsArray = ArrayFunctions.GainOrLoss(numerosSortisArray, numerosJouesArray);*/
            txtResultats.Text = ArrayStringFunctions.ArrayToString(gj.GetResults());

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

        private void GoToPgMontantes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PgMontante(gj));
        }
    }
}
