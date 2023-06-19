
Console.WriteLine("Input size of CHAR array");
int Size;
bool CheckElement;
    
CheckElement = int.TryParse(Console.ReadLine(), out Size);
if (!CheckElement || Size <= 0)
{
    Console.WriteLine("size equal only 1.2.3.4....");
    return;
}

char[] CharArr = FillArray(Size);



Console.WriteLine("Input symbol you want to search in array");
char Symbol = Convert.ToChar(Console.ReadLine()!);

int Count =  SearchSymbol(CharArr, Symbol);
CountSymbol(Count, Symbol);


char[] FillArray(int Size)
{
    var CharArr = new char[Size];

    Console.WriteLine("Input " + Size + " symbol");
    for (var i = 0; i < Size; i++)
    {
        Console.Write("input {0}: ", i + 1);
        CharArr[i] = Convert.ToChar(Console.ReadLine()!);
    }
    return CharArr;
}

int SearchSymbol(char[] CharArr, char Symbol)
{
    int Count = 0;
    foreach (char c in CharArr)
    {
        if (c == Symbol)
            Count++;
    }
    return Count;
}


void CountSymbol(int Count, char Symbol)
{
    Console.WriteLine("Symbol '" + Symbol + "' was " + Count + " times");
}
