Console.WriteLine("Enter array size");
int ArraySize, ArrayIndexSun, Index, ArrayElement;
bool IsArraySize, IsIndex;

IsArraySize = int.TryParse(Console.ReadLine(), out ArraySize);

if (!IsArraySize || ArraySize <= 0) return;

Console.WriteLine("Enter array elements");
int[] MyArray = new int[ArraySize];



for (int i = 0; i < ArraySize; i++)
{
   var IsElement = int.TryParse(Console.ReadLine(), out ArrayElement);
    
    if (IsElement && ArrayElement > 0)
    {
        MyArray[i] = ArrayElement;
    }
    else {
        return;
    }
}


Console.WriteLine("Enter index of array");
IsIndex = int.TryParse(Console.ReadLine(), out Index);
if (!IsIndex || Index < 0) return;

ArrayIndexSun = ArraySum(MyArray, Index);
Console.WriteLine("Sum index of array is "+ ArrayIndexSun);


int ArraySum(int[] Array, int Index)
{
    if(Array.Length < Index)
    {
        return -1;
    }
    var Sum = 0;

    string Element = Array[Index].ToString();

    for (int i = 0; i < Element.Length; i++)
    {
        Sum += Convert.ToInt32(new string(Element[i], 1));
    }
    
    return Sum;
}
