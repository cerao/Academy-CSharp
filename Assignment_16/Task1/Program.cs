
using System.Diagnostics;
using Task1;
var Calc = new Calculator();
bool WhileLoop = true;
double DA, DB;
Console.WriteLine("choose what operation want you");
Console.WriteLine("1 +");
Console.WriteLine("2 -");
Console.WriteLine("3 *");
Console.WriteLine("4 /");
Console.WriteLine("5 Sqrt");
Console.WriteLine("6 Rise");
Console.WriteLine("Other key  close");
string ReadKey;


while (WhileLoop)
{
    Console.Write("My operation index is ");
    ReadKey = Console.ReadLine();

    switch (ReadKey)
    {
        case "1":
            var Assembly = new NumberCalculate(Calc.Assembly);
            Console.WriteLine("Ipnut number A and B");
            Console.Write("A = ");
            var NumberA = Console.ReadLine();
            Console.Write("B = ");
            var NumberB = Console.ReadLine();

            if (double.TryParse(NumberA, out DA) && double.TryParse(NumberB, out DB))
            {
                Assembly(DA, DB);
            }
            break;
        case "2":
            var Deduction = new NumberCalculate(Calc.Deduction);
            Console.WriteLine("Ipnut number A and B");
            Console.Write("A = ");
            var DeducA = Console.ReadLine();
            Console.Write("B = ");
            var DeducB = Console.ReadLine();

            if (double.TryParse(DeducA, out DA) && double.TryParse(DeducB, out DB))
            {
                Deduction(DA, DB);
            }
            break;
        case "3":
            var Multiply = new NumberCalculate(Calc.Multiply);
            Console.WriteLine("Ipnut number A and B");
            Console.Write("A = ");
            var MultipA = Console.ReadLine();
            Console.Write("B = ");
            var MultipB = Console.ReadLine();

            if (double.TryParse(MultipA, out DA) && double.TryParse(MultipB, out DB))
            {
                Multiply(DA, DB);
            }
            break;
        case "4":
            var Divide = new NumberCalculate(Calc.Multiply);
            Console.WriteLine("Ipnut number A and B");
            Console.Write("A = ");
            var DivideA = Console.ReadLine();
            Console.Write("B = ");
            var DivideB = Console.ReadLine();

            if (double.TryParse(DivideA, out DA) && double.TryParse(DivideB, out DB))
            {
                Divide(DA, DB);
            }
            break;
        case "5":
            var Sqrt = new NumberSqrt(Calc.Sqrt);
            Console.WriteLine("Ipnut number A");
            Console.Write("A = ");
            var A = Console.ReadLine();

            if (double.TryParse(A, out DA))
            {
                Sqrt(DA);
            }
            break;
        case "6":
            var NumberRise = new NumberRise(Calc.NumberRise);
            Console.WriteLine("Ipnut number A and B");
            Console.Write("A = ");
            var RiseA = Console.ReadLine();
            Console.Write("B = ");
            var RiseB = Console.ReadLine();

            if (double.TryParse(RiseA, out DA) && int.TryParse(RiseB, out int B))
            {
                NumberRise(DA,B);
            }
            break;
            default:
             WhileLoop = false;
            break;

    }
}

public delegate void NumberCalculate(double A, double B);
public delegate void NumberSqrt(double A);
public delegate void NumberRise(double A, int B);