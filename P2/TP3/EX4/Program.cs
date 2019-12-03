using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Diagonal_Principal_Abaixo
    {
        float[,] Matriz = new float[12, 12];
        float Soma, Media;
        Random random = new Random();

        public void Gera_Exibe(char op)
        {
            //Gerando valores aleatórios
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Matriz[i, j] = random.Next(-1000, 1000);
                }
            }

            //Fazendo a soma ou a média dos valores
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Soma += Matriz[i, j];
                }
            }

            Media = Soma / 66;

            //Exibindo resultado de acordo com a opção do usuário
            Console.WriteLine("Resultado: {0:F2}", op == 's' ? Soma : Media);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char O;

            Diagonal_Principal_Abaixo teste = new Diagonal_Principal_Abaixo();

            do
            {
                Console.WriteLine("Escolha uma operação envolvendo valores abaixo da diagonal principal\ns = Soma\nm = Média\n0 = Encerrar");
                O = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (O)
                {
                    case 's':
                    case 'm':
                        teste.Gera_Exibe(O);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case '0':
                        Console.WriteLine("Confirme o '0' para encerrar");
                        O = char.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Digite somente opções válidas..");
                        break;
                }
            } while (O != '0');

            Console.WriteLine("Encerrando aplicação..");
            Console.ReadKey();
        }
    }
}
