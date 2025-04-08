using khan2az_Module8_ContactListApp.Models;
using khan2az_Module8_ContactListApp.ViewModels;
using System.Collections.ObjectModel;

namespace khan2az_Module8_ContactListApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage(ObservableCollection<ContactPerson> contacts)
    {
        InitializeComponent();
        BindingContext = new AddContactViewModel(contacts);
    }
}