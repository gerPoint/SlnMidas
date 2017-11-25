using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class Transportador
    {
        public int IDTransportador { get; set; }
        public string Nome { get; set; }
        public string Veiculo { get; set; }
        public string Placa { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public char Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public string Endereco { get; set; }
        public string objTransportador { get; set; }
    }

    public class TransportadorLista : List<Transportador> { }
}
