using khan2az_Module8_ContactListApp.ViewModels;

namespace khan2az_Module8_ContactListApp.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage()
    {
        InitializeComponent();
        BindingContext = new ContactDetailsViewModel();
    }
}
