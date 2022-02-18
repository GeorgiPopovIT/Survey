using System.ComponentModel.DataAnnotations;

namespace Survey.Web.ViewModels.Survey
{
    public class SurveyInputModel
    {
        [Required(ErrorMessage ="Cannot be empty.")]
        [MinLength(1,ErrorMessage ="This question is too short.")]
        [StringLength(1000,ErrorMessage ="This question is too long")]
        [Display(Name ="Question")]
        public string QuestionContent { get; init; }

        [Required]
        public string AnswerType { get; init; }
    }
}
