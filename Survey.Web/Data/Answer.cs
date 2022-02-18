using System.ComponentModel.DataAnnotations;

namespace Survey.Web.Data
{
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        public string AnswerText { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
