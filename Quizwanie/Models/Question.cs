using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System;

namespace Quizwanie.Models
{
    public class Question
    {
        [Required(AllowEmptyStrings = true)]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Content { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string CorrectAnswer { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string WrongAnswer1 { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string WrongAnswer2 { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string WrongAnswer3 { get; set; }
    }

    public class QuestionDBContext: DbContext {
        public QuestionDBContext() : base("QuestionDBContext")
        {
        }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public List<Question> Get5RandomQuestions()
        {
            Random random = new Random();
            return Questions.ToList().OrderBy(x => random.Next()).Take(5).ToList();
        }
    }
}