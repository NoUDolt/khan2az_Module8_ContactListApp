using Microsoft.Maui;
using khan2az_Module8_ContactListApp.ViewModels;

namespace khan2az_Module8_ContactListApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        public static ContactViewModel SharedViewModel { get; } = new ContactViewModel();
    }
}