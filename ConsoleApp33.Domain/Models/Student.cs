using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.Domain.Models
{
    public class Student
    {
        public string Name { get; set; }
        private static int _Id;
        public int Id { get; set; }
        public string SurName { get; set; }
        public int Age { get; set;}
        public int Point { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name},{Id},{SurName},{Age},{Point}");
        }
        public static bool operator >(Student s1, Student s2)
        {
            return s1.Point > s2.Point;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Point < s2.Point;
        }
        public Student(string name,string surname,int point)
        {
            Name = name;
            SurName = surname;
            Point = point;
            Id = _Id++;
        }
    }
}
