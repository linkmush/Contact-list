using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class Contacts : IContacts
{

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public ContactInformation ContactInformation { get; set; } = new ContactInformation();
    public ContactAddress ContactAddress { get; set; } = new ContactAddress();

}
