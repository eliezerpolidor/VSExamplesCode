using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1While
{
    class Program
    {
        
        private static int rando;
        private static string datetime = DateTime.Now.ToString("ss tt");
        static void Main(string[] args)
        {
            numbeRando();
            hitNumber();
            Console.ReadKey();

        }

        static int numbeRando()
        {
            rando = int.Parse(datetime);
            if (rando < 51) rando = int.Parse(datetime) * 2;
            return rando;
        }

        static void hitNumber() 
        {
            bool sw=true;
            int attemps=0;

            while (sw)
            {
                attemps++;
                Console.WriteLine("Enter in number: ");
                int number = int.Parse(Console.ReadLine());
                if (number == rando)
                {
                    Console.WriteLine("....!!!!!!Congratulations Hit Number Random.......!!!!");
                    sw = false;
                    Console.WriteLine($"The number Random is: {rando}");
                    Console.WriteLine($".....You NUMBER FOR aTTEMPS IS: {attemps}");
                }
                
                if (number>rando) Console.WriteLine("The number is less .....");
                if (number>0 && number<rando) Console.WriteLine("the number is greather .....");
                if (number == 0)
                {
                    sw = false;
                    Console.WriteLine(".....Thanks for you time....");
                    Console.WriteLine($"The number Random was: {rando}");
                    Console.WriteLine($".....You NUMBER FOR aTTEMPS IS: {attemps}");
                }
                


            }
            
            

            
        }
    }
}
