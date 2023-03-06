// See https://aka.ms/new-console-template for more information
using StudentExample;

Console.WriteLine("Hello, World!");

Console.WriteLine("=== Demonstrate Class Definition ===");
Student ThisStudent = new Student();
ThisStudent.FirstName = "Dapeng";
ThisStudent.LastName = "LI";

Student AnotherStudent = new Student("1234");
AnotherStudent.FirstName = "Din";
AnotherStudent.LastName = "Diesel";

ThisStudent.RegisterPaper("ISCG6426");
AnotherStudent.RegisterPaper("6426");
bool AttendStatus = ThisStudent.AttendClass();

Console.WriteLine();
Console.WriteLine("=== Demonstrate Linked List ===");
