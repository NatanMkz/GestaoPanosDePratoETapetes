using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class Costureira : Pessoa
    {
       
        private int _id;
        private int _totalToalhas;

        public Costureira(int id, string nome, string telefone, string endereco, TipoPessoa tipo, int totalToalhas) : base(id, nome, telefone, endereco, tipo)
        {
            _id = id;
            _totalToalhas = totalToalhas;
        }

        public Costureira()
        {
        }

        public int TotalToalhas { get => _totalToalhas; set => _totalToalhas = value; }
        [Key]
        public int CostureiraId { get => _id; set => _id = value; }

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
