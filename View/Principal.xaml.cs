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

namespace GestaoPanosDePratoETapetes.View
{
    /// <summary>
    /// Interação lógica para Principal.xam
    /// </summary>
    public partial class Principal : Page
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Toalhas_Click(object sender, RoutedEventArgs e)
        {
            ToalhaPage toalhaPage = new ToalhaPage();
            NavigationService.Navigate(toalhaPage);
            // dtgPrincipal.Content = null;
            // dtgPrincipal.Content = toalhaPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TapetePage tapete = new TapetePage();
            NavigationService.Navigate(tapete);
            
            // Navigatio
            // dtgPrincipal.Content = null;
            // dtgPrincipal.Content = tapete;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadCostureira pessoa = new CadCostureira();
            NavigationService.Navigate(pessoa);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CadPano cadpano = new CadPano();
            NavigationService.Navigate(cadpano);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            cvCostureira costureira = new cvCostureira();
            NavigationService.Navigate(costureira);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            cvPano pano = new cvPano();
            NavigationService.Navigate(pano);
        }
    }
}
