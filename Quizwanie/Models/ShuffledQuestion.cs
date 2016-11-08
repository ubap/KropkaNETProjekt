using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quizwanie.Models
{
    public class ShuffledQuestion
    {
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public string Content { get; set; }

        public bool IsEndOfGame { get; set; }

        public int CorrectAnswers { get; set; }

        public ShuffledQuestion (Question question)
        {
            Answers = new List<string>();

            Answers.Add(question.CorrectAnswer);
            Answers.Add(question.WrongAnswer1);
            Answers.Add(question.WrongAnswer2);
            Answers.Add(question.WrongAnswer3);

            Answers = Answers.OrderBy(answer => Guid.NewGuid()).ToList();

            CorrectAnswerIndex = Answers.IndexOf(question.CorrectAnswer);

            Content = question.Content;
        }

        public ShuffledQuestion (int correctAnswers)
        {
            IsEndOfGame = true;
            CorrectAnswers = correctAnswers;
        }
    }
}