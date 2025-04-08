using khan2az_Module8_ContactListApp.Views;

namespace khan2az_Module8_ContactListApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("MainPage", typeof(Views.MainPage));
            Routing.RegisterRoute("ContactsPage", typeof(Views.ContactsPage));
            Routing.RegisterRoute("ContactDetailsPage", typeof(Views.ContactDetailsPage));
        }
    }
}