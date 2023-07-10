
using Quiz;
using System.Collections.Generic;
bool AddQuestion = true;

List<FillingQuizFunctionality> Quiz = new List<FillingQuizFunctionality>();
AddQuizFile AddQuizToFile = new AddQuizFile();

Console.WriteLine("1 - Add Question");
Console.WriteLine("2 - Clear file of Question and Add Question");
Console.WriteLine("3 - filling Question");
Console.WriteLine("Other kay - Exult");
try
{
    if (int.TryParse(Console.ReadLine(), out int Number))
    {

        switch (Number)
        {
            case 1:
            case 2:
                while (AddQuestion)
                {
                    if(Number == 2)
                        AddQuizToFile.ClearFile();

                    FillingQuizFunctionality FillingQuiz = new FillingQuizFunctionality();
                    FillingQuiz.AddQuestion();

                    Quiz.Add(FillingQuiz);

                    Console.WriteLine("1 - Add Question");
                    Console.WriteLine("2 - Save");
                    Console.WriteLine("Other kay - Exult");
                    if (int.TryParse(Console.ReadLine(), out Number))
                    {
                        AddQuestion = Number == 1 ? true : false;

                        if (Number == 2)
                        {
                            AddQuizToFile.FillQuestion(Quiz);
                        }
                    }
                }
                break;
            case 3:
                Console.WriteLine("Input your fullname");
                var name = Console.ReadLine();
                var point = AddQuizToFile.FillQuiz();
                Console.WriteLine($"{name} point is {point}");
                break;
        }
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}




//var path = @"C:\Users\Mzoziashvili\source\repos\C#\Assingment 15\Quiz\Quiz\bin\Debug\net6.0\Quiz.txt";

//using (StreamWriter sw = new StreamWriter(path,true))
//{
//    sw.WriteLine("jda mtirali wylisa pirsa");
//    sw.WriteLine("shavi tskheni sadavita");

//    sw.Close();
//}

//using (StreamReader sr = new StreamReader(path, true))
//{
//    while (sr.ReadLine() != null)
//    {

//        Console.WriteLine(sr.ReadLine());
//    }
//}


//using (var fs = new FileStream(path, FileMode.Open))
//{
//    string b = "bolo teqsti";
//    byte[] bb = Encoding.Default.GetBytes(b);
//    fs.Write(bb, 0, bb.Length);
//        int leng = (int)fs.Length;
//        byte[] buffer = new byte[leng];
//        fs.Read(buffer, 0, leng);

//        for (int i = 0; i < leng; i++)
//        {
//Console.WriteLine((char)buffer[i]);
//        }
//        Console.WriteLine();
//}