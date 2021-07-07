using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public TipoPessoa Tipo { get => _tipo; set => _tipo = value; }
    }

}
