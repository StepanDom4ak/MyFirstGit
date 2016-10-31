using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGit
{
    class Fish
    {
        public string Name { set; get; }
        public double Weight { set; get; }
        public double Price { set; get; }

        public static void MyMethod()
        {
            Console.WriteLine("I Have Just Cheking Git");
        }

        public override String ToString()
        {
            return String.Format("Name: {0}, Weight: {1}, Price: {2}", Name, Weight, Price);
        }
    }
}
