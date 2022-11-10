// See https://aka.ms/new-console-template for more information
using MyCustom;

Console.WriteLine("Hello, World!");

var v1 = new MyVector(20, 10);
var v2 = new MyVector(10, 20);

var result = MyVector.Add(v1, v2);
var crossProduct = MyVector.CrossProduct(v1, v2);
var subtraction = MyVector.Subtract(v1, v2);

Console.WriteLine(subtraction);


Console.ReadLine();