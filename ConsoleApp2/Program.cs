// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using System.Reflection;

Console.WriteLine("Hello, World!");
Dictionary<string, string> map = new Dictionary<string, string>() { {"bool1","true"}, {"bool2","false"}, { "bool3", "true" }, { "bool4", "false" } };

Reflection reflection = new Reflection();

Class1 class1 = new Class1();
Class1 classone = (Class1)reflection.returnClass(map, class1);

Console.WriteLine(classone.bool1);
Console.WriteLine(classone.bool2);
Console.WriteLine(classone.bool3);
Console.WriteLine(classone.bool4);

Class2 class2 = new Class2();
Class2 classtwo = (Class2)reflection.returnClass(map, class2);

Console.WriteLine(classtwo.bool1);
Console.WriteLine(classtwo.bool2);
Console.WriteLine(classtwo.bool3);
Console.WriteLine(classtwo.bool4);