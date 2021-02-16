using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.ViewModel
{
    public class RegionViewModel : EntityViewModelBase
    {
        public string Name { get; set; }
        public int? TotalTime { get; set; }
        public int? TotalDistance { get; set; }


        public List<RegionBorderViewModel> RegionBorderViewModels { set; get; }
        
    }
}
