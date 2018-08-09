using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjTransferencia
{
   public class Romaneio
    {
        public int IDRomaneio { get; set; }
        public int IDCliente { get; set; }
        public int IDTransportador { get; set; }
        public int IDFornecedor { get; set; }
        public int IDFruta { get; set; }
        public int QtdFrutas { get; set; }
        public int IDCarregamento { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal Seguro { get; set; }
        public decimal AdiantFretMot { get; set; }
        public DateTime DataRomaneio { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataExclusao{ get; set; }
        public string FormaPagamento { get; set; }
        public decimal CustoCarregamento { get; set; }
        public decimal ValorComissao { get; set; }
        public decimal ValorTotalRomaneio { get; set; }
        public decimal TaxaNf { get; set; }   
        public string UnidMedida { get; set; }
        public char Status { get; set; }
        public string Cliente { get; set; }
        public string Transportador { get; set; }
        public string Fornecedor { get; set; }
        public string Fruta { get; set; }
        public string Placa { get; set; }
        public string Veiculo { get; set; }

        public string objRomaneio { get; set; }

    }
    public class RomaneioLista : List<Romaneio> { }
}
