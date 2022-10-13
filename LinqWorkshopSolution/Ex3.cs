using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkshopSolution
{
    class Ex3
    {
        static void Main()
        {
            List<Student> students = new List<Student>() {
                new Student() { Name = "John", ExamMark1 = 75, ExamMark2 = 80 } ,
                new Student() { Name = "Joey",  ExamMark1 = 95, ExamMark2 = 50 } ,
                new Student() { Name = "Bill",  ExamMark1 = 40, ExamMark2 = 50 } ,
                new Student() { Name = "Alex" , ExamMark1 = 20, ExamMark2 = 75 } ,
                new Student() { Name = "Ron" , ExamMark1 = 70, ExamMark2 = 80 }
            };

            Solution3a(students);
            Console.WriteLine();

            Solution3b(students);
            Console.WriteLine();

            Solution3c(students);
            Console.WriteLine();

            Console.ReadKey();
        }

        public class Student
        {
            public string Name { get; set; }
            public int ExamMark1 { get; set; }
            public int ExamMark2 { get; set; }
        }

        static void Solution3a(List<Student> students)
        {
            var iter = from student in students
                       orderby student.ExamMark1 descending
                       select student.Name;

            foreach (var name in iter)
                Console.WriteLine(name);
        }

        static void Solution3b(List<Student> students)
        {
            var iter = from student in students
                       orderby Average(student.ExamMark1, student.ExamMark2) descending
                       select student.Name;

            foreach (var name in iter)
                Console.WriteLine(name);
        }

        static void Solution3c(List<Student> students)
        {
            var iter = from student in students
                       orderby Average(student.ExamMark1, student.ExamMark2) descending
                       select new {
                           Name = student.Name,
                           ExamAve = Average(student.ExamMark1,student.ExamMark2)
                       };

            foreach (var student in iter)
                Console.WriteLine("{0}: Exam average is {1}", student.Name, student.ExamAve);
        }

        static double Average(int num1, int num2)
        {
            // Because num1 and num2 are both integer, to make the division double, 
            // e.g, average of 72 and 73 are 72.5 instead of only 72, 
            // we need to cast the divident or divisor to double
            return (double) (num1 + num2) / 2;
        }
    }
}
