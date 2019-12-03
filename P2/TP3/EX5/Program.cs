using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class Program
    {
        class CriaMatriz
        {
            int[,] Matriz;
            int linha, coluna = 1, N, p = 0, q = 0, r;

            public CriaMatriz(int Tamanho)
            {
                Matriz = new int[Tamanho, Tamanho];
                linha = N = Tamanho;
                Preenche();
            }

            public void Preenche()
            {
                if (N == 0)
                {
                    Console.WriteLine("Não há valores.");
                }
                else
                {
                    // Calculando o valor do "meio" da matriz
                    if (N % 2 == 0)
                        r = N / 2;

                    else
                    {
                        r = (N / 2) + 1;
                    }

                    // Preenchendo a matriz
                    for (int i = 1; i <= r; i++)
                    {
                        for (int j = p; j < linha; j++)
                        {
                            for (int k = q; k < linha; k++)
                                Matriz[j, k] = coluna;
                        }
                        linha--; coluna++; p++; q++;
                    }

                    // Exibindo a matriz
                    for (int i = 0;  i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            Console.Write(Matriz[i, j]);
                        }
                        Console.Write("\n");
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            int Tamanho;
            char op;
            CriaMatriz Teste;
            
            do
            {
            Console.WriteLine("Informe o tamanho da matriz quadrática: ");
            Tamanho = int.Parse(Console.ReadLine());
            Console.Clear();

            Teste = new CriaMatriz(Tamanho);
            Console.ReadKey();
            Console.WriteLine("Deseja encerrar a aplicação? 0: Não / 1: Sim");
            op = char.Parse(Console.ReadLine());
            Console.Clear();

            }while(op != '1');

            Console.WriteLine("Encerrando a aplicação...");
            Console.ReadKey();
        }
    }
}
