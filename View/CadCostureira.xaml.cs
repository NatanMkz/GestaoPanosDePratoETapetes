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
    /// Interação lógica para CadCostureira.xam
    /// </summary>
    public partial class CadCostureira : Page
    {
        public CadCostureira()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            List<Costureira> info = new List<Costureira>();            
            info.Add(new Costureira( int.Parse( txtId.Text), txtNome.Text, txtTelefone.Text, txtEndereco.Text, null, int.Parse(txtTotal.Text)));
        }

        
    }
}
