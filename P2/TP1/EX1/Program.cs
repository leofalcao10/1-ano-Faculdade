using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Animal
    {
        public string Nome { get; set; }

        public Animal()
        {
            Nome = "nenhum nome cadastrado";
        }

        public void Acordar()
        {
            Console.WriteLine("Acordando..");
        }

        public void Comer()
        {
            Console.WriteLine("Comendo..");
        }

        public void Dormir()
        {
            Console.WriteLine("Dormindo..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal { Nome = "Péricles" };

            Console.WriteLine(a.Nome);

            Console.WriteLine("Digite o nome de seu animal");
                a.Nome = Console.ReadLine();
            
            Console.WriteLine(a.Nome);

            a.Acordar();
            a.Comer();
            a.Dormir();

            Console.ReadKey();
        }
    }
}