using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Animal
    {
        public string Nome { get; set; }

        public void Acordar()
        {
            Console.WriteLine("{0} Acordando..", Nome);
        }

        public void Comer()
        {
            Console.WriteLine("{0} Comendo..", Nome);
        }

        public void Dormir()
        {
            Console.WriteLine("{0} Dormindo..", Nome);
        }
    }

    public class Mamifero : Animal
    {
        public void Mamar()
        {
            Console.WriteLine("{0} Mamando..", Nome);
        }
    }

    public class Morcego : Mamifero
    {
        public void Voar()
        {
            Console.WriteLine("{0} Voando..", Nome);
        }
    }
    public class Baleia : Mamifero
    {
        public void Nadar()
        {
            Console.WriteLine("{0} Nadando..", Nome);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Morcego A = new Morcego
            {
                Nome = "Claudio"
            };

            A.Acordar();
            A.Comer();
            A.Dormir();
            A.Mamar();
            A.Voar();

            Baleia B = new Baleia
            {
                Nome = "Cleiton"
            };

            B.Nadar();

            Console.ReadKey();
        }
    }
}
