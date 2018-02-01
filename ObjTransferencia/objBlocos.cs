using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
    public class Blocos
    {
        //public Venda Venda { get; set; }
        public string Bloco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public int IDRomaneio { get; set; }
    }

    public class BlocosLista : List<Blocos> { }
}
