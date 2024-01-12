using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            #region Task1
            //İki ədəd verilib.əgər bu iki ədədin cəmi cüt ədədirsə "Cəm cüt ədəddir"deyilsə "Cəm tək ədəddir" yazı ekrana yazdırmaq
            int a = 3;
            int b = 4;

            int c = a + b;

            if (c % 2 == 0)
            {
                Console.WriteLine("Cem cut ededdir");
            }
            else
                Console.WriteLine("Cem tek ededdir");
            #endregion


            #region Task2

            //Massivdə 10(on) ədəd saxlanılıb  bu ədədlərdən cüt olanları ekrana yazdırmaq

            int[] numbers = { 2, 4, 6, 8, 9, 3, 15, 22, 45, 63 };
            Console.WriteLine("massivdeki cut ededler:");
            foreach (int number1 in numbers)
            {
                if (number1 % 2 == 0)
                {
                    Console.WriteLine(number1);

                }
            }

            #endregion


            #region Task3
            //Massivdə 10(on) ədəd saxlanılıb bu ədədlərdən tək olanların cəmini tapıb ekrana yazdırmaq

            int[] digits = { 1, 7, 8, 19, 23, 34, 26, 56, 48, 68 };

            int sum = 0;
            foreach (int digit in digits)
            {
                if (digit % 2 != 0)

                {
                    sum += digit;
                }
            }
            Console.WriteLine($"Sum of odd digits:{sum}");
            #endregion


            #region Task4
            //Verilmish 4 reqemli ededin reqemlerinin cemini tap (əgər ədəd 4reqemlidirse yoxlamaq)
            int num = 2567;

            if (num >= 1000 && num <= 9999)
            {
                int sm = 0;

                //sum of the digits
                while (num > 0)
                {
                    sm += num % 10;
                    num /= 10;
                }
                Console.WriteLine($"Sum of digits:{sm} ");
            }
            else
            {
                Console.WriteLine("Invalid number.Please,try again");
            }
            #endregion


            #region Task5
            Student student = Student.GetStudentInfoFromUser();

            Console.WriteLine($"Student name:{student.Name}");
            Console.WriteLine($"Student surname:{student.Surname}");
            Console.WriteLine($"Student age:{student.Age}");
            Console.WriteLine($"Student speciality:{student.Speciality}");
            Console.WriteLine($"Student Group Number:{student.GroupNo}"); 
            #endregion
        }
       

      











            
        
    }
}


