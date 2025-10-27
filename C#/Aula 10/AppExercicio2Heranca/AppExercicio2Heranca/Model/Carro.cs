using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Heranca.Model
{
    public class Carro:Veiculo
    {
        private Int32 numeroPortas;
        private string tipoCombustivel;
        private string motorizacao;

        public int NumeroPortas { get => numeroPortas; set => numeroPortas = value; }
        public string TipoCombustivel { get => tipoCombustivel; set => tipoCombustivel = value; }
        public string Motorizacao { get => motorizacao; set => motorizacao = value; }
    }
}
