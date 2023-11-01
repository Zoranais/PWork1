using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f.Services
{
    public class ArraySolver
    {
        private readonly int[] values;

        public ArraySolver(string[] input)
        {
            values = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                values[i] = Convert.ToInt32(input[i]);
            }
        }

        public ArraySolver(int[] input)
        {
            values = new int[input.Length];
            for(int i = 0;i < input.Length; i++)
            {
                values[i] = input[i];
            }
        }

        public ArraySolver()
        {
            var random = new Random();
            var length = random.Next(1, 10);
            values = new int[length];
            for (int i = 0; i < length; i++)
            {
                values[i] = random.Next();
            }
        }

        public int this[int i]
        {
            get
            {
                return values[i];
            }
        }

        public double[] GetPows()
        {
            var result = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                result[i] = Math.Pow(values[i], 2);
            }
            return result;
        }
        public double[] GetSqrts()
        {
            var result = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                result[i] = Math.Sqrt(values[i]);
            }
            return result;
        }
    }
}
