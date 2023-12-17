using ContactMaui.ViewModels;

namespace ContactMaui.Views;

public partial class ContactAddPage : ContentPage
{
	public ContactAddPage(ContactAddViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}