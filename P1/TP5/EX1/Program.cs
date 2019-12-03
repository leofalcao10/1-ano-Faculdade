using System;

namespace EX1
{
    class Calculadora
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Resultado { get; private set; }

        public void SetValores()
        {
            Console.Write("Entre com o 1º Valor: ");
                X = float.Parse(Console.ReadLine());

            Console.Write("Entre com o 2º Valor: ");
                Y = float.Parse(Console.ReadLine());

            Console.Clear();
        }
        public void Soma()
        {
            SetValores();
            Resultado = X + Y;
            Console.WriteLine($"Resultado: {Resultado}");
        }
        public void Subtracao()
        {
            SetValores();
            Resultado = X - Y;
            Console.WriteLine("Resultado: {0}",Resultado);
        }
        public void Multiplicacao()
        {
            SetValores();
            Resultado = X * Y;
            Console.WriteLine("Resultado: " + Resultado);
        }
        public void Divisao()
        {
            SetValores();
            Resultado = X / Y;
            Console.WriteLine($"Resultado: {Resultado}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            bool funcionando = true;

            Calculadora objeto = new Calculadora();

            Console.WriteLine("Bem vindo á Calculadora!");
            do
            {
                Console.WriteLine("Qual função deseja executar:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");
                opcao = Char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case '1':
                        objeto.Soma();
                        break;

                    case '2':
                        objeto.Subtracao();
                        break;

                    case '3':
                        objeto.Multiplicacao();
                        break;

                    case '4':
                        objeto.Divisao();
                        break;

                    case '5':
                        Console.WriteLine("Encerrando a aplicação...");
                        funcionando = false;
                        break;

                    default:
                        Console.WriteLine("Por favor, digite somente opções válidas!");
                        break;
                }
            }while (funcionando == true);

            Console.ReadKey();
        }
    }
}
