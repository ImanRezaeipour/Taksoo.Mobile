using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.Mobile.Service.Parameter
{
   public class SelectedAddressParam:EntityParamBase,INotifyCollectionChanged
    {
        public string Name { get; set; }
  
        public string Address { get; set; }

        public UserParam User { get; set; }
        public double DestLat { get; set; }
        public double DestLong { get; set; }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
