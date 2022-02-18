using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Survey.Web.Data
{
    public class Survey
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public IEnumerable<Question> Questions { get; set; } = new HashSet<Question>();
    }
}
