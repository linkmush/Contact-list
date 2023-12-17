using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContactMaui.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    public async Task NavigateToContactAdd()
    {
        await Shell.Current.GoToAsync("ContactAddPage");
    }

    [RelayCommand]
    public async Task NavigateToContactList()
    {
        await Shell.Current.GoToAsync("ContactListPage");
    }

    [RelayCommand]
    public async Task NavigateToContactInfo()
    {
        await Shell.Current.GoToAsync("ContactInfoPage");
    }

    [RelayCommand]
    public async Task NavigateToContactDelete()
    {
        await Shell.Current.GoToAsync("ContactDeletePage");
    }

    [RelayCommand]
    public async Task NavigateToContactUpdate()
    {
        await Shell.Current.GoToAsync("ContactUpdatePage");
    }
}
