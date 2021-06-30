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

        public int GetTotalToalhas()
        {
            return 0;
        }

        public int RemoverToalhas(int numero)
        {
            return 0;
        }

        public int AdicionarToalhas(int numero)
        {
            return 0;
        }

    }
}
