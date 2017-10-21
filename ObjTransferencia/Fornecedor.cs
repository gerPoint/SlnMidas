using System;
namespace ObjTransferencia
{
    public class Fornecedor
    {
        public int IDFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public char Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
