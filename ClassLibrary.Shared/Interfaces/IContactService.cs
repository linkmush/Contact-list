namespace ClassLibrary.Shared.Interfaces;

// CRUD - Create Read Update Delete

public interface IContactService
{
    /// <summary>
    /// Add a contact to the contact list.
    /// </summary>
    /// <param name="contacts">A contact of type IContact</param>
    /// <returns>Return true if successful, or false if it fails or customer already exists.</returns>
    IServiceResult AddContactToList(IContacts contacts);
    /// <summary>
    /// Removes a contact from the contact list by email.
    /// </summary>
    /// <param name="email">Enter the email as a string.</param>
    /// <returns>Return true if the contact was successfully removed, or false if otherwise.</returns>
    IServiceResult DeleteContactFromList(string email);
    /// <summary>
    /// Get a specific contact from contact list by email.
    /// </summary>
    /// <returns>Return contact if exists, if contact does not exists return null.</returns>
    IServiceResult GetContactsFromList();
    /// <summary>
    /// Gets all contacts from contact list.
    /// </summary>
    /// <returns>Return contacts if list has contacts in it, if no contacts exists return null.</returns>
    IServiceResult GetContactFromList(string email);

    IServiceResult UpdateContactInList(IContacts contactUpdated);

    event EventHandler ContactsUpdated;

}

// LAMBDA expression (Contacts) => contacts.FirstName == "oskar" 