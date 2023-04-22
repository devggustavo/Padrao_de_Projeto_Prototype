using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1_ShallowCopy.ConcretePrototype
{
    public class Acessorio
    {

        public string Nome { get; set; }

        public object   Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }  
}
