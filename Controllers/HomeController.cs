using Microsoft.AspNetCore.Mvc;


namespace Layout.Controllers
{
  public class HomeController : Controller
  {

    [Route("/index")]
    public ActionResult index()
    {
      return View();
    }
  }
}
