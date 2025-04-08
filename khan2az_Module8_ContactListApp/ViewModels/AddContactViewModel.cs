using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using khan2az_Module8_ContactListApp.Models;
using khan2az_Module8_ContactListApp.Views;
using System.Collections.ObjectModel;

namespace khan2az_Module8_ContactListApp.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [ObservableProperty]
        private string phoneNumber = string.Empty;

        [ObservableProperty]
        private string description = string.Empty;

        public ObservableCollection<ContactPerson> Contacts { get; }

        public AddContactViewModel(ObservableCollection<ContactPerson> contacts)
        {
            Contacts = contacts;
        }

        [RelayCommand]
        private async Task Save()
        {
            var newContact = new ContactPerson
            {
                Name = this.Name,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                Description = this.Description
            };

            Contacts.Add(newContact);
            await Shell.Current.GoToAsync(nameof(khan2az_Module8_ContactListApp.Views.ContactsPage));
        }
    }
}


