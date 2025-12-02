using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppSistemaVendaBCC.Entities
{
    [Table("tbItemVenda")]
    public class ItemVenda
    {
        [Column("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        [Column("PedidoId")]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
