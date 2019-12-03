using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    class Program
    {
        static int Somatorio(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            return num + Somatorio(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O somatório é: {0}", Somatorio(num));
        }
    }
}
