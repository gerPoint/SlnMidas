using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class ClassificFruta
    {
        public int IDClassificacao { get; set; }
        public string Classificacao { get; set; }
        public char Status { get; set; }
        public DateTime DataCadastro { get; set; }


        public string objClassificFruta { get; set; }
    }
    public class ClassificFrutaLista : List<ClassificFruta> { }
}
