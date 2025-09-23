using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritmeticos.Controllers
{
    public class Exercicio5Controller : Controller
    {
        [HttpGet("ReajustePercentual")]
        public string ReajustePercentual(double saldo)
        {
            double saldoReajustado;
            saldoReajustado = saldo * 1.01;
            return $"O novo saldo é: {saldoReajustado}";
        }
    }
}
