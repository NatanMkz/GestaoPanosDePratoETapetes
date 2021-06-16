using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class TipoPessoa
    {
        int _id;
        string _nome;

        public TipoPessoa(int id, string nome)
        {
            _id = id;
            _nome = nome;
        }

        public int Id { get => _id;}
        public string Nome { get => _nome;}
    }
}
