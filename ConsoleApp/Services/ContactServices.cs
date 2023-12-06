using ConsoleApp.Models;

namespace ConsoleApp.Services;

public class ContactServices
{
    private readonly List<Contacts> _contacts = [];

    public void AddContactToList(Contacts contact)
    {
        if (!_contacts.Any(x => x.ContactInformation.Email == contact.ContactInformation.Email))
            _contacts.Add(contact);
    }

    public Contacts GetUserFromList(string email)
    {
        var user = _contacts.FirstOrDefault(x => x.ContactInformation.Email == email);
        return user ??= null!;
    }

    public List<Contacts> GetUsersFromList()
    {
        return _contacts;
    }
}
