using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritmeticos.Controllers
{
    public class Exercicio4Controller : Controller
    {
        [HttpGet("MediaSemestral")]
        public string MediaSemestral(double nota1Usuario, double nota2Usuario, double nota3Usuario, double nota4Usuario)
        {
            double media4Notas;
            media4Notas = (nota1Usuario + nota2Usuario + nota3Usuario + nota4Usuario) / 4;
            return $"A média final do aluno é: {media4Notas}";
        }
    }
}
