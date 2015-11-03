using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class MainClass
    {
        static void Main()
        {
            List<string> kosher = new List<string>();
            kosher.Add("queen");
            kosher.Add("collector");
            kosher.Add("collector");
            kosher.Add("collector");
            kosher.Add("scout");
            kosher.Add("scout");
            kosher.Add("scout");

            var beeFactory = new BeesFactory();

            var years = 0;

            foreach (var bee in kosher)
            {
                years++;
                var beeInKosher = beeFactory.GetBee(bee);
                beeInKosher.Display(years);
            }

        }
    }
}
