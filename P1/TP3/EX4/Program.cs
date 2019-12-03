using System;

namespace EX4
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private float peso, altura;
        public Pessoa(string nome,int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public void setAltura(float altura)
        {
            this.altura = altura;
        }
        public string getNome()
        {
            return this.nome;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public float getPeso()
        {
            return this.peso;
        }
        public float getAltura()
        {
            return this.altura;
        }
        public void toString()
        {
            Console.WriteLine("Cadastro:\n Nome: {0}\n Idade: {1}\n Peso: {2}KG\n Altura: {3}", getNome(), getIdade(), getPeso(), getAltura());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Leonardo", 18, 70.7F, 1.73F);

            p.setIdade(19);
            p.setAltura(1.76F);


            p.toString();

            Console.ReadKey();
        }
    }
}
