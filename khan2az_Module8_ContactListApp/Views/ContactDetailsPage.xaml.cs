using Microsoft.Maui.Controls;

namespace khan2az_Module8_ContactListApp.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage()
        {
            InitializeComponent();
            BindingContext = App.SharedViewModel;
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..", true);
        }
    }
}

