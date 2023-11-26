using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f
{
    public class ByResultComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Result < y.Result) return -1;
            if (x.Result > y.Result) return 1;
            return 0;
        }
    }
}
