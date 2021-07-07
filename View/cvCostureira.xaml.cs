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
    /// Interação lógica para cvCostureira.xam
    /// </summary>
    public partial class cvCostureira : Page
    {
        public cvCostureira()
        {
            InitializeComponent();
        }

        public void ListarCostureira()
        {
            List<Costureira> info = new List<Costureira>();
            //info.Add(new Costureira(int.Parse(txtId.Text), txtNome.Text, txtTelefone.Text, txtEndereco.Text, null, int.Parse(txtTotal.Text)));
            //info.Add(new Costureira(int.Parse(), string nome, string telefone, string endereco, TipoPessoa tipo, int totalToalhas));
            info.Add(new Costureira(1, "Vilmar", "3350-3020", "Brusque, algum bairro", new TipoPessoa(1, "Costureiro"), 0));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadCostureira pessoa = new CadCostureira();
            NavigationService.Navigate(pessoa);
        }
    }
}
