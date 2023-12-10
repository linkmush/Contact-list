using ClassLibrary.Shared.Interfaces;

namespace ClassLibrary.Shared.Models;

public class ContactInformation : IContactInformation
{
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
}
