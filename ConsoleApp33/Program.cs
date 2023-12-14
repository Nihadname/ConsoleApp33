// See https://aka.ms/new-console-template for more information
using ConsoleApp33.Domain.Models;


Console.WriteLine("Hello, World!");
Student student = new Student("Nihad", "ibadzade", 56);
Student student1 = new Student("Nihad2", "ibadzade6",  79);
Student student2 = new Student("Nihad3", "ibadzade2",  75);
Student student4 = new("Nihad9", "ibadzade7", 86);
try {
    Group group = new Group(4);
    group.AddStudents(student1);
    group.AddStudents(student2);
    group.AddStudents(student);
    group.AddStudents(student4);

    foreach (Student student3 in group.GetAllStudents())
    {
        Console.WriteLine($"{student3.Name}, {student3.SurName},{student3.Point}");
    }
    Console.WriteLine("sort olunmuslar");
    List<Student> sortedStudents = group.Sort();
    foreach (var sortedStudent in sortedStudents)
    {
        Console.WriteLine($"{sortedStudent.Name}, {sortedStudent.SurName}, {sortedStudent.Point}");
    }


}
catch (Exception ex) 
{
    Console.WriteLine(ex.Message);
}

Group group1 = new Group(3);
Console.WriteLine(group1.GroupNo);



