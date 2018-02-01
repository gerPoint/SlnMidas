using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransferencia
{
    public class objCarregamentoBloco
    {
        public int IDCarregamentoBloco { get; set; }
        public int IDCarregamento { get; set; }
        public string Bloco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public int IDRomaneio { get; set; }
    }


    public class ListaCarregamentoBloco: List<objCarregamentoBloco> { }
}

