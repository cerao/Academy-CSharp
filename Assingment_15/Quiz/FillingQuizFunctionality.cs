using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Quiz
{
    public class FillingQuizFunctionality
    {
        public string _Question { get; set; }
        public string _CorrectAnswer { get; set; }
        public List<string> _ProbableAnswers = new List<string>();
        public int _QuestionPoint { get; set; }
        
        
        public void AddQuestion()
        {
                Console.WriteLine("Enter your Question");
                _Question = (string)Console.ReadLine();

                if (_Question.Length < 5)
                    throw new Exception(message: "Question is smoll");

                Console.WriteLine("How many probable answers do you have? (Max 5, Min 2)");
                if (!(int.TryParse(Console.ReadLine(), out int _QuestionQuantity)))
                {
                    throw new ArgumentNullException();
                }
                if (_QuestionQuantity > 5 || _QuestionQuantity < 1)
                {
                    throw new Exception(message: "Question Quantity between 2 and 5");
                }

                for (int i = 0; i < _QuestionQuantity; i++)
                {
                    Console.Write($"{i+1}) ");
                    var Answers = Console.ReadLine();
                    if (Answers == null || Answers.Length <= 0) 
                    { 
                        throw new ArgumentNullException(nameof(Answers));
                    }
                    _ProbableAnswers.Add(Answers);
            }

                Console.WriteLine("Enter Correct Answer");
                _CorrectAnswer = Console.ReadLine();

                if (_ProbableAnswers.FirstOrDefault(stringToCheck => stringToCheck.Contains(_CorrectAnswer)) == null)
                {
                    throw new Exception("Your Answer isn't in list");
                }
                Console.WriteLine("Enter Answer Point");
                bool IsPoint = (int.TryParse(Console.ReadLine(), out int Point));
                if (IsPoint == false || Point <= 0)
                {
                    throw new Exception(message: $"Your Point is {Point} Your Answer Point should be between 1 and 5");
                }
                _QuestionPoint = Point;
        }       
    }
}
