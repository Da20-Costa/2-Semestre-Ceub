namespace BlazorAppFuncionario.Model
{
    public class Diretor:Funcionario
    {
        public override double RetornarSalario(int horas)
        {
            return horas * 200;
        }
    }
}
