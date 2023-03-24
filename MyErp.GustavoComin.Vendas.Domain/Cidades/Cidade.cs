using MyErp.GustavoComin.Vendas.Domain.Common;
using MyErp.GustavoComin.Vendas.Domain.Ufs;

namespace MyErp.GustavoComin.Vendas.Domain.Cidades
{
    public class Cidade : Identificador
    {
        public string NomeCidade { get; set; }
        public int CodigoUf { get; set; }
        public Uf Uf { get; set; }
    }
}