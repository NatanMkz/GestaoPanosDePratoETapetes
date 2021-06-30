using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class Malha
    {
        private double _precoVenda;

        public Malha()
        {

        }

        public Malha(double precoVenda)
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
