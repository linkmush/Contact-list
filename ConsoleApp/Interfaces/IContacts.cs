using ConsoleApp.Models;

namespace ConsoleApp.Interfaces;

public interface IContacts
{
    ContactAddress ContactAddress { get; set; }
    ContactInformation ContactInformation { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}