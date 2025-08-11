using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCI.MVVM.ViewModels
{
    public class TCIViewModel
    {
        public Models.TCI TCI { get; set; }

        public TCIViewModel()
        {
            TCI = new Models.TCI();
            TCI.Temp = 36.5f; // Default temperature
        }
    }
}
