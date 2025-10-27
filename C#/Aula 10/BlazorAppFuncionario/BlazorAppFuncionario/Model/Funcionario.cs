namespace BlazorAppFuncionario.Model
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        public string Nome { get => nome; set => nome = value; }

        public virtual double RetornarSalario(int horas)
        {
            salario = horas * 100;
            return salario;
        }
    }
}
