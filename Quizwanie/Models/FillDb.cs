using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quizwanie.Models
{
    public class FillDb
    {
        public FillDb()
        {
            using (var db = new QuestionDBContext())
            {
                Question q1 = new Question
                {
                    Content = "Z jakiego kraju pochodzi firma Lenovo?",
                    CorrectAnswer = "Chiny",
                    WrongAnswer1 = "Korea Południowa",
                    WrongAnswer2 = "USA",
                    WrongAnswer3 = "Japonia"
                };

                Question q2 = new Question
                {
                    Content = "Zjawisko piezoelektryczności zostało odkryte przez:",
                    CorrectAnswer = "Braci Curie",
                    WrongAnswer1 = "Woldemar Voigt",
                    WrongAnswer2 = "Andre Ampere",
                    WrongAnswer3 = "Allesandro Volt"
                };

                Question q3 = new Question
                {
                    Content = "W którym roku uruchomiono wyszukiwarkę Google?",
                    CorrectAnswer = "1998",
                    WrongAnswer1 = "1995",
                    WrongAnswer2 = "2000",
                    WrongAnswer3 = "2001"
                };

                Question q4 = new Question
                {
                    Content = "Który producent telewizorów pochodzi z Niemiec?",
                    CorrectAnswer = "Panasonic",
                    WrongAnswer1 = "Grundig",
                    WrongAnswer2 = "Samsung",
                    WrongAnswer3 = "Philips"
                };

                Question q5 = new Question
                {
                    Content = "Jaki kolor ma zazwyczaj czarna skrzynka w samolocie?",
                    CorrectAnswer = "Pomarańczowy",
                    WrongAnswer1 = "Czarny",
                    WrongAnswer2 = "Biały",
                    WrongAnswer3 = "Różowy"
                };

                Question q6 = new Question
                {
                    Content = "Jak nazywani są chińscy astronauci?",
                    CorrectAnswer = "Tajkonauci",
                    WrongAnswer1 = "Kosmonauci",
                    WrongAnswer2 = "Omninauci",
                    WrongAnswer3 = "Astronauci"
                };

                Question q7 = new Question
                {
                    Content = "Jaki kolor ma ametyst?",
                    CorrectAnswer = "Fioletowy",
                    WrongAnswer1 = "Zielony",
                    WrongAnswer2 = "Czerwony",
                    WrongAnswer3 = "Pomarańczowy"
                };

                Question q8 = new Question
                {
                    Content = "EEG to badanie",
                    CorrectAnswer = "Pracy mózgu",
                    WrongAnswer1 = "Pracy serca",
                    WrongAnswer2 = "Endoskopia guzów",
                    WrongAnswer3 = "Endoskopia głowy"
                };

                Question q9 = new Question
                {
                    Content = "Co mają wspólnego Jowisz, Saturn, Uran i Neptun?",
                    CorrectAnswer = "To gazowe giganty",
                    WrongAnswer1 = "Znaleziono tam ślady życia",
                    WrongAnswer2 = "Są większe niż Słońce",
                    WrongAnswer3 = "Są najbliżej Słońca"
                };

                Question q10 = new Question
                {
                    Content = "Planetą gazową nie jest",
                    CorrectAnswer = "Merkury",
                    WrongAnswer1 = "Saturn",
                    WrongAnswer2 = "Uran",
                    WrongAnswer3 = "Jowisz"
                };

                var questions = db.Set<Question>();
                questions.Add(q1);
                questions.Add(q2);
                questions.Add(q3);
                questions.Add(q4);
                questions.Add(q5);
                questions.Add(q6);
                questions.Add(q7);
                questions.Add(q8);
                questions.Add(q9);
                questions.Add(q10);

                db.SaveChanges();
            }
        }
    }
}