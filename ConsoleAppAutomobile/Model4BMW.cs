using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    internal class Model4BMW : BMW
    {
        public override void GetClassAuto()
        {
            Console.WriteLine($"Модель 4 - D-класс");
        }

        public override void GetTheTypeOfCar()
        {
            Console.WriteLine($"Модель 4 - не спортивная");
        }

        public override void ReturnMaxSpeed()
        {
            Console.WriteLine($"Модель 4 скорость 250 км/ч");
        }
    }
}
