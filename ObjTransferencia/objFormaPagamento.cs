using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class FormaPagamento
    {
        public int IDFormaPagamento { get; set; }
        public string Descricao { get; set; }
        public string Parcelamento { get; set; }
        public char Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public string objFormaPagamento { get; set; }
    }
    public class FormaPagamentoLista : List<FormaPagamento> { }
}
