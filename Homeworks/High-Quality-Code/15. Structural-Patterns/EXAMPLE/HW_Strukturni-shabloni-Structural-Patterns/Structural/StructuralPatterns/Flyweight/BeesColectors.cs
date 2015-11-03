using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class BeesColectors : Bee
    {
        public BeesColectors()
        {
            this.Job = "collector";
            this.Width = 100;
            this.Height = 50;
        }

        public override void Display(int years)
        {
            Console.WriteLine("{0} (years {1})", this.Job, years);
        }
    }
}
