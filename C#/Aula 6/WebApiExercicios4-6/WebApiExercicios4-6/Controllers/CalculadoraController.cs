using Microsoft.AspNetCore.Mvc;
using WebApiExercicios4_6.Model;

namespace WebApiExercicios4_6.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet("Calcular")]
        public string Calcular (double valor1, double valor2)
        {
            Calculadora calculadora = new Calculadora();
            double soma = calculadora.Somar(valor1, valor2);
            double subtracao = calculadora.Subtrair(valor1, valor2);
            double multiplicacao = calculadora.Multiplicar(valor1, valor2);
            double divisao = calculadora.Dividir(valor1, valor2);

            return $"Soma: {soma}\nSubtração: {subtracao}\nMultiplicação: {multiplicacao}\nDivisão: {divisao}";
        }
    }
}
