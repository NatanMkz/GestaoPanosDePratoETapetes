using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class Costureira
    {
        private int _totalToalhas;

        public Costureira(int totalToalhas)
        {
            _totalToalhas = totalToalhas;
        }

        public int TotalToalhas { get => _totalToalhas; set => _totalToalhas = value; }

        public int RemoverToalhas(int numero)
        {
            if(TotalToalhas < numero)
            {
                TotalToalhas = 0;
                return TotalToalhas;
            }
            TotalToalhas -= numero;
            return TotalToalhas;
        }

        public int AdicionarToalhas(int numero)
        {
            TotalToalhas += numero;
            return TotalToalhas;
        }

    }
}
