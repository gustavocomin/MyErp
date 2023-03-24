using MyErp.GustavoComin.Vendas.Domain.Common;

namespace MyErp.GustavoComin.Vendas.Domain.Unidades
{
    public class Unidade : Identificador
    {
        public string Descricao { get; set; }
        public string Sigla { get; set; }
    }
}
