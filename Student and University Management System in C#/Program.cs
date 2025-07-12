using Student_and_University_Management_System_in_C_;

class Program
{
    static void Main(string[] args)
    {
        // إنشاء قسم
        var csDepartment = new Department { Name = "Computer Science" };

        // إنشاء معلم
        var teacher = new Teacher { Name = "Dr. Ahmed" };

        // إنشاء مقررات
        var oopCourse = new Course { courseName = "Object Oriented Programming", teacher = teacher };
        var dbCourse = new Course { courseName = "Database Systems", teacher = teacher };

        // إضافة المقررات إلى القسم
        csDepartment.AddCourse(oopCourse);
        csDepartment.AddCourse(dbCourse);

        // إنشاء طالب
        var student = new Student { Name = "Mohammed", Id = 12345 };

        // إضافة الطالب إلى القسم
        csDepartment.AddStudent(student);

        // تسجيل الطالب في المقررات
        student.RegisterCourse(oopCourse);
        student.RegisterCourse(dbCourse);

        // طباعة بيانات الطالب
        Console.WriteLine("\nStudent Details:");
        student.Print();

        /////////////////////
        Console.WriteLine("Shaban");
        /// 
        // طباعة بيانات القسم بالكامل 
        csDepartment.PrintDepartmentDetails();
    }
}

