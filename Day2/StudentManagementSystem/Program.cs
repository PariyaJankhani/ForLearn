using System.Diagnostics;
using System.Xml.Linq;
using StudentManagementSystem;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to The Main Menu!");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Enter the following number for...");
            Console.WriteLine("1.Add a new student \n 2.show the students list \n 3.Edit information of students \n 4.Student's report card \n 5.Search \n 6.close");
            Console.ResetColor();
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
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

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student Add to list!");
                Console.ResetColor();

            }
            else if (input == 2)
            {

            }







        }
    }
}
