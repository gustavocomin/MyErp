using MyErp.GustavoComin.Vendas.Domain.CliForEmps;
using MyErp.GustavoComin.Vendas.Domain.Common;

namespace MyErp.GustavoComin.Vendas.Domain.Itens.ItensFornec
{
    public class HistItemFornec : Identificador
    {
        public int CodigoItem { get; set; }
        public int CodigoFornecedor { get; set; }
        public CliForEmp Fornecedor { get; set; }
        public DateTime DataUltimaCompra { get; set; }
        public decimal UltimoValorCompra { get; set; }
        public decimal MenorValorCompra { get; set; }
        public DateTime DataMenorValorCompra { get; set; }
        public decimal MaioValorCompra { get; set; }
        public DateTime DataMaioValorCompra { get; set; }
    }
}
