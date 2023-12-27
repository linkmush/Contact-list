using Interfaces = ClassLibrary.Shared.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ClassLibrary.Shared.Models.Responses;

namespace ContactMaui.ViewModels;

public partial class ContactListViewModel : ObservableObject
{
    private readonly Interfaces.IContactService _contactService;

    public ContactListViewModel(Interfaces.IContactService contactServices)
    {
        _contactService = contactServices;
        UpdateContactList();

        _contactService.ContactsUpdated += (sender, e) =>
        {
            UpdateContactList();
        };
    }

    private void UpdateContactList()
    {
        var contactsResult = (ServiceResult)_contactService.GetContactsFromList();

        if (contactsResult.Result is List<Interfaces.IContacts> contactsList)
        {
            ContactList = new ObservableCollection<Interfaces.IContacts>(contactsList);
        }
        else
        {
            ContactList = [];
        }

        //ContactList = new ObservableCollection<Interfaces.IContacts>((IEnumerable<Interfaces.IContacts>)_contactService.GetContactsFromList());
    }

    [ObservableProperty]
    private ObservableCollection<Interfaces.IContacts> contactList = [];

    [RelayCommand]
    private async Task NavigateToAddContact(Interfaces.IContacts contacts)
    {
        await Shell.Current.GoToAsync("ContactAddPage");
    }

    [RelayCommand]
    private async Task NavigateToContactInfo(Interfaces.IContacts contacts)
    {
        await Shell.Current.GoToAsync("ContactInfoPage");
    }

    [RelayCommand]
    private async Task NavigateToContactUpdate(Interfaces.IContacts contacts)
    {
        var parameters = new ShellNavigationQueryParameters
        {
            { "Contact", contacts }
        };

        await Shell.Current.GoToAsync("ContactUpdatePage", parameters);
    }

    [RelayCommand]
    private void DeleteContactFromList(Interfaces.IContacts contact)
    {
        _contactService.DeleteContactFromList(contact.ContactInformation.Email);
    }
}
