using PropertyChanged;
using Microsoft.Maui.Controls;

namespace TCI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class TCI
    {
        public float Temp { get; set; }

        [DependsOn(nameof(Temp))]
        public Brush Grav
        {
            get
            {
                if (Temp < 35)
                    return new SolidColorBrush(Color.FromArgb("#2196F3")); // Azul
                else if (Temp >= 35 && Temp <= 37.5)
                    return new SolidColorBrush(Color.FromArgb("#4CAF50")); // Verde
                else if (Temp > 37.5 && Temp <= 39)
                    return new SolidColorBrush(Color.FromArgb("#FF9800")); // Naranja
                else if (Temp > 39)
                    return new SolidColorBrush(Color.FromArgb("#F44336")); // Rojo
                else
                    return new SolidColorBrush(Color.FromArgb("#9E9E9E")); // Gris
            }
        }

        [DependsOn(nameof(Temp))]
        public Brush InactiveColor
        {
            get
            {
                if (Temp < 35)
                    return new SolidColorBrush(Color.FromArgb("#90CAF9")); // Azul claro
                else if (Temp >= 35 && Temp <= 37.5)
                    return new SolidColorBrush(Color.FromArgb("#A5D6A7")); // Verde claro
                else if (Temp > 37.5 && Temp <= 39)
                    return new SolidColorBrush(Color.FromArgb("#FFCC80")); // Naranja claro
                else if (Temp > 39)
                    return new SolidColorBrush(Color.FromArgb("#EF9A9A")); // Rojo claro
                else
                    return new SolidColorBrush(Color.FromArgb("#E0E0E0")); // Gris claro
            }
        }
    }
}
