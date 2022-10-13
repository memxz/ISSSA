using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkshopSolution
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Solution();
            Console.ReadKey();
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Solution()
        {
            List<Student> students = new List<Student>() {
                new Student() { Name = "John", Age = 13 } ,
                new Student() { Name = "Joey",  Age = 21 } ,
                new Student() { Name = "Bill",  Age = 18 } ,
                new Student() { Name = "Alex" , Age = 20} ,
                new Student() { Name = "Ron" , Age = 15 }
            };

            var iter = from s in students
                       where s.Age >= 12 && s.Age <= 20
                       select s.Name;

            foreach (var name in iter)
                Console.WriteLine(name);
        }
    }
}
