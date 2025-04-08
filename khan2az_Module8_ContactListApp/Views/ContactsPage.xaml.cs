using khan2az_Module8_ContactListApp.Models;
using khan2az_Module8_ContactListApp.ViewModels;

namespace khan2az_Module8_ContactListApp.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel();
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BindingContext is ContactViewModel viewModel && e.CurrentSelection.FirstOrDefault() is ContactPerson selectedContact)
            {
                await viewModel.ShowContactDetailsCommand.ExecuteAsync(selectedContact);
            }
        }
    }
}