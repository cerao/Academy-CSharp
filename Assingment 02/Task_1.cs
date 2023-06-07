
int a = 0, Number =Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= Number; i++)
{
    if (Number % i == 0)
    {
        a++;
    }
}
if (a == 2)
{
    Console.WriteLine("is a Prime Number", Number);
}
else
{
    Console.WriteLine("Not a Prime Number");
}