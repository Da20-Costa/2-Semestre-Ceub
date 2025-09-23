using Microsoft.AspNetCore.Mvc;
using WebApiExercicios4_6.Model;

namespace WebApiExercicios4_6.Controllers
{
    public class PessoaController : Controller
    {
        [HttpGet("CadastrarPessoa")]
        public string CadastrarPessoa (string nomeUsuario, string cpfUsuario, int idadeUsuario)
        {
            Pessoa pessoa1 = new Pessoa(nomeUsuario, cpfUsuario, idadeUsuario);

            Pessoa pessoa2 = new Pessoa();
            string nomeOriginal = pessoa2.nome;
            string cpfOriginal = pessoa2.cpf;
            int idadeOriginal = pessoa2.idade;

            pessoa2.AlterarPessoa(nomeUsuario, cpfUsuario, idadeUsuario);

            return $"Primeiro caso:\nNome: {pessoa1.nome}\nCPF: {pessoa1.cpf}\nIdade: {pessoa1.idade}\n\n" +
                $"Segundo caso:\nNome original: {nomeOriginal}\nCPF original: {cpfOriginal}\nIdade original: {idadeOriginal}\n\n" +
                $"Nome alterado: {pessoa2.nome}\nCPF alterado: {pessoa2.cpf}\nIdade alterada: {pessoa2.idade}";
        }
    }
}
