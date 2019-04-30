using System.Collections.Generic;
namespace MadLibs.Models
{
  public class Words
  {
    private Dictionary<string, string> _wordList = new Dictionary<string, string>();

    public string GetWord(string key)
    {
      if (_wordList.ContainsKey(key))
      {
        return _wordList[key];
      }
      else
      {
        return "0";
      }
    }

    public void AddWord(string key, string word)
    {
      _wordList.Add(key, word);
    }

  }
}
