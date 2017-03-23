using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Dog becky = new HelloWorld.Dog();
            becky.Color = "beige";

            becky.Waggle();
            Console.WriteLine(becky.Color);
            Console.ReadKey();
            float f = 3.13F;
        }
    }
}
