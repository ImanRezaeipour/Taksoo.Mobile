using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
   public class PassengerTrunoverViewModel: EntityViewModelBase
    {

       private string _color;
        public string TournoverDateTimeShamsi { get; set; }
        public bool Type { get; set; }
        public string Description { get; set; }
        public string AmountAccount { get; set; }
        public long CurrentAccount { get; set; }
        public string TripCode { get; set; }
        public string BackgroundColor
        {
            get { return _color; }
            set
            {
                if (value != null)
                {
                    _color = value;
                    OnPropertyChanged("BackgroundColor");
                }
            } }


        public Guid UserId { get; set; }
    }
}
