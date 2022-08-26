using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleArrayObjectStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student[] arrayStudent = new Student[3];
            
            Student julieta = new Student("Julieta","Marquez","Chacao",32);
            //TODO
            arrayStudent[0] = new Student("Eliezer", "Polidor", "Pastora", 53);
            arrayStudent[1] = new Student("Diana", "Perez", "Centro", 27);
            arrayStudent[2] = julieta;

            Console.WriteLine("DATA STUDENT");
            for (int i = 0; i < arrayStudent.Length; i++)
            {
                Console.WriteLine(arrayStudent[i].getInfStudent());
            }
            Console.ReadKey();
        }
    }

    class Student 
    {
        private string nameStudent;
        private string lastNameStudent;
        private string homeAddressStudent;
        private int ageStudent;

        public Student(string nameStudent, string lastNameStudent, string homeAddressStudent, int ageStudent)
        {
            this.nameStudent = nameStudent;
            this.lastNameStudent = lastNameStudent;
            this.homeAddressStudent = homeAddressStudent;
            this.ageStudent = ageStudent;
        }

        public string getInfStudent() 
        {
            return nameStudent + " " + lastNameStudent + " " + homeAddressStudent + " " + ageStudent;

        }
        
        //TODO
        public void setInfStudent()
        {
            Console.WriteLine("Enter Name: ");
            string nameStudent = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastNameStudent = Console.ReadLine();
            Console.WriteLine("Enter Home Address: ");
            string homeAddressStudent = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            string ageStudent= Console.ReadLine();

            //this.nameStudent = nameStudent;
            //this.lastNameStudent = lastNameStudent;
            //this.homeAddressStudent = homeAddressStudent;
            //this.ageStudent = int.Parse(ageStudent);

            
        }

    }
}
