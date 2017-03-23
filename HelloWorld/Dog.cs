using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Dog
    {
        // fields
        public string color;
        // properties
        public string Color
        {
            get;set;
        }
        // constructors
        public Dog() {}
        // methods
        public void Waggle()
        {
            Console.WriteLine("Wagging tail!");
        }
        public string Fetch(String returnToy)
        {
            return "ball" + returnToy;
        }
    }
}
