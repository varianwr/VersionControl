using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Method.Variable.Type
{
    class FloatOrDouble
    {
        double d = 34.567839023;

        float e = 12.345F;

        double f = 8923.1234857;

        float j = 3456.091F;

        //Write a program to assign the numbers in variables and print them to ensure no precision is lost
        //float precision 7 digits
        //double precision 15-16 digits
        //decimal precision 28-29 digits

        public static void FloatOrDoube()
        {
            double d = 34.567839023;
            Console.WriteLine(d);
            float e = 12.345F;
            Console.WriteLine(e);
            double f = 8923.1234857;
            Console.WriteLine(f);
            float j = 3456.091F;
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
