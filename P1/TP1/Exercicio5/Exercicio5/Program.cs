using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Cria20(ref bool criado, ref int[] n)
        {
            if (criado == false)
            {
                Console.WriteLine("Digite os 20 valores a serem armazenados:");
                for (int i = 0; i < 20; i++)
                {
                    n[i] = int.Parse(Console.ReadLine());
                    while (n[i] < 0)
                    {
                        Console.WriteLine("Por favor, utilize somente valores possitivos! Tente novamente um outro valor:");
                        n[i] = int.Parse(Console.ReadLine());
                    }
                }
                Console.Clear();
                criado = true;
            }
            else
            {
                Console.WriteLine("Seu arquivo com 20 valores já foi criado!");
            }
        }
        static void Media137(ref bool criado, ref int[] n, ref int somatorio, ref int divisor, ref float media)
        {
            if (criado == true)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (n[i] > 137)
                    {
                        somatorio += n[i];
                        divisor++;
                        media = somatorio / divisor;
                    }
                }
                Console.WriteLine("A média aritmética dos valores maiores que 137 é: {0} ", media);
            }
            else
            {
                Console.WriteLine("Você ainda não criou seus números! Crie-os primeiro e depois tente novamente.");
            }
        }
        static void MostraMaiorPar(ref bool criado, ref int[] n, ref int maiorPar)
        {
            if (criado == true)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (n[i] % 2 == 0 && n[i] > maiorPar)
                    {
                        maiorPar = n[i];
                    }
                }
                Console.WriteLine("O maior valor Par dentro do arquivo é: {0}", maiorPar);
            }
            else
            {
                Console.WriteLine("Você ainda não criou seus números! Crie-os primeiro e depois tente novamente.");
            }
        }
        static void Maior21(ref int[] n)
        {
            Console.WriteLine("Aqui estão os números superiores a 21:");
            for (int i = 0; i < 19; i++)
            {
                if (n[i] > 21)
                {
                    Console.WriteLine(n[i]); 
                }
            }
        }
        static void Main(string[] args)
        {
            int[] n = new int[20];
            int maiorPar = 0;
            char opcao;
            bool funcionando = true, criado = false;
            int somatorio = 0, divisor = 0;
            float media = 0;
            do
            {
                Console.WriteLine("Seleciona a opção desejada:" +
                "\n a.Criação de um arquivo com 20 números positivos;" +
                "\n b.Cálculo da média aritmética dos que são maiores que 137;" +
                "\n c.Determinação do maior dos números que são pares;" +
                "\n d.Exclusão dos números menores que 21;" +
                "\n e.Fechar aplicação");
                opcao = char.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 'a':
                        Console.Clear();
                        Cria20(ref criado, ref n);
                        break;

                   case 'b':
                        Console.Clear();
                        Media137(ref criado, ref n, ref somatorio, ref divisor, ref media);
                        break;
                        
                    case 'c':
                        Console.Clear();
                        MostraMaiorPar(ref criado, ref n, ref maiorPar);
                        break;

                    case 'd':
                        Console.Clear();
                        Maior21(ref n);
                        break;

                    case 'e':
                        funcionando = false;
                        break;

                    default:
                        Console.WriteLine("Por favor, digite somente opções válidas.");
                        break;
                }

            } while (funcionando == true);
            Console.Clear();
            Console.WriteLine("Encerraremos o programa por aqui.");
            Console.ReadKey();
        }
    }
}
