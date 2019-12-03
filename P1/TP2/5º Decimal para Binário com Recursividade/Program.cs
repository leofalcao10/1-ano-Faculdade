using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor a ser convertido para Binário: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Resultado: "); DecimalParaBinario(n);
            Console.ReadKey();
        }
        //A diferença de utilizar Recursividade para transformar em binário consiste no fato que eu posso poupar a criação do método que faz a inversão de posição dos valores como foi feito no EX04. Da maneira como é feito abaixo não se torna necessário esse método pois quando o método "DecimalParaBinario" se chama pela última vez, os returns, que estão implícitos no código, retornarão de forma descrescente cada chamamento do método, portanto indiretamente o número binário já será exibido na tela de forma inversa. Teste com o Debug para acompanhar.
        static void DecimalParaBinario(int n)
        {
            if (n > 0)
            {
                DecimalParaBinario(n / 2);
                Console.Write(n % 2);
            }
        }
    }
}
