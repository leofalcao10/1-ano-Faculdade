using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Calculadora
    {
        public float X { get; protected set; }
        public float Y { get; protected set; }
        public float Resultado { get; protected set; }

        public void InformaValores()
        {
            Console.WriteLine("Informe o 1º Valor: ");
            X = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2º Valor: ");
            Y = float.Parse(Console.ReadLine());
        }
        public void Soma()
        {
            InformaValores();
            Resultado = X + Y;
            Console.WriteLine("Resultado: {0:F2}", Resultado);
        }
        public void Subtracao()
        {
            InformaValores();
            Resultado = X - Y;
            Console.WriteLine("Resultado: {0:F2}", Resultado);
        }
        public void Multiplicacao()
        {
            InformaValores();
            Resultado = X * Y;
            Console.WriteLine("Resultado: {0:F2}", Resultado);
        }
        public void Divisao()
        {
            InformaValores();
            Resultado = X / Y;
            Console.WriteLine("Resultado: {0:F2}", Resultado);
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public void Raiz()
        {
            Console.WriteLine("Informe o índice da raiz:");
            X = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o radicando da raiz:");
            Y = float.Parse(Console.ReadLine());

            Resultado = (float)Math.Pow(Y, 1 / X);
            Console.WriteLine("Resultado: {0}", Resultado);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            bool ligado = true;

            CalculadoraCientifica Calc = new CalculadoraCientifica();

            do
            {
                Console.WriteLine("Escolha uma opção: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão \n 5 - Raíz Quadrada \n 6 - Sair");
                opcao = char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case '1':
                        Calc.Soma();
                        break;

                    case '2':
                        Calc.Subtracao();
                        break;

                    case '3':
                        Calc.Multiplicacao();
                        break;

                    case '4':
                        Calc.Divisao();
                        break;

                    case '5':
                        Calc.Raiz();
                        break;

                    case '6':
                        Console.WriteLine("Encerrando aplicação..");
                        ligado = false;
                        break;

                    default:
                        Console.WriteLine("Por favor, digite somente opções válidas..");
                        break;
                }
            } while (ligado == true);

            Console.ReadKey();
        }
    }
}
