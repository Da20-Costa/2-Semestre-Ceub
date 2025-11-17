using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Heranca.Model
{
    public class Caminhao:Veiculo
    {
        private double capacidadeCarga;
        private double altura;
        private Int32 numeroEixos;

        public double CapacidadeCarga { get => capacidadeCarga; set => capacidadeCarga = value; }
        public double Altura { get => altura; set => altura = value; }
        public int NumeroEixos { get => numeroEixos; set => numeroEixos = value; }
    }
}
