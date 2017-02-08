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
        Contact newContact = new Contact (Request.Form["name"], Request.Form["email"], Request.Form["phone-number"], Request.Form["address"]);
        Job newJob = new Job (Request.Form["title"], Request.Form["description"], newContact);
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
