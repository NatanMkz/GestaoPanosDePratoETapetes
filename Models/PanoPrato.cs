using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class PanoPrato : Pano
    {
        private int _deficeToalhas;
        private Costureira _costureira;

        public PanoPrato(int id, string nome, int remessa, int quantidade, DateTime dataEntrega, DateTime dataColeta, int deficeToalhas, Costureira costureira) : base(id, nome, remessa, quantidade, dataEntrega, dataColeta)
        {
            _deficeToalhas = deficeToalhas;
            _costureira = costureira;
        }

        public int DeficeToalhas { get => _deficeToalhas; set => _deficeToalhas = value; }
        public Costureira Costureira { get => _costureira; set => _costureira = value; }

        public int AdicionarDeficeToalhas(int numero)
        {
            DeficeToalhas += numero;
            return DeficeToalhas;
        }

        public int RemoverDeficeToalhas(int numero)
        {
            if(DeficeToalhas < numero)
            {
                DeficeToalhas = 0;
                return DeficeToalhas;
            }
            DeficeToalhas += numero;
            return DeficeToalhas;
        }

    }
}
