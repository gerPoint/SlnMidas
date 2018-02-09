using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class objCarregamentoBloco
    {
        public int IDCarregamentoBloco { get; set; }
        public string Bloco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int IDRomaneio { get; set; }
        public string FrutaP { get; set; }
        public string FrutaM { get; set; }
        public string FrutaG { get; set; }
        public decimal PrecoP { get; set; }
        public decimal PrecoM { get; set; }
        public decimal PrecoG { get; set; }
        public int QtdP { get; set; }
        public int QtdM { get; set; }
        public int QtdG { get; set; }




    }


    public class ListaCarregamentoBloco: List<objCarregamentoBloco> { }
}

