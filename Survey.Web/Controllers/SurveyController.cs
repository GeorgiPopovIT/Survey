using Microsoft.AspNetCore.Mvc;
using Survey.Web.ViewModels.Survey;

namespace Survey.Web.Controllers
{
    public class SurveyController : Controller
    {

        public SurveyController()
        {

        }

        public IActionResult CreateSurvey()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSurvey(SurveyInputModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            return null;
        }
    }
}
