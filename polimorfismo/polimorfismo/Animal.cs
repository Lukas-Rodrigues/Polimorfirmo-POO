using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public string idade { get; set; }


        public virtual void EmitirSom()
        {


        } 

    }
}
