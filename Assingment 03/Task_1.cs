int[] array = new int[5];
bool WhileLoop = true;


for (int i = 0; i< array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}


while (WhileLoop)
{
    WhileLoop = false;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            var element = array[i];
            array[i] = array[i+1];
            array[i+1] = element;
            WhileLoop = true;
        }
    }
}
foreach (int i in array)
{
    Console.WriteLine(i);
}