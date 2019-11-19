using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class MathLogic
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public bool TriangleCheck(double first, double second, double third)
        {
            return (first < second + third || second < first + third || third < first + second);               
        }

    }

}
