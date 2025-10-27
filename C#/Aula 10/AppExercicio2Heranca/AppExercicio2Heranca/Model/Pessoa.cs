using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Heranca.Model
{
    public class Pessoa
    {
        private string cpf;
        private string nome;
        private string endereco;
        private DateTime dataNascimento;
        private string telefone;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
