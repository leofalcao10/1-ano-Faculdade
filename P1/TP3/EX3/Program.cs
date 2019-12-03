using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    public class invoice
    {
        private int nItem, qItem;
        private string dItem;
        private double pItem;

        public invoice(int nItem, string dItem, int qItem, double pItem)
        {
            this.nItem = nItem;
            this.dItem = dItem;
            this.qItem = qItem;
            this.pItem = pItem;
        }
        public double getInvoiceAmount()
        {
            return (qItem * pItem);
        }
        public void toString()
        {
            Console.WriteLine("Dados da fatura:\n NºItem: {0}\n {1}\n Quantidade: {2}\n Preço Final: {3}", nItem, dItem, qItem, getInvoiceAmount());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número do item:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Breve descrição sobre o item:");
            string d = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quantidade de unidades do item:");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Preço por unidade do item:");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();

            invoice comprador = new invoice(n, d, q, p);

            comprador.toString();

            Console.ReadKey();
        }
    }
}
