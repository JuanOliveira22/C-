using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp29
{
    class Cachorro
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public List<Veterinario> Vaterinarios { get; set; }
        public  Cachorro()
        {
        }

        public Cachorro(string nome, string raca)
        {
            Nome = nome;
            Raca = raca;
        }

        public Cachorro(string nome, string raca, List<Veterinario> vaterinarios)
        {
            Nome = nome;
            Raca = raca;
            Vaterinarios = vaterinarios;
        }

        public void Medicar(string nome, string tipo)
        {
            Vaterinarios = new List<Veterinario>();
            Vaterinarios.Add(new Veterinario(nome, tipo));

           

        }
       

    }
}
