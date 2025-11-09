using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public List<Grade> Grades { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            PhoneNumber = "";
            Grades = new List<Grade>();

        }


        public void AddGrade(string courseName, int score)
        {

            
             Grades.Add(new Grade(courseName, score));
                

        }
    }

    public class Grade
    {
        public string CourseName { get; set; }
        public int Score { get; set; }

        public Grade(string courseName, int score)
        {
            CourseName = courseName;
            Score = score;
        }



    }

   


}
