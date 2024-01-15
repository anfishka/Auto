using Auto.BaseAuto;
using System.Collections.Generic;

List <string> auto = new List<string>() { "Toyota", "Ford", "Honda", "Volkswagen", "BMW", "Nissan", "Hyundai" };


// auto.Where(brand => brand.Contains("a")).ToList().ForEach(i => Console.Write($"{i},"));
List<string> filteredAuto = auto.Where(brand => brand.Contains("a")).ToList();
Console.WriteLine($"With string : { string.Join(", ", filteredAuto) } \n");


List<BaseAuto> cars = new List<BaseAuto>()
{
    new BaseAuto ("Toyota", "Camry", 2.5m, "FWD", "Automatic"),
    new BaseAuto ("Honda", "Accord", 2.5m, "FWD", "Manual"),
    new BaseAuto ("Ford", "Accord", 2.5m, "AWD", "Automatic"),
    new BaseAuto ("Volkswagen", "Golf", 2.5m, "FWD", "Automatic"),
    new BaseAuto ("BMW", "X5", 3.0m, "AWD", "Automatic"),
    new BaseAuto ("Nissan", "Altima", 2.5m, "FWD", "CVT"),
    new BaseAuto ("Hyundai", "Elantra", 2.0m, "FWD", "Automatic"),
};

 List<BaseAuto> filteredCars = cars.Where(car => car.Brand.Contains("a")).ToList();
//filteredCars.ForEach(e => Console.Write($"{e.Brand}, "));
Console.WriteLine($"With class : {string.Join(", ", filteredCars.Select(e => e.Brand))}" );





