using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/input")]
    public ActionResult ScarsInput() { return View(); }

    [Route("/scars")]
    public ActionResult ScarsOutput(string thing, string occupation, string verb, string question, string adjective)
    {
      Words myWords = new Words();
      myWords.AddWord("thing", thing);
      myWords.AddWord("occupation", occupation);
      myWords.AddWord("verb", verb);
      myWords.AddWord("question", question);
      myWords.AddWord("adjective", adjective);

      return View(myWords);
    }

  }
}
