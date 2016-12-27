using Microsoft.AspNet.Mvc;

namespace DBLearningNG2_AspNetCore.Controllers
{
  public class PartialController : Controller
  {
    public IActionResult Message() => PartialView();

    public IActionResult Numbers() => PartialView();
  }
}