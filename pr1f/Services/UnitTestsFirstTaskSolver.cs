using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f.Services
{
    public class UnitTestsFirstTaskSolver
    {
        private List<int> values;
        public UnitTestsFirstTaskSolver(int a, int b, int c)
        {
            values = new List<int>
            {
                a,
                b,
                c
            };
        }

        public double Calculate()
        {
            if(values.All(x => x % 5 == 0))
            {
                return values.Sum();
            }
            else
            {
                return Math.Pow(values.Sum(), 3);
            }
        }
    }
}
