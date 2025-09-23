using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGerenciamentoFinanceiro.Model
{
    public class ContaCorrente
    {
        public Int32 numeroConta;
        public string nomeBanco;
        public string nomeAgencia;
        public string nomeCliente;
        public double saldo;

        public string ImprimirConta()
        {
            string resultado;
            resultado = $"Cliente: {nomeCliente}\nBanco: {nomeBanco}\nAgência: {nomeAgencia}\nNúmero da Conta: {numeroConta}";
            return resultado;
        }
    }
}
