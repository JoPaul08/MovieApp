using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public String Index()
    {
        return "This is my default action...."; 
    }
    public String Welcome()
    {

        return "This is the Welcome action method...";
    }
}