using System;

namespace EX
{
    class Lista
    {
        public Lista()
        {
            info = 0;
            next = prev = null;
        }
        public void Insere(int n, ref Lista START, ref Lista END)
        {
            this.info = n;
            if (START == null)
                START = END = this;
            else
            {
                END.next = this;
                this.prev = END;
                END = this;
            }
        }
        public void Remove(ref Lista START, ref Lista END)
        {
            Console.WriteLine("O primeiro Elemento da lista {0} será removido...", START.info);
            if (START.next == null)
            {
                START = END = null;
                Console.WriteLine("A Lista está vazia");
            }
            else
            {
                START = this.next;
                (this.next).prev = null;
                Console.WriteLine("O primeiro Elemento da lista agora é {0}.", START.info);
            }
            Console.ReadKey();
        }
        public void Consulta(int n, Lista START)
        {
            int controle = 0;
            int pos = 1;
            do
            {
                if (START.info == n)
                {
                    Console.WriteLine("O elemento {0} foi encontrado na posição {1} da lista", n, pos);
                    controle++;
                }
                else
                {
                    START = this.next;
                    pos++;
                }
            } while (controle == 0);
            Console.ReadKey();
        }
        public void Imprimir()
        {
            Lista aux = this;
            int cont = 1;
            while (aux != null)
            {
                Console.WriteLine("O Elemento {0} da lista é: {1}", cont, aux.info);
                aux = aux.next;
                cont++;
            }
            Console.ReadKey();
        }
        public void ImprimirInverso()
        {
            Lista aux = this;
            int cont = 1;
            while (aux != null)
            {
                Console.WriteLine("O Elemento {0} da lista é: {1}", cont, aux.info);
                aux = aux.prev;
                cont++;
            }
            Console.ReadKey();
        }
        private int info;
        Lista next, prev;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lista START, END, ff;
            START = END = null;
            int n, escolha, resultado;
            do
            {
                Console.Clear();
                Console.WriteLine("--Menu Principal--");
                Console.WriteLine("(1) - Insere um elemento na Lista");
                Console.WriteLine("(2) - Remove um elemento da Lista");
                Console.WriteLine("(3) - Consulta um elemento da Lista");
                Console.WriteLine("(4) - Imprime os elementos da Lista");
                Console.WriteLine("(5) - Imprime os elementos da Lista ao contrario");
                Console.WriteLine("(6) - Para SAIR");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 1: // Insere um elemento na Lista
                        ff = new Lista();
                        Console.Write("Entre com um numero : ");
                        n = int.Parse(Console.ReadLine());
                        ff.Insere(n, ref START, ref END);
                        break;
                    case 2: // Remove o primeiro elemento na lista
                        START.Remove(ref START, ref END);
                        break;
                    case 3: //Consulta um elemento na lista
                        Console.Write("Insira numero a consultar: ");
                        resultado = int.Parse(Console.ReadLine());
                        START.Consulta(resultado, START);
                        break;
                    case 4: //Imprime todos os elementos da lista
                        START.Imprimir();
                        break;
                    case 5: //Imprime todos os elementos da lista ao contrario
                        END.ImprimirInverso();
                        break;
                }
            } while (escolha != 6);
        }
    }
}
