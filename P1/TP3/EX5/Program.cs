using System;

namespace EX5
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private static float peso, altura;
        private double imc;
        public Pessoa(string nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            Pessoa.peso = peso;
            Pessoa.altura = altura;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public void SetPeso(float peso)
        {
            Pessoa.peso = peso;
        }
        public void SetAltura(float altura)
        {
            Pessoa.altura = altura;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public int GetIdade()
        {
            return this.idade;
        }
        public float GetPeso()
        {
            return peso;
        }
        public float GetAltura()
        {
            return altura;
        }
        public void MostraDados()
        {
            Console.WriteLine("Cadastro:\n Nome: {0}\n Idade: {1}\n Peso: {2}KG\n Altura: {3}", GetNome(), GetIdade(), GetPeso(), GetAltura());
        }

        public void MostraIMC()
        {
            imc = GetPeso() / Math.Pow(GetAltura(), 2);
            Console.Write("Categoria IMC: ");

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc <= 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc <= 35)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Grau II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Grau III");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Pessoa p = new Pessoa("Leonardo", 18, 70.7f, 1.73f);

                p.MostraDados();
                p.MostraIMC();

                Console.ReadKey();
            }
        }
    }
}
