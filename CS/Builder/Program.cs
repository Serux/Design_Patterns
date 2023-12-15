// See https://aka.ms/new-console-template for more information


using System.Globalization;
using Builder.src;
using Builder.src.Enums;

HouseBuilder b = new HouseBuilder();
Director d = new Director(b);
d.make(HouseBuilderTypes.Normal);
House h1 = b.GetHouse();
b.reset();
d.make(HouseBuilderTypes.WithoutWindows);
House h2 = b.GetHouse();

HousePlanBuilder hpb = new HousePlanBuilder();
Director d2 = new Director(hpb);
d2.make(HouseBuilderTypes.Normal);
HousePlan hp1 = hpb.GetHousePlan();
hpb.reset();
d2.make(HouseBuilderTypes.WithoutWindows);
HousePlan hp2 = hpb.GetHousePlan();

Console.Write(h1.ToString());
Console.Write(h2.ToString());
Console.Write(hp1.ToString());
Console.Write(hp2.ToString());

