using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkshopSolution
{
    class Ex5
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

            Solution5(students);
            
            Console.ReadKey();
        }

        public class Student
        {
            public string Name { get; set; }
            public int ExamMark1 { get; set; }
            public int ExamMark2 { get; set; }

            public string MarkCategory
            {
                get
                {
                    double average = (double)(ExamMark1 + ExamMark2) / 2;
                    return (average > 0 ? (int)average / 10 : 0) + "x";
                }
            }

            public double Average
            {
                get
                {
                    return (double)(ExamMark1 + ExamMark2) / 2;
                }
            }
        }

        static void Solution5(List<Student> students)
        {
            var iter = from student in students
                       orderby student.Average descending
                       group student by student.MarkCategory;
    
            foreach (var group in iter)
            {
                Console.WriteLine("({0}): {1} students", group.Key, group.Count());
                foreach (var student in group)
                    Console.WriteLine("   {0}, average {1}", student.Name, student.Average);
            }
                
        }

    }
}
