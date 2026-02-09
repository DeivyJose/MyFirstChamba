using System;

namespace MyFirstChamba
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person{};
            person1.Name = "Starling Germosen";
            person1.IdntityCard = "402-0934867-3";
            person1.Age = 25;

            person1.AddRol(Rol.Teacher);
            person1.AddRol(Rol.Employee);

            person1.ShowInfo();

            Console.ReadLine();

        }
    }
}

