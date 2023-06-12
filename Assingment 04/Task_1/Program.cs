Console.WriteLine("Enter array size");
int ArraySize, ArrayIndexSun, Index;


ArraySize = int.Parse(Console.ReadLine());

Console.WriteLine("Enter array elements");
int[] MyArray = new int[ArraySize];

for (int i = 0; i < ArraySize; i++)
{
    MyArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter index of array");
Index = int.Parse(Console.ReadLine());

ArrayIndexSun = ArraySum(MyArray, Index);

Console.WriteLine("Sum index of array is "+ ArrayIndexSun);


int ArraySum(int[] Array, int Index)
{
    var sum = 0;

    if (Array.Length < Index)
        return -1;

    
    for (int i = 0; i < Index; i++)
    {
        sum += Array[i];
    }

    return sum;
}