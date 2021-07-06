using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GestaoPanosDePratoETapetes.Models;

namespace GestaoPanosDePratoETapetes.View
{
    /// <summary>
    /// Interaction logic for Toalha.xaml
    /// </summary>
    public partial class TapetePage : Page
    {
        public TapetePage()
        {
            InitializeComponent();
            //dtgTapetes.DataContext = new List<PanoPrato>();
            var a = new List<Tapete>();
            a.Add(new Tapete(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 4));
            dtgTapetes.ItemsSource = a;
        }

        private void retornar_Click(object sender, RoutedEventArgs e)
        {
            Principal voltar = new Principal();
            this.Content = voltar;
        }
    }
}
