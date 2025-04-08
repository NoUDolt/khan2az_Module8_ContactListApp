using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using khan2az_Module8_ContactListApp.Models;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace khan2az_Module8_ContactListApp.ViewModels
{
public partial class ContactViewModel : ObservableObject
{
    [ObservableProperty]
    private string name = "";

    [ObservableProperty]
    private string email = "";

    [ObservableProperty]
    private string phoneNumber = "";

    [ObservableProperty]
    private string description = "";

    [ObservableProperty]
    private ContactPerson selectedContact;

    public ObservableCollection<ContactPerson> Contacts { get; } = new();

    [RelayCommand]
    private async Task SaveContactAsync()
    {
        var contact = new ContactPerson
        {
            Name = Name,
            Email = Email,
            PhoneNumber = PhoneNumber,
            Description = Description
        };

        Contacts.Add(contact);
        ClearForm();
        await Shell.Current.GoToAsync("//ContactsPage");
    }

    [RelayCommand]
    private async Task GoToAddContactPage() => await Shell.Current.GoToAsync("//MainPage");

    [RelayCommand]
    private async Task ShowContactDetails(ContactPerson contact)
    {
        SelectedContact = contact;
        await Shell.Current.GoToAsync("ContactDetailsPage");
    }

    [RelayCommand]
    private void UpdateContact()
    {
        var index = Contacts.IndexOf(SelectedContact);
        if (index >= 0)
        {
            Contacts[index] = new ContactPerson
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };
        }
    }

    private void ClearForm()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Description = string.Empty;
    }
}
}