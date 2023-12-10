namespace ClassLibrary.Shared.Interfaces;

// CRUD - Create Read Update Delete

public interface IContactService
{
    IServiceResult AddContactToList(IContacts contacts);
    IServiceResult DeleteContactFromList();
    IServiceResult GetContactsFromList();
    IServiceResult GetContactFromList(string email);
    IServiceResult UpdateContactInList();

}

// LAMBDA expression (Contacts) => contacts.FirstName == "oskar" 