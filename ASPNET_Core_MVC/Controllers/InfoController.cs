using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASPNET_Core_MVC.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Info()
        {
            return "versão 1.0.0";
        }
        public string NewVersion(string version)
        {
            return HtmlEncoder.Default.Encode($"The new version is {version}");
        }
    }
}
