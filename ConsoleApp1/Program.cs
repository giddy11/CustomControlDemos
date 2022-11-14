// See https://aka.ms/new-console-template for more information



#region MyVector 
//using ConsoleApp1;

//var v1 = new MyVector(20, 10);
//var v2 = new MyVector(10, 20);


//var vec1 = new MyVector();

//vec1.XCordinates = 2;
//vec1.YCordinates = 2;


////var v8 = new MyVector();
//var v9 = MyVector.AngleBetween(v1, v2);

////v1.ScalarDivision(2);

//var v10 = v1 / 2;

////var v3 = new MyVector();
////var v4 = new MyVector();

////MyVector v6 = 2 * v1;

//v2.Normalize();

//v3.XCordinates = 2;
//v4.XCordinates = 3;

//var result3 = v3 + v4;
//var result = MyVector.Add(v1, v2);
//var result2 = v1 + v2;
//var crossProduct = MyVector.CrossProduct(v1, v2);
//var subtraction = MyVector.Subtract(v1, v2);

//Console.WriteLine(v9); 
#endregion


using ConsoleApp1;

var accesor = new MyMatrix();
var matrix1 = new MyMatrix(1,2,3,4,0,1);
var matrix2 = new MyMatrix(0,1,2,1,0,1);
var matrix3 = new MyMatrix(1, 2, 3, 4, 0, 1);
var matrix4 = new MyMatrix(0,0,0,0,0,0);
var matrix8 = accesor.Rotate(45);


var matrix6 = accesor.Scale(1, 0.5);
var matrix7 = accesor.Translate(1, 0.5);


var result = accesor.ScaleAt(matrix6, matrix3);
var result1 = accesor.TranslateAt(matrix7, matrix3);
var result2 = accesor.RotateAt(matrix8, matrix3);

//var multiply = new MyMatrix();
//multiply.Multiply(matrix3, matrix5);
//multiply.Scale()


Console.WriteLine(result1);

Console.ReadLine();
