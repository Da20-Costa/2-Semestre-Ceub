using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlugaFacil.Model
{
    public class Carro
    {
        public Int32 idCarro;
        public string placa;
        public string fabricante;
        public string modelo;
        public Int32 ano;
        public string cor;
        public double valorDiaria;

        public string ImprimirCarro()
        {
            string resultado;
            resultado = $"Placa: {placa}\r\nFabricante: {fabricante}\r\nModelo: {modelo}\r\nAno: {ano}\r\nCor: {cor}\r\nValor da diária: {valorDiaria}";
            return resultado;
        }
    }
}
