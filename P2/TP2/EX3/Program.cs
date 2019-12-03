using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    public class Figura
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Area { get; set; }
    }

    public class Quadrado : Figura
    {
        public void CalcArea()
        {
            Console.WriteLine("Informe o lado do quadrado:");
            X = float.Parse(Console.ReadLine());
            Console.Clear();

            Area = X * X;
            Console.WriteLine("Resultado: {0}", Area);
        }
    }

    public class Retangulo : Figura
    {
        public void CalcArea()
        {
            Console.WriteLine("Informe a base do retângulo:");
            X = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do retângulo:");
            Y = float.Parse(Console.ReadLine());

            Console.Clear();

            Area = X * Y;
            Console.WriteLine("Resultado: {0}", Area);
        }
    }

    public class Triangulo : Figura
    {
        public void CalcArea()
        {
            Console.WriteLine("Informe a base do triângulo:");
            X = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo:");
            Y = float.Parse(Console.ReadLine());

            Console.Clear();

            Area = (X * Y) / 2;
            Console.WriteLine("Resultado: {0}", Area);
        }
    }

    public class Circulo : Figura
    {
        public void CalcArea()
        {
            Console.WriteLine("Informe o raio do círculo:");
            X = float.Parse(Console.ReadLine());

            Console.Clear();

            Area = (float) Math.PI * (float) Math.Pow(X, 2);
            Console.WriteLine("Resultado: {0:F2}", Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            bool ligado = true;

            Quadrado A = new Quadrado();

            Retangulo B = new Retangulo();

            Triangulo C = new Triangulo();

            Circulo D = new Circulo();

            do
            {
                Console.WriteLine("Escolha uma opção: \n 1 - Quadrado \n 2 - Retângulo \n 3 - Triângulo \n 4 - Círculo \n 5 - Sair");
                opcao = char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case '1':
                        A.CalcArea();
                        break;

                    case '2':
                        B.CalcArea();
                        break;

                    case '3':
                        C.CalcArea();
                        break;

                    case '4':
                        D.CalcArea();
                        break;

                    case '5':
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
