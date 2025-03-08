using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace DataGridSample.Converters
{
    public class GDPValueConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int gdp)
            {
                if (gdp <= 5000)
                    return new SolidColorBrush(Colors.Orange, 0.6);
                else if (gdp <= 10000)
                    return new SolidColorBrush(Colors.Yellow, 0.6);
                else
                    return new SolidColorBrush(Colors.LightGreen, 0.6);
            }

            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
