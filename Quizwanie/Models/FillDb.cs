using System.Collections.Generic;

namespace Quizwanie.Models
{
    public class FillDb : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuestionDBContext>
    {
        protected override void Seed(QuestionDBContext context)
        {
            var questions = new List<Question> {
                new Question
                {
                    Content = "Z jakiego kraju pochodzi firma Lenovo?",
                    CorrectAnswer = "Chiny",
                    WrongAnswer1 = "Korea Południowa",
                    WrongAnswer2 = "USA",
                    WrongAnswer3 = "Japonia"
                },

                new Question
                {
                    Content = "Zjawisko piezoelektryczności zostało odkryte przez:",
                    CorrectAnswer = "Braci Curie",
                    WrongAnswer1 = "Woldemar Voigt",
                    WrongAnswer2 = "Andre Ampere",
                    WrongAnswer3 = "Allesandro Volt"
                },

                new Question
                {
                    Content = "W którym roku uruchomiono wyszukiwarkę Google?",
                    CorrectAnswer = "1998",
                    WrongAnswer1 = "1995",
                    WrongAnswer2 = "2000",
                    WrongAnswer3 = "2001"
                },

                new Question
                {
                    Content = "Który producent telewizorów pochodzi z Niemiec?",
                    CorrectAnswer = "Grundig",
                    WrongAnswer1 = "Panasonic",
                    WrongAnswer2 = "Samsung",
                    WrongAnswer3 = "Philips"
                },

                new Question
                {
                    Content = "Jaki kolor ma zazwyczaj czarna skrzynka w samolocie?",
                    CorrectAnswer = "Pomarańczowy",
                    WrongAnswer1 = "Czarny",
                    WrongAnswer2 = "Biały",
                    WrongAnswer3 = "Różowy"
                },

                new Question
                {
                    Content = "Jak nazywani są chińscy astronauci?",
                    CorrectAnswer = "Tajkonauci",
                    WrongAnswer1 = "Kosmonauci",
                    WrongAnswer2 = "Omninauci",
                    WrongAnswer3 = "Astronauci"
                },

                new Question
                {
                    Content = "Jaki kolor ma ametyst?",
                    CorrectAnswer = "Fioletowy",
                    WrongAnswer1 = "Zielony",
                    WrongAnswer2 = "Czerwony",
                    WrongAnswer3 = "Pomarańczowy"
                },

                new Question
                {
                    Content = "EEG to badanie",
                    CorrectAnswer = "Pracy mózgu",
                    WrongAnswer1 = "Pracy serca",
                    WrongAnswer2 = "Endoskopia guzów",
                    WrongAnswer3 = "Endoskopia głowy"
                },

                new Question
                {
                    Content = "Co mają wspólnego Jowisz, Saturn, Uran i Neptun?",
                    CorrectAnswer = "To gazowe giganty",
                    WrongAnswer1 = "Znaleziono tam ślady życia",
                    WrongAnswer2 = "Są większe niż Słońce",
                    WrongAnswer3 = "Są najbliżej Słońca"
                },

                new Question
                {
                    Content = "Planetą gazową nie jest",
                    CorrectAnswer = "Merkury",
                    WrongAnswer1 = "Saturn",
                    WrongAnswer2 = "Uran",
                    WrongAnswer3 = "Jowisz"
                }
            };

            questions.ForEach(s => context.Questions.Add(s));
            context.SaveChanges();
        }
    }
}