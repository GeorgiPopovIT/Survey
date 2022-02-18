using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Survey.Web.Data
{
    public class SurveyDbContext : IdentityDbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Survey> Surveys { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }


    }
}
