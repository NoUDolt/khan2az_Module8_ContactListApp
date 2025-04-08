using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using khan2az_Module8_ContactListApp.Models;

namespace khan2az_Module8_ContactListApp.ViewModels
{
    [QueryProperty(nameof(SelectedContact), "SelectedContact")]
    public partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty] private ContactPerson? selectedContact;
        [ObservableProperty] private bool isEditing;

        [RelayCommand]
        private void EnableEdit() => IsEditing = true;

        [RelayCommand]
        private async Task SaveChanges()
        {
            IsEditing = false;
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}