using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void RetornaValor(int[] vetor, int contador)
        {
            if (contador > vetor.Length - 1)
            {
                return;
            }
            Console.WriteLine(vetor[contador]);
            RetornaValor((vetor), (contador + 1));
        }
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Quantos valores deseja inserir?");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º Valor");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            RetornaValor(vetor, contador);
            Console.ReadKey();
           
        }
    }
}
