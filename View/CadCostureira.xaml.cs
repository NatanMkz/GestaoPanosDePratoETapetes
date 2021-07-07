using GestaoPanosDePratoETapetes.Models;
<<<<<<< HEAD
=======
using GestaoPanosDePratoETapetes.Repository;
>>>>>>> 733f2d8fe7ddb14e1b77a55a4d21057f7061c3a7
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
<<<<<<< HEAD
            List<Costureira> info = new List<Costureira>();            
            info.Add(new Costureira( int.Parse( txtId.Text), txtNome.Text, txtTelefone.Text, txtEndereco.Text, null, int.Parse(txtTotal.Text)));
=======
            using (var dataContext = new DataBase())
            {
                dataContext.Costureira.Add(new Costureira(int.Parse(txtId.Text), txtNome.Text, txtTelefone.Text, txtEndereco.Text, null, int.Parse(txtTotal.Text)));
                dataContext.SaveChanges();
                var a = dataContext.Costureira.ToList();
            }
              
>>>>>>> 733f2d8fe7ddb14e1b77a55a4d21057f7061c3a7
        }

        
    }
}
