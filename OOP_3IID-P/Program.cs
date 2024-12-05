// See https://aka.ms/new-console-template for more information
using OOP_3IID_P.Constructions;
using OOP_3IID_P.Constructions.models;
using OOP_3IID_P.Constructions.models.DTO;
using OOP_3IID_P.IndustrialHalls;
using OOP_3IID_P.ResidentalBuildings;
using OOP_3IID_P.Wrappers;

Console.WriteLine("Hello, World!");
var house = new Construction();
var house2 = new Construction(BuildMaterialEnum.Brik, 23, 45, 4, 5);
var house3 = new Construction(
    new CreateConstructionDto()
    {
        HumanCapacity = 3,
        Width = 4,
        Height = 5,
        BuildMaterial = BuildMaterialEnum.Brik
    }
);
Console.WriteLine(house2.HumanCapacity);
Console.WriteLine(house2.Entrances);
Console.WriteLine(house2.Width);
Console.WriteLine(house2.Height);
Console.WriteLine(house2.BuildMaterial);
Console.WriteLine("\n");
Console.WriteLine(house.HumanCapacity);
Console.WriteLine(house.Entrances);
Console.WriteLine(house.Width);
Console.WriteLine(house.Height);
Console.WriteLine(house.BuildMaterial);
Console.WriteLine(house.getSquareCost());

var industrialHall = new IndustrialHall(
    new CreateConstructionDto()
    {
        HumanCapacity = 5,
        Width = 1,
        Height = 3,
        BuildMaterial = BuildMaterialEnum.Brik
    }
);
var residentalBuilding = new ResidentalBuilding(3);

Console.WriteLine(industrialHall.HumanCapacity);
Console.WriteLine(industrialHall.Entrances);
Console.WriteLine(industrialHall.Width);
Console.WriteLine(industrialHall.Height);
Console.WriteLine(industrialHall.BuildMaterial);

Console.WriteLine(residentalBuilding.HumanCapacity);
Console.WriteLine(residentalBuilding.Entrances);
Console.WriteLine(residentalBuilding.Width);
Console.WriteLine(residentalBuilding.Height);
Console.WriteLine(residentalBuilding.BuildMaterial);
Console.WriteLine(residentalBuilding.NumberOfFloors);
//Console.WriteLine(residentalBuilding.DisplayCostDetails());

var wrapped1 = new BuildingWrapper(residentalBuilding);
var wrapped2 = new BuildingWrapper(industrialHall);
Console.WriteLine(wrapped1.GetWrappedSquareCost());
Console.WriteLine(wrapped2.GetWrappedSquareCost());
