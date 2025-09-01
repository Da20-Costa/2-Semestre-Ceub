using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritmeticos.Controllers
{
    public class Exercicio3Controller : Controller
    {
        [HttpGet("Media3numeros")]
        public string Media3numeros(double numero1Usuario, double numero2Usuario, double numero3Usuario)
        {
            double numero1, numero2, numero3, media;
            numero1 = numero1Usuario;
            numero2 = numero2Usuario;
            numero3 = numero3Usuario;
            media = (numero1 + numero2 + numero3) / 3;
            return $"A média dos 3 números é: {media}";
        }
    }
}
