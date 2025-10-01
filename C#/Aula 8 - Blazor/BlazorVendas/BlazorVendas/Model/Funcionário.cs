namespace BlazorVendas.Model
{
    public class Funcionário
    {
        public Int32 id { get; set; }
        public string Nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
        public DateOnly dataAdmissao { get; set; }

        //private Int32 id;
        //private string nome;
        //private string cpf;
        //private string email;
        //private string cargo;
        //private double salario;
        //private DateOnly dataAdmissao;

        //public int Id { get => id; set => id = value; }
        //public string Nome { get => nome; set => nome = value; }
        //public string Cpf { get => cpf; set => cpf = value; }
        //public string Email { get => email; set => email = value; }
        //public string Cargo { get => cargo; set => cargo = value; }
        //public double Salario { get => salario; set => salario = value; }
        //public DateOnly DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }

        public void Adicionar()
        {
            //Adiciona
        }

        public void Excluir(Int32 id)
        {
            //Exclui
        }

        public void Alterar(Int32 id)
        {
            //Altera
        }

        public string PesquisarPorId(Int32 id)
        {
            string resultado = "";
            return resultado;
        }

        public string PesquisarPorNome(string nome)
        {
            string resultado = "";
            return resultado;
        }

        public string ListarTodos()
        {
            string resultado = "";
            return resultado;
        }
    }
}
