using GestaoPanosDePratoETapetes.Models;
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
    /// Interação lógica para cvPano.xam
    /// </summary>
    public partial class cvPano : Page
    {
        public cvPano()
        {
            InitializeComponent();
        }

        public void ListarPanos()
        {
            var a = new List<PanoPrato>();
            a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 1, null));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadPano pano = new CadPano();
            NavigationService.Navigate(pano);
        }
        
    }
}
