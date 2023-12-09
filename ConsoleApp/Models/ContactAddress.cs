using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class ContactAddress : IContactAddress
{
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
