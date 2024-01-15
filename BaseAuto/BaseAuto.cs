using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
 * Описать класс -Авто- (марка - модель - обьем - привод - коробка). 
 * Создать список машин и вывести с него только те,
 * у которых в имени есть буква -а- или -А-
*/

namespace Auto.BaseAuto
{
    internal class BaseAuto
    {
       public string Brand;
       public string Model;
       public decimal EngineCapacity;
       public string DriveType;
       public string Transmission;

        public BaseAuto(string brand, string model, decimal engineCapacity, string driveType, string transmission)
                {
                Brand = brand;
                Model = model;
                EngineCapacity = engineCapacity;
                DriveType = driveType;
                Transmission = transmission;
                }
    }
}
