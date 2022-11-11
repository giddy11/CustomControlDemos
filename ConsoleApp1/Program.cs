// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");

var v1 = new MyVector(20, 10);
var v2 = new MyVector(10, 20);

var vec1 = new MyVector();

vec1.XCordinates = 2;
vec1.YCordinates = 2;


//var v8 = new MyVector();
var v9 = MyVector.AngleBetween(v1, v2);

//v1.ScalarDivision(2);

var v10 = v1 / 2;

//var v3 = new MyVector();
//var v4 = new MyVector();

//MyVector v6 = 2 * v1;

v2.Normalize();

//v3.XCordinates = 2;
//v4.XCordinates = 3;

//var result3 = v3 + v4;
//var result = MyVector.Add(v1, v2);
//var result2 = v1 + v2;
//var crossProduct = MyVector.CrossProduct(v1, v2);
//var subtraction = MyVector.Subtract(v1, v2);

Console.WriteLine(v9);


Console.ReadLine();
