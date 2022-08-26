using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleStructureSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            switc();
            commissionCalculatio();

        }

        static void switc() 
        {
            Console.WriteLine("Example one.............");
            Console.WriteLine("Select means of transport (cars) - (plane) - (train)");
            string meansTransport = Console.ReadLine();

            switch (meansTransport)
            {
                case ("cars"):
                    Console.WriteLine("Average Speed 100 Km/h");
                    Console.ReadKey();
                    break;
                case ("plain"):
                    Console.WriteLine("Average Speed 800 km/h");
                    Console.ReadKey();
                    break;
                case ("train"):
                    Console.WriteLine("Average Speed 250 km/h");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Transport not contemplated");
                    break;
            }
            Console.WriteLine("End of the program");
        }
    
        static void commissionCalculatio() 
        {
            Console.WriteLine("EXAMPLE TWO.............");
            Console.WriteLine("Enter month number for calculation commission: ");
            int nMonth = Int32.Parse(Console.ReadLine());

            switch (nMonth)
            {
                case (1):
                    Console.WriteLine("Calculation for the month the January");
                    break;
                case (2):
                    Console.WriteLine("Calculation for the month the February");
                    break;
                case (3):
                    Console.WriteLine("Calculation for the month the March");
                    break;
                case (4):
                    Console.WriteLine("Calculation for the month the April");
                    break;
                case (5):
                    Console.WriteLine("Calculation for the month the May");
                    break;
                case (6):
                    Console.WriteLine("Calculation for the month the June");
                    break;
                case (7):
                    Console.WriteLine("Calculation for the month the July");
                    break;
                case (8):
                    Console.WriteLine("Calculation for the month the August");
                    break;
                case (9):
                    Console.WriteLine("Calculation for the month the September");
                    break;
                case (10):
                    Console.WriteLine("Calculation for the month the October");
                    break;
                case (11):
                    Console.WriteLine("Calculation for the month the November");
                    break;
                case (12):
                    Console.WriteLine("Calculation for the month the December");
                    break;

                default:
                    Console.WriteLine("Select Fail..........");
                    break;
            }
            Console.WriteLine("End the program........");
            Console.ReadKey();
        }   
    }
}
