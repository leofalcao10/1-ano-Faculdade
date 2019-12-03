using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Exercicio04 {
        static void calcularSa(ref float sa, ref float sAtual)
        {
            Console.WriteLine("Insira o saldo anterior:");
                sa = float.Parse(Console.ReadLine());
                sAtual = sa;
        }
        static void calcularCe(ref int qce, ref float[] ce, ref bool jaUsado, ref int acumulativo, ref float sAtual, ref float sa)
        {
            if (jaUsado == false)
            {
                Console.WriteLine("Digite quantos cheques serão emitidos:");
                qce = int.Parse(Console.ReadLine());
                acumulativo = qce;
                for (int i = 0; i < qce; i++)
                {
                    Console.WriteLine("Digite o valor para o " + (i + 1) + "º Cheque Emitido:");
                    ce[i] = float.Parse(Console.ReadLine());
                    sAtual -= ce[i];
                }
                jaUsado = true;
            }
            else if(jaUsado == true)
            {
                Console.WriteLine("Digite quantos cheques serão emitidos:");
                qce = int.Parse(Console.ReadLine());
                for (int i = 0; i < qce; i++)
                {
                    Console.WriteLine("Digite o valor para o " + (i + 1) + "º Cheque Emitido:");
                    ce[i + acumulativo] = float.Parse(Console.ReadLine());
                    sAtual -= ce[i + acumulativo];
                }
            }
        }
        static void calcularDb(ref float db, ref float sAtual)
        {
            Console.WriteLine("Insira o valor de Débitos (gastos):");
            db = float.Parse (Console.ReadLine());
            sAtual -= db;
        }
        static void calcularCr(ref float cr, ref float sAtual)
        {
            Console.WriteLine("Insira o valor de Creditos (ganhos): ");
            cr = float.Parse(Console.ReadLine());
            sAtual += cr;
        }

        static void Main(string[] args)
        {
            float sAtual = 0; 
            float sa = 0;
            int qce = 100;
            float[] ce = new float[qce];
            float db = 0;
            float cr = 0;
            bool funcionando = true;
            int opcao;
            bool jaUsado = false;
            int acumulativo = 0;
            
            Console.WriteLine("Seja bem vindo ao Banco Unisanta! O que deseja realizar?");

            do
            {
                Console.WriteLine("\n 1. Digitar o Saldo Anterior \n 2. Digitar Cheques Emitidos \n 3. Digitar as contas debitadas \n 4. Digitar os creditos \n 5. Relatorio \n 6. Fechar Conta Corrente");
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao){
                    case 1:
                        Console.Clear();
                        calcularSa(ref sa, ref sAtual);
                        break;

                    case 2: 
                        Console.Clear();
                        calcularCe(ref qce, ref ce, ref jaUsado, ref acumulativo, ref sAtual, ref sa);
                        break;

                    case 3: 
                        Console.Clear();
                        calcularDb(ref db, ref sAtual);
                        break;

                    case 4: 
                        Console.Clear();
                        calcularCr(ref cr, ref sAtual);
                        break;
                    
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Seu saldo atual é de: " + sAtual);
                        break;

                    case 6:
                        funcionando = false;
                        break;
                }
            } while (funcionando == true);

            Console.Clear();
            Console.WriteLine("Muito obrigado pela preferência!");
            Console.ReadKey();
            



        }
    }
}
