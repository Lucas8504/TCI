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
                if (Temp < 35)
                {
                    return "#49B6D7";
                }
                else if (Temp > 35 && Temp <= 37.5)
                {
                    return "#407712";
                }
                else if (Temp > 37.5 && Temp <= 39)
                {
                    return "#E5611B";
                }
                else if (Temp > 39)
                {
                    return "#7F1423";
                }
                else
                    return "#49B6D7";
            }

        }

    }
}
