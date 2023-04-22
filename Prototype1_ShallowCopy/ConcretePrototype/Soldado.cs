using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1_ShallowCopy.ConcretePrototype
{
    public class Soldado : ICloneable
    {

        public string Nome { get; set; }

        public string Arma { get; set; }

        public Acessorio Acessorio { get; set; }

        public Soldado() { }

        public Soldado(Soldado s)
        {

            this.Nome = s.Nome;
            this.Arma = s.Arma;
            this.Acessorio = s.Acessorio;
        }

        public object Clone()
        {
            //return new Soldado(this); (versão 1)

            //última versão
            Soldado soldado = (Soldado)this.MemberwiseClone();
            soldado.Acessorio = (Acessorio)this.Acessorio.Clone();
            return soldado;
        }

    }
}
