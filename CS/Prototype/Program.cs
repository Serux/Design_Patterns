// See https://aka.ms/new-console-template for more information
using Microsoft.Win32;
using Prototype.src;
using Prototype.src.Interfaces;

PrototypeRegistry pr = new PrototypeRegistry();
Button b = new Button(10,40,"red");
ScrollBar sb = new ScrollBar("100");
pr.additem(b);
pr.additem(sb);

IList<IPrototype?> copies = new List<IPrototype?>();
copies.Add(pr.getById(0)?.clone());
copies.Add(pr.getById(1)?.clone());
copies.Add(pr.getByColor("red")?.clone());

Console.WriteLine("Originals");
Console.WriteLine(b.ToString());
Console.WriteLine(sb.ToString());

Console.WriteLine("Copied");
Console.WriteLine(copies[0]?.ToString());
Console.WriteLine(copies[1]?.ToString());
Console.WriteLine(copies[2]?.ToString());

(copies[0] as Button).X= 100;
(copies[1] as ScrollBar).Scrollsize= "NoScroll";
(copies[2] as Button).X= 200;

Console.WriteLine("Originals after modification");
Console.WriteLine(b.ToString());
Console.WriteLine(sb.ToString());

Console.WriteLine("Copied After Modification");
Console.WriteLine(copies[0]?.ToString());
Console.WriteLine(copies[1]?.ToString());
Console.WriteLine(copies[2]?.ToString());


