
int a=0, Number = Convert.ToInt32(Console.ReadLine());
string b = "(";

for(int i = 1; i <= Number; i++)
{
    if((Number % i) == 0)
    {
        a++;
        b = b + i + " ";
    }

}
b = b + ")";

Console.WriteLine(a + " " + b);