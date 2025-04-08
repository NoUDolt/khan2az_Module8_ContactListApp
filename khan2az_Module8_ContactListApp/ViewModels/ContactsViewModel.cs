using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using khan2az_Module8_ContactListApp.Models;
using System.Collections.ObjectModel;

namespace khan2az_Module8_ContactListApp.ViewModels;

public partial class ContactsViewModel : ObservableObject
{
    public ObservableCollection<ContactPerson> Contacts { get; }

    public ContactsViewModel(ObservableCollection<ContactPerson> contacts)
    {
        Contacts = contacts;
    }

    [RelayCommand]
    async Task ViewDetails(ContactPerson contact)
    {
        var navigationParameter = new Dictionary<string, object>
    {
        { "SelectedContact", contact }
    };

        await Shell.Current.GoToAsync(nameof(Views.ContactDetailsPage), navigationParameter);
    }

    [RelayCommand]
    async Task AddNewContact()
    {
        await Shell.Current.GoToAsync(nameof(Views.MainPage));
    }
}