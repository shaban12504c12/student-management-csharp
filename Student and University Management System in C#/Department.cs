using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_University_Management_System_in_C_
{
    internal class Department
    {
        public string Name { get; set; }    
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; }= new List<Course>();
        public void AddStudent( Student student)
        {
            Students.Add(student);
            Console.WriteLine($"{student.Name} has registered for Debrtment: {Name}");

        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
            Console.WriteLine($"{course.courseName} has registered for Debrtment: {Name}");
        }
        public void PrintDepartmentDetails()
        {
            Console.WriteLine($"\n--- Department: {Name} ---");

            Console.WriteLine("\nCourses:");
            foreach (var c in Courses)
                c.PrintCourseInfo();

            Console.WriteLine("\nStudents:");
            foreach (var s in Students)
            {
                Console.WriteLine("----------------");
                s.Print();
            }
        }

    }
}
