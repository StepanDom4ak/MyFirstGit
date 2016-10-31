using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGit
{
    class Fish
    {
        string Name { set; get; }
        double Weight { set; get; }
        double Price { set; get; }

        public override String ToString()
        {
            return String.Format("Name: {0}, Weight: {1}, Price: {2}", Name, Weight, Price);
        }
    }
}
