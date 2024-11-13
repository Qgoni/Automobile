using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    public abstract class BMW : Car
    {
        public abstract void GetTheTypeOfCar();
        public override void GetBrand()
        {
            Console.WriteLine("BMW");
        }
    }
}
