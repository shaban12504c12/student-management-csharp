using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_University_Management_System_in_C_
{
    internal class Student : Person
    {
        public int Id {  get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public void RegisterCourse(Course course)
        {
            Courses.Add(course);
            Console.WriteLine($"{Name} has registered for course: {course.courseName}");
        }

        public void PrintDetails()
        {
            base.Print();
            Console.WriteLine($"the Student ID is {this.Id}");
            foreach (var course in Courses)
            {
                course.PrintCourseInfo();
            }

        }

    }
}
