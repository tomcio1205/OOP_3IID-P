// See https://aka.ms/new-console-template for more information
using OOP_3IID_P.Constructions;
using OOP_3IID_P.Constructions.models;
using OOP_3IID_P.Constructions.models.DTO;

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

