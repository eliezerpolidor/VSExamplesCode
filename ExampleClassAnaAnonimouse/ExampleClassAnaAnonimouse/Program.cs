using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassAnaAnonimouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dataEmployee = new { name="EliezerP", LastName = "Polidor", Age = 53};
            //Console.WriteLine($"Data of Employees: {dataEmployee.name} {dataEmployee.LastName} {dataEmployee.Age} ");
            var opertionAdd = new {n=2+3};
            Console.WriteLine($"The Add is: {opertionAdd}");
            Console.ReadKey();
        }
    }
}
