using ContactMaui.ViewModels;

namespace ContactMaui.Views;

public partial class ContactUpdatePage : ContentPage
{
	public ContactUpdatePage(ContactUpdateViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}