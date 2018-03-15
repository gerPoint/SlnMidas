﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class CarregamentoBloco
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
        public decimal ValorUnitP { get; set; }
        public decimal ValorUnitM { get; set; }
        public decimal ValorUnitG { get; set; }
        public decimal TotalBloco { get; set; }
        
        public decimal TotalCarreg { get; set; }
        


    }


    public class ListaCarregamentoBloco: List<CarregamentoBloco> { }
}

