using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class TipoPessoa
    {
        int _id;
        string _nome;

        

        public TipoPessoa()
        {
        }

        public TipoPessoa(int id, string nome)
        {
            _id = id;
            _nome = nome;
        }
        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
