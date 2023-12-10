using ClassLibrary.Shared.Interfaces;

namespace ClassLibrary.Shared.Models;

public class ContactAddress : IContactAddress
{
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
