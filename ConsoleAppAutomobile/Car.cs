using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutomobile
{
    public abstract class Car
    {
        public int EnginePower { get; set; }
        public string model { get; set; }
        public long VINid { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Возвращает максимальную скорость автомобиля в зависимости от модели передаваемой в метод.
        /// </summary>
        /// <returns>Максимальная скорость автомобиля в км/ч и ее модель</returns>
        public abstract void GetTheTypeOfCar();
        public abstract void GetBrand();
        public abstract void ReturnMaxSpeed();
        public abstract void GetClassAuto();
    }
}
