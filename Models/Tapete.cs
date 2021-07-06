using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class Tapete : Pano
    {
        private double _precoVenda;

        public Tapete(int id, string nome, int remessa, int quantidade, DateTime dataEntrega, DateTime dataColeta, double precoVenda) : base(id, nome, remessa, quantidade, dataEntrega, dataColeta)
        {
            _precoVenda = precoVenda;
        }

        public double PrecoVenda { get => _precoVenda; set => _precoVenda = value; }

        public double TotalEmReais()
        {
            return this.Quantidade * _precoVenda;
        }



    }
}
