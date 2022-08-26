using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleArrayObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arrayEmployee = new Employee[4]; //cree, declare, inicie el array

            Employee sandra = new Employee("Sandra","Pernia","Zulia",35);
            Employee alberto = new Employee("Alberto","Castillo","Cumana",28);
            arrayEmployee[0] = new Employee("Eliezer", "Polidor", "Caracas", 53);
            arrayEmployee[1] = new Employee("Diana", "Carrillo", "Miranda", 27);
            arrayEmployee[2] = sandra;
            arrayEmployee[3] = alberto;

            Console.WriteLine("............DATA EMPLOYEE...............");
            Console.WriteLine("USING THE LOOP FOR SHOW RECORD THE ARRAY");
            for (int i = 0; i < arrayEmployee.Length; i++)
            {
                Console.WriteLine(arrayEmployee[i].);
            }
           
        }
    }

    class Employee
    {
        private string name;
        private string lastName;
        private string direction;
        private int age;
        public Employee(string name, string lastName, string direction, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.direction = direction;
            this.age = age;
        }

        public string getInf()
        {
            return name + " " + lastName + " " + direction + " " + age + " años";
        }
    }
}
