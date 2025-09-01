using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritmeticos.Controllers
{
    public class Exercicio6Controller : Controller
    {
        [HttpPost("AreaTrapezio")]
        public string AreaTrapezio(double baseMaior, double baseMenor, double altura)
        {
            double areaTrapezio;
            areaTrapezio = ((baseMaior + baseMenor) * altura) / 2;
            return $"A área do trapézio é: {areaTrapezio}";
        }
    }
}
