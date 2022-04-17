using Microsoft.AspNetCore.Mvc;

namespace LightLib.Web.Controllers
{
    public class HelloWorldController : Controller
    {


        public string Index()
        {
            return "This is my <b>default</b> action...";

        }

        public string Welcome()
        {

            return "This is welcome action method...";
        }

    }
}
