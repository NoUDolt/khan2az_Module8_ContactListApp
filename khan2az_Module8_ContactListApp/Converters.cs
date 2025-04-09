using System;
using System.Globalization;
using khan2az_Module8_ContactListApp.ViewModels;

namespace khan2az_Module8_ContactListApp.Converters
{
    public class InverseBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => !(bool)value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => !(bool)value;
    }
}