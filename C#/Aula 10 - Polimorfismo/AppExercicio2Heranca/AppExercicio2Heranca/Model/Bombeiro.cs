using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Heranca.Model
{
    public class Bombeiro:Pessoa
    {
        private string matricula;
        private string arma;
        private DateTime dataAdmissao;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Arma { get => arma; set => arma = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
    }
}
