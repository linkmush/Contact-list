namespace ConsoleApp.Models;

public class Contacts
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;

    public ContactInformation ContactInformation { get; set; } = null!;
    public ContactAddress ContactAddress { get; set; } = null!;

}
