
string[] Game = { "Rock", "Paper", "Scissors" };
string RandomText, CustomerText;


//win Rock - Paper
//win paper - Scissors
//win scissors - Rock
while (true)
{
    Random rnd = new Random();
    int i = rnd.Next(0, Game.Length);
    RandomText = Game[i];
    Console.WriteLine("Enter the text (Rock, Paper, Scissors)");
    CustomerText = Console.ReadLine();

    if (RandomText == CustomerText)
    {
        Console.WriteLine("Game Text = " + RandomText + "  You Text = " + CustomerText + " try again.");
        continue;
    }
        
    else if ((RandomText == "Rock" && CustomerText == "Paper") ||
             (RandomText == "Paper" && CustomerText == "Scissors") ||
             (RandomText == "Scissors" && CustomerText == "Rock") )
    {
        Console.WriteLine("Game Text = " + RandomText + "  You Text = " + CustomerText + " YOU WIN!");
        break;
    }
    else
    {
        Console.WriteLine("Game Text = " + RandomText + "  You Text = " + CustomerText + " You lose try again.");
    }


}

