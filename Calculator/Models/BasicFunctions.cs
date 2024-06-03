using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class BasicFunctions
    {
        public int Som(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Sub(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Mul(int n1, int n2)
        {
            return n1 * n2;
        }

        public decimal Div(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
    }
}