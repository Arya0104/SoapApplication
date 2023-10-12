using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // getting our HelloWorld

        public string Index()
        {
            return "This is my default action...";
        }

       // getting Welcome

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}