using ContactMaui.ViewModels;

namespace ContactMaui.Views;

public partial class ContactInfoPage : ContentPage
{
	public ContactInfoPage(ContactInfoViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}