namespace BlazorVendas.Model
{
    public class ItemVenda
    {
        public Int32 produtoId { get; set; }
        public Int32 vendaId { get; set; }
        public Int32 quantidadeProduto { get; set; }
        public double precoUnitario { get; set; }

        public void InserirItem()
        {
            //Inserir
        }

        public void ExcluirItem(Int32 vendaId)
        {
            //Excluir
        }
    }
}
