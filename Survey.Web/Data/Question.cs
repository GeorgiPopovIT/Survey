using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Survey.Web.Data
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public QuestionType QuestionType { get; set; }

        public IEnumerable<Survey> Surveys { get; set; } = new HashSet<Survey>();

        public IEnumerable<Answer> Answers { get; set; } = new HashSet<Answer>();
    }
}