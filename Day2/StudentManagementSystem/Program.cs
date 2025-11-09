using System.Diagnostics;
using System.Xml.Linq;
using StudentManagementSystem;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter name");
            string name = Console.ReadLine();

            Console.WriteLine("please enter age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter course name");
            string course = Console.ReadLine();

            Console.WriteLine($"please enter grade of {course} :");
           
            int score = int.Parse(Console.ReadLine());

           Student student = new Student(id, name, age);

            student.AddGrade(course, score);


            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Age: {student.Age}");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"Course: {grade.CourseName}, Score: {grade.Score}");
            }

        }
    }
}
