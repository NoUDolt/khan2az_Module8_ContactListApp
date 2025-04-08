using khan2az_Module8_ContactListApp.Models;
using khan2az_Module8_ContactListApp.ViewModels;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

namespace khan2az_Module8_ContactListApp.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        BindingContext = new ContactsViewModel(AppState.Contacts);
    }
}

public static class AppState
{
    public static ObservableCollection<ContactPerson> Contacts { get; } = new();
}
