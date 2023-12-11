// See https://aka.ms/new-console-template for more information


using System.Data;
using AbstractFactory.src;
using AbstractFactory.src.Interfaces;

IFurnitureFactory factory;
for (int i =0; i< 10; i++)
{
    factory = i%2==0? new ModernFurnitureFactory(): new VictorianFurnitureFactory();
    IChair chair = factory.createChair();
    ISofa sofa = factory.createSofa();
    Console.WriteLine($"Factory is creating {chair.info()} and {sofa.info()}");
}



