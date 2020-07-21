using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Veterinario
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public List<Cachorro> Dogs { get; set; }
        public List<Departamento> Departamentos { get; set; }

        public Veterinario()
        {

        }

        public Veterinario(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public string Atender()
        {
            return Nome + " " + Tipo;
        }
    }

}
