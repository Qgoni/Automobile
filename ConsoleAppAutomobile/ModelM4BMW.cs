using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    internal class ModelM4BMW : BMW
    {
        public override void GetClassAuto()
        {
            Console.WriteLine($"Модель M4 - D-класс");
        }

        public override void GetTheTypeOfCar()
        {
            Console.WriteLine($"Модель M4 - спорткар");
        }

        public override void ReturnMaxSpeed()
        {
            Console.WriteLine($"Модель M4 скорость 280 км/ч");
        }
    }
}
