using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using khan2az_Module8_ContactListApp.Models;
using System.Collections.ObjectModel;

namespace khan2az_Module8_ContactListApp.ViewModels
{
    public partial class ContactViewModel : ObservableObject
    {
        [ObservableProperty] private ContactPerson selectedContact = new();

        [ObservableProperty] private bool isEditing;

        public ObservableCollection<ContactPerson> Contacts { get; } = new();
        public IAsyncRelayCommand SaveContactAsyncCommand { get; }

        public ContactViewModel()
        {
            SelectedContact = new ContactPerson();
            SaveContactAsyncCommand = new AsyncRelayCommand(SaveContactAsync);
        }

        [RelayCommand]
        private async Task SaveContactAsync()
        {
            var contact = new ContactPerson
            {
                Name = SelectedContact.Name,
                Email = SelectedContact.Email,
                PhoneNumber = SelectedContact.PhoneNumber,
                Description = SelectedContact.Description
            };

            Contacts.Add(contact);
            SelectedContact = new ContactPerson();
            await Shell.Current.GoToAsync("//ContactsPage");
        }

        [RelayCommand] private async Task GoToAddContactPage() => await Shell.Current.GoToAsync("//MainPage");

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
                    Name = SelectedContact.Name,
                    Email = SelectedContact.Email,
                    PhoneNumber = SelectedContact.PhoneNumber,
                    Description = SelectedContact.Description
                };
            }

            isEditing = false;
        }

        [RelayCommand]
        private void EditContact()
        {
            IsEditing = true;
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }

    public static class AppState
    {
        public static ContactViewModel ViewModel { get; } = new();
    }
}