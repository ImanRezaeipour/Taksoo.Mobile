using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
   public class PassenrMessageViewModel: EntityViewModelBase
    {

        public string content { get; set; }
        public string Content {
            get { return content; }
            set {
                if (value != null)
                {
                    content = value;
                    OnPropertyChanged("Content");
                } }
        }

    }
}
