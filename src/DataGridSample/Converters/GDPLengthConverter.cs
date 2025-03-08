using System;
using System.Globalization;
using Avalonia.Controls;
using Avalonia.Data.Converters;

namespace DataGridSample.Converters;

internal class GDPLengthConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is double d)
        {
            return new DataGridLength(d, DataGridLengthUnitType.Pixel, d, d);
        }
        else if (value is decimal d2)
        {
            var dv = System.Convert.ToDouble(d2);
            return new DataGridLength(dv, DataGridLengthUnitType.Pixel, dv, dv);
        }
        return value;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is DataGridLength width)
        {
            return System.Convert.ToDecimal(width.DisplayValue);
        }
        return value;
    }
}
