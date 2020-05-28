using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>()
            {
               new Student("Jimmy", 13),
               new Student("Hannah Banana", 21),
               new Student("Justin", 30),
               new Student("Sarah", 53),
               new Student("Hannibal", 15),
               new Student("Phillip", 16),
               new Student("Maria", 63),
               new Student("Abe", 33),
               new Student("Curtis", 10)
            };
            var minnum = nums.Min();
            Console.WriteLine("Min " + minnum);
            Console.WriteLine();
            var maxnum = nums.Max();
            Console.WriteLine("Max " + maxnum);
            Console.WriteLine();
            var maxnum1000 = nums.Where(x => x < 1000).Max();
            Console.WriteLine("Max less than 1000 " + maxnum1000);
            Console.WriteLine();
            List<int> between = nums.Where(x => x > 9 && x < 101).ToList();
            foreach(int num in between)
            {
            Console.WriteLine(num);
            }
            Console.WriteLine();
            List<int> between2 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach (int num2 in between2)
            {
                Console.WriteLine(num2);
            }
            Console.WriteLine();
            List<int> even = nums.Where(x => x % 2 == 0).ToList();
            foreach (int num3 in even)
            {
                Console.WriteLine(num3);
            }
            Console.WriteLine();

            List<Student> drinking = students.Where(x => x.Age >= 21).ToList();
            foreach(Student stu in drinking)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine();

            List<Student> max = students.Where(x => x.Age > 62).ToList();
            foreach (Student stumax in max)
            {
                Console.WriteLine(stumax.Name);
            }
            Console.WriteLine();
            List<Student> max25 = students.Where(x => x.Age <= 25 && x.Age > 20).ToList();
            foreach (Student stumax in max25)
            {
                Console.WriteLine(stumax.Name);
            }
            Console.WriteLine();
            List<Student> even21 = students.Where(x => x.Age % 2 == 0 && x.Age >= 20).ToList();
            foreach (Student stumax in even21)
            {
                Console.WriteLine(stumax.Name);
            }
            Console.WriteLine();
            List<Student> between19 = students.Where(x => x.Age <= 19 && x.Age >= 13).ToList();
            foreach (Student stumax in between19)
            {
                Console.WriteLine(stumax.Name);
            }
            Console.WriteLine();
            List<Student> vowel = students.Where(x => x.Name is "Abe").ToList();
            foreach (Student stumax in vowel)
            {
                Console.WriteLine(stumax.Name);
            }
            Console.WriteLine();
        }
    }
}
