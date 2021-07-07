using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class Pessoa
    {

        private int _id;
        private string _nome;
        private string _telefone;
        private string _endereco;
        private TipoPessoa _tipo;

        public Pessoa()
        {

        }

        public Pessoa(int id, string nome, string telefone, string endereco, TipoPessoa tipo)
        {
            _id = id;
            _nome = nome;
            _telefone = telefone;
            _endereco = endereco;
            _tipo = tipo;
        }

        public int Id { get => _id; }
        public string Nome { get => _nome; }
        public string Telefone { get => _telefone; }
        public string Endereco { get => _endereco; }
       
        public TipoPessoa Tipo
        {
            get { return _tipo; }
        }

    }

}
