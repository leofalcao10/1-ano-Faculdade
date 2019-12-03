using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    class Program
    {
        static int MaiorVetor(int[] vetor, int contador)
        {
            if (contador == 1)
            {
                return vetor[0];
            }

            int m = MaiorVetor(vetor, contador - 1);

            if (m > vetor[contador - 1])
            {
                return m;
            }
            else
            {
                return vetor[contador - 1];
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valores deseja informar?");
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o " + (i+1) + "º Valor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O maior número é: " + MaiorVetor(vetor, vetor.Length));
            Console.ReadKey();
        }
    }
}
