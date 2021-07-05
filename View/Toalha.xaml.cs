using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GestaoPanosDePratoETapetes.Models;

namespace GestaoPanosDePratoETapetes.View
{
    /// <summary>
    /// Interaction logic for Toalha.xaml
    /// </summary>
    public partial class Toalha : Window
    {
        public Toalha()
        {
            InitializeComponent();
            dtgToalhas.DataContext = new List<PanoPrato>();
        }
    }
}
