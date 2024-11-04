using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    internal class Model5BMW : BMW
    {
        public override void GetClassAuto()
        {
            Console.WriteLine($"Модель 5 - D-класс");
        }

        public override void GetTheTypeOfCar()
        {
            Console.WriteLine($"Модель 5 - не спортивная");
        }

        public override void ReturnMaxSpeed()
        {
            Console.WriteLine($"Модель 5 скорость 237 км/ч");
        }
    }
}
