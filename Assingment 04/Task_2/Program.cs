


FillArray();





char[] FillArray()
{
    Console.WriteLine("Enter size of CHAR array");
    int size = int.Parse(Console.ReadLine());


    var CharArr = new char[size];

    Console.WriteLine("Enter " + size + " symbol");
    string symbol = Console.ReadLine();

    for (var i = 0; i < size; i++)
    {
        CharArr[i] = symbol[i];
    }

    for (var i = 0; i < size; i++)
        Console.WriteLine("CharArr[" + i + "] = " + CharArr[i]);


    Console.WriteLine("Enter symbol you want to search in array");
    string SearchSymbolST = Console.ReadLine();
    char SearchSymbo = SearchSymbolST[0];

    SearchSymbol(CharArr, SearchSymbo);

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

    CountSymbol(Count, Symbol);
    return Count;
}


void CountSymbol(int Count, char Symbol)
{
    Console.WriteLine("Symbol '" + Symbol + "' was " + Count + " times");
}