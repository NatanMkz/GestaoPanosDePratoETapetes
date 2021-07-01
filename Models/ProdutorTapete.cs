﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPanosDePratoETapetes.Models
{
    public class ProdutorTapete
    {
        private int _credito;

        public ProdutorTapete(int credito)
        {
            _credito = credito;
        }

        public int Credito { get => _credito; set => _credito = value; }
    }
}