namespace BlazorAppFuncionario.Model
{
    public class Gerente:Funcionario
    {

        public override double Bonificacao()
        {
            return salario * 0.15;
        }
    }
}
