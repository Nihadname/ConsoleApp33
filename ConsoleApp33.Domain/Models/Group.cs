using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.Domain.Models
{
    public class Group
    {
        private static int _GroupNo = 101;
        public string GroupNo { get; set; }
     
    //    private const int MaxStudentsInGroup = 4;
        public int GroupLimit {  get; set; }

            
        
        private List<Student> Students {  get; set; }
        public Group(int groupLimit)
        {
            GroupLimit = groupLimit;
            Students = new List<Student>();
            _GroupNo++;
            GroupNo = $"AP{_GroupNo}";
        }
        public void AddStudents(Student student)
        {
            //  Students = new List<Student>();

            if (Students.Count >= GroupLimit) throw new ArgumentNullException("limit bitib");
             Students.Add(student);
         
        }
        public List<Student> GetAllStudents()
        {
                return Students;
        }
        public List<Student> Sort()
        {
            List<Student> sortedStudents = new List<Student>(Students);
            sortedStudents.Sort((s1, s2) => s1.Point.CompareTo(s2.Point));
            return sortedStudents;
        }
    }
}
