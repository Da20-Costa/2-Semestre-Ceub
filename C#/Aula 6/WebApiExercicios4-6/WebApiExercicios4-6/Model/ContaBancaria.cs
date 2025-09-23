namespace WebApiExercicios4_6.Model
{
    public class ContaBancaria
    {
        public string nomeCliente;
        public int numeroConta;
        public double saldoConta;

        public ContaBancaria()
        {
            saldoConta = 100;
        }

        public void Sacar(double valorSacado)
        {
            this.saldoConta -= valorSacado;
        }

        public void Depositar(double valorDepositado)
        {
            this.saldoConta += valorDepositado;
        }

        public double ConsultarSaldo()
        {
            return this.saldoConta;
        }

        public string ConsultarNome()
        {
            return this.nomeCliente;
        }

        public void AlterarNome(string nomeAlterado)
        {
            this.nomeCliente = nomeAlterado;
        }
    }
}
