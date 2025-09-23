using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlugaFacil.Model
{
    public class Cliente
    {
        public Int32 idCliente;
        public string nome;
        public string cpf;
        public string cnh;

        public string ImprimirCliente()
        {
            string resultado;
            resultado = $"CPF: {cpf}\r\nNome: {nome}\r\nCNH: {cnh}";
            return resultado;
        }
    }
}
