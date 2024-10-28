using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    public class Car
    {
        public int EnginePower { get; set; }
        public string model { get; set; }
        public int VINid { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Возвращает максимальную скорость автомобиля в зависимости от модели передаваемой в метод.
        /// </summary>
        /// <returns>Максимальная скорость автомобиля в км/ч и ее модель</returns>
        public virtual void ReturnMaxSpeed(string model)
        {
            if (model == null)
            {
                Console.WriteLine($"Не определена");
            }
            else
            {
                Console.WriteLine($"Модель {model} скорость...");
            }
        }
    }
}
