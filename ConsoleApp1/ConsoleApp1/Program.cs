using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(25.IsOdd());
            Console.WriteLine(25.IsEven());
            Console.WriteLine("Leman99".IsContainsDigit());
            Console.WriteLine("leMan".ToCapitalize());

            int[] Arr = "Leman".GetValueIndexes('a');
            foreach (int item in Arr)
            {
                Console.WriteLine(item);
            }
            string fullname, groupNo;
            int age;
            do
            {
                Console.Write("Fullname: ");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullname(fullname));

            do
            {
                Console.Write("Group No: ");
                groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));


            do
            {
                Console.Write("age: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age <= 0 || age > 88);

            Student st = new Student();

        }
    }
}
