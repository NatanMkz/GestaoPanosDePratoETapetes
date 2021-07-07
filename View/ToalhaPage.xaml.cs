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
using GestaoPanosDePratoETapetes.Models;
using GestaoPanosDePratoETapetes.Repository;

namespace GestaoPanosDePratoETapetes.View
{
    /// <summary>
    /// Interaction logic for ToalhaPage.xaml
    /// </summary>
    public partial class ToalhaPage : Page
    {
        public ToalhaPage()
        {
            InitializeComponent();


            var a = new List<PanoPrato>();
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Vilmar","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Natan","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Vilmar","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Natan","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Vilmar","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Natan","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Vilmar","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));
            //a.Add(new PanoPrato(1, "Teste", 1, 10, DateTime.Now, DateTime.Now, 2, new Costureira(1,"Natan","3350-3020", "Brusque, algum bairro", new TipoPessoa(1,"Costureiro"),0)));

            dtgToalhas.ItemsSource = a;
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadPano pano = new CadPano();
            NavigationService.Navigate(pano);
        }
    }
}
