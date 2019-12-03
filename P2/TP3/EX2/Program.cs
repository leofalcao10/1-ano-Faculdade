using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class CalculaCapital
    {
        public CalculaCapital(float C, float J)
        {
            for (int i = 1; i < 13; i++)
            {
                C += C * (J / 100);

                Console.WriteLine("Capital do {0}º Mês: {1:C}", String.Format("{0:00}" ,i), C);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float Capital, Juros;

            Console.WriteLine("Informe o Capital Inicial:");
            Capital = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a taxa de Juros Mensal em porcentagem:");
            Juros = float.Parse(Console.ReadLine());

            CalculaCapital teste = new CalculaCapital(Capital, Juros);

            Console.ReadKey();
        }
    }
}
