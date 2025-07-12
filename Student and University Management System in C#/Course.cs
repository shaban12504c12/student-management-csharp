using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_University_Management_System_in_C_
{
    internal class Course
    {
        public string courseName {  get; set; }
        public Teacher teacher { get; set; }
        public void PrintCourseInfo()
        {
            Console.WriteLine($"The Corse Name is{this.courseName} And the Teacher Name Is{this.teacher}");
        }
    }
}
