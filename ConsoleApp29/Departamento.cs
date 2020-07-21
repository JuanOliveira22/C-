using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class Departamento
    {
        public string Departament { get; set; }
        public List<Veterinario> Local { get; set; }

        public Departamento(string departament)
        {
            Departament = departament;
        }
        public string AdicionarDepartamento(string nome, string tipo)
        {
            List<Veterinario> Local = new List<Veterinario>();
            Local.Add(new Veterinario(nome, tipo));
            return Departament;
        }
    }

}
