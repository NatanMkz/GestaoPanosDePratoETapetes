using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
   public class TipoPano
    {
        int _id;
        string _nome;
        double _precoUnidadeFabricacao;

        public TipoPano()
        {

        }

        public TipoPano(int id, string nome, double precoUnidadeFabricacao)
        {
            _id = id;
            _nome = nome;
            _precoUnidadeFabricacao = precoUnidadeFabricacao;
        }
        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double PrecoUnidadeFabricacao { get => _precoUnidadeFabricacao; set => _precoUnidadeFabricacao = value; }

    }
}
