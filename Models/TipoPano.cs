using System;
using System.Collections.Generic;
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

        public TipoPano(int id, string nome, double precoUnidadeFabricacao)
        {
            _id = id;
            _nome = nome;
            _precoUnidadeFabricacao = precoUnidadeFabricacao;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double PrecoUnidadeFabricacao { get => _precoUnidadeFabricacao; set => _precoUnidadeFabricacao = value; }

        public int GetID()
        {
            return 0;
        }

        public string GetNome()
        {
            return "";
        }

        public double GetPrecoUnidadeFabricacao()
        {
            return 0;
        }



    }
}
