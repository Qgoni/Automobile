using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    internal class ModelM5BMW : BMW
    {
        public override void GetClassAuto()
        {
            Console.WriteLine($"Модель M5 - E-класс");
        }

        public override void GetTheTypeOfCar()
        {
            Console.WriteLine($"Модель M5 - спорткар");
        }

        public override void ReturnMaxSpeed()
        {
            Console.WriteLine($"Модель M5 скорость 237 км/ч");
        }
    }
}
