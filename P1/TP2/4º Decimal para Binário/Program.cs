using System;

namespace EX05
{
    class Program
    {
        static string InverterString(string str)
        {
            //tamanho receberá em valor numérico, a quantidade de caracteres binários contida em "str". EX: se o número binário for "110", tamanho receberá o valor 3.
            int tamanho = str.Length;

            //Criando vetor de char para a mesma quantidade de caracteres contída em "str". EX: se o número binário for "110", criará 3 vetores de char, sendo da posição 0 até 2.
            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                //Aqui está sendo efetivada a troca/inversão de posições. Sendo os primeiros agora os últimos e vice-versa.
                caracteres[i] = str[tamanho - 1 - i];
            }

            // Retorno do novo número binário invertido. O "new string" fez a junção de todas as posições de vetores de caracteres em uma nova string unificada somente.
            return new string(caracteres);
        }
        static string DecimalParaBinario(string numero)
        {
            // Fiz uma atribuição inicial á valor para que não dê erro. Valor conterá o valor em binário em forma de String.
            string valor = "";

            // Passando para int o número que eu informei para que seja possível realizar contas.
            int dividendo = int.Parse(numero);

            // Se de início eu passar como argumento o valor 0 ou 1, esses serão retornados diretamente por ja serem binários.
            if (dividendo == 0 || dividendo == 1)
            {

                return Convert.ToString(dividendo);

            }

            else
            {
                // Para converter um número decimal para binário, deve-se dividir o número decimal por 2 e obter o resto, que deve dar 1 ou 0. O resultado da divisão deve ser dividido por 2 novamente e assim sucessivamente, até que o quociente seja 0. Ao final pegamos todos os restos, mas invertidos!
                while (dividendo > 0)
                {
                    // Convertendo para string e atribuindo á valor o resto da divisão por 2, que será 0 ou 1.
                    valor += Convert.ToString(dividendo % 2);

                    //Dividindo o resultado da divisão por 2 até não ser mais possível(dividendo = 0)
                    dividendo /= 2;

                }
                // No final de tudo, passo os valores 0 e 1 atribuídos a "valor", como argumento para a função que faz a inversão dos números. Vá na função de inversão e entenda o código.
                return InverterString(valor);

            }

        }
        public static int BinarioParaDecimal(string valorBinario)
        {

            int expoente = 0;

            int numero;

            int soma = 0;

            string numeroInvertido = InverterString(valorBinario);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));

                soma += numero * (int)Math.Pow(2, expoente);

                expoente++;

            }

            return soma;

        }
        static void Main(string[] args)
        {
            bool funcionando = true;

            do {
                
                Console.WriteLine("Qual função deseja executar?\n 0: Binário para Decimal\n 1: Decimal para Binário");
                byte opcao = byte.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Digite o valor Binário a ser convertido para Decimal:");
                        string valorBinario = Console.ReadLine();
                        Console.WriteLine("Resultado: {0}", BinarioParaDecimal(valorBinario));
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o valor a ser convertido para Binário:");
                        string numero = Console.ReadLine();
                        Console.WriteLine("Resultado: {0}", DecimalParaBinario(numero));
                        break;
                }
            } while (funcionando == true);
            Console.ReadKey();
        }
    }
       
}

