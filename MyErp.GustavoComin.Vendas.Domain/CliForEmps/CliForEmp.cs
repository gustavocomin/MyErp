using MyErp.GustavoComin.Vendas.Domain.Cidades;
using MyErp.GustavoComin.Vendas.Domain.Common;

namespace MyErp.GustavoComin.Vendas.Domain.CliForEmps
{
    public class CliForEmp : Identificador
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public bool Vendedor { get; set; }
        public bool Cliente { get; set; }
        public bool Fornecedor { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string ComplementoEnd { get; set; }
        public string NumeroEnd { get; set; }
        public int CodigoCidade { get; set; }
        public Cidade Cidade { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Fone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
