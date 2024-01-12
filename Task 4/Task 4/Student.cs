using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Speciality { get; set; }
        public string GroupNo { get; set; }

        public Student(string name, string surname, int age, string speciality,string groupNo)
        {
            Name = name;
            Surname= surname;
            Age= age;
            Speciality= speciality;
            GroupNo= groupNo;

        }
        public static Student GetStudentInfoFromUser() 
        {
            Console.WriteLine("Enter student information:");

            Console.Write("Name: ");
            string name= Console.ReadLine();
            Console.Write("Surname: ");
            string surname= Console.ReadLine();
            Console.Write("Age: ");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Speciality: ");
            string speciality= Console.ReadLine();
            Console.Write("Group number:");
           string groupNo= Console.ReadLine();  

            return new Student(name, surname, age, speciality,groupNo);
        }
    }
}
