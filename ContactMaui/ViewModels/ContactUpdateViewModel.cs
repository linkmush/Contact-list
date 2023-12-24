using Interfaces = ClassLibrary.Shared.Interfaces;
using Models = ClassLibrary.Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContactMaui.ViewModels;

public partial class ContactUpdateViewModel : ObservableObject, IQueryAttributable
{
    private readonly Interfaces.IContactService _contactService;

    public ContactUpdateViewModel(Interfaces.IContactService contactServices)
    {
        _contactService = contactServices;
    }

    [ObservableProperty]
    private Interfaces.IContacts? _updateContactForm = new Models.Contacts();

    [RelayCommand]
    private async Task UpdateContact()
    {
        _contactService.UpdateContactInList(UpdateContactForm!);
        UpdateContactForm = new Models.Contacts();

        await Shell.Current.GoToAsync("..");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        UpdateContactForm = (query["Contact"] as Interfaces.IContacts);
    }
}
