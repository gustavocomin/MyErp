using MyErp.GustavoComin.Vendas.Domain.Common;
using MyErp.GustavoComin.Vendas.Domain.Itens.ItensFornec;

namespace MyErp.GustavoComin.Vendas.Domain.Itens
{
    public class Item : Identificador
    {
        public string Descricao { get; set; }
        public decimal MinValor { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal ValorUnitCompra { get; set; }
        public decimal PercMargem { get; set; }
        public bool Venda { get; set; }
        public bool Compra { get; set; }
        public decimal EstoqueMin { get; set; }
        public decimal EstoqueMax { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal PesoLiq { get; set; }
        public int CodigoUnidade { get; set; }

        public virtual HistItemFornec? HistItemFornec { get; set; }
    }
}
