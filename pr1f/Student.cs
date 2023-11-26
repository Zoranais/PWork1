using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f
{
    public class Student: IComparable<Student>
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public int Result { get; set; }

        public Student(
            string name,
            int course,
            string group,
            int result)
        {
            Name = name;
            Course = course;
            Group = group;
            Result = result;
        }

        public int CompareTo(Student other)
        {
            return - Result.CompareTo(other.Result);
        }
    }
}
