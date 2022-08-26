using System;

namespace ExampleCountingThelettersFromACountry
{
    class Program
    {
        private static string name="        Eliezer      ";
        private static string notSpaceName = name.Trim();
        
        static void Main(string[] args)
        {
            //Console.WriteLine("pleas write your name: ");
            //string answer = Console.ReadLine();
            //Console.WriteLine($"This country the name has {answer.Length} letters");
            Console.WriteLine($"This country name {notSpaceName} has: {notSpaceName.Length} letters");
            Console.ReadKey();
        }
    }
}
