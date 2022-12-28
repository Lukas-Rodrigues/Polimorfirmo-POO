using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Animal animal = new Cachorro();
            animal.EmitirSom();
           
            Animal animal2 = new Cavalo();
            animal2.EmitirSom();

            Animal animal3 = new preguica();
            animal3.EmitirSom();
            
            Console.ReadKey();

        }
    }
}
