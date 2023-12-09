using ConsoleApp.Models;

namespace ConsoleApp.Interfaces;

public interface IContacts
{
    IContactAddress ContactAddress { get; set; }
    IContactInformation ContactInformation { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}