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

            Console.WriteLine("Qual Sua Idade");
            int idade = 0;
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                int.TryParse(Console.ReadLine(), out idade);
            } 

            Console.WriteLine("Digite Sua altura");
            float altura = 0;
            while (!float.TryParse(Console.ReadLine(), out altura))
            {
                float.TryParse(Console.ReadLine(), out altura);
            }
            Console.WriteLine("Digite Seu Peso");
            float peso = 0;
            while (!float.TryParse(Console.ReadLine(), out peso))
            {
                float.TryParse(Console.ReadLine(), out peso);
            }
            string categoria = "";
         

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
            }


            float imc = peso / (altura * altura);


            Console.Clear();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine($"Categoria: {categoria} \r\n");
            Console.WriteLine($"{nome}, Seu imc é: {imc}");

    









        }
    }
}
