using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_University_Management_System_in_C_
{
    public abstract class Person
    {
        public string Name { get; set; }
        public void Print() 
        {
            Console.WriteLine($"The Name is {this.Name}");
        }
    }
}
