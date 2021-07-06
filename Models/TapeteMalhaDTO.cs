using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
   public class TapeteMalhaDTO
    {
        private Tapete _tapete;
        private Malha _malha;

        public TapeteMalhaDTO(Tapete tapete, Malha malha)
        {
            _tapete = tapete;
            _malha = malha;
        }

        public Tapete Tapete { get => _tapete; set => _tapete = value; }
        public Malha Malha { get => _malha; set => _malha = value; }
    }
}
