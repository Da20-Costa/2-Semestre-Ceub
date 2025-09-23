namespace WebApiExercicios4_6.Model
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
        public int idade;

        public Pessoa (string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        public Pessoa()
        {
            nome = "Roberto";
            cpf = "555.555.555-55";
            idade = 18;
        }

        public void AlterarPessoa(string novoNome, string novoCpf, int novaidade)
        {
            this.nome = novoNome;
            this.cpf = novoCpf;
            this.idade = novaidade;
        }
    }
}
