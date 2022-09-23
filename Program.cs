using System;

namespace CalculaIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gabriel";
            string sexo = "Masculino";
            int idade = 26;
            float altura = 1.79f;
            float peso = 76.4f;
            string categoria = ""; 


            if(idade < 12)
            {

                categoria = "infantil";

            }
            if(idade >= 12 && idade <= 20)
            {

                categoria = "juvenil";

            }
            if (idade >= 21 && idade <= 65){

                categoria = "Adulto";
            }
            if (idade > 65) {

                categoria = "idoso";
            }


                double imc = peso / (altura * altura);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(peso);
            Console.WriteLine(categoria);









        }
    }
}
