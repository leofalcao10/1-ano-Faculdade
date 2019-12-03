using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Lista
    {
        private int info;
        Lista next;

        public Lista()
        {
            info = 0;
            next = null;
        }
        public void Insere(int n, ref Lista START, ref Lista END)
        {                           // Objeto corrente = objeto o qual está utilizando esse método.
            this.info = n;          // O objeto corrente terá seu info alterado para n, valor introduzido pelo usuário.
            if (START == null)      // Essa condição só será verdadeira na criação do 1º objeto, onde START E END ainda valem null.
                START = END = this; // START e END receberão o valor para o endereço de memória do objeto corrente ff(Em nosso exemplo: 1000).
            else
            {
                END.next = this;    // O objeto seguinte(next) áquele que END aponta no momento receberá o endereço de memória para o objeto corrente ff.
                END = this;         // END está apontando para um Objeto(no caso o último objeto). Atribua a esse objeto o endereço de memória(posição) do objeto corrente(ff).
                                    // Adicionar um novo objeto á lista é mexer com o END, ou seja, "andar" uma nova posição para END, pois sempre que criamos um novo objeto, este vai para o "final da fila", portanto altera-se END.
            }
        }

        public void Remove(ref Lista START)
        {
            START = this.next; // START recebe o endereço de memória(posição) do objeto seguinte(next) ao objeto corrente(que é o próprio START). Em outras palavras: Pego a posição atual de START e o avanço para a posição seguinte. Fazendo isso, eu "ignoro"/retiro o 1º Objeto da lista pois pulo para o segundo. Assim de certa forma eu tiro o objeto da lista.      
            Console.WriteLine("Objeto removido!");
        }

        public void Consulta(int n)
        {
            Lista START = this;
            bool achou = false;
            int cont = 0;

            do
            {
                cont++;
                if (START.info == n) //SE o info para o objeto ao qual START está apontando no momento for igual á n..
                {
                    Console.WriteLine("Elemento encontrado na posição {0}", cont);
                    achou = true;
                }

                START = START.next; // Fazendo a "incrementação" de START: START receberá/apontará para a posição/objeto seguinte ao objeto apontado no momento por START: Pulará uma linha.
                                    // Nesse caso eu faço o pulo de posição porém isso não remove os objetos que são ultrapassados por START na lista pois aqui não passo START por referência, logo as alterações não serão salvas.
            } while (START != null && achou == false); // START retornará null assim que ultrapassar o último elemento/objeto da lista(que é apontado sempre por END), pois como não haverá mais elemento a ser referenciado, o retorno é nulo.

            if (achou == false)
            {
                Console.WriteLine("Elemento não encontrado!");
            }
        }

        public void Imprime()
        {
            Lista aux = this; //aux receberá o endereço de memória do objeto corrente(nesse caso será START). Aqui ele está agindo como uma cópia de START, sendo responsável por percorrer a lista toda desde o início ao fim e exibir os infos na tela.

            while (aux != null)// Mesma lógica já apresentada acima
            {
                Console.WriteLine(aux.info); // Exibindo todos os infos que aux recebe enquanto percorre cada um dos objetos.
                aux = aux.next; // aux recebe o endereço de memória do objeto seguinte áquele objeto que é apontado no momento por aux: pulando/incrementando uma posição de aux.
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lista START, END, ff;
            START = END = null;

            int n, op;
           
            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Lista" );
                Console.WriteLine("(2) - Remove um elemento da Lista" );
                Console.WriteLine("(3) - Consulta um elemento da Lista" );
                Console.WriteLine("(4) - Imprime os elementos da Lista" );
                Console.WriteLine("(5) - Para SAIR");
               
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        ff = new Lista();
                        
                        Console.Write("Entre com um numero: ");
                        n = int.Parse(Console.ReadLine());
                        
                        ff.Insere(n, ref START, ref END);
                        break;

                    case 2:
                        if (START == null) //SE START estiver vazio, significa que a lista ainda não foi criada.

                        {
                            Console.WriteLine("Lista vazia!");
                        }

                        else
                        {
                            START.Remove(ref START);
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        if (START == null)
                        {
                            Console.WriteLine("Lista vazia!");
                        }

                        else
                        {
                            Console.Write("Entre com um numero: ");
                            n = int.Parse(Console.ReadLine());

                            START.Consulta(n);
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        if (START == null)
                        {
                            Console.WriteLine("Lista vazia!");
                        }

                        else
                        {
                            START.Imprime();
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Encerrando aplicação..");
                        break;
                }
            } while (op != 5);
            Console.ReadKey();
        }
    }
}