using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGetCurrenTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine(datetime);
            Console.ReadKey();
        }
    }
}
