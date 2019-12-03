using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Conversor
    {
        string[] unidade = new string[] { " Reais", " e ", " mil"};
        string[] numeral = new string[] {"zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove"};
        string[] dezena = new string[] {"dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        string[] centena = new string[] { "cem", "cento", "duzentos", "tresentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos"};
        string[] diferentes = new string[] {"onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        int[] recorte;
        string concatenacao;
        public Conversor(string validado)
        {
            recorte = new int[validado.Length];

            for (int i = 0; i < recorte.Length; i++)
            {
                recorte[i] = int.Parse(validado.Substring(i, 1)); // ou numero[i].ToString();
            }

            Tranformar();
        }

        public void Tranformar()
        {
            if (recorte.Length == 4)
            {
                if (recorte[1] == 0 && recorte[2] == 0 && recorte[3] == 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if(recorte[1] == 1 && recorte[2] == 0 && recorte[3] == 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + centena[0] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if(recorte[1] != 0 && recorte[2] == 0 && recorte[3] == 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + centena[recorte[1]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] != 0 && recorte[2] != 0 && recorte[3] == 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + centena[recorte[1]] + unidade[1] + dezena[recorte[2] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] != 0 &&  recorte[2] == 1 && recorte[3] != 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + centena[recorte[1]] + unidade[1] + diferentes[recorte[3] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] != 0 && recorte[2] == 0 && recorte[3] != 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + centena[recorte[1]] + unidade[1] + numeral[recorte[3]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] != 0 && recorte[2] != 0 && recorte[3] != 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + centena[recorte[1]] + unidade[1] + dezena[recorte[2] - 1] + unidade[1] + numeral[recorte[3]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 0 && recorte[2] == 0 && recorte[3] != 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + numeral[recorte[3]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 0 && recorte[2] == 1 && recorte[3] != 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + diferentes[recorte[3] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 0 && recorte[2] != 0 && recorte[3] == 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + dezena[recorte[2] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 0 && recorte[2] != 0 && recorte[3] != 0)
                {
                    concatenacao += numeral[recorte[0]] + unidade[2] + unidade[1] + dezena[recorte[2] - 1] + unidade[1] + numeral[recorte[3]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }
            }

            else if (recorte.Length == 3)
            {
                if (recorte[0] == 1 && recorte[1] == 0 && recorte[2] == 0)
                {
                    concatenacao += centena[0] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 0 && recorte[2] == 0)
                {
                    concatenacao += centena[recorte[0]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] != 0 && recorte[2] == 0)
                {
                    concatenacao += centena[recorte[0]] + unidade[1] + dezena[recorte[1] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 1 && recorte[2] != 0)
                {
                    concatenacao += centena[recorte[0]] + unidade[1] + diferentes[recorte[2] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] == 0 && recorte[2] != 0)
                {
                    concatenacao += centena[recorte[0]] + unidade[1] + numeral[recorte[2]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[1] != 0 && recorte[2] != 0)
                {
                    concatenacao += centena[recorte[0]] + unidade[1] + dezena[recorte[1] - 1] + unidade[1] + numeral[recorte[2]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }
            }

            else if (recorte.Length == 2)
            {
                if (recorte[0] == 1 && recorte[1] != 0)
                {
                    concatenacao = diferentes[recorte[1] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[0] == 1 && recorte[1] == 0)
                {
                    concatenacao = dezena[recorte[0] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else if (recorte[0] != 0 && recorte[1] != 0)
                {
                    concatenacao = dezena[recorte[0] - 1] + unidade[2] + numeral[recorte[1]] + unidade[0];
                    Console.WriteLine(concatenacao);
                }

                else
                {
                    concatenacao = dezena[recorte[0] - 1] + unidade[0];
                    Console.WriteLine(concatenacao);
                }
            }

            else
            {
                concatenacao += numeral[recorte[0]] + unidade[0];
                Console.WriteLine(concatenacao);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string validado;
            char op;

            do {
                do {
                    Console.WriteLine("Informe o valor monetário a ser convertido (abaixo de R$ 10.000):");
                    numero = int.Parse(Console.ReadLine());
                    Console.Clear();

                    validado = numero.ToString().TrimStart('0').Trim(); // Retirando todas as ocorrências de zero á esquerda ou espaços vazios.

                    if (validado.Length > 4 || validado == "")
                    {
                        Console.WriteLine("Digite somente valores até o limite informado..");
                    }

                } while (validado.Length > 4 || validado == "");

                Conversor teste = new Conversor(validado);

                Console.WriteLine("Deseja informar um novo valor? 0:Não 1:Sim");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (op == '1');

            Console.WriteLine("Encerrando aplicação..");
            Console.ReadKey();
        }
    }
}
