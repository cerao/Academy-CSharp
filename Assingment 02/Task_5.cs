int Max = 0, Min = 0, GameNumber = 0, PlayerNumber = 0, Count = 0;
string str;
bool Game = true;


while (Game)
{
    if(Max == 0 && Min == 0)
    {

        Console.WriteLine("Min =");
        Min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Max =");
        Max = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        GameNumber = rnd.Next(Min,Max);
        Console.WriteLine("Enter your number between ( Max ="+Max + " Min ="+ Min);
    }

    PlayerNumber = Convert.ToInt32(Console.ReadLine());
    Count++;
    if (GameNumber == PlayerNumber)
    {
        Console.WriteLine("You win on the "+ Count + " try. Do you Want play again Y/N");
        str = Console.ReadLine();
        Game = str == "Y" ? true: false;
        if(Game == true)
        {
            Max = 0; 
            Min = 0;
            PlayerNumber = 0;
            GameNumber = 0;
            Count = 0;

        }

    }
    else
    {
        Console.WriteLine("You Wrong");

    }


}