using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFillArrayFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _dataArray = dateArray();
            Console.WriteLine("Show from Main Method");
            foreach (int item in _dataArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }

        static int[] dateArray() 
        {
            Console.WriteLine("how many elements do you want the array to have?");
            int numElements = int.Parse(Console.ReadLine());
            int[] dataArray = new int[numElements];
            for (int i = 0; i < dataArray.Length; i++)
            {
                Console.WriteLine($"The array has {numElements} elements: Enter value {i} from Elements: ");
                int numerber = int.Parse(Console.ReadLine());
                dataArray[i] = numerber;
            }
            return dataArray;       
        }
    }
}
