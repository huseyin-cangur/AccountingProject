

using AccountingProject.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace AccountingProject.Presentation.Controller
{
    public class TestController : ApiContoller
    {
        [HttpGet]
        public IActionResult Get()

        {
            return Ok("Başarılı...");
        }

    }
}