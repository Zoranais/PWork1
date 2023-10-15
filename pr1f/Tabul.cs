using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1f
{
    internal class Tabul
    {
        public double[,] Xy { get; private set; }
        public int N { get; private set; }

        public Tabul()
        {
            Xy = new double[1000, 2];
            N = 0;
        }

        private double F1(double x) => 
            Math.Pow(Math.Abs(5), Math.Sin(x) + 2) + Math.Sin(x); 

        private double F2(double x) =>
            Math.Pow(x, 3) + Math.Pow(Math.Abs(x) + 1, 0.1 * x);

        private double F3(double x) =>
            Math.Pow(Math.Sin(x + 2), 3) / Math.Pow(Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(x), 4), 0.25);

        public void Tab(double xn = - 4.2, double xk = 28.1, double h = 0.1, double a = 0.5)
        {
            double x = xn;
            double y;

            N = 0;

            while (x <= xk)
            {
                if (x < 0)
                {
                    y = F1(x);
                }
                else if ((x >= 0) && (x < a))
                {
                    y = F2(x);
                }
                else
                {
                    y = F3(x);
                }

                Xy[N, 0] = x;
                Xy[N, 1] = y;
                x = x + h;

                N++;
            }

        }
    }
}
