using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace TCI.Converters
{
    public class TempToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is double temp)
            {
                if (temp < 36.5) return Color.FromArgb("#4CAF50"); // verde
                if (temp < 38) return Color.FromArgb("#FFEB3B");   // amarillo
                if (temp < 39) return Color.FromArgb("#FF9800");   // naranja
                return Color.FromArgb("#F44336");                  // rojo
            }
            return Colors.Gray;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
