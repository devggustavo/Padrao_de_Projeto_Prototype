using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Prototype1_ShallowCopy.ConcretePrototype;

namespace Prototype1_ShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {

            Soldado Soldado = new Soldado();
            Soldado.Nome = "Soldado1";
            Soldado.Arma = "Fuzil Hk G36";
            Soldado.Acessorio = new Acessorio { Nome = "Visor Noturno" };

            //clone1 do objeto original 
            Soldado Soldado_clone1 = (Soldado) Soldado.Clone();
            Soldado_clone1.Nome = "Soldado clone1";
            Soldado_clone1.Arma = "Fuzil Kalashinikov";
            Soldado_clone1.Acessorio.Nome = "Colete Esecial";

            //clone2 do objeto original 
            Soldado Soldado_clone2 = (Soldado)Soldado.Clone();
            Soldado_clone2.Nome = "Soldado clone2";
            Soldado_clone2.Arma = "Fuzil AK45";
            Soldado_clone2.Acessorio.Nome = "Arma Super Secreta";

            //Exibir valores do objeto orginal 
            WriteLine(">> Obejeto Original");
            WriteLine($"{Soldado.Nome}");
            WriteLine($"{Soldado.Arma}");
            WriteLine($"{Soldado.Acessorio.Nome}\n");

            //Exibir valores do clone1
            WriteLine(">> Obejeto Clone1");
            WriteLine($"{Soldado_clone1.Nome}");
            WriteLine($"{Soldado_clone1.Arma}");
            WriteLine($"{Soldado_clone1.Acessorio.Nome}\n");

            //Exibir valores do clone2
            WriteLine(">> Obejeto Clone2");
            WriteLine($"{Soldado_clone2.Nome}");
            WriteLine($"{Soldado_clone2.Arma}");
            WriteLine($"{Soldado_clone2.Acessorio.Nome}\n");

            ReadLine();
        }


    }
}

            
