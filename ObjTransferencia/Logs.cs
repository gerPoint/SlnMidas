using System;

namespace ObjTransferencia
{
    class Logs
    {
        public int IDLog { get; set; };
        public int IDUsuario { get; set; };
        public string Tabela { get; set; };
        public string ValorAnterior { get; set; };
        public string ValorPosterior { get; set; };
        public DateTime DataHora { get; set; };
    }
}
