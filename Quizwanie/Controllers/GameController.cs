using Quizwanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quizwanie.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private QuestionDBContext questionContext = new QuestionDBContext();
        private static int correctAnswers = 0;
        private static ShuffledQuestion currentQuestion;
        private static List<ShuffledQuestion> shuffledQuestions = new List<ShuffledQuestion>();

        // GET: Game
        [HttpGet]
        public ActionResult Index()
        {
            var randomQuestions = questionContext.Get5RandomQuestions();
            correctAnswers = 0;

            randomQuestions.ForEach(rQuestion =>
            {
                shuffledQuestions.Add(new ShuffledQuestion(rQuestion));
            });

            setNextQuestion();
            
            return View(currentQuestion);
        }

        // POST: Game
        [HttpPost]
        public ActionResult Index(string answer)
        {
            if (currentQuestion.Answers.IndexOf(answer) == currentQuestion.CorrectAnswerIndex)
            {
                correctAnswers++;
            }
            shuffledQuestions.Remove(currentQuestion);

            setNextQuestion();

            return View(currentQuestion);
        }

        private void setNextQuestion()
        {
            if (shuffledQuestions.Any())
            {
                currentQuestion = shuffledQuestions.First();
            }
            else
            {
                currentQuestion = new ShuffledQuestion(correctAnswers);
            }
        }
    }
}