using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace timeDisplay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index(){
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;
            return View();
        }   
    }
}