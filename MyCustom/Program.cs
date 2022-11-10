// See https://aka.ms/new-console-template for more information
using MyCustom;

Console.WriteLine("Hello, World!");

var v1 = new MyVector(1, 5);
var v2 = new MyVector(1, 5);

var result = MyVector.Add(v1, v2);

Console.WriteLine(result);


Console.ReadLine();