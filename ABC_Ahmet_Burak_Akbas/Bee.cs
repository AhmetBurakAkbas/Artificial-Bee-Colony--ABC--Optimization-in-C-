using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Ahmet_Burak_Akbas
{
    public class Bee
    {
        public double[] Position { get; set; }
        public double Fitness { get; set; }
        public int Trial { get; set; }

        public Bee(int dimension)
        {
            Position = new double[dimension];
            Trial = 0;
        }
    }

    public static class ObjectiveFunction
    {
        public static double Evaluate(double[] x)
        {
            return x.Sum(val => val * val);
        }
    }
}
