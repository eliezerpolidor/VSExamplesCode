using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleArrayEnetrForConsola
{
    class Program
    {
        private static int note=20;

        static void Main(string[] args)
        {
            int i = 0;
            
            int[] arrayStudenNotes = new int[10];
            Console.WriteLine("Continuar s/n: ");
            string answer = Console.ReadLine();
            while (answer != "no") 
            {

                try
                {
                    Console.WriteLine("Enter  Notes Student: ");
                    int note = int.Parse(Console.ReadLine());
                    arrayStudenNotes[i++] = note;
                    if (note == 0) answer = "no";
                    
                }
                catch
                {
                    
                    //note = 0;
                }

                
            }
            Console.WriteLine("bye bye");
            Console.WriteLine("Show Record the Array");
            foreach (int item in arrayStudenNotes)
            {
                Console.WriteLine($"Nota{i} {item}");
            }
            Console.ReadKey();

        }
    }
}
