using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pedro",18);
            Console.WriteLine(p1.name);
            Persona p2 = new Persona("Cascante",18);
            Console.WriteLine(p2.name + " " + p1.name);
        }
    }
}
