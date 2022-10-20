using System;
using System.Globalization;

namespace VetorExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // adiciona ponto na leitura de dados

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altrua = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));  // adiciona ponto da escrita de dados
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altrua.ToString("F2",CultureInfo.InvariantCulture));

           */



            
            Console.ReadLine();
            Console.WriteLine("Exercício da aula");
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu último nome, idade e altura");

            string[] vet2 = Console.ReadLine().Split(' ');
            string fulano = vet2[0];
            int idade2 = int.Parse(vet2[1]);
            double altura2 = double.Parse(vet2[2]);

            Console.ReadLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome2);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(preco);
            Console.WriteLine(fulano);
            Console.WriteLine(idade2);
            Console.WriteLine(altura2);


            
        }
    }
}
