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
    /// Logique d'interaction pour PgMontante.xaml
    /// </summary>
    public partial class PgMontante : Page
    {
        public GestionJeu gj { get; set; }

        public PgMontante()
        {
            InitializeComponent();
            InitializeListeMontantes();
            gj = new GestionJeu();
        }
        public PgMontante(GestionJeu gj)
        {
            InitializeComponent();
            InitializeListeMontantes();
            this.gj = gj;
        }

        private void InitializeListeMontantes()
        {
            cbbMontantes.ItemsSource = new List<String>() { "Montante perte block" };
            cbbMontantes.SelectedIndex = 0;
        }

        private void GenererListes_Click(object sender, RoutedEventArgs e)
        {
            Montante m;
            
            switch (cbbMontantes.SelectedItem)
            {
                case "Montante perte block":
                    m = new MontantePerteBlock();
                    break;
                default:
                    m = new MontantePerteBlock();
                    break;
            }
            m.SoldeInitial = float.Parse(txtSoldeInitial.Text);
            m.MiseInitiale = float.Parse(txtMiseInitiale.Text);
            m.ListeResultats = gj.GetResults();
            txtMises.Text = ArrayStringFunctions.ArrayToString(m.ListeMise());
            txtSolde.Text = ArrayStringFunctions.ArrayToString(m.ListeSolde());


        }
    }
}
