using Interfaces = ClassLibrary.Shared.Interfaces;
using Models = ClassLibrary.Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContactMaui.ViewModels;

public partial class ContactInfoViewModel : ObservableObject, IQueryAttributable
{
    private readonly Interfaces.IContactService _contactService;

    public ContactInfoViewModel(Interfaces.IContactService contactServices)
    {
        _contactService = contactServices;
    }

    [ObservableProperty]
    private Interfaces.IContacts? _contactInfo = new Models.Contacts();

    [RelayCommand]
    private void GetContactFromList(string email)
    {
        _contactService.GetContactFromList(email);
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        ContactInfo = (query["ContactInfo"] as Interfaces.IContacts);
    }
}
