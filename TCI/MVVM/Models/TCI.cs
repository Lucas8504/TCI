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

        [DependsOn(nameof(Temp))]
        public string Estado
        {
            get
            {
                if (Temp < 35)
                    return "Hipotermia";
                else if (Temp >= 35 && Temp <= 37.5)
                    return "Normal";
                else if (Temp > 37.5 && Temp <= 39)
                    return "Fiebre leve";
                else if (Temp > 39)
                    return "Fiebre alta";
                else
                    return "Desconocido";
            }
        }

        [DependsOn(nameof(Temp))]
        public string TempTexto
        {
            get => $"{Temp:0.0} °C";
        }

        [DependsOn(nameof(Temp))]
        public string Recomendacion
        {
            get
            {
                if (Temp < 35)
                    return "Hipotermia: Abriga bien al paciente, proporciona líquidos calientes y busca atención médica si la temperatura sigue bajando.";
                else if (Temp >= 35 && Temp <= 37.5)
                    return "Temperatura normal: No se requiere tratamiento. Mantener hábitos saludables.";
                else if (Temp > 37.5 && Temp <= 39)
                    return "Fiebre leve: Reposo, hidratación y ropa ligera. Se pueden usar antipiréticos si es necesario.";
                else if (Temp > 39)
                    return "Fiebre alta: Acudir al médico. Mantener hidratación y controlar la temperatura con compresas o medicación indicada.";
                else
                    return "Estado desconocido.";
            }
        }


    }
}
