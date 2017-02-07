using Nancy;
using JobOpenings.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_openings.cshtml"];
      Get["/all_openings"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["/all_openings.cshtml",allJobs];
      };
      Post["/openings_added"] = _ => {
        Job newJob = new Job (Request.Form["title"], Request.Form["description"], Request.Form["email"], Request.Form["contact"]);
        newJob.SaveJob();
        return View["openings_added.cshtml", newJob];
      };
      Post["/no_jobs"] = _ => {
        Job.ClearAll();
        return View["no_jobs.cshtml"];
      };
    }
  }
}
