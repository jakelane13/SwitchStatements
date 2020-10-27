using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "C#";

            Console.WriteLine("What is your favorite subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "c#":
                    Console.WriteLine("you're in the right class");
                    break;
                case "Math":
                    Console.WriteLine("math is fun but this aint it chief");
                    break;
                case "English":
                    Console.WriteLine("ew english sucks");
                    break;
                default:
                    Console.WriteLine("ya i've never heard of that");
                    break;
            }
        }
    }
}
