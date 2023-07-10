using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class AddQuizFile : FillingQuizFunctionality
    {
        public const string _FilePath = @"C:\Users\Mzoziashvili\source\repos\C#\Assingment 15\Quiz\Quiz\bin\Debug\net6.0\Quiz.txt";
        public const string _AnswerPath = @"C:\Users\Mzoziashvili\source\repos\C#\Assingment 15\Quiz\Quiz\bin\Debug\net6.0\QuizAnswer.txt";
        private  List<string> _Answers = new List<string>();

        public void FillQuestion(List<FillingQuizFunctionality> FillingQuizes)
        {
            using (StreamWriter sw = new StreamWriter(_FilePath, true))
            {

                foreach (var FillingQuiz in FillingQuizes)
                {
                    string text = "";
                    Console.WriteLine(FillingQuiz._Question);
                    sw.WriteLine(FillingQuiz._Question);
                    for (int i = 0; i < FillingQuiz._ProbableAnswers.Count; i++)
                    {
                        text += i + 1 + ") " + FillingQuiz._ProbableAnswers[i].ToString() + "  ";
                    }
                    FilAnswerAndPoint(FillingQuiz._CorrectAnswer, FillingQuiz._QuestionPoint);
                    sw.WriteLine(text);
                    Console.WriteLine(text);
                }
                sw.Close();
            }


        }

        private void FilAnswerAndPoint(string Answer, int _QuestionPoint)
        {
            using (StreamWriter sw = new StreamWriter(_AnswerPath, true))
            {
                var answer = Answer + " " + _QuestionPoint;

                sw.WriteLine(answer);
                sw.Close();
            }
        }

        public void ClearFile()
        {
            File.WriteAllText(_FilePath, string.Empty);
            File.WriteAllText(_AnswerPath, string.Empty);
        }
        public int FillQuiz()
        {
            GetAnswer();
            using (StreamReader sw = new StreamReader(_FilePath))
            {
                List<string> answer = new List<string>();
                string FileRead = string.Empty;
                int Count = 1;
                int @Point = 0;
                while ((FileRead = sw.ReadLine()) != null)
                {
                    Console.WriteLine($"{Count++}) {FileRead}");
                    Console.WriteLine(sw.ReadLine());
                    answer.Add(Console.ReadLine());
                    if (_Answers[Count - 2].Split()[0] == answer[Count - 2])
                    {
                        @Point += int.Parse(_Answers[Count - 2].Split()[1]);
                    }
                }

                return @Point;
            }
        }

        private void GetAnswer()
        {
            string FileRead = string.Empty;
            using (StreamReader sw = new StreamReader(_AnswerPath))
            {
                while ((FileRead = sw.ReadLine()) != null)
                {
                   _Answers.Add(FileRead);
                }
            }
        }
    }
}
