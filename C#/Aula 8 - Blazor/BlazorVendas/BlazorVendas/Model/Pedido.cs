namespace BlazorVendas.Model
{
    public class Pedido
    {
        public Int32 id { get; set; }
        public DateOnly dataPedido { get; set; }
        public Int32 funcionarioId { get; set; }
        public Int32 clienteId { get; set; }
        public double valorTotal { get; set; }

        public void RegistrarVenda()
        {
            //Registro
        }

        public string ListarVendas()
        {
            string resultado = "";
            return resultado;
        }
    }
}
