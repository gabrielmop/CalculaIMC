using System;

namespace CalculaIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Bem Vindo ao Software de Calculo de IMC");
            Console.WriteLine("Escreva Seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual Seu Sexo?");
            string sexo = Console.ReadLine();
            int idade = 26;
            float altura = 1.79f;
            float peso = 76.4f;
            string categoria = "";
            //float/double.Parse(Console.ReadLine()); - Comando pra ler do console em float/double

            if (idade < 12)
            {

                categoria = "infantil";

            }
            if (idade >= 12 && idade <= 20)
            {

                categoria = "juvenil";

            }
            if (idade >= 21 && idade <= 65) {

                categoria = "Adulto";
            }
            if (idade > 65) {

                categoria = "idoso";
            }else
            {

                Console.WriteLine("Os dados inseridos não são de idade, tente novamente");

            }


            float imc = peso / (altura * altura);

            

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Categoria: {categoria}");
            Console.WriteLine($"{nome}, Seu imc é: {imc}");

    









        }
    }
}
