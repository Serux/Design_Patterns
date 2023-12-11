using System.Text;
using FactoryMethod.src;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", 
() => {
    StringBuilder sb = new StringBuilder();
    Factory[] arr = new Factory[5];
    arr[0] = new ScooterFactory();
    arr[1] = new CarFactory();
    arr[2] = new CarFactory();
    arr[3] = new CarFactory();
    arr[4] = new ScooterFactory();


    foreach (var i in arr)
    {
        sb.AppendLine(i.startFabric());
    }
        
    
    return sb.ToString();}

);

app.Run();

