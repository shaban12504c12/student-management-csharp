
# 🎓 Student and University Management System – C#

A simple console-based management system that demonstrates core **Object-Oriented Programming (OOP)** principles using **C#**.  
This project simulates a basic university structure with students, teachers, departments, and courses.

---

## 🧠 Features

- Add new **Students** and **Courses**
- Assign **Teachers** to courses
- Register students in courses
- Organize students and courses into **Departments**
- Print detailed information about students and their registered courses
- Apply core **OOP concepts** such as:
  - Inheritance
  - Encapsulation
  - Polymorphism
  - Association
  - Abstraction

---

## 🛠️ Technologies

- **C# (.NET 6 or above)**  
- Console Application (No GUI for simplicity)

---

## 🏗️ OOP Concepts Demonstrated

| Concept         | Implementation                                                                 |
|-----------------|---------------------------------------------------------------------------------|
| Inheritance     | `Student` and `Teacher` inherit from base class `Person`                       |
| Encapsulation   | Properties managed via `get; set;`                                              |
| Polymorphism    | Method `Print()` overridden in `Student`                                       |
| Association     | A `Student` has a list of `Courses`<br>Each `Course` has a `Teacher` reference |
| Abstraction     | Base class `Person` represents shared identity                                 |

---

## 📁 Project Structure

```
├── Program.cs              // Entry point
├── Person.cs               // Base class
├── Student.cs              // Inherits Person
├── Teacher.cs              // Inherits Person
├── Course.cs               // Contains course details + teacher
├── Department.cs           // Contains students and courses
```

---

## ▶️ How to Run

1. Open the project in **Visual Studio** or any .NET-compatible IDE.
2. Build and run the solution.
3. The program runs in the **Console**, showcasing test data and registration flow.

---

## 📸 Sample Output

```
Mohammed has registered for course: Object Oriented Programming
Mohammed has registered for course: Database Systems

Student Details:
Name: Mohammed
Student ID: 12345
Registered Courses:
- Object Oriented Programming (Taught by: Dr. Ahmed)
- Database Systems (Taught by: Dr. Ahmed)
```

---

## 🚀 Future Improvements

- Add interactive console menu (Add / View / Search)
- Implement file storage or database
- Add interface `IRegisterable`
- Extend system to support grading

---

## 🧑‍💻 Author

- **Shaaban Kamel**  
  Computer Science graduate from Mansoura University  
  Passionate about backend development (.NET)  
  [LinkedIn profile – www.linkedin.com/in/shabankamel]  

---

## 📄 License

Free to use and extend for educational or personal purposes.
"# student-management-csharp" 
