using Nancy;
using System;
using System.Collections.Generic;
using AnagramList.Objects;
namespace AnagramList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/result"] = _ => {
        Anagram myAnagram=new Anagram(Request.Query["new-ourWord"],Request.Query["new-userWord"]);
        return View["result.cshtml",myAnagram];
      };

    }
  }
}
