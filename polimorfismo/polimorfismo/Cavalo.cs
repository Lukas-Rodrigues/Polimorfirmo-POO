using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class Cavalo:Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Som de cavalo");
        }
    }
}
