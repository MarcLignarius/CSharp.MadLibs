using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/game1input")]
    public ActionResult Game1Input() { return View(); }

    [Route("/game2input")]
    public ActionResult Game2Input() { return View(); }

    [Route("/game1output")]
    public ActionResult Game1Output(string noun1, string noun2, string occupation, string verb, string question, string adjective)
    {
      Words myWords = new Words();
      myWords.AddWord("noun1", noun1);
      myWords.AddWord("noun2", noun2);
      myWords.AddWord("occupation", occupation);
      myWords.AddWord("verb", verb);
      myWords.AddWord("question", question);
      myWords.AddWord("adjective", adjective);

      return View(myWords);
    }

    [Route("/game2output")]
    public ActionResult Game2Output(string noun1, string noun2, string adjective, string noun3, string verb1, string noun4, string verb2, string verb3, string noun5, string name)
    {
      Words myWords = new Words();
      myWords.AddWord("noun1", noun1);
      myWords.AddWord("noun2", noun2);
      myWords.AddWord("adjective", adjective);
      myWords.AddWord("noun3", noun3);
      myWords.AddWord("verb1", verb1);
      myWords.AddWord("noun4", noun4);
      myWords.AddWord("verb2", verb2);
      myWords.AddWord("verb3", verb3);
      myWords.AddWord("noun5", noun5);
      myWords.AddWord("name", name);

      return View(myWords);
    }

  }
}
