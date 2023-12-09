using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class Contacts : IContacts
{

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public IContactInformation ContactInformation { get; set; } = new ContactInformation();
    public IContactAddress ContactAddress { get; set; } = new ContactAddress();

}
