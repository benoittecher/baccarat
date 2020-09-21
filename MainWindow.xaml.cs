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
using WpfAppBaccarat.View;
using WpfAppBaccarat.ViewModel;

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
            ChargerSaisieResultats();
        }

        private void ChargerSaisieResultats()
        {
            frmPrincipal.Navigate(new PgSaisieResultats());
        }

        private void GoToResults_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
