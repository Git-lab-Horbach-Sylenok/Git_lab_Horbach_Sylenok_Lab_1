using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Calculator
{
    public class Subtraction : IOperation
    {
        public double Calculate(double a, double b) => a - b;
    }
}
