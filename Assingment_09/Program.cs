
using Task;

MatrixClass matrixClass = new MatrixClass();
matrixClass.FillMatrix();
MatrixClass matrixClass2 = new MatrixClass();
matrixClass2.FillMatrix();

var matrixClass3 = new MatrixClass();
matrixClass3 = matrixClass + matrixClass2;
//Console.WriteLine("+");
//matrixClass3.Print();
matrixClass3 = matrixClass - matrixClass2;
//Console.WriteLine("-");
//matrixClass3.Print();
matrixClass3 = matrixClass * matrixClass2;
//Console.WriteLine("*");
//matrixClass3.Print();

Console.WriteLine("-");
matrixClass3 = -matrixClass3;
//matrixClass3.Print();

var IntNumber = matrixClass3;
Console.WriteLine(IntNumber);
Console.WriteLine(matrixClass3.ToString());
