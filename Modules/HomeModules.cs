using Nancy;
using JobOpenings.Objects
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_openings.cshtml"];
      Post["/openings_added"] = _ => {
        Job newJob = new Job (Request.Form["title"], Request.Form["description"], Request.Form["email"], Request.Form["contact"]);
        newJob.SaveJob();
        return View["openings_added.cshtml", newJob];
      };
    }
  }
}
