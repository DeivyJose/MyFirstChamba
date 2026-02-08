using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstChamba
{
    public class Person
    {
        public string Name { get; set; }
        public string IdntityCard { get; set; }
        public int Age { get; set; }

        public List<Rol> Roles { get; set; }

        public Person()
        {
            Roles = new List<Rol>();
        }

        public void AddRol(Rol rol)
        {
            if (!Roles.Contains(rol))
            {
                Roles.Add(rol);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Nombre: " + Name);
            Console.WriteLine("Cedula: " + IdntityCard);
            Console.WriteLine("Edad: " + Age);
            Console.WriteLine("Roles:");

            foreach (var rol in Roles)
            {
                Console.WriteLine("- " + rol);
            }
        }
    }
}