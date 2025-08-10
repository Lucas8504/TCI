using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCI.MVVM.Models
{
    class TCI
    {
        private string? grav;

        public float Temp { get; set; }

        public string? Grav 
        { 
            get
            {
                string template = "BMI: #";
                if (Temp < 35)
                {
                    return template.Replace("#", "#");
                }
                else if (Temp > 35 && Temp <= 37.5)
                {
                    return template.Replace("#", "Moderate Thinness");
                }
                else if (Temp > 35 && Temp <= 37.5)
                {
                    return template.Replace("#", "Moderate Thinness");
                }
                else if (Temp > 37.5 && Temp <= 39)
                {
                    return template.Replace("#", "Moderate Thinness");
                }
                else
                { return template.Replace("#", "Normal Weight"); }
            }
                
        }

    }
}
