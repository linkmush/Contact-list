using ConsoleApp.Models;
using ConsoleApp.Models.Responses;

namespace ConsoleApp.Interfaces;

// CRUD - Create Read Update Delete

public interface IContactService
{
    IServiceResult AddContactToList(IContacts contacts);
    IServiceResult DeleteContactFromList();
    IServiceResult GetContactsFromList();
    IServiceResult GetContactFromList();
    IServiceResult UpdateContactInList();
}

// LAMBDA expression (Contacts) => contacts.FirstName == "oskar" 