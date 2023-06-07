int Number = Convert.ToInt32(Console.ReadLine()), Space, Print;

for (int i = 1; i <= Number; i++) 
{
    for (Space = 1; Space <= (Number - i); Space++) 
        Console.Write(" ");
    for (Print = 1; Print <= i; Print++) 
        Console.Write("*");
    for (Print = (i - 1); Print >= 1; Print--) 
        Console.Write("*");
    Console.WriteLine();
}