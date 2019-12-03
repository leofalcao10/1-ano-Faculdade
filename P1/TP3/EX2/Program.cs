using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Funcionario
    {
        private string nome;
        private double salario;
        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
            Console.WriteLine("Dados do funcionário:\n Nome: {0}\n Salário: {1}", this.nome, this.salario);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário:");
            double salario = double.Parse(Console.ReadLine());

            Console.Clear();

            Funcionario F = new Funcionario(nome, salario);
            Console.ReadKey();
        }
    }
}
