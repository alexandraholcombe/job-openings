using System;
using System.Collections.Generic;

namespace JobOpenings.Objects
{

  public class Job
  {
    private string _title;
    private string _description;
    private Contact _contact;

    private static List<Job> _instances = new List<Job>{};

    public Job(string title, string description, Contact contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
    }

    public static List<Job> GetAll(){
      return _instances;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string inputTitle)
    {
      _title = inputTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string inputDescription)
    {
      _description = inputDescription;
    }
    public Contact GetContact()
    {
      return _contact;
    }
    public void SetContact(Contact inputContact)
    {
      _contact = inputContact;
    }

    public void SaveJob()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
