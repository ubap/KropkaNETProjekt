using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quizwanie.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string WrongAnswer3 { get; set; }
    }

    public class QuestionDBContext: DbContext {
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}