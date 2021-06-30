using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class Tapete
    {
        private double _precoVenda;

        public Tapete()
        {

        }

        public Tapete(double precoVenda)
        {
            PrecoVenda = precoVenda;
        }

        public double PrecoVenda { get => _precoVenda; set => _precoVenda = value; }

        public double TotalEmReais()
        {
            return 0;
        }



    }
}
