using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
   
    public class CarViewModel : EntityViewModelBase
    {
       
        public string NumberPlate { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string NameColor
        {
            get => Name + " " + Color;
        }

    }
}
