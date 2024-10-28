using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    public class BMW : Car
    {
        /// <summary>
        /// Возвращает максимальную скорость автомобиля в зависимости от модели передаваемой в метод.
        /// <para> Допустимые модели для BMW: 2, 3, 4, M4, 5, M5 </para>
        /// </summary>
        /// <returns>Максимальная скорость автомобиля в км/ч и ее модель</returns>
        
        public override void ReturnMaxSpeed(string model)
        {
            if (model == "2")
            {
                Console.WriteLine($"Модель {model} скорость 250 км/ч");
            }
            if (model == "3")
            {
                Console.WriteLine($"Модель {model} скорость 250 км/ч");
            }
            if (model == "4")
            {
                Console.WriteLine($"Модель {model} скорость 250 км/ч");
            }
            if (model == "M4")
            {
                Console.WriteLine($"Модель {model} скорость 280 км/ч");
            }
            if (model == "5")
            {
                Console.WriteLine($"Модель {model} скорость 237 км/ч");
            }
            if (model == "M5")
            {
                Console.WriteLine($"Модель {model} скорость 305 км/ч");
            }
            else
            {
                Console.WriteLine("Скорость не определена");
            }
        }
    }
}
