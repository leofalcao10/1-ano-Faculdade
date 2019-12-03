using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class ValidaCPF
    {
        string CPF;
        int somatorio, resto;
        int contador = 0;
        int[] digito_verificado = new int[2];
        int[] digito_calculado = new int[2];

        public ValidaCPF()
        {
            Console.Write("Digite um CPF a ser verificado: ");
            this.CPF = Console.ReadLine();
            Validacao();
        }

        public void Validacao()
        {
            if (CPF.Length != 11)
            {
                Console.WriteLine("CPF Inválido");
                return;
            }

            switch (CPF)
            {
                case "00000000000":
                case "11111111111":
                case "22222222222":
                case "33333333333":
                case "44444444444":
                case "55555555555":
                case "66666666666":
                case "77777777777":
                case "88888888888":
                case "99999999999":

                    Console.WriteLine("cpf Inválido");
                    return;
            }

            /* Pegando o 1º e 2º Dígito validador de CPF (penúltimo e último número): Pegar o dígito de qualquer número é pegar o resto/módulo da      divisão desse número por 10 */

            digito_verificado[0] = (int)((long.Parse(CPF) / 10) % 10);
            digito_verificado[1] = (int)(long.Parse(CPF) % 10);

            do
            {
                somatorio = 0;

                Console.Clear();

                for (int i = 0; i < (9 + contador); i++)
                {
                    somatorio += int.Parse(CPF[i].ToString()) * ((10 + contador) - i);
                }

                resto = somatorio % 11;

                if (resto < 2)
                {
                    digito_calculado[contador] = 0;
                }
                else
                {
                    digito_calculado[contador] = 11 - resto;
                }

                contador++;

            } while (contador <= 1);

            if(digito_verificado[0] == digito_calculado[0] && digito_verificado[1] == digito_calculado[1])
            {
                Console.WriteLine("CPF Válido");
            }
            else
            {
                Console.WriteLine("CPF Inválido");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ValidaCPF pessoa = new ValidaCPF();
            Console.ReadKey();
        }
    }
}
