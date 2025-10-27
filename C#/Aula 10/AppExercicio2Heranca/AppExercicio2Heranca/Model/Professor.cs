using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Heranca.Model
{
    public class Professor:Pessoa
    {
        private string matricula;
        private string especialidade;
        private string materia;
        private string nivel;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}
