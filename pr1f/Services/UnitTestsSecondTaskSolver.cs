using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f.Services
{
    public class UnitTestsSecondTaskSolver
    {
        private int a;
        private int b;
        public UnitTestsSecondTaskSolver(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Calculate()
        {
            int result = 0;
            for (int i = a; i <= b && i < 30; i++)
            {
                if(i % 7 == 0)
                {
                    result = result == 0 ? i : result * i;
                }
            }

            return result;
        }
    }
}
