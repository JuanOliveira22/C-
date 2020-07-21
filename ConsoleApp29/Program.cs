using System;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Informe o seu nome : ");
             string nome = Console.ReadLine();
            Console.Write("Informe o seu tipo : ");
            string tipo = Console.ReadLine();
            Veterinario veterinario = new Veterinario(nome, tipo);

            Console.Write("Informe o nome do seu Cachorro : ");
            string nomeDog = Console.ReadLine();
            Console.Write("Informe a raca do cachorro : ");
            string Raca = Console.ReadLine();
            Cachorro cachorro = new Cachorro(nomeDog, Raca);
            List<Veterinario> veterinarios = new List<Veterinario>();
            cachorro.Medicar(nome, tipo);
        
            Console.WriteLine("O cachorro " + cachorro.Nome + " foi atendido pelo veterinario" + cachorro.Vaterinarios[0].Nome);










        }
    }
}
