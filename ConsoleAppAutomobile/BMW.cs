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
        public void GetListModelCar()
        {
            Console.WriteLine("Список моделей BMW:");
            string[] arrayCar = {
                "BMW 2 серии",
                "BMW 3 серии",
                "BMW 4 серии",
                "BMW M4 серии",
                "BMW 5 серии",
                "BMW M5 серии"
            };

            foreach (string car in arrayCar) 
            {
                Console.WriteLine(car);
            }
        }
    }
}
