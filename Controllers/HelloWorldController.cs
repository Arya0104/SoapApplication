using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // getting our HelloWorld

        public IActionResult Index()
        {
            return View();
        }

        // getting Welcome

        //getting the numeric values
        public string Welcome(string name, int ID)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}