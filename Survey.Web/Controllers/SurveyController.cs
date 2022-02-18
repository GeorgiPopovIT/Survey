using Microsoft.AspNetCore.Mvc;

namespace Survey.Web.Controllers
{
    public class SurveyController : Controller
    {

        public SurveyController()
        {

        }

        public IActionResult CreateSurvey()
        {
            return null;
        }

        [HttpPost]
        public IActionResult CreateSurvey(int a = 5)
        {
            return null;
        }
    }
}
