using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Validacao
    {
        public Validacao(int d, int m, int a)
        {
            if ((a > 0) && (m > 0 && m < 13) && (d > 0 && d < 32))
            {
                Valida(d, m, a);
            }
            else
            {
                Console.WriteLine("Data Inválida!");
            }
        }

        public void Valida(int d, int m, int a)
        {
            if (a % 4 == 0 && m == 2 && d <= 29)
            {
                Console.WriteLine("Data Válida!");
            }
            else if (m == 2 && d <= 28)
            {
                Console.WriteLine("Data Válida!");
            }
            else if ((m == 4 || m == 6 || m == 9 || m == 11) && (d <= 30))
            {
                Console.WriteLine("Data Válida!");
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                Console.WriteLine("Data Válida!");
            }
            else
            {
                Console.WriteLine("Data Inválida!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int data, mes, ano;
            char op;
            do
            {
                Console.WriteLine("Informe uma data");
                data = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe uma mês");
                mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe um ano");
                ano = int.Parse(Console.ReadLine());

                Validacao teste = new Validacao(data, mes, ano);
                Console.ReadKey();

                Console.WriteLine("Deseja encerrar? 0: Não / 1: Sim");
                op = char.Parse(Console.ReadLine());
                Console.Clear();

            } while (op != '1');

            Console.WriteLine("Encerrando aplicação..");
            Console.ReadKey();
        }
    }
}
