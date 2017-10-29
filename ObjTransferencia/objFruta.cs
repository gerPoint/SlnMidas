using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    class Fruta
    {
        public int IDFruta { get; set; }
        public string Nome { get; set; }
        public string UnidMedida { get; set; }
        public char Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public string objFruta { get; set; }
    }
   // public class FrutaLista : List<Fruta> { }
}
