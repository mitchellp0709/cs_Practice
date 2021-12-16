using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections;

namespace firstdotnet.Controllers
{
  public class FirstController : Controller
  {
    // This route would match /first/first
    public Hashtable First()
    {
      Hashtable myHashtable = new Hashtable();
      myHashtable.Add("cheese", "gouda");
      myHashtable.Add("bread", "rye");
      return myHashtable;
      //return new Hashtable(){"Result", "You Made a Route"};
    }
  }
  public Hashtable Second(string URLParam)
  {
    return new Hashtable() { { "PARAM", URLParam } };
  }
}