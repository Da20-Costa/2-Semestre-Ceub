using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Heranca.Model
{
    public class Veiculo
    {
        private string renavam;
        private string marca;
        private string modelo;
        private Int32 ano;
        private string placa;
        private Int32 numeroRodas;
        private string cor;

        public string Renavam { get => renavam; set => renavam = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public string Placa { get => placa; set => placa = value; }
        public int NumeroRodas { get => numeroRodas; set => numeroRodas = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
