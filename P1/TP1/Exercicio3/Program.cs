using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Cria20(ref float[] n)
        {
            Console.WriteLine("Digite os 20 números inteiros e positivos desejados.");
            for (int i = 0; i < 20; i++)
            {
                n[i] = float.Parse(Console.ReadLine());
                while (n[i] % 1 != 0 || n[i] < 0)
                {
                    Console.WriteLine("Tente novamente um valor inteiro e positivo:");
                    n[i] = float.Parse(Console.ReadLine());
                }
            }
        }
        static void SomaPar(ref float[] n, ref int somatorio)
        {
            for (int i = 0; i < 20; i++)
            {
                if (n[i] % 2 == 0)
                {
                    somatorio += (int)n[i];
                }
            }
            Console.WriteLine("O somatório dos valores pares é: {0}", somatorio);
        }
        static void MaiorNumero(ref float[] n, ref int maiorValor)
        {
            for (int i = 0; i < 20; i++)
            {
                if (n[i] > maiorValor)
                {
                    maiorValor = (int)n[i];
                }
            }
            Console.WriteLine("O maior valor contido no arquivo é: {0}", maiorValor);
        }
        static void Main(string[] args)
        {
            float[] n = new float[20];
            bool funcionando = true;
            char comando;
            int somatorio = 0;
            int maiorValor = 0;

            do
            {
                Console.WriteLine("Selecione uma das opções possíveis:" +
                "\n a.Criação de um arquivo de 20 números inteiros e positivos;" +
                "\n b.Cálculo da soma de todos os números que são pares;" +
                "\n c.Determine o maior número do arquivo;" +
                "\n d.Encerramento");
                comando = char.Parse(Console.ReadLine());

                switch (comando)
                {
                    case 'a':
                        Console.Clear();
                        Cria20(ref n);
                        break;

                    case 'b':
                        Console.Clear();
                        SomaPar(ref n, ref somatorio);

                        break;

                    case 'c':
                        Console.Clear();
                        MaiorNumero(ref n, ref maiorValor);
                        break;

                    case 'd':
                        funcionando = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor, digite apenas comando válidos.");
                        break;
                }

            } while (funcionando == true);
            Console.Clear();
            Console.WriteLine("Encerraremos o programa por aqui.");
            Console.ReadKey();  
        }
    }
}
