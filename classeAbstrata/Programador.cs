using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstrata
{
    public class Programador: Funcionario
    {
        public override void Reajustar()
        {
            Salario += 1000;
        }
    }
}
