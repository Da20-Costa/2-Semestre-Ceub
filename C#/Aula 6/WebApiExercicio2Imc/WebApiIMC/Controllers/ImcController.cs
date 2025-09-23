using Microsoft.AspNetCore.Mvc;
using WebApiIMC.Model;

namespace WebApiIMC.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet("ImprimirIndiceImc")]
        public string ImprimirIndiceImc (string nomeUsuario1, double alturaUsuario1, double pesoUsuario1, string nomeUsuario2, double alturaUsuario2, double pesoUsuario2)
        {
            Pessoa pessoa1 = new Pessoa ();
            pessoa1.nomePessoa = nomeUsuario1;
            pessoa1.alturaPessoa = alturaUsuario1;
            pessoa1.pesoPessoa = pesoUsuario1;

            Int32 indiceImcPessoa1 = pessoa1.CalcularImc(pessoa1.alturaPessoa, pessoa1.pesoPessoa);
            string classificacaoImcPesoa1 = pessoa1.ClassificarImc(indiceImcPessoa1);

            Pessoa pessoa2 = new Pessoa ();
            pessoa2.nomePessoa = nomeUsuario2;
            pessoa2.alturaPessoa = alturaUsuario2;
            pessoa2.pesoPessoa = pesoUsuario2;

            Int32 indiceImcPessoa2 = pessoa2.CalcularImc(pessoa2.alturaPessoa, pessoa2.pesoPessoa);
            string classificacaoImcPesoa2 = pessoa2.ClassificarImc(indiceImcPessoa2);


            return $"Nome: {pessoa1.nomePessoa}\nIMC: {indiceImcPessoa1}\nClassificação: {classificacaoImcPesoa1}\n\nNome: {pessoa2.nomePessoa}\nIMC: {indiceImcPessoa2}" +
                $"\nClassificação: {classificacaoImcPesoa2}";
        }
    }
}
