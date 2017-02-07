using System;
using System.Collections.Generic;

namespace JobOpenings.Objects
{
  public class Job
  {
    private string _title;
    private string _description;
    private string _email;
    private string _contact;

    public Job(string title, string description, string email, string contact)
    {
      _title = title;
      _description = description;
      _email = email;
      _contact = contact;
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
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string inputEmail)
    {
      _email = inputEmail;
    }
    public string GetContact()
    {
      return _contact;
    }
    public void SetContact(string inputContact)
    {
      _contact = inputContact;
    }
  }
}
