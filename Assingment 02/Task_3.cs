Console.WriteLine("How Many number do you want enter");
int Sum = 0, Pnc = 0, Count = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Count];


for (int i = 0; i < Count; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {
        Sum += arr[i];
        Pnc++;
    }
        
}
Console.WriteLine(Sum + "  "+ Sum / Pnc);
