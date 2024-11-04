using ConsoleAppAutomobile;

Console.WriteLine("Информация по машине BMW 2 серии");
Model2BMW bmwModel2 = new Model2BMW();
bmwModel2.model = "2";
bmwModel2.EnginePower = 4;
bmwModel2.Color = "Белый";
bmwModel2.VINid = 9836245874325;
Console.WriteLine($"VIN-{bmwModel2.VINid}\nОбъем двигателя {bmwModel2.EnginePower}\nЦвет - {bmwModel2.Color}");
bmwModel2.GetTheTypeOfCar();
bmwModel2.GetClassAuto();
bmwModel2.ReturnMaxSpeed();
bmwModel2.GetListModelCar();

Console.WriteLine("\nИнформация по машине BMW 3 серии");

Model3BMW bmwModel3 = new Model3BMW();
bmwModel3.model = "3";
bmwModel3.EnginePower = 4;
bmwModel3.Color = "Черный";
bmwModel3.VINid = 7836245874325;
Console.WriteLine($"VIN-{bmwModel3.VINid}\nОбъем двигателя {bmwModel3.EnginePower}\nЦвет - {bmwModel3.Color}");
bmwModel3.GetTheTypeOfCar();
bmwModel3.GetClassAuto();
bmwModel3.ReturnMaxSpeed();
bmwModel3.GetListModelCar();


