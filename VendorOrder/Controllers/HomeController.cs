using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }  
}