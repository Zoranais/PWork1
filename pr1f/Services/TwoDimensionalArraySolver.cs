using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f.Services
{
    public class TwoDimensionalArraySolver
    {
        private readonly int[,] values;

        public TwoDimensionalArraySolver(string[,] input)
        {
            var x = input.GetLength(0);
            var y = input.GetLength(1);
            values = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    values[i, j] = Convert.ToInt32(input[i, j]);
                }
            }
        }

        public TwoDimensionalArraySolver(int[,] input)
        {
            var x = input.GetLength(0);
            var y = input.GetLength(1);
            values = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    values[i, j] = input[i, j];
                }
            }
        }

        public TwoDimensionalArraySolver()
        {
            var random = new Random();
            var x = random.Next(1, 20);
            var y = random.Next(1, 20);
            values = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    values[i, j] = random.Next();
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return values[i, j];
            }
        }

        public double[,] GetPows()
        {
            var x = values.GetLength(0);
            var y = values.GetLength(1);

            var result = new double[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    result[i, j] = Math.Pow(values[i, j], 2);
                }
            }

            return result;
        }
    }
}
