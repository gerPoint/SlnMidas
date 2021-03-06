﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjTransferencia
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public char Status { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }

        public string objCliente { get; set; }
    }

    public class ClienteLista : List<Cliente> { }
}
