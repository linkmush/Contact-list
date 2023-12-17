using ContactMaui.Views;

namespace ContactMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactAddPage), typeof(ContactAddPage));
            Routing.RegisterRoute(nameof(ContactListPage), typeof(ContactListPage));
            Routing.RegisterRoute(nameof(ContactInfoPage), typeof(ContactInfoPage));
            Routing.RegisterRoute(nameof(ContactDeletePage), typeof(ContactDeletePage));
            Routing.RegisterRoute(nameof(ContactUpdatePage), typeof(ContactUpdatePage));
        }
    }
}
