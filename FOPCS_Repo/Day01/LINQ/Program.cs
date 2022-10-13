using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                  new Student() { Name = "John", Age = 13 } ,
                  new Student() { Name = "Joey",  Age = 21 } ,
                  new Student() { Name = "Bill",  Age = 18 } ,
                  new Student() { Name = "Alex" , Age = 20} ,
                  new Student() { Name = "Ron" , Age = 15 }
            };
            List<Stud> students2 = new List<Stud>() {
                  new Stud() { Name = "John", ExamMark1 = 75, ExamMark2 = 80 } ,
                  new Stud() { Name = "Joey",  ExamMark1 = 95, ExamMark2 = 50 } ,
                  new Stud() { Name = "Bill",  ExamMark1 = 40, ExamMark2 = 50 } ,
                  new Stud() { Name = "Alex" , ExamMark1 = 20, ExamMark2 = 75 } ,
                  new Stud() { Name = "Ron" , ExamMark1 = 70, ExamMark2 = 80 }
            };

            int[] numbers = { 20, 12, 6, 10, 0, 3, 1 };

            var iter= from student in students
                      where student.Age<=20 && student.Age>=12
                      select student;
            var iter1 = from student in students2
                      orderby student.ExamMark1 descending
                        select student;
            var iter3 = from student in students2
                        orderby student.a student. descending
                        select student;

            var inter2 = from no in numbers
                         orderby no ascending
                         select no;
            Console.WriteLine("Question_1");
            foreach (Student student in iter)
                Console.WriteLine(student.Name);
            Console.WriteLine("Question_2");
            foreach (int no in inter2)
                Console.WriteLine(no);
            Console.WriteLine("Question_3");
            foreach (Stud student in iter1)
                Console.WriteLine(student.Name);
            Console.ReadLine();
        }
    }
}
