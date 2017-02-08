namespace JobOpenings.Objects
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phoneNumber;
    private string _address;

    public Contact(string name, string email, string phoneNumber, string address)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
      _address = address;
    }

    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string inputEmail)
    {
      _email = inputEmail;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string inputName)
    {
      _name = inputName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string inputPhoneNumber)
    {
      _phoneNumber = inputPhoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string inputAddress)
    {
      _address = inputAddress;
    }
  }
}
