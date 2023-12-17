// See https://aka.ms/new-console-template for more information

using System.Data;
using Singleton.src;




Console.WriteLine("Singleton not exists");
SingletonPattern s = SingletonPattern.getInstance();
Console.WriteLine("Singleton got created and returned");
SingletonPattern s2 = SingletonPattern.getInstance();
Console.WriteLine("Second pointer to Singleton instance got returned");
if(s == s2) 
    Console.WriteLine("OK to Check that they are pointers to the same instance");
else
    Console.WriteLine("Something went wrong and it's not the same instance");




