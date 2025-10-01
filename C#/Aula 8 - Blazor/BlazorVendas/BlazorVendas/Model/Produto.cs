namespace BlazorVendas.Model
{
    public class Produto
    {
        public Int32 id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Int32 quantidadeEstoque { get; set; }
        public string unidadeMedida { get; set; }
        public double precoUnitario { get; set; }
        public string imgProduto { get; set; }

        public void Adicionar()
        {
            //Adicionar no banco de dados
        }

        public void Excluir(Int32 id)
        {
            //Excluir no banco de dados
        }

        public void Alterar(Int32 id)
        {
            //Alterar no banco de dados
        }

        public string PesquisarPorProdutoId(Int32 id)
        {
            string resultado = "";
            return resultado;
        }

        public string ListarTodosProdutos()
        {
            string resultado = "";
            return resultado;
        }
    }
}
