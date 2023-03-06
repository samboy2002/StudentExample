// See https://aka.ms/new-console-template for more information
using StudentExample;

Console.WriteLine("Hello, World!");

Console.WriteLine("=== Demonstrate Class Definition ===");
Student ThisStudent = new();
ThisStudent.FirstName = "Dapeng";
ThisStudent.LastName = "LI";

Student AnotherStudent = new("1234");
AnotherStudent.FirstName = "Din";
AnotherStudent.LastName = "Diesel";

ThisStudent.RegisterPaper("ISCG6426");
AnotherStudent.RegisterPaper("6426");
bool AttendStatus = ThisStudent.AttendClass();

Console.WriteLine('\n');
Console.WriteLine("=== Demonstrate Linked List ===");

IntegerLinkedList list = new();
list.Append(1);
list.Append(2);
list.Append(3);
list.Append(4);
list.Append(5);

Console.WriteLine(list.ToString());
Console.WriteLine($"The length of the list is {list.Length}");
Console.WriteLine($"The MaxValue={list.Max}, the MinValue={list.Min}");