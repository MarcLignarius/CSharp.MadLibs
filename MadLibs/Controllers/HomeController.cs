using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/input")]
    public ActionResult Input() { return View(); }

    [Route("/output")]
    public ActionResult Output(string recipient, string sender)
    {
      Words myWords = new Words();
      myWords.SetRecipient(recipient);
      myWords.SetSender(sender);
      return View(myWords);
    }

  }
}
