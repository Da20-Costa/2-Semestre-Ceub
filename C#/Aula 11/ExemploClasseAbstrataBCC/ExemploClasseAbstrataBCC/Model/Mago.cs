using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseAbstrataBCC.Model
{
    public class Mago : Personagem
    {
        public override void UsarHabilidade()
        {
            Console.WriteLine($"O guerreiro {Nome} lançou um feitiço");
        }
    }
}
