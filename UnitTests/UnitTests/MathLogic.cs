using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class MathLogic
    {/*            bool resultEx;
            MathLogic traingle = new MathLogic();
            traingle.a = 3;
            traingle.b = 4;
            traingle.c = 5;
            resultEx = traingle.triangleCheck(traingle.a, traingle.b, traingle.c);*/
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public bool triangleCheck(double first, double second, double third)
        {
            if (first > 0 || second > 0 || third > 0)
            {
                return (first < second + third || second < first + third || third < first + second);
            }
            else { return false; }
               
        }
        //public MathLogic(double a_, double b_, double c_)
        //{
        //    if (a_ > 0 && b_ > 0 && c_ > 0)
        //    {
        //        a = a_;
        //        b = b_;
        //        c = c_;
        //    }
            
        //}
        static void Main(string[] args)
        {
            TestCaseNUnit test1 = new TestCaseNUnit();
            test1.Test_NegativeValues();
            test1.Test_NotTraingleValues();
            test1.Test_TraingleValues();
            test1.Test_ZiroValue();
        }
    }

}
