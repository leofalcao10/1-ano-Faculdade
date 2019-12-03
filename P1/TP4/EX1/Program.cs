using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class CalcFrete
    {
        float Custo_fixo, Custo_variavel, Carga, Custo_final;

        public CalcFrete()
        {
            Console.WriteLine("Informe o valor para o Custo fixo:");
                this.Custo_fixo = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o valor para o Custo Variável:");
                this.Custo_variavel = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Informe o valor para a Carga Total:");
                this.Carga = float.Parse(Console.ReadLine());

            this.Custo_final = Custo_fixo + (Custo_variavel * Carga);
        }

        public float getFrete()
        {
            return Custo_final;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CalcFrete transporte_A = new CalcFrete();

            Console.Clear();

            CalcFrete transporte_B = new CalcFrete();

            Console.Clear();

            Console.WriteLine("Transportadora A: {0}\n Transportadora B: {1}", transporte_A.getFrete(), transporte_B.getFrete());

            float Diferenca = transporte_A.getFrete() - transporte_B.getFrete();

            if (Diferenca <= 1000 || transporte_A.getFrete() < transporte_B.getFrete())
            {
                Console.WriteLine("Preferência pela transportadora A");
            }
            else
            {
                Console.WriteLine("Preferência pela transportadora B");
            }

            Console.ReadKey();
        }
    }
}
