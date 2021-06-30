using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class PanoPrato
    {
        private int _deficeToalhas;
        private Costureira _costureira;

        public PanoPrato(int deficeToalhas, Costureira costureira)
        {
            _deficeToalhas = deficeToalhas;
            _costureira = costureira;
        }

        public int DeficeToalhas { get => _deficeToalhas; set => _deficeToalhas = value; }
        public Costureira Costureira { get => _costureira; set => _costureira = value; }

        public Costureira GetCostureira()
        {
            return Costureira;
        }

        public int GetDeficeToalhas()
        {
            return 0;
        }

        public int AdicionarDeficeToalhas()
        {
            return 0;
        }
           
        public int RemoverDeficeToalhas()
        {
            return 0;
        }

    }
}
