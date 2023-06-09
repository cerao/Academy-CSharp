Console.WriteLine("Enter Array Length");
int ArrayOneLength = int.Parse(Console.ReadLine());
int[] IntArray = new int [ArrayOneLength];

Console.WriteLine("Enter INT number");
for (int i = 0; i < ArrayOneLength; i++)
{
    IntArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Enter Array Length");
int ArrayTwoLength = int.Parse(Console.ReadLine());
String[] StringArray = new String[ArrayTwoLength];

Console.WriteLine("Enter String");
for (int i = 0; i < ArrayTwoLength; i++)
{
    StringArray[i] = Console.ReadLine();
}

int ArrayThreeLength = ArrayOneLength > ArrayTwoLength ? ArrayOneLength : ArrayTwoLength;
String[] ThreeArray = new String[ArrayOneLength];


ThreeArray = StringArray;
if(ThreeArray.Length != ArrayThreeLength)
    Array.Resize(ref ThreeArray, ArrayThreeLength);

for (int i = 0;i < ArrayOneLength; i++)
{
    ThreeArray[i] += IntArray[i];
}

foreach (string i in ThreeArray)
{
    Console.WriteLine(i);
}
