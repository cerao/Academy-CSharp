Console.WriteLine("enter array number");
int[] OneArray = new int[5];

for (int i = 0; i < 5; i++)
{
    OneArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("enter array number");
int[] TwoArray = new int[5];
for (int i = 0; i < 5; i++)
{
    TwoArray[i] = int.Parse(Console.ReadLine());
}
Array.Sort(OneArray);
Array.Sort(TwoArray);

int[] ThreeArray = new int[10];

for (int i = 0; i < 5; i++)
{
    ThreeArray[i] = OneArray[i];
    ThreeArray[i+4] = TwoArray[i];
}
foreach (int i in ThreeArray)
{
    Console.WriteLine(i);
}