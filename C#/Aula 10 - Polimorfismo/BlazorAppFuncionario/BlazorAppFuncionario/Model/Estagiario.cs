namespace BlazorAppFuncionario.Model
{
    public class Estagiario:Funcionario
    {
        public override double RetornarSalario(int horas)
        {
            return horas * 50;
        }
    }
}
